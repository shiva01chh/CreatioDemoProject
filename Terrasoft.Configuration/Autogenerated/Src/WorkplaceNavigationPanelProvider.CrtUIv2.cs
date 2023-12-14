namespace Terrasoft.Configuration.NavigationMenu
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using global::Common.Logging;
	using Terrasoft.Common;
	using Core;
	using Core.Factories;
	using Terrasoft.Configuration.Section;
	using Terrasoft.Configuration.Workplace;

	[DefaultBinding(typeof(IWorkplaceNavigationPanelProvider), Name = "WorkplaceNavigationPanelProvider")]
	public class WorkplaceNavigationPanelProvider : IWorkplaceNavigationPanelProvider
	{

		#region Constants: Private

		private const string AllAppsGroupId = "All-apps";

		#endregion

		#region Fields: Private

		private readonly string _iconBackgroundColor = string.Empty; 
		private readonly IDictionary<string, NavigationMenuItem> _allAppsMenuItems 
			= new Dictionary<string, NavigationMenuItem>();
		private ILog _log;
		private ConfigurationSectionHelper _configurationSectionHelper;
		private IConfigurationDataRelatedPagesApplier _configurationDataRelatedPagesApplier;

		private ILog Log => _log ?? (_log = LogManager.GetLogger(typeof(WorkplaceNavigationPanelProvider)));

		#endregion
		
		#region Properties: Private

		private UserConnection UserConnection { get; }

		private string _homePageSideBarImage;
		private string HomePageSidebarImage {
			get {
				if (!_homePageSideBarImage.IsNullOrEmpty()) {
					return _homePageSideBarImage;
				}
				ClientUnitSchema homePageClientUnit = 
					UserConnection.ClientUnitSchemaManager.FindInstanceByName("SectionMenuModule");
				_homePageSideBarImage =	ImageUrlBuilder.GetClientUnitImageUrl("SectionMenuModule", 
				"HomePageSidebarImage", homePageClientUnit.SchemaManager.GetHash());
				return _homePageSideBarImage;
			}
		}

		private ISectionManager _sectionManager =>
			ClassFactory.Get<ISectionManager>(new ConstructorArgument("uc", UserConnection),
				new ConstructorArgument("sectionType", UserConnection.CurrentUser.ConnectionType.ToString()));

		#endregion

		#region Constructors: Public

		public WorkplaceNavigationPanelProvider(UserConnection userConnection) {
			UserConnection = userConnection;
			_configurationSectionHelper = ClassFactory.Get<ConfigurationSectionHelper>(
				new ConstructorArgument("userConnection", UserConnection));
			_configurationDataRelatedPagesApplier = ClassFactory.Get<IConfigurationDataRelatedPagesApplier>();
		}

		#endregion
		
		#region Methods: Private

		private NavigationMenuItem GetNavigationMenuItem(Guid uid, string name, LocalizableString caption) {
			return new NavigationMenuItem {
				Caption = caption,
				Id = uid.ToString(),
				IconBackgroundColor = _iconBackgroundColor,
				IconUrl = HomePageSidebarImage,
				Name = name,
				Type = WorkplaceNavigationItemType.Schema.ToString().ToLower()
			};
		}

		private LocalizableString _homePageCaption;

		private LocalizableString HomePageCaption => _homePageCaption ?? (_homePageCaption = new LocalizableString(UserConnection.Workspace.ResourceStorage,
		"SectionMenuModule", "LocalizableStrings.HomePageTitle.Value"));


		private bool GetIsAvailableSection(Section section) {
			if (UserConnection.CurrentUser.ConnectionType != UserType.SSP) {
				return true;
			}
			return UserConnection.DBSecurityEngine.GetIsAvailableOnSsp(section.Code);
		}

		private Dictionary<Guid, NavigationMenuGroup> LoadGroups() {
			List<Workplace> workplaces = GetWorkplaces().OrderBy(workplace => workplace.Position).ToList();
			if (workplaces.IsNullOrEmpty()) {
				Log.Info($"Could not find workplaces for user with Id {UserConnection.CurrentUser.Id}");
			}
			var result = new Dictionary<Guid, NavigationMenuGroup>();
			workplaces.ForEach(workplace => ProcessSysWorkplaceEntity(workplace, result));
			return result;
		}

		private void LoadItems(IReadOnlyDictionary<Guid, NavigationMenuGroup> groups) {
			groups.ForEach(workplace => {
				List<Section> sections = _sectionManager.GetSectionsInWorkplace(workplace.Key, false).Where(GetIsAvailableSection).ToList();
				if (sections.IsNullOrEmpty()) {
					Log.Info($"Could not find sections for workplace with Id {workplace.Key} " +
						$"for user with Id {UserConnection.CurrentUser.Id}");
				}
				sections.ForEach(section => {
					var menuItem = new NavigationMenuItem {
						Caption = section.Caption,
						Id = section.Id.ToString(),
						IconBackgroundColor = section.IconBackground,
						Name = section.SchemaName,
						IconUrl = GetIconUrl(section.Image32Id),
						Type = GetWorkplaceNavigationItemType(section.IsModule)
					};
					workplace.Value.Sections.Add(menuItem);
					AddAllAppsMenuItem(menuItem);
				});
			});
		}

		private void AddAllAppsMenuItem(NavigationMenuItem menuItem) {
			string sysModuleId = menuItem.Id;
			if (!_allAppsMenuItems.ContainsKey(sysModuleId)) {
				_allAppsMenuItems.Add(sysModuleId, menuItem);
			}
		}

		private void ProcessSysWorkplaceEntity(Workplace workplace, IDictionary<Guid, NavigationMenuGroup> menuGroups) {
			workplace.GetSectionIds();
			Guid id = workplace.Id;
			menuGroups[id] = new NavigationMenuGroup {
				Caption = workplace.Name,
				Id = id.ToString(),
				Sections = new List<NavigationMenuItem>()
			};
			Guid? homePageUId = workplace.HomePageUId;
			if (!homePageUId.HasValue) {
				return;
			}
			ISchemaManagerItem<ClientUnitSchema> clientUnitSchema = 
				UserConnection.ClientUnitSchemaManager.FindItemByUId(homePageUId.Value);
			if (clientUnitSchema == null) {
				return;
			}
			NavigationMenuItem homePageMenuItem = GetNavigationMenuItem(homePageUId.Value, clientUnitSchema.Name, HomePageCaption);
			menuGroups[id].Sections.Add(homePageMenuItem);
			NavigationMenuItem allAppsHomePageMenuItem = GetNavigationMenuItem(homePageUId.Value, clientUnitSchema.Name, clientUnitSchema.Caption);
			AddAllAppsMenuItem(allAppsHomePageMenuItem);
		}
		
		private IEnumerable<Workplace> GetWorkplaces() {
			var workplaceManager = ClassFactory.Get<IWorkplaceManager>(new ConstructorArgument("uc", UserConnection));
			workplaceManager.ReloadWorkplaces();
			return workplaceManager.GetCurrentUserWorkplaces(BaseConsts.BrowserClientTypeId);
		}

		private static string GetIconUrl(Guid iconId) {
			return iconId == Guid.Empty ? string.Empty : $"/img/entity/hash/SysImage/Data/{iconId}";
		}

		private static string GetWorkplaceNavigationItemType(bool isModule) {
			return isModule
				? WorkplaceNavigationItemType.Module.ToString().ToLower()
				: WorkplaceNavigationItemType.Schema.ToString().ToLower();
		}

		private NavigationMenuGroup CreateAllAppsMenuGroup() {
			return new NavigationMenuGroup {
				Id = AllAppsGroupId,
				Caption = new LocalizableString(UserConnection.Workspace.ResourceStorage,
					"WorkplaceNavigationPanelProvider",
					"LocalizableStrings.AllAppsTitle.Value"),
				Sections = GetAllAppsMenuItems()
			};
		}

		private IList<NavigationMenuItem> GetAllAppsMenuItems() {
			IEnumerable<ModuleStructure> modulesStructureValues = _configurationSectionHelper.GetSchemaModuleStructures(UserConnection);
			List<ModuleStructure> modulesStructureInAllApps = modulesStructureValues.Where(x => 
				_allAppsMenuItems.ContainsKey(x.ModuleId)).ToList();
			return _allAppsMenuItems.Values
				.Where(menuItem => NeedShowMenuItemInAllApps(modulesStructureInAllApps, menuItem.Id))
				.OrderBy(menuItem => menuItem.Caption)
				.ToList();
		}

		private bool NeedShowMenuItemInAllApps(IList<ModuleStructure> modulesStructureInAllApps, string itemId) {
			ModuleStructure moduleItem =
				modulesStructureInAllApps.FirstOrDefault(module => module.ModuleId == itemId);
			if (moduleItem == null) {
				return true;
			}
			string entitySchemaName = moduleItem.EntitySchemaName;
			IEnumerable<ModuleStructure> structureByEntity =
				modulesStructureInAllApps.Where(module => module.EntitySchemaName == entitySchemaName).ToList();
			IEnumerable<ModuleStructure> duplicateModuleItems =
				structureByEntity.Where(module => module.ModuleId != itemId);
			if (!duplicateModuleItems.Any()) {
				return true;
			}
			bool use7XSection = _configurationDataRelatedPagesApplier.Use7XSection(entitySchemaName);
			if (use7XSection) {
				bool is7XSection = !moduleItem.Section8X;
				return is7XSection || structureByEntity.All(x => x.Section8X);
			} else {
				bool is8XSection = moduleItem.Section8X;
				return is8XSection || structureByEntity.All(x => !x.Section8X);
			}
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc />
		public IEnumerable<NavigationMenuGroup> Load() {
			Dictionary<Guid, NavigationMenuGroup> groups = LoadGroups();
			LoadItems(groups);
			return new []{ CreateAllAppsMenuGroup() }.Union(groups.Values);
		}

		#endregion

	}
}






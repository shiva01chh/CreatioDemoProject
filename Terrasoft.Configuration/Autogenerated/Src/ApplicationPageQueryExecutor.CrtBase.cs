namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Applications.Abstractions;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: ApplicationPageQueryExecutor

	/// <summary>
	/// Query executor for pages of application.
	/// </summary>
	[DefaultBinding(typeof(IEntityQueryExecutor), Name = "ApplicationPageQueryExecutor")]
	public class ApplicationPageQueryExecutor : BaseApplicationSchemaQueryExecutor<ClientUnitSchema>
	{

		#region Fields: Private

		private static readonly Guid _pageWithTabsTemplateUId = new Guid("05477cbd-1ca8-4658-b427-971fc58bbc08");
		private static readonly Guid _pageWithTabsFreedomTemplateUId = new Guid("3b2e117f-8c6b-4ca5-80a2-7ebb497cddf9");
		private static readonly Guid _pageWithTabsTemplateImageId = new Guid("bb9cbd6d-3b98-4002-a41f-7b70fc9762e5");
		private static readonly Guid _pageWithRightAreaAndTabsTemplateUId = new Guid("98ca84c1-5f6a-4a55-9c3f-d668ce12378c");
		private static readonly Guid _pageWithRightAreaAndTabsFreedomTemplateUId = new Guid("5f8dd430-acf2-4e1a-80c8-77cf57e245ce");
		private static readonly Guid _pageWithRightAreaAndTabsTemplateImageId = new Guid("bdb1be8f-c4e3-41e0-a44b-bd8947a08b7c");
		private static readonly Guid _pageWithTopAreaAndTabsTemplateUId = new Guid("3176536a-77ac-403a-932e-28dd4b50e4e6");
		private static readonly Guid _pageWithTopAreaAndTabsFreedomTemplateUId = new Guid("27e1b215-163a-4b82-b0a6-9872a8dde6e4");
		private static readonly Guid _pageWithTopAreaAndTabsTemplateImageId = new Guid("78b0d4c5-891d-49a3-a364-0afc10f2a93a");
		private static readonly Guid _pageWithLeftAreaTemplateUId = new Guid("0f8eb896-7b62-4dfa-bd55-a414f50932a7");
		private static readonly Guid _pageWithLeftAreaTemplateImageId = new Guid("db72ade9-dd9a-4492-bf4f-415c6e8c4dca");
		private static readonly Guid _pageWithAreaTemplateUId = new Guid("e4b45c7b-cfe3-4ee4-b56b-502f690db0d5");
		private static readonly Guid _pageWithAreaFreedomTemplateUId = new Guid("97e48060-149c-408f-9f17-8ba82c400249");
		private static readonly Guid _pageWithAreaTemplateImageId = new Guid("4839a18f-637a-4189-be5c-85f20a65cfe9");
		private static readonly Guid _pageWithActionDashboardTemplateUId = new Guid("126f25c9-1c1d-43b3-9372-ac1903348ef4");
		private static readonly Guid _pageWithActionDashboardFreedomTemplateUId = new Guid("f3600f35-4e3d-4dd3-882e-3404ab515e38");
		private static readonly Guid _pageWithActionDashboardTemplateImageId = new Guid("4826a502-3cd6-4454-a8bf-4679b7ffde2c");
		private static readonly Guid _baseHomePageUId = new Guid("0c5cfb7a-1ed9-41b8-905e-9a38c6915550");
		private static readonly Guid _baseHomePageImageId = new Guid("318d1004-01dc-4bfa-912d-6cf85f73535b");
		private static readonly Guid _baseSectionTemplateUId = new Guid("9d0fd8cc-431b-455a-beeb-3bb93c64cb38");
		private static readonly Guid _baseSectionTemplateImageId = new Guid("54590275-d5f0-401e-9e33-d2fbbc496100");
		private static readonly Guid _blankPageTemplateUId = new Guid("f691e828-0b36-42a7-898f-c337e9af67d0");
		private static readonly Guid _blankPageTemplateImageId = new Guid("f9813cc3-2843-4819-982b-61c9f9ec1da9");
		private static readonly Guid _listFreedomTemplateUId = new Guid("3F1F3F38-A0A4-4549-B895-249FB08F554A");
		private static readonly Guid _listFreedomTemplateImageId = new Guid("54590275-d5f0-401e-9e33-d2fbbc496100");
		private static readonly Guid _baseMiniPageTemplatePageUId = new Guid("ecdcc8ff-272c-4957-9381-7d74ce17e140");
		private static readonly Guid _baseMiniPageTemplateImageId = new Guid("461bc8f5-b353-3632-9c0d-c5f1bae967ac");
		private static readonly Dictionary<Guid, Guid> _pageImageDictionary = new Dictionary<Guid, Guid> {
			{ _pageWithTabsTemplateUId, _pageWithTabsTemplateImageId },
			{ _pageWithActionDashboardFreedomTemplateUId, _pageWithActionDashboardTemplateImageId },
			{ _pageWithTabsFreedomTemplateUId, _pageWithTabsTemplateImageId },
			{ _pageWithRightAreaAndTabsTemplateUId, _pageWithRightAreaAndTabsTemplateImageId },
			{ _pageWithRightAreaAndTabsFreedomTemplateUId, _pageWithRightAreaAndTabsTemplateImageId },
			{ _pageWithTopAreaAndTabsTemplateUId, _pageWithTopAreaAndTabsTemplateImageId },
			{ _pageWithTopAreaAndTabsFreedomTemplateUId, _pageWithTopAreaAndTabsTemplateImageId },
			{ _pageWithLeftAreaTemplateUId, _pageWithLeftAreaTemplateImageId },
			{ _pageWithAreaTemplateUId, _pageWithAreaTemplateImageId },
			{ _pageWithAreaFreedomTemplateUId, _pageWithAreaTemplateImageId },
			{ _pageWithActionDashboardTemplateUId, _pageWithActionDashboardTemplateImageId },
			{ _baseHomePageUId, _baseHomePageImageId },
			{ _baseSectionTemplateUId, _baseSectionTemplateImageId },
			{ _blankPageTemplateUId, _blankPageTemplateImageId },
			{ _listFreedomTemplateUId, _listFreedomTemplateImageId },
			{ _baseMiniPageTemplatePageUId, _baseMiniPageTemplateImageId },
		};

		#endregion

		#region Constructors: Public

		public ApplicationPageQueryExecutor(UserConnection userConnection, IAppManager appManager)
			: base(userConnection, appManager) {
		}

		#endregion

		#region Methods: Private

		private void SetImageForEntityItem(IEntity entity, ISchemaManagerItem<ClientUnitSchema> schemaManagerItem) {
			Guid? previewImageId = GetPreviewImageIdBySchemaItem(schemaManagerItem) 
				?? GetPreviewImageIdByParentSchemas(schemaManagerItem);
			SetPreviewImage(entity, previewImageId);
		}

		private static Guid? GetPreviewImageIdBySchemaItem(ISchemaManagerItem<ClientUnitSchema> schemaManagerItem) {
			ISchemaManagerItem<ClientUnitSchema>[] baseSchemaManagerItems = { schemaManagerItem };
			return GetPreviewImageId(baseSchemaManagerItems);
		}

		private Guid? GetPreviewImageIdByParentSchemas(ISchemaManagerItem<ClientUnitSchema> schemaManagerItem) {
			List<ISchemaManagerItem<ClientUnitSchema>> baseSchemaManagerItems =
				UserConnection.ClientUnitSchemaManager.GetAllParents(schemaManagerItem).ToList();
			return GetPreviewImageId(baseSchemaManagerItems);
		}

		private static Guid? GetPreviewImageId(IReadOnlyCollection<ISchemaManagerItem<ClientUnitSchema>> baseSchemaManagerItems) {
			foreach (KeyValuePair<Guid, Guid> pageImagePair in _pageImageDictionary) {
				bool isCollectionContainsSchema = CheckIfCollectionContainsSchema(baseSchemaManagerItems, pageImagePair.Key);
				if (isCollectionContainsSchema) {
					return pageImagePair.Value;
				}
			}
			return null;
		}

		private static void SetPreviewImage(IEntity entity, Guid? previewImageId) {
			if (previewImageId.IsNullOrEmpty()) {
				return;
			}
			entity.SetColumnValue("PreviewImageId", previewImageId);
		}

		private static bool CheckIfCollectionContainsSchema(
				IEnumerable<ISchemaManagerItem<ClientUnitSchema>> schemaManagerItems, Guid schemaUId) {
			return schemaManagerItems.Any(x => x.UId == schemaUId);
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// <inheritdoc />
		/// </summary>
		protected override string ResultEntitySchemaName => "ApplicationPage";

		/// <summary>
		/// <inheritdoc />
		/// </summary>
		protected override SchemaManager<ClientUnitSchema> GetSchemaManager() => UserConnection.ClientUnitSchemaManager;

		/// <summary>
		/// <inheritdoc />
		/// </summary>
		protected override Func<ISchemaManagerItem<ClientUnitSchema>, bool>
				GetManagerItemsFilter(EntitySchemaQueryFilterCollection filters) {
			Func<ISchemaManagerItem<ClientUnitSchema>, bool> baseFilter = base.GetManagerItemsFilter(filters);
			ClientUnitSchemaType schemaType = GetRequiredColumnFilterValue<ClientUnitSchemaType>(filters, "SchemaType");
			return schemaManagerItem => {
				ExtraProperty property = schemaManagerItem.ExtraProperties.FindByName("SchemaType");
				bool isSameSchemaType = Convert.ToInt32(property.Value) == (int)schemaType;
				return isSameSchemaType && baseFilter?.Invoke(schemaManagerItem) != false;
			};
		}

		/// <summary>
		/// <inheritdoc />
		/// </summary>
		protected override void MapAdditionalColumns(Entity entity, ISchemaManagerItem<ClientUnitSchema> schemaManagerItem) {
			SetImageForEntityItem(entity, schemaManagerItem);
		}

		#endregion

	}

	#endregion

}















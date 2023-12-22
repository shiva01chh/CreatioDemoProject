namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Newtonsoft.Json;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using CoreSysSettings = Core.Configuration.SysSettings;
	using Terrasoft.Core.Entities;
	using Terrasoft.UI.WebControls.ResourceHandlers;

	#region Class: CurrentSysUserProfileResolver

	public class CurrentSysUserProfileResolver
	{

		#region Constants: Private

		private const string EnablePopupsKey = "DesktopPopupNotification";

		#endregion

		#region Fields: Private

		private readonly UserConnection _userConnection;

		private readonly string _entitySchemaName = "SysUserProfile";

		#endregion

		#region Properties: Protected

		protected UserConnection UserConnection => _userConnection;

		protected EntitySchemaManager EntitySchemaManager => UserConnection.EntitySchemaManager;

		#endregion

		#region Properties: Public

		public EntitySchema EntitySchema => EntitySchemaManager.GetInstanceByName(_entitySchemaName);

		#endregion

		#region Constructors: Public

		public CurrentSysUserProfileResolver(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private bool TryGetTimeZone(Dictionary<string, object> conditions, out Entity timeZoneEntity) {
			var timeZonesSchema = UserConnection.EntitySchemaManager.GetInstanceByName("TimeZone");
			timeZoneEntity = timeZonesSchema.CreateEntity(UserConnection);
			timeZoneEntity.UseAdminRights = false;
			return timeZoneEntity.FetchFromDB(conditions);
		}

		private string ConvertServerTimeZone(string timeZoneId) {
			timeZoneId.CheckArgumentNullOrEmpty(nameof(timeZoneId));
			string windowsOrIanaTimeZoneId = timeZoneId;
			const string posix = "posix/";
			if (timeZoneId.StartsWith(posix)) {
				windowsOrIanaTimeZoneId = timeZoneId.Substring(posix.Length, timeZoneId.Length - posix.Length);
			}
			const string easternEuropeanStandardTime = "Eastern European Standard Time";
			if (string.Compare(timeZoneId, easternEuropeanStandardTime, StringComparison.OrdinalIgnoreCase) == 0) {
				windowsOrIanaTimeZoneId = "E. Europe Standard Time";
			}
			const string newEuropeKyivTimeZone = "Europe/Kyiv";
			if (string.Compare(timeZoneId, newEuropeKyivTimeZone, StringComparison.OrdinalIgnoreCase) == 0) {
				windowsOrIanaTimeZoneId = "Europe/Kiev";
			}
			return windowsOrIanaTimeZoneId;
		}
		
		private void SetTimeZone(Entity entity, string timeZoneId) {
			Dictionary<string, object> timeZoneConditions;
			string displayValue = "";
			if (timeZoneId.IsNullOrEmpty()) {
				var timeZoneSysSettingValue = CoreSysSettings.GetDefValue(UserConnection, "DefaultTimeZone");
				if (timeZoneSysSettingValue != null && (Guid)timeZoneSysSettingValue != Guid.Empty) {
					timeZoneConditions = new Dictionary<string, object> {
						{ "Id", timeZoneSysSettingValue }
					};
				} else {
					TimeZoneInfo serverTimeZoneInfo = TimeZoneInfo.Local;
					displayValue = serverTimeZoneInfo.DisplayName;
					timeZoneConditions = new Dictionary<string, object> {
						{ "Code", ConvertServerTimeZone(serverTimeZoneInfo.StandardName) }
					};
				}
			} else {
				timeZoneConditions = new Dictionary<string, object> {
					{ "Code", timeZoneId }
				};
			}
			if (!TryGetTimeZone(timeZoneConditions, out Entity timeZoneEntity)) {
				entity.LoadColumnValue("TimeZoneName", displayValue);
				timeZoneConditions = new Dictionary<string, object> {
					{ "Code", "UTC" }
				};
				if (!TryGetTimeZone(timeZoneConditions, out timeZoneEntity)) {
					return;
				}
			} else {
				displayValue = timeZoneEntity.PrimaryDisplayColumnValue;
			}
			object valueId = timeZoneEntity.PrimaryColumnValue;
			entity.LoadColumnValue("TimeZoneId", valueId);
			entity.LoadColumnValue("TimeZoneName", displayValue);
		}

		private void FillFieldsFromContact(Entity resultEntity, Guid contactId) {
			EntitySchema contactSchema = _userConnection.EntitySchemaManager.FindInstanceByName("Contact");
			Entity contact = contactSchema.CreateEntity(_userConnection);
			contact.PrimaryColumnValue = contactId;
			contact.UseAdminRights = false;
			if (!contact.FetchFromDB(new[] { "Name", "GivenName", "MiddleName", "Surname", "Photo" }, false)) {
				return;
			}
			string fullName = contact.GetTypedColumnValue<string>("Name");
			string firstName = contact.GetTypedColumnValue<string>("GivenName");
			string middleName = contact.GetTypedColumnValue<string>("MiddleName");
			string lastName = contact.GetTypedColumnValue<string>("Surname");
			resultEntity.LoadColumnValue("FullName", fullName);
			resultEntity.LoadColumnValue("FirstName", firstName);
			resultEntity.LoadColumnValue("MiddleName", middleName);
			resultEntity.LoadColumnValue("LastName", lastName);
			var contactPhotoId = contact.GetTypedColumnValue<Guid>("PhotoId");
			if (contactPhotoId.IsNotEmpty() ) {
				resultEntity.SetColumnValue("PhotoId", contactPhotoId);	
			} else {
				resultEntity.SetColumnValue("PhotoId", null);
			}
		}

		private void FillFieldsFromSysAdminUnit(Entity resultEntity, Guid currentUserId) {
			EntitySchema sysAdminUnitSchema = _userConnection.EntitySchemaManager.FindInstanceByName("SysAdminUnit");
			Entity sysAdminUnitEntity = sysAdminUnitSchema.CreateEntity(_userConnection);
			sysAdminUnitEntity.PrimaryColumnValue = currentUserId;
			if(_userConnection.CurrentUser.ConnectionType == UserType.SSP) {
				sysAdminUnitEntity.UseAdminRights = false;
			}
			if (!sysAdminUnitEntity.FetchFromDB(new[] { "Email", "Name", "SysCulture", "DateTimeFormat", "TimeZoneId" },
					true)) {
				return;
			}
			resultEntity.SetColumnValue("Email", sysAdminUnitEntity.GetColumnValue("Email"));
			var timeZoneId = sysAdminUnitEntity.GetTypedColumnValue<string>("TimeZoneId");
			SetTimeZone(resultEntity, timeZoneId);
			resultEntity.LoadColumnValue("Username", sysAdminUnitEntity.GetColumnValue("Name"));
			var cultureId = sysAdminUnitEntity.GetTypedColumnValue<Guid>("SysCultureId");
			if (cultureId.IsNotEmpty()) {
				FillFieldsFromSysCulture(resultEntity, cultureId);
			}
			var dateTimeFormatId = sysAdminUnitEntity.GetTypedColumnValue<Guid>("DateTimeFormatId");
			if (dateTimeFormatId.IsEmpty()) {
				if (TryLoadSysCultureWithLanguage(cultureId, out Entity sysCultureWithLanguage)) {
					SetColumnBothValuesByName(sysCultureWithLanguage, resultEntity, "Language", "DateTimeFormat");
				}
			} else {
				SetColumnBothValuesByName(sysAdminUnitEntity, resultEntity, "DateTimeFormat");
			}
		}

		private bool TryLoadSysCultureWithLanguage(Guid cultureId, out Entity sysCultureWithLanguage) {
			EntitySchema sysCultureSchema = _userConnection.EntitySchemaManager.FindInstanceByName("SysCulture");
			sysCultureWithLanguage = sysCultureSchema.CreateEntity(_userConnection);
			sysCultureWithLanguage.PrimaryColumnValue = cultureId;
			sysCultureWithLanguage.UseAdminRights = false;
			if (!sysCultureWithLanguage.FetchFromDB(new[] { "Language" }, true)) {
				return false;
			}
			return true;
		}

		private void FillFieldsFromSysCulture(Entity resultEntity, Guid cultureId) {
			if (!TryLoadSysCultureWithLanguage(cultureId, out Entity sysCulture)) {
				return;
			}
			SetColumnBothValuesByName(sysCulture, resultEntity, "Language");
		}

		private void FillFieldsFromSysProfileData(Entity resultEntity) {
			var enablePopupsResourceHandler = new UserProfileResourceHandler(_userConnection, EnablePopupsKey);
			byte[] byteData = enablePopupsResourceHandler.Fetch();
			string textData = Encoding.UTF8.GetString(byteData);
			var definition = new { Enabled = false };
			var jsonData = JsonConvert.DeserializeAnonymousType(textData, definition);
			bool enabled = jsonData.Enabled;
			resultEntity.LoadColumnValue("EnablePopups", enabled);
		}
		
		private void FillFieldsFromSysSettings(Entity resultEntity) {
			if (CoreSysSettings.TryGetValue(_userConnection, "DisableAdvancedVisualEffects", out object value)) {
				resultEntity.LoadColumnValue("DisableAdvancedVisualEffects", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected void SetColumnBothValuesByName(Entity sourceEntity, Entity destination, string columnName) {
			SetColumnBothValuesByName(sourceEntity, destination, columnName, columnName);
		}
		
		protected void SetColumnBothValuesByName(Entity sourceEntity, Entity destination, string sourceColumnName,
				string destinationColumnName) {
			EntitySchema sourceSchema = sourceEntity.Schema;
			EntitySchemaColumn sourceColumn = sourceSchema.Columns.FindByName(sourceColumnName);
			object valueId = sourceEntity.GetColumnValue(sourceColumn);
			string displayValue = sourceEntity.GetColumnDisplayValue(sourceColumn);
			destination.LoadColumnValue(destinationColumnName+"Id", valueId);
			destination.LoadColumnValue(destinationColumnName+"Name", displayValue);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns SysUserProfile Entity filled with the current user properties.
		/// </summary>
		/// <returns>SysUserProfile entity.</returns>
		public virtual Entity GetCurrentUserProfile() {
			SysUserInfo currentUser = _userConnection.CurrentUser;
			Entity entity = EntitySchema.CreateEntity(UserConnection);
			Guid currentUserId = currentUser.Id;
			entity.LoadColumnValue("Id", currentUserId);
			FillFieldsFromContact(entity, currentUser.ContactId);
			FillFieldsFromSysAdminUnit(entity, currentUserId);
			FillFieldsFromSysProfileData(entity);
			FillFieldsFromSysSettings(entity);
			return entity;
		}

		#endregion

	}

	#endregion

}

















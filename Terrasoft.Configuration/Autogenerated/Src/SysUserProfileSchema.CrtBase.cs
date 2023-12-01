namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: SysUserProfileSchema

	/// <exclude/>
	[IsVirtual]
	public class SysUserProfileSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysUserProfileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysUserProfileSchema(SysUserProfileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysUserProfileSchema(SysUserProfileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390");
			RealUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390");
			Name = "SysUserProfile";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("400566f7-77a1-4986-aa86-a353b8b6c452");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateUsernameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5eae7609-959b-14e1-eaeb-cb578ea9732e")) == null) {
				Columns.Add(CreateDateTimeFormatColumn());
			}
			if (Columns.FindByUId(new Guid("aa5857f2-bd1f-d71d-56ee-0023d8609e98")) == null) {
				Columns.Add(CreateEmailColumn());
			}
			if (Columns.FindByUId(new Guid("a134b236-83e3-567e-3dfa-0574e77ba675")) == null) {
				Columns.Add(CreatePhotoColumn());
			}
			if (Columns.FindByUId(new Guid("140a7094-abb0-e28d-e5dc-24ed7a960df3")) == null) {
				Columns.Add(CreateFullNameColumn());
			}
			if (Columns.FindByUId(new Guid("74bb4924-91b6-17f4-144e-555c552ada8d")) == null) {
				Columns.Add(CreateTimeZoneColumn());
			}
			if (Columns.FindByUId(new Guid("64a640d6-ad31-07db-f1bd-bcb3d684c53a")) == null) {
				Columns.Add(CreateEnablePopupsColumn());
			}
			if (Columns.FindByUId(new Guid("dd203f0d-9267-0b7c-4729-2328a70520ae")) == null) {
				Columns.Add(CreateLanguageColumn());
			}
			if (Columns.FindByUId(new Guid("b4d51aee-6883-0d93-a4ca-c2da756b3f13")) == null) {
				Columns.Add(CreateLastNameColumn());
			}
			if (Columns.FindByUId(new Guid("33ca712f-dfb8-ee74-7aee-27ee1537f0d9")) == null) {
				Columns.Add(CreateMiddleNameColumn());
			}
			if (Columns.FindByUId(new Guid("41bdb5c9-f512-ab61-8bee-f3fa9f900eae")) == null) {
				Columns.Add(CreateFirstNameColumn());
			}
			if (Columns.FindByUId(new Guid("35b4f3e2-4ebe-f515-0721-806f18407f52")) == null) {
				Columns.Add(CreateDisableAdvancedVisualEffectsColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDateTimeFormatColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5eae7609-959b-14e1-eaeb-cb578ea9732e"),
				Name = @"DateTimeFormat",
				ReferenceSchemaUId = new Guid("2f96cb61-7e14-41e5-980a-bcb856edab51"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				ModifiedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				CreatedInPackageId = new Guid("400566f7-77a1-4986-aa86-a353b8b6c452"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("EmailText")) {
				UId = new Guid("aa5857f2-bd1f-d71d-56ee-0023d8609e98"),
				Name = @"Email",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				ModifiedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				CreatedInPackageId = new Guid("400566f7-77a1-4986-aa86-a353b8b6c452"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateUsernameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d20031bc-f8ba-a4f4-6210-36f26f5de359"),
				Name = @"Username",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				ModifiedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				CreatedInPackageId = new Guid("400566f7-77a1-4986-aa86-a353b8b6c452")
			};
		}

		protected virtual EntitySchemaColumn CreatePhotoColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("a134b236-83e3-567e-3dfa-0574e77ba675"),
				Name = @"Photo",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				ModifiedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				CreatedInPackageId = new Guid("400566f7-77a1-4986-aa86-a353b8b6c452"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateFullNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("140a7094-abb0-e28d-e5dc-24ed7a960df3"),
				Name = @"FullName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				ModifiedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				CreatedInPackageId = new Guid("400566f7-77a1-4986-aa86-a353b8b6c452"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateTimeZoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("74bb4924-91b6-17f4-144e-555c552ada8d"),
				Name = @"TimeZone",
				ReferenceSchemaUId = new Guid("a394a569-92d6-44d0-bdda-fa0578373b4f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				ModifiedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				CreatedInPackageId = new Guid("58864000-91f9-447b-9f45-be75e7e0fa19"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateEnablePopupsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("64a640d6-ad31-07db-f1bd-bcb3d684c53a"),
				Name = @"EnablePopups",
				CreatedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				ModifiedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				CreatedInPackageId = new Guid("dfe26092-42fe-43d1-a763-4b74135d04ec")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dd203f0d-9267-0b7c-4729-2328a70520ae"),
				Name = @"Language",
				ReferenceSchemaUId = new Guid("2f96cb61-7e14-41e5-980a-bcb856edab51"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				ModifiedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				CreatedInPackageId = new Guid("b5578e4f-2732-4fb5-8de7-483c06c796b9"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateLastNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("b4d51aee-6883-0d93-a4ca-c2da756b3f13"),
				Name = @"LastName",
				CreatedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				ModifiedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				CreatedInPackageId = new Guid("b5578e4f-2732-4fb5-8de7-483c06c796b9"),
				IsFormatValidated = true
			};
		}

		protected virtual EntitySchemaColumn CreateMiddleNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("33ca712f-dfb8-ee74-7aee-27ee1537f0d9"),
				Name = @"MiddleName",
				CreatedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				ModifiedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				CreatedInPackageId = new Guid("b5578e4f-2732-4fb5-8de7-483c06c796b9"),
				IsFormatValidated = true
			};
		}

		protected virtual EntitySchemaColumn CreateFirstNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("41bdb5c9-f512-ab61-8bee-f3fa9f900eae"),
				Name = @"FirstName",
				CreatedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				ModifiedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				CreatedInPackageId = new Guid("b5578e4f-2732-4fb5-8de7-483c06c796b9"),
				IsFormatValidated = true
			};
		}

		protected virtual EntitySchemaColumn CreateDisableAdvancedVisualEffectsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("35b4f3e2-4ebe-f515-0721-806f18407f52"),
				Name = @"DisableAdvancedVisualEffects",
				CreatedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				ModifiedInSchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390"),
				CreatedInPackageId = new Guid("77cba790-25e3-4aa1-b888-a6dbf0ea113a")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysUserProfile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysUserProfile_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysUserProfileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysUserProfileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15e02b73-2eb5-4c03-8dee-739001875390"));
		}

		#endregion

	}

	#endregion

	#region Class: SysUserProfile

	/// <summary>
	/// User profile.
	/// </summary>
	public class SysUserProfile : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysUserProfile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysUserProfile";
		}

		public SysUserProfile(SysUserProfile source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid DateTimeFormatId {
			get {
				return GetTypedColumnValue<Guid>("DateTimeFormatId");
			}
			set {
				SetColumnValue("DateTimeFormatId", value);
				_dateTimeFormat = null;
			}
		}

		/// <exclude/>
		public string DateTimeFormatName {
			get {
				return GetTypedColumnValue<string>("DateTimeFormatName");
			}
			set {
				SetColumnValue("DateTimeFormatName", value);
				if (_dateTimeFormat != null) {
					_dateTimeFormat.Name = value;
				}
			}
		}

		private SysLanguage _dateTimeFormat;
		/// <summary>
		/// Date & time format.
		/// </summary>
		public SysLanguage DateTimeFormat {
			get {
				return _dateTimeFormat ??
					(_dateTimeFormat = LookupColumnEntities.GetEntity("DateTimeFormat") as SysLanguage);
			}
		}

		/// <summary>
		/// Email.
		/// </summary>
		public string Email {
			get {
				return GetTypedColumnValue<string>("Email");
			}
			set {
				SetColumnValue("Email", value);
			}
		}

		/// <summary>
		/// User name.
		/// </summary>
		public string Username {
			get {
				return GetTypedColumnValue<string>("Username");
			}
			set {
				SetColumnValue("Username", value);
			}
		}

		/// <exclude/>
		public Guid PhotoId {
			get {
				return GetTypedColumnValue<Guid>("PhotoId");
			}
			set {
				SetColumnValue("PhotoId", value);
				_photo = null;
			}
		}

		/// <exclude/>
		public string PhotoName {
			get {
				return GetTypedColumnValue<string>("PhotoName");
			}
			set {
				SetColumnValue("PhotoName", value);
				if (_photo != null) {
					_photo.Name = value;
				}
			}
		}

		private SysImage _photo;
		/// <summary>
		/// Photo.
		/// </summary>
		public SysImage Photo {
			get {
				return _photo ??
					(_photo = LookupColumnEntities.GetEntity("Photo") as SysImage);
			}
		}

		/// <summary>
		/// Full name.
		/// </summary>
		public string FullName {
			get {
				return GetTypedColumnValue<string>("FullName");
			}
			set {
				SetColumnValue("FullName", value);
			}
		}

		/// <exclude/>
		public Guid TimeZoneId {
			get {
				return GetTypedColumnValue<Guid>("TimeZoneId");
			}
			set {
				SetColumnValue("TimeZoneId", value);
				_timeZone = null;
			}
		}

		/// <exclude/>
		public string TimeZoneName {
			get {
				return GetTypedColumnValue<string>("TimeZoneName");
			}
			set {
				SetColumnValue("TimeZoneName", value);
				if (_timeZone != null) {
					_timeZone.Name = value;
				}
			}
		}

		private TimeZone _timeZone;
		/// <summary>
		/// Time Zone.
		/// </summary>
		public TimeZone TimeZone {
			get {
				return _timeZone ??
					(_timeZone = LookupColumnEntities.GetEntity("TimeZone") as TimeZone);
			}
		}

		/// <summary>
		/// Turn on browser notifications.
		/// </summary>
		public bool EnablePopups {
			get {
				return GetTypedColumnValue<bool>("EnablePopups");
			}
			set {
				SetColumnValue("EnablePopups", value);
			}
		}

		/// <exclude/>
		public Guid LanguageId {
			get {
				return GetTypedColumnValue<Guid>("LanguageId");
			}
			set {
				SetColumnValue("LanguageId", value);
				_language = null;
			}
		}

		/// <exclude/>
		public string LanguageName {
			get {
				return GetTypedColumnValue<string>("LanguageName");
			}
			set {
				SetColumnValue("LanguageName", value);
				if (_language != null) {
					_language.Name = value;
				}
			}
		}

		private SysLanguage _language;
		/// <summary>
		/// Language.
		/// </summary>
		public SysLanguage Language {
			get {
				return _language ??
					(_language = LookupColumnEntities.GetEntity("Language") as SysLanguage);
			}
		}

		/// <summary>
		/// Last name.
		/// </summary>
		public string LastName {
			get {
				return GetTypedColumnValue<string>("LastName");
			}
			set {
				SetColumnValue("LastName", value);
			}
		}

		/// <summary>
		/// Middle name.
		/// </summary>
		public string MiddleName {
			get {
				return GetTypedColumnValue<string>("MiddleName");
			}
			set {
				SetColumnValue("MiddleName", value);
			}
		}

		/// <summary>
		/// First name.
		/// </summary>
		public string FirstName {
			get {
				return GetTypedColumnValue<string>("FirstName");
			}
			set {
				SetColumnValue("FirstName", value);
			}
		}

		/// <summary>
		/// Disable advanced visual effects.
		/// </summary>
		public bool DisableAdvancedVisualEffects {
			get {
				return GetTypedColumnValue<bool>("DisableAdvancedVisualEffects");
			}
			set {
				SetColumnValue("DisableAdvancedVisualEffects", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysUserProfile_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysUserProfile(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysUserProfile_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysUserProfile_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SysUserProfile
	{

		public SysUserProfile_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysUserProfile_CrtBaseEventsProcess";
			SchemaUId = new Guid("15e02b73-2eb5-4c03-8dee-739001875390");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("15e02b73-2eb5-4c03-8dee-739001875390");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: SysUserProfile_CrtBaseEventsProcess

	/// <exclude/>
	public class SysUserProfile_CrtBaseEventsProcess : SysUserProfile_CrtBaseEventsProcess<SysUserProfile>
	{

		public SysUserProfile_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysUserProfile_CrtBaseEventsProcess

	public partial class SysUserProfile_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysUserProfileEventsProcess

	/// <exclude/>
	public class SysUserProfileEventsProcess : SysUserProfile_CrtBaseEventsProcess
	{

		public SysUserProfileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


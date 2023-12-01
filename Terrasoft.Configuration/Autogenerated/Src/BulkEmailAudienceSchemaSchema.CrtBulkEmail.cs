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

	#region Class: BulkEmailAudienceSchemaSchema

	/// <exclude/>
	public class BulkEmailAudienceSchemaSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BulkEmailAudienceSchemaSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailAudienceSchemaSchema(BulkEmailAudienceSchemaSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailAudienceSchemaSchema(BulkEmailAudienceSchemaSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32");
			RealUId = new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32");
			Name = "BulkEmailAudienceSchema";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateDisplayNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d7aceffd-9944-46cd-a104-ad18a399a1a1")) == null) {
				Columns.Add(CreateEntityObjectColumn());
			}
			if (Columns.FindByUId(new Guid("603140c3-34d8-4ada-afa1-e521f2a6ae63")) == null) {
				Columns.Add(CreateContactColumnColumn());
			}
			if (Columns.FindByUId(new Guid("763f403d-86c2-4682-bcaa-f82af9c61e8c")) == null) {
				Columns.Add(CreateEmailAddressColumnColumn());
			}
			if (Columns.FindByUId(new Guid("f78a0ded-c197-4502-aee1-df8f0638d541")) == null) {
				Columns.Add(CreateImageColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEntityObjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d7aceffd-9944-46cd-a104-ad18a399a1a1"),
				Name = @"EntityObject",
				ReferenceSchemaUId = new Guid("c82db13a-7f77-4085-b3ef-91c5420fd417"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32"),
				ModifiedInSchemaUId = new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32"),
				CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf")
			};
		}

		protected virtual EntitySchemaColumn CreateDisplayNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5c2dd7cd-ec0e-4d05-b2e3-7a67e3c4fd08"),
				Name = @"DisplayName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32"),
				ModifiedInSchemaUId = new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32"),
				CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("603140c3-34d8-4ada-afa1-e521f2a6ae63"),
				Name = @"ContactColumn",
				CreatedInSchemaUId = new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32"),
				ModifiedInSchemaUId = new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32"),
				CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateEmailAddressColumnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("763f403d-86c2-4682-bcaa-f82af9c61e8c"),
				Name = @"EmailAddressColumn",
				CreatedInSchemaUId = new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32"),
				ModifiedInSchemaUId = new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32"),
				CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("f78a0ded-c197-4502-aee1-df8f0638d541"),
				Name = @"Image",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32"),
				ModifiedInSchemaUId = new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32"),
				CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmailAudienceSchema(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmailAudienceSchema_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmailAudienceSchemaSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailAudienceSchemaSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailAudienceSchema

	/// <summary>
	/// Manage objects for audience import.
	/// </summary>
	public class BulkEmailAudienceSchema : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BulkEmailAudienceSchema(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailAudienceSchema";
		}

		public BulkEmailAudienceSchema(BulkEmailAudienceSchema source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid EntityObjectId {
			get {
				return GetTypedColumnValue<Guid>("EntityObjectId");
			}
			set {
				SetColumnValue("EntityObjectId", value);
				_entityObject = null;
			}
		}

		/// <exclude/>
		public string EntityObjectTitle {
			get {
				return GetTypedColumnValue<string>("EntityObjectTitle");
			}
			set {
				SetColumnValue("EntityObjectTitle", value);
				if (_entityObject != null) {
					_entityObject.Title = value;
				}
			}
		}

		private VwEntityObjects _entityObject;
		/// <summary>
		/// Entity object.
		/// </summary>
		public VwEntityObjects EntityObject {
			get {
				return _entityObject ??
					(_entityObject = LookupColumnEntities.GetEntity("EntityObject") as VwEntityObjects);
			}
		}

		/// <summary>
		/// Object caption.
		/// </summary>
		public string DisplayName {
			get {
				return GetTypedColumnValue<string>("DisplayName");
			}
			set {
				SetColumnValue("DisplayName", value);
			}
		}

		/// <summary>
		/// Contact сolumn path.
		/// </summary>
		public string ContactColumn {
			get {
				return GetTypedColumnValue<string>("ContactColumn");
			}
			set {
				SetColumnValue("ContactColumn", value);
			}
		}

		/// <summary>
		/// Email column path.
		/// </summary>
		public string EmailAddressColumn {
			get {
				return GetTypedColumnValue<string>("EmailAddressColumn");
			}
			set {
				SetColumnValue("EmailAddressColumn", value);
			}
		}

		/// <exclude/>
		public Guid ImageId {
			get {
				return GetTypedColumnValue<Guid>("ImageId");
			}
			set {
				SetColumnValue("ImageId", value);
				_image = null;
			}
		}

		/// <exclude/>
		public string ImageName {
			get {
				return GetTypedColumnValue<string>("ImageName");
			}
			set {
				SetColumnValue("ImageName", value);
				if (_image != null) {
					_image.Name = value;
				}
			}
		}

		private SysImage _image;
		/// <summary>
		/// Image.
		/// </summary>
		public SysImage Image {
			get {
				return _image ??
					(_image = LookupColumnEntities.GetEntity("Image") as SysImage);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailAudienceSchema_CrtBulkEmailEventsProcess(UserConnection);
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
			return new BulkEmailAudienceSchema(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailAudienceSchema_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class BulkEmailAudienceSchema_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BulkEmailAudienceSchema
	{

		public BulkEmailAudienceSchema_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailAudienceSchema_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ee825389-76df-4c88-b91c-f43d7fc15a32");
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

	#region Class: BulkEmailAudienceSchema_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class BulkEmailAudienceSchema_CrtBulkEmailEventsProcess : BulkEmailAudienceSchema_CrtBulkEmailEventsProcess<BulkEmailAudienceSchema>
	{

		public BulkEmailAudienceSchema_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailAudienceSchema_CrtBulkEmailEventsProcess

	public partial class BulkEmailAudienceSchema_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BulkEmailAudienceSchemaEventsProcess

	/// <exclude/>
	public class BulkEmailAudienceSchemaEventsProcess : BulkEmailAudienceSchema_CrtBulkEmailEventsProcess
	{

		public BulkEmailAudienceSchemaEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


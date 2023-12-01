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

	#region Class: SpecificationInObject_CrtSpecification_TerrasoftSchema

	/// <exclude/>
	public class SpecificationInObject_CrtSpecification_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SpecificationInObject_CrtSpecification_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationInObject_CrtSpecification_TerrasoftSchema(SpecificationInObject_CrtSpecification_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationInObject_CrtSpecification_TerrasoftSchema(SpecificationInObject_CrtSpecification_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			RealUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			Name = "SpecificationInObject_CrtSpecification_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8d363901-e536-4e02-82ef-7921ad3ad215")) == null) {
				Columns.Add(CreateStringValueColumn());
			}
			if (Columns.FindByUId(new Guid("985cfb03-dc38-4589-97e8-1663035e12cb")) == null) {
				Columns.Add(CreateIntValueColumn());
			}
			if (Columns.FindByUId(new Guid("1492aef9-5567-4ce2-b308-5b7d581aebb7")) == null) {
				Columns.Add(CreateFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("43656d13-5970-40fa-a6cc-b9d34b1d3636")) == null) {
				Columns.Add(CreateBooleanValueColumn());
			}
			if (Columns.FindByUId(new Guid("6adaf528-b0c1-4e74-a20f-70933fc06ddd")) == null) {
				Columns.Add(CreateSpecificationColumn());
			}
			if (Columns.FindByUId(new Guid("e81eee9a-1b68-4318-9a9f-20dadd47c823")) == null) {
				Columns.Add(CreateListItemValueColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			column.CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e");
			return column;
		}

		protected virtual EntitySchemaColumn CreateStringValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("8d363901-e536-4e02-82ef-7921ad3ad215"),
				Name = @"StringValue",
				CreatedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			};
		}

		protected virtual EntitySchemaColumn CreateIntValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("985cfb03-dc38-4589-97e8-1663035e12cb"),
				Name = @"IntValue",
				CreatedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			};
		}

		protected virtual EntitySchemaColumn CreateFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("1492aef9-5567-4ce2-b308-5b7d581aebb7"),
				Name = @"FloatValue",
				CreatedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			};
		}

		protected virtual EntitySchemaColumn CreateBooleanValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("43656d13-5970-40fa-a6cc-b9d34b1d3636"),
				Name = @"BooleanValue",
				CreatedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6adaf528-b0c1-4e74-a20f-70933fc06ddd"),
				Name = @"Specification",
				ReferenceSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			};
		}

		protected virtual EntitySchemaColumn CreateListItemValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e81eee9a-1b68-4318-9a9f-20dadd47c823"),
				Name = @"ListItemValue",
				ReferenceSchemaUId = new Guid("99bb0a66-4041-4261-a6f2-f37806ba3f65"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				ModifiedInSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"),
				CreatedInPackageId = new Guid("caa0a55b-ca92-4b47-9a26-59cfe4fac97e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SpecificationInObject_CrtSpecification_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationInObject_CrtSpecificationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationInObject_CrtSpecification_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationInObject_CrtSpecification_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInObject_CrtSpecification_Terrasoft

	/// <summary>
	/// Feature in object.
	/// </summary>
	public class SpecificationInObject_CrtSpecification_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SpecificationInObject_CrtSpecification_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationInObject_CrtSpecification_Terrasoft";
		}

		public SpecificationInObject_CrtSpecification_Terrasoft(SpecificationInObject_CrtSpecification_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Value.
		/// </summary>
		public string StringValue {
			get {
				return GetTypedColumnValue<string>("StringValue");
			}
			set {
				SetColumnValue("StringValue", value);
			}
		}

		/// <summary>
		/// Value (integer).
		/// </summary>
		public int IntValue {
			get {
				return GetTypedColumnValue<int>("IntValue");
			}
			set {
				SetColumnValue("IntValue", value);
			}
		}

		/// <summary>
		/// Value (decimal).
		/// </summary>
		public Decimal FloatValue {
			get {
				return GetTypedColumnValue<Decimal>("FloatValue");
			}
			set {
				SetColumnValue("FloatValue", value);
			}
		}

		/// <summary>
		/// Value (Boolean).
		/// </summary>
		public bool BooleanValue {
			get {
				return GetTypedColumnValue<bool>("BooleanValue");
			}
			set {
				SetColumnValue("BooleanValue", value);
			}
		}

		/// <exclude/>
		public Guid SpecificationId {
			get {
				return GetTypedColumnValue<Guid>("SpecificationId");
			}
			set {
				SetColumnValue("SpecificationId", value);
				_specification = null;
			}
		}

		/// <exclude/>
		public string SpecificationName {
			get {
				return GetTypedColumnValue<string>("SpecificationName");
			}
			set {
				SetColumnValue("SpecificationName", value);
				if (_specification != null) {
					_specification.Name = value;
				}
			}
		}

		private Specification _specification;
		/// <summary>
		/// Feature.
		/// </summary>
		public Specification Specification {
			get {
				return _specification ??
					(_specification = LookupColumnEntities.GetEntity("Specification") as Specification);
			}
		}

		/// <exclude/>
		public Guid ListItemValueId {
			get {
				return GetTypedColumnValue<Guid>("ListItemValueId");
			}
			set {
				SetColumnValue("ListItemValueId", value);
				_listItemValue = null;
			}
		}

		/// <exclude/>
		public string ListItemValueName {
			get {
				return GetTypedColumnValue<string>("ListItemValueName");
			}
			set {
				SetColumnValue("ListItemValueName", value);
				if (_listItemValue != null) {
					_listItemValue.Name = value;
				}
			}
		}

		private SpecificationListItem _listItemValue;
		/// <summary>
		/// Value (drop-down list).
		/// </summary>
		public SpecificationListItem ListItemValue {
			get {
				return _listItemValue ??
					(_listItemValue = LookupColumnEntities.GetEntity("ListItemValue") as SpecificationListItem);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecificationInObject_CrtSpecificationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecificationInObject_CrtSpecification_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("SpecificationInObject_CrtSpecification_TerrasoftInserting", e);
			Saving += (s, e) => ThrowEvent("SpecificationInObject_CrtSpecification_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("SpecificationInObject_CrtSpecification_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationInObject_CrtSpecification_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInObject_CrtSpecificationEventsProcess

	/// <exclude/>
	public partial class SpecificationInObject_CrtSpecificationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SpecificationInObject_CrtSpecification_Terrasoft
	{

		public SpecificationInObject_CrtSpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationInObject_CrtSpecificationEventsProcess";
			SchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private LocalizableString _yes;
		public LocalizableString Yes {
			get {
				return _yes ?? (_yes = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.Yes.Value"));
			}
		}

		private LocalizableString _no;
		public LocalizableString No {
			get {
				return _no ?? (_no = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.No.Value"));
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

	#region Class: SpecificationInObject_CrtSpecificationEventsProcess

	/// <exclude/>
	public class SpecificationInObject_CrtSpecificationEventsProcess : SpecificationInObject_CrtSpecificationEventsProcess<SpecificationInObject_CrtSpecification_Terrasoft>
	{

		public SpecificationInObject_CrtSpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


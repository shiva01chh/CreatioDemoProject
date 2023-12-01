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

	#region Class: QualifyStatus_CrtLead_TerrasoftSchema

	/// <exclude/>
	public class QualifyStatus_CrtLead_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public QualifyStatus_CrtLead_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public QualifyStatus_CrtLead_TerrasoftSchema(QualifyStatus_CrtLead_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public QualifyStatus_CrtLead_TerrasoftSchema(QualifyStatus_CrtLead_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			RealUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			Name = "QualifyStatus_CrtLead_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c3cce05b-84ce-4d10-ad34-8d9cc9a35abf")) == null) {
				Columns.Add(CreateStageNumberColumn());
			}
			if (Columns.FindByUId(new Guid("f83ff4ec-8cda-4067-9262-b71bc587746d")) == null) {
				Columns.Add(CreateColorColumn());
			}
			if (Columns.FindByUId(new Guid("c4e29fea-f73c-4780-91c1-995285f7397a")) == null) {
				Columns.Add(CreateIsDisplayedColumn());
			}
			if (Columns.FindByUId(new Guid("eb37a354-ec7b-4077-a79d-5ff3cc521b99")) == null) {
				Columns.Add(CreateStageOrderColumn());
			}
			if (Columns.FindByUId(new Guid("58c481ee-ed40-4e89-98a1-11ce7d3bdff3")) == null) {
				Columns.Add(CreateStageInnerOrderColumn());
			}
			if (Columns.FindByUId(new Guid("b40801fd-7858-4a95-8d35-0fee83285cb2")) == null) {
				Columns.Add(CreateIsFinalColumn());
			}
			if (Columns.FindByUId(new Guid("db9586bb-31b8-4078-a1fc-2d0588c294ac")) == null) {
				Columns.Add(CreateSuccessfulColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			column.CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5");
			return column;
		}

		protected virtual EntitySchemaColumn CreateStageNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("c3cce05b-84ce-4d10-ad34-8d9cc9a35abf"),
				Name = @"StageNumber",
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("af77c4b2-f9ec-497f-9388-8112501477da")
			};
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("f83ff4ec-8cda-4067-9262-b71bc587746d"),
				Name = @"Color",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("1a7afc7f-95ec-4933-ad5b-fbf6e891e557")
			};
		}

		protected virtual EntitySchemaColumn CreateIsDisplayedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c4e29fea-f73c-4780-91c1-995285f7397a"),
				Name = @"IsDisplayed",
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("1a7afc7f-95ec-4933-ad5b-fbf6e891e557")
			};
		}

		protected virtual EntitySchemaColumn CreateStageOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("eb37a354-ec7b-4077-a79d-5ff3cc521b99"),
				Name = @"StageOrder",
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("1a7afc7f-95ec-4933-ad5b-fbf6e891e557")
			};
		}

		protected virtual EntitySchemaColumn CreateStageInnerOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("58c481ee-ed40-4e89-98a1-11ce7d3bdff3"),
				Name = @"StageInnerOrder",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("1a7afc7f-95ec-4933-ad5b-fbf6e891e557")
			};
		}

		protected virtual EntitySchemaColumn CreateIsFinalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b40801fd-7858-4a95-8d35-0fee83285cb2"),
				Name = @"IsFinal",
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("ffff327e-8320-4d3b-80f3-cd12dd0dbcc4")
			};
		}

		protected virtual EntitySchemaColumn CreateSuccessfulColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("db9586bb-31b8-4078-a1fc-2d0588c294ac"),
				Name = @"Successful",
				CreatedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				ModifiedInSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new QualifyStatus_CrtLead_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new QualifyStatus_CrtLeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new QualifyStatus_CrtLead_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new QualifyStatus_CrtLead_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"));
		}

		#endregion

	}

	#endregion

	#region Class: QualifyStatus_CrtLead_Terrasoft

	/// <summary>
	/// Lead stage.
	/// </summary>
	public class QualifyStatus_CrtLead_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public QualifyStatus_CrtLead_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "QualifyStatus_CrtLead_Terrasoft";
		}

		public QualifyStatus_CrtLead_Terrasoft(QualifyStatus_CrtLead_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Stage number.
		/// </summary>
		public int StageNumber {
			get {
				return GetTypedColumnValue<int>("StageNumber");
			}
			set {
				SetColumnValue("StageNumber", value);
			}
		}

		/// <summary>
		/// Color.
		/// </summary>
		public string Color {
			get {
				return GetTypedColumnValue<string>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		/// <summary>
		/// Display in Workflow Bar.
		/// </summary>
		public bool IsDisplayed {
			get {
				return GetTypedColumnValue<bool>("IsDisplayed");
			}
			set {
				SetColumnValue("IsDisplayed", value);
			}
		}

		/// <summary>
		/// Primary order in Workflow Bar.
		/// </summary>
		public int StageOrder {
			get {
				return GetTypedColumnValue<int>("StageOrder");
			}
			set {
				SetColumnValue("StageOrder", value);
			}
		}

		/// <summary>
		/// Secondary order in Workflow Bar.
		/// </summary>
		public int StageInnerOrder {
			get {
				return GetTypedColumnValue<int>("StageInnerOrder");
			}
			set {
				SetColumnValue("StageInnerOrder", value);
			}
		}

		/// <summary>
		/// Is final.
		/// </summary>
		public bool IsFinal {
			get {
				return GetTypedColumnValue<bool>("IsFinal");
			}
			set {
				SetColumnValue("IsFinal", value);
			}
		}

		/// <summary>
		/// Successful.
		/// </summary>
		public bool Successful {
			get {
				return GetTypedColumnValue<bool>("Successful");
			}
			set {
				SetColumnValue("Successful", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new QualifyStatus_CrtLeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("QualifyStatus_CrtLead_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("QualifyStatus_CrtLead_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("QualifyStatus_CrtLead_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QualifyStatus_CrtLead_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: QualifyStatus_CrtLeadEventsProcess

	/// <exclude/>
	public partial class QualifyStatus_CrtLeadEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : QualifyStatus_CrtLead_Terrasoft
	{

		public QualifyStatus_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QualifyStatus_CrtLeadEventsProcess";
			SchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44");
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

	#region Class: QualifyStatus_CrtLeadEventsProcess

	/// <exclude/>
	public class QualifyStatus_CrtLeadEventsProcess : QualifyStatus_CrtLeadEventsProcess<QualifyStatus_CrtLead_Terrasoft>
	{

		public QualifyStatus_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QualifyStatus_CrtLeadEventsProcess

	public partial class QualifyStatus_CrtLeadEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}


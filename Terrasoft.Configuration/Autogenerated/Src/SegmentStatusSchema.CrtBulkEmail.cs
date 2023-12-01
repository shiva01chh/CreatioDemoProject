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

	#region Class: SegmentStatusSchema

	/// <exclude/>
	public class SegmentStatusSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SegmentStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SegmentStatusSchema(SegmentStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SegmentStatusSchema(SegmentStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70");
			RealUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70");
			Name = "SegmentStatus";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2285822f-2af3-4fd6-aa26-8a7c756559b3")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70");
			column.CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70");
			column.CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70");
			column.CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70");
			column.CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70");
			column.CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70");
			column.CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("3c6f201d-e6f5-4494-9265-2263d8069b6f"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70"),
				ModifiedInSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("2285822f-2af3-4fd6-aa26-8a7c756559b3"),
				Name = @"Description",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70"),
				ModifiedInSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SegmentStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SegmentStatus_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SegmentStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SegmentStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70"));
		}

		#endregion

	}

	#endregion

	#region Class: SegmentStatus

	/// <summary>
	/// Segment update status.
	/// </summary>
	public class SegmentStatus : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SegmentStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SegmentStatus";
		}

		public SegmentStatus(SegmentStatus source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SegmentStatus_CrtBulkEmailEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SegmentStatusDeleted", e);
			Inserting += (s, e) => ThrowEvent("SegmentStatusInserting", e);
			Validating += (s, e) => ThrowEvent("SegmentStatusValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SegmentStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: SegmentStatus_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class SegmentStatus_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SegmentStatus
	{

		public SegmentStatus_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SegmentStatus_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70");
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

	#region Class: SegmentStatus_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class SegmentStatus_CrtBulkEmailEventsProcess : SegmentStatus_CrtBulkEmailEventsProcess<SegmentStatus>
	{

		public SegmentStatus_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SegmentStatus_CrtBulkEmailEventsProcess

	public partial class SegmentStatus_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SegmentStatusEventsProcess

	/// <exclude/>
	public class SegmentStatusEventsProcess : SegmentStatus_CrtBulkEmailEventsProcess
	{

		public SegmentStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


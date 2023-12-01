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

	#region Class: ServicePactStatusSchema

	/// <exclude/>
	public class ServicePactStatusSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ServicePactStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ServicePactStatusSchema(ServicePactStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ServicePactStatusSchema(ServicePactStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78");
			RealUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78");
			Name = "ServicePactStatus";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColorColumn() {
			base.InitializePrimaryColorColumn();
			PrimaryColorColumn = CreateColorColumn();
			if (Columns.FindByUId(PrimaryColorColumn.UId) == null) {
				Columns.Add(PrimaryColorColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("9b3fb41d-c75a-4a0a-88a1-016a55b32ec0")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9b3fb41d-c75a-4a0a-88a1-016a55b32ec0"),
				Name = @"IsActive",
				CreatedInSchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78"),
				ModifiedInSchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("d0668240-0895-bdb1-b082-96ca478e0221"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78"),
				ModifiedInSchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78"),
				CreatedInPackageId = new Guid("9e15b378-783b-44f1-895b-b01e6274a20d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ServicePactStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ServicePactStatus_CrtSLMITILServiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ServicePactStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ServicePactStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78"));
		}

		#endregion

	}

	#endregion

	#region Class: ServicePactStatus

	/// <summary>
	/// Service contract status.
	/// </summary>
	public class ServicePactStatus : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ServicePactStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ServicePactStatus";
		}

		public ServicePactStatus(ServicePactStatus source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Is Active.
		/// </summary>
		public bool IsActive {
			get {
				return GetTypedColumnValue<bool>("IsActive");
			}
			set {
				SetColumnValue("IsActive", value);
			}
		}

		/// <summary>
		/// Color.
		/// </summary>
		public Color Color {
			get {
				return GetTypedColumnValue<Color>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ServicePactStatus_CrtSLMITILServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ServicePactStatusDeleted", e);
			Deleting += (s, e) => ThrowEvent("ServicePactStatusDeleting", e);
			Inserted += (s, e) => ThrowEvent("ServicePactStatusInserted", e);
			Inserting += (s, e) => ThrowEvent("ServicePactStatusInserting", e);
			Saved += (s, e) => ThrowEvent("ServicePactStatusSaved", e);
			Saving += (s, e) => ThrowEvent("ServicePactStatusSaving", e);
			Validating += (s, e) => ThrowEvent("ServicePactStatusValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ServicePactStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: ServicePactStatus_CrtSLMITILServiceEventsProcess

	/// <exclude/>
	public partial class ServicePactStatus_CrtSLMITILServiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : ServicePactStatus
	{

		public ServicePactStatus_CrtSLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ServicePactStatus_CrtSLMITILServiceEventsProcess";
			SchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78");
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

	#region Class: ServicePactStatus_CrtSLMITILServiceEventsProcess

	/// <exclude/>
	public class ServicePactStatus_CrtSLMITILServiceEventsProcess : ServicePactStatus_CrtSLMITILServiceEventsProcess<ServicePactStatus>
	{

		public ServicePactStatus_CrtSLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ServicePactStatus_CrtSLMITILServiceEventsProcess

	public partial class ServicePactStatus_CrtSLMITILServiceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ServicePactStatusEventsProcess

	/// <exclude/>
	public class ServicePactStatusEventsProcess : ServicePactStatus_CrtSLMITILServiceEventsProcess
	{

		public ServicePactStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


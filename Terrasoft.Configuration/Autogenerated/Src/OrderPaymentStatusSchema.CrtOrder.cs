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

	#region Class: OrderPaymentStatus_CrtOrder_TerrasoftSchema

	/// <exclude/>
	public class OrderPaymentStatus_CrtOrder_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public OrderPaymentStatus_CrtOrder_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderPaymentStatus_CrtOrder_TerrasoftSchema(OrderPaymentStatus_CrtOrder_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderPaymentStatus_CrtOrder_TerrasoftSchema(OrderPaymentStatus_CrtOrder_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88");
			RealUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88");
			Name = "OrderPaymentStatus_CrtOrder_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("207eee15-86fb-425e-a03c-7599a8dab8e8")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("207eee15-86fb-425e-a03c-7599a8dab8e8"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88"),
				ModifiedInSchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OrderPaymentStatus_CrtOrder_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderPaymentStatus_CrtOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderPaymentStatus_CrtOrder_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderPaymentStatus_CrtOrder_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c121173e-9034-4066-aede-682a4ce8fa88"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderPaymentStatus_CrtOrder_Terrasoft

	/// <summary>
	/// Order payment status.
	/// </summary>
	public class OrderPaymentStatus_CrtOrder_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public OrderPaymentStatus_CrtOrder_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderPaymentStatus_CrtOrder_Terrasoft";
		}

		public OrderPaymentStatus_CrtOrder_Terrasoft(OrderPaymentStatus_CrtOrder_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderPaymentStatus_CrtOrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OrderPaymentStatus_CrtOrder_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("OrderPaymentStatus_CrtOrder_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("OrderPaymentStatus_CrtOrder_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderPaymentStatus_CrtOrder_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderPaymentStatus_CrtOrderEventsProcess

	/// <exclude/>
	public partial class OrderPaymentStatus_CrtOrderEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : OrderPaymentStatus_CrtOrder_Terrasoft
	{

		public OrderPaymentStatus_CrtOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderPaymentStatus_CrtOrderEventsProcess";
			SchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c121173e-9034-4066-aede-682a4ce8fa88");
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

	#region Class: OrderPaymentStatus_CrtOrderEventsProcess

	/// <exclude/>
	public class OrderPaymentStatus_CrtOrderEventsProcess : OrderPaymentStatus_CrtOrderEventsProcess<OrderPaymentStatus_CrtOrder_Terrasoft>
	{

		public OrderPaymentStatus_CrtOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OrderPaymentStatus_CrtOrderEventsProcess

	public partial class OrderPaymentStatus_CrtOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}


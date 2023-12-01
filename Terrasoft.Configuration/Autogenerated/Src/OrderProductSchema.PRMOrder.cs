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
	using Terrasoft.Configuration.Passport;
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

	#region Class: OrderProduct_PRMOrder_TerrasoftSchema

	/// <exclude/>
	public class OrderProduct_PRMOrder_TerrasoftSchema : Terrasoft.Configuration.OrderProduct_Passport_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderProduct_PRMOrder_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderProduct_PRMOrder_TerrasoftSchema(OrderProduct_PRMOrder_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderProduct_PRMOrder_TerrasoftSchema(OrderProduct_PRMOrder_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("1e7d093d-bab7-4ded-aa2e-6032727b09b7");
			Name = "OrderProduct_PRMOrder_Terrasoft";
			ParentSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("5ad21e1a-95d7-43e1-8821-5a5bb2a4bde1");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeMasterRecordColumn() {
			base.InitializeMasterRecordColumn();
			MasterRecordColumn = CreateOrderColumn();
			if (Columns.FindByUId(MasterRecordColumn.UId) == null) {
				Columns.Add(MasterRecordColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OrderProduct_PRMOrder_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderProduct_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderProduct_PRMOrder_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderProduct_PRMOrder_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1e7d093d-bab7-4ded-aa2e-6032727b09b7"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_PRMOrder_Terrasoft

	/// <summary>
	/// Product in order.
	/// </summary>
	public class OrderProduct_PRMOrder_Terrasoft : Terrasoft.Configuration.OrderProduct_Passport_Terrasoft
	{

		#region Constructors: Public

		public OrderProduct_PRMOrder_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderProduct_PRMOrder_Terrasoft";
		}

		public OrderProduct_PRMOrder_Terrasoft(OrderProduct_PRMOrder_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderProduct_PRMOrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saved += (s, e) => ThrowEvent("OrderProduct_PRMOrder_TerrasoftSaved", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderProduct_PRMOrder_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_PRMOrderEventsProcess

	/// <exclude/>
	public partial class OrderProduct_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.OrderProduct_PassportEventsProcess<TEntity> where TEntity : OrderProduct_PRMOrder_Terrasoft
	{

		public OrderProduct_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderProduct_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1e7d093d-bab7-4ded-aa2e-6032727b09b7");
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

	#region Class: OrderProduct_PRMOrderEventsProcess

	/// <exclude/>
	public class OrderProduct_PRMOrderEventsProcess : OrderProduct_PRMOrderEventsProcess<OrderProduct_PRMOrder_Terrasoft>
	{

		public OrderProduct_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OrderProduct_PRMOrderEventsProcess

	public partial class OrderProduct_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void RecalculateOrderAmount() {
			base.RecalculateOrderAmount();
			var helper = ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
			if (IsProductDeleted){
				if (SupplyPaymentElementsToRecalc != null) {
					var speIds = (List<Guid>)SupplyPaymentElementsToRecalc;
					helper.OnOrderProductDeleted(Entity.GetTypedColumnValue<Guid>("OrderId"), speIds);
				}
			} else {
				var changedColumnValues = ChangedColumnValues as IEnumerable<EntityColumnValue>;
				helper.OnOrderProductChanged(Entity.PrimaryColumnValue, changedColumnValues);
			}
		}

		#endregion

	}

	#endregion

}


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

	#region Class: OrderProduct_Order_TerrasoftSchema

	/// <exclude/>
	public class OrderProduct_Order_TerrasoftSchema : Terrasoft.Configuration.OrderProduct_CrtOrderContract_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderProduct_Order_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderProduct_Order_TerrasoftSchema(OrderProduct_Order_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderProduct_Order_TerrasoftSchema(OrderProduct_Order_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("14fd627c-8051-440c-9cd6-1f10c65efe7e");
			Name = "OrderProduct_Order_Terrasoft";
			ParentSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("e8c4bc03-2f14-47b7-8005-47fab57cc1b8");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
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
			return new OrderProduct_Order_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderProduct_OrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderProduct_Order_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderProduct_Order_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("14fd627c-8051-440c-9cd6-1f10c65efe7e"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_Order_Terrasoft

	/// <summary>
	/// Product in order.
	/// </summary>
	public class OrderProduct_Order_Terrasoft : Terrasoft.Configuration.OrderProduct_CrtOrderContract_Terrasoft
	{

		#region Constructors: Public

		public OrderProduct_Order_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderProduct_Order_Terrasoft";
		}

		public OrderProduct_Order_Terrasoft(OrderProduct_Order_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderProduct_OrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OrderProduct_Order_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("OrderProduct_Order_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("OrderProduct_Order_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("OrderProduct_Order_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("OrderProduct_Order_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderProduct_Order_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_OrderEventsProcess

	/// <exclude/>
	public partial class OrderProduct_OrderEventsProcess<TEntity> : Terrasoft.Configuration.OrderProduct_CrtOrderContractEventsProcess<TEntity> where TEntity : OrderProduct_Order_Terrasoft
	{

		public OrderProduct_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderProduct_OrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("14fd627c-8051-440c-9cd6-1f10c65efe7e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("262c8e25-2f7d-485a-b944-d6b9574c0527"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _recalcOrderProductDeletedStartMessage;
		public ProcessFlowElement RecalcOrderProductDeletedStartMessage {
			get {
				return _recalcOrderProductDeletedStartMessage ?? (_recalcOrderProductDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RecalcOrderProductDeletedStartMessage",
					SchemaElementUId = new Guid("c092650a-de1d-4cee-80ac-f26d412d55ad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setNeedUpdateAmountScriptTask;
		public ProcessScriptTask SetNeedUpdateAmountScriptTask {
			get {
				return _setNeedUpdateAmountScriptTask ?? (_setNeedUpdateAmountScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetNeedUpdateAmountScriptTask",
					SchemaElementUId = new Guid("5686b16e-0d8d-4198-83bc-f721dfd296c2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetNeedUpdateAmountScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTask5_a600abfe9ada4cd182f3bfdae6b42086;
		public ProcessScriptTask ScriptTask5_a600abfe9ada4cd182f3bfdae6b42086 {
			get {
				return _scriptTask5_a600abfe9ada4cd182f3bfdae6b42086 ?? (_scriptTask5_a600abfe9ada4cd182f3bfdae6b42086 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5_a600abfe9ada4cd182f3bfdae6b42086",
					SchemaElementUId = new Guid("d16de2aa-a40d-4401-8767-092a51a88798"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5_a600abfe9ada4cd182f3bfdae6b42086Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3_42205f7a290946f1b277de9d122a4518;
		public ProcessFlowElement EventSubProcess3_42205f7a290946f1b277de9d122a4518 {
			get {
				return _eventSubProcess3_42205f7a290946f1b277de9d122a4518 ?? (_eventSubProcess3_42205f7a290946f1b277de9d122a4518 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_42205f7a290946f1b277de9d122a4518",
					SchemaElementUId = new Guid("42205f7a-2909-46f1-b277-de9d122a4518"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _recalcOrderProductSavedStartMessage;
		public ProcessFlowElement RecalcOrderProductSavedStartMessage {
			get {
				return _recalcOrderProductSavedStartMessage ?? (_recalcOrderProductSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RecalcOrderProductSavedStartMessage",
					SchemaElementUId = new Guid("76d5069a-af5e-4d18-ba02-e3a51cf427d3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _recalculateOrderAmountScriptTask;
		public ProcessScriptTask RecalculateOrderAmountScriptTask {
			get {
				return _recalculateOrderAmountScriptTask ?? (_recalculateOrderAmountScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RecalculateOrderAmountScriptTask",
					SchemaElementUId = new Guid("514c821a-6f35-4045-af45-799e03ae0d6d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RecalculateOrderAmountScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("543ed6a8-b284-475a-852f-31d736667d48"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _orderProductSaving;
		public ProcessFlowElement OrderProductSaving {
			get {
				return _orderProductSaving ?? (_orderProductSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OrderProductSaving",
					SchemaElementUId = new Guid("becf48f5-4b8a-422e-b03e-36d59c34e793"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptUpdateFinance;
		public ProcessScriptTask ScriptUpdateFinance {
			get {
				return _scriptUpdateFinance ?? (_scriptUpdateFinance = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptUpdateFinance",
					SchemaElementUId = new Guid("eea89f53-556e-49f2-96ef-43a5e1af16d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptUpdateFinanceExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageOrderProductSaving;
		public ProcessThrowMessageEvent IntermediateThrowMessageOrderProductSaving {
			get {
				return _intermediateThrowMessageOrderProductSaving ?? (_intermediateThrowMessageOrderProductSaving = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageOrderProductSaving",
					SchemaElementUId = new Guid("32d90477-f22c-4a40-a83c-d3305baf647a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OrderProductSaving",
				});
			}
		}

		private ProcessScriptTask _checkNeedUpdateOrderAmountScriptTask;
		public ProcessScriptTask CheckNeedUpdateOrderAmountScriptTask {
			get {
				return _checkNeedUpdateOrderAmountScriptTask ?? (_checkNeedUpdateOrderAmountScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckNeedUpdateOrderAmountScriptTask",
					SchemaElementUId = new Guid("0cde7c00-487a-45f0-9700-6bdda75ccbd6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckNeedUpdateOrderAmountScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[RecalcOrderProductDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RecalcOrderProductDeletedStartMessage };
			FlowElements[SetNeedUpdateAmountScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetNeedUpdateAmountScriptTask };
			FlowElements[ScriptTask5_a600abfe9ada4cd182f3bfdae6b42086.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5_a600abfe9ada4cd182f3bfdae6b42086 };
			FlowElements[EventSubProcess3_42205f7a290946f1b277de9d122a4518.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_42205f7a290946f1b277de9d122a4518 };
			FlowElements[RecalcOrderProductSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RecalcOrderProductSavedStartMessage };
			FlowElements[RecalculateOrderAmountScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RecalculateOrderAmountScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[OrderProductSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { OrderProductSaving };
			FlowElements[ScriptUpdateFinance.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptUpdateFinance };
			FlowElements[IntermediateThrowMessageOrderProductSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageOrderProductSaving };
			FlowElements[CheckNeedUpdateOrderAmountScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckNeedUpdateOrderAmountScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3":
						break;
					case "RecalcOrderProductDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("SetNeedUpdateAmountScriptTask");
						break;
					case "SetNeedUpdateAmountScriptTask":
						e.Context.QueueTasks.Enqueue("ScriptTask5_a600abfe9ada4cd182f3bfdae6b42086");
						break;
					case "ScriptTask5_a600abfe9ada4cd182f3bfdae6b42086":
						break;
					case "EventSubProcess3_42205f7a290946f1b277de9d122a4518":
						break;
					case "RecalcOrderProductSavedStartMessage":
						e.Context.QueueTasks.Enqueue("RecalculateOrderAmountScriptTask");
						break;
					case "RecalculateOrderAmountScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "OrderProductSaving":
						e.Context.QueueTasks.Enqueue("ScriptUpdateFinance");
						break;
					case "ScriptUpdateFinance":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageOrderProductSaving");
						break;
					case "IntermediateThrowMessageOrderProductSaving":
						e.Context.QueueTasks.Enqueue("CheckNeedUpdateOrderAmountScriptTask");
						break;
					case "CheckNeedUpdateOrderAmountScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("RecalcOrderProductDeletedStartMessage");
			ActivatedEventElements.Add("RecalcOrderProductSavedStartMessage");
			ActivatedEventElements.Add("OrderProductSaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "RecalcOrderProductDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RecalcOrderProductDeletedStartMessage";
					result = RecalcOrderProductDeletedStartMessage.Execute(context);
					break;
				case "SetNeedUpdateAmountScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetNeedUpdateAmountScriptTask";
					result = SetNeedUpdateAmountScriptTask.Execute(context, SetNeedUpdateAmountScriptTaskExecute);
					break;
				case "ScriptTask5_a600abfe9ada4cd182f3bfdae6b42086":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5_a600abfe9ada4cd182f3bfdae6b42086";
					result = ScriptTask5_a600abfe9ada4cd182f3bfdae6b42086.Execute(context, ScriptTask5_a600abfe9ada4cd182f3bfdae6b42086Execute);
					break;
				case "EventSubProcess3_42205f7a290946f1b277de9d122a4518":
					context.QueueTasks.Dequeue();
					break;
				case "RecalcOrderProductSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RecalcOrderProductSavedStartMessage";
					result = RecalcOrderProductSavedStartMessage.Execute(context);
					break;
				case "RecalculateOrderAmountScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RecalculateOrderAmountScriptTask";
					result = RecalculateOrderAmountScriptTask.Execute(context, RecalculateOrderAmountScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "OrderProductSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "OrderProductSaving";
					result = OrderProductSaving.Execute(context);
					break;
				case "ScriptUpdateFinance":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptUpdateFinance";
					result = ScriptUpdateFinance.Execute(context, ScriptUpdateFinanceExecute);
					break;
				case "IntermediateThrowMessageOrderProductSaving":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageOrderProductSaving.Execute(context);
					break;
				case "CheckNeedUpdateOrderAmountScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckNeedUpdateOrderAmountScriptTask";
					result = CheckNeedUpdateOrderAmountScriptTask.Execute(context, CheckNeedUpdateOrderAmountScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool SetNeedUpdateAmountScriptTaskExecute(ProcessExecutingContext context) {
			NeedUpdateOrderAmount = true;
			IsProductDeleted = true;
			return true;
		}

		public virtual bool ScriptTask5_a600abfe9ada4cd182f3bfdae6b42086Execute(ProcessExecutingContext context) {
			if (NeedUpdateOrderAmount) {
				RecalculateOrderAmount();
			}
			return true;
		}

		public virtual bool RecalculateOrderAmountScriptTaskExecute(ProcessExecutingContext context) {
			if (NeedUpdateOrderAmount) {
				RecalculateOrderAmount();
			}
			return true;
		}

		public virtual bool ScriptUpdateFinanceExecute(ProcessExecutingContext context) {
			LoadCurrencyFromOrder();
			return true;
		}

		public virtual bool CheckNeedUpdateOrderAmountScriptTaskExecute(ProcessExecutingContext context) {
			var changedValues = Entity.GetChangedColumnValues();
			List<string> changedColumnNames = changedValues.Where(cv => cv.Value != cv.OldValue).ToList().ConvertAll(cv => cv.Column.Name);
			NeedUpdateOrderAmount = changedColumnNames.Intersect(new[] {"TotalAmount", "PrimaryTotalAmount"}).Any();
			ChangedColumnValues = changedValues;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OrderProduct_Order_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("RecalcOrderProductDeletedStartMessage")) {
							context.QueueTasks.Enqueue("RecalcOrderProductDeletedStartMessage");
						}
						break;
					case "OrderProduct_Order_TerrasoftSaved":
							if (ActivatedEventElements.Contains("RecalcOrderProductSavedStartMessage")) {
							context.QueueTasks.Enqueue("RecalcOrderProductSavedStartMessage");
						}
						break;
					case "OrderProduct_Order_TerrasoftSaving":
							if (ActivatedEventElements.Contains("OrderProductSaving")) {
							context.QueueTasks.Enqueue("OrderProductSaving");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_OrderEventsProcess

	/// <exclude/>
	public class OrderProduct_OrderEventsProcess : OrderProduct_OrderEventsProcess<OrderProduct_Order_Terrasoft>
	{

		public OrderProduct_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


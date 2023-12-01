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
	using Terrasoft.Configuration;
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

	#region Class: Order_Order_TerrasoftSchema

	/// <exclude/>
	public class Order_Order_TerrasoftSchema : Terrasoft.Configuration.Order_CrtOrder_TerrasoftSchema
	{

		#region Constructors: Public

		public Order_Order_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Order_Order_TerrasoftSchema(Order_Order_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Order_Order_TerrasoftSchema(Order_Order_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("af49161c-e710-44cd-811b-e889851cfdaa");
			Name = "Order_Order_Terrasoft";
			ParentSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
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

		protected override EntitySchemaColumn CreateOwnerColumn() {
			EntitySchemaColumn column = base.CreateOwnerColumn();
			column.ModifiedInSchemaUId = new Guid("af49161c-e710-44cd-811b-e889851cfdaa");
			return column;
		}

		protected override EntitySchemaColumn CreateStatusColumn() {
			EntitySchemaColumn column = base.CreateStatusColumn();
			column.ModifiedInSchemaUId = new Guid("af49161c-e710-44cd-811b-e889851cfdaa");
			return column;
		}

		protected override EntitySchemaColumn CreatePaymentStatusColumn() {
			EntitySchemaColumn column = base.CreatePaymentStatusColumn();
			column.ModifiedInSchemaUId = new Guid("af49161c-e710-44cd-811b-e889851cfdaa");
			return column;
		}

		protected override EntitySchemaColumn CreateDeliveryStatusColumn() {
			EntitySchemaColumn column = base.CreateDeliveryStatusColumn();
			column.ModifiedInSchemaUId = new Guid("af49161c-e710-44cd-811b-e889851cfdaa");
			return column;
		}

		protected override EntitySchemaColumn CreateCurrencyColumn() {
			EntitySchemaColumn column = base.CreateCurrencyColumn();
			column.ModifiedInSchemaUId = new Guid("af49161c-e710-44cd-811b-e889851cfdaa");
			return column;
		}

		protected override EntitySchemaColumn CreateDeliveryTypeColumn() {
			EntitySchemaColumn column = base.CreateDeliveryTypeColumn();
			column.ModifiedInSchemaUId = new Guid("af49161c-e710-44cd-811b-e889851cfdaa");
			return column;
		}

		protected override EntitySchemaColumn CreatePaymentTypeColumn() {
			EntitySchemaColumn column = base.CreatePaymentTypeColumn();
			column.ModifiedInSchemaUId = new Guid("af49161c-e710-44cd-811b-e889851cfdaa");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Order_Order_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Order_OrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Order_Order_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Order_Order_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af49161c-e710-44cd-811b-e889851cfdaa"));
		}

		#endregion

	}

	#endregion

	#region Class: Order_Order_Terrasoft

	/// <summary>
	/// Order.
	/// </summary>
	public class Order_Order_Terrasoft : Terrasoft.Configuration.Order_CrtOrder_Terrasoft
	{

		#region Constructors: Public

		public Order_Order_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Order_Order_Terrasoft";
		}

		public Order_Order_Terrasoft(Order_Order_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Order_OrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Order_Order_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Order_Order_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Order_Order_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Order_Order_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Order_Order_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Order_Order_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Order_OrderEventsProcess

	/// <exclude/>
	public partial class Order_OrderEventsProcess<TEntity> : Terrasoft.Configuration.Order_CrtOrderEventsProcess<TEntity> where TEntity : Order_Order_Terrasoft
	{

		#region Class: GenerateNumberUserTaskFlowElement

		/// <exclude/>
		public class GenerateNumberUserTaskFlowElement : GenerateSequenseNumberUserTask
		{

			public GenerateNumberUserTaskFlowElement(UserConnection userConnection, Order_OrderEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GenerateNumberUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("52975af3-426f-4e52-b69b-d621df6d3dea");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Order_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Order_OrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("af49161c-e710-44cd-811b-e889851cfdaa");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
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
					SchemaElementUId = new Guid("361d906f-350c-4773-a40c-205a1f0ad718"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_fac02c993d3b476f9b40bee7a657b3ee;
		public ProcessFlowElement StartMessage3_fac02c993d3b476f9b40bee7a657b3ee {
			get {
				return _startMessage3_fac02c993d3b476f9b40bee7a657b3ee ?? (_startMessage3_fac02c993d3b476f9b40bee7a657b3ee = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_fac02c993d3b476f9b40bee7a657b3ee",
					SchemaElementUId = new Guid("fac02c99-3d3b-476f-9b40-bee7a657b3ee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _init;
		public ProcessScriptTask Init {
			get {
				return _init ?? (_init = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Init",
					SchemaElementUId = new Guid("61a3952e-be6b-4783-bf14-05372faacd2c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("3bde9330-837d-4de8-ba82-1274dbbc037e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessScriptTask _scriptTask5;
		public ProcessScriptTask ScriptTask5 {
			get {
				return _scriptTask5 ?? (_scriptTask5 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5",
					SchemaElementUId = new Guid("ad002356-e187-46f2-9797-42b3577ac836"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("0fec9c99-a437-454e-993b-43d44a0eef4a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OrderSaving",
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("d62fa281-0109-406f-a815-953444bf0af3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("075bb8d7-c0a7-49ef-bb7d-035e02de7fa4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3;
		public ProcessScriptTask ScriptTask3 {
			get {
				return _scriptTask3 ?? (_scriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3",
					SchemaElementUId = new Guid("1e07d5c0-14fc-4014-ac6b-75fca5f3c074"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
				});
			}
		}

		private GenerateNumberUserTaskFlowElement _generateNumberUserTask;
		public GenerateNumberUserTaskFlowElement GenerateNumberUserTask {
			get {
				return _generateNumberUserTask ?? (_generateNumberUserTask = new GenerateNumberUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTask4;
		public ProcessScriptTask ScriptTask4 {
			get {
				return _scriptTask4 ?? (_scriptTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4",
					SchemaElementUId = new Guid("acdb0aeb-6d8a-4b6f-8e7e-7d23ccc9d676"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("50859d81-88f2-4b1b-91b8-2264d2e5a6ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_281f5024435c4ec9a05a2c121240498d;
		public ProcessFlowElement StartMessage4_281f5024435c4ec9a05a2c121240498d {
			get {
				return _startMessage4_281f5024435c4ec9a05a2c121240498d ?? (_startMessage4_281f5024435c4ec9a05a2c121240498d = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_281f5024435c4ec9a05a2c121240498d",
					SchemaElementUId = new Guid("281f5024-435c-4ec9-a05a-2c121240498d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateRemindings;
		public ProcessScriptTask UpdateRemindings {
			get {
				return _updateRemindings ?? (_updateRemindings = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateRemindings",
					SchemaElementUId = new Guid("e8611f67-229b-40da-9486-19b3a1200404"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateRemindingsExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("05e52303-a080-4098-9568-a6af32d76388"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessage2_04ad275234d14819a5cf2b741119275b;
		public ProcessThrowMessageEvent IntermediateThrowMessage2_04ad275234d14819a5cf2b741119275b {
			get {
				return _intermediateThrowMessage2_04ad275234d14819a5cf2b741119275b ?? (_intermediateThrowMessage2_04ad275234d14819a5cf2b741119275b = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessage2_04ad275234d14819a5cf2b741119275b",
					SchemaElementUId = new Guid("04ad2752-34d1-4819-a5cf-2b741119275b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OrderSaved",
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("9d26dc5f-028b-44ca-b507-8cbea959d002"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage3_fac02c993d3b476f9b40bee7a657b3ee.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_fac02c993d3b476f9b40bee7a657b3ee };
			FlowElements[Init.SchemaElementUId] = new Collection<ProcessFlowElement> { Init };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[ScriptTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[GenerateNumberUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateNumberUserTask };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage4_281f5024435c4ec9a05a2c121240498d.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_281f5024435c4ec9a05a2c121240498d };
			FlowElements[UpdateRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateRemindings };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[IntermediateThrowMessage2_04ad275234d14819a5cf2b741119275b.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessage2_04ad275234d14819a5cf2b741119275b };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2":
						break;
					case "StartMessage3_fac02c993d3b476f9b40bee7a657b3ee":
						e.Context.QueueTasks.Enqueue("Init");
						break;
					case "Init":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						e.Context.QueueTasks.Enqueue("ScriptTask5");
						break;
					case "ScriptTask5":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask3");
							break;
						}
						e.Context.QueueTasks.Enqueue("Terminate1");
						break;
					case "Terminate1":
						break;
					case "ScriptTask3":
						e.Context.QueueTasks.Enqueue("GenerateNumberUserTask");
						break;
					case "GenerateNumberUserTask":
							e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "ScriptTask4":
						break;
					case "EventSubProcess1":
						break;
					case "StartMessage4_281f5024435c4ec9a05a2c121240498d":
						e.Context.QueueTasks.Enqueue("UpdateRemindings");
						break;
					case "UpdateRemindings":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessage2_04ad275234d14819a5cf2b741119275b");
						break;
					case "IntermediateThrowMessage2_04ad275234d14819a5cf2b741119275b":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>("Number")));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_fac02c993d3b476f9b40bee7a657b3ee");
			ActivatedEventElements.Add("StartMessage4_281f5024435c4ec9a05a2c121240498d");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_fac02c993d3b476f9b40bee7a657b3ee":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_fac02c993d3b476f9b40bee7a657b3ee";
					result = StartMessage3_fac02c993d3b476f9b40bee7a657b3ee.Execute(context);
					break;
				case "Init":
					context.QueueTasks.Dequeue();
					context.SenderName = "Init";
					result = Init.Execute(context, InitExecute);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "ScriptTask5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5";
					result = ScriptTask5.Execute(context, ScriptTask5Execute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "Terminate1":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "GenerateNumberUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GenerateNumberUserTask";
					result = GenerateNumberUserTask.Execute(context);
					break;
				case "ScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4";
					result = ScriptTask4.Execute(context, ScriptTask4Execute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_281f5024435c4ec9a05a2c121240498d":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_281f5024435c4ec9a05a2c121240498d";
					result = StartMessage4_281f5024435c4ec9a05a2c121240498d.Execute(context);
					break;
				case "UpdateRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateRemindings";
					result = UpdateRemindings.Execute(context, UpdateRemindingsExecute);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "IntermediateThrowMessage2_04ad275234d14819a5cf2b741119275b":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessage2_04ad275234d14819a5cf2b741119275b.Execute(context);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool InitExecute(ProcessExecutingContext context) {
			InitCanGenerateAnniversaryReminding();
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			return ChangeStatus();
		}

		public virtual bool ScriptTask5Execute(ProcessExecutingContext context) {
			return CalculatePrimaryAmount();
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			return SetNumberGenerationParams();
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			return UpdateNumber();
		}

		public virtual bool UpdateRemindingsExecute(ProcessExecutingContext context) {
			return UpdateReminders();
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			UpdateProductAmounts();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Order_Order_TerrasoftSaving":
							if (ActivatedEventElements.Contains("StartMessage3_fac02c993d3b476f9b40bee7a657b3ee")) {
							context.QueueTasks.Enqueue("StartMessage3_fac02c993d3b476f9b40bee7a657b3ee");
							ProcessQueue(context);
							return;
						}
						break;
					case "Order_Order_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage4_281f5024435c4ec9a05a2c121240498d")) {
							context.QueueTasks.Enqueue("StartMessage4_281f5024435c4ec9a05a2c121240498d");
							ProcessQueue(context);
							return;
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Order_OrderEventsProcess

	/// <exclude/>
	public class Order_OrderEventsProcess : Order_OrderEventsProcess<Order_Order_Terrasoft>
	{

		public Order_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


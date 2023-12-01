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

	#region Class: ServiceInServicePact_SLMITILService_TerrasoftSchema

	/// <exclude/>
	public class ServiceInServicePact_SLMITILService_TerrasoftSchema : Terrasoft.Configuration.ServiceInServicePact_CrtSLMITILService7x_TerrasoftSchema
	{

		#region Constructors: Public

		public ServiceInServicePact_SLMITILService_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ServiceInServicePact_SLMITILService_TerrasoftSchema(ServiceInServicePact_SLMITILService_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ServiceInServicePact_SLMITILService_TerrasoftSchema(ServiceInServicePact_SLMITILService_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("7c573f11-2f51-4e17-96f8-ce90ec3147a5");
			Name = "ServiceInServicePact_SLMITILService_Terrasoft";
			ParentSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			ExtendParent = true;
			CreatedInPackageId = new Guid("914c52f8-7161-4b32-82f6-d4cef8b3a889");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
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
			return new ServiceInServicePact_SLMITILService_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ServiceInServicePact_SLMITILServiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ServiceInServicePact_SLMITILService_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ServiceInServicePact_SLMITILService_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c573f11-2f51-4e17-96f8-ce90ec3147a5"));
		}

		#endregion

	}

	#endregion

	#region Class: ServiceInServicePact_SLMITILService_Terrasoft

	/// <summary>
	/// Service in service agreement.
	/// </summary>
	public class ServiceInServicePact_SLMITILService_Terrasoft : Terrasoft.Configuration.ServiceInServicePact_CrtSLMITILService7x_Terrasoft
	{

		#region Constructors: Public

		public ServiceInServicePact_SLMITILService_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ServiceInServicePact_SLMITILService_Terrasoft";
		}

		public ServiceInServicePact_SLMITILService_Terrasoft(ServiceInServicePact_SLMITILService_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ServiceInServicePact_SLMITILServiceEventsProcess(UserConnection);
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
			return new ServiceInServicePact_SLMITILService_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ServiceInServicePact_SLMITILServiceEventsProcess

	/// <exclude/>
	public partial class ServiceInServicePact_SLMITILServiceEventsProcess<TEntity> : Terrasoft.Configuration.ServiceInServicePact_CrtSLMITILService7xEventsProcess<TEntity> where TEntity : ServiceInServicePact_SLMITILService_Terrasoft
	{

		public ServiceInServicePact_SLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ServiceInServicePact_SLMITILServiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7c573f11-2f51-4e17-96f8-ce90ec3147a5");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
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
					SchemaElementUId = new Guid("d4aa7cfd-c8f8-41a4-9137-214f20b94458"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _serviceInServicePactInsertingStartMessage;
		public ProcessFlowElement ServiceInServicePactInsertingStartMessage {
			get {
				return _serviceInServicePactInsertingStartMessage ?? (_serviceInServicePactInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ServiceInServicePactInsertingStartMessage",
					SchemaElementUId = new Guid("2f768b55-8528-4a94-9110-978a433cd29a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("fe21b45d-ebd6-4f00-a066-d92a19047dcf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1_85f663a3a78140e29428ae85eaf7504a;
		public ProcessExclusiveGateway ExclusiveGateway1_85f663a3a78140e29428ae85eaf7504a {
			get {
				return _exclusiveGateway1_85f663a3a78140e29428ae85eaf7504a ?? (_exclusiveGateway1_85f663a3a78140e29428ae85eaf7504a = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1_85f663a3a78140e29428ae85eaf7504a",
					SchemaElementUId = new Guid("85f663a3-a781-40e2-9428-ae85eaf7504a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway1_85f663a3a78140e29428ae85eaf7504a.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent1_680c139470514e32b18fc7e914d57dd5;
		public ProcessTerminateEvent TerminateEvent1_680c139470514e32b18fc7e914d57dd5 {
			get {
				return _terminateEvent1_680c139470514e32b18fc7e914d57dd5 ?? (_terminateEvent1_680c139470514e32b18fc7e914d57dd5 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1_680c139470514e32b18fc7e914d57dd5",
					SchemaElementUId = new Guid("680c1394-7051-4e32-b18f-c7e914d57dd5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4_643c5eb9f4b54a17a3a46e1a0c64ecd3;
		public ProcessFlowElement EventSubProcess4_643c5eb9f4b54a17a3a46e1a0c64ecd3 {
			get {
				return _eventSubProcess4_643c5eb9f4b54a17a3a46e1a0c64ecd3 ?? (_eventSubProcess4_643c5eb9f4b54a17a3a46e1a0c64ecd3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_643c5eb9f4b54a17a3a46e1a0c64ecd3",
					SchemaElementUId = new Guid("643c5eb9-f4b5-4a17-a3a4-6e1a0c64ecd3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_73e1d6e6fc1b4749853379f4a8b982e7;
		public ProcessScriptTask ScriptTask4_73e1d6e6fc1b4749853379f4a8b982e7 {
			get {
				return _scriptTask4_73e1d6e6fc1b4749853379f4a8b982e7 ?? (_scriptTask4_73e1d6e6fc1b4749853379f4a8b982e7 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_73e1d6e6fc1b4749853379f4a8b982e7",
					SchemaElementUId = new Guid("73e1d6e6-fc1b-4749-8533-79f4a8b982e7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_73e1d6e6fc1b4749853379f4a8b982e7Execute,
				});
			}
		}

		private ProcessFlowElement _startMessage4_b7e9ac6b6d024d448ede5702958ce99c;
		public ProcessFlowElement StartMessage4_b7e9ac6b6d024d448ede5702958ce99c {
			get {
				return _startMessage4_b7e9ac6b6d024d448ede5702958ce99c ?? (_startMessage4_b7e9ac6b6d024d448ede5702958ce99c = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_b7e9ac6b6d024d448ede5702958ce99c",
					SchemaElementUId = new Guid("b7e9ac6b-6d02-4d44-8ede-5702958ce99c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent2_023e5edf7e3c4e4bbca982fcbc842b9e;
		public ProcessTerminateEvent TerminateEvent2_023e5edf7e3c4e4bbca982fcbc842b9e {
			get {
				return _terminateEvent2_023e5edf7e3c4e4bbca982fcbc842b9e ?? (_terminateEvent2_023e5edf7e3c4e4bbca982fcbc842b9e = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent2_023e5edf7e3c4e4bbca982fcbc842b9e",
					SchemaElementUId = new Guid("023e5edf-7e3c-4e4b-bca9-82fcbc842b9e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2_742702adf3514f7fa081a50259cc1a6e;
		public ProcessExclusiveGateway ExclusiveGateway2_742702adf3514f7fa081a50259cc1a6e {
			get {
				return _exclusiveGateway2_742702adf3514f7fa081a50259cc1a6e ?? (_exclusiveGateway2_742702adf3514f7fa081a50259cc1a6e = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2_742702adf3514f7fa081a50259cc1a6e",
					SchemaElementUId = new Guid("742702ad-f351-4f7f-a081-a50259cc1a6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway2_742702adf3514f7fa081a50259cc1a6e.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow1_055aef24b57f4fd9849c8cbd02701ae2;
		public ProcessConditionalFlow ConditionalSequenceFlow1_055aef24b57f4fd9849c8cbd02701ae2 {
			get {
				return _conditionalSequenceFlow1_055aef24b57f4fd9849c8cbd02701ae2 ?? (_conditionalSequenceFlow1_055aef24b57f4fd9849c8cbd02701ae2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1_055aef24b57f4fd9849c8cbd02701ae2",
					SchemaElementUId = new Guid("055aef24-b57f-4fd9-849c-8cbd02701ae2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow3_c013b0df87d44d99927fe229c8da6c8b;
		public ProcessConditionalFlow ConditionalSequenceFlow3_c013b0df87d44d99927fe229c8da6c8b {
			get {
				return _conditionalSequenceFlow3_c013b0df87d44d99927fe229c8da6c8b ?? (_conditionalSequenceFlow3_c013b0df87d44d99927fe229c8da6c8b = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow3_c013b0df87d44d99927fe229c8da6c8b",
					SchemaElementUId = new Guid("c013b0df-87d4-4d99-927f-e229c8da6c8b"),
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
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ServiceInServicePactInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ServiceInServicePactInsertingStartMessage };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[ExclusiveGateway1_85f663a3a78140e29428ae85eaf7504a.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1_85f663a3a78140e29428ae85eaf7504a };
			FlowElements[TerminateEvent1_680c139470514e32b18fc7e914d57dd5.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1_680c139470514e32b18fc7e914d57dd5 };
			FlowElements[EventSubProcess4_643c5eb9f4b54a17a3a46e1a0c64ecd3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_643c5eb9f4b54a17a3a46e1a0c64ecd3 };
			FlowElements[ScriptTask4_73e1d6e6fc1b4749853379f4a8b982e7.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_73e1d6e6fc1b4749853379f4a8b982e7 };
			FlowElements[StartMessage4_b7e9ac6b6d024d448ede5702958ce99c.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_b7e9ac6b6d024d448ede5702958ce99c };
			FlowElements[TerminateEvent2_023e5edf7e3c4e4bbca982fcbc842b9e.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent2_023e5edf7e3c4e4bbca982fcbc842b9e };
			FlowElements[ExclusiveGateway2_742702adf3514f7fa081a50259cc1a6e.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2_742702adf3514f7fa081a50259cc1a6e };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ServiceInServicePactInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1_85f663a3a78140e29428ae85eaf7504a");
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("TerminateEvent1_680c139470514e32b18fc7e914d57dd5");
						break;
					case "ExclusiveGateway1_85f663a3a78140e29428ae85eaf7504a":
						if (ConditionalSequenceFlow1_055aef24b57f4fd9849c8cbd02701ae2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask1");
							break;
						}
						e.Context.QueueTasks.Enqueue("TerminateEvent1_680c139470514e32b18fc7e914d57dd5");
						break;
					case "TerminateEvent1_680c139470514e32b18fc7e914d57dd5":
						break;
					case "EventSubProcess4_643c5eb9f4b54a17a3a46e1a0c64ecd3":
						break;
					case "ScriptTask4_73e1d6e6fc1b4749853379f4a8b982e7":
						e.Context.QueueTasks.Enqueue("TerminateEvent2_023e5edf7e3c4e4bbca982fcbc842b9e");
						break;
					case "StartMessage4_b7e9ac6b6d024d448ede5702958ce99c":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2_742702adf3514f7fa081a50259cc1a6e");
						break;
					case "TerminateEvent2_023e5edf7e3c4e4bbca982fcbc842b9e":
						break;
					case "ExclusiveGateway2_742702adf3514f7fa081a50259cc1a6e":
						if (ConditionalSequenceFlow3_c013b0df87d44d99927fe229c8da6c8bExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask4_73e1d6e6fc1b4749853379f4a8b982e7");
							break;
						}
						e.Context.QueueTasks.Enqueue("TerminateEvent2_023e5edf7e3c4e4bbca982fcbc842b9e");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalSequenceFlow1_055aef24b57f4fd9849c8cbd02701ae2ExpressionExecute() {
			return Convert.ToBoolean(UserConnection.GetIsFeatureEnabled("UseServiceInServicePactInSLMITILServiceOldFunc"));
		}

		private bool ConditionalSequenceFlow3_c013b0df87d44d99927fe229c8da6c8bExpressionExecute() {
			return Convert.ToBoolean(UserConnection.GetIsFeatureEnabled("UseServiceInServicePactInSLMITILServiceOldFunc"));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ServiceInServicePactInsertingStartMessage");
			ActivatedEventElements.Add("StartMessage4_b7e9ac6b6d024d448ede5702958ce99c");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ServiceInServicePactInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ServiceInServicePactInsertingStartMessage";
					result = ServiceInServicePactInsertingStartMessage.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "ExclusiveGateway1_85f663a3a78140e29428ae85eaf7504a":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1_85f663a3a78140e29428ae85eaf7504a";
					result = ExclusiveGateway1_85f663a3a78140e29428ae85eaf7504a.Execute(context);
					break;
				case "TerminateEvent1_680c139470514e32b18fc7e914d57dd5":
					context.QueueTasks.Dequeue();
					break;
				case "EventSubProcess4_643c5eb9f4b54a17a3a46e1a0c64ecd3":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTask4_73e1d6e6fc1b4749853379f4a8b982e7":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_73e1d6e6fc1b4749853379f4a8b982e7";
					result = ScriptTask4_73e1d6e6fc1b4749853379f4a8b982e7.Execute(context, ScriptTask4_73e1d6e6fc1b4749853379f4a8b982e7Execute);
					break;
				case "StartMessage4_b7e9ac6b6d024d448ede5702958ce99c":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_b7e9ac6b6d024d448ede5702958ce99c";
					result = StartMessage4_b7e9ac6b6d024d448ede5702958ce99c.Execute(context);
					break;
				case "TerminateEvent2_023e5edf7e3c4e4bbca982fcbc842b9e":
					context.QueueTasks.Dequeue();
					break;
				case "ExclusiveGateway2_742702adf3514f7fa081a50259cc1a6e":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2_742702adf3514f7fa081a50259cc1a6e";
					result = ExclusiveGateway2_742702adf3514f7fa081a50259cc1a6e.Execute(context);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ServiceItem");
			var idColumnName = esq.AddColumn(esq.RootSchema.GetPrimaryColumnName()); 
			var reactionTimeValueColumnName = esq.AddColumn("ReactionTimeValue").Name;
			var reactionTimeUnitColumnName = esq.AddColumn("ReactionTimeUnit.Id").Name;
			var reactionTimeColumnName = esq.AddColumn("ReactionTime").Name;
			var solutionTimeValueColumnName = esq.AddColumn("SolutionTimeValue").Name;
			var solutionTimeUnitColumnName = esq.AddColumn("SolutionTimeUnit.Id").Name;
			var solutionTimeColumnName = esq.AddColumn("SolutionTime").Name;
			var statusColumnName = esq.AddColumn("Status.Id").Name;
			var filter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", 
					Entity.GetTypedColumnValue<Guid>("ServiceItemId"));
			esq.Filters.Add(filter);
			string serviceItemName = GetServiceItemName();
			string servicePactName = GetServicePactName();
			var entityCollection = esq.GetEntityCollection(UserConnection);
			foreach(var entity in entityCollection) {
				Entity.SetColumnValue("ReactionTimeValue", entity.GetTypedColumnValue<int>(reactionTimeValueColumnName));
				Entity.SetColumnValue("ReactionTimeUnitId", entity.GetTypedColumnValue<Guid>(reactionTimeUnitColumnName));
				Entity.SetColumnValue("ReactionTime", entity.GetTypedColumnValue<string>(reactionTimeColumnName));
				Entity.SetColumnValue("SolutionTimeValue", entity.GetTypedColumnValue<int>(solutionTimeValueColumnName));
				Entity.SetColumnValue("SolutionTimeUnitId", entity.GetTypedColumnValue<Guid>(solutionTimeUnitColumnName));
				Entity.SetColumnValue("SolutionTime", entity.GetTypedColumnValue<string>(solutionTimeColumnName));
				Entity.SetColumnValue("StatusId", entity.GetTypedColumnValue<Guid>(statusColumnName));
				if(serviceItemName != null && servicePactName != null) {
					string concatName = serviceItemName + " " + servicePactName;
					concatName = concatName.Length > 500 ? concatName.Substring(0, 500) : concatName;
					Entity.SetColumnValue("ConcatName", concatName);
				} else {
					Entity.SetColumnValue("ConcatName", "Default name");
				}
			} 
			return true;
		}

		public virtual bool ScriptTask4_73e1d6e6fc1b4749853379f4a8b982e7Execute(ProcessExecutingContext context) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "TimeUnit");
			esq.AddColumn("Name");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", Entity.GetTypedColumnValue<Guid>("ReactionTimeUnitId")));
			var entityCollection = esq.GetEntityCollection(UserConnection);
			if(entityCollection.Count > 0) {
				Entity.SetColumnValue("ReactionTime",Entity.GetTypedColumnValue<int>("ReactionTimeValue").ToString()+" "+entityCollection[0].GetTypedColumnValue<string>("Name"));
			}
			esq.Filters.Clear();
			esq.ResetSelectQuery();
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", Entity.GetTypedColumnValue<Guid>("SolutionTimeUnitId")));
			entityCollection = esq.GetEntityCollection(UserConnection);
			if(entityCollection.Count > 0) {
				Entity.SetColumnValue("SolutionTime",Entity.GetTypedColumnValue<int>("SolutionTimeValue").ToString()+" "+entityCollection[0].GetTypedColumnValue<string>("Name"));
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ServiceInServicePactInserting":
							if (ActivatedEventElements.Contains("ServiceInServicePactInsertingStartMessage")) {
							context.QueueTasks.Enqueue("ServiceInServicePactInsertingStartMessage");
						}
						break;
					case "ServiceInServicePactSaving":
							if (ActivatedEventElements.Contains("StartMessage4_b7e9ac6b6d024d448ede5702958ce99c")) {
							context.QueueTasks.Enqueue("StartMessage4_b7e9ac6b6d024d448ede5702958ce99c");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: ServiceInServicePact_SLMITILServiceEventsProcess

	/// <exclude/>
	public class ServiceInServicePact_SLMITILServiceEventsProcess : ServiceInServicePact_SLMITILServiceEventsProcess<ServiceInServicePact_SLMITILService_Terrasoft>
	{

		public ServiceInServicePact_SLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


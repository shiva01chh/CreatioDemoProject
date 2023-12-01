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

	#region Class: Invoice_Invoice_TerrasoftSchema

	/// <exclude/>
	public class Invoice_Invoice_TerrasoftSchema : Terrasoft.Configuration.Invoice_CrtInvoiceContract_TerrasoftSchema
	{

		#region Constructors: Public

		public Invoice_Invoice_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Invoice_Invoice_TerrasoftSchema(Invoice_Invoice_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Invoice_Invoice_TerrasoftSchema(Invoice_Invoice_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("43aed55f-497a-41ea-b194-2200daec61e2");
			Name = "Invoice_Invoice_Terrasoft";
			ParentSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreatePaymentStatusColumn() {
			EntitySchemaColumn column = base.CreatePaymentStatusColumn();
			column.ModifiedInSchemaUId = new Guid("43aed55f-497a-41ea-b194-2200daec61e2");
			return column;
		}

		protected override EntitySchemaColumn CreateOwnerColumn() {
			EntitySchemaColumn column = base.CreateOwnerColumn();
			column.ModifiedInSchemaUId = new Guid("43aed55f-497a-41ea-b194-2200daec61e2");
			return column;
		}

		protected override EntitySchemaColumn CreateCurrencyColumn() {
			EntitySchemaColumn column = base.CreateCurrencyColumn();
			column.ModifiedInSchemaUId = new Guid("43aed55f-497a-41ea-b194-2200daec61e2");
			return column;
		}

		protected override EntitySchemaColumn CreateSupplierColumn() {
			EntitySchemaColumn column = base.CreateSupplierColumn();
			column.ModifiedInSchemaUId = new Guid("43aed55f-497a-41ea-b194-2200daec61e2");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Invoice_Invoice_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Invoice_InvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Invoice_Invoice_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Invoice_Invoice_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("43aed55f-497a-41ea-b194-2200daec61e2"));
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_Invoice_Terrasoft

	/// <summary>
	/// Invoice.
	/// </summary>
	public class Invoice_Invoice_Terrasoft : Terrasoft.Configuration.Invoice_CrtInvoiceContract_Terrasoft
	{

		#region Constructors: Public

		public Invoice_Invoice_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Invoice_Invoice_Terrasoft";
		}

		public Invoice_Invoice_Terrasoft(Invoice_Invoice_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Invoice_InvoiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("Invoice_Invoice_TerrasoftDeleting", e);
			Saved += (s, e) => ThrowEvent("Invoice_Invoice_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Invoice_Invoice_TerrasoftSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Invoice_Invoice_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_InvoiceEventsProcess

	/// <exclude/>
	public partial class Invoice_InvoiceEventsProcess<TEntity> : Terrasoft.Configuration.Invoice_CrtInvoiceContractEventsProcess<TEntity> where TEntity : Invoice_Invoice_Terrasoft
	{

		#region Class: SynchronizeSubjectRemindingFlowElement

		/// <exclude/>
		public class SynchronizeSubjectRemindingFlowElement : SynchronizeSubjectRemindingUserTask
		{

			public SynchronizeSubjectRemindingFlowElement(UserConnection userConnection, Invoice_InvoiceEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SynchronizeSubjectReminding";
				IsLogging = false;
				SchemaElementUId = new Guid("3e62c94f-11ec-40e0-a245-e8c8b8ca2953");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: GenerateNumberUserTaskFlowElement

		/// <exclude/>
		public class GenerateNumberUserTaskFlowElement : GenerateSequenseNumberUserTask
		{

			public GenerateNumberUserTaskFlowElement(UserConnection userConnection, Invoice_InvoiceEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GenerateNumberUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("2ee97f9a-cd0f-4c0e-9f80-447601df9118");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Invoice_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Invoice_InvoiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("43aed55f-497a-41ea-b194-2200daec61e2");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcessInvoiceSaving;
		public ProcessFlowElement EventSubProcessInvoiceSaving {
			get {
				return _eventSubProcessInvoiceSaving ?? (_eventSubProcessInvoiceSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessInvoiceSaving",
					SchemaElementUId = new Guid("36a68c92-f1ae-4f91-8bcf-5ab36617f6bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _invoiceSaving;
		public ProcessFlowElement InvoiceSaving {
			get {
				return _invoiceSaving ?? (_invoiceSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InvoiceSaving",
					SchemaElementUId = new Guid("28d2c42f-ba50-4998-b1fc-a061e21cc50a"),
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
					SchemaElementUId = new Guid("ea77e1f8-89c6-46c7-880a-27b90ce2a9e3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessScriptTask _scriptInvoiceSaving;
		public ProcessScriptTask ScriptInvoiceSaving {
			get {
				return _scriptInvoiceSaving ?? (_scriptInvoiceSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInvoiceSaving",
					SchemaElementUId = new Guid("33b62cb2-243e-4cee-86f8-20a4d35b48f2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInvoiceSavingExecute,
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
					SchemaElementUId = new Guid("3eb280f3-4ba4-44ed-bdd1-b3f3527fe6f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _synchronizeRemindingsMessage;
		public ProcessFlowElement SynchronizeRemindingsMessage {
			get {
				return _synchronizeRemindingsMessage ?? (_synchronizeRemindingsMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SynchronizeRemindingsMessage",
					SchemaElementUId = new Guid("6b40c3e0-db72-48de-8b0d-7e4e2ddf6523"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInvoiceSaved;
		public ProcessScriptTask ScriptInvoiceSaved {
			get {
				return _scriptInvoiceSaved ?? (_scriptInvoiceSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInvoiceSaved",
					SchemaElementUId = new Guid("ca407b5e-c767-4bd1-94eb-d96384bf6fc5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInvoiceSavedExecute,
				});
			}
		}

		private SynchronizeSubjectRemindingFlowElement _synchronizeSubjectReminding;
		public SynchronizeSubjectRemindingFlowElement SynchronizeSubjectReminding {
			get {
				return _synchronizeSubjectReminding ?? (_synchronizeSubjectReminding = new SynchronizeSubjectRemindingFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcessInvoiceSaved;
		public ProcessFlowElement EventSubProcessInvoiceSaved {
			get {
				return _eventSubProcessInvoiceSaved ?? (_eventSubProcessInvoiceSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessInvoiceSaved",
					SchemaElementUId = new Guid("c2d1dc01-253a-413e-a448-eccc39c922a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _invoiceSaved;
		public ProcessFlowElement InvoiceSaved {
			get {
				return _invoiceSaved ?? (_invoiceSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InvoiceSaved",
					SchemaElementUId = new Guid("1a22c78c-c2ff-4a1f-b67a-c687299c0c70"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setGenerateParamScript;
		public ProcessScriptTask SetGenerateParamScript {
			get {
				return _setGenerateParamScript ?? (_setGenerateParamScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetGenerateParamScript",
					SchemaElementUId = new Guid("2639594e-c8ff-4e6d-b902-377980f53d1f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetGenerateParamScriptExecute,
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
					SchemaElementUId = new Guid("44155528-6dbc-416e-a5cf-391a0699eeb8"),
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

		private GenerateNumberUserTaskFlowElement _generateNumberUserTask;
		public GenerateNumberUserTaskFlowElement GenerateNumberUserTask {
			get {
				return _generateNumberUserTask ?? (_generateNumberUserTask = new GenerateNumberUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _setGeneratedNumberScript;
		public ProcessScriptTask SetGeneratedNumberScript {
			get {
				return _setGeneratedNumberScript ?? (_setGeneratedNumberScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetGeneratedNumberScript",
					SchemaElementUId = new Guid("8624e2bc-c2ec-4b8e-bab3-452368ae5d3f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetGeneratedNumberScriptExecute,
				});
			}
		}

		private ProcessTerminateEvent _end1;
		public ProcessTerminateEvent End1 {
			get {
				return _end1 ?? (_end1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "End1",
					SchemaElementUId = new Guid("3824f366-50b5-45ec-9ac0-b50396cd2442"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _synchronizeRemindingsIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent SynchronizeRemindingsIntermediateThrowMessageEvent {
			get {
				return _synchronizeRemindingsIntermediateThrowMessageEvent ?? (_synchronizeRemindingsIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SynchronizeRemindingsIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("a93ba837-4e39-4b09-8c58-5ea3135b60b5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SynchronizeRemindings",
				});
			}
		}

		private ProcessScriptTask _financeRecalculationScriptTask;
		public ProcessScriptTask FinanceRecalculationScriptTask {
			get {
				return _financeRecalculationScriptTask ?? (_financeRecalculationScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FinanceRecalculationScriptTask",
					SchemaElementUId = new Guid("6b3bb13b-8f11-4638-bdc4-4432d57d8a98"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = FinanceRecalculationScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessInvoiceDeleting;
		public ProcessFlowElement EventSubProcessInvoiceDeleting {
			get {
				return _eventSubProcessInvoiceDeleting ?? (_eventSubProcessInvoiceDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessInvoiceDeleting",
					SchemaElementUId = new Guid("507193df-5999-4863-8ba4-3c072e330006"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _invoiceDeletingStartMessage;
		public ProcessFlowElement InvoiceDeletingStartMessage {
			get {
				return _invoiceDeletingStartMessage ?? (_invoiceDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InvoiceDeletingStartMessage",
					SchemaElementUId = new Guid("459b83a7-7216-4f6b-a399-e59981c5320c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _invoiceDeletingScriptTask;
		public ProcessScriptTask InvoiceDeletingScriptTask {
			get {
				return _invoiceDeletingScriptTask ?? (_invoiceDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InvoiceDeletingScriptTask",
					SchemaElementUId = new Guid("a336b743-cfdf-4537-bae3-068cbadec0d1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InvoiceDeletingScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _synchronizeRemindingsOnDeleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent {
			get {
				return _synchronizeRemindingsOnDeleteIntermediateThrowMessageEvent ?? (_synchronizeRemindingsOnDeleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("a8e5d862-b16d-4a57-8ae2-af9673feba14"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SynchronizeRemindings",
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1232;
		public ProcessConditionalFlow ConditionalFlow1232 {
			get {
				return _conditionalFlow1232 ?? (_conditionalFlow1232 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1232",
					SchemaElementUId = new Guid("4a658c4a-dd38-4190-8483-682c30ff4d37"),
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
			FlowElements[EventSubProcessInvoiceSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessInvoiceSaving };
			FlowElements[InvoiceSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceSaving };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[ScriptInvoiceSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInvoiceSaving };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[SynchronizeRemindingsMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeRemindingsMessage };
			FlowElements[ScriptInvoiceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInvoiceSaved };
			FlowElements[SynchronizeSubjectReminding.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeSubjectReminding };
			FlowElements[EventSubProcessInvoiceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessInvoiceSaved };
			FlowElements[InvoiceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceSaved };
			FlowElements[SetGenerateParamScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetGenerateParamScript };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[GenerateNumberUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateNumberUserTask };
			FlowElements[SetGeneratedNumberScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetGeneratedNumberScript };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[SynchronizeRemindingsIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeRemindingsIntermediateThrowMessageEvent };
			FlowElements[FinanceRecalculationScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FinanceRecalculationScriptTask };
			FlowElements[EventSubProcessInvoiceDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessInvoiceDeleting };
			FlowElements[InvoiceDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceDeletingStartMessage };
			FlowElements[InvoiceDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceDeletingScriptTask };
			FlowElements[SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessInvoiceSaving":
						break;
					case "InvoiceSaving":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("ScriptInvoiceSaving");
						break;
					case "ScriptInvoiceSaving":
						break;
					case "EventSubProcess1":
						break;
					case "SynchronizeRemindingsMessage":
						e.Context.QueueTasks.Enqueue("ScriptInvoiceSaved");
						break;
					case "ScriptInvoiceSaved":
						e.Context.QueueTasks.Enqueue("SynchronizeSubjectReminding");
						break;
					case "SynchronizeSubjectReminding":
						break;
					case "EventSubProcessInvoiceSaved":
						break;
					case "InvoiceSaved":
						e.Context.QueueTasks.Enqueue("SetGenerateParamScript");
						e.Context.QueueTasks.Enqueue("SynchronizeRemindingsIntermediateThrowMessageEvent");
						e.Context.QueueTasks.Enqueue("FinanceRecalculationScriptTask");
						break;
					case "SetGenerateParamScript":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1232ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("GenerateNumberUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("End1");
						break;
					case "GenerateNumberUserTask":
							e.Context.QueueTasks.Enqueue("SetGeneratedNumberScript");
						break;
					case "SetGeneratedNumberScript":
						break;
					case "End1":
						break;
					case "SynchronizeRemindingsIntermediateThrowMessageEvent":
						break;
					case "FinanceRecalculationScriptTask":
						break;
					case "EventSubProcessInvoiceDeleting":
						break;
					case "InvoiceDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("InvoiceDeletingScriptTask");
						break;
					case "InvoiceDeletingScriptTask":
						e.Context.QueueTasks.Enqueue("SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent");
						break;
					case "SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1232ExpressionExecute() {
			return Convert.ToBoolean(string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>("Number")));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("InvoiceSaving");
			ActivatedEventElements.Add("SynchronizeRemindingsMessage");
			ActivatedEventElements.Add("InvoiceSaved");
			ActivatedEventElements.Add("InvoiceDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessInvoiceSaving":
					context.QueueTasks.Dequeue();
					break;
				case "InvoiceSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceSaving";
					result = InvoiceSaving.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "ScriptInvoiceSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInvoiceSaving";
					result = ScriptInvoiceSaving.Execute(context, ScriptInvoiceSavingExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "SynchronizeRemindingsMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeRemindingsMessage";
					result = SynchronizeRemindingsMessage.Execute(context);
					break;
				case "ScriptInvoiceSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInvoiceSaved";
					result = ScriptInvoiceSaved.Execute(context, ScriptInvoiceSavedExecute);
					break;
				case "SynchronizeSubjectReminding":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeSubjectReminding";
					result = SynchronizeSubjectReminding.Execute(context);
					break;
				case "EventSubProcessInvoiceSaved":
					context.QueueTasks.Dequeue();
					break;
				case "InvoiceSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceSaved";
					result = InvoiceSaved.Execute(context);
					break;
				case "SetGenerateParamScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetGenerateParamScript";
					result = SetGenerateParamScript.Execute(context, SetGenerateParamScriptExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "GenerateNumberUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GenerateNumberUserTask";
					result = GenerateNumberUserTask.Execute(context);
					break;
				case "SetGeneratedNumberScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetGeneratedNumberScript";
					result = SetGeneratedNumberScript.Execute(context, SetGeneratedNumberScriptExecute);
					break;
				case "End1":
					context.QueueTasks.Dequeue();
					break;
				case "SynchronizeRemindingsIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = SynchronizeRemindingsIntermediateThrowMessageEvent.Execute(context);
					break;
				case "FinanceRecalculationScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "FinanceRecalculationScriptTask";
					result = FinanceRecalculationScriptTask.Execute(context, FinanceRecalculationScriptTaskExecute);
					break;
				case "EventSubProcessInvoiceDeleting":
					context.QueueTasks.Dequeue();
					break;
				case "InvoiceDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceDeletingStartMessage";
					result = InvoiceDeletingStartMessage.Execute(context);
					break;
				case "InvoiceDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceDeletingScriptTask";
					result = InvoiceDeletingScriptTask.Execute(context, InvoiceDeletingScriptTaskExecute);
					break;
				case "SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = SynchronizeRemindingsOnDeleteIntermediateThrowMessageEvent.Execute(context);
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
			return UpdatePrimaryAmount();
		}

		public virtual bool ScriptInvoiceSavingExecute(ProcessExecutingContext context) {
			OnSaving();
			return true;
		}

		public virtual bool ScriptInvoiceSavedExecute(ProcessExecutingContext context) {
			var active = !Entity.IsInDeleting && !IsFinalStatus() && Entity.GetTypedColumnValue<bool>("RemindToOwner");
			var ownerRemindingSourceTypeId = "a76d08e1-2e2d-e011-ac0a-00155d043205";
			SynchronizeSubjectReminding.Active = active;
			SynchronizeSubjectReminding.SubjectPrimaryColumnValue = Entity.GetTypedColumnValue<Guid>("Id");
			SynchronizeSubjectReminding.Contact = Entity.GetTypedColumnValue<Guid>("OwnerId");
			SynchronizeSubjectReminding.Source = new Guid(ownerRemindingSourceTypeId);
			SynchronizeSubjectReminding.RemindTime = Entity.GetTypedColumnValue<DateTime>("RemindToOwnerDate");
			SynchronizeSubjectReminding.SysEntitySchema = Entity.Schema.UId;
			SynchronizeSubjectReminding.NotificationType = RemindingConsts.NotificationTypeRemindingId;
			if (UserConnection.GetIsFeatureEnabled("NotificationV2") && active) {
				IRemindingTextFormer textFormer = ClassFactory.Get<InvoiceRemindingTextFormer>(
					new ConstructorArgument("userConnection", UserConnection));
				string invoiceNumber = Entity.GetTypedColumnValue<string>("Number");
				DateTime startDate = Entity.GetTypedColumnValue<DateTime>("StartDate");
				string accountName = GetLookupDisplayColumnValue(Entity, "Account");
				string contactName = GetLookupDisplayColumnValue(Entity, "Contact");
				SynchronizeSubjectReminding.SubjectCaption =  textFormer.GetBody(new Dictionary<string, object> {
					{"Number", invoiceNumber},
					{"StartDate", startDate},
					{"AccountName", accountName},
					{"ContactName", contactName}
				});
				SynchronizeSubjectReminding.Description = invoiceNumber;
				SynchronizeSubjectReminding.PopupTitle = textFormer.GetTitle(null);
				SynchronizeSubjectReminding.IsSingleReminder = IsOwnerChanged;
			}
			return true;
		}

		public virtual bool SetGenerateParamScriptExecute(ProcessExecutingContext context) {
			GenerateNumberUserTask.EntitySchema = Entity.Schema;
			return true;
		}

		public virtual bool SetGeneratedNumberScriptExecute(ProcessExecutingContext context) {
			string code = GenerateNumberUserTask.ResultCode;
			var update = new Update(UserConnection, Entity.Schema.Name)
				.Set("Number", Column.Parameter(code))
				.Where("Id").IsEqual(Column.Parameter(Entity.PrimaryColumnValue));
			update.Execute();
			return true;
		}

		public virtual bool FinanceRecalculationScriptTaskExecute(ProcessExecutingContext context) {
			OnSaved();
			return true;
		}

		public virtual bool InvoiceDeletingScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Invoice_Invoice_TerrasoftSaving":
							if (ActivatedEventElements.Contains("InvoiceSaving")) {
							context.QueueTasks.Enqueue("InvoiceSaving");
							ProcessQueue(context);
							return;
						}
						break;
					case "SynchronizeRemindings":
							if (ActivatedEventElements.Contains("SynchronizeRemindingsMessage")) {
							context.QueueTasks.Enqueue("SynchronizeRemindingsMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "Invoice_Invoice_TerrasoftSaved":
							if (ActivatedEventElements.Contains("InvoiceSaved")) {
							context.QueueTasks.Enqueue("InvoiceSaved");
							ProcessQueue(context);
							return;
						}
						break;
					case "Invoice_Invoice_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("InvoiceDeletingStartMessage")) {
							context.QueueTasks.Enqueue("InvoiceDeletingStartMessage");
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

	#region Class: Invoice_InvoiceEventsProcess

	/// <exclude/>
	public class Invoice_InvoiceEventsProcess : Invoice_InvoiceEventsProcess<Invoice_Invoice_Terrasoft>
	{

		public Invoice_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


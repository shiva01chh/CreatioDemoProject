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

	#region Class: Document_Document_TerrasoftSchema

	/// <exclude/>
	public class Document_Document_TerrasoftSchema : Terrasoft.Configuration.Document_CrtOrderDocument_TerrasoftSchema
	{

		#region Constructors: Public

		public Document_Document_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Document_Document_TerrasoftSchema(Document_Document_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Document_Document_TerrasoftSchema(Document_Document_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("2d430460-3822-44db-892c-6b8dd675827f");
			Name = "Document_Document_Terrasoft";
			ParentSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a4c567a6-b37c-4fa1-91db-ec1c077c3a21");
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
			return new Document_Document_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Document_DocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Document_Document_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Document_Document_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2d430460-3822-44db-892c-6b8dd675827f"));
		}

		#endregion

	}

	#endregion

	#region Class: Document_Document_Terrasoft

	/// <summary>
	/// Document.
	/// </summary>
	public class Document_Document_Terrasoft : Terrasoft.Configuration.Document_CrtOrderDocument_Terrasoft
	{

		#region Constructors: Public

		public Document_Document_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Document_Document_Terrasoft";
		}

		public Document_Document_Terrasoft(Document_Document_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Document_DocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("Document_Document_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Document_Document_TerrasoftInserted", e);
			Saved += (s, e) => ThrowEvent("Document_Document_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Document_Document_TerrasoftSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Document_Document_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Document_DocumentEventsProcess

	/// <exclude/>
	public partial class Document_DocumentEventsProcess<TEntity> : Terrasoft.Configuration.Document_CrtOrderDocumentEventsProcess<TEntity> where TEntity : Document_Document_Terrasoft
	{

		#region Class: GenerateNumberUserTaskFlowElement

		/// <exclude/>
		public class GenerateNumberUserTaskFlowElement : GenerateSequenseNumberUserTask
		{

			public GenerateNumberUserTaskFlowElement(UserConnection userConnection, Document_DocumentEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GenerateNumberUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("0703cd24-bd8d-4484-b307-4d9da2b9a092");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Document_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Document_DocumentEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2d430460-3822-44db-892c-6b8dd675827f");
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
					SchemaElementUId = new Guid("9e8daa8f-4b5b-4305-9929-9eb16985905c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_84598c9f1e0a4b1586f92ff3674c2085;
		public ProcessFlowElement StartMessage3_84598c9f1e0a4b1586f92ff3674c2085 {
			get {
				return _startMessage3_84598c9f1e0a4b1586f92ff3674c2085 ?? (_startMessage3_84598c9f1e0a4b1586f92ff3674c2085 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_84598c9f1e0a4b1586f92ff3674c2085",
					SchemaElementUId = new Guid("84598c9f-1e0a-4b15-86f9-2ff3674c2085"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _documentDeletingScriptTask;
		public ProcessScriptTask DocumentDeletingScriptTask {
			get {
				return _documentDeletingScriptTask ?? (_documentDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DocumentDeletingScriptTask",
					SchemaElementUId = new Guid("6055ec05-e1ef-483b-8640-426c1d20d3b9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DocumentDeletingScriptTaskExecute,
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
					SchemaElementUId = new Guid("b5136944-229d-4503-a3a5-277eec92c1be"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_187ffbd8f9f44e518e4e58ea7d034cf1;
		public ProcessFlowElement StartMessage4_187ffbd8f9f44e518e4e58ea7d034cf1 {
			get {
				return _startMessage4_187ffbd8f9f44e518e4e58ea7d034cf1 ?? (_startMessage4_187ffbd8f9f44e518e4e58ea7d034cf1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_187ffbd8f9f44e518e4e58ea7d034cf1",
					SchemaElementUId = new Guid("187ffbd8-f9f4-4e51-8e4e-58ea7d034cf1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _documentInsertedScriptTask;
		public ProcessScriptTask DocumentInsertedScriptTask {
			get {
				return _documentInsertedScriptTask ?? (_documentInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DocumentInsertedScriptTask",
					SchemaElementUId = new Guid("478c6227-7a6d-42b7-87ea-9fdbd6081f6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DocumentInsertedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessDocumentSaving;
		public ProcessFlowElement EventSubProcessDocumentSaving {
			get {
				return _eventSubProcessDocumentSaving ?? (_eventSubProcessDocumentSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessDocumentSaving",
					SchemaElementUId = new Guid("9f9ed578-d858-4b40-81af-574ef7e7cd37"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5_930f40308b0b430293a1732af3f69628;
		public ProcessFlowElement StartMessage5_930f40308b0b430293a1732af3f69628 {
			get {
				return _startMessage5_930f40308b0b430293a1732af3f69628 ?? (_startMessage5_930f40308b0b430293a1732af3f69628 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5_930f40308b0b430293a1732af3f69628",
					SchemaElementUId = new Guid("930f4030-8b0b-4302-93a1-732af3f69628"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDocumentSaving;
		public ProcessScriptTask ScriptDocumentSaving {
			get {
				return _scriptDocumentSaving ?? (_scriptDocumentSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDocumentSaving",
					SchemaElementUId = new Guid("64b7298d-af20-4b3a-85bc-5a163dd977a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDocumentSavingExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess1;
		public ProcessFlowElement SubProcess1 {
			get {
				return _subProcess1 ?? (_subProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess1",
					SchemaElementUId = new Guid("745fe82a-3482-4083-b9aa-18e152695c4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage6_06d4e25661e543bcbe34de8d7dec4696;
		public ProcessFlowElement StartMessage6_06d4e25661e543bcbe34de8d7dec4696 {
			get {
				return _startMessage6_06d4e25661e543bcbe34de8d7dec4696 ?? (_startMessage6_06d4e25661e543bcbe34de8d7dec4696 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage6_06d4e25661e543bcbe34de8d7dec4696",
					SchemaElementUId = new Guid("06d4e256-61e5-43bc-be34-de8d7dec4696"),
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
					SchemaElementUId = new Guid("76851729-cc33-40d0-a1c2-b7f6f5f6855a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetGenerateParamScriptExecute,
				});
			}
		}

		private ProcessScriptTask _changeRightsScriptTask;
		public ProcessScriptTask ChangeRightsScriptTask {
			get {
				return _changeRightsScriptTask ?? (_changeRightsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeRightsScriptTask",
					SchemaElementUId = new Guid("11d1627c-0ee6-49b9-9c10-cae7cb8f4046"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeRightsScriptTaskExecute,
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
					SchemaElementUId = new Guid("f0e4ae4c-77f0-4b6e-9139-4c26f3bd7a17"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = FinanceRecalculationScriptTaskExecute,
				});
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
					SchemaElementUId = new Guid("71ec0cab-4ba1-4547-a0a0-a16e30d642b5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetGeneratedNumberScriptExecute,
				});
			}
		}

		private GenerateNumberUserTaskFlowElement _generateNumberUserTask;
		public GenerateNumberUserTaskFlowElement GenerateNumberUserTask {
			get {
				return _generateNumberUserTask ?? (_generateNumberUserTask = new GenerateNumberUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2_72c1d2ea32bf4eeab7870e2647d97e19;
		public ProcessExclusiveGateway ExclusiveGateway2_72c1d2ea32bf4eeab7870e2647d97e19 {
			get {
				return _exclusiveGateway2_72c1d2ea32bf4eeab7870e2647d97e19 ?? (_exclusiveGateway2_72c1d2ea32bf4eeab7870e2647d97e19 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2_72c1d2ea32bf4eeab7870e2647d97e19",
					SchemaElementUId = new Guid("72c1d2ea-32bf-4eea-b787-0e2647d97e19"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway2_72c1d2ea32bf4eeab7870e2647d97e19.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent1_b889f809958148c58ded4d9cd83365ff;
		public ProcessTerminateEvent TerminateEvent1_b889f809958148c58ded4d9cd83365ff {
			get {
				return _terminateEvent1_b889f809958148c58ded4d9cd83365ff ?? (_terminateEvent1_b889f809958148c58ded4d9cd83365ff = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1_b889f809958148c58ded4d9cd83365ff",
					SchemaElementUId = new Guid("b889f809-9581-48c5-8ded-4d9cd83365ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow1_dad73b0eb21e415ebdf2746f156e3470;
		public ProcessConditionalFlow ConditionalSequenceFlow1_dad73b0eb21e415ebdf2746f156e3470 {
			get {
				return _conditionalSequenceFlow1_dad73b0eb21e415ebdf2746f156e3470 ?? (_conditionalSequenceFlow1_dad73b0eb21e415ebdf2746f156e3470 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1_dad73b0eb21e415ebdf2746f156e3470",
					SchemaElementUId = new Guid("dad73b0e-b21e-415e-bdf2-746f156e3470"),
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
			FlowElements[StartMessage3_84598c9f1e0a4b1586f92ff3674c2085.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_84598c9f1e0a4b1586f92ff3674c2085 };
			FlowElements[DocumentDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DocumentDeletingScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage4_187ffbd8f9f44e518e4e58ea7d034cf1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_187ffbd8f9f44e518e4e58ea7d034cf1 };
			FlowElements[DocumentInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DocumentInsertedScriptTask };
			FlowElements[EventSubProcessDocumentSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessDocumentSaving };
			FlowElements[StartMessage5_930f40308b0b430293a1732af3f69628.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5_930f40308b0b430293a1732af3f69628 };
			FlowElements[ScriptDocumentSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDocumentSaving };
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[StartMessage6_06d4e25661e543bcbe34de8d7dec4696.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage6_06d4e25661e543bcbe34de8d7dec4696 };
			FlowElements[SetGenerateParamScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetGenerateParamScript };
			FlowElements[ChangeRightsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeRightsScriptTask };
			FlowElements[FinanceRecalculationScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FinanceRecalculationScriptTask };
			FlowElements[SetGeneratedNumberScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetGeneratedNumberScript };
			FlowElements[GenerateNumberUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateNumberUserTask };
			FlowElements[ExclusiveGateway2_72c1d2ea32bf4eeab7870e2647d97e19.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2_72c1d2ea32bf4eeab7870e2647d97e19 };
			FlowElements[TerminateEvent1_b889f809958148c58ded4d9cd83365ff.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1_b889f809958148c58ded4d9cd83365ff };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage3_84598c9f1e0a4b1586f92ff3674c2085":
						e.Context.QueueTasks.Enqueue("DocumentDeletingScriptTask");
						break;
					case "DocumentDeletingScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage4_187ffbd8f9f44e518e4e58ea7d034cf1":
						e.Context.QueueTasks.Enqueue("DocumentInsertedScriptTask");
						break;
					case "DocumentInsertedScriptTask":
						break;
					case "EventSubProcessDocumentSaving":
						break;
					case "StartMessage5_930f40308b0b430293a1732af3f69628":
						e.Context.QueueTasks.Enqueue("ScriptDocumentSaving");
						break;
					case "ScriptDocumentSaving":
						break;
					case "SubProcess1":
						break;
					case "StartMessage6_06d4e25661e543bcbe34de8d7dec4696":
						e.Context.QueueTasks.Enqueue("SetGenerateParamScript");
						e.Context.QueueTasks.Enqueue("ChangeRightsScriptTask");
						e.Context.QueueTasks.Enqueue("FinanceRecalculationScriptTask");
						break;
					case "SetGenerateParamScript":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2_72c1d2ea32bf4eeab7870e2647d97e19");
						break;
					case "ChangeRightsScriptTask":
						break;
					case "FinanceRecalculationScriptTask":
						break;
					case "SetGeneratedNumberScript":
						break;
					case "GenerateNumberUserTask":
							e.Context.QueueTasks.Enqueue("SetGeneratedNumberScript");
						break;
					case "ExclusiveGateway2_72c1d2ea32bf4eeab7870e2647d97e19":
						if (ConditionalSequenceFlow1_dad73b0eb21e415ebdf2746f156e3470ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("GenerateNumberUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("TerminateEvent1_b889f809958148c58ded4d9cd83365ff");
						break;
					case "TerminateEvent1_b889f809958148c58ded4d9cd83365ff":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalSequenceFlow1_dad73b0eb21e415ebdf2746f156e3470ExpressionExecute() {
			return Convert.ToBoolean(string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>("Number")));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_84598c9f1e0a4b1586f92ff3674c2085");
			ActivatedEventElements.Add("StartMessage4_187ffbd8f9f44e518e4e58ea7d034cf1");
			ActivatedEventElements.Add("StartMessage5_930f40308b0b430293a1732af3f69628");
			ActivatedEventElements.Add("StartMessage6_06d4e25661e543bcbe34de8d7dec4696");
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
				case "StartMessage3_84598c9f1e0a4b1586f92ff3674c2085":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_84598c9f1e0a4b1586f92ff3674c2085";
					result = StartMessage3_84598c9f1e0a4b1586f92ff3674c2085.Execute(context);
					break;
				case "DocumentDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DocumentDeletingScriptTask";
					result = DocumentDeletingScriptTask.Execute(context, DocumentDeletingScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_187ffbd8f9f44e518e4e58ea7d034cf1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_187ffbd8f9f44e518e4e58ea7d034cf1";
					result = StartMessage4_187ffbd8f9f44e518e4e58ea7d034cf1.Execute(context);
					break;
				case "DocumentInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DocumentInsertedScriptTask";
					result = DocumentInsertedScriptTask.Execute(context, DocumentInsertedScriptTaskExecute);
					break;
				case "EventSubProcessDocumentSaving":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5_930f40308b0b430293a1732af3f69628":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5_930f40308b0b430293a1732af3f69628";
					result = StartMessage5_930f40308b0b430293a1732af3f69628.Execute(context);
					break;
				case "ScriptDocumentSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDocumentSaving";
					result = ScriptDocumentSaving.Execute(context, ScriptDocumentSavingExecute);
					break;
				case "SubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage6_06d4e25661e543bcbe34de8d7dec4696":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage6_06d4e25661e543bcbe34de8d7dec4696";
					result = StartMessage6_06d4e25661e543bcbe34de8d7dec4696.Execute(context);
					break;
				case "SetGenerateParamScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetGenerateParamScript";
					result = SetGenerateParamScript.Execute(context, SetGenerateParamScriptExecute);
					break;
				case "ChangeRightsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeRightsScriptTask";
					result = ChangeRightsScriptTask.Execute(context, ChangeRightsScriptTaskExecute);
					break;
				case "FinanceRecalculationScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "FinanceRecalculationScriptTask";
					result = FinanceRecalculationScriptTask.Execute(context, FinanceRecalculationScriptTaskExecute);
					break;
				case "SetGeneratedNumberScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetGeneratedNumberScript";
					result = SetGeneratedNumberScript.Execute(context, SetGeneratedNumberScriptExecute);
					break;
				case "GenerateNumberUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GenerateNumberUserTask";
					result = GenerateNumberUserTask.Execute(context);
					break;
				case "ExclusiveGateway2_72c1d2ea32bf4eeab7870e2647d97e19":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2_72c1d2ea32bf4eeab7870e2647d97e19";
					result = ExclusiveGateway2_72c1d2ea32bf4eeab7870e2647d97e19.Execute(context);
					break;
				case "TerminateEvent1_b889f809958148c58ded4d9cd83365ff":
					context.QueueTasks.Dequeue();
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool DocumentDeletingScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool DocumentInsertedScriptTaskExecute(ProcessExecutingContext context) {
			IsNew = true;
			return true;
		}

		public virtual bool ScriptDocumentSavingExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool SetGenerateParamScriptExecute(ProcessExecutingContext context) {
			GenerateNumberUserTask.EntitySchema = Entity.Schema;
			return true;
		}

		public virtual bool ChangeRightsScriptTaskExecute(ProcessExecutingContext context) {
			var ownerId = Entity.GetTypedColumnValue<Guid>("OwnerId");
			var oldOwnerId = Entity.GetTypedOldColumnValue<Guid>("OwnerId");
			if (ownerId != oldOwnerId) {
				if (ownerId != Guid.Empty && ownerId != UserConnection.CurrentUser.ContactId) {
					//AddWrightRights(ownerId);
				}
				if (oldOwnerId != Guid.Empty && oldOwnerId != UserConnection.CurrentUser.ContactId) {
					//RemoveWrightRights(oldOwnerId);
				}
			}
			return true;
		}

		public virtual bool FinanceRecalculationScriptTaskExecute(ProcessExecutingContext context) {
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

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Document_Document_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("StartMessage3_84598c9f1e0a4b1586f92ff3674c2085")) {
							context.QueueTasks.Enqueue("StartMessage3_84598c9f1e0a4b1586f92ff3674c2085");
							ProcessQueue(context);
							return;
						}
						break;
					case "Document_Document_TerrasoftInserted":
							if (ActivatedEventElements.Contains("StartMessage4_187ffbd8f9f44e518e4e58ea7d034cf1")) {
							context.QueueTasks.Enqueue("StartMessage4_187ffbd8f9f44e518e4e58ea7d034cf1");
							ProcessQueue(context);
							return;
						}
						break;
					case "Document_Document_TerrasoftSaving":
							if (ActivatedEventElements.Contains("StartMessage5_930f40308b0b430293a1732af3f69628")) {
							context.QueueTasks.Enqueue("StartMessage5_930f40308b0b430293a1732af3f69628");
							ProcessQueue(context);
							return;
						}
						break;
					case "Document_Document_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage6_06d4e25661e543bcbe34de8d7dec4696")) {
							context.QueueTasks.Enqueue("StartMessage6_06d4e25661e543bcbe34de8d7dec4696");
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

	#region Class: Document_DocumentEventsProcess

	/// <exclude/>
	public class Document_DocumentEventsProcess : Document_DocumentEventsProcess<Document_Document_Terrasoft>
	{

		public Document_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


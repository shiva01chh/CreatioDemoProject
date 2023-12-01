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

	#region Class: DocumentProductSchema

	/// <exclude/>
	public class DocumentProductSchema : Terrasoft.Configuration.DocumentProduct_CrtDocument_TerrasoftSchema
	{

		#region Constructors: Public

		public DocumentProductSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocumentProductSchema(DocumentProductSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocumentProductSchema(DocumentProductSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("7d0d1e08-61a9-49a6-90c5-7aac02e1bcbb");
			Name = "DocumentProduct";
			ParentSchemaUId = new Guid("5bab82ce-a828-4259-8ed9-5416ea3a0113");
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
			return new DocumentProduct(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocumentProduct_DocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocumentProductSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocumentProductSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7d0d1e08-61a9-49a6-90c5-7aac02e1bcbb"));
		}

		#endregion

	}

	#endregion

	#region Class: DocumentProduct

	/// <summary>
	/// Product in document.
	/// </summary>
	public class DocumentProduct : Terrasoft.Configuration.DocumentProduct_CrtDocument_Terrasoft
	{

		#region Constructors: Public

		public DocumentProduct(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocumentProduct";
		}

		public DocumentProduct(DocumentProduct source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DocumentProduct_DocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocumentProductDeleted", e);
			Deleting += (s, e) => ThrowEvent("DocumentProductDeleting", e);
			Inserted += (s, e) => ThrowEvent("DocumentProductInserted", e);
			Inserting += (s, e) => ThrowEvent("DocumentProductInserting", e);
			Saved += (s, e) => ThrowEvent("DocumentProductSaved", e);
			Saving += (s, e) => ThrowEvent("DocumentProductSaving", e);
			Validating += (s, e) => ThrowEvent("DocumentProductValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentProduct(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentProduct_DocumentEventsProcess

	/// <exclude/>
	public partial class DocumentProduct_DocumentEventsProcess<TEntity> : Terrasoft.Configuration.DocumentProduct_CrtDocumentEventsProcess<TEntity> where TEntity : DocumentProduct
	{

		public DocumentProduct_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentProduct_DocumentEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7d0d1e08-61a9-49a6-90c5-7aac02e1bcbb");
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
					SchemaElementUId = new Guid("fa93bfd5-90b4-46b5-8597-7df17b6ea464"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_8e6618f31e07452b940e757dcfb7e8c9;
		public ProcessFlowElement StartMessage3_8e6618f31e07452b940e757dcfb7e8c9 {
			get {
				return _startMessage3_8e6618f31e07452b940e757dcfb7e8c9 ?? (_startMessage3_8e6618f31e07452b940e757dcfb7e8c9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_8e6618f31e07452b940e757dcfb7e8c9",
					SchemaElementUId = new Guid("8e6618f3-1e07-452b-940e-757dcfb7e8c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _documentProductSavingScriptTask;
		public ProcessScriptTask DocumentProductSavingScriptTask {
			get {
				return _documentProductSavingScriptTask ?? (_documentProductSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DocumentProductSavingScriptTask",
					SchemaElementUId = new Guid("4b13830e-0c7e-45c5-99cb-3f32b3b3e787"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DocumentProductSavingScriptTaskExecute,
				});
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
					SchemaElementUId = new Guid("6daa4893-3a1b-4499-86bb-92c35d94f88d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_d16892bded4149319a2b9d9951d718d3;
		public ProcessFlowElement StartMessage4_d16892bded4149319a2b9d9951d718d3 {
			get {
				return _startMessage4_d16892bded4149319a2b9d9951d718d3 ?? (_startMessage4_d16892bded4149319a2b9d9951d718d3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_d16892bded4149319a2b9d9951d718d3",
					SchemaElementUId = new Guid("d16892bd-ed41-4931-9a2b-9d9951d718d3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAmountChange2;
		public ProcessScriptTask ScriptAmountChange2 {
			get {
				return _scriptAmountChange2 ?? (_scriptAmountChange2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAmountChange2",
					SchemaElementUId = new Guid("a655e0c2-6ab1-4ca1-a191-07d62185b787"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAmountChange2Execute,
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
					SchemaElementUId = new Guid("953b51e7-1b54-4e35-8cc2-201a562615e4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5_762a806db52b4871892420dc85953304;
		public ProcessFlowElement StartMessage5_762a806db52b4871892420dc85953304 {
			get {
				return _startMessage5_762a806db52b4871892420dc85953304 ?? (_startMessage5_762a806db52b4871892420dc85953304 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5_762a806db52b4871892420dc85953304",
					SchemaElementUId = new Guid("762a806d-b52b-4871-8924-20dc85953304"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAmountChange;
		public ProcessScriptTask ScriptAmountChange {
			get {
				return _scriptAmountChange ?? (_scriptAmountChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAmountChange",
					SchemaElementUId = new Guid("a2351257-33be-4995-879d-8adec7bc10a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAmountChangeExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage3_8e6618f31e07452b940e757dcfb7e8c9.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_8e6618f31e07452b940e757dcfb7e8c9 };
			FlowElements[DocumentProductSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DocumentProductSavingScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[StartMessage4_d16892bded4149319a2b9d9951d718d3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_d16892bded4149319a2b9d9951d718d3 };
			FlowElements[ScriptAmountChange2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAmountChange2 };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage5_762a806db52b4871892420dc85953304.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5_762a806db52b4871892420dc85953304 };
			FlowElements[ScriptAmountChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAmountChange };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2":
						break;
					case "StartMessage3_8e6618f31e07452b940e757dcfb7e8c9":
						e.Context.QueueTasks.Enqueue("DocumentProductSavingScriptTask");
						break;
					case "DocumentProductSavingScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "StartMessage4_d16892bded4149319a2b9d9951d718d3":
						e.Context.QueueTasks.Enqueue("ScriptAmountChange2");
						break;
					case "ScriptAmountChange2":
						break;
					case "EventSubProcess1":
						break;
					case "StartMessage5_762a806db52b4871892420dc85953304":
						e.Context.QueueTasks.Enqueue("ScriptAmountChange");
						break;
					case "ScriptAmountChange":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_8e6618f31e07452b940e757dcfb7e8c9");
			ActivatedEventElements.Add("StartMessage4_d16892bded4149319a2b9d9951d718d3");
			ActivatedEventElements.Add("StartMessage5_762a806db52b4871892420dc85953304");
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
				case "StartMessage3_8e6618f31e07452b940e757dcfb7e8c9":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_8e6618f31e07452b940e757dcfb7e8c9";
					result = StartMessage3_8e6618f31e07452b940e757dcfb7e8c9.Execute(context);
					break;
				case "DocumentProductSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DocumentProductSavingScriptTask";
					result = DocumentProductSavingScriptTask.Execute(context, DocumentProductSavingScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_d16892bded4149319a2b9d9951d718d3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_d16892bded4149319a2b9d9951d718d3";
					result = StartMessage4_d16892bded4149319a2b9d9951d718d3.Execute(context);
					break;
				case "ScriptAmountChange2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAmountChange2";
					result = ScriptAmountChange2.Execute(context, ScriptAmountChange2Execute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5_762a806db52b4871892420dc85953304":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5_762a806db52b4871892420dc85953304";
					result = StartMessage5_762a806db52b4871892420dc85953304.Execute(context);
					break;
				case "ScriptAmountChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAmountChange";
					result = ScriptAmountChange.Execute(context, ScriptAmountChangeExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool DocumentProductSavingScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptAmountChange2Execute(ProcessExecutingContext context) {
			UpdateTotalAmmount(context);
			return true;
		}

		public virtual bool ScriptAmountChangeExecute(ProcessExecutingContext context) {
			UpdateTotalAmmount(context);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DocumentProductSaving":
							if (ActivatedEventElements.Contains("StartMessage3_8e6618f31e07452b940e757dcfb7e8c9")) {
							context.QueueTasks.Enqueue("StartMessage3_8e6618f31e07452b940e757dcfb7e8c9");
							ProcessQueue(context);
							return;
						}
						break;
					case "DocumentProductSaved":
							if (ActivatedEventElements.Contains("StartMessage4_d16892bded4149319a2b9d9951d718d3")) {
							context.QueueTasks.Enqueue("StartMessage4_d16892bded4149319a2b9d9951d718d3");
							ProcessQueue(context);
							return;
						}
						break;
					case "DocumentProductDeleted":
							if (ActivatedEventElements.Contains("StartMessage5_762a806db52b4871892420dc85953304")) {
							context.QueueTasks.Enqueue("StartMessage5_762a806db52b4871892420dc85953304");
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

	#region Class: DocumentProduct_DocumentEventsProcess

	/// <exclude/>
	public class DocumentProduct_DocumentEventsProcess : DocumentProduct_DocumentEventsProcess<DocumentProduct>
	{

		public DocumentProduct_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: DocumentProductEventsProcess

	/// <exclude/>
	public class DocumentProductEventsProcess : DocumentProduct_DocumentEventsProcess
	{

		public DocumentProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


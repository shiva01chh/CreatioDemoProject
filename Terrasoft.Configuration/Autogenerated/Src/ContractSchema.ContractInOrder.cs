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

	#region Class: ContractSchema

	/// <exclude/>
	public class ContractSchema : Terrasoft.Configuration.Contract_CrtOrderContractMgmtApp_TerrasoftSchema
	{

		#region Constructors: Public

		public ContractSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContractSchema(ContractSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContractSchema(ContractSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("027b9465-f3cc-4b30-a7a9-0b715d04d815");
			Name = "Contract";
			ParentSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810");
			ExtendParent = true;
			CreatedInPackageId = new Guid("143ed6c8-334b-4846-a5dc-2c0b65e53c84");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
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
			return new Contract(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contract_ContractInOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContractSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContractSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("027b9465-f3cc-4b30-a7a9-0b715d04d815"));
		}

		#endregion

	}

	#endregion

	#region Class: Contract

	/// <summary>
	/// Contract.
	/// </summary>
	public class Contract : Terrasoft.Configuration.Contract_CrtOrderContractMgmtApp_Terrasoft
	{

		#region Constructors: Public

		public Contract(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contract";
		}

		public Contract(Contract source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contract_ContractInOrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContractDeleted", e);
			Deleting += (s, e) => ThrowEvent("ContractDeleting", e);
			Saved += (s, e) => ThrowEvent("ContractSaved", e);
			Saving += (s, e) => ThrowEvent("ContractSaving", e);
			Validating += (s, e) => ThrowEvent("ContractValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contract(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contract_ContractInOrderEventsProcess

	/// <exclude/>
	public partial class Contract_ContractInOrderEventsProcess<TEntity> : Terrasoft.Configuration.Contract_CrtOrderContractMgmtAppEventsProcess<TEntity> where TEntity : Contract
	{

		public Contract_ContractInOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contract_ContractInOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("027b9465-f3cc-4b30-a7a9-0b715d04d815");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcessContractSaving;
		public ProcessFlowElement EventSubProcessContractSaving {
			get {
				return _eventSubProcessContractSaving ?? (_eventSubProcessContractSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessContractSaving",
					SchemaElementUId = new Guid("573fcd7c-d70f-4658-9410-03e0f1a198a7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_6c0128e828b04c7faaed2b0f48f74b31;
		public ProcessFlowElement StartMessage3_6c0128e828b04c7faaed2b0f48f74b31 {
			get {
				return _startMessage3_6c0128e828b04c7faaed2b0f48f74b31 ?? (_startMessage3_6c0128e828b04c7faaed2b0f48f74b31 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_6c0128e828b04c7faaed2b0f48f74b31",
					SchemaElementUId = new Guid("6c0128e8-28b0-4c7f-aaed-2b0f48f74b31"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContractSaving;
		public ProcessScriptTask ScriptContractSaving {
			get {
				return _scriptContractSaving ?? (_scriptContractSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContractSaving",
					SchemaElementUId = new Guid("756abe60-8e2a-49e1-b90e-96a9309a9371"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContractSavingExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessContractSaving2;
		public ProcessFlowElement EventSubProcessContractSaving2 {
			get {
				return _eventSubProcessContractSaving2 ?? (_eventSubProcessContractSaving2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessContractSaving2",
					SchemaElementUId = new Guid("e23652ed-ccc6-4eb3-a3a3-9e9bf3c58b10"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_a3a48f7a8d6d453ab854bd453247c2d9;
		public ProcessFlowElement StartMessage4_a3a48f7a8d6d453ab854bd453247c2d9 {
			get {
				return _startMessage4_a3a48f7a8d6d453ab854bd453247c2d9 ?? (_startMessage4_a3a48f7a8d6d453ab854bd453247c2d9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_a3a48f7a8d6d453ab854bd453247c2d9",
					SchemaElementUId = new Guid("a3a48f7a-8d6d-453a-b854-bd453247c2d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContractSaved;
		public ProcessScriptTask ScriptContractSaved {
			get {
				return _scriptContractSaved ?? (_scriptContractSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContractSaved",
					SchemaElementUId = new Guid("7b14522b-0b8f-4d8b-8686-9065189c32b5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContractSavedExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessContractSaving3;
		public ProcessFlowElement EventSubProcessContractSaving3 {
			get {
				return _eventSubProcessContractSaving3 ?? (_eventSubProcessContractSaving3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessContractSaving3",
					SchemaElementUId = new Guid("810492ee-72c2-449d-a3ad-24c72765cfe5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5_50460d819d46462286d944e8e6a646ca;
		public ProcessFlowElement StartMessage5_50460d819d46462286d944e8e6a646ca {
			get {
				return _startMessage5_50460d819d46462286d944e8e6a646ca ?? (_startMessage5_50460d819d46462286d944e8e6a646ca = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5_50460d819d46462286d944e8e6a646ca",
					SchemaElementUId = new Guid("50460d81-9d46-4622-86d9-44e8e6a646ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask5_818d7a8b611c4912b3fa63c9a57f6e01;
		public ProcessScriptTask ScriptTask5_818d7a8b611c4912b3fa63c9a57f6e01 {
			get {
				return _scriptTask5_818d7a8b611c4912b3fa63c9a57f6e01 ?? (_scriptTask5_818d7a8b611c4912b3fa63c9a57f6e01 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5_818d7a8b611c4912b3fa63c9a57f6e01",
					SchemaElementUId = new Guid("818d7a8b-611c-4912-b3fa-63c9a57f6e01"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5_818d7a8b611c4912b3fa63c9a57f6e01Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessContractSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessContractSaving };
			FlowElements[StartMessage3_6c0128e828b04c7faaed2b0f48f74b31.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_6c0128e828b04c7faaed2b0f48f74b31 };
			FlowElements[ScriptContractSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContractSaving };
			FlowElements[EventSubProcessContractSaving2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessContractSaving2 };
			FlowElements[StartMessage4_a3a48f7a8d6d453ab854bd453247c2d9.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_a3a48f7a8d6d453ab854bd453247c2d9 };
			FlowElements[ScriptContractSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContractSaved };
			FlowElements[EventSubProcessContractSaving3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessContractSaving3 };
			FlowElements[StartMessage5_50460d819d46462286d944e8e6a646ca.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5_50460d819d46462286d944e8e6a646ca };
			FlowElements[ScriptTask5_818d7a8b611c4912b3fa63c9a57f6e01.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5_818d7a8b611c4912b3fa63c9a57f6e01 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessContractSaving":
						break;
					case "StartMessage3_6c0128e828b04c7faaed2b0f48f74b31":
						e.Context.QueueTasks.Enqueue("ScriptContractSaving");
						break;
					case "ScriptContractSaving":
						break;
					case "EventSubProcessContractSaving2":
						break;
					case "StartMessage4_a3a48f7a8d6d453ab854bd453247c2d9":
						e.Context.QueueTasks.Enqueue("ScriptContractSaved");
						break;
					case "ScriptContractSaved":
						break;
					case "EventSubProcessContractSaving3":
						break;
					case "StartMessage5_50460d819d46462286d944e8e6a646ca":
						e.Context.QueueTasks.Enqueue("ScriptTask5_818d7a8b611c4912b3fa63c9a57f6e01");
						break;
					case "ScriptTask5_818d7a8b611c4912b3fa63c9a57f6e01":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_6c0128e828b04c7faaed2b0f48f74b31");
			ActivatedEventElements.Add("StartMessage4_a3a48f7a8d6d453ab854bd453247c2d9");
			ActivatedEventElements.Add("StartMessage5_50460d819d46462286d944e8e6a646ca");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessContractSaving":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_6c0128e828b04c7faaed2b0f48f74b31":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_6c0128e828b04c7faaed2b0f48f74b31";
					result = StartMessage3_6c0128e828b04c7faaed2b0f48f74b31.Execute(context);
					break;
				case "ScriptContractSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContractSaving";
					result = ScriptContractSaving.Execute(context, ScriptContractSavingExecute);
					break;
				case "EventSubProcessContractSaving2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_a3a48f7a8d6d453ab854bd453247c2d9":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_a3a48f7a8d6d453ab854bd453247c2d9";
					result = StartMessage4_a3a48f7a8d6d453ab854bd453247c2d9.Execute(context);
					break;
				case "ScriptContractSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContractSaved";
					result = ScriptContractSaved.Execute(context, ScriptContractSavedExecute);
					break;
				case "EventSubProcessContractSaving3":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5_50460d819d46462286d944e8e6a646ca":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5_50460d819d46462286d944e8e6a646ca";
					result = StartMessage5_50460d819d46462286d944e8e6a646ca.Execute(context);
					break;
				case "ScriptTask5_818d7a8b611c4912b3fa63c9a57f6e01":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5_818d7a8b611c4912b3fa63c9a57f6e01";
					result = ScriptTask5_818d7a8b611c4912b3fa63c9a57f6e01.Execute(context, ScriptTask5_818d7a8b611c4912b3fa63c9a57f6e01Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptContractSavingExecute(ProcessExecutingContext context) {
			oldOrderId = Entity.GetTypedOldColumnValue<Guid>("OrderId");
			return true;
		}

		public virtual bool ScriptContractSavedExecute(ProcessExecutingContext context) {
			var OrderId = Entity.GetTypedColumnValue<Guid>("OrderId");
			var doUpdate = false;
			if (OrderId == null || OrderId.Equals(Guid.Empty)) {
				doUpdate = true;
			} else {
				if (OrderId != oldOrderId) {
					doUpdate = true;
				}
			}
			if (doUpdate) {
				var update = new Update(UserConnection, "OrderProduct")
								.Set("ContractId", Column.Const(null))
								.Where("OrderId").IsEqual(Column.Parameter(oldOrderId));
								update.Execute();	
			}
			return true;
		}

		public virtual bool ScriptTask5_818d7a8b611c4912b3fa63c9a57f6e01Execute(ProcessExecutingContext context) {
			var OrderId = Entity.GetTypedColumnValue<Guid>("OrderId");
			var update = new Update(UserConnection, "OrderProduct")
							.Set("ContractId", Column.Const(null))
							.Where("OrderId").IsEqual(Column.Parameter(OrderId))
							.And("ContractId").IsEqual(Column.Parameter(Entity.Id));
							update.Execute();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ContractSaving":
							if (ActivatedEventElements.Contains("StartMessage3_6c0128e828b04c7faaed2b0f48f74b31")) {
							context.QueueTasks.Enqueue("StartMessage3_6c0128e828b04c7faaed2b0f48f74b31");
							ProcessQueue(context);
							return;
						}
						break;
					case "ContractSaved":
							if (ActivatedEventElements.Contains("StartMessage4_a3a48f7a8d6d453ab854bd453247c2d9")) {
							context.QueueTasks.Enqueue("StartMessage4_a3a48f7a8d6d453ab854bd453247c2d9");
							ProcessQueue(context);
							return;
						}
						break;
					case "ContractDeleting":
							if (ActivatedEventElements.Contains("StartMessage5_50460d819d46462286d944e8e6a646ca")) {
							context.QueueTasks.Enqueue("StartMessage5_50460d819d46462286d944e8e6a646ca");
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

	#region Class: Contract_ContractInOrderEventsProcess

	/// <exclude/>
	public class Contract_ContractInOrderEventsProcess : Contract_ContractInOrderEventsProcess<Contract>
	{

		public Contract_ContractInOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contract_ContractInOrderEventsProcess

	public partial class Contract_ContractInOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ContractEventsProcess

	/// <exclude/>
	public class ContractEventsProcess : Contract_ContractInOrderEventsProcess
	{

		public ContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


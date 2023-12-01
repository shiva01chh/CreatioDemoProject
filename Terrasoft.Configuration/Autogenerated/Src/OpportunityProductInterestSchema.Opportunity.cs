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

	#region Class: OpportunityProductInterest_Opportunity_TerrasoftSchema

	/// <exclude/>
	public class OpportunityProductInterest_Opportunity_TerrasoftSchema : Terrasoft.Configuration.OpportunityProductInterest_CrtOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityProductInterest_Opportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityProductInterest_Opportunity_TerrasoftSchema(OpportunityProductInterest_Opportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityProductInterest_Opportunity_TerrasoftSchema(OpportunityProductInterest_Opportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("5019e1b7-d306-40fa-9b7c-def48844fad0");
			Name = "OpportunityProductInterest_Opportunity_Terrasoft";
			ParentSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860");
			ExtendParent = true;
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
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
			return new OpportunityProductInterest_Opportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityProductInterest_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityProductInterest_Opportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityProductInterest_Opportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5019e1b7-d306-40fa-9b7c-def48844fad0"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProductInterest_Opportunity_Terrasoft

	/// <summary>
	/// Opportunity product.
	/// </summary>
	public class OpportunityProductInterest_Opportunity_Terrasoft : Terrasoft.Configuration.OpportunityProductInterest_CrtOpportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityProductInterest_Opportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityProductInterest_Opportunity_Terrasoft";
		}

		public OpportunityProductInterest_Opportunity_Terrasoft(OpportunityProductInterest_Opportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityProductInterest_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityProductInterest_Opportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityProductInterest_Opportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProductInterest_OpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityProductInterest_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityProductInterest_CrtOpportunityEventsProcess<TEntity> where TEntity : OpportunityProductInterest_Opportunity_Terrasoft
	{

		public OpportunityProductInterest_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityProductInterest_OpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5019e1b7-d306-40fa-9b7c-def48844fad0");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess4_a1b5e69f6de84accb7b361afe8f9de4a;
		public ProcessFlowElement EventSubProcess4_a1b5e69f6de84accb7b361afe8f9de4a {
			get {
				return _eventSubProcess4_a1b5e69f6de84accb7b361afe8f9de4a ?? (_eventSubProcess4_a1b5e69f6de84accb7b361afe8f9de4a = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_a1b5e69f6de84accb7b361afe8f9de4a",
					SchemaElementUId = new Guid("a1b5e69f-6de8-4acc-b7b3-61afe8f9de4a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_be2a7659436e466593cca4eccfc1ab96;
		public ProcessFlowElement StartMessage3_be2a7659436e466593cca4eccfc1ab96 {
			get {
				return _startMessage3_be2a7659436e466593cca4eccfc1ab96 ?? (_startMessage3_be2a7659436e466593cca4eccfc1ab96 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_be2a7659436e466593cca4eccfc1ab96",
					SchemaElementUId = new Guid("be2a7659-436e-4665-93cc-a4eccfc1ab96"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_5e9e4e5c64e44467927f474b8028a368;
		public ProcessScriptTask ScriptTask3_5e9e4e5c64e44467927f474b8028a368 {
			get {
				return _scriptTask3_5e9e4e5c64e44467927f474b8028a368 ?? (_scriptTask3_5e9e4e5c64e44467927f474b8028a368 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_5e9e4e5c64e44467927f474b8028a368",
					SchemaElementUId = new Guid("5e9e4e5c-64e4-4467-927f-474b8028a368"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_5e9e4e5c64e44467927f474b8028a368Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessage1_9b1dbefe30974f2cac2a082c96f52a9f;
		public ProcessThrowMessageEvent IntermediateThrowMessage1_9b1dbefe30974f2cac2a082c96f52a9f {
			get {
				return _intermediateThrowMessage1_9b1dbefe30974f2cac2a082c96f52a9f ?? (_intermediateThrowMessage1_9b1dbefe30974f2cac2a082c96f52a9f = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessage1_9b1dbefe30974f2cac2a082c96f52a9f",
					SchemaElementUId = new Guid("9b1dbefe-3097-4f2c-ac2a-082c96f52a9f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OpportunityProductInterestSaved",
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5_46e49063474d4ade8e1a6e0fcd01ca57;
		public ProcessFlowElement EventSubProcess5_46e49063474d4ade8e1a6e0fcd01ca57 {
			get {
				return _eventSubProcess5_46e49063474d4ade8e1a6e0fcd01ca57 ?? (_eventSubProcess5_46e49063474d4ade8e1a6e0fcd01ca57 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5_46e49063474d4ade8e1a6e0fcd01ca57",
					SchemaElementUId = new Guid("46e49063-474d-4ade-8e1a-6e0fcd01ca57"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_b21d7e9547ee454093d6ddfc8e3ed88e;
		public ProcessFlowElement StartMessage4_b21d7e9547ee454093d6ddfc8e3ed88e {
			get {
				return _startMessage4_b21d7e9547ee454093d6ddfc8e3ed88e ?? (_startMessage4_b21d7e9547ee454093d6ddfc8e3ed88e = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_b21d7e9547ee454093d6ddfc8e3ed88e",
					SchemaElementUId = new Guid("b21d7e95-47ee-4540-93d6-ddfc8e3ed88e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8;
		public ProcessScriptTask ScriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8 {
			get {
				return _scriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8 ?? (_scriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8",
					SchemaElementUId = new Guid("222146a9-0b9b-4094-b9cb-d3a9b3c6fbd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessage2_f8196d7254b04eca8fa00d41ff253920;
		public ProcessThrowMessageEvent IntermediateThrowMessage2_f8196d7254b04eca8fa00d41ff253920 {
			get {
				return _intermediateThrowMessage2_f8196d7254b04eca8fa00d41ff253920 ?? (_intermediateThrowMessage2_f8196d7254b04eca8fa00d41ff253920 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessage2_f8196d7254b04eca8fa00d41ff253920",
					SchemaElementUId = new Guid("f8196d72-54b0-4eca-8fa0-0d41ff253920"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OpportunityProductInterestDeleting",
				});
			}
		}

		private ProcessFlowElement _eventSubProcess6_aef8af6e790945b5bdbe74d028108c01;
		public ProcessFlowElement EventSubProcess6_aef8af6e790945b5bdbe74d028108c01 {
			get {
				return _eventSubProcess6_aef8af6e790945b5bdbe74d028108c01 ?? (_eventSubProcess6_aef8af6e790945b5bdbe74d028108c01 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6_aef8af6e790945b5bdbe74d028108c01",
					SchemaElementUId = new Guid("aef8af6e-7909-45b5-bdbe-74d028108c01"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5_9520fe61419046a59e311ce5ec58ba4d;
		public ProcessFlowElement StartMessage5_9520fe61419046a59e311ce5ec58ba4d {
			get {
				return _startMessage5_9520fe61419046a59e311ce5ec58ba4d ?? (_startMessage5_9520fe61419046a59e311ce5ec58ba4d = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5_9520fe61419046a59e311ce5ec58ba4d",
					SchemaElementUId = new Guid("9520fe61-4190-46a5-9e31-1ce5ec58ba4d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask5_1cb4726c0a7d4a259da27e5c1abf03bd;
		public ProcessScriptTask ScriptTask5_1cb4726c0a7d4a259da27e5c1abf03bd {
			get {
				return _scriptTask5_1cb4726c0a7d4a259da27e5c1abf03bd ?? (_scriptTask5_1cb4726c0a7d4a259da27e5c1abf03bd = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5_1cb4726c0a7d4a259da27e5c1abf03bd",
					SchemaElementUId = new Guid("1cb4726c-0a7d-4a25-9da2-7e5c1abf03bd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5_1cb4726c0a7d4a259da27e5c1abf03bdExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessage3_7c60a4f6546e4beda1741abc25e22448;
		public ProcessThrowMessageEvent IntermediateThrowMessage3_7c60a4f6546e4beda1741abc25e22448 {
			get {
				return _intermediateThrowMessage3_7c60a4f6546e4beda1741abc25e22448 ?? (_intermediateThrowMessage3_7c60a4f6546e4beda1741abc25e22448 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessage3_7c60a4f6546e4beda1741abc25e22448",
					SchemaElementUId = new Guid("7c60a4f6-546e-4bed-a174-1abc25e22448"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OpportunityProductInterestDeleted",
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess4_a1b5e69f6de84accb7b361afe8f9de4a.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_a1b5e69f6de84accb7b361afe8f9de4a };
			FlowElements[StartMessage3_be2a7659436e466593cca4eccfc1ab96.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_be2a7659436e466593cca4eccfc1ab96 };
			FlowElements[ScriptTask3_5e9e4e5c64e44467927f474b8028a368.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_5e9e4e5c64e44467927f474b8028a368 };
			FlowElements[IntermediateThrowMessage1_9b1dbefe30974f2cac2a082c96f52a9f.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessage1_9b1dbefe30974f2cac2a082c96f52a9f };
			FlowElements[EventSubProcess5_46e49063474d4ade8e1a6e0fcd01ca57.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5_46e49063474d4ade8e1a6e0fcd01ca57 };
			FlowElements[StartMessage4_b21d7e9547ee454093d6ddfc8e3ed88e.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_b21d7e9547ee454093d6ddfc8e3ed88e };
			FlowElements[ScriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8 };
			FlowElements[IntermediateThrowMessage2_f8196d7254b04eca8fa00d41ff253920.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessage2_f8196d7254b04eca8fa00d41ff253920 };
			FlowElements[EventSubProcess6_aef8af6e790945b5bdbe74d028108c01.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6_aef8af6e790945b5bdbe74d028108c01 };
			FlowElements[StartMessage5_9520fe61419046a59e311ce5ec58ba4d.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5_9520fe61419046a59e311ce5ec58ba4d };
			FlowElements[ScriptTask5_1cb4726c0a7d4a259da27e5c1abf03bd.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5_1cb4726c0a7d4a259da27e5c1abf03bd };
			FlowElements[IntermediateThrowMessage3_7c60a4f6546e4beda1741abc25e22448.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessage3_7c60a4f6546e4beda1741abc25e22448 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess4_a1b5e69f6de84accb7b361afe8f9de4a":
						break;
					case "StartMessage3_be2a7659436e466593cca4eccfc1ab96":
						e.Context.QueueTasks.Enqueue("ScriptTask3_5e9e4e5c64e44467927f474b8028a368");
						break;
					case "ScriptTask3_5e9e4e5c64e44467927f474b8028a368":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessage1_9b1dbefe30974f2cac2a082c96f52a9f");
						break;
					case "IntermediateThrowMessage1_9b1dbefe30974f2cac2a082c96f52a9f":
						break;
					case "EventSubProcess5_46e49063474d4ade8e1a6e0fcd01ca57":
						break;
					case "StartMessage4_b21d7e9547ee454093d6ddfc8e3ed88e":
						e.Context.QueueTasks.Enqueue("ScriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8");
						break;
					case "ScriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessage2_f8196d7254b04eca8fa00d41ff253920");
						break;
					case "IntermediateThrowMessage2_f8196d7254b04eca8fa00d41ff253920":
						break;
					case "EventSubProcess6_aef8af6e790945b5bdbe74d028108c01":
						break;
					case "StartMessage5_9520fe61419046a59e311ce5ec58ba4d":
						e.Context.QueueTasks.Enqueue("ScriptTask5_1cb4726c0a7d4a259da27e5c1abf03bd");
						break;
					case "ScriptTask5_1cb4726c0a7d4a259da27e5c1abf03bd":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessage3_7c60a4f6546e4beda1741abc25e22448");
						break;
					case "IntermediateThrowMessage3_7c60a4f6546e4beda1741abc25e22448":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_be2a7659436e466593cca4eccfc1ab96");
			ActivatedEventElements.Add("StartMessage4_b21d7e9547ee454093d6ddfc8e3ed88e");
			ActivatedEventElements.Add("StartMessage5_9520fe61419046a59e311ce5ec58ba4d");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess4_a1b5e69f6de84accb7b361afe8f9de4a":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_be2a7659436e466593cca4eccfc1ab96":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_be2a7659436e466593cca4eccfc1ab96";
					result = StartMessage3_be2a7659436e466593cca4eccfc1ab96.Execute(context);
					break;
				case "ScriptTask3_5e9e4e5c64e44467927f474b8028a368":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_5e9e4e5c64e44467927f474b8028a368";
					result = ScriptTask3_5e9e4e5c64e44467927f474b8028a368.Execute(context, ScriptTask3_5e9e4e5c64e44467927f474b8028a368Execute);
					break;
				case "IntermediateThrowMessage1_9b1dbefe30974f2cac2a082c96f52a9f":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessage1_9b1dbefe30974f2cac2a082c96f52a9f.Execute(context);
					break;
				case "EventSubProcess5_46e49063474d4ade8e1a6e0fcd01ca57":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_b21d7e9547ee454093d6ddfc8e3ed88e":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_b21d7e9547ee454093d6ddfc8e3ed88e";
					result = StartMessage4_b21d7e9547ee454093d6ddfc8e3ed88e.Execute(context);
					break;
				case "ScriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8";
					result = ScriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8.Execute(context, ScriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8Execute);
					break;
				case "IntermediateThrowMessage2_f8196d7254b04eca8fa00d41ff253920":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessage2_f8196d7254b04eca8fa00d41ff253920.Execute(context);
					break;
				case "EventSubProcess6_aef8af6e790945b5bdbe74d028108c01":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5_9520fe61419046a59e311ce5ec58ba4d":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5_9520fe61419046a59e311ce5ec58ba4d";
					result = StartMessage5_9520fe61419046a59e311ce5ec58ba4d.Execute(context);
					break;
				case "ScriptTask5_1cb4726c0a7d4a259da27e5c1abf03bd":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5_1cb4726c0a7d4a259da27e5c1abf03bd";
					result = ScriptTask5_1cb4726c0a7d4a259da27e5c1abf03bd.Execute(context, ScriptTask5_1cb4726c0a7d4a259da27e5c1abf03bdExecute);
					break;
				case "IntermediateThrowMessage3_7c60a4f6546e4beda1741abc25e22448":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessage3_7c60a4f6546e4beda1741abc25e22448.Execute(context);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_5e9e4e5c64e44467927f474b8028a368Execute(ProcessExecutingContext context) {
			var opportunityId = Entity.GetTypedColumnValue<Guid>("OpportunityId");
			CalckOpportunityAmount(opportunityId);
			return true;
		}

		public virtual bool ScriptTask4_222146a90b9b4094b9cbd3a9b3c6fbd8Execute(ProcessExecutingContext context) {
			OpportunityId = Entity.GetTypedColumnValue<Guid>("OpportunityId");
			return true;
		}

		public virtual bool ScriptTask5_1cb4726c0a7d4a259da27e5c1abf03bdExecute(ProcessExecutingContext context) {
			CalckOpportunityAmount(OpportunityId);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OpportunityProductInterest_Opportunity_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage3_be2a7659436e466593cca4eccfc1ab96")) {
							context.QueueTasks.Enqueue("StartMessage3_be2a7659436e466593cca4eccfc1ab96");
							ProcessQueue(context);
							return;
						}
						break;
					case "OpportunityProductInterest_Opportunity_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("StartMessage4_b21d7e9547ee454093d6ddfc8e3ed88e")) {
							context.QueueTasks.Enqueue("StartMessage4_b21d7e9547ee454093d6ddfc8e3ed88e");
							ProcessQueue(context);
							return;
						}
						break;
					case "OpportunityProductInterest_Opportunity_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("StartMessage5_9520fe61419046a59e311ce5ec58ba4d")) {
							context.QueueTasks.Enqueue("StartMessage5_9520fe61419046a59e311ce5ec58ba4d");
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

	#region Class: OpportunityProductInterest_OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityProductInterest_OpportunityEventsProcess : OpportunityProductInterest_OpportunityEventsProcess<OpportunityProductInterest_Opportunity_Terrasoft>
	{

		public OpportunityProductInterest_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


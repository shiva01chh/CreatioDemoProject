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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: OpportunityStage_Opportunity_TerrasoftSchema

	/// <exclude/>
	public class OpportunityStage_Opportunity_TerrasoftSchema : Terrasoft.Configuration.OpportunityStage_CrtOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityStage_Opportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityStage_Opportunity_TerrasoftSchema(OpportunityStage_Opportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityStage_Opportunity_TerrasoftSchema(OpportunityStage_Opportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("ab9ee9ab-e078-42c7-b1a0-fa53e6a0f387");
			Name = "OpportunityStage_Opportunity_Terrasoft";
			ParentSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
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
			return new OpportunityStage_Opportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityStage_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityStage_Opportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityStage_Opportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ab9ee9ab-e078-42c7-b1a0-fa53e6a0f387"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityStage_Opportunity_Terrasoft

	/// <summary>
	/// Opportunity stage.
	/// </summary>
	public class OpportunityStage_Opportunity_Terrasoft : Terrasoft.Configuration.OpportunityStage_CrtOpportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityStage_Opportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityStage_Opportunity_Terrasoft";
		}

		public OpportunityStage_Opportunity_Terrasoft(OpportunityStage_Opportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityStage_OpportunityEventsProcess(UserConnection);
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
			return new OpportunityStage_Opportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityStage_OpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityStage_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityStage_CrtOpportunityEventsProcess<TEntity> where TEntity : OpportunityStage_Opportunity_Terrasoft
	{

		public OpportunityStage_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityStage_OpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ab9ee9ab-e078-42c7-b1a0-fa53e6a0f387");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_c9333824175c4ccf9cb076097d7bf723;
		public ProcessFlowElement EventSubProcess3_c9333824175c4ccf9cb076097d7bf723 {
			get {
				return _eventSubProcess3_c9333824175c4ccf9cb076097d7bf723 ?? (_eventSubProcess3_c9333824175c4ccf9cb076097d7bf723 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_c9333824175c4ccf9cb076097d7bf723",
					SchemaElementUId = new Guid("c9333824-175c-4ccf-9cb0-76097d7bf723"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_ba78fd5a1ab241ca988fef7fa2aadf49;
		public ProcessFlowElement StartMessage3_ba78fd5a1ab241ca988fef7fa2aadf49 {
			get {
				return _startMessage3_ba78fd5a1ab241ca988fef7fa2aadf49 ?? (_startMessage3_ba78fd5a1ab241ca988fef7fa2aadf49 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_ba78fd5a1ab241ca988fef7fa2aadf49",
					SchemaElementUId = new Guid("ba78fd5a-1ab2-41ca-988f-ef7fa2aadf49"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_9d6aee8b677b45e7a33647f9986a9c9b;
		public ProcessScriptTask ScriptTask3_9d6aee8b677b45e7a33647f9986a9c9b {
			get {
				return _scriptTask3_9d6aee8b677b45e7a33647f9986a9c9b ?? (_scriptTask3_9d6aee8b677b45e7a33647f9986a9c9b = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_9d6aee8b677b45e7a33647f9986a9c9b",
					SchemaElementUId = new Guid("9d6aee8b-677b-45e7-a336-47f9986a9c9b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_9d6aee8b677b45e7a33647f9986a9c9bExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4_6e5137c6e36b4278a62a8ff209dc7a0d;
		public ProcessFlowElement EventSubProcess4_6e5137c6e36b4278a62a8ff209dc7a0d {
			get {
				return _eventSubProcess4_6e5137c6e36b4278a62a8ff209dc7a0d ?? (_eventSubProcess4_6e5137c6e36b4278a62a8ff209dc7a0d = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_6e5137c6e36b4278a62a8ff209dc7a0d",
					SchemaElementUId = new Guid("6e5137c6-e36b-4278-a62a-8ff209dc7a0d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_76e24f4dab2046db839405eb91d42bcf;
		public ProcessFlowElement StartMessage4_76e24f4dab2046db839405eb91d42bcf {
			get {
				return _startMessage4_76e24f4dab2046db839405eb91d42bcf ?? (_startMessage4_76e24f4dab2046db839405eb91d42bcf = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_76e24f4dab2046db839405eb91d42bcf",
					SchemaElementUId = new Guid("76e24f4d-ab20-46db-8394-05eb91d42bcf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_96e2748f382d424e84e3fc58414e7bed;
		public ProcessScriptTask ScriptTask4_96e2748f382d424e84e3fc58414e7bed {
			get {
				return _scriptTask4_96e2748f382d424e84e3fc58414e7bed ?? (_scriptTask4_96e2748f382d424e84e3fc58414e7bed = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_96e2748f382d424e84e3fc58414e7bed",
					SchemaElementUId = new Guid("96e2748f-382d-424e-84e3-fc58414e7bed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_96e2748f382d424e84e3fc58414e7bedExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5_68e7efa9659e43cfbc0dd465039b57ac;
		public ProcessFlowElement EventSubProcess5_68e7efa9659e43cfbc0dd465039b57ac {
			get {
				return _eventSubProcess5_68e7efa9659e43cfbc0dd465039b57ac ?? (_eventSubProcess5_68e7efa9659e43cfbc0dd465039b57ac = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5_68e7efa9659e43cfbc0dd465039b57ac",
					SchemaElementUId = new Guid("68e7efa9-659e-43cf-bc0d-d465039b57ac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5_0e28649db09d4fb7a5df9c750fdbe190;
		public ProcessFlowElement StartMessage5_0e28649db09d4fb7a5df9c750fdbe190 {
			get {
				return _startMessage5_0e28649db09d4fb7a5df9c750fdbe190 ?? (_startMessage5_0e28649db09d4fb7a5df9c750fdbe190 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5_0e28649db09d4fb7a5df9c750fdbe190",
					SchemaElementUId = new Guid("0e28649d-b09d-4fb7-a5df-9c750fdbe190"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask5_a999ceb111204923bfc59eb883451030;
		public ProcessScriptTask ScriptTask5_a999ceb111204923bfc59eb883451030 {
			get {
				return _scriptTask5_a999ceb111204923bfc59eb883451030 ?? (_scriptTask5_a999ceb111204923bfc59eb883451030 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5_a999ceb111204923bfc59eb883451030",
					SchemaElementUId = new Guid("a999ceb1-1120-4923-bfc5-9eb883451030"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5_a999ceb111204923bfc59eb883451030Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_c9333824175c4ccf9cb076097d7bf723.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_c9333824175c4ccf9cb076097d7bf723 };
			FlowElements[StartMessage3_ba78fd5a1ab241ca988fef7fa2aadf49.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_ba78fd5a1ab241ca988fef7fa2aadf49 };
			FlowElements[ScriptTask3_9d6aee8b677b45e7a33647f9986a9c9b.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_9d6aee8b677b45e7a33647f9986a9c9b };
			FlowElements[EventSubProcess4_6e5137c6e36b4278a62a8ff209dc7a0d.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_6e5137c6e36b4278a62a8ff209dc7a0d };
			FlowElements[StartMessage4_76e24f4dab2046db839405eb91d42bcf.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_76e24f4dab2046db839405eb91d42bcf };
			FlowElements[ScriptTask4_96e2748f382d424e84e3fc58414e7bed.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_96e2748f382d424e84e3fc58414e7bed };
			FlowElements[EventSubProcess5_68e7efa9659e43cfbc0dd465039b57ac.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5_68e7efa9659e43cfbc0dd465039b57ac };
			FlowElements[StartMessage5_0e28649db09d4fb7a5df9c750fdbe190.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5_0e28649db09d4fb7a5df9c750fdbe190 };
			FlowElements[ScriptTask5_a999ceb111204923bfc59eb883451030.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5_a999ceb111204923bfc59eb883451030 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_c9333824175c4ccf9cb076097d7bf723":
						break;
					case "StartMessage3_ba78fd5a1ab241ca988fef7fa2aadf49":
						e.Context.QueueTasks.Enqueue("ScriptTask3_9d6aee8b677b45e7a33647f9986a9c9b");
						break;
					case "ScriptTask3_9d6aee8b677b45e7a33647f9986a9c9b":
						break;
					case "EventSubProcess4_6e5137c6e36b4278a62a8ff209dc7a0d":
						break;
					case "StartMessage4_76e24f4dab2046db839405eb91d42bcf":
						e.Context.QueueTasks.Enqueue("ScriptTask4_96e2748f382d424e84e3fc58414e7bed");
						break;
					case "ScriptTask4_96e2748f382d424e84e3fc58414e7bed":
						break;
					case "EventSubProcess5_68e7efa9659e43cfbc0dd465039b57ac":
						break;
					case "StartMessage5_0e28649db09d4fb7a5df9c750fdbe190":
						e.Context.QueueTasks.Enqueue("ScriptTask5_a999ceb111204923bfc59eb883451030");
						break;
					case "ScriptTask5_a999ceb111204923bfc59eb883451030":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_ba78fd5a1ab241ca988fef7fa2aadf49");
			ActivatedEventElements.Add("StartMessage4_76e24f4dab2046db839405eb91d42bcf");
			ActivatedEventElements.Add("StartMessage5_0e28649db09d4fb7a5df9c750fdbe190");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_c9333824175c4ccf9cb076097d7bf723":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_ba78fd5a1ab241ca988fef7fa2aadf49":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_ba78fd5a1ab241ca988fef7fa2aadf49";
					result = StartMessage3_ba78fd5a1ab241ca988fef7fa2aadf49.Execute(context);
					break;
				case "ScriptTask3_9d6aee8b677b45e7a33647f9986a9c9b":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_9d6aee8b677b45e7a33647f9986a9c9b";
					result = ScriptTask3_9d6aee8b677b45e7a33647f9986a9c9b.Execute(context, ScriptTask3_9d6aee8b677b45e7a33647f9986a9c9bExecute);
					break;
				case "EventSubProcess4_6e5137c6e36b4278a62a8ff209dc7a0d":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_76e24f4dab2046db839405eb91d42bcf":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_76e24f4dab2046db839405eb91d42bcf";
					result = StartMessage4_76e24f4dab2046db839405eb91d42bcf.Execute(context);
					break;
				case "ScriptTask4_96e2748f382d424e84e3fc58414e7bed":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_96e2748f382d424e84e3fc58414e7bed";
					result = ScriptTask4_96e2748f382d424e84e3fc58414e7bed.Execute(context, ScriptTask4_96e2748f382d424e84e3fc58414e7bedExecute);
					break;
				case "EventSubProcess5_68e7efa9659e43cfbc0dd465039b57ac":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5_0e28649db09d4fb7a5df9c750fdbe190":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5_0e28649db09d4fb7a5df9c750fdbe190";
					result = StartMessage5_0e28649db09d4fb7a5df9c750fdbe190.Execute(context);
					break;
				case "ScriptTask5_a999ceb111204923bfc59eb883451030":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5_a999ceb111204923bfc59eb883451030";
					result = ScriptTask5_a999ceb111204923bfc59eb883451030.Execute(context, ScriptTask5_a999ceb111204923bfc59eb883451030Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_9d6aee8b677b45e7a33647f9986a9c9bExecute(ProcessExecutingContext context) {
			ClearCache();
			return true;
		}

		public virtual bool ScriptTask4_96e2748f382d424e84e3fc58414e7bedExecute(ProcessExecutingContext context) {
			ClearCache();
			return true;
		}

		public virtual bool ScriptTask5_a999ceb111204923bfc59eb883451030Execute(ProcessExecutingContext context) {
			ClearCache();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OpportunityStageSaving":
							if (ActivatedEventElements.Contains("StartMessage3_ba78fd5a1ab241ca988fef7fa2aadf49")) {
							context.QueueTasks.Enqueue("StartMessage3_ba78fd5a1ab241ca988fef7fa2aadf49");
							ProcessQueue(context);
							return;
						}
						break;
					case "OpportunityStageDeleting":
							if (ActivatedEventElements.Contains("StartMessage4_76e24f4dab2046db839405eb91d42bcf")) {
							context.QueueTasks.Enqueue("StartMessage4_76e24f4dab2046db839405eb91d42bcf");
							ProcessQueue(context);
							return;
						}
						break;
					case "OpportunityStageInserting":
							if (ActivatedEventElements.Contains("StartMessage5_0e28649db09d4fb7a5df9c750fdbe190")) {
							context.QueueTasks.Enqueue("StartMessage5_0e28649db09d4fb7a5df9c750fdbe190");
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

	#region Class: OpportunityStage_OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityStage_OpportunityEventsProcess : OpportunityStage_OpportunityEventsProcess<OpportunityStage_Opportunity_Terrasoft>
	{

		public OpportunityStage_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


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

	#region Class: OpportunityContact_Opportunity_TerrasoftSchema

	/// <exclude/>
	public class OpportunityContact_Opportunity_TerrasoftSchema : Terrasoft.Configuration.OpportunityContact_CrtOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityContact_Opportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityContact_Opportunity_TerrasoftSchema(OpportunityContact_Opportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityContact_Opportunity_TerrasoftSchema(OpportunityContact_Opportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("486034bb-ad51-4783-a008-92963c269d20");
			Name = "OpportunityContact_Opportunity_Terrasoft";
			ParentSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
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
			return new OpportunityContact_Opportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityContact_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityContact_Opportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityContact_Opportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("486034bb-ad51-4783-a008-92963c269d20"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityContact_Opportunity_Terrasoft

	/// <summary>
	/// Contact in opportunity.
	/// </summary>
	public class OpportunityContact_Opportunity_Terrasoft : Terrasoft.Configuration.OpportunityContact_CrtOpportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityContact_Opportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityContact_Opportunity_Terrasoft";
		}

		public OpportunityContact_Opportunity_Terrasoft(OpportunityContact_Opportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityContact_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityContact_Opportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityContact_OpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityContact_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityContact_CrtOpportunityEventsProcess<TEntity> where TEntity : OpportunityContact_Opportunity_Terrasoft
	{

		public OpportunityContact_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityContact_OpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("486034bb-ad51-4783-a008-92963c269d20");
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
					SchemaElementUId = new Guid("4a743ef4-998d-4231-af9d-5af750ecaf08"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_55d7aaae2ea4400890ae7d6bc88233e6;
		public ProcessFlowElement StartMessage3_55d7aaae2ea4400890ae7d6bc88233e6 {
			get {
				return _startMessage3_55d7aaae2ea4400890ae7d6bc88233e6 ?? (_startMessage3_55d7aaae2ea4400890ae7d6bc88233e6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_55d7aaae2ea4400890ae7d6bc88233e6",
					SchemaElementUId = new Guid("55d7aaae-2ea4-4008-90ae-7d6bc88233e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_7bc06190588743f8babb4f6bc3aa2d5b;
		public ProcessScriptTask ScriptTask3_7bc06190588743f8babb4f6bc3aa2d5b {
			get {
				return _scriptTask3_7bc06190588743f8babb4f6bc3aa2d5b ?? (_scriptTask3_7bc06190588743f8babb4f6bc3aa2d5b = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_7bc06190588743f8babb4f6bc3aa2d5b",
					SchemaElementUId = new Guid("7bc06190-5887-43f8-babb-4f6bc3aa2d5b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_7bc06190588743f8babb4f6bc3aa2d5bExecute,
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
					SchemaElementUId = new Guid("eaa23c69-67a9-41ef-b9b1-9e41874cb75c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_4fd568b1c70e41d0b34c35695825597d;
		public ProcessFlowElement StartMessage4_4fd568b1c70e41d0b34c35695825597d {
			get {
				return _startMessage4_4fd568b1c70e41d0b34c35695825597d ?? (_startMessage4_4fd568b1c70e41d0b34c35695825597d = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_4fd568b1c70e41d0b34c35695825597d",
					SchemaElementUId = new Guid("4fd568b1-c70e-41d0-b34c-35695825597d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_c1304beb3206449c9c7101dfd0dbce03;
		public ProcessScriptTask ScriptTask4_c1304beb3206449c9c7101dfd0dbce03 {
			get {
				return _scriptTask4_c1304beb3206449c9c7101dfd0dbce03 ?? (_scriptTask4_c1304beb3206449c9c7101dfd0dbce03 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_c1304beb3206449c9c7101dfd0dbce03",
					SchemaElementUId = new Guid("c1304beb-3206-449c-9c71-01dfd0dbce03"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_c1304beb3206449c9c7101dfd0dbce03Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage3_55d7aaae2ea4400890ae7d6bc88233e6.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_55d7aaae2ea4400890ae7d6bc88233e6 };
			FlowElements[ScriptTask3_7bc06190588743f8babb4f6bc3aa2d5b.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_7bc06190588743f8babb4f6bc3aa2d5b };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage4_4fd568b1c70e41d0b34c35695825597d.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_4fd568b1c70e41d0b34c35695825597d };
			FlowElements[ScriptTask4_c1304beb3206449c9c7101dfd0dbce03.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_c1304beb3206449c9c7101dfd0dbce03 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage3_55d7aaae2ea4400890ae7d6bc88233e6":
						e.Context.QueueTasks.Enqueue("ScriptTask3_7bc06190588743f8babb4f6bc3aa2d5b");
						break;
					case "ScriptTask3_7bc06190588743f8babb4f6bc3aa2d5b":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage4_4fd568b1c70e41d0b34c35695825597d":
						e.Context.QueueTasks.Enqueue("ScriptTask4_c1304beb3206449c9c7101dfd0dbce03");
						break;
					case "ScriptTask4_c1304beb3206449c9c7101dfd0dbce03":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_55d7aaae2ea4400890ae7d6bc88233e6");
			ActivatedEventElements.Add("StartMessage4_4fd568b1c70e41d0b34c35695825597d");
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
				case "StartMessage3_55d7aaae2ea4400890ae7d6bc88233e6":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_55d7aaae2ea4400890ae7d6bc88233e6";
					result = StartMessage3_55d7aaae2ea4400890ae7d6bc88233e6.Execute(context);
					break;
				case "ScriptTask3_7bc06190588743f8babb4f6bc3aa2d5b":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_7bc06190588743f8babb4f6bc3aa2d5b";
					result = ScriptTask3_7bc06190588743f8babb4f6bc3aa2d5b.Execute(context, ScriptTask3_7bc06190588743f8babb4f6bc3aa2d5bExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_4fd568b1c70e41d0b34c35695825597d":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_4fd568b1c70e41d0b34c35695825597d";
					result = StartMessage4_4fd568b1c70e41d0b34c35695825597d.Execute(context);
					break;
				case "ScriptTask4_c1304beb3206449c9c7101dfd0dbce03":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_c1304beb3206449c9c7101dfd0dbce03";
					result = ScriptTask4_c1304beb3206449c9c7101dfd0dbce03.Execute(context, ScriptTask4_c1304beb3206449c9c7101dfd0dbce03Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_7bc06190588743f8babb4f6bc3aa2d5bExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptTask4_c1304beb3206449c9c7101dfd0dbce03Execute(ProcessExecutingContext context) {
			Guid id = Entity.GetTypedColumnValue<Guid>("OpportunityId");
			OpportunityAnniversaryReminding remindingsGenerator = new OpportunityAnniversaryReminding(UserConnection, id);
			remindingsGenerator.GenerateActualRemindings();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OpportunityContact_Opportunity_TerrasoftSaving":
							if (ActivatedEventElements.Contains("StartMessage3_55d7aaae2ea4400890ae7d6bc88233e6")) {
							context.QueueTasks.Enqueue("StartMessage3_55d7aaae2ea4400890ae7d6bc88233e6");
						}
						break;
					case "OpportunityContact_Opportunity_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage4_4fd568b1c70e41d0b34c35695825597d")) {
							context.QueueTasks.Enqueue("StartMessage4_4fd568b1c70e41d0b34c35695825597d");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityContact_OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityContact_OpportunityEventsProcess : OpportunityContact_OpportunityEventsProcess<OpportunityContact_Opportunity_Terrasoft>
	{

		public OpportunityContact_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityContact_OpportunityEventsProcess

	public partial class OpportunityContact_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}


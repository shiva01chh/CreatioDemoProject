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

	#region Class: EventTargetSchema

	/// <exclude/>
	public class EventTargetSchema : Terrasoft.Configuration.EventTarget_CrtEvent_TerrasoftSchema
	{

		#region Constructors: Public

		public EventTargetSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EventTargetSchema(EventTargetSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EventTargetSchema(EventTargetSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("ae05e40f-2580-409d-a5cd-5fcd82a5e9ae");
			Name = "EventTarget";
			ParentSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87");
			ExtendParent = true;
			CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateEventResponseColumn() {
			EntitySchemaColumn column = base.CreateEventResponseColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"c6eae023-2778-49c6-8273-6b015c1cc611"
			};
			column.ModifiedInSchemaUId = new Guid("ae05e40f-2580-409d-a5cd-5fcd82a5e9ae");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EventTarget(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EventTarget_MarketingCampaignEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EventTargetSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EventTargetSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae05e40f-2580-409d-a5cd-5fcd82a5e9ae"));
		}

		#endregion

	}

	#endregion

	#region Class: EventTarget

	/// <summary>
	/// Event participant.
	/// </summary>
	public class EventTarget : Terrasoft.Configuration.EventTarget_CrtEvent_Terrasoft
	{

		#region Constructors: Public

		public EventTarget(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EventTarget";
		}

		public EventTarget(EventTarget source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EventTarget_MarketingCampaignEventsProcess(UserConnection);
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
			return new EventTarget(this);
		}

		#endregion

	}

	#endregion

	#region Class: EventTarget_MarketingCampaignEventsProcess

	/// <exclude/>
	public partial class EventTarget_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.EventTarget_CrtEventEventsProcess<TEntity> where TEntity : EventTarget
	{

		public EventTarget_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EventTarget_MarketingCampaignEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ae05e40f-2580-409d-a5cd-5fcd82a5e9ae");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventInsertingStartMessageEventSubProcess;
		public ProcessFlowElement EventInsertingStartMessageEventSubProcess {
			get {
				return _eventInsertingStartMessageEventSubProcess ?? (_eventInsertingStartMessageEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventInsertingStartMessageEventSubProcess",
					SchemaElementUId = new Guid("6a1ce30f-bb9e-4174-a4e1-5ba2aab80db3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_a38f6956073a4b788bf8312eea25bd07;
		public ProcessFlowElement StartMessage4_a38f6956073a4b788bf8312eea25bd07 {
			get {
				return _startMessage4_a38f6956073a4b788bf8312eea25bd07 ?? (_startMessage4_a38f6956073a4b788bf8312eea25bd07 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_a38f6956073a4b788bf8312eea25bd07",
					SchemaElementUId = new Guid("a38f6956-073a-4b78-8bf8-312eea25bd07"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9;
		public ProcessScriptTask ScriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9 {
			get {
				return _scriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9 ?? (_scriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9",
					SchemaElementUId = new Guid("dfdbd87c-eebe-4533-8b54-e7b9b31e7bd9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventInsertingStartMessageEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EventInsertingStartMessageEventSubProcess };
			FlowElements[StartMessage4_a38f6956073a4b788bf8312eea25bd07.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_a38f6956073a4b788bf8312eea25bd07 };
			FlowElements[ScriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventInsertingStartMessageEventSubProcess":
						break;
					case "StartMessage4_a38f6956073a4b788bf8312eea25bd07":
						e.Context.QueueTasks.Enqueue("ScriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9");
						break;
					case "ScriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage4_a38f6956073a4b788bf8312eea25bd07");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventInsertingStartMessageEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_a38f6956073a4b788bf8312eea25bd07":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_a38f6956073a4b788bf8312eea25bd07";
					result = StartMessage4_a38f6956073a4b788bf8312eea25bd07.Execute(context);
					break;
				case "ScriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9";
					result = ScriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9.Execute(context, ScriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask4_dfdbd87ceebe45338b54e7b9b31e7bd9Execute(ProcessExecutingContext context) {
			OnInserting();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "EventTargetInserting":
							if (ActivatedEventElements.Contains("StartMessage4_a38f6956073a4b788bf8312eea25bd07")) {
							context.QueueTasks.Enqueue("StartMessage4_a38f6956073a4b788bf8312eea25bd07");
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

	#region Class: EventTarget_MarketingCampaignEventsProcess

	/// <exclude/>
	public class EventTarget_MarketingCampaignEventsProcess : EventTarget_MarketingCampaignEventsProcess<EventTarget>
	{

		public EventTarget_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: EventTargetEventsProcess

	/// <exclude/>
	public class EventTargetEventsProcess : EventTarget_MarketingCampaignEventsProcess
	{

		public EventTargetEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}


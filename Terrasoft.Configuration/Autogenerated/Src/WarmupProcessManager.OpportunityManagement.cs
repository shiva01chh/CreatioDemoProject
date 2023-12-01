﻿namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: WarmupProcessManagerSchema

	/// <exclude/>
	public class WarmupProcessManagerSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public WarmupProcessManagerSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public WarmupProcessManagerSchema(WarmupProcessManagerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "WarmupProcessManager";
			UId = new Guid("d585266b-5e89-461c-adce-c20364561547");
			CreatedInPackageId = new Guid("7f26fbbf-b17c-4eaf-8186-36d9ccf0d066");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"8.1.0.6704";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("d585266b-5e89-461c-adce-c20364561547");
			Version = 0;
			PackageUId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd");
			UseSystemSecurityContext = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaScriptTask warmupprocessmanagerscripttask = CreateWarmupProcessManagerScriptTaskScriptTask();
			FlowElements.Add(warmupprocessmanagerscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("73b2c7f7-83b1-4977-a966-8d782b81d780"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7f26fbbf-b17c-4eaf-8186-36d9ccf0d066"),
				CreatedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4c69a5cb-e631-4ab8-9dae-5b261a5f038f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a55492f-cacf-4d78-af86-144930dcad35"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("80683d2b-0cc3-4071-8849-af6ed83aa45b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7f26fbbf-b17c-4eaf-8186-36d9ccf0d066"),
				CreatedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a55492f-cacf-4d78-af86-144930dcad35"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("82616241-1c86-41b2-b9ec-7620387acc8c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("01093d6b-9339-42ee-91f3-159b32f4f7c4"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7f26fbbf-b17c-4eaf-8186-36d9ccf0d066"),
				CreatedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1058, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("ca703f59-8e26-4b20-be70-2127aa01fc78"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("01093d6b-9339-42ee-91f3-159b32f4f7c4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("7f26fbbf-b17c-4eaf-8186-36d9ccf0d066"),
				CreatedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(1029, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("4c69a5cb-e631-4ab8-9dae-5b261a5f038f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca703f59-8e26-4b20-be70-2127aa01fc78"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7f26fbbf-b17c-4eaf-8186-36d9ccf0d066"),
				CreatedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("82616241-1c86-41b2-b9ec-7620387acc8c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca703f59-8e26-4b20-be70-2127aa01fc78"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7f26fbbf-b17c-4eaf-8186-36d9ccf0d066"),
				CreatedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				Name = @"Terminate1",
				Position = new Point(365, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateWarmupProcessManagerScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7a55492f-cacf-4d78-af86-144930dcad35"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca703f59-8e26-4b20-be70-2127aa01fc78"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7f26fbbf-b17c-4eaf-8186-36d9ccf0d066"),
				CreatedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547"),
				Name = @"WarmupProcessManagerScriptTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(183, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,211,193,74,3,49,16,6,224,187,224,59,72,79,122,233,11,244,84,235,10,61,180,93,186,173,7,111,67,118,220,14,77,38,97,50,17,246,237,205,186,130,135,46,88,53,167,16,248,255,143,33,76,142,17,101,229,153,209,40,121,158,215,226,13,198,216,152,19,58,216,0,67,135,50,127,38,110,215,28,21,216,224,99,191,5,135,247,179,93,8,94,52,49,105,63,198,28,178,206,30,22,183,55,199,191,139,223,210,186,125,66,67,49,3,27,56,163,196,114,242,22,177,93,50,216,62,82,65,53,183,130,143,96,203,137,47,96,19,142,44,13,76,25,89,106,20,131,97,104,151,122,132,203,53,168,184,221,189,53,154,111,229,237,220,142,97,144,184,251,196,47,248,138,53,23,126,214,155,62,142,209,213,9,184,195,67,31,38,167,189,150,91,230,248,251,144,84,208,52,249,166,191,149,74,77,180,199,152,236,228,215,188,86,170,28,144,45,53,78,13,162,100,40,0,235,222,219,50,164,144,151,124,254,199,58,144,195,87,207,248,181,84,130,154,132,239,84,18,46,62,0,252,165,13,150,35,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new WarmupProcessManager(userConnection);
		}

		public override object Clone() {
			return new WarmupProcessManagerSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d585266b-5e89-461c-adce-c20364561547"));
		}

		#endregion

	}

	#endregion

	#region Class: WarmupProcessManager

	/// <exclude/>
	public class WarmupProcessManager : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, WarmupProcessManager process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public WarmupProcessManager(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WarmupProcessManager";
			SchemaUId = new Guid("d585266b-5e89-461c-adce-c20364561547");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d585266b-5e89-461c-adce-c20364561547");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: WarmupProcessManager, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: WarmupProcessManager, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _start1;
		public ProcessFlowElement Start1 {
			get {
				return _start1 ?? (_start1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start1",
					SchemaElementUId = new Guid("4c69a5cb-e631-4ab8-9dae-5b261a5f038f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("82616241-1c86-41b2-b9ec-7620387acc8c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _warmupProcessManagerScriptTask;
		public ProcessScriptTask WarmupProcessManagerScriptTask {
			get {
				return _warmupProcessManagerScriptTask ?? (_warmupProcessManagerScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "WarmupProcessManagerScriptTask",
					SchemaElementUId = new Guid("7a55492f-cacf-4d78-af86-144930dcad35"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = WarmupProcessManagerScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[WarmupProcessManagerScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { WarmupProcessManagerScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("WarmupProcessManagerScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "WarmupProcessManagerScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start1", string.Empty));
		}

		protected override void CompleteApplyingFlowElementsPropertiesData() {
			base.CompleteApplyingFlowElementsPropertiesData();
			foreach (var item in FlowElements) {
				foreach (var itemValue in item.Value) {
					if (Guid.Equals(itemValue.CreatedInSchemaUId, InternalSchemaUId)) {
						itemValue.ExecutedEventHandler = OnExecuted;
					}
				}
			}
		}

		protected override void InitializeMetaPathParameterValues() {
			base.InitializeMetaPathParameterValues();
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool WarmupProcessManagerScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.ProcessSchemaManager.FindInstanceByName("OpportunityManagement");
			UserConnection.ProcessSchemaManager.FindInstanceByName("OppManagementIdDecisionMakers");
			UserConnection.ProcessSchemaManager.FindInstanceByName("OppManagementNeedAnalysis");
			UserConnection.ProcessSchemaManager.FindInstanceByName("OppManagementProposal");
			UserConnection.ProcessSchemaManager.FindInstanceByName("OppManagementValueProposition");
			UserConnection.ProcessSchemaManager.FindInstanceByName("OppManagerPerceptionAnalysis");
			UserConnection.ProcessSchemaManager.FindInstanceByName("OpportunityManagementEndOfStage");
			UserConnection.ProcessSchemaManager.FindInstanceByName("OpportunityManagementProspecting");
			
			UserConnection.EntitySchemaManager.FindInstanceByName("SysEntityChangeType");
			UserConnection.EntitySchemaManager.FindInstanceByName("ActivityStatus");
			UserConnection.EntitySchemaManager.FindInstanceByName("ActivityType");
			UserConnection.EntitySchemaManager.FindInstanceByName("ActivityResult");
			UserConnection.EntitySchemaManager.FindInstanceByName("EmailType");
			UserConnection.EntitySchemaManager.FindInstanceByName("ActivityParticipantRole");
			UserConnection.EntitySchemaManager.FindInstanceByName("ActivityPriority");
			UserConnection.EntitySchemaManager.FindInstanceByName("TimeZone");
			
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			if (Status == Core.Process.ProcessStatus.Inactive) {
				return;
			}
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer, writeFlowElements);
			WritePropertyValues(writer, false);
			writer.WriteFinishObject();
		}

		public override object CloneShallow() {
			var cloneItem = (WarmupProcessManager)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


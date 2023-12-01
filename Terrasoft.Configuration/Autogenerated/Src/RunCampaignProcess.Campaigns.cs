namespace Terrasoft.Core.Process
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
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Campaign.Enums;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: RunCampaignProcessSchema

	/// <exclude/>
	public class RunCampaignProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public RunCampaignProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public RunCampaignProcessSchema(RunCampaignProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "RunCampaignProcess";
			UId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db");
			CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,80,203,78,195,48,16,60,39,95,177,202,201,145,144,127,160,180,151,40,148,72,8,1,81,225,188,56,91,106,225,71,112,108,32,66,253,119,226,164,34,244,113,177,214,51,187,179,179,211,134,87,37,5,172,131,108,96,77,190,64,221,162,124,51,181,216,145,198,77,213,176,145,17,7,184,106,174,96,211,145,43,172,49,36,188,180,6,194,209,55,135,159,52,57,26,249,83,130,229,184,133,151,186,245,253,34,77,62,209,65,71,106,152,123,12,228,250,129,54,244,5,245,136,176,19,213,52,73,120,97,85,208,134,101,103,22,179,145,190,113,86,207,228,132,189,236,200,17,203,98,11,175,186,242,35,160,98,147,12,127,64,135,154,60,57,54,223,150,231,128,221,193,193,96,240,159,57,94,183,36,228,182,191,183,119,86,188,223,74,227,59,150,159,180,148,223,36,130,167,39,194,102,80,109,208,227,84,194,114,21,67,73,46,5,50,119,241,24,254,104,237,25,85,160,235,24,213,234,226,177,195,218,125,124,28,249,224,204,121,206,139,116,255,11,61,42,236,187,213,1,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db");
			Version = 0;
			PackageUId = new Guid("f96c8402-9614-48d5-988e-1f34fea20081");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCampaignIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("78ff6226-18fd-4054-a8d7-8364f51fa82e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				Name = @"CampaignId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateScheduledUtcFireTimeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a607a24d-8fb6-4aa5-a092-74b07f2048c7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				Name = @"ScheduledUtcFireTime",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCampaignIdParameter());
			Parameters.Add(CreateScheduledUtcFireTimeParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent startevent1 = CreateStartEvent1StartEvent();
			FlowElements.Add(startevent1);
			ProcessSchemaTerminateEvent terminateevent1 = CreateTerminateEvent1TerminateEvent();
			FlowElements.Add(terminateevent1);
			ProcessSchemaScriptTask runcampaignscripttask = CreateRunCampaignScriptTaskScriptTask();
			FlowElements.Add(runcampaignscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("fdbe892f-d639-44ca-a24c-df1f84bb8742"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f96c8402-9614-48d5-988e-1f34fea20081"),
				CreatedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fae6af65-f56c-4e17-9be2-c2f39b31efba"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4e9efb44-5b3d-44c3-bde2-da8629708298"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("755b919c-996f-41e5-82ae-d7d4384bc206"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f96c8402-9614-48d5-988e-1f34fea20081"),
				CreatedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4e9efb44-5b3d-44c3-bde2-da8629708298"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5247eb72-3c2f-4f40-b537-453f3a87006c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("956aac5c-eca4-4448-bee2-3098429fa400"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f96c8402-9614-48d5-988e-1f34fea20081"),
				CreatedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("8b224e5a-3fed-438a-9d16-c6dfecebd24c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("956aac5c-eca4-4448-bee2-3098429fa400"),
				CreatedInOwnerSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				CreatedInPackageId = new Guid("f96c8402-9614-48d5-988e-1f34fea20081"),
				CreatedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStartEvent1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("fae6af65-f56c-4e17-9be2-c2f39b31efba"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b224e5a-3fed-438a-9d16-c6dfecebd24c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f96c8402-9614-48d5-988e-1f34fea20081"),
				CreatedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				Name = @"StartEvent1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("5247eb72-3c2f-4f40-b537-453f3a87006c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b224e5a-3fed-438a-9d16-c6dfecebd24c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f96c8402-9614-48d5-988e-1f34fea20081"),
				CreatedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				Name = @"TerminateEvent1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRunCampaignScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4e9efb44-5b3d-44c3-bde2-da8629708298"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b224e5a-3fed-438a-9d16-c6dfecebd24c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f96c8402-9614-48d5-988e-1f34fea20081"),
				CreatedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"),
				Name = @"RunCampaignScriptTask",
				Position = new Point(283, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = true,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,221,110,130,48,20,190,150,167,104,184,170,73,195,11,232,76,22,116,198,93,44,102,206,7,56,194,145,213,216,214,148,214,205,24,223,125,7,161,19,144,43,202,233,247,119,190,158,193,178,12,212,9,100,161,87,57,123,97,75,116,211,165,151,249,140,199,233,255,60,30,79,162,51,33,125,137,54,53,90,99,230,164,209,13,122,219,25,18,175,59,8,220,50,251,198,220,31,49,223,186,236,77,90,252,146,10,27,133,57,184,251,47,113,55,3,168,160,16,114,86,24,5,219,16,55,237,143,249,99,33,209,139,76,74,114,207,248,147,82,178,42,63,140,91,168,147,187,240,241,152,93,163,81,101,120,48,187,197,47,102,222,25,75,86,26,127,88,240,122,127,220,112,210,12,232,53,88,80,101,131,157,203,187,37,216,203,180,116,86,234,66,48,179,59,80,142,89,165,63,186,178,248,41,121,44,6,150,188,137,26,61,88,141,24,238,245,137,243,90,191,133,96,109,207,214,77,242,233,117,135,165,96,137,26,45,208,134,27,71,31,44,46,61,182,130,186,2,98,7,68,50,199,61,248,163,91,163,149,134,146,71,163,27,149,211,170,49,169,15,200,187,207,34,30,229,81,155,183,200,162,243,86,51,103,61,78,254,0,150,31,154,108,162,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6c04eb9b-f4bb-4657-b338-e7234d38b202"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("14282258-f9ae-4cbe-b740-b85af3eb3a4a"),
				Name = "Terrasoft.Core.Campaign.Enums",
				Alias = "",
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new RunCampaignProcess(userConnection);
		}

		public override object Clone() {
			return new RunCampaignProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db"));
		}

		#endregion

	}

	#endregion

	#region Class: RunCampaignProcessMethodsWrapper

	/// <exclude/>
	public class RunCampaignProcessMethodsWrapper : ProcessModel
	{

		public RunCampaignProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("RunCampaignScriptTaskExecute", RunCampaignScriptTaskExecute);
		}

		#region Methods: Private

		private bool RunCampaignScriptTaskExecute(ProcessExecutingContext context) {
			var campaignId = Get<Guid>("CampaignId");
			var userConnection = Get<UserConnection>("UserConnection");
			var scheduledUtcFireTime = Get<DateTime>("ScheduledUtcFireTime");
			var campaignSchemaUId = GetCampaignSchemaUId(campaignId, userConnection);
			if (campaignSchemaUId.IsNotEmpty()) {
				var jobExecutor = new CampaignJobExecutor();
				var jobParams = new Dictionary<string, object> {
					{ "CampaignSchemaUId", campaignSchemaUId },
					{ "ScheduledUtcFireTime", scheduledUtcFireTime },
					{ "ScheduledAction", CampaignScheduledAction.Run },
					{ "SchemaGeneratorStrategy", CampaignSchemaExecutionStrategy.DefaultPeriod }
				};
				jobExecutor.Execute(userConnection, jobParams);
			}
			return true;
		}

			public Guid GetCampaignSchemaUId(Guid campaignId, UserConnection userConnection) {
				Guid campaignSchemaUId = Guid.Empty;
				var selectQuery = new Select(userConnection)
					.Column("CampaignSchemaUId")
					.From("Campaign")
					.Where("Id").IsEqual(Column.Parameter(campaignId)) as Select;
				selectQuery.SpecifyNoLockHints();
				selectQuery.ExecuteReader(dataReader => {
					campaignSchemaUId = dataReader.GetColumnValue<Guid>("CampaignSchemaUId");
				});
				return campaignSchemaUId;
			}

		#endregion

	}

	#endregion

	#region Class: RunCampaignProcess

	/// <exclude/>
	public class RunCampaignProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, RunCampaignProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public RunCampaignProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RunCampaignProcess";
			SchemaUId = new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			ProcessModel = new RunCampaignProcessMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bf34bef3-8e0d-47f1-96c5-dace6f02c4db");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: RunCampaignProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: RunCampaignProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

		public virtual Guid CampaignId {
			get;
			set;
		}

		public virtual DateTime ScheduledUtcFireTime {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _startEvent1;
		public ProcessFlowElement StartEvent1 {
			get {
				return _startEvent1 ?? (_startEvent1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartEvent1",
					SchemaElementUId = new Guid("fae6af65-f56c-4e17-9be2-c2f39b31efba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent1;
		public ProcessTerminateEvent TerminateEvent1 {
			get {
				return _terminateEvent1 ?? (_terminateEvent1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1",
					SchemaElementUId = new Guid("5247eb72-3c2f-4f40-b537-453f3a87006c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _runCampaignScriptTask;
		public ProcessScriptTask RunCampaignScriptTask {
			get {
				return _runCampaignScriptTask ?? (_runCampaignScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RunCampaignScriptTask",
					SchemaElementUId = new Guid("4e9efb44-5b3d-44c3-bde2-da8629708298"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ProcessModel.GetScriptTaskMethod("RunCampaignScriptTaskExecute"),
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[StartEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartEvent1 };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[RunCampaignScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RunCampaignScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("RunCampaignScriptTask", e.Context.SenderName));
						break;
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "RunCampaignScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CampaignId")) {
				writer.WriteValue("CampaignId", CampaignId, Guid.Empty);
			}
			if (!HasMapping("ScheduledUtcFireTime")) {
				writer.WriteValue("ScheduledUtcFireTime", ScheduledUtcFireTime, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartEvent1", string.Empty));
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
			MetaPathParameterValues.Add("78ff6226-18fd-4054-a8d7-8364f51fa82e", () => CampaignId);
			MetaPathParameterValues.Add("a607a24d-8fb6-4aa5-a092-74b07f2048c7", () => ScheduledUtcFireTime);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CampaignId":
					if (!hasValueToRead) break;
					CampaignId = reader.GetValue<System.Guid>();
				break;
				case "ScheduledUtcFireTime":
					if (!hasValueToRead) break;
					ScheduledUtcFireTime = reader.GetValue<System.DateTime>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

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
			var cloneItem = (RunCampaignProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


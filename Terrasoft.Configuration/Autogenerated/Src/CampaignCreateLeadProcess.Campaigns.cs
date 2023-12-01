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
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: CampaignCreateLeadProcessSchema

	/// <exclude/>
	public class CampaignCreateLeadProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public CampaignCreateLeadProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public CampaignCreateLeadProcessSchema(CampaignCreateLeadProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CampaignCreateLeadProcess";
			UId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625");
			CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.6.0.0";
			CultureName = @"ru-RU";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = false;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,87,193,110,219,56,16,61,187,64,255,129,213,161,144,80,65,200,46,176,151,56,49,208,181,221,194,89,55,77,225,116,123,72,123,160,37,218,97,32,83,94,146,74,227,13,242,239,59,228,80,18,41,43,13,176,104,42,25,18,103,248,230,205,204,27,234,245,171,125,189,46,121,78,238,185,212,53,45,201,125,197,11,50,149,140,106,182,100,180,136,19,242,248,250,213,232,158,74,82,86,219,45,147,228,156,108,203,106,77,203,211,211,105,181,219,85,34,91,194,115,46,182,230,254,137,10,10,107,178,143,76,47,237,234,88,223,114,149,173,242,91,182,163,217,37,221,177,100,236,188,105,42,183,76,47,196,166,154,86,101,201,114,205,43,1,190,175,135,30,83,69,22,115,81,239,152,164,235,146,157,253,197,14,127,211,178,102,87,148,203,179,143,53,47,82,98,174,147,137,241,205,55,36,30,244,253,230,156,136,186,44,49,158,209,92,104,174,15,8,140,148,16,168,251,121,78,190,42,38,167,149,16,104,150,249,11,189,240,22,66,105,42,114,246,231,193,68,21,71,134,171,200,6,55,154,113,107,73,229,225,76,105,9,204,164,164,90,223,129,187,9,17,176,182,133,174,96,51,240,52,99,27,90,151,26,144,214,59,161,98,227,104,165,217,126,81,160,55,46,52,201,171,90,104,75,253,137,125,182,228,74,219,192,39,13,141,69,64,162,96,63,73,183,38,70,71,155,10,146,154,223,146,248,57,250,188,148,16,46,6,19,228,200,115,236,89,222,220,207,115,143,196,12,203,7,223,196,33,159,136,101,212,89,102,43,75,1,134,111,113,169,120,112,145,183,34,142,86,128,78,27,170,48,37,59,38,244,149,172,114,166,84,148,146,13,45,21,123,217,199,23,40,119,190,225,12,184,19,154,230,64,34,216,118,81,103,118,153,115,51,76,94,63,189,123,120,104,168,11,211,220,144,22,212,28,34,129,204,218,91,200,30,86,66,246,129,139,194,149,151,113,156,193,214,14,141,45,114,103,26,150,245,47,35,70,139,212,194,12,162,27,61,217,27,94,181,60,52,190,204,54,190,59,122,207,226,164,219,233,184,246,178,247,69,225,117,159,15,217,58,123,247,174,41,229,9,249,227,228,164,115,53,2,168,87,84,41,230,106,223,107,131,116,160,198,91,167,67,24,166,0,89,198,221,146,126,247,180,145,54,183,160,140,13,153,99,143,142,156,106,147,247,249,67,206,246,182,189,216,67,11,27,21,49,251,70,165,248,80,201,29,213,168,3,4,170,5,50,107,139,138,124,143,30,79,158,190,71,36,167,80,23,149,38,107,70,114,219,30,69,246,248,251,211,92,202,74,158,146,199,223,158,162,20,125,246,11,48,133,13,179,79,80,216,80,230,41,153,11,208,233,74,152,122,207,46,217,207,37,23,77,14,45,90,123,241,20,48,160,197,208,0,188,183,172,255,31,202,205,6,240,31,254,204,191,222,232,248,133,240,29,235,156,145,28,226,132,174,29,49,71,250,104,148,236,121,183,152,100,191,173,190,212,12,202,151,169,127,156,237,209,187,248,101,121,79,73,52,165,59,104,146,173,48,248,80,213,193,165,41,110,68,31,71,23,171,207,151,131,47,26,203,200,131,6,185,239,220,1,48,99,2,132,12,234,99,74,60,241,183,109,238,219,134,205,110,41,108,222,47,10,240,236,47,54,91,92,31,246,172,240,36,192,13,132,22,229,162,153,89,33,241,182,141,187,80,82,111,19,92,126,241,94,74,122,32,119,120,179,99,12,76,184,77,83,105,106,55,128,237,6,25,4,227,12,92,24,228,237,91,231,226,184,56,23,118,126,13,164,30,239,147,9,41,176,158,112,100,0,6,108,31,231,239,186,250,108,75,228,236,69,63,205,120,28,225,3,167,200,70,117,65,188,192,109,52,109,31,68,3,11,237,246,193,74,251,36,234,141,141,231,1,4,113,152,225,17,196,149,248,82,236,191,201,236,208,226,66,193,222,113,128,57,1,90,157,204,189,96,208,96,247,36,253,152,5,8,204,119,115,19,236,245,99,60,104,135,177,12,26,54,123,118,150,221,44,67,51,175,56,222,244,202,114,56,102,31,254,80,33,119,43,83,18,163,114,36,70,27,76,47,248,59,39,221,200,8,230,195,147,39,124,35,201,116,45,251,19,126,252,156,34,186,62,57,110,15,39,12,166,59,240,103,167,129,119,170,106,9,236,222,15,118,179,43,33,95,142,46,176,238,173,23,247,19,14,213,12,96,168,106,163,51,119,100,191,80,205,101,198,64,126,56,28,132,254,101,113,187,115,98,78,220,206,83,163,67,158,195,80,133,252,29,103,84,155,35,116,183,246,38,162,69,97,34,142,126,244,124,182,78,173,77,239,20,227,88,110,94,223,68,221,7,201,204,111,15,231,213,178,60,30,74,19,14,243,225,228,216,47,157,254,16,180,154,186,247,158,164,193,167,199,115,135,110,4,254,117,95,0,74,82,219,27,142,34,28,67,248,226,72,234,91,137,197,175,158,40,49,33,152,83,91,28,249,160,64,128,49,235,217,21,149,80,120,112,152,137,125,136,9,218,125,187,101,18,142,181,70,211,179,133,136,251,38,106,224,80,144,216,76,35,58,195,159,135,60,155,63,176,188,6,208,73,67,224,127,242,36,67,21,43,14,0,0 };
			RealUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625");
			Version = 0;
			PackageUId = new Guid("f96c8402-9614-48d5-988e-1f34fea20081");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateLeadStepIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("eb87380c-a95a-4a44-95da-b83827b301b6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Name = @"LeadStepId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTargetInfoCollectionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ba95186c-0b66-4608-8e44-30714cb58500"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Name = @"TargetInfoCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadStepIdParameter());
			Parameters.Add(CreateTargetInfoCollectionParameter());
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
			ProcessSchemaScriptTask createleadscripttask = CreateCreateLeadScriptTaskScriptTask();
			FlowElements.Add(createleadscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("eebcd74c-6407-4aab-8e22-5a3c69e80227"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c453f4bb-0948-45ee-9f3c-531394a38393"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("94653132-aac7-4355-97f2-b2c31c58fd4f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("4f64caef-8293-4432-a27f-1ea8c4224231"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("94653132-aac7-4355-97f2-b2c31c58fd4f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab63017c-3d97-4dfb-a462-9d975f3c007c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("cb83dccf-f722-4089-b444-79c61eeccf4f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("3d83941c-854f-4239-9104-f7dae1bf1919"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("cb83dccf-f722-4089-b444-79c61eeccf4f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("c453f4bb-0948-45ee-9f3c-531394a38393"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d83941c-854f-4239-9104-f7dae1bf1919"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("ab63017c-3d97-4dfb-a462-9d975f3c007c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d83941c-854f-4239-9104-f7dae1bf1919"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateLeadScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("94653132-aac7-4355-97f2-b2c31c58fd4f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d83941c-854f-4239-9104-f7dae1bf1919"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369"),
				CreatedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"),
				Name = @"CreateLeadScriptTask",
				Position = new Point(288, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,115,46,74,77,44,73,245,73,77,76,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,157,165,154,94,27,0,0,0 }
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
			return new CampaignCreateLeadProcess(userConnection);
		}

		public override object Clone() {
			return new CampaignCreateLeadProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignCreateLeadProcess

	/// <exclude/>
	public class CampaignCreateLeadProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, CampaignCreateLeadProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public CampaignCreateLeadProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignCreateLeadProcess";
			SchemaUId = new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("35deb097-e755-4e60-bd6f-53c5f7baf625");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: CampaignCreateLeadProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: CampaignCreateLeadProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid LeadStepId {
			get;
			set;
		}

		public virtual Object TargetInfoCollection {
			get;
			set;
		}

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
					SchemaElementUId = new Guid("c453f4bb-0948-45ee-9f3c-531394a38393"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("ab63017c-3d97-4dfb-a462-9d975f3c007c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _createLeadScriptTask;
		public ProcessScriptTask CreateLeadScriptTask {
			get {
				return _createLeadScriptTask ?? (_createLeadScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateLeadScriptTask",
					SchemaElementUId = new Guid("94653132-aac7-4355-97f2-b2c31c58fd4f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CreateLeadScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[CreateLeadScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateLeadScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CreateLeadScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "CreateLeadScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("LeadStepId")) {
				writer.WriteValue("LeadStepId", LeadStepId, Guid.Empty);
			}
			if (TargetInfoCollection != null) {
				if (TargetInfoCollection.GetType().IsSerializable ||
					TargetInfoCollection.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("TargetInfoCollection", TargetInfoCollection, null);
				}
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
			MetaPathParameterValues.Add("eb87380c-a95a-4a44-95da-b83827b301b6", () => LeadStepId);
			MetaPathParameterValues.Add("ba95186c-0b66-4608-8e44-30714cb58500", () => TargetInfoCollection);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "LeadStepId":
					if (!hasValueToRead) break;
					LeadStepId = reader.GetValue<System.Guid>();
				break;
				case "TargetInfoCollection":
					if (!hasValueToRead) break;
					TargetInfoCollection = reader.GetSerializableObjectValue();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool CreateLeadScriptTaskExecute(ProcessExecutingContext context) {
			CreateLead();
			return true;
		}

			
			public virtual void CreateLead() {
				var logger = global::Common.Logging.LogManager.GetLogger(this.Schema.Name);
				var targetInfoCollection = TargetInfoCollection as IEnumerable<KeyValuePair<Guid, Guid>>;
				if (targetInfoCollection != null) {
					EntitySchema leadSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Lead");
					Dictionary<string, object> nameValuePairs = GetDefaultColumns(LeadStepId);
					int counter = 0;
					List<Guid> targetIdCollection = new List<Guid>();
					foreach (KeyValuePair<Guid, Guid> targetInfo in targetInfoCollection) {
						Entity leadEntity = leadSchema.CreateEntity(UserConnection);
						leadEntity.SetDefColumnValues();
						leadEntity.SetColumnValue("StartLeadManagementProcess", false);
						leadEntity.SetColumnValue("QualifiedContactId", targetInfo.Value);
						foreach (KeyValuePair<string, object> pair in nameValuePairs) {
							EntitySchemaColumn column = leadSchema.Columns.FindByName(pair.Key);
							if (column != null) {
								leadEntity.SetColumnValue(column, pair.Value);
							}
						}
						try {
							if (leadEntity.Save()) {
								targetIdCollection.Add(targetInfo.Key);
								if (++counter > 500) {
									SetPassedStepId(LeadStepId, targetIdCollection);
									targetIdCollection.Clear();
									counter = 0;
								}
							}
							leadEntity = null;
						}
						catch (Exception ex) {
							logger.WarnFormat("Lead for contact \"{0}\" can not be created.{2}Error: {1}",
							targetInfo.Value, ex.Message, Environment.NewLine);
						}
					}
					if (targetIdCollection.Count > 0) {
						SetPassedStepId(LeadStepId, targetIdCollection);
					}
				}
			}
			
			
			public virtual Dictionary<string, object> GetDefaultColumns(Guid StepId) {
				var nameValuePairs = new Dictionary<string, object>();
				EntitySchemaQuery esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "CampaignStep");
				esq.AddColumn("JSON");
				esq.AddColumn("Campaign");
				Entity campaignStep = esq.GetEntity(UserConnection, StepId);
				if (campaignStep != null) {
					Guid campaignId = campaignStep.GetTypedColumnValue<Guid>("CampaignId");
					nameValuePairs.Add("Campaign", campaignId);
					JArray jArray = GetAdditionalInfo(campaignStep);
					if (jArray != null && jArray.Count > 0) {
						IList<Dictionary<string, string>> defaultValues = 
							jArray.ToObject<IList<Dictionary<string, string>>>();
						string columnNameKey = "ColumnName";
						string columnValueKey = "ColumnValue";
						foreach (Dictionary<string, string> defaultValue in defaultValues) {
							if (defaultValue.ContainsKey(columnNameKey) &&
								defaultValue.ContainsKey(columnValueKey)) {
									string columnName = defaultValue[columnNameKey];
									string columnValue = defaultValue[columnValueKey];
									if (columnValue != null && !nameValuePairs.ContainsKey(columnName)) {
										nameValuePairs.Add(columnName, (object)new Guid(columnValue));
									}
							}
						}
					}
				}
				return nameValuePairs;
			}
			
			
			public virtual JArray GetAdditionalInfo(Entity StepEntity) {
				var jsonValue = StepEntity.GetTypedColumnValue<string>("JSON");
				JObject jsonObject = Terrasoft.Common.Json.Json.Deserialize(jsonValue) as JObject;
				if (jsonObject != null) {
					JObject jsonData = jsonObject["addInfo"] as JObject;
					if (jsonData != null) {
						return jsonData["CreateLeadDefaultValues"] as JArray;
					}
				}
				return null;
			}
			
			
			public virtual void SetPassedStepId(Guid passedStepId, IEnumerable<Guid> targetIdCollection) {
				Update updateQuery = new Update(UserConnection, "CampaignTarget")
					.Set("PassedStepId", Column.Parameter(passedStepId))
					.Where("Id").In(Column.Parameters(targetIdCollection)) as Update;
				updateQuery.Execute();
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
			var cloneItem = (CampaignCreateLeadProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.TargetInfoCollection = TargetInfoCollection;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


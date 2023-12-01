namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: RunSendEmailToCaseGroupSchema

	/// <exclude/>
	public class RunSendEmailToCaseGroupSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public RunSendEmailToCaseGroupSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public RunSendEmailToCaseGroupSchema(RunSendEmailToCaseGroupSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "RunSendEmailToCaseGroup";
			UId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae");
			CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"Business process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("02541d56-c300-4b56-b7b9-a795a2af3a8e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"CaseRecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3c1a583e-579d-4272-8c0c-cb74582f81f0}].[Parameter:{bcf4067c-cafc-4056-b29f-1afecb12a005}]#]  == Guid.Empty ? [#[IsOwnerSchema:false].[IsSchema:false].[Element:{5f24a920-e8d6-4e2b-ab95-9606f938e9ce}].[Parameter:{387361b5-5452-454b-89f5-1cd99a230829}]#] : [#[IsOwnerSchema:false].[IsSchema:false].[Element:{3c1a583e-579d-4272-8c0c-cb74582f81f0}].[Parameter:{bcf4067c-cafc-4056-b29f-1afecb12a005}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseRecordIdParameter());
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bcf4067c-cafc-4056-b29f-1afecb12a005"),
				ContainerUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7cc92fc9-fece-47af-9bf1-99d8b3ec74eb"),
				ContainerUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeStartSignal2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("387361b5-5452-454b-89f5-1cd99a230829"),
				ContainerUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fbbbcb2e-769d-4c62-aa1b-04440ddcd118"),
				ContainerUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaStartSignalEvent startsignal1 = CreateStartSignal1StartSignalEvent();
			FlowElements.Add(startsignal1);
			ProcessSchemaStartSignalEvent startsignal2 = CreateStartSignal2StartSignalEvent();
			FlowElements.Add(startsignal2);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask runprocess = CreateRunProcessScriptTask();
			FlowElements.Add(runprocess);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("14ab0ad1-8660-4bb3-8424-564ccb990427"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(185, 127));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("bc83b551-12cb-4fba-accd-964617644676"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(185, 267));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("930315a5-ede8-41f0-822f-7abd90adfb85"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6b467a14-3688-4459-af56-2285cc0165d9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f937c722-64ff-4561-ab8b-c5f114957735"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6b467a14-3688-4459-af56-2285cc0165d9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2d3139b5-6a1a-4db2-acb1-ecb5cfa443cb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8c91975d-2cb4-4229-8b2b-8c71b0e9324c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8c91975d-2cb4-4229-8b2b-8c71b0e9324c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("2d3139b5-6a1a-4db2-acb1-ecb5cfa443cb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"Terminate1",
				Position = new Point(438, 180),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(77, 113),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal2StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"StartSignal2",
				NewEntityChangedColumns = false,
				Position = new Point(77, 253),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("70620d00-e4ea-48d1-9fdc-4572fcd8d41b");
			schemaStartSignalEvent.EntityChangedColumns.Add("9147230c-ab53-4eb4-b0b4-ac78be6f8326");
			InitializeStartSignal2Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"ExclusiveGateway1",
				Position = new Point(157, 166),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateRunProcessScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6b467a14-3688-4459-af56-2285cc0165d9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"RunProcess",
				Position = new Point(280, 166),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,86,219,110,219,56,16,125,118,128,252,131,170,39,25,112,132,108,214,45,140,122,147,133,171,216,89,23,77,155,141,236,246,161,232,3,87,154,56,4,36,74,37,169,110,141,198,255,222,225,69,50,37,43,65,138,6,136,109,113,56,103,14,207,92,168,181,0,30,21,140,65,34,105,193,188,170,253,120,238,173,91,11,211,227,35,122,231,5,237,93,97,84,113,14,76,170,173,225,126,121,181,45,193,59,55,8,234,119,24,199,55,67,239,199,241,209,224,32,72,7,111,86,150,206,83,188,21,18,242,3,30,187,227,163,111,132,123,2,88,10,124,158,19,154,33,208,10,56,39,162,184,147,200,131,131,34,115,71,55,21,39,53,80,12,82,82,182,17,225,21,200,143,36,171,224,47,33,57,46,92,116,142,52,242,144,166,31,87,101,89,112,25,3,255,70,19,208,49,252,145,103,60,194,121,94,202,237,176,95,16,68,95,138,5,16,89,113,152,51,242,95,6,105,224,107,255,107,16,130,108,224,186,202,36,125,71,216,166,194,7,127,232,61,60,116,53,248,53,136,143,103,254,208,104,171,52,73,136,128,91,72,10,158,46,83,20,37,136,37,193,83,208,13,35,217,31,97,99,120,113,238,93,85,52,181,7,65,215,193,223,94,255,78,101,123,237,218,206,26,219,212,134,4,241,21,35,49,248,223,155,51,73,229,54,78,238,33,39,255,86,192,183,93,113,220,13,215,132,33,123,62,242,252,8,57,251,74,206,1,66,133,179,52,141,138,172,202,89,224,95,241,162,42,141,165,62,155,65,192,120,106,43,10,101,158,15,82,232,202,160,253,85,166,28,127,20,128,85,89,102,116,211,224,36,205,41,91,51,42,231,191,123,28,172,181,89,13,102,200,15,92,240,16,203,89,219,111,233,230,94,10,140,117,71,50,1,211,154,8,168,68,27,5,222,147,28,219,168,69,205,149,7,153,72,146,200,208,84,231,48,84,219,27,152,141,210,78,215,192,254,216,74,48,213,142,22,193,116,129,42,132,11,171,245,50,237,35,188,160,153,4,46,84,232,160,101,136,56,22,41,24,243,39,42,239,111,8,71,10,106,111,96,22,163,34,47,9,167,194,76,132,112,254,181,34,25,42,244,25,37,82,77,189,100,183,69,6,175,237,211,23,213,165,106,1,27,205,178,31,14,155,243,36,69,150,53,67,163,197,162,169,130,168,217,210,73,212,30,133,131,192,222,65,4,219,201,111,11,138,66,78,49,226,30,63,140,65,253,10,80,250,11,15,122,53,171,39,71,39,87,67,203,87,21,219,11,27,97,41,222,99,161,125,224,159,238,169,132,184,36,9,4,134,132,109,90,39,233,43,200,203,12,5,141,245,92,179,69,232,142,53,119,162,233,164,43,209,175,73,194,11,97,203,175,247,224,135,17,116,93,60,134,172,218,17,87,132,196,81,169,210,176,119,50,104,191,61,244,246,19,11,255,122,78,30,170,47,237,189,224,69,190,42,2,183,155,71,221,147,140,220,123,96,100,51,108,15,62,224,128,148,152,39,121,101,58,99,176,243,0,155,173,14,126,40,189,196,187,227,57,202,183,28,250,85,63,68,175,5,248,7,178,242,121,9,238,247,236,8,242,120,244,204,186,233,124,63,65,69,37,240,93,179,55,232,40,236,34,74,187,186,159,195,7,106,232,142,177,11,93,168,145,67,169,134,253,245,10,104,147,8,111,56,205,9,223,58,13,250,84,77,236,212,167,250,192,127,167,26,212,24,212,94,70,247,66,117,129,46,127,155,38,101,199,145,251,106,178,120,57,27,207,79,102,151,167,175,78,198,209,228,207,147,201,36,26,159,156,142,79,47,207,198,147,211,197,44,122,179,191,176,114,211,148,135,111,57,55,188,72,176,49,90,55,71,237,84,186,54,116,181,32,186,199,176,41,9,75,224,205,118,141,89,234,35,219,220,117,45,148,208,246,164,115,221,89,251,156,109,40,131,71,9,26,243,180,235,244,29,146,10,51,141,110,45,152,198,203,218,181,223,37,213,136,152,31,59,53,235,183,168,11,175,172,175,11,157,51,97,133,126,194,193,116,237,103,253,194,80,87,131,255,5,253,220,133,112,85,196,122,127,160,95,108,118,154,69,135,121,104,126,64,71,166,181,42,174,14,43,173,232,78,191,115,186,195,228,39,132,62,205,169,60,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("09015002-8c72-44a0-87aa-300725e2353a"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4bc22559-3627-4ea2-9aee-a2721c12aafa"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("60d0ddb8-902b-457f-9428-6aa42c5240aa"),
				Name = "System",
				Alias = "",
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7abde226-b990-4e5b-9337-0c55786d6c6f"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new RunSendEmailToCaseGroup(userConnection);
		}

		public override object Clone() {
			return new RunSendEmailToCaseGroupSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"));
		}

		#endregion

	}

	#endregion

	#region Class: RunSendEmailToCaseGroup

	/// <exclude/>
	public class RunSendEmailToCaseGroup : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, RunSendEmailToCaseGroup process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public RunSendEmailToCaseGroup(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RunSendEmailToCaseGroup";
			SchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_caseRecordId = () => { return (Guid)((StartSignal1.RecordId)  == Guid.Empty ? (StartSignal2.RecordId) : (StartSignal1.RecordId)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: RunSendEmailToCaseGroup, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: RunSendEmailToCaseGroup, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		private Func<Guid> _caseRecordId;
		public virtual Guid CaseRecordId {
			get {
				return (_caseRecordId ?? (_caseRecordId = () => Guid.Empty)).Invoke();
			}
			set {
				_caseRecordId = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
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
					SchemaElementUId = new Guid("2d3139b5-6a1a-4db2-acb1-ecb5cfa443cb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal1;
		public ProcessStartSignalEvent StartSignal1 {
			get {
				return _startSignal1 ?? (_startSignal1 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal1",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal2;
		public ProcessStartSignalEvent StartSignal2 {
			get {
				return _startSignal2 ?? (_startSignal2 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal2",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _runProcess;
		public ProcessScriptTask RunProcess {
			get {
				return _runProcess ?? (_runProcess = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RunProcess",
					SchemaElementUId = new Guid("6b467a14-3688-4459-af56-2285cc0165d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = RunProcessExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[StartSignal2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal2 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[RunProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { RunProcess };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "StartSignal2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("RunProcess", e.Context.SenderName));
						break;
					case "RunProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CaseRecordId")) {
				writer.WriteValue("CaseRecordId", CaseRecordId, Guid.Empty);
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
			MetaPathParameterValues.Add("02541d56-c300-4b56-b7b9-a795a2af3a8e", () => CaseRecordId);
			MetaPathParameterValues.Add("bcf4067c-cafc-4056-b29f-1afecb12a005", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("7cc92fc9-fece-47af-9bf1-99d8b3ec74eb", () => StartSignal1.EntitySchemaUId);
			MetaPathParameterValues.Add("387361b5-5452-454b-89f5-1cd99a230829", () => StartSignal2.RecordId);
			MetaPathParameterValues.Add("fbbbcb2e-769d-4c62-aa1b-04440ddcd118", () => StartSignal2.EntitySchemaUId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CaseRecordId":
					if (!hasValueToRead) break;
					CaseRecordId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool RunProcessExecute(ProcessExecutingContext context) {
			UserConnection userConnection = UserConnection;
			if (userConnection.CurrentUser.ConnectionType == UserType.SSP) {
				userConnection = userConnection.AppConnection.SystemUserConnection;
			}
			var senderEmail = Terrasoft.Core.Configuration.SysSettings.GetValue<string>(userConnection, 
				"SupportServiceEmail", string.Empty);
			if (userConnection.GetIsFeatureEnabled("EmailMessageMultiLanguage") || userConnection.GetIsFeatureEnabled("EmailMessageMultiLanguageV2")) {
				var caseRecordId = (StartSignal1.RecordId != Guid.Empty)
					? StartSignal1.RecordId 
					: StartSignal2.RecordId;
				var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "Case");
				esq.AddColumn("Group");
				var caseEntity = esq.GetEntity(userConnection, caseRecordId);
				if (caseEntity != null) {
					var adminUnitEsq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "SysAdminUnit");
					adminUnitEsq.UseAdminRights = false;
					var emailColumnName = adminUnitEsq.AddColumn("Contact.Email").Name;
					var groupId = caseEntity.GetTypedColumnValue<Guid>("GroupId");
					adminUnitEsq.Filters.Add(adminUnitEsq.CreateFilterWithParameters(FilterComparisonType.Equal, "[SysUserInRole:SysUser].SysRole", groupId));
					var collection = adminUnitEsq.GetEntityCollection(userConnection);
					var result = string.Join(";", collection.Select(e => e.GetTypedColumnValue<string>(emailColumnName)));
					if (!string.IsNullOrWhiteSpace(result)) {
						var emailTemplateSender = new Terrasoft.Configuration.EmailWithMacrosManager(userConnection);
						var emailTemplateId = Terrasoft.Configuration.CaseConsts.GroupTemplateId;
						if (userConnection.GetIsFeatureEnabled("EmailMessageMultiLanguageV2")) {
							emailTemplateSender.SendEmailFromTo(caseRecordId, emailTemplateId, senderEmail, result);
							return true;
						} else {
							var emailTemplateStore = new Terrasoft.Configuration.EmailTemplateStore(userConnection);
							var emailTemplateLanguageHelper = new Terrasoft.Configuration.EmailTemplateLanguageHelper(caseRecordId, userConnection);
							var languageId = emailTemplateLanguageHelper.GetLanguageId(emailTemplateId);
							var templateEntity = emailTemplateStore.GetTemplate(emailTemplateId, languageId);
							emailTemplateSender.SendEmailFromTo(caseRecordId, templateEntity.PrimaryColumnValue, senderEmail, result);
						}
					}
				}
			} else {
				Guid sendEmailToCaseGroup = new Guid("C68F5A4E-AD06-4C83-88C4-040D2480FACB");
				var manager = userConnection.ProcessSchemaManager;
				var processSchema = manager.GetInstanceByUId(sendEmailToCaseGroup);
				if (processSchema.Enabled) {
					var processEngine = userConnection.ProcessEngine;
					var processExecutor = processEngine.ProcessExecutor;
					Dictionary<string, string> parameterValues = new Dictionary<string, string> {
						["CaseRecordId"] = CaseRecordId.ToString()
					};
					processExecutor.Execute(processSchema.UId, parameterValues);
				}
			}
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
			var cloneItem = (RunSendEmailToCaseGroup)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


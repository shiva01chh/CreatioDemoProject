namespace Terrasoft.Core.Process
{

	using IntegrationApi.Interfaces;
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
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Sync;
	using Terrasoft.Sync.Exchange;

	#region Class: SyncExchangeActivitiesProcessSchema

	/// <exclude/>
	public class SyncExchangeActivitiesProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SyncExchangeActivitiesProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SyncExchangeActivitiesProcessSchema(SyncExchangeActivitiesProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SyncExchangeActivitiesProcess";
			UId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a");
			CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
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
			Tag = @"Business Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,77,111,26,49,16,61,19,41,255,193,181,122,88,20,180,106,175,73,137,68,9,180,72,9,173,66,114,42,61,56,236,132,172,226,181,145,237,37,221,160,253,239,29,239,71,216,15,147,64,83,33,4,242,140,223,204,155,121,99,251,248,104,21,223,241,112,65,214,161,50,49,227,100,45,195,128,204,18,177,120,80,82,132,207,224,117,201,230,248,168,115,41,151,23,112,23,47,189,143,180,98,36,240,103,241,192,196,18,8,91,152,112,29,154,16,52,209,134,41,3,1,185,151,138,108,102,32,2,80,163,136,133,124,16,4,10,180,78,105,247,12,1,195,123,226,181,141,254,68,79,99,206,127,224,226,202,36,94,55,15,126,72,116,80,202,198,157,2,4,51,48,183,26,84,61,110,103,44,85,196,204,53,232,152,27,175,237,150,59,41,48,177,18,246,111,138,223,53,83,228,1,248,10,20,233,19,1,79,100,36,76,104,146,74,42,234,123,102,246,178,221,185,171,63,228,192,84,219,211,179,193,134,82,8,192,164,165,200,118,140,10,34,183,38,228,232,238,95,0,7,3,89,13,6,57,181,100,172,100,84,254,127,5,174,71,74,39,92,211,70,251,55,76,63,222,36,43,184,157,4,121,221,133,33,108,181,146,248,27,129,48,151,114,193,248,48,11,174,135,50,22,166,87,181,94,67,36,13,84,205,22,66,27,21,138,101,221,207,86,243,10,203,199,176,27,125,146,123,248,25,129,179,125,212,179,133,58,68,63,117,234,254,55,48,19,61,6,134,173,131,145,96,119,28,2,143,78,225,233,10,192,96,58,19,97,96,169,152,117,165,14,97,161,35,9,163,149,84,102,207,12,50,89,104,164,51,195,53,4,69,222,67,206,180,30,163,26,165,74,108,58,95,38,179,173,253,220,163,67,198,17,141,41,218,203,100,148,181,72,197,214,125,160,150,177,165,239,209,120,129,214,134,70,242,120,149,88,254,204,166,152,203,45,37,192,53,228,124,154,66,178,225,203,181,137,129,72,183,228,210,166,215,35,22,169,131,131,223,63,111,51,250,202,52,148,136,22,253,167,146,235,16,17,144,93,185,60,216,118,179,234,65,123,25,110,103,55,243,90,106,237,42,188,181,95,183,168,80,23,191,110,1,36,99,179,83,195,61,210,176,58,230,164,181,191,57,43,69,33,155,61,169,78,49,214,102,129,17,167,44,130,110,121,218,216,9,53,56,181,142,144,118,249,213,153,204,29,42,68,246,153,62,187,105,223,177,251,127,2,251,119,125,217,35,205,33,172,119,234,234,221,178,122,19,198,216,83,200,110,22,120,197,21,42,180,34,106,53,45,215,214,14,13,108,119,184,245,118,136,220,10,213,168,166,98,84,227,60,223,53,38,229,65,252,161,56,240,235,183,119,139,87,121,234,214,225,79,250,132,158,17,74,78,220,234,77,95,141,161,92,248,21,193,143,92,15,148,151,33,200,46,131,130,254,78,225,159,146,77,45,138,243,33,81,207,195,241,134,56,228,9,131,41,188,49,135,136,104,63,174,183,91,45,173,162,193,81,145,87,86,30,87,211,183,119,118,190,221,163,155,205,156,62,66,50,167,167,100,78,55,159,210,57,234,118,78,11,160,98,245,51,174,166,105,143,102,194,115,205,121,180,173,199,165,100,65,158,148,43,22,162,21,153,104,139,253,11,3,254,38,105,138,200,173,194,166,187,136,191,84,216,69,186,57,21,232,236,231,222,81,13,250,47,237,206,13,172,16,11,0,0 };
			RealUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a");
			Version = 0;
			PackageUId = new Guid("b8c22230-2173-426f-959e-be736709a63f");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1706a8e4-a8db-40dd-bcfe-70083813c584"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"SenderEmailAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f363e086-ca54-4a07-b6a4-f2d793380738"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"LoadResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateRemindingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f4f43cc4-e123-4ce2-9acd-20ddaba5c641"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"CreateReminding",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSetUserAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("264bbae8-6f36-4dcf-94e7-82abf4ec9e24"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"NeedSetUserAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSyncActivitySuccessMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d17b41bd-be12-494e-934a-ba442230f54f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"SyncActivitySuccessMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSenderEmailAddressParameter());
			Parameters.Add(CreateLoadResultParameter());
			Parameters.Add(CreateCreateRemindingParameter());
			Parameters.Add(CreateNeedSetUserAddressParameter());
			Parameters.Add(CreateSyncActivitySuccessMessageParameter());
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
			ProcessSchemaScriptTask mainscripttask = CreateMainScriptTaskScriptTask();
			FlowElements.Add(mainscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("41f16446-2ae5-4ea4-ac7d-30b3c1e71a02"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("01fff802-295f-4649-9bca-a1af184a280f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("143c11fd-593c-4449-b58c-0f5cf0393adb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e4a99538-e8d9-4f6d-a8d2-c4de8277151e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("143c11fd-593c-4449-b58c-0f5cf0393adb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("49cf4a4b-4e8c-49da-a7bb-669368c326fc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9fc02540-1342-4ae4-bf1f-3768b697dea1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("0744a239-2513-49f9-b6fa-459d7ee83ba3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("9fc02540-1342-4ae4-bf1f-3768b697dea1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("01fff802-295f-4649-9bca-a1af184a280f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0744a239-2513-49f9-b6fa-459d7ee83ba3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
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
				UId = new Guid("49cf4a4b-4e8c-49da-a7bb-669368c326fc"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0744a239-2513-49f9-b6fa-459d7ee83ba3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMainScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("143c11fd-593c-4449-b58c-0f5cf0393adb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0744a239-2513-49f9-b6fa-459d7ee83ba3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"MainScriptTask",
				Position = new Point(295, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,11,174,204,75,206,40,202,207,203,172,74,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,209,75,113,44,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ccf59d5b-a728-418e-9389-ed5f74140b3b"),
				Name = "Terrasoft.Sync.Exchange",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1699d33-d81c-428e-ab95-b9519e811946"),
				Name = "Terrasoft.Sync",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2cc2de4d-4a49-4023-84e0-87f513f606fd"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7d06a26f-7484-42fa-a34a-a289a78da842"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7835e741-23c7-4f92-bfad-db3d847fa2ad"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c25553c6-8f82-4df6-aa2e-7aa7bdef3c27"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("405cd56e-8293-41da-83e9-a9cf9867a065")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("23df5e27-0cfa-4ef6-b0b4-19e72992cfcc"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("43f3a715-af06-427b-b896-54d69dab34cd"),
				Name = "IntegrationApi.Interfaces",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SyncExchangeActivitiesProcess(userConnection);
		}

		public override object Clone() {
			return new SyncExchangeActivitiesProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"));
		}

		#endregion

	}

	#endregion

	#region Class: SyncExchangeActivitiesProcess

	/// <exclude/>
	public class SyncExchangeActivitiesProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SyncExchangeActivitiesProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public SyncExchangeActivitiesProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SyncExchangeActivitiesProcess";
			SchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a");
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
				return new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SyncExchangeActivitiesProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SyncExchangeActivitiesProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual string SenderEmailAddress {
			get;
			set;
		}

		public virtual string LoadResult {
			get;
			set;
		}

		public virtual bool CreateReminding {
			get;
			set;
		}

		private LocalizableString _needSetUserAddress;
		public virtual LocalizableString NeedSetUserAddress {
			get {
				return _needSetUserAddress ?? (_needSetUserAddress = GetLocalizableString("e58738377f4e4bce93c30179fb72eb6a",
						 "Parameters.NeedSetUserAddress.Value"));
			}
			set {
				_needSetUserAddress = value;
			}
		}

		private LocalizableString _syncActivitySuccessMessage;
		public virtual LocalizableString SyncActivitySuccessMessage {
			get {
				return _syncActivitySuccessMessage ?? (_syncActivitySuccessMessage = GetLocalizableString("e58738377f4e4bce93c30179fb72eb6a",
						 "Parameters.SyncActivitySuccessMessage.Value"));
			}
			set {
				_syncActivitySuccessMessage = value;
			}
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
					SchemaElementUId = new Guid("01fff802-295f-4649-9bca-a1af184a280f"),
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
					SchemaElementUId = new Guid("49cf4a4b-4e8c-49da-a7bb-669368c326fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _mainScriptTask;
		public ProcessScriptTask MainScriptTask {
			get {
				return _mainScriptTask ?? (_mainScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MainScriptTask",
					SchemaElementUId = new Guid("143c11fd-593c-4449-b58c-0f5cf0393adb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = MainScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[MainScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MainScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("MainScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "MainScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("SenderEmailAddress")) {
				writer.WriteValue("SenderEmailAddress", SenderEmailAddress, null);
			}
			if (!HasMapping("LoadResult")) {
				writer.WriteValue("LoadResult", LoadResult, null);
			}
			if (!HasMapping("CreateReminding")) {
				writer.WriteValue("CreateReminding", CreateReminding, false);
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
			MetaPathParameterValues.Add("1706a8e4-a8db-40dd-bcfe-70083813c584", () => SenderEmailAddress);
			MetaPathParameterValues.Add("f363e086-ca54-4a07-b6a4-f2d793380738", () => LoadResult);
			MetaPathParameterValues.Add("f4f43cc4-e123-4ce2-9acd-20ddaba5c641", () => CreateReminding);
			MetaPathParameterValues.Add("264bbae8-6f36-4dcf-94e7-82abf4ec9e24", () => NeedSetUserAddress);
			MetaPathParameterValues.Add("d17b41bd-be12-494e-934a-ba442230f54f", () => SyncActivitySuccessMessage);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "SenderEmailAddress":
					if (!hasValueToRead) break;
					SenderEmailAddress = reader.GetValue<System.String>();
				break;
				case "LoadResult":
					if (!hasValueToRead) break;
					LoadResult = reader.GetValue<System.String>();
				break;
				case "CreateReminding":
					if (!hasValueToRead) break;
					CreateReminding = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool MainScriptTaskExecute(ProcessExecutingContext context) {
			Synchronize();
			return true;
		}

			
			public virtual void Synchronize() {
				LogDebug($"Synchronize exchange activities started for {SenderEmailAddress}");
				if (SenderEmailAddress.IsNullOrEmpty()) {
					LogDebug($"Synchronize exchange activities error {NeedSetUserAddress}");
					FormatResult(NeedSetUserAddress);
					return;
				}
				var helper = new EntitySynchronizerHelper();
				helper.ClearEntitySynchronizer(UserConnection);
				ExchangeUtility.DeleteEmptyActivityFromActivitySynchronizer(UserConnection, ActivityConsts.TaskTypeUId);
				int appointmentLocalChangesCount, appointmentRemoteChangesCount;
				string appointmentResultMessage = string.Empty;
				LogDebug($"Synchronize exchange appointments started for {SenderEmailAddress}");
				if (UserConnection.GetIsFeatureEnabled("NewMeetingIntegration")) {
					LogDebug($"New import started for {SenderEmailAddress}");
					var syncSession = ClassFactory.Get<ISyncSession>("Calendar", new ConstructorArgument("uc", UserConnection));
					syncSession.Start();
				} else {
					ExchangeUtility.SyncExchangeItems(UserConnection, SenderEmailAddress, 
						() => ClassFactory.Get<BaseExchangeSyncProvider>("ExchangeAppointmentSyncProvider",
							new ConstructorArgument("userConnection", UserConnection),
							new ConstructorArgument("senderEmailAddress", SenderEmailAddress)),
						out appointmentResultMessage, out appointmentLocalChangesCount, out appointmentRemoteChangesCount, 
						ExchangeUtility.ActivitySyncProcessName);
				}
				int taskLocalChangesCount, taskRemoteChangesCount;
				string taskResultMessage;
				LogDebug($"Synchronize exchange tasks started for {SenderEmailAddress}");
				ExchangeUtility.SyncExchangeItems(UserConnection, SenderEmailAddress, 
					() => ClassFactory.Get<BaseExchangeSyncProvider>("ExchangeTaskSyncProvider",
						new ConstructorArgument("userConnection", UserConnection),
						new ConstructorArgument("senderEmailAddress", SenderEmailAddress),
						new ConstructorArgument("settings", null)),
					out taskResultMessage, out taskLocalChangesCount, out taskRemoteChangesCount, 
					ExchangeUtility.ActivitySyncProcessName);
				string resultMessage;
				resultMessage = appointmentResultMessage;
				if (!string.IsNullOrEmpty(taskResultMessage)) {
					resultMessage += "; " + taskResultMessage;
				}
				if (!string.IsNullOrEmpty(resultMessage)) {
					LogDebug($"Exchange activities synchronization result for {SenderEmailAddress}: {resultMessage}");
					FormatResult(resultMessage);
					return;
				}
				LogDebug($"Synchronize exchange activities ended for {SenderEmailAddress}");
			}
			
			
			public virtual void FormatResult(string message) {
				string resultMessage = string.Format("{{\"key\": \"{0}\", \"message\": \"{1}\"}},", 
				SenderEmailAddress, message);
			LoadResult = string.Format("{{ \"Messages\": [{0}] }}", resultMessage);
			}
			
			public virtual void LogDebug(string message) {
				ExchangeUtility.Log.Debug(message);
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
			var cloneItem = (SyncExchangeActivitiesProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


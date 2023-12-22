﻿namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
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

	#region Class: SynchronizeCalendarWithGoogleModuleProcessSchema

	/// <exclude/>
	public class SynchronizeCalendarWithGoogleModuleProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SynchronizeCalendarWithGoogleModuleProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SynchronizeCalendarWithGoogleModuleProcessSchema(SynchronizeCalendarWithGoogleModuleProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SynchronizeCalendarWithGoogleModuleProcess";
			UId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e");
			Version = 0;
			PackageUId = new Guid("8d48ade0-350e-7694-49aa-2a913c356ce1");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridClientIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dcf4f776-1148-4f95-8b37-57a97308738d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				Name = @"ActiveTreeGridClientId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSyncResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2e93a492-ef0c-4528-9a57-48b43e23c4fa"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				Direction = ProcessSchemaParameterDirection.Out,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				Name = @"SyncResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateActiveTreeGridClientIdParameter());
			Parameters.Add(CreateSyncResultParameter());
		}

		protected virtual void InitializeAuthProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var pageInstanceIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea45e850-7cf0-4a13-90cb-1079183a6943"),
				ContainerUId = new Guid("25e2ba09-5d6e-4bc4-9fdb-679621f61f72"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"PageInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			pageInstanceIdParameter.SourceValue = new ProcessSchemaParameterValue(pageInstanceIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pageInstanceIdParameter);
			var activeTreeGridCurrentRowIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("45445f48-ec11-48c5-9217-d37dbb4203c9"),
				ContainerUId = new Guid("25e2ba09-5d6e-4bc4-9fdb-679621f61f72"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"ActiveTreeGridCurrentRowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activeTreeGridCurrentRowIdParameter.SourceValue = new ProcessSchemaParameterValue(activeTreeGridCurrentRowIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activeTreeGridCurrentRowIdParameter);
			var userTokenParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eaa698e2-f71a-421b-ae22-df0108495df2"),
				ContainerUId = new Guid("25e2ba09-5d6e-4bc4-9fdb-679621f61f72"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"UserToken",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object")
			};
			userTokenParameter.SourceValue = new ProcessSchemaParameterValue(userTokenParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(userTokenParameter);
			var activeTreeGridClientIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea625c17-d252-4983-af1d-12b3a2f38fe6"),
				ContainerUId = new Guid("25e2ba09-5d6e-4bc4-9fdb-679621f61f72"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"ActiveTreeGridClientId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			activeTreeGridClientIdParameter.SourceValue = new ProcessSchemaParameterValue(activeTreeGridClientIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activeTreeGridClientIdParameter);
			var integrationProcessIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3c151517-59b5-4801-99f7-4a25554f44b6"),
				ContainerUId = new Guid("25e2ba09-5d6e-4bc4-9fdb-679621f61f72"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"IntegrationProcessId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			integrationProcessIdParameter.SourceValue = new ProcessSchemaParameterValue(integrationProcessIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(integrationProcessIdParameter);
			var syncProcessResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a990f37c-fcaa-41f5-a2d5-9170132d0f95"),
				ContainerUId = new Guid("25e2ba09-5d6e-4bc4-9fdb-679621f61f72"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"SyncProcessResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			syncProcessResultParameter.SourceValue = new ProcessSchemaParameterValue(syncProcessResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58")
			};
			parametrizedElement.Parameters.Add(syncProcessResultParameter);
			var synchronizationAuthenticationErrorMessageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc655232-a835-49f1-83a5-e01e4340bab1"),
				ContainerUId = new Guid("25e2ba09-5d6e-4bc4-9fdb-679621f61f72"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("74528743-3768-4ea1-98c1-af5d8111ed6d"),
				CreatedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				Name = @"SynchronizationAuthenticationErrorMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			synchronizationAuthenticationErrorMessageParameter.SourceValue = new ProcessSchemaParameterValue(synchronizationAuthenticationErrorMessageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58")
			};
			parametrizedElement.Parameters.Add(synchronizationAuthenticationErrorMessageParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaSubProcess authprocess = CreateAuthProcessSubProcess();
			FlowElements.Add(authprocess);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			FlowElements.Add(end1);
			ProcessSchemaScriptTask scriptprepare = CreateScriptPrepareScriptTask();
			FlowElements.Add(scriptprepare);
			ProcessSchemaScriptTask getsyncresultsripttask = CreateGetSyncResultSriptTaskScriptTask();
			FlowElements.Add(getsyncresultsripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("7bd40693-09e2-4883-81b8-712184ccc186"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("43347c3c-1d52-4c68-98e2-81ddc204d7fb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("63a0bf6f-d35c-419f-aadd-7e71d3606fca"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("c41d3a6f-ddc5-42aa-bedc-e2f0e1d73620"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63a0bf6f-d35c-419f-aadd-7e71d3606fca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("25e2ba09-5d6e-4bc4-9fdb-679621f61f72"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("6fcc8684-246b-496e-9a91-d1c9165845ae"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("25e2ba09-5d6e-4bc4-9fdb-679621f61f72"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("920a1eba-a17a-4e22-9728-4a5556760a88"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("a5ebe2e2-720a-4ed7-9cf6-1375a3ad3c7f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("920a1eba-a17a-4e22-9728-4a5556760a88"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("14b6f758-aab5-48f5-b595-b97160af1b92"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9eeeb1e9-1bc6-4db9-ad2b-0367db3bd5c4"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(671, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("3ccf2a35-ae92-49b2-9dd6-cd0630fd4f2c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("9eeeb1e9-1bc6-4db9-ad2b-0367db3bd5c4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(642, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("43347c3c-1d52-4c68-98e2-81ddc204d7fb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ccf2a35-ae92-49b2-9dd6-cd0630fd4f2c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("14b6f758-aab5-48f5-b595-b97160af1b92"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ccf2a35-ae92-49b2-9dd6-cd0630fd4f2c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				Name = @"End1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPrepareScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("63a0bf6f-d35c-419f-aadd-7e71d3606fca"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ccf2a35-ae92-49b2-9dd6-cd0630fd4f2c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				Name = @"ScriptPrepare",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(183, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,201,110,219,48,16,61,59,64,254,129,229,137,58,72,16,19,171,177,106,228,224,216,110,160,75,17,196,46,122,201,133,33,71,137,80,153,108,135,164,219,32,200,191,119,180,180,130,209,162,128,150,225,155,121,111,54,30,21,50,29,17,193,134,207,30,176,50,236,154,117,198,218,89,11,58,52,206,102,235,201,157,85,102,121,126,118,36,142,135,150,220,20,108,225,7,219,245,7,113,202,75,178,243,179,217,218,181,241,96,5,175,12,63,57,175,180,6,239,247,238,43,216,193,241,17,221,65,240,157,211,141,106,201,233,162,13,131,227,203,51,32,8,62,20,71,80,229,183,223,163,106,197,160,148,221,41,84,7,8,128,226,164,139,164,231,174,172,17,124,255,242,13,254,207,236,90,184,141,13,197,66,13,133,185,82,23,105,81,95,46,82,144,82,166,139,66,66,154,231,178,40,76,62,215,185,36,165,36,97,202,143,77,211,56,162,111,236,19,19,155,155,237,79,208,49,56,100,230,241,143,249,215,52,183,214,71,132,205,205,4,9,210,123,165,106,71,157,106,163,130,186,7,101,128,132,38,243,122,28,121,54,72,195,0,139,41,213,168,50,107,106,38,222,77,196,172,251,253,78,49,155,237,94,172,190,7,31,219,110,119,252,245,129,123,8,129,242,250,79,46,236,32,60,240,15,44,96,132,55,190,236,195,17,66,68,203,106,213,122,232,145,55,250,208,75,207,42,134,231,59,116,221,30,179,21,53,114,132,61,2,220,98,99,214,109,67,139,232,175,210,191,29,203,83,118,101,3,60,161,234,102,49,66,61,119,90,75,14,26,234,26,222,167,23,87,101,145,206,47,203,58,125,44,101,145,74,185,40,22,121,57,39,180,228,9,169,142,229,118,29,44,127,1,117,211,21,59,218,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaSubProcess CreateAuthProcessSubProcess() {
			ProcessSchemaSubProcess schemaAuthProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("25e2ba09-5d6e-4bc4-9fdb-679621f61f72"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ccf2a35-ae92-49b2-9dd6-cd0630fd4f2c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				Name = @"AuthProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(337, 177),
				SchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeAuthProcessParameters(schemaAuthProcess);
			return schemaAuthProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateGetSyncResultSriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("920a1eba-a17a-4e22-9728-4a5556760a88"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ccf2a35-ae92-49b2-9dd6-cd0630fd4f2c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"),
				Name = @"GetSyncResultSriptTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(470, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,11,174,204,75,14,74,45,46,205,41,81,176,85,112,44,45,201,8,40,202,79,78,45,46,214,11,6,74,64,217,16,121,107,94,174,162,212,146,210,162,60,133,146,162,210,84,107,0,203,226,29,171,57,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3264dcff-36fe-4fa8-96f2-78390b4abbe9"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SynchronizeCalendarWithGoogleModuleProcess(userConnection);
		}

		public override object Clone() {
			return new SynchronizeCalendarWithGoogleModuleProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e"));
		}

		#endregion

	}

	#endregion

	#region Class: SynchronizeCalendarWithGoogleModuleProcess

	/// <exclude/>
	public class SynchronizeCalendarWithGoogleModuleProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SynchronizeCalendarWithGoogleModuleProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: AuthProcessFlowElement

		/// <exclude/>
		public class AuthProcessFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public AuthProcessFlowElement(UserConnection userConnection, SynchronizeCalendarWithGoogleModuleProcess process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("3d5ca9a9-8a90-433c-8e51-fab6c0c2cc58");
			}

			#endregion

			#region Properties: Public

			public string PageInstanceId {
				get {
					return GetParameterValue<string>("PageInstanceId");
				}
				set {
					SetParameterValue("PageInstanceId", value);
				}
			}

			public Guid ActiveTreeGridCurrentRowId {
				get {
					return GetParameterValue<Guid>("ActiveTreeGridCurrentRowId");
				}
				set {
					SetParameterValue("ActiveTreeGridCurrentRowId", value);
				}
			}

			public Object UserToken {
				get {
					return GetParameterValue<Object>("UserToken");
				}
				set {
					SetParameterValue("UserToken", value);
				}
			}

			public string ActiveTreeGridClientId {
				get {
					return GetParameterValue<string>("ActiveTreeGridClientId");
				}
				set {
					SetParameterValue("ActiveTreeGridClientId", value);
				}
			}

			public Guid IntegrationProcessId {
				get {
					return GetParameterValue<Guid>("IntegrationProcessId");
				}
				set {
					SetParameterValue("IntegrationProcessId", value);
				}
			}

			public string SyncProcessResult {
				get {
					return GetParameterValue<string>("SyncProcessResult");
				}
				set {
					SetParameterValue("SyncProcessResult", value);
				}
			}

			public LocalizableString SynchronizationAuthenticationErrorMessage {
				get {
					return GetParameterValue<LocalizableString>("SynchronizationAuthenticationErrorMessage");
				}
				set {
					SetParameterValue("SynchronizationAuthenticationErrorMessage", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (SynchronizeCalendarWithGoogleModuleProcess)owner;
				Name = "AuthProcess";
				SerializeToDB = true;
				IsLogging = false;
				SchemaElementUId = new Guid("25e2ba09-5d6e-4bc4-9fdb-679621f61f72");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (SynchronizeCalendarWithGoogleModuleProcess)Owner;
			}

			#endregion

		}

		#endregion

		public SynchronizeCalendarWithGoogleModuleProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SynchronizeCalendarWithGoogleModuleProcess";
			SchemaUId = new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7ab7486b-20f8-4f28-a3d3-2d68a95a583e");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SynchronizeCalendarWithGoogleModuleProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SynchronizeCalendarWithGoogleModuleProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual string ActiveTreeGridClientId {
			get;
			set;
		}

		public virtual string SyncResult {
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
					SchemaElementUId = new Guid("43347c3c-1d52-4c68-98e2-81ddc204d7fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessEndEvent _end1;
		public ProcessEndEvent End1 {
			get {
				return _end1 ?? (_end1 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End1",
					SchemaElementUId = new Guid("14b6f758-aab5-48f5-b595-b97160af1b92"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPrepare;
		public ProcessScriptTask ScriptPrepare {
			get {
				return _scriptPrepare ?? (_scriptPrepare = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPrepare",
					SchemaElementUId = new Guid("63a0bf6f-d35c-419f-aadd-7e71d3606fca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = ScriptPrepareExecute,
				});
			}
		}

		private AuthProcessFlowElement _authProcess;
		public AuthProcessFlowElement AuthProcess {
			get {
				return _authProcess ?? ((_authProcess) = new AuthProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _getSyncResultSriptTask;
		public ProcessScriptTask GetSyncResultSriptTask {
			get {
				return _getSyncResultSriptTask ?? (_getSyncResultSriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "GetSyncResultSriptTask",
					SchemaElementUId = new Guid("920a1eba-a17a-4e22-9728-4a5556760a88"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = GetSyncResultSriptTaskExecute,
				});
			}
		}

		private ProcessToken _scriptPrepareAuthProcessToken;
		public ProcessToken ScriptPrepareAuthProcessToken {
			get {
				return _scriptPrepareAuthProcessToken ?? (_scriptPrepareAuthProcessToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "ScriptPrepareAuthProcessToken",
					SchemaElementUId = new Guid("68440adc-6859-4f71-8791-57a77233e313"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[ScriptPrepare.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPrepare };
			FlowElements[AuthProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AuthProcess };
			FlowElements[GetSyncResultSriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GetSyncResultSriptTask };
			FlowElements[ScriptPrepareAuthProcessToken.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPrepareAuthProcessToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptPrepare", e.Context.SenderName));
						break;
					case "End1":
						CompleteProcess();
						break;
					case "ScriptPrepare":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptPrepareAuthProcessToken", e.Context.SenderName));
						break;
					case "AuthProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("GetSyncResultSriptTask", e.Context.SenderName));
						break;
					case "GetSyncResultSriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
					case "ScriptPrepareAuthProcessToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AuthProcess", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("ActiveTreeGridClientId")) {
				writer.WriteValue("ActiveTreeGridClientId", ActiveTreeGridClientId, null);
			}
			if (!HasMapping("SyncResult")) {
				writer.WriteValue("SyncResult", SyncResult, null);
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
			MetaPathParameterValues.Add("dcf4f776-1148-4f95-8b37-57a97308738d", () => ActiveTreeGridClientId);
			MetaPathParameterValues.Add("2e93a492-ef0c-4528-9a57-48b43e23c4fa", () => SyncResult);
			MetaPathParameterValues.Add("ea45e850-7cf0-4a13-90cb-1079183a6943", () => AuthProcess.PageInstanceId);
			MetaPathParameterValues.Add("45445f48-ec11-48c5-9217-d37dbb4203c9", () => AuthProcess.ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("eaa698e2-f71a-421b-ae22-df0108495df2", () => AuthProcess.UserToken);
			MetaPathParameterValues.Add("ea625c17-d252-4983-af1d-12b3a2f38fe6", () => AuthProcess.ActiveTreeGridClientId);
			MetaPathParameterValues.Add("3c151517-59b5-4801-99f7-4a25554f44b6", () => AuthProcess.IntegrationProcessId);
			MetaPathParameterValues.Add("a990f37c-fcaa-41f5-a2d5-9170132d0f95", () => AuthProcess.SyncProcessResult);
			MetaPathParameterValues.Add("fc655232-a835-49f1-83a5-e01e4340bab1", () => AuthProcess.SynchronizationAuthenticationErrorMessage);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "ActiveTreeGridClientId":
					if (!hasValueToRead) break;
					ActiveTreeGridClientId = reader.GetValue<System.String>();
				break;
				case "SyncResult":
					if (!hasValueToRead) break;
					SyncResult = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptPrepareExecute(ProcessExecutingContext context) {
			var currentUserId = UserConnection.CurrentUser.Id;
			var select = new Select(UserConnection).
				Column("Id").
				Column("AccessToken").
				From("SocialAccount").
				Where("UserId").IsEqual(Column.Parameter(currentUserId)).
				And("TypeId").IsEqual(Column.Parameter(new Guid("efe5d7a2-5f38-e111-851e-00155d04c01d"))) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = select.ExecuteReader(dbExecutor)) {
					if (!dataReader.Read()) {
						SyncResult = "{\"settingsNotSet\": true}";
						return false;
					}
				}
			}
			AuthProcess.ActiveTreeGridClientId = ActiveTreeGridClientId;
			AuthProcess.IntegrationProcessId = new Guid("0eceffe6-2795-439f-b915-118580947959");
			return true;
		}

		public virtual bool GetSyncResultSriptTaskExecute(ProcessExecutingContext context) {
			SyncResult = AuthProcess.SyncProcessResult;
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
			var cloneItem = (SynchronizeCalendarWithGoogleModuleProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


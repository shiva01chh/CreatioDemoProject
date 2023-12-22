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

	#region Class: FindInSocialNetworksByAccountProcessSchema

	/// <exclude/>
	public class FindInSocialNetworksByAccountProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public FindInSocialNetworksByAccountProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public FindInSocialNetworksByAccountProcessSchema(FindInSocialNetworksByAccountProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "FindInSocialNetworksByAccountProcess";
			UId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
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
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39");
			Version = 0;
			PackageUId = new Guid("06d9ef10-51d8-122c-8933-9212e84236c9");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreatePageInstanceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("099d5adc-1343-4553-a92e-9b46e8bb3036"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				Name = @"PageInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridCurrentRowIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6abd3803-407c-43b9-97c2-ec165465bff9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				Name = @"ActiveTreeGridCurrentRowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePageInstanceIdParameter());
			Parameters.Add(CreateActiveTreeGridCurrentRowIdParameter());
		}

		protected virtual void InitializeFindInNetworksSubProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var pageInstanceIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bf0d0387-cf73-430e-8329-8fb6ae1cce4c"),
				ContainerUId = new Guid("f1404d13-11b2-43d2-9b8b-78db5d214f45"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
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
				UId = new Guid("76b3869d-06cf-4340-97cd-f9fbdcb8135c"),
				ContainerUId = new Guid("f1404d13-11b2-43d2-9b8b-78db5d214f45"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
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
			var socialUsersKeyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0ad1593b-29da-459a-ab8a-93226df39803"),
				ContainerUId = new Guid("f1404d13-11b2-43d2-9b8b-78db5d214f45"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Name = @"SocialUsersKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			socialUsersKeyParameter.SourceValue = new ProcessSchemaParameterValue(socialUsersKeyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1")
			};
			parametrizedElement.Parameters.Add(socialUsersKeyParameter);
			var socialNetworksParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e0ee186b-0b7b-4ef2-800a-531c827cb49a"),
				ContainerUId = new Guid("f1404d13-11b2-43d2-9b8b-78db5d214f45"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Name = @"SocialNetworks",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			socialNetworksParameter.SourceValue = new ProcessSchemaParameterValue(socialNetworksParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1")
			};
			parametrizedElement.Parameters.Add(socialNetworksParameter);
			var searchCriteriaParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("204c12e4-cb5b-466d-bc63-c683bfe58ecf"),
				ContainerUId = new Guid("f1404d13-11b2-43d2-9b8b-78db5d214f45"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Name = @"SearchCriteria",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			searchCriteriaParameter.SourceValue = new ProcessSchemaParameterValue(searchCriteriaParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1")
			};
			parametrizedElement.Parameters.Add(searchCriteriaParameter);
			var matchesFoundPageUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2cd4a555-2adc-4835-b467-ee3ae4e976fc"),
				ContainerUId = new Guid("f1404d13-11b2-43d2-9b8b-78db5d214f45"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Name = @"MatchesFoundPageUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			matchesFoundPageUIdParameter.SourceValue = new ProcessSchemaParameterValue(matchesFoundPageUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1")
			};
			parametrizedElement.Parameters.Add(matchesFoundPageUIdParameter);
			var heightParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("59123d9a-2d50-4f3b-a962-c45c985d603d"),
				ContainerUId = new Guid("f1404d13-11b2-43d2-9b8b-78db5d214f45"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Name = @"Height",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			heightParameter.SourceValue = new ProcessSchemaParameterValue(heightParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"350",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39")
			};
			parametrizedElement.Parameters.Add(heightParameter);
			var widthParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1fe48b59-0df0-4f74-86b8-8fad6f22b2a3"),
				ContainerUId = new Guid("f1404d13-11b2-43d2-9b8b-78db5d214f45"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				Name = @"Width",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			widthParameter.SourceValue = new ProcessSchemaParameterValue(widthParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"550",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39")
			};
			parametrizedElement.Parameters.Add(widthParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet39 = CreateLaneSet39LaneSet();
			LaneSets.Add(schemaLaneSet39);
			ProcessSchemaLane schemaLane113 = CreateLane113Lane();
			schemaLaneSet39.Lanes.Add(schemaLane113);
			ProcessSchemaSubProcess findinnetworkssubprocess = CreateFindInNetworksSubProcessSubProcess();
			FlowElements.Add(findinnetworkssubprocess);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			FlowElements.Add(end1);
			ProcessSchemaScriptTask initilizesubprocessscripttask = CreateInitilizeSubProcessScriptTaskScriptTask();
			FlowElements.Add(initilizesubprocessscripttask);
			FlowElements.Add(CreateSequenceFlow379SequenceFlow());
			FlowElements.Add(CreateSequenceFlow380SequenceFlow());
			FlowElements.Add(CreateSequenceFlow381SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow379SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow379",
				UId = new Guid("8d7da2b9-f594-4840-aafa-91d36a9ba950"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				CurveCenterPosition = new Point(373, 199),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f1404d13-11b2-43d2-9b8b-78db5d214f45"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1c7cf198-b6fe-4aee-baa8-c7012d5772a0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow380SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow380",
				UId = new Guid("63578aea-5a42-4418-8d0d-13baa81f1992"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				CurveCenterPosition = new Point(373, 199),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("62816f0b-c35c-4e48-a126-062997ed7d7a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9380c078-182a-40b1-8681-217fd890bea9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow381SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow381",
				UId = new Guid("8f950c4d-b008-4bbf-8ddf-aff2c3a7248c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				CurveCenterPosition = new Point(297, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9380c078-182a-40b1-8681-217fd890bea9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f1404d13-11b2-43d2-9b8b-78db5d214f45"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet39LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet39 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("49bfd817-2135-4282-9fc9-6279347c624c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				Name = @"LaneSet39",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet39;
		}

		protected virtual ProcessSchemaLane CreateLane113Lane() {
			ProcessSchemaLane schemaLane113 = new ProcessSchemaLane(this) {
				UId = new Guid("83efd5cd-8dce-4a5f-ab16-b35a19a5df7e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("49bfd817-2135-4282-9fc9-6279347c624c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				Name = @"Lane113",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane113;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("62816f0b-c35c-4e48-a126-062997ed7d7a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83efd5cd-8dce-4a5f-ab16-b35a19a5df7e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				Name = @"Start1",
				Position = new Point(50, 177),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("1c7cf198-b6fe-4aee-baa8-c7012d5772a0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83efd5cd-8dce-4a5f-ab16-b35a19a5df7e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				Name = @"End1",
				Position = new Point(603, 177),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitilizeSubProcessScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9380c078-182a-40b1-8681-217fd890bea9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83efd5cd-8dce-4a5f-ab16-b35a19a5df7e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				Name = @"InitilizeSubProcessScriptTask",
				Position = new Point(141, 163),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,81,107,194,48,16,126,94,127,69,214,167,22,108,113,82,166,82,246,32,101,74,97,138,91,245,7,196,228,212,96,77,216,37,177,200,240,191,47,109,21,38,206,193,94,114,112,247,221,125,223,119,185,177,144,60,151,51,48,149,194,157,46,236,106,142,138,129,214,241,148,26,182,5,61,86,86,242,57,221,192,50,231,228,133,72,168,200,196,10,30,248,207,189,65,119,213,125,130,168,142,81,194,56,143,86,195,164,31,13,18,232,115,78,123,9,29,14,252,48,245,198,247,8,10,197,4,45,47,5,55,219,127,19,114,7,14,236,255,209,85,75,201,165,54,84,50,104,20,93,39,82,239,64,145,128,52,194,28,11,167,127,79,167,84,58,4,58,228,82,3,102,74,74,96,70,40,25,191,222,130,82,239,103,242,221,2,30,201,103,243,182,206,111,170,193,47,76,29,226,143,24,115,107,51,181,253,166,61,30,113,158,169,210,238,101,224,207,232,30,234,66,173,147,182,56,55,189,133,77,192,180,20,193,181,214,14,25,185,120,128,5,2,76,80,240,204,34,58,230,15,85,229,60,36,84,147,5,32,82,173,214,38,118,77,107,177,177,72,27,143,103,33,169,39,214,36,184,176,61,58,51,182,44,67,242,229,61,220,255,29,160,200,182,25,10,3,40,168,83,120,238,142,107,253,169,119,34,80,106,248,223,132,250,110,226,25,84,205,253,132,241,66,21,6,133,220,4,110,25,39,15,193,88,148,196,160,133,244,27,209,121,137,161,148,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaSubProcess CreateFindInNetworksSubProcessSubProcess() {
			ProcessSchemaSubProcess schemaFindInNetworksSubProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("f1404d13-11b2-43d2-9b8b-78db5d214f45"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83efd5cd-8dce-4a5f-ab16-b35a19a5df7e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"),
				Name = @"FindInNetworksSubProcess",
				Position = new Point(295, 163),
				SchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1"),
				SerializeToDB = false,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeFindInNetworksSubProcessParameters(schemaFindInNetworksSubProcess);
			return schemaFindInNetworksSubProcess;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b27361e5-957f-4eea-98ce-67bce63c6fd7"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f571ae44-15c5-4cff-8784-3fb11004d6d3"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new FindInSocialNetworksByAccountProcess(userConnection);
		}

		public override object Clone() {
			return new FindInSocialNetworksByAccountProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39"));
		}

		#endregion

	}

	#endregion

	#region Class: FindInSocialNetworksByAccountProcess

	/// <exclude/>
	public class FindInSocialNetworksByAccountProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane113

		/// <exclude/>
		public class ProcessLane113 : ProcessLane
		{

			public ProcessLane113(UserConnection userConnection, FindInSocialNetworksByAccountProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: FindInNetworksSubProcessFlowElement

		/// <exclude/>
		public class FindInNetworksSubProcessFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public FindInNetworksSubProcessFlowElement(UserConnection userConnection, FindInSocialNetworksByAccountProcess process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("d389027a-6008-40cd-b17b-623d1d1344c1");
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

			public string SocialUsersKey {
				get {
					return GetParameterValue<string>("SocialUsersKey");
				}
				set {
					SetParameterValue("SocialUsersKey", value);
				}
			}

			public string SocialNetworks {
				get {
					return GetParameterValue<string>("SocialNetworks");
				}
				set {
					SetParameterValue("SocialNetworks", value);
				}
			}

			public string SearchCriteria {
				get {
					return GetParameterValue<string>("SearchCriteria");
				}
				set {
					SetParameterValue("SearchCriteria", value);
				}
			}

			public Guid MatchesFoundPageUId {
				get {
					return GetParameterValue<Guid>("MatchesFoundPageUId");
				}
				set {
					SetParameterValue("MatchesFoundPageUId", value);
				}
			}

			public int Height {
				get {
					return GetParameterValue<int>("Height");
				}
				set {
					SetParameterValue("Height", value);
				}
			}

			public int Width {
				get {
					return GetParameterValue<int>("Width");
				}
				set {
					SetParameterValue("Width", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (FindInSocialNetworksByAccountProcess)owner;
				Name = "FindInNetworksSubProcess";
				SerializeToDB = false;
				IsLogging = true;
				SchemaElementUId = new Guid("f1404d13-11b2-43d2-9b8b-78db5d214f45");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane113;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (FindInSocialNetworksByAccountProcess)Owner;
				SetParameterValue("Height", (int)(350));
				SetParameterValue("Width", (int)(550));
			}

			#endregion

		}

		#endregion

		public FindInSocialNetworksByAccountProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FindInSocialNetworksByAccountProcess";
			SchemaUId = new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("13b605c0-b8f2-4498-9911-6d957cc37c39");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: FindInSocialNetworksByAccountProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: FindInSocialNetworksByAccountProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual string PageInstanceId {
			get;
			set;
		}

		public virtual Guid ActiveTreeGridCurrentRowId {
			get;
			set;
		}

		private ProcessLane113 _lane113;
		public ProcessLane113 Lane113 {
			get {
				return _lane113 ?? ((_lane113) = new ProcessLane113(UserConnection, this));
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
					SchemaElementUId = new Guid("62816f0b-c35c-4e48-a126-062997ed7d7a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("1c7cf198-b6fe-4aee-baa8-c7012d5772a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _initilizeSubProcessScriptTask;
		public ProcessScriptTask InitilizeSubProcessScriptTask {
			get {
				return _initilizeSubProcessScriptTask ?? (_initilizeSubProcessScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitilizeSubProcessScriptTask",
					SchemaElementUId = new Guid("9380c078-182a-40b1-8681-217fd890bea9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = InitilizeSubProcessScriptTaskExecute,
				});
			}
		}

		private FindInNetworksSubProcessFlowElement _findInNetworksSubProcess;
		public FindInNetworksSubProcessFlowElement FindInNetworksSubProcess {
			get {
				return _findInNetworksSubProcess ?? ((_findInNetworksSubProcess) = new FindInNetworksSubProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessToken _initilizeSubProcessScriptTaskFindInNetworksSubProcessToken;
		public ProcessToken InitilizeSubProcessScriptTaskFindInNetworksSubProcessToken {
			get {
				return _initilizeSubProcessScriptTaskFindInNetworksSubProcessToken ?? (_initilizeSubProcessScriptTaskFindInNetworksSubProcessToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "InitilizeSubProcessScriptTaskFindInNetworksSubProcessToken",
					SchemaElementUId = new Guid("3f798cd6-fef7-424c-a043-4b2908dd5b03"),
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
			FlowElements[InitilizeSubProcessScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitilizeSubProcessScriptTask };
			FlowElements[FindInNetworksSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { FindInNetworksSubProcess };
			FlowElements[InitilizeSubProcessScriptTaskFindInNetworksSubProcessToken.SchemaElementUId] = new Collection<ProcessFlowElement> { InitilizeSubProcessScriptTaskFindInNetworksSubProcessToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InitilizeSubProcessScriptTask", e.Context.SenderName));
						break;
					case "End1":
						CompleteProcess();
						break;
					case "InitilizeSubProcessScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InitilizeSubProcessScriptTaskFindInNetworksSubProcessToken", e.Context.SenderName));
						break;
					case "FindInNetworksSubProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
					case "InitilizeSubProcessScriptTaskFindInNetworksSubProcessToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FindInNetworksSubProcess", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("PageInstanceId")) {
				writer.WriteValue("PageInstanceId", PageInstanceId, null);
			}
			if (!HasMapping("ActiveTreeGridCurrentRowId")) {
				writer.WriteValue("ActiveTreeGridCurrentRowId", ActiveTreeGridCurrentRowId, Guid.Empty);
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
			MetaPathParameterValues.Add("099d5adc-1343-4553-a92e-9b46e8bb3036", () => PageInstanceId);
			MetaPathParameterValues.Add("6abd3803-407c-43b9-97c2-ec165465bff9", () => ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("bf0d0387-cf73-430e-8329-8fb6ae1cce4c", () => FindInNetworksSubProcess.PageInstanceId);
			MetaPathParameterValues.Add("76b3869d-06cf-4340-97cd-f9fbdcb8135c", () => FindInNetworksSubProcess.ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("0ad1593b-29da-459a-ab8a-93226df39803", () => FindInNetworksSubProcess.SocialUsersKey);
			MetaPathParameterValues.Add("e0ee186b-0b7b-4ef2-800a-531c827cb49a", () => FindInNetworksSubProcess.SocialNetworks);
			MetaPathParameterValues.Add("204c12e4-cb5b-466d-bc63-c683bfe58ecf", () => FindInNetworksSubProcess.SearchCriteria);
			MetaPathParameterValues.Add("2cd4a555-2adc-4835-b467-ee3ae4e976fc", () => FindInNetworksSubProcess.MatchesFoundPageUId);
			MetaPathParameterValues.Add("59123d9a-2d50-4f3b-a962-c45c985d603d", () => FindInNetworksSubProcess.Height);
			MetaPathParameterValues.Add("1fe48b59-0df0-4f74-86b8-8fad6f22b2a3", () => FindInNetworksSubProcess.Width);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "PageInstanceId":
					if (!hasValueToRead) break;
					PageInstanceId = reader.GetValue<System.String>();
				break;
				case "ActiveTreeGridCurrentRowId":
					if (!hasValueToRead) break;
					ActiveTreeGridCurrentRowId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool InitilizeSubProcessScriptTaskExecute(ProcessExecutingContext context) {
			FindInNetworksSubProcess.MatchesFoundPageUId = new Guid("6280b01e-280b-4cdd-b947-84e7dda24a98");
			FindInNetworksSubProcess.SocialNetworks = "LinkedIn";
			FindInNetworksSubProcess.PageInstanceId = PageInstanceId;
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			EntitySchemaQuery query = new EntitySchemaQuery(entitySchemaManager, "Account");
			query.AddColumn("Name");
			var account = query.GetEntity(UserConnection, ActiveTreeGridCurrentRowId) as Terrasoft.Configuration.Account;
			if (account != null) {
				FindInNetworksSubProcess.SearchCriteria = account.Name;
			} else {
				FindInNetworksSubProcess.SearchCriteria = Guid.NewGuid().ToString();
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
			var cloneItem = (FindInSocialNetworksByAccountProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


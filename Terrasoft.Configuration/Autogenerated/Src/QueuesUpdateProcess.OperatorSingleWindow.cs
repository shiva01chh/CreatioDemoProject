namespace Terrasoft.Core.Process
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
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Nui.ServiceModel.Extensions;

	#region Class: QueuesUpdateProcessSchema

	/// <exclude/>
	public class QueuesUpdateProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public QueuesUpdateProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public QueuesUpdateProcessSchema(QueuesUpdateProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QueuesUpdateProcess";
			UId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d");
			CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7");
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
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,87,77,111,219,56,16,61,59,64,254,3,235,147,4,4,66,209,107,55,11,100,19,187,245,162,113,118,235,102,123,102,165,113,76,68,38,29,146,114,226,93,228,191,239,240,67,150,68,81,110,156,2,45,18,36,18,57,51,156,153,247,248,72,157,158,108,170,111,37,203,201,150,73,93,209,146,108,5,43,200,148,149,229,223,21,84,128,15,26,36,20,51,13,107,149,220,42,144,151,130,115,200,53,19,156,84,157,215,51,242,161,66,215,106,83,80,13,11,80,10,199,102,133,31,125,48,193,204,155,210,146,241,59,247,62,167,107,216,143,44,237,74,87,84,211,148,252,119,122,50,90,64,137,113,9,205,77,86,54,151,9,215,76,51,80,126,230,156,160,213,7,208,23,67,22,73,152,95,47,181,125,86,173,116,90,121,188,63,61,97,75,146,28,72,225,156,240,170,44,93,194,18,116,37,57,250,60,159,158,108,169,36,140,227,242,186,182,68,3,14,143,100,214,26,12,242,75,209,36,155,113,45,146,113,175,245,99,51,57,202,22,160,147,177,205,97,247,25,114,33,139,89,49,62,35,206,220,61,222,118,75,180,126,217,84,138,181,95,114,176,22,83,172,150,59,91,73,59,243,108,242,4,121,165,33,49,6,207,36,167,58,95,145,100,242,148,195,198,114,0,92,241,54,162,186,213,172,180,49,179,79,226,110,34,165,144,137,67,55,155,10,185,166,58,153,241,173,184,135,107,208,43,81,216,249,107,204,148,222,193,153,41,111,28,103,29,150,5,153,183,75,241,217,36,50,210,43,41,30,93,175,241,215,252,196,104,124,133,37,104,152,139,54,71,94,192,100,87,146,193,208,181,235,31,90,86,13,230,30,201,65,12,71,217,165,40,171,53,247,48,154,245,222,25,104,218,104,180,230,198,105,118,161,58,182,214,234,79,193,120,98,254,124,217,109,0,105,193,65,214,72,71,136,113,195,99,164,65,135,128,44,105,54,83,147,7,44,41,76,46,180,179,81,47,120,49,16,182,102,220,96,188,189,129,169,229,235,10,125,7,34,245,8,187,143,104,154,140,46,114,247,23,149,184,51,209,43,233,89,159,145,96,36,53,11,82,229,209,65,130,244,17,204,22,27,200,217,114,55,23,159,68,126,255,145,113,173,44,185,13,222,133,37,204,30,99,199,159,216,62,237,129,248,29,204,66,156,106,66,68,250,119,176,125,181,129,245,69,98,39,24,129,39,253,34,91,0,222,108,64,82,45,164,95,110,142,130,149,52,211,41,110,112,166,176,5,135,57,29,144,186,197,231,81,167,25,245,80,44,231,33,210,116,131,53,164,179,227,234,154,114,52,45,119,70,28,80,73,14,19,100,73,75,5,150,3,13,9,60,35,28,150,45,149,115,3,69,35,10,151,162,226,230,88,113,36,248,153,194,55,168,83,63,160,125,238,164,153,195,227,241,170,215,61,185,200,241,71,215,81,71,214,66,83,93,169,200,89,245,66,149,141,74,87,87,130,131,81,247,15,223,184,210,73,187,67,117,42,142,65,109,94,71,52,247,117,170,214,89,59,38,94,245,182,116,155,251,53,155,179,173,17,189,13,218,20,112,80,175,154,110,96,238,55,97,228,6,178,136,126,121,183,78,2,199,200,193,224,89,19,234,195,11,207,184,239,29,137,177,176,173,26,212,148,113,90,58,233,20,58,2,162,150,213,128,228,244,111,86,23,69,17,83,156,95,117,225,138,104,196,235,20,199,107,197,193,219,248,207,252,120,112,152,43,63,174,176,197,11,144,91,150,3,2,155,223,127,129,39,253,17,74,60,23,179,43,192,52,24,45,217,191,240,155,119,250,61,233,126,2,248,37,164,16,122,145,175,96,77,205,202,24,209,199,206,62,119,38,252,55,131,71,193,29,183,55,114,178,222,232,93,210,13,145,14,2,249,149,74,30,224,104,3,184,4,155,245,106,44,155,134,164,22,46,247,37,98,63,77,28,104,51,199,121,231,101,143,76,23,202,32,78,64,61,76,247,109,170,139,250,163,98,101,49,169,103,130,204,241,214,213,21,33,127,123,122,104,34,227,14,41,61,208,231,237,21,112,87,12,228,210,120,248,104,232,133,190,70,249,122,30,1,151,178,182,1,222,23,176,39,40,100,65,183,49,42,70,204,112,7,214,98,105,54,191,135,43,158,249,155,246,231,221,160,89,230,119,241,57,121,235,44,143,135,84,13,33,25,64,57,66,44,71,166,10,239,102,34,179,156,150,238,138,231,154,29,207,49,52,124,31,4,178,226,54,232,109,103,141,203,82,72,160,70,143,14,50,202,145,8,85,45,30,206,119,169,189,60,162,226,119,93,234,203,124,38,128,87,57,107,25,26,54,116,74,29,189,189,250,168,250,194,98,28,80,138,220,176,35,76,213,35,236,222,218,61,152,187,71,236,122,224,181,199,10,124,212,160,10,207,240,125,236,161,15,13,143,169,170,63,81,172,164,254,15,83,161,116,246,136,17,0,0 };
			RealUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d");
			Version = 0;
			PackageUId = new Guid("692a159e-9044-4f75-85a8-855bdb86a76d");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateUpdateSessionIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dbf48210-a598-460b-bfce-b27933ecfff8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"UpdateSessionId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewQueueItemStatusIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("168bc457-1b6d-4962-83a3-24cc0c53583d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"NewQueueItemStatusId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.a4b5e242-0a9b-413d-a7cc-0faca45c3c2c.2b341a1d-6fa1-4960-9c85-fef60d1bbcc4#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMaxQueueFilteredItemsLifeDaysParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ce429aa3-6cd8-4d38-a6b7-019286ef4823"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"MaxQueueFilteredItemsLifeDays",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"1",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateAddedQueueItemsCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f1bbdf69-8cdd-4223-b6f6-0ada6c340c29"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"AddedQueueItemsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDeletedQueueItemsCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("222b97a0-00c9-411d-897c-c035aff3a4a7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"DeletedQueueItemsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateQueuesUpdatedMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fcfa253f-171b-4c14-9460-e9fde6eb0258"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"QueuesUpdatedMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEmptyFilterRootSchemaMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("59c9124e-ef80-402a-a878-2c33e9741c0a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"EmptyFilterRootSchemaMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEmptyFiltersMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4212368e-ac01-41d1-8922-c43a0f14a0d7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"EmptyFiltersMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateInvokeMethodErrorMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("df7ac21b-eaf4-425a-af1f-8e71d75c59ec"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"InvokeMethodErrorMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateUpdateSessionIdParameter());
			Parameters.Add(CreateNewQueueItemStatusIdParameter());
			Parameters.Add(CreateMaxQueueFilteredItemsLifeDaysParameter());
			Parameters.Add(CreateAddedQueueItemsCountParameter());
			Parameters.Add(CreateDeletedQueueItemsCountParameter());
			Parameters.Add(CreateQueuesUpdatedMessageParameter());
			Parameters.Add(CreateEmptyFilterRootSchemaMessageParameter());
			Parameters.Add(CreateEmptyFiltersMessageParameter());
			Parameters.Add(CreateInvokeMethodErrorMessageParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
			ProcessSchemaTerminateEvent terminate = CreateTerminateTerminateEvent();
			FlowElements.Add(terminate);
			ProcessSchemaScriptTask actualizequeuestriggerscripttask = CreateActualizeQueuesTriggerScriptTaskScriptTask();
			FlowElements.Add(actualizequeuestriggerscripttask);
			ProcessSchemaScriptTask fillqueuefiltereditemsscripttask = CreateFillQueueFilteredItemsScriptTaskScriptTask();
			FlowElements.Add(fillqueuefiltereditemsscripttask);
			ProcessSchemaFormulaTask initupdatesessionidformulatask = CreateInitUpdateSessionIdFormulaTaskFormulaTask();
			FlowElements.Add(initupdatesessionidformulatask);
			ProcessSchemaScriptTask updatequeuesscripttask = CreateUpdateQueuesScriptTaskScriptTask();
			FlowElements.Add(updatequeuesscripttask);
			ProcessSchemaScriptTask clearqueuefiltereditemsscripttask = CreateClearQueueFilteredItemsScriptTaskScriptTask();
			FlowElements.Add(clearqueuefiltereditemsscripttask);
			ProcessSchemaScriptTask logprocessscripttask = CreateLogProcessScriptTaskScriptTask();
			FlowElements.Add(logprocessscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask callqueueupdateutilitiesscripttask = CreateCallQueueUpdateUtilitiesScriptTaskScriptTask();
			FlowElements.Add(callqueueupdateutilitiesscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("6b36a146-d851-4667-b2d4-526512106c94"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d912ed96-306e-4b1b-b6d7-184caeaeae6b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b5edc036-7bca-4292-beef-0f43b08aba2e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("32bd243b-4cbd-41fd-9810-e31ca13a2e8b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a1ff683f-f1a4-4c97-a81e-c87fa24875f8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("22081b5c-f88d-476f-8093-15fa34e94a95"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f2f85c52-77cf-4593-b935-cbb9860d4fc8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(647, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cadc3623-0358-428b-a511-59cacdb6c9e7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("935d3cdd-060a-45b0-8bdb-61c264c77e55"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("f88ea237-acee-4dff-bb1e-df35385b096b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("48d9dcca-e30a-4c81-9416-cdb5ded3e133"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a1ff683f-f1a4-4c97-a81e-c87fa24875f8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("356e34c8-8191-42e5-84b6-cf41673bce65"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("22081b5c-f88d-476f-8093-15fa34e94a95"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0885763e-54d9-4f26-ac0e-c014d0c739b0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("a4a76fc9-7769-47f1-92f0-e3c484267efc"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(677, 205),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0885763e-54d9-4f26-ac0e-c014d0c739b0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ec3120d-48d9-4a50-8a3f-ba47ab91590b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("4fbecf5d-d10f-4903-9837-491ef2fc6235"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(789, 205),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ec3120d-48d9-4a50-8a3f-ba47ab91590b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cadc3623-0358-428b-a511-59cacdb6c9e7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("aae426bd-5094-4225-a4c8-d0d840e87564"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"false",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d9aef2c0-f2be-4b4c-9a75-0e443b6a6d1f"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(204, 141),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b5edc036-7bca-4292-beef-0f43b08aba2e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("48d9dcca-e30a-4c81-9416-cdb5ded3e133"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("7816f084-7e3e-457d-9ad0-317d329b9778"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d9aef2c0-f2be-4b4c-9a75-0e443b6a6d1f"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(267, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b5edc036-7bca-4292-beef-0f43b08aba2e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("71ef494c-3926-443f-99c6-dbbf7a8384a0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("5af2f059-cf49-4938-a951-7e5680318008"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d9aef2c0-f2be-4b4c-9a75-0e443b6a6d1f"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				CurveCenterPosition = new Point(626, 127),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("71ef494c-3926-443f-99c6-dbbf7a8384a0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cadc3623-0358-428b-a511-59cacdb6c9e7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a2525006-738b-4752-a483-70687f58d2a7"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a2525006-738b-4752-a483-70687f58d2a7"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("d912ed96-306e-4b1b-b6d7-184caeaeae6b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"Start",
				Position = new Point(50, 58),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("935d3cdd-060a-45b0-8bdb-61c264c77e55"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"Terminate",
				Position = new Point(925, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActualizeQueuesTriggerScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cadc3623-0358-428b-a511-59cacdb6c9e7"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"ActualizeQueuesTriggerScriptTask",
				Position = new Point(806, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,85,141,65,10,2,49,16,4,239,130,127,200,81,47,249,192,226,201,23,8,155,7,132,181,55,12,200,68,58,61,224,243,93,241,148,99,87,65,117,25,224,189,187,99,147,117,79,49,207,91,218,186,11,31,229,50,137,229,124,90,65,214,209,119,229,3,239,214,130,245,103,242,35,16,24,69,246,50,25,70,46,239,103,21,254,116,165,181,6,94,230,151,235,81,35,20,244,36,6,150,47,43,2,178,135,147,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateFillQueueFilteredItemsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a1ff683f-f1a4-4c97-a81e-c87fa24875f8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"FillQueueFilteredItemsScriptTask",
				Position = new Point(260, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,203,110,219,48,16,60,43,64,254,129,208,137,2,4,254,128,145,67,19,203,129,138,58,125,56,110,207,172,184,177,137,208,164,67,46,99,27,69,254,189,75,81,241,171,110,15,5,12,154,228,238,204,206,114,71,243,0,254,206,89,11,29,106,103,89,60,61,222,176,206,89,132,45,138,249,73,96,116,125,245,42,61,11,96,232,76,89,215,87,133,133,13,155,245,103,126,74,82,81,176,16,119,206,196,149,229,229,215,8,17,202,154,149,173,42,255,18,121,144,43,56,139,77,180,65,240,99,137,178,15,136,137,119,171,119,68,206,252,232,180,229,105,121,220,173,65,180,84,220,19,85,159,49,67,137,49,148,149,248,124,92,37,223,38,21,162,13,205,75,148,134,159,164,31,36,138,31,75,240,240,103,52,180,86,163,150,166,103,120,112,152,73,210,59,80,166,223,125,145,158,26,33,217,28,125,132,42,203,252,96,213,5,162,137,182,255,75,147,9,166,210,18,200,236,232,157,140,182,139,163,158,46,240,60,73,19,50,145,12,195,200,104,158,49,16,144,241,241,109,179,133,46,162,243,76,253,220,111,111,216,233,252,69,99,67,244,48,190,61,92,241,170,98,191,136,19,253,174,255,47,6,194,54,77,237,27,72,5,196,152,152,178,105,68,230,134,28,225,135,90,3,77,81,108,150,218,0,227,202,139,148,195,247,247,69,114,222,75,234,189,85,68,199,239,163,86,21,101,221,3,102,187,124,151,38,210,184,210,244,70,103,136,100,173,132,9,232,73,220,37,84,54,223,17,238,105,111,189,127,3,143,45,58,192,211,52,250,33,229,24,168,22,97,21,206,62,143,154,205,215,74,34,204,32,4,58,182,170,126,111,174,62,104,174,143,100,12,236,111,105,77,203,27,235,36,118,75,198,155,109,7,235,254,179,133,225,173,250,226,97,142,218,144,81,33,136,79,110,209,120,239,252,208,134,152,56,191,146,200,91,251,234,158,97,10,184,116,170,143,79,73,139,92,64,221,23,42,47,183,49,235,188,94,227,163,12,207,100,65,16,3,164,162,125,22,136,75,239,54,105,71,26,233,231,1,163,183,44,121,120,244,27,10,43,177,67,116,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateInitUpdateSessionIdFormulaTaskFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("48d9dcca-e30a-4c81-9416-cdb5ded3e133"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"InitUpdateSessionIdFormulaTask",
				Position = new Point(134, 170),
				ResultParameterMetaPath = @"dbf48210-a598-460b-bfce-b27933ecfff8",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,139,86,14,174,44,14,75,44,202,76,76,202,73,213,115,44,45,201,119,47,205,76,81,142,5,0,88,38,247,74,24,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateQueuesScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("22081b5c-f88d-476f-8093-15fa34e94a95"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"UpdateQueuesScriptTask",
				Position = new Point(393, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,11,45,78,45,114,206,207,203,75,77,46,201,204,207,83,40,69,229,218,42,36,231,231,149,164,86,148,232,133,162,72,88,243,114,185,164,230,164,150,164,250,229,151,56,38,151,148,38,230,4,150,166,150,166,122,150,164,230,22,107,160,154,161,9,84,235,153,7,20,42,241,75,45,199,171,170,40,181,164,180,40,79,161,164,168,52,213,26,0,81,236,215,35,151,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateClearQueueFilteredItemsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0885763e-54d9-4f26-ac0e-c014d0c739b0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"ClearQueueFilteredItemsScriptTask",
				Position = new Point(519, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,203,110,194,48,16,60,131,196,63,88,57,217,18,245,15,160,30,170,16,164,72,80,90,65,212,179,21,111,137,69,98,211,245,154,135,170,254,123,215,161,167,114,243,122,30,59,59,103,131,194,66,15,4,226,89,204,166,19,15,23,177,28,103,217,68,192,50,120,15,45,185,224,21,131,122,133,97,144,197,123,130,4,43,215,19,32,216,154,96,40,70,240,163,227,89,22,205,201,26,130,29,196,200,170,218,22,74,215,177,250,74,166,151,217,155,181,120,123,51,104,6,94,129,143,236,185,248,247,163,178,247,68,111,153,91,34,48,98,183,126,244,92,51,99,139,119,231,50,244,105,240,154,211,70,146,75,38,237,221,0,186,161,246,53,92,244,139,181,75,115,139,242,105,99,174,15,209,227,218,125,66,134,149,82,139,217,148,240,38,190,121,225,189,18,93,93,161,77,92,69,134,126,68,107,168,237,132,172,174,45,156,114,37,2,212,72,30,77,99,67,174,119,228,32,234,117,56,84,136,1,101,36,116,254,160,87,1,7,67,178,246,231,112,132,13,80,23,236,136,111,248,2,115,128,121,62,176,40,123,48,248,24,111,215,162,59,209,222,196,35,87,3,250,79,162,248,157,51,77,168,195,112,201,225,102,83,4,74,232,5,97,130,197,47,20,34,252,90,214,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateLogProcessScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7ec3120d-48d9-4a50-8a3f-ba47ab91590b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"LogProcessScriptTask",
				Position = new Point(673, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,141,65,10,194,64,16,4,239,130,127,152,99,132,144,15,132,28,68,17,2,122,240,224,3,22,166,93,22,178,187,50,211,251,127,49,230,150,107,117,81,237,180,84,162,100,184,135,8,153,196,87,48,220,170,229,192,238,217,208,224,175,143,6,66,31,127,169,151,179,42,116,157,102,34,251,165,182,194,94,174,88,192,29,63,141,199,195,86,97,90,18,19,124,184,215,56,151,119,237,182,215,159,98,96,179,34,180,134,241,11,37,72,152,105,148,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("b5edc036-7bca-4292-beef-0f43b08aba2e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d9aef2c0-f2be-4b4c-9a75-0e443b6a6d1f"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"ExclusiveGateway1",
				Position = new Point(141, 44),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateCallQueueUpdateUtilitiesScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("71ef494c-3926-443f-99c6-dbbf7a8384a0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a422a28e-cda7-403c-97af-079365b00969"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d9aef2c0-f2be-4b4c-9a75-0e443b6a6d1f"),
				CreatedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"),
				Name = @"CallQueueUpdateUtilitiesScriptTask",
				Position = new Point(393, 44),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,143,177,10,194,64,16,68,107,3,249,135,37,85,2,146,31,136,10,33,162,164,211,34,149,88,28,113,144,131,228,78,247,246,34,34,254,187,39,87,9,1,187,97,103,31,188,153,20,211,221,195,195,117,183,139,18,116,162,7,45,26,142,214,212,12,202,185,157,234,197,242,179,220,67,86,199,185,199,13,229,6,143,211,153,94,105,178,8,137,26,107,156,176,255,98,53,95,253,8,35,121,230,29,56,20,6,189,104,107,178,37,117,63,135,34,77,222,69,149,38,179,42,229,129,109,15,231,106,47,54,86,81,36,255,75,108,49,64,208,154,176,65,79,145,106,5,99,36,25,226,217,80,80,69,245,1,34,167,252,111,7,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ba49f690-bdb5-4dab-804d-6395616497bf"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2040fa02-b1f4-4c39-85bd-0c29c264a9fa"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "",
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c10cdc29-996e-4079-bf44-b3e5e9f0501d"),
				Name = "Terrasoft.Nui.ServiceModel.Extensions",
				Alias = "",
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a22f9d1a-02c1-432e-aa14-06daa10c8e99"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("db7fbfe0-43e5-45c8-ae48-f28c06d2978d"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new QueuesUpdateProcess(userConnection);
		}

		public override object Clone() {
			return new QueuesUpdateProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d"));
		}

		#endregion

	}

	#endregion

	#region Class: QueuesUpdateProcess

	/// <exclude/>
	public class QueuesUpdateProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, QueuesUpdateProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public QueuesUpdateProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QueuesUpdateProcess";
			SchemaUId = new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_newQueueItemStatusId = () => { return (Guid)(new Guid("2b341a1d-6fa1-4960-9c85-fef60d1bbcc4")); };
			_maxQueueFilteredItemsLifeDays = () => { return (int)(1); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("78ffb369-bb6b-4479-a08a-32f19d02092d");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: QueuesUpdateProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: QueuesUpdateProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid UpdateSessionId {
			get;
			set;
		}

		private Func<Guid> _newQueueItemStatusId;
		public virtual Guid NewQueueItemStatusId {
			get {
				return (_newQueueItemStatusId ?? (_newQueueItemStatusId = () => Guid.Empty)).Invoke();
			}
			set {
				_newQueueItemStatusId = () => { return value; };
			}
		}

		private Func<int> _maxQueueFilteredItemsLifeDays;
		public virtual int MaxQueueFilteredItemsLifeDays {
			get {
				return (_maxQueueFilteredItemsLifeDays ?? (_maxQueueFilteredItemsLifeDays = () => 0)).Invoke();
			}
			set {
				_maxQueueFilteredItemsLifeDays = () => { return value; };
			}
		}

		public virtual int AddedQueueItemsCount {
			get;
			set;
		}

		public virtual int DeletedQueueItemsCount {
			get;
			set;
		}

		private LocalizableString _queuesUpdatedMessage;
		public virtual LocalizableString QueuesUpdatedMessage {
			get {
				return _queuesUpdatedMessage ?? (_queuesUpdatedMessage = GetLocalizableString("78ffb369bb6b4479a08a32f19d02092d",
						 "Parameters.QueuesUpdatedMessage.Value"));
			}
			set {
				_queuesUpdatedMessage = value;
			}
		}

		private LocalizableString _emptyFilterRootSchemaMessage;
		public virtual LocalizableString EmptyFilterRootSchemaMessage {
			get {
				return _emptyFilterRootSchemaMessage ?? (_emptyFilterRootSchemaMessage = GetLocalizableString("78ffb369bb6b4479a08a32f19d02092d",
						 "Parameters.EmptyFilterRootSchemaMessage.Value"));
			}
			set {
				_emptyFilterRootSchemaMessage = value;
			}
		}

		private LocalizableString _emptyFiltersMessage;
		public virtual LocalizableString EmptyFiltersMessage {
			get {
				return _emptyFiltersMessage ?? (_emptyFiltersMessage = GetLocalizableString("78ffb369bb6b4479a08a32f19d02092d",
						 "Parameters.EmptyFiltersMessage.Value"));
			}
			set {
				_emptyFiltersMessage = value;
			}
		}

		private LocalizableString _invokeMethodErrorMessage;
		public virtual LocalizableString InvokeMethodErrorMessage {
			get {
				return _invokeMethodErrorMessage ?? (_invokeMethodErrorMessage = GetLocalizableString("78ffb369bb6b4479a08a32f19d02092d",
						 "Parameters.InvokeMethodErrorMessage.Value"));
			}
			set {
				_invokeMethodErrorMessage = value;
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _start;
		public ProcessFlowElement Start {
			get {
				return _start ?? (_start = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start",
					SchemaElementUId = new Guid("d912ed96-306e-4b1b-b6d7-184caeaeae6b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _terminate;
		public ProcessTerminateEvent Terminate {
			get {
				return _terminate ?? (_terminate = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate",
					SchemaElementUId = new Guid("935d3cdd-060a-45b0-8bdb-61c264c77e55"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _actualizeQueuesTriggerScriptTask;
		public ProcessScriptTask ActualizeQueuesTriggerScriptTask {
			get {
				return _actualizeQueuesTriggerScriptTask ?? (_actualizeQueuesTriggerScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActualizeQueuesTriggerScriptTask",
					SchemaElementUId = new Guid("cadc3623-0358-428b-a511-59cacdb6c9e7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ActualizeQueuesTriggerScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _fillQueueFilteredItemsScriptTask;
		public ProcessScriptTask FillQueueFilteredItemsScriptTask {
			get {
				return _fillQueueFilteredItemsScriptTask ?? (_fillQueueFilteredItemsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FillQueueFilteredItemsScriptTask",
					SchemaElementUId = new Guid("a1ff683f-f1a4-4c97-a81e-c87fa24875f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FillQueueFilteredItemsScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _initUpdateSessionIdFormulaTask;
		public ProcessScriptTask InitUpdateSessionIdFormulaTask {
			get {
				return _initUpdateSessionIdFormulaTask ?? (_initUpdateSessionIdFormulaTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "InitUpdateSessionIdFormulaTask",
					SchemaElementUId = new Guid("48d9dcca-e30a-4c81-9416-cdb5ded3e133"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = InitUpdateSessionIdFormulaTaskExecute,
				});
			}
		}

		private ProcessScriptTask _updateQueuesScriptTask;
		public ProcessScriptTask UpdateQueuesScriptTask {
			get {
				return _updateQueuesScriptTask ?? (_updateQueuesScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateQueuesScriptTask",
					SchemaElementUId = new Guid("22081b5c-f88d-476f-8093-15fa34e94a95"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = UpdateQueuesScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _clearQueueFilteredItemsScriptTask;
		public ProcessScriptTask ClearQueueFilteredItemsScriptTask {
			get {
				return _clearQueueFilteredItemsScriptTask ?? (_clearQueueFilteredItemsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ClearQueueFilteredItemsScriptTask",
					SchemaElementUId = new Guid("0885763e-54d9-4f26-ac0e-c014d0c739b0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ClearQueueFilteredItemsScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _logProcessScriptTask;
		public ProcessScriptTask LogProcessScriptTask {
			get {
				return _logProcessScriptTask ?? (_logProcessScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LogProcessScriptTask",
					SchemaElementUId = new Guid("7ec3120d-48d9-4a50-8a3f-ba47ab91590b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = LogProcessScriptTaskExecute,
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
					SchemaElementUId = new Guid("b5edc036-7bca-4292-beef-0f43b08aba2e"),
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

		private ProcessScriptTask _callQueueUpdateUtilitiesScriptTask;
		public ProcessScriptTask CallQueueUpdateUtilitiesScriptTask {
			get {
				return _callQueueUpdateUtilitiesScriptTask ?? (_callQueueUpdateUtilitiesScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CallQueueUpdateUtilitiesScriptTask",
					SchemaElementUId = new Guid("71ef494c-3926-443f-99c6-dbbf7a8384a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CallQueueUpdateUtilitiesScriptTaskExecute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("aae426bd-5094-4225-a4c8-d0d840e87564"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow2;
		public ProcessConditionalFlow ConditionalFlow2 {
			get {
				return _conditionalFlow2 ?? (_conditionalFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow2",
					SchemaElementUId = new Guid("7816f084-7e3e-457d-9ad0-317d329b9778"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start.SchemaElementUId] = new Collection<ProcessFlowElement> { Start };
			FlowElements[Terminate.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate };
			FlowElements[ActualizeQueuesTriggerScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActualizeQueuesTriggerScriptTask };
			FlowElements[FillQueueFilteredItemsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FillQueueFilteredItemsScriptTask };
			FlowElements[InitUpdateSessionIdFormulaTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitUpdateSessionIdFormulaTask };
			FlowElements[UpdateQueuesScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateQueuesScriptTask };
			FlowElements[ClearQueueFilteredItemsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ClearQueueFilteredItemsScriptTask };
			FlowElements[LogProcessScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogProcessScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[CallQueueUpdateUtilitiesScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CallQueueUpdateUtilitiesScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "Terminate":
						CompleteProcess();
						break;
					case "ActualizeQueuesTriggerScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate", e.Context.SenderName));
						break;
					case "FillQueueFilteredItemsScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("UpdateQueuesScriptTask", e.Context.SenderName));
						break;
					case "InitUpdateSessionIdFormulaTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FillQueueFilteredItemsScriptTask", e.Context.SenderName));
						break;
					case "UpdateQueuesScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ClearQueueFilteredItemsScriptTask", e.Context.SenderName));
						break;
					case "ClearQueueFilteredItemsScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LogProcessScriptTask", e.Context.SenderName));
						break;
					case "LogProcessScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActualizeQueuesTriggerScriptTask", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InitUpdateSessionIdFormulaTask", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CallQueueUpdateUtilitiesScriptTask", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ExclusiveGateway1");
						break;
					case "CallQueueUpdateUtilitiesScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActualizeQueuesTriggerScriptTask", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(false);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow1", "false", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean(true);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow2", "true", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("UpdateSessionId")) {
				writer.WriteValue("UpdateSessionId", UpdateSessionId, Guid.Empty);
			}
			if (!HasMapping("AddedQueueItemsCount")) {
				writer.WriteValue("AddedQueueItemsCount", AddedQueueItemsCount, 0);
			}
			if (!HasMapping("DeletedQueueItemsCount")) {
				writer.WriteValue("DeletedQueueItemsCount", DeletedQueueItemsCount, 0);
			}
			if (!HasMapping("NewQueueItemStatusId")) {
				writer.WriteValue("NewQueueItemStatusId", NewQueueItemStatusId, Guid.Empty);
			}
			if (!HasMapping("MaxQueueFilteredItemsLifeDays")) {
				writer.WriteValue("MaxQueueFilteredItemsLifeDays", MaxQueueFilteredItemsLifeDays, 0);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start", string.Empty));
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
			MetaPathParameterValues.Add("dbf48210-a598-460b-bfce-b27933ecfff8", () => UpdateSessionId);
			MetaPathParameterValues.Add("168bc457-1b6d-4962-83a3-24cc0c53583d", () => NewQueueItemStatusId);
			MetaPathParameterValues.Add("ce429aa3-6cd8-4d38-a6b7-019286ef4823", () => MaxQueueFilteredItemsLifeDays);
			MetaPathParameterValues.Add("f1bbdf69-8cdd-4223-b6f6-0ada6c340c29", () => AddedQueueItemsCount);
			MetaPathParameterValues.Add("222b97a0-00c9-411d-897c-c035aff3a4a7", () => DeletedQueueItemsCount);
			MetaPathParameterValues.Add("fcfa253f-171b-4c14-9460-e9fde6eb0258", () => QueuesUpdatedMessage);
			MetaPathParameterValues.Add("59c9124e-ef80-402a-a878-2c33e9741c0a", () => EmptyFilterRootSchemaMessage);
			MetaPathParameterValues.Add("4212368e-ac01-41d1-8922-c43a0f14a0d7", () => EmptyFiltersMessage);
			MetaPathParameterValues.Add("df7ac21b-eaf4-425a-af1f-8e71d75c59ec", () => InvokeMethodErrorMessage);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "UpdateSessionId":
					if (!hasValueToRead) break;
					UpdateSessionId = reader.GetValue<System.Guid>();
				break;
				case "AddedQueueItemsCount":
					if (!hasValueToRead) break;
					AddedQueueItemsCount = reader.GetValue<System.Int32>();
				break;
				case "DeletedQueueItemsCount":
					if (!hasValueToRead) break;
					DeletedQueueItemsCount = reader.GetValue<System.Int32>();
				break;
				case "NewQueueItemStatusId":
					if (!hasValueToRead) break;
					NewQueueItemStatusId = reader.GetValue<System.Guid>();
				break;
				case "MaxQueueFilteredItemsLifeDays":
					if (!hasValueToRead) break;
					MaxQueueFilteredItemsLifeDays = reader.GetValue<System.Int32>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ActualizeQueuesTriggerScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection userConnection = context.UserConnection;
			Terrasoft.Configuration.QueuesUtilities.UpdateQueuesTrigger(userConnection);
			return true;
		}

		public virtual bool FillQueueFilteredItemsScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection userConnection = context.UserConnection;
			var select = 
				new Select(userConnection)
					.Column("Queue", "Id")
					.Column("Queue", "Name")
					.Column("FilterData")
				.From("Queue")
					.Join(JoinType.Inner, "QueueStatus").On("Queue", "StatusId").IsEqual("QueueStatus", "Id")
				.Where("QueueStatus", "IsInitial").IsNotEqual(new QueryParameter(true))
					.And("QueueStatus", "IsFinal").IsNotEqual(new QueryParameter(true))
					.And("Queue", "IsManuallyFilling").IsEqual(new QueryParameter(false))
				as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				try {
					using (IDataReader dr = select.ExecuteReader(dbExecutor)) {
						while (dr.Read()) {
							var queueId = (Guid)dr.GetColumnValue("Id");
							var queueName = (string)dr.GetColumnValue("Name");
							var filterData = (string)dr.GetColumnValue("FilterData");
							FillQueueFilteredItems(userConnection, UpdateSessionId, queueId, queueName, filterData);
						}
					}
				} catch (Exception e) {
					QueuesUtilities.LogError(string.Format(InvokeMethodErrorMessage,
						"FillQueueFilteredItemsScriptTask", e.Message), e);
					throw;
				}
			}
			return true;
		}

		public virtual bool InitUpdateSessionIdFormulaTaskExecute(ProcessExecutingContext context) {
			var localUpdateSessionId = ((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "AutoGuid"));
			UpdateSessionId = (System.Guid)localUpdateSessionId;
			return true;
		}

		public virtual bool UpdateQueuesScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection userConnection = context.UserConnection;
			DeleteNotActualQueueItems(userConnection);
			InsertNewQueueItems(userConnection);
			return true;
		}

		public virtual bool ClearQueueFilteredItemsScriptTaskExecute(ProcessExecutingContext context) {
			var delete = 
				new Delete(UserConnection)
				.From("QueueFilteredItem")
				.Where("UpdateSessionId").IsEqual(new QueryParameter("UpdateSessionId", UpdateSessionId))
					.Or("CreatedOn").IsLessOrEqual(Column.Const(DateTime.UtcNow.AddDays(-MaxQueueFilteredItemsLifeDays)));
			try {
				delete.Execute();
			} catch (Exception e) {
				QueuesUtilities.LogError(string.Format(InvokeMethodErrorMessage,
					"ClearQueueFilteredItemsScriptTask", e.Message), e);
				throw;
			}
			return true;
		}

		public virtual bool LogProcessScriptTaskExecute(ProcessExecutingContext context) {
			string message = string.Format(QueuesUpdatedMessage, AddedQueueItemsCount, DeletedQueueItemsCount);
			QueuesUtilities.LogInfo(message);
			return true;
		}

		public virtual bool CallQueueUpdateUtilitiesScriptTaskExecute(ProcessExecutingContext context) {
			var queuesUpdateUtilities = ClassFactory.Get<QueuesUpdateUtilities> (new[] {
				new ConstructorArgument("userConnection", UserConnection)
			});
			queuesUpdateUtilities.ProcessAutoUpdateQueues();
			queuesUpdateUtilities.ProcessDeleteInactiveQueueItems();
			return true;
		}

			
			public virtual void FillQueueFilteredItems(UserConnection userConnection, Guid updateSessionId, Guid queueId, string queueName, string filterData) {
				Select actualQueueEntitiesSelect = 
				GetActualQueueEntitiesSelect(userConnection, updateSessionId, queueId, queueName, filterData);
			if (actualQueueEntitiesSelect == null) {
				return;
			}
			var insertSelect =
				new InsertSelect(userConnection)
				.Into("QueueFilteredItem")
					.Set("EntityRecordId", "QueueId", "UpdateSessionId")
				.FromSelect(actualQueueEntitiesSelect);
			try {
				insertSelect.Execute();
			} catch (Exception e) {
				QueuesUtilities.LogError(string.Format(InvokeMethodErrorMessage,
					"FillQueueFilteredItems", e.Message), e);
				throw;
			}
			}
			
			
			public virtual void DeleteNotActualQueueItems(UserConnection userConnection) {
				var actualValuesSelect =
				new Select(userConnection)
					.Column("QueueItem2", "Id")
				.From("QueueItem").As("QueueItem2")
				.Join(JoinType.Inner, "QueueFilteredItem")
					.On("QueueFilteredItem", "EntityRecordId").IsEqual("QueueItem2", "EntityRecordId")
					.And("QueueFilteredItem", "QueueId").IsEqual("QueueItem2", "QueueId")
				.Where("QueueFilteredItem", "UpdateSessionId").IsEqual(new QueryParameter("UpdateSessionId", UpdateSessionId))
				as Select;
			actualValuesSelect.SpecifyNoLockHints();
			var delete =
				new Delete(userConnection)
				.From("QueueItem")
				.Join(JoinType.Inner, "Queue")
					.On("Queue", "Id").IsEqual("QueueItem", "QueueId")
				.Where("QueueItem", "Id").Not().In(actualValuesSelect)
					.And("OperatorId").IsNull()
					.And().Exists(new Select(userConnection)
						.Column("Queue", "Id")
						.From("Queue")
						.Where("QueueItem", "QueueId").IsEqual("Queue", "Id")
						.And("Queue", "IsManuallyFilling").IsEqual(new QueryParameter(false))
					as Select)
				as Delete;
			try {
				DeletedQueueItemsCount = delete.Execute();
			} catch (Exception e) {
				QueuesUtilities.LogError(string.Format(InvokeMethodErrorMessage,
					"DeleteNotActualQueueItems", e.Message), e);
				throw;
			}
			}
			
			
			public virtual void InsertNewQueueItems(UserConnection userConnection) {
				var insertSelect = 
				new InsertSelect(userConnection)
				.Into("QueueItem")
					.Set("EntityRecordId", "QueueId", "StatusId")
				.FromSelect(new Select(userConnection)
					.Column("EntityRecordId")
					.Column("QueueId")
					.Column(Column.Const(NewQueueItemStatusId))
					.From("QueueFilteredItem")
					.Where("QueueFilteredItem", "UpdateSessionId").IsEqual(Column.Const(UpdateSessionId))
					.And().Not().Exists(new Select(userConnection)
						.Column("QueueItem", "Id")
						.From("QueueItem")
						.Join(JoinType.Inner, "QueueItemStatus").On("QueueItem", "StatusId").IsEqual("QueueItemStatus", "Id")
						.Where("QueueItem", "QueueId").IsEqual("QueueFilteredItem", "QueueId")
						.And("QueueItem", "EntityRecordId").IsEqual("QueueFilteredItem", "EntityRecordId")
						.And("QueueItemStatus", "IsFinal").IsNotEqual(Column.Const(true))
					as Select)
				as Select);
			try {
				AddedQueueItemsCount = insertSelect.Execute();
			} catch (Exception e) {
				QueuesUtilities.LogError(string.Format(InvokeMethodErrorMessage,
					"InsertNewQueueItems", e.Message), e);
				throw;
			}
			}
			
			
			public virtual Select GetActualQueueEntitiesSelect(UserConnection userConnection, Guid updateSessionId, Guid queueId, string queueName, string filterData) {
				Filters filters = ServiceStackTextHelper.Deserialize<Filters>(filterData);
			string rootSchemaName = filters.RootSchemaName;
			if (string.IsNullOrEmpty(rootSchemaName)) {
				QueuesUtilities.LogWarn(string.Format(EmptyFilterRootSchemaMessage, queueName));
				return null;
			}
			IEntitySchemaQueryFilterItem esqFilters = filters.BuildEsqFilter(rootSchemaName, UserConnection);
			var queryFilterCollection = esqFilters as EntitySchemaQueryFilterCollection;
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, rootSchemaName);
			esq.AddColumn("Id");
			if (queryFilterCollection != null) {
				if (queryFilterCollection.Count == 0) {
					QueuesUtilities.LogWarn(string.Format(EmptyFiltersMessage, queueName));
					return null;
				}
				esq.Filters.LogicalOperation = queryFilterCollection.LogicalOperation;
				esq.Filters.IsNot = queryFilterCollection.IsNot;
				foreach (IEntitySchemaQueryFilterItem filter in queryFilterCollection) {
					esq.Filters.Add(filter);
				}
			} else {
				esq.Filters.Add(esqFilters);
			}
			Select select = esq.GetSelectQuery(userConnection);
			select = select
				.Column(Column.Const(queueId))
				.Column(Column.Const(updateSessionId));
			select.SpecifyNoLockHints();
			return select;
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
			var cloneItem = (QueuesUpdateProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


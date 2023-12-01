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
	using Terrasoft.Configuration.MandrillService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: ActualizeBulkEmailRecipientsSchema

	/// <exclude/>
	public class ActualizeBulkEmailRecipientsSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ActualizeBulkEmailRecipientsSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ActualizeBulkEmailRecipientsSchema(ActualizeBulkEmailRecipientsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActualizeBulkEmailRecipients";
			UId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481");
			CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.6.0.0";
			CultureName = @"en-US";
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
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481");
			Version = 0;
			PackageUId = new Guid("789c617e-760f-4576-a608-ee12728eae0a");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateSessionKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ccf30a79-ff5e-451c-98a5-2d4d6cf1299a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Name = @"SessionKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLOGGERParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4449f3bb-5841-48c7-a613-6d90a9b7f456"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Name = @"LOGGER",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSessionKeyParameter());
			Parameters.Add(CreateLOGGERParameter());
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
			ProcessSchemaScriptTask scriptmain = CreateScriptMainScriptTask();
			FlowElements.Add(scriptmain);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f1fca63b-3ea2-4f68-ba94-89dcf46af738"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77f33242-6f7d-4ced-8c74-7346cfe812d0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("af84af2a-d656-4916-8437-11132ba775d9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("0022e166-b714-4a74-a4ee-65379bbfa3b4"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CurveCenterPosition = new Point(527, 208),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("af84af2a-d656-4916-8437-11132ba775d9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d3d157f1-a25d-44fb-a96d-539664c943d0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b13ff23e-a247-494f-9649-f91b05c59347"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(882, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("f86465b4-1339-4651-87fe-38b2d48028bc"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b13ff23e-a247-494f-9649-f91b05c59347"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(853, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("77f33242-6f7d-4ced-8c74-7346cfe812d0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f86465b4-1339-4651-87fe-38b2d48028bc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
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
				UId = new Guid("d3d157f1-a25d-44fb-a96d-539664c943d0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f86465b4-1339-4651-87fe-38b2d48028bc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptMainScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("af84af2a-d656-4916-8437-11132ba775d9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f86465b4-1339-4651-87fe-38b2d48028bc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Name = @"ScriptMain",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(295, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,243,77,204,204,211,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,176,217,148,41,21,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateMainMethod());
			Methods.Add(CreateLogErrorMethod());
			Methods.Add(CreateGetLoggerMethod());
			Methods.Add(CreateDeleteOutdatedDataMethod());
			Methods.Add(CreateProcessTriggerEmailsMethod());
			Methods.Add(CreateProcessMassEmailsMethod());
			Methods.Add(CreateInitialEmailsToProccessMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e3484efc-ebe3-4366-a991-1b0729f90297"),
				Name = "Terrasoft.Configuration.MandrillService",
				Alias = "",
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cc216601-e3bc-4db4-a328-21462c6c475e"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1cfb36b4-606d-4fea-9001-ac2a86966701"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			});
		}

		protected virtual SchemaMethod CreateMainMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("85bd34ee-281a-40d1-bda5-17a9704e8550"),
				Name = "Main",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,142,193,106,195,64,12,68,207,245,87,136,156,28,40,246,7,132,158,226,210,83,112,192,78,239,234,122,236,46,108,118,91,73,27,112,190,190,235,66,105,161,23,193,240,102,30,106,219,118,236,187,158,174,188,210,27,200,222,33,32,175,164,136,174,196,68,89,65,19,102,186,113,200,133,204,228,82,142,70,248,204,28,148,238,144,68,213,141,133,38,94,143,223,228,137,106,31,109,63,66,132,53,205,214,28,147,160,156,56,251,37,11,155,79,177,25,86,29,96,230,227,162,77,245,240,2,123,221,236,245,69,33,165,24,225,182,214,35,237,78,28,39,241,33,12,86,118,106,222,93,62,38,54,156,33,62,77,29,175,186,219,31,170,179,36,7,213,81,252,178,64,158,175,236,131,214,63,239,252,242,19,171,254,135,29,2,12,125,182,205,91,148,198,127,232,23,224,146,212,243,29,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLogErrorMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("29558aa7-8144-490a-b708-32f83c335ed4"),
				Name = "LogError",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("61d978b6-aa02-4c1c-93ba-8689cc50b2a0"),
				Name = "message",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6b10f63d-c22b-4f14-b46f-da91d8e98fc8"),
				Name = "e",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Exception",
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,43,75,44,82,200,201,79,79,79,45,82,176,85,112,79,45,241,1,179,53,52,173,185,32,162,122,174,69,69,249,69,26,37,25,153,197,122,126,137,185,169,10,218,10,74,86,10,209,74,64,58,56,181,184,56,51,63,207,59,181,18,36,24,171,0,18,203,5,138,37,166,131,85,89,43,233,40,164,106,90,3,0,131,238,231,16,97,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetLoggerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("998d222e-95a7-4fa7-96ae-03134231f511"),
				Name = "GetLogger",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				ResultValueTypeName = "global::Common.Logging.ILog"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,142,77,10,194,48,20,132,215,230,20,143,174,146,77,14,208,210,149,148,32,214,20,172,23,136,24,107,32,63,146,164,74,17,239,110,26,90,93,185,154,247,96,102,190,121,8,15,218,13,131,244,80,67,219,49,214,28,65,4,24,180,59,11,93,150,91,103,140,179,180,77,14,101,7,186,75,71,133,212,21,240,154,169,193,142,90,19,120,161,205,183,230,79,56,233,65,88,145,60,148,201,216,102,55,142,55,21,40,23,70,146,10,109,22,126,189,44,170,208,59,179,66,244,25,30,120,66,117,190,49,247,56,225,94,134,160,156,221,203,137,100,250,239,79,121,54,170,11,229,242,57,43,38,244,228,250,92,129,11,94,144,185,213,203,56,122,187,98,62,183,168,15,183,4,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeleteOutdatedDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c3a19e27-b010-44cd-8bc6-550d4b0f297b"),
				Name = "DeleteOutdatedData",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("96c06f30-d70a-40c7-996f-8be019477bf7"),
				Name = "dayCount",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,83,77,143,218,48,16,61,7,137,255,96,113,114,164,202,98,111,85,41,149,54,36,84,72,84,187,165,180,123,172,76,60,93,172,58,54,181,157,93,208,138,255,190,227,56,1,130,170,106,15,69,33,31,227,241,123,111,102,158,151,210,249,143,82,251,79,100,83,171,223,69,197,165,90,45,132,35,83,162,225,153,44,187,85,154,78,134,131,111,160,160,244,164,220,66,25,51,191,214,96,15,109,106,92,164,223,29,216,153,209,26,223,165,209,233,112,144,176,153,81,117,165,233,8,113,71,77,96,110,77,69,71,89,199,23,131,15,91,176,64,83,86,236,145,211,81,12,37,201,63,113,241,199,214,102,71,111,186,143,142,167,165,9,161,200,244,133,107,97,165,82,43,40,229,78,130,246,167,245,72,122,150,210,72,100,11,87,252,169,185,186,148,248,142,68,249,141,212,59,43,192,102,135,91,87,98,81,29,230,204,212,1,152,112,215,74,198,134,13,7,30,251,243,130,123,106,39,245,35,161,121,86,236,161,172,189,177,68,108,78,175,83,210,175,142,21,218,213,22,242,236,28,162,105,218,224,116,64,139,156,123,190,2,142,66,136,141,143,233,245,96,88,36,128,152,70,207,132,29,86,242,188,149,10,8,141,0,44,228,157,120,146,164,231,7,118,43,196,213,12,88,158,173,15,59,192,192,19,88,143,251,243,236,7,87,53,172,205,66,251,14,243,51,248,38,72,199,105,26,44,132,184,199,112,15,55,252,31,73,201,125,185,37,180,216,151,176,11,168,4,90,1,75,243,88,88,107,44,29,205,81,3,8,226,13,145,90,122,201,21,17,88,60,249,133,157,43,21,112,75,60,84,59,18,148,134,214,120,190,81,224,112,96,16,248,142,97,8,152,9,60,176,160,147,123,54,71,192,190,237,35,55,94,79,8,235,176,85,32,238,173,41,65,224,56,58,159,247,163,87,77,65,159,120,183,251,153,163,3,60,116,190,187,171,61,42,6,17,102,54,106,186,112,5,205,30,164,223,222,115,203,43,220,101,233,165,164,55,164,11,126,104,204,151,78,130,242,206,113,255,207,114,201,121,31,158,177,170,194,170,214,178,2,83,123,132,185,121,63,30,199,185,94,139,108,221,119,233,187,201,105,244,111,152,187,243,22,11,96,115,99,43,238,47,93,32,154,230,146,214,5,120,194,255,102,0,70,46,15,245,7,242,50,62,162,39,122,157,109,45,210,248,112,56,120,5,12,10,91,97,9,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateProcessTriggerEmailsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a488f38b-423a-48c9-a734-84522a1bc039"),
				Name = "ProcessTriggerEmails",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b60dbddb-cf7a-40ca-b7f9-0d6859902d49"),
				Name = "dayCount",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,65,75,195,64,16,133,207,17,252,15,67,79,91,40,161,222,68,241,96,107,132,130,130,104,197,163,140,187,99,92,76,118,203,236,68,173,210,255,238,36,209,198,234,197,203,102,119,152,55,239,203,155,23,100,120,104,170,231,162,70,95,165,133,75,112,2,139,224,197,99,213,151,150,241,138,163,181,148,146,185,68,126,38,241,161,156,199,144,36,229,75,246,101,73,76,174,235,156,125,79,153,163,80,25,121,189,112,227,227,253,189,199,200,132,246,9,140,15,50,56,93,47,28,248,176,235,60,134,143,253,189,76,120,221,125,179,23,37,75,162,106,215,2,144,107,152,148,45,208,43,220,236,86,205,109,34,86,164,64,86,124,12,19,24,73,90,221,159,90,105,176,242,239,244,69,121,169,46,138,126,77,214,175,60,5,73,163,150,46,203,126,89,228,119,94,158,174,144,177,38,33,54,63,129,255,211,239,112,61,143,77,144,190,183,73,234,8,230,108,86,188,145,109,84,8,238,97,123,61,129,93,238,188,8,73,7,158,205,134,146,25,247,153,100,217,160,203,231,177,174,49,184,165,175,41,54,162,99,14,14,167,211,206,238,15,91,175,33,51,168,123,174,141,30,27,176,40,237,94,138,55,75,171,214,13,232,203,237,34,150,5,115,100,147,132,245,7,242,243,200,53,138,25,157,107,14,228,64,34,84,17,29,56,20,108,31,219,197,47,145,75,18,208,141,131,244,161,3,117,203,205,135,30,205,241,8,62,166,155,209,4,58,228,157,128,39,138,208,2,42,223,230,19,120,80,227,171,153,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateProcessMassEmailsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("97e856b7-7a63-446f-b502-109f5a632dea"),
				Name = "ProcessMassEmails",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ce7241aa-abbd-42c2-a08c-3dd8c1d06bbf"),
				Name = "dayCount",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,65,107,219,64,16,133,207,10,228,63,12,62,173,193,200,46,244,80,26,114,168,109,5,12,53,9,137,74,143,97,178,59,181,150,72,187,102,118,148,198,13,254,239,157,141,218,168,110,47,189,72,218,199,204,188,239,141,246,9,25,30,250,246,177,234,208,183,105,227,18,92,194,38,120,241,216,14,82,29,111,56,90,75,41,153,45,242,35,137,15,187,85,12,73,82,185,197,148,114,141,42,203,223,35,86,40,180,139,124,216,184,233,197,249,217,183,200,132,182,1,227,131,140,54,183,27,7,62,156,218,78,225,229,252,172,16,62,188,190,139,249,124,94,95,175,175,161,174,238,106,120,15,210,232,28,101,235,72,154,232,160,33,166,92,245,164,240,73,212,195,101,70,114,61,147,226,7,250,14,119,167,170,249,146,136,149,58,144,21,31,195,12,38,146,246,247,159,172,244,216,250,31,148,131,108,135,32,183,100,253,222,83,144,52,201,1,138,226,175,249,229,87,47,205,13,50,42,10,177,249,51,211,255,212,59,60,172,98,31,100,168,237,147,58,130,89,47,171,103,178,189,54,130,123,120,251,188,132,83,232,178,10,73,7,174,151,163,100,166,195,218,138,98,236,43,87,177,235,48,184,218,119,20,123,209,49,239,62,44,22,175,118,255,176,13,61,100,198,238,129,235,168,143,35,88,148,252,235,170,103,75,251,236,6,244,203,237,115,220,85,204,145,77,18,214,0,229,85,228,14,197,76,174,116,15,228,64,34,180,17,29,56,20,204,135,183,187,81,35,239,72,202,81,208,165,125,132,151,197,113,50,59,185,28,211,153,90,101,16,229,56,254,4,193,43,42,32,161,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitialEmailsToProccessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("921c066d-a600-4bf9-8829-cd6a6ef96b9f"),
				Name = "InitialEmailsToProccess",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				ResultValueTypeName = "List<int>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8be56cf3-11fa-41dc-b1a5-0d3737f5c353"),
				Name = "emailCategoryId",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,77,143,218,48,16,61,131,196,127,24,113,114,164,149,105,207,219,173,196,71,168,144,64,187,93,104,123,54,201,108,176,214,216,169,61,222,5,85,251,223,59,249,0,66,171,246,176,145,146,56,99,191,55,227,121,207,89,234,64,159,180,165,207,176,141,230,57,221,43,109,30,23,121,128,59,176,248,10,203,211,172,72,110,7,253,209,104,4,155,251,217,61,172,157,39,216,30,193,99,166,75,141,150,2,100,46,90,130,39,231,97,171,11,200,21,169,65,127,141,6,51,2,172,72,195,215,136,254,216,210,54,19,226,91,64,63,117,214,242,88,59,155,12,250,61,57,117,38,238,173,24,114,13,195,58,48,247,110,47,134,147,83,109,77,240,199,14,61,242,34,12,165,179,1,31,188,203,48,4,109,139,169,219,151,6,9,25,44,23,33,253,25,149,17,13,165,124,80,94,237,121,202,139,39,101,2,38,53,209,216,230,98,56,85,132,133,243,199,197,127,81,245,46,46,75,59,248,53,41,138,161,65,91,193,225,222,95,224,149,242,207,72,117,129,54,80,144,231,253,52,216,185,182,58,236,48,103,218,155,247,224,215,228,202,242,253,240,49,247,255,5,187,123,74,100,122,96,233,131,248,183,90,114,227,74,241,49,57,43,214,10,198,87,171,217,74,217,220,107,99,214,236,143,21,203,163,10,228,14,181,210,77,58,102,235,116,189,35,244,13,52,38,72,64,133,182,4,182,32,177,135,126,113,154,88,169,13,98,54,73,15,152,69,98,219,229,219,243,240,14,174,107,149,169,13,209,227,108,114,9,9,230,173,120,78,68,139,25,59,246,17,85,142,158,93,93,191,238,186,198,149,13,57,54,75,196,37,217,137,167,247,186,211,6,65,52,96,89,173,59,231,232,245,174,206,150,28,231,249,31,221,148,179,201,230,88,34,7,94,208,179,98,252,253,93,153,136,27,183,176,116,226,252,130,84,7,197,135,36,169,142,35,243,190,85,207,234,193,247,27,100,138,178,29,136,244,144,97,89,177,2,182,5,44,93,145,122,239,188,24,206,185,6,204,129,28,176,229,72,43,83,31,213,250,220,26,167,242,170,23,60,119,86,97,163,124,129,196,90,96,149,144,147,120,164,232,237,245,191,226,246,55,131,83,222,22,68,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ActualizeBulkEmailRecipients(userConnection);
		}

		public override object Clone() {
			return new ActualizeBulkEmailRecipientsSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"));
		}

		#endregion

	}

	#endregion

	#region Class: ActualizeBulkEmailRecipients

	/// <exclude/>
	public class ActualizeBulkEmailRecipients : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, ActualizeBulkEmailRecipients process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public ActualizeBulkEmailRecipients(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActualizeBulkEmailRecipients";
			SchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ActualizeBulkEmailRecipients, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ActualizeBulkEmailRecipients, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual string SessionKey {
			get;
			set;
		}

		public virtual Object LOGGER {
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
					SchemaElementUId = new Guid("77f33242-6f7d-4ced-8c74-7346cfe812d0"),
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
					SchemaElementUId = new Guid("d3d157f1-a25d-44fb-a96d-539664c943d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptMain;
		public ProcessScriptTask ScriptMain {
			get {
				return _scriptMain ?? (_scriptMain = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptMain",
					SchemaElementUId = new Guid("af84af2a-d656-4916-8437-11132ba775d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = ScriptMainExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ScriptMain.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptMain };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptMain", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ScriptMain":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("SessionKey")) {
				writer.WriteValue("SessionKey", SessionKey, null);
			}
			if (LOGGER != null) {
				if (LOGGER.GetType().IsSerializable ||
					LOGGER.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("LOGGER", LOGGER, null);
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
			MetaPathParameterValues.Add("ccf30a79-ff5e-451c-98a5-2d4d6cf1299a", () => SessionKey);
			MetaPathParameterValues.Add("4449f3bb-5841-48c7-a613-6d90a9b7f456", () => LOGGER);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "SessionKey":
					if (!hasValueToRead) break;
					SessionKey = reader.GetValue<System.String>();
				break;
				case "LOGGER":
					if (!hasValueToRead) break;
					LOGGER = reader.GetSerializableObjectValue();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptMainExecute(ProcessExecutingContext context) {
			Main();
			return true;
		}

		public virtual void Main() {
			///TODO may be there is sence to use def value if count equals zero 
			var dayCount = (int)Terrasoft.Core.Configuration.SysSettings.
				GetValue(UserConnection, "MandrillStatisticUpdatePeriodDays");
			ProcessTriggerEmails(dayCount);
			ProcessMassEmails(dayCount);
			DeleteOutdatedData(dayCount);
		}

		public virtual void LogError(string message, Exception e) {
			var logger = GetLogger();
			logger.Error(this.Name + ": [" + SessionKey + "] " + message + ";", e);
		}

		public virtual global::Common.Logging.ILog GetLogger() {
			var logger = LOGGER as global::Common.Logging.ILog;
			if (logger == null) {
				logger = global::Common.Logging.LogManager.GetLogger(this.Name);
				LOGGER = logger;
			}
			if (string.IsNullOrEmpty(SessionKey)) {
				SessionKey = Guid.NewGuid().ToString("N");
			}
			return logger;
		}

		public virtual void DeleteOutdatedData(int dayCount) {
			List<int> bulkEmailRIds = new List<int>();
			Select checkEmailQuery = new Select(UserConnection)
				.Column("RId")
				.From("BulkEmail")
				.Where().Exists(
						new Select(UserConnection)
							.Top(1)
							.Column("Id")
							.From("MandrillRecipient")
							.Where("BulkEmailRId").IsEqual("BulkEmail", "RId"))
				.OrderByAsc("RecipientCount") as Select;
			
			try {
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader reader = checkEmailQuery.ExecuteReader(dbExecutor)) {
						while (reader.Read()) {
							bulkEmailRIds.Add(UserConnection.DBTypeConverter.DBValueToInt(reader.GetValue(0)));
						}
					}
				}
			} catch (Exception e) {
					LogError("Failed to initial data for clear temp mailing tables", e);
			}
			
			foreach (int bulkEmailRId in bulkEmailRIds) {
				
				var storedProcedure = new StoredProcedure(UserConnection, "tsp_DeleteMandrillOutdatedData");
				storedProcedure.WithParameter(bulkEmailRId);
				storedProcedure.WithParameter(dayCount);	
				try {
					using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
						dbExecutor.CommandTimeout = 1800;
						storedProcedure.Execute(dbExecutor);
					}
				} catch (Exception e) {
					LogError(string.Format("Failed to delete  data from temp mailing tables. BulkEmailRId: {0}", bulkEmailRId), e);
				}
			}
		}

		public virtual void ProcessTriggerEmails(int dayCount) {
			var bulkEmailsIds = InitialEmailsToProccess(MarketingConsts.TriggeredEmailBulkEmailCategoryId);
			foreach (int bulkEmailRId in bulkEmailsIds) {
				try {
					var storedProcedure = new StoredProcedure(UserConnection, "tsp_ActualizeTriggerMailingRecipients");
					storedProcedure.WithParameter(bulkEmailRId);
					storedProcedure.WithParameter(dayCount);
					using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
						dbExecutor.CommandTimeout = 1800;
						storedProcedure.Execute(dbExecutor);
					}
				} catch (Exception e) {
					LogError(string.Format("Failed to load data to BulkEmailTarget for trigger emails. BulkEmailRId: {0}", 
						bulkEmailRId), e);
				}
			}
		}

		public virtual void ProcessMassEmails(int dayCount) {
			var bulkEmailsIds = InitialEmailsToProccess(MarketingConsts.MassmailingBulkEmailCategoryId);
			foreach (int bulkEmailRId in bulkEmailsIds) {
				try {
					///TODO TEST 4 threads method here
					var storedProcedure = new StoredProcedure(UserConnection, "tsp_ActualizeMassMailingRecipients");
					storedProcedure.WithParameter(bulkEmailRId);
					storedProcedure.WithParameter(dayCount);
					using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
						dbExecutor.CommandTimeout = 1800;
						storedProcedure.Execute(dbExecutor);
					}
				} catch (Exception e) {
					LogError(string.Format("Failed to load data to BulkEmailTarget. BulkEmailRId: {0}", bulkEmailRId), e);
				}
			}
		}

		public virtual List<int> InitialEmailsToProccess(Guid emailCategoryId) {
			List<int> bulkEmailRIds = new List<int>();
			/// TODO Sort by recipients count for big data
			Select emailsQuery = new Select(UserConnection)
				.Column("RId")
				.From("BulkEmail")
				.Where("ResponseProcessingCompleted").IsEqual(Column.Parameter(false))
				.And("CategoryId").IsEqual(Column.Parameter(emailCategoryId))
				.And("StatusId").In(
					Column.Parameter(MarketingConsts.BulkEmailStatusFinishedId),
					Column.Parameter(MarketingConsts.BulkEmailStatusStoppedId),
					Column.Parameter(MarketingConsts.BulkEmailStatusActiveId))
				.And().Exists(new Select(UserConnection).Top(1).Column("Id")
							.From("MandrillSentMessage").Where("BulkEmailRId").IsEqual("BulkEmail", "RId")) as Select;
			try {
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader reader = emailsQuery.ExecuteReader(dbExecutor)) {
						while (reader.Read()) {
							bulkEmailRIds.Add(UserConnection.DBTypeConverter.DBValueToInt(reader.GetValue(0)));
						}
					}
				}
			} catch (Exception e) {
					LogError("Failed to initial data for loading to BulkEmailTarget", e);
			}
			return bulkEmailRIds;
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
			var cloneItem = (ActualizeBulkEmailRecipients)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.LOGGER = LOGGER;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


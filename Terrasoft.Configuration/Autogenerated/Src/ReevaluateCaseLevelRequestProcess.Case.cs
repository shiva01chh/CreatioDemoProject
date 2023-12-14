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

	#region Class: ReevaluateCaseLevelRequestProcessSchema

	/// <exclude/>
	public class ReevaluateCaseLevelRequestProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ReevaluateCaseLevelRequestProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ReevaluateCaseLevelRequestProcessSchema(ReevaluateCaseLevelRequestProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ReevaluateCaseLevelRequestProcess";
			UId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c");
			CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.8.0.0";
			CultureName = @"ru-RU";
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
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,85,219,78,219,64,16,125,6,137,127,216,250,201,150,34,139,210,71,46,82,49,9,178,212,166,8,135,242,188,216,227,176,210,122,55,221,139,75,84,250,239,204,238,26,48,113,82,46,165,170,18,69,120,103,206,217,153,51,199,195,206,246,194,94,113,86,146,150,41,99,41,39,173,100,21,41,12,85,102,194,148,54,51,214,128,58,83,178,4,173,153,152,199,9,249,181,179,189,149,81,13,231,80,74,85,229,21,57,36,167,150,85,233,184,89,152,229,254,206,118,174,51,46,53,124,22,213,248,134,25,140,214,148,107,192,0,171,73,236,137,11,54,23,148,127,76,31,24,62,244,41,214,222,176,22,135,156,191,7,180,123,111,164,221,91,161,109,169,34,181,83,96,106,155,43,80,151,148,25,236,255,132,46,53,57,140,153,48,201,12,148,162,90,214,38,205,164,2,252,17,53,155,91,69,13,147,34,45,150,186,0,227,16,58,61,5,243,157,114,11,241,133,6,133,105,2,74,151,51,34,145,87,248,28,160,197,176,199,245,110,137,18,47,89,188,169,134,67,178,27,90,26,232,109,148,117,114,111,41,48,86,137,199,110,140,52,148,23,216,164,168,16,79,4,252,36,110,186,197,130,138,13,183,140,200,110,248,38,233,172,7,70,202,140,154,242,218,123,99,38,31,26,0,223,79,234,69,253,86,215,26,92,53,216,112,11,202,32,65,46,204,167,189,184,95,133,107,209,151,231,62,27,125,24,146,215,27,17,5,66,121,115,93,160,124,186,166,94,216,139,69,133,181,124,129,22,56,42,162,13,166,222,222,18,159,230,198,223,15,36,175,18,80,251,66,254,161,31,66,167,207,24,98,83,21,7,206,17,239,102,136,13,183,188,214,17,33,254,78,150,184,146,146,175,159,163,247,130,107,169,196,64,1,28,21,237,26,10,15,43,82,39,152,141,3,226,182,17,241,196,138,18,255,182,194,196,81,94,69,137,143,77,148,108,226,200,221,18,249,231,203,107,80,16,226,105,174,199,63,176,154,56,224,211,51,170,104,3,6,84,220,223,45,129,6,71,16,71,125,107,250,154,61,203,84,98,217,200,53,181,156,99,253,84,119,149,98,251,97,76,189,86,210,241,13,148,22,197,44,41,167,234,0,205,118,132,144,35,178,251,34,173,158,121,53,238,149,211,131,180,7,29,255,90,200,97,9,79,100,117,194,189,70,218,117,106,109,42,255,45,218,249,213,227,223,33,119,239,255,216,52,32,12,51,203,162,188,134,134,126,165,130,206,65,97,246,83,237,211,241,48,105,127,8,71,220,26,54,183,132,114,161,13,21,37,28,47,167,40,243,189,221,145,34,16,119,48,119,186,194,145,102,10,176,239,144,182,234,136,238,31,253,35,56,157,0,110,6,103,132,147,227,193,59,226,84,233,165,226,142,12,179,15,11,50,194,189,97,172,70,111,140,136,139,123,245,194,153,187,231,79,72,151,106,21,100,178,130,39,240,238,236,133,240,19,103,213,209,170,240,153,85,10,177,238,212,233,216,61,186,92,183,255,112,214,171,228,180,197,211,253,206,110,254,231,14,57,223,241,92,119,9,0,0 };
			RealUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c");
			Version = 0;
			PackageUId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("139575f5-1fcd-4511-8b6e-8fcca638b068"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"CaseRecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCloseAndExitParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("53928eba-9c90-4f6f-880b-0ca34bb3e439"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"IsCloseAndExit",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseClosureCodeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1dd18ad4-0125-4b96-9e2d-6f2c3401376b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"CaseClosureCode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.66827e0a-27d4-4616-b69a-ac6321b7be52.b69f315c-f36b-1410-159b-0050ba5d6c38#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseCloseStatusParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1830b7fa-15a4-4836-af66-3bacbb623476"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"CaseCloseStatus",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.99f35013-6b7a-47d6-b440-e3f1a0ba991c.3e7f420c-f46b-1410-fc9a-0050ba5d6c38#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailTemplateIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3b72b4ac-4c8f-4e6a-b29b-c81d60d4fcc7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"EmailTemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.93030575-f70f-4041-902e-c4badaf62c63.291b7433-d6ca-43da-b194-2590d86369b2#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseRecordIdParameter());
			Parameters.Add(CreateIsCloseAndExitParameter());
			Parameters.Add(CreateCaseClosureCodeParameter());
			Parameters.Add(CreateCaseCloseStatusParameter());
			Parameters.Add(CreateEmailTemplateIdParameter());
		}

		protected virtual void InitializeSubProcessSendEmailParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var caseIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4523623f-4dea-4fac-858f-a633a5eb3787"),
				ContainerUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"CaseId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			caseIdParameter.SourceValue = new ProcessSchemaParameterValue(caseIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{139575f5-1fcd-4511-8b6e-8fcca638b068}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c")
			};
			parametrizedElement.Parameters.Add(caseIdParameter);
			var senderEmailParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("584a3f6a-da7e-45f5-b2f0-f83f8893a97f"),
				ContainerUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"SenderEmail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText")
			};
			senderEmailParameter.SourceValue = new ProcessSchemaParameterValue(senderEmailParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#SysSettings.SupportServiceEmail<String>#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c")
			};
			parametrizedElement.Parameters.Add(senderEmailParameter);
			var templateIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b2a1f1d0-1269-45d3-93c3-a329c07567bf"),
				ContainerUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"TemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			templateIdParameter.SourceValue = new ProcessSchemaParameterValue(templateIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{3b72b4ac-4c8f-4e6a-b29b-c81d60d4fcc7}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c")
			};
			parametrizedElement.Parameters.Add(templateIdParameter);
			var subjectParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0e122291-0a8c-48ff-946f-4ca72f29f16f"),
				ContainerUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"Subject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText")
			};
			subjectParameter.SourceValue = new ProcessSchemaParameterValue(subjectParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(subjectParameter);
			var parentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2413977c-0566-46eb-ab67-c15adc6a3fc5"),
				ContainerUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"ParentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			parentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(parentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(parentActivityIdParameter);
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("30fc86ce-b02b-4d00-8276-3f023dee5566"),
				ContainerUId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
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
				UId = new Guid("d46fb24f-a5d8-484e-bdc3-8065a7da191e"),
				ContainerUId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
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
				UId = new Guid("45d8dd87-236b-4301-8a97-113a71a04d29"),
				ContainerUId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
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
				UId = new Guid("e405b39d-9a4f-4a66-a35a-707bdf998f1e"),
				ContainerUId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
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

		protected virtual void InitializeCatchTimerToReevaluateFirstParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var startOffsetParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ee6b7a7e-e889-4f79-ade3-114e4895482d"),
				ContainerUId = new Guid("553ce2c0-4662-49b8-a937-de141892e8e4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("553ce2c0-4662-49b8-a937-de141892e8e4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"StartOffset",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startOffsetParameter.SourceValue = new ProcessSchemaParameterValue(startOffsetParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c")
			};
			parametrizedElement.Parameters.Add(startOffsetParameter);
		}

		protected virtual void InitializeCatchTimerToReevaluateSecondParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var startOffsetParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4bbaea95-8c50-4f35-ac3c-93ca19ff3b2d"),
				ContainerUId = new Guid("7ac2cdf4-9c14-4cf8-b583-3980fb41c88c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ac2cdf4-9c14-4cf8-b583-3980fb41c88c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"StartOffset",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startOffsetParameter.SourceValue = new ProcessSchemaParameterValue(startOffsetParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c")
			};
			parametrizedElement.Parameters.Add(startOffsetParameter);
		}

		protected virtual void InitializeIntermediateCatchSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("21c64e29-5cd9-4d94-8115-916f7cd44bda"),
				ContainerUId = new Guid("a09882fe-81f6-4ef9-9e42-724756f47811"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{139575f5-1fcd-4511-8b6e-8fcca638b068}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaSubProcess subprocesssendemail = CreateSubProcessSendEmailSubProcess();
			FlowElements.Add(subprocesssendemail);
			ProcessSchemaTerminateEvent terminate1086974 = CreateTerminate1086974TerminateEvent();
			FlowElements.Add(terminate1086974);
			ProcessSchemaStartSignalEvent startsignal1 = CreateStartSignal1StartSignalEvent();
			FlowElements.Add(startsignal1);
			ProcessSchemaStartSignalEvent startsignal2 = CreateStartSignal2StartSignalEvent();
			FlowElements.Add(startsignal2);
			ProcessSchemaExclusiveGateway exclusivegateway111111111111111111 = CreateExclusiveGateway111111111111111111ExclusiveGateway();
			FlowElements.Add(exclusivegateway111111111111111111);
			ProcessSchemaScriptTask startfirsttimerprocessingscripttask = CreateStartFirstTimerProcessingScriptTaskScriptTask();
			FlowElements.Add(startfirsttimerprocessingscripttask);
			ProcessSchemaIntermediateCatchTimerEvent catchtimertoreevaluatefirst = CreateCatchTimerToReevaluateFirstIntermediateCatchTimerEvent();
			FlowElements.Add(catchtimertoreevaluatefirst);
			ProcessSchemaScriptTask startsecondtimerprocessingscripttask = CreateStartSecondTimerProcessingScriptTaskScriptTask();
			FlowElements.Add(startsecondtimerprocessingscripttask);
			ProcessSchemaIntermediateCatchTimerEvent catchtimertoreevaluatesecond = CreateCatchTimerToReevaluateSecondIntermediateCatchTimerEvent();
			FlowElements.Add(catchtimertoreevaluatesecond);
			ProcessSchemaScriptTask closecasescripttask = CreateCloseCaseScriptTaskScriptTask();
			FlowElements.Add(closecasescripttask);
			ProcessSchemaParallelGateway parallelgateway1 = CreateParallelGateway1ParallelGateway();
			FlowElements.Add(parallelgateway1);
			ProcessSchemaIntermediateCatchSignalEvent intermediatecatchsignal1 = CreateIntermediateCatchSignal1IntermediateCatchSignalEvent();
			FlowElements.Add(intermediatecatchsignal1);
			ProcessSchemaTerminateEvent terminateevent1 = CreateTerminateEvent1TerminateEvent();
			FlowElements.Add(terminateevent1);
			FlowElements.Add(CreateSequenceFlow19546735SequenceFlow());
			FlowElements.Add(CreateSequenceFlow29868587SequenceFlow());
			FlowElements.Add(CreateSequenceFlow33453543SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4958986784SequenceFlow());
			FlowElements.Add(CreateSequenceFlow762532546SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8524524SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow165867ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow17453654SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow234SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow262574684ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19546735SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19546735",
				UId = new Guid("6eb1d5ca-06f4-4c7c-8363-c0239f722300"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cd92481c-0570-43b4-b4b9-f7abce8bbe5a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(147, 246));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow29868587SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow29868587",
				UId = new Guid("83fd9fd3-2e4a-4b15-81e1-12326e12ee5a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cd92481c-0570-43b4-b4b9-f7abce8bbe5a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("14bba315-e0f3-4300-b097-2c089d9cdb14"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow33453543SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow33453543",
				UId = new Guid("ffff5dfd-220f-4f15-b936-978019d94507"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cd92481c-0570-43b4-b4b9-f7abce8bbe5a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(77, 133));
			schemaFlow.PolylinePointPositions.Add(new Point(77, 130));
			schemaFlow.PolylinePointPositions.Add(new Point(147, 130));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4958986784SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4958986784",
				UId = new Guid("a55a1fd5-64c4-4d2d-a32b-a2e097fe5d3f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ac2cdf4-9c14-4cf8-b583-3980fb41c88c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d2c716a7-30a5-45f9-adbb-431118668991"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow762532546SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow762532546",
				UId = new Guid("ee0330fb-43c1-43e0-987c-0d4eb428141d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d2c716a7-30a5-45f9-adbb-431118668991"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a92db02c-08c7-4f4a-881b-032d16da77f6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8524524SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8524524",
				UId = new Guid("36efe2c2-194e-45d4-b9e7-b88e5dcbfb2a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ac2cdf4-9c14-4cf8-b583-3980fb41c88c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow165867ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow165867",
				UId = new Guid("b721b4be-1338-4df2-b3e6-08a78ca1c1eb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{53928eba-9c90-4f6f-880b-0ca34bb3e439}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf1065a6-92fd-4c15-9139-11de754f136e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a92db02c-08c7-4f4a-881b-032d16da77f6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(605, 245));
			schemaFlow.PolylinePointPositions.Add(new Point(966, 245));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow17453654SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow17453654",
				UId = new Guid("19028fd2-7863-4257-a99c-87fdf6058309"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf1065a6-92fd-4c15-9139-11de754f136e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(605, 105));
			schemaFlow.PolylinePointPositions.Add(new Point(660, 105));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow234SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow234",
				UId = new Guid("ec631169-2b03-49d1-b5b6-f48246ec3577"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("14bba315-e0f3-4300-b097-2c089d9cdb14"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1f6c3ee1-6122-4b11-b104-a0e1410eaa35"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow262574684ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow262574684",
				UId = new Guid("c863baaa-bf59-4331-825f-f0e475e77b99"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{53928eba-9c90-4f6f-880b-0ca34bb3e439}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("14bba315-e0f3-4300-b097-2c089d9cdb14"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a92db02c-08c7-4f4a-881b-032d16da77f6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(245, 230));
			schemaFlow.PolylinePointPositions.Add(new Point(966, 230));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("d4c828d9-7a8d-40e9-914b-3247cf8b6343"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("553ce2c0-4662-49b8-a937-de141892e8e4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bf1065a6-92fd-4c15-9139-11de754f136e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("43ca5022-c5b2-498e-9083-0294ac67176c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1f6c3ee1-6122-4b11-b104-a0e1410eaa35"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a09882fe-81f6-4ef9-9e42-724756f47811"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(405, 187));
			schemaFlow.PolylinePointPositions.Add(new Point(405, 84));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("d77c7501-dca5-466a-b9ef-9a2883e0b281"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1f6c3ee1-6122-4b11-b104-a0e1410eaa35"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("553ce2c0-4662-49b8-a937-de141892e8e4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("3a950068-1a9d-414a-b97b-b64d4d66386a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a09882fe-81f6-4ef9-9e42-724756f47811"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("45a66392-0072-4438-921e-1b2982c9157f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("492956c3-9985-4387-9dba-30a80ab3301d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("492956c3-9985-4387-9dba-30a80ab3301d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1086974TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("a92db02c-08c7-4f4a-881b-032d16da77f6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"Terminate1086974",
				Position = new Point(953, 174),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
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
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(20, 233),
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
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
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
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"StartSignal2",
				NewEntityChangedColumns = false,
				Position = new Point(20, 120),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("a71adaea-3464-4dee-bb4f-c7a535450ad7");
			InitializeStartSignal2Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway111111111111111111ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("cd92481c-0570-43b4-b4b9-f7abce8bbe5a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"ExclusiveGateway111111111111111111",
				Position = new Point(120, 160),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateStartFirstTimerProcessingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("14bba315-e0f3-4300-b097-2c089d9cdb14"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"StartFirstTimerProcessingScriptTask",
				Position = new Point(211, 160),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,11,46,73,44,42,113,203,44,42,46,9,201,204,77,45,10,40,202,79,78,45,46,206,204,75,215,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,27,159,177,206,41,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaSubProcess CreateSubProcessSendEmailSubProcess() {
			ProcessSchemaSubProcess schemaSubProcessSendEmail = new ProcessSchemaSubProcess(this) {
				UId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"SubProcessSendEmail",
				Position = new Point(626, 20),
				SchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeSubProcessSendEmailParameters(schemaSubProcessSendEmail);
			return schemaSubProcessSendEmail;
		}

		protected virtual ProcessSchemaIntermediateCatchTimerEvent CreateCatchTimerToReevaluateFirstIntermediateCatchTimerEvent() {
			ProcessSchemaIntermediateCatchTimerEvent schemaCatchTimerEvent = new ProcessSchemaIntermediateCatchTimerEvent(this) {
				UId = new Guid("553ce2c0-4662-49b8-a937-de141892e8e4"),
				AttachedToUId = Guid.Empty,
				BackgroundModePriority = BackgroundModePriority.Inherited,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("97d1af3d-ef13-465c-b6d8-5425f78bf000"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"CatchTimerToReevaluateFirst",
				Position = new Point(453, 174),
				Size = new Size(27, 27)
			};
			InitializeCatchTimerToReevaluateFirstParameters(schemaCatchTimerEvent);
			return schemaCatchTimerEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateStartSecondTimerProcessingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bf1065a6-92fd-4c15-9139-11de754f136e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"StartSecondTimerProcessingScriptTask",
				Position = new Point(571, 160),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,11,46,73,44,42,9,78,77,206,207,75,9,201,204,77,45,10,40,202,79,78,45,46,206,204,75,215,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,73,197,15,185,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateCatchTimerEvent CreateCatchTimerToReevaluateSecondIntermediateCatchTimerEvent() {
			ProcessSchemaIntermediateCatchTimerEvent schemaCatchTimerEvent = new ProcessSchemaIntermediateCatchTimerEvent(this) {
				UId = new Guid("7ac2cdf4-9c14-4cf8-b583-3980fb41c88c"),
				AttachedToUId = Guid.Empty,
				BackgroundModePriority = BackgroundModePriority.Inherited,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("97d1af3d-ef13-465c-b6d8-5425f78bf000"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"CatchTimerToReevaluateSecond",
				Position = new Point(800, 34),
				Size = new Size(27, 27)
			};
			InitializeCatchTimerToReevaluateSecondParameters(schemaCatchTimerEvent);
			return schemaCatchTimerEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCloseCaseScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d2c716a7-30a5-45f9-adbb-431118668991"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"CloseCaseScriptTask",
				Position = new Point(932, 20),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,115,206,201,47,78,117,78,44,78,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,225,243,46,39,25,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaParallelGateway CreateParallelGateway1ParallelGateway() {
			ProcessSchemaParallelGateway gateway = new ProcessSchemaParallelGateway(this) {
				UId = new Guid("1f6c3ee1-6122-4b11-b104-a0e1410eaa35"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("e9e1e6de-7066-4eb1-bbb4-5b75b13d4f56"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"ParallelGateway1",
				Position = new Point(329, 160),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateIntermediateCatchSignal1IntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("a09882fe-81f6-4ef9-9e42-724756f47811"),
				AttachedToUId = Guid.Empty,
				BackgroundModePriority = BackgroundModePriority.Inherited,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = false,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"IntermediateCatchSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(427, 70),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("a71adaea-3464-4dee-bb4f-c7a535450ad7");
			InitializeIntermediateCatchSignal1Parameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("45a66392-0072-4438-921e-1b2982c9157f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"),
				Name = @"TerminateEvent1",
				Position = new Point(526, 70),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ReevaluateCaseLevelRequestProcess(userConnection);
		}

		public override object Clone() {
			return new ReevaluateCaseLevelRequestProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c"));
		}

		#endregion

	}

	#endregion

	#region Class: ReevaluateCaseLevelRequestProcess

	/// <exclude/>
	public class ReevaluateCaseLevelRequestProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, ReevaluateCaseLevelRequestProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: SubProcessSendEmailFlowElement

		/// <exclude/>
		public class SubProcessSendEmailFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public SubProcessSendEmailFlowElement(UserConnection userConnection, ReevaluateCaseLevelRequestProcess process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41");
			}

			#endregion

			#region Properties: Public

			public Guid CaseId {
				get {
					return GetParameterValue<Guid>("CaseId");
				}
				set {
					SetParameterValue("CaseId", value);
				}
			}

			public Guid TemplateId {
				get {
					return GetParameterValue<Guid>("TemplateId");
				}
				set {
					SetParameterValue("TemplateId", value);
				}
			}

			public string SenderEmail {
				get {
					return GetParameterValue<string>("SenderEmail");
				}
				set {
					SetParameterValue("SenderEmail", value);
				}
			}

			public string Subject {
				get {
					return GetParameterValue<string>("Subject");
				}
				set {
					SetParameterValue("Subject", value);
				}
			}

			public Guid ParentActivityId {
				get {
					return GetParameterValue<Guid>("ParentActivityId");
				}
				set {
					SetParameterValue("ParentActivityId", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (ReevaluateCaseLevelRequestProcess)owner;
				Name = "SubProcessSendEmail";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (ReevaluateCaseLevelRequestProcess)Owner;
				SetParameterValue("CaseId", (Guid)((process.CaseRecordId)));
				SetParameterValue("SenderEmail", new LocalizableString(((String)SysSettings.GetValue(UserConnection, "SupportServiceEmail"))));
				SetParameterValue("TemplateId", (Guid)((process.EmailTemplateId)));
			}

			#endregion

		}

		#endregion

		#region Class: CatchTimerToReevaluateFirstFlowElement

		/// <exclude/>
		public class CatchTimerToReevaluateFirstFlowElement : ProcessIntermediateCatchTimerEvent
		{

			#region Constructors: Public

			public CatchTimerToReevaluateFirstFlowElement(UserConnection userConnection, ReevaluateCaseLevelRequestProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchTimerEvent";
				Name = "CatchTimerToReevaluateFirst";
				IsLogging = true;
				SchemaElementUId = new Guid("553ce2c0-4662-49b8-a937-de141892e8e4");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private int _startOffset = 0;
			public override int StartOffset {
				get {
					return _startOffset;
				}
				set {
					_startOffset = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: CatchTimerToReevaluateSecondFlowElement

		/// <exclude/>
		public class CatchTimerToReevaluateSecondFlowElement : ProcessIntermediateCatchTimerEvent
		{

			#region Constructors: Public

			public CatchTimerToReevaluateSecondFlowElement(UserConnection userConnection, ReevaluateCaseLevelRequestProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchTimerEvent";
				Name = "CatchTimerToReevaluateSecond";
				IsLogging = true;
				SchemaElementUId = new Guid("7ac2cdf4-9c14-4cf8-b583-3980fb41c88c");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private int _startOffset = 0;
			public override int StartOffset {
				get {
					return _startOffset;
				}
				set {
					_startOffset = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ParallelGateway1FlowElement

		/// <exclude/>
		public class ParallelGateway1FlowElement : ProcessParallelGateway
		{

			public ParallelGateway1FlowElement(UserConnection userConnection, ReevaluateCaseLevelRequestProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessParallelGateway";
				Name = "ParallelGateway1";
				IsLogging = true;
				SchemaElementUId = new Guid("1f6c3ee1-6122-4b11-b104-a0e1410eaa35");
				CreatedInSchemaUId = process.InternalSchemaUId;
				IncomingTokens = new Dictionary<string, bool> { { "StartFirstTimerProcessingScriptTask", false }, };
				SerializeToDB = Owner.SerializeToDB;
			}

		}

		#endregion

		#region Class: IntermediateCatchSignal1FlowElement

		/// <exclude/>
		public class IntermediateCatchSignal1FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignal1FlowElement(UserConnection userConnection, ReevaluateCaseLevelRequestProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignal1";
				IsLogging = true;
				SchemaElementUId = new Guid("a09882fe-81f6-4ef9-9e42-724756f47811");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = false;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",""$values"":[""a71adaea-3464-4dee-bb4f-c7a535450ad7""]}";
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\"",\""key\"":\""\""}"",""dataSourceFilters"":""{\""items\"":{},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\""}""}";
				_recordId = () => (Guid)((process.CaseRecordId));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _recordId;
			public override Guid RecordId {
				get {
					return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
				}
				set {
					_recordId = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		public ReevaluateCaseLevelRequestProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ReevaluateCaseLevelRequestProcess";
			SchemaUId = new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_caseClosureCode = () => { return (Guid)(new Guid("b69f315c-f36b-1410-159b-0050ba5d6c38")); };
			_caseCloseStatus = () => { return (Guid)(new Guid("3e7f420c-f46b-1410-fc9a-0050ba5d6c38")); };
			_emailTemplateId = () => { return (Guid)(new Guid("291b7433-d6ca-43da-b194-2590d86369b2")); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6b800a1f-ee38-4c6e-bd67-278a57544c2c");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ReevaluateCaseLevelRequestProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ReevaluateCaseLevelRequestProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid CaseRecordId {
			get;
			set;
		}

		public virtual bool IsCloseAndExit {
			get;
			set;
		}

		private Func<Guid> _caseClosureCode;
		public virtual Guid CaseClosureCode {
			get {
				return (_caseClosureCode ?? (_caseClosureCode = () => Guid.Empty)).Invoke();
			}
			set {
				_caseClosureCode = () => { return value; };
			}
		}

		private Func<Guid> _caseCloseStatus;
		public virtual Guid CaseCloseStatus {
			get {
				return (_caseCloseStatus ?? (_caseCloseStatus = () => Guid.Empty)).Invoke();
			}
			set {
				_caseCloseStatus = () => { return value; };
			}
		}

		private Func<Guid> _emailTemplateId;
		public virtual Guid EmailTemplateId {
			get {
				return (_emailTemplateId ?? (_emailTemplateId = () => Guid.Empty)).Invoke();
			}
			set {
				_emailTemplateId = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessTerminateEvent _terminate1086974;
		public ProcessTerminateEvent Terminate1086974 {
			get {
				return _terminate1086974 ?? (_terminate1086974 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1086974",
					SchemaElementUId = new Guid("a92db02c-08c7-4f4a-881b-032d16da77f6"),
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
					SchemaElementUId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
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
					SchemaElementUId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway111111111111111111;
		public ProcessExclusiveGateway ExclusiveGateway111111111111111111 {
			get {
				return _exclusiveGateway111111111111111111 ?? (_exclusiveGateway111111111111111111 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway111111111111111111",
					SchemaElementUId = new Guid("cd92481c-0570-43b4-b4b9-f7abce8bbe5a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway111111111111111111.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _startFirstTimerProcessingScriptTask;
		public ProcessScriptTask StartFirstTimerProcessingScriptTask {
			get {
				return _startFirstTimerProcessingScriptTask ?? (_startFirstTimerProcessingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "StartFirstTimerProcessingScriptTask",
					SchemaElementUId = new Guid("14bba315-e0f3-4300-b097-2c089d9cdb14"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = StartFirstTimerProcessingScriptTaskExecute,
				});
			}
		}

		private SubProcessSendEmailFlowElement _subProcessSendEmail;
		public SubProcessSendEmailFlowElement SubProcessSendEmail {
			get {
				return _subProcessSendEmail ?? ((_subProcessSendEmail) = new SubProcessSendEmailFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private CatchTimerToReevaluateFirstFlowElement _catchTimerToReevaluateFirst;
		public CatchTimerToReevaluateFirstFlowElement CatchTimerToReevaluateFirst {
			get {
				return _catchTimerToReevaluateFirst ?? ((_catchTimerToReevaluateFirst) = new CatchTimerToReevaluateFirstFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _startSecondTimerProcessingScriptTask;
		public ProcessScriptTask StartSecondTimerProcessingScriptTask {
			get {
				return _startSecondTimerProcessingScriptTask ?? (_startSecondTimerProcessingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "StartSecondTimerProcessingScriptTask",
					SchemaElementUId = new Guid("bf1065a6-92fd-4c15-9139-11de754f136e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = StartSecondTimerProcessingScriptTaskExecute,
				});
			}
		}

		private CatchTimerToReevaluateSecondFlowElement _catchTimerToReevaluateSecond;
		public CatchTimerToReevaluateSecondFlowElement CatchTimerToReevaluateSecond {
			get {
				return _catchTimerToReevaluateSecond ?? ((_catchTimerToReevaluateSecond) = new CatchTimerToReevaluateSecondFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _closeCaseScriptTask;
		public ProcessScriptTask CloseCaseScriptTask {
			get {
				return _closeCaseScriptTask ?? (_closeCaseScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CloseCaseScriptTask",
					SchemaElementUId = new Guid("d2c716a7-30a5-45f9-adbb-431118668991"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CloseCaseScriptTaskExecute,
				});
			}
		}

		private ParallelGateway1FlowElement _parallelGateway1;
		public ParallelGateway1FlowElement ParallelGateway1 {
			get {
				return _parallelGateway1 ?? ((_parallelGateway1) = new ParallelGateway1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private IntermediateCatchSignal1FlowElement _intermediateCatchSignal1;
		public IntermediateCatchSignal1FlowElement IntermediateCatchSignal1 {
			get {
				return _intermediateCatchSignal1 ?? ((_intermediateCatchSignal1) = new IntermediateCatchSignal1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("45a66392-0072-4438-921e-1b2982c9157f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow165867;
		public ProcessConditionalFlow ConditionalSequenceFlow165867 {
			get {
				return _conditionalSequenceFlow165867 ?? (_conditionalSequenceFlow165867 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow165867",
					SchemaElementUId = new Guid("b721b4be-1338-4df2-b3e6-08a78ca1c1eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow262574684;
		public ProcessConditionalFlow ConditionalSequenceFlow262574684 {
			get {
				return _conditionalSequenceFlow262574684 ?? (_conditionalSequenceFlow262574684 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow262574684",
					SchemaElementUId = new Guid("c863baaa-bf59-4331-825f-f0e475e77b99"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessToken _startSecondTimerProcessingScriptTaskSubProcessSendEmailToken;
		public ProcessToken StartSecondTimerProcessingScriptTaskSubProcessSendEmailToken {
			get {
				return _startSecondTimerProcessingScriptTaskSubProcessSendEmailToken ?? (_startSecondTimerProcessingScriptTaskSubProcessSendEmailToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "StartSecondTimerProcessingScriptTaskSubProcessSendEmailToken",
					SchemaElementUId = new Guid("1f1e1121-e326-483d-9cc4-320bb89f18fe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Terminate1086974.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1086974 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[StartSignal2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal2 };
			FlowElements[ExclusiveGateway111111111111111111.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway111111111111111111 };
			FlowElements[StartFirstTimerProcessingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { StartFirstTimerProcessingScriptTask };
			FlowElements[SubProcessSendEmail.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessSendEmail };
			FlowElements[CatchTimerToReevaluateFirst.SchemaElementUId] = new Collection<ProcessFlowElement> { CatchTimerToReevaluateFirst };
			FlowElements[StartSecondTimerProcessingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSecondTimerProcessingScriptTask };
			FlowElements[CatchTimerToReevaluateSecond.SchemaElementUId] = new Collection<ProcessFlowElement> { CatchTimerToReevaluateSecond };
			FlowElements[CloseCaseScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CloseCaseScriptTask };
			FlowElements[ParallelGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ParallelGateway1 };
			FlowElements[IntermediateCatchSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignal1 };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[StartSecondTimerProcessingScriptTaskSubProcessSendEmailToken.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSecondTimerProcessingScriptTaskSubProcessSendEmailToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1086974":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway111111111111111111", e.Context.SenderName));
						break;
					case "StartSignal2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway111111111111111111", e.Context.SenderName));
						break;
					case "ExclusiveGateway111111111111111111":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartFirstTimerProcessingScriptTask", e.Context.SenderName));
						break;
					case "StartFirstTimerProcessingScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGateway1", e.Context.SenderName));
						if (ConditionalSequenceFlow262574684ExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1086974", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "StartFirstTimerProcessingScriptTask");
						break;
					case "SubProcessSendEmail":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CatchTimerToReevaluateSecond", e.Context.SenderName));
						break;
					case "CatchTimerToReevaluateFirst":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartSecondTimerProcessingScriptTask", e.Context.SenderName));
						break;
					case "StartSecondTimerProcessingScriptTask":
						if (ConditionalSequenceFlow165867ExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1086974", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartSecondTimerProcessingScriptTaskSubProcessSendEmailToken", e.Context.SenderName));
						Log.ErrorFormat(DeadEndGatewayLogMessage, "StartSecondTimerProcessingScriptTask");
						break;
					case "CatchTimerToReevaluateSecond":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CloseCaseScriptTask", e.Context.SenderName));
						break;
					case "CloseCaseScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1086974", e.Context.SenderName));
						break;
					case "ParallelGateway1":
						if (ParallelGateway1.IsAllPreviousFlowElementsExecuted()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignal1", e.Context.SenderName));
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CatchTimerToReevaluateFirst", e.Context.SenderName));
						}
						break;
					case "IntermediateCatchSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "StartSecondTimerProcessingScriptTaskSubProcessSendEmailToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SubProcessSendEmail", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow165867ExpressionExecute() {
			bool result = Convert.ToBoolean((IsCloseAndExit));
			Log.InfoFormat(ConditionalExpressionLogMessage, "StartSecondTimerProcessingScriptTask", "ConditionalSequenceFlow165867", "(IsCloseAndExit)", result);
			return result;
		}

		private bool ConditionalSequenceFlow262574684ExpressionExecute() {
			bool result = Convert.ToBoolean((IsCloseAndExit));
			Log.InfoFormat(ConditionalExpressionLogMessage, "StartFirstTimerProcessingScriptTask", "ConditionalSequenceFlow262574684", "(IsCloseAndExit)", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CaseRecordId")) {
				writer.WriteValue("CaseRecordId", CaseRecordId, Guid.Empty);
			}
			if (!HasMapping("IsCloseAndExit")) {
				writer.WriteValue("IsCloseAndExit", IsCloseAndExit, false);
			}
			if (!HasMapping("CaseClosureCode")) {
				writer.WriteValue("CaseClosureCode", CaseClosureCode, Guid.Empty);
			}
			if (!HasMapping("CaseCloseStatus")) {
				writer.WriteValue("CaseCloseStatus", CaseCloseStatus, Guid.Empty);
			}
			if (!HasMapping("EmailTemplateId")) {
				writer.WriteValue("EmailTemplateId", EmailTemplateId, Guid.Empty);
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
			MetaPathParameterValues.Add("139575f5-1fcd-4511-8b6e-8fcca638b068", () => CaseRecordId);
			MetaPathParameterValues.Add("53928eba-9c90-4f6f-880b-0ca34bb3e439", () => IsCloseAndExit);
			MetaPathParameterValues.Add("1dd18ad4-0125-4b96-9e2d-6f2c3401376b", () => CaseClosureCode);
			MetaPathParameterValues.Add("1830b7fa-15a4-4836-af66-3bacbb623476", () => CaseCloseStatus);
			MetaPathParameterValues.Add("3b72b4ac-4c8f-4e6a-b29b-c81d60d4fcc7", () => EmailTemplateId);
			MetaPathParameterValues.Add("30fc86ce-b02b-4d00-8276-3f023dee5566", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("d46fb24f-a5d8-484e-bdc3-8065a7da191e", () => StartSignal1.EntitySchemaUId);
			MetaPathParameterValues.Add("45d8dd87-236b-4301-8a97-113a71a04d29", () => StartSignal2.RecordId);
			MetaPathParameterValues.Add("e405b39d-9a4f-4a66-a35a-707bdf998f1e", () => StartSignal2.EntitySchemaUId);
			MetaPathParameterValues.Add("4523623f-4dea-4fac-858f-a633a5eb3787", () => SubProcessSendEmail.CaseId);
			MetaPathParameterValues.Add("584a3f6a-da7e-45f5-b2f0-f83f8893a97f", () => SubProcessSendEmail.SenderEmail);
			MetaPathParameterValues.Add("b2a1f1d0-1269-45d3-93c3-a329c07567bf", () => SubProcessSendEmail.TemplateId);
			MetaPathParameterValues.Add("0e122291-0a8c-48ff-946f-4ca72f29f16f", () => SubProcessSendEmail.Subject);
			MetaPathParameterValues.Add("2413977c-0566-46eb-ab67-c15adc6a3fc5", () => SubProcessSendEmail.ParentActivityId);
			MetaPathParameterValues.Add("ee6b7a7e-e889-4f79-ade3-114e4895482d", () => CatchTimerToReevaluateFirst.StartOffset);
			MetaPathParameterValues.Add("4bbaea95-8c50-4f35-ac3c-93ca19ff3b2d", () => CatchTimerToReevaluateSecond.StartOffset);
			MetaPathParameterValues.Add("21c64e29-5cd9-4d94-8115-916f7cd44bda", () => IntermediateCatchSignal1.RecordId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CaseRecordId":
					if (!hasValueToRead) break;
					CaseRecordId = reader.GetValue<System.Guid>();
				break;
				case "IsCloseAndExit":
					if (!hasValueToRead) break;
					IsCloseAndExit = reader.GetValue<System.Boolean>();
				break;
				case "CaseClosureCode":
					if (!hasValueToRead) break;
					CaseClosureCode = reader.GetValue<System.Guid>();
				break;
				case "CaseCloseStatus":
					if (!hasValueToRead) break;
					CaseCloseStatus = reader.GetValue<System.Guid>();
				break;
				case "EmailTemplateId":
					if (!hasValueToRead) break;
					EmailTemplateId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool StartFirstTimerProcessingScriptTaskExecute(ProcessExecutingContext context) {
			StartFirstTimerProcessing();
			return true;
		}

		public virtual bool StartSecondTimerProcessingScriptTaskExecute(ProcessExecutingContext context) {
			StartSecondTimerProcessing();
			return true;
		}

		public virtual bool CloseCaseScriptTaskExecute(ProcessExecutingContext context) {
			CloseCase();
			return true;
		}

			
			public virtual void StartFirstTimerProcessing() {
				CaseRecordId = Guid.Empty;
			IsCloseAndExit = false;
			if (StartSignal1.RecordId != Guid.Empty) {
				CaseRecordId = StartSignal1.RecordId;
			}
			if (StartSignal2.RecordId != Guid.Empty) {
				CaseRecordId = StartSignal2.RecordId;
			}
			var firstNumberWaitingDays =(int)Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "FirstReevaluationWaitingDays");
			if(firstNumberWaitingDays == 0) {
				IsCloseAndExit = true;
				return;
			}
			var totalSeconds = new TimeSpan(firstNumberWaitingDays, 0, 0, 0).TotalSeconds;
			CatchTimerToReevaluateFirst.StartOffset = Convert.ToInt32(totalSeconds);
			
			}
			
			
			public virtual void StartSecondTimerProcessing() {
				if(GetIsSatisfactionUpdateLevelExist() || GetIsCaseLevelExist()){
				IsCloseAndExit = true;
				return;
			}
			var secondNumberWaitingDays =(int)Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "SecondReevaluationWaitingDays");
			if(secondNumberWaitingDays <= 0){
				IsCloseAndExit = true;
				return;
			}
			var totalSeconds = new TimeSpan(secondNumberWaitingDays, 0, 0, 0).TotalSeconds;
			CatchTimerToReevaluateSecond.StartOffset = Convert.ToInt32(totalSeconds);
			
			}
			
			
			public virtual bool GetIsCaseLevelExist() {
				var caseSelect = new Select(UserConnection)
				.Column(Func.Count("Id"))
				.From("Case")
				.Where("Id").IsEqual(Column.Parameter(CaseRecordId))
				.And("SatisfactionLevelId").Not().IsNull() as Select;
			return caseSelect.ExecuteScalar<int>() > 0;
			
			}
			
			
			public virtual bool GetIsSatisfactionUpdateLevelExist() {
				var satisfactionUpdateSelect =  new Select(UserConnection)
				.Column(Func.Count("Id"))
				.From("SatisfactionUpdate")
				.Where("CaseId").IsEqual(Column.Parameter(CaseRecordId)) as Select;
			return satisfactionUpdateSelect.ExecuteScalar<int>() > 0;
			
			}
			
			
			public virtual void CloseCase() {
				if(GetIsSatisfactionUpdateLevelExist() || GetIsCaseLevelExist()){
				IsCloseAndExit = true;
				return;
			}
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchema = entitySchemaManager.GetInstanceByName("Case");
			Entity entityCase = entitySchema.CreateEntity(UserConnection);
			if (entityCase.FetchFromDB(CaseRecordId))
			{
				entityCase.SetColumnValue("StatusId", CaseCloseStatus);
				entityCase.SetColumnValue("ClosureCodeId", CaseClosureCode);
				entityCase.SetColumnValue("ClosureDate", UserConnection.CurrentUser.GetCurrentDateTime());
				entityCase.Save();
			}
			
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
			var cloneItem = (ReevaluateCaseLevelRequestProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


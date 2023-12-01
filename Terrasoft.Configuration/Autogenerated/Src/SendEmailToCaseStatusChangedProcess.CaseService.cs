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
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SendEmailToCaseStatusChangedProcessSchema

	/// <exclude/>
	public class SendEmailToCaseStatusChangedProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SendEmailToCaseStatusChangedProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SendEmailToCaseStatusChangedProcessSchema(SendEmailToCaseStatusChangedProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendEmailToCaseStatusChangedProcess";
			UId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277");
			CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"Business process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateIsCloseAndExitParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("94883989-46c7-4825-b827-2c151618e017"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"IsCloseAndExit",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailTemplateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0d056708-d60e-42dd-86c1-f5efcfd86bef"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"EmailTemplate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e9f06e37-ba23-48d4-832c-0745bb5b6289"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"CaseRecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCloseStatusIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9fc90727-5ac3-4ea8-a541-e3baca1ade4f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"CloseStatusId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.99f35013-6b7a-47d6-b440-e3f1a0ba991c.3e7f420c-f46b-1410-fc9a-0050ba5d6c38#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailSenderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6adbdb8d-22e9-4e5f-91e9-ac5d02328433"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"EmailSender",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsCloseAndExitParameter());
			Parameters.Add(CreateEmailTemplateParameter());
			Parameters.Add(CreateCaseRecordIdParameter());
			Parameters.Add(CreateCloseStatusIdParameter());
			Parameters.Add(CreateEmailSenderParameter());
		}

		protected virtual void InitializeSubProcessSendEmailParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var caseIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2ea97d45-fb65-4126-9177-dd5587f15336"),
				ContainerUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{e9f06e37-ba23-48d4-832c-0745bb5b6289}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(caseIdParameter);
			var templateIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3f984456-427a-4177-9163-9b73842be371"),
				ContainerUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{0d056708-d60e-42dd-86c1-f5efcfd86bef}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(templateIdParameter);
			var senderEmailParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4ea09cbc-77f4-49ed-932b-bfc84d1131fb"),
				ContainerUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{6adbdb8d-22e9-4e5f-91e9-ac5d02328433}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(senderEmailParameter);
			var subjectParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e9652116-1fbc-423a-809f-5abee6bc90cb"),
				ContainerUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
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
				UId = new Guid("46ad5752-9bc9-40b5-8f41-4568b7813102"),
				ContainerUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
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
				UId = new Guid("b45094d5-b09f-4ac1-94fb-eb15b5624972"),
				ContainerUId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
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
				UId = new Guid("0ea1b5d8-4e6c-43d5-a7b7-f9bb4610ae41"),
				ContainerUId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
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
				UId = new Guid("ce8c0266-efa5-44a9-bff8-26d3da1ebeff"),
				ContainerUId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
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
				UId = new Guid("021c651a-8af8-4170-b888-138386e1329f"),
				ContainerUId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
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

		protected virtual void InitializeChangeDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("810b9374-7a6a-46db-896a-f030e43430f9"),
				ContainerUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3e718202-15ca-44b5-b786-1c807f779f66"),
				ContainerUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"IsMatchConditions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6ff8853b-20dd-41d4-8339-8a3541af22e2"),
				ContainerUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,86,81,79,219,48,16,254,43,40,207,24,57,78,226,196,188,33,198,38,94,0,1,226,133,242,224,216,231,54,90,154,68,182,203,198,170,254,247,93,146,182,148,173,64,138,180,1,125,105,123,250,124,254,238,124,223,221,205,3,85,74,231,206,228,20,130,195,224,26,172,149,174,54,254,224,107,81,122,176,223,108,61,107,130,253,192,129,45,100,89,252,2,221,219,79,116,225,191,72,47,241,200,124,244,232,97,20,28,142,182,251,24,5,251,163,160,240,48,117,136,193,35,60,97,38,11,25,16,99,210,148,196,218,80,146,81,170,137,226,198,132,25,163,17,215,170,71,62,231,252,184,158,54,210,66,127,71,231,222,116,63,175,31,154,22,26,162,65,117,144,194,213,213,210,24,181,36,220,73,37,243,18,52,254,247,118,6,104,242,182,152,98,52,112,93,76,225,66,90,188,171,245,83,183,38,4,25,89,186,22,85,130,241,39,63,27,11,206,21,117,245,26,185,114,54,173,54,209,232,0,214,127,151,116,104,199,177,69,94,72,63,233,92,156,34,173,69,199,242,104,60,182,48,150,190,184,223,36,241,29,30,58,220,176,252,225,1,141,175,116,35,203,25,108,220,249,52,146,99,217,248,62,160,254,122,4,216,98,60,25,28,235,58,99,175,133,203,208,216,172,192,3,125,110,141,129,113,52,222,183,134,222,203,234,231,40,184,61,117,231,63,42,176,87,106,2,83,217,103,237,238,0,173,127,24,78,74,152,66,229,15,231,34,205,179,156,38,156,40,202,5,137,69,170,137,212,97,66,18,134,41,229,144,10,197,211,5,30,88,19,58,156,43,200,20,101,156,19,48,50,33,113,44,5,201,141,201,8,227,58,210,50,132,28,140,89,220,245,196,11,215,148,242,225,102,205,239,88,58,216,115,94,250,153,219,83,19,89,141,65,31,92,130,170,173,94,102,190,253,66,92,130,79,152,69,52,34,194,132,72,139,243,148,136,68,0,201,115,78,33,74,147,140,50,131,133,130,159,182,132,144,171,50,145,32,60,76,20,137,105,22,18,1,9,158,85,105,72,163,52,77,5,55,47,167,251,180,122,78,70,241,231,148,209,85,151,226,97,82,26,150,190,45,101,24,190,172,165,21,135,86,79,96,192,66,165,160,47,195,117,164,109,57,108,194,158,202,174,109,149,183,31,74,120,93,196,27,194,91,86,43,42,37,130,60,199,102,164,21,71,17,101,140,100,113,20,18,157,41,148,8,51,160,85,159,193,245,133,151,80,55,80,65,95,243,143,242,29,236,232,47,97,61,58,68,77,220,181,207,206,88,146,164,218,8,34,149,148,36,78,114,74,132,100,168,90,16,185,142,98,129,61,50,124,69,21,238,108,86,150,207,41,131,109,83,6,251,240,202,232,218,227,48,97,12,203,224,238,194,56,66,203,184,2,120,89,26,117,229,165,242,253,222,208,61,196,138,97,215,243,202,122,92,40,89,158,55,96,229,210,49,221,158,251,39,143,214,14,14,91,215,126,139,14,187,155,86,161,231,97,168,69,28,171,182,16,177,199,71,202,16,145,209,152,176,28,210,156,233,136,131,164,152,68,220,140,218,216,175,234,153,85,203,77,196,245,43,209,155,86,157,119,88,96,118,217,73,182,110,5,67,154,205,167,157,223,255,118,26,191,195,160,221,117,118,62,51,145,222,242,232,79,102,199,208,86,191,115,47,127,135,22,189,115,215,253,47,205,108,17,44,126,3,55,20,2,244,219,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("84e64196-ae90-4d27-ba05-56b7d0cb5cf6"),
				ContainerUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,193,110,219,48,12,134,95,101,16,122,140,2,201,150,45,57,215,245,18,160,45,130,165,235,101,222,129,22,169,214,128,99,7,178,51,160,11,252,238,147,85,123,105,138,238,52,29,100,136,228,79,254,248,204,51,187,25,94,143,196,54,236,145,188,135,190,115,195,250,107,231,105,189,243,157,165,190,95,223,117,22,154,250,55,84,13,237,192,195,129,6,242,79,208,156,168,191,171,251,97,245,229,90,198,86,236,230,87,204,178,205,143,51,219,14,116,248,190,197,208,157,20,90,13,185,228,152,38,146,43,204,128,23,153,70,142,70,83,106,133,33,172,138,32,182,93,115,58,180,247,52,192,14,134,23,182,57,179,216,45,52,208,34,79,4,10,193,73,17,112,101,80,242,194,161,229,42,211,137,179,104,80,201,138,141,43,214,219,23,58,64,28,122,17,75,169,195,92,87,112,147,232,44,72,82,197,141,146,146,75,155,231,82,102,150,10,139,147,120,174,191,8,167,32,214,253,177,129,215,167,207,114,199,43,36,239,179,231,242,141,108,201,54,229,191,216,206,223,125,180,124,77,247,35,216,146,173,74,182,239,78,222,78,29,69,120,220,190,179,21,135,196,146,15,207,133,100,136,180,167,166,153,35,183,48,192,82,184,132,59,172,93,77,184,109,247,11,192,216,69,204,135,127,114,45,231,205,219,255,200,238,161,133,103,242,15,1,192,197,251,95,151,143,1,227,210,184,74,138,76,104,233,184,38,40,184,162,60,225,97,21,194,50,201,162,114,169,14,63,217,37,81,253,141,28,121,106,45,93,27,147,121,69,105,158,73,110,28,37,92,201,44,236,4,162,224,96,68,138,42,55,41,98,58,235,251,72,123,90,225,217,215,132,106,100,227,248,115,252,3,236,27,126,200,54,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bfb97948-4d1b-4c6f-a455-9292aaee855e"),
				ContainerUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaSubProcess subprocesssendemail = CreateSubProcessSendEmailSubProcess();
			FlowElements.Add(subprocesssendemail);
			ProcessSchemaStartSignalEvent startsignal1 = CreateStartSignal1StartSignalEvent();
			FlowElements.Add(startsignal1);
			ProcessSchemaStartSignalEvent startsignal2 = CreateStartSignal2StartSignalEvent();
			FlowElements.Add(startsignal2);
			ProcessSchemaScriptTask scripttask = CreateScriptTaskScriptTask();
			FlowElements.Add(scripttask);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("fcb1629b-22ff-42cb-9266-b81588ed68d3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("87b14dd0-8690-4c2d-970a-35c3656cd9f9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("f9180d1b-7e24-4b75-811a-70caff864c67"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2abdea98-cf8b-47f8-8868-0da495323261"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(487, 72));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("21cdafae-cfe7-4c14-85dd-a45603176746"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("526b358c-eb90-47e8-8a27-4e49156b7f73"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(734, 72));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("ebcf97b5-1631-42e6-8413-edda66493717"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{94883989-46c7-4825-b827-2c151618e017}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2abdea98-cf8b-47f8-8868-0da495323261"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("526b358c-eb90-47e8-8a27-4e49156b7f73"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("5a22b753-52b0-43ce-9a7b-c55286215695"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("815b13ec-93a8-4af3-a0f5-cbff738b1263"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("87b14dd0-8690-4c2d-970a-35c3656cd9f9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(320, 325));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("936b82a8-012d-4b83-b3d5-481528a4b911"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("87b14dd0-8690-4c2d-970a-35c3656cd9f9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2abdea98-cf8b-47f8-8868-0da495323261"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("87200ec3-22b2-494e-824f-744d1f9062d8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("87200ec3-22b2-494e-824f-744d1f9062d8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
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
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(82, 191),
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
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
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
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"StartSignal2",
				NewEntityChangedColumns = false,
				Position = new Point(82, 312),
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

		protected virtual ProcessSchemaScriptTask CreateScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("87b14dd0-8690-4c2d-970a-35c3656cd9f9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"ScriptTask",
				Position = new Point(286, 177),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,89,221,143,211,56,16,127,46,18,255,67,232,3,74,165,42,112,251,10,172,4,221,46,87,137,5,174,237,30,15,136,135,144,78,119,45,165,73,177,157,133,234,180,255,251,205,216,78,108,39,78,63,216,69,39,161,107,236,249,205,167,127,158,241,222,165,60,154,164,2,230,144,149,124,53,91,69,111,162,247,21,91,37,211,205,86,238,94,61,125,114,135,235,89,42,225,166,228,187,240,170,144,169,172,68,120,141,137,171,42,151,44,79,139,155,42,189,129,105,145,126,207,129,118,94,11,224,147,178,40,32,147,172,44,146,247,32,103,226,18,16,136,215,155,226,225,116,147,178,252,10,132,64,73,5,243,193,192,12,71,8,63,19,147,188,20,240,182,88,77,127,49,137,144,235,52,23,128,11,108,29,197,11,153,114,185,96,55,69,154,255,149,52,174,61,115,45,28,69,255,61,125,50,104,185,30,148,67,204,251,14,236,217,111,194,158,181,96,117,156,200,153,84,248,17,64,185,37,112,158,138,114,45,19,140,213,154,221,84,60,85,225,50,251,174,49,178,76,50,16,193,248,249,33,30,71,195,5,96,172,40,166,203,146,236,251,84,44,84,230,38,183,24,86,80,250,85,96,217,58,14,153,163,29,83,229,64,107,211,95,144,85,178,228,104,101,1,63,123,45,221,171,179,99,162,27,54,50,101,224,169,74,230,85,17,171,207,157,220,75,94,81,234,7,28,208,224,162,254,169,194,75,255,45,170,239,159,121,153,97,41,53,246,36,164,75,37,199,85,218,148,237,37,195,92,57,69,69,95,65,252,48,222,78,11,201,228,110,145,221,194,38,253,167,2,190,107,121,146,184,27,174,210,2,107,150,99,2,72,147,10,49,34,37,111,87,171,73,153,87,155,34,30,234,152,132,86,38,230,228,169,53,93,40,115,16,101,126,7,102,11,26,20,4,75,236,70,71,86,121,165,55,126,76,55,176,71,88,237,28,142,18,218,22,48,171,44,100,154,201,144,197,159,126,22,192,213,194,139,23,180,116,201,114,9,92,208,150,152,126,79,56,22,21,232,175,95,152,188,253,156,114,84,65,91,98,253,113,82,110,182,41,103,162,44,150,187,45,36,211,31,85,154,99,236,102,171,97,171,62,70,13,59,9,208,241,54,254,224,97,208,191,15,214,23,157,105,71,28,15,114,81,229,249,136,10,221,227,60,187,135,192,201,46,227,239,191,105,94,193,107,58,253,231,54,89,51,29,242,129,67,140,199,1,44,140,128,22,247,211,125,24,228,123,89,230,231,113,187,64,84,6,21,158,45,234,35,129,90,213,162,65,48,98,207,172,14,77,10,202,212,106,187,66,255,205,1,185,86,63,186,20,116,1,121,186,131,213,199,82,178,53,203,20,69,12,71,132,48,64,166,144,177,162,168,11,148,164,92,107,243,81,92,200,88,165,197,108,252,114,11,28,226,161,62,191,88,162,51,161,106,36,54,2,77,65,197,126,181,104,97,164,12,115,177,44,97,179,205,81,149,198,40,98,181,62,232,128,244,17,27,129,47,128,223,177,12,148,137,34,81,49,169,104,209,117,111,185,205,81,251,56,122,48,252,84,72,182,81,139,115,248,81,129,144,26,89,225,170,212,12,6,58,5,137,230,75,208,84,121,31,1,50,152,77,83,166,143,238,41,101,93,75,232,178,84,40,37,157,242,19,48,62,233,253,6,65,29,59,107,199,155,26,206,84,83,63,189,107,229,208,37,215,110,71,17,96,224,48,2,145,70,119,175,186,81,49,238,105,145,193,187,29,149,127,108,233,27,81,12,99,104,73,90,104,193,24,158,11,242,144,129,160,40,88,121,188,211,101,118,123,201,203,205,197,187,80,229,234,200,12,40,158,120,1,151,2,239,229,73,185,130,11,88,119,59,175,129,113,211,223,183,144,156,21,55,173,174,130,67,251,194,222,225,29,41,37,238,84,93,133,202,98,231,28,107,21,3,21,145,137,167,4,207,210,178,212,154,98,227,231,192,113,18,161,157,234,112,24,15,207,59,165,188,254,125,132,168,209,107,216,162,149,253,73,197,57,202,210,87,242,194,252,164,189,75,134,169,28,213,248,148,3,21,186,37,223,225,161,20,16,135,98,54,142,202,74,118,162,62,170,203,245,24,51,73,74,185,217,65,49,150,220,119,29,78,239,160,137,161,223,216,212,251,233,159,123,167,141,4,34,54,226,80,117,34,98,161,172,31,157,156,239,215,90,240,60,148,247,225,162,218,110,75,236,102,53,57,41,42,69,183,116,160,76,11,252,42,220,113,105,195,212,255,211,105,177,182,218,254,234,236,225,13,150,75,190,243,42,111,26,174,51,183,75,241,110,128,224,14,18,189,22,245,176,209,94,85,247,152,93,105,53,57,103,39,119,57,104,116,221,232,88,197,227,222,174,90,157,59,125,45,92,48,65,221,57,5,82,73,17,220,232,241,12,171,173,82,247,145,110,83,199,205,196,247,135,244,52,77,239,216,153,60,155,118,15,220,212,97,62,114,93,17,186,247,59,179,205,159,93,10,208,175,226,222,48,16,134,186,42,228,249,75,125,186,189,66,169,171,182,43,244,245,229,183,125,215,95,167,225,168,91,169,240,124,236,116,85,158,190,5,14,65,112,96,224,154,118,4,130,183,79,7,187,158,173,255,134,124,11,135,166,186,105,191,164,119,119,181,121,89,235,94,163,81,105,118,27,197,29,35,34,86,244,69,184,38,219,142,140,186,254,188,47,39,103,66,163,214,73,232,2,250,30,18,252,135,102,111,220,50,198,1,148,230,163,29,78,58,185,81,166,154,15,109,164,177,99,145,65,245,221,108,95,53,109,223,198,45,11,146,207,28,59,72,190,115,132,52,174,185,70,6,33,210,246,194,236,105,208,53,220,38,230,224,75,78,176,237,119,170,60,179,247,51,106,169,175,233,228,90,102,31,203,159,166,101,140,205,252,226,22,194,74,227,78,31,58,152,7,237,211,33,183,42,188,57,185,158,83,246,238,114,27,198,240,14,123,143,24,143,216,202,27,207,195,82,106,100,49,147,185,145,91,107,2,214,97,248,250,173,238,76,28,249,135,48,114,123,244,30,239,69,15,227,205,196,71,28,226,204,51,148,142,157,110,100,58,241,113,46,147,185,122,38,50,206,57,97,170,119,83,61,122,119,128,3,115,220,77,160,154,192,56,140,135,211,226,46,182,109,222,225,42,109,184,45,110,27,73,204,22,86,98,187,200,71,152,162,247,12,210,118,230,116,252,160,24,95,177,2,167,69,17,215,0,54,23,138,0,66,100,202,240,130,108,138,119,52,178,186,205,108,238,205,229,228,137,58,139,214,130,131,10,52,91,187,135,97,212,244,236,193,49,183,233,160,155,190,216,173,19,55,82,253,151,184,177,158,87,244,246,122,94,251,68,63,247,221,40,77,191,70,78,211,48,123,76,211,70,102,249,45,91,205,114,1,139,253,50,116,43,172,112,253,178,21,230,10,55,229,245,24,213,245,224,218,114,13,62,161,178,30,244,230,211,255,232,211,95,160,7,237,236,107,39,124,157,150,234,218,22,187,207,90,206,196,206,65,96,63,168,58,80,204,82,79,161,99,149,120,251,222,68,47,189,44,179,2,83,42,77,150,103,234,71,155,248,76,62,146,89,33,203,158,235,217,231,19,19,249,113,20,8,86,40,230,181,156,206,100,80,236,212,90,240,129,187,205,206,159,72,227,99,208,233,201,53,31,165,194,164,173,102,60,157,209,163,24,143,109,54,176,98,104,203,73,156,55,247,57,111,254,7,56,111,86,27,22,230,189,160,221,62,243,117,231,161,250,165,227,224,172,66,13,207,85,154,241,82,152,166,47,220,9,236,227,214,160,129,222,185,147,244,32,75,214,252,110,213,153,180,74,190,179,47,75,93,127,237,223,212,90,179,150,210,223,212,6,205,206,56,100,213,64,244,222,138,149,9,61,165,211,255,228,218,122,121,186,215,93,127,107,46,62,170,2,22,248,69,172,83,21,240,69,197,239,96,231,12,23,164,234,249,243,227,254,46,172,95,194,129,146,58,67,191,68,61,75,52,5,98,211,253,200,37,18,68,239,77,136,23,164,253,127,184,164,87,60,251,82,127,252,223,55,221,15,255,3,58,196,173,22,203,31,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaSubProcess CreateSubProcessSendEmailSubProcess() {
			ProcessSchemaSubProcess schemaSubProcessSendEmail = new ProcessSchemaSubProcess(this) {
				UId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"SubProcessSendEmail",
				Position = new Point(591, 45),
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

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("526b358c-eb90-47e8-8a27-4e49156b7f73"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"Terminate1",
				Position = new Point(721, 191),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(191, 298),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("2abdea98-cf8b-47f8-8868-0da495323261"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("877593b0-6738-40f5-9061-ed61292b498c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277"),
				Name = @"ExclusiveGateway1",
				Position = new Point(460, 177),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb058002-0bf1-4e72-950d-847a882e3c69"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1e8b887e-ebaa-40ce-be6c-6b5e1191a3e4"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b964c921-e7ab-4448-9709-966667751d2e"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SendEmailToCaseStatusChangedProcess(userConnection);
		}

		public override object Clone() {
			return new SendEmailToCaseStatusChangedProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("22405112-0a8c-4444-870f-deb07a0f7277"));
		}

		#endregion

	}

	#endregion

	#region Class: SendEmailToCaseStatusChangedProcess

	/// <exclude/>
	public class SendEmailToCaseStatusChangedProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendEmailToCaseStatusChangedProcess process)
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

			public SubProcessSendEmailFlowElement(UserConnection userConnection, SendEmailToCaseStatusChangedProcess process)
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
				var process = (SendEmailToCaseStatusChangedProcess)owner;
				Name = "SubProcessSendEmail";
				SerializeToDB = true;
				IsLogging = false;
				SchemaElementUId = new Guid("3ad05c84-c9fa-4316-bb75-2bcaa742c41b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (SendEmailToCaseStatusChangedProcess)Owner;
				SetParameterValue("CaseId", (Guid)((process.CaseRecordId)));
				SetParameterValue("TemplateId", (Guid)((process.EmailTemplate)));
				SetParameterValue("SenderEmail", new LocalizableString((process.EmailSender)));
			}

			#endregion

		}

		#endregion

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, SendEmailToCaseStatusChangedProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = false;
				SchemaElementUId = new Guid("a9434382-a448-40ee-b92f-07bbc051af96");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Owner", () => _recordColumnValues_Owner.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Owner;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private bool _isMatchConditions = true;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,86,81,79,219,48,16,254,43,40,207,24,57,78,226,196,188,33,198,38,94,0,1,226,133,242,224,216,231,54,90,154,68,182,203,198,170,254,247,93,146,182,148,173,64,138,180,1,125,105,123,250,124,254,238,124,223,221,205,3,85,74,231,206,228,20,130,195,224,26,172,149,174,54,254,224,107,81,122,176,223,108,61,107,130,253,192,129,45,100,89,252,2,221,219,79,116,225,191,72,47,241,200,124,244,232,97,20,28,142,182,251,24,5,251,163,160,240,48,117,136,193,35,60,97,38,11,25,16,99,210,148,196,218,80,146,81,170,137,226,198,132,25,163,17,215,170,71,62,231,252,184,158,54,210,66,127,71,231,222,116,63,175,31,154,22,26,162,65,117,144,194,213,213,210,24,181,36,220,73,37,243,18,52,254,247,118,6,104,242,182,152,98,52,112,93,76,225,66,90,188,171,245,83,183,38,4,25,89,186,22,85,130,241,39,63,27,11,206,21,117,245,26,185,114,54,173,54,209,232,0,214,127,151,116,104,199,177,69,94,72,63,233,92,156,34,173,69,199,242,104,60,182,48,150,190,184,223,36,241,29,30,58,220,176,252,225,1,141,175,116,35,203,25,108,220,249,52,146,99,217,248,62,160,254,122,4,216,98,60,25,28,235,58,99,175,133,203,208,216,172,192,3,125,110,141,129,113,52,222,183,134,222,203,234,231,40,184,61,117,231,63,42,176,87,106,2,83,217,103,237,238,0,173,127,24,78,74,152,66,229,15,231,34,205,179,156,38,156,40,202,5,137,69,170,137,212,97,66,18,134,41,229,144,10,197,211,5,30,88,19,58,156,43,200,20,101,156,19,48,50,33,113,44,5,201,141,201,8,227,58,210,50,132,28,140,89,220,245,196,11,215,148,242,225,102,205,239,88,58,216,115,94,250,153,219,83,19,89,141,65,31,92,130,170,173,94,102,190,253,66,92,130,79,152,69,52,34,194,132,72,139,243,148,136,68,0,201,115,78,33,74,147,140,50,131,133,130,159,182,132,144,171,50,145,32,60,76,20,137,105,22,18,1,9,158,85,105,72,163,52,77,5,55,47,167,251,180,122,78,70,241,231,148,209,85,151,226,97,82,26,150,190,45,101,24,190,172,165,21,135,86,79,96,192,66,165,160,47,195,117,164,109,57,108,194,158,202,174,109,149,183,31,74,120,93,196,27,194,91,86,43,42,37,130,60,199,102,164,21,71,17,101,140,100,113,20,18,157,41,148,8,51,160,85,159,193,245,133,151,80,55,80,65,95,243,143,242,29,236,232,47,97,61,58,68,77,220,181,207,206,88,146,164,218,8,34,149,148,36,78,114,74,132,100,168,90,16,185,142,98,129,61,50,124,69,21,238,108,86,150,207,41,131,109,83,6,251,240,202,232,218,227,48,97,12,203,224,238,194,56,66,203,184,2,120,89,26,117,229,165,242,253,222,208,61,196,138,97,215,243,202,122,92,40,89,158,55,96,229,210,49,221,158,251,39,143,214,14,14,91,215,126,139,14,187,155,86,161,231,97,168,69,28,171,182,16,177,199,71,202,16,145,209,152,176,28,210,156,233,136,131,164,152,68,220,140,218,216,175,234,153,85,203,77,196,245,43,209,155,86,157,119,88,96,118,217,73,182,110,5,67,154,205,167,157,223,255,118,26,191,195,160,221,117,118,62,51,145,222,242,232,79,102,199,208,86,191,115,47,127,135,22,189,115,215,253,47,205,108,17,44,126,3,55,20,2,244,219,13,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,193,110,219,48,12,134,95,101,16,122,140,2,201,150,45,57,215,245,18,160,45,130,165,235,101,222,129,22,169,214,128,99,7,178,51,160,11,252,238,147,85,123,105,138,238,52,29,100,136,228,79,254,248,204,51,187,25,94,143,196,54,236,145,188,135,190,115,195,250,107,231,105,189,243,157,165,190,95,223,117,22,154,250,55,84,13,237,192,195,129,6,242,79,208,156,168,191,171,251,97,245,229,90,198,86,236,230,87,204,178,205,143,51,219,14,116,248,190,197,208,157,20,90,13,185,228,152,38,146,43,204,128,23,153,70,142,70,83,106,133,33,172,138,32,182,93,115,58,180,247,52,192,14,134,23,182,57,179,216,45,52,208,34,79,4,10,193,73,17,112,101,80,242,194,161,229,42,211,137,179,104,80,201,138,141,43,214,219,23,58,64,28,122,17,75,169,195,92,87,112,147,232,44,72,82,197,141,146,146,75,155,231,82,102,150,10,139,147,120,174,191,8,167,32,214,253,177,129,215,167,207,114,199,43,36,239,179,231,242,141,108,201,54,229,191,216,206,223,125,180,124,77,247,35,216,146,173,74,182,239,78,222,78,29,69,120,220,190,179,21,135,196,146,15,207,133,100,136,180,167,166,153,35,183,48,192,82,184,132,59,172,93,77,184,109,247,11,192,216,69,204,135,127,114,45,231,205,219,255,200,238,161,133,103,242,15,1,192,197,251,95,151,143,1,227,210,184,74,138,76,104,233,184,38,40,184,162,60,225,97,21,194,50,201,162,114,169,14,63,217,37,81,253,141,28,121,106,45,93,27,147,121,69,105,158,73,110,28,37,92,201,44,236,4,162,224,96,68,138,42,55,41,98,58,235,251,72,123,90,225,217,215,132,106,100,227,248,115,252,3,236,27,126,200,54,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "224051120a8c4444870fdeb07a0f7277",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordColumnValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordColumnValues", getColumnValue);
					}
					return _recordColumnValues;
				}
				set {
					_recordColumnValues = value;
				}
			}

			#endregion

		}

		#endregion

		public SendEmailToCaseStatusChangedProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendEmailToCaseStatusChangedProcess";
			SchemaUId = new Guid("22405112-0a8c-4444-870f-deb07a0f7277");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_closeStatusId = () => { return (Guid)(new Guid("3e7f420c-f46b-1410-fc9a-0050ba5d6c38")); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("22405112-0a8c-4444-870f-deb07a0f7277");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SendEmailToCaseStatusChangedProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SendEmailToCaseStatusChangedProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual bool IsCloseAndExit {
			get;
			set;
		}

		public virtual Guid EmailTemplate {
			get;
			set;
		}

		public virtual Guid CaseRecordId {
			get;
			set;
		}

		private Func<Guid> _closeStatusId;
		public virtual Guid CloseStatusId {
			get {
				return (_closeStatusId ?? (_closeStatusId = () => Guid.Empty)).Invoke();
			}
			set {
				_closeStatusId = () => { return value; };
			}
		}

		public virtual string EmailSender {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
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
					SchemaElementUId = new Guid("d67fd76a-2fbe-4045-8049-736af35bdb13"),
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
					SchemaElementUId = new Guid("97b8b056-c069-497d-ad15-52df06e79c67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask;
		public ProcessScriptTask ScriptTask {
			get {
				return _scriptTask ?? (_scriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask",
					SchemaElementUId = new Guid("87b14dd0-8690-4c2d-970a-35c3656cd9f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTaskExecute,
				});
			}
		}

		private SubProcessSendEmailFlowElement _subProcessSendEmail;
		public SubProcessSendEmailFlowElement SubProcessSendEmail {
			get {
				return _subProcessSendEmail ?? ((_subProcessSendEmail) = new SubProcessSendEmailFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("526b358c-eb90-47e8-8a27-4e49156b7f73"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("2abdea98-cf8b-47f8-8868-0da495323261"),
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

		private ProcessConditionalFlow _conditionalSequenceFlow1;
		public ProcessConditionalFlow ConditionalSequenceFlow1 {
			get {
				return _conditionalSequenceFlow1 ?? (_conditionalSequenceFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1",
					SchemaElementUId = new Guid("ebcf97b5-1631-42e6-8413-edda66493717"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessToken _exclusiveGateway1SubProcessSendEmailToken;
		public ProcessToken ExclusiveGateway1SubProcessSendEmailToken {
			get {
				return _exclusiveGateway1SubProcessSendEmailToken ?? (_exclusiveGateway1SubProcessSendEmailToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "ExclusiveGateway1SubProcessSendEmailToken",
					SchemaElementUId = new Guid("e916b7b7-3aaa-42ba-b1df-806f1f74af71"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[StartSignal2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal2 };
			FlowElements[ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask };
			FlowElements[SubProcessSendEmail.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessSendEmail };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ExclusiveGateway1SubProcessSendEmailToken.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1SubProcessSendEmailToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask", e.Context.SenderName));
						break;
					case "StartSignal2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "ScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "SubProcessSendEmail":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1SubProcessSendEmailToken", e.Context.SenderName));
						break;
					case "ExclusiveGateway1SubProcessSendEmailToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SubProcessSendEmail", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((IsCloseAndExit));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow1", "(IsCloseAndExit)", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("IsCloseAndExit")) {
				writer.WriteValue("IsCloseAndExit", IsCloseAndExit, false);
			}
			if (!HasMapping("EmailTemplate")) {
				writer.WriteValue("EmailTemplate", EmailTemplate, Guid.Empty);
			}
			if (!HasMapping("CaseRecordId")) {
				writer.WriteValue("CaseRecordId", CaseRecordId, Guid.Empty);
			}
			if (!HasMapping("EmailSender")) {
				writer.WriteValue("EmailSender", EmailSender, null);
			}
			if (!HasMapping("CloseStatusId")) {
				writer.WriteValue("CloseStatusId", CloseStatusId, Guid.Empty);
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
			MetaPathParameterValues.Add("94883989-46c7-4825-b827-2c151618e017", () => IsCloseAndExit);
			MetaPathParameterValues.Add("0d056708-d60e-42dd-86c1-f5efcfd86bef", () => EmailTemplate);
			MetaPathParameterValues.Add("e9f06e37-ba23-48d4-832c-0745bb5b6289", () => CaseRecordId);
			MetaPathParameterValues.Add("9fc90727-5ac3-4ea8-a541-e3baca1ade4f", () => CloseStatusId);
			MetaPathParameterValues.Add("6adbdb8d-22e9-4e5f-91e9-ac5d02328433", () => EmailSender);
			MetaPathParameterValues.Add("b45094d5-b09f-4ac1-94fb-eb15b5624972", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("0ea1b5d8-4e6c-43d5-a7b7-f9bb4610ae41", () => StartSignal1.EntitySchemaUId);
			MetaPathParameterValues.Add("ce8c0266-efa5-44a9-bff8-26d3da1ebeff", () => StartSignal2.RecordId);
			MetaPathParameterValues.Add("021c651a-8af8-4170-b888-138386e1329f", () => StartSignal2.EntitySchemaUId);
			MetaPathParameterValues.Add("2ea97d45-fb65-4126-9177-dd5587f15336", () => SubProcessSendEmail.CaseId);
			MetaPathParameterValues.Add("3f984456-427a-4177-9163-9b73842be371", () => SubProcessSendEmail.TemplateId);
			MetaPathParameterValues.Add("4ea09cbc-77f4-49ed-932b-bfc84d1131fb", () => SubProcessSendEmail.SenderEmail);
			MetaPathParameterValues.Add("e9652116-1fbc-423a-809f-5abee6bc90cb", () => SubProcessSendEmail.Subject);
			MetaPathParameterValues.Add("46ad5752-9bc9-40b5-8f41-4568b7813102", () => SubProcessSendEmail.ParentActivityId);
			MetaPathParameterValues.Add("810b9374-7a6a-46db-896a-f030e43430f9", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("3e718202-15ca-44b5-b786-1c807f779f66", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("6ff8853b-20dd-41d4-8339-8a3541af22e2", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("84e64196-ae90-4d27-ba05-56b7d0cb5cf6", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("bfb97948-4d1b-4c6f-a455-9292aaee855e", () => ChangeDataUserTask1.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "IsCloseAndExit":
					if (!hasValueToRead) break;
					IsCloseAndExit = reader.GetValue<System.Boolean>();
				break;
				case "EmailTemplate":
					if (!hasValueToRead) break;
					EmailTemplate = reader.GetValue<System.Guid>();
				break;
				case "CaseRecordId":
					if (!hasValueToRead) break;
					CaseRecordId = reader.GetValue<System.Guid>();
				break;
				case "EmailSender":
					if (!hasValueToRead) break;
					EmailSender = reader.GetValue<System.String>();
				break;
				case "CloseStatusId":
					if (!hasValueToRead) break;
					CloseStatusId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTaskExecute(ProcessExecutingContext context) {
			var CaseRecordId = Guid.Empty;
			var categoryId = Guid.Empty;
			var statusId = Guid.Empty;
			var isMultilanguageEnabled = UserConnection.GetIsFeatureEnabled("EmailMessageMultiLanguage");
			IsCloseAndExit = false;
			if (StartSignal1.RecordId != Guid.Empty) {
				CaseRecordId = StartSignal1.RecordId;
			}
			if (StartSignal2.RecordId != Guid.Empty) {
				CaseRecordId = StartSignal2.RecordId;
			}
			
			var IsClassFeatureEnable = Terrasoft.Configuration.FeatureUtilities.GetIsFeatureEnabled(UserConnection, "SendEmailToCaseOnStatusChangeClass");
			if(IsClassFeatureEnable) {
				var classExecutor = new Terrasoft.Configuration.SendEmailToCaseOnStatusChange(UserConnection, CaseRecordId);
				classExecutor.Run();
				IsCloseAndExit = true;
				return true;
			}
			
			
			
			SubProcessSendEmail.CaseId = CaseRecordId;
			var isFinal = false;
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Case");
			esq.AddColumn("Status");
			esq.AddColumn("Category");
			var IsResolvedColumn = esq.AddColumn("Status.IsResolved");
			var IsFinalColumnName = esq.AddColumn("Status.IsFinal").Name;
			esq.AddColumn("Contact");
			esq.AddColumn("Owner");
			//esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", CaseRecordId));
			var caseEntity = esq.GetEntity(UserConnection, CaseRecordId);
			if (caseEntity != null){
				categoryId = caseEntity.GetTypedColumnValue<Guid>("CategoryId");
				statusId = caseEntity.GetTypedColumnValue<Guid>("StatusId");
				var IsResolved = caseEntity.GetTypedColumnValue<bool>(IsResolvedColumn.Name);
				isFinal = caseEntity.GetTypedColumnValue<bool>(IsFinalColumnName);
				if (!IsResolved) {
					var update = new Update(UserConnection, "DelayedNotification")
						.Set("SendDate", Column.Const(null))
						.Where("CaseId").IsEqual(Column.Parameter(CaseRecordId))
						.And("EmailTemplateId").In(
							Column.Parameter(Terrasoft.Configuration.CaseServiceConsts.ResolutionNotificationTplId), 
							Column.Parameter(Terrasoft.Configuration.CaseServiceConsts.EstimationRequestTplId)
						);
						update.Execute();
				} else {
					var contactId = caseEntity.GetTypedColumnValue<Guid>("ContactId");
					var ownerId = caseEntity.GetTypedColumnValue<Guid>("OwnerId");
					if (contactId == ownerId) {
						IsCloseAndExit = true;
						var entitySchemaManager = UserConnection.EntitySchemaManager;
						var entitySchema = entitySchemaManager.GetInstanceByName("Case");
						Entity entityCase = entitySchema.CreateEntity(UserConnection);
						if (entityCase.FetchFromDB(CaseRecordId))
						{
							Guid closureCodeDefId = Guid.Empty;
							var closureCodeDefString = Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, 
								"CaseClosureCodeDef").ToString();
							entityCase.SetColumnValue("StatusId", CloseStatusId);
							entityCase.SetColumnValue("ClosureDate", UserConnection.CurrentUser.GetCurrentDateTime());
							if (Guid.TryParse(closureCodeDefString, out closureCodeDefId)) {
								entityCase.SetColumnValue("ClosureCodeId", closureCodeDefId);
							}
							entityCase.Save();
							return true;
						}
					}
				}
			}
			
			var emailSender = (string)Terrasoft.Core.Configuration.SysSettings.GetValue<string>(UserConnection, 
				"SupportServiceEmail", String.Empty);
			SubProcessSendEmail.SenderEmail = emailSender;
			var esq2 = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "CaseNotificationRule");
			esq2.AddColumn("EmailTemplate");
			esq2.AddColumn("RuleUsage");
			esq2.AddColumn("Delay");
			esq2.Filters.Add(esq2.CreateFilterWithParameters(FilterComparisonType.NotEqual, "RuleUsage", Terrasoft.Configuration.CaseConsts.DisableSendUsageType));
			esq2.Filters.Add(esq2.CreateFilterWithParameters(FilterComparisonType.Equal, "CaseStatus", statusId));
			esq2.Filters.Add(esq2.CreateFilterWithParameters(FilterComparisonType.Equal, "CaseCategory", categoryId));
			var emailTemplateCollection = esq2.GetEntityCollection(UserConnection);
			if (emailTemplateCollection.Count>0) {
				EmailTemplate = emailTemplateCollection[0].GetTypedColumnValue<Guid>("EmailTemplateId");
				if (isMultilanguageEnabled) {
					var emailTemplateStore = new Terrasoft.Configuration.EmailTemplateStore(UserConnection);
					var emailTemplateLanguageHelper = new Terrasoft.Configuration.EmailTemplateLanguageHelper(CaseRecordId, UserConnection);
					foreach (var emailTemplate in emailTemplateCollection) {
						var emailTemplateId = emailTemplate.GetTypedColumnValue<Guid>("EmailTemplateId");
						var languageId = emailTemplateLanguageHelper.GetLanguageId(emailTemplateId);
						var templateEntity = emailTemplateStore.GetTemplate(emailTemplateId, languageId);
						emailTemplate.SetColumnValue("EmailTemplateId", templateEntity.PrimaryColumnValue);
					}
				}
				SubProcessSendEmail.TemplateId = EmailTemplate;
				if(UserConnection.GetIsFeatureEnabled("DelayedNotification")) {
					var currentDate = DateTime.UtcNow;
					if(isFinal) {
						var delayedEsq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "DelayedNotification");
						delayedEsq.AddColumn("SendDate");
						delayedEsq.AddColumn("Case");
						delayedEsq.AddColumn("Delay");
						var idColumnName = delayedEsq.AddColumn("Id").Name;
						var filters = new[] {
							delayedEsq.CreateFilterWithParameters(FilterComparisonType.Equal, "Case", CaseRecordId),
							delayedEsq.CreateFilter(FilterComparisonType.IsNull, "SendDate")
						};
						delayedEsq.Filters.AddRange(filters);
						var delayedEmailCollection = delayedEsq.GetEntityCollection(UserConnection);
						if(delayedEmailCollection.Any()) {
							currentDate = DateTime.UtcNow;
							foreach(var delayedEmail in delayedEmailCollection) {
								var update = new Update(UserConnection, "DelayedNotification")
									.Set("SendDate", Column.Parameter(currentDate.AddMinutes(
											delayedEmail.GetTypedColumnValue<int>("Delay"))))
									.Where("Id").IsEqual(new QueryParameter(delayedEmail.GetTypedColumnValue<Guid>(idColumnName)));
								update.Execute();
							}
						}
					}
					var delayedNotification = emailTemplateCollection.Where(rule =>
									rule.GetTypedColumnValue<Guid>("RuleUsageId") == Terrasoft.Configuration.CaseConsts.DelaySendUsageType);
					if(delayedNotification.Any()) {
						foreach(var notification in delayedNotification) {
							var update = new Update(UserConnection, "DelayedNotification")
							.Set("SendDate", Column.Parameter(currentDate.AddMinutes(
									notification.GetTypedColumnValue<int>("Delay"))))
							.Where("CaseId").IsEqual(Column.Parameter(CaseRecordId))
							.And("EmailTemplateId").IsEqual(new QueryParameter(notification.GetTypedColumnValue<Guid>("EmailTemplateId")))
							.And("SendDate").IsEqual(Column.Const(null));
							var resultCount = update.Execute();
							if(resultCount == 0) {
							var insert = new Insert(UserConnection)
								.Into("DelayedNotification")
									.Set("CaseId", new QueryParameter(CaseRecordId))
									.Set("Delay", new QueryParameter(notification.GetTypedColumnValue<int>("Delay")))
									.Set("EmailTemplateId", new QueryParameter(notification.GetTypedColumnValue<Guid>("EmailTemplateId")))
									.Set("SendDate", Column.Parameter(currentDate.AddMinutes(
										notification.GetTypedColumnValue<int>("Delay")))) as Insert;
								insert.Execute();
							}
						}
					}
					var immediateNotification = emailTemplateCollection.Where(Rule =>
									Rule.GetTypedColumnValue<Guid>("RuleUsageId") == Terrasoft.Configuration.CaseConsts.ImmediateSendUsageType);
					if(immediateNotification.Any()) {
						var emailTemplateSender = new Terrasoft.Configuration.EmailWithMacrosManager(UserConnection);
						foreach(var notification in immediateNotification) {
							var tplId = notification.GetTypedColumnValue<Guid>("EmailTemplateId");
							try {
								emailTemplateSender.SendEmail(CaseRecordId, tplId);
							} catch {
								continue;
							}
						}
					}
					IsCloseAndExit = true;
					return true;
				}
				if(EmailTemplate == Terrasoft.Configuration.CaseConsts.SatisfactionSurveyTemplateId 
					&& UserConnection.GetIsFeatureEnabled("EstimateWithIcons")) {
				var emailWithMacrosSender = new Terrasoft.Configuration.EmailWithMacrosManager(UserConnection);
				emailWithMacrosSender.SendEmail(CaseRecordId, EmailTemplate);
				IsCloseAndExit = true;
				}
			} else {
				IsCloseAndExit = true;
				return true;
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
			var cloneItem = (SendEmailToCaseStatusChangedProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


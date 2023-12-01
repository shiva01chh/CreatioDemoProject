namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using SysSettings = Terrasoft.Core.Configuration.SysSettings;
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
	using Terrasoft.Core.Scheduler;
	using Terrasoft.Mail;
	using Terrasoft.Mail.Sender;

	#region Class: SendEmailToSROwnerSchema

	/// <exclude/>
	public class SendEmailToSROwnerSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SendEmailToSROwnerSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SendEmailToSROwnerSchema(SendEmailToSROwnerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendEmailToSROwner";
			UId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698");
			CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.6.0.541";
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
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateTemplateIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e2d6e188-0536-4cbb-a47d-546de3233a1d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"TemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.93030575-f70f-4041-902e-c4badaf62c63.b47e41c6-94d0-4d02-8531-4054c157c2ac#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a7d24a5a-b023-47ad-be9a-c28a39a5ae4f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"SenderEmail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c4cbc9bd-932f-4649-87a1-e88804fb12c1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"Subject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7ebb67ae-b1e9-459b-b25c-d3ca6c2d1b78"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"CaseRecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b}].[Parameter:{021d04f3-0d96-4292-a469-49763741f632}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCloseAndExitParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("57bee078-709b-4064-8102-a8d287b5ba04"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"IsCloseAndExit",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateTemplateIdParameter());
			Parameters.Add(CreateSenderEmailParameter());
			Parameters.Add(CreateSubjectParameter());
			Parameters.Add(CreateCaseRecordIdParameter());
			Parameters.Add(CreateIsCloseAndExitParameter());
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c046b569-c1d5-44ee-bef5-2f0c073b6e8d"),
				ContainerUId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
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
				UId = new Guid("85939570-5e97-434a-8ec4-3e328c887084"),
				ContainerUId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
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
				UId = new Guid("fae2fcb8-9ebc-4d88-a763-51a8fd7fa007"),
				ContainerUId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
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
				UId = new Guid("df23ea66-cd2f-4c48-a92d-7b123685cf55"),
				ContainerUId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
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

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9fe73c5e-c65c-4dc9-8a14-32ddee1d2062"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,77,111,219,48,12,253,43,129,207,83,33,219,178,44,231,54,116,217,208,203,90,172,65,47,75,15,148,68,37,198,252,5,217,233,214,5,249,239,163,237,52,107,139,116,205,6,12,235,128,250,98,155,120,164,30,63,30,181,9,76,1,109,251,17,74,12,166,193,28,189,135,182,118,221,201,251,188,232,208,127,240,245,186,9,222,4,45,250,28,138,252,59,218,209,62,179,121,247,14,58,32,151,205,226,103,132,69,48,93,28,142,177,8,222,44,130,188,195,178,37,12,185,184,68,103,41,104,206,100,42,4,19,86,0,211,6,129,33,143,67,149,88,17,243,44,28,145,79,5,63,173,203,6,60,142,103,12,225,221,240,57,191,109,122,104,72,6,51,64,242,182,174,118,198,184,39,209,206,42,208,5,90,250,239,252,26,201,212,249,188,164,108,112,158,151,120,1,158,206,234,227,212,189,137,64,14,138,182,71,21,232,186,217,183,198,99,219,230,117,245,28,185,98,93,86,247,209,20,0,247,191,59,58,124,224,216,35,47,160,91,13,33,206,136,214,118,96,249,118,185,244,184,132,46,191,185,79,226,11,222,14,184,227,234,71,14,150,186,116,5,197,26,239,157,249,48,147,83,104,186,49,161,241,120,2,248,124,185,58,58,215,125,197,158,75,55,34,99,115,7,62,50,230,193,28,34,73,198,155,222,48,70,185,251,92,4,159,207,218,243,175,21,250,75,179,194,18,198,170,93,159,144,245,145,97,86,96,137,85,55,221,160,180,153,227,138,51,37,157,100,194,113,206,64,72,201,92,196,67,116,82,99,154,37,91,114,216,19,154,110,12,23,82,39,50,99,38,180,9,19,2,145,105,116,9,139,28,55,60,141,181,68,101,183,215,35,241,188,109,10,184,189,218,243,155,175,112,98,160,197,201,10,218,137,70,172,38,148,127,190,172,208,78,186,122,82,247,212,79,62,161,169,189,221,117,162,127,145,159,49,194,100,210,8,22,134,41,103,2,140,99,160,50,100,153,84,10,98,151,26,112,154,6,135,30,242,201,84,138,46,85,25,83,161,137,41,39,131,76,233,56,98,150,210,147,74,203,4,245,171,182,126,161,173,227,234,247,170,173,231,180,37,109,106,34,77,26,137,34,158,50,145,98,194,128,228,198,184,138,49,178,41,96,104,237,35,109,57,192,200,25,173,88,134,218,208,90,83,138,65,42,99,150,132,160,156,77,29,112,158,62,165,173,211,94,87,80,217,81,70,19,227,145,102,204,30,148,147,48,156,11,142,17,139,227,148,84,159,240,152,84,31,39,44,142,148,78,56,135,208,225,78,78,253,188,20,245,50,55,80,156,55,232,97,215,205,240,240,176,63,80,73,95,72,95,215,221,88,158,125,35,122,154,3,151,187,113,147,54,206,116,66,138,14,251,61,36,120,130,140,74,67,211,23,41,145,161,139,108,40,18,34,67,183,112,223,171,203,122,237,205,78,153,237,120,253,254,209,181,250,15,4,253,59,26,61,168,146,99,166,254,191,189,43,254,238,166,127,109,247,11,91,95,47,102,19,109,131,237,15,216,121,190,243,4,12,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("faf88bc7-9ec3-474f-85c3-47d19c91dd4c"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("87c61dbc-e2fe-4c1d-a939-228b0714856a"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("489aeb16-3e43-4075-8bb1-f85b63fd422a"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bc13a1cb-f6d2-48da-8094-9471e8db4dc6"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c395b470-4a8b-4af1-9692-e47f4c846c96"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38b53574-4673-4dd1-93d8-83f1e4d170ed"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,43,205,77,74,45,178,50,180,50,212,241,76,177,50,176,50,0,0,237,33,101,51,17,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("021d04f3-0d96-4292-a469-49763741f632"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d1a08149-aeef-49fe-8363-1b80aad76636"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f4318b8e-a4ba-4399-bb71-48847b675f4d"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eda4e7cd-cb31-419b-ad36-22a6022aa70d"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("655b9008-70a9-4c03-a04d-b2f308450e34"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("25e0fa4b-970d-43dd-b80e-b2a2625e0dd3"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bf24a190-2262-4aa4-b32e-c6169bca3b2f"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("014d404c-3972-44b9-a7b0-4e7fca6be3b6"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7be14a6d-bf83-44ed-a78c-1601116baefd"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f4e0fd1b-8be5-40bd-9ac3-e85c039c4f9f"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ddb3398e-58cd-4e8c-9e32-678df8172a66"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c4e67b30-1c3b-463c-a33c-d95308105c66"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
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
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("70b11618-c71a-4155-8014-3a53fd5cd1c8"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,93,111,211,48,20,253,43,85,158,231,41,137,29,39,238,219,52,10,218,11,155,216,180,23,202,131,99,95,119,22,249,146,237,14,74,213,255,206,117,210,149,13,21,173,240,2,18,121,114,142,206,61,62,247,203,219,68,53,210,251,247,178,133,100,158,220,129,115,210,247,38,156,191,181,77,0,247,206,245,235,33,57,75,60,56,43,27,251,13,244,132,47,180,13,111,100,144,24,178,93,254,80,88,38,243,229,113,141,101,114,182,76,108,128,214,35,7,67,42,86,9,202,68,69,106,158,106,194,152,0,34,42,154,18,90,139,66,152,76,211,28,242,137,249,43,241,203,190,29,164,131,233,142,81,222,140,199,187,205,16,169,25,2,106,164,88,223,119,123,144,70,19,126,209,201,186,1,141,255,193,173,1,161,224,108,139,217,192,157,109,225,70,58,188,43,234,244,17,66,146,145,141,143,172,6,76,88,124,29,28,120,111,251,238,53,115,205,186,237,158,179,81,0,14,191,123,59,233,232,49,50,111,100,120,24,37,174,208,214,110,116,121,177,90,57,88,201,96,31,159,155,248,12,155,145,119,90,253,48,64,99,151,238,101,179,134,103,119,190,204,228,82,14,97,74,104,186,30,9,206,174,30,78,206,245,80,177,215,210,205,17,28,158,200,39,106,30,205,33,231,8,62,70,96,82,121,58,46,147,143,87,254,250,75,7,238,86,61,64,43,167,170,125,58,71,244,39,96,209,64,11,93,152,111,107,101,40,64,105,8,175,76,65,152,81,146,72,86,107,2,58,83,89,89,8,170,170,122,135,1,7,67,243,109,154,103,58,101,134,146,84,11,78,88,46,114,12,225,130,48,81,114,90,178,204,112,154,199,144,69,23,108,216,76,147,48,223,150,41,207,83,157,166,4,24,72,194,42,157,17,97,180,34,172,40,115,163,116,165,89,134,23,77,233,90,63,52,114,115,127,200,234,3,72,61,83,210,195,44,86,2,215,202,249,48,139,203,52,235,205,12,107,188,110,130,237,86,51,28,165,6,84,236,229,249,5,214,125,213,1,140,122,177,169,168,34,11,90,106,35,74,66,105,134,35,195,211,156,212,101,85,19,202,50,73,139,90,209,204,224,200,236,226,23,103,164,95,89,37,155,235,1,156,220,143,71,122,124,123,94,172,93,236,140,235,251,48,213,251,208,217,203,190,11,82,133,209,206,211,8,43,94,105,163,107,67,138,178,198,138,112,108,130,128,130,18,90,113,206,141,169,101,70,21,250,193,215,39,102,125,219,175,157,218,111,187,159,158,157,63,122,78,254,194,35,241,59,123,127,116,243,78,217,164,255,108,71,254,165,153,222,37,187,239,116,120,106,19,70,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("67dd077f-eb7e-455c-bd25-7a2739501199"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("920a67b6-1c8c-4f36-a894-356d4b59f1df"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d32b69b8-da12-4d43-9e3f-b871199dc2ac"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5ef8e651-f0f6-44c6-bd11-f287de677557"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ff3266dd-6661-4954-9be1-753c4436c33c"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f4581450-6bde-48e5-8aeb-24e01a3f6cb3"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("5719453e-2032-4300-a9bf-e4208bede94d"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("76dd0aac-acbd-4d32-bed0-d30d3e00b7bf"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("485e921a-c9c1-4491-88dc-28252e30e587"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("250b6f40-ea89-421d-b1a1-885362269881"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4a2e7dfa-30ae-4c59-b872-15ea611cc23d"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e7d5edde-50a9-47cf-b4d3-02ad39fbec6a"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("984c8a1b-a1b9-4152-ae3f-a823be19b2fc"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("2d33dda1-70ec-434d-8bf0-4a150a70b973"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e4e926dc-1916-4d49-b91e-d1b3b9ee27f6"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6e2df57d-caef-4ef7-9bda-a15c8fe5861b"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("416fa2d3-de4d-44d5-9978-c81f98f5e3f1"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f082c002-fcd5-4525-b652-643120eef8b6"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
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
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeFillEmailUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var subjectParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e4f314d3-291c-45de-a2c4-0bb7a7a4a043"),
				ContainerUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
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
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(subjectParameter);
			var bodyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fd3e36ce-30b6-4382-a169-07ea62f57648"),
				ContainerUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"Body",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			bodyParameter.SourceValue = new ProcessSchemaParameterValue(bodyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(bodyParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4becebac-6618-4cf8-acff-5399dc9ef219"),
				ContainerUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b}].[Parameter:{021d04f3-0d96-4292-a469-49763741f632}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var templateIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8ada520f-9328-4d23-8e28-7cd84ab83abd"),
				ContainerUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"TemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			templateIdParameter.SourceValue = new ProcessSchemaParameterValue(templateIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#Lookup.93030575-f70f-4041-902e-c4badaf62c63.b47e41c6-94d0-4d02-8531-4054c157c2ac#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(templateIdParameter);
			var sysEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("19997124-7bc1-4d68-91c0-f2a7263fc478"),
				ContainerUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"SysEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			sysEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(sysEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{6a3f340b-79dd-4dc2-8779-5140388e5320}].[Parameter:{492ae6cd-2386-4f94-b3dc-ecfe0a561e90}].[EntityColumn:{ed98cf3e-1642-4755-acb2-a61181429306}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(sysEntitySchemaIdParameter);
		}

		protected virtual void InitializeReadDataUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("09d4d948-3e28-4f04-9934-8ff03d3aee8c"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,193,142,218,48,16,253,151,156,215,43,136,179,78,178,183,138,165,189,181,72,160,158,184,76,236,73,176,214,193,145,237,172,74,87,252,123,237,4,40,72,89,109,168,132,218,106,111,241,211,155,201,155,231,231,121,141,184,2,107,191,66,141,209,99,180,66,99,192,234,210,221,127,150,202,161,249,98,116,219,68,119,145,69,35,65,201,159,40,122,124,46,164,123,2,7,190,228,117,253,187,195,58,122,92,15,247,88,71,119,235,72,58,172,173,231,248,18,150,11,145,228,60,33,73,153,35,73,48,227,36,103,140,19,140,115,94,198,44,45,10,150,246,204,183,154,207,116,221,128,193,254,31,93,251,178,251,92,237,154,64,157,122,128,119,20,105,245,246,0,210,32,194,206,183,80,40,20,254,236,76,139,30,114,70,214,126,26,92,201,26,23,96,252,191,66,31,29,32,79,42,65,217,192,82,88,186,249,143,198,160,181,82,111,223,19,167,218,122,123,206,246,13,240,116,60,200,153,116,26,3,115,1,110,211,181,232,123,237,59,157,159,170,202,96,5,78,190,156,203,120,198,93,199,28,231,160,47,16,254,158,190,131,106,241,204,153,203,89,102,208,184,126,164,163,0,79,49,178,218,140,158,247,228,218,123,35,199,30,108,142,228,145,61,7,167,136,51,15,190,4,160,43,155,129,13,190,237,131,115,44,193,20,99,74,9,45,210,146,36,177,16,36,167,211,7,66,31,50,202,232,52,77,32,23,31,49,91,203,157,93,0,127,134,10,239,175,136,217,40,51,175,142,217,165,144,255,55,110,193,66,165,43,201,65,125,107,208,192,97,192,201,112,24,46,82,196,194,212,90,187,37,223,96,13,39,69,254,150,122,164,211,113,188,6,40,120,33,48,47,194,67,103,36,201,38,148,20,98,90,16,202,48,17,34,133,52,203,185,23,228,87,117,80,190,212,173,225,135,248,218,126,71,255,209,238,253,11,169,191,110,73,14,166,102,76,10,110,178,78,254,81,187,6,223,253,205,157,187,233,203,216,71,251,95,72,180,142,225,185,8,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc417be0-069a-44c3-9150-0bb0efc91d55"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("58f21f7f-2f16-4ac7-8ac8-ce14b47deace"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a030b9d0-e7a0-4ced-bbbe-9539dfb1dd22"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3825a909-209e-4923-923d-23603fc8a105"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("702fea70-3f23-4480-8b9f-b553d0a194a6"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9bcb9ea2-2f79-4c66-be40-60fc89827613"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,115,78,44,40,201,204,207,179,50,180,50,212,241,76,177,50,176,50,0,0,176,27,135,17,18,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("492ae6cd-2386-4f94-b3dc-ecfe0a561e90"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2fabbf13-01ca-42c6-9f0d-07f14a79d614"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("96c84c00-2797-4646-a698-7f02695068c7"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6356bc10-9b8b-4a7c-b5e7-8b18ccb8d4cd"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c5c8881b-1545-4573-bffe-420faeaa97bc"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("64c177fe-eb36-4a4b-b7ae-91f33fcd1623"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("18bfd995-e4af-4ba7-9844-31322fbc7da7"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("753cf6dc-9ea4-44fd-adc1-48898e488426"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e8af8fcc-bceb-41bc-99dd-9e7f54a2cc6e"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55390786-dd46-43fb-add4-4f851434760e"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4fbec98f-004d-4f1f-87a7-b668063d0884"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("de308fad-dcf4-42c5-832a-534722bee38f"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
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
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeAddDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("a244c08e-bd09-4ca7-8a99-1077520a1ec5"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"c449d832-a4cc-4b01-b9d5-8a12c42a9f89",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("31b660b1-300f-4f12-a4b2-98efc57cd867"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("441998e4-8821-4d10-8a9c-40c050c8dd78"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,51,0,0,33,223,219,244,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("dde1dd64-30a8-4ef6-b1d1-6d6d6661ac9b"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1d10b34a-77ec-4277-99b6-ce89fe7cd27d"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,89,93,111,91,55,18,253,43,130,90,96,95,60,2,191,63,252,214,109,179,88,3,201,54,136,187,125,137,243,48,36,135,137,118,101,41,144,174,27,184,134,255,251,158,43,219,77,226,182,138,188,133,227,4,176,0,91,208,21,57,28,14,231,204,57,67,93,76,191,29,206,223,202,244,112,250,147,172,215,188,89,245,97,246,253,106,45,179,231,235,85,149,205,102,246,116,85,121,49,255,149,203,66,158,243,154,79,101,144,245,207,188,56,147,205,211,249,102,56,152,124,60,109,122,48,253,246,151,237,183,211,195,151,23,211,163,65,78,255,125,212,96,221,53,197,169,115,163,222,93,38,23,114,167,148,116,37,159,180,20,175,156,179,41,97,114,93,45,206,78,151,207,100,224,231,60,188,153,30,94,76,183,214,182,6,106,87,108,53,197,222,34,185,86,152,88,41,71,226,180,45,58,122,235,172,158,94,30,76,55,245,141,156,242,118,209,247,147,171,115,185,37,107,136,93,173,228,138,210,84,114,243,148,88,155,234,12,231,158,242,56,249,122,252,251,137,47,191,121,121,180,249,241,221,82,214,199,91,187,135,157,23,27,121,53,195,211,91,15,126,11,206,225,69,117,181,212,92,26,101,107,58,246,138,13,167,200,154,36,165,164,92,47,88,83,95,190,250,230,213,184,98,155,111,222,46,248,252,231,223,47,124,124,86,254,35,117,184,26,246,246,163,208,127,56,240,226,228,234,4,79,166,135,39,127,118,134,215,239,87,30,127,124,138,183,15,240,100,122,112,50,61,94,157,173,235,104,209,226,195,15,31,120,184,93,100,59,228,214,199,155,19,195,147,229,217,98,113,253,228,7,30,248,102,224,205,227,85,155,247,185,180,163,229,241,205,65,109,173,168,235,23,253,193,191,155,215,149,111,127,101,218,51,94,242,107,89,255,11,1,120,239,251,111,94,254,132,48,222,24,246,149,173,239,90,17,107,36,139,171,33,18,231,192,100,147,109,28,184,115,237,117,59,251,133,116,89,203,178,202,255,233,216,11,217,108,163,61,66,229,218,175,49,84,151,211,203,203,131,15,1,20,68,59,246,154,169,242,152,84,186,120,98,203,145,74,236,57,231,168,76,181,97,39,128,188,203,186,90,219,73,178,1,128,42,39,98,31,51,53,151,180,18,246,174,250,112,31,0,122,186,90,253,247,236,237,44,250,226,154,205,133,188,111,163,133,22,40,53,196,215,162,30,176,79,45,135,26,103,98,146,213,77,42,33,186,138,90,215,88,70,169,142,168,233,22,148,100,155,106,248,20,110,174,215,251,174,14,243,95,230,195,249,100,4,199,236,201,41,207,23,143,80,122,16,40,21,147,189,138,186,83,20,70,233,151,96,198,147,103,202,58,151,110,35,106,100,55,187,160,180,79,230,220,9,74,221,217,102,84,27,45,52,67,46,26,248,98,106,33,221,173,169,162,69,251,162,118,66,41,232,36,209,43,75,9,212,67,206,155,70,204,22,31,123,12,49,155,228,109,241,15,201,69,79,22,114,42,203,225,240,34,7,175,85,141,66,50,226,201,37,7,204,59,39,20,107,237,136,102,6,113,242,229,199,228,213,155,21,27,170,144,85,37,16,104,25,142,234,144,73,225,244,130,233,62,6,151,62,77,94,255,228,101,91,200,4,33,199,128,65,38,125,181,158,200,136,193,201,187,249,240,102,114,202,117,189,218,204,254,190,106,231,143,160,124,16,80,86,213,149,11,35,17,4,131,204,40,72,143,228,196,83,118,58,183,154,188,14,69,127,86,126,51,61,58,200,184,134,170,159,45,185,30,183,190,120,106,57,121,37,166,89,237,119,11,68,111,138,14,210,18,5,16,53,248,77,65,127,165,132,13,22,78,181,148,236,173,228,47,68,32,114,108,6,100,206,32,55,131,189,70,200,226,34,25,212,110,18,91,212,52,22,215,247,16,136,178,108,178,254,219,230,10,88,143,56,122,16,28,181,86,44,107,145,177,62,38,180,37,32,183,18,65,115,77,9,88,98,20,47,165,125,94,28,213,168,83,44,149,66,52,30,58,209,6,100,25,104,174,177,3,173,245,40,197,198,157,56,82,181,248,145,148,41,169,145,51,52,23,218,234,206,196,94,101,237,44,231,84,190,8,114,67,253,106,62,165,14,5,235,193,194,101,92,85,20,136,139,53,26,175,81,44,150,124,139,220,124,212,217,161,16,144,81,24,237,44,2,205,16,33,104,34,141,74,69,154,100,215,198,41,79,150,3,164,227,247,219,24,29,94,180,210,141,50,163,42,117,206,1,174,144,34,165,118,71,45,137,47,58,5,107,212,30,253,220,11,225,54,89,141,59,156,52,100,210,236,31,243,245,102,152,204,113,112,147,85,159,172,101,115,182,24,230,203,215,19,156,204,2,125,223,124,181,124,84,173,143,4,249,129,106,149,84,81,105,50,73,81,97,188,0,25,27,64,168,86,165,188,13,26,8,85,49,239,190,65,137,213,181,234,34,37,111,160,195,81,161,136,67,103,234,6,136,46,70,213,166,237,23,1,108,128,203,138,196,78,33,117,148,176,94,25,171,150,70,210,116,133,68,200,182,166,114,11,216,202,232,166,92,183,164,218,72,254,38,143,142,66,181,186,28,131,133,176,232,0,233,239,129,61,150,11,135,78,31,192,206,227,66,130,38,223,230,134,10,82,162,137,73,116,208,113,79,96,87,222,200,222,184,62,106,143,160,126,16,80,255,213,86,84,235,216,48,40,83,50,208,167,96,18,135,162,160,53,233,26,130,214,190,74,174,237,78,160,206,200,52,215,217,19,216,75,64,182,232,41,139,213,133,44,68,68,84,217,118,252,237,4,53,119,207,209,54,11,70,3,65,57,20,39,74,216,12,105,31,225,142,206,161,52,115,143,183,58,174,152,24,24,29,121,4,52,97,1,34,22,74,22,8,138,89,90,13,74,105,211,103,177,135,102,123,118,212,109,128,103,216,37,169,144,42,92,6,208,85,177,25,145,223,243,86,231,25,18,30,103,125,117,169,243,227,217,240,122,5,104,61,130,233,171,4,211,62,185,115,39,48,53,184,227,148,213,196,90,163,173,202,78,65,167,21,67,217,55,86,5,24,77,159,0,83,77,26,96,140,154,68,1,131,206,66,64,115,77,13,219,114,108,178,5,255,216,116,143,96,202,65,11,116,104,128,255,6,203,55,136,143,162,70,98,130,243,18,208,91,212,170,102,73,217,177,73,68,212,18,220,131,163,26,128,15,126,188,34,245,30,28,8,49,234,238,122,69,90,121,144,215,171,245,249,163,224,252,138,225,180,79,246,220,173,147,140,222,23,159,43,217,26,209,218,246,0,96,21,141,42,158,26,27,111,170,237,220,119,194,41,169,14,196,192,133,40,6,6,146,135,224,244,33,128,60,59,231,48,222,203,168,123,232,36,135,53,222,118,164,255,205,247,143,9,254,153,19,60,171,18,124,233,137,84,239,56,81,232,0,74,49,102,50,99,243,29,35,247,172,226,103,237,168,106,231,241,238,222,144,49,190,193,161,150,33,190,146,65,190,151,154,217,20,167,28,239,238,168,178,245,72,199,241,202,167,140,226,203,86,98,3,3,209,148,134,36,143,65,170,187,71,190,232,182,235,152,114,167,94,12,252,183,161,3,95,89,81,182,33,196,170,36,5,231,102,65,217,50,254,96,73,65,171,120,197,23,28,92,32,29,176,120,101,148,136,164,246,228,139,45,59,76,142,7,30,206,54,179,239,222,241,124,120,20,95,95,43,91,236,147,59,159,2,211,171,203,255,1,99,162,16,103,62,34,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b80339a8-820c-40b9-aa5e-7542914dc2df"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
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
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("94e9a24c-27da-4f2f-898d-31e395dc6cc2"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
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
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadDataUserTask4Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("977cad3d-2c65-430b-8902-f756c05291e4"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,77,111,219,48,12,253,43,133,207,117,225,143,196,78,114,43,178,108,200,101,13,208,160,151,58,7,74,162,19,97,182,101,72,74,183,44,240,127,31,101,231,171,93,154,181,189,172,39,203,79,79,143,228,35,185,245,120,1,198,124,135,18,189,145,55,71,173,193,168,220,222,124,149,133,69,253,77,171,117,237,93,123,6,181,132,66,254,70,209,225,19,33,237,23,176,64,79,182,217,81,33,243,70,217,121,141,204,187,206,60,105,177,52,196,161,39,121,40,146,65,44,2,159,241,4,252,94,63,76,124,214,23,177,159,198,3,145,178,40,76,68,142,29,243,53,241,105,213,201,183,202,121,123,156,111,106,199,234,17,192,85,89,131,150,70,85,59,48,118,241,205,164,2,86,160,160,127,171,215,72,144,213,178,164,66,112,46,75,156,129,166,48,78,71,57,136,72,57,20,198,177,10,204,237,228,87,173,209,24,169,170,203,121,141,85,177,46,171,83,54,9,224,225,119,151,78,208,230,232,152,51,176,171,86,98,12,134,110,154,54,207,219,229,82,227,18,172,124,58,77,227,7,110,90,230,219,204,163,7,130,90,244,0,197,26,119,81,195,224,175,98,198,80,219,174,166,125,6,68,209,152,163,198,138,227,61,95,97,9,135,42,143,4,185,92,157,136,184,166,62,94,240,228,224,236,191,108,137,8,172,247,228,203,62,207,142,180,51,149,70,9,129,79,14,232,84,246,199,204,123,156,154,187,159,21,234,174,180,206,219,197,13,161,47,128,131,254,104,155,34,99,73,10,232,179,16,135,228,247,144,249,44,234,115,95,196,28,18,30,137,144,165,131,102,209,229,33,77,93,192,230,225,16,206,89,118,165,145,43,45,174,166,162,229,184,15,221,176,62,66,154,15,2,63,102,130,186,24,48,238,15,83,193,125,214,27,134,76,164,208,139,18,55,15,77,179,104,220,80,20,106,41,57,20,119,53,106,216,117,44,56,63,211,207,150,193,249,160,149,178,47,58,121,203,105,182,164,221,180,9,237,231,138,162,209,174,59,43,239,213,90,115,236,22,204,116,75,254,161,229,253,15,123,249,190,85,123,101,144,223,50,152,159,101,228,62,215,56,53,94,243,7,237,208,219,167,83,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9c6f141c-5da9-4856-8b61-9f48b7911781"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4e3be632-b70c-4b4c-8308-380d8171b89f"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a4a0e571-6551-46d8-9aa9-dd1afda8956c"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e3c26302-9b0d-4a54-8335-90d353b47af9"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3be3fe2d-ee9f-45c2-915c-ea7ebe38b5e3"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9f627d7b-d9c3-4a70-aa62-1e7d41fa025c"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,115,46,74,77,44,73,77,241,207,179,50,180,50,4,0,252,157,29,132,13,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("d5304989-02e5-4d55-9d1d-091d6ef8ca92"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1217e6ca-8d64-4667-ae20-c8be0b49ba25"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("48649703-f62f-4c0f-a38e-076044d6d4b2"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fd373003-c24e-424c-b3c5-56117473ca44"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2b34f769-63d0-497e-ba58-140a71c665cd"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dcbdb688-b666-4348-9e82-b8f414a14ff9"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97d4b158-03da-42e6-8e2d-9c1391a6e264"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("23ad489e-59f4-4704-a50f-89d316ef79aa"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("07605453-95da-4cae-bb85-94983ae46c6d"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,5,193,129,9,0,48,8,3,176,139,10,150,118,120,143,206,249,255,9,75,60,119,163,68,228,78,194,211,133,138,48,158,169,102,30,89,252,2,221,81,196,36,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4df5accf-b45e-4785-839d-c9360472a236"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dd5564ee-277d-43ad-bbc6-bf73ebd13b2e"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5b165516-cbae-4f7a-b065-9fbf5cb28241"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
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
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
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
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaUserTask fillemailusertask = CreateFillEmailUserTaskUserTask();
			FlowElements.Add(fillemailusertask);
			ProcessSchemaUserTask readdatausertask3 = CreateReadDataUserTask3UserTask();
			FlowElements.Add(readdatausertask3);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask4 = CreateReadDataUserTask4UserTask();
			FlowElements.Add(readdatausertask4);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			FlowElements.Add(scripttask2);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("aa5ade14-1be3-4e08-ac39-209a6b873b1c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(154, 146),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("94bba729-c06a-4c0c-954a-a363bb53f98a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("a758c66e-b1b6-431b-9ce4-e115f3479d9c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(156, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("94bba729-c06a-4c0c-954a-a363bb53f98a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(83, 192));
			schemaFlow.PolylinePointPositions.Add(new Point(83, 93));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow4",
				UId = new Guid("5ebcb3b3-95e2-4b52-b11b-1cd548bd659e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(504, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33ec13b0-6c8a-4620-8921-30f51798762c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("a7874379-205f-41fe-96f1-309febd80697"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{046d588f-d451-4b32-ae0e-3a1932e938b9}].[Parameter:{5719453e-2032-4300-a9bf-e4208bede94d}].[EntityColumn:{dbf202ec-c444-479b-bcf4-d8e5b1863201}]#] != string.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(329, 163),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("bb807e9b-583c-4859-9c29-095a70d66f33"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(402, 267),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("b27c22ab-0638-4e97-9349-352e005e3609"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(510, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79a25b3e-6735-442d-b68f-a2544aeea005"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("69b7d2e9-299a-4779-a633-d185a4b71e04"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(634, 269),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fac52282-ed67-44a7-bd72-ed38e5e56220"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(935, 233));
			schemaFlow.PolylinePointPositions.Add(new Point(935, 113));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("08cbffd4-ed3f-46f8-a81f-4f5c5cdf4834"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(564, 168),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fac52282-ed67-44a7-bd72-ed38e5e56220"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33ec13b0-6c8a-4620-8921-30f51798762c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1006, 55));
			schemaFlow.PolylinePointPositions.Add(new Point(610, 55));
			schemaFlow.PolylinePointPositions.Add(new Point(610, 93));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("689283cf-dd44-4ce0-9556-210b607aa27c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(274, 100),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("4b3aed1a-644a-45c5-815c-97053ed16b8b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b}].[Parameter:{021d04f3-0d96-4292-a469-49763741f632}].[EntityColumn:{3015559e-cbc6-406a-88af-07f7930be832}]#]==[#[IsOwnerSchema:false].[IsSchema:false].[Element:{bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b}].[Parameter:{021d04f3-0d96-4292-a469-49763741f632}].[EntityColumn:{70620d00-e4ea-48d1-9fdc-4572fcd8d41b}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(324, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33ec13b0-6c8a-4620-8921-30f51798762c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(384, 35));
			schemaFlow.PolylinePointPositions.Add(new Point(567, 35));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("4af39791-80bf-4a7d-9619-a1bf7a5ced17"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b}].[Parameter:{021d04f3-0d96-4292-a469-49763741f632}].[EntityColumn:{b59a15ea-751e-4fd8-8281-f1a3dc7190ff}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79a25b3e-6735-442d-b68f-a2544aeea005"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(688, 428));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("f37ba6da-aaaf-466c-b9bb-0e6ea73adcfd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79a25b3e-6735-442d-b68f-a2544aeea005"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(688, 233));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("0ff8f18a-1b60-4d3b-8549-3705eda4a5a3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5ed81272-95c4-4558-9999-a96862be7013"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("b41b1611-c34b-431b-a6ec-a0a0e41e3b57"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5ed81272-95c4-4558-9999-a96862be7013"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("43d381c1-2317-4601-9d21-a326412570ef"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("94bba729-c06a-4c0c-954a-a363bb53f98a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7059a9d3-af29-4546-b5d1-b46029a486d7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(210, 93));
			schemaFlow.PolylinePointPositions.Add(new Point(210, 92));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("56043e87-d590-4613-b649-bf6fa7e632b6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7059a9d3-af29-4546-b5d1-b46029a486d7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(318, 92));
			schemaFlow.PolylinePointPositions.Add(new Point(318, 93));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("cdb788c4-3d14-4967-b75e-18d8e829c806"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{57bee078-709b-4064-8102-a8d287b5ba04}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7059a9d3-af29-4546-b5d1-b46029a486d7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33ec13b0-6c8a-4620-8921-30f51798762c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(255, 92));
			schemaFlow.PolylinePointPositions.Add(new Point(255, 1));
			schemaFlow.PolylinePointPositions.Add(new Point(567, 1));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("bab75b4b-ea1f-49e7-8a58-3a33ef7f9457"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("bab75b4b-ea1f-49e7-8a58-3a33ef7f9457"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("33ec13b0-6c8a-4620-8921-30f51798762c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"Terminate1",
				Position = new Point(553, 79),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(40, 79),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("70620d00-e4ea-48d1-9fdc-4572fcd8d41b");
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal2StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"StartSignal2",
				NewEntityChangedColumns = false,
				Position = new Point(20, 178),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeStartSignal2Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ReadDataUserTask1",
				Position = new Point(349, 65),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ReadDataUserTask2",
				Position = new Point(451, 65),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateFillEmailUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"FillEmailUserTask",
				Position = new Point(551, 280),
				SchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeFillEmailUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ReadDataUserTask3",
				Position = new Point(451, 280),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"AddDataUserTask1",
				Position = new Point(831, 205),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fac52282-ed67-44a7-bd72-ed38e5e56220"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ScriptTask1",
				Position = new Point(971, 85),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,205,106,195,48,12,62,55,144,119,16,57,57,48,2,61,119,29,132,44,29,185,118,221,3,104,177,86,204,92,7,108,39,37,148,189,123,229,80,88,102,239,100,91,250,244,253,200,19,90,192,222,171,73,249,185,147,176,135,90,202,87,244,248,225,200,158,208,125,111,171,35,245,131,149,157,220,229,153,250,2,17,26,205,96,12,241,208,96,170,55,242,157,59,16,250,209,82,107,240,83,147,20,5,99,106,55,155,190,189,160,210,239,100,36,217,162,44,225,150,103,155,184,14,180,186,239,193,208,21,98,72,36,89,178,145,205,106,170,10,199,50,35,126,131,4,208,15,144,118,180,168,78,248,16,106,180,34,227,15,12,28,236,204,122,141,70,231,30,207,144,229,185,77,80,47,34,152,98,125,231,237,24,42,181,61,143,23,238,139,98,252,99,172,120,130,200,233,98,117,90,109,184,77,195,166,29,145,58,77,152,3,241,63,164,203,46,226,53,48,52,207,44,241,15,25,224,8,180,187,3,126,184,91,109,244,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("79a25b3e-6735-442d-b68f-a2544aeea005"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ExclusiveGateway1",
				Position = new Point(660, 280),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask4UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ReadDataUserTask4",
				Position = new Point(731, 400),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask4Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("5ed81272-95c4-4558-9999-a96862be7013"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"FormulaTask1",
				Position = new Point(831, 400),
				ResultParameterMetaPath = @"c4cbc9bd-932f-4649-87a1-e88804fb12c1",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,207,189,106,195,48,20,64,225,87,17,201,226,80,110,144,172,171,95,8,25,130,135,76,41,237,24,60,220,88,87,164,96,171,224,184,180,197,228,221,235,118,236,35,100,61,112,134,175,58,175,207,199,219,233,179,240,248,218,93,121,160,152,169,191,113,187,93,234,191,208,244,60,112,153,226,108,124,103,21,43,6,239,44,2,26,170,193,103,39,1,45,105,148,10,115,246,246,190,12,207,52,210,192,19,143,113,78,70,75,12,62,128,172,217,0,38,99,32,36,149,64,6,149,44,103,223,81,168,127,151,166,76,111,211,247,225,189,255,24,74,156,49,117,89,146,86,224,114,114,203,117,33,32,41,17,24,149,190,40,103,52,106,117,111,215,237,102,123,44,137,191,78,185,90,189,52,81,172,54,98,183,19,82,236,69,245,16,58,177,144,254,92,226,233,65,68,63,150,200,134,88,118,2,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("94bba729-c06a-4c0c-954a-a363bb53f98a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ScriptTask2",
				Position = new Point(120, 65),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,84,77,111,219,48,12,61,219,191,66,245,201,6,2,3,237,113,105,50,180,73,90,100,88,91,172,206,218,227,160,216,76,170,205,145,60,125,180,11,218,252,247,81,146,99,59,94,186,29,150,131,99,139,228,19,201,247,200,12,120,1,114,182,161,172,36,35,178,0,41,169,18,43,157,78,132,4,124,240,21,91,27,73,53,19,60,205,182,42,3,173,25,95,171,244,26,244,3,45,13,156,43,45,241,96,28,127,85,32,209,157,67,110,125,7,36,12,162,204,84,149,144,58,3,249,204,114,112,87,68,3,226,3,210,217,166,210,219,100,24,178,21,233,197,90,236,185,186,2,170,141,132,25,167,203,18,138,56,114,225,55,160,20,93,195,141,41,53,251,76,249,218,224,71,148,144,183,55,242,95,16,15,103,81,146,144,215,48,152,171,73,41,20,92,240,98,246,139,105,236,135,150,6,134,97,240,76,37,201,169,130,123,200,133,44,230,5,90,226,76,83,172,141,173,57,45,79,211,198,112,50,34,215,134,21,117,121,97,16,124,36,199,29,209,244,161,107,58,107,76,195,144,224,207,40,236,18,137,167,151,179,95,144,27,45,36,41,150,205,235,168,95,239,140,43,172,116,122,217,30,197,73,226,112,94,221,179,169,224,238,133,131,204,160,68,167,47,6,228,150,140,48,17,235,193,225,133,248,243,30,29,73,186,16,85,124,106,107,193,31,74,162,52,27,30,71,19,4,67,54,35,7,56,47,162,247,236,55,162,96,43,6,197,229,246,152,147,224,154,230,218,250,121,121,120,135,244,74,138,77,13,177,15,153,99,62,242,147,96,157,168,218,20,164,119,199,242,73,231,106,246,211,208,242,224,150,38,135,244,241,9,36,180,97,7,17,62,61,171,126,165,227,46,239,168,18,170,234,54,121,154,58,84,205,167,84,211,123,160,56,78,68,250,191,209,209,158,167,158,71,240,190,113,203,107,77,153,167,45,216,191,190,60,177,18,72,236,33,83,27,100,185,13,58,158,205,187,101,89,216,219,240,230,218,31,39,193,151,227,199,213,138,115,28,183,93,26,246,162,55,13,93,255,130,56,36,182,143,67,149,66,89,3,188,139,178,223,27,123,226,251,0,76,181,23,220,213,37,213,165,141,58,89,118,195,236,42,57,249,35,206,13,246,33,118,69,37,221,128,6,169,16,212,10,127,202,156,212,169,220,214,121,13,136,88,126,71,190,198,113,210,13,118,72,237,23,113,242,217,139,3,101,116,176,35,118,131,190,183,43,117,1,155,170,164,26,92,128,141,119,50,83,233,69,221,177,214,126,4,1,193,89,197,128,91,49,55,45,222,117,83,220,13,253,84,92,84,85,150,63,65,97,74,236,253,66,178,245,218,142,207,242,60,195,125,127,176,252,110,133,198,118,229,110,197,143,227,122,59,99,78,120,18,71,127,245,222,203,246,90,10,83,217,33,250,214,107,65,50,168,39,180,183,173,30,133,252,161,42,154,67,122,139,60,12,250,203,108,98,164,196,18,237,105,237,208,18,54,112,43,249,64,45,174,252,93,216,126,250,231,46,148,128,235,159,251,29,254,27,46,148,246,35,231,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("7059a9d3-af29-4546-b5d1-b46029a486d7"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ExclusiveGateway2",
				Position = new Point(232, 64),
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
				UId = new Guid("b664894c-10e2-4207-9f2a-e18100f3a271"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f4ad8837-96b8-46ff-9488-8002103ea83c"),
				Name = "Terrasoft.Mail.Sender",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("275e8026-6921-41d0-bf0e-2f9d9f0051c4"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3af073b6-ff03-4de8-a1ef-c261aabf7ba8"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c9759650-9711-40d6-a7e2-c5aba34fe0a9"),
				Name = "Terrasoft.Core.Scheduler",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4cc50205-bb0b-4854-abab-6a774187dd16"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("84ceba09-0dcf-4ced-a843-30e0b024f78b"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4f275d04-4104-4f26-9f0f-7b1eb2419c23"),
				Name = "System",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("70f57acd-ff6a-42b0-9dd8-ec32c122c084"),
				Name = "Terrasoft.Core.Configuration.SysSettings",
				Alias = "SysSettings",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SendEmailToSROwner(userConnection);
		}

		public override object Clone() {
			return new SendEmailToSROwnerSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"));
		}

		#endregion

	}

	#endregion

	#region Class: SendEmailToSROwner

	/// <exclude/>
	public class SendEmailToSROwner : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,77,111,219,48,12,253,43,129,207,83,33,219,178,44,231,54,116,217,208,203,90,172,65,47,75,15,148,68,37,198,252,5,217,233,214,5,249,239,163,237,52,107,139,116,205,6,12,235,128,250,98,155,120,164,30,63,30,181,9,76,1,109,251,17,74,12,166,193,28,189,135,182,118,221,201,251,188,232,208,127,240,245,186,9,222,4,45,250,28,138,252,59,218,209,62,179,121,247,14,58,32,151,205,226,103,132,69,48,93,28,142,177,8,222,44,130,188,195,178,37,12,185,184,68,103,41,104,206,100,42,4,19,86,0,211,6,129,33,143,67,149,88,17,243,44,28,145,79,5,63,173,203,6,60,142,103,12,225,221,240,57,191,109,122,104,72,6,51,64,242,182,174,118,198,184,39,209,206,42,208,5,90,250,239,252,26,201,212,249,188,164,108,112,158,151,120,1,158,206,234,227,212,189,137,64,14,138,182,71,21,232,186,217,183,198,99,219,230,117,245,28,185,98,93,86,247,209,20,0,247,191,59,58,124,224,216,35,47,160,91,13,33,206,136,214,118,96,249,118,185,244,184,132,46,191,185,79,226,11,222,14,184,227,234,71,14,150,186,116,5,197,26,239,157,249,48,147,83,104,186,49,161,241,120,2,248,124,185,58,58,215,125,197,158,75,55,34,99,115,7,62,50,230,193,28,34,73,198,155,222,48,70,185,251,92,4,159,207,218,243,175,21,250,75,179,194,18,198,170,93,159,144,245,145,97,86,96,137,85,55,221,160,180,153,227,138,51,37,157,100,194,113,206,64,72,201,92,196,67,116,82,99,154,37,91,114,216,19,154,110,12,23,82,39,50,99,38,180,9,19,2,145,105,116,9,139,28,55,60,141,181,68,101,183,215,35,241,188,109,10,184,189,218,243,155,175,112,98,160,197,201,10,218,137,70,172,38,148,127,190,172,208,78,186,122,82,247,212,79,62,161,169,189,221,117,162,127,145,159,49,194,100,210,8,22,134,41,103,2,140,99,160,50,100,153,84,10,98,151,26,112,154,6,135,30,242,201,84,138,46,85,25,83,161,137,41,39,131,76,233,56,98,150,210,147,74,203,4,245,171,182,126,161,173,227,234,247,170,173,231,180,37,109,106,34,77,26,137,34,158,50,145,98,194,128,228,198,184,138,49,178,41,96,104,237,35,109,57,192,200,25,173,88,134,218,208,90,83,138,65,42,99,150,132,160,156,77,29,112,158,62,165,173,211,94,87,80,217,81,70,19,227,145,102,204,30,148,147,48,156,11,142,17,139,227,148,84,159,240,152,84,31,39,44,142,148,78,56,135,208,225,78,78,253,188,20,245,50,55,80,156,55,232,97,215,205,240,240,176,63,80,73,95,72,95,215,221,88,158,125,35,122,154,3,151,187,113,147,54,206,116,66,138,14,251,61,36,120,130,140,74,67,211,23,41,145,161,139,108,40,18,34,67,183,112,223,171,203,122,237,205,78,153,237,120,253,254,209,181,250,15,4,253,59,26,61,168,146,99,166,254,191,189,43,254,238,166,127,109,247,11,91,95,47,102,19,109,131,237,15,216,121,190,243,4,12,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = true;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,43,205,77,74,45,178,50,180,50,212,241,76,177,50,176,50,0,0,237,33,101,51,17,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("117d32f9-8275-4534-8411-1c66115ce9cd")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private bool _canReadUncommitedData = false;
			public override bool CanReadUncommitedData {
				get {
					return _canReadUncommitedData;
				}
				set {
					_canReadUncommitedData = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask2FlowElement

		/// <exclude/>
		public class ReadDataUserTask2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask2FlowElement(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,93,111,211,48,20,253,43,85,158,231,41,137,29,39,238,219,52,10,218,11,155,216,180,23,202,131,99,95,119,22,249,146,237,14,74,213,255,206,117,210,149,13,21,173,240,2,18,121,114,142,206,61,62,247,203,219,68,53,210,251,247,178,133,100,158,220,129,115,210,247,38,156,191,181,77,0,247,206,245,235,33,57,75,60,56,43,27,251,13,244,132,47,180,13,111,100,144,24,178,93,254,80,88,38,243,229,113,141,101,114,182,76,108,128,214,35,7,67,42,86,9,202,68,69,106,158,106,194,152,0,34,42,154,18,90,139,66,152,76,211,28,242,137,249,43,241,203,190,29,164,131,233,142,81,222,140,199,187,205,16,169,25,2,106,164,88,223,119,123,144,70,19,126,209,201,186,1,141,255,193,173,1,161,224,108,139,217,192,157,109,225,70,58,188,43,234,244,17,66,146,145,141,143,172,6,76,88,124,29,28,120,111,251,238,53,115,205,186,237,158,179,81,0,14,191,123,59,233,232,49,50,111,100,120,24,37,174,208,214,110,116,121,177,90,57,88,201,96,31,159,155,248,12,155,145,119,90,253,48,64,99,151,238,101,179,134,103,119,190,204,228,82,14,97,74,104,186,30,9,206,174,30,78,206,245,80,177,215,210,205,17,28,158,200,39,106,30,205,33,231,8,62,70,96,82,121,58,46,147,143,87,254,250,75,7,238,86,61,64,43,167,170,125,58,71,244,39,96,209,64,11,93,152,111,107,101,40,64,105,8,175,76,65,152,81,146,72,86,107,2,58,83,89,89,8,170,170,122,135,1,7,67,243,109,154,103,58,101,134,146,84,11,78,88,46,114,12,225,130,48,81,114,90,178,204,112,154,199,144,69,23,108,216,76,147,48,223,150,41,207,83,157,166,4,24,72,194,42,157,17,97,180,34,172,40,115,163,116,165,89,134,23,77,233,90,63,52,114,115,127,200,234,3,72,61,83,210,195,44,86,2,215,202,249,48,139,203,52,235,205,12,107,188,110,130,237,86,51,28,165,6,84,236,229,249,5,214,125,213,1,140,122,177,169,168,34,11,90,106,35,74,66,105,134,35,195,211,156,212,101,85,19,202,50,73,139,90,209,204,224,200,236,226,23,103,164,95,89,37,155,235,1,156,220,143,71,122,124,123,94,172,93,236,140,235,251,48,213,251,208,217,203,190,11,82,133,209,206,211,8,43,94,105,163,107,67,138,178,198,138,112,108,130,128,130,18,90,113,206,141,169,101,70,21,250,193,215,39,102,125,219,175,157,218,111,187,159,158,157,63,122,78,254,194,35,241,59,123,127,116,243,78,217,164,255,108,71,254,165,153,222,37,187,239,116,120,106,19,70,7,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = true;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: FillEmailUserTaskFlowElement

		/// <exclude/>
		public class FillEmailUserTaskFlowElement : FillEmailTemplateUserTask
		{

			#region Constructors: Public

			public FillEmailUserTaskFlowElement(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "FillEmailUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_templateId = () => (Guid)(new Guid("b47e41c6-94d0-4d02-8531-4054c157c2ac"));
				_sysEntitySchemaId = () => (Guid)(((process.ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName("UId").ColumnValueName) ? process.ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>("UId") : Guid.Empty)));
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

			internal Func<Guid> _templateId;
			public override Guid TemplateId {
				get {
					return (_templateId ?? (_templateId = () => Guid.Empty)).Invoke();
				}
				set {
					_templateId = () => { return value; };
				}
			}

			internal Func<Guid> _sysEntitySchemaId;
			public override Guid SysEntitySchemaId {
				get {
					return (_sysEntitySchemaId ?? (_sysEntitySchemaId = () => Guid.Empty)).Invoke();
				}
				set {
					_sysEntitySchemaId = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask3FlowElement

		/// <exclude/>
		public class ReadDataUserTask3FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask3FlowElement(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,193,142,218,48,16,253,151,156,215,43,136,179,78,178,183,138,165,189,181,72,160,158,184,76,236,73,176,214,193,145,237,172,74,87,252,123,237,4,40,72,89,109,168,132,218,106,111,241,211,155,201,155,231,231,121,141,184,2,107,191,66,141,209,99,180,66,99,192,234,210,221,127,150,202,161,249,98,116,219,68,119,145,69,35,65,201,159,40,122,124,46,164,123,2,7,190,228,117,253,187,195,58,122,92,15,247,88,71,119,235,72,58,172,173,231,248,18,150,11,145,228,60,33,73,153,35,73,48,227,36,103,140,19,140,115,94,198,44,45,10,150,246,204,183,154,207,116,221,128,193,254,31,93,251,178,251,92,237,154,64,157,122,128,119,20,105,245,246,0,210,32,194,206,183,80,40,20,254,236,76,139,30,114,70,214,126,26,92,201,26,23,96,252,191,66,31,29,32,79,42,65,217,192,82,88,186,249,143,198,160,181,82,111,223,19,167,218,122,123,206,246,13,240,116,60,200,153,116,26,3,115,1,110,211,181,232,123,237,59,157,159,170,202,96,5,78,190,156,203,120,198,93,199,28,231,160,47,16,254,158,190,131,106,241,204,153,203,89,102,208,184,126,164,163,0,79,49,178,218,140,158,247,228,218,123,35,199,30,108,142,228,145,61,7,167,136,51,15,190,4,160,43,155,129,13,190,237,131,115,44,193,20,99,74,9,45,210,146,36,177,16,36,167,211,7,66,31,50,202,232,52,77,32,23,31,49,91,203,157,93,0,127,134,10,239,175,136,217,40,51,175,142,217,165,144,255,55,110,193,66,165,43,201,65,125,107,208,192,97,192,201,112,24,46,82,196,194,212,90,187,37,223,96,13,39,69,254,150,122,164,211,113,188,6,40,120,33,48,47,194,67,103,36,201,38,148,20,98,90,16,202,48,17,34,133,52,203,185,23,228,87,117,80,190,212,173,225,135,248,218,126,71,255,209,238,253,11,169,191,110,73,14,166,102,76,10,110,178,78,254,81,187,6,223,253,205,157,187,233,203,216,71,251,95,72,180,142,225,185,8,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = true;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,115,78,44,40,201,204,207,179,50,180,50,212,241,76,177,50,176,50,0,0,176,27,135,17,18,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("6c7394db-06ff-4050-91ef-8278e21dce15")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private bool _canReadUncommitedData = false;
			public override bool CanReadUncommitedData {
				get {
					return _canReadUncommitedData;
				}
				set {
					_canReadUncommitedData = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddDataUserTask1FlowElement

		/// <exclude/>
		public class AddDataUserTask1FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask1FlowElement(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Title = () => new LocalizableString((process.Subject));
				_recordDefValues_Type = () => (Guid)(new Guid("e2831dec-cfc0-df11-b00f-001d60e938c6"));
				_recordDefValues_Body = () => new LocalizableString((process.FillEmailUserTask.Body));
				_recordDefValues_Sender = () => new LocalizableString((process.SenderEmail));
				_recordDefValues_Recepient = () => new LocalizableString(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>("Email") : null)));
				_recordDefValues_Case = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_recordDefValues_MessageType = () => (Guid)(new Guid("7f6d3f94-f36b-1410-068c-20cf30b39373"));
				_recordDefValues_ActivityCategory = () => (Guid)(new Guid("8038a396-7825-e011-8165-00155d043204"));
				_recordDefValues_IsHtmlBody = () => (bool)(true);
				_recordDefValues_EmailSendStatus = () => (Guid)(new Guid("603ba6af-6107-e011-a646-16d83cab0980"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Title", () => _recordDefValues_Title.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Type", () => _recordDefValues_Type.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Body", () => _recordDefValues_Body.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Sender", () => _recordDefValues_Sender.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Recepient", () => _recordDefValues_Recepient.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Case", () => _recordDefValues_Case.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_MessageType", () => _recordDefValues_MessageType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_ActivityCategory", () => _recordDefValues_ActivityCategory.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsHtmlBody", () => _recordDefValues_IsHtmlBody.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_EmailSendStatus", () => _recordDefValues_EmailSendStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Title;
			internal Func<Guid> _recordDefValues_Type;
			internal Func<string> _recordDefValues_Body;
			internal Func<string> _recordDefValues_Sender;
			internal Func<string> _recordDefValues_Recepient;
			internal Func<Guid> _recordDefValues_Case;
			internal Func<Guid> _recordDefValues_MessageType;
			internal Func<Guid> _recordDefValues_ActivityCategory;
			internal Func<bool> _recordDefValues_IsHtmlBody;
			internal Func<Guid> _recordDefValues_EmailSendStatus;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _recordAddMode;
			public override string RecordAddMode {
				get {
					return _recordAddMode ?? (_recordAddMode = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,51,0,0,33,223,219,244,1,0,0,0 })));
				}
				set {
					_recordAddMode = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,89,93,111,91,55,18,253,43,130,90,96,95,60,2,191,63,252,214,109,179,88,3,201,54,136,187,125,137,243,48,36,135,137,118,101,41,144,174,27,184,134,255,251,158,43,219,77,226,182,138,188,133,227,4,176,0,91,208,21,57,28,14,231,204,57,67,93,76,191,29,206,223,202,244,112,250,147,172,215,188,89,245,97,246,253,106,45,179,231,235,85,149,205,102,246,116,85,121,49,255,149,203,66,158,243,154,79,101,144,245,207,188,56,147,205,211,249,102,56,152,124,60,109,122,48,253,246,151,237,183,211,195,151,23,211,163,65,78,255,125,212,96,221,53,197,169,115,163,222,93,38,23,114,167,148,116,37,159,180,20,175,156,179,41,97,114,93,45,206,78,151,207,100,224,231,60,188,153,30,94,76,183,214,182,6,106,87,108,53,197,222,34,185,86,152,88,41,71,226,180,45,58,122,235,172,158,94,30,76,55,245,141,156,242,118,209,247,147,171,115,185,37,107,136,93,173,228,138,210,84,114,243,148,88,155,234,12,231,158,242,56,249,122,252,251,137,47,191,121,121,180,249,241,221,82,214,199,91,187,135,157,23,27,121,53,195,211,91,15,126,11,206,225,69,117,181,212,92,26,101,107,58,246,138,13,167,200,154,36,165,164,92,47,88,83,95,190,250,230,213,184,98,155,111,222,46,248,252,231,223,47,124,124,86,254,35,117,184,26,246,246,163,208,127,56,240,226,228,234,4,79,166,135,39,127,118,134,215,239,87,30,127,124,138,183,15,240,100,122,112,50,61,94,157,173,235,104,209,226,195,15,31,120,184,93,100,59,228,214,199,155,19,195,147,229,217,98,113,253,228,7,30,248,102,224,205,227,85,155,247,185,180,163,229,241,205,65,109,173,168,235,23,253,193,191,155,215,149,111,127,101,218,51,94,242,107,89,255,11,1,120,239,251,111,94,254,132,48,222,24,246,149,173,239,90,17,107,36,139,171,33,18,231,192,100,147,109,28,184,115,237,117,59,251,133,116,89,203,178,202,255,233,216,11,217,108,163,61,66,229,218,175,49,84,151,211,203,203,131,15,1,20,68,59,246,154,169,242,152,84,186,120,98,203,145,74,236,57,231,168,76,181,97,39,128,188,203,186,90,219,73,178,1,128,42,39,98,31,51,53,151,180,18,246,174,250,112,31,0,122,186,90,253,247,236,237,44,250,226,154,205,133,188,111,163,133,22,40,53,196,215,162,30,176,79,45,135,26,103,98,146,213,77,42,33,186,138,90,215,88,70,169,142,168,233,22,148,100,155,106,248,20,110,174,215,251,174,14,243,95,230,195,249,100,4,199,236,201,41,207,23,143,80,122,16,40,21,147,189,138,186,83,20,70,233,151,96,198,147,103,202,58,151,110,35,106,100,55,187,160,180,79,230,220,9,74,221,217,102,84,27,45,52,67,46,26,248,98,106,33,221,173,169,162,69,251,162,118,66,41,232,36,209,43,75,9,212,67,206,155,70,204,22,31,123,12,49,155,228,109,241,15,201,69,79,22,114,42,203,225,240,34,7,175,85,141,66,50,226,201,37,7,204,59,39,20,107,237,136,102,6,113,242,229,199,228,213,155,21,27,170,144,85,37,16,104,25,142,234,144,73,225,244,130,233,62,6,151,62,77,94,255,228,101,91,200,4,33,199,128,65,38,125,181,158,200,136,193,201,187,249,240,102,114,202,117,189,218,204,254,190,106,231,143,160,124,16,80,86,213,149,11,35,17,4,131,204,40,72,143,228,196,83,118,58,183,154,188,14,69,127,86,126,51,61,58,200,184,134,170,159,45,185,30,183,190,120,106,57,121,37,166,89,237,119,11,68,111,138,14,210,18,5,16,53,248,77,65,127,165,132,13,22,78,181,148,236,173,228,47,68,32,114,108,6,100,206,32,55,131,189,70,200,226,34,25,212,110,18,91,212,52,22,215,247,16,136,178,108,178,254,219,230,10,88,143,56,122,16,28,181,86,44,107,145,177,62,38,180,37,32,183,18,65,115,77,9,88,98,20,47,165,125,94,28,213,168,83,44,149,66,52,30,58,209,6,100,25,104,174,177,3,173,245,40,197,198,157,56,82,181,248,145,148,41,169,145,51,52,23,218,234,206,196,94,101,237,44,231,84,190,8,114,67,253,106,62,165,14,5,235,193,194,101,92,85,20,136,139,53,26,175,81,44,150,124,139,220,124,212,217,161,16,144,81,24,237,44,2,205,16,33,104,34,141,74,69,154,100,215,198,41,79,150,3,164,227,247,219,24,29,94,180,210,141,50,163,42,117,206,1,174,144,34,165,118,71,45,137,47,58,5,107,212,30,253,220,11,225,54,89,141,59,156,52,100,210,236,31,243,245,102,152,204,113,112,147,85,159,172,101,115,182,24,230,203,215,19,156,204,2,125,223,124,181,124,84,173,143,4,249,129,106,149,84,81,105,50,73,81,97,188,0,25,27,64,168,86,165,188,13,26,8,85,49,239,190,65,137,213,181,234,34,37,111,160,195,81,161,136,67,103,234,6,136,46,70,213,166,237,23,1,108,128,203,138,196,78,33,117,148,176,94,25,171,150,70,210,116,133,68,200,182,166,114,11,216,202,232,166,92,183,164,218,72,254,38,143,142,66,181,186,28,131,133,176,232,0,233,239,129,61,150,11,135,78,31,192,206,227,66,130,38,223,230,134,10,82,162,137,73,116,208,113,79,96,87,222,200,222,184,62,106,143,160,126,16,80,255,213,86,84,235,216,48,40,83,50,208,167,96,18,135,162,160,53,233,26,130,214,190,74,174,237,78,160,206,200,52,215,217,19,216,75,64,182,232,41,139,213,133,44,68,68,84,217,118,252,237,4,53,119,207,209,54,11,70,3,65,57,20,39,74,216,12,105,31,225,142,206,161,52,115,143,183,58,174,152,24,24,29,121,4,52,97,1,34,22,74,22,8,138,89,90,13,74,105,211,103,177,135,102,123,118,212,109,128,103,216,37,169,144,42,92,6,208,85,177,25,145,223,243,86,231,25,18,30,103,125,117,169,243,227,217,240,122,5,104,61,130,233,171,4,211,62,185,115,39,48,53,184,227,148,213,196,90,163,173,202,78,65,167,21,67,217,55,86,5,24,77,159,0,83,77,26,96,140,154,68,1,131,206,66,64,115,77,13,219,114,108,178,5,255,216,116,143,96,202,65,11,116,104,128,255,6,203,55,136,143,162,70,98,130,243,18,208,91,212,170,102,73,217,177,73,68,212,18,220,131,163,26,128,15,126,188,34,245,30,28,8,49,234,238,122,69,90,121,144,215,171,245,249,163,224,252,138,225,180,79,246,220,173,147,140,222,23,159,43,217,26,209,218,246,0,96,21,141,42,158,26,27,111,170,237,220,119,194,41,169,14,196,192,133,40,6,6,146,135,224,244,33,128,60,59,231,48,222,203,168,123,232,36,135,53,222,118,164,255,205,247,143,9,254,153,19,60,171,18,124,233,137,84,239,56,81,232,0,74,49,102,50,99,243,29,35,247,172,226,103,237,168,106,231,241,238,222,144,49,190,193,161,150,33,190,146,65,190,151,154,217,20,167,28,239,238,168,178,245,72,199,241,202,167,140,226,203,86,98,3,3,209,148,134,36,143,65,170,187,71,190,232,182,235,152,114,167,94,12,252,183,161,3,95,89,81,182,33,196,170,36,5,231,102,65,217,50,254,96,73,65,171,120,197,23,28,92,32,29,176,120,101,148,136,164,246,228,139,45,59,76,142,7,30,206,54,179,239,222,241,124,120,20,95,95,43,91,236,147,59,159,2,211,171,203,255,1,99,162,16,103,62,34,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "77b64dfc5e5942e8baa6a231f1fdd698",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask4FlowElement

		/// <exclude/>
		public class ReadDataUserTask4FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask4FlowElement(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask4";
				IsLogging = true;
				SchemaElementUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,77,111,219,48,12,253,43,133,207,117,225,143,196,78,114,43,178,108,200,101,13,208,160,151,58,7,74,162,19,97,182,101,72,74,183,44,240,127,31,101,231,171,93,154,181,189,172,39,203,79,79,143,228,35,185,245,120,1,198,124,135,18,189,145,55,71,173,193,168,220,222,124,149,133,69,253,77,171,117,237,93,123,6,181,132,66,254,70,209,225,19,33,237,23,176,64,79,182,217,81,33,243,70,217,121,141,204,187,206,60,105,177,52,196,161,39,121,40,146,65,44,2,159,241,4,252,94,63,76,124,214,23,177,159,198,3,145,178,40,76,68,142,29,243,53,241,105,213,201,183,202,121,123,156,111,106,199,234,17,192,85,89,131,150,70,85,59,48,118,241,205,164,2,86,160,160,127,171,215,72,144,213,178,164,66,112,46,75,156,129,166,48,78,71,57,136,72,57,20,198,177,10,204,237,228,87,173,209,24,169,170,203,121,141,85,177,46,171,83,54,9,224,225,119,151,78,208,230,232,152,51,176,171,86,98,12,134,110,154,54,207,219,229,82,227,18,172,124,58,77,227,7,110,90,230,219,204,163,7,130,90,244,0,197,26,119,81,195,224,175,98,198,80,219,174,166,125,6,68,209,152,163,198,138,227,61,95,97,9,135,42,143,4,185,92,157,136,184,166,62,94,240,228,224,236,191,108,137,8,172,247,228,203,62,207,142,180,51,149,70,9,129,79,14,232,84,246,199,204,123,156,154,187,159,21,234,174,180,206,219,197,13,161,47,128,131,254,104,155,34,99,73,10,232,179,16,135,228,247,144,249,44,234,115,95,196,28,18,30,137,144,165,131,102,209,229,33,77,93,192,230,225,16,206,89,118,165,145,43,45,174,166,162,229,184,15,221,176,62,66,154,15,2,63,102,130,186,24,48,238,15,83,193,125,214,27,134,76,164,208,139,18,55,15,77,179,104,220,80,20,106,41,57,20,119,53,106,216,117,44,56,63,211,207,150,193,249,160,149,178,47,58,121,203,105,182,164,221,180,9,237,231,138,162,209,174,59,43,239,213,90,115,236,22,204,116,75,254,161,229,253,15,123,249,190,85,123,101,144,223,50,152,159,101,228,62,215,56,53,94,243,7,237,208,219,167,83,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,115,46,74,77,44,73,77,241,207,179,50,180,50,4,0,252,157,29,132,13,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,5,193,129,9,0,48,8,3,176,139,10,150,118,120,143,206,249,255,9,75,60,119,163,68,228,78,194,211,133,138,48,158,169,102,30,89,252,2,221,81,196,36,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
				}
			}

			#endregion

		}

		#endregion

		public SendEmailToSROwner(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendEmailToSROwner";
			SchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_templateId = () => { return (Guid)(new Guid("b47e41c6-94d0-4d02-8531-4054c157c2ac")); };
			_senderEmail = () => { return new LocalizableString(((String)SysSettings.GetValue(UserConnection, "SupportServiceEmail"))); };
			_subject = () => { return new LocalizableString((FillEmailUserTask.Subject)); };
			_caseRecordId = () => { return (Guid)(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty))); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SendEmailToSROwner, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SendEmailToSROwner, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		private Func<Guid> _templateId;
		public virtual Guid TemplateId {
			get {
				return (_templateId ?? (_templateId = () => Guid.Empty)).Invoke();
			}
			set {
				_templateId = () => { return value; };
			}
		}

		private Func<string> _senderEmail;
		public virtual string SenderEmail {
			get {
				return (_senderEmail ?? (_senderEmail = () => null)).Invoke();
			}
			set {
				_senderEmail = () => { return value; };
			}
		}

		private Func<string> _subject;
		public virtual string Subject {
			get {
				return (_subject ?? (_subject = () => null)).Invoke();
			}
			set {
				_subject = () => { return value; };
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

		public virtual bool IsCloseAndExit {
			get;
			set;
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
					SchemaElementUId = new Guid("33ec13b0-6c8a-4620-8921-30f51798762c"),
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
					SchemaElementUId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
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
					SchemaElementUId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private FillEmailUserTaskFlowElement _fillEmailUserTask;
		public FillEmailUserTaskFlowElement FillEmailUserTask {
			get {
				return _fillEmailUserTask ?? (_fillEmailUserTask = new FillEmailUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask3FlowElement _readDataUserTask3;
		public ReadDataUserTask3FlowElement ReadDataUserTask3 {
			get {
				return _readDataUserTask3 ?? (_readDataUserTask3 = new ReadDataUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("fac52282-ed67-44a7-bd72-ed38e5e56220"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("79a25b3e-6735-442d-b68f-a2544aeea005"),
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

		private ReadDataUserTask4FlowElement _readDataUserTask4;
		public ReadDataUserTask4FlowElement ReadDataUserTask4 {
			get {
				return _readDataUserTask4 ?? (_readDataUserTask4 = new ReadDataUserTask4FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask1;
		public ProcessScriptTask FormulaTask1 {
			get {
				return _formulaTask1 ?? (_formulaTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask1",
					SchemaElementUId = new Guid("5ed81272-95c4-4558-9999-a96862be7013"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("94bba729-c06a-4c0c-954a-a363bb53f98a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("7059a9d3-af29-4546-b5d1-b46029a486d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
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
					SchemaElementUId = new Guid("a7874379-205f-41fe-96f1-309febd80697"),
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
					SchemaElementUId = new Guid("4b3aed1a-644a-45c5-815c-97053ed16b8b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
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
					SchemaElementUId = new Guid("4af39791-80bf-4a7d-9619-a1bf7a5ced17"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow2;
		public ProcessConditionalFlow ConditionalSequenceFlow2 {
			get {
				return _conditionalSequenceFlow2 ?? (_conditionalSequenceFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow2",
					SchemaElementUId = new Guid("cdb788c4-3d14-4967-b75e-18d8e829c806"),
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
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[StartSignal2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal2 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[FillEmailUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FillEmailUserTask };
			FlowElements[ReadDataUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask3 };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask4 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask2", e.Context.SenderName));
						break;
					case "StartSignal2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask3", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "FillEmailUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ReadDataUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FillEmailUserTask", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask4", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "ScriptTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>("Email") : null)) != string.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask2", "ConditionalFlow1", "((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName(\"Email\").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>(\"Email\") : null)) != string.Empty", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("ModifiedBy").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ModifiedById") : Guid.Empty))==((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask1", "ConditionalFlow2", "((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName(\"ModifiedBy\").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>(\"ModifiedById\") : Guid.Empty))==((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName(\"Owner\").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>(\"OwnerId\") : Guid.Empty))", result);
			return result;
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("ParentActivity").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ParentActivityId") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow1", "((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName(\"ParentActivity\").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>(\"ParentActivityId\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((IsCloseAndExit));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "ConditionalSequenceFlow2", "(IsCloseAndExit)", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("IsCloseAndExit")) {
				writer.WriteValue("IsCloseAndExit", IsCloseAndExit, false);
			}
			if (!HasMapping("TemplateId")) {
				writer.WriteValue("TemplateId", TemplateId, Guid.Empty);
			}
			if (!HasMapping("SenderEmail")) {
				writer.WriteValue("SenderEmail", SenderEmail, null);
			}
			if (!HasMapping("Subject")) {
				writer.WriteValue("Subject", Subject, null);
			}
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
			MetaPathParameterValues.Add("e2d6e188-0536-4cbb-a47d-546de3233a1d", () => TemplateId);
			MetaPathParameterValues.Add("a7d24a5a-b023-47ad-be9a-c28a39a5ae4f", () => SenderEmail);
			MetaPathParameterValues.Add("c4cbc9bd-932f-4649-87a1-e88804fb12c1", () => Subject);
			MetaPathParameterValues.Add("7ebb67ae-b1e9-459b-b25c-d3ca6c2d1b78", () => CaseRecordId);
			MetaPathParameterValues.Add("57bee078-709b-4064-8102-a8d287b5ba04", () => IsCloseAndExit);
			MetaPathParameterValues.Add("c046b569-c1d5-44ee-bef5-2f0c073b6e8d", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("85939570-5e97-434a-8ec4-3e328c887084", () => StartSignal1.EntitySchemaUId);
			MetaPathParameterValues.Add("fae2fcb8-9ebc-4d88-a763-51a8fd7fa007", () => StartSignal2.RecordId);
			MetaPathParameterValues.Add("df23ea66-cd2f-4c48-a92d-7b123685cf55", () => StartSignal2.EntitySchemaUId);
			MetaPathParameterValues.Add("9fe73c5e-c65c-4dc9-8a14-32ddee1d2062", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("faf88bc7-9ec3-474f-85c3-47d19c91dd4c", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("87c61dbc-e2fe-4c1d-a939-228b0714856a", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("489aeb16-3e43-4075-8bb1-f85b63fd422a", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("bc13a1cb-f6d2-48da-8094-9471e8db4dc6", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("c395b470-4a8b-4af1-9692-e47f4c846c96", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("38b53574-4673-4dd1-93d8-83f1e4d170ed", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("021d04f3-0d96-4292-a469-49763741f632", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("d1a08149-aeef-49fe-8363-1b80aad76636", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("f4318b8e-a4ba-4399-bb71-48847b675f4d", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("eda4e7cd-cb31-419b-ad36-22a6022aa70d", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("655b9008-70a9-4c03-a04d-b2f308450e34", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("25e0fa4b-970d-43dd-b80e-b2a2625e0dd3", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("bf24a190-2262-4aa4-b32e-c6169bca3b2f", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("014d404c-3972-44b9-a7b0-4e7fca6be3b6", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("7be14a6d-bf83-44ed-a78c-1601116baefd", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("f4e0fd1b-8be5-40bd-9ac3-e85c039c4f9f", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("ddb3398e-58cd-4e8c-9e32-678df8172a66", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("c4e67b30-1c3b-463c-a33c-d95308105c66", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("70b11618-c71a-4155-8014-3a53fd5cd1c8", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("67dd077f-eb7e-455c-bd25-7a2739501199", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("920a67b6-1c8c-4f36-a894-356d4b59f1df", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("d32b69b8-da12-4d43-9e3f-b871199dc2ac", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("5ef8e651-f0f6-44c6-bd11-f287de677557", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("ff3266dd-6661-4954-9be1-753c4436c33c", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("f4581450-6bde-48e5-8aeb-24e01a3f6cb3", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("5719453e-2032-4300-a9bf-e4208bede94d", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("76dd0aac-acbd-4d32-bed0-d30d3e00b7bf", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("485e921a-c9c1-4491-88dc-28252e30e587", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("250b6f40-ea89-421d-b1a1-885362269881", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("4a2e7dfa-30ae-4c59-b872-15ea611cc23d", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("e7d5edde-50a9-47cf-b4d3-02ad39fbec6a", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("984c8a1b-a1b9-4152-ae3f-a823be19b2fc", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("2d33dda1-70ec-434d-8bf0-4a150a70b973", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("e4e926dc-1916-4d49-b91e-d1b3b9ee27f6", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("6e2df57d-caef-4ef7-9bda-a15c8fe5861b", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("416fa2d3-de4d-44d5-9978-c81f98f5e3f1", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("f082c002-fcd5-4525-b652-643120eef8b6", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("e4f314d3-291c-45de-a2c4-0bb7a7a4a043", () => FillEmailUserTask.Subject);
			MetaPathParameterValues.Add("fd3e36ce-30b6-4382-a169-07ea62f57648", () => FillEmailUserTask.Body);
			MetaPathParameterValues.Add("4becebac-6618-4cf8-acff-5399dc9ef219", () => FillEmailUserTask.RecordId);
			MetaPathParameterValues.Add("8ada520f-9328-4d23-8e28-7cd84ab83abd", () => FillEmailUserTask.TemplateId);
			MetaPathParameterValues.Add("19997124-7bc1-4d68-91c0-f2a7263fc478", () => FillEmailUserTask.SysEntitySchemaId);
			MetaPathParameterValues.Add("09d4d948-3e28-4f04-9934-8ff03d3aee8c", () => ReadDataUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("fc417be0-069a-44c3-9150-0bb0efc91d55", () => ReadDataUserTask3.ResultType);
			MetaPathParameterValues.Add("58f21f7f-2f16-4ac7-8ac8-ce14b47deace", () => ReadDataUserTask3.ReadSomeTopRecords);
			MetaPathParameterValues.Add("a030b9d0-e7a0-4ced-bbbe-9539dfb1dd22", () => ReadDataUserTask3.NumberOfRecords);
			MetaPathParameterValues.Add("3825a909-209e-4923-923d-23603fc8a105", () => ReadDataUserTask3.FunctionType);
			MetaPathParameterValues.Add("702fea70-3f23-4480-8b9f-b553d0a194a6", () => ReadDataUserTask3.AggregationColumnName);
			MetaPathParameterValues.Add("9bcb9ea2-2f79-4c66-be40-60fc89827613", () => ReadDataUserTask3.OrderInfo);
			MetaPathParameterValues.Add("492ae6cd-2386-4f94-b3dc-ecfe0a561e90", () => ReadDataUserTask3.ResultEntity);
			MetaPathParameterValues.Add("2fabbf13-01ca-42c6-9f0d-07f14a79d614", () => ReadDataUserTask3.ResultCount);
			MetaPathParameterValues.Add("96c84c00-2797-4646-a698-7f02695068c7", () => ReadDataUserTask3.ResultIntegerFunction);
			MetaPathParameterValues.Add("6356bc10-9b8b-4a7c-b5e7-8b18ccb8d4cd", () => ReadDataUserTask3.ResultFloatFunction);
			MetaPathParameterValues.Add("c5c8881b-1545-4573-bffe-420faeaa97bc", () => ReadDataUserTask3.ResultDateTimeFunction);
			MetaPathParameterValues.Add("64c177fe-eb36-4a4b-b7ae-91f33fcd1623", () => ReadDataUserTask3.ResultRowsCount);
			MetaPathParameterValues.Add("18bfd995-e4af-4ba7-9844-31322fbc7da7", () => ReadDataUserTask3.CanReadUncommitedData);
			MetaPathParameterValues.Add("753cf6dc-9ea4-44fd-adc1-48898e488426", () => ReadDataUserTask3.ResultEntityCollection);
			MetaPathParameterValues.Add("e8af8fcc-bceb-41bc-99dd-9e7f54a2cc6e", () => ReadDataUserTask3.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("55390786-dd46-43fb-add4-4f851434760e", () => ReadDataUserTask3.IgnoreDisplayValues);
			MetaPathParameterValues.Add("4fbec98f-004d-4f1f-87a7-b668063d0884", () => ReadDataUserTask3.ResultCompositeObjectList);
			MetaPathParameterValues.Add("de308fad-dcf4-42c5-832a-534722bee38f", () => ReadDataUserTask3.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("a244c08e-bd09-4ca7-8a99-1077520a1ec5", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("31b660b1-300f-4f12-a4b2-98efc57cd867", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("441998e4-8821-4d10-8a9c-40c050c8dd78", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("dde1dd64-30a8-4ef6-b1d1-6d6d6661ac9b", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("1d10b34a-77ec-4277-99b6-ce89fe7cd27d", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("b80339a8-820c-40b9-aa5e-7542914dc2df", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("94e9a24c-27da-4f2f-898d-31e395dc6cc2", () => AddDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("977cad3d-2c65-430b-8902-f756c05291e4", () => ReadDataUserTask4.DataSourceFilters);
			MetaPathParameterValues.Add("9c6f141c-5da9-4856-8b61-9f48b7911781", () => ReadDataUserTask4.ResultType);
			MetaPathParameterValues.Add("4e3be632-b70c-4b4c-8308-380d8171b89f", () => ReadDataUserTask4.ReadSomeTopRecords);
			MetaPathParameterValues.Add("a4a0e571-6551-46d8-9aa9-dd1afda8956c", () => ReadDataUserTask4.NumberOfRecords);
			MetaPathParameterValues.Add("e3c26302-9b0d-4a54-8335-90d353b47af9", () => ReadDataUserTask4.FunctionType);
			MetaPathParameterValues.Add("3be3fe2d-ee9f-45c2-915c-ea7ebe38b5e3", () => ReadDataUserTask4.AggregationColumnName);
			MetaPathParameterValues.Add("9f627d7b-d9c3-4a70-aa62-1e7d41fa025c", () => ReadDataUserTask4.OrderInfo);
			MetaPathParameterValues.Add("d5304989-02e5-4d55-9d1d-091d6ef8ca92", () => ReadDataUserTask4.ResultEntity);
			MetaPathParameterValues.Add("1217e6ca-8d64-4667-ae20-c8be0b49ba25", () => ReadDataUserTask4.ResultCount);
			MetaPathParameterValues.Add("48649703-f62f-4c0f-a38e-076044d6d4b2", () => ReadDataUserTask4.ResultIntegerFunction);
			MetaPathParameterValues.Add("fd373003-c24e-424c-b3c5-56117473ca44", () => ReadDataUserTask4.ResultFloatFunction);
			MetaPathParameterValues.Add("2b34f769-63d0-497e-ba58-140a71c665cd", () => ReadDataUserTask4.ResultDateTimeFunction);
			MetaPathParameterValues.Add("dcbdb688-b666-4348-9e82-b8f414a14ff9", () => ReadDataUserTask4.ResultRowsCount);
			MetaPathParameterValues.Add("97d4b158-03da-42e6-8e2d-9c1391a6e264", () => ReadDataUserTask4.CanReadUncommitedData);
			MetaPathParameterValues.Add("23ad489e-59f4-4704-a50f-89d316ef79aa", () => ReadDataUserTask4.ResultEntityCollection);
			MetaPathParameterValues.Add("07605453-95da-4cae-bb85-94983ae46c6d", () => ReadDataUserTask4.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("4df5accf-b45e-4785-839d-c9360472a236", () => ReadDataUserTask4.IgnoreDisplayValues);
			MetaPathParameterValues.Add("dd5564ee-277d-43ad-bbc6-bf73ebd13b2e", () => ReadDataUserTask4.ResultCompositeObjectList);
			MetaPathParameterValues.Add("5b165516-cbae-4f7a-b065-9fbf5cb28241", () => ReadDataUserTask4.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "IsCloseAndExit":
					if (!hasValueToRead) break;
					IsCloseAndExit = reader.GetValue<System.Boolean>();
				break;
				case "TemplateId":
					if (!hasValueToRead) break;
					TemplateId = reader.GetValue<System.Guid>();
				break;
				case "SenderEmail":
					if (!hasValueToRead) break;
					SenderEmail = reader.GetValue<System.String>();
				break;
				case "Subject":
					if (!hasValueToRead) break;
					Subject = reader.GetValue<System.String>();
				break;
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var activityId = AddDataUserTask1.RecordId;
			if (UserConnection.GetIsFeatureEnabled("UseAsyncEmailSender")) {
				AsyncEmailSender emailSender = new AsyncEmailSender(UserConnection);
				emailSender.SendAsync(activityId);
			} else {
				var emailClientFactory = ClassFactory.Get<EmailClientFactory>(new ConstructorArgument("userConnection", UserConnection));
				var activityEmailSender = new ActivityEmailSender(emailClientFactory, UserConnection);
				activityEmailSender.Send(activityId);
			}
				
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localSubject = (((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null))).IndexOf("RE: ") == 0 ? (((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null))) : "RE: " + (((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null)));
			Subject = (System.String)localSubject;
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			SenderEmail = Terrasoft.Core.Configuration.SysSettings.GetValue<string>(UserConnection, 
				"SupportServiceEmail", string.Empty);
			if (UserConnection.GetIsFeatureEnabled("EmailMessageMultiLanguage") || UserConnection.GetIsFeatureEnabled("EmailMessageMultiLanguageV2")) {
				IsCloseAndExit = true;
				var caseRecordId = (StartSignal1.RecordId != Guid.Empty)
					? StartSignal1.RecordId 
					: StartSignal2.RecordId;
			    using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection())
			    {
			    	var caseOwnerSelectQuery =
					    new Select(UserConnection).Top(1)
								.Column("Case", "OwnerId")
								.Column("Case", "ModifiedById")
								.Column("Contact", "Email")
							.From("Case")
								.InnerJoin("Contact")
									.On("Case", "OwnerId").IsEqual("Contact", "Id")
							.Where("Case", "Id").IsEqual(Column.Const(caseRecordId)) as Select;
			        using (IDataReader reader = caseOwnerSelectQuery.ExecuteReader(dbExecutor))
			        {
				        while (reader.Read())
				        {
					        var owner = reader.GetColumnValue<Guid>("OwnerId");
					        var modifiedBy = reader.GetColumnValue<Guid>("ModifiedById");
					        var assignee = reader.GetColumnValue<string>("Email");
					        var isModifiedByOwner = owner == modifiedBy;
					        if (!isModifiedByOwner) {
						        var parameters = new Dictionary<string, object>()
						        {
							        { "CaseRecordId", caseRecordId },
							        { "EmailTemplateId", CaseConsts.AssigneeTemplateId },
							        { "Recipient", assignee }
						        };
								AppScheduler.TriggerJob<SendMultiLanguageNotification>(string.Concat("SendMultiLanguageNotificationExecutorGroup", "_", caseRecordId),
									UserConnection.Workspace.Name, UserConnection.CurrentUser.Name, parameters, true);
					        }
						}
			        }
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
			var cloneItem = (SendEmailToSROwner)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


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
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;
	using Terrasoft.Mail.Sender;

	#region Class: SendEmailToCaseContactProcessSchema

	/// <exclude/>
	public class SendEmailToCaseContactProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SendEmailToCaseContactProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SendEmailToCaseContactProcessSchema(SendEmailToCaseContactProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendEmailToCaseContactProcess";
			UId = new Guid("010a69df-55e1-475c-937c-0184594f2e41");
			CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsActiveVersion = false;
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
			RealUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41");
			Version = 0;
			PackageUId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCaseIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2182c543-89b6-4709-8a44-0ccc49d8c85a"),
				ContainerUId = Guid.Empty,
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
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTemplateIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d30737ec-df8a-4aeb-805c-7bc8649175e6"),
				ContainerUId = Guid.Empty,
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
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3da60100-fb70-4440-a82a-0ee88ccc4b13"),
				ContainerUId = Guid.Empty,
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
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7f0cb231-3dda-4b22-a6ea-e79291d7ee8c"),
				ContainerUId = Guid.Empty,
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
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateParentActivityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("be5104c4-7adc-4c31-a4a7-99463c431b36"),
				ContainerUId = Guid.Empty,
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
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{70ba378d-c705-4902-a786-2c2d4f623c91}].[Parameter:{de51c882-736f-4db7-9a1b-bb605ec75208}].[EntityColumn:{b59a15ea-751e-4fd8-8281-f1a3dc7190ff}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseIdParameter());
			Parameters.Add(CreateTemplateIdParameter());
			Parameters.Add(CreateSenderEmailParameter());
			Parameters.Add(CreateSubjectParameter());
			Parameters.Add(CreateParentActivityIdParameter());
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2240c0c2-4f40-423c-8b95-f111c72bbfd9"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,77,111,219,48,12,253,43,131,207,85,97,59,254,144,115,27,178,108,232,101,45,208,160,151,185,7,90,162,19,97,254,130,164,116,203,130,252,247,81,182,227,165,67,134,166,189,172,190,88,122,120,124,124,164,200,189,39,42,48,230,43,212,232,205,189,21,106,13,166,45,237,245,103,85,89,212,95,116,187,237,188,43,207,160,86,80,169,95,40,7,124,41,149,253,4,22,40,100,159,255,81,200,189,121,126,94,35,247,174,114,79,89,172,13,113,40,68,6,41,47,35,201,89,26,38,5,139,210,24,24,164,65,204,210,0,18,95,22,25,150,60,26,152,255,18,95,180,117,7,26,135,28,189,124,217,31,87,187,206,81,3,2,68,79,81,166,109,70,112,230,76,152,101,3,69,133,146,238,86,111,145,32,171,85,77,213,224,74,213,120,7,154,114,57,157,214,65,68,42,161,50,142,85,97,105,151,63,59,141,198,168,182,121,201,92,181,173,155,83,54,9,224,116,29,237,248,189,71,199,188,3,187,233,37,110,200,214,161,119,249,113,189,214,184,6,171,158,78,77,124,199,93,207,187,172,127,20,32,233,149,30,160,218,226,73,206,231,149,44,160,179,67,65,67,122,34,104,181,222,92,92,235,212,177,151,202,13,9,236,142,228,11,53,207,214,16,38,4,62,57,96,80,57,30,115,239,219,141,185,253,209,160,190,23,27,172,97,232,218,227,53,161,127,1,147,254,124,31,6,60,20,113,52,99,60,43,18,234,164,159,49,14,81,196,124,33,68,148,73,46,120,12,135,199,193,135,50,93,5,187,135,41,221,2,12,126,24,123,230,126,4,241,140,115,240,131,144,5,113,152,178,40,132,132,241,52,70,150,149,24,250,50,148,179,56,166,216,131,251,220,75,180,107,37,160,186,237,80,195,248,8,254,249,25,125,54,220,174,126,221,182,118,168,106,234,159,179,211,123,57,78,73,201,11,89,202,89,202,132,224,206,12,217,202,252,50,101,73,129,144,100,89,0,34,40,200,12,45,184,107,241,125,187,213,98,92,40,51,108,246,155,54,246,63,236,225,107,86,235,236,112,95,50,172,239,101,12,223,205,164,29,188,195,111,251,130,65,241,63,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b46a95f8-c76e-49f0-a82f-3277d460a1f6"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("db33b5a6-46aa-47ff-8e4b-5e13fdb80187"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("77acc736-6e4a-4799-8893-f31e6c67dd35"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("576434f3-e5c5-4731-be98-011701f8c85c"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8aa5b82c-3a24-4b4e-b291-b0353a2dc144"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				UId = new Guid("0b953ab2-858c-4dd9-9bce-9d641ba01668"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("de51c882-736f-4db7-9a1b-bb605ec75208"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1a5ebf76-4ad7-4eb7-81fd-71180b9cf610"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				UId = new Guid("c4106eb8-5ed0-42c8-b84f-34b0294210ca"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				UId = new Guid("51459f74-5d40-4e53-8ac7-ffca49ce3463"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				UId = new Guid("76c7a624-b7e2-4ab7-b03b-403b54d5cf2c"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				UId = new Guid("f5df9dd5-1461-4018-96ef-5e5408602213"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				UId = new Guid("4e739645-cfcf-4acb-b2c4-d98d6c2154ce"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("8453c16f-b75c-4362-9c4c-34a7a9599cbc"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dd247f81-c60d-43ef-a529-7e9e698f5f8a"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d72a4519-9e07-4c3a-ae50-fb5c05a32b5e"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				UId = new Guid("82c1a44f-a739-4a40-80cb-718991eb3256"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d8352102-f94b-4317-a726-65436dae68e9"),
				ContainerUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
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
				UId = new Guid("0ec419a6-4bb4-40da-806a-7aff639e25bd"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,203,110,19,49,20,253,149,104,214,117,53,15,207,195,217,161,18,80,55,180,162,85,55,164,139,107,207,117,106,49,47,217,78,161,68,249,119,174,103,210,144,162,160,6,54,32,49,43,207,209,185,199,231,190,188,137,84,3,206,125,128,22,163,121,116,139,214,130,235,181,63,127,103,26,143,246,189,237,215,67,116,22,57,180,6,26,243,13,235,9,95,212,198,191,5,15,20,178,89,254,80,88,70,243,229,113,141,101,116,182,140,140,199,214,17,135,66,210,92,228,74,10,193,114,0,100,60,78,129,85,53,22,76,171,68,168,36,209,160,117,53,49,127,37,126,209,183,3,88,156,238,24,229,245,120,188,125,26,2,53,33,64,141,20,227,250,110,7,102,193,132,91,116,32,27,172,233,223,219,53,18,228,173,105,41,27,188,53,45,94,131,165,187,130,78,31,32,34,105,104,92,96,53,168,253,226,235,96,209,57,211,119,175,153,107,214,109,119,200,38,1,220,255,238,236,196,163,199,192,188,6,255,48,74,92,146,173,237,232,242,205,106,101,113,5,222,60,30,154,248,140,79,35,239,180,250,81,64,77,93,186,131,102,141,7,119,190,204,228,2,6,63,37,52,93,79,4,107,86,15,39,231,186,175,216,107,233,166,4,14,207,228,19,53,143,230,144,22,4,62,6,96,82,121,62,46,163,79,151,238,234,75,135,246,70,61,96,11,83,213,238,207,9,253,9,88,52,216,98,231,231,155,50,150,144,149,85,205,84,25,231,140,139,56,101,80,86,5,75,85,90,115,93,164,153,18,201,150,2,246,134,230,155,26,243,68,85,85,202,202,172,208,140,215,178,100,2,18,201,164,44,226,28,85,153,167,113,21,66,22,157,55,254,105,154,132,249,166,200,68,161,121,129,76,113,65,81,90,38,172,202,227,154,85,41,175,10,161,117,204,101,182,189,159,210,53,110,104,224,233,110,159,213,71,132,122,166,192,225,44,84,130,214,202,58,63,11,203,52,235,245,140,106,188,110,188,233,86,51,26,165,6,85,232,37,205,95,231,65,249,81,46,244,148,68,106,145,105,94,98,194,80,87,21,227,73,33,152,20,101,201,74,37,42,153,241,58,43,165,160,217,11,95,24,145,126,101,20,52,87,3,90,216,77,71,124,124,121,94,108,93,104,140,237,123,63,149,123,223,216,67,59,207,19,172,50,14,165,84,9,19,168,82,198,129,35,147,5,114,42,163,168,133,20,18,19,204,201,15,61,62,33,233,155,126,109,213,110,217,221,244,234,252,209,107,242,23,222,136,223,89,251,163,139,119,202,34,253,103,43,242,47,205,244,54,218,126,7,172,145,81,107,69,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b0de42aa-d0a6-43c9-84cd-9298f4cb6c71"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("12b7121c-ee28-40f6-89c1-935e8b7d7ca7"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("df939b4e-dde0-4d27-824d-3ce613d1a8df"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("70545f3a-7add-45c7-ba78-4585c9bf7ee7"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ba3c18dd-7276-4d59-a388-7dd72332309c"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				UId = new Guid("7569fb84-ca21-4722-9617-c42bd11f787f"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("e88f81f6-bb4f-4667-8712-8244a108432a"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("13f6b58c-3dac-47b1-8c2a-67b10c00b042"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				UId = new Guid("f661c175-85bd-46e2-be1b-f8f2696bed90"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				UId = new Guid("c3e9fc0d-0126-49b4-b41c-42ce78706d8d"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				UId = new Guid("eb5bda7b-e48e-4c43-a503-e9218b4bf960"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				UId = new Guid("1a676d4f-b1c2-4fb2-ad01-f5ebd45a6e19"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				UId = new Guid("b6d720fe-0e34-42a7-8e39-608e8b72fb38"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				UId = new Guid("89bf6187-da0e-4a92-9f82-dffbe82cc14c"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc3b7c87-0f42-4827-bc59-66107a5f6680"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a9eeba5-9cd2-4b31-b5da-2bb820239f2a"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				UId = new Guid("02f9d1b3-8602-4fe1-84ab-08e9073bfef7"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e4c1a70-a584-4670-9b78-58387ea2f83f"),
				ContainerUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
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
				UId = new Guid("f8d2ec88-506d-4044-908d-a191e3892bb2"),
				ContainerUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
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
				UId = new Guid("21eff95f-b71a-4567-861f-65486cfabf8f"),
				ContainerUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
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
				UId = new Guid("47f64290-f732-4e87-9a44-4cf2485d1240"),
				ContainerUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{2182c543-89b6-4709-8a44-0ccc49d8c85a}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var templateIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4f0a1a14-83f4-4436-9927-3286a76c15e2"),
				ContainerUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d30737ec-df8a-4aeb-805c-7bc8649175e6}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(templateIdParameter);
			var sysEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5f5844ae-4b77-4818-8542-1f6474d6e62c"),
				ContainerUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{68684123-fbf5-4c0a-a480-775f630307b9}].[Parameter:{8e42a1ac-c457-45b8-8e4d-7e6e530c82aa}].[EntityColumn:{ed98cf3e-1642-4755-acb2-a61181429306}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(sysEntitySchemaIdParameter);
		}

		protected virtual void InitializeAddActivityDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("78fa348b-febc-4c15-9ab7-8db84e2baf7a"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a251d4b1-48d0-4b81-bd57-227f8c042748"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5464c2e0-a7bf-468f-ba2c-a086e8b7cb5b"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("8d80b754-2b5d-4731-ada2-68af17a0c8be"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eef95653-dcf6-49d4-b0e9-a9f6f4c8b03d"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,89,91,111,91,69,16,254,43,150,65,226,37,107,237,253,146,55,40,69,68,106,161,106,129,151,166,15,179,179,179,173,193,177,43,251,4,20,162,252,119,190,227,36,244,2,184,9,40,77,145,236,135,88,103,189,151,57,51,243,205,247,205,230,124,250,249,112,246,90,166,135,211,31,100,189,166,205,170,15,179,7,171,181,204,158,172,87,44,155,205,236,209,138,105,49,255,157,234,66,158,208,154,78,100,144,245,79,180,56,149,205,163,249,102,56,152,188,187,108,122,48,253,252,215,237,175,211,195,231,231,211,163,65,78,126,60,106,216,189,229,210,51,7,173,116,45,65,121,145,162,136,169,169,210,106,208,222,248,90,178,198,98,94,45,78,79,150,143,101,160,39,52,188,154,30,158,79,183,187,97,3,223,184,107,114,70,165,222,146,242,173,146,34,173,189,18,111,92,53,41,56,239,204,244,226,96,186,225,87,114,66,219,67,223,44,102,239,75,203,206,42,242,204,202,87,109,84,45,45,168,76,198,178,183,4,219,202,184,248,106,254,155,133,207,63,123,126,180,249,254,183,165,172,159,109,247,61,236,180,216,200,139,25,70,223,27,248,211,57,135,231,169,107,174,22,166,186,214,8,167,89,156,27,133,148,164,98,139,105,73,36,243,197,139,207,94,140,39,182,249,230,245,130,206,126,250,235,193,207,78,235,207,194,195,229,180,215,239,184,254,237,137,231,199,151,17,60,158,30,30,255,83,12,175,190,47,45,126,55,138,239,7,240,120,122,112,60,125,182,58,93,243,184,163,195,195,215,111,89,184,61,100,59,229,189,199,235,136,97,100,121,186,88,92,141,124,77,3,93,79,188,30,94,181,121,159,75,59,90,62,187,14,212,118,23,125,245,81,127,243,231,250,115,105,219,127,89,246,152,150,244,82,214,223,193,1,111,108,255,211,202,31,224,198,235,141,3,147,11,221,104,69,6,201,226,57,38,69,37,146,114,217,53,138,212,137,59,111,87,63,149,46,107,89,178,252,75,195,158,202,102,235,237,17,42,87,118,141,174,186,152,94,92,28,188,13,32,79,148,117,20,171,156,103,171,188,67,234,23,164,181,18,228,84,241,214,177,143,105,39,128,130,47,134,157,235,227,10,0,136,41,43,10,169,168,230,179,209,66,193,115,136,119,1,160,71,171,213,47,167,175,103,41,84,223,92,169,42,132,54,238,208,162,202,13,254,117,221,23,10,185,149,200,105,38,54,59,211,132,21,188,171,85,235,6,199,104,221,225,53,211,162,150,226,50,199,15,225,230,234,188,47,121,152,255,58,31,206,38,35,56,102,15,79,104,190,216,67,233,94,160,84,109,9,58,153,174,146,80,65,233,143,118,140,60,169,98,74,237,46,57,219,187,221,5,165,155,100,206,173,160,100,65,56,54,137,6,8,12,12,2,171,168,18,125,86,154,90,175,137,107,236,173,237,132,82,52,89,82,208,78,101,80,143,242,193,54,69,228,240,216,83,68,141,207,193,213,112,159,92,244,112,33,39,178,28,14,207,115,114,236,70,154,13,198,11,222,212,91,85,82,130,39,117,213,161,120,173,171,177,23,239,146,151,53,210,123,9,93,213,132,24,249,128,194,151,35,130,23,131,207,145,59,213,158,251,135,201,235,91,90,182,133,76,224,114,76,24,100,210,87,235,137,140,24,156,252,54,31,94,77,78,136,215,171,205,236,171,85,59,219,131,242,94,64,201,186,107,31,71,34,136,22,64,168,40,183,217,75,80,197,155,210,56,7,19,171,249,168,252,86,27,248,86,123,240,145,171,117,172,18,192,148,105,86,137,225,14,172,229,22,122,223,205,111,182,154,40,45,171,8,162,6,180,53,196,101,206,120,193,74,153,43,84,167,147,242,137,8,196,81,66,104,3,111,161,220,192,249,222,67,102,100,75,74,67,25,102,102,246,213,184,27,8,68,89,54,89,127,177,185,4,214,30,71,247,130,163,214,170,35,35,162,116,146,140,182,4,228,86,19,104,174,105,1,75,140,226,165,182,143,138,35,83,173,137,25,226,14,189,7,200,45,36,3,110,66,201,47,177,90,45,32,46,215,203,78,28,161,119,9,35,41,171,172,81,20,188,161,10,157,8,42,200,20,116,49,222,81,201,245,147,32,183,170,45,26,64,147,84,209,192,142,151,140,55,13,12,69,220,24,133,13,29,101,203,245,61,114,3,188,122,54,61,170,90,125,71,233,27,201,45,25,232,17,235,61,132,126,246,206,210,184,228,225,114,128,116,124,176,245,209,225,121,171,221,106,59,170,82,64,85,249,4,41,82,185,123,213,178,132,106,114,116,86,155,15,195,245,169,80,155,240,106,57,16,15,147,134,92,154,125,51,95,111,134,201,28,161,155,172,250,100,45,155,211,197,48,95,190,196,164,197,2,157,223,124,181,220,235,214,61,69,190,129,182,131,54,3,193,17,200,162,35,123,147,129,110,13,150,149,84,226,64,149,44,218,195,221,119,40,137,125,99,143,164,15,22,181,1,53,74,81,236,164,186,5,166,81,30,184,25,247,137,80,164,53,217,114,240,208,212,165,130,205,147,46,56,8,232,211,35,61,194,14,248,159,62,140,185,7,180,145,201,81,219,3,232,94,0,244,95,27,63,99,82,195,36,68,222,166,0,42,115,30,0,52,70,25,142,209,152,192,82,184,221,10,64,68,204,2,145,165,170,171,35,55,186,160,106,47,164,162,173,173,184,106,125,239,121,39,128,168,7,74,174,57,5,42,5,6,80,8,84,198,203,40,19,18,204,49,224,216,102,239,240,14,197,87,155,34,161,255,77,134,209,119,86,152,94,165,52,229,82,25,73,79,107,99,251,44,245,216,192,241,94,117,23,97,153,71,167,172,99,102,152,204,221,233,234,10,60,127,195,59,148,199,72,120,196,250,242,10,229,251,211,225,229,10,244,180,7,211,255,18,76,55,201,157,91,129,73,71,102,202,232,95,106,234,78,121,170,162,178,163,166,44,249,194,86,123,97,217,125,33,201,217,248,78,208,167,162,13,58,62,103,131,34,206,13,175,229,201,22,39,32,163,124,135,96,42,209,136,213,57,162,205,180,56,190,129,232,171,30,255,55,161,171,145,8,37,207,172,103,89,187,76,14,253,100,202,48,15,134,26,0,62,134,241,66,50,132,166,97,180,246,183,189,144,100,26,228,229,106,125,182,23,119,255,99,56,221,36,123,110,119,255,81,153,146,214,85,137,51,72,104,7,178,171,99,166,81,141,25,213,92,34,165,221,220,148,117,7,98,96,66,18,139,78,52,7,136,187,16,35,200,179,83,137,227,45,136,190,131,190,109,88,227,107,71,250,95,255,190,79,240,143,156,224,69,215,24,106,207,74,247,142,136,66,7,160,213,77,69,89,143,180,77,137,122,209,233,174,187,151,23,23,127,0,187,250,69,63,95,30,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d07a51ae-6eef-4fae-8974-16c453d75d56"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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
				UId = new Guid("d528a520-ffc6-45f3-a441-037cf090d3ad"),
				ContainerUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
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

		protected virtual void InitializeReadDataUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3c44ff41-7d4f-4045-985d-f5591d95f153"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,193,142,155,48,20,252,23,206,235,21,193,6,146,189,85,217,180,183,54,82,162,158,114,121,152,103,98,173,137,145,109,86,77,87,249,247,218,144,164,137,196,106,217,74,81,91,237,13,70,227,97,222,120,120,47,17,87,96,237,87,168,49,122,136,214,104,12,88,45,220,253,103,169,28,154,47,70,183,77,116,23,89,52,18,148,252,137,101,143,47,74,233,30,193,129,63,242,178,249,173,176,137,30,54,195,26,155,232,110,19,73,135,181,245,28,127,100,74,69,82,64,62,33,40,18,70,88,76,11,2,5,23,4,153,160,60,77,121,9,105,218,51,95,19,159,235,186,1,131,253,55,58,121,209,61,174,247,77,160,78,60,192,59,138,180,122,119,4,105,48,97,23,59,40,20,150,254,221,153,22,61,228,140,172,253,52,184,150,53,46,193,248,111,5,29,29,32,79,18,160,108,96,41,20,110,241,163,49,104,173,212,187,183,204,169,182,222,93,178,189,0,158,95,143,118,226,206,99,96,46,193,109,59,137,94,235,208,249,252,84,85,6,43,112,242,249,210,198,19,238,59,230,184,4,253,129,210,223,211,119,80,45,94,36,115,61,203,28,26,215,143,116,50,224,41,70,86,219,209,243,158,83,123,107,228,196,131,205,137,60,82,115,112,138,100,234,193,231,0,116,199,230,96,67,110,135,144,28,229,37,159,98,156,19,198,121,74,24,99,156,20,60,79,9,82,90,210,25,38,49,205,39,31,177,91,171,189,93,2,127,130,10,239,199,215,108,92,152,239,174,217,181,145,255,183,110,33,66,165,43,201,65,125,107,208,192,113,192,120,184,12,87,45,202,194,212,90,187,21,223,98,13,103,71,254,150,122,164,243,113,186,134,28,178,56,79,104,70,138,28,5,97,41,103,4,104,158,17,49,73,138,12,217,76,204,178,196,27,242,171,58,56,95,233,214,240,99,125,109,191,163,255,104,247,254,133,214,191,111,73,14,182,102,76,11,110,178,78,254,209,184,6,255,251,155,39,119,211,63,227,16,29,126,1,249,234,133,188,185,8,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8f65b044-884b-49ca-9219-5baf24f17958"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5523d04c-3e1b-4f60-9563-9e520dac2c6c"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a8f08199-d9c0-4005-9c94-7c03f7670d2e"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ebd74111-6e32-475d-ab86-716f0976612e"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("573cfd72-52b9-4c1e-a621-58e6e1c6ce39"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				UId = new Guid("524f3776-d1c5-42c1-a379-e9b3d4ea79d5"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("8e42a1ac-c457-45b8-8e4d-7e6e530c82aa"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0e982666-3fc9-4b3d-bf43-1c31a8e6cb53"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				UId = new Guid("ac82296a-e4a2-4f63-8ecf-fc2befdcc54e"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				UId = new Guid("2ce6abdb-47e7-4462-a89a-faa0c73eff6e"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				UId = new Guid("5e71482a-fa3d-496e-aab2-d15119381051"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				UId = new Guid("5af71371-6345-46b7-91d8-531f111fc281"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				UId = new Guid("7ee2a87a-3e6d-4e07-bf35-2fba8030ddcd"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("e505355f-473f-4baf-a0c5-a7acfe566ab9"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("65c22ff4-89c4-41cc-9507-4121365b392c"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("898740ca-c0ac-43d9-bb83-01db84a4e988"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				UId = new Guid("3bc5196e-ec53-438d-bad5-a9917f44ba81"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4cb4efcb-23d5-4943-87bc-d3837e241587"),
				ContainerUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
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

		protected virtual void InitializeReadDataUserTask4Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("01c24e99-0525-4c53-bd4b-2b34f9d3766f"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,77,79,227,48,16,253,43,200,103,130,154,143,126,222,16,20,196,5,144,168,184,16,14,83,103,146,90,56,113,100,59,236,150,42,255,157,113,92,66,65,69,116,145,86,187,57,57,79,207,111,222,60,207,108,24,151,96,204,53,148,200,102,108,129,90,131,81,185,61,185,16,210,162,190,212,170,169,217,49,51,168,5,72,241,130,153,199,231,153,176,231,96,129,174,108,210,119,133,148,205,210,253,26,41,59,78,153,176,88,26,226,208,149,201,40,25,142,151,241,40,192,44,138,130,36,204,135,193,116,28,77,130,152,135,131,48,130,101,60,156,68,158,249,149,248,153,42,107,208,232,107,116,242,121,119,92,172,107,71,13,9,224,29,69,24,85,109,193,216,153,48,243,10,150,18,51,250,183,186,65,130,172,22,37,117,131,11,81,226,45,104,170,229,116,148,131,136,148,131,52,142,37,49,183,243,223,181,70,99,132,170,190,51,39,155,178,218,101,147,0,246,191,91,59,131,206,163,99,222,130,93,117,18,87,100,171,237,92,158,22,133,198,2,172,120,222,53,241,132,235,142,119,88,126,116,33,163,87,186,7,217,224,78,205,143,157,156,65,109,125,67,190,60,17,180,40,86,7,247,218,39,246,93,187,17,129,245,27,249,64,205,189,61,68,35,2,159,29,224,85,222,142,41,123,184,50,55,191,42,212,119,124,133,37,248,212,30,79,8,253,4,244,250,179,205,18,135,225,32,225,73,48,134,140,7,9,143,195,0,18,24,7,211,105,50,138,121,18,135,148,114,251,232,125,8,83,75,88,223,247,229,72,6,43,123,4,156,94,73,88,122,153,214,125,46,97,85,8,14,242,166,70,13,219,112,7,251,103,239,195,208,186,190,180,82,214,187,237,115,57,237,245,119,38,128,138,209,98,186,104,238,84,163,249,118,17,140,223,200,31,109,218,63,216,159,63,89,137,189,67,121,200,144,253,23,227,243,183,39,163,101,237,43,18,83,210,84,203,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c7d73d91-0514-42af-999d-7a34d7ec0e95"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				UId = new Guid("eeb351c9-365d-423c-800b-a2a013bab823"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				UId = new Guid("71bd15f4-6282-4eae-a7e9-6faa031d959e"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				UId = new Guid("3f1dbb68-9a58-49b3-a323-5ac45052dfef"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2056ce2f-42d8-4fd2-bf24-61ea6742c3dd"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				UId = new Guid("7f067451-f8bd-4ba8-942d-d6a482207da2"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("95cb3a8c-de47-4ebf-ab83-44e2e6e9b06e"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a0062d8b-80ae-4931-8d0d-9e40b6beed2a"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				UId = new Guid("e646785e-110f-4438-bc03-5a65ff0404d2"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				UId = new Guid("45fdb25d-4878-4115-a5db-f8c6a0d63fdb"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				UId = new Guid("6c591f23-80f8-405f-bcf7-acb6c98329e5"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				UId = new Guid("5764dd4b-f9ff-4af0-ad7a-a37ba669478c"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				UId = new Guid("177a98fd-0f17-4427-86c0-92b3fd286f79"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				UId = new Guid("8071ca0f-90db-43d4-8161-5e54d91f00ea"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				UId = new Guid("f92969bc-781b-4b37-b423-62af4cbe765b"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3bcea3e3-3e90-4842-98a1-348ce8d75cc4"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				UId = new Guid("aada065d-4bf3-47e6-a1d2-45f360ece43f"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2a1bd4d1-2389-4180-8a78-b66acff9df8b"),
				ContainerUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
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
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaUserTask fillemailusertask = CreateFillEmailUserTaskUserTask();
			FlowElements.Add(fillemailusertask);
			ProcessSchemaUserTask addactivitydatausertask = CreateAddActivityDataUserTaskUserTask();
			FlowElements.Add(addactivitydatausertask);
			ProcessSchemaUserTask readdatausertask3 = CreateReadDataUserTask3UserTask();
			FlowElements.Add(readdatausertask3);
			ProcessSchemaScriptTask sendmailscripttask = CreateSendMailScriptTaskScriptTask();
			FlowElements.Add(sendmailscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask4 = CreateReadDataUserTask4UserTask();
			FlowElements.Add(readdatausertask4);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("9ddc1a0b-a466-47d2-82b5-83aa49438994"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7f074929-411d-41a1-9f14-36b4e42641af"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(83, 101));
			schemaFlow.PolylinePointPositions.Add(new Point(83, 87));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("a2e8ef78-e0cb-4b03-80ee-1ef683b0ed83"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{70ba378d-c705-4902-a786-2c2d4f623c91}].[Parameter:{de51c882-736f-4db7-9a1b-bb605ec75208}].[EntityColumn:{6396f46e-c49f-4fb1-850d-824869ff04b3}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(430, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(240, 87));
			schemaFlow.PolylinePointPositions.Add(new Point(240, 107));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow2",
				UId = new Guid("35dcb8df-533d-48b8-aa1d-33128db9836d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(438, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("24ec1bfd-0193-4b66-b797-b1118b9a6f2a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(154, 30));
			schemaFlow.PolylinePointPositions.Add(new Point(1186, 30));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("f07aee8e-1621-486d-92b1-1591317f60c2"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{b0200417-902a-4e81-a5c4-edc6274b9d8b}].[Parameter:{e88f81f6-bb4f-4667-8712-8244a108432a}].[EntityColumn:{dbf202ec-c444-479b-bcf4-d8e5b1863201}]#] != string.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(522, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(325, 332));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("598e616a-5180-40f1-a0ab-9f92b088b9bb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(528, 197),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("24ec1bfd-0193-4b66-b797-b1118b9a6f2a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(325, 50));
			schemaFlow.PolylinePointPositions.Add(new Point(1186, 50));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("44c5fa4c-0096-49bc-ad9a-40266638707f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(722, 202),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b2f6e645-ba3c-41d5-8709-1dc94bbb5be1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("b4bd0bb9-d007-42c8-a087-feac9a3ed139"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(628, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(494, 332));
			schemaFlow.PolylinePointPositions.Add(new Point(494, 152));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("e72d381c-dce6-4ad4-8896-113ee36b7e48"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(722, 202),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b2f6e645-ba3c-41d5-8709-1dc94bbb5be1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("24ec1bfd-0193-4b66-b797-b1118b9a6f2a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1136, 307));
			schemaFlow.PolylinePointPositions.Add(new Point(1136, 193));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("261cef82-4b0a-4d18-8b5b-aa42470fb2fd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1db9fc77-db99-4250-918d-046db047f9a5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("0c2036ff-eec7-4fed-8a49-c46b3cf449a6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1db9fc77-db99-4250-918d-046db047f9a5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(945, 152));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("5880c05f-f6d8-4064-bb1f-0c7b60536fb5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{70ba378d-c705-4902-a786-2c2d4f623c91}].[Parameter:{de51c882-736f-4db7-9a1b-bb605ec75208}].[EntityColumn:{a93cb111-ce30-4da4-89ec-d2a2f3dd71c4}]#]==[#Lookup.b17869fe-43f9-487a-af82-b7626f1fc810.7f9e1f1e-f46b-1410-3492-0050ba5d6c38#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1db9fc77-db99-4250-918d-046db047f9a5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("fb4832f6-f288-41c6-97da-95371a8537c1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("320c19cd-a242-47b6-9d55-21bac6ccbe86"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("917d22fe-13e7-4464-9603-0f46fd69e64b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("320c19cd-a242-47b6-9d55-21bac6ccbe86"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(945, 438));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("dae6eec2-f54b-41ae-aabb-69a51383693f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("dae6eec2-f54b-41ae-aabb-69a51383693f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("7f074929-411d-41a1-9f14-36b4e42641af"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"Start1",
				Position = new Point(20, 88),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("24ec1bfd-0193-4b66-b797-b1118b9a6f2a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"Terminate1",
				Position = new Point(1173, 180),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"ReadDataUserTask1",
				Position = new Point(120, 60),
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
				UId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"ReadDataUserTask2",
				Position = new Point(291, 80),
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
				UId = new Guid("873c3cad-514e-4042-977b-50b059400b12"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"FillEmailUserTask",
				Position = new Point(520, 125),
				SchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeFillEmailUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddActivityDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("157ccf72-d402-417b-8311-0635535d7e00"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"AddActivityDataUserTask",
				Position = new Point(911, 280),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddActivityDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4dbfae82-70d6-4c31-aacd-fc794e4811aa"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"ReadDataUserTask3",
				Position = new Point(400, 305),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSendMailScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b2f6e645-ba3c-41d5-8709-1dc94bbb5be1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"SendMailScriptTask",
				Position = new Point(1031, 280),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,77,10,194,48,16,133,247,130,119,8,93,165,32,189,64,85,8,245,135,110,213,30,32,52,131,4,219,4,38,147,74,111,239,68,42,34,113,21,102,222,188,239,61,50,105,20,186,39,59,89,154,91,35,118,66,25,163,150,249,160,73,119,1,240,166,195,163,186,64,239,209,180,166,94,175,38,246,192,168,237,208,12,22,28,157,216,239,113,102,111,51,232,16,150,177,58,3,109,143,217,213,94,58,120,138,198,187,64,24,211,70,225,61,142,172,203,34,114,20,11,14,56,222,187,98,35,186,159,69,89,46,209,159,186,111,248,21,156,1,228,236,132,85,185,34,243,162,25,152,185,127,152,85,122,228,247,111,210,25,2,69,116,130,171,67,253,2,3,155,136,48,58,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("1db9fc77-db99-4250-918d-046db047f9a5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"ExclusiveGateway1",
				Position = new Point(665, 125),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask4UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"ReadDataUserTask4",
				Position = new Point(658, 411),
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
				UId = new Guid("320c19cd-a242-47b6-9d55-21bac6ccbe86"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("65546fe6-cd1d-49c0-96d8-e09f7c342a01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41"),
				Name = @"FormulaTask1",
				Position = new Point(808, 411),
				ResultParameterMetaPath = @"7f0cb231-3dda-4b22-a6ea-e79291d7ee8c",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,144,177,106,195,48,20,69,127,69,36,75,66,43,35,89,178,165,24,66,7,227,193,147,75,50,6,15,79,210,83,98,176,229,34,187,180,197,228,223,235,102,236,39,100,61,112,184,156,187,187,108,47,245,212,124,5,140,103,123,195,1,10,15,253,132,109,178,210,127,160,234,113,192,48,23,139,202,140,245,10,129,130,55,140,202,84,167,212,164,10,168,211,42,207,52,183,144,235,244,190,10,239,16,97,192,25,99,177,28,50,107,4,104,75,29,74,69,37,26,79,193,104,65,165,196,20,115,60,24,150,227,159,82,133,185,155,127,202,177,255,28,66,177,72,103,61,3,193,169,242,110,181,156,89,39,25,147,20,37,23,134,171,76,72,193,239,237,182,221,39,117,112,248,221,248,221,230,84,21,100,243,74,206,115,236,194,181,28,135,15,136,221,52,134,164,137,174,11,208,215,215,48,70,44,97,194,61,57,30,9,35,111,228,25,14,32,107,244,163,156,188,60,69,207,47,137,154,8,140,150,2,0,0 }
			};
			
			return FormulaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6a058acc-ee02-4e77-b820-891e6bc0cb95"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("be966acc-af84-4226-9b13-0286de9ffd75"),
				Name = "Terrasoft.Mail.Sender",
				Alias = "",
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("06bb9208-0bbc-4847-80a8-8bc33de240ad"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3b91697b-7fa9-4a1d-b948-99807c7539c5"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("8394e686-2333-42c9-8ea4-7feddc53fa46")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SendEmailToCaseContactProcess(userConnection);
		}

		public override object Clone() {
			return new SendEmailToCaseContactProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("010a69df-55e1-475c-937c-0184594f2e41"));
		}

		#endregion

	}

	#endregion

	#region Class: SendEmailToCaseContactProcess

	/// <exclude/>
	public class SendEmailToCaseContactProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendEmailToCaseContactProcess process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, SendEmailToCaseContactProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = false;
				SchemaElementUId = new Guid("70ba378d-c705-4902-a786-2c2d4f623c91");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,77,111,219,48,12,253,43,131,207,85,97,59,254,144,115,27,178,108,232,101,45,208,160,151,185,7,90,162,19,97,254,130,164,116,203,130,252,247,81,182,227,165,67,134,166,189,172,190,88,122,120,124,124,164,200,189,39,42,48,230,43,212,232,205,189,21,106,13,166,45,237,245,103,85,89,212,95,116,187,237,188,43,207,160,86,80,169,95,40,7,124,41,149,253,4,22,40,100,159,255,81,200,189,121,126,94,35,247,174,114,79,89,172,13,113,40,68,6,41,47,35,201,89,26,38,5,139,210,24,24,164,65,204,210,0,18,95,22,25,150,60,26,152,255,18,95,180,117,7,26,135,28,189,124,217,31,87,187,206,81,3,2,68,79,81,166,109,70,112,230,76,152,101,3,69,133,146,238,86,111,145,32,171,85,77,213,224,74,213,120,7,154,114,57,157,214,65,68,42,161,50,142,85,97,105,151,63,59,141,198,168,182,121,201,92,181,173,155,83,54,9,224,116,29,237,248,189,71,199,188,3,187,233,37,110,200,214,161,119,249,113,189,214,184,6,171,158,78,77,124,199,93,207,187,172,127,20,32,233,149,30,160,218,226,73,206,231,149,44,160,179,67,65,67,122,34,104,181,222,92,92,235,212,177,151,202,13,9,236,142,228,11,53,207,214,16,38,4,62,57,96,80,57,30,115,239,219,141,185,253,209,160,190,23,27,172,97,232,218,227,53,161,127,1,147,254,124,31,6,60,20,113,52,99,60,43,18,234,164,159,49,14,81,196,124,33,68,148,73,46,120,12,135,199,193,135,50,93,5,187,135,41,221,2,12,126,24,123,230,126,4,241,140,115,240,131,144,5,113,152,178,40,132,132,241,52,70,150,149,24,250,50,148,179,56,166,216,131,251,220,75,180,107,37,160,186,237,80,195,248,8,254,249,25,125,54,220,174,126,221,182,118,168,106,234,159,179,211,123,57,78,73,201,11,89,202,89,202,132,224,206,12,217,202,252,50,101,73,129,144,100,89,0,34,40,200,12,45,184,107,241,125,187,213,98,92,40,51,108,246,155,54,246,63,236,225,107,86,235,236,112,95,50,172,239,101,12,223,205,164,29,188,195,111,251,130,65,241,63,6,0,0 })));
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

			private bool _readSomeTopRecords = false;
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

			public ReadDataUserTask2FlowElement(UserConnection userConnection, SendEmailToCaseContactProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = false;
				SchemaElementUId = new Guid("b0200417-902a-4e81-a5c4-edc6274b9d8b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,203,110,19,49,20,253,149,104,214,117,53,15,207,195,217,161,18,80,55,180,162,85,55,164,139,107,207,117,106,49,47,217,78,161,68,249,119,174,103,210,144,162,160,6,54,32,49,43,207,209,185,199,231,190,188,137,84,3,206,125,128,22,163,121,116,139,214,130,235,181,63,127,103,26,143,246,189,237,215,67,116,22,57,180,6,26,243,13,235,9,95,212,198,191,5,15,20,178,89,254,80,88,70,243,229,113,141,101,116,182,140,140,199,214,17,135,66,210,92,228,74,10,193,114,0,100,60,78,129,85,53,22,76,171,68,168,36,209,160,117,53,49,127,37,126,209,183,3,88,156,238,24,229,245,120,188,125,26,2,53,33,64,141,20,227,250,110,7,102,193,132,91,116,32,27,172,233,223,219,53,18,228,173,105,41,27,188,53,45,94,131,165,187,130,78,31,32,34,105,104,92,96,53,168,253,226,235,96,209,57,211,119,175,153,107,214,109,119,200,38,1,220,255,238,236,196,163,199,192,188,6,255,48,74,92,146,173,237,232,242,205,106,101,113,5,222,60,30,154,248,140,79,35,239,180,250,81,64,77,93,186,131,102,141,7,119,190,204,228,2,6,63,37,52,93,79,4,107,86,15,39,231,186,175,216,107,233,166,4,14,207,228,19,53,143,230,144,22,4,62,6,96,82,121,62,46,163,79,151,238,234,75,135,246,70,61,96,11,83,213,238,207,9,253,9,88,52,216,98,231,231,155,50,150,144,149,85,205,84,25,231,140,139,56,101,80,86,5,75,85,90,115,93,164,153,18,201,150,2,246,134,230,155,26,243,68,85,85,202,202,172,208,140,215,178,100,2,18,201,164,44,226,28,85,153,167,113,21,66,22,157,55,254,105,154,132,249,166,200,68,161,121,129,76,113,65,81,90,38,172,202,227,154,85,41,175,10,161,117,204,101,182,189,159,210,53,110,104,224,233,110,159,213,71,132,122,166,192,225,44,84,130,214,202,58,63,11,203,52,235,245,140,106,188,110,188,233,86,51,26,165,6,85,232,37,205,95,231,65,249,81,46,244,148,68,106,145,105,94,98,194,80,87,21,227,73,33,152,20,101,201,74,37,42,153,241,58,43,165,160,217,11,95,24,145,126,101,20,52,87,3,90,216,77,71,124,124,121,94,108,93,104,140,237,123,63,149,123,223,216,67,59,207,19,172,50,14,165,84,9,19,168,82,198,129,35,147,5,114,42,163,168,133,20,18,19,204,201,15,61,62,33,233,155,126,109,213,110,217,221,244,234,252,209,107,242,23,222,136,223,89,251,163,139,119,202,34,253,103,43,242,47,205,244,54,218,126,7,172,145,81,107,69,7,0,0 })));
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

			private bool _readSomeTopRecords = false;
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

			public FillEmailUserTaskFlowElement(UserConnection userConnection, SendEmailToCaseContactProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "FillEmailUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("873c3cad-514e-4042-977b-50b059400b12");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordId = () => (Guid)((process.CaseId));
				_templateId = () => (Guid)((process.TemplateId));
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

		#region Class: AddActivityDataUserTaskFlowElement

		/// <exclude/>
		public class AddActivityDataUserTaskFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddActivityDataUserTaskFlowElement(UserConnection userConnection, SendEmailToCaseContactProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddActivityDataUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("157ccf72-d402-417b-8311-0635535d7e00");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Title = () => new LocalizableString((process.Subject));
				_recordDefValues_Type = () => (Guid)(new Guid("e2831dec-cfc0-df11-b00f-001d60e938c6"));
				_recordDefValues_Body = () => new LocalizableString((process.FillEmailUserTask.Body));
				_recordDefValues_Sender = () => new LocalizableString((process.SenderEmail));
				_recordDefValues_Recepient = () => new LocalizableString(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>("Email") : null)));
				_recordDefValues_Case = () => (Guid)((process.CaseId));
				_recordDefValues_MessageType = () => (Guid)(new Guid("7f6d3f94-f36b-1410-068c-20cf30b39373"));
				_recordDefValues_ActivityCategory = () => (Guid)(new Guid("8038a396-7825-e011-8165-00155d043204"));
				_recordDefValues_IsHtmlBody = () => (bool)(true);
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,89,91,111,91,69,16,254,43,150,65,226,37,107,237,253,146,55,40,69,68,106,161,106,129,151,166,15,179,179,179,173,193,177,43,251,4,20,162,252,119,190,227,36,244,2,184,9,40,77,145,236,135,88,103,189,151,57,51,243,205,247,205,230,124,250,249,112,246,90,166,135,211,31,100,189,166,205,170,15,179,7,171,181,204,158,172,87,44,155,205,236,209,138,105,49,255,157,234,66,158,208,154,78,100,144,245,79,180,56,149,205,163,249,102,56,152,188,187,108,122,48,253,252,215,237,175,211,195,231,231,211,163,65,78,126,60,106,216,189,229,210,51,7,173,116,45,65,121,145,162,136,169,169,210,106,208,222,248,90,178,198,98,94,45,78,79,150,143,101,160,39,52,188,154,30,158,79,183,187,97,3,223,184,107,114,70,165,222,146,242,173,146,34,173,189,18,111,92,53,41,56,239,204,244,226,96,186,225,87,114,66,219,67,223,44,102,239,75,203,206,42,242,204,202,87,109,84,45,45,168,76,198,178,183,4,219,202,184,248,106,254,155,133,207,63,123,126,180,249,254,183,165,172,159,109,247,61,236,180,216,200,139,25,70,223,27,248,211,57,135,231,169,107,174,22,166,186,214,8,167,89,156,27,133,148,164,98,139,105,73,36,243,197,139,207,94,140,39,182,249,230,245,130,206,126,250,235,193,207,78,235,207,194,195,229,180,215,239,184,254,237,137,231,199,151,17,60,158,30,30,255,83,12,175,190,47,45,126,55,138,239,7,240,120,122,112,60,125,182,58,93,243,184,163,195,195,215,111,89,184,61,100,59,229,189,199,235,136,97,100,121,186,88,92,141,124,77,3,93,79,188,30,94,181,121,159,75,59,90,62,187,14,212,118,23,125,245,81,127,243,231,250,115,105,219,127,89,246,152,150,244,82,214,223,193,1,111,108,255,211,202,31,224,198,235,141,3,147,11,221,104,69,6,201,226,57,38,69,37,146,114,217,53,138,212,137,59,111,87,63,149,46,107,89,178,252,75,195,158,202,102,235,237,17,42,87,118,141,174,186,152,94,92,28,188,13,32,79,148,117,20,171,156,103,171,188,67,234,23,164,181,18,228,84,241,214,177,143,105,39,128,130,47,134,157,235,227,10,0,136,41,43,10,169,168,230,179,209,66,193,115,136,119,1,160,71,171,213,47,167,175,103,41,84,223,92,169,42,132,54,238,208,162,202,13,254,117,221,23,10,185,149,200,105,38,54,59,211,132,21,188,171,85,235,6,199,104,221,225,53,211,162,150,226,50,199,15,225,230,234,188,47,121,152,255,58,31,206,38,35,56,102,15,79,104,190,216,67,233,94,160,84,109,9,58,153,174,146,80,65,233,143,118,140,60,169,98,74,237,46,57,219,187,221,5,165,155,100,206,173,160,100,65,56,54,137,6,8,12,12,2,171,168,18,125,86,154,90,175,137,107,236,173,237,132,82,52,89,82,208,78,101,80,143,242,193,54,69,228,240,216,83,68,141,207,193,213,112,159,92,244,112,33,39,178,28,14,207,115,114,236,70,154,13,198,11,222,212,91,85,82,130,39,117,213,161,120,173,171,177,23,239,146,151,53,210,123,9,93,213,132,24,249,128,194,151,35,130,23,131,207,145,59,213,158,251,135,201,235,91,90,182,133,76,224,114,76,24,100,210,87,235,137,140,24,156,252,54,31,94,77,78,136,215,171,205,236,171,85,59,219,131,242,94,64,201,186,107,31,71,34,136,22,64,168,40,183,217,75,80,197,155,210,56,7,19,171,249,168,252,86,27,248,86,123,240,145,171,117,172,18,192,148,105,86,137,225,14,172,229,22,122,223,205,111,182,154,40,45,171,8,162,6,180,53,196,101,206,120,193,74,153,43,84,167,147,242,137,8,196,81,66,104,3,111,161,220,192,249,222,67,102,100,75,74,67,25,102,102,246,213,184,27,8,68,89,54,89,127,177,185,4,214,30,71,247,130,163,214,170,35,35,162,116,146,140,182,4,228,86,19,104,174,105,1,75,140,226,165,182,143,138,35,83,173,137,25,226,14,189,7,200,45,36,3,110,66,201,47,177,90,45,32,46,215,203,78,28,161,119,9,35,41,171,172,81,20,188,161,10,157,8,42,200,20,116,49,222,81,201,245,147,32,183,170,45,26,64,147,84,209,192,142,151,140,55,13,12,69,220,24,133,13,29,101,203,245,61,114,3,188,122,54,61,170,90,125,71,233,27,201,45,25,232,17,235,61,132,126,246,206,210,184,228,225,114,128,116,124,176,245,209,225,121,171,221,106,59,170,82,64,85,249,4,41,82,185,123,213,178,132,106,114,116,86,155,15,195,245,169,80,155,240,106,57,16,15,147,134,92,154,125,51,95,111,134,201,28,161,155,172,250,100,45,155,211,197,48,95,190,196,164,197,2,157,223,124,181,220,235,214,61,69,190,129,182,131,54,3,193,17,200,162,35,123,147,129,110,13,150,149,84,226,64,149,44,218,195,221,119,40,137,125,99,143,164,15,22,181,1,53,74,81,236,164,186,5,166,81,30,184,25,247,137,80,164,53,217,114,240,208,212,165,130,205,147,46,56,8,232,211,35,61,194,14,248,159,62,140,185,7,180,145,201,81,219,3,232,94,0,244,95,27,63,99,82,195,36,68,222,166,0,42,115,30,0,52,70,25,142,209,152,192,82,184,221,10,64,68,204,2,145,165,170,171,35,55,186,160,106,47,164,162,173,173,184,106,125,239,121,39,128,168,7,74,174,57,5,42,5,6,80,8,84,198,203,40,19,18,204,49,224,216,102,239,240,14,197,87,155,34,161,255,77,134,209,119,86,152,94,165,52,229,82,25,73,79,107,99,251,44,245,216,192,241,94,117,23,97,153,71,167,172,99,102,152,204,221,233,234,10,60,127,195,59,148,199,72,120,196,250,242,10,229,251,211,225,229,10,244,180,7,211,255,18,76,55,201,157,91,129,73,71,102,202,232,95,106,234,78,121,170,162,178,163,166,44,249,194,86,123,97,217,125,33,201,217,248,78,208,167,162,13,58,62,103,131,34,206,13,175,229,201,22,39,32,163,124,135,96,42,209,136,213,57,162,205,180,56,190,129,232,171,30,255,55,161,171,145,8,37,207,172,103,89,187,76,14,253,100,202,48,15,134,26,0,62,134,241,66,50,132,166,97,180,246,183,189,144,100,26,228,229,106,125,182,23,119,255,99,56,221,36,123,110,119,255,81,153,146,214,85,137,51,72,104,7,178,171,99,166,81,141,25,213,92,34,165,221,220,148,117,7,98,96,66,18,139,78,52,7,136,187,16,35,200,179,83,137,227,45,136,190,131,190,109,88,227,107,71,250,95,255,190,79,240,143,156,224,69,215,24,106,207,74,247,142,136,66,7,160,213,77,69,89,143,180,77,137,122,209,233,174,187,151,23,23,127,0,187,250,69,63,95,30,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "010a69df55e1475c937c0184594f2e41",
							"BaseElements.AddActivityDataUserTask.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57");
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

		#region Class: ReadDataUserTask3FlowElement

		/// <exclude/>
		public class ReadDataUserTask3FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask3FlowElement(UserConnection userConnection, SendEmailToCaseContactProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask3";
				IsLogging = false;
				SchemaElementUId = new Guid("68684123-fbf5-4c0a-a480-775f630307b9");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,193,142,155,48,20,252,23,206,235,21,193,6,146,189,85,217,180,183,54,82,162,158,114,121,152,103,98,173,137,145,109,86,77,87,249,247,218,144,164,137,196,106,217,74,81,91,237,13,70,227,97,222,120,120,47,17,87,96,237,87,168,49,122,136,214,104,12,88,45,220,253,103,169,28,154,47,70,183,77,116,23,89,52,18,148,252,137,101,143,47,74,233,30,193,129,63,242,178,249,173,176,137,30,54,195,26,155,232,110,19,73,135,181,245,28,127,100,74,69,82,64,62,33,40,18,70,88,76,11,2,5,23,4,153,160,60,77,121,9,105,218,51,95,19,159,235,186,1,131,253,55,58,121,209,61,174,247,77,160,78,60,192,59,138,180,122,119,4,105,48,97,23,59,40,20,150,254,221,153,22,61,228,140,172,253,52,184,150,53,46,193,248,111,5,29,29,32,79,18,160,108,96,41,20,110,241,163,49,104,173,212,187,183,204,169,182,222,93,178,189,0,158,95,143,118,226,206,99,96,46,193,109,59,137,94,235,208,249,252,84,85,6,43,112,242,249,210,198,19,238,59,230,184,4,253,129,210,223,211,119,80,45,94,36,115,61,203,28,26,215,143,116,50,224,41,70,86,219,209,243,158,83,123,107,228,196,131,205,137,60,82,115,112,138,100,234,193,231,0,116,199,230,96,67,110,135,144,28,229,37,159,98,156,19,198,121,74,24,99,156,20,60,79,9,82,90,210,25,38,49,205,39,31,177,91,171,189,93,2,127,130,10,239,199,215,108,92,152,239,174,217,181,145,255,183,110,33,66,165,43,201,65,125,107,208,192,113,192,120,184,12,87,45,202,194,212,90,187,21,223,98,13,103,71,254,150,122,164,243,113,186,134,28,178,56,79,104,70,138,28,5,97,41,103,4,104,158,17,49,73,138,12,217,76,204,178,196,27,242,171,58,56,95,233,214,240,99,125,109,191,163,255,104,247,254,133,214,191,111,73,14,182,102,76,11,110,178,78,254,209,184,6,255,251,155,39,119,211,63,227,16,29,126,1,249,234,133,188,185,8,0,0 })));
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

			private bool _readSomeTopRecords = false;
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

		#region Class: ReadDataUserTask4FlowElement

		/// <exclude/>
		public class ReadDataUserTask4FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask4FlowElement(UserConnection userConnection, SendEmailToCaseContactProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask4";
				IsLogging = false;
				SchemaElementUId = new Guid("75bcf7ea-afb0-4282-b27a-d876581ca682");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,77,79,227,48,16,253,43,200,103,130,154,143,126,222,16,20,196,5,144,168,184,16,14,83,103,146,90,56,113,100,59,236,150,42,255,157,113,92,66,65,69,116,145,86,187,57,57,79,207,111,222,60,207,108,24,151,96,204,53,148,200,102,108,129,90,131,81,185,61,185,16,210,162,190,212,170,169,217,49,51,168,5,72,241,130,153,199,231,153,176,231,96,129,174,108,210,119,133,148,205,210,253,26,41,59,78,153,176,88,26,226,208,149,201,40,25,142,151,241,40,192,44,138,130,36,204,135,193,116,28,77,130,152,135,131,48,130,101,60,156,68,158,249,149,248,153,42,107,208,232,107,116,242,121,119,92,172,107,71,13,9,224,29,69,24,85,109,193,216,153,48,243,10,150,18,51,250,183,186,65,130,172,22,37,117,131,11,81,226,45,104,170,229,116,148,131,136,148,131,52,142,37,49,183,243,223,181,70,99,132,170,190,51,39,155,178,218,101,147,0,246,191,91,59,131,206,163,99,222,130,93,117,18,87,100,171,237,92,158,22,133,198,2,172,120,222,53,241,132,235,142,119,88,126,116,33,163,87,186,7,217,224,78,205,143,157,156,65,109,125,67,190,60,17,180,40,86,7,247,218,39,246,93,187,17,129,245,27,249,64,205,189,61,68,35,2,159,29,224,85,222,142,41,123,184,50,55,191,42,212,119,124,133,37,248,212,30,79,8,253,4,244,250,179,205,18,135,225,32,225,73,48,134,140,7,9,143,195,0,18,24,7,211,105,50,138,121,18,135,148,114,251,232,125,8,83,75,88,223,247,229,72,6,43,123,4,156,94,73,88,122,153,214,125,46,97,85,8,14,242,166,70,13,219,112,7,251,103,239,195,208,186,190,180,82,214,187,237,115,57,237,245,119,38,128,138,209,98,186,104,238,84,163,249,118,17,140,223,200,31,109,218,63,216,159,63,89,137,189,67,121,200,144,253,23,227,243,183,39,163,101,237,43,18,83,210,84,203,5,0,0 })));
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

		public SendEmailToCaseContactProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendEmailToCaseContactProcess";
			SchemaUId = new Guid("010a69df-55e1-475c-937c-0184594f2e41");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_subject = () => { return new LocalizableString((FillEmailUserTask.Subject)); };
			_parentActivityId = () => { return (Guid)(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("ParentActivity").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ParentActivityId") : Guid.Empty))); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("010a69df-55e1-475c-937c-0184594f2e41");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SendEmailToCaseContactProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SendEmailToCaseContactProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid CaseId {
			get;
			set;
		}

		public virtual Guid TemplateId {
			get;
			set;
		}

		public virtual string SenderEmail {
			get;
			set;
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

		private Func<Guid> _parentActivityId;
		public virtual Guid ParentActivityId {
			get {
				return (_parentActivityId ?? (_parentActivityId = () => Guid.Empty)).Invoke();
			}
			set {
				_parentActivityId = () => { return value; };
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
					SchemaElementUId = new Guid("7f074929-411d-41a1-9f14-36b4e42641af"),
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
					SchemaElementUId = new Guid("24ec1bfd-0193-4b66-b797-b1118b9a6f2a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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

		private AddActivityDataUserTaskFlowElement _addActivityDataUserTask;
		public AddActivityDataUserTaskFlowElement AddActivityDataUserTask {
			get {
				return _addActivityDataUserTask ?? (_addActivityDataUserTask = new AddActivityDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask3FlowElement _readDataUserTask3;
		public ReadDataUserTask3FlowElement ReadDataUserTask3 {
			get {
				return _readDataUserTask3 ?? (_readDataUserTask3 = new ReadDataUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _sendMailScriptTask;
		public ProcessScriptTask SendMailScriptTask {
			get {
				return _sendMailScriptTask ?? (_sendMailScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendMailScriptTask",
					SchemaElementUId = new Guid("b2f6e645-ba3c-41d5-8709-1dc94bbb5be1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SendMailScriptTaskExecute,
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
					SchemaElementUId = new Guid("1db9fc77-db99-4250-918d-046db047f9a5"),
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
					SchemaElementUId = new Guid("320c19cd-a242-47b6-9d55-21bac6ccbe86"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask1Execute,
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
					SchemaElementUId = new Guid("a2e8ef78-e0cb-4b03-80ee-1ef683b0ed83"),
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
					SchemaElementUId = new Guid("f07aee8e-1621-486d-92b1-1591317f60c2"),
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
					SchemaElementUId = new Guid("5880c05f-f6d8-4064-bb1f-0c7b60536fb5"),
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
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[FillEmailUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FillEmailUserTask };
			FlowElements[AddActivityDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddActivityDataUserTask };
			FlowElements[ReadDataUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask3 };
			FlowElements[SendMailScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SendMailScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask4 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ReadDataUserTask1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask3", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "FillEmailUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "AddActivityDataUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SendMailScriptTask", e.Context.SenderName));
						break;
					case "ReadDataUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FillEmailUserTask", e.Context.SenderName));
						break;
					case "SendMailScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask4", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddActivityDataUserTask", e.Context.SenderName));
						break;
					case "ReadDataUserTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddActivityDataUserTask", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask1", "ConditionalFlow1", "((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName(\"Contact\").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>(\"ContactId\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>("Email") : null)) != string.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask2", "ConditionalFlow2", "((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName(\"Email\").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>(\"Email\") : null)) != string.Empty", result);
			return result;
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Origin").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OriginId") : Guid.Empty))==new Guid("7f9e1f1e-f46b-1410-3492-0050ba5d6c38"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow1", "((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName(\"Origin\").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>(\"OriginId\") : Guid.Empty))==new Guid(\"7f9e1f1e-f46b-1410-3492-0050ba5d6c38\")", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CaseId")) {
				writer.WriteValue("CaseId", CaseId, Guid.Empty);
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
			if (!HasMapping("ParentActivityId")) {
				writer.WriteValue("ParentActivityId", ParentActivityId, Guid.Empty);
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
			MetaPathParameterValues.Add("2182c543-89b6-4709-8a44-0ccc49d8c85a", () => CaseId);
			MetaPathParameterValues.Add("d30737ec-df8a-4aeb-805c-7bc8649175e6", () => TemplateId);
			MetaPathParameterValues.Add("3da60100-fb70-4440-a82a-0ee88ccc4b13", () => SenderEmail);
			MetaPathParameterValues.Add("7f0cb231-3dda-4b22-a6ea-e79291d7ee8c", () => Subject);
			MetaPathParameterValues.Add("be5104c4-7adc-4c31-a4a7-99463c431b36", () => ParentActivityId);
			MetaPathParameterValues.Add("2240c0c2-4f40-423c-8b95-f111c72bbfd9", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("b46a95f8-c76e-49f0-a82f-3277d460a1f6", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("db33b5a6-46aa-47ff-8e4b-5e13fdb80187", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("77acc736-6e4a-4799-8893-f31e6c67dd35", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("576434f3-e5c5-4731-be98-011701f8c85c", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("8aa5b82c-3a24-4b4e-b291-b0353a2dc144", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("0b953ab2-858c-4dd9-9bce-9d641ba01668", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("de51c882-736f-4db7-9a1b-bb605ec75208", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("1a5ebf76-4ad7-4eb7-81fd-71180b9cf610", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("c4106eb8-5ed0-42c8-b84f-34b0294210ca", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("51459f74-5d40-4e53-8ac7-ffca49ce3463", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("76c7a624-b7e2-4ab7-b03b-403b54d5cf2c", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("f5df9dd5-1461-4018-96ef-5e5408602213", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("4e739645-cfcf-4acb-b2c4-d98d6c2154ce", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("8453c16f-b75c-4362-9c4c-34a7a9599cbc", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("dd247f81-c60d-43ef-a529-7e9e698f5f8a", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("d72a4519-9e07-4c3a-ae50-fb5c05a32b5e", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("82c1a44f-a739-4a40-80cb-718991eb3256", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("d8352102-f94b-4317-a726-65436dae68e9", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("0ec419a6-4bb4-40da-806a-7aff639e25bd", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("b0de42aa-d0a6-43c9-84cd-9298f4cb6c71", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("12b7121c-ee28-40f6-89c1-935e8b7d7ca7", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("df939b4e-dde0-4d27-824d-3ce613d1a8df", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("70545f3a-7add-45c7-ba78-4585c9bf7ee7", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("ba3c18dd-7276-4d59-a388-7dd72332309c", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("7569fb84-ca21-4722-9617-c42bd11f787f", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("e88f81f6-bb4f-4667-8712-8244a108432a", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("13f6b58c-3dac-47b1-8c2a-67b10c00b042", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("f661c175-85bd-46e2-be1b-f8f2696bed90", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("c3e9fc0d-0126-49b4-b41c-42ce78706d8d", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("eb5bda7b-e48e-4c43-a503-e9218b4bf960", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("1a676d4f-b1c2-4fb2-ad01-f5ebd45a6e19", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("b6d720fe-0e34-42a7-8e39-608e8b72fb38", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("89bf6187-da0e-4a92-9f82-dffbe82cc14c", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("fc3b7c87-0f42-4827-bc59-66107a5f6680", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("0a9eeba5-9cd2-4b31-b5da-2bb820239f2a", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("02f9d1b3-8602-4fe1-84ab-08e9073bfef7", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("5e4c1a70-a584-4670-9b78-58387ea2f83f", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("f8d2ec88-506d-4044-908d-a191e3892bb2", () => FillEmailUserTask.Subject);
			MetaPathParameterValues.Add("21eff95f-b71a-4567-861f-65486cfabf8f", () => FillEmailUserTask.Body);
			MetaPathParameterValues.Add("47f64290-f732-4e87-9a44-4cf2485d1240", () => FillEmailUserTask.RecordId);
			MetaPathParameterValues.Add("4f0a1a14-83f4-4436-9927-3286a76c15e2", () => FillEmailUserTask.TemplateId);
			MetaPathParameterValues.Add("5f5844ae-4b77-4818-8542-1f6474d6e62c", () => FillEmailUserTask.SysEntitySchemaId);
			MetaPathParameterValues.Add("78fa348b-febc-4c15-9ab7-8db84e2baf7a", () => AddActivityDataUserTask.EntitySchemaId);
			MetaPathParameterValues.Add("a251d4b1-48d0-4b81-bd57-227f8c042748", () => AddActivityDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("5464c2e0-a7bf-468f-ba2c-a086e8b7cb5b", () => AddActivityDataUserTask.RecordAddMode);
			MetaPathParameterValues.Add("8d80b754-2b5d-4731-ada2-68af17a0c8be", () => AddActivityDataUserTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("eef95653-dcf6-49d4-b0e9-a9f6f4c8b03d", () => AddActivityDataUserTask.RecordDefValues);
			MetaPathParameterValues.Add("d07a51ae-6eef-4fae-8974-16c453d75d56", () => AddActivityDataUserTask.RecordId);
			MetaPathParameterValues.Add("d528a520-ffc6-45f3-a441-037cf090d3ad", () => AddActivityDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("3c44ff41-7d4f-4045-985d-f5591d95f153", () => ReadDataUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("8f65b044-884b-49ca-9219-5baf24f17958", () => ReadDataUserTask3.ResultType);
			MetaPathParameterValues.Add("5523d04c-3e1b-4f60-9563-9e520dac2c6c", () => ReadDataUserTask3.ReadSomeTopRecords);
			MetaPathParameterValues.Add("a8f08199-d9c0-4005-9c94-7c03f7670d2e", () => ReadDataUserTask3.NumberOfRecords);
			MetaPathParameterValues.Add("ebd74111-6e32-475d-ab86-716f0976612e", () => ReadDataUserTask3.FunctionType);
			MetaPathParameterValues.Add("573cfd72-52b9-4c1e-a621-58e6e1c6ce39", () => ReadDataUserTask3.AggregationColumnName);
			MetaPathParameterValues.Add("524f3776-d1c5-42c1-a379-e9b3d4ea79d5", () => ReadDataUserTask3.OrderInfo);
			MetaPathParameterValues.Add("8e42a1ac-c457-45b8-8e4d-7e6e530c82aa", () => ReadDataUserTask3.ResultEntity);
			MetaPathParameterValues.Add("0e982666-3fc9-4b3d-bf43-1c31a8e6cb53", () => ReadDataUserTask3.ResultCount);
			MetaPathParameterValues.Add("ac82296a-e4a2-4f63-8ecf-fc2befdcc54e", () => ReadDataUserTask3.ResultIntegerFunction);
			MetaPathParameterValues.Add("2ce6abdb-47e7-4462-a89a-faa0c73eff6e", () => ReadDataUserTask3.ResultFloatFunction);
			MetaPathParameterValues.Add("5e71482a-fa3d-496e-aab2-d15119381051", () => ReadDataUserTask3.ResultDateTimeFunction);
			MetaPathParameterValues.Add("5af71371-6345-46b7-91d8-531f111fc281", () => ReadDataUserTask3.ResultRowsCount);
			MetaPathParameterValues.Add("7ee2a87a-3e6d-4e07-bf35-2fba8030ddcd", () => ReadDataUserTask3.CanReadUncommitedData);
			MetaPathParameterValues.Add("e505355f-473f-4baf-a0c5-a7acfe566ab9", () => ReadDataUserTask3.ResultEntityCollection);
			MetaPathParameterValues.Add("65c22ff4-89c4-41cc-9507-4121365b392c", () => ReadDataUserTask3.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("898740ca-c0ac-43d9-bb83-01db84a4e988", () => ReadDataUserTask3.IgnoreDisplayValues);
			MetaPathParameterValues.Add("3bc5196e-ec53-438d-bad5-a9917f44ba81", () => ReadDataUserTask3.ResultCompositeObjectList);
			MetaPathParameterValues.Add("4cb4efcb-23d5-4943-87bc-d3837e241587", () => ReadDataUserTask3.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("01c24e99-0525-4c53-bd4b-2b34f9d3766f", () => ReadDataUserTask4.DataSourceFilters);
			MetaPathParameterValues.Add("c7d73d91-0514-42af-999d-7a34d7ec0e95", () => ReadDataUserTask4.ResultType);
			MetaPathParameterValues.Add("eeb351c9-365d-423c-800b-a2a013bab823", () => ReadDataUserTask4.ReadSomeTopRecords);
			MetaPathParameterValues.Add("71bd15f4-6282-4eae-a7e9-6faa031d959e", () => ReadDataUserTask4.NumberOfRecords);
			MetaPathParameterValues.Add("3f1dbb68-9a58-49b3-a323-5ac45052dfef", () => ReadDataUserTask4.FunctionType);
			MetaPathParameterValues.Add("2056ce2f-42d8-4fd2-bf24-61ea6742c3dd", () => ReadDataUserTask4.AggregationColumnName);
			MetaPathParameterValues.Add("7f067451-f8bd-4ba8-942d-d6a482207da2", () => ReadDataUserTask4.OrderInfo);
			MetaPathParameterValues.Add("95cb3a8c-de47-4ebf-ab83-44e2e6e9b06e", () => ReadDataUserTask4.ResultEntity);
			MetaPathParameterValues.Add("a0062d8b-80ae-4931-8d0d-9e40b6beed2a", () => ReadDataUserTask4.ResultCount);
			MetaPathParameterValues.Add("e646785e-110f-4438-bc03-5a65ff0404d2", () => ReadDataUserTask4.ResultIntegerFunction);
			MetaPathParameterValues.Add("45fdb25d-4878-4115-a5db-f8c6a0d63fdb", () => ReadDataUserTask4.ResultFloatFunction);
			MetaPathParameterValues.Add("6c591f23-80f8-405f-bcf7-acb6c98329e5", () => ReadDataUserTask4.ResultDateTimeFunction);
			MetaPathParameterValues.Add("5764dd4b-f9ff-4af0-ad7a-a37ba669478c", () => ReadDataUserTask4.ResultRowsCount);
			MetaPathParameterValues.Add("177a98fd-0f17-4427-86c0-92b3fd286f79", () => ReadDataUserTask4.CanReadUncommitedData);
			MetaPathParameterValues.Add("8071ca0f-90db-43d4-8161-5e54d91f00ea", () => ReadDataUserTask4.ResultEntityCollection);
			MetaPathParameterValues.Add("f92969bc-781b-4b37-b423-62af4cbe765b", () => ReadDataUserTask4.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("3bcea3e3-3e90-4842-98a1-348ce8d75cc4", () => ReadDataUserTask4.IgnoreDisplayValues);
			MetaPathParameterValues.Add("aada065d-4bf3-47e6-a1d2-45f360ece43f", () => ReadDataUserTask4.ResultCompositeObjectList);
			MetaPathParameterValues.Add("2a1bd4d1-2389-4180-8a78-b66acff9df8b", () => ReadDataUserTask4.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CaseId":
					if (!hasValueToRead) break;
					CaseId = reader.GetValue<System.Guid>();
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
				case "ParentActivityId":
					if (!hasValueToRead) break;
					ParentActivityId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool SendMailScriptTaskExecute(ProcessExecutingContext context) {
			var activityId = AddActivityDataUserTask.RecordId;
			var emailClientFactory = ClassFactory.Get<EmailClientFactory>(new ConstructorArgument("userConnection", UserConnection));
			var activityEmailSender = new ActivityEmailSender(emailClientFactory, UserConnection);
			activityEmailSender.Send(activityId);
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localSubject = (((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null))).IndexOf("RE: ", StringComparison.OrdinalIgnoreCase) == 0 ? ((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null)) : "RE: " + ((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null));
			Subject = (System.String)localSubject;
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
			var cloneItem = (SendEmailToCaseContactProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


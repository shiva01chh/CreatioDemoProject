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

	#region Class: SendEmailToCaseGroupSchema

	/// <exclude/>
	public class SendEmailToCaseGroupSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SendEmailToCaseGroupSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SendEmailToCaseGroupSchema(SendEmailToCaseGroupSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendEmailToCaseGroup";
			UId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
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
			RealUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateIsNeedSendEmailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("56772c15-0da6-416b-89f3-18ff8e888563"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"IsNeedSendEmail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"false",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateRecipientEmailsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7ea8c009-6542-4fdd-9572-6a844d21ab92"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"RecipientEmails",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTemplateIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("94d0d4a6-3942-434c-add8-db0c09b339ba"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"TemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.93030575-f70f-4041-902e-c4badaf62c63.0dc0759c-80b3-48b3-a832-7e32925d748b#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ce79eab9-3a98-423f-b3e9-66323aac7d60"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"CaseRecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("50441308-78db-4135-97ae-5d3c91b5f48f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"Subject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailSenderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fb6b20e1-ef67-4e02-ae21-d8d6528daffe"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"EmailSender",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsNeedSendEmailParameter());
			Parameters.Add(CreateRecipientEmailsParameter());
			Parameters.Add(CreateTemplateIdParameter());
			Parameters.Add(CreateCaseRecordIdParameter());
			Parameters.Add(CreateSubjectParameter());
			Parameters.Add(CreateEmailSenderParameter());
		}

		protected virtual void InitializeReadCaseDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4bff0fd5-1b5b-42da-97ec-43b95e6ba9cb"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,203,110,219,48,16,252,149,64,231,48,208,203,148,228,91,225,186,69,46,77,128,24,185,84,57,172,200,149,77,84,50,5,146,78,235,26,254,247,46,37,91,113,10,23,113,123,105,116,145,56,26,206,206,190,118,129,104,192,218,47,208,98,48,13,22,104,12,88,93,187,155,79,170,113,104,62,27,189,233,130,235,192,162,81,208,168,159,40,7,124,46,149,251,8,14,232,202,174,124,81,40,131,105,121,94,163,12,174,203,64,57,108,45,113,232,74,18,22,89,196,121,198,98,62,153,176,52,148,33,171,210,48,99,41,96,13,60,41,138,56,205,7,230,159,196,103,186,237,192,224,16,163,151,175,251,207,197,182,243,212,136,0,209,83,148,213,235,3,152,120,19,118,190,134,170,65,73,103,103,54,72,144,51,170,165,108,112,161,90,188,7,67,177,188,142,246,16,145,106,104,172,103,53,88,187,249,143,206,160,181,74,175,223,50,215,108,218,245,41,155,4,112,60,30,236,132,189,71,207,188,7,183,234,37,110,201,214,190,119,249,97,185,52,184,4,167,158,79,77,124,195,109,207,187,172,126,116,65,82,151,30,161,217,224,73,204,215,153,204,160,115,67,66,67,120,34,24,181,92,93,156,235,88,177,183,210,141,9,236,142,228,11,53,207,230,16,115,2,159,61,48,168,28,63,203,224,235,173,189,251,190,70,243,32,86,216,194,80,181,167,27,66,127,3,70,253,233,78,96,86,32,84,5,75,160,200,89,26,39,53,171,18,44,24,231,73,156,0,136,76,242,112,255,52,248,80,182,107,96,251,56,134,155,129,197,43,131,66,27,121,117,40,157,127,209,159,72,230,34,226,177,100,144,228,53,75,171,60,103,32,64,48,140,38,17,10,145,79,50,30,82,167,253,227,27,162,151,74,64,115,215,161,129,67,47,162,243,163,250,106,198,125,25,140,214,110,72,110,44,163,119,213,123,57,14,75,30,11,164,137,136,152,204,39,64,41,2,103,85,33,19,198,11,94,11,41,163,40,242,33,246,180,231,190,210,15,122,99,196,97,175,236,176,224,255,180,184,255,97,29,255,102,195,206,206,248,37,51,251,94,166,241,221,76,218,62,216,255,2,86,247,126,159,70,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a33f837c-29dc-4fee-a6ce-9b43656fdcf8"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("abb94808-5aed-4a2b-91a0-b3c4e019244f"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5c31db74-03b4-4e13-b937-a5bd1c4b9346"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("43f58502-a3f9-4d89-8b05-bfd006634914"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9bbb4181-ec2f-4b6d-9c67-a8acb3d3bb29"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("71f14a14-3659-44b0-8b17-52639bb50b8b"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("b3e79b7f-0cf2-4db9-a3b5-50f22bd30da9"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b94c3537-238d-4c55-bf91-3524d23fa348"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("11c9e107-95c8-4c1c-9999-e948c31b229b"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("ec11c857-840d-4bf0-81d9-e4b22444f6a4"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("a7dfeac1-20f7-4098-9ddf-8b4e9e037ab5"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("3b5fc9e6-f635-4946-96d0-99a07663b06a"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("1b1d7240-335a-4137-9822-956528e4d5c8"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("79abe934-9fa1-465e-b36c-e6a83fcae767"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a7890ce-b0ce-4cb6-9467-4d2a3d591114"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("957348b6-6c6f-4f23-9005-92046516fcbf"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("80dc665c-d274-472d-b93c-096ce2079593"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("a4fdcd96-edab-4671-bd7e-1885420719da"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("5601149a-7688-4bb0-829b-346b4f6428e9"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,203,110,211,64,20,253,23,175,59,145,29,199,175,238,80,8,236,32,82,34,86,222,92,143,175,157,81,237,216,154,153,84,132,42,18,127,64,187,69,240,15,8,169,42,66,176,105,196,138,191,224,75,184,99,155,144,74,65,53,149,42,64,44,70,26,31,157,185,115,238,153,227,123,102,241,2,148,122,2,37,90,199,214,28,165,4,85,101,122,240,72,20,26,229,99,89,173,106,235,200,82,40,5,20,226,5,166,45,62,73,133,126,8,26,232,200,89,252,179,66,108,29,199,135,107,196,214,81,108,9,141,165,34,14,29,9,67,76,178,192,119,153,151,121,9,27,121,105,198,18,176,67,230,185,137,159,98,148,132,201,48,106,153,191,42,62,174,202,26,36,182,119,52,229,179,102,59,95,215,134,234,16,192,27,138,80,213,178,3,93,35,66,77,150,144,20,152,210,183,150,43,36,72,75,81,82,55,56,23,37,78,65,210,93,166,78,101,32,34,101,80,40,195,42,48,211,147,231,181,68,165,68,181,188,77,92,177,42,151,251,108,42,128,187,207,78,142,221,104,52,204,41,232,69,83,162,173,181,105,116,62,200,115,137,57,104,113,186,47,227,4,215,13,179,159,131,116,32,165,119,122,6,197,10,247,156,185,217,203,24,106,221,182,20,91,219,243,175,111,182,231,215,159,182,23,215,175,154,227,82,228,139,222,125,239,220,187,173,245,33,129,245,15,114,207,154,7,187,25,134,4,158,26,160,57,54,6,101,252,219,24,7,157,161,155,122,16,100,12,61,59,98,35,142,54,139,162,0,25,250,110,194,193,25,57,137,13,255,99,198,102,107,53,5,126,2,57,14,250,199,173,159,153,119,136,219,151,15,20,183,119,180,62,210,186,220,94,124,123,249,122,64,187,183,29,122,69,235,125,183,255,76,203,176,47,255,229,96,26,179,139,42,23,28,138,167,53,74,232,172,176,15,199,230,70,222,124,211,117,85,233,25,95,96,9,59,69,244,158,45,210,232,216,61,88,48,164,167,194,128,121,145,231,210,124,24,5,12,130,208,101,190,51,10,93,159,115,15,184,67,130,104,184,27,229,179,106,37,121,23,116,213,78,245,59,77,235,63,240,127,252,222,88,61,152,154,62,41,184,151,193,243,151,218,117,112,66,220,187,115,247,250,103,108,172,205,119,34,58,131,223,235,8,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("33bce745-fb67-43b6-b483-90cf9af1f475"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c1bec890-46fb-4d20-8d4a-05948010b323"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9b2c93dd-c44c-440a-9072-328f06f7b94c"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f13d3489-febd-495e-87cf-34c08df24766"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5109a2ba-50c9-44b0-8714-4102a725b645"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("82ffd8c0-e88a-4530-87aa-024e8633e4d5"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("6f04cfdc-2015-4135-b910-ee8e91e73e65"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("81e8c52d-6348-476a-919b-4c222b549563"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("f54c25eb-87ff-4e05-9ea4-fa641521ef7d"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("bf35315a-7b9b-4e81-9cca-4628bc3abbe5"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("19ab1ec6-b279-4170-9439-600c31df5a4a"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("bafbaee0-2586-4010-ba1c-e98dd9e853cc"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("6abdacf3-1dd7-4b36-b7bc-80b7b2a13122"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("31a337f9-edbe-45b5-995e-4c7b22eee133"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9f758c03-00f6-4843-b6eb-99c9178eaf1a"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bbc539f4-868f-49dd-9dd3-cef59500c068"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("29b08ce6-a116-4009-aec0-c220240793d0"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("c01248a2-cf2e-4f75-9efa-1ebd98ed13d4"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("eb64ce85-4fbd-4226-97de-985e5b9fef59"),
				ContainerUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
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
				UId = new Guid("35173a57-a2e2-479f-aa27-bd861b439f14"),
				ContainerUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
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
				UId = new Guid("80f75966-6900-4fcd-8f09-804f82c014af"),
				ContainerUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dc83797-2f02-421a-8c91-14b4b0109539}].[Parameter:{b3e79b7f-0cf2-4db9-a3b5-50f22bd30da9}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var templateIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("86a9ca15-a29b-468f-92c9-7070bbd6f371"),
				ContainerUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
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
				Value = @"[#Lookup.93030575-f70f-4041-902e-c4badaf62c63.0dc0759c-80b3-48b3-a832-7e32925d748b#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(templateIdParameter);
			var sysEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9fbf2e69-990b-41f6-8ec5-c33d551a4914"),
				ContainerUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{d8487221-4c12-4a8e-9887-24309eafbaea}].[Parameter:{6f04cfdc-2015-4135-b910-ee8e91e73e65}].[EntityColumn:{ed98cf3e-1642-4755-acb2-a61181429306}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(sysEntitySchemaIdParameter);
		}

		protected virtual void InitializeAddEmailDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("847cacd4-6fdf-4340-890f-2d494c4c5c98"),
				ContainerUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("31e0eb82-93a1-4879-91aa-b744930a4611"),
				ContainerUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("567a0c1b-7356-49ce-93db-d58cb11abf8f"),
				ContainerUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("6a9f6041-ec7b-424a-88e3-3c868e83e490"),
				ContainerUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("91d4d62a-3cec-433d-b549-0651c8113c05"),
				ContainerUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,153,203,110,91,71,18,134,95,133,96,178,84,17,125,191,104,55,147,56,24,1,246,196,176,147,108,44,47,170,187,171,109,102,40,82,56,60,74,160,17,244,238,249,15,37,197,151,204,208,210,12,100,217,128,184,32,197,195,190,84,87,215,215,127,85,235,98,254,237,120,126,42,243,195,249,79,50,12,188,221,244,113,241,221,102,144,197,243,97,83,101,187,93,60,221,84,94,45,255,205,101,37,207,121,224,19,25,101,248,133,87,103,178,125,186,220,142,7,179,15,187,205,15,230,223,254,182,251,117,126,248,234,98,126,52,202,201,207,71,13,163,55,195,58,69,22,50,69,59,114,213,41,74,182,106,210,53,251,168,66,149,18,18,58,215,205,234,236,100,253,76,70,126,206,227,219,249,225,197,124,55,26,6,112,173,118,197,86,83,236,45,146,107,133,137,149,114,36,78,219,162,163,183,206,234,249,229,193,124,91,223,202,9,239,38,125,215,185,58,151,91,178,134,216,213,74,174,40,77,37,55,79,137,181,169,206,112,238,41,79,157,175,219,191,235,248,234,155,87,71,219,31,127,95,203,240,114,55,238,97,231,213,86,94,47,240,244,163,7,127,58,231,240,194,43,7,163,84,162,152,90,33,252,233,41,79,75,247,205,214,172,139,239,46,245,203,215,223,188,158,102,108,203,237,233,138,207,127,249,235,196,47,207,202,175,82,199,171,102,167,31,184,254,253,134,23,199,87,59,120,60,63,60,254,111,123,120,253,121,101,241,135,187,248,241,6,30,207,15,142,231,47,55,103,67,157,70,180,248,242,253,123,22,238,38,217,53,249,232,235,205,142,225,201,250,108,181,186,126,242,61,143,124,211,240,230,241,166,45,251,82,218,209,250,229,205,70,237,70,81,215,47,250,15,111,55,175,43,219,254,159,110,207,120,205,111,100,248,39,28,240,206,246,63,173,252,9,110,188,25,216,87,182,190,107,69,172,17,44,174,134,72,156,3,147,77,182,113,224,206,181,215,93,239,23,210,101,144,117,149,255,209,176,23,178,221,121,123,66,229,218,174,201,85,151,243,203,203,131,247,1,202,85,98,246,217,147,241,45,144,203,165,80,41,54,32,142,17,192,53,152,146,172,221,11,80,208,73,162,87,22,220,21,172,200,155,70,204,22,95,123,12,49,155,228,109,241,15,9,208,147,149,156,200,122,60,188,192,52,78,88,10,53,238,152,43,234,64,169,37,38,193,249,209,77,10,57,54,123,249,33,113,214,235,104,217,99,143,140,24,116,201,29,107,51,145,74,75,65,23,103,115,215,238,211,196,253,131,215,109,37,51,184,28,13,70,153,245,205,48,131,133,203,213,236,247,229,248,118,118,194,117,216,108,23,127,223,180,243,71,40,31,4,202,170,186,114,1,251,138,55,133,40,172,16,17,39,56,93,157,206,173,38,175,67,209,159,21,202,152,149,32,86,27,213,73,138,156,115,32,194,114,37,163,84,65,152,106,223,211,126,85,243,46,235,106,109,39,201,211,178,42,39,66,24,103,106,46,105,37,236,93,245,225,62,160,124,186,217,252,235,236,116,17,125,113,205,230,66,222,183,105,132,54,161,134,67,207,118,151,217,167,150,67,141,11,49,201,234,38,149,112,228,41,106,93,99,26,165,58,188,166,91,80,146,109,170,225,83,104,93,207,247,183,58,46,127,91,142,231,179,9,142,197,147,137,173,71,148,30,4,165,98,178,87,81,119,138,194,153,156,4,51,237,60,83,214,185,116,27,173,233,221,236,67,233,54,145,115,39,148,76,142,154,123,210,20,122,19,144,208,5,88,39,71,213,71,159,196,72,237,125,191,190,113,247,28,109,179,128,15,177,138,12,44,83,194,98,72,99,128,42,58,135,210,204,61,162,228,138,137,129,225,134,168,145,214,186,146,153,138,228,70,54,102,105,53,0,22,211,23,177,135,102,123,118,212,109,128,101,14,14,83,33,77,231,69,237,86,21,155,225,249,91,162,244,12,1,143,189,190,34,233,199,179,241,205,102,185,126,243,8,211,87,9,211,109,98,231,110,186,148,178,120,156,204,40,150,12,12,210,56,173,75,211,145,186,228,152,188,99,229,149,236,133,169,38,237,58,71,77,162,52,74,24,107,60,113,77,13,203,114,108,178,149,166,109,186,71,152,114,208,98,84,10,200,190,13,166,111,83,42,167,144,251,58,85,180,4,215,66,173,106,145,148,77,108,51,188,150,96,30,12,213,0,62,248,73,151,112,40,41,24,173,220,93,117,169,34,239,123,179,25,206,31,181,233,43,198,233,54,209,115,39,156,124,102,22,133,68,51,120,143,218,43,129,207,9,4,202,45,179,248,28,5,229,197,254,52,207,20,29,164,37,10,40,34,33,110,170,81,78,9,9,95,225,84,75,201,222,74,254,66,46,47,122,9,5,10,10,242,59,106,94,39,10,243,138,209,212,82,11,222,36,212,100,93,62,93,74,237,240,153,109,101,221,100,120,164,232,65,40,106,173,88,214,34,164,162,36,80,0,138,74,4,79,77,73,208,105,202,224,75,251,172,197,82,213,69,39,70,33,207,12,128,156,74,25,68,203,164,76,25,185,157,43,186,69,222,127,5,24,171,107,213,69,74,126,82,53,44,132,56,116,38,104,92,42,8,218,10,85,250,34,110,48,96,101,130,118,71,50,29,248,56,131,179,43,213,172,145,240,149,105,98,156,69,54,127,116,131,81,172,196,92,34,170,170,218,205,116,189,153,137,109,241,228,85,55,166,52,171,26,239,186,60,89,143,208,169,239,118,62,58,188,152,78,37,231,43,83,117,211,249,214,37,162,215,148,56,112,137,38,38,209,65,199,79,195,250,2,21,44,148,111,43,179,134,64,154,45,126,88,14,219,113,182,196,198,205,54,125,54,200,246,108,53,34,185,156,97,103,86,2,165,220,172,23,71,237,145,234,175,82,27,181,142,13,141,80,27,153,136,136,241,214,81,114,122,186,135,15,65,107,20,74,185,182,59,81,173,156,113,158,187,166,14,53,36,23,93,135,180,169,74,181,250,80,173,142,94,231,253,84,171,90,252,100,55,161,151,66,174,202,133,216,79,196,176,87,89,59,203,128,251,11,209,70,248,60,85,165,50,242,0,7,72,123,131,140,251,104,160,234,201,33,205,128,233,217,220,6,183,186,60,93,226,160,184,186,92,220,62,146,244,32,36,125,113,151,137,62,152,146,29,64,112,9,124,187,224,19,113,43,129,36,43,168,71,140,72,34,247,103,153,73,117,40,32,132,32,138,129,226,39,15,125,244,33,0,245,142,180,115,202,53,213,61,144,52,14,248,216,19,240,55,191,63,6,248,103,14,240,172,74,240,165,39,82,125,250,63,138,118,168,143,99,204,100,28,138,163,24,185,103,21,239,59,192,95,95,254,1,131,101,45,171,97,30,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("296257aa-1125-48e6-a411-79017af52a29"),
				ContainerUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
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
				UId = new Guid("6f656226-9a82-4643-a447-c6a6c5906771"),
				ContainerUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
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

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4d3f858a-52c5-430f-800f-6955ea542711"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,65,110,219,48,16,252,74,192,115,100,40,146,64,71,190,5,142,91,228,210,4,136,145,75,149,195,74,90,201,68,41,81,32,233,180,174,225,191,119,73,218,170,83,184,136,91,32,104,117,162,6,195,217,217,229,236,150,85,18,140,249,4,29,178,25,91,162,214,96,84,99,39,31,132,180,168,63,106,181,30,216,37,51,168,5,72,241,29,235,128,47,106,97,111,193,2,93,217,22,63,21,10,54,43,78,107,20,236,178,96,194,98,103,136,67,87,174,51,228,188,193,105,84,198,249,85,148,101,117,29,65,210,240,168,68,222,100,60,143,161,78,121,96,254,78,124,174,186,1,52,134,26,94,190,241,199,229,102,112,212,43,2,42,79,17,70,245,123,48,117,38,204,162,135,82,98,77,255,86,175,145,32,171,69,71,221,224,82,116,248,0,154,106,57,29,229,32,34,53,32,141,99,73,108,236,226,219,160,209,24,161,250,183,204,201,117,215,31,179,73,0,199,223,189,157,216,123,116,204,7,176,43,47,49,7,131,147,59,242,182,243,86,111,218,86,99,11,86,188,28,59,249,130,27,79,62,111,136,116,161,166,167,122,2,185,198,163,194,175,219,153,195,96,67,87,193,131,191,166,69,187,58,187,229,113,112,111,117,157,16,56,28,200,103,106,158,236,34,225,4,190,56,32,168,28,142,5,251,124,103,238,191,246,168,31,171,21,118,16,230,246,60,33,244,23,96,212,159,109,43,156,230,8,101,30,165,144,95,71,89,146,54,81,153,98,30,113,158,38,41,64,53,173,121,188,123,14,62,132,25,36,108,158,198,114,110,96,23,26,43,165,235,11,255,118,238,115,35,86,173,168,64,222,15,168,97,63,221,248,116,2,95,69,215,181,165,149,178,193,236,56,150,155,138,98,32,236,198,123,56,68,128,138,209,122,186,201,60,170,181,174,246,235,96,194,94,254,213,190,253,131,45,250,227,197,56,25,204,115,130,246,95,68,232,189,227,177,99,187,31,161,80,80,219,214,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bfbc3d0d-9a1e-43da-adb7-89e445d1a625"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("18710cc5-5550-481e-a010-e0505fa8b2a9"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("66e99c9d-a861-41c9-9892-3b4320edcabf"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("55a48763-bffc-4c07-9950-003aefdc3654"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d00b0ee2-e935-4829-a4db-fe5abd649d41"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("39985f73-d9e1-4a6e-8cd4-a40b31d7e533"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("9c756e63-5afb-42ed-94f8-3ee3f4bf4d9d"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea2ee12d-af13-403c-883f-817b024d86a9"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("fd47a28a-0a99-4a41-8153-9064ca9dad24"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("ab1d5b68-f04f-4772-8051-b480bf6acbc0"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("d83f0b00-f100-417a-a588-eb7796e2396a"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("4295e0df-6d0d-459b-a4fe-8ae3f18b4356"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("67446c2d-1033-4a62-98c7-f79a1d2cff50"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("a65afada-0121-4d32-8046-c15726057d12"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("85c368fc-5947-409e-9f8d-423a3de5d035"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b7f41d79-3f1f-44f6-97ed-626171550655"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("aba25d6c-1595-4be2-8a98-78b42b829b67"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("1820e651-8fa2-4509-9090-034da1a1911e"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
			ProcessSchemaUserTask readcasedata = CreateReadCaseDataUserTask();
			FlowElements.Add(readcasedata);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaUserTask fillemailusertask = CreateFillEmailUserTaskUserTask();
			FlowElements.Add(fillemailusertask);
			ProcessSchemaScriptTask preparerecipientemails = CreatePrepareRecipientEmailsScriptTask();
			FlowElements.Add(preparerecipientemails);
			ProcessSchemaUserTask addemaildatausertask = CreateAddEmailDataUserTaskUserTask();
			FlowElements.Add(addemaildatausertask);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaScriptTask sendemailscripttask = CreateSendEmailScriptTaskScriptTask();
			FlowElements.Add(sendemailscripttask);
			ProcessSchemaStartEvent startevent1 = CreateStartEvent1StartEvent();
			FlowElements.Add(startevent1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("57a6edbc-8a5e-418d-bf67-29dcb9cdfef0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("cb98fa26-176c-4258-957d-5f366e784589"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("5b6bbda6-2544-4984-a493-33ea3d53997e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("60f2028e-d6aa-415b-bb5b-ef027be86bcf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("96c28b67-1288-4df0-96f5-2a55923ff807"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("60f2028e-d6aa-415b-bb5b-ef027be86bcf"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fce8a14e-9408-4274-8948-3165aeb15892"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("217c6685-36c5-4584-8a80-2f2f04b00727"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4a1291aa-8caf-4e54-8275-887b0bb550c4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("75bdf120-c093-47fd-b23e-d52f059ec58c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{56772c15-0da6-416b-89f3-18ff8e888563}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4a1291aa-8caf-4e54-8275-887b0bb550c4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b19e5a82-b497-469b-b25d-0c491fd8111a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(535, 332));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("8b7489eb-b116-4b26-a892-34fb88add808"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4a1291aa-8caf-4e54-8275-887b0bb550c4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fce8a14e-9408-4274-8948-3165aeb15892"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(535, 146));
			schemaFlow.PolylinePointPositions.Add(new Point(1093, 146));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("b5a3673d-f005-4df7-b7e5-edef707a8f96"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("58c9e19e-5a97-42fa-8666-4613269c9517"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("8f83be51-9c06-45ff-b8d8-dd8224eb633a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dc83797-2f02-421a-8c91-14b4b0109539}].[Parameter:{b3e79b7f-0cf2-4db9-a3b5-50f22bd30da9}].[EntityColumn:{a93cb111-ce30-4da4-89ec-d2a2f3dd71c4}]#] ==[#Lookup.b17869fe-43f9-487a-af82-b7626f1fc810.7f9e1f1e-f46b-1410-3492-0050ba5d6c38#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b19e5a82-b497-469b-b25d-0c491fd8111a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(627, 407));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("bf943044-0e65-4a76-9f79-6e7bcf838238"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eeede76c-0137-4ded-80aa-cc1cc3f876de"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("f74b17bb-0662-4a73-b5ab-e34bcda5b0bc"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b19e5a82-b497-469b-b25d-0c491fd8111a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(627, 203));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("86e8cd15-190e-497b-8609-884788958143"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eeede76c-0137-4ded-80aa-cc1cc3f876de"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b1d52543-8143-4b41-b705-fbf73d8e80ca"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b1d52543-8143-4b41-b705-fbf73d8e80ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaUserTask CreateReadCaseDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"ReadCaseData",
				Position = new Point(171, 176),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadCaseDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"ReadDataUserTask2",
				Position = new Point(281, 176),
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
				UId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"FillEmailUserTask",
				Position = new Point(391, 176),
				SchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeFillEmailUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareRecipientEmailsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4a1291aa-8caf-4e54-8275-887b0bb550c4"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"PrepareRecipientEmails",
				Position = new Point(501, 176),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,193,138,219,48,16,61,39,144,127,80,125,146,105,48,123,110,218,192,226,122,67,14,221,182,241,110,123,88,122,16,246,36,17,200,146,59,26,109,49,203,254,123,71,86,146,186,129,5,99,240,248,205,123,111,222,76,213,41,109,106,176,45,160,248,36,164,39,212,246,144,63,0,162,242,110,79,69,233,16,248,101,247,250,16,80,145,118,182,168,7,95,3,17,227,124,177,1,250,161,76,128,143,169,113,45,31,61,32,195,45,52,17,187,20,139,249,44,171,67,223,59,164,26,240,89,55,80,69,197,108,41,234,177,163,168,186,158,134,124,181,152,63,43,20,144,220,24,238,102,55,22,254,136,202,146,166,161,110,142,252,235,123,0,28,174,20,138,41,224,139,178,234,0,184,20,25,123,188,109,59,109,31,173,166,236,63,246,210,153,208,89,102,159,104,21,183,109,155,234,50,99,106,82,92,74,54,207,173,7,116,161,223,182,220,182,3,213,150,202,195,103,69,170,216,129,15,134,146,133,152,197,195,208,195,137,41,197,178,9,186,93,203,108,147,218,71,186,169,238,157,54,4,232,163,190,156,214,75,4,69,144,254,254,212,116,252,166,80,117,16,161,50,21,75,215,245,10,181,119,54,74,22,213,239,160,12,143,253,196,115,199,124,182,118,231,12,124,56,125,253,138,43,139,5,78,253,52,72,126,30,172,113,198,164,36,175,34,225,105,210,92,229,5,113,21,125,164,216,250,123,128,54,222,207,152,23,115,252,35,228,179,9,150,196,90,220,48,112,7,141,238,53,88,26,113,158,129,126,178,127,6,236,249,208,84,115,148,227,162,70,97,161,237,132,45,23,47,124,75,151,53,70,183,111,199,126,190,198,201,198,139,123,78,48,95,197,131,212,123,33,223,157,228,121,128,96,204,87,28,109,36,124,158,164,102,215,150,223,95,60,223,57,236,20,201,236,229,230,117,197,153,166,46,158,97,246,186,152,243,131,64,1,173,32,12,176,18,127,1,210,39,117,232,97,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddEmailDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"AddEmailDataUserTask",
				Position = new Point(831, 176),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddEmailDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("fce8a14e-9408-4274-8948-3165aeb15892"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"Terminate1",
				Position = new Point(1080, 190),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSendEmailScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("60f2028e-d6aa-415b-bb5b-ef027be86bcf"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"SendEmailScriptTask",
				Position = new Point(980, 176),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,82,193,106,195,48,12,61,55,208,127,16,57,37,16,242,3,89,7,37,77,70,174,91,251,1,90,173,22,51,199,46,182,147,17,198,254,125,178,105,89,150,236,100,91,122,210,123,79,242,136,22,240,236,229,40,253,212,9,216,193,94,136,166,71,169,14,232,241,228,200,30,209,125,148,175,116,54,86,116,162,218,38,242,2,89,136,215,70,107,226,66,163,203,23,242,157,107,9,253,96,169,209,248,174,72,100,41,99,246,110,210,231,216,236,141,180,32,155,230,57,124,109,147,205,50,14,52,187,239,64,211,39,44,33,11,202,156,133,108,102,85,101,56,98,77,246,107,38,128,190,129,148,163,200,58,226,157,168,86,146,180,111,25,104,236,196,124,181,66,231,238,207,224,229,169,89,161,158,179,32,138,249,157,183,67,136,236,237,117,232,57,159,165,195,31,97,105,1,11,165,81,234,56,155,114,179,54,187,206,100,107,165,171,206,161,241,145,172,69,103,46,190,228,196,69,94,7,139,113,37,181,233,123,163,79,94,42,233,37,57,126,223,166,86,42,58,144,231,190,139,105,22,112,164,254,166,208,83,39,138,217,111,40,32,141,146,30,89,54,151,62,180,242,157,71,65,121,5,172,226,31,107,113,35,203,101,108,19,75,252,73,116,44,173,126,0,69,198,69,68,123,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartEvent CreateStartEvent1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("58c9e19e-5a97-42fa-8666-4613269c9517"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"StartEvent1",
				Position = new Point(80, 190),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("b19e5a82-b497-469b-b25d-0c491fd8111a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"ExclusiveGateway1",
				Position = new Point(600, 305),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"ReadDataUserTask1",
				Position = new Point(680, 380),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("eeede76c-0137-4ded-80aa-cc1cc3f876de"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"FormulaTask1",
				Position = new Point(831, 380),
				ResultParameterMetaPath = @"50441308-78db-4135-97ae-5d3c91b5f48f",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,144,189,110,131,48,20,70,95,197,74,22,162,230,34,28,95,126,165,168,3,98,96,162,106,198,136,225,130,175,19,36,48,149,161,106,171,40,239,94,43,99,30,33,235,209,119,134,243,5,231,237,185,94,154,31,203,238,212,95,121,162,194,208,184,112,27,122,250,4,170,145,39,182,107,113,203,49,233,242,44,86,16,75,133,128,156,196,144,229,82,67,122,64,67,40,123,102,165,239,94,248,32,71,19,175,236,188,210,167,113,194,137,87,200,116,128,7,214,144,163,201,64,249,173,193,206,160,206,31,74,101,215,97,253,43,231,241,123,178,197,13,117,111,34,82,18,82,163,83,64,221,17,80,20,33,48,74,213,201,52,86,168,228,189,221,182,187,176,182,154,127,27,19,108,62,171,66,108,246,226,180,186,193,94,202,121,250,34,55,44,179,13,27,167,7,75,99,125,177,179,227,146,22,222,137,227,81,68,226,93,4,47,241,128,240,217,143,118,241,246,34,69,255,68,39,120,43,154,2,0,0 }
			};
			
			return FormulaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6eceebac-b0e5-4cc8-b022-84e50eb7f42e"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb35bbc2-5e4c-4518-a793-46d126c86da9"),
				Name = "Terrasoft.Mail.Sender",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bab858b4-c2ef-4534-94c5-1f8e9452cf9b"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4256f56b-80d4-4887-900e-0f587b83f100"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SendEmailToCaseGroup(userConnection);
		}

		public override object Clone() {
			return new SendEmailToCaseGroupSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"));
		}

		#endregion

	}

	#endregion

	#region Class: SendEmailToCaseGroup

	/// <exclude/>
	public class SendEmailToCaseGroup : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendEmailToCaseGroup process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadCaseDataFlowElement

		/// <exclude/>
		public class ReadCaseDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadCaseDataFlowElement(UserConnection userConnection, SendEmailToCaseGroup process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadCaseData";
				IsLogging = true;
				SchemaElementUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,203,110,219,48,16,252,149,64,231,48,208,203,148,228,91,225,186,69,46,77,128,24,185,84,57,172,200,149,77,84,50,5,146,78,235,26,254,247,46,37,91,113,10,23,113,123,105,116,145,56,26,206,206,190,118,129,104,192,218,47,208,98,48,13,22,104,12,88,93,187,155,79,170,113,104,62,27,189,233,130,235,192,162,81,208,168,159,40,7,124,46,149,251,8,14,232,202,174,124,81,40,131,105,121,94,163,12,174,203,64,57,108,45,113,232,74,18,22,89,196,121,198,98,62,153,176,52,148,33,171,210,48,99,41,96,13,60,41,138,56,205,7,230,159,196,103,186,237,192,224,16,163,151,175,251,207,197,182,243,212,136,0,209,83,148,213,235,3,152,120,19,118,190,134,170,65,73,103,103,54,72,144,51,170,165,108,112,161,90,188,7,67,177,188,142,246,16,145,106,104,172,103,53,88,187,249,143,206,160,181,74,175,223,50,215,108,218,245,41,155,4,112,60,30,236,132,189,71,207,188,7,183,234,37,110,201,214,190,119,249,97,185,52,184,4,167,158,79,77,124,195,109,207,187,172,126,116,65,82,151,30,161,217,224,73,204,215,153,204,160,115,67,66,67,120,34,24,181,92,93,156,235,88,177,183,210,141,9,236,142,228,11,53,207,230,16,115,2,159,61,48,168,28,63,203,224,235,173,189,251,190,70,243,32,86,216,194,80,181,167,27,66,127,3,70,253,233,78,96,86,32,84,5,75,160,200,89,26,39,53,171,18,44,24,231,73,156,0,136,76,242,112,255,52,248,80,182,107,96,251,56,134,155,129,197,43,131,66,27,121,117,40,157,127,209,159,72,230,34,226,177,100,144,228,53,75,171,60,103,32,64,48,140,38,17,10,145,79,50,30,82,167,253,227,27,162,151,74,64,115,215,161,129,67,47,162,243,163,250,106,198,125,25,140,214,110,72,110,44,163,119,213,123,57,14,75,30,11,164,137,136,152,204,39,64,41,2,103,85,33,19,198,11,94,11,41,163,40,242,33,246,180,231,190,210,15,122,99,196,97,175,236,176,224,255,180,184,255,97,29,255,102,195,206,206,248,37,51,251,94,166,241,221,76,218,62,216,255,2,86,247,126,159,70,6,0,0 })));
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

			public ReadDataUserTask2FlowElement(UserConnection userConnection, SendEmailToCaseGroup process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,203,110,211,64,20,253,23,175,59,145,29,199,175,238,80,8,236,32,82,34,86,222,92,143,175,157,81,237,216,154,153,84,132,42,18,127,64,187,69,240,15,8,169,42,66,176,105,196,138,191,224,75,184,99,155,144,74,65,53,149,42,64,44,70,26,31,157,185,115,238,153,227,123,102,241,2,148,122,2,37,90,199,214,28,165,4,85,101,122,240,72,20,26,229,99,89,173,106,235,200,82,40,5,20,226,5,166,45,62,73,133,126,8,26,232,200,89,252,179,66,108,29,199,135,107,196,214,81,108,9,141,165,34,14,29,9,67,76,178,192,119,153,151,121,9,27,121,105,198,18,176,67,230,185,137,159,98,148,132,201,48,106,153,191,42,62,174,202,26,36,182,119,52,229,179,102,59,95,215,134,234,16,192,27,138,80,213,178,3,93,35,66,77,150,144,20,152,210,183,150,43,36,72,75,81,82,55,56,23,37,78,65,210,93,166,78,101,32,34,101,80,40,195,42,48,211,147,231,181,68,165,68,181,188,77,92,177,42,151,251,108,42,128,187,207,78,142,221,104,52,204,41,232,69,83,162,173,181,105,116,62,200,115,137,57,104,113,186,47,227,4,215,13,179,159,131,116,32,165,119,122,6,197,10,247,156,185,217,203,24,106,221,182,20,91,219,243,175,111,182,231,215,159,182,23,215,175,154,227,82,228,139,222,125,239,220,187,173,245,33,129,245,15,114,207,154,7,187,25,134,4,158,26,160,57,54,6,101,252,219,24,7,157,161,155,122,16,100,12,61,59,98,35,142,54,139,162,0,25,250,110,194,193,25,57,137,13,255,99,198,102,107,53,5,126,2,57,14,250,199,173,159,153,119,136,219,151,15,20,183,119,180,62,210,186,220,94,124,123,249,122,64,187,183,29,122,69,235,125,183,255,76,203,176,47,255,229,96,26,179,139,42,23,28,138,167,53,74,232,172,176,15,199,230,70,222,124,211,117,85,233,25,95,96,9,59,69,244,158,45,210,232,216,61,88,48,164,167,194,128,121,145,231,210,124,24,5,12,130,208,101,190,51,10,93,159,115,15,184,67,130,104,184,27,229,179,106,37,121,23,116,213,78,245,59,77,235,63,240,127,252,222,88,61,152,154,62,41,184,151,193,243,151,218,117,112,66,220,187,115,247,250,103,108,172,205,119,34,58,131,223,235,8,0,0 })));
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

		#region Class: FillEmailUserTaskFlowElement

		/// <exclude/>
		public class FillEmailUserTaskFlowElement : FillEmailTemplateUserTask
		{

			#region Constructors: Public

			public FillEmailUserTaskFlowElement(UserConnection userConnection, SendEmailToCaseGroup process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "FillEmailUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordId = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_templateId = () => (Guid)(new Guid("0dc0759c-80b3-48b3-a832-7e32925d748b"));
				_sysEntitySchemaId = () => (Guid)(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("UId").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<Guid>("UId") : Guid.Empty)));
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

		#region Class: AddEmailDataUserTaskFlowElement

		/// <exclude/>
		public class AddEmailDataUserTaskFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddEmailDataUserTaskFlowElement(UserConnection userConnection, SendEmailToCaseGroup process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddEmailDataUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Title = () => new LocalizableString((process.Subject));
				_recordDefValues_Body = () => new LocalizableString((process.FillEmailUserTask.Body));
				_recordDefValues_Type = () => (Guid)(new Guid("e2831dec-cfc0-df11-b00f-001d60e938c6"));
				_recordDefValues_MessageType = () => (Guid)(new Guid("7f6d3f94-f36b-1410-068c-20cf30b39373"));
				_recordDefValues_ActivityCategory = () => (Guid)(new Guid("8038a396-7825-e011-8165-00155d043204"));
				_recordDefValues_Sender = () => new LocalizableString((process.EmailSender));
				_recordDefValues_Case = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_recordDefValues_Recepient = () => new LocalizableString((process.RecipientEmails));
				_recordDefValues_IsHtmlBody = () => (bool)(true);
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Title", () => _recordDefValues_Title.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Body", () => _recordDefValues_Body.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Type", () => _recordDefValues_Type.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_MessageType", () => _recordDefValues_MessageType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_ActivityCategory", () => _recordDefValues_ActivityCategory.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Sender", () => _recordDefValues_Sender.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Case", () => _recordDefValues_Case.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Recepient", () => _recordDefValues_Recepient.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsHtmlBody", () => _recordDefValues_IsHtmlBody.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Title;
			internal Func<string> _recordDefValues_Body;
			internal Func<Guid> _recordDefValues_Type;
			internal Func<Guid> _recordDefValues_MessageType;
			internal Func<Guid> _recordDefValues_ActivityCategory;
			internal Func<string> _recordDefValues_Sender;
			internal Func<Guid> _recordDefValues_Case;
			internal Func<string> _recordDefValues_Recepient;
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,153,203,110,91,71,18,134,95,133,96,178,84,17,125,191,104,55,147,56,24,1,246,196,176,147,108,44,47,170,187,171,109,102,40,82,56,60,74,160,17,244,238,249,15,37,197,151,204,208,210,12,100,217,128,184,32,197,195,190,84,87,215,215,127,85,235,98,254,237,120,126,42,243,195,249,79,50,12,188,221,244,113,241,221,102,144,197,243,97,83,101,187,93,60,221,84,94,45,255,205,101,37,207,121,224,19,25,101,248,133,87,103,178,125,186,220,142,7,179,15,187,205,15,230,223,254,182,251,117,126,248,234,98,126,52,202,201,207,71,13,163,55,195,58,69,22,50,69,59,114,213,41,74,182,106,210,53,251,168,66,149,18,18,58,215,205,234,236,100,253,76,70,126,206,227,219,249,225,197,124,55,26,6,112,173,118,197,86,83,236,45,146,107,133,137,149,114,36,78,219,162,163,183,206,234,249,229,193,124,91,223,202,9,239,38,125,215,185,58,151,91,178,134,216,213,74,174,40,77,37,55,79,137,181,169,206,112,238,41,79,157,175,219,191,235,248,234,155,87,71,219,31,127,95,203,240,114,55,238,97,231,213,86,94,47,240,244,163,7,127,58,231,240,194,43,7,163,84,162,152,90,33,252,233,41,79,75,247,205,214,172,139,239,46,245,203,215,223,188,158,102,108,203,237,233,138,207,127,249,235,196,47,207,202,175,82,199,171,102,167,31,184,254,253,134,23,199,87,59,120,60,63,60,254,111,123,120,253,121,101,241,135,187,248,241,6,30,207,15,142,231,47,55,103,67,157,70,180,248,242,253,123,22,238,38,217,53,249,232,235,205,142,225,201,250,108,181,186,126,242,61,143,124,211,240,230,241,166,45,251,82,218,209,250,229,205,70,237,70,81,215,47,250,15,111,55,175,43,219,254,159,110,207,120,205,111,100,248,39,28,240,206,246,63,173,252,9,110,188,25,216,87,182,190,107,69,172,17,44,174,134,72,156,3,147,77,182,113,224,206,181,215,93,239,23,210,101,144,117,149,255,209,176,23,178,221,121,123,66,229,218,174,201,85,151,243,203,203,131,247,1,202,85,98,246,217,147,241,45,144,203,165,80,41,54,32,142,17,192,53,152,146,172,221,11,80,208,73,162,87,22,220,21,172,200,155,70,204,22,95,123,12,49,155,228,109,241,15,9,208,147,149,156,200,122,60,188,192,52,78,88,10,53,238,152,43,234,64,169,37,38,193,249,209,77,10,57,54,123,249,33,113,214,235,104,217,99,143,140,24,116,201,29,107,51,145,74,75,65,23,103,115,215,238,211,196,253,131,215,109,37,51,184,28,13,70,153,245,205,48,131,133,203,213,236,247,229,248,118,118,194,117,216,108,23,127,223,180,243,71,40,31,4,202,170,186,114,1,251,138,55,133,40,172,16,17,39,56,93,157,206,173,38,175,67,209,159,21,202,152,149,32,86,27,213,73,138,156,115,32,194,114,37,163,84,65,152,106,223,211,126,85,243,46,235,106,109,39,201,211,178,42,39,66,24,103,106,46,105,37,236,93,245,225,62,160,124,186,217,252,235,236,116,17,125,113,205,230,66,222,183,105,132,54,161,134,67,207,118,151,217,167,150,67,141,11,49,201,234,38,149,112,228,41,106,93,99,26,165,58,188,166,91,80,146,109,170,225,83,104,93,207,247,183,58,46,127,91,142,231,179,9,142,197,147,137,173,71,148,30,4,165,98,178,87,81,119,138,194,153,156,4,51,237,60,83,214,185,116,27,173,233,221,236,67,233,54,145,115,39,148,76,142,154,123,210,20,122,19,144,208,5,88,39,71,213,71,159,196,72,237,125,191,190,113,247,28,109,179,128,15,177,138,12,44,83,194,98,72,99,128,42,58,135,210,204,61,162,228,138,137,129,225,134,168,145,214,186,146,153,138,228,70,54,102,105,53,0,22,211,23,177,135,102,123,118,212,109,128,101,14,14,83,33,77,231,69,237,86,21,155,225,249,91,162,244,12,1,143,189,190,34,233,199,179,241,205,102,185,126,243,8,211,87,9,211,109,98,231,110,186,148,178,120,156,204,40,150,12,12,210,56,173,75,211,145,186,228,152,188,99,229,149,236,133,169,38,237,58,71,77,162,52,74,24,107,60,113,77,13,203,114,108,178,149,166,109,186,71,152,114,208,98,84,10,200,190,13,166,111,83,42,167,144,251,58,85,180,4,215,66,173,106,145,148,77,108,51,188,150,96,30,12,213,0,62,248,73,151,112,40,41,24,173,220,93,117,169,34,239,123,179,25,206,31,181,233,43,198,233,54,209,115,39,156,124,102,22,133,68,51,120,143,218,43,129,207,9,4,202,45,179,248,28,5,229,197,254,52,207,20,29,164,37,10,40,34,33,110,170,81,78,9,9,95,225,84,75,201,222,74,254,66,46,47,122,9,5,10,10,242,59,106,94,39,10,243,138,209,212,82,11,222,36,212,100,93,62,93,74,237,240,153,109,101,221,100,120,164,232,65,40,106,173,88,214,34,164,162,36,80,0,138,74,4,79,77,73,208,105,202,224,75,251,172,197,82,213,69,39,70,33,207,12,128,156,74,25,68,203,164,76,25,185,157,43,186,69,222,127,5,24,171,107,213,69,74,126,82,53,44,132,56,116,38,104,92,42,8,218,10,85,250,34,110,48,96,101,130,118,71,50,29,248,56,131,179,43,213,172,145,240,149,105,98,156,69,54,127,116,131,81,172,196,92,34,170,170,218,205,116,189,153,137,109,241,228,85,55,166,52,171,26,239,186,60,89,143,208,169,239,118,62,58,188,152,78,37,231,43,83,117,211,249,214,37,162,215,148,56,112,137,38,38,209,65,199,79,195,250,2,21,44,148,111,43,179,134,64,154,45,126,88,14,219,113,182,196,198,205,54,125,54,200,246,108,53,34,185,156,97,103,86,2,165,220,172,23,71,237,145,234,175,82,27,181,142,13,141,80,27,153,136,136,241,214,81,114,122,186,135,15,65,107,20,74,185,182,59,81,173,156,113,158,187,166,14,53,36,23,93,135,180,169,74,181,250,80,173,142,94,231,253,84,171,90,252,100,55,161,151,66,174,202,133,216,79,196,176,87,89,59,203,128,251,11,209,70,248,60,85,165,50,242,0,7,72,123,131,140,251,104,160,234,201,33,205,128,233,217,220,6,183,186,60,93,226,160,184,186,92,220,62,146,244,32,36,125,113,151,137,62,152,146,29,64,112,9,124,187,224,19,113,43,129,36,43,168,71,140,72,34,247,103,153,73,117,40,32,132,32,138,129,226,39,15,125,244,33,0,245,142,180,115,202,53,213,61,144,52,14,248,216,19,240,55,191,63,6,248,103,14,240,172,74,240,165,39,82,125,250,63,138,118,168,143,99,204,100,28,138,163,24,185,103,21,239,59,192,95,95,254,1,131,101,45,171,97,30,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "c68f5a4ead064c8388c4040d2480facb",
							"BaseElements.AddEmailDataUserTask.Parameters.RecordDefValues.Value");
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

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, SendEmailToCaseGroup process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,65,110,219,48,16,252,74,192,115,100,40,146,64,71,190,5,142,91,228,210,4,136,145,75,149,195,74,90,201,68,41,81,32,233,180,174,225,191,119,73,218,170,83,184,136,91,32,104,117,162,6,195,217,217,229,236,150,85,18,140,249,4,29,178,25,91,162,214,96,84,99,39,31,132,180,168,63,106,181,30,216,37,51,168,5,72,241,29,235,128,47,106,97,111,193,2,93,217,22,63,21,10,54,43,78,107,20,236,178,96,194,98,103,136,67,87,174,51,228,188,193,105,84,198,249,85,148,101,117,29,65,210,240,168,68,222,100,60,143,161,78,121,96,254,78,124,174,186,1,52,134,26,94,190,241,199,229,102,112,212,43,2,42,79,17,70,245,123,48,117,38,204,162,135,82,98,77,255,86,175,145,32,171,69,71,221,224,82,116,248,0,154,106,57,29,229,32,34,53,32,141,99,73,108,236,226,219,160,209,24,161,250,183,204,201,117,215,31,179,73,0,199,223,189,157,216,123,116,204,7,176,43,47,49,7,131,147,59,242,182,243,86,111,218,86,99,11,86,188,28,59,249,130,27,79,62,111,136,116,161,166,167,122,2,185,198,163,194,175,219,153,195,96,67,87,193,131,191,166,69,187,58,187,229,113,112,111,117,157,16,56,28,200,103,106,158,236,34,225,4,190,56,32,168,28,142,5,251,124,103,238,191,246,168,31,171,21,118,16,230,246,60,33,244,23,96,212,159,109,43,156,230,8,101,30,165,144,95,71,89,146,54,81,153,98,30,113,158,38,41,64,53,173,121,188,123,14,62,132,25,36,108,158,198,114,110,96,23,26,43,165,235,11,255,118,238,115,35,86,173,168,64,222,15,168,97,63,221,248,116,2,95,69,215,181,165,149,178,193,236,56,150,155,138,98,32,236,198,123,56,68,128,138,209,122,186,201,60,170,181,174,246,235,96,194,94,254,213,190,253,131,45,250,227,197,56,25,204,115,130,246,95,68,232,189,227,177,99,187,31,161,80,80,219,214,5,0,0 })));
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

		public SendEmailToCaseGroup(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendEmailToCaseGroup";
			SchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_isNeedSendEmail = () => { return (bool)(false); };
			_templateId = () => { return (Guid)(new Guid("0dc0759c-80b3-48b3-a832-7e32925d748b")); };
			_subject = () => { return new LocalizableString((FillEmailUserTask.Subject)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SendEmailToCaseGroup, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SendEmailToCaseGroup, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		private Func<bool> _isNeedSendEmail;
		public virtual bool IsNeedSendEmail {
			get {
				return (_isNeedSendEmail ?? (_isNeedSendEmail = () => false)).Invoke();
			}
			set {
				_isNeedSendEmail = () => { return value; };
			}
		}

		public virtual string RecipientEmails {
			get;
			set;
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

		public virtual Guid CaseRecordId {
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

		private ReadCaseDataFlowElement _readCaseData;
		public ReadCaseDataFlowElement ReadCaseData {
			get {
				return _readCaseData ?? (_readCaseData = new ReadCaseDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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

		private ProcessScriptTask _prepareRecipientEmails;
		public ProcessScriptTask PrepareRecipientEmails {
			get {
				return _prepareRecipientEmails ?? (_prepareRecipientEmails = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareRecipientEmails",
					SchemaElementUId = new Guid("4a1291aa-8caf-4e54-8275-887b0bb550c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = PrepareRecipientEmailsExecute,
				});
			}
		}

		private AddEmailDataUserTaskFlowElement _addEmailDataUserTask;
		public AddEmailDataUserTaskFlowElement AddEmailDataUserTask {
			get {
				return _addEmailDataUserTask ?? (_addEmailDataUserTask = new AddEmailDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("fce8a14e-9408-4274-8948-3165aeb15892"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _sendEmailScriptTask;
		public ProcessScriptTask SendEmailScriptTask {
			get {
				return _sendEmailScriptTask ?? (_sendEmailScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendEmailScriptTask",
					SchemaElementUId = new Guid("60f2028e-d6aa-415b-bb5b-ef027be86bcf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SendEmailScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _startEvent1;
		public ProcessFlowElement StartEvent1 {
			get {
				return _startEvent1 ?? (_startEvent1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartEvent1",
					SchemaElementUId = new Guid("58c9e19e-5a97-42fa-8666-4613269c9517"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("b19e5a82-b497-469b-b25d-0c491fd8111a"),
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

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("eeede76c-0137-4ded-80aa-cc1cc3f876de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
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
					SchemaElementUId = new Guid("75bdf120-c093-47fd-b23e-d52f059ec58c"),
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
					SchemaElementUId = new Guid("8f83be51-9c06-45ff-b8d8-dd8224eb633a"),
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
			FlowElements[ReadCaseData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadCaseData };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[FillEmailUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FillEmailUserTask };
			FlowElements[PrepareRecipientEmails.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareRecipientEmails };
			FlowElements[AddEmailDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddEmailDataUserTask };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[SendEmailScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SendEmailScriptTask };
			FlowElements[StartEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartEvent1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ReadCaseData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FillEmailUserTask", e.Context.SenderName));
						break;
					case "FillEmailUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PrepareRecipientEmails", e.Context.SenderName));
						break;
					case "PrepareRecipientEmails":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						Log.ErrorFormat(DeadEndGatewayLogMessage, "PrepareRecipientEmails");
						break;
					case "AddEmailDataUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SendEmailScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "SendEmailScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "StartEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadCaseData", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddEmailDataUserTask", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddEmailDataUserTask", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((IsNeedSendEmail));
			Log.InfoFormat(ConditionalExpressionLogMessage, "PrepareRecipientEmails", "ConditionalSequenceFlow1", "(IsNeedSendEmail)", result);
			return result;
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadCaseData.ResultEntity.IsColumnValueLoaded(ReadCaseData.ResultEntity.Schema.Columns.GetByName("Origin").ColumnValueName) ? ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("OriginId") : Guid.Empty)) ==new Guid("7f9e1f1e-f46b-1410-3492-0050ba5d6c38"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow2", "((ReadCaseData.ResultEntity.IsColumnValueLoaded(ReadCaseData.ResultEntity.Schema.Columns.GetByName(\"Origin\").ColumnValueName) ? ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>(\"OriginId\") : Guid.Empty)) ==new Guid(\"7f9e1f1e-f46b-1410-3492-0050ba5d6c38\")", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("RecipientEmails")) {
				writer.WriteValue("RecipientEmails", RecipientEmails, null);
			}
			if (!HasMapping("CaseRecordId")) {
				writer.WriteValue("CaseRecordId", CaseRecordId, Guid.Empty);
			}
			if (!HasMapping("EmailSender")) {
				writer.WriteValue("EmailSender", EmailSender, null);
			}
			if (!HasMapping("IsNeedSendEmail")) {
				writer.WriteValue("IsNeedSendEmail", IsNeedSendEmail, false);
			}
			if (!HasMapping("TemplateId")) {
				writer.WriteValue("TemplateId", TemplateId, Guid.Empty);
			}
			if (!HasMapping("Subject")) {
				writer.WriteValue("Subject", Subject, null);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartEvent1", string.Empty));
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
			MetaPathParameterValues.Add("56772c15-0da6-416b-89f3-18ff8e888563", () => IsNeedSendEmail);
			MetaPathParameterValues.Add("7ea8c009-6542-4fdd-9572-6a844d21ab92", () => RecipientEmails);
			MetaPathParameterValues.Add("94d0d4a6-3942-434c-add8-db0c09b339ba", () => TemplateId);
			MetaPathParameterValues.Add("ce79eab9-3a98-423f-b3e9-66323aac7d60", () => CaseRecordId);
			MetaPathParameterValues.Add("50441308-78db-4135-97ae-5d3c91b5f48f", () => Subject);
			MetaPathParameterValues.Add("fb6b20e1-ef67-4e02-ae21-d8d6528daffe", () => EmailSender);
			MetaPathParameterValues.Add("4bff0fd5-1b5b-42da-97ec-43b95e6ba9cb", () => ReadCaseData.DataSourceFilters);
			MetaPathParameterValues.Add("a33f837c-29dc-4fee-a6ce-9b43656fdcf8", () => ReadCaseData.ResultType);
			MetaPathParameterValues.Add("abb94808-5aed-4a2b-91a0-b3c4e019244f", () => ReadCaseData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("5c31db74-03b4-4e13-b937-a5bd1c4b9346", () => ReadCaseData.NumberOfRecords);
			MetaPathParameterValues.Add("43f58502-a3f9-4d89-8b05-bfd006634914", () => ReadCaseData.FunctionType);
			MetaPathParameterValues.Add("9bbb4181-ec2f-4b6d-9c67-a8acb3d3bb29", () => ReadCaseData.AggregationColumnName);
			MetaPathParameterValues.Add("71f14a14-3659-44b0-8b17-52639bb50b8b", () => ReadCaseData.OrderInfo);
			MetaPathParameterValues.Add("b3e79b7f-0cf2-4db9-a3b5-50f22bd30da9", () => ReadCaseData.ResultEntity);
			MetaPathParameterValues.Add("b94c3537-238d-4c55-bf91-3524d23fa348", () => ReadCaseData.ResultCount);
			MetaPathParameterValues.Add("11c9e107-95c8-4c1c-9999-e948c31b229b", () => ReadCaseData.ResultIntegerFunction);
			MetaPathParameterValues.Add("ec11c857-840d-4bf0-81d9-e4b22444f6a4", () => ReadCaseData.ResultFloatFunction);
			MetaPathParameterValues.Add("a7dfeac1-20f7-4098-9ddf-8b4e9e037ab5", () => ReadCaseData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("3b5fc9e6-f635-4946-96d0-99a07663b06a", () => ReadCaseData.ResultRowsCount);
			MetaPathParameterValues.Add("1b1d7240-335a-4137-9822-956528e4d5c8", () => ReadCaseData.CanReadUncommitedData);
			MetaPathParameterValues.Add("79abe934-9fa1-465e-b36c-e6a83fcae767", () => ReadCaseData.ResultEntityCollection);
			MetaPathParameterValues.Add("0a7890ce-b0ce-4cb6-9467-4d2a3d591114", () => ReadCaseData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("957348b6-6c6f-4f23-9005-92046516fcbf", () => ReadCaseData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("80dc665c-d274-472d-b93c-096ce2079593", () => ReadCaseData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("a4fdcd96-edab-4671-bd7e-1885420719da", () => ReadCaseData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("5601149a-7688-4bb0-829b-346b4f6428e9", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("33bce745-fb67-43b6-b483-90cf9af1f475", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("c1bec890-46fb-4d20-8d4a-05948010b323", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("9b2c93dd-c44c-440a-9072-328f06f7b94c", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("f13d3489-febd-495e-87cf-34c08df24766", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("5109a2ba-50c9-44b0-8714-4102a725b645", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("82ffd8c0-e88a-4530-87aa-024e8633e4d5", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("6f04cfdc-2015-4135-b910-ee8e91e73e65", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("81e8c52d-6348-476a-919b-4c222b549563", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("f54c25eb-87ff-4e05-9ea4-fa641521ef7d", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("bf35315a-7b9b-4e81-9cca-4628bc3abbe5", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("19ab1ec6-b279-4170-9439-600c31df5a4a", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("bafbaee0-2586-4010-ba1c-e98dd9e853cc", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("6abdacf3-1dd7-4b36-b7bc-80b7b2a13122", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("31a337f9-edbe-45b5-995e-4c7b22eee133", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("9f758c03-00f6-4843-b6eb-99c9178eaf1a", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("bbc539f4-868f-49dd-9dd3-cef59500c068", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("29b08ce6-a116-4009-aec0-c220240793d0", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("c01248a2-cf2e-4f75-9efa-1ebd98ed13d4", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("eb64ce85-4fbd-4226-97de-985e5b9fef59", () => FillEmailUserTask.Subject);
			MetaPathParameterValues.Add("35173a57-a2e2-479f-aa27-bd861b439f14", () => FillEmailUserTask.Body);
			MetaPathParameterValues.Add("80f75966-6900-4fcd-8f09-804f82c014af", () => FillEmailUserTask.RecordId);
			MetaPathParameterValues.Add("86a9ca15-a29b-468f-92c9-7070bbd6f371", () => FillEmailUserTask.TemplateId);
			MetaPathParameterValues.Add("9fbf2e69-990b-41f6-8ec5-c33d551a4914", () => FillEmailUserTask.SysEntitySchemaId);
			MetaPathParameterValues.Add("847cacd4-6fdf-4340-890f-2d494c4c5c98", () => AddEmailDataUserTask.EntitySchemaId);
			MetaPathParameterValues.Add("31e0eb82-93a1-4879-91aa-b744930a4611", () => AddEmailDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("567a0c1b-7356-49ce-93db-d58cb11abf8f", () => AddEmailDataUserTask.RecordAddMode);
			MetaPathParameterValues.Add("6a9f6041-ec7b-424a-88e3-3c868e83e490", () => AddEmailDataUserTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("91d4d62a-3cec-433d-b549-0651c8113c05", () => AddEmailDataUserTask.RecordDefValues);
			MetaPathParameterValues.Add("296257aa-1125-48e6-a411-79017af52a29", () => AddEmailDataUserTask.RecordId);
			MetaPathParameterValues.Add("6f656226-9a82-4643-a447-c6a6c5906771", () => AddEmailDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("4d3f858a-52c5-430f-800f-6955ea542711", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("bfbc3d0d-9a1e-43da-adb7-89e445d1a625", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("18710cc5-5550-481e-a010-e0505fa8b2a9", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("66e99c9d-a861-41c9-9892-3b4320edcabf", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("55a48763-bffc-4c07-9950-003aefdc3654", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("d00b0ee2-e935-4829-a4db-fe5abd649d41", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("39985f73-d9e1-4a6e-8cd4-a40b31d7e533", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("9c756e63-5afb-42ed-94f8-3ee3f4bf4d9d", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("ea2ee12d-af13-403c-883f-817b024d86a9", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("fd47a28a-0a99-4a41-8153-9064ca9dad24", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("ab1d5b68-f04f-4772-8051-b480bf6acbc0", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("d83f0b00-f100-417a-a588-eb7796e2396a", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("4295e0df-6d0d-459b-a4fe-8ae3f18b4356", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("67446c2d-1033-4a62-98c7-f79a1d2cff50", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("a65afada-0121-4d32-8046-c15726057d12", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("85c368fc-5947-409e-9f8d-423a3de5d035", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("b7f41d79-3f1f-44f6-97ed-626171550655", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("aba25d6c-1595-4be2-8a98-78b42b829b67", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("1820e651-8fa2-4509-9090-034da1a1911e", () => ReadDataUserTask1.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "RecipientEmails":
					if (!hasValueToRead) break;
					RecipientEmails = reader.GetValue<System.String>();
				break;
				case "CaseRecordId":
					if (!hasValueToRead) break;
					CaseRecordId = reader.GetValue<System.Guid>();
				break;
				case "EmailSender":
					if (!hasValueToRead) break;
					EmailSender = reader.GetValue<System.String>();
				break;
				case "IsNeedSendEmail":
					if (!hasValueToRead) break;
					IsNeedSendEmail = reader.GetValue<System.Boolean>();
				break;
				case "TemplateId":
					if (!hasValueToRead) break;
					TemplateId = reader.GetValue<System.Guid>();
				break;
				case "Subject":
					if (!hasValueToRead) break;
					Subject = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool PrepareRecipientEmailsExecute(ProcessExecutingContext context) {
			EmailSender = (string)Terrasoft.Core.Configuration.SysSettings.GetValue<string>(UserConnection, 
				"SupportServiceEmail", String.Empty);
			var emailSelect = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAdminUnit");
			var emailColumn = emailSelect.AddColumn("Contact.Email");
			var groupId = ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("GroupId");
			emailSelect.Filters.Add(emailSelect.CreateFilterWithParameters(FilterComparisonType.Equal, "[SysUserInRole:SysUser].SysRole", groupId));
			var collection = emailSelect.GetEntityCollection(UserConnection);
			IsNeedSendEmail = collection.Count > 0;
			RecipientEmails = string.Empty;
			foreach(var entity in collection) {
				var email = entity.GetTypedColumnValue<string>(emailColumn.Name); 
				if (!string.IsNullOrEmpty(email)) {
					RecipientEmails += string.Format("{0};", email);
				}
			}
			return true; 
		}

		public virtual bool SendEmailScriptTaskExecute(ProcessExecutingContext context) {
			var activityId = AddEmailDataUserTask.RecordId;
			if (UserConnection.GetIsFeatureEnabled("UseAsyncEmailSender")) {
				AsyncEmailSender emailSender = new AsyncEmailSender(UserConnection);
				emailSender.SendAsync(activityId);
			} else {
				var emailClientFactory = ClassFactory.Get<EmailClientFactory>(new ConstructorArgument("userConnection", UserConnection));
				var activityEmailSender = new ActivityEmailSender(emailClientFactory, UserConnection);
				Terrasoft.Configuration.CommonUtilities.CopyFileDetail(UserConnection, TemplateId, activityId, "EmailTemplate", "Activity", true); 
				activityEmailSender.Send(activityId);
			}
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localSubject = (((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<string>("Title") : null))).IndexOf("RE: ", StringComparison.OrdinalIgnoreCase) == 0 ? (((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<string>("Title") : null))) : "RE: " + (((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<string>("Title") : null)));
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
			var cloneItem = (SendEmailToCaseGroup)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


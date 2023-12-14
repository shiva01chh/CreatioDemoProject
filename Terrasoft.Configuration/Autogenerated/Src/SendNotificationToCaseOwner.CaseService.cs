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
	using TConfiguration = Terrasoft.Configuration;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SendNotificationToCaseOwnerSchema

	/// <exclude/>
	public class SendNotificationToCaseOwnerSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SendNotificationToCaseOwnerSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SendNotificationToCaseOwnerSchema(SendNotificationToCaseOwnerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendNotificationToCaseOwner";
			UId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"ru-RU";
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
			UseForceCompile = true;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateActivityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("917716bf-4d97-4095-a230-624af4a6b429"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseOwnerIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dbd4dbea-e2f6-43a8-9366-14aac293091e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"CaseOwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("63e2fd8f-d2d4-4c91-a9a3-3eea91ebb907"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"CaseId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("709f0792-1296-4595-93ee-af64360d8192"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"SubjectCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateAssigneeIsClearedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9857231e-99d6-4e24-98f0-e976db21dd58"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"AssigneeIsCleared",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#BooleanValue.False#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateActivityIdParameter());
			Parameters.Add(CreateCaseOwnerIdParameter());
			Parameters.Add(CreateCaseIdParameter());
			Parameters.Add(CreateSubjectCaptionParameter());
			Parameters.Add(CreateAssigneeIsClearedParameter());
		}

		protected virtual void InitializeReadCaseDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4506bd0f-7d6f-4191-9565-845a21c0d11d"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,203,110,219,48,16,252,149,66,231,48,160,222,162,111,133,235,22,185,52,1,98,228,82,231,176,34,151,54,81,201,18,72,58,173,27,248,223,187,148,108,215,41,92,196,237,165,209,65,162,6,195,217,217,215,115,36,27,112,238,51,180,24,77,162,57,90,11,174,211,254,250,163,105,60,218,79,182,219,244,209,85,228,208,26,104,204,15,84,35,62,83,198,127,0,15,116,229,121,241,75,97,17,77,22,231,53,22,209,213,34,50,30,91,71,28,186,82,201,76,149,69,206,89,150,151,146,94,137,96,53,74,201,138,76,199,73,174,210,170,144,124,100,254,73,124,218,181,61,88,28,99,12,242,122,56,206,183,125,160,198,4,200,129,98,92,183,222,131,105,48,225,102,107,168,27,84,244,239,237,6,9,242,214,180,148,13,206,77,139,119,96,41,86,208,233,2,68,36,13,141,11,172,6,181,159,125,239,45,58,103,186,245,107,230,154,77,187,62,101,147,0,30,127,247,118,248,224,49,48,239,192,175,6,137,27,178,181,27,92,190,95,46,45,46,193,155,167,83,19,95,113,59,240,46,171,31,93,80,212,165,7,104,54,120,18,243,101,38,83,232,253,152,208,24,158,8,214,44,87,23,231,122,172,216,107,233,38,4,246,7,242,133,154,103,115,72,10,2,159,2,48,170,28,142,139,232,203,141,187,253,182,70,123,47,87,216,194,88,181,199,107,66,127,3,142,250,147,231,34,197,68,171,74,51,149,168,140,101,82,196,12,4,164,44,69,4,17,99,93,11,94,238,30,71,31,198,245,13,108,31,142,225,166,224,240,221,190,102,225,67,144,80,165,40,57,8,198,101,92,176,12,243,146,213,66,215,76,163,230,60,151,113,174,179,138,90,28,158,208,137,110,105,36,52,183,61,90,216,55,129,159,159,209,23,195,29,242,183,93,231,199,172,142,245,11,118,6,47,135,41,225,101,38,84,82,32,203,85,93,134,81,169,88,45,19,197,48,230,154,87,82,136,180,214,100,134,22,60,148,248,190,219,88,185,95,40,55,110,246,63,109,236,127,216,195,191,89,173,179,195,125,201,176,190,149,49,124,51,147,182,139,118,63,1,187,245,87,161,63,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("125091b9-9929-4b16-b593-00f43685f38f"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5abb2c3a-53c2-45f9-a792-dc0d56899ec5"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("69ff34a2-2575-4283-8a79-1849034587f1"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6bda2483-0b9a-4e13-83aa-ef65d8e5fc29"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d0a9c951-282e-4b35-b2b9-586d16c25933"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				UId = new Guid("cd4e92d5-8ac6-4681-9893-10531933e9f7"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("c0f47d08-77d4-4f35-b9b8-79efd4ecc233"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e3648d82-88fe-4d08-83f0-38a192059287"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				UId = new Guid("51a965b5-b922-460b-8ded-70db0b0b9559"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				UId = new Guid("1a36246f-ef97-4371-8e3c-6e2fdff4875d"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				UId = new Guid("e6df8d5b-cab3-4471-b93f-f16dbda2f9a4"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				UId = new Guid("23e88460-2b78-42f3-bb7d-bc523ec78b23"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				UId = new Guid("efcb90d5-185b-45d2-b46e-ebdd4f4422c5"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				UId = new Guid("78164945-a544-4c0f-a423-9e6fcc580552"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3c50e486-1699-49e5-a51a-1bc6cd510ae5"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("876cd4a1-2b3c-48b1-85e5-ea04e0312504"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				UId = new Guid("a62dc61c-733d-49ca-a1e9-773df8ed0bc6"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				UId = new Guid("b35bf595-fe8e-4d6a-866b-bb4dbc6e25d9"),
				ContainerUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
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
				UId = new Guid("78d57c59-616c-456c-ac2c-9cd77bdbd677"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,203,110,219,48,16,252,21,67,231,48,208,155,146,111,69,234,22,185,52,65,19,228,82,231,176,34,151,14,81,189,64,82,105,93,195,255,222,165,100,187,78,225,34,110,47,45,80,157,196,193,236,112,246,197,77,32,106,176,246,3,52,24,204,131,123,52,6,108,167,220,229,59,93,59,52,239,77,55,244,193,69,96,209,104,168,245,55,148,19,190,144,218,189,5,7,20,178,89,254,80,88,6,243,229,105,141,101,112,177,12,180,195,198,18,135,66,56,72,20,89,137,172,204,11,201,82,46,83,86,228,0,76,149,170,148,97,138,113,154,69,19,243,87,226,87,93,211,131,193,233,142,81,94,141,191,247,235,222,83,35,2,196,72,209,182,107,119,96,226,77,216,69,11,85,141,146,206,206,12,72,144,51,186,161,108,240,94,55,120,11,134,238,242,58,157,135,136,164,160,182,158,85,163,114,139,175,189,65,107,117,215,190,102,174,30,154,246,152,77,2,120,56,238,236,132,163,71,207,188,5,247,52,74,92,147,173,237,232,242,205,106,101,112,5,78,63,31,155,248,140,235,145,119,94,253,40,64,82,151,30,160,30,240,232,206,151,153,92,65,239,166,132,166,235,137,96,244,234,233,236,92,15,21,123,45,221,152,192,126,79,62,83,243,100,14,113,78,224,179,7,38,149,253,239,50,248,116,109,111,190,180,104,238,196,19,54,48,85,237,241,146,208,159,128,69,141,13,182,110,190,17,97,156,131,226,25,11,99,42,97,170,42,100,80,148,37,139,42,30,37,5,96,165,210,114,75,1,7,67,62,68,81,189,195,130,113,62,134,36,25,171,202,138,142,37,42,153,162,16,113,146,248,144,69,235,180,91,79,147,48,223,0,143,64,2,2,75,210,156,162,36,34,171,170,84,49,193,33,75,178,52,11,65,242,237,227,148,174,182,125,13,235,135,67,86,31,17,228,76,128,197,153,175,4,173,149,177,110,230,151,105,214,169,25,213,120,168,157,110,87,51,26,165,26,133,239,229,229,157,3,55,216,81,205,183,148,52,162,56,207,170,40,146,44,47,43,63,48,89,194,138,72,84,172,168,68,130,0,145,140,68,76,163,231,63,63,33,221,74,11,168,111,122,52,176,27,142,240,244,238,188,88,58,223,23,211,117,110,170,246,161,175,87,100,253,200,209,126,134,21,207,121,148,166,84,113,197,5,75,69,6,100,137,199,76,38,25,64,156,39,33,7,154,225,45,61,63,62,237,187,110,48,98,183,238,118,122,119,254,232,61,249,11,175,196,239,44,254,201,213,59,103,149,254,179,37,249,199,198,122,27,108,191,3,210,30,43,144,74,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("86e26d5e-484f-41f0-bbab-fc34eeb9aa75"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e78616d2-d5e4-45ff-b596-cd4077bd95f6"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("15712166-8aff-40a6-aa13-01c7f3e35c6d"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4f55e2a6-ba23-43c6-830c-0c37149c2dfa"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("22a51850-96e2-4f1b-921c-2e8ae641277c"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				UId = new Guid("bbcdf8e1-e64e-4131-8c66-a7875bc9aa86"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				UId = new Guid("7f3b2864-d5d3-405d-b781-90d93ae8c182"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3fdbb8ea-a109-436f-9526-5f4981e720df"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				UId = new Guid("9b717c7a-0916-4442-a7e2-1eb5d8444932"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				UId = new Guid("f94eb8f0-f6d7-4e39-bcac-5f524d486d10"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				UId = new Guid("0a8a652e-132a-4a06-ba66-aaf55eb0d4ee"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				UId = new Guid("02e560cd-10d7-4e56-bd33-2638021393b9"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				UId = new Guid("b6a76e86-7bda-4867-9d85-33825ffc996a"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				ReferenceSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				UId = new Guid("9e70bb31-84bd-4894-9154-dc72555d80ee"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ae4b4580-882a-42d6-858b-fc7f1a5ad5ae"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41083d4f-db04-4676-8683-a5a2eb046ccf"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				UId = new Guid("09e221cf-ac9c-411c-a00e-e3ea288e8aa1"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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
				UId = new Guid("e6419337-a5aa-4730-a472-2788ba1d6154"),
				ContainerUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
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

		protected virtual void InitializeChangeDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("4de1092c-2886-4a3a-b044-6a900b08bad6"),
				ContainerUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0ba9435d-0627-444d-8a1f-ad7297863488"),
				ContainerUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("179d913f-3405-40bc-89fb-a1def3ab9a09"),
				ContainerUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,203,110,219,48,16,252,21,67,231,48,144,68,234,65,223,138,212,45,114,105,130,38,200,165,206,97,69,174,28,162,122,129,164,211,186,134,255,189,75,201,113,147,194,69,220,94,90,160,190,88,28,204,44,103,95,220,70,170,1,231,62,64,139,209,60,186,69,107,193,245,181,63,127,103,26,143,246,189,237,215,67,116,22,57,180,6,26,243,13,245,132,47,180,241,111,193,3,73,182,203,31,17,150,209,124,121,60,198,50,58,91,70,198,99,235,136,19,36,105,38,53,207,4,211,50,85,76,84,21,103,37,170,156,197,144,40,157,197,192,115,13,123,230,47,130,95,244,237,0,22,167,59,198,240,245,248,121,187,25,2,53,33,64,141,20,227,250,110,15,242,96,194,45,58,168,26,212,116,246,118,141,4,121,107,90,202,6,111,77,139,215,96,233,174,16,167,15,16,145,106,104,92,96,53,88,251,197,215,193,162,115,166,239,94,51,215,172,219,238,57,155,2,224,225,184,183,19,143,30,3,243,26,252,195,24,226,146,108,237,70,151,111,86,43,139,43,240,230,241,185,137,207,184,25,121,167,213,143,4,154,186,116,7,205,26,159,221,249,50,147,11,24,252,148,208,116,61,17,172,89,61,156,156,235,161,98,175,165,155,18,56,60,145,79,140,121,52,135,52,39,240,49,0,83,148,167,207,101,244,233,210,93,125,233,208,222,168,7,108,97,170,218,253,57,161,63,1,139,6,91,236,252,124,171,226,52,135,186,200,88,156,106,193,68,93,33,131,82,74,150,84,69,194,75,192,170,22,114,71,130,131,161,32,169,69,161,227,146,21,197,40,225,25,171,100,69,71,137,181,22,168,84,202,121,144,44,58,111,252,102,154,132,249,22,48,70,145,41,96,74,200,140,84,88,48,224,82,51,14,85,145,22,37,38,121,82,236,238,167,116,141,27,26,216,220,29,178,250,136,160,103,10,28,206,66,37,104,173,172,243,179,176,76,179,190,158,81,141,215,141,55,221,106,70,163,212,160,10,189,60,223,247,49,252,145,62,75,177,200,185,72,152,174,184,164,97,81,9,131,84,150,76,39,165,2,1,18,138,92,209,216,133,95,152,142,126,101,20,52,87,3,90,216,15,70,124,124,111,94,44,92,232,137,237,123,63,85,250,208,211,11,178,61,122,57,76,110,13,121,174,179,148,145,43,205,68,89,39,172,82,133,96,82,96,165,57,87,50,139,57,153,161,71,39,36,123,211,175,173,218,47,185,155,94,155,63,122,69,254,194,219,240,59,235,126,116,225,78,89,160,255,108,53,254,153,129,222,69,187,239,24,243,34,169,58,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a90561e6-7bbd-4a0f-96af-b770af8d44eb"),
				ContainerUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,83,77,79,27,49,16,253,43,200,112,140,87,246,250,59,87,168,42,164,80,69,64,185,16,14,99,123,92,162,110,178,209,126,84,162,81,254,123,157,37,1,130,10,173,212,94,42,213,7,175,236,157,247,102,60,239,205,154,156,116,15,43,36,99,114,141,77,3,109,157,186,226,180,110,176,152,54,117,192,182,45,38,117,128,106,254,29,124,133,83,104,96,129,29,54,55,80,245,216,78,230,109,55,58,58,132,145,17,57,249,54,252,37,227,219,53,57,239,112,241,249,60,102,246,210,186,82,66,82,212,178,82,83,25,189,160,32,101,162,82,249,160,140,244,81,160,207,224,80,87,253,98,121,129,29,76,161,187,39,227,53,25,216,50,1,24,14,17,16,168,144,90,102,2,68,234,125,38,8,6,148,80,82,49,136,134,108,70,164,13,247,184,128,33,233,51,152,115,19,69,153,28,181,165,81,57,167,144,212,74,206,41,15,90,115,174,2,186,16,183,224,93,252,51,240,246,120,82,215,95,251,85,225,92,18,138,113,65,181,55,64,165,137,154,122,41,25,69,145,56,48,15,206,241,80,36,166,243,51,60,210,20,67,126,164,179,101,78,35,56,141,54,36,80,101,194,24,210,241,221,54,81,156,183,171,10,30,110,222,204,119,10,45,30,181,29,116,125,91,92,98,189,194,37,198,71,232,234,64,133,151,224,245,236,81,204,25,25,207,222,146,115,247,189,26,186,116,40,232,107,45,103,100,52,35,87,117,223,132,45,163,200,135,179,23,85,15,73,134,144,87,199,189,120,249,102,217,87,213,238,230,12,58,216,7,238,175,235,56,79,115,140,231,203,171,189,102,3,11,219,45,250,147,109,191,30,107,251,19,216,5,44,225,11,54,159,114,3,158,107,127,170,242,58,183,113,79,236,75,167,152,225,137,26,4,71,37,234,172,106,228,64,29,119,62,9,147,125,149,202,1,125,137,9,27,92,6,60,44,236,119,172,179,195,183,67,183,183,83,179,171,107,219,170,13,217,108,70,47,103,137,25,103,19,147,150,26,145,68,118,115,8,20,44,104,170,149,21,40,140,54,202,198,119,103,201,48,93,178,152,123,131,50,15,148,204,175,161,46,91,54,83,153,50,133,104,163,228,254,239,207,210,199,126,30,139,15,139,85,247,240,222,4,28,70,253,55,251,63,102,118,174,61,10,173,56,181,9,75,42,185,202,62,137,145,101,131,50,17,165,182,34,70,241,43,179,223,109,126,0,81,130,55,189,150,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a241d043-f9e0-415b-88e4-72152150dcb4"),
				ContainerUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
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

		protected virtual void InitializeChangeDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("dc0d8500-2c5d-44ee-8b80-5d1ee9e419af"),
				ContainerUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
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
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("582913d8-566d-458d-b331-4604de9e8c23"),
				ContainerUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
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
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("db752332-2f10-401f-9ce4-5238cd69c2e9"),
				ContainerUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,77,143,211,48,16,253,43,85,206,235,42,159,77,210,27,42,5,237,133,93,177,213,94,200,30,38,206,56,181,112,62,100,187,11,165,234,127,103,156,180,165,139,138,182,32,33,14,228,100,63,189,153,121,51,158,151,157,199,21,24,243,1,26,244,230,222,10,181,6,211,9,59,125,39,149,69,253,94,119,155,222,187,241,12,106,9,74,126,195,106,196,151,149,180,111,193,2,133,236,138,31,25,10,111,94,92,206,81,120,55,133,39,45,54,134,56,20,146,8,168,252,32,207,88,128,60,100,49,159,9,150,139,40,100,25,175,194,68,36,65,24,165,254,200,252,85,242,69,215,244,160,113,172,49,164,23,195,113,181,237,29,53,32,128,15,20,105,186,246,0,70,78,132,89,182,80,42,172,232,110,245,6,9,178,90,54,212,13,174,100,131,247,160,169,150,203,211,57,136,72,2,148,113,44,133,194,46,191,246,26,141,145,93,251,154,56,181,105,218,115,54,37,192,211,245,32,199,31,52,58,230,61,216,245,144,226,150,100,237,7,149,111,234,90,99,13,86,62,159,139,248,140,219,129,119,221,252,40,160,162,87,122,4,181,193,179,154,47,59,89,64,111,199,134,198,242,68,208,178,94,95,221,235,105,98,175,181,27,18,216,31,201,87,230,188,216,67,56,35,240,217,1,99,150,227,177,240,62,221,154,187,47,45,234,7,190,198,6,198,169,61,77,9,253,9,88,42,108,176,181,243,29,247,195,25,136,52,97,126,88,197,44,22,37,50,200,242,156,5,101,26,68,25,96,41,226,124,79,1,39,65,46,68,196,105,229,103,44,77,135,144,40,97,101,94,210,53,71,81,197,200,121,24,69,46,100,217,90,105,183,227,38,204,119,128,62,198,9,7,198,227,60,161,40,76,25,68,121,197,34,40,211,48,205,48,152,5,233,254,105,108,87,154,94,193,246,241,212,213,71,132,106,194,193,224,196,77,130,108,165,141,157,56,51,77,58,49,161,25,111,148,149,109,61,161,85,82,200,221,91,78,135,53,114,159,123,237,174,150,28,212,93,143,26,14,15,237,95,246,193,11,3,185,25,235,174,179,227,228,78,111,180,32,25,131,202,227,38,82,33,250,65,56,97,15,221,70,243,131,33,205,248,103,248,35,199,255,3,31,255,142,53,47,154,227,154,101,255,159,214,248,111,46,223,222,219,127,7,180,254,100,80,182,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bc1fbcca-fa65-4c95-9a77-ce97f378b282"),
				ContainerUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,193,110,219,48,12,253,149,66,237,49,52,44,75,182,162,92,219,75,128,116,8,154,174,151,166,7,74,162,214,96,142,29,88,246,128,46,200,191,79,113,236,166,41,86,96,192,116,144,33,154,239,241,137,143,218,179,155,246,109,71,108,198,30,169,105,48,212,190,77,110,235,134,146,101,83,91,10,33,89,212,22,203,205,111,52,37,45,177,193,45,181,212,60,97,217,81,88,108,66,59,185,186,132,177,9,187,249,213,255,101,179,231,61,155,183,180,253,62,119,145,221,25,229,165,76,29,100,62,227,32,133,77,97,42,184,7,173,20,183,153,201,76,225,242,8,182,117,217,109,171,123,106,113,137,237,43,155,237,89,207,22,9,80,113,116,72,8,66,22,18,164,35,2,99,164,7,171,48,23,185,204,83,116,138,29,38,44,216,87,218,98,95,244,12,230,92,57,145,121,13,211,76,229,32,115,33,97,42,57,7,110,139,130,243,220,146,182,238,8,30,242,207,192,231,235,69,93,255,236,118,137,214,94,228,41,23,80,24,133,32,149,43,192,196,251,0,9,207,49,53,168,53,183,137,79,11,65,198,16,120,103,11,144,122,154,197,50,130,131,155,90,143,121,230,201,89,127,253,114,44,228,54,97,87,226,219,211,151,245,110,49,208,85,104,177,237,66,242,64,245,142,42,114,39,232,238,194,133,143,224,253,250,100,230,154,205,214,95,217,57,124,87,125,151,46,13,253,236,229,154,77,214,108,85,119,141,61,50,138,120,184,251,160,186,47,210,167,124,58,142,230,197,72,213,149,229,16,185,195,22,199,196,49,92,187,141,223,144,155,87,171,209,179,158,37,29,22,252,101,27,215,73,219,255,192,238,177,194,31,212,124,139,13,56,107,127,87,249,24,219,56,18,155,76,231,169,138,179,170,8,53,72,42,162,171,142,35,104,174,141,23,42,206,149,207,122,244,3,121,106,168,178,116,41,236,95,70,103,192,135,190,219,199,87,51,232,58,182,234,192,14,135,151,195,31,36,81,154,26,169,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f9301d60-5593-4dda-8ec5-b940b63c89d7"),
				ContainerUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
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
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaUserTask readcasedata = CreateReadCaseDataUserTask();
			FlowElements.Add(readcasedata);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaScriptTask createnotificationscripttask = CreateCreateNotificationScriptTaskScriptTask();
			FlowElements.Add(createnotificationscripttask);
			ProcessSchemaScriptTask setactivityserviceprocessed = CreateSetActivityServiceProcessedScriptTask();
			FlowElements.Add(setactivityserviceprocessed);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			ProcessSchemaUserTask changedatausertask2 = CreateChangeDataUserTask2UserTask();
			FlowElements.Add(changedatausertask2);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			FlowElements.Add(exclusivegateway3);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow3ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("707dc0f7-731e-4b42-b6bc-33a3ac14d1d6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0f86f691-728b-4367-98e9-372c14b8eb83"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e480bdab-02d9-43fb-9d11-3cab3de13d05"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("dea78ebe-598e-4789-8933-7e97ada40c4e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d7cc27a6-e003-48dc-a893-2c2b634e3685"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("164028a5-0e9f-43b5-b440-9f409420a265"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"([#[IsOwnerSchema:false].[IsSchema:false].[Element:{9755f7a3-15ff-4623-b0f7-6bd8b05d9682}].[Parameter:{7f3b2864-d5d3-405d-b781-90d93ae8c182}].[EntityColumn:{0a97a9ee-3cf1-4e17-ae9c-b06583f4b46e}]#] || [#[IsOwnerSchema:false].[IsSchema:false].[Element:{9755f7a3-15ff-4623-b0f7-6bd8b05d9682}].[Parameter:{7f3b2864-d5d3-405d-b781-90d93ae8c182}].[EntityColumn:{98771b3f-7dbe-4b12-a017-0ab8d406a02a}]#]) &&  ([#[IsOwnerSchema:false].[IsSchema:false].[Element:{c026af75-02d4-4fbe-a899-1b7138aebf49}].[Parameter:{c0f47d08-77d4-4f35-b9b8-79efd4ecc233}].[EntityColumn:{a71adaea-3464-4dee-bb4f-c7a535450ad7}]#] != [#Lookup.99f35013-6b7a-47d6-b440-e3f1a0ba991c.f063ebbe-fdc6-4982-8431-d8cfa52fedcf#])",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7e40039d-bc2e-48e6-98a8-825e345002f1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("e5b968fe-a1e2-4553-9f9e-2365429b0f48"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"([#[IsOwnerSchema:false].[IsSchema:false].[Element:{c026af75-02d4-4fbe-a899-1b7138aebf49}].[Parameter:{c0f47d08-77d4-4f35-b9b8-79efd4ecc233}].[EntityColumn:{70620d00-e4ea-48d1-9fdc-4572fcd8d41b}]#] == Guid.Empty) || ([#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{9857231e-99d6-4e24-98f0-e976db21dd58}]#]==true)",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7cc27a6-e003-48dc-a893-2c2b634e3685"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f0ec85e6-466f-4c94-a9e7-34f9f0f6a0f2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(687, 84));
			schemaFlow.PolylinePointPositions.Add(new Point(862, 84));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("293d8afc-a4e7-4800-987c-5de2164824aa"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2fbbc7ef-f73b-4ac7-8e1a-1d9b4ccd5702"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f0ec85e6-466f-4c94-a9e7-34f9f0f6a0f2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("a35125c1-02b5-47c1-926b-95f966f6b9ce"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4eb36ce5-c20b-4142-85d7-04f72012f119"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7cc27a6-e003-48dc-a893-2c2b634e3685"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2fbbc7ef-f73b-4ac7-8e1a-1d9b4ccd5702"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("efc90b80-b772-4205-bf51-315a08b3047a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7612672-4aa0-4784-991c-5276cb1e1131"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d7cc27a6-e003-48dc-a893-2c2b634e3685"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow3",
				UId = new Guid("1e21d9c0-b54f-47a0-8af2-5c4ae0fa2720"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#SysSettings.ClearAssigneeOnCaseReopening<Boolean>#]==true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7e40039d-bc2e-48e6-98a8-825e345002f1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("18b93021-759a-4d94-84cd-74f76d9acc7d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(274, 452));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow3",
				UId = new Guid("8824362b-6385-4a61-a315-c46db2761d09"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7e40039d-bc2e-48e6-98a8-825e345002f1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("df870c75-8a1b-4baa-8304-cfb719f11ef8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3534cd8c-fb72-4ff0-b6a9-ddc3708c723c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(576, 332));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("a301fe1f-8a8c-4bb6-9d8c-06bf6dc5581d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3534cd8c-fb72-4ff0-b6a9-ddc3708c723c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(576, 452));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("6a9d764d-7daf-46c9-88d3-78c3efb8d84f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18b93021-759a-4d94-84cd-74f76d9acc7d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("4149de33-d5f1-4f2f-8636-d849aa44aaaf"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3534cd8c-fb72-4ff0-b6a9-ddc3708c723c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c7612672-4aa0-4784-991c-5276cb1e1131"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("db31b497-0277-4fd6-9e5b-27bc8d92092d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db31b497-0277-4fd6-9e5b-27bc8d92092d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("0f86f691-728b-4367-98e9-372c14b8eb83"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
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
				UId = new Guid("f0ec85e6-466f-4c94-a9e7-34f9f0f6a0f2"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"Terminate1",
				Position = new Point(849, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadCaseDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ReadCaseData",
				Position = new Point(140, 170),
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
				UId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ReadDataUserTask2",
				Position = new Point(240, 170),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("d7cc27a6-e003-48dc-a893-2c2b634e3685"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ExclusiveGateway1",
				Position = new Point(660, 170),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(460, 425),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateNotificationScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2fbbc7ef-f73b-4ac7-8e1a-1d9b4ccd5702"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"CreateNotificationScriptTask",
				Position = new Point(751, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,85,201,110,219,48,16,61,199,128,255,129,213,137,2,12,162,151,94,154,38,133,45,59,169,15,113,10,47,189,51,210,216,98,33,145,6,23,5,66,224,127,239,80,148,109,57,104,26,53,7,3,34,103,222,27,206,155,197,51,105,133,173,137,134,82,200,76,200,221,44,156,111,200,198,128,78,148,148,144,90,161,36,11,247,171,52,135,146,63,112,201,119,160,217,61,216,185,52,150,203,20,38,245,130,151,64,163,229,145,39,138,135,131,43,150,104,224,22,2,150,94,50,198,215,195,65,197,53,73,185,129,121,134,1,151,192,179,4,15,83,110,57,91,130,113,133,13,64,246,83,139,146,235,58,81,133,43,229,47,94,56,184,38,1,172,158,37,232,119,208,248,202,117,189,135,172,3,255,118,239,68,118,75,163,199,0,143,142,111,145,174,124,2,253,223,108,198,106,204,24,249,22,13,254,68,151,42,148,194,231,138,140,18,158,201,84,52,153,99,42,45,100,68,212,211,111,148,227,150,188,160,90,254,119,21,141,157,205,149,142,70,175,11,144,56,173,65,90,127,203,240,218,242,212,206,51,68,28,70,36,0,219,75,68,182,170,116,141,43,229,116,10,104,91,163,219,86,236,156,230,13,235,169,94,120,109,172,57,159,3,32,60,230,146,170,77,114,212,170,213,53,141,241,169,21,170,132,146,142,200,249,224,93,134,131,67,171,10,166,222,234,177,106,68,152,56,81,100,160,169,87,109,171,176,97,210,156,208,160,11,169,188,190,68,200,179,148,172,145,220,196,77,68,164,98,227,253,30,100,70,27,79,79,113,8,81,114,110,114,12,115,39,10,216,88,81,32,22,140,47,222,195,244,203,15,52,209,153,76,149,207,147,109,164,192,47,240,182,73,109,193,80,79,186,86,225,109,52,142,61,231,171,233,96,43,176,83,216,118,90,192,208,55,220,58,62,52,58,170,217,179,184,125,40,79,206,231,178,247,129,133,234,54,168,143,53,68,159,32,1,186,22,37,252,59,97,84,190,61,226,184,129,247,167,241,113,132,140,107,26,33,225,251,118,142,194,224,176,59,165,75,110,233,167,246,56,55,11,87,20,143,122,86,238,113,209,172,46,64,221,98,250,46,253,78,222,180,19,111,255,74,162,5,54,39,238,57,81,224,94,76,65,84,144,225,199,142,107,159,44,177,57,52,75,139,44,20,123,249,124,192,220,60,234,52,12,177,223,77,239,234,127,241,2,164,184,204,179,187,27,195,202,253,240,66,246,91,44,234,213,18,181,233,82,54,189,113,142,207,54,61,27,43,228,113,66,247,67,249,137,68,128,159,217,191,186,243,10,218,1,179,78,75,98,53,254,3,252,1,42,221,156,166,185,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSetActivityServiceProcessedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c7612672-4aa0-4784-991c-5276cb1e1131"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"SetActivityServiceProcessed",
				Position = new Point(653, 365),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,142,177,10,194,48,20,69,103,251,21,143,76,9,148,252,64,113,144,210,161,155,80,138,243,35,185,98,161,77,245,37,169,250,247,86,172,131,56,94,56,151,115,22,22,98,151,134,101,72,207,254,234,57,129,246,20,112,167,207,208,125,132,212,115,8,88,153,57,148,164,14,27,172,76,177,179,29,146,86,29,100,25,28,142,50,59,196,8,175,74,170,231,49,79,193,30,89,120,66,130,232,51,143,17,230,125,57,93,32,208,170,245,202,216,54,54,183,204,163,254,195,191,146,214,27,67,28,183,152,170,248,45,181,205,3,46,175,145,166,42,4,41,75,160,36,25,213,11,109,242,86,202,212,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("7e40039d-bc2e-48e6-98a8-825e345002f1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ExclusiveGateway2",
				Position = new Point(247, 305),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ChangeDataUserTask2",
				Position = new Point(391, 305),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("18b93021-759a-4d94-84cd-74f76d9acc7d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"FormulaTask1",
				Position = new Point(340, 425),
				ResultParameterMetaPath = @"9857231e-99d6-4e24-98f0-e976db21dd58",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,43,41,42,77,5,0,141,76,252,253,4,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("3534cd8c-fb72-4ff0-b6a9-ddc3708c723c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb8f9711-ecbe-4c20-9d66-6633413c713d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"),
				Name = @"ExclusiveGateway3",
				Position = new Point(549, 365),
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
				UId = new Guid("a62d71a9-1414-4f68-86ab-baff31296a19"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f119a82c-706c-4b56-bf2d-bb763a00c4e7"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c0c3676-9acd-4b48-a524-ac71ec25ed67"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2ec255eb-3b3c-4d0a-a3e1-616e3f38ecdf"),
				Name = "Terrasoft.Configuration",
				Alias = "TConfiguration",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SendNotificationToCaseOwner(userConnection);
		}

		public override object Clone() {
			return new SendNotificationToCaseOwnerSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625"));
		}

		#endregion

	}

	#endregion

	#region Class: SendNotificationToCaseOwner

	/// <exclude/>
	public class SendNotificationToCaseOwner : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendNotificationToCaseOwner process)
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

			public ReadCaseDataFlowElement(UserConnection userConnection, SendNotificationToCaseOwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadCaseData";
				IsLogging = true;
				SchemaElementUId = new Guid("c026af75-02d4-4fbe-a899-1b7138aebf49");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,203,110,219,48,16,252,149,66,231,48,160,222,162,111,133,235,22,185,52,1,98,228,82,231,176,34,151,54,81,201,18,72,58,173,27,248,223,187,148,108,215,41,92,196,237,165,209,65,162,6,195,217,217,215,115,36,27,112,238,51,180,24,77,162,57,90,11,174,211,254,250,163,105,60,218,79,182,219,244,209,85,228,208,26,104,204,15,84,35,62,83,198,127,0,15,116,229,121,241,75,97,17,77,22,231,53,22,209,213,34,50,30,91,71,28,186,82,201,76,149,69,206,89,150,151,146,94,137,96,53,74,201,138,76,199,73,174,210,170,144,124,100,254,73,124,218,181,61,88,28,99,12,242,122,56,206,183,125,160,198,4,200,129,98,92,183,222,131,105,48,225,102,107,168,27,84,244,239,237,6,9,242,214,180,148,13,206,77,139,119,96,41,86,208,233,2,68,36,13,141,11,172,6,181,159,125,239,45,58,103,186,245,107,230,154,77,187,62,101,147,0,30,127,247,118,248,224,49,48,239,192,175,6,137,27,178,181,27,92,190,95,46,45,46,193,155,167,83,19,95,113,59,240,46,171,31,93,80,212,165,7,104,54,120,18,243,101,38,83,232,253,152,208,24,158,8,214,44,87,23,231,122,172,216,107,233,38,4,246,7,242,133,154,103,115,72,10,2,159,2,48,170,28,142,139,232,203,141,187,253,182,70,123,47,87,216,194,88,181,199,107,66,127,3,142,250,147,231,34,197,68,171,74,51,149,168,140,101,82,196,12,4,164,44,69,4,17,99,93,11,94,238,30,71,31,198,245,13,108,31,142,225,166,224,240,221,190,102,225,67,144,80,165,40,57,8,198,101,92,176,12,243,146,213,66,215,76,163,230,60,151,113,174,179,138,90,28,158,208,137,110,105,36,52,183,61,90,216,55,129,159,159,209,23,195,29,242,183,93,231,199,172,142,245,11,118,6,47,135,41,225,101,38,84,82,32,203,85,93,134,81,169,88,45,19,197,48,230,154,87,82,136,180,214,100,134,22,60,148,248,190,219,88,185,95,40,55,110,246,63,109,236,127,216,195,191,89,173,179,195,125,201,176,190,149,49,124,51,147,182,139,118,63,1,187,245,87,161,63,6,0,0 })));
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

			public ReadDataUserTask2FlowElement(UserConnection userConnection, SendNotificationToCaseOwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("9755f7a3-15ff-4623-b0f7-6bd8b05d9682");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,203,110,219,48,16,252,21,67,231,48,208,155,146,111,69,234,22,185,52,65,19,228,82,231,176,34,151,14,81,189,64,82,105,93,195,255,222,165,100,187,78,225,34,110,47,45,80,157,196,193,236,112,246,197,77,32,106,176,246,3,52,24,204,131,123,52,6,108,167,220,229,59,93,59,52,239,77,55,244,193,69,96,209,104,168,245,55,148,19,190,144,218,189,5,7,20,178,89,254,80,88,6,243,229,105,141,101,112,177,12,180,195,198,18,135,66,56,72,20,89,137,172,204,11,201,82,46,83,86,228,0,76,149,170,148,97,138,113,154,69,19,243,87,226,87,93,211,131,193,233,142,81,94,141,191,247,235,222,83,35,2,196,72,209,182,107,119,96,226,77,216,69,11,85,141,146,206,206,12,72,144,51,186,161,108,240,94,55,120,11,134,238,242,58,157,135,136,164,160,182,158,85,163,114,139,175,189,65,107,117,215,190,102,174,30,154,246,152,77,2,120,56,238,236,132,163,71,207,188,5,247,52,74,92,147,173,237,232,242,205,106,101,112,5,78,63,31,155,248,140,235,145,119,94,253,40,64,82,151,30,160,30,240,232,206,151,153,92,65,239,166,132,166,235,137,96,244,234,233,236,92,15,21,123,45,221,152,192,126,79,62,83,243,100,14,113,78,224,179,7,38,149,253,239,50,248,116,109,111,190,180,104,238,196,19,54,48,85,237,241,146,208,159,128,69,141,13,182,110,190,17,97,156,131,226,25,11,99,42,97,170,42,100,80,148,37,139,42,30,37,5,96,165,210,114,75,1,7,67,62,68,81,189,195,130,113,62,134,36,25,171,202,138,142,37,42,153,162,16,113,146,248,144,69,235,180,91,79,147,48,223,0,143,64,2,2,75,210,156,162,36,34,171,170,84,49,193,33,75,178,52,11,65,242,237,227,148,174,182,125,13,235,135,67,86,31,17,228,76,128,197,153,175,4,173,149,177,110,230,151,105,214,169,25,213,120,168,157,110,87,51,26,165,26,133,239,229,229,157,3,55,216,81,205,183,148,52,162,56,207,170,40,146,44,47,43,63,48,89,194,138,72,84,172,168,68,130,0,145,140,68,76,163,231,63,63,33,221,74,11,168,111,122,52,176,27,142,240,244,238,188,88,58,223,23,211,117,110,170,246,161,175,87,100,253,200,209,126,134,21,207,121,148,166,84,113,197,5,75,69,6,100,137,199,76,38,25,64,156,39,33,7,154,225,45,61,63,62,237,187,110,48,98,183,238,118,122,119,254,232,61,249,11,175,196,239,44,254,201,213,59,103,149,254,179,37,249,199,198,122,27,108,191,3,210,30,43,144,74,7,0,0 })));
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
								new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"));
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

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, SendNotificationToCaseOwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("ff731486-2289-44bf-807c-51e954d04ed7");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Status = () => (Guid)(new Guid("f063ebbe-fdc6-4982-8431-d8cfa52fedcf"));
				_recordColumnValues_Owner = () => (Guid)(Guid.Empty);
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Status", () => _recordColumnValues_Status.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Owner", () => _recordColumnValues_Owner.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Status;
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,203,110,219,48,16,252,21,67,231,48,144,68,234,65,223,138,212,45,114,105,130,38,200,165,206,97,69,174,28,162,122,129,164,211,186,134,255,189,75,201,113,147,194,69,220,94,90,160,190,88,28,204,44,103,95,220,70,170,1,231,62,64,139,209,60,186,69,107,193,245,181,63,127,103,26,143,246,189,237,215,67,116,22,57,180,6,26,243,13,245,132,47,180,241,111,193,3,73,182,203,31,17,150,209,124,121,60,198,50,58,91,70,198,99,235,136,19,36,105,38,53,207,4,211,50,85,76,84,21,103,37,170,156,197,144,40,157,197,192,115,13,123,230,47,130,95,244,237,0,22,167,59,198,240,245,248,121,187,25,2,53,33,64,141,20,227,250,110,15,242,96,194,45,58,168,26,212,116,246,118,141,4,121,107,90,202,6,111,77,139,215,96,233,174,16,167,15,16,145,106,104,92,96,53,88,251,197,215,193,162,115,166,239,94,51,215,172,219,238,57,155,2,224,225,184,183,19,143,30,3,243,26,252,195,24,226,146,108,237,70,151,111,86,43,139,43,240,230,241,185,137,207,184,25,121,167,213,143,4,154,186,116,7,205,26,159,221,249,50,147,11,24,252,148,208,116,61,17,172,89,61,156,156,235,161,98,175,165,155,18,56,60,145,79,140,121,52,135,52,39,240,49,0,83,148,167,207,101,244,233,210,93,125,233,208,222,168,7,108,97,170,218,253,57,161,63,1,139,6,91,236,252,124,171,226,52,135,186,200,88,156,106,193,68,93,33,131,82,74,150,84,69,194,75,192,170,22,114,71,130,131,161,32,169,69,161,227,146,21,197,40,225,25,171,100,69,71,137,181,22,168,84,202,121,144,44,58,111,252,102,154,132,249,22,48,70,145,41,96,74,200,140,84,88,48,224,82,51,14,85,145,22,37,38,121,82,236,238,167,116,141,27,26,216,220,29,178,250,136,160,103,10,28,206,66,37,104,173,172,243,179,176,76,179,190,158,81,141,215,141,55,221,106,70,163,212,160,10,189,60,223,247,49,252,145,62,75,177,200,185,72,152,174,184,164,97,81,9,131,84,150,76,39,165,2,1,18,138,92,209,216,133,95,152,142,126,101,20,52,87,3,90,216,15,70,124,124,111,94,44,92,232,137,237,123,63,85,250,208,211,11,178,61,122,57,76,110,13,121,174,179,148,145,43,205,68,89,39,172,82,133,96,82,96,165,57,87,50,139,57,153,161,71,39,36,123,211,175,173,218,47,185,155,94,155,63,122,69,254,194,219,240,59,235,126,116,225,78,89,160,255,108,53,254,153,129,222,69,187,239,24,243,34,169,58,7,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,83,77,79,27,49,16,253,43,200,112,140,87,246,250,59,87,168,42,164,80,69,64,185,16,14,99,123,92,162,110,178,209,126,84,162,81,254,123,157,37,1,130,10,173,212,94,42,213,7,175,236,157,247,102,60,239,205,154,156,116,15,43,36,99,114,141,77,3,109,157,186,226,180,110,176,152,54,117,192,182,45,38,117,128,106,254,29,124,133,83,104,96,129,29,54,55,80,245,216,78,230,109,55,58,58,132,145,17,57,249,54,252,37,227,219,53,57,239,112,241,249,60,102,246,210,186,82,66,82,212,178,82,83,25,189,160,32,101,162,82,249,160,140,244,81,160,207,224,80,87,253,98,121,129,29,76,161,187,39,227,53,25,216,50,1,24,14,17,16,168,144,90,102,2,68,234,125,38,8,6,148,80,82,49,136,134,108,70,164,13,247,184,128,33,233,51,152,115,19,69,153,28,181,165,81,57,167,144,212,74,206,41,15,90,115,174,2,186,16,183,224,93,252,51,240,246,120,82,215,95,251,85,225,92,18,138,113,65,181,55,64,165,137,154,122,41,25,69,145,56,48,15,206,241,80,36,166,243,51,60,210,20,67,126,164,179,101,78,35,56,141,54,36,80,101,194,24,210,241,221,54,81,156,183,171,10,30,110,222,204,119,10,45,30,181,29,116,125,91,92,98,189,194,37,198,71,232,234,64,133,151,224,245,236,81,204,25,25,207,222,146,115,247,189,26,186,116,40,232,107,45,103,100,52,35,87,117,223,132,45,163,200,135,179,23,85,15,73,134,144,87,199,189,120,249,102,217,87,213,238,230,12,58,216,7,238,175,235,56,79,115,140,231,203,171,189,102,3,11,219,45,250,147,109,191,30,107,251,19,216,5,44,225,11,54,159,114,3,158,107,127,170,242,58,183,113,79,236,75,167,152,225,137,26,4,71,37,234,172,106,228,64,29,119,62,9,147,125,149,202,1,125,137,9,27,92,6,60,44,236,119,172,179,195,183,67,183,183,83,179,171,107,219,170,13,217,108,70,47,103,137,25,103,19,147,150,26,145,68,118,115,8,20,44,104,170,149,21,40,140,54,202,198,119,103,201,48,93,178,152,123,131,50,15,148,204,175,161,46,91,54,83,153,50,133,104,163,228,254,239,207,210,199,126,30,139,15,139,85,247,240,222,4,28,70,253,55,251,63,102,118,174,61,10,173,56,181,9,75,42,185,202,62,137,145,101,131,50,17,165,182,34,70,241,43,179,223,109,126,0,81,130,55,189,150,6,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "53d09a3b5a4248cdbd0cf36c9a389625",
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

		#region Class: ChangeDataUserTask2FlowElement

		/// <exclude/>
		public class ChangeDataUserTask2FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask2FlowElement(UserConnection userConnection, SendNotificationToCaseOwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("db5fa60f-1727-44d8-8ec6-131c3f7eeb75");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Status = () => (Guid)(new Guid("f063ebbe-fdc6-4982-8431-d8cfa52fedcf"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Status", () => _recordColumnValues_Status.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Status;

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

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,77,143,211,48,16,253,43,85,206,235,42,159,77,210,27,42,5,237,133,93,177,213,94,200,30,38,206,56,181,112,62,100,187,11,165,234,127,103,156,180,165,139,138,182,32,33,14,228,100,63,189,153,121,51,158,151,157,199,21,24,243,1,26,244,230,222,10,181,6,211,9,59,125,39,149,69,253,94,119,155,222,187,241,12,106,9,74,126,195,106,196,151,149,180,111,193,2,133,236,138,31,25,10,111,94,92,206,81,120,55,133,39,45,54,134,56,20,146,8,168,252,32,207,88,128,60,100,49,159,9,150,139,40,100,25,175,194,68,36,65,24,165,254,200,252,85,242,69,215,244,160,113,172,49,164,23,195,113,181,237,29,53,32,128,15,20,105,186,246,0,70,78,132,89,182,80,42,172,232,110,245,6,9,178,90,54,212,13,174,100,131,247,160,169,150,203,211,57,136,72,2,148,113,44,133,194,46,191,246,26,141,145,93,251,154,56,181,105,218,115,54,37,192,211,245,32,199,31,52,58,230,61,216,245,144,226,150,100,237,7,149,111,234,90,99,13,86,62,159,139,248,140,219,129,119,221,252,40,160,162,87,122,4,181,193,179,154,47,59,89,64,111,199,134,198,242,68,208,178,94,95,221,235,105,98,175,181,27,18,216,31,201,87,230,188,216,67,56,35,240,217,1,99,150,227,177,240,62,221,154,187,47,45,234,7,190,198,6,198,169,61,77,9,253,9,88,42,108,176,181,243,29,247,195,25,136,52,97,126,88,197,44,22,37,50,200,242,156,5,101,26,68,25,96,41,226,124,79,1,39,65,46,68,196,105,229,103,44,77,135,144,40,97,101,94,210,53,71,81,197,200,121,24,69,46,100,217,90,105,183,227,38,204,119,128,62,198,9,7,198,227,60,161,40,76,25,68,121,197,34,40,211,48,205,48,152,5,233,254,105,108,87,154,94,193,246,241,212,213,71,132,106,194,193,224,196,77,130,108,165,141,157,56,51,77,58,49,161,25,111,148,149,109,61,161,85,82,200,221,91,78,135,53,114,159,123,237,174,150,28,212,93,143,26,14,15,237,95,246,193,11,3,185,25,235,174,179,227,228,78,111,180,32,25,131,202,227,38,82,33,250,65,56,97,15,221,70,243,131,33,205,248,103,248,35,199,255,3,31,255,142,53,47,154,227,154,101,255,159,214,248,111,46,223,222,219,127,7,180,254,100,80,182,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,193,110,219,48,12,253,149,66,237,49,52,44,75,182,162,92,219,75,128,116,8,154,174,151,166,7,74,162,214,96,142,29,88,246,128,46,200,191,79,113,236,166,41,86,96,192,116,144,33,154,239,241,137,143,218,179,155,246,109,71,108,198,30,169,105,48,212,190,77,110,235,134,146,101,83,91,10,33,89,212,22,203,205,111,52,37,45,177,193,45,181,212,60,97,217,81,88,108,66,59,185,186,132,177,9,187,249,213,255,101,179,231,61,155,183,180,253,62,119,145,221,25,229,165,76,29,100,62,227,32,133,77,97,42,184,7,173,20,183,153,201,76,225,242,8,182,117,217,109,171,123,106,113,137,237,43,155,237,89,207,22,9,80,113,116,72,8,66,22,18,164,35,2,99,164,7,171,48,23,185,204,83,116,138,29,38,44,216,87,218,98,95,244,12,230,92,57,145,121,13,211,76,229,32,115,33,97,42,57,7,110,139,130,243,220,146,182,238,8,30,242,207,192,231,235,69,93,255,236,118,137,214,94,228,41,23,80,24,133,32,149,43,192,196,251,0,9,207,49,53,168,53,183,137,79,11,65,198,16,120,103,11,144,122,154,197,50,130,131,155,90,143,121,230,201,89,127,253,114,44,228,54,97,87,226,219,211,151,245,110,49,208,85,104,177,237,66,242,64,245,142,42,114,39,232,238,194,133,143,224,253,250,100,230,154,205,214,95,217,57,124,87,125,151,46,13,253,236,229,154,77,214,108,85,119,141,61,50,138,120,184,251,160,186,47,210,167,124,58,142,230,197,72,213,149,229,16,185,195,22,199,196,49,92,187,141,223,144,155,87,171,209,179,158,37,29,22,252,101,27,215,73,219,255,192,238,177,194,31,212,124,139,13,56,107,127,87,249,24,219,56,18,155,76,231,169,138,179,170,8,53,72,42,162,171,142,35,104,174,141,23,42,206,149,207,122,244,3,121,106,168,178,116,41,236,95,70,103,192,135,190,219,199,87,51,232,58,182,234,192,14,135,151,195,31,36,81,154,26,169,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "53d09a3b5a4248cdbd0cf36c9a389625",
							"BaseElements.ChangeDataUserTask2.Parameters.RecordColumnValues.Value");
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

		public SendNotificationToCaseOwner(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendNotificationToCaseOwner";
			SchemaUId = new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_assigneeIsCleared = () => { return (bool)(false); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("53d09a3b-5a42-48cd-bd0c-f36c9a389625");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SendNotificationToCaseOwner, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SendNotificationToCaseOwner, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid ActivityId {
			get;
			set;
		}

		public virtual Guid CaseOwnerId {
			get;
			set;
		}

		public virtual Guid CaseId {
			get;
			set;
		}

		private LocalizableString _subjectCaption;
		public virtual LocalizableString SubjectCaption {
			get {
				return _subjectCaption ?? (_subjectCaption = GetLocalizableString("53d09a3b5a4248cdbd0cf36c9a389625",
						 "Parameters.SubjectCaption.Value"));
			}
			set {
				_subjectCaption = value;
			}
		}

		private Func<bool> _assigneeIsCleared;
		public virtual bool AssigneeIsCleared {
			get {
				return (_assigneeIsCleared ?? (_assigneeIsCleared = () => false)).Invoke();
			}
			set {
				_assigneeIsCleared = () => { return value; };
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
					SchemaElementUId = new Guid("0f86f691-728b-4367-98e9-372c14b8eb83"),
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
					SchemaElementUId = new Guid("f0ec85e6-466f-4c94-a9e7-34f9f0f6a0f2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
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

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("d7cc27a6-e003-48dc-a893-2c2b634e3685"),
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

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _createNotificationScriptTask;
		public ProcessScriptTask CreateNotificationScriptTask {
			get {
				return _createNotificationScriptTask ?? (_createNotificationScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateNotificationScriptTask",
					SchemaElementUId = new Guid("2fbbc7ef-f73b-4ac7-8e1a-1d9b4ccd5702"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CreateNotificationScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _setActivityServiceProcessed;
		public ProcessScriptTask SetActivityServiceProcessed {
			get {
				return _setActivityServiceProcessed ?? (_setActivityServiceProcessed = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetActivityServiceProcessed",
					SchemaElementUId = new Guid("c7612672-4aa0-4784-991c-5276cb1e1131"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SetActivityServiceProcessedExecute,
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
					SchemaElementUId = new Guid("7e40039d-bc2e-48e6-98a8-825e345002f1"),
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

		private ChangeDataUserTask2FlowElement _changeDataUserTask2;
		public ChangeDataUserTask2FlowElement ChangeDataUserTask2 {
			get {
				return _changeDataUserTask2 ?? (_changeDataUserTask2 = new ChangeDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("18b93021-759a-4d94-84cd-74f76d9acc7d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3;
		public ProcessExclusiveGateway ExclusiveGateway3 {
			get {
				return _exclusiveGateway3 ?? (_exclusiveGateway3 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3",
					SchemaElementUId = new Guid("3534cd8c-fb72-4ff0-b6a9-ddc3708c723c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway3.Question"),
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
					SchemaElementUId = new Guid("164028a5-0e9f-43b5-b440-9f409420a265"),
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
					SchemaElementUId = new Guid("e5b968fe-a1e2-4553-9f9e-2365429b0f48"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow3;
		public ProcessConditionalFlow ConditionalSequenceFlow3 {
			get {
				return _conditionalSequenceFlow3 ?? (_conditionalSequenceFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow3",
					SchemaElementUId = new Guid("1e21d9c0-b54f-47a0-8af2-5c4ae0fa2720"),
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
			FlowElements[ReadCaseData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadCaseData };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[CreateNotificationScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateNotificationScriptTask };
			FlowElements[SetActivityServiceProcessed.SchemaElementUId] = new Collection<ProcessFlowElement> { SetActivityServiceProcessed };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ChangeDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask2 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadCaseData", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ReadCaseData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CreateNotificationScriptTask", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway3", e.Context.SenderName));
						break;
					case "CreateNotificationScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "SetActivityServiceProcessed":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (ConditionalSequenceFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask2", e.Context.SenderName));
						break;
					case "ChangeDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway3", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "ExclusiveGateway3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SetActivityServiceProcessed", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("IsPaused").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>("IsPaused") : false)) || ((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("IsResolved").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>("IsResolved") : false))) &&  (((ReadCaseData.ResultEntity.IsColumnValueLoaded(ReadCaseData.ResultEntity.Schema.Columns.GetByName("Status").ColumnValueName) ? ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("StatusId") : Guid.Empty)) != new Guid("f063ebbe-fdc6-4982-8431-d8cfa52fedcf")));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask2", "ConditionalSequenceFlow1", "(((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName(\"IsPaused\").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>(\"IsPaused\") : false)) || ((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName(\"IsResolved\").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>(\"IsResolved\") : false))) &&  (((ReadCaseData.ResultEntity.IsColumnValueLoaded(ReadCaseData.ResultEntity.Schema.Columns.GetByName(\"Status\").ColumnValueName) ? ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>(\"StatusId\") : Guid.Empty)) != new Guid(\"f063ebbe-fdc6-4982-8431-d8cfa52fedcf\"))", result);
			return result;
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((((ReadCaseData.ResultEntity.IsColumnValueLoaded(ReadCaseData.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)) == Guid.Empty) || ((AssigneeIsCleared)==true));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow2", "(((ReadCaseData.ResultEntity.IsColumnValueLoaded(ReadCaseData.ResultEntity.Schema.Columns.GetByName(\"Owner\").ColumnValueName) ? ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>(\"OwnerId\") : Guid.Empty)) == Guid.Empty) || ((AssigneeIsCleared)==true)", result);
			return result;
		}

		private bool ConditionalSequenceFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean(((Boolean)SysSettings.GetValue(UserConnection, "ClearAssigneeOnCaseReopening"))==true);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "ConditionalSequenceFlow3", "((Boolean)SysSettings.GetValue(UserConnection, \"ClearAssigneeOnCaseReopening\"))==true", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("ActivityId")) {
				writer.WriteValue("ActivityId", ActivityId, Guid.Empty);
			}
			if (!HasMapping("CaseOwnerId")) {
				writer.WriteValue("CaseOwnerId", CaseOwnerId, Guid.Empty);
			}
			if (!HasMapping("CaseId")) {
				writer.WriteValue("CaseId", CaseId, Guid.Empty);
			}
			if (!HasMapping("AssigneeIsCleared")) {
				writer.WriteValue("AssigneeIsCleared", AssigneeIsCleared, false);
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
			MetaPathParameterValues.Add("917716bf-4d97-4095-a230-624af4a6b429", () => ActivityId);
			MetaPathParameterValues.Add("dbd4dbea-e2f6-43a8-9366-14aac293091e", () => CaseOwnerId);
			MetaPathParameterValues.Add("63e2fd8f-d2d4-4c91-a9a3-3eea91ebb907", () => CaseId);
			MetaPathParameterValues.Add("709f0792-1296-4595-93ee-af64360d8192", () => SubjectCaption);
			MetaPathParameterValues.Add("9857231e-99d6-4e24-98f0-e976db21dd58", () => AssigneeIsCleared);
			MetaPathParameterValues.Add("4506bd0f-7d6f-4191-9565-845a21c0d11d", () => ReadCaseData.DataSourceFilters);
			MetaPathParameterValues.Add("125091b9-9929-4b16-b593-00f43685f38f", () => ReadCaseData.ResultType);
			MetaPathParameterValues.Add("5abb2c3a-53c2-45f9-a792-dc0d56899ec5", () => ReadCaseData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("69ff34a2-2575-4283-8a79-1849034587f1", () => ReadCaseData.NumberOfRecords);
			MetaPathParameterValues.Add("6bda2483-0b9a-4e13-83aa-ef65d8e5fc29", () => ReadCaseData.FunctionType);
			MetaPathParameterValues.Add("d0a9c951-282e-4b35-b2b9-586d16c25933", () => ReadCaseData.AggregationColumnName);
			MetaPathParameterValues.Add("cd4e92d5-8ac6-4681-9893-10531933e9f7", () => ReadCaseData.OrderInfo);
			MetaPathParameterValues.Add("c0f47d08-77d4-4f35-b9b8-79efd4ecc233", () => ReadCaseData.ResultEntity);
			MetaPathParameterValues.Add("e3648d82-88fe-4d08-83f0-38a192059287", () => ReadCaseData.ResultCount);
			MetaPathParameterValues.Add("51a965b5-b922-460b-8ded-70db0b0b9559", () => ReadCaseData.ResultIntegerFunction);
			MetaPathParameterValues.Add("1a36246f-ef97-4371-8e3c-6e2fdff4875d", () => ReadCaseData.ResultFloatFunction);
			MetaPathParameterValues.Add("e6df8d5b-cab3-4471-b93f-f16dbda2f9a4", () => ReadCaseData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("23e88460-2b78-42f3-bb7d-bc523ec78b23", () => ReadCaseData.ResultRowsCount);
			MetaPathParameterValues.Add("efcb90d5-185b-45d2-b46e-ebdd4f4422c5", () => ReadCaseData.CanReadUncommitedData);
			MetaPathParameterValues.Add("78164945-a544-4c0f-a423-9e6fcc580552", () => ReadCaseData.ResultEntityCollection);
			MetaPathParameterValues.Add("3c50e486-1699-49e5-a51a-1bc6cd510ae5", () => ReadCaseData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("876cd4a1-2b3c-48b1-85e5-ea04e0312504", () => ReadCaseData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("a62dc61c-733d-49ca-a1e9-773df8ed0bc6", () => ReadCaseData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("b35bf595-fe8e-4d6a-866b-bb4dbc6e25d9", () => ReadCaseData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("78d57c59-616c-456c-ac2c-9cd77bdbd677", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("86e26d5e-484f-41f0-bbab-fc34eeb9aa75", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("e78616d2-d5e4-45ff-b596-cd4077bd95f6", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("15712166-8aff-40a6-aa13-01c7f3e35c6d", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("4f55e2a6-ba23-43c6-830c-0c37149c2dfa", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("22a51850-96e2-4f1b-921c-2e8ae641277c", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("bbcdf8e1-e64e-4131-8c66-a7875bc9aa86", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("7f3b2864-d5d3-405d-b781-90d93ae8c182", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("3fdbb8ea-a109-436f-9526-5f4981e720df", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("9b717c7a-0916-4442-a7e2-1eb5d8444932", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("f94eb8f0-f6d7-4e39-bcac-5f524d486d10", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("0a8a652e-132a-4a06-ba66-aaf55eb0d4ee", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("02e560cd-10d7-4e56-bd33-2638021393b9", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("b6a76e86-7bda-4867-9d85-33825ffc996a", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("9e70bb31-84bd-4894-9154-dc72555d80ee", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("ae4b4580-882a-42d6-858b-fc7f1a5ad5ae", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("41083d4f-db04-4676-8683-a5a2eb046ccf", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("09e221cf-ac9c-411c-a00e-e3ea288e8aa1", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("e6419337-a5aa-4730-a472-2788ba1d6154", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("4de1092c-2886-4a3a-b044-6a900b08bad6", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("0ba9435d-0627-444d-8a1f-ad7297863488", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("179d913f-3405-40bc-89fb-a1def3ab9a09", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("a90561e6-7bbd-4a0f-96af-b770af8d44eb", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("a241d043-f9e0-415b-88e4-72152150dcb4", () => ChangeDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("dc0d8500-2c5d-44ee-8b80-5d1ee9e419af", () => ChangeDataUserTask2.EntitySchemaUId);
			MetaPathParameterValues.Add("582913d8-566d-458d-b331-4604de9e8c23", () => ChangeDataUserTask2.IsMatchConditions);
			MetaPathParameterValues.Add("db752332-2f10-401f-9ce4-5238cd69c2e9", () => ChangeDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("bc1fbcca-fa65-4c95-9a77-ce97f378b282", () => ChangeDataUserTask2.RecordColumnValues);
			MetaPathParameterValues.Add("f9301d60-5593-4dda-8ec5-b940b63c89d7", () => ChangeDataUserTask2.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "ActivityId":
					if (!hasValueToRead) break;
					ActivityId = reader.GetValue<System.Guid>();
				break;
				case "CaseOwnerId":
					if (!hasValueToRead) break;
					CaseOwnerId = reader.GetValue<System.Guid>();
				break;
				case "CaseId":
					if (!hasValueToRead) break;
					CaseId = reader.GetValue<System.Guid>();
				break;
				case "AssigneeIsCleared":
					if (!hasValueToRead) break;
					AssigneeIsCleared = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool CreateNotificationScriptTaskExecute(ProcessExecutingContext context) {
			Entity remindingEntity = UserConnection.EntitySchemaManager.GetInstanceByName("Reminding")
				.CreateEntity(UserConnection);
			var caseId = ReadCaseData.ResultEntity.PrimaryColumnValue; 
			var ownerId = ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("OwnerId");
			var number = ReadCaseData.ResultEntity.GetTypedColumnValue<string>("Number");
			var condition = new Dictionary<string, object> {
				{
					"Author", UserConnection.CurrentUser.ContactId
				}, {
					"Contact", ownerId
				}, {
					"Source", TConfiguration.RemindingConsts.RemindingSourceAuthorId
				}, {
					"Number", number
				}, {
					"ActivityId", ActivityId
				}
			};
			var str = new StringBuilder();
			foreach (object value in condition.Values) {
				str.Append(value);
			}
			var hash = FileUtilities.GetMD5Hash(Encoding.Unicode.GetBytes(str.ToString()));
			remindingEntity.SetDefColumnValues();
			remindingEntity.SetColumnValue("AuthorId", UserConnection.CurrentUser.ContactId);
			remindingEntity.SetColumnValue("ContactId", ownerId);
			remindingEntity.SetColumnValue("SourceId", TConfiguration.RemindingConsts.RemindingSourceAuthorId);
			remindingEntity.SetColumnValue("RemindTime", UserConnection.CurrentUser.GetCurrentDateTime());
			var subjectCaption = string.Format(!string.IsNullOrEmpty(SubjectCaption.ToString())
					? SubjectCaption.ToString() 
					: "New email received regarding the case No.{0}", 
					number
				); 
			remindingEntity.SetColumnValue("SubjectCaption", subjectCaption);
			var caseSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Case");
			remindingEntity.SetColumnValue("SysEntitySchemaId", caseSchema.UId);
			remindingEntity.SetColumnValue("SubjectId", caseId);
			remindingEntity.SetColumnValue("Hash", hash);
			remindingEntity.Save();
			return true;
		}

		public virtual bool SetActivityServiceProcessedExecute(ProcessExecutingContext context) {
			var activityUpdate = new Update(UserConnection, "Activity")
				.Set("ServiceProcessed", Column.Parameter(false))
				.Where("Id").IsEqual(Column.Parameter(ActivityId)) as Update;
			activityUpdate.Execute();
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localAssigneeIsCleared = true;
			AssigneeIsCleared = (System.Boolean)localAssigneeIsCleared;
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
			var cloneItem = (SendNotificationToCaseOwner)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


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
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: AnalyzeCaseSatisfactionLevelSchema

	/// <exclude/>
	public class AnalyzeCaseSatisfactionLevelSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public AnalyzeCaseSatisfactionLevelSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public AnalyzeCaseSatisfactionLevelSchema(AnalyzeCaseSatisfactionLevelSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AnalyzeCaseSatisfactionLevel";
			UId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"en-US";
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
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7c806e5d-f304-455d-b2e4-9ed5a8c88f0c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"CaseRecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseRecordIdParameter());
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("643fc2b1-37e6-4c13-b874-541f74be69c6"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,83,203,110,219,48,16,252,149,64,231,48,208,131,146,37,223,10,215,45,114,105,130,198,200,165,202,97,69,173,100,162,146,40,144,84,90,215,240,191,119,41,217,142,83,184,136,219,75,47,213,137,26,12,103,103,150,187,91,79,52,96,204,39,104,209,155,123,43,212,26,140,170,236,205,7,217,88,212,31,181,26,122,239,218,51,168,37,52,242,7,150,19,190,44,165,125,15,22,232,202,54,127,81,200,189,121,126,94,35,247,174,115,79,90,108,13,113,232,74,26,37,101,86,241,144,249,65,150,48,158,196,21,131,25,15,152,192,178,76,179,168,202,66,62,155,152,191,19,95,168,182,7,141,83,141,81,190,26,143,171,77,239,168,1,1,98,164,72,163,186,61,24,57,19,102,217,65,209,96,73,255,86,15,72,144,213,178,165,52,184,146,45,222,131,166,90,78,71,57,136,72,21,52,198,177,26,172,236,242,123,175,209,24,169,186,183,204,53,67,219,157,178,73,0,143,191,123,59,254,232,209,49,239,193,174,71,137,91,178,181,27,93,190,171,107,141,53,88,249,124,106,226,43,110,70,222,101,253,163,11,37,189,210,35,52,3,158,212,124,157,100,1,189,157,2,77,229,137,160,101,189,190,56,235,177,99,111,197,13,9,236,15,228,11,53,207,102,8,19,2,159,29,48,169,28,142,185,247,229,214,220,125,235,80,63,136,53,182,48,117,237,233,134,208,95,128,163,254,124,59,19,169,159,96,92,178,42,242,57,227,49,157,138,16,57,203,176,140,33,21,105,90,249,98,247,52,249,144,166,111,96,243,120,44,183,0,131,87,159,81,40,93,94,141,47,231,62,215,96,85,75,1,205,93,143,26,246,189,245,207,143,222,171,153,117,177,180,82,118,50,123,108,139,171,50,214,63,60,190,192,106,22,101,65,192,32,77,67,198,35,30,179,34,138,67,22,70,69,202,57,197,73,131,130,204,208,222,186,206,61,168,65,139,253,158,152,105,97,255,106,17,255,193,122,253,201,198,156,157,217,75,102,240,255,116,161,27,150,221,79,90,144,37,197,10,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fb56437e-ba33-4a23-9d0c-ae27bb35a2a4"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("28d07f6e-0d89-4984-ae74-9e1d6c8a64b5"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c4dec099-47fa-4366-98a4-b699ffa357e6"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("72de3fe9-d5d9-40ab-85f1-88ea175b52be"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e86df7f-bd13-4bc4-9cc7-8b7f60824845"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("247ba482-7f2c-4dc6-94f2-7174de79afd0"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("a7ec7ea4-ce5b-4f68-85b1-5bcb0f131a52"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("608cedf5-b8e9-4b65-b2eb-f05daae2899e"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("d10c7fb3-28cc-4700-a5b8-66c91209a9f8"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("fdea50bf-6a67-4306-9bf6-a560509191ee"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("85ce2111-939c-4c61-a6fc-25f3d846bef3"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("c8ea1ef0-089c-4d1e-ad79-bb1881d2a81b"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("6400198a-fd0f-42e8-aff8-558ad741e1f3"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("b853c17a-5aa9-4f6a-b6f5-dc1d14e76e99"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cbfaa20f-5593-406d-b8d0-2a98e6a2c065"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55ff5bcf-9e1c-431e-be5e-7d02bf259e96"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("f57e2c13-063b-4f4f-a6c1-6242bef6ec8b"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("22be0081-4670-4d92-b56b-32844cd949e3"),
				ContainerUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
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
				UId = new Guid("3dc139f3-bcc4-413e-937a-9d613d137381"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,203,110,19,49,20,253,149,104,214,117,53,15,207,43,59,84,2,234,134,86,180,234,134,116,113,199,190,78,45,230,37,219,83,8,81,254,157,235,153,36,164,40,168,129,13,18,98,86,158,163,115,143,207,125,121,19,136,26,172,253,0,13,6,243,224,30,141,1,219,41,119,249,78,215,14,205,123,211,13,125,112,17,88,52,26,106,253,13,229,132,47,164,118,111,193,1,133,108,150,63,20,150,193,124,121,90,99,25,92,44,3,237,176,177,196,161,16,37,18,224,69,136,44,140,114,100,60,149,146,21,105,156,178,88,86,24,150,33,47,132,148,19,243,87,226,87,93,211,131,193,233,142,81,94,141,199,251,117,239,169,17,1,98,164,104,219,181,59,48,241,38,236,162,133,170,70,47,239,204,128,4,57,163,27,202,6,239,117,131,183,96,232,46,175,211,121,136,72,10,106,235,89,53,42,183,248,218,27,180,86,119,237,107,230,234,161,105,143,217,36,128,135,223,157,157,112,244,232,153,183,224,158,70,137,107,178,181,29,93,190,89,173,12,174,192,233,231,99,19,159,113,61,242,206,171,31,5,72,234,210,3,212,3,30,221,249,50,147,43,232,221,148,208,116,61,17,140,94,61,157,157,235,161,98,175,165,27,19,216,239,201,103,106,158,204,33,206,8,124,246,192,164,178,63,46,131,79,215,246,230,75,139,230,78,60,97,3,83,213,30,47,9,253,9,88,212,216,96,235,230,27,89,65,149,85,41,48,17,149,146,234,152,81,29,101,30,178,42,41,98,200,10,94,22,42,218,82,192,193,208,124,3,57,138,28,129,51,129,105,197,184,202,10,42,125,21,177,180,18,85,168,162,36,130,52,246,33,139,214,105,183,158,38,193,71,69,32,1,129,37,60,227,140,75,68,86,85,92,49,145,67,154,164,60,13,65,230,219,199,41,93,109,251,26,214,15,135,172,62,34,200,153,0,139,51,95,137,25,237,149,177,110,230,183,105,214,169,25,21,121,168,157,110,87,51,154,165,26,133,111,230,229,157,3,55,216,81,206,247,148,68,18,193,139,12,74,193,226,180,136,25,207,179,152,149,130,126,121,146,128,138,84,89,240,200,207,158,255,252,136,116,43,45,160,190,233,209,192,110,58,194,211,203,243,98,235,124,99,76,215,185,169,220,135,198,94,145,247,35,71,251,33,174,162,52,41,195,92,49,20,33,80,37,139,130,149,50,69,134,105,89,161,72,18,196,82,145,37,122,127,124,222,119,221,96,196,110,223,237,244,240,252,209,131,242,23,158,137,223,217,252,147,187,119,206,46,253,223,146,127,104,75,182,193,246,59,78,13,231,206,154,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0c6de25d-2707-4643-a8ad-911d475e594c"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2c01b2a0-4d16-41e0-a641-3d9a2f02561b"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c0073aa2-5633-49ad-b4a3-2e43b3e5669f"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("02c2428c-c555-47dc-9e99-df353f553049"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cbd3780c-de4a-4e33-8ee8-b9febddbf1a5"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bd37a5c6-0d37-4523-b75c-cf34a74888cb"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				UId = new Guid("7092f775-9a72-4aaf-b608-e2668011359f"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("352856bf-54d3-414b-a777-6ea0f684dd68"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("38097a14-57ca-4d1c-a9b6-b83821594568"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("891c23be-079e-4dcf-afa7-6c04ead53b72"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("ca27a4b0-7cce-4840-9bca-800f545dca25"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("101a3fe4-83d5-45b2-94de-c891f8aae0b1"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("9b75f53d-4836-4518-9ff9-ac4c9e368e0f"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("b0a000e3-e6fc-4cdd-b51c-12f6e2c080eb"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ae705119-6e00-4b54-afa3-f7214514ce18"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7b964786-d631-40c6-80bc-46e13902504e"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("7d8bb773-f3ac-4fff-96c4-90b07b7d612c"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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
				UId = new Guid("45354f6b-5f87-4f1c-b3ac-5d1e5c2529f6"),
				ContainerUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
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

		protected virtual void InitializeReadDataUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("42a0be64-dc23-4a7d-9fe3-953b6cefb20b"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,93,111,211,48,20,253,43,81,158,231,41,78,227,38,233,27,26,5,77,66,108,98,211,94,214,61,92,59,215,93,132,243,33,219,29,148,170,255,157,235,164,43,29,42,90,225,5,36,242,20,31,29,31,159,251,185,137,149,1,231,62,66,131,241,44,190,69,107,193,117,218,159,191,171,141,71,251,222,118,171,62,62,139,29,218,26,76,253,13,171,17,159,87,181,127,11,30,232,202,102,241,67,97,17,207,22,199,53,22,241,217,34,174,61,54,142,56,116,69,164,185,204,33,153,48,205,43,96,89,154,86,76,162,206,24,22,25,168,9,207,85,94,164,35,243,87,226,23,93,211,131,197,241,141,65,94,15,191,183,235,62,80,57,1,106,160,212,174,107,119,224,36,152,112,243,22,164,193,138,206,222,174,144,32,111,235,134,162,193,219,186,193,107,176,244,86,208,233,2,68,36,13,198,5,150,65,237,231,95,123,139,206,213,93,251,154,57,179,106,218,67,54,9,224,254,184,179,147,12,30,3,243,26,252,227,32,113,73,182,182,131,203,55,203,165,197,37,248,250,233,208,196,103,92,15,188,211,242,71,23,42,170,210,29,152,21,30,188,249,50,146,11,232,253,24,208,248,60,17,108,189,124,60,57,214,125,198,94,11,55,37,176,127,38,159,168,121,52,134,116,74,224,83,0,70,149,231,223,69,124,127,233,174,190,180,104,111,212,35,54,48,102,237,225,156,208,159,128,185,193,6,91,63,219,84,18,228,84,10,96,138,151,21,203,196,180,98,69,149,39,76,78,138,20,166,69,86,22,154,111,233,194,222,208,108,3,57,170,28,33,99,10,133,100,153,158,22,172,16,146,51,33,149,76,52,159,112,16,105,184,50,111,125,237,215,99,39,204,54,74,105,37,180,212,44,171,84,201,178,28,51,86,114,61,97,34,67,40,83,193,65,242,98,251,48,134,91,187,222,192,250,110,31,213,39,132,42,82,224,48,10,153,136,104,174,172,243,81,152,166,168,211,17,37,121,101,124,221,46,35,234,37,131,42,20,243,252,134,26,199,105,24,14,145,193,39,52,131,116,168,47,9,86,121,137,2,196,132,21,80,82,247,0,47,41,106,73,73,168,120,154,113,94,202,4,50,234,195,240,133,118,233,150,181,2,115,213,163,133,93,167,36,199,7,233,197,4,134,34,217,174,243,99,234,247,69,62,116,246,97,111,236,185,175,185,208,121,50,45,21,163,144,41,185,144,8,86,74,20,67,95,99,34,32,75,74,78,206,104,37,133,84,220,116,43,171,118,43,192,141,187,232,143,118,204,95,216,28,191,179,12,142,142,227,41,227,245,159,13,206,191,217,221,219,120,251,29,12,208,201,151,101,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6167808-425a-4541-a89f-19118a685830"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("df97a40d-caba-46d0-ae3b-3ab77b3aa563"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b70e85c0-915b-4104-b121-b468de8a4637"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("223eb29e-364a-44cc-becc-69e01425be9c"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("656b1ea1-bac6-4518-8006-2d3d95f56bed"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ec808db1-3f0a-4038-a26b-446f2935c069"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("82b9bea0-0053-40fc-8232-85f47d8d17da"),
				UId = new Guid("f5fc4e93-92c3-47f2-a1dc-a5ba89846ff7"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("92813432-e952-427c-b775-57f77d398b6d"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("2ef81675-328b-4e33-8a16-6a0df1006683"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("2f91fd7b-c25b-45ae-ac98-c772e1c88493"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("3a06c5c6-afac-4bd1-9115-551805b1f7bb"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("af6a486a-47e5-47a2-85fe-6687125e74bd"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("32bf5acf-9862-459e-a98e-55e6f938cfb2"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ReferenceSchemaUId = new Guid("82b9bea0-0053-40fc-8232-85f47d8d17da"),
				UId = new Guid("fc23f180-56cd-4e39-a2cf-d3dad81c0dd1"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("be278a15-6327-41b0-a4a8-6c2d57c5a3cc"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9105f6d4-f8a4-4fc1-b550-632a6cf66f9a"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("4da5aef6-f601-4b3f-86e6-5544484a2c6d"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("0e5da894-beb3-4105-b6f7-9e80be0477d0"),
				ContainerUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
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
				UId = new Guid("9368f221-436d-4df7-8b76-c98cf6d025a9"),
				ContainerUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("65d9b230-45b3-4daa-bb41-9096e6b07169"),
				ContainerUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a461b0ff-7cf6-4abc-aab6-8c25d8833b2b"),
				ContainerUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,203,110,219,48,16,252,149,64,231,48,144,101,61,125,43,92,183,200,165,9,26,35,151,42,135,21,185,148,137,82,162,64,82,105,93,195,255,94,82,178,85,167,112,17,183,64,209,234,68,13,134,51,179,203,221,93,64,37,24,243,1,26,12,22,193,26,181,6,163,184,189,121,39,164,69,253,94,171,190,11,174,3,131,90,128,20,223,144,141,248,138,9,251,22,44,184,43,187,242,135,66,25,44,202,243,26,101,112,93,6,194,98,99,28,199,93,201,162,104,22,21,69,68,104,50,103,36,158,49,70,170,34,201,72,72,33,206,211,52,195,138,86,35,243,87,226,75,213,116,160,113,244,24,228,249,112,92,111,59,79,157,57,128,14,20,97,84,123,0,231,62,132,89,181,80,73,100,238,223,234,30,29,100,181,104,92,53,184,22,13,222,131,118,94,94,71,121,200,145,56,72,227,89,18,185,93,125,237,52,26,35,84,251,90,56,217,55,237,41,219,9,224,244,123,136,19,14,25,61,243,30,236,102,144,184,117,177,246,67,202,55,117,173,177,6,43,158,79,67,124,198,237,192,187,172,127,238,2,115,175,244,8,178,199,19,207,151,149,44,161,179,99,65,163,189,35,104,81,111,46,174,117,234,216,107,229,70,14,236,142,228,11,53,207,214,16,165,14,124,246,192,168,114,60,150,193,167,91,115,247,165,69,253,64,55,216,192,216,181,167,27,135,254,4,76,250,139,93,70,243,48,197,132,17,62,15,99,18,39,238,84,69,24,147,2,89,2,57,205,115,30,210,253,211,152,67,152,78,194,246,113,178,91,130,193,171,143,72,149,102,87,195,203,249,207,55,88,213,130,130,188,235,80,195,161,183,225,249,209,123,49,179,190,44,173,148,29,195,78,109,241,46,131,255,241,241,227,138,241,40,13,43,82,241,170,32,49,163,33,1,22,115,18,198,140,103,225,44,41,128,38,46,140,219,91,223,185,7,213,107,122,216,19,51,46,236,31,45,226,63,88,175,223,217,152,179,51,123,201,12,254,23,211,245,55,39,103,31,236,191,3,17,107,186,229,230,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3ef5ba64-31d5-408a-91cd-c4b705177d41"),
				ContainerUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,193,110,219,48,12,253,21,195,237,49,12,44,75,178,44,95,219,14,8,208,110,69,179,245,210,228,64,75,84,107,192,177,11,75,233,208,5,249,247,41,78,210,54,221,118,154,14,50,68,243,61,146,79,79,155,244,60,188,62,83,90,165,223,105,24,208,247,46,76,47,250,129,166,183,67,111,200,251,233,117,111,176,109,126,97,221,210,45,14,184,162,64,195,61,182,107,242,215,141,15,147,228,20,150,78,210,243,151,241,111,90,61,108,210,89,160,213,143,153,141,236,178,116,69,157,151,53,152,90,18,136,66,230,80,154,130,129,85,121,169,115,172,107,225,202,8,54,125,187,94,117,55,20,240,22,195,83,90,109,210,145,45,18,160,98,104,145,16,184,40,4,8,75,4,59,16,24,133,146,75,33,51,180,42,221,78,82,111,158,104,133,99,209,119,48,99,202,242,220,105,40,115,37,65,72,46,160,20,140,1,51,69,193,152,52,164,141,221,129,15,249,239,192,135,179,135,153,255,246,179,163,97,62,242,86,14,91,79,203,105,140,126,10,92,181,180,162,46,84,27,166,12,149,84,58,208,89,89,130,64,87,0,58,169,65,41,205,184,211,150,202,140,111,35,224,77,205,106,227,164,51,130,52,7,157,27,14,66,185,28,144,89,3,40,107,44,117,41,10,231,212,14,114,213,133,38,188,94,140,26,85,27,201,52,21,130,12,24,158,57,16,117,212,166,206,172,130,130,152,230,153,150,133,200,104,187,60,91,238,6,179,141,127,110,241,245,254,207,249,238,8,109,226,49,52,222,161,9,77,223,37,45,189,80,155,88,12,56,253,210,12,62,36,77,188,197,164,119,201,64,126,221,134,166,123,76,226,53,181,52,102,79,231,1,195,218,239,171,60,159,24,228,99,157,205,98,239,179,69,90,45,254,229,180,195,119,175,235,169,215,62,219,108,145,78,22,233,188,95,15,102,199,200,227,225,242,195,128,99,145,49,229,211,241,232,171,24,233,214,109,123,136,92,198,73,143,137,199,112,111,27,215,144,157,117,243,163,157,70,150,236,176,224,47,219,113,237,123,251,31,216,13,118,248,72,195,215,40,192,123,239,111,93,126,143,50,30,137,235,92,203,76,49,7,138,80,131,160,34,190,42,203,16,52,211,181,227,42,90,222,229,35,250,142,28,13,212,25,58,109,76,107,199,101,198,56,20,181,194,104,60,91,64,45,68,6,196,29,195,172,70,173,153,57,224,253,168,246,238,65,31,250,218,73,181,77,183,219,229,246,55,20,247,87,35,68,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7c487732-e1d0-41c7-a366-6994979c4154"),
				ContainerUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
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

		protected virtual void InitializeReadDataUserTask4Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d51b136d-f674-45ae-991e-74dc6a36e5a5"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,77,111,211,64,16,253,43,150,207,117,228,141,191,115,67,33,160,94,104,69,163,94,112,15,227,245,216,89,177,254,208,238,186,16,162,252,119,102,237,36,164,40,168,1,9,113,192,39,251,233,205,204,155,143,231,157,203,37,104,253,1,26,116,23,238,26,149,2,221,85,102,246,78,72,131,234,189,234,134,222,189,113,53,42,1,82,124,195,114,194,87,165,48,111,193,0,133,236,242,31,25,114,119,145,95,206,145,187,55,185,43,12,54,154,56,20,18,101,217,60,101,5,243,144,65,236,133,177,207,60,136,51,244,210,50,42,89,18,68,28,146,100,98,254,42,249,178,107,122,80,56,213,24,211,87,227,235,122,219,91,42,35,128,143,20,161,187,246,0,6,86,132,94,181,80,72,44,233,219,168,1,9,50,74,52,212,13,174,69,131,247,160,168,150,205,211,89,136,72,21,72,109,89,18,43,179,250,218,43,212,90,116,237,107,226,228,208,180,231,108,74,128,167,207,131,28,127,212,104,153,247,96,54,99,138,91,146,181,31,85,190,169,107,133,53,24,241,124,46,226,51,110,71,222,117,243,163,128,146,182,244,8,114,192,179,154,47,59,89,66,111,166,134,166,242,68,80,162,222,92,221,235,105,98,175,181,59,39,176,63,146,175,204,121,177,135,121,76,224,179,5,166,44,199,215,220,253,116,171,239,190,180,168,30,248,6,27,152,166,246,52,35,244,39,96,37,177,193,214,44,118,101,1,69,92,68,224,113,150,149,94,24,197,37,141,48,241,189,34,72,231,16,167,97,150,86,108,79,1,39,65,139,29,36,200,19,132,208,227,24,21,94,88,197,169,151,70,180,137,168,224,133,95,177,128,65,52,183,33,171,214,8,179,157,46,129,162,208,199,144,214,226,241,48,139,40,10,19,15,2,42,25,64,145,204,147,20,89,204,146,253,211,212,174,208,189,132,237,227,169,171,143,8,165,195,65,163,99,39,225,144,175,148,54,142,117,147,211,85,14,13,121,144,70,180,181,67,183,36,145,219,101,206,198,59,178,143,93,119,87,11,14,242,174,71,5,135,77,251,151,141,240,194,65,118,200,170,235,204,52,186,211,146,150,164,99,148,121,60,69,42,68,127,8,171,236,161,27,20,63,56,82,79,191,134,63,178,252,63,48,242,239,120,243,162,59,174,185,246,255,233,142,255,230,241,237,221,253,119,249,242,79,43,183,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fe0fa648-3fc3-4ce1-a8d3-1681f04a67c9"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ae404d44-60d7-4e4b-8282-762b27d3a152"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("8763f1ba-63c6-4753-87a2-dbaeb9ea40d3"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("9eda2b32-157f-4e17-b87c-cc0782b8e875"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d2adb4a4-eb38-4950-aadd-fdeebf093883"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("6c320b14-8f29-402a-a272-3d4d451107ba"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,43,205,77,74,45,178,50,180,50,4,0,62,85,105,155,10,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("b3c152f3-8f5d-4ccd-a444-d697a2992b1a"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("919f3607-18a5-44b4-b8c5-a553b21c63f7"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("275b1604-78cd-4f80-ad1a-dbb6afbae187"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("58b416b7-18b4-43de-b90e-b775fc705598"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("18226361-e716-427e-8881-44a4fbfcbcbc"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("acdae03e-04e7-470b-acab-80f8b02cde3d"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("98406230-ae2f-4d18-934d-4512830c3860"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("4ed4d571-44c8-4a27-a65a-4131b67102cd"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("b38a94a0-f6e4-4feb-8786-12e8b069d09b"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a4fde4e6-b89d-4d7a-9c00-a5b453b8f484"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("c418c43f-8865-4baa-9f1a-2d3f8b70bbe9"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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
				UId = new Guid("32ec9b82-a1f1-4152-bbff-c3c4dccaa240"),
				ContainerUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
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

		protected virtual void InitializeChangeDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("838069b1-290a-4dfe-8a76-789d0b22ee56"),
				ContainerUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9aae8482-6a87-492c-a2eb-c2cc69f1a33a"),
				ContainerUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
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
				UId = new Guid("7f1e55bc-3c69-4e8d-ab13-4c60e7f1c2b5"),
				ContainerUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,65,110,219,48,16,252,74,192,115,20,40,150,100,203,190,21,174,91,228,210,4,141,145,75,149,195,154,90,201,68,41,81,32,169,180,174,225,191,119,73,218,170,83,184,136,27,32,104,13,31,168,193,112,102,118,185,187,101,92,130,49,159,160,65,54,99,75,212,26,140,170,236,213,7,33,45,234,143,90,245,29,187,100,6,181,0,41,126,96,25,240,69,41,236,123,176,64,87,182,197,47,133,130,205,138,211,26,5,187,44,152,176,216,24,226,208,149,20,178,24,174,121,21,77,227,21,68,105,50,225,209,52,201,203,8,199,73,50,78,50,250,79,166,129,249,39,241,185,106,58,208,24,60,188,124,229,143,203,77,231,168,215,4,112,79,17,70,181,123,48,113,33,204,162,133,149,196,146,190,173,238,145,32,171,69,67,213,224,82,52,120,7,154,188,156,142,114,16,145,42,144,198,177,36,86,118,241,189,211,104,140,80,237,75,225,100,223,180,199,108,18,192,225,115,31,39,246,25,29,243,14,236,218,75,220,80,172,157,79,249,174,174,53,214,96,197,211,113,136,175,184,241,188,243,250,71,23,74,122,165,7,144,61,30,121,62,175,100,14,157,13,5,5,123,34,104,81,175,207,174,117,232,216,75,229,142,8,236,14,228,51,53,79,214,48,26,19,248,228,128,160,114,56,22,236,203,141,185,253,214,162,190,231,107,108,32,116,237,241,138,208,223,128,65,127,182,157,240,60,30,99,86,70,85,18,167,81,154,209,105,53,194,52,154,98,153,65,206,243,188,138,249,238,49,228,16,166,147,176,121,24,236,230,96,240,226,51,114,165,203,11,255,114,238,231,26,172,106,193,65,222,118,168,97,223,219,248,244,232,61,155,89,87,150,86,202,134,176,67,91,156,139,247,63,60,62,25,209,78,186,174,220,171,94,243,253,14,152,176,140,175,90,178,127,176,58,127,179,13,39,231,241,156,249,250,47,38,231,45,167,98,199,118,63,1,56,110,94,215,194,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("75fd7f6c-28fc-4c7c-bf17-b30ef4fedf91"),
				ContainerUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,77,111,163,48,20,252,43,200,237,49,142,48,24,48,185,182,151,72,237,42,106,178,185,148,30,30,246,243,22,137,143,200,152,74,217,136,255,190,134,64,211,68,221,203,174,15,32,63,222,140,231,205,224,19,185,183,199,3,146,21,217,161,49,208,54,218,46,31,26,131,203,141,105,36,182,237,242,169,145,80,22,191,33,47,113,3,6,42,180,104,246,80,118,216,62,21,173,93,120,215,48,178,32,247,31,227,87,178,122,61,145,181,197,234,231,90,57,118,161,133,47,67,145,80,197,49,167,156,137,156,10,205,99,202,164,200,85,148,112,157,198,129,3,203,166,236,170,250,25,45,108,192,190,147,213,137,140,108,142,0,89,192,82,166,53,13,4,99,148,135,190,162,128,18,104,2,156,135,17,242,156,229,41,233,23,164,149,239,88,193,120,232,5,204,88,162,194,64,167,84,4,73,68,121,20,114,42,184,163,97,50,142,25,139,36,166,82,13,224,169,255,2,124,189,219,30,219,61,152,98,152,127,249,208,25,131,181,125,4,139,187,162,194,187,183,1,163,138,246,80,194,113,255,45,212,205,239,125,220,192,189,1,235,65,173,188,129,232,76,114,184,178,246,43,205,41,59,39,148,145,85,246,183,140,166,247,118,28,253,58,165,219,128,50,178,200,200,182,233,140,28,24,67,183,121,252,162,127,60,100,108,185,217,206,137,184,74,221,149,229,84,113,250,97,110,156,203,141,42,116,129,106,93,111,231,32,70,22,127,90,244,155,199,188,206,218,254,7,246,12,53,252,66,243,195,25,112,209,254,169,114,231,108,156,137,85,192,48,69,205,169,244,99,78,185,207,2,154,7,34,166,26,24,8,150,48,229,126,171,17,253,130,26,93,106,18,255,81,216,11,182,163,219,195,85,152,116,13,86,245,164,239,223,250,63,244,80,4,92,126,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("365c5862-4aa2-4ebe-ae16-a748f2bce5dc"),
				ContainerUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
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

		protected virtual void InitializeReadDataUserTask5Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8a822ce2-db65-4f4c-9559-c00347db1b23"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,77,143,211,48,16,253,43,81,206,235,170,249,78,123,67,165,160,189,176,43,186,218,11,217,195,196,158,180,22,206,135,108,103,161,84,253,239,140,147,182,116,81,209,22,36,196,129,156,156,167,231,153,55,31,207,59,159,43,48,230,3,212,232,207,253,7,212,26,76,91,217,201,59,169,44,234,247,186,237,59,255,198,55,168,37,40,249,13,197,136,47,133,180,111,193,2,93,217,21,63,34,20,254,188,184,28,163,240,111,10,95,90,172,13,113,232,74,37,50,17,150,98,198,74,14,1,139,147,60,100,57,23,130,65,16,204,50,145,132,89,192,163,145,249,171,224,139,182,238,64,227,152,99,8,95,13,199,135,109,231,168,1,1,124,160,72,211,54,7,48,114,34,204,178,129,82,161,160,127,171,123,36,200,106,89,83,53,248,32,107,188,7,77,185,92,156,214,65,68,170,64,25,199,82,88,217,229,215,78,163,49,178,109,94,19,167,250,186,57,103,83,0,60,253,30,228,76,7,141,142,121,15,118,51,132,184,37,89,251,65,229,155,245,90,227,26,172,124,62,23,241,25,183,3,239,186,254,209,5,65,83,122,4,213,227,89,206,151,149,44,160,179,99,65,99,122,34,104,185,222,92,93,235,169,99,175,149,27,18,216,29,201,87,198,188,88,67,152,18,248,236,128,49,202,241,88,248,159,110,205,221,151,6,245,138,111,176,134,177,107,79,19,66,127,2,150,10,107,108,236,124,199,33,45,167,60,64,86,85,73,206,226,41,157,102,165,0,150,139,44,21,105,158,38,121,144,238,233,194,73,208,124,87,70,60,72,194,42,98,121,149,8,22,115,78,93,143,227,152,137,116,150,65,56,155,133,101,0,238,202,178,177,210,110,199,77,152,239,32,11,64,0,2,139,226,52,102,177,64,100,101,25,87,140,103,144,68,73,156,76,65,100,251,167,177,92,105,58,5,219,199,83,85,31,17,132,199,193,160,103,44,216,222,144,177,180,177,158,179,147,215,86,30,117,185,87,86,54,107,143,150,73,33,119,211,156,172,6,38,45,147,251,220,204,219,181,228,160,238,58,212,112,24,247,244,178,27,94,216,200,117,90,183,173,29,251,119,154,212,130,196,28,51,156,109,37,165,163,199,194,141,107,213,246,154,31,204,105,198,87,226,143,220,255,15,60,253,59,54,189,104,148,107,22,255,127,90,233,191,191,130,123,127,255,29,53,44,32,79,200,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("94072bca-6162-4e8e-b862-b76f105bc46a"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("5c651444-a144-4931-821b-e26e9fb71f60"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("d6933145-11a6-41e0-a083-8e3d0f5cb15f"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("41bdacb0-38ba-4c89-b2bd-9e26c44910c6"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0f225841-4a24-46aa-9ab5-c60099fe3a63"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("e30c8bb4-f01c-440f-8a45-b98eb8058e08"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,75,204,77,181,50,180,50,4,0,127,229,4,95,8,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				UId = new Guid("82d3dd51-cb6e-431e-b725-0622ebd71499"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1397425e-4ae0-4803-9260-930a308717ad"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("3bbdd8db-b7fb-45ce-a565-73afafc90561"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("1a775799-e9f7-4e06-9c16-7b002d6e9c48"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("a39c131b-b8b8-409b-b619-3e350352fc5e"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("2f2d12aa-73bf-4cc5-9ed8-61b85e547204"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("2d5e1b39-c1bd-463e-aa87-b6982b2c0502"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("ecdc24d5-dc69-4e45-9cdc-bbbc660c2d5e"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("93186690-48ea-44b2-a2cf-18064e1d9d6d"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dc93e612-6e5f-4209-89e2-bf47d63b7bf2"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("0b0acbf2-552b-49a1-881d-d5ab49e8ca40"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
				UId = new Guid("f4024a32-fd2b-4005-9d29-010f490f38c1"),
				ContainerUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
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
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask3 = CreateReadDataUserTask3UserTask();
			FlowElements.Add(readdatausertask3);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			ProcessSchemaStartEvent startevent1 = CreateStartEvent1StartEvent();
			FlowElements.Add(startevent1);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			FlowElements.Add(exclusivegateway3);
			ProcessSchemaUserTask readdatausertask4 = CreateReadDataUserTask4UserTask();
			FlowElements.Add(readdatausertask4);
			ProcessSchemaUserTask changedatausertask2 = CreateChangeDataUserTask2UserTask();
			FlowElements.Add(changedatausertask2);
			ProcessSchemaUserTask readdatausertask5 = CreateReadDataUserTask5UserTask();
			FlowElements.Add(readdatausertask5);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("8c28c284-86be-46b8-b2e6-f127f4feec81"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("83737d09-45d0-40fd-9630-7d18b9e17546"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a2bcfc44-4bb9-471f-82b7-6a0b3a316268"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("738ffaeb-4a93-4ede-99d2-a18ebefe310d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a2bcfc44-4bb9-471f-82b7-6a0b3a316268"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3658f89e-eda6-4d65-b32c-1a1ea21763fd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(417, 261));
			schemaFlow.PolylinePointPositions.Add(new Point(1406, 261));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("e7bc3b23-71ca-41a9-a7d7-73a1b7c38399"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{9b9bf88c-1372-47f8-9d44-ebeaec7db7c0}].[Parameter:{7092f775-9a72-4aaf-b608-e2668011359f}].[EntityColumn:{98771b3f-7dbe-4b12-a017-0ab8d406a02a}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a2bcfc44-4bb9-471f-82b7-6a0b3a316268"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(417, 148));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("34efd614-e31d-4208-b42f-1c9207feaceb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8593432b-dbe4-49d2-ab4e-15dbe6b69a1c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("97d8cfff-02dd-47e0-ab08-ab86e99a853e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("6d531419-b788-4cf5-9023-81bd006b0421"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8593432b-dbe4-49d2-ab4e-15dbe6b69a1c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("5a9762ab-9fb2-4607-92d8-972d548892b2"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{17ce8e8f-9088-4af6-af59-77913f9de803}].[Parameter:{f5fc4e93-92c3-47f2-a1dc-a5ba89846ff7}].[EntityColumn:{519e64ec-c30f-4bea-b0d7-6e193095640e}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8593432b-dbe4-49d2-ab4e-15dbe6b69a1c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3658f89e-eda6-4d65-b32c-1a1ea21763fd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(601, 91));
			schemaFlow.PolylinePointPositions.Add(new Point(1406, 91));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("b5c8bbf2-28c0-4bcd-811a-ea6ebe0336f6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6f8502a0-3594-4b8f-977d-f540357b0266"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow3",
				UId = new Guid("4c1ae41c-a832-4454-9f59-95e8303e57f8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5689cf75-4c45-4caa-af3e-b87939b74ebc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3658f89e-eda6-4d65-b32c-1a1ea21763fd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1092, 217));
			schemaFlow.PolylinePointPositions.Add(new Point(1406, 217));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("b12f7964-a59e-4b0d-b921-f24173ada1db"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow3",
				UId = new Guid("43d68cc9-41d1-4662-a26b-62bb02a1f91a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{de73a61b-399c-4391-9e63-7eff8e68c02f}].[Parameter:{82d3dd51-cb6e-431e-b725-0622ebd71499}].[EntityColumn:{b78647f6-76db-4d25-b665-00fce475324e}]#] == true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5689cf75-4c45-4caa-af3e-b87939b74ebc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("fa228622-278b-4c12-b91f-ed2309e9c835"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3658f89e-eda6-4d65-b32c-1a1ea21763fd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1331, 148));
			schemaFlow.PolylinePointPositions.Add(new Point(1331, 173));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("838a62a1-26d2-4951-932f-58f4cb859319"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5689cf75-4c45-4caa-af3e-b87939b74ebc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("033cef62-157b-4804-9ded-0bba90f7da42"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("033cef62-157b-4804-9ded-0bba90f7da42"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("3658f89e-eda6-4d65-b32c-1a1ea21763fd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"Terminate1",
				Position = new Point(1393, 160),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ReadDataUserTask1",
				Position = new Point(137, 176),
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
				UId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ReadDataUserTask2",
				Position = new Point(260, 176),
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
				UId = new Guid("a2bcfc44-4bb9-471f-82b7-6a0b3a316268"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ExclusiveGateway1",
				Position = new Point(390, 176),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ReadDataUserTask3",
				Position = new Point(467, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(680, 121),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("8593432b-dbe4-49d2-ab4e-15dbe6b69a1c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ExclusiveGateway2",
				Position = new Point(574, 121),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaStartEvent CreateStartEvent1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("6f8502a0-3594-4b8f-977d-f540357b0266"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"StartEvent1",
				Position = new Point(56, 190),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("5689cf75-4c45-4caa-af3e-b87939b74ebc"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ExclusiveGateway3",
				Position = new Point(1065, 121),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask4UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ReadDataUserTask4",
				Position = new Point(810, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask4Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ChangeDataUserTask2",
				Position = new Point(1200, 121),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask5UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73d4e26a-203e-4287-9a4d-dfc1a61e4f3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"),
				Name = @"ReadDataUserTask5",
				Position = new Point(926, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask5Parameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new AnalyzeCaseSatisfactionLevel(userConnection);
		}

		public override object Clone() {
			return new AnalyzeCaseSatisfactionLevelSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("01896e87-3e42-46cf-8f01-9781cacfce12"));
		}

		#endregion

	}

	#endregion

	#region Class: AnalyzeCaseSatisfactionLevel

	/// <exclude/>
	public class AnalyzeCaseSatisfactionLevel : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("dbab6b5a-c19d-456d-8d70-b382a68498f1");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,83,203,110,219,48,16,252,149,64,231,48,208,131,146,37,223,10,215,45,114,105,130,198,200,165,202,97,69,173,100,162,146,40,144,84,90,215,240,191,119,41,217,142,83,184,136,219,75,47,213,137,26,12,103,103,150,187,91,79,52,96,204,39,104,209,155,123,43,212,26,140,170,236,205,7,217,88,212,31,181,26,122,239,218,51,168,37,52,242,7,150,19,190,44,165,125,15,22,232,202,54,127,81,200,189,121,126,94,35,247,174,115,79,90,108,13,113,232,74,26,37,101,86,241,144,249,65,150,48,158,196,21,131,25,15,152,192,178,76,179,168,202,66,62,155,152,191,19,95,168,182,7,141,83,141,81,190,26,143,171,77,239,168,1,1,98,164,72,163,186,61,24,57,19,102,217,65,209,96,73,255,86,15,72,144,213,178,165,52,184,146,45,222,131,166,90,78,71,57,136,72,21,52,198,177,26,172,236,242,123,175,209,24,169,186,183,204,53,67,219,157,178,73,0,143,191,123,59,254,232,209,49,239,193,174,71,137,91,178,181,27,93,190,171,107,141,53,88,249,124,106,226,43,110,70,222,101,253,163,11,37,189,210,35,52,3,158,212,124,157,100,1,189,157,2,77,229,137,160,101,189,190,56,235,177,99,111,197,13,9,236,15,228,11,53,207,102,8,19,2,159,29,48,169,28,142,185,247,229,214,220,125,235,80,63,136,53,182,48,117,237,233,134,208,95,128,163,254,124,59,19,169,159,96,92,178,42,242,57,227,49,157,138,16,57,203,176,140,33,21,105,90,249,98,247,52,249,144,166,111,96,243,120,44,183,0,131,87,159,81,40,93,94,141,47,231,62,215,96,85,75,1,205,93,143,26,246,189,245,207,143,222,171,153,117,177,180,82,118,50,123,108,139,171,50,214,63,60,190,192,106,22,101,65,192,32,77,67,198,35,30,179,34,138,67,22,70,69,202,57,197,73,131,130,204,208,222,186,206,61,168,65,139,253,158,152,105,97,255,106,17,255,193,122,253,201,198,156,157,217,75,102,240,255,116,161,27,150,221,79,90,144,37,197,10,6,0,0 })));
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

			public ReadDataUserTask2FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("9b9bf88c-1372-47f8-9d44-ebeaec7db7c0");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,203,110,19,49,20,253,149,104,214,117,53,15,207,43,59,84,2,234,134,86,180,234,134,116,113,199,190,78,45,230,37,219,83,8,81,254,157,235,153,36,164,40,168,129,13,18,98,86,158,163,115,143,207,125,121,19,136,26,172,253,0,13,6,243,224,30,141,1,219,41,119,249,78,215,14,205,123,211,13,125,112,17,88,52,26,106,253,13,229,132,47,164,118,111,193,1,133,108,150,63,20,150,193,124,121,90,99,25,92,44,3,237,176,177,196,161,16,37,18,224,69,136,44,140,114,100,60,149,146,21,105,156,178,88,86,24,150,33,47,132,148,19,243,87,226,87,93,211,131,193,233,142,81,94,141,199,251,117,239,169,17,1,98,164,104,219,181,59,48,241,38,236,162,133,170,70,47,239,204,128,4,57,163,27,202,6,239,117,131,183,96,232,46,175,211,121,136,72,10,106,235,89,53,42,183,248,218,27,180,86,119,237,107,230,234,161,105,143,217,36,128,135,223,157,157,112,244,232,153,183,224,158,70,137,107,178,181,29,93,190,89,173,12,174,192,233,231,99,19,159,113,61,242,206,171,31,5,72,234,210,3,212,3,30,221,249,50,147,43,232,221,148,208,116,61,17,140,94,61,157,157,235,161,98,175,165,27,19,216,239,201,103,106,158,204,33,206,8,124,246,192,164,178,63,46,131,79,215,246,230,75,139,230,78,60,97,3,83,213,30,47,9,253,9,88,212,216,96,235,230,27,89,65,149,85,41,48,17,149,146,234,152,81,29,101,30,178,42,41,98,200,10,94,22,42,218,82,192,193,208,124,3,57,138,28,129,51,129,105,197,184,202,10,42,125,21,177,180,18,85,168,162,36,130,52,246,33,139,214,105,183,158,38,193,71,69,32,1,129,37,60,227,140,75,68,86,85,92,49,145,67,154,164,60,13,65,230,219,199,41,93,109,251,26,214,15,135,172,62,34,200,153,0,139,51,95,137,25,237,149,177,110,230,183,105,214,169,25,21,121,168,157,110,87,51,154,165,26,133,111,230,229,157,3,55,216,81,206,247,148,68,18,193,139,12,74,193,226,180,136,25,207,179,152,149,130,126,121,146,128,138,84,89,240,200,207,158,255,252,136,116,43,45,160,190,233,209,192,110,58,194,211,203,243,98,235,124,99,76,215,185,169,220,135,198,94,145,247,35,71,251,33,174,162,52,41,195,92,49,20,33,80,37,139,130,149,50,69,134,105,89,161,72,18,196,82,145,37,122,127,124,222,119,221,96,196,110,223,237,244,240,252,209,131,242,23,158,137,223,217,252,147,187,119,206,46,253,223,146,127,104,75,182,193,246,59,78,13,231,206,154,7,0,0 })));
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

		#region Class: ReadDataUserTask3FlowElement

		/// <exclude/>
		public class ReadDataUserTask3FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask3FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("17ce8e8f-9088-4af6-af59-77913f9de803");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,93,111,211,48,20,253,43,81,158,231,41,78,227,38,233,27,26,5,77,66,108,98,211,94,214,61,92,59,215,93,132,243,33,219,29,148,170,255,157,235,164,43,29,42,90,225,5,36,242,20,31,29,31,159,251,185,137,149,1,231,62,66,131,241,44,190,69,107,193,117,218,159,191,171,141,71,251,222,118,171,62,62,139,29,218,26,76,253,13,171,17,159,87,181,127,11,30,232,202,102,241,67,97,17,207,22,199,53,22,241,217,34,174,61,54,142,56,116,69,164,185,204,33,153,48,205,43,96,89,154,86,76,162,206,24,22,25,168,9,207,85,94,164,35,243,87,226,23,93,211,131,197,241,141,65,94,15,191,183,235,62,80,57,1,106,160,212,174,107,119,224,36,152,112,243,22,164,193,138,206,222,174,144,32,111,235,134,162,193,219,186,193,107,176,244,86,208,233,2,68,36,13,198,5,150,65,237,231,95,123,139,206,213,93,251,154,57,179,106,218,67,54,9,224,254,184,179,147,12,30,3,243,26,252,227,32,113,73,182,182,131,203,55,203,165,197,37,248,250,233,208,196,103,92,15,188,211,242,71,23,42,170,210,29,152,21,30,188,249,50,146,11,232,253,24,208,248,60,17,108,189,124,60,57,214,125,198,94,11,55,37,176,127,38,159,168,121,52,134,116,74,224,83,0,70,149,231,223,69,124,127,233,174,190,180,104,111,212,35,54,48,102,237,225,156,208,159,128,185,193,6,91,63,219,84,18,228,84,10,96,138,151,21,203,196,180,98,69,149,39,76,78,138,20,166,69,86,22,154,111,233,194,222,208,108,3,57,170,28,33,99,10,133,100,153,158,22,172,16,146,51,33,149,76,52,159,112,16,105,184,50,111,125,237,215,99,39,204,54,74,105,37,180,212,44,171,84,201,178,28,51,86,114,61,97,34,67,40,83,193,65,242,98,251,48,134,91,187,222,192,250,110,31,213,39,132,42,82,224,48,10,153,136,104,174,172,243,81,152,166,168,211,17,37,121,101,124,221,46,35,234,37,131,42,20,243,252,134,26,199,105,24,14,145,193,39,52,131,116,168,47,9,86,121,137,2,196,132,21,80,82,247,0,47,41,106,73,73,168,120,154,113,94,202,4,50,234,195,240,133,118,233,150,181,2,115,213,163,133,93,167,36,199,7,233,197,4,134,34,217,174,243,99,234,247,69,62,116,246,97,111,236,185,175,185,208,121,50,45,21,163,144,41,185,144,8,86,74,20,67,95,99,34,32,75,74,78,206,104,37,133,84,220,116,43,171,118,43,192,141,187,232,143,118,204,95,216,28,191,179,12,142,142,227,41,227,245,159,13,206,191,217,221,219,120,251,29,12,208,201,151,101,7,0,0 })));
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
								new Guid("82b9bea0-0053-40fc-8232-85f47d8d17da")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("82b9bea0-0053-40fc-8232-85f47d8d17da"));
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

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("2f66b44b-a3ad-4488-adac-18654ff735ea");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Status = () => (Guid)(((process.ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName("Status").ColumnValueName) ? process.ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>("StatusId") : Guid.Empty)));
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,203,110,219,48,16,252,149,64,231,48,144,101,61,125,43,92,183,200,165,9,26,35,151,42,135,21,185,148,137,82,162,64,82,105,93,195,255,94,82,178,85,167,112,17,183,64,209,234,68,13,134,51,179,203,221,93,64,37,24,243,1,26,12,22,193,26,181,6,163,184,189,121,39,164,69,253,94,171,190,11,174,3,131,90,128,20,223,144,141,248,138,9,251,22,44,184,43,187,242,135,66,25,44,202,243,26,101,112,93,6,194,98,99,28,199,93,201,162,104,22,21,69,68,104,50,103,36,158,49,70,170,34,201,72,72,33,206,211,52,195,138,86,35,243,87,226,75,213,116,160,113,244,24,228,249,112,92,111,59,79,157,57,128,14,20,97,84,123,0,231,62,132,89,181,80,73,100,238,223,234,30,29,100,181,104,92,53,184,22,13,222,131,118,94,94,71,121,200,145,56,72,227,89,18,185,93,125,237,52,26,35,84,251,90,56,217,55,237,41,219,9,224,244,123,136,19,14,25,61,243,30,236,102,144,184,117,177,246,67,202,55,117,173,177,6,43,158,79,67,124,198,237,192,187,172,127,238,2,115,175,244,8,178,199,19,207,151,149,44,161,179,99,65,163,189,35,104,81,111,46,174,117,234,216,107,229,70,14,236,142,228,11,53,207,214,16,165,14,124,246,192,168,114,60,150,193,167,91,115,247,165,69,253,64,55,216,192,216,181,167,27,135,254,4,76,250,139,93,70,243,48,197,132,17,62,15,99,18,39,238,84,69,24,147,2,89,2,57,205,115,30,210,253,211,152,67,152,78,194,246,113,178,91,130,193,171,143,72,149,102,87,195,203,249,207,55,88,213,130,130,188,235,80,195,161,183,225,249,209,123,49,179,190,44,173,148,29,195,78,109,241,46,131,255,241,241,227,138,241,40,13,43,82,241,170,32,49,163,33,1,22,115,18,198,140,103,225,44,41,128,38,46,140,219,91,223,185,7,213,107,122,216,19,51,46,236,31,45,226,63,88,175,223,217,152,179,51,123,201,12,254,23,211,245,55,39,103,31,236,191,3,17,107,186,229,230,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,193,110,219,48,12,253,21,195,237,49,12,44,75,178,44,95,219,14,8,208,110,69,179,245,210,228,64,75,84,107,192,177,11,75,233,208,5,249,247,41,78,210,54,221,118,154,14,50,68,243,61,146,79,79,155,244,60,188,62,83,90,165,223,105,24,208,247,46,76,47,250,129,166,183,67,111,200,251,233,117,111,176,109,126,97,221,210,45,14,184,162,64,195,61,182,107,242,215,141,15,147,228,20,150,78,210,243,151,241,111,90,61,108,210,89,160,213,143,153,141,236,178,116,69,157,151,53,152,90,18,136,66,230,80,154,130,129,85,121,169,115,172,107,225,202,8,54,125,187,94,117,55,20,240,22,195,83,90,109,210,145,45,18,160,98,104,145,16,184,40,4,8,75,4,59,16,24,133,146,75,33,51,180,42,221,78,82,111,158,104,133,99,209,119,48,99,202,242,220,105,40,115,37,65,72,46,160,20,140,1,51,69,193,152,52,164,141,221,129,15,249,239,192,135,179,135,153,255,246,179,163,97,62,242,86,14,91,79,203,105,140,126,10,92,181,180,162,46,84,27,166,12,149,84,58,208,89,89,130,64,87,0,58,169,65,41,205,184,211,150,202,140,111,35,224,77,205,106,227,164,51,130,52,7,157,27,14,66,185,28,144,89,3,40,107,44,117,41,10,231,212,14,114,213,133,38,188,94,140,26,85,27,201,52,21,130,12,24,158,57,16,117,212,166,206,172,130,130,152,230,153,150,133,200,104,187,60,91,238,6,179,141,127,110,241,245,254,207,249,238,8,109,226,49,52,222,161,9,77,223,37,45,189,80,155,88,12,56,253,210,12,62,36,77,188,197,164,119,201,64,126,221,134,166,123,76,226,53,181,52,102,79,231,1,195,218,239,171,60,159,24,228,99,157,205,98,239,179,69,90,45,254,229,180,195,119,175,235,169,215,62,219,108,145,78,22,233,188,95,15,102,199,200,227,225,242,195,128,99,145,49,229,211,241,232,171,24,233,214,109,123,136,92,198,73,143,137,199,112,111,27,215,144,157,117,243,163,157,70,150,236,176,224,47,219,113,237,123,251,31,216,13,118,248,72,195,215,40,192,123,239,111,93,126,143,50,30,137,235,92,203,76,49,7,138,80,131,160,34,190,42,203,16,52,211,181,227,42,90,222,229,35,250,142,28,13,212,25,58,109,76,107,199,101,198,56,20,181,194,104,60,91,64,45,68,6,196,29,195,172,70,173,153,57,224,253,168,246,238,65,31,250,218,73,181,77,183,219,229,246,55,20,247,87,35,68,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "01896e873e4246cf8f019781cacfce12",
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

		#region Class: ReadDataUserTask4FlowElement

		/// <exclude/>
		public class ReadDataUserTask4FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask4FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask4";
				IsLogging = true;
				SchemaElementUId = new Guid("ca6b0c1e-ff58-401e-9bda-8d76d6865816");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,77,111,211,64,16,253,43,150,207,117,228,141,191,115,67,33,160,94,104,69,163,94,112,15,227,245,216,89,177,254,208,238,186,16,162,252,119,102,237,36,164,40,168,1,9,113,192,39,251,233,205,204,155,143,231,157,203,37,104,253,1,26,116,23,238,26,149,2,221,85,102,246,78,72,131,234,189,234,134,222,189,113,53,42,1,82,124,195,114,194,87,165,48,111,193,0,133,236,242,31,25,114,119,145,95,206,145,187,55,185,43,12,54,154,56,20,18,101,217,60,101,5,243,144,65,236,133,177,207,60,136,51,244,210,50,42,89,18,68,28,146,100,98,254,42,249,178,107,122,80,56,213,24,211,87,227,235,122,219,91,42,35,128,143,20,161,187,246,0,6,86,132,94,181,80,72,44,233,219,168,1,9,50,74,52,212,13,174,69,131,247,160,168,150,205,211,89,136,72,21,72,109,89,18,43,179,250,218,43,212,90,116,237,107,226,228,208,180,231,108,74,128,167,207,131,28,127,212,104,153,247,96,54,99,138,91,146,181,31,85,190,169,107,133,53,24,241,124,46,226,51,110,71,222,117,243,163,128,146,182,244,8,114,192,179,154,47,59,89,66,111,166,134,166,242,68,80,162,222,92,221,235,105,98,175,181,59,39,176,63,146,175,204,121,177,135,121,76,224,179,5,166,44,199,215,220,253,116,171,239,190,180,168,30,248,6,27,152,166,246,52,35,244,39,96,37,177,193,214,44,118,101,1,69,92,68,224,113,150,149,94,24,197,37,141,48,241,189,34,72,231,16,167,97,150,86,108,79,1,39,65,139,29,36,200,19,132,208,227,24,21,94,88,197,169,151,70,180,137,168,224,133,95,177,128,65,52,183,33,171,214,8,179,157,46,129,162,208,199,144,214,226,241,48,139,40,10,19,15,2,42,25,64,145,204,147,20,89,204,146,253,211,212,174,208,189,132,237,227,169,171,143,8,165,195,65,163,99,39,225,144,175,148,54,142,117,147,211,85,14,13,121,144,70,180,181,67,183,36,145,219,101,206,198,59,178,143,93,119,87,11,14,242,174,71,5,135,77,251,151,141,240,194,65,118,200,170,235,204,52,186,211,146,150,164,99,148,121,60,69,42,68,127,8,171,236,161,27,20,63,56,82,79,191,134,63,178,252,63,48,242,239,120,243,162,59,174,185,246,255,233,142,255,230,241,237,221,253,119,249,242,79,43,183,6,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,43,205,77,74,45,178,50,180,50,4,0,62,85,105,155,10,0,0,0 })));
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

			#endregion

		}

		#endregion

		#region Class: ChangeDataUserTask2FlowElement

		/// <exclude/>
		public class ChangeDataUserTask2FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask2FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("76d999c8-bdbc-4338-8a0c-62bc13b6b90a");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_ClosureDate = () => (DateTime)(((DateTime)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentDateTime")));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_ClosureDate", () => _recordColumnValues_ClosureDate.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<DateTime> _recordColumnValues_ClosureDate;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,205,83,65,110,219,48,16,252,74,192,115,20,40,150,100,203,190,21,174,91,228,210,4,141,145,75,149,195,154,90,201,68,41,81,32,169,180,174,225,191,119,73,218,170,83,184,136,27,32,104,13,31,168,193,112,102,118,185,187,101,92,130,49,159,160,65,54,99,75,212,26,140,170,236,213,7,33,45,234,143,90,245,29,187,100,6,181,0,41,126,96,25,240,69,41,236,123,176,64,87,182,197,47,133,130,205,138,211,26,5,187,44,152,176,216,24,226,208,149,20,178,24,174,121,21,77,227,21,68,105,50,225,209,52,201,203,8,199,73,50,78,50,250,79,166,129,249,39,241,185,106,58,208,24,60,188,124,229,143,203,77,231,168,215,4,112,79,17,70,181,123,48,113,33,204,162,133,149,196,146,190,173,238,145,32,171,69,67,213,224,82,52,120,7,154,188,156,142,114,16,145,42,144,198,177,36,86,118,241,189,211,104,140,80,237,75,225,100,223,180,199,108,18,192,225,115,31,39,246,25,29,243,14,236,218,75,220,80,172,157,79,249,174,174,53,214,96,197,211,113,136,175,184,241,188,243,250,71,23,74,122,165,7,144,61,30,121,62,175,100,14,157,13,5,5,123,34,104,81,175,207,174,117,232,216,75,229,142,8,236,14,228,51,53,79,214,48,26,19,248,228,128,160,114,56,22,236,203,141,185,253,214,162,190,231,107,108,32,116,237,241,138,208,223,128,65,127,182,157,240,60,30,99,86,70,85,18,167,81,154,209,105,53,194,52,154,98,153,65,206,243,188,138,249,238,49,228,16,166,147,176,121,24,236,230,96,240,226,51,114,165,203,11,255,114,238,231,26,172,106,193,65,222,118,168,97,223,219,248,244,232,61,155,89,87,150,86,202,134,176,67,91,156,139,247,63,60,62,25,209,78,186,174,220,171,94,243,253,14,152,176,140,175,90,178,127,176,58,127,179,13,39,231,241,156,249,250,47,38,231,45,167,98,199,118,63,1,56,110,94,215,194,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,77,111,163,48,20,252,43,200,237,49,142,48,24,48,185,182,151,72,237,42,106,178,185,148,30,30,246,243,22,137,143,200,152,74,217,136,255,190,134,64,211,68,221,203,174,15,32,63,222,140,231,205,224,19,185,183,199,3,146,21,217,161,49,208,54,218,46,31,26,131,203,141,105,36,182,237,242,169,145,80,22,191,33,47,113,3,6,42,180,104,246,80,118,216,62,21,173,93,120,215,48,178,32,247,31,227,87,178,122,61,145,181,197,234,231,90,57,118,161,133,47,67,145,80,197,49,167,156,137,156,10,205,99,202,164,200,85,148,112,157,198,129,3,203,166,236,170,250,25,45,108,192,190,147,213,137,140,108,142,0,89,192,82,166,53,13,4,99,148,135,190,162,128,18,104,2,156,135,17,242,156,229,41,233,23,164,149,239,88,193,120,232,5,204,88,162,194,64,167,84,4,73,68,121,20,114,42,184,163,97,50,142,25,139,36,166,82,13,224,169,255,2,124,189,219,30,219,61,152,98,152,127,249,208,25,131,181,125,4,139,187,162,194,187,183,1,163,138,246,80,194,113,255,45,212,205,239,125,220,192,189,1,235,65,173,188,129,232,76,114,184,178,246,43,205,41,59,39,148,145,85,246,183,140,166,247,118,28,253,58,165,219,128,50,178,200,200,182,233,140,28,24,67,183,121,252,162,127,60,100,108,185,217,206,137,184,74,221,149,229,84,113,250,97,110,156,203,141,42,116,129,106,93,111,231,32,70,22,127,90,244,155,199,188,206,218,254,7,246,12,53,252,66,243,195,25,112,209,254,169,114,231,108,156,137,85,192,48,69,205,169,244,99,78,185,207,2,154,7,34,166,26,24,8,150,48,229,126,171,17,253,130,26,93,106,18,255,81,216,11,182,163,219,195,85,152,116,13,86,245,164,239,223,250,63,244,80,4,92,126,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "01896e873e4246cf8f019781cacfce12",
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

		#region Class: ReadDataUserTask5FlowElement

		/// <exclude/>
		public class ReadDataUserTask5FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask5FlowElement(UserConnection userConnection, AnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask5";
				IsLogging = true;
				SchemaElementUId = new Guid("de73a61b-399c-4391-9e63-7eff8e68c02f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,77,143,211,48,16,253,43,81,206,235,170,249,78,123,67,165,160,189,176,43,186,218,11,217,195,196,158,180,22,206,135,108,103,161,84,253,239,140,147,182,116,81,209,22,36,196,129,156,156,167,231,153,55,31,207,59,159,43,48,230,3,212,232,207,253,7,212,26,76,91,217,201,59,169,44,234,247,186,237,59,255,198,55,168,37,40,249,13,197,136,47,133,180,111,193,2,93,217,21,63,34,20,254,188,184,28,163,240,111,10,95,90,172,13,113,232,74,37,50,17,150,98,198,74,14,1,139,147,60,100,57,23,130,65,16,204,50,145,132,89,192,163,145,249,171,224,139,182,238,64,227,152,99,8,95,13,199,135,109,231,168,1,1,124,160,72,211,54,7,48,114,34,204,178,129,82,161,160,127,171,123,36,200,106,89,83,53,248,32,107,188,7,77,185,92,156,214,65,68,170,64,25,199,82,88,217,229,215,78,163,49,178,109,94,19,167,250,186,57,103,83,0,60,253,30,228,76,7,141,142,121,15,118,51,132,184,37,89,251,65,229,155,245,90,227,26,172,124,62,23,241,25,183,3,239,186,254,209,5,65,83,122,4,213,227,89,206,151,149,44,160,179,99,65,99,122,34,104,185,222,92,93,235,169,99,175,149,27,18,216,29,201,87,198,188,88,67,152,18,248,236,128,49,202,241,88,248,159,110,205,221,151,6,245,138,111,176,134,177,107,79,19,66,127,2,150,10,107,108,236,124,199,33,45,167,60,64,86,85,73,206,226,41,157,102,165,0,150,139,44,21,105,158,38,121,144,238,233,194,73,208,124,87,70,60,72,194,42,98,121,149,8,22,115,78,93,143,227,152,137,116,150,65,56,155,133,101,0,238,202,178,177,210,110,199,77,152,239,32,11,64,0,2,139,226,52,102,177,64,100,101,25,87,140,103,144,68,73,156,76,65,100,251,167,177,92,105,58,5,219,199,83,85,31,17,132,199,193,160,103,44,216,222,144,177,180,177,158,179,147,215,86,30,117,185,87,86,54,107,143,150,73,33,119,211,156,172,6,38,45,147,251,220,204,219,181,228,160,238,58,212,112,24,247,244,178,27,94,216,200,117,90,183,173,29,251,119,154,212,130,196,28,51,156,109,37,165,163,199,194,141,107,213,246,154,31,204,105,198,87,226,143,220,255,15,60,253,59,54,189,104,148,107,22,255,127,90,233,191,191,130,123,127,255,29,53,44,32,79,200,6,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,75,204,77,181,50,180,50,4,0,127,229,4,95,8,0,0,0 })));
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

			#endregion

		}

		#endregion

		public AnalyzeCaseSatisfactionLevel(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AnalyzeCaseSatisfactionLevel";
			SchemaUId = new Guid("01896e87-3e42-46cf-8f01-9781cacfce12");
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
				return new Guid("01896e87-3e42-46cf-8f01-9781cacfce12");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: AnalyzeCaseSatisfactionLevel, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: AnalyzeCaseSatisfactionLevel, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid CaseRecordId {
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
					SchemaElementUId = new Guid("3658f89e-eda6-4d65-b32c-1a1ea21763fd"),
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

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("a2bcfc44-4bb9-471f-82b7-6a0b3a316268"),
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

		private ReadDataUserTask3FlowElement _readDataUserTask3;
		public ReadDataUserTask3FlowElement ReadDataUserTask3 {
			get {
				return _readDataUserTask3 ?? (_readDataUserTask3 = new ReadDataUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("8593432b-dbe4-49d2-ab4e-15dbe6b69a1c"),
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

		private ProcessFlowElement _startEvent1;
		public ProcessFlowElement StartEvent1 {
			get {
				return _startEvent1 ?? (_startEvent1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartEvent1",
					SchemaElementUId = new Guid("6f8502a0-3594-4b8f-977d-f540357b0266"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("5689cf75-4c45-4caa-af3e-b87939b74ebc"),
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

		private ReadDataUserTask4FlowElement _readDataUserTask4;
		public ReadDataUserTask4FlowElement ReadDataUserTask4 {
			get {
				return _readDataUserTask4 ?? (_readDataUserTask4 = new ReadDataUserTask4FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask2FlowElement _changeDataUserTask2;
		public ChangeDataUserTask2FlowElement ChangeDataUserTask2 {
			get {
				return _changeDataUserTask2 ?? (_changeDataUserTask2 = new ChangeDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask5FlowElement _readDataUserTask5;
		public ReadDataUserTask5FlowElement ReadDataUserTask5 {
			get {
				return _readDataUserTask5 ?? (_readDataUserTask5 = new ReadDataUserTask5FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("e7bc3b23-71ca-41a9-a7d7-73a1b7c38399"),
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
					SchemaElementUId = new Guid("5a9762ab-9fb2-4607-92d8-972d548892b2"),
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
					SchemaElementUId = new Guid("43d68cc9-41d1-4662-a26b-62bb02a1f91a"),
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
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask3 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[StartEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartEvent1 };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[ReadDataUserTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask4 };
			FlowElements[ChangeDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask2 };
			FlowElements[ReadDataUserTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask5 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "ReadDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask3", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadDataUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask4", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "StartEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "ExclusiveGateway3":
						if (ConditionalSequenceFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadDataUserTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask5", e.Context.SenderName));
						break;
					case "ChangeDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadDataUserTask5":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway3", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("IsResolved").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>("IsResolved") : false)));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow1", "((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName(\"IsResolved\").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<bool>(\"IsResolved\") : false))", result);
			return result;
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName("Status").ColumnValueName) ? ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>("StatusId") : Guid.Empty)) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "ConditionalSequenceFlow2", "((ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName(\"Status\").ColumnValueName) ? ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>(\"StatusId\") : Guid.Empty)) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalSequenceFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask5.ResultEntity.IsColumnValueLoaded(ReadDataUserTask5.ResultEntity.Schema.Columns.GetByName("IsFinal").ColumnValueName) ? ReadDataUserTask5.ResultEntity.GetTypedColumnValue<bool>("IsFinal") : false)) == true);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway3", "ConditionalSequenceFlow3", "((ReadDataUserTask5.ResultEntity.IsColumnValueLoaded(ReadDataUserTask5.ResultEntity.Schema.Columns.GetByName(\"IsFinal\").ColumnValueName) ? ReadDataUserTask5.ResultEntity.GetTypedColumnValue<bool>(\"IsFinal\") : false)) == true", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
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
			MetaPathParameterValues.Add("7c806e5d-f304-455d-b2e4-9ed5a8c88f0c", () => CaseRecordId);
			MetaPathParameterValues.Add("643fc2b1-37e6-4c13-b874-541f74be69c6", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("fb56437e-ba33-4a23-9d0c-ae27bb35a2a4", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("28d07f6e-0d89-4984-ae74-9e1d6c8a64b5", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("c4dec099-47fa-4366-98a4-b699ffa357e6", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("72de3fe9-d5d9-40ab-85f1-88ea175b52be", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("5e86df7f-bd13-4bc4-9cc7-8b7f60824845", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("247ba482-7f2c-4dc6-94f2-7174de79afd0", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("a7ec7ea4-ce5b-4f68-85b1-5bcb0f131a52", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("608cedf5-b8e9-4b65-b2eb-f05daae2899e", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("d10c7fb3-28cc-4700-a5b8-66c91209a9f8", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("fdea50bf-6a67-4306-9bf6-a560509191ee", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("85ce2111-939c-4c61-a6fc-25f3d846bef3", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("c8ea1ef0-089c-4d1e-ad79-bb1881d2a81b", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("6400198a-fd0f-42e8-aff8-558ad741e1f3", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("b853c17a-5aa9-4f6a-b6f5-dc1d14e76e99", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("cbfaa20f-5593-406d-b8d0-2a98e6a2c065", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("55ff5bcf-9e1c-431e-be5e-7d02bf259e96", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("f57e2c13-063b-4f4f-a6c1-6242bef6ec8b", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("22be0081-4670-4d92-b56b-32844cd949e3", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("3dc139f3-bcc4-413e-937a-9d613d137381", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("0c6de25d-2707-4643-a8ad-911d475e594c", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("2c01b2a0-4d16-41e0-a641-3d9a2f02561b", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("c0073aa2-5633-49ad-b4a3-2e43b3e5669f", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("02c2428c-c555-47dc-9e99-df353f553049", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("cbd3780c-de4a-4e33-8ee8-b9febddbf1a5", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("bd37a5c6-0d37-4523-b75c-cf34a74888cb", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("7092f775-9a72-4aaf-b608-e2668011359f", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("352856bf-54d3-414b-a777-6ea0f684dd68", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("38097a14-57ca-4d1c-a9b6-b83821594568", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("891c23be-079e-4dcf-afa7-6c04ead53b72", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("ca27a4b0-7cce-4840-9bca-800f545dca25", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("101a3fe4-83d5-45b2-94de-c891f8aae0b1", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("9b75f53d-4836-4518-9ff9-ac4c9e368e0f", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("b0a000e3-e6fc-4cdd-b51c-12f6e2c080eb", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("ae705119-6e00-4b54-afa3-f7214514ce18", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("7b964786-d631-40c6-80bc-46e13902504e", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("7d8bb773-f3ac-4fff-96c4-90b07b7d612c", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("45354f6b-5f87-4f1c-b3ac-5d1e5c2529f6", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("42a0be64-dc23-4a7d-9fe3-953b6cefb20b", () => ReadDataUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("d6167808-425a-4541-a89f-19118a685830", () => ReadDataUserTask3.ResultType);
			MetaPathParameterValues.Add("df97a40d-caba-46d0-ae3b-3ab77b3aa563", () => ReadDataUserTask3.ReadSomeTopRecords);
			MetaPathParameterValues.Add("b70e85c0-915b-4104-b121-b468de8a4637", () => ReadDataUserTask3.NumberOfRecords);
			MetaPathParameterValues.Add("223eb29e-364a-44cc-becc-69e01425be9c", () => ReadDataUserTask3.FunctionType);
			MetaPathParameterValues.Add("656b1ea1-bac6-4518-8006-2d3d95f56bed", () => ReadDataUserTask3.AggregationColumnName);
			MetaPathParameterValues.Add("ec808db1-3f0a-4038-a26b-446f2935c069", () => ReadDataUserTask3.OrderInfo);
			MetaPathParameterValues.Add("f5fc4e93-92c3-47f2-a1dc-a5ba89846ff7", () => ReadDataUserTask3.ResultEntity);
			MetaPathParameterValues.Add("92813432-e952-427c-b775-57f77d398b6d", () => ReadDataUserTask3.ResultCount);
			MetaPathParameterValues.Add("2ef81675-328b-4e33-8a16-6a0df1006683", () => ReadDataUserTask3.ResultIntegerFunction);
			MetaPathParameterValues.Add("2f91fd7b-c25b-45ae-ac98-c772e1c88493", () => ReadDataUserTask3.ResultFloatFunction);
			MetaPathParameterValues.Add("3a06c5c6-afac-4bd1-9115-551805b1f7bb", () => ReadDataUserTask3.ResultDateTimeFunction);
			MetaPathParameterValues.Add("af6a486a-47e5-47a2-85fe-6687125e74bd", () => ReadDataUserTask3.ResultRowsCount);
			MetaPathParameterValues.Add("32bf5acf-9862-459e-a98e-55e6f938cfb2", () => ReadDataUserTask3.CanReadUncommitedData);
			MetaPathParameterValues.Add("fc23f180-56cd-4e39-a2cf-d3dad81c0dd1", () => ReadDataUserTask3.ResultEntityCollection);
			MetaPathParameterValues.Add("be278a15-6327-41b0-a4a8-6c2d57c5a3cc", () => ReadDataUserTask3.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("9105f6d4-f8a4-4fc1-b550-632a6cf66f9a", () => ReadDataUserTask3.IgnoreDisplayValues);
			MetaPathParameterValues.Add("4da5aef6-f601-4b3f-86e6-5544484a2c6d", () => ReadDataUserTask3.ResultCompositeObjectList);
			MetaPathParameterValues.Add("0e5da894-beb3-4105-b6f7-9e80be0477d0", () => ReadDataUserTask3.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("9368f221-436d-4df7-8b76-c98cf6d025a9", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("65d9b230-45b3-4daa-bb41-9096e6b07169", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("a461b0ff-7cf6-4abc-aab6-8c25d8833b2b", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("3ef5ba64-31d5-408a-91cd-c4b705177d41", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("7c487732-e1d0-41c7-a366-6994979c4154", () => ChangeDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("d51b136d-f674-45ae-991e-74dc6a36e5a5", () => ReadDataUserTask4.DataSourceFilters);
			MetaPathParameterValues.Add("fe0fa648-3fc3-4ce1-a8d3-1681f04a67c9", () => ReadDataUserTask4.ResultType);
			MetaPathParameterValues.Add("ae404d44-60d7-4e4b-8282-762b27d3a152", () => ReadDataUserTask4.ReadSomeTopRecords);
			MetaPathParameterValues.Add("8763f1ba-63c6-4753-87a2-dbaeb9ea40d3", () => ReadDataUserTask4.NumberOfRecords);
			MetaPathParameterValues.Add("9eda2b32-157f-4e17-b87c-cc0782b8e875", () => ReadDataUserTask4.FunctionType);
			MetaPathParameterValues.Add("d2adb4a4-eb38-4950-aadd-fdeebf093883", () => ReadDataUserTask4.AggregationColumnName);
			MetaPathParameterValues.Add("6c320b14-8f29-402a-a272-3d4d451107ba", () => ReadDataUserTask4.OrderInfo);
			MetaPathParameterValues.Add("b3c152f3-8f5d-4ccd-a444-d697a2992b1a", () => ReadDataUserTask4.ResultEntity);
			MetaPathParameterValues.Add("919f3607-18a5-44b4-b8c5-a553b21c63f7", () => ReadDataUserTask4.ResultCount);
			MetaPathParameterValues.Add("275b1604-78cd-4f80-ad1a-dbb6afbae187", () => ReadDataUserTask4.ResultIntegerFunction);
			MetaPathParameterValues.Add("58b416b7-18b4-43de-b90e-b775fc705598", () => ReadDataUserTask4.ResultFloatFunction);
			MetaPathParameterValues.Add("18226361-e716-427e-8881-44a4fbfcbcbc", () => ReadDataUserTask4.ResultDateTimeFunction);
			MetaPathParameterValues.Add("acdae03e-04e7-470b-acab-80f8b02cde3d", () => ReadDataUserTask4.ResultRowsCount);
			MetaPathParameterValues.Add("98406230-ae2f-4d18-934d-4512830c3860", () => ReadDataUserTask4.CanReadUncommitedData);
			MetaPathParameterValues.Add("4ed4d571-44c8-4a27-a65a-4131b67102cd", () => ReadDataUserTask4.ResultEntityCollection);
			MetaPathParameterValues.Add("b38a94a0-f6e4-4feb-8786-12e8b069d09b", () => ReadDataUserTask4.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("a4fde4e6-b89d-4d7a-9c00-a5b453b8f484", () => ReadDataUserTask4.IgnoreDisplayValues);
			MetaPathParameterValues.Add("c418c43f-8865-4baa-9f1a-2d3f8b70bbe9", () => ReadDataUserTask4.ResultCompositeObjectList);
			MetaPathParameterValues.Add("32ec9b82-a1f1-4152-bbff-c3c4dccaa240", () => ReadDataUserTask4.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("838069b1-290a-4dfe-8a76-789d0b22ee56", () => ChangeDataUserTask2.EntitySchemaUId);
			MetaPathParameterValues.Add("9aae8482-6a87-492c-a2eb-c2cc69f1a33a", () => ChangeDataUserTask2.IsMatchConditions);
			MetaPathParameterValues.Add("7f1e55bc-3c69-4e8d-ab13-4c60e7f1c2b5", () => ChangeDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("75fd7f6c-28fc-4c7c-bf17-b30ef4fedf91", () => ChangeDataUserTask2.RecordColumnValues);
			MetaPathParameterValues.Add("365c5862-4aa2-4ebe-ae16-a748f2bce5dc", () => ChangeDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("8a822ce2-db65-4f4c-9559-c00347db1b23", () => ReadDataUserTask5.DataSourceFilters);
			MetaPathParameterValues.Add("94072bca-6162-4e8e-b862-b76f105bc46a", () => ReadDataUserTask5.ResultType);
			MetaPathParameterValues.Add("5c651444-a144-4931-821b-e26e9fb71f60", () => ReadDataUserTask5.ReadSomeTopRecords);
			MetaPathParameterValues.Add("d6933145-11a6-41e0-a083-8e3d0f5cb15f", () => ReadDataUserTask5.NumberOfRecords);
			MetaPathParameterValues.Add("41bdacb0-38ba-4c89-b2bd-9e26c44910c6", () => ReadDataUserTask5.FunctionType);
			MetaPathParameterValues.Add("0f225841-4a24-46aa-9ab5-c60099fe3a63", () => ReadDataUserTask5.AggregationColumnName);
			MetaPathParameterValues.Add("e30c8bb4-f01c-440f-8a45-b98eb8058e08", () => ReadDataUserTask5.OrderInfo);
			MetaPathParameterValues.Add("82d3dd51-cb6e-431e-b725-0622ebd71499", () => ReadDataUserTask5.ResultEntity);
			MetaPathParameterValues.Add("1397425e-4ae0-4803-9260-930a308717ad", () => ReadDataUserTask5.ResultCount);
			MetaPathParameterValues.Add("3bbdd8db-b7fb-45ce-a565-73afafc90561", () => ReadDataUserTask5.ResultIntegerFunction);
			MetaPathParameterValues.Add("1a775799-e9f7-4e06-9c16-7b002d6e9c48", () => ReadDataUserTask5.ResultFloatFunction);
			MetaPathParameterValues.Add("a39c131b-b8b8-409b-b619-3e350352fc5e", () => ReadDataUserTask5.ResultDateTimeFunction);
			MetaPathParameterValues.Add("2f2d12aa-73bf-4cc5-9ed8-61b85e547204", () => ReadDataUserTask5.ResultRowsCount);
			MetaPathParameterValues.Add("2d5e1b39-c1bd-463e-aa87-b6982b2c0502", () => ReadDataUserTask5.CanReadUncommitedData);
			MetaPathParameterValues.Add("ecdc24d5-dc69-4e45-9cdc-bbbc660c2d5e", () => ReadDataUserTask5.ResultEntityCollection);
			MetaPathParameterValues.Add("93186690-48ea-44b2-a2cf-18064e1d9d6d", () => ReadDataUserTask5.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("dc93e612-6e5f-4209-89e2-bf47d63b7bf2", () => ReadDataUserTask5.IgnoreDisplayValues);
			MetaPathParameterValues.Add("0b0acbf2-552b-49a1-881d-d5ab49e8ca40", () => ReadDataUserTask5.ResultCompositeObjectList);
			MetaPathParameterValues.Add("f4024a32-fd2b-4005-9d29-010f490f38c1", () => ReadDataUserTask5.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
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
			var cloneItem = (AnalyzeCaseSatisfactionLevel)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


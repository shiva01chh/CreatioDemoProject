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

	#region Class: LeadManagementHandoffSchema

	/// <exclude/>
	public class LeadManagementHandoffSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementHandoffSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementHandoffSchema(LeadManagementHandoffSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementHandoff";
			UId = new Guid("7ee7590a-758b-4ee3-990c-188743946765");
			CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"8.1.0.6704";
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
			Tag = @"LeadManagementHandoff";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765");
			Version = 0;
			PackageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("54a0a9d9-5cdd-45ca-8269-7e1318e707b2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
		}

		protected virtual void InitializeReadLeadDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fa68c1b9-9e12-4b99-bdde-6eb1806d8874"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,100,21,201,150,45,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,191,98,203,52,193,236,127,175,108,103,83,200,161,148,222,10,58,140,70,243,222,188,121,140,230,123,63,126,244,117,192,161,116,80,143,152,76,7,91,18,89,57,167,242,84,81,169,11,160,130,113,73,65,113,69,153,144,76,240,76,2,58,36,73,11,13,150,100,67,239,173,15,36,241,1,155,177,188,157,127,147,134,97,194,228,222,173,151,175,230,132,13,124,91,26,8,14,78,105,212,84,230,172,162,2,171,138,42,3,134,58,151,233,170,16,74,112,52,100,211,194,164,176,58,214,83,89,229,41,21,144,58,170,92,90,209,130,129,112,150,27,237,88,74,146,26,93,216,63,245,3,142,163,239,218,114,198,215,248,230,185,143,42,183,222,187,174,158,154,150,36,13,6,184,134,112,42,9,32,67,145,27,160,70,232,156,10,135,113,210,76,91,154,65,37,83,169,144,23,92,146,196,64,31,22,90,114,176,36,177,16,224,59,212,19,174,204,179,143,26,211,140,113,149,23,17,203,51,67,69,150,50,170,10,37,169,179,133,211,152,21,90,87,246,226,215,167,201,199,216,143,87,83,131,131,55,47,182,99,244,175,27,202,217,116,109,24,186,122,161,190,90,203,111,240,41,108,230,190,60,253,216,6,10,49,191,128,200,57,153,70,220,213,30,219,176,111,77,103,125,251,176,113,158,207,17,210,244,48,248,241,226,194,254,113,130,154,36,131,127,56,253,209,173,221,52,134,174,249,143,70,77,226,152,145,35,46,217,42,119,217,65,235,199,190,134,231,245,94,146,119,143,83,23,62,124,70,176,91,68,222,32,74,114,71,114,1,12,180,213,52,55,214,210,117,43,84,90,196,29,69,158,113,133,146,201,42,189,35,81,197,63,112,223,30,198,47,63,219,203,31,216,84,31,223,199,236,155,196,245,5,89,206,127,35,231,124,92,4,29,207,241,252,2,68,247,49,72,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("99786611-0f56-4e3c-8f29-a4185ad1f427"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c21a605f-a60b-42ed-9061-294cc87b69a0"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8bb1e66c-1b41-4f67-ab42-57cdc5d866a6"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("745423dc-b077-4526-8e74-98d8ad204cb8"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e1878c2-6cac-4d8b-baa8-a59f16943d8b"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1053c0e9-6404-4b90-bd4a-07157c475327"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("8bc11220-5b0b-4d4e-a16c-25109fbcecd2"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("952c2d22-d6b6-4a51-82ac-ec6cfa9a867e"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ff499ce0-d575-4f90-b31d-15c099b5f8ee"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ddfda365-0d3d-45c9-84c5-ef97a50abd3e"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7ced0725-a5ff-48ab-8329-db8cd92d45fc"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1bdef657-82b6-4e4c-9cba-7cc3f773ead3"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0e7bc406-b400-4ee2-8857-94f4a2ed4291"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("a4c0fd5e-3b7e-4c6a-bf78-0b172e842a9f"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ed0eae90-a660-43ec-85fa-c1bc0b2c7a5c"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4fb15793-1f5f-4afb-a9c5-7ee6d16f6cd6"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("6fcf7170-2737-4d10-bb96-7b591a1f7593"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("156dfda2-8f07-4454-b745-3aca84f7ef95"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeActivityUserTaskBANTParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5141e1f7-4af9-4bf4-b6d1-8874c0d2dc5f"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Contact customer, specify need, budget, decision-making role.",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("5b4637a8-7fc7-40e0-bfac-9cb675816ccf"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ActivityCategory",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			activityCategoryParameter.SourceValue = new ProcessSchemaParameterValue(activityCategoryParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"f51c4643-58e6-df11-971b-001d60e938c6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("0902eded-b1a4-4f75-aa93-09fdf0aac605"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{cf8af50c-5791-4531-ac0c-21f2700e557b}].[Parameter:{8bc11220-5b0b-4d4e-a16c-25109fbcecd2}].[EntityColumn:{52817348-4c01-4015-a766-cb10c7b554c8}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ba47d7d3-1ca5-41d1-9d6b-42ce60295158"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Duration",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationParameter.SourceValue = new ProcessSchemaParameterValue(durationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"60",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fdd5f4d6-8792-40d3-a46d-47a3545e3715"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"DurationPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationPeriodParameter.SourceValue = new ProcessSchemaParameterValue(durationPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5f4c4e07-469e-451a-88f4-305e2f6792b2"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"StartIn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInParameter.SourceValue = new ProcessSchemaParameterValue(startInParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("abdfdb50-a1ba-4d57-9207-b1dd297f6e84"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"StartInPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInPeriodParameter.SourceValue = new ProcessSchemaParameterValue(startInPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6ff80f1-90c6-416a-90bb-260e00d506f7"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"RemindBefore",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforeParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4e14fc2e-ed85-4967-92f6-4ffd68e2401a"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"RemindBeforePeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforePeriodParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforePeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0685b12b-443e-4c64-ab26-d4859f0c8c4b"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ShowInScheduler",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showInSchedulerParameter.SourceValue = new ProcessSchemaParameterValue(showInSchedulerParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("53d8ba23-d026-4fd0-9523-ad2d59cb13a1"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("54f32772-50b2-49b4-a2a7-eee12cea8efc"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Lead",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{54a0a9d9-5cdd-45ca-8269-7e1318e707b2}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("531d1563-ba9a-4e91-98ce-d35b182bca5f"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{cf8af50c-5791-4531-ac0c-21f2700e557b}].[Parameter:{8bc11220-5b0b-4d4e-a16c-25109fbcecd2}].[EntityColumn:{32949ae4-ff13-48f5-9f5d-45a74558ea55}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("fdb90180-2f4b-4831-b679-403593dd3b6f"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{cf8af50c-5791-4531-ac0c-21f2700e557b}].[Parameter:{8bc11220-5b0b-4d4e-a16c-25109fbcecd2}].[EntityColumn:{ad490d58-054a-4d85-9246-dd8466eb3983}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("41dcb696-2cb1-4512-b3cf-dd1a7583a4ff"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Opportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityParameter.SourceValue = new ProcessSchemaParameterValue(opportunityParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("d329e26e-4b48-4034-a14b-d1f9fe83945f"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Invoice",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			invoiceParameter.SourceValue = new ProcessSchemaParameterValue(invoiceParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(invoiceParameter);
			var documentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				UId = new Guid("a61fc569-1cd9-4ee0-913c-ffb7359a1776"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Document",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			documentParameter.SourceValue = new ProcessSchemaParameterValue(documentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(documentParameter);
			var incidentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f7625075-971c-47b4-b67f-f12b29f07881"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Incident",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			incidentParameter.SourceValue = new ProcessSchemaParameterValue(incidentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(incidentParameter);
			var caseParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("71e2fad8-087d-4d30-853f-4284671382e2"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Case",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			caseParameter.SourceValue = new ProcessSchemaParameterValue(caseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(caseParameter);
			var activityResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b9471d7d-f83c-40ed-8479-ac97045d505d"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ActivityResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activityResultParameter.SourceValue = new ProcessSchemaParameterValue(activityResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activityResultParameter);
			var currentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("42791514-cf69-4e4b-a09a-b627acdcf9e8"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"CurrentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(currentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(currentActivityIdParameter);
			var isActivityCompletedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("85441486-29f4-4732-bedf-744579a8ec72"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"IsActivityCompleted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isActivityCompletedParameter.SourceValue = new ProcessSchemaParameterValue(isActivityCompletedParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var executionContextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1ec1c9c1-eadf-4d15-a0fa-5e9731a46b43"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ExecutionContext",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			executionContextParameter.SourceValue = new ProcessSchemaParameterValue(executionContextParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executionContextParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4c515728-a780-4846-a088-022faab38f6a"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"InformationOnStep",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Contact customer, get in touch with contact persons, define interest and BANT. As a result, either proceed to handoff, order or continue lead nurturing.",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var orderParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("5cf10363-3ca3-4fcf-a2e0-2c6f612c9aef"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Order",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			orderParameter.SourceValue = new ProcessSchemaParameterValue(orderParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(orderParameter);
			var requestsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38749114-70e5-4e48-85a8-d4f5a5ff24c3"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Requests",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			requestsParameter.SourceValue = new ProcessSchemaParameterValue(requestsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(requestsParameter);
			var listingParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("725e7498-44eb-49c5-8104-b615cd2a44b3"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Listing",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			listingParameter.SourceValue = new ProcessSchemaParameterValue(listingParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(listingParameter);
			var propertyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("24e0015e-591a-49d6-b47e-f60c309ab061"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Property",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			propertyParameter.SourceValue = new ProcessSchemaParameterValue(propertyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(propertyParameter);
			var contractParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				UId = new Guid("ed86a088-1c5e-4485-b084-878f1a8d39df"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Contract",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contractParameter.SourceValue = new ProcessSchemaParameterValue(contractParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contractParameter);
			var projectParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				UId = new Guid("b14902c4-2013-48e9-b69e-d810c180118b"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Project",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			projectParameter.SourceValue = new ProcessSchemaParameterValue(projectParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(projectParameter);
			var problemParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230"),
				UId = new Guid("1138fd23-4b02-4812-9de6-6ecb917db660"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Problem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			problemParameter.SourceValue = new ProcessSchemaParameterValue(problemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(problemParameter);
			var changeParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("de5c8d59-d372-407d-8c09-f0523e057e40"),
				UId = new Guid("948d7cec-52ca-4a20-9991-67a3f04cc7c2"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Change",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			changeParameter.SourceValue = new ProcessSchemaParameterValue(changeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(changeParameter);
			var releaseParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				UId = new Guid("4b5d863d-2006-4c46-8f37-592fbfa512c0"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Release",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			releaseParameter.SourceValue = new ProcessSchemaParameterValue(releaseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(releaseParameter);
			var queueItemParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("aadf2fcd-684b-4414-8317-bf9879e97569"),
				UId = new Guid("af9569bc-af68-4326-b7bd-5c4ef9e17ea0"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"QueueItem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			queueItemParameter.SourceValue = new ProcessSchemaParameterValue(queueItemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(queueItemParameter);
			var applicationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("094292f5-1d0c-46e2-a6f8-eb2e20a06d3e"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Application",
				SourceParameterUId = Guid.Empty,
				Tag = @"EntityColumnValue",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			applicationParameter.SourceValue = new ProcessSchemaParameterValue(applicationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(applicationParameter);
			var finApplicationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1428d031-6da1-4c3b-becc-0d2348c4e851"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"FinApplication",
				SourceParameterUId = Guid.Empty,
				Tag = @"EntityColumnValue",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			finApplicationParameter.SourceValue = new ProcessSchemaParameterValue(finApplicationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(finApplicationParameter);
			var activityPriorityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b934f48c-5dea-49b9-bde3-697cb4be5d8b"),
				UId = new Guid("1aef7d2c-d9f4-44ff-a907-47abf8075765"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ActivityPriority",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			activityPriorityParameter.SourceValue = new ProcessSchemaParameterValue(activityPriorityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ab96fa02-7fe6-df11-971b-001d60e938c6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			parametrizedElement.Parameters.Add(activityPriorityParameter);
		}

		protected virtual void InitializeChangeLeadStateToNoInterestParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("2c070493-7483-4c5e-a83b-3eb1c5d78ab7"),
				ContainerUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
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
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c600955c-8b94-4c98-aee1-79c3c61d4140"),
				ContainerUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("24bf952c-9579-4dcf-981f-f2cce1dbc830"),
				ContainerUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
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
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,36,21,127,72,182,228,30,151,109,89,40,105,160,105,41,36,75,24,73,163,172,192,95,177,101,154,96,246,191,87,182,179,41,228,80,74,111,5,29,70,163,121,111,222,60,70,243,189,31,63,250,58,224,80,57,168,71,164,211,193,86,36,211,165,40,108,94,178,44,213,156,113,11,130,169,210,10,166,1,10,238,20,215,153,72,8,109,161,193,138,108,232,189,245,129,80,31,176,25,171,219,249,55,105,24,38,164,247,110,189,124,53,39,108,224,219,210,128,167,224,164,66,197,74,145,104,198,81,107,38,13,24,230,92,174,116,193,37,79,209,144,77,11,231,82,160,80,154,153,88,203,184,118,57,147,90,228,12,184,116,73,6,34,229,186,32,180,70,23,246,79,253,128,227,232,187,182,154,241,53,190,121,238,163,202,173,247,174,171,167,166,37,180,193,0,215,16,78,21,1,76,144,11,3,204,112,37,24,119,88,50,200,149,101,57,232,50,43,37,166,69,90,18,106,160,15,11,45,57,88,66,45,4,248,14,245,132,43,243,236,23,191,242,36,149,162,136,216,52,55,140,231,89,194,100,33,75,230,108,225,20,230,133,82,218,94,252,250,52,249,24,251,241,106,106,112,240,230,197,118,140,254,117,67,53,155,174,13,67,87,47,212,87,107,249,13,62,133,205,220,151,167,31,219,64,33,230,23,16,57,211,105,196,93,237,177,13,251,214,116,214,183,15,27,231,249,28,33,77,15,131,31,47,46,236,31,39,168,9,29,252,195,233,143,110,237,166,49,116,205,127,52,42,141,99,70,142,184,100,171,220,101,7,173,31,251,26,158,215,123,69,222,61,78,93,248,240,25,193,110,17,121,131,168,200,29,17,28,18,80,86,49,97,172,101,235,86,200,172,136,59,138,105,158,74,44,147,82,103,119,36,170,248,7,238,219,195,248,229,103,123,249,3,155,234,227,251,152,125,147,184,190,32,171,249,111,228,156,143,139,160,227,57,158,95,209,224,137,218,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0c8a0e7e-306d-4ecc-b6cd-fbb09ef8707a"),
				ContainerUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
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
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,83,77,107,27,49,20,252,43,65,201,209,50,250,90,125,248,90,183,16,72,66,104,210,92,226,28,158,164,167,100,169,237,53,187,235,210,212,248,191,87,86,108,108,151,166,132,64,47,165,58,104,89,73,51,243,244,70,179,34,103,253,243,2,201,136,220,98,219,66,215,164,126,248,161,105,113,120,221,54,1,187,110,120,209,4,152,214,63,192,79,241,26,90,152,97,143,237,29,76,151,216,93,212,93,63,56,57,134,145,1,57,251,86,118,201,232,126,69,206,123,156,125,57,143,153,221,7,155,156,230,146,66,76,21,85,18,29,181,149,229,212,1,72,225,153,67,107,55,224,208,76,151,179,249,37,246,112,13,253,19,25,173,72,97,203,4,206,11,227,130,209,148,137,204,162,82,197,41,132,168,169,116,82,35,103,218,249,168,200,122,64,186,240,132,51,40,162,123,176,226,144,172,203,154,166,98,158,42,244,158,218,0,129,166,36,157,215,202,42,142,97,3,222,158,223,3,239,79,47,154,230,235,114,49,20,49,241,16,172,166,90,152,64,85,204,19,68,158,40,139,104,17,61,120,197,194,48,25,203,180,142,249,146,70,98,150,201,199,189,119,142,162,50,38,5,239,148,23,246,244,97,35,20,235,110,49,133,231,187,87,245,174,16,227,201,12,250,101,91,247,207,195,171,166,63,169,231,185,243,216,245,24,95,40,22,71,110,28,146,172,38,47,166,78,200,104,242,154,173,219,239,77,233,214,177,177,191,122,58,33,131,9,185,105,150,109,216,48,202,205,207,174,199,69,129,109,7,253,205,180,27,47,28,5,118,9,115,120,196,246,42,43,22,120,217,26,67,15,69,252,54,215,189,35,246,194,85,204,228,38,27,4,151,219,169,5,181,145,3,117,220,249,36,141,20,41,137,130,254,140,41,183,102,30,240,184,176,183,120,86,240,69,121,95,204,238,249,229,149,249,114,58,45,2,93,185,255,230,61,111,11,223,238,140,15,140,60,96,104,98,157,106,140,231,243,119,182,106,140,169,80,126,106,218,143,223,115,206,234,249,227,214,177,3,233,253,153,113,152,109,215,215,100,189,30,28,6,207,26,233,28,51,140,98,4,69,149,144,130,130,118,156,162,12,129,89,29,140,136,236,143,193,243,129,5,17,53,163,21,200,72,115,86,24,5,80,72,131,102,8,198,104,20,76,255,205,224,9,169,120,136,156,86,94,230,220,135,44,239,24,231,84,39,163,157,196,164,81,169,97,197,33,6,137,129,202,138,229,67,158,231,26,89,22,180,30,165,103,200,121,98,111,13,222,77,159,95,231,255,192,189,47,112,111,240,234,95,12,220,195,250,39,147,220,118,68,71,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("27632760-23b5-4cb3-a0b9-909d22873875"),
				ContainerUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
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

		protected virtual void InitializeChangeLeadNurturingParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("091ab17a-49f8-4d9e-be81-1ca9c9dcb055"),
				ContainerUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
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
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cbaa2dfb-5f4a-4bfc-9df0-93ddbbb25a13"),
				ContainerUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6f0df01f-2acd-4bc7-adec-34cfc25c9246"),
				ContainerUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
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
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,75,107,220,48,16,254,47,58,244,100,21,217,150,109,201,61,46,219,178,80,210,64,211,82,72,150,48,146,70,89,129,95,177,100,154,96,246,191,87,182,179,41,228,80,74,111,5,29,70,99,127,143,249,24,205,247,206,127,116,77,192,177,182,208,120,76,166,131,169,9,67,171,37,23,5,197,146,43,202,81,11,10,10,56,69,76,141,201,76,197,180,209,36,233,160,197,154,108,232,189,113,129,36,46,96,235,235,219,249,55,105,24,39,76,238,237,122,249,170,79,216,194,183,69,128,167,96,133,68,73,171,130,45,2,74,81,161,65,83,107,115,169,74,46,120,138,81,96,245,82,9,166,51,80,150,166,86,49,202,45,147,20,140,150,148,41,169,37,242,50,203,181,33,73,131,54,236,159,134,17,189,119,125,87,207,248,90,223,60,15,209,229,166,189,235,155,169,237,72,210,98,128,107,8,167,154,0,50,228,133,6,170,185,44,34,59,86,20,114,105,104,14,170,202,42,129,105,153,86,36,209,48,132,133,150,28,162,148,129,0,223,161,153,112,101,158,93,244,152,229,44,21,69,25,177,105,174,41,207,51,70,69,41,42,106,77,105,37,230,165,148,202,92,242,250,52,185,88,59,127,53,181,56,58,253,18,59,198,252,250,177,158,117,223,133,177,111,22,234,171,245,247,27,124,10,91,184,47,159,126,108,3,133,216,95,64,228,156,76,30,119,141,195,46,236,59,221,27,215,61,108,156,231,115,132,180,3,140,206,95,82,216,63,78,208,144,100,116,15,167,63,166,181,155,124,232,219,255,104,212,36,142,25,57,226,146,173,118,151,29,52,206,15,13,60,175,247,154,188,123,156,250,240,225,51,130,217,42,242,6,81,147,59,82,112,96,32,141,164,133,54,134,174,91,33,178,50,238,40,166,121,42,176,98,149,202,238,72,116,241,15,220,183,7,255,229,103,119,121,3,155,235,227,251,216,125,211,184,190,32,235,249,111,236,156,143,139,161,227,57,158,95,203,128,158,28,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38717ef0-c344-40ce-a5f4-e39c87df0d1d"),
				ContainerUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
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
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,65,110,219,48,16,252,74,160,228,232,53,72,145,162,72,95,235,22,8,144,4,65,147,230,18,231,176,92,46,19,161,182,101,72,114,208,52,240,223,75,43,54,108,23,77,97,20,232,165,40,15,18,68,106,102,86,59,59,122,205,206,186,151,5,103,163,236,150,155,6,219,58,118,195,15,117,195,195,235,166,38,110,219,225,69,77,56,173,190,163,159,242,53,54,56,227,142,155,59,156,46,185,189,168,218,110,112,114,8,203,6,217,217,115,127,154,141,238,95,179,243,142,103,95,206,67,98,47,75,227,189,160,8,69,44,29,104,68,5,22,165,134,130,116,105,92,48,161,40,215,96,170,167,203,217,252,146,59,188,198,238,41,27,189,102,61,91,34,112,62,47,29,149,6,68,46,21,232,88,72,64,10,6,148,83,134,165,48,206,7,157,173,6,89,75,79,60,195,94,116,7,214,18,163,117,236,160,44,132,7,205,222,131,37,36,136,81,57,111,180,213,146,105,13,222,188,191,3,222,159,94,212,245,215,229,98,152,135,40,137,172,1,147,151,4,58,164,11,6,25,65,4,182,204,30,189,22,52,44,188,10,82,104,3,145,164,1,93,144,5,44,80,66,238,108,136,100,139,178,208,230,244,97,45,20,170,118,49,197,151,187,119,245,174,152,195,201,12,187,101,83,117,47,195,113,213,82,253,204,13,135,55,248,226,192,137,125,130,215,201,155,161,147,108,52,121,207,210,205,253,166,239,212,161,169,63,251,57,201,6,147,236,166,94,54,180,102,84,235,135,109,127,123,5,177,89,240,139,203,118,189,113,244,176,75,156,227,35,55,87,73,177,135,247,71,99,236,176,23,191,77,117,111,137,125,238,10,81,166,6,151,140,105,94,216,228,96,131,68,112,210,249,168,74,149,199,152,247,232,207,28,83,95,230,196,135,133,29,227,87,143,239,149,119,197,108,71,47,237,204,151,211,105,47,208,246,223,191,158,229,77,225,155,147,241,158,137,123,12,117,168,98,197,225,124,254,135,173,26,115,236,41,63,213,205,199,111,41,99,213,252,113,227,216,158,244,238,157,49,205,54,251,171,108,181,26,236,135,78,68,212,214,146,135,148,141,144,66,23,8,60,7,132,168,108,140,194,4,227,4,253,54,116,158,4,229,193,8,40,80,37,2,171,5,32,106,6,50,130,49,69,154,115,97,254,102,232,114,165,37,5,9,41,88,41,243,148,228,157,144,18,76,76,255,12,197,209,176,214,67,169,41,146,209,26,88,113,170,209,149,12,54,253,42,128,131,86,105,88,188,21,78,29,25,186,155,46,77,231,58,108,93,83,249,101,87,213,243,255,113,59,50,110,71,56,245,47,198,237,97,245,3,126,255,5,18,65,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7ac82dc6-daa3-46a3-8567-fede289c90ea"),
				ContainerUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
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

		protected virtual void InitializeAutoGeneratedPageHandoffParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("37ca1e6d-f9a7-4c7f-ba6c-9ca142ff1579"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Title",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			titleParameter.SourceValue = new ProcessSchemaParameterValue(titleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Proceed to handoff: Information",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("92313c1a-6c83-4de1-b493-4b387b234357"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5854a389-d5a2-4dce-814f-9c06510637e6"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Specify information that is required for proceeding to handoff",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41d66075-70c0-453a-8022-cff5949370b2"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"EntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entityIdParameter.SourceValue = new ProcessSchemaParameterValue(entityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var buttonsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3111f593-81b1-42b5-99a0-cd853a60b279"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Buttons",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			buttonsParameter.SourceValue = new ProcessSchemaParameterValue(buttonsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""853857d6-cc8a-4f66-a1ca-f7261718597c"",""name"":""SaveButton"",""caption"":""Save"",""style"":""green"",""performValidation"":true,""isEnabled"":true,""generateSignal"":""""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(buttonsParameter);
			var elementsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d88c0edd-7a1d-4087-b13e-ce975c3e925f"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Elements",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			elementsParameter.SourceValue = new ProcessSchemaParameterValue(elementsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""3a8ae276-d1a6-4833-8edd-18a3802457a6"",""name"":""LeadType"",""caption"":""Need type"",""controlEditType"":""SelectionField"",""isRequired"":true,""dataFilter"":"""",""controlDataValueType"":""11"",""dataSource"":""e0dbeb22-4932-4eee-a8f2-a247a5fce888""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""396b79de-3b3c-45d3-aea7-bdab8f0a023e"",""name"":""Budget"",""caption"":""Budget, base currency"",""controlEditType"":""4"",""isRequired"":false},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""55254183-6074-4e56-9aab-59ca46e386f2"",""name"":""OpportunityResponsible"",""caption"":""Sales owner"",""controlEditType"":""SelectionField"",""isRequired"":false,""dataFilter"":"""",""controlDataValueType"":""10"",""dataSource"":""16be3651-8fe2-4159-8dd0-a803d4683dd3""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""476a3574-3ae8-49f9-a144-15e4daebec38"",""name"":""OpportunityDepartment"",""caption"":""Sales division"",""controlEditType"":""SelectionField"",""isRequired"":false,""dataFilter"":"""",""controlDataValueType"":""11"",""dataSource"":""5d8456b4-15e0-4de5-b0e5-afb10f6795c0""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""968839fa-bdc5-40db-84fc-b1c7ba66460b"",""name"":""MeetingTime"",""caption"":""Meeting date and time"",""controlEditType"":""DateTimeField"",""isRequired"":false,""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""1cda6777-d842-406e-9075-3c837bf46d26"",""name"":""DecisionDate"",""caption"":""Decision timeline"",""controlEditType"":""DateTimeField"",""isRequired"":false,""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""765a88b1-8502-4f19-801f-b1be417dd065"",""name"":""Comment"",""caption"":""Notes"",""controlEditType"":""1"",""isMultiline"":true,""isRequired"":false}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(elementsParameter);
			var extendedClientModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7d35cac3-bad2-40c8-842e-1b639ac400c8"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"ExtendedClientModule",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			extendedClientModuleParameter.SourceValue = new ProcessSchemaParameterValue(extendedClientModuleParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(extendedClientModuleParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f2e508ca-4b2f-4b48-976b-52653e3dbe10"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"EntryPointId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entryPointIdParameter.SourceValue = new ProcessSchemaParameterValue(entryPointIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entryPointIdParameter);
			var pressedButtonCodeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("478f0294-5119-41e8-ab5b-bc27d9882a36"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"PressedButtonCode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			pressedButtonCodeParameter.SourceValue = new ProcessSchemaParameterValue(pressedButtonCodeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pressedButtonCodeParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("9d600d04-bc01-4cd3-86a4-a9bb56f488b7"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a698c3a6-4b9a-4404-9178-0cd67c688925"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("03fc2e34-8cdc-4158-9dd1-dafee46392f4"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"InformationOnStep",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Use the page to specify information about customer's budget, decision date, need type (the BANT criteria) and the information required to create an opportunity (owner and sales division).",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var isRunningParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97a4e728-73b0-4b7e-8a0e-313bec8ab330"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"IsRunning",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isRunningParameter.SourceValue = new ProcessSchemaParameterValue(isRunningParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isRunningParameter);
			var currentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b1dd92e2-b196-4567-886d-afd46f7d61cc"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"CurrentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(currentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(currentActivityIdParameter);
			var createActivityParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a216e8c0-bfd3-4e51-a232-a26d5ccffb07"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"CreateActivity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			createActivityParameter.SourceValue = new ProcessSchemaParameterValue(createActivityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(createActivityParameter);
			var activityPriorityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b934f48c-5dea-49b9-bde3-697cb4be5d8b"),
				UId = new Guid("1321bb99-0d62-4a4a-8d29-353c09a23d4d"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"ActivityPriority",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			activityPriorityParameter.SourceValue = new ProcessSchemaParameterValue(activityPriorityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ab96fa02-7fe6-df11-971b-001d60e938c6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(activityPriorityParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("586b06de-5dfb-43be-afb2-f574881bca46"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"StartIn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInParameter.SourceValue = new ProcessSchemaParameterValue(startInParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d26ff5a0-6991-4a71-aa5a-46feacf7537c"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"StartInPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInPeriodParameter.SourceValue = new ProcessSchemaParameterValue(startInPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("081d3969-dd55-41f7-bf2f-30cea119fbc9"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Duration",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationParameter.SourceValue = new ProcessSchemaParameterValue(durationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fe50e312-3895-4702-bdfe-90fe3728bb50"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"DurationPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationPeriodParameter.SourceValue = new ProcessSchemaParameterValue(durationPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cbd596b3-6a07-460f-aac7-582c3ffb6463"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"ShowInScheduler",
				SourceParameterUId = Guid.Empty,
				Tag = @"EntityColumnValue",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showInSchedulerParameter.SourceValue = new ProcessSchemaParameterValue(showInSchedulerParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea9ca265-54b9-47f1-a9f0-3901f038311b"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"RemindBefore",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforeParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d08aec7b-ebfe-4519-a9c6-a4dbe2b73789"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"RemindBeforePeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforePeriodParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforePeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var activityResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51506cad-a901-4309-aee0-5a656a758325"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"ActivityResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activityResultParameter.SourceValue = new ProcessSchemaParameterValue(activityResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activityResultParameter);
			var isActivityCompletedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e4e0c873-d65e-4828-bcf1-ffe5ee544361"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"IsActivityCompleted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isActivityCompletedParameter.SourceValue = new ProcessSchemaParameterValue(isActivityCompletedParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var leadTypeParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("3a8ae276-d1a6-4833-8edd-18a3802457a6"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"LeadType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadTypeParameter.SourceValue = new ProcessSchemaParameterValue(leadTypeParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{5c696704-62e8-4503-86bf-ed66c3dd63d5}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(leadTypeParameter);
			var budgetParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("396b79de-3b3c-45d3-aea7-bdab8f0a023e"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"Budget",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			budgetParameter.SourceValue = new ProcessSchemaParameterValue(budgetParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{882bf1d7-3d1f-4208-80ca-bf913c8d4f2f}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(budgetParameter);
			var opportunityResponsibleParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("55254183-6074-4e56-9aab-59ca46e386f2"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"OpportunityResponsible",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityResponsibleParameter.SourceValue = new ProcessSchemaParameterValue(opportunityResponsibleParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{52817348-4c01-4015-a766-cb10c7b554c8}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(opportunityResponsibleParameter);
			var meetingTimeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("968839fa-bdc5-40db-84fc-b1c7ba66460b"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"MeetingTime",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			meetingTimeParameter.SourceValue = new ProcessSchemaParameterValue(meetingTimeParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{efc32501-4c3a-4500-8fa4-1d70c6bf26f9}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(meetingTimeParameter);
			var commentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("765a88b1-8502-4f19-801f-b1be417dd065"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"Comment",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			commentParameter.SourceValue = new ProcessSchemaParameterValue(commentParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0}].[Parameter:{946dd2c0-da26-457d-ad8c-4ba3167aa54d}].[EntityColumn:{070b689f-c9d8-46e3-bb52-bcb1f430f5cf}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(commentParameter);
			var decisionDateParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1cda6777-d842-406e-9075-3c837bf46d26"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"DecisionDate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			decisionDateParameter.SourceValue = new ProcessSchemaParameterValue(decisionDateParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{4c3a6f1b-99d3-4baf-8954-076274d0675c}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(decisionDateParameter);
			var opportunityDepartmentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				UId = new Guid("476a3574-3ae8-49f9-a144-15e4daebec38"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"OpportunityDepartment",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityDepartmentParameter.SourceValue = new ProcessSchemaParameterValue(opportunityDepartmentParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{a40a64fa-a0ea-40e6-9476-a59c1dfbb93f}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(opportunityDepartmentParameter);
		}

		protected virtual void InitializeReadLeadForHandoffParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6e73bc51-9c3d-46b9-99dc-388c60d1dae1"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,100,21,91,146,109,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,191,98,201,52,193,236,127,175,108,103,83,200,161,148,222,10,58,140,70,243,222,188,121,140,230,123,231,63,186,38,224,88,89,104,60,38,211,193,84,36,67,38,24,160,162,66,151,37,21,32,107,170,108,94,83,97,10,100,41,207,121,46,107,146,116,208,98,69,54,244,222,184,64,18,23,176,245,213,237,252,155,52,140,19,38,247,118,189,124,213,39,108,225,219,210,64,100,96,165,138,13,202,60,141,180,88,215,84,106,208,212,90,174,234,66,72,145,161,38,155,22,45,176,96,32,74,90,167,44,143,165,220,208,90,3,82,174,114,205,153,176,38,183,146,36,13,218,176,127,26,70,244,222,245,93,53,227,107,124,243,60,68,149,91,239,93,223,76,109,71,146,22,3,92,67,56,85,4,48,69,145,107,160,90,168,200,110,177,164,192,149,161,28,234,146,149,18,179,34,43,73,162,97,8,11,45,57,24,146,24,8,240,29,154,9,87,230,217,69,141,140,167,153,204,139,136,205,184,166,130,179,148,202,66,150,212,154,194,42,228,133,82,181,185,248,245,105,114,49,118,254,106,106,113,116,250,197,118,140,254,245,99,53,235,190,11,99,223,44,212,87,107,249,13,62,133,205,220,151,167,31,219,64,33,230,23,16,57,39,147,199,93,227,176,11,251,78,247,198,117,15,27,231,249,28,33,237,0,163,243,23,23,246,143,19,52,36,25,221,195,233,143,110,237,38,31,250,246,63,26,53,137,99,70,142,184,100,171,220,101,7,141,243,67,3,207,235,189,34,239,30,167,62,124,248,140,96,182,136,188,65,84,228,142,228,2,82,80,70,209,92,27,67,215,173,144,172,136,59,138,25,207,36,150,105,89,179,59,18,85,252,3,247,237,193,127,249,217,93,254,192,166,250,248,62,102,223,36,174,47,200,106,254,27,57,231,227,34,232,120,142,231,23,149,211,217,112,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c3ef0854-9dec-41d4-8d16-407475422cc6"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("976150fd-e561-4fa6-9f3f-911949e5c42c"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51bcbfaa-b77d-4c21-947e-02e0676d3545"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("663137f9-795a-4269-b94a-83f9c02d10da"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b1c37761-25d6-438c-bdbc-43b2a149b1ca"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("73074895-abf7-4e2d-ad95-2629a87fc3d5"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("69f1e87b-3dd8-44cf-8c4f-97bd0653ad06"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("225fc2e7-3024-4f80-b9c4-c881e8aadeed"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("38d606ea-c1d2-4017-915e-893f7f96a610"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d8b37a80-9357-459a-9ca1-945f0af37bb5"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3207b919-eb4b-44b7-9c43-5080d06b54a1"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f24a8102-fb92-4bc4-b65f-c475f479a843"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8f0a63b7-c987-4e12-93c8-76a709a96645"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("4af22b59-f62b-47c3-ad50-2c78bf148bf7"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a1770417-d693-4416-9df8-379715d76f1e"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e6e3bcd-5e15-4652-84f8-98664792001d"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a50e4bc1-e2da-47e3-870d-311693034d8d"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4cd0ffd2-f5b3-400d-8196-85aa7dcced3e"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeReadActivityDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b7a60eae-1035-42aa-a3a1-1572936331df"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,111,212,48,20,252,43,149,15,156,226,85,28,59,137,29,78,176,44,104,47,75,37,22,132,212,174,170,23,251,185,107,145,143,109,226,136,86,81,254,59,206,166,11,82,15,168,7,46,72,62,216,207,158,121,51,163,231,241,206,245,31,93,229,177,43,44,84,61,70,195,214,20,36,231,9,66,198,24,77,227,76,81,33,153,161,32,211,132,90,149,150,9,40,46,83,131,36,106,160,198,130,44,232,141,113,158,68,206,99,221,23,55,227,31,82,223,13,24,221,217,243,225,139,62,98,13,95,231,6,90,8,101,36,79,40,8,173,169,40,99,70,75,101,82,42,129,37,90,132,22,86,42,178,104,65,137,220,166,165,166,152,161,160,2,115,77,161,180,57,213,60,99,162,204,76,170,84,78,162,10,173,223,60,158,58,236,123,215,54,197,136,191,247,251,167,83,80,185,244,94,183,213,80,55,36,170,209,195,53,248,99,65,0,99,20,169,6,170,133,74,169,176,152,83,224,202,80,14,101,158,228,18,89,198,2,187,134,147,159,105,201,214,144,200,128,135,111,80,13,120,102,30,93,208,152,240,152,201,52,11,88,198,131,29,158,196,84,102,50,167,214,100,86,33,207,148,42,205,37,175,79,131,11,123,215,239,134,26,59,167,159,99,199,144,95,219,21,163,110,27,223,181,213,76,189,59,63,223,227,163,95,194,125,190,250,190,24,242,161,62,131,200,20,13,61,174,43,135,141,223,52,186,53,174,185,95,56,167,41,64,234,19,116,174,191,164,176,121,24,160,34,81,231,238,143,127,77,107,61,244,190,173,255,35,171,81,176,25,56,194,144,157,229,206,51,104,92,127,170,224,233,124,46,200,155,135,161,245,111,247,208,255,40,174,62,160,117,13,94,189,127,183,219,175,230,202,213,214,44,215,228,5,77,65,110,137,148,178,228,74,100,148,151,202,134,1,49,72,165,65,164,92,165,0,146,113,198,180,94,137,36,87,44,101,130,106,59,255,23,20,37,133,88,1,45,179,36,7,109,116,72,70,222,146,160,255,95,169,186,217,246,159,127,54,151,47,181,132,112,88,133,234,139,194,166,194,58,164,85,140,175,177,49,5,192,245,165,85,49,190,198,212,116,152,109,29,166,176,126,1,177,30,142,224,74,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51205379-8b3b-4d44-91b1-2cf7e081b07f"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f9078003-1806-4096-a752-6ce6fcaf6be3"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("76950e9e-10e8-40f4-86ff-2e96d8188d1b"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("93775e4e-88f1-48e9-ad74-74ac5f28d089"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("60cd6a65-a50a-4617-80ad-ed2c447da612"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("72a0125d-b3d1-40d6-87c7-019a59320276"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("946dd2c0-da26-457d-ad8c-4ba3167aa54d"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cd269b97-48c0-45a2-b046-e6a8730dbc7b"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("af08f6d6-b7c6-43d1-9f43-0d58376f1628"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1374d32a-f908-40e6-bf89-db89d892800d"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5b57f2b2-ecee-4016-9433-31ce467f75e4"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c8013d26-15c8-4309-8bd8-b47ac03d9b59"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("16f2c6ff-c1c8-4618-a4e9-e3c0db708ee5"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("0d16c05d-2fc2-4a8a-8988-a0236870a419"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6aa112f-0172-4d91-a4d7-4aca0c91d611"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aa42b756-be31-4168-9f40-03d0cd697284"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f618c628-078b-4fab-81a7-240f5a62a2b2"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("571db245-7db6-406f-a8a7-15a2bb0159b2"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("de2b38a3-9f52-4d0b-8df6-067cb01d12fa"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				Value = @"b0e78c23-7095-4d59-b8eb-c10243bcd67b",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2486b970-ba2a-4d75-ad7e-6a6ca3693558"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d0582550-2e0c-4765-8c6b-c7cbbd545084"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("0b9fe44f-dae0-43df-bf4f-456291e2c0f3"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("85beb4a5-021f-4174-8075-c753178d9f8c"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,75,111,27,55,16,254,43,194,38,135,22,16,13,190,31,186,214,110,97,192,73,131,58,205,197,242,97,72,14,99,1,210,174,177,187,138,155,10,250,239,153,93,203,181,156,166,74,234,166,40,144,122,15,43,137,228,60,57,223,55,163,77,245,188,127,127,141,213,172,122,141,109,11,93,83,250,163,31,154,22,143,94,181,77,194,174,59,58,107,18,44,23,191,67,92,226,43,104,97,133,61,182,111,96,185,198,238,108,209,245,211,201,67,177,106,90,61,127,55,238,86,179,139,77,117,218,227,234,215,211,76,218,129,115,95,66,40,12,131,82,76,163,2,6,220,74,166,75,14,201,43,30,36,90,18,78,205,114,189,170,95,96,15,175,160,191,170,102,155,106,212,70,10,34,119,22,92,32,9,25,50,211,46,71,230,131,200,204,90,41,148,22,192,99,198,106,59,173,186,116,133,43,24,141,238,11,163,243,73,42,230,120,48,76,103,19,88,244,24,89,18,92,106,21,83,182,46,14,194,187,243,247,130,23,207,46,78,187,159,111,106,108,207,71,189,179,2,203,14,47,143,104,245,163,133,63,146,51,219,24,13,28,66,14,204,164,76,174,154,4,204,75,27,152,67,161,132,71,199,93,148,219,203,103,151,131,197,188,232,174,151,240,254,205,159,13,159,33,228,219,51,215,15,242,190,127,106,51,191,189,190,121,53,155,255,213,5,238,62,111,221,125,120,133,31,223,222,188,154,206,171,243,102,221,166,65,163,26,126,220,101,115,180,192,119,15,251,196,235,238,185,213,49,138,189,128,26,222,98,251,146,44,142,226,227,214,49,244,48,26,127,77,126,223,41,150,138,11,111,172,99,32,84,98,90,73,206,188,245,142,149,108,75,64,101,67,136,121,148,254,5,11,182,88,39,124,164,99,163,229,123,103,238,10,141,86,234,245,114,57,26,232,198,248,135,202,221,57,190,219,57,222,187,169,61,13,77,94,148,5,230,211,250,145,30,29,99,25,85,254,216,180,39,191,17,162,22,245,219,221,141,237,153,190,63,115,156,86,187,245,109,181,221,78,247,33,166,161,72,112,209,50,130,131,96,58,106,195,64,27,195,162,0,229,130,7,107,114,60,8,49,112,16,4,7,170,86,158,57,97,84,0,11,38,37,230,168,150,139,204,50,136,18,190,62,196,106,188,153,252,180,94,228,239,230,21,193,184,248,128,132,20,195,35,57,16,9,227,9,18,43,69,133,104,181,215,2,211,188,250,254,16,110,30,167,237,9,97,79,8,251,2,132,57,171,133,53,82,51,167,51,80,69,149,50,52,49,65,37,15,34,10,81,156,228,249,32,194,74,212,46,121,65,98,66,18,72,188,143,44,202,18,25,55,90,152,232,51,120,157,190,62,194,206,251,150,98,166,250,171,19,244,4,140,211,186,52,237,10,250,69,83,79,32,54,235,126,114,61,228,3,51,157,154,244,205,228,10,234,220,148,66,57,158,78,78,234,119,139,182,169,87,88,247,71,47,241,230,108,81,83,77,127,121,87,60,89,226,32,58,219,184,194,149,244,69,49,27,141,165,158,72,141,49,66,162,246,157,117,138,14,36,37,70,109,31,182,81,103,13,80,134,4,243,134,15,131,130,8,68,76,148,187,40,34,106,225,114,230,214,12,109,244,32,31,252,11,177,239,138,103,20,184,194,73,139,221,122,217,79,154,242,105,77,100,122,53,104,216,249,249,237,51,77,226,133,107,43,29,163,23,117,145,152,136,105,52,26,22,180,8,57,121,35,108,20,79,76,243,25,166,137,2,193,39,67,68,145,13,245,114,200,158,70,72,77,223,84,20,58,112,37,52,199,131,76,131,177,216,24,131,98,30,128,240,6,92,176,192,121,102,201,34,88,7,165,160,20,255,229,184,252,79,136,33,100,75,161,112,205,168,182,40,37,41,83,148,22,52,131,16,73,71,25,104,213,125,126,190,254,155,48,30,163,250,191,204,227,81,6,195,29,113,173,67,8,212,232,232,143,154,207,195,56,40,66,44,202,41,89,138,60,132,97,194,56,205,20,84,185,158,234,140,81,111,35,234,38,190,102,224,185,202,218,122,149,179,250,22,49,124,185,253,0,107,225,160,234,80,15,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ca953947-82c9-4fca-ad12-345201627164"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				UId = new Guid("a5128403-8408-4135-9d07-16147385bc38"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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

		protected virtual void InitializeChangeDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("f7d955b1-b130-45d2-b90b-36a4a2ff1c1b"),
				ContainerUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
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
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("86baa44f-1be5-4c2b-afba-f50c69444878"),
				ContainerUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ad1909b2-86a5-4387-ac62-e67d8d19b991"),
				ContainerUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
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
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,36,21,107,109,235,195,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,118,54,133,28,74,233,173,160,195,104,70,239,205,155,199,104,186,247,225,163,111,34,14,149,131,38,32,29,247,182,34,194,42,37,53,34,67,225,36,43,156,176,12,50,233,152,44,107,196,50,23,170,228,53,161,29,180,88,145,21,189,179,62,18,234,35,182,161,186,157,126,147,198,97,68,122,239,150,203,87,115,196,22,190,205,13,10,14,78,105,212,137,49,171,89,129,117,205,148,1,195,156,203,117,45,10,85,112,52,100,213,226,120,205,83,98,174,25,195,10,105,57,211,9,202,80,130,17,160,149,149,14,9,109,208,197,221,211,105,192,16,124,223,85,19,190,198,55,207,167,164,114,237,189,237,155,177,237,8,109,49,194,53,196,99,69,0,51,44,74,3,204,20,186,76,147,162,100,144,107,203,114,168,229,70,42,228,130,75,66,13,156,226,76,75,246,150,80,11,17,190,67,51,226,194,60,249,164,113,147,103,92,149,34,97,121,158,52,230,155,140,41,161,36,115,86,56,141,185,208,186,182,23,191,62,141,62,197,62,92,141,45,14,222,188,216,142,201,191,126,168,38,211,119,113,232,155,153,250,106,121,126,131,79,113,53,247,165,244,99,29,40,166,252,12,34,103,58,6,220,54,30,187,184,235,76,111,125,247,176,114,158,207,9,210,158,96,240,225,226,194,238,113,132,134,208,193,63,28,255,232,214,118,12,177,111,255,163,81,105,26,51,113,164,37,91,228,206,59,104,125,56,53,240,188,220,43,242,238,113,236,227,135,207,8,118,141,200,27,68,69,238,72,89,64,6,218,106,86,26,107,217,178,21,106,35,210,142,34,207,185,66,153,201,122,115,71,146,138,127,224,190,221,135,47,63,187,203,31,88,85,31,222,167,236,155,196,245,5,89,77,127,35,231,124,152,5,29,206,233,252,2,227,206,64,245,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea16bf89-752e-4e21-a5fa-2779bbe6a5de"),
				ContainerUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
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
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,152,75,111,27,55,16,128,255,138,176,201,209,20,248,28,146,190,181,117,10,24,72,210,160,78,115,137,125,24,146,195,88,168,164,53,118,87,73,93,195,255,189,179,107,185,182,131,198,49,26,231,96,59,58,172,160,93,205,144,156,153,111,30,123,214,60,31,78,79,168,217,109,222,82,215,97,223,214,97,254,75,219,209,252,77,215,102,234,251,249,203,54,227,114,241,55,166,37,189,193,14,87,52,80,247,14,151,27,234,95,46,250,97,103,118,83,172,217,105,158,127,156,158,54,187,239,207,154,253,129,86,127,236,23,214,174,28,144,10,38,9,68,95,132,205,74,137,84,108,16,81,250,148,148,51,104,146,100,225,220,46,55,171,245,43,26,240,13,14,199,205,238,89,51,105,99,5,41,203,172,11,72,225,208,176,130,96,37,171,178,36,50,72,66,239,129,180,132,230,124,167,233,243,49,173,112,90,244,74,216,42,172,33,82,20,222,201,36,44,165,36,66,198,44,106,53,49,1,43,83,148,71,225,237,255,175,4,223,63,123,217,182,127,110,78,230,90,27,171,114,81,194,37,99,120,255,188,124,148,124,8,168,30,162,161,10,100,237,220,99,148,81,242,10,206,36,39,172,139,124,62,157,140,144,72,20,37,104,200,14,158,29,141,11,149,69,127,178,196,211,119,95,92,239,96,192,15,52,255,233,19,46,134,197,250,195,172,199,37,93,72,158,220,112,194,117,217,179,195,11,95,30,54,187,135,95,242,230,246,251,96,50,210,77,127,126,238,202,195,102,231,176,57,104,55,93,30,53,154,241,199,165,105,167,21,228,246,35,254,227,114,249,185,208,49,137,189,194,53,159,168,123,205,43,78,226,211,163,61,28,112,90,252,45,239,251,82,113,210,209,73,175,170,240,132,145,157,5,90,132,162,80,68,21,83,53,222,232,90,245,36,253,59,85,234,104,157,233,230,198,238,226,170,73,126,90,249,106,51,151,81,199,119,214,155,229,114,90,160,159,206,63,134,241,118,227,219,39,123,215,252,119,77,67,91,22,117,65,101,127,253,63,77,181,71,117,82,249,107,219,189,248,139,241,98,215,111,61,118,109,233,171,255,236,229,213,246,254,121,115,126,190,115,157,55,111,35,71,117,10,34,64,100,35,178,225,68,138,62,11,107,41,4,19,11,21,87,111,229,45,38,237,99,246,32,164,86,108,197,234,148,192,92,64,152,104,152,100,9,145,241,253,158,188,149,170,114,14,32,64,143,187,46,124,193,194,49,33,11,5,162,132,201,202,60,7,168,198,80,9,204,27,85,206,9,185,10,28,79,10,224,248,252,148,43,96,190,35,111,175,137,202,108,133,195,166,91,12,167,243,3,198,173,23,29,97,57,253,65,221,29,169,187,131,195,30,63,117,30,173,178,58,10,85,117,26,171,156,231,184,55,86,56,233,156,146,46,203,224,225,86,234,66,208,169,170,226,133,25,109,103,181,100,128,101,70,145,106,84,38,135,98,171,174,223,131,186,247,251,253,111,159,214,212,93,88,112,183,226,178,167,163,57,223,253,236,198,139,37,173,104,61,236,158,249,42,141,14,35,107,201,1,151,186,82,68,226,252,32,160,216,156,60,234,100,189,57,103,129,127,163,125,247,204,68,72,158,51,143,48,201,228,81,196,8,228,210,205,125,0,166,80,37,74,109,232,252,232,107,188,110,61,51,22,197,225,152,102,29,245,155,229,48,107,235,236,100,124,64,101,122,208,206,142,113,93,218,90,231,63,111,202,7,226,54,37,97,79,179,188,233,198,200,125,50,76,71,224,126,196,144,22,236,14,18,22,184,253,226,228,143,28,92,38,133,12,170,202,92,110,99,250,206,27,123,204,76,71,176,58,103,91,4,73,178,156,216,164,19,201,161,18,53,150,2,228,128,121,13,183,50,205,216,87,244,17,68,146,129,43,169,210,192,149,148,41,205,181,148,172,157,51,17,229,67,101,218,57,237,44,247,245,2,164,103,227,176,57,68,68,228,6,56,102,180,64,38,64,213,247,206,244,84,157,103,237,120,182,167,66,242,183,86,103,5,137,12,112,15,23,42,167,3,171,92,100,249,194,35,84,144,166,88,8,166,20,243,232,73,78,197,17,24,228,16,141,129,211,97,72,89,36,32,46,174,137,148,138,92,132,44,164,91,73,166,154,141,118,82,113,101,231,44,106,29,111,55,84,180,130,11,182,204,156,8,52,212,248,80,73,142,48,206,5,149,173,81,50,207,174,178,240,246,108,101,11,169,236,19,2,88,144,233,222,73,126,69,52,141,183,5,135,39,51,222,22,173,40,82,181,34,75,224,148,41,149,22,73,115,223,92,81,97,80,94,21,220,142,167,63,138,242,151,81,150,5,60,135,147,229,161,126,204,103,25,50,67,237,180,64,158,62,100,144,220,220,20,252,74,81,134,8,94,178,2,77,97,68,217,240,164,156,170,160,2,144,57,27,130,41,238,161,162,108,48,32,105,30,221,185,66,176,72,48,124,54,98,57,21,208,4,169,173,243,8,247,142,242,52,64,143,124,62,21,142,191,181,36,19,167,88,74,154,163,55,26,190,16,17,87,227,202,33,172,173,71,87,51,133,16,30,61,199,90,231,148,67,114,99,173,241,28,170,129,43,42,114,253,137,160,156,231,198,153,84,188,253,181,240,88,137,161,170,196,248,243,60,105,19,86,17,162,179,66,122,206,4,220,172,3,107,121,168,28,171,92,16,188,247,162,4,203,17,34,129,198,215,229,78,152,28,140,79,213,66,209,247,207,241,30,229,69,191,104,215,179,97,177,162,229,98,253,100,120,254,81,151,239,129,231,234,3,115,195,115,134,39,93,57,202,145,147,98,202,81,184,16,19,15,28,129,103,144,219,135,101,180,18,193,114,27,138,146,59,115,43,137,187,117,203,165,12,121,162,84,165,166,20,205,131,125,1,198,231,64,227,120,78,54,56,246,28,177,70,129,202,242,248,224,200,22,164,68,217,132,239,52,44,151,197,199,137,234,167,2,243,183,22,103,199,41,215,65,154,124,35,133,45,228,68,146,124,193,154,148,172,224,35,215,166,199,8,243,209,249,63,241,172,237,47,17,30,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b489a3e3-1617-471f-b59f-c1cc1901627e"),
				ContainerUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
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
				UId = new Guid("96352b96-718c-4854-ab6d-31d33673a18b"),
				ContainerUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
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
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("702f5fbb-ed10-4780-81d7-ed81fe787102"),
				ContainerUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("24e70e39-6f35-420e-8745-11cb3e30fc29"),
				ContainerUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,100,21,127,200,150,228,30,183,219,178,80,210,64,183,37,144,44,97,36,141,178,2,127,197,150,105,130,241,127,175,108,103,83,200,161,148,222,10,58,140,198,122,111,222,60,207,76,247,110,248,228,42,143,125,105,161,26,48,26,15,166,36,5,7,203,10,174,104,174,117,76,25,15,145,176,133,164,25,160,50,134,51,203,84,78,162,6,106,44,201,134,222,27,231,73,228,60,214,67,121,59,253,38,245,253,136,209,189,93,47,223,244,25,107,248,190,20,96,9,88,33,81,82,158,199,138,50,84,161,128,6,77,173,205,164,42,152,96,9,106,178,105,97,8,104,83,38,40,136,92,80,102,211,16,41,145,82,43,181,74,243,140,89,133,138,68,190,119,245,71,240,120,116,53,94,67,31,148,133,130,199,118,73,109,26,42,180,126,255,212,245,56,12,174,109,202,9,95,227,227,115,23,218,216,196,237,218,106,172,27,18,5,56,92,131,63,151,4,48,70,150,107,160,154,201,60,148,71,78,33,147,38,88,161,120,202,5,38,69,194,73,164,161,243,11,45,57,24,18,25,240,240,3,170,17,87,230,201,133,38,210,44,78,68,94,4,108,146,105,202,178,52,166,162,16,156,90,83,88,137,89,33,165,50,23,67,63,143,46,196,110,184,26,107,236,157,126,249,47,24,12,110,251,114,210,109,227,251,182,90,168,175,214,231,71,124,242,155,251,47,159,110,182,134,124,200,47,32,50,71,227,128,187,202,97,227,247,141,110,141,107,30,54,206,121,14,144,186,131,222,13,23,23,246,143,35,84,36,234,221,195,249,143,110,237,198,193,183,245,127,212,106,212,93,134,98,149,187,12,169,113,67,87,193,243,122,47,201,187,199,177,245,31,190,32,152,45,34,111,16,37,185,35,57,131,24,164,145,97,45,140,161,235,84,136,52,172,5,199,36,75,4,242,152,171,244,142,4,21,255,192,125,123,24,190,254,108,46,75,178,169,62,189,15,217,55,137,215,225,46,167,191,145,51,159,22,65,167,57,156,95,86,230,180,189,235,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aa996c30-4714-41b7-ba32-536d65ced754"),
				ContainerUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,77,111,219,70,16,253,43,198,38,71,141,176,95,220,15,223,130,184,5,12,56,137,17,39,185,68,57,204,238,206,38,66,37,209,32,169,180,142,161,255,158,17,45,195,82,209,56,66,209,92,140,242,64,130,220,125,243,134,243,230,237,220,138,231,195,205,53,137,83,241,142,186,14,251,182,14,211,151,109,71,211,203,174,205,212,247,211,139,54,227,98,254,13,211,130,46,177,195,37,13,212,125,192,197,154,250,139,121,63,76,78,14,97,98,34,158,127,29,87,197,233,199,91,113,62,208,242,253,121,225,232,228,85,44,222,121,160,170,3,88,138,9,66,72,25,42,81,81,53,84,107,170,102,112,110,23,235,229,234,21,13,120,137,195,23,113,122,43,198,104,28,32,101,153,117,113,18,26,52,5,108,176,18,16,45,65,118,146,208,123,71,90,58,177,153,136,62,127,161,37,142,164,15,96,171,176,134,72,17,124,35,19,179,39,102,207,200,236,213,196,228,56,152,162,188,5,239,246,63,0,63,62,187,104,219,63,214,215,83,173,141,85,185,40,104,146,49,96,51,211,71,169,20,184,234,93,52,84,29,89,59,245,24,101,148,204,208,152,212,128,109,98,128,168,147,1,137,68,81,58,237,114,227,158,125,218,18,149,121,127,189,192,155,15,63,228,187,26,240,51,77,95,252,137,243,97,190,250,124,210,227,130,238,144,215,7,34,236,99,111,103,119,90,206,196,233,236,71,106,238,158,87,99,145,14,245,252,187,148,51,49,153,137,171,118,221,229,109,68,179,125,185,47,237,200,32,119,23,252,195,237,254,186,139,49,194,94,225,138,255,168,123,205,140,35,124,92,58,195,1,71,242,119,156,247,125,224,164,99,35,189,170,224,9,35,139,229,52,132,162,16,162,138,169,26,111,116,173,122,68,191,165,74,29,173,50,29,38,118,140,84,35,126,100,126,72,230,190,235,248,203,106,189,88,140,4,253,248,255,219,54,222,37,190,91,57,219,211,111,47,66,91,230,117,78,229,124,245,47,75,117,70,117,12,249,123,219,253,246,23,219,139,165,223,41,182,71,253,176,231,44,47,119,223,55,98,179,153,236,251,77,81,169,78,98,5,82,129,59,222,35,215,175,241,108,0,237,125,86,210,231,20,220,79,252,134,65,121,50,108,25,199,126,147,220,203,33,72,11,161,137,209,74,163,100,113,225,191,247,219,76,188,233,10,117,51,241,152,73,14,54,61,125,63,24,221,160,55,41,128,172,214,131,181,40,129,11,168,193,59,201,45,29,164,52,152,31,243,195,209,137,61,101,63,20,29,81,113,67,243,41,146,249,104,174,202,64,76,201,114,71,86,139,41,234,64,73,62,234,135,152,180,143,217,59,144,154,177,182,54,10,48,23,7,38,26,71,74,186,152,138,253,149,243,167,84,149,115,112,224,180,207,96,11,223,144,7,39,200,66,129,40,97,178,50,79,157,171,198,80,9,60,127,168,242,140,204,21,144,143,76,112,174,241,54,82,174,14,243,145,243,231,53,207,229,147,37,14,235,110,62,220,76,175,120,252,244,208,17,150,155,255,167,208,145,83,232,8,193,158,162,235,62,109,190,3,19,102,106,192,83,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6110e927-9c70-4dbd-9d6e-6ee7ead41e8b"),
				ContainerUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
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
			ProcessSchemaLaneSet schemaLeadHandoffProcess = CreateLeadHandoffProcessLaneSet();
			LaneSets.Add(schemaLeadHandoffProcess);
			ProcessSchemaLane schemaLeadHandoff = CreateLeadHandoffLane();
			schemaLeadHandoffProcess.Lanes.Add(schemaLeadHandoff);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
			ProcessSchemaTerminateEvent terminatenurturing = CreateTerminateNurturingTerminateEvent();
			FlowElements.Add(terminatenurturing);
			ProcessSchemaExclusiveGateway exclusivegatewayleaddefined = CreateExclusiveGatewayLeadDefinedExclusiveGateway();
			FlowElements.Add(exclusivegatewayleaddefined);
			ProcessSchemaTerminateEvent terminateleadundefined = CreateTerminateLeadUndefinedTerminateEvent();
			FlowElements.Add(terminateleadundefined);
			ProcessSchemaUserTask readleaddata = CreateReadLeadDataUserTask();
			FlowElements.Add(readleaddata);
			ProcessSchemaUserTask activityusertaskbant = CreateActivityUserTaskBANTUserTask();
			FlowElements.Add(activityusertaskbant);
			ProcessSchemaUserTask changeleadstatetonointerest = CreateChangeLeadStateToNoInterestUserTask();
			FlowElements.Add(changeleadstatetonointerest);
			ProcessSchemaUserTask changeleadnurturing = CreateChangeLeadNurturingUserTask();
			FlowElements.Add(changeleadnurturing);
			ProcessSchemaTerminateEvent terminateopportunity = CreateTerminateOpportunityTerminateEvent();
			FlowElements.Add(terminateopportunity);
			ProcessSchemaTerminateEvent terminatenointerest = CreateTerminateNoInterestTerminateEvent();
			FlowElements.Add(terminatenointerest);
			ProcessSchemaUserTask autogeneratedpagehandoff = CreateAutoGeneratedPageHandoffUserTask();
			FlowElements.Add(autogeneratedpagehandoff);
			ProcessSchemaUserTask readleadforhandoff = CreateReadLeadForHandoffUserTask();
			FlowElements.Add(readleadforhandoff);
			ProcessSchemaUserTask readactivitydata = CreateReadActivityDataUserTask();
			FlowElements.Add(readactivitydata);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaUserTask changedatausertask2 = CreateChangeDataUserTask2UserTask();
			FlowElements.Add(changedatausertask2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateSequenceFlowLeadDefinedSequenceFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow9ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow7ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5b260b1a-a023-4cd9-a40d-481707a20898"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("00836aec-4306-4338-9ac5-67ea748b499b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowLeadUndefinedConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowLeadUndefined",
				UId = new Guid("c46387cf-300b-4cd8-be2d-4740b8665e12"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{54a0a9d9-5cdd-45ca-8269-7e1318e707b2}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(182, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("417b4b0e-9802-41ee-a1ee-f7c063ac01d7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowLeadDefinedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlowLeadDefined",
				UId = new Guid("ec60176a-01ca-46d0-bf66-047ed4a197d9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(242, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("f4359b3c-140b-4cfa-a64a-624975aad45f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(566, 200),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("89a7d2c0-103f-4f41-87f7-265a34bf1d89"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow9ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow9",
				UId = new Guid("1c27d27e-3f1d-4f64-a277-78d7380f5bb1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(560, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("e07f0e4a-f36b-1410-6698-00155d043204"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow7ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow7",
				UId = new Guid("37f09d58-5453-451a-97f7-c4f7dcacee68"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(582, 218),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("a08e24ec-c5d1-4951-b49f-5e70dde6a7d9"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("d76ddb1d-3dc5-4e4a-a026-c27588143f72"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(956, 295),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("75650cf9-cc74-4582-bca5-d68dbfe34907"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("4c30ec94-2c81-4c4f-889c-bea3f5a1139b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(923, 415),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5061ca01-0d15-463d-b233-768fa17131d0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("31b52b04-44cf-4b5c-9b9b-5d4441942c8f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(956, 180),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("da8b2a97-17f6-4b09-944c-d3169e2a7cf5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(712, 163),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("98857f24-89e8-4af8-bd7b-bd7edc0c46e5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(353, 222),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("23ff5267-6922-4cdf-bc26-a9d0f2ececcd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(326, 164),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(-1, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("d87d32bc-f36b-1410-6598-00155d043204"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("528b01b5-68f3-4731-884e-9434c98dfe97"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("80b19196-e5d8-462a-b1ba-f02f4dd04777"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(1148, 189),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1251ae43-7225-4df5-993b-23aae9b2351a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("80b19196-e5d8-462a-b1ba-f02f4dd04777"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(952, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("b189122e-cd60-4368-8d1c-eed898c517dc"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2dc83e6e-1ed4-44d5-8886-72aa55f8985d"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(1162, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf288ac2-175d-42be-a7ba-9dfdcc1724f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("8cdb95ca-c8ea-4880-b7cc-741fa584081f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("00276668-9718-4e94-8d54-1a9582a96ad4"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("fdc13e7b-c600-487f-a398-7240d059ee6a"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("31f7cb76-83b3-441e-ba96-e7cef52d36de"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("00276668-9718-4e94-8d54-1a9582a96ad4"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf288ac2-175d-42be-a7ba-9dfdcc1724f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLeadHandoffProcessLaneSet() {
			ProcessSchemaLaneSet schemaLeadHandoffProcess = new ProcessSchemaLaneSet(this) {
				UId = new Guid("c46f8bb0-50e4-4535-913d-d89bd088077f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"LeadHandoffProcess",
				Position = new Point(5, 5),
				Size = new Size(1232, 599),
				UseBackgroundMode = false
			};
			return schemaLeadHandoffProcess;
		}

		protected virtual ProcessSchemaLane CreateLeadHandoffLane() {
			ProcessSchemaLane schemaLeadHandoff = new ProcessSchemaLane(this) {
				UId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("c46f8bb0-50e4-4535-913d-d89bd088077f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"LeadHandoff",
				Position = new Point(29, 0),
				Size = new Size(1203, 599),
				UseBackgroundMode = false
			};
			return schemaLeadHandoff;
		}

		protected virtual ProcessSchemaStartEvent CreateStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("00836aec-4306-4338-9ac5-67ea748b499b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"Start",
				Position = new Point(50, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateNurturingTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("75650cf9-cc74-4582-bca5-d68dbfe34907"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"TerminateNurturing",
				Position = new Point(673, 282),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayLeadDefinedExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ExclusiveGatewayLeadDefined",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(120, 156),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateLeadUndefinedTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("417b4b0e-9802-41ee-a1ee-f7c063ac01d7"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"TerminateLeadUndefined",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(134, 289),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ReadLeadData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(218, 156),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadLeadDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateActivityUserTaskBANTUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ActivityUserTaskBANT",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(337, 156),
				SchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeActivityUserTaskBANTParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadStateToNoInterestUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ChangeLeadStateToNoInterest",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(526, 387),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeLeadStateToNoInterestParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadNurturingUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ChangeLeadNurturing",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(526, 268),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeLeadNurturingParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateOpportunityTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("cf288ac2-175d-42be-a7ba-9dfdcc1724f5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"TerminateOpportunity",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1149, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateNoInterestTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("5061ca01-0d15-463d-b233-768fa17131d0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"TerminateNoInterest",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(673, 401),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateAutoGeneratedPageHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"AutoGeneratedPageHandoff",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(785, 156),
				SchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAutoGeneratedPageHandoffParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadForHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ReadLeadForHandoff",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(652, 156),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadLeadForHandoffParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadActivityDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ReadActivityData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(526, 156),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadActivityDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("80b19196-e5d8-462a-b1ba-f02f4dd04777"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"AddDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(911, 156),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2dc83e6e-1ed4-44d5-8886-72aa55f8985d"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ChangeDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1037, 156),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("00276668-9718-4e94-8d54-1a9582a96ad4"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ChangeDataUserTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1039, 34),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementHandoff(userConnection);
		}

		public override object Clone() {
			return new LeadManagementHandoffSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ee7590a-758b-4ee3-990c-188743946765"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementHandoff

	/// <exclude/>
	public class LeadManagementHandoff : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadHandoff

		/// <exclude/>
		public class ProcessLeadHandoff : ProcessLane
		{

			public ProcessLeadHandoff(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadLeadDataFlowElement

		/// <exclude/>
		public class ReadLeadDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadData";
				IsLogging = true;
				SchemaElementUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,100,21,201,150,45,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,191,98,203,52,193,236,127,175,108,103,83,200,161,148,222,10,58,140,70,243,222,188,121,140,230,123,63,126,244,117,192,161,116,80,143,152,76,7,91,18,89,57,167,242,84,81,169,11,160,130,113,73,65,113,69,153,144,76,240,76,2,58,36,73,11,13,150,100,67,239,173,15,36,241,1,155,177,188,157,127,147,134,97,194,228,222,173,151,175,230,132,13,124,91,26,8,14,78,105,212,84,230,172,162,2,171,138,42,3,134,58,151,233,170,16,74,112,52,100,211,194,164,176,58,214,83,89,229,41,21,144,58,170,92,90,209,130,129,112,150,27,237,88,74,146,26,93,216,63,245,3,142,163,239,218,114,198,215,248,230,185,143,42,183,222,187,174,158,154,150,36,13,6,184,134,112,42,9,32,67,145,27,160,70,232,156,10,135,113,210,76,91,154,65,37,83,169,144,23,92,146,196,64,31,22,90,114,176,36,177,16,224,59,212,19,174,204,179,143,26,211,140,113,149,23,17,203,51,67,69,150,50,170,10,37,169,179,133,211,152,21,90,87,246,226,215,167,201,199,216,143,87,83,131,131,55,47,182,99,244,175,27,202,217,116,109,24,186,122,161,190,90,203,111,240,41,108,230,190,60,253,216,6,10,49,191,128,200,57,153,70,220,213,30,219,176,111,77,103,125,251,176,113,158,207,17,210,244,48,248,241,226,194,254,113,130,154,36,131,127,56,253,209,173,221,52,134,174,249,143,70,77,226,152,145,35,46,217,42,119,217,65,235,199,190,134,231,245,94,146,119,143,83,23,62,124,70,176,91,68,222,32,74,114,71,114,1,12,180,213,52,55,214,210,117,43,84,90,196,29,69,158,113,133,146,201,42,189,35,81,197,63,112,223,30,198,47,63,219,203,31,216,84,31,223,199,236,155,196,245,5,89,206,127,35,231,124,92,4,29,207,241,252,2,68,247,49,72,202,3,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })));
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
								new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
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

		#region Class: ActivityUserTaskBANTFlowElement

		/// <exclude/>
		public class ActivityUserTaskBANTFlowElement : ActivityUserTask
		{

			#region Constructors: Public

			public ActivityUserTaskBANTFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ActivityUserTaskBANT";
				IsLogging = true;
				SchemaElementUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadHandoff;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_lead = () => (Guid)((process.LeadId));
				_account = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.ActivityUserTaskBANT.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private Guid _activityCategory = new Guid("f51c4643-58e6-df11-971b-001d60e938c6");
			public override Guid ActivityCategory {
				get {
					return _activityCategory;
				}
				set {
					_activityCategory = value;
				}
			}

			internal Func<Guid> _ownerId;
			public override Guid OwnerId {
				get {
					return (_ownerId ?? (_ownerId = () => Guid.Empty)).Invoke();
				}
				set {
					_ownerId = () => { return value; };
				}
			}

			private int _duration = 60;
			public override int Duration {
				get {
					return _duration;
				}
				set {
					_duration = value;
				}
			}

			private int _remindBefore = 0;
			public override int RemindBefore {
				get {
					return _remindBefore;
				}
				set {
					_remindBefore = value;
				}
			}

			private bool _showInScheduler = true;
			public override bool ShowInScheduler {
				get {
					return _showInScheduler;
				}
				set {
					_showInScheduler = value;
				}
			}

			private bool _showExecutionPage = true;
			public override bool ShowExecutionPage {
				get {
					return _showExecutionPage;
				}
				set {
					_showExecutionPage = value;
				}
			}

			internal Func<Guid> _lead;
			public override Guid Lead {
				get {
					return (_lead ?? (_lead = () => Guid.Empty)).Invoke();
				}
				set {
					_lead = () => { return value; };
				}
			}

			internal Func<Guid> _account;
			public override Guid Account {
				get {
					return (_account ?? (_account = () => Guid.Empty)).Invoke();
				}
				set {
					_account = () => { return value; };
				}
			}

			internal Func<Guid> _contact;
			public override Guid Contact {
				get {
					return (_contact ?? (_contact = () => Guid.Empty)).Invoke();
				}
				set {
					_contact = () => { return value; };
				}
			}

			private LocalizableString _informationOnStep;
			public override LocalizableString InformationOnStep {
				get {
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.ActivityUserTaskBANT.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"89a7d2c0-103f-4f41-87f7-265a34bf1d89\",\"e07f0e4a-f36b-1410-6698-00155d043204\",\"a08e24ec-c5d1-4951-b49f-5e70dde6a7d9\",\"d87d32bc-f36b-1410-6598-00155d043204\",\"fdc13e7b-c600-487f-a398-7240d059ee6a\"]";
			}

			#endregion

			#region Methods: Protected

			protected override void AfterActivitySaveScriptExecute(Entity activity) {
			}

			#endregion

		}

		#endregion

		#region Class: ChangeLeadStateToNoInterestFlowElement

		/// <exclude/>
		public class ChangeLeadStateToNoInterestFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadStateToNoInterestFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadStateToNoInterest";
				IsLogging = true;
				SchemaElementUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("f78066d3-a73e-4e86-bb99-e477fcb94b28"));
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("51adc3ec-3503-4b10-a00b-8be3b0e11f08"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_LeadTypeStatus;
			internal Func<Guid> _recordColumnValues_QualifyStatus;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,36,21,127,72,182,228,30,151,109,89,40,105,160,105,41,36,75,24,73,163,172,192,95,177,101,154,96,246,191,87,182,179,41,228,80,74,111,5,29,70,163,121,111,222,60,70,243,189,31,63,250,58,224,80,57,168,71,164,211,193,86,36,211,165,40,108,94,178,44,213,156,113,11,130,169,210,10,166,1,10,238,20,215,153,72,8,109,161,193,138,108,232,189,245,129,80,31,176,25,171,219,249,55,105,24,38,164,247,110,189,124,53,39,108,224,219,210,128,167,224,164,66,197,74,145,104,198,81,107,38,13,24,230,92,174,116,193,37,79,209,144,77,11,231,82,160,80,154,153,88,203,184,118,57,147,90,228,12,184,116,73,6,34,229,186,32,180,70,23,246,79,253,128,227,232,187,182,154,241,53,190,121,238,163,202,173,247,174,171,167,166,37,180,193,0,215,16,78,21,1,76,144,11,3,204,112,37,24,119,88,50,200,149,101,57,232,50,43,37,166,69,90,18,106,160,15,11,45,57,88,66,45,4,248,14,245,132,43,243,236,23,191,242,36,149,162,136,216,52,55,140,231,89,194,100,33,75,230,108,225,20,230,133,82,218,94,252,250,52,249,24,251,241,106,106,112,240,230,197,118,140,254,117,67,53,155,174,13,67,87,47,212,87,107,249,13,62,133,205,220,151,167,31,219,64,33,230,23,16,57,211,105,196,93,237,177,13,251,214,116,214,183,15,27,231,249,28,33,77,15,131,31,47,46,236,31,39,168,9,29,252,195,233,143,110,237,166,49,116,205,127,52,42,141,99,70,142,184,100,171,220,101,7,173,31,251,26,158,215,123,69,222,61,78,93,248,240,25,193,110,17,121,131,168,200,29,17,28,18,80,86,49,97,172,101,235,86,200,172,136,59,138,105,158,74,44,147,82,103,119,36,170,248,7,238,219,195,248,229,103,123,249,3,155,234,227,251,152,125,147,184,190,32,171,249,111,228,156,143,139,160,227,57,158,95,209,224,137,218,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,83,77,107,27,49,20,252,43,65,201,209,50,250,90,125,248,90,183,16,72,66,104,210,92,226,28,158,164,167,100,169,237,53,187,235,210,212,248,191,87,86,108,108,151,166,132,64,47,165,58,104,89,73,51,243,244,70,179,34,103,253,243,2,201,136,220,98,219,66,215,164,126,248,161,105,113,120,221,54,1,187,110,120,209,4,152,214,63,192,79,241,26,90,152,97,143,237,29,76,151,216,93,212,93,63,56,57,134,145,1,57,251,86,118,201,232,126,69,206,123,156,125,57,143,153,221,7,155,156,230,146,66,76,21,85,18,29,181,149,229,212,1,72,225,153,67,107,55,224,208,76,151,179,249,37,246,112,13,253,19,25,173,72,97,203,4,206,11,227,130,209,148,137,204,162,82,197,41,132,168,169,116,82,35,103,218,249,168,200,122,64,186,240,132,51,40,162,123,176,226,144,172,203,154,166,98,158,42,244,158,218,0,129,166,36,157,215,202,42,142,97,3,222,158,223,3,239,79,47,154,230,235,114,49,20,49,241,16,172,166,90,152,64,85,204,19,68,158,40,139,104,17,61,120,197,194,48,25,203,180,142,249,146,70,98,150,201,199,189,119,142,162,50,38,5,239,148,23,246,244,97,35,20,235,110,49,133,231,187,87,245,174,16,227,201,12,250,101,91,247,207,195,171,166,63,169,231,185,243,216,245,24,95,40,22,71,110,28,146,172,38,47,166,78,200,104,242,154,173,219,239,77,233,214,177,177,191,122,58,33,131,9,185,105,150,109,216,48,202,205,207,174,199,69,129,109,7,253,205,180,27,47,28,5,118,9,115,120,196,246,42,43,22,120,217,26,67,15,69,252,54,215,189,35,246,194,85,204,228,38,27,4,151,219,169,5,181,145,3,117,220,249,36,141,20,41,137,130,254,140,41,183,102,30,240,184,176,183,120,86,240,69,121,95,204,238,249,229,149,249,114,58,45,2,93,185,255,230,61,111,11,223,238,140,15,140,60,96,104,98,157,106,140,231,243,119,182,106,140,169,80,126,106,218,143,223,115,206,234,249,227,214,177,3,233,253,153,113,152,109,215,215,100,189,30,28,6,207,26,233,28,51,140,98,4,69,149,144,130,130,118,156,162,12,129,89,29,140,136,236,143,193,243,129,5,17,53,163,21,200,72,115,86,24,5,80,72,131,102,8,198,104,20,76,255,205,224,9,169,120,136,156,86,94,230,220,135,44,239,24,231,84,39,163,157,196,164,81,169,97,197,33,6,137,129,202,138,229,67,158,231,26,89,22,180,30,165,103,200,121,98,111,13,222,77,159,95,231,255,192,189,47,112,111,240,234,95,12,220,195,250,39,147,220,118,68,71,7,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7ee7590a758b4ee3990c188743946765",
							"BaseElements.ChangeLeadStateToNoInterest.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
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

		#region Class: ChangeLeadNurturingFlowElement

		/// <exclude/>
		public class ChangeLeadNurturingFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadNurturingFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadNurturing";
				IsLogging = true;
				SchemaElementUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("5b3d1046-fc16-45c8-a5a1-298dfc857546"));
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("14cfc644-e3ed-497e-8279-ed4319bb8093"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_LeadTypeStatus;
			internal Func<Guid> _recordColumnValues_QualifyStatus;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,75,107,220,48,16,254,47,58,244,100,21,217,150,109,201,61,46,219,178,80,210,64,211,82,72,150,48,146,70,89,129,95,177,100,154,96,246,191,87,182,179,41,228,80,74,111,5,29,70,99,127,143,249,24,205,247,206,127,116,77,192,177,182,208,120,76,166,131,169,9,67,171,37,23,5,197,146,43,202,81,11,10,10,56,69,76,141,201,76,197,180,209,36,233,160,197,154,108,232,189,113,129,36,46,96,235,235,219,249,55,105,24,39,76,238,237,122,249,170,79,216,194,183,69,128,167,96,133,68,73,171,130,45,2,74,81,161,65,83,107,115,169,74,46,120,138,81,96,245,82,9,166,51,80,150,166,86,49,202,45,147,20,140,150,148,41,169,37,242,50,203,181,33,73,131,54,236,159,134,17,189,119,125,87,207,248,90,223,60,15,209,229,166,189,235,155,169,237,72,210,98,128,107,8,167,154,0,50,228,133,6,170,185,44,34,59,86,20,114,105,104,14,170,202,42,129,105,153,86,36,209,48,132,133,150,28,162,148,129,0,223,161,153,112,101,158,93,244,152,229,44,21,69,25,177,105,174,41,207,51,70,69,41,42,106,77,105,37,230,165,148,202,92,242,250,52,185,88,59,127,53,181,56,58,253,18,59,198,252,250,177,158,117,223,133,177,111,22,234,171,245,247,27,124,10,91,184,47,159,126,108,3,133,216,95,64,228,156,76,30,119,141,195,46,236,59,221,27,215,61,108,156,231,115,132,180,3,140,206,95,82,216,63,78,208,144,100,116,15,167,63,166,181,155,124,232,219,255,104,212,36,142,25,57,226,146,173,118,151,29,52,206,15,13,60,175,247,154,188,123,156,250,240,225,51,130,217,42,242,6,81,147,59,82,112,96,32,141,164,133,54,134,174,91,33,178,50,238,40,166,121,42,176,98,149,202,238,72,116,241,15,220,183,7,255,229,103,119,121,3,155,235,227,251,216,125,211,184,190,32,235,249,111,236,156,143,139,161,227,57,158,95,203,128,158,28,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,65,110,219,48,16,252,74,160,228,232,53,72,145,162,72,95,235,22,8,144,4,65,147,230,18,231,176,92,46,19,161,182,101,72,114,208,52,240,223,75,43,54,108,23,77,97,20,232,165,40,15,18,68,106,102,86,59,59,122,205,206,186,151,5,103,163,236,150,155,6,219,58,118,195,15,117,195,195,235,166,38,110,219,225,69,77,56,173,190,163,159,242,53,54,56,227,142,155,59,156,46,185,189,168,218,110,112,114,8,203,6,217,217,115,127,154,141,238,95,179,243,142,103,95,206,67,98,47,75,227,189,160,8,69,44,29,104,68,5,22,165,134,130,116,105,92,48,161,40,215,96,170,167,203,217,252,146,59,188,198,238,41,27,189,102,61,91,34,112,62,47,29,149,6,68,46,21,232,88,72,64,10,6,148,83,134,165,48,206,7,157,173,6,89,75,79,60,195,94,116,7,214,18,163,117,236,160,44,132,7,205,222,131,37,36,136,81,57,111,180,213,146,105,13,222,188,191,3,222,159,94,212,245,215,229,98,152,135,40,137,172,1,147,151,4,58,164,11,6,25,65,4,182,204,30,189,22,52,44,188,10,82,104,3,145,164,1,93,144,5,44,80,66,238,108,136,100,139,178,208,230,244,97,45,20,170,118,49,197,151,187,119,245,174,152,195,201,12,187,101,83,117,47,195,113,213,82,253,204,13,135,55,248,226,192,137,125,130,215,201,155,161,147,108,52,121,207,210,205,253,166,239,212,161,169,63,251,57,201,6,147,236,166,94,54,180,102,84,235,135,109,127,123,5,177,89,240,139,203,118,189,113,244,176,75,156,227,35,55,87,73,177,135,247,71,99,236,176,23,191,77,117,111,137,125,238,10,81,166,6,151,140,105,94,216,228,96,131,68,112,210,249,168,74,149,199,152,247,232,207,28,83,95,230,196,135,133,29,227,87,143,239,149,119,197,108,71,47,237,204,151,211,105,47,208,246,223,191,158,229,77,225,155,147,241,158,137,123,12,117,168,98,197,225,124,254,135,173,26,115,236,41,63,213,205,199,111,41,99,213,252,113,227,216,158,244,238,157,49,205,54,251,171,108,181,26,236,135,78,68,212,214,146,135,148,141,144,66,23,8,60,7,132,168,108,140,194,4,227,4,253,54,116,158,4,229,193,8,40,80,37,2,171,5,32,106,6,50,130,49,69,154,115,97,254,102,232,114,165,37,5,9,41,88,41,243,148,228,157,144,18,76,76,255,12,197,209,176,214,67,169,41,146,209,26,88,113,170,209,149,12,54,253,42,128,131,86,105,88,188,21,78,29,25,186,155,46,77,231,58,108,93,83,249,101,87,213,243,255,113,59,50,110,71,56,245,47,198,237,97,245,3,126,255,5,18,65,7,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7ee7590a758b4ee3990c188743946765",
							"BaseElements.ChangeLeadNurturing.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
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

		#region Class: AutoGeneratedPageHandoffFlowElement

		/// <exclude/>
		public class AutoGeneratedPageHandoffFlowElement : AutoGeneratedPageUserTask
		{

			#region Constructors: Public

			public AutoGeneratedPageHandoffFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AutoGeneratedPageHandoff";
				IsLogging = true;
				SchemaElementUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadHandoff;
				SerializeToDB = true;
				_showExecutionPage = () => (bool)(true);
				_leadType = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("LeadType").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("LeadTypeId") : Guid.Empty)));
				_budget = () => (int)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("Budget").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Decimal>("Budget") : 0m)));
				_opportunityResponsible = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_meetingTime = () => (DateTime)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))));
				_comment = () => new LocalizableString(((process.ReadActivityData.ResultEntity.IsColumnValueLoaded(process.ReadActivityData.ResultEntity.Schema.Columns.GetByName("DetailedResult").ColumnValueName) ? process.ReadActivityData.ResultEntity.GetTypedColumnValue<string>("DetailedResult") : null)));
				_decisionDate = () => (DateTime)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("DecisionDate").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<DateTime>("DecisionDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))));
				_opportunityDepartment = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("OpportunityDepartment").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("OpportunityDepartmentId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private LocalizableString _buttons;
			public override LocalizableString Buttons {
				get {
					return _buttons ?? (_buttons = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Buttons.Value"));
				}
				set {
					_buttons = value;
				}
			}

			private LocalizableString _elements;
			public override LocalizableString Elements {
				get {
					return _elements ?? (_elements = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Elements.Value"));
				}
				set {
					_elements = value;
				}
			}

			internal Func<bool> _showExecutionPage;
			public override bool ShowExecutionPage {
				get {
					return (_showExecutionPage ?? (_showExecutionPage = () => false)).Invoke();
				}
				set {
					_showExecutionPage = () => { return value; };
				}
			}

			private LocalizableString _informationOnStep;
			public override LocalizableString InformationOnStep {
				get {
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			internal Func<Guid> _leadType;
			public virtual Guid LeadType {
				get {
					return (_leadType ?? (_leadType = () => Guid.Empty)).Invoke();
				}
				set {
					_leadType = () => { return value; };
				}
			}

			internal Func<int> _budget;
			public virtual int Budget {
				get {
					return (_budget ?? (_budget = () => 0)).Invoke();
				}
				set {
					_budget = () => { return value; };
				}
			}

			internal Func<Guid> _opportunityResponsible;
			public virtual Guid OpportunityResponsible {
				get {
					return (_opportunityResponsible ?? (_opportunityResponsible = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunityResponsible = () => { return value; };
				}
			}

			internal Func<DateTime> _meetingTime;
			public virtual DateTime MeetingTime {
				get {
					return (_meetingTime ?? (_meetingTime = () => DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))).Invoke();
				}
				set {
					_meetingTime = () => { return value; };
				}
			}

			internal Func<string> _comment;
			public virtual string Comment {
				get {
					return (_comment ?? (_comment = () => null)).Invoke();
				}
				set {
					_comment = () => { return value; };
				}
			}

			internal Func<DateTime> _decisionDate;
			public virtual DateTime DecisionDate {
				get {
					return (_decisionDate ?? (_decisionDate = () => DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))).Invoke();
				}
				set {
					_decisionDate = () => { return value; };
				}
			}

			internal Func<Guid> _opportunityDepartment;
			public virtual Guid OpportunityDepartment {
				get {
					return (_opportunityDepartment ?? (_opportunityDepartment = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunityDepartment = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadLeadForHandoffFlowElement

		/// <exclude/>
		public class ReadLeadForHandoffFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadForHandoffFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadForHandoff";
				IsLogging = true;
				SchemaElementUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,100,21,91,146,109,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,191,98,201,52,193,236,127,175,108,103,83,200,161,148,222,10,58,140,70,243,222,188,121,140,230,123,231,63,186,38,224,88,89,104,60,38,211,193,84,36,67,38,24,160,162,66,151,37,21,32,107,170,108,94,83,97,10,100,41,207,121,46,107,146,116,208,98,69,54,244,222,184,64,18,23,176,245,213,237,252,155,52,140,19,38,247,118,189,124,213,39,108,225,219,210,64,100,96,165,138,13,202,60,141,180,88,215,84,106,208,212,90,174,234,66,72,145,161,38,155,22,45,176,96,32,74,90,167,44,143,165,220,208,90,3,82,174,114,205,153,176,38,183,146,36,13,218,176,127,26,70,244,222,245,93,53,227,107,124,243,60,68,149,91,239,93,223,76,109,71,146,22,3,92,67,56,85,4,48,69,145,107,160,90,168,200,110,177,164,192,149,161,28,234,146,149,18,179,34,43,73,162,97,8,11,45,57,24,146,24,8,240,29,154,9,87,230,217,69,141,140,167,153,204,139,136,205,184,166,130,179,148,202,66,150,212,154,194,42,228,133,82,181,185,248,245,105,114,49,118,254,106,106,113,116,250,197,118,140,254,245,99,53,235,190,11,99,223,44,212,87,107,249,13,62,133,205,220,151,167,31,219,64,33,230,23,16,57,39,147,199,93,227,176,11,251,78,247,198,117,15,27,231,249,28,33,237,0,163,243,23,23,246,143,19,52,36,25,221,195,233,143,110,237,38,31,250,246,63,26,53,137,99,70,142,184,100,171,220,101,7,141,243,67,3,207,235,189,34,239,30,167,62,124,248,140,96,182,136,188,65,84,228,142,228,2,82,80,70,209,92,27,67,215,173,144,172,136,59,138,25,207,36,150,105,89,179,59,18,85,252,3,247,237,193,127,249,217,93,254,192,166,250,248,62,102,223,36,174,47,200,106,254,27,57,231,227,34,232,120,142,231,23,149,211,217,112,202,3,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })));
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
								new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
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

		#region Class: ReadActivityDataFlowElement

		/// <exclude/>
		public class ReadActivityDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadActivityDataFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadActivityData";
				IsLogging = true;
				SchemaElementUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,111,212,48,20,252,43,149,15,156,226,85,28,59,137,29,78,176,44,104,47,75,37,22,132,212,174,170,23,251,185,107,145,143,109,226,136,86,81,254,59,206,166,11,82,15,168,7,46,72,62,216,207,158,121,51,163,231,241,206,245,31,93,229,177,43,44,84,61,70,195,214,20,36,231,9,66,198,24,77,227,76,81,33,153,161,32,211,132,90,149,150,9,40,46,83,131,36,106,160,198,130,44,232,141,113,158,68,206,99,221,23,55,227,31,82,223,13,24,221,217,243,225,139,62,98,13,95,231,6,90,8,101,36,79,40,8,173,169,40,99,70,75,101,82,42,129,37,90,132,22,86,42,178,104,65,137,220,166,165,166,152,161,160,2,115,77,161,180,57,213,60,99,162,204,76,170,84,78,162,10,173,223,60,158,58,236,123,215,54,197,136,191,247,251,167,83,80,185,244,94,183,213,80,55,36,170,209,195,53,248,99,65,0,99,20,169,6,170,133,74,169,176,152,83,224,202,80,14,101,158,228,18,89,198,2,187,134,147,159,105,201,214,144,200,128,135,111,80,13,120,102,30,93,208,152,240,152,201,52,11,88,198,131,29,158,196,84,102,50,167,214,100,86,33,207,148,42,205,37,175,79,131,11,123,215,239,134,26,59,167,159,99,199,144,95,219,21,163,110,27,223,181,213,76,189,59,63,223,227,163,95,194,125,190,250,190,24,242,161,62,131,200,20,13,61,174,43,135,141,223,52,186,53,174,185,95,56,167,41,64,234,19,116,174,191,164,176,121,24,160,34,81,231,238,143,127,77,107,61,244,190,173,255,35,171,81,176,25,56,194,144,157,229,206,51,104,92,127,170,224,233,124,46,200,155,135,161,245,111,247,208,255,40,174,62,160,117,13,94,189,127,183,219,175,230,202,213,214,44,215,228,5,77,65,110,137,148,178,228,74,100,148,151,202,134,1,49,72,165,65,164,92,165,0,146,113,198,180,94,137,36,87,44,101,130,106,59,255,23,20,37,133,88,1,45,179,36,7,109,116,72,70,222,146,160,255,95,169,186,217,246,159,127,54,151,47,181,132,112,88,133,234,139,194,166,194,58,164,85,140,175,177,49,5,192,245,165,85,49,190,198,212,116,152,109,29,166,176,126,1,177,30,142,224,74,4,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })));
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

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"));
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

			public AddDataUserTask1FlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_EntityId = () => (Guid)((process.LeadId));
				_recordDefValues_EntitySchemaUId = () => (Guid)(new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
				_recordDefValues_Message = () => new LocalizableString(String.Concat("Information about proceeding to handoff:", Environment.NewLine, (process.AutoGeneratedPageHandoff.Comment)));
				_recordDefValues_CreatedBy = () => (Guid)((process.AutoGeneratedPageHandoff.OwnerId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_EntityId", () => _recordDefValues_EntityId.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_EntitySchemaUId", () => _recordDefValues_EntitySchemaUId.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Message", () => _recordDefValues_Message.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_CreatedBy", () => _recordDefValues_CreatedBy.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_EntityId;
			internal Func<Guid> _recordDefValues_EntitySchemaUId;
			internal Func<string> _recordDefValues_Message;
			internal Func<Guid> _recordDefValues_CreatedBy;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,75,111,27,55,16,254,43,194,38,135,22,16,13,190,31,186,214,110,97,192,73,131,58,205,197,242,97,72,14,99,1,210,174,177,187,138,155,10,250,239,153,93,203,181,156,166,74,234,166,40,144,122,15,43,137,228,60,57,223,55,163,77,245,188,127,127,141,213,172,122,141,109,11,93,83,250,163,31,154,22,143,94,181,77,194,174,59,58,107,18,44,23,191,67,92,226,43,104,97,133,61,182,111,96,185,198,238,108,209,245,211,201,67,177,106,90,61,127,55,238,86,179,139,77,117,218,227,234,215,211,76,218,129,115,95,66,40,12,131,82,76,163,2,6,220,74,166,75,14,201,43,30,36,90,18,78,205,114,189,170,95,96,15,175,160,191,170,102,155,106,212,70,10,34,119,22,92,32,9,25,50,211,46,71,230,131,200,204,90,41,148,22,192,99,198,106,59,173,186,116,133,43,24,141,238,11,163,243,73,42,230,120,48,76,103,19,88,244,24,89,18,92,106,21,83,182,46,14,194,187,243,247,130,23,207,46,78,187,159,111,106,108,207,71,189,179,2,203,14,47,143,104,245,163,133,63,146,51,219,24,13,28,66,14,204,164,76,174,154,4,204,75,27,152,67,161,132,71,199,93,148,219,203,103,151,131,197,188,232,174,151,240,254,205,159,13,159,33,228,219,51,215,15,242,190,127,106,51,191,189,190,121,53,155,255,213,5,238,62,111,221,125,120,133,31,223,222,188,154,206,171,243,102,221,166,65,163,26,126,220,101,115,180,192,119,15,251,196,235,238,185,213,49,138,189,128,26,222,98,251,146,44,142,226,227,214,49,244,48,26,127,77,126,223,41,150,138,11,111,172,99,32,84,98,90,73,206,188,245,142,149,108,75,64,101,67,136,121,148,254,5,11,182,88,39,124,164,99,163,229,123,103,238,10,141,86,234,245,114,57,26,232,198,248,135,202,221,57,190,219,57,222,187,169,61,13,77,94,148,5,230,211,250,145,30,29,99,25,85,254,216,180,39,191,17,162,22,245,219,221,141,237,153,190,63,115,156,86,187,245,109,181,221,78,247,33,166,161,72,112,209,50,130,131,96,58,106,195,64,27,195,162,0,229,130,7,107,114,60,8,49,112,16,4,7,170,86,158,57,97,84,0,11,38,37,230,168,150,139,204,50,136,18,190,62,196,106,188,153,252,180,94,228,239,230,21,193,184,248,128,132,20,195,35,57,16,9,227,9,18,43,69,133,104,181,215,2,211,188,250,254,16,110,30,167,237,9,97,79,8,251,2,132,57,171,133,53,82,51,167,51,80,69,149,50,52,49,65,37,15,34,10,81,156,228,249,32,194,74,212,46,121,65,98,66,18,72,188,143,44,202,18,25,55,90,152,232,51,120,157,190,62,194,206,251,150,98,166,250,171,19,244,4,140,211,186,52,237,10,250,69,83,79,32,54,235,126,114,61,228,3,51,157,154,244,205,228,10,234,220,148,66,57,158,78,78,234,119,139,182,169,87,88,247,71,47,241,230,108,81,83,77,127,121,87,60,89,226,32,58,219,184,194,149,244,69,49,27,141,165,158,72,141,49,66,162,246,157,117,138,14,36,37,70,109,31,182,81,103,13,80,134,4,243,134,15,131,130,8,68,76,148,187,40,34,106,225,114,230,214,12,109,244,32,31,252,11,177,239,138,103,20,184,194,73,139,221,122,217,79,154,242,105,77,100,122,53,104,216,249,249,237,51,77,226,133,107,43,29,163,23,117,145,152,136,105,52,26,22,180,8,57,121,35,108,20,79,76,243,25,166,137,2,193,39,67,68,145,13,245,114,200,158,70,72,77,223,84,20,58,112,37,52,199,131,76,131,177,216,24,131,98,30,128,240,6,92,176,192,121,102,201,34,88,7,165,160,20,255,229,184,252,79,136,33,100,75,161,112,205,168,182,40,37,41,83,148,22,52,131,16,73,71,25,104,213,125,126,190,254,155,48,30,163,250,191,204,227,81,6,195,29,113,173,67,8,212,232,232,143,154,207,195,56,40,66,44,202,41,89,138,60,132,97,194,56,205,20,84,185,158,234,140,81,111,35,234,38,190,102,224,185,202,218,122,149,179,250,22,49,124,185,253,0,107,225,160,234,80,15,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7ee7590a758b4ee3990c188743946765",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
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

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("7a90900b-53b5-4598-92b3-0aee90626c56"));
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("66f33ed8-53ef-48cf-abf3-665749ecf6ac"));
				_recordColumnValues_Budget = () => (Decimal)((process.AutoGeneratedPageHandoff.Budget));
				_recordColumnValues_SalesOwner = () => (Guid)((process.AutoGeneratedPageHandoff.OpportunityResponsible));
				_recordColumnValues_MeetingDate = () => (DateTime)((process.AutoGeneratedPageHandoff.MeetingTime));
				_recordColumnValues_LeadType = () => (Guid)((process.AutoGeneratedPageHandoff.LeadType));
				_recordColumnValues_DecisionDate = () => (DateTime)((process.AutoGeneratedPageHandoff.DecisionDate));
				_recordColumnValues_OpportunityDepartment = () => (Guid)((process.AutoGeneratedPageHandoff.OpportunityDepartment));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Budget", () => _recordColumnValues_Budget.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_SalesOwner", () => _recordColumnValues_SalesOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_MeetingDate", () => _recordColumnValues_MeetingDate.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadType", () => _recordColumnValues_LeadType.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_DecisionDate", () => _recordColumnValues_DecisionDate.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_OpportunityDepartment", () => _recordColumnValues_OpportunityDepartment.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;
			internal Func<Guid> _recordColumnValues_LeadTypeStatus;
			internal Func<Decimal> _recordColumnValues_Budget;
			internal Func<Guid> _recordColumnValues_SalesOwner;
			internal Func<DateTime> _recordColumnValues_MeetingDate;
			internal Func<Guid> _recordColumnValues_LeadType;
			internal Func<DateTime> _recordColumnValues_DecisionDate;
			internal Func<Guid> _recordColumnValues_OpportunityDepartment;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,36,21,107,109,235,195,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,118,54,133,28,74,233,173,160,195,104,70,239,205,155,199,104,186,247,225,163,111,34,14,149,131,38,32,29,247,182,34,194,42,37,53,34,67,225,36,43,156,176,12,50,233,152,44,107,196,50,23,170,228,53,161,29,180,88,145,21,189,179,62,18,234,35,182,161,186,157,126,147,198,97,68,122,239,150,203,87,115,196,22,190,205,13,10,14,78,105,212,137,49,171,89,129,117,205,148,1,195,156,203,117,45,10,85,112,52,100,213,226,120,205,83,98,174,25,195,10,105,57,211,9,202,80,130,17,160,149,149,14,9,109,208,197,221,211,105,192,16,124,223,85,19,190,198,55,207,167,164,114,237,189,237,155,177,237,8,109,49,194,53,196,99,69,0,51,44,74,3,204,20,186,76,147,162,100,144,107,203,114,168,229,70,42,228,130,75,66,13,156,226,76,75,246,150,80,11,17,190,67,51,226,194,60,249,164,113,147,103,92,149,34,97,121,158,52,230,155,140,41,161,36,115,86,56,141,185,208,186,182,23,191,62,141,62,197,62,92,141,45,14,222,188,216,142,201,191,126,168,38,211,119,113,232,155,153,250,106,121,126,131,79,113,53,247,165,244,99,29,40,166,252,12,34,103,58,6,220,54,30,187,184,235,76,111,125,247,176,114,158,207,9,210,158,96,240,225,226,194,238,113,132,134,208,193,63,28,255,232,214,118,12,177,111,255,163,81,105,26,51,113,164,37,91,228,206,59,104,125,56,53,240,188,220,43,242,238,113,236,227,135,207,8,118,141,200,27,68,69,238,72,89,64,6,218,106,86,26,107,217,178,21,106,35,210,142,34,207,185,66,153,201,122,115,71,146,138,127,224,190,221,135,47,63,187,203,31,88,85,31,222,167,236,155,196,245,5,89,77,127,35,231,124,152,5,29,206,233,252,2,227,206,64,245,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,152,75,111,27,55,16,128,255,138,176,201,209,20,248,28,146,190,181,117,10,24,72,210,160,78,115,137,125,24,146,195,88,168,164,53,118,87,73,93,195,255,189,179,107,185,182,131,198,49,26,231,96,59,58,172,160,93,205,144,156,153,111,30,123,214,60,31,78,79,168,217,109,222,82,215,97,223,214,97,254,75,219,209,252,77,215,102,234,251,249,203,54,227,114,241,55,166,37,189,193,14,87,52,80,247,14,151,27,234,95,46,250,97,103,118,83,172,217,105,158,127,156,158,54,187,239,207,154,253,129,86,127,236,23,214,174,28,144,10,38,9,68,95,132,205,74,137,84,108,16,81,250,148,148,51,104,146,100,225,220,46,55,171,245,43,26,240,13,14,199,205,238,89,51,105,99,5,41,203,172,11,72,225,208,176,130,96,37,171,178,36,50,72,66,239,129,180,132,230,124,167,233,243,49,173,112,90,244,74,216,42,172,33,82,20,222,201,36,44,165,36,66,198,44,106,53,49,1,43,83,148,71,225,237,255,175,4,223,63,123,217,182,127,110,78,230,90,27,171,114,81,194,37,99,120,255,188,124,148,124,8,168,30,162,161,10,100,237,220,99,148,81,242,10,206,36,39,172,139,124,62,157,140,144,72,20,37,104,200,14,158,29,141,11,149,69,127,178,196,211,119,95,92,239,96,192,15,52,255,233,19,46,134,197,250,195,172,199,37,93,72,158,220,112,194,117,217,179,195,11,95,30,54,187,135,95,242,230,246,251,96,50,210,77,127,126,238,202,195,102,231,176,57,104,55,93,30,53,154,241,199,165,105,167,21,228,246,35,254,227,114,249,185,208,49,137,189,194,53,159,168,123,205,43,78,226,211,163,61,28,112,90,252,45,239,251,82,113,210,209,73,175,170,240,132,145,157,5,90,132,162,80,68,21,83,53,222,232,90,245,36,253,59,85,234,104,157,233,230,198,238,226,170,73,126,90,249,106,51,151,81,199,119,214,155,229,114,90,160,159,206,63,134,241,118,227,219,39,123,215,252,119,77,67,91,22,117,65,101,127,253,63,77,181,71,117,82,249,107,219,189,248,139,241,98,215,111,61,118,109,233,171,255,236,229,213,246,254,121,115,126,190,115,157,55,111,35,71,117,10,34,64,100,35,178,225,68,138,62,11,107,41,4,19,11,21,87,111,229,45,38,237,99,246,32,164,86,108,197,234,148,192,92,64,152,104,152,100,9,145,241,253,158,188,149,170,114,14,32,64,143,187,46,124,193,194,49,33,11,5,162,132,201,202,60,7,168,198,80,9,204,27,85,206,9,185,10,28,79,10,224,248,252,148,43,96,190,35,111,175,137,202,108,133,195,166,91,12,167,243,3,198,173,23,29,97,57,253,65,221,29,169,187,131,195,30,63,117,30,173,178,58,10,85,117,26,171,156,231,184,55,86,56,233,156,146,46,203,224,225,86,234,66,208,169,170,226,133,25,109,103,181,100,128,101,70,145,106,84,38,135,98,171,174,223,131,186,247,251,253,111,159,214,212,93,88,112,183,226,178,167,163,57,223,253,236,198,139,37,173,104,61,236,158,249,42,141,14,35,107,201,1,151,186,82,68,226,252,32,160,216,156,60,234,100,189,57,103,129,127,163,125,247,204,68,72,158,51,143,48,201,228,81,196,8,228,210,205,125,0,166,80,37,74,109,232,252,232,107,188,110,61,51,22,197,225,152,102,29,245,155,229,48,107,235,236,100,124,64,101,122,208,206,142,113,93,218,90,231,63,111,202,7,226,54,37,97,79,179,188,233,198,200,125,50,76,71,224,126,196,144,22,236,14,18,22,184,253,226,228,143,28,92,38,133,12,170,202,92,110,99,250,206,27,123,204,76,71,176,58,103,91,4,73,178,156,216,164,19,201,161,18,53,150,2,228,128,121,13,183,50,205,216,87,244,17,68,146,129,43,169,210,192,149,148,41,205,181,148,172,157,51,17,229,67,101,218,57,237,44,247,245,2,164,103,227,176,57,68,68,228,6,56,102,180,64,38,64,213,247,206,244,84,157,103,237,120,182,167,66,242,183,86,103,5,137,12,112,15,23,42,167,3,171,92,100,249,194,35,84,144,166,88,8,166,20,243,232,73,78,197,17,24,228,16,141,129,211,97,72,89,36,32,46,174,137,148,138,92,132,44,164,91,73,166,154,141,118,82,113,101,231,44,106,29,111,55,84,180,130,11,182,204,156,8,52,212,248,80,73,142,48,206,5,149,173,81,50,207,174,178,240,246,108,101,11,169,236,19,2,88,144,233,222,73,126,69,52,141,183,5,135,39,51,222,22,173,40,82,181,34,75,224,148,41,149,22,73,115,223,92,81,97,80,94,21,220,142,167,63,138,242,151,81,150,5,60,135,147,229,161,126,204,103,25,50,67,237,180,64,158,62,100,144,220,220,20,252,74,81,134,8,94,178,2,77,97,68,217,240,164,156,170,160,2,144,57,27,130,41,238,161,162,108,48,32,105,30,221,185,66,176,72,48,124,54,98,57,21,208,4,169,173,243,8,247,142,242,52,64,143,124,62,21,142,191,181,36,19,167,88,74,154,163,55,26,190,16,17,87,227,202,33,172,173,71,87,51,133,16,30,61,199,90,231,148,67,114,99,173,241,28,170,129,43,42,114,253,137,160,156,231,198,153,84,188,253,181,240,88,137,161,170,196,248,243,60,105,19,86,17,162,179,66,122,206,4,220,172,3,107,121,168,28,171,92,16,188,247,162,4,203,17,34,129,198,215,229,78,152,28,140,79,213,66,209,247,207,241,30,229,69,191,104,215,179,97,177,162,229,98,253,100,120,254,81,151,239,129,231,234,3,115,195,115,134,39,93,57,202,145,147,98,202,81,184,16,19,15,28,129,103,144,219,135,101,180,18,193,114,27,138,146,59,115,43,137,187,117,203,165,12,121,162,84,165,166,20,205,131,125,1,198,231,64,227,120,78,54,56,246,28,177,70,129,202,242,248,224,200,22,164,68,217,132,239,52,44,151,197,199,137,234,167,2,243,183,22,103,199,41,215,65,154,124,35,133,45,228,68,146,124,193,154,148,172,224,35,215,166,199,8,243,209,249,63,241,172,237,47,17,30,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7ee7590a758b4ee3990c188743946765",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
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

			public ChangeDataUserTask2FlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("7a90900b-53b5-4598-92b3-0aee90626c56"));
				_recordColumnValues_SaleType = () => new LocalizableString("Order");
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("66f33ed8-53ef-48cf-abf3-665749ecf6ac"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_SaleType", () => _recordColumnValues_SaleType.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;
			internal Func<string> _recordColumnValues_SaleType;
			internal Func<Guid> _recordColumnValues_LeadTypeStatus;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,100,21,127,200,150,228,30,183,219,178,80,210,64,183,37,144,44,97,36,141,178,2,127,197,150,105,130,241,127,175,108,103,83,200,161,148,222,10,58,140,198,122,111,222,60,207,76,247,110,248,228,42,143,125,105,161,26,48,26,15,166,36,5,7,203,10,174,104,174,117,76,25,15,145,176,133,164,25,160,50,134,51,203,84,78,162,6,106,44,201,134,222,27,231,73,228,60,214,67,121,59,253,38,245,253,136,209,189,93,47,223,244,25,107,248,190,20,96,9,88,33,81,82,158,199,138,50,84,161,128,6,77,173,205,164,42,152,96,9,106,178,105,97,8,104,83,38,40,136,92,80,102,211,16,41,145,82,43,181,74,243,140,89,133,138,68,190,119,245,71,240,120,116,53,94,67,31,148,133,130,199,118,73,109,26,42,180,126,255,212,245,56,12,174,109,202,9,95,227,227,115,23,218,216,196,237,218,106,172,27,18,5,56,92,131,63,151,4,48,70,150,107,160,154,201,60,148,71,78,33,147,38,88,161,120,202,5,38,69,194,73,164,161,243,11,45,57,24,18,25,240,240,3,170,17,87,230,201,133,38,210,44,78,68,94,4,108,146,105,202,178,52,166,162,16,156,90,83,88,137,89,33,165,50,23,67,63,143,46,196,110,184,26,107,236,157,126,249,47,24,12,110,251,114,210,109,227,251,182,90,168,175,214,231,71,124,242,155,251,47,159,110,182,134,124,200,47,32,50,71,227,128,187,202,97,227,247,141,110,141,107,30,54,206,121,14,144,186,131,222,13,23,23,246,143,35,84,36,234,221,195,249,143,110,237,198,193,183,245,127,212,106,212,93,134,98,149,187,12,169,113,67,87,193,243,122,47,201,187,199,177,245,31,190,32,152,45,34,111,16,37,185,35,57,131,24,164,145,97,45,140,161,235,84,136,52,172,5,199,36,75,4,242,152,171,244,142,4,21,255,192,125,123,24,190,254,108,46,75,178,169,62,189,15,217,55,137,215,225,46,167,191,145,51,159,22,65,167,57,156,95,86,230,180,189,235,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,77,111,219,70,16,253,43,198,38,71,141,176,95,220,15,223,130,184,5,12,56,137,17,39,185,68,57,204,238,206,38,66,37,209,32,169,180,142,161,255,158,17,45,195,82,209,56,66,209,92,140,242,64,130,220,125,243,134,243,230,237,220,138,231,195,205,53,137,83,241,142,186,14,251,182,14,211,151,109,71,211,203,174,205,212,247,211,139,54,227,98,254,13,211,130,46,177,195,37,13,212,125,192,197,154,250,139,121,63,76,78,14,97,98,34,158,127,29,87,197,233,199,91,113,62,208,242,253,121,225,232,228,85,44,222,121,160,170,3,88,138,9,66,72,25,42,81,81,53,84,107,170,102,112,110,23,235,229,234,21,13,120,137,195,23,113,122,43,198,104,28,32,101,153,117,113,18,26,52,5,108,176,18,16,45,65,118,146,208,123,71,90,58,177,153,136,62,127,161,37,142,164,15,96,171,176,134,72,17,124,35,19,179,39,102,207,200,236,213,196,228,56,152,162,188,5,239,246,63,0,63,62,187,104,219,63,214,215,83,173,141,85,185,40,104,146,49,96,51,211,71,169,20,184,234,93,52,84,29,89,59,245,24,101,148,204,208,152,212,128,109,98,128,168,147,1,137,68,81,58,237,114,227,158,125,218,18,149,121,127,189,192,155,15,63,228,187,26,240,51,77,95,252,137,243,97,190,250,124,210,227,130,238,144,215,7,34,236,99,111,103,119,90,206,196,233,236,71,106,238,158,87,99,145,14,245,252,187,148,51,49,153,137,171,118,221,229,109,68,179,125,185,47,237,200,32,119,23,252,195,237,254,186,139,49,194,94,225,138,255,168,123,205,140,35,124,92,58,195,1,71,242,119,156,247,125,224,164,99,35,189,170,224,9,35,139,229,52,132,162,16,162,138,169,26,111,116,173,122,68,191,165,74,29,173,50,29,38,118,140,84,35,126,100,126,72,230,190,235,248,203,106,189,88,140,4,253,248,255,219,54,222,37,190,91,57,219,211,111,47,66,91,230,117,78,229,124,245,47,75,117,70,117,12,249,123,219,253,246,23,219,139,165,223,41,182,71,253,176,231,44,47,119,223,55,98,179,153,236,251,77,81,169,78,98,5,82,129,59,222,35,215,175,241,108,0,237,125,86,210,231,20,220,79,252,134,65,121,50,108,25,199,126,147,220,203,33,72,11,161,137,209,74,163,100,113,225,191,247,219,76,188,233,10,117,51,241,152,73,14,54,61,125,63,24,221,160,55,41,128,172,214,131,181,40,129,11,168,193,59,201,45,29,164,52,152,31,243,195,209,137,61,101,63,20,29,81,113,67,243,41,146,249,104,174,202,64,76,201,114,71,86,139,41,234,64,73,62,234,135,152,180,143,217,59,144,154,177,182,54,10,48,23,7,38,26,71,74,186,152,138,253,149,243,167,84,149,115,112,224,180,207,96,11,223,144,7,39,200,66,129,40,97,178,50,79,157,171,198,80,9,60,127,168,242,140,204,21,144,143,76,112,174,241,54,82,174,14,243,145,243,231,53,207,229,147,37,14,235,110,62,220,76,175,120,252,244,208,17,150,155,255,167,208,145,83,232,8,193,158,162,235,62,109,190,3,19,102,106,192,83,10,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7ee7590a758b4ee3990c188743946765",
							"BaseElements.ChangeDataUserTask2.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
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

		public LeadManagementHandoff(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementHandoff";
			SchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7ee7590a-758b-4ee3-990c-188743946765");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementHandoff, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementHandoff, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid LeadId {
			get;
			set;
		}

		private ProcessLeadHandoff _leadHandoff;
		public ProcessLeadHandoff LeadHandoff {
			get {
				return _leadHandoff ?? ((_leadHandoff) = new ProcessLeadHandoff(UserConnection, this));
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
					SchemaElementUId = new Guid("00836aec-4306-4338-9ac5-67ea748b499b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateNurturing;
		public ProcessTerminateEvent TerminateNurturing {
			get {
				return _terminateNurturing ?? (_terminateNurturing = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateNurturing",
					SchemaElementUId = new Guid("75650cf9-cc74-4582-bca5-d68dbfe34907"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayLeadDefined;
		public ProcessExclusiveGateway ExclusiveGatewayLeadDefined {
			get {
				return _exclusiveGatewayLeadDefined ?? (_exclusiveGatewayLeadDefined = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayLeadDefined",
					SchemaElementUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayLeadDefined.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminateLeadUndefined;
		public ProcessTerminateEvent TerminateLeadUndefined {
			get {
				return _terminateLeadUndefined ?? (_terminateLeadUndefined = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateLeadUndefined",
					SchemaElementUId = new Guid("417b4b0e-9802-41ee-a1ee-f7c063ac01d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadLeadDataFlowElement _readLeadData;
		public ReadLeadDataFlowElement ReadLeadData {
			get {
				return _readLeadData ?? (_readLeadData = new ReadLeadDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ActivityUserTaskBANTFlowElement _activityUserTaskBANT;
		public ActivityUserTaskBANTFlowElement ActivityUserTaskBANT {
			get {
				return _activityUserTaskBANT ?? (_activityUserTaskBANT = new ActivityUserTaskBANTFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadStateToNoInterestFlowElement _changeLeadStateToNoInterest;
		public ChangeLeadStateToNoInterestFlowElement ChangeLeadStateToNoInterest {
			get {
				return _changeLeadStateToNoInterest ?? (_changeLeadStateToNoInterest = new ChangeLeadStateToNoInterestFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadNurturingFlowElement _changeLeadNurturing;
		public ChangeLeadNurturingFlowElement ChangeLeadNurturing {
			get {
				return _changeLeadNurturing ?? (_changeLeadNurturing = new ChangeLeadNurturingFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminateOpportunity;
		public ProcessTerminateEvent TerminateOpportunity {
			get {
				return _terminateOpportunity ?? (_terminateOpportunity = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateOpportunity",
					SchemaElementUId = new Guid("cf288ac2-175d-42be-a7ba-9dfdcc1724f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateNoInterest;
		public ProcessTerminateEvent TerminateNoInterest {
			get {
				return _terminateNoInterest ?? (_terminateNoInterest = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateNoInterest",
					SchemaElementUId = new Guid("5061ca01-0d15-463d-b233-768fa17131d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private AutoGeneratedPageHandoffFlowElement _autoGeneratedPageHandoff;
		public AutoGeneratedPageHandoffFlowElement AutoGeneratedPageHandoff {
			get {
				return _autoGeneratedPageHandoff ?? (_autoGeneratedPageHandoff = new AutoGeneratedPageHandoffFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadForHandoffFlowElement _readLeadForHandoff;
		public ReadLeadForHandoffFlowElement ReadLeadForHandoff {
			get {
				return _readLeadForHandoff ?? (_readLeadForHandoff = new ReadLeadForHandoffFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadActivityDataFlowElement _readActivityData;
		public ReadActivityDataFlowElement ReadActivityData {
			get {
				return _readActivityData ?? (_readActivityData = new ReadActivityDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask2FlowElement _changeDataUserTask2;
		public ChangeDataUserTask2FlowElement ChangeDataUserTask2 {
			get {
				return _changeDataUserTask2 ?? (_changeDataUserTask2 = new ChangeDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _conditionalFlowLeadUndefined;
		public ProcessConditionalFlow ConditionalFlowLeadUndefined {
			get {
				return _conditionalFlowLeadUndefined ?? (_conditionalFlowLeadUndefined = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowLeadUndefined",
					SchemaElementUId = new Guid("c46387cf-300b-4cd8-be2d-4740b8665e12"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow4;
		public ProcessConditionalFlow ConditionalFlow4 {
			get {
				return _conditionalFlow4 ?? (_conditionalFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow4",
					SchemaElementUId = new Guid("f4359b3c-140b-4cfa-a64a-624975aad45f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("89a7d2c0-103f-4f41-87f7-265a34bf1d89"),
						}},
					},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow9;
		public ProcessConditionalFlow ConditionalFlow9 {
			get {
				return _conditionalFlow9 ?? (_conditionalFlow9 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow9",
					SchemaElementUId = new Guid("1c27d27e-3f1d-4f64-a277-78d7380f5bb1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("e07f0e4a-f36b-1410-6698-00155d043204"),
						}},
					},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow7;
		public ProcessConditionalFlow ConditionalFlow7 {
			get {
				return _conditionalFlow7 ?? (_conditionalFlow7 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow7",
					SchemaElementUId = new Guid("37f09d58-5453-451a-97f7-c4f7dcacee68"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("a08e24ec-c5d1-4951-b49f-5e70dde6a7d9"),
						}},
					},
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
					SchemaElementUId = new Guid("23ff5267-6922-4cdf-bc26-a9d0f2ececcd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("d87d32bc-f36b-1410-6598-00155d043204"),
						}},
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
					SchemaElementUId = new Guid("8cdb95ca-c8ea-4880-b7cc-741fa584081f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("fdc13e7b-c600-487f-a398-7240d059ee6a"),
						}},
					},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start.SchemaElementUId] = new Collection<ProcessFlowElement> { Start };
			FlowElements[TerminateNurturing.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateNurturing };
			FlowElements[ExclusiveGatewayLeadDefined.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayLeadDefined };
			FlowElements[TerminateLeadUndefined.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateLeadUndefined };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ActivityUserTaskBANT.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUserTaskBANT };
			FlowElements[ChangeLeadStateToNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadStateToNoInterest };
			FlowElements[ChangeLeadNurturing.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadNurturing };
			FlowElements[TerminateOpportunity.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateOpportunity };
			FlowElements[TerminateNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateNoInterest };
			FlowElements[AutoGeneratedPageHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { AutoGeneratedPageHandoff };
			FlowElements[ReadLeadForHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadForHandoff };
			FlowElements[ReadActivityData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadActivityData };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ChangeDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayLeadDefined", e.Context.SenderName));
						break;
					case "TerminateNurturing":
						CompleteProcess();
						break;
					case "ExclusiveGatewayLeadDefined":
						if (ConditionalFlowLeadUndefinedExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateLeadUndefined", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
						break;
					case "TerminateLeadUndefined":
						CompleteProcess();
						break;
					case "ReadLeadData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActivityUserTaskBANT", e.Context.SenderName));
						break;
					case "ActivityUserTaskBANT":
						if (ConditionalFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadActivityData", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow9ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadStateToNoInterest", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow7ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadNurturing", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
							break;
						}
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask2", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ActivityUserTaskBANT");
						break;
					case "ChangeLeadStateToNoInterest":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateNoInterest", e.Context.SenderName));
						break;
					case "ChangeLeadNurturing":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateNurturing", e.Context.SenderName));
						break;
					case "TerminateOpportunity":
						CompleteProcess();
						break;
					case "TerminateNoInterest":
						CompleteProcess();
						break;
					case "AutoGeneratedPageHandoff":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "ReadLeadForHandoff":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AutoGeneratedPageHandoff", e.Context.SenderName));
						break;
					case "ReadActivityData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadForHandoff", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateOpportunity", e.Context.SenderName));
						break;
					case "ChangeDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateOpportunity", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlowLeadUndefinedExpressionExecute() {
			bool result = Convert.ToBoolean((LeadId) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayLeadDefined", "ConditionalFlowLeadUndefined", "(LeadId) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow4ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("89a7d2c0-103f-4f41-87f7-265a34bf1d89");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalFlow4", "ActivityUserTaskBANT.ActivityResult == new Guid(\"89a7d2c0-103f-4f41-87f7-265a34bf1d89\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private bool ConditionalFlow9ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("e07f0e4a-f36b-1410-6698-00155d043204");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalFlow9", "ActivityUserTaskBANT.ActivityResult == new Guid(\"e07f0e4a-f36b-1410-6698-00155d043204\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private bool ConditionalFlow7ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("a08e24ec-c5d1-4951-b49f-5e70dde6a7d9");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalFlow7", "ActivityUserTaskBANT.ActivityResult == new Guid(\"a08e24ec-c5d1-4951-b49f-5e70dde6a7d9\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("d87d32bc-f36b-1410-6598-00155d043204");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalFlow1", "ActivityUserTaskBANT.ActivityResult == new Guid(\"d87d32bc-f36b-1410-6598-00155d043204\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("fdc13e7b-c600-487f-a398-7240d059ee6a");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalSequenceFlow1", "ActivityUserTaskBANT.ActivityResult == new Guid(\"fdc13e7b-c600-487f-a398-7240d059ee6a\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("AutoGeneratedPageHandoff.LeadType")) {
				writer.WriteValue("AutoGeneratedPageHandoff.LeadType", AutoGeneratedPageHandoff.LeadType, Guid.Empty);
			}
			if (!HasMapping("AutoGeneratedPageHandoff.Budget")) {
				writer.WriteValue("AutoGeneratedPageHandoff.Budget", AutoGeneratedPageHandoff.Budget, 0);
			}
			if (!HasMapping("AutoGeneratedPageHandoff.OpportunityResponsible")) {
				writer.WriteValue("AutoGeneratedPageHandoff.OpportunityResponsible", AutoGeneratedPageHandoff.OpportunityResponsible, Guid.Empty);
			}
			if (!HasMapping("AutoGeneratedPageHandoff.MeetingTime")) {
				writer.WriteValue("AutoGeneratedPageHandoff.MeetingTime", AutoGeneratedPageHandoff.MeetingTime, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("AutoGeneratedPageHandoff.Comment")) {
				writer.WriteValue("AutoGeneratedPageHandoff.Comment", AutoGeneratedPageHandoff.Comment, null);
			}
			if (!HasMapping("AutoGeneratedPageHandoff.DecisionDate")) {
				writer.WriteValue("AutoGeneratedPageHandoff.DecisionDate", AutoGeneratedPageHandoff.DecisionDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("AutoGeneratedPageHandoff.OpportunityDepartment")) {
				writer.WriteValue("AutoGeneratedPageHandoff.OpportunityDepartment", AutoGeneratedPageHandoff.OpportunityDepartment, Guid.Empty);
			}
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
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
			MetaPathParameterValues.Add("54a0a9d9-5cdd-45ca-8269-7e1318e707b2", () => LeadId);
			MetaPathParameterValues.Add("fa68c1b9-9e12-4b99-bdde-6eb1806d8874", () => ReadLeadData.DataSourceFilters);
			MetaPathParameterValues.Add("99786611-0f56-4e3c-8f29-a4185ad1f427", () => ReadLeadData.ResultType);
			MetaPathParameterValues.Add("c21a605f-a60b-42ed-9061-294cc87b69a0", () => ReadLeadData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("8bb1e66c-1b41-4f67-ab42-57cdc5d866a6", () => ReadLeadData.NumberOfRecords);
			MetaPathParameterValues.Add("745423dc-b077-4526-8e74-98d8ad204cb8", () => ReadLeadData.FunctionType);
			MetaPathParameterValues.Add("5e1878c2-6cac-4d8b-baa8-a59f16943d8b", () => ReadLeadData.AggregationColumnName);
			MetaPathParameterValues.Add("1053c0e9-6404-4b90-bd4a-07157c475327", () => ReadLeadData.OrderInfo);
			MetaPathParameterValues.Add("8bc11220-5b0b-4d4e-a16c-25109fbcecd2", () => ReadLeadData.ResultEntity);
			MetaPathParameterValues.Add("952c2d22-d6b6-4a51-82ac-ec6cfa9a867e", () => ReadLeadData.ResultCount);
			MetaPathParameterValues.Add("ff499ce0-d575-4f90-b31d-15c099b5f8ee", () => ReadLeadData.ResultIntegerFunction);
			MetaPathParameterValues.Add("ddfda365-0d3d-45c9-84c5-ef97a50abd3e", () => ReadLeadData.ResultFloatFunction);
			MetaPathParameterValues.Add("7ced0725-a5ff-48ab-8329-db8cd92d45fc", () => ReadLeadData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("1bdef657-82b6-4e4c-9cba-7cc3f773ead3", () => ReadLeadData.ResultRowsCount);
			MetaPathParameterValues.Add("0e7bc406-b400-4ee2-8857-94f4a2ed4291", () => ReadLeadData.CanReadUncommitedData);
			MetaPathParameterValues.Add("a4c0fd5e-3b7e-4c6a-bf78-0b172e842a9f", () => ReadLeadData.ResultEntityCollection);
			MetaPathParameterValues.Add("ed0eae90-a660-43ec-85fa-c1bc0b2c7a5c", () => ReadLeadData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("4fb15793-1f5f-4afb-a9c5-7ee6d16f6cd6", () => ReadLeadData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("6fcf7170-2737-4d10-bb96-7b591a1f7593", () => ReadLeadData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("156dfda2-8f07-4454-b745-3aca84f7ef95", () => ReadLeadData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("5141e1f7-4af9-4bf4-b6d1-8874c0d2dc5f", () => ActivityUserTaskBANT.Recommendation);
			MetaPathParameterValues.Add("5b4637a8-7fc7-40e0-bfac-9cb675816ccf", () => ActivityUserTaskBANT.ActivityCategory);
			MetaPathParameterValues.Add("0902eded-b1a4-4f75-aa93-09fdf0aac605", () => ActivityUserTaskBANT.OwnerId);
			MetaPathParameterValues.Add("ba47d7d3-1ca5-41d1-9d6b-42ce60295158", () => ActivityUserTaskBANT.Duration);
			MetaPathParameterValues.Add("fdd5f4d6-8792-40d3-a46d-47a3545e3715", () => ActivityUserTaskBANT.DurationPeriod);
			MetaPathParameterValues.Add("5f4c4e07-469e-451a-88f4-305e2f6792b2", () => ActivityUserTaskBANT.StartIn);
			MetaPathParameterValues.Add("abdfdb50-a1ba-4d57-9207-b1dd297f6e84", () => ActivityUserTaskBANT.StartInPeriod);
			MetaPathParameterValues.Add("d6ff80f1-90c6-416a-90bb-260e00d506f7", () => ActivityUserTaskBANT.RemindBefore);
			MetaPathParameterValues.Add("4e14fc2e-ed85-4967-92f6-4ffd68e2401a", () => ActivityUserTaskBANT.RemindBeforePeriod);
			MetaPathParameterValues.Add("0685b12b-443e-4c64-ab26-d4859f0c8c4b", () => ActivityUserTaskBANT.ShowInScheduler);
			MetaPathParameterValues.Add("53d8ba23-d026-4fd0-9523-ad2d59cb13a1", () => ActivityUserTaskBANT.ShowExecutionPage);
			MetaPathParameterValues.Add("54f32772-50b2-49b4-a2a7-eee12cea8efc", () => ActivityUserTaskBANT.Lead);
			MetaPathParameterValues.Add("531d1563-ba9a-4e91-98ce-d35b182bca5f", () => ActivityUserTaskBANT.Account);
			MetaPathParameterValues.Add("fdb90180-2f4b-4831-b679-403593dd3b6f", () => ActivityUserTaskBANT.Contact);
			MetaPathParameterValues.Add("41dcb696-2cb1-4512-b3cf-dd1a7583a4ff", () => ActivityUserTaskBANT.Opportunity);
			MetaPathParameterValues.Add("d329e26e-4b48-4034-a14b-d1f9fe83945f", () => ActivityUserTaskBANT.Invoice);
			MetaPathParameterValues.Add("a61fc569-1cd9-4ee0-913c-ffb7359a1776", () => ActivityUserTaskBANT.Document);
			MetaPathParameterValues.Add("f7625075-971c-47b4-b67f-f12b29f07881", () => ActivityUserTaskBANT.Incident);
			MetaPathParameterValues.Add("71e2fad8-087d-4d30-853f-4284671382e2", () => ActivityUserTaskBANT.Case);
			MetaPathParameterValues.Add("b9471d7d-f83c-40ed-8479-ac97045d505d", () => ActivityUserTaskBANT.ActivityResult);
			MetaPathParameterValues.Add("42791514-cf69-4e4b-a09a-b627acdcf9e8", () => ActivityUserTaskBANT.CurrentActivityId);
			MetaPathParameterValues.Add("85441486-29f4-4732-bedf-744579a8ec72", () => ActivityUserTaskBANT.IsActivityCompleted);
			MetaPathParameterValues.Add("1ec1c9c1-eadf-4d15-a0fa-5e9731a46b43", () => ActivityUserTaskBANT.ExecutionContext);
			MetaPathParameterValues.Add("4c515728-a780-4846-a088-022faab38f6a", () => ActivityUserTaskBANT.InformationOnStep);
			MetaPathParameterValues.Add("5cf10363-3ca3-4fcf-a2e0-2c6f612c9aef", () => ActivityUserTaskBANT.Order);
			MetaPathParameterValues.Add("38749114-70e5-4e48-85a8-d4f5a5ff24c3", () => ActivityUserTaskBANT.Requests);
			MetaPathParameterValues.Add("725e7498-44eb-49c5-8104-b615cd2a44b3", () => ActivityUserTaskBANT.Listing);
			MetaPathParameterValues.Add("24e0015e-591a-49d6-b47e-f60c309ab061", () => ActivityUserTaskBANT.Property);
			MetaPathParameterValues.Add("ed86a088-1c5e-4485-b084-878f1a8d39df", () => ActivityUserTaskBANT.Contract);
			MetaPathParameterValues.Add("b14902c4-2013-48e9-b69e-d810c180118b", () => ActivityUserTaskBANT.Project);
			MetaPathParameterValues.Add("1138fd23-4b02-4812-9de6-6ecb917db660", () => ActivityUserTaskBANT.Problem);
			MetaPathParameterValues.Add("948d7cec-52ca-4a20-9991-67a3f04cc7c2", () => ActivityUserTaskBANT.Change);
			MetaPathParameterValues.Add("4b5d863d-2006-4c46-8f37-592fbfa512c0", () => ActivityUserTaskBANT.Release);
			MetaPathParameterValues.Add("af9569bc-af68-4326-b7bd-5c4ef9e17ea0", () => ActivityUserTaskBANT.QueueItem);
			MetaPathParameterValues.Add("094292f5-1d0c-46e2-a6f8-eb2e20a06d3e", () => ActivityUserTaskBANT.Application);
			MetaPathParameterValues.Add("1428d031-6da1-4c3b-becc-0d2348c4e851", () => ActivityUserTaskBANT.FinApplication);
			MetaPathParameterValues.Add("1aef7d2c-d9f4-44ff-a907-47abf8075765", () => ActivityUserTaskBANT.ActivityPriority);
			MetaPathParameterValues.Add("2c070493-7483-4c5e-a83b-3eb1c5d78ab7", () => ChangeLeadStateToNoInterest.EntitySchemaUId);
			MetaPathParameterValues.Add("c600955c-8b94-4c98-aee1-79c3c61d4140", () => ChangeLeadStateToNoInterest.IsMatchConditions);
			MetaPathParameterValues.Add("24bf952c-9579-4dcf-981f-f2cce1dbc830", () => ChangeLeadStateToNoInterest.DataSourceFilters);
			MetaPathParameterValues.Add("0c8a0e7e-306d-4ecc-b6cd-fbb09ef8707a", () => ChangeLeadStateToNoInterest.RecordColumnValues);
			MetaPathParameterValues.Add("27632760-23b5-4cb3-a0b9-909d22873875", () => ChangeLeadStateToNoInterest.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("091ab17a-49f8-4d9e-be81-1ca9c9dcb055", () => ChangeLeadNurturing.EntitySchemaUId);
			MetaPathParameterValues.Add("cbaa2dfb-5f4a-4bfc-9df0-93ddbbb25a13", () => ChangeLeadNurturing.IsMatchConditions);
			MetaPathParameterValues.Add("6f0df01f-2acd-4bc7-adec-34cfc25c9246", () => ChangeLeadNurturing.DataSourceFilters);
			MetaPathParameterValues.Add("38717ef0-c344-40ce-a5f4-e39c87df0d1d", () => ChangeLeadNurturing.RecordColumnValues);
			MetaPathParameterValues.Add("7ac82dc6-daa3-46a3-8567-fede289c90ea", () => ChangeLeadNurturing.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("37ca1e6d-f9a7-4c7f-ba6c-9ca142ff1579", () => AutoGeneratedPageHandoff.Title);
			MetaPathParameterValues.Add("92313c1a-6c83-4de1-b493-4b387b234357", () => AutoGeneratedPageHandoff.EntitySchemaUId);
			MetaPathParameterValues.Add("5854a389-d5a2-4dce-814f-9c06510637e6", () => AutoGeneratedPageHandoff.Recommendation);
			MetaPathParameterValues.Add("41d66075-70c0-453a-8022-cff5949370b2", () => AutoGeneratedPageHandoff.EntityId);
			MetaPathParameterValues.Add("3111f593-81b1-42b5-99a0-cd853a60b279", () => AutoGeneratedPageHandoff.Buttons);
			MetaPathParameterValues.Add("d88c0edd-7a1d-4087-b13e-ce975c3e925f", () => AutoGeneratedPageHandoff.Elements);
			MetaPathParameterValues.Add("7d35cac3-bad2-40c8-842e-1b639ac400c8", () => AutoGeneratedPageHandoff.ExtendedClientModule);
			MetaPathParameterValues.Add("f2e508ca-4b2f-4b48-976b-52653e3dbe10", () => AutoGeneratedPageHandoff.EntryPointId);
			MetaPathParameterValues.Add("478f0294-5119-41e8-ab5b-bc27d9882a36", () => AutoGeneratedPageHandoff.PressedButtonCode);
			MetaPathParameterValues.Add("9d600d04-bc01-4cd3-86a4-a9bb56f488b7", () => AutoGeneratedPageHandoff.OwnerId);
			MetaPathParameterValues.Add("a698c3a6-4b9a-4404-9178-0cd67c688925", () => AutoGeneratedPageHandoff.ShowExecutionPage);
			MetaPathParameterValues.Add("03fc2e34-8cdc-4158-9dd1-dafee46392f4", () => AutoGeneratedPageHandoff.InformationOnStep);
			MetaPathParameterValues.Add("97a4e728-73b0-4b7e-8a0e-313bec8ab330", () => AutoGeneratedPageHandoff.IsRunning);
			MetaPathParameterValues.Add("b1dd92e2-b196-4567-886d-afd46f7d61cc", () => AutoGeneratedPageHandoff.CurrentActivityId);
			MetaPathParameterValues.Add("a216e8c0-bfd3-4e51-a232-a26d5ccffb07", () => AutoGeneratedPageHandoff.CreateActivity);
			MetaPathParameterValues.Add("1321bb99-0d62-4a4a-8d29-353c09a23d4d", () => AutoGeneratedPageHandoff.ActivityPriority);
			MetaPathParameterValues.Add("586b06de-5dfb-43be-afb2-f574881bca46", () => AutoGeneratedPageHandoff.StartIn);
			MetaPathParameterValues.Add("d26ff5a0-6991-4a71-aa5a-46feacf7537c", () => AutoGeneratedPageHandoff.StartInPeriod);
			MetaPathParameterValues.Add("081d3969-dd55-41f7-bf2f-30cea119fbc9", () => AutoGeneratedPageHandoff.Duration);
			MetaPathParameterValues.Add("fe50e312-3895-4702-bdfe-90fe3728bb50", () => AutoGeneratedPageHandoff.DurationPeriod);
			MetaPathParameterValues.Add("cbd596b3-6a07-460f-aac7-582c3ffb6463", () => AutoGeneratedPageHandoff.ShowInScheduler);
			MetaPathParameterValues.Add("ea9ca265-54b9-47f1-a9f0-3901f038311b", () => AutoGeneratedPageHandoff.RemindBefore);
			MetaPathParameterValues.Add("d08aec7b-ebfe-4519-a9c6-a4dbe2b73789", () => AutoGeneratedPageHandoff.RemindBeforePeriod);
			MetaPathParameterValues.Add("51506cad-a901-4309-aee0-5a656a758325", () => AutoGeneratedPageHandoff.ActivityResult);
			MetaPathParameterValues.Add("e4e0c873-d65e-4828-bcf1-ffe5ee544361", () => AutoGeneratedPageHandoff.IsActivityCompleted);
			MetaPathParameterValues.Add("3a8ae276-d1a6-4833-8edd-18a3802457a6", () => AutoGeneratedPageHandoff.LeadType);
			MetaPathParameterValues.Add("396b79de-3b3c-45d3-aea7-bdab8f0a023e", () => AutoGeneratedPageHandoff.Budget);
			MetaPathParameterValues.Add("55254183-6074-4e56-9aab-59ca46e386f2", () => AutoGeneratedPageHandoff.OpportunityResponsible);
			MetaPathParameterValues.Add("968839fa-bdc5-40db-84fc-b1c7ba66460b", () => AutoGeneratedPageHandoff.MeetingTime);
			MetaPathParameterValues.Add("765a88b1-8502-4f19-801f-b1be417dd065", () => AutoGeneratedPageHandoff.Comment);
			MetaPathParameterValues.Add("1cda6777-d842-406e-9075-3c837bf46d26", () => AutoGeneratedPageHandoff.DecisionDate);
			MetaPathParameterValues.Add("476a3574-3ae8-49f9-a144-15e4daebec38", () => AutoGeneratedPageHandoff.OpportunityDepartment);
			MetaPathParameterValues.Add("6e73bc51-9c3d-46b9-99dc-388c60d1dae1", () => ReadLeadForHandoff.DataSourceFilters);
			MetaPathParameterValues.Add("c3ef0854-9dec-41d4-8d16-407475422cc6", () => ReadLeadForHandoff.ResultType);
			MetaPathParameterValues.Add("976150fd-e561-4fa6-9f3f-911949e5c42c", () => ReadLeadForHandoff.ReadSomeTopRecords);
			MetaPathParameterValues.Add("51bcbfaa-b77d-4c21-947e-02e0676d3545", () => ReadLeadForHandoff.NumberOfRecords);
			MetaPathParameterValues.Add("663137f9-795a-4269-b94a-83f9c02d10da", () => ReadLeadForHandoff.FunctionType);
			MetaPathParameterValues.Add("b1c37761-25d6-438c-bdbc-43b2a149b1ca", () => ReadLeadForHandoff.AggregationColumnName);
			MetaPathParameterValues.Add("73074895-abf7-4e2d-ad95-2629a87fc3d5", () => ReadLeadForHandoff.OrderInfo);
			MetaPathParameterValues.Add("69f1e87b-3dd8-44cf-8c4f-97bd0653ad06", () => ReadLeadForHandoff.ResultEntity);
			MetaPathParameterValues.Add("225fc2e7-3024-4f80-b9c4-c881e8aadeed", () => ReadLeadForHandoff.ResultCount);
			MetaPathParameterValues.Add("38d606ea-c1d2-4017-915e-893f7f96a610", () => ReadLeadForHandoff.ResultIntegerFunction);
			MetaPathParameterValues.Add("d8b37a80-9357-459a-9ca1-945f0af37bb5", () => ReadLeadForHandoff.ResultFloatFunction);
			MetaPathParameterValues.Add("3207b919-eb4b-44b7-9c43-5080d06b54a1", () => ReadLeadForHandoff.ResultDateTimeFunction);
			MetaPathParameterValues.Add("f24a8102-fb92-4bc4-b65f-c475f479a843", () => ReadLeadForHandoff.ResultRowsCount);
			MetaPathParameterValues.Add("8f0a63b7-c987-4e12-93c8-76a709a96645", () => ReadLeadForHandoff.CanReadUncommitedData);
			MetaPathParameterValues.Add("4af22b59-f62b-47c3-ad50-2c78bf148bf7", () => ReadLeadForHandoff.ResultEntityCollection);
			MetaPathParameterValues.Add("a1770417-d693-4416-9df8-379715d76f1e", () => ReadLeadForHandoff.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("5e6e3bcd-5e15-4652-84f8-98664792001d", () => ReadLeadForHandoff.IgnoreDisplayValues);
			MetaPathParameterValues.Add("a50e4bc1-e2da-47e3-870d-311693034d8d", () => ReadLeadForHandoff.ResultCompositeObjectList);
			MetaPathParameterValues.Add("4cd0ffd2-f5b3-400d-8196-85aa7dcced3e", () => ReadLeadForHandoff.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("b7a60eae-1035-42aa-a3a1-1572936331df", () => ReadActivityData.DataSourceFilters);
			MetaPathParameterValues.Add("51205379-8b3b-4d44-91b1-2cf7e081b07f", () => ReadActivityData.ResultType);
			MetaPathParameterValues.Add("f9078003-1806-4096-a752-6ce6fcaf6be3", () => ReadActivityData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("76950e9e-10e8-40f4-86ff-2e96d8188d1b", () => ReadActivityData.NumberOfRecords);
			MetaPathParameterValues.Add("93775e4e-88f1-48e9-ad74-74ac5f28d089", () => ReadActivityData.FunctionType);
			MetaPathParameterValues.Add("60cd6a65-a50a-4617-80ad-ed2c447da612", () => ReadActivityData.AggregationColumnName);
			MetaPathParameterValues.Add("72a0125d-b3d1-40d6-87c7-019a59320276", () => ReadActivityData.OrderInfo);
			MetaPathParameterValues.Add("946dd2c0-da26-457d-ad8c-4ba3167aa54d", () => ReadActivityData.ResultEntity);
			MetaPathParameterValues.Add("cd269b97-48c0-45a2-b046-e6a8730dbc7b", () => ReadActivityData.ResultCount);
			MetaPathParameterValues.Add("af08f6d6-b7c6-43d1-9f43-0d58376f1628", () => ReadActivityData.ResultIntegerFunction);
			MetaPathParameterValues.Add("1374d32a-f908-40e6-bf89-db89d892800d", () => ReadActivityData.ResultFloatFunction);
			MetaPathParameterValues.Add("5b57f2b2-ecee-4016-9433-31ce467f75e4", () => ReadActivityData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("c8013d26-15c8-4309-8bd8-b47ac03d9b59", () => ReadActivityData.ResultRowsCount);
			MetaPathParameterValues.Add("16f2c6ff-c1c8-4618-a4e9-e3c0db708ee5", () => ReadActivityData.CanReadUncommitedData);
			MetaPathParameterValues.Add("0d16c05d-2fc2-4a8a-8988-a0236870a419", () => ReadActivityData.ResultEntityCollection);
			MetaPathParameterValues.Add("d6aa112f-0172-4d91-a4d7-4aca0c91d611", () => ReadActivityData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("aa42b756-be31-4168-9f40-03d0cd697284", () => ReadActivityData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("f618c628-078b-4fab-81a7-240f5a62a2b2", () => ReadActivityData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("571db245-7db6-406f-a8a7-15a2bb0159b2", () => ReadActivityData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("de2b38a3-9f52-4d0b-8df6-067cb01d12fa", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("2486b970-ba2a-4d75-ad7e-6a6ca3693558", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("d0582550-2e0c-4765-8c6b-c7cbbd545084", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("0b9fe44f-dae0-43df-bf4f-456291e2c0f3", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("85beb4a5-021f-4174-8075-c753178d9f8c", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("ca953947-82c9-4fca-ad12-345201627164", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("a5128403-8408-4135-9d07-16147385bc38", () => AddDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("f7d955b1-b130-45d2-b90b-36a4a2ff1c1b", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("86baa44f-1be5-4c2b-afba-f50c69444878", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("ad1909b2-86a5-4387-ac62-e67d8d19b991", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("ea16bf89-752e-4e21-a5fa-2779bbe6a5de", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("b489a3e3-1617-471f-b59f-c1cc1901627e", () => ChangeDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("96352b96-718c-4854-ab6d-31d33673a18b", () => ChangeDataUserTask2.EntitySchemaUId);
			MetaPathParameterValues.Add("702f5fbb-ed10-4780-81d7-ed81fe787102", () => ChangeDataUserTask2.IsMatchConditions);
			MetaPathParameterValues.Add("24e70e39-6f35-420e-8745-11cb3e30fc29", () => ChangeDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("aa996c30-4714-41b7-ba32-536d65ced754", () => ChangeDataUserTask2.RecordColumnValues);
			MetaPathParameterValues.Add("6110e927-9c70-4dbd-9d6e-6ee7ead41e8b", () => ChangeDataUserTask2.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "AutoGeneratedPageHandoff.LeadType":
					AutoGeneratedPageHandoff.LeadType = reader.GetValue<System.Guid>();
				break;
				case "AutoGeneratedPageHandoff.Budget":
					AutoGeneratedPageHandoff.Budget = reader.GetValue<System.Int32>();
				break;
				case "AutoGeneratedPageHandoff.OpportunityResponsible":
					AutoGeneratedPageHandoff.OpportunityResponsible = reader.GetValue<System.Guid>();
				break;
				case "AutoGeneratedPageHandoff.MeetingTime":
					AutoGeneratedPageHandoff.MeetingTime = reader.GetValue<System.DateTime>();
				break;
				case "AutoGeneratedPageHandoff.Comment":
					AutoGeneratedPageHandoff.Comment = reader.GetValue<System.String>();
				break;
				case "AutoGeneratedPageHandoff.DecisionDate":
					AutoGeneratedPageHandoff.DecisionDate = reader.GetValue<System.DateTime>();
				break;
				case "AutoGeneratedPageHandoff.OpportunityDepartment":
					AutoGeneratedPageHandoff.OpportunityDepartment = reader.GetValue<System.Guid>();
				break;
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
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
			var cloneItem = (LeadManagementHandoff)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


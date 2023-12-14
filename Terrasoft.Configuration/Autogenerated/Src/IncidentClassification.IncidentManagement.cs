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

	#region Class: IncidentClassificationSchema

	/// <exclude/>
	public class IncidentClassificationSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public IncidentClassificationSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public IncidentClassificationSchema(IncidentClassificationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "IncidentClassification";
			UId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b");
			CreatedInPackageId = new Guid("4f61f5dc-c214-42b2-93aa-02d5c35156ab");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"8.1.0.6704";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b");
			Version = 0;
			PackageUId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateIncidentIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d383a904-01bc-48db-aa27-ea4bb618f782"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				Name = @"IncidentId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIncidentIdParameter());
		}

		protected virtual void InitializeSearchForParentParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var incidentIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("abceed8c-c3dd-4674-9bce-5ea3599b7797"),
				ContainerUId = new Guid("7a8a973b-3cac-4678-96a2-ebf2179751e0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Name = @"IncidentId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			incidentIdParameter.SourceValue = new ProcessSchemaParameterValue(incidentIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d383a904-01bc-48db-aa27-ea4bb618f782}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b")
			};
			parametrizedElement.Parameters.Add(incidentIdParameter);
			var isCaseCollectionAnyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("175e0f29-9e7d-46d8-add2-688541e40b0b"),
				ContainerUId = new Guid("7a8a973b-3cac-4678-96a2-ebf2179751e0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Name = @"IsCaseCollectionAny",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isCaseCollectionAnyParameter.SourceValue = new ProcessSchemaParameterValue(isCaseCollectionAnyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(isCaseCollectionAnyParameter);
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d9cd6ff7-8c44-4ad3-9dc6-8537b799e76a"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,147,205,106,220,48,20,133,95,165,104,209,149,85,44,201,182,100,103,57,76,203,108,210,129,166,165,144,12,225,90,186,202,8,252,51,177,100,154,96,230,221,43,219,153,20,178,40,133,174,2,94,72,215,62,71,223,57,200,211,189,243,159,93,19,112,168,44,52,30,147,113,103,42,194,20,87,34,151,72,45,207,11,154,165,28,40,136,84,211,50,179,53,34,104,193,185,36,73,7,45,86,100,85,111,141,11,36,113,1,91,95,221,78,127,76,195,48,98,114,111,151,205,55,125,196,22,190,47,7,48,105,4,183,37,85,92,230,52,203,69,70,85,198,24,101,186,40,24,203,53,150,218,144,149,5,69,42,12,8,75,107,43,36,205,0,57,85,145,130,234,58,151,160,76,212,206,44,13,218,176,125,58,13,232,189,235,187,106,194,215,245,205,243,41,82,174,103,111,250,102,108,59,146,180,24,96,15,225,88,17,192,20,179,92,3,213,89,25,65,44,202,152,180,52,84,64,45,185,84,200,10,22,221,53,156,194,108,75,118,145,202,64,128,31,208,140,184,56,79,46,50,114,145,50,149,23,81,203,132,166,153,224,41,85,133,146,212,154,194,150,40,138,178,172,205,165,175,47,163,139,107,231,175,199,22,7,167,95,106,199,216,95,63,84,147,238,187,48,244,205,108,125,189,124,126,131,79,97,45,247,229,213,207,53,80,136,243,89,68,206,201,232,113,211,56,236,194,182,211,189,113,221,195,234,121,62,71,73,123,130,193,249,75,11,219,199,17,26,146,12,238,225,248,215,182,54,163,15,125,251,142,162,38,49,102,244,136,151,108,193,157,239,160,113,254,212,192,243,178,175,200,199,199,177,15,87,251,161,215,49,39,154,15,174,211,206,68,159,117,78,222,232,43,114,71,140,80,2,202,52,163,41,171,99,80,101,106,10,192,37,69,200,234,186,96,202,74,197,239,72,100,250,239,147,110,119,254,235,175,238,242,127,172,137,14,159,226,244,205,96,127,81,86,211,191,192,157,15,51,222,225,28,159,223,212,60,27,63,230,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("478bb032-888a-4f41-9359-41cdb90d377e"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5979b1c3-b827-4ad7-a3eb-52822c581832"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b0b1805a-5abb-4475-805c-218ee548217c"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fdee5873-86f8-4f3d-aa5c-e69b12f97fee"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5d0fa38c-f2c2-4f78-95b6-f3676b75c8e1"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3c207d1d-42f2-4e68-bd85-e688aa78b24b"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,177,50,176,50,208,241,43,205,77,74,45,178,50,180,50,4,0,178,212,123,197,17,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("72f86497-87b0-46fe-bac9-b3db7791047b"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c7c58a2b-cac9-491c-b4c9-fb948db2f97f"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("661d1b62-01ff-4fa0-bfb4-5df1d5d0ba10"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("74411649-0f9c-415d-a4c8-9024b0f3ed9f"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("711a202f-1cdc-41ef-afd8-c20b828b210a"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8d5ec566-8e21-4a38-8039-ce6bb8fb64dd"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3a63bde1-e78c-404e-80db-ae395affa439"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("26f4ab8c-c295-46bd-be1d-c830377c5cff"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c3b3c15e-6fd3-4da9-8787-36b8370bf8df"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fe099617-16b2-4b5e-ab53-736d73a5c5b3"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0acbd958-8ae3-4658-a981-493a1f92ab02"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c1bb6c9d-15d4-4bca-a20b-b6bb085f80f4"),
				ContainerUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
			ProcessSchemaLaneSet schemaIncidentsClassification = CreateIncidentsClassificationLaneSet();
			LaneSets.Add(schemaIncidentsClassification);
			ProcessSchemaLane schemaFirstSupportLine = CreateFirstSupportLineLane();
			schemaIncidentsClassification.Lanes.Add(schemaFirstSupportLine);
			ProcessSchemaSubProcess searchforparent = CreateSearchForParentSubProcess();
			FlowElements.Add(searchforparent);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("49a737a4-9193-4f32-a219-0bb7e79b7131"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4f61f5dc-c214-42b2-93aa-02d5c35156ab"),
				CreatedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8842294e-237e-46c1-984d-cc0645df4cf2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("2670d16c-ad43-4008-9d0c-adc18008f4b5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4f61f5dc-c214-42b2-93aa-02d5c35156ab"),
				CreatedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a8a973b-3cac-4678-96a2-ebf2179751e0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0b514df5-26a2-44f1-982e-68d9d3618f2b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("6ee4d0dc-aa5b-4686-b8f5-2dc4374b7b45"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("409c047c-767f-4fe1-831e-6a5e6d719a3f"),
				CreatedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				CurveCenterPosition = new Point(384, 206),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a8a973b-3cac-4678-96a2-ebf2179751e0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateIncidentsClassificationLaneSet() {
			ProcessSchemaLaneSet schemaIncidentsClassification = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ea634c1e-a6c6-4dde-9ab0-402a332972fb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4f61f5dc-c214-42b2-93aa-02d5c35156ab"),
				CreatedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				Name = @"IncidentsClassification",
				Position = new Point(5, 5),
				Size = new Size(1093, 400),
				UseBackgroundMode = false
			};
			return schemaIncidentsClassification;
		}

		protected virtual ProcessSchemaLane CreateFirstSupportLineLane() {
			ProcessSchemaLane schemaFirstSupportLine = new ProcessSchemaLane(this) {
				UId = new Guid("d77f88d0-4bd4-432e-997a-1c08e49cf4f6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ea634c1e-a6c6-4dde-9ab0-402a332972fb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("4f61f5dc-c214-42b2-93aa-02d5c35156ab"),
				CreatedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				Name = @"FirstSupportLine",
				Position = new Point(29, 0),
				Size = new Size(1064, 400),
				UseBackgroundMode = false
			};
			return schemaFirstSupportLine;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("8842294e-237e-46c1-984d-cc0645df4cf2"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d77f88d0-4bd4-432e-997a-1c08e49cf4f6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4f61f5dc-c214-42b2-93aa-02d5c35156ab"),
				CreatedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
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
				UId = new Guid("0b514df5-26a2-44f1-982e-68d9d3618f2b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d77f88d0-4bd4-432e-997a-1c08e49cf4f6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4f61f5dc-c214-42b2-93aa-02d5c35156ab"),
				CreatedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				Name = @"Terminate1",
				Position = new Point(757, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d77f88d0-4bd4-432e-997a-1c08e49cf4f6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4f61f5dc-c214-42b2-93aa-02d5c35156ab"),
				CreatedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				Name = @"ReadDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(127, 170),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaSubProcess CreateSearchForParentSubProcess() {
			ProcessSchemaSubProcess schemaSearchForParent = new ProcessSchemaSubProcess(this) {
				UId = new Guid("7a8a973b-3cac-4678-96a2-ebf2179751e0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d77f88d0-4bd4-432e-997a-1c08e49cf4f6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4f61f5dc-c214-42b2-93aa-02d5c35156ab"),
				CreatedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b"),
				Name = @"SearchForParent",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(505, 170),
				SchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeSearchForParentParameters(schemaSearchForParent);
			return schemaSearchForParent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new IncidentClassification(userConnection);
		}

		public override object Clone() {
			return new IncidentClassificationSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("476a1146-b211-4c61-897d-fb0ea900085b"));
		}

		#endregion

	}

	#endregion

	#region Class: IncidentClassification

	/// <exclude/>
	public class IncidentClassification : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessFirstSupportLine

		/// <exclude/>
		public class ProcessFirstSupportLine : ProcessLane
		{

			public ProcessFirstSupportLine(UserConnection userConnection, IncidentClassification process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, IncidentClassification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("4529a033-5f2b-450c-89ad-ad746fe8ed5c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,147,205,106,220,48,20,133,95,165,104,209,149,85,44,201,182,100,103,57,76,203,108,210,129,166,165,144,12,225,90,186,202,8,252,51,177,100,154,96,230,221,43,219,153,20,178,40,133,174,2,94,72,215,62,71,223,57,200,211,189,243,159,93,19,112,168,44,52,30,147,113,103,42,194,20,87,34,151,72,45,207,11,154,165,28,40,136,84,211,50,179,53,34,104,193,185,36,73,7,45,86,100,85,111,141,11,36,113,1,91,95,221,78,127,76,195,48,98,114,111,151,205,55,125,196,22,190,47,7,48,105,4,183,37,85,92,230,52,203,69,70,85,198,24,101,186,40,24,203,53,150,218,144,149,5,69,42,12,8,75,107,43,36,205,0,57,85,145,130,234,58,151,160,76,212,206,44,13,218,176,125,58,13,232,189,235,187,106,194,215,245,205,243,41,82,174,103,111,250,102,108,59,146,180,24,96,15,225,88,17,192,20,179,92,3,213,89,25,65,44,202,152,180,52,84,64,45,185,84,200,10,22,221,53,156,194,108,75,118,145,202,64,128,31,208,140,184,56,79,46,50,114,145,50,149,23,81,203,132,166,153,224,41,85,133,146,212,154,194,150,40,138,178,172,205,165,175,47,163,139,107,231,175,199,22,7,167,95,106,199,216,95,63,84,147,238,187,48,244,205,108,125,189,124,126,131,79,97,45,247,229,213,207,53,80,136,243,89,68,206,201,232,113,211,56,236,194,182,211,189,113,221,195,234,121,62,71,73,123,130,193,249,75,11,219,199,17,26,146,12,238,225,248,215,182,54,163,15,125,251,142,162,38,49,102,244,136,151,108,193,157,239,160,113,254,212,192,243,178,175,200,199,199,177,15,87,251,161,215,49,39,154,15,174,211,206,68,159,117,78,222,232,43,114,71,140,80,2,202,52,163,41,171,99,80,101,106,10,192,37,69,200,234,186,96,202,74,197,239,72,100,250,239,147,110,119,254,235,175,238,242,127,172,137,14,159,226,244,205,96,127,81,86,211,191,192,157,15,51,222,225,28,159,223,212,60,27,63,230,3,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,177,50,176,50,208,241,43,205,77,74,45,178,50,180,50,4,0,178,212,123,197,17,0,0,0 })));
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

		#region Class: SearchForParentFlowElement

		/// <exclude/>
		public class SearchForParentFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public SearchForParentFlowElement(UserConnection userConnection, IncidentClassification process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a");
			}

			#endregion

			#region Properties: Public

			public Guid IncidentId {
				get {
					return GetParameterValue<Guid>("IncidentId");
				}
				set {
					SetParameterValue("IncidentId", value);
				}
			}

			public bool IsCaseCollectionAny {
				get {
					return GetParameterValue<bool>("IsCaseCollectionAny");
				}
				set {
					SetParameterValue("IsCaseCollectionAny", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (IncidentClassification)owner;
				Name = "SearchForParent";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("7a8a973b-3cac-4678-96a2-ebf2179751e0");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.FirstSupportLine;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (IncidentClassification)Owner;
				SetParameterValue("IncidentId", (Guid)((process.IncidentId)));
			}

			#endregion

		}

		#endregion

		public IncidentClassification(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "IncidentClassification";
			SchemaUId = new Guid("476a1146-b211-4c61-897d-fb0ea900085b");
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
				return new Guid("476a1146-b211-4c61-897d-fb0ea900085b");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: IncidentClassification, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: IncidentClassification, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid IncidentId {
			get;
			set;
		}

		private ProcessFirstSupportLine _firstSupportLine;
		public ProcessFirstSupportLine FirstSupportLine {
			get {
				return _firstSupportLine ?? ((_firstSupportLine) = new ProcessFirstSupportLine(UserConnection, this));
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
					SchemaElementUId = new Guid("8842294e-237e-46c1-984d-cc0645df4cf2"),
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
					SchemaElementUId = new Guid("0b514df5-26a2-44f1-982e-68d9d3618f2b"),
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

		private SearchForParentFlowElement _searchForParent;
		public SearchForParentFlowElement SearchForParent {
			get {
				return _searchForParent ?? ((_searchForParent) = new SearchForParentFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessToken _readDataUserTask1SearchForParentToken;
		public ProcessToken ReadDataUserTask1SearchForParentToken {
			get {
				return _readDataUserTask1SearchForParentToken ?? (_readDataUserTask1SearchForParentToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "ReadDataUserTask1SearchForParentToken",
					SchemaElementUId = new Guid("59620ed5-6e5e-40af-b19c-5b312044e581"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[SearchForParent.SchemaElementUId] = new Collection<ProcessFlowElement> { SearchForParent };
			FlowElements[ReadDataUserTask1SearchForParentToken.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1SearchForParentToken };
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
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1SearchForParentToken", e.Context.SenderName));
						break;
					case "SearchForParent":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1SearchForParentToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SearchForParent", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("IncidentId")) {
				writer.WriteValue("IncidentId", IncidentId, Guid.Empty);
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
			MetaPathParameterValues.Add("d383a904-01bc-48db-aa27-ea4bb618f782", () => IncidentId);
			MetaPathParameterValues.Add("d9cd6ff7-8c44-4ad3-9dc6-8537b799e76a", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("478bb032-888a-4f41-9359-41cdb90d377e", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("5979b1c3-b827-4ad7-a3eb-52822c581832", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("b0b1805a-5abb-4475-805c-218ee548217c", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("fdee5873-86f8-4f3d-aa5c-e69b12f97fee", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("5d0fa38c-f2c2-4f78-95b6-f3676b75c8e1", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("3c207d1d-42f2-4e68-bd85-e688aa78b24b", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("72f86497-87b0-46fe-bac9-b3db7791047b", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("c7c58a2b-cac9-491c-b4c9-fb948db2f97f", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("661d1b62-01ff-4fa0-bfb4-5df1d5d0ba10", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("74411649-0f9c-415d-a4c8-9024b0f3ed9f", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("711a202f-1cdc-41ef-afd8-c20b828b210a", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("8d5ec566-8e21-4a38-8039-ce6bb8fb64dd", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("3a63bde1-e78c-404e-80db-ae395affa439", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("26f4ab8c-c295-46bd-be1d-c830377c5cff", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("c3b3c15e-6fd3-4da9-8787-36b8370bf8df", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("fe099617-16b2-4b5e-ab53-736d73a5c5b3", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("0acbd958-8ae3-4658-a981-493a1f92ab02", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("c1bb6c9d-15d4-4bca-a20b-b6bb085f80f4", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("abceed8c-c3dd-4674-9bce-5ea3599b7797", () => SearchForParent.IncidentId);
			MetaPathParameterValues.Add("175e0f29-9e7d-46d8-add2-688541e40b0b", () => SearchForParent.IsCaseCollectionAny);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "IncidentId":
					if (!hasValueToRead) break;
					IncidentId = reader.GetValue<System.Guid>();
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
			var cloneItem = (IncidentClassification)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


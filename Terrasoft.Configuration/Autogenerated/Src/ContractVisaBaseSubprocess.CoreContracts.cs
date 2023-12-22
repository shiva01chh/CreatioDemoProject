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

	#region Class: ContractVisaBaseSubprocessSchema

	/// <exclude/>
	public class ContractVisaBaseSubprocessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ContractVisaBaseSubprocessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ContractVisaBaseSubprocessSchema(ContractVisaBaseSubprocessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContractVisaBaseSubprocess";
			UId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53");
			CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"8.1.0.6704";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
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
			RealUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53");
			Version = 0;
			PackageUId = new Guid("29c7b5a2-1b24-4486-9276-6f30e0b427b5");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateContractParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3a0d5732-da62-4c3b-a064-34320b6b3b70"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"Contract",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateVisaOwnerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c77907f0-2c9c-4bf7-8e77-d9e1cf50c135"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"VisaOwner",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateVisaObjectiveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("50d952fa-4e0b-414d-a1d6-444068fea4a1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"VisaObjective",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateVisaResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d2fd2fb7-ec08-4092-840e-40479398aece"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"VisaResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsAllowedToDelegateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3cafec33-e6b4-4fdf-b420-5fa70f8373c2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"IsAllowedToDelegate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsPreviousVisaCountsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2b0415c8-fe33-430e-b6b0-0d6cee817372"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"IsPreviousVisaCounts",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateContractParameter());
			Parameters.Add(CreateVisaOwnerParameter());
			Parameters.Add(CreateVisaObjectiveParameter());
			Parameters.Add(CreateVisaResultParameter());
			Parameters.Add(CreateIsAllowedToDelegateParameter());
			Parameters.Add(CreateIsPreviousVisaCountsParameter());
		}

		protected virtual void InitializeCancelPreviousVisasParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("6c9b198f-bc19-4b69-ab86-d1dd9334339a"),
				ContainerUId = new Guid("535b4886-240c-4ff4-917d-84b951475499"),
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
				Value = @"e2edcaf0-4bec-418f-9c13-b1e07e7244c5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("49cbb5c4-bd70-43aa-8f31-4879e73d2376"),
				ContainerUId = new Guid("535b4886-240c-4ff4-917d-84b951475499"),
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
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6d65720-6f5e-4f79-b9bc-19d68d9d465f"),
				ContainerUId = new Guid("535b4886-240c-4ff4-917d-84b951475499"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,151,223,111,219,54,16,199,255,23,61,236,73,55,240,167,72,122,79,109,144,13,5,134,172,64,183,98,64,17,20,71,242,216,8,149,37,87,146,183,22,134,255,247,157,237,184,51,178,52,200,146,22,88,128,189,8,18,165,59,222,29,63,223,35,181,121,219,78,63,182,221,76,227,162,96,55,81,189,126,145,23,149,146,209,20,19,9,48,4,5,70,104,9,33,21,9,72,228,181,179,74,144,75,85,221,227,146,22,213,193,250,60,183,115,85,183,51,45,167,197,155,205,223,78,231,113,77,245,219,178,127,120,149,174,104,137,191,237,38,32,69,57,97,17,192,147,36,48,210,23,158,64,106,136,146,132,35,167,140,73,182,58,196,146,101,131,5,173,133,212,196,6,12,5,3,222,59,2,145,74,78,65,74,103,67,169,234,142,202,124,254,113,53,210,52,181,67,191,216,208,231,251,95,63,173,56,202,195,220,103,67,183,94,246,85,189,164,25,95,226,124,181,168,10,137,92,48,121,246,30,8,140,51,6,162,208,2,114,19,130,15,218,166,32,76,85,39,92,205,59,183,213,217,208,207,35,38,78,117,164,66,35,245,137,78,178,242,193,69,210,100,64,104,173,193,52,46,115,168,164,32,58,12,198,38,145,189,20,85,157,113,198,215,216,173,105,31,217,166,101,195,168,130,21,78,22,112,132,129,115,108,20,248,44,17,130,12,177,104,167,85,41,234,88,239,159,135,225,253,122,197,181,158,46,214,75,26,219,116,189,112,196,43,48,140,139,77,218,133,56,116,59,231,23,39,6,135,5,186,126,249,251,161,40,221,254,205,206,176,218,214,235,137,206,186,150,250,249,188,79,67,110,251,119,251,181,219,110,217,102,185,194,177,157,142,165,60,255,176,198,142,11,208,190,187,186,179,228,103,235,105,30,150,79,45,223,154,115,101,55,140,235,62,230,29,205,185,157,86,29,126,218,63,47,170,239,62,172,135,249,135,35,8,135,167,234,134,213,241,43,141,34,91,78,7,50,114,138,38,233,8,40,26,3,218,104,37,98,19,117,116,226,218,195,182,126,196,60,111,94,76,191,252,217,31,21,118,40,208,229,247,60,122,99,224,229,209,122,177,185,79,104,219,203,99,112,151,204,193,87,85,117,80,2,99,182,9,228,78,114,198,229,2,94,170,8,145,132,108,168,228,88,210,99,84,173,53,58,75,130,249,202,236,61,138,6,208,72,1,49,80,208,74,55,198,70,121,162,234,103,171,213,56,252,65,227,23,84,205,173,208,196,128,236,39,177,170,83,44,128,18,185,99,80,18,42,73,190,132,244,212,40,255,95,213,183,170,237,8,194,221,106,75,206,5,225,24,115,149,2,99,30,139,3,79,206,65,14,36,83,177,130,145,183,119,171,250,126,243,60,64,213,247,9,237,27,170,186,81,168,117,44,25,74,99,185,169,32,55,21,47,145,32,203,40,99,212,146,124,240,15,87,117,114,89,137,6,89,136,66,114,32,34,88,136,104,52,56,235,146,47,50,72,62,28,156,238,213,200,58,238,40,223,202,106,224,30,103,99,241,32,74,217,37,101,36,120,174,29,40,163,4,223,96,225,50,30,89,125,62,12,29,97,255,47,96,61,187,162,244,254,249,240,241,38,170,105,55,30,121,252,54,80,247,62,31,161,204,207,24,60,173,132,111,145,230,77,57,236,63,252,6,184,38,163,69,196,220,64,81,166,48,174,204,108,212,198,67,180,81,99,246,46,113,197,30,142,171,245,196,167,193,134,192,105,207,155,16,111,119,124,180,220,169,82,176,99,214,162,71,147,79,112,125,53,227,188,158,110,223,130,154,134,1,183,152,192,178,4,192,20,242,16,44,10,240,1,131,39,237,138,117,229,169,181,228,127,130,126,49,204,95,135,245,255,112,214,247,220,136,126,26,177,159,41,223,189,63,144,11,252,235,18,53,232,196,231,56,163,201,1,90,254,139,225,115,20,74,101,169,145,90,157,180,250,203,237,95,229,214,90,236,237,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("11edda32-f2fb-41b4-8837-0586bfabade5"),
				ContainerUId = new Guid("535b4886-240c-4ff4-917d-84b951475499"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,221,111,130,48,16,255,87,150,198,71,106,64,139,136,175,99,75,76,116,49,211,249,50,246,112,180,87,37,225,195,20,92,230,8,255,251,74,197,128,203,124,152,125,184,166,189,251,125,244,122,21,25,148,167,3,146,25,217,160,82,80,228,178,28,62,230,10,135,43,149,115,44,138,225,34,231,144,196,223,16,37,184,2,5,41,150,168,182,144,28,177,88,196,69,105,61,92,195,136,69,6,159,38,75,102,239,21,153,151,152,190,205,133,102,119,166,238,196,155,78,60,202,192,149,148,141,164,71,193,103,156,10,119,204,109,225,79,124,17,249,26,204,243,228,152,102,75,44,97,5,229,158,204,42,98,216,52,1,247,196,200,158,0,80,102,59,92,7,223,165,17,176,49,245,92,143,79,165,227,59,12,125,82,91,164,224,123,76,193,136,118,96,28,161,224,32,109,202,34,212,96,103,42,169,207,157,49,141,28,180,61,244,70,140,113,183,1,183,245,29,112,163,244,166,19,34,46,14,9,156,182,183,242,135,171,214,244,43,170,240,220,225,144,204,194,91,61,110,247,181,177,126,221,229,223,13,14,137,21,146,117,126,84,188,97,116,154,195,229,193,70,193,110,23,253,35,92,214,153,195,192,150,144,193,14,213,139,86,52,112,147,10,160,4,35,190,209,190,255,77,252,138,18,21,102,28,239,52,102,148,59,51,151,89,208,55,217,49,73,140,64,97,222,223,12,87,107,188,205,4,189,95,234,49,228,34,150,49,138,121,118,167,163,0,165,161,124,206,213,211,151,30,250,56,219,181,63,214,147,238,106,2,158,182,247,53,169,235,143,250,7,202,11,197,88,99,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("726b18b2-8ee8-4fdb-8351-40addd8d68a2"),
				ContainerUId = new Guid("535b4886-240c-4ff4-917d-84b951475499"),
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

		protected virtual void InitializeAddVisaParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("69a4680b-dced-4f91-9736-b89098e9b12c"),
				ContainerUId = new Guid("8d004d94-5e54-4b1e-80a4-f03f34f6f0bd"),
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
				Value = @"e2edcaf0-4bec-418f-9c13-b1e07e7244c5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ce9ba715-9c2b-4b46-b3cd-a342eea5cf22"),
				ContainerUId = new Guid("8d004d94-5e54-4b1e-80a4-f03f34f6f0bd"),
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
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fbf6a978-d0cf-473f-8ce4-5a20e548bb14"),
				ContainerUId = new Guid("8d004d94-5e54-4b1e-80a4-f03f34f6f0bd"),
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
				UId = new Guid("3691ae8b-153d-41dc-8223-2f176da23196"),
				ContainerUId = new Guid("8d004d94-5e54-4b1e-80a4-f03f34f6f0bd"),
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
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a9c1fff-05ca-424d-919c-e1edf51210b3"),
				ContainerUId = new Guid("8d004d94-5e54-4b1e-80a4-f03f34f6f0bd"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,150,77,111,27,55,16,134,255,138,177,201,81,99,240,99,150,31,186,5,113,11,24,72,90,163,73,115,177,124,24,146,67,71,133,164,21,86,235,180,169,160,255,222,209,90,174,237,164,113,130,156,140,58,123,224,238,114,57,243,206,114,230,33,185,109,158,15,31,215,220,76,155,183,220,247,180,233,234,112,252,178,235,249,248,172,239,50,111,54,199,175,186,76,139,249,223,148,22,124,70,61,45,121,224,254,29,45,174,120,243,106,190,25,38,71,247,205,154,73,243,252,195,248,181,153,158,111,155,211,129,151,191,159,22,241,158,3,70,171,180,6,76,73,26,21,11,144,11,6,138,143,114,79,46,21,106,197,56,119,139,171,229,234,53,15,116,70,195,251,102,186,109,70,111,123,7,38,152,28,12,130,39,18,7,152,16,82,168,10,74,38,85,217,150,144,48,53,187,73,179,201,239,121,73,163,232,173,49,27,150,113,50,26,19,103,64,29,42,196,172,45,36,205,202,179,55,136,185,221,27,31,198,223,26,158,63,59,63,221,252,250,231,138,251,55,163,223,105,165,197,134,47,142,165,247,147,142,127,39,103,186,109,85,137,173,169,4,200,42,137,26,202,191,234,226,36,104,84,46,84,38,36,189,187,120,118,177,87,44,243,205,122,65,31,223,125,46,252,98,189,238,59,121,61,234,210,31,156,135,249,7,190,182,88,223,203,194,93,155,237,236,58,153,179,102,58,251,82,58,15,247,235,224,239,39,244,211,92,206,154,201,172,121,211,93,245,121,239,209,238,95,110,230,118,84,80,135,11,254,163,185,185,174,125,140,102,175,105,69,151,220,255,34,138,163,249,248,233,132,6,26,197,223,74,220,55,142,75,73,150,52,51,72,110,2,96,113,6,146,167,8,69,177,211,33,41,85,83,25,173,127,227,202,61,175,50,127,103,96,163,242,109,48,55,101,39,61,171,171,197,98,20,216,140,255,191,175,227,67,224,135,47,39,119,242,118,199,67,87,230,117,206,229,116,245,157,17,157,112,29,93,254,220,245,63,253,37,124,205,87,151,135,140,221,145,190,29,115,146,151,135,254,93,179,219,77,238,2,23,189,11,65,167,8,181,8,52,136,148,129,146,41,80,44,185,90,80,155,148,232,65,224,170,181,228,91,86,224,185,136,131,164,28,16,106,5,41,114,180,198,58,108,147,126,36,192,101,239,163,242,162,102,114,20,181,84,61,4,246,30,74,100,157,107,171,68,185,253,86,224,184,127,42,152,37,19,91,229,117,149,4,11,92,200,130,89,40,154,32,234,152,170,245,214,212,106,30,194,44,96,149,101,56,202,50,151,178,5,204,169,202,50,71,1,50,103,101,178,150,38,230,255,61,102,22,147,171,54,183,16,165,6,1,131,0,71,44,75,191,115,181,213,2,0,86,19,31,198,140,85,169,148,101,218,92,100,64,143,178,175,41,43,251,154,139,49,68,219,230,168,240,145,96,102,73,149,86,234,2,10,73,173,96,182,9,72,57,4,139,214,40,217,194,109,242,234,235,152,189,236,86,67,79,121,248,129,217,55,98,22,125,98,203,8,202,90,193,204,249,2,33,240,245,150,136,109,86,37,232,39,176,155,25,31,107,169,1,12,22,57,18,8,19,178,155,217,10,236,48,21,78,197,103,172,15,98,230,11,182,194,170,16,22,36,82,244,81,32,9,24,192,121,175,11,97,52,202,187,199,130,153,72,113,150,92,179,147,67,46,202,111,67,66,163,160,173,228,85,13,82,50,217,124,29,179,19,94,240,37,13,243,110,117,180,230,126,57,31,6,46,79,5,185,40,171,81,155,164,90,84,173,251,124,161,134,176,95,158,141,76,163,60,80,149,211,194,143,3,228,231,200,93,236,254,1,214,101,173,151,15,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("58cb0143-4eb3-4db4-b3d9-85dbab73eef1"),
				ContainerUId = new Guid("8d004d94-5e54-4b1e-80a4-f03f34f6f0bd"),
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
				UId = new Guid("be5e09cd-98c3-4140-8020-40aaffa76af3"),
				ContainerUId = new Guid("8d004d94-5e54-4b1e-80a4-f03f34f6f0bd"),
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

		protected virtual void InitializeVisaApprovedEventParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c031b7d4-47c5-4757-b402-f10b423e1766"),
				ContainerUId = new Guid("e6b71c76-86d0-43a1-8852-c815814f361e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8d004d94-5e54-4b1e-80a4-f03f34f6f0bd}].[Parameter:{58cb0143-4eb3-4db4-b3d9-85dbab73eef1}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeVisaRejectedEventParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a3b7e6ec-ad76-4a63-9b48-ee16803ca206"),
				ContainerUId = new Guid("b0ff5122-dde6-487d-a7e0-e7ba43e507a9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8d004d94-5e54-4b1e-80a4-f03f34f6f0bd}].[Parameter:{58cb0143-4eb3-4db4-b3d9-85dbab73eef1}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeVisaCanceledEventParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9cba3ba9-8b2e-4d4b-a3a5-ba1a989ed52a"),
				ContainerUId = new Guid("7c046ee4-d44b-49a9-9e4f-4606b8554bec"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8d004d94-5e54-4b1e-80a4-f03f34f6f0bd}].[Parameter:{58cb0143-4eb3-4db4-b3d9-85dbab73eef1}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeFindPositiveVisaParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2cb83f28-00c3-4498-b39b-2f4679606074"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,223,139,220,54,16,254,95,252,208,39,79,209,79,75,218,62,53,199,181,4,74,26,72,27,10,225,8,35,105,148,51,241,174,55,182,183,77,88,246,127,239,120,247,54,93,142,237,113,189,235,65,15,250,98,44,217,51,250,102,244,125,51,210,246,125,59,254,208,118,19,13,139,130,221,72,245,230,101,94,84,13,150,166,73,170,1,71,152,192,72,225,193,55,202,67,16,194,155,38,11,173,140,171,234,21,46,105,81,29,172,47,115,59,85,117,59,209,114,92,188,219,254,229,116,26,54,84,191,47,251,193,155,116,77,75,252,117,94,128,20,229,132,69,128,137,52,47,224,11,132,36,53,68,73,194,145,83,198,36,91,29,176,184,18,147,86,17,33,96,44,96,178,148,16,29,106,40,69,10,219,8,73,81,202,170,238,168,76,151,159,215,3,141,99,219,175,22,91,250,250,254,203,151,53,163,60,172,125,209,119,155,229,170,170,151,52,225,107,156,174,23,85,33,145,11,38,15,169,9,4,198,25,3,81,104,1,185,9,193,7,109,83,16,166,170,19,174,167,217,109,117,209,175,166,1,19,135,58,80,161,129,86,137,78,162,242,193,69,210,100,64,104,173,193,52,46,131,247,164,102,188,193,216,36,178,151,162,170,51,78,248,22,187,13,237,145,109,91,54,140,42,88,225,100,153,243,29,192,80,163,192,103,201,33,203,16,139,118,90,149,162,142,249,254,169,239,63,110,214,156,235,241,213,102,73,67,155,110,54,142,120,7,250,97,177,77,51,196,190,155,157,191,58,49,56,108,208,205,199,223,14,73,233,246,95,102,195,106,87,111,70,186,232,90,90,77,151,171,212,231,118,245,97,191,119,187,29,219,44,215,56,180,227,49,149,151,159,54,216,113,2,218,15,215,119,166,252,98,51,78,253,242,185,197,91,115,172,236,134,233,186,199,60,179,57,183,227,186,195,47,251,241,162,250,230,211,166,159,190,59,18,225,48,170,110,89,29,255,210,40,178,229,112,32,35,135,104,146,142,128,162,49,160,141,86,34,54,81,71,39,110,60,236,234,71,172,243,238,229,248,243,31,171,163,194,14,9,186,250,150,103,111,77,188,62,90,47,182,247,129,182,187,58,130,187,98,30,252,171,170,110,178,42,50,139,6,76,113,44,21,47,36,32,82,6,97,45,21,153,12,101,157,30,161,106,173,209,89,18,204,175,108,24,13,175,131,92,197,32,6,10,90,233,198,216,40,79,84,253,253,122,61,244,191,211,240,55,170,54,197,152,24,144,253,36,134,154,184,10,161,68,174,24,148,132,74,146,31,33,61,55,150,255,175,234,179,106,59,18,225,110,181,37,231,130,112,76,115,149,2,211,60,22,7,158,156,131,28,72,166,98,5,83,222,222,173,234,251,173,243,0,85,223,7,218,19,170,90,120,34,35,148,2,169,2,235,78,145,5,100,153,0,198,160,41,11,39,208,233,135,171,58,185,172,68,131,44,68,33,25,136,8,22,34,26,13,206,186,228,139,12,210,80,56,237,213,200,58,238,40,159,229,106,224,26,103,99,241,32,74,153,131,50,18,60,231,14,148,81,130,95,176,112,26,143,92,125,209,247,29,225,234,31,144,245,226,154,210,199,23,253,231,219,84,77,243,124,228,249,115,68,221,251,124,132,50,191,210,224,121,5,124,70,154,183,229,176,255,241,105,232,234,163,158,91,143,78,146,11,22,119,195,152,73,3,233,228,163,183,210,231,88,30,78,87,235,137,79,131,13,129,211,158,197,128,49,243,209,114,86,165,112,169,97,45,122,52,249,132,174,111,38,156,54,227,249,22,196,135,113,95,44,31,197,45,75,128,91,38,241,81,220,162,0,31,48,120,210,174,88,87,158,91,73,126,42,162,255,135,67,190,103,23,250,113,192,213,68,249,238,230,64,46,240,189,37,106,208,124,59,2,163,201,1,90,190,194,72,190,42,73,101,169,145,90,157,212,249,171,221,159,218,16,39,159,234,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9a26576c-c7c3-446c-84c6-01bfb60e881c"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6c8ba82f-8a97-45f4-84a5-d3fa4a515b71"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("71734acf-2f73-40f2-8700-2c88d70553ce"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e31e30a5-7698-42ba-bee5-b12248b7f70c"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("deaa2aa9-71f7-423c-950f-88351e8c8775"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,1,0,242,67,189,42,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bbaada9f-c766-4ba8-b5d1-b74d05465f22"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,177,50,176,50,208,241,79,202,74,77,46,201,44,75,181,50,180,50,4,0,6,191,96,252,20,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5"),
				UId = new Guid("468b242d-1dd5-4213-86e5-2cdc5fba51e2"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6348dc3-4710-49a2-8cd5-eafb895e4fa5"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0ed51c81-29b7-44dc-8000-5478283dbe98"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("38909994-7218-4923-acc1-cb94b885239e"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("19a6723d-07af-4e13-b781-faa4906b1b21"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("195b1cc1-73e4-4d81-b1bc-fba63109558b"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2cf29bbb-a6c1-49f3-b333-58f19e6a7f0f"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5"),
				UId = new Guid("b9d95ef0-203a-45b1-b583-ce4f734719f6"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eac06a30-8133-464e-b39f-0f9124e46853"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6fabb303-28c8-4090-9fa2-d74dd5df6abd"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("507b1628-1801-4371-a338-2979564dff30"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fab39ad9-950d-450d-bd0b-c3e83cdcb19b"),
				ContainerUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
			ProcessSchemaLaneSet schemaContractVisa = CreateContractVisaLaneSet();
			LaneSets.Add(schemaContractVisa);
			ProcessSchemaLane schemaBPMonline = CreateBPMonlineLane();
			schemaContractVisa.Lanes.Add(schemaBPMonline);
			ProcessSchemaStartEvent startprocess = CreateStartProcessStartEvent();
			FlowElements.Add(startprocess);
			ProcessSchemaTerminateEvent visarejectedendprocess = CreateVisaRejectedEndProcessTerminateEvent();
			FlowElements.Add(visarejectedendprocess);
			ProcessSchemaUserTask cancelpreviousvisas = CreateCancelPreviousVisasUserTask();
			FlowElements.Add(cancelpreviousvisas);
			ProcessSchemaUserTask addvisa = CreateAddVisaUserTask();
			FlowElements.Add(addvisa);
			ProcessSchemaEventBasedGateway visaeventgateway = CreateVisaEventGatewayEventBasedGateway();
			FlowElements.Add(visaeventgateway);
			ProcessSchemaIntermediateCatchSignalEvent visaapprovedevent = CreateVisaApprovedEventIntermediateCatchSignalEvent();
			FlowElements.Add(visaapprovedevent);
			ProcessSchemaIntermediateCatchSignalEvent visarejectedevent = CreateVisaRejectedEventIntermediateCatchSignalEvent();
			FlowElements.Add(visarejectedevent);
			ProcessSchemaTerminateEvent visaapprovedendprocess = CreateVisaApprovedEndProcessTerminateEvent();
			FlowElements.Add(visaapprovedendprocess);
			ProcessSchemaTerminateEvent visacanceledendprocess = CreateVisaCanceledEndProcessTerminateEvent();
			FlowElements.Add(visacanceledendprocess);
			ProcessSchemaIntermediateCatchSignalEvent visacanceledevent = CreateVisaCanceledEventIntermediateCatchSignalEvent();
			FlowElements.Add(visacanceledevent);
			ProcessSchemaUserTask findpositivevisa = CreateFindPositiveVisaUserTask();
			FlowElements.Add(findpositivevisa);
			ProcessSchemaTerminateEvent alreadyexistsvisaendprocess = CreateAlreadyExistsVisaEndProcessTerminateEvent();
			FlowElements.Add(alreadyexistsvisaendprocess);
			ProcessSchemaTerminateEvent errorendprocess = CreateErrorEndProcessTerminateEvent();
			FlowElements.Add(errorendprocess);
			ProcessSchemaExclusiveGateway inputparametersgateway = CreateInputParametersGatewayExclusiveGateway();
			FlowElements.Add(inputparametersgateway);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaFormulaTask formulatask2 = CreateFormulaTask2FormulaTask();
			FlowElements.Add(formulatask2);
			ProcessSchemaFormulaTask formulatask3 = CreateFormulaTask3FormulaTask();
			FlowElements.Add(formulatask3);
			ProcessSchemaFormulaTask formulatask4 = CreateFormulaTask4FormulaTask();
			FlowElements.Add(formulatask4);
			ProcessSchemaFormulaTask formulatask5 = CreateFormulaTask5FormulaTask();
			FlowElements.Add(formulatask5);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1dc82dd8-37b0-41c4-9be8-77f8c650aa55"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("535b4886-240c-4ff4-917d-84b951475499"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8d004d94-5e54-4b1e-80a4-f03f34f6f0bd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("1258d959-0f51-4d43-afc5-af858431206f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8d004d94-5e54-4b1e-80a4-f03f34f6f0bd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6d317fc3-3ec1-4167-8100-d452dfeebaa2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("5c1c448f-c2e7-4f3c-9182-e636a81e7f7c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6d317fc3-3ec1-4167-8100-d452dfeebaa2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b0ff5122-dde6-487d-a7e0-e7ba43e507a9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("bb9764a1-e3ab-4542-986c-92da3fd39779"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b0ff5122-dde6-487d-a7e0-e7ba43e507a9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("51f42a41-e4fc-4878-a6cd-34cd87dc1969"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("0f49d1bc-bc71-436e-843b-a34c46c48362"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(662, 160),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6d317fc3-3ec1-4167-8100-d452dfeebaa2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e6b71c76-86d0-43a1-8852-c815814f361e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("087d1368-afa9-40b9-be32-2694e52e92da"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(769, 120),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e6b71c76-86d0-43a1-8852-c815814f361e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("df06cffd-2788-47f3-aa36-e9630c969070"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("b9961282-3cb6-4502-aa85-4444430f651b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(649, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6d317fc3-3ec1-4167-8100-d452dfeebaa2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7c046ee4-d44b-49a9-9e4f-4606b8554bec"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("544d63d5-6acc-40a1-bb6e-8d8ea0190205"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(767, 302),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7c046ee4-d44b-49a9-9e4f-4606b8554bec"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0984b4ad-b023-4a3d-a496-1586cf9586d6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("7623fa5a-d0ea-4b67-a2d2-e48bf8f59eaf"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{80386e6f-06c0-42ef-980b-c608cd4c8d26}].[Parameter:{d6348dc3-4710-49a2-8cd5-eafb895e4fa5}]#]>0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(210, 289),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8dad276d-a200-40aa-92a0-bf4cb821d2fc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow10",
				UId = new Guid("56ad27c9-8324-4da0-9a9f-e48181195aca"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(308, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("535b4886-240c-4ff4-917d-84b951475499"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("2baf54f3-f62d-4407-a7f7-8673978956af"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{c77907f0-2c9c-4bf7-8e77-d9e1cf50c135}]#] == null || [#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{3a0d5732-da62-4c3b-a064-34320b6b3b70}]#] == null",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(151, 225),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("113c262b-8fe0-4413-8ba5-8315e16ea3f2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("77e77a39-537a-4a84-a052-aec8ab139324"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow11",
				UId = new Guid("b2f53c23-91cd-453e-afbb-fec1183a0551"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(215, 147),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("113c262b-8fe0-4413-8ba5-8315e16ea3f2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("19e5e6ad-7695-4006-8c97-6f41ed28c7c9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("933b0a22-b066-47b7-a1eb-22ad3b60df27"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(160, 147),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ec42dc50-18dd-4744-816b-b2811303d2e1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("113c262b-8fe0-4413-8ba5-8315e16ea3f2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("82a29c07-c98e-461a-acb1-adc459002e03"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(196, 324),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77e77a39-537a-4a84-a052-aec8ab139324"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3e0a1d3e-7215-4cac-807f-02a021ddd2a3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("15a2a359-fc14-47d5-b440-421f4c241560"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(769, 120),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("df06cffd-2788-47f3-aa36-e9630c969070"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e699229d-457b-40cc-94e1-d536113a8b65"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("21827e4a-8c02-4933-940e-dce0e25a9029"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(767, 302),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0984b4ad-b023-4a3d-a496-1586cf9586d6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f7ed8781-388b-41bb-913f-acec5ab5fa49"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("1d4dc3d3-4be4-49f6-8cfd-9309439632ce"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("51f42a41-e4fc-4878-a6cd-34cd87dc1969"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("de31436f-6b97-4b75-a6e9-12218945fb31"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("ebf681b6-4805-4601-87cf-3b22da74dcb5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(316, 312),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8dad276d-a200-40aa-92a0-bf4cb821d2fc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("10c69615-38e8-4a65-a9ab-7f0bfc22a18d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("4eed58cf-4e0d-47f2-9ad9-b5341d3c41e3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{2b0415c8-fe33-430e-b6b0-0d6cee817372}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(315, 216),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("19e5e6ad-7695-4006-8c97-6f41ed28c7c9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow17",
				UId = new Guid("8dde0824-6cfa-478e-901a-2c316c9deff5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				CurveCenterPosition = new Point(393, 148),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("19e5e6ad-7695-4006-8c97-6f41ed28c7c9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("535b4886-240c-4ff4-917d-84b951475499"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateContractVisaLaneSet() {
			ProcessSchemaLaneSet schemaContractVisa = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ece8cb92-e6e7-4b4d-8cec-dd9f3a5c15b4"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"ContractVisa",
				Position = new Point(5, 5),
				Size = new Size(1090, 487),
				UseBackgroundMode = false
			};
			return schemaContractVisa;
		}

		protected virtual ProcessSchemaLane CreateBPMonlineLane() {
			ProcessSchemaLane schemaBPMonline = new ProcessSchemaLane(this) {
				UId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ece8cb92-e6e7-4b4d-8cec-dd9f3a5c15b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"BPMonline",
				Position = new Point(29, 0),
				Size = new Size(1061, 487),
				UseBackgroundMode = false
			};
			return schemaBPMonline;
		}

		protected virtual ProcessSchemaStartEvent CreateStartProcessStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("ec42dc50-18dd-4744-816b-b2811303d2e1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"StartProcess",
				Position = new Point(57, 128),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateVisaRejectedEndProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("de31436f-6b97-4b75-a6e9-12218945fb31"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"VisaRejectedEndProcess",
				Position = new Point(911, 128),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateCancelPreviousVisasUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("535b4886-240c-4ff4-917d-84b951475499"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"CancelPreviousVisas",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(379, 114),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeCancelPreviousVisasParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddVisaUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("8d004d94-5e54-4b1e-80a4-f03f34f6f0bd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"AddVisa",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(498, 114),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddVisaParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventBasedGateway CreateVisaEventGatewayEventBasedGateway() {
			ProcessSchemaEventBasedGateway gateway = new ProcessSchemaEventBasedGateway(this) {
				UId = new Guid("6d317fc3-3ec1-4167-8100-d452dfeebaa2"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				Instantiate = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0ddbda75-9cac-4e42-b94c-5cf1edb45846"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"VisaEventGateway",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(617, 114),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateVisaApprovedEventIntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("e6b71c76-86d0-43a1-8852-c815814f361e"),
				AttachedToUId = Guid.Empty,
				BackgroundModePriority = BackgroundModePriority.Inherited,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"VisaApprovedEvent",
				NewEntityChangedColumns = false,
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(708, 44),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("58ebe36e-7384-4abd-b09c-407c6f508a4d");
			InitializeVisaApprovedEventParameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateVisaRejectedEventIntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("b0ff5122-dde6-487d-a7e0-e7ba43e507a9"),
				AttachedToUId = Guid.Empty,
				BackgroundModePriority = BackgroundModePriority.Inherited,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"VisaRejectedEvent",
				NewEntityChangedColumns = false,
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(708, 128),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("58ebe36e-7384-4abd-b09c-407c6f508a4d");
			InitializeVisaRejectedEventParameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateVisaApprovedEndProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("e699229d-457b-40cc-94e1-d536113a8b65"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"VisaApprovedEndProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(911, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateVisaCanceledEndProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("f7ed8781-388b-41bb-913f-acec5ab5fa49"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"VisaCanceledEndProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(911, 212),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateVisaCanceledEventIntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("7c046ee4-d44b-49a9-9e4f-4606b8554bec"),
				AttachedToUId = Guid.Empty,
				BackgroundModePriority = BackgroundModePriority.Inherited,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"VisaCanceledEvent",
				NewEntityChangedColumns = false,
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(708, 212),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("c7d206aa-401c-4095-ba43-757c8f1914e9");
			InitializeVisaCanceledEventParameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateFindPositiveVisaUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"FindPositiveVisa",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(246, 226),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeFindPositiveVisaParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateAlreadyExistsVisaEndProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("10c69615-38e8-4a65-a9ab-7f0bfc22a18d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"AlreadyExistsVisaEndProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(267, 429),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateErrorEndProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("3e0a1d3e-7215-4cac-807f-02a021ddd2a3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"ErrorEndProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(148, 317),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateInputParametersGatewayExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("113c262b-8fe0-4413-8ba5-8315e16ea3f2"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"InputParametersGateway",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(134, 114),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("77e77a39-537a-4a84-a052-aec8ab139324"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"FormulaTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(127, 226),
				ResultParameterMetaPath = @"d2fd2fb7-ec08-4092-840e-40479398aece",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,83,114,45,42,202,47,82,2,0,33,97,29,83,7,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("df06cffd-2788-47f3-aa36-e9630c969070"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"FormulaTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(792, 30),
				ResultParameterMetaPath = @"d2fd2fb7-ec08-4092-840e-40479398aece",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,83,114,44,40,40,202,47,75,77,81,2,0,254,184,194,168,10,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask3FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("0984b4ad-b023-4a3d-a496-1586cf9586d6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"FormulaTask3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(792, 198),
				ResultParameterMetaPath = @"d2fd2fb7-ec08-4092-840e-40479398aece",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,83,114,78,204,75,78,205,73,77,81,2,0,58,56,90,188,10,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask4FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("51f42a41-e4fc-4878-a6cd-34cd87dc1969"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"FormulaTask4",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(792, 114),
				ResultParameterMetaPath = @"d2fd2fb7-ec08-4092-840e-40479398aece",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,83,10,74,205,74,77,46,73,77,81,2,0,44,45,80,187,10,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask5FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("8dad276d-a200-40aa-92a0-bf4cb821d2fc"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"FormulaTask5",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(246, 338),
				ResultParameterMetaPath = @"d2fd2fb7-ec08-4092-840e-40479398aece",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,83,114,44,40,40,202,47,75,77,81,2,0,254,184,194,168,10,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("19e5e6ad-7695-4006-8c97-6f41ed28c7c9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(253, 114),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ContractVisaBaseSubprocess(userConnection);
		}

		public override object Clone() {
			return new ContractVisaBaseSubprocessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53"));
		}

		#endregion

	}

	#endregion

	#region Class: ContractVisaBaseSubprocess

	/// <exclude/>
	public class ContractVisaBaseSubprocess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessBPMonline

		/// <exclude/>
		public class ProcessBPMonline : ProcessLane
		{

			public ProcessBPMonline(UserConnection userConnection, ContractVisaBaseSubprocess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: CancelPreviousVisasFlowElement

		/// <exclude/>
		public class CancelPreviousVisasFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public CancelPreviousVisasFlowElement(UserConnection userConnection, ContractVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "CancelPreviousVisas";
				IsLogging = true;
				SchemaElementUId = new Guid("535b4886-240c-4ff4-917d-84b951475499");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_IsCanceled", () => _recordColumnValues_IsCanceled.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<bool> _recordColumnValues_IsCanceled;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,151,223,111,219,54,16,199,255,23,61,236,73,55,240,167,72,122,79,109,144,13,5,134,172,64,183,98,64,17,20,71,242,216,8,149,37,87,146,183,22,134,255,247,157,237,184,51,178,52,200,146,22,88,128,189,8,18,165,59,222,29,63,223,35,181,121,219,78,63,182,221,76,227,162,96,55,81,189,126,145,23,149,146,209,20,19,9,48,4,5,70,104,9,33,21,9,72,228,181,179,74,144,75,85,221,227,146,22,213,193,250,60,183,115,85,183,51,45,167,197,155,205,223,78,231,113,77,245,219,178,127,120,149,174,104,137,191,237,38,32,69,57,97,17,192,147,36,48,210,23,158,64,106,136,146,132,35,167,140,73,182,58,196,146,101,131,5,173,133,212,196,6,12,5,3,222,59,2,145,74,78,65,74,103,67,169,234,142,202,124,254,113,53,210,52,181,67,191,216,208,231,251,95,63,173,56,202,195,220,103,67,183,94,246,85,189,164,25,95,226,124,181,168,10,137,92,48,121,246,30,8,140,51,6,162,208,2,114,19,130,15,218,166,32,76,85,39,92,205,59,183,213,217,208,207,35,38,78,117,164,66,35,245,137,78,178,242,193,69,210,100,64,104,173,193,52,46,115,168,164,32,58,12,198,38,145,189,20,85,157,113,198,215,216,173,105,31,217,166,101,195,168,130,21,78,22,112,132,129,115,108,20,248,44,17,130,12,177,104,167,85,41,234,88,239,159,135,225,253,122,197,181,158,46,214,75,26,219,116,189,112,196,43,48,140,139,77,218,133,56,116,59,231,23,39,6,135,5,186,126,249,251,161,40,221,254,205,206,176,218,214,235,137,206,186,150,250,249,188,79,67,110,251,119,251,181,219,110,217,102,185,194,177,157,142,165,60,255,176,198,142,11,208,190,187,186,179,228,103,235,105,30,150,79,45,223,154,115,101,55,140,235,62,230,29,205,185,157,86,29,126,218,63,47,170,239,62,172,135,249,135,35,8,135,167,234,134,213,241,43,141,34,91,78,7,50,114,138,38,233,8,40,26,3,218,104,37,98,19,117,116,226,218,195,182,126,196,60,111,94,76,191,252,217,31,21,118,40,208,229,247,60,122,99,224,229,209,122,177,185,79,104,219,203,99,112,151,204,193,87,85,117,80,2,99,182,9,228,78,114,198,229,2,94,170,8,145,132,108,168,228,88,210,99,84,173,53,58,75,130,249,202,236,61,138,6,208,72,1,49,80,208,74,55,198,70,121,162,234,103,171,213,56,252,65,227,23,84,205,173,208,196,128,236,39,177,170,83,44,128,18,185,99,80,18,42,73,190,132,244,212,40,255,95,213,183,170,237,8,194,221,106,75,206,5,225,24,115,149,2,99,30,139,3,79,206,65,14,36,83,177,130,145,183,119,171,250,126,243,60,64,213,247,9,237,27,170,186,81,168,117,44,25,74,99,185,169,32,55,21,47,145,32,203,40,99,212,146,124,240,15,87,117,114,89,137,6,89,136,66,114,32,34,88,136,104,52,56,235,146,47,50,72,62,28,156,238,213,200,58,238,40,223,202,106,224,30,103,99,241,32,74,217,37,101,36,120,174,29,40,163,4,223,96,225,50,30,89,125,62,12,29,97,255,47,96,61,187,162,244,254,249,240,241,38,170,105,55,30,121,252,54,80,247,62,31,161,204,207,24,60,173,132,111,145,230,77,57,236,63,252,6,184,38,163,69,196,220,64,81,166,48,174,204,108,212,198,67,180,81,99,246,46,113,197,30,142,171,245,196,167,193,134,192,105,207,155,16,111,119,124,180,220,169,82,176,99,214,162,71,147,79,112,125,53,227,188,158,110,223,130,154,134,1,183,152,192,178,4,192,20,242,16,44,10,240,1,131,39,237,138,117,229,169,181,228,127,130,126,49,204,95,135,245,255,112,214,247,220,136,126,26,177,159,41,223,189,63,144,11,252,235,18,53,232,196,231,56,163,201,1,90,254,139,225,115,20,74,101,169,145,90,157,180,250,203,237,95,229,214,90,236,237,13,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,221,111,130,48,16,255,87,150,198,71,106,64,139,136,175,99,75,76,116,49,211,249,50,246,112,180,87,37,225,195,20,92,230,8,255,251,74,197,128,203,124,152,125,184,166,189,251,125,244,122,21,25,148,167,3,146,25,217,160,82,80,228,178,28,62,230,10,135,43,149,115,44,138,225,34,231,144,196,223,16,37,184,2,5,41,150,168,182,144,28,177,88,196,69,105,61,92,195,136,69,6,159,38,75,102,239,21,153,151,152,190,205,133,102,119,166,238,196,155,78,60,202,192,149,148,141,164,71,193,103,156,10,119,204,109,225,79,124,17,249,26,204,243,228,152,102,75,44,97,5,229,158,204,42,98,216,52,1,247,196,200,158,0,80,102,59,92,7,223,165,17,176,49,245,92,143,79,165,227,59,12,125,82,91,164,224,123,76,193,136,118,96,28,161,224,32,109,202,34,212,96,103,42,169,207,157,49,141,28,180,61,244,70,140,113,183,1,183,245,29,112,163,244,166,19,34,46,14,9,156,182,183,242,135,171,214,244,43,170,240,220,225,144,204,194,91,61,110,247,181,177,126,221,229,223,13,14,137,21,146,117,126,84,188,97,116,154,195,229,193,70,193,110,23,253,35,92,214,153,195,192,150,144,193,14,213,139,86,52,112,147,10,160,4,35,190,209,190,255,77,252,138,18,21,102,28,239,52,102,148,59,51,151,89,208,55,217,49,73,140,64,97,222,223,12,87,107,188,205,4,189,95,234,49,228,34,150,49,138,121,118,167,163,0,165,161,124,206,213,211,151,30,250,56,219,181,63,214,147,238,106,2,158,182,247,53,169,235,143,250,7,202,11,197,88,99,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "b4ef173acd864fed8781695413ee6e53",
							"BaseElements.CancelPreviousVisas.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("29c7b5a2-1b24-4486-9276-6f30e0b427b5");
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

		#region Class: AddVisaFlowElement

		/// <exclude/>
		public class AddVisaFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddVisaFlowElement(UserConnection userConnection, ContractVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddVisa";
				IsLogging = true;
				SchemaElementUId = new Guid("8d004d94-5e54-4b1e-80a4-f03f34f6f0bd");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Objective = () => new LocalizableString((process.VisaObjective));
				_recordDefValues_VisaOwner = () => (Guid)((process.VisaOwner));
				_recordDefValues_Contract = () => (Guid)((process.Contract));
				_recordDefValues_IsAllowedToDelegate = () => (bool)((process.IsAllowedToDelegate));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Objective", () => _recordDefValues_Objective.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_VisaOwner", () => _recordDefValues_VisaOwner.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contract", () => _recordDefValues_Contract.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsAllowedToDelegate", () => _recordDefValues_IsAllowedToDelegate.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Objective;
			internal Func<Guid> _recordDefValues_VisaOwner;
			internal Func<Guid> _recordDefValues_Contract;
			internal Func<bool> _recordDefValues_IsAllowedToDelegate;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,150,77,111,27,55,16,134,255,138,177,201,81,99,240,99,150,31,186,5,113,11,24,72,90,163,73,115,177,124,24,146,67,71,133,164,21,86,235,180,169,160,255,222,209,90,174,237,164,113,130,156,140,58,123,224,238,114,57,243,206,114,230,33,185,109,158,15,31,215,220,76,155,183,220,247,180,233,234,112,252,178,235,249,248,172,239,50,111,54,199,175,186,76,139,249,223,148,22,124,70,61,45,121,224,254,29,45,174,120,243,106,190,25,38,71,247,205,154,73,243,252,195,248,181,153,158,111,155,211,129,151,191,159,22,241,158,3,70,171,180,6,76,73,26,21,11,144,11,6,138,143,114,79,46,21,106,197,56,119,139,171,229,234,53,15,116,70,195,251,102,186,109,70,111,123,7,38,152,28,12,130,39,18,7,152,16,82,168,10,74,38,85,217,150,144,48,53,187,73,179,201,239,121,73,163,232,173,49,27,150,113,50,26,19,103,64,29,42,196,172,45,36,205,202,179,55,136,185,221,27,31,198,223,26,158,63,59,63,221,252,250,231,138,251,55,163,223,105,165,197,134,47,142,165,247,147,142,127,39,103,186,109,85,137,173,169,4,200,42,137,26,202,191,234,226,36,104,84,46,84,38,36,189,187,120,118,177,87,44,243,205,122,65,31,223,125,46,252,98,189,238,59,121,61,234,210,31,156,135,249,7,190,182,88,223,203,194,93,155,237,236,58,153,179,102,58,251,82,58,15,247,235,224,239,39,244,211,92,206,154,201,172,121,211,93,245,121,239,209,238,95,110,230,118,84,80,135,11,254,163,185,185,174,125,140,102,175,105,69,151,220,255,34,138,163,249,248,233,132,6,26,197,223,74,220,55,142,75,73,150,52,51,72,110,2,96,113,6,146,167,8,69,177,211,33,41,85,83,25,173,127,227,202,61,175,50,127,103,96,163,242,109,48,55,101,39,61,171,171,197,98,20,216,140,255,191,175,227,67,224,135,47,39,119,242,118,199,67,87,230,117,206,229,116,245,157,17,157,112,29,93,254,220,245,63,253,37,124,205,87,151,135,140,221,145,190,29,115,146,151,135,254,93,179,219,77,238,2,23,189,11,65,167,8,181,8,52,136,148,129,146,41,80,44,185,90,80,155,148,232,65,224,170,181,228,91,86,224,185,136,131,164,28,16,106,5,41,114,180,198,58,108,147,126,36,192,101,239,163,242,162,102,114,20,181,84,61,4,246,30,74,100,157,107,171,68,185,253,86,224,184,127,42,152,37,19,91,229,117,149,4,11,92,200,130,89,40,154,32,234,152,170,245,214,212,106,30,194,44,96,149,101,56,202,50,151,178,5,204,169,202,50,71,1,50,103,101,178,150,38,230,255,61,102,22,147,171,54,183,16,165,6,1,131,0,71,44,75,191,115,181,213,2,0,86,19,31,198,140,85,169,148,101,218,92,100,64,143,178,175,41,43,251,154,139,49,68,219,230,168,240,145,96,102,73,149,86,234,2,10,73,173,96,182,9,72,57,4,139,214,40,217,194,109,242,234,235,152,189,236,86,67,79,121,248,129,217,55,98,22,125,98,203,8,202,90,193,204,249,2,33,240,245,150,136,109,86,37,232,39,176,155,25,31,107,169,1,12,22,57,18,8,19,178,155,217,10,236,48,21,78,197,103,172,15,98,230,11,182,194,170,16,22,36,82,244,81,32,9,24,192,121,175,11,97,52,202,187,199,130,153,72,113,150,92,179,147,67,46,202,111,67,66,163,160,173,228,85,13,82,50,217,124,29,179,19,94,240,37,13,243,110,117,180,230,126,57,31,6,46,79,5,185,40,171,81,155,164,90,84,173,251,124,161,134,176,95,158,141,76,163,60,80,149,211,194,143,3,228,231,200,93,236,254,1,214,101,173,151,15,14,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "b4ef173acd864fed8781695413ee6e53",
							"BaseElements.AddVisa.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("29c7b5a2-1b24-4486-9276-6f30e0b427b5");
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

		#region Class: VisaApprovedEventFlowElement

		/// <exclude/>
		public class VisaApprovedEventFlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public VisaApprovedEventFlowElement(UserConnection userConnection, ContractVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "VisaApprovedEvent";
				IsLogging = false;
				SchemaElementUId = new Guid("e6b71c76-86d0-43a1-8852-c815814f361e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",""$values"":[""58ebe36e-7384-4abd-b09c-407c6f508a4d""]}";
				EntityFilters = @"{_isFilter:false,uId:""c0285505-677e-4cea-84d2-37df6c645ebf"",name:""FilterEdit"",items:[{_isFilter:true,_filterSchemaUId:""e2edcaf0-4bec-418f-9c13-b1e07e7244c5"",uId:""6015b714-a7d3-47f6-bb98-63fbe17da2f2"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""58ebe36e-7384-4abd-b09c-407c6f508a4d"",caption:""Status"",referenceSchemaUId:""66c8f5ac-57d2-4fe8-95a0-89a98e37f57f"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true},parameterValues:[{displayValue:""&quot;Granted&quot;"",parameterValue:""&quot;e79facb3-3c32-43e7-a59e-12ba125e6132&quot;""}]}},{_isFilter:true,_filterSchemaUId:""e2edcaf0-4bec-418f-9c13-b1e07e7244c5"",uId:""dd728109-65d2-4661-b30a-c56a7b3cf587"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""c7d206aa-401c-4095-ba43-757c8f1914e9"",caption:""Canceled"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false},parameterValues:[{parameterValue:""false""}]}}]}";
				_recordId = () => (Guid)((process.AddVisa.RecordId));
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

		#region Class: VisaRejectedEventFlowElement

		/// <exclude/>
		public class VisaRejectedEventFlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public VisaRejectedEventFlowElement(UserConnection userConnection, ContractVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "VisaRejectedEvent";
				IsLogging = false;
				SchemaElementUId = new Guid("b0ff5122-dde6-487d-a7e0-e7ba43e507a9");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",""$values"":[""58ebe36e-7384-4abd-b09c-407c6f508a4d""]}";
				EntityFilters = @"{_isFilter:false,uId:""a4e00283-aeb3-447c-8f98-d96408285b25"",name:""FilterEdit"",items:[{_isFilter:true,_filterSchemaUId:""e2edcaf0-4bec-418f-9c13-b1e07e7244c5"",uId:""fceb530d-c1fd-474b-9f1b-bfbf3c1c5e12"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""58ebe36e-7384-4abd-b09c-407c6f508a4d"",caption:""Status"",referenceSchemaUId:""66c8f5ac-57d2-4fe8-95a0-89a98e37f57f"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true},parameterValues:[{displayValue:""&quot;Rejected&quot;"",parameterValue:""&quot;a93ab0b9-ca36-4b95-9b23-e01aa169c338&quot;""}]}},{_isFilter:true,_filterSchemaUId:""e2edcaf0-4bec-418f-9c13-b1e07e7244c5"",uId:""09e9eb10-1458-4a32-938e-20e56cde2704"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""c7d206aa-401c-4095-ba43-757c8f1914e9"",caption:""Canceled"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false},parameterValues:[{parameterValue:""false""}]}}]}";
				_recordId = () => (Guid)((process.AddVisa.RecordId));
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

		#region Class: VisaCanceledEventFlowElement

		/// <exclude/>
		public class VisaCanceledEventFlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public VisaCanceledEventFlowElement(UserConnection userConnection, ContractVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "VisaCanceledEvent";
				IsLogging = false;
				SchemaElementUId = new Guid("7c046ee4-d44b-49a9-9e4f-4606b8554bec");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",""$values"":[""c7d206aa-401c-4095-ba43-757c8f1914e9""]}";
				EntityFilters = @"{_isFilter:false,uId:""4491cfc0-beff-4e52-a226-7603ab3e4f16"",name:""FilterEdit"",items:[{_isFilter:true,_filterSchemaUId:""e2edcaf0-4bec-418f-9c13-b1e07e7244c5"",uId:""01d4b4fd-a90b-4e44-b49a-37749e2d75b4"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""c7d206aa-401c-4095-ba43-757c8f1914e9"",caption:""Canceled"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false},parameterValues:[{parameterValue:""true""}]}}]}";
				_recordId = () => (Guid)((process.AddVisa.RecordId));
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

		#region Class: FindPositiveVisaFlowElement

		/// <exclude/>
		public class FindPositiveVisaFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public FindPositiveVisaFlowElement(UserConnection userConnection, ContractVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "FindPositiveVisa";
				IsLogging = true;
				SchemaElementUId = new Guid("80386e6f-06c0-42ef-980b-c608cd4c8d26");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,223,139,220,54,16,254,95,252,208,39,79,209,79,75,218,62,53,199,181,4,74,26,72,27,10,225,8,35,105,148,51,241,174,55,182,183,77,88,246,127,239,120,247,54,93,142,237,113,189,235,65,15,250,98,44,217,51,250,102,244,125,51,210,246,125,59,254,208,118,19,13,139,130,221,72,245,230,101,94,84,13,150,166,73,170,1,71,152,192,72,225,193,55,202,67,16,194,155,38,11,173,140,171,234,21,46,105,81,29,172,47,115,59,85,117,59,209,114,92,188,219,254,229,116,26,54,84,191,47,251,193,155,116,77,75,252,117,94,128,20,229,132,69,128,137,52,47,224,11,132,36,53,68,73,194,145,83,198,36,91,29,176,184,18,147,86,17,33,96,44,96,178,148,16,29,106,40,69,10,219,8,73,81,202,170,238,168,76,151,159,215,3,141,99,219,175,22,91,250,250,254,203,151,53,163,60,172,125,209,119,155,229,170,170,151,52,225,107,156,174,23,85,33,145,11,38,15,169,9,4,198,25,3,81,104,1,185,9,193,7,109,83,16,166,170,19,174,167,217,109,117,209,175,166,1,19,135,58,80,161,129,86,137,78,162,242,193,69,210,100,64,104,173,193,52,46,131,247,164,102,188,193,216,36,178,151,162,170,51,78,248,22,187,13,237,145,109,91,54,140,42,88,225,100,153,243,29,192,80,163,192,103,201,33,203,16,139,118,90,149,162,142,249,254,169,239,63,110,214,156,235,241,213,102,73,67,155,110,54,142,120,7,250,97,177,77,51,196,190,155,157,191,58,49,56,108,208,205,199,223,14,73,233,246,95,102,195,106,87,111,70,186,232,90,90,77,151,171,212,231,118,245,97,191,119,187,29,219,44,215,56,180,227,49,149,151,159,54,216,113,2,218,15,215,119,166,252,98,51,78,253,242,185,197,91,115,172,236,134,233,186,199,60,179,57,183,227,186,195,47,251,241,162,250,230,211,166,159,190,59,18,225,48,170,110,89,29,255,210,40,178,229,112,32,35,135,104,146,142,128,162,49,160,141,86,34,54,81,71,39,110,60,236,234,71,172,243,238,229,248,243,31,171,163,194,14,9,186,250,150,103,111,77,188,62,90,47,182,247,129,182,187,58,130,187,98,30,252,171,170,110,178,42,50,139,6,76,113,44,21,47,36,32,82,6,97,45,21,153,12,101,157,30,161,106,173,209,89,18,204,175,108,24,13,175,131,92,197,32,6,10,90,233,198,216,40,79,84,253,253,122,61,244,191,211,240,55,170,54,197,152,24,144,253,36,134,154,184,10,161,68,174,24,148,132,74,146,31,33,61,55,150,255,175,234,179,106,59,18,225,110,181,37,231,130,112,76,115,149,2,211,60,22,7,158,156,131,28,72,166,98,5,83,222,222,173,234,251,173,243,0,85,223,7,218,19,170,90,120,34,35,148,2,169,2,235,78,145,5,100,153,0,198,160,41,11,39,208,233,135,171,58,185,172,68,131,44,68,33,25,136,8,22,34,26,13,206,186,228,139,12,210,80,56,237,213,200,58,238,40,159,229,106,224,26,103,99,241,32,74,153,131,50,18,60,231,14,148,81,130,95,176,112,26,143,92,125,209,247,29,225,234,31,144,245,226,154,210,199,23,253,231,219,84,77,243,124,228,249,115,68,221,251,124,132,50,191,210,224,121,5,124,70,154,183,229,176,255,241,105,232,234,163,158,91,143,78,146,11,22,119,195,152,73,3,233,228,163,183,210,231,88,30,78,87,235,137,79,131,13,129,211,158,197,128,49,243,209,114,86,165,112,169,97,45,122,52,249,132,174,111,38,156,54,227,249,22,196,135,113,95,44,31,197,45,75,128,91,38,241,81,220,162,0,31,48,120,210,174,88,87,158,91,73,126,42,162,255,135,67,190,103,23,250,113,192,213,68,249,238,230,64,46,240,189,37,106,208,124,59,2,163,201,1,90,190,194,72,190,42,73,101,169,145,90,157,212,249,171,221,159,218,16,39,159,234,13,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 1;
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

			private string _aggregationColumnName;
			public override string AggregationColumnName {
				get {
					return _aggregationColumnName ?? (_aggregationColumnName = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,1,0,242,67,189,42,2,0,0,0 })));
				}
				set {
					_aggregationColumnName = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,177,50,176,50,208,241,79,202,74,77,46,201,44,75,181,50,180,50,4,0,6,191,96,252,20,0,0,0 })));
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
								new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5"));
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

		public ContractVisaBaseSubprocess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContractVisaBaseSubprocess";
			SchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53");
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
				return new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ContractVisaBaseSubprocess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ContractVisaBaseSubprocess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid Contract {
			get;
			set;
		}

		public virtual Guid VisaOwner {
			get;
			set;
		}

		public virtual string VisaObjective {
			get;
			set;
		}

		public virtual string VisaResult {
			get;
			set;
		}

		public virtual bool IsAllowedToDelegate {
			get;
			set;
		}

		public virtual bool IsPreviousVisaCounts {
			get;
			set;
		}

		private ProcessBPMonline _bPMonline;
		public ProcessBPMonline BPMonline {
			get {
				return _bPMonline ?? ((_bPMonline) = new ProcessBPMonline(UserConnection, this));
			}
		}

		private ProcessFlowElement _startProcess;
		public ProcessFlowElement StartProcess {
			get {
				return _startProcess ?? (_startProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartProcess",
					SchemaElementUId = new Guid("ec42dc50-18dd-4744-816b-b2811303d2e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _visaRejectedEndProcess;
		public ProcessTerminateEvent VisaRejectedEndProcess {
			get {
				return _visaRejectedEndProcess ?? (_visaRejectedEndProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "VisaRejectedEndProcess",
					SchemaElementUId = new Guid("de31436f-6b97-4b75-a6e9-12218945fb31"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private CancelPreviousVisasFlowElement _cancelPreviousVisas;
		public CancelPreviousVisasFlowElement CancelPreviousVisas {
			get {
				return _cancelPreviousVisas ?? (_cancelPreviousVisas = new CancelPreviousVisasFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddVisaFlowElement _addVisa;
		public AddVisaFlowElement AddVisa {
			get {
				return _addVisa ?? (_addVisa = new AddVisaFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveEventBasedGateway _visaEventGateway;
		public ProcessExclusiveEventBasedGateway VisaEventGateway {
			get {
				return _visaEventGateway ?? (_visaEventGateway = new ProcessExclusiveEventBasedGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventBasedGateway",
					Name = "VisaEventGateway",
					SchemaElementUId = new Guid("6d317fc3-3ec1-4167-8100-d452dfeebaa2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Events = new Collection<string> { "VisaRejectedEvent", "VisaApprovedEvent", "VisaCanceledEvent", },
				});
			}
		}

		private VisaApprovedEventFlowElement _visaApprovedEvent;
		public VisaApprovedEventFlowElement VisaApprovedEvent {
			get {
				return _visaApprovedEvent ?? ((_visaApprovedEvent) = new VisaApprovedEventFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private VisaRejectedEventFlowElement _visaRejectedEvent;
		public VisaRejectedEventFlowElement VisaRejectedEvent {
			get {
				return _visaRejectedEvent ?? ((_visaRejectedEvent) = new VisaRejectedEventFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _visaApprovedEndProcess;
		public ProcessTerminateEvent VisaApprovedEndProcess {
			get {
				return _visaApprovedEndProcess ?? (_visaApprovedEndProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "VisaApprovedEndProcess",
					SchemaElementUId = new Guid("e699229d-457b-40cc-94e1-d536113a8b65"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _visaCanceledEndProcess;
		public ProcessTerminateEvent VisaCanceledEndProcess {
			get {
				return _visaCanceledEndProcess ?? (_visaCanceledEndProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "VisaCanceledEndProcess",
					SchemaElementUId = new Guid("f7ed8781-388b-41bb-913f-acec5ab5fa49"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private VisaCanceledEventFlowElement _visaCanceledEvent;
		public VisaCanceledEventFlowElement VisaCanceledEvent {
			get {
				return _visaCanceledEvent ?? ((_visaCanceledEvent) = new VisaCanceledEventFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private FindPositiveVisaFlowElement _findPositiveVisa;
		public FindPositiveVisaFlowElement FindPositiveVisa {
			get {
				return _findPositiveVisa ?? (_findPositiveVisa = new FindPositiveVisaFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _alreadyExistsVisaEndProcess;
		public ProcessTerminateEvent AlreadyExistsVisaEndProcess {
			get {
				return _alreadyExistsVisaEndProcess ?? (_alreadyExistsVisaEndProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "AlreadyExistsVisaEndProcess",
					SchemaElementUId = new Guid("10c69615-38e8-4a65-a9ab-7f0bfc22a18d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _errorEndProcess;
		public ProcessTerminateEvent ErrorEndProcess {
			get {
				return _errorEndProcess ?? (_errorEndProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "ErrorEndProcess",
					SchemaElementUId = new Guid("3e0a1d3e-7215-4cac-807f-02a021ddd2a3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _inputParametersGateway;
		public ProcessExclusiveGateway InputParametersGateway {
			get {
				return _inputParametersGateway ?? (_inputParametersGateway = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "InputParametersGateway",
					SchemaElementUId = new Guid("113c262b-8fe0-4413-8ba5-8315e16ea3f2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.InputParametersGateway.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
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
					SchemaElementUId = new Guid("77e77a39-537a-4a84-a052-aec8ab139324"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask2;
		public ProcessScriptTask FormulaTask2 {
			get {
				return _formulaTask2 ?? (_formulaTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask2",
					SchemaElementUId = new Guid("df06cffd-2788-47f3-aa36-e9630c969070"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask2Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask3;
		public ProcessScriptTask FormulaTask3 {
			get {
				return _formulaTask3 ?? (_formulaTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask3",
					SchemaElementUId = new Guid("0984b4ad-b023-4a3d-a496-1586cf9586d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask3Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask4;
		public ProcessScriptTask FormulaTask4 {
			get {
				return _formulaTask4 ?? (_formulaTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask4",
					SchemaElementUId = new Guid("51f42a41-e4fc-4878-a6cd-34cd87dc1969"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask4Execute,
				});
			}
		}

		private ProcessScriptTask _formulaTask5;
		public ProcessScriptTask FormulaTask5 {
			get {
				return _formulaTask5 ?? (_formulaTask5 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask5",
					SchemaElementUId = new Guid("8dad276d-a200-40aa-92a0-bf4cb821d2fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask5Execute,
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
					SchemaElementUId = new Guid("19e5e6ad-7695-4006-8c97-6f41ed28c7c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
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
					SchemaElementUId = new Guid("7623fa5a-d0ea-4b67-a2d2-e48bf8f59eaf"),
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
					SchemaElementUId = new Guid("2baf54f3-f62d-4407-a7f7-8673978956af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow3;
		public ProcessConditionalFlow ConditionalFlow3 {
			get {
				return _conditionalFlow3 ?? (_conditionalFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow3",
					SchemaElementUId = new Guid("4eed58cf-4e0d-47f2-9ad9-b5341d3c41e3"),
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
			FlowElements[StartProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { StartProcess };
			FlowElements[VisaRejectedEndProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { VisaRejectedEndProcess };
			FlowElements[CancelPreviousVisas.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelPreviousVisas };
			FlowElements[AddVisa.SchemaElementUId] = new Collection<ProcessFlowElement> { AddVisa };
			FlowElements[VisaEventGateway.SchemaElementUId] = new Collection<ProcessFlowElement> { VisaEventGateway };
			FlowElements[VisaApprovedEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { VisaApprovedEvent };
			FlowElements[VisaRejectedEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { VisaRejectedEvent };
			FlowElements[VisaApprovedEndProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { VisaApprovedEndProcess };
			FlowElements[VisaCanceledEndProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { VisaCanceledEndProcess };
			FlowElements[VisaCanceledEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { VisaCanceledEvent };
			FlowElements[FindPositiveVisa.SchemaElementUId] = new Collection<ProcessFlowElement> { FindPositiveVisa };
			FlowElements[AlreadyExistsVisaEndProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AlreadyExistsVisaEndProcess };
			FlowElements[ErrorEndProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ErrorEndProcess };
			FlowElements[InputParametersGateway.SchemaElementUId] = new Collection<ProcessFlowElement> { InputParametersGateway };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[FormulaTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask2 };
			FlowElements[FormulaTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask3 };
			FlowElements[FormulaTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask4 };
			FlowElements[FormulaTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask5 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InputParametersGateway", e.Context.SenderName));
						break;
					case "VisaRejectedEndProcess":
						CompleteProcess();
						break;
					case "CancelPreviousVisas":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddVisa", e.Context.SenderName));
						break;
					case "AddVisa":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("VisaEventGateway", e.Context.SenderName));
						break;
					case "VisaEventGateway":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("VisaRejectedEvent", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("VisaApprovedEvent", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("VisaCanceledEvent", e.Context.SenderName));
						break;
					case "VisaApprovedEvent":
						VisaEventGateway.CancelNonexecutedEvents("VisaApprovedEvent");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask2", e.Context.SenderName));
						break;
					case "VisaRejectedEvent":
						VisaEventGateway.CancelNonexecutedEvents("VisaRejectedEvent");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask4", e.Context.SenderName));
						break;
					case "VisaApprovedEndProcess":
						CompleteProcess();
						break;
					case "VisaCanceledEndProcess":
						CompleteProcess();
						break;
					case "VisaCanceledEvent":
						VisaEventGateway.CancelNonexecutedEvents("VisaCanceledEvent");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask3", e.Context.SenderName));
						break;
					case "FindPositiveVisa":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask5", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CancelPreviousVisas", e.Context.SenderName));
						break;
					case "AlreadyExistsVisaEndProcess":
						CompleteProcess();
						break;
					case "ErrorEndProcess":
						CompleteProcess();
						break;
					case "InputParametersGateway":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ErrorEndProcess", e.Context.SenderName));
						break;
					case "FormulaTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("VisaApprovedEndProcess", e.Context.SenderName));
						break;
					case "FormulaTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("VisaCanceledEndProcess", e.Context.SenderName));
						break;
					case "FormulaTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("VisaRejectedEndProcess", e.Context.SenderName));
						break;
					case "FormulaTask5":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AlreadyExistsVisaEndProcess", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FindPositiveVisa", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CancelPreviousVisas", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((FindPositiveVisa.ResultCount)>0);
			Log.InfoFormat(ConditionalExpressionLogMessage, "FindPositiveVisa", "ConditionalFlow1", "(FindPositiveVisa.ResultCount)>0", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((VisaOwner) == null || (Contract) == null);
			Log.InfoFormat(ConditionalExpressionLogMessage, "InputParametersGateway", "ConditionalFlow2", "(VisaOwner) == null || (Contract) == null", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((IsPreviousVisaCounts));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow3", "(IsPreviousVisaCounts)", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("Contract")) {
				writer.WriteValue("Contract", Contract, Guid.Empty);
			}
			if (!HasMapping("VisaOwner")) {
				writer.WriteValue("VisaOwner", VisaOwner, Guid.Empty);
			}
			if (!HasMapping("VisaObjective")) {
				writer.WriteValue("VisaObjective", VisaObjective, null);
			}
			if (!HasMapping("VisaResult")) {
				writer.WriteValue("VisaResult", VisaResult, null);
			}
			if (!HasMapping("IsAllowedToDelegate")) {
				writer.WriteValue("IsAllowedToDelegate", IsAllowedToDelegate, false);
			}
			if (!HasMapping("IsPreviousVisaCounts")) {
				writer.WriteValue("IsPreviousVisaCounts", IsPreviousVisaCounts, false);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartProcess", string.Empty));
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
			MetaPathParameterValues.Add("3a0d5732-da62-4c3b-a064-34320b6b3b70", () => Contract);
			MetaPathParameterValues.Add("c77907f0-2c9c-4bf7-8e77-d9e1cf50c135", () => VisaOwner);
			MetaPathParameterValues.Add("50d952fa-4e0b-414d-a1d6-444068fea4a1", () => VisaObjective);
			MetaPathParameterValues.Add("d2fd2fb7-ec08-4092-840e-40479398aece", () => VisaResult);
			MetaPathParameterValues.Add("3cafec33-e6b4-4fdf-b420-5fa70f8373c2", () => IsAllowedToDelegate);
			MetaPathParameterValues.Add("2b0415c8-fe33-430e-b6b0-0d6cee817372", () => IsPreviousVisaCounts);
			MetaPathParameterValues.Add("6c9b198f-bc19-4b69-ab86-d1dd9334339a", () => CancelPreviousVisas.EntitySchemaUId);
			MetaPathParameterValues.Add("49cbb5c4-bd70-43aa-8f31-4879e73d2376", () => CancelPreviousVisas.IsMatchConditions);
			MetaPathParameterValues.Add("d6d65720-6f5e-4f79-b9bc-19d68d9d465f", () => CancelPreviousVisas.DataSourceFilters);
			MetaPathParameterValues.Add("11edda32-f2fb-41b4-8837-0586bfabade5", () => CancelPreviousVisas.RecordColumnValues);
			MetaPathParameterValues.Add("726b18b2-8ee8-4fdb-8351-40addd8d68a2", () => CancelPreviousVisas.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("69a4680b-dced-4f91-9736-b89098e9b12c", () => AddVisa.EntitySchemaId);
			MetaPathParameterValues.Add("ce9ba715-9c2b-4b46-b3cd-a342eea5cf22", () => AddVisa.DataSourceFilters);
			MetaPathParameterValues.Add("fbf6a978-d0cf-473f-8ce4-5a20e548bb14", () => AddVisa.RecordAddMode);
			MetaPathParameterValues.Add("3691ae8b-153d-41dc-8223-2f176da23196", () => AddVisa.FilterEntitySchemaId);
			MetaPathParameterValues.Add("0a9c1fff-05ca-424d-919c-e1edf51210b3", () => AddVisa.RecordDefValues);
			MetaPathParameterValues.Add("58cb0143-4eb3-4db4-b3d9-85dbab73eef1", () => AddVisa.RecordId);
			MetaPathParameterValues.Add("be5e09cd-98c3-4140-8020-40aaffa76af3", () => AddVisa.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("c031b7d4-47c5-4757-b402-f10b423e1766", () => VisaApprovedEvent.RecordId);
			MetaPathParameterValues.Add("a3b7e6ec-ad76-4a63-9b48-ee16803ca206", () => VisaRejectedEvent.RecordId);
			MetaPathParameterValues.Add("9cba3ba9-8b2e-4d4b-a3a5-ba1a989ed52a", () => VisaCanceledEvent.RecordId);
			MetaPathParameterValues.Add("2cb83f28-00c3-4498-b39b-2f4679606074", () => FindPositiveVisa.DataSourceFilters);
			MetaPathParameterValues.Add("9a26576c-c7c3-446c-84c6-01bfb60e881c", () => FindPositiveVisa.ResultType);
			MetaPathParameterValues.Add("6c8ba82f-8a97-45f4-84a5-d3fa4a515b71", () => FindPositiveVisa.ReadSomeTopRecords);
			MetaPathParameterValues.Add("71734acf-2f73-40f2-8700-2c88d70553ce", () => FindPositiveVisa.NumberOfRecords);
			MetaPathParameterValues.Add("e31e30a5-7698-42ba-bee5-b12248b7f70c", () => FindPositiveVisa.FunctionType);
			MetaPathParameterValues.Add("deaa2aa9-71f7-423c-950f-88351e8c8775", () => FindPositiveVisa.AggregationColumnName);
			MetaPathParameterValues.Add("bbaada9f-c766-4ba8-b5d1-b74d05465f22", () => FindPositiveVisa.OrderInfo);
			MetaPathParameterValues.Add("468b242d-1dd5-4213-86e5-2cdc5fba51e2", () => FindPositiveVisa.ResultEntity);
			MetaPathParameterValues.Add("d6348dc3-4710-49a2-8cd5-eafb895e4fa5", () => FindPositiveVisa.ResultCount);
			MetaPathParameterValues.Add("0ed51c81-29b7-44dc-8000-5478283dbe98", () => FindPositiveVisa.ResultIntegerFunction);
			MetaPathParameterValues.Add("38909994-7218-4923-acc1-cb94b885239e", () => FindPositiveVisa.ResultFloatFunction);
			MetaPathParameterValues.Add("19a6723d-07af-4e13-b781-faa4906b1b21", () => FindPositiveVisa.ResultDateTimeFunction);
			MetaPathParameterValues.Add("195b1cc1-73e4-4d81-b1bc-fba63109558b", () => FindPositiveVisa.ResultRowsCount);
			MetaPathParameterValues.Add("2cf29bbb-a6c1-49f3-b333-58f19e6a7f0f", () => FindPositiveVisa.CanReadUncommitedData);
			MetaPathParameterValues.Add("b9d95ef0-203a-45b1-b583-ce4f734719f6", () => FindPositiveVisa.ResultEntityCollection);
			MetaPathParameterValues.Add("eac06a30-8133-464e-b39f-0f9124e46853", () => FindPositiveVisa.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("6fabb303-28c8-4090-9fa2-d74dd5df6abd", () => FindPositiveVisa.IgnoreDisplayValues);
			MetaPathParameterValues.Add("507b1628-1801-4371-a338-2979564dff30", () => FindPositiveVisa.ResultCompositeObjectList);
			MetaPathParameterValues.Add("fab39ad9-950d-450d-bd0b-c3e83cdcb19b", () => FindPositiveVisa.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "Contract":
					if (!hasValueToRead) break;
					Contract = reader.GetValue<System.Guid>();
				break;
				case "VisaOwner":
					if (!hasValueToRead) break;
					VisaOwner = reader.GetValue<System.Guid>();
				break;
				case "VisaObjective":
					if (!hasValueToRead) break;
					VisaObjective = reader.GetValue<System.String>();
				break;
				case "VisaResult":
					if (!hasValueToRead) break;
					VisaResult = reader.GetValue<System.String>();
				break;
				case "IsAllowedToDelegate":
					if (!hasValueToRead) break;
					IsAllowedToDelegate = reader.GetValue<System.Boolean>();
				break;
				case "IsPreviousVisaCounts":
					if (!hasValueToRead) break;
					IsPreviousVisaCounts = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localVisaResult = "Error";
			VisaResult = (System.String)localVisaResult;
			return true;
		}

		public virtual bool FormulaTask2Execute(ProcessExecutingContext context) {
			var localVisaResult = "Approved";
			VisaResult = (System.String)localVisaResult;
			return true;
		}

		public virtual bool FormulaTask3Execute(ProcessExecutingContext context) {
			var localVisaResult = "Canceled";
			VisaResult = (System.String)localVisaResult;
			return true;
		}

		public virtual bool FormulaTask4Execute(ProcessExecutingContext context) {
			var localVisaResult = "Rejected";
			VisaResult = (System.String)localVisaResult;
			return true;
		}

		public virtual bool FormulaTask5Execute(ProcessExecutingContext context) {
			var localVisaResult = "Approved";
			VisaResult = (System.String)localVisaResult;
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
			var cloneItem = (ContractVisaBaseSubprocess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


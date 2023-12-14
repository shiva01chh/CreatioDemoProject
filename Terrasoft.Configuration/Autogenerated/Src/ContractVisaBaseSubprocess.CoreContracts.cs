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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,75,111,194,48,12,254,43,83,196,177,65,77,27,40,112,93,55,9,9,38,52,24,151,117,7,55,113,160,82,31,40,45,211,24,234,127,95,8,69,45,211,56,140,28,28,37,246,247,136,227,35,233,85,135,29,146,9,89,161,214,80,22,170,234,63,22,26,251,11,93,8,44,203,254,172,16,144,38,223,16,167,184,0,13,25,86,168,215,144,238,177,156,37,101,229,60,92,195,136,67,122,159,54,75,38,239,71,50,173,48,123,155,74,195,206,71,194,243,57,74,26,160,226,148,15,61,70,1,135,146,202,24,124,240,93,224,40,152,1,139,34,221,103,249,28,43,88,64,181,37,147,35,177,108,134,64,4,210,115,135,0,148,187,76,152,48,30,208,24,184,79,131,65,32,70,138,141,25,199,49,169,29,82,138,45,102,96,69,91,48,122,40,5,40,151,242,24,13,152,141,20,29,11,230,211,152,161,27,96,224,113,46,6,39,112,83,223,2,87,218,108,38,33,147,114,151,194,97,125,43,191,187,106,77,183,226,24,157,59,28,145,73,116,171,199,205,190,180,214,175,187,252,187,193,17,113,34,178,44,246,90,156,24,217,233,112,121,176,85,112,155,69,255,8,151,117,230,176,176,57,228,176,65,253,98,20,45,220,166,66,168,192,138,175,140,239,127,19,191,162,66,141,185,192,59,141,89,229,214,204,101,22,204,77,190,79,83,43,80,218,247,159,134,171,49,222,100,194,206,47,117,24,10,153,168,4,229,52,191,211,81,136,202,82,62,23,250,233,203,12,125,146,111,154,31,235,72,183,53,161,200,154,251,154,212,245,71,253,3,158,53,249,44,99,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b4ef173a-cd86-4fed-8781-695413ee6e53")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("637a00a7-ca38-4651-b154-4eb2f2519f88"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,150,77,111,27,55,16,134,255,138,177,201,81,99,240,99,184,36,117,43,162,22,48,144,180,70,147,230,98,249,48,36,135,142,10,73,43,172,214,105,83,67,255,61,163,181,92,219,73,107,7,57,25,73,246,176,218,229,114,230,29,113,230,25,242,170,121,62,124,216,112,51,109,222,112,223,211,182,171,195,241,139,174,231,227,211,190,203,188,221,30,191,236,50,45,23,255,80,90,242,41,245,180,226,129,251,183,180,188,228,237,203,197,118,152,28,221,55,107,38,205,243,247,227,215,102,122,118,213,156,12,188,250,227,164,136,119,213,82,112,190,102,112,53,4,192,138,12,73,105,5,174,112,116,137,162,50,26,197,56,119,203,203,213,250,21,15,116,74,195,187,102,122,213,140,222,196,65,54,193,228,96,16,60,145,6,196,132,144,66,85,80,50,169,202,182,132,132,169,217,77,154,109,126,199,43,26,69,111,141,217,176,204,147,217,152,56,3,234,80,33,102,109,33,105,86,158,189,65,204,110,111,124,152,127,107,120,246,236,236,100,251,219,95,107,238,95,143,126,167,149,150,91,62,63,150,209,79,6,254,93,156,233,149,83,37,58,83,9,144,85,18,53,44,64,186,180,18,52,170,54,84,38,36,189,59,127,118,190,87,44,139,237,102,73,31,222,126,46,252,211,102,211,119,242,122,212,165,63,57,15,139,247,124,109,177,185,151,133,187,54,87,243,235,100,206,155,233,252,255,210,121,248,189,14,254,126,66,63,205,229,188,153,204,155,215,221,101,159,247,30,237,254,229,102,109,71,5,117,184,224,63,110,55,215,181,143,209,236,21,173,233,130,251,95,69,113,52,31,63,205,104,160,81,252,141,196,125,227,184,148,100,73,51,131,228,70,106,165,180,6,146,167,8,69,113,171,67,82,170,166,50,90,255,206,149,123,94,103,254,202,192,70,229,219,96,110,202,78,70,214,151,203,229,40,176,29,255,255,190,142,15,129,31,190,204,238,228,237,142,135,174,44,234,130,203,201,250,43,35,154,113,29,93,254,210,245,63,255,45,124,45,214,23,135,140,221,145,190,157,51,203,171,195,248,174,217,237,38,119,129,107,201,155,194,38,3,163,67,192,182,74,201,51,85,176,94,91,103,77,200,41,170,7,129,171,214,146,119,172,192,115,17,7,73,181,64,40,196,166,200,209,26,219,162,75,250,137,0,151,189,143,202,139,154,201,81,212,82,245,16,216,123,40,145,117,174,78,137,178,251,82,224,184,255,94,48,75,38,58,229,117,149,4,11,92,200,130,89,40,154,32,234,152,170,245,214,212,106,30,194,44,72,23,199,20,165,205,165,108,1,115,170,210,230,40,64,230,172,76,214,114,139,249,155,199,76,19,9,72,104,133,43,229,164,87,201,230,22,227,30,154,86,11,37,169,148,86,211,195,152,177,42,149,178,44,91,27,25,208,163,236,107,202,202,190,214,198,24,162,117,89,188,63,17,204,44,169,226,164,46,160,144,212,10,102,155,128,84,139,96,209,26,149,218,100,147,87,143,99,246,162,91,15,61,229,225,7,102,95,136,89,244,137,45,35,40,107,5,179,214,23,8,129,175,183,68,116,89,149,160,191,253,221,12,131,45,202,86,11,69,179,52,28,135,17,66,45,10,106,13,197,85,69,81,63,130,153,47,232,172,80,2,24,36,82,244,81,32,9,24,160,245,94,23,194,104,148,111,159,10,102,34,197,89,114,205,173,28,114,177,150,10,9,141,28,149,43,121,85,131,148,76,54,143,99,54,227,37,95,208,176,232,214,71,27,238,87,139,97,224,242,189,32,23,165,27,185,84,3,168,90,247,249,66,13,65,142,8,96,100,25,229,129,170,156,22,126,28,32,63,71,238,124,247,17,58,43,182,252,15,14,0,0 })),
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
				UId = new Guid("cd520a71-e5b8-4395-a572-9a51c8e59c67"),
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
				UId = new Guid("1b2b41a1-1946-4602-b047-f3432cb6d4c1"),
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
				UId = new Guid("4c830ca8-92e8-40d3-84a0-5c4c9dced72f"),
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,75,111,194,48,12,254,43,83,196,177,65,77,27,40,112,93,55,9,9,38,52,24,151,117,7,55,113,160,82,31,40,45,211,24,234,127,95,8,69,45,211,56,140,28,28,37,246,247,136,227,35,233,85,135,29,146,9,89,161,214,80,22,170,234,63,22,26,251,11,93,8,44,203,254,172,16,144,38,223,16,167,184,0,13,25,86,168,215,144,238,177,156,37,101,229,60,92,195,136,67,122,159,54,75,38,239,71,50,173,48,123,155,74,195,206,71,194,243,57,74,26,160,226,148,15,61,70,1,135,146,202,24,124,240,93,224,40,152,1,139,34,221,103,249,28,43,88,64,181,37,147,35,177,108,134,64,4,210,115,135,0,148,187,76,152,48,30,208,24,184,79,131,65,32,70,138,141,25,199,49,169,29,82,138,45,102,96,69,91,48,122,40,5,40,151,242,24,13,152,141,20,29,11,230,211,152,161,27,96,224,113,46,6,39,112,83,223,2,87,218,108,38,33,147,114,151,194,97,125,43,191,187,106,77,183,226,24,157,59,28,145,73,116,171,199,205,190,180,214,175,187,252,187,193,17,113,34,178,44,246,90,156,24,217,233,112,121,176,85,112,155,69,255,8,151,117,230,176,176,57,228,176,65,253,98,20,45,220,166,66,168,192,138,175,140,239,127,19,191,162,66,141,185,192,59,141,89,229,214,204,101,22,204,77,190,79,83,43,80,218,247,159,134,171,49,222,100,194,206,47,117,24,10,153,168,4,229,52,191,211,81,136,202,82,62,23,250,233,203,12,125,146,111,154,31,235,72,183,53,161,200,154,251,154,212,245,71,253,3,158,53,249,44,99,3,0,0 };
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,150,77,111,27,55,16,134,255,138,177,201,81,99,240,99,184,36,117,43,162,22,48,144,180,70,147,230,98,249,48,36,135,142,10,73,43,172,214,105,83,67,255,61,163,181,92,219,73,107,7,57,25,73,246,176,218,229,114,230,29,113,230,25,242,170,121,62,124,216,112,51,109,222,112,223,211,182,171,195,241,139,174,231,227,211,190,203,188,221,30,191,236,50,45,23,255,80,90,242,41,245,180,226,129,251,183,180,188,228,237,203,197,118,152,28,221,55,107,38,205,243,247,227,215,102,122,118,213,156,12,188,250,227,164,136,119,213,82,112,190,102,112,53,4,192,138,12,73,105,5,174,112,116,137,162,50,26,197,56,119,203,203,213,250,21,15,116,74,195,187,102,122,213,140,222,196,65,54,193,228,96,16,60,145,6,196,132,144,66,85,80,50,169,202,182,132,132,169,217,77,154,109,126,199,43,26,69,111,141,217,176,204,147,217,152,56,3,234,80,33,102,109,33,105,86,158,189,65,204,110,111,124,152,127,107,120,246,236,236,100,251,219,95,107,238,95,143,126,167,149,150,91,62,63,150,209,79,6,254,93,156,233,149,83,37,58,83,9,144,85,18,53,44,64,186,180,18,52,170,54,84,38,36,189,59,127,118,190,87,44,139,237,102,73,31,222,126,46,252,211,102,211,119,242,122,212,165,63,57,15,139,247,124,109,177,185,151,133,187,54,87,243,235,100,206,155,233,252,255,210,121,248,189,14,254,126,66,63,205,229,188,153,204,155,215,221,101,159,247,30,237,254,229,102,109,71,5,117,184,224,63,110,55,215,181,143,209,236,21,173,233,130,251,95,69,113,52,31,63,205,104,160,81,252,141,196,125,227,184,148,100,73,51,131,228,70,106,165,180,6,146,167,8,69,113,171,67,82,170,166,50,90,255,206,149,123,94,103,254,202,192,70,229,219,96,110,202,78,70,214,151,203,229,40,176,29,255,255,190,142,15,129,31,190,204,238,228,237,142,135,174,44,234,130,203,201,250,43,35,154,113,29,93,254,210,245,63,255,45,124,45,214,23,135,140,221,145,190,157,51,203,171,195,248,174,217,237,38,119,129,107,201,155,194,38,3,163,67,192,182,74,201,51,85,176,94,91,103,77,200,41,170,7,129,171,214,146,119,172,192,115,17,7,73,181,64,40,196,166,200,209,26,219,162,75,250,137,0,151,189,143,202,139,154,201,81,212,82,245,16,216,123,40,145,117,174,78,137,178,251,82,224,184,255,94,48,75,38,58,229,117,149,4,11,92,200,130,89,40,154,32,234,152,170,245,214,212,106,30,194,44,72,23,199,20,165,205,165,108,1,115,170,210,230,40,64,230,172,76,214,114,139,249,155,199,76,19,9,72,104,133,43,229,164,87,201,230,22,227,30,154,86,11,37,169,148,86,211,195,152,177,42,149,178,44,91,27,25,208,163,236,107,202,202,190,214,198,24,162,117,89,188,63,17,204,44,169,226,164,46,160,144,212,10,102,155,128,84,139,96,209,26,149,218,100,147,87,143,99,246,162,91,15,61,229,225,7,102,95,136,89,244,137,45,35,40,107,5,179,214,23,8,129,175,183,68,116,89,149,160,191,253,221,12,131,45,202,86,11,69,179,52,28,135,17,66,45,10,106,13,197,85,69,81,63,130,153,47,232,172,80,2,24,36,82,244,81,32,9,24,160,245,94,23,194,104,148,111,159,10,102,34,197,89,114,205,173,28,114,177,150,10,9,141,28,149,43,121,85,131,148,76,54,143,99,54,227,37,95,208,176,232,214,71,27,238,87,139,97,224,242,189,32,23,165,27,185,84,3,168,90,247,249,66,13,65,142,8,96,100,25,229,129,170,156,22,126,28,32,63,71,238,124,247,17,58,43,182,252,15,14,0,0 };
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
			MetaPathParameterValues.Add("637a00a7-ca38-4651-b154-4eb2f2519f88", () => CancelPreviousVisas.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("69a4680b-dced-4f91-9736-b89098e9b12c", () => AddVisa.EntitySchemaId);
			MetaPathParameterValues.Add("ce9ba715-9c2b-4b46-b3cd-a342eea5cf22", () => AddVisa.DataSourceFilters);
			MetaPathParameterValues.Add("fbf6a978-d0cf-473f-8ce4-5a20e548bb14", () => AddVisa.RecordAddMode);
			MetaPathParameterValues.Add("3691ae8b-153d-41dc-8223-2f176da23196", () => AddVisa.FilterEntitySchemaId);
			MetaPathParameterValues.Add("0a9c1fff-05ca-424d-919c-e1edf51210b3", () => AddVisa.RecordDefValues);
			MetaPathParameterValues.Add("58cb0143-4eb3-4db4-b3d9-85dbab73eef1", () => AddVisa.RecordId);
			MetaPathParameterValues.Add("cd520a71-e5b8-4395-a572-9a51c8e59c67", () => AddVisa.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("1b2b41a1-1946-4602-b047-f3432cb6d4c1", () => FindPositiveVisa.ResultCompositeObjectList);
			MetaPathParameterValues.Add("4c830ca8-92e8-40d3-84a0-5c4c9dced72f", () => FindPositiveVisa.ConsiderTimeInFilter);
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


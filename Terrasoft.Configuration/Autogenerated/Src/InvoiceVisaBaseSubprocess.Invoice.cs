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

	#region Class: InvoiceVisaBaseSubprocessSchema

	/// <exclude/>
	public class InvoiceVisaBaseSubprocessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public InvoiceVisaBaseSubprocessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public InvoiceVisaBaseSubprocessSchema(InvoiceVisaBaseSubprocessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "InvoiceVisaBaseSubprocess";
			UId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c");
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
			RealUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c");
			Version = 0;
			PackageUId = new Guid("e7a2c20a-9591-484e-bf77-5953f2dc592e");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateInvoiceParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3a0d5732-da62-4c3b-a064-34320b6b3b70"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Name = @"Invoice",
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Name = @"IsPreviousVisaCounts",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateInvoiceParameter());
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
				Value = @"ec034d19-5185-497d-9066-29f2973037f1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,109,139,220,54,16,254,47,254,144,79,86,208,187,172,237,167,102,185,192,65,184,30,164,45,133,112,132,145,52,202,153,120,237,141,95,174,9,203,254,247,142,119,111,211,229,186,92,175,219,4,122,208,47,198,146,53,143,102,70,207,51,35,111,222,215,195,235,186,25,177,95,100,104,6,44,167,203,180,40,164,8,58,235,128,12,188,151,76,115,37,152,143,89,48,64,172,148,51,146,163,139,69,217,194,10,23,197,222,250,34,213,99,81,214,35,174,134,197,187,205,159,160,99,63,97,249,62,239,6,111,227,45,174,224,151,121,3,140,92,233,36,60,51,162,50,76,123,151,152,231,214,50,233,179,244,78,113,229,178,40,246,190,152,24,133,117,54,48,33,173,103,26,82,98,193,197,204,172,119,18,37,135,224,4,22,101,131,121,188,248,188,238,113,24,234,174,93,108,240,235,251,207,95,214,228,229,126,239,101,215,76,171,182,40,87,56,194,53,140,183,139,2,156,3,163,3,176,36,131,98,58,165,192,130,240,134,201,40,147,208,64,193,6,91,148,17,214,227,12,91,92,182,119,93,29,105,191,30,51,246,216,70,60,10,42,228,160,132,154,253,11,134,130,66,17,88,133,90,50,149,148,182,200,19,184,104,138,50,193,8,191,66,51,225,206,177,77,61,27,74,111,184,19,153,57,4,10,17,173,100,85,18,192,188,240,33,43,167,100,206,242,144,238,55,93,247,113,90,83,170,135,171,105,133,125,29,239,207,13,233,0,186,126,177,137,93,59,246,93,51,131,95,29,25,236,207,231,254,227,111,251,156,52,187,47,179,97,177,45,167,1,151,77,141,237,120,209,198,46,213,237,135,221,209,109,183,100,179,90,67,95,15,135,76,94,124,154,160,161,4,212,31,110,31,205,248,114,26,198,110,245,220,226,45,41,86,130,33,182,238,124,158,201,156,234,97,221,192,151,221,120,81,188,248,52,117,227,15,247,60,216,15,138,7,70,135,69,10,120,50,20,13,75,64,17,234,168,2,3,110,53,83,90,73,30,108,80,193,241,123,132,109,121,254,54,239,46,135,159,126,111,15,242,218,167,231,230,37,205,62,152,184,62,88,47,54,79,241,108,123,115,240,237,134,88,240,77,37,173,120,148,89,10,195,34,8,18,93,200,150,10,77,112,44,113,148,9,120,5,202,138,243,37,157,149,2,103,144,19,187,146,38,116,78,232,90,112,22,60,122,37,149,213,38,136,35,73,255,184,94,247,221,29,246,167,53,93,81,29,212,193,3,225,68,114,53,134,204,64,64,197,34,133,43,163,160,135,143,207,141,227,255,107,250,164,216,14,68,120,92,109,209,57,207,93,230,212,33,124,156,185,235,168,200,59,226,174,71,17,179,225,81,40,243,184,168,159,182,207,25,170,126,138,107,223,81,213,94,101,45,0,45,51,94,211,246,38,89,22,72,81,172,210,220,171,148,43,25,32,157,175,234,232,146,228,22,72,136,92,16,58,167,30,29,64,43,230,140,139,85,22,94,104,244,71,170,94,2,233,184,193,116,146,171,158,106,156,9,185,98,60,103,194,18,90,176,138,114,199,164,150,156,94,32,83,26,15,92,125,213,117,13,66,251,15,200,186,188,197,248,241,85,247,249,33,85,227,60,31,104,254,20,81,119,152,255,66,153,95,105,240,188,2,62,33,205,135,114,216,45,252,14,116,181,206,87,18,164,34,26,89,164,123,37,167,30,168,128,90,98,158,23,39,46,21,202,243,233,106,42,12,168,8,216,169,138,154,16,4,186,21,242,89,149,220,69,75,90,172,64,167,35,186,190,29,97,156,134,211,45,200,90,34,184,129,200,12,73,128,233,140,21,243,6,56,171,60,248,10,41,34,227,242,115,43,201,127,37,250,85,55,126,27,174,255,135,163,126,98,35,186,238,134,122,172,239,254,230,218,135,206,103,136,244,211,162,34,93,228,180,66,199,192,120,164,223,164,0,66,26,180,66,201,163,90,127,179,253,3,93,223,183,82,235,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,203,110,227,32,20,253,149,17,234,50,68,96,140,9,217,78,102,164,72,109,21,77,59,221,212,93,92,195,165,181,228,71,132,73,53,157,200,255,62,132,58,74,82,77,55,101,1,54,247,158,7,7,246,228,42,188,109,145,44,201,61,122,15,67,239,194,252,123,239,113,190,241,189,193,97,152,95,247,6,154,250,47,84,13,110,192,67,139,1,253,3,52,59,28,174,235,33,204,190,93,194,200,140,92,189,166,42,89,62,238,201,58,96,251,123,109,35,59,67,43,68,165,13,205,164,80,52,119,26,40,112,169,168,146,153,132,194,106,45,185,136,96,211,55,187,182,187,193,0,27,8,47,100,185,39,137,45,18,24,101,51,86,0,208,156,113,19,39,45,105,5,185,136,4,202,44,28,215,60,71,77,198,25,25,204,11,182,144,68,79,96,52,76,228,150,107,42,249,66,210,92,43,75,53,43,10,154,105,151,105,37,152,80,142,31,192,83,255,9,24,124,92,98,193,214,195,182,129,183,135,207,234,219,139,104,206,59,246,229,123,194,37,89,150,159,101,60,173,119,201,250,101,202,31,3,46,201,172,36,119,253,206,155,3,163,56,252,28,15,156,20,216,52,232,127,166,227,120,231,72,176,27,232,224,25,253,109,84,76,240,84,90,65,128,36,126,31,125,31,137,53,171,10,89,185,5,101,206,197,252,121,206,233,66,41,77,179,60,99,241,3,156,102,42,161,127,161,67,143,157,193,47,26,75,202,39,51,199,183,16,119,186,93,211,36,129,33,157,255,240,184,38,227,83,101,117,118,75,103,12,189,173,93,141,118,221,125,209,209,10,93,162,252,217,251,31,127,226,163,175,187,231,233,198,206,164,79,61,43,211,78,251,35,25,199,167,241,31,245,207,75,171,99,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("071820bb-c98b-4df2-9dfd-1e5cd9193237"),
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
				Value = @"ec034d19-5185-497d-9066-29f2973037f1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,150,77,111,27,55,16,134,255,138,177,201,81,99,240,99,184,36,117,43,170,22,48,144,180,70,147,230,98,251,48,36,135,142,10,73,43,172,214,110,83,67,255,61,163,181,92,203,73,235,24,61,25,73,246,176,90,113,57,31,124,135,207,44,111,154,151,195,135,53,55,211,230,45,247,61,109,186,58,28,255,216,245,124,124,218,119,153,55,155,227,87,93,166,197,252,111,74,11,62,165,158,150,60,112,255,142,22,87,188,121,53,223,12,147,163,135,102,205,164,121,121,61,190,109,166,103,55,205,201,192,203,223,79,138,120,103,226,24,83,155,192,112,81,128,154,2,196,144,11,68,111,216,98,171,75,140,40,198,185,91,92,45,87,175,121,160,83,26,222,55,211,155,102,244,38,14,200,123,114,152,8,138,73,22,176,148,4,73,71,7,38,155,162,145,172,119,169,109,182,147,102,147,223,243,146,198,160,247,198,156,149,197,162,35,56,29,28,96,244,18,88,181,45,152,88,77,244,86,89,95,245,206,120,63,255,222,240,236,197,217,201,230,215,63,87,220,191,25,253,78,43,45,54,124,113,44,163,159,12,252,35,206,244,198,146,42,206,91,3,133,90,3,152,109,2,82,45,130,69,107,148,104,96,147,87,219,139,23,23,187,136,101,190,89,47,232,195,187,207,3,159,172,174,187,121,230,219,105,235,7,210,31,78,188,57,191,173,224,121,51,61,255,175,26,238,127,111,51,126,88,197,79,11,120,222,76,206,155,55,221,85,159,119,30,237,238,207,157,160,99,4,181,191,224,95,110,119,215,173,143,209,236,53,173,232,146,251,95,36,226,104,62,190,154,209,64,99,240,183,146,247,157,227,100,162,83,94,87,240,76,17,144,69,185,80,52,65,212,49,85,43,106,214,106,70,235,223,184,114,207,171,204,15,19,75,53,89,109,75,129,148,156,148,152,117,130,192,104,192,22,217,94,172,10,249,236,70,251,49,242,125,50,119,123,77,70,86,87,139,197,24,96,51,174,127,183,121,247,137,239,223,204,14,138,117,224,161,43,243,58,231,114,178,250,159,82,205,184,142,46,127,238,250,159,254,18,168,230,171,203,125,197,14,66,223,207,153,229,229,126,124,219,108,183,147,67,202,156,72,136,10,43,40,147,18,160,85,12,193,85,37,144,132,192,45,198,90,41,61,74,89,181,150,188,99,37,85,40,8,152,84,11,132,90,65,138,28,173,177,45,186,164,159,9,101,217,251,168,252,184,184,152,37,213,234,165,224,222,67,137,172,115,117,42,107,235,190,76,217,15,235,117,223,93,115,255,29,179,167,97,22,176,34,166,72,34,120,150,54,156,83,5,218,53,243,44,197,55,89,203,45,230,175,30,179,214,96,210,133,11,160,217,41,161,156,232,135,161,236,128,147,6,239,218,104,218,250,40,102,217,4,65,210,32,120,34,13,34,40,66,10,178,149,75,38,85,217,150,144,48,61,19,204,156,42,209,153,42,203,100,37,45,69,99,145,130,151,86,146,70,213,134,202,132,164,159,138,25,45,142,186,244,7,231,97,126,253,205,124,215,228,160,98,73,51,131,242,28,228,220,34,192,37,47,232,21,197,173,14,73,169,154,202,99,192,61,57,177,175,25,56,162,202,85,250,61,196,218,10,47,228,164,107,161,246,208,86,95,156,124,176,74,204,143,159,30,125,65,103,49,49,96,144,76,209,71,43,192,97,128,214,123,93,8,163,81,254,217,156,30,179,44,54,91,11,220,74,91,192,90,42,36,52,10,92,37,175,106,144,30,157,205,151,129,155,241,130,47,105,152,119,171,163,53,247,203,249,48,112,249,86,144,139,114,200,118,169,6,80,181,230,93,203,210,16,118,155,199,136,140,242,64,85,206,13,223,145,251,28,185,139,237,71,20,131,202,228,14,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				UId = new Guid("218938bc-c581-43d3-a013-ab7675b1954c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeVisaRejectedEventParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a3b7e6ec-ad76-4a63-9b48-ee16803ca206"),
				ContainerUId = new Guid("b0ff5122-dde6-487d-a7e0-e7ba43e507a9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeVisaCanceledEventParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9cba3ba9-8b2e-4d4b-a3a5-ba1a989ed52a"),
				ContainerUId = new Guid("7c046ee4-d44b-49a9-9e4f-4606b8554bec"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,91,107,27,87,16,254,47,251,208,167,157,114,238,23,245,169,49,46,24,74,106,72,91,10,193,132,57,183,120,201,106,87,217,75,154,32,244,223,59,43,89,169,48,194,117,221,26,106,232,139,216,61,123,102,206,124,115,190,111,102,180,125,215,140,63,52,237,148,135,85,193,118,204,245,124,149,86,149,193,98,76,20,6,108,198,8,138,51,7,206,8,7,158,49,167,76,98,82,40,91,213,29,174,243,170,58,88,95,166,102,170,234,102,202,235,113,245,118,251,167,211,105,152,115,253,174,236,95,222,196,219,188,198,95,150,3,114,100,82,37,238,65,115,167,65,121,155,200,183,49,32,124,17,222,74,38,109,225,213,33,22,89,10,119,142,11,8,44,81,44,210,21,8,81,122,48,69,11,238,153,48,12,41,150,54,151,233,242,243,102,200,227,216,244,221,106,155,191,62,255,252,101,67,81,30,206,190,232,219,121,221,85,245,58,79,120,141,211,237,170,66,107,81,171,128,144,68,144,160,82,10,16,184,215,32,162,72,92,161,180,58,152,170,142,184,153,22,183,213,85,247,169,111,98,174,234,33,151,60,228,46,230,19,80,161,4,201,101,74,16,130,38,80,153,7,112,89,9,144,73,42,147,89,66,27,117,85,39,156,240,87,108,231,188,15,108,219,44,134,194,107,102,121,89,210,237,201,208,8,112,137,35,120,238,67,145,86,138,82,196,49,221,63,246,253,135,121,67,169,30,95,207,235,60,52,241,238,222,50,93,64,63,172,182,177,239,166,161,111,23,231,175,79,12,14,247,115,247,241,183,67,78,218,253,151,197,176,218,213,243,152,47,218,38,119,211,101,23,251,212,116,239,247,87,183,219,145,205,122,131,67,51,30,51,121,249,113,198,150,18,208,188,191,125,48,227,23,243,56,245,235,151,134,183,38,172,228,134,216,186,143,121,33,115,106,198,77,139,95,246,239,171,234,155,143,115,63,125,119,199,131,195,75,117,207,232,184,73,34,75,154,208,64,66,66,168,162,12,128,204,40,144,74,10,22,76,144,193,178,59,15,187,250,233,199,188,189,26,127,250,189,59,202,235,144,158,155,111,105,245,222,194,245,209,122,181,125,76,100,187,155,99,108,55,196,130,127,85,210,86,123,238,60,74,176,42,250,101,171,2,239,139,3,44,65,5,210,33,143,5,159,46,233,34,37,90,157,25,177,43,41,80,129,25,64,42,97,16,124,246,82,72,163,116,224,39,146,254,126,179,25,250,79,121,56,175,105,167,138,82,193,35,249,137,84,31,98,40,128,28,29,68,130,43,34,167,31,31,95,26,199,255,215,244,89,177,29,137,240,176,218,162,181,158,217,194,168,67,120,106,71,161,88,42,242,214,66,242,153,104,171,89,228,82,63,44,234,199,157,243,4,85,63,38,180,103,84,181,79,41,41,238,36,36,206,22,85,83,15,244,193,104,144,82,38,199,180,66,103,213,211,85,29,109,18,204,32,9,145,113,2,199,168,71,7,84,84,66,180,141,174,112,207,85,246,39,170,190,64,210,113,155,211,89,174,122,170,113,58,80,193,97,165,44,227,141,226,224,40,119,32,148,96,244,128,133,210,120,228,234,171,190,111,51,118,127,131,172,23,183,57,126,120,213,127,190,79,213,184,172,7,90,63,71,212,189,207,127,160,204,175,52,120,89,128,207,72,243,190,28,246,27,159,129,174,198,105,69,124,114,192,169,33,128,82,66,128,79,65,64,137,194,202,164,172,244,204,61,157,174,218,229,144,165,201,96,165,163,38,132,129,166,66,182,168,146,217,72,147,43,115,168,210,9,93,223,76,56,205,227,249,22,68,147,184,43,154,230,112,77,18,0,85,50,205,225,26,25,80,7,245,46,19,34,109,203,75,43,201,207,69,244,255,48,228,71,118,161,235,126,108,166,230,211,95,204,124,217,250,130,145,254,177,200,72,83,156,146,217,2,106,159,129,139,128,92,232,108,184,20,39,133,254,102,247,7,163,173,107,214,232,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,79,202,74,77,46,201,44,75,181,50,180,50,212,241,76,177,50,176,50,0,0,200,6,180,116,20,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1"),
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				ReferenceSchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1"),
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
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
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e7518960-69b7-4cb5-92f0-4092f7a8b622"),
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
				UId = new Guid("8cbb61ab-037c-4b9c-993a-744caf8c6168"),
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
				UId = new Guid("921acd6f-f51d-4633-bcad-6e4a83d31fab"),
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
			ProcessSchemaLaneSet schemaInvoiceVisa = CreateInvoiceVisaLaneSet();
			LaneSets.Add(schemaInvoiceVisa);
			ProcessSchemaLane schemaBPMonline = CreateBPMonlineLane();
			schemaInvoiceVisa.Lanes.Add(schemaBPMonline);
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(662, 160),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(769, 120),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(649, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(767, 302),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(210, 289),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(308, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(151, 225),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(215, 147),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(160, 147),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(196, 324),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(769, 120),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(767, 302),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(316, 312),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(315, 216),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				CurveCenterPosition = new Point(393, 148),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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

		protected virtual ProcessSchemaLaneSet CreateInvoiceVisaLaneSet() {
			ProcessSchemaLaneSet schemaInvoiceVisa = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ece8cb92-e6e7-4b4d-8cec-dd9f3a5c15b4"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Name = @"InvoiceVisa",
				Position = new Point(5, 5),
				Size = new Size(1008, 487),
				UseBackgroundMode = false
			};
			return schemaInvoiceVisa;
		}

		protected virtual ProcessSchemaLane CreateBPMonlineLane() {
			ProcessSchemaLane schemaBPMonline = new ProcessSchemaLane(this) {
				UId = new Guid("561bb91d-719b-4b9d-a8fe-65b13a8e9e3f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ece8cb92-e6e7-4b4d-8cec-dd9f3a5c15b4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("ccbd91c8-b356-4a0d-a8c1-5f4c3839a373"),
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				Name = @"BPMonline",
				Position = new Point(29, 0),
				Size = new Size(979, 487),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				Instantiate = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0ddbda75-9cac-4e42-b94c-5cf1edb45846"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
				CreatedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"),
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
			return new InvoiceVisaBaseSubprocess(userConnection);
		}

		public override object Clone() {
			return new InvoiceVisaBaseSubprocessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceVisaBaseSubprocess

	/// <exclude/>
	public class InvoiceVisaBaseSubprocess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessBPMonline

		/// <exclude/>
		public class ProcessBPMonline : ProcessLane
		{

			public ProcessBPMonline(UserConnection userConnection, InvoiceVisaBaseSubprocess process)
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

			public CancelPreviousVisasFlowElement(UserConnection userConnection, InvoiceVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "CancelPreviousVisas";
				IsLogging = true;
				SchemaElementUId = new Guid("535b4886-240c-4ff4-917d-84b951475499");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_IsCanceled = () => (bool)(true);
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

			private Guid _entitySchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,109,139,220,54,16,254,47,254,144,79,86,208,187,172,237,167,102,185,192,65,184,30,164,45,133,112,132,145,52,202,153,120,237,141,95,174,9,203,254,247,142,119,111,211,229,186,92,175,219,4,122,208,47,198,146,53,143,102,70,207,51,35,111,222,215,195,235,186,25,177,95,100,104,6,44,167,203,180,40,164,8,58,235,128,12,188,151,76,115,37,152,143,89,48,64,172,148,51,146,163,139,69,217,194,10,23,197,222,250,34,213,99,81,214,35,174,134,197,187,205,159,160,99,63,97,249,62,239,6,111,227,45,174,224,151,121,3,140,92,233,36,60,51,162,50,76,123,151,152,231,214,50,233,179,244,78,113,229,178,40,246,190,152,24,133,117,54,48,33,173,103,26,82,98,193,197,204,172,119,18,37,135,224,4,22,101,131,121,188,248,188,238,113,24,234,174,93,108,240,235,251,207,95,214,228,229,126,239,101,215,76,171,182,40,87,56,194,53,140,183,139,2,156,3,163,3,176,36,131,98,58,165,192,130,240,134,201,40,147,208,64,193,6,91,148,17,214,227,12,91,92,182,119,93,29,105,191,30,51,246,216,70,60,10,42,228,160,132,154,253,11,134,130,66,17,88,133,90,50,149,148,182,200,19,184,104,138,50,193,8,191,66,51,225,206,177,77,61,27,74,111,184,19,153,57,4,10,17,173,100,85,18,192,188,240,33,43,167,100,206,242,144,238,55,93,247,113,90,83,170,135,171,105,133,125,29,239,207,13,233,0,186,126,177,137,93,59,246,93,51,131,95,29,25,236,207,231,254,227,111,251,156,52,187,47,179,97,177,45,167,1,151,77,141,237,120,209,198,46,213,237,135,221,209,109,183,100,179,90,67,95,15,135,76,94,124,154,160,161,4,212,31,110,31,205,248,114,26,198,110,245,220,226,45,41,86,130,33,182,238,124,158,201,156,234,97,221,192,151,221,120,81,188,248,52,117,227,15,247,60,216,15,138,7,70,135,69,10,120,50,20,13,75,64,17,234,168,2,3,110,53,83,90,73,30,108,80,193,241,123,132,109,121,254,54,239,46,135,159,126,111,15,242,218,167,231,230,37,205,62,152,184,62,88,47,54,79,241,108,123,115,240,237,134,88,240,77,37,173,120,148,89,10,195,34,8,18,93,200,150,10,77,112,44,113,148,9,120,5,202,138,243,37,157,149,2,103,144,19,187,146,38,116,78,232,90,112,22,60,122,37,149,213,38,136,35,73,255,184,94,247,221,29,246,167,53,93,81,29,212,193,3,225,68,114,53,134,204,64,64,197,34,133,43,163,160,135,143,207,141,227,255,107,250,164,216,14,68,120,92,109,209,57,207,93,230,212,33,124,156,185,235,168,200,59,226,174,71,17,179,225,81,40,243,184,168,159,182,207,25,170,126,138,107,223,81,213,94,101,45,0,45,51,94,211,246,38,89,22,72,81,172,210,220,171,148,43,25,32,157,175,234,232,146,228,22,72,136,92,16,58,167,30,29,64,43,230,140,139,85,22,94,104,244,71,170,94,2,233,184,193,116,146,171,158,106,156,9,185,98,60,103,194,18,90,176,138,114,199,164,150,156,94,32,83,26,15,92,125,213,117,13,66,251,15,200,186,188,197,248,241,85,247,249,33,85,227,60,31,104,254,20,81,119,152,255,66,153,95,105,240,188,2,62,33,205,135,114,216,45,252,14,116,181,206,87,18,164,34,26,89,164,123,37,167,30,168,128,90,98,158,23,39,46,21,202,243,233,106,42,12,168,8,216,169,138,154,16,4,186,21,242,89,149,220,69,75,90,172,64,167,35,186,190,29,97,156,134,211,45,200,90,34,184,129,200,12,73,128,233,140,21,243,6,56,171,60,248,10,41,34,227,242,115,43,201,127,37,250,85,55,126,27,174,255,135,163,126,98,35,186,238,134,122,172,239,254,230,218,135,206,103,136,244,211,162,34,93,228,180,66,199,192,120,164,223,164,0,66,26,180,66,201,163,90,127,179,253,3,93,223,183,82,235,13,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,203,110,227,32,20,253,149,17,234,50,68,96,140,9,217,78,102,164,72,109,21,77,59,221,212,93,92,195,165,181,228,71,132,73,53,157,200,255,62,132,58,74,82,77,55,101,1,54,247,158,7,7,246,228,42,188,109,145,44,201,61,122,15,67,239,194,252,123,239,113,190,241,189,193,97,152,95,247,6,154,250,47,84,13,110,192,67,139,1,253,3,52,59,28,174,235,33,204,190,93,194,200,140,92,189,166,42,89,62,238,201,58,96,251,123,109,35,59,67,43,68,165,13,205,164,80,52,119,26,40,112,169,168,146,153,132,194,106,45,185,136,96,211,55,187,182,187,193,0,27,8,47,100,185,39,137,45,18,24,101,51,86,0,208,156,113,19,39,45,105,5,185,136,4,202,44,28,215,60,71,77,198,25,25,204,11,182,144,68,79,96,52,76,228,150,107,42,249,66,210,92,43,75,53,43,10,154,105,151,105,37,152,80,142,31,192,83,255,9,24,124,92,98,193,214,195,182,129,183,135,207,234,219,139,104,206,59,246,229,123,194,37,89,150,159,101,60,173,119,201,250,101,202,31,3,46,201,172,36,119,253,206,155,3,163,56,252,28,15,156,20,216,52,232,127,166,227,120,231,72,176,27,232,224,25,253,109,84,76,240,84,90,65,128,36,126,31,125,31,137,53,171,10,89,185,5,101,206,197,252,121,206,233,66,41,77,179,60,99,241,3,156,102,42,161,127,161,67,143,157,193,47,26,75,202,39,51,199,183,16,119,186,93,211,36,129,33,157,255,240,184,38,227,83,101,117,118,75,103,12,189,173,93,141,118,221,125,209,209,10,93,162,252,217,251,31,127,226,163,175,187,231,233,198,206,164,79,61,43,211,78,251,35,25,199,167,241,31,245,207,75,171,99,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "09e20650fdc842099589e4895ac21b3c",
							"BaseElements.CancelPreviousVisas.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("e7a2c20a-9591-484e-bf77-5953f2dc592e");
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

			public AddVisaFlowElement(UserConnection userConnection, InvoiceVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddVisa";
				IsLogging = true;
				SchemaElementUId = new Guid("8d004d94-5e54-4b1e-80a4-f03f34f6f0bd");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Invoice = () => (Guid)((process.Invoice));
				_recordDefValues_VisaOwner = () => (Guid)((process.VisaOwner));
				_recordDefValues_Objective = () => new LocalizableString((process.VisaObjective));
				_recordDefValues_IsAllowedToDelegate = () => (bool)((process.IsAllowedToDelegate));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Invoice", () => _recordDefValues_Invoice.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_VisaOwner", () => _recordDefValues_VisaOwner.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Objective", () => _recordDefValues_Objective.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsAllowedToDelegate", () => _recordDefValues_IsAllowedToDelegate.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Invoice;
			internal Func<Guid> _recordDefValues_VisaOwner;
			internal Func<string> _recordDefValues_Objective;
			internal Func<bool> _recordDefValues_IsAllowedToDelegate;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("ec034d19-5185-497d-9066-29f2973037f1");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,150,77,111,27,55,16,134,255,138,177,201,81,99,240,99,184,36,117,43,170,22,48,144,180,70,147,230,98,251,48,36,135,142,10,73,43,172,214,110,83,67,255,61,163,181,92,203,73,235,24,61,25,73,246,176,90,113,57,31,124,135,207,44,111,154,151,195,135,53,55,211,230,45,247,61,109,186,58,28,255,216,245,124,124,218,119,153,55,155,227,87,93,166,197,252,111,74,11,62,165,158,150,60,112,255,142,22,87,188,121,53,223,12,147,163,135,102,205,164,121,121,61,190,109,166,103,55,205,201,192,203,223,79,138,120,103,226,24,83,155,192,112,81,128,154,2,196,144,11,68,111,216,98,171,75,140,40,198,185,91,92,45,87,175,121,160,83,26,222,55,211,155,102,244,38,14,200,123,114,152,8,138,73,22,176,148,4,73,71,7,38,155,162,145,172,119,169,109,182,147,102,147,223,243,146,198,160,247,198,156,149,197,162,35,56,29,28,96,244,18,88,181,45,152,88,77,244,86,89,95,245,206,120,63,255,222,240,236,197,217,201,230,215,63,87,220,191,25,253,78,43,45,54,124,113,44,163,159,12,252,35,206,244,198,146,42,206,91,3,133,90,3,152,109,2,82,45,130,69,107,148,104,96,147,87,219,139,23,23,187,136,101,190,89,47,232,195,187,207,3,159,172,174,187,121,230,219,105,235,7,210,31,78,188,57,191,173,224,121,51,61,255,175,26,238,127,111,51,126,88,197,79,11,120,222,76,206,155,55,221,85,159,119,30,237,238,207,157,160,99,4,181,191,224,95,110,119,215,173,143,209,236,53,173,232,146,251,95,36,226,104,62,190,154,209,64,99,240,183,146,247,157,227,100,162,83,94,87,240,76,17,144,69,185,80,52,65,212,49,85,43,106,214,106,70,235,223,184,114,207,171,204,15,19,75,53,89,109,75,129,148,156,148,152,117,130,192,104,192,22,217,94,172,10,249,236,70,251,49,242,125,50,119,123,77,70,86,87,139,197,24,96,51,174,127,183,121,247,137,239,223,204,14,138,117,224,161,43,243,58,231,114,178,250,159,82,205,184,142,46,127,238,250,159,254,18,168,230,171,203,125,197,14,66,223,207,153,229,229,126,124,219,108,183,147,67,202,156,72,136,10,43,40,147,18,160,85,12,193,85,37,144,132,192,45,198,90,41,61,74,89,181,150,188,99,37,85,40,8,152,84,11,132,90,65,138,28,173,177,45,186,164,159,9,101,217,251,168,252,184,184,152,37,213,234,165,224,222,67,137,172,115,117,42,107,235,190,76,217,15,235,117,223,93,115,255,29,179,167,97,22,176,34,166,72,34,120,150,54,156,83,5,218,53,243,44,197,55,89,203,45,230,175,30,179,214,96,210,133,11,160,217,41,161,156,232,135,161,236,128,147,6,239,218,104,218,250,40,102,217,4,65,210,32,120,34,13,34,40,66,10,178,149,75,38,85,217,150,144,48,61,19,204,156,42,209,153,42,203,100,37,45,69,99,145,130,151,86,146,70,213,134,202,132,164,159,138,25,45,142,186,244,7,231,97,126,253,205,124,215,228,160,98,73,51,131,242,28,228,220,34,192,37,47,232,21,197,173,14,73,169,154,202,99,192,61,57,177,175,25,56,162,202,85,250,61,196,218,10,47,228,164,107,161,246,208,86,95,156,124,176,74,204,143,159,30,125,65,103,49,49,96,144,76,209,71,43,192,97,128,214,123,93,8,163,81,254,217,156,30,179,44,54,91,11,220,74,91,192,90,42,36,52,10,92,37,175,106,144,30,157,205,151,129,155,241,130,47,105,152,119,171,163,53,247,203,249,48,112,249,86,144,139,114,200,118,169,6,80,181,230,93,203,210,16,118,155,199,136,140,242,64,85,206,13,223,145,251,28,185,139,237,71,20,131,202,228,14,14,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "09e20650fdc842099589e4895ac21b3c",
							"BaseElements.AddVisa.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("e7a2c20a-9591-484e-bf77-5953f2dc592e");
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

			public VisaApprovedEventFlowElement(UserConnection userConnection, InvoiceVisaBaseSubprocess process)
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
				EntitySchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",""$values"":[""58ebe36e-7384-4abd-b09c-407c6f508a4d""]}";
				EntityFilters = @"{_isFilter:false,uId:""c6f014b8-ea54-4f62-b765-e0d577a801dc"",name:""FilterEdit"",items:[{_isFilter:true,_filterSchemaUId:""ec034d19-5185-497d-9066-29f2973037f1"",uId:""9ca638a0-4a6a-448e-9418-a2de47386a8a"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""58ebe36e-7384-4abd-b09c-407c6f508a4d"",caption:""Status"",referenceSchemaUId:""66c8f5ac-57d2-4fe8-95a0-89a98e37f57f"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true},parameterValues:[{displayValue:""&quot;Positive&quot;"",parameterValue:""&quot;e79facb3-3c32-43e7-a59e-12ba125e6132&quot;""}]}},{_isFilter:true,_filterSchemaUId:""ec034d19-5185-497d-9066-29f2973037f1"",uId:""cdcdae87-0576-47d7-b0cc-c0eced9f0063"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""c7d206aa-401c-4095-ba43-757c8f1914e9"",caption:""Canceled"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false},parameterValues:[{parameterValue:""false""}]}}]}";
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

			public VisaRejectedEventFlowElement(UserConnection userConnection, InvoiceVisaBaseSubprocess process)
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
				EntitySchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",""$values"":[""58ebe36e-7384-4abd-b09c-407c6f508a4d""]}";
				EntityFilters = @"{_isFilter:false,uId:""dfcd61a9-4a65-45f1-a0fc-baadb54f99be"",name:""FilterEdit"",items:[{_isFilter:true,_filterSchemaUId:""ec034d19-5185-497d-9066-29f2973037f1"",uId:""68833a80-dd97-494e-a864-7994c5a1db47"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""58ebe36e-7384-4abd-b09c-407c6f508a4d"",caption:""Status"",referenceSchemaUId:""66c8f5ac-57d2-4fe8-95a0-89a98e37f57f"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true},parameterValues:[{displayValue:""&quot;Negative&quot;"",parameterValue:""&quot;a93ab0b9-ca36-4b95-9b23-e01aa169c338&quot;""}]}},{_isFilter:true,_filterSchemaUId:""ec034d19-5185-497d-9066-29f2973037f1"",uId:""8b7435ac-0271-4e79-88b1-fe0238cb1cc7"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""c7d206aa-401c-4095-ba43-757c8f1914e9"",caption:""Canceled"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false},parameterValues:[{parameterValue:""false""}]}}]}";
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

			public VisaCanceledEventFlowElement(UserConnection userConnection, InvoiceVisaBaseSubprocess process)
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
				EntitySchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",""$values"":[""c7d206aa-401c-4095-ba43-757c8f1914e9""]}";
				EntityFilters = @"{_isFilter:false,uId:""74742b14-1d74-4ec7-90ea-91e36e4e0254"",name:""FilterEdit"",items:[{_isFilter:true,_filterSchemaUId:""ec034d19-5185-497d-9066-29f2973037f1"",uId:""9d522176-afea-4238-92f6-af2b615dff00"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""c7d206aa-401c-4095-ba43-757c8f1914e9"",caption:""Canceled"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false},parameterValues:[{parameterValue:""true""}]}}]}";
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

			public FindPositiveVisaFlowElement(UserConnection userConnection, InvoiceVisaBaseSubprocess process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,91,107,27,87,16,254,47,251,208,167,157,114,238,23,245,169,49,46,24,74,106,72,91,10,193,132,57,183,120,201,106,87,217,75,154,32,244,223,59,43,89,169,48,194,117,221,26,106,232,139,216,61,123,102,206,124,115,190,111,102,180,125,215,140,63,52,237,148,135,85,193,118,204,245,124,149,86,149,193,98,76,20,6,108,198,8,138,51,7,206,8,7,158,49,167,76,98,82,40,91,213,29,174,243,170,58,88,95,166,102,170,234,102,202,235,113,245,118,251,167,211,105,152,115,253,174,236,95,222,196,219,188,198,95,150,3,114,100,82,37,238,65,115,167,65,121,155,200,183,49,32,124,17,222,74,38,109,225,213,33,22,89,10,119,142,11,8,44,81,44,210,21,8,81,122,48,69,11,238,153,48,12,41,150,54,151,233,242,243,102,200,227,216,244,221,106,155,191,62,255,252,101,67,81,30,206,190,232,219,121,221,85,245,58,79,120,141,211,237,170,66,107,81,171,128,144,68,144,160,82,10,16,184,215,32,162,72,92,161,180,58,152,170,142,184,153,22,183,213,85,247,169,111,98,174,234,33,151,60,228,46,230,19,80,161,4,201,101,74,16,130,38,80,153,7,112,89,9,144,73,42,147,89,66,27,117,85,39,156,240,87,108,231,188,15,108,219,44,134,194,107,102,121,89,210,237,201,208,8,112,137,35,120,238,67,145,86,138,82,196,49,221,63,246,253,135,121,67,169,30,95,207,235,60,52,241,238,222,50,93,64,63,172,182,177,239,166,161,111,23,231,175,79,12,14,247,115,247,241,183,67,78,218,253,151,197,176,218,213,243,152,47,218,38,119,211,101,23,251,212,116,239,247,87,183,219,145,205,122,131,67,51,30,51,121,249,113,198,150,18,208,188,191,125,48,227,23,243,56,245,235,151,134,183,38,172,228,134,216,186,143,121,33,115,106,198,77,139,95,246,239,171,234,155,143,115,63,125,119,199,131,195,75,117,207,232,184,73,34,75,154,208,64,66,66,168,162,12,128,204,40,144,74,10,22,76,144,193,178,59,15,187,250,233,199,188,189,26,127,250,189,59,202,235,144,158,155,111,105,245,222,194,245,209,122,181,125,76,100,187,155,99,108,55,196,130,127,85,210,86,123,238,60,74,176,42,250,101,171,2,239,139,3,44,65,5,210,33,143,5,159,46,233,34,37,90,157,25,177,43,41,80,129,25,64,42,97,16,124,246,82,72,163,116,224,39,146,254,126,179,25,250,79,121,56,175,105,167,138,82,193,35,249,137,84,31,98,40,128,28,29,68,130,43,34,167,31,31,95,26,199,255,215,244,89,177,29,137,240,176,218,162,181,158,217,194,168,67,120,106,71,161,88,42,242,214,66,242,153,104,171,89,228,82,63,44,234,199,157,243,4,85,63,38,180,103,84,181,79,41,41,238,36,36,206,22,85,83,15,244,193,104,144,82,38,199,180,66,103,213,211,85,29,109,18,204,32,9,145,113,2,199,168,71,7,84,84,66,180,141,174,112,207,85,246,39,170,190,64,210,113,155,211,89,174,122,170,113,58,80,193,97,165,44,227,141,226,224,40,119,32,148,96,244,128,133,210,120,228,234,171,190,111,51,118,127,131,172,23,183,57,126,120,213,127,190,79,213,184,172,7,90,63,71,212,189,207,127,160,204,175,52,120,89,128,207,72,243,190,28,246,27,159,129,174,198,105,69,124,114,192,169,33,128,82,66,128,79,65,64,137,194,202,164,172,244,204,61,157,174,218,229,144,165,201,96,165,163,38,132,129,166,66,182,168,146,217,72,147,43,115,168,210,9,93,223,76,56,205,227,249,22,68,147,184,43,154,230,112,77,18,0,85,50,205,225,26,25,80,7,245,46,19,34,109,203,75,43,201,207,69,244,255,48,228,71,118,161,235,126,108,166,230,211,95,204,124,217,250,130,145,254,177,200,72,83,156,146,217,2,106,159,129,139,128,92,232,108,184,20,39,133,254,102,247,7,163,173,107,214,232,13,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,79,202,74,77,46,201,44,75,181,50,180,50,212,241,76,177,50,176,50,0,0,200,6,180,116,20,0,0,0 })));
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
								new Guid("ec034d19-5185-497d-9066-29f2973037f1")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("ec034d19-5185-497d-9066-29f2973037f1"));
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

		public InvoiceVisaBaseSubprocess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoiceVisaBaseSubprocess";
			SchemaUId = new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c");
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
				return new Guid("09e20650-fdc8-4209-9589-e4895ac21b3c");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: InvoiceVisaBaseSubprocess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: InvoiceVisaBaseSubprocess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid Invoice {
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
			bool result = Convert.ToBoolean((VisaOwner) == null || (Invoice) == null);
			Log.InfoFormat(ConditionalExpressionLogMessage, "InputParametersGateway", "ConditionalFlow2", "(VisaOwner) == null || (Invoice) == null", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((IsPreviousVisaCounts));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow3", "(IsPreviousVisaCounts)", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("Invoice")) {
				writer.WriteValue("Invoice", Invoice, Guid.Empty);
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
			MetaPathParameterValues.Add("3a0d5732-da62-4c3b-a064-34320b6b3b70", () => Invoice);
			MetaPathParameterValues.Add("c77907f0-2c9c-4bf7-8e77-d9e1cf50c135", () => VisaOwner);
			MetaPathParameterValues.Add("50d952fa-4e0b-414d-a1d6-444068fea4a1", () => VisaObjective);
			MetaPathParameterValues.Add("d2fd2fb7-ec08-4092-840e-40479398aece", () => VisaResult);
			MetaPathParameterValues.Add("3cafec33-e6b4-4fdf-b420-5fa70f8373c2", () => IsAllowedToDelegate);
			MetaPathParameterValues.Add("2b0415c8-fe33-430e-b6b0-0d6cee817372", () => IsPreviousVisaCounts);
			MetaPathParameterValues.Add("6c9b198f-bc19-4b69-ab86-d1dd9334339a", () => CancelPreviousVisas.EntitySchemaUId);
			MetaPathParameterValues.Add("49cbb5c4-bd70-43aa-8f31-4879e73d2376", () => CancelPreviousVisas.IsMatchConditions);
			MetaPathParameterValues.Add("d6d65720-6f5e-4f79-b9bc-19d68d9d465f", () => CancelPreviousVisas.DataSourceFilters);
			MetaPathParameterValues.Add("11edda32-f2fb-41b4-8837-0586bfabade5", () => CancelPreviousVisas.RecordColumnValues);
			MetaPathParameterValues.Add("071820bb-c98b-4df2-9dfd-1e5cd9193237", () => CancelPreviousVisas.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("69a4680b-dced-4f91-9736-b89098e9b12c", () => AddVisa.EntitySchemaId);
			MetaPathParameterValues.Add("ce9ba715-9c2b-4b46-b3cd-a342eea5cf22", () => AddVisa.DataSourceFilters);
			MetaPathParameterValues.Add("fbf6a978-d0cf-473f-8ce4-5a20e548bb14", () => AddVisa.RecordAddMode);
			MetaPathParameterValues.Add("3691ae8b-153d-41dc-8223-2f176da23196", () => AddVisa.FilterEntitySchemaId);
			MetaPathParameterValues.Add("0a9c1fff-05ca-424d-919c-e1edf51210b3", () => AddVisa.RecordDefValues);
			MetaPathParameterValues.Add("58cb0143-4eb3-4db4-b3d9-85dbab73eef1", () => AddVisa.RecordId);
			MetaPathParameterValues.Add("218938bc-c581-43d3-a013-ab7675b1954c", () => AddVisa.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("e7518960-69b7-4cb5-92f0-4092f7a8b622", () => FindPositiveVisa.IgnoreDisplayValues);
			MetaPathParameterValues.Add("8cbb61ab-037c-4b9c-993a-744caf8c6168", () => FindPositiveVisa.ResultCompositeObjectList);
			MetaPathParameterValues.Add("921acd6f-f51d-4633-bcad-6e4a83d31fab", () => FindPositiveVisa.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "Invoice":
					if (!hasValueToRead) break;
					Invoice = reader.GetValue<System.Guid>();
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
			var cloneItem = (InvoiceVisaBaseSubprocess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


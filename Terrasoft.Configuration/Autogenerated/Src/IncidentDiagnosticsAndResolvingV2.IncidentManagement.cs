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

	#region Class: IncidentDiagnosticsAndResolvingV2Schema

	/// <exclude/>
	public class IncidentDiagnosticsAndResolvingV2Schema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public IncidentDiagnosticsAndResolvingV2Schema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public IncidentDiagnosticsAndResolvingV2Schema(IncidentDiagnosticsAndResolvingV2Schema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "IncidentDiagnosticsAndResolvingV2";
			UId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb");
			CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsActiveVersion = false;
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
			Version = 1;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb");
			Version = 1;
			PackageUId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("415d89df-f50f-46b6-8a77-b034e8173608"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"ProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"Guid.Parse(""6AEEED31-5D8C-452E-B157-ED9AD8B83E57"")",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsTaskExistsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ecd8a32c-df30-44e9-89f6-3adc6c3bdfd8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"IsTaskExists",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"false",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateNotStartedActivityStatusIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ec21229b-9b25-49d7-92ad-eed18aa728e5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"NotStartedActivityStatusId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.805aace4-8604-40e7-a9eb-0f54174593c0.384d4b84-58e6-df11-971b-001d60e938c6#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentTaskIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ae73a291-5391-4398-ad71-c61091bd78fe"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"CurrentTaskId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTaskCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7cdb4564-160f-4dc7-afbd-a2d9ac97aa23"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"TaskCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateTaskCaptionValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a0a5e89d-ee0e-4227-948e-7fcad6fbb49e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("391f4991-86a6-4a6d-9a3e-b08a114cc7d3"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"TaskCaptionValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateActivityDueDateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("77719740-2177-4b8a-b22a-54a091ab6496"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"ActivityDueDate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActivityStartDateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("aa6b400d-ea76-4b36-a31a-03f5695b31dc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"ActivityStartDate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateProcessUIdParameter());
			Parameters.Add(CreateIsTaskExistsParameter());
			Parameters.Add(CreateNotStartedActivityStatusIdParameter());
			Parameters.Add(CreateCurrentTaskIdParameter());
			Parameters.Add(CreateTaskCaptionParameter());
			Parameters.Add(CreateTaskCaptionValueParameter());
			Parameters.Add(CreateActivityDueDateParameter());
			Parameters.Add(CreateActivityStartDateParameter());
		}

		protected virtual void InitializeCreatedNewIncidentStartSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eb69a7f3-6d56-4292-8246-38c29e406529"),
				ContainerUId = new Guid("9ad8937e-6a59-4a6c-b6b0-32c1157f455c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9ad8937e-6a59-4a6c-b6b0-32c1157f455c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
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
				UId = new Guid("b7921a8f-2af8-4912-99a2-e91f94ee1377"),
				ContainerUId = new Guid("9ad8937e-6a59-4a6c-b6b0-32c1157f455c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9ad8937e-6a59-4a6c-b6b0-32c1157f455c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeModifiedInactiveIncidentStartSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ad68430c-33cb-4b0e-9767-a62d05a705bb"),
				ContainerUId = new Guid("cefe2402-d24e-4662-9268-03c62b4e8ad0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cefe2402-d24e-4662-9268-03c62b4e8ad0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
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
				UId = new Guid("133eafbe-3f14-4fbf-8b65-546fedfd2878"),
				ContainerUId = new Guid("cefe2402-d24e-4662-9268-03c62b4e8ad0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cefe2402-d24e-4662-9268-03c62b4e8ad0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeAddDiagnoseTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("47381106-439b-48de-a3be-7347358ad7d6"),
				ContainerUId = new Guid("81eb01f4-e429-4220-8543-2f8b4220d93b"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2e5068e9-10ba-4629-9ad3-a2262e2be850"),
				ContainerUId = new Guid("81eb01f4-e429-4220-8543-2f8b4220d93b"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b0c3a7d0-eda7-45fa-93f0-1e0bd05d687d"),
				ContainerUId = new Guid("81eb01f4-e429-4220-8543-2f8b4220d93b"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("2ff06d85-70bf-4fe3-84cb-f040ea533588"),
				ContainerUId = new Guid("81eb01f4-e429-4220-8543-2f8b4220d93b"),
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
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fb5c9609-3001-46fb-999e-e8f79c1d2ce2"),
				ContainerUId = new Guid("81eb01f4-e429-4220-8543-2f8b4220d93b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,152,91,111,83,73,12,128,255,74,116,224,141,58,154,139,231,214,55,4,172,84,9,88,180,237,242,66,121,240,204,120,74,68,154,84,57,39,172,216,170,255,125,125,210,22,90,180,244,162,85,151,34,154,135,84,153,30,123,60,182,63,219,115,142,187,199,195,231,35,238,182,187,61,94,173,168,95,182,97,250,108,185,226,233,155,213,178,112,223,79,95,46,11,205,103,127,83,158,243,27,90,209,33,15,188,122,75,243,53,247,47,103,253,176,53,185,44,214,109,117,143,63,109,254,219,109,191,59,238,118,6,62,252,115,167,138,118,180,204,49,163,7,114,49,2,22,67,144,155,67,200,33,83,181,74,151,230,162,8,151,229,124,125,184,120,197,3,189,161,225,67,183,125,220,109,180,137,130,18,53,54,10,26,88,233,12,104,141,3,42,177,66,172,72,38,89,174,218,198,238,100,171,235,203,7,62,164,205,166,23,132,17,83,141,214,0,97,41,128,89,105,200,169,58,136,164,77,65,67,169,197,52,10,159,61,255,85,240,221,163,151,203,229,199,245,209,52,121,205,70,69,177,95,27,217,190,154,0,89,37,7,168,178,102,143,213,151,162,166,205,233,130,30,45,184,200,30,106,211,26,82,16,107,149,210,213,43,78,54,22,255,232,253,184,81,157,245,71,115,250,252,246,187,251,61,45,195,236,211,108,248,60,41,52,240,193,114,245,121,186,183,156,212,229,169,244,209,165,64,92,148,63,222,63,141,231,126,183,189,255,189,136,158,253,221,221,56,234,114,76,191,13,231,126,183,181,223,237,46,215,171,50,106,180,242,227,249,5,195,55,155,108,30,249,230,231,121,252,100,101,177,158,207,207,86,158,211,64,231,15,158,47,47,235,172,205,184,238,44,118,207,195,182,209,162,206,62,240,47,95,231,159,83,219,254,139,216,43,90,208,1,175,94,139,3,190,218,254,197,202,61,113,227,185,226,108,146,83,65,55,8,76,9,144,189,145,188,211,4,73,167,220,108,176,166,53,179,145,254,131,27,175,120,81,248,178,97,55,201,158,51,249,126,227,237,17,156,51,187,70,87,157,116,39,39,91,23,113,146,220,10,53,176,3,173,170,6,212,181,64,76,88,193,171,156,83,114,62,112,75,87,226,212,84,176,190,145,133,144,70,5,193,43,32,246,9,146,231,226,124,74,22,147,190,11,156,222,237,244,191,255,181,224,213,169,127,182,27,205,123,126,63,149,213,111,22,94,204,249,144,23,195,246,113,108,46,32,187,12,193,27,20,67,141,129,164,36,8,182,52,239,164,114,100,162,120,34,2,95,18,121,251,56,144,211,132,209,64,41,222,139,115,92,0,10,222,129,10,181,17,39,86,205,231,81,228,197,98,16,194,158,109,124,36,82,202,27,85,37,91,24,153,0,37,190,144,154,248,21,93,48,173,84,169,51,90,164,174,195,247,15,166,42,204,246,60,169,146,72,211,223,102,171,126,152,204,36,110,147,101,155,172,184,95,207,135,217,226,96,34,129,153,179,32,190,92,76,159,246,253,236,96,193,252,128,246,79,137,182,246,153,173,119,26,98,99,51,38,91,18,249,42,52,69,101,43,250,104,107,181,183,66,219,75,159,104,46,139,5,110,84,104,164,229,101,39,41,44,217,235,180,228,111,83,154,174,68,59,55,162,84,66,131,98,189,180,90,84,114,34,171,197,34,29,188,87,141,154,198,59,233,148,247,23,109,111,147,111,232,25,10,166,6,216,178,68,203,41,153,29,12,70,159,90,83,152,237,93,160,253,108,185,24,168,12,15,100,63,144,61,146,45,57,135,60,14,0,177,218,52,146,157,55,76,130,231,204,129,141,243,158,240,74,178,49,20,172,5,131,100,175,17,5,85,49,144,52,113,104,38,197,156,141,42,50,4,255,90,100,19,43,70,87,104,36,91,198,169,198,34,101,83,5,75,57,152,16,89,123,29,238,130,236,157,250,0,245,207,9,181,204,205,242,144,160,108,130,36,140,179,8,17,229,158,166,37,235,180,118,133,83,169,183,130,90,177,139,1,137,33,144,242,99,6,74,91,137,217,129,17,160,139,53,152,108,185,186,93,11,209,77,145,213,16,90,13,2,181,116,126,82,10,101,12,213,54,235,32,22,218,31,58,137,95,100,180,212,140,206,35,104,153,35,196,212,34,180,181,92,129,76,77,84,82,32,50,155,62,250,100,178,223,77,30,237,119,79,238,115,233,8,57,22,246,25,193,36,169,31,168,228,48,153,105,28,182,114,11,89,42,173,66,186,190,116,236,81,255,81,74,199,209,88,21,46,29,252,246,53,229,245,250,48,243,234,161,174,252,144,186,34,61,196,186,182,153,146,133,33,44,94,114,40,121,2,43,109,158,60,53,42,173,92,85,87,110,108,216,77,235,74,106,82,57,70,194,42,5,59,190,239,146,97,161,201,244,225,217,215,216,138,205,42,95,115,195,207,170,250,38,183,88,29,36,171,145,164,164,144,118,78,42,69,246,104,139,175,234,87,187,6,100,237,172,50,37,9,226,69,54,170,9,71,151,58,144,105,78,137,187,169,54,214,119,114,195,47,101,185,94,60,92,3,126,206,137,193,184,26,138,166,12,186,178,146,137,97,68,97,188,83,43,35,179,167,163,96,170,231,91,78,12,182,26,31,2,200,117,94,200,86,14,33,137,70,72,136,156,41,83,179,198,92,61,49,40,43,173,75,78,164,93,150,139,137,183,82,181,114,246,32,45,204,134,64,25,75,202,247,101,98,8,65,167,32,135,51,90,14,140,57,18,100,99,8,156,212,163,36,78,245,152,252,245,200,157,191,12,127,190,102,9,241,195,155,178,31,3,82,53,90,74,107,67,40,74,70,64,84,218,72,44,163,135,70,154,162,14,186,18,226,255,218,34,91,144,22,105,91,132,224,130,144,221,140,149,84,206,13,188,138,89,123,177,201,100,123,37,72,99,202,147,179,17,188,206,210,34,147,10,227,43,223,6,74,39,159,180,151,190,80,235,61,1,137,72,70,85,165,42,176,52,58,217,205,122,185,232,74,21,83,182,57,159,92,182,186,150,155,131,180,59,208,106,120,64,233,151,70,233,253,201,63,179,30,208,98,252,29,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("15433e0e-c833-4c29-9b51-7ec388ba323f"),
				ContainerUId = new Guid("81eb01f4-e429-4220-8543-2f8b4220d93b"),
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
				UId = new Guid("2ffddea6-666f-447f-a4a5-04225016ac33"),
				ContainerUId = new Guid("81eb01f4-e429-4220-8543-2f8b4220d93b"),
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

		protected virtual void InitializeReadCaseDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e20c98d0-9d0e-407b-930b-a6b43f524e3c"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,75,111,211,64,16,254,43,145,207,221,202,222,151,237,220,80,8,168,7,104,69,43,46,164,135,241,238,56,89,225,151,214,78,75,169,242,223,25,219,105,104,171,148,166,72,8,144,234,211,122,244,205,204,55,143,111,247,54,48,5,180,237,71,40,49,152,6,23,232,61,180,117,222,29,191,115,69,135,254,189,175,215,77,112,20,180,232,29,20,238,59,218,209,62,183,174,123,11,29,144,203,237,226,103,132,69,48,93,236,143,177,8,142,22,129,235,176,108,9,67,46,177,209,218,42,195,153,81,57,103,50,55,9,203,84,152,179,56,19,73,44,227,84,242,60,29,145,79,5,159,213,101,3,30,199,28,67,248,124,56,94,220,52,61,52,34,131,25,32,174,173,171,173,81,244,36,218,121,5,89,129,150,254,59,191,70,50,117,222,149,84,13,94,184,18,207,192,83,174,62,78,221,155,8,148,67,209,246,168,2,243,110,254,173,241,216,182,174,174,158,35,87,172,203,234,62,154,2,224,238,119,75,39,28,56,246,200,51,232,86,67,136,19,162,181,25,88,190,89,46,61,46,161,115,87,247,73,124,197,155,1,119,88,255,200,193,210,148,62,67,177,198,123,57,31,86,50,131,166,27,11,26,211,19,192,187,229,234,224,90,119,29,123,174,92,78,198,230,14,124,96,204,189,53,112,77,198,171,222,48,70,185,59,46,130,47,39,237,233,117,133,254,220,172,176,132,177,107,151,199,100,125,100,152,23,88,98,213,77,111,83,176,73,42,98,100,26,84,202,36,104,195,50,157,133,76,112,19,69,42,206,165,82,102,67,14,59,66,211,91,204,116,10,113,46,24,13,64,51,201,83,206,18,46,53,19,137,225,41,202,80,43,158,110,46,71,226,174,109,10,184,249,188,227,55,243,72,75,101,39,21,94,79,92,101,156,37,18,199,159,208,212,222,14,147,167,143,220,180,8,19,29,70,17,75,49,148,76,42,141,44,51,144,178,72,8,161,172,18,42,73,94,197,241,11,113,28,214,191,87,113,60,39,14,131,57,114,25,114,102,185,68,38,181,230,44,229,58,97,161,48,154,103,18,19,176,225,35,113,128,213,137,20,161,97,66,152,140,201,44,68,150,198,58,102,160,185,13,21,196,161,202,178,167,196,241,161,182,46,119,164,14,87,129,233,71,187,147,200,228,218,117,171,9,173,48,109,230,132,154,226,150,21,226,35,221,244,139,81,212,75,103,160,56,109,208,195,118,108,209,254,173,126,32,135,190,99,190,174,187,177,15,187,142,207,160,197,129,233,221,94,129,69,174,184,200,88,162,146,180,87,190,164,189,162,75,55,237,107,142,140,206,69,159,98,67,239,101,63,148,243,122,237,205,86,130,237,248,80,254,214,3,248,23,148,251,18,49,238,149,195,33,235,253,127,222,234,47,190,162,95,199,247,47,221,59,127,242,166,216,4,155,31,42,231,46,119,78,11,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fa34df5c-7b4e-47ae-a912-474e470b6c45"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("90e6fe3b-6a23-4699-9d12-17cb6e9231df"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f4188d8f-b976-4570-97fc-41b0f9be5bfc"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dfebf7b5-d60e-4831-b0d2-43813be0a77d"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9adc4f45-21a7-4b76-9422-1980c48bcf46"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7754467c-fdaa-4a75-8546-a1292b5a6ded"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("7a51a482-cc66-4157-a765-07dfae9e0f6b"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f5018c00-5f7e-48d6-bf73-d4ce6cbf8adf"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("cad8e278-2b4a-4f1b-8ccf-55db9d72df60"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("31c46bd6-ea7c-4f58-8530-fa76fa4e672f"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("81e76ac5-083c-40f7-a7a6-1a58511ec988"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f3ab54a9-d46b-470b-9dd7-8f28314883aa"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("29febfab-7d22-4313-9fce-288ec640e85f"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("c73dce7a-814b-4024-bd5d-023c0ae8ff38"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d2d9806f-75cc-4f82-957f-a0faf091d697"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("80b7264a-0735-4862-9f54-b35f79ae6dba"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("deb1676b-e3ed-4d08-b4d4-40bb2d5e2294"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("852a79b3-d625-4f18-b6ee-e2a25dd3c9b6"),
				ContainerUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeResolvedCatchSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("78f519cc-f8d2-4fac-9f87-2dc4c245ab29"),
				ContainerUId = new Guid("b64d7413-4571-4a80-9683-fa8ed03cf197"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b64d7413-4571-4a80-9683-fa8ed03cf197"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8f574e5b-7624-4722-90a9-3cf65d30baa8}].[Parameter:{7a51a482-cc66-4157-a765-07dfae9e0f6b}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeResolvedChangeDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("92796a3d-edaa-47bf-9730-0fb84a1bcb7f"),
				ContainerUId = new Guid("cc3ba7b8-b66a-4e6a-9d64-0c10df04ce80"),
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
				Value = @"c449d832-a4cc-4b01-b9d5-8a12c42a9f89",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("69f7d295-e143-42e8-bb3c-c2f6f0421146"),
				ContainerUId = new Guid("cc3ba7b8-b66a-4e6a-9d64-0c10df04ce80"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("792c5022-ebba-44b5-955b-42c816843971"),
				ContainerUId = new Guid("cc3ba7b8-b66a-4e6a-9d64-0c10df04ce80"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,85,201,110,219,48,16,253,21,67,231,48,16,37,70,75,110,65,146,22,190,52,1,28,228,82,231,48,164,134,54,17,109,32,169,180,110,224,127,239,72,178,221,164,112,27,183,232,146,162,62,216,210,248,241,205,155,149,143,129,42,193,185,119,80,97,112,26,220,160,181,224,26,237,143,223,152,210,163,125,107,155,174,13,142,2,135,214,64,105,62,97,49,218,47,11,227,47,192,3,29,121,156,127,97,152,7,167,243,253,28,243,224,104,30,24,143,149,35,12,29,201,85,170,69,162,144,137,88,43,38,162,56,101,178,136,4,211,160,34,93,64,42,49,230,35,242,91,228,231,77,213,130,197,209,199,64,175,135,199,155,85,219,67,57,25,212,0,49,174,169,55,198,184,23,225,46,107,144,37,22,244,238,109,135,100,242,214,84,20,13,222,152,10,175,193,146,175,158,167,233,77,4,210,80,186,30,85,162,246,151,31,91,139,206,153,166,126,73,92,217,85,245,83,52,17,224,238,117,35,39,28,52,246,200,107,240,203,129,98,74,178,214,131,202,179,197,194,226,2,188,121,120,42,226,30,87,3,238,176,252,209,129,130,170,116,11,101,135,79,124,62,143,228,28,90,63,6,52,186,39,128,53,139,229,193,177,238,50,246,82,184,17,25,219,45,248,64,206,189,49,68,9,25,31,122,195,200,178,125,156,7,239,167,238,234,67,141,118,166,150,88,193,152,181,187,99,178,126,101,216,241,159,62,2,166,49,68,57,103,39,49,125,137,56,207,24,20,41,103,42,225,97,206,101,145,102,26,215,119,163,14,227,218,18,86,183,59,119,231,157,181,88,251,137,7,119,63,153,94,12,160,62,133,244,87,132,66,229,32,98,166,248,137,100,34,76,34,38,67,41,89,202,229,73,30,101,192,115,174,169,212,244,161,51,169,138,179,60,5,96,73,26,23,76,164,66,178,60,21,200,194,92,114,173,32,195,236,255,156,134,153,7,223,57,218,35,181,113,203,195,6,227,176,84,238,105,42,30,125,119,50,54,82,198,159,137,113,19,109,106,40,255,133,105,25,2,219,142,200,144,174,77,215,149,205,194,40,40,175,90,180,176,137,51,220,223,18,207,122,169,31,62,219,52,126,28,169,157,156,51,69,21,49,126,53,104,216,86,3,65,138,4,184,102,137,208,33,85,35,166,41,144,50,102,69,24,201,34,65,145,105,213,47,60,186,97,122,213,179,166,179,106,211,195,110,188,90,126,234,202,248,11,173,255,35,187,125,111,191,28,82,255,215,178,7,127,239,138,123,165,213,219,179,139,126,89,33,255,248,136,174,131,245,103,246,5,23,239,249,9,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("59ead31f-77ed-48f6-a880-82e8bb04a642"),
				ContainerUId = new Guid("cc3ba7b8-b66a-4e6a-9d64-0c10df04ce80"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,203,110,219,48,16,252,21,131,201,209,107,144,20,69,145,190,21,205,37,64,82,4,117,154,75,156,195,146,92,54,66,101,203,208,35,64,106,248,223,75,43,118,98,7,77,27,160,232,161,64,117,144,64,106,103,118,52,203,209,154,157,118,143,43,98,83,118,77,77,131,109,29,187,201,199,186,161,201,85,83,123,106,219,201,69,237,177,42,191,163,171,232,10,27,92,80,71,205,13,86,61,181,23,101,219,141,71,199,48,54,102,167,15,195,91,54,189,93,179,243,142,22,95,206,67,98,23,198,112,116,222,65,212,50,3,133,153,5,44,10,9,166,240,36,17,77,206,35,38,176,175,171,126,177,188,164,14,175,176,187,103,211,53,27,216,18,129,55,193,168,104,61,56,101,28,168,194,58,176,232,53,40,37,100,204,84,166,61,74,182,25,179,214,223,211,2,135,166,7,96,165,108,48,153,4,84,222,131,114,92,128,179,33,7,131,66,122,37,209,70,99,183,224,93,253,11,240,246,228,162,174,191,245,171,137,225,57,162,39,5,70,115,5,138,83,1,104,201,1,143,185,18,133,202,109,230,249,68,185,224,156,49,17,114,67,26,66,20,2,108,33,82,17,23,65,115,178,153,241,250,228,110,219,40,148,237,170,194,199,155,55,251,125,240,93,249,80,118,143,163,182,195,174,111,147,185,139,85,149,188,15,79,248,213,209,40,14,25,214,243,167,137,206,217,116,254,214,76,119,207,217,96,213,241,84,95,15,116,206,198,115,54,171,251,198,111,25,179,180,56,59,144,62,52,25,74,94,45,247,19,76,59,203,190,170,118,59,103,216,225,190,112,191,93,135,50,150,20,206,151,179,253,224,6,22,190,187,224,39,183,253,245,164,237,79,96,151,184,196,175,212,124,74,6,188,104,127,86,121,157,108,220,19,59,105,115,94,136,8,5,161,5,69,58,29,221,32,16,172,176,46,102,69,38,99,148,3,250,51,69,106,104,233,233,88,216,123,206,207,14,223,14,110,111,163,179,211,181,181,106,195,54,155,241,97,160,84,144,210,72,138,192,139,196,170,114,76,130,200,72,8,74,134,16,149,115,24,242,95,6,10,41,43,164,143,8,40,211,103,169,34,242,20,7,173,64,20,65,100,5,57,178,90,255,197,64,101,210,186,192,53,65,180,121,106,111,164,2,228,209,129,201,41,36,47,163,180,202,76,40,42,173,68,238,147,215,219,168,103,233,255,97,61,34,100,154,114,212,58,23,193,199,119,6,42,249,218,87,221,168,142,35,220,69,107,50,75,222,116,101,189,28,197,186,95,254,15,214,191,25,172,247,156,163,223,5,235,110,243,3,141,80,24,75,7,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bf527547-9986-4b51-846e-92eb30993331"),
				ContainerUId = new Guid("cc3ba7b8-b66a-4e6a-9d64-0c10df04ce80"),
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

		protected virtual void InitializeCanceledCatchSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9e2aacd6-9c62-4726-94bc-1859bba3cced"),
				ContainerUId = new Guid("1ae2d9da-9762-47c2-8ddd-7f67b805d1fb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1ae2d9da-9762-47c2-8ddd-7f67b805d1fb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8f574e5b-7624-4722-90a9-3cf65d30baa8}].[Parameter:{7a51a482-cc66-4157-a765-07dfae9e0f6b}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeCanceledChangeDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("183ecb6a-29e5-46cc-83dd-a8ec060bc191"),
				ContainerUId = new Guid("469548be-7215-434c-8fda-7e541797fdf9"),
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
				Value = @"c449d832-a4cc-4b01-b9d5-8a12c42a9f89",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("58ab220b-a239-4004-a8b3-362b8616d6b5"),
				ContainerUId = new Guid("469548be-7215-434c-8fda-7e541797fdf9"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cb23be2e-d56f-4c76-8277-bea8232dc232"),
				ContainerUId = new Guid("469548be-7215-434c-8fda-7e541797fdf9"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,85,201,110,219,48,16,253,21,67,231,48,144,72,89,18,125,11,146,180,200,165,9,16,35,151,58,135,161,52,178,137,104,3,73,165,117,13,255,123,71,146,237,38,133,218,184,69,151,20,245,193,150,158,31,103,222,172,220,120,105,1,214,190,131,18,189,153,55,71,99,192,214,185,59,125,163,11,135,230,173,169,219,198,59,241,44,26,13,133,254,132,217,128,95,102,218,93,128,3,58,178,89,124,177,176,240,102,139,113,27,11,239,100,225,105,135,165,37,14,29,1,197,211,48,144,17,83,92,33,11,69,224,51,37,69,204,146,24,253,32,11,67,161,178,100,96,126,203,248,121,93,54,96,112,240,209,155,207,251,199,249,186,233,168,1,1,105,79,209,182,174,118,160,232,68,216,203,10,84,129,25,189,59,211,34,65,206,232,146,162,193,185,46,241,6,12,249,234,236,212,29,68,164,28,10,219,177,10,204,221,229,199,198,160,181,186,174,94,18,87,180,101,245,148,77,6,240,240,186,147,227,247,26,59,230,13,184,85,111,226,138,100,109,123,149,103,203,165,193,37,56,253,248,84,196,3,174,123,222,113,249,163,3,25,85,233,14,138,22,159,248,124,30,201,57,52,110,8,104,112,79,4,163,151,171,163,99,61,100,236,165,112,57,129,205,158,124,164,205,209,24,120,68,224,99,7,12,86,246,143,11,239,253,149,189,254,80,161,185,77,87,88,194,144,181,251,83,66,191,2,14,246,103,27,192,88,0,151,1,155,10,250,10,133,76,24,100,113,192,210,40,240,101,160,178,56,201,113,123,63,232,208,182,41,96,125,119,112,119,222,26,131,149,155,56,176,15,147,171,139,158,212,165,144,254,138,68,34,80,9,197,184,192,136,133,190,31,48,165,20,176,76,228,42,73,49,228,97,230,83,169,233,67,103,166,121,154,38,10,21,147,145,228,68,14,19,150,160,20,108,26,65,28,197,145,136,165,244,255,199,105,184,117,224,90,75,123,164,210,118,117,220,96,28,151,202,145,166,10,248,119,39,99,39,101,248,153,104,59,201,117,5,197,191,48,45,125,96,251,17,233,211,181,235,186,162,94,234,20,138,235,6,13,236,226,244,199,91,226,89,47,117,195,103,234,218,13,35,117,144,115,150,82,69,180,91,247,26,246,213,144,241,84,170,128,11,70,253,46,89,168,124,206,36,231,138,229,144,101,34,136,19,244,243,136,234,74,55,76,167,250,182,110,77,186,235,97,59,92,45,63,117,101,252,133,214,255,145,221,62,218,47,199,212,255,181,236,193,223,187,226,94,105,245,70,118,209,47,43,228,31,31,209,173,183,253,12,73,226,161,1,249,9,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1546ad35-5335-436b-9a67-31666d57fea3"),
				ContainerUId = new Guid("469548be-7215-434c-8fda-7e541797fdf9"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,83,77,79,219,64,16,253,43,145,225,152,137,246,203,251,145,91,5,23,36,168,80,161,92,8,135,217,221,217,18,213,137,35,219,65,162,81,254,123,55,38,41,9,42,109,164,170,135,74,221,131,237,93,207,123,51,59,111,222,170,56,237,158,23,84,140,139,91,106,26,108,235,212,141,206,234,134,70,215,77,29,168,109,71,151,117,192,106,250,13,125,69,215,216,224,140,58,106,238,176,90,82,123,57,109,187,225,224,16,86,12,139,211,167,254,111,49,190,95,21,23,29,205,62,95,196,204,142,161,76,40,19,129,79,165,7,69,38,129,55,76,130,48,190,116,50,58,225,189,204,224,80,87,203,217,252,138,58,188,198,238,177,24,175,138,158,45,19,4,27,173,74,46,128,87,54,19,24,231,193,97,208,160,20,23,73,42,169,3,138,98,61,44,218,240,72,51,236,147,238,129,149,114,209,74,1,168,66,0,229,25,7,239,98,9,22,185,8,74,160,75,214,109,192,219,248,87,224,253,201,101,93,127,93,46,70,150,149,136,129,20,88,205,20,40,70,6,208,145,7,150,74,197,141,202,119,8,108,36,24,15,201,163,133,210,146,134,152,56,7,103,120,14,98,60,106,70,78,218,160,79,30,54,137,226,180,93,84,248,124,247,110,190,15,161,155,62,77,187,231,65,219,97,183,108,71,103,56,15,84,81,124,129,47,14,148,216,39,88,77,94,4,157,20,227,201,123,146,110,223,55,125,167,14,69,125,171,231,164,24,78,138,155,122,217,132,13,163,204,155,243,189,202,251,36,125,200,155,237,78,192,124,50,95,86,213,246,228,28,59,220,5,238,142,235,56,77,83,138,23,243,155,157,110,61,11,219,46,248,201,99,183,94,106,251,19,216,21,206,241,11,53,31,115,3,94,107,255,81,229,109,110,227,142,216,11,87,50,195,19,24,66,151,199,87,11,176,145,35,56,238,124,146,70,138,148,68,143,254,68,137,26,202,90,29,22,118,204,248,108,241,109,223,237,141,115,182,117,109,90,181,46,214,235,225,190,159,140,208,200,172,117,96,80,242,76,88,218,236,44,193,32,104,205,172,199,146,43,102,127,233,39,36,105,68,72,8,40,242,181,148,73,44,187,65,43,224,38,114,105,200,147,211,250,47,250,73,10,231,35,211,4,201,149,57,189,21,10,144,37,15,182,164,152,123,153,132,83,118,20,189,79,140,56,131,164,180,7,174,242,151,46,157,221,248,169,44,35,83,82,48,117,164,159,114,95,151,85,55,168,211,0,183,206,250,111,169,127,219,82,199,76,208,239,44,245,176,254,14,149,180,72,106,0,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("74aca4f2-5300-4e68-bd97-6d89c9d5beb7"),
				ContainerUId = new Guid("469548be-7215-434c-8fda-7e541797fdf9"),
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

		protected virtual void InitializePendingCatchSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("159c71ef-be09-4085-8d00-3c67a436bd4b"),
				ContainerUId = new Guid("d7674af7-e199-4c72-821d-36401cba0d75"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d7674af7-e199-4c72-821d-36401cba0d75"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8f574e5b-7624-4722-90a9-3cf65d30baa8}].[Parameter:{7a51a482-cc66-4157-a765-07dfae9e0f6b}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializePendingChangeDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("9ceb65d0-c08f-4758-80c4-0eb931174b9b"),
				ContainerUId = new Guid("41a9e18e-ba68-4a3e-9b87-c9033b84382e"),
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
				Value = @"c449d832-a4cc-4b01-b9d5-8a12c42a9f89",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2e50cca2-8933-4280-8cbf-18fdb137ab50"),
				ContainerUId = new Guid("41a9e18e-ba68-4a3e-9b87-c9033b84382e"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fa758883-6271-4b3c-bbfa-6cbee86d2b5b"),
				ContainerUId = new Guid("41a9e18e-ba68-4a3e-9b87-c9033b84382e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,85,75,111,218,64,16,254,43,200,231,108,228,197,111,110,17,73,43,46,77,36,80,46,37,135,177,61,11,171,248,165,221,117,90,138,248,239,29,63,160,164,114,27,183,234,35,85,57,128,61,124,251,205,55,207,221,91,73,6,90,191,131,28,173,153,181,66,165,64,151,194,92,190,145,153,65,245,86,149,117,101,93,88,26,149,132,76,126,194,180,179,223,164,210,92,131,1,58,178,95,127,97,88,91,179,245,48,199,218,186,88,91,210,96,174,9,67,71,56,66,224,196,129,96,97,20,199,204,5,238,179,216,21,14,227,182,112,252,128,11,143,139,105,135,252,22,249,188,204,43,80,216,249,104,233,69,251,184,218,85,13,148,147,33,105,33,82,151,69,111,116,26,17,250,166,128,56,195,148,222,141,170,145,76,70,201,156,162,193,149,204,241,14,20,249,106,120,202,198,68,32,1,153,110,80,25,10,115,243,177,82,168,181,44,139,151,196,101,117,94,156,163,137,0,79,175,189,28,187,213,216,32,239,192,108,91,138,5,201,58,180,42,175,54,27,133,27,48,242,233,92,196,35,238,90,220,184,252,209,129,148,170,116,15,89,141,103,62,159,71,50,135,202,116,1,117,238,9,160,228,102,59,58,214,83,198,94,10,119,74,198,234,8,30,201,57,24,195,212,39,227,83,99,232,88,142,143,107,235,253,66,223,126,40,80,45,147,45,230,208,101,237,225,146,172,95,25,78,252,179,61,96,224,192,52,226,204,115,232,203,117,162,144,65,26,112,150,248,220,142,120,156,6,161,192,195,67,167,67,234,42,131,221,253,201,221,188,86,10,11,51,49,160,31,39,139,235,22,212,164,144,254,194,192,247,17,83,143,121,182,75,5,10,93,151,133,110,76,94,92,17,113,15,189,16,32,161,82,211,167,33,142,132,240,67,145,50,36,119,204,77,121,196,226,212,225,44,112,108,238,132,190,15,60,116,255,199,105,88,26,48,181,166,61,82,72,189,29,55,24,227,82,57,208,84,124,250,221,201,232,165,116,63,19,169,39,66,22,144,253,11,211,210,6,118,28,145,54,93,125,215,101,229,70,38,144,221,86,168,160,143,211,30,110,137,103,189,212,12,159,42,75,211,141,212,73,206,85,66,21,145,102,215,106,56,86,195,134,8,252,36,20,204,230,62,48,215,118,144,197,40,98,22,32,120,158,15,2,195,176,89,120,116,195,52,170,151,101,173,146,190,135,117,119,181,252,212,149,241,23,90,255,71,118,251,96,191,140,169,255,107,217,131,191,119,197,189,210,234,13,236,162,95,86,200,63,62,162,7,235,240,25,90,113,110,252,249,9,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95810b4e-5292-4018-a8df-b266bc723708"),
				ContainerUId = new Guid("41a9e18e-ba68-4a3e-9b87-c9033b84382e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,83,77,79,27,49,16,253,43,209,194,49,19,249,107,215,118,110,168,92,144,160,66,133,114,33,28,198,246,184,172,186,201,166,251,129,68,163,252,247,58,75,2,9,42,45,82,213,67,165,250,176,43,123,231,189,153,125,207,111,149,29,119,143,75,202,166,217,53,53,13,182,117,236,38,31,234,134,38,151,77,237,169,109,39,231,181,199,170,252,142,174,162,75,108,112,78,29,53,55,88,245,212,158,151,109,55,30,29,194,178,113,118,252,48,124,205,166,183,171,236,172,163,249,231,179,144,216,137,27,66,227,57,20,132,26,20,247,57,24,227,8,100,238,131,151,86,16,87,34,129,125,93,245,243,197,5,117,120,137,221,125,54,93,101,3,91,34,240,38,24,21,173,7,167,140,3,165,173,3,139,190,0,165,184,136,82,201,194,163,200,214,227,172,245,247,52,199,161,233,30,88,41,27,140,20,128,202,123,80,142,113,112,54,164,17,144,11,175,4,218,104,236,6,188,173,127,1,222,30,157,215,245,215,126,57,49,44,71,244,164,192,20,76,129,98,164,1,45,57,96,49,87,92,171,220,74,207,38,202,5,231,140,137,144,27,42,32,68,206,193,106,158,138,24,15,5,35,43,141,47,142,238,54,141,66,217,46,43,124,188,121,179,223,137,239,202,135,178,123,28,181,29,118,125,155,196,157,47,171,164,125,120,194,47,15,172,216,103,88,205,158,28,157,101,211,217,91,158,110,223,87,131,84,135,174,190,54,116,150,141,103,217,85,221,55,126,195,40,211,230,116,111,244,161,201,80,242,106,187,115,48,157,44,250,170,218,158,156,98,135,187,194,221,113,29,202,88,82,56,91,92,237,140,27,88,216,118,193,79,30,187,245,52,219,159,192,46,112,129,95,168,249,152,4,120,153,253,121,202,235,36,227,142,216,9,155,51,205,35,104,66,11,138,10,1,38,112,4,203,173,139,82,75,17,163,24,208,159,40,82,67,11,79,135,131,189,231,254,108,241,237,160,246,38,58,219,185,54,82,173,179,245,122,188,31,40,21,180,211,20,11,16,49,113,41,76,215,204,153,68,205,21,17,35,193,185,200,221,47,3,133,36,181,240,17,1,69,250,45,165,35,75,113,40,18,129,14,92,106,114,100,139,226,47,6,74,10,235,2,43,8,162,205,83,123,35,20,32,139,14,76,78,33,105,25,133,85,102,66,82,146,204,173,1,206,164,4,21,184,1,35,184,128,92,42,180,185,215,134,52,127,103,160,146,174,125,213,141,234,56,194,109,180,38,39,33,148,93,89,47,176,26,149,139,88,55,115,220,236,70,13,125,235,203,230,127,210,254,209,164,189,231,98,253,46,105,119,235,31,155,85,63,149,24,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5f57cb97-288f-4d71-a2c4-4b5e5dddee19"),
				ContainerUId = new Guid("41a9e18e-ba68-4a3e-9b87-c9033b84382e"),
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

		protected virtual void InitializeEscalationCatchSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cc1f93c0-6974-4f8b-b1e8-6a819c4b21e9"),
				ContainerUId = new Guid("9465eae5-e8e5-47ca-be99-632bc3fcb44c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9465eae5-e8e5-47ca-be99-632bc3fcb44c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8f574e5b-7624-4722-90a9-3cf65d30baa8}].[Parameter:{7a51a482-cc66-4157-a765-07dfae9e0f6b}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeEscalationChangeDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("da080b93-b78a-437a-adbc-9f4eee898cc5"),
				ContainerUId = new Guid("ad170079-791f-4bd7-98e0-472fdd5812f3"),
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
				Value = @"c449d832-a4cc-4b01-b9d5-8a12c42a9f89",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a94e00f8-50cc-4b2b-9d7e-3c846c8fe91d"),
				ContainerUId = new Guid("ad170079-791f-4bd7-98e0-472fdd5812f3"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b03d7915-a2be-4918-8d0b-ca7e158f79e6"),
				ContainerUId = new Guid("ad170079-791f-4bd7-98e0-472fdd5812f3"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,85,75,111,218,64,16,254,43,200,231,108,228,247,218,220,34,146,86,92,154,72,160,92,234,28,198,246,44,172,226,151,118,215,105,41,226,191,119,108,3,37,21,109,220,170,143,84,229,0,246,199,183,51,223,60,119,107,101,5,104,253,14,74,180,166,214,18,149,2,93,11,115,249,70,22,6,213,91,85,183,141,117,97,105,84,18,10,249,9,243,1,191,201,165,185,6,3,116,100,155,124,177,144,88,211,228,188,141,196,186,72,44,105,176,212,196,161,35,156,3,247,68,20,178,40,78,99,230,219,65,192,32,23,41,203,210,60,230,110,106,135,14,231,3,243,91,198,103,117,217,128,194,193,71,111,94,244,143,203,77,211,81,29,2,178,158,34,117,93,237,65,175,19,161,111,42,72,11,204,233,221,168,22,9,50,74,150,20,13,46,101,137,119,160,200,87,103,167,238,32,34,9,40,116,199,42,80,152,155,143,141,66,173,101,93,189,36,174,104,203,234,148,77,6,240,248,186,151,99,247,26,59,230,29,152,117,111,98,78,178,118,189,202,171,213,74,225,10,140,124,58,21,241,136,155,158,55,46,127,116,32,167,42,221,67,209,226,137,207,231,145,204,160,49,67,64,131,123,34,40,185,90,143,142,245,152,177,151,194,117,9,108,14,228,145,54,207,198,224,134,4,62,117,192,96,229,240,152,88,239,231,250,246,67,133,106,145,173,177,132,33,107,15,151,132,126,5,28,237,79,183,128,220,3,55,118,88,224,209,151,239,197,17,101,146,59,44,11,29,59,118,210,156,71,2,119,15,131,14,169,155,2,54,247,71,119,179,86,41,172,204,196,128,126,156,204,175,123,82,151,66,250,43,69,17,57,57,79,153,16,33,103,62,120,46,3,63,118,153,27,162,235,6,81,156,123,34,166,82,211,167,107,130,144,251,16,251,25,11,99,238,19,57,245,88,42,220,148,133,129,15,142,8,60,223,137,240,127,156,134,133,1,211,106,218,35,149,212,235,113,131,49,46,149,103,154,202,113,191,59,25,123,41,195,207,68,234,137,144,21,20,255,194,180,244,129,29,70,164,79,215,190,235,138,122,37,51,40,110,27,84,176,143,211,62,223,18,207,122,169,27,62,85,215,102,24,169,163,156,171,140,42,34,205,166,215,112,168,70,20,114,170,5,122,12,56,45,39,223,183,109,6,89,148,51,39,203,93,238,113,223,179,49,160,186,210,13,211,169,94,212,173,202,246,61,172,135,171,229,167,174,140,191,208,250,63,178,219,207,246,203,152,250,191,150,61,248,123,87,220,43,173,222,153,93,244,203,10,249,199,71,116,103,237,62,3,173,8,87,151,249,9,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ecc66875-1982-4fd7-99ab-6d047904b215"),
				ContainerUId = new Guid("ad170079-791f-4bd7-98e0-472fdd5812f3"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,77,111,19,49,16,253,43,209,210,99,38,242,215,122,237,220,16,229,80,169,69,21,45,189,52,61,140,237,49,93,177,201,134,253,168,84,162,252,119,156,77,66,147,138,66,37,196,1,9,31,118,101,123,222,204,243,27,63,175,178,147,238,113,73,217,52,187,166,166,193,182,142,221,228,93,221,208,228,178,169,61,181,237,228,188,246,88,149,223,208,85,116,137,13,206,169,163,230,6,171,158,218,243,178,237,198,163,99,88,54,206,78,30,134,221,108,122,187,202,206,58,154,127,58,11,41,187,55,82,120,100,30,10,167,35,40,105,61,24,174,243,52,149,220,56,229,131,212,54,129,125,93,245,243,197,5,117,120,137,221,125,54,93,101,67,182,33,65,48,42,38,152,83,198,129,42,172,3,139,94,131,82,92,68,169,164,246,40,178,245,56,107,253,61,205,113,40,122,0,86,202,134,196,0,80,121,15,202,49,14,206,134,28,12,114,225,149,64,27,141,221,128,119,241,79,192,219,55,231,117,253,165,95,78,12,203,17,61,41,48,154,41,80,140,10,64,75,14,88,204,21,47,84,110,165,103,19,229,130,115,198,68,200,13,105,8,145,115,176,5,79,65,140,7,205,200,74,227,245,155,187,77,161,80,182,203,10,31,111,94,172,247,214,119,229,67,217,61,142,218,14,187,190,77,226,206,151,85,210,62,108,241,203,163,86,28,102,88,205,182,29,157,101,211,217,75,61,221,253,175,6,169,142,187,250,188,161,179,108,60,203,174,234,190,241,155,140,50,77,78,15,168,15,69,134,144,103,211,125,7,211,202,162,175,170,221,202,41,118,184,15,220,47,215,161,140,37,133,179,197,213,190,113,67,22,182,27,240,147,207,126,108,185,253,9,236,2,23,248,153,154,15,73,128,39,238,63,88,94,39,25,247,137,157,176,57,43,120,132,130,208,130,34,45,192,4,142,96,185,117,81,22,82,196,40,6,244,71,138,212,208,194,211,49,177,215,220,159,29,190,29,212,222,88,103,199,107,35,213,58,91,175,199,135,134,82,138,229,54,58,177,189,200,74,219,196,69,8,15,44,207,77,160,24,165,101,225,151,134,66,146,133,240,17,1,69,58,150,42,34,75,118,208,10,120,17,184,44,200,145,213,250,47,26,74,10,235,2,211,4,209,230,169,188,17,10,144,69,7,38,167,144,180,140,194,42,51,73,158,206,211,65,24,232,66,38,213,49,237,91,45,52,48,66,142,121,145,24,88,245,74,67,37,93,251,170,27,213,113,132,59,107,77,222,183,233,105,195,174,172,23,163,134,190,246,101,243,223,93,255,168,187,94,115,153,126,231,174,187,245,119,149,238,193,24,12,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("75e7bd13-6a7e-4f4d-9b14-947dc9d4dbb1"),
				ContainerUId = new Guid("ad170079-791f-4bd7-98e0-472fdd5812f3"),
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

		protected virtual void InitializeReadCaseCountDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6e10b476-de64-4b9b-8536-f53f0ce813e9"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,77,111,219,56,16,253,43,134,206,101,64,73,164,62,124,43,178,238,34,151,54,216,4,189,212,57,140,200,161,35,84,150,4,138,206,110,214,240,127,223,161,100,59,78,19,187,74,209,96,11,164,39,203,163,225,211,124,188,55,156,117,160,42,232,186,143,176,196,96,26,92,163,181,208,53,198,157,125,40,43,135,246,79,219,172,218,224,93,208,161,45,161,42,255,69,61,216,103,186,116,127,128,3,58,178,158,63,32,204,131,233,252,121,140,121,240,110,30,148,14,151,29,249,208,17,145,25,147,96,36,88,42,226,136,9,201,21,3,13,138,165,104,100,196,77,4,25,152,193,243,24,248,69,61,192,247,200,166,127,188,190,111,189,151,32,131,106,150,45,216,178,107,234,173,49,246,223,239,102,53,20,21,106,250,239,236,10,201,228,108,185,164,68,240,186,92,226,37,88,250,140,199,105,188,137,156,12,84,157,247,170,208,184,217,63,173,197,174,43,155,250,116,92,231,77,181,90,214,135,222,4,128,251,191,219,112,120,31,163,247,188,4,119,219,67,156,67,71,111,54,125,156,239,23,11,139,11,112,229,221,97,24,95,241,190,247,28,87,60,58,160,169,69,159,161,90,225,246,171,33,127,146,204,57,180,110,200,105,23,1,185,88,52,104,177,86,120,165,110,113,9,251,44,31,28,202,197,237,1,136,111,234,151,19,53,217,87,246,123,101,137,200,216,238,156,79,215,249,242,193,237,153,76,163,132,140,119,222,48,160,236,30,231,193,151,139,238,211,223,53,218,33,181,161,182,55,103,100,253,198,48,171,112,137,181,155,174,51,35,83,129,178,96,105,66,37,23,105,20,177,156,67,206,98,101,18,169,99,94,0,100,27,58,176,15,104,186,78,65,134,32,178,136,41,149,36,76,132,50,101,144,38,146,241,84,27,192,28,185,73,10,127,100,86,187,210,221,15,140,153,174,1,57,10,169,128,41,145,75,38,12,210,169,56,215,44,134,34,141,210,12,195,36,76,55,55,67,186,101,215,86,112,255,121,159,213,95,8,122,162,168,61,19,95,9,82,158,237,220,196,235,109,210,152,9,213,120,85,185,178,94,76,136,114,21,42,223,240,179,11,221,35,249,31,58,111,162,72,166,89,92,48,224,146,40,21,39,49,43,66,76,88,14,5,134,40,83,13,57,81,106,179,217,220,120,130,166,69,146,21,66,43,150,112,12,89,95,156,12,243,144,1,70,25,167,114,128,130,248,116,247,78,140,6,76,120,172,184,7,207,208,48,193,61,187,165,84,76,199,20,67,154,139,88,134,234,141,141,134,43,7,110,213,141,27,14,227,202,247,242,225,176,139,225,196,120,120,79,204,186,35,66,31,186,254,234,131,162,207,250,96,80,108,245,16,231,66,139,34,19,76,102,164,2,109,194,144,229,105,88,48,206,67,77,164,207,227,76,37,61,222,254,131,23,245,164,181,205,194,135,217,191,120,152,56,163,177,158,168,250,17,230,78,124,73,161,163,60,215,5,147,154,35,19,58,85,44,203,105,86,68,40,37,42,174,12,202,228,183,62,142,234,99,92,249,126,235,227,59,250,200,94,170,143,143,141,155,116,14,172,67,253,173,62,198,98,61,209,199,35,204,94,31,158,1,85,179,40,21,84,159,90,180,176,109,79,248,60,133,31,113,223,111,12,182,105,220,145,166,245,17,236,72,52,238,2,60,22,13,255,201,209,112,218,16,178,88,132,76,69,153,102,66,196,138,229,196,113,166,133,49,68,235,72,208,22,66,209,208,30,239,187,123,213,172,172,194,97,2,116,195,2,255,67,139,249,255,48,56,94,182,70,31,209,214,24,173,188,177,117,242,149,151,192,31,90,238,126,81,122,29,94,53,63,145,96,143,198,236,216,149,225,197,11,193,219,174,233,168,107,230,181,47,145,87,189,19,54,193,230,63,21,145,70,10,208,17,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e57b1d74-578d-476a-b807-98eadc71a555"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f86d057a-db93-4c1d-a3b0-3470068d9d08"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc0df9c8-409b-444e-a12d-e048877ca940"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d119c974-e8fb-423b-b661-fc9d3c080ea7"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0676e49c-6b30-489d-83c5-ab83ad3e6093"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c9b59582-9d62-471e-8bb4-aa7df0658127"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("e0685b0c-239b-47ce-8492-ff99b21d13a5"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("399de72a-ef6d-4a47-b355-3086cf7cc0cd"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("b6b9ddf5-da1a-4be7-80c2-86cd883ed495"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("518f26fc-42e0-4dfd-bded-1ca5061316e6"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c56a1f76-9f86-47e6-b3b7-33ab372ebaef"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ace9d311-33b7-4a4f-8db5-5154787974c9"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("20e89035-f4c1-4152-b109-4eedc803888e"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("b1feaf4d-a320-4d9a-a665-cddda8e8bb59"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d49a261c-b0a1-4251-8c54-c4923cc2b11f"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bce2b23c-43d7-4ee3-99a6-d42915037782"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("26fee922-21a7-4cbd-aaa5-6625b9d9ba29"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f19d01c9-602a-413a-8523-48e2ede551bb"),
				ContainerUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeCompleteTasksChangeDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("99f2dd86-4eab-47c5-8ba2-01d496b9a3fb"),
				ContainerUId = new Guid("3fceae6f-a629-4ceb-92b4-3aed7434c92b"),
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
				Value = @"c449d832-a4cc-4b01-b9d5-8a12c42a9f89",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6a09dbe4-c830-4973-9ba2-bee31e9f77f2"),
				ContainerUId = new Guid("3fceae6f-a629-4ceb-92b4-3aed7434c92b"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c8a7ec42-256a-40db-af79-d1e36121c71c"),
				ContainerUId = new Guid("3fceae6f-a629-4ceb-92b4-3aed7434c92b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,86,75,115,219,54,16,254,43,26,158,3,15,248,2,8,221,50,174,218,241,165,241,212,158,92,34,31,150,192,66,230,148,34,53,32,228,86,213,232,191,119,65,234,149,90,86,20,79,30,205,228,34,146,171,197,98,31,223,183,187,235,72,215,208,117,191,195,28,163,113,116,143,206,65,215,90,127,245,107,85,123,116,191,185,118,185,136,222,68,29,186,10,234,234,31,52,131,124,98,42,255,11,120,160,35,235,233,193,194,52,26,79,79,219,152,70,111,166,81,229,113,222,145,14,29,17,146,243,20,139,152,9,197,145,101,60,45,152,50,160,153,150,89,145,115,1,89,174,237,160,249,146,241,155,102,48,223,91,182,253,235,253,106,17,180,50,18,232,118,190,0,87,117,109,179,21,166,225,254,110,210,64,89,163,161,111,239,150,72,34,239,170,57,5,130,247,213,28,111,193,209,53,193,78,27,68,164,100,161,238,130,86,141,214,79,254,94,56,236,186,170,109,206,251,117,221,214,203,121,115,172,77,6,112,255,185,117,135,247,62,6,205,91,240,143,189,137,107,232,232,159,77,239,231,219,217,204,225,12,124,245,116,236,198,159,184,234,53,47,75,30,29,48,84,162,247,80,47,113,123,107,204,159,5,115,13,11,63,196,180,243,128,84,28,90,116,216,104,188,211,143,56,135,125,148,7,133,106,246,120,100,36,20,245,195,153,156,236,51,251,169,180,36,36,92,236,148,207,231,249,246,160,118,34,210,68,144,240,41,8,6,43,187,215,105,244,225,166,123,247,87,131,110,8,109,200,237,195,21,73,255,35,152,212,56,199,198,143,215,133,205,101,134,121,201,164,72,50,150,201,36,97,138,131,98,169,182,34,55,41,47,1,138,13,29,216,59,52,94,75,200,99,200,138,132,105,45,4,203,226,92,50,144,34,103,92,26,11,168,144,91,81,134,35,147,198,87,126,53,32,102,188,6,228,72,165,3,166,51,149,179,204,34,157,74,149,97,41,148,50,145,5,198,34,150,155,135,33,220,170,91,212,176,122,191,143,234,15,4,51,210,84,158,81,200,4,49,207,117,126,20,248,54,106,237,136,114,188,172,125,213,204,70,4,185,26,117,40,248,213,141,233,45,133,7,157,47,51,91,112,165,5,75,172,42,89,150,201,152,41,45,45,75,19,76,141,142,99,128,84,19,56,55,155,135,0,80,195,233,219,74,100,177,9,218,225,77,25,43,25,138,194,24,110,149,41,148,248,201,216,251,150,178,250,20,138,73,119,207,90,183,186,140,201,151,37,242,53,76,222,121,113,134,205,207,93,254,17,152,221,71,126,196,236,45,128,109,30,235,76,100,41,203,11,20,204,216,152,0,44,227,146,113,30,27,193,81,165,133,30,50,121,184,176,29,153,182,23,29,154,195,197,86,158,17,112,107,109,199,16,203,69,145,148,88,50,203,21,117,0,149,24,6,42,167,159,68,36,66,165,154,67,146,127,10,137,129,3,248,18,77,226,31,147,38,119,30,252,178,163,254,212,84,221,227,101,28,185,44,149,167,144,146,156,229,200,214,149,225,49,170,186,145,173,26,168,79,145,224,66,184,126,59,10,36,71,160,237,211,69,176,11,169,172,219,89,165,161,126,183,64,7,219,56,249,105,72,124,132,165,48,43,93,219,250,23,250,67,239,195,174,26,156,23,152,202,52,103,52,194,12,203,82,160,221,3,139,156,201,184,72,227,210,38,74,2,80,93,105,103,12,94,223,181,75,167,183,24,238,134,101,241,85,75,224,119,152,16,159,183,178,189,208,54,47,193,192,79,182,186,124,229,133,227,127,138,148,211,235,193,23,68,205,71,99,241,210,65,246,217,195,234,59,140,160,87,78,149,147,45,252,85,137,253,214,205,118,19,109,254,5,85,154,181,8,149,15,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cbba51f0-1bbc-4cab-9bfd-7c94e372df30"),
				ContainerUId = new Guid("3fceae6f-a629-4ceb-92b4-3aed7434c92b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,83,203,110,219,48,16,252,21,131,201,209,107,240,37,137,244,173,104,46,1,146,34,168,211,94,226,28,150,228,178,17,42,75,134,30,1,82,195,255,94,90,177,155,56,104,218,0,69,15,5,202,131,4,82,59,179,195,89,205,134,157,246,15,107,98,115,118,77,109,139,93,19,251,217,251,166,165,217,85,219,120,234,186,217,69,227,177,42,191,161,171,232,10,91,92,81,79,237,103,172,6,234,46,202,174,159,78,142,97,108,202,78,239,199,175,108,126,179,97,231,61,173,62,157,135,196,78,153,17,162,240,30,76,238,13,104,161,28,32,82,0,12,49,16,113,158,57,233,19,216,55,213,176,170,47,169,199,43,236,239,216,124,195,70,182,68,224,77,48,58,90,15,78,27,7,186,176,14,44,250,28,180,22,50,42,173,114,143,146,109,167,172,243,119,180,194,177,233,51,176,214,54,24,37,1,117,146,160,29,23,224,108,200,192,160,144,94,75,180,209,216,29,120,95,255,4,188,57,185,104,154,175,195,122,102,120,134,232,73,39,253,92,131,230,84,0,90,114,192,99,166,69,161,51,171,60,159,105,23,156,51,38,66,102,40,135,16,133,0,91,136,84,196,69,200,57,89,101,124,126,114,187,107,20,202,110,93,225,195,231,87,251,189,243,125,121,95,246,15,147,174,199,126,232,146,185,171,117,149,188,15,143,248,245,209,40,158,51,108,150,143,19,93,178,249,242,181,153,238,223,139,209,170,227,169,190,28,232,146,77,151,108,209,12,173,223,49,170,180,57,123,38,125,108,50,150,188,216,30,38,152,78,234,161,170,246,39,103,216,227,161,240,112,220,132,50,150,20,206,235,197,97,112,35,11,223,47,248,201,227,176,30,181,253,9,236,18,107,252,66,237,135,100,192,147,246,31,42,175,147,141,7,98,39,109,198,11,17,161,32,180,160,41,151,96,130,64,176,194,186,168,10,37,99,148,35,250,35,69,106,169,246,116,44,236,45,255,207,30,223,141,110,239,162,179,215,181,179,106,203,182,219,233,81,160,172,44,10,101,16,178,232,146,32,163,119,209,42,2,136,96,163,34,165,41,137,250,101,160,48,85,72,31,17,80,166,107,233,34,242,20,135,92,131,40,130,80,5,57,178,121,254,23,3,165,164,117,129,231,4,209,102,169,189,145,26,144,71,7,38,163,144,188,140,210,106,51,163,168,115,45,178,116,181,176,139,186,242,41,244,30,17,84,78,25,230,121,38,130,143,111,12,84,242,117,168,250,73,19,39,184,143,214,108,145,188,233,203,166,158,196,102,168,255,7,235,223,12,214,91,254,163,223,5,235,118,251,29,75,12,150,132,7,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e94ca64d-9014-4261-b361-6537c253d08e"),
				ContainerUId = new Guid("3fceae6f-a629-4ceb-92b4-3aed7434c92b"),
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

		protected virtual void InitializeCancelTasksChangeDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("e21b52d3-db26-4e4e-8254-fcc14a5f7386"),
				ContainerUId = new Guid("484f3905-6b35-4c22-a574-50b567b9a99b"),
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
				Value = @"c449d832-a4cc-4b01-b9d5-8a12c42a9f89",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("59deaa49-2d60-48b6-81d5-cecd7aaaf43b"),
				ContainerUId = new Guid("484f3905-6b35-4c22-a574-50b567b9a99b"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c590c5de-cb61-45ff-a24d-d8ee718c86e7"),
				ContainerUId = new Guid("484f3905-6b35-4c22-a574-50b567b9a99b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,86,75,115,219,54,16,254,43,26,158,3,15,64,2,124,232,150,113,213,142,47,141,167,246,228,18,249,176,0,22,50,167,20,169,1,41,183,170,70,255,189,11,82,175,212,178,162,120,242,104,38,39,73,171,197,98,247,219,239,219,197,58,50,21,180,237,239,48,199,104,28,221,163,247,208,54,174,187,250,181,172,58,244,191,249,102,185,136,222,68,45,250,18,170,242,31,180,131,125,98,203,238,23,232,128,142,172,167,135,8,211,104,60,61,29,99,26,189,153,70,101,135,243,150,124,232,136,19,218,89,149,199,44,214,210,49,153,20,5,211,166,72,152,142,179,220,230,198,36,78,137,193,243,165,224,55,245,16,190,143,236,250,175,247,171,69,240,146,100,48,205,124,1,190,108,155,122,107,76,194,253,237,164,6,93,161,165,223,157,95,34,153,58,95,206,169,16,188,47,231,120,11,158,174,9,113,154,96,34,39,7,85,27,188,42,116,221,228,239,133,199,182,45,155,250,124,94,215,77,181,156,215,199,222,20,0,247,63,183,233,240,62,199,224,121,11,221,99,31,226,26,90,250,103,211,231,249,118,54,243,56,131,174,124,58,78,227,79,92,245,158,151,129,71,7,44,181,232,61,84,75,220,222,42,248,179,98,174,97,209,13,53,237,50,32,23,143,14,61,214,6,239,204,35,206,97,95,229,193,161,156,61,30,5,9,77,253,112,6,147,61,178,159,130,37,38,227,98,231,124,30,231,219,131,219,137,74,227,148,140,79,193,48,68,217,125,157,70,31,110,218,119,127,213,232,135,210,6,108,31,174,200,250,31,195,164,194,57,214,221,120,157,59,149,73,84,154,101,105,44,153,204,226,152,21,28,10,150,24,151,42,155,112,13,144,111,232,192,62,161,241,58,3,37,64,82,131,140,73,83,38,133,202,24,100,169,98,60,179,14,176,64,238,82,29,142,76,234,174,236,86,3,99,198,107,64,142,82,25,96,70,22,138,73,135,116,42,41,44,75,64,103,212,89,20,169,200,54,15,67,185,101,187,168,96,245,126,95,213,31,8,118,100,168,61,163,128,4,41,207,183,221,40,232,109,212,184,17,97,188,172,186,178,158,141,136,114,21,154,208,240,171,27,219,71,10,31,116,30,173,210,32,84,204,92,14,49,21,73,185,67,150,40,150,196,60,167,244,243,56,46,52,145,115,179,121,8,4,149,25,7,37,141,96,133,206,2,1,93,194,64,99,206,50,237,242,28,37,23,188,215,216,207,164,222,183,132,234,83,104,38,221,61,107,252,234,50,37,95,6,228,107,148,188,203,226,140,154,159,167,252,35,40,187,175,252,72,217,91,2,211,200,51,50,149,9,83,57,166,204,58,65,152,102,66,51,206,133,77,57,22,73,110,210,62,222,225,194,102,100,155,222,116,24,14,23,71,121,38,192,109,180,189,66,148,84,133,53,138,9,39,144,73,99,115,86,56,65,179,0,51,157,36,121,134,86,240,79,49,49,104,0,95,146,137,248,49,101,114,215,65,183,108,105,62,213,101,251,120,161,70,46,130,242,20,83,226,179,26,217,166,50,124,140,202,118,228,202,26,170,83,34,184,144,174,223,78,2,241,17,105,123,184,136,118,1,202,170,153,149,6,170,119,11,244,176,173,147,159,166,196,71,92,10,187,210,55,77,247,194,124,232,115,216,117,35,23,146,199,49,8,6,128,52,177,132,227,76,103,41,208,74,116,90,104,107,149,224,57,245,149,222,140,33,235,187,102,233,205,150,195,237,240,88,124,213,35,240,59,108,136,207,123,178,189,48,54,47,225,192,79,246,116,249,202,15,142,255,41,83,78,63,15,190,32,107,62,90,139,151,46,178,207,94,86,223,97,5,189,114,171,156,28,225,175,2,246,91,15,219,77,180,249,23,138,153,2,35,149,15,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6c0bc164-4425-4e9d-abaf-b243259091c3"),
				ContainerUId = new Guid("484f3905-6b35-4c22-a574-50b567b9a99b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,207,107,219,48,20,254,87,138,218,99,94,144,108,217,150,114,27,237,37,144,142,176,116,189,52,61,60,73,79,171,153,19,7,91,46,100,33,255,251,20,215,94,147,178,194,96,58,200,232,233,125,63,120,159,124,96,55,97,191,35,54,99,15,212,52,216,214,62,76,111,235,134,166,203,166,182,212,182,211,69,109,177,42,127,161,169,104,137,13,110,40,80,243,136,85,71,237,162,108,195,228,234,18,198,38,236,230,181,191,101,179,167,3,155,7,218,124,159,187,200,110,40,79,149,17,9,136,220,33,72,174,20,152,44,45,32,205,45,71,133,162,176,220,71,176,173,171,110,179,189,167,128,75,12,47,108,118,96,61,91,36,176,202,41,233,181,5,35,149,1,89,104,3,26,109,14,82,138,196,167,50,242,96,194,142,19,214,218,23,218,96,47,122,6,150,82,59,149,38,128,210,90,144,134,11,48,218,101,16,133,19,43,19,212,94,233,19,120,232,127,7,62,93,47,234,250,103,183,155,42,158,33,90,146,160,114,46,163,127,42,0,53,25,224,62,147,162,144,153,78,45,159,38,92,88,111,80,65,166,40,7,231,133,0,93,136,216,196,133,203,57,233,84,217,252,250,249,36,228,202,118,87,225,254,241,83,189,47,54,148,175,101,216,95,181,1,67,215,78,111,113,107,169,34,247,6,223,93,36,113,78,112,88,191,5,186,102,179,245,103,145,14,223,85,63,169,203,80,63,230,185,102,147,53,91,213,93,99,79,140,105,60,220,157,57,239,69,250,150,15,199,49,192,88,217,118,85,53,84,238,48,224,216,56,150,107,87,250,146,220,124,187,26,115,235,89,248,176,224,47,219,184,222,188,253,15,236,30,183,248,131,154,175,113,0,239,222,255,184,124,136,99,28,137,77,162,51,94,8,15,5,161,6,73,121,2,202,9,4,45,180,241,105,145,38,222,39,61,250,27,121,106,40,102,117,105,236,95,158,207,128,111,251,105,159,254,156,193,215,105,84,71,118,60,62,31,127,3,132,44,58,181,173,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("66258bdb-9a28-4293-a3a8-1ae305614e52"),
				ContainerUId = new Guid("484f3905-6b35-4c22-a574-50b567b9a99b"),
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

		protected virtual void InitializeRescheduledCatchSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a46b9b07-561d-402a-bfce-8c12452a18d2"),
				ContainerUId = new Guid("e615c390-d90a-4a82-a7af-2fd1be051086"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e615c390-d90a-4a82-a7af-2fd1be051086"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{ae73a291-5391-4398-ad71-c61091bd78fe}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeAddRescheduledTaskUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("92b7b385-b361-4426-aa17-35a191aa76c8"),
				ContainerUId = new Guid("68ef5315-41e9-4b68-96d5-fdca74d37520"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b7e1b44d-217e-4e2f-a90c-17a5ebf74c94"),
				ContainerUId = new Guid("68ef5315-41e9-4b68-96d5-fdca74d37520"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d5038619-45b6-440d-9cef-0b9bb2381b70"),
				ContainerUId = new Guid("68ef5315-41e9-4b68-96d5-fdca74d37520"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("c587e107-d285-4719-941f-a1aa76cdf30e"),
				ContainerUId = new Guid("68ef5315-41e9-4b68-96d5-fdca74d37520"),
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
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2a49baff-f87a-4844-8d6e-503b3b93151b"),
				ContainerUId = new Guid("68ef5315-41e9-4b68-96d5-fdca74d37520"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,151,75,111,27,71,12,128,255,138,176,206,173,30,97,222,15,221,130,36,5,12,36,105,144,164,185,216,62,112,134,28,71,168,188,107,236,174,82,184,134,254,123,185,178,157,216,65,163,56,109,141,38,168,117,144,176,163,33,135,75,242,35,135,23,205,163,241,252,140,154,69,243,150,250,30,134,174,142,243,39,93,79,243,87,125,87,104,24,230,207,187,2,171,229,31,144,87,244,10,122,56,165,145,250,119,176,90,211,240,124,57,140,251,179,219,98,205,126,243,232,195,246,223,102,113,120,209,28,140,116,250,235,1,178,118,27,129,84,46,94,84,71,32,172,11,81,36,68,43,100,80,53,185,88,162,81,150,133,75,183,90,159,182,47,104,132,87,48,190,111,22,23,205,86,27,43,40,81,217,10,65,9,146,42,11,107,180,19,80,34,138,136,22,116,50,132,202,196,102,179,223,12,229,61,157,194,246,208,27,194,214,38,140,70,11,176,165,8,155,165,18,57,161,19,17,148,46,86,67,170,49,77,194,87,251,63,9,30,238,61,239,186,223,214,103,243,228,21,105,25,189,96,9,62,30,117,16,89,38,39,172,204,138,188,69,95,138,156,87,167,138,245,214,8,23,201,11,172,74,137,20,216,90,41,21,122,73,201,196,226,247,142,167,131,112,57,156,173,224,252,221,23,207,123,92,198,229,135,229,120,62,43,48,210,73,215,159,207,223,118,51,236,46,165,207,110,5,226,166,252,197,209,101,60,143,154,197,209,151,34,122,245,251,102,235,168,219,49,253,60,156,71,205,254,81,243,166,91,247,101,210,104,248,225,233,13,195,183,135,108,183,124,246,120,29,63,94,105,215,171,213,213,202,83,24,225,122,227,245,114,135,203,186,36,60,104,223,92,135,109,171,69,94,125,196,95,124,93,127,46,109,251,39,98,47,160,133,19,234,95,178,3,62,217,254,209,202,183,236,198,107,197,89,39,55,101,170,8,4,73,88,242,154,243,78,129,72,42,229,106,130,209,181,234,173,244,107,170,212,83,91,232,182,97,119,201,158,43,249,97,235,237,9,156,43,187,38,87,109,154,205,102,255,38,78,213,107,7,186,104,161,80,34,171,113,78,228,200,72,68,175,201,162,115,174,16,237,196,201,98,169,18,140,18,161,98,96,139,50,8,144,210,10,178,202,100,21,156,177,70,253,251,56,77,249,3,39,109,55,208,12,90,156,245,252,182,171,15,52,91,182,101,137,212,142,179,189,163,230,167,195,189,195,131,225,151,223,91,234,47,125,184,168,176,26,232,120,206,171,159,45,60,91,209,41,75,45,46,98,117,193,146,203,34,120,109,133,13,90,139,36,57,80,166,84,239,208,200,12,16,55,44,240,49,217,23,23,1,156,2,27,181,40,197,123,97,149,11,2,130,119,92,143,176,2,37,146,213,231,73,228,89,59,50,133,79,182,126,100,169,28,11,249,108,133,78,133,171,152,44,28,71,2,126,123,151,107,200,161,88,105,97,115,188,27,241,187,249,224,53,1,50,251,188,9,57,33,231,63,47,251,97,156,45,57,254,179,174,78,50,235,213,184,108,79,102,28,224,21,113,169,232,218,249,203,245,105,166,254,161,64,252,39,5,194,21,48,174,42,201,128,51,12,182,120,78,167,228,65,152,104,16,60,84,40,181,236,42,16,119,54,236,174,5,34,197,28,188,245,40,208,85,174,56,84,185,246,4,43,69,12,32,3,21,84,20,226,238,2,193,217,140,197,6,17,157,230,146,135,146,4,248,10,162,106,86,157,181,100,21,230,62,250,237,247,11,63,144,36,203,129,22,197,78,165,187,18,75,153,132,194,64,14,58,68,82,94,133,175,193,255,119,192,62,192,7,168,127,200,174,175,84,64,222,148,68,212,129,19,134,123,170,136,150,239,132,138,179,78,41,110,209,169,224,55,65,77,21,48,2,39,120,160,80,153,73,176,34,3,231,162,148,37,243,61,56,57,136,106,39,212,85,6,195,16,27,17,18,114,153,10,158,11,22,249,36,146,167,226,124,74,198,166,123,232,250,223,51,212,65,122,45,145,179,133,236,52,151,112,124,69,170,88,166,9,69,215,130,236,85,149,239,3,234,199,195,176,60,105,137,30,208,254,49,209,246,153,140,119,74,196,74,122,74,54,134,28,145,105,138,210,160,245,220,245,209,124,19,218,144,37,183,91,109,132,158,248,182,134,47,16,145,103,71,110,46,49,199,232,162,11,89,239,68,59,87,128,84,184,44,20,227,163,176,86,242,27,153,237,133,36,120,47,43,84,101,239,101,62,254,126,209,246,38,249,106,61,77,253,154,171,101,205,28,45,199,211,82,212,54,250,84,171,180,217,220,7,218,79,186,118,132,50,62,144,253,64,246,68,182,169,149,201,246,133,251,138,159,70,117,172,34,219,24,133,210,198,241,240,111,188,146,187,201,174,89,162,175,220,152,84,224,81,211,2,79,233,160,120,224,7,155,189,53,197,163,252,191,145,157,149,51,82,151,196,115,119,225,131,48,177,71,42,191,20,7,72,166,154,0,43,169,123,105,218,165,116,235,246,129,236,31,147,108,237,48,20,5,89,40,36,201,23,188,9,133,169,77,74,205,131,157,131,160,209,211,215,200,62,222,252,9,161,153,34,109,49,23,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("538e3867-2d16-4738-823f-530a3f2cd5a7"),
				ContainerUId = new Guid("68ef5315-41e9-4b68-96d5-fdca74d37520"),
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
				UId = new Guid("486f548a-8c81-4e60-890d-0be6b972deba"),
				ContainerUId = new Guid("68ef5315-41e9-4b68-96d5-fdca74d37520"),
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

		protected virtual void InitializeOpenResheduledTaskEditPageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var objectSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("f9f0b2ef-b537-4f31-a5bd-bc0b4387a477"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ObjectSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			objectSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(objectSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"c449d832-a4cc-4b01-b9d5-8a12c42a9f89",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(objectSchemaIdParameter);
			var pageSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("73f9197d-3c80-4e5a-a6dd-fd7e5eb882d5"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"PageSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			pageSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(pageSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"6e5551de-a0fa-48af-8d1b-7dc896060a1e",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(pageSchemaIdParameter);
			var editModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a517303e-9785-4d9c-be67-2b59977d0b6c"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"EditMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			editModeParameter.SourceValue = new ProcessSchemaParameterValue(editModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(editModeParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cdfee2f2-2914-43ad-8e30-4e93a8301ea1"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,171,86,82,41,169,44,72,85,178,82,10,73,45,42,74,44,206,79,43,209,115,206,47,74,213,11,40,202,79,78,45,46,214,243,201,79,78,204,201,172,74,76,202,73,13,72,44,74,204,77,45,73,45,10,75,204,41,77,45,246,201,44,46,209,81,64,213,166,164,163,164,82,6,150,85,178,138,142,173,5,0,199,127,71,237,94,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("2d261075-7320-45c5-a0b8-da25a32b1ce0"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{68ef5315-41e9-4b68-96d5-fdca74d37520}].[Parameter:{538e3867-2d16-4738-823f-530a3f2cd5a7}]#]",
				MetaPath = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{68ef5315-41e9-4b68-96d5-fdca74d37520}].[Parameter:{538e3867-2d16-4738-823f-530a3f2cd5a7}]#]",
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var executedModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("975dad01-0f9c-41f9-9dba-6c204620b59d"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ExecutedMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			executedModeParameter.SourceValue = new ProcessSchemaParameterValue(executedModeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executedModeParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c2630eb6-4cab-45a0-a61a-f97018285882"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsMatchConditions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8553b6f1-1c80-4fc3-ae4d-08b5cd7171f8"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var generateDecisionsFromColumnParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6e47e63f-e942-4085-a3bd-6ab9010b12ff"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"GenerateDecisionsFromColumn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			generateDecisionsFromColumnParameter.SourceValue = new ProcessSchemaParameterValue(generateDecisionsFromColumnParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(generateDecisionsFromColumnParameter);
			var decisionalColumnMetaPathParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d0d67c0b-b33d-46f1-a228-5a0a3f8db1a5"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"DecisionalColumnMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			decisionalColumnMetaPathParameter.SourceValue = new ProcessSchemaParameterValue(decisionalColumnMetaPathParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(decisionalColumnMetaPathParameter);
			var resultParameterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("34934901-cc88-496d-874d-c790334668d4"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ResultParameter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			resultParameterParameter.SourceValue = new ProcessSchemaParameterValue(resultParameterParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultParameterParameter);
			var isReexecutionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4fc12d51-aee6-4025-b7b7-9cb916b765c1"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsReexecution",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isReexecutionParameter.SourceValue = new ProcessSchemaParameterValue(isReexecutionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(isReexecutionParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("36fc1749-5e74-486d-9aa2-9997322bd096"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Specify start/end dates in the task",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("a4ce0f56-9fe5-4465-8f2e-2b52e4ea511a"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("8923c12b-3e36-466f-8b47-a61859bf4610"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#SysVariable.CurrentUserContact#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("77d923b9-b162-4dc3-a65a-f662c1683465"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cf9a71fe-d429-4b38-b8e7-dfe32a55ae55"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3e7299c2-13e1-4fb6-9110-6637acbf7fa8"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("92526212-b4e7-4c84-b889-378fb2292a7a"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("de781630-7327-4331-8d12-5d22d92e1737"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("189d2378-a138-4c1f-876e-ca81238f2c0b"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0b7d386f-a98b-4951-b236-c81c9d1971b1"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ShowInScheduler",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showInSchedulerParameter.SourceValue = new ProcessSchemaParameterValue(showInSchedulerParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ebd95a51-ddeb-44d8-bf32-63592a44c539"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("d6fdb102-6caa-49e9-a5b2-1c770ca6e847"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Lead",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("ca853fd2-05a9-469a-a508-4e39f3da9059"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("9329119b-85e9-4b2b-8a37-3b22c75f7a41"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("8d6acd3b-9769-4126-94cb-a2c73f82c650"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Opportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityParameter.SourceValue = new ProcessSchemaParameterValue(opportunityParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("3dec8030-fe45-48ff-9399-e7952212a53c"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("27e6ba69-8288-4933-94c8-3077891add79"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Document",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			documentParameter.SourceValue = new ProcessSchemaParameterValue(documentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(documentParameter);
			var incidentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("29631052-774c-49d8-b31d-f1c8820e0946"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("87e7e4d8-7bcb-4fc9-84c8-670dbb29fd6d"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("a45b4882-0481-4d81-82ad-1c5b52de9081"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivityResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activityResultParameter.SourceValue = new ProcessSchemaParameterValue(activityResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activityResultParameter);
			var currentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cf1b147f-ba96-4412-a061-6dc9d86fe625"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"CurrentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(currentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(currentActivityIdParameter);
			var isActivityCompletedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6ea35da2-f744-4d97-ba95-f3db35c6a221"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var executionContextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6351291c-9331-45a5-b9e7-07dcfb87ca72"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
			var pageTypeUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bc0f1f42-e563-4d5d-a178-dc465ba0dd21"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"PageTypeUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			pageTypeUIdParameter.SourceValue = new ProcessSchemaParameterValue(pageTypeUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"fbe0acdc-cfc0-df11-b00f-001d60e938c6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(pageTypeUIdParameter);
			var activitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a1876452-d45e-49e4-9764-f5701aa6c862"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(activitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activitySchemaUIdParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6d3b9d72-0379-484c-91be-dbd4cfaa6087"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"InformationOnStep",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var orderParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("2eeff63d-d521-490d-a199-1ebc8eab8777"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("f2e5410e-5ad0-434f-b0ff-e54c67b05726"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("0d61e10b-5035-4def-a3ab-2b157dc34402"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("07cc0683-8fb0-412d-84e4-1129fe369a51"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("fb1686c8-d568-46c0-84ce-b39d2c502807"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
			var problemParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230"),
				UId = new Guid("45923a9c-afb5-4081-b2ee-958f0892885b"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("dc430176-a84a-4020-9f66-3796a92959ce"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("fb3da557-5fd3-41cf-bc78-31f1210af7b7"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
			var projectParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				UId = new Guid("c38a9663-79ef-4428-9487-8fdeadfe594e"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
			var activityPriorityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b934f48c-5dea-49b9-bde3-697cb4be5d8b"),
				UId = new Guid("1644ba00-a9b3-4e94-bbc9-b8298693f77f"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(activityPriorityParameter);
			var createActivityParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fadac54b-e261-437e-a97d-de3a06f8d988"),
				ContainerUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"CreateActivity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			createActivityParameter.SourceValue = new ProcessSchemaParameterValue(createActivityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(createActivityParameter);
		}

		protected virtual void InitializeUserQuestionUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var branchingDecisionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("675f0993-7e43-4f73-9a39-40712c295959"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"BranchingDecisions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableParameterValuesListDataValueType")
			};
			branchingDecisionsParameter.SourceValue = new ProcessSchemaParameterValue(branchingDecisionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,149,143,77,75,195,64,16,134,255,138,44,61,102,202,238,102,63,178,94,91,4,161,136,7,237,69,60,76,102,103,53,152,54,37,137,130,45,253,239,110,42,136,34,138,222,6,222,121,94,222,231,32,102,227,235,142,197,185,184,225,190,199,161,75,227,124,209,245,60,191,238,59,226,97,152,175,58,194,182,217,99,221,242,53,246,184,225,145,251,53,182,207,60,172,154,97,44,206,190,98,162,16,179,151,83,42,206,239,14,226,114,228,205,237,101,204,237,154,149,87,62,16,4,19,21,24,173,34,96,141,18,108,114,198,81,242,132,213,4,79,191,7,113,106,200,144,211,70,59,131,30,148,213,30,76,165,25,176,178,18,40,41,195,28,49,148,210,138,99,33,174,242,172,207,220,146,169,25,154,110,43,167,112,129,187,49,223,83,222,12,43,218,175,223,159,198,254,153,139,15,98,209,109,118,109,86,155,128,37,167,197,35,211,19,127,217,114,129,237,144,227,99,241,217,202,58,103,189,11,12,58,104,4,195,94,67,112,18,65,219,58,121,69,46,80,148,223,172,202,132,38,178,142,80,201,148,192,4,139,80,123,178,16,180,143,78,167,104,107,196,223,172,212,223,173,112,75,220,254,211,137,100,85,105,133,22,100,153,55,26,118,18,2,91,130,178,170,19,42,233,163,138,246,155,83,172,41,106,82,1,74,66,6,227,99,132,90,229,11,165,81,86,149,101,165,156,249,205,73,255,217,105,217,157,109,187,241,177,217,62,252,236,117,147,137,172,117,127,124,3,76,129,125,193,222,2,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(branchingDecisionsParameter);
			var resultDecisionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d7ddf2ac-d757-46b1-be45-23d92c75fac3"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ResultDecisions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			resultDecisionsParameter.SourceValue = new ProcessSchemaParameterValue(resultDecisionsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDecisionsParameter);
			var decisionModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("000efa2d-fb03-4c16-a5d9-f25cf8f9d82d"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"DecisionMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			decisionModeParameter.SourceValue = new ProcessSchemaParameterValue(decisionModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(decisionModeParameter);
			var isDecisionRequiredParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("215456ce-4520-4c29-b6d6-8259bd1cb74b"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"IsDecisionRequired",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isDecisionRequiredParameter.SourceValue = new ProcessSchemaParameterValue(isDecisionRequiredParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(isDecisionRequiredParameter);
			var questionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51a4a529-9378-410d-8fa1-e469e0bfa4e0"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Question",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			questionParameter.SourceValue = new ProcessSchemaParameterValue(questionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"What should be done with the remaining tasks for this incident",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(questionParameter);
			var windowCaptionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c50c1d7b-3b09-46d8-91ca-188cb23ef8c2"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"WindowCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			windowCaptionParameter.SourceValue = new ProcessSchemaParameterValue(windowCaptionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(windowCaptionParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dc8b9fc3-346a-4e8b-a0ac-66c45ebc30b2"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"What should be done with the remaining tasks for this incident",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("f48bfc98-8af5-4b8b-8f0e-0f54a4b68120"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("ca4f9842-d9ff-4a15-b38b-1cd918ee9ed3"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#SysVariable.CurrentUserContact#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("622b9f2a-4cb2-43a8-8f4b-becabac69839"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("acc42a39-4371-4da5-b7fc-d06c3e13ec03"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a5d59779-62f7-485f-b4a9-a0d09a870942"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("43205693-5dcc-43f3-a331-b49c4bc9973d"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d471d560-f33f-4ec8-b727-bf18cd94b7c2"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e895a017-2743-4df7-be4f-c24ce2e71411"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9dfce689-a334-4c71-8932-456ffbbfdca7"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ShowInScheduler",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showInSchedulerParameter.SourceValue = new ProcessSchemaParameterValue(showInSchedulerParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a9906e90-904c-47dc-a148-9c2ac1836a1f"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("3d2362be-d4ae-4a2b-b570-6dadadab9cfb"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Lead",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("65dedf77-e2ac-4f6a-81b0-9b66c8145aa7"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("1663995d-0b3c-4b2c-a172-e140a6adcfc2"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("eca4a8da-4536-4478-8fb8-db24bbdb8f90"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Opportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityParameter.SourceValue = new ProcessSchemaParameterValue(opportunityParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("972e2db6-3271-40c0-82a2-3d60f8cee668"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				UId = new Guid("1cea383e-0fcf-4a49-af48-76f2446e9056"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Document",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			documentParameter.SourceValue = new ProcessSchemaParameterValue(documentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(documentParameter);
			var incidentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("40e4bd9f-a064-4a0a-9a39-d1d5e1f3a19c"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				UId = new Guid("f2bc9f52-708a-476d-a06a-4e438caea1c8"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				UId = new Guid("332854ec-8027-4a9f-be87-fd81e4c8cdc4"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ActivityResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activityResultParameter.SourceValue = new ProcessSchemaParameterValue(activityResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activityResultParameter);
			var currentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8a4aa587-30b7-4d91-8af2-9c962132c668"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"CurrentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(currentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(currentActivityIdParameter);
			var isActivityCompletedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8624a7a9-f290-4573-a493-1a331d465b0c"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var executionContextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("73499557-0a32-4d92-84b3-8bb67973374b"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ExecutionContext",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			executionContextParameter.SourceValue = new ProcessSchemaParameterValue(executionContextParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executionContextParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7bf7d250-d34e-4225-aaa6-dcddbf01f6d2"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"InformationOnStep",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var orderParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("58d3775d-23b0-4670-9b6c-61eed72117e4"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				UId = new Guid("8e07b990-896f-406b-b301-1ca5ad999a3b"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				UId = new Guid("33643c88-34dd-4205-98e0-a9d17513a406"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				UId = new Guid("e6e31938-0b0f-4bba-a9bb-1722f1b6c875"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				UId = new Guid("4ac1b552-b731-4e7f-a4aa-2104b7d151c1"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				UId = new Guid("7abadf0a-2e61-4b8b-ae34-40e154e2bae6"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				UId = new Guid("4790f3c7-f104-4440-a586-b32ca6f69887"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				UId = new Guid("ee3e666e-6999-4800-8719-42b69d82985f"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
				UId = new Guid("e2b728c6-93b7-493c-978a-05eb21b9cdf3"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
			var createActivityParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("526e4e0e-d910-498a-af71-5ee401b97594"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"CreateActivity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			createActivityParameter.SourceValue = new ProcessSchemaParameterValue(createActivityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			parametrizedElement.Parameters.Add(createActivityParameter);
			var activityPriorityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b934f48c-5dea-49b9-bde3-697cb4be5d8b"),
				UId = new Guid("3443aa84-091a-4638-a153-8c07754c53cc"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
			var confItemParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				UId = new Guid("3210c491-5bf8-4c44-809f-2ccea5bab678"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"ConfItem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			confItemParameter.SourceValue = new ProcessSchemaParameterValue(confItemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(confItemParameter);
			var eventParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5b4fdfc7-12b6-4b4f-a9bd-b6f1b6e4447f"),
				UId = new Guid("f2efe05d-aea3-45b2-ac3b-b435686ba5c7"),
				ContainerUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"Event",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			eventParameter.SourceValue = new ProcessSchemaParameterValue(eventParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(eventParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaStartSignalEvent creatednewincidentstartsignal = CreateCreatedNewIncidentStartSignalStartSignalEvent();
			FlowElements.Add(creatednewincidentstartsignal);
			ProcessSchemaStartSignalEvent modifiedinactiveincidentstartsignal = CreateModifiedInactiveIncidentStartSignalStartSignalEvent();
			FlowElements.Add(modifiedinactiveincidentstartsignal);
			ProcessSchemaUserTask adddiagnosetask = CreateAddDiagnoseTaskUserTask();
			FlowElements.Add(adddiagnosetask);
			ProcessSchemaUserTask readcasedata = CreateReadCaseDataUserTask();
			FlowElements.Add(readcasedata);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaIntermediateCatchSignalEvent resolvedcatchsignal = CreateResolvedCatchSignalIntermediateCatchSignalEvent();
			FlowElements.Add(resolvedcatchsignal);
			ProcessSchemaEventBasedGateway eventbasedgateway1 = CreateEventBasedGateway1EventBasedGateway();
			FlowElements.Add(eventbasedgateway1);
			ProcessSchemaUserTask resolvedchangedatausertask = CreateResolvedChangeDataUserTaskUserTask();
			FlowElements.Add(resolvedchangedatausertask);
			ProcessSchemaIntermediateCatchSignalEvent canceledcatchsignal = CreateCanceledCatchSignalIntermediateCatchSignalEvent();
			FlowElements.Add(canceledcatchsignal);
			ProcessSchemaUserTask canceledchangedatausertask = CreateCanceledChangeDataUserTaskUserTask();
			FlowElements.Add(canceledchangedatausertask);
			ProcessSchemaIntermediateCatchSignalEvent pendingcatchsignal = CreatePendingCatchSignalIntermediateCatchSignalEvent();
			FlowElements.Add(pendingcatchsignal);
			ProcessSchemaUserTask pendingchangedatausertask = CreatePendingChangeDataUserTaskUserTask();
			FlowElements.Add(pendingchangedatausertask);
			ProcessSchemaIntermediateCatchSignalEvent escalationcatchsignal = CreateEscalationCatchSignalIntermediateCatchSignalEvent();
			FlowElements.Add(escalationcatchsignal);
			ProcessSchemaUserTask escalationchangedatausertask = CreateEscalationChangeDataUserTaskUserTask();
			FlowElements.Add(escalationchangedatausertask);
			ProcessSchemaScriptTask existsdiagnoseincidenttask = CreateExistsDiagnoseIncidentTaskScriptTask();
			FlowElements.Add(existsdiagnoseincidenttask);
			ProcessSchemaUserTask readcasecountdatausertask = CreateReadCaseCountDataUserTaskUserTask();
			FlowElements.Add(readcasecountdatausertask);
			ProcessSchemaUserTask completetaskschangedatausertask = CreateCompleteTasksChangeDataUserTaskUserTask();
			FlowElements.Add(completetaskschangedatausertask);
			ProcessSchemaUserTask canceltaskschangedatausertask = CreateCancelTasksChangeDataUserTaskUserTask();
			FlowElements.Add(canceltaskschangedatausertask);
			ProcessSchemaTerminateEvent terminateevent1 = CreateTerminateEvent1TerminateEvent();
			FlowElements.Add(terminateevent1);
			ProcessSchemaFormulaTask setcurrenttask = CreateSetCurrentTaskFormulaTask();
			FlowElements.Add(setcurrenttask);
			ProcessSchemaIntermediateCatchSignalEvent rescheduledcatchsignal = CreateRescheduledCatchSignalIntermediateCatchSignalEvent();
			FlowElements.Add(rescheduledcatchsignal);
			ProcessSchemaUserTask addrescheduledtaskusertask = CreateAddRescheduledTaskUserTaskUserTask();
			FlowElements.Add(addrescheduledtaskusertask);
			ProcessSchemaUserTask openresheduledtaskeditpageusertask = CreateOpenResheduledTaskEditPageUserTaskUserTask();
			FlowElements.Add(openresheduledtaskeditpageusertask);
			ProcessSchemaFormulaTask setrescheduledtaskformula = CreateSetRescheduledTaskFormulaFormulaTask();
			FlowElements.Add(setrescheduledtaskformula);
			ProcessSchemaUserTask userquestionusertask1 = CreateUserQuestionUserTask1UserTask();
			FlowElements.Add(userquestionusertask1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
			FlowElements.Add(CreateConditionalSequenceFlow4ConditionalFlow());
			FlowElements.Add(CreateConditionalSequenceFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("c124d32d-f4a9-4025-b54f-a3391f71f23b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(261, 218),
				SequenceFlowStartPointPosition = new Point(224, 218),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b4dbfeb1-c536-4a67-b205-344a03d90f82"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f7662a09-75e5-455d-8553-82e904aa11ad"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cefe2402-d24e-4662-9268-03c62b4e8ad0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b4dbfeb1-c536-4a67-b205-344a03d90f82"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(196, 283));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("9f5f64ec-a801-47fc-b0ea-27e0de2a22fe"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ad8937e-6a59-4a6c-b6b0-32c1157f455c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b4dbfeb1-c536-4a67-b205-344a03d90f82"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(196, 146));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("d8fd141a-30c6-4788-8953-322cf033900c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(355, 218),
				SequenceFlowStartPointPosition = new Point(330, 218),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a5470c4b-b56a-4a48-87ba-c46af633f521"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("5cb5ec46-0721-46b5-9799-5590ce948346"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("81eb01f4-e429-4220-8543-2f8b4220d93b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ccf3540c-c804-4971-8995-4b3c3e683205"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(554, 297));
			schemaFlow.PolylinePointPositions.Add(new Point(554, 216));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("e46dfcaa-8c91-42ba-b744-c74675968500"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b64d7413-4571-4a80-9683-fa8ed03cf197"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cc3ba7b8-b66a-4e6a-9d64-0c10df04ce80"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("27df56ec-5d63-4321-83cd-50eb7792d19d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ccf3540c-c804-4971-8995-4b3c3e683205"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1ae2d9da-9762-47c2-8ddd-7f67b805d1fb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(616, 311));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("16bbe664-2448-407b-aaba-79333d218be9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ccf3540c-c804-4971-8995-4b3c3e683205"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b64d7413-4571-4a80-9683-fa8ed03cf197"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(616, 402));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("3d580ae9-3f3c-4ac2-b3a7-e9cfa1641be7"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ae2d9da-9762-47c2-8ddd-7f67b805d1fb"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("469548be-7215-434c-8fda-7e541797fdf9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("f0938080-5382-4c81-8259-c7a180aa2897"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ccf3540c-c804-4971-8995-4b3c3e683205"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d7674af7-e199-4c72-821d-36401cba0d75"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("d39a07da-9daf-4306-bb48-9245659c53f1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7674af7-e199-4c72-821d-36401cba0d75"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("41a9e18e-ba68-4a3e-9b87-c9033b84382e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(769, 216));
			schemaFlow.PolylinePointPositions.Add(new Point(769, 217));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("88874a96-92e7-4a97-9b28-4e07557e2b8f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("41a9e18e-ba68-4a3e-9b87-c9033b84382e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("04869428-40a4-4d45-ba84-5c89ce37b217"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("cc7f219c-ad11-4ca7-8f46-b569809b644d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ccf3540c-c804-4971-8995-4b3c3e683205"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9465eae5-e8e5-47ca-be99-632bc3fcb44c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(616, 132));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("f2e5c1bb-4171-4280-a270-9e8df84c77d8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9465eae5-e8e5-47ca-be99-632bc3fcb44c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ad170079-791f-4bd7-98e0-472fdd5812f3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("3c48c743-4e11-4ceb-b7b1-cab3b3738212"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ad170079-791f-4bd7-98e0-472fdd5812f3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("04869428-40a4-4d45-ba84-5c89ce37b217"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1099, 132));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("1d38db98-8dc6-4042-9109-8a7749040b55"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{ecd8a32c-df30-44e9-89f6-3adc6c3bdfd8}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a5470c4b-b56a-4a48-87ba-c46af633f521"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ccf3540c-c804-4971-8995-4b3c3e683205"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(506, 217));
			schemaFlow.PolylinePointPositions.Add(new Point(506, 216));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("46a79fd0-8e80-43fd-854c-d322f0116884"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a5470c4b-b56a-4a48-87ba-c46af633f521"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7f8b1890-288d-4ede-ac71-15b759489e77"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow3",
				UId = new Guid("fb04edf5-8ee9-435c-a469-f023d2bf3090"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("04869428-40a4-4d45-ba84-5c89ce37b217"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(998, 246));
			schemaFlow.PolylinePointPositions.Add(new Point(1099, 246));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("5f1814a8-43e5-487c-b104-63caf0fb92f2"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3fceae6f-a629-4ceb-92b4-3aed7434c92b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("815ee92a-d5be-44c7-9cb1-07a1bdb1fc7f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1372, 258));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("658297d6-6ddf-444a-a55a-61611c75576f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("484f3905-6b35-4c22-a574-50b567b9a99b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("815ee92a-d5be-44c7-9cb1-07a1bdb1fc7f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1372, 432));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("e55b9f8f-6e8d-499c-ba83-9b1e260b2711"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("81eb01f4-e429-4220-8543-2f8b4220d93b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("70881c66-7559-4967-b02f-2bb93def217f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("e05747d6-2f01-455e-8c6c-8bf413fcc734"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("70881c66-7559-4967-b02f-2bb93def217f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e615c390-d90a-4a82-a7af-2fd1be051086"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21",
				UId = new Guid("bba41f6b-07a5-4a16-ae3b-94b29cdfee95"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e615c390-d90a-4a82-a7af-2fd1be051086"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68ef5315-41e9-4b68-96d5-fdca74d37520"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("2f328f1d-76a7-4371-a547-f5bcaffd91af"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d3611d33-118c-47cc-a393-7f8025bbd3f8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("ac653afe-76e7-4e26-ba63-b2216690aa33"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d3611d33-118c-47cc-a393-7f8025bbd3f8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e615c390-d90a-4a82-a7af-2fd1be051086"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("a81be806-38eb-4b86-a29a-615e6c038463"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("68ef5315-41e9-4b68-96d5-fdca74d37520"),
				SourceSequenceFlowPointLocalPosition = new Point(-1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("16155d91-0c1b-4224-8711-7b822b39a47c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("469548be-7215-434c-8fda-7e541797fdf9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(925, 311));
			schemaFlow.PolylinePointPositions.Add(new Point(925, 354));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("6b232d69-35ab-4654-8a10-827443a21369"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cc3ba7b8-b66a-4e6a-9d64-0c10df04ce80"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(925, 402));
			schemaFlow.PolylinePointPositions.Add(new Point(925, 354));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("c441e48e-09cc-4a19-81e6-f377ad5c0d0c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e056d00a-f1bb-41c3-b364-ba74262573fd}].[Parameter:{399de72a-ef6d-4a47-b355-3086cf7cc0cd}]#]>0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow4",
				UId = new Guid("74d3d11b-a9f9-4b35-93b4-796e21acc9c4"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("484f3905-6b35-4c22-a574-50b567b9a99b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"), new Collection<Guid>() {
						new Guid("3fa4de2d-80ff-495a-b7c5-927d62fd5baa"),
					}},
				}
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1216, 354));
			schemaFlow.PolylinePointPositions.Add(new Point(1216, 432));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow3",
				UId = new Guid("f6bd99ed-2ff7-4c65-82fd-851a090f22e7"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3fceae6f-a629-4ceb-92b4-3aed7434c92b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"), new Collection<Guid>() {
						new Guid("624264a7-1527-482e-a850-cf14eeda9305"),
					}},
				}
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1217, 354));
			schemaFlow.PolylinePointPositions.Add(new Point(1217, 258));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow25",
				UId = new Guid("94c617e9-8815-4fc9-ad4b-612ef616a019"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7f8b1890-288d-4ede-ac71-15b759489e77"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("81eb01f4-e429-4220-8543-2f8b4220d93b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("12402efe-b2f1-4a22-8403-6b47a8fd7f7e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("12402efe-b2f1-4a22-8403-6b47a8fd7f7e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("04869428-40a4-4d45-ba84-5c89ce37b217"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"Terminate1",
				Position = new Point(1086, 204),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateCreatedNewIncidentStartSignalStartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("9ad8937e-6a59-4a6c-b6b0-32c1157f455c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"CreatedNewIncidentStartSignal",
				NewEntityChangedColumns = false,
				Position = new Point(79, 133),
				SerializeToDB = false,
				Signal = @"Case",
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeCreatedNewIncidentStartSignalParameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateModifiedInactiveIncidentStartSignalStartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("cefe2402-d24e-4662-9268-03c62b4e8ad0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
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
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"ModifiedInactiveIncidentStartSignal",
				NewEntityChangedColumns = false,
				Position = new Point(79, 270),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("70620d00-e4ea-48d1-9fdc-4572fcd8d41b");
			schemaStartSignalEvent.EntityChangedColumns.Add("a71adaea-3464-4dee-bb4f-c7a535450ad7");
			InitializeModifiedInactiveIncidentStartSignalParameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateAddDiagnoseTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("81eb01f4-e429-4220-8543-2f8b4220d93b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"AddDiagnoseTask",
				Position = new Point(450, 270),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDiagnoseTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadCaseDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"ReadCaseData",
				Position = new Point(261, 190),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadCaseDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("b4dbfeb1-c536-4a67-b205-344a03d90f82"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"ExclusiveGateway1",
				Position = new Point(169, 190),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateResolvedCatchSignalIntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("b64d7413-4571-4a80-9683-fa8ed03cf197"),
				AttachedToUId = Guid.Empty,
				BackgroundModePriority = BackgroundModePriority.Inherited,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"ResolvedCatchSignal",
				NewEntityChangedColumns = false,
				Position = new Point(695, 389),
				SerializeToDB = true,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("a71adaea-3464-4dee-bb4f-c7a535450ad7");
			InitializeResolvedCatchSignalParameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaEventBasedGateway CreateEventBasedGateway1EventBasedGateway() {
			ProcessSchemaEventBasedGateway gateway = new ProcessSchemaEventBasedGateway(this) {
				UId = new Guid("ccf3540c-c804-4971-8995-4b3c3e683205"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				Instantiate = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ddbda75-9cac-4e42-b94c-5cf1edb45846"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"EventBasedGateway1",
				Position = new Point(589, 189),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateResolvedChangeDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("cc3ba7b8-b66a-4e6a-9d64-0c10df04ce80"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"ResolvedChangeDataUserTask",
				Position = new Point(817, 375),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeResolvedChangeDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateCanceledCatchSignalIntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("1ae2d9da-9762-47c2-8ddd-7f67b805d1fb"),
				AttachedToUId = Guid.Empty,
				BackgroundModePriority = BackgroundModePriority.Inherited,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"CanceledCatchSignal",
				NewEntityChangedColumns = false,
				Position = new Point(695, 298),
				SerializeToDB = true,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("a71adaea-3464-4dee-bb4f-c7a535450ad7");
			InitializeCanceledCatchSignalParameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateCanceledChangeDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("469548be-7215-434c-8fda-7e541797fdf9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"CanceledChangeDataUserTask",
				Position = new Point(817, 284),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeCanceledChangeDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreatePendingCatchSignalIntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("d7674af7-e199-4c72-821d-36401cba0d75"),
				AttachedToUId = Guid.Empty,
				BackgroundModePriority = BackgroundModePriority.Inherited,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"PendingCatchSignal",
				NewEntityChangedColumns = false,
				Position = new Point(695, 203),
				SerializeToDB = true,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("a71adaea-3464-4dee-bb4f-c7a535450ad7");
			InitializePendingCatchSignalParameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreatePendingChangeDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("41a9e18e-ba68-4a3e-9b87-c9033b84382e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"PendingChangeDataUserTask",
				Position = new Point(817, 190),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializePendingChangeDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateEscalationCatchSignalIntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("9465eae5-e8e5-47ca-be99-632bc3fcb44c"),
				AttachedToUId = Guid.Empty,
				BackgroundModePriority = BackgroundModePriority.Inherited,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"EscalationCatchSignal",
				NewEntityChangedColumns = false,
				Position = new Point(695, 119),
				SerializeToDB = true,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("70620d00-e4ea-48d1-9fdc-4572fcd8d41b");
			schemaCatchSignalEvent.EntityChangedColumns.Add("9147230c-ab53-4eb4-b0b4-ac78be6f8326");
			InitializeEscalationCatchSignalParameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateEscalationChangeDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ad170079-791f-4bd7-98e0-472fdd5812f3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"EscalationChangeDataUserTask",
				Position = new Point(817, 105),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeEscalationChangeDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateExistsDiagnoseIncidentTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a5470c4b-b56a-4a48-87ba-c46af633f521"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"ExistsDiagnoseIncidentTask",
				Position = new Point(355, 190),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,146,79,79,2,49,16,197,239,38,124,135,134,211,146,144,198,243,162,36,100,69,178,137,26,228,143,30,140,135,201,118,2,27,187,45,182,83,116,191,189,179,116,17,66,196,43,183,238,244,205,155,223,78,223,22,156,240,181,159,58,91,160,247,99,67,37,213,115,212,88,144,184,21,6,191,68,91,42,214,88,193,115,64,87,39,75,143,46,179,198,176,166,180,70,30,11,30,193,192,10,93,95,116,231,39,158,221,222,160,115,245,247,32,57,82,42,179,58,84,38,57,106,219,53,108,153,14,119,210,25,22,214,169,92,49,213,12,65,101,224,241,14,8,228,12,125,208,20,237,228,4,105,81,111,176,117,123,1,29,240,102,18,74,53,76,186,185,250,143,224,190,212,132,206,55,36,201,25,73,230,16,8,163,240,181,164,245,20,28,84,216,116,37,177,152,217,106,3,174,244,214,52,12,114,252,25,64,243,34,162,9,143,239,159,252,73,239,50,60,111,135,21,63,216,85,154,171,244,80,120,151,124,142,47,41,151,59,228,246,98,121,57,220,17,167,108,203,62,105,243,228,233,126,155,76,74,64,193,51,226,147,37,62,59,66,181,151,198,171,22,185,137,80,97,181,142,105,229,248,156,1,228,236,196,239,236,87,124,146,244,222,64,116,174,114,191,0,255,49,254,46,61,121,54,59,56,203,204,6,67,98,40,174,121,168,67,10,206,8,114,1,155,166,31,17,141,3,122,101,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadCaseCountDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"ReadCaseCountDataUserTask",
				Position = new Point(964, 327),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadCaseCountDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateCompleteTasksChangeDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3fceae6f-a629-4ceb-92b4-3aed7434c92b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"CompleteTasksChangeDataUserTask",
				Position = new Point(1252, 231),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeCompleteTasksChangeDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateCancelTasksChangeDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("484f3905-6b35-4c22-a574-50b567b9a99b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"CancelTasksChangeDataUserTask",
				Position = new Point(1251, 405),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeCancelTasksChangeDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("815ee92a-d5be-44c7-9cb1-07a1bdb1fc7f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"TerminateEvent1",
				Position = new Point(1359, 341),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaFormulaTask CreateSetCurrentTaskFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("70881c66-7559-4967-b02f-2bb93def217f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"SetCurrentTask",
				Position = new Point(450, 361),
				ResultParameterMetaPath = @"ae73a291-5391-4398-ad71-c61091bd78fe",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,139,49,15,194,32,20,6,127,76,231,103,128,71,227,131,221,193,169,38,142,13,3,224,71,28,74,7,218,196,161,233,127,23,87,199,187,203,205,195,124,223,166,207,138,246,204,111,212,232,75,92,54,132,75,183,127,226,182,160,98,221,253,33,26,73,233,98,9,214,56,178,198,40,146,209,50,153,34,233,71,47,199,233,236,195,35,182,88,177,163,249,67,247,206,80,160,44,204,100,115,255,92,26,53,93,145,89,36,69,54,92,206,48,132,47,137,4,102,212,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateRescheduledCatchSignalIntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("e615c390-d90a-4a82-a7af-2fd1be051086"),
				AttachedToUId = Guid.Empty,
				BackgroundModePriority = BackgroundModePriority.Inherited,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"RescheduledCatchSignal",
				NewEntityChangedColumns = false,
				Position = new Point(471, 444),
				SerializeToDB = true,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("ae372cfa-a21f-47f0-8a64-17d137ebe966");
			schemaCatchSignalEvent.EntityChangedColumns.Add("c8d84f9c-b48b-479b-9ac6-4412f3436ca2");
			InitializeRescheduledCatchSignalParameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateAddRescheduledTaskUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("68ef5315-41e9-4b68-96d5-fdca74d37520"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"AddRescheduledTaskUserTask",
				Position = new Point(450, 518),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddRescheduledTaskUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenResheduledTaskEditPageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"OpenResheduledTaskEditPageUserTask",
				Position = new Point(312, 518),
				SchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeOpenResheduledTaskEditPageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateSetRescheduledTaskFormulaFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("d3611d33-118c-47cc-a393-7f8025bbd3f8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"SetRescheduledTaskFormula",
				Position = new Point(312, 430),
				ResultParameterMetaPath = @"ae73a291-5391-4398-ad71-c61091bd78fe",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,203,177,14,131,32,16,0,208,143,113,190,70,56,14,78,246,14,78,109,210,209,48,92,225,72,7,117,64,147,14,198,127,175,115,215,151,188,169,155,198,237,241,93,181,189,242,71,23,137,85,230,77,211,237,210,63,184,207,186,232,186,199,195,179,86,66,67,224,140,14,224,222,158,97,240,133,160,150,44,193,21,12,100,251,243,10,79,105,178,232,174,45,30,132,172,200,62,128,45,198,131,11,200,192,22,43,16,246,130,213,230,66,18,206,212,165,31,213,159,223,210,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserQuestionUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"UserQuestionUserTask1",
				Position = new Point(1113, 327),
				SchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeUserQuestionUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7f8b1890-288d-4ede-ac71-15b759489e77"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d1efc494-00a3-4188-8c97-7c81e848542c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd"),
				CreatedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"),
				Name = @"ScriptTask1",
				Position = new Point(355, 270),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,193,10,194,48,16,68,239,253,138,189,8,105,197,90,20,189,4,15,165,5,79,158,170,31,16,218,61,4,52,133,116,19,240,239,77,154,170,77,233,37,144,217,153,55,155,88,161,97,32,161,169,22,132,112,129,199,128,186,234,149,194,150,100,175,242,202,104,141,138,188,154,95,145,166,171,247,222,229,11,89,202,19,169,40,0,110,82,153,17,241,195,229,65,226,73,60,103,140,205,133,61,156,82,216,194,1,50,136,244,141,215,199,97,230,143,13,156,11,158,88,183,174,21,207,168,165,236,186,16,25,216,110,217,157,78,229,211,235,92,116,110,159,213,45,140,17,189,193,182,87,93,68,15,146,11,149,238,159,172,164,119,179,22,254,143,107,131,107,228,239,34,199,194,161,52,146,209,10,72,27,228,31,76,222,139,204,151,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new IncidentDiagnosticsAndResolvingV2(userConnection);
		}

		public override object Clone() {
			return new IncidentDiagnosticsAndResolvingV2Schema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb"));
		}

		#endregion

	}

	#endregion

	#region Class: IncidentDiagnosticsAndResolvingV2

	/// <exclude/>
	public class IncidentDiagnosticsAndResolvingV2 : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: AddDiagnoseTaskFlowElement

		/// <exclude/>
		public class AddDiagnoseTaskFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDiagnoseTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDiagnoseTask";
				IsLogging = true;
				SchemaElementUId = new Guid("81eb01f4-e429-4220-8543-2f8b4220d93b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_ActivityCategory = () => (Guid)(new Guid("f51c4643-58e6-df11-971b-001d60e938c6"));
				_recordDefValues_Owner = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_recordDefValues_Contact = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
				_recordDefValues_Case = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_recordDefValues_Title = () => new LocalizableString((process.TaskCaption)+ " #"+((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Number").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<string>("Number") : null)));
				_recordDefValues_Account = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_recordDefValues_DueDate = () => (DateTime)((process.ActivityDueDate));
				_recordDefValues_StartDate = () => (DateTime)((process.ActivityStartDate));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_ActivityCategory", () => _recordDefValues_ActivityCategory.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Owner", () => _recordDefValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Case", () => _recordDefValues_Case.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Title", () => _recordDefValues_Title.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Account", () => _recordDefValues_Account.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DueDate", () => _recordDefValues_DueDate.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_StartDate", () => _recordDefValues_StartDate.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_ActivityCategory;
			internal Func<Guid> _recordDefValues_Owner;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_Case;
			internal Func<string> _recordDefValues_Title;
			internal Func<Guid> _recordDefValues_Account;
			internal Func<DateTime> _recordDefValues_DueDate;
			internal Func<DateTime> _recordDefValues_StartDate;

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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,152,91,111,83,73,12,128,255,74,116,224,141,58,154,139,231,214,55,4,172,84,9,88,180,237,242,66,121,240,204,120,74,68,154,84,57,39,172,216,170,255,125,125,210,22,90,180,244,162,85,151,34,154,135,84,153,30,123,60,182,63,219,115,142,187,199,195,231,35,238,182,187,61,94,173,168,95,182,97,250,108,185,226,233,155,213,178,112,223,79,95,46,11,205,103,127,83,158,243,27,90,209,33,15,188,122,75,243,53,247,47,103,253,176,53,185,44,214,109,117,143,63,109,254,219,109,191,59,238,118,6,62,252,115,167,138,118,180,204,49,163,7,114,49,2,22,67,144,155,67,200,33,83,181,74,151,230,162,8,151,229,124,125,184,120,197,3,189,161,225,67,183,125,220,109,180,137,130,18,53,54,10,26,88,233,12,104,141,3,42,177,66,172,72,38,89,174,218,198,238,100,171,235,203,7,62,164,205,166,23,132,17,83,141,214,0,97,41,128,89,105,200,169,58,136,164,77,65,67,169,197,52,10,159,61,255,85,240,221,163,151,203,229,199,245,209,52,121,205,70,69,177,95,27,217,190,154,0,89,37,7,168,178,102,143,213,151,162,166,205,233,130,30,45,184,200,30,106,211,26,82,16,107,149,210,213,43,78,54,22,255,232,253,184,81,157,245,71,115,250,252,246,187,251,61,45,195,236,211,108,248,60,41,52,240,193,114,245,121,186,183,156,212,229,169,244,209,165,64,92,148,63,222,63,141,231,126,183,189,255,189,136,158,253,221,221,56,234,114,76,191,13,231,126,183,181,223,237,46,215,171,50,106,180,242,227,249,5,195,55,155,108,30,249,230,231,121,252,100,101,177,158,207,207,86,158,211,64,231,15,158,47,47,235,172,205,184,238,44,118,207,195,182,209,162,206,62,240,47,95,231,159,83,219,254,139,216,43,90,208,1,175,94,139,3,190,218,254,197,202,61,113,227,185,226,108,146,83,65,55,8,76,9,144,189,145,188,211,4,73,167,220,108,176,166,53,179,145,254,131,27,175,120,81,248,178,97,55,201,158,51,249,126,227,237,17,156,51,187,70,87,157,116,39,39,91,23,113,146,220,10,53,176,3,173,170,6,212,181,64,76,88,193,171,156,83,114,62,112,75,87,226,212,84,176,190,145,133,144,70,5,193,43,32,246,9,146,231,226,124,74,22,147,190,11,156,222,237,244,191,255,181,224,213,169,127,182,27,205,123,126,63,149,213,111,22,94,204,249,144,23,195,246,113,108,46,32,187,12,193,27,20,67,141,129,164,36,8,182,52,239,164,114,100,162,120,34,2,95,18,121,251,56,144,211,132,209,64,41,222,139,115,92,0,10,222,129,10,181,17,39,86,205,231,81,228,197,98,16,194,158,109,124,36,82,202,27,85,37,91,24,153,0,37,190,144,154,248,21,93,48,173,84,169,51,90,164,174,195,247,15,166,42,204,246,60,169,146,72,211,223,102,171,126,152,204,36,110,147,101,155,172,184,95,207,135,217,226,96,34,129,153,179,32,190,92,76,159,246,253,236,96,193,252,128,246,79,137,182,246,153,173,119,26,98,99,51,38,91,18,249,42,52,69,101,43,250,104,107,181,183,66,219,75,159,104,46,139,5,110,84,104,164,229,101,39,41,44,217,235,180,228,111,83,154,174,68,59,55,162,84,66,131,98,189,180,90,84,114,34,171,197,34,29,188,87,141,154,198,59,233,148,247,23,109,111,147,111,232,25,10,166,6,216,178,68,203,41,153,29,12,70,159,90,83,152,237,93,160,253,108,185,24,168,12,15,100,63,144,61,146,45,57,135,60,14,0,177,218,52,146,157,55,76,130,231,204,129,141,243,158,240,74,178,49,20,172,5,131,100,175,17,5,85,49,144,52,113,104,38,197,156,141,42,50,4,255,90,100,19,43,70,87,104,36,91,198,169,198,34,101,83,5,75,57,152,16,89,123,29,238,130,236,157,250,0,245,207,9,181,204,205,242,144,160,108,130,36,140,179,8,17,229,158,166,37,235,180,118,133,83,169,183,130,90,177,139,1,137,33,144,242,99,6,74,91,137,217,129,17,160,139,53,152,108,185,186,93,11,209,77,145,213,16,90,13,2,181,116,126,82,10,101,12,213,54,235,32,22,218,31,58,137,95,100,180,212,140,206,35,104,153,35,196,212,34,180,181,92,129,76,77,84,82,32,50,155,62,250,100,178,223,77,30,237,119,79,238,115,233,8,57,22,246,25,193,36,169,31,168,228,48,153,105,28,182,114,11,89,42,173,66,186,190,116,236,81,255,81,74,199,209,88,21,46,29,252,246,53,229,245,250,48,243,234,161,174,252,144,186,34,61,196,186,182,153,146,133,33,44,94,114,40,121,2,43,109,158,60,53,42,173,92,85,87,110,108,216,77,235,74,106,82,57,70,194,42,5,59,190,239,146,97,161,201,244,225,217,215,216,138,205,42,95,115,195,207,170,250,38,183,88,29,36,171,145,164,164,144,118,78,42,69,246,104,139,175,234,87,187,6,100,237,172,50,37,9,226,69,54,170,9,71,151,58,144,105,78,137,187,169,54,214,119,114,195,47,101,185,94,60,92,3,126,206,137,193,184,26,138,166,12,186,178,146,137,97,68,97,188,83,43,35,179,167,163,96,170,231,91,78,12,182,26,31,2,200,117,94,200,86,14,33,137,70,72,136,156,41,83,179,198,92,61,49,40,43,173,75,78,164,93,150,139,137,183,82,181,114,246,32,45,204,134,64,25,75,202,247,101,98,8,65,167,32,135,51,90,14,140,57,18,100,99,8,156,212,163,36,78,245,152,252,245,200,157,191,12,127,190,102,9,241,195,155,178,31,3,82,53,90,74,107,67,40,74,70,64,84,218,72,44,163,135,70,154,162,14,186,18,226,255,218,34,91,144,22,105,91,132,224,130,144,221,140,149,84,206,13,188,138,89,123,177,201,100,123,37,72,99,202,147,179,17,188,206,210,34,147,10,227,43,223,6,74,39,159,180,151,190,80,235,61,1,137,72,70,85,165,42,176,52,58,217,205,122,185,232,74,21,83,182,57,159,92,182,186,150,155,131,180,59,208,106,120,64,233,151,70,233,253,201,63,179,30,208,98,252,29,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "b98be122f42246da8bb7c0a3e83ee7cb",
							"BaseElements.AddDiagnoseTask.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd");
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

		#region Class: ReadCaseDataFlowElement

		/// <exclude/>
		public class ReadCaseDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadCaseDataFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadCaseData";
				IsLogging = true;
				SchemaElementUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,75,111,211,64,16,254,43,145,207,221,202,222,151,237,220,80,8,168,7,104,69,43,46,164,135,241,238,56,89,225,151,214,78,75,169,242,223,25,219,105,104,171,148,166,72,8,144,234,211,122,244,205,204,55,143,111,247,54,48,5,180,237,71,40,49,152,6,23,232,61,180,117,222,29,191,115,69,135,254,189,175,215,77,112,20,180,232,29,20,238,59,218,209,62,183,174,123,11,29,144,203,237,226,103,132,69,48,93,236,143,177,8,142,22,129,235,176,108,9,67,46,177,209,218,42,195,153,81,57,103,50,55,9,203,84,152,179,56,19,73,44,227,84,242,60,29,145,79,5,159,213,101,3,30,199,28,67,248,124,56,94,220,52,61,52,34,131,25,32,174,173,171,173,81,244,36,218,121,5,89,129,150,254,59,191,70,50,117,222,149,84,13,94,184,18,207,192,83,174,62,78,221,155,8,148,67,209,246,168,2,243,110,254,173,241,216,182,174,174,158,35,87,172,203,234,62,154,2,224,238,119,75,39,28,56,246,200,51,232,86,67,136,19,162,181,25,88,190,89,46,61,46,161,115,87,247,73,124,197,155,1,119,88,255,200,193,210,148,62,67,177,198,123,57,31,86,50,131,166,27,11,26,211,19,192,187,229,234,224,90,119,29,123,174,92,78,198,230,14,124,96,204,189,53,112,77,198,171,222,48,70,185,59,46,130,47,39,237,233,117,133,254,220,172,176,132,177,107,151,199,100,125,100,152,23,88,98,213,77,111,83,176,73,42,98,100,26,84,202,36,104,195,50,157,133,76,112,19,69,42,206,165,82,102,67,14,59,66,211,91,204,116,10,113,46,24,13,64,51,201,83,206,18,46,53,19,137,225,41,202,80,43,158,110,46,71,226,174,109,10,184,249,188,227,55,243,72,75,101,39,21,94,79,92,101,156,37,18,199,159,208,212,222,14,147,167,143,220,180,8,19,29,70,17,75,49,148,76,42,141,44,51,144,178,72,8,161,172,18,42,73,94,197,241,11,113,28,214,191,87,113,60,39,14,131,57,114,25,114,102,185,68,38,181,230,44,229,58,97,161,48,154,103,18,19,176,225,35,113,128,213,137,20,161,97,66,152,140,201,44,68,150,198,58,102,160,185,13,21,196,161,202,178,167,196,241,161,182,46,119,164,14,87,129,233,71,187,147,200,228,218,117,171,9,173,48,109,230,132,154,226,150,21,226,35,221,244,139,81,212,75,103,160,56,109,208,195,118,108,209,254,173,126,32,135,190,99,190,174,187,177,15,187,142,207,160,197,129,233,221,94,129,69,174,184,200,88,162,146,180,87,190,164,189,162,75,55,237,107,142,140,206,69,159,98,67,239,101,63,148,243,122,237,205,86,130,237,248,80,254,214,3,248,23,148,251,18,49,238,149,195,33,235,253,127,222,234,47,190,162,95,199,247,47,221,59,127,242,166,216,4,155,31,42,231,46,119,78,11,0,0 })));
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

		#region Class: ResolvedCatchSignalFlowElement

		/// <exclude/>
		public class ResolvedCatchSignalFlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public ResolvedCatchSignalFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "ResolvedCatchSignal";
				IsLogging = true;
				SchemaElementUId = new Guid("b64d7413-4571-4a80-9683-fa8ed03cf197");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",""$values"":[""a71adaea-3464-4dee-bb4f-c7a535450ad7""]}";
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{\""1fac16a5-a625-4773-a4aa-287aceb4b093\"":{\""className\"":\""Terrasoft.InFilter\"",\""filterType\"":4,\""comparisonType\"":3,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""className\"":\""Terrasoft.ColumnExpression\"",\""expressionType\"":0,\""columnPath\"":\""Status\""},\""isAggregative\"":false,\""key\"":\""1fac16a5-a625-4773-a4aa-287aceb4b093\"",\""dataValueType\"":10,\""leftExpressionCaption\"":\""Status\"",\""referenceSchemaName\"":\""CaseStatus\"",\""rightExpressions\"":[{\""className\"":\""Terrasoft.ParameterExpression\"",\""expressionType\"":2,\""parameter\"":{\""className\"":\""Terrasoft.Parameter\"",\""dataValueType\"":10,\""value\"":{\""Id\"":\""ae7f411e-f46b-1410-009b-0050ba5d6c38\"",\""Name\"":\""Resolved\"",\""value\"":\""ae7f411e-f46b-1410-009b-0050ba5d6c38\"",\""displayValue\"":\""Resolved\""}}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\"",\""key\"":\""dadc7b7d-b990-430e-b79d-5376e1f8beb0\""}"",""dataSourceFilters"":""{\""items\"":{\""1fac16a5-a625-4773-a4aa-287aceb4b093\"":{\""filterType\"":4,\""comparisonType\"":3,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""expressionType\"":0,\""columnPath\"":\""Status\""},\""rightExpressions\"":[{\""expressionType\"":2,\""parameter\"":{\""dataValueType\"":10,\""value\"":\""ae7f411e-f46b-1410-009b-0050ba5d6c38\""}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\""}""}";
				_recordId = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
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

		#region Class: ResolvedChangeDataUserTaskFlowElement

		/// <exclude/>
		public class ResolvedChangeDataUserTaskFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ResolvedChangeDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ResolvedChangeDataUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("cc3ba7b8-b66a-4e6a-9d64-0c10df04ce80");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Status = () => (Guid)(new Guid("4bdbb88f-58e6-df11-971b-001d60e938c6"));
				_recordColumnValues_Result = () => (Guid)(new Guid("ef46415c-8dc6-43cb-9caa-36e5a6651dcf"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Status", () => _recordColumnValues_Status.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Result", () => _recordColumnValues_Result.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Status;
			internal Func<Guid> _recordColumnValues_Result;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,85,201,110,219,48,16,253,21,67,231,48,16,37,70,75,110,65,146,22,190,52,1,28,228,82,231,48,164,134,54,17,109,32,169,180,110,224,127,239,72,178,221,164,112,27,183,232,146,162,62,216,210,248,241,205,155,149,143,129,42,193,185,119,80,97,112,26,220,160,181,224,26,237,143,223,152,210,163,125,107,155,174,13,142,2,135,214,64,105,62,97,49,218,47,11,227,47,192,3,29,121,156,127,97,152,7,167,243,253,28,243,224,104,30,24,143,149,35,12,29,201,85,170,69,162,144,137,88,43,38,162,56,101,178,136,4,211,160,34,93,64,42,49,230,35,242,91,228,231,77,213,130,197,209,199,64,175,135,199,155,85,219,67,57,25,212,0,49,174,169,55,198,184,23,225,46,107,144,37,22,244,238,109,135,100,242,214,84,20,13,222,152,10,175,193,146,175,158,167,233,77,4,210,80,186,30,85,162,246,151,31,91,139,206,153,166,126,73,92,217,85,245,83,52,17,224,238,117,35,39,28,52,246,200,107,240,203,129,98,74,178,214,131,202,179,197,194,226,2,188,121,120,42,226,30,87,3,238,176,252,209,129,130,170,116,11,101,135,79,124,62,143,228,28,90,63,6,52,186,39,128,53,139,229,193,177,238,50,246,82,184,17,25,219,45,248,64,206,189,49,68,9,25,31,122,195,200,178,125,156,7,239,167,238,234,67,141,118,166,150,88,193,152,181,187,99,178,126,101,216,241,159,62,2,166,49,68,57,103,39,49,125,137,56,207,24,20,41,103,42,225,97,206,101,145,102,26,215,119,163,14,227,218,18,86,183,59,119,231,157,181,88,251,137,7,119,63,153,94,12,160,62,133,244,87,132,66,229,32,98,166,248,137,100,34,76,34,38,67,41,89,202,229,73,30,101,192,115,174,169,212,244,161,51,169,138,179,60,5,96,73,26,23,76,164,66,178,60,21,200,194,92,114,173,32,195,236,255,156,134,153,7,223,57,218,35,181,113,203,195,6,227,176,84,238,105,42,30,125,119,50,54,82,198,159,137,113,19,109,106,40,255,133,105,25,2,219,142,200,144,174,77,215,149,205,194,40,40,175,90,180,176,137,51,220,223,18,207,122,169,31,62,219,52,126,28,169,157,156,51,69,21,49,126,53,104,216,86,3,65,138,4,184,102,137,208,33,85,35,166,41,144,50,102,69,24,201,34,65,145,105,213,47,60,186,97,122,213,179,166,179,106,211,195,110,188,90,126,234,202,248,11,173,255,35,187,125,111,191,28,82,255,215,178,7,127,239,138,123,165,213,219,179,139,126,89,33,255,248,136,174,131,245,103,246,5,23,239,249,9,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,203,110,219,48,16,252,21,131,201,209,107,144,20,69,145,190,21,205,37,64,82,4,117,154,75,156,195,146,92,54,66,101,203,208,35,64,106,248,223,75,43,118,98,7,77,27,160,232,161,64,117,144,64,106,103,118,52,203,209,154,157,118,143,43,98,83,118,77,77,131,109,29,187,201,199,186,161,201,85,83,123,106,219,201,69,237,177,42,191,163,171,232,10,27,92,80,71,205,13,86,61,181,23,101,219,141,71,199,48,54,102,167,15,195,91,54,189,93,179,243,142,22,95,206,67,98,23,198,112,116,222,65,212,50,3,133,153,5,44,10,9,166,240,36,17,77,206,35,38,176,175,171,126,177,188,164,14,175,176,187,103,211,53,27,216,18,129,55,193,168,104,61,56,101,28,168,194,58,176,232,53,40,37,100,204,84,166,61,74,182,25,179,214,223,211,2,135,166,7,96,165,108,48,153,4,84,222,131,114,92,128,179,33,7,131,66,122,37,209,70,99,183,224,93,253,11,240,246,228,162,174,191,245,171,137,225,57,162,39,5,70,115,5,138,83,1,104,201,1,143,185,18,133,202,109,230,249,68,185,224,156,49,17,114,67,26,66,20,2,108,33,82,17,23,65,115,178,153,241,250,228,110,219,40,148,237,170,194,199,155,55,251,125,240,93,249,80,118,143,163,182,195,174,111,147,185,139,85,149,188,15,79,248,213,209,40,14,25,214,243,167,137,206,217,116,254,214,76,119,207,217,96,213,241,84,95,15,116,206,198,115,54,171,251,198,111,25,179,180,56,59,144,62,52,25,74,94,45,247,19,76,59,203,190,170,118,59,103,216,225,190,112,191,93,135,50,150,20,206,151,179,253,224,6,22,190,187,224,39,183,253,245,164,237,79,96,151,184,196,175,212,124,74,6,188,104,127,86,121,157,108,220,19,59,105,115,94,136,8,5,161,5,69,58,29,221,32,16,172,176,46,102,69,38,99,148,3,250,51,69,106,104,233,233,88,216,123,206,207,14,223,14,110,111,163,179,211,181,181,106,195,54,155,241,97,160,84,144,210,72,138,192,139,196,170,114,76,130,200,72,8,74,134,16,149,115,24,242,95,6,10,41,43,164,143,8,40,211,103,169,34,242,20,7,173,64,20,65,100,5,57,178,90,255,197,64,101,210,186,192,53,65,180,121,106,111,164,2,228,209,129,201,41,36,47,163,180,202,76,40,42,173,68,238,147,215,219,168,103,233,255,97,61,34,100,154,114,212,58,23,193,199,119,6,42,249,218,87,221,168,142,35,220,69,107,50,75,222,116,101,189,28,197,186,95,254,15,214,191,25,172,247,156,163,223,5,235,110,243,3,141,80,24,75,7,7,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "b98be122f42246da8bb7c0a3e83ee7cb",
							"BaseElements.ResolvedChangeDataUserTask.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd");
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

		#region Class: CanceledCatchSignalFlowElement

		/// <exclude/>
		public class CanceledCatchSignalFlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public CanceledCatchSignalFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "CanceledCatchSignal";
				IsLogging = true;
				SchemaElementUId = new Guid("1ae2d9da-9762-47c2-8ddd-7f67b805d1fb");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",""$values"":[""a71adaea-3464-4dee-bb4f-c7a535450ad7""]}";
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{\""5ab56440-a4b9-4680-b192-23bb1a7c7981\"":{\""className\"":\""Terrasoft.InFilter\"",\""filterType\"":4,\""comparisonType\"":3,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""className\"":\""Terrasoft.ColumnExpression\"",\""expressionType\"":0,\""columnPath\"":\""Status\""},\""isAggregative\"":false,\""key\"":\""5ab56440-a4b9-4680-b192-23bb1a7c7981\"",\""dataValueType\"":10,\""leftExpressionCaption\"":\""Status\"",\""referenceSchemaName\"":\""CaseStatus\"",\""rightExpressions\"":[{\""className\"":\""Terrasoft.ParameterExpression\"",\""expressionType\"":2,\""parameter\"":{\""className\"":\""Terrasoft.Parameter\"",\""dataValueType\"":10,\""value\"":{\""Id\"":\""6e5f4218-f46b-1410-fe9a-0050ba5d6c38\"",\""Name\"":\""Cancelled\"",\""value\"":\""6e5f4218-f46b-1410-fe9a-0050ba5d6c38\"",\""displayValue\"":\""Cancelled\""}}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\"",\""key\"":\""543091b1-97e0-45d2-b947-6fda16831f3c\""}"",""dataSourceFilters"":""{\""items\"":{\""5ab56440-a4b9-4680-b192-23bb1a7c7981\"":{\""filterType\"":4,\""comparisonType\"":3,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""expressionType\"":0,\""columnPath\"":\""Status\""},\""rightExpressions\"":[{\""expressionType\"":2,\""parameter\"":{\""dataValueType\"":10,\""value\"":\""6e5f4218-f46b-1410-fe9a-0050ba5d6c38\""}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\""}""}";
				_recordId = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
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

		#region Class: CanceledChangeDataUserTaskFlowElement

		/// <exclude/>
		public class CanceledChangeDataUserTaskFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public CanceledChangeDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "CanceledChangeDataUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("469548be-7215-434c-8fda-7e541797fdf9");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Status = () => (Guid)(new Guid("201cfba8-58e6-df11-971b-001d60e938c6"));
				_recordColumnValues_Result = () => (Guid)(new Guid("dbbf0e10-f46b-1410-6598-00155d043204"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Status", () => _recordColumnValues_Status.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Result", () => _recordColumnValues_Result.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Status;
			internal Func<Guid> _recordColumnValues_Result;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,85,201,110,219,48,16,253,21,67,231,48,144,72,89,18,125,11,146,180,200,165,9,16,35,151,58,135,161,52,178,137,104,3,73,165,117,13,255,123,71,146,237,38,133,218,184,69,151,20,245,193,150,158,31,103,222,172,220,120,105,1,214,190,131,18,189,153,55,71,99,192,214,185,59,125,163,11,135,230,173,169,219,198,59,241,44,26,13,133,254,132,217,128,95,102,218,93,128,3,58,178,89,124,177,176,240,102,139,113,27,11,239,100,225,105,135,165,37,14,29,1,197,211,48,144,17,83,92,33,11,69,224,51,37,69,204,146,24,253,32,11,67,161,178,100,96,126,203,248,121,93,54,96,112,240,209,155,207,251,199,249,186,233,168,1,1,105,79,209,182,174,118,160,232,68,216,203,10,84,129,25,189,59,211,34,65,206,232,146,162,193,185,46,241,6,12,249,234,236,212,29,68,164,28,10,219,177,10,204,221,229,199,198,160,181,186,174,94,18,87,180,101,245,148,77,6,240,240,186,147,227,247,26,59,230,13,184,85,111,226,138,100,109,123,149,103,203,165,193,37,56,253,248,84,196,3,174,123,222,113,249,163,3,25,85,233,14,138,22,159,248,124,30,201,57,52,110,8,104,112,79,4,163,151,171,163,99,61,100,236,165,112,57,129,205,158,124,164,205,209,24,120,68,224,99,7,12,86,246,143,11,239,253,149,189,254,80,161,185,77,87,88,194,144,181,251,83,66,191,2,14,246,103,27,192,88,0,151,1,155,10,250,10,133,76,24,100,113,192,210,40,240,101,160,178,56,201,113,123,63,232,208,182,41,96,125,119,112,119,222,26,131,149,155,56,176,15,147,171,139,158,212,165,144,254,138,68,34,80,9,197,184,192,136,133,190,31,48,165,20,176,76,228,42,73,49,228,97,230,83,169,233,67,103,166,121,154,38,10,21,147,145,228,68,14,19,150,160,20,108,26,65,28,197,145,136,165,244,255,199,105,184,117,224,90,75,123,164,210,118,117,220,96,28,151,202,145,166,10,248,119,39,99,39,101,248,153,104,59,201,117,5,197,191,48,45,125,96,251,17,233,211,181,235,186,162,94,234,20,138,235,6,13,236,226,244,199,91,226,89,47,117,195,103,234,218,13,35,117,144,115,150,82,69,180,91,247,26,246,213,144,241,84,170,128,11,70,253,46,89,168,124,206,36,231,138,229,144,101,34,136,19,244,243,136,234,74,55,76,167,250,182,110,77,186,235,97,59,92,45,63,117,101,252,133,214,255,145,221,62,218,47,199,212,255,181,236,193,223,187,226,94,105,245,70,118,209,47,43,228,31,31,209,173,183,253,12,73,226,161,1,249,9,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,83,77,79,219,64,16,253,43,145,225,152,137,246,203,251,145,91,5,23,36,168,80,161,92,8,135,217,221,217,18,213,137,35,219,65,162,81,254,123,55,38,41,9,42,109,164,170,135,74,221,131,237,93,207,123,51,59,111,222,170,56,237,158,23,84,140,139,91,106,26,108,235,212,141,206,234,134,70,215,77,29,168,109,71,151,117,192,106,250,13,125,69,215,216,224,140,58,106,238,176,90,82,123,57,109,187,225,224,16,86,12,139,211,167,254,111,49,190,95,21,23,29,205,62,95,196,204,142,161,76,40,19,129,79,165,7,69,38,129,55,76,130,48,190,116,50,58,225,189,204,224,80,87,203,217,252,138,58,188,198,238,177,24,175,138,158,45,19,4,27,173,74,46,128,87,54,19,24,231,193,97,208,160,20,23,73,42,169,3,138,98,61,44,218,240,72,51,236,147,238,129,149,114,209,74,1,168,66,0,229,25,7,239,98,9,22,185,8,74,160,75,214,109,192,219,248,87,224,253,201,101,93,127,93,46,70,150,149,136,129,20,88,205,20,40,70,6,208,145,7,150,74,197,141,202,119,8,108,36,24,15,201,163,133,210,146,134,152,56,7,103,120,14,98,60,106,70,78,218,160,79,30,54,137,226,180,93,84,248,124,247,110,190,15,161,155,62,77,187,231,65,219,97,183,108,71,103,56,15,84,81,124,129,47,14,148,216,39,88,77,94,4,157,20,227,201,123,146,110,223,55,125,167,14,69,125,171,231,164,24,78,138,155,122,217,132,13,163,204,155,243,189,202,251,36,125,200,155,237,78,192,124,50,95,86,213,246,228,28,59,220,5,238,142,235,56,77,83,138,23,243,155,157,110,61,11,219,46,248,201,99,183,94,106,251,19,216,21,206,241,11,53,31,115,3,94,107,255,81,229,109,110,227,142,216,11,87,50,195,19,24,66,151,199,87,11,176,145,35,56,238,124,146,70,138,148,68,143,254,68,137,26,202,90,29,22,118,204,248,108,241,109,223,237,141,115,182,117,109,90,181,46,214,235,225,190,159,140,208,200,172,117,96,80,242,76,88,218,236,44,193,32,104,205,172,199,146,43,102,127,233,39,36,105,68,72,8,40,242,181,148,73,44,187,65,43,224,38,114,105,200,147,211,250,47,250,73,10,231,35,211,4,201,149,57,189,21,10,144,37,15,182,164,152,123,153,132,83,118,20,189,79,140,56,131,164,180,7,174,242,151,46,157,221,248,169,44,35,83,82,48,117,164,159,114,95,151,85,55,168,211,0,183,206,250,111,169,127,219,82,199,76,208,239,44,245,176,254,14,149,180,72,106,0,7,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "b98be122f42246da8bb7c0a3e83ee7cb",
							"BaseElements.CanceledChangeDataUserTask.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd");
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

		#region Class: PendingCatchSignalFlowElement

		/// <exclude/>
		public class PendingCatchSignalFlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public PendingCatchSignalFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "PendingCatchSignal";
				IsLogging = true;
				SchemaElementUId = new Guid("d7674af7-e199-4c72-821d-36401cba0d75");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",""$values"":[""a71adaea-3464-4dee-bb4f-c7a535450ad7""]}";
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{\""2018e7a5-23fd-4373-a3ad-61c145d13fde\"":{\""className\"":\""Terrasoft.InFilter\"",\""filterType\"":4,\""comparisonType\"":3,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""className\"":\""Terrasoft.ColumnExpression\"",\""expressionType\"":0,\""columnPath\"":\""Status\""},\""isAggregative\"":false,\""key\"":\""2018e7a5-23fd-4373-a3ad-61c145d13fde\"",\""dataValueType\"":10,\""leftExpressionCaption\"":\""Status\"",\""referenceSchemaName\"":\""CaseStatus\"",\""rightExpressions\"":[{\""className\"":\""Terrasoft.ParameterExpression\"",\""expressionType\"":2,\""parameter\"":{\""className\"":\""Terrasoft.Parameter\"",\""dataValueType\"":10,\""value\"":{\""Id\"":\""3859c6e7-cbcb-486b-ba53-77808fe6e593\"",\""Name\"":\""Pending\"",\""value\"":\""3859c6e7-cbcb-486b-ba53-77808fe6e593\"",\""displayValue\"":\""Pending\""}}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\"",\""key\"":\""2348f93f-39d3-43a1-b8ec-124dffb0e7f2\""}"",""dataSourceFilters"":""{\""items\"":{\""2018e7a5-23fd-4373-a3ad-61c145d13fde\"":{\""filterType\"":4,\""comparisonType\"":3,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""expressionType\"":0,\""columnPath\"":\""Status\""},\""rightExpressions\"":[{\""expressionType\"":2,\""parameter\"":{\""dataValueType\"":10,\""value\"":\""3859c6e7-cbcb-486b-ba53-77808fe6e593\""}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\""}""}";
				_recordId = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
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

		#region Class: PendingChangeDataUserTaskFlowElement

		/// <exclude/>
		public class PendingChangeDataUserTaskFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public PendingChangeDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "PendingChangeDataUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("41a9e18e-ba68-4a3e-9b87-c9033b84382e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Status = () => (Guid)(new Guid("4bdbb88f-58e6-df11-971b-001d60e938c6"));
				_recordColumnValues_Result = () => (Guid)(new Guid("e33e3598-1033-4d18-8212-534a95c78e71"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Status", () => _recordColumnValues_Status.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Result", () => _recordColumnValues_Result.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Status;
			internal Func<Guid> _recordColumnValues_Result;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,85,75,111,218,64,16,254,43,200,231,108,228,197,111,110,17,73,43,46,77,36,80,46,37,135,177,61,11,171,248,165,221,117,90,138,248,239,29,63,160,164,114,27,183,234,35,85,57,128,61,124,251,205,55,207,221,91,73,6,90,191,131,28,173,153,181,66,165,64,151,194,92,190,145,153,65,245,86,149,117,101,93,88,26,149,132,76,126,194,180,179,223,164,210,92,131,1,58,178,95,127,97,88,91,179,245,48,199,218,186,88,91,210,96,174,9,67,71,56,66,224,196,129,96,97,20,199,204,5,238,179,216,21,14,227,182,112,252,128,11,143,139,105,135,252,22,249,188,204,43,80,216,249,104,233,69,251,184,218,85,13,148,147,33,105,33,82,151,69,111,116,26,17,250,166,128,56,195,148,222,141,170,145,76,70,201,156,162,193,149,204,241,14,20,249,106,120,202,198,68,32,1,153,110,80,25,10,115,243,177,82,168,181,44,139,151,196,101,117,94,156,163,137,0,79,175,189,28,187,213,216,32,239,192,108,91,138,5,201,58,180,42,175,54,27,133,27,48,242,233,92,196,35,238,90,220,184,252,209,129,148,170,116,15,89,141,103,62,159,71,50,135,202,116,1,117,238,9,160,228,102,59,58,214,83,198,94,10,119,74,198,234,8,30,201,57,24,195,212,39,227,83,99,232,88,142,143,107,235,253,66,223,126,40,80,45,147,45,230,208,101,237,225,146,172,95,25,78,252,179,61,96,224,192,52,226,204,115,232,203,117,162,144,65,26,112,150,248,220,142,120,156,6,161,192,195,67,167,67,234,42,131,221,253,201,221,188,86,10,11,51,49,160,31,39,139,235,22,212,164,144,254,194,192,247,17,83,143,121,182,75,5,10,93,151,133,110,76,94,92,17,113,15,189,16,32,161,82,211,167,33,142,132,240,67,145,50,36,119,204,77,121,196,226,212,225,44,112,108,238,132,190,15,60,116,255,199,105,88,26,48,181,166,61,82,72,189,29,55,24,227,82,57,208,84,124,250,221,201,232,165,116,63,19,169,39,66,22,144,253,11,211,210,6,118,28,145,54,93,125,215,101,229,70,38,144,221,86,168,160,143,211,30,110,137,103,189,212,12,159,42,75,211,141,212,73,206,85,66,21,145,102,215,106,56,86,195,134,8,252,36,20,204,230,62,48,215,118,144,197,40,98,22,32,120,158,15,2,195,176,89,120,116,195,52,170,151,101,173,146,190,135,117,119,181,252,212,149,241,23,90,255,71,118,251,96,191,140,169,255,107,217,131,191,119,197,189,210,234,13,236,162,95,86,200,63,62,162,7,235,240,25,90,113,110,252,249,9,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,83,77,79,27,49,16,253,43,209,194,49,19,249,107,215,118,110,168,92,144,160,66,133,114,33,28,198,246,184,172,186,201,166,251,129,68,163,252,247,58,75,2,9,42,45,82,213,67,165,250,176,43,123,231,189,153,125,207,111,149,29,119,143,75,202,166,217,53,53,13,182,117,236,38,31,234,134,38,151,77,237,169,109,39,231,181,199,170,252,142,174,162,75,108,112,78,29,53,55,88,245,212,158,151,109,55,30,29,194,178,113,118,252,48,124,205,166,183,171,236,172,163,249,231,179,144,216,137,27,66,227,57,20,132,26,20,247,57,24,227,8,100,238,131,151,86,16,87,34,129,125,93,245,243,197,5,117,120,137,221,125,54,93,101,3,91,34,240,38,24,21,173,7,167,140,3,165,173,3,139,190,0,165,184,136,82,201,194,163,200,214,227,172,245,247,52,199,161,233,30,88,41,27,140,20,128,202,123,80,142,113,112,54,164,17,144,11,175,4,218,104,236,6,188,173,127,1,222,30,157,215,245,215,126,57,49,44,71,244,164,192,20,76,129,98,164,1,45,57,96,49,87,92,171,220,74,207,38,202,5,231,140,137,144,27,42,32,68,206,193,106,158,138,24,15,5,35,43,141,47,142,238,54,141,66,217,46,43,124,188,121,179,223,137,239,202,135,178,123,28,181,29,118,125,155,196,157,47,171,164,125,120,194,47,15,172,216,103,88,205,158,28,157,101,211,217,91,158,110,223,87,131,84,135,174,190,54,116,150,141,103,217,85,221,55,126,195,40,211,230,116,111,244,161,201,80,242,106,187,115,48,157,44,250,170,218,158,156,98,135,187,194,221,113,29,202,88,82,56,91,92,237,140,27,88,216,118,193,79,30,187,245,52,219,159,192,46,112,129,95,168,249,152,4,120,153,253,121,202,235,36,227,142,216,9,155,51,205,35,104,66,11,138,10,1,38,112,4,203,173,139,82,75,17,163,24,208,159,40,82,67,11,79,135,131,189,231,254,108,241,237,160,246,38,58,219,185,54,82,173,179,245,122,188,31,40,21,180,211,20,11,16,49,113,41,76,215,204,153,68,205,21,17,35,193,185,200,221,47,3,133,36,181,240,17,1,69,250,45,165,35,75,113,40,18,129,14,92,106,114,100,139,226,47,6,74,10,235,2,43,8,162,205,83,123,35,20,32,139,14,76,78,33,105,25,133,85,102,66,82,146,204,173,1,206,164,4,21,184,1,35,184,128,92,42,180,185,215,134,52,127,103,160,146,174,125,213,141,234,56,194,109,180,38,39,33,148,93,89,47,176,26,149,139,88,55,115,220,236,70,13,125,235,203,230,127,210,254,209,164,189,231,98,253,46,105,119,235,31,155,85,63,149,24,7,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "b98be122f42246da8bb7c0a3e83ee7cb",
							"BaseElements.PendingChangeDataUserTask.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd");
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

		#region Class: EscalationCatchSignalFlowElement

		/// <exclude/>
		public class EscalationCatchSignalFlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public EscalationCatchSignalFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "EscalationCatchSignal";
				IsLogging = true;
				SchemaElementUId = new Guid("9465eae5-e8e5-47ca-be99-632bc3fcb44c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",""$values"":[""70620d00-e4ea-48d1-9fdc-4572fcd8d41b"",""9147230c-ab53-4eb4-b0b4-ac78be6f8326""]}";
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{\""00341d8c-8bdd-4cd2-834e-302e3c28735b\"":{\""className\"":\""Terrasoft.IsNullFilter\"",\""filterType\"":2,\""comparisonType\"":2,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""className\"":\""Terrasoft.ColumnExpression\"",\""expressionType\"":0,\""columnPath\"":\""Owner\""},\""isAggregative\"":false,\""key\"":\""00341d8c-8bdd-4cd2-834e-302e3c28735b\"",\""dataValueType\"":10,\""leftExpressionCaption\"":\""Assignee\"",\""referenceSchemaName\"":\""Contact\"",\""isNull\"":false},\""bf5aa442-2113-479a-afd5-bf5d470a810d\"":{\""className\"":\""Terrasoft.IsNullFilter\"",\""filterType\"":2,\""comparisonType\"":2,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""className\"":\""Terrasoft.ColumnExpression\"",\""expressionType\"":0,\""columnPath\"":\""Group\""},\""isAggregative\"":false,\""key\"":\""bf5aa442-2113-479a-afd5-bf5d470a810d\"",\""dataValueType\"":10,\""leftExpressionCaption\"":\""Assignees group\"",\""referenceSchemaName\"":\""SysAdminUnit\"",\""isNull\"":false}},\""logicalOperation\"":1,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\"",\""key\"":\""dbb99e94-3913-4a55-a508-54e46e4e5b39\""}"",""dataSourceFilters"":""{\""items\"":{\""00341d8c-8bdd-4cd2-834e-302e3c28735b\"":{\""filterType\"":2,\""comparisonType\"":2,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""expressionType\"":0,\""columnPath\"":\""Owner\""},\""isNull\"":false},\""bf5aa442-2113-479a-afd5-bf5d470a810d\"":{\""filterType\"":2,\""comparisonType\"":2,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""expressionType\"":0,\""columnPath\"":\""Group\""},\""isNull\"":false}},\""logicalOperation\"":1,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\""}""}";
				_recordId = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
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

		#region Class: EscalationChangeDataUserTaskFlowElement

		/// <exclude/>
		public class EscalationChangeDataUserTaskFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public EscalationChangeDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "EscalationChangeDataUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("ad170079-791f-4bd7-98e0-472fdd5812f3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Status = () => (Guid)(new Guid("4bdbb88f-58e6-df11-971b-001d60e938c6"));
				_recordColumnValues_Result = () => (Guid)(new Guid("ca253900-6739-4afb-9626-0ea1a57d8394"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Status", () => _recordColumnValues_Status.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Result", () => _recordColumnValues_Result.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Status;
			internal Func<Guid> _recordColumnValues_Result;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,85,75,111,218,64,16,254,43,200,231,108,228,247,218,220,34,146,86,92,154,72,160,92,234,28,198,246,44,172,226,151,118,215,105,41,226,191,119,108,3,37,21,109,220,170,143,84,229,0,246,199,183,51,223,60,119,107,101,5,104,253,14,74,180,166,214,18,149,2,93,11,115,249,70,22,6,213,91,85,183,141,117,97,105,84,18,10,249,9,243,1,191,201,165,185,6,3,116,100,155,124,177,144,88,211,228,188,141,196,186,72,44,105,176,212,196,161,35,156,3,247,68,20,178,40,78,99,230,219,65,192,32,23,41,203,210,60,230,110,106,135,14,231,3,243,91,198,103,117,217,128,194,193,71,111,94,244,143,203,77,211,81,29,2,178,158,34,117,93,237,65,175,19,161,111,42,72,11,204,233,221,168,22,9,50,74,150,20,13,46,101,137,119,160,200,87,103,167,238,32,34,9,40,116,199,42,80,152,155,143,141,66,173,101,93,189,36,174,104,203,234,148,77,6,240,248,186,151,99,247,26,59,230,29,152,117,111,98,78,178,118,189,202,171,213,74,225,10,140,124,58,21,241,136,155,158,55,46,127,116,32,167,42,221,67,209,226,137,207,231,145,204,160,49,67,64,131,123,34,40,185,90,143,142,245,152,177,151,194,117,9,108,14,228,145,54,207,198,224,134,4,62,117,192,96,229,240,152,88,239,231,250,246,67,133,106,145,173,177,132,33,107,15,151,132,126,5,28,237,79,183,128,220,3,55,118,88,224,209,151,239,197,17,101,146,59,44,11,29,59,118,210,156,71,2,119,15,131,14,169,155,2,54,247,71,119,179,86,41,172,204,196,128,126,156,204,175,123,82,151,66,250,43,69,17,57,57,79,153,16,33,103,62,120,46,3,63,118,153,27,162,235,6,81,156,123,34,166,82,211,167,107,130,144,251,16,251,25,11,99,238,19,57,245,88,42,220,148,133,129,15,142,8,60,223,137,240,127,156,134,133,1,211,106,218,35,149,212,235,113,131,49,46,149,103,154,202,113,191,59,25,123,41,195,207,68,234,137,144,21,20,255,194,180,244,129,29,70,164,79,215,190,235,138,122,37,51,40,110,27,84,176,143,211,62,223,18,207,122,169,27,62,85,215,102,24,169,163,156,171,140,42,34,205,166,215,112,168,70,20,114,170,5,122,12,56,45,39,223,183,109,6,89,148,51,39,203,93,238,113,223,179,49,160,186,210,13,211,169,94,212,173,202,246,61,172,135,171,229,167,174,140,191,208,250,63,178,219,207,246,203,152,250,191,150,61,248,123,87,220,43,173,222,153,93,244,203,10,249,199,71,116,103,237,62,3,173,8,87,151,249,9,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,77,111,19,49,16,253,43,209,210,99,38,242,215,122,237,220,16,229,80,169,69,21,45,189,52,61,140,237,49,93,177,201,134,253,168,84,162,252,119,156,77,66,147,138,66,37,196,1,9,31,118,101,123,222,204,243,27,63,175,178,147,238,113,73,217,52,187,166,166,193,182,142,221,228,93,221,208,228,178,169,61,181,237,228,188,246,88,149,223,208,85,116,137,13,206,169,163,230,6,171,158,218,243,178,237,198,163,99,88,54,206,78,30,134,221,108,122,187,202,206,58,154,127,58,11,41,187,55,82,120,100,30,10,167,35,40,105,61,24,174,243,52,149,220,56,229,131,212,54,129,125,93,245,243,197,5,117,120,137,221,125,54,93,101,67,182,33,65,48,42,38,152,83,198,129,42,172,3,139,94,131,82,92,68,169,164,246,40,178,245,56,107,253,61,205,113,40,122,0,86,202,134,196,0,80,121,15,202,49,14,206,134,28,12,114,225,149,64,27,141,221,128,119,241,79,192,219,55,231,117,253,165,95,78,12,203,17,61,41,48,154,41,80,140,10,64,75,14,88,204,21,47,84,110,165,103,19,229,130,115,198,68,200,13,105,8,145,115,176,5,79,65,140,7,205,200,74,227,245,155,187,77,161,80,182,203,10,31,111,94,172,247,214,119,229,67,217,61,142,218,14,187,190,77,226,206,151,85,210,62,108,241,203,163,86,28,102,88,205,182,29,157,101,211,217,75,61,221,253,175,6,169,142,187,250,188,161,179,108,60,203,174,234,190,241,155,140,50,77,78,15,168,15,69,134,144,103,211,125,7,211,202,162,175,170,221,202,41,118,184,15,220,47,215,161,140,37,133,179,197,213,190,113,67,22,182,27,240,147,207,126,108,185,253,9,236,2,23,248,153,154,15,73,128,39,238,63,88,94,39,25,247,137,157,176,57,43,120,132,130,208,130,34,45,192,4,142,96,185,117,81,22,82,196,40,6,244,71,138,212,208,194,211,49,177,215,220,159,29,190,29,212,222,88,103,199,107,35,213,58,91,175,199,135,134,82,138,229,54,58,177,189,200,74,219,196,69,8,15,44,207,77,160,24,165,101,225,151,134,66,146,133,240,17,1,69,58,150,42,34,75,118,208,10,120,17,184,44,200,145,213,250,47,26,74,10,235,2,211,4,209,230,169,188,17,10,144,69,7,38,167,144,180,140,194,42,51,73,158,206,211,65,24,232,66,38,213,49,237,91,45,52,48,66,142,121,145,24,88,245,74,67,37,93,251,170,27,213,113,132,59,107,77,222,183,233,105,195,174,172,23,163,134,190,246,101,243,223,93,255,168,187,94,115,153,126,231,174,187,245,119,149,238,193,24,12,7,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "b98be122f42246da8bb7c0a3e83ee7cb",
							"BaseElements.EscalationChangeDataUserTask.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd");
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

		#region Class: ReadCaseCountDataUserTaskFlowElement

		/// <exclude/>
		public class ReadCaseCountDataUserTaskFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadCaseCountDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadCaseCountDataUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("e056d00a-f1bb-41c3-b364-ba74262573fd");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,77,111,219,56,16,253,43,134,206,101,64,73,164,62,124,43,178,238,34,151,54,216,4,189,212,57,140,200,161,35,84,150,4,138,206,110,214,240,127,223,161,100,59,78,19,187,74,209,96,11,164,39,203,163,225,211,124,188,55,156,117,160,42,232,186,143,176,196,96,26,92,163,181,208,53,198,157,125,40,43,135,246,79,219,172,218,224,93,208,161,45,161,42,255,69,61,216,103,186,116,127,128,3,58,178,158,63,32,204,131,233,252,121,140,121,240,110,30,148,14,151,29,249,208,17,145,25,147,96,36,88,42,226,136,9,201,21,3,13,138,165,104,100,196,77,4,25,152,193,243,24,248,69,61,192,247,200,166,127,188,190,111,189,151,32,131,106,150,45,216,178,107,234,173,49,246,223,239,102,53,20,21,106,250,239,236,10,201,228,108,185,164,68,240,186,92,226,37,88,250,140,199,105,188,137,156,12,84,157,247,170,208,184,217,63,173,197,174,43,155,250,116,92,231,77,181,90,214,135,222,4,128,251,191,219,112,120,31,163,247,188,4,119,219,67,156,67,71,111,54,125,156,239,23,11,139,11,112,229,221,97,24,95,241,190,247,28,87,60,58,160,169,69,159,161,90,225,246,171,33,127,146,204,57,180,110,200,105,23,1,185,88,52,104,177,86,120,165,110,113,9,251,44,31,28,202,197,237,1,136,111,234,151,19,53,217,87,246,123,101,137,200,216,238,156,79,215,249,242,193,237,153,76,163,132,140,119,222,48,160,236,30,231,193,151,139,238,211,223,53,218,33,181,161,182,55,103,100,253,198,48,171,112,137,181,155,174,51,35,83,129,178,96,105,66,37,23,105,20,177,156,67,206,98,101,18,169,99,94,0,100,27,58,176,15,104,186,78,65,134,32,178,136,41,149,36,76,132,50,101,144,38,146,241,84,27,192,28,185,73,10,127,100,86,187,210,221,15,140,153,174,1,57,10,169,128,41,145,75,38,12,210,169,56,215,44,134,34,141,210,12,195,36,76,55,55,67,186,101,215,86,112,255,121,159,213,95,8,122,162,168,61,19,95,9,82,158,237,220,196,235,109,210,152,9,213,120,85,185,178,94,76,136,114,21,42,223,240,179,11,221,35,249,31,58,111,162,72,166,89,92,48,224,146,40,21,39,49,43,66,76,88,14,5,134,40,83,13,57,81,106,179,217,220,120,130,166,69,146,21,66,43,150,112,12,89,95,156,12,243,144,1,70,25,167,114,128,130,248,116,247,78,140,6,76,120,172,184,7,207,208,48,193,61,187,165,84,76,199,20,67,154,139,88,134,234,141,141,134,43,7,110,213,141,27,14,227,202,247,242,225,176,139,225,196,120,120,79,204,186,35,66,31,186,254,234,131,162,207,250,96,80,108,245,16,231,66,139,34,19,76,102,164,2,109,194,144,229,105,88,48,206,67,77,164,207,227,76,37,61,222,254,131,23,245,164,181,205,194,135,217,191,120,152,56,163,177,158,168,250,17,230,78,124,73,161,163,60,215,5,147,154,35,19,58,85,44,203,105,86,68,40,37,42,174,12,202,228,183,62,142,234,99,92,249,126,235,227,59,250,200,94,170,143,143,141,155,116,14,172,67,253,173,62,198,98,61,209,199,35,204,94,31,158,1,85,179,40,21,84,159,90,180,176,109,79,248,60,133,31,113,223,111,12,182,105,220,145,166,245,17,236,72,52,238,2,60,22,13,255,201,209,112,218,16,178,88,132,76,69,153,102,66,196,138,229,196,113,166,133,49,68,235,72,208,22,66,209,208,30,239,187,123,213,172,172,194,97,2,116,195,2,255,67,139,249,255,48,56,94,182,70,31,209,214,24,173,188,177,117,242,149,151,192,31,90,238,126,81,122,29,94,53,63,145,96,143,198,236,216,149,225,197,11,193,219,174,233,168,107,230,181,47,145,87,189,19,54,193,230,63,21,145,70,10,208,17,0,0 })));
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

		#region Class: CompleteTasksChangeDataUserTaskFlowElement

		/// <exclude/>
		public class CompleteTasksChangeDataUserTaskFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public CompleteTasksChangeDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "CompleteTasksChangeDataUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("3fceae6f-a629-4ceb-92b4-3aed7434c92b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Status = () => (Guid)(new Guid("4bdbb88f-58e6-df11-971b-001d60e938c6"));
				_recordColumnValues_Result = () => (Guid)(new Guid("ef46415c-8dc6-43cb-9caa-36e5a6651dcf"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Status", () => _recordColumnValues_Status.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Result", () => _recordColumnValues_Result.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Status;
			internal Func<Guid> _recordColumnValues_Result;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,86,75,115,219,54,16,254,43,26,158,3,15,248,2,8,221,50,174,218,241,165,241,212,158,92,34,31,150,192,66,230,148,34,53,32,228,86,213,232,191,119,65,234,149,90,86,20,79,30,205,228,34,146,171,197,98,31,223,183,187,235,72,215,208,117,191,195,28,163,113,116,143,206,65,215,90,127,245,107,85,123,116,191,185,118,185,136,222,68,29,186,10,234,234,31,52,131,124,98,42,255,11,120,160,35,235,233,193,194,52,26,79,79,219,152,70,111,166,81,229,113,222,145,14,29,17,146,243,20,139,152,9,197,145,101,60,45,152,50,160,153,150,89,145,115,1,89,174,237,160,249,146,241,155,102,48,223,91,182,253,235,253,106,17,180,50,18,232,118,190,0,87,117,109,179,21,166,225,254,110,210,64,89,163,161,111,239,150,72,34,239,170,57,5,130,247,213,28,111,193,209,53,193,78,27,68,164,100,161,238,130,86,141,214,79,254,94,56,236,186,170,109,206,251,117,221,214,203,121,115,172,77,6,112,255,185,117,135,247,62,6,205,91,240,143,189,137,107,232,232,159,77,239,231,219,217,204,225,12,124,245,116,236,198,159,184,234,53,47,75,30,29,48,84,162,247,80,47,113,123,107,204,159,5,115,13,11,63,196,180,243,128,84,28,90,116,216,104,188,211,143,56,135,125,148,7,133,106,246,120,100,36,20,245,195,153,156,236,51,251,169,180,36,36,92,236,148,207,231,249,246,160,118,34,210,68,144,240,41,8,6,43,187,215,105,244,225,166,123,247,87,131,110,8,109,200,237,195,21,73,255,35,152,212,56,199,198,143,215,133,205,101,134,121,201,164,72,50,150,201,36,97,138,131,98,169,182,34,55,41,47,1,138,13,29,216,59,52,94,75,200,99,200,138,132,105,45,4,203,226,92,50,144,34,103,92,26,11,168,144,91,81,134,35,147,198,87,126,53,32,102,188,6,228,72,165,3,166,51,149,179,204,34,157,74,149,97,41,148,50,145,5,198,34,150,155,135,33,220,170,91,212,176,122,191,143,234,15,4,51,210,84,158,81,200,4,49,207,117,126,20,248,54,106,237,136,114,188,172,125,213,204,70,4,185,26,117,40,248,213,141,233,45,133,7,157,47,51,91,112,165,5,75,172,42,89,150,201,152,41,45,45,75,19,76,141,142,99,128,84,19,56,55,155,135,0,80,195,233,219,74,100,177,9,218,225,77,25,43,25,138,194,24,110,149,41,148,248,201,216,251,150,178,250,20,138,73,119,207,90,183,186,140,201,151,37,242,53,76,222,121,113,134,205,207,93,254,17,152,221,71,126,196,236,45,128,109,30,235,76,100,41,203,11,20,204,216,152,0,44,227,146,113,30,27,193,81,165,133,30,50,121,184,176,29,153,182,23,29,154,195,197,86,158,17,112,107,109,199,16,203,69,145,148,88,50,203,21,117,0,149,24,6,42,167,159,68,36,66,165,154,67,146,127,10,137,129,3,248,18,77,226,31,147,38,119,30,252,178,163,254,212,84,221,227,101,28,185,44,149,167,144,146,156,229,200,214,149,225,49,170,186,145,173,26,168,79,145,224,66,184,126,59,10,36,71,160,237,211,69,176,11,169,172,219,89,165,161,126,183,64,7,219,56,249,105,72,124,132,165,48,43,93,219,250,23,250,67,239,195,174,26,156,23,152,202,52,103,52,194,12,203,82,160,221,3,139,156,201,184,72,227,210,38,74,2,80,93,105,103,12,94,223,181,75,167,183,24,238,134,101,241,85,75,224,119,152,16,159,183,178,189,208,54,47,193,192,79,182,186,124,229,133,227,127,138,148,211,235,193,23,68,205,71,99,241,210,65,246,217,195,234,59,140,160,87,78,149,147,45,252,85,137,253,214,205,118,19,109,254,5,85,154,181,8,149,15,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,83,203,110,219,48,16,252,21,131,201,209,107,240,37,137,244,173,104,46,1,146,34,168,211,94,226,28,150,228,178,17,42,75,134,30,1,82,195,255,94,90,177,155,56,104,218,0,69,15,5,202,131,4,82,59,179,195,89,205,134,157,246,15,107,98,115,118,77,109,139,93,19,251,217,251,166,165,217,85,219,120,234,186,217,69,227,177,42,191,161,171,232,10,91,92,81,79,237,103,172,6,234,46,202,174,159,78,142,97,108,202,78,239,199,175,108,126,179,97,231,61,173,62,157,135,196,78,153,17,162,240,30,76,238,13,104,161,28,32,82,0,12,49,16,113,158,57,233,19,216,55,213,176,170,47,169,199,43,236,239,216,124,195,70,182,68,224,77,48,58,90,15,78,27,7,186,176,14,44,250,28,180,22,50,42,173,114,143,146,109,167,172,243,119,180,194,177,233,51,176,214,54,24,37,1,117,146,160,29,23,224,108,200,192,160,144,94,75,180,209,216,29,120,95,255,4,188,57,185,104,154,175,195,122,102,120,134,232,73,39,253,92,131,230,84,0,90,114,192,99,166,69,161,51,171,60,159,105,23,156,51,38,66,102,40,135,16,133,0,91,136,84,196,69,200,57,89,101,124,126,114,187,107,20,202,110,93,225,195,231,87,251,189,243,125,121,95,246,15,147,174,199,126,232,146,185,171,117,149,188,15,143,248,245,209,40,158,51,108,150,143,19,93,178,249,242,181,153,238,223,139,209,170,227,169,190,28,232,146,77,151,108,209,12,173,223,49,170,180,57,123,38,125,108,50,150,188,216,30,38,152,78,234,161,170,246,39,103,216,227,161,240,112,220,132,50,150,20,206,235,197,97,112,35,11,223,47,248,201,227,176,30,181,253,9,236,18,107,252,66,237,135,100,192,147,246,31,42,175,147,141,7,98,39,109,198,11,17,161,32,180,160,41,151,96,130,64,176,194,186,168,10,37,99,148,35,250,35,69,106,169,246,116,44,236,45,255,207,30,223,141,110,239,162,179,215,181,179,106,203,182,219,233,81,160,172,44,10,101,16,178,232,146,32,163,119,209,42,2,136,96,163,34,165,41,137,250,101,160,48,85,72,31,17,80,166,107,233,34,242,20,135,92,131,40,130,80,5,57,178,121,254,23,3,165,164,117,129,231,4,209,102,169,189,145,26,144,71,7,38,163,144,188,140,210,106,51,163,168,115,45,178,116,181,176,139,186,242,41,244,30,17,84,78,25,230,121,38,130,143,111,12,84,242,117,168,250,73,19,39,184,143,214,108,145,188,233,203,166,158,196,102,168,255,7,235,223,12,214,91,254,163,223,5,235,118,251,29,75,12,150,132,7,7,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "b98be122f42246da8bb7c0a3e83ee7cb",
							"BaseElements.CompleteTasksChangeDataUserTask.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd");
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

		#region Class: CancelTasksChangeDataUserTaskFlowElement

		/// <exclude/>
		public class CancelTasksChangeDataUserTaskFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public CancelTasksChangeDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "CancelTasksChangeDataUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("484f3905-6b35-4c22-a574-50b567b9a99b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Status = () => (Guid)(new Guid("201cfba8-58e6-df11-971b-001d60e938c6"));
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

			private Guid _entitySchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,86,75,115,219,54,16,254,43,26,158,3,15,64,2,124,232,150,113,213,142,47,141,167,246,228,18,249,176,0,22,50,167,20,169,1,41,183,170,70,255,189,11,82,175,212,178,162,120,242,104,38,39,73,171,197,98,247,219,239,219,197,58,50,21,180,237,239,48,199,104,28,221,163,247,208,54,174,187,250,181,172,58,244,191,249,102,185,136,222,68,45,250,18,170,242,31,180,131,125,98,203,238,23,232,128,142,172,167,135,8,211,104,60,61,29,99,26,189,153,70,101,135,243,150,124,232,136,19,218,89,149,199,44,214,210,49,153,20,5,211,166,72,152,142,179,220,230,198,36,78,137,193,243,165,224,55,245,16,190,143,236,250,175,247,171,69,240,146,100,48,205,124,1,190,108,155,122,107,76,194,253,237,164,6,93,161,165,223,157,95,34,153,58,95,206,169,16,188,47,231,120,11,158,174,9,113,154,96,34,39,7,85,27,188,42,116,221,228,239,133,199,182,45,155,250,124,94,215,77,181,156,215,199,222,20,0,247,63,183,233,240,62,199,224,121,11,221,99,31,226,26,90,250,103,211,231,249,118,54,243,56,131,174,124,58,78,227,79,92,245,158,151,129,71,7,44,181,232,61,84,75,220,222,42,248,179,98,174,97,209,13,53,237,50,32,23,143,14,61,214,6,239,204,35,206,97,95,229,193,161,156,61,30,5,9,77,253,112,6,147,61,178,159,130,37,38,227,98,231,124,30,231,219,131,219,137,74,227,148,140,79,193,48,68,217,125,157,70,31,110,218,119,127,213,232,135,210,6,108,31,174,200,250,31,195,164,194,57,214,221,120,157,59,149,73,84,154,101,105,44,153,204,226,152,21,28,10,150,24,151,42,155,112,13,144,111,232,192,62,161,241,58,3,37,64,82,131,140,73,83,38,133,202,24,100,169,98,60,179,14,176,64,238,82,29,142,76,234,174,236,86,3,99,198,107,64,142,82,25,96,70,22,138,73,135,116,42,41,44,75,64,103,212,89,20,169,200,54,15,67,185,101,187,168,96,245,126,95,213,31,8,118,100,168,61,163,128,4,41,207,183,221,40,232,109,212,184,17,97,188,172,186,178,158,141,136,114,21,154,208,240,171,27,219,71,10,31,116,30,173,210,32,84,204,92,14,49,21,73,185,67,150,40,150,196,60,167,244,243,56,46,52,145,115,179,121,8,4,149,25,7,37,141,96,133,206,2,1,93,194,64,99,206,50,237,242,28,37,23,188,215,216,207,164,222,183,132,234,83,104,38,221,61,107,252,234,50,37,95,6,228,107,148,188,203,226,140,154,159,167,252,35,40,187,175,252,72,217,91,2,211,200,51,50,149,9,83,57,166,204,58,65,152,102,66,51,206,133,77,57,22,73,110,210,62,222,225,194,102,100,155,222,116,24,14,23,71,121,38,192,109,180,189,66,148,84,133,53,138,9,39,144,73,99,115,86,56,65,179,0,51,157,36,121,134,86,240,79,49,49,104,0,95,146,137,248,49,101,114,215,65,183,108,105,62,213,101,251,120,161,70,46,130,242,20,83,226,179,26,217,166,50,124,140,202,118,228,202,26,170,83,34,184,144,174,223,78,2,241,17,105,123,184,136,118,1,202,170,153,149,6,170,119,11,244,176,173,147,159,166,196,71,92,10,187,210,55,77,247,194,124,232,115,216,117,35,23,146,199,49,8,6,128,52,177,132,227,76,103,41,208,74,116,90,104,107,149,224,57,245,149,222,140,33,235,187,102,233,205,150,195,237,240,88,124,213,35,240,59,108,136,207,123,178,189,48,54,47,225,192,79,246,116,249,202,15,142,255,41,83,78,63,15,190,32,107,62,90,139,151,46,178,207,94,86,223,97,5,189,114,171,156,28,225,175,2,246,91,15,219,77,180,249,23,138,153,2,35,149,15,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,207,107,219,48,20,254,87,138,218,99,94,144,108,217,150,114,27,237,37,144,142,176,116,189,52,61,60,73,79,171,153,19,7,91,46,100,33,255,251,20,215,94,147,178,194,96,58,200,232,233,125,63,120,159,124,96,55,97,191,35,54,99,15,212,52,216,214,62,76,111,235,134,166,203,166,182,212,182,211,69,109,177,42,127,161,169,104,137,13,110,40,80,243,136,85,71,237,162,108,195,228,234,18,198,38,236,230,181,191,101,179,167,3,155,7,218,124,159,187,200,110,40,79,149,17,9,136,220,33,72,174,20,152,44,45,32,205,45,71,133,162,176,220,71,176,173,171,110,179,189,167,128,75,12,47,108,118,96,61,91,36,176,202,41,233,181,5,35,149,1,89,104,3,26,109,14,82,138,196,167,50,242,96,194,142,19,214,218,23,218,96,47,122,6,150,82,59,149,38,128,210,90,144,134,11,48,218,101,16,133,19,43,19,212,94,233,19,120,232,127,7,62,93,47,234,250,103,183,155,42,158,33,90,146,160,114,46,163,127,42,0,53,25,224,62,147,162,144,153,78,45,159,38,92,88,111,80,65,166,40,7,231,133,0,93,136,216,196,133,203,57,233,84,217,252,250,249,36,228,202,118,87,225,254,241,83,189,47,54,148,175,101,216,95,181,1,67,215,78,111,113,107,169,34,247,6,223,93,36,113,78,112,88,191,5,186,102,179,245,103,145,14,223,85,63,169,203,80,63,230,185,102,147,53,91,213,93,99,79,140,105,60,220,157,57,239,69,250,150,15,199,49,192,88,217,118,85,53,84,238,48,224,216,56,150,107,87,250,146,220,124,187,26,115,235,89,248,176,224,47,219,184,222,188,253,15,236,30,183,248,131,154,175,113,0,239,222,255,184,124,136,99,28,137,77,162,51,94,8,15,5,161,6,73,121,2,202,9,4,45,180,241,105,145,38,222,39,61,250,27,121,106,40,102,117,105,236,95,158,207,128,111,251,105,159,254,156,193,215,105,84,71,118,60,62,31,127,3,132,44,58,181,173,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "b98be122f42246da8bb7c0a3e83ee7cb",
							"BaseElements.CancelTasksChangeDataUserTask.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd");
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

		#region Class: RescheduledCatchSignalFlowElement

		/// <exclude/>
		public class RescheduledCatchSignalFlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public RescheduledCatchSignalFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "RescheduledCatchSignal";
				IsLogging = true;
				SchemaElementUId = new Guid("e615c390-d90a-4a82-a7af-2fd1be051086");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",""$values"":[""ae372cfa-a21f-47f0-8a64-17d137ebe966"",""c8d84f9c-b48b-479b-9ac6-4412f3436ca2""]}";
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{\""4ec38736-8c00-4dcc-8c9f-c250f63b860a\"":{\""className\"":\""Terrasoft.InFilter\"",\""filterType\"":4,\""comparisonType\"":3,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""className\"":\""Terrasoft.ColumnExpression\"",\""expressionType\"":0,\""columnPath\"":\""Status\""},\""isAggregative\"":false,\""key\"":\""4ec38736-8c00-4dcc-8c9f-c250f63b860a\"",\""dataValueType\"":10,\""leftExpressionCaption\"":\""Status\"",\""referenceSchemaName\"":\""ActivityStatus\"",\""rightExpressions\"":[{\""className\"":\""Terrasoft.ParameterExpression\"",\""expressionType\"":2,\""parameter\"":{\""className\"":\""Terrasoft.Parameter\"",\""dataValueType\"":10,\""value\"":{\""Id\"":\""4bdbb88f-58e6-df11-971b-001d60e938c6\"",\""Name\"":\""Completed\"",\""value\"":\""4bdbb88f-58e6-df11-971b-001d60e938c6\"",\""displayValue\"":\""Completed\""}}}]},\""645cd7c9-33b7-4b71-9f8b-a0fce4bac1af\"":{\""className\"":\""Terrasoft.InFilter\"",\""filterType\"":4,\""comparisonType\"":3,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""className\"":\""Terrasoft.ColumnExpression\"",\""expressionType\"":0,\""columnPath\"":\""Result\""},\""isAggregative\"":false,\""key\"":\""645cd7c9-33b7-4b71-9f8b-a0fce4bac1af\"",\""dataValueType\"":10,\""leftExpressionCaption\"":\""Result\"",\""referenceSchemaName\"":\""ActivityResult\"",\""rightExpressions\"":[{\""className\"":\""Terrasoft.ParameterExpression\"",\""expressionType\"":2,\""parameter\"":{\""className\"":\""Terrasoft.Parameter\"",\""dataValueType\"":10,\""value\"":{\""Id\"":\""d87d32bc-f36b-1410-6598-00155d043204\"",\""Name\"":\""Rescheduled\"",\""value\"":\""d87d32bc-f36b-1410-6598-00155d043204\"",\""displayValue\"":\""Rescheduled\""}}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Activity\"",\""key\"":\""0a46b150-32d2-40e9-bf57-933b745bfc9a\""}"",""dataSourceFilters"":""{\""items\"":{\""4ec38736-8c00-4dcc-8c9f-c250f63b860a\"":{\""filterType\"":4,\""comparisonType\"":3,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""expressionType\"":0,\""columnPath\"":\""Status\""},\""rightExpressions\"":[{\""expressionType\"":2,\""parameter\"":{\""dataValueType\"":10,\""value\"":\""4bdbb88f-58e6-df11-971b-001d60e938c6\""}}]},\""645cd7c9-33b7-4b71-9f8b-a0fce4bac1af\"":{\""filterType\"":4,\""comparisonType\"":3,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""expressionType\"":0,\""columnPath\"":\""Result\""},\""rightExpressions\"":[{\""expressionType\"":2,\""parameter\"":{\""dataValueType\"":10,\""value\"":\""d87d32bc-f36b-1410-6598-00155d043204\""}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Activity\""}""}";
				_recordId = () => (Guid)((process.CurrentTaskId));
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

		#region Class: AddRescheduledTaskUserTaskFlowElement

		/// <exclude/>
		public class AddRescheduledTaskUserTaskFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddRescheduledTaskUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddRescheduledTaskUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("68ef5315-41e9-4b68-96d5-fdca74d37520");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_ActivityCategory = () => (Guid)(new Guid("f51c4643-58e6-df11-971b-001d60e938c6"));
				_recordDefValues_Title = () => new LocalizableString("Diagnose and resolve incident #"+((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Number").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<string>("Number") : null)));
				_recordDefValues_Case = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_recordDefValues_Owner = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_recordDefValues_Contact = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
				_recordDefValues_Account = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_ActivityCategory", () => _recordDefValues_ActivityCategory.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Title", () => _recordDefValues_Title.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Case", () => _recordDefValues_Case.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Owner", () => _recordDefValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Account", () => _recordDefValues_Account.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_ActivityCategory;
			internal Func<string> _recordDefValues_Title;
			internal Func<Guid> _recordDefValues_Case;
			internal Func<Guid> _recordDefValues_Owner;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_Account;

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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,151,75,111,27,71,12,128,255,138,176,206,173,30,97,222,15,221,130,36,5,12,36,105,144,164,185,216,62,112,134,28,71,168,188,107,236,174,82,184,134,254,123,185,178,157,216,65,163,56,109,141,38,168,117,144,176,163,33,135,75,242,35,135,23,205,163,241,252,140,154,69,243,150,250,30,134,174,142,243,39,93,79,243,87,125,87,104,24,230,207,187,2,171,229,31,144,87,244,10,122,56,165,145,250,119,176,90,211,240,124,57,140,251,179,219,98,205,126,243,232,195,246,223,102,113,120,209,28,140,116,250,235,1,178,118,27,129,84,46,94,84,71,32,172,11,81,36,68,43,100,80,53,185,88,162,81,150,133,75,183,90,159,182,47,104,132,87,48,190,111,22,23,205,86,27,43,40,81,217,10,65,9,146,42,11,107,180,19,80,34,138,136,22,116,50,132,202,196,102,179,223,12,229,61,157,194,246,208,27,194,214,38,140,70,11,176,165,8,155,165,18,57,161,19,17,148,46,86,67,170,49,77,194,87,251,63,9,30,238,61,239,186,223,214,103,243,228,21,105,25,189,96,9,62,30,117,16,89,38,39,172,204,138,188,69,95,138,156,87,167,138,245,214,8,23,201,11,172,74,137,20,216,90,41,21,122,73,201,196,226,247,142,167,131,112,57,156,173,224,252,221,23,207,123,92,198,229,135,229,120,62,43,48,210,73,215,159,207,223,118,51,236,46,165,207,110,5,226,166,252,197,209,101,60,143,154,197,209,151,34,122,245,251,102,235,168,219,49,253,60,156,71,205,254,81,243,166,91,247,101,210,104,248,225,233,13,195,183,135,108,183,124,246,120,29,63,94,105,215,171,213,213,202,83,24,225,122,227,245,114,135,203,186,36,60,104,223,92,135,109,171,69,94,125,196,95,124,93,127,46,109,251,39,98,47,160,133,19,234,95,178,3,62,217,254,209,202,183,236,198,107,197,89,39,55,101,170,8,4,73,88,242,154,243,78,129,72,42,229,106,130,209,181,234,173,244,107,170,212,83,91,232,182,97,119,201,158,43,249,97,235,237,9,156,43,187,38,87,109,154,205,102,255,38,78,213,107,7,186,104,161,80,34,171,113,78,228,200,72,68,175,201,162,115,174,16,237,196,201,98,169,18,140,18,161,98,96,139,50,8,144,210,10,178,202,100,21,156,177,70,253,251,56,77,249,3,39,109,55,208,12,90,156,245,252,182,171,15,52,91,182,101,137,212,142,179,189,163,230,167,195,189,195,131,225,151,223,91,234,47,125,184,168,176,26,232,120,206,171,159,45,60,91,209,41,75,45,46,98,117,193,146,203,34,120,109,133,13,90,139,36,57,80,166,84,239,208,200,12,16,55,44,240,49,217,23,23,1,156,2,27,181,40,197,123,97,149,11,2,130,119,92,143,176,2,37,146,213,231,73,228,89,59,50,133,79,182,126,100,169,28,11,249,108,133,78,133,171,152,44,28,71,2,126,123,151,107,200,161,88,105,97,115,188,27,241,187,249,224,53,1,50,251,188,9,57,33,231,63,47,251,97,156,45,57,254,179,174,78,50,235,213,184,108,79,102,28,224,21,113,169,232,218,249,203,245,105,166,254,161,64,252,39,5,194,21,48,174,42,201,128,51,12,182,120,78,167,228,65,152,104,16,60,84,40,181,236,42,16,119,54,236,174,5,34,197,28,188,245,40,208,85,174,56,84,185,246,4,43,69,12,32,3,21,84,20,226,238,2,193,217,140,197,6,17,157,230,146,135,146,4,248,10,162,106,86,157,181,100,21,230,62,250,237,247,11,63,144,36,203,129,22,197,78,165,187,18,75,153,132,194,64,14,58,68,82,94,133,175,193,255,119,192,62,192,7,168,127,200,174,175,84,64,222,148,68,212,129,19,134,123,170,136,150,239,132,138,179,78,41,110,209,169,224,55,65,77,21,48,2,39,120,160,80,153,73,176,34,3,231,162,148,37,243,61,56,57,136,106,39,212,85,6,195,16,27,17,18,114,153,10,158,11,22,249,36,146,167,226,124,74,198,166,123,232,250,223,51,212,65,122,45,145,179,133,236,52,151,112,124,69,170,88,166,9,69,215,130,236,85,149,239,3,234,199,195,176,60,105,137,30,208,254,49,209,246,153,140,119,74,196,74,122,74,54,134,28,145,105,138,210,160,245,220,245,209,124,19,218,144,37,183,91,109,132,158,248,182,134,47,16,145,103,71,110,46,49,199,232,162,11,89,239,68,59,87,128,84,184,44,20,227,163,176,86,242,27,153,237,133,36,120,47,43,84,101,239,101,62,254,126,209,246,38,249,106,61,77,253,154,171,101,205,28,45,199,211,82,212,54,250,84,171,180,217,220,7,218,79,186,118,132,50,62,144,253,64,246,68,182,169,149,201,246,133,251,138,159,70,117,172,34,219,24,133,210,198,241,240,111,188,146,187,201,174,89,162,175,220,152,84,224,81,211,2,79,233,160,120,224,7,155,189,53,197,163,252,191,145,157,149,51,82,151,196,115,119,225,131,48,177,71,42,191,20,7,72,166,154,0,43,169,123,105,218,165,116,235,246,129,236,31,147,108,237,48,20,5,89,40,36,201,23,188,9,133,169,77,74,205,131,157,131,160,209,211,215,200,62,222,252,9,161,153,34,109,49,23,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "b98be122f42246da8bb7c0a3e83ee7cb",
							"BaseElements.AddRescheduledTaskUserTask.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd");
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

		#region Class: OpenResheduledTaskEditPageUserTaskFlowElement

		/// <exclude/>
		public class OpenResheduledTaskEditPageUserTaskFlowElement : OpenEditPageUserTask
		{

			#region Constructors: Public

			public OpenResheduledTaskEditPageUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenResheduledTaskEditPageUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("523cb373-bd6a-4f64-bca0-cd6a43ef1ae5");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_recordId = () => (Guid)((process.AddRescheduledTaskUserTask.RecordId));
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
			}

			#endregion

			#region Properties: Public

			private Guid _objectSchemaId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			public override Guid ObjectSchemaId {
				get {
					return _objectSchemaId;
				}
				set {
					_objectSchemaId = value;
				}
			}

			private Guid _pageSchemaId = new Guid("6e5551de-a0fa-48af-8d1b-7dc896060a1e");
			public override Guid PageSchemaId {
				get {
					return _pageSchemaId;
				}
				set {
					_pageSchemaId = value;
				}
			}

			private int _editMode = 1;
			public override int EditMode {
				get {
					return _editMode;
				}
				set {
					_editMode = value;
				}
			}

			internal Func<Guid> _recordId;
			public override Guid RecordId {
				get {
					return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
				}
				set {
					_recordId = () => { return value; };
				}
			}

			private bool _isMatchConditions = false;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private bool _generateDecisionsFromColumn = false;
			public override bool GenerateDecisionsFromColumn {
				get {
					return _generateDecisionsFromColumn;
				}
				set {
					_generateDecisionsFromColumn = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("b98be122f42246da8bb7c0a3e83ee7cb",
						 "BaseElements.OpenResheduledTaskEditPageUserTask.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
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

			private int _duration = 5;
			public override int Duration {
				get {
					return _duration;
				}
				set {
					_duration = value;
				}
			}

			private int _durationPeriod = 0;
			public override int DurationPeriod {
				get {
					return _durationPeriod;
				}
				set {
					_durationPeriod = value;
				}
			}

			private int _startInPeriod = 0;
			public override int StartInPeriod {
				get {
					return _startInPeriod;
				}
				set {
					_startInPeriod = value;
				}
			}

			private int _remindBeforePeriod = 0;
			public override int RemindBeforePeriod {
				get {
					return _remindBeforePeriod;
				}
				set {
					_remindBeforePeriod = value;
				}
			}

			private bool _showInScheduler = false;
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

			private Guid _pageTypeUId = new Guid("fbe0acdc-cfc0-df11-b00f-001d60e938c6");
			public override Guid PageTypeUId {
				get {
					return _pageTypeUId;
				}
				set {
					_pageTypeUId = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: UserQuestionUserTask1FlowElement

		/// <exclude/>
		public class UserQuestionUserTask1FlowElement : UserQuestionUserTask
		{

			#region Constructors: Public

			public UserQuestionUserTask1FlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolvingV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserQuestionUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _branchingDecisions;
			public override LocalizableString BranchingDecisions {
				get {
					if (_branchingDecisions == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,143,77,107,194,64,16,134,255,74,89,122,204,200,238,102,63,178,94,149,130,32,197,131,245,82,122,152,204,206,210,80,109,36,137,133,42,254,247,174,246,162,8,30,74,111,3,207,188,239,204,115,16,143,195,247,150,197,88,44,185,235,176,111,211,48,154,180,29,143,22,93,75,220,247,163,121,75,184,110,246,88,175,121,129,29,110,120,224,110,133,235,29,247,243,166,31,138,135,235,152,40,196,227,215,153,138,241,235,65,204,6,222,188,204,98,110,215,172,188,242,129,32,152,168,192,104,21,1,107,148,96,147,51,142,146,39,172,78,225,211,238,65,156,27,114,200,105,163,157,65,15,202,106,15,166,210,12,88,89,9,148,148,97,142,24,74,105,197,177,16,207,249,173,203,220,148,169,233,155,246,83,158,224,4,183,67,158,79,188,233,231,180,95,253,46,13,221,142,51,157,114,154,188,51,125,240,213,225,39,92,247,44,142,199,226,82,193,58,103,189,11,12,58,104,4,195,94,67,112,18,65,219,58,121,69,46,80,148,55,10,101,66,19,89,71,168,100,74,96,130,69,168,61,89,8,218,71,167,83,180,53,226,61,5,245,175,10,36,171,74,43,180,32,203,252,146,97,39,33,176,37,40,171,58,161,146,62,170,104,111,20,98,77,81,147,10,80,18,50,24,31,35,212,42,79,40,141,178,170,44,43,229,204,61,5,253,87,133,101,134,217,224,237,248,3,219,111,32,42,165,2,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "b98be122f42246da8bb7c0a3e83ee7cb",
							"BaseElements.UserQuestionUserTask1.Parameters.BranchingDecisions.Value");
						dataList.LoadLocalizableValues();
						_branchingDecisions = dataList.GetSerializedItems();
						};
					return _branchingDecisions;
				}
				set {
					_branchingDecisions = value;
				}
			}

			private int _decisionMode = 0;
			public override int DecisionMode {
				get {
					return _decisionMode;
				}
				set {
					_decisionMode = value;
				}
			}

			private bool _isDecisionRequired = true;
			public override bool IsDecisionRequired {
				get {
					return _isDecisionRequired;
				}
				set {
					_isDecisionRequired = value;
				}
			}

			private LocalizableString _question;
			public override LocalizableString Question {
				get {
					return _question ?? (_question = GetLocalizableString("b98be122f42246da8bb7c0a3e83ee7cb",
						 "BaseElements.UserQuestionUserTask1.Parameters.Question.Value"));
				}
				set {
					_question = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("b98be122f42246da8bb7c0a3e83ee7cb",
						 "BaseElements.UserQuestionUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
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

			private int _duration = 5;
			public override int Duration {
				get {
					return _duration;
				}
				set {
					_duration = value;
				}
			}

			private int _durationPeriod = 0;
			public override int DurationPeriod {
				get {
					return _durationPeriod;
				}
				set {
					_durationPeriod = value;
				}
			}

			private bool _showInScheduler = false;
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

			public virtual Guid ConfItem {
				get;
				set;
			}

			public virtual Guid Event {
				get;
				set;
			}

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"3fa4de2d-80ff-495a-b7c5-927d62fd5baa\",\"624264a7-1527-482e-a850-cf14eeda9305\"]";
			}

			#endregion

		}

		#endregion

		public IncidentDiagnosticsAndResolvingV2(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "IncidentDiagnosticsAndResolvingV2";
			SchemaUId = new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_processUId = () => { return (Guid)(Guid.Parse("6AEEED31-5D8C-452E-B157-ED9AD8B83E57")); };
			_isTaskExists = () => { return (bool)(false); };
			_notStartedActivityStatusId = () => { return (Guid)(new Guid("384d4b84-58e6-df11-971b-001d60e938c6")); };
			_taskCaption = () => { return new LocalizableString((TaskCaptionValue)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b98be122-f422-46da-8bb7-c0a3e83ee7cb");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: IncidentDiagnosticsAndResolvingV2, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: IncidentDiagnosticsAndResolvingV2, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		private Func<Guid> _processUId;
		public virtual Guid ProcessUId {
			get {
				return (_processUId ?? (_processUId = () => Guid.Empty)).Invoke();
			}
			set {
				_processUId = () => { return value; };
			}
		}

		private Func<bool> _isTaskExists;
		public virtual bool IsTaskExists {
			get {
				return (_isTaskExists ?? (_isTaskExists = () => false)).Invoke();
			}
			set {
				_isTaskExists = () => { return value; };
			}
		}

		private Func<Guid> _notStartedActivityStatusId;
		public virtual Guid NotStartedActivityStatusId {
			get {
				return (_notStartedActivityStatusId ?? (_notStartedActivityStatusId = () => Guid.Empty)).Invoke();
			}
			set {
				_notStartedActivityStatusId = () => { return value; };
			}
		}

		public virtual Guid CurrentTaskId {
			get;
			set;
		}

		private Func<LocalizableString> _taskCaption;
		public virtual LocalizableString TaskCaption {
			get {
				return (_taskCaption ?? (_taskCaption = () => null)).Invoke();
			}
			set {
				_taskCaption = () => { return value; };
			}
		}

		private LocalizableString _taskCaptionValue;
		public virtual LocalizableString TaskCaptionValue {
			get {
				return _taskCaptionValue ?? (_taskCaptionValue = GetLocalizableString("b98be122f42246da8bb7c0a3e83ee7cb",
						 "Parameters.TaskCaptionValue.Value"));
			}
			set {
				_taskCaptionValue = value;
			}
		}

		public virtual DateTime ActivityDueDate {
			get;
			set;
		}

		public virtual DateTime ActivityStartDate {
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
					SchemaElementUId = new Guid("04869428-40a4-4d45-ba84-5c89ce37b217"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _createdNewIncidentStartSignal;
		public ProcessStartSignalEvent CreatedNewIncidentStartSignal {
			get {
				return _createdNewIncidentStartSignal ?? (_createdNewIncidentStartSignal = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "CreatedNewIncidentStartSignal",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("9ad8937e-6a59-4a6c-b6b0-32c1157f455c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessStartSignalEvent _modifiedInactiveIncidentStartSignal;
		public ProcessStartSignalEvent ModifiedInactiveIncidentStartSignal {
			get {
				return _modifiedInactiveIncidentStartSignal ?? (_modifiedInactiveIncidentStartSignal = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "ModifiedInactiveIncidentStartSignal",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("cefe2402-d24e-4662-9268-03c62b4e8ad0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private AddDiagnoseTaskFlowElement _addDiagnoseTask;
		public AddDiagnoseTaskFlowElement AddDiagnoseTask {
			get {
				return _addDiagnoseTask ?? (_addDiagnoseTask = new AddDiagnoseTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadCaseDataFlowElement _readCaseData;
		public ReadCaseDataFlowElement ReadCaseData {
			get {
				return _readCaseData ?? (_readCaseData = new ReadCaseDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("b4dbfeb1-c536-4a67-b205-344a03d90f82"),
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

		private ResolvedCatchSignalFlowElement _resolvedCatchSignal;
		public ResolvedCatchSignalFlowElement ResolvedCatchSignal {
			get {
				return _resolvedCatchSignal ?? ((_resolvedCatchSignal) = new ResolvedCatchSignalFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveEventBasedGateway _eventBasedGateway1;
		public ProcessExclusiveEventBasedGateway EventBasedGateway1 {
			get {
				return _eventBasedGateway1 ?? (_eventBasedGateway1 = new ProcessExclusiveEventBasedGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventBasedGateway",
					Name = "EventBasedGateway1",
					SchemaElementUId = new Guid("ccf3540c-c804-4971-8995-4b3c3e683205"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Events = new Collection<string> { "CanceledCatchSignal", "ResolvedCatchSignal", "PendingCatchSignal", "EscalationCatchSignal", },
				});
			}
		}

		private ResolvedChangeDataUserTaskFlowElement _resolvedChangeDataUserTask;
		public ResolvedChangeDataUserTaskFlowElement ResolvedChangeDataUserTask {
			get {
				return _resolvedChangeDataUserTask ?? (_resolvedChangeDataUserTask = new ResolvedChangeDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private CanceledCatchSignalFlowElement _canceledCatchSignal;
		public CanceledCatchSignalFlowElement CanceledCatchSignal {
			get {
				return _canceledCatchSignal ?? ((_canceledCatchSignal) = new CanceledCatchSignalFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private CanceledChangeDataUserTaskFlowElement _canceledChangeDataUserTask;
		public CanceledChangeDataUserTaskFlowElement CanceledChangeDataUserTask {
			get {
				return _canceledChangeDataUserTask ?? (_canceledChangeDataUserTask = new CanceledChangeDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private PendingCatchSignalFlowElement _pendingCatchSignal;
		public PendingCatchSignalFlowElement PendingCatchSignal {
			get {
				return _pendingCatchSignal ?? ((_pendingCatchSignal) = new PendingCatchSignalFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private PendingChangeDataUserTaskFlowElement _pendingChangeDataUserTask;
		public PendingChangeDataUserTaskFlowElement PendingChangeDataUserTask {
			get {
				return _pendingChangeDataUserTask ?? (_pendingChangeDataUserTask = new PendingChangeDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private EscalationCatchSignalFlowElement _escalationCatchSignal;
		public EscalationCatchSignalFlowElement EscalationCatchSignal {
			get {
				return _escalationCatchSignal ?? ((_escalationCatchSignal) = new EscalationCatchSignalFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private EscalationChangeDataUserTaskFlowElement _escalationChangeDataUserTask;
		public EscalationChangeDataUserTaskFlowElement EscalationChangeDataUserTask {
			get {
				return _escalationChangeDataUserTask ?? (_escalationChangeDataUserTask = new EscalationChangeDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _existsDiagnoseIncidentTask;
		public ProcessScriptTask ExistsDiagnoseIncidentTask {
			get {
				return _existsDiagnoseIncidentTask ?? (_existsDiagnoseIncidentTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ExistsDiagnoseIncidentTask",
					SchemaElementUId = new Guid("a5470c4b-b56a-4a48-87ba-c46af633f521"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ExistsDiagnoseIncidentTaskExecute,
				});
			}
		}

		private ReadCaseCountDataUserTaskFlowElement _readCaseCountDataUserTask;
		public ReadCaseCountDataUserTaskFlowElement ReadCaseCountDataUserTask {
			get {
				return _readCaseCountDataUserTask ?? (_readCaseCountDataUserTask = new ReadCaseCountDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private CompleteTasksChangeDataUserTaskFlowElement _completeTasksChangeDataUserTask;
		public CompleteTasksChangeDataUserTaskFlowElement CompleteTasksChangeDataUserTask {
			get {
				return _completeTasksChangeDataUserTask ?? (_completeTasksChangeDataUserTask = new CompleteTasksChangeDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private CancelTasksChangeDataUserTaskFlowElement _cancelTasksChangeDataUserTask;
		public CancelTasksChangeDataUserTaskFlowElement CancelTasksChangeDataUserTask {
			get {
				return _cancelTasksChangeDataUserTask ?? (_cancelTasksChangeDataUserTask = new CancelTasksChangeDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminateEvent1;
		public ProcessTerminateEvent TerminateEvent1 {
			get {
				return _terminateEvent1 ?? (_terminateEvent1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1",
					SchemaElementUId = new Guid("815ee92a-d5be-44c7-9cb1-07a1bdb1fc7f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _setCurrentTask;
		public ProcessScriptTask SetCurrentTask {
			get {
				return _setCurrentTask ?? (_setCurrentTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SetCurrentTask",
					SchemaElementUId = new Guid("70881c66-7559-4967-b02f-2bb93def217f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SetCurrentTaskExecute,
				});
			}
		}

		private RescheduledCatchSignalFlowElement _rescheduledCatchSignal;
		public RescheduledCatchSignalFlowElement RescheduledCatchSignal {
			get {
				return _rescheduledCatchSignal ?? ((_rescheduledCatchSignal) = new RescheduledCatchSignalFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddRescheduledTaskUserTaskFlowElement _addRescheduledTaskUserTask;
		public AddRescheduledTaskUserTaskFlowElement AddRescheduledTaskUserTask {
			get {
				return _addRescheduledTaskUserTask ?? (_addRescheduledTaskUserTask = new AddRescheduledTaskUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OpenResheduledTaskEditPageUserTaskFlowElement _openResheduledTaskEditPageUserTask;
		public OpenResheduledTaskEditPageUserTaskFlowElement OpenResheduledTaskEditPageUserTask {
			get {
				return _openResheduledTaskEditPageUserTask ?? (_openResheduledTaskEditPageUserTask = new OpenResheduledTaskEditPageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _setRescheduledTaskFormula;
		public ProcessScriptTask SetRescheduledTaskFormula {
			get {
				return _setRescheduledTaskFormula ?? (_setRescheduledTaskFormula = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SetRescheduledTaskFormula",
					SchemaElementUId = new Guid("d3611d33-118c-47cc-a393-7f8025bbd3f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SetRescheduledTaskFormulaExecute,
				});
			}
		}

		private UserQuestionUserTask1FlowElement _userQuestionUserTask1;
		public UserQuestionUserTask1FlowElement UserQuestionUserTask1 {
			get {
				return _userQuestionUserTask1 ?? (_userQuestionUserTask1 = new UserQuestionUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("7f8b1890-288d-4ede-ac71-15b759489e77"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("1d38db98-8dc6-4042-9109-8a7749040b55"),
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
					SchemaElementUId = new Guid("c441e48e-09cc-4a19-81e6-f377ad5c0d0c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow4;
		public ProcessConditionalFlow ConditionalSequenceFlow4 {
			get {
				return _conditionalSequenceFlow4 ?? (_conditionalSequenceFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow4",
					SchemaElementUId = new Guid("74d3d11b-a9f9-4b35-93b4-796e21acc9c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"), new Collection<Guid>() {
							new Guid("3fa4de2d-80ff-495a-b7c5-927d62fd5baa"),
						}},
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
					SchemaElementUId = new Guid("f6bd99ed-2ff7-4c65-82fd-851a090f22e7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb"), new Collection<Guid>() {
							new Guid("624264a7-1527-482e-a850-cf14eeda9305"),
						}},
					},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[CreatedNewIncidentStartSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { CreatedNewIncidentStartSignal };
			FlowElements[ModifiedInactiveIncidentStartSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { ModifiedInactiveIncidentStartSignal };
			FlowElements[AddDiagnoseTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDiagnoseTask };
			FlowElements[ReadCaseData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadCaseData };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ResolvedCatchSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { ResolvedCatchSignal };
			FlowElements[EventBasedGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventBasedGateway1 };
			FlowElements[ResolvedChangeDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ResolvedChangeDataUserTask };
			FlowElements[CanceledCatchSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { CanceledCatchSignal };
			FlowElements[CanceledChangeDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CanceledChangeDataUserTask };
			FlowElements[PendingCatchSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { PendingCatchSignal };
			FlowElements[PendingChangeDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PendingChangeDataUserTask };
			FlowElements[EscalationCatchSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { EscalationCatchSignal };
			FlowElements[EscalationChangeDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EscalationChangeDataUserTask };
			FlowElements[ExistsDiagnoseIncidentTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ExistsDiagnoseIncidentTask };
			FlowElements[ReadCaseCountDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadCaseCountDataUserTask };
			FlowElements[CompleteTasksChangeDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CompleteTasksChangeDataUserTask };
			FlowElements[CancelTasksChangeDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelTasksChangeDataUserTask };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[SetCurrentTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetCurrentTask };
			FlowElements[RescheduledCatchSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { RescheduledCatchSignal };
			FlowElements[AddRescheduledTaskUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRescheduledTaskUserTask };
			FlowElements[OpenResheduledTaskEditPageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenResheduledTaskEditPageUserTask };
			FlowElements[SetRescheduledTaskFormula.SchemaElementUId] = new Collection<ProcessFlowElement> { SetRescheduledTaskFormula };
			FlowElements[UserQuestionUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { UserQuestionUserTask1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "CreatedNewIncidentStartSignal":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ModifiedInactiveIncidentStartSignal":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "AddDiagnoseTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("EventBasedGateway1", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SetCurrentTask", e.Context.SenderName));
						break;
					case "ReadCaseData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExistsDiagnoseIncidentTask", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadCaseData", e.Context.SenderName));
						break;
					case "ResolvedCatchSignal":
						EventBasedGateway1.CancelNonexecutedEvents("ResolvedCatchSignal");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ResolvedChangeDataUserTask", e.Context.SenderName));
						break;
					case "EventBasedGateway1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CanceledCatchSignal", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ResolvedCatchSignal", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PendingCatchSignal", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("EscalationCatchSignal", e.Context.SenderName));
						break;
					case "ResolvedChangeDataUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadCaseCountDataUserTask", e.Context.SenderName));
						break;
					case "CanceledCatchSignal":
						EventBasedGateway1.CancelNonexecutedEvents("CanceledCatchSignal");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CanceledChangeDataUserTask", e.Context.SenderName));
						break;
					case "CanceledChangeDataUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadCaseCountDataUserTask", e.Context.SenderName));
						break;
					case "PendingCatchSignal":
						EventBasedGateway1.CancelNonexecutedEvents("PendingCatchSignal");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PendingChangeDataUserTask", e.Context.SenderName));
						break;
					case "PendingChangeDataUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "EscalationCatchSignal":
						EventBasedGateway1.CancelNonexecutedEvents("EscalationCatchSignal");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("EscalationChangeDataUserTask", e.Context.SenderName));
						break;
					case "EscalationChangeDataUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ExistsDiagnoseIncidentTask":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("EventBasedGateway1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ExistsDiagnoseIncidentTask");
						break;
					case "ReadCaseCountDataUserTask":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("UserQuestionUserTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "CompleteTasksChangeDataUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "CancelTasksChangeDataUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "SetCurrentTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("RescheduledCatchSignal", e.Context.SenderName));
						break;
					case "RescheduledCatchSignal":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddRescheduledTaskUserTask", e.Context.SenderName));
						break;
					case "AddRescheduledTaskUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenResheduledTaskEditPageUserTask", e.Context.SenderName));
						break;
					case "OpenResheduledTaskEditPageUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SetRescheduledTaskFormula", e.Context.SenderName));
						break;
					case "SetRescheduledTaskFormula":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("RescheduledCatchSignal", e.Context.SenderName));
						break;
					case "UserQuestionUserTask1":
						if (ConditionalSequenceFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CancelTasksChangeDataUserTask", e.Context.SenderName));
							break;
						}
						if (ConditionalSequenceFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CompleteTasksChangeDataUserTask", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "UserQuestionUserTask1");
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDiagnoseTask", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((IsTaskExists));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExistsDiagnoseIncidentTask", "ConditionalSequenceFlow1", "(IsTaskExists)", result);
			return result;
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((ReadCaseCountDataUserTask.ResultCount)>0);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadCaseCountDataUserTask", "ConditionalSequenceFlow2", "(ReadCaseCountDataUserTask.ResultCount)>0", result);
			return result;
		}

		private bool ConditionalSequenceFlow4ExpressionExecute() {
			bool result = System.Linq.Enumerable.Count(System.Linq.Enumerable.Intersect(JsonConvert.DeserializeObject<Collection<Guid>>(UserQuestionUserTask1.ResultDecisions), ConditionalSequenceFlow4.ProcessActivitiesSelectedResults[new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb")])) != 0;
			Log.InfoFormat(ConditionalExpressionLogMessage, "UserQuestionUserTask1", "ConditionalSequenceFlow4", "System.Linq.Enumerable.Count(System.Linq.Enumerable.Intersect(JsonConvert.DeserializeObject<Collection<Guid>>(UserQuestionUserTask1.ResultDecisions), ConditionalSequenceFlow4.ProcessActivitiesSelectedResults[new Guid(\"4211020f-f647-4a9e-97d5-2c52d07813bb\")])) != 0", result);
			Log.Info($"UserQuestionUserTask1.ResultDecisions: {UserQuestionUserTask1.ResultDecisions}");
			return result;
		}

		private bool ConditionalSequenceFlow3ExpressionExecute() {
			bool result = System.Linq.Enumerable.Count(System.Linq.Enumerable.Intersect(JsonConvert.DeserializeObject<Collection<Guid>>(UserQuestionUserTask1.ResultDecisions), ConditionalSequenceFlow3.ProcessActivitiesSelectedResults[new Guid("4211020f-f647-4a9e-97d5-2c52d07813bb")])) != 0;
			Log.InfoFormat(ConditionalExpressionLogMessage, "UserQuestionUserTask1", "ConditionalSequenceFlow3", "System.Linq.Enumerable.Count(System.Linq.Enumerable.Intersect(JsonConvert.DeserializeObject<Collection<Guid>>(UserQuestionUserTask1.ResultDecisions), ConditionalSequenceFlow3.ProcessActivitiesSelectedResults[new Guid(\"4211020f-f647-4a9e-97d5-2c52d07813bb\")])) != 0", result);
			Log.Info($"UserQuestionUserTask1.ResultDecisions: {UserQuestionUserTask1.ResultDecisions}");
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("UserQuestionUserTask1.ConfItem")) {
				writer.WriteValue("UserQuestionUserTask1.ConfItem", UserQuestionUserTask1.ConfItem, Guid.Empty);
			}
			if (!HasMapping("UserQuestionUserTask1.Event")) {
				writer.WriteValue("UserQuestionUserTask1.Event", UserQuestionUserTask1.Event, Guid.Empty);
			}
			if (!HasMapping("CurrentTaskId")) {
				writer.WriteValue("CurrentTaskId", CurrentTaskId, Guid.Empty);
			}
			if (!HasMapping("ActivityDueDate")) {
				writer.WriteValue("ActivityDueDate", ActivityDueDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("ActivityStartDate")) {
				writer.WriteValue("ActivityStartDate", ActivityStartDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("ProcessUId")) {
				writer.WriteValue("ProcessUId", ProcessUId, Guid.Empty);
			}
			if (!HasMapping("IsTaskExists")) {
				writer.WriteValue("IsTaskExists", IsTaskExists, false);
			}
			if (!HasMapping("NotStartedActivityStatusId")) {
				writer.WriteValue("NotStartedActivityStatusId", NotStartedActivityStatusId, Guid.Empty);
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
			MetaPathParameterValues.Add("415d89df-f50f-46b6-8a77-b034e8173608", () => ProcessUId);
			MetaPathParameterValues.Add("ecd8a32c-df30-44e9-89f6-3adc6c3bdfd8", () => IsTaskExists);
			MetaPathParameterValues.Add("ec21229b-9b25-49d7-92ad-eed18aa728e5", () => NotStartedActivityStatusId);
			MetaPathParameterValues.Add("ae73a291-5391-4398-ad71-c61091bd78fe", () => CurrentTaskId);
			MetaPathParameterValues.Add("7cdb4564-160f-4dc7-afbd-a2d9ac97aa23", () => TaskCaption);
			MetaPathParameterValues.Add("a0a5e89d-ee0e-4227-948e-7fcad6fbb49e", () => TaskCaptionValue);
			MetaPathParameterValues.Add("77719740-2177-4b8a-b22a-54a091ab6496", () => ActivityDueDate);
			MetaPathParameterValues.Add("aa6b400d-ea76-4b36-a31a-03f5695b31dc", () => ActivityStartDate);
			MetaPathParameterValues.Add("eb69a7f3-6d56-4292-8246-38c29e406529", () => CreatedNewIncidentStartSignal.RecordId);
			MetaPathParameterValues.Add("b7921a8f-2af8-4912-99a2-e91f94ee1377", () => CreatedNewIncidentStartSignal.EntitySchemaUId);
			MetaPathParameterValues.Add("ad68430c-33cb-4b0e-9767-a62d05a705bb", () => ModifiedInactiveIncidentStartSignal.RecordId);
			MetaPathParameterValues.Add("133eafbe-3f14-4fbf-8b65-546fedfd2878", () => ModifiedInactiveIncidentStartSignal.EntitySchemaUId);
			MetaPathParameterValues.Add("47381106-439b-48de-a3be-7347358ad7d6", () => AddDiagnoseTask.EntitySchemaId);
			MetaPathParameterValues.Add("2e5068e9-10ba-4629-9ad3-a2262e2be850", () => AddDiagnoseTask.DataSourceFilters);
			MetaPathParameterValues.Add("b0c3a7d0-eda7-45fa-93f0-1e0bd05d687d", () => AddDiagnoseTask.RecordAddMode);
			MetaPathParameterValues.Add("2ff06d85-70bf-4fe3-84cb-f040ea533588", () => AddDiagnoseTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("fb5c9609-3001-46fb-999e-e8f79c1d2ce2", () => AddDiagnoseTask.RecordDefValues);
			MetaPathParameterValues.Add("15433e0e-c833-4c29-9b51-7ec388ba323f", () => AddDiagnoseTask.RecordId);
			MetaPathParameterValues.Add("2ffddea6-666f-447f-a4a5-04225016ac33", () => AddDiagnoseTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("e20c98d0-9d0e-407b-930b-a6b43f524e3c", () => ReadCaseData.DataSourceFilters);
			MetaPathParameterValues.Add("fa34df5c-7b4e-47ae-a912-474e470b6c45", () => ReadCaseData.ResultType);
			MetaPathParameterValues.Add("90e6fe3b-6a23-4699-9d12-17cb6e9231df", () => ReadCaseData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("f4188d8f-b976-4570-97fc-41b0f9be5bfc", () => ReadCaseData.NumberOfRecords);
			MetaPathParameterValues.Add("dfebf7b5-d60e-4831-b0d2-43813be0a77d", () => ReadCaseData.FunctionType);
			MetaPathParameterValues.Add("9adc4f45-21a7-4b76-9422-1980c48bcf46", () => ReadCaseData.AggregationColumnName);
			MetaPathParameterValues.Add("7754467c-fdaa-4a75-8546-a1292b5a6ded", () => ReadCaseData.OrderInfo);
			MetaPathParameterValues.Add("7a51a482-cc66-4157-a765-07dfae9e0f6b", () => ReadCaseData.ResultEntity);
			MetaPathParameterValues.Add("f5018c00-5f7e-48d6-bf73-d4ce6cbf8adf", () => ReadCaseData.ResultCount);
			MetaPathParameterValues.Add("cad8e278-2b4a-4f1b-8ccf-55db9d72df60", () => ReadCaseData.ResultIntegerFunction);
			MetaPathParameterValues.Add("31c46bd6-ea7c-4f58-8530-fa76fa4e672f", () => ReadCaseData.ResultFloatFunction);
			MetaPathParameterValues.Add("81e76ac5-083c-40f7-a7a6-1a58511ec988", () => ReadCaseData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("f3ab54a9-d46b-470b-9dd7-8f28314883aa", () => ReadCaseData.ResultRowsCount);
			MetaPathParameterValues.Add("29febfab-7d22-4313-9fce-288ec640e85f", () => ReadCaseData.CanReadUncommitedData);
			MetaPathParameterValues.Add("c73dce7a-814b-4024-bd5d-023c0ae8ff38", () => ReadCaseData.ResultEntityCollection);
			MetaPathParameterValues.Add("d2d9806f-75cc-4f82-957f-a0faf091d697", () => ReadCaseData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("80b7264a-0735-4862-9f54-b35f79ae6dba", () => ReadCaseData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("deb1676b-e3ed-4d08-b4d4-40bb2d5e2294", () => ReadCaseData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("852a79b3-d625-4f18-b6ee-e2a25dd3c9b6", () => ReadCaseData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("78f519cc-f8d2-4fac-9f87-2dc4c245ab29", () => ResolvedCatchSignal.RecordId);
			MetaPathParameterValues.Add("92796a3d-edaa-47bf-9730-0fb84a1bcb7f", () => ResolvedChangeDataUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("69f7d295-e143-42e8-bb3c-c2f6f0421146", () => ResolvedChangeDataUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("792c5022-ebba-44b5-955b-42c816843971", () => ResolvedChangeDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("59ead31f-77ed-48f6-a880-82e8bb04a642", () => ResolvedChangeDataUserTask.RecordColumnValues);
			MetaPathParameterValues.Add("bf527547-9986-4b51-846e-92eb30993331", () => ResolvedChangeDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("9e2aacd6-9c62-4726-94bc-1859bba3cced", () => CanceledCatchSignal.RecordId);
			MetaPathParameterValues.Add("183ecb6a-29e5-46cc-83dd-a8ec060bc191", () => CanceledChangeDataUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("58ab220b-a239-4004-a8b3-362b8616d6b5", () => CanceledChangeDataUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("cb23be2e-d56f-4c76-8277-bea8232dc232", () => CanceledChangeDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("1546ad35-5335-436b-9a67-31666d57fea3", () => CanceledChangeDataUserTask.RecordColumnValues);
			MetaPathParameterValues.Add("74aca4f2-5300-4e68-bd97-6d89c9d5beb7", () => CanceledChangeDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("159c71ef-be09-4085-8d00-3c67a436bd4b", () => PendingCatchSignal.RecordId);
			MetaPathParameterValues.Add("9ceb65d0-c08f-4758-80c4-0eb931174b9b", () => PendingChangeDataUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("2e50cca2-8933-4280-8cbf-18fdb137ab50", () => PendingChangeDataUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("fa758883-6271-4b3c-bbfa-6cbee86d2b5b", () => PendingChangeDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("95810b4e-5292-4018-a8df-b266bc723708", () => PendingChangeDataUserTask.RecordColumnValues);
			MetaPathParameterValues.Add("5f57cb97-288f-4d71-a2c4-4b5e5dddee19", () => PendingChangeDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("cc1f93c0-6974-4f8b-b1e8-6a819c4b21e9", () => EscalationCatchSignal.RecordId);
			MetaPathParameterValues.Add("da080b93-b78a-437a-adbc-9f4eee898cc5", () => EscalationChangeDataUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("a94e00f8-50cc-4b2b-9d7e-3c846c8fe91d", () => EscalationChangeDataUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("b03d7915-a2be-4918-8d0b-ca7e158f79e6", () => EscalationChangeDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("ecc66875-1982-4fd7-99ab-6d047904b215", () => EscalationChangeDataUserTask.RecordColumnValues);
			MetaPathParameterValues.Add("75e7bd13-6a7e-4f4d-9b14-947dc9d4dbb1", () => EscalationChangeDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("6e10b476-de64-4b9b-8536-f53f0ce813e9", () => ReadCaseCountDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("e57b1d74-578d-476a-b807-98eadc71a555", () => ReadCaseCountDataUserTask.ResultType);
			MetaPathParameterValues.Add("f86d057a-db93-4c1d-a3b0-3470068d9d08", () => ReadCaseCountDataUserTask.ReadSomeTopRecords);
			MetaPathParameterValues.Add("fc0df9c8-409b-444e-a12d-e048877ca940", () => ReadCaseCountDataUserTask.NumberOfRecords);
			MetaPathParameterValues.Add("d119c974-e8fb-423b-b661-fc9d3c080ea7", () => ReadCaseCountDataUserTask.FunctionType);
			MetaPathParameterValues.Add("0676e49c-6b30-489d-83c5-ab83ad3e6093", () => ReadCaseCountDataUserTask.AggregationColumnName);
			MetaPathParameterValues.Add("c9b59582-9d62-471e-8bb4-aa7df0658127", () => ReadCaseCountDataUserTask.OrderInfo);
			MetaPathParameterValues.Add("e0685b0c-239b-47ce-8492-ff99b21d13a5", () => ReadCaseCountDataUserTask.ResultEntity);
			MetaPathParameterValues.Add("399de72a-ef6d-4a47-b355-3086cf7cc0cd", () => ReadCaseCountDataUserTask.ResultCount);
			MetaPathParameterValues.Add("b6b9ddf5-da1a-4be7-80c2-86cd883ed495", () => ReadCaseCountDataUserTask.ResultIntegerFunction);
			MetaPathParameterValues.Add("518f26fc-42e0-4dfd-bded-1ca5061316e6", () => ReadCaseCountDataUserTask.ResultFloatFunction);
			MetaPathParameterValues.Add("c56a1f76-9f86-47e6-b3b7-33ab372ebaef", () => ReadCaseCountDataUserTask.ResultDateTimeFunction);
			MetaPathParameterValues.Add("ace9d311-33b7-4a4f-8db5-5154787974c9", () => ReadCaseCountDataUserTask.ResultRowsCount);
			MetaPathParameterValues.Add("20e89035-f4c1-4152-b109-4eedc803888e", () => ReadCaseCountDataUserTask.CanReadUncommitedData);
			MetaPathParameterValues.Add("b1feaf4d-a320-4d9a-a665-cddda8e8bb59", () => ReadCaseCountDataUserTask.ResultEntityCollection);
			MetaPathParameterValues.Add("d49a261c-b0a1-4251-8c54-c4923cc2b11f", () => ReadCaseCountDataUserTask.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("bce2b23c-43d7-4ee3-99a6-d42915037782", () => ReadCaseCountDataUserTask.IgnoreDisplayValues);
			MetaPathParameterValues.Add("26fee922-21a7-4cbd-aaa5-6625b9d9ba29", () => ReadCaseCountDataUserTask.ResultCompositeObjectList);
			MetaPathParameterValues.Add("f19d01c9-602a-413a-8523-48e2ede551bb", () => ReadCaseCountDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("99f2dd86-4eab-47c5-8ba2-01d496b9a3fb", () => CompleteTasksChangeDataUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("6a09dbe4-c830-4973-9ba2-bee31e9f77f2", () => CompleteTasksChangeDataUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("c8a7ec42-256a-40db-af79-d1e36121c71c", () => CompleteTasksChangeDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("cbba51f0-1bbc-4cab-9bfd-7c94e372df30", () => CompleteTasksChangeDataUserTask.RecordColumnValues);
			MetaPathParameterValues.Add("e94ca64d-9014-4261-b361-6537c253d08e", () => CompleteTasksChangeDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("e21b52d3-db26-4e4e-8254-fcc14a5f7386", () => CancelTasksChangeDataUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("59deaa49-2d60-48b6-81d5-cecd7aaaf43b", () => CancelTasksChangeDataUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("c590c5de-cb61-45ff-a24d-d8ee718c86e7", () => CancelTasksChangeDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("6c0bc164-4425-4e9d-abaf-b243259091c3", () => CancelTasksChangeDataUserTask.RecordColumnValues);
			MetaPathParameterValues.Add("66258bdb-9a28-4293-a3a8-1ae305614e52", () => CancelTasksChangeDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("a46b9b07-561d-402a-bfce-8c12452a18d2", () => RescheduledCatchSignal.RecordId);
			MetaPathParameterValues.Add("92b7b385-b361-4426-aa17-35a191aa76c8", () => AddRescheduledTaskUserTask.EntitySchemaId);
			MetaPathParameterValues.Add("b7e1b44d-217e-4e2f-a90c-17a5ebf74c94", () => AddRescheduledTaskUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("d5038619-45b6-440d-9cef-0b9bb2381b70", () => AddRescheduledTaskUserTask.RecordAddMode);
			MetaPathParameterValues.Add("c587e107-d285-4719-941f-a1aa76cdf30e", () => AddRescheduledTaskUserTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("2a49baff-f87a-4844-8d6e-503b3b93151b", () => AddRescheduledTaskUserTask.RecordDefValues);
			MetaPathParameterValues.Add("538e3867-2d16-4738-823f-530a3f2cd5a7", () => AddRescheduledTaskUserTask.RecordId);
			MetaPathParameterValues.Add("486f548a-8c81-4e60-890d-0be6b972deba", () => AddRescheduledTaskUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("f9f0b2ef-b537-4f31-a5bd-bc0b4387a477", () => OpenResheduledTaskEditPageUserTask.ObjectSchemaId);
			MetaPathParameterValues.Add("73f9197d-3c80-4e5a-a6dd-fd7e5eb882d5", () => OpenResheduledTaskEditPageUserTask.PageSchemaId);
			MetaPathParameterValues.Add("a517303e-9785-4d9c-be67-2b59977d0b6c", () => OpenResheduledTaskEditPageUserTask.EditMode);
			MetaPathParameterValues.Add("cdfee2f2-2914-43ad-8e30-4e93a8301ea1", () => OpenResheduledTaskEditPageUserTask.RecordColumnValues);
			MetaPathParameterValues.Add("2d261075-7320-45c5-a0b8-da25a32b1ce0", () => OpenResheduledTaskEditPageUserTask.RecordId);
			MetaPathParameterValues.Add("975dad01-0f9c-41f9-9dba-6c204620b59d", () => OpenResheduledTaskEditPageUserTask.ExecutedMode);
			MetaPathParameterValues.Add("c2630eb6-4cab-45a0-a61a-f97018285882", () => OpenResheduledTaskEditPageUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("8553b6f1-1c80-4fc3-ae4d-08b5cd7171f8", () => OpenResheduledTaskEditPageUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("6e47e63f-e942-4085-a3bd-6ab9010b12ff", () => OpenResheduledTaskEditPageUserTask.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("d0d67c0b-b33d-46f1-a228-5a0a3f8db1a5", () => OpenResheduledTaskEditPageUserTask.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("34934901-cc88-496d-874d-c790334668d4", () => OpenResheduledTaskEditPageUserTask.ResultParameter);
			MetaPathParameterValues.Add("4fc12d51-aee6-4025-b7b7-9cb916b765c1", () => OpenResheduledTaskEditPageUserTask.IsReexecution);
			MetaPathParameterValues.Add("36fc1749-5e74-486d-9aa2-9997322bd096", () => OpenResheduledTaskEditPageUserTask.Recommendation);
			MetaPathParameterValues.Add("a4ce0f56-9fe5-4465-8f2e-2b52e4ea511a", () => OpenResheduledTaskEditPageUserTask.ActivityCategory);
			MetaPathParameterValues.Add("8923c12b-3e36-466f-8b47-a61859bf4610", () => OpenResheduledTaskEditPageUserTask.OwnerId);
			MetaPathParameterValues.Add("77d923b9-b162-4dc3-a65a-f662c1683465", () => OpenResheduledTaskEditPageUserTask.Duration);
			MetaPathParameterValues.Add("cf9a71fe-d429-4b38-b8e7-dfe32a55ae55", () => OpenResheduledTaskEditPageUserTask.DurationPeriod);
			MetaPathParameterValues.Add("3e7299c2-13e1-4fb6-9110-6637acbf7fa8", () => OpenResheduledTaskEditPageUserTask.StartIn);
			MetaPathParameterValues.Add("92526212-b4e7-4c84-b889-378fb2292a7a", () => OpenResheduledTaskEditPageUserTask.StartInPeriod);
			MetaPathParameterValues.Add("de781630-7327-4331-8d12-5d22d92e1737", () => OpenResheduledTaskEditPageUserTask.RemindBefore);
			MetaPathParameterValues.Add("189d2378-a138-4c1f-876e-ca81238f2c0b", () => OpenResheduledTaskEditPageUserTask.RemindBeforePeriod);
			MetaPathParameterValues.Add("0b7d386f-a98b-4951-b236-c81c9d1971b1", () => OpenResheduledTaskEditPageUserTask.ShowInScheduler);
			MetaPathParameterValues.Add("ebd95a51-ddeb-44d8-bf32-63592a44c539", () => OpenResheduledTaskEditPageUserTask.ShowExecutionPage);
			MetaPathParameterValues.Add("d6fdb102-6caa-49e9-a5b2-1c770ca6e847", () => OpenResheduledTaskEditPageUserTask.Lead);
			MetaPathParameterValues.Add("ca853fd2-05a9-469a-a508-4e39f3da9059", () => OpenResheduledTaskEditPageUserTask.Account);
			MetaPathParameterValues.Add("9329119b-85e9-4b2b-8a37-3b22c75f7a41", () => OpenResheduledTaskEditPageUserTask.Contact);
			MetaPathParameterValues.Add("8d6acd3b-9769-4126-94cb-a2c73f82c650", () => OpenResheduledTaskEditPageUserTask.Opportunity);
			MetaPathParameterValues.Add("3dec8030-fe45-48ff-9399-e7952212a53c", () => OpenResheduledTaskEditPageUserTask.Invoice);
			MetaPathParameterValues.Add("27e6ba69-8288-4933-94c8-3077891add79", () => OpenResheduledTaskEditPageUserTask.Document);
			MetaPathParameterValues.Add("29631052-774c-49d8-b31d-f1c8820e0946", () => OpenResheduledTaskEditPageUserTask.Incident);
			MetaPathParameterValues.Add("87e7e4d8-7bcb-4fc9-84c8-670dbb29fd6d", () => OpenResheduledTaskEditPageUserTask.Case);
			MetaPathParameterValues.Add("a45b4882-0481-4d81-82ad-1c5b52de9081", () => OpenResheduledTaskEditPageUserTask.ActivityResult);
			MetaPathParameterValues.Add("cf1b147f-ba96-4412-a061-6dc9d86fe625", () => OpenResheduledTaskEditPageUserTask.CurrentActivityId);
			MetaPathParameterValues.Add("6ea35da2-f744-4d97-ba95-f3db35c6a221", () => OpenResheduledTaskEditPageUserTask.IsActivityCompleted);
			MetaPathParameterValues.Add("6351291c-9331-45a5-b9e7-07dcfb87ca72", () => OpenResheduledTaskEditPageUserTask.ExecutionContext);
			MetaPathParameterValues.Add("bc0f1f42-e563-4d5d-a178-dc465ba0dd21", () => OpenResheduledTaskEditPageUserTask.PageTypeUId);
			MetaPathParameterValues.Add("a1876452-d45e-49e4-9764-f5701aa6c862", () => OpenResheduledTaskEditPageUserTask.ActivitySchemaUId);
			MetaPathParameterValues.Add("6d3b9d72-0379-484c-91be-dbd4cfaa6087", () => OpenResheduledTaskEditPageUserTask.InformationOnStep);
			MetaPathParameterValues.Add("2eeff63d-d521-490d-a199-1ebc8eab8777", () => OpenResheduledTaskEditPageUserTask.Order);
			MetaPathParameterValues.Add("f2e5410e-5ad0-434f-b0ff-e54c67b05726", () => OpenResheduledTaskEditPageUserTask.Requests);
			MetaPathParameterValues.Add("0d61e10b-5035-4def-a3ab-2b157dc34402", () => OpenResheduledTaskEditPageUserTask.Listing);
			MetaPathParameterValues.Add("07cc0683-8fb0-412d-84e4-1129fe369a51", () => OpenResheduledTaskEditPageUserTask.Property);
			MetaPathParameterValues.Add("fb1686c8-d568-46c0-84ce-b39d2c502807", () => OpenResheduledTaskEditPageUserTask.Contract);
			MetaPathParameterValues.Add("45923a9c-afb5-4081-b2ee-958f0892885b", () => OpenResheduledTaskEditPageUserTask.Problem);
			MetaPathParameterValues.Add("dc430176-a84a-4020-9f66-3796a92959ce", () => OpenResheduledTaskEditPageUserTask.Change);
			MetaPathParameterValues.Add("fb3da557-5fd3-41cf-bc78-31f1210af7b7", () => OpenResheduledTaskEditPageUserTask.Release);
			MetaPathParameterValues.Add("c38a9663-79ef-4428-9487-8fdeadfe594e", () => OpenResheduledTaskEditPageUserTask.Project);
			MetaPathParameterValues.Add("1644ba00-a9b3-4e94-bbc9-b8298693f77f", () => OpenResheduledTaskEditPageUserTask.ActivityPriority);
			MetaPathParameterValues.Add("fadac54b-e261-437e-a97d-de3a06f8d988", () => OpenResheduledTaskEditPageUserTask.CreateActivity);
			MetaPathParameterValues.Add("675f0993-7e43-4f73-9a39-40712c295959", () => UserQuestionUserTask1.BranchingDecisions);
			MetaPathParameterValues.Add("d7ddf2ac-d757-46b1-be45-23d92c75fac3", () => UserQuestionUserTask1.ResultDecisions);
			MetaPathParameterValues.Add("000efa2d-fb03-4c16-a5d9-f25cf8f9d82d", () => UserQuestionUserTask1.DecisionMode);
			MetaPathParameterValues.Add("215456ce-4520-4c29-b6d6-8259bd1cb74b", () => UserQuestionUserTask1.IsDecisionRequired);
			MetaPathParameterValues.Add("51a4a529-9378-410d-8fa1-e469e0bfa4e0", () => UserQuestionUserTask1.Question);
			MetaPathParameterValues.Add("c50c1d7b-3b09-46d8-91ca-188cb23ef8c2", () => UserQuestionUserTask1.WindowCaption);
			MetaPathParameterValues.Add("dc8b9fc3-346a-4e8b-a0ac-66c45ebc30b2", () => UserQuestionUserTask1.Recommendation);
			MetaPathParameterValues.Add("f48bfc98-8af5-4b8b-8f0e-0f54a4b68120", () => UserQuestionUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("ca4f9842-d9ff-4a15-b38b-1cd918ee9ed3", () => UserQuestionUserTask1.OwnerId);
			MetaPathParameterValues.Add("622b9f2a-4cb2-43a8-8f4b-becabac69839", () => UserQuestionUserTask1.Duration);
			MetaPathParameterValues.Add("acc42a39-4371-4da5-b7fc-d06c3e13ec03", () => UserQuestionUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("a5d59779-62f7-485f-b4a9-a0d09a870942", () => UserQuestionUserTask1.StartIn);
			MetaPathParameterValues.Add("43205693-5dcc-43f3-a331-b49c4bc9973d", () => UserQuestionUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("d471d560-f33f-4ec8-b727-bf18cd94b7c2", () => UserQuestionUserTask1.RemindBefore);
			MetaPathParameterValues.Add("e895a017-2743-4df7-be4f-c24ce2e71411", () => UserQuestionUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("9dfce689-a334-4c71-8932-456ffbbfdca7", () => UserQuestionUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("a9906e90-904c-47dc-a148-9c2ac1836a1f", () => UserQuestionUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("3d2362be-d4ae-4a2b-b570-6dadadab9cfb", () => UserQuestionUserTask1.Lead);
			MetaPathParameterValues.Add("65dedf77-e2ac-4f6a-81b0-9b66c8145aa7", () => UserQuestionUserTask1.Account);
			MetaPathParameterValues.Add("1663995d-0b3c-4b2c-a172-e140a6adcfc2", () => UserQuestionUserTask1.Contact);
			MetaPathParameterValues.Add("eca4a8da-4536-4478-8fb8-db24bbdb8f90", () => UserQuestionUserTask1.Opportunity);
			MetaPathParameterValues.Add("972e2db6-3271-40c0-82a2-3d60f8cee668", () => UserQuestionUserTask1.Invoice);
			MetaPathParameterValues.Add("1cea383e-0fcf-4a49-af48-76f2446e9056", () => UserQuestionUserTask1.Document);
			MetaPathParameterValues.Add("40e4bd9f-a064-4a0a-9a39-d1d5e1f3a19c", () => UserQuestionUserTask1.Incident);
			MetaPathParameterValues.Add("f2bc9f52-708a-476d-a06a-4e438caea1c8", () => UserQuestionUserTask1.Case);
			MetaPathParameterValues.Add("332854ec-8027-4a9f-be87-fd81e4c8cdc4", () => UserQuestionUserTask1.ActivityResult);
			MetaPathParameterValues.Add("8a4aa587-30b7-4d91-8af2-9c962132c668", () => UserQuestionUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("8624a7a9-f290-4573-a493-1a331d465b0c", () => UserQuestionUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("73499557-0a32-4d92-84b3-8bb67973374b", () => UserQuestionUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("7bf7d250-d34e-4225-aaa6-dcddbf01f6d2", () => UserQuestionUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("58d3775d-23b0-4670-9b6c-61eed72117e4", () => UserQuestionUserTask1.Order);
			MetaPathParameterValues.Add("8e07b990-896f-406b-b301-1ca5ad999a3b", () => UserQuestionUserTask1.Requests);
			MetaPathParameterValues.Add("33643c88-34dd-4205-98e0-a9d17513a406", () => UserQuestionUserTask1.Listing);
			MetaPathParameterValues.Add("e6e31938-0b0f-4bba-a9bb-1722f1b6c875", () => UserQuestionUserTask1.Property);
			MetaPathParameterValues.Add("4ac1b552-b731-4e7f-a4aa-2104b7d151c1", () => UserQuestionUserTask1.Contract);
			MetaPathParameterValues.Add("7abadf0a-2e61-4b8b-ae34-40e154e2bae6", () => UserQuestionUserTask1.Project);
			MetaPathParameterValues.Add("4790f3c7-f104-4440-a586-b32ca6f69887", () => UserQuestionUserTask1.Problem);
			MetaPathParameterValues.Add("ee3e666e-6999-4800-8719-42b69d82985f", () => UserQuestionUserTask1.Change);
			MetaPathParameterValues.Add("e2b728c6-93b7-493c-978a-05eb21b9cdf3", () => UserQuestionUserTask1.Release);
			MetaPathParameterValues.Add("526e4e0e-d910-498a-af71-5ee401b97594", () => UserQuestionUserTask1.CreateActivity);
			MetaPathParameterValues.Add("3443aa84-091a-4638-a153-8c07754c53cc", () => UserQuestionUserTask1.ActivityPriority);
			MetaPathParameterValues.Add("3210c491-5bf8-4c44-809f-2ccea5bab678", () => UserQuestionUserTask1.ConfItem);
			MetaPathParameterValues.Add("f2efe05d-aea3-45b2-ac3b-b435686ba5c7", () => UserQuestionUserTask1.Event);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "UserQuestionUserTask1.ConfItem":
					UserQuestionUserTask1.ConfItem = reader.GetValue<System.Guid>();
				break;
				case "UserQuestionUserTask1.Event":
					UserQuestionUserTask1.Event = reader.GetValue<System.Guid>();
				break;
				case "CurrentTaskId":
					if (!hasValueToRead) break;
					CurrentTaskId = reader.GetValue<System.Guid>();
				break;
				case "ActivityDueDate":
					if (!hasValueToRead) break;
					ActivityDueDate = reader.GetValue<System.DateTime>();
				break;
				case "ActivityStartDate":
					if (!hasValueToRead) break;
					ActivityStartDate = reader.GetValue<System.DateTime>();
				break;
				case "ProcessUId":
					if (!hasValueToRead) break;
					ProcessUId = reader.GetValue<System.Guid>();
				break;
				case "IsTaskExists":
					if (!hasValueToRead) break;
					IsTaskExists = reader.GetValue<System.Boolean>();
				break;
				case "NotStartedActivityStatusId":
					if (!hasValueToRead) break;
					NotStartedActivityStatusId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ExistsDiagnoseIncidentTaskExecute(ProcessExecutingContext context) {
			var sysProcessEntitySelect = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysProcessEntity");
			sysProcessEntitySelect.AddColumn("SysProcess");
			var entityRecordId = ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("Id");
			sysProcessEntitySelect.Filters.Add(sysProcessEntitySelect.CreateFilterWithParameters(FilterComparisonType.Equal, "EntityId", entityRecordId));
			sysProcessEntitySelect.Filters.Add(sysProcessEntitySelect.CreateFilterWithParameters(FilterComparisonType.Equal, "[SysProcessLog:Id:SysProcess].SysSchema.UId", ProcessUId));
			sysProcessEntitySelect.Filters.Add(sysProcessEntitySelect.CreateFilterWithParameters(FilterComparisonType.Equal, "[Activity:Case:EntityId].Status", NotStartedActivityStatusId));
			var collection = sysProcessEntitySelect.GetEntityCollection(UserConnection); 
			IsTaskExists = collection.Count > 0;
			return true; 
		}

		public virtual bool SetCurrentTaskExecute(ProcessExecutingContext context) {
			var localCurrentTaskId = (AddDiagnoseTask.RecordId);
			CurrentTaskId = (System.Guid)localCurrentTaskId;
			return true;
		}

		public virtual bool SetRescheduledTaskFormulaExecute(ProcessExecutingContext context) {
			var localCurrentTaskId = (AddRescheduledTaskUserTask.RecordId);
			CurrentTaskId = (System.Guid)localCurrentTaskId;
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var startDate = UserConnection.CurrentUser.GetCurrentDateTime();
			int startMinute = startDate.Minute;
			startMinute = (((startMinute / 5) + 2 * (startMinute % 5) / 5) * 5) % 60;
			var val = startDate.AddMinutes(-startDate.Minute);
			startDate = val.AddMinutes(startMinute);
			startDate = startDate.AddSeconds(-startDate.Second);
			ActivityStartDate = startDate;
			ActivityDueDate = startDate.AddMinutes(30);
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
			var cloneItem = (IncidentDiagnosticsAndResolvingV2)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


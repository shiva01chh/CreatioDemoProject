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

	#region Class: IncidentDiagnosticsAndResolvingSchema

	/// <exclude/>
	public class IncidentDiagnosticsAndResolvingSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public IncidentDiagnosticsAndResolvingSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public IncidentDiagnosticsAndResolvingSchema(IncidentDiagnosticsAndResolvingSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "IncidentDiagnosticsAndResolving";
			UId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57");
			CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f");
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
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57");
			Version = 0;
			PackageUId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("415d89df-f50f-46b6-8a77-b034e8173608"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Name = @"ProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"Guid.Parse(""6AEEED31-5D8C-452E-B157-ED9AD8B83E57"")",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsTaskExistsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ecd8a32c-df30-44e9-89f6-3adc6c3bdfd8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Name = @"IsTaskExists",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"false",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateNotStartedActivityStatusIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ec21229b-9b25-49d7-92ad-eed18aa728e5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Name = @"NotStartedActivityStatusId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.805aace4-8604-40e7-a9eb-0f54174593c0.384d4b84-58e6-df11-971b-001d60e938c6#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentTaskIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ae73a291-5391-4398-ad71-c61091bd78fe"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Name = @"TaskCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateTaskCaptionValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a0a5e89d-ee0e-4227-948e-7fcad6fbb49e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("391f4991-86a6-4a6d-9a3e-b08a114cc7d3"),
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Name = @"TaskCaptionValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateActivityDueDateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("77719740-2177-4b8a-b22a-54a091ab6496"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				ModifiedInSchemaUId = Guid.Empty
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				ModifiedInSchemaUId = Guid.Empty
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,152,91,111,83,73,12,128,255,74,116,224,141,58,154,139,231,214,55,4,172,84,9,88,180,237,242,66,121,240,204,120,32,34,205,169,146,19,86,221,170,255,125,125,210,22,90,180,244,162,85,151,34,154,135,84,153,30,123,60,182,63,219,115,142,187,199,195,209,33,119,219,221,30,47,151,180,234,219,48,125,214,47,121,250,102,217,23,94,173,166,47,251,66,243,217,223,148,231,252,134,150,116,192,3,47,223,210,124,205,171,151,179,213,176,53,185,44,214,109,117,143,63,111,254,219,109,191,59,238,118,6,62,248,115,167,138,118,180,204,49,163,7,114,49,2,22,67,144,155,67,200,33,83,181,74,151,230,162,8,151,126,190,62,88,188,226,129,222,208,240,177,219,62,238,54,218,68,65,137,26,27,5,13,172,116,6,180,198,1,149,88,33,86,36,147,44,87,109,99,119,178,213,173,202,71,62,160,205,166,23,132,17,83,141,214,0,97,41,128,89,105,200,169,58,136,164,77,65,67,169,197,52,10,159,61,255,85,240,221,163,151,125,255,105,125,56,77,94,179,81,81,236,215,70,182,175,38,64,86,201,1,170,172,217,99,245,165,168,105,115,186,160,71,11,46,178,135,218,180,134,20,196,90,165,116,245,138,147,141,197,63,122,63,110,84,103,171,195,57,29,189,253,238,126,79,203,48,251,60,27,142,38,133,6,254,208,47,143,166,123,253,164,246,167,210,135,151,2,113,81,254,120,255,52,158,251,221,246,254,247,34,122,246,119,119,227,168,203,49,253,54,156,251,221,214,126,183,219,175,151,101,212,104,229,199,243,11,134,111,54,217,60,242,205,207,243,248,201,202,98,61,159,159,173,60,167,129,206,31,60,95,238,235,172,205,184,238,44,118,207,195,182,209,162,206,62,240,47,95,231,159,83,219,254,139,216,43,90,208,7,94,190,22,7,124,181,253,139,149,123,226,198,115,197,217,36,167,130,110,16,152,18,32,123,35,121,167,9,146,78,185,217,96,77,107,102,35,253,7,55,94,242,162,240,101,195,110,146,61,103,242,171,141,183,71,112,206,236,26,93,117,210,157,156,108,93,196,73,114,43,212,192,14,180,170,26,80,215,2,49,97,5,175,114,78,201,249,192,45,93,137,83,83,193,250,70,22,66,26,21,4,175,128,216,39,72,158,139,243,41,89,76,250,46,112,122,183,179,250,253,175,5,47,79,253,179,221,104,190,226,247,83,89,253,102,225,197,156,15,120,49,108,31,199,230,2,178,203,16,188,65,49,212,24,72,74,130,96,75,243,78,42,71,38,138,39,34,240,37,145,183,143,3,57,77,24,13,148,226,189,56,199,5,160,224,29,168,80,27,113,98,213,124,30,69,94,44,6,33,236,217,198,71,34,165,188,81,85,178,133,145,9,80,226,11,169,137,95,209,5,211,74,149,58,163,69,234,58,124,255,96,170,194,236,138,39,85,18,105,250,219,108,185,26,38,51,137,219,164,111,147,37,175,214,243,97,182,248,48,145,192,204,89,16,239,23,211,141,59,30,184,254,41,185,214,62,179,245,78,67,108,108,198,76,75,34,95,5,165,168,108,69,31,109,173,246,86,92,123,105,18,205,101,177,192,141,10,141,244,187,236,36,127,37,117,157,150,228,109,74,211,149,92,231,70,148,74,104,80,172,151,62,139,74,78,100,181,88,164,131,247,170,81,211,120,39,109,242,254,114,237,109,242,13,61,67,193,212,0,91,150,104,57,37,131,131,193,232,83,107,10,179,189,11,174,159,245,139,129,202,240,64,246,3,217,35,217,146,115,200,99,247,143,213,166,145,236,188,97,18,60,103,14,108,156,247,132,87,146,141,161,96,45,24,36,123,141,40,168,138,129,164,131,67,51,41,230,108,84,145,9,248,215,34,155,88,49,186,66,35,217,50,75,53,22,41,155,42,88,202,193,132,200,218,235,112,23,100,239,212,7,168,127,78,168,101,104,150,135,4,101,19,36,97,156,69,136,40,151,52,45,89,167,181,43,156,74,189,21,212,138,93,12,72,12,129,148,31,51,80,218,74,204,14,140,0,93,172,193,100,203,213,237,90,136,110,138,172,134,208,106,16,168,165,243,147,82,40,51,168,182,89,7,177,208,254,208,49,252,34,163,165,102,116,30,65,203,28,33,166,22,161,173,229,10,100,106,162,146,2,145,217,244,209,39,147,253,110,242,104,191,123,114,159,75,71,200,177,176,207,8,38,73,253,64,37,135,201,76,227,176,149,91,200,82,105,21,210,245,165,99,143,86,159,164,116,28,142,85,225,210,193,111,95,83,94,175,15,242,195,53,224,7,213,21,233,33,214,181,205,148,44,12,97,241,146,67,201,19,88,105,243,228,169,81,105,229,170,186,114,99,195,110,90,87,82,147,202,49,18,86,41,216,241,101,151,12,11,77,166,15,207,190,198,86,108,86,249,154,235,125,86,213,55,185,194,234,32,89,141,36,37,133,180,115,82,41,178,71,91,124,85,191,218,53,32,107,103,149,41,73,16,47,178,81,77,56,186,212,129,76,115,74,220,77,181,177,190,139,97,225,105,41,253,122,241,112,13,248,57,39,6,227,106,40,154,50,232,202,74,38,134,17,133,241,78,173,140,204,158,142,130,169,158,111,57,49,216,106,124,8,32,215,121,33,91,57,132,36,26,33,33,114,166,76,205,26,115,245,196,160,172,180,46,57,145,118,89,46,38,222,74,213,202,217,131,180,48,27,2,101,44,41,223,151,137,33,4,157,130,28,206,104,57,48,230,72,144,141,33,112,82,143,146,56,213,99,242,215,35,119,254,38,252,249,154,37,196,252,0,210,15,1,169,26,45,165,181,33,20,37,35,32,42,109,36,150,209,67,35,77,81,7,93,9,241,127,109,145,45,72,139,180,45,66,112,65,200,110,198,74,42,231,6,94,197,172,189,216,100,178,189,18,164,49,229,201,217,8,94,103,105,145,73,133,241,125,111,3,165,147,79,218,75,95,168,245,158,128,68,36,163,170,82,21,88,26,157,236,102,189,92,116,165,138,41,219,156,79,46,91,93,203,205,65,218,29,104,57,60,160,244,75,163,244,254,228,31,211,18,24,233,249,29,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				UId = new Guid("38823804-2448-4468-92e6-d9d0f5ec6c2d"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,77,107,219,64,16,253,43,70,135,158,180,65,218,47,237,170,71,227,22,31,154,132,54,45,133,196,132,213,238,200,94,208,135,35,173,154,4,227,255,222,145,149,184,16,104,113,33,61,20,114,219,175,121,243,222,104,222,104,119,235,251,15,190,10,208,229,165,169,122,136,135,165,203,35,227,128,10,202,10,162,132,210,132,83,205,73,97,147,146,104,169,56,75,173,44,25,184,40,110,76,13,121,52,69,47,156,15,81,92,181,107,111,77,117,177,133,206,4,223,54,121,116,209,69,177,15,80,247,249,245,238,87,170,208,13,16,223,150,135,205,23,187,129,218,124,29,211,166,105,230,24,45,53,81,52,19,132,11,198,137,226,105,74,48,163,76,83,97,65,91,76,123,96,152,225,145,19,150,18,43,74,74,120,105,21,41,4,50,204,10,166,50,158,105,142,48,200,7,202,176,120,216,118,208,247,35,155,29,28,215,87,143,91,228,62,229,158,183,213,80,55,81,92,67,48,151,38,108,80,63,36,192,133,53,196,114,141,68,74,200,136,97,218,17,102,138,140,102,10,82,153,102,81,108,205,118,18,185,68,86,206,4,243,205,84,3,28,144,119,30,57,82,150,164,74,72,140,77,153,37,156,209,132,40,169,50,82,58,89,106,96,82,235,226,88,197,143,131,199,181,239,207,135,26,58,111,159,62,6,96,85,219,46,223,217,182,9,93,91,141,208,231,135,231,87,240,16,166,146,63,93,125,159,4,5,60,31,131,162,125,60,244,48,175,60,52,97,209,216,214,249,102,61,97,238,247,24,82,111,77,231,251,231,42,44,238,6,83,69,113,231,215,155,63,86,107,62,244,161,173,255,35,169,49,202,68,12,108,178,3,221,177,7,157,239,183,149,121,60,236,243,232,221,221,208,134,247,243,14,12,66,205,26,184,159,249,198,122,135,72,103,159,193,182,157,155,45,221,244,38,122,129,149,71,55,145,54,78,105,150,1,145,70,160,75,140,180,164,144,69,66,24,181,216,173,89,201,133,176,103,80,72,109,178,146,17,108,87,57,90,137,98,119,115,73,152,178,84,3,79,164,160,250,38,66,17,175,74,237,122,217,95,220,55,207,230,154,202,177,58,195,211,23,7,139,10,106,132,204,119,167,104,217,99,192,229,115,42,108,143,19,148,237,87,163,182,21,54,221,171,186,95,178,68,201,4,239,52,36,28,159,74,192,249,100,52,73,25,99,194,9,38,148,122,115,255,155,251,79,114,255,39,140,41,61,122,204,55,198,6,255,3,142,70,155,221,251,176,153,97,159,86,120,107,176,20,235,6,224,20,247,89,40,129,242,132,18,71,57,16,46,37,37,154,74,69,18,102,37,45,56,40,227,146,51,227,198,159,105,98,9,99,182,32,188,72,128,232,108,172,161,164,46,17,38,75,68,81,252,126,48,252,3,214,127,61,51,78,145,249,98,102,156,34,250,56,51,86,251,159,120,166,224,206,158,8,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,177,50,176,50,208,241,43,205,77,74,45,178,50,180,50,4,0,178,212,123,197,17,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bc481380-5343-4b25-8cb1-a6d8dc980555"),
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
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("15affdc1-11bb-4c74-b27b-02758669fa13"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,201,110,219,48,16,253,21,67,231,48,16,37,70,75,110,65,146,22,190,52,1,28,228,82,231,48,164,134,54,17,109,32,169,180,110,224,127,239,72,178,157,164,112,27,183,40,186,160,245,193,150,158,31,103,222,172,124,12,84,9,206,189,131,10,131,211,224,6,173,5,215,104,127,252,198,148,30,237,91,219,116,109,112,20,56,180,6,74,243,9,139,17,191,44,140,191,0,15,116,228,113,254,100,97,30,156,206,247,219,152,7,71,243,192,120,172,28,113,232,72,174,82,45,18,133,76,196,90,49,17,197,41,147,69,36,152,6,21,233,2,82,137,49,31,153,95,51,126,222,84,45,88,28,125,12,230,245,240,120,179,106,123,42,39,64,13,20,227,154,122,3,198,189,8,119,89,131,44,177,160,119,111,59,36,200,91,83,81,52,120,99,42,188,6,75,190,122,59,77,15,17,73,67,233,122,86,137,218,95,126,108,45,58,103,154,250,53,113,101,87,213,207,217,100,0,119,175,27,57,225,160,177,103,94,131,95,14,38,166,36,107,61,168,60,91,44,44,46,192,155,135,231,34,238,113,53,240,14,203,31,29,40,168,74,183,80,118,248,204,231,203,72,206,161,245,99,64,163,123,34,88,179,88,30,28,235,46,99,175,133,27,17,216,110,201,7,218,220,27,67,148,16,248,208,3,163,149,237,227,60,120,63,117,87,31,106,180,51,181,196,10,198,172,221,29,19,250,5,176,179,127,250,8,152,198,16,229,156,157,196,244,37,226,60,99,80,164,156,169,132,135,57,151,69,154,105,92,223,141,58,140,107,75,88,221,238,220,157,119,214,98,237,39,30,220,253,100,122,49,144,250,20,210,95,17,10,149,131,136,153,226,39,146,137,48,137,152,12,165,100,41,151,39,121,148,1,207,185,166,82,211,135,206,164,42,206,242,20,128,37,105,92,48,145,10,201,242,84,32,11,115,201,181,130,12,179,127,115,26,102,30,124,231,104,143,212,198,45,15,27,140,195,82,185,167,169,120,244,205,201,216,72,25,127,38,198,77,180,169,161,252,27,166,101,8,108,59,34,67,186,54,93,87,54,11,163,160,188,106,209,194,38,206,112,127,75,188,232,165,126,248,108,211,248,113,164,118,114,206,20,85,196,248,213,160,97,91,13,4,41,18,224,154,37,66,135,84,141,152,166,64,202,152,21,97,36,139,4,69,166,85,191,240,232,134,233,85,207,154,206,170,77,15,187,241,106,249,161,43,227,55,180,254,247,236,246,189,253,114,72,253,255,239,193,236,15,47,241,158,133,245,211,170,253,203,231,120,29,172,63,3,144,22,16,11,30,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5ce57c9f-0b11-4679-8661-6fcd0e1a0dde"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,201,110,219,48,16,253,21,67,231,48,144,72,89,18,125,11,146,180,200,165,9,16,35,151,58,135,161,52,178,137,104,3,73,165,117,13,255,123,71,146,173,36,133,219,184,69,209,5,173,15,182,244,252,56,243,102,229,198,75,11,176,246,29,148,232,205,188,57,26,3,182,206,221,233,27,93,56,52,111,77,221,54,222,137,103,209,104,40,244,39,204,6,252,50,211,238,2,28,208,145,205,226,201,194,194,155,45,14,219,88,120,39,11,79,59,44,45,113,232,8,40,158,134,129,140,152,226,10,89,40,2,159,41,41,98,150,196,232,7,89,24,10,149,37,3,243,107,198,207,235,178,1,131,131,143,222,124,222,63,206,215,77,71,13,8,72,123,138,182,117,181,3,69,39,194,94,86,160,10,204,232,221,153,22,9,114,70,151,20,13,206,117,137,55,96,200,87,103,167,238,32,34,229,80,216,142,85,96,238,46,63,54,6,173,213,117,245,154,184,162,45,171,231,108,50,128,227,235,78,142,223,107,236,152,55,224,86,189,137,43,146,181,237,85,158,45,151,6,151,224,244,227,115,17,15,184,238,121,199,229,143,14,100,84,165,59,40,90,124,230,243,101,36,231,208,184,33,160,193,61,17,140,94,174,142,142,117,204,216,107,225,114,2,155,61,249,72,155,7,99,224,17,129,143,29,48,88,217,63,46,188,247,87,246,250,67,133,230,54,93,97,9,67,214,238,79,9,253,2,24,237,207,54,128,177,0,46,3,54,21,244,21,10,153,48,200,226,128,165,81,224,203,64,101,113,146,227,246,126,208,161,109,83,192,250,110,116,119,222,26,131,149,155,56,176,15,147,171,139,158,212,165,144,254,138,68,34,80,9,197,184,192,136,133,190,31,48,165,20,176,76,228,42,73,49,228,97,230,83,169,233,67,103,166,121,154,38,10,21,147,145,228,68,14,19,150,160,20,108,26,65,28,197,145,136,165,244,255,197,105,184,117,224,90,75,123,164,210,118,117,220,96,28,151,202,3,77,21,240,111,78,198,78,202,240,51,209,118,146,235,10,138,191,97,90,250,192,246,35,210,167,107,215,117,69,189,212,41,20,215,13,26,216,197,233,31,110,137,23,189,212,13,159,169,107,55,140,212,40,231,44,165,138,104,183,238,53,236,171,33,227,169,84,1,23,140,250,93,178,80,249,156,73,206,21,203,33,203,68,16,39,232,231,17,213,149,110,152,78,245,109,221,154,116,215,195,118,184,90,126,232,202,248,13,173,255,61,187,253,96,191,28,83,255,255,123,112,220,131,127,104,137,15,44,172,159,86,237,95,62,199,91,111,251,25,146,66,135,34,30,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5d2b98b3-4786-44c0-bd0c-c98b0b4ab617"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,75,111,218,64,16,254,43,200,231,108,228,197,111,110,17,73,43,46,77,36,80,46,117,14,99,123,22,86,241,75,187,235,180,20,241,223,59,182,193,33,149,219,208,170,234,67,45,7,176,135,111,191,249,230,185,59,43,205,65,235,119,80,160,53,179,86,168,20,232,74,152,203,55,50,55,168,222,170,170,169,173,11,75,163,146,144,203,79,152,245,246,155,76,154,107,48,64,71,118,241,51,67,108,205,226,113,142,216,186,136,45,105,176,208,132,161,35,28,33,112,146,64,176,48,74,18,230,2,247,89,226,10,135,113,91,56,126,192,133,199,197,180,71,126,141,124,94,21,53,40,236,125,116,244,162,123,92,109,235,22,202,201,144,118,16,169,171,242,96,116,90,17,250,166,132,36,199,140,222,141,106,144,76,70,201,130,162,193,149,44,240,14,20,249,106,121,170,214,68,32,1,185,110,81,57,10,115,243,177,86,168,181,172,202,215,196,229,77,81,158,162,137,0,135,215,131,28,187,211,216,34,239,192,108,58,138,5,201,218,119,42,175,214,107,133,107,48,242,233,84,196,35,110,59,220,121,249,163,3,25,85,233,30,242,6,79,124,190,140,100,14,181,233,3,234,221,19,64,201,245,230,236,88,135,140,189,22,238,148,140,245,17,124,38,231,104,12,83,159,140,79,173,161,103,57,62,198,214,251,133,190,253,80,162,90,166,27,44,160,207,218,195,37,89,191,48,12,252,179,29,96,224,192,52,226,204,115,232,203,117,162,144,65,22,112,150,250,220,142,120,146,5,161,192,253,67,175,67,234,58,135,237,253,224,110,222,40,133,165,153,24,208,143,147,197,117,7,106,83,72,127,97,224,251,136,153,199,60,219,165,2,133,174,203,66,55,33,47,174,136,184,135,94,8,144,82,169,233,211,18,71,66,248,161,200,24,146,59,230,102,60,98,73,230,112,22,56,54,119,66,223,7,30,186,255,226,52,44,13,152,70,211,30,41,165,222,156,55,24,231,165,114,164,169,248,244,155,147,113,144,210,255,76,164,158,8,89,66,254,55,76,75,23,216,113,68,186,116,29,186,46,175,214,50,133,252,182,70,5,135,56,237,241,150,120,209,75,237,240,169,170,50,253,72,13,114,174,82,170,136,52,219,78,195,177,26,54,68,224,167,161,96,54,247,129,185,182,131,44,65,145,176,0,193,243,124,16,24,134,237,194,163,27,166,85,189,172,26,149,30,122,88,247,87,203,15,93,25,191,161,245,191,103,183,143,246,203,57,245,255,191,7,135,61,248,135,150,120,100,97,253,180,106,255,242,57,222,91,251,207,221,92,155,43,30,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fa90eb4a-37cf-4197-a808-a074f52a3864"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,201,110,219,48,16,253,21,131,135,158,196,64,20,41,46,234,45,134,91,228,146,6,72,91,20,72,140,96,184,197,68,180,56,18,133,38,48,252,239,165,173,56,45,140,160,232,122,200,69,162,70,156,55,111,6,239,205,230,38,12,239,66,29,93,95,121,168,7,151,141,103,182,66,146,11,197,140,163,24,132,215,152,177,60,199,96,164,197,196,216,66,80,193,104,238,74,148,181,208,184,10,77,217,11,27,34,202,66,116,205,80,93,109,190,131,198,126,116,217,141,223,127,92,154,149,107,224,211,174,128,97,76,89,73,11,12,204,24,204,116,78,176,86,182,196,18,72,97,88,1,202,75,133,38,46,66,128,160,94,114,44,149,86,152,229,101,137,193,38,86,70,91,37,10,157,115,34,4,202,106,231,227,226,97,221,187,97,8,93,91,109,220,243,249,227,227,58,177,156,106,207,187,122,108,90,148,53,46,194,5,196,85,133,192,229,142,149,6,176,97,170,196,204,59,129,129,42,139,41,104,81,8,233,72,130,71,153,129,117,220,193,162,51,139,50,11,17,62,67,61,186,61,242,38,36,142,5,205,137,44,121,202,37,52,181,67,139,28,75,46,5,246,150,123,229,40,87,74,219,195,188,222,143,33,157,195,112,62,54,174,15,230,105,236,46,205,175,235,171,141,233,218,216,119,245,14,250,124,127,253,163,123,136,211,112,159,126,125,153,26,138,41,190,75,66,219,108,28,220,188,14,174,141,139,214,116,54,180,183,19,230,118,155,82,154,53,244,97,56,76,97,113,63,66,141,178,62,220,174,126,58,173,249,56,196,174,121,69,173,102,169,205,132,145,68,182,167,187,211,160,13,195,186,134,199,253,119,133,222,220,143,93,124,59,31,251,62,37,207,34,12,119,179,96,167,32,58,74,174,208,117,146,133,160,80,40,130,75,154,30,140,42,153,68,39,8,54,156,228,138,104,43,164,119,215,40,17,250,187,50,87,103,195,135,175,237,193,25,83,47,203,147,20,61,10,92,28,50,171,205,175,48,219,46,119,220,150,73,0,255,212,137,134,11,6,105,47,96,174,4,195,12,52,197,218,23,26,243,146,1,241,37,101,68,186,63,119,98,218,47,146,121,101,176,102,50,237,28,161,52,86,96,120,218,62,164,240,148,81,110,160,56,209,60,213,80,146,166,61,144,167,75,206,185,164,62,86,98,207,161,164,222,210,162,116,230,7,187,94,70,136,227,112,50,189,102,97,152,249,208,238,12,240,130,174,85,174,121,169,189,196,185,247,105,14,132,17,44,133,80,184,96,69,158,14,224,85,46,14,186,62,237,186,218,65,251,27,210,158,175,156,185,59,237,30,142,165,109,118,113,157,226,255,195,197,207,170,121,93,13,191,224,229,99,231,236,47,238,21,190,220,126,3,87,222,244,191,194,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,77,111,19,49,16,253,43,145,233,49,142,252,181,94,59,55,68,57,84,106,81,69,75,47,77,15,99,123,76,87,108,178,97,63,42,149,40,255,29,199,73,104,130,40,138,144,56,32,225,195,174,188,227,55,111,60,111,222,174,200,89,255,188,68,50,37,183,216,182,208,53,177,159,188,107,90,156,92,183,141,199,174,155,92,54,30,234,234,27,184,26,175,161,133,57,246,216,222,65,61,96,119,89,117,253,120,116,12,35,99,114,246,148,163,100,122,191,34,23,61,206,63,93,132,148,221,27,41,60,48,79,75,167,35,85,210,122,106,184,46,210,86,114,227,148,15,82,219,4,246,77,61,204,23,87,216,195,53,244,143,100,186,34,57,91,78,16,140,138,9,230,148,113,84,149,214,81,11,94,83,165,184,136,82,73,237,65,144,245,152,116,254,17,231,144,73,15,192,74,217,144,42,160,160,188,167,202,49,78,157,13,5,53,192,133,87,2,108,52,118,3,222,157,127,1,222,191,185,108,154,47,195,114,98,88,1,224,81,81,163,153,162,138,97,73,193,162,163,44,22,138,151,170,176,210,179,137,114,193,57,99,34,45,12,106,26,34,231,212,150,60,29,98,60,104,134,86,26,175,223,60,108,136,66,213,45,107,120,190,123,149,239,173,239,171,167,170,127,30,117,61,244,67,151,154,59,95,214,169,247,97,139,95,30,73,113,152,97,53,219,42,58,35,211,217,107,154,238,222,55,185,85,199,170,254,44,232,140,140,103,228,166,25,90,191,201,40,55,155,125,131,51,3,219,45,250,139,199,126,109,115,100,216,21,44,224,51,182,31,18,99,134,231,208,57,244,144,201,111,83,221,251,196,78,216,130,149,60,210,18,193,82,133,90,80,19,56,80,203,173,139,178,148,34,70,145,209,31,49,98,139,11,143,199,133,157,34,88,198,103,230,151,98,246,179,151,190,44,134,186,206,4,93,190,255,102,152,119,133,239,34,231,7,42,30,100,104,66,21,43,12,23,139,63,108,213,166,132,31,61,217,177,173,201,122,61,62,52,148,82,172,176,209,137,237,32,43,109,83,107,132,240,148,21,133,9,24,163,180,44,252,214,80,128,178,20,62,2,5,145,186,172,202,200,146,29,180,162,188,12,92,150,232,208,106,253,23,13,37,133,117,129,105,164,209,22,137,222,8,69,129,69,71,77,129,33,73,27,133,85,102,146,60,93,164,139,48,170,75,153,134,0,82,220,106,161,41,67,224,80,148,169,2,171,78,52,84,82,113,168,251,81,19,71,176,179,214,228,125,151,126,109,208,87,205,98,212,226,215,161,106,255,187,235,84,119,157,162,222,63,230,174,135,245,119,97,203,197,148,12,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fd957cac-7757-4375-864c-a41078a5c3fc"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,77,111,219,56,16,253,43,134,206,101,64,73,164,62,124,43,178,238,34,151,54,216,4,189,212,57,140,200,161,35,84,150,4,138,206,110,214,240,127,223,161,100,59,78,19,187,74,209,98,3,52,39,203,163,225,211,124,188,55,156,117,160,42,232,186,143,176,196,96,26,92,163,181,208,53,198,157,125,40,43,135,246,79,219,172,218,224,93,208,161,45,161,42,255,69,61,216,103,186,116,127,128,3,58,178,158,63,32,204,131,233,252,121,140,121,240,110,30,148,14,151,29,249,208,17,145,25,147,96,36,88,42,226,136,9,201,21,3,13,138,165,104,100,196,77,4,25,152,193,243,24,248,69,61,192,247,200,166,127,188,190,111,189,151,32,131,106,150,45,216,178,107,234,173,49,246,223,239,102,53,20,21,106,250,239,236,10,201,228,108,185,164,68,240,186,92,226,37,88,250,140,199,105,188,137,156,12,84,157,247,170,208,184,217,63,173,197,174,43,155,250,116,92,231,77,181,90,214,135,222,4,128,251,191,219,112,120,31,163,247,188,4,119,219,67,156,67,71,111,54,125,156,239,23,11,139,11,112,229,221,97,24,95,241,190,247,28,87,60,58,160,169,69,159,161,90,225,246,171,33,127,146,204,57,180,110,200,105,23,1,185,88,52,104,177,86,120,165,110,113,9,251,44,31,28,202,197,237,1,136,111,234,151,19,53,217,87,246,123,101,137,200,216,238,156,79,215,249,242,193,237,153,76,163,132,140,119,222,48,160,236,30,231,193,151,139,238,211,223,53,218,33,181,161,182,55,103,100,253,198,48,171,112,137,181,155,174,51,35,83,129,178,96,105,66,37,23,105,20,177,156,67,206,98,101,18,169,99,94,0,100,27,58,176,15,104,186,78,65,134,32,178,136,41,149,36,76,132,50,101,144,38,146,241,84,27,192,28,185,73,10,127,100,86,187,210,221,15,140,153,174,1,57,10,169,128,41,145,75,38,12,210,169,56,215,44,134,34,141,210,12,195,36,76,55,55,67,186,101,215,86,112,255,121,159,213,95,8,122,162,168,61,19,95,9,82,158,237,220,196,235,109,210,152,9,213,120,85,185,178,94,76,136,114,21,42,223,240,179,11,221,35,249,31,58,111,162,72,166,89,92,48,224,146,40,21,39,49,43,66,76,88,14,5,134,40,83,13,57,81,106,179,217,220,120,130,166,69,146,21,66,43,150,112,12,89,95,156,12,243,144,1,70,25,167,114,128,130,248,116,247,78,140,6,76,120,172,184,7,207,208,48,193,61,187,165,84,76,199,20,67,154,139,88,134,234,55,27,13,87,14,220,170,27,55,28,198,149,239,229,195,97,23,195,137,241,240,158,152,117,71,132,62,116,125,237,131,162,207,250,96,80,108,245,16,231,66,139,34,19,76,102,164,2,109,194,144,229,105,88,48,206,67,77,164,207,227,76,37,61,222,254,131,23,245,164,181,205,194,135,217,191,120,152,56,163,177,158,168,250,17,230,78,124,73,161,163,60,215,5,147,154,35,19,58,85,44,203,105,86,68,40,37,42,174,12,202,228,77,31,71,245,49,174,124,111,250,248,142,62,178,151,234,227,99,227,38,157,3,235,80,127,171,143,177,88,79,244,241,8,179,215,135,103,64,213,44,74,5,213,167,22,45,108,219,19,62,79,225,71,220,247,27,131,109,26,119,164,105,125,4,59,18,141,187,0,143,69,195,127,114,52,156,54,132,44,22,33,83,81,166,153,16,177,98,57,113,156,105,97,12,209,58,18,180,133,80,52,180,199,251,238,94,53,43,171,112,152,0,221,176,192,255,208,98,254,63,12,142,151,173,209,71,180,53,70,43,111,235,228,235,92,39,127,104,77,124,165,68,61,188,180,126,34,85,31,13,236,177,203,199,139,87,139,223,187,166,163,46,172,95,125,29,253,210,219,101,19,108,254,3,22,67,249,254,26,18,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d54609de-42c1-4043-91d7-382901823d54"),
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
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("67c472af-8203-4b58-af97-3714096bbc13"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,75,111,227,54,16,254,43,134,206,203,128,122,145,162,111,139,212,45,114,233,6,77,176,151,117,14,35,114,232,8,149,37,131,162,211,186,134,255,123,135,146,95,219,56,94,111,176,216,7,182,23,75,26,207,12,231,241,125,156,89,71,186,134,174,251,29,230,24,141,163,123,116,14,186,214,250,171,95,171,218,163,251,205,181,203,69,244,38,234,208,85,80,87,255,160,25,228,19,83,249,95,192,3,153,172,167,7,15,211,104,60,61,237,99,26,189,153,70,149,199,121,71,58,100,34,36,231,41,22,49,19,138,35,203,120,90,48,101,64,51,45,179,34,231,2,178,92,219,65,243,37,231,55,205,224,190,247,108,251,215,251,213,34,104,101,36,208,237,124,1,174,234,218,102,43,76,195,249,221,164,129,178,70,67,223,222,45,145,68,222,85,115,74,4,239,171,57,222,130,163,99,130,159,54,136,72,201,66,221,5,173,26,173,159,252,189,112,216,117,85,219,156,143,235,186,173,151,243,230,88,155,28,224,254,115,27,14,239,99,12,154,183,224,31,123,23,215,208,209,63,155,62,206,183,179,153,195,25,248,234,233,56,140,63,113,213,107,94,86,60,50,48,212,162,247,80,47,113,123,106,204,159,37,115,13,11,63,228,180,139,128,84,28,90,116,216,104,188,211,143,56,135,125,150,7,133,106,246,120,228,36,52,245,195,153,154,236,43,251,169,178,36,36,92,236,148,207,215,249,246,160,118,34,211,68,144,240,41,8,6,47,187,215,105,244,225,166,123,247,87,131,110,72,109,168,237,195,21,73,255,35,152,212,56,199,198,143,215,133,205,101,134,121,201,164,72,50,150,201,36,97,138,131,98,169,182,34,55,41,47,1,138,13,25,236,3,26,175,37,228,49,100,69,194,180,22,130,101,113,46,25,72,145,51,46,141,5,84,200,173,40,131,201,164,241,149,95,13,136,25,175,1,57,82,235,128,233,76,229,44,179,72,86,169,50,44,133,82,38,178,192,88,196,114,243,48,164,91,117,139,26,86,239,247,89,253,129,96,70,154,218,51,10,149,32,230,185,206,143,2,223,70,173,29,81,141,151,181,175,154,217,136,32,87,163,14,13,191,186,49,189,167,240,32,251,50,179,5,87,90,176,196,170,146,101,153,140,153,210,210,178,52,193,212,232,56,6,72,53,129,115,179,121,8,0,53,156,190,173,68,22,155,160,29,222,148,177,146,161,40,140,225,86,153,66,137,159,140,189,111,169,170,79,161,153,116,246,172,117,171,203,152,124,89,33,95,195,228,93,20,103,216,252,60,228,31,129,217,125,230,71,204,222,2,216,230,177,206,68,150,178,188,64,193,140,141,9,192,50,46,25,231,177,17,28,85,90,232,161,146,135,3,219,145,105,123,209,225,114,184,216,203,51,2,110,189,237,24,98,185,40,146,18,75,102,185,162,27,64,37,134,129,202,233,39,17,137,80,169,230,144,228,159,66,98,224,0,190,68,147,248,199,164,201,157,7,191,236,232,126,106,170,238,241,50,142,92,86,202,83,72,73,206,114,100,27,202,240,24,85,221,200,86,13,212,167,72,112,33,92,191,30,5,146,35,208,246,229,34,216,133,82,214,237,172,210,80,191,91,160,131,109,158,252,52,36,62,194,82,152,149,174,109,253,11,247,67,31,195,174,27,156,23,152,202,52,103,52,194,12,203,82,160,221,3,139,156,201,184,72,227,210,38,74,2,80,95,105,103,12,81,223,181,75,167,183,24,238,134,101,241,85,75,224,55,152,16,159,183,178,189,112,109,94,130,129,255,87,151,239,115,117,249,78,49,119,122,209,248,130,248,251,104,192,94,58,18,63,123,236,125,131,97,246,202,249,116,114,24,188,170,176,95,251,218,222,68,155,127,1,170,123,216,143,223,15,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b2216f87-53e9-4b0f-819a-17ea487cb6b4"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,75,111,227,54,16,254,43,134,206,203,64,148,72,61,124,91,164,110,145,75,55,104,130,189,172,115,24,146,67,71,168,44,25,20,157,214,53,252,223,59,148,252,218,198,241,122,131,197,62,176,61,217,30,15,135,51,223,124,223,12,215,145,174,161,235,126,135,57,70,227,232,30,157,131,174,181,254,234,215,170,246,232,126,115,237,114,17,189,137,58,116,21,212,213,63,104,6,251,196,84,254,23,240,64,71,214,211,67,132,105,52,158,158,142,49,141,222,76,163,202,227,188,35,31,58,98,185,178,70,22,9,75,148,176,76,164,101,201,148,46,83,166,146,188,48,133,214,169,149,124,240,124,41,248,77,51,132,239,35,219,254,235,253,106,17,188,4,25,116,59,95,128,171,186,182,217,26,211,112,127,55,105,64,213,104,232,183,119,75,36,147,119,213,156,10,193,251,106,142,183,224,232,154,16,167,13,38,114,178,80,119,193,171,70,235,39,127,47,28,118,93,213,54,231,243,186,110,235,229,188,57,246,166,0,184,255,185,77,39,238,115,12,158,183,224,31,251,16,215,208,209,63,155,62,207,183,179,153,195,25,248,234,233,56,141,63,113,213,123,94,6,30,29,48,212,162,247,80,47,113,123,43,143,159,21,115,13,11,63,212,180,203,128,92,28,90,116,216,104,188,211,143,56,135,125,149,7,135,106,246,120,20,36,52,245,195,25,76,246,200,126,10,150,132,140,139,157,243,121,156,111,15,110,39,42,77,50,50,62,5,195,16,101,247,117,26,125,184,233,222,253,213,160,27,74,27,176,125,184,34,235,127,12,147,26,231,216,248,241,186,176,50,23,40,21,203,179,68,48,145,39,9,43,99,40,89,170,109,38,77,26,43,128,98,67,7,246,9,141,215,57,72,14,130,26,164,117,150,49,193,101,206,32,207,36,139,115,99,1,75,140,109,166,194,145,73,227,43,191,26,24,51,94,3,198,40,164,6,166,69,41,153,176,72,167,210,210,176,20,84,78,157,69,158,241,124,243,48,148,91,117,139,26,86,239,247,85,253,129,96,70,154,218,51,10,72,144,242,92,231,71,65,111,163,214,142,8,227,101,237,171,102,54,34,202,213,168,67,195,175,110,76,31,41,124,208,121,52,82,1,151,9,179,5,36,84,36,229,14,121,42,89,154,196,5,165,95,36,73,169,136,156,155,205,67,32,168,200,99,144,66,115,86,170,60,16,208,166,12,20,22,44,87,182,40,80,196,60,238,53,246,51,169,247,45,161,250,20,154,73,119,207,90,183,186,76,201,151,1,249,26,37,239,178,56,163,230,231,41,255,8,202,238,43,63,82,246,150,192,52,242,180,200,68,202,100,129,25,51,150,19,166,57,87,44,142,185,201,98,44,211,66,103,125,188,195,133,237,200,180,189,233,48,28,46,142,242,76,128,219,104,123,133,72,33,75,163,37,227,150,35,19,218,20,172,180,156,102,1,230,42,77,139,28,13,143,63,197,196,160,1,124,73,38,252,199,148,201,157,7,191,236,104,62,53,85,247,120,161,70,46,130,242,20,83,146,179,26,217,166,50,124,140,170,110,100,171,6,234,83,34,184,144,174,95,79,2,201,17,105,123,184,136,118,1,202,186,157,85,26,234,119,11,116,176,173,51,62,77,137,143,184,20,118,165,107,91,255,194,124,232,115,216,117,163,224,34,78,18,224,12,0,105,98,113,27,51,149,103,64,43,209,42,174,140,145,60,46,168,175,244,102,12,89,223,181,75,167,183,28,238,134,199,226,171,30,129,223,96,67,124,222,147,237,133,177,121,9,7,254,127,186,124,159,79,151,239,148,115,167,31,26,95,144,127,31,45,216,75,87,226,103,175,189,111,176,204,94,185,159,78,46,131,87,1,251,181,199,246,38,218,252,11,50,55,23,20,223,15,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38a88de8-a208-4906-8a96-66fe61989e1e"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,151,75,111,27,71,12,128,255,138,176,206,173,166,48,239,135,110,65,146,2,6,156,52,136,221,92,108,31,56,51,28,71,168,188,107,172,86,46,92,67,255,189,92,217,78,236,160,81,156,182,70,19,212,58,72,216,209,144,195,37,249,145,195,171,230,217,112,121,78,205,172,57,164,190,199,101,87,135,233,139,174,167,233,219,190,203,180,92,78,247,187,140,139,249,31,152,22,244,22,123,60,163,129,250,247,184,88,209,114,127,190,28,118,39,247,197,154,221,230,217,197,230,223,102,118,116,213,236,13,116,246,235,94,97,237,38,32,201,148,29,84,75,8,198,250,0,177,20,3,194,203,26,109,200,65,75,195,194,185,91,172,206,218,215,52,224,91,28,62,52,179,171,102,163,141,21,228,32,77,69,47,129,132,76,96,180,178,128,57,20,8,197,160,138,154,138,212,161,89,239,54,203,252,129,206,112,115,232,29,97,99,98,9,90,1,154,156,193,36,33,33,197,98,33,160,84,217,40,140,53,196,81,248,102,255,39,193,163,157,253,174,251,109,117,62,141,78,146,18,193,1,75,240,241,69,121,72,34,90,48,34,73,114,166,184,156,197,180,90,153,141,51,26,108,32,7,165,74,9,209,179,181,66,200,226,4,69,29,178,219,57,25,15,42,243,229,249,2,47,223,127,241,188,231,121,152,95,204,135,203,73,198,129,78,187,254,114,122,216,77,74,119,45,125,126,47,16,119,229,175,142,175,227,121,220,204,142,191,20,209,155,223,131,141,163,238,199,244,243,112,30,55,187,199,205,65,183,234,243,168,81,243,195,203,59,134,111,14,217,108,249,236,241,54,126,188,210,174,22,139,155,149,151,56,224,237,198,219,229,174,204,235,156,202,94,123,112,27,182,141,22,113,243,129,191,248,186,253,92,219,246,79,196,94,99,139,167,212,191,97,7,124,178,253,163,149,135,236,198,91,197,73,69,59,102,42,120,194,8,134,156,226,188,147,8,81,198,84,181,215,170,86,181,145,126,71,149,122,106,51,221,55,236,33,217,115,35,191,220,120,123,4,231,198,174,209,85,235,102,189,222,189,139,83,117,202,162,202,10,100,17,133,213,88,11,41,48,18,193,41,50,197,90,155,137,182,226,100,74,174,2,181,4,95,139,103,139,18,2,10,97,128,140,212,73,122,171,141,150,255,62,78,99,254,224,105,219,45,105,130,109,153,244,252,182,139,11,154,204,219,60,47,212,14,147,157,227,230,167,163,157,163,189,229,47,191,183,212,95,251,112,86,113,177,164,147,41,175,126,182,240,106,65,103,44,53,187,10,213,122,67,54,129,119,202,128,241,74,65,20,28,40,157,171,179,69,139,132,24,214,44,240,49,217,103,87,30,173,68,19,20,228,236,28,24,105,61,160,119,150,235,81,169,72,145,68,117,105,20,121,213,14,76,225,139,141,31,89,42,133,76,46,25,80,49,115,21,19,153,227,72,200,111,111,83,245,201,103,35,12,174,79,182,35,254,48,31,188,35,44,204,62,111,42,156,144,211,159,231,253,114,152,204,57,254,147,174,142,50,171,197,48,111,79,39,28,224,5,113,169,232,218,233,155,213,89,162,254,169,64,252,39,5,194,102,212,182,74,193,128,51,12,38,59,78,167,232,16,116,208,5,29,86,204,53,111,43,16,15,54,236,161,5,34,134,228,157,113,5,138,173,92,113,168,114,237,241,70,64,240,40,60,229,34,201,135,237,5,130,179,185,100,227,33,88,197,37,175,8,2,116,21,161,42,86,157,148,96,21,250,49,250,237,247,11,63,146,32,195,129,134,108,198,210,93,137,165,116,44,160,49,121,229,3,73,39,253,215,224,255,59,96,239,149,39,168,127,200,174,47,165,47,188,41,66,80,158,19,134,123,42,4,195,119,66,201,89,39,37,183,232,152,203,55,65,77,21,75,64,78,112,79,190,50,147,104,32,33,231,162,16,57,241,61,56,90,12,114,43,212,85,120,205,16,107,240,177,112,153,242,142,11,22,185,8,209,81,182,46,70,109,226,35,116,253,239,25,106,47,156,18,133,179,133,204,56,151,112,124,33,214,146,199,9,69,213,92,216,171,50,61,6,212,27,119,60,113,253,99,114,237,18,105,103,37,132,74,106,204,52,38,188,20,70,41,8,93,140,227,150,95,244,55,113,141,73,112,175,85,26,212,8,183,209,124,123,8,60,56,114,103,9,41,4,27,172,79,106,43,215,169,34,198,204,53,33,107,23,192,24,193,111,164,55,183,17,239,156,168,88,165,121,148,225,248,251,229,218,233,232,170,113,52,54,107,46,149,53,113,180,44,143,74,65,153,224,98,173,194,36,253,24,92,191,232,218,1,243,240,68,246,19,217,35,217,186,86,38,219,101,110,42,110,156,211,75,133,100,66,0,169,180,229,201,95,59,41,182,147,93,147,40,174,114,87,146,158,231,76,131,60,162,163,228,105,31,77,114,70,103,87,196,255,141,236,36,173,22,42,71,30,186,51,31,84,34,123,164,242,75,113,128,68,172,17,75,37,249,24,100,63,207,185,91,181,79,100,255,152,100,43,91,124,150,152,64,22,18,124,187,27,81,24,219,164,80,60,213,89,244,170,56,250,26,217,39,235,63,1,251,63,43,74,46,23,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				UId = new Guid("591d77d1-1344-4390-9cda-8dcaa9a64548"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				UId = new Guid("01c906ed-6cc4-4b37-9f7a-09fe54fa385c"),
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
				UId = new Guid("42010ab4-b5ab-4bb9-955a-7b0944552f9e"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57")
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
				UId = new Guid("e43bf708-7a7f-4bd8-aec1-9691f9d06fe7"),
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
				UId = new Guid("e78f7bd8-73bf-4489-b563-8bf2ab3ddf66"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b4dbfeb1-c536-4a67-b205-344a03d90f82"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8f574e5b-7624-4722-90a9-3cf65d30baa8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a5470c4b-b56a-4a48-87ba-c46af633f521"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				Name = @"ReadCaseData",
				Position = new Point(255, 190),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				Instantiate = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ddbda75-9cac-4e42-b94c-5cf1edb45846"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
				CreatedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"),
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
			return new IncidentDiagnosticsAndResolving(userConnection);
		}

		public override object Clone() {
			return new IncidentDiagnosticsAndResolvingSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57"));
		}

		#endregion

	}

	#endregion

	#region Class: IncidentDiagnosticsAndResolving

	/// <exclude/>
	public class IncidentDiagnosticsAndResolving : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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

			public AddDiagnoseTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,152,91,111,83,73,12,128,255,74,116,224,141,58,154,139,231,214,55,4,172,84,9,88,180,237,242,66,121,240,204,120,32,34,205,169,146,19,86,221,170,255,125,125,210,22,90,180,244,162,85,151,34,154,135,84,153,30,123,60,182,63,219,115,142,187,199,195,209,33,119,219,221,30,47,151,180,234,219,48,125,214,47,121,250,102,217,23,94,173,166,47,251,66,243,217,223,148,231,252,134,150,116,192,3,47,223,210,124,205,171,151,179,213,176,53,185,44,214,109,117,143,63,111,254,219,109,191,59,238,118,6,62,248,115,167,138,118,180,204,49,163,7,114,49,2,22,67,144,155,67,200,33,83,181,74,151,230,162,8,151,126,190,62,88,188,226,129,222,208,240,177,219,62,238,54,218,68,65,137,26,27,5,13,172,116,6,180,198,1,149,88,33,86,36,147,44,87,109,99,119,178,213,173,202,71,62,160,205,166,23,132,17,83,141,214,0,97,41,128,89,105,200,169,58,136,164,77,65,67,169,197,52,10,159,61,255,85,240,221,163,151,125,255,105,125,56,77,94,179,81,81,236,215,70,182,175,38,64,86,201,1,170,172,217,99,245,165,168,105,115,186,160,71,11,46,178,135,218,180,134,20,196,90,165,116,245,138,147,141,197,63,122,63,110,84,103,171,195,57,29,189,253,238,126,79,203,48,251,60,27,142,38,133,6,254,208,47,143,166,123,253,164,246,167,210,135,151,2,113,81,254,120,255,52,158,251,221,246,254,247,34,122,246,119,119,227,168,203,49,253,54,156,251,221,214,126,183,219,175,151,101,212,104,229,199,243,11,134,111,54,217,60,242,205,207,243,248,201,202,98,61,159,159,173,60,167,129,206,31,60,95,238,235,172,205,184,238,44,118,207,195,182,209,162,206,62,240,47,95,231,159,83,219,254,139,216,43,90,208,7,94,190,22,7,124,181,253,139,149,123,226,198,115,197,217,36,167,130,110,16,152,18,32,123,35,121,167,9,146,78,185,217,96,77,107,102,35,253,7,55,94,242,162,240,101,195,110,146,61,103,242,171,141,183,71,112,206,236,26,93,117,210,157,156,108,93,196,73,114,43,212,192,14,180,170,26,80,215,2,49,97,5,175,114,78,201,249,192,45,93,137,83,83,193,250,70,22,66,26,21,4,175,128,216,39,72,158,139,243,41,89,76,250,46,112,122,183,179,250,253,175,5,47,79,253,179,221,104,190,226,247,83,89,253,102,225,197,156,15,120,49,108,31,199,230,2,178,203,16,188,65,49,212,24,72,74,130,96,75,243,78,42,71,38,138,39,34,240,37,145,183,143,3,57,77,24,13,148,226,189,56,199,5,160,224,29,168,80,27,113,98,213,124,30,69,94,44,6,33,236,217,198,71,34,165,188,81,85,178,133,145,9,80,226,11,169,137,95,209,5,211,74,149,58,163,69,234,58,124,255,96,170,194,236,138,39,85,18,105,250,219,108,185,26,38,51,137,219,164,111,147,37,175,214,243,97,182,248,48,145,192,204,89,16,239,23,211,141,59,30,184,254,41,185,214,62,179,245,78,67,108,108,198,76,75,34,95,5,165,168,108,69,31,109,173,246,86,92,123,105,18,205,101,177,192,141,10,141,244,187,236,36,127,37,117,157,150,228,109,74,211,149,92,231,70,148,74,104,80,172,151,62,139,74,78,100,181,88,164,131,247,170,81,211,120,39,109,242,254,114,237,109,242,13,61,67,193,212,0,91,150,104,57,37,131,131,193,232,83,107,10,179,189,11,174,159,245,139,129,202,240,64,246,3,217,35,217,146,115,200,99,247,143,213,166,145,236,188,97,18,60,103,14,108,156,247,132,87,146,141,161,96,45,24,36,123,141,40,168,138,129,164,131,67,51,41,230,108,84,145,9,248,215,34,155,88,49,186,66,35,217,50,75,53,22,41,155,42,88,202,193,132,200,218,235,112,23,100,239,212,7,168,127,78,168,101,104,150,135,4,101,19,36,97,156,69,136,40,151,52,45,89,167,181,43,156,74,189,21,212,138,93,12,72,12,129,148,31,51,80,218,74,204,14,140,0,93,172,193,100,203,213,237,90,136,110,138,172,134,208,106,16,168,165,243,147,82,40,51,168,182,89,7,177,208,254,208,49,252,34,163,165,102,116,30,65,203,28,33,166,22,161,173,229,10,100,106,162,146,2,145,217,244,209,39,147,253,110,242,104,191,123,114,159,75,71,200,177,176,207,8,38,73,253,64,37,135,201,76,227,176,149,91,200,82,105,21,210,245,165,99,143,86,159,164,116,28,142,85,225,210,193,111,95,83,94,175,15,242,195,53,224,7,213,21,233,33,214,181,205,148,44,12,97,241,146,67,201,19,88,105,243,228,169,81,105,229,170,186,114,99,195,110,90,87,82,147,202,49,18,86,41,216,241,101,151,12,11,77,166,15,207,190,198,86,108,86,249,154,235,125,86,213,55,185,194,234,32,89,141,36,37,133,180,115,82,41,178,71,91,124,85,191,218,53,32,107,103,149,41,73,16,47,178,81,77,56,186,212,129,76,115,74,220,77,181,177,190,139,97,225,105,41,253,122,241,112,13,248,57,39,6,227,106,40,154,50,232,202,74,38,134,17,133,241,78,173,140,204,158,142,130,169,158,111,57,49,216,106,124,8,32,215,121,33,91,57,132,36,26,33,33,114,166,76,205,26,115,245,196,160,172,180,46,57,145,118,89,46,38,222,74,213,202,217,131,180,48,27,2,101,44,41,223,151,137,33,4,157,130,28,206,104,57,48,230,72,144,141,33,112,82,143,146,56,213,99,242,215,35,119,254,38,252,249,154,37,196,252,0,210,15,1,169,26,45,165,181,33,20,37,35,32,42,109,36,150,209,67,35,77,81,7,93,9,241,127,109,145,45,72,139,180,45,66,112,65,200,110,198,74,42,231,6,94,197,172,189,216,100,178,189,18,164,49,229,201,217,8,94,103,105,145,73,133,241,125,111,3,165,147,79,218,75,95,168,245,158,128,68,36,163,170,82,21,88,26,157,236,102,189,92,116,165,138,41,219,156,79,46,91,93,203,205,65,218,29,104,57,60,160,244,75,163,244,254,228,31,211,18,24,233,249,29,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "6aeeed315d8c452eb157ed9ad8b83e57",
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

			public ReadCaseDataFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,77,107,219,64,16,253,43,70,135,158,180,65,218,47,237,170,71,227,22,31,154,132,54,45,133,196,132,213,238,200,94,208,135,35,173,154,4,227,255,222,145,149,184,16,104,113,33,61,20,114,219,175,121,243,222,104,222,104,119,235,251,15,190,10,208,229,165,169,122,136,135,165,203,35,227,128,10,202,10,162,132,210,132,83,205,73,97,147,146,104,169,56,75,173,44,25,184,40,110,76,13,121,52,69,47,156,15,81,92,181,107,111,77,117,177,133,206,4,223,54,121,116,209,69,177,15,80,247,249,245,238,87,170,208,13,16,223,150,135,205,23,187,129,218,124,29,211,166,105,230,24,45,53,81,52,19,132,11,198,137,226,105,74,48,163,76,83,97,65,91,76,123,96,152,225,145,19,150,18,43,74,74,120,105,21,41,4,50,204,10,166,50,158,105,142,48,200,7,202,176,120,216,118,208,247,35,155,29,28,215,87,143,91,228,62,229,158,183,213,80,55,81,92,67,48,151,38,108,80,63,36,192,133,53,196,114,141,68,74,200,136,97,218,17,102,138,140,102,10,82,153,102,81,108,205,118,18,185,68,86,206,4,243,205,84,3,28,144,119,30,57,82,150,164,74,72,140,77,153,37,156,209,132,40,169,50,82,58,89,106,96,82,235,226,88,197,143,131,199,181,239,207,135,26,58,111,159,62,6,96,85,219,46,223,217,182,9,93,91,141,208,231,135,231,87,240,16,166,146,63,93,125,159,4,5,60,31,131,162,125,60,244,48,175,60,52,97,209,216,214,249,102,61,97,238,247,24,82,111,77,231,251,231,42,44,238,6,83,69,113,231,215,155,63,86,107,62,244,161,173,255,35,169,49,202,68,12,108,178,3,221,177,7,157,239,183,149,121,60,236,243,232,221,221,208,134,247,243,14,12,66,205,26,184,159,249,198,122,135,72,103,159,193,182,157,155,45,221,244,38,122,129,149,71,55,145,54,78,105,150,1,145,70,160,75,140,180,164,144,69,66,24,181,216,173,89,201,133,176,103,80,72,109,178,146,17,108,87,57,90,137,98,119,115,73,152,178,84,3,79,164,160,250,38,66,17,175,74,237,122,217,95,220,55,207,230,154,202,177,58,195,211,23,7,139,10,106,132,204,119,167,104,217,99,192,229,115,42,108,143,19,148,237,87,163,182,21,54,221,171,186,95,178,68,201,4,239,52,36,28,159,74,192,249,100,52,73,25,99,194,9,38,148,122,115,255,155,251,79,114,255,39,140,41,61,122,204,55,198,6,255,3,142,70,155,221,251,176,153,97,159,86,120,107,176,20,235,6,224,20,247,89,40,129,242,132,18,71,57,16,46,37,37,154,74,69,18,102,37,45,56,40,227,146,51,227,198,159,105,98,9,99,182,32,188,72,128,232,108,172,161,164,46,17,38,75,68,81,252,126,48,252,3,214,127,61,51,78,145,249,98,102,156,34,250,56,51,86,251,159,120,166,224,206,158,8,0,0 })));
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

		#region Class: ResolvedCatchSignalFlowElement

		/// <exclude/>
		public class ResolvedCatchSignalFlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public ResolvedCatchSignalFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
				EntityFilters = @"{_isFilter:false,uId:""dadc7b7d-b990-430e-b79d-5376e1f8beb0"",name:""FilterEdit"",items:[{_isFilter:true,_filterSchemaUId:""117d32f9-8275-4534-8411-1c66115ce9cd"",uId:""1fac16a5-a625-4773-a4aa-287aceb4b093"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""a71adaea-3464-4dee-bb4f-c7a535450ad7"",caption:""Status"",referenceSchemaUId:""99f35013-6b7a-47d6-b440-e3f1a0ba991c"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true},parameterValues:[{displayValue:""&quot;Resolved&quot;"",parameterValue:""&quot;ae7f411e-f46b-1410-009b-0050ba5d6c38&quot;""}]}}]}";
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

			public ResolvedChangeDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,201,110,219,48,16,253,21,67,231,48,16,37,70,75,110,65,146,22,190,52,1,28,228,82,231,48,164,134,54,17,109,32,169,180,110,224,127,239,72,178,157,164,112,27,183,40,186,160,245,193,150,158,31,103,222,172,124,12,84,9,206,189,131,10,131,211,224,6,173,5,215,104,127,252,198,148,30,237,91,219,116,109,112,20,56,180,6,74,243,9,139,17,191,44,140,191,0,15,116,228,113,254,100,97,30,156,206,247,219,152,7,71,243,192,120,172,28,113,232,72,174,82,45,18,133,76,196,90,49,17,197,41,147,69,36,152,6,21,233,2,82,137,49,31,153,95,51,126,222,84,45,88,28,125,12,230,245,240,120,179,106,123,42,39,64,13,20,227,154,122,3,198,189,8,119,89,131,44,177,160,119,111,59,36,200,91,83,81,52,120,99,42,188,6,75,190,122,59,77,15,17,73,67,233,122,86,137,218,95,126,108,45,58,103,154,250,53,113,101,87,213,207,217,100,0,119,175,27,57,225,160,177,103,94,131,95,14,38,166,36,107,61,168,60,91,44,44,46,192,155,135,231,34,238,113,53,240,14,203,31,29,40,168,74,183,80,118,248,204,231,203,72,206,161,245,99,64,163,123,34,88,179,88,30,28,235,46,99,175,133,27,17,216,110,201,7,218,220,27,67,148,16,248,208,3,163,149,237,227,60,120,63,117,87,31,106,180,51,181,196,10,198,172,221,29,19,250,5,176,179,127,250,8,152,198,16,229,156,157,196,244,37,226,60,99,80,164,156,169,132,135,57,151,69,154,105,92,223,141,58,140,107,75,88,221,238,220,157,119,214,98,237,39,30,220,253,100,122,49,144,250,20,210,95,17,10,149,131,136,153,226,39,146,137,48,137,152,12,165,100,41,151,39,121,148,1,207,185,166,82,211,135,206,164,42,206,242,20,128,37,105,92,48,145,10,201,242,84,32,11,115,201,181,130,12,179,127,115,26,102,30,124,231,104,143,212,198,45,15,27,140,195,82,185,167,169,120,244,205,201,216,72,25,127,38,198,77,180,169,161,252,27,166,101,8,108,59,34,67,186,54,93,87,54,11,163,160,188,106,209,194,38,206,112,127,75,188,232,165,126,248,108,211,248,113,164,118,114,206,20,85,196,248,213,160,97,91,13,4,41,18,224,154,37,66,135,84,141,152,166,64,202,152,21,97,36,139,4,69,166,85,191,240,232,134,233,85,207,154,206,170,77,15,187,241,106,249,161,43,227,55,180,254,247,236,246,189,253,114,72,253,255,239,193,236,15,47,241,158,133,245,211,170,253,203,231,120,29,172,63,3,144,22,16,11,30,10,0,0 })));
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
						dataList.InitializeLocalizableValues(Storage, "6aeeed315d8c452eb157ed9ad8b83e57",
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

			public CanceledCatchSignalFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
				EntityFilters = @"{_isFilter:false,uId:""543091b1-97e0-45d2-b947-6fda16831f3c"",name:""FilterEdit"",items:[{_isFilter:true,_filterSchemaUId:""117d32f9-8275-4534-8411-1c66115ce9cd"",uId:""5ab56440-a4b9-4680-b192-23bb1a7c7981"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""a71adaea-3464-4dee-bb4f-c7a535450ad7"",caption:""Status"",referenceSchemaUId:""99f35013-6b7a-47d6-b440-e3f1a0ba991c"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true},parameterValues:[{displayValue:""&quot;Cancelled&quot;"",parameterValue:""&quot;6e5f4218-f46b-1410-fe9a-0050ba5d6c38&quot;""}]}}]}";
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

			public CanceledChangeDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,201,110,219,48,16,253,21,67,231,48,144,72,89,18,125,11,146,180,200,165,9,16,35,151,58,135,161,52,178,137,104,3,73,165,117,13,255,123,71,146,173,36,133,219,184,69,209,5,173,15,182,244,252,56,243,102,229,198,75,11,176,246,29,148,232,205,188,57,26,3,182,206,221,233,27,93,56,52,111,77,221,54,222,137,103,209,104,40,244,39,204,6,252,50,211,238,2,28,208,145,205,226,201,194,194,155,45,14,219,88,120,39,11,79,59,44,45,113,232,8,40,158,134,129,140,152,226,10,89,40,2,159,41,41,98,150,196,232,7,89,24,10,149,37,3,243,107,198,207,235,178,1,131,131,143,222,124,222,63,206,215,77,71,13,8,72,123,138,182,117,181,3,69,39,194,94,86,160,10,204,232,221,153,22,9,114,70,151,20,13,206,117,137,55,96,200,87,103,167,238,32,34,229,80,216,142,85,96,238,46,63,54,6,173,213,117,245,154,184,162,45,171,231,108,50,128,227,235,78,142,223,107,236,152,55,224,86,189,137,43,146,181,237,85,158,45,151,6,151,224,244,227,115,17,15,184,238,121,199,229,143,14,100,84,165,59,40,90,124,230,243,101,36,231,208,184,33,160,193,61,17,140,94,174,142,142,117,204,216,107,225,114,2,155,61,249,72,155,7,99,224,17,129,143,29,48,88,217,63,46,188,247,87,246,250,67,133,230,54,93,97,9,67,214,238,79,9,253,2,24,237,207,54,128,177,0,46,3,54,21,244,21,10,153,48,200,226,128,165,81,224,203,64,101,113,146,227,246,126,208,161,109,83,192,250,110,116,119,222,26,131,149,155,56,176,15,147,171,139,158,212,165,144,254,138,68,34,80,9,197,184,192,136,133,190,31,48,165,20,176,76,228,42,73,49,228,97,230,83,169,233,67,103,166,121,154,38,10,21,147,145,228,68,14,19,150,160,20,108,26,65,28,197,145,136,165,244,255,197,105,184,117,224,90,75,123,164,210,118,117,220,96,28,151,202,3,77,21,240,111,78,198,78,202,240,51,209,118,146,235,10,138,191,97,90,250,192,246,35,210,167,107,215,117,69,189,212,41,20,215,13,26,216,197,233,31,110,137,23,189,212,13,159,169,107,55,140,212,40,231,44,165,138,104,183,238,53,236,171,33,227,169,84,1,23,140,250,93,178,80,249,156,73,206,21,203,33,203,68,16,39,232,231,17,213,149,110,152,78,245,109,221,154,116,215,195,118,184,90,126,232,202,248,13,173,255,61,187,253,96,191,28,83,255,255,123,112,220,131,127,104,137,15,44,172,159,86,237,95,62,199,91,111,251,25,146,66,135,34,30,10,0,0 })));
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
						dataList.InitializeLocalizableValues(Storage, "6aeeed315d8c452eb157ed9ad8b83e57",
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

			public PendingCatchSignalFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
				EntityFilters = @"{_isFilter:false,uId:""2348f93f-39d3-43a1-b8ec-124dffb0e7f2"",name:""FilterEdit"",items:[{_isFilter:true,_filterSchemaUId:""117d32f9-8275-4534-8411-1c66115ce9cd"",uId:""2018e7a5-23fd-4373-a3ad-61c145d13fde"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""a71adaea-3464-4dee-bb4f-c7a535450ad7"",caption:""Status"",referenceSchemaUId:""99f35013-6b7a-47d6-b440-e3f1a0ba991c"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true},parameterValues:[{displayValue:""&quot;Pending&quot;"",parameterValue:""&quot;3859c6e7-cbcb-486b-ba53-77808fe6e593&quot;""}]}}]}";
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

			public PendingChangeDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,75,111,218,64,16,254,43,200,231,108,228,197,111,110,17,73,43,46,77,36,80,46,117,14,99,123,22,86,241,75,187,235,180,20,241,223,59,182,193,33,149,219,208,170,234,67,45,7,176,135,111,191,249,230,185,59,43,205,65,235,119,80,160,53,179,86,168,20,232,74,152,203,55,50,55,168,222,170,170,169,173,11,75,163,146,144,203,79,152,245,246,155,76,154,107,48,64,71,118,241,51,67,108,205,226,113,142,216,186,136,45,105,176,208,132,161,35,28,33,112,146,64,176,48,74,18,230,2,247,89,226,10,135,113,91,56,126,192,133,199,197,180,71,126,141,124,94,21,53,40,236,125,116,244,162,123,92,109,235,22,202,201,144,118,16,169,171,242,96,116,90,17,250,166,132,36,199,140,222,141,106,144,76,70,201,130,162,193,149,44,240,14,20,249,106,121,170,214,68,32,1,185,110,81,57,10,115,243,177,86,168,181,172,202,215,196,229,77,81,158,162,137,0,135,215,131,28,187,211,216,34,239,192,108,58,138,5,201,218,119,42,175,214,107,133,107,48,242,233,84,196,35,110,59,220,121,249,163,3,25,85,233,30,242,6,79,124,190,140,100,14,181,233,3,234,221,19,64,201,245,230,236,88,135,140,189,22,238,148,140,245,17,124,38,231,104,12,83,159,140,79,173,161,103,57,62,198,214,251,133,190,253,80,162,90,166,27,44,160,207,218,195,37,89,191,48,12,252,179,29,96,224,192,52,226,204,115,232,203,117,162,144,65,22,112,150,250,220,142,120,146,5,161,192,253,67,175,67,234,58,135,237,253,224,110,222,40,133,165,153,24,208,143,147,197,117,7,106,83,72,127,97,224,251,136,153,199,60,219,165,2,133,174,203,66,55,33,47,174,136,184,135,94,8,144,82,169,233,211,18,71,66,248,161,200,24,146,59,230,102,60,98,73,230,112,22,56,54,119,66,223,7,30,186,255,226,52,44,13,152,70,211,30,41,165,222,156,55,24,231,165,114,164,169,248,244,155,147,113,144,210,255,76,164,158,8,89,66,254,55,76,75,23,216,113,68,186,116,29,186,46,175,214,50,133,252,182,70,5,135,56,237,241,150,120,209,75,237,240,169,170,50,253,72,13,114,174,82,170,136,52,219,78,195,177,26,54,68,224,167,161,96,54,247,129,185,182,131,44,65,145,176,0,193,243,124,16,24,134,237,194,163,27,166,85,189,172,26,149,30,122,88,247,87,203,15,93,25,191,161,245,191,103,183,143,246,203,57,245,255,191,7,135,61,248,135,150,120,100,97,253,180,106,255,242,57,222,91,251,207,221,92,155,43,30,10,0,0 })));
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
						dataList.InitializeLocalizableValues(Storage, "6aeeed315d8c452eb157ed9ad8b83e57",
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

			public EscalationCatchSignalFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
				EntityFilters = @"{_isFilter:false,uId:""dbb99e94-3913-4a55-a508-54e46e4e5b39"",name:""FilterEdit"",logicalOperation:""Or"",items:[{_isFilter:true,_filterSchemaUId:""117d32f9-8275-4534-8411-1c66115ce9cd"",uId:""00341d8c-8bdd-4cd2-834e-302e3c28735b"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""70620d00-e4ea-48d1-9fdc-4572fcd8d41b"",caption:""Owner"",referenceSchemaUId:""16be3651-8fe2-4159-8dd0-a803d4683dd3"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true}},comparisonType:""IsNotNull""},{_isFilter:true,_filterSchemaUId:""117d32f9-8275-4534-8411-1c66115ce9cd"",uId:""bf5aa442-2113-479a-afd5-bf5d470a810d"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""9147230c-ab53-4eb4-b0b4-ac78be6f8326"",caption:""Group"",referenceSchemaUId:""84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true}},comparisonType:""IsNotNull""}]}";
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

			public EscalationChangeDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,201,110,219,48,16,253,21,131,135,158,196,64,20,41,46,234,45,134,91,228,146,6,72,91,20,72,140,96,184,197,68,180,56,18,133,38,48,252,239,165,173,56,45,140,160,232,122,200,69,162,70,156,55,111,6,239,205,230,38,12,239,66,29,93,95,121,168,7,151,141,103,182,66,146,11,197,140,163,24,132,215,152,177,60,199,96,164,197,196,216,66,80,193,104,238,74,148,181,208,184,10,77,217,11,27,34,202,66,116,205,80,93,109,190,131,198,126,116,217,141,223,127,92,154,149,107,224,211,174,128,97,76,89,73,11,12,204,24,204,116,78,176,86,182,196,18,72,97,88,1,202,75,133,38,46,66,128,160,94,114,44,149,86,152,229,101,137,193,38,86,70,91,37,10,157,115,34,4,202,106,231,227,226,97,221,187,97,8,93,91,109,220,243,249,227,227,58,177,156,106,207,187,122,108,90,148,53,46,194,5,196,85,133,192,229,142,149,6,176,97,170,196,204,59,129,129,42,139,41,104,81,8,233,72,130,71,153,129,117,220,193,162,51,139,50,11,17,62,67,61,186,61,242,38,36,142,5,205,137,44,121,202,37,52,181,67,139,28,75,46,5,246,150,123,229,40,87,74,219,195,188,222,143,33,157,195,112,62,54,174,15,230,105,236,46,205,175,235,171,141,233,218,216,119,245,14,250,124,127,253,163,123,136,211,112,159,126,125,153,26,138,41,190,75,66,219,108,28,220,188,14,174,141,139,214,116,54,180,183,19,230,118,155,82,154,53,244,97,56,76,97,113,63,66,141,178,62,220,174,126,58,173,249,56,196,174,121,69,173,102,169,205,132,145,68,182,167,187,211,160,13,195,186,134,199,253,119,133,222,220,143,93,124,59,31,251,62,37,207,34,12,119,179,96,167,32,58,74,174,208,117,146,133,160,80,40,130,75,154,30,140,42,153,68,39,8,54,156,228,138,104,43,164,119,215,40,17,250,187,50,87,103,195,135,175,237,193,25,83,47,203,147,20,61,10,92,28,50,171,205,175,48,219,46,119,220,150,73,0,255,212,137,134,11,6,105,47,96,174,4,195,12,52,197,218,23,26,243,146,1,241,37,101,68,186,63,119,98,218,47,146,121,101,176,102,50,237,28,161,52,86,96,120,218,62,164,240,148,81,110,160,56,209,60,213,80,146,166,61,144,167,75,206,185,164,62,86,98,207,161,164,222,210,162,116,230,7,187,94,70,136,227,112,50,189,102,97,152,249,208,238,12,240,130,174,85,174,121,169,189,196,185,247,105,14,132,17,44,133,80,184,96,69,158,14,224,85,46,14,186,62,237,186,218,65,251,27,210,158,175,156,185,59,237,30,142,165,109,118,113,157,226,255,195,197,207,170,121,93,13,191,224,229,99,231,236,47,238,21,190,220,126,3,87,222,244,191,194,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,77,111,19,49,16,253,43,145,233,49,142,252,181,94,59,55,68,57,84,106,81,69,75,47,77,15,99,123,76,87,108,178,97,63,42,149,40,255,29,199,73,104,130,40,138,144,56,32,225,195,174,188,227,55,111,60,111,222,174,200,89,255,188,68,50,37,183,216,182,208,53,177,159,188,107,90,156,92,183,141,199,174,155,92,54,30,234,234,27,184,26,175,161,133,57,246,216,222,65,61,96,119,89,117,253,120,116,12,35,99,114,246,148,163,100,122,191,34,23,61,206,63,93,132,148,221,27,41,60,48,79,75,167,35,85,210,122,106,184,46,210,86,114,227,148,15,82,219,4,246,77,61,204,23,87,216,195,53,244,143,100,186,34,57,91,78,16,140,138,9,230,148,113,84,149,214,81,11,94,83,165,184,136,82,73,237,65,144,245,152,116,254,17,231,144,73,15,192,74,217,144,42,160,160,188,167,202,49,78,157,13,5,53,192,133,87,2,108,52,118,3,222,157,127,1,222,191,185,108,154,47,195,114,98,88,1,224,81,81,163,153,162,138,97,73,193,162,163,44,22,138,151,170,176,210,179,137,114,193,57,99,34,45,12,106,26,34,231,212,150,60,29,98,60,104,134,86,26,175,223,60,108,136,66,213,45,107,120,190,123,149,239,173,239,171,167,170,127,30,117,61,244,67,151,154,59,95,214,169,247,97,139,95,30,73,113,152,97,53,219,42,58,35,211,217,107,154,238,222,55,185,85,199,170,254,44,232,140,140,103,228,166,25,90,191,201,40,55,155,125,131,51,3,219,45,250,139,199,126,109,115,100,216,21,44,224,51,182,31,18,99,134,231,208,57,244,144,201,111,83,221,251,196,78,216,130,149,60,210,18,193,82,133,90,80,19,56,80,203,173,139,178,148,34,70,145,209,31,49,98,139,11,143,199,133,157,34,88,198,103,230,151,98,246,179,151,190,44,134,186,206,4,93,190,255,102,152,119,133,239,34,231,7,42,30,100,104,66,21,43,12,23,139,63,108,213,166,132,31,61,217,177,173,201,122,61,62,52,148,82,172,176,209,137,237,32,43,109,83,107,132,240,148,21,133,9,24,163,180,44,252,214,80,128,178,20,62,2,5,145,186,172,202,200,146,29,180,162,188,12,92,150,232,208,106,253,23,13,37,133,117,129,105,164,209,22,137,222,8,69,129,69,71,77,129,33,73,27,133,85,102,146,60,93,164,139,48,170,75,153,134,0,82,220,106,161,41,67,224,80,148,169,2,171,78,52,84,82,113,168,251,81,19,71,176,179,214,228,125,151,126,109,208,87,205,98,212,226,215,161,106,255,187,235,84,119,157,162,222,63,230,174,135,245,119,97,203,197,148,12,7,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "6aeeed315d8c452eb157ed9ad8b83e57",
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

			public ReadCaseCountDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,77,111,219,56,16,253,43,134,206,101,64,73,164,62,124,43,178,238,34,151,54,216,4,189,212,57,140,200,161,35,84,150,4,138,206,110,214,240,127,223,161,100,59,78,19,187,74,209,98,3,52,39,203,163,225,211,124,188,55,156,117,160,42,232,186,143,176,196,96,26,92,163,181,208,53,198,157,125,40,43,135,246,79,219,172,218,224,93,208,161,45,161,42,255,69,61,216,103,186,116,127,128,3,58,178,158,63,32,204,131,233,252,121,140,121,240,110,30,148,14,151,29,249,208,17,145,25,147,96,36,88,42,226,136,9,201,21,3,13,138,165,104,100,196,77,4,25,152,193,243,24,248,69,61,192,247,200,166,127,188,190,111,189,151,32,131,106,150,45,216,178,107,234,173,49,246,223,239,102,53,20,21,106,250,239,236,10,201,228,108,185,164,68,240,186,92,226,37,88,250,140,199,105,188,137,156,12,84,157,247,170,208,184,217,63,173,197,174,43,155,250,116,92,231,77,181,90,214,135,222,4,128,251,191,219,112,120,31,163,247,188,4,119,219,67,156,67,71,111,54,125,156,239,23,11,139,11,112,229,221,97,24,95,241,190,247,28,87,60,58,160,169,69,159,161,90,225,246,171,33,127,146,204,57,180,110,200,105,23,1,185,88,52,104,177,86,120,165,110,113,9,251,44,31,28,202,197,237,1,136,111,234,151,19,53,217,87,246,123,101,137,200,216,238,156,79,215,249,242,193,237,153,76,163,132,140,119,222,48,160,236,30,231,193,151,139,238,211,223,53,218,33,181,161,182,55,103,100,253,198,48,171,112,137,181,155,174,51,35,83,129,178,96,105,66,37,23,105,20,177,156,67,206,98,101,18,169,99,94,0,100,27,58,176,15,104,186,78,65,134,32,178,136,41,149,36,76,132,50,101,144,38,146,241,84,27,192,28,185,73,10,127,100,86,187,210,221,15,140,153,174,1,57,10,169,128,41,145,75,38,12,210,169,56,215,44,134,34,141,210,12,195,36,76,55,55,67,186,101,215,86,112,255,121,159,213,95,8,122,162,168,61,19,95,9,82,158,237,220,196,235,109,210,152,9,213,120,85,185,178,94,76,136,114,21,42,223,240,179,11,221,35,249,31,58,111,162,72,166,89,92,48,224,146,40,21,39,49,43,66,76,88,14,5,134,40,83,13,57,81,106,179,217,220,120,130,166,69,146,21,66,43,150,112,12,89,95,156,12,243,144,1,70,25,167,114,128,130,248,116,247,78,140,6,76,120,172,184,7,207,208,48,193,61,187,165,84,76,199,20,67,154,139,88,134,234,55,27,13,87,14,220,170,27,55,28,198,149,239,229,195,97,23,195,137,241,240,158,152,117,71,132,62,116,125,237,131,162,207,250,96,80,108,245,16,231,66,139,34,19,76,102,164,2,109,194,144,229,105,88,48,206,67,77,164,207,227,76,37,61,222,254,131,23,245,164,181,205,194,135,217,191,120,152,56,163,177,158,168,250,17,230,78,124,73,161,163,60,215,5,147,154,35,19,58,85,44,203,105,86,68,40,37,42,174,12,202,228,77,31,71,245,49,174,124,111,250,248,142,62,178,151,234,227,99,227,38,157,3,235,80,127,171,143,177,88,79,244,241,8,179,215,135,103,64,213,44,74,5,213,167,22,45,108,219,19,62,79,225,71,220,247,27,131,109,26,119,164,105,125,4,59,18,141,187,0,143,69,195,127,114,52,156,54,132,44,22,33,83,81,166,153,16,177,98,57,113,156,105,97,12,209,58,18,180,133,80,52,180,199,251,238,94,53,43,171,112,152,0,221,176,192,255,208,98,254,63,12,142,151,173,209,71,180,53,70,43,111,235,228,235,92,39,127,104,77,124,165,68,61,188,180,126,34,85,31,13,236,177,203,199,139,87,139,223,187,166,163,46,172,95,125,29,253,210,219,101,19,108,254,3,22,67,249,254,26,18,0,0 })));
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

		#region Class: CompleteTasksChangeDataUserTaskFlowElement

		/// <exclude/>
		public class CompleteTasksChangeDataUserTaskFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public CompleteTasksChangeDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,75,111,227,54,16,254,43,134,206,203,128,122,145,162,111,139,212,45,114,233,6,77,176,151,117,14,35,114,232,8,149,37,131,162,211,186,134,255,123,135,146,95,219,56,94,111,176,216,7,182,23,75,26,207,12,231,241,125,156,89,71,186,134,174,251,29,230,24,141,163,123,116,14,186,214,250,171,95,171,218,163,251,205,181,203,69,244,38,234,208,85,80,87,255,160,25,228,19,83,249,95,192,3,153,172,167,7,15,211,104,60,61,237,99,26,189,153,70,149,199,121,71,58,100,34,36,231,41,22,49,19,138,35,203,120,90,48,101,64,51,45,179,34,231,2,178,92,219,65,243,37,231,55,205,224,190,247,108,251,215,251,213,34,104,101,36,208,237,124,1,174,234,218,102,43,76,195,249,221,164,129,178,70,67,223,222,45,145,68,222,85,115,74,4,239,171,57,222,130,163,99,130,159,54,136,72,201,66,221,5,173,26,173,159,252,189,112,216,117,85,219,156,143,235,186,173,151,243,230,88,155,28,224,254,115,27,14,239,99,12,154,183,224,31,123,23,215,208,209,63,155,62,206,183,179,153,195,25,248,234,233,56,140,63,113,213,107,94,86,60,50,48,212,162,247,80,47,113,123,106,204,159,37,115,13,11,63,228,180,139,128,84,28,90,116,216,104,188,211,143,56,135,125,150,7,133,106,246,120,228,36,52,245,195,153,154,236,43,251,169,178,36,36,92,236,148,207,215,249,246,160,118,34,211,68,144,240,41,8,6,47,187,215,105,244,225,166,123,247,87,131,110,72,109,168,237,195,21,73,255,35,152,212,56,199,198,143,215,133,205,101,134,121,201,164,72,50,150,201,36,97,138,131,98,169,182,34,55,41,47,1,138,13,25,236,3,26,175,37,228,49,100,69,194,180,22,130,101,113,46,25,72,145,51,46,141,5,84,200,173,40,131,201,164,241,149,95,13,136,25,175,1,57,82,235,128,233,76,229,44,179,72,86,169,50,44,133,82,38,178,192,88,196,114,243,48,164,91,117,139,26,86,239,247,89,253,129,96,70,154,218,51,10,149,32,230,185,206,143,2,223,70,173,29,81,141,151,181,175,154,217,136,32,87,163,14,13,191,186,49,189,167,240,32,251,50,179,5,87,90,176,196,170,146,101,153,140,153,210,210,178,52,193,212,232,56,6,72,53,129,115,179,121,8,0,53,156,190,173,68,22,155,160,29,222,148,177,146,161,40,140,225,86,153,66,137,159,140,189,111,169,170,79,161,153,116,246,172,117,171,203,152,124,89,33,95,195,228,93,20,103,216,252,60,228,31,129,217,125,230,71,204,222,2,216,230,177,206,68,150,178,188,64,193,140,141,9,192,50,46,25,231,177,17,28,85,90,232,161,146,135,3,219,145,105,123,209,225,114,184,216,203,51,2,110,189,237,24,98,185,40,146,18,75,102,185,162,27,64,37,134,129,202,233,39,17,137,80,169,230,144,228,159,66,98,224,0,190,68,147,248,199,164,201,157,7,191,236,232,126,106,170,238,241,50,142,92,86,202,83,72,73,206,114,100,27,202,240,24,85,221,200,86,13,212,167,72,112,33,92,191,30,5,146,35,208,246,229,34,216,133,82,214,237,172,210,80,191,91,160,131,109,158,252,52,36,62,194,82,152,149,174,109,253,11,247,67,31,195,174,27,156,23,152,202,52,103,52,194,12,203,82,160,221,3,139,156,201,184,72,227,210,38,74,2,80,95,105,103,12,81,223,181,75,167,183,24,238,134,101,241,85,75,224,55,152,16,159,183,178,189,112,109,94,130,129,255,87,151,239,115,117,249,78,49,119,122,209,248,130,248,251,104,192,94,58,18,63,123,236,125,131,97,246,202,249,116,114,24,188,170,176,95,251,218,222,68,155,127,1,170,123,216,143,223,15,0,0 })));
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
						dataList.InitializeLocalizableValues(Storage, "6aeeed315d8c452eb157ed9ad8b83e57",
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

			public CancelTasksChangeDataUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,75,111,227,54,16,254,43,134,206,203,64,148,72,61,124,91,164,110,145,75,55,104,130,189,172,115,24,146,67,71,168,44,25,20,157,214,53,252,223,59,148,252,218,198,241,122,131,197,62,176,61,217,30,15,135,51,223,124,223,12,215,145,174,161,235,126,135,57,70,227,232,30,157,131,174,181,254,234,215,170,246,232,126,115,237,114,17,189,137,58,116,21,212,213,63,104,6,251,196,84,254,23,240,64,71,214,211,67,132,105,52,158,158,142,49,141,222,76,163,202,227,188,35,31,58,98,185,178,70,22,9,75,148,176,76,164,101,201,148,46,83,166,146,188,48,133,214,169,149,124,240,124,41,248,77,51,132,239,35,219,254,235,253,106,17,188,4,25,116,59,95,128,171,186,182,217,26,211,112,127,55,105,64,213,104,232,183,119,75,36,147,119,213,156,10,193,251,106,142,183,224,232,154,16,167,13,38,114,178,80,119,193,171,70,235,39,127,47,28,118,93,213,54,231,243,186,110,235,229,188,57,246,166,0,184,255,185,77,39,238,115,12,158,183,224,31,251,16,215,208,209,63,155,62,207,183,179,153,195,25,248,234,233,56,141,63,113,213,123,94,6,30,29,48,212,162,247,80,47,113,123,43,143,159,21,115,13,11,63,212,180,203,128,92,28,90,116,216,104,188,211,143,56,135,125,149,7,135,106,246,120,20,36,52,245,195,25,76,246,200,126,10,150,132,140,139,157,243,121,156,111,15,110,39,42,77,50,50,62,5,195,16,101,247,117,26,125,184,233,222,253,213,160,27,74,27,176,125,184,34,235,127,12,147,26,231,216,248,241,186,176,50,23,40,21,203,179,68,48,145,39,9,43,99,40,89,170,109,38,77,26,43,128,98,67,7,246,9,141,215,57,72,14,130,26,164,117,150,49,193,101,206,32,207,36,139,115,99,1,75,140,109,166,194,145,73,227,43,191,26,24,51,94,3,198,40,164,6,166,69,41,153,176,72,167,210,210,176,20,84,78,157,69,158,241,124,243,48,148,91,117,139,26,86,239,247,85,253,129,96,70,154,218,51,10,72,144,242,92,231,71,65,111,163,214,142,8,227,101,237,171,102,54,34,202,213,168,67,195,175,110,76,31,41,124,208,121,52,82,1,151,9,179,5,36,84,36,229,14,121,42,89,154,196,5,165,95,36,73,169,136,156,155,205,67,32,168,200,99,144,66,115,86,170,60,16,208,166,12,20,22,44,87,182,40,80,196,60,238,53,246,51,169,247,45,161,250,20,154,73,119,207,90,183,186,76,201,151,1,249,26,37,239,178,56,163,230,231,41,255,8,202,238,43,63,82,246,150,192,52,242,180,200,68,202,100,129,25,51,150,19,166,57,87,44,142,185,201,98,44,211,66,103,125,188,195,133,237,200,180,189,233,48,28,46,142,242,76,128,219,104,123,133,72,33,75,163,37,227,150,35,19,218,20,172,180,156,102,1,230,42,77,139,28,13,143,63,197,196,160,1,124,73,38,252,199,148,201,157,7,191,236,104,62,53,85,247,120,161,70,46,130,242,20,83,146,179,26,217,166,50,124,140,170,110,100,171,6,234,83,34,184,144,174,95,79,2,201,17,105,123,184,136,118,1,202,186,157,85,26,234,119,11,116,176,173,51,62,77,137,143,184,20,118,165,107,91,255,194,124,232,115,216,117,163,224,34,78,18,224,12,0,105,98,113,27,51,149,103,64,43,209,42,174,140,145,60,46,168,175,244,102,12,89,223,181,75,167,183,28,238,134,199,226,171,30,129,223,96,67,124,222,147,237,133,177,121,9,7,254,127,186,124,159,79,151,239,148,115,167,31,26,95,144,127,31,45,216,75,87,226,103,175,189,111,176,204,94,185,159,78,46,131,87,1,251,181,199,246,38,218,252,11,50,55,23,20,223,15,0,0 })));
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
						dataList.InitializeLocalizableValues(Storage, "6aeeed315d8c452eb157ed9ad8b83e57",
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

			public RescheduledCatchSignalFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
				EntityFilters = @"{_isFilter:false,uId:""0a46b150-32d2-40e9-bf57-933b745bfc9a"",name:""FilterEdit"",items:[{_isFilter:true,_filterSchemaUId:""c449d832-a4cc-4b01-b9d5-8a12c42a9f89"",uId:""4ec38736-8c00-4dcc-8c9f-c250f63b860a"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""c8d84f9c-b48b-479b-9ac6-4412f3436ca2"",caption:""Status"",referenceSchemaUId:""805aace4-8604-40e7-a9eb-0f54174593c0"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true},parameterValues:[{displayValue:""&quot;Completed&quot;"",parameterValue:""&quot;4bdbb88f-58e6-df11-971b-001d60e938c6&quot;""}]}},{_isFilter:true,_filterSchemaUId:""c449d832-a4cc-4b01-b9d5-8a12c42a9f89"",uId:""645cd7c9-33b7-4b71-9f8b-a0fce4bac1af"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""ae372cfa-a21f-47f0-8a64-17d137ebe966"",caption:""Result"",referenceSchemaUId:""329bd06e-f95f-4824-a0fb-85edff2f2948"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true},parameterValues:[{displayValue:""&quot;Rescheduled&quot;"",parameterValue:""&quot;d87d32bc-f36b-1410-6598-00155d043204&quot;""}]}}]}";
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

			public AddRescheduledTaskUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,151,75,111,27,71,12,128,255,138,176,206,173,166,48,239,135,110,65,146,2,6,156,52,136,221,92,108,31,56,51,28,71,168,188,107,172,86,46,92,67,255,189,92,217,78,236,160,81,156,182,70,19,212,58,72,216,209,144,195,37,249,145,195,171,230,217,112,121,78,205,172,57,164,190,199,101,87,135,233,139,174,167,233,219,190,203,180,92,78,247,187,140,139,249,31,152,22,244,22,123,60,163,129,250,247,184,88,209,114,127,190,28,118,39,247,197,154,221,230,217,197,230,223,102,118,116,213,236,13,116,246,235,94,97,237,38,32,201,148,29,84,75,8,198,250,0,177,20,3,194,203,26,109,200,65,75,195,194,185,91,172,206,218,215,52,224,91,28,62,52,179,171,102,163,141,21,228,32,77,69,47,129,132,76,96,180,178,128,57,20,8,197,160,138,154,138,212,161,89,239,54,203,252,129,206,112,115,232,29,97,99,98,9,90,1,154,156,193,36,33,33,197,98,33,160,84,217,40,140,53,196,81,248,102,255,39,193,163,157,253,174,251,109,117,62,141,78,146,18,193,1,75,240,241,69,121,72,34,90,48,34,73,114,166,184,156,197,180,90,153,141,51,26,108,32,7,165,74,9,209,179,181,66,200,226,4,69,29,178,219,57,25,15,42,243,229,249,2,47,223,127,241,188,231,121,152,95,204,135,203,73,198,129,78,187,254,114,122,216,77,74,119,45,125,126,47,16,119,229,175,142,175,227,121,220,204,142,191,20,209,155,223,131,141,163,238,199,244,243,112,30,55,187,199,205,65,183,234,243,168,81,243,195,203,59,134,111,14,217,108,249,236,241,54,126,188,210,174,22,139,155,149,151,56,224,237,198,219,229,174,204,235,156,202,94,123,112,27,182,141,22,113,243,129,191,248,186,253,92,219,246,79,196,94,99,139,167,212,191,97,7,124,178,253,163,149,135,236,198,91,197,73,69,59,102,42,120,194,8,134,156,226,188,147,8,81,198,84,181,215,170,86,181,145,126,71,149,122,106,51,221,55,236,33,217,115,35,191,220,120,123,4,231,198,174,209,85,235,102,189,222,189,139,83,117,202,162,202,10,100,17,133,213,88,11,41,48,18,193,41,50,197,90,155,137,182,226,100,74,174,2,181,4,95,139,103,139,18,2,10,97,128,140,212,73,122,171,141,150,255,62,78,99,254,224,105,219,45,105,130,109,153,244,252,182,139,11,154,204,219,60,47,212,14,147,157,227,230,167,163,157,163,189,229,47,191,183,212,95,251,112,86,113,177,164,147,41,175,126,182,240,106,65,103,44,53,187,10,213,122,67,54,129,119,202,128,241,74,65,20,28,40,157,171,179,69,139,132,24,214,44,240,49,217,103,87,30,173,68,19,20,228,236,28,24,105,61,160,119,150,235,81,169,72,145,68,117,105,20,121,213,14,76,225,139,141,31,89,42,133,76,46,25,80,49,115,21,19,153,227,72,200,111,111,83,245,201,103,35,12,174,79,182,35,254,48,31,188,35,44,204,62,111,42,156,144,211,159,231,253,114,152,204,57,254,147,174,142,50,171,197,48,111,79,39,28,224,5,113,169,232,218,233,155,213,89,162,254,169,64,252,39,5,194,102,212,182,74,193,128,51,12,38,59,78,167,232,16,116,208,5,29,86,204,53,111,43,16,15,54,236,161,5,34,134,228,157,113,5,138,173,92,113,168,114,237,241,70,64,240,40,60,229,34,201,135,237,5,130,179,185,100,227,33,88,197,37,175,8,2,116,21,161,42,86,157,148,96,21,250,49,250,237,247,11,63,146,32,195,129,134,108,198,210,93,137,165,116,44,160,49,121,229,3,73,39,253,215,224,255,59,96,239,149,39,168,127,200,174,47,165,47,188,41,66,80,158,19,134,123,42,4,195,119,66,201,89,39,37,183,232,152,203,55,65,77,21,75,64,78,112,79,190,50,147,104,32,33,231,162,16,57,241,61,56,90,12,114,43,212,85,120,205,16,107,240,177,112,153,242,142,11,22,185,8,209,81,182,46,70,109,226,35,116,253,239,25,106,47,156,18,133,179,133,204,56,151,112,124,33,214,146,199,9,69,213,92,216,171,50,61,6,212,27,119,60,113,253,99,114,237,18,105,103,37,132,74,106,204,52,38,188,20,70,41,8,93,140,227,150,95,244,55,113,141,73,112,175,85,26,212,8,183,209,124,123,8,60,56,114,103,9,41,4,27,172,79,106,43,215,169,34,198,204,53,33,107,23,192,24,193,111,164,55,183,17,239,156,168,88,165,121,148,225,248,251,229,218,233,232,170,113,52,54,107,46,149,53,113,180,44,143,74,65,153,224,98,173,194,36,253,24,92,191,232,218,1,243,240,68,246,19,217,35,217,186,86,38,219,101,110,42,110,156,211,75,133,100,66,0,169,180,229,201,95,59,41,182,147,93,147,40,174,114,87,146,158,231,76,131,60,162,163,228,105,31,77,114,70,103,87,196,255,141,236,36,173,22,42,71,30,186,51,31,84,34,123,164,242,75,113,128,68,172,17,75,37,249,24,100,63,207,185,91,181,79,100,255,152,100,43,91,124,150,152,64,22,18,124,187,27,81,24,219,164,80,60,213,89,244,170,56,250,26,217,39,235,63,1,251,63,43,74,46,23,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "6aeeed315d8c452eb157ed9ad8b83e57",
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

			public OpenResheduledTaskEditPageUserTaskFlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
					return _recommendation ?? (_recommendation = GetLocalizableString("6aeeed315d8c452eb157ed9ad8b83e57",
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

			public UserQuestionUserTask1FlowElement(UserConnection userConnection, IncidentDiagnosticsAndResolving process)
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
						dataList.InitializeLocalizableValues(Storage, "6aeeed315d8c452eb157ed9ad8b83e57",
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
					return _question ?? (_question = GetLocalizableString("6aeeed315d8c452eb157ed9ad8b83e57",
						 "BaseElements.UserQuestionUserTask1.Parameters.Question.Value"));
				}
				set {
					_question = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("6aeeed315d8c452eb157ed9ad8b83e57",
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

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"3fa4de2d-80ff-495a-b7c5-927d62fd5baa\",\"624264a7-1527-482e-a850-cf14eeda9305\"]";
			}

			#endregion

		}

		#endregion

		public IncidentDiagnosticsAndResolving(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "IncidentDiagnosticsAndResolving";
			SchemaUId = new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_processUId = () => { return (Guid)(Guid.Parse("6AEEED31-5D8C-452E-B157-ED9AD8B83E57")); };
			_isTaskExists = () => { return (bool)(false); };
			_notStartedActivityStatusId = () => { return (Guid)(new Guid("384d4b84-58e6-df11-971b-001d60e938c6")); };
			_taskCaption = () => { return new LocalizableString((TaskCaptionValue)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6aeeed31-5d8c-452e-b157-ed9ad8b83e57");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: IncidentDiagnosticsAndResolving, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: IncidentDiagnosticsAndResolving, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

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
				return _taskCaptionValue ?? (_taskCaptionValue = GetLocalizableString("6aeeed315d8c452eb157ed9ad8b83e57",
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
			MetaPathParameterValues.Add("38823804-2448-4468-92e6-d9d0f5ec6c2d", () => AddDiagnoseTask.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("bc481380-5343-4b25-8cb1-a6d8dc980555", () => ReadCaseData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("15affdc1-11bb-4c74-b27b-02758669fa13", () => ReadCaseData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("78f519cc-f8d2-4fac-9f87-2dc4c245ab29", () => ResolvedCatchSignal.RecordId);
			MetaPathParameterValues.Add("92796a3d-edaa-47bf-9730-0fb84a1bcb7f", () => ResolvedChangeDataUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("69f7d295-e143-42e8-bb3c-c2f6f0421146", () => ResolvedChangeDataUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("792c5022-ebba-44b5-955b-42c816843971", () => ResolvedChangeDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("59ead31f-77ed-48f6-a880-82e8bb04a642", () => ResolvedChangeDataUserTask.RecordColumnValues);
			MetaPathParameterValues.Add("5ce57c9f-0b11-4679-8661-6fcd0e1a0dde", () => ResolvedChangeDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("9e2aacd6-9c62-4726-94bc-1859bba3cced", () => CanceledCatchSignal.RecordId);
			MetaPathParameterValues.Add("183ecb6a-29e5-46cc-83dd-a8ec060bc191", () => CanceledChangeDataUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("58ab220b-a239-4004-a8b3-362b8616d6b5", () => CanceledChangeDataUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("cb23be2e-d56f-4c76-8277-bea8232dc232", () => CanceledChangeDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("1546ad35-5335-436b-9a67-31666d57fea3", () => CanceledChangeDataUserTask.RecordColumnValues);
			MetaPathParameterValues.Add("5d2b98b3-4786-44c0-bd0c-c98b0b4ab617", () => CanceledChangeDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("159c71ef-be09-4085-8d00-3c67a436bd4b", () => PendingCatchSignal.RecordId);
			MetaPathParameterValues.Add("9ceb65d0-c08f-4758-80c4-0eb931174b9b", () => PendingChangeDataUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("2e50cca2-8933-4280-8cbf-18fdb137ab50", () => PendingChangeDataUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("fa758883-6271-4b3c-bbfa-6cbee86d2b5b", () => PendingChangeDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("95810b4e-5292-4018-a8df-b266bc723708", () => PendingChangeDataUserTask.RecordColumnValues);
			MetaPathParameterValues.Add("fa90eb4a-37cf-4197-a808-a074f52a3864", () => PendingChangeDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("cc1f93c0-6974-4f8b-b1e8-6a819c4b21e9", () => EscalationCatchSignal.RecordId);
			MetaPathParameterValues.Add("da080b93-b78a-437a-adbc-9f4eee898cc5", () => EscalationChangeDataUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("a94e00f8-50cc-4b2b-9d7e-3c846c8fe91d", () => EscalationChangeDataUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("b03d7915-a2be-4918-8d0b-ca7e158f79e6", () => EscalationChangeDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("ecc66875-1982-4fd7-99ab-6d047904b215", () => EscalationChangeDataUserTask.RecordColumnValues);
			MetaPathParameterValues.Add("fd957cac-7757-4375-864c-a41078a5c3fc", () => EscalationChangeDataUserTask.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("d54609de-42c1-4043-91d7-382901823d54", () => ReadCaseCountDataUserTask.ResultCompositeObjectList);
			MetaPathParameterValues.Add("67c472af-8203-4b58-af97-3714096bbc13", () => ReadCaseCountDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("99f2dd86-4eab-47c5-8ba2-01d496b9a3fb", () => CompleteTasksChangeDataUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("6a09dbe4-c830-4973-9ba2-bee31e9f77f2", () => CompleteTasksChangeDataUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("c8a7ec42-256a-40db-af79-d1e36121c71c", () => CompleteTasksChangeDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("cbba51f0-1bbc-4cab-9bfd-7c94e372df30", () => CompleteTasksChangeDataUserTask.RecordColumnValues);
			MetaPathParameterValues.Add("b2216f87-53e9-4b0f-819a-17ea487cb6b4", () => CompleteTasksChangeDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("e21b52d3-db26-4e4e-8254-fcc14a5f7386", () => CancelTasksChangeDataUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("59deaa49-2d60-48b6-81d5-cecd7aaaf43b", () => CancelTasksChangeDataUserTask.IsMatchConditions);
			MetaPathParameterValues.Add("c590c5de-cb61-45ff-a24d-d8ee718c86e7", () => CancelTasksChangeDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("6c0bc164-4425-4e9d-abaf-b243259091c3", () => CancelTasksChangeDataUserTask.RecordColumnValues);
			MetaPathParameterValues.Add("38a88de8-a208-4906-8a96-66fe61989e1e", () => CancelTasksChangeDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("a46b9b07-561d-402a-bfce-8c12452a18d2", () => RescheduledCatchSignal.RecordId);
			MetaPathParameterValues.Add("92b7b385-b361-4426-aa17-35a191aa76c8", () => AddRescheduledTaskUserTask.EntitySchemaId);
			MetaPathParameterValues.Add("b7e1b44d-217e-4e2f-a90c-17a5ebf74c94", () => AddRescheduledTaskUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("d5038619-45b6-440d-9cef-0b9bb2381b70", () => AddRescheduledTaskUserTask.RecordAddMode);
			MetaPathParameterValues.Add("c587e107-d285-4719-941f-a1aa76cdf30e", () => AddRescheduledTaskUserTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("2a49baff-f87a-4844-8d6e-503b3b93151b", () => AddRescheduledTaskUserTask.RecordDefValues);
			MetaPathParameterValues.Add("538e3867-2d16-4738-823f-530a3f2cd5a7", () => AddRescheduledTaskUserTask.RecordId);
			MetaPathParameterValues.Add("591d77d1-1344-4390-9cda-8dcaa9a64548", () => AddRescheduledTaskUserTask.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("01c906ed-6cc4-4b37-9f7a-09fe54fa385c", () => OpenResheduledTaskEditPageUserTask.ActivityPriority);
			MetaPathParameterValues.Add("42010ab4-b5ab-4bb9-955a-7b0944552f9e", () => OpenResheduledTaskEditPageUserTask.CreateActivity);
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
			MetaPathParameterValues.Add("e43bf708-7a7f-4bd8-aec1-9691f9d06fe7", () => UserQuestionUserTask1.CreateActivity);
			MetaPathParameterValues.Add("e78f7bd8-73bf-4489-b563-8bf2ab3ddf66", () => UserQuestionUserTask1.ActivityPriority);
			MetaPathParameterValues.Add("3210c491-5bf8-4c44-809f-2ccea5bab678", () => UserQuestionUserTask1.ConfItem);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "UserQuestionUserTask1.ConfItem":
					UserQuestionUserTask1.ConfItem = reader.GetValue<System.Guid>();
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
			var cloneItem = (IncidentDiagnosticsAndResolving)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


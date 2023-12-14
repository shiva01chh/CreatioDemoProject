namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SearchForParentSchema

	/// <exclude/>
	public class SearchForParentSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SearchForParentSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SearchForParentSchema(SearchForParentSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SearchForParent";
			UId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a");
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
			Tag = @"Business process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a");
			Version = 0;
			PackageUId = new Guid("76d633dd-63f4-4955-b36c-e6042cb74dfd");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateIncidentIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d270a8e7-f283-4e0c-9abb-71cd7fc777c6"),
				ContainerUId = Guid.Empty,
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
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCaseCollectionAnyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f83d82b0-58af-4e46-968e-7c6ef3d7b958"),
				ContainerUId = Guid.Empty,
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
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"false",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIncidentIdParameter());
			Parameters.Add(CreateIsCaseCollectionAnyParameter());
		}

		protected virtual void InitializeSearchForParentPreconfiguredPageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("425b83a9-1efb-4042-8357-a8bb999509f4"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Title",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			titleParameter.SourceValue = new ProcessSchemaParameterValue(titleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Open similar cases search page",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("22d91d0f-7c9a-4ab4-be73-b242a2d32322"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var clientUnitSchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1396cfec-96e9-4358-ba2a-db56f25466d7"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"ClientUnitSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			clientUnitSchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(clientUnitSchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"a463ec0c-c9f2-4b07-9247-27dcb61a6a91",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(clientUnitSchemaUIdParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("91d5ab47-a61f-4071-804e-e9f0565f3ccc"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3f5d1bed-0e68-4f37-b37a-fa58e5f88671"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("f80ca0e3-df11-4e51-8ed1-7b98c0dffeee"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var useCardProcessModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a30c0fcd-9d71-4b13-82ee-e7dba8cf37b0"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"UseCardProcessModule",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			useCardProcessModuleParameter.SourceValue = new ProcessSchemaParameterValue(useCardProcessModuleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(useCardProcessModuleParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("dea4a681-ca88-4b34-bd1d-b2d572da8b1b"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				UId = new Guid("659d70cd-0a71-48d8-9eff-11a205ff4b3d"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b662c6d3-20ec-4889-a118-c2838daa4b62"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
			var isRunningParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c2cbff2b-348c-417e-8ba3-b85b5b4ef5b8"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
			var templateParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				UId = new Guid("248b8f00-e298-4070-8e9b-ddf585c1cc2f"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Template",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			templateParameter.SourceValue = new ProcessSchemaParameterValue(templateParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#Lookup.90fa6d02-3e93-45d6-a72b-58dcffa411ae.21620f25-166f-42f1-8b4d-224a959040a3#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(templateParameter);
			var moduleParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				UId = new Guid("26a88202-ce7b-439d-a4e3-5e9b025e16b4"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Module",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			moduleParameter.SourceValue = new ProcessSchemaParameterValue(moduleParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#Lookup.90fa6d02-3e93-45d6-a72b-58dcffa411ae.eb89c336-08b9-4951-bffd-3f5abc433174#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(moduleParameter);
			var pressedButtonCodeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1f047336-25d7-4503-86ee-bd5308da2da5"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
			var urlParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c8d8e280-5095-4a16-b650-fec6bdb41f64"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Url",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			urlParameter.SourceValue = new ProcessSchemaParameterValue(urlParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"""[Module]/[Page]/add""",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(urlParameter);
			var currentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("670b0150-bc25-4597-acbb-1404bbbbc8f2"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				UId = new Guid("016d7767-c561-4adb-a9b7-c358cc40595d"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(createActivityParameter);
			var activityPriorityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b934f48c-5dea-49b9-bde3-697cb4be5d8b"),
				UId = new Guid("4e0c550a-ca20-4baf-8399-b692ae27c15a"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(activityPriorityParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("63a64efa-4a7e-4f0c-9e9a-1bcc05010f43"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a8a3647a-96ff-48e0-a47b-7f3dbeba7408"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e2144b9b-f825-418e-858a-c8518699e79e"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("93c4b302-dcaf-4502-965d-1555706464b4"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("738c84c3-f74e-432f-9119-51ad130f13cf"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("394540bd-dfb1-46bc-8ed3-085376b976b8"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a0f7f61a-c030-4340-8c34-b63b025a844a"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var activityResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a2cb32e2-a0b0-414e-b429-15b555836062"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				UId = new Guid("d21da11f-4af8-4f55-b6b5-f3b947f1691f"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
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
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var serviceItemParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				UId = new Guid("0a201783-e5a9-49bb-aa18-483539cd7e45"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
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
				Name = @"ServiceItem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			serviceItemParameter.SourceValue = new ProcessSchemaParameterValue(serviceItemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(serviceItemParameter);
			var totalPagesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6220e5ea-1f4c-4e9b-b033-f97c376b240c"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
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
				Name = @"TotalPages",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			totalPagesParameter.SourceValue = new ProcessSchemaParameterValue(totalPagesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(totalPagesParameter);
			var currentPageNumberParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e9db3967-c4c4-4bc4-8167-944c1682b12c"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
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
				Name = @"CurrentPageNumber",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			currentPageNumberParameter.SourceValue = new ProcessSchemaParameterValue(currentPageNumberParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(currentPageNumberParameter);
			var resultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6eda63e0-df98-4e32-8946-8d99267b8943"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
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
				Name = @"Result",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			resultParameter.SourceValue = new ProcessSchemaParameterValue(resultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(resultParameter);
			var pageTitleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("929b077b-0f50-49ff-a5b4-a1f72fb2e16c"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
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
				Name = @"PageTitle",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			pageTitleParameter.SourceValue = new ProcessSchemaParameterValue(pageTitleParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(pageTitleParameter);
			var hidePageNumbersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("11939531-2013-4afa-b680-6c5672ac4563"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
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
				Name = @"HidePageNumbers",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			hidePageNumbersParameter.SourceValue = new ProcessSchemaParameterValue(hidePageNumbersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(hidePageNumbersParameter);
			var caseIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("0662da67-49e4-4828-8aac-06b388cca81f"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
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
				Name = @"CaseId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			caseIdParameter.SourceValue = new ProcessSchemaParameterValue(caseIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d270a8e7-f283-4e0c-9abb-71cd7fc777c6}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(caseIdParameter);
			var caseCollectionParamParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("21cdc12a-97d7-4875-9cbc-8e89b57b8f11"),
				ContainerUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
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
				Name = @"CaseCollectionParam",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			caseCollectionParamParameter.SourceValue = new ProcessSchemaParameterValue(caseCollectionParamParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(caseCollectionParamParameter);
		}

		protected virtual void InitializeChangeDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("ace78947-8c57-47c0-ae85-c57a5821bb13"),
				ContainerUId = new Guid("e02dce31-a6f7-4c9a-af3b-2e17cfbedd87"),
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
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d8ec807d-7f8d-4037-b2ab-9c88007c0121"),
				ContainerUId = new Guid("e02dce31-a6f7-4c9a-af3b-2e17cfbedd87"),
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d9594b77-041b-46f3-9024-1bd044d68726"),
				ContainerUId = new Guid("e02dce31-a6f7-4c9a-af3b-2e17cfbedd87"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,20,252,43,69,135,158,172,98,125,216,178,220,227,178,45,123,73,3,77,75,33,89,194,179,244,148,21,248,99,99,201,52,193,236,127,175,188,206,166,144,67,41,244,84,208,65,122,210,204,155,25,158,230,123,31,62,249,54,226,88,59,104,3,102,211,206,214,196,240,70,84,141,104,104,101,181,165,210,34,163,13,7,78,185,102,214,184,156,25,203,144,100,61,116,88,147,21,189,181,62,146,204,71,236,66,125,59,255,38,141,227,132,217,189,59,31,190,154,3,118,240,109,105,192,152,178,130,59,77,43,174,10,42,11,33,105,37,25,163,204,148,37,99,133,65,109,44,89,181,48,176,37,230,90,82,166,165,163,82,26,65,193,65,67,185,101,78,53,149,98,133,54,36,107,209,197,237,211,113,196,16,252,208,215,51,190,238,111,158,143,73,229,218,123,51,180,83,215,147,172,195,8,215,16,15,53,1,204,81,22,6,168,145,58,9,113,168,40,136,228,89,64,163,184,170,144,149,76,145,204,192,49,46,180,100,151,84,89,136,240,29,218,9,207,204,179,79,26,185,200,89,85,148,9,203,132,161,82,240,156,86,101,165,168,179,165,211,40,74,173,27,123,201,235,243,228,211,222,135,171,169,195,209,155,151,216,49,229,55,140,245,108,134,62,142,67,187,80,95,157,159,223,224,83,92,195,125,185,250,177,26,138,169,190,128,200,41,155,2,110,90,143,125,220,246,102,176,190,127,88,57,79,167,4,233,142,48,250,112,73,97,251,56,65,75,178,209,63,28,254,152,214,102,10,113,232,254,35,171,89,178,153,56,210,144,157,229,46,51,104,125,56,182,240,124,62,215,228,253,227,52,196,143,215,227,96,146,79,180,239,124,111,188,77,60,107,157,188,193,215,228,142,88,174,114,168,210,60,56,94,9,42,49,55,84,67,211,80,149,166,95,57,163,148,50,229,29,73,154,254,185,211,237,46,124,249,217,95,254,199,234,104,255,33,85,223,20,174,47,200,122,254,27,113,167,253,34,111,127,74,235,23,102,52,166,128,230,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55f85150-f401-4e97-9d12-0f211ee35972"),
				ContainerUId = new Guid("e02dce31-a6f7-4c9a-af3b-2e17cfbedd87"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,203,110,219,48,16,252,21,131,201,209,52,76,145,18,69,93,235,20,48,144,52,65,94,23,59,135,21,185,76,4,232,97,144,114,219,212,240,191,151,166,229,218,78,91,160,40,15,18,184,203,153,89,238,14,55,228,178,127,95,33,41,200,35,58,7,190,179,253,228,83,231,112,114,231,58,141,222,79,174,59,13,117,245,3,202,26,239,192,65,131,61,186,103,168,215,232,175,43,223,143,71,231,48,50,38,151,95,99,150,20,139,13,153,247,216,60,205,77,96,215,22,193,164,34,167,82,96,70,69,174,12,45,129,35,85,41,23,58,203,166,137,40,203,0,214,93,189,110,218,27,236,225,14,250,55,82,108,72,100,11,4,144,230,178,20,74,80,33,45,167,162,76,36,45,81,36,20,146,84,97,42,149,157,102,140,108,199,196,235,55,108,32,138,30,193,140,73,195,19,171,104,158,200,148,138,160,73,115,193,24,101,65,154,177,84,163,210,102,7,30,206,31,129,139,139,197,220,223,126,107,209,61,68,222,194,66,237,241,101,18,162,31,2,87,53,54,216,246,197,134,11,41,69,42,45,69,157,49,42,208,34,205,89,106,40,231,210,160,154,26,158,26,190,13,128,95,221,44,54,25,26,200,56,78,169,177,42,15,16,158,208,92,137,140,230,70,169,36,147,101,216,4,200,197,203,174,68,83,249,85,13,239,207,191,87,122,187,194,118,228,171,166,170,193,141,52,120,244,35,143,224,244,219,104,5,175,56,185,71,191,174,251,61,201,234,108,146,167,52,155,229,222,16,75,82,44,255,102,137,225,191,111,192,185,41,62,250,97,73,198,75,242,208,173,157,222,49,242,221,230,48,159,168,48,29,22,253,195,231,176,246,28,17,118,3,109,184,138,251,18,20,35,60,166,102,208,67,20,127,12,117,31,136,203,68,165,83,201,44,149,8,42,180,52,11,45,53,12,168,98,170,180,92,6,51,216,36,162,239,195,128,28,182,26,207,11,251,23,199,68,124,84,62,22,115,176,110,136,180,235,186,142,2,62,222,127,247,22,134,194,135,204,236,100,148,39,12,157,169,108,133,102,222,254,103,171,102,104,35,229,231,206,93,125,15,111,180,106,95,135,137,157,72,31,207,204,116,51,196,183,100,187,125,217,254,4,243,40,241,12,18,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ef745821-7b98-4cde-a848-f26a508d70e6"),
				ContainerUId = new Guid("e02dce31-a6f7-4c9a-af3b-2e17cfbedd87"),
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

		protected virtual void InitializeReadConfItemDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cd861df3-40fb-4186-b65e-25dba80f9e24"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,203,138,220,48,16,252,149,160,67,78,86,144,52,178,100,59,199,97,2,11,97,51,144,7,129,101,88,244,104,237,136,248,181,150,76,178,152,249,247,200,246,56,89,246,16,114,200,37,224,131,212,82,85,87,85,203,211,189,15,239,124,29,97,168,156,170,3,100,227,141,173,80,225,20,104,106,53,230,69,238,48,231,138,96,77,96,135,89,46,44,24,238,8,200,18,101,173,106,160,66,43,250,96,125,68,153,143,208,132,234,110,250,77,26,135,17,178,123,183,108,62,154,51,52,234,243,220,32,55,146,185,146,1,38,86,48,204,153,32,88,17,237,176,53,4,64,59,158,11,89,160,85,139,208,84,104,109,52,46,132,20,233,170,204,177,6,82,98,71,53,115,194,16,83,104,142,178,26,92,60,252,232,7,8,193,119,109,53,193,175,245,167,167,62,169,92,123,239,187,122,108,90,148,53,16,213,81,197,115,133,156,212,78,49,107,176,3,85,98,46,148,74,78,103,207,154,229,5,225,34,249,87,40,51,170,143,51,45,218,171,0,40,27,192,193,0,173,129,103,142,40,149,118,151,60,225,98,86,200,243,29,199,5,167,20,83,35,4,165,185,129,210,88,148,89,21,213,23,85,143,176,168,154,124,2,106,86,230,68,82,135,229,162,0,82,30,133,165,10,151,180,212,110,39,19,167,99,91,214,239,187,238,219,216,167,156,195,237,216,192,224,205,117,104,144,210,239,134,106,50,93,27,135,174,158,201,111,159,1,214,225,92,15,191,174,129,212,203,201,12,68,151,108,12,176,175,61,180,241,208,154,206,250,246,97,153,219,229,146,48,77,175,6,31,182,24,15,143,163,170,83,0,254,225,252,199,184,247,99,136,93,243,191,249,205,146,215,68,147,158,234,162,121,126,201,214,135,190,86,79,203,190,66,175,31,199,46,190,61,14,157,73,102,193,190,242,173,241,54,209,172,117,244,2,191,221,183,76,18,85,128,196,142,21,187,228,152,24,92,42,173,177,164,198,74,103,164,148,70,92,25,46,217,63,233,120,119,19,62,124,111,183,63,110,13,237,244,38,85,95,20,142,27,186,154,254,70,228,229,180,201,60,93,210,247,19,153,206,39,17,60,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("84cb8b09-ef03-435e-8588-4e64e6ef5a4f"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97a0ecd6-d533-479c-a450-c4a2577641d4"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("05538184-0f57-423a-b191-c5dbdac068f8"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c73f9f80-fd7b-4cf1-acb9-d60091d0f344"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a13349cc-1228-4922-a0ff-008c512c950b"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("93e4cd31-714c-41ca-ae3a-d8696adcf3dd"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,177,50,176,50,208,113,78,44,78,181,50,180,50,4,0,241,126,40,137,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5c72f92e-0d62-4260-a0bf-dc0eebf45678"),
				UId = new Guid("5f8f8252-4b03-4c7c-bd80-b7808545ec0c"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c76d235a-b599-4654-ba0e-21d29510a3b3"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7fde92e2-24aa-451d-bd80-ee4640257ed9"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0294f17d-4f4c-41a8-84bd-41091d1e9884"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d1c4b637-39da-474d-980c-8c8ad96125c5"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("44873c50-da69-45fb-b889-4e99c0c63fba"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4066fd99-ee9a-4434-9b7d-3d6cfe69c3ed"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("5c72f92e-0d62-4260-a0bf-dc0eebf45678"),
				UId = new Guid("2b138545-6ab5-4b6c-bd27-a904e645cb89"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cf362cd5-a00c-4a73-a580-9a64f6cb55ac"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("46bc0544-e508-430d-b9ad-6eb5ebd0d48b"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("44458d37-76c5-4b36-b11f-a55b386019de"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8b54bfea-6880-477e-89eb-4dd5a3049f87"),
				ContainerUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeReadCaseDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("acf43b55-9bc9-4f23-ab2f-4be0d0fda31f"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,147,79,107,220,48,16,197,191,74,209,161,39,171,88,150,44,201,206,113,217,150,189,164,11,77,75,33,89,130,44,141,178,2,255,139,37,211,4,227,239,94,217,206,166,144,67,41,244,20,240,65,26,251,189,249,205,99,60,221,59,255,217,213,1,134,210,170,218,67,50,30,76,137,8,79,169,22,164,192,0,82,97,38,41,195,146,230,2,83,13,148,89,75,40,145,41,74,90,213,64,137,54,245,222,184,128,18,23,160,241,229,237,244,199,52,12,35,36,247,118,189,124,211,103,104,212,247,181,1,17,134,102,182,192,50,19,57,102,249,210,128,17,130,137,230,156,144,92,67,161,13,218,88,140,172,42,147,90,129,171,84,114,204,88,158,97,37,185,196,182,0,89,16,157,139,148,231,40,169,193,134,253,83,63,128,247,174,107,203,9,94,207,55,207,125,164,220,122,239,186,122,108,90,148,52,16,212,81,133,115,137,20,164,192,114,173,176,102,69,4,177,32,176,162,133,193,84,85,34,19,18,8,39,2,37,90,245,97,177,69,135,72,101,84,80,63,84,61,194,234,60,185,200,152,209,148,200,156,71,45,161,26,51,154,165,56,34,10,108,13,143,152,148,23,69,101,46,121,125,25,93,60,59,127,61,54,48,56,253,18,59,196,252,186,161,156,116,215,134,161,171,23,235,235,245,243,27,120,10,91,184,47,175,126,110,3,133,88,95,68,104,78,70,15,187,218,65,27,246,173,238,140,107,31,54,207,121,142,146,166,87,131,243,151,20,246,143,163,170,81,50,184,135,243,95,211,218,141,62,116,205,59,26,53,137,99,70,143,184,100,43,238,178,131,198,249,190,86,207,235,189,68,31,31,199,46,92,29,135,78,199,57,193,124,112,173,118,38,250,108,117,244,70,95,162,59,100,50,145,42,25,247,193,102,146,98,6,169,198,133,170,42,44,136,54,194,106,33,132,230,119,40,50,253,119,167,219,131,255,250,171,189,252,31,219,68,167,79,177,250,166,112,188,40,203,233,95,224,230,211,130,119,154,227,243,27,30,212,77,220,230,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("870b6336-1d39-430f-af59-ef5b32142e14"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("14b1a615-9e84-4bf2-95fa-7edb14a5255f"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dd90fd1c-0563-48f6-ab88-502b7089d065"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fbbe03b2-1467-4b16-bce2-946a0ea9dde1"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2a0c0741-97b6-4dfb-9773-ab3e71bf05e7"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e50d1955-15fb-4f03-add8-674d9bdd2878"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,43,205,77,74,45,178,50,178,50,212,9,78,45,42,203,76,78,245,44,73,205,181,50,176,50,208,241,76,1,81,0,37,166,231,142,33,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("72430e28-8bf4-41c4-8aa3-392123b79311"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("64981203-3d0d-4db5-b21e-8d95f119545f"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0594e91b-20aa-47ba-b7b9-c3c046612aff"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e97c2cc7-5ef7-4027-b501-41a79b2a21b2"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("6fb0bacd-1017-4b1c-8458-a9b76a08c1d0"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("380ab258-c3ad-496b-ad59-c7ba3f40c610"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("6ce7255d-b559-43d6-bed7-f3e91167dbf8"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("19c3b6f8-27ba-43df-be8e-76a89b378ea5"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1087a0aa-984b-42e6-b132-8d5478f65528"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4faa6e56-1123-4ec1-909d-aaad325be138"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("33c04b7b-b6d0-46ee-b742-e553c9c84b94"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fcd2bf96-d170-4e41-8f08-42191946c92e"),
				ContainerUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializePrepareTagCollectionParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6418d70e-c8df-4215-a8a3-cb363d472ec0"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,43,69,135,158,172,98,201,178,101,185,199,101,11,129,146,4,250,65,33,44,97,60,26,101,213,250,43,182,76,27,204,254,247,106,215,187,109,200,161,244,208,75,193,7,105,164,247,230,189,55,242,114,239,167,119,190,9,52,86,14,154,137,146,249,202,86,172,48,169,74,157,1,158,167,96,185,146,2,57,128,149,60,43,50,5,90,164,89,86,58,150,116,208,82,197,86,244,214,250,192,18,31,168,157,170,187,229,55,105,24,103,74,238,221,105,243,1,247,212,194,167,99,3,139,70,213,86,58,158,231,105,206,85,89,35,47,177,208,92,89,89,107,2,109,106,202,217,170,69,230,166,52,89,234,56,24,225,184,50,46,94,5,68,46,44,90,161,82,68,43,21,75,26,114,97,251,99,24,105,154,124,223,85,11,253,90,127,124,26,162,202,181,247,166,111,230,182,99,73,75,1,110,33,236,43,6,25,213,37,101,5,47,108,30,133,216,210,114,131,66,113,145,202,26,181,113,164,74,96,9,194,16,142,180,236,166,254,74,24,141,142,228,104,164,14,233,153,39,33,180,205,164,51,188,148,58,82,229,153,226,165,18,130,11,44,10,33,114,36,131,150,37,22,2,124,134,102,166,147,174,197,71,96,45,77,158,234,104,46,58,55,92,81,33,121,105,5,112,35,76,237,50,29,57,157,188,164,253,190,239,191,205,67,76,122,186,158,91,26,61,158,199,70,49,255,126,172,22,236,187,48,246,205,145,252,250,25,96,29,207,249,240,203,26,73,115,58,57,2,217,33,153,39,218,52,158,186,176,237,176,183,190,123,56,77,238,112,136,152,118,128,209,79,151,32,183,143,51,52,49,0,255,176,255,99,224,155,121,10,125,251,191,249,77,162,215,72,19,31,235,73,243,241,45,91,63,13,13,60,157,246,21,123,253,56,247,225,237,237,216,99,52,75,246,149,239,208,219,72,179,214,217,11,252,229,190,149,58,133,146,52,119,178,204,162,227,20,185,129,186,230,90,160,213,14,181,214,88,156,25,14,201,63,233,120,119,53,221,124,239,46,255,220,26,218,238,77,172,190,40,220,94,208,213,242,55,34,15,187,139,204,221,33,126,63,1,218,179,228,98,62,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ad80f9ab-24d3-4614-ac24-e78e1e7f8cc9"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fd932721-9572-4d4d-9ae0-a53f2f7a9404"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8fe4967a-019f-4732-8095-d40150ef5806"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5fb9d631-8efe-459a-9bd5-6fed2139169c"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e4e5c77d-f138-4aa2-94e0-b84a088abacc"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("259d4266-8c7e-4c27-b0f0-98cdf9128a23"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,177,50,176,50,208,9,73,76,183,50,180,50,4,0,218,2,59,40,14,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("dc94bd2f-5505-48bc-8c67-4d2b7ea79be5"),
				UId = new Guid("21277763-11c1-45b5-85ba-7d1933f003a9"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fe355ae7-ae4c-401b-9d39-9d56030ea11c"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("db47687b-5a80-4a97-8e54-fd79fc9357df"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8db483e0-0d10-4173-987c-761a50993f1c"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("66a32598-4247-4928-9458-69deda5a2d2d"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("03fa10e4-0653-4807-96a6-5f7afd87fa99"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e7e86faa-f353-40d1-bda1-b828e648e3e6"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("dc94bd2f-5505-48bc-8c67-4d2b7ea79be5"),
				UId = new Guid("7964a7ec-d994-44ef-b450-d3fd3382705c"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2ed44ec2-017e-412a-9306-9b3ae4a16754"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9dd501c5-5d42-4870-8c69-3f4c0982c50a"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("53f0274e-6a67-4b8d-a1a5-55e83be56bdd"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("bb53212b-35ce-4fbb-9e9f-0903d673264e"),
				ContainerUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
			ProcessSchemaLaneSet schemaSearchForParents = CreateSearchForParentsLaneSet();
			LaneSets.Add(schemaSearchForParents);
			ProcessSchemaLane schemaFirstSupportLine = CreateFirstSupportLineLane();
			schemaSearchForParents.Lanes.Add(schemaFirstSupportLine);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaUserTask searchforparentpreconfiguredpageusertask = CreateSearchForParentPreconfiguredPageUserTaskUserTask();
			FlowElements.Add(searchforparentpreconfiguredpageusertask);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaUserTask readconfitemdatausertask = CreateReadConfItemDataUserTaskUserTask();
			FlowElements.Add(readconfitemdatausertask);
			ProcessSchemaScriptTask preparecasecollection = CreatePrepareCaseCollectionScriptTask();
			FlowElements.Add(preparecasecollection);
			ProcessSchemaUserTask readcasedatausertask = CreateReadCaseDataUserTaskUserTask();
			FlowElements.Add(readcasedatausertask);
			ProcessSchemaUserTask preparetagcollection = CreatePrepareTagCollectionUserTask();
			FlowElements.Add(preparetagcollection);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateParentCaseSelectedConditionalFlowConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("28f0db2a-3335-4fbc-9e26-3ad70bdfe215"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e02dce31-a6f7-4c9a-af3b-2e17cfbedd87"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c54dcc84-10c3-4c6b-83d2-71375cca6121"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateParentCaseSelectedConditionalFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ParentCaseSelectedConditionalFlow",
				UId = new Guid("d0644cf4-411e-46d8-b79c-a9b7c342f134"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3477457f-ec61-4efe-815d-337de90d35d3}].[Parameter:{6eda63e0-df98-4e32-8946-8d99267b8943}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				CurveCenterPosition = new Point(375, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e02dce31-a6f7-4c9a-af3b-2e17cfbedd87"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow2",
				UId = new Guid("2da0d46f-94f2-4e7d-9630-22192cacad9a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				CurveCenterPosition = new Point(460, 184),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c54dcc84-10c3-4c6b-83d2-71375cca6121"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(742, 150));
			schemaFlow.PolylinePointPositions.Add(new Point(1050, 150));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("e115c96f-04f8-495e-8c9e-afeadb22cff2"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				CurveCenterPosition = new Point(160, 202),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bfc04a7f-3451-4aab-b2ce-0f992a937a13"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("1db82c5d-247c-4bb2-8955-62cc05eff9e6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				CurveCenterPosition = new Point(365, 206),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("192b4fb7-f0a5-4895-9b2b-c085503eec6f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				CurveCenterPosition = new Point(160, 202),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("4350a31d-c5db-45f9-8efd-4f58d1b70544"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{f83d82b0-58af-4e46-968e-7c6ef3d7b958}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				CurveCenterPosition = new Point(526, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f223b416-07f8-4d28-be9a-ff5273b6274f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow5",
				UId = new Guid("fa967f5b-9630-4dd4-a1dc-530f33b346fb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				CurveCenterPosition = new Point(680, 224),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f223b416-07f8-4d28-be9a-ff5273b6274f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c54dcc84-10c3-4c6b-83d2-71375cca6121"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(560, 235));
			schemaFlow.PolylinePointPositions.Add(new Point(1050, 235));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("e12eb3c5-3171-47b2-a064-87d99fb6a700"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f223b416-07f8-4d28-be9a-ff5273b6274f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(494, 197));
			schemaFlow.PolylinePointPositions.Add(new Point(494, 192));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateSearchForParentsLaneSet() {
			ProcessSchemaLaneSet schemaSearchForParents = new ProcessSchemaLaneSet(this) {
				UId = new Guid("5af10768-7fa4-4032-818c-4af36a769b60"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4f61f5dc-c214-42b2-93aa-02d5c35156ab"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Name = @"SearchForParents",
				Position = new Point(5, 5),
				Size = new Size(1093, 400),
				UseBackgroundMode = false
			};
			return schemaSearchForParents;
		}

		protected virtual ProcessSchemaLane CreateFirstSupportLineLane() {
			ProcessSchemaLane schemaFirstSupportLine = new ProcessSchemaLane(this) {
				UId = new Guid("ae5885dd-d8e1-4822-b304-e90c2bf74a5e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("5af10768-7fa4-4032-818c-4af36a769b60"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("4f61f5dc-c214-42b2-93aa-02d5c35156ab"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Name = @"FirstSupportLine",
				Position = new Point(29, 0),
				Size = new Size(1064, 400),
				UseBackgroundMode = false
			};
			return schemaFirstSupportLine;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("bfc04a7f-3451-4aab-b2ce-0f992a937a13"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ae5885dd-d8e1-4822-b304-e90c2bf74a5e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4f61f5dc-c214-42b2-93aa-02d5c35156ab"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
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
				UId = new Guid("c54dcc84-10c3-4c6b-83d2-71375cca6121"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ae5885dd-d8e1-4822-b304-e90c2bf74a5e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4f61f5dc-c214-42b2-93aa-02d5c35156ab"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Name = @"Terminate1",
				Position = new Point(1037, 179),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateSearchForParentPreconfiguredPageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ae5885dd-d8e1-4822-b304-e90c2bf74a5e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Name = @"SearchForParentPreconfiguredPageUserTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(708, 165),
				SchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeSearchForParentPreconfiguredPageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e02dce31-a6f7-4c9a-af3b-2e17cfbedd87"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ae5885dd-d8e1-4822-b304-e90c2bf74a5e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Name = @"ChangeDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(911, 165),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadConfItemDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ae5885dd-d8e1-4822-b304-e90c2bf74a5e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Name = @"ReadConfItemDataUserTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(253, 170),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadConfItemDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareCaseCollectionScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f223b416-07f8-4d28-be9a-ff5273b6274f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ae5885dd-d8e1-4822-b304-e90c2bf74a5e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Name = @"PrepareCaseCollection",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(526, 165),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,85,193,142,218,48,16,61,23,137,127,176,56,37,210,202,106,175,187,155,72,40,192,42,213,182,80,160,237,161,218,131,155,12,193,109,98,179,182,67,133,218,254,123,199,113,18,32,133,110,181,66,123,65,200,241,188,247,230,189,201,100,203,20,1,253,24,49,13,36,32,2,126,144,177,48,220,236,22,201,26,10,246,161,4,181,243,62,106,80,145,20,2,18,195,165,160,135,23,222,49,193,50,80,87,100,96,17,6,254,77,191,87,163,209,97,154,70,50,47,11,225,13,226,244,220,147,57,100,92,27,80,144,78,197,192,167,83,149,130,26,113,229,152,80,208,241,1,29,129,78,64,164,92,100,7,112,19,158,35,130,182,176,94,115,22,41,96,6,220,147,207,220,172,103,76,177,2,236,53,207,29,70,178,216,48,197,181,20,203,221,6,232,123,105,198,143,37,203,177,17,20,123,69,98,145,240,20,132,137,83,223,191,48,85,195,179,48,204,148,154,198,122,194,5,203,145,115,197,114,13,39,233,238,101,198,19,150,79,55,160,88,109,76,247,104,97,20,79,12,29,138,20,235,183,46,212,203,5,122,58,204,103,232,155,170,78,105,237,228,243,93,4,181,229,9,196,6,10,180,112,14,44,181,186,71,204,48,219,228,146,233,239,116,14,186,204,141,107,146,222,129,113,141,124,98,121,9,222,97,189,109,172,178,191,178,175,186,126,143,195,89,187,104,255,222,58,144,208,171,120,164,88,217,178,179,92,200,147,59,135,27,208,172,228,233,80,41,182,67,204,61,1,93,128,189,231,21,65,88,88,125,182,191,244,64,228,237,244,235,55,124,30,122,131,134,178,82,74,151,178,194,242,44,58,95,17,175,69,167,145,44,133,241,124,18,4,228,181,79,126,246,123,175,46,105,249,151,86,134,176,94,95,219,159,7,218,28,98,10,119,40,132,142,139,141,217,85,118,254,38,128,131,253,242,50,90,63,156,10,23,129,97,153,62,149,232,76,1,146,192,146,101,251,216,158,72,19,161,154,48,45,106,27,35,9,66,242,68,144,72,115,58,195,6,243,56,194,126,239,242,230,161,91,177,64,29,215,174,189,7,138,255,95,48,187,51,244,77,255,77,100,255,187,120,255,77,87,173,116,44,107,223,110,85,5,107,223,194,26,11,211,234,198,220,217,146,77,105,46,113,173,237,111,29,237,216,179,197,135,235,116,37,81,119,178,246,170,45,147,67,129,139,128,112,81,75,242,173,211,29,10,215,180,187,89,219,18,107,11,183,191,50,20,118,10,255,170,19,110,176,22,192,84,178,158,72,133,241,32,6,142,122,130,111,9,207,74,252,236,206,112,219,183,219,235,24,180,10,19,97,237,234,22,25,125,43,57,110,255,95,232,100,151,167,30,124,8,66,56,57,246,186,2,8,237,167,227,205,209,208,91,113,10,76,169,4,49,170,132,155,63,229,84,203,163,141,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadCaseDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ae5885dd-d8e1-4822-b304-e90c2bf74a5e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Name = @"ReadCaseDataUserTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(113, 170),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadCaseDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreatePrepareTagCollectionUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ae5885dd-d8e1-4822-b304-e90c2bf74a5e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ce623b78-6526-411f-bc45-53ddeb08476f"),
				CreatedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"),
				Name = @"PrepareTagCollection",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(393, 170),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializePrepareTagCollectionParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("83d33621-a790-4111-bab0-7772b4d07bcc"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("af4e550c-48e2-4633-8dc7-3d1cb7a5a757")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SearchForParent(userConnection);
		}

		public override object Clone() {
			return new SearchForParentSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a"));
		}

		#endregion

	}

	#endregion

	#region Class: SearchForParent

	/// <exclude/>
	public class SearchForParent : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessFirstSupportLine

		/// <exclude/>
		public class ProcessFirstSupportLine : ProcessLane
		{

			public ProcessFirstSupportLine(UserConnection userConnection, SearchForParent process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: SearchForParentPreconfiguredPageUserTaskFlowElement

		/// <exclude/>
		public class SearchForParentPreconfiguredPageUserTaskFlowElement : PreconfiguredPageUserTask
		{

			#region Constructors: Public

			public SearchForParentPreconfiguredPageUserTaskFlowElement(UserConnection userConnection, SearchForParent process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SearchForParentPreconfiguredPageUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("3477457f-ec61-4efe-815d-337de90d35d3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.FirstSupportLine;
				SerializeToDB = true;
				_caseId = () => (Guid)((process.IncidentId));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("eaad6977be784c4085ad1bbdd5573c1a",
						 "BaseElements.SearchForParentPreconfiguredPageUserTask.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private Guid _clientUnitSchemaUId = new Guid("a463ec0c-c9f2-4b07-9247-27dcb61a6a91");
			public override Guid ClientUnitSchemaUId {
				get {
					return _clientUnitSchemaUId;
				}
				set {
					_clientUnitSchemaUId = value;
				}
			}

			private bool _useCardProcessModule = true;
			public override bool UseCardProcessModule {
				get {
					return _useCardProcessModule;
				}
				set {
					_useCardProcessModule = value;
				}
			}

			public virtual Guid ServiceItem {
				get;
				set;
			}

			public virtual int TotalPages {
				get;
				set;
			}

			public virtual int CurrentPageNumber {
				get;
				set;
			}

			public virtual Guid Result {
				get;
				set;
			}

			public virtual string PageTitle {
				get;
				set;
			}

			public virtual bool HidePageNumbers {
				get;
				set;
			}

			internal Func<Guid> _caseId;
			public virtual Guid CaseId {
				get {
					return (_caseId ?? (_caseId = () => Guid.Empty)).Invoke();
				}
				set {
					_caseId = () => { return value; };
				}
			}

			public virtual string CaseCollectionParam {
				get;
				set;
			}

			#endregion

		}

		#endregion

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, SearchForParent process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("e02dce31-a6f7-4c9a-af3b-2e17cfbedd87");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_ParentCase = () => (Guid)((process.SearchForParentPreconfiguredPageUserTask.Result));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_ParentCase", () => _recordColumnValues_ParentCase.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_ParentCase;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,20,252,43,69,135,158,172,98,125,216,178,220,227,178,45,123,73,3,77,75,33,89,194,179,244,148,21,248,99,99,201,52,193,236,127,175,188,206,166,144,67,41,244,84,208,65,122,210,204,155,25,158,230,123,31,62,249,54,226,88,59,104,3,102,211,206,214,196,240,70,84,141,104,104,101,181,165,210,34,163,13,7,78,185,102,214,184,156,25,203,144,100,61,116,88,147,21,189,181,62,146,204,71,236,66,125,59,255,38,141,227,132,217,189,59,31,190,154,3,118,240,109,105,192,152,178,130,59,77,43,174,10,42,11,33,105,37,25,163,204,148,37,99,133,65,109,44,89,181,48,176,37,230,90,82,166,165,163,82,26,65,193,65,67,185,101,78,53,149,98,133,54,36,107,209,197,237,211,113,196,16,252,208,215,51,190,238,111,158,143,73,229,218,123,51,180,83,215,147,172,195,8,215,16,15,53,1,204,81,22,6,168,145,58,9,113,168,40,136,228,89,64,163,184,170,144,149,76,145,204,192,49,46,180,100,151,84,89,136,240,29,218,9,207,204,179,79,26,185,200,89,85,148,9,203,132,161,82,240,156,86,101,165,168,179,165,211,40,74,173,27,123,201,235,243,228,211,222,135,171,169,195,209,155,151,216,49,229,55,140,245,108,134,62,142,67,187,80,95,157,159,223,224,83,92,195,125,185,250,177,26,138,169,190,128,200,41,155,2,110,90,143,125,220,246,102,176,190,127,88,57,79,167,4,233,142,48,250,112,73,97,251,56,65,75,178,209,63,28,254,152,214,102,10,113,232,254,35,171,89,178,153,56,210,144,157,229,46,51,104,125,56,182,240,124,62,215,228,253,227,52,196,143,215,227,96,146,79,180,239,124,111,188,77,60,107,157,188,193,215,228,142,88,174,114,168,210,60,56,94,9,42,49,55,84,67,211,80,149,166,95,57,163,148,50,229,29,73,154,254,185,211,237,46,124,249,217,95,254,199,234,104,255,33,85,223,20,174,47,200,122,254,27,113,167,253,34,111,127,74,235,23,102,52,166,128,230,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,203,110,219,48,16,252,21,131,201,209,52,76,145,18,69,93,235,20,48,144,52,65,94,23,59,135,21,185,76,4,232,97,144,114,219,212,240,191,151,166,229,218,78,91,160,40,15,18,184,203,153,89,238,14,55,228,178,127,95,33,41,200,35,58,7,190,179,253,228,83,231,112,114,231,58,141,222,79,174,59,13,117,245,3,202,26,239,192,65,131,61,186,103,168,215,232,175,43,223,143,71,231,48,50,38,151,95,99,150,20,139,13,153,247,216,60,205,77,96,215,22,193,164,34,167,82,96,70,69,174,12,45,129,35,85,41,23,58,203,166,137,40,203,0,214,93,189,110,218,27,236,225,14,250,55,82,108,72,100,11,4,144,230,178,20,74,80,33,45,167,162,76,36,45,81,36,20,146,84,97,42,149,157,102,140,108,199,196,235,55,108,32,138,30,193,140,73,195,19,171,104,158,200,148,138,160,73,115,193,24,101,65,154,177,84,163,210,102,7,30,206,31,129,139,139,197,220,223,126,107,209,61,68,222,194,66,237,241,101,18,162,31,2,87,53,54,216,246,197,134,11,41,69,42,45,69,157,49,42,208,34,205,89,106,40,231,210,160,154,26,158,26,190,13,128,95,221,44,54,25,26,200,56,78,169,177,42,15,16,158,208,92,137,140,230,70,169,36,147,101,216,4,200,197,203,174,68,83,249,85,13,239,207,191,87,122,187,194,118,228,171,166,170,193,141,52,120,244,35,143,224,244,219,104,5,175,56,185,71,191,174,251,61,201,234,108,146,167,52,155,229,222,16,75,82,44,255,102,137,225,191,111,192,185,41,62,250,97,73,198,75,242,208,173,157,222,49,242,221,230,48,159,168,48,29,22,253,195,231,176,246,28,17,118,3,109,184,138,251,18,20,35,60,166,102,208,67,20,127,12,117,31,136,203,68,165,83,201,44,149,8,42,180,52,11,45,53,12,168,98,170,180,92,6,51,216,36,162,239,195,128,28,182,26,207,11,251,23,199,68,124,84,62,22,115,176,110,136,180,235,186,142,2,62,222,127,247,22,134,194,135,204,236,100,148,39,12,157,169,108,133,102,222,254,103,171,102,104,35,229,231,206,93,125,15,111,180,106,95,135,137,157,72,31,207,204,116,51,196,183,100,187,125,217,254,4,243,40,241,12,18,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "eaad6977be784c4085ad1bbdd5573c1a",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
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

		#region Class: ReadConfItemDataUserTaskFlowElement

		/// <exclude/>
		public class ReadConfItemDataUserTaskFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadConfItemDataUserTaskFlowElement(UserConnection userConnection, SearchForParent process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadConfItemDataUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("3d783dfa-9ba5-4ff8-a851-bd03abda1ffe");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,203,138,220,48,16,252,149,160,67,78,86,144,52,178,100,59,199,97,2,11,97,51,144,7,129,101,88,244,104,237,136,248,181,150,76,178,152,249,247,200,246,56,89,246,16,114,200,37,224,131,212,82,85,87,85,203,211,189,15,239,124,29,97,168,156,170,3,100,227,141,173,80,225,20,104,106,53,230,69,238,48,231,138,96,77,96,135,89,46,44,24,238,8,200,18,101,173,106,160,66,43,250,96,125,68,153,143,208,132,234,110,250,77,26,135,17,178,123,183,108,62,154,51,52,234,243,220,32,55,146,185,146,1,38,86,48,204,153,32,88,17,237,176,53,4,64,59,158,11,89,160,85,139,208,84,104,109,52,46,132,20,233,170,204,177,6,82,98,71,53,115,194,16,83,104,142,178,26,92,60,252,232,7,8,193,119,109,53,193,175,245,167,167,62,169,92,123,239,187,122,108,90,148,53,16,213,81,197,115,133,156,212,78,49,107,176,3,85,98,46,148,74,78,103,207,154,229,5,225,34,249,87,40,51,170,143,51,45,218,171,0,40,27,192,193,0,173,129,103,142,40,149,118,151,60,225,98,86,200,243,29,199,5,167,20,83,35,4,165,185,129,210,88,148,89,21,213,23,85,143,176,168,154,124,2,106,86,230,68,82,135,229,162,0,82,30,133,165,10,151,180,212,110,39,19,167,99,91,214,239,187,238,219,216,167,156,195,237,216,192,224,205,117,104,144,210,239,134,106,50,93,27,135,174,158,201,111,159,1,214,225,92,15,191,174,129,212,203,201,12,68,151,108,12,176,175,61,180,241,208,154,206,250,246,97,153,219,229,146,48,77,175,6,31,182,24,15,143,163,170,83,0,254,225,252,199,184,247,99,136,93,243,191,249,205,146,215,68,147,158,234,162,121,126,201,214,135,190,86,79,203,190,66,175,31,199,46,190,61,14,157,73,102,193,190,242,173,241,54,209,172,117,244,2,191,221,183,76,18,85,128,196,142,21,187,228,152,24,92,42,173,177,164,198,74,103,164,148,70,92,25,46,217,63,233,120,119,19,62,124,111,183,63,110,13,237,244,38,85,95,20,142,27,186,154,254,70,228,229,180,201,60,93,210,247,19,153,206,39,17,60,4,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,177,50,176,50,208,113,78,44,78,181,50,180,50,4,0,241,126,40,137,15,0,0,0 })));
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
								new Guid("5c72f92e-0d62-4260-a0bf-dc0eebf45678")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("5c72f92e-0d62-4260-a0bf-dc0eebf45678"));
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

		#region Class: ReadCaseDataUserTaskFlowElement

		/// <exclude/>
		public class ReadCaseDataUserTaskFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadCaseDataUserTaskFlowElement(UserConnection userConnection, SearchForParent process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadCaseDataUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("2f48f577-b657-4507-a14f-b3d677f3f02a");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,147,79,107,220,48,16,197,191,74,209,161,39,171,88,150,44,201,206,113,217,150,189,164,11,77,75,33,89,130,44,141,178,2,255,139,37,211,4,227,239,94,217,206,166,144,67,41,244,20,240,65,26,251,189,249,205,99,60,221,59,255,217,213,1,134,210,170,218,67,50,30,76,137,8,79,169,22,164,192,0,82,97,38,41,195,146,230,2,83,13,148,89,75,40,145,41,74,90,213,64,137,54,245,222,184,128,18,23,160,241,229,237,244,199,52,12,35,36,247,118,189,124,211,103,104,212,247,181,1,17,134,102,182,192,50,19,57,102,249,210,128,17,130,137,230,156,144,92,67,161,13,218,88,140,172,42,147,90,129,171,84,114,204,88,158,97,37,185,196,182,0,89,16,157,139,148,231,40,169,193,134,253,83,63,128,247,174,107,203,9,94,207,55,207,125,164,220,122,239,186,122,108,90,148,52,16,212,81,133,115,137,20,164,192,114,173,176,102,69,4,177,32,176,162,133,193,84,85,34,19,18,8,39,2,37,90,245,97,177,69,135,72,101,84,80,63,84,61,194,234,60,185,200,152,209,148,200,156,71,45,161,26,51,154,165,56,34,10,108,13,143,152,148,23,69,101,46,121,125,25,93,60,59,127,61,54,48,56,253,18,59,196,252,186,161,156,116,215,134,161,171,23,235,235,245,243,27,120,10,91,184,47,175,126,110,3,133,88,95,68,104,78,70,15,187,218,65,27,246,173,238,140,107,31,54,207,121,142,146,166,87,131,243,151,20,246,143,163,170,81,50,184,135,243,95,211,218,141,62,116,205,59,26,53,137,99,70,143,184,100,43,238,178,131,198,249,190,86,207,235,189,68,31,31,199,46,92,29,135,78,199,57,193,124,112,173,118,38,250,108,117,244,70,95,162,59,100,50,145,42,25,247,193,102,146,98,6,169,198,133,170,42,44,136,54,194,106,33,132,230,119,40,50,253,119,167,219,131,255,250,171,189,252,31,219,68,167,79,177,250,166,112,188,40,203,233,95,224,230,211,130,119,154,227,243,27,30,212,77,220,230,3,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,43,205,77,74,45,178,50,178,50,212,9,78,45,42,203,76,78,245,44,73,205,181,50,176,50,208,241,76,1,81,0,37,166,231,142,33,0,0,0 })));
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

		#region Class: PrepareTagCollectionFlowElement

		/// <exclude/>
		public class PrepareTagCollectionFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public PrepareTagCollectionFlowElement(UserConnection userConnection, SearchForParent process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "PrepareTagCollection";
				IsLogging = true;
				SchemaElementUId = new Guid("4a618527-da26-4a7e-82d7-a0d4c8f6d67e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,43,69,135,158,172,98,201,178,101,185,199,101,11,129,146,4,250,65,33,44,97,60,26,101,213,250,43,182,76,27,204,254,247,106,215,187,109,200,161,244,208,75,193,7,105,164,247,230,189,55,242,114,239,167,119,190,9,52,86,14,154,137,146,249,202,86,172,48,169,74,157,1,158,167,96,185,146,2,57,128,149,60,43,50,5,90,164,89,86,58,150,116,208,82,197,86,244,214,250,192,18,31,168,157,170,187,229,55,105,24,103,74,238,221,105,243,1,247,212,194,167,99,3,139,70,213,86,58,158,231,105,206,85,89,35,47,177,208,92,89,89,107,2,109,106,202,217,170,69,230,166,52,89,234,56,24,225,184,50,46,94,5,68,46,44,90,161,82,68,43,21,75,26,114,97,251,99,24,105,154,124,223,85,11,253,90,127,124,26,162,202,181,247,166,111,230,182,99,73,75,1,110,33,236,43,6,25,213,37,101,5,47,108,30,133,216,210,114,131,66,113,145,202,26,181,113,164,74,96,9,194,16,142,180,236,166,254,74,24,141,142,228,104,164,14,233,153,39,33,180,205,164,51,188,148,58,82,229,153,226,165,18,130,11,44,10,33,114,36,131,150,37,22,2,124,134,102,166,147,174,197,71,96,45,77,158,234,104,46,58,55,92,81,33,121,105,5,112,35,76,237,50,29,57,157,188,164,253,190,239,191,205,67,76,122,186,158,91,26,61,158,199,70,49,255,126,172,22,236,187,48,246,205,145,252,250,25,96,29,207,249,240,203,26,73,115,58,57,2,217,33,153,39,218,52,158,186,176,237,176,183,190,123,56,77,238,112,136,152,118,128,209,79,151,32,183,143,51,52,49,0,255,176,255,99,224,155,121,10,125,251,191,249,77,162,215,72,19,31,235,73,243,241,45,91,63,13,13,60,157,246,21,123,253,56,247,225,237,237,216,99,52,75,246,149,239,208,219,72,179,214,217,11,252,229,190,149,58,133,146,52,119,178,204,162,227,20,185,129,186,230,90,160,213,14,181,214,88,156,25,14,201,63,233,120,119,53,221,124,239,46,255,220,26,218,238,77,172,190,40,220,94,208,213,242,55,34,15,187,139,204,221,33,126,63,1,218,179,228,98,62,4,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,243,76,177,50,176,50,208,9,73,76,183,50,180,50,4,0,218,2,59,40,14,0,0,0 })));
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
								new Guid("dc94bd2f-5505-48bc-8c67-4d2b7ea79be5")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("dc94bd2f-5505-48bc-8c67-4d2b7ea79be5"));
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

		public SearchForParent(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SearchForParent";
			SchemaUId = new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_isCaseCollectionAny = () => { return (bool)(false); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("eaad6977-be78-4c40-85ad-1bbdd5573c1a");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SearchForParent, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SearchForParent, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid IncidentId {
			get;
			set;
		}

		private Func<bool> _isCaseCollectionAny;
		public virtual bool IsCaseCollectionAny {
			get {
				return (_isCaseCollectionAny ?? (_isCaseCollectionAny = () => false)).Invoke();
			}
			set {
				_isCaseCollectionAny = () => { return value; };
			}
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
					SchemaElementUId = new Guid("bfc04a7f-3451-4aab-b2ce-0f992a937a13"),
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
					SchemaElementUId = new Guid("c54dcc84-10c3-4c6b-83d2-71375cca6121"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private SearchForParentPreconfiguredPageUserTaskFlowElement _searchForParentPreconfiguredPageUserTask;
		public SearchForParentPreconfiguredPageUserTaskFlowElement SearchForParentPreconfiguredPageUserTask {
			get {
				return _searchForParentPreconfiguredPageUserTask ?? (_searchForParentPreconfiguredPageUserTask = new SearchForParentPreconfiguredPageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadConfItemDataUserTaskFlowElement _readConfItemDataUserTask;
		public ReadConfItemDataUserTaskFlowElement ReadConfItemDataUserTask {
			get {
				return _readConfItemDataUserTask ?? (_readConfItemDataUserTask = new ReadConfItemDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _prepareCaseCollection;
		public ProcessScriptTask PrepareCaseCollection {
			get {
				return _prepareCaseCollection ?? (_prepareCaseCollection = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareCaseCollection",
					SchemaElementUId = new Guid("f223b416-07f8-4d28-be9a-ff5273b6274f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = PrepareCaseCollectionExecute,
				});
			}
		}

		private ReadCaseDataUserTaskFlowElement _readCaseDataUserTask;
		public ReadCaseDataUserTaskFlowElement ReadCaseDataUserTask {
			get {
				return _readCaseDataUserTask ?? (_readCaseDataUserTask = new ReadCaseDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private PrepareTagCollectionFlowElement _prepareTagCollection;
		public PrepareTagCollectionFlowElement PrepareTagCollection {
			get {
				return _prepareTagCollection ?? (_prepareTagCollection = new PrepareTagCollectionFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _parentCaseSelectedConditionalFlow;
		public ProcessConditionalFlow ParentCaseSelectedConditionalFlow {
			get {
				return _parentCaseSelectedConditionalFlow ?? (_parentCaseSelectedConditionalFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ParentCaseSelectedConditionalFlow",
					SchemaElementUId = new Guid("d0644cf4-411e-46d8-b79c-a9b7c342f134"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
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
					SchemaElementUId = new Guid("4350a31d-c5db-45f9-8efd-4f58d1b70544"),
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
			FlowElements[SearchForParentPreconfiguredPageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SearchForParentPreconfiguredPageUserTask };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ReadConfItemDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadConfItemDataUserTask };
			FlowElements[PrepareCaseCollection.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareCaseCollection };
			FlowElements[ReadCaseDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadCaseDataUserTask };
			FlowElements[PrepareTagCollection.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareTagCollection };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadCaseDataUserTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "SearchForParentPreconfiguredPageUserTask":
						if (ParentCaseSelectedConditionalFlowExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadConfItemDataUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PrepareTagCollection", e.Context.SenderName));
						break;
					case "PrepareCaseCollection":
						if (ConditionalFlow1ExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SearchForParentPreconfiguredPageUserTask", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						Log.ErrorFormat(DeadEndGatewayLogMessage, "PrepareCaseCollection");
						break;
					case "ReadCaseDataUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadConfItemDataUserTask", e.Context.SenderName));
						break;
					case "PrepareTagCollection":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PrepareCaseCollection", e.Context.SenderName));
						break;
			}
		}

		private bool ParentCaseSelectedConditionalFlowExpressionExecute() {
			bool result = Convert.ToBoolean((SearchForParentPreconfiguredPageUserTask.Result) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "SearchForParentPreconfiguredPageUserTask", "ParentCaseSelectedConditionalFlow", "(SearchForParentPreconfiguredPageUserTask.Result) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((IsCaseCollectionAny));
			Log.InfoFormat(ConditionalExpressionLogMessage, "PrepareCaseCollection", "ConditionalFlow1", "(IsCaseCollectionAny)", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("SearchForParentPreconfiguredPageUserTask.ServiceItem")) {
				writer.WriteValue("SearchForParentPreconfiguredPageUserTask.ServiceItem", SearchForParentPreconfiguredPageUserTask.ServiceItem, Guid.Empty);
			}
			if (!HasMapping("SearchForParentPreconfiguredPageUserTask.TotalPages")) {
				writer.WriteValue("SearchForParentPreconfiguredPageUserTask.TotalPages", SearchForParentPreconfiguredPageUserTask.TotalPages, 0);
			}
			if (!HasMapping("SearchForParentPreconfiguredPageUserTask.CurrentPageNumber")) {
				writer.WriteValue("SearchForParentPreconfiguredPageUserTask.CurrentPageNumber", SearchForParentPreconfiguredPageUserTask.CurrentPageNumber, 0);
			}
			if (!HasMapping("SearchForParentPreconfiguredPageUserTask.Result")) {
				writer.WriteValue("SearchForParentPreconfiguredPageUserTask.Result", SearchForParentPreconfiguredPageUserTask.Result, Guid.Empty);
			}
			if (!HasMapping("SearchForParentPreconfiguredPageUserTask.PageTitle")) {
				writer.WriteValue("SearchForParentPreconfiguredPageUserTask.PageTitle", SearchForParentPreconfiguredPageUserTask.PageTitle, null);
			}
			if (!HasMapping("SearchForParentPreconfiguredPageUserTask.HidePageNumbers")) {
				writer.WriteValue("SearchForParentPreconfiguredPageUserTask.HidePageNumbers", SearchForParentPreconfiguredPageUserTask.HidePageNumbers, false);
			}
			if (!HasMapping("SearchForParentPreconfiguredPageUserTask.CaseId")) {
				writer.WriteValue("SearchForParentPreconfiguredPageUserTask.CaseId", SearchForParentPreconfiguredPageUserTask.CaseId, Guid.Empty);
			}
			if (!HasMapping("SearchForParentPreconfiguredPageUserTask.CaseCollectionParam")) {
				writer.WriteValue("SearchForParentPreconfiguredPageUserTask.CaseCollectionParam", SearchForParentPreconfiguredPageUserTask.CaseCollectionParam, null);
			}
			if (!HasMapping("IncidentId")) {
				writer.WriteValue("IncidentId", IncidentId, Guid.Empty);
			}
			if (!HasMapping("IsCaseCollectionAny")) {
				writer.WriteValue("IsCaseCollectionAny", IsCaseCollectionAny, false);
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
			MetaPathParameterValues.Add("d270a8e7-f283-4e0c-9abb-71cd7fc777c6", () => IncidentId);
			MetaPathParameterValues.Add("f83d82b0-58af-4e46-968e-7c6ef3d7b958", () => IsCaseCollectionAny);
			MetaPathParameterValues.Add("425b83a9-1efb-4042-8357-a8bb999509f4", () => SearchForParentPreconfiguredPageUserTask.Title);
			MetaPathParameterValues.Add("22d91d0f-7c9a-4ab4-be73-b242a2d32322", () => SearchForParentPreconfiguredPageUserTask.Recommendation);
			MetaPathParameterValues.Add("1396cfec-96e9-4358-ba2a-db56f25466d7", () => SearchForParentPreconfiguredPageUserTask.ClientUnitSchemaUId);
			MetaPathParameterValues.Add("91d5ab47-a61f-4071-804e-e9f0565f3ccc", () => SearchForParentPreconfiguredPageUserTask.EntityId);
			MetaPathParameterValues.Add("3f5d1bed-0e68-4f37-b37a-fa58e5f88671", () => SearchForParentPreconfiguredPageUserTask.EntryPointId);
			MetaPathParameterValues.Add("f80ca0e3-df11-4e51-8ed1-7b98c0dffeee", () => SearchForParentPreconfiguredPageUserTask.EntitySchemaUId);
			MetaPathParameterValues.Add("a30c0fcd-9d71-4b13-82ee-e7dba8cf37b0", () => SearchForParentPreconfiguredPageUserTask.UseCardProcessModule);
			MetaPathParameterValues.Add("dea4a681-ca88-4b34-bd1d-b2d572da8b1b", () => SearchForParentPreconfiguredPageUserTask.OwnerId);
			MetaPathParameterValues.Add("659d70cd-0a71-48d8-9eff-11a205ff4b3d", () => SearchForParentPreconfiguredPageUserTask.ShowExecutionPage);
			MetaPathParameterValues.Add("b662c6d3-20ec-4889-a118-c2838daa4b62", () => SearchForParentPreconfiguredPageUserTask.InformationOnStep);
			MetaPathParameterValues.Add("c2cbff2b-348c-417e-8ba3-b85b5b4ef5b8", () => SearchForParentPreconfiguredPageUserTask.IsRunning);
			MetaPathParameterValues.Add("248b8f00-e298-4070-8e9b-ddf585c1cc2f", () => SearchForParentPreconfiguredPageUserTask.Template);
			MetaPathParameterValues.Add("26a88202-ce7b-439d-a4e3-5e9b025e16b4", () => SearchForParentPreconfiguredPageUserTask.Module);
			MetaPathParameterValues.Add("1f047336-25d7-4503-86ee-bd5308da2da5", () => SearchForParentPreconfiguredPageUserTask.PressedButtonCode);
			MetaPathParameterValues.Add("c8d8e280-5095-4a16-b650-fec6bdb41f64", () => SearchForParentPreconfiguredPageUserTask.Url);
			MetaPathParameterValues.Add("670b0150-bc25-4597-acbb-1404bbbbc8f2", () => SearchForParentPreconfiguredPageUserTask.CurrentActivityId);
			MetaPathParameterValues.Add("016d7767-c561-4adb-a9b7-c358cc40595d", () => SearchForParentPreconfiguredPageUserTask.CreateActivity);
			MetaPathParameterValues.Add("4e0c550a-ca20-4baf-8399-b692ae27c15a", () => SearchForParentPreconfiguredPageUserTask.ActivityPriority);
			MetaPathParameterValues.Add("63a64efa-4a7e-4f0c-9e9a-1bcc05010f43", () => SearchForParentPreconfiguredPageUserTask.StartIn);
			MetaPathParameterValues.Add("a8a3647a-96ff-48e0-a47b-7f3dbeba7408", () => SearchForParentPreconfiguredPageUserTask.StartInPeriod);
			MetaPathParameterValues.Add("e2144b9b-f825-418e-858a-c8518699e79e", () => SearchForParentPreconfiguredPageUserTask.Duration);
			MetaPathParameterValues.Add("93c4b302-dcaf-4502-965d-1555706464b4", () => SearchForParentPreconfiguredPageUserTask.DurationPeriod);
			MetaPathParameterValues.Add("738c84c3-f74e-432f-9119-51ad130f13cf", () => SearchForParentPreconfiguredPageUserTask.ShowInScheduler);
			MetaPathParameterValues.Add("394540bd-dfb1-46bc-8ed3-085376b976b8", () => SearchForParentPreconfiguredPageUserTask.RemindBefore);
			MetaPathParameterValues.Add("a0f7f61a-c030-4340-8c34-b63b025a844a", () => SearchForParentPreconfiguredPageUserTask.RemindBeforePeriod);
			MetaPathParameterValues.Add("a2cb32e2-a0b0-414e-b429-15b555836062", () => SearchForParentPreconfiguredPageUserTask.ActivityResult);
			MetaPathParameterValues.Add("d21da11f-4af8-4f55-b6b5-f3b947f1691f", () => SearchForParentPreconfiguredPageUserTask.IsActivityCompleted);
			MetaPathParameterValues.Add("0a201783-e5a9-49bb-aa18-483539cd7e45", () => SearchForParentPreconfiguredPageUserTask.ServiceItem);
			MetaPathParameterValues.Add("6220e5ea-1f4c-4e9b-b033-f97c376b240c", () => SearchForParentPreconfiguredPageUserTask.TotalPages);
			MetaPathParameterValues.Add("e9db3967-c4c4-4bc4-8167-944c1682b12c", () => SearchForParentPreconfiguredPageUserTask.CurrentPageNumber);
			MetaPathParameterValues.Add("6eda63e0-df98-4e32-8946-8d99267b8943", () => SearchForParentPreconfiguredPageUserTask.Result);
			MetaPathParameterValues.Add("929b077b-0f50-49ff-a5b4-a1f72fb2e16c", () => SearchForParentPreconfiguredPageUserTask.PageTitle);
			MetaPathParameterValues.Add("11939531-2013-4afa-b680-6c5672ac4563", () => SearchForParentPreconfiguredPageUserTask.HidePageNumbers);
			MetaPathParameterValues.Add("0662da67-49e4-4828-8aac-06b388cca81f", () => SearchForParentPreconfiguredPageUserTask.CaseId);
			MetaPathParameterValues.Add("21cdc12a-97d7-4875-9cbc-8e89b57b8f11", () => SearchForParentPreconfiguredPageUserTask.CaseCollectionParam);
			MetaPathParameterValues.Add("ace78947-8c57-47c0-ae85-c57a5821bb13", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("d8ec807d-7f8d-4037-b2ab-9c88007c0121", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("d9594b77-041b-46f3-9024-1bd044d68726", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("55f85150-f401-4e97-9d12-0f211ee35972", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("ef745821-7b98-4cde-a848-f26a508d70e6", () => ChangeDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("cd861df3-40fb-4186-b65e-25dba80f9e24", () => ReadConfItemDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("84cb8b09-ef03-435e-8588-4e64e6ef5a4f", () => ReadConfItemDataUserTask.ResultType);
			MetaPathParameterValues.Add("97a0ecd6-d533-479c-a450-c4a2577641d4", () => ReadConfItemDataUserTask.ReadSomeTopRecords);
			MetaPathParameterValues.Add("05538184-0f57-423a-b191-c5dbdac068f8", () => ReadConfItemDataUserTask.NumberOfRecords);
			MetaPathParameterValues.Add("c73f9f80-fd7b-4cf1-acb9-d60091d0f344", () => ReadConfItemDataUserTask.FunctionType);
			MetaPathParameterValues.Add("a13349cc-1228-4922-a0ff-008c512c950b", () => ReadConfItemDataUserTask.AggregationColumnName);
			MetaPathParameterValues.Add("93e4cd31-714c-41ca-ae3a-d8696adcf3dd", () => ReadConfItemDataUserTask.OrderInfo);
			MetaPathParameterValues.Add("5f8f8252-4b03-4c7c-bd80-b7808545ec0c", () => ReadConfItemDataUserTask.ResultEntity);
			MetaPathParameterValues.Add("c76d235a-b599-4654-ba0e-21d29510a3b3", () => ReadConfItemDataUserTask.ResultCount);
			MetaPathParameterValues.Add("7fde92e2-24aa-451d-bd80-ee4640257ed9", () => ReadConfItemDataUserTask.ResultIntegerFunction);
			MetaPathParameterValues.Add("0294f17d-4f4c-41a8-84bd-41091d1e9884", () => ReadConfItemDataUserTask.ResultFloatFunction);
			MetaPathParameterValues.Add("d1c4b637-39da-474d-980c-8c8ad96125c5", () => ReadConfItemDataUserTask.ResultDateTimeFunction);
			MetaPathParameterValues.Add("44873c50-da69-45fb-b889-4e99c0c63fba", () => ReadConfItemDataUserTask.ResultRowsCount);
			MetaPathParameterValues.Add("4066fd99-ee9a-4434-9b7d-3d6cfe69c3ed", () => ReadConfItemDataUserTask.CanReadUncommitedData);
			MetaPathParameterValues.Add("2b138545-6ab5-4b6c-bd27-a904e645cb89", () => ReadConfItemDataUserTask.ResultEntityCollection);
			MetaPathParameterValues.Add("cf362cd5-a00c-4a73-a580-9a64f6cb55ac", () => ReadConfItemDataUserTask.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("46bc0544-e508-430d-b9ad-6eb5ebd0d48b", () => ReadConfItemDataUserTask.IgnoreDisplayValues);
			MetaPathParameterValues.Add("44458d37-76c5-4b36-b11f-a55b386019de", () => ReadConfItemDataUserTask.ResultCompositeObjectList);
			MetaPathParameterValues.Add("8b54bfea-6880-477e-89eb-4dd5a3049f87", () => ReadConfItemDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("acf43b55-9bc9-4f23-ab2f-4be0d0fda31f", () => ReadCaseDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("870b6336-1d39-430f-af59-ef5b32142e14", () => ReadCaseDataUserTask.ResultType);
			MetaPathParameterValues.Add("14b1a615-9e84-4bf2-95fa-7edb14a5255f", () => ReadCaseDataUserTask.ReadSomeTopRecords);
			MetaPathParameterValues.Add("dd90fd1c-0563-48f6-ab88-502b7089d065", () => ReadCaseDataUserTask.NumberOfRecords);
			MetaPathParameterValues.Add("fbbe03b2-1467-4b16-bce2-946a0ea9dde1", () => ReadCaseDataUserTask.FunctionType);
			MetaPathParameterValues.Add("2a0c0741-97b6-4dfb-9773-ab3e71bf05e7", () => ReadCaseDataUserTask.AggregationColumnName);
			MetaPathParameterValues.Add("e50d1955-15fb-4f03-add8-674d9bdd2878", () => ReadCaseDataUserTask.OrderInfo);
			MetaPathParameterValues.Add("72430e28-8bf4-41c4-8aa3-392123b79311", () => ReadCaseDataUserTask.ResultEntity);
			MetaPathParameterValues.Add("64981203-3d0d-4db5-b21e-8d95f119545f", () => ReadCaseDataUserTask.ResultCount);
			MetaPathParameterValues.Add("0594e91b-20aa-47ba-b7b9-c3c046612aff", () => ReadCaseDataUserTask.ResultIntegerFunction);
			MetaPathParameterValues.Add("e97c2cc7-5ef7-4027-b501-41a79b2a21b2", () => ReadCaseDataUserTask.ResultFloatFunction);
			MetaPathParameterValues.Add("6fb0bacd-1017-4b1c-8458-a9b76a08c1d0", () => ReadCaseDataUserTask.ResultDateTimeFunction);
			MetaPathParameterValues.Add("380ab258-c3ad-496b-ad59-c7ba3f40c610", () => ReadCaseDataUserTask.ResultRowsCount);
			MetaPathParameterValues.Add("6ce7255d-b559-43d6-bed7-f3e91167dbf8", () => ReadCaseDataUserTask.CanReadUncommitedData);
			MetaPathParameterValues.Add("19c3b6f8-27ba-43df-be8e-76a89b378ea5", () => ReadCaseDataUserTask.ResultEntityCollection);
			MetaPathParameterValues.Add("1087a0aa-984b-42e6-b132-8d5478f65528", () => ReadCaseDataUserTask.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("4faa6e56-1123-4ec1-909d-aaad325be138", () => ReadCaseDataUserTask.IgnoreDisplayValues);
			MetaPathParameterValues.Add("33c04b7b-b6d0-46ee-b742-e553c9c84b94", () => ReadCaseDataUserTask.ResultCompositeObjectList);
			MetaPathParameterValues.Add("fcd2bf96-d170-4e41-8f08-42191946c92e", () => ReadCaseDataUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("6418d70e-c8df-4215-a8a3-cb363d472ec0", () => PrepareTagCollection.DataSourceFilters);
			MetaPathParameterValues.Add("ad80f9ab-24d3-4614-ac24-e78e1e7f8cc9", () => PrepareTagCollection.ResultType);
			MetaPathParameterValues.Add("fd932721-9572-4d4d-9ae0-a53f2f7a9404", () => PrepareTagCollection.ReadSomeTopRecords);
			MetaPathParameterValues.Add("8fe4967a-019f-4732-8095-d40150ef5806", () => PrepareTagCollection.NumberOfRecords);
			MetaPathParameterValues.Add("5fb9d631-8efe-459a-9bd5-6fed2139169c", () => PrepareTagCollection.FunctionType);
			MetaPathParameterValues.Add("e4e5c77d-f138-4aa2-94e0-b84a088abacc", () => PrepareTagCollection.AggregationColumnName);
			MetaPathParameterValues.Add("259d4266-8c7e-4c27-b0f0-98cdf9128a23", () => PrepareTagCollection.OrderInfo);
			MetaPathParameterValues.Add("21277763-11c1-45b5-85ba-7d1933f003a9", () => PrepareTagCollection.ResultEntity);
			MetaPathParameterValues.Add("fe355ae7-ae4c-401b-9d39-9d56030ea11c", () => PrepareTagCollection.ResultCount);
			MetaPathParameterValues.Add("db47687b-5a80-4a97-8e54-fd79fc9357df", () => PrepareTagCollection.ResultIntegerFunction);
			MetaPathParameterValues.Add("8db483e0-0d10-4173-987c-761a50993f1c", () => PrepareTagCollection.ResultFloatFunction);
			MetaPathParameterValues.Add("66a32598-4247-4928-9458-69deda5a2d2d", () => PrepareTagCollection.ResultDateTimeFunction);
			MetaPathParameterValues.Add("03fa10e4-0653-4807-96a6-5f7afd87fa99", () => PrepareTagCollection.ResultRowsCount);
			MetaPathParameterValues.Add("e7e86faa-f353-40d1-bda1-b828e648e3e6", () => PrepareTagCollection.CanReadUncommitedData);
			MetaPathParameterValues.Add("7964a7ec-d994-44ef-b450-d3fd3382705c", () => PrepareTagCollection.ResultEntityCollection);
			MetaPathParameterValues.Add("2ed44ec2-017e-412a-9306-9b3ae4a16754", () => PrepareTagCollection.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("9dd501c5-5d42-4870-8c69-3f4c0982c50a", () => PrepareTagCollection.IgnoreDisplayValues);
			MetaPathParameterValues.Add("53f0274e-6a67-4b8d-a1a5-55e83be56bdd", () => PrepareTagCollection.ResultCompositeObjectList);
			MetaPathParameterValues.Add("bb53212b-35ce-4fbb-9e9f-0903d673264e", () => PrepareTagCollection.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "SearchForParentPreconfiguredPageUserTask.ServiceItem":
					SearchForParentPreconfiguredPageUserTask.ServiceItem = reader.GetValue<System.Guid>();
				break;
				case "SearchForParentPreconfiguredPageUserTask.TotalPages":
					SearchForParentPreconfiguredPageUserTask.TotalPages = reader.GetValue<System.Int32>();
				break;
				case "SearchForParentPreconfiguredPageUserTask.CurrentPageNumber":
					SearchForParentPreconfiguredPageUserTask.CurrentPageNumber = reader.GetValue<System.Int32>();
				break;
				case "SearchForParentPreconfiguredPageUserTask.Result":
					SearchForParentPreconfiguredPageUserTask.Result = reader.GetValue<System.Guid>();
				break;
				case "SearchForParentPreconfiguredPageUserTask.PageTitle":
					SearchForParentPreconfiguredPageUserTask.PageTitle = reader.GetValue<System.String>();
				break;
				case "SearchForParentPreconfiguredPageUserTask.HidePageNumbers":
					SearchForParentPreconfiguredPageUserTask.HidePageNumbers = reader.GetValue<System.Boolean>();
				break;
				case "SearchForParentPreconfiguredPageUserTask.CaseId":
					SearchForParentPreconfiguredPageUserTask.CaseId = reader.GetValue<System.Guid>();
				break;
				case "SearchForParentPreconfiguredPageUserTask.CaseCollectionParam":
					SearchForParentPreconfiguredPageUserTask.CaseCollectionParam = reader.GetValue<System.String>();
				break;
				case "IncidentId":
					if (!hasValueToRead) break;
					IncidentId = reader.GetValue<System.Guid>();
				break;
				case "IsCaseCollectionAny":
					if (!hasValueToRead) break;
					IsCaseCollectionAny = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool PrepareCaseCollectionExecute(ProcessExecutingContext context) {
			var esqCase = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Case");
			esqCase.AddColumn("Id");
			esqCase.AddColumn("RegisteredOn").OrderDirection = OrderDirection.Descending;
			esqCase.Filters.Add(esqCase.CreateFilterWithParameters(FilterComparisonType.NotEqual, "Id", IncidentId));
			esqCase.Filters.Add(esqCase.CreateFilterWithParameters(FilterComparisonType.Equal, "Status.IsFinal", false));
			esqCase.Filters.LogicalOperation = LogicalOperationStrict.And;
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Case");
			esq.AddColumn("Id");
			esq.Filters.LogicalOperation = LogicalOperationStrict.Or;
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "ServiceItem", ReadCaseDataUserTask.ResultEntity.GetColumnValue("ServiceItemId")));
			var entityList = new List<Entity>(ReadConfItemDataUserTask.ResultEntityCollection);
			var guidArray = entityList.Select(m=>m.GetTypedColumnValue<Object>("ConfItemId")).ToArray();
			if (guidArray.Count() == 0) {
				esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "[ConfItemInCase:Case].ConfItem", Guid.Empty));
			} else {
				esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "[ConfItemInCase:Case].ConfItem", guidArray));
			}
			var tags = new List<Entity>(PrepareTagCollection.ResultEntityCollection);
			var tagArray = tags.Select(m => m.GetTypedColumnValue<Object>("TagId")).ToArray();
			if (tagArray.Count() == 0)
			{
				esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "[CaseInTag:Entity].Tag", Guid.Empty));
			} else {
				esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "[CaseInTag:Entity].Tag", tagArray));
			}
			esqCase.Filters.Add(esqCase.CreateFilter(FilterComparisonType.Equal, "Id", esq));
			var result = esqCase.GetEntityCollection(UserConnection);
			var localCollection = new EntityCollection(UserConnection, "Case");
			foreach(var element in result){
				localCollection.Add(element);
			}
			IsCaseCollectionAny = localCollection.Any();
			SearchForParentPreconfiguredPageUserTask.CaseCollectionParam = String.Join("|", localCollection.Select(e=>e.GetTypedColumnValue<string>("Id1")).ToArray());
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
			var cloneItem = (SearchForParent)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


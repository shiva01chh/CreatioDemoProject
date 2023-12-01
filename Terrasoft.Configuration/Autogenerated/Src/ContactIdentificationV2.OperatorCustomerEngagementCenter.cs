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

	#region Class: ContactIdentificationV2Schema

	/// <exclude/>
	public class ContactIdentificationV2Schema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ContactIdentificationV2Schema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ContactIdentificationV2Schema(ContactIdentificationV2Schema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContactIdentificationV2";
			UId = new Guid("f58fbc05-8179-4074-9636-19e734769536");
			CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.10.1.444";
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
			UseForceCompile = true;
			Version = 1;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("f58fbc05-8179-4074-9636-19e734769536");
			Version = 1;
			PackageUId = new Guid("e16ad5af-f2b8-4128-ab85-84768b536fe3");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateContactIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("deefb406-4a64-4513-9f48-328ba955695b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ContactId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAccountIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("839ed405-68e4-4e40-bd9c-062c634c4a20"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePhoneNumberParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("244eac40-5473-4748-aa26-e77b96a35846"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"PhoneNumber",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewContactParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fe1f7c0c-c8cf-47c3-bbfe-363c45186118"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"NewContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCaseIncludedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e5e56c22-18ea-449c-b1be-62a59c96abd7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"IsCaseIncluded",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAccountSelectedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("22ed503f-1097-4afd-9c1c-e7591592243a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AccountSelected",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateContactButtonCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("77a86efd-52da-41d3-b551-b2af78145723"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"CreateContactButtonCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSearchDetailSelectButtonCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ce1af657-ffbd-40aa-8ba8-92e5d0b88a47"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"SearchDetailSelectButtonCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDefaultContactNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("04c9b73f-67bc-483e-9d66-6c2494c5be0f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"DefaultContactName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateContactIdParameter());
			Parameters.Add(CreateAccountIdParameter());
			Parameters.Add(CreatePhoneNumberParameter());
			Parameters.Add(CreateNewContactParameter());
			Parameters.Add(CreateIsCaseIncludedParameter());
			Parameters.Add(CreateAccountSelectedParameter());
			Parameters.Add(CreateCreateContactButtonCaptionParameter());
			Parameters.Add(CreateSearchDetailSelectButtonCaptionParameter());
			Parameters.Add(CreateDefaultContactNameParameter());
		}

		protected virtual void InitializePreconfiguredPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("69b15c71-905e-4fe2-b8c8-13247e6c2e08"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				Value = @"Search page - Contacts and Accoutns",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7e141f0a-9d5c-457c-a67f-0a1d278e31bd"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("1b7e2a98-62c5-480f-87de-803a6fd6bd04"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				Value = @"4f01d1ce-b5c7-4d19-b354-b5bef74d6e95",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(clientUnitSchemaUIdParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55b46c6d-9866-4800-b1a5-66f885cd2355"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0ae7e716-e7cc-4a75-ae50-55d0030ffc0a"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("d602fd51-f1ec-46f8-a61c-e2a65578dafd"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var useCardProcessModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("03340eb8-8dc3-4cfa-803e-9f3b3bc34101"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(useCardProcessModuleParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("8c360d85-bf72-4c87-8c17-d3163c1c7d9d"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#SysVariable.CurrentUserContact#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("972c2fff-1e7a-4897-88b5-1b6a3de96469"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("6943ab1a-dce8-4c57-bd3b-eb4715dcb1d5"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("23145d3b-45a3-4a9a-b019-f296e0cbcfb0"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(isRunningParameter);
			var templateParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				UId = new Guid("4a5221ff-1dfa-4371-aa3b-b83fc6ef48f2"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("c003612c-32bf-4743-9ddc-9cd6eddfff56"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("993430b0-b3fc-4871-a50f-48baed943409"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("3f7bb4ba-649e-4dbc-9238-e0630e06179b"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("0089de74-c149-432d-b6bd-700caa13d660"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("46298d4b-f2db-45c6-9c57-cacc8316da59"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("54c71711-c4a4-4811-86f7-7bf7eb77df3c"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("1354525d-6ec9-4419-9199-6312ac9d97d4"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("44744e62-de7d-4719-9d52-621e63480486"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("3f26e0e6-56b2-4176-866b-07504872eebd"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("cfa83da4-dc81-4fcc-b946-d0189d57aebc"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("d1e162ce-f452-4a5e-ac2d-f2c213ce3422"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("0de510ec-b520-4f58-809c-bb7999f2a4b0"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("bf93f395-9044-4c42-912b-109b4e2a50b2"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("31ea7bf9-a7f7-4bae-9cf8-7bbf65717805"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
				UId = new Guid("18a9f5f0-2c9c-4808-bf57-d409a0ffaa4f"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
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
			var contactIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("12fe9831-090b-4b80-938e-a6c2149a2993"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ContactId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactIdParameter.SourceValue = new ProcessSchemaParameterValue(contactIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(contactIdParameter);
			var accountIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("6f5535c1-cef2-4fab-aa8c-101f094e1360"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountIdParameter.SourceValue = new ProcessSchemaParameterValue(accountIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(accountIdParameter);
			var contactNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aba17913-301c-4b8a-8b12-d315eba94a55"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ContactName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			contactNameParameter.SourceValue = new ProcessSchemaParameterValue(contactNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(contactNameParameter);
			var phoneNumberParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f0c052d1-ca27-43fa-bd30-40cbc6d55b3d"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"PhoneNumber",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			phoneNumberParameter.SourceValue = new ProcessSchemaParameterValue(phoneNumberParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(phoneNumberParameter);
			var emailParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc1e2817-ed80-4462-81b7-66965f9c76df"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Email",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			emailParameter.SourceValue = new ProcessSchemaParameterValue(emailParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(emailParameter);
			var isContactSelectedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("154e18f3-415a-442d-a42b-a1ab3f228aa9"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"IsContactSelected",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isContactSelectedParameter.SourceValue = new ProcessSchemaParameterValue(isContactSelectedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(isContactSelectedParameter);
			var resultCodeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("17a010c9-438a-4621-b397-adfd1bbf6b2c"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ResultCode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			resultCodeParameter.SourceValue = new ProcessSchemaParameterValue(resultCodeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultCodeParameter);
			var isCaseIncludedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f9936a9b-7364-4807-886d-c47923aa5526"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"IsCaseIncluded",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isCaseIncludedParameter.SourceValue = new ProcessSchemaParameterValue(isCaseIncludedParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{e5e56c22-18ea-449c-b1be-62a59c96abd7}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(isCaseIncludedParameter);
			var accountNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc227909-1872-4ba3-9409-260e522e5bda"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AccountName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			accountNameParameter.SourceValue = new ProcessSchemaParameterValue(accountNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(accountNameParameter);
			var createContactButtonCaptionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("932357b5-6b5b-4d70-b80b-a52c2cd999a5"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"CreateContactButtonCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			createContactButtonCaptionParameter.SourceValue = new ProcessSchemaParameterValue(createContactButtonCaptionParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{77a86efd-52da-41d3-b551-b2af78145723}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(createContactButtonCaptionParameter);
			var searchDetailSelectButtonCaptionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("36bf19ed-4a1b-46d1-8360-7b98a0a05451"),
				ContainerUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"SearchDetailSelectButtonCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText")
			};
			searchDetailSelectButtonCaptionParameter.SourceValue = new ProcessSchemaParameterValue(searchDetailSelectButtonCaptionParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{ce1af657-ffbd-40aa-8ba8-92e5d0b88a47}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(searchDetailSelectButtonCaptionParameter);
		}

		protected virtual void InitializeAddDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("2cc3931e-cae7-49e3-8cf0-9ce37b4622d1"),
				ContainerUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
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
				Value = @"16be3651-8fe2-4159-8dd0-a803d4683dd3",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("52f0c27a-aa7b-4b1a-81a6-d96439fb602b"),
				ContainerUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e33fa283-1e3e-45ee-a4c9-cd8f02f2bd1f"),
				ContainerUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("3b08e0b0-95c8-4039-b074-cc84d0e02189"),
				ContainerUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("03c59888-3e70-4fc6-b8d8-8ca80b0c1a0f"),
				ContainerUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,151,75,111,219,56,16,128,255,138,161,246,176,11,132,6,223,15,95,22,139,38,135,0,125,4,77,183,151,56,135,33,57,108,12,200,114,32,201,91,100,13,255,247,142,148,56,47,108,211,54,93,116,81,52,58,216,18,201,121,104,56,223,12,181,169,158,247,23,231,88,205,170,119,216,182,208,173,74,63,125,177,106,113,122,212,174,18,118,221,244,229,42,65,189,248,7,98,141,71,208,194,18,123,108,223,67,189,198,238,229,162,235,247,38,119,197,170,189,234,249,223,227,108,53,59,217,84,135,61,46,255,58,204,164,221,155,32,81,8,206,74,194,204,180,143,134,129,139,150,129,22,220,149,96,10,58,65,194,105,85,175,151,205,43,236,225,8,250,179,106,182,169,70,109,164,0,76,74,224,130,100,218,101,82,32,61,48,175,74,100,38,5,25,115,14,174,20,95,109,247,170,46,157,225,18,70,163,55,194,194,70,84,214,8,230,11,146,6,97,2,243,57,115,6,158,171,172,173,87,57,171,65,248,106,253,141,96,215,183,139,230,195,244,176,123,189,174,235,55,237,193,242,188,191,248,237,228,217,201,97,247,230,99,131,237,241,104,108,86,160,238,240,116,74,163,247,6,14,106,92,98,211,207,54,37,10,145,115,118,76,231,96,153,78,138,108,7,71,119,38,235,96,121,78,154,231,45,9,92,135,120,182,177,74,115,43,18,197,41,120,61,200,69,230,109,33,185,162,149,116,9,52,8,185,61,125,118,58,249,125,242,199,228,235,93,186,101,129,235,20,162,83,133,89,23,19,237,137,66,22,178,181,204,38,169,131,78,38,34,47,131,133,233,184,223,147,217,55,88,249,33,47,62,236,88,94,116,231,53,92,188,255,202,141,123,209,34,244,52,49,105,240,227,36,173,154,30,82,63,125,77,150,175,227,184,143,5,214,117,191,155,156,52,227,228,173,16,60,164,98,240,232,252,14,37,183,125,218,204,47,97,155,87,179,249,231,112,187,250,191,12,231,93,224,238,179,54,175,246,230,213,241,106,221,166,65,163,162,135,253,91,193,24,141,140,75,238,61,238,224,162,145,134,98,115,53,178,15,61,236,22,238,134,87,121,81,22,152,15,155,227,29,83,163,22,126,117,177,127,249,217,93,151,190,125,143,216,43,104,224,3,182,67,96,111,124,191,246,242,29,133,113,167,56,231,168,64,32,50,238,208,83,190,88,201,162,131,192,50,71,43,124,228,188,196,60,74,191,197,130,45,54,9,31,233,216,91,236,198,104,15,85,237,202,175,33,84,219,106,187,221,187,93,235,172,201,38,123,242,69,41,99,152,230,142,74,21,248,72,217,31,165,138,148,240,74,193,131,181,46,199,34,185,196,196,146,214,68,128,35,2,98,42,154,145,82,19,133,183,74,114,241,223,215,186,31,67,183,1,91,164,205,158,161,75,131,123,228,99,240,209,49,37,48,3,12,27,23,248,64,247,67,112,127,6,194,131,37,44,234,75,201,39,8,127,117,8,165,213,168,49,43,198,141,161,252,116,220,80,23,145,156,41,58,135,20,27,172,141,158,63,8,161,73,54,129,224,200,132,240,156,114,91,32,81,108,56,51,6,156,44,37,208,161,67,255,172,16,74,239,157,142,64,111,84,4,21,24,77,171,163,74,150,41,159,56,207,78,121,94,212,35,33,252,51,165,213,186,233,159,48,252,95,48,140,50,24,238,68,97,14,9,62,141,132,161,207,2,88,16,33,22,229,20,37,174,124,8,67,105,178,75,2,34,19,25,41,233,13,23,140,26,150,100,212,141,56,14,137,159,45,126,19,134,84,228,35,71,79,133,192,112,32,135,168,149,129,26,92,19,42,91,149,32,235,47,244,66,79,7,81,207,233,180,239,232,19,130,196,130,103,17,44,48,169,85,10,6,148,226,60,254,172,24,134,168,99,150,212,216,131,83,130,190,105,184,99,192,105,203,66,146,66,21,18,81,218,61,18,195,163,179,85,131,79,16,254,178,189,240,116,251,9,231,63,10,70,218,15,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c9d9c923-3eb2-47cf-b2d5-b699ef55d643"),
				ContainerUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
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
				UId = new Guid("e6b6a1df-8229-45f9-bc5d-b75e6ddcd7be"),
				ContainerUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
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

		protected virtual void InitializeAddDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("50baaec3-b4b2-4696-8e6e-0a52599c84ce"),
				ContainerUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
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
				Value = @"004a9121-21f8-4a1e-8918-45c0f756ea41",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95bbe5fe-f292-4542-8914-7e0d64c9dd0b"),
				ContainerUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a7fa4bd-042f-431c-bd8d-a294932edf78"),
				ContainerUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
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
				UId = new Guid("4314f4b3-ed6a-4fd8-be55-31d309df8a90"),
				ContainerUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("362a0f68-4c27-4983-b9fe-775a0850402c"),
				ContainerUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,77,111,219,70,16,253,43,2,147,163,86,216,239,15,93,237,30,4,36,169,81,167,185,88,62,204,238,206,198,2,40,210,32,169,6,174,160,255,222,33,37,215,114,218,58,65,129,34,41,90,30,200,229,174,222,155,217,157,247,56,218,87,175,135,135,123,172,150,213,123,236,58,232,219,50,44,46,218,14,23,87,93,155,176,239,23,111,218,4,245,230,87,136,53,94,65,7,91,28,176,251,0,245,14,251,55,155,126,152,207,158,195,170,121,245,250,151,105,181,90,222,236,171,213,128,219,159,87,153,216,181,49,60,21,155,89,145,224,152,6,141,44,198,232,88,241,10,61,106,40,145,27,2,167,182,222,109,155,183,56,192,21,12,119,213,114,95,77,108,68,144,138,148,86,27,207,146,72,156,233,204,19,131,130,134,105,97,173,46,50,27,199,177,58,204,171,62,221,225,22,166,160,79,96,206,53,4,33,5,147,162,120,138,46,144,249,32,104,100,18,47,206,88,4,45,70,240,233,247,79,192,155,87,55,171,254,199,79,13,118,215,19,239,178,64,221,227,237,130,102,63,155,248,161,198,45,54,195,114,47,149,116,210,42,206,20,154,204,180,211,138,121,229,21,27,147,244,144,68,212,206,29,8,240,251,105,46,247,41,228,144,130,84,4,137,146,32,169,176,72,59,98,209,134,128,197,152,108,181,58,220,190,186,29,83,204,155,254,190,134,135,15,127,204,244,29,126,154,165,182,25,32,13,139,113,220,97,106,187,60,91,229,35,240,254,89,245,206,161,251,245,81,4,235,106,185,254,43,25,156,158,199,77,63,23,194,231,26,88,87,243,117,117,221,238,186,52,50,170,241,229,177,38,83,4,126,186,216,159,220,30,175,35,199,4,123,11,13,124,196,238,29,69,156,224,211,210,37,12,48,5,127,79,121,63,18,71,25,12,119,162,48,135,16,152,70,43,153,207,2,88,16,33,22,229,148,44,69,78,232,159,176,96,135,77,194,231,137,9,27,81,89,35,152,47,72,101,16,38,16,62,115,6,158,171,172,173,87,57,171,9,63,69,126,74,230,81,174,52,211,236,234,122,10,208,79,251,31,245,127,74,252,180,114,121,86,190,51,134,54,111,202,6,243,170,249,59,71,117,168,14,135,249,185,217,162,82,28,209,208,30,146,37,135,184,32,88,204,163,34,19,7,155,13,29,133,121,217,108,66,22,145,157,2,166,85,34,2,32,170,16,179,37,125,114,76,80,178,42,81,255,19,102,187,126,232,175,113,24,54,205,199,126,113,137,5,118,245,112,113,84,244,69,187,221,238,154,77,130,97,211,54,99,209,191,228,6,162,162,243,152,245,71,186,197,137,134,12,114,198,51,107,239,167,199,40,254,89,124,152,229,99,200,255,253,242,117,126,201,94,219,20,117,97,69,120,250,210,217,64,133,86,165,48,12,86,20,146,8,120,247,239,240,139,49,162,80,35,10,44,234,64,31,106,141,227,40,11,38,12,181,25,135,62,113,103,95,244,11,151,37,1,26,106,103,80,200,52,72,103,18,148,117,44,26,175,132,3,139,18,211,183,108,78,103,189,70,210,246,32,105,206,140,118,106,108,79,158,1,72,203,208,185,24,44,40,67,69,253,114,175,185,186,107,27,252,175,248,36,231,168,168,42,200,56,105,129,254,122,144,79,162,35,199,100,142,86,248,200,121,137,249,37,159,124,117,98,223,161,79,110,15,191,1,77,176,106,194,34,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eec63597-7c61-4178-ab9d-589c0450ab30"),
				ContainerUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
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
				UId = new Guid("1d98f2b5-ae9c-40d8-8d24-d2241734947e"),
				ContainerUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
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

		protected virtual void InitializeAddDataUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("040ed64a-eb19-4f89-925d-c9522c5d6854"),
				ContainerUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
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
				Value = @"004a9121-21f8-4a1e-8918-45c0f756ea41",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cda6b132-0e59-45bb-988a-dd98d098385b"),
				ContainerUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("611a2e2a-44ad-46d6-a803-86b905065d78"),
				ContainerUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
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
				UId = new Guid("a85205de-fa99-4c50-85d5-7011ef3b4d0e"),
				ContainerUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ac5bb6e7-6eff-457f-b790-d236a0edda50"),
				ContainerUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,77,143,219,54,16,253,43,134,146,163,103,193,239,15,95,179,61,44,144,180,139,58,205,101,189,135,33,57,204,26,144,165,133,36,183,112,13,255,247,82,178,221,245,166,237,38,40,80,36,69,203,131,62,72,189,55,35,206,123,195,125,245,122,216,61,82,181,168,222,83,215,97,223,230,225,234,77,219,209,213,109,215,70,234,251,171,183,109,196,122,253,43,134,154,110,177,195,13,13,212,125,192,122,75,253,219,117,63,204,103,207,97,213,188,122,253,243,180,90,45,238,246,213,205,64,155,159,110,82,97,247,210,26,37,147,5,101,24,3,133,218,67,240,170,92,56,211,58,38,140,150,197,2,142,109,189,221,52,239,104,192,91,28,30,170,197,190,154,216,10,65,204,66,24,165,29,68,30,11,65,98,17,48,147,6,197,141,81,89,36,109,25,85,135,121,213,199,7,218,224,20,244,9,204,152,66,207,5,7,193,179,43,209,57,129,243,188,60,233,200,178,213,134,80,241,17,124,250,254,9,120,247,234,238,166,255,225,151,134,186,229,196,187,200,88,247,116,127,85,102,63,153,248,174,166,13,53,195,98,79,204,203,40,75,4,195,121,44,137,170,12,158,12,3,174,68,54,148,116,16,25,15,5,240,251,110,46,246,92,100,242,78,114,96,158,5,80,193,49,240,210,17,160,137,130,43,143,194,123,121,184,127,117,63,166,152,214,253,99,141,187,15,127,204,116,73,216,197,135,89,110,187,89,220,246,67,187,161,174,212,164,25,48,14,71,232,227,179,250,93,130,247,171,163,12,86,213,98,245,87,66,56,221,143,191,253,92,10,159,170,96,85,205,87,213,178,221,118,113,100,148,227,203,185,42,83,4,118,26,240,39,151,243,56,114,76,176,119,216,224,71,234,190,47,17,39,248,180,116,141,3,78,193,223,151,188,207,196,65,120,205,44,207,96,9,61,40,50,2,92,226,8,158,251,144,165,149,34,103,49,161,127,164,76,29,53,145,158,39,198,77,32,105,52,7,151,73,20,105,21,149,186,148,24,160,99,50,41,227,100,74,114,194,79,145,159,146,57,11,182,204,52,219,186,158,2,244,211,255,143,14,56,37,126,90,185,190,40,224,5,67,155,214,121,77,233,166,249,59,91,117,168,14,135,249,165,221,148,55,142,123,227,33,10,99,64,73,116,16,152,42,2,11,58,233,100,109,100,78,191,104,183,34,73,158,172,196,130,141,122,244,171,0,31,146,1,73,140,34,230,36,115,80,255,132,221,150,187,126,73,195,176,110,62,246,87,215,148,113,91,15,39,13,191,105,55,155,109,179,142,56,172,219,102,44,250,103,253,176,235,203,126,204,250,35,221,217,10,179,120,201,51,107,31,167,219,40,254,89,216,205,210,49,228,255,126,249,50,191,36,167,76,12,165,195,101,238,82,105,237,190,20,90,230,12,228,13,207,69,34,232,236,191,196,47,214,250,72,69,162,50,226,216,180,25,2,70,227,192,145,210,66,51,94,12,64,47,250,133,137,28,145,180,133,140,185,152,134,198,174,47,141,133,160,75,95,183,104,72,80,252,154,199,211,197,105,35,148,34,140,138,129,86,86,130,178,202,1,162,48,64,214,6,111,80,234,82,212,207,159,54,183,15,109,67,255,21,159,164,20,100,169,10,1,179,84,202,146,138,79,130,45,142,73,140,12,119,129,177,28,210,75,62,249,226,196,190,65,159,220,31,126,3,25,173,225,11,36,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("415de17c-c12f-4817-8781-82b8431e8c3d"),
				ContainerUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
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
				UId = new Guid("f6ad6984-cbfd-40df-ab31-955875bf4183"),
				ContainerUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
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

		protected virtual void InitializeAutoGeneratedPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("369adb53-be77-4d6a-9958-3b4c83ca70fe"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				Value = @"Creating new contact",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("6e13b431-433e-4be7-8eee-468eed2a7d09"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5408038c-ac80-4220-b5cc-f215a44ba230"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				Value = @"Specify contact data",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("206826a5-918d-4250-8a64-287b1bde9a2b"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var buttonsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b9a46d74-6ecd-4ff8-8131-73d06aa4f4bd"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""aa2b00e5-ba27-432d-9421-d457baffb853"",""isEnabled"":true,""performValidation"":true,""caption"":""Next"",""name"":""Next"",""style"":""green"",""generateSignal"":""""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(buttonsParameter);
			var elementsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e2f306b-000b-4710-81f9-7b949ea2ad54"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""634061c5-a984-4d9b-86f0-af4327ca4a12"",""controlEditType"":""1"",""caption"":""Name"",""name"":""ContactName"",""isMultiline"":false,""isRequired"":false,""dataSource"":null,""controlDataValueType"":""10"",""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""9b4bd2f4-9731-4207-a062-9c213f0dc347"",""controlEditType"":""1"",""caption"":""Phone"",""name"":""Phone"",""isMultiline"":false,""isRequired"":false,""dataSource"":null,""controlDataValueType"":""10"",""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""28874bae-8f14-4476-b3c6-38c00d7380f3"",""controlEditType"":""SelectionField"",""caption"":""Account"",""name"":""Account"",""isRequired"":false,""dataSource"":""25d7c1ab-1de0-4501-b402-02e0e5a72d6e"",""dataFilter"":"""",""controlDataValueType"":""10"",""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""5a6f26d8-e7c2-41e2-98b7-31edaab7a990"",""controlEditType"":""1"",""caption"":""Email"",""name"":""Email"",""isMultiline"":false,""isRequired"":false,""dataSource"":null,""controlDataValueType"":""10"",""dateTimeFormat"":""7""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(elementsParameter);
			var extendedClientModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("830320f1-bd81-4cea-9f95-a80eadbd7767"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(extendedClientModuleParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6098bc34-95ad-496c-a3b2-81e95b073100"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("300e12bc-e3f7-49b2-8167-6ffb30b989af"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("0f482d41-ab86-41fc-b865-2e19e647b9aa"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#SysVariable.CurrentUserContact#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8c0b7c0a-66fd-4a5b-9457-bf3729096fef"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ecbfdeeb-28bb-4777-abb9-4dc8ec14f22e"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				Value = @"Once the data is filled in, click the ""Next"" button",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var isRunningParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("76840c62-b319-4288-b212-45c7398a6f01"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("a71bc511-48c7-481f-bf67-abfc8fe1ecf1"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("e2f7cc7a-e9e8-41c0-8622-1222fc2baaeb"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("04213c48-2177-4168-a157-ed8f1b44436a"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("577d7986-8527-48fd-9803-6ed6fb3abbf7"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("56906487-3485-4f0f-bb51-4220cfd0a52a"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("f0026ce5-0c15-4888-a598-0484658c8c1c"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("7d78594c-7fb5-4461-a72c-adf71150a96d"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("979fdb4d-5095-4eec-b5c2-5b80a61d9bd8"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("b459e3f6-c6a6-4d17-bc0f-a3ff63a86859"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("a2e2f953-128f-4f1e-87ce-25278dd30af9"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("dfa84ae7-dabb-4013-910a-64a5b3afb027"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
				UId = new Guid("063ab895-6977-46dd-8e75-db8954ae433d"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
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
			var contactNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("634061c5-a984-4d9b-86f0-af4327ca4a12"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ContactName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			contactNameParameter.SourceValue = new ProcessSchemaParameterValue(contactNameParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e093c31e-611c-4d4f-9e60-142f6ed5b2fa}].[Parameter:{aba17913-301c-4b8a-8b12-d315eba94a55}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(contactNameParameter);
			var phoneParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9b4bd2f4-9731-4207-a062-9c213f0dc347"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Phone",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			phoneParameter.SourceValue = new ProcessSchemaParameterValue(phoneParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e093c31e-611c-4d4f-9e60-142f6ed5b2fa}].[Parameter:{f0c052d1-ca27-43fa-bd30-40cbc6d55b3d}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(phoneParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("28874bae-8f14-4476-b3c6-38c00d7380f3"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{50fc9fed-3694-412a-846f-9e7f49617296}].[Parameter:{5efb285c-200d-4e01-90d9-5acd97f421c3}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var emailParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5a6f26d8-e7c2-41e2-98b7-31edaab7a990"),
				ContainerUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Email",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			emailParameter.SourceValue = new ProcessSchemaParameterValue(emailParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e093c31e-611c-4d4f-9e60-142f6ed5b2fa}].[Parameter:{fc1e2817-ed80-4462-81b7-66965f9c76df}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(emailParameter);
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b1517598-2489-44aa-aaa6-5640f2853121"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,203,110,219,48,16,252,149,64,231,48,16,41,90,22,125,43,82,183,200,165,9,96,35,151,42,135,21,185,180,137,234,5,146,74,235,26,254,247,82,146,237,56,133,139,184,189,180,213,137,26,204,14,103,95,220,70,178,4,231,62,65,133,209,44,90,162,181,224,26,237,111,62,152,210,163,253,104,155,174,141,174,35,135,214,64,105,190,163,26,241,185,50,254,61,120,8,33,219,252,69,33,143,102,249,121,141,60,186,206,35,227,177,114,129,19,66,68,33,0,18,154,18,205,117,76,120,146,73,82,208,88,19,170,20,149,114,170,88,38,179,145,249,43,241,219,166,106,193,226,120,199,32,175,135,227,114,211,246,84,26,0,57,80,140,107,234,61,152,244,38,220,188,134,162,68,21,254,189,237,48,64,222,154,42,100,131,75,83,225,3,216,112,87,175,211,244,80,32,105,40,93,207,42,81,251,249,183,214,162,115,166,169,223,50,87,118,85,125,202,14,2,120,252,221,219,137,7,143,61,243,1,252,122,144,184,11,182,118,131,203,119,171,149,197,21,120,243,124,106,226,11,110,6,222,101,245,11,1,42,116,233,17,202,14,79,238,124,157,201,45,180,126,76,104,188,62,16,172,89,173,47,206,245,88,177,183,210,101,1,108,15,228,11,53,207,230,192,210,0,62,247,192,168,114,56,230,209,231,59,119,255,181,70,187,144,107,172,96,172,218,211,77,64,127,2,230,37,86,88,251,217,22,99,145,200,132,34,73,41,149,132,43,174,137,192,52,38,148,51,157,162,154,20,76,195,46,4,28,13,205,182,148,105,20,89,66,73,44,226,130,240,34,139,137,72,50,36,144,74,70,185,0,38,68,178,123,26,141,27,215,150,176,121,60,250,91,32,88,185,190,210,141,189,146,157,243,77,133,54,204,74,237,65,250,33,160,175,127,160,77,10,173,146,84,21,68,74,129,132,115,150,17,193,39,156,160,206,132,18,168,41,3,25,230,164,255,250,118,54,43,35,161,188,111,209,194,190,147,241,249,65,127,181,33,125,17,109,211,248,177,52,199,38,156,218,57,76,27,159,34,106,73,5,161,146,135,105,19,211,148,100,42,142,9,43,48,6,150,226,52,97,60,248,9,15,69,223,170,69,211,89,185,95,76,55,190,16,127,180,249,127,97,159,127,103,69,207,46,201,37,67,255,223,142,243,191,52,157,187,104,247,3,158,39,111,237,187,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6afebec2-bcc5-4267-b4d1-642bc77d9b47"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("27a93232-ccc8-48ad-9eff-1ad1ea4b60eb"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("60e46248-0ebb-4ee8-a1bc-4ee2f5b4a0b1"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dd28bfbd-e627-4d61-a3fd-91ebd0891488"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1b16fad7-4ecc-4715-be57-b6aa7d76d4b9"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4ae849fb-aa93-4b31-98f6-6818622659e0"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("cdf7b7b2-89b5-4196-a299-d432ec544639"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3c555a9a-084f-46b0-97da-7805b5965ddc"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("628c1898-b678-4647-b7e5-8624e2a20a4b"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("05f3c3a8-49ec-4ef1-923a-b82935dad796"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("bc3bc9a9-a676-4a08-b8d4-3eca60a51ec1"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("712197a2-16fc-411c-a0b8-ad059a020d40"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fb660a18-6ba8-4292-86c1-b614908a8d63"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("2519b17d-ed42-4ff6-bb3c-7ebb21fcc7d5"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c735c402-0b9e-406d-a4e0-cbb66e7839f7"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,51,77,54,75,78,52,52,72,213,53,52,180,48,208,53,73,54,76,213,181,72,52,53,208,53,53,77,52,55,74,75,179,76,74,73,49,1,0,215,224,64,129,36,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("75c9c0ab-0f22-4b23-9b18-aa90e393a626"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a27c7b13-58a7-4ad4-b15a-448de74c1d65"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9ddc6a96-8c0e-469b-9ff3-8706adc2e1ae"),
				ContainerUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fbab1060-c0b1-4f93-867c-7266001affb5"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,203,110,219,48,16,252,21,67,231,208,160,168,183,111,65,234,22,185,52,1,108,228,82,231,176,36,87,54,81,73,20,72,42,173,107,248,223,75,73,182,235,20,46,226,246,210,86,39,114,48,59,154,125,113,23,136,10,172,253,8,53,6,179,96,137,198,128,213,165,155,190,87,149,67,243,193,232,174,13,110,2,139,70,65,165,190,161,28,241,185,84,238,29,56,240,33,187,213,15,133,85,48,91,93,214,88,5,55,171,64,57,172,173,231,248,16,140,153,44,242,172,36,72,227,144,196,121,68,9,80,38,73,36,162,136,138,132,165,44,140,70,230,175,196,239,116,221,130,193,241,31,131,124,57,28,151,219,182,167,134,30,16,3,69,89,221,28,192,168,55,97,231,13,240,10,165,191,59,211,161,135,156,81,181,207,6,151,170,198,71,48,254,95,189,142,238,33,79,42,161,178,61,171,194,210,205,191,182,6,173,85,186,121,203,92,213,213,205,57,219,11,224,233,122,176,67,7,143,61,243,17,220,102,144,24,181,246,131,207,219,245,218,224,26,156,122,57,183,241,25,183,3,243,186,10,250,0,233,251,244,4,85,135,103,149,121,157,203,29,180,110,76,233,104,192,83,140,90,111,174,206,247,84,181,183,82,102,30,108,143,228,43,53,47,102,193,82,15,190,244,192,168,114,60,174,130,79,247,246,225,75,131,102,33,54,88,195,88,183,231,169,71,127,2,230,21,214,216,184,217,14,105,225,139,22,34,73,195,80,144,88,198,37,41,48,165,36,140,89,153,162,76,56,43,97,239,3,78,134,102,187,82,48,150,21,180,32,97,158,49,18,115,136,72,17,251,43,75,41,38,140,97,194,165,15,25,141,43,219,86,176,125,58,249,91,32,24,177,153,148,218,76,68,103,157,174,209,76,111,133,208,93,227,38,205,177,250,247,114,224,66,156,229,144,241,132,20,73,81,146,184,8,67,82,72,201,137,144,60,229,17,203,139,136,129,31,151,254,235,187,170,215,74,64,245,208,162,129,67,67,233,229,137,127,181,42,125,37,141,214,110,172,207,169,19,7,79,131,157,227,208,229,144,243,80,114,73,120,8,222,143,128,254,36,50,194,49,134,146,198,185,224,84,120,63,254,197,232,251,181,208,157,17,135,13,181,227,83,241,71,79,192,95,88,236,223,219,213,139,187,114,205,236,255,183,83,253,47,205,231,62,216,127,7,106,42,244,29,198,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("924fc06b-cb19-4f36-a6b8-cf093ff6c691"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7c0f02aa-82a3-47c5-8208-d996fae17d12"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("29bb462d-f9de-41f8-a19f-9a0a6f6c1b19"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2a4fe780-6a8d-4f63-b87b-5a80ff81bce7"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2195e600-5141-46fb-b239-3e0e4a1d1c65"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("023d4b5d-869b-486b-b744-24dbdc8bba9c"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("5efb285c-200d-4e01-90d9-5acd97f421c3"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("638e86b2-8f33-425f-aaa1-33fb04bf366d"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9eb12b6f-8e40-4fd0-b12e-2a3ef8ae2d3e"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("92940858-d280-4045-be1c-4dfc9c628640"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("392ebbf9-7eb2-467c-8926-251c70dea54e"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d723185e-d81c-4915-b608-d9baa29f3ad5"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("02fb567d-b208-4a18-85e9-4dfe4ee10e81"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("a33a0ba3-e017-4a51-892a-31febdf691b4"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e85fcae9-ec25-43af-bcd0-47641523512d"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9526e9cd-5214-40c4-a8ce-b2cd44a5bc1e"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ebd64a2d-e832-4590-8e4e-d17eb77d95d2"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8306da24-e061-4f3c-bcaa-f7f14df26208"),
				ContainerUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaUserTask preconfiguredpageusertask1 = CreatePreconfiguredPageUserTask1UserTask();
			FlowElements.Add(preconfiguredpageusertask1);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaFormulaTask formulatask2 = CreateFormulaTask2FormulaTask();
			FlowElements.Add(formulatask2);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaFormulaTask formulatask3 = CreateFormulaTask3FormulaTask();
			FlowElements.Add(formulatask3);
			ProcessSchemaInclusiveGateway inclusivegateway1 = CreateInclusiveGateway1InclusiveGateway();
			FlowElements.Add(inclusivegateway1);
			ProcessSchemaFormulaTask formulatask4 = CreateFormulaTask4FormulaTask();
			FlowElements.Add(formulatask4);
			ProcessSchemaUserTask adddatausertask2 = CreateAddDataUserTask2UserTask();
			FlowElements.Add(adddatausertask2);
			ProcessSchemaUserTask adddatausertask3 = CreateAddDataUserTask3UserTask();
			FlowElements.Add(adddatausertask3);
			ProcessSchemaUserTask autogeneratedpageusertask1 = CreateAutoGeneratedPageUserTask1UserTask();
			FlowElements.Add(autogeneratedpageusertask1);
			ProcessSchemaFormulaTask formulatask5 = CreateFormulaTask5FormulaTask();
			FlowElements.Add(formulatask5);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaFormulaTask formulatask6 = CreateFormulaTask6FormulaTask();
			FlowElements.Add(formulatask6);
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("0374f97e-d765-44ea-9d30-3be8ae09bd89"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{deefb406-4a64-4513-9f48-328ba955695b}]#] != Guid.Empty || [#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{839ed405-68e4-4e40-bd9c-062c634c4a20}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(482, 191),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(1401, 100),
				SequenceFlowStartPointPosition = new Point(162, 198),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dc06821c-b4ef-4f7c-b1bc-fbc4a11a2b5f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b116d3eb-3bf3-46c8-bc63-fc3476d31a3b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(162, 11));
			schemaFlow.PolylinePointPositions.Add(new Point(1401, 11));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow4",
				UId = new Guid("5ad4e173-04b5-4649-837c-d22c26b2674f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(327, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("5f92367a-0974-4ebf-a32c-d55c04e48d6a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(645, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("d688193f-9dd6-4af8-b948-cde51b4c7904"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(645, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b226b71-a1a2-47fa-8ea6-40796f17cd9b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("507376ca-fdf6-4662-bea7-7d15e3985c6a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("8fa9aea6-0bc2-46bc-9e80-649f429aa652"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(144, 202),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c4b6fd4c-b7fd-4417-a51e-f9c612519b8d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dc06821c-b4ef-4f7c-b1bc-fbc4a11a2b5f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow7",
				UId = new Guid("25b9392e-704d-42ed-9624-4190b568f6ae"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(277, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dc06821c-b4ef-4f7c-b1bc-fbc4a11a2b5f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("5deb83d5-d535-4f74-8eca-57097cadb848"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(645, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("507376ca-fdf6-4662-bea7-7d15e3985c6a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("20522a18-5cd9-4713-b542-1cf712c3a705"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("88059cf2-ff4e-44cb-920a-375a1aa1430f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(645, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9b226b71-a1a2-47fa-8ea6-40796f17cd9b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("c7e99f46-3a51-422f-be23-20e5e667edab"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e093c31e-611c-4d4f-9e60-142f6ed5b2fa}].[Parameter:{17a010c9-438a-4621-b397-adfd1bbf6b2c}]#] == ""ContactSelected""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(420, 282),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("592683c9-85dd-45a8-9431-d7587c13f066"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("6736c170-cc87-479a-89bc-5a92e7dab75c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(582, 330),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("592683c9-85dd-45a8-9431-d7587c13f066"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("32c6ad93-f028-469b-bdf3-bc06033eb7ea"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(730, 376),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("721dfa93-c964-4ad1-bcc6-54248fddf0c9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(903, 333),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("20522a18-5cd9-4713-b542-1cf712c3a705"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("96344677-1e02-4847-98db-c6b2b8f63ade"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow10",
				UId = new Guid("7058391b-7d68-4265-a336-03f8c9347da3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(327, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("9eb9df03-804c-4569-a976-83ca81356295"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(730, 376),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("44d743fe-0bf2-4e53-9cff-ffff18b3c9e0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b116d3eb-3bf3-46c8-bc63-fc3476d31a3b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("d393627d-e9ed-4c4a-81df-a49ea5c1fcdd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(730, 376),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("44d743fe-0bf2-4e53-9cff-ffff18b3c9e0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("67a31b03-747e-4e89-b588-dcf4ad465052"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(368, 114),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("20233c44-02c5-4422-af20-c4c3cefd67f0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(1282, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("af1f1aea-ca64-4bd3-97e9-55794de511f9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b116d3eb-3bf3-46c8-bc63-fc3476d31a3b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow15",
				UId = new Guid("6fb5aaeb-187b-4bb5-8135-48362af4d054"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(1246, 120),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("96344677-1e02-4847-98db-c6b2b8f63ade"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b116d3eb-3bf3-46c8-bc63-fc3476d31a3b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("b4a7612b-41dd-4dee-9113-e84a5423a170"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e093c31e-611c-4d4f-9e60-142f6ed5b2fa}].[Parameter:{17a010c9-438a-4621-b397-adfd1bbf6b2c}]#] == ""AccountSelected""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				CurveCenterPosition = new Point(1190, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("96344677-1e02-4847-98db-c6b2b8f63ade"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("af1f1aea-ca64-4bd3-97e9-55794de511f9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a2eacbc5-b538-476c-8c03-51467abed9ec"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a2eacbc5-b538-476c-8c03-51467abed9ec"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("c4b6fd4c-b7fd-4417-a51e-f9c612519b8d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Start1",
				Position = new Point(43, 212),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("b116d3eb-3bf3-46c8-bc63-fc3476d31a3b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"Terminate1",
				Position = new Point(1387, 100),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreatePreconfiguredPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"PreconfiguredPageUserTask1",
				Position = new Point(232, 198),
				SchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializePreconfiguredPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("592683c9-85dd-45a8-9431-d7587c13f066"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"FormulaTask1",
				Position = new Point(449, 198),
				ResultParameterMetaPath = @"deefb406-4a64-4513-9f48-328ba955695b",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,203,161,14,131,48,16,6,224,135,65,223,210,107,187,166,87,63,49,197,146,73,130,56,202,223,76,80,68,33,153,32,188,251,208,179,95,242,13,221,240,220,250,239,138,246,206,31,84,77,69,151,13,227,237,210,63,120,44,168,88,247,116,192,136,203,142,65,129,57,147,159,125,33,65,48,196,222,150,128,249,62,217,162,231,21,94,218,180,98,71,75,7,219,2,137,142,201,136,153,200,79,209,144,184,8,210,144,45,123,81,43,226,206,177,27,127,142,172,191,195,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("20522a18-5cd9-4713-b542-1cf712c3a705"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"FormulaTask2",
				Position = new Point(953, 86),
				ResultParameterMetaPath = @"839ed405-68e4-4e40-bd9c-062c634c4a20",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,139,187,14,194,48,12,0,63,166,179,81,66,76,94,59,3,19,72,140,85,6,39,118,196,208,116,72,43,49,84,253,119,50,179,157,78,119,243,52,63,182,231,119,149,254,46,31,105,20,43,45,155,164,203,176,127,226,190,72,147,117,143,71,205,90,51,179,3,228,96,1,139,81,64,193,13,186,49,6,171,184,160,226,115,12,47,234,212,100,151,30,143,171,247,14,51,9,248,170,17,16,71,157,77,177,96,124,81,138,157,241,170,154,51,77,233,7,66,56,231,37,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AddDataUserTask1",
				Position = new Point(449, 86),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask3FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("9b226b71-a1a2-47fa-8ea6-40796f17cd9b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"FormulaTask3",
				Position = new Point(708, 86),
				ResultParameterMetaPath = @"deefb406-4a64-4513-9f48-328ba955695b",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,203,59,14,194,48,12,0,208,195,116,54,2,219,249,238,12,76,32,49,86,25,242,113,196,208,116,72,43,49,84,189,59,153,89,159,244,230,105,126,108,207,239,42,253,157,63,210,162,175,113,217,36,92,134,254,193,125,145,38,235,238,15,36,52,168,233,10,36,170,0,27,38,176,100,9,184,98,177,49,223,18,27,115,142,240,138,61,54,217,165,251,35,187,226,178,67,26,37,225,40,185,66,194,162,32,105,231,164,42,85,52,211,25,166,240,3,91,238,63,192,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaInclusiveGateway CreateInclusiveGateway1InclusiveGateway() {
			ProcessSchemaInclusiveGateway gateway = new ProcessSchemaInclusiveGateway(this) {
				UId = new Guid("dc06821c-b4ef-4f7c-b1bc-fbc4a11a2b5f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("ffa4a06a-5747-49d4-96c2-c32a727a3b14"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"InclusiveGateway1",
				Position = new Point(134, 198),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask4FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("507376ca-fdf6-4662-bea7-7d15e3985c6a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"FormulaTask4",
				Position = new Point(834, 86),
				ResultParameterMetaPath = @"fe1f7c0c-c8cf-47c3-bbfe-363c45186118",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,43,41,42,77,5,0,141,76,252,253,4,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AddDataUserTask2",
				Position = new Point(575, 86),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AddDataUserTask3",
				Position = new Point(575, 198),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAutoGeneratedPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"AutoGeneratedPageUserTask1",
				Position = new Point(344, 86),
				SchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAutoGeneratedPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask5FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("44d743fe-0bf2-4e53-9cff-ffff18b3c9e0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"FormulaTask5",
				Position = new Point(834, 198),
				ResultParameterMetaPath = @"839ed405-68e4-4e40-bd9c-062c634c4a20",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,205,187,10,194,48,20,128,225,135,113,62,146,251,165,171,116,112,82,112,44,29,78,146,19,20,154,8,109,68,164,244,221,173,171,235,15,31,255,112,24,206,203,229,93,105,190,197,59,21,236,50,78,11,141,199,189,254,133,126,162,66,181,117,43,70,169,165,205,26,152,13,25,148,37,130,224,131,3,135,129,71,76,86,120,105,182,29,92,113,198,66,141,230,110,141,41,219,96,131,0,231,131,6,197,189,1,20,222,67,82,82,80,212,74,25,233,127,164,175,237,209,62,167,231,244,42,181,91,117,52,17,57,35,224,220,49,80,145,211,254,208,12,180,70,43,114,246,33,37,181,141,135,241,11,190,245,233,142,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0cce7e8b-c985-435f-8005-0c0ee9b342c6"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ReadDataUserTask1",
				Position = new Point(708, 198),
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
				UId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ReadDataUserTask2",
				Position = new Point(232, 86),
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
				UId = new Guid("96344677-1e02-4847-98db-c6b2b8f63ade"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"ExclusiveGateway1",
				Position = new Point(1072, 86),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask6FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("af1f1aea-ca64-4bd3-97e9-55794de511f9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cd2e686-06a5-468f-ac9d-3a0b8a0b4a1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7bf1cfd3-8c1f-4948-b39c-36d3910b43c5"),
				CreatedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536"),
				Name = @"FormulaTask6",
				Position = new Point(1177, 23),
				ResultParameterMetaPath = @"22ed503f-1097-4afd-9c1c-e7591592243a",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,43,41,42,77,5,0,141,76,252,253,4,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ContactIdentificationV2(userConnection);
		}

		public override object Clone() {
			return new ContactIdentificationV2Schema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f58fbc05-8179-4074-9636-19e734769536"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactIdentificationV2

	/// <exclude/>
	public class ContactIdentificationV2 : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: PreconfiguredPageUserTask1FlowElement

		/// <exclude/>
		public class PreconfiguredPageUserTask1FlowElement : PreconfiguredPageUserTask
		{

			#region Constructors: Public

			public PreconfiguredPageUserTask1FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "PreconfiguredPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("e093c31e-611c-4d4f-9e60-142f6ed5b2fa");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
				_isCaseIncluded = () => (bool)((process.IsCaseIncluded));
				_createContactButtonCaption = () => new LocalizableString((process.CreateContactButtonCaption));
				_searchDetailSelectButtonCaption = () => new LocalizableString((process.SearchDetailSelectButtonCaption));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("f58fbc0581794074963619e734769536",
						 "BaseElements.PreconfiguredPageUserTask1.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private Guid _clientUnitSchemaUId = new Guid("4f01d1ce-b5c7-4d19-b354-b5bef74d6e95");
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

			internal Func<Guid> _ownerId;
			public override Guid OwnerId {
				get {
					return (_ownerId ?? (_ownerId = () => Guid.Empty)).Invoke();
				}
				set {
					_ownerId = () => { return value; };
				}
			}

			public virtual Guid ContactId {
				get;
				set;
			}

			public virtual Guid AccountId {
				get;
				set;
			}

			public virtual string ContactName {
				get;
				set;
			}

			public virtual string PhoneNumber {
				get;
				set;
			}

			public virtual string Email {
				get;
				set;
			}

			public virtual bool IsContactSelected {
				get;
				set;
			}

			public virtual string ResultCode {
				get;
				set;
			}

			internal Func<bool> _isCaseIncluded;
			public virtual bool IsCaseIncluded {
				get {
					return (_isCaseIncluded ?? (_isCaseIncluded = () => false)).Invoke();
				}
				set {
					_isCaseIncluded = () => { return value; };
				}
			}

			public virtual string AccountName {
				get;
				set;
			}

			internal Func<string> _createContactButtonCaption;
			public virtual string CreateContactButtonCaption {
				get {
					return (_createContactButtonCaption ?? (_createContactButtonCaption = () => null)).Invoke();
				}
				set {
					_createContactButtonCaption = () => { return value; };
				}
			}

			internal Func<string> _searchDetailSelectButtonCaption;
			public virtual string SearchDetailSelectButtonCaption {
				get {
					return (_searchDetailSelectButtonCaption ?? (_searchDetailSelectButtonCaption = () => null)).Invoke();
				}
				set {
					_searchDetailSelectButtonCaption = () => { return value; };
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

			public AddDataUserTask1FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("23272630-3e5d-4743-8383-4f2d8ac1b477");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Name = () => new LocalizableString(string.IsNullOrEmpty((process.AutoGeneratedPageUserTask1.ContactName) ) ? (process.DefaultContactName).Value : (process.AutoGeneratedPageUserTask1.ContactName) );
				_recordDefValues_Email = () => new LocalizableString((process.AutoGeneratedPageUserTask1.Email));
				_recordDefValues_Account = () => (Guid)((process.AutoGeneratedPageUserTask1.Account));
				_recordDefValues_Phone = () => new LocalizableString((process.AutoGeneratedPageUserTask1.Phone));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Name", () => _recordDefValues_Name.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Email", () => _recordDefValues_Email.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Account", () => _recordDefValues_Account.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Phone", () => _recordDefValues_Phone.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Name;
			internal Func<string> _recordDefValues_Email;
			internal Func<Guid> _recordDefValues_Account;
			internal Func<string> _recordDefValues_Phone;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,151,75,111,219,56,16,128,255,138,161,246,176,11,132,6,223,15,95,22,139,38,135,0,125,4,77,183,151,56,135,33,57,108,12,200,114,32,201,91,100,13,255,247,142,148,56,47,108,211,54,93,116,81,52,58,216,18,201,121,104,56,223,12,181,169,158,247,23,231,88,205,170,119,216,182,208,173,74,63,125,177,106,113,122,212,174,18,118,221,244,229,42,65,189,248,7,98,141,71,208,194,18,123,108,223,67,189,198,238,229,162,235,247,38,119,197,170,189,234,249,223,227,108,53,59,217,84,135,61,46,255,58,204,164,221,155,32,81,8,206,74,194,204,180,143,134,129,139,150,129,22,220,149,96,10,58,65,194,105,85,175,151,205,43,236,225,8,250,179,106,182,169,70,109,164,0,76,74,224,130,100,218,101,82,32,61,48,175,74,100,38,5,25,115,14,174,20,95,109,247,170,46,157,225,18,70,163,55,194,194,70,84,214,8,230,11,146,6,97,2,243,57,115,6,158,171,172,173,87,57,171,65,248,106,253,141,96,215,183,139,230,195,244,176,123,189,174,235,55,237,193,242,188,191,248,237,228,217,201,97,247,230,99,131,237,241,104,108,86,160,238,240,116,74,163,247,6,14,106,92,98,211,207,54,37,10,145,115,118,76,231,96,153,78,138,108,7,71,119,38,235,96,121,78,154,231,45,9,92,135,120,182,177,74,115,43,18,197,41,120,61,200,69,230,109,33,185,162,149,116,9,52,8,185,61,125,118,58,249,125,242,199,228,235,93,186,101,129,235,20,162,83,133,89,23,19,237,137,66,22,178,181,204,38,169,131,78,38,34,47,131,133,233,184,223,147,217,55,88,249,33,47,62,236,88,94,116,231,53,92,188,255,202,141,123,209,34,244,52,49,105,240,227,36,173,154,30,82,63,125,77,150,175,227,184,143,5,214,117,191,155,156,52,227,228,173,16,60,164,98,240,232,252,14,37,183,125,218,204,47,97,155,87,179,249,231,112,187,250,191,12,231,93,224,238,179,54,175,246,230,213,241,106,221,166,65,163,162,135,253,91,193,24,141,140,75,238,61,238,224,162,145,134,98,115,53,178,15,61,236,22,238,134,87,121,81,22,152,15,155,227,29,83,163,22,126,117,177,127,249,217,93,151,190,125,143,216,43,104,224,3,182,67,96,111,124,191,246,242,29,133,113,167,56,231,168,64,32,50,238,208,83,190,88,201,162,131,192,50,71,43,124,228,188,196,60,74,191,197,130,45,54,9,31,233,216,91,236,198,104,15,85,237,202,175,33,84,219,106,187,221,187,93,235,172,201,38,123,242,69,41,99,152,230,142,74,21,248,72,217,31,165,138,148,240,74,193,131,181,46,199,34,185,196,196,146,214,68,128,35,2,98,42,154,145,82,19,133,183,74,114,241,223,215,186,31,67,183,1,91,164,205,158,161,75,131,123,228,99,240,209,49,37,48,3,12,27,23,248,64,247,67,112,127,6,194,131,37,44,234,75,201,39,8,127,117,8,165,213,168,49,43,198,141,161,252,116,220,80,23,145,156,41,58,135,20,27,172,141,158,63,8,161,73,54,129,224,200,132,240,156,114,91,32,81,108,56,51,6,156,44,37,208,161,67,255,172,16,74,239,157,142,64,111,84,4,21,24,77,171,163,74,150,41,159,56,207,78,121,94,212,35,33,252,51,165,213,186,233,159,48,252,95,48,140,50,24,238,68,97,14,9,62,141,132,161,207,2,88,16,33,22,229,20,37,174,124,8,67,105,178,75,2,34,19,25,41,233,13,23,140,26,150,100,212,141,56,14,137,159,45,126,19,134,84,228,35,71,79,133,192,112,32,135,168,149,129,26,92,19,42,91,149,32,235,47,244,66,79,7,81,207,233,180,239,232,19,130,196,130,103,17,44,48,169,85,10,6,148,226,60,254,172,24,134,168,99,150,212,216,131,83,130,190,105,184,99,192,105,203,66,146,66,21,18,81,218,61,18,195,163,179,85,131,79,16,254,178,189,240,116,251,9,231,63,10,70,218,15,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "f58fbc0581794074963619e734769536",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("e16ad5af-f2b8-4128-ab85-84768b536fe3");
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

		#region Class: AddDataUserTask2FlowElement

		/// <exclude/>
		public class AddDataUserTask2FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask2FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("317b5386-d177-44ef-9b11-32ee8526b126");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Contact = () => (Guid)((process.AddDataUserTask1.RecordId));
				_recordDefValues_CommunicationType = () => (Guid)(((Guid)SysSettings.GetValue(UserConnection, "DefaultContactCommunicationType")));
				_recordDefValues_Number = () => new LocalizableString((process.PhoneNumber));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_CommunicationType", () => _recordDefValues_CommunicationType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Number", () => _recordDefValues_Number.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_CommunicationType;
			internal Func<string> _recordDefValues_Number;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,77,111,219,70,16,253,43,2,147,163,86,216,239,15,93,237,30,4,36,169,81,167,185,88,62,204,238,206,198,2,40,210,32,169,6,174,160,255,222,33,37,215,114,218,58,65,129,34,41,90,30,200,229,174,222,155,217,157,247,56,218,87,175,135,135,123,172,150,213,123,236,58,232,219,50,44,46,218,14,23,87,93,155,176,239,23,111,218,4,245,230,87,136,53,94,65,7,91,28,176,251,0,245,14,251,55,155,126,152,207,158,195,170,121,245,250,151,105,181,90,222,236,171,213,128,219,159,87,153,216,181,49,60,21,155,89,145,224,152,6,141,44,198,232,88,241,10,61,106,40,145,27,2,167,182,222,109,155,183,56,192,21,12,119,213,114,95,77,108,68,144,138,148,86,27,207,146,72,156,233,204,19,131,130,134,105,97,173,46,50,27,199,177,58,204,171,62,221,225,22,166,160,79,96,206,53,4,33,5,147,162,120,138,46,144,249,32,104,100,18,47,206,88,4,45,70,240,233,247,79,192,155,87,55,171,254,199,79,13,118,215,19,239,178,64,221,227,237,130,102,63,155,248,161,198,45,54,195,114,47,149,116,210,42,206,20,154,204,180,211,138,121,229,21,27,147,244,144,68,212,206,29,8,240,251,105,46,247,41,228,144,130,84,4,137,146,32,169,176,72,59,98,209,134,128,197,152,108,181,58,220,190,186,29,83,204,155,254,190,134,135,15,127,204,244,29,126,154,165,182,25,32,13,139,113,220,97,106,187,60,91,229,35,240,254,89,245,206,161,251,245,81,4,235,106,185,254,43,25,156,158,199,77,63,23,194,231,26,88,87,243,117,117,221,238,186,52,50,170,241,229,177,38,83,4,126,186,216,159,220,30,175,35,199,4,123,11,13,124,196,238,29,69,156,224,211,210,37,12,48,5,127,79,121,63,18,71,25,12,119,162,48,135,16,152,70,43,153,207,2,88,16,33,22,229,148,44,69,78,232,159,176,96,135,77,194,231,137,9,27,81,89,35,152,47,72,101,16,38,16,62,115,6,158,171,172,173,87,57,171,9,63,69,126,74,230,81,174,52,211,236,234,122,10,208,79,251,31,245,127,74,252,180,114,121,86,190,51,134,54,111,202,6,243,170,249,59,71,117,168,14,135,249,185,217,162,82,28,209,208,30,146,37,135,184,32,88,204,163,34,19,7,155,13,29,133,121,217,108,66,22,145,157,2,166,85,34,2,32,170,16,179,37,125,114,76,80,178,42,81,255,19,102,187,126,232,175,113,24,54,205,199,126,113,137,5,118,245,112,113,84,244,69,187,221,238,154,77,130,97,211,54,99,209,191,228,6,162,162,243,152,245,71,186,197,137,134,12,114,198,51,107,239,167,199,40,254,89,124,152,229,99,200,255,253,242,117,126,201,94,219,20,117,97,69,120,250,210,217,64,133,86,165,48,12,86,20,146,8,120,247,239,240,139,49,162,80,35,10,44,234,64,31,106,141,227,40,11,38,12,181,25,135,62,113,103,95,244,11,151,37,1,26,106,103,80,200,52,72,103,18,148,117,44,26,175,132,3,139,18,211,183,108,78,103,189,70,210,246,32,105,206,140,118,106,108,79,158,1,72,203,208,185,24,44,40,67,69,253,114,175,185,186,107,27,252,175,248,36,231,168,168,42,200,56,105,129,254,122,144,79,162,35,199,100,142,86,248,200,121,137,249,37,159,124,117,98,223,161,79,110,15,191,1,77,176,106,194,34,10,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "f58fbc0581794074963619e734769536",
							"BaseElements.AddDataUserTask2.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("e16ad5af-f2b8-4128-ab85-84768b536fe3");
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

		#region Class: AddDataUserTask3FlowElement

		/// <exclude/>
		public class AddDataUserTask3FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask3FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("6865b758-30cc-4e9e-891c-65dc7ef5244b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Contact = () => (Guid)((process.PreconfiguredPageUserTask1.ContactId));
				_recordDefValues_CommunicationType = () => (Guid)(((Guid)SysSettings.GetValue(UserConnection, "DefaultContactCommunicationType")));
				_recordDefValues_Number = () => new LocalizableString((process.PhoneNumber));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_CommunicationType", () => _recordDefValues_CommunicationType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Number", () => _recordDefValues_Number.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_CommunicationType;
			internal Func<string> _recordDefValues_Number;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,77,143,219,54,16,253,43,134,146,163,103,193,239,15,95,179,61,44,144,180,139,58,205,101,189,135,33,57,204,26,144,165,133,36,183,112,13,255,247,82,178,221,245,166,237,38,40,80,36,69,203,131,62,72,189,55,35,206,123,195,125,245,122,216,61,82,181,168,222,83,215,97,223,230,225,234,77,219,209,213,109,215,70,234,251,171,183,109,196,122,253,43,134,154,110,177,195,13,13,212,125,192,122,75,253,219,117,63,204,103,207,97,213,188,122,253,243,180,90,45,238,246,213,205,64,155,159,110,82,97,247,210,26,37,147,5,101,24,3,133,218,67,240,170,92,56,211,58,38,140,150,197,2,142,109,189,221,52,239,104,192,91,28,30,170,197,190,154,216,10,65,204,66,24,165,29,68,30,11,65,98,17,48,147,6,197,141,81,89,36,109,25,85,135,121,213,199,7,218,224,20,244,9,204,152,66,207,5,7,193,179,43,209,57,129,243,188,60,233,200,178,213,134,80,241,17,124,250,254,9,120,247,234,238,166,255,225,151,134,186,229,196,187,200,88,247,116,127,85,102,63,153,248,174,166,13,53,195,98,79,204,203,40,75,4,195,121,44,137,170,12,158,12,3,174,68,54,148,116,16,25,15,5,240,251,110,46,246,92,100,242,78,114,96,158,5,80,193,49,240,210,17,160,137,130,43,143,194,123,121,184,127,117,63,166,152,214,253,99,141,187,15,127,204,116,73,216,197,135,89,110,187,89,220,246,67,187,161,174,212,164,25,48,14,71,232,227,179,250,93,130,247,171,163,12,86,213,98,245,87,66,56,221,143,191,253,92,10,159,170,96,85,205,87,213,178,221,118,113,100,148,227,203,185,42,83,4,118,26,240,39,151,243,56,114,76,176,119,216,224,71,234,190,47,17,39,248,180,116,141,3,78,193,223,151,188,207,196,65,120,205,44,207,96,9,61,40,50,2,92,226,8,158,251,144,165,149,34,103,49,161,127,164,76,29,53,145,158,39,198,77,32,105,52,7,151,73,20,105,21,149,186,148,24,160,99,50,41,227,100,74,114,194,79,145,159,146,57,11,182,204,52,219,186,158,2,244,211,255,143,14,56,37,126,90,185,190,40,224,5,67,155,214,121,77,233,166,249,59,91,117,168,14,135,249,165,221,148,55,142,123,227,33,10,99,64,73,116,16,152,42,2,11,58,233,100,109,100,78,191,104,183,34,73,158,172,196,130,141,122,244,171,0,31,146,1,73,140,34,230,36,115,80,255,132,221,150,187,126,73,195,176,110,62,246,87,215,148,113,91,15,39,13,191,105,55,155,109,179,142,56,172,219,102,44,250,103,253,176,235,203,126,204,250,35,221,217,10,179,120,201,51,107,31,167,219,40,254,89,216,205,210,49,228,255,126,249,50,191,36,167,76,12,165,195,101,238,82,105,237,190,20,90,230,12,228,13,207,69,34,232,236,191,196,47,214,250,72,69,162,50,226,216,180,25,2,70,227,192,145,210,66,51,94,12,64,47,250,133,137,28,145,180,133,140,185,152,134,198,174,47,141,133,160,75,95,183,104,72,80,252,154,199,211,197,105,35,148,34,140,138,129,86,86,130,178,202,1,162,48,64,214,6,111,80,234,82,212,207,159,54,183,15,109,67,255,21,159,164,20,100,169,10,1,179,84,202,146,138,79,130,45,142,73,140,12,119,129,177,28,210,75,62,249,226,196,190,65,159,220,31,126,3,25,173,225,11,36,10,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "f58fbc0581794074963619e734769536",
							"BaseElements.AddDataUserTask3.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("e16ad5af-f2b8-4128-ab85-84768b536fe3");
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

		#region Class: AutoGeneratedPageUserTask1FlowElement

		/// <exclude/>
		public class AutoGeneratedPageUserTask1FlowElement : AutoGeneratedPageUserTask
		{

			#region Constructors: Public

			public AutoGeneratedPageUserTask1FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AutoGeneratedPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("fb11ddd7-4d96-4c30-a976-45d4960dc40d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
				_contactName = () => new LocalizableString((process.PreconfiguredPageUserTask1.ContactName));
				_phone = () => new LocalizableString((process.PreconfiguredPageUserTask1.PhoneNumber));
				_account = () => (Guid)(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_email = () => new LocalizableString((process.PreconfiguredPageUserTask1.Email));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("f58fbc0581794074963619e734769536",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("f58fbc0581794074963619e734769536",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private LocalizableString _buttons;
			public override LocalizableString Buttons {
				get {
					return _buttons ?? (_buttons = GetLocalizableString("f58fbc0581794074963619e734769536",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Buttons.Value"));
				}
				set {
					_buttons = value;
				}
			}

			private LocalizableString _elements;
			public override LocalizableString Elements {
				get {
					return _elements ?? (_elements = GetLocalizableString("f58fbc0581794074963619e734769536",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.Elements.Value"));
				}
				set {
					_elements = value;
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

			private LocalizableString _informationOnStep;
			public override LocalizableString InformationOnStep {
				get {
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("f58fbc0581794074963619e734769536",
						 "BaseElements.AutoGeneratedPageUserTask1.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			internal Func<string> _contactName;
			public virtual string ContactName {
				get {
					return (_contactName ?? (_contactName = () => null)).Invoke();
				}
				set {
					_contactName = () => { return value; };
				}
			}

			internal Func<string> _phone;
			public virtual string Phone {
				get {
					return (_phone ?? (_phone = () => null)).Invoke();
				}
				set {
					_phone = () => { return value; };
				}
			}

			internal Func<Guid> _account;
			public virtual Guid Account {
				get {
					return (_account ?? (_account = () => Guid.Empty)).Invoke();
				}
				set {
					_account = () => { return value; };
				}
			}

			internal Func<string> _email;
			public virtual string Email {
				get {
					return (_email ?? (_email = () => null)).Invoke();
				}
				set {
					_email = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("ac3537f5-07bf-47ee-b9b8-8ab1cad72936");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,203,110,219,48,16,252,149,64,231,48,16,41,90,22,125,43,82,183,200,165,9,96,35,151,42,135,21,185,180,137,234,5,146,74,235,26,254,247,82,146,237,56,133,139,184,189,180,213,137,26,204,14,103,95,220,70,178,4,231,62,65,133,209,44,90,162,181,224,26,237,111,62,152,210,163,253,104,155,174,141,174,35,135,214,64,105,190,163,26,241,185,50,254,61,120,8,33,219,252,69,33,143,102,249,121,141,60,186,206,35,227,177,114,129,19,66,68,33,0,18,154,18,205,117,76,120,146,73,82,208,88,19,170,20,149,114,170,88,38,179,145,249,43,241,219,166,106,193,226,120,199,32,175,135,227,114,211,246,84,26,0,57,80,140,107,234,61,152,244,38,220,188,134,162,68,21,254,189,237,48,64,222,154,42,100,131,75,83,225,3,216,112,87,175,211,244,80,32,105,40,93,207,42,81,251,249,183,214,162,115,166,169,223,50,87,118,85,125,202,14,2,120,252,221,219,137,7,143,61,243,1,252,122,144,184,11,182,118,131,203,119,171,149,197,21,120,243,124,106,226,11,110,6,222,101,245,11,1,42,116,233,17,202,14,79,238,124,157,201,45,180,126,76,104,188,62,16,172,89,173,47,206,245,88,177,183,210,101,1,108,15,228,11,53,207,230,192,210,0,62,247,192,168,114,56,230,209,231,59,119,255,181,70,187,144,107,172,96,172,218,211,77,64,127,2,230,37,86,88,251,217,22,99,145,200,132,34,73,41,149,132,43,174,137,192,52,38,148,51,157,162,154,20,76,195,46,4,28,13,205,182,148,105,20,89,66,73,44,226,130,240,34,139,137,72,50,36,144,74,70,185,0,38,68,178,123,26,141,27,215,150,176,121,60,250,91,32,88,185,190,210,141,189,146,157,243,77,133,54,204,74,237,65,250,33,160,175,127,160,77,10,173,146,84,21,68,74,129,132,115,150,17,193,39,156,160,206,132,18,168,41,3,25,230,164,255,250,118,54,43,35,161,188,111,209,194,190,147,241,249,65,127,181,33,125,17,109,211,248,177,52,199,38,156,218,57,76,27,159,34,106,73,5,161,146,135,105,19,211,148,100,42,142,9,43,48,6,150,226,52,97,60,248,9,15,69,223,170,69,211,89,185,95,76,55,190,16,127,180,249,127,97,159,127,103,69,207,46,201,37,67,255,223,142,243,191,52,157,187,104,247,3,158,39,111,237,187,6,0,0 })));
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
								new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,51,77,54,75,78,52,52,72,213,53,52,180,48,208,53,73,54,76,213,181,72,52,53,208,53,53,77,52,55,74,75,179,76,74,73,49,1,0,215,224,64,129,36,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
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

			public ReadDataUserTask2FlowElement(UserConnection userConnection, ContactIdentificationV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("50fc9fed-3694-412a-846f-9e7f49617296");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,203,110,219,48,16,252,21,67,231,208,160,168,183,111,65,234,22,185,52,1,108,228,82,231,176,36,87,54,81,73,20,72,42,173,107,248,223,75,73,182,235,20,46,226,246,210,86,39,114,48,59,154,125,113,23,136,10,172,253,8,53,6,179,96,137,198,128,213,165,155,190,87,149,67,243,193,232,174,13,110,2,139,70,65,165,190,161,28,241,185,84,238,29,56,240,33,187,213,15,133,85,48,91,93,214,88,5,55,171,64,57,172,173,231,248,16,140,153,44,242,172,36,72,227,144,196,121,68,9,80,38,73,36,162,136,138,132,165,44,140,70,230,175,196,239,116,221,130,193,241,31,131,124,57,28,151,219,182,167,134,30,16,3,69,89,221,28,192,168,55,97,231,13,240,10,165,191,59,211,161,135,156,81,181,207,6,151,170,198,71,48,254,95,189,142,238,33,79,42,161,178,61,171,194,210,205,191,182,6,173,85,186,121,203,92,213,213,205,57,219,11,224,233,122,176,67,7,143,61,243,17,220,102,144,24,181,246,131,207,219,245,218,224,26,156,122,57,183,241,25,183,3,243,186,10,250,0,233,251,244,4,85,135,103,149,121,157,203,29,180,110,76,233,104,192,83,140,90,111,174,206,247,84,181,183,82,102,30,108,143,228,43,53,47,102,193,82,15,190,244,192,168,114,60,174,130,79,247,246,225,75,131,102,33,54,88,195,88,183,231,169,71,127,2,230,21,214,216,184,217,14,105,225,139,22,34,73,195,80,144,88,198,37,41,48,165,36,140,89,153,162,76,56,43,97,239,3,78,134,102,187,82,48,150,21,180,32,97,158,49,18,115,136,72,17,251,43,75,41,38,140,97,194,165,15,25,141,43,219,86,176,125,58,249,91,32,24,177,153,148,218,76,68,103,157,174,209,76,111,133,208,93,227,38,205,177,250,247,114,224,66,156,229,144,241,132,20,73,81,146,184,8,67,82,72,201,137,144,60,229,17,203,139,136,129,31,151,254,235,187,170,215,74,64,245,208,162,129,67,67,233,229,137,127,181,42,125,37,141,214,110,172,207,169,19,7,79,131,157,227,208,229,144,243,80,114,73,120,8,222,143,128,254,36,50,194,49,134,146,198,185,224,84,120,63,254,197,232,251,181,208,157,17,135,13,181,227,83,241,71,79,192,95,88,236,223,219,213,139,187,114,205,236,255,183,83,253,47,205,231,62,216,127,7,106,42,244,29,198,6,0,0 })));
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
								new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"));
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

		public ContactIdentificationV2(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactIdentificationV2";
			SchemaUId = new Guid("f58fbc05-8179-4074-9636-19e734769536");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f58fbc05-8179-4074-9636-19e734769536");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ContactIdentificationV2, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ContactIdentificationV2, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid ContactId {
			get;
			set;
		}

		public virtual Guid AccountId {
			get;
			set;
		}

		public virtual string PhoneNumber {
			get;
			set;
		}

		public virtual bool NewContact {
			get;
			set;
		}

		public virtual bool IsCaseIncluded {
			get;
			set;
		}

		public virtual bool AccountSelected {
			get;
			set;
		}

		public virtual string CreateContactButtonCaption {
			get;
			set;
		}

		public virtual string SearchDetailSelectButtonCaption {
			get;
			set;
		}

		private LocalizableString _defaultContactName;
		public virtual LocalizableString DefaultContactName {
			get {
				return _defaultContactName ?? (_defaultContactName = GetLocalizableString("f58fbc0581794074963619e734769536",
						 "Parameters.DefaultContactName.Value"));
			}
			set {
				_defaultContactName = value;
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
					SchemaElementUId = new Guid("c4b6fd4c-b7fd-4417-a51e-f9c612519b8d"),
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
					SchemaElementUId = new Guid("b116d3eb-3bf3-46c8-bc63-fc3476d31a3b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private PreconfiguredPageUserTask1FlowElement _preconfiguredPageUserTask1;
		public PreconfiguredPageUserTask1FlowElement PreconfiguredPageUserTask1 {
			get {
				return _preconfiguredPageUserTask1 ?? (_preconfiguredPageUserTask1 = new PreconfiguredPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("592683c9-85dd-45a8-9431-d7587c13f066"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("20522a18-5cd9-4713-b542-1cf712c3a705"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask2Execute,
				});
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("9b226b71-a1a2-47fa-8ea6-40796f17cd9b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask3Execute,
				});
			}
		}

		private ProcessInclusiveGateway _inclusiveGateway1;
		public ProcessInclusiveGateway InclusiveGateway1 {
			get {
				return _inclusiveGateway1 ?? (_inclusiveGateway1 = new ProcessInclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaInclusiveGateway",
					Name = "InclusiveGateway1",
					SchemaElementUId = new Guid("dc06821c-b4ef-4f7c-b1bc-fbc4a11a2b5f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.InclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
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
					SchemaElementUId = new Guid("507376ca-fdf6-4662-bea7-7d15e3985c6a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask4Execute,
				});
			}
		}

		private AddDataUserTask2FlowElement _addDataUserTask2;
		public AddDataUserTask2FlowElement AddDataUserTask2 {
			get {
				return _addDataUserTask2 ?? (_addDataUserTask2 = new AddDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddDataUserTask3FlowElement _addDataUserTask3;
		public AddDataUserTask3FlowElement AddDataUserTask3 {
			get {
				return _addDataUserTask3 ?? (_addDataUserTask3 = new AddDataUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AutoGeneratedPageUserTask1FlowElement _autoGeneratedPageUserTask1;
		public AutoGeneratedPageUserTask1FlowElement AutoGeneratedPageUserTask1 {
			get {
				return _autoGeneratedPageUserTask1 ?? (_autoGeneratedPageUserTask1 = new AutoGeneratedPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("44d743fe-0bf2-4e53-9cff-ffff18b3c9e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask5Execute,
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
					SchemaElementUId = new Guid("96344677-1e02-4847-98db-c6b2b8f63ade"),
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

		private ProcessScriptTask _formulaTask6;
		public ProcessScriptTask FormulaTask6 {
			get {
				return _formulaTask6 ?? (_formulaTask6 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask6",
					SchemaElementUId = new Guid("af1f1aea-ca64-4bd3-97e9-55794de511f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask6Execute,
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
					SchemaElementUId = new Guid("0374f97e-d765-44ea-9d30-3be8ae09bd89"),
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
					SchemaElementUId = new Guid("c7e99f46-3a51-422f-be23-20e5e667edab"),
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
					SchemaElementUId = new Guid("b4a7612b-41dd-4dee-9113-e84a5423a170"),
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
			FlowElements[PreconfiguredPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { PreconfiguredPageUserTask1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[FormulaTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask2 };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[FormulaTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask3 };
			FlowElements[InclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { InclusiveGateway1 };
			FlowElements[FormulaTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask4 };
			FlowElements[AddDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask2 };
			FlowElements[AddDataUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask3 };
			FlowElements[AutoGeneratedPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AutoGeneratedPageUserTask1 };
			FlowElements[FormulaTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask5 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[FormulaTask6.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask6 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InclusiveGateway1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "PreconfiguredPageUserTask1":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask3", e.Context.SenderName));
						break;
					case "FormulaTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask2", e.Context.SenderName));
						break;
					case "FormulaTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask4", e.Context.SenderName));
						break;
					case "InclusiveGateway1":
						bool isInclusiveGateway1ConditionsEvulated = false;
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							isInclusiveGateway1ConditionsEvulated = true;
						} 
						if (!isInclusiveGateway1ConditionsEvulated) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PreconfiguredPageUserTask1", e.Context.SenderName));
						} 
						break;
					case "FormulaTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask2", e.Context.SenderName));
						break;
					case "AddDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask3", e.Context.SenderName));
						break;
					case "AddDataUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "AutoGeneratedPageUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "FormulaTask5":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask5", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AutoGeneratedPageUserTask1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask6", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "FormulaTask6":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((ContactId) != Guid.Empty || (AccountId) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "InclusiveGateway1", "ConditionalFlow1", "(ContactId) != Guid.Empty || (AccountId) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((PreconfiguredPageUserTask1.ResultCode) == "ContactSelected");
			Log.InfoFormat(ConditionalExpressionLogMessage, "PreconfiguredPageUserTask1", "ConditionalFlow2", "(PreconfiguredPageUserTask1.ResultCode) == \"ContactSelected\"", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((PreconfiguredPageUserTask1.ResultCode) == "AccountSelected");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow3", "(PreconfiguredPageUserTask1.ResultCode) == \"AccountSelected\"", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("PreconfiguredPageUserTask1.ContactId")) {
				writer.WriteValue("PreconfiguredPageUserTask1.ContactId", PreconfiguredPageUserTask1.ContactId, Guid.Empty);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.AccountId")) {
				writer.WriteValue("PreconfiguredPageUserTask1.AccountId", PreconfiguredPageUserTask1.AccountId, Guid.Empty);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.ContactName")) {
				writer.WriteValue("PreconfiguredPageUserTask1.ContactName", PreconfiguredPageUserTask1.ContactName, null);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.PhoneNumber")) {
				writer.WriteValue("PreconfiguredPageUserTask1.PhoneNumber", PreconfiguredPageUserTask1.PhoneNumber, null);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.Email")) {
				writer.WriteValue("PreconfiguredPageUserTask1.Email", PreconfiguredPageUserTask1.Email, null);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.IsContactSelected")) {
				writer.WriteValue("PreconfiguredPageUserTask1.IsContactSelected", PreconfiguredPageUserTask1.IsContactSelected, false);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.ResultCode")) {
				writer.WriteValue("PreconfiguredPageUserTask1.ResultCode", PreconfiguredPageUserTask1.ResultCode, null);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.IsCaseIncluded")) {
				writer.WriteValue("PreconfiguredPageUserTask1.IsCaseIncluded", PreconfiguredPageUserTask1.IsCaseIncluded, false);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.AccountName")) {
				writer.WriteValue("PreconfiguredPageUserTask1.AccountName", PreconfiguredPageUserTask1.AccountName, null);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.CreateContactButtonCaption")) {
				writer.WriteValue("PreconfiguredPageUserTask1.CreateContactButtonCaption", PreconfiguredPageUserTask1.CreateContactButtonCaption, null);
			}
			if (!HasMapping("PreconfiguredPageUserTask1.SearchDetailSelectButtonCaption")) {
				writer.WriteValue("PreconfiguredPageUserTask1.SearchDetailSelectButtonCaption", PreconfiguredPageUserTask1.SearchDetailSelectButtonCaption, null);
			}
			if (!HasMapping("AutoGeneratedPageUserTask1.ContactName")) {
				writer.WriteValue("AutoGeneratedPageUserTask1.ContactName", AutoGeneratedPageUserTask1.ContactName, null);
			}
			if (!HasMapping("AutoGeneratedPageUserTask1.Phone")) {
				writer.WriteValue("AutoGeneratedPageUserTask1.Phone", AutoGeneratedPageUserTask1.Phone, null);
			}
			if (!HasMapping("AutoGeneratedPageUserTask1.Account")) {
				writer.WriteValue("AutoGeneratedPageUserTask1.Account", AutoGeneratedPageUserTask1.Account, Guid.Empty);
			}
			if (!HasMapping("AutoGeneratedPageUserTask1.Email")) {
				writer.WriteValue("AutoGeneratedPageUserTask1.Email", AutoGeneratedPageUserTask1.Email, null);
			}
			if (!HasMapping("ContactId")) {
				writer.WriteValue("ContactId", ContactId, Guid.Empty);
			}
			if (!HasMapping("AccountId")) {
				writer.WriteValue("AccountId", AccountId, Guid.Empty);
			}
			if (!HasMapping("PhoneNumber")) {
				writer.WriteValue("PhoneNumber", PhoneNumber, null);
			}
			if (!HasMapping("NewContact")) {
				writer.WriteValue("NewContact", NewContact, false);
			}
			if (!HasMapping("IsCaseIncluded")) {
				writer.WriteValue("IsCaseIncluded", IsCaseIncluded, false);
			}
			if (!HasMapping("AccountSelected")) {
				writer.WriteValue("AccountSelected", AccountSelected, false);
			}
			if (!HasMapping("CreateContactButtonCaption")) {
				writer.WriteValue("CreateContactButtonCaption", CreateContactButtonCaption, null);
			}
			if (!HasMapping("SearchDetailSelectButtonCaption")) {
				writer.WriteValue("SearchDetailSelectButtonCaption", SearchDetailSelectButtonCaption, null);
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
			MetaPathParameterValues.Add("deefb406-4a64-4513-9f48-328ba955695b", () => ContactId);
			MetaPathParameterValues.Add("839ed405-68e4-4e40-bd9c-062c634c4a20", () => AccountId);
			MetaPathParameterValues.Add("244eac40-5473-4748-aa26-e77b96a35846", () => PhoneNumber);
			MetaPathParameterValues.Add("fe1f7c0c-c8cf-47c3-bbfe-363c45186118", () => NewContact);
			MetaPathParameterValues.Add("e5e56c22-18ea-449c-b1be-62a59c96abd7", () => IsCaseIncluded);
			MetaPathParameterValues.Add("22ed503f-1097-4afd-9c1c-e7591592243a", () => AccountSelected);
			MetaPathParameterValues.Add("77a86efd-52da-41d3-b551-b2af78145723", () => CreateContactButtonCaption);
			MetaPathParameterValues.Add("ce1af657-ffbd-40aa-8ba8-92e5d0b88a47", () => SearchDetailSelectButtonCaption);
			MetaPathParameterValues.Add("04c9b73f-67bc-483e-9d66-6c2494c5be0f", () => DefaultContactName);
			MetaPathParameterValues.Add("69b15c71-905e-4fe2-b8c8-13247e6c2e08", () => PreconfiguredPageUserTask1.Title);
			MetaPathParameterValues.Add("7e141f0a-9d5c-457c-a67f-0a1d278e31bd", () => PreconfiguredPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("1b7e2a98-62c5-480f-87de-803a6fd6bd04", () => PreconfiguredPageUserTask1.ClientUnitSchemaUId);
			MetaPathParameterValues.Add("55b46c6d-9866-4800-b1a5-66f885cd2355", () => PreconfiguredPageUserTask1.EntityId);
			MetaPathParameterValues.Add("0ae7e716-e7cc-4a75-ae50-55d0030ffc0a", () => PreconfiguredPageUserTask1.EntryPointId);
			MetaPathParameterValues.Add("d602fd51-f1ec-46f8-a61c-e2a65578dafd", () => PreconfiguredPageUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("03340eb8-8dc3-4cfa-803e-9f3b3bc34101", () => PreconfiguredPageUserTask1.UseCardProcessModule);
			MetaPathParameterValues.Add("8c360d85-bf72-4c87-8c17-d3163c1c7d9d", () => PreconfiguredPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("972c2fff-1e7a-4897-88b5-1b6a3de96469", () => PreconfiguredPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("6943ab1a-dce8-4c57-bd3b-eb4715dcb1d5", () => PreconfiguredPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("23145d3b-45a3-4a9a-b019-f296e0cbcfb0", () => PreconfiguredPageUserTask1.IsRunning);
			MetaPathParameterValues.Add("4a5221ff-1dfa-4371-aa3b-b83fc6ef48f2", () => PreconfiguredPageUserTask1.Template);
			MetaPathParameterValues.Add("c003612c-32bf-4743-9ddc-9cd6eddfff56", () => PreconfiguredPageUserTask1.Module);
			MetaPathParameterValues.Add("993430b0-b3fc-4871-a50f-48baed943409", () => PreconfiguredPageUserTask1.PressedButtonCode);
			MetaPathParameterValues.Add("3f7bb4ba-649e-4dbc-9238-e0630e06179b", () => PreconfiguredPageUserTask1.Url);
			MetaPathParameterValues.Add("0089de74-c149-432d-b6bd-700caa13d660", () => PreconfiguredPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("46298d4b-f2db-45c6-9c57-cacc8316da59", () => PreconfiguredPageUserTask1.CreateActivity);
			MetaPathParameterValues.Add("54c71711-c4a4-4811-86f7-7bf7eb77df3c", () => PreconfiguredPageUserTask1.ActivityPriority);
			MetaPathParameterValues.Add("1354525d-6ec9-4419-9199-6312ac9d97d4", () => PreconfiguredPageUserTask1.StartIn);
			MetaPathParameterValues.Add("44744e62-de7d-4719-9d52-621e63480486", () => PreconfiguredPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("3f26e0e6-56b2-4176-866b-07504872eebd", () => PreconfiguredPageUserTask1.Duration);
			MetaPathParameterValues.Add("cfa83da4-dc81-4fcc-b946-d0189d57aebc", () => PreconfiguredPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("d1e162ce-f452-4a5e-ac2d-f2c213ce3422", () => PreconfiguredPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("0de510ec-b520-4f58-809c-bb7999f2a4b0", () => PreconfiguredPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("bf93f395-9044-4c42-912b-109b4e2a50b2", () => PreconfiguredPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("31ea7bf9-a7f7-4bae-9cf8-7bbf65717805", () => PreconfiguredPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("18a9f5f0-2c9c-4808-bf57-d409a0ffaa4f", () => PreconfiguredPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("12fe9831-090b-4b80-938e-a6c2149a2993", () => PreconfiguredPageUserTask1.ContactId);
			MetaPathParameterValues.Add("6f5535c1-cef2-4fab-aa8c-101f094e1360", () => PreconfiguredPageUserTask1.AccountId);
			MetaPathParameterValues.Add("aba17913-301c-4b8a-8b12-d315eba94a55", () => PreconfiguredPageUserTask1.ContactName);
			MetaPathParameterValues.Add("f0c052d1-ca27-43fa-bd30-40cbc6d55b3d", () => PreconfiguredPageUserTask1.PhoneNumber);
			MetaPathParameterValues.Add("fc1e2817-ed80-4462-81b7-66965f9c76df", () => PreconfiguredPageUserTask1.Email);
			MetaPathParameterValues.Add("154e18f3-415a-442d-a42b-a1ab3f228aa9", () => PreconfiguredPageUserTask1.IsContactSelected);
			MetaPathParameterValues.Add("17a010c9-438a-4621-b397-adfd1bbf6b2c", () => PreconfiguredPageUserTask1.ResultCode);
			MetaPathParameterValues.Add("f9936a9b-7364-4807-886d-c47923aa5526", () => PreconfiguredPageUserTask1.IsCaseIncluded);
			MetaPathParameterValues.Add("fc227909-1872-4ba3-9409-260e522e5bda", () => PreconfiguredPageUserTask1.AccountName);
			MetaPathParameterValues.Add("932357b5-6b5b-4d70-b80b-a52c2cd999a5", () => PreconfiguredPageUserTask1.CreateContactButtonCaption);
			MetaPathParameterValues.Add("36bf19ed-4a1b-46d1-8360-7b98a0a05451", () => PreconfiguredPageUserTask1.SearchDetailSelectButtonCaption);
			MetaPathParameterValues.Add("2cc3931e-cae7-49e3-8cf0-9ce37b4622d1", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("52f0c27a-aa7b-4b1a-81a6-d96439fb602b", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("e33fa283-1e3e-45ee-a4c9-cd8f02f2bd1f", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("3b08e0b0-95c8-4039-b074-cc84d0e02189", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("03c59888-3e70-4fc6-b8d8-8ca80b0c1a0f", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("c9d9c923-3eb2-47cf-b2d5-b699ef55d643", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("e6b6a1df-8229-45f9-bc5d-b75e6ddcd7be", () => AddDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("50baaec3-b4b2-4696-8e6e-0a52599c84ce", () => AddDataUserTask2.EntitySchemaId);
			MetaPathParameterValues.Add("95bbe5fe-f292-4542-8914-7e0d64c9dd0b", () => AddDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("0a7fa4bd-042f-431c-bd8d-a294932edf78", () => AddDataUserTask2.RecordAddMode);
			MetaPathParameterValues.Add("4314f4b3-ed6a-4fd8-be55-31d309df8a90", () => AddDataUserTask2.FilterEntitySchemaId);
			MetaPathParameterValues.Add("362a0f68-4c27-4983-b9fe-775a0850402c", () => AddDataUserTask2.RecordDefValues);
			MetaPathParameterValues.Add("eec63597-7c61-4178-ab9d-589c0450ab30", () => AddDataUserTask2.RecordId);
			MetaPathParameterValues.Add("1d98f2b5-ae9c-40d8-8d24-d2241734947e", () => AddDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("040ed64a-eb19-4f89-925d-c9522c5d6854", () => AddDataUserTask3.EntitySchemaId);
			MetaPathParameterValues.Add("cda6b132-0e59-45bb-988a-dd98d098385b", () => AddDataUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("611a2e2a-44ad-46d6-a803-86b905065d78", () => AddDataUserTask3.RecordAddMode);
			MetaPathParameterValues.Add("a85205de-fa99-4c50-85d5-7011ef3b4d0e", () => AddDataUserTask3.FilterEntitySchemaId);
			MetaPathParameterValues.Add("ac5bb6e7-6eff-457f-b790-d236a0edda50", () => AddDataUserTask3.RecordDefValues);
			MetaPathParameterValues.Add("415de17c-c12f-4817-8781-82b8431e8c3d", () => AddDataUserTask3.RecordId);
			MetaPathParameterValues.Add("f6ad6984-cbfd-40df-ab31-955875bf4183", () => AddDataUserTask3.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("369adb53-be77-4d6a-9958-3b4c83ca70fe", () => AutoGeneratedPageUserTask1.Title);
			MetaPathParameterValues.Add("6e13b431-433e-4be7-8eee-468eed2a7d09", () => AutoGeneratedPageUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("5408038c-ac80-4220-b5cc-f215a44ba230", () => AutoGeneratedPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("206826a5-918d-4250-8a64-287b1bde9a2b", () => AutoGeneratedPageUserTask1.EntityId);
			MetaPathParameterValues.Add("b9a46d74-6ecd-4ff8-8131-73d06aa4f4bd", () => AutoGeneratedPageUserTask1.Buttons);
			MetaPathParameterValues.Add("5e2f306b-000b-4710-81f9-7b949ea2ad54", () => AutoGeneratedPageUserTask1.Elements);
			MetaPathParameterValues.Add("830320f1-bd81-4cea-9f95-a80eadbd7767", () => AutoGeneratedPageUserTask1.ExtendedClientModule);
			MetaPathParameterValues.Add("6098bc34-95ad-496c-a3b2-81e95b073100", () => AutoGeneratedPageUserTask1.EntryPointId);
			MetaPathParameterValues.Add("300e12bc-e3f7-49b2-8167-6ffb30b989af", () => AutoGeneratedPageUserTask1.PressedButtonCode);
			MetaPathParameterValues.Add("0f482d41-ab86-41fc-b865-2e19e647b9aa", () => AutoGeneratedPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("8c0b7c0a-66fd-4a5b-9457-bf3729096fef", () => AutoGeneratedPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("ecbfdeeb-28bb-4777-abb9-4dc8ec14f22e", () => AutoGeneratedPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("76840c62-b319-4288-b212-45c7398a6f01", () => AutoGeneratedPageUserTask1.IsRunning);
			MetaPathParameterValues.Add("a71bc511-48c7-481f-bf67-abfc8fe1ecf1", () => AutoGeneratedPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("e2f7cc7a-e9e8-41c0-8622-1222fc2baaeb", () => AutoGeneratedPageUserTask1.CreateActivity);
			MetaPathParameterValues.Add("04213c48-2177-4168-a157-ed8f1b44436a", () => AutoGeneratedPageUserTask1.ActivityPriority);
			MetaPathParameterValues.Add("577d7986-8527-48fd-9803-6ed6fb3abbf7", () => AutoGeneratedPageUserTask1.StartIn);
			MetaPathParameterValues.Add("56906487-3485-4f0f-bb51-4220cfd0a52a", () => AutoGeneratedPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("f0026ce5-0c15-4888-a598-0484658c8c1c", () => AutoGeneratedPageUserTask1.Duration);
			MetaPathParameterValues.Add("7d78594c-7fb5-4461-a72c-adf71150a96d", () => AutoGeneratedPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("979fdb4d-5095-4eec-b5c2-5b80a61d9bd8", () => AutoGeneratedPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("b459e3f6-c6a6-4d17-bc0f-a3ff63a86859", () => AutoGeneratedPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("a2e2f953-128f-4f1e-87ce-25278dd30af9", () => AutoGeneratedPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("dfa84ae7-dabb-4013-910a-64a5b3afb027", () => AutoGeneratedPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("063ab895-6977-46dd-8e75-db8954ae433d", () => AutoGeneratedPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("634061c5-a984-4d9b-86f0-af4327ca4a12", () => AutoGeneratedPageUserTask1.ContactName);
			MetaPathParameterValues.Add("9b4bd2f4-9731-4207-a062-9c213f0dc347", () => AutoGeneratedPageUserTask1.Phone);
			MetaPathParameterValues.Add("28874bae-8f14-4476-b3c6-38c00d7380f3", () => AutoGeneratedPageUserTask1.Account);
			MetaPathParameterValues.Add("5a6f26d8-e7c2-41e2-98b7-31edaab7a990", () => AutoGeneratedPageUserTask1.Email);
			MetaPathParameterValues.Add("b1517598-2489-44aa-aaa6-5640f2853121", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("6afebec2-bcc5-4267-b4d1-642bc77d9b47", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("27a93232-ccc8-48ad-9eff-1ad1ea4b60eb", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("60e46248-0ebb-4ee8-a1bc-4ee2f5b4a0b1", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("dd28bfbd-e627-4d61-a3fd-91ebd0891488", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("1b16fad7-4ecc-4715-be57-b6aa7d76d4b9", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("4ae849fb-aa93-4b31-98f6-6818622659e0", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("cdf7b7b2-89b5-4196-a299-d432ec544639", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("3c555a9a-084f-46b0-97da-7805b5965ddc", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("628c1898-b678-4647-b7e5-8624e2a20a4b", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("05f3c3a8-49ec-4ef1-923a-b82935dad796", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("bc3bc9a9-a676-4a08-b8d4-3eca60a51ec1", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("712197a2-16fc-411c-a0b8-ad059a020d40", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("fb660a18-6ba8-4292-86c1-b614908a8d63", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("2519b17d-ed42-4ff6-bb3c-7ebb21fcc7d5", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("c735c402-0b9e-406d-a4e0-cbb66e7839f7", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("75c9c0ab-0f22-4b23-9b18-aa90e393a626", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("a27c7b13-58a7-4ad4-b15a-448de74c1d65", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("9ddc6a96-8c0e-469b-9ff3-8706adc2e1ae", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("fbab1060-c0b1-4f93-867c-7266001affb5", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("924fc06b-cb19-4f36-a6b8-cf093ff6c691", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("7c0f02aa-82a3-47c5-8208-d996fae17d12", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("29bb462d-f9de-41f8-a19f-9a0a6f6c1b19", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("2a4fe780-6a8d-4f63-b87b-5a80ff81bce7", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("2195e600-5141-46fb-b239-3e0e4a1d1c65", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("023d4b5d-869b-486b-b744-24dbdc8bba9c", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("5efb285c-200d-4e01-90d9-5acd97f421c3", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("638e86b2-8f33-425f-aaa1-33fb04bf366d", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("9eb12b6f-8e40-4fd0-b12e-2a3ef8ae2d3e", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("92940858-d280-4045-be1c-4dfc9c628640", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("392ebbf9-7eb2-467c-8926-251c70dea54e", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("d723185e-d81c-4915-b608-d9baa29f3ad5", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("02fb567d-b208-4a18-85e9-4dfe4ee10e81", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("a33a0ba3-e017-4a51-892a-31febdf691b4", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("e85fcae9-ec25-43af-bcd0-47641523512d", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("9526e9cd-5214-40c4-a8ce-b2cd44a5bc1e", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("ebd64a2d-e832-4590-8e4e-d17eb77d95d2", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("8306da24-e061-4f3c-bcaa-f7f14df26208", () => ReadDataUserTask2.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "PreconfiguredPageUserTask1.ContactId":
					PreconfiguredPageUserTask1.ContactId = reader.GetValue<System.Guid>();
				break;
				case "PreconfiguredPageUserTask1.AccountId":
					PreconfiguredPageUserTask1.AccountId = reader.GetValue<System.Guid>();
				break;
				case "PreconfiguredPageUserTask1.ContactName":
					PreconfiguredPageUserTask1.ContactName = reader.GetValue<System.String>();
				break;
				case "PreconfiguredPageUserTask1.PhoneNumber":
					PreconfiguredPageUserTask1.PhoneNumber = reader.GetValue<System.String>();
				break;
				case "PreconfiguredPageUserTask1.Email":
					PreconfiguredPageUserTask1.Email = reader.GetValue<System.String>();
				break;
				case "PreconfiguredPageUserTask1.IsContactSelected":
					PreconfiguredPageUserTask1.IsContactSelected = reader.GetValue<System.Boolean>();
				break;
				case "PreconfiguredPageUserTask1.ResultCode":
					PreconfiguredPageUserTask1.ResultCode = reader.GetValue<System.String>();
				break;
				case "PreconfiguredPageUserTask1.IsCaseIncluded":
					PreconfiguredPageUserTask1.IsCaseIncluded = reader.GetValue<System.Boolean>();
				break;
				case "PreconfiguredPageUserTask1.AccountName":
					PreconfiguredPageUserTask1.AccountName = reader.GetValue<System.String>();
				break;
				case "PreconfiguredPageUserTask1.CreateContactButtonCaption":
					PreconfiguredPageUserTask1.CreateContactButtonCaption = reader.GetValue<System.String>();
				break;
				case "PreconfiguredPageUserTask1.SearchDetailSelectButtonCaption":
					PreconfiguredPageUserTask1.SearchDetailSelectButtonCaption = reader.GetValue<System.String>();
				break;
				case "AutoGeneratedPageUserTask1.ContactName":
					AutoGeneratedPageUserTask1.ContactName = reader.GetValue<System.String>();
				break;
				case "AutoGeneratedPageUserTask1.Phone":
					AutoGeneratedPageUserTask1.Phone = reader.GetValue<System.String>();
				break;
				case "AutoGeneratedPageUserTask1.Account":
					AutoGeneratedPageUserTask1.Account = reader.GetValue<System.Guid>();
				break;
				case "AutoGeneratedPageUserTask1.Email":
					AutoGeneratedPageUserTask1.Email = reader.GetValue<System.String>();
				break;
				case "ContactId":
					if (!hasValueToRead) break;
					ContactId = reader.GetValue<System.Guid>();
				break;
				case "AccountId":
					if (!hasValueToRead) break;
					AccountId = reader.GetValue<System.Guid>();
				break;
				case "PhoneNumber":
					if (!hasValueToRead) break;
					PhoneNumber = reader.GetValue<System.String>();
				break;
				case "NewContact":
					if (!hasValueToRead) break;
					NewContact = reader.GetValue<System.Boolean>();
				break;
				case "IsCaseIncluded":
					if (!hasValueToRead) break;
					IsCaseIncluded = reader.GetValue<System.Boolean>();
				break;
				case "AccountSelected":
					if (!hasValueToRead) break;
					AccountSelected = reader.GetValue<System.Boolean>();
				break;
				case "CreateContactButtonCaption":
					if (!hasValueToRead) break;
					CreateContactButtonCaption = reader.GetValue<System.String>();
				break;
				case "SearchDetailSelectButtonCaption":
					if (!hasValueToRead) break;
					SearchDetailSelectButtonCaption = reader.GetValue<System.String>();
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
			var localContactId = (PreconfiguredPageUserTask1.ContactId);
			ContactId = (System.Guid)localContactId;
			return true;
		}

		public virtual bool FormulaTask2Execute(ProcessExecutingContext context) {
			var localAccountId = (AutoGeneratedPageUserTask1.Account);
			AccountId = (System.Guid)localAccountId;
			return true;
		}

		public virtual bool FormulaTask3Execute(ProcessExecutingContext context) {
			var localContactId = (AddDataUserTask1.RecordId);
			ContactId = (System.Guid)localContactId;
			return true;
		}

		public virtual bool FormulaTask4Execute(ProcessExecutingContext context) {
			var localNewContact = true;
			NewContact = (System.Boolean)localNewContact;
			return true;
		}

		public virtual bool FormulaTask5Execute(ProcessExecutingContext context) {
			var localAccountId = ((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty));
			AccountId = (System.Guid)localAccountId;
			return true;
		}

		public virtual bool FormulaTask6Execute(ProcessExecutingContext context) {
			var localAccountSelected = true;
			AccountSelected = (System.Boolean)localAccountSelected;
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
			var cloneItem = (ContactIdentificationV2)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


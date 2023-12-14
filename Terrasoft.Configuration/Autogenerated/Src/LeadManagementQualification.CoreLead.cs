namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: LeadManagementQualificationSchema

	/// <exclude/>
	public class LeadManagementQualificationSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementQualificationSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementQualificationSchema(LeadManagementQualificationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementQualification";
			UId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645");
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
			SerializeToDB = false;
			SerializeToMemory = false;
			Tag = @"LeadManagementQualification";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645");
			Version = 0;
			PackageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7da3d394-c5b2-4fba-be47-747a00d3685e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAccountIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("adff468f-5785-4238-a962-2d46a6df9207"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"AccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContactIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("21f03e5d-1b78-48dc-9e30-1c86f9161488"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"ContactId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadAddressTypeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2365f649-230d-4d6e-b38b-15932b94c2d9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadAddressType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{66852a75-b22e-4390-a8df-49814cdb0131}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadCityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a00b4828-9039-473d-9786-1042a8a4d495"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadCity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{4258b690-fe71-4b7a-8278-f0a7b9dd4780}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadZipParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b9c2234b-9f29-4b4b-bff9-43ed0aee7fd4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadZip",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadRegionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b120b526-724c-470e-9bde-cca7c5bce38b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadRegion",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{dce30e38-3b37-40b3-b9f5-08b790d93420}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadCountryParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7f25c2c6-3a0b-430a-b8f4-14dac4a33300"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadCountry",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{d79b4d09-4791-4993-952b-e097088b55c6}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadWebsiteParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7573b5d0-d90d-43fb-a4ff-b434212f304d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadWebsite",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadFaxParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ef248d37-29b4-41f3-ae05-29aa2ca78c1e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadFax",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadBusinessPhoneParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("237e51db-51d4-40d3-ba2e-657d419fe693"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadBusinessPhone",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadEmailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6547686a-48b1-457a-810e-01431f20fcf7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadEmail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadMobilePhoneParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f609b031-6cfd-4dbc-9110-5a3c4aaf1d59"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadMobilePhone",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadDecisionRoleParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7d3339ff-d4dd-47f4-aad0-f962a3c06682"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadDecisionRole",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{4a577f44-6cf7-40d0-b1f8-81c2cf6539d1}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadGenderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("26e960a5-407f-49ef-9aeb-194c10c5c07a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadGender",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{257a1321-f45d-4868-bf44-e9f2297661d3}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadDepartmentParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8ad4103a-0d1e-4f62-a22a-707a1d45a404"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadDepartment",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{c7fb190e-51d8-4c65-a5db-c3714d3b0af7}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadJobParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a0f4b101-277c-452d-94c8-b44202a3a196"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadJob",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{aa8c19b4-a8fb-4284-b969-8f15630a25ec}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadSalutationParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f34298ea-de28-49a3-a7dd-0537e9d81810"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadSalutation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{afdaca14-10c0-4767-b1f4-ed06946d37eb}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadDearParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("61ebe384-47c3-41a5-8f7a-689cc754debd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadDear",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadFullJobTitleParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("69d73113-cfb5-46b5-bad8-db01b0089ad7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadFullJobTitle",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadContactNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9ccf4757-79ad-4fda-8a8d-091f07d873c6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadContactName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadAccountNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d7cbdc44-a5b7-48dc-bbaf-a96bd83d7066"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadAccountName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadAnnualRevenueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("485ac59c-8ec0-45f6-b314-99549ce9eedf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadAnnualRevenue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{718683e1-7d00-48d6-ad3f-c882ee2ce79f}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadEmployeesNumberParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("81219640-87de-43de-9f88-0867fbbd7c43"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadEmployeesNumber",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{49508aa7-fa69-4ce3-aa4d-1eeb2c9d73a5}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadAccountCategoryParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("347c7337-e229-470b-a321-5aa2e5a4d102"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadAccountCategory",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{a3200694-9a9a-42a6-824f-870d5b03e255}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadIndustryParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7ab43aa0-0265-44da-baf7-13ae2e552bfe"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadIndustry",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{2edaf1d4-f64e-4351-aa6b-c81a7ebfc108}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadOwnershipParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5b328e21-1e24-46e8-a579-71076a3c942a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadOwnership",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{6a7045c5-ab82-4bf9-a929-9ac065c69343}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadAccountIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ae489f7c-9167-44af-a723-c61c0541a93a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadAccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{32949ae4-ff13-48f5-9f5d-45a74558ea55}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadContactIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f302fbc3-0ce9-4626-9957-2cf93197d6fd"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadContactId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{ad490d58-054a-4d85-9246-dd8466eb3983}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c945f2af-1eae-4ba3-a433-a8ea8b69d8b1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateAccountOnQualificationParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("70ebb313-bd3c-472f-bf4f-f07a23506a9c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"CreateAccountOnQualification",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a188ff27-c185-4b79-b24c-71503e5df1a6}].[Parameter:{411b2f2b-abb2-49c4-b63c-c589bc81bb8c}].[EntityColumn:{297f4697-d071-4be2-8509-9090c07dfe18}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateAccountIdParameter());
			Parameters.Add(CreateContactIdParameter());
			Parameters.Add(CreateLeadAddressTypeParameter());
			Parameters.Add(CreateLeadCityParameter());
			Parameters.Add(CreateLeadZipParameter());
			Parameters.Add(CreateLeadRegionParameter());
			Parameters.Add(CreateLeadCountryParameter());
			Parameters.Add(CreateLeadWebsiteParameter());
			Parameters.Add(CreateLeadFaxParameter());
			Parameters.Add(CreateLeadBusinessPhoneParameter());
			Parameters.Add(CreateLeadEmailParameter());
			Parameters.Add(CreateLeadMobilePhoneParameter());
			Parameters.Add(CreateLeadDecisionRoleParameter());
			Parameters.Add(CreateLeadGenderParameter());
			Parameters.Add(CreateLeadDepartmentParameter());
			Parameters.Add(CreateLeadJobParameter());
			Parameters.Add(CreateLeadSalutationParameter());
			Parameters.Add(CreateLeadDearParameter());
			Parameters.Add(CreateLeadFullJobTitleParameter());
			Parameters.Add(CreateLeadContactNameParameter());
			Parameters.Add(CreateLeadAccountNameParameter());
			Parameters.Add(CreateLeadAnnualRevenueParameter());
			Parameters.Add(CreateLeadEmployeesNumberParameter());
			Parameters.Add(CreateLeadAccountCategoryParameter());
			Parameters.Add(CreateLeadIndustryParameter());
			Parameters.Add(CreateLeadOwnershipParameter());
			Parameters.Add(CreateLeadAccountIdParameter());
			Parameters.Add(CreateLeadContactIdParameter());
			Parameters.Add(CreateLeadAddressParameter());
			Parameters.Add(CreateCreateAccountOnQualificationParameter());
		}

		protected virtual void InitializeReadLeadDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eb174310-4f6b-4191-b705-5ac74e8d6810"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,36,21,219,146,45,201,61,46,219,178,80,210,64,211,82,72,150,48,146,70,89,129,63,54,182,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,209,104,222,155,55,143,209,124,31,198,143,161,137,56,212,30,154,17,233,180,115,53,81,50,171,148,45,21,227,86,35,19,185,171,152,66,101,24,47,164,41,84,174,140,178,64,104,7,45,214,100,69,111,93,136,132,134,136,237,88,223,206,191,73,227,48,33,189,247,231,203,87,123,192,22,190,45,13,68,14,94,105,212,76,150,153,97,2,141,97,137,210,50,239,185,54,149,80,34,71,75,86,45,168,185,149,214,8,230,164,45,153,240,94,50,237,83,169,54,170,244,186,200,115,144,21,161,13,250,184,125,58,14,56,142,161,239,234,25,95,227,155,231,99,82,185,246,222,244,205,212,118,132,182,24,225,26,226,161,38,128,25,138,210,2,179,66,47,236,40,25,112,237,24,7,35,11,169,48,175,114,73,168,133,99,92,104,201,206,17,234,32,194,119,104,38,60,51,207,33,105,44,120,150,171,178,74,216,156,91,38,120,145,49,85,41,201,188,171,188,70,94,105,109,220,197,175,79,83,72,113,24,175,166,22,135,96,95,108,199,228,95,63,212,179,237,187,56,244,205,66,125,117,46,191,193,167,184,154,251,242,244,99,29,40,166,252,2,34,39,58,141,184,105,2,118,113,219,217,222,133,238,97,229,60,157,18,164,61,194,16,198,139,11,219,199,9,26,66,135,240,112,248,163,91,155,105,140,125,251,31,141,74,211,152,137,35,45,217,89,238,178,131,46,140,199,6,158,207,247,154,188,123,156,250,248,225,51,130,91,35,242,6,81,147,59,34,29,112,199,181,96,182,52,69,218,5,3,204,160,144,76,10,9,89,230,120,165,74,188,35,73,197,63,112,223,238,198,47,63,187,203,31,88,85,239,223,167,236,155,196,245,5,89,207,127,35,231,180,95,4,237,79,233,252,2,53,129,193,231,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2c5fddb8-7f3b-431c-a140-15c790c47997"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c9715250-2f51-47c6-ae51-692c6ef09e35"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7aa6f27f-9136-4c8a-95c8-d11d8c5dd57c"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("105c3fa8-1208-4d19-bf97-40057718c52f"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("001d410e-1ab8-4cd6-bb61-83ee17b39a5b"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a1588d18-597e-4d60-95bc-bd4c78338608"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("724a8768-9516-4d2c-aa88-41a1bb2d5e37"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1eb2f334-3b2d-4e66-96ae-e2c0468ec136"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("02e6f3dc-c3b7-48c5-b1bb-858d7d4b6706"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("552d4238-195d-4289-9c82-72b9a2a6cc13"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2ee6855b-3c07-41fe-9ed9-dce8afc87598"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d8c1e15f-029b-46de-8fb1-c9ab4e292106"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("30fc9f29-8bc3-4e4c-8238-8d93757cf810"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2ab23a86-7cff-4fa0-b600-4001d8b72aca"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fd8b3b5a-0afb-4d72-b51c-4907de28ec37"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6d962028-129a-453e-8ba9-f69a2f78e60c"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f2737688-dfc2-4d03-969c-d7a4170bc47e"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("13beec44-3596-4408-9292-685bdcd4aae4"),
				ContainerUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeChangeContactAccountParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("ea29a1a7-83b3-4850-9134-d716cf498910"),
				ContainerUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
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
				Value = @"16be3651-8fe2-4159-8dd0-a803d4683dd3",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2a3f5cb3-7035-42b2-9882-c80f7985168f"),
				ContainerUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0d8e007f-f368-46a3-840e-c8c133b97854"),
				ContainerUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,43,65,135,158,60,197,178,100,91,118,143,203,182,236,37,77,105,90,2,73,8,35,105,148,21,248,99,99,203,52,193,236,127,175,188,206,182,144,67,233,161,151,130,14,210,72,239,205,123,143,209,252,224,199,143,190,9,52,212,14,155,145,146,105,103,107,166,114,237,164,171,50,112,156,19,72,41,16,116,90,57,176,174,212,28,93,37,181,40,89,210,97,75,53,91,209,91,235,3,75,124,160,118,172,111,231,223,164,97,152,40,121,112,167,195,87,179,167,22,191,45,13,120,161,73,20,57,7,229,40,3,201,243,10,148,181,41,160,74,133,149,133,18,214,10,182,106,113,133,205,172,174,16,82,165,11,144,70,58,64,148,6,156,206,164,70,99,140,83,81,75,67,46,108,159,15,3,141,163,239,187,122,166,95,251,235,151,67,84,185,246,222,244,205,212,118,44,105,41,224,21,134,125,205,144,82,146,185,65,48,178,202,65,58,42,1,69,101,65,160,46,179,82,17,47,120,100,55,120,8,11,45,219,89,150,88,12,248,29,155,137,78,204,179,143,26,51,145,114,149,23,17,203,133,1,41,178,20,84,161,74,112,182,112,85,52,90,85,218,158,243,250,52,249,184,247,227,229,212,210,224,205,107,236,20,243,235,135,122,54,125,23,134,190,89,168,47,79,207,175,233,57,172,225,190,94,221,172,134,66,172,47,32,118,76,166,145,54,141,167,46,108,59,211,91,223,61,174,156,199,99,132,180,7,28,252,120,78,97,251,52,97,195,146,193,63,238,255,152,214,102,26,67,223,254,71,86,147,104,51,114,196,33,59,201,93,102,208,250,241,208,224,203,233,92,179,119,79,83,31,62,124,137,246,189,243,100,47,112,188,88,154,160,9,235,13,123,195,80,179,59,150,113,151,10,202,45,112,93,42,144,202,26,136,14,83,224,70,69,175,113,50,164,82,119,44,170,250,7,189,110,119,227,231,31,221,249,143,172,174,238,223,199,234,155,194,213,25,89,207,127,35,239,120,191,8,188,63,198,245,19,156,38,180,91,234,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c0fe375b-e8e3-406d-b4a8-8783f94f8903"),
				ContainerUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,203,110,219,48,16,252,21,131,201,209,52,72,74,212,235,90,183,128,129,164,117,155,52,23,219,135,21,185,76,12,200,146,65,74,109,83,67,255,94,138,150,107,59,109,47,229,129,132,118,57,51,203,157,213,129,220,182,175,123,36,5,121,68,107,193,53,166,157,189,107,44,206,150,182,81,232,220,236,174,81,80,109,127,66,89,225,18,44,236,176,69,251,4,85,135,238,110,235,218,233,228,26,70,166,228,246,91,200,146,98,117,32,139,22,119,95,23,218,179,39,130,43,4,204,41,23,105,78,99,166,37,45,1,57,77,208,0,98,84,34,64,236,193,170,169,186,93,125,143,45,44,161,125,33,197,129,4,54,79,32,85,162,128,51,164,156,103,140,198,138,35,205,64,50,42,37,164,194,152,188,212,58,38,253,148,56,245,130,59,8,162,103,48,79,74,140,18,201,105,102,80,208,152,203,156,102,90,51,10,25,139,116,156,100,145,214,209,0,30,239,159,129,171,155,213,194,125,250,94,163,125,8,188,133,129,202,225,102,230,163,111,2,191,155,83,28,64,27,227,73,13,149,105,38,105,44,162,140,66,158,8,42,188,20,36,218,228,130,165,253,230,102,51,40,234,173,219,87,240,250,244,167,240,231,206,247,221,108,81,79,192,77,64,169,166,171,219,35,102,127,229,195,37,234,176,62,218,185,38,197,250,95,134,142,231,177,252,107,75,223,186,185,38,211,53,121,104,58,171,6,198,104,248,56,117,55,40,176,113,209,191,108,167,117,228,8,176,123,168,225,25,237,71,175,24,224,33,53,135,22,130,248,163,175,251,68,92,138,92,178,148,27,154,34,248,105,65,223,188,76,115,160,57,207,75,19,165,145,55,92,4,244,23,52,104,177,86,120,93,152,144,58,85,28,74,202,53,250,97,145,140,211,50,102,130,50,129,12,135,129,209,201,241,113,65,249,92,204,105,240,124,164,238,170,42,8,184,240,254,97,146,199,194,199,204,252,194,185,11,134,70,7,211,22,245,127,182,106,142,38,80,126,104,236,251,31,254,15,219,214,207,163,99,23,210,231,59,115,181,27,227,61,233,251,77,255,11,70,60,179,216,208,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cefcf07d-bdb1-4eef-8f15-76b244047bd4"),
				ContainerUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
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

		protected virtual void InitializeChangeLeadStageDistributionParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("9e34dc39-7d39-421f-8d27-92a8af9a80c6"),
				ContainerUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bcf5b8fe-4737-4d4e-a037-b2c70a7900e8"),
				ContainerUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bb68e8f2-44a8-4731-b948-176e754a5d8b"),
				ContainerUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,36,21,91,146,45,203,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,153,145,222,155,55,143,209,124,239,195,71,223,70,28,107,7,109,64,58,237,108,77,184,226,34,47,141,98,152,75,203,164,212,142,85,156,75,86,104,206,185,145,69,46,120,65,104,15,29,214,100,69,111,173,143,132,250,136,93,168,111,231,223,164,113,156,144,222,187,115,242,213,28,176,131,111,75,3,153,131,171,52,106,166,138,172,97,18,155,134,85,6,12,115,78,232,166,148,149,204,209,144,85,139,146,218,100,188,116,12,178,204,49,89,186,20,85,166,96,214,136,194,128,179,153,85,72,104,139,46,110,159,142,35,134,224,135,190,158,241,53,190,121,62,38,149,107,239,205,208,78,93,79,104,135,17,174,33,30,106,2,152,161,76,60,204,72,93,48,233,80,49,16,218,50,1,141,226,170,194,188,204,21,161,6,142,113,161,37,59,75,168,133,8,223,161,157,240,204,60,251,197,47,145,229,85,81,38,108,46,12,147,130,103,172,42,43,197,156,45,157,70,81,106,221,216,139,95,159,38,159,98,31,174,166,14,71,111,94,108,199,228,223,48,214,179,25,250,56,14,237,66,125,117,126,126,131,79,113,53,247,229,234,199,58,80,76,245,5,68,78,116,10,184,105,61,246,113,219,155,193,250,254,97,229,60,157,18,164,59,194,232,195,197,133,237,227,4,45,161,163,127,56,252,209,173,205,20,226,208,253,71,163,210,52,102,226,72,75,118,150,187,236,160,245,225,216,194,243,57,175,201,187,199,105,136,31,62,35,216,53,34,111,16,53,185,35,202,130,176,66,75,102,138,134,167,93,104,128,53,40,21,83,82,165,221,179,162,172,10,188,35,73,197,63,112,223,238,194,151,159,253,229,15,172,170,247,239,83,245,77,225,250,130,172,231,191,145,115,218,47,130,246,167,116,126,1,123,109,74,170,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f994ffb6-8edf-41e3-892d-aa56db1c821b"),
				ContainerUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,95,111,218,48,20,197,191,202,228,246,17,71,137,237,216,49,175,99,149,144,232,132,70,215,151,210,135,107,231,186,141,26,18,228,36,211,58,196,119,159,49,65,192,180,74,211,252,144,200,127,126,231,92,223,227,29,185,237,223,183,72,166,228,1,189,135,174,117,125,242,185,245,152,44,125,107,177,235,146,69,107,161,174,126,129,169,113,9,30,54,216,163,127,132,122,192,110,81,117,253,228,211,53,70,38,228,246,71,220,37,211,167,29,153,247,184,249,62,47,131,122,94,74,151,51,5,212,228,76,80,81,88,77,65,155,130,58,163,180,112,168,114,45,84,128,109,91,15,155,230,30,123,88,66,255,74,166,59,18,213,130,128,177,169,101,165,76,105,14,188,12,2,34,165,0,2,169,149,41,130,82,18,89,42,201,126,66,58,251,138,27,136,166,103,88,100,224,10,141,154,170,60,53,84,160,49,180,176,96,169,115,92,27,25,196,50,180,7,120,60,127,6,159,110,22,109,251,54,108,19,198,184,200,108,153,209,220,112,78,133,13,246,58,205,50,42,157,146,154,163,147,40,68,146,9,235,172,20,130,34,199,80,163,86,72,11,166,52,197,82,240,76,27,83,164,154,223,60,31,140,202,170,219,214,240,254,248,161,223,170,135,23,76,102,161,197,190,50,67,95,181,205,17,220,94,101,112,137,238,214,199,40,215,100,186,254,40,204,241,191,138,61,186,142,243,207,36,215,100,178,38,171,118,240,246,160,200,15,147,83,103,163,67,58,14,250,151,207,105,28,53,34,118,15,77,184,144,255,26,28,35,30,183,102,208,67,52,127,8,117,159,132,13,211,121,170,50,71,21,130,14,89,73,70,139,50,3,170,67,7,29,87,156,57,199,34,253,13,29,122,108,44,94,23,246,47,73,69,62,58,159,139,57,61,186,176,210,12,117,29,13,186,120,255,195,43,30,11,31,119,102,23,241,93,40,180,101,229,42,44,231,205,127,182,106,134,46,74,222,181,254,203,207,16,125,213,188,140,137,93,88,159,207,204,236,102,92,223,147,253,254,121,255,27,225,101,147,76,204,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7e817e60-3ea5-40a4-8ee5-379468961efc"),
				ContainerUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
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

		protected virtual void InitializeLinkContactToLeadParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("6dd0bc3f-edfa-4078-87d0-79fe8307a8ab"),
				ContainerUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55ac08c6-ba80-4060-81f6-fb82943a2aa6"),
				ContainerUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("34908b60-ff49-4067-a7d9-fecfeba3d015"),
				ContainerUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,100,21,219,146,45,201,61,46,219,178,80,210,64,211,82,72,150,48,146,70,89,129,63,54,150,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,153,145,222,155,55,143,209,124,239,195,71,223,70,28,27,7,109,192,108,218,217,134,228,224,74,199,164,166,214,212,21,229,70,20,84,114,91,81,109,21,230,170,174,141,150,154,100,61,116,216,144,21,189,181,62,146,204,71,236,66,115,59,255,38,141,227,132,217,189,59,39,95,205,1,59,248,182,52,224,5,56,169,80,81,81,229,154,114,212,154,74,3,134,58,199,148,174,185,228,5,26,178,106,209,104,20,171,77,78,157,72,239,185,41,144,202,138,139,37,5,174,36,215,133,96,36,107,209,197,237,211,113,196,16,252,208,55,51,190,198,55,207,199,164,114,237,189,25,218,169,235,73,214,97,132,107,136,135,134,0,230,200,43,3,212,112,149,38,117,40,40,48,101,41,3,45,74,33,177,168,11,65,50,3,199,184,208,146,157,37,153,133,8,223,161,157,240,204,60,251,164,177,100,121,33,171,58,97,11,102,40,103,101,78,101,45,147,70,91,59,133,172,86,74,219,139,95,159,38,159,98,31,174,166,14,71,111,94,108,199,228,223,48,54,179,25,250,56,14,237,66,125,117,126,126,131,79,113,53,247,229,234,199,58,80,76,245,5,68,78,217,20,112,211,122,236,227,182,55,131,245,253,195,202,121,58,37,72,119,132,209,135,139,11,219,199,9,90,146,141,254,225,240,71,183,54,83,136,67,247,31,141,154,165,49,19,71,90,178,179,220,101,7,173,15,199,22,158,207,121,67,222,61,78,67,252,240,25,193,174,17,121,131,104,200,29,17,22,152,101,138,83,83,233,50,237,130,6,170,49,109,154,224,2,242,220,178,90,86,120,71,146,138,127,224,190,221,133,47,63,251,203,31,88,85,239,223,167,234,155,194,245,5,217,204,127,35,231,180,95,4,237,79,233,252,2,68,233,196,17,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ee931748-590a-41b4-8229-e4dc1c8b23af"),
				ContainerUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,81,111,219,32,20,133,255,74,68,251,24,34,99,192,6,191,46,155,20,169,221,178,181,235,75,146,135,11,92,218,72,142,29,217,206,182,46,242,127,31,33,206,146,116,219,203,120,176,229,11,223,57,23,14,222,147,219,238,117,139,164,32,143,216,52,208,214,190,155,188,171,27,156,204,155,218,98,219,78,238,106,11,229,250,39,152,18,231,208,192,6,59,108,158,160,220,97,123,183,110,187,241,232,26,35,99,114,251,45,206,146,98,177,39,179,14,55,95,103,46,168,167,70,176,92,72,71,185,178,154,10,48,72,181,180,138,38,153,101,10,133,100,82,186,0,219,186,220,109,170,123,236,96,14,221,11,41,246,36,170,5,1,112,66,39,78,6,66,10,160,194,41,73,117,42,50,234,156,18,89,134,134,107,197,73,63,38,173,125,193,13,68,211,51,44,24,120,165,81,211,92,38,134,10,52,134,42,11,150,122,207,181,201,132,18,12,237,1,30,214,159,193,197,205,98,214,126,250,94,97,243,16,117,11,15,101,139,171,73,168,190,41,252,62,156,98,159,50,159,112,12,123,101,38,87,84,40,103,169,70,158,80,102,85,230,53,203,152,80,170,95,221,172,14,142,110,221,110,75,120,125,250,211,248,243,46,156,187,95,163,27,65,59,178,117,213,129,237,142,204,246,42,135,75,106,191,60,198,185,36,197,242,95,129,14,239,99,251,215,145,190,77,115,73,198,75,242,80,239,26,123,80,228,135,143,211,233,70,135,100,24,244,47,143,211,56,106,68,236,30,42,120,198,230,99,112,140,120,156,154,66,7,209,252,49,244,125,18,54,169,150,73,206,60,205,17,194,109,193,44,165,202,49,160,154,105,227,121,206,83,239,211,72,127,65,143,13,86,22,175,27,99,153,65,158,73,70,149,199,148,10,38,117,224,93,66,65,37,220,137,76,113,231,120,228,163,243,185,153,211,197,11,149,106,87,150,209,160,141,251,63,220,228,161,241,97,102,122,145,220,133,66,237,98,104,179,234,63,143,106,138,62,74,126,168,155,247,63,194,31,182,174,158,135,196,46,172,207,107,166,118,51,212,123,210,247,171,254,23,174,109,74,206,208,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a7baafae-621c-427a-952d-c17478900ce1"),
				ContainerUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
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

		protected virtual void InitializeLinkAccountToLeadParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("7b3e0e2a-6d32-492c-9290-46e7c194da0b"),
				ContainerUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fbd3778b-b29e-4da4-878c-479ce66f6695"),
				ContainerUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e2572aab-9833-4451-bac3-3c93b4938008"),
				ContainerUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,36,21,127,72,150,229,30,151,109,89,40,105,160,105,41,36,75,24,73,163,172,192,31,27,75,166,9,102,255,123,229,117,54,133,28,74,233,173,160,195,204,72,239,205,155,199,104,190,247,225,163,111,35,142,141,131,54,32,157,118,182,33,89,94,91,13,218,177,66,229,150,113,172,53,211,174,54,76,85,142,231,89,230,180,118,72,104,15,29,54,100,69,111,173,143,132,250,136,93,104,110,231,223,164,113,156,144,222,187,115,242,213,28,176,131,111,75,3,158,131,171,21,42,38,69,166,83,3,173,89,109,192,48,231,74,165,43,94,243,28,13,89,181,8,237,138,42,43,37,43,100,101,24,183,66,49,45,92,197,140,116,5,26,93,24,1,130,208,22,93,220,62,29,71,12,193,15,125,51,227,107,124,243,124,76,42,215,222,155,161,157,186,158,208,14,35,92,67,60,52,4,48,67,46,12,48,195,149,96,220,161,100,80,42,203,74,208,178,144,53,230,85,46,9,53,112,140,11,45,217,89,66,45,68,248,14,237,132,103,230,217,39,141,69,153,28,19,85,194,230,101,210,88,22,25,171,171,90,50,103,43,167,176,172,148,210,246,226,215,167,201,167,216,135,171,169,195,209,155,23,219,49,249,55,140,205,108,134,62,142,67,187,80,95,157,159,223,224,83,92,205,125,185,250,177,14,20,83,125,1,145,19,157,2,110,90,143,125,220,246,102,176,190,127,88,57,79,167,4,233,142,48,250,112,113,97,251,56,65,75,232,232,31,14,127,116,107,51,133,56,116,255,209,168,52,141,153,56,210,146,157,229,46,59,104,125,56,182,240,124,206,27,242,238,113,26,226,135,207,8,118,141,200,27,68,67,238,136,180,80,218,82,113,102,132,46,210,46,104,96,26,185,100,146,75,200,50,91,86,181,192,59,146,84,252,3,247,237,46,124,249,217,95,254,192,170,122,255,62,85,223,20,174,47,200,102,254,27,57,167,253,34,104,127,74,231,23,52,11,173,221,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2c5dda1b-35c1-410a-8a66-b8e7dbef353d"),
				ContainerUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,193,110,219,48,12,253,149,64,237,49,10,108,89,178,45,95,151,13,8,208,110,217,218,245,146,228,64,73,84,27,192,177,3,217,222,214,5,254,247,201,138,179,36,221,118,153,14,18,76,234,189,71,241,209,7,114,219,190,238,145,20,228,17,157,131,166,182,237,236,93,237,112,182,116,181,198,166,153,221,213,26,202,237,79,80,37,46,193,193,14,91,116,79,80,118,216,220,109,155,118,58,185,134,145,41,185,253,22,178,164,88,29,200,162,197,221,215,133,241,236,89,198,101,108,35,160,92,171,140,242,36,85,84,42,140,40,211,185,180,90,9,3,54,242,96,93,151,221,174,186,199,22,150,208,190,144,226,64,2,155,39,72,152,228,18,144,83,107,227,132,242,220,10,42,173,48,148,11,200,184,16,57,130,16,164,159,146,70,191,224,14,130,232,25,204,99,176,185,68,73,51,17,41,202,81,41,154,107,208,158,43,145,42,229,57,143,81,15,224,241,254,25,184,186,89,45,154,79,223,43,116,15,129,183,176,80,54,184,153,249,232,155,192,239,230,20,7,48,214,242,52,183,84,100,185,160,156,37,57,5,153,50,202,12,79,33,53,86,178,40,235,55,55,155,65,209,108,155,125,9,175,79,127,10,127,238,124,223,237,22,205,4,154,9,104,93,119,85,123,196,236,175,124,184,68,29,214,71,59,215,164,88,255,203,208,241,60,150,127,109,233,91,55,215,100,186,38,15,117,231,244,192,152,12,31,167,238,6,133,104,92,244,47,219,105,29,57,2,236,30,42,120,70,247,209,43,6,120,72,205,161,133,32,254,232,235,62,17,43,38,69,148,197,150,102,8,210,251,229,155,151,155,24,168,140,165,178,73,150,48,107,89,64,127,65,139,14,43,141,215,133,49,97,50,29,131,162,177,241,51,198,69,20,83,197,35,70,35,134,17,250,129,97,38,61,62,46,40,159,139,57,13,158,143,84,93,89,6,129,38,188,127,152,228,177,240,49,51,191,112,238,130,161,54,193,180,69,245,159,173,154,163,13,148,31,106,247,254,135,255,195,182,213,243,232,216,133,244,249,206,92,239,198,120,79,250,126,211,255,2,14,63,30,86,208,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8e7d41f7-0f25-4dc6-8538-30a7a13a5a71"),
				ContainerUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
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

		protected virtual void InitializeReadSystemSettingsParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5b47b7b3-1c3a-4e76-8b27-d2d1429d61ee"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,82,77,107,220,48,20,252,43,69,135,158,172,32,75,178,100,187,167,178,108,161,151,52,101,211,82,40,37,60,75,79,89,129,191,98,201,144,101,217,255,94,217,206,182,208,67,33,199,128,14,250,120,243,102,222,140,206,15,62,124,242,109,196,169,118,208,6,204,230,207,182,38,18,148,180,85,83,209,70,138,134,202,188,82,180,196,28,40,54,165,150,40,28,203,49,39,89,15,29,214,100,67,239,173,143,36,243,17,187,80,255,60,255,109,26,167,25,179,7,183,30,14,230,136,29,124,91,8,170,34,111,120,211,52,148,53,32,168,100,178,162,21,240,196,87,88,105,88,163,108,193,28,217,180,112,93,42,205,139,130,114,206,28,149,70,26,90,149,82,209,194,228,172,178,74,11,180,146,100,45,186,184,127,30,39,12,193,15,125,125,198,63,251,251,211,152,84,110,220,187,161,157,187,158,100,29,70,184,131,120,172,9,115,22,149,203,49,117,55,5,149,165,209,180,50,101,69,149,99,76,228,200,53,179,120,147,11,0,91,72,73,209,8,70,37,106,69,65,104,65,29,51,206,9,206,56,242,36,193,192,24,23,110,114,56,133,228,195,187,128,49,250,254,241,102,55,88,36,153,133,8,223,161,157,113,213,115,246,105,50,193,11,208,162,41,41,115,82,83,41,129,209,82,230,156,106,197,148,211,101,18,0,230,234,242,225,56,76,241,30,159,23,147,195,237,220,225,228,205,75,98,152,172,31,166,250,108,134,62,78,67,187,244,191,93,49,75,249,150,203,203,211,143,205,139,152,238,23,16,185,100,115,192,93,235,177,143,251,222,12,54,169,93,3,187,92,18,162,27,97,242,225,234,223,254,105,134,150,100,147,127,60,254,215,231,59,152,18,119,10,251,141,77,156,141,87,225,171,228,229,19,91,31,198,22,78,235,185,38,239,159,230,33,126,216,77,8,17,63,26,51,204,125,252,210,127,77,166,120,231,13,44,193,111,21,228,159,78,175,64,94,126,93,210,250,13,237,231,240,99,146,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("055337fb-4c12-4162-baa0-f0a6f82b04f1"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("61008822-6246-4cb7-94b5-d7ab2c0e761f"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a18bad05-72bd-47e8-8a76-9adc5adb727a"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("05ce4b0d-7adf-4370-a4da-9a578ae526a6"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b54c1807-d3db-417d-acc8-5ec641e8f114"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("eb5b205e-4427-45cf-8b2f-e5c11ffb5d04"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,11,174,44,14,78,45,41,201,204,75,47,182,50,180,50,212,241,76,177,50,176,50,0,0,176,83,7,250,22,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("951b2bbb-0ba3-4049-9a29-b5d4c0b6d50f"),
				UId = new Guid("411b2f2b-abb2-49c4-b63c-c589bc81bb8c"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0107e886-cf9e-458c-9fa5-10337b71312c"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c92f52ed-8123-486d-ae9b-c9c0f3e785cf"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("6c8845de-fd11-481f-ba54-02935c4aeb9d"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("63c46681-2887-41fe-8ea5-3cd9bd9e60fe"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f0232a3c-912e-48ab-9927-5fc33677f7ba"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("06e3ef5a-2fa6-49b7-bfa6-3a114e683d05"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("951b2bbb-0ba3-4049-9a29-b5d4c0b6d50f"),
				UId = new Guid("0a40e220-4683-47e0-a0c2-892934668fc3"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("44d1abb0-802b-49e6-9571-d667de498b3e"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("11fe36aa-20e3-41b3-99f4-0a35fd3628cc"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e38c6786-4b6a-453c-98ff-274e159ab770"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("31b48d41-0e68-4322-ac74-bf409264e30f"),
				ContainerUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
			ProcessSchemaLaneSet schemaLeadQualificationProcess = CreateLeadQualificationProcessLaneSet();
			LaneSets.Add(schemaLeadQualificationProcess);
			ProcessSchemaLane schemaLeadQualification = CreateLeadQualificationLane();
			schemaLeadQualificationProcess.Lanes.Add(schemaLeadQualification);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminatequalified = CreateTerminateQualifiedTerminateEvent();
			FlowElements.Add(terminatequalified);
			ProcessSchemaExclusiveGateway exclusivegatewayisleadset = CreateExclusiveGatewayIsLeadSetExclusiveGateway();
			FlowElements.Add(exclusivegatewayisleadset);
			ProcessSchemaTerminateEvent terminate2 = CreateTerminate2TerminateEvent();
			FlowElements.Add(terminate2);
			ProcessSchemaUserTask readleaddata = CreateReadLeadDataUserTask();
			FlowElements.Add(readleaddata);
			ProcessSchemaUserTask changecontactaccount = CreateChangeContactAccountUserTask();
			FlowElements.Add(changecontactaccount);
			ProcessSchemaExclusiveGateway exclusivegatewayaccountconnection = CreateExclusiveGatewayAccountConnectionExclusiveGateway();
			FlowElements.Add(exclusivegatewayaccountconnection);
			ProcessSchemaUserTask changeleadstagedistribution = CreateChangeLeadStageDistributionUserTask();
			FlowElements.Add(changeleadstagedistribution);
			ProcessSchemaScriptTask changeaccountscripttask = CreateChangeAccountScriptTaskScriptTask();
			FlowElements.Add(changeaccountscripttask);
			ProcessSchemaScriptTask changecontactscripttask = CreateChangeContactScriptTaskScriptTask();
			FlowElements.Add(changecontactscripttask);
			ProcessSchemaUserTask linkcontacttolead = CreateLinkContactToLeadUserTask();
			FlowElements.Add(linkcontacttolead);
			ProcessSchemaUserTask linkaccounttolead = CreateLinkAccountToLeadUserTask();
			FlowElements.Add(linkaccounttolead);
			ProcessSchemaExclusiveGateway exclusivegatewayqualifiedaccount = CreateExclusiveGatewayQualifiedAccountExclusiveGateway();
			FlowElements.Add(exclusivegatewayqualifiedaccount);
			ProcessSchemaUserTask readsystemsettings = CreateReadSystemSettingsUserTask();
			FlowElements.Add(readsystemsettings);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateLeadDefinedSequenceFlow());
			FlowElements.Add(CreateSequenceFlowNoAccountSequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
			FlowElements.Add(CreateQualifiedContactExistsSequenceFlowConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateQualifiedAccountExistsSequenceFlowConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("c65a1bbe-a2e1-4643-aea1-a3b83207ea88"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf1b5b17-6f6d-4e3d-8136-b213854f53b7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ed9cbb4d-b5c9-4231-ab67-76ffff3433b0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowLeadUndefinedConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowLeadUndefined",
				UId = new Guid("00b2c101-a67f-4a28-a60e-f6ef8f988808"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{7da3d394-c5b2-4fba-be47-747a00d3685e}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(176, 271),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ed9cbb4d-b5c9-4231-ab67-76ffff3433b0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("478ef5b0-3cfe-49aa-9d92-d33e5210847a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateLeadDefinedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "LeadDefined",
				UId = new Guid("756698c0-b46a-4130-a2ea-3b7d3f77b46b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(231, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ed9cbb4d-b5c9-4231-ab67-76ffff3433b0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(202, 372));
			schemaFlow.PolylinePointPositions.Add(new Point(202, 491));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowNoAccountSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlowNoAccount",
				UId = new Guid("c7e87ab7-7efe-4228-b1ed-7c57a2135e50"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(1084, 512),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("968e7a35-4c26-459a-806f-a3b34d7fe1c2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(636, 512));
			schemaFlow.PolylinePointPositions.Add(new Point(636, 92));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("8df03451-825f-4626-947e-1c39dddd618f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{adff468f-5785-4238-a962-2d46a6df9207}]#]!= Guid.Empty && [#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{21f03e5d-1b78-48dc-9e30-1c86f9161488}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(1021, 601),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("968e7a35-4c26-459a-806f-a3b34d7fe1c2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("d11e3a52-d220-4d16-b36a-25b6d32fa2d8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(1104, 628),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(734, 687));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("aecc3666-b64f-448b-92d5-e58fceb68420"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(1782, 434),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("279e66a8-61fb-4e2b-8559-0362a5ebb1fe"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow26",
				UId = new Guid("d5c984cc-6130-459a-87b9-d537c71ee823"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(793, 206),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9970214a-b543-4895-ab00-ab57461e70cf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("97776b38-7f29-472a-ab13-e87884d17d43"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(270, 121));
			schemaFlow.PolylinePointPositions.Add(new Point(274, 121));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateQualifiedContactExistsSequenceFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "QualifiedContactExistsSequenceFlow",
				UId = new Guid("644d1a44-d831-44e0-982d-8da2dc9c15bf"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{21f03e5d-1b78-48dc-9e30-1c86f9161488}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("92323026-06de-4fcc-b310-6de28b5b7964"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("97776b38-7f29-472a-ab13-e87884d17d43"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(274, 36));
			schemaFlow.PolylinePointPositions.Add(new Point(552, 36));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("2f920b5d-24b3-48d4-8c77-b0608b4cbdac"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("92323026-06de-4fcc-b310-6de28b5b7964"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("97776b38-7f29-472a-ab13-e87884d17d43"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("045b9d72-61cb-4f5f-8a92-c02297c04e1d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(413, 78));
			schemaFlow.PolylinePointPositions.Add(new Point(413, 232));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("b8793434-8131-45af-9836-038f53b3d96f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("968e7a35-4c26-459a-806f-a3b34d7fe1c2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("48ad4d37-ec71-49c5-bbbc-48d071c60c63"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("045b9d72-61cb-4f5f-8a92-c02297c04e1d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(552, 135));
			schemaFlow.PolylinePointPositions.Add(new Point(545, 135));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("2115af57-31f8-4299-8456-bf03d959df4a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("5307b755-7675-4cab-b5a0-bbf36f487016"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9970214a-b543-4895-ab00-ab57461e70cf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateQualifiedAccountExistsSequenceFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "QualifiedAccountExistsSequenceFlow",
				UId = new Guid("2e0ed20e-8966-4d04-847a-b6b5a83c0b82"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{adff468f-5785-4238-a962-2d46a6df9207}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("045b9d72-61cb-4f5f-8a92-c02297c04e1d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(588, 232));
			schemaFlow.PolylinePointPositions.Add(new Point(588, 344));
			schemaFlow.PolylinePointPositions.Add(new Point(545, 344));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("8f67e700-62e9-40c4-a643-f73bb5f05cad"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("045b9d72-61cb-4f5f-8a92-c02297c04e1d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("968e7a35-4c26-459a-806f-a3b34d7fe1c2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(545, 275));
			schemaFlow.PolylinePointPositions.Add(new Point(445, 275));
			schemaFlow.PolylinePointPositions.Add(new Point(445, 512));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLeadQualificationProcessLaneSet() {
			ProcessSchemaLaneSet schemaLeadQualificationProcess = new ProcessSchemaLaneSet(this) {
				UId = new Guid("52a0ec41-f948-487a-bbce-75440b557857"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadQualificationProcess",
				Position = new Point(5, 5),
				Size = new Size(1156, 948),
				UseBackgroundMode = false
			};
			return schemaLeadQualificationProcess;
		}

		protected virtual ProcessSchemaLane CreateLeadQualificationLane() {
			ProcessSchemaLane schemaLeadQualification = new ProcessSchemaLane(this) {
				UId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("52a0ec41-f948-487a-bbce-75440b557857"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LeadQualification",
				Position = new Point(29, 0),
				Size = new Size(1127, 948),
				UseBackgroundMode = false
			};
			return schemaLeadQualification;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("bf1b5b17-6f6d-4e3d-8136-b213854f53b7"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"Start1",
				Position = new Point(50, 359),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateQualifiedTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("279e66a8-61fb-4e2b-8559-0362a5ebb1fe"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"TerminateQualified",
				Position = new Point(820, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayIsLeadSetExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("ed9cbb4d-b5c9-4231-ab67-76ffff3433b0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"ExclusiveGatewayIsLeadSet",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(113, 345),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate2TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("478ef5b0-3cfe-49aa-9d92-d33e5210847a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"Terminate2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(127, 478),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"ReadLeadData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(236, 464),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadLeadDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeContactAccountUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"ChangeContactAccount",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(511, 660),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeContactAccountParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayAccountConnectionExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("968e7a35-4c26-459a-806f-a3b34d7fe1c2"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"ExclusiveGatewayAccountConnection",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(518, 485),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadStageDistributionUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"ChangeLeadStageDistribution",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(700, 65),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeChangeLeadStageDistributionParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeAccountScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("97776b38-7f29-472a-ab13-e87884d17d43"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"ChangeAccountScriptTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(240, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,11,40,202,79,78,45,46,118,76,78,206,47,205,43,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,181,13,239,214,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeContactScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9970214a-b543-4895-ab00-ab57461e70cf"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"ChangeContactScriptTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(236, 185),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,11,40,202,79,78,45,46,118,206,207,43,73,76,46,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,245,187,243,113,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateLinkContactToLeadUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("92323026-06de-4fcc-b310-6de28b5b7964"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LinkContactToLead",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(518, 65),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeLinkContactToLeadParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateLinkAccountToLeadUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"LinkAccountToLead",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(511, 359),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeLinkAccountToLeadParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayQualifiedAccountExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("045b9d72-61cb-4f5f-8a92-c02297c04e1d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"ExclusiveGatewayQualifiedAccount",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(518, 205),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadSystemSettingsUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba73ea8a-5a22-4c8b-807e-e27f1d404045"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06d6585a-7cd3-4bd9-a9f3-7b52c8d29213"),
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Name = @"ReadSystemSettings",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(236, 304),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadSystemSettingsParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateProcessAccountMethod());
			Methods.Add(CreateSetValueMethod());
			Methods.Add(CreateProcessContactMethod());
			Methods.Add(CreateSyncContactCommunicationsMethod());
			Methods.Add(CreateSyncAccountCommunicationsMethod());
			Methods.Add(CreateAddContacAddressMethod());
			Methods.Add(CreateAddAccountAddressMethod());
			Methods.Add(CreateIsAddressExistsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3c6ecdc6-bc79-4245-a9cc-a34cb13e3cc3"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("44f94bf0-4527-4bb4-ac7e-a66ed2ff2653"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("86b4ee06-6bcf-45c0-ab44-66865e38fa0d"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
		}

		protected virtual SchemaMethod CreateProcessAccountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7194e5eb-0600-4b2b-86c7-7401514d65b6"),
				Name = "ProcessAccount",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,83,201,110,131,48,16,61,195,87,184,57,17,41,226,7,162,30,82,178,8,169,74,212,166,237,221,129,33,177,100,236,200,75,82,84,229,223,59,38,152,37,34,39,240,99,222,50,227,97,99,89,78,104,150,73,43,76,154,147,87,242,14,52,95,248,243,60,60,72,201,73,166,128,26,104,80,172,73,250,231,157,248,176,148,179,130,101,212,48,41,230,225,133,42,175,136,181,2,174,228,11,148,162,90,22,38,78,164,40,216,209,170,186,52,110,20,162,111,13,10,191,8,200,28,60,109,92,27,141,213,47,211,70,163,82,65,185,134,121,200,10,18,181,129,227,84,175,202,179,169,162,233,148,252,133,65,191,145,13,118,22,111,225,234,158,17,106,222,8,32,191,87,213,10,55,231,120,13,38,59,173,149,44,151,111,157,131,99,214,158,47,3,90,109,231,224,193,108,106,52,24,140,176,211,119,227,12,188,121,252,252,203,30,204,18,138,68,114,91,138,31,202,45,104,23,63,232,242,7,10,140,85,194,97,62,155,54,138,137,35,78,99,107,57,223,169,251,76,122,57,182,180,132,193,136,98,135,12,175,219,33,190,217,81,189,62,245,46,230,131,220,66,12,93,103,245,69,51,50,217,93,5,40,125,98,231,52,159,204,106,163,22,193,126,70,8,169,200,45,26,87,109,189,7,198,203,155,216,9,142,255,40,123,172,7,124,156,140,29,113,89,1,96,131,229,1,84,75,126,192,159,56,11,129,43,255,9,23,16,22,58,223,62,138,196,246,62,233,5,220,13,238,43,145,249,108,178,44,173,104,254,24,29,117,59,129,101,79,54,103,145,251,198,240,77,129,214,253,21,253,7,108,243,11,33,198,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4296bf57-0225-4b64-95fe-60bd8aaaea6b"),
				Name = "SetValue",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5c388a48-f5cf-4d1f-bbfc-c91b2053934b"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a6ef6811-9020-4a4d-8757-7b1bdd89267b"),
				Name = "valueName",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b8a1b0c7-b023-4f0d-bd4f-3debae11e7cc"),
				Name = "value",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Object",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,203,76,83,208,112,47,205,76,209,115,205,45,40,169,212,115,45,44,77,204,41,214,40,75,204,41,77,213,212,84,168,230,226,4,51,21,108,21,242,74,115,114,172,185,106,185,82,243,74,50,129,10,131,83,75,156,243,115,74,115,243,194,64,242,16,13,126,137,185,169,58,10,16,189,214,0,45,199,129,174,89,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateProcessContactMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("44a20dbd-1c99-4ff3-948f-6b89c23345d0"),
				Name = "ProcessContact",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,75,110,194,48,16,93,147,83,184,172,130,132,114,1,212,69,155,20,68,85,81,169,161,221,187,206,132,90,138,109,52,182,65,168,226,238,181,157,56,9,82,88,116,21,251,125,198,243,38,179,177,188,34,76,73,67,153,217,86,228,145,188,1,173,242,120,95,37,39,138,145,118,164,132,51,217,3,34,213,170,54,153,147,213,252,96,145,26,174,100,214,153,210,79,13,232,206,18,152,135,23,171,68,27,228,242,16,171,236,168,128,219,103,60,178,74,120,77,210,190,143,108,171,95,196,209,92,210,197,130,252,38,51,207,61,180,101,28,179,179,77,243,142,45,63,42,218,74,103,227,44,27,23,46,219,193,217,127,83,215,73,207,102,37,152,2,234,92,53,86,200,47,218,88,208,183,124,176,179,97,12,179,43,129,70,67,120,1,193,88,148,30,75,58,52,244,23,173,107,48,236,103,141,74,20,207,67,160,182,185,232,188,38,255,72,20,235,118,131,99,227,161,93,147,124,20,119,212,175,203,23,98,197,114,75,50,47,128,226,124,25,6,239,143,139,73,209,171,250,222,115,211,64,39,92,187,198,34,52,109,40,221,221,132,5,216,95,142,176,173,58,227,0,223,125,167,215,186,243,180,168,128,35,69,35,64,154,94,59,64,211,150,13,200,10,176,151,183,215,123,213,25,215,174,193,15,213,192,168,254,0,58,91,156,125,216,116,20,224,167,108,208,194,192,148,244,4,126,117,202,139,100,221,191,200,149,16,86,114,22,226,235,116,88,41,39,123,170,186,173,119,7,4,125,203,254,1,86,71,26,106,140,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSyncContactCommunicationsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("234f41ed-2721-40f9-8ad1-4155addd81c3"),
				Name = "SyncContactCommunications",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b6a91fab-21a7-4075-adab-1a9161a98693"),
				Name = "contactId",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,147,81,111,218,48,16,199,159,147,79,225,242,228,72,147,181,119,74,165,65,88,133,198,58,52,216,250,48,237,193,36,71,177,150,216,157,237,148,70,19,223,125,103,59,180,9,36,170,180,73,72,36,246,221,255,126,119,255,75,42,50,43,148,228,186,190,190,173,68,254,142,24,171,133,124,184,33,5,240,124,166,202,178,146,34,227,46,196,144,9,145,112,32,233,64,6,77,198,177,216,17,122,21,222,217,194,220,85,69,241,69,207,203,71,91,211,37,202,77,43,35,36,24,179,218,43,9,73,66,254,196,209,101,149,31,174,134,19,166,157,243,77,253,8,51,188,182,134,221,43,253,203,75,44,242,228,39,66,93,72,143,227,227,27,36,159,213,86,20,240,159,28,45,145,22,73,235,244,109,142,121,201,69,241,239,4,62,189,85,219,191,187,170,107,40,32,179,4,158,133,177,88,249,174,42,183,160,79,6,134,75,250,205,128,70,29,9,222,206,36,142,216,76,21,85,41,233,40,132,143,220,209,71,173,74,58,194,48,203,51,219,193,240,215,247,123,208,240,114,191,200,71,9,54,57,255,93,241,130,6,49,182,226,154,151,96,65,211,236,20,132,253,114,211,80,140,227,37,34,94,159,150,46,235,20,234,172,93,59,206,173,154,51,252,129,208,116,58,127,134,172,178,74,147,124,251,242,56,33,221,238,216,92,154,74,67,58,125,61,162,97,236,141,204,34,229,150,127,197,17,130,38,58,252,77,206,199,199,130,60,132,48,250,90,46,73,80,40,58,236,209,119,66,67,54,115,65,77,137,40,234,107,139,125,200,243,83,240,45,216,181,239,140,190,79,216,70,45,213,1,245,19,108,50,138,142,49,254,142,97,74,159,160,254,206,139,10,86,92,232,238,183,231,38,215,94,157,141,90,215,50,195,22,250,246,170,113,77,146,201,13,185,234,69,243,126,10,105,168,100,190,96,139,201,243,33,140,179,96,167,144,63,219,19,58,12,214,229,34,66,246,130,250,49,61,113,125,230,127,147,20,252,239,219,193,243,29,198,129,245,41,176,53,216,20,118,97,35,61,168,161,131,177,193,108,44,218,1,13,115,24,202,185,248,62,23,249,133,0,206,104,56,189,249,50,124,82,243,60,216,11,127,2,71,127,252,11,57,252,38,237,186,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSyncAccountCommunicationsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("27a03f5a-1438-4ae9-a779-d2f9955dee17"),
				Name = "SyncAccountCommunications",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8557cb9d-31d3-4eec-beaf-715049caeaec"),
				Name = "accountId",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,77,107,219,64,16,61,75,191,98,227,211,10,202,210,187,227,64,108,57,193,212,77,77,237,52,135,210,195,90,26,199,11,210,110,186,31,177,77,241,127,239,172,86,114,172,88,34,208,130,64,210,238,204,123,111,102,222,164,34,179,66,73,174,15,215,247,78,228,159,136,177,90,200,231,27,82,0,207,39,170,44,157,20,25,247,33,134,140,136,132,29,73,123,50,104,50,140,197,134,208,171,240,207,102,230,193,21,197,55,61,45,95,236,129,206,17,110,236,140,144,96,204,98,171,36,36,9,249,19,71,151,44,63,61,135,7,166,173,243,213,225,5,38,120,109,13,251,202,133,172,32,102,121,242,11,69,93,64,15,227,227,7,74,238,248,254,223,249,49,249,140,25,255,62,230,123,130,181,17,246,63,106,70,128,51,206,26,206,243,46,161,128,204,18,216,11,99,145,251,193,149,107,208,205,168,194,37,125,52,160,17,71,66,53,184,36,142,216,68,21,174,148,116,16,194,7,254,232,78,171,146,14,110,179,76,57,105,91,50,170,235,167,45,104,56,221,207,242,65,130,101,78,127,59,94,208,0,198,22,92,243,18,44,104,202,155,32,172,151,155,90,197,48,158,163,196,235,198,94,153,146,150,103,13,81,203,96,231,113,222,84,126,180,207,132,166,227,233,30,50,103,149,38,249,250,244,57,34,237,234,216,84,26,167,33,29,191,29,209,208,246,26,102,150,114,203,191,99,19,65,19,29,94,163,247,237,99,1,30,66,24,125,163,75,18,4,138,118,91,81,0,161,33,155,249,160,154,34,138,186,202,98,183,121,222,4,223,131,93,86,149,209,207,9,91,169,185,218,33,126,130,69,70,209,49,198,231,24,186,244,5,14,63,120,225,96,193,133,110,111,153,239,220,185,117,86,106,121,144,25,150,208,229,171,122,106,146,140,110,200,85,167,180,137,63,20,210,80,201,42,194,51,77,149,62,20,227,71,176,81,168,63,219,18,218,47,172,173,139,8,217,41,180,106,211,43,215,132,119,24,173,158,127,151,7,223,123,24,27,214,133,192,150,96,83,216,4,71,86,66,13,237,141,13,195,70,210,150,208,208,135,190,156,139,253,156,229,23,0,216,163,190,244,211,250,96,210,105,75,122,107,225,175,224,213,31,255,2,174,157,147,242,164,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddContacAddressMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cd18d00b-aa43-475e-ae43-9ecf1f939583"),
				Name = "AddContacAddress",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0ddfb326-8961-4ab4-8126-049433cf4cc8"),
				Name = "contactId",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,77,79,132,48,16,61,111,127,197,132,195,6,18,178,251,3,54,30,12,238,129,196,104,226,170,7,111,13,12,107,35,20,210,150,85,98,252,239,14,20,144,175,224,30,223,204,123,51,125,175,35,18,112,239,145,199,183,113,172,80,235,231,170,192,93,168,143,89,97,42,215,131,237,22,216,102,83,247,3,97,170,197,198,19,158,69,46,151,53,121,41,141,154,203,78,70,9,121,166,242,67,153,166,143,202,54,107,193,155,40,254,229,180,15,245,60,248,102,27,133,166,84,242,192,126,216,126,31,188,99,244,1,66,3,183,12,224,169,34,126,5,248,37,180,209,76,144,211,80,183,242,99,83,115,105,145,19,228,210,240,200,180,13,199,135,65,49,140,45,142,58,232,119,222,6,121,249,195,140,252,113,46,254,36,139,30,147,213,233,172,5,75,100,192,32,180,219,123,99,137,202,51,168,133,236,194,85,215,109,135,192,13,72,252,132,177,41,247,69,163,162,146,196,200,208,163,188,3,27,139,118,39,52,119,152,4,121,90,102,242,149,167,37,106,151,72,84,109,128,59,102,251,224,12,220,55,17,77,18,89,213,214,41,245,162,26,172,178,109,140,61,223,194,245,249,54,233,191,21,22,175,106,232,55,90,118,125,130,87,56,31,123,158,7,218,223,15,253,71,127,60,243,216,249,5,41,232,95,63,222,231,250,132,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddAccountAddressMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c1936540-1ff1-47e9-8013-34aeccc38053"),
				Name = "AddAccountAddress",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2d48371a-4f61-405e-9589-e551c3d14f9d"),
				Name = "accountId",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,77,79,132,48,16,61,111,127,197,132,195,6,146,102,247,7,108,60,108,112,15,36,70,19,87,61,120,107,96,88,27,161,144,182,172,18,227,127,183,165,128,124,5,61,190,153,247,102,230,189,150,167,224,223,33,75,142,73,34,81,169,167,186,196,93,164,78,121,169,107,63,128,237,22,200,102,99,251,33,215,245,98,227,17,47,188,16,203,154,162,18,90,206,101,103,45,185,184,152,242,125,149,101,15,210,53,173,224,149,151,127,114,218,67,131,0,190,200,70,162,174,164,56,144,111,178,223,135,111,24,191,3,87,192,28,3,88,38,13,191,6,252,228,74,43,194,141,211,72,181,242,83,83,243,205,34,239,24,199,246,206,182,225,81,24,20,163,196,97,214,65,218,121,27,228,69,135,25,209,113,46,116,146,69,143,141,213,233,172,5,75,198,128,70,104,183,247,198,82,89,228,96,133,228,202,100,215,109,135,192,13,8,252,128,177,41,255,89,161,12,11,33,48,214,230,168,224,64,198,162,221,25,245,45,166,97,145,85,185,120,97,89,133,202,55,36,83,109,128,63,102,83,240,6,238,155,136,38,137,172,106,109,74,189,200,130,85,182,139,177,231,59,184,62,223,37,253,187,194,225,85,141,121,141,150,109,191,224,63,156,143,61,207,3,237,255,143,121,143,254,243,204,99,103,87,52,65,255,0,163,166,142,59,132,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsAddressExistsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3d37119b-b810-4927-95c8-ffee3a0a27c7"),
				Name = "IsAddressExists",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("258a6dc1-5e41-4901-addf-a7af2fe52b05"),
				Name = "addressTableName",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("da2d55bf-4fbf-4838-a333-05200575d3ac"),
				Name = "relationColumnName",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3a752f8e-a144-4878-bd56-30da77de8d1c"),
				Name = "relationColumnValue",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ea2df1f1-d4c9-4d49-bc75-bf54b8eef7a9"),
				Name = "addressType",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f7502380-4bd6-48e2-909f-b7c1c545fe6d"),
				Name = "addressCity",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3a0fc0f1-64cc-4b3e-9d9e-d9158c5206c4"),
				Name = "addressRegion",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f62327f0-975d-4954-a7e0-337e6ffc6ad2"),
				Name = "addressCountry",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("18230e13-130e-493d-aa00-f8182b70c96e"),
				Name = "zipValue",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f8dc2466-bd41-44ed-aad4-e3b32f147719"),
				Name = "addressValue",
				CreatedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				ModifiedInSchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("72a81799-379a-47fd-98a2-863474ed2379")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,91,111,218,48,24,125,54,191,194,229,161,114,164,202,108,207,136,135,22,216,132,180,117,91,75,55,105,111,134,124,5,75,142,205,124,25,99,19,255,125,118,236,132,36,176,54,123,138,253,93,206,57,223,197,249,201,52,102,121,174,193,152,71,16,176,182,120,130,37,236,113,188,144,39,3,122,170,164,244,103,174,100,54,64,116,170,132,43,36,25,126,231,187,97,243,126,27,65,74,219,59,173,10,146,80,151,108,37,224,158,21,16,28,223,182,160,129,104,16,44,192,197,212,210,71,23,102,254,195,49,65,162,141,126,102,218,155,45,232,78,240,87,38,28,100,25,102,38,41,28,15,6,252,25,147,171,138,237,176,131,128,85,236,236,129,248,184,63,3,212,170,142,222,202,188,214,26,130,23,249,240,5,242,6,106,150,141,7,199,22,215,148,219,195,235,92,33,170,23,73,8,60,39,121,128,141,47,254,117,154,24,215,139,40,134,94,168,71,57,105,117,159,146,98,96,191,170,98,108,100,91,41,37,240,90,21,59,166,193,239,143,95,181,103,38,12,140,163,140,71,171,185,220,120,196,123,39,196,39,29,69,252,230,187,106,230,94,76,117,243,153,213,145,46,213,7,181,247,132,25,93,106,94,16,79,132,250,194,161,150,22,171,157,151,130,142,29,161,105,89,250,136,77,53,55,24,154,22,143,208,188,254,159,240,115,104,116,166,175,81,128,51,30,2,147,217,221,252,23,172,157,85,26,231,171,250,56,193,237,103,77,231,210,56,13,179,187,147,41,13,63,193,44,102,204,178,7,96,57,104,172,227,103,210,254,107,208,8,14,49,136,156,200,146,214,209,104,9,198,98,96,235,109,149,72,189,121,191,229,2,48,137,152,52,36,39,98,132,76,217,133,48,102,207,149,2,222,131,141,205,33,111,178,75,237,171,179,88,221,147,179,204,183,255,200,44,71,238,217,62,50,235,53,214,195,174,60,9,241,220,59,26,125,113,220,226,253,22,100,77,203,13,46,152,221,6,119,152,104,99,203,174,175,113,212,241,100,185,224,150,131,161,229,251,49,139,141,84,26,166,204,64,216,209,27,220,89,84,132,26,210,210,156,145,159,116,219,113,58,78,26,207,108,220,209,81,45,76,31,45,169,162,27,124,97,255,16,234,52,165,173,171,227,108,95,39,157,215,85,107,172,75,240,234,154,41,21,165,6,235,180,108,83,29,227,206,39,87,28,205,95,137,231,50,148,216,6,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementQualification(userConnection);
		}

		public override object Clone() {
			return new LeadManagementQualificationSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementQualification

	/// <exclude/>
	public class LeadManagementQualification : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadQualification

		/// <exclude/>
		public class ProcessLeadQualification : ProcessLane
		{

			public ProcessLeadQualification(UserConnection userConnection, LeadManagementQualification process)
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

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementQualification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadData";
				IsLogging = true;
				SchemaElementUId = new Guid("8bf25d2e-0f4c-4ed1-b885-635952f9e063");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,36,21,219,146,45,201,61,46,219,178,80,210,64,211,82,72,150,48,146,70,89,129,63,54,182,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,209,104,222,155,55,143,209,124,31,198,143,161,137,56,212,30,154,17,233,180,115,53,81,50,171,148,45,21,227,86,35,19,185,171,152,66,101,24,47,164,41,84,174,140,178,64,104,7,45,214,100,69,111,93,136,132,134,136,237,88,223,206,191,73,227,48,33,189,247,231,203,87,123,192,22,190,45,13,68,14,94,105,212,76,150,153,97,2,141,97,137,210,50,239,185,54,149,80,34,71,75,86,45,168,185,149,214,8,230,164,45,153,240,94,50,237,83,169,54,170,244,186,200,115,144,21,161,13,250,184,125,58,14,56,142,161,239,234,25,95,227,155,231,99,82,185,246,222,244,205,212,118,132,182,24,225,26,226,161,38,128,25,138,210,2,179,66,47,236,40,25,112,237,24,7,35,11,169,48,175,114,73,168,133,99,92,104,201,206,17,234,32,194,119,104,38,60,51,207,33,105,44,120,150,171,178,74,216,156,91,38,120,145,49,85,41,201,188,171,188,70,94,105,109,220,197,175,79,83,72,113,24,175,166,22,135,96,95,108,199,228,95,63,212,179,237,187,56,244,205,66,125,117,46,191,193,167,184,154,251,242,244,99,29,40,166,252,2,34,39,58,141,184,105,2,118,113,219,217,222,133,238,97,229,60,157,18,164,61,194,16,198,139,11,219,199,9,26,66,135,240,112,248,163,91,155,105,140,125,251,31,141,74,211,152,137,35,45,217,89,238,178,131,46,140,199,6,158,207,247,154,188,123,156,250,248,225,51,130,91,35,242,6,81,147,59,34,29,112,199,181,96,182,52,69,218,5,3,204,160,144,76,10,9,89,230,120,165,74,188,35,73,197,63,112,223,238,198,47,63,187,203,31,88,85,239,223,167,236,155,196,245,5,89,207,127,35,231,180,95,4,237,79,233,252,2,53,129,193,231,202,3,0,0 })));
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

		#region Class: ChangeContactAccountFlowElement

		/// <exclude/>
		public class ChangeContactAccountFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeContactAccountFlowElement(UserConnection userConnection, LeadManagementQualification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeContactAccount";
				IsLogging = true;
				SchemaElementUId = new Guid("304c2e1a-af0b-4016-a95f-ee471f292c6e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Account = () => (Guid)((process.AccountId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Account", () => _recordColumnValues_Account.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Account;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,43,65,135,158,60,197,178,100,91,118,143,203,182,236,37,77,105,90,2,73,8,35,105,148,21,248,99,99,203,52,193,236,127,175,188,206,182,144,67,233,161,151,130,14,210,72,239,205,123,143,209,252,224,199,143,190,9,52,212,14,155,145,146,105,103,107,166,114,237,164,171,50,112,156,19,72,41,16,116,90,57,176,174,212,28,93,37,181,40,89,210,97,75,53,91,209,91,235,3,75,124,160,118,172,111,231,223,164,97,152,40,121,112,167,195,87,179,167,22,191,45,13,120,161,73,20,57,7,229,40,3,201,243,10,148,181,41,160,74,133,149,133,18,214,10,182,106,113,133,205,172,174,16,82,165,11,144,70,58,64,148,6,156,206,164,70,99,140,83,81,75,67,46,108,159,15,3,141,163,239,187,122,166,95,251,235,151,67,84,185,246,222,244,205,212,118,44,105,41,224,21,134,125,205,144,82,146,185,65,48,178,202,65,58,42,1,69,101,65,160,46,179,82,17,47,120,100,55,120,8,11,45,219,89,150,88,12,248,29,155,137,78,204,179,143,26,51,145,114,149,23,17,203,133,1,41,178,20,84,161,74,112,182,112,85,52,90,85,218,158,243,250,52,249,184,247,227,229,212,210,224,205,107,236,20,243,235,135,122,54,125,23,134,190,89,168,47,79,207,175,233,57,172,225,190,94,221,172,134,66,172,47,32,118,76,166,145,54,141,167,46,108,59,211,91,223,61,174,156,199,99,132,180,7,28,252,120,78,97,251,52,97,195,146,193,63,238,255,152,214,102,26,67,223,254,71,86,147,104,51,114,196,33,59,201,93,102,208,250,241,208,224,203,233,92,179,119,79,83,31,62,124,137,246,189,243,100,47,112,188,88,154,160,9,235,13,123,195,80,179,59,150,113,151,10,202,45,112,93,42,144,202,26,136,14,83,224,70,69,175,113,50,164,82,119,44,170,250,7,189,110,119,227,231,31,221,249,143,172,174,238,223,199,234,155,194,213,25,89,207,127,35,239,120,191,8,188,63,198,245,19,156,38,180,91,234,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,203,110,219,48,16,252,21,131,201,209,52,72,74,212,235,90,183,128,129,164,117,155,52,23,219,135,21,185,76,12,200,146,65,74,109,83,67,255,94,138,150,107,59,109,47,229,129,132,118,57,51,203,157,213,129,220,182,175,123,36,5,121,68,107,193,53,166,157,189,107,44,206,150,182,81,232,220,236,174,81,80,109,127,66,89,225,18,44,236,176,69,251,4,85,135,238,110,235,218,233,228,26,70,166,228,246,91,200,146,98,117,32,139,22,119,95,23,218,179,39,130,43,4,204,41,23,105,78,99,166,37,45,1,57,77,208,0,98,84,34,64,236,193,170,169,186,93,125,143,45,44,161,125,33,197,129,4,54,79,32,85,162,128,51,164,156,103,140,198,138,35,205,64,50,42,37,164,194,152,188,212,58,38,253,148,56,245,130,59,8,162,103,48,79,74,140,18,201,105,102,80,208,152,203,156,102,90,51,10,25,139,116,156,100,145,214,209,0,30,239,159,129,171,155,213,194,125,250,94,163,125,8,188,133,129,202,225,102,230,163,111,2,191,155,83,28,64,27,227,73,13,149,105,38,105,44,162,140,66,158,8,42,188,20,36,218,228,130,165,253,230,102,51,40,234,173,219,87,240,250,244,167,240,231,206,247,221,108,81,79,192,77,64,169,166,171,219,35,102,127,229,195,37,234,176,62,218,185,38,197,250,95,134,142,231,177,252,107,75,223,186,185,38,211,53,121,104,58,171,6,198,104,248,56,117,55,40,176,113,209,191,108,167,117,228,8,176,123,168,225,25,237,71,175,24,224,33,53,135,22,130,248,163,175,251,68,92,138,92,178,148,27,154,34,248,105,65,223,188,76,115,160,57,207,75,19,165,145,55,92,4,244,23,52,104,177,86,120,93,152,144,58,85,28,74,202,53,250,97,145,140,211,50,102,130,50,129,12,135,129,209,201,241,113,65,249,92,204,105,240,124,164,238,170,42,8,184,240,254,97,146,199,194,199,204,252,194,185,11,134,70,7,211,22,245,127,182,106,142,38,80,126,104,236,251,31,254,15,219,214,207,163,99,23,210,231,59,115,181,27,227,61,233,251,77,255,11,70,60,179,216,208,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "4e764f9106384bdbb584bf89b9bf3645",
							"BaseElements.ChangeContactAccount.Parameters.RecordColumnValues.Value");
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

		#region Class: ChangeLeadStageDistributionFlowElement

		/// <exclude/>
		public class ChangeLeadStageDistributionFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadStageDistributionFlowElement(UserConnection userConnection, LeadManagementQualification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadStageDistribution";
				IsLogging = true;
				SchemaElementUId = new Guid("2b2b8a21-5d60-4170-a9eb-caa404a44b84");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("14cfc644-e3ed-497e-8279-ed4319bb8093"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,36,21,91,146,45,203,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,153,145,222,155,55,143,209,124,239,195,71,223,70,28,107,7,109,64,58,237,108,77,184,226,34,47,141,98,152,75,203,164,212,142,85,156,75,86,104,206,185,145,69,46,120,65,104,15,29,214,100,69,111,173,143,132,250,136,93,168,111,231,223,164,113,156,144,222,187,115,242,213,28,176,131,111,75,3,153,131,171,52,106,166,138,172,97,18,155,134,85,6,12,115,78,232,166,148,149,204,209,144,85,139,146,218,100,188,116,12,178,204,49,89,186,20,85,166,96,214,136,194,128,179,153,85,72,104,139,46,110,159,142,35,134,224,135,190,158,241,53,190,121,62,38,149,107,239,205,208,78,93,79,104,135,17,174,33,30,106,2,152,161,76,60,204,72,93,48,233,80,49,16,218,50,1,141,226,170,194,188,204,21,161,6,142,113,161,37,59,75,168,133,8,223,161,157,240,204,60,251,197,47,145,229,85,81,38,108,46,12,147,130,103,172,42,43,197,156,45,157,70,81,106,221,216,139,95,159,38,159,98,31,174,166,14,71,111,94,108,199,228,223,48,214,179,25,250,56,14,237,66,125,117,126,126,131,79,113,53,247,229,234,199,58,80,76,245,5,68,78,116,10,184,105,61,246,113,219,155,193,250,254,97,229,60,157,18,164,59,194,232,195,197,133,237,227,4,45,161,163,127,56,252,209,173,205,20,226,208,253,71,163,210,52,102,226,72,75,118,150,187,236,160,245,225,216,194,243,57,175,201,187,199,105,136,31,62,35,216,53,34,111,16,53,185,35,202,130,176,66,75,102,138,134,167,93,104,128,53,40,21,83,82,165,221,179,162,172,10,188,35,73,197,63,112,223,238,194,151,159,253,229,15,172,170,247,239,83,245,77,225,250,130,172,231,191,145,115,218,47,130,246,167,116,126,1,123,109,74,170,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,95,111,218,48,20,197,191,202,228,246,17,71,137,237,216,49,175,99,149,144,232,132,70,215,151,210,135,107,231,186,141,26,18,228,36,211,58,196,119,159,49,65,192,180,74,211,252,144,200,127,126,231,92,223,227,29,185,237,223,183,72,166,228,1,189,135,174,117,125,242,185,245,152,44,125,107,177,235,146,69,107,161,174,126,129,169,113,9,30,54,216,163,127,132,122,192,110,81,117,253,228,211,53,70,38,228,246,71,220,37,211,167,29,153,247,184,249,62,47,131,122,94,74,151,51,5,212,228,76,80,81,88,77,65,155,130,58,163,180,112,168,114,45,84,128,109,91,15,155,230,30,123,88,66,255,74,166,59,18,213,130,128,177,169,101,165,76,105,14,188,12,2,34,165,0,2,169,149,41,130,82,18,89,42,201,126,66,58,251,138,27,136,166,103,88,100,224,10,141,154,170,60,53,84,160,49,180,176,96,169,115,92,27,25,196,50,180,7,120,60,127,6,159,110,22,109,251,54,108,19,198,184,200,108,153,209,220,112,78,133,13,246,58,205,50,42,157,146,154,163,147,40,68,146,9,235,172,20,130,34,199,80,163,86,72,11,166,52,197,82,240,76,27,83,164,154,223,60,31,140,202,170,219,214,240,254,248,161,223,170,135,23,76,102,161,197,190,50,67,95,181,205,17,220,94,101,112,137,238,214,199,40,215,100,186,254,40,204,241,191,138,61,186,142,243,207,36,215,100,178,38,171,118,240,246,160,200,15,147,83,103,163,67,58,14,250,151,207,105,28,53,34,118,15,77,184,144,255,26,28,35,30,183,102,208,67,52,127,8,117,159,132,13,211,121,170,50,71,21,130,14,89,73,70,139,50,3,170,67,7,29,87,156,57,199,34,253,13,29,122,108,44,94,23,246,47,73,69,62,58,159,139,57,61,186,176,210,12,117,29,13,186,120,255,195,43,30,11,31,119,102,23,241,93,40,180,101,229,42,44,231,205,127,182,106,134,46,74,222,181,254,203,207,16,125,213,188,140,137,93,88,159,207,204,236,102,92,223,147,253,254,121,255,27,225,101,147,76,204,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "4e764f9106384bdbb584bf89b9bf3645",
							"BaseElements.ChangeLeadStageDistribution.Parameters.RecordColumnValues.Value");
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

		#region Class: LinkContactToLeadFlowElement

		/// <exclude/>
		public class LinkContactToLeadFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public LinkContactToLeadFlowElement(UserConnection userConnection, LeadManagementQualification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LinkContactToLead";
				IsLogging = true;
				SchemaElementUId = new Guid("9da5af0d-7621-41eb-8e00-f682895bb04e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)((process.ContactId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,100,21,219,146,45,201,61,46,219,178,80,210,64,211,82,72,150,48,146,70,89,129,63,54,150,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,153,145,222,155,55,143,209,124,239,195,71,223,70,28,27,7,109,192,108,218,217,134,228,224,74,199,164,166,214,212,21,229,70,20,84,114,91,81,109,21,230,170,174,141,150,154,100,61,116,216,144,21,189,181,62,146,204,71,236,66,115,59,255,38,141,227,132,217,189,59,39,95,205,1,59,248,182,52,224,5,56,169,80,81,81,229,154,114,212,154,74,3,134,58,199,148,174,185,228,5,26,178,106,209,104,20,171,77,78,157,72,239,185,41,144,202,138,139,37,5,174,36,215,133,96,36,107,209,197,237,211,113,196,16,252,208,55,51,190,198,55,207,199,164,114,237,189,25,218,169,235,73,214,97,132,107,136,135,134,0,230,200,43,3,212,112,149,38,117,40,40,48,101,41,3,45,74,33,177,168,11,65,50,3,199,184,208,146,157,37,153,133,8,223,161,157,240,204,60,251,164,177,100,121,33,171,58,97,11,102,40,103,101,78,101,45,147,70,91,59,133,172,86,74,219,139,95,159,38,159,98,31,174,166,14,71,111,94,108,199,228,223,48,54,179,25,250,56,14,237,66,125,117,126,126,131,79,113,53,247,229,234,199,58,80,76,245,5,68,78,217,20,112,211,122,236,227,182,55,131,245,253,195,202,121,58,37,72,119,132,209,135,139,11,219,199,9,90,146,141,254,225,240,71,183,54,83,136,67,247,31,141,154,165,49,19,71,90,178,179,220,101,7,173,15,199,22,158,207,121,67,222,61,78,67,252,240,25,193,174,17,121,131,104,200,29,17,22,152,101,138,83,83,233,50,237,130,6,170,49,109,154,224,2,242,220,178,90,86,120,71,146,138,127,224,190,221,133,47,63,251,203,31,88,85,239,223,167,234,155,194,245,5,217,204,127,35,231,180,95,4,237,79,233,252,2,68,233,196,17,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,81,111,219,32,20,133,255,74,68,251,24,34,99,192,6,191,46,155,20,169,221,178,181,235,75,146,135,11,92,218,72,142,29,217,206,182,46,242,127,31,33,206,146,116,219,203,120,176,229,11,223,57,23,14,222,147,219,238,117,139,164,32,143,216,52,208,214,190,155,188,171,27,156,204,155,218,98,219,78,238,106,11,229,250,39,152,18,231,208,192,6,59,108,158,160,220,97,123,183,110,187,241,232,26,35,99,114,251,45,206,146,98,177,39,179,14,55,95,103,46,168,167,70,176,92,72,71,185,178,154,10,48,72,181,180,138,38,153,101,10,133,100,82,186,0,219,186,220,109,170,123,236,96,14,221,11,41,246,36,170,5,1,112,66,39,78,6,66,10,160,194,41,73,117,42,50,234,156,18,89,134,134,107,197,73,63,38,173,125,193,13,68,211,51,44,24,120,165,81,211,92,38,134,10,52,134,42,11,150,122,207,181,201,132,18,12,237,1,30,214,159,193,197,205,98,214,126,250,94,97,243,16,117,11,15,101,139,171,73,168,190,41,252,62,156,98,159,50,159,112,12,123,101,38,87,84,40,103,169,70,158,80,102,85,230,53,203,152,80,170,95,221,172,14,142,110,221,110,75,120,125,250,211,248,243,46,156,187,95,163,27,65,59,178,117,213,129,237,142,204,246,42,135,75,106,191,60,198,185,36,197,242,95,129,14,239,99,251,215,145,190,77,115,73,198,75,242,80,239,26,123,80,228,135,143,211,233,70,135,100,24,244,47,143,211,56,106,68,236,30,42,120,198,230,99,112,140,120,156,154,66,7,209,252,49,244,125,18,54,169,150,73,206,60,205,17,194,109,193,44,165,202,49,160,154,105,227,121,206,83,239,211,72,127,65,143,13,86,22,175,27,99,153,65,158,73,70,149,199,148,10,38,117,224,93,66,65,37,220,137,76,113,231,120,228,163,243,185,153,211,197,11,149,106,87,150,209,160,141,251,63,220,228,161,241,97,102,122,145,220,133,66,237,98,104,179,234,63,143,106,138,62,74,126,168,155,247,63,194,31,182,174,158,135,196,46,172,207,107,166,118,51,212,123,210,247,171,254,23,174,109,74,206,208,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "4e764f9106384bdbb584bf89b9bf3645",
							"BaseElements.LinkContactToLead.Parameters.RecordColumnValues.Value");
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

		#region Class: LinkAccountToLeadFlowElement

		/// <exclude/>
		public class LinkAccountToLeadFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public LinkAccountToLeadFlowElement(UserConnection userConnection, LeadManagementQualification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LinkAccountToLead";
				IsLogging = true;
				SchemaElementUId = new Guid("1337590d-7ee1-488b-b0db-de061f6759f5");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedAccount = () => (Guid)((process.AccountId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedAccount", () => _recordColumnValues_QualifiedAccount.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedAccount;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,77,107,220,48,16,253,47,58,244,36,21,127,72,150,229,30,151,109,89,40,105,160,105,41,36,75,24,73,163,172,192,31,27,75,166,9,102,255,123,229,117,54,133,28,74,233,173,160,195,204,72,239,205,155,199,104,190,247,225,163,111,35,142,141,131,54,32,157,118,182,33,89,94,91,13,218,177,66,229,150,113,172,53,211,174,54,76,85,142,231,89,230,180,118,72,104,15,29,54,100,69,111,173,143,132,250,136,93,104,110,231,223,164,113,156,144,222,187,115,242,213,28,176,131,111,75,3,158,131,171,21,42,38,69,166,83,3,173,89,109,192,48,231,74,165,43,94,243,28,13,89,181,8,237,138,42,43,37,43,100,101,24,183,66,49,45,92,197,140,116,5,26,93,24,1,130,208,22,93,220,62,29,71,12,193,15,125,51,227,107,124,243,124,76,42,215,222,155,161,157,186,158,208,14,35,92,67,60,52,4,48,67,46,12,48,195,149,96,220,161,100,80,42,203,74,208,178,144,53,230,85,46,9,53,112,140,11,45,217,89,66,45,68,248,14,237,132,103,230,217,39,141,69,153,28,19,85,194,230,101,210,88,22,25,171,171,90,50,103,43,167,176,172,148,210,246,226,215,167,201,167,216,135,171,169,195,209,155,23,219,49,249,55,140,205,108,134,62,142,67,187,80,95,157,159,223,224,83,92,205,125,185,250,177,14,20,83,125,1,145,19,157,2,110,90,143,125,220,246,102,176,190,127,88,57,79,167,4,233,142,48,250,112,113,97,251,56,65,75,232,232,31,14,127,116,107,51,133,56,116,255,209,168,52,141,153,56,210,146,157,229,46,59,104,125,56,182,240,124,206,27,242,238,113,26,226,135,207,8,118,141,200,27,68,67,238,136,180,80,218,82,113,102,132,46,210,46,104,96,26,185,100,146,75,200,50,91,86,181,192,59,146,84,252,3,247,237,46,124,249,217,95,254,192,170,122,255,62,85,223,20,174,47,200,102,254,27,57,167,253,34,104,127,74,231,23,52,11,173,221,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,193,110,219,48,12,253,149,64,237,49,10,108,89,178,45,95,151,13,8,208,110,217,218,245,146,228,64,73,84,27,192,177,3,217,222,214,5,254,247,201,138,179,36,221,118,153,14,18,76,234,189,71,241,209,7,114,219,190,238,145,20,228,17,157,131,166,182,237,236,93,237,112,182,116,181,198,166,153,221,213,26,202,237,79,80,37,46,193,193,14,91,116,79,80,118,216,220,109,155,118,58,185,134,145,41,185,253,22,178,164,88,29,200,162,197,221,215,133,241,236,89,198,101,108,35,160,92,171,140,242,36,85,84,42,140,40,211,185,180,90,9,3,54,242,96,93,151,221,174,186,199,22,150,208,190,144,226,64,2,155,39,72,152,228,18,144,83,107,227,132,242,220,10,42,173,48,148,11,200,184,16,57,130,16,164,159,146,70,191,224,14,130,232,25,204,99,176,185,68,73,51,17,41,202,81,41,154,107,208,158,43,145,42,229,57,143,81,15,224,241,254,25,184,186,89,45,154,79,223,43,116,15,129,183,176,80,54,184,153,249,232,155,192,239,230,20,7,48,214,242,52,183,84,100,185,160,156,37,57,5,153,50,202,12,79,33,53,86,178,40,235,55,55,155,65,209,108,155,125,9,175,79,127,10,127,238,124,223,237,22,205,4,154,9,104,93,119,85,123,196,236,175,124,184,68,29,214,71,59,215,164,88,255,203,208,241,60,150,127,109,233,91,55,215,100,186,38,15,117,231,244,192,152,12,31,167,238,6,133,104,92,244,47,219,105,29,57,2,236,30,42,120,70,247,209,43,6,120,72,205,161,133,32,254,232,235,62,17,43,38,69,148,197,150,102,8,210,251,229,155,151,155,24,168,140,165,178,73,150,48,107,89,64,127,65,139,14,43,141,215,133,49,97,50,29,131,162,177,241,51,198,69,20,83,197,35,70,35,134,17,250,129,97,38,61,62,46,40,159,139,57,13,158,143,84,93,89,6,129,38,188,127,152,228,177,240,49,51,191,112,238,130,161,54,193,180,69,245,159,173,154,163,13,148,31,106,247,254,135,255,195,182,213,243,232,216,133,244,249,206,92,239,198,120,79,250,126,211,255,2,14,63,30,86,208,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "4e764f9106384bdbb584bf89b9bf3645",
							"BaseElements.LinkAccountToLead.Parameters.RecordColumnValues.Value");
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

		#region Class: ReadSystemSettingsFlowElement

		/// <exclude/>
		public class ReadSystemSettingsFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadSystemSettingsFlowElement(UserConnection userConnection, LeadManagementQualification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadSystemSettings";
				IsLogging = true;
				SchemaElementUId = new Guid("a188ff27-c185-4b79-b24c-71503e5df1a6");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,213,82,77,107,220,48,20,252,43,69,135,158,172,32,75,178,100,187,167,178,108,161,151,52,101,211,82,40,37,60,75,79,89,129,191,98,201,144,101,217,255,94,217,206,182,208,67,33,199,128,14,250,120,243,102,222,140,206,15,62,124,242,109,196,169,118,208,6,204,230,207,182,38,18,148,180,85,83,209,70,138,134,202,188,82,180,196,28,40,54,165,150,40,28,203,49,39,89,15,29,214,100,67,239,173,143,36,243,17,187,80,255,60,255,109,26,167,25,179,7,183,30,14,230,136,29,124,91,8,170,34,111,120,211,52,148,53,32,168,100,178,162,21,240,196,87,88,105,88,163,108,193,28,217,180,112,93,42,205,139,130,114,206,28,149,70,26,90,149,82,209,194,228,172,178,74,11,180,146,100,45,186,184,127,30,39,12,193,15,125,125,198,63,251,251,211,152,84,110,220,187,161,157,187,158,100,29,70,184,131,120,172,9,115,22,149,203,49,117,55,5,149,165,209,180,50,101,69,149,99,76,228,200,53,179,120,147,11,0,91,72,73,209,8,70,37,106,69,65,104,65,29,51,206,9,206,56,242,36,193,192,24,23,110,114,56,133,228,195,187,128,49,250,254,241,102,55,88,36,153,133,8,223,161,157,113,213,115,246,105,50,193,11,208,162,41,41,115,82,83,41,129,209,82,230,156,106,197,148,211,101,18,0,230,234,242,225,56,76,241,30,159,23,147,195,237,220,225,228,205,75,98,152,172,31,166,250,108,134,62,78,67,187,244,191,93,49,75,249,150,203,203,211,143,205,139,152,238,23,16,185,100,115,192,93,235,177,143,251,222,12,54,169,93,3,187,92,18,162,27,97,242,225,234,223,254,105,134,150,100,147,127,60,254,215,231,59,152,18,119,10,251,141,77,156,141,87,225,171,228,229,19,91,31,198,22,78,235,185,38,239,159,230,33,126,216,77,8,17,63,26,51,204,125,252,210,127,77,166,120,231,13,44,193,111,21,228,159,78,175,64,94,126,93,210,250,13,237,231,240,99,146,3,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,11,174,44,14,78,45,41,201,204,75,47,182,50,180,50,212,241,76,177,50,176,50,0,0,176,83,7,250,22,0,0,0 })));
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
								new Guid("951b2bbb-0ba3-4049-9a29-b5d4c0b6d50f")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("951b2bbb-0ba3-4049-9a29-b5d4c0b6d50f"));
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

		public LeadManagementQualification(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementQualification";
			SchemaUId = new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_leadAddressType = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("AddressType").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AddressTypeId") : Guid.Empty))); };
			_leadCity = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("City").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("CityId") : Guid.Empty))); };
			_leadZip = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Zip").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Zip") : null))); };
			_leadRegion = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Region").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("RegionId") : Guid.Empty))); };
			_leadCountry = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Country").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("CountryId") : Guid.Empty))); };
			_leadWebsite = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Website").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Website") : null))); };
			_leadFax = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Fax").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Fax") : null))); };
			_leadBusinessPhone = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null))); };
			_leadEmail = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null))); };
			_leadMobilePhone = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null))); };
			_leadDecisionRole = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("DecisionRole").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("DecisionRoleId") : Guid.Empty))); };
			_leadGender = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Gender").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("GenderId") : Guid.Empty))); };
			_leadDepartment = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Department").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("DepartmentId") : Guid.Empty))); };
			_leadJob = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Job").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("JobId") : Guid.Empty))); };
			_leadSalutation = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("TitleId") : Guid.Empty))); };
			_leadDear = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Dear").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Dear") : null))); };
			_leadFullJobTitle = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("FullJobTitle").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("FullJobTitle") : null))); };
			_leadContactName = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Contact") : null))); };
			_leadAccountName = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Account") : null))); };
			_leadAnnualRevenue = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("AnnualRevenue").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AnnualRevenueId") : Guid.Empty))); };
			_leadEmployeesNumber = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("EmployeesNumber").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("EmployeesNumberId") : Guid.Empty))); };
			_leadAccountCategory = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("AccountCategory").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AccountCategoryId") : Guid.Empty))); };
			_leadIndustry = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Industry").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("IndustryId") : Guid.Empty))); };
			_leadOwnership = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("AccountOwnership").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AccountOwnershipId") : Guid.Empty))); };
			_leadAccountId = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty))); };
			_leadContactId = () => { return (Guid)(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty))); };
			_leadAddress = () => { return new LocalizableString(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Address").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Address") : null))); };
			_createAccountOnQualification = () => { return (bool)(((ReadSystemSettings.ResultEntity.IsColumnValueLoaded(ReadSystemSettings.ResultEntity.Schema.Columns.GetByName("BooleanValue").ColumnValueName) ? ReadSystemSettings.ResultEntity.GetTypedColumnValue<bool>("BooleanValue") : false))); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4e764f91-0638-4bdb-b584-bf89b9bf3645");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementQualification, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementQualification, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid LeadId {
			get;
			set;
		}

		public virtual Guid AccountId {
			get;
			set;
		}

		public virtual Guid ContactId {
			get;
			set;
		}

		private Func<Guid> _leadAddressType;
		public virtual Guid LeadAddressType {
			get {
				return (_leadAddressType ?? (_leadAddressType = () => Guid.Empty)).Invoke();
			}
			set {
				_leadAddressType = () => { return value; };
			}
		}

		private Func<Guid> _leadCity;
		public virtual Guid LeadCity {
			get {
				return (_leadCity ?? (_leadCity = () => Guid.Empty)).Invoke();
			}
			set {
				_leadCity = () => { return value; };
			}
		}

		private Func<string> _leadZip;
		public virtual string LeadZip {
			get {
				return (_leadZip ?? (_leadZip = () => null)).Invoke();
			}
			set {
				_leadZip = () => { return value; };
			}
		}

		private Func<Guid> _leadRegion;
		public virtual Guid LeadRegion {
			get {
				return (_leadRegion ?? (_leadRegion = () => Guid.Empty)).Invoke();
			}
			set {
				_leadRegion = () => { return value; };
			}
		}

		private Func<Guid> _leadCountry;
		public virtual Guid LeadCountry {
			get {
				return (_leadCountry ?? (_leadCountry = () => Guid.Empty)).Invoke();
			}
			set {
				_leadCountry = () => { return value; };
			}
		}

		private Func<string> _leadWebsite;
		public virtual string LeadWebsite {
			get {
				return (_leadWebsite ?? (_leadWebsite = () => null)).Invoke();
			}
			set {
				_leadWebsite = () => { return value; };
			}
		}

		private Func<string> _leadFax;
		public virtual string LeadFax {
			get {
				return (_leadFax ?? (_leadFax = () => null)).Invoke();
			}
			set {
				_leadFax = () => { return value; };
			}
		}

		private Func<string> _leadBusinessPhone;
		public virtual string LeadBusinessPhone {
			get {
				return (_leadBusinessPhone ?? (_leadBusinessPhone = () => null)).Invoke();
			}
			set {
				_leadBusinessPhone = () => { return value; };
			}
		}

		private Func<string> _leadEmail;
		public virtual string LeadEmail {
			get {
				return (_leadEmail ?? (_leadEmail = () => null)).Invoke();
			}
			set {
				_leadEmail = () => { return value; };
			}
		}

		private Func<string> _leadMobilePhone;
		public virtual string LeadMobilePhone {
			get {
				return (_leadMobilePhone ?? (_leadMobilePhone = () => null)).Invoke();
			}
			set {
				_leadMobilePhone = () => { return value; };
			}
		}

		private Func<Guid> _leadDecisionRole;
		public virtual Guid LeadDecisionRole {
			get {
				return (_leadDecisionRole ?? (_leadDecisionRole = () => Guid.Empty)).Invoke();
			}
			set {
				_leadDecisionRole = () => { return value; };
			}
		}

		private Func<Guid> _leadGender;
		public virtual Guid LeadGender {
			get {
				return (_leadGender ?? (_leadGender = () => Guid.Empty)).Invoke();
			}
			set {
				_leadGender = () => { return value; };
			}
		}

		private Func<Guid> _leadDepartment;
		public virtual Guid LeadDepartment {
			get {
				return (_leadDepartment ?? (_leadDepartment = () => Guid.Empty)).Invoke();
			}
			set {
				_leadDepartment = () => { return value; };
			}
		}

		private Func<Guid> _leadJob;
		public virtual Guid LeadJob {
			get {
				return (_leadJob ?? (_leadJob = () => Guid.Empty)).Invoke();
			}
			set {
				_leadJob = () => { return value; };
			}
		}

		private Func<Guid> _leadSalutation;
		public virtual Guid LeadSalutation {
			get {
				return (_leadSalutation ?? (_leadSalutation = () => Guid.Empty)).Invoke();
			}
			set {
				_leadSalutation = () => { return value; };
			}
		}

		private Func<string> _leadDear;
		public virtual string LeadDear {
			get {
				return (_leadDear ?? (_leadDear = () => null)).Invoke();
			}
			set {
				_leadDear = () => { return value; };
			}
		}

		private Func<string> _leadFullJobTitle;
		public virtual string LeadFullJobTitle {
			get {
				return (_leadFullJobTitle ?? (_leadFullJobTitle = () => null)).Invoke();
			}
			set {
				_leadFullJobTitle = () => { return value; };
			}
		}

		private Func<string> _leadContactName;
		public virtual string LeadContactName {
			get {
				return (_leadContactName ?? (_leadContactName = () => null)).Invoke();
			}
			set {
				_leadContactName = () => { return value; };
			}
		}

		private Func<string> _leadAccountName;
		public virtual string LeadAccountName {
			get {
				return (_leadAccountName ?? (_leadAccountName = () => null)).Invoke();
			}
			set {
				_leadAccountName = () => { return value; };
			}
		}

		private Func<Guid> _leadAnnualRevenue;
		public virtual Guid LeadAnnualRevenue {
			get {
				return (_leadAnnualRevenue ?? (_leadAnnualRevenue = () => Guid.Empty)).Invoke();
			}
			set {
				_leadAnnualRevenue = () => { return value; };
			}
		}

		private Func<Guid> _leadEmployeesNumber;
		public virtual Guid LeadEmployeesNumber {
			get {
				return (_leadEmployeesNumber ?? (_leadEmployeesNumber = () => Guid.Empty)).Invoke();
			}
			set {
				_leadEmployeesNumber = () => { return value; };
			}
		}

		private Func<Guid> _leadAccountCategory;
		public virtual Guid LeadAccountCategory {
			get {
				return (_leadAccountCategory ?? (_leadAccountCategory = () => Guid.Empty)).Invoke();
			}
			set {
				_leadAccountCategory = () => { return value; };
			}
		}

		private Func<Guid> _leadIndustry;
		public virtual Guid LeadIndustry {
			get {
				return (_leadIndustry ?? (_leadIndustry = () => Guid.Empty)).Invoke();
			}
			set {
				_leadIndustry = () => { return value; };
			}
		}

		private Func<Guid> _leadOwnership;
		public virtual Guid LeadOwnership {
			get {
				return (_leadOwnership ?? (_leadOwnership = () => Guid.Empty)).Invoke();
			}
			set {
				_leadOwnership = () => { return value; };
			}
		}

		private Func<Guid> _leadAccountId;
		public virtual Guid LeadAccountId {
			get {
				return (_leadAccountId ?? (_leadAccountId = () => Guid.Empty)).Invoke();
			}
			set {
				_leadAccountId = () => { return value; };
			}
		}

		private Func<Guid> _leadContactId;
		public virtual Guid LeadContactId {
			get {
				return (_leadContactId ?? (_leadContactId = () => Guid.Empty)).Invoke();
			}
			set {
				_leadContactId = () => { return value; };
			}
		}

		private Func<string> _leadAddress;
		public virtual string LeadAddress {
			get {
				return (_leadAddress ?? (_leadAddress = () => null)).Invoke();
			}
			set {
				_leadAddress = () => { return value; };
			}
		}

		private Func<bool> _createAccountOnQualification;
		public virtual bool CreateAccountOnQualification {
			get {
				return (_createAccountOnQualification ?? (_createAccountOnQualification = () => false)).Invoke();
			}
			set {
				_createAccountOnQualification = () => { return value; };
			}
		}

		private ProcessLeadQualification _leadQualification;
		public ProcessLeadQualification LeadQualification {
			get {
				return _leadQualification ?? ((_leadQualification) = new ProcessLeadQualification(UserConnection, this));
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
					SchemaElementUId = new Guid("bf1b5b17-6f6d-4e3d-8136-b213854f53b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateQualified;
		public ProcessTerminateEvent TerminateQualified {
			get {
				return _terminateQualified ?? (_terminateQualified = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateQualified",
					SchemaElementUId = new Guid("279e66a8-61fb-4e2b-8559-0362a5ebb1fe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayIsLeadSet;
		public ProcessExclusiveGateway ExclusiveGatewayIsLeadSet {
			get {
				return _exclusiveGatewayIsLeadSet ?? (_exclusiveGatewayIsLeadSet = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayIsLeadSet",
					SchemaElementUId = new Guid("ed9cbb4d-b5c9-4231-ab67-76ffff3433b0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayIsLeadSet.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminate2;
		public ProcessTerminateEvent Terminate2 {
			get {
				return _terminate2 ?? (_terminate2 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate2",
					SchemaElementUId = new Guid("478ef5b0-3cfe-49aa-9d92-d33e5210847a"),
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

		private ChangeContactAccountFlowElement _changeContactAccount;
		public ChangeContactAccountFlowElement ChangeContactAccount {
			get {
				return _changeContactAccount ?? (_changeContactAccount = new ChangeContactAccountFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayAccountConnection;
		public ProcessExclusiveGateway ExclusiveGatewayAccountConnection {
			get {
				return _exclusiveGatewayAccountConnection ?? (_exclusiveGatewayAccountConnection = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayAccountConnection",
					SchemaElementUId = new Guid("968e7a35-4c26-459a-806f-a3b34d7fe1c2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayAccountConnection.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ChangeLeadStageDistributionFlowElement _changeLeadStageDistribution;
		public ChangeLeadStageDistributionFlowElement ChangeLeadStageDistribution {
			get {
				return _changeLeadStageDistribution ?? (_changeLeadStageDistribution = new ChangeLeadStageDistributionFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _changeAccountScriptTask;
		public ProcessScriptTask ChangeAccountScriptTask {
			get {
				return _changeAccountScriptTask ?? (_changeAccountScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeAccountScriptTask",
					SchemaElementUId = new Guid("97776b38-7f29-472a-ab13-e87884d17d43"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = ChangeAccountScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _changeContactScriptTask;
		public ProcessScriptTask ChangeContactScriptTask {
			get {
				return _changeContactScriptTask ?? (_changeContactScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeContactScriptTask",
					SchemaElementUId = new Guid("9970214a-b543-4895-ab00-ab57461e70cf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = ChangeContactScriptTaskExecute,
				});
			}
		}

		private LinkContactToLeadFlowElement _linkContactToLead;
		public LinkContactToLeadFlowElement LinkContactToLead {
			get {
				return _linkContactToLead ?? (_linkContactToLead = new LinkContactToLeadFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private LinkAccountToLeadFlowElement _linkAccountToLead;
		public LinkAccountToLeadFlowElement LinkAccountToLead {
			get {
				return _linkAccountToLead ?? (_linkAccountToLead = new LinkAccountToLeadFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayQualifiedAccount;
		public ProcessExclusiveGateway ExclusiveGatewayQualifiedAccount {
			get {
				return _exclusiveGatewayQualifiedAccount ?? (_exclusiveGatewayQualifiedAccount = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayQualifiedAccount",
					SchemaElementUId = new Guid("045b9d72-61cb-4f5f-8a92-c02297c04e1d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayQualifiedAccount.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ReadSystemSettingsFlowElement _readSystemSettings;
		public ReadSystemSettingsFlowElement ReadSystemSettings {
			get {
				return _readSystemSettings ?? (_readSystemSettings = new ReadSystemSettingsFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("00b2c101-a67f-4a28-a60e-f6ef8f988808"),
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
					SchemaElementUId = new Guid("8df03451-825f-4626-947e-1c39dddd618f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _qualifiedContactExistsSequenceFlow;
		public ProcessConditionalFlow QualifiedContactExistsSequenceFlow {
			get {
				return _qualifiedContactExistsSequenceFlow ?? (_qualifiedContactExistsSequenceFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "QualifiedContactExistsSequenceFlow",
					SchemaElementUId = new Guid("644d1a44-d831-44e0-982d-8da2dc9c15bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _qualifiedAccountExistsSequenceFlow;
		public ProcessConditionalFlow QualifiedAccountExistsSequenceFlow {
			get {
				return _qualifiedAccountExistsSequenceFlow ?? (_qualifiedAccountExistsSequenceFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "QualifiedAccountExistsSequenceFlow",
					SchemaElementUId = new Guid("2e0ed20e-8966-4d04-847a-b6b5a83c0b82"),
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
			FlowElements[TerminateQualified.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateQualified };
			FlowElements[ExclusiveGatewayIsLeadSet.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayIsLeadSet };
			FlowElements[Terminate2.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate2 };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ChangeContactAccount.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeContactAccount };
			FlowElements[ExclusiveGatewayAccountConnection.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayAccountConnection };
			FlowElements[ChangeLeadStageDistribution.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadStageDistribution };
			FlowElements[ChangeAccountScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAccountScriptTask };
			FlowElements[ChangeContactScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeContactScriptTask };
			FlowElements[LinkContactToLead.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkContactToLead };
			FlowElements[LinkAccountToLead.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkAccountToLead };
			FlowElements[ExclusiveGatewayQualifiedAccount.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayQualifiedAccount };
			FlowElements[ReadSystemSettings.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadSystemSettings };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayIsLeadSet", e.Context.SenderName));
						break;
					case "TerminateQualified":
						CompleteProcess();
						break;
					case "ExclusiveGatewayIsLeadSet":
						if (ConditionalFlowLeadUndefinedExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
						break;
					case "Terminate2":
						CompleteProcess();
						break;
					case "ReadLeadData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadSystemSettings", e.Context.SenderName));
						break;
					case "ChangeContactAccount":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadStageDistribution", e.Context.SenderName));
						break;
					case "ExclusiveGatewayAccountConnection":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeContactAccount", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadStageDistribution", e.Context.SenderName));
						break;
					case "ChangeLeadStageDistribution":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateQualified", e.Context.SenderName));
						break;
					case "ChangeAccountScriptTask":
						if (QualifiedContactExistsSequenceFlowExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkContactToLead", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayQualifiedAccount", e.Context.SenderName));
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ChangeAccountScriptTask");
						break;
					case "ChangeContactScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeAccountScriptTask", e.Context.SenderName));
						break;
					case "LinkContactToLead":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayQualifiedAccount", e.Context.SenderName));
						break;
					case "LinkAccountToLead":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayAccountConnection", e.Context.SenderName));
						break;
					case "ExclusiveGatewayQualifiedAccount":
						if (QualifiedAccountExistsSequenceFlowExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkAccountToLead", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayAccountConnection", e.Context.SenderName));
						break;
					case "ReadSystemSettings":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeContactScriptTask", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlowLeadUndefinedExpressionExecute() {
			bool result = Convert.ToBoolean((LeadId) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayIsLeadSet", "ConditionalFlowLeadUndefined", "(LeadId) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((AccountId)!= Guid.Empty && (ContactId) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayAccountConnection", "ConditionalFlow3", "(AccountId)!= Guid.Empty && (ContactId) != Guid.Empty", result);
			return result;
		}

		private bool QualifiedContactExistsSequenceFlowExpressionExecute() {
			bool result = Convert.ToBoolean((ContactId) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ChangeAccountScriptTask", "QualifiedContactExistsSequenceFlow", "(ContactId) != Guid.Empty", result);
			return result;
		}

		private bool QualifiedAccountExistsSequenceFlowExpressionExecute() {
			bool result = Convert.ToBoolean((AccountId) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayQualifiedAccount", "QualifiedAccountExistsSequenceFlow", "(AccountId) != Guid.Empty", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
			}
			if (!HasMapping("AccountId")) {
				writer.WriteValue("AccountId", AccountId, Guid.Empty);
			}
			if (!HasMapping("ContactId")) {
				writer.WriteValue("ContactId", ContactId, Guid.Empty);
			}
			if (!HasMapping("LeadAddressType")) {
				writer.WriteValue("LeadAddressType", LeadAddressType, Guid.Empty);
			}
			if (!HasMapping("LeadCity")) {
				writer.WriteValue("LeadCity", LeadCity, Guid.Empty);
			}
			if (!HasMapping("LeadZip")) {
				writer.WriteValue("LeadZip", LeadZip, null);
			}
			if (!HasMapping("LeadRegion")) {
				writer.WriteValue("LeadRegion", LeadRegion, Guid.Empty);
			}
			if (!HasMapping("LeadCountry")) {
				writer.WriteValue("LeadCountry", LeadCountry, Guid.Empty);
			}
			if (!HasMapping("LeadWebsite")) {
				writer.WriteValue("LeadWebsite", LeadWebsite, null);
			}
			if (!HasMapping("LeadFax")) {
				writer.WriteValue("LeadFax", LeadFax, null);
			}
			if (!HasMapping("LeadBusinessPhone")) {
				writer.WriteValue("LeadBusinessPhone", LeadBusinessPhone, null);
			}
			if (!HasMapping("LeadEmail")) {
				writer.WriteValue("LeadEmail", LeadEmail, null);
			}
			if (!HasMapping("LeadMobilePhone")) {
				writer.WriteValue("LeadMobilePhone", LeadMobilePhone, null);
			}
			if (!HasMapping("LeadDecisionRole")) {
				writer.WriteValue("LeadDecisionRole", LeadDecisionRole, Guid.Empty);
			}
			if (!HasMapping("LeadGender")) {
				writer.WriteValue("LeadGender", LeadGender, Guid.Empty);
			}
			if (!HasMapping("LeadDepartment")) {
				writer.WriteValue("LeadDepartment", LeadDepartment, Guid.Empty);
			}
			if (!HasMapping("LeadJob")) {
				writer.WriteValue("LeadJob", LeadJob, Guid.Empty);
			}
			if (!HasMapping("LeadSalutation")) {
				writer.WriteValue("LeadSalutation", LeadSalutation, Guid.Empty);
			}
			if (!HasMapping("LeadDear")) {
				writer.WriteValue("LeadDear", LeadDear, null);
			}
			if (!HasMapping("LeadFullJobTitle")) {
				writer.WriteValue("LeadFullJobTitle", LeadFullJobTitle, null);
			}
			if (!HasMapping("LeadContactName")) {
				writer.WriteValue("LeadContactName", LeadContactName, null);
			}
			if (!HasMapping("LeadAccountName")) {
				writer.WriteValue("LeadAccountName", LeadAccountName, null);
			}
			if (!HasMapping("LeadAnnualRevenue")) {
				writer.WriteValue("LeadAnnualRevenue", LeadAnnualRevenue, Guid.Empty);
			}
			if (!HasMapping("LeadEmployeesNumber")) {
				writer.WriteValue("LeadEmployeesNumber", LeadEmployeesNumber, Guid.Empty);
			}
			if (!HasMapping("LeadAccountCategory")) {
				writer.WriteValue("LeadAccountCategory", LeadAccountCategory, Guid.Empty);
			}
			if (!HasMapping("LeadIndustry")) {
				writer.WriteValue("LeadIndustry", LeadIndustry, Guid.Empty);
			}
			if (!HasMapping("LeadOwnership")) {
				writer.WriteValue("LeadOwnership", LeadOwnership, Guid.Empty);
			}
			if (!HasMapping("LeadAccountId")) {
				writer.WriteValue("LeadAccountId", LeadAccountId, Guid.Empty);
			}
			if (!HasMapping("LeadContactId")) {
				writer.WriteValue("LeadContactId", LeadContactId, Guid.Empty);
			}
			if (!HasMapping("LeadAddress")) {
				writer.WriteValue("LeadAddress", LeadAddress, null);
			}
			if (!HasMapping("CreateAccountOnQualification")) {
				writer.WriteValue("CreateAccountOnQualification", CreateAccountOnQualification, false);
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
			MetaPathParameterValues.Add("7da3d394-c5b2-4fba-be47-747a00d3685e", () => LeadId);
			MetaPathParameterValues.Add("adff468f-5785-4238-a962-2d46a6df9207", () => AccountId);
			MetaPathParameterValues.Add("21f03e5d-1b78-48dc-9e30-1c86f9161488", () => ContactId);
			MetaPathParameterValues.Add("2365f649-230d-4d6e-b38b-15932b94c2d9", () => LeadAddressType);
			MetaPathParameterValues.Add("a00b4828-9039-473d-9786-1042a8a4d495", () => LeadCity);
			MetaPathParameterValues.Add("b9c2234b-9f29-4b4b-bff9-43ed0aee7fd4", () => LeadZip);
			MetaPathParameterValues.Add("b120b526-724c-470e-9bde-cca7c5bce38b", () => LeadRegion);
			MetaPathParameterValues.Add("7f25c2c6-3a0b-430a-b8f4-14dac4a33300", () => LeadCountry);
			MetaPathParameterValues.Add("7573b5d0-d90d-43fb-a4ff-b434212f304d", () => LeadWebsite);
			MetaPathParameterValues.Add("ef248d37-29b4-41f3-ae05-29aa2ca78c1e", () => LeadFax);
			MetaPathParameterValues.Add("237e51db-51d4-40d3-ba2e-657d419fe693", () => LeadBusinessPhone);
			MetaPathParameterValues.Add("6547686a-48b1-457a-810e-01431f20fcf7", () => LeadEmail);
			MetaPathParameterValues.Add("f609b031-6cfd-4dbc-9110-5a3c4aaf1d59", () => LeadMobilePhone);
			MetaPathParameterValues.Add("7d3339ff-d4dd-47f4-aad0-f962a3c06682", () => LeadDecisionRole);
			MetaPathParameterValues.Add("26e960a5-407f-49ef-9aeb-194c10c5c07a", () => LeadGender);
			MetaPathParameterValues.Add("8ad4103a-0d1e-4f62-a22a-707a1d45a404", () => LeadDepartment);
			MetaPathParameterValues.Add("a0f4b101-277c-452d-94c8-b44202a3a196", () => LeadJob);
			MetaPathParameterValues.Add("f34298ea-de28-49a3-a7dd-0537e9d81810", () => LeadSalutation);
			MetaPathParameterValues.Add("61ebe384-47c3-41a5-8f7a-689cc754debd", () => LeadDear);
			MetaPathParameterValues.Add("69d73113-cfb5-46b5-bad8-db01b0089ad7", () => LeadFullJobTitle);
			MetaPathParameterValues.Add("9ccf4757-79ad-4fda-8a8d-091f07d873c6", () => LeadContactName);
			MetaPathParameterValues.Add("d7cbdc44-a5b7-48dc-bbaf-a96bd83d7066", () => LeadAccountName);
			MetaPathParameterValues.Add("485ac59c-8ec0-45f6-b314-99549ce9eedf", () => LeadAnnualRevenue);
			MetaPathParameterValues.Add("81219640-87de-43de-9f88-0867fbbd7c43", () => LeadEmployeesNumber);
			MetaPathParameterValues.Add("347c7337-e229-470b-a321-5aa2e5a4d102", () => LeadAccountCategory);
			MetaPathParameterValues.Add("7ab43aa0-0265-44da-baf7-13ae2e552bfe", () => LeadIndustry);
			MetaPathParameterValues.Add("5b328e21-1e24-46e8-a579-71076a3c942a", () => LeadOwnership);
			MetaPathParameterValues.Add("ae489f7c-9167-44af-a723-c61c0541a93a", () => LeadAccountId);
			MetaPathParameterValues.Add("f302fbc3-0ce9-4626-9957-2cf93197d6fd", () => LeadContactId);
			MetaPathParameterValues.Add("c945f2af-1eae-4ba3-a433-a8ea8b69d8b1", () => LeadAddress);
			MetaPathParameterValues.Add("70ebb313-bd3c-472f-bf4f-f07a23506a9c", () => CreateAccountOnQualification);
			MetaPathParameterValues.Add("eb174310-4f6b-4191-b705-5ac74e8d6810", () => ReadLeadData.DataSourceFilters);
			MetaPathParameterValues.Add("2c5fddb8-7f3b-431c-a140-15c790c47997", () => ReadLeadData.ResultType);
			MetaPathParameterValues.Add("c9715250-2f51-47c6-ae51-692c6ef09e35", () => ReadLeadData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("7aa6f27f-9136-4c8a-95c8-d11d8c5dd57c", () => ReadLeadData.NumberOfRecords);
			MetaPathParameterValues.Add("105c3fa8-1208-4d19-bf97-40057718c52f", () => ReadLeadData.FunctionType);
			MetaPathParameterValues.Add("001d410e-1ab8-4cd6-bb61-83ee17b39a5b", () => ReadLeadData.AggregationColumnName);
			MetaPathParameterValues.Add("a1588d18-597e-4d60-95bc-bd4c78338608", () => ReadLeadData.OrderInfo);
			MetaPathParameterValues.Add("724a8768-9516-4d2c-aa88-41a1bb2d5e37", () => ReadLeadData.ResultEntity);
			MetaPathParameterValues.Add("1eb2f334-3b2d-4e66-96ae-e2c0468ec136", () => ReadLeadData.ResultCount);
			MetaPathParameterValues.Add("02e6f3dc-c3b7-48c5-b1bb-858d7d4b6706", () => ReadLeadData.ResultIntegerFunction);
			MetaPathParameterValues.Add("552d4238-195d-4289-9c82-72b9a2a6cc13", () => ReadLeadData.ResultFloatFunction);
			MetaPathParameterValues.Add("2ee6855b-3c07-41fe-9ed9-dce8afc87598", () => ReadLeadData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("d8c1e15f-029b-46de-8fb1-c9ab4e292106", () => ReadLeadData.ResultRowsCount);
			MetaPathParameterValues.Add("30fc9f29-8bc3-4e4c-8238-8d93757cf810", () => ReadLeadData.CanReadUncommitedData);
			MetaPathParameterValues.Add("2ab23a86-7cff-4fa0-b600-4001d8b72aca", () => ReadLeadData.ResultEntityCollection);
			MetaPathParameterValues.Add("fd8b3b5a-0afb-4d72-b51c-4907de28ec37", () => ReadLeadData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("6d962028-129a-453e-8ba9-f69a2f78e60c", () => ReadLeadData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("f2737688-dfc2-4d03-969c-d7a4170bc47e", () => ReadLeadData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("13beec44-3596-4408-9292-685bdcd4aae4", () => ReadLeadData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("ea29a1a7-83b3-4850-9134-d716cf498910", () => ChangeContactAccount.EntitySchemaUId);
			MetaPathParameterValues.Add("2a3f5cb3-7035-42b2-9882-c80f7985168f", () => ChangeContactAccount.IsMatchConditions);
			MetaPathParameterValues.Add("0d8e007f-f368-46a3-840e-c8c133b97854", () => ChangeContactAccount.DataSourceFilters);
			MetaPathParameterValues.Add("c0fe375b-e8e3-406d-b4a8-8783f94f8903", () => ChangeContactAccount.RecordColumnValues);
			MetaPathParameterValues.Add("cefcf07d-bdb1-4eef-8f15-76b244047bd4", () => ChangeContactAccount.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("9e34dc39-7d39-421f-8d27-92a8af9a80c6", () => ChangeLeadStageDistribution.EntitySchemaUId);
			MetaPathParameterValues.Add("bcf5b8fe-4737-4d4e-a037-b2c70a7900e8", () => ChangeLeadStageDistribution.IsMatchConditions);
			MetaPathParameterValues.Add("bb68e8f2-44a8-4731-b948-176e754a5d8b", () => ChangeLeadStageDistribution.DataSourceFilters);
			MetaPathParameterValues.Add("f994ffb6-8edf-41e3-892d-aa56db1c821b", () => ChangeLeadStageDistribution.RecordColumnValues);
			MetaPathParameterValues.Add("7e817e60-3ea5-40a4-8ee5-379468961efc", () => ChangeLeadStageDistribution.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("6dd0bc3f-edfa-4078-87d0-79fe8307a8ab", () => LinkContactToLead.EntitySchemaUId);
			MetaPathParameterValues.Add("55ac08c6-ba80-4060-81f6-fb82943a2aa6", () => LinkContactToLead.IsMatchConditions);
			MetaPathParameterValues.Add("34908b60-ff49-4067-a7d9-fecfeba3d015", () => LinkContactToLead.DataSourceFilters);
			MetaPathParameterValues.Add("ee931748-590a-41b4-8229-e4dc1c8b23af", () => LinkContactToLead.RecordColumnValues);
			MetaPathParameterValues.Add("a7baafae-621c-427a-952d-c17478900ce1", () => LinkContactToLead.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("7b3e0e2a-6d32-492c-9290-46e7c194da0b", () => LinkAccountToLead.EntitySchemaUId);
			MetaPathParameterValues.Add("fbd3778b-b29e-4da4-878c-479ce66f6695", () => LinkAccountToLead.IsMatchConditions);
			MetaPathParameterValues.Add("e2572aab-9833-4451-bac3-3c93b4938008", () => LinkAccountToLead.DataSourceFilters);
			MetaPathParameterValues.Add("2c5dda1b-35c1-410a-8a66-b8e7dbef353d", () => LinkAccountToLead.RecordColumnValues);
			MetaPathParameterValues.Add("8e7d41f7-0f25-4dc6-8538-30a7a13a5a71", () => LinkAccountToLead.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("5b47b7b3-1c3a-4e76-8b27-d2d1429d61ee", () => ReadSystemSettings.DataSourceFilters);
			MetaPathParameterValues.Add("055337fb-4c12-4162-baa0-f0a6f82b04f1", () => ReadSystemSettings.ResultType);
			MetaPathParameterValues.Add("61008822-6246-4cb7-94b5-d7ab2c0e761f", () => ReadSystemSettings.ReadSomeTopRecords);
			MetaPathParameterValues.Add("a18bad05-72bd-47e8-8a76-9adc5adb727a", () => ReadSystemSettings.NumberOfRecords);
			MetaPathParameterValues.Add("05ce4b0d-7adf-4370-a4da-9a578ae526a6", () => ReadSystemSettings.FunctionType);
			MetaPathParameterValues.Add("b54c1807-d3db-417d-acc8-5ec641e8f114", () => ReadSystemSettings.AggregationColumnName);
			MetaPathParameterValues.Add("eb5b205e-4427-45cf-8b2f-e5c11ffb5d04", () => ReadSystemSettings.OrderInfo);
			MetaPathParameterValues.Add("411b2f2b-abb2-49c4-b63c-c589bc81bb8c", () => ReadSystemSettings.ResultEntity);
			MetaPathParameterValues.Add("0107e886-cf9e-458c-9fa5-10337b71312c", () => ReadSystemSettings.ResultCount);
			MetaPathParameterValues.Add("c92f52ed-8123-486d-ae9b-c9c0f3e785cf", () => ReadSystemSettings.ResultIntegerFunction);
			MetaPathParameterValues.Add("6c8845de-fd11-481f-ba54-02935c4aeb9d", () => ReadSystemSettings.ResultFloatFunction);
			MetaPathParameterValues.Add("63c46681-2887-41fe-8ea5-3cd9bd9e60fe", () => ReadSystemSettings.ResultDateTimeFunction);
			MetaPathParameterValues.Add("f0232a3c-912e-48ab-9927-5fc33677f7ba", () => ReadSystemSettings.ResultRowsCount);
			MetaPathParameterValues.Add("06e3ef5a-2fa6-49b7-bfa6-3a114e683d05", () => ReadSystemSettings.CanReadUncommitedData);
			MetaPathParameterValues.Add("0a40e220-4683-47e0-a0c2-892934668fc3", () => ReadSystemSettings.ResultEntityCollection);
			MetaPathParameterValues.Add("44d1abb0-802b-49e6-9571-d667de498b3e", () => ReadSystemSettings.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("11fe36aa-20e3-41b3-99f4-0a35fd3628cc", () => ReadSystemSettings.IgnoreDisplayValues);
			MetaPathParameterValues.Add("e38c6786-4b6a-453c-98ff-274e159ab770", () => ReadSystemSettings.ResultCompositeObjectList);
			MetaPathParameterValues.Add("31b48d41-0e68-4322-ac74-bf409264e30f", () => ReadSystemSettings.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
				case "AccountId":
					if (!hasValueToRead) break;
					AccountId = reader.GetValue<System.Guid>();
				break;
				case "ContactId":
					if (!hasValueToRead) break;
					ContactId = reader.GetValue<System.Guid>();
				break;
				case "LeadAddressType":
					if (!hasValueToRead) break;
					LeadAddressType = reader.GetValue<System.Guid>();
				break;
				case "LeadCity":
					if (!hasValueToRead) break;
					LeadCity = reader.GetValue<System.Guid>();
				break;
				case "LeadZip":
					if (!hasValueToRead) break;
					LeadZip = reader.GetValue<System.String>();
				break;
				case "LeadRegion":
					if (!hasValueToRead) break;
					LeadRegion = reader.GetValue<System.Guid>();
				break;
				case "LeadCountry":
					if (!hasValueToRead) break;
					LeadCountry = reader.GetValue<System.Guid>();
				break;
				case "LeadWebsite":
					if (!hasValueToRead) break;
					LeadWebsite = reader.GetValue<System.String>();
				break;
				case "LeadFax":
					if (!hasValueToRead) break;
					LeadFax = reader.GetValue<System.String>();
				break;
				case "LeadBusinessPhone":
					if (!hasValueToRead) break;
					LeadBusinessPhone = reader.GetValue<System.String>();
				break;
				case "LeadEmail":
					if (!hasValueToRead) break;
					LeadEmail = reader.GetValue<System.String>();
				break;
				case "LeadMobilePhone":
					if (!hasValueToRead) break;
					LeadMobilePhone = reader.GetValue<System.String>();
				break;
				case "LeadDecisionRole":
					if (!hasValueToRead) break;
					LeadDecisionRole = reader.GetValue<System.Guid>();
				break;
				case "LeadGender":
					if (!hasValueToRead) break;
					LeadGender = reader.GetValue<System.Guid>();
				break;
				case "LeadDepartment":
					if (!hasValueToRead) break;
					LeadDepartment = reader.GetValue<System.Guid>();
				break;
				case "LeadJob":
					if (!hasValueToRead) break;
					LeadJob = reader.GetValue<System.Guid>();
				break;
				case "LeadSalutation":
					if (!hasValueToRead) break;
					LeadSalutation = reader.GetValue<System.Guid>();
				break;
				case "LeadDear":
					if (!hasValueToRead) break;
					LeadDear = reader.GetValue<System.String>();
				break;
				case "LeadFullJobTitle":
					if (!hasValueToRead) break;
					LeadFullJobTitle = reader.GetValue<System.String>();
				break;
				case "LeadContactName":
					if (!hasValueToRead) break;
					LeadContactName = reader.GetValue<System.String>();
				break;
				case "LeadAccountName":
					if (!hasValueToRead) break;
					LeadAccountName = reader.GetValue<System.String>();
				break;
				case "LeadAnnualRevenue":
					if (!hasValueToRead) break;
					LeadAnnualRevenue = reader.GetValue<System.Guid>();
				break;
				case "LeadEmployeesNumber":
					if (!hasValueToRead) break;
					LeadEmployeesNumber = reader.GetValue<System.Guid>();
				break;
				case "LeadAccountCategory":
					if (!hasValueToRead) break;
					LeadAccountCategory = reader.GetValue<System.Guid>();
				break;
				case "LeadIndustry":
					if (!hasValueToRead) break;
					LeadIndustry = reader.GetValue<System.Guid>();
				break;
				case "LeadOwnership":
					if (!hasValueToRead) break;
					LeadOwnership = reader.GetValue<System.Guid>();
				break;
				case "LeadAccountId":
					if (!hasValueToRead) break;
					LeadAccountId = reader.GetValue<System.Guid>();
				break;
				case "LeadContactId":
					if (!hasValueToRead) break;
					LeadContactId = reader.GetValue<System.Guid>();
				break;
				case "LeadAddress":
					if (!hasValueToRead) break;
					LeadAddress = reader.GetValue<System.String>();
				break;
				case "CreateAccountOnQualification":
					if (!hasValueToRead) break;
					CreateAccountOnQualification = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ChangeAccountScriptTaskExecute(ProcessExecutingContext context) {
			ProcessAccount();
			return true;
		}

		public virtual bool ChangeContactScriptTaskExecute(ProcessExecutingContext context) {
			ProcessContact();
			return true;
		}

		public virtual void ProcessAccount() {
			Guid accountId = LeadAccountId;
			bool createAccount = CreateAccountOnQualification;
			var account = new Terrasoft.Configuration.Account(UserConnection);
			bool accountExists = false;
			if (accountId.IsEmpty()) {
				accountId = Guid.NewGuid();
			} else {
				accountExists = account.FetchFromDB(accountId);
			}
			if (!accountExists) {
				if (createAccount) {
					LeadAccountId = accountId;
					account.Id = accountId;
					account.SetDefColumnValues();
				} else {
					return;
				}
			}
			if (!string.IsNullOrEmpty(LeadAccountName)) {
				account.Name = LeadAccountName;
			}
			if (string.IsNullOrEmpty(account.Name)) {
				return;
			}
			SetValue(account, "OwnershipId", LeadOwnership);
			SetValue(account, "IndustryId", LeadIndustry);
			SetValue(account, "AccountCategoryId", LeadAccountCategory);
			SetValue(account, "EmployeesNumberId", LeadEmployeesNumber);
			SetValue(account, "AnnualRevenueId", LeadAnnualRevenue);
			account.Save();
			SyncAccountCommunications(account.Id);
			AccountId = accountId;
			AddAccountAddress(accountId);
		}

		public virtual void SetValue(Entity entity, string valueName, Object value) {
			if (Guid.Empty.Equals(value)) {
				value = null;
			}
			entity.SetColumnValue(valueName, value);
		}

		public virtual void ProcessContact() {
			Guid contactId = LeadContactId;
			var contact = new Terrasoft.Configuration.Contact(UserConnection);
			string contactName = LeadContactName;
			if (contactId.IsEmpty()) {
				if (!string.IsNullOrEmpty(contactName)) {
					contactId = Guid.NewGuid();
					contact.SetDefColumnValues();
					contact.Id = contactId;
				} else {
					return;
				}
			} else if (!contact.FetchFromDB(contactId)) {
				return;
			}
			if (!string.IsNullOrEmpty(contactName)) {
				contact.Name = contactName;
			}
			ContactId = contactId;
			SetValue(contact, "Dear", LeadDear);
			SetValue(contact, "JobTitle", LeadFullJobTitle);
			SetValue(contact, "SalutationTypeId", LeadSalutation);
			SetValue(contact, "JobId", LeadJob);
			SetValue(contact, "DepartmentId", LeadDepartment);
			SetValue(contact, "GenderId", LeadGender);
			SetValue(contact, "DecisionRoleId", LeadDecisionRole);
			contact.Confirmed = true;
			contact.Save();
			SyncContactCommunications(contact.Id);
			AddContacAddress(contact.Id);
		}

		public virtual void SyncContactCommunications(Guid contactId) {
			Dictionary<Guid, string> leadCommunications = new Dictionary<Guid, string>();
			if (!string.IsNullOrEmpty(LeadBusinessPhone)) {
				leadCommunications[new Guid(CommunicationTypeConsts.WorkPhoneId)] = LeadBusinessPhone;
			}
			if (!string.IsNullOrEmpty(LeadMobilePhone)) {
				leadCommunications[new Guid(CommunicationTypeConsts.MobilePhoneId)] = LeadMobilePhone;
			}
			if (!string.IsNullOrEmpty(LeadEmail)) {
				leadCommunications[new Guid(CommunicationTypeConsts.EmailId)] = LeadEmail;
			}
			Select existingNumbers = new Select(UserConnection)
				.Column("Number")
				.From("ContactCommunication")
				.Where("ContactId").IsEqual(Column.Parameter(contactId)) as Select;
			List<string> contactCommuniations = new List<string>();
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = existingNumbers.ExecuteReader(dbExecutor)){
					while (reader.Read()) {
						contactCommuniations.Add(reader.GetString(0).ToLower());
					}
				}
			}
			List<KeyValuePair<Guid, string>> communicationsToSync = 
				leadCommunications.Where(n => !contactCommuniations.Contains(n.Value.ToLower())).ToList();
			foreach (KeyValuePair<Guid, string> communication in communicationsToSync) {
				var contactCommunication = new ContactCommunication(UserConnection);
				contactCommunication.SetDefColumnValues();
				contactCommunication.Number = communication.Value;
				contactCommunication.CommunicationTypeId = communication.Key;
				contactCommunication.ContactId = contactId;
				contactCommunication.Save();
			}
		}

		public virtual void SyncAccountCommunications(Guid accountId) {
			Dictionary<Guid, string> leadCommunications = new Dictionary<Guid, string>();
			if (!string.IsNullOrEmpty(LeadBusinessPhone)) {
				leadCommunications[new Guid(CommunicationTypeConsts.MainPhoneId)] = LeadBusinessPhone;
			}
			if (!string.IsNullOrEmpty(LeadFax)) {
				leadCommunications[new Guid(CommunicationTypeConsts.FaxId)] = LeadFax;
			}
			if (!string.IsNullOrEmpty(LeadWebsite)) {
				leadCommunications[new Guid(CommunicationTypeConsts.WebId)] = LeadWebsite;
			}
			Select existingNumbers = new Select(UserConnection)
				.Column("Number")
				.From("AccountCommunication")
				.Where("AccountId").IsEqual(Column.Parameter(accountId)) as Select;
			List<string> contactCommuniations = new List<string>();
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = existingNumbers.ExecuteReader(dbExecutor)){
					while (reader.Read()) {
						contactCommuniations.Add(reader.GetString(0).ToLower());
					}
				}
			}
			List<KeyValuePair<Guid, string>> communicationsToSync = 
				leadCommunications.Where(n => !contactCommuniations.Contains(n.Value.ToLower())).ToList();
			foreach (KeyValuePair<Guid, string> communication in communicationsToSync) {
				var accountCommunication = new AccountCommunication(UserConnection);
				accountCommunication.SetDefColumnValues();
				accountCommunication.Number = communication.Value;
				accountCommunication.CommunicationTypeId = communication.Key;
				accountCommunication.AccountId = accountId;
				accountCommunication.Save();
			}
		}

		public virtual void AddContacAddress(Guid contactId) {
			if (LeadAddressType.IsEmpty() && 
					LeadCity.IsEmpty() && 
					LeadRegion.IsEmpty() && 
					LeadCountry.IsEmpty() && 
					String.IsNullOrEmpty(LeadZip) && 
					String.IsNullOrEmpty(LeadAddress)) {
				return;
			}
			//Check is address already exists
			if (IsAddressExists(
					"ContactAddress", 
					"ContactId", 
					contactId, 
					LeadAddressType, 
					LeadCity, 
					LeadRegion, 
					LeadCountry, 
					LeadZip, 
					LeadAddress)) {
				return;
			}
			//Create contact address from Lead
			var contactAddress = new ContactAddress(UserConnection);
			contactAddress.SetDefColumnValues();
			SetValue(contactAddress, "AddressTypeId", LeadAddressType);
			SetValue(contactAddress, "CityId", LeadCity);
			SetValue(contactAddress, "RegionId", LeadRegion);
			SetValue(contactAddress, "CountryId", LeadCountry);
			SetValue(contactAddress, "Zip", LeadZip);
			SetValue(contactAddress, "Address", LeadAddress);
			contactAddress.ContactId = contactId;
			contactAddress.Save();
		}

		public virtual void AddAccountAddress(Guid accountId) {
			if (LeadAddressType.IsEmpty() && 
					LeadCity.IsEmpty() && 
					LeadRegion.IsEmpty() && 
					LeadCountry.IsEmpty() && 
					String.IsNullOrEmpty(LeadZip) && 
					String.IsNullOrEmpty(LeadAddress)) {
				return;
			}
			//Check is address already exists
			if (IsAddressExists(
					"AccountAddress", 
					"AccountId", 
					accountId, 
					LeadAddressType, 
					LeadCity, 
					LeadRegion, 
					LeadCountry, 
					LeadZip, 
					LeadAddress)) {
				return;
			}
			//Create account address from Lead
			var accountAddress = new AccountAddress(UserConnection);
			accountAddress.SetDefColumnValues();
			SetValue(accountAddress, "AddressTypeId", LeadAddressType);
			SetValue(accountAddress, "CityId", LeadCity);
			SetValue(accountAddress, "RegionId", LeadRegion);
			SetValue(accountAddress, "CountryId", LeadCountry);
			SetValue(accountAddress, "Zip", LeadZip);
			SetValue(accountAddress, "Address", LeadAddress);
			accountAddress.AccountId = accountId;
			accountAddress.Save();
		}

		public virtual bool IsAddressExists(string addressTableName, string relationColumnName, Guid relationColumnValue, Guid addressType, Guid addressCity, Guid addressRegion, Guid addressCountry, string zipValue, string addressValue) {
			var addressSelect = new Select(UserConnection)
				.Column("Zip")
				.Column("Address")
				.From(addressTableName)
				.Where(relationColumnName).IsEqual(Column.Parameter(relationColumnValue)) as Select;
			
			if (!addressType.IsEmpty()) {
				addressSelect.And("AddressTypeId").IsEqual(Column.Parameter(addressType));
			}
			if (!addressCity.IsEmpty()) {
				addressSelect.And("CityId").IsEqual(Column.Parameter(addressCity));
			}
			if (!addressRegion.IsEmpty()) {
				addressSelect.And("RegionId").IsEqual(Column.Parameter(addressRegion));
			}
			if (!addressCountry.IsEmpty()) {
				addressSelect.And("CountryId").IsEqual(Column.Parameter(addressCountry));
			}
			bool compareZip = false;
			if (!String.IsNullOrEmpty(zipValue)) {
				zipValue = zipValue.ToLower().Trim();
				if (!String.IsNullOrEmpty(zipValue)) {
					compareZip = true;
				}
			}
			bool compareAddress = false;
			if (!String.IsNullOrEmpty(addressValue)) {
				addressValue = addressValue.ToLower().Trim();
				if (!String.IsNullOrEmpty(addressValue)) {
					compareAddress = true;
				}
			}
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = addressSelect.ExecuteReader(dbExecutor)) {
					//Test each address.
					while (reader.Read()) {
						string zip = reader.GetString(0).ToLower().Trim();
						string address = reader.GetString(1).ToLower().Trim();
						bool zipMatch = false;
						bool addressMatch = false;
						//Quit when address is math
						if (compareZip && StringUtilities.EqualsIgnoreCase(zip, zipValue)) {
							zipMatch = true;
						}
						zipMatch = zipMatch == compareZip;
						if (compareAddress && StringUtilities.EqualsIgnoreCase(address, addressValue)) {
							addressMatch = true;
						}
						addressMatch = addressMatch == compareAddress;
						if (zipMatch && addressMatch) {
							return true;
						}
					}
				}
			}
			return false;
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
			var cloneItem = (LeadManagementQualification)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


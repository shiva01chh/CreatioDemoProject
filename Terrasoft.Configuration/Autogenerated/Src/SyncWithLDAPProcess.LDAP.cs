namespace Terrasoft.Core.Process
{

	using global::Common.Logging;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using SysSettings = Terrasoft.Core.Configuration.SysSettings;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.DirectoryServices.Protocols;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.LDAP;
	using Terrasoft.Configuration.LDAPSysSettingsService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;

	#region Class: SyncWithLDAPProcessSchema

	/// <exclude/>
	public class SyncWithLDAPProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SyncWithLDAPProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SyncWithLDAPProcessSchema(SyncWithLDAPProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SyncWithLDAPProcess";
			UId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"Business Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,85,219,110,26,49,16,125,222,72,249,7,119,213,7,35,33,171,237,99,155,32,65,66,218,173,200,69,185,52,207,206,238,64,172,122,109,106,123,211,82,202,191,119,124,1,118,9,72,121,129,181,61,115,206,120,230,204,120,222,60,73,81,146,23,97,92,195,37,121,209,162,34,103,6,184,131,91,168,133,170,132,154,141,22,55,70,151,96,45,237,145,229,241,81,246,194,13,169,113,201,103,64,78,137,130,223,100,162,75,46,197,95,254,36,225,206,25,116,161,15,22,204,153,86,10,74,39,180,98,143,218,252,180,115,94,2,187,5,171,27,83,162,157,54,8,208,39,249,221,66,149,143,194,61,79,206,135,55,137,232,27,200,57,152,188,143,100,89,254,10,220,50,111,58,17,37,40,11,87,218,137,169,40,121,160,249,193,101,3,121,239,11,250,121,147,7,39,164,112,11,118,240,62,221,40,247,199,18,163,72,247,237,19,213,72,217,39,83,46,45,120,158,213,241,209,241,209,188,155,67,27,162,36,95,193,141,107,46,228,72,87,11,58,17,214,157,180,194,46,212,84,15,72,131,252,54,38,53,100,21,214,246,41,175,241,190,163,70,200,10,12,13,247,202,54,54,108,56,159,131,170,40,242,156,68,202,1,205,61,69,96,189,140,1,231,189,232,53,213,152,131,242,153,80,79,227,105,137,80,175,232,165,158,93,118,234,186,143,127,107,180,14,224,125,78,69,245,153,44,61,28,243,41,45,170,85,143,252,107,109,92,241,26,86,184,19,75,147,133,100,164,144,73,45,172,197,143,148,23,139,204,193,237,178,187,29,252,138,107,131,113,64,53,86,77,13,198,11,98,131,162,227,201,229,46,152,119,203,118,40,88,128,25,45,232,84,24,235,38,224,28,166,227,116,64,90,203,24,103,16,122,215,55,102,4,131,140,196,236,187,22,138,230,168,156,254,129,16,14,37,109,47,238,33,227,156,229,251,139,127,161,77,205,29,205,151,31,86,203,143,171,229,167,149,15,229,228,201,12,240,127,11,211,39,99,133,226,212,170,6,229,216,21,252,158,8,21,212,155,161,124,51,3,174,49,106,171,61,118,175,83,19,31,18,120,167,126,40,191,187,133,29,86,216,92,184,109,56,246,181,13,10,108,143,139,38,168,194,174,199,69,203,63,170,202,219,216,132,114,171,37,20,21,154,142,184,5,236,78,235,44,67,6,7,117,151,100,205,250,160,132,43,170,13,10,72,236,230,88,248,32,225,176,222,233,244,94,144,5,59,211,178,169,177,124,120,224,120,233,124,238,66,228,121,56,103,23,70,215,52,111,211,164,131,2,113,76,172,252,218,181,199,174,213,142,45,162,165,211,162,194,243,194,142,127,97,242,58,108,254,96,23,177,115,173,144,140,3,224,107,231,108,11,189,199,55,12,181,118,162,18,227,227,51,138,245,45,30,177,28,187,84,49,117,236,134,27,108,109,108,24,218,173,94,47,146,164,70,27,218,114,95,146,9,183,169,60,190,120,98,74,118,95,141,243,209,88,205,80,170,155,143,251,197,28,200,187,83,210,94,35,9,47,37,164,49,22,203,207,134,190,105,94,51,98,248,248,94,28,184,65,158,102,229,138,0,14,247,55,193,33,24,13,160,248,40,208,77,67,37,167,241,31,40,27,255,236,112,63,60,195,132,217,76,90,223,15,1,4,101,110,24,182,80,140,38,188,95,219,97,158,104,66,231,167,14,98,195,170,162,27,239,72,25,126,83,23,39,51,223,184,255,1,60,175,157,247,218,7,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617");
			Version = 0;
			PackageUId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreatePageInstanceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e5c388b3-4785-4a2c-93b1-eb2829edce7e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"PageInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridCurrentRowIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("39bf6d5a-ff9c-4dc0-956a-35ae10d7f2e2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"ActiveTreeGridCurrentRowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDoOpenListParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c4ff2517-a192-4965-8aef-e3dc495ae18d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"DoOpenList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateShowLDAPMessageIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0e5163a5-e480-4e06-b4b9-8d121b6ab25b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"ShowLDAPMessageId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"{83A1E9EA-651D-4600-B027-886C6EFA6524}",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateNotLicensedUserNamesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6740fc54-80fe-4f42-acd8-d4ec48888997"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"NotLicensedUserNames",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSyncResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c241e947-d0e3-48ca-b0eb-5109850b0a5f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"SyncResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewUsersQuestionLSParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3eee1f90-cad9-48ab-9581-9a37ffd7cc9e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"NewUsersQuestionLS",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateNotActiveUsersLSParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7c51318b-2807-4e95-8070-9952bce377ca"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"NotActiveUsersLS",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateNewUsersInGroupLSParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("79cfd16f-6f0a-4429-8b33-20efbd7074bb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"NewUsersInGroupLS",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateProcessSynchWithLDAPLaunchedLSParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f4fa0f38-8445-4c0a-872a-08444b3b1da4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"ProcessSynchWithLDAPLaunchedLS",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateErrorCheckRequiredLDAPSettingsLSParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c1351620-72ca-42c4-b8b1-b83dbf2f79a8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"ErrorCheckRequiredLDAPSettingsLS",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLDAPUsersWereAddedLSParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3ff56a7f-b43f-454e-8320-db273d793916"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"LDAPUsersWereAddedLS",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateServerErrorLSParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ff35025d-d1a8-48b1-9355-f8a23f7413cb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"ServerErrorLS",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateProcessEndedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("83c82239-ffec-4409-9bf6-9b8de6528de7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("912fb492-38c7-4dbe-88b2-46a261777d72"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"ProcessEnded",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMessageLogParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fcf94a88-a3b6-4d21-a997-00a81b8c55c3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("912fb492-38c7-4dbe-88b2-46a261777d72"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"MessageLog",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateNoAccessMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ece68291-3e57-4d5a-a686-ac986c534ae8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("97916cee-c1a7-4a71-815d-9d80f3965c04"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"NoAccessMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateInvalidCredentialsErrorCodeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("eb1d1d1a-09c4-4cdc-ae6d-3cbc3d8c345c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"InvalidCredentialsErrorCode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"49",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateInvalidCredentialMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e410db97-07f1-42a9-97c3-499e34692d6d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"InvalidCredentialMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateConnectionNotEstablishedMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f6d1588b-7930-4f8e-9038-661abad4372d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"ConnectionNotEstablishedMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateErrorSyncResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a9370089-7daf-4b16-b51c-855fb82d5532"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"ErrorSyncResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailSubjectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("aeb1a392-036e-4295-8e8d-f388946495a5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"EmailSubject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailBodyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d7e3ec26-8976-4d26-a926-b73e739132ba"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"EmailBody",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRecipientEmailsStringParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e6d9613e-c931-45a4-8289-34a64d103e30"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"RecipientEmailsString",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLDAPEmailMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2d31abe5-21af-4461-8c88-14c9cb2e037d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"LDAPEmailMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateNotAvailableFunctionalityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3aeb7d6b-24b2-49d5-8f60-33c4bc99b910"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"NotAvailableFunctionality",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePageInstanceIdParameter());
			Parameters.Add(CreateActiveTreeGridCurrentRowIdParameter());
			Parameters.Add(CreateDoOpenListParameter());
			Parameters.Add(CreateShowLDAPMessageIdParameter());
			Parameters.Add(CreateNotLicensedUserNamesParameter());
			Parameters.Add(CreateSyncResultParameter());
			Parameters.Add(CreateNewUsersQuestionLSParameter());
			Parameters.Add(CreateNotActiveUsersLSParameter());
			Parameters.Add(CreateNewUsersInGroupLSParameter());
			Parameters.Add(CreateProcessSynchWithLDAPLaunchedLSParameter());
			Parameters.Add(CreateErrorCheckRequiredLDAPSettingsLSParameter());
			Parameters.Add(CreateLDAPUsersWereAddedLSParameter());
			Parameters.Add(CreateServerErrorLSParameter());
			Parameters.Add(CreateProcessEndedParameter());
			Parameters.Add(CreateMessageLogParameter());
			Parameters.Add(CreateNoAccessMessageParameter());
			Parameters.Add(CreateInvalidCredentialsErrorCodeParameter());
			Parameters.Add(CreateInvalidCredentialMessageParameter());
			Parameters.Add(CreateConnectionNotEstablishedMessageParameter());
			Parameters.Add(CreateErrorSyncResultParameter());
			Parameters.Add(CreateEmailSubjectParameter());
			Parameters.Add(CreateEmailBodyParameter());
			Parameters.Add(CreateRecipientEmailsStringParameter());
			Parameters.Add(CreateLDAPEmailMessageParameter());
			Parameters.Add(CreateNotAvailableFunctionalityParameter());
		}

		protected virtual void InitializeEmailSendUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ca308d49-70ae-4ee3-a7a6-576b39d0906d"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Send email 1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("9e636c72-feec-443d-80db-bbb11ca74373"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"ActivityCategory",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			activityCategoryParameter.SourceValue = new ProcessSchemaParameterValue(activityCategoryParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#Lookup.961e2086-a12b-4d27-b095-40b1e64d6cc0.8038a396-7825-e011-8165-00155d043204#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("20c028fe-7707-4d7c-8ae9-cf1c90b232e7"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6194902c-224f-4855-9b2a-9d91ea50a55e"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fb8728ed-a9ef-4b57-8aa7-37c3bac33e7b"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a2c18195-1b0e-4559-8052-817ae92fd235"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3c731905-eb35-44ed-b3ca-dd1c63b9398b"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("22574204-b989-403f-aa68-6db44ddef273"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3e151f18-e3c4-4475-aa5b-5dbaefa7a649"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7c910dbb-c563-4a34-acf6-c6a467c05210"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("13944a4c-7072-43a9-b1f5-b83b8de6253b"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("97b9f11a-d877-4fb1-a48a-d0b0ca01eb23"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"Lead",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("83a900f2-650d-4af8-8b42-4730bdc2076e"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("b96b1ca6-35c7-4f2b-9344-720c982df478"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("396fe566-406a-403f-a5a5-6af7e082deb9"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("92959022-75ae-442f-86ef-9b01c388c38c"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("959b81bb-3ff0-43ae-9129-2f50675fc64d"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
			var activityResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3b18e768-4724-4d67-836a-cc1b4310b25e"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
			var incidentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("68f42e26-155e-4df5-9df2-41543aca9a91"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("73127a7c-1289-4e1b-8116-dc1191419c44"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
			var activityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7422cc60-2798-4064-84f0-b61ff20194c6"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"ActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activityIdParameter.SourceValue = new ProcessSchemaParameterValue(activityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activityIdParameter);
			var isActivityCompletedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6aa36187-c640-44b8-a099-21d088d631b1"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"IsActivityCompleted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isActivityCompletedParameter.SourceValue = new ProcessSchemaParameterValue(isActivityCompletedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var executionContextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("131c861e-e4b5-4cb8-add0-76db6ac463ed"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("883ae716-c06b-41a5-a98f-cea9cde03256"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("334b7e03-c84d-46cc-ae02-30e60226da8a"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
			var contractParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				UId = new Guid("703db63c-a4c5-4d00-99aa-8886e6f8ad64"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
			var propertyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("26810327-3097-4fe8-a1a1-66a1d38d218a"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
			var listingParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2f922d07-1465-46ff-89a8-6baac78050de"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
			var requestsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("77526092-2a5c-4e11-865e-760b484d2d5e"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
			var projectParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				UId = new Guid("50d6e9c3-54bb-4a5a-afc0-2c939d94b1b4"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("b82ba56c-dfcc-46d3-a733-b779b91d801b"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("5acd32c6-85a3-4f51-8f40-b4528de854c7"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("533b40fc-4e3e-4725-acf6-d5d6f8a2c575"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("00c6d940-fd61-4cf6-9434-c51565909d13"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
			var senderParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				UId = new Guid("db07491a-f5b1-439c-97a1-6af53ce909cd"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"Sender",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			senderParameter.SourceValue = new ProcessSchemaParameterValue(senderParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#SysSettings.LDAPLogNotificationSender<Guid>#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(senderParameter);
			var importanceParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("953f4a27-0013-452f-8b74-5d28dbcbf8c6"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"Importance",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			importanceParameter.SourceValue = new ProcessSchemaParameterValue(importanceParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(importanceParameter);
			var subjectParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b760a46f-1ff5-4b25-9a6f-af792f81b239"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"Subject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			subjectParameter.SourceValue = new ProcessSchemaParameterValue(subjectParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{aeb1a392-036e-4295-8e8d-f388946495a5}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(subjectParameter);
			var ignoreErrorsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e2a57e59-b1eb-4aaf-81ec-1719d9392746"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"IgnoreErrors",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreErrorsParameter.SourceValue = new ProcessSchemaParameterValue(ignoreErrorsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(ignoreErrorsParameter);
			var sendEmailTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b138f1ee-5c36-4c42-9abb-c1cd87be5b8e"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"SendEmailType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			sendEmailTypeParameter.SourceValue = new ProcessSchemaParameterValue(sendEmailTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(sendEmailTypeParameter);
			var bodyTemplateTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9c010bb6-8599-403e-b457-54ab13ff4c91"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"BodyTemplateType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			bodyTemplateTypeParameter.SourceValue = new ProcessSchemaParameterValue(bodyTemplateTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(bodyTemplateTypeParameter);
			var emailTemplateIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				UId = new Guid("09a73a34-9036-48e9-9e48-78e8873369b7"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"EmailTemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			emailTemplateIdParameter.SourceValue = new ProcessSchemaParameterValue(emailTemplateIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(emailTemplateIdParameter);
			var emailTemplateEntityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95428372-753c-42d5-b08f-5a8e7695dfa8"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"EmailTemplateEntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			emailTemplateEntityIdParameter.SourceValue = new ProcessSchemaParameterValue(emailTemplateEntityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(emailTemplateEntityIdParameter);
			var bodyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("126ba0f1-9346-426c-865c-079a6d0e9101"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = true,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"Body",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			bodyParameter.SourceValue = new ProcessSchemaParameterValue(bodyParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,88,91,111,227,54,22,126,239,175,224,40,88,96,102,97,90,118,238,145,47,216,109,38,69,7,104,183,131,110,6,109,17,228,129,146,104,155,27,74,84,41,250,86,215,255,125,15,73,73,166,46,118,50,187,47,11,108,2,219,226,33,121,238,231,59,164,198,239,62,254,116,255,248,219,231,7,180,80,9,71,159,191,124,251,195,167,123,228,97,223,255,229,226,222,247,63,62,126,68,191,126,255,248,227,15,104,216,31,160,71,73,210,156,41,38,82,194,125,255,225,31,30,242,22,74,101,129,239,175,215,235,254,250,162,47,228,220,127,252,217,223,104,94,67,189,185,120,196,202,217,217,143,85,236,77,199,122,2,190,41,137,167,227,132,42,130,52,43,76,127,95,178,213,196,187,23,169,162,169,194,143,219,140,122,40,178,163,137,167,232,70,249,122,227,8,69,11,34,115,170,38,95,30,191,195,183,158,95,240,200,164,200,168,84,219,137,39,230,129,98,138,187,187,171,85,41,73,232,196,91,49,186,206,132,84,206,138,53,139,213,98,18,211,21,139,40,54,131,30,75,65,109,194,113,30,17,78,39,195,138,135,171,237,175,248,203,223,241,189,72,50,162,88,88,19,249,233,97,66,227,57,213,187,140,54,211,177,95,252,230,106,203,41,82,96,95,97,86,148,231,222,244,76,44,21,23,226,5,145,93,70,226,152,165,243,96,176,15,69,188,221,25,109,130,225,96,240,151,119,44,209,106,147,84,237,251,63,131,251,126,204,231,223,214,87,236,251,15,27,69,37,248,250,158,147,60,63,62,211,171,15,81,204,86,77,210,12,76,105,210,178,38,33,207,72,218,164,169,120,199,89,74,241,130,178,249,66,89,233,164,23,114,17,189,252,190,20,138,246,180,89,61,206,122,89,79,17,240,90,15,54,224,53,13,95,152,194,218,33,56,103,127,80,76,226,127,45,115,187,123,132,147,252,200,76,146,11,236,8,195,114,201,105,64,55,36,82,124,187,175,184,235,85,102,128,57,40,28,209,96,48,58,144,100,73,10,133,140,169,196,122,232,184,63,33,114,206,82,152,62,132,133,37,243,157,93,12,228,166,169,35,29,72,160,193,148,81,57,166,145,144,68,23,64,144,138,148,26,91,24,36,137,204,4,55,100,156,136,152,6,33,139,150,240,217,147,167,13,38,89,6,122,197,68,17,216,173,104,164,132,204,159,119,145,224,66,6,44,93,80,201,212,33,21,58,165,56,211,58,140,198,111,29,91,205,220,140,36,140,111,143,205,174,173,101,237,89,215,238,214,172,117,125,225,36,12,154,115,146,229,52,40,31,154,11,117,202,28,91,107,163,224,56,216,209,161,29,155,81,103,181,252,45,161,49,35,72,164,124,139,242,72,82,154,34,146,198,232,125,66,54,182,216,131,203,219,65,182,249,176,235,39,34,204,23,98,189,139,89,158,113,178,13,140,122,142,68,177,162,114,198,197,58,88,177,156,213,166,246,253,84,192,238,106,103,35,12,86,204,192,161,20,38,13,92,22,5,124,96,83,44,187,67,232,134,215,217,230,56,26,140,18,150,226,78,195,33,83,251,51,78,55,90,85,204,18,50,167,165,39,201,82,137,150,122,45,247,110,186,217,254,199,213,92,119,202,254,100,96,92,48,174,226,243,255,230,160,186,193,186,78,14,242,28,241,215,3,112,143,163,152,197,138,179,203,203,203,90,141,19,9,13,173,183,160,124,69,21,139,72,47,135,222,140,115,40,221,153,3,19,195,203,108,211,168,110,211,8,29,39,158,107,113,163,163,21,219,82,26,17,212,223,66,93,73,21,45,21,244,158,246,124,0,2,95,58,39,116,161,41,26,23,240,119,118,113,125,87,3,166,203,65,27,103,151,41,232,165,45,232,208,68,99,119,89,162,44,213,139,70,78,192,247,125,125,198,192,148,211,4,118,233,118,103,120,31,198,89,21,58,139,61,56,164,51,33,53,216,55,232,100,166,76,123,104,144,115,69,164,106,147,105,26,235,158,84,192,217,190,159,211,140,128,49,66,150,162,123,109,18,94,75,104,20,84,214,154,60,155,167,160,78,21,147,22,170,22,92,106,184,21,211,252,69,137,12,135,36,122,153,75,1,222,219,29,30,139,156,48,204,1,222,24,148,201,137,117,208,68,15,20,73,51,74,116,74,23,79,21,3,136,103,82,195,201,145,65,83,198,153,218,58,89,228,172,70,127,53,61,124,193,160,83,18,206,33,76,219,80,178,184,206,201,182,243,136,234,249,210,166,163,11,194,165,82,208,123,11,95,54,82,194,166,75,103,103,173,118,170,197,174,145,135,95,209,102,222,224,242,90,95,120,221,243,205,243,97,151,171,139,243,142,88,59,72,225,120,190,104,105,71,29,223,192,166,110,31,55,23,185,129,130,222,169,97,135,99,194,33,79,3,216,251,10,192,238,251,36,38,153,98,43,48,221,120,189,119,32,24,176,118,198,58,88,221,224,223,13,232,141,160,116,11,213,105,224,200,200,23,148,170,221,241,157,251,32,40,11,27,226,15,137,28,18,89,1,134,46,86,168,189,52,178,158,172,12,6,36,173,78,55,208,196,58,88,64,174,45,147,208,9,121,112,22,135,250,255,13,25,119,125,99,51,174,200,218,5,225,51,157,1,221,9,111,183,92,213,66,240,6,25,231,119,231,39,101,184,204,27,1,222,143,125,115,31,130,235,145,189,16,234,102,137,56,157,41,11,134,19,111,224,33,251,104,175,104,122,12,137,211,154,181,46,52,4,49,155,233,251,161,126,52,188,39,94,9,172,112,249,180,231,77,11,139,102,137,134,131,226,248,88,141,139,43,128,25,151,140,181,226,30,42,148,176,131,130,251,177,62,168,165,73,248,64,23,211,249,62,241,34,170,207,253,30,90,21,99,176,3,214,188,195,248,137,205,208,251,185,162,8,106,13,221,125,248,243,253,167,135,15,207,165,174,133,72,104,241,175,43,123,176,171,148,13,252,159,160,187,176,217,51,198,149,245,115,211,76,39,222,217,204,252,1,31,125,113,155,120,245,68,175,12,252,223,63,114,180,61,81,243,212,16,8,44,134,72,85,21,244,168,29,113,8,80,61,34,53,191,219,80,191,230,248,194,129,141,246,235,77,209,88,233,140,214,191,82,127,53,68,161,78,89,157,188,80,171,7,188,170,85,91,122,37,176,144,97,42,83,215,170,247,53,37,225,106,59,69,150,121,203,182,114,213,213,237,161,14,187,64,167,178,183,58,134,235,51,27,129,121,137,156,230,161,141,121,99,165,88,47,158,168,185,175,46,35,167,132,78,106,17,151,134,150,247,81,116,5,73,123,112,197,205,160,161,72,131,181,53,163,88,160,65,240,171,194,82,129,93,89,162,87,186,61,141,218,93,215,129,226,83,21,213,192,4,123,132,110,71,201,235,72,175,66,149,255,26,19,204,9,204,234,173,221,49,90,131,182,230,220,27,132,146,146,23,172,199,150,104,198,46,181,236,162,139,109,182,160,105,110,218,255,8,39,226,143,58,197,29,212,115,246,141,37,95,59,128,160,55,0,64,35,69,116,134,20,207,88,219,88,35,72,131,134,46,5,194,87,27,135,2,122,110,98,72,29,111,100,154,121,111,85,118,239,52,90,67,184,19,65,210,65,143,123,58,123,72,8,227,72,191,85,60,123,246,144,121,5,101,223,84,126,150,34,162,121,254,25,78,48,9,53,21,101,38,129,253,146,234,141,79,159,242,159,214,144,13,255,140,22,52,33,193,140,240,156,62,247,129,218,32,84,12,130,93,124,67,47,104,116,126,141,111,239,110,174,241,101,12,79,228,14,190,194,155,11,122,115,113,55,188,56,15,201,254,89,235,81,246,224,171,219,102,79,26,222,245,111,110,135,135,35,212,213,109,182,57,0,212,240,206,243,167,223,140,51,56,93,100,211,111,208,216,55,41,234,155,72,248,101,92,124,147,178,211,230,108,65,60,94,237,126,163,185,158,94,43,167,37,207,250,30,35,180,144,122,84,151,211,154,214,103,173,94,117,129,167,109,56,166,220,56,148,126,215,18,223,8,28,155,215,241,211,127,3,52,104,132,124,71,24,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(bodyParameter);
			var bodyConfigParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c828d5b0-a444-4243-a108-cd25dd3dd2a0"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = true,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Name = @"BodyConfig",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			bodyConfigParameter.SourceValue = new ProcessSchemaParameterValue(bodyConfigParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,75,111,194,48,12,254,43,85,184,242,126,245,49,134,52,208,14,156,134,198,164,29,160,7,183,49,109,69,218,68,77,24,32,196,127,159,147,193,132,134,214,67,107,127,159,253,217,181,125,102,11,131,229,199,73,33,139,152,206,17,13,107,178,57,40,83,200,138,144,185,172,12,86,198,227,168,139,172,194,154,72,27,175,89,180,62,223,103,38,66,166,187,255,72,131,71,167,42,197,190,36,209,110,147,189,203,131,251,18,180,82,64,88,127,232,192,31,199,17,174,46,37,79,138,50,243,64,152,231,13,91,55,94,75,40,132,55,147,252,212,136,55,204,75,5,104,77,4,153,28,12,180,12,213,35,119,89,203,20,181,94,66,13,37,26,172,111,244,23,136,61,58,157,245,66,191,29,232,119,86,105,142,37,68,91,16,26,227,54,161,127,128,95,137,232,204,125,28,96,218,31,183,130,208,31,183,134,156,44,8,233,149,248,3,244,7,97,111,208,79,224,18,187,182,114,44,178,220,54,60,10,200,211,230,36,108,213,67,193,77,30,121,189,94,216,246,131,158,58,62,93,227,34,111,20,144,71,145,46,130,34,41,132,188,206,116,83,77,212,116,210,81,100,208,248,86,86,135,102,123,102,10,56,47,170,172,37,112,107,39,52,82,71,162,111,96,109,53,31,80,35,213,3,150,72,99,100,121,133,47,151,248,174,132,243,62,109,59,44,26,119,105,31,51,72,119,89,45,247,21,167,149,201,154,146,26,91,247,216,198,236,213,188,8,186,15,130,83,218,154,59,147,89,141,176,83,178,168,204,85,103,24,116,47,223,177,2,245,144,110,2,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(bodyConfigParameter);
			var createActivityParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("09a93c2b-915a-470a-a80c-0c680d44c1d1"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19")
			};
			parametrizedElement.Parameters.Add(createActivityParameter);
			var recipient1Parameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("b976035c-f70e-41b8-b529-d345c403d06c"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"Recipient1",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			recipient1Parameter.SourceValue = new ProcessSchemaParameterValue(recipient1Parameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{e6d9613e-c931-45a4-8289-34a64d103e30}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617")
			};
			parametrizedElement.Parameters.Add(recipient1Parameter);
			var omniChatParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("af1f685c-315b-4b44-a957-c5094417a57a"),
				UId = new Guid("48c8cbfc-612a-4dab-b34f-c3eb75382329"),
				ContainerUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"OmniChat",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			omniChatParameter.SourceValue = new ProcessSchemaParameterValue(omniChatParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(omniChatParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet62 = CreateLaneSet62LaneSet();
			LaneSets.Add(schemaLaneSet62);
			ProcessSchemaLane schemaLane166 = CreateLane166Lane();
			schemaLaneSet62.Lanes.Add(schemaLane166);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			FlowElements.Add(end1);
			ProcessSchemaScriptTask usersautoimportscripttask = CreateUsersAutoImportScriptTaskScriptTask();
			FlowElements.Add(usersautoimportscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask noaccessscripttask = CreateNoAccessScriptTaskScriptTask();
			FlowElements.Add(noaccessscripttask);
			ProcessSchemaScriptTask insertldapelementsscripttask = CreateInsertLDAPElementsScriptTaskScriptTask();
			FlowElements.Add(insertldapelementsscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			ProcessSchemaUserTask emailsendusertask = CreateEmailSendUserTaskUserTask();
			FlowElements.Add(emailsendusertask);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			FlowElements.Add(exclusivegateway3);
			ProcessSchemaExclusiveGateway checkcanuseldapgateway = CreateCheckCanUseLdapGatewayExclusiveGateway();
			FlowElements.Add(checkcanuseldapgateway);
			ProcessSchemaScriptTask lognotavailablefunctionality = CreateLogNotAvailableFunctionalityScriptTask();
			FlowElements.Add(lognotavailablefunctionality);
			FlowElements.Add(CreateSequenceFlow541SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateCanUseLdapCheckConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow541SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow541",
				UId = new Guid("d17d7a27-d07d-4922-9850-83e6c388d3cb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(130, 198),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(-156, 191),
				SequenceFlowStartPointPosition = new Point(-260, 191),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d9b99a5-0778-4b16-90d6-7a385850e5cd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f97d5d14-4494-43b3-a080-53add42b01e0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("4fa1d705-682f-4a80-aa72-3cedba1f4704"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"UserConnection.DBSecurityEngine.GetCanExecuteOperation(""CanManageAdministration"")",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97916cee-c1a7-4a71-815d-9d80f3965c04"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(298, 198),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e5d193f0-85fe-4fd8-8ab4-8c85dbf6a304"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("214f1782-408b-45a3-a66f-305ae7b2d818"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow2",
				UId = new Guid("4710cdc7-9c8a-481e-a7c0-b06862a27748"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97916cee-c1a7-4a71-815d-9d80f3965c04"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(294, 142),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e5d193f0-85fe-4fd8-8ab4-8c85dbf6a304"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f80232b1-1c8f-416a-a6b8-7c40d3e44979"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(133, 113));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("2c194e57-1aba-40e3-9118-ded5469ab527"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97916cee-c1a7-4a71-815d-9d80f3965c04"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(650, 137),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f80232b1-1c8f-416a-a6b8-7c40d3e44979"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6dce4d8c-057f-42ab-b2b1-ac53ac170c3e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1147, 113));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("b20b8d2d-d2aa-4d3d-b7b5-8e8e2abb02c9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("214f1782-408b-45a3-a66f-305ae7b2d818"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("233b45df-488c-4522-9045-2ed5b9134d61"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("2501ba77-13f6-4274-8b23-c777ef76faf0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"string.IsNullOrEmpty([#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{c241e947-d0e3-48ca-b0eb-5109850b0a5f}]#])",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("233b45df-488c-4522-9045-2ed5b9134d61"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0efac1d8-6a81-4348-ad2a-9a2f49b1cbe0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("7333476f-2abe-4077-837e-624d27d28899"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("233b45df-488c-4522-9045-2ed5b9134d61"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6dce4d8c-057f-42ab-b2b1-ac53ac170c3e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(493, 467));
			schemaFlow.PolylinePointPositions.Add(new Point(1147, 467));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("bf0c8218-90dd-4e90-86d9-ba9f09e1e37f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0efac1d8-6a81-4348-ad2a-9a2f49b1cbe0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dcdec0b2-6fc0-412a-917b-cf38319bc27f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("3ba25dcf-2521-41cf-869e-28bff4f7b03d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dcdec0b2-6fc0-412a-917b-cf38319bc27f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6dce4d8c-057f-42ab-b2b1-ac53ac170c3e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(773, 336));
			schemaFlow.PolylinePointPositions.Add(new Point(1147, 336));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("02614f52-5d70-40a3-a124-8e4425535446"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d7e3ec26-8976-4d26-a926-b73e739132ba}]#] != null && [#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d7e3ec26-8976-4d26-a926-b73e739132ba}]#].Length > 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dcdec0b2-6fc0-412a-917b-cf38319bc27f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("df0b2e37-bec2-4692-b9be-a45e60c1d5ed"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6dce4d8c-057f-42ab-b2b1-ac53ac170c3e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateCanUseLdapCheckConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "CanUseLdapCheck",
				UId = new Guid("4d0728aa-5bf2-4f0e-bf3a-ec4b4ac7c3ce"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ConditionExpression = @"UserConnection.LicHelper.GetHasOperationLicense(""CanUseLdap"")",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(105, 191),
				SequenceFlowStartPointPosition = new Point(-101, 191),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f97d5d14-4494-43b3-a080-53add42b01e0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e5d193f0-85fe-4fd8-8ab4-8c85dbf6a304"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow3",
				UId = new Guid("b5ace46f-bf5c-4f63-b1d6-8b536428a469"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f97d5d14-4494-43b3-a080-53add42b01e0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6f9f086c-03cd-4c01-82af-bcf4d9f839e8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(-128, 4));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f9c44183-83b5-4cb4-b113-8388391baaed"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				SequenceFlowEndPointPosition = new Point(1147, 177),
				SequenceFlowStartPointPosition = new Point(320, 4),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6f9f086c-03cd-4c01-82af-bcf4d9f839e8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6dce4d8c-057f-42ab-b2b1-ac53ac170c3e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1147, 4));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet62LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet62 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("963140b4-7029-452f-a00d-20f3514133d6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"LaneSet62",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet62;
		}

		protected virtual ProcessSchemaLane CreateLane166Lane() {
			ProcessSchemaLane schemaLane166 = new ProcessSchemaLane(this) {
				UId = new Guid("8e8dca88-60d7-4e46-8c62-837a3d952b4c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("963140b4-7029-452f-a00d-20f3514133d6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"Lane166",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane166;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("3d9b99a5-0778-4b16-90d6-7a385850e5cd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e8dca88-60d7-4e46-8c62-837a3d952b4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"Start1",
				Position = new Point(-287, 177),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("6dce4d8c-057f-42ab-b2b1-ac53ac170c3e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e8dca88-60d7-4e46-8c62-837a3d952b4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"End1",
				Position = new Point(1133, 177),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUsersAutoImportScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0efac1d8-6a81-4348-ad2a-9a2f49b1cbe0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e8dca88-60d7-4e46-8c62-837a3d952b4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("912fb492-38c7-4dbe-88b2-46a261777d72"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"UsersAutoImportScriptTask",
				Position = new Point(620, 163),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,221,111,218,48,16,127,14,18,255,195,53,15,85,144,144,217,59,218,164,150,161,78,83,58,85,100,29,207,174,115,192,173,193,206,252,49,150,77,251,223,119,142,67,91,144,152,20,164,112,254,125,221,157,51,155,193,98,135,234,25,202,143,55,15,224,208,123,210,91,55,30,209,6,138,171,178,150,237,163,167,134,60,161,19,61,110,133,63,2,89,172,35,188,26,208,197,163,67,187,48,90,163,242,100,244,100,2,127,198,163,172,234,180,90,161,11,141,135,247,176,180,214,216,139,2,101,53,103,130,223,89,115,0,141,7,88,254,82,216,70,169,226,85,100,194,144,191,227,209,108,6,177,150,226,6,246,229,172,63,165,5,199,197,53,249,93,172,63,88,163,208,185,79,216,180,104,217,60,74,86,151,206,207,195,179,205,69,45,241,86,165,136,208,147,38,7,236,82,215,88,207,83,172,152,176,36,23,79,47,171,222,161,143,33,92,60,189,39,231,120,36,37,41,212,14,93,111,66,155,226,168,35,22,38,104,15,31,224,93,26,114,244,56,88,217,254,183,209,123,244,59,83,187,117,194,21,126,71,46,202,102,3,81,44,44,74,143,43,220,147,174,217,251,182,27,120,189,121,22,111,66,213,185,227,174,196,87,219,113,224,111,178,9,120,54,187,41,228,209,181,52,219,47,198,211,134,148,140,213,10,121,30,54,159,130,9,30,98,94,155,246,9,169,131,94,63,149,224,138,91,8,77,3,215,215,80,220,5,170,39,240,122,16,255,139,229,190,245,221,192,203,150,123,73,77,21,158,190,179,251,208,124,105,148,108,232,183,124,106,176,242,150,227,158,37,20,107,99,159,93,43,21,10,222,154,9,86,49,206,88,185,197,105,47,153,229,23,239,73,30,187,59,151,119,226,109,8,209,15,37,239,167,54,196,187,53,117,199,217,142,147,230,193,189,148,95,118,58,224,211,104,20,181,132,58,161,220,41,147,151,112,83,243,142,152,98,37,167,118,9,84,12,252,213,41,55,5,140,247,174,127,17,159,13,233,34,159,115,27,103,38,137,206,159,86,252,241,99,209,7,171,193,219,128,243,127,62,157,81,226,30,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("e5d193f0-85fe-4fd8-8ab4-8c85dbf6a304"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e8dca88-60d7-4e46-8c62-837a3d952b4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97916cee-c1a7-4a71-815d-9d80f3965c04"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"ExclusiveGateway1",
				Position = new Point(105, 163),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateNoAccessScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f80232b1-1c8f-416a-a6b8-7c40d3e44979"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e8dca88-60d7-4e46-8c62-837a3d952b4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("97916cee-c1a7-4a71-815d-9d80f3965c04"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"NoAccessScriptTask",
				Position = new Point(251, 85),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,11,174,204,75,14,74,45,46,205,41,81,176,85,240,203,119,76,78,78,45,46,246,5,226,196,244,84,107,94,174,178,196,34,133,156,252,116,160,156,79,126,186,111,98,30,80,180,72,207,61,181,4,200,3,178,52,148,124,92,28,3,148,52,129,10,129,138,244,92,82,147,74,211,53,130,225,38,130,196,139,82,75,74,139,242,20,74,138,74,83,173,1,251,185,135,195,108,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateInsertLDAPElementsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("214f1782-408b-45a3-a66f-305ae7b2d818"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e8dca88-60d7-4e46-8c62-837a3d952b4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"InsertLDAPElementsScriptTask",
				Position = new Point(340, 163),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,65,106,195,48,16,69,215,54,248,14,67,86,10,20,95,32,100,81,82,167,4,156,82,106,122,0,213,158,218,2,69,10,51,99,167,166,228,238,149,226,208,36,52,139,238,36,253,255,102,254,215,160,9,172,111,97,9,165,111,183,218,233,22,41,127,70,9,183,112,82,179,242,233,241,117,54,95,100,169,208,8,223,89,154,12,17,104,244,190,66,26,76,141,1,116,120,128,104,171,70,174,80,196,184,150,207,162,138,96,114,229,206,55,142,145,36,186,11,139,59,116,194,234,61,188,172,188,115,88,139,241,46,18,71,168,181,212,29,168,50,144,197,87,141,251,168,0,206,79,1,204,39,40,204,11,34,31,176,38,4,88,194,198,13,218,154,102,69,216,132,145,70,91,254,149,39,38,169,70,87,191,33,247,86,224,142,125,139,204,161,120,12,123,4,180,140,119,160,75,196,23,47,5,139,254,176,134,59,108,174,217,88,214,183,83,54,117,161,31,66,244,168,75,71,254,112,221,239,79,183,155,141,44,20,254,50,95,123,218,105,81,167,161,55,51,243,243,234,233,147,255,179,55,75,9,165,39,7,66,61,46,126,0,21,40,86,27,251,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("233b45df-488c-4522-9045-2ed5b9134d61"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e8dca88-60d7-4e46-8c62-837a3d952b4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"ExclusiveGateway2",
				Position = new Point(465, 163),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateEmailSendUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e8dca88-60d7-4e46-8c62-837a3d952b4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"EmailSendUserTask",
				Position = new Point(971, 163),
				SchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeEmailSendUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("dcdec0b2-6fc0-412a-917b-cf38319bc27f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e8dca88-60d7-4e46-8c62-837a3d952b4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"ExclusiveGateway3",
				Position = new Point(745, 163),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateCheckCanUseLdapGatewayExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("f97d5d14-4494-43b3-a080-53add42b01e0"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e8dca88-60d7-4e46-8c62-837a3d952b4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"CheckCanUseLdapGateway",
				Position = new Point(-156, 163),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateLogNotAvailableFunctionalityScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6f9f086c-03cd-4c01-82af-bcf4d9f839e8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e8dca88-60d7-4e46-8c62-837a3d952b4c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bb1e143e-f3ee-4316-9450-851ddd02d999"),
				CreatedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"),
				Name = @"LogNotAvailableFunctionality",
				Position = new Point(251, -24),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,11,174,204,75,14,74,45,46,205,41,81,176,85,240,203,47,113,44,75,204,204,73,76,202,73,117,43,205,75,46,201,204,207,75,204,201,44,169,180,230,229,42,75,44,82,200,201,79,7,170,242,201,79,247,77,204,75,76,79,45,210,115,79,45,1,242,128,44,13,37,31,23,199,0,37,77,160,66,160,34,189,240,196,162,60,141,96,184,209,32,225,162,212,146,210,162,60,133,146,162,210,84,107,0,19,240,62,213,117,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("965baacf-c7aa-4161-a95e-2c2d7b8f4cbb"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1330ddd7-eaaa-4ca5-ab7c-57899370ec73"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3609334e-ba40-4df8-9807-fb41f44bfe91"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0ec5cb84-ec2a-43e2-819e-d638446aaf82"),
				Name = "System.DirectoryServices.Protocols",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("27850d19-dcd3-49e7-bdaa-192704764402"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2fa6ea01-2c71-41e2-9c20-f42ca8fd5671"),
				Name = "Terrasoft.UI.WebControls.Utilities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("754b28c5-0a4a-42df-b596-d8563d7096d3"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9390cd3c-c416-4c74-95e9-5b85e347b815"),
				Name = "Terrasoft.Configuration.LDAP",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ac0921a0-6982-4abc-bdd3-4bac6be144f2"),
				Name = "global::Common.Logging",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2419d58a-33e7-4a62-b2b1-40e95835c2cf"),
				Name = "Terrasoft.Configuration.LDAPSysSettingsService",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7d24f034-b91f-4fdd-967f-79621e7072ce"),
				Name = "Terrasoft.Core.Configuration.SysSettings",
				Alias = "SysSettings",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a2de64c7-a361-4b8f-81a1-165cd75e35d7"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SyncWithLDAPProcess(userConnection);
		}

		public override object Clone() {
			return new SyncWithLDAPProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c2aa62d6-6228-4d1a-a472-acaced886617"));
		}

		#endregion

	}

	#endregion

	#region Class: SyncWithLDAPProcessMethodsWrapper

	/// <exclude/>
	public class SyncWithLDAPProcessMethodsWrapper : ProcessModel
	{

		public SyncWithLDAPProcessMethodsWrapper(Process process)
			: base(process) {
		}

		#region Methods: Private

			public virtual void CreateRemindingByProcess() {
				var message = new LocalizableString(UserConnection.Workspace.ResourceStorage, "SyncWithLDAPProcessHelper",
					"LocalizableStrings.LDAPLicenseNotification.Value");
				LDAPUtility.CreateRemindingByProcess(UserConnection, "SyncWithLDAPProcess",
					message, null, false);
			}
			
			public virtual string GetEmailBody(List<LDAPLicenseInfo> users) {
					var emailBody = new StringBuilder();
					emailBody.Append(Get<string>("LDAPEmailMessage"));
					foreach (var user in users) {
					var logMessage = new StringBuilder();
					logMessage.Append($"(id: {user.UserId}) | {user.UserName} | ");
					List<string> missingLicenses = user.MissingLicenses;
					IOrderedEnumerable<string> orderedMissingLicenses =
						missingLicenses.OrderBy(firstLetter => firstLetter);
					var missingLicensesString = string.Join(", ", orderedMissingLicenses);
					logMessage.Append(missingLicensesString);
					logMessage.Append(".");
					emailBody.AppendFormat("{0}{1}{2}", "<br>", logMessage, Environment.NewLine);
				}
				return emailBody.ToString();
			}
			
			public virtual List<string> GetSysAdministratorsEmails() {
				var userIds = new List<string>();
				var sysAdminRoleId = BaseConsts.SystemAdministratorsSysAdminUnitId;
				var select =
					new Select(UserConnection)
						.Column("Contact", "Email")
					.From("SysAdminUnit")
					.InnerJoin("Contact").On("SysAdminUnit", "ContactId").IsEqual("Contact", "Id")
					.InnerJoin("SysAdminUnitInRole").On("SysAdminUnit", "Id")
						.IsEqual("SysAdminUnitInRole", "SysAdminUnitId")
					.Where("SysAdminUnitInRole", "SysAdminUnitRoleId")
						.IsEqual(Column.Parameter(sysAdminRoleId))
					.OrderByAsc("Contact", "Email") as Select;
				if (UserConnection.DBEngine.DBEngineType != DBEngineType.Oracle) {
					select.And("Contact", "Email").IsNotEqual(Column.Parameter(""));
				} else {
					select.And("Contact", "Email").Not().IsNull();
				}
				select.ExecuteReader(r => {
					var userEmail = r.GetColumnValue<string>("Email");
					userIds.Add(userEmail);
				});
				return userIds;
			}

		#endregion

	}

	#endregion

	#region Class: SyncWithLDAPProcess

	/// <exclude/>
	public class SyncWithLDAPProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane166

		/// <exclude/>
		public class ProcessLane166 : ProcessLane
		{

			public ProcessLane166(UserConnection userConnection, SyncWithLDAPProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: EmailSendUserTaskFlowElement

		/// <exclude/>
		public class EmailSendUserTaskFlowElement : EmailTemplateUserTask
		{

			#region Constructors: Public

			public EmailSendUserTaskFlowElement(UserConnection userConnection, SyncWithLDAPProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "EmailSendUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("39fd1969-f920-4b4f-8953-8d8f00efac7c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane166;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
				_sender = () => (Guid)(((Guid)SysSettings.GetValue(UserConnection, "LDAPLogNotificationSender")));
				_subject = () => new LocalizableString((process.EmailSubject));
				_recipient1 = () => new LocalizableString((process.RecipientEmailsString));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "BaseElements.EmailSendUserTask.Parameters.Recommendation.Value"));
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

			private int _startIn = 0;
			public override int StartIn {
				get {
					return _startIn;
				}
				set {
					_startIn = value;
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

			private int _remindBefore = 0;
			public override int RemindBefore {
				get {
					return _remindBefore;
				}
				set {
					_remindBefore = value;
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

			internal Func<Guid> _sender;
			public override Guid Sender {
				get {
					return (_sender ?? (_sender = () => Guid.Empty)).Invoke();
				}
				set {
					_sender = () => { return value; };
				}
			}

			private int _importance = 1;
			public override int Importance {
				get {
					return _importance;
				}
				set {
					_importance = value;
				}
			}

			internal Func<LocalizableString> _subject;
			public override LocalizableString Subject {
				get {
					return (_subject ?? (_subject = () => null)).Invoke();
				}
				set {
					_subject = () => { return value; };
				}
			}

			private bool _ignoreErrors = true;
			public override bool IgnoreErrors {
				get {
					return _ignoreErrors;
				}
				set {
					_ignoreErrors = value;
				}
			}

			private int _sendEmailType = 0;
			public override int SendEmailType {
				get {
					return _sendEmailType;
				}
				set {
					_sendEmailType = value;
				}
			}

			private int _bodyTemplateType = 1;
			public override int BodyTemplateType {
				get {
					return _bodyTemplateType;
				}
				set {
					_bodyTemplateType = value;
				}
			}

			private string _body;
			public override string Body {
				get {
					return _body ?? (_body = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,229,88,91,111,227,54,22,126,239,175,224,40,88,96,102,97,90,118,238,145,47,216,109,38,69,7,104,183,131,110,6,109,17,228,129,146,104,155,27,74,84,41,250,86,215,255,125,15,73,73,166,46,118,50,187,47,11,108,2,219,226,33,121,238,231,59,164,198,239,62,254,116,255,248,219,231,7,180,80,9,71,159,191,124,251,195,167,123,228,97,223,255,229,226,222,247,63,62,126,68,191,126,255,248,227,15,104,216,31,160,71,73,210,156,41,38,82,194,125,255,225,31,30,242,22,74,101,129,239,175,215,235,254,250,162,47,228,220,127,252,217,223,104,94,67,189,185,120,196,202,217,217,143,85,236,77,199,122,2,190,41,137,167,227,132,42,130,52,43,76,127,95,178,213,196,187,23,169,162,169,194,143,219,140,122,40,178,163,137,167,232,70,249,122,227,8,69,11,34,115,170,38,95,30,191,195,183,158,95,240,200,164,200,168,84,219,137,39,230,129,98,138,187,187,171,85,41,73,232,196,91,49,186,206,132,84,206,138,53,139,213,98,18,211,21,139,40,54,131,30,75,65,109,194,113,30,17,78,39,195,138,135,171,237,175,248,203,223,241,189,72,50,162,88,88,19,249,233,97,66,227,57,213,187,140,54,211,177,95,252,230,106,203,41,82,96,95,97,86,148,231,222,244,76,44,21,23,226,5,145,93,70,226,152,165,243,96,176,15,69,188,221,25,109,130,225,96,240,151,119,44,209,106,147,84,237,251,63,131,251,126,204,231,223,214,87,236,251,15,27,69,37,248,250,158,147,60,63,62,211,171,15,81,204,86,77,210,12,76,105,210,178,38,33,207,72,218,164,169,120,199,89,74,241,130,178,249,66,89,233,164,23,114,17,189,252,190,20,138,246,180,89,61,206,122,89,79,17,240,90,15,54,224,53,13,95,152,194,218,33,56,103,127,80,76,226,127,45,115,187,123,132,147,252,200,76,146,11,236,8,195,114,201,105,64,55,36,82,124,187,175,184,235,85,102,128,57,40,28,209,96,48,58,144,100,73,10,133,140,169,196,122,232,184,63,33,114,206,82,152,62,132,133,37,243,157,93,12,228,166,169,35,29,72,160,193,148,81,57,166,145,144,68,23,64,144,138,148,26,91,24,36,137,204,4,55,100,156,136,152,6,33,139,150,240,217,147,167,13,38,89,6,122,197,68,17,216,173,104,164,132,204,159,119,145,224,66,6,44,93,80,201,212,33,21,58,165,56,211,58,140,198,111,29,91,205,220,140,36,140,111,143,205,174,173,101,237,89,215,238,214,172,117,125,225,36,12,154,115,146,229,52,40,31,154,11,117,202,28,91,107,163,224,56,216,209,161,29,155,81,103,181,252,45,161,49,35,72,164,124,139,242,72,82,154,34,146,198,232,125,66,54,182,216,131,203,219,65,182,249,176,235,39,34,204,23,98,189,139,89,158,113,178,13,140,122,142,68,177,162,114,198,197,58,88,177,156,213,166,246,253,84,192,238,106,103,35,12,86,204,192,161,20,38,13,92,22,5,124,96,83,44,187,67,232,134,215,217,230,56,26,140,18,150,226,78,195,33,83,251,51,78,55,90,85,204,18,50,167,165,39,201,82,137,150,122,45,247,110,186,217,254,199,213,92,119,202,254,100,96,92,48,174,226,243,255,230,160,186,193,186,78,14,242,28,241,215,3,112,143,163,152,197,138,179,203,203,203,90,141,19,9,13,173,183,160,124,69,21,139,72,47,135,222,140,115,40,221,153,3,19,195,203,108,211,168,110,211,8,29,39,158,107,113,163,163,21,219,82,26,17,212,223,66,93,73,21,45,21,244,158,246,124,0,2,95,58,39,116,161,41,26,23,240,119,118,113,125,87,3,166,203,65,27,103,151,41,232,165,45,232,208,68,99,119,89,162,44,213,139,70,78,192,247,125,125,198,192,148,211,4,118,233,118,103,120,31,198,89,21,58,139,61,56,164,51,33,53,216,55,232,100,166,76,123,104,144,115,69,164,106,147,105,26,235,158,84,192,217,190,159,211,140,128,49,66,150,162,123,109,18,94,75,104,20,84,214,154,60,155,167,160,78,21,147,22,170,22,92,106,184,21,211,252,69,137,12,135,36,122,153,75,1,222,219,29,30,139,156,48,204,1,222,24,148,201,137,117,208,68,15,20,73,51,74,116,74,23,79,21,3,136,103,82,195,201,145,65,83,198,153,218,58,89,228,172,70,127,53,61,124,193,160,83,18,206,33,76,219,80,178,184,206,201,182,243,136,234,249,210,166,163,11,194,165,82,208,123,11,95,54,82,194,166,75,103,103,173,118,170,197,174,145,135,95,209,102,222,224,242,90,95,120,221,243,205,243,97,151,171,139,243,142,88,59,72,225,120,190,104,105,71,29,223,192,166,110,31,55,23,185,129,130,222,169,97,135,99,194,33,79,3,216,251,10,192,238,251,36,38,153,98,43,48,221,120,189,119,32,24,176,118,198,58,88,221,224,223,13,232,141,160,116,11,213,105,224,200,200,23,148,170,221,241,157,251,32,40,11,27,226,15,137,28,18,89,1,134,46,86,168,189,52,178,158,172,12,6,36,173,78,55,208,196,58,88,64,174,45,147,208,9,121,112,22,135,250,255,13,25,119,125,99,51,174,200,218,5,225,51,157,1,221,9,111,183,92,213,66,240,6,25,231,119,231,39,101,184,204,27,1,222,143,125,115,31,130,235,145,189,16,234,102,137,56,157,41,11,134,19,111,224,33,251,104,175,104,122,12,137,211,154,181,46,52,4,49,155,233,251,161,126,52,188,39,94,9,172,112,249,180,231,77,11,139,102,137,134,131,226,248,88,141,139,43,128,25,151,140,181,226,30,42,148,176,131,130,251,177,62,168,165,73,248,64,23,211,249,62,241,34,170,207,253,30,90,21,99,176,3,214,188,195,248,137,205,208,251,185,162,8,106,13,221,125,248,243,253,167,135,15,207,165,174,133,72,104,241,175,43,123,176,171,148,13,252,159,160,187,176,217,51,198,149,245,115,211,76,39,222,217,204,252,1,31,125,113,155,120,245,68,175,12,252,223,63,114,180,61,81,243,212,16,8,44,134,72,85,21,244,168,29,113,8,80,61,34,53,191,219,80,191,230,248,194,129,141,246,235,77,209,88,233,140,214,191,82,127,53,68,161,78,89,157,188,80,171,7,188,170,85,91,122,37,176,144,97,42,83,215,170,247,53,37,225,106,59,69,150,121,203,182,114,213,213,237,161,14,187,64,167,178,183,58,134,235,51,27,129,121,137,156,230,161,141,121,99,165,88,47,158,168,185,175,46,35,167,132,78,106,17,151,134,150,247,81,116,5,73,123,112,197,205,160,161,72,131,181,53,163,88,160,65,240,171,194,82,129,93,89,162,87,186,61,141,218,93,215,129,226,83,21,213,192,4,123,132,110,71,201,235,72,175,66,149,255,26,19,204,9,204,234,173,221,49,90,131,182,230,220,27,132,146,146,23,172,199,150,104,198,46,181,236,162,139,109,182,160,105,110,218,255,8,39,226,143,58,197,29,212,115,246,141,37,95,59,128,160,55,0,64,35,69,116,134,20,207,88,219,88,35,72,131,134,46,5,194,87,27,135,2,122,110,98,72,29,111,100,154,121,111,85,118,239,52,90,67,184,19,65,210,65,143,123,58,123,72,8,227,72,191,85,60,123,246,144,121,5,101,223,84,126,150,34,162,121,254,25,78,48,9,53,21,101,38,129,253,146,234,141,79,159,242,159,214,144,13,255,140,22,52,33,193,140,240,156,62,247,129,218,32,84,12,130,93,124,67,47,104,116,126,141,111,239,110,174,241,101,12,79,228,14,190,194,155,11,122,115,113,55,188,56,15,201,254,89,235,81,246,224,171,219,102,79,26,222,245,111,110,135,135,35,212,213,109,182,57,0,212,240,206,243,167,223,140,51,56,93,100,211,111,208,216,55,41,234,155,72,248,101,92,124,147,178,211,230,108,65,60,94,237,126,163,185,158,94,43,167,37,207,250,30,35,180,144,122,84,151,211,154,214,103,173,94,117,129,167,109,56,166,220,56,148,126,215,18,223,8,28,155,215,241,211,127,3,52,104,132,124,71,24,0,0 })));
				}
				set {
					_body = value;
				}
			}

			private string _bodyConfig;
			public override string BodyConfig {
				get {
					return _bodyConfig ?? (_bodyConfig = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,75,111,194,48,12,254,43,85,184,242,126,245,49,134,52,208,14,156,134,198,164,29,160,7,183,49,109,69,218,68,77,24,32,196,127,159,147,193,132,134,214,67,107,127,159,253,217,181,125,102,11,131,229,199,73,33,139,152,206,17,13,107,178,57,40,83,200,138,144,185,172,12,86,198,227,168,139,172,194,154,72,27,175,89,180,62,223,103,38,66,166,187,255,72,131,71,167,42,197,190,36,209,110,147,189,203,131,251,18,180,82,64,88,127,232,192,31,199,17,174,46,37,79,138,50,243,64,152,231,13,91,55,94,75,40,132,55,147,252,212,136,55,204,75,5,104,77,4,153,28,12,180,12,213,35,119,89,203,20,181,94,66,13,37,26,172,111,244,23,136,61,58,157,245,66,191,29,232,119,86,105,142,37,68,91,16,26,227,54,161,127,128,95,137,232,204,125,28,96,218,31,183,130,208,31,183,134,156,44,8,233,149,248,3,244,7,97,111,208,79,224,18,187,182,114,44,178,220,54,60,10,200,211,230,36,108,213,67,193,77,30,121,189,94,216,246,131,158,58,62,93,227,34,111,20,144,71,145,46,130,34,41,132,188,206,116,83,77,212,116,210,81,100,208,248,86,86,135,102,123,102,10,56,47,170,172,37,112,107,39,52,82,71,162,111,96,109,53,31,80,35,213,3,150,72,99,100,121,133,47,151,248,174,132,243,62,109,59,44,26,119,105,31,51,72,119,89,45,247,21,167,149,201,154,146,26,91,247,216,198,236,213,188,8,186,15,130,83,218,154,59,147,89,141,176,83,178,168,204,85,103,24,116,47,223,177,2,245,144,110,2,0,0 })));
				}
				set {
					_bodyConfig = value;
				}
			}

			internal Func<string> _recipient1;
			public virtual string Recipient1 {
				get {
					return (_recipient1 ?? (_recipient1 = () => null)).Invoke();
				}
				set {
					_recipient1 = () => { return value; };
				}
			}

			public virtual Guid OmniChat {
				get;
				set;
			}

			#endregion

			#region Methods: Protected

			protected override void AfterActivitySaveScriptExecute(Entity activity) {
			}

			#endregion

		}

		#endregion

		public SyncWithLDAPProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SyncWithLDAPProcess";
			SchemaUId = new Guid("c2aa62d6-6228-4d1a-a472-acaced886617");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			ProcessModel = new SyncWithLDAPProcessMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c2aa62d6-6228-4d1a-a472-acaced886617");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SyncWithLDAPProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SyncWithLDAPProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual string PageInstanceId {
			get;
			set;
		}

		public virtual Guid ActiveTreeGridCurrentRowId {
			get;
			set;
		}

		public virtual bool DoOpenList {
			get;
			set;
		}

		private Guid _showLDAPMessageId = new Guid("{83A1E9EA-651D-4600-B027-886C6EFA6524}");
		public Guid ShowLDAPMessageId {
			get {
				return _showLDAPMessageId;
			}
			set {
				_showLDAPMessageId = value;
			}
		}

		public virtual string NotLicensedUserNames {
			get;
			set;
		}

		public virtual string SyncResult {
			get;
			set;
		}

		private LocalizableString _newUsersQuestionLS;
		public virtual LocalizableString NewUsersQuestionLS {
			get {
				return _newUsersQuestionLS ?? (_newUsersQuestionLS = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.NewUsersQuestionLS.Value"));
			}
			set {
				_newUsersQuestionLS = value;
			}
		}

		private LocalizableString _notActiveUsersLS;
		public virtual LocalizableString NotActiveUsersLS {
			get {
				return _notActiveUsersLS ?? (_notActiveUsersLS = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.NotActiveUsersLS.Value"));
			}
			set {
				_notActiveUsersLS = value;
			}
		}

		private LocalizableString _newUsersInGroupLS;
		public virtual LocalizableString NewUsersInGroupLS {
			get {
				return _newUsersInGroupLS ?? (_newUsersInGroupLS = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.NewUsersInGroupLS.Value"));
			}
			set {
				_newUsersInGroupLS = value;
			}
		}

		private LocalizableString _processSynchWithLDAPLaunchedLS;
		public virtual LocalizableString ProcessSynchWithLDAPLaunchedLS {
			get {
				return _processSynchWithLDAPLaunchedLS ?? (_processSynchWithLDAPLaunchedLS = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.ProcessSynchWithLDAPLaunchedLS.Value"));
			}
			set {
				_processSynchWithLDAPLaunchedLS = value;
			}
		}

		private LocalizableString _errorCheckRequiredLDAPSettingsLS;
		public virtual LocalizableString ErrorCheckRequiredLDAPSettingsLS {
			get {
				return _errorCheckRequiredLDAPSettingsLS ?? (_errorCheckRequiredLDAPSettingsLS = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.ErrorCheckRequiredLDAPSettingsLS.Value"));
			}
			set {
				_errorCheckRequiredLDAPSettingsLS = value;
			}
		}

		private LocalizableString _lDAPUsersWereAddedLS;
		public virtual LocalizableString LDAPUsersWereAddedLS {
			get {
				return _lDAPUsersWereAddedLS ?? (_lDAPUsersWereAddedLS = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.LDAPUsersWereAddedLS.Value"));
			}
			set {
				_lDAPUsersWereAddedLS = value;
			}
		}

		private LocalizableString _serverErrorLS;
		public virtual LocalizableString ServerErrorLS {
			get {
				return _serverErrorLS ?? (_serverErrorLS = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.ServerErrorLS.Value"));
			}
			set {
				_serverErrorLS = value;
			}
		}

		private LocalizableString _processEnded;
		public virtual LocalizableString ProcessEnded {
			get {
				return _processEnded ?? (_processEnded = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.ProcessEnded.Value"));
			}
			set {
				_processEnded = value;
			}
		}

		private LocalizableString _messageLog;
		public virtual LocalizableString MessageLog {
			get {
				return _messageLog ?? (_messageLog = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.MessageLog.Value"));
			}
			set {
				_messageLog = value;
			}
		}

		private LocalizableString _noAccessMessage;
		public virtual LocalizableString NoAccessMessage {
			get {
				return _noAccessMessage ?? (_noAccessMessage = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.NoAccessMessage.Value"));
			}
			set {
				_noAccessMessage = value;
			}
		}

		private int _invalidCredentialsErrorCode = 49;
		public int InvalidCredentialsErrorCode {
			get {
				return _invalidCredentialsErrorCode;
			}
			set {
				_invalidCredentialsErrorCode = value;
			}
		}

		private string _invalidCredentialMessage;
		public virtual string InvalidCredentialMessage {
			get {
				return _invalidCredentialMessage ?? (_invalidCredentialMessage = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.InvalidCredentialMessage.Value"));
			}
			set {
				_invalidCredentialMessage = value;
			}
		}

		private string _connectionNotEstablishedMessage;
		public virtual string ConnectionNotEstablishedMessage {
			get {
				return _connectionNotEstablishedMessage ?? (_connectionNotEstablishedMessage = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.ConnectionNotEstablishedMessage.Value"));
			}
			set {
				_connectionNotEstablishedMessage = value;
			}
		}

		private string _errorSyncResult;
		public virtual string ErrorSyncResult {
			get {
				return _errorSyncResult ?? (_errorSyncResult = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.ErrorSyncResult.Value"));
			}
			set {
				_errorSyncResult = value;
			}
		}

		public virtual string EmailSubject {
			get;
			set;
		}

		public virtual string EmailBody {
			get;
			set;
		}

		public virtual string RecipientEmailsString {
			get;
			set;
		}

		private string _lDAPEmailMessage;
		public virtual string LDAPEmailMessage {
			get {
				return _lDAPEmailMessage ?? (_lDAPEmailMessage = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.LDAPEmailMessage.Value"));
			}
			set {
				_lDAPEmailMessage = value;
			}
		}

		private string _notAvailableFunctionality;
		public virtual string NotAvailableFunctionality {
			get {
				return _notAvailableFunctionality ?? (_notAvailableFunctionality = GetLocalizableString("c2aa62d662284d1aa472acaced886617",
						 "Parameters.NotAvailableFunctionality.Value"));
			}
			set {
				_notAvailableFunctionality = value;
			}
		}

		private ProcessLane166 _lane166;
		public ProcessLane166 Lane166 {
			get {
				return _lane166 ?? ((_lane166) = new ProcessLane166(UserConnection, this));
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
					SchemaElementUId = new Guid("3d9b99a5-0778-4b16-90d6-7a385850e5cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessEndEvent _end1;
		public ProcessEndEvent End1 {
			get {
				return _end1 ?? (_end1 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End1",
					SchemaElementUId = new Guid("6dce4d8c-057f-42ab-b2b1-ac53ac170c3e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _usersAutoImportScriptTask;
		public ProcessScriptTask UsersAutoImportScriptTask {
			get {
				return _usersAutoImportScriptTask ?? (_usersAutoImportScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UsersAutoImportScriptTask",
					SchemaElementUId = new Guid("0efac1d8-6a81-4348-ad2a-9a2f49b1cbe0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = UsersAutoImportScriptTaskExecute,
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
					SchemaElementUId = new Guid("e5d193f0-85fe-4fd8-8ab4-8c85dbf6a304"),
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

		private ProcessScriptTask _noAccessScriptTask;
		public ProcessScriptTask NoAccessScriptTask {
			get {
				return _noAccessScriptTask ?? (_noAccessScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "NoAccessScriptTask",
					SchemaElementUId = new Guid("f80232b1-1c8f-416a-a6b8-7c40d3e44979"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = NoAccessScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _insertLDAPElementsScriptTask;
		public ProcessScriptTask InsertLDAPElementsScriptTask {
			get {
				return _insertLDAPElementsScriptTask ?? (_insertLDAPElementsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InsertLDAPElementsScriptTask",
					SchemaElementUId = new Guid("214f1782-408b-45a3-a66f-305ae7b2d818"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = InsertLDAPElementsScriptTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("233b45df-488c-4522-9045-2ed5b9134d61"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private EmailSendUserTaskFlowElement _emailSendUserTask;
		public EmailSendUserTaskFlowElement EmailSendUserTask {
			get {
				return _emailSendUserTask ?? (_emailSendUserTask = new EmailSendUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3;
		public ProcessExclusiveGateway ExclusiveGateway3 {
			get {
				return _exclusiveGateway3 ?? (_exclusiveGateway3 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3",
					SchemaElementUId = new Guid("dcdec0b2-6fc0-412a-917b-cf38319bc27f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway3.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessExclusiveGateway _checkCanUseLdapGateway;
		public ProcessExclusiveGateway CheckCanUseLdapGateway {
			get {
				return _checkCanUseLdapGateway ?? (_checkCanUseLdapGateway = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "CheckCanUseLdapGateway",
					SchemaElementUId = new Guid("f97d5d14-4494-43b3-a080-53add42b01e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.CheckCanUseLdapGateway.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _logNotAvailableFunctionality;
		public ProcessScriptTask LogNotAvailableFunctionality {
			get {
				return _logNotAvailableFunctionality ?? (_logNotAvailableFunctionality = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LogNotAvailableFunctionality",
					SchemaElementUId = new Guid("6f9f086c-03cd-4c01-82af-bcf4d9f839e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = LogNotAvailableFunctionalityExecute,
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
					SchemaElementUId = new Guid("4fa1d705-682f-4a80-aa72-3cedba1f4704"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
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
					SchemaElementUId = new Guid("2501ba77-13f6-4274-8b23-c777ef76faf0"),
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
					SchemaElementUId = new Guid("02614f52-5d70-40a3-a124-8e4425535446"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _canUseLdapCheck;
		public ProcessConditionalFlow CanUseLdapCheck {
			get {
				return _canUseLdapCheck ?? (_canUseLdapCheck = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "CanUseLdapCheck",
					SchemaElementUId = new Guid("4d0728aa-5bf2-4f0e-bf3a-ec4b4ac7c3ce"),
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
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[UsersAutoImportScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UsersAutoImportScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[NoAccessScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { NoAccessScriptTask };
			FlowElements[InsertLDAPElementsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertLDAPElementsScriptTask };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[EmailSendUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EmailSendUserTask };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[CheckCanUseLdapGateway.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckCanUseLdapGateway };
			FlowElements[LogNotAvailableFunctionality.SchemaElementUId] = new Collection<ProcessFlowElement> { LogNotAvailableFunctionality };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CheckCanUseLdapGateway", e.Context.SenderName));
						break;
					case "End1":
						CompleteProcess();
						break;
					case "UsersAutoImportScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway3", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InsertLDAPElementsScriptTask", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("NoAccessScriptTask", e.Context.SenderName));
						break;
					case "NoAccessScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
					case "InsertLDAPElementsScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("UsersAutoImportScriptTask", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
					case "EmailSendUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
					case "ExclusiveGateway3":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("EmailSendUserTask", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
					case "CheckCanUseLdapGateway":
						if (CanUseLdapCheckExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LogNotAvailableFunctionality", e.Context.SenderName));
						break;
					case "LogNotAvailableFunctionality":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanManageAdministration"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow1", "UserConnection.DBSecurityEngine.GetCanExecuteOperation(\"CanManageAdministration\")", result);
			return result;
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(string.IsNullOrEmpty((SyncResult)));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "ConditionalSequenceFlow1", "string.IsNullOrEmpty((SyncResult))", result);
			return result;
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((EmailBody) != null && (EmailBody).Length > 0);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway3", "ConditionalSequenceFlow2", "(EmailBody) != null && (EmailBody).Length > 0", result);
			return result;
		}

		private bool CanUseLdapCheckExpressionExecute() {
			bool result = Convert.ToBoolean(UserConnection.LicHelper.GetHasOperationLicense("CanUseLdap"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "CheckCanUseLdapGateway", "CanUseLdapCheck", "UserConnection.LicHelper.GetHasOperationLicense(\"CanUseLdap\")", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("EmailSendUserTask.Recipient1")) {
				writer.WriteValue("EmailSendUserTask.Recipient1", EmailSendUserTask.Recipient1, null);
			}
			if (!HasMapping("EmailSendUserTask.OmniChat")) {
				writer.WriteValue("EmailSendUserTask.OmniChat", EmailSendUserTask.OmniChat, Guid.Empty);
			}
			if (!HasMapping("PageInstanceId")) {
				writer.WriteValue("PageInstanceId", PageInstanceId, null);
			}
			if (!HasMapping("ActiveTreeGridCurrentRowId")) {
				writer.WriteValue("ActiveTreeGridCurrentRowId", ActiveTreeGridCurrentRowId, Guid.Empty);
			}
			if (!HasMapping("DoOpenList")) {
				writer.WriteValue("DoOpenList", DoOpenList, false);
			}
			if (!HasMapping("ShowLDAPMessageId")) {
				writer.WriteValue("ShowLDAPMessageId", ShowLDAPMessageId, Guid.Empty);
			}
			if (!HasMapping("NotLicensedUserNames")) {
				writer.WriteValue("NotLicensedUserNames", NotLicensedUserNames, null);
			}
			if (!HasMapping("SyncResult")) {
				writer.WriteValue("SyncResult", SyncResult, null);
			}
			if (!HasMapping("InvalidCredentialsErrorCode")) {
				writer.WriteValue("InvalidCredentialsErrorCode", InvalidCredentialsErrorCode, 0);
			}
			if (!HasMapping("InvalidCredentialMessage")) {
				writer.WriteValue("InvalidCredentialMessage", InvalidCredentialMessage, null);
			}
			if (!HasMapping("ConnectionNotEstablishedMessage")) {
				writer.WriteValue("ConnectionNotEstablishedMessage", ConnectionNotEstablishedMessage, null);
			}
			if (!HasMapping("ErrorSyncResult")) {
				writer.WriteValue("ErrorSyncResult", ErrorSyncResult, null);
			}
			if (!HasMapping("EmailSubject")) {
				writer.WriteValue("EmailSubject", EmailSubject, null);
			}
			if (!HasMapping("EmailBody")) {
				writer.WriteValue("EmailBody", EmailBody, null);
			}
			if (!HasMapping("RecipientEmailsString")) {
				writer.WriteValue("RecipientEmailsString", RecipientEmailsString, null);
			}
			if (!HasMapping("LDAPEmailMessage")) {
				writer.WriteValue("LDAPEmailMessage", LDAPEmailMessage, null);
			}
			if (!HasMapping("NotAvailableFunctionality")) {
				writer.WriteValue("NotAvailableFunctionality", NotAvailableFunctionality, null);
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
			MetaPathParameterValues.Add("e5c388b3-4785-4a2c-93b1-eb2829edce7e", () => PageInstanceId);
			MetaPathParameterValues.Add("39bf6d5a-ff9c-4dc0-956a-35ae10d7f2e2", () => ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("c4ff2517-a192-4965-8aef-e3dc495ae18d", () => DoOpenList);
			MetaPathParameterValues.Add("0e5163a5-e480-4e06-b4b9-8d121b6ab25b", () => ShowLDAPMessageId);
			MetaPathParameterValues.Add("6740fc54-80fe-4f42-acd8-d4ec48888997", () => NotLicensedUserNames);
			MetaPathParameterValues.Add("c241e947-d0e3-48ca-b0eb-5109850b0a5f", () => SyncResult);
			MetaPathParameterValues.Add("3eee1f90-cad9-48ab-9581-9a37ffd7cc9e", () => NewUsersQuestionLS);
			MetaPathParameterValues.Add("7c51318b-2807-4e95-8070-9952bce377ca", () => NotActiveUsersLS);
			MetaPathParameterValues.Add("79cfd16f-6f0a-4429-8b33-20efbd7074bb", () => NewUsersInGroupLS);
			MetaPathParameterValues.Add("f4fa0f38-8445-4c0a-872a-08444b3b1da4", () => ProcessSynchWithLDAPLaunchedLS);
			MetaPathParameterValues.Add("c1351620-72ca-42c4-b8b1-b83dbf2f79a8", () => ErrorCheckRequiredLDAPSettingsLS);
			MetaPathParameterValues.Add("3ff56a7f-b43f-454e-8320-db273d793916", () => LDAPUsersWereAddedLS);
			MetaPathParameterValues.Add("ff35025d-d1a8-48b1-9355-f8a23f7413cb", () => ServerErrorLS);
			MetaPathParameterValues.Add("83c82239-ffec-4409-9bf6-9b8de6528de7", () => ProcessEnded);
			MetaPathParameterValues.Add("fcf94a88-a3b6-4d21-a997-00a81b8c55c3", () => MessageLog);
			MetaPathParameterValues.Add("ece68291-3e57-4d5a-a686-ac986c534ae8", () => NoAccessMessage);
			MetaPathParameterValues.Add("eb1d1d1a-09c4-4cdc-ae6d-3cbc3d8c345c", () => InvalidCredentialsErrorCode);
			MetaPathParameterValues.Add("e410db97-07f1-42a9-97c3-499e34692d6d", () => InvalidCredentialMessage);
			MetaPathParameterValues.Add("f6d1588b-7930-4f8e-9038-661abad4372d", () => ConnectionNotEstablishedMessage);
			MetaPathParameterValues.Add("a9370089-7daf-4b16-b51c-855fb82d5532", () => ErrorSyncResult);
			MetaPathParameterValues.Add("aeb1a392-036e-4295-8e8d-f388946495a5", () => EmailSubject);
			MetaPathParameterValues.Add("d7e3ec26-8976-4d26-a926-b73e739132ba", () => EmailBody);
			MetaPathParameterValues.Add("e6d9613e-c931-45a4-8289-34a64d103e30", () => RecipientEmailsString);
			MetaPathParameterValues.Add("2d31abe5-21af-4461-8c88-14c9cb2e037d", () => LDAPEmailMessage);
			MetaPathParameterValues.Add("3aeb7d6b-24b2-49d5-8f60-33c4bc99b910", () => NotAvailableFunctionality);
			MetaPathParameterValues.Add("ca308d49-70ae-4ee3-a7a6-576b39d0906d", () => EmailSendUserTask.Recommendation);
			MetaPathParameterValues.Add("9e636c72-feec-443d-80db-bbb11ca74373", () => EmailSendUserTask.ActivityCategory);
			MetaPathParameterValues.Add("20c028fe-7707-4d7c-8ae9-cf1c90b232e7", () => EmailSendUserTask.OwnerId);
			MetaPathParameterValues.Add("6194902c-224f-4855-9b2a-9d91ea50a55e", () => EmailSendUserTask.Duration);
			MetaPathParameterValues.Add("fb8728ed-a9ef-4b57-8aa7-37c3bac33e7b", () => EmailSendUserTask.DurationPeriod);
			MetaPathParameterValues.Add("a2c18195-1b0e-4559-8052-817ae92fd235", () => EmailSendUserTask.StartIn);
			MetaPathParameterValues.Add("3c731905-eb35-44ed-b3ca-dd1c63b9398b", () => EmailSendUserTask.StartInPeriod);
			MetaPathParameterValues.Add("22574204-b989-403f-aa68-6db44ddef273", () => EmailSendUserTask.RemindBefore);
			MetaPathParameterValues.Add("3e151f18-e3c4-4475-aa5b-5dbaefa7a649", () => EmailSendUserTask.RemindBeforePeriod);
			MetaPathParameterValues.Add("7c910dbb-c563-4a34-acf6-c6a467c05210", () => EmailSendUserTask.ShowInScheduler);
			MetaPathParameterValues.Add("13944a4c-7072-43a9-b1f5-b83b8de6253b", () => EmailSendUserTask.ShowExecutionPage);
			MetaPathParameterValues.Add("97b9f11a-d877-4fb1-a48a-d0b0ca01eb23", () => EmailSendUserTask.Lead);
			MetaPathParameterValues.Add("83a900f2-650d-4af8-8b42-4730bdc2076e", () => EmailSendUserTask.Account);
			MetaPathParameterValues.Add("b96b1ca6-35c7-4f2b-9344-720c982df478", () => EmailSendUserTask.Contact);
			MetaPathParameterValues.Add("396fe566-406a-403f-a5a5-6af7e082deb9", () => EmailSendUserTask.Opportunity);
			MetaPathParameterValues.Add("92959022-75ae-442f-86ef-9b01c388c38c", () => EmailSendUserTask.Invoice);
			MetaPathParameterValues.Add("959b81bb-3ff0-43ae-9129-2f50675fc64d", () => EmailSendUserTask.Document);
			MetaPathParameterValues.Add("3b18e768-4724-4d67-836a-cc1b4310b25e", () => EmailSendUserTask.ActivityResult);
			MetaPathParameterValues.Add("68f42e26-155e-4df5-9df2-41543aca9a91", () => EmailSendUserTask.Incident);
			MetaPathParameterValues.Add("73127a7c-1289-4e1b-8116-dc1191419c44", () => EmailSendUserTask.Case);
			MetaPathParameterValues.Add("7422cc60-2798-4064-84f0-b61ff20194c6", () => EmailSendUserTask.ActivityId);
			MetaPathParameterValues.Add("6aa36187-c640-44b8-a099-21d088d631b1", () => EmailSendUserTask.IsActivityCompleted);
			MetaPathParameterValues.Add("131c861e-e4b5-4cb8-add0-76db6ac463ed", () => EmailSendUserTask.ExecutionContext);
			MetaPathParameterValues.Add("883ae716-c06b-41a5-a98f-cea9cde03256", () => EmailSendUserTask.InformationOnStep);
			MetaPathParameterValues.Add("334b7e03-c84d-46cc-ae02-30e60226da8a", () => EmailSendUserTask.Order);
			MetaPathParameterValues.Add("703db63c-a4c5-4d00-99aa-8886e6f8ad64", () => EmailSendUserTask.Contract);
			MetaPathParameterValues.Add("26810327-3097-4fe8-a1a1-66a1d38d218a", () => EmailSendUserTask.Property);
			MetaPathParameterValues.Add("2f922d07-1465-46ff-89a8-6baac78050de", () => EmailSendUserTask.Listing);
			MetaPathParameterValues.Add("77526092-2a5c-4e11-865e-760b484d2d5e", () => EmailSendUserTask.Requests);
			MetaPathParameterValues.Add("50d6e9c3-54bb-4a5a-afc0-2c939d94b1b4", () => EmailSendUserTask.Project);
			MetaPathParameterValues.Add("b82ba56c-dfcc-46d3-a733-b779b91d801b", () => EmailSendUserTask.Problem);
			MetaPathParameterValues.Add("5acd32c6-85a3-4f51-8f40-b4528de854c7", () => EmailSendUserTask.Change);
			MetaPathParameterValues.Add("533b40fc-4e3e-4725-acf6-d5d6f8a2c575", () => EmailSendUserTask.Release);
			MetaPathParameterValues.Add("00c6d940-fd61-4cf6-9434-c51565909d13", () => EmailSendUserTask.QueueItem);
			MetaPathParameterValues.Add("db07491a-f5b1-439c-97a1-6af53ce909cd", () => EmailSendUserTask.Sender);
			MetaPathParameterValues.Add("953f4a27-0013-452f-8b74-5d28dbcbf8c6", () => EmailSendUserTask.Importance);
			MetaPathParameterValues.Add("b760a46f-1ff5-4b25-9a6f-af792f81b239", () => EmailSendUserTask.Subject);
			MetaPathParameterValues.Add("e2a57e59-b1eb-4aaf-81ec-1719d9392746", () => EmailSendUserTask.IgnoreErrors);
			MetaPathParameterValues.Add("b138f1ee-5c36-4c42-9abb-c1cd87be5b8e", () => EmailSendUserTask.SendEmailType);
			MetaPathParameterValues.Add("9c010bb6-8599-403e-b457-54ab13ff4c91", () => EmailSendUserTask.BodyTemplateType);
			MetaPathParameterValues.Add("09a73a34-9036-48e9-9e48-78e8873369b7", () => EmailSendUserTask.EmailTemplateId);
			MetaPathParameterValues.Add("95428372-753c-42d5-b08f-5a8e7695dfa8", () => EmailSendUserTask.EmailTemplateEntityId);
			MetaPathParameterValues.Add("126ba0f1-9346-426c-865c-079a6d0e9101", () => EmailSendUserTask.Body);
			MetaPathParameterValues.Add("c828d5b0-a444-4243-a108-cd25dd3dd2a0", () => EmailSendUserTask.BodyConfig);
			MetaPathParameterValues.Add("09a93c2b-915a-470a-a80c-0c680d44c1d1", () => EmailSendUserTask.CreateActivity);
			MetaPathParameterValues.Add("b976035c-f70e-41b8-b529-d345c403d06c", () => EmailSendUserTask.Recipient1);
			MetaPathParameterValues.Add("48c8cbfc-612a-4dab-b34f-c3eb75382329", () => EmailSendUserTask.OmniChat);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "EmailSendUserTask.Recipient1":
					EmailSendUserTask.Recipient1 = reader.GetValue<System.String>();
				break;
				case "EmailSendUserTask.OmniChat":
					EmailSendUserTask.OmniChat = reader.GetValue<System.Guid>();
				break;
				case "PageInstanceId":
					if (!hasValueToRead) break;
					PageInstanceId = reader.GetValue<System.String>();
				break;
				case "ActiveTreeGridCurrentRowId":
					if (!hasValueToRead) break;
					ActiveTreeGridCurrentRowId = reader.GetValue<System.Guid>();
				break;
				case "DoOpenList":
					if (!hasValueToRead) break;
					DoOpenList = reader.GetValue<System.Boolean>();
				break;
				case "ShowLDAPMessageId":
					if (!hasValueToRead) break;
					ShowLDAPMessageId = reader.GetValue<System.Guid>();
				break;
				case "NotLicensedUserNames":
					if (!hasValueToRead) break;
					NotLicensedUserNames = reader.GetValue<System.String>();
				break;
				case "SyncResult":
					if (!hasValueToRead) break;
					SyncResult = reader.GetValue<System.String>();
				break;
				case "InvalidCredentialsErrorCode":
					if (!hasValueToRead) break;
					InvalidCredentialsErrorCode = reader.GetValue<System.Int32>();
				break;
				case "InvalidCredentialMessage":
					if (!hasValueToRead) break;
					InvalidCredentialMessage = reader.GetValue<System.String>();
				break;
				case "ConnectionNotEstablishedMessage":
					if (!hasValueToRead) break;
					ConnectionNotEstablishedMessage = reader.GetValue<System.String>();
				break;
				case "ErrorSyncResult":
					if (!hasValueToRead) break;
					ErrorSyncResult = reader.GetValue<System.String>();
				break;
				case "EmailSubject":
					if (!hasValueToRead) break;
					EmailSubject = reader.GetValue<System.String>();
				break;
				case "EmailBody":
					if (!hasValueToRead) break;
					EmailBody = reader.GetValue<System.String>();
				break;
				case "RecipientEmailsString":
					if (!hasValueToRead) break;
					RecipientEmailsString = reader.GetValue<System.String>();
				break;
				case "LDAPEmailMessage":
					if (!hasValueToRead) break;
					LDAPEmailMessage = reader.GetValue<System.String>();
				break;
				case "NotAvailableFunctionality":
					if (!hasValueToRead) break;
					NotAvailableFunctionality = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool UsersAutoImportScriptTaskExecute(ProcessExecutingContext context) {
			// Check LDAP settings
			if (!LdapUtilities.CheckRequiredLDAPSettings(UserConnection)) {
				SyncResult = ErrorCheckRequiredLDAPSettingsLS;
				throw new Exception(SyncResult);
			}
			// Sync LDAP users
			var syncWithLDAPProcessHelper = new SyncWithLDAPProcessHelper(UserConnection);
			syncWithLDAPProcessHelper.SyncWithLDAP();
			SyncResult = ProcessEnded;
			var userList = syncWithLDAPProcessHelper.GetUsersWithMissingLicenses();
			if(userList.Count > 0) {
				var wrapper = new SyncWithLDAPProcessMethodsWrapper(this);
				wrapper.CreateRemindingByProcess();
				if (SysSettings.TryGetValue(UserConnection, "LDAPLogNotificationSender", out var result) ) {
					if (result != null && (Guid) result != Guid.Empty) {
						EmailSubject = new LocalizableString(UserConnection.Workspace.ResourceStorage,
							"SyncWithLDAPProcessHelper", "LocalizableStrings.EmailSubject.Value");
						EmailBody = wrapper.GetEmailBody(userList);
						var recipientEmails = wrapper.GetSysAdministratorsEmails();
						RecipientEmailsString = string.Join(";", recipientEmails);
					}
				}
			}
			return true;
		}

		public virtual bool NoAccessScriptTaskExecute(ProcessExecutingContext context) {
			SyncResult = NoAccessMessage;
			var log = LogManager.GetLogger("LDAP");
			log.Debug(SyncResult);
			return true;
		}

		public virtual bool InsertLDAPElementsScriptTaskExecute(ProcessExecutingContext context) {
			var log = LogManager.GetLogger("LDAP");
			try {
				var ldapService = new LDAPSysSettingsService();
				ldapService.InsertLDAPElements(UserConnection);
			} catch (LdapException e) {
				if (e.ErrorCode == InvalidCredentialsErrorCode) {
					SyncResult = InvalidCredentialMessage;
				} else {
					SyncResult = ConnectionNotEstablishedMessage;
				}
				log.Error(SyncResult, e);
				throw;
			} catch (Exception e) {
				SyncResult = string.Format(ErrorSyncResult, e.Message);
				log.Error(SyncResult, e);
				throw;
			}
			return true;
		}

		public virtual bool LogNotAvailableFunctionalityExecute(ProcessExecutingContext context) {
			SyncResult = NotAvailableFunctionality;
			var log = LogManager.GetLogger("LDAP");
			log.Warn(SyncResult);
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
			var cloneItem = (SyncWithLDAPProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}


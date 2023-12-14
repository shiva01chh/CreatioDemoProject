namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailSplitValidatorSchema

	/// <exclude/>
	public class BulkEmailSplitValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailSplitValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailSplitValidatorSchema(BulkEmailSplitValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9");
			Name = "BulkEmailSplitValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,85,77,111,219,48,12,61,167,192,254,3,151,94,82,160,176,239,75,226,2,45,186,34,135,98,67,191,174,133,98,211,137,80,89,206,244,145,34,40,242,223,71,89,138,227,168,113,214,195,114,113,76,145,143,143,228,163,44,89,133,122,197,114,132,39,84,138,233,186,52,201,77,45,75,190,176,138,25,94,203,111,103,31,223,206,6,86,115,185,128,199,141,54,88,141,163,119,242,23,2,115,231,172,147,59,148,168,120,190,247,233,194,42,36,59,157,156,43,92,144,55,220,8,166,245,15,184,182,226,237,182,98,92,60,174,4,55,47,76,240,130,153,90,53,174,105,154,194,68,219,170,98,106,147,133,119,247,107,66,193,44,153,1,46,215,245,27,194,218,199,57,92,101,5,146,25,52,81,65,157,236,96,210,14,206,202,206,5,207,201,131,9,44,32,111,208,122,121,12,62,26,46,45,239,159,28,69,65,196,127,43,190,102,6,253,225,202,191,128,66,86,212,82,108,224,153,210,83,43,165,111,13,188,218,131,247,113,79,212,236,113,133,57,47,121,222,230,191,182,92,20,168,38,119,150,23,25,188,174,35,123,0,58,71,89,120,122,1,216,23,56,187,149,182,66,197,230,2,39,179,151,182,69,15,212,161,12,174,153,198,67,155,134,15,88,160,25,195,182,31,37,34,24,34,61,189,12,194,41,22,167,129,91,9,144,104,140,178,57,213,227,26,218,164,243,30,241,228,247,163,223,135,128,169,33,167,214,25,55,110,109,152,36,29,215,37,133,33,58,123,57,29,246,204,116,152,102,73,155,36,141,179,76,86,76,177,10,36,237,198,116,120,56,182,97,118,99,149,66,105,192,217,33,223,207,119,71,32,153,164,77,248,113,180,120,122,195,44,252,129,146,202,137,52,124,0,21,70,209,83,208,40,82,219,33,235,203,127,202,42,230,5,83,144,86,136,11,112,219,63,24,68,226,165,211,79,106,118,94,71,80,62,153,174,174,64,226,123,95,29,193,107,20,37,188,240,9,142,9,118,250,121,37,146,153,228,166,57,29,133,192,94,85,246,69,239,218,213,69,217,30,223,180,157,148,239,209,44,235,226,171,42,14,68,136,194,124,3,121,208,148,27,186,254,170,48,181,107,220,19,106,51,43,134,217,179,228,127,44,109,65,65,48,174,80,229,246,160,241,0,202,97,220,162,132,58,143,8,84,161,177,74,234,236,193,63,65,219,60,71,186,16,21,106,43,232,130,45,129,9,1,77,16,26,84,26,152,10,247,109,2,191,204,18,213,59,215,238,10,243,209,116,225,147,148,125,44,229,218,129,119,52,60,175,107,209,54,96,228,4,8,157,98,46,161,182,6,104,197,221,231,163,1,187,167,219,153,45,112,39,198,174,45,232,212,79,153,86,8,89,190,132,81,116,211,181,31,132,35,250,217,129,14,168,202,209,247,102,235,90,102,23,237,97,156,179,241,187,117,182,113,112,240,101,66,201,132,198,96,219,54,143,109,68,237,212,245,217,18,237,211,235,41,182,157,22,254,71,226,225,152,46,92,60,177,4,222,218,53,146,197,253,254,2,135,240,102,62,96,8,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateStartTestEmailAlreadyRunMessageLocalizableString());
			LocalizableStrings.Add(CreateEmptyTemplateExistsMessageLocalizableString());
			LocalizableStrings.Add(CreatePingFailedMessageLocalizableString());
			LocalizableStrings.Add(CreateStartTestEmailDraftMessageLocalizableString());
			LocalizableStrings.Add(CreateNotEnoughActiveContactsMsgLocalizableString());
			LocalizableStrings.Add(CreateLicenseMissingMsgCodeLocalizableString());
			LocalizableStrings.Add(CreateNoRightToEditBulkEmailMsgLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateStartTestEmailAlreadyRunMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9d2048d7-a814-47ba-a6c2-8a501b495421"),
				Name = "StartTestEmailAlreadyRunMessage",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmptyTemplateExistsMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ebf71544-37ed-4cfd-b943-cabcb0570e92"),
				Name = "EmptyTemplateExistsMessage",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePingFailedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4148a7e4-06eb-4663-93d8-a680071d97b7"),
				Name = "PingFailedMessage",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStartTestEmailDraftMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("566936cf-99d2-4586-8ae5-d4296985935d"),
				Name = "StartTestEmailDraftMessage",
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotEnoughActiveContactsMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("51ffb3e4-a062-b06b-63aa-f711ab96b0a7"),
				Name = "NotEnoughActiveContactsMsg",
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLicenseMissingMsgCodeLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("67a1f8b1-b170-fddf-df53-dcf0eeadf065"),
				Name = "LicenseMissingMsgCode",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoRightToEditBulkEmailMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("90693f81-754f-2e62-f38b-ddc86be39d52"),
				Name = "NoRightToEditBulkEmailMsg",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"));
		}

		#endregion

	}

	#endregion

}


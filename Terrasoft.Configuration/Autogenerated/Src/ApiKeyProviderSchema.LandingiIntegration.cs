namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApiKeyProviderSchema

	/// <exclude/>
	public class ApiKeyProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApiKeyProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApiKeyProviderSchema(ApiKeyProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394");
			Name = "ApiKeyProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e8c267b1-bae4-4c71-bb04-0c218f8cac09");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,88,221,111,219,54,16,127,118,129,254,15,172,215,7,25,48,148,238,97,47,105,157,194,205,154,193,91,190,16,167,203,67,48,4,180,76,59,66,100,81,35,169,164,110,224,255,125,199,47,155,164,40,219,109,134,250,197,210,241,238,120,247,187,227,29,79,37,94,16,94,225,140,160,107,194,24,230,116,38,210,99,90,206,242,121,205,176,200,105,153,158,226,114,154,151,243,124,84,10,50,215,180,215,175,158,95,191,234,212,28,200,104,188,228,130,44,222,7,239,233,152,176,199,60,35,103,116,74,138,173,139,233,48,19,249,163,82,187,157,239,134,76,54,12,243,130,78,112,113,120,120,76,23,11,105,35,157,207,129,188,89,119,157,145,28,241,21,215,205,79,21,176,21,121,73,142,11,90,79,29,103,99,162,231,117,238,27,247,59,22,24,244,9,134,51,17,19,0,227,55,150,192,250,47,140,204,65,55,58,46,48,231,135,104,88,229,127,145,229,37,163,143,249,148,48,201,129,224,119,112,112,128,62,240,122,177,192,108,121,180,33,1,51,122,32,75,84,25,246,212,225,62,240,217,111,141,145,214,180,127,96,235,219,33,175,206,137,0,107,42,240,111,146,23,185,88,94,145,127,235,156,145,5,41,5,79,220,23,233,29,26,160,29,34,146,43,53,132,105,79,110,82,213,147,34,207,80,38,221,11,188,67,135,232,19,230,196,88,6,188,207,10,145,13,36,180,228,2,131,214,67,116,201,100,102,16,189,94,233,23,148,201,117,196,5,147,8,15,179,140,214,165,48,202,190,176,98,196,207,169,56,201,139,130,76,143,181,237,221,109,60,159,25,163,236,140,207,187,239,91,183,208,44,132,115,60,39,151,140,204,242,175,86,113,115,101,139,154,63,0,63,70,100,70,129,5,74,210,170,105,174,24,131,144,249,69,245,141,166,128,60,196,97,76,132,128,119,62,100,196,247,202,170,223,201,184,221,253,11,113,79,152,167,112,67,217,46,9,57,127,79,233,131,15,191,181,198,211,184,155,211,236,164,242,132,148,83,157,42,126,222,156,228,164,152,182,37,205,8,42,4,186,43,160,76,16,230,89,60,186,24,214,226,222,57,238,87,4,203,36,189,163,81,186,47,123,69,169,48,70,175,179,251,142,53,137,190,212,184,158,4,235,39,112,52,41,91,162,59,222,182,180,195,119,224,174,8,19,57,105,243,191,53,151,209,224,72,166,230,105,246,109,172,88,146,120,186,247,190,199,0,117,246,245,122,80,194,52,1,246,227,136,50,196,229,63,36,19,210,113,73,215,2,7,174,132,41,37,42,130,167,138,17,201,238,211,233,204,137,144,214,155,168,162,143,31,81,98,159,7,146,243,12,151,88,170,149,238,41,114,210,245,43,81,183,215,83,145,233,112,95,211,0,61,226,162,38,106,109,213,154,222,227,12,92,134,228,125,210,201,155,102,250,12,167,179,186,40,238,112,150,1,132,54,101,163,40,92,131,227,50,87,16,214,17,119,235,249,54,28,98,73,23,163,249,32,69,178,82,35,22,91,24,160,146,60,197,148,38,95,56,129,83,91,150,36,147,103,162,175,65,8,97,140,171,244,48,253,223,81,105,57,198,45,100,31,155,248,81,215,240,180,172,105,132,226,218,147,16,143,86,29,251,65,210,56,46,80,37,26,240,160,153,46,20,59,96,106,175,61,237,43,46,88,234,177,211,94,167,0,52,205,146,108,225,209,224,181,110,216,192,111,155,166,6,132,109,21,234,140,136,123,218,218,31,54,77,122,83,9,13,173,160,25,46,242,111,120,82,16,85,9,13,30,143,152,185,75,90,230,28,110,211,96,212,219,238,105,184,194,211,231,64,209,42,253,91,218,174,27,104,135,17,81,179,82,1,211,144,13,78,93,122,67,217,131,186,179,195,157,139,211,154,101,192,71,25,212,186,62,10,43,92,95,71,35,106,104,207,133,205,2,97,91,177,82,3,234,43,40,121,68,150,119,89,207,84,111,176,184,16,167,81,72,127,250,22,196,133,166,185,64,185,188,10,159,231,102,155,89,161,103,15,254,80,127,111,101,160,210,197,60,213,198,188,213,183,48,187,233,33,122,118,229,86,232,243,215,140,84,18,53,135,195,60,173,186,38,207,214,22,174,253,213,25,26,199,66,123,213,185,162,79,124,56,155,65,72,200,20,248,127,53,72,91,182,177,192,162,230,182,146,122,196,164,251,219,187,119,221,190,7,74,207,136,143,107,213,56,64,110,134,11,78,20,113,229,101,136,103,104,44,130,19,74,11,116,205,150,0,166,83,115,70,229,140,218,200,229,27,178,204,131,62,162,181,64,1,175,203,36,223,181,125,146,49,18,126,27,106,177,174,22,157,64,28,13,52,185,19,47,153,105,196,216,32,233,135,85,229,188,233,1,49,232,70,102,139,78,224,159,137,114,39,72,194,18,250,180,89,49,208,6,54,167,38,24,154,105,133,50,44,178,123,148,108,50,106,237,119,211,91,87,123,176,47,73,205,179,191,185,138,183,217,106,123,84,199,52,203,113,225,116,231,196,9,11,20,198,26,111,230,139,239,13,155,163,85,58,178,78,122,219,110,6,177,91,129,140,222,5,83,51,12,105,26,103,225,15,44,3,85,254,104,17,71,203,108,156,186,245,194,7,78,59,150,194,80,7,144,95,176,207,139,74,44,147,152,88,47,8,228,8,50,72,78,66,192,56,141,5,181,105,240,174,105,243,135,3,110,77,242,71,193,189,108,138,207,149,47,182,100,84,66,103,205,167,155,225,145,61,18,102,71,200,253,44,219,107,66,125,177,161,251,217,178,79,170,189,252,96,174,239,41,182,210,154,217,96,172,154,116,127,103,141,69,238,65,86,93,199,39,189,236,108,143,252,49,123,125,53,111,94,175,214,213,186,245,142,38,143,124,92,93,18,248,44,88,189,174,192,218,39,128,186,185,165,91,67,140,98,115,204,116,251,13,213,6,208,189,172,200,52,91,193,155,120,85,81,166,132,117,36,154,129,214,83,71,245,207,200,202,221,183,223,189,134,115,57,101,192,165,74,141,180,196,102,49,26,94,142,228,135,199,150,17,67,81,42,204,240,2,149,208,117,7,221,160,13,119,143,212,237,152,206,148,118,103,49,253,112,160,196,226,90,188,184,119,143,228,124,104,237,209,119,223,166,184,134,136,31,201,207,140,136,217,22,246,148,139,123,251,237,20,100,44,147,148,186,189,168,136,182,197,253,80,218,185,133,68,132,58,72,31,72,162,241,147,223,170,46,47,198,215,112,121,179,157,241,132,178,5,150,125,17,120,77,160,52,41,253,147,219,43,201,39,58,93,142,197,178,32,30,219,154,154,222,48,92,85,100,42,63,160,18,46,212,247,83,59,176,197,175,160,205,179,98,14,73,219,5,47,86,142,108,174,230,51,148,188,137,223,23,127,232,162,136,218,42,210,250,112,152,20,246,134,138,253,62,22,6,151,102,39,255,93,55,190,235,130,164,204,221,223,206,134,248,94,6,109,26,195,246,50,214,218,1,126,154,213,206,28,186,117,252,25,218,2,103,172,12,199,23,89,246,157,233,37,94,158,52,213,39,42,154,252,253,7,58,109,199,252,154,26,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOtherErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateIdentitySettingsAreNotFilledErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateAccountServiceUrlIsNotFilledErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateErrorMessagePrefixLocalizableString());
			LocalizableStrings.Add(CreateWebhookAccountServiceIdentityErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateGetCreatioUrlErrorMsgLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOtherErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2d5ffaaa-9e13-a68a-41a3-50e2f7dcc505"),
				Name = "OtherErrorMsg",
				CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf"),
				CreatedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"),
				ModifiedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateIdentitySettingsAreNotFilledErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("418532a4-9551-7296-cd86-04a914304d8c"),
				Name = "IdentitySettingsAreNotFilledErrorMsg",
				CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf"),
				CreatedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"),
				ModifiedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAccountServiceUrlIsNotFilledErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9c5f3a3c-d4fe-7100-3640-a3b6a653fa3a"),
				Name = "AccountServiceUrlIsNotFilledErrorMsg",
				CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf"),
				CreatedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"),
				ModifiedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorMessagePrefixLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7a7c65f0-a15d-29eb-908c-baa495d7d6e0"),
				Name = "ErrorMessagePrefix",
				CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf"),
				CreatedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"),
				ModifiedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWebhookAccountServiceIdentityErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4fccb0b9-3c96-6654-2624-b0dc0489d356"),
				Name = "WebhookAccountServiceIdentityErrorMsg",
				CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf"),
				CreatedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"),
				ModifiedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateGetCreatioUrlErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("efb3459a-1bd2-cd22-10ba-cac8d6926ff0"),
				Name = "GetCreatioUrlErrorMsg",
				CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf"),
				CreatedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"),
				ModifiedInSchemaUId = new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4b7b38d3-aa8b-4294-9a44-9200020a5394"));
		}

		#endregion

	}

	#endregion

}


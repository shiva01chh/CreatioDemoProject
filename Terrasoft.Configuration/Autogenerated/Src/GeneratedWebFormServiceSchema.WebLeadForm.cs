namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GeneratedWebFormServiceSchema

	/// <exclude/>
	public class GeneratedWebFormServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GeneratedWebFormServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GeneratedWebFormServiceSchema(GeneratedWebFormServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("177ef661-e736-4802-9520-b1d553edb13c");
			Name = "GeneratedWebFormService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a350b119-a1d4-416a-b96f-a65dc67beca4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,89,221,83,219,56,16,127,78,103,250,63,168,238,61,56,119,193,180,247,116,211,20,58,225,163,109,122,133,48,36,92,31,56,134,113,98,37,232,112,108,159,36,67,83,134,255,253,118,245,145,72,142,19,2,244,120,32,177,188,223,218,253,237,74,201,226,41,21,69,60,162,100,64,57,143,69,62,150,209,126,158,141,217,164,228,177,100,121,22,125,162,25,133,175,52,249,70,135,31,115,62,237,83,126,195,70,244,229,139,187,151,47,26,165,96,217,132,244,103,66,210,105,187,242,28,125,74,243,97,156,178,31,74,206,210,219,110,111,105,233,152,202,165,181,1,253,190,188,104,108,56,202,19,154,174,125,25,129,209,235,9,58,35,201,110,42,22,186,161,152,78,33,6,95,196,170,215,156,174,90,143,14,51,201,36,163,162,142,0,204,138,62,75,89,68,157,161,144,60,30,161,126,36,4,210,115,99,30,236,130,122,115,129,107,29,81,64,112,192,154,2,76,29,178,148,201,217,41,253,183,100,156,78,105,38,69,232,62,160,95,100,135,60,192,130,84,145,89,72,154,168,164,40,135,41,27,145,81,26,11,65,86,238,122,3,183,189,241,154,211,9,152,76,192,72,176,191,28,201,156,139,119,228,68,73,80,94,88,105,43,228,132,77,162,228,52,128,27,35,195,233,24,98,67,57,216,157,149,169,218,211,70,131,141,73,136,65,194,72,64,22,68,251,37,144,100,82,89,77,133,140,206,120,122,106,249,94,105,70,43,182,225,8,220,80,4,110,69,158,150,146,158,113,166,245,223,171,255,55,49,39,55,144,198,73,12,78,162,125,244,118,201,171,191,236,251,208,234,109,145,51,65,57,168,205,168,218,220,102,123,46,44,161,227,184,76,37,240,148,244,40,206,226,9,181,98,191,210,56,57,88,126,27,26,230,163,184,40,230,180,168,246,32,150,241,32,87,121,54,211,47,195,185,165,173,58,61,245,86,41,63,55,216,179,110,189,78,50,85,31,54,244,115,43,245,178,213,160,178,134,102,137,78,28,243,108,178,232,132,231,64,137,181,242,14,191,75,48,142,38,38,141,56,86,39,117,55,145,92,94,45,30,218,154,200,240,144,27,198,101,25,167,30,185,217,115,119,73,91,58,161,146,236,236,122,226,200,135,15,36,244,22,106,243,199,108,136,168,17,176,131,201,82,82,215,109,235,131,31,123,114,89,122,207,21,79,42,196,149,199,133,3,38,223,177,86,42,2,151,106,2,138,66,150,188,94,177,205,246,70,85,200,78,77,252,0,65,133,128,151,231,129,111,86,112,65,98,81,49,181,253,147,237,195,10,130,196,242,44,12,59,238,66,179,198,96,32,128,204,86,48,127,30,120,212,193,69,123,149,227,158,154,72,55,143,90,231,214,217,125,255,216,252,119,48,116,123,123,155,188,23,229,116,26,243,217,174,93,232,2,226,198,25,52,236,124,76,86,84,100,52,103,222,118,185,77,121,175,42,99,243,113,71,32,173,218,68,224,191,7,236,62,162,242,42,79,84,209,170,12,247,211,221,162,71,124,3,8,127,74,5,96,17,64,139,236,151,163,17,164,143,187,60,239,6,38,144,136,111,117,220,115,108,199,167,35,16,2,152,6,251,84,197,171,175,163,31,103,18,27,30,4,212,100,22,76,49,18,150,251,170,219,40,68,12,3,12,65,23,237,160,137,177,105,12,217,56,51,114,131,22,9,86,0,97,176,4,163,45,215,176,125,221,127,223,232,237,175,3,130,21,145,57,228,60,231,94,92,76,119,156,106,147,158,23,37,35,164,206,212,173,183,171,109,189,201,89,2,179,132,96,147,12,228,23,208,239,213,100,2,245,101,173,27,233,199,193,172,160,45,146,230,176,2,47,104,60,253,74,179,137,188,106,17,159,236,128,129,16,193,84,216,208,212,215,128,12,175,142,15,7,253,65,231,248,160,115,122,240,251,165,14,28,120,214,43,168,158,65,171,221,187,87,202,73,174,29,86,6,69,251,11,19,192,29,199,160,246,147,101,105,235,65,154,235,204,19,196,125,134,158,78,185,136,58,73,18,6,70,246,150,19,4,72,166,154,200,128,162,215,52,21,84,233,115,59,151,223,106,150,145,78,91,232,80,69,155,6,169,150,199,88,127,62,183,92,199,1,128,222,15,76,52,200,117,109,133,251,144,86,37,167,221,108,156,71,221,12,208,154,197,153,52,139,205,53,154,32,62,90,217,99,163,148,37,108,188,1,198,46,176,202,1,216,115,111,31,237,180,221,56,135,29,6,219,243,107,26,106,54,240,54,56,233,245,7,96,134,153,28,177,234,98,220,2,32,53,53,166,151,212,89,1,201,180,95,235,233,212,220,109,113,217,212,73,31,28,88,32,52,194,147,45,52,152,235,98,139,1,216,79,43,51,193,206,210,8,172,96,66,51,71,135,211,66,206,220,185,214,8,189,166,51,176,238,151,96,161,238,79,58,187,188,251,84,178,4,206,99,183,248,25,54,239,3,205,233,107,180,99,0,178,158,131,28,76,10,180,177,237,162,20,172,187,176,178,38,226,128,128,33,204,222,3,58,45,82,68,30,136,57,154,179,136,197,71,150,210,237,187,49,252,63,134,83,235,253,246,29,42,51,137,4,70,223,7,94,56,251,42,61,201,178,8,27,78,43,104,142,80,190,184,199,71,122,113,114,241,34,236,136,5,159,214,132,208,215,127,177,168,41,231,240,64,179,81,158,160,84,125,10,56,27,124,252,227,208,44,185,100,186,54,13,209,17,157,230,124,166,227,97,137,134,51,73,207,47,180,56,138,218,129,214,202,198,102,185,7,239,69,232,88,100,71,94,37,37,250,198,153,164,225,130,187,69,222,180,28,97,145,70,5,159,167,79,233,117,8,100,248,217,227,108,194,178,104,15,106,51,91,80,85,186,9,102,0,170,222,134,124,96,89,80,71,230,160,129,234,234,200,18,75,25,143,174,240,144,219,86,123,156,193,30,239,252,29,4,228,183,249,150,195,215,0,86,180,196,250,230,230,117,53,227,129,237,104,43,148,55,189,196,215,60,27,230,254,18,218,244,78,6,221,222,113,31,71,141,229,146,176,115,14,30,23,33,218,126,222,171,134,13,59,88,33,50,184,213,43,212,85,67,184,182,247,98,6,229,149,70,102,58,129,70,178,71,183,63,29,153,21,50,117,111,236,168,17,108,75,133,38,79,183,58,105,154,223,110,233,60,193,89,236,215,160,249,84,33,6,250,81,138,2,241,39,11,50,20,40,72,27,214,34,182,87,233,60,65,174,66,6,255,75,251,118,26,228,166,161,122,146,156,21,209,122,146,172,199,5,172,210,201,107,79,63,251,80,84,128,76,36,5,201,100,24,171,107,53,64,228,52,206,20,42,22,56,235,34,106,173,56,2,169,149,34,230,128,141,10,22,130,177,105,13,193,110,111,248,15,96,50,185,101,48,245,45,139,123,191,173,184,22,66,116,149,139,93,242,165,223,59,182,77,150,204,205,4,47,1,179,4,28,163,96,0,74,217,15,56,209,231,142,130,49,163,41,12,35,150,220,153,198,183,96,116,224,165,0,214,55,132,9,2,69,203,103,132,126,167,163,18,111,5,132,115,80,105,145,92,94,81,126,203,4,112,189,141,124,89,118,238,223,34,246,155,210,171,95,26,121,216,202,212,126,66,144,172,59,79,156,138,54,0,41,125,240,216,203,19,232,68,179,148,122,35,209,124,21,26,11,158,66,147,77,231,44,37,243,25,179,214,178,157,161,29,22,136,77,141,199,30,83,200,109,205,218,90,216,244,58,27,131,46,58,85,176,164,1,91,213,13,240,215,72,133,1,219,163,93,140,235,6,12,204,221,70,29,235,250,131,202,122,132,169,53,241,185,160,247,128,251,62,254,172,117,247,121,240,185,198,57,11,80,63,97,250,198,22,123,171,51,239,51,128,77,58,191,215,253,230,45,134,181,183,200,62,99,164,63,113,37,156,231,236,226,6,253,85,133,218,220,117,84,13,197,18,193,95,70,52,90,133,181,215,17,21,73,138,192,20,90,179,233,122,183,82,102,237,229,79,211,29,146,86,157,223,246,241,103,137,119,117,23,30,222,239,13,250,215,139,90,170,134,254,233,226,193,91,183,10,70,248,120,106,130,54,161,38,107,241,14,120,238,185,203,205,50,233,194,250,195,124,174,227,181,209,48,107,149,128,32,110,157,228,66,130,55,24,89,69,82,237,156,248,92,161,3,219,0,173,71,208,82,84,196,34,203,229,118,75,47,164,75,122,48,154,15,30,176,107,123,56,138,129,25,58,191,102,148,200,156,96,135,185,198,72,11,125,189,182,105,235,198,17,64,95,96,6,187,104,29,156,63,240,193,107,213,118,38,54,63,11,168,217,24,213,239,21,83,115,242,234,38,213,74,246,111,113,91,68,235,32,11,117,166,116,234,19,214,108,146,183,168,214,240,239,63,154,56,238,254,110,29,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNotAllowedURLMessageLocalizableString());
			LocalizableStrings.Add(CreateDataIsSavedSuccessfullyMessageLocalizableString());
			LocalizableStrings.Add(CreateUnknownWebFormIdentifierMessageLocalizableString());
			LocalizableStrings.Add(CreateLandingDisabledMessageLocalizableString());
			LocalizableStrings.Add(CreateConversionExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateOverflowExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateFormatExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNotAllowedURLMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ab59051e-66d5-4ef8-885c-4a1307f76006"),
				Name = "NotAllowedURLMessage",
				CreatedInPackageId = new Guid("a350b119-a1d4-416a-b96f-a65dc67beca4"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDataIsSavedSuccessfullyMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2fe873f3-73c3-4911-ada1-b77028b1ac25"),
				Name = "DataIsSavedSuccessfullyMessage",
				CreatedInPackageId = new Guid("a350b119-a1d4-416a-b96f-a65dc67beca4"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUnknownWebFormIdentifierMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("29eb0044-749f-44a7-be3e-f5ca1d725a82"),
				Name = "UnknownWebFormIdentifierMessage",
				CreatedInPackageId = new Guid("a350b119-a1d4-416a-b96f-a65dc67beca4"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLandingDisabledMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ec21278c-9228-4888-ad81-2753b2f4bfc7"),
				Name = "LandingDisabledMessage",
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateConversionExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4fdb8564-ea35-4b21-8dc4-c5f118c7a7e0"),
				Name = "ConversionExceptionMessage",
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOverflowExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("54e9d086-fbb8-4bea-a8f1-7611beb3aee1"),
				Name = "OverflowExceptionMessage",
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFormatExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e82e92af-f617-41f4-b061-1fe472ab96dd"),
				Name = "FormatExceptionMessage",
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("177ef661-e736-4802-9520-b1d553edb13c"));
		}

		#endregion

	}

	#endregion

}


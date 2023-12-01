﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GeneratedObjectWebFormServiceSchema

	/// <exclude/>
	public class GeneratedObjectWebFormServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GeneratedObjectWebFormServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GeneratedObjectWebFormServiceSchema(GeneratedObjectWebFormServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95");
			Name = "GeneratedObjectWebFormService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,25,107,79,220,56,240,243,86,234,127,112,183,82,181,123,130,208,251,218,45,160,45,7,133,83,91,16,75,219,15,8,161,144,12,224,187,108,146,179,157,165,219,199,127,191,25,219,201,58,206,99,161,69,167,171,68,137,237,153,241,188,31,38,13,231,32,243,48,2,118,6,66,132,50,187,86,193,94,150,94,243,155,66,132,138,103,105,240,22,82,192,79,136,63,195,213,65,38,230,51,16,11,30,193,211,39,223,158,62,25,20,146,167,55,108,182,148,10,230,19,111,29,88,200,247,89,12,73,239,97,128,164,251,1,166,145,226,11,205,207,10,206,101,120,62,239,59,9,254,148,93,199,2,218,246,145,159,30,162,116,122,168,84,30,76,175,164,18,97,68,108,73,4,68,208,231,2,110,112,197,246,146,80,202,87,172,210,221,241,213,95,16,41,95,131,136,112,110,23,168,115,77,234,130,246,166,50,255,0,10,25,200,81,228,43,158,112,181,60,133,127,10,46,96,14,169,146,35,119,65,250,97,219,108,13,10,65,5,118,35,30,211,37,121,113,149,240,136,69,196,104,63,159,236,21,123,19,74,168,184,30,144,225,7,244,83,73,139,242,43,81,68,42,19,82,75,85,82,239,165,59,26,51,77,233,199,3,80,142,236,250,48,76,227,4,4,187,171,45,55,24,153,133,84,9,95,20,187,93,125,111,208,5,131,193,71,9,2,119,82,208,38,99,69,109,105,185,25,120,55,108,123,119,76,52,208,165,67,28,65,156,149,61,175,211,70,144,250,198,196,17,252,57,164,177,81,164,93,91,173,158,136,44,7,161,56,160,35,225,183,66,76,136,13,200,214,214,22,123,45,139,249,60,20,203,157,114,227,45,40,201,212,45,176,168,16,2,141,206,14,207,206,78,88,100,216,10,42,180,45,31,239,245,34,76,10,168,150,103,235,41,172,16,114,65,97,9,53,189,95,250,218,200,75,230,217,130,11,85,132,73,13,124,207,220,229,110,109,239,52,149,188,187,203,70,158,214,29,148,105,20,129,148,153,192,108,165,142,208,25,195,148,252,107,60,177,174,101,185,244,236,127,217,98,147,21,175,217,2,3,158,199,13,44,111,105,156,230,6,148,253,26,240,107,100,212,51,255,179,109,150,22,73,82,186,216,96,32,64,21,162,157,3,237,23,131,86,31,106,170,10,179,164,148,120,184,123,62,172,243,53,188,96,161,244,120,157,60,50,131,139,80,176,48,207,107,44,142,166,238,198,184,133,99,4,192,56,215,185,252,124,88,131,30,94,76,186,36,175,93,19,152,10,209,42,92,31,223,63,220,108,99,93,194,79,40,151,45,209,190,242,9,31,218,91,54,124,161,228,166,78,212,248,242,157,159,103,82,184,243,8,142,234,34,106,127,174,212,47,233,154,6,233,109,166,131,115,194,30,34,236,84,46,211,232,65,18,187,24,107,197,174,1,187,178,215,14,106,10,112,79,30,160,5,143,96,139,42,186,146,237,123,80,183,89,172,51,173,214,85,93,113,139,140,199,108,6,234,56,215,181,126,239,248,116,86,86,47,29,78,207,222,38,217,85,152,160,55,35,144,194,110,65,6,200,52,121,253,33,132,49,8,76,223,11,76,37,162,138,175,150,184,56,197,62,12,105,67,48,141,99,131,53,26,154,180,182,169,155,131,44,217,156,38,73,118,183,121,44,248,13,79,135,27,108,248,219,208,234,226,151,232,89,209,137,224,201,241,236,236,81,104,154,67,77,83,227,166,106,243,108,153,195,6,35,232,92,13,199,221,17,89,234,218,144,248,223,169,186,141,229,178,73,9,23,200,15,18,47,18,69,213,216,120,11,196,238,126,163,131,185,45,91,23,218,252,35,84,33,187,182,31,165,4,148,102,133,33,106,98,164,164,219,114,237,200,114,73,154,42,233,4,153,241,218,0,69,71,239,47,133,255,204,213,237,254,23,178,6,30,146,113,198,171,240,37,82,8,238,28,82,106,183,172,82,97,169,11,49,222,13,42,74,187,84,130,9,99,52,14,62,224,112,65,1,143,205,33,114,24,236,207,115,181,116,131,215,230,9,115,223,228,254,138,221,23,34,19,191,168,213,54,210,210,89,172,244,88,138,205,125,177,217,139,23,204,87,114,163,146,186,52,81,137,93,110,81,49,92,241,105,21,197,32,145,208,65,204,73,152,109,78,96,51,164,115,18,24,85,191,71,79,15,111,200,166,246,218,64,107,212,110,79,186,208,246,204,168,177,249,251,196,181,94,67,105,247,179,225,172,208,1,87,231,187,225,241,102,8,88,47,170,11,221,16,210,159,96,223,69,95,63,42,26,145,176,181,54,122,37,159,197,221,153,246,211,79,84,53,70,67,50,194,17,241,135,150,50,188,94,163,93,151,150,44,229,132,222,81,5,1,188,186,213,201,169,213,235,203,73,51,40,12,220,125,166,133,85,1,211,115,148,57,60,63,206,193,140,241,238,124,57,56,71,86,143,210,69,246,55,140,12,26,222,62,60,62,57,59,58,254,48,35,190,5,63,131,121,158,144,245,240,128,84,96,101,51,236,144,102,134,122,136,44,135,54,157,179,81,135,13,48,26,57,65,150,117,179,50,176,95,74,93,1,31,194,179,174,87,247,100,216,204,128,111,178,120,57,83,203,132,0,17,198,90,179,218,13,62,11,108,53,33,222,96,150,115,34,18,170,26,176,217,210,111,10,134,102,153,81,251,97,107,10,51,25,145,181,114,58,234,204,89,94,85,92,165,40,111,38,217,54,57,136,125,255,110,220,187,164,211,121,16,208,199,1,135,36,150,46,220,216,107,232,186,242,184,29,66,14,33,65,211,5,179,28,34,126,189,68,185,42,75,30,197,88,129,185,90,142,154,197,216,15,147,192,130,208,174,149,208,196,89,130,106,206,10,17,193,76,101,2,85,139,163,143,66,88,4,221,195,64,193,143,81,55,161,192,130,88,130,148,95,26,125,179,135,77,131,164,60,128,144,208,246,211,240,42,129,120,52,108,233,78,135,99,59,49,185,197,128,70,102,116,92,71,163,182,44,176,94,168,224,29,164,55,234,150,237,176,151,134,232,110,91,63,108,142,94,121,197,200,72,86,151,42,48,191,105,103,228,213,21,221,74,121,208,54,205,249,86,39,231,165,215,56,30,38,252,43,140,90,235,175,255,14,83,221,54,110,169,247,77,130,173,197,96,220,147,246,204,110,125,179,249,252,214,82,48,52,88,237,237,171,21,200,188,113,181,190,196,56,233,181,30,204,245,178,243,141,225,64,52,97,146,254,171,191,112,241,84,49,39,241,183,0,186,114,181,138,234,11,186,175,59,59,136,171,46,172,75,114,255,225,136,214,6,89,226,62,0,139,4,92,111,15,91,208,135,91,59,236,14,91,70,22,198,49,167,43,194,132,153,158,7,63,242,74,65,65,121,137,251,204,84,211,119,79,247,202,58,76,70,214,184,143,61,90,159,197,40,207,132,28,59,179,170,159,101,138,26,218,20,155,211,142,87,177,186,93,235,125,240,26,115,221,211,96,58,197,195,117,136,226,233,118,67,135,127,211,55,59,192,126,198,59,163,44,41,230,169,238,200,187,93,211,194,234,185,249,49,28,211,225,255,109,193,99,45,67,175,148,14,212,207,8,217,201,120,29,44,230,18,155,133,229,167,199,18,83,75,176,74,227,237,18,186,231,63,35,91,250,223,154,174,154,156,108,163,214,153,62,170,248,162,196,16,187,137,65,82,25,104,239,113,214,102,137,198,237,191,148,3,14,146,240,6,243,110,76,239,142,64,143,228,216,166,165,0,152,244,120,26,37,5,102,97,47,57,112,221,128,235,174,142,221,221,66,202,184,66,44,145,221,73,22,23,90,209,102,236,97,166,175,233,207,35,87,89,150,176,53,195,119,155,201,30,40,138,202,240,18,136,10,108,130,49,137,131,160,49,88,119,139,228,20,60,54,127,205,91,207,40,6,7,117,59,167,134,196,73,134,7,203,199,204,122,221,137,142,250,164,123,90,185,238,244,212,109,28,197,61,193,81,143,191,243,11,230,245,187,15,192,108,182,118,253,200,142,19,87,97,241,24,225,249,169,178,105,87,99,211,132,120,80,218,209,206,96,26,179,245,105,167,167,235,89,43,153,222,195,127,255,2,48,164,125,66,139,30,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDataIsSavedSuccessfullyMessageLocalizableString());
			LocalizableStrings.Add(CreateLandingDisabledMessageLocalizableString());
			LocalizableStrings.Add(CreateNotAllowedURLMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDataIsSavedSuccessfullyMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6db1d3e6-c846-44e1-a09c-1a50c702b21d"),
				Name = "DataIsSavedSuccessfullyMessage",
				CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c"),
				CreatedInSchemaUId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95"),
				ModifiedInSchemaUId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLandingDisabledMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d67f55cf-49e0-4c7b-b5b9-ae2c35802592"),
				Name = "LandingDisabledMessage",
				CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c"),
				CreatedInSchemaUId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95"),
				ModifiedInSchemaUId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotAllowedURLMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("94f80c05-fb1c-490f-b4c8-39286962e741"),
				Name = "NotAllowedURLMessage",
				CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c"),
				CreatedInSchemaUId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95"),
				ModifiedInSchemaUId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95"));
		}

		#endregion

	}

	#endregion

}

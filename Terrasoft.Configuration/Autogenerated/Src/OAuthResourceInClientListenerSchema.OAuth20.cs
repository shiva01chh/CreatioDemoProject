﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OAuthResourceInClientListenerSchema

	/// <exclude/>
	public class OAuthResourceInClientListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OAuthResourceInClientListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OAuthResourceInClientListenerSchema(OAuthResourceInClientListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("90185723-7b0d-414c-540c-f66b5211d1d8");
			Name = "OAuthResourceInClientListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,87,77,111,27,55,16,61,43,64,254,3,177,189,172,0,97,21,244,104,91,2,100,217,113,5,196,117,106,201,205,33,200,129,230,142,36,182,43,114,77,114,229,168,134,254,123,135,31,187,218,93,175,29,5,109,14,69,125,145,73,205,188,153,121,243,200,161,4,221,128,206,41,3,178,0,165,168,150,75,147,76,165,88,242,85,161,168,225,82,36,55,147,194,172,127,126,247,246,205,211,219,55,189,66,115,177,34,243,157,54,176,57,109,173,209,47,203,128,89,39,157,92,129,0,197,217,193,166,14,175,224,165,253,228,82,24,110,56,232,111,26,36,151,91,16,166,211,206,101,60,19,6,86,161,132,139,197,205,81,118,151,95,25,228,246,63,180,70,251,159,20,172,112,65,166,25,213,250,132,56,243,91,208,178,80,12,102,98,154,113,76,224,3,199,210,177,84,231,240,217,37,183,115,153,149,95,196,115,182,134,13,253,21,121,38,35,18,117,130,68,253,47,232,157,23,247,25,103,132,217,104,175,7,35,39,228,156,106,112,54,147,156,79,41,242,142,25,244,158,92,22,135,188,177,17,70,21,204,72,133,233,127,116,240,222,34,132,122,53,72,220,199,48,247,24,38,22,240,72,46,184,107,44,85,187,179,197,46,135,1,65,100,100,115,140,86,86,23,189,222,19,49,184,47,151,49,38,52,7,181,5,85,177,217,31,144,232,131,100,52,227,127,209,251,12,230,206,83,39,157,209,47,149,146,234,26,180,166,43,72,126,167,89,1,17,217,15,94,136,128,5,10,43,184,173,37,253,27,209,74,91,41,58,67,216,8,123,172,101,31,40,4,145,122,22,155,148,94,131,89,203,212,178,169,248,150,26,8,116,250,69,224,132,92,129,41,203,178,109,143,175,10,158,18,85,22,154,150,220,85,91,94,33,213,182,6,170,216,26,15,83,177,17,3,114,167,15,117,98,2,69,99,89,146,191,165,138,128,126,64,129,217,94,121,21,122,212,223,10,80,187,184,233,149,212,13,174,169,64,30,212,160,149,77,255,212,1,63,131,242,105,17,38,179,89,138,225,48,104,50,73,83,191,27,215,51,15,0,179,103,8,239,121,102,64,205,240,194,168,66,90,150,252,54,25,57,175,158,197,157,42,64,82,253,254,39,110,214,31,169,66,59,92,232,216,111,78,229,38,167,138,107,41,172,36,147,203,135,130,102,216,252,89,26,13,106,116,135,68,44,162,119,211,54,227,248,121,236,70,201,135,187,140,64,123,195,151,141,93,110,155,182,120,14,128,182,57,245,104,214,191,229,248,249,221,23,139,103,203,8,92,58,93,158,149,135,204,209,157,88,231,128,169,192,20,74,52,96,221,23,251,99,4,121,190,171,78,93,250,92,156,71,9,174,165,224,80,86,91,248,117,216,230,205,135,29,138,172,9,126,118,114,246,221,245,249,219,99,150,158,239,252,127,147,60,47,139,99,135,141,127,181,186,6,174,47,175,138,109,235,43,83,250,135,53,94,41,138,144,140,225,133,53,19,75,105,211,104,109,189,87,114,227,165,24,251,143,160,175,250,237,80,75,182,210,95,167,228,44,101,227,184,94,14,86,208,161,228,239,193,57,200,173,68,58,138,225,134,78,235,90,10,97,239,186,88,13,200,44,164,238,81,187,213,209,104,224,107,152,161,83,246,110,109,119,195,51,220,155,30,194,149,145,253,208,234,221,54,75,172,87,236,12,246,245,158,31,49,118,164,193,212,32,45,53,18,150,68,226,56,84,60,5,178,149,40,249,197,90,201,199,106,34,198,129,19,168,13,190,62,25,141,137,177,102,174,172,238,89,92,1,52,60,79,143,205,181,246,224,24,14,135,228,76,23,155,13,62,32,198,229,198,47,84,164,25,232,64,61,153,211,45,22,2,246,241,148,84,62,195,182,211,89,110,199,0,17,200,223,40,210,152,3,168,104,236,94,92,196,175,146,179,161,51,233,246,128,104,188,88,3,230,2,64,152,130,229,40,90,156,188,248,194,116,121,77,150,56,27,92,128,137,90,233,136,12,199,132,227,187,138,10,124,51,51,41,12,229,194,146,107,214,80,6,116,37,144,148,26,218,200,37,60,186,154,157,186,17,51,129,146,51,8,17,203,251,63,176,153,161,140,65,24,227,231,176,196,164,170,248,4,202,83,61,93,3,251,115,74,133,31,224,115,60,122,190,215,206,59,8,215,62,223,146,122,136,18,27,106,39,58,208,63,34,225,246,232,123,35,111,208,214,251,170,181,30,189,126,31,133,139,40,76,214,175,192,10,3,225,197,26,199,78,131,179,212,219,216,23,29,103,240,73,209,60,199,38,214,32,227,86,204,254,11,135,181,170,106,127,188,230,20,108,176,31,255,63,209,93,64,6,63,86,115,85,132,255,140,228,92,198,224,175,190,57,147,57,104,247,203,167,190,113,11,15,5,104,211,113,235,183,146,76,166,205,41,48,201,50,249,8,169,71,9,207,116,251,67,171,124,225,145,167,103,8,141,193,177,247,179,226,88,233,191,208,245,187,28,245,241,67,187,94,69,104,117,189,99,190,133,189,230,24,193,61,252,251,27,62,149,206,144,149,16,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateConnectionErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateOAuthResourceInClientErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateConnectionErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("17f29709-20f9-88ab-aa54-5e1ac04adbd7"),
				Name = "ConnectionErrorMessage",
				CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee"),
				CreatedInSchemaUId = new Guid("90185723-7b0d-414c-540c-f66b5211d1d8"),
				ModifiedInSchemaUId = new Guid("90185723-7b0d-414c-540c-f66b5211d1d8")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOAuthResourceInClientErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1ffb57fc-90e6-d522-1436-b85f9a302127"),
				Name = "OAuthResourceInClientErrorMessage",
				CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee"),
				CreatedInSchemaUId = new Guid("90185723-7b0d-414c-540c-f66b5211d1d8"),
				ModifiedInSchemaUId = new Guid("90185723-7b0d-414c-540c-f66b5211d1d8")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("90185723-7b0d-414c-540c-f66b5211d1d8"));
		}

		#endregion

	}

	#endregion

}

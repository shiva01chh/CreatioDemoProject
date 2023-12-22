﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingElementHandlerSchema

	/// <exclude/>
	public class LandingElementHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingElementHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingElementHandlerSchema(LandingElementHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b4a27abc-02dd-4475-8af2-c1a758c299fa");
			Name = "LandingElementHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,221,115,219,54,18,127,86,103,250,63,160,186,135,35,103,100,58,78,58,253,114,236,140,109,201,169,174,78,220,137,227,250,225,230,230,6,18,33,25,45,69,170,0,40,91,205,228,127,239,226,139,4,64,82,150,125,190,198,153,187,62,68,18,128,93,236,23,118,247,183,110,142,23,132,47,241,148,160,247,132,49,204,139,153,72,78,138,124,70,231,37,195,130,22,249,151,95,124,248,242,139,94,201,105,62,71,23,107,46,200,98,63,248,13,231,179,140,76,229,97,158,188,38,57,97,116,218,56,51,196,2,55,22,207,104,254,123,189,232,10,176,88,20,121,251,14,35,201,145,16,140,78,74,65,120,231,145,19,188,88,98,58,239,230,97,15,36,163,21,201,197,143,56,79,51,194,58,79,15,143,235,45,185,96,169,47,166,215,100,129,209,1,242,121,250,219,64,10,196,127,99,100,14,22,66,39,25,230,252,7,116,6,55,2,183,81,70,22,245,253,234,224,238,238,46,122,201,203,197,2,179,245,161,249,13,30,17,152,230,28,45,136,184,46,82,142,102,5,67,11,88,145,171,82,168,76,179,67,68,243,227,136,230,104,106,197,177,76,119,29,174,203,114,146,209,41,226,4,103,36,69,83,41,84,187,76,168,67,214,99,204,201,0,141,207,115,171,236,47,56,163,41,22,254,226,73,177,92,15,224,186,158,179,118,52,19,132,93,224,21,129,245,15,74,229,202,56,63,179,98,73,152,160,4,44,4,223,5,68,21,73,245,145,208,44,106,193,200,242,119,142,114,136,99,101,149,172,152,207,65,216,164,162,113,181,238,45,45,83,84,172,192,197,52,37,136,67,48,129,229,124,237,222,74,118,7,135,138,109,49,139,90,45,16,239,27,225,73,158,106,249,125,101,222,104,95,53,52,105,145,97,60,202,203,5,97,120,146,145,151,126,240,152,43,15,209,107,34,124,41,120,212,18,137,92,125,196,72,190,217,94,143,17,81,178,220,44,38,167,89,113,99,105,147,243,217,251,245,178,190,204,103,125,24,73,221,122,189,143,27,76,255,142,128,221,200,138,112,116,67,38,210,242,11,4,154,228,130,206,40,4,205,140,21,11,36,174,73,21,132,54,50,183,247,203,235,146,166,142,214,227,52,106,181,140,101,108,117,94,97,102,95,131,61,113,96,207,32,204,81,187,198,251,174,189,66,242,3,148,151,89,166,78,244,94,41,185,146,209,98,41,214,122,229,135,224,124,82,9,236,218,240,238,32,81,15,114,131,193,237,251,226,205,199,94,212,143,29,173,244,49,224,157,160,11,130,25,216,74,102,3,12,249,121,69,42,82,248,64,56,133,68,34,10,229,38,19,34,29,206,209,185,98,85,128,67,206,171,119,30,89,139,235,231,80,47,223,25,58,151,75,173,199,180,200,115,237,116,70,166,5,75,165,156,179,2,69,239,212,175,113,170,164,212,206,190,132,95,16,88,89,202,99,132,101,254,168,21,190,6,167,78,8,1,19,20,75,74,210,14,29,254,121,206,82,194,162,231,241,191,154,26,201,36,21,104,163,151,62,149,38,28,146,99,151,34,190,232,85,46,13,228,119,214,55,68,161,94,13,22,131,66,117,33,48,19,143,92,173,184,228,249,56,53,171,91,188,251,23,174,160,78,169,218,133,62,239,194,213,109,158,123,84,47,186,2,235,216,218,165,126,160,33,85,253,30,72,247,82,230,195,129,17,198,45,83,252,138,138,235,203,252,183,188,184,201,71,80,23,196,58,82,1,186,69,173,51,145,225,173,114,55,193,211,92,165,57,123,19,100,248,156,220,116,10,101,222,128,91,26,198,169,36,114,171,11,143,218,111,213,164,116,134,162,154,20,154,194,50,23,240,228,160,52,60,179,114,217,234,17,200,166,233,63,54,106,147,178,200,5,145,141,179,17,95,255,136,46,57,97,39,58,159,128,50,177,230,45,123,236,114,145,71,250,35,249,25,51,240,47,68,99,180,23,219,19,167,80,114,163,126,88,222,212,53,253,56,57,226,81,127,154,145,190,61,61,134,11,216,63,10,154,71,125,104,198,181,206,230,24,231,20,190,157,231,250,219,0,245,33,101,193,194,152,143,126,47,113,166,217,192,170,102,125,62,249,21,4,149,7,12,227,171,107,194,72,69,42,195,209,165,229,188,94,149,213,88,235,220,112,15,191,183,97,250,243,155,153,100,237,72,98,119,220,59,61,91,41,172,2,209,156,94,145,201,41,52,48,70,127,201,169,197,76,198,162,178,109,50,7,51,97,236,4,95,204,213,181,166,70,30,121,220,145,105,163,217,43,171,183,24,93,95,97,74,8,77,155,6,119,244,135,91,26,129,194,157,240,173,66,230,40,79,163,56,121,91,64,40,39,163,91,202,69,117,202,13,207,134,163,124,39,37,23,75,50,165,179,245,219,226,172,152,254,246,35,149,157,169,121,53,26,48,69,195,227,209,45,153,150,2,146,92,58,169,190,30,32,223,161,201,40,231,37,35,195,227,122,41,138,171,199,101,88,141,37,142,124,71,48,212,114,148,214,95,15,130,192,73,244,45,68,111,71,245,173,53,195,222,205,53,205,8,138,106,46,137,252,112,174,12,18,6,92,226,156,133,212,161,77,12,213,163,36,42,223,28,70,202,250,251,46,181,202,238,155,8,109,138,50,241,233,17,115,139,46,27,134,82,206,81,187,111,112,142,231,154,237,56,135,186,154,79,201,241,90,242,138,228,213,53,191,32,43,37,71,105,90,71,196,192,246,127,39,120,169,222,150,37,211,105,203,124,124,116,123,228,182,44,247,209,175,17,170,69,177,197,213,203,71,81,75,179,238,167,93,47,57,215,128,199,43,23,78,106,254,170,149,9,196,247,218,241,167,150,188,35,31,251,55,182,212,174,77,213,225,138,81,97,27,96,48,223,24,122,191,246,243,131,234,186,1,10,218,15,67,119,6,144,42,75,70,140,21,108,160,197,150,82,77,255,184,80,113,162,98,38,218,8,74,33,7,152,141,134,14,87,152,201,246,171,31,111,234,9,63,75,248,218,210,230,252,47,96,216,22,181,255,15,100,55,0,89,3,2,247,218,64,224,118,176,182,215,145,207,158,50,230,109,85,247,179,194,188,70,145,157,23,109,154,252,247,33,112,39,140,188,27,1,79,224,212,157,67,91,105,168,255,12,18,227,9,244,17,240,50,54,13,114,165,192,128,137,109,238,112,231,222,90,151,16,211,158,42,143,117,0,64,149,217,254,237,21,185,75,213,35,201,134,93,110,70,253,175,247,142,70,223,14,191,27,238,28,143,78,94,236,124,189,55,60,221,57,250,230,244,217,206,243,163,227,103,195,103,223,29,191,248,254,155,111,251,119,193,208,191,16,88,87,70,236,6,214,31,208,156,136,125,180,125,229,188,39,116,30,155,244,102,219,144,199,68,204,62,231,39,6,153,125,225,186,122,52,168,119,162,124,0,54,108,1,133,30,28,180,139,146,191,139,214,186,96,162,143,188,238,13,185,234,123,42,124,215,192,245,103,68,145,130,78,128,202,0,162,25,3,233,85,67,31,119,35,51,199,80,137,236,3,53,44,147,6,171,97,90,20,127,66,152,230,10,248,217,131,181,48,126,67,116,229,65,177,77,152,170,229,25,4,160,106,187,86,251,77,145,202,30,54,13,91,110,55,35,76,75,198,96,241,129,136,203,223,128,240,167,130,226,204,254,61,84,55,154,225,51,15,110,12,95,57,213,60,238,35,144,127,175,147,179,56,88,220,97,20,176,78,212,4,38,16,199,192,173,158,57,43,135,168,230,107,2,149,205,238,26,34,185,107,190,186,187,145,161,24,216,205,88,30,140,60,4,96,142,168,76,232,109,88,146,154,216,79,52,183,146,215,109,50,22,100,177,103,119,76,250,115,182,158,199,30,4,8,148,132,183,54,37,75,17,185,246,137,219,226,76,53,87,186,213,59,177,141,158,21,85,194,219,45,226,144,4,101,8,106,49,193,211,107,20,73,7,89,52,67,243,198,57,29,12,105,80,108,34,139,145,246,235,67,238,115,7,44,3,201,84,162,25,136,242,87,42,254,100,118,148,111,253,21,180,61,52,53,116,70,39,35,178,180,88,165,159,233,92,165,122,22,233,73,223,54,219,156,65,125,115,236,68,241,3,1,117,107,31,115,74,51,89,66,16,6,53,102,128,124,235,150,80,118,139,218,185,92,33,158,140,114,129,138,89,163,119,236,232,119,212,202,82,214,25,149,150,14,250,26,49,245,15,173,73,236,216,233,6,202,134,127,117,242,114,87,17,214,124,140,28,135,103,129,12,33,98,150,164,246,108,71,211,245,216,51,4,213,87,254,229,200,191,82,103,91,228,239,67,110,219,13,223,95,102,222,45,116,87,36,212,82,187,182,87,197,49,104,243,182,111,64,195,214,179,117,16,193,189,180,229,25,233,54,142,131,108,199,223,22,194,60,235,56,121,95,200,72,219,2,164,170,137,28,196,100,61,68,128,55,195,203,76,168,65,65,203,140,65,129,215,59,13,165,178,98,219,180,239,161,45,186,41,28,157,152,32,24,179,110,156,26,162,76,254,107,105,1,117,114,142,231,164,53,251,218,119,74,27,131,92,63,9,123,123,117,251,22,140,89,79,41,227,226,156,13,201,12,131,133,91,189,42,139,157,33,78,126,34,107,155,196,101,39,17,94,18,244,14,189,41,96,105,154,151,100,223,237,155,122,70,201,149,103,134,55,90,101,16,84,111,39,178,93,199,34,50,166,24,4,10,217,113,119,149,206,19,213,230,89,225,130,86,3,122,186,192,233,173,151,15,180,27,90,234,194,19,27,134,5,81,29,142,187,158,206,132,190,5,186,182,65,229,71,26,208,135,183,109,30,212,155,145,250,131,71,245,129,22,237,19,250,39,51,80,108,13,25,111,146,40,216,218,77,32,208,189,60,32,94,122,27,250,78,135,163,125,98,160,133,144,137,77,183,182,50,151,147,219,42,164,170,191,135,23,115,249,103,50,245,135,21,147,21,154,243,157,1,80,214,254,54,239,94,143,120,171,78,175,39,174,89,113,179,229,235,254,20,255,127,80,155,143,154,51,210,192,81,11,3,24,125,111,117,194,200,187,253,20,50,124,90,206,218,98,8,12,107,238,127,127,2,134,41,104,156,40,45,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateInactiveLandingWarningLocalizableString());
			LocalizableStrings.Add(CreateLandingWithUnknownEntityWarningLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateInactiveLandingWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("553b63ae-bb9f-4aa6-baf9-b55e5df3154a"),
				Name = "InactiveLandingWarning",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("b4a27abc-02dd-4475-8af2-c1a758c299fa"),
				ModifiedInSchemaUId = new Guid("b4a27abc-02dd-4475-8af2-c1a758c299fa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLandingWithUnknownEntityWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f35c7b54-e61a-4d44-9f0b-49c9de5d6d1a"),
				Name = "LandingWithUnknownEntityWarning",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("b4a27abc-02dd-4475-8af2-c1a758c299fa"),
				ModifiedInSchemaUId = new Guid("b4a27abc-02dd-4475-8af2-c1a758c299fa")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b4a27abc-02dd-4475-8af2-c1a758c299fa"));
		}

		#endregion

	}

	#endregion

}


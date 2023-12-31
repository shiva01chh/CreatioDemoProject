﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CasePortalServiceSchema

	/// <exclude/>
	public class CasePortalServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CasePortalServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CasePortalServiceSchema(CasePortalServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("debb6152-95c5-4972-8ad8-0499f3e41f2a");
			Name = "CasePortalService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,91,111,219,54,20,126,246,128,253,7,214,3,6,25,48,228,237,53,183,45,201,220,214,67,211,100,117,182,60,4,193,192,72,199,177,80,73,84,73,42,173,151,229,191,239,240,38,81,146,101,59,217,186,245,97,121,138,68,242,240,156,239,124,231,66,202,57,205,64,20,52,2,114,9,156,83,193,22,50,60,101,249,34,185,43,57,149,9,203,195,83,42,224,130,113,73,211,57,240,251,36,130,175,191,122,248,250,171,65,41,146,252,142,204,87,66,66,182,223,122,70,9,105,10,145,90,46,194,87,144,3,79,162,206,28,43,237,140,197,144,110,28,12,175,224,118,243,132,99,220,234,94,107,91,207,243,205,201,178,190,17,14,225,52,151,137,76,64,172,159,224,33,177,117,130,134,202,42,214,187,221,79,39,235,134,208,196,90,79,28,255,134,195,29,74,36,167,41,21,98,143,172,241,1,78,186,182,15,168,132,228,52,146,55,234,221,177,40,222,130,68,89,5,234,116,155,164,137,92,189,131,15,101,194,33,131,92,138,192,127,80,232,145,67,178,101,137,154,21,218,23,241,72,109,82,148,183,105,18,145,72,41,215,213,141,236,145,147,26,8,156,254,160,181,173,109,66,86,72,138,130,247,200,5,87,126,51,214,12,10,243,64,34,53,78,132,228,218,221,146,202,82,204,226,183,200,83,84,117,104,158,195,89,60,220,223,182,70,92,208,82,64,103,165,125,189,195,250,151,73,78,211,206,114,253,118,135,213,239,64,176,244,126,205,254,110,96,184,111,113,129,60,54,208,172,193,137,151,145,100,92,65,165,49,55,51,38,147,9,57,16,101,150,81,190,58,114,47,102,57,210,152,166,201,31,64,114,248,72,18,13,50,122,131,45,112,46,160,146,28,22,135,195,142,183,134,147,74,194,193,196,151,105,157,220,89,16,140,136,138,255,193,224,56,77,49,108,48,212,203,44,63,163,5,218,168,246,253,41,209,113,143,82,14,12,32,99,11,204,81,48,210,160,61,126,22,27,194,74,102,65,57,205,72,142,168,31,14,35,156,121,194,217,123,224,195,163,89,191,48,59,5,165,28,76,244,242,167,66,82,11,33,245,150,35,141,210,96,143,200,101,34,42,212,126,175,39,32,98,245,131,143,77,31,35,46,56,43,128,171,100,165,66,135,73,76,177,16,219,224,49,170,245,163,79,218,238,122,32,119,32,247,137,227,176,80,15,79,217,223,227,163,147,225,193,240,123,203,178,30,119,111,119,9,162,71,37,106,201,34,16,2,76,186,33,160,114,246,42,220,234,37,171,140,247,175,113,2,90,110,255,27,112,144,37,207,125,125,201,15,63,144,160,233,38,69,198,90,72,48,50,76,86,238,218,234,179,51,144,75,22,247,229,186,123,150,196,228,56,142,141,91,68,160,139,209,106,30,45,33,163,191,148,192,87,4,196,135,49,153,77,243,50,3,78,111,83,56,112,254,140,204,18,199,171,5,22,23,26,45,73,96,211,144,30,198,8,106,207,107,135,237,181,30,191,65,35,113,167,176,82,37,208,175,71,161,202,94,93,99,157,250,183,140,165,100,38,222,2,196,239,0,185,145,91,3,172,131,220,158,22,227,192,186,237,21,200,203,85,1,118,167,223,104,90,194,129,146,116,20,180,117,235,102,242,155,17,249,243,79,99,200,224,217,226,252,212,124,51,26,145,111,191,53,18,9,33,27,100,190,42,147,184,87,166,83,238,197,161,38,138,206,221,194,52,4,122,130,129,7,226,89,188,191,1,71,38,117,117,49,75,54,98,249,226,217,198,87,85,237,102,123,62,214,115,85,54,86,209,208,19,110,107,147,46,214,231,35,29,169,73,172,20,93,36,192,187,185,213,95,36,44,140,118,153,121,220,121,117,148,50,81,114,68,61,54,59,155,71,164,126,220,171,65,35,2,157,157,106,239,64,249,153,24,35,198,68,63,56,229,236,99,99,55,231,151,123,202,85,4,217,100,209,137,227,224,87,1,28,89,145,155,182,56,244,39,156,209,156,222,1,31,19,157,249,134,54,185,168,112,196,156,161,112,214,18,140,39,177,127,56,78,63,210,149,152,131,234,176,113,59,108,17,108,132,122,121,68,103,13,84,228,250,6,243,124,183,159,121,180,123,88,134,253,168,172,181,25,0,9,101,222,182,52,30,91,72,236,202,211,37,205,239,160,230,119,160,101,140,61,168,218,116,30,183,112,219,74,190,83,85,26,210,39,81,143,67,196,120,188,141,124,13,215,155,93,106,199,59,17,206,175,13,106,184,193,241,250,32,55,178,218,195,181,213,102,28,226,147,149,194,118,39,12,112,241,211,162,239,57,16,168,77,254,33,4,148,168,206,176,135,128,30,223,221,126,147,54,63,55,0,102,151,126,4,190,252,216,214,229,103,188,230,228,51,94,127,30,121,86,2,168,96,217,156,2,182,212,191,113,163,97,216,78,1,125,127,160,92,5,159,34,40,148,38,216,18,34,39,114,134,109,33,19,34,193,166,72,167,22,152,68,58,190,38,124,55,210,152,74,42,250,14,6,154,246,181,1,83,183,59,246,164,7,19,183,214,167,82,53,163,82,217,32,212,90,95,157,4,108,163,6,156,51,126,134,205,45,242,196,50,236,13,139,84,196,169,118,111,174,39,181,25,118,197,248,123,125,107,19,42,175,150,60,194,121,140,163,128,177,105,100,214,28,145,144,129,29,177,202,65,46,251,77,149,26,161,110,32,28,75,109,171,161,52,234,3,35,240,181,223,33,157,105,64,180,103,92,137,167,121,85,80,117,189,126,74,151,97,120,106,3,221,54,68,95,86,151,209,145,81,112,136,147,8,185,49,60,186,112,255,18,201,8,38,139,232,189,34,182,186,76,136,19,77,35,108,233,13,84,145,130,13,253,181,33,133,183,99,209,6,118,141,82,167,149,169,182,63,48,19,142,72,165,155,97,81,183,215,65,122,198,176,160,101,42,117,158,28,57,38,39,11,18,180,38,30,234,237,194,105,86,212,173,235,96,246,38,17,178,218,174,210,13,219,84,71,124,127,252,193,211,158,60,26,74,14,146,92,18,110,115,137,50,87,173,172,79,102,161,73,42,231,249,169,3,49,240,119,25,123,38,234,220,58,114,82,209,128,150,212,67,242,93,165,247,64,46,57,251,184,45,172,173,172,71,115,90,34,144,170,234,131,130,95,120,250,233,250,183,86,189,85,67,185,218,77,13,92,173,214,149,98,79,208,171,247,248,118,170,152,55,19,74,201,215,84,252,150,232,132,106,35,90,248,205,176,219,213,86,167,66,167,151,105,70,147,180,153,189,204,120,43,101,217,203,144,240,146,21,193,247,238,193,30,53,135,5,100,67,91,33,173,168,215,72,4,198,87,24,102,110,238,75,206,178,96,120,209,217,116,56,10,143,133,17,225,166,94,45,129,195,22,169,88,107,167,31,74,154,6,195,40,91,170,105,234,37,161,194,106,191,223,181,244,111,27,169,181,49,190,238,177,171,101,82,215,162,150,136,142,17,167,230,232,229,150,29,231,113,48,124,141,169,233,60,55,27,120,75,108,203,161,11,117,176,160,72,214,81,159,253,81,7,193,93,64,176,118,55,246,49,236,213,214,53,44,158,126,66,185,162,133,73,215,113,202,68,101,105,19,22,247,116,142,225,123,146,178,232,125,195,167,54,130,43,187,187,180,173,166,156,243,14,144,173,101,205,21,38,154,205,150,13,200,251,132,88,44,46,84,14,7,9,60,176,129,213,1,222,86,222,46,240,225,244,19,68,165,132,57,86,114,202,237,73,191,81,119,183,223,67,109,187,72,158,131,20,166,238,96,178,197,202,100,142,97,38,35,61,179,9,55,143,27,139,164,235,168,220,71,4,14,162,64,206,64,216,108,182,174,209,203,230,107,139,255,213,99,112,125,5,183,179,252,30,115,108,96,12,85,55,238,23,231,243,75,244,131,250,116,1,66,190,100,60,163,170,169,198,169,22,84,243,42,252,89,168,238,246,132,197,171,185,92,165,208,152,82,189,13,175,56,45,10,136,77,109,124,103,181,219,44,84,127,44,169,238,35,253,79,69,214,74,39,198,63,133,218,182,112,221,25,196,97,226,110,36,55,72,116,105,95,98,176,218,98,161,36,24,194,17,91,157,145,136,222,145,206,21,48,79,151,198,145,255,17,87,75,117,195,88,55,186,48,170,175,81,173,187,234,65,60,78,120,165,199,113,218,77,220,218,43,182,105,168,79,194,255,179,240,179,178,176,186,8,248,239,73,88,169,242,5,113,208,30,44,255,39,225,231,36,161,119,25,243,159,179,208,211,229,95,160,225,96,176,225,30,76,251,157,196,12,207,38,250,148,168,184,180,164,247,64,16,243,20,168,144,228,123,114,111,154,119,146,217,86,85,125,178,211,125,203,179,174,238,159,192,212,75,236,235,212,89,199,106,37,80,23,60,187,102,12,79,199,78,167,74,23,167,221,151,198,102,43,237,217,164,182,223,112,118,63,71,89,26,227,105,90,157,97,55,158,194,26,228,171,217,131,75,119,105,253,42,30,138,13,169,110,234,221,174,161,197,177,234,79,179,36,215,116,163,210,38,65,161,63,40,234,59,92,123,217,6,241,230,116,88,253,68,66,255,86,164,239,26,137,236,213,251,171,85,6,160,142,158,189,191,17,120,202,229,93,45,122,210,145,221,8,6,203,211,225,145,190,26,243,104,91,7,129,243,125,239,245,152,205,96,118,237,8,237,188,85,201,164,122,126,32,27,190,33,155,183,205,151,250,157,255,247,23,0,90,94,164,193,37,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCancelCaseErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCancelCaseErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f7aa1416-1f16-46f2-8b35-6285fd72bd50"),
				Name = "CancelCaseError",
				CreatedInPackageId = new Guid("e575f8b9-fb60-4dfe-8829-1e1af76dbac8"),
				CreatedInSchemaUId = new Guid("debb6152-95c5-4972-8ad8-0499f3e41f2a"),
				ModifiedInSchemaUId = new Guid("debb6152-95c5-4972-8ad8-0499f3e41f2a")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("debb6152-95c5-4972-8ad8-0499f3e41f2a"));
		}

		#endregion

	}

	#endregion

}


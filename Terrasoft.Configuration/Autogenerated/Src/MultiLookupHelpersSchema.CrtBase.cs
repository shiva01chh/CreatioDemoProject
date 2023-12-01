﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MultiLookupHelpersSchema

	/// <exclude/>
	public class MultiLookupHelpersSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MultiLookupHelpersSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MultiLookupHelpersSchema(MultiLookupHelpersSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("335e2875-b8e4-4305-9db1-5e8762d08de7");
			Name = "MultiLookupHelpers";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,87,221,111,219,54,16,127,118,129,254,15,55,27,104,101,212,83,218,189,108,75,234,14,169,227,182,6,210,45,139,211,229,161,232,3,45,157,29,54,148,168,146,84,23,47,240,255,190,163,72,73,148,63,178,97,27,230,135,196,60,222,29,127,247,125,206,89,134,186,96,9,194,21,42,197,180,92,154,120,34,243,37,95,149,138,25,46,243,199,143,238,31,63,234,149,154,231,43,152,175,181,193,236,100,235,76,252,66,96,98,153,117,252,22,115,84,60,217,225,185,194,59,211,18,195,183,178,76,230,251,111,20,30,162,199,211,220,112,195,81,239,99,248,48,139,175,113,65,70,24,37,133,142,235,47,196,74,204,69,185,16,60,1,109,200,184,4,18,193,180,134,247,165,48,252,92,202,219,178,120,135,162,64,165,137,209,90,221,27,40,92,145,89,48,41,181,145,25,42,199,42,42,214,105,202,13,76,179,82,48,35,85,165,187,119,116,52,203,10,129,25,230,70,195,146,11,67,174,32,104,44,79,129,149,70,126,171,209,250,9,150,82,193,105,146,200,50,55,149,18,123,111,81,178,196,157,141,4,250,10,76,67,214,62,103,245,119,193,127,149,60,109,144,109,1,171,113,69,231,45,86,214,62,57,178,218,122,193,93,210,62,239,238,62,104,84,132,41,119,113,133,178,115,28,66,229,157,94,32,21,95,40,44,152,66,167,243,77,101,59,60,27,67,164,49,79,81,141,0,135,48,126,229,229,122,24,59,14,138,142,64,166,162,225,137,163,127,101,10,156,147,48,245,30,250,101,241,217,250,108,28,194,143,127,99,162,196,64,198,223,205,82,226,219,47,255,205,24,242,82,8,39,2,91,159,222,79,16,189,45,121,58,220,47,124,64,232,24,172,76,60,205,10,179,246,88,248,18,162,0,203,56,224,168,125,214,235,41,52,165,202,189,196,102,219,33,167,105,26,229,248,59,156,241,202,213,76,173,95,106,99,211,104,4,178,66,211,56,177,119,223,79,100,70,78,231,90,230,87,235,2,251,35,112,90,38,29,114,60,253,82,50,177,25,53,82,2,151,102,122,87,40,212,154,94,160,234,45,179,252,130,153,27,146,239,123,195,251,1,59,197,254,140,235,66,176,117,229,118,226,90,50,161,49,224,80,124,117,19,104,188,96,138,186,10,225,168,248,53,9,88,131,28,250,143,159,224,190,241,208,198,91,191,241,241,223,184,26,237,38,214,233,103,118,55,253,106,75,42,158,220,176,124,69,246,216,211,225,228,218,78,136,157,40,5,12,63,19,80,155,51,149,135,119,152,50,150,179,21,229,241,120,43,255,93,251,89,207,147,27,204,216,123,199,20,136,125,41,81,173,73,200,90,29,114,254,106,233,145,87,26,248,58,204,254,66,241,140,98,238,130,226,209,85,250,108,98,56,106,212,159,165,253,97,108,47,119,5,125,164,30,150,183,244,174,6,199,18,230,160,163,76,20,50,131,142,126,205,205,77,19,90,29,249,232,31,206,184,58,63,250,31,125,115,59,246,6,31,207,210,79,49,217,80,51,248,218,11,131,94,101,206,48,116,12,250,142,223,216,243,22,141,115,110,59,126,162,173,54,21,84,101,45,78,227,128,16,192,43,120,222,22,100,152,44,53,223,199,231,159,236,11,214,26,239,182,10,210,75,11,245,85,180,19,165,250,169,94,39,175,60,173,247,87,74,93,250,53,106,119,98,88,107,223,0,82,225,61,216,72,194,46,57,47,117,65,5,210,22,80,211,103,59,92,104,42,20,167,121,106,135,116,219,191,70,97,145,236,147,188,68,93,102,184,171,126,83,253,219,184,90,30,16,2,55,69,237,105,239,80,157,233,75,252,82,114,133,169,19,241,99,46,165,94,188,162,236,115,131,142,114,114,158,40,94,152,51,79,142,156,215,64,87,212,225,73,61,130,201,30,13,50,71,144,75,176,48,53,40,175,61,134,89,110,108,199,72,237,136,93,32,36,140,50,39,133,165,146,25,93,145,69,7,134,108,11,240,146,160,211,62,163,28,148,67,211,21,30,154,172,239,169,73,82,3,184,96,57,10,200,130,195,8,206,152,97,115,89,42,218,198,210,230,235,104,215,116,96,53,165,78,226,80,79,124,206,243,219,118,144,216,147,219,232,234,196,177,148,42,217,195,96,78,4,167,24,206,206,124,81,78,88,81,13,254,113,128,36,118,109,44,118,137,105,119,61,243,122,109,147,35,106,91,89,236,5,93,34,248,132,248,103,232,194,126,240,239,208,249,254,115,0,93,227,204,168,131,179,126,18,158,65,63,166,222,242,84,16,176,132,82,227,246,41,77,192,50,119,29,135,194,35,42,192,195,251,190,47,75,176,18,182,101,37,89,65,8,167,119,38,94,161,153,100,69,228,57,79,58,156,182,59,89,206,39,79,172,64,188,148,73,169,41,172,29,158,230,130,74,108,179,25,129,185,225,122,232,231,198,166,78,124,170,98,158,218,236,224,65,61,109,231,243,66,74,17,228,115,45,243,95,103,242,223,90,31,131,109,169,109,250,110,118,232,40,220,156,172,107,182,135,195,30,190,97,184,1,232,133,159,192,243,170,77,188,46,185,160,85,161,233,128,71,71,131,193,96,4,3,247,169,255,119,78,48,128,107,169,110,221,175,163,201,229,139,239,191,251,225,199,23,237,3,180,236,84,121,55,167,53,155,12,223,93,18,26,97,219,40,67,214,112,13,17,168,140,247,163,199,123,46,169,45,241,63,216,66,160,131,30,109,189,84,143,205,94,127,247,135,139,93,225,118,20,80,181,5,207,56,247,117,150,142,16,69,91,90,255,7,24,255,218,22,38,189,136,79,11,59,186,222,72,149,49,26,73,129,4,233,188,239,83,77,236,235,93,182,84,54,253,154,99,95,255,112,28,245,59,157,122,167,142,228,159,136,246,248,99,68,9,21,95,73,239,132,225,8,252,117,181,238,92,51,149,19,185,86,235,230,178,219,146,253,68,172,254,122,186,81,254,183,203,190,9,73,180,138,76,159,63,1,49,144,21,47,155,15,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateAlertMessageLocalizableString());
			LocalizableStrings.Add(CreateAlertMessageCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateAlertMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d05cfcd7-cc35-44a8-bc05-e3aabc4cd1c5"),
				Name = "AlertMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("335e2875-b8e4-4305-9db1-5e8762d08de7"),
				ModifiedInSchemaUId = new Guid("335e2875-b8e4-4305-9db1-5e8762d08de7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAlertMessageCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5ab4d66e-8007-4ea2-ad2f-237ff275a15d"),
				Name = "AlertMessageCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("335e2875-b8e4-4305-9db1-5e8762d08de7"),
				ModifiedInSchemaUId = new Guid("335e2875-b8e4-4305-9db1-5e8762d08de7")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("335e2875-b8e4-4305-9db1-5e8762d08de7"));
		}

		#endregion

	}

	#endregion

}

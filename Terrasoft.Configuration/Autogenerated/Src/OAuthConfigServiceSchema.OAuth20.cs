﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OAuthConfigServiceSchema

	/// <exclude/>
	public class OAuthConfigServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OAuthConfigServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OAuthConfigServiceSchema(OAuthConfigServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9299bebf-e0c0-4836-9492-fee7fb5aac83");
			Name = "OAuthConfigService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2e618fe0-496b-4dc6-9b5c-1f29508fde14");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,91,221,111,219,56,18,127,206,2,251,63,48,222,195,66,6,12,161,56,220,83,178,109,145,207,194,135,107,155,171,155,237,67,177,88,40,210,36,214,174,44,169,36,229,214,23,228,127,191,225,151,68,73,148,44,39,118,178,109,183,15,105,52,26,14,103,134,191,249,32,197,164,193,2,88,30,132,64,222,3,165,1,203,174,185,127,146,165,215,241,77,65,3,30,103,169,255,246,168,224,243,127,62,251,241,135,219,31,127,216,43,88,156,222,144,217,138,113,88,28,54,158,113,92,146,64,40,6,49,255,21,164,64,227,176,197,51,3,186,140,67,120,157,69,144,244,190,244,143,80,210,82,170,208,207,247,1,174,42,6,219,136,197,194,30,106,191,161,208,69,247,207,82,30,243,24,88,39,131,61,55,58,138,211,32,228,46,102,84,107,141,14,117,63,35,23,242,253,68,225,6,31,200,73,18,48,118,64,164,239,21,155,158,87,114,125,212,15,102,254,223,4,237,136,229,111,128,227,148,57,202,187,138,147,152,175,222,193,167,34,166,176,128,148,51,207,126,16,218,147,231,100,205,16,193,229,107,66,52,22,147,228,197,85,18,135,36,20,218,57,148,35,7,228,56,96,80,170,186,119,43,213,45,173,186,160,89,14,84,184,247,128,92,72,81,234,189,22,203,56,21,94,146,114,79,99,22,92,37,16,189,6,198,130,27,32,2,124,123,123,55,192,245,111,123,20,120,65,83,146,194,103,242,159,44,12,146,248,127,130,127,38,69,120,151,12,40,106,150,42,52,162,13,44,43,104,136,111,51,138,194,38,100,212,214,125,52,81,114,247,246,70,45,121,204,119,233,228,255,26,36,5,140,198,135,114,224,157,248,41,127,252,4,105,164,12,174,91,255,26,248,60,139,132,233,84,0,27,180,237,234,129,92,101,89,66,166,204,168,58,77,79,146,24,23,225,40,161,16,68,171,179,47,49,195,53,212,30,10,229,171,105,52,49,46,163,122,212,27,140,230,177,246,208,50,160,4,216,39,92,102,225,35,137,235,213,44,156,195,34,248,111,1,116,213,244,145,205,240,58,72,209,62,106,252,212,212,201,152,140,210,253,163,40,194,176,47,22,169,55,154,70,230,197,180,53,219,121,156,112,160,83,12,94,173,188,34,160,114,40,68,57,222,63,65,75,57,168,23,31,98,62,191,8,40,154,131,15,204,83,68,9,84,26,179,44,125,191,202,49,84,63,21,65,82,174,165,148,234,159,104,207,140,38,165,147,134,232,100,252,183,109,173,140,231,124,177,48,168,83,109,157,42,39,42,65,76,56,211,179,221,211,193,82,215,86,51,41,243,170,20,44,230,42,18,174,108,193,116,204,155,12,13,0,104,49,241,53,241,212,72,76,79,69,202,201,11,242,108,220,136,57,78,11,176,64,111,200,215,65,194,20,253,206,1,237,247,116,133,74,104,80,231,249,52,58,94,153,197,106,195,58,43,56,121,85,196,145,38,73,126,163,133,69,66,227,4,151,127,182,200,249,234,112,203,168,47,85,29,213,60,108,9,83,192,39,97,150,72,85,30,18,14,211,200,64,79,121,90,200,186,47,242,186,99,192,141,53,51,119,23,144,160,73,184,7,164,154,50,28,224,170,175,107,115,192,199,103,191,137,25,133,161,218,195,50,251,254,34,214,255,133,39,151,192,183,162,234,65,80,157,50,236,51,142,162,69,156,94,166,49,199,121,226,200,147,104,100,22,185,2,228,86,32,103,207,184,91,192,213,141,216,30,236,36,224,26,30,218,80,29,33,111,123,10,205,26,146,85,185,158,144,127,117,68,131,203,49,3,88,43,165,159,56,128,30,158,157,203,66,143,201,89,4,147,231,104,47,172,228,76,75,118,163,67,69,217,105,106,54,122,238,54,80,108,171,183,135,202,225,157,64,123,254,39,7,152,181,186,79,148,160,151,25,2,79,249,222,217,155,122,205,182,97,210,133,85,1,71,218,24,173,177,233,150,236,116,93,83,2,238,15,249,41,92,91,30,96,94,23,171,213,102,72,151,90,90,247,141,120,103,47,67,101,87,151,62,193,18,180,6,13,87,214,182,159,122,23,132,178,115,220,190,3,17,216,161,52,163,125,76,38,61,44,212,126,168,74,2,229,206,172,119,116,137,171,89,17,134,40,2,173,145,203,174,55,98,114,250,105,122,157,153,132,97,158,171,129,123,102,119,248,220,232,160,232,10,74,119,46,163,107,30,212,64,50,143,158,13,141,48,75,163,88,158,101,232,249,79,99,185,238,1,93,253,162,236,198,76,120,245,7,130,225,133,81,231,22,139,32,195,197,15,176,123,198,16,23,208,38,182,42,53,200,185,160,214,29,157,251,102,152,127,14,60,156,159,211,108,113,122,236,85,58,142,91,65,218,3,196,138,71,4,36,42,242,143,17,130,14,119,224,114,153,142,228,98,252,126,43,211,247,27,248,44,254,247,198,7,111,238,70,205,209,184,31,206,147,96,165,133,216,50,72,32,133,180,70,148,238,65,254,42,242,45,157,43,176,234,69,4,4,132,49,141,207,105,246,89,122,77,228,103,123,103,124,246,37,132,92,230,183,154,105,99,71,102,49,12,54,56,214,239,216,173,195,138,143,111,115,80,128,182,143,95,246,62,126,128,171,105,186,204,254,4,79,13,19,46,185,120,59,123,143,72,56,206,162,213,140,175,18,225,38,100,211,168,45,169,254,7,26,228,152,54,39,68,28,182,0,227,231,25,93,4,188,198,172,72,254,191,177,156,168,248,48,97,212,207,43,79,109,204,249,10,22,21,131,180,50,206,145,166,151,164,21,5,241,181,183,255,42,201,174,130,4,87,22,209,196,229,73,200,57,70,76,65,225,44,21,71,33,250,108,112,154,114,184,81,62,105,118,35,98,181,28,243,90,49,236,142,254,65,225,111,197,191,235,128,70,115,221,233,164,96,131,129,211,149,145,210,8,202,102,74,56,220,212,156,48,203,193,74,204,18,136,117,13,8,6,73,56,39,94,137,90,2,155,187,173,26,140,181,184,109,225,221,55,0,86,85,193,108,168,234,74,108,189,147,42,144,160,65,216,5,132,235,218,252,133,0,44,235,131,107,207,218,244,138,175,142,207,69,145,193,54,168,210,162,94,198,5,20,102,57,132,241,117,12,114,203,43,122,225,2,199,144,152,145,52,227,100,41,132,251,38,183,171,98,89,95,169,231,107,125,214,229,180,97,94,235,170,251,165,171,140,175,202,53,172,43,120,104,183,9,150,1,118,77,46,143,127,220,69,89,31,87,244,85,89,205,161,203,99,107,49,4,189,206,105,21,208,75,154,184,198,212,57,234,163,223,65,20,83,212,177,99,168,245,186,97,129,5,10,215,64,251,125,125,228,148,201,111,52,80,47,230,97,171,239,28,28,73,173,94,184,60,207,157,212,56,102,16,162,196,38,151,162,222,55,213,118,42,245,173,39,218,222,109,192,101,30,97,53,52,27,32,235,193,100,222,162,77,171,146,47,217,66,246,29,180,17,113,37,207,113,71,186,220,176,185,183,144,112,91,59,91,117,88,94,194,149,212,83,246,61,83,140,116,160,134,248,186,182,223,145,196,223,65,152,209,136,124,142,249,156,176,50,161,163,114,81,6,42,147,131,232,157,171,76,190,137,199,23,53,39,155,84,42,52,118,249,165,150,99,246,209,5,69,146,144,159,127,214,243,58,139,151,220,200,143,215,9,219,90,21,123,184,237,245,116,239,82,92,190,122,249,146,88,156,125,41,220,37,194,230,168,36,117,230,246,86,69,113,201,108,48,85,98,251,170,77,163,106,172,93,244,74,234,160,122,226,146,87,190,174,100,25,210,176,210,211,127,26,177,89,197,232,149,85,203,61,143,80,32,116,234,31,82,37,200,182,43,196,41,36,80,86,8,251,193,84,136,168,77,251,78,42,132,195,242,239,190,66,104,101,21,80,238,29,164,242,231,87,24,168,79,216,201,189,162,1,34,73,110,186,106,141,156,60,175,96,38,88,111,42,174,175,35,86,133,90,235,110,205,180,141,170,246,21,14,139,203,235,66,242,8,113,88,131,161,67,55,176,143,64,149,14,100,30,48,125,28,74,120,102,133,89,121,64,180,213,254,203,219,239,187,104,209,235,9,231,165,139,62,243,245,55,147,70,250,48,151,10,118,220,102,238,119,124,178,92,179,158,238,207,151,253,73,82,159,13,54,236,76,69,55,183,59,27,251,190,113,213,62,111,89,102,124,71,45,207,19,102,82,85,187,100,222,236,201,164,20,22,217,210,245,230,43,72,168,251,235,50,106,167,113,173,3,155,110,206,237,103,217,52,123,196,68,75,250,51,237,0,15,125,35,9,119,216,10,127,53,121,247,65,205,191,213,180,151,183,239,212,141,182,187,73,131,171,188,195,98,103,240,97,187,130,97,55,19,6,109,14,20,231,166,59,132,250,197,133,32,141,72,243,98,194,223,27,136,157,148,189,93,111,244,173,115,116,251,38,136,77,111,93,176,49,62,107,92,223,58,61,70,254,130,198,124,117,150,222,196,41,248,39,115,8,255,60,9,210,179,47,72,199,206,198,56,201,27,33,81,93,240,154,101,73,33,72,230,122,214,189,54,197,216,3,187,64,239,74,177,246,42,59,76,111,125,153,216,224,187,131,125,111,97,104,34,239,142,155,193,138,238,244,42,205,35,161,92,227,251,73,123,60,243,18,115,153,186,232,118,65,179,101,28,1,85,189,148,233,214,76,179,199,234,207,127,241,22,111,7,145,106,48,142,146,151,64,47,105,162,141,61,81,127,104,212,233,131,75,241,215,66,121,128,242,193,188,194,245,42,255,228,76,34,243,165,174,152,232,36,189,24,51,51,203,136,28,136,139,199,77,106,93,39,211,31,61,130,74,229,225,95,91,175,242,149,75,57,21,206,143,166,160,154,174,83,73,253,90,43,58,91,177,82,3,245,181,91,126,231,110,36,223,137,203,205,147,102,96,148,205,239,248,94,194,91,110,234,154,64,49,110,58,137,11,188,237,25,74,152,25,241,235,111,12,61,233,46,188,113,185,77,81,235,68,164,225,191,255,3,132,218,20,120,11,58,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOAuthDisabledMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOAuthDisabledMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ba685975-464c-6850-99f9-1f1fa441091e"),
				Name = "OAuthDisabledMessage",
				CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96"),
				CreatedInSchemaUId = new Guid("9299bebf-e0c0-4836-9492-fee7fb5aac83"),
				ModifiedInSchemaUId = new Guid("9299bebf-e0c0-4836-9492-fee7fb5aac83")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9299bebf-e0c0-4836-9492-fee7fb5aac83"));
		}

		#endregion

	}

	#endregion

}

﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoogleSharedOAuthAuthenticatorSchema

	/// <exclude/>
	public class GoogleSharedOAuthAuthenticatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoogleSharedOAuthAuthenticatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoogleSharedOAuthAuthenticatorSchema(GoogleSharedOAuthAuthenticatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a373997d-4e2b-4247-b13b-0acd4b13fe44");
			Name = "GoogleSharedOAuthAuthenticator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0dceaad6-a204-4806-b152-45288d90ce02");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,84,77,107,219,64,16,61,43,144,255,48,40,80,108,48,210,61,177,93,28,211,134,148,186,41,113,66,14,161,135,181,52,82,150,72,187,202,236,202,197,152,252,247,204,74,178,35,57,177,83,40,180,22,6,237,104,246,205,155,55,31,74,228,104,10,17,33,220,32,145,48,58,177,193,84,171,68,166,37,9,43,181,58,62,90,31,31,121,165,145,42,133,249,202,88,204,207,118,206,193,28,105,41,35,156,233,24,179,131,31,131,73,100,229,178,130,61,236,119,135,139,87,135,54,49,66,182,187,199,59,33,76,25,7,166,153,48,230,20,46,180,78,51,156,63,8,194,248,106,82,218,7,247,71,101,101,36,172,166,234,70,24,134,48,52,101,158,11,90,141,155,243,53,22,132,134,253,12,8,213,128,128,169,80,64,20,69,230,174,187,40,21,36,136,54,38,152,154,49,68,90,89,18,145,13,54,49,194,86,144,251,38,175,105,227,244,203,217,38,166,248,129,118,170,243,130,209,23,50,147,118,117,141,79,165,36,204,29,149,94,251,224,4,129,17,124,112,197,121,5,141,33,238,187,32,69,185,96,246,16,57,121,62,80,231,20,206,133,193,143,20,244,214,149,138,175,194,107,101,44,149,17,127,100,253,127,86,225,106,143,142,208,67,131,44,17,97,50,242,223,162,246,110,89,68,6,82,24,57,153,251,126,56,238,168,183,201,226,48,183,29,20,40,187,160,167,176,224,244,122,59,86,112,109,237,61,255,39,198,125,104,88,245,219,52,78,80,197,181,186,93,169,103,104,31,116,124,72,229,141,97,110,5,217,157,110,77,54,77,156,100,250,55,36,220,185,78,10,168,135,43,221,215,242,193,54,70,184,27,100,88,8,18,57,40,94,29,35,223,97,125,215,169,84,254,216,73,3,153,123,7,171,129,131,119,240,134,97,117,237,125,148,92,200,204,77,10,210,101,236,143,103,124,170,198,203,209,84,242,169,68,144,113,157,10,82,7,232,254,170,192,122,79,181,7,204,187,231,5,114,169,150,250,17,123,181,118,60,65,254,197,151,27,127,0,183,36,111,48,47,50,97,221,88,249,173,178,160,227,255,121,155,207,104,189,125,125,254,212,230,55,90,183,79,207,140,121,174,227,213,220,174,50,135,200,145,103,104,140,72,113,107,13,238,136,133,192,120,224,168,121,110,74,209,216,175,154,114,97,59,23,106,83,240,205,104,53,224,205,100,10,158,48,60,236,87,141,250,166,231,52,19,34,22,10,120,46,93,109,119,115,235,53,246,109,94,3,184,40,101,12,237,116,154,185,240,8,109,73,170,234,209,224,13,78,11,160,115,247,108,223,72,109,219,83,44,209,0,97,36,151,220,109,9,233,124,255,178,181,92,61,183,149,227,186,93,13,90,203,228,205,158,190,252,235,70,168,71,117,82,20,46,248,84,100,217,66,68,143,126,93,178,63,173,47,252,131,218,46,53,87,236,93,178,189,77,237,170,162,237,113,57,219,191,110,106,107,215,88,217,248,247,2,205,18,76,107,39,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a373997d-4e2b-4247-b13b-0acd4b13fe44"));
		}

		#endregion

	}

	#endregion

}


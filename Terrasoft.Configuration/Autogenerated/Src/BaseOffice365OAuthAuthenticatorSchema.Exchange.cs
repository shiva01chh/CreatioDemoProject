﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseOffice365OAuthAuthenticatorSchema

	/// <exclude/>
	public class BaseOffice365OAuthAuthenticatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseOffice365OAuthAuthenticatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseOffice365OAuthAuthenticatorSchema(BaseOffice365OAuthAuthenticatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0b5bb331-5b7d-4b5c-acc9-77bc0de507a5");
			Name = "BaseOffice365OAuthAuthenticator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2137d3bc-8953-4060-9df8-39c52dc22e74");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,89,91,111,219,70,22,126,86,129,254,135,169,138,173,41,212,34,147,212,105,183,177,45,64,190,117,29,36,177,97,89,221,135,32,8,70,195,145,60,13,201,97,103,134,150,213,32,255,189,103,110,20,41,146,178,28,20,251,180,69,80,136,195,57,247,239,220,232,12,167,84,230,152,80,116,75,133,192,146,207,85,120,202,179,57,91,20,2,43,198,179,111,191,249,252,237,55,189,66,178,108,129,38,43,169,104,122,184,241,28,222,210,7,181,62,124,71,151,138,103,134,209,107,201,179,240,13,203,254,92,191,173,74,73,83,158,181,191,17,180,235,60,60,59,233,124,117,158,41,166,24,149,157,23,46,48,81,92,116,220,152,112,194,112,18,94,141,11,117,7,239,225,70,20,69,232,72,22,105,138,197,106,228,158,111,104,46,168,164,153,146,8,103,104,134,37,69,87,243,57,35,244,167,159,95,34,67,139,48,252,15,46,48,130,65,88,232,249,68,21,70,121,49,75,24,65,36,193,82,162,19,224,81,178,48,28,198,85,6,232,149,189,209,120,1,124,62,27,53,123,223,11,186,128,72,161,11,70,147,88,190,66,215,130,221,99,69,237,203,220,62,32,65,113,204,179,100,133,46,47,40,86,133,160,83,197,18,227,46,244,113,190,121,114,140,78,181,110,214,95,171,240,55,170,142,26,100,163,96,112,232,228,211,44,182,42,212,245,1,28,73,37,10,205,67,107,101,140,182,55,106,158,61,146,148,34,34,232,252,184,223,180,50,152,74,42,128,81,70,137,70,227,160,31,141,106,174,244,190,124,196,139,27,108,80,81,231,10,78,214,161,12,54,143,53,244,123,95,158,172,243,87,107,89,42,82,23,221,229,224,107,193,115,42,116,48,116,208,185,2,181,105,220,162,173,63,88,35,85,99,20,50,225,47,108,189,33,146,176,36,170,235,237,185,34,126,15,153,194,98,138,32,164,58,113,198,142,3,157,138,196,42,219,91,80,229,126,245,4,5,172,100,168,127,167,84,46,95,69,81,194,23,44,11,83,70,4,215,201,6,64,100,25,13,9,79,35,98,202,64,196,181,70,47,34,175,23,237,31,26,70,95,186,2,208,52,73,241,79,244,235,76,185,213,148,255,168,25,70,151,93,77,184,76,33,136,80,41,109,44,224,119,202,164,132,159,18,45,4,206,180,194,138,35,64,73,197,86,146,48,0,13,194,121,158,104,228,192,229,39,27,61,33,128,157,110,139,79,113,2,160,195,66,134,55,80,56,254,43,24,148,16,200,12,5,21,161,122,244,22,179,100,253,184,171,197,183,96,204,56,207,209,229,25,154,222,92,34,62,55,230,45,233,12,141,175,47,159,108,201,13,149,188,16,100,139,49,62,124,188,80,9,231,159,66,238,29,169,67,215,162,116,87,190,189,165,128,206,70,133,109,53,241,20,234,173,130,74,138,81,70,151,168,82,46,58,218,108,232,156,59,89,101,100,66,149,2,195,36,84,17,40,219,132,139,216,115,157,67,63,208,174,146,57,37,12,108,216,133,177,14,209,140,63,108,50,6,7,66,217,153,51,42,58,28,110,78,114,44,112,138,50,24,18,142,251,169,101,116,25,247,71,255,136,216,163,200,112,31,85,187,212,61,103,177,243,29,204,17,45,62,9,126,43,224,70,169,138,171,147,61,211,250,87,19,114,71,83,140,104,245,225,24,213,75,127,88,189,250,22,103,120,1,170,64,131,187,132,94,133,51,66,79,86,239,192,218,160,223,22,143,193,97,69,24,34,246,6,72,168,10,12,173,246,246,206,102,247,178,244,142,48,4,190,103,116,126,202,147,34,205,126,199,73,65,101,208,188,81,121,29,244,91,156,10,225,216,175,248,99,59,253,249,67,206,133,242,121,60,78,18,160,133,14,77,31,33,131,10,181,19,25,190,167,206,130,109,217,255,228,212,24,131,243,238,181,131,255,159,27,235,220,104,115,202,255,44,57,90,35,82,207,14,236,174,60,61,61,60,229,150,252,168,94,249,170,4,233,100,96,161,14,205,137,179,76,165,122,206,111,192,253,17,218,91,44,63,61,129,200,166,164,115,40,76,114,91,40,119,75,175,107,104,218,144,93,176,92,176,20,1,138,20,154,11,158,58,184,2,44,29,98,255,88,42,51,247,104,224,153,113,101,87,168,151,132,22,233,6,232,190,193,42,206,19,25,50,170,230,33,23,139,232,78,165,73,36,230,228,151,151,207,127,237,143,94,47,149,149,4,2,40,29,213,48,110,164,216,118,45,71,167,107,213,93,139,135,9,97,139,254,192,201,147,86,243,197,209,2,124,13,195,137,121,188,0,95,24,186,192,189,246,124,124,178,184,99,88,242,138,68,215,118,255,62,156,192,172,165,2,93,178,200,29,22,239,63,160,207,104,47,220,67,95,6,239,159,127,176,145,2,196,160,148,199,7,64,101,201,195,55,52,91,192,70,248,47,116,224,110,204,81,96,110,140,208,179,193,122,74,49,162,126,60,54,245,208,202,15,246,142,247,246,209,1,26,26,134,131,202,136,210,43,53,115,50,96,35,77,96,127,15,246,134,64,177,247,227,222,96,125,242,81,159,68,123,142,220,77,67,231,25,225,49,136,8,167,183,23,255,214,201,109,29,19,64,30,194,96,165,66,237,33,189,167,252,124,224,94,88,57,131,26,242,118,152,144,30,95,71,96,198,76,96,158,195,202,212,109,224,232,39,193,250,118,2,147,31,161,82,134,155,253,67,193,116,44,177,221,231,116,241,95,154,137,212,205,202,103,39,224,77,26,3,123,189,211,161,24,43,188,43,192,53,193,27,61,232,247,71,110,161,95,143,217,150,155,93,3,26,248,173,50,49,64,159,192,78,7,37,84,119,5,171,116,236,182,20,105,95,116,87,252,198,172,107,138,255,53,151,202,121,163,178,55,130,90,30,204,165,234,251,200,180,130,186,22,30,113,246,203,71,112,118,114,254,64,73,161,191,49,196,179,242,103,75,75,144,176,246,159,157,172,143,130,65,137,221,53,97,56,81,144,176,183,235,152,248,90,221,83,98,229,175,247,234,13,74,127,103,240,253,172,165,114,7,21,115,54,44,113,172,123,155,163,162,254,168,84,100,206,43,21,6,157,4,53,121,155,93,162,114,189,181,221,54,239,87,252,161,85,97,173,14,249,130,64,63,114,87,58,165,66,116,195,147,100,134,201,167,54,178,158,186,19,124,233,121,236,182,105,153,102,96,65,171,113,233,90,65,163,110,207,0,209,50,76,101,92,89,110,205,90,75,31,160,216,101,11,72,164,251,232,197,179,231,7,209,179,159,162,23,47,35,131,160,161,93,118,135,138,15,49,209,152,28,18,183,52,14,221,68,56,196,89,60,212,78,26,226,156,13,89,54,180,139,215,16,54,175,161,231,60,180,75,116,212,31,177,248,99,181,61,148,235,177,59,214,117,64,127,237,112,131,55,131,253,184,76,109,215,237,98,42,137,96,51,200,27,150,181,88,185,181,59,233,1,7,84,87,27,210,167,25,251,179,160,31,141,243,172,144,185,254,202,166,69,67,229,114,42,80,109,227,174,229,69,224,229,149,118,156,107,162,182,212,186,79,135,80,106,115,192,173,239,93,221,45,114,90,138,69,208,83,188,231,208,61,78,88,188,143,142,200,200,49,56,79,115,181,58,138,200,8,113,168,23,98,201,36,109,116,75,95,107,238,153,80,5,78,42,125,83,75,209,3,95,163,105,214,108,240,197,224,245,213,236,15,224,84,26,113,166,3,115,140,220,113,104,160,24,212,41,215,93,177,74,244,190,239,13,234,127,64,223,65,91,44,146,164,172,56,27,109,219,246,193,86,210,208,76,88,71,150,96,84,166,209,218,4,59,103,28,119,78,8,229,104,112,136,44,169,183,144,56,194,134,105,134,141,23,228,250,173,185,252,190,95,172,129,212,165,154,239,239,134,172,26,192,71,103,190,173,159,35,117,143,55,167,166,176,11,106,122,14,78,244,202,177,243,167,150,54,122,212,193,55,88,143,80,38,46,62,116,173,60,202,105,70,127,246,236,210,180,68,135,115,84,165,219,105,120,218,16,54,193,186,65,165,97,246,221,127,176,28,155,98,117,203,93,199,241,243,13,250,225,135,146,99,120,41,223,113,245,14,112,119,37,76,4,42,45,207,141,93,83,223,90,64,186,39,107,9,163,189,253,180,209,169,235,67,185,63,168,247,126,87,131,64,145,218,246,219,24,93,190,98,252,153,150,195,142,31,171,170,252,182,206,63,186,52,77,168,0,252,232,233,71,187,26,73,243,136,108,34,116,142,62,246,67,121,219,215,102,103,50,213,90,117,13,60,85,177,62,98,58,238,141,63,113,152,173,86,186,191,105,156,103,120,6,147,232,198,58,186,143,108,50,193,40,11,16,208,127,204,0,13,250,107,32,140,99,166,175,225,100,42,146,107,109,128,12,199,113,28,244,115,115,31,150,184,62,241,52,45,192,48,120,111,152,85,177,167,102,202,22,0,193,41,252,131,255,254,6,94,97,219,57,203,27,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b5bb331-5b7d-4b5c-acc9-77bc0de507a5"));
		}

		#endregion

	}

	#endregion

}

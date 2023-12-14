﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UserDefaultPageServiceSchema

	/// <exclude/>
	public class UserDefaultPageServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UserDefaultPageServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UserDefaultPageServiceSchema(UserDefaultPageServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5b1b5a41-4484-4ea9-ae8d-474396ac7338");
			Name = "UserDefaultPageService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("95a133a1-cd5f-4df8-af8f-ad440775d7d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,91,111,219,56,22,126,246,0,243,31,184,94,96,70,2,12,230,61,105,82,36,141,91,120,182,153,6,73,58,121,8,138,130,150,104,71,59,178,228,146,82,26,237,32,255,125,207,225,69,34,37,202,78,59,151,189,160,243,80,196,228,225,185,243,59,231,136,83,176,13,151,91,150,112,114,195,133,96,178,92,85,244,85,89,172,178,117,45,88,149,149,5,125,47,185,56,231,43,86,231,213,37,91,243,107,46,30,178,132,127,255,221,111,223,127,55,169,101,86,172,201,117,35,43,190,57,234,253,6,54,121,206,19,228,33,233,27,94,112,145,37,3,154,115,86,177,193,226,219,172,248,52,88,188,170,139,42,219,112,10,242,51,150,103,255,82,202,13,168,140,118,23,101,202,243,157,155,244,20,52,123,216,207,132,222,242,101,71,176,206,203,37,203,15,15,95,149,155,13,184,230,109,185,94,195,114,183,239,250,16,41,194,59,130,143,173,211,211,52,5,119,237,217,166,139,162,226,98,5,65,27,167,60,63,27,221,186,226,57,171,120,138,193,12,158,7,139,59,245,97,255,239,130,175,193,77,228,85,206,164,60,36,167,219,45,36,72,197,139,106,1,206,194,236,144,138,236,14,99,137,59,130,37,213,7,88,216,214,203,60,75,72,130,199,194,167,38,191,169,147,250,232,5,223,44,185,136,126,134,132,36,199,100,202,188,3,139,116,26,35,79,203,244,77,157,165,61,158,139,244,104,156,91,13,2,23,169,28,50,185,251,64,222,235,61,125,250,73,155,204,139,84,91,29,242,192,224,70,96,154,151,66,145,30,28,28,144,23,178,222,108,152,104,78,204,239,75,81,62,100,41,7,39,92,46,72,85,146,53,175,200,22,189,79,62,103,213,61,65,221,36,17,101,206,37,181,28,14,28,22,158,31,71,101,163,47,39,173,166,175,51,158,167,160,234,165,192,36,231,218,49,91,253,131,8,206,32,141,242,70,49,3,15,22,250,150,146,143,181,247,251,200,61,179,80,169,119,157,220,243,13,187,96,5,136,22,228,35,27,172,29,249,146,66,167,2,75,74,245,9,186,69,255,53,17,188,170,69,17,18,64,94,190,36,81,104,253,152,68,1,105,113,207,38,250,58,43,82,143,34,154,14,79,77,227,88,25,143,217,48,49,41,209,207,137,46,41,224,70,86,162,198,40,160,195,85,176,140,23,116,224,70,66,22,245,188,239,43,26,27,87,244,244,7,51,3,65,122,250,253,242,102,193,88,13,253,28,147,67,82,221,103,50,10,171,139,91,52,28,158,96,178,236,245,238,5,175,238,203,209,76,94,204,139,122,195,5,91,230,252,69,164,48,1,192,32,171,26,45,230,253,34,157,105,164,144,90,203,118,57,62,33,111,120,53,71,218,140,203,215,165,184,54,133,42,114,57,226,209,147,225,89,99,170,246,171,221,150,103,141,2,84,179,122,76,10,254,153,232,31,81,47,134,177,206,113,172,143,245,166,136,166,215,23,211,25,153,34,194,5,55,174,123,242,3,100,115,69,215,200,185,111,124,75,249,90,148,155,8,9,160,164,213,57,159,198,244,84,42,246,49,148,18,40,204,63,149,89,225,236,107,54,45,213,28,254,122,215,169,227,83,161,20,186,144,243,79,53,203,91,85,28,209,183,247,92,240,113,83,64,126,164,237,160,151,76,0,88,67,97,147,209,192,229,49,97,210,120,83,95,76,3,16,65,231,211,249,35,79,234,138,119,145,140,32,255,78,72,164,85,234,101,200,33,17,208,157,84,90,137,95,88,94,155,184,71,65,135,206,52,143,190,130,59,152,132,163,103,0,230,105,95,58,103,54,131,19,38,210,94,250,42,147,207,26,168,130,112,235,85,39,179,35,139,89,159,8,42,222,95,153,201,255,43,41,58,158,148,65,15,14,18,243,129,9,235,72,11,47,224,194,175,201,211,108,71,86,185,169,56,240,233,151,101,180,155,142,147,183,153,172,246,101,158,224,18,42,139,201,139,103,28,136,12,239,158,87,40,160,238,156,37,247,145,187,222,160,253,166,7,64,79,234,46,233,24,179,221,233,90,117,23,28,197,38,114,98,139,167,196,150,222,48,1,61,68,43,154,28,31,123,161,104,232,208,87,38,7,38,84,135,4,10,83,19,169,66,165,2,17,185,173,114,172,214,117,11,174,39,164,152,234,13,109,223,68,41,219,154,133,191,28,107,38,218,109,120,60,242,77,166,232,56,164,86,220,28,204,51,108,159,108,47,18,123,208,167,249,237,67,17,167,166,159,140,120,209,104,232,80,66,79,172,108,69,207,15,155,2,213,66,153,195,253,238,202,245,174,37,199,22,220,87,93,51,55,209,123,68,39,61,106,183,34,41,85,247,20,110,181,163,234,212,135,203,103,244,10,101,5,26,241,212,58,198,252,36,15,153,168,128,187,231,34,71,78,223,69,210,152,105,6,5,225,236,188,119,240,211,152,53,146,164,78,102,61,6,178,234,49,148,81,30,50,217,76,234,139,199,57,189,98,25,8,25,205,158,167,81,7,116,195,249,78,7,156,53,58,164,110,115,229,244,64,59,45,247,140,96,104,1,235,95,81,27,236,142,177,61,229,222,199,208,93,124,185,195,109,55,37,194,82,244,133,57,227,52,238,253,33,78,45,128,145,210,204,106,171,82,184,3,156,220,242,36,91,101,224,94,105,13,83,147,220,112,148,211,43,91,44,42,164,128,100,63,158,118,39,166,39,248,47,41,87,138,181,97,37,113,94,92,241,42,49,99,34,125,113,160,78,119,204,116,8,228,73,23,80,203,66,18,86,164,70,227,207,24,4,242,43,111,72,6,203,90,2,66,36,82,60,96,137,80,235,112,53,133,96,77,171,131,58,251,35,89,164,63,202,23,7,86,144,51,105,156,103,74,32,24,167,42,204,76,151,3,85,108,218,14,69,141,250,246,6,117,214,218,12,218,201,194,43,53,187,40,109,141,9,95,95,71,106,7,207,14,54,103,43,18,109,233,21,12,224,228,111,32,171,206,243,184,133,109,220,51,208,109,175,219,63,120,3,228,189,235,214,30,48,64,127,215,163,248,160,145,31,213,141,181,44,139,239,147,39,194,115,201,251,12,20,125,143,201,172,171,185,186,162,131,88,226,242,36,79,29,87,83,61,188,218,49,50,244,56,14,178,237,152,113,147,224,73,41,82,183,142,181,101,217,66,195,160,60,119,160,161,79,211,94,199,221,170,168,252,238,177,26,184,191,19,135,230,97,65,242,14,88,132,68,5,123,17,52,8,162,247,60,191,211,115,112,96,86,192,94,236,67,133,167,147,146,71,79,1,127,48,184,196,238,187,209,49,230,245,135,129,153,163,112,199,248,169,31,152,125,229,252,57,32,196,186,222,191,237,49,7,152,100,80,225,75,80,137,13,102,10,5,80,6,159,130,82,255,111,64,107,56,79,121,16,22,116,205,159,131,102,206,44,33,95,181,77,181,233,135,119,76,127,97,21,59,158,225,174,186,69,203,161,68,123,151,100,130,151,73,38,212,111,241,225,22,157,98,8,162,216,111,245,195,44,164,230,33,251,76,156,91,105,209,167,163,232,205,5,184,161,162,98,1,193,7,2,15,52,113,12,112,24,253,240,67,31,41,252,17,32,0,24,71,93,153,104,5,183,200,96,78,135,76,214,58,141,89,236,235,101,181,152,4,28,5,154,180,46,129,216,182,49,117,97,185,173,59,46,193,7,252,42,26,168,94,46,77,76,94,146,224,209,195,65,177,233,192,44,40,12,49,241,138,21,107,222,121,201,129,191,118,156,209,232,182,31,255,220,142,237,235,62,203,155,135,170,145,175,242,102,95,225,40,244,164,21,62,130,100,197,170,36,108,89,214,149,233,117,205,93,89,54,6,201,66,223,231,239,12,39,247,237,227,238,84,110,127,198,25,124,179,133,123,184,204,114,224,117,197,63,213,153,224,27,224,44,35,247,7,62,52,225,168,181,251,8,82,81,179,144,198,131,7,150,176,245,16,197,51,38,59,95,216,23,151,175,255,120,173,24,169,198,99,207,87,103,77,248,220,175,202,206,215,238,192,183,107,3,154,207,251,178,61,11,9,120,206,44,176,243,209,100,68,54,25,83,249,104,255,23,249,209,245,209,247,144,49,247,168,71,145,63,194,119,161,135,15,235,1,89,65,94,38,221,235,209,226,109,185,38,31,115,248,231,152,192,159,118,222,135,170,130,239,162,248,178,50,23,162,20,211,248,232,247,124,226,15,60,28,66,21,190,41,223,45,255,9,42,235,210,188,179,236,150,138,80,222,66,87,164,49,201,159,93,251,219,22,127,203,26,225,21,61,23,208,160,253,106,50,233,191,65,130,47,202,154,2,200,154,207,115,230,113,81,47,171,143,113,93,181,52,56,216,45,124,27,88,255,172,222,239,238,221,150,235,255,159,193,69,233,201,221,45,95,46,138,135,242,87,30,105,191,226,91,241,229,187,235,155,233,140,32,212,114,89,65,225,221,48,236,218,128,244,130,75,9,98,244,18,253,73,2,214,168,24,158,149,105,115,93,53,57,247,200,218,85,122,43,160,80,242,212,112,68,214,114,11,192,203,119,243,246,222,170,195,215,224,63,49,99,87,162,233,96,201,156,29,1,23,234,233,231,40,102,64,6,250,31,76,148,104,254,152,240,173,202,4,254,216,222,44,68,22,170,16,36,226,143,212,184,199,133,39,123,131,125,44,208,58,197,223,38,169,111,183,233,43,110,211,127,207,240,247,133,215,108,76,241,93,179,224,95,117,255,188,78,126,164,153,135,53,248,239,223,86,46,122,172,142,38,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b1b5a41-4484-4ea9-ae8d-474396ac7338"));
		}

		#endregion

	}

	#endregion

}


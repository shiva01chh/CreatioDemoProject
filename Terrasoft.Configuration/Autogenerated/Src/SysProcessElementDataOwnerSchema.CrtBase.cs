﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysProcessElementDataOwnerSchema

	/// <exclude/>
	public class SysProcessElementDataOwnerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysProcessElementDataOwnerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysProcessElementDataOwnerSchema(SysProcessElementDataOwnerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("48f31341-3966-443f-a394-8a177770cce2");
			Name = "SysProcessElementDataOwner";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,87,219,110,27,55,16,125,150,129,252,3,177,237,3,23,16,86,237,107,108,11,240,45,142,0,219,113,107,59,121,136,139,128,222,29,73,68,119,201,13,201,181,171,26,250,247,240,182,87,173,110,117,243,98,153,220,225,204,225,57,51,67,146,145,12,100,78,98,64,247,32,4,145,124,170,162,51,206,166,116,86,8,162,40,103,239,14,94,223,29,12,10,73,217,12,221,45,164,130,236,176,51,214,246,105,10,177,49,150,209,37,48,16,52,94,177,185,162,236,123,61,217,140,149,101,156,245,127,17,176,110,62,58,63,237,251,116,13,82,146,153,158,171,221,106,171,95,4,204,52,54,116,150,18,41,223,27,64,183,130,199,218,244,34,133,12,152,58,39,138,124,122,209,176,173,245,104,52,66,71,178,200,50,34,22,99,63,190,38,140,204,64,34,110,172,16,159,162,220,57,64,224,60,160,68,187,136,202,197,163,198,234,188,120,74,105,140,98,19,122,99,228,193,171,141,94,129,253,64,33,77,52,218,91,65,159,137,2,247,49,119,3,36,128,36,156,165,11,244,32,65,104,181,152,99,31,125,43,90,227,195,222,53,147,107,57,59,155,19,109,148,186,125,9,244,45,91,153,58,70,43,102,209,132,73,69,88,12,150,86,11,22,88,226,240,182,193,107,8,82,137,34,86,92,152,45,88,14,156,69,151,93,59,49,97,84,81,146,210,127,53,197,12,94,16,245,113,12,211,71,18,0,197,2,166,199,193,122,250,130,81,229,171,197,190,155,201,137,32,25,98,58,209,143,131,54,65,193,216,16,136,226,106,34,58,26,89,107,187,216,107,183,62,44,238,208,223,118,30,34,83,56,131,65,71,20,205,108,143,74,203,205,132,94,131,154,243,181,233,112,89,208,228,235,95,232,18,212,5,83,84,45,60,92,144,120,61,246,9,155,242,50,125,91,147,37,236,103,34,144,4,83,215,26,177,81,229,206,14,112,103,59,161,53,30,152,30,80,100,12,55,68,154,36,65,249,241,131,224,89,243,147,131,25,132,209,23,170,230,31,41,83,18,155,8,55,252,138,199,127,155,49,14,203,165,95,230,32,0,7,110,69,195,229,68,94,124,47,72,138,93,220,232,214,168,6,74,107,210,183,167,168,92,30,134,136,72,191,19,203,251,64,128,42,4,243,59,141,46,254,129,184,80,112,193,138,12,4,121,74,1,235,74,24,35,161,219,154,114,145,62,147,180,128,35,195,248,184,187,217,48,186,231,39,186,21,45,112,216,212,180,84,233,138,74,229,22,26,165,252,186,123,126,206,241,164,142,231,13,242,82,193,73,50,220,144,128,91,69,116,59,221,67,199,90,200,154,235,30,253,92,72,3,190,54,242,74,213,86,6,145,241,162,251,198,138,76,18,55,182,24,86,62,78,88,130,3,13,74,145,88,185,165,123,201,252,41,77,220,224,191,8,173,251,35,56,181,237,127,107,36,47,133,54,106,246,235,252,204,105,130,30,114,125,36,64,47,99,174,117,252,60,205,77,225,230,117,118,105,213,59,233,214,10,212,235,201,49,102,146,197,237,163,155,44,67,180,57,25,162,59,80,77,29,135,104,55,253,110,224,165,210,175,93,255,91,243,200,132,175,22,121,117,189,62,131,169,190,49,144,120,142,176,161,70,139,67,89,147,160,146,183,193,13,87,116,186,176,0,36,166,155,185,89,238,41,124,125,102,252,60,225,247,211,203,184,104,235,229,169,255,31,212,106,247,197,157,235,223,149,127,9,227,45,197,223,155,7,203,213,83,211,148,134,57,196,39,201,233,194,167,43,182,243,113,153,187,189,157,244,143,2,196,98,183,118,122,207,115,252,251,14,205,245,243,139,38,237,36,201,40,123,208,183,161,149,174,186,161,39,218,203,22,174,1,183,155,105,211,235,253,34,135,205,196,158,18,9,214,159,140,12,45,171,139,75,239,157,230,218,160,165,36,253,78,95,195,83,248,19,98,46,146,125,154,235,16,241,66,57,113,72,25,59,108,181,240,106,186,79,213,59,154,229,41,184,135,0,160,51,29,78,129,45,108,26,219,231,140,185,210,206,32,241,6,78,108,176,183,3,7,213,212,160,190,187,154,119,5,207,193,61,129,154,157,53,243,158,189,248,173,104,190,143,76,18,211,115,181,99,83,33,230,23,135,67,247,229,148,39,38,109,126,13,94,95,209,99,32,124,192,199,224,189,30,189,182,81,44,31,117,29,62,6,21,6,109,164,109,170,161,254,188,92,6,222,237,71,207,110,9,64,39,43,115,19,65,117,20,203,249,19,39,34,9,156,197,210,53,177,22,173,126,103,107,143,52,215,30,155,140,25,174,218,213,178,43,119,91,117,169,3,212,158,14,43,71,133,45,89,119,178,117,203,183,46,4,103,191,250,182,137,110,185,46,24,35,95,125,37,195,26,103,233,118,57,44,145,174,63,223,91,103,133,229,32,47,27,222,155,122,184,39,185,225,108,75,175,211,173,61,209,38,10,2,191,223,29,61,212,205,91,123,40,236,169,17,132,251,61,69,182,61,235,156,164,59,188,154,87,159,105,125,144,131,177,249,43,50,155,12,136,60,153,54,177,217,117,243,49,183,250,54,244,207,59,43,167,131,250,214,231,146,69,115,91,159,107,46,65,187,111,178,13,183,10,58,69,184,235,36,186,2,54,83,115,52,70,191,85,55,149,173,151,140,174,147,141,119,153,117,238,234,203,234,94,238,150,107,146,200,207,181,243,74,207,29,28,252,0,81,158,234,92,132,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("48f31341-3966-443f-a394-8a177770cce2"));
		}

		#endregion

	}

	#endregion

}

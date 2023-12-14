﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PRMBaseConstantsSchema

	/// <exclude/>
	public class PRMBaseConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PRMBaseConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PRMBaseConstantsSchema(PRMBaseConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("67a3d5ac-4431-4d38-8572-f746181cd701");
			Name = "PRMBaseConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e3f6af0f-4ac0-46d1-b2e6-e18d10bd5c8e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,152,219,110,219,56,16,134,175,83,160,239,32,180,55,221,11,54,226,65,164,184,221,93,128,199,34,64,211,6,73,250,0,146,76,59,66,109,201,43,201,237,6,197,190,251,142,100,59,71,215,238,58,135,230,34,177,73,234,159,249,194,225,204,80,85,54,11,237,60,43,66,116,30,154,38,107,235,113,247,214,212,213,184,156,44,154,172,43,235,234,229,139,239,47,95,28,44,218,178,154,68,103,151,109,23,102,239,94,190,128,145,215,77,152,192,116,100,166,89,219,254,30,157,156,30,235,172,13,240,104,219,101,85,215,14,107,230,139,124,90,22,17,140,116,240,167,232,87,110,88,120,240,125,88,124,173,184,158,2,213,65,96,57,125,120,120,24,253,209,46,102,179,172,185,252,107,57,16,153,38,140,202,46,58,111,178,170,205,138,222,221,243,203,121,136,202,81,168,186,114,92,134,230,237,213,147,135,55,31,189,237,216,251,69,57,90,73,221,85,250,51,170,194,183,97,193,155,87,218,72,145,168,152,32,227,189,67,204,26,142,20,166,28,89,107,99,130,165,17,24,171,87,191,189,251,177,183,54,228,143,228,236,160,180,205,87,193,172,167,9,79,17,143,37,65,140,112,135,36,17,18,25,202,45,150,66,115,70,205,54,95,15,163,79,96,116,50,68,64,52,207,26,136,146,46,52,81,183,135,195,77,200,70,117,53,189,92,122,126,45,123,178,86,237,157,63,26,221,114,159,197,218,16,103,36,114,84,74,196,98,71,145,78,189,66,46,214,152,106,195,177,246,118,187,251,102,209,52,224,102,239,123,87,133,166,189,40,231,143,202,177,210,63,185,150,31,120,54,176,40,162,89,66,173,69,158,59,142,24,23,2,41,33,61,18,76,41,235,44,192,89,190,157,229,60,107,38,225,233,80,150,242,63,65,194,84,130,133,33,41,114,154,91,196,82,43,16,68,61,48,37,194,242,216,43,30,199,110,59,137,14,85,24,151,221,163,186,191,210,220,22,78,216,48,199,37,108,1,53,148,65,56,197,41,82,9,103,72,123,73,40,81,148,89,34,182,59,238,155,16,162,34,52,189,151,197,213,169,216,176,29,48,25,38,117,115,249,48,166,222,156,185,105,205,172,101,111,98,73,194,156,18,112,44,12,131,92,196,20,236,12,156,13,129,168,101,86,41,130,185,81,59,246,99,101,35,140,162,240,207,28,62,183,79,74,245,113,49,203,67,243,105,124,101,213,45,141,110,132,115,78,107,230,99,143,100,236,60,98,24,51,164,52,181,40,241,26,59,154,96,29,219,116,59,220,199,186,15,52,176,59,207,46,103,125,46,0,150,139,122,244,64,134,26,34,173,28,157,44,37,143,151,138,55,253,78,52,113,18,210,20,28,242,216,32,38,24,65,138,112,13,81,103,101,44,168,21,92,239,240,251,214,198,71,227,69,53,122,140,124,117,83,212,131,230,253,242,70,60,133,234,192,144,144,22,28,39,210,162,20,142,10,28,118,11,161,213,215,19,187,181,188,29,70,110,180,88,57,221,87,165,175,101,119,25,181,197,69,152,101,209,162,42,255,94,60,144,224,74,93,173,196,207,6,237,207,119,147,84,170,98,107,189,69,74,74,168,210,218,39,40,213,9,148,142,132,91,239,12,197,46,222,81,249,158,22,227,168,130,3,53,129,222,170,110,86,41,119,67,194,162,132,7,41,211,49,226,12,226,135,201,113,134,210,60,140,144,12,57,227,48,197,199,69,241,43,33,250,22,109,49,237,155,180,31,51,240,60,163,92,140,115,20,138,177,64,140,242,0,12,105,134,68,202,112,204,153,76,50,138,183,51,28,103,205,151,208,245,141,231,21,195,142,244,244,24,108,199,95,186,201,58,196,86,116,67,109,89,103,169,1,179,95,249,22,134,219,240,230,149,241,56,73,157,162,168,63,250,144,134,19,72,195,218,40,164,76,42,148,211,2,115,190,163,89,217,0,154,205,231,77,253,21,18,115,239,227,162,125,20,50,181,210,60,27,36,239,115,48,11,39,63,97,40,37,6,130,142,26,72,0,41,247,200,82,234,169,36,94,211,93,28,63,209,116,61,74,244,109,238,189,110,21,255,155,96,15,239,192,62,223,245,58,170,199,209,180,108,187,232,107,54,133,137,1,13,134,54,130,239,65,120,54,15,197,85,182,238,153,62,128,173,123,92,206,248,68,64,186,131,44,199,108,223,37,115,40,150,210,32,42,149,39,64,152,90,74,246,224,26,133,25,88,158,62,23,154,93,154,187,71,167,157,102,60,161,24,49,79,224,14,144,16,131,180,195,41,194,206,38,30,43,149,234,52,222,131,46,175,235,105,200,170,231,162,211,75,115,247,232,104,34,29,92,107,18,72,21,20,232,124,12,189,180,134,152,84,206,112,101,99,193,83,178,163,77,216,72,215,118,77,159,70,158,9,238,108,176,118,143,77,192,177,98,88,42,36,157,80,208,2,165,80,130,45,166,200,8,239,49,139,137,195,116,71,34,217,200,86,66,229,156,192,199,103,130,59,90,154,187,71,71,8,38,132,97,133,4,118,208,214,241,84,35,69,109,130,76,12,89,18,90,140,4,27,185,7,221,201,233,113,52,175,155,14,14,222,162,133,161,6,226,6,144,251,119,46,106,52,43,43,120,168,139,186,44,159,134,61,224,64,252,100,208,254,12,210,167,160,124,167,86,203,148,8,66,113,142,70,152,101,136,101,12,163,156,231,35,148,10,158,5,158,230,130,166,203,90,125,112,240,63,169,86,187,19,153,163,179,167,224,90,201,131,250,15,200,18,42,226,2,75,138,128,4,18,101,200,115,36,19,89,0,25,195,188,8,5,133,18,247,48,178,247,211,58,127,154,77,91,89,88,26,248,17,95,28,135,108,12,13,22,23,9,116,89,227,34,134,162,29,83,52,230,73,150,231,52,207,68,186,163,83,220,92,219,192,147,245,209,138,234,111,253,239,37,150,131,69,235,214,251,52,20,167,229,228,162,59,171,23,77,17,246,230,220,170,250,1,150,174,254,17,159,6,55,110,189,90,49,220,90,1,229,156,8,6,155,235,113,140,164,1,120,78,188,228,82,105,131,173,219,107,115,109,24,103,208,223,254,34,230,181,245,155,168,158,193,197,133,240,20,57,74,24,220,206,224,174,47,29,92,112,18,163,133,49,50,230,84,94,215,139,215,161,26,45,95,166,14,223,255,93,190,176,189,53,8,99,253,207,127,196,192,42,179,255,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("67a3d5ac-4431-4d38-8572-f746181cd701"));
		}

		#endregion

	}

	#endregion

}


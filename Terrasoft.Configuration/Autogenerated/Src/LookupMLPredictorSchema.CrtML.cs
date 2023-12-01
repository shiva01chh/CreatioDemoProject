﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LookupMLPredictorSchema

	/// <exclude/>
	public class LookupMLPredictorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LookupMLPredictorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LookupMLPredictorSchema(LookupMLPredictorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d33381f2-8dc6-4f47-984a-cfcaba4b8e3f");
			Name = "LookupMLPredictor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33c09d4f-db5e-4d77-bac6-f1fd801beedb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,89,221,115,219,54,18,127,86,103,250,63,160,234,67,232,25,29,221,222,163,45,105,198,113,236,156,166,82,207,173,157,188,118,96,17,146,112,161,72,5,32,157,240,92,255,239,183,139,5,72,240,83,114,110,122,79,151,7,197,2,22,139,221,197,238,111,63,148,240,189,208,7,190,22,236,65,40,197,117,186,201,194,235,52,217,200,109,174,120,38,211,36,92,45,191,255,238,249,251,239,70,185,150,201,150,221,23,58,19,251,203,198,119,56,18,199,98,141,244,58,124,47,18,161,228,186,69,179,148,201,231,106,113,27,167,143,60,190,184,184,78,247,123,184,101,153,110,183,176,92,237,251,226,32,69,247,142,18,125,235,225,77,146,201,76,10,221,75,112,203,215,89,170,122,40,86,203,112,145,100,66,109,192,52,72,0,36,63,42,177,5,5,217,117,204,181,190,96,203,52,253,148,31,86,203,59,37,34,137,156,12,209,249,249,57,155,234,124,191,231,170,152,219,239,150,66,179,216,28,97,27,41,226,136,61,241,56,23,236,177,96,2,5,45,104,85,135,142,199,185,199,228,144,63,198,114,205,214,120,113,215,189,163,103,115,119,83,194,21,63,44,192,240,180,119,80,242,137,103,194,50,129,247,202,247,73,73,48,114,28,74,22,119,42,61,8,133,246,187,96,119,230,122,75,96,101,209,153,66,131,221,241,108,199,158,217,86,100,151,76,227,199,75,39,217,85,44,185,238,164,251,81,36,17,93,73,11,118,189,185,92,106,6,14,150,53,68,42,53,195,61,119,227,63,228,118,119,47,183,137,220,200,53,79,192,189,103,108,140,107,227,203,225,11,110,205,43,92,160,254,25,56,180,136,220,29,246,43,83,130,71,105,18,23,236,131,22,10,196,73,200,237,217,31,121,237,251,165,47,153,206,32,148,214,213,209,5,120,59,251,35,134,143,25,60,231,118,197,19,190,21,10,2,39,195,48,16,42,24,175,150,227,179,35,146,246,189,80,211,3,205,2,176,214,44,85,104,123,205,178,157,96,251,52,18,49,147,81,200,222,22,44,18,27,158,199,25,147,137,132,109,112,201,101,202,163,21,82,188,227,25,103,123,145,237,210,40,44,153,159,55,185,79,141,47,151,95,31,124,254,213,169,138,200,58,199,251,92,70,204,92,179,136,156,115,148,38,243,156,228,85,26,129,15,152,247,254,203,85,171,46,194,0,134,232,85,39,234,106,15,126,168,148,126,157,178,7,10,124,244,1,112,185,39,9,50,228,42,102,177,76,62,129,127,126,145,16,145,70,196,191,74,255,238,251,135,148,183,49,121,79,212,31,64,216,111,82,156,12,239,93,47,18,254,24,131,206,155,152,111,79,215,97,213,96,163,25,87,194,241,26,82,227,49,77,99,58,125,87,30,190,177,34,12,184,239,32,150,169,28,33,252,148,16,94,192,11,74,30,203,127,11,16,152,37,226,75,229,130,233,198,68,192,84,11,64,65,37,54,179,113,43,73,140,207,231,4,253,67,118,58,112,197,247,44,129,146,96,54,174,195,217,120,142,47,143,107,8,179,118,49,156,158,155,19,190,141,90,23,7,13,156,172,243,61,99,207,38,13,52,208,19,112,177,3,78,143,216,115,101,124,217,96,183,121,132,122,118,120,71,239,5,250,78,201,29,39,44,125,252,23,112,159,163,147,85,15,186,72,14,121,134,177,17,220,80,94,166,244,60,49,98,142,150,82,103,211,90,242,156,91,2,90,196,124,8,27,78,173,39,174,0,245,53,6,224,204,60,89,191,20,193,153,209,113,68,183,222,175,119,98,207,153,166,255,102,246,142,144,150,137,112,3,53,12,95,239,88,80,19,135,73,243,145,12,73,101,196,90,155,29,96,77,119,132,183,50,137,136,61,157,121,91,224,169,0,217,133,248,151,21,111,68,226,218,234,165,20,12,76,72,199,62,226,122,64,204,221,17,178,64,120,21,69,196,206,84,3,19,98,97,105,94,204,167,18,89,174,18,107,49,255,201,221,35,218,39,65,12,123,224,10,34,142,22,2,11,48,164,202,175,224,191,19,2,92,146,110,17,77,216,43,31,174,251,21,26,94,26,250,84,94,18,119,8,255,182,64,81,130,74,42,171,44,154,255,115,46,84,97,157,194,103,243,27,174,219,35,150,220,144,134,224,212,24,172,102,159,68,14,23,250,163,212,18,224,7,248,0,144,136,65,191,216,59,255,120,133,107,208,205,240,110,68,27,88,30,53,127,240,215,224,8,157,13,81,91,255,101,75,161,124,93,137,171,187,14,4,179,174,72,235,186,148,73,110,88,224,100,42,253,213,218,195,242,248,243,79,43,172,61,27,94,37,133,113,54,54,155,155,144,48,18,225,113,79,192,179,242,134,17,128,90,38,19,103,66,43,244,168,169,191,127,182,195,111,137,252,125,233,149,13,119,153,148,238,120,214,229,219,228,161,8,209,166,102,197,19,191,155,64,152,51,243,232,21,68,5,3,88,182,38,6,5,34,152,143,66,252,32,127,17,232,112,171,229,135,76,198,216,165,101,87,119,11,88,107,138,233,57,169,46,19,246,149,218,90,103,245,178,22,44,230,123,208,41,24,87,132,227,137,151,230,61,86,116,255,17,54,68,4,44,232,15,123,124,177,90,90,150,80,242,126,45,32,199,226,231,140,186,28,106,226,140,213,167,13,194,121,80,147,127,82,201,96,25,15,88,124,221,177,170,81,244,60,142,233,112,6,225,107,189,167,143,216,8,26,218,11,138,160,89,253,77,234,143,101,29,138,1,23,19,40,95,215,226,64,85,78,233,166,216,50,132,55,74,165,234,54,85,123,14,22,171,75,207,54,92,198,174,6,20,72,119,193,158,127,122,1,131,2,32,138,112,37,180,6,140,234,114,221,78,21,94,153,116,107,13,83,103,9,115,207,159,4,21,235,181,234,43,137,88,126,136,32,6,180,195,2,202,46,16,247,94,177,39,53,219,65,3,7,237,147,46,251,186,236,212,106,134,34,143,170,24,155,178,252,226,165,69,79,41,72,211,1,251,101,248,68,102,242,17,1,5,2,196,120,110,16,199,150,102,180,235,192,103,144,145,209,253,94,224,56,5,222,57,79,214,227,57,126,210,251,154,82,56,174,18,240,70,165,123,223,72,49,184,52,203,82,246,104,74,80,236,87,1,86,237,229,102,192,80,26,108,177,97,211,245,28,253,121,122,190,158,179,191,25,227,122,166,133,178,146,174,248,34,227,152,248,197,230,125,235,85,95,217,23,63,73,149,229,60,102,79,41,228,93,124,232,10,175,116,163,148,26,130,58,107,107,91,110,217,188,222,180,173,221,69,179,76,23,55,9,160,135,194,42,188,155,229,132,117,223,212,178,179,15,151,85,145,123,4,178,26,101,242,164,89,35,248,104,10,70,81,93,184,85,86,203,64,143,150,83,243,160,118,191,229,97,206,135,117,211,90,80,1,44,105,163,139,245,243,90,162,52,229,217,196,89,217,50,238,178,143,113,7,127,128,242,209,22,124,21,2,98,90,110,25,145,253,64,36,37,102,245,241,105,157,12,234,66,189,48,17,107,113,140,139,11,205,91,169,116,246,79,245,142,186,221,192,213,220,206,159,194,250,40,104,214,26,15,213,48,17,21,235,185,176,161,156,1,228,69,178,73,29,30,255,154,250,232,100,35,40,18,54,70,48,124,223,0,32,191,33,132,86,98,157,42,136,208,8,22,127,126,121,51,182,110,61,170,21,251,33,149,179,189,143,89,21,217,8,228,190,26,45,225,192,117,76,149,220,18,240,205,243,223,65,166,211,164,123,149,112,147,110,55,10,125,201,59,42,66,63,222,155,205,15,70,76,71,159,210,132,8,203,220,29,173,183,39,62,113,232,109,144,54,24,235,216,61,116,251,128,149,189,193,31,130,50,216,112,112,216,179,215,37,205,99,77,255,3,206,167,17,208,99,104,121,236,0,36,194,193,13,62,86,133,251,167,166,193,61,161,5,165,181,114,68,215,74,71,228,75,122,14,9,2,251,10,147,32,32,40,232,128,248,10,232,77,89,27,7,154,69,83,148,233,185,59,238,141,5,92,118,48,35,148,7,85,212,166,80,224,159,30,162,153,198,205,10,234,67,242,127,217,133,141,87,75,115,225,248,219,154,176,122,57,124,221,215,33,141,17,203,83,200,69,251,135,226,32,194,170,20,30,215,154,57,255,64,3,183,123,9,91,51,39,95,19,251,27,194,236,120,15,226,44,91,97,184,59,123,12,219,104,110,150,164,80,73,164,57,188,254,99,129,224,48,35,204,24,55,57,187,202,210,68,133,15,75,61,3,52,127,148,128,182,139,188,184,156,162,219,204,7,76,224,77,22,7,249,80,61,225,55,6,215,173,150,174,53,164,29,228,136,222,58,239,127,69,55,221,158,57,235,84,102,255,161,199,16,208,202,54,185,133,55,159,33,120,180,9,141,240,102,127,200,138,179,254,103,194,208,18,14,43,8,207,35,169,237,160,180,22,170,102,178,138,239,153,41,46,19,216,46,68,118,250,59,218,245,114,240,48,52,198,45,127,1,195,90,24,145,3,107,25,151,188,17,222,108,137,106,93,145,82,207,169,160,86,205,87,234,53,183,101,102,231,5,131,53,183,107,204,253,6,161,74,128,195,103,37,14,12,107,195,20,226,98,214,109,197,111,134,35,160,38,153,22,55,232,23,177,61,63,180,225,243,255,77,70,179,201,168,231,16,211,97,88,143,186,74,34,204,189,182,97,61,62,7,36,151,238,152,159,88,100,96,237,215,116,123,255,163,46,132,213,97,184,2,247,154,80,54,105,117,76,53,221,28,185,173,72,8,8,113,195,215,187,224,147,40,108,57,59,247,107,186,58,49,78,107,169,235,241,167,136,110,94,102,167,125,142,83,248,139,112,19,242,17,121,182,183,103,62,237,92,237,172,86,244,85,105,171,61,209,245,158,176,154,226,118,77,46,47,187,139,93,147,195,125,175,29,46,111,39,245,232,161,146,248,120,205,139,66,245,148,158,39,14,233,64,249,158,223,31,92,183,220,175,244,55,12,176,154,163,196,142,17,148,25,183,118,31,39,223,196,20,213,73,0,181,116,14,77,5,144,253,212,159,159,238,218,63,31,14,63,13,179,245,36,166,170,29,216,241,132,62,169,153,189,252,188,213,156,77,56,51,119,106,212,126,221,73,199,224,96,160,230,167,213,250,162,89,131,127,255,1,0,166,188,109,124,35,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d33381f2-8dc6-4f47-984a-cfcaba4b8e3f"));
		}

		#endregion

	}

	#endregion

}


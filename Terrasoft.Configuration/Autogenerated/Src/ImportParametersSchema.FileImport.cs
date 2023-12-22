﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportParametersSchema

	/// <exclude/>
	public class ImportParametersSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportParametersSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportParametersSchema(ImportParametersSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("04eff58a-422b-45e2-b3de-4a80f0b72fbd");
			Name = "ImportParameters";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("422e303b-e4b1-4d5c-a964-ae75099f60da");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,26,93,111,219,56,242,217,11,236,127,224,122,95,100,160,80,222,155,216,69,224,54,189,220,118,179,69,236,237,2,87,20,133,98,141,109,94,100,210,37,165,100,221,108,254,251,14,63,36,145,18,37,203,45,110,175,15,169,61,156,25,206,12,231,147,52,75,118,32,247,201,10,200,18,132,72,36,95,231,241,156,179,53,221,20,34,201,41,103,241,21,205,224,122,183,231,34,39,63,254,240,244,227,15,163,66,82,182,33,139,131,204,97,119,222,248,142,180,89,6,43,69,40,227,183,192,64,208,85,11,231,29,101,95,90,192,219,130,229,116,7,241,2,73,146,140,126,213,155,183,176,150,91,1,73,138,128,122,229,6,30,115,220,77,9,254,111,233,146,184,10,237,118,93,43,2,186,224,241,85,178,202,185,160,32,59,49,22,185,161,199,245,159,5,108,80,98,50,207,18,41,95,18,99,177,247,137,64,251,230,32,164,198,57,59,59,35,23,148,109,81,197,60,229,43,114,54,43,129,178,216,237,18,113,40,191,95,50,66,153,204,19,134,231,194,215,36,223,82,73,86,138,49,17,176,23,32,129,229,146,172,241,96,8,53,39,179,175,54,138,75,150,103,14,207,143,175,147,60,193,99,205,5,170,244,73,1,42,51,223,101,160,0,251,226,46,163,43,187,73,83,120,242,146,188,193,211,201,15,138,13,121,210,186,212,10,115,45,105,142,74,191,23,244,33,201,193,172,239,205,23,178,82,235,68,230,66,217,207,112,214,204,208,174,191,192,97,81,172,215,244,79,50,37,99,127,105,124,110,119,1,150,154,141,2,187,138,66,29,144,218,88,75,111,48,154,246,212,128,57,186,77,14,210,183,234,97,15,136,9,40,162,128,245,116,220,212,122,124,54,139,43,134,174,53,75,99,53,9,162,9,121,34,207,255,152,20,26,162,15,158,48,68,158,142,141,47,44,64,74,180,208,117,58,158,217,176,149,6,66,104,138,126,67,215,20,68,124,113,166,9,123,181,121,91,208,148,52,120,78,200,116,102,49,43,24,30,94,3,203,158,93,23,227,150,123,73,94,136,21,76,148,103,141,70,163,91,206,243,197,106,11,187,228,119,205,220,172,198,30,248,92,99,222,240,220,240,130,244,150,63,202,57,199,28,82,19,132,86,13,93,15,81,7,197,123,193,87,168,93,144,164,189,102,104,150,60,79,178,0,190,15,55,184,243,109,193,238,23,244,43,212,104,21,200,149,217,53,186,39,177,107,123,196,190,44,242,45,23,46,90,9,113,215,151,152,112,255,195,25,52,177,74,184,149,141,103,197,142,73,71,50,3,112,229,250,237,238,191,152,245,155,66,25,168,229,146,176,223,37,248,65,174,210,103,178,113,117,238,70,50,92,84,49,186,65,183,169,73,74,136,89,255,23,86,7,16,86,192,15,73,86,128,35,119,96,209,213,97,153,108,100,83,3,5,243,236,159,123,242,58,64,23,107,174,130,59,203,116,9,91,242,123,96,77,138,22,130,166,126,238,79,121,87,20,178,116,72,178,187,202,146,13,89,115,129,129,207,82,194,56,198,252,161,35,135,232,194,240,43,236,238,64,68,214,174,227,27,128,116,129,148,55,154,112,60,249,228,196,242,29,231,25,241,17,206,123,36,81,49,75,164,14,90,82,48,250,165,0,55,9,13,23,73,184,177,239,75,164,179,84,51,55,116,10,132,34,219,100,5,41,17,24,131,88,158,48,8,79,16,133,5,178,138,47,81,65,49,218,59,146,79,167,96,215,223,37,20,29,32,209,73,226,84,57,237,184,60,238,30,193,84,216,185,137,78,132,223,166,112,238,229,208,128,182,173,36,123,196,242,100,165,210,45,145,152,111,79,16,99,85,230,104,95,2,37,128,155,190,143,237,29,40,208,189,182,214,62,223,44,8,166,120,110,32,215,37,218,230,121,89,126,69,105,31,84,198,115,19,205,199,27,206,202,62,16,210,86,80,105,13,250,195,9,249,98,11,131,29,94,142,125,37,121,220,114,236,243,18,237,198,198,35,219,90,196,93,166,76,108,125,10,68,183,83,186,186,125,9,75,22,249,170,106,89,175,64,47,8,195,228,165,147,99,99,110,192,67,112,6,143,225,46,144,120,21,243,154,173,185,175,129,109,124,47,91,104,71,26,92,157,237,59,90,234,235,102,7,117,11,123,46,41,22,202,3,249,76,59,215,2,59,142,70,238,158,24,190,123,16,170,232,170,141,121,142,197,27,210,110,95,41,165,153,39,152,122,245,40,68,62,175,170,207,125,167,165,41,208,52,106,134,234,240,244,114,123,143,189,243,17,189,218,217,140,188,122,69,34,247,251,148,232,255,99,77,241,81,255,125,7,15,144,197,151,251,61,30,139,62,228,79,147,35,103,224,217,195,86,93,99,177,30,115,232,18,249,25,108,247,50,223,38,108,3,253,65,100,146,64,73,209,149,126,186,119,124,71,101,126,225,52,77,135,89,189,191,223,138,7,48,203,54,203,201,31,230,211,136,174,209,164,37,31,242,211,148,176,34,203,202,38,125,52,18,144,23,130,121,59,41,240,179,249,207,186,61,109,206,123,170,19,210,75,234,150,1,143,33,106,164,177,23,93,35,226,196,242,175,37,154,58,238,16,191,133,92,119,116,23,109,21,103,81,75,138,22,51,123,76,200,19,135,74,219,203,117,104,248,92,37,214,167,182,68,117,142,61,194,252,217,201,195,189,101,201,116,171,167,212,36,67,225,103,161,235,55,172,216,129,80,211,190,53,142,105,131,103,164,236,238,159,8,30,253,57,102,65,252,51,64,46,174,91,251,206,224,181,153,193,157,13,108,98,170,102,130,254,94,198,160,53,148,112,217,121,95,188,218,231,109,100,18,131,7,65,71,134,71,143,62,154,76,206,91,167,218,160,113,79,182,57,161,54,112,77,164,216,48,121,165,107,88,252,102,183,207,15,22,244,210,39,136,171,121,214,117,138,224,209,118,143,71,129,54,189,111,226,26,122,218,106,186,210,183,11,39,56,224,218,78,100,193,58,88,13,112,67,37,48,67,91,25,7,230,24,78,9,135,109,123,232,27,22,26,26,119,70,66,19,229,80,217,113,122,212,198,59,69,94,90,205,157,190,152,78,94,195,197,242,18,70,207,172,1,113,44,81,125,119,171,103,84,169,84,37,14,160,135,84,119,94,53,189,237,236,85,159,105,72,202,24,63,110,132,97,157,89,111,195,235,246,77,141,86,170,93,183,108,218,182,101,230,90,222,96,48,254,38,116,0,70,237,54,108,66,94,217,176,76,97,157,20,89,30,249,171,47,137,234,14,177,88,61,96,39,16,191,134,178,77,4,19,188,23,46,246,44,196,191,163,106,168,234,170,157,89,85,214,224,214,117,169,109,115,69,79,113,197,90,248,66,25,198,101,145,123,38,144,73,232,103,166,18,150,87,192,203,84,116,180,221,105,223,117,216,228,22,190,227,232,105,9,21,122,117,159,109,220,173,215,41,218,59,119,221,190,132,202,67,88,188,114,96,234,66,106,142,81,182,127,238,232,31,127,5,52,117,218,188,24,15,170,191,72,30,212,197,240,160,86,176,52,253,3,199,16,85,132,126,142,143,74,199,81,46,246,83,179,11,153,248,97,226,121,231,255,168,103,243,27,201,105,163,145,116,154,184,91,216,241,7,232,110,215,218,34,215,196,31,91,84,159,84,101,246,122,183,234,192,134,12,82,216,81,118,175,70,88,89,177,40,48,102,222,186,72,225,125,45,117,43,27,200,238,145,12,219,19,163,90,212,135,52,53,175,74,230,61,234,160,122,221,139,30,201,103,145,234,111,156,7,146,75,177,193,10,199,242,104,236,139,57,126,209,148,219,246,65,71,46,34,107,183,118,110,34,221,206,67,153,78,122,193,8,233,48,139,249,208,120,190,133,213,125,41,190,202,227,145,42,167,124,29,53,229,62,119,237,221,145,6,176,20,184,176,91,248,130,181,92,21,160,191,254,210,212,100,212,127,228,141,61,99,71,75,27,10,134,61,234,218,8,16,207,170,199,195,223,127,204,235,78,128,85,252,87,17,239,132,67,67,132,120,201,23,58,134,163,137,138,11,245,162,104,108,22,202,31,71,197,189,197,50,88,190,64,166,216,195,12,144,83,147,168,126,66,245,60,149,192,206,125,126,93,130,222,212,243,84,13,172,95,33,106,88,248,182,191,90,239,53,184,146,255,88,158,117,205,12,181,125,2,83,116,201,169,212,203,81,193,159,30,91,143,66,145,186,174,156,84,146,212,111,66,253,246,87,142,174,174,77,203,215,118,213,92,221,99,170,182,125,114,88,33,13,49,65,34,103,23,103,229,167,65,115,34,122,59,230,84,107,235,168,145,225,44,56,254,99,11,2,34,35,131,42,163,230,147,234,154,114,202,18,243,171,128,75,118,136,210,26,160,208,156,175,24,164,42,225,79,208,95,149,153,7,249,98,200,22,25,231,247,197,254,200,248,60,68,233,119,154,209,48,189,181,202,1,109,181,142,241,21,101,169,33,88,30,246,128,67,31,114,195,98,168,226,65,251,174,130,198,102,59,15,134,152,147,227,102,120,173,18,198,142,50,244,185,199,45,38,104,156,153,146,118,66,49,13,56,69,115,37,236,48,204,72,158,211,44,133,122,194,81,191,72,8,252,244,160,143,249,57,225,74,166,71,42,225,5,89,39,216,144,198,65,7,212,245,3,141,214,107,246,246,177,104,59,31,55,146,121,128,71,153,246,7,229,36,229,59,252,55,71,75,243,33,123,158,97,75,29,233,71,242,250,142,193,121,249,86,105,183,188,116,108,100,151,106,192,50,239,238,235,246,228,165,217,134,38,178,105,8,59,124,181,105,140,211,0,6,127,186,130,147,165,94,252,166,159,142,168,193,247,201,109,25,6,191,93,42,202,239,121,41,212,221,121,224,13,225,131,237,218,143,206,234,39,236,149,82,185,207,146,195,135,246,150,182,147,126,237,32,28,219,91,253,14,228,148,7,48,68,15,221,142,33,43,149,51,136,250,19,186,239,63,201,1,20,147,239,114,2,45,202,183,59,130,254,109,204,255,205,27,244,238,255,128,75,28,57,31,13,113,255,253,13,241,96,207,182,179,39,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04eff58a-422b-45e2-b3de-4a80f0b72fbd"));
		}

		#endregion

	}

	#endregion

}


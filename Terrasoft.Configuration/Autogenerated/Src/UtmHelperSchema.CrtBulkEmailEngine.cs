﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UtmHelperSchema

	/// <exclude/>
	public class UtmHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UtmHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UtmHelperSchema(UtmHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3e02aad0-4fd4-4d2f-85a6-43398aa0ca6e");
			Name = "UtmHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bc5da875-f48b-48a1-a687-7137717191f8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,26,105,111,27,185,245,179,2,236,127,96,198,11,123,38,150,199,78,11,20,104,108,201,112,28,111,106,108,14,175,143,22,168,172,24,99,137,150,7,153,67,33,57,78,92,71,255,189,143,55,57,135,36,47,218,69,144,104,200,119,241,221,143,220,34,201,49,157,39,19,140,46,49,33,9,45,239,88,124,92,22,119,233,172,34,9,75,203,34,254,152,20,83,146,102,217,5,38,15,233,4,255,242,226,233,151,23,189,138,166,197,12,93,60,82,134,243,253,218,55,224,103,25,158,112,100,26,191,199,5,38,233,164,1,243,33,45,190,53,22,47,241,15,22,159,227,89,149,37,228,228,199,156,96,74,57,17,128,3,200,13,130,103,240,133,142,179,132,210,55,232,138,229,239,18,150,136,173,121,117,155,165,19,52,225,59,118,163,199,5,213,123,183,101,153,161,43,138,97,23,61,161,25,102,251,136,242,191,22,14,12,101,132,11,243,174,204,147,180,160,171,192,128,210,69,89,17,208,220,106,192,143,120,154,86,43,25,3,224,113,146,207,147,116,86,172,1,10,246,90,139,98,89,48,92,176,85,144,151,56,159,103,9,195,199,229,180,121,160,133,171,101,202,192,47,180,178,129,250,3,38,12,79,219,181,174,96,213,166,134,190,44,213,66,200,238,83,138,222,86,217,215,19,80,121,134,110,245,175,190,22,139,57,98,69,72,144,238,17,204,42,82,160,2,127,55,132,229,70,79,217,119,96,9,197,114,169,47,247,181,101,93,0,181,166,32,172,81,61,34,122,213,66,41,139,214,160,228,170,133,50,230,172,193,233,117,11,41,172,89,131,226,107,14,45,101,200,58,41,185,172,224,60,51,14,60,245,9,128,5,143,185,158,181,233,6,134,224,22,113,213,17,99,255,192,217,28,19,177,185,187,187,139,14,104,149,231,9,121,28,170,111,1,136,238,74,130,190,151,228,43,250,158,178,123,142,133,88,50,163,177,198,217,117,144,234,161,170,233,115,183,225,162,25,9,32,238,89,82,48,144,226,140,164,15,112,6,185,63,225,235,218,59,206,18,198,48,41,32,151,124,133,195,6,225,65,50,250,50,28,191,58,28,125,217,25,223,19,124,119,125,77,95,13,70,215,193,245,214,56,10,15,15,50,128,27,142,190,136,239,237,40,212,27,28,103,59,58,28,6,251,221,44,206,18,194,146,252,84,177,18,170,12,128,34,136,72,216,80,179,229,236,106,108,37,183,235,235,195,13,206,241,240,224,91,133,201,227,141,164,61,132,101,185,207,55,15,97,247,142,36,179,28,140,121,147,78,135,27,70,80,190,3,102,26,10,57,135,209,50,49,165,51,27,1,71,95,222,140,183,223,236,238,10,18,83,177,55,28,37,59,255,57,218,249,247,222,206,223,199,246,231,206,205,248,233,117,255,111,175,23,238,82,60,126,218,235,47,162,16,208,151,241,4,35,126,72,110,113,198,45,48,58,220,28,135,21,203,111,168,8,151,159,252,231,68,249,186,248,200,69,128,136,159,128,43,127,76,164,7,71,3,205,165,230,148,173,62,33,220,72,110,107,151,106,151,77,4,202,233,212,136,200,131,231,6,243,197,27,146,78,87,242,252,136,217,125,57,173,123,97,61,20,100,44,16,12,0,20,73,69,163,44,165,44,54,192,187,117,232,131,121,66,146,28,21,80,127,7,129,68,161,193,240,66,138,47,226,72,45,134,83,156,165,121,10,57,86,46,111,245,183,16,196,219,214,254,86,116,176,43,136,88,154,50,53,210,225,7,224,141,202,59,77,226,96,87,111,8,125,145,146,65,121,6,122,42,61,115,232,3,229,147,232,61,102,210,139,248,106,168,212,169,232,232,12,252,144,16,52,151,26,6,149,74,152,248,183,146,228,9,11,131,47,79,123,139,95,131,190,239,146,209,190,65,132,170,94,101,60,141,133,119,164,204,181,182,224,143,98,18,95,204,179,148,133,144,222,71,99,168,68,112,220,62,63,44,90,68,50,197,245,122,8,42,19,111,48,16,180,10,248,7,52,40,108,114,143,65,79,2,63,190,36,105,30,70,125,45,96,95,66,125,158,203,126,228,116,86,148,4,31,39,20,27,114,64,47,45,88,137,114,78,71,138,107,57,125,191,199,4,187,91,208,221,84,60,11,15,208,235,134,60,14,216,104,111,28,191,39,101,53,167,35,101,221,96,28,255,51,201,42,28,197,151,165,208,173,210,137,42,103,82,45,58,61,119,58,217,185,52,36,18,134,7,119,35,218,227,121,14,174,72,38,125,4,194,106,71,167,224,181,252,15,138,104,48,20,165,84,227,139,20,222,233,96,174,159,10,16,12,162,80,45,196,10,127,83,18,131,167,65,124,158,113,108,73,46,212,229,156,139,163,125,77,1,87,10,178,233,111,54,221,12,192,243,54,109,150,25,60,189,150,159,58,3,13,158,254,178,8,84,161,228,44,26,117,93,47,122,101,92,47,234,154,173,204,150,222,133,47,149,36,167,244,83,149,101,159,201,73,62,103,143,161,134,231,213,59,210,167,232,25,249,183,33,7,109,234,252,55,8,208,54,114,17,36,237,197,122,28,84,233,95,198,68,229,86,143,143,66,115,89,41,31,212,248,255,35,47,44,33,47,207,18,86,146,71,227,80,235,58,164,105,113,206,79,167,193,208,118,136,240,249,255,246,201,183,14,107,215,57,33,71,32,87,172,110,7,237,40,62,219,30,58,100,1,69,216,207,3,107,219,96,195,249,15,213,254,65,222,186,1,21,121,65,252,122,118,97,242,24,108,52,108,224,226,184,77,103,29,113,57,166,62,187,198,218,113,79,104,133,95,69,165,160,213,45,157,144,244,22,127,76,38,164,164,71,89,10,249,222,28,194,17,7,213,23,172,58,58,221,236,185,170,94,225,120,239,82,49,41,3,75,85,130,245,236,35,74,49,239,55,41,100,186,115,12,42,157,224,208,43,213,202,56,173,195,82,95,78,188,149,28,127,80,205,73,85,106,83,171,4,127,171,82,34,102,56,185,139,78,79,138,42,199,36,185,205,176,225,214,165,86,183,41,184,127,132,102,158,183,217,124,198,226,3,90,247,233,180,219,67,120,226,100,114,31,138,42,46,43,168,104,178,161,33,240,203,187,127,58,167,245,239,174,240,38,49,114,217,50,57,37,24,14,166,60,243,13,93,156,165,76,61,47,188,212,207,126,205,214,250,47,107,105,137,43,244,158,82,30,253,63,120,27,54,168,157,35,19,34,215,154,231,238,51,168,126,99,136,246,208,207,159,232,165,52,232,190,199,202,100,172,211,233,122,44,221,180,180,46,231,214,74,84,247,156,200,23,236,202,186,140,112,22,16,140,139,194,47,152,152,104,109,131,87,63,175,62,93,92,189,125,19,104,76,237,14,202,53,19,129,6,190,176,202,251,68,185,244,137,11,92,235,3,0,209,38,16,35,198,234,32,55,48,255,170,191,100,105,212,255,0,249,22,124,80,76,232,216,122,115,179,197,28,142,8,188,28,167,133,97,168,210,187,231,111,245,196,226,40,84,198,187,52,234,212,23,157,59,184,211,125,46,247,0,9,211,109,248,125,115,226,176,181,241,221,139,224,220,234,68,225,75,221,182,31,21,143,170,5,71,131,225,122,173,112,124,242,173,74,50,221,185,247,145,44,136,199,37,52,90,36,165,101,17,127,38,211,180,72,50,55,164,29,109,214,245,113,7,180,150,169,214,13,101,245,129,54,156,156,109,149,238,44,27,93,216,220,102,92,236,119,252,24,218,124,98,11,250,26,22,55,6,227,168,239,48,144,203,104,195,106,109,180,251,109,87,18,235,216,178,206,205,25,100,172,184,75,251,10,171,14,93,57,196,117,134,234,187,6,141,243,184,134,119,47,62,106,201,86,52,186,45,97,99,3,247,180,160,152,176,63,44,51,72,60,119,46,243,126,163,134,69,181,40,86,76,220,72,245,220,231,121,220,170,46,46,173,250,171,135,180,219,201,248,250,148,67,160,186,207,170,205,57,48,220,28,194,68,3,51,204,211,95,205,24,211,235,45,83,186,184,158,210,218,54,24,238,73,214,161,226,220,74,53,104,45,195,195,133,129,55,122,114,130,232,104,58,237,112,112,171,133,200,134,77,125,86,177,148,214,239,148,77,253,190,210,6,64,45,46,142,174,206,63,172,219,31,59,186,108,180,186,146,210,179,26,94,191,111,92,130,56,45,63,149,236,148,251,169,68,117,189,206,59,111,103,199,222,218,206,54,251,236,165,189,235,67,153,78,81,123,184,52,19,68,163,9,213,33,215,57,231,58,200,54,163,250,41,167,25,35,155,16,35,38,58,106,253,174,139,28,95,240,224,160,255,130,105,49,12,14,131,8,29,34,111,23,234,188,60,205,235,190,183,241,1,23,51,24,48,119,120,214,124,227,238,40,95,93,32,12,85,168,93,90,111,182,147,238,188,88,247,250,209,185,240,108,117,242,163,249,28,104,80,49,105,59,211,47,43,17,187,199,72,92,120,154,1,225,121,215,66,234,65,132,127,240,59,69,159,65,188,212,77,253,49,30,254,226,4,184,60,38,217,255,201,73,206,62,49,106,138,137,220,18,18,90,52,168,73,28,175,41,165,246,235,19,79,49,246,246,203,59,161,23,4,222,203,150,189,54,112,95,94,184,83,233,206,222,187,212,234,163,250,45,130,242,204,63,51,112,121,53,163,246,240,35,238,122,220,53,233,114,109,227,35,64,251,119,190,2,87,61,139,41,167,110,222,113,52,47,239,196,165,221,190,47,153,95,147,37,90,215,253,138,119,183,34,233,44,153,141,189,73,179,101,80,54,179,113,67,19,106,201,123,24,52,121,162,101,22,238,52,131,119,109,227,22,182,217,12,162,23,184,133,77,211,40,126,225,164,34,132,191,218,89,188,136,119,205,106,57,214,167,48,187,49,180,154,14,176,170,170,145,45,125,75,174,234,242,242,1,55,242,130,184,123,175,72,182,110,42,0,208,96,120,5,240,157,145,36,55,87,134,138,148,7,212,251,27,72,112,69,82,61,233,1,3,237,216,176,10,159,169,189,103,133,133,248,146,60,202,7,150,16,32,251,8,150,126,79,139,105,124,116,75,203,172,98,96,213,178,98,28,203,86,10,125,161,70,50,247,170,211,45,76,60,37,3,105,81,187,12,183,139,206,82,180,138,244,228,30,154,122,202,95,47,248,141,232,0,109,109,110,237,55,120,94,200,231,96,241,219,169,50,123,125,40,40,46,244,104,44,97,206,172,205,6,78,77,113,11,84,100,159,76,16,151,65,188,155,24,57,22,122,174,18,64,122,68,144,102,16,135,59,41,96,27,215,66,29,106,253,4,83,138,167,127,40,69,169,74,43,48,252,155,27,247,116,70,90,62,179,215,228,55,218,3,37,251,91,110,45,110,191,165,224,19,39,234,70,114,31,1,2,103,58,237,173,64,49,47,3,193,58,12,228,141,253,115,200,235,219,247,117,168,171,71,139,96,233,240,168,39,153,86,39,245,109,230,208,169,25,115,123,96,188,195,167,220,132,243,101,174,191,78,60,75,138,134,71,217,112,216,174,185,91,219,211,4,196,233,103,146,206,248,117,128,98,171,147,164,160,211,175,145,136,220,169,160,214,93,53,255,215,7,177,242,226,197,127,1,94,65,10,51,13,37,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e02aad0-4fd4-4d2f-85a6-43398aa0ca6e"));
		}

		#endregion

	}

	#endregion

}


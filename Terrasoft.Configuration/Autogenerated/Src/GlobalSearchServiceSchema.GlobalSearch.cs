﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchServiceSchema

	/// <exclude/>
	public class GlobalSearchServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchServiceSchema(GlobalSearchServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5a3357c6-df2f-45c6-8cb3-943cc980aa69");
			Name = "GlobalSearchService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6f142301-7a5f-41f6-815b-40f61aa5d442");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,90,221,115,219,54,18,127,86,103,250,63,160,234,76,75,77,84,58,237,189,217,150,114,138,63,18,229,18,219,39,41,231,135,204,141,135,18,33,153,13,69,50,0,233,88,151,250,127,191,93,124,144,0,9,210,114,238,210,185,185,60,196,34,176,0,246,11,187,191,93,50,9,182,148,103,193,138,146,5,101,44,224,233,58,247,79,210,100,29,109,10,22,228,81,154,248,175,226,116,25,196,115,26,176,213,237,247,223,125,249,254,187,94,193,163,100,67,230,59,158,211,237,81,237,25,22,199,49,93,225,74,238,191,162,9,101,209,170,65,243,54,74,62,53,6,231,148,221,69,43,250,46,13,105,220,57,233,79,96,251,59,193,92,55,221,53,93,54,8,22,183,140,6,33,12,180,207,248,139,128,127,228,141,121,216,13,182,231,28,142,157,231,65,78,43,130,147,148,81,255,60,88,229,41,139,168,177,112,35,52,119,120,120,146,110,183,160,200,183,233,102,99,29,124,65,63,231,160,38,84,249,27,110,10,51,163,60,159,223,6,44,171,134,76,235,224,110,238,153,54,187,157,230,233,211,22,188,166,113,70,153,123,13,51,68,71,165,180,51,100,238,232,154,191,40,34,219,98,167,65,30,0,83,57,3,101,186,22,188,75,147,8,181,108,106,209,125,220,35,164,151,147,34,191,157,38,57,221,176,154,35,85,52,149,108,154,201,89,90,228,45,27,34,241,235,60,207,252,201,146,11,246,241,2,84,132,103,140,165,108,154,172,83,50,170,233,210,82,128,150,221,47,233,97,11,216,228,71,70,55,176,33,57,137,3,206,15,137,41,168,90,46,200,14,14,14,200,49,47,182,219,128,237,198,234,89,210,18,46,136,225,143,160,38,25,75,239,119,190,94,114,96,172,249,160,54,212,172,252,19,199,78,233,58,40,226,220,80,3,21,227,115,158,53,198,38,60,187,160,57,40,46,3,205,46,163,56,202,119,51,250,169,136,24,221,210,36,231,158,249,128,66,131,70,30,89,130,84,190,26,8,7,120,72,86,44,227,104,69,86,168,14,151,54,200,33,121,25,112,170,158,134,100,58,131,171,125,153,196,59,243,2,195,62,95,132,218,42,245,130,205,242,0,78,60,36,87,12,67,140,84,107,47,147,15,100,133,243,4,236,43,194,130,178,91,196,87,234,26,209,80,152,237,68,10,213,119,17,244,143,212,137,52,9,229,161,54,7,231,17,141,195,182,227,167,239,40,28,189,154,209,44,101,57,101,228,102,107,63,143,164,127,200,72,180,131,232,155,31,215,150,140,189,193,145,181,35,70,154,147,56,2,45,147,27,86,254,182,104,154,97,129,220,108,156,161,162,92,2,74,204,193,60,24,79,83,80,58,153,66,232,35,55,49,252,55,34,240,243,93,144,4,27,202,144,65,140,137,148,121,125,243,144,254,224,17,37,93,177,20,78,204,33,214,182,40,202,193,178,245,128,73,172,215,219,208,92,253,234,69,107,226,57,132,34,163,17,73,138,56,30,104,186,158,147,168,169,246,38,3,99,47,161,159,165,131,177,2,9,39,108,83,160,119,123,253,2,46,37,76,36,50,107,246,135,234,168,222,123,107,124,32,45,215,235,61,200,63,140,230,5,75,90,77,33,201,30,108,189,148,158,107,92,149,247,44,110,234,67,109,238,201,5,3,17,167,236,100,1,73,113,78,115,140,134,152,230,243,127,4,113,65,61,155,227,33,177,204,10,7,245,7,237,188,69,224,130,120,199,193,9,23,209,150,66,56,105,103,11,104,7,228,171,153,194,36,163,132,255,123,65,217,78,29,215,197,156,121,79,140,159,110,63,170,238,145,246,31,242,211,79,228,7,203,73,22,108,7,12,218,126,175,35,105,185,188,63,36,168,6,99,195,129,225,137,230,49,4,157,203,100,140,104,29,142,234,74,125,112,187,81,237,242,187,181,48,13,97,30,130,179,226,244,154,5,153,8,7,145,115,252,104,191,213,45,195,163,177,224,163,101,111,242,226,5,104,186,101,110,164,2,192,36,203,74,119,56,167,1,8,74,223,99,82,200,2,240,23,170,167,206,83,38,208,192,111,207,165,70,94,56,162,168,155,199,177,215,63,187,135,168,154,192,81,171,21,100,150,254,64,110,113,248,132,45,6,79,139,118,105,14,126,76,67,73,82,207,247,142,132,191,146,158,159,50,114,43,163,85,36,82,28,164,200,99,78,33,163,49,186,30,89,94,120,162,23,200,96,210,63,24,251,229,81,38,78,112,6,219,218,98,59,58,213,38,85,198,80,2,145,187,136,229,5,240,221,181,93,215,156,246,151,142,19,165,211,116,17,140,164,253,58,227,121,109,205,19,2,59,169,71,116,109,250,61,236,120,75,131,56,7,115,222,210,213,199,22,43,78,107,92,86,129,241,181,88,124,34,215,62,110,209,61,55,106,88,183,133,174,197,208,251,158,178,39,89,139,253,219,200,93,174,208,186,117,139,87,236,41,129,113,199,157,134,54,76,40,65,171,74,6,81,16,71,255,18,246,42,205,253,136,225,92,203,201,205,239,80,91,86,207,53,107,56,151,188,177,86,128,106,137,212,173,189,147,212,97,109,76,166,34,215,174,143,104,225,4,229,139,99,161,62,146,167,31,105,226,116,114,147,108,129,84,93,238,92,119,185,198,98,199,136,51,167,99,101,135,5,17,189,135,162,173,96,12,115,236,15,85,110,119,76,67,189,194,51,8,10,84,211,85,153,91,165,220,174,69,190,76,197,167,162,116,72,132,16,130,59,103,238,110,200,224,95,164,9,109,166,241,182,4,3,37,194,109,218,40,58,156,70,58,143,98,200,119,156,100,112,19,64,175,249,46,163,156,44,119,36,16,233,143,176,104,115,155,115,146,174,201,74,41,9,67,96,139,121,196,8,166,226,45,73,130,45,29,245,113,183,254,24,43,238,224,23,174,146,116,72,100,214,36,28,34,223,54,16,148,220,63,62,16,235,170,109,164,38,248,62,139,201,90,200,0,147,192,183,201,166,45,4,156,161,55,117,32,104,169,135,5,48,252,114,39,83,255,76,172,82,128,89,40,70,27,252,46,96,16,196,101,67,0,174,7,78,73,243,249,243,12,42,93,239,231,225,207,10,54,248,215,183,192,88,13,176,250,167,47,231,20,248,4,57,206,146,77,148,80,12,61,83,126,38,193,132,16,108,38,251,86,147,56,78,63,67,129,44,45,175,156,67,50,228,191,73,163,196,235,15,33,7,105,86,36,89,13,225,33,132,84,120,17,188,1,213,72,213,163,55,149,247,89,61,10,224,172,114,147,57,52,36,45,26,192,231,185,156,26,105,166,166,252,2,46,198,37,59,219,102,249,206,147,43,94,72,85,40,10,49,67,14,173,49,192,107,219,0,178,235,193,151,231,15,32,79,171,41,196,126,40,229,143,112,131,47,206,22,243,197,228,226,116,50,59,253,237,70,2,189,10,46,251,24,174,176,14,146,193,235,61,139,188,185,125,22,28,245,229,215,135,131,27,41,240,11,249,231,6,79,24,133,107,126,243,9,69,191,201,111,105,114,179,166,57,84,176,170,134,171,23,90,67,67,13,146,53,26,115,218,206,205,159,192,133,96,34,9,163,181,160,85,198,131,168,147,209,18,70,203,245,2,35,207,113,66,212,86,226,23,48,166,34,23,250,108,205,113,149,31,162,241,153,114,169,170,78,209,78,166,98,162,12,65,48,47,127,248,175,206,22,138,121,69,40,85,0,4,88,188,201,7,209,51,85,84,245,132,85,203,96,50,20,250,215,81,46,197,176,240,156,170,12,184,15,236,139,217,177,231,198,234,67,169,151,1,9,184,41,67,229,97,231,179,201,187,179,235,203,217,223,212,5,20,211,254,36,12,95,166,225,206,107,94,22,219,3,12,122,228,190,115,77,105,48,76,78,39,140,98,236,215,37,206,34,221,108,98,225,54,90,48,17,48,32,151,4,203,152,134,143,201,94,149,152,29,160,215,135,210,10,152,128,147,133,166,130,152,123,138,125,179,136,214,49,136,149,138,106,4,28,244,245,50,83,2,159,162,129,166,7,188,169,84,179,154,102,234,199,208,232,166,82,163,175,106,102,89,244,186,72,14,87,36,128,87,208,255,170,213,165,247,113,30,108,208,225,245,17,178,255,170,198,149,143,153,189,189,146,78,51,135,13,197,130,251,139,84,94,43,79,70,116,85,107,191,204,182,58,120,42,81,184,253,168,64,83,131,76,241,55,47,100,102,26,145,53,104,218,226,71,137,142,162,154,39,202,75,39,119,65,103,82,55,2,172,120,7,165,164,95,222,140,203,229,239,96,85,79,147,42,227,97,167,78,106,192,179,99,238,95,251,182,188,135,4,66,146,110,87,153,42,131,137,95,203,9,1,114,146,28,198,126,123,24,18,61,170,119,130,225,191,96,28,71,17,252,82,199,234,89,91,160,82,184,218,108,104,137,55,168,229,60,75,139,46,183,187,75,163,144,204,105,233,91,23,0,194,206,89,186,245,154,54,88,214,71,192,253,230,53,26,202,107,36,130,155,189,18,166,233,176,80,95,228,23,20,174,84,248,58,202,167,24,14,27,135,139,55,36,254,91,32,244,6,254,52,60,178,214,78,147,144,222,163,24,103,248,132,93,95,92,4,248,89,21,48,117,54,253,242,177,136,115,31,206,68,7,126,27,225,222,202,74,254,121,148,132,98,91,239,30,203,0,157,150,63,21,120,229,239,129,131,97,157,235,161,202,90,162,155,207,34,176,142,63,77,128,195,40,72,242,19,56,7,194,205,116,147,164,140,158,192,213,215,134,107,202,169,45,130,104,161,161,52,95,204,60,235,22,250,25,249,213,101,250,101,154,198,24,105,144,229,183,105,16,206,232,42,101,33,199,158,34,248,20,254,62,73,11,116,176,61,92,65,27,15,215,6,119,65,20,99,132,157,85,155,184,44,88,246,4,95,144,231,228,176,205,194,98,185,229,212,206,253,143,77,150,91,165,125,29,240,137,94,93,106,73,74,189,39,168,67,1,243,52,15,226,115,56,40,52,56,208,26,168,221,60,99,59,45,238,31,127,116,24,210,49,51,135,240,4,242,57,79,221,199,174,232,64,87,16,59,246,187,210,255,169,30,228,20,107,85,140,195,225,44,103,115,184,22,214,149,237,134,115,113,231,182,144,75,89,118,98,61,187,135,2,35,167,87,105,137,105,60,19,163,233,204,174,36,194,183,227,199,214,6,99,146,195,152,202,192,210,105,115,80,160,202,94,106,206,0,184,198,121,184,217,132,239,146,149,198,15,195,102,57,171,95,124,224,70,254,117,0,37,147,6,25,100,21,0,206,37,222,217,253,138,102,162,113,64,239,75,248,98,100,49,24,61,210,112,82,189,89,175,101,110,241,202,170,224,71,85,201,79,239,73,196,117,27,189,60,160,170,226,229,2,37,152,107,75,31,215,134,151,133,186,198,192,144,253,186,206,151,63,188,18,146,200,87,117,228,139,114,70,19,111,152,80,172,28,247,203,150,126,249,106,136,32,154,36,21,251,151,128,213,132,34,165,82,105,88,105,10,238,163,39,76,99,244,49,132,134,167,92,19,15,158,34,237,100,137,82,133,223,76,88,181,127,67,216,253,57,20,123,125,51,254,212,253,20,3,6,147,149,219,53,112,172,85,14,217,136,175,87,243,206,145,242,79,253,110,208,196,90,8,113,239,17,227,67,253,175,134,184,78,224,250,101,79,9,196,13,72,100,99,116,97,122,137,4,92,1,67,189,209,85,245,33,28,102,189,213,174,222,92,73,220,174,203,72,57,12,56,171,200,174,88,10,65,108,203,181,75,125,123,76,236,132,250,6,214,119,113,103,233,87,153,187,243,61,191,105,229,7,43,95,119,225,109,91,84,43,66,63,222,164,19,159,62,116,244,232,102,69,162,190,60,82,42,221,183,255,38,250,7,18,188,245,199,42,7,74,188,215,232,183,153,203,84,67,73,54,164,46,96,168,63,214,45,82,53,165,219,112,72,223,189,151,145,19,177,19,136,16,39,93,195,54,177,236,227,202,105,71,255,175,217,70,196,134,144,106,245,117,147,175,1,129,244,199,231,17,227,58,127,67,42,7,72,73,214,41,211,10,108,237,55,106,195,98,130,182,250,248,117,183,181,154,248,118,107,241,67,21,164,141,79,110,122,31,174,233,18,128,51,36,64,175,236,142,244,175,46,231,11,168,149,234,77,17,32,85,126,109,182,70,8,182,16,230,249,46,166,22,73,57,234,203,190,70,56,212,13,40,193,105,247,166,226,235,27,253,249,141,245,57,129,190,244,134,23,149,205,192,134,139,52,224,146,213,55,68,73,251,146,100,45,75,128,231,38,210,206,128,165,139,66,12,31,149,131,78,236,3,36,191,200,34,96,191,98,204,130,48,123,224,70,139,190,35,232,233,2,108,191,247,69,24,203,177,122,138,32,5,91,84,122,59,119,163,13,179,190,235,112,108,179,166,185,236,180,94,223,70,57,157,227,231,158,70,159,167,130,168,221,65,221,21,205,205,76,242,249,22,56,38,158,11,131,59,16,247,222,0,118,104,193,234,146,107,167,245,204,207,96,68,151,82,182,62,97,57,53,41,61,219,73,155,222,105,121,166,242,183,161,112,70,157,216,237,182,102,173,87,238,148,13,219,209,106,177,187,175,5,251,56,144,184,221,87,19,86,110,233,62,33,146,107,5,63,232,80,49,133,32,90,97,58,20,129,218,64,162,209,129,171,117,134,172,236,86,245,87,171,4,231,153,27,214,64,208,163,109,19,235,58,245,218,155,124,186,30,168,106,140,70,107,163,214,240,58,165,220,78,193,199,117,102,198,149,86,85,139,169,194,153,170,202,192,13,141,74,99,208,117,184,0,31,117,121,53,125,25,140,16,109,41,153,212,148,6,108,61,250,40,146,113,181,45,117,119,204,234,201,41,28,67,117,55,173,118,212,131,81,243,116,53,136,28,31,195,253,57,24,250,81,159,107,245,218,225,30,205,95,83,143,125,201,16,234,19,5,134,2,138,226,11,168,190,83,159,125,241,114,74,234,166,175,117,90,255,74,175,67,69,242,172,82,71,167,42,200,163,165,234,102,88,164,233,199,74,31,120,111,51,150,34,252,5,36,202,13,175,179,194,223,149,36,57,171,109,214,48,114,89,94,183,100,80,199,81,192,16,208,26,17,169,181,203,85,57,139,43,121,58,182,118,23,119,45,93,178,73,24,206,130,4,242,139,139,71,164,24,52,125,188,171,225,70,198,35,87,15,167,237,252,246,6,237,34,248,72,205,6,207,160,108,172,106,159,118,53,159,29,89,178,209,89,118,181,144,109,33,85,186,122,246,204,81,229,181,94,161,102,255,201,44,74,220,223,39,209,156,4,155,13,212,39,129,124,183,189,220,73,240,247,191,93,110,56,161,123,12,182,193,74,195,5,225,39,149,140,255,95,40,254,131,228,255,144,40,130,43,84,20,64,4,230,161,90,145,81,253,173,64,223,5,251,193,254,175,88,90,100,136,20,37,217,147,74,0,243,197,7,184,81,233,231,157,120,110,82,18,62,21,211,57,223,70,215,96,155,155,141,33,20,35,106,245,215,227,182,255,30,108,251,234,100,56,176,192,186,0,127,124,98,72,188,55,112,50,46,196,163,232,9,131,222,177,235,42,141,201,6,157,135,183,102,45,199,41,158,139,97,251,213,95,171,90,228,105,93,173,22,57,106,15,138,49,248,247,111,33,187,126,238,38,55,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5a3357c6-df2f-45c6-8cb3-943cc980aa69"));
		}

		#endregion

	}

	#endregion

}

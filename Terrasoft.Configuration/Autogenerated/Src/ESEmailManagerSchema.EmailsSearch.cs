﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ESEmailManagerSchema

	/// <exclude/>
	public class ESEmailManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ESEmailManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ESEmailManagerSchema(ESEmailManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3bafcda6-79af-4f6b-ad66-8a682682dfdb");
			Name = "ESEmailManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92df5372-6a61-42f2-95f4-67c9e246a93f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,91,235,115,219,54,18,255,172,206,244,127,64,216,153,14,53,81,233,180,119,55,215,241,67,153,196,150,59,78,29,59,177,124,189,15,55,55,30,154,130,108,214,20,169,2,160,109,213,227,255,253,118,241,32,1,240,33,57,143,235,229,238,242,33,150,200,197,98,177,251,219,7,22,80,30,47,40,95,198,9,37,231,148,177,152,23,115,17,237,23,249,60,189,42,89,44,210,34,143,38,139,56,205,248,148,198,44,185,254,250,171,135,175,191,26,148,60,205,175,200,116,197,5,93,236,120,223,97,112,150,209,4,71,242,232,39,154,83,150,38,13,154,227,52,255,173,126,120,149,21,151,113,182,189,189,95,44,22,48,223,113,113,117,5,143,235,247,39,244,78,0,55,148,236,13,47,242,206,23,30,91,123,61,200,184,253,141,181,210,181,4,209,79,82,82,165,138,118,106,70,187,158,71,135,113,34,10,150,82,222,70,49,201,98,46,210,164,155,181,55,53,80,124,195,232,21,8,69,18,24,202,183,201,100,42,13,245,54,206,227,43,202,36,197,63,14,232,60,46,51,241,58,205,103,192,45,20,171,37,45,230,225,145,75,58,28,254,19,104,151,229,101,150,38,138,153,199,139,108,147,35,159,251,0,113,80,137,0,90,226,34,206,5,136,241,142,165,183,177,160,114,254,193,82,125,33,140,198,179,34,207,86,228,8,140,75,46,50,248,111,143,192,71,205,14,112,34,208,234,148,133,129,141,182,96,184,211,202,133,11,134,202,185,72,192,174,101,158,38,210,56,211,114,62,79,239,129,111,176,111,63,190,16,244,94,4,253,124,102,84,192,164,206,48,41,198,207,116,133,252,54,230,160,233,213,23,222,49,36,205,5,210,207,21,178,166,233,239,20,198,124,255,23,101,211,193,55,52,159,41,165,234,239,90,195,135,41,205,102,235,213,235,192,232,140,46,11,158,2,230,86,228,130,182,191,104,23,17,172,253,190,164,108,245,186,76,179,25,216,255,226,55,235,155,51,228,56,229,98,87,41,97,172,200,0,223,176,158,156,222,57,239,194,225,154,245,73,4,177,18,61,4,87,41,193,168,23,169,128,233,2,48,28,146,135,199,190,247,157,154,232,80,196,8,89,13,252,133,219,235,30,145,191,113,202,64,206,92,69,55,82,58,95,65,32,201,162,75,211,160,148,62,27,12,28,29,3,113,67,229,3,111,250,61,79,0,73,244,216,175,229,119,172,88,82,38,192,70,136,164,66,192,72,58,83,36,91,91,91,100,151,151,139,69,204,86,99,243,0,167,36,73,53,69,84,17,110,217,148,75,195,201,215,144,247,245,129,92,81,177,67,56,254,247,216,51,171,52,36,185,75,197,53,201,33,59,145,121,193,22,177,208,190,182,86,134,219,148,137,50,206,140,107,194,252,2,2,239,161,226,225,136,128,190,250,240,226,145,236,62,124,255,56,14,118,158,32,81,156,207,72,156,36,69,9,190,252,81,210,189,82,76,250,164,11,65,186,33,200,248,195,26,25,167,34,6,203,2,79,8,246,244,158,20,115,50,139,69,76,120,188,88,102,79,145,12,227,147,138,77,135,172,88,52,100,122,209,39,195,219,248,62,93,148,11,146,151,139,75,64,14,200,192,104,82,176,25,252,17,37,203,97,150,57,242,100,80,113,128,191,211,15,144,73,198,75,229,105,32,151,254,52,72,231,36,132,108,80,7,212,61,50,83,169,207,184,37,56,152,253,158,200,140,236,38,119,168,77,166,84,160,10,177,112,17,191,196,89,73,67,23,194,35,205,107,160,210,148,242,228,3,59,150,7,35,47,184,171,20,38,61,19,255,40,69,16,75,24,245,254,17,53,108,100,117,69,189,69,65,52,149,246,241,58,0,203,108,226,48,235,243,255,183,84,92,23,141,52,210,106,74,88,193,45,132,10,19,180,184,92,106,101,57,34,10,40,21,82,10,179,175,49,166,124,178,140,89,188,144,174,179,23,20,151,191,130,50,235,42,49,24,79,90,167,136,118,183,228,176,118,46,60,185,166,139,248,4,62,7,227,169,252,44,95,52,7,41,133,243,177,94,15,128,170,125,69,48,210,144,182,99,240,104,2,168,166,44,190,204,232,174,90,195,152,0,76,234,133,132,54,197,65,42,159,129,22,116,10,28,17,61,104,76,124,13,104,84,233,144,80,175,204,96,23,34,12,141,65,212,240,54,102,36,133,250,25,172,222,96,82,1,29,137,204,162,142,144,88,101,227,22,129,236,220,108,9,144,21,119,148,77,43,41,96,124,45,82,116,94,28,227,235,163,28,166,73,161,226,243,7,163,17,116,150,193,148,231,243,122,78,194,6,123,136,115,25,84,30,1,121,73,130,11,252,132,60,2,40,58,131,11,249,201,155,65,199,221,222,73,130,11,77,21,236,212,1,66,85,208,175,150,203,202,203,15,105,12,22,167,71,24,48,157,234,239,116,41,247,47,175,242,217,113,81,220,148,75,254,122,245,195,116,181,184,44,50,94,7,20,111,169,206,215,231,80,143,84,69,113,4,222,134,254,0,198,42,23,57,87,133,170,22,108,208,92,142,255,100,99,94,143,142,158,16,40,218,126,0,83,68,130,138,104,248,124,228,72,235,41,24,9,84,194,107,29,217,166,109,138,228,190,161,144,92,231,183,118,78,222,66,205,240,87,179,153,98,47,133,8,109,44,143,106,225,70,213,2,71,246,76,22,147,3,89,134,171,253,68,11,151,145,5,235,53,204,16,61,54,3,72,28,184,168,49,121,81,163,97,133,5,186,206,115,142,255,57,198,49,1,188,51,236,130,220,68,106,147,171,84,169,100,36,122,75,129,97,23,120,67,94,131,170,204,120,254,166,129,215,22,42,24,159,1,27,135,75,111,184,77,229,152,246,64,45,53,246,137,162,181,63,167,26,114,102,207,180,225,72,109,66,127,176,198,156,51,222,228,210,219,34,157,17,31,56,221,113,147,184,152,234,142,248,10,110,29,65,222,176,179,16,216,244,31,3,51,4,98,170,0,8,85,109,154,115,216,113,134,245,230,115,232,36,129,95,185,220,37,180,56,158,53,66,163,211,73,49,18,127,152,99,222,197,140,83,165,141,16,185,217,46,83,207,101,214,36,135,253,29,106,228,58,234,76,236,71,33,221,192,111,209,113,207,36,194,81,104,207,109,157,25,134,31,228,88,153,227,86,127,148,59,241,58,190,249,0,149,107,220,220,155,62,189,107,52,153,248,254,97,71,231,141,221,195,1,190,142,224,77,103,232,74,32,182,3,88,213,200,17,63,41,196,73,153,101,167,108,178,88,138,85,56,36,223,126,107,207,209,66,81,225,118,83,216,186,34,123,57,163,153,118,158,132,222,181,176,133,178,4,12,129,117,254,18,240,101,26,44,114,39,218,81,153,203,237,194,166,32,166,92,198,5,11,10,106,120,103,25,125,206,74,16,102,238,201,147,168,112,36,214,11,54,34,243,56,131,47,133,184,166,236,46,109,169,187,21,214,46,139,2,74,110,126,132,211,188,87,179,152,152,119,148,43,21,135,198,128,106,13,198,174,50,130,169,71,178,84,197,198,139,250,106,138,87,83,179,58,65,79,246,91,48,232,153,46,150,19,75,229,91,195,78,126,241,153,73,104,62,179,39,174,130,116,88,143,182,162,166,46,21,164,58,154,161,204,188,22,76,239,253,214,197,54,233,194,16,207,148,121,25,157,183,133,169,173,241,71,7,186,222,232,114,67,87,193,24,187,160,176,243,223,92,144,245,44,165,82,63,156,169,31,192,44,23,125,106,252,2,113,236,88,180,6,161,146,26,34,210,51,175,122,172,147,247,141,157,181,29,42,144,19,223,142,228,148,27,70,11,153,176,157,250,209,87,24,166,113,80,212,166,182,151,228,227,93,78,41,73,128,201,94,240,102,122,122,130,138,214,237,174,79,187,71,87,37,151,155,69,219,130,131,211,117,182,139,20,109,36,93,171,116,237,167,245,14,25,211,126,71,167,90,91,23,249,96,6,105,77,31,117,169,15,140,44,251,12,222,156,202,178,175,170,217,247,8,30,78,233,254,67,116,64,57,96,37,206,210,223,169,162,219,213,244,99,57,157,158,253,205,121,113,67,115,205,130,236,25,94,117,95,138,219,27,176,182,131,16,107,25,154,203,51,88,44,172,164,90,192,155,87,140,197,43,131,22,51,71,36,249,239,170,151,227,176,239,108,164,191,120,84,124,237,120,135,138,146,176,86,53,206,121,49,149,42,7,157,118,199,63,75,189,125,192,7,189,184,141,216,118,244,171,125,234,214,120,212,120,35,59,13,128,107,195,16,59,188,62,141,233,41,108,238,62,106,62,3,254,13,74,187,252,105,91,36,35,145,25,209,182,187,113,60,236,176,169,35,149,201,37,61,239,240,55,77,222,172,140,172,10,170,242,183,220,222,195,196,213,254,63,8,12,20,180,101,141,172,158,127,41,36,188,52,1,70,9,28,58,93,252,145,158,67,206,171,7,108,123,3,156,198,186,25,160,167,52,35,215,162,106,26,223,82,98,5,63,121,54,116,152,102,130,50,196,138,44,104,248,230,105,20,202,0,46,156,104,170,26,200,146,45,50,76,101,147,39,233,169,190,167,84,156,41,62,58,229,132,22,11,162,167,168,142,162,116,37,19,237,103,64,212,90,245,176,50,195,218,210,140,140,206,224,123,237,179,14,233,92,174,91,18,3,81,164,212,96,249,183,67,44,85,131,180,106,84,228,84,104,166,88,170,229,51,133,146,28,102,213,72,214,26,48,110,168,215,102,167,104,250,93,230,111,115,35,184,65,27,124,253,25,216,62,44,11,212,175,207,19,72,183,245,76,49,92,84,234,196,122,204,41,134,55,197,138,102,165,106,41,205,140,99,128,243,216,117,250,249,193,166,210,118,182,189,101,78,180,198,140,181,34,38,211,41,197,236,108,240,231,228,98,175,116,182,177,153,40,15,214,232,197,19,24,201,78,59,246,132,91,180,161,97,163,44,237,142,84,16,149,112,192,212,109,13,195,23,97,133,29,141,79,59,195,91,180,234,237,56,180,161,230,177,83,36,14,197,192,233,138,7,90,246,96,84,19,168,182,172,33,48,27,109,139,64,85,178,123,70,83,213,139,71,23,212,143,122,237,232,75,58,106,213,154,243,4,173,69,116,197,243,102,215,29,227,150,146,167,90,97,32,107,53,35,109,117,143,65,187,151,126,46,245,223,161,86,124,103,43,181,215,66,255,22,27,105,37,56,245,139,109,143,243,213,82,29,7,90,239,241,153,108,184,115,117,247,233,104,246,116,3,214,250,250,207,81,66,55,80,29,187,63,105,145,78,232,173,75,78,247,216,52,154,228,34,21,43,37,148,185,243,115,152,230,51,220,232,188,94,201,90,34,56,198,51,160,33,30,7,57,85,170,174,22,218,116,99,107,197,13,18,102,41,174,235,104,89,237,90,29,253,11,143,156,158,236,92,82,218,39,120,22,210,187,222,165,186,127,95,178,111,217,58,104,98,74,173,239,11,247,156,254,37,54,140,250,81,174,99,23,199,107,224,222,138,118,23,236,250,161,5,110,203,71,205,213,169,42,219,219,153,186,39,49,247,37,123,75,242,13,252,199,203,157,79,79,78,46,188,254,43,114,149,214,201,255,118,174,90,91,84,125,184,195,125,65,139,252,136,224,217,204,200,235,26,39,106,179,214,218,48,73,117,95,245,114,213,120,181,212,199,246,39,170,115,178,225,206,70,29,36,31,196,34,174,78,13,160,22,232,109,114,56,19,141,171,107,17,253,173,196,95,186,215,228,9,142,253,213,206,93,80,221,249,168,207,80,215,29,244,154,65,246,60,118,235,49,53,156,192,156,242,48,215,52,245,78,153,222,182,133,246,80,195,47,146,13,18,171,173,87,243,73,121,207,233,179,95,73,217,205,200,169,219,138,172,89,218,13,103,51,208,146,91,213,104,228,165,35,26,217,174,73,172,230,222,90,8,158,41,205,147,121,202,56,54,162,174,40,169,143,142,64,27,122,227,139,189,5,117,72,35,173,250,199,236,171,207,180,68,250,90,227,28,18,238,204,218,240,119,226,168,227,242,216,33,46,249,29,172,88,239,163,157,253,182,145,175,217,182,174,111,125,217,65,74,243,109,239,243,232,250,182,110,245,112,11,23,74,118,121,221,115,207,186,251,185,227,190,175,110,78,186,55,23,7,205,158,148,233,67,105,130,250,120,109,207,189,74,30,201,191,170,78,240,198,32,192,245,24,111,67,48,192,159,15,68,19,198,10,22,6,231,215,148,73,252,83,137,64,211,99,171,122,68,166,40,1,6,238,37,41,48,234,249,233,193,41,57,59,57,248,238,79,63,254,248,231,191,170,199,234,104,239,160,72,192,90,185,48,215,223,44,144,91,75,210,144,113,140,209,117,251,59,114,111,10,202,105,108,245,36,54,19,151,182,49,205,168,66,91,157,84,134,149,173,92,124,96,159,228,44,206,175,104,88,207,208,230,219,254,184,141,157,22,127,165,146,209,118,175,237,118,211,247,230,220,56,134,9,103,136,74,142,75,202,19,121,182,172,188,138,226,158,81,29,46,99,7,25,10,57,78,196,117,172,0,156,50,188,75,12,126,139,19,127,118,239,119,218,184,197,221,190,190,61,81,220,201,11,89,122,217,234,206,243,218,193,252,116,62,231,212,30,126,147,46,59,7,127,166,184,51,149,86,195,192,211,19,119,70,242,114,177,89,111,245,77,47,224,115,71,165,42,104,232,176,99,228,32,207,45,33,200,119,141,185,213,221,60,63,138,72,38,187,123,246,133,189,75,16,228,198,13,10,94,36,124,209,30,0,43,134,95,114,252,251,127,160,211,227,166,224,126,161,5,235,232,60,190,161,161,65,155,83,189,172,63,78,176,126,182,36,221,55,205,193,62,169,152,21,137,110,194,123,191,163,139,148,250,244,85,67,244,151,7,101,131,71,233,110,242,191,161,46,174,245,239,156,218,174,163,119,95,98,24,147,198,12,254,254,93,111,50,108,95,39,213,207,39,124,175,39,141,31,86,8,128,168,229,178,85,88,221,235,56,47,112,123,251,238,89,124,61,127,53,13,222,158,176,167,175,94,104,128,191,244,202,168,42,142,232,247,219,94,184,171,131,91,29,216,44,235,87,232,178,192,18,237,3,46,251,116,108,98,219,35,228,51,129,177,109,114,159,80,121,131,156,208,251,101,229,184,182,223,202,63,164,72,146,146,65,38,27,145,187,107,154,155,68,2,72,47,51,46,143,208,149,71,232,23,81,48,146,252,180,140,226,26,228,110,222,11,241,64,170,158,218,15,225,9,254,251,23,61,93,182,17,248,59,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3bafcda6-79af-4f6b-ad66-8a682682dfdb"));
		}

		#endregion

	}

	#endregion

}


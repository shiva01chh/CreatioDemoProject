﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StageHelperSchema

	/// <exclude/>
	public class StageHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StageHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StageHelperSchema(StageHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a40755c8-347a-442a-a897-8406acca45e8");
			Name = "StageHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,26,219,110,219,56,246,217,5,250,15,108,6,24,200,128,215,193,190,54,137,131,52,73,219,0,153,164,91,119,118,30,6,131,129,34,209,182,176,178,228,146,82,82,111,199,255,190,135,60,164,68,82,212,197,78,58,216,2,51,145,41,158,43,207,157,42,121,146,45,201,124,203,11,186,62,121,253,170,52,126,78,47,243,52,165,81,145,228,25,159,126,160,25,101,73,228,110,185,77,178,175,213,218,23,202,88,200,243,69,1,144,140,182,44,79,175,179,34,41,18,202,219,222,95,189,107,123,51,47,16,237,235,87,89,184,166,124,19,70,212,218,146,45,146,101,201,66,193,240,235,87,223,197,190,209,79,140,46,225,39,185,76,67,206,223,146,121,17,46,233,71,154,110,40,147,175,143,143,143,201,41,47,215,235,144,109,103,234,247,47,97,6,155,8,23,91,201,42,225,64,116,75,210,124,185,4,142,52,200,177,1,179,41,31,210,36,34,225,3,47,88,24,21,36,18,164,108,74,35,96,102,84,243,2,250,44,88,25,1,98,96,233,19,203,11,80,50,141,197,22,241,159,203,147,92,48,208,145,168,134,175,246,31,187,0,167,155,144,133,107,34,20,117,118,84,114,202,128,106,134,135,121,52,35,245,15,146,100,139,28,224,229,118,9,189,209,12,153,68,131,95,45,20,196,198,56,38,82,192,145,179,233,204,217,118,34,54,237,164,226,71,63,209,44,70,125,168,223,74,57,239,19,154,198,82,45,201,99,88,80,124,217,174,146,234,128,120,180,162,235,144,80,97,92,91,191,90,54,136,146,72,3,220,206,17,224,79,121,206,31,17,11,174,157,116,115,8,7,6,10,17,22,108,29,94,43,159,119,112,4,36,95,40,214,72,177,10,11,194,232,134,81,14,43,92,217,153,56,133,54,174,245,113,84,22,6,127,164,11,10,72,100,89,210,248,78,150,180,56,33,187,67,121,81,172,128,169,31,196,201,109,190,220,143,25,199,8,251,136,58,198,229,252,84,244,244,25,243,62,226,7,88,143,102,196,178,159,121,195,124,148,47,0,59,234,105,196,104,81,178,204,103,106,228,252,28,183,140,2,223,219,51,71,202,169,73,26,227,20,131,200,92,220,64,64,8,179,136,190,219,10,221,7,205,227,24,143,165,239,9,231,171,60,208,171,150,207,121,94,104,235,136,242,180,92,103,188,210,216,42,47,211,88,68,159,34,76,50,78,192,116,82,26,242,226,173,218,48,26,29,221,196,71,228,31,22,142,36,22,15,139,68,134,45,129,78,70,164,26,66,178,42,128,240,60,250,182,223,63,65,22,18,219,229,67,247,246,214,243,123,76,88,81,134,41,185,74,164,82,97,195,41,218,241,68,217,243,76,138,128,186,190,68,37,180,30,106,70,159,186,16,169,205,163,239,68,40,103,34,255,191,155,212,139,40,255,68,61,56,47,81,218,137,122,48,94,238,154,167,217,22,173,126,161,197,42,31,22,80,127,221,196,194,117,32,125,233,80,176,72,178,132,175,72,44,225,6,101,26,174,196,152,53,15,212,204,49,13,56,86,41,92,2,183,152,144,157,166,208,211,31,243,36,86,172,95,149,244,10,254,188,207,217,45,200,32,25,8,62,148,240,90,113,53,33,242,151,73,75,102,174,215,175,136,241,79,238,73,53,2,229,144,159,105,148,179,248,38,6,151,4,127,187,109,121,27,152,168,39,154,172,240,61,147,0,110,104,33,209,69,32,104,227,74,121,183,16,254,75,2,193,55,42,25,3,165,137,223,205,24,114,137,47,197,170,136,29,151,245,94,1,27,184,220,250,105,78,231,0,41,93,227,223,97,90,210,224,72,233,30,172,213,32,62,20,87,248,72,131,69,152,114,58,62,233,11,80,31,195,44,78,69,190,44,40,91,211,56,145,193,94,160,228,34,113,65,50,19,24,249,64,107,205,202,245,3,120,216,140,220,129,23,235,68,28,211,111,4,95,252,13,38,123,99,200,33,53,195,3,16,77,209,111,179,87,56,234,199,144,145,44,47,64,249,73,140,117,0,21,165,58,156,118,128,79,99,17,152,240,209,169,221,198,24,67,166,120,124,129,136,72,122,233,61,203,215,129,83,86,232,119,191,173,40,131,115,190,67,149,233,213,27,254,129,81,224,157,221,179,235,175,16,84,3,196,58,253,36,132,166,176,30,160,40,99,215,20,60,204,79,231,27,26,37,139,237,93,126,155,71,255,249,8,122,224,13,107,20,114,151,155,88,217,15,136,43,196,68,85,58,98,78,60,85,137,226,122,36,172,55,56,66,36,73,20,166,96,181,13,190,161,194,134,180,105,11,255,217,60,242,49,8,223,34,179,117,98,26,199,69,22,7,85,152,7,224,44,240,232,64,121,114,45,226,244,250,27,141,202,2,253,178,219,53,46,87,97,38,252,32,151,185,17,170,60,229,137,104,217,3,93,162,102,221,176,105,52,234,102,163,96,152,51,18,87,193,68,10,36,147,86,160,130,93,141,86,91,112,195,180,225,48,235,159,83,72,87,130,73,35,198,156,212,96,42,176,218,16,16,203,190,108,55,52,54,64,78,197,238,89,208,200,230,191,171,188,251,199,216,64,250,210,33,95,227,205,49,121,63,131,89,172,3,52,179,104,237,77,77,183,241,63,209,28,244,91,16,162,126,166,5,181,241,113,52,235,12,167,138,73,123,151,39,98,54,5,239,60,61,21,67,181,10,132,241,185,241,228,133,19,241,1,201,83,215,119,206,81,141,246,201,151,154,164,115,176,230,50,200,195,205,242,78,119,63,152,52,29,20,199,126,28,3,143,218,233,175,144,2,1,47,168,79,215,194,138,213,52,159,145,219,54,246,0,82,111,170,97,237,150,190,227,192,58,109,164,97,21,125,21,90,179,233,155,94,202,52,136,128,110,194,117,140,34,89,144,224,77,203,209,190,167,69,180,18,105,248,234,93,135,67,227,217,143,109,180,142,12,221,230,119,69,23,134,5,54,243,236,206,254,169,154,29,63,62,3,180,51,61,73,13,113,95,233,182,119,110,26,90,113,249,251,19,237,110,218,74,115,183,153,236,68,129,252,99,177,38,71,105,122,72,42,2,166,42,69,139,156,68,82,220,142,132,41,223,123,234,191,70,98,84,33,204,100,125,66,110,174,161,176,162,44,124,72,233,169,4,132,122,59,156,17,147,57,157,105,95,172,45,80,117,167,57,168,16,84,111,225,17,240,153,164,167,170,242,52,214,200,217,76,22,107,115,7,90,183,200,106,147,137,70,117,187,222,2,1,116,128,111,239,171,244,106,41,8,95,42,81,13,193,167,23,113,60,7,179,205,98,110,114,55,197,186,22,107,181,221,120,250,37,23,82,105,169,23,57,28,86,180,10,124,210,3,195,94,141,104,237,99,169,78,159,220,24,130,231,239,9,85,46,178,9,145,165,40,114,50,114,49,97,50,240,140,119,6,12,4,250,103,151,50,99,24,142,1,22,46,243,135,10,201,90,116,217,122,129,146,8,216,122,145,68,101,170,245,244,55,59,182,225,211,224,129,11,232,229,154,64,85,166,185,177,196,234,77,57,190,9,146,244,203,174,226,176,211,151,33,241,8,180,117,67,199,117,15,215,222,187,129,97,110,130,127,14,106,225,124,157,207,15,105,100,218,128,181,144,26,238,158,197,148,189,219,94,81,30,5,71,104,254,241,125,118,52,38,33,87,210,162,21,243,206,110,176,30,189,105,117,129,190,202,52,37,231,82,181,211,235,245,6,204,230,173,122,171,219,167,57,116,121,33,83,37,118,127,33,12,103,138,253,78,248,144,151,5,9,1,125,248,24,38,169,8,183,253,57,171,50,177,11,7,70,76,41,117,178,232,179,173,150,0,15,156,97,136,173,243,78,96,14,5,36,161,107,254,85,89,145,57,48,254,87,73,153,91,155,248,38,202,19,247,102,161,10,101,151,16,4,61,169,227,98,179,73,161,141,22,207,114,199,244,183,164,88,193,169,133,169,248,153,100,203,198,76,97,98,224,187,41,232,90,94,25,156,169,169,169,184,201,3,108,46,144,24,158,194,86,101,233,106,4,170,46,32,18,213,72,85,120,80,9,34,216,155,62,50,21,239,45,64,8,146,189,144,215,153,23,20,7,27,189,208,122,96,162,205,255,2,172,223,196,86,245,122,218,48,168,187,96,224,133,211,119,247,123,138,205,218,69,92,92,58,47,127,179,178,177,153,134,65,88,32,248,205,219,160,62,228,121,58,11,44,149,233,147,68,41,91,33,193,123,103,129,171,48,13,59,175,186,121,63,48,58,109,210,164,186,27,228,200,92,186,175,46,204,196,141,215,19,196,64,194,163,4,232,144,7,90,60,81,10,181,91,170,162,50,9,65,3,160,154,125,6,222,92,167,29,199,195,187,218,221,52,174,116,15,208,247,21,249,198,152,165,57,181,164,79,38,168,57,187,244,129,214,9,207,51,51,237,139,66,162,146,113,194,143,167,100,117,119,33,114,60,164,218,194,76,145,39,134,229,153,242,232,80,227,98,52,139,75,180,112,209,69,153,24,117,30,168,130,149,9,162,125,136,235,1,32,230,65,174,11,83,110,212,128,228,212,226,200,170,12,1,210,174,12,119,132,66,43,214,73,210,165,21,88,196,102,150,90,28,98,63,255,252,12,206,204,56,96,50,102,85,2,21,87,111,144,16,184,191,147,174,253,74,210,155,44,154,67,186,63,17,116,244,188,97,184,131,25,229,112,99,182,16,139,195,247,55,92,205,222,141,55,172,87,224,91,229,79,92,180,229,5,224,172,124,9,114,141,242,149,86,151,66,70,48,200,246,121,146,154,41,180,150,253,141,190,168,217,7,136,248,75,60,34,128,169,225,68,160,46,39,91,122,62,23,231,84,174,159,159,31,214,12,42,145,224,72,213,211,33,147,17,236,105,212,88,212,29,140,201,153,152,44,235,32,202,137,191,193,184,23,198,170,109,39,77,145,171,122,182,15,81,61,149,107,224,184,183,198,116,237,40,116,149,236,65,129,109,231,220,154,23,119,34,98,133,255,130,77,197,194,22,2,34,159,255,245,151,207,106,208,133,191,87,109,101,11,229,214,139,61,55,198,84,40,134,124,230,83,119,161,242,235,169,174,15,53,182,89,180,98,121,150,252,151,114,157,181,158,160,190,236,251,90,165,53,227,202,38,209,200,183,3,27,76,0,175,231,70,2,124,191,169,145,247,94,69,248,140,12,95,214,148,8,191,39,211,113,67,14,139,12,37,72,25,176,177,172,37,210,83,238,138,199,137,142,55,205,139,23,21,69,228,198,203,21,128,139,202,171,134,36,111,6,94,84,84,254,161,140,65,225,5,142,10,138,183,65,10,177,174,239,6,35,174,122,203,218,186,109,188,85,142,111,232,197,84,137,33,186,26,158,160,165,154,182,139,184,13,93,212,189,78,203,133,86,3,107,239,55,53,255,47,22,252,163,77,176,213,226,170,190,148,227,165,74,179,129,117,106,23,1,208,126,53,184,215,221,25,232,234,15,47,214,59,85,73,189,224,53,162,159,192,253,75,222,255,85,116,204,66,176,46,53,223,39,140,23,247,236,138,46,194,50,45,2,46,203,182,105,37,231,153,87,126,131,123,187,160,30,140,181,182,130,138,71,225,88,54,143,78,121,238,247,69,139,129,55,14,72,251,87,62,126,183,175,68,219,85,2,202,56,178,164,159,24,125,76,242,146,27,1,202,164,72,160,240,246,84,218,80,127,123,138,117,39,72,213,200,29,190,61,125,147,135,134,159,127,171,203,144,114,216,157,134,191,45,83,109,152,211,120,89,237,150,10,140,173,151,17,246,236,178,213,184,39,246,197,67,165,245,74,239,63,232,234,65,207,74,221,229,106,152,177,95,252,144,67,34,115,42,129,248,107,229,225,43,159,71,187,10,193,157,221,247,15,173,205,220,206,241,244,131,239,14,234,186,178,245,210,160,167,80,179,62,156,175,17,119,125,66,234,126,219,108,53,106,93,189,159,74,59,230,7,244,38,69,93,172,54,168,202,149,58,11,214,155,44,236,26,189,204,91,112,122,202,70,196,103,195,248,196,245,147,54,92,63,161,107,247,98,98,8,189,202,18,15,165,234,126,240,58,132,168,182,211,67,105,206,171,169,82,15,181,58,128,34,200,51,8,178,130,20,9,126,195,219,65,80,199,134,115,249,212,77,111,47,19,223,215,182,165,77,31,96,216,67,44,122,238,84,119,67,142,92,39,229,231,30,121,253,17,100,15,85,241,181,162,202,142,135,210,188,225,226,170,46,76,235,43,195,14,122,178,203,16,77,237,254,103,174,214,204,37,88,129,127,255,3,234,194,55,63,4,53,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a40755c8-347a-442a-a897-8406acca45e8"));
		}

		#endregion

	}

	#endregion

}

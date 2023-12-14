﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookHandlerSchema

	/// <exclude/>
	public class WebHookHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookHandlerSchema(WebHookHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("40006aab-bf10-4248-abcc-b15221fc05db");
			Name = "WebHookHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,89,91,111,227,182,18,126,118,129,254,7,174,11,20,18,54,80,210,215,38,118,145,196,217,214,219,236,38,136,157,211,135,69,112,32,75,116,194,174,76,122,73,42,137,79,55,255,253,12,239,212,197,177,123,65,243,224,88,212,112,56,215,111,102,104,154,175,176,88,231,5,70,115,204,121,46,216,82,102,231,140,46,201,125,205,115,73,24,253,246,155,63,190,253,102,80,11,66,239,209,108,35,36,94,29,183,158,129,190,170,112,161,136,69,246,51,166,152,147,162,67,51,189,234,44,93,18,250,37,44,158,51,142,155,79,217,228,44,44,124,196,79,18,248,43,241,222,11,70,221,102,120,255,29,199,247,112,52,58,175,114,33,126,68,191,225,197,47,140,125,254,37,167,101,133,185,166,56,60,60,68,39,162,94,173,114,190,25,219,231,107,206,30,73,137,5,90,97,249,192,74,129,36,67,107,206,10,44,4,122,194,11,244,0,60,4,90,114,182,66,231,23,179,204,113,57,140,216,172,235,69,69,10,84,168,115,59,199,14,254,208,71,7,233,64,120,153,83,9,18,94,115,242,152,75,108,222,175,205,3,42,212,123,68,168,116,156,206,114,89,60,124,32,116,70,254,135,209,8,253,112,188,23,125,254,236,232,143,142,142,90,91,56,206,75,70,171,13,186,21,152,131,60,212,248,12,253,183,110,60,111,61,8,152,79,37,54,81,33,206,89,13,75,234,28,75,255,29,166,165,209,181,173,184,144,188,46,36,227,74,117,109,50,67,208,246,138,94,152,82,34,73,94,129,14,2,149,68,203,3,175,17,91,162,188,170,208,131,177,46,248,133,113,239,37,36,55,107,44,50,207,50,118,145,243,81,211,59,73,203,0,77,253,83,164,2,126,48,104,153,5,116,237,216,105,48,120,121,93,121,136,178,53,230,146,224,109,110,159,192,199,156,172,240,79,104,194,62,50,121,157,115,129,65,88,29,125,239,84,240,25,89,238,177,180,223,6,28,203,154,83,148,248,157,105,156,184,144,53,141,236,205,32,215,102,88,74,72,33,149,155,242,63,121,85,227,196,112,106,107,120,128,134,51,201,214,198,72,214,98,215,38,37,78,229,48,213,250,42,133,189,214,251,40,49,103,255,186,10,57,151,251,235,176,205,115,31,12,44,108,113,219,12,43,192,67,32,77,156,125,102,53,113,1,244,152,235,32,13,175,77,102,38,144,75,41,250,243,26,183,85,53,22,24,126,0,85,57,169,170,166,178,176,245,58,47,62,231,247,88,39,170,211,156,44,81,210,17,233,164,15,114,156,18,131,30,13,122,200,35,195,246,31,50,238,195,169,189,15,49,228,241,33,214,184,42,198,172,51,70,136,226,39,235,153,182,177,82,189,39,155,179,117,71,50,251,10,106,88,189,162,201,240,38,127,178,39,139,33,68,147,170,53,16,166,249,240,117,178,105,233,8,84,210,38,38,46,148,108,211,82,88,137,32,46,37,17,146,20,23,143,152,202,57,96,86,118,177,202,73,229,215,133,229,112,75,65,224,125,89,220,82,81,47,68,193,201,2,167,59,247,211,186,170,210,20,229,194,90,41,205,78,69,50,172,157,232,151,120,41,175,106,64,248,247,140,180,84,76,179,43,170,40,15,180,166,217,84,92,124,169,243,170,215,12,129,189,113,151,77,246,134,175,142,123,64,164,145,82,187,244,254,73,131,126,156,104,95,106,12,117,98,119,12,4,23,122,159,89,167,53,21,182,111,126,123,192,28,39,195,119,224,40,28,107,110,152,100,0,117,208,63,129,201,146,101,94,9,112,65,72,51,37,32,122,3,2,41,163,187,56,119,82,234,255,217,41,45,147,161,82,231,53,198,26,46,180,182,49,122,57,179,26,134,77,147,183,12,251,200,72,137,38,240,90,58,64,20,201,244,130,214,43,40,229,139,10,159,252,92,147,114,140,72,121,9,38,118,130,42,43,154,45,219,172,184,211,100,145,121,167,180,163,150,72,236,129,105,118,241,140,11,136,186,36,221,42,252,204,195,172,48,142,72,212,214,173,130,223,174,203,188,43,56,132,103,159,180,192,219,187,247,0,89,49,117,179,150,64,219,226,146,170,161,213,223,209,167,107,120,11,216,222,53,19,223,245,104,130,131,198,150,179,92,56,39,142,199,174,184,136,56,15,160,25,245,198,10,40,122,43,73,69,84,27,162,202,201,101,68,146,120,30,199,158,197,146,84,160,17,46,93,9,239,99,243,78,211,68,232,99,41,186,86,143,5,138,15,209,38,119,71,104,52,182,217,27,124,107,77,104,39,128,100,114,102,76,11,189,95,185,240,95,71,237,254,53,187,0,169,56,158,156,133,165,36,245,25,8,157,35,206,225,172,36,170,206,208,221,118,148,246,27,180,180,28,139,186,82,37,198,238,200,116,73,206,230,124,211,232,52,146,32,215,65,91,44,171,139,1,135,55,134,97,56,100,208,99,143,236,180,44,111,114,122,143,157,147,178,95,241,198,179,49,48,96,255,133,154,104,103,24,205,74,219,124,90,130,216,109,237,50,3,23,208,59,108,146,103,52,26,163,103,205,187,17,235,122,253,77,159,92,160,148,204,9,21,201,115,218,19,54,58,40,162,216,137,3,0,146,163,192,107,153,116,172,189,69,32,195,189,95,167,158,85,37,89,145,7,246,13,81,34,108,238,219,122,10,39,135,48,105,225,101,223,134,137,42,73,84,245,123,125,192,220,99,183,62,60,80,115,21,164,228,199,122,181,192,252,106,105,123,54,241,142,241,211,66,214,106,16,130,208,63,173,75,130,105,129,125,103,233,26,104,85,26,254,177,70,114,63,25,174,150,103,117,245,89,119,46,195,6,194,245,142,115,122,20,128,217,250,1,251,113,109,203,160,166,87,214,10,78,17,5,72,29,13,75,213,117,141,231,209,78,164,150,178,147,67,77,21,54,25,99,136,6,41,80,185,229,216,218,239,79,193,86,27,228,6,20,157,178,139,141,196,159,238,52,239,86,227,174,207,52,152,100,54,38,81,8,41,122,52,106,149,247,102,175,211,110,87,97,14,198,160,158,225,248,1,175,24,223,204,244,146,102,102,121,75,40,231,150,27,208,43,220,251,29,90,208,153,249,58,130,25,28,16,152,222,7,32,158,224,130,173,214,0,39,48,105,25,170,196,156,227,128,34,40,98,148,200,180,246,73,224,234,162,23,21,26,132,19,147,162,106,6,106,244,231,206,26,160,175,229,220,145,197,154,244,146,221,103,23,156,51,14,17,180,130,108,28,126,106,142,223,17,221,29,212,92,220,151,62,177,9,95,11,176,27,227,101,48,233,179,68,11,173,0,91,70,23,56,225,86,103,223,184,115,5,113,56,86,133,40,230,102,248,131,158,157,16,140,247,175,149,121,75,104,94,3,3,81,23,74,130,101,93,33,243,22,154,22,123,183,180,23,75,131,37,13,150,148,201,253,121,185,84,48,25,174,182,171,171,32,248,40,24,47,197,150,92,177,200,20,245,76,9,171,37,234,180,39,38,170,66,51,114,128,20,89,212,160,121,233,123,210,203,143,110,91,38,105,19,25,79,161,159,209,141,233,22,17,28,185,63,112,107,67,161,36,40,212,92,140,85,255,112,212,232,50,212,187,191,222,94,196,76,184,233,23,130,158,174,53,188,1,235,67,103,31,78,9,251,7,79,15,32,60,192,11,207,20,85,196,217,72,77,202,30,137,38,103,106,136,128,133,71,204,65,37,120,214,64,63,103,74,105,96,245,73,181,173,119,190,115,208,140,12,126,33,245,210,207,184,119,106,144,48,120,232,105,45,100,6,0,104,128,103,4,92,97,240,215,132,237,201,39,114,227,39,82,222,5,211,248,221,47,8,195,8,21,209,123,63,170,70,8,250,235,112,208,139,251,98,157,248,246,237,43,93,145,69,20,75,218,87,132,23,140,85,104,42,12,60,93,99,78,88,233,75,173,210,105,203,213,156,69,127,244,245,171,237,25,250,46,191,118,19,57,94,125,219,219,149,69,141,36,237,178,66,217,83,79,76,156,215,156,195,176,172,110,58,85,229,183,143,238,198,45,78,4,141,29,35,197,38,83,175,209,219,45,87,145,174,231,133,237,87,203,73,190,9,28,0,100,119,236,159,179,254,221,202,186,250,252,49,48,241,202,170,85,165,213,216,200,246,245,171,214,241,36,38,9,109,22,196,204,113,195,233,38,140,90,60,190,255,190,203,163,203,162,17,48,222,214,123,223,20,238,186,220,182,163,30,52,68,234,50,187,245,43,131,0,28,128,182,235,245,123,108,61,14,183,39,198,56,84,223,180,195,184,165,109,227,158,14,16,62,183,29,30,118,253,157,235,254,108,173,24,253,153,238,244,216,179,93,91,202,243,54,200,70,237,141,162,163,150,179,194,58,199,221,122,179,175,130,216,87,59,107,208,158,133,66,139,80,152,204,240,191,108,4,89,29,22,39,125,82,26,203,180,171,99,179,8,134,202,151,66,28,30,57,208,130,88,236,28,122,210,243,235,74,8,246,182,57,223,142,94,179,92,124,241,172,251,5,63,182,138,108,206,130,81,162,65,235,192,201,102,151,76,178,158,138,247,225,238,33,73,61,48,219,97,45,249,125,206,62,99,170,118,116,238,7,38,24,128,199,252,144,227,106,133,161,206,124,155,154,166,105,99,38,142,36,246,195,24,138,75,150,55,167,187,45,104,39,66,196,33,212,138,70,21,49,227,116,147,81,122,236,78,121,137,164,105,155,124,60,218,149,43,81,169,219,26,254,240,215,49,149,75,37,108,251,233,27,92,144,53,240,151,162,115,247,118,220,35,104,232,118,108,201,85,88,23,41,221,24,107,7,131,238,93,90,136,210,54,251,118,148,250,50,251,18,112,186,99,39,116,20,78,251,7,116,117,160,254,202,112,242,151,231,144,86,252,116,134,145,126,224,55,171,205,69,88,131,191,255,3,107,254,235,111,76,31,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("40006aab-bf10-4248-abcc-b15221fc05db"));
		}

		#endregion

	}

	#endregion

}


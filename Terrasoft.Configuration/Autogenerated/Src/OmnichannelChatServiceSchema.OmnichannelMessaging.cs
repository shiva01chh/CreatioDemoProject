﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmnichannelChatServiceSchema

	/// <exclude/>
	public class OmnichannelChatServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmnichannelChatServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmnichannelChatServiceSchema(OmnichannelChatServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("714d98d4-57c8-4f9d-834a-6068d3ad895b");
			Name = "OmnichannelChatService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aa784342-25af-480c-b5d1-88617bf6f672");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,91,91,111,219,56,22,126,246,0,243,31,184,238,98,32,3,30,165,88,96,95,154,216,133,235,164,29,239,54,151,141,211,45,176,193,32,80,36,58,17,42,137,46,73,57,235,41,242,223,231,240,38,81,20,125,145,59,15,221,206,246,33,141,168,115,227,119,14,15,15,143,152,34,202,49,91,70,49,70,55,152,210,136,145,5,15,167,164,88,164,15,37,141,120,74,138,240,50,47,210,248,49,42,10,156,133,231,152,177,232,33,45,30,126,252,225,203,143,63,244,74,6,191,34,139,224,138,146,85,154,96,202,194,83,146,71,105,17,158,21,60,229,41,102,199,21,245,124,205,56,206,221,103,208,153,101,56,22,10,89,248,14,23,152,166,113,139,230,125,90,124,110,13,94,151,160,34,199,225,28,88,162,44,253,77,26,221,162,130,183,171,52,198,231,36,193,217,214,151,225,4,140,88,237,22,18,126,196,247,45,2,24,3,34,198,128,121,206,35,142,107,2,27,220,60,183,101,219,111,232,6,14,138,61,64,58,4,111,163,152,19,186,129,226,162,76,155,214,159,70,60,2,55,115,10,92,62,6,49,19,215,82,229,124,124,154,82,229,40,52,218,203,245,161,203,7,18,65,230,11,138,31,132,144,105,22,49,246,202,150,52,125,140,184,54,86,82,30,29,29,161,19,86,230,121,68,215,99,253,172,181,49,20,33,166,72,209,130,80,244,68,232,39,97,234,83,202,31,17,169,69,34,248,159,179,16,25,105,71,150,184,91,173,203,192,241,171,24,155,176,229,5,230,128,192,18,66,225,62,205,82,190,190,198,159,75,152,66,142,11,206,2,251,65,32,10,88,236,96,17,84,161,30,72,6,160,228,69,186,64,23,103,55,243,155,201,197,233,228,250,244,111,119,47,65,241,178,188,207,210,24,197,2,148,13,152,160,87,232,77,196,112,133,208,11,156,49,124,8,235,16,205,174,113,148,92,22,217,218,14,90,33,177,72,210,5,136,252,34,241,223,225,170,107,200,31,176,106,149,175,182,90,97,40,193,140,70,138,209,246,212,130,122,66,115,175,215,187,21,97,122,142,243,123,76,131,11,72,84,128,114,95,8,98,125,1,96,175,210,246,62,101,252,196,81,54,70,146,18,125,65,15,152,31,67,148,192,143,103,16,80,224,39,63,125,48,16,161,222,123,214,115,6,12,212,180,247,193,64,209,220,218,171,234,215,93,104,232,105,202,121,24,233,111,83,156,37,32,254,74,242,233,151,110,252,171,145,15,69,250,185,196,8,22,1,172,179,69,26,75,36,17,89,32,241,204,215,97,205,122,212,224,245,97,58,75,28,64,223,149,105,130,102,73,19,188,173,230,136,25,161,24,230,14,83,239,164,123,170,120,92,143,18,242,169,92,194,166,80,230,197,191,163,12,38,170,233,58,152,52,137,99,2,155,131,192,228,43,12,11,181,152,157,6,26,117,157,48,147,201,105,169,83,103,55,243,244,150,108,242,238,110,0,181,182,253,237,3,173,88,160,151,147,164,138,176,78,54,158,75,70,12,41,198,177,142,113,42,119,148,234,125,215,72,99,144,169,74,214,201,152,185,100,217,9,147,34,235,106,207,146,226,85,138,159,186,122,144,95,41,62,63,60,22,65,87,123,200,18,67,110,37,221,66,234,82,51,237,196,200,16,118,177,202,44,197,178,128,112,143,97,191,193,9,202,85,101,208,205,143,31,106,1,231,236,97,234,89,155,41,104,242,80,29,176,50,129,148,131,39,88,149,102,15,92,164,96,194,92,139,242,231,218,6,193,33,134,146,146,198,248,32,219,230,146,213,31,129,234,157,215,30,159,200,247,17,227,110,181,231,8,110,21,145,62,158,14,0,204,42,199,200,60,175,231,116,0,14,126,191,84,47,93,147,128,110,111,171,96,159,46,85,125,26,151,148,194,27,89,142,118,206,21,255,18,98,54,154,105,94,123,177,115,171,153,29,69,78,85,134,80,113,20,50,149,157,122,64,20,106,70,2,53,163,91,207,152,141,8,221,197,214,211,241,118,77,64,6,185,68,28,19,132,54,194,193,255,56,105,234,19,178,77,194,185,32,26,213,59,226,140,200,218,173,229,12,233,139,2,54,139,34,150,59,217,9,195,24,197,20,47,70,125,159,216,254,209,88,213,106,97,37,173,225,154,165,177,208,111,84,107,64,85,177,224,14,253,91,143,98,94,210,162,109,61,184,184,61,246,250,181,44,86,125,170,130,15,112,234,129,2,165,80,235,69,85,174,61,21,150,172,86,231,211,179,18,25,220,162,127,110,163,125,141,151,132,165,192,182,86,190,172,159,15,66,185,102,223,137,175,10,105,199,6,231,113,35,168,77,83,5,164,206,136,5,104,61,186,5,74,15,52,114,145,185,248,56,131,7,129,228,200,232,128,148,107,146,111,108,43,102,46,241,200,63,108,161,231,188,218,31,66,19,199,231,81,1,249,222,90,198,122,96,51,116,85,201,145,107,214,212,143,165,163,97,79,28,93,187,220,231,157,11,217,16,142,218,67,26,55,71,228,110,204,54,158,64,225,140,204,105,41,186,61,206,73,209,76,198,123,246,15,6,218,246,70,122,6,131,229,137,86,117,143,214,225,59,220,58,24,27,210,113,160,166,222,147,81,80,27,49,161,15,165,232,112,4,253,178,49,165,254,16,57,115,220,235,128,125,142,249,35,217,184,249,120,142,53,176,31,113,108,143,7,178,243,180,134,141,42,38,52,25,154,90,38,150,47,197,134,58,68,247,132,100,232,49,98,179,28,124,1,24,44,162,140,97,3,144,246,173,71,176,145,104,139,250,107,255,75,253,248,44,126,192,196,141,232,198,140,255,128,57,100,146,68,41,214,67,73,202,150,89,180,86,108,59,102,182,138,96,221,36,48,170,196,10,111,223,172,151,56,177,108,57,17,245,196,56,128,89,213,186,158,69,209,161,2,52,93,160,32,77,194,25,59,203,151,124,29,12,6,206,130,40,202,44,179,55,35,161,17,230,45,214,155,180,72,205,119,84,91,248,186,171,45,87,150,180,254,0,189,146,5,80,40,205,57,182,221,39,251,60,45,164,181,181,198,12,224,188,33,115,9,100,48,24,170,119,167,10,80,67,178,197,60,229,1,105,96,195,11,207,125,35,235,202,51,245,22,28,53,154,128,70,191,15,83,106,147,184,86,62,119,91,74,86,146,240,102,215,73,28,227,37,23,221,84,145,28,16,39,136,63,226,170,90,109,28,38,219,57,84,142,44,35,26,229,168,0,15,141,250,66,6,132,204,184,85,155,243,240,228,72,18,214,124,202,91,108,124,67,69,51,107,161,244,10,27,158,34,48,71,154,133,33,254,9,140,211,167,148,137,242,83,50,168,192,6,121,70,128,144,120,171,146,44,204,189,209,133,187,253,136,239,103,197,138,124,194,129,130,68,84,212,87,151,243,27,88,169,162,35,139,25,127,75,104,14,74,71,8,72,245,105,68,13,133,255,96,4,150,213,27,146,172,231,124,157,225,6,73,53,26,126,164,209,18,162,67,75,147,62,50,237,204,237,162,7,118,159,80,46,94,229,11,145,121,3,89,219,43,52,237,37,172,253,98,118,148,153,152,79,51,213,134,83,69,34,70,195,89,114,92,175,126,54,209,152,154,109,222,164,247,112,194,88,250,80,216,213,102,160,84,15,219,10,135,8,128,24,59,107,31,163,191,140,100,2,64,63,253,132,240,150,5,221,175,5,193,10,30,141,90,75,248,121,208,88,202,181,209,118,212,123,3,25,148,162,184,110,53,136,179,138,238,253,111,137,93,19,66,83,47,227,55,22,98,135,198,150,104,138,0,58,31,228,212,100,107,92,78,55,112,118,189,102,76,248,24,182,70,218,224,32,15,153,62,16,24,89,31,141,119,56,235,159,120,253,179,60,203,160,101,148,82,20,81,26,173,213,119,31,153,62,96,225,68,69,210,82,32,53,127,47,46,61,77,165,11,0,30,185,176,134,194,199,227,218,201,154,187,147,159,29,158,157,222,60,143,232,39,20,101,234,3,91,13,51,228,238,170,253,214,125,215,240,238,22,255,179,94,90,17,209,223,3,156,196,26,154,48,241,201,205,151,216,155,14,113,232,53,169,202,138,110,51,32,116,151,168,124,225,158,202,14,91,168,182,87,255,32,71,58,41,215,124,246,87,107,183,210,245,141,45,209,175,220,216,103,103,5,156,145,104,116,159,225,19,225,39,77,46,23,43,204,104,133,41,147,179,243,5,198,166,5,107,201,97,141,0,217,157,125,213,151,180,206,126,85,124,150,107,245,23,178,150,119,157,104,208,237,213,58,32,100,143,118,43,23,37,79,170,179,95,111,202,48,196,118,50,93,46,22,12,3,215,53,16,3,147,120,248,127,240,109,9,190,73,150,121,226,207,56,122,136,76,60,42,23,202,29,6,25,223,128,242,191,191,172,134,20,242,48,246,114,87,224,130,206,58,110,107,85,150,22,163,97,88,11,222,43,180,25,122,76,153,108,86,221,175,77,25,208,248,110,211,33,123,77,155,236,251,4,145,206,118,127,198,56,250,69,225,222,53,127,25,182,46,233,107,73,241,207,139,20,64,79,196,29,8,241,249,216,0,142,56,206,225,20,206,241,87,250,250,219,170,59,108,175,33,116,128,223,52,74,154,74,213,135,246,200,141,70,173,139,243,46,75,30,147,60,45,30,92,25,251,122,114,154,17,56,204,71,226,178,29,222,89,243,255,249,124,38,139,70,137,145,188,143,136,55,181,3,154,223,50,66,151,195,28,224,57,45,241,158,25,84,30,122,69,254,52,93,159,3,114,40,169,207,247,227,75,143,152,239,203,87,155,110,185,233,28,199,148,223,106,76,236,86,14,53,196,234,98,218,6,81,250,32,214,227,213,167,28,213,7,146,174,26,185,159,22,76,114,101,111,214,85,39,199,210,126,108,154,54,74,118,56,213,82,84,183,99,142,197,110,22,232,86,247,64,116,121,60,134,25,43,122,179,189,186,201,242,130,153,110,137,246,204,61,169,209,182,14,187,185,125,117,103,110,95,181,135,238,116,175,93,198,182,17,110,110,137,237,37,220,22,234,21,166,47,87,236,16,166,168,238,170,139,88,142,148,106,1,108,23,83,95,190,49,140,250,38,210,118,54,115,171,201,178,185,186,51,180,87,243,186,121,13,201,136,177,110,102,141,228,61,176,155,52,199,226,94,130,100,22,194,170,11,215,56,168,181,88,10,130,198,237,175,33,18,2,254,67,10,60,43,22,36,252,192,227,74,149,239,166,206,86,203,69,151,35,240,95,3,170,204,111,92,167,217,39,66,141,23,157,155,58,70,160,247,150,202,86,185,46,53,232,240,95,143,169,220,173,238,218,236,237,52,105,174,185,188,227,132,108,183,73,219,19,181,111,146,236,35,162,186,148,162,248,159,7,225,13,17,215,107,77,202,122,70,113,196,227,71,20,156,253,87,180,112,5,108,216,250,104,164,115,208,188,140,133,43,205,247,42,55,69,157,81,10,169,11,2,71,154,100,120,48,175,198,3,220,184,2,161,171,22,67,186,71,49,130,69,58,213,185,67,109,84,28,78,16,81,252,184,127,45,105,78,50,172,63,22,0,88,7,100,107,235,99,223,217,222,167,235,20,128,111,106,230,175,192,155,10,236,2,121,209,90,70,74,125,168,100,198,253,245,72,8,226,207,128,33,16,31,39,199,141,205,198,150,42,107,135,107,156,147,21,54,106,222,82,146,43,85,162,255,185,237,123,179,215,241,215,250,99,146,60,182,69,234,207,79,80,6,70,119,173,70,237,27,8,96,189,88,69,226,234,193,119,91,243,84,55,232,101,147,82,37,56,83,240,168,71,230,43,87,171,161,58,197,56,21,172,150,161,223,55,27,159,226,227,115,131,217,254,114,84,37,149,125,196,235,196,231,213,210,72,33,158,219,46,66,134,28,50,243,180,20,110,187,225,160,70,155,131,48,38,254,253,14,206,35,128,103,133,53,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("714d98d4-57c8-4f9d-834a-6068d3ad895b"));
		}

		#endregion

	}

	#endregion

}


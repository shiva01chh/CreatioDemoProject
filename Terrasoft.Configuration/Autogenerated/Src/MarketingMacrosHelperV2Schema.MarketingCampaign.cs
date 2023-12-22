﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MarketingMacrosHelperV2Schema

	/// <exclude/>
	public class MarketingMacrosHelperV2Schema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MarketingMacrosHelperV2Schema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MarketingMacrosHelperV2Schema(MarketingMacrosHelperV2Schema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2e0bb74b-01ca-4a9b-a637-27fd95a2f7c2");
			Name = "MarketingMacrosHelperV2";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("29541596-ea83-4c00-89eb-6c01cd654a20");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,90,91,87,219,72,18,126,246,156,51,255,161,99,30,70,158,104,228,100,30,185,101,129,33,137,119,67,96,113,156,60,100,114,56,178,220,24,109,100,201,105,73,4,47,225,191,111,245,253,162,150,108,195,206,217,229,1,80,171,186,186,186,171,234,171,75,43,143,23,184,92,198,9,70,31,48,33,113,89,92,87,209,73,145,95,167,243,154,196,85,90,228,209,89,156,207,72,154,101,99,76,110,211,4,255,252,211,253,207,63,245,234,50,205,231,104,188,42,43,188,216,115,158,97,126,150,225,132,78,46,163,55,56,199,36,77,26,52,239,210,252,91,99,240,3,190,171,244,160,41,16,193,109,227,209,31,199,254,87,230,30,78,78,199,103,197,12,103,229,122,210,73,149,154,100,111,171,106,73,135,210,106,133,14,164,156,159,240,52,50,94,0,53,208,239,16,60,7,6,232,36,139,203,114,23,157,197,228,43,174,128,197,89,156,144,162,124,139,179,37,38,140,112,56,28,162,253,178,94,44,98,178,58,20,207,59,198,15,50,126,59,131,234,1,249,94,69,146,249,208,224,190,172,167,89,154,160,132,74,229,23,138,202,170,159,62,254,142,238,153,152,122,67,160,199,42,206,43,216,212,5,73,111,227,10,243,247,75,254,128,18,250,30,149,21,161,231,245,38,43,166,113,198,25,142,147,27,188,136,225,216,250,192,162,138,147,170,191,183,213,204,227,58,251,122,186,136,211,140,178,80,15,157,76,196,116,28,147,228,230,34,174,42,76,114,152,252,183,254,159,159,119,162,231,175,118,254,252,210,57,91,217,4,103,115,12,251,207,53,151,254,231,157,109,102,159,230,51,99,238,78,247,202,210,201,252,11,255,250,99,139,201,246,186,63,126,237,156,58,201,203,122,90,38,36,157,98,240,200,175,198,196,251,23,15,195,23,67,225,244,204,121,134,14,18,68,229,109,50,52,24,92,226,36,93,166,56,239,86,115,99,69,2,8,4,139,26,75,191,250,138,87,7,176,254,70,155,102,252,24,187,163,44,115,246,48,121,63,158,28,239,174,227,244,247,34,205,1,178,234,69,254,30,68,161,243,70,51,57,97,7,195,42,204,13,218,125,130,57,152,224,47,156,205,100,127,129,73,89,228,107,125,162,109,165,215,41,206,102,109,174,71,112,60,43,242,108,133,38,37,38,192,48,231,176,139,174,106,235,217,217,189,16,236,106,90,204,86,206,171,119,105,89,237,47,48,153,227,171,219,152,28,162,171,57,247,74,58,242,49,38,165,67,254,166,78,103,138,134,237,79,236,106,52,235,160,84,174,220,160,146,146,197,203,37,156,35,3,228,9,201,28,162,105,81,100,232,42,45,39,202,144,94,147,98,113,68,237,31,224,56,159,187,66,74,166,181,182,188,35,151,127,175,215,56,5,190,159,81,126,93,192,49,44,196,230,100,96,91,163,180,11,82,0,148,86,41,118,236,195,133,126,27,251,145,7,211,25,212,91,8,223,132,120,105,118,174,242,222,216,186,163,184,222,235,245,230,184,18,255,245,8,174,106,240,20,143,146,225,229,3,253,253,176,141,220,200,29,232,22,119,116,154,215,32,109,60,205,240,62,215,209,161,137,14,252,252,143,178,52,46,177,71,246,107,136,253,113,114,131,2,216,42,226,234,65,105,222,212,212,64,78,232,165,215,40,224,111,35,64,29,192,169,209,12,29,28,232,152,200,124,186,140,152,101,126,192,139,101,6,166,192,133,224,228,134,108,163,153,102,219,91,81,15,69,226,44,197,2,76,236,61,65,241,192,255,62,52,142,181,19,93,72,157,84,5,217,194,128,26,10,177,226,122,136,90,44,204,77,39,214,90,27,27,89,82,220,70,57,0,230,65,223,6,155,254,161,111,13,207,72,180,63,100,92,76,155,240,38,40,129,131,110,246,122,82,19,14,230,1,196,54,64,144,82,185,246,1,116,57,254,222,112,249,96,32,232,29,223,48,201,181,171,9,234,53,106,61,195,213,77,209,138,229,183,5,32,228,40,79,171,51,71,194,64,238,144,90,58,184,204,20,19,78,2,178,188,224,82,110,237,12,148,142,20,69,117,154,225,5,152,182,226,103,154,111,52,6,144,172,130,95,162,95,6,159,95,124,17,198,44,8,70,37,7,23,152,242,36,159,226,92,168,59,253,248,33,188,37,240,200,117,208,149,29,10,77,245,4,206,39,44,148,67,22,112,67,163,44,13,233,125,65,208,2,0,52,52,129,132,203,106,165,157,154,158,207,172,168,46,138,50,21,70,98,31,205,40,159,225,187,243,235,160,31,245,229,242,140,189,57,231,217,1,250,237,165,129,19,150,96,246,65,3,174,48,225,173,249,207,209,203,129,3,33,242,248,79,76,86,154,239,158,9,52,146,150,159,25,45,173,128,150,47,19,189,46,200,34,174,2,154,228,221,191,124,184,255,253,161,31,118,37,191,161,37,110,136,132,48,173,9,239,192,54,22,54,171,185,248,217,209,201,229,249,152,102,103,161,101,214,114,182,57,246,252,121,51,40,9,200,128,60,172,98,127,152,246,47,49,216,88,130,63,165,213,205,152,141,156,20,11,64,153,20,82,176,64,144,164,249,178,174,66,57,161,100,181,130,122,36,124,126,200,69,112,89,192,89,203,127,77,167,228,115,143,235,52,155,97,34,16,98,108,142,73,52,161,196,80,136,85,204,124,180,251,210,225,164,38,68,14,51,9,149,141,73,9,141,181,249,180,239,55,105,134,81,160,103,218,22,103,73,21,65,202,3,176,20,112,214,218,224,148,52,161,33,193,111,90,200,129,237,93,14,55,113,90,146,70,115,120,126,32,14,54,122,135,243,185,178,76,115,239,138,184,49,185,245,0,36,133,231,44,184,205,111,183,101,185,55,17,186,237,201,31,10,174,65,27,218,45,176,22,182,38,163,198,49,164,211,10,171,183,70,100,150,141,195,214,217,223,72,176,14,26,62,28,118,185,112,123,21,169,124,214,118,228,182,202,113,96,157,170,14,139,200,200,161,33,113,102,47,168,204,238,174,162,215,41,41,171,115,242,7,190,142,235,172,226,219,64,7,135,150,20,209,198,177,98,98,173,10,209,130,75,71,1,215,39,16,184,65,94,103,153,227,8,62,217,229,254,91,16,202,56,91,33,120,215,9,123,248,175,61,103,203,185,62,127,1,19,185,141,179,116,102,111,248,130,224,235,244,78,224,138,34,189,71,253,155,170,90,238,14,135,125,20,242,255,75,246,240,176,231,201,144,151,156,7,152,96,199,18,58,88,41,168,244,208,82,51,84,9,131,247,196,212,113,245,248,178,222,179,177,206,94,5,58,233,6,93,56,206,104,194,117,194,41,25,214,173,29,34,119,133,232,156,204,82,40,217,71,243,28,206,240,4,10,144,129,21,90,31,218,16,1,234,190,4,151,165,153,172,88,217,155,89,41,123,253,230,211,13,38,224,245,212,85,22,42,201,26,0,24,181,229,167,154,171,202,135,20,123,115,53,193,249,142,114,190,107,75,127,92,150,231,223,115,35,215,220,128,221,179,22,118,4,151,0,3,194,130,255,72,217,94,161,156,16,101,159,196,52,115,83,189,152,204,107,154,2,150,205,89,116,137,16,157,79,255,5,135,166,230,80,48,104,72,29,29,229,0,201,202,172,21,207,232,104,54,11,182,78,82,195,150,86,135,52,14,13,245,212,108,63,198,89,77,187,73,83,48,159,232,13,22,86,201,70,203,166,164,33,82,194,13,124,254,203,248,106,182,105,238,174,164,125,151,31,54,219,162,61,43,250,7,94,133,14,167,136,79,110,154,183,113,160,142,101,181,29,234,134,138,114,180,160,237,37,100,211,65,70,38,210,69,156,18,101,31,148,232,48,232,168,1,84,124,107,182,152,6,143,86,143,179,239,255,63,21,181,36,25,156,187,85,235,217,85,172,208,148,170,95,117,141,146,243,14,168,200,18,168,48,186,122,201,43,216,186,126,201,164,146,229,201,158,125,252,170,92,102,91,180,199,204,212,194,135,161,180,4,78,1,216,255,141,39,165,70,110,213,39,214,128,218,213,2,164,117,41,237,19,14,156,203,34,251,174,103,188,42,199,184,162,16,80,70,124,3,96,8,108,95,129,211,77,128,0,107,196,25,103,49,89,2,182,119,24,169,56,220,150,255,26,129,236,213,250,6,36,118,29,210,160,209,75,19,97,63,102,233,16,88,82,91,59,174,145,40,212,118,87,31,246,251,76,100,6,163,242,61,228,98,231,132,185,120,208,126,68,3,105,104,175,58,58,181,146,102,215,201,59,252,215,24,161,219,72,86,89,134,144,122,97,222,33,124,136,231,115,60,19,210,219,236,215,221,53,132,238,254,213,66,212,185,42,198,248,216,151,222,199,60,255,104,145,163,145,20,105,78,173,233,200,250,222,211,35,218,209,254,246,96,216,36,216,176,97,72,146,101,37,225,64,182,11,215,173,102,54,11,27,12,167,18,169,47,71,51,221,127,180,219,143,178,41,138,217,141,226,118,108,77,174,143,101,198,72,1,14,1,157,203,254,225,169,158,104,136,233,233,136,42,76,148,247,72,13,159,12,232,113,94,105,48,55,79,151,102,201,21,50,143,71,0,58,187,143,49,246,167,26,32,166,152,210,205,55,6,18,94,73,55,43,114,189,18,189,68,119,75,134,221,23,234,135,86,177,166,180,3,167,191,185,53,64,153,135,17,209,7,16,192,220,226,94,43,142,189,141,75,218,93,83,190,207,238,250,83,92,70,162,90,32,171,101,85,68,167,121,66,255,17,189,2,147,179,138,156,198,41,235,174,66,255,125,127,224,194,145,177,56,68,94,141,66,128,250,0,97,193,84,39,59,142,152,138,81,131,131,241,149,66,4,0,8,210,22,51,28,216,100,29,98,88,55,180,13,88,92,115,149,27,162,173,214,121,90,204,176,143,170,125,74,3,170,149,212,138,217,174,195,236,113,161,70,101,164,150,86,236,21,205,40,177,104,201,205,104,186,35,178,50,17,45,116,38,230,48,86,89,152,101,244,183,50,13,91,180,39,96,237,129,192,135,161,122,44,68,107,113,219,123,231,180,233,205,18,141,123,2,121,53,155,168,19,102,189,21,90,191,25,221,252,209,65,109,203,30,52,175,216,214,236,167,67,52,219,66,250,135,52,49,116,23,111,48,224,144,90,30,238,15,229,127,86,239,155,121,18,228,140,178,110,101,77,72,9,186,172,77,194,144,222,123,42,158,119,199,102,68,176,186,103,142,121,203,28,92,100,38,83,149,147,248,75,100,167,125,96,126,37,224,45,218,28,122,251,139,1,58,35,118,243,235,198,39,3,20,121,105,109,55,113,175,5,155,31,71,244,252,247,130,118,105,104,92,200,177,93,11,55,242,223,216,241,119,222,6,49,127,229,237,20,105,142,221,5,144,213,182,190,82,103,223,229,204,151,220,120,0,50,210,111,180,56,157,1,130,164,215,41,160,186,254,202,106,186,66,16,114,55,245,77,150,106,189,167,55,248,96,136,6,191,226,90,179,108,186,170,52,226,73,67,14,103,158,199,218,153,181,130,62,12,107,160,137,8,8,18,208,44,231,82,223,202,179,75,25,76,181,33,111,99,216,131,91,68,9,200,23,215,105,1,253,238,71,14,81,198,129,241,209,153,28,231,125,47,182,249,1,196,169,211,111,117,156,5,124,126,164,84,20,80,81,6,8,82,20,190,174,125,205,192,134,162,211,59,156,212,21,30,39,113,22,147,125,222,224,24,108,172,70,88,64,220,251,33,200,141,80,193,90,44,182,42,133,166,89,127,101,67,149,82,141,174,85,76,139,66,215,91,130,71,163,84,109,166,66,47,185,70,71,188,45,132,158,172,208,203,205,53,218,173,208,109,245,9,27,219,70,157,9,199,67,217,90,217,80,93,137,14,111,94,173,9,148,237,142,151,44,101,213,159,238,137,194,36,230,57,44,229,66,228,187,178,155,145,85,44,61,214,138,188,86,226,212,55,96,48,74,94,129,156,204,90,18,29,215,204,90,70,209,138,112,103,200,105,90,215,210,250,76,111,93,115,254,153,209,157,127,124,207,250,209,157,80,223,55,133,161,62,128,129,151,255,198,253,110,35,65,72,156,30,55,111,230,179,168,166,55,215,214,69,181,143,180,217,62,117,244,170,200,237,76,216,166,10,220,138,208,109,125,58,178,89,93,80,197,229,138,50,254,203,154,160,238,70,156,20,92,10,96,221,177,54,230,152,181,170,50,97,209,215,115,74,122,32,243,131,168,105,234,58,183,104,111,36,184,66,216,181,56,10,237,134,129,45,154,157,148,184,156,54,70,66,141,54,52,190,201,92,236,123,90,221,108,9,142,28,150,251,135,255,172,49,88,40,221,41,15,31,160,194,25,251,190,38,246,192,144,7,93,181,255,183,160,154,160,43,185,144,216,132,207,13,1,243,105,153,148,23,50,217,117,161,237,57,135,22,112,150,141,156,149,135,54,17,206,100,242,223,64,48,249,161,102,227,116,154,157,38,233,122,94,89,92,3,177,62,172,115,136,205,187,206,169,85,35,248,147,65,79,3,233,127,133,240,98,142,188,108,106,185,254,108,134,5,126,241,67,33,163,63,174,167,92,53,253,80,40,199,75,102,127,197,14,180,246,128,159,53,11,28,130,222,23,83,214,198,41,201,239,191,22,112,28,134,214,229,177,47,200,24,6,188,46,220,88,33,3,152,122,174,202,158,18,145,58,110,227,34,231,250,111,139,88,212,17,140,186,163,209,99,195,145,252,122,144,74,33,179,192,131,166,187,127,102,102,48,160,155,3,153,228,215,161,109,81,76,114,18,100,79,137,66,78,16,18,140,7,45,2,240,125,186,163,86,228,109,137,88,165,25,178,156,91,21,62,106,14,178,17,243,231,63,52,125,227,41,88,55,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2e0bb74b-01ca-4a9b-a637-27fd95a2f7c2"));
		}

		#endregion

	}

	#endregion

}


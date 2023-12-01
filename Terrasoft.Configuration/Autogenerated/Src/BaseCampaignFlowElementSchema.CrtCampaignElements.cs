﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCampaignFlowElementSchema

	/// <exclude/>
	public class BaseCampaignFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCampaignFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCampaignFlowElementSchema(BaseCampaignFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b7f88a5b-01f8-4d24-9883-14cb920af36e");
			Name = "BaseCampaignFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,26,203,114,219,56,242,236,169,154,127,192,106,47,84,141,139,246,30,246,18,89,118,217,142,157,209,108,226,100,34,103,115,156,130,72,200,194,154,175,0,160,29,37,229,127,223,6,26,32,1,62,44,121,50,91,155,67,108,130,221,141,126,191,232,130,230,76,86,52,97,228,150,9,65,101,185,86,241,101,89,172,249,93,45,168,226,101,241,243,79,223,127,254,233,160,150,188,184,35,203,173,84,44,159,117,158,1,62,203,88,162,129,101,252,134,21,76,240,164,7,243,150,23,95,122,135,183,27,193,104,10,7,241,45,149,247,178,125,239,243,146,231,101,49,252,70,176,177,243,248,146,230,21,229,119,163,136,241,235,139,209,87,31,68,153,48,169,185,1,136,191,11,118,7,130,145,203,140,74,249,138,92,80,201,28,237,235,172,124,188,202,88,206,10,101,64,143,142,142,200,137,172,243,156,138,237,169,125,214,240,36,209,184,100,93,10,194,190,178,164,86,116,149,193,161,165,66,24,146,144,177,35,113,228,209,168,234,85,198,19,75,97,228,114,242,138,184,83,203,122,192,217,193,119,195,93,43,9,152,73,81,184,240,21,249,32,248,3,85,12,223,87,248,64,18,253,158,72,37,180,106,26,194,84,40,158,240,10,240,110,53,251,55,224,54,100,78,38,3,239,39,179,151,80,123,95,237,162,247,190,154,204,172,4,172,72,81,136,103,36,42,21,184,34,75,17,162,107,18,115,176,164,107,70,86,84,37,27,34,249,55,102,12,147,151,192,101,185,38,95,106,38,182,68,109,43,102,236,209,55,8,8,102,111,176,162,113,48,128,166,248,187,198,188,208,84,151,154,232,156,252,243,248,120,7,223,192,108,197,64,78,214,53,197,48,219,154,44,176,72,137,118,218,204,137,160,74,34,171,140,43,195,58,144,34,143,27,14,47,209,179,157,58,13,95,44,253,221,130,172,25,85,53,120,250,152,132,104,58,45,217,31,206,77,173,59,157,215,41,103,69,210,151,22,128,227,119,188,248,55,205,106,54,235,82,185,220,139,136,206,51,7,7,119,76,217,223,14,248,154,68,123,50,112,66,142,167,14,237,224,129,10,242,160,25,1,190,48,27,248,9,45,134,228,179,100,74,129,126,116,186,82,134,229,232,147,100,2,192,10,204,99,135,150,210,193,100,47,214,39,135,3,46,48,157,89,34,123,235,240,29,85,155,248,29,253,26,25,230,15,65,36,75,226,9,127,8,6,86,43,246,180,9,162,26,204,167,151,184,225,238,248,113,42,33,212,94,76,48,163,21,16,195,59,131,102,71,94,33,243,83,178,132,12,6,124,45,210,248,234,75,77,51,25,165,108,77,235,76,69,111,106,158,78,167,168,139,179,103,83,19,194,188,218,145,112,102,207,9,89,102,117,94,24,153,200,35,87,27,157,37,152,22,250,158,109,9,230,28,69,19,21,47,82,66,33,115,8,126,199,11,154,17,201,116,37,140,201,2,18,131,132,32,4,137,117,128,154,83,146,114,9,94,7,191,36,136,44,221,101,24,172,38,247,28,18,180,50,32,174,182,192,22,131,20,42,216,122,62,1,79,13,12,61,57,58,37,57,83,155,50,221,169,243,7,46,84,173,153,67,221,47,203,90,36,108,105,120,178,98,44,82,148,215,164,225,239,4,98,112,6,76,195,127,79,207,168,232,182,177,58,81,27,106,165,226,133,36,20,92,35,77,185,14,36,184,149,23,235,146,100,188,184,7,78,140,38,155,202,87,181,86,249,1,191,89,0,253,198,119,70,253,234,23,50,209,128,147,103,109,222,115,236,148,42,72,183,70,95,59,146,229,194,33,59,35,181,97,234,78,102,161,68,125,140,222,65,155,17,65,180,30,61,114,118,230,229,199,230,116,78,192,85,186,164,162,169,205,37,114,140,216,28,83,230,204,75,24,131,74,250,200,114,94,232,158,141,212,138,67,221,129,180,1,238,110,10,112,98,234,147,231,179,13,236,39,7,10,94,187,67,145,125,28,242,135,232,157,161,46,177,57,26,192,24,56,10,117,217,167,136,218,28,56,159,147,130,61,14,80,236,169,116,16,119,63,165,54,158,183,97,25,228,226,81,133,58,184,95,13,216,110,101,134,240,173,213,241,217,87,98,7,178,243,56,236,136,246,101,224,134,246,12,149,22,82,233,212,216,49,143,108,40,244,84,183,87,1,51,226,60,167,234,90,8,221,52,103,28,59,190,161,108,36,33,105,145,199,82,220,143,169,23,117,182,184,42,234,156,9,157,95,78,116,109,58,37,46,154,76,21,118,137,20,58,32,38,176,56,180,25,117,76,150,119,38,165,143,245,230,253,156,49,24,235,214,94,221,23,216,6,233,60,173,127,132,38,10,97,186,237,80,3,182,72,15,219,250,220,116,92,238,237,82,55,153,117,198,210,215,154,217,57,9,158,177,31,65,155,219,78,166,123,249,53,148,162,82,108,99,231,253,241,144,116,200,254,212,119,12,167,30,91,36,0,11,107,220,121,198,169,140,76,185,196,234,58,5,79,51,12,68,216,232,83,73,62,85,144,228,217,244,44,70,148,88,243,156,211,182,137,208,222,221,0,99,209,108,128,175,190,86,2,149,17,155,171,94,132,209,94,52,11,165,64,20,45,197,191,152,110,85,245,83,132,108,218,90,20,52,2,206,10,186,235,197,215,160,249,1,184,190,128,179,6,15,120,130,6,203,94,140,142,225,238,13,99,22,37,140,177,91,136,240,150,67,40,173,233,196,189,186,22,101,110,95,76,227,115,233,126,181,111,63,111,152,96,209,16,119,112,9,182,12,211,86,109,129,179,248,60,14,25,127,80,109,246,240,199,213,54,102,56,75,129,106,243,99,233,245,93,111,232,94,68,210,179,141,187,22,20,94,103,89,19,77,86,222,97,37,25,189,155,219,64,237,111,77,87,117,85,40,174,182,218,4,90,223,198,22,94,243,255,167,236,251,215,27,209,200,107,194,51,94,200,27,16,247,189,248,188,225,138,45,245,238,41,218,209,146,78,61,221,180,130,116,181,225,9,78,88,38,93,251,100,20,96,59,110,219,213,15,27,26,95,202,248,26,170,248,197,22,13,184,139,177,217,56,91,215,117,145,152,105,206,231,175,53,145,29,14,227,55,162,172,171,139,173,131,10,24,117,89,3,159,12,71,186,218,238,199,212,211,75,130,7,115,228,71,86,101,180,163,150,207,208,178,47,138,198,176,54,155,210,177,80,194,196,55,15,1,226,203,172,44,116,93,2,254,205,65,27,56,89,224,194,141,125,6,18,232,144,121,122,17,176,51,34,233,64,44,126,9,125,23,184,101,84,68,94,160,14,50,249,183,78,216,34,21,140,141,33,132,41,148,181,8,127,141,97,60,1,67,65,91,32,163,160,101,152,14,58,176,79,217,119,166,151,16,244,157,225,75,99,130,142,23,60,148,60,37,118,87,116,101,86,149,108,151,189,131,174,105,238,178,239,197,214,0,14,106,91,47,132,124,172,203,178,46,116,82,242,207,98,115,216,194,175,188,45,201,94,27,25,239,42,92,137,178,212,221,115,140,239,62,184,115,71,224,60,15,1,112,143,22,117,240,79,250,188,55,30,16,118,127,29,137,150,247,188,234,16,155,198,183,244,158,69,171,238,198,200,232,85,48,64,199,149,157,142,167,125,66,115,72,219,163,114,254,2,237,153,217,35,58,67,7,55,58,236,142,244,128,180,10,85,124,160,55,247,241,107,150,209,109,244,143,227,105,252,153,114,21,249,78,183,127,191,27,108,158,122,147,63,120,214,219,228,219,210,60,224,202,206,190,48,187,113,157,247,14,29,104,230,224,76,54,180,214,113,239,202,4,66,232,155,238,217,91,24,93,16,176,54,93,151,34,167,10,242,74,23,76,198,223,143,159,98,115,241,228,176,115,131,151,205,186,104,182,216,246,200,69,168,188,176,250,198,159,97,228,48,31,99,226,143,12,43,212,18,250,97,122,7,162,121,82,14,138,224,134,41,188,213,109,63,123,160,113,187,160,53,153,205,2,118,82,217,56,186,110,200,161,144,212,130,161,13,204,231,30,154,117,216,5,127,88,91,176,67,178,166,144,202,134,210,80,111,190,243,54,86,58,17,93,10,6,73,233,166,84,124,205,19,179,186,117,38,47,188,51,63,25,53,179,220,188,51,122,250,131,68,228,207,50,147,247,143,32,128,95,55,130,233,168,153,250,237,88,228,46,176,61,96,252,201,27,130,206,107,240,100,177,72,1,181,99,86,59,114,234,211,184,169,215,118,197,220,60,3,90,67,221,48,213,128,44,235,213,127,152,5,241,120,199,151,175,153,76,4,175,244,61,154,103,79,49,254,188,213,223,94,196,168,221,230,69,111,226,27,28,179,156,125,236,52,2,90,93,40,150,123,203,54,137,111,92,223,237,50,146,45,226,158,169,106,164,128,106,182,72,99,67,103,119,153,231,250,208,37,131,72,93,42,86,189,43,83,16,155,165,239,11,136,205,110,69,140,244,240,121,203,115,22,127,82,201,77,249,232,74,34,114,224,202,106,192,168,215,199,134,176,144,112,127,133,162,34,35,227,28,229,35,196,245,189,62,104,118,65,214,181,17,126,143,93,26,248,51,123,96,146,208,102,31,193,83,112,21,45,141,144,100,13,109,56,81,27,55,246,185,17,167,20,206,0,216,25,236,218,157,190,5,210,118,65,209,169,207,88,93,118,77,71,230,86,87,136,220,50,222,154,180,59,205,4,84,244,14,220,206,215,46,74,66,98,225,176,54,68,161,157,208,135,58,163,63,65,45,224,251,201,110,160,26,42,241,111,37,135,30,243,60,77,63,210,226,110,120,200,49,32,205,242,170,69,181,157,188,142,136,29,20,124,200,1,66,203,138,37,124,189,189,41,157,123,201,40,116,47,31,216,150,239,118,21,21,9,189,78,195,148,103,66,193,100,106,180,127,100,135,144,219,82,251,68,52,18,221,238,123,129,249,180,137,33,126,89,230,85,6,209,148,190,32,178,199,179,67,7,57,136,177,38,168,155,43,135,98,90,137,154,77,123,121,160,65,121,81,34,8,98,214,233,115,79,221,248,194,45,21,85,181,28,86,208,33,209,250,135,46,67,131,232,194,179,42,75,253,65,198,227,25,52,102,164,250,203,85,137,87,14,41,196,177,51,245,195,216,231,169,9,219,255,155,113,158,246,53,209,200,87,60,251,73,42,169,165,130,92,154,149,119,60,49,31,252,189,165,186,137,77,239,171,26,47,32,245,155,190,199,84,239,93,217,213,121,4,102,152,238,103,186,102,25,107,69,208,125,214,78,182,173,128,154,109,92,86,175,179,242,209,253,161,136,97,31,51,0,220,238,236,63,194,166,57,169,180,146,205,135,186,249,36,152,17,38,167,200,180,166,200,193,191,188,47,186,37,89,177,118,118,138,79,142,12,145,150,38,138,35,79,111,234,124,197,132,46,92,13,112,56,247,156,28,57,208,103,2,41,24,68,158,153,56,173,18,143,127,76,131,251,234,74,239,98,216,87,53,57,189,133,18,140,127,186,163,219,44,123,252,63,208,73,249,192,132,128,6,160,249,163,18,167,18,59,196,225,35,182,163,154,5,199,138,159,51,2,189,97,234,232,56,100,27,235,33,108,119,161,209,89,4,12,77,151,65,116,142,77,154,103,103,161,193,58,163,32,158,134,135,230,12,254,253,23,177,185,108,182,158,38,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7f88a5b-01f8-4d24-9883-14cb920af36e"));
		}

		#endregion

	}

	#endregion

}

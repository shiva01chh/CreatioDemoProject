﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignBaseEnqueuesFlowElementSchema

	/// <exclude/>
	public class CampaignBaseEnqueuesFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignBaseEnqueuesFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignBaseEnqueuesFlowElementSchema(CampaignBaseEnqueuesFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("556db784-4c2d-40bf-abce-1d90b84ffb63");
			Name = "CampaignBaseEnqueuesFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,87,75,111,35,55,12,62,123,129,253,15,170,183,135,49,96,140,239,73,236,69,226,56,11,3,217,54,221,164,189,22,154,25,142,173,118,70,114,37,141,227,192,200,127,95,234,53,15,123,236,77,22,104,46,177,41,146,250,72,145,31,105,78,75,80,27,154,2,121,2,41,169,18,185,142,231,130,231,108,85,73,170,153,224,31,63,236,63,126,24,84,138,241,21,121,124,81,26,202,203,250,123,219,68,66,60,167,229,134,178,21,63,169,112,123,115,242,232,65,138,20,148,106,206,87,133,72,104,113,113,49,23,101,41,120,124,47,86,43,20,95,30,96,137,111,169,166,71,194,185,40,10,72,13,122,21,127,1,14,146,165,168,131,90,159,36,172,80,74,230,5,85,234,130,4,192,55,84,193,92,86,217,239,201,63,104,118,87,136,231,69,1,37,112,109,141,38,147,9,185,82,85,89,82,249,50,243,223,141,5,73,141,23,146,11,73,208,109,85,80,73,96,7,105,165,105,82,0,1,231,193,157,3,255,175,130,10,20,217,80,169,89,202,54,212,156,104,129,126,1,253,72,200,167,195,0,230,15,163,57,156,204,226,112,245,164,117,247,166,74,10,150,18,154,40,45,105,170,61,132,118,28,11,127,85,43,10,210,68,218,137,109,176,183,241,213,89,193,55,216,0,226,3,76,13,126,214,152,11,200,156,202,97,14,172,96,177,219,48,87,36,68,179,18,136,200,79,198,179,196,103,193,152,8,227,63,10,249,56,230,193,38,96,33,91,38,117,69,11,116,163,73,237,183,129,241,128,47,45,50,50,53,247,232,248,43,221,253,69,139,10,46,207,132,176,228,74,83,158,90,236,122,13,39,193,125,165,156,174,64,190,5,99,159,93,191,16,113,114,120,238,61,139,254,84,32,177,15,185,43,227,209,185,24,130,61,41,176,71,64,158,4,200,182,84,3,89,98,39,145,191,157,234,101,23,185,61,10,222,238,173,6,98,52,58,3,111,64,62,127,38,81,248,60,37,168,227,241,98,155,105,103,17,5,7,136,222,228,86,171,184,235,242,55,100,156,81,8,232,19,240,204,85,95,183,20,191,130,94,139,204,214,161,133,237,78,67,12,137,16,5,89,170,59,73,87,166,146,23,182,235,208,44,26,153,156,62,34,143,224,151,101,70,126,153,146,12,114,90,21,58,250,82,177,44,92,26,220,60,130,97,9,130,208,31,66,91,106,100,17,4,174,177,183,148,59,142,188,22,173,50,6,41,224,35,201,151,17,217,219,172,108,177,229,149,59,158,218,167,244,38,29,93,155,228,129,83,51,204,84,149,200,74,243,2,168,140,58,103,246,227,192,107,68,195,101,54,28,197,215,42,170,235,240,161,161,14,115,118,160,238,65,55,86,205,119,119,137,4,93,73,238,225,90,209,107,55,27,91,193,50,12,64,183,238,81,11,41,133,124,212,84,87,42,90,236,82,216,216,102,135,93,72,128,150,47,254,211,224,192,210,27,249,236,141,48,199,215,38,41,220,103,37,26,141,201,233,66,105,57,106,33,88,102,62,148,87,146,82,157,174,73,27,82,64,52,208,107,41,158,237,99,92,175,86,88,77,24,90,173,22,25,241,61,83,250,170,22,205,200,30,227,25,19,32,175,193,123,43,55,111,40,207,183,208,164,41,79,36,255,180,146,210,208,113,142,36,28,230,131,97,196,220,215,241,137,206,181,18,247,124,106,54,23,21,26,33,91,117,38,201,243,154,97,62,214,84,145,4,128,147,141,27,166,144,197,87,147,96,216,109,245,122,128,24,38,237,246,17,68,103,217,230,124,52,102,216,185,18,51,151,248,23,175,227,186,206,178,119,141,64,66,121,134,238,140,222,26,74,210,96,58,178,56,91,67,75,142,207,132,181,160,84,40,164,211,60,110,37,8,145,150,132,35,81,77,135,237,94,30,206,236,63,27,37,195,201,83,71,104,226,72,160,147,119,235,227,127,123,63,177,197,245,137,101,96,223,239,17,73,171,128,240,122,14,98,31,93,185,29,41,50,172,149,37,78,93,24,26,239,206,154,120,193,85,37,225,246,166,17,69,163,186,189,26,195,24,147,41,245,147,164,92,81,167,181,84,162,176,115,248,30,182,80,196,223,128,102,102,123,99,26,17,251,230,106,51,134,165,207,180,67,182,8,230,7,108,28,8,165,135,98,7,131,190,73,26,251,133,40,234,222,212,208,143,89,33,150,217,248,244,62,81,187,55,120,177,138,112,156,32,206,243,124,215,134,55,246,230,131,159,44,214,49,201,105,161,160,134,209,122,2,151,222,246,27,212,90,158,239,29,94,47,12,196,185,63,246,244,13,87,230,132,166,255,246,250,178,156,26,124,28,145,228,251,105,162,238,61,172,188,204,172,45,184,210,118,151,199,3,74,50,92,240,188,198,206,232,37,29,8,119,245,114,105,187,153,77,13,192,78,15,103,79,184,235,65,88,27,136,23,191,183,107,245,154,234,159,111,90,154,215,45,235,127,252,248,61,198,213,60,226,9,184,66,243,177,156,68,189,91,79,51,252,90,221,229,11,160,143,220,219,181,208,59,215,155,90,117,59,91,108,199,240,157,144,37,213,209,175,195,61,54,233,211,203,6,157,197,102,155,123,197,2,101,5,6,136,44,40,43,78,246,38,217,34,143,14,174,30,189,146,210,206,205,120,56,54,51,247,176,45,92,35,214,69,119,102,21,65,160,157,210,68,111,199,213,25,18,144,224,143,162,184,157,237,144,213,246,18,116,48,232,157,180,43,180,50,252,251,14,126,157,164,211,50,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("556db784-4c2d-40bf-abce-1d90b84ffb63"));
		}

		#endregion

	}

	#endregion

}


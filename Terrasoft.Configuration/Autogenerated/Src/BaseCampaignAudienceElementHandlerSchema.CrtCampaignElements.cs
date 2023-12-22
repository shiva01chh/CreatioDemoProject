﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCampaignAudienceElementHandlerSchema

	/// <exclude/>
	public class BaseCampaignAudienceElementHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCampaignAudienceElementHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCampaignAudienceElementHandlerSchema(BaseCampaignAudienceElementHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("326349f5-a353-47fc-80f8-b6d9a046a25f");
			Name = "BaseCampaignAudienceElementHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,89,91,111,219,54,20,126,118,129,254,7,206,123,145,49,87,65,210,110,197,154,56,129,147,58,109,134,164,25,154,180,125,24,134,129,145,104,155,168,68,121,36,237,198,43,250,223,119,120,21,69,201,118,90,116,192,242,16,216,228,225,185,126,231,66,154,225,146,136,5,206,8,186,37,156,99,81,77,101,122,86,177,41,157,45,57,150,180,98,143,31,125,126,252,168,183,20,148,205,208,205,90,72,82,30,70,223,129,190,40,72,166,136,69,250,138,48,194,105,214,162,121,137,37,110,45,94,82,246,119,189,24,42,80,150,21,235,222,225,36,29,75,201,233,221,82,18,177,145,228,12,151,11,76,103,155,121,56,130,116,178,34,76,190,198,44,47,8,175,169,21,141,35,185,201,230,164,196,104,132,154,7,155,219,112,20,14,239,237,237,161,35,177,44,75,204,215,199,246,59,120,83,98,202,4,42,137,156,87,185,64,211,138,163,18,86,212,170,146,133,151,57,37,12,34,64,10,82,130,50,2,81,134,50,39,198,113,221,11,216,46,150,119,5,205,16,190,19,146,227,76,162,172,192,66,160,83,44,188,206,99,203,115,98,88,90,251,208,11,228,8,66,179,213,193,33,186,184,102,254,244,84,18,126,131,87,100,8,194,122,193,198,89,181,88,195,210,103,109,108,239,71,78,102,16,116,116,78,73,145,139,23,232,119,94,73,192,1,201,205,118,236,12,189,240,6,240,134,170,41,146,115,111,47,154,27,53,82,127,40,180,181,183,112,92,17,88,171,252,69,26,54,41,134,135,91,4,222,130,160,119,23,185,147,169,163,145,201,243,170,200,193,31,66,199,110,167,224,87,75,154,55,79,154,160,43,190,35,196,200,39,77,145,244,199,227,167,63,143,207,207,158,61,57,59,221,223,127,242,236,96,252,235,147,211,253,231,147,39,7,231,231,147,243,253,231,79,39,147,211,95,250,3,171,237,143,132,229,198,129,77,111,130,23,23,132,75,74,148,71,117,160,183,88,55,102,0,22,33,177,130,143,181,240,72,16,130,50,78,166,163,190,209,245,53,41,128,97,127,239,120,163,157,116,133,37,65,33,53,250,107,26,124,59,212,100,6,116,13,170,198,23,85,39,122,189,25,145,246,83,143,19,185,228,172,201,10,157,156,160,164,185,98,60,24,178,74,6,3,45,178,247,69,255,23,53,203,248,228,10,23,75,18,208,126,217,238,219,43,147,130,10,170,218,102,179,235,28,112,49,97,203,146,112,124,87,144,163,45,201,116,140,94,17,121,85,229,116,74,73,30,237,137,100,96,85,93,97,142,178,37,231,176,232,246,64,95,56,217,58,209,44,36,214,114,58,69,209,70,122,193,168,164,184,112,229,8,220,182,44,138,65,228,236,72,100,232,70,165,17,53,60,190,74,163,166,96,171,159,98,38,32,245,2,78,17,239,244,183,138,178,36,210,103,104,148,237,89,90,52,58,118,199,82,72,38,183,107,15,169,93,251,49,220,77,236,137,161,219,28,40,66,183,154,26,32,169,204,28,249,211,110,173,62,50,48,204,210,15,115,194,73,114,175,56,220,167,23,208,148,246,221,206,13,81,77,45,220,58,176,182,119,187,58,157,220,103,100,33,147,208,43,230,192,151,38,204,116,53,1,183,71,149,36,113,229,141,73,42,215,102,89,21,183,16,80,211,224,136,174,164,163,22,57,250,9,217,188,239,215,145,10,137,224,204,59,65,56,148,51,102,154,118,58,9,118,175,48,195,51,168,197,231,148,229,202,230,211,181,98,154,196,130,155,158,104,178,55,192,68,39,218,208,116,82,46,228,26,26,79,72,163,162,25,122,166,179,180,189,91,228,224,45,225,59,150,210,6,125,162,114,142,50,163,58,137,106,50,2,183,170,222,170,138,96,65,133,84,5,209,181,212,13,165,79,175,44,48,199,37,98,96,213,168,239,232,251,199,151,150,67,80,78,183,212,4,85,93,143,246,52,167,70,77,93,85,160,148,177,228,204,105,109,180,21,23,108,90,37,15,46,57,78,49,135,6,48,148,224,108,142,18,29,94,219,72,97,110,136,233,2,216,232,102,101,247,125,70,164,23,66,71,8,234,214,137,137,27,22,58,112,39,42,102,17,241,97,205,210,116,78,101,67,192,52,172,37,65,184,181,165,77,204,13,90,172,76,47,237,74,11,207,35,21,49,254,122,225,89,255,185,97,211,134,182,253,162,38,183,172,108,148,2,180,249,136,189,37,89,197,115,109,134,51,85,213,163,154,197,208,187,120,240,77,205,104,247,220,244,86,103,154,104,128,27,242,0,128,9,40,115,195,98,123,148,4,29,23,36,131,78,149,233,212,0,21,233,10,242,102,251,196,213,202,10,99,103,255,216,57,199,26,238,71,143,6,244,245,105,83,24,132,207,162,7,168,10,76,220,169,230,244,229,199,220,175,233,207,237,158,214,158,232,133,111,104,27,221,254,129,83,85,131,96,204,160,185,190,14,193,20,47,4,84,72,36,171,112,149,19,177,44,30,94,102,112,164,29,184,214,223,161,220,28,215,229,160,200,203,33,75,7,192,22,47,154,171,210,11,179,10,23,142,245,29,175,62,18,102,49,187,131,175,181,183,127,124,75,238,165,99,208,246,199,118,38,5,89,145,2,88,40,240,170,143,15,228,83,99,64,215,81,29,140,247,254,200,215,21,208,216,229,118,154,80,0,61,82,245,238,216,167,176,74,26,211,138,173,78,67,223,131,154,194,47,181,41,218,160,206,178,236,203,46,101,53,243,70,97,118,133,123,212,82,15,26,48,23,242,154,191,36,83,12,200,114,99,72,56,220,68,37,71,143,140,158,97,52,29,246,32,1,37,101,110,86,182,19,97,207,218,185,106,152,117,101,17,62,178,110,0,161,188,196,50,241,222,112,53,240,12,47,194,90,30,77,141,227,60,143,98,213,41,102,104,29,216,174,155,157,9,121,54,39,217,71,129,200,61,196,141,48,161,111,61,22,199,202,205,69,133,115,128,75,230,51,32,117,41,108,51,52,202,91,170,218,202,174,235,159,6,159,22,108,91,247,196,73,255,62,240,179,65,85,62,169,114,82,56,36,138,65,132,169,45,2,194,17,32,22,229,65,160,0,242,131,75,250,49,91,251,217,86,195,41,110,246,131,26,60,205,116,48,109,250,50,251,231,70,47,191,87,87,48,7,188,224,82,62,116,115,232,155,10,186,239,146,229,19,206,43,222,119,104,249,190,216,251,102,240,109,201,236,84,43,60,104,100,204,78,124,94,2,0,69,128,200,169,214,95,65,109,202,171,18,172,170,184,170,114,223,169,79,60,160,71,184,158,218,110,48,54,87,234,46,208,221,126,187,33,170,236,252,166,65,118,19,58,235,130,249,138,87,203,133,232,170,137,122,231,212,227,214,241,182,83,102,30,92,77,93,0,204,219,66,167,9,137,37,111,148,236,153,146,80,215,107,163,74,231,44,173,120,107,234,232,162,232,211,39,189,173,148,220,36,28,117,73,52,21,123,30,186,218,39,131,111,156,160,119,92,11,163,217,185,117,67,180,47,3,214,49,202,176,240,49,38,245,51,185,137,116,44,108,24,54,206,110,29,107,222,42,159,39,224,109,231,173,73,124,123,221,170,185,227,231,107,88,158,191,197,108,70,146,90,64,227,225,200,94,79,45,249,206,27,167,186,243,10,148,175,33,247,244,188,108,32,164,174,156,213,82,162,41,45,164,18,250,192,212,181,199,227,140,221,56,115,197,19,115,199,216,182,73,163,173,153,107,102,27,101,154,13,226,7,56,253,166,58,215,103,147,237,253,167,149,154,141,195,97,114,105,41,173,140,138,24,91,38,117,122,53,91,147,89,75,111,215,11,98,58,210,21,230,31,9,76,45,51,64,148,80,35,145,38,80,251,47,77,140,32,203,124,143,170,211,235,86,21,33,11,38,203,51,134,25,220,16,223,192,120,116,205,63,204,97,56,184,81,191,127,36,246,221,167,215,59,65,125,123,105,236,187,165,23,155,24,29,6,210,231,88,120,199,52,18,72,143,14,55,4,243,108,174,126,6,121,237,232,146,72,95,151,73,105,77,123,74,153,123,246,234,117,231,150,233,234,94,118,237,144,94,71,200,84,198,56,63,215,131,163,155,6,191,108,76,157,144,71,152,70,187,175,182,187,30,176,221,43,79,253,166,195,245,101,219,244,78,148,216,171,55,220,2,89,142,234,235,251,84,255,228,48,64,88,253,82,81,95,42,193,13,232,142,192,213,38,171,22,148,228,27,114,245,143,107,14,70,37,7,131,63,131,119,109,61,228,93,235,95,56,252,27,174,228,235,176,244,227,226,235,30,78,157,127,183,188,255,4,44,93,229,2,107,164,74,30,243,156,168,188,73,238,125,84,157,128,203,106,166,94,233,244,132,98,71,164,174,9,140,220,215,19,142,157,140,12,130,235,224,203,57,175,62,61,112,248,254,143,130,37,240,106,99,172,154,209,241,63,76,109,10,81,105,159,229,155,113,218,252,88,191,59,66,49,199,255,87,152,162,4,132,85,189,17,254,253,11,13,30,11,151,226,29,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("326349f5-a353-47fc-80f8-b6d9a046a25f"));
		}

		#endregion

	}

	#endregion

}


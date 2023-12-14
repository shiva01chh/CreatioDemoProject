﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCampaignAudienceElementSchema

	/// <exclude/>
	public class BaseCampaignAudienceElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCampaignAudienceElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCampaignAudienceElementSchema(BaseCampaignAudienceElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eab6aab2-524d-43a9-968d-e037cbd4562f");
			Name = "BaseCampaignAudienceElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,88,75,79,227,72,16,62,103,164,249,15,45,239,97,29,41,54,228,73,2,76,164,196,78,102,89,105,102,16,12,51,135,213,30,26,187,3,189,235,216,153,238,54,179,17,226,191,111,245,195,175,196,49,32,177,151,69,10,196,221,85,95,87,85,127,245,48,49,94,19,190,193,1,65,95,9,99,152,39,43,225,122,73,188,162,119,41,195,130,38,241,251,119,143,239,223,181,82,78,227,59,116,189,229,130,172,207,118,158,65,62,138,72,32,133,185,251,145,196,132,209,160,144,41,195,174,215,73,92,191,195,200,161,117,215,195,235,13,166,119,7,21,93,127,14,91,176,249,11,35,119,96,3,242,34,204,249,41,154,99,78,50,221,89,26,82,18,7,100,17,145,53,137,133,18,63,58,58,66,231,60,93,175,49,219,78,205,179,217,71,226,30,11,132,55,27,18,135,28,109,48,19,52,160,27,28,11,142,68,130,2,3,234,102,32,71,37,148,63,124,194,97,239,83,18,146,75,150,108,8,19,91,251,51,196,24,125,64,214,50,137,66,194,46,66,171,3,130,173,27,142,239,200,215,237,70,110,21,74,249,170,251,57,17,223,40,167,183,17,233,160,79,68,224,12,206,160,105,176,242,98,251,207,103,206,207,162,112,29,220,147,53,126,35,59,118,65,95,101,209,111,152,47,105,36,8,123,19,83,114,180,87,217,240,134,6,28,56,125,147,222,70,52,64,129,228,101,19,45,209,41,202,118,116,52,115,186,182,30,21,101,11,138,67,170,9,201,199,83,4,167,9,72,62,18,106,137,93,86,171,5,205,21,68,67,0,163,43,10,95,55,198,70,20,131,145,110,174,88,102,114,107,147,33,163,64,30,135,184,96,50,251,246,137,87,225,246,89,131,106,19,87,106,9,186,3,198,8,14,147,56,218,162,143,41,13,101,16,4,14,132,22,190,185,8,1,33,38,63,213,158,109,117,71,243,69,127,52,236,58,227,229,162,231,12,186,195,137,51,246,253,99,103,54,62,238,251,131,209,184,239,251,125,171,109,240,233,3,22,164,106,106,45,151,170,148,61,172,92,175,89,168,169,171,132,218,162,111,179,230,106,89,26,136,132,189,240,118,125,178,194,105,36,180,9,90,19,173,224,115,206,9,216,197,200,234,131,213,64,58,235,104,250,236,253,55,168,219,109,36,251,67,235,169,193,64,239,141,13,83,43,80,149,241,90,209,247,131,197,147,148,5,196,154,94,168,172,128,94,150,172,94,113,200,249,145,194,122,133,207,77,57,172,109,105,75,176,86,235,20,58,9,229,182,94,235,160,56,141,34,253,251,255,21,181,61,232,144,6,226,107,114,69,110,105,28,90,83,159,170,225,0,12,145,237,147,169,85,196,85,218,34,162,17,249,175,80,157,120,51,40,124,7,73,157,238,214,244,82,61,229,205,216,224,253,39,151,217,209,151,89,184,113,46,107,76,71,85,154,41,42,251,218,65,149,145,197,173,150,115,84,246,192,48,4,40,114,11,6,228,20,169,162,85,20,52,101,90,89,165,133,146,162,149,220,108,69,21,164,214,110,17,45,228,118,119,180,124,94,208,10,193,124,73,75,236,110,151,246,158,154,139,153,41,129,148,200,82,166,186,96,3,225,111,98,250,35,37,229,46,5,132,148,113,208,109,68,214,122,72,4,233,234,1,134,255,33,91,178,236,211,121,143,183,30,79,102,35,127,176,156,121,142,55,232,207,156,193,113,127,228,204,188,238,210,25,246,142,103,93,191,63,241,253,249,226,201,82,109,58,235,211,170,185,228,81,126,68,119,68,156,33,46,127,53,165,107,22,220,140,216,133,27,46,186,224,40,137,85,126,137,123,82,206,177,156,31,240,193,209,2,20,196,246,112,6,215,249,55,26,249,94,119,50,60,118,70,203,249,210,25,248,30,248,55,30,143,29,127,225,121,94,111,52,58,238,250,189,58,255,246,88,242,82,63,151,17,190,147,105,12,247,66,3,217,249,212,172,12,169,22,16,174,166,115,202,209,237,22,173,20,71,94,225,200,252,100,56,31,14,231,11,103,180,88,120,206,96,212,27,58,243,238,228,196,153,13,71,189,113,127,220,157,47,134,253,29,71,110,147,36,42,26,245,203,61,208,226,224,131,177,26,97,19,140,87,152,59,25,78,230,75,111,48,119,38,131,217,220,25,120,221,174,51,25,250,125,167,219,27,119,79,122,147,229,241,120,176,107,110,101,56,168,179,246,80,22,193,241,247,73,248,194,105,224,10,102,36,174,134,83,31,11,140,30,112,148,18,110,156,53,185,248,108,191,79,30,224,13,11,8,140,30,18,73,149,205,38,218,102,128,223,36,158,45,191,201,131,192,15,166,254,100,197,73,214,50,183,70,193,72,233,122,194,127,82,17,220,35,179,232,122,41,147,85,78,141,203,6,166,21,0,78,205,164,121,106,138,102,169,6,26,144,143,68,72,94,235,211,204,57,96,14,236,254,125,86,130,108,154,64,51,240,154,2,250,186,67,106,103,199,12,189,92,110,11,216,57,80,249,57,216,195,152,53,128,215,138,108,13,144,161,158,26,79,247,183,158,94,80,216,11,74,62,87,213,191,51,42,128,128,107,160,3,10,11,70,190,116,72,249,41,213,89,117,72,217,41,162,146,101,223,181,216,209,20,9,249,158,86,153,2,116,246,85,57,173,228,51,138,218,5,2,210,231,85,232,92,149,53,2,58,84,250,65,75,232,88,239,115,182,147,247,18,61,49,184,139,245,70,108,15,2,52,49,180,179,199,223,23,65,214,242,177,83,208,180,131,86,56,226,228,176,79,53,202,153,166,46,106,101,3,154,74,239,21,17,41,139,57,34,170,211,101,173,82,222,52,194,113,209,229,131,36,74,215,49,76,63,226,30,133,48,18,64,245,226,36,210,181,9,87,251,236,161,90,166,47,253,129,50,145,226,8,217,166,246,106,29,237,129,89,50,103,122,234,200,75,56,81,135,212,136,194,107,101,27,65,58,229,131,161,50,220,68,63,94,37,182,78,159,27,78,24,204,235,177,254,47,24,74,43,143,25,153,232,10,237,221,174,123,193,85,232,236,118,94,250,152,138,17,178,45,243,126,107,117,144,37,255,87,179,247,190,219,46,165,107,235,1,51,19,35,243,26,124,173,30,236,29,83,244,17,174,246,214,182,56,151,232,50,30,214,238,86,192,137,220,211,14,127,185,253,11,0,192,138,3,82,94,57,136,185,208,146,37,107,187,126,198,105,187,51,174,181,51,225,11,176,145,253,158,80,0,189,222,114,51,229,107,49,176,178,237,126,57,108,147,12,226,15,184,230,204,159,155,146,161,223,239,9,35,185,102,69,90,91,235,94,202,74,65,128,204,123,151,3,119,130,185,9,164,233,92,234,187,187,248,135,4,169,32,215,192,159,136,92,145,32,97,161,105,102,232,195,52,239,107,64,27,125,132,202,162,115,205,183,169,109,194,221,201,110,187,81,118,39,176,29,84,47,175,222,68,236,189,192,100,135,36,169,200,82,32,227,189,102,121,59,79,167,130,210,134,86,134,134,251,251,13,115,191,94,173,46,170,53,249,243,47,208,243,95,187,106,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eab6aab2-524d-43a9-968d-e037cbd4562f"));
		}

		#endregion

	}

	#endregion

}


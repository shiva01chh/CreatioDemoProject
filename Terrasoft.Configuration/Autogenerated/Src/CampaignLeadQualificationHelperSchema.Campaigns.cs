﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignLeadQualificationHelperSchema

	/// <exclude/>
	public class CampaignLeadQualificationHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignLeadQualificationHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignLeadQualificationHelperSchema(CampaignLeadQualificationHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f2f676e-40b7-4360-96fa-f4d67d29da54");
			Name = "CampaignLeadQualificationHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c9b8abc8-8efb-4353-8434-80e2246ec543");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,24,217,110,219,70,240,89,5,250,15,27,22,8,40,64,165,209,3,104,225,67,133,44,219,177,82,37,78,41,187,121,8,130,98,69,142,100,166,36,87,217,37,21,171,169,255,189,179,23,185,164,72,203,245,3,229,157,157,251,38,115,154,129,216,208,8,200,45,112,78,5,91,21,193,148,229,171,100,93,114,90,36,44,39,95,191,253,102,80,138,36,95,147,197,78,20,144,157,180,206,136,158,166,16,73,92,241,212,93,240,10,114,224,73,180,135,115,65,11,90,3,93,53,56,244,193,131,139,243,222,171,43,26,21,140,39,32,122,49,22,209,61,196,101,10,188,198,88,167,108,73,211,227,227,41,203,50,150,7,115,182,94,35,24,239,17,227,59,14,107,233,137,40,165,66,28,147,41,205,54,52,89,231,115,160,241,31,37,77,147,85,18,41,87,93,67,186,1,174,72,142,142,142,200,169,40,179,140,242,221,216,156,245,181,230,66,86,140,147,20,25,144,207,46,135,192,146,30,57,180,31,110,150,130,165,80,128,239,253,18,252,26,252,76,254,37,119,2,12,159,158,168,5,86,201,5,240,109,18,129,118,62,45,32,126,15,203,43,198,51,173,140,55,252,136,2,54,229,50,77,34,195,240,128,117,199,164,231,66,230,9,242,170,156,117,149,64,26,163,183,222,241,100,139,114,245,229,70,31,136,40,144,50,34,28,89,177,60,221,145,25,250,155,252,149,226,227,140,224,191,111,104,78,215,192,81,233,66,6,2,184,239,29,80,203,27,158,24,241,144,199,90,131,166,58,232,29,81,240,82,102,134,84,74,89,172,49,218,161,82,128,89,158,20,9,74,249,7,4,201,225,139,241,77,130,60,104,142,181,114,42,0,3,192,97,117,118,80,177,163,113,80,73,57,106,139,57,221,80,78,51,146,99,17,158,121,165,0,142,106,230,186,94,188,49,6,25,179,165,2,84,210,131,211,35,69,214,205,133,110,54,169,209,224,142,167,222,120,82,159,201,93,56,111,16,155,192,31,48,193,191,107,40,70,154,122,142,48,152,92,86,80,83,240,80,242,31,12,142,201,146,10,240,219,36,45,92,242,245,241,233,232,189,129,226,158,245,102,211,146,177,148,204,132,84,255,138,179,108,78,243,24,21,154,228,241,53,221,2,138,45,176,33,248,175,202,36,86,21,55,139,71,132,149,5,209,0,141,219,128,69,154,2,97,218,6,121,145,228,133,133,135,22,217,216,109,192,151,25,77,164,37,138,166,98,139,249,44,121,6,151,217,166,216,157,168,187,138,125,255,93,168,46,191,255,161,1,84,2,16,172,197,186,84,91,202,137,0,217,103,241,90,102,235,66,29,90,113,51,17,145,45,185,204,114,223,107,119,4,111,68,188,89,236,13,131,137,240,189,185,53,192,107,147,73,47,75,84,147,40,16,79,173,61,134,212,57,183,72,205,141,164,86,198,52,9,12,168,159,38,108,139,8,29,25,50,240,29,54,217,235,215,44,201,125,249,184,221,109,32,152,161,79,56,114,84,182,24,148,65,112,227,88,103,232,149,196,153,184,148,77,186,223,99,157,50,230,176,42,110,202,66,201,177,70,52,68,57,150,53,197,60,229,97,35,234,253,61,112,168,49,27,244,218,115,193,59,89,229,56,52,184,175,147,126,104,105,177,46,14,68,241,45,43,124,201,239,109,153,166,126,131,172,203,3,11,236,229,240,180,6,115,80,217,164,122,176,8,38,152,142,91,48,48,67,61,28,18,42,76,222,234,164,214,99,217,191,56,191,124,128,168,196,182,77,226,101,245,239,25,105,230,118,112,153,139,146,195,197,121,13,242,135,182,24,45,171,153,92,52,66,52,28,219,42,215,63,103,166,110,2,205,25,244,173,95,75,170,153,12,100,11,168,234,90,155,56,203,99,120,64,38,154,155,28,87,55,28,239,85,16,235,2,58,113,24,84,197,127,144,129,19,144,14,6,225,243,57,132,61,44,84,189,61,151,137,41,78,203,230,203,125,146,2,241,13,190,244,154,227,238,102,251,171,121,202,102,231,119,121,176,98,219,232,141,45,194,46,207,237,17,134,45,202,89,94,252,244,163,223,233,179,61,90,219,95,107,234,133,234,180,126,143,191,106,6,75,36,249,219,158,30,245,175,254,209,79,14,69,201,115,242,162,238,246,129,42,20,81,123,99,72,94,190,236,66,168,172,214,210,30,59,7,223,2,75,233,45,251,162,70,220,111,56,0,30,80,115,216,200,49,213,49,162,156,65,183,44,211,191,21,204,78,52,153,29,21,48,148,90,233,144,42,57,28,68,153,202,9,179,66,197,64,155,155,172,136,95,203,11,174,169,248,147,166,37,84,169,240,59,236,20,224,29,77,248,169,148,57,146,50,198,142,228,124,197,144,165,221,64,244,194,49,135,53,141,118,42,126,89,6,113,130,166,166,187,91,158,200,77,240,188,214,25,242,66,182,46,126,190,211,226,125,19,129,187,214,178,225,40,168,181,51,161,114,204,71,21,26,42,5,168,120,27,43,236,64,83,252,12,98,229,159,23,14,99,27,199,58,178,70,250,35,1,244,162,245,83,83,149,246,86,208,214,193,46,6,141,236,210,226,187,178,100,203,48,214,147,56,190,101,214,205,147,50,78,0,55,201,27,46,83,71,113,214,251,81,100,16,100,66,184,251,145,205,167,206,253,168,189,27,61,43,13,109,138,180,19,209,228,85,43,17,53,180,224,59,235,48,153,120,117,226,187,178,246,115,125,47,205,27,41,94,183,45,185,70,125,98,203,106,108,9,179,77,93,36,42,145,112,111,63,213,134,32,151,229,39,204,174,113,221,241,190,18,111,210,92,188,71,164,9,32,143,35,7,121,90,57,26,17,29,183,55,177,156,100,151,104,110,150,116,227,133,45,196,176,23,83,187,203,115,171,163,165,97,53,127,70,117,196,59,81,66,23,103,79,98,99,128,52,195,67,30,109,207,180,205,179,179,15,76,177,189,22,80,101,170,211,19,94,179,165,223,174,246,70,4,109,169,55,171,173,91,204,27,224,107,251,182,128,115,163,42,150,61,9,110,145,180,234,163,213,174,171,49,128,52,69,116,79,252,203,135,8,54,234,37,10,134,70,25,249,214,27,92,114,206,184,92,168,104,225,123,31,14,188,143,5,135,106,249,99,128,142,182,109,238,209,233,8,207,120,189,98,5,154,9,177,237,32,230,72,182,9,47,80,147,170,151,72,213,140,175,106,85,132,251,146,213,40,240,106,206,157,212,176,202,87,117,201,215,57,164,97,29,125,163,158,59,135,94,248,220,119,189,214,107,94,221,193,220,99,88,117,180,129,3,213,221,202,89,110,244,175,211,20,244,92,147,207,113,149,27,243,68,200,81,240,84,190,225,120,155,58,216,231,187,106,101,220,203,184,122,77,48,105,37,91,149,21,37,115,79,92,35,70,170,22,218,169,252,82,161,63,129,41,25,167,211,14,188,177,157,149,178,191,57,159,70,38,124,93,102,56,87,253,246,199,136,81,107,225,30,90,77,86,12,171,83,166,182,171,18,14,249,134,39,106,239,181,166,12,234,107,15,206,200,29,236,143,30,23,209,29,186,131,246,176,113,16,93,131,93,111,47,0,67,27,155,157,161,214,165,218,231,14,142,202,231,52,128,81,99,36,58,3,170,107,235,108,117,139,255,85,177,135,190,100,77,244,71,27,186,194,126,216,243,197,241,57,31,167,116,53,121,227,187,60,249,92,2,73,170,237,139,176,149,98,219,245,97,137,109,129,115,68,53,109,67,105,50,145,138,216,229,77,235,208,213,54,250,123,140,193,59,233,247,146,134,54,129,8,115,255,254,3,230,75,33,151,247,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f2f676e-40b7-4360-96fa-f4d67d29da54"));
		}

		#endregion

	}

	#endregion

}


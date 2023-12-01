﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignEventHelperSchema

	/// <exclude/>
	public class CampaignEventHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignEventHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignEventHelperSchema(CampaignEventHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d219c98d-c27f-4e2c-8c0d-955b5c514de1");
			Name = "CampaignEventHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("dd426a46-db99-4691-be2c-979c875b4586");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,88,89,111,227,54,16,126,246,2,251,31,8,239,139,140,6,74,251,154,11,72,28,103,215,64,146,221,198,94,244,161,40,22,92,105,108,19,145,69,135,164,146,184,139,252,247,14,47,137,186,28,167,5,10,20,205,67,44,82,156,225,28,223,92,202,233,26,228,134,38,64,230,32,4,149,124,161,226,49,207,23,108,89,8,170,24,207,227,49,93,111,40,91,230,147,71,200,213,39,200,54,32,222,191,251,241,254,221,160,144,44,95,146,217,86,42,88,31,55,214,200,35,203,32,209,12,100,252,17,114,16,44,105,157,185,164,138,182,54,175,89,254,80,109,134,66,9,232,219,143,47,47,186,95,133,122,220,208,60,21,44,203,102,32,30,89,18,240,90,102,252,59,205,142,142,198,124,189,198,115,215,124,185,196,109,124,143,39,62,8,88,34,49,25,103,84,202,35,210,105,11,60,118,120,120,72,78,100,177,94,83,177,61,115,107,67,66,22,92,144,39,46,238,201,19,83,43,2,154,78,18,181,162,138,20,18,82,194,114,146,56,158,50,246,140,14,3,78,155,226,123,198,18,146,24,102,157,215,15,126,24,17,74,81,175,24,100,41,202,250,69,176,71,170,192,190,220,216,5,17,64,83,158,103,91,242,85,130,64,251,228,214,71,228,91,81,91,31,247,80,77,209,56,228,91,134,255,78,9,62,162,73,233,18,4,58,88,105,171,129,136,134,129,104,195,145,99,243,1,208,242,70,184,186,164,120,159,84,162,72,20,23,90,94,163,169,187,216,106,221,161,111,212,16,188,46,247,136,104,96,14,6,13,117,80,218,150,126,250,212,91,20,25,12,94,118,107,115,3,106,197,91,134,111,34,195,108,220,129,42,68,46,73,82,6,9,225,11,99,229,45,81,156,72,188,193,67,133,165,248,195,22,12,132,193,71,27,32,118,103,67,5,93,147,28,131,249,116,232,1,53,77,135,103,95,115,246,80,64,192,69,95,164,86,80,154,54,62,57,52,180,21,43,97,133,59,27,215,132,43,154,140,164,222,181,66,158,28,122,154,16,52,215,76,170,147,143,5,75,207,8,154,245,78,43,55,231,51,69,133,50,166,149,250,125,164,223,147,74,96,239,191,128,22,202,195,232,170,28,158,2,190,145,245,203,96,6,90,80,119,210,45,78,73,100,159,70,154,198,62,70,13,88,140,12,245,64,231,170,98,157,71,67,52,152,223,186,18,124,237,48,80,238,253,182,2,1,209,112,92,153,119,20,79,229,228,161,160,89,100,89,196,95,180,41,65,33,126,2,157,156,148,54,217,68,151,23,147,103,72,10,196,60,73,191,151,143,167,205,8,140,39,185,44,4,92,94,84,91,209,200,155,199,243,154,234,12,170,45,139,126,21,246,231,180,102,134,216,94,0,246,76,84,93,88,177,26,60,173,88,6,36,178,244,177,62,25,92,52,24,176,220,89,118,154,90,37,167,121,10,207,120,143,35,64,223,126,22,41,203,209,8,198,128,199,158,208,184,214,81,214,142,235,23,81,155,101,69,89,185,60,62,79,203,163,229,251,23,251,107,127,236,127,139,191,0,43,97,192,118,134,32,50,214,241,151,43,154,96,148,45,208,221,38,44,188,219,8,45,82,6,57,150,69,212,159,87,43,23,61,230,162,127,41,30,67,86,206,20,59,248,24,200,214,152,248,120,124,228,232,143,243,68,33,92,217,159,96,206,157,59,181,52,218,189,0,205,144,60,32,161,35,61,48,148,216,122,136,152,215,88,186,55,198,205,141,42,171,253,237,57,207,204,153,139,237,29,36,92,164,211,52,10,47,113,252,15,154,113,224,189,142,254,26,59,111,205,185,17,190,38,116,39,43,43,148,231,208,148,108,86,73,54,167,98,9,74,142,11,33,144,84,203,89,99,104,249,244,137,246,130,198,82,201,10,243,77,213,213,196,179,135,108,156,49,237,10,124,154,60,39,176,49,137,20,202,192,210,181,39,158,8,193,197,21,23,107,170,34,7,238,225,239,65,225,137,95,119,215,31,71,100,232,72,127,34,195,242,188,197,193,17,249,241,243,75,5,94,131,114,175,24,190,251,229,133,44,40,203,100,60,68,163,5,118,11,114,151,179,157,90,9,254,68,224,184,10,185,157,177,85,74,81,198,74,67,136,238,80,67,7,97,237,195,112,116,36,24,160,214,35,198,3,255,145,112,107,49,177,232,217,67,22,171,101,127,232,238,142,128,157,97,235,86,46,32,28,6,93,165,148,190,96,98,168,218,45,127,141,231,141,8,53,247,237,17,101,205,32,115,245,103,154,99,228,56,238,145,189,240,64,223,23,238,251,91,91,170,245,4,222,46,4,142,177,218,40,144,4,13,142,137,74,247,224,78,203,61,50,254,255,16,103,181,190,239,87,109,179,184,187,167,115,144,121,29,41,111,71,227,35,21,21,20,247,238,217,90,125,151,175,83,163,248,92,186,6,46,104,235,250,168,110,168,184,7,133,61,149,25,73,100,108,232,238,112,48,198,37,124,201,40,222,158,214,153,250,151,123,48,95,208,76,130,163,157,74,141,236,143,130,23,155,87,233,176,144,192,156,173,33,254,170,146,91,254,228,56,88,104,167,159,243,191,73,127,195,83,141,138,125,24,52,173,226,131,91,143,96,165,53,60,191,139,109,219,20,195,241,28,75,203,208,161,196,52,204,70,133,106,93,107,183,235,229,216,31,158,183,26,112,203,244,205,109,184,227,114,158,167,158,199,45,60,43,219,149,236,226,225,112,26,210,143,226,91,174,240,255,228,25,123,77,233,107,247,171,168,237,156,53,234,211,70,77,247,201,60,56,228,180,159,24,201,75,96,247,139,93,70,66,201,193,104,62,105,185,196,115,104,123,107,164,107,176,213,200,166,119,27,160,241,108,3,9,91,108,111,249,53,79,238,63,97,135,44,253,40,230,26,113,89,209,188,45,77,51,4,26,86,132,42,79,155,246,187,221,70,236,155,164,173,32,67,155,212,186,10,65,127,30,156,175,116,243,175,235,147,149,175,39,37,134,37,108,239,146,22,213,106,111,152,2,89,200,206,38,194,90,241,236,73,135,83,52,83,3,65,238,13,182,185,85,30,244,200,9,178,23,110,133,73,73,3,160,204,48,184,8,210,69,176,50,193,126,224,129,213,19,208,181,114,95,199,71,168,229,219,190,173,4,31,137,246,237,61,229,142,230,179,7,71,238,251,83,199,200,36,247,254,100,97,59,170,158,239,30,173,22,27,161,9,84,79,17,181,177,153,249,153,182,156,27,130,193,107,176,199,48,215,209,177,249,158,190,156,91,186,198,147,222,249,164,111,64,57,207,50,171,94,48,144,252,211,137,164,246,61,0,53,240,235,246,124,18,124,11,232,64,146,219,11,183,112,7,255,254,2,154,26,56,200,253,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d219c98d-c27f-4e2c-8c0d-955b5c514de1"));
		}

		#endregion

	}

	#endregion

}


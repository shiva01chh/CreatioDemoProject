﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignAudienceFactorySchema

	/// <exclude/>
	public class CampaignAudienceFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignAudienceFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignAudienceFactorySchema(CampaignAudienceFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1969ebeb-1f14-4d32-81f5-ef1b7016c38c");
			Name = "CampaignAudienceFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,86,75,111,219,56,16,62,171,64,255,195,52,189,56,64,96,223,215,177,139,194,105,130,96,177,109,209,244,86,20,1,67,141,109,110,41,82,32,41,167,222,69,254,123,135,15,189,44,43,113,177,88,95,100,13,231,245,205,124,51,162,98,5,218,146,113,132,175,104,12,179,122,237,166,43,173,214,98,83,25,230,132,86,175,95,253,251,250,85,86,89,161,54,112,183,183,14,139,249,193,59,233,75,137,220,43,219,233,13,42,52,130,183,58,93,183,69,161,21,157,208,217,91,131,27,210,135,15,170,42,254,128,21,43,74,38,54,234,125,149,11,84,28,175,152,99,119,186,50,28,131,242,108,54,131,75,91,21,5,51,251,101,122,247,134,240,40,220,22,220,22,65,10,235,64,175,193,86,101,169,141,195,28,114,114,97,131,11,59,173,93,204,58,62,202,234,65,10,14,232,221,60,23,62,243,232,179,43,92,179,74,186,90,225,194,203,238,208,90,130,128,121,45,37,225,83,4,135,42,143,248,122,88,87,146,89,59,4,123,205,184,211,102,63,138,52,157,195,90,27,224,6,153,67,224,201,5,176,228,3,44,169,224,115,64,45,50,73,101,225,62,135,241,20,60,90,143,173,78,249,90,160,204,41,231,207,70,236,40,112,60,44,227,11,197,36,130,112,216,105,73,79,137,99,94,225,94,40,82,37,193,252,136,53,1,202,181,146,123,208,15,127,19,135,224,222,238,21,191,77,6,159,162,108,1,10,31,147,194,228,188,231,165,9,126,37,2,1,9,244,229,120,59,47,224,186,82,124,160,16,249,126,1,183,135,7,203,37,220,231,141,181,157,167,226,244,219,219,246,151,248,239,76,229,65,143,149,108,164,68,147,115,8,52,203,110,149,112,141,44,0,125,122,62,230,103,163,75,52,78,160,143,24,58,29,207,15,137,20,4,119,52,143,18,29,153,213,29,241,51,227,231,103,29,99,78,27,211,46,131,26,10,197,142,141,181,185,110,90,130,178,65,151,254,101,98,13,147,134,4,176,160,118,86,82,214,144,179,76,106,254,131,20,134,141,111,85,94,114,145,101,157,195,192,150,209,74,207,107,147,167,244,39,61,211,195,160,171,140,58,224,108,60,124,161,21,127,161,219,234,209,97,25,39,37,124,65,171,229,174,35,153,28,39,40,240,240,168,81,199,183,233,106,139,252,199,123,179,169,10,84,238,35,85,101,114,22,79,206,18,84,95,186,164,155,86,214,109,14,111,22,144,199,157,54,185,169,68,126,222,148,50,225,31,79,119,58,216,123,157,18,157,96,126,176,74,79,33,121,91,217,151,24,238,231,71,48,41,254,161,85,151,56,29,63,18,9,108,248,44,64,231,187,48,206,246,157,22,57,244,230,17,22,203,158,32,80,112,254,95,178,161,141,94,26,164,55,65,229,4,83,201,209,164,130,164,100,134,21,160,232,139,189,56,107,237,218,218,218,179,229,87,26,230,188,89,133,49,218,32,196,229,44,120,122,22,237,105,251,52,114,230,183,151,234,209,228,107,10,118,55,46,13,243,81,221,24,247,221,187,48,234,255,215,234,175,151,203,183,223,25,134,239,148,114,156,54,79,23,159,94,163,114,232,38,77,229,249,197,9,113,14,166,102,24,101,204,121,90,110,221,49,59,202,213,85,188,89,164,175,176,191,107,20,76,137,178,146,225,18,120,228,198,241,192,44,17,202,31,197,60,34,59,13,174,19,65,211,18,154,45,79,101,116,50,88,82,75,28,163,245,75,83,98,185,17,101,136,31,46,63,131,28,194,109,166,71,231,224,53,46,33,235,61,209,133,137,80,117,63,119,67,47,17,51,185,169,237,58,115,49,224,5,220,160,27,212,250,164,125,189,99,6,90,106,255,137,123,234,225,112,245,39,155,118,117,191,233,206,195,180,46,14,153,79,122,206,218,13,238,182,70,63,6,78,144,248,163,118,215,186,82,249,135,159,28,67,37,235,15,96,111,93,119,67,124,235,185,253,222,75,232,248,158,14,210,193,181,151,164,221,223,47,144,201,146,218,104,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1969ebeb-1f14-4d32-81f5-ef1b7016c38c"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignAudienceConfigSchema

	/// <exclude/>
	public class CampaignAudienceConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignAudienceConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignAudienceConfigSchema(CampaignAudienceConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("639d6364-2acb-4af6-9f5a-465dfd23757f");
			Name = "CampaignAudienceConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,148,205,110,219,48,12,199,207,41,208,119,32,186,75,11,12,246,125,73,58,12,30,176,245,50,4,72,247,0,154,68,219,194,108,201,211,199,178,34,232,187,143,146,101,199,54,210,52,57,69,252,248,145,127,138,178,98,45,218,142,113,132,103,52,134,89,93,186,172,208,170,148,149,55,204,73,173,110,111,142,183,55,43,111,165,170,96,255,98,29,182,235,241,60,77,49,72,118,242,124,48,88,81,26,20,13,179,246,19,20,172,237,152,172,212,23,47,36,42,142,61,59,70,230,121,14,27,235,219,150,153,151,199,116,142,89,112,168,37,175,129,107,229,152,84,22,58,102,168,75,135,198,66,169,13,112,131,204,33,240,68,6,150,208,96,29,117,145,13,228,124,130,238,252,175,70,114,224,145,254,86,75,171,99,108,235,164,64,43,235,140,231,68,37,33,187,136,232,35,150,157,71,195,46,213,56,101,101,99,108,190,12,222,68,77,160,72,215,246,206,91,52,84,76,33,15,3,191,123,124,34,2,11,130,116,9,174,70,8,254,192,77,1,217,38,143,217,231,97,195,88,158,4,129,4,42,39,75,73,233,9,53,104,191,204,176,104,45,21,10,136,125,255,23,228,136,202,224,59,179,32,176,100,190,113,240,151,53,30,97,98,248,230,165,232,173,179,26,233,6,206,207,254,254,231,108,2,48,31,200,199,158,121,18,150,12,99,151,176,29,170,223,7,199,195,3,132,149,93,173,22,212,237,130,187,142,65,251,9,101,36,246,174,98,172,72,190,83,249,232,124,77,187,130,74,244,235,50,223,157,157,209,29,26,39,241,154,205,41,134,69,95,52,28,150,253,143,71,67,148,55,86,41,77,117,145,183,56,30,161,66,183,134,215,11,29,156,187,229,31,136,226,154,7,23,67,14,218,252,134,129,118,144,174,30,102,137,34,60,95,39,185,236,152,114,196,51,186,5,75,20,214,188,35,42,222,241,233,118,174,80,49,220,215,84,198,251,37,38,183,124,69,141,103,217,38,197,225,19,117,160,197,239,26,166,130,204,113,60,248,15,185,143,15,245,98,241,175,52,211,64,251,60,118,176,231,53,10,223,160,8,174,161,25,59,233,104,177,109,189,117,110,36,27,253,254,3,196,58,59,9,214,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("639d6364-2acb-4af6-9f5a-465dfd23757f"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignCreateLeadProcessHelperSchema

	/// <exclude/>
	public class CampaignCreateLeadProcessHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignCreateLeadProcessHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignCreateLeadProcessHelperSchema(CampaignCreateLeadProcessHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c1f6025-2ed1-42c2-928b-a879e96e8221");
			Name = "CampaignCreateLeadProcessHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,223,111,155,64,12,126,102,210,254,7,139,190,36,18,130,189,151,34,77,217,214,177,85,85,165,116,219,227,116,1,39,187,13,238,144,239,104,21,69,249,223,103,56,126,133,210,13,129,56,238,62,127,182,63,219,40,81,162,169,68,134,240,136,68,194,232,189,13,55,90,237,229,161,38,97,165,86,112,122,251,198,171,141,84,7,216,30,141,197,242,122,246,205,240,162,192,172,193,154,240,22,21,146,204,70,204,148,149,240,181,253,112,155,253,194,188,46,144,24,193,152,170,222,21,50,3,99,57,132,12,178,66,24,3,27,81,86,66,30,212,134,80,88,188,67,145,63,144,206,208,152,207,88,84,72,109,156,94,243,84,36,159,24,1,25,7,100,153,131,26,127,189,117,99,215,50,104,250,162,119,247,156,253,131,176,22,73,193,13,248,11,160,159,167,119,103,255,186,167,142,162,8,98,83,151,165,160,99,210,111,92,245,23,204,222,221,2,134,29,152,157,135,3,103,52,39,141,43,65,162,4,197,1,222,248,181,65,226,162,40,167,178,159,188,240,120,181,184,19,198,81,203,178,76,90,112,146,91,139,85,154,251,73,154,183,118,224,79,88,252,127,155,91,65,7,180,169,218,235,177,254,147,200,58,18,232,152,155,175,113,61,13,115,20,99,234,238,178,1,158,180,204,193,213,125,90,162,213,183,11,93,224,82,166,0,110,107,54,27,211,12,32,253,168,234,18,73,236,10,140,191,226,241,187,40,106,46,191,164,184,65,58,124,146,192,82,102,107,215,94,94,215,77,230,168,178,174,125,184,111,220,102,248,73,83,41,236,234,191,157,230,28,133,247,248,220,188,87,235,117,219,94,222,7,217,122,226,38,136,29,97,0,122,247,155,221,39,208,234,130,108,107,216,155,194,103,120,29,187,234,35,245,78,224,223,141,37,14,38,66,192,57,24,32,143,75,101,12,22,53,128,115,107,117,118,225,190,175,170,97,104,135,241,77,203,18,115,201,101,234,70,147,19,95,77,180,10,198,17,243,39,235,23,19,205,135,46,192,203,138,134,63,52,253,105,127,86,161,99,155,29,111,106,34,84,182,233,138,14,48,10,231,68,110,50,224,135,239,233,245,23,35,228,108,160,4,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c1f6025-2ed1-42c2-928b-a879e96e8221"));
		}

		#endregion

	}

	#endregion

}


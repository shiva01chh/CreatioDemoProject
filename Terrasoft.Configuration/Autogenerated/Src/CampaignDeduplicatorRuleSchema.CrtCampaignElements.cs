namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignDeduplicatorRuleSchema

	/// <exclude/>
	public class CampaignDeduplicatorRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignDeduplicatorRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignDeduplicatorRuleSchema(CampaignDeduplicatorRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("078983fb-8c59-4207-a217-01b1057fd97c");
			Name = "CampaignDeduplicatorRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,106,195,48,16,60,39,144,127,24,200,61,190,55,165,23,183,148,94,74,104,154,15,80,172,181,45,176,36,87,187,58,152,208,127,175,164,60,72,75,9,209,65,72,179,187,51,179,43,57,101,137,71,213,16,62,41,4,197,190,149,85,237,93,107,186,24,148,24,239,22,243,195,98,62,139,108,92,135,237,196,66,118,189,152,39,100,25,168,75,97,212,131,98,126,64,173,236,168,76,231,158,73,199,113,48,141,18,31,62,226,64,37,183,170,42,60,114,180,86,133,233,233,116,207,65,104,37,10,214,107,26,32,189,18,24,70,100,210,216,79,104,78,132,208,87,140,160,129,44,57,225,213,153,181,186,162,29,227,62,229,161,201,142,110,24,154,29,138,169,75,7,155,224,71,10,98,40,181,177,41,20,199,248,95,215,5,216,57,243,21,9,70,39,23,166,53,20,224,91,228,179,76,224,166,39,171,86,151,218,107,111,103,115,175,209,104,188,148,252,109,73,223,189,105,28,208,145,172,193,121,251,190,33,190,81,210,67,60,26,63,68,235,242,169,53,78,227,220,32,113,26,220,109,121,150,144,31,178,46,4,133,238,94,237,247,244,81,208,166,39,144,158,16,210,32,239,18,42,85,255,72,44,201,233,227,248,203,253,136,254,6,11,150,215,15,104,21,53,57,163,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("078983fb-8c59-4207-a217-01b1057fd97c"));
		}

		#endregion

	}

	#endregion

}


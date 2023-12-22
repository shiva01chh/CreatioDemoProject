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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,106,195,48,16,60,39,144,127,24,200,61,190,55,165,23,183,148,94,138,105,154,15,80,172,181,45,176,36,87,187,58,152,208,127,175,172,60,112,75,9,209,65,72,179,187,51,179,43,57,101,137,7,85,19,62,41,4,197,190,145,77,233,93,99,218,24,148,24,239,86,203,227,106,185,136,108,92,139,221,200,66,118,187,90,38,100,29,168,77,97,148,189,98,126,64,169,236,160,76,235,158,73,199,161,55,181,18,31,62,98,79,57,183,40,10,60,114,180,86,133,241,233,124,159,130,208,74,20,172,215,212,67,58,37,48,140,200,164,113,24,81,159,9,161,103,140,160,158,44,57,225,205,133,181,152,209,14,241,144,242,80,79,142,110,24,90,28,179,169,107,7,85,240,3,5,49,148,218,168,50,197,41,254,215,117,6,246,206,124,69,130,209,201,133,105,12,5,248,6,211,89,70,112,221,145,85,155,107,237,220,219,197,220,107,52,26,47,57,127,151,211,247,111,26,71,180,36,91,240,180,125,223,16,175,148,116,16,143,218,247,209,186,233,212,24,167,113,105,144,56,13,238,182,60,75,152,30,178,204,4,153,238,94,237,247,244,81,208,164,39,144,142,16,210,32,239,18,202,85,255,72,172,201,233,211,248,243,253,132,254,6,51,54,95,63,128,135,199,13,171,2,0,0 };
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


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,106,195,48,16,60,39,144,127,24,200,221,190,55,165,23,183,148,94,74,104,154,15,80,172,181,45,176,36,87,187,58,24,211,127,175,172,60,72,75,9,209,65,72,179,187,51,179,43,57,101,137,7,85,19,62,41,4,197,190,145,162,242,174,49,109,12,74,140,119,171,229,180,90,46,34,27,215,98,55,178,144,221,172,150,9,89,7,106,83,24,85,175,152,31,80,41,59,40,211,186,103,210,113,232,77,173,196,135,143,216,83,206,45,203,18,143,28,173,85,97,124,58,221,231,32,180,18,5,235,53,245,144,78,9,12,35,50,105,28,70,212,39,66,232,43,70,80,79,150,156,112,113,102,45,175,104,135,120,72,121,168,103,71,55,12,45,166,108,234,210,193,54,248,129,130,24,74,109,108,51,197,49,254,215,117,6,246,206,124,69,130,209,201,133,105,12,5,248,6,243,89,70,112,221,145,85,197,165,246,218,219,217,220,107,52,26,47,57,127,151,211,247,111,26,19,90,146,13,120,222,190,111,136,111,149,116,16,143,218,247,209,186,249,212,24,167,113,110,144,56,13,238,182,60,75,152,31,178,202,4,153,238,94,237,247,244,81,208,164,39,144,142,16,210,32,239,18,202,85,255,72,172,201,233,227,248,243,253,136,254,6,51,150,214,15,207,218,204,57,162,2,0,0 };
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


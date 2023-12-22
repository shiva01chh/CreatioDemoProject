namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICampaignFragmentSyncManagerSchema

	/// <exclude/>
	public class ICampaignFragmentSyncManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICampaignFragmentSyncManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICampaignFragmentSyncManagerSchema(ICampaignFragmentSyncManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f487be7-70f8-43c3-96b8-4b744c2ea4c4");
			Name = "ICampaignFragmentSyncManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,193,78,227,48,16,61,83,169,255,48,42,23,144,80,115,135,210,75,17,82,15,72,72,44,31,48,117,38,137,165,120,28,102,108,160,32,254,29,199,45,109,3,236,238,133,35,190,68,158,25,191,121,239,141,29,70,71,218,161,33,248,67,34,168,190,10,211,133,231,202,214,81,48,88,207,227,209,235,120,116,20,213,114,61,40,17,186,24,143,82,230,88,168,78,101,176,228,64,82,37,160,115,88,46,208,117,104,107,190,22,172,29,113,184,91,179,185,65,198,154,36,159,41,138,2,102,26,157,67,89,207,183,251,43,82,35,118,69,10,85,100,211,119,198,214,134,53,84,94,192,108,241,160,67,9,214,216,14,57,40,104,66,109,196,179,125,201,68,97,11,20,26,12,96,21,140,119,46,69,251,243,181,248,216,129,175,246,64,106,26,114,8,212,82,207,79,225,201,134,6,232,33,98,251,5,182,245,181,53,211,15,214,197,1,237,46,174,90,107,192,126,40,255,143,240,163,215,44,126,231,216,13,133,198,151,122,14,183,25,103,147,252,108,77,14,220,237,40,37,123,190,55,163,151,249,212,88,211,236,243,213,150,132,66,131,37,172,136,24,232,153,76,12,84,78,119,173,138,207,189,102,9,22,29,112,186,23,151,147,168,36,233,54,48,229,129,76,230,75,214,128,156,148,38,47,103,74,4,70,168,186,156,220,15,203,138,57,152,22,85,167,179,34,131,125,143,189,247,153,202,133,143,28,38,243,252,233,177,15,115,3,157,3,200,71,111,203,67,111,78,134,60,96,200,254,12,18,215,126,88,240,165,243,233,197,63,204,191,246,146,4,235,239,8,254,58,130,236,208,79,206,225,152,184,220,60,146,188,127,219,252,104,6,193,28,59,92,239,137,28,218,1,201,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f487be7-70f8-43c3-96b8-4b744c2ea4c4"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignTimerFlowElementSchema

	/// <exclude/>
	public class CampaignTimerFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignTimerFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignTimerFlowElementSchema(CampaignTimerFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a2be9fb0-f9e2-400e-a7f9-206a3251c665");
			Name = "CampaignTimerFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,143,77,10,194,48,16,133,215,13,244,14,3,238,155,189,136,155,80,79,208,11,76,227,52,4,242,71,126,80,17,239,110,99,42,234,194,217,189,97,190,121,239,57,180,148,2,74,130,137,98,196,228,151,60,8,239,22,173,74,196,172,189,235,217,189,103,61,235,118,145,212,42,65,24,76,105,15,2,109,64,173,220,164,45,197,147,241,151,209,144,37,151,95,183,156,115,56,164,98,45,198,219,113,211,227,149,100,201,56,27,130,92,25,160,6,0,102,144,219,179,225,205,242,47,56,148,217,104,9,178,250,254,181,133,79,162,159,48,93,11,255,104,21,200,157,91,139,42,215,93,157,39,243,91,236,244,1,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2be9fb0-f9e2-400e-a7f9-206a3251c665"));
		}

		#endregion

	}

	#endregion

}


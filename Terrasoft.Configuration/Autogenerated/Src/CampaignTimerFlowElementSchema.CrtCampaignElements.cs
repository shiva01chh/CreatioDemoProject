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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,143,77,10,194,48,16,133,215,45,244,14,3,238,155,189,136,155,80,79,208,11,76,227,52,4,242,83,38,9,42,226,221,109,76,69,93,56,187,55,204,55,239,61,143,142,226,130,138,96,36,102,140,97,78,189,12,126,54,58,51,38,19,124,215,222,187,182,107,155,29,147,94,37,72,139,49,238,65,162,91,208,104,63,26,71,124,178,225,50,88,114,228,211,235,86,8,1,135,152,157,67,190,29,55,61,92,73,229,132,147,37,72,133,1,170,0,96,2,181,61,235,223,172,248,130,151,60,89,163,64,21,223,191,182,240,73,244,19,166,169,225,31,181,2,249,115,109,81,228,186,91,231,9,58,210,132,55,0,1,0,0 };
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


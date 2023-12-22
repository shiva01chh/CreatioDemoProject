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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,143,77,10,194,48,16,133,215,13,244,14,3,238,155,189,136,155,80,79,208,11,76,227,52,4,242,83,242,67,21,241,238,54,166,98,93,56,187,55,204,55,239,61,135,150,226,140,146,96,160,16,48,250,41,117,194,187,73,171,28,48,105,239,90,246,104,89,203,154,67,32,181,74,16,6,99,60,130,64,59,163,86,110,208,150,194,197,248,165,55,100,201,165,247,45,231,28,78,49,91,139,225,126,222,116,127,35,153,19,142,134,32,21,6,168,2,128,9,228,246,172,251,176,124,7,207,121,52,90,130,44,190,127,109,225,155,232,39,76,83,195,63,107,5,114,215,218,162,200,117,183,159,23,142,64,173,79,9,1,0,0 };
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


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignStartEventFlowElementSchema

	/// <exclude/>
	public class CampaignStartEventFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignStartEventFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignStartEventFlowElementSchema(CampaignStartEventFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b2c0d06b-bc9a-4a03-b964-92f201a1b9c3");
			Name = "CampaignStartEventFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,79,203,14,130,48,16,60,67,194,63,108,226,29,238,198,120,33,248,3,250,3,75,187,96,147,62,72,187,85,137,241,223,173,128,1,47,238,105,103,178,179,51,99,209,80,24,80,16,92,200,123,12,174,227,178,118,182,83,125,244,200,202,217,34,127,22,121,145,103,59,79,125,130,80,107,12,97,15,53,154,1,85,111,207,140,158,155,27,89,62,105,119,111,52,153,180,78,130,170,170,224,16,162,49,232,199,227,130,155,7,137,200,216,106,2,177,60,0,154,53,192,87,100,64,41,3,8,103,25,5,7,96,183,158,97,148,138,108,202,217,142,16,18,129,186,252,154,84,27,151,33,182,90,9,16,159,148,255,67,194,90,226,39,122,150,250,102,175,185,51,89,57,215,254,192,137,219,206,27,160,55,65,117,60,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b2c0d06b-bc9a-4a03-b964-92f201a1b9c3"));
		}

		#endregion

	}

	#endregion

}


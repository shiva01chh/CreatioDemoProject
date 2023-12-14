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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,79,73,14,194,48,12,60,183,82,255,96,137,123,123,71,136,75,85,62,0,31,112,19,183,68,202,82,37,14,80,33,254,78,186,160,194,5,159,60,35,143,103,198,162,161,48,160,32,184,144,247,24,92,199,101,237,108,167,250,232,145,149,179,69,254,44,242,34,207,118,158,250,4,161,214,24,194,30,106,52,3,170,222,158,25,61,55,55,178,124,210,238,222,104,50,105,157,5,85,85,193,33,68,99,208,143,199,21,55,15,18,145,177,213,4,98,125,0,180,104,128,175,200,128,82,6,16,206,50,10,14,192,110,59,195,40,21,217,148,179,29,33,36,2,117,249,49,169,190,92,134,216,106,37,64,76,41,255,135,132,173,196,79,244,44,245,205,94,75,103,178,114,169,61,193,153,155,230,13,32,222,31,126,52,1,0,0 };
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


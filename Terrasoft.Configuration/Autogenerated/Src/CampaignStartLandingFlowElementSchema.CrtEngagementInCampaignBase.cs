namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignStartLandingFlowElementSchema

	/// <exclude/>
	public class CampaignStartLandingFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignStartLandingFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignStartLandingFlowElementSchema(CampaignStartLandingFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("61400b6c-6c0b-7653-fe9c-14375ff174b0");
			Name = "CampaignStartLandingFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,143,177,14,194,48,12,68,231,86,234,63,88,98,167,59,66,44,85,153,216,224,7,220,196,45,145,18,167,74,28,1,66,252,59,165,45,106,153,240,118,39,159,253,142,209,81,236,81,17,92,40,4,140,190,149,109,229,185,53,93,10,40,198,115,145,63,139,188,200,179,77,160,110,144,80,89,140,113,7,21,186,30,77,199,103,193,32,39,100,109,184,59,90,127,171,45,57,98,25,35,101,89,194,62,38,231,48,60,14,179,174,239,164,146,96,99,9,212,124,2,104,202,128,92,81,0,181,142,160,60,11,42,137,32,126,89,195,164,13,241,64,218,60,32,14,6,218,237,247,73,185,250,210,167,198,26,5,234,195,249,15,19,150,34,63,240,217,208,57,123,77,189,137,245,84,253,35,71,111,61,111,192,27,186,56,64,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("61400b6c-6c0b-7653-fe9c-14375ff174b0"));
		}

		#endregion

	}

	#endregion

}


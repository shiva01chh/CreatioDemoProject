namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignStartSignalFlowElementSchema

	/// <exclude/>
	public class CampaignStartSignalFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignStartSignalFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignStartSignalFlowElementSchema(CampaignStartSignalFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("823b00f3-7d8f-4414-a5d0-9dfbf7ad3656");
			Name = "CampaignStartSignalFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,143,77,10,131,64,12,133,215,10,222,33,208,189,238,75,233,70,236,5,218,11,196,153,168,3,243,35,51,25,172,148,222,189,254,21,237,170,89,229,133,36,239,123,22,13,133,30,5,193,131,188,199,224,26,206,75,103,27,213,70,143,172,156,205,210,87,150,102,105,114,242,212,78,18,74,141,33,156,161,68,211,163,106,237,157,209,243,125,106,80,223,180,27,42,77,134,44,47,23,69,81,192,37,68,99,208,143,215,77,87,79,18,145,177,214,4,98,251,0,180,222,192,208,41,209,1,74,9,194,89,70,193,1,216,237,107,24,165,34,59,129,214,35,132,197,48,255,154,20,7,151,62,214,90,9,16,51,230,31,74,216,99,252,176,39,107,226,247,154,155,172,92,163,207,114,153,29,235,3,73,31,246,177,64,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("823b00f3-7d8f-4414-a5d0-9dfbf7ad3656"));
		}

		#endregion

	}

	#endregion

}


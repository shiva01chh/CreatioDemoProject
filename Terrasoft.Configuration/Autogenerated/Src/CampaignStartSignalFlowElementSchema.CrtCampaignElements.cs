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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,143,77,10,131,64,12,133,215,10,222,33,208,189,238,75,233,70,236,5,236,5,226,76,212,129,249,145,153,12,86,74,239,94,255,138,237,170,89,229,133,36,239,123,22,13,133,1,5,193,157,188,199,224,90,206,75,103,91,213,69,143,172,156,205,210,103,150,102,105,114,242,212,205,18,74,141,33,156,161,68,51,160,234,108,205,232,185,158,27,212,55,237,198,74,147,33,203,235,69,81,20,112,9,209,24,244,211,117,215,213,131,68,100,108,52,129,216,63,0,109,55,48,246,74,244,128,82,130,112,150,81,112,0,118,199,26,70,169,200,206,160,205,4,97,53,204,63,38,197,151,203,16,27,173,4,136,5,243,15,37,28,49,126,216,147,45,241,107,203,77,86,110,209,23,185,206,150,122,3,156,62,32,4,56,1,0,0 };
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


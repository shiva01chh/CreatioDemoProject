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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,143,77,10,131,64,12,133,215,10,222,33,208,189,238,75,233,70,236,5,236,5,226,24,117,96,126,100,38,131,149,210,187,119,252,41,182,171,102,149,23,146,188,239,25,212,228,71,20,4,119,114,14,189,237,56,47,173,233,100,31,28,178,180,38,75,159,89,154,165,201,201,81,31,37,148,10,189,63,67,137,122,68,217,155,154,209,113,29,27,84,55,101,167,74,145,38,195,235,69,81,20,112,241,65,107,116,243,117,215,213,131,68,96,108,20,129,216,63,0,109,55,48,13,82,12,128,109,11,194,26,70,193,30,216,30,107,24,90,73,38,130,54,51,248,213,48,255,152,20,95,46,99,104,148,20,32,22,204,63,148,112,196,248,97,79,182,196,175,45,55,153,118,139,190,200,117,22,235,13,170,249,114,244,55,1,0,0 };
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


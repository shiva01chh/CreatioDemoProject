namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignInfoSchema

	/// <exclude/>
	public class CampaignInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignInfoSchema(CampaignInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d788e01e-bff4-487a-85dc-ee3d99dc9d42");
			Name = "CampaignInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,205,106,195,48,12,199,207,45,244,29,4,189,55,247,118,236,82,182,209,91,161,235,3,168,182,226,136,37,182,103,217,140,82,246,238,115,156,126,109,140,177,110,33,24,244,245,215,15,73,22,59,18,143,138,224,153,66,64,113,117,156,45,157,173,217,164,128,145,157,157,140,15,147,241,40,9,91,3,155,189,68,234,22,217,206,255,52,144,201,113,88,182,40,50,135,37,118,30,217,216,149,173,221,100,156,227,85,85,193,157,164,174,195,176,191,63,218,37,23,98,131,17,2,249,64,66,54,10,180,108,154,248,70,253,11,234,40,3,18,49,18,112,86,131,206,105,106,103,39,201,234,74,211,167,93,203,10,84,145,253,76,48,58,20,138,51,230,58,56,79,33,50,101,214,117,41,27,226,95,49,139,99,107,249,53,229,238,58,243,113,205,20,192,213,23,180,222,25,247,179,115,245,53,209,9,233,41,177,190,16,105,56,128,161,184,0,233,159,247,63,119,238,135,146,228,134,206,155,82,112,67,255,199,22,205,176,32,182,154,85,222,129,92,218,251,224,76,94,154,12,203,249,25,99,231,92,11,43,187,62,149,252,107,0,177,33,240,24,88,177,71,27,243,193,216,23,210,199,61,128,168,134,58,252,197,80,30,74,254,166,164,111,191,159,201,148,172,30,14,166,216,131,247,218,153,47,191,56,243,247,1,101,112,181,217,59,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d788e01e-bff4-487a-85dc-ee3d99dc9d42"));
		}

		#endregion

	}

	#endregion

}


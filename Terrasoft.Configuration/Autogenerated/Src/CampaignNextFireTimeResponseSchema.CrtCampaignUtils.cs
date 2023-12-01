namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignNextFireTimeResponseSchema

	/// <exclude/>
	public class CampaignNextFireTimeResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignNextFireTimeResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignNextFireTimeResponseSchema(CampaignNextFireTimeResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("33b2b06a-b8c5-4d45-827a-16cf4cc3cdd4");
			Name = "CampaignNextFireTimeResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,77,79,2,49,16,134,207,144,240,31,38,120,129,196,176,119,17,46,24,19,15,18,2,196,131,198,67,183,204,46,53,219,118,51,109,163,72,252,239,206,118,119,249,50,134,158,218,233,244,157,103,230,173,17,26,93,41,36,194,26,137,132,179,153,31,205,172,201,84,30,72,120,101,77,175,187,239,117,59,193,41,147,195,106,231,60,234,241,197,121,180,12,198,43,141,163,21,146,18,133,250,142,239,142,89,167,194,90,255,119,67,200,113,190,185,33,204,249,57,204,10,225,220,29,204,132,46,133,202,205,28,191,252,163,34,92,115,161,37,19,91,227,48,230,39,73,2,247,46,104,45,104,55,109,206,220,128,39,33,61,100,150,128,154,108,16,169,13,30,100,35,8,134,21,33,99,73,136,240,173,84,114,162,245,246,32,188,104,197,222,57,80,134,180,80,18,100,197,118,5,173,179,143,120,135,126,22,100,75,36,175,144,155,90,68,153,250,254,146,63,6,86,158,170,249,16,150,76,143,198,199,137,130,205,56,19,17,36,97,54,233,51,91,44,217,79,166,240,185,85,114,11,202,200,34,108,208,241,134,27,215,245,163,171,93,199,130,235,173,114,151,229,220,214,134,98,3,41,130,77,189,80,6,55,144,145,213,71,232,63,40,213,184,94,68,17,112,189,43,143,223,1,7,54,253,64,233,111,161,202,121,181,6,159,152,111,200,220,173,84,101,147,180,68,156,4,165,160,248,55,148,225,49,43,134,57,48,158,89,83,123,243,140,58,69,26,204,249,19,195,4,250,230,196,137,254,176,50,172,117,204,213,3,61,181,10,170,127,221,233,228,232,199,113,227,154,205,79,227,27,154,77,109,93,60,215,209,243,32,199,120,253,2,144,18,122,198,66,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33b2b06a-b8c5-4d45-827a-16cf4cc3cdd4"));
		}

		#endregion

	}

	#endregion

}


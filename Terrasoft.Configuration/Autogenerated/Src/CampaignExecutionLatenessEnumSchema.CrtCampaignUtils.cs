namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignExecutionLatenessEnumSchema

	/// <exclude/>
	public class CampaignExecutionLatenessEnumSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignExecutionLatenessEnumSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignExecutionLatenessEnumSchema(CampaignExecutionLatenessEnumSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("790d2649-25eb-4742-88b0-ff7156873fad");
			Name = "CampaignExecutionLatenessEnum";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,147,61,79,195,48,16,134,231,84,202,127,56,137,21,37,124,77,136,34,161,208,13,186,208,137,205,177,47,201,73,241,57,178,29,62,132,248,239,56,105,92,42,65,3,3,120,187,211,235,231,125,239,44,179,208,232,58,33,17,54,104,173,112,166,242,89,97,184,162,186,183,194,147,225,116,241,150,46,210,69,114,100,177,14,37,172,184,215,151,80,8,221,9,170,121,245,130,178,31,100,119,194,35,163,115,163,54,207,115,184,114,189,214,194,190,94,79,245,45,58,105,169,68,7,237,36,133,202,88,144,19,8,48,146,178,8,200,247,8,93,95,182,36,1,131,249,156,119,18,178,38,95,236,199,198,35,90,179,179,206,118,178,125,147,100,109,24,97,9,39,199,227,20,223,115,214,198,55,196,53,52,226,9,161,68,100,208,228,42,178,168,14,66,239,183,130,64,62,157,35,63,24,141,128,45,106,100,239,224,153,124,3,158,66,75,26,86,52,204,249,123,207,201,81,109,194,253,34,94,95,69,244,18,206,230,114,196,117,2,57,168,45,134,202,130,111,4,131,235,80,82,69,168,32,188,164,39,41,218,207,183,28,146,30,8,83,68,241,18,206,255,197,55,2,4,43,112,127,183,196,152,251,134,213,79,251,188,8,250,247,237,55,65,86,219,159,50,148,99,111,56,31,228,130,72,101,103,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("790d2649-25eb-4742-88b0-ff7156873fad"));
		}

		#endregion

	}

	#endregion

}


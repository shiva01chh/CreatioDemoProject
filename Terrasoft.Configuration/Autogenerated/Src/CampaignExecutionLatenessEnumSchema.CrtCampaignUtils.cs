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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,147,61,79,195,48,16,134,231,68,234,127,56,137,21,53,124,77,136,32,161,144,13,186,208,137,205,181,47,201,73,241,57,178,29,62,132,248,239,56,105,92,42,65,3,3,120,187,211,235,231,125,239,44,179,208,232,58,33,17,214,104,173,112,166,242,203,194,112,69,117,111,133,39,195,139,244,109,145,46,210,228,200,98,29,74,40,185,215,151,80,8,221,9,170,185,124,65,217,15,178,59,225,145,209,185,81,155,101,25,92,185,94,107,97,95,175,167,250,22,157,180,180,65,7,237,36,133,202,88,144,19,8,48,146,150,17,144,237,17,186,126,211,146,4,12,230,115,222,73,200,154,124,177,31,27,143,104,205,206,122,185,147,237,155,36,43,195,8,57,156,28,143,83,124,207,89,25,223,16,215,208,136,39,132,13,34,131,38,87,145,69,117,16,122,191,21,4,242,233,28,249,193,104,4,108,81,35,123,7,207,228,27,240,20,90,210,176,162,97,206,223,123,78,142,106,29,238,23,241,122,25,209,57,156,205,229,136,235,4,114,80,91,12,149,5,223,8,6,215,161,164,138,80,65,120,73,79,82,180,159,111,57,36,61,16,166,136,226,28,206,255,197,55,2,4,43,112,127,183,196,152,251,134,213,79,251,188,8,250,247,237,55,65,86,219,159,50,148,99,111,255,124,0,114,99,99,105,111,3,0,0 };
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


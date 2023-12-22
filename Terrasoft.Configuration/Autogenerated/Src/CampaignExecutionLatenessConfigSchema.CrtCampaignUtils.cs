namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignExecutionLatenessConfigSchema

	/// <exclude/>
	public class CampaignExecutionLatenessConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignExecutionLatenessConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignExecutionLatenessConfigSchema(CampaignExecutionLatenessConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("363990ca-c5bf-49b2-9d2c-6f6312c3cdc6");
			Name = "CampaignExecutionLatenessConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,193,106,195,48,12,134,207,41,244,29,68,123,79,238,107,215,75,8,163,176,65,161,125,1,213,85,82,131,237,4,203,217,86,202,222,125,182,147,180,89,97,25,44,16,176,229,95,159,127,73,54,168,137,27,20,4,7,178,22,185,46,93,154,215,166,148,85,107,209,201,218,204,103,215,249,44,105,89,154,10,246,23,118,164,87,15,123,175,87,138,68,16,115,250,66,134,172,20,119,205,24,107,41,205,81,55,40,43,227,5,94,178,180,84,249,52,200,21,50,63,193,112,88,124,146,104,3,239,21,157,231,49,119,142,98,74,150,101,176,230,86,107,180,151,77,191,143,233,224,206,232,64,212,198,161,52,12,162,103,129,234,25,208,160,245,197,58,178,156,14,156,108,4,106,218,163,146,2,68,100,253,233,36,185,70,55,183,10,118,182,110,200,58,73,190,140,93,36,133,211,240,63,26,142,129,1,7,239,168,90,74,97,107,216,161,241,83,168,75,47,38,2,97,169,124,94,28,164,166,125,131,102,145,109,210,27,107,108,122,112,61,8,111,224,16,128,48,185,36,169,200,173,226,130,251,197,87,103,125,218,152,187,52,52,125,231,175,61,186,67,254,97,224,254,152,66,47,180,228,82,90,58,1,41,210,100,28,195,135,116,103,112,161,58,63,234,147,12,194,105,155,219,194,180,154,44,30,21,173,7,203,123,113,38,141,69,199,220,192,91,127,75,104,90,62,80,139,225,198,233,34,150,100,78,221,27,136,251,46,250,51,24,99,227,239,27,251,166,156,205,117,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("363990ca-c5bf-49b2-9d2c-6f6312c3cdc6"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,81,107,194,48,16,199,159,43,248,29,14,125,111,223,167,243,165,200,16,54,16,244,11,156,241,90,3,73,90,114,233,54,145,125,247,37,105,163,78,88,7,43,20,146,203,255,126,249,223,93,12,106,226,22,5,193,158,172,69,110,42,151,151,141,169,100,221,89,116,178,49,211,201,101,58,201,58,150,166,134,221,153,29,233,197,195,222,235,149,34,17,196,156,191,144,33,43,197,77,115,143,181,148,151,168,91,148,181,241,2,47,153,91,170,125,26,148,10,153,159,32,29,174,63,73,116,129,247,138,206,243,152,123,71,49,165,40,10,88,114,167,53,218,243,106,216,199,116,112,39,116,32,26,227,80,26,6,49,176,64,13,12,104,209,250,98,29,89,206,19,167,184,3,181,221,65,73,1,34,178,254,116,146,93,162,155,107,5,91,219,180,100,157,36,95,198,54,146,194,105,248,31,13,199,64,194,193,59,170,142,114,216,24,118,104,252,20,154,202,139,137,64,88,170,158,103,123,169,105,215,162,153,21,171,252,202,186,55,157,92,39,225,21,28,2,16,38,151,101,53,185,69,92,240,176,248,234,173,143,27,115,231,150,198,239,252,181,71,55,200,63,12,220,30,83,232,133,150,92,73,75,71,32,69,154,140,99,248,144,238,4,46,84,231,71,125,148,65,56,110,115,179,54,157,38,139,7,69,203,100,121,39,78,164,113,221,51,87,240,54,220,18,154,86,38,234,58,221,56,94,196,156,204,177,127,3,113,223,71,127,6,99,44,124,223,63,234,211,109,109,3,0,0 };
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


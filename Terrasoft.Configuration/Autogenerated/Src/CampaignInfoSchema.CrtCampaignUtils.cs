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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,219,106,195,48,12,134,175,91,232,59,8,122,223,220,183,99,55,101,27,189,43,116,125,0,55,86,28,177,248,48,75,102,148,178,119,159,227,244,180,49,198,186,133,96,208,233,215,135,36,167,44,114,80,53,194,51,198,168,216,55,50,91,122,215,144,73,81,9,121,55,25,31,38,227,81,98,114,6,54,123,22,180,139,108,231,127,26,209,228,56,44,59,197,60,135,165,178,65,145,113,43,215,248,201,56,199,171,170,130,59,78,214,170,184,191,63,218,37,23,164,85,2,17,67,68,70,39,12,29,153,86,222,176,127,161,62,202,0,139,18,4,202,106,96,189,198,110,118,146,172,174,52,67,218,117,84,67,93,100,63,19,140,14,133,226,140,185,142,62,96,20,194,204,186,46,101,67,252,43,102,113,108,29,189,166,220,93,103,62,106,8,35,248,230,130,214,59,101,63,59,87,95,19,157,144,158,18,233,11,145,134,3,24,148,5,112,255,188,255,185,115,63,148,196,55,116,222,148,130,27,250,63,118,202,12,11,34,167,169,206,59,224,75,251,16,189,201,75,227,97,57,63,99,236,188,239,96,229,214,167,146,127,13,64,90,132,160,34,213,20,148,147,124,48,238,5,245,113,15,192,117,139,86,253,98,40,15,37,127,83,210,183,223,207,100,138,78,15,7,83,236,193,123,237,204,151,95,156,253,247,1,52,38,214,15,60,3,0,0 };
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


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignScheduledActionEnumSchema

	/// <exclude/>
	public class CampaignScheduledActionEnumSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignScheduledActionEnumSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignScheduledActionEnumSchema(CampaignScheduledActionEnumSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ee85b26e-3465-4222-8e7e-6c8dbf431c31");
			Name = "CampaignScheduledActionEnum";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,203,106,195,48,16,69,215,54,248,31,6,186,45,113,95,171,82,7,74,210,31,104,10,93,79,228,177,35,136,30,232,177,8,165,255,222,177,28,55,46,113,130,169,118,51,92,157,123,53,131,52,42,242,22,5,193,7,57,135,222,52,97,177,50,186,145,109,116,24,164,209,69,254,85,228,69,158,221,56,106,185,132,55,29,213,51,172,80,89,148,173,222,136,29,213,113,79,245,171,232,197,172,44,203,18,94,124,84,10,221,97,121,172,215,132,94,56,185,37,15,152,148,30,26,227,64,28,49,80,75,14,17,24,230,22,3,161,28,33,108,220,238,165,0,98,239,203,214,25,7,205,206,220,83,227,61,234,147,87,31,96,241,43,30,27,101,157,178,130,187,219,244,146,105,216,38,160,11,51,113,189,182,130,251,235,64,99,103,243,88,90,193,195,85,220,48,24,240,147,73,225,115,71,163,113,36,17,139,121,183,65,42,130,154,26,169,201,15,52,169,79,192,244,154,53,6,234,186,195,30,120,43,65,134,195,165,192,127,238,114,244,199,185,209,39,102,114,150,220,88,59,55,185,177,255,14,158,70,254,196,205,239,254,39,144,174,251,207,208,149,169,199,231,7,105,154,63,17,73,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee85b26e-3465-4222-8e7e-6c8dbf431c31"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignFireTimeConfigSchema

	/// <exclude/>
	public class CampaignFireTimeConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignFireTimeConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignFireTimeConfigSchema(CampaignFireTimeConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9223c62-28e8-4dfe-acbc-1c6c34636529");
			Name = "CampaignFireTimeConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,203,106,195,48,16,60,59,144,127,88,146,187,125,111,218,64,73,147,210,158,2,201,15,200,242,218,86,176,37,163,149,73,76,232,191,119,45,63,112,83,18,74,125,48,218,209,104,118,246,161,69,137,84,9,137,112,68,107,5,153,212,133,27,163,83,149,213,86,56,101,244,124,118,157,207,130,154,148,206,224,208,144,195,114,53,198,211,39,22,195,141,40,43,161,50,29,110,117,93,18,211,152,184,180,152,177,10,108,10,65,244,4,3,101,167,44,30,85,137,93,42,207,140,162,8,158,169,46,75,97,155,117,31,251,87,224,114,225,64,26,237,132,210,4,149,176,236,217,161,37,72,141,5,146,57,38,117,129,160,241,194,172,94,31,78,38,14,7,209,104,162,90,213,113,161,36,72,47,124,207,77,112,245,142,70,243,123,107,42,180,78,33,87,176,247,2,221,253,173,101,15,124,154,24,200,9,235,192,177,100,8,31,154,35,205,13,54,41,147,17,65,90,76,95,22,111,194,249,156,139,104,29,142,90,83,167,131,213,129,8,254,215,14,35,8,50,116,43,127,160,254,240,245,192,208,193,241,36,49,107,124,187,38,14,238,77,111,87,152,243,59,106,228,87,198,142,112,139,30,184,215,165,24,239,166,214,71,16,178,238,132,4,108,142,218,170,121,105,42,130,4,43,212,9,3,154,7,170,120,142,93,83,155,199,213,15,233,187,212,219,11,202,186,221,202,177,166,223,200,63,58,244,42,91,133,110,207,18,68,146,86,197,236,255,220,198,167,118,156,185,169,139,4,18,195,144,114,57,136,113,207,254,110,190,221,209,164,79,116,27,63,182,188,228,182,117,139,232,227,14,253,9,122,108,250,125,3,8,131,242,244,215,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9223c62-28e8-4dfe-acbc-1c6c34636529"));
		}

		#endregion

	}

	#endregion

}


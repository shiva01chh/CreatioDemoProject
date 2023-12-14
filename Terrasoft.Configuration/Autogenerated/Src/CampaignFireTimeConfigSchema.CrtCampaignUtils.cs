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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,203,110,194,48,16,60,131,196,63,172,224,158,220,75,139,84,81,168,218,19,18,252,128,227,108,18,163,196,142,188,142,32,66,253,247,174,29,18,165,84,160,170,57,68,222,241,120,118,246,161,69,133,84,11,137,112,64,107,5,153,204,69,107,163,51,149,55,86,56,101,244,108,122,153,77,39,13,41,157,195,190,37,135,213,114,136,199,79,44,70,107,81,213,66,229,58,218,232,166,34,166,49,113,97,49,103,21,88,151,130,232,9,122,202,86,89,60,168,10,187,84,129,25,199,49,60,83,83,85,194,182,171,107,28,94,129,43,132,3,105,180,19,74,19,212,194,178,103,135,150,32,51,22,72,22,152,54,37,130,198,51,179,174,250,112,52,73,212,139,198,35,213,186,73,74,37,65,6,225,123,110,38,151,224,104,48,191,179,166,70,235,20,114,5,187,32,208,221,223,90,14,192,167,73,128,156,176,14,28,75,70,240,161,57,210,220,96,147,49,25,17,164,197,236,101,254,38,92,200,57,143,87,209,160,53,118,218,91,237,137,16,126,126,24,147,73,142,110,25,14,116,61,124,61,48,180,119,60,73,204,219,208,174,145,131,123,211,219,150,230,244,142,26,249,149,177,3,236,209,61,247,186,18,195,221,216,250,0,66,222,157,144,128,205,145,175,154,151,166,38,72,177,70,157,50,160,121,160,138,231,216,53,181,125,92,125,159,190,75,189,57,163,108,252,86,14,53,253,70,254,209,161,87,233,21,186,61,75,17,73,90,149,176,255,147,143,143,126,156,133,105,202,20,82,195,144,114,5,136,97,207,254,110,222,239,104,122,77,116,27,63,182,188,224,182,117,139,24,226,14,253,9,6,204,127,223,103,28,225,69,207,3,0,0 };
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


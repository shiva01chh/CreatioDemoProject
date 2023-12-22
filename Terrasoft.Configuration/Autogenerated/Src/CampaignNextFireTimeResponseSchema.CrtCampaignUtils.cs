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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,193,78,2,49,16,134,207,144,240,14,19,188,64,98,216,187,8,23,140,137,7,9,1,226,65,227,161,91,102,151,154,109,187,153,182,81,36,190,187,179,221,5,22,140,161,167,118,58,253,231,155,249,107,132,70,87,10,137,176,70,34,225,108,230,71,51,107,50,149,7,18,94,89,211,235,238,123,221,78,112,202,228,176,218,57,143,122,124,113,30,45,131,241,74,227,104,133,164,68,161,190,227,187,83,86,91,88,235,255,110,8,57,206,55,55,132,57,63,135,89,33,156,187,131,153,208,165,80,185,153,227,151,127,84,132,107,46,180,100,98,107,28,198,252,36,73,224,222,5,173,5,237,166,205,153,27,240,36,164,135,204,18,80,147,13,34,181,193,131,108,4,193,176,34,100,44,9,17,254,32,149,180,180,222,30,132,23,7,177,119,14,148,33,45,148,4,89,177,93,65,235,236,35,222,177,159,5,217,18,201,43,228,166,22,81,166,190,191,228,143,129,149,167,106,62,132,37,211,163,241,113,162,96,51,206,68,4,73,152,77,250,204,22,75,246,147,41,124,110,149,220,130,50,178,8,27,116,188,225,198,117,253,232,106,215,177,224,122,171,220,101,57,183,181,161,216,64,138,96,83,47,148,193,13,100,100,245,9,250,15,74,53,174,23,81,4,92,239,202,211,119,192,129,77,63,80,250,91,168,114,94,173,193,39,230,27,50,247,65,170,178,73,90,34,78,130,82,80,252,27,202,240,152,21,195,28,25,207,172,169,189,121,70,157,34,13,230,252,137,97,2,125,211,114,162,63,172,12,59,56,230,234,129,182,173,130,234,95,119,58,57,250,113,220,184,102,243,211,248,134,102,83,91,23,207,117,244,60,200,177,246,250,5,243,132,14,174,75,3,0,0 };
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


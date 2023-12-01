namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignEnumsSchema

	/// <exclude/>
	public class CampaignEnumsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignEnumsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignEnumsSchema(CampaignEnumsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0c552018-5652-4db5-88b4-c7082c75a44f");
			Name = "CampaignEnums";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,207,78,195,48,12,198,207,155,180,119,176,198,129,11,90,129,35,218,144,208,254,0,39,14,192,3,152,204,221,34,165,73,72,28,166,10,241,238,184,45,148,13,40,189,208,83,28,187,159,127,177,63,139,5,69,143,138,224,129,66,192,232,114,158,204,157,205,245,38,5,100,237,236,104,248,58,26,142,134,131,163,64,27,9,97,105,83,113,1,247,76,126,238,10,111,136,105,45,245,107,221,212,74,97,150,101,48,141,169,40,48,148,151,31,113,91,1,188,69,6,45,145,66,166,40,33,65,100,57,130,203,193,99,96,173,180,71,203,241,24,80,177,126,169,178,228,65,185,166,19,248,224,60,5,46,33,119,1,84,10,129,44,3,7,180,177,150,159,124,246,207,246,0,124,122,50,90,1,9,120,39,247,64,30,57,248,129,94,95,92,19,199,3,180,186,247,110,171,213,246,80,238,11,78,71,120,8,137,38,173,230,62,206,224,49,82,251,207,157,53,37,204,224,244,164,30,221,127,2,172,208,196,63,8,110,173,250,198,112,214,203,128,198,28,114,236,52,111,93,98,64,91,202,138,62,87,252,132,81,88,228,240,59,92,7,211,149,173,32,206,229,248,214,248,141,236,186,177,220,47,246,107,55,135,230,158,158,19,89,69,43,227,118,11,50,88,62,90,205,157,70,172,43,32,73,73,51,197,105,36,2,21,40,159,141,59,52,151,134,10,49,217,56,187,236,53,87,63,213,31,54,107,200,180,133,53,150,177,99,70,11,73,245,185,165,213,145,205,132,46,161,155,42,87,237,188,99,220,114,39,223,59,197,215,113,175,28,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c552018-5652-4db5-88b4-c7082c75a44f"));
		}

		#endregion

	}

	#endregion

}


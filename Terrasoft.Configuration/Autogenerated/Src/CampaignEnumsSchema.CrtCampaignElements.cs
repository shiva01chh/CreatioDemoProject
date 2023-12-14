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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,207,78,195,48,12,198,207,155,180,119,176,224,192,5,173,192,17,109,147,16,27,127,78,28,128,7,240,50,151,70,74,147,144,56,76,21,226,221,113,91,86,54,160,219,133,158,226,216,253,252,139,253,89,44,41,122,84,4,79,20,2,70,151,243,248,218,217,92,191,164,128,172,157,29,13,223,71,195,209,112,112,28,232,69,66,88,216,84,94,194,35,147,191,118,165,55,196,180,146,250,149,110,107,165,48,203,50,152,196,84,150,24,170,217,87,220,85,0,23,200,160,37,82,200,20,37,36,136,44,71,112,57,120,12,172,149,246,104,57,158,0,42,214,111,117,150,60,40,215,118,2,31,156,167,192,21,228,46,128,74,33,144,101,224,128,54,54,242,227,77,255,108,11,192,167,165,209,10,72,192,123,185,7,242,200,193,47,244,230,226,150,56,238,160,53,189,215,133,86,197,174,220,55,156,142,240,20,18,141,59,205,109,156,193,115,164,238,159,7,107,42,152,194,217,105,51,186,255,4,184,65,19,247,16,220,91,245,131,225,252,32,3,26,179,203,177,214,92,184,196,128,182,146,21,109,86,188,196,40,44,114,248,27,174,135,233,202,214,16,23,114,252,104,253,70,118,213,90,238,15,251,117,155,67,243,72,175,137,172,162,27,227,214,115,50,88,61,91,205,189,70,108,42,32,73,73,59,197,73,36,2,21,40,159,30,245,104,46,12,149,98,178,163,108,118,208,92,135,169,246,216,172,37,211,22,86,88,197,158,25,205,37,117,200,45,157,142,108,38,244,9,221,213,185,122,231,61,227,150,187,250,251,4,123,65,118,217,29,4,0,0 };
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


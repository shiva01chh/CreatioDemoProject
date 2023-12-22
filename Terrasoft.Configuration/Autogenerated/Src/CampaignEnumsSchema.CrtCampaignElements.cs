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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,207,78,195,48,12,198,207,155,180,119,176,198,129,11,90,129,35,98,147,208,254,0,39,14,176,7,48,153,187,69,74,147,144,56,76,21,226,221,241,90,86,54,88,183,11,61,197,177,251,249,23,251,179,88,80,244,168,8,94,40,4,140,46,231,193,216,217,92,47,83,64,214,206,246,186,31,189,110,175,219,57,11,180,148,16,166,54,21,55,240,204,228,199,174,240,134,152,22,82,191,208,117,173,20,102,89,6,183,49,21,5,134,114,244,29,55,21,192,43,100,208,18,41,100,138,18,18,68,150,35,184,28,60,6,214,74,123,180,28,207,1,21,235,247,77,150,60,40,87,119,2,31,156,167,192,37,228,46,128,74,33,144,101,224,128,54,86,242,131,109,255,108,7,192,167,87,163,21,144,128,183,114,119,228,145,157,63,232,213,197,61,113,220,67,171,122,175,87,90,173,246,229,126,224,116,132,151,144,104,208,104,238,226,116,230,145,154,127,158,172,41,97,8,151,23,213,232,254,19,96,134,38,30,33,120,180,234,23,195,213,73,6,52,102,159,99,173,121,229,18,3,218,82,86,180,93,241,43,70,97,145,195,97,184,22,166,59,187,129,184,150,227,103,237,55,178,139,218,114,7,236,215,108,14,205,51,189,37,178,138,102,198,173,39,100,176,156,91,205,173,70,172,42,32,73,73,61,197,219,72,4,42,80,62,236,183,104,78,13,21,98,178,126,54,58,105,174,211,84,71,108,86,147,105,11,11,44,99,203,140,38,146,58,229,150,70,71,54,19,218,132,30,54,185,205,206,91,198,45,119,187,223,23,241,195,113,137,37,4,0,0 };
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


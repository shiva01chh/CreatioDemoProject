namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignAppEventListenerSchema

	/// <exclude/>
	public class CampaignAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignAppEventListenerSchema(CampaignAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3e664810-988a-4dee-b55a-dbf31d8fa22e");
			Name = "CampaignAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1f302b36-4763-41e5-806c-b1f1f1b6d901");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,81,107,219,48,16,126,78,161,255,225,112,95,82,24,214,123,154,26,182,52,133,140,142,141,185,208,103,69,62,219,98,150,100,36,185,212,43,251,239,59,203,78,230,100,205,12,101,108,245,147,124,119,250,238,187,79,159,164,185,66,87,115,129,112,143,214,114,103,114,31,175,140,206,101,209,88,238,165,209,231,103,207,231,103,179,198,73,93,28,148,88,140,87,92,213,92,22,250,106,170,32,222,104,143,54,167,46,110,186,54,245,220,250,148,86,188,58,89,124,203,133,55,86,190,12,247,128,91,170,82,202,116,196,40,127,97,177,160,65,96,85,113,231,22,176,107,244,190,174,215,143,168,253,157,116,30,53,218,80,203,24,131,165,107,148,226,182,77,134,255,175,88,91,116,84,233,64,161,47,77,230,192,27,144,90,122,201,43,249,29,129,228,251,198,11,140,119,251,217,8,160,110,182,149,20,32,186,222,39,91,195,2,54,191,211,153,61,7,74,123,254,159,250,230,11,248,18,48,251,228,49,225,16,248,32,53,145,28,104,57,202,35,130,176,152,95,71,65,131,94,189,54,98,9,72,143,202,197,123,32,118,140,180,172,185,229,10,52,185,228,58,18,134,142,241,201,71,201,70,59,207,53,121,198,228,99,240,221,8,171,161,142,37,241,146,5,128,128,55,72,241,104,100,6,159,59,13,194,73,207,143,118,193,208,229,18,58,223,205,102,99,198,113,55,216,114,179,147,113,253,132,162,233,60,122,103,138,2,237,59,56,145,72,230,81,227,208,82,3,141,162,11,71,151,87,83,216,31,205,246,70,210,197,240,162,28,35,31,132,95,131,123,47,21,166,180,57,107,170,49,238,65,248,53,184,183,150,23,138,84,76,91,45,74,107,52,249,114,4,255,82,54,153,247,168,63,254,96,164,112,76,107,157,1,170,218,183,80,114,157,17,191,255,229,23,34,50,229,22,198,110,12,104,227,203,238,73,200,141,5,90,237,111,2,180,232,227,233,145,83,116,142,68,15,238,124,3,131,143,233,252,195,241,223,198,169,255,34,243,87,71,191,64,157,245,175,106,248,239,163,135,193,16,27,127,63,1,0,43,88,15,42,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e664810-988a-4dee-b55a-dbf31d8fa22e"));
		}

		#endregion

	}

	#endregion

}


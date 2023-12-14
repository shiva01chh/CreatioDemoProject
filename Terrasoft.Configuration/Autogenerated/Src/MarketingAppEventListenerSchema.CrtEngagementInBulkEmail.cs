namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MarketingAppEventListenerSchema

	/// <exclude/>
	public class MarketingAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MarketingAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MarketingAppEventListenerSchema(MarketingAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ab8c1b0d-1351-4fe6-8ded-74eb63abcdfb");
			Name = "MarketingAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,193,106,194,64,16,61,43,248,15,131,189,88,40,201,93,99,160,74,11,66,165,69,5,207,107,50,137,139,102,55,221,153,72,173,244,223,59,217,68,81,105,115,219,247,222,188,121,51,19,163,10,164,82,37,8,43,116,78,145,205,56,152,90,147,233,188,114,138,181,53,189,238,169,215,237,84,164,77,126,35,113,24,188,170,132,173,211,72,163,63,20,107,220,136,170,40,172,17,86,248,7,135,185,216,193,116,175,136,134,48,87,110,135,44,37,207,101,249,114,64,195,111,154,24,13,58,47,14,195,16,34,170,138,66,185,99,220,190,23,88,58,36,81,18,20,200,91,155,18,176,5,109,52,107,181,215,223,8,50,197,78,229,24,156,235,195,43,131,178,218,236,117,2,73,221,252,255,222,48,132,123,104,162,8,165,254,228,99,93,134,152,55,1,134,240,225,125,27,242,62,180,7,38,218,72,208,54,26,9,143,8,137,195,108,220,247,139,104,86,120,236,135,49,104,198,130,130,139,81,120,239,20,149,202,169,2,140,28,108,220,79,172,97,252,226,126,60,51,196,202,200,249,108,118,109,126,30,99,218,234,194,56,136,66,111,224,253,218,117,216,131,156,75,167,8,7,171,83,120,55,82,181,100,229,120,112,87,14,109,187,71,168,255,133,78,103,35,75,9,174,228,103,122,228,217,235,193,130,122,254,104,86,251,8,64,43,187,60,154,100,129,159,21,18,63,193,25,94,107,222,78,37,208,238,86,16,15,26,199,159,118,249,104,210,102,255,254,221,160,183,160,199,234,239,23,201,88,145,90,215,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ab8c1b0d-1351-4fe6-8ded-74eb63abcdfb"));
		}

		#endregion

	}

	#endregion

}


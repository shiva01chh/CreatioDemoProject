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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,193,106,194,64,16,61,43,248,15,131,189,88,40,201,93,99,160,134,22,132,74,139,10,158,215,56,137,139,102,55,221,153,72,173,244,223,59,217,68,81,105,115,219,247,222,188,121,51,19,163,10,164,82,165,8,75,116,78,145,205,56,72,172,201,116,94,57,197,218,154,94,247,212,235,118,42,210,38,191,145,56,12,94,85,202,214,105,164,209,31,138,21,174,69,85,20,214,8,43,252,131,195,92,236,32,217,43,162,33,204,148,219,33,75,201,115,89,190,28,208,240,155,38,70,131,206,139,195,48,132,136,170,162,80,238,24,183,239,57,150,14,73,148,4,5,242,214,110,8,216,130,54,154,181,218,235,111,4,153,98,167,114,12,206,245,225,149,65,89,173,247,58,133,180,110,254,127,111,24,194,61,52,81,132,82,127,242,177,46,67,204,154,0,67,248,240,190,13,121,31,218,3,19,109,36,104,27,141,132,71,132,212,97,54,238,251,69,52,43,60,246,195,24,52,99,65,193,197,40,188,119,138,74,229,84,1,70,14,54,238,167,214,48,126,113,63,158,26,98,101,228,124,54,187,54,63,143,145,180,186,48,14,162,208,27,120,191,118,29,246,32,231,210,27,132,131,213,27,120,55,82,181,96,229,120,112,87,14,109,187,71,168,255,133,78,103,45,75,9,174,228,103,122,228,217,235,193,130,122,254,104,90,251,8,64,75,187,56,154,116,142,159,21,18,63,193,25,94,105,222,38,18,104,119,43,136,7,141,227,79,187,124,52,155,102,255,254,221,160,183,160,199,228,251,5,210,162,237,155,214,2,0,0 };
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


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,193,106,194,64,16,61,43,248,15,131,189,88,40,201,93,99,160,74,11,66,165,69,5,207,107,156,196,69,179,155,238,76,164,86,250,239,157,108,162,68,105,115,219,247,222,188,121,51,19,163,114,164,66,37,8,43,116,78,145,77,57,152,90,147,234,172,116,138,181,53,189,238,185,215,237,148,164,77,118,35,113,24,188,170,132,173,211,72,163,63,20,107,220,136,42,207,173,17,86,248,7,135,153,216,193,244,160,136,134,48,87,110,143,44,37,207,69,241,114,68,195,111,154,24,13,58,47,14,195,16,34,42,243,92,185,83,220,188,23,88,56,36,81,18,228,200,59,187,37,96,11,218,104,214,234,160,191,17,100,138,189,202,48,184,212,135,45,131,162,220,28,116,2,73,213,252,255,222,48,132,123,104,162,8,165,254,236,99,93,135,152,215,1,134,240,225,125,107,242,62,180,7,38,218,72,208,38,26,9,143,8,137,195,116,220,247,139,168,87,120,234,135,49,104,198,156,130,171,81,120,239,20,21,202,169,28,140,28,108,220,79,172,97,252,226,126,60,51,196,202,200,249,108,218,54,191,140,49,109,116,97,28,68,161,55,240,126,205,58,236,81,206,165,183,8,71,171,183,240,110,164,106,201,202,241,224,174,28,154,118,143,80,253,11,157,206,70,150,18,180,228,23,122,228,217,246,96,65,53,127,52,171,124,4,160,149,93,158,76,178,192,207,18,137,159,224,2,175,53,239,166,18,104,127,43,136,7,181,227,79,179,124,52,219,122,255,254,93,163,183,160,199,218,223,47,78,42,227,18,223,2,0,0 };
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


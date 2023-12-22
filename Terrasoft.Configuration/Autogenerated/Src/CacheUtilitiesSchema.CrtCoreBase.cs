namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CacheUtilitiesSchema

	/// <exclude/>
	public class CacheUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CacheUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CacheUtilitiesSchema(CacheUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e686424e-171b-4e43-9ed2-8c621f1495a0");
			Name = "CacheUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,148,77,79,227,48,16,134,207,65,226,63,88,57,129,132,162,61,111,197,1,165,108,185,176,135,165,192,1,33,52,73,135,214,90,55,142,198,99,118,81,213,255,142,157,164,82,220,154,126,40,81,21,53,51,243,62,243,206,196,109,5,75,52,53,148,40,166,72,4,70,191,115,150,235,234,93,206,45,1,75,93,157,159,173,206,207,18,107,100,53,15,74,8,71,145,248,51,22,217,29,115,157,221,20,134,9,74,79,48,174,208,149,214,182,80,178,20,134,29,182,20,165,2,99,68,14,229,2,31,89,42,201,18,141,43,90,53,165,73,77,242,3,24,55,197,14,229,219,228,150,8,43,206,173,98,75,248,219,57,23,222,91,146,204,145,187,111,201,7,144,176,6,201,205,80,97,211,94,92,139,139,199,32,114,233,29,186,71,198,255,110,146,22,154,61,160,49,46,247,146,134,181,233,235,168,5,19,186,166,213,22,123,163,246,154,172,243,149,121,99,173,104,237,239,235,110,164,96,252,110,162,103,77,127,155,237,55,139,152,144,182,245,238,72,93,231,86,146,253,210,180,4,190,72,35,210,183,213,143,117,122,21,89,211,101,104,231,27,51,99,100,144,202,52,188,99,93,244,53,3,219,223,180,135,229,164,246,125,205,192,246,127,176,214,196,167,181,239,107,134,78,95,129,250,116,207,166,101,182,54,174,69,26,139,167,163,195,152,124,1,27,202,177,187,220,149,14,156,105,66,114,246,36,241,223,73,54,2,209,64,3,183,51,201,193,169,118,11,221,142,237,89,230,237,210,85,77,113,89,43,247,95,212,251,133,122,202,78,106,15,231,94,207,172,194,49,48,132,144,88,252,167,159,248,152,247,27,144,34,225,3,160,137,210,5,168,214,65,200,138,103,246,160,186,215,178,101,105,55,122,208,205,3,2,149,139,152,155,237,204,30,212,24,204,162,208,64,179,41,20,33,42,158,105,80,238,8,185,79,255,250,2,105,233,12,171,24,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e686424e-171b-4e43-9ed2-8c621f1495a0"));
		}

		#endregion

	}

	#endregion

}


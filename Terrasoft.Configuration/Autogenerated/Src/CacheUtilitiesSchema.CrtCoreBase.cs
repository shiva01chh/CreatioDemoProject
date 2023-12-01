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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,148,77,107,219,64,16,134,207,10,228,63,8,157,18,40,34,231,154,28,130,156,58,151,228,208,56,205,161,148,50,146,39,246,210,181,86,204,206,38,41,198,255,189,179,146,12,94,123,235,15,36,140,176,102,230,125,230,157,209,218,53,44,209,54,80,97,58,69,34,176,230,141,243,194,212,111,106,238,8,88,153,250,242,98,117,121,145,56,171,234,121,80,66,56,138,196,95,177,204,31,152,155,252,174,180,76,80,121,130,149,66,41,109,92,169,85,149,90,22,108,149,86,26,172,77,11,168,22,248,194,74,43,86,104,165,104,213,150,38,13,169,119,96,220,20,11,202,183,41,28,17,214,92,56,205,142,240,73,156,167,222,91,146,204,145,251,111,201,59,80,234,44,146,204,80,99,219,62,189,77,175,94,130,200,181,119,40,143,140,159,50,73,7,205,159,209,90,201,253,204,194,218,236,215,168,3,19,74,211,122,135,189,81,123,77,222,251,202,189,177,78,180,246,247,117,63,82,48,126,63,209,171,161,63,237,246,219,69,76,200,184,102,127,164,190,115,39,201,191,25,90,2,95,101,17,233,239,213,205,58,251,18,89,211,117,104,231,63,102,198,200,160,180,109,121,167,186,216,214,12,108,127,215,29,150,179,218,111,107,6,182,255,142,141,33,62,175,253,182,102,232,244,53,232,191,242,108,59,102,103,227,54,205,98,241,108,116,28,83,44,96,67,57,117,151,251,210,129,51,77,72,205,126,40,252,56,203,70,32,26,104,224,126,166,56,56,213,178,208,221,216,129,101,222,47,165,106,138,203,70,203,127,209,214,47,212,83,246,82,7,56,143,102,230,52,142,129,33,132,196,226,95,253,196,167,188,223,128,20,9,31,1,77,180,41,65,119,14,66,86,60,115,0,213,191,150,29,75,251,209,163,110,158,17,168,90,196,220,236,102,14,160,198,96,23,165,1,154,77,161,12,81,241,76,139,146,35,36,31,185,254,1,254,52,253,142,15,7,0,0 };
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


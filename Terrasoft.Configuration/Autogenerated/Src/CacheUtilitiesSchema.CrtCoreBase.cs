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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,148,203,78,235,48,16,134,215,65,226,29,172,172,64,58,138,88,83,177,64,41,148,13,44,160,192,2,29,29,77,210,161,181,112,227,104,60,230,162,170,239,142,157,164,82,221,250,244,162,68,85,212,204,204,255,205,63,19,183,21,204,209,212,80,162,24,35,17,24,253,206,89,174,171,119,57,181,4,44,117,117,122,178,56,61,73,172,145,213,52,40,33,28,68,226,175,88,100,119,204,117,118,93,24,38,40,61,193,184,66,87,90,219,66,201,82,24,118,216,82,148,10,140,17,57,148,51,124,102,169,36,75,52,174,104,209,148,38,53,201,79,96,92,21,59,148,111,147,91,34,172,56,183,138,45,225,131,115,46,188,183,36,153,34,119,223,146,79,32,97,13,146,155,161,194,166,189,184,18,103,207,65,228,220,59,116,143,140,223,110,146,22,154,61,161,49,46,247,150,134,181,233,223,65,11,38,116,77,171,13,246,74,237,53,89,231,43,243,198,90,209,210,223,151,221,72,193,248,221,68,175,154,62,154,237,55,139,24,145,182,245,246,72,93,231,86,146,221,106,154,3,159,165,17,233,191,197,197,50,253,19,89,211,121,104,231,63,102,134,200,32,149,105,120,135,186,88,215,244,108,127,221,30,150,163,218,175,107,122,182,127,196,90,19,31,215,126,93,211,119,250,10,212,143,123,54,45,179,181,113,37,210,88,60,29,236,199,228,51,88,81,14,221,229,182,180,231,76,35,146,147,23,137,95,71,217,8,68,61,13,220,76,36,7,167,218,45,116,51,182,99,153,55,115,87,53,198,121,173,220,127,209,218,47,212,83,182,82,59,56,247,122,98,21,14,129,33,132,196,226,151,126,226,67,222,111,64,138,132,247,128,70,74,23,160,90,7,33,43,158,217,129,234,94,203,134,165,237,232,94,55,79,8,84,206,98,110,54,51,59,80,67,48,179,66,3,77,198,80,132,168,120,166,65,185,35,228,62,254,250,5,188,36,92,104,16,7,0,0 };
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


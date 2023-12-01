namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseServiceConstsSchema

	/// <exclude/>
	public class CaseServiceConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseServiceConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseServiceConstsSchema(CaseServiceConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4c96d0a7-eeac-44d3-afd1-3e92a22d0b77");
			Name = "CaseServiceConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,77,106,195,48,16,133,215,9,228,14,34,221,180,11,133,248,47,142,27,186,176,20,167,116,83,130,227,11,168,242,36,8,28,201,213,200,129,80,122,247,202,14,221,148,150,134,204,74,51,239,241,190,65,140,22,71,192,86,72,32,21,88,43,208,236,221,140,27,189,87,135,206,10,167,140,38,31,147,241,100,60,234,80,233,3,217,157,209,193,113,53,76,238,44,28,122,157,55,2,241,145,108,187,183,70,201,65,105,135,39,65,231,3,36,145,189,78,184,64,216,129,61,41,9,62,30,29,246,185,163,31,86,11,162,54,186,57,147,231,78,213,164,4,52,77,215,239,240,106,156,218,43,57,236,83,181,205,75,77,158,6,203,108,43,44,194,253,52,140,146,52,227,25,163,249,58,10,105,156,132,115,186,140,146,136,166,44,143,242,156,179,36,202,179,233,195,234,63,96,129,78,29,7,72,9,239,29,160,251,141,197,151,27,22,204,55,1,101,30,73,99,182,136,105,182,14,18,154,134,155,120,94,20,105,176,72,217,21,172,92,58,117,82,238,236,83,189,168,90,161,93,105,26,168,140,199,125,107,151,143,154,253,105,189,21,194,229,213,16,46,111,133,48,121,61,197,123,123,204,231,229,174,64,215,151,211,234,91,63,243,245,5,98,12,95,203,166,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c96d0a7-eeac-44d3-afd1-3e92a22d0b77"));
		}

		#endregion

	}

	#endregion

}


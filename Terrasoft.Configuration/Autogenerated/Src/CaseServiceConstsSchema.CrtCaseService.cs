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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,207,106,2,49,16,198,207,10,190,67,176,151,246,144,197,253,231,186,149,30,54,81,75,47,69,212,23,72,179,227,18,88,147,109,38,43,72,233,187,55,187,34,148,210,82,113,78,153,249,62,190,223,16,70,139,3,96,35,36,144,29,88,43,208,236,93,192,141,222,171,170,181,194,41,163,201,199,104,56,26,14,90,84,186,34,219,19,58,56,204,251,201,157,133,170,211,121,45,16,31,201,186,125,171,149,236,149,166,127,18,116,62,64,18,217,233,132,11,132,45,216,163,146,224,227,209,97,151,59,248,97,181,32,74,163,235,19,121,110,85,73,54,128,166,110,187,29,94,141,83,123,37,251,125,118,77,253,82,146,167,222,18,172,133,69,184,31,71,113,154,229,60,103,180,88,196,17,77,210,104,66,103,113,26,211,140,21,113,81,112,150,198,69,62,126,152,255,7,92,162,83,135,30,178,129,247,22,208,253,198,226,179,21,11,39,171,144,50,143,164,9,155,38,52,95,132,41,205,162,85,50,89,46,179,112,154,177,43,88,133,116,234,168,220,201,167,122,81,53,66,187,141,169,97,103,60,238,162,157,63,42,248,211,122,43,132,203,171,33,92,222,10,97,242,122,138,247,118,152,207,243,93,129,46,207,167,213,181,126,246,189,190,0,19,73,36,94,175,2,0,0 };
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


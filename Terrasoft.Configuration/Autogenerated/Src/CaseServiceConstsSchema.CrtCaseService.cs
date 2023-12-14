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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,207,106,2,49,16,198,207,10,190,67,176,151,246,16,113,255,185,110,165,135,77,212,210,75,17,221,23,72,179,163,4,214,100,155,201,10,82,250,238,77,86,122,41,45,21,231,148,153,239,227,251,13,97,180,56,2,182,66,2,169,192,90,129,102,239,38,220,232,189,58,116,86,56,101,52,249,24,13,71,195,65,135,74,31,200,238,140,14,142,139,126,114,103,225,16,116,222,8,196,71,178,233,222,26,37,123,165,237,159,4,157,15,144,68,6,157,112,129,176,3,123,82,18,124,60,58,12,185,131,31,86,11,162,54,186,57,147,231,78,213,100,11,104,154,46,236,240,106,156,218,43,217,239,83,181,205,75,77,158,122,203,100,35,44,194,253,56,78,178,188,224,5,163,229,50,137,105,154,197,83,58,79,178,132,230,172,76,202,146,179,44,41,139,241,195,226,63,224,10,157,58,246,144,45,188,119,128,238,55,22,159,175,89,52,93,71,148,121,36,77,217,44,165,197,50,202,104,30,175,211,233,106,149,71,179,156,93,193,42,165,83,39,229,206,62,213,139,170,21,218,109,77,3,149,241,184,111,237,242,81,147,63,173,183,66,184,188,26,194,229,173,16,38,175,167,120,111,192,124,94,238,10,116,125,57,173,208,250,89,168,47,235,89,160,145,167,2,0,0 };
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


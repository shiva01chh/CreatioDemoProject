namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchOAuthScopesSchema

	/// <exclude/>
	public class GlobalSearchOAuthScopesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchOAuthScopesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchOAuthScopesSchema(GlobalSearchOAuthScopesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d20499a8-e69d-4f2f-b21b-32f0cd735faa");
			Name = "GlobalSearchOAuthScopes";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ca3090cb-7cbd-4956-acde-76442c58fa1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,207,110,194,48,12,198,207,69,226,29,44,118,129,75,123,103,140,9,33,134,56,140,77,234,120,128,144,26,90,169,249,35,199,145,134,208,222,125,73,186,49,138,88,111,253,242,249,103,251,179,22,10,157,21,18,225,3,137,132,51,7,206,151,70,31,154,163,39,193,141,209,249,186,53,123,209,150,40,72,214,195,193,121,56,200,188,107,244,177,231,87,202,232,199,187,47,132,247,244,107,102,190,209,140,116,8,35,184,96,13,230,7,194,99,104,12,203,86,56,55,133,107,239,219,194,115,93,74,99,209,37,171,245,251,182,145,224,56,140,42,65,198,130,255,253,217,57,213,92,248,175,200,181,169,66,135,247,68,233,30,139,162,128,153,243,74,9,58,205,127,133,53,50,8,107,201,88,106,4,35,184,72,132,10,45,234,42,46,22,96,92,35,120,135,4,124,178,152,95,72,197,45,106,102,5,9,5,58,196,254,52,138,5,33,108,141,50,38,61,154,239,34,64,94,4,104,116,216,76,75,204,103,69,42,75,148,254,206,142,41,78,16,38,76,107,190,24,90,122,34,212,28,89,227,93,175,1,244,251,77,32,30,51,203,8,217,211,237,99,190,250,12,87,209,162,93,200,112,24,183,169,242,141,219,26,94,41,203,167,241,4,158,97,93,118,185,230,165,183,214,16,195,244,79,218,26,82,162,141,135,207,190,126,50,15,73,117,177,167,255,78,237,139,73,187,254,190,1,152,59,145,79,155,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d20499a8-e69d-4f2f-b21b-32f0cd735faa"));
		}

		#endregion

	}

	#endregion

}


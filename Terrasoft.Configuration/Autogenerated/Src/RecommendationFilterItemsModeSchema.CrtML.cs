namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RecommendationFilterItemsModeSchema

	/// <exclude/>
	public class RecommendationFilterItemsModeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RecommendationFilterItemsModeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RecommendationFilterItemsModeSchema(RecommendationFilterItemsModeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ab1853cd-ba91-4c11-942e-58eb26dfa9d8");
			Name = "RecommendationFilterItemsMode";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("55b53857-a033-4921-8f47-13b5471dd33e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,80,77,107,2,49,16,61,239,194,254,135,129,94,203,238,93,74,15,138,130,7,47,197,210,115,204,78,52,152,143,237,36,129,138,248,223,157,68,91,86,42,8,230,148,55,243,230,205,123,227,132,197,48,8,137,176,70,34,17,188,138,237,204,59,165,183,137,68,212,222,65,83,31,155,186,169,171,23,194,109,198,115,151,236,4,62,80,122,107,209,245,133,180,208,38,34,45,35,218,176,242,61,22,126,215,117,240,22,146,181,130,14,239,87,156,155,224,21,168,194,7,237,128,110,116,24,126,39,12,177,253,157,239,70,2,67,218,24,45,1,121,255,163,245,21,91,174,254,57,40,133,207,192,14,156,57,128,206,116,80,228,237,200,206,64,216,107,153,53,219,63,133,177,135,234,107,199,115,175,37,224,125,253,249,143,52,137,83,62,39,63,53,66,238,249,115,186,156,156,3,94,174,158,33,215,198,239,12,192,115,239,87,186,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ab1853cd-ba91-4c11-942e-58eb26dfa9d8"));
		}

		#endregion

	}

	#endregion

}


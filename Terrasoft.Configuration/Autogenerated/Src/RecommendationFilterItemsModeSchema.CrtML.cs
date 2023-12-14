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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,80,203,106,195,48,16,60,219,224,127,88,232,53,216,247,80,122,72,112,161,135,94,74,74,207,138,188,114,69,245,112,87,18,52,132,252,123,86,202,3,135,20,10,213,73,179,59,59,59,179,78,88,12,147,144,8,27,36,18,193,171,216,174,189,83,122,76,36,162,246,14,154,122,223,212,77,93,61,16,142,25,247,46,217,37,188,161,244,214,162,27,10,233,89,155,136,244,18,209,134,87,63,96,225,119,93,7,143,33,89,43,104,247,116,198,185,9,94,129,42,124,208,14,232,70,135,225,119,194,16,219,203,124,55,19,152,210,214,104,9,200,251,255,90,95,177,229,234,206,65,41,188,7,118,224,204,14,116,166,131,34,111,103,118,38,194,65,203,172,217,94,21,230,30,170,143,79,158,91,148,128,191,235,247,63,210,36,78,249,63,249,149,17,242,139,63,135,211,201,57,224,233,234,25,114,45,191,35,34,222,250,16,178,1,0,0 };
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


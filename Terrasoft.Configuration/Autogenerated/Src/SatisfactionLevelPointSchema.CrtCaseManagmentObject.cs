namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SatisfactionLevelPointSchema

	/// <exclude/>
	public class SatisfactionLevelPointSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SatisfactionLevelPointSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SatisfactionLevelPointSchema(SatisfactionLevelPointSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f9c9fd0-00ee-4522-83fe-fc6de0e0459a");
			Name = "SatisfactionLevelPoint";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,81,189,106,196,48,12,158,19,200,59,8,110,143,247,182,116,201,218,161,208,123,1,213,39,7,67,44,7,75,41,148,163,239,94,249,92,174,233,193,13,213,96,208,167,239,71,194,140,137,100,69,79,112,164,82,80,114,208,113,202,28,226,188,21,212,152,121,232,207,67,15,86,135,66,179,245,48,45,40,2,15,240,102,99,9,232,43,233,133,62,104,121,205,145,117,232,27,219,57,7,79,178,165,132,229,243,249,23,106,98,159,89,49,50,21,8,185,128,236,140,96,173,38,2,200,39,99,165,68,214,140,59,71,247,215,114,221,222,151,232,193,95,92,239,45,212,217,1,93,119,179,80,3,46,12,200,1,72,52,38,84,178,84,20,26,175,2,183,87,252,164,85,73,19,158,97,38,125,4,169,207,87,189,252,78,204,212,46,1,205,255,10,18,45,145,231,171,250,38,173,107,137,7,226,83,251,153,161,55,196,234,27,24,20,63,210,211,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f9c9fd0-00ee-4522-83fe-fc6de0e0459a"));
		}

		#endregion

	}

	#endregion

}


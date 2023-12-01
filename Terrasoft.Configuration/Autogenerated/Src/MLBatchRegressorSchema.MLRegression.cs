namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLBatchRegressorSchema

	/// <exclude/>
	public class MLBatchRegressorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLBatchRegressorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLBatchRegressorSchema(MLBatchRegressorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b141c318-5fc2-4336-be2b-b9cb83f27062");
			Name = "MLBatchRegressor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("97d940bd-1454-46d7-84c7-92245c2594a8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,146,65,107,131,64,16,133,207,9,228,63,12,246,98,160,232,189,53,57,36,165,16,72,66,40,233,169,244,176,110,70,179,160,187,50,187,82,210,208,255,222,113,181,6,45,241,182,111,103,222,188,249,92,45,74,180,149,144,8,71,36,18,214,100,46,90,27,157,169,188,38,225,148,209,209,110,59,155,94,103,211,73,109,149,206,7,85,132,207,119,244,232,85,72,103,72,161,229,10,174,121,32,204,217,11,214,133,176,246,9,118,219,149,112,242,252,134,57,161,181,134,124,77,28,199,144,216,186,44,5,93,150,221,185,171,104,90,85,89,21,88,162,118,232,124,46,200,12,177,17,164,141,19,84,132,39,37,125,222,63,171,120,228,149,88,68,81,88,3,146,48,91,4,247,215,141,186,120,251,186,68,82,242,208,90,27,10,32,110,188,62,94,48,19,117,225,86,74,159,120,243,208,93,42,52,89,184,233,186,250,242,249,35,236,25,46,44,56,37,143,176,206,70,183,117,14,100,82,94,231,200,189,243,79,54,173,234,180,80,18,100,195,231,31,30,232,137,141,35,113,231,213,195,187,17,110,38,81,221,92,50,232,131,183,109,43,198,124,189,176,209,202,41,81,168,111,180,32,64,227,23,40,238,23,154,223,131,201,192,157,209,99,235,144,141,115,5,241,178,77,28,245,254,241,120,64,82,9,18,37,104,38,177,8,106,139,196,1,53,250,63,21,44,143,236,223,104,32,123,49,74,98,223,225,13,58,42,227,185,225,251,192,7,134,182,115,198,149,10,139,225,88,110,30,241,228,167,195,133,250,212,18,243,231,86,29,138,94,227,239,23,124,85,176,6,34,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b141c318-5fc2-4336-be2b-b9cb83f27062"));
		}

		#endregion

	}

	#endregion

}


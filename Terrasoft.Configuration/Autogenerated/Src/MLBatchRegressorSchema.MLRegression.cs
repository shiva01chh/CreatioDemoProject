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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,146,65,107,194,64,16,133,207,10,254,135,33,189,40,148,228,222,70,15,90,10,130,138,20,123,42,61,172,235,68,23,146,221,48,187,75,177,210,255,222,217,77,26,49,197,220,246,237,204,155,55,95,86,139,10,109,45,36,194,14,137,132,53,133,75,23,70,23,234,232,73,56,101,116,186,94,141,134,151,209,112,224,173,210,199,155,42,194,231,59,122,250,42,164,51,164,208,114,5,215,60,16,30,217,11,22,165,176,246,9,214,171,185,112,242,244,134,71,66,107,13,197,154,44,203,32,183,190,170,4,157,103,237,185,173,8,173,170,170,75,172,80,59,116,49,23,20,134,216,8,246,193,9,106,194,131,146,49,239,159,85,214,243,202,45,162,40,173,1,73,88,76,147,251,235,166,109,188,141,175,144,148,220,54,214,134,18,200,130,215,199,11,22,194,151,110,174,244,129,55,31,187,115,141,166,24,47,219,174,174,124,242,8,27,134,11,83,78,201,35,172,179,233,117,157,45,153,61,175,179,227,222,201,39,155,214,126,95,42,9,50,240,249,135,7,58,98,253,72,220,121,137,240,174,132,195,36,242,225,146,65,111,163,109,83,209,231,27,133,165,86,78,137,82,125,163,5,1,26,191,64,113,191,208,252,30,76,1,238,132,17,91,139,172,159,43,201,102,77,226,180,243,207,250,3,242,90,144,168,64,51,137,105,226,45,18,7,212,24,255,84,50,219,177,127,208,64,118,98,154,103,177,35,26,180,84,250,115,199,239,55,62,112,107,59,97,92,123,97,113,220,151,195,35,30,252,180,184,80,31,26,98,241,220,168,183,98,212,194,247,11,209,139,98,107,35,3,0,0 };
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


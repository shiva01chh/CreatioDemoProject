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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,146,65,107,131,64,16,133,207,13,228,63,12,246,98,160,232,189,53,57,36,165,16,72,66,40,233,169,244,176,110,70,179,160,187,50,187,82,210,208,255,222,113,181,166,90,226,109,223,206,188,121,243,185,90,148,104,43,33,17,14,72,36,172,201,92,180,50,58,83,121,77,194,41,163,163,237,102,58,185,76,39,119,181,85,58,31,84,17,62,221,208,163,23,33,157,33,133,150,43,184,230,158,48,103,47,88,21,194,218,71,216,110,150,194,201,211,43,230,132,214,26,242,53,113,28,67,98,235,178,20,116,94,116,231,174,162,105,85,101,85,96,137,218,161,243,185,32,51,196,70,144,54,78,80,17,30,149,244,121,127,173,226,145,87,98,17,69,97,13,72,194,108,30,220,94,55,234,226,237,234,18,73,201,125,107,109,40,128,184,241,122,127,198,76,212,133,91,42,125,228,205,67,119,174,208,100,225,186,235,234,203,103,15,176,99,184,48,231,148,60,194,58,27,93,215,217,147,73,121,157,3,247,206,62,216,180,170,211,66,73,144,13,159,127,120,160,39,54,142,196,157,23,15,239,74,184,153,68,117,115,201,160,247,222,182,173,24,243,245,194,90,43,167,68,161,190,208,130,0,141,159,160,184,95,104,126,15,38,3,119,66,143,173,67,54,206,21,196,139,54,113,212,251,199,227,1,73,37,72,148,160,153,196,60,168,45,18,7,212,232,255,84,176,56,176,127,163,129,236,197,40,137,125,135,55,232,168,140,231,134,111,3,31,24,218,206,24,87,42,44,134,99,185,121,196,119,223,29,46,212,199,150,152,63,183,234,80,244,218,223,239,7,137,227,209,40,43,3,0,0 };
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


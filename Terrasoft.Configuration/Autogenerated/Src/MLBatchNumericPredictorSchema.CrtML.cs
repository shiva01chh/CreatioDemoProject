namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLBatchNumericPredictorSchema

	/// <exclude/>
	public class MLBatchNumericPredictorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLBatchNumericPredictorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLBatchNumericPredictorSchema(MLBatchNumericPredictorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0aff8371-c82b-4302-bc26-bde1d1357452");
			Name = "MLBatchNumericPredictor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,93,107,227,48,16,124,118,161,255,97,113,95,82,40,246,123,155,230,161,57,56,2,205,17,174,237,15,80,236,117,44,176,37,163,143,28,185,208,255,222,149,100,59,182,131,75,131,31,178,43,207,204,206,104,45,88,141,186,97,25,194,59,42,197,180,44,76,178,150,162,224,7,171,152,225,82,36,219,215,219,155,243,237,77,100,53,23,7,120,59,105,131,245,83,95,175,165,66,170,168,78,211,20,150,218,214,53,83,167,85,91,175,43,166,53,20,82,193,158,153,172,132,70,97,206,51,35,149,6,83,50,3,37,59,98,215,36,45,80,168,109,101,64,22,196,132,8,153,194,226,57,206,165,221,87,24,167,43,48,167,6,147,78,42,157,104,57,4,171,180,108,81,243,118,232,121,113,211,236,186,97,206,193,84,242,203,11,125,198,144,58,206,134,10,158,65,230,45,180,144,63,182,70,197,179,30,9,143,48,37,91,134,113,29,195,217,231,18,221,41,60,56,115,52,135,54,202,122,251,143,176,83,210,96,102,48,15,47,77,211,243,141,141,224,134,179,138,255,71,13,12,4,254,3,78,20,76,208,109,81,68,166,196,97,76,51,35,186,220,188,135,164,151,73,167,58,203,134,41,86,131,160,93,120,142,173,70,69,163,10,244,87,18,175,222,73,198,245,32,235,155,201,50,245,8,79,208,116,70,230,66,90,124,140,24,97,44,112,79,25,238,153,198,197,180,237,118,46,250,108,35,68,145,135,20,199,145,110,209,148,50,255,97,154,111,180,108,218,167,118,181,113,63,205,166,150,57,86,97,159,66,48,190,225,146,161,206,40,149,43,40,10,195,205,105,147,7,92,168,128,231,238,79,193,81,125,15,62,178,202,98,188,218,93,125,41,254,96,230,58,228,145,62,1,82,128,163,228,185,119,127,193,255,245,240,197,246,117,123,113,4,3,119,15,240,219,18,168,27,250,193,49,71,81,88,237,32,218,94,80,116,225,116,10,42,25,235,44,6,156,9,241,12,53,18,175,189,105,55,250,195,157,246,122,173,198,211,252,14,80,215,31,12,127,95,121,209,74,77,205,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0aff8371-c82b-4302-bc26-bde1d1357452"));
		}

		#endregion

	}

	#endregion

}


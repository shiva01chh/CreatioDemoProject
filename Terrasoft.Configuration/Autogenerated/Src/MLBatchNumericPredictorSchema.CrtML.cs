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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,93,107,227,48,16,124,118,161,255,97,241,189,228,160,216,239,109,154,135,203,193,17,104,142,112,109,127,128,98,173,99,129,45,25,125,228,200,133,254,247,91,73,182,19,59,184,52,248,33,187,242,204,236,140,214,146,53,104,90,86,32,188,161,214,204,168,210,102,107,37,75,113,112,154,89,161,100,182,125,185,191,59,223,223,37,206,8,121,128,215,147,177,216,60,13,245,90,105,164,138,234,60,207,97,105,92,211,48,125,90,117,245,186,102,198,64,169,52,236,153,45,42,104,53,114,81,88,165,13,216,138,89,168,216,17,251,38,105,129,70,227,106,11,170,36,38,68,40,52,150,207,41,87,110,95,99,154,175,192,158,90,204,122,169,124,162,229,17,172,54,170,67,205,219,161,231,135,159,102,215,15,115,142,166,178,159,65,232,35,133,220,115,182,84,136,2,138,96,161,131,252,118,13,106,81,12,72,120,132,41,217,50,142,235,25,206,33,151,228,155,198,131,55,71,115,24,171,93,176,255,8,59,173,44,22,22,121,124,105,154,94,104,108,164,176,130,213,226,31,26,96,32,241,47,8,162,96,146,110,139,34,178,21,94,199,52,51,162,207,45,120,200,6,153,124,170,179,108,153,102,13,72,218,133,231,212,25,212,52,170,196,112,37,233,234,141,100,124,15,138,161,153,45,243,128,8,4,109,111,100,46,164,197,251,136,17,198,2,223,41,195,61,51,184,152,182,253,206,37,31,93,132,40,121,76,113,28,233,22,109,165,248,23,211,124,165,101,51,33,181,155,141,251,106,54,141,226,88,199,125,138,193,132,134,79,134,58,163,84,110,160,40,173,176,167,13,143,184,88,129,224,254,79,41,80,127,14,62,178,218,97,186,218,221,124,41,225,96,230,58,212,145,62,1,82,128,163,18,60,184,191,224,255,4,248,98,251,178,189,56,130,43,119,15,240,203,17,168,31,250,193,51,39,73,92,237,40,218,93,80,114,225,244,10,58,27,235,44,174,56,51,226,185,214,200,130,246,166,219,232,119,127,58,232,117,26,79,243,59,64,221,112,64,191,255,92,92,9,4,196,4,0,0 };
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


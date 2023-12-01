namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLTextSimilarityProblemTypeFeaturesSchema

	/// <exclude/>
	public class MLTextSimilarityProblemTypeFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLTextSimilarityProblemTypeFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLTextSimilarityProblemTypeFeaturesSchema(MLTextSimilarityProblemTypeFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9fc5d315-3ac5-48a3-af06-cad122142a03");
			Name = "MLTextSimilarityProblemTypeFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d4e7fe16-4978-48c7-8486-0391de2e8fa7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,145,77,107,2,65,12,134,207,46,236,127,200,81,161,236,222,107,219,67,45,210,130,182,66,189,149,30,226,110,70,6,230,99,153,201,148,138,248,223,155,209,213,90,235,192,28,38,201,60,111,242,198,161,165,216,97,67,176,164,16,48,122,197,213,196,59,165,215,41,32,107,239,170,249,172,44,182,101,49,72,81,187,245,159,170,64,213,20,27,246,65,83,28,151,133,212,212,117,13,119,49,89,139,97,243,208,191,23,24,88,55,201,96,0,69,200,41,80,4,175,4,244,205,240,174,173,150,132,230,13,116,193,175,12,89,224,77,71,213,17,85,159,177,62,158,72,97,50,252,168,93,43,157,12,115,161,87,195,151,249,108,113,248,186,148,192,180,87,24,221,192,171,76,6,247,48,159,101,165,95,161,69,160,86,231,166,171,203,248,9,50,250,20,185,46,173,140,110,160,49,24,227,21,200,63,69,184,149,170,190,197,43,105,33,102,19,7,249,94,186,180,15,60,163,216,146,184,75,12,67,198,176,38,30,65,227,77,178,14,148,15,96,125,75,6,56,160,118,50,124,117,194,156,59,116,236,217,127,201,146,116,75,176,242,222,100,240,219,158,59,57,208,182,32,236,49,236,196,27,133,38,146,108,110,176,43,139,93,94,160,156,31,249,32,111,97,17,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9fc5d315-3ac5-48a3-af06-cad122142a03"));
		}

		#endregion

	}

	#endregion

}


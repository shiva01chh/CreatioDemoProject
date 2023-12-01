namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLDefaultProblemTypeFeaturesSchema

	/// <exclude/>
	public class MLDefaultProblemTypeFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLDefaultProblemTypeFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLDefaultProblemTypeFeaturesSchema(MLDefaultProblemTypeFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d30cac6-8bd4-4ed6-a823-a8838e7983e0");
			Name = "MLDefaultProblemTypeFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b54cb82a-9c72-40e4-855f-14a0ef44684e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,208,177,106,195,48,16,6,224,57,6,191,195,141,246,98,239,77,219,161,41,161,5,155,118,200,86,58,156,157,147,17,200,146,57,157,2,193,248,221,171,216,78,73,105,180,73,252,247,241,159,44,246,228,7,108,9,14,196,140,222,41,41,118,206,42,221,5,70,209,206,22,117,149,38,99,154,108,130,215,182,251,147,98,42,246,216,138,99,77,126,155,38,49,83,150,37,60,250,208,247,200,231,231,245,254,74,10,131,17,80,132,18,152,224,132,38,144,7,229,24,208,24,24,216,53,134,122,144,243,64,190,184,26,229,13,242,181,10,47,218,30,99,133,236,146,116,42,123,175,171,207,101,246,16,31,246,139,238,243,252,59,142,12,161,49,186,133,214,160,247,80,87,43,112,39,14,15,112,223,137,200,56,175,244,111,167,249,225,13,61,184,32,67,16,200,4,185,35,201,161,117,38,244,118,94,172,119,71,50,32,140,218,198,198,197,47,115,187,214,181,228,73,179,4,52,208,56,103,46,238,199,204,238,22,108,132,72,111,97,130,167,168,5,138,191,188,153,210,100,186,52,139,231,7,178,91,174,210,189,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d30cac6-8bd4-4ed6-a823-a8838e7983e0"));
		}

		#endregion

	}

	#endregion

}


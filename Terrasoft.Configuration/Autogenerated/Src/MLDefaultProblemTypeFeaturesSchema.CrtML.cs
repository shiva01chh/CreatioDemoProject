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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,208,61,107,195,48,16,6,224,57,6,255,135,27,237,197,222,155,182,67,83,66,11,54,237,144,173,116,56,59,39,35,144,116,70,31,129,96,252,223,43,127,164,184,52,218,36,222,123,120,79,6,53,185,30,91,130,19,89,139,142,133,47,14,108,132,236,130,69,47,217,20,117,149,38,67,154,236,130,147,166,251,147,178,84,28,177,245,108,37,185,125,154,196,76,89,150,240,232,130,214,104,175,207,235,253,149,4,6,229,65,16,250,96,9,46,168,2,57,16,108,1,149,130,222,114,163,72,131,191,246,228,138,155,81,110,144,175,85,120,145,230,28,43,100,83,146,69,246,94,87,159,203,236,41,62,28,23,221,229,249,119,28,233,67,163,100,11,173,66,231,160,174,86,224,78,28,30,224,190,19,145,97,94,233,223,78,243,195,27,58,224,224,251,224,33,243,104,59,242,57,180,172,130,54,243,98,154,207,164,192,91,148,38,54,46,126,153,237,90,183,146,23,105,125,64,5,13,179,154,220,143,153,61,44,216,0,145,222,195,8,79,81,11,20,127,121,55,166,201,56,53,219,158,31,203,144,16,243,198,1,0,0 };
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


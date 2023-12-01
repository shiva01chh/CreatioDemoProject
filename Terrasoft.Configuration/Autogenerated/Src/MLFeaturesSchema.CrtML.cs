namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLFeaturesSchema

	/// <exclude/>
	public class MLFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLFeaturesSchema(MLFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("67fb55d9-3f15-424b-9ada-e5b443f524e0");
			Name = "MLFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("55b53857-a033-4921-8f47-13b5471dd33e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,85,79,59,110,195,48,12,157,101,192,119,32,210,165,93,124,128,4,29,138,180,5,2,196,104,135,244,0,140,76,43,2,92,201,32,165,44,65,238,94,202,114,134,106,160,132,247,211,99,192,95,146,25,45,193,137,152,81,226,152,186,125,12,163,119,153,49,249,24,186,254,216,54,183,182,49,89,124,112,176,103,42,112,247,169,87,102,58,69,231,38,197,119,109,163,146,57,159,39,111,193,78,40,2,253,113,213,136,50,37,224,63,253,35,244,245,150,211,5,182,176,234,122,74,56,96,194,34,189,45,121,198,60,49,57,45,1,90,73,18,103,155,34,203,22,190,151,160,85,178,166,62,242,158,95,96,249,204,152,131,124,4,60,79,52,192,43,168,151,118,21,126,39,177,236,231,178,155,18,27,245,65,45,130,58,40,36,111,151,189,97,140,172,59,128,16,95,189,165,77,117,223,31,189,40,12,181,90,5,42,174,243,14,229,165,231,15,206,222,28,43,89,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("67fb55d9-3f15-424b-9ada-e5b443f524e0"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,85,79,205,106,195,48,12,62,59,144,119,16,221,101,189,228,1,90,118,24,221,6,133,134,237,208,61,128,234,40,158,33,179,131,100,239,82,250,238,147,227,20,54,31,100,243,253,249,83,192,111,146,25,45,193,153,152,81,226,152,186,67,12,163,119,153,49,249,24,186,254,212,54,215,182,49,89,124,112,112,96,42,112,247,166,87,102,58,71,231,38,197,247,109,163,146,57,95,38,111,193,78,40,2,253,105,213,136,50,37,224,63,253,41,244,254,156,211,23,236,96,213,245,148,112,192,132,69,122,93,242,140,121,96,114,90,2,180,146,36,206,54,69,150,29,124,44,65,171,100,77,189,231,61,110,97,249,204,152,163,188,6,188,76,52,192,19,168,151,246,21,126,33,177,236,231,178,155,18,27,245,65,45,130,58,40,36,111,151,189,97,140,172,59,128,16,255,120,75,155,234,190,221,123,81,24,106,181,10,84,92,231,13,202,235,239,249,5,236,61,43,123,98,1,0,0 };
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


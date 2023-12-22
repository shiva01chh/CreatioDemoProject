namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchFeaturesSchema

	/// <exclude/>
	public class GlobalSearchFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchFeaturesSchema(GlobalSearchFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ce6e5c0-35f8-4d5b-be9a-e16f527da2d1");
			Name = "GlobalSearchFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ca3090cb-7cbd-4956-acde-76442c58fa1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,106,195,48,12,134,207,9,228,29,68,119,217,46,121,128,150,29,70,214,149,29,198,6,235,30,64,113,148,212,224,218,65,178,119,9,123,247,57,177,195,218,194,124,176,225,211,175,15,201,22,207,36,35,42,130,35,49,163,184,222,215,141,179,189,30,2,163,215,206,214,7,227,90,52,159,132,172,78,85,57,85,101,17,68,219,1,26,166,57,80,191,196,39,48,29,221,48,152,200,119,85,25,35,119,76,67,108,134,198,160,200,22,46,29,57,47,75,110,12,173,209,10,212,28,251,39,85,76,75,242,86,249,37,244,254,20,252,41,21,175,60,107,9,182,144,53,111,228,177,67,143,115,52,235,254,124,206,138,231,160,188,227,168,253,88,68,57,146,173,171,239,254,1,166,133,23,175,178,183,216,26,234,224,17,98,47,237,18,126,38,81,172,199,249,219,98,97,19,251,32,13,130,241,34,235,181,90,190,20,122,199,121,89,72,219,130,16,127,107,69,155,36,250,89,71,36,219,165,41,19,200,252,6,39,122,13,35,187,60,191,47,92,51,247,230,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ce6e5c0-35f8-4d5b-be9a-e16f527da2d1"));
		}

		#endregion

	}

	#endregion

}


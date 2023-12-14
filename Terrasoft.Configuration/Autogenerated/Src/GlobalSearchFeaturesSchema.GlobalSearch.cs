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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,207,74,196,48,16,135,207,45,244,29,134,245,162,151,62,192,46,30,164,254,193,131,40,184,62,192,52,157,118,3,49,41,51,137,151,226,187,155,52,41,186,11,230,144,192,55,191,249,152,137,197,79,146,25,21,193,145,152,81,220,232,219,206,217,81,79,129,209,107,103,219,39,227,122,52,239,132,172,78,77,189,52,117,21,68,219,9,58,166,20,104,31,227,19,152,142,110,154,76,228,135,166,142,145,43,166,41,54,67,103,80,100,15,127,29,37,47,107,110,14,189,209,10,84,138,253,147,170,150,53,121,169,252,16,122,189,11,254,148,139,103,158,173,4,123,40,154,23,242,56,160,199,20,45,186,95,159,179,226,57,40,239,56,106,223,86,81,137,20,235,230,187,190,129,101,229,213,179,60,88,236,13,13,112,11,177,151,14,25,223,147,40,214,115,250,182,88,216,197,62,200,131,96,188,200,122,173,214,47,133,209,113,89,22,242,182,32,196,95,90,209,46,139,190,183,17,201,14,121,202,12,10,191,192,153,158,195,200,210,249,1,24,245,58,88,222,1,0,0 };
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


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EnrichmentFeaturesSchema

	/// <exclude/>
	public class EnrichmentFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EnrichmentFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EnrichmentFeaturesSchema(EnrichmentFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b04c4e9f-9c27-4baf-aabc-9d025acb482c");
			Name = "EnrichmentFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("523e180e-845f-4752-bb0d-120bebcd70d6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,193,106,195,48,12,134,207,9,228,29,68,119,217,46,201,189,93,7,163,235,160,135,177,29,186,7,80,29,37,53,36,118,144,236,194,40,125,247,57,118,186,172,12,230,131,108,126,255,254,253,73,6,123,146,1,21,193,158,152,81,108,227,202,141,53,141,110,61,163,211,214,148,91,195,90,29,123,50,174,200,207,69,158,121,209,166,133,13,211,120,93,190,134,205,51,237,109,219,118,65,95,21,121,176,12,254,208,105,5,170,67,17,152,223,79,94,9,142,49,232,214,246,41,244,254,236,221,17,150,48,249,222,200,97,141,14,71,235,57,230,102,217,29,83,27,160,32,32,138,99,175,156,101,89,194,71,12,154,44,85,85,193,163,248,190,71,254,122,250,81,66,60,164,124,12,37,192,104,21,219,131,198,50,160,82,36,177,173,25,22,132,248,164,21,149,115,104,117,147,58,209,95,185,239,31,32,54,149,101,59,217,26,60,116,84,195,26,2,35,173,146,252,66,162,88,15,241,211,53,44,254,5,250,139,177,72,41,151,235,28,200,212,105,20,73,72,122,168,23,24,79,191,215,55,106,66,174,204,226,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b04c4e9f-9c27-4baf-aabc-9d025acb482c"));
		}

		#endregion

	}

	#endregion

}


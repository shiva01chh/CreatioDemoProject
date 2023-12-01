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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,193,106,195,48,12,134,207,9,244,29,68,119,217,46,201,189,93,7,165,235,96,135,177,29,186,7,80,29,37,53,36,118,144,236,193,40,125,247,41,113,186,80,6,243,65,54,191,127,255,254,36,135,29,73,143,134,224,64,204,40,190,14,197,206,187,218,54,145,49,88,239,138,189,99,107,78,29,185,176,200,207,139,60,139,98,93,3,59,166,225,186,120,209,45,50,29,124,211,180,170,175,23,185,90,250,120,108,173,1,211,162,8,204,239,39,175,168,99,8,186,181,125,10,189,111,99,56,193,10,38,223,27,5,172,48,224,96,61,143,185,89,118,199,212,40,20,40,162,4,142,38,120,150,21,124,140,65,147,165,44,75,120,148,216,117,200,223,79,191,138,198,67,202,71,45,10,99,205,216,30,212,158,1,141,33,25,219,154,97,65,136,191,172,161,98,14,45,111,82,39,250,43,247,253,3,140,77,101,217,171,236,29,30,91,170,96,3,202,72,235,36,63,147,24,182,253,248,233,6,150,255,2,253,197,88,166,148,203,117,14,228,170,52,138,36,36,93,235,5,134,147,174,31,185,45,57,26,217,1,0,0 };
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


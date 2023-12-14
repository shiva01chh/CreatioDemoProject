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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,193,106,195,48,12,134,207,9,228,29,68,119,217,46,201,189,93,7,165,107,161,135,177,29,186,7,80,29,37,53,36,118,144,236,193,40,125,247,57,118,186,80,6,243,65,54,191,127,255,254,36,131,61,201,128,138,224,72,204,40,182,113,229,214,154,70,183,158,209,105,107,202,157,97,173,206,61,25,87,228,151,34,207,188,104,211,194,150,105,188,46,247,97,243,76,71,219,182,93,208,87,69,30,44,131,63,117,90,129,234,80,4,230,247,147,87,130,99,12,186,183,125,10,189,111,188,59,195,18,38,223,27,57,172,209,225,104,189,196,220,44,123,96,106,3,20,4,68,113,236,149,179,44,75,248,136,65,147,165,170,42,120,22,223,247,200,223,47,191,74,136,135,148,143,161,4,24,173,98,123,208,88,6,84,138,36,182,53,195,130,16,127,105,69,229,28,90,221,165,78,244,55,238,199,39,136,77,101,217,65,118,6,79,29,213,176,134,192,72,171,36,191,146,40,214,67,252,116,13,139,127,129,254,98,44,82,202,245,54,7,50,117,26,69,18,146,30,234,21,198,211,184,126,0,150,52,112,128,218,1,0,0 };
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


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GenAIFeaturesSchema

	/// <exclude/>
	public class GenAIFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GenAIFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GenAIFeaturesSchema(GenAIFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c34afc2a-3a9e-42a3-8317-da9524c6d9bf");
			Name = "GenAIFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("cb0914d9-1fee-4752-8315-10e295faf1dc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,193,106,195,48,12,134,207,13,228,29,68,79,219,37,15,176,178,67,105,214,145,195,118,89,247,0,170,163,4,131,99,27,203,134,193,232,187,79,118,210,178,195,198,214,49,19,39,32,125,255,47,253,16,139,19,177,71,69,112,160,16,144,221,16,155,157,179,131,30,83,192,168,157,109,30,201,110,187,186,122,175,171,85,98,109,71,216,5,202,157,102,47,159,20,232,224,198,209,72,125,83,87,130,248,116,52,90,1,71,65,20,40,131,204,80,28,22,154,133,201,86,103,240,66,144,140,163,86,77,119,176,144,79,20,177,199,136,25,46,138,179,228,19,124,115,11,115,107,213,241,131,197,163,161,30,238,33,134,68,155,185,220,18,171,160,125,14,34,141,245,43,19,108,59,24,92,128,113,118,201,129,196,168,148,208,123,241,47,169,215,179,254,148,223,167,18,236,155,133,105,114,173,44,121,197,214,139,226,127,86,239,197,13,242,188,191,6,120,166,183,248,18,201,243,239,19,92,36,95,71,24,208,240,85,25,172,248,201,15,35,134,63,132,200,87,158,124,62,0,61,75,110,131,183,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c34afc2a-3a9e-42a3-8317-da9524c6d9bf"));
		}

		#endregion

	}

	#endregion

}


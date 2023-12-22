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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,193,106,195,48,12,134,207,13,228,29,68,79,219,37,15,176,178,67,105,182,145,195,118,89,247,0,170,163,152,128,99,27,203,134,193,232,187,79,118,210,210,195,198,214,49,19,39,32,125,255,47,253,16,139,19,177,71,69,176,167,16,144,221,16,155,157,179,195,168,83,192,56,58,219,60,145,221,118,117,245,81,87,171,196,163,213,176,11,148,59,205,163,124,82,160,189,211,218,72,125,83,87,130,248,116,48,163,2,142,130,40,80,6,153,161,56,44,52,11,147,173,78,224,153,32,25,71,173,154,238,96,33,159,41,98,143,17,51,92,20,39,201,5,124,115,11,115,107,213,241,131,197,131,161,30,238,33,134,68,155,185,220,18,171,48,250,28,68,26,235,55,38,216,118,48,184,0,122,118,201,129,196,168,148,208,123,241,47,169,215,179,254,152,223,199,18,236,155,133,105,114,173,44,121,197,214,139,226,127,86,239,197,13,242,188,191,6,120,161,247,248,26,201,243,239,19,156,37,95,71,24,208,240,85,25,172,248,201,15,35,134,63,132,200,87,158,203,243,9,73,0,213,95,191,2,0,0 };
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


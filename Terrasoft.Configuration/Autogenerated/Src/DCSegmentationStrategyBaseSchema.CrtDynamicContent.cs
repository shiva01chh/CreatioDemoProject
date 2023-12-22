namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCSegmentationStrategyBaseSchema

	/// <exclude/>
	public class DCSegmentationStrategyBaseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCSegmentationStrategyBaseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCSegmentationStrategyBaseSchema(DCSegmentationStrategyBaseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1a5fefef-c426-40f0-a77a-e097708df1d9");
			Name = "DCSegmentationStrategyBase";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("41c9b305-ccaa-4408-abc9-8158dd3fa84a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,83,77,143,155,64,12,61,39,82,254,131,149,94,118,165,10,238,205,135,180,37,171,158,170,174,54,237,15,112,192,192,72,48,67,103,76,182,40,234,127,175,25,32,37,17,217,230,84,110,120,236,231,247,252,108,141,37,185,10,99,130,239,100,45,58,147,114,16,25,157,170,172,182,200,202,232,96,215,104,44,85,44,65,38,205,139,249,105,49,159,213,78,233,12,246,141,99,42,87,139,185,68,62,88,202,36,27,162,2,157,251,4,187,104,79,89,41,249,30,99,207,130,69,89,243,25,29,249,236,48,12,97,237,234,178,68,219,108,251,255,87,170,44,57,41,113,224,186,124,69,14,56,71,6,180,4,174,195,107,251,162,6,172,19,69,58,166,96,0,11,71,104,85,125,40,84,12,120,104,113,98,134,184,229,244,46,165,217,201,211,250,171,194,104,169,173,99,54,86,196,188,120,188,46,227,154,185,15,68,150,4,204,129,240,55,197,145,236,32,160,1,37,56,40,60,225,77,113,14,8,34,49,161,84,105,74,32,110,7,250,139,131,51,106,120,13,187,174,208,98,9,50,126,218,44,221,136,124,212,149,46,183,79,50,22,6,147,142,113,125,17,49,89,247,17,222,114,21,231,126,124,157,99,135,102,52,219,96,29,250,92,223,175,159,217,237,33,61,92,62,245,20,96,130,214,35,180,43,50,155,77,165,111,166,10,86,109,250,239,222,1,210,73,103,194,165,35,47,214,84,100,89,104,223,225,199,104,149,56,167,97,210,144,26,123,54,196,181,83,91,59,146,87,75,233,102,121,91,248,50,220,222,240,104,114,102,131,210,169,216,9,50,226,21,252,67,234,87,226,220,36,247,232,220,121,203,93,111,179,165,74,210,17,92,110,234,34,129,67,123,51,154,129,141,188,196,170,146,123,185,181,108,215,7,163,244,153,255,83,127,104,15,143,171,255,64,196,71,44,113,109,181,219,254,208,234,103,77,160,146,246,236,83,37,103,117,109,217,107,215,72,28,2,177,118,244,244,165,86,73,240,92,86,220,180,238,173,195,1,114,74,108,155,59,168,221,203,145,20,244,44,253,184,121,95,241,190,211,102,169,52,71,2,44,10,104,247,211,187,141,5,36,200,120,231,172,143,70,218,71,5,161,253,86,237,164,236,220,246,106,61,186,165,185,12,250,216,248,251,3,211,7,72,192,206,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1a5fefef-c426-40f0-a77a-e097708df1d9"));
		}

		#endregion

	}

	#endregion

}


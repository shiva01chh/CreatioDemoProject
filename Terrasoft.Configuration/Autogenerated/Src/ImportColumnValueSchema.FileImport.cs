namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportColumnValueSchema

	/// <exclude/>
	public class ImportColumnValueSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportColumnValueSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportColumnValueSchema(ImportColumnValueSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f8ae54ba-7ca1-412e-af1f-79f7b6e20f3d");
			Name = "ImportColumnValue";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,77,107,219,64,16,61,43,144,255,48,40,23,155,22,233,94,71,130,98,19,200,33,33,56,37,151,210,195,90,30,169,11,171,93,49,187,106,234,154,252,247,238,135,36,75,177,99,28,31,12,251,102,230,205,188,153,103,75,86,163,110,88,129,240,3,137,152,86,165,73,150,74,150,188,106,137,25,174,100,114,199,5,222,215,141,34,115,125,181,191,190,138,90,205,101,5,207,59,109,176,94,188,123,39,43,206,42,169,180,225,133,62,138,173,91,105,120,141,201,51,18,103,130,255,243,244,54,203,230,221,16,86,246,1,75,193,180,254,6,161,221,82,137,182,150,47,76,180,232,147,210,52,133,91,221,214,53,163,93,222,189,191,75,224,82,27,38,173,0,85,130,249,205,53,20,142,4,8,27,66,141,210,104,224,158,14,10,207,7,127,28,97,210,243,165,35,194,159,43,220,180,85,133,180,226,186,17,108,55,139,125,243,108,31,195,23,144,118,81,170,156,121,100,110,223,241,91,60,255,229,138,6,57,27,129,14,104,218,141,224,69,55,197,9,37,209,222,171,25,52,223,113,20,91,43,250,201,215,133,216,123,169,30,8,44,86,239,22,255,38,67,214,88,128,85,192,12,123,192,122,131,52,123,180,3,67,6,113,144,125,239,170,194,196,253,132,218,144,187,206,242,16,95,156,233,190,86,175,159,110,77,234,245,227,190,235,46,216,53,189,65,185,13,27,153,174,231,137,84,131,100,56,94,178,162,151,254,182,23,14,232,189,112,114,58,207,4,123,168,208,44,64,187,175,183,243,115,218,31,141,45,109,11,163,232,162,99,18,50,131,122,234,222,93,131,54,19,17,10,194,50,139,143,204,19,167,249,7,226,60,210,48,98,181,55,106,214,41,203,195,66,110,83,31,58,157,57,246,71,62,241,216,217,178,225,182,249,193,25,227,130,110,157,71,26,102,221,130,253,128,95,251,117,143,134,24,176,190,131,59,84,60,7,247,223,19,69,35,183,90,188,152,120,215,134,195,217,178,192,30,160,245,129,134,14,150,139,162,19,247,236,176,233,137,45,230,62,255,1,7,156,201,61,41,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f8ae54ba-7ca1-412e-af1f-79f7b6e20f3d"));
		}

		#endregion

	}

	#endregion

}


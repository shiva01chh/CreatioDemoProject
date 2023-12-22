namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportParamsGeneratorSchema

	/// <exclude/>
	public class IImportParamsGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportParamsGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportParamsGeneratorSchema(IImportParamsGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36bfcac9-e88e-4dbb-b7ce-a67ca5579bb2");
			Name = "IImportParamsGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,82,177,110,194,48,16,157,131,196,63,156,96,105,37,148,236,37,205,66,41,98,168,132,4,234,238,134,35,88,138,237,232,236,32,161,170,255,94,231,12,33,133,146,165,75,89,130,207,239,222,189,247,124,90,40,180,149,200,17,54,72,36,172,217,185,120,102,244,78,22,53,9,39,141,30,14,62,135,131,168,182,82,23,176,62,90,135,202,223,151,37,230,205,165,141,23,168,145,100,62,109,49,119,104,226,87,89,226,82,85,134,220,239,88,194,120,174,157,116,18,173,7,120,200,152,176,240,141,176,212,14,105,231,21,62,193,50,16,172,4,9,101,121,178,112,134,24,157,36,9,164,182,86,74,208,49,59,157,87,100,14,114,139,22,20,186,189,217,90,216,25,2,201,20,80,49,7,20,129,164,17,120,38,73,58,44,85,253,81,202,28,228,89,194,93,5,81,19,82,43,217,15,174,144,26,43,172,237,70,28,23,22,232,44,184,61,66,110,202,90,105,56,136,178,70,27,183,248,228,186,33,101,68,123,220,244,180,94,144,47,146,31,202,243,164,214,145,15,125,2,225,155,193,140,155,223,185,23,88,127,84,32,191,78,244,21,116,143,81,111,131,165,211,249,228,239,45,228,217,148,122,236,113,56,24,60,114,220,232,83,236,53,200,40,208,30,249,60,10,158,70,89,99,243,228,47,77,24,240,59,30,155,229,57,174,243,61,42,17,186,66,5,44,151,110,155,9,93,77,218,102,105,114,254,215,92,117,222,151,229,182,62,46,165,135,121,103,20,116,231,78,160,39,238,96,226,113,218,187,18,127,203,236,63,100,112,54,120,181,59,97,163,126,22,185,214,253,125,3,251,182,210,128,141,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36bfcac9-e88e-4dbb-b7ce-a67ca5579bb2"));
		}

		#endregion

	}

	#endregion

}


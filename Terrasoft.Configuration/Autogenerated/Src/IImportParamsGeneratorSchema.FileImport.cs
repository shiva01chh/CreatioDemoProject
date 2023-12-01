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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,82,177,110,194,48,16,157,131,196,63,156,96,105,37,148,236,37,205,66,41,98,168,132,4,234,238,134,35,88,138,237,232,236,32,161,170,255,94,231,28,2,133,146,165,75,89,130,207,239,222,189,247,124,90,40,180,149,200,17,54,72,36,172,217,185,120,102,244,78,22,53,9,39,141,30,14,62,135,131,168,182,82,23,176,62,90,135,202,223,151,37,230,205,165,141,23,168,145,100,62,237,48,119,104,226,87,89,226,82,85,134,220,239,88,194,120,174,157,116,18,173,7,120,200,152,176,240,141,176,212,14,105,231,21,62,193,50,16,172,4,9,101,121,178,112,134,24,157,36,9,164,182,86,74,208,49,107,207,43,50,7,185,69,11,10,221,222,108,45,236,12,129,100,10,168,152,3,138,64,210,8,60,145,36,23,44,85,253,81,202,28,228,73,194,93,5,81,19,82,39,217,15,174,144,26,43,172,237,70,28,23,22,232,44,184,61,66,110,202,90,105,56,136,178,70,27,119,248,228,186,33,101,68,119,220,244,180,158,145,47,146,31,202,243,164,214,145,15,125,2,225,155,193,140,155,223,185,23,88,127,84,32,191,78,244,21,116,143,81,111,131,165,246,220,250,123,11,121,54,165,30,123,28,14,6,143,28,55,250,20,123,13,50,10,180,71,62,143,130,167,81,214,216,108,253,165,9,3,126,199,99,179,60,199,117,190,71,37,66,87,168,128,229,210,109,51,161,171,73,219,44,77,78,255,154,171,139,247,101,185,157,143,115,233,97,126,49,10,46,231,78,160,39,238,96,226,113,218,187,18,127,203,236,63,100,112,50,120,181,59,97,163,126,22,185,230,127,223,128,58,47,23,132,4,0,0 };
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


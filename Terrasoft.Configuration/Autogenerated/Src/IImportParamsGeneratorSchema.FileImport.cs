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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,82,177,110,194,48,16,157,131,196,63,156,96,105,37,148,236,37,101,161,20,49,84,66,2,117,119,195,17,44,197,118,116,118,144,80,213,127,175,125,134,64,161,100,233,82,150,224,243,187,119,239,61,159,22,10,109,45,10,132,53,18,9,107,182,46,157,26,189,149,101,67,194,73,163,251,189,207,126,47,105,172,212,37,172,14,214,161,242,247,85,133,69,184,180,233,28,53,146,44,198,45,230,14,77,250,42,43,92,168,218,144,251,29,75,152,206,180,147,78,162,245,0,15,25,18,150,190,17,22,218,33,109,189,194,39,88,68,130,165,32,161,44,79,22,206,16,163,179,44,131,220,54,74,9,58,76,142,231,37,153,189,220,160,5,133,110,103,54,22,182,134,64,50,5,212,204,1,101,36,9,2,79,36,217,5,75,221,124,84,178,0,121,146,112,87,65,18,66,106,37,251,193,53,82,176,194,218,110,196,113,97,142,206,130,219,33,20,166,106,148,134,189,168,26,180,105,139,207,174,27,114,70,180,199,117,71,235,25,249,34,249,161,60,79,110,29,249,208,71,16,191,19,152,114,243,59,247,2,235,79,74,228,215,73,190,162,238,33,234,77,180,116,60,31,253,189,197,60,67,169,195,30,135,131,209,35,199,141,62,197,78,131,140,2,237,145,207,131,232,105,48,9,54,143,254,242,140,1,191,227,49,44,207,97,85,236,80,137,216,21,43,96,185,116,219,76,232,26,210,118,146,103,167,127,225,234,226,125,89,110,235,227,92,122,152,93,140,130,203,185,35,232,136,59,154,120,28,119,174,196,223,50,251,15,25,156,12,94,237,78,220,168,159,69,174,133,223,55,137,170,120,223,133,4,0,0 };
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


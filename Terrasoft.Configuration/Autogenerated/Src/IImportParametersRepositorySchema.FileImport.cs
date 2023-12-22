namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportParametersRepositorySchema

	/// <exclude/>
	public class IImportParametersRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportParametersRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportParametersRepositorySchema(IImportParametersRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0944487b-5887-4694-84cc-de8e541b2ac6");
			Name = "IImportParametersRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a83ae89b-1206-453d-b626-f37ab41fffbf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,148,201,110,219,48,16,134,207,54,224,119,24,228,148,2,134,116,111,85,95,146,212,224,169,65,220,229,76,139,35,151,40,69,10,36,149,64,40,250,238,229,34,217,218,146,218,110,13,1,134,134,179,124,243,107,56,146,150,104,42,154,35,124,65,173,169,81,133,77,238,148,44,248,161,214,212,114,37,147,79,92,32,41,43,165,237,106,249,107,181,92,212,134,203,3,236,26,99,177,252,48,122,119,161,66,96,238,227,76,178,69,137,154,231,19,31,242,217,153,156,177,170,247,130,231,192,165,69,93,120,2,18,203,60,82,237,160,156,209,60,97,165,12,183,74,55,240,30,200,131,180,220,54,39,91,54,118,223,184,164,158,112,145,166,41,100,166,46,75,170,155,77,103,248,90,49,106,17,140,165,7,4,85,0,15,209,96,208,24,135,123,12,75,199,113,89,229,11,128,116,69,62,222,112,118,179,201,210,96,153,119,144,248,18,177,118,190,206,208,249,89,113,214,98,244,124,110,183,181,51,115,182,134,147,210,225,192,60,200,218,165,29,36,124,23,165,155,239,240,30,133,211,1,170,163,32,80,40,125,101,159,177,100,140,33,108,166,143,88,172,133,31,122,191,9,185,69,107,58,166,156,202,28,5,20,130,30,146,255,1,22,188,53,218,90,75,179,33,211,26,89,218,29,122,239,189,82,194,227,16,67,250,73,239,66,0,178,203,91,107,39,204,151,106,203,34,187,126,210,198,141,146,65,22,32,44,185,104,16,191,81,81,227,156,240,147,47,27,5,24,104,114,181,22,149,86,185,243,119,180,83,33,174,254,228,23,42,209,50,244,34,59,42,46,221,54,144,126,243,176,169,12,253,139,250,216,165,152,21,98,13,193,122,172,115,246,252,247,110,234,11,183,63,122,92,185,42,43,127,191,222,210,168,155,229,123,30,22,174,59,139,89,126,98,3,220,204,53,9,84,50,120,142,131,48,3,49,186,31,167,188,153,239,111,13,147,125,235,155,249,238,74,118,242,28,177,111,255,38,1,20,110,215,65,161,85,9,108,127,78,147,79,225,63,134,25,171,145,150,35,218,93,48,250,220,126,141,198,183,203,199,182,93,161,231,210,253,195,152,246,150,168,7,126,21,117,241,123,181,116,79,255,247,7,164,251,230,25,180,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0944487b-5887-4694-84cc-de8e541b2ac6"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,148,201,110,219,48,16,134,207,54,224,119,24,228,148,2,134,116,111,85,95,146,212,224,169,65,220,229,76,139,35,151,40,69,18,36,149,64,40,250,238,37,69,201,214,150,212,118,107,8,48,52,156,229,155,95,195,145,180,68,171,105,142,240,5,141,161,86,21,46,185,83,178,224,135,202,80,199,149,76,62,113,129,164,212,202,184,213,242,215,106,185,168,44,151,7,216,213,214,97,249,97,244,238,67,133,192,60,196,217,100,139,18,13,207,39,62,228,179,55,121,163,174,246,130,231,192,165,67,83,4,2,18,203,60,82,227,161,188,209,62,161,86,150,59,101,106,120,15,228,65,58,238,234,147,45,27,187,111,124,210,64,184,72,211,20,50,91,149,37,53,245,166,51,124,213,140,58,4,235,232,1,65,21,192,155,104,176,104,173,199,61,134,165,227,184,76,135,2,32,125,145,143,55,156,221,108,178,180,177,204,59,72,124,137,88,187,80,103,232,252,172,56,107,49,122,62,183,219,202,155,57,91,195,73,233,230,192,62,200,202,167,29,36,124,23,165,155,239,240,30,133,215,1,244,81,16,40,148,185,178,207,88,50,198,16,54,211,71,44,214,194,15,189,223,132,220,162,179,29,83,78,101,142,2,10,65,15,201,255,0,107,188,13,186,202,72,187,33,211,26,89,218,29,6,239,189,82,34,224,16,75,250,73,239,154,0,100,151,183,214,78,88,40,213,150,69,118,253,164,141,27,37,131,44,64,88,114,209,32,126,163,162,194,57,225,39,95,54,10,48,208,228,106,45,180,81,185,247,247,180,83,33,174,254,228,23,42,209,50,244,34,59,42,46,253,54,144,97,243,176,169,12,253,139,250,216,165,152,21,98,13,141,245,88,231,236,249,239,221,212,23,238,126,244,184,114,85,234,112,191,222,210,168,155,229,123,222,44,92,127,22,179,252,196,26,184,157,107,18,168,100,240,28,7,97,6,98,116,63,78,121,179,208,223,26,38,251,54,52,243,221,151,236,228,57,98,223,254,77,2,40,252,174,131,194,168,18,216,254,156,38,159,154,255,24,102,157,65,90,142,104,119,141,49,228,14,107,52,190,93,62,182,237,10,61,151,238,31,198,180,183,68,3,240,171,168,139,223,171,165,127,194,239,15,129,118,28,115,172,7,0,0 };
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


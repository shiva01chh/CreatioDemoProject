namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceTermCalculatorServiceSchema

	/// <exclude/>
	public class ServiceTermCalculatorServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceTermCalculatorServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceTermCalculatorServiceSchema(ServiceTermCalculatorServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3f571728-8b0d-420c-b89e-e23ca6aab2b4");
			Name = "ServiceTermCalculatorService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,193,110,218,64,16,61,19,41,255,176,162,23,35,89,254,0,104,43,145,68,169,90,137,4,97,170,28,80,14,139,61,144,109,237,93,119,102,77,101,161,252,123,103,119,109,199,105,83,210,75,213,75,17,2,237,236,155,55,111,102,30,70,203,18,168,146,25,136,53,32,74,50,59,155,92,26,189,83,251,26,165,85,70,39,151,178,0,157,75,164,243,179,227,249,217,168,38,165,247,191,5,167,128,7,149,1,95,151,179,30,156,54,100,161,100,100,81,64,230,96,148,124,0,13,168,178,95,48,109,254,194,228,80,156,188,76,238,96,123,26,48,231,82,7,175,106,246,170,108,167,151,251,204,234,194,159,91,158,151,242,184,44,231,150,165,103,229,251,77,139,101,62,139,50,179,247,46,54,167,234,6,44,195,42,166,219,170,66,217,102,5,223,106,133,80,130,182,20,13,15,78,172,120,39,94,73,113,168,164,13,228,19,87,164,170,183,133,202,68,86,72,34,49,24,123,215,134,193,54,40,166,226,66,18,180,39,206,60,122,225,163,55,8,123,238,85,44,192,62,152,156,166,98,233,25,195,229,230,182,130,48,155,97,99,163,13,183,255,81,31,204,87,136,66,26,43,31,47,111,211,245,56,22,78,29,144,189,54,88,74,203,113,134,46,128,72,238,33,132,146,79,100,116,44,46,76,222,164,182,41,224,25,164,143,38,119,40,171,10,242,216,149,27,173,216,155,108,23,56,77,58,9,218,16,108,141,122,42,90,192,82,34,123,219,2,70,55,252,237,132,186,241,116,140,227,144,212,78,113,48,191,14,32,186,65,250,40,69,87,202,91,87,98,243,150,44,178,41,98,97,182,95,216,207,239,69,102,116,174,188,175,39,226,232,117,31,36,138,172,95,4,215,214,240,253,229,37,69,79,201,177,248,76,128,60,111,29,126,37,147,89,207,133,173,168,43,150,195,108,79,212,73,175,114,53,128,68,131,84,50,69,237,216,78,164,166,3,72,151,26,134,249,179,238,126,56,161,77,222,143,244,82,215,202,79,120,40,51,44,112,212,113,183,136,161,26,15,120,244,229,30,221,199,127,223,61,247,221,112,45,243,29,19,46,101,77,240,111,141,248,87,221,244,199,94,241,143,47,254,83,10,79,48,62,113,140,223,252,250,1,100,122,102,216,207,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f571728-8b0d-420c-b89e-e23ca6aab2b4"));
		}

		#endregion

	}

	#endregion

}


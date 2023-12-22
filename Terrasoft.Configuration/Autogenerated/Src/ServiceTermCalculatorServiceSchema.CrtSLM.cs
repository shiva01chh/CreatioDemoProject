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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,193,110,218,64,16,61,19,41,255,176,162,23,35,33,127,0,180,149,72,162,84,173,68,130,48,85,14,40,135,197,30,200,182,246,174,59,179,166,66,40,255,222,217,93,219,217,180,41,233,165,234,165,8,129,118,246,205,155,55,51,15,163,101,5,84,203,28,196,10,16,37,153,173,77,47,141,222,170,93,131,210,42,163,211,75,89,130,46,36,210,249,217,241,252,108,208,144,210,187,223,130,51,192,189,202,129,175,171,105,15,206,14,100,161,98,100,89,66,238,96,148,126,0,13,168,242,95,48,109,254,220,20,80,158,188,76,239,96,115,26,48,227,82,123,175,106,250,170,108,167,151,251,204,155,210,159,91,158,151,242,184,44,231,86,149,103,229,251,117,139,101,62,139,50,183,247,46,54,163,250,6,44,195,106,166,219,168,82,217,195,18,190,53,10,161,2,109,41,137,15,78,172,120,39,94,73,113,168,180,13,20,35,87,164,110,54,165,202,69,94,74,34,17,141,189,107,195,96,27,20,19,113,33,9,218,19,103,30,189,240,193,27,132,29,247,42,230,96,31,76,65,19,177,240,140,225,114,125,91,67,152,77,220,216,96,205,237,127,212,123,243,21,146,144,198,202,135,139,219,108,53,28,11,167,14,200,94,27,172,164,229,56,67,231,64,36,119,16,66,233,39,50,122,44,46,76,113,200,236,161,132,103,144,62,154,222,161,172,107,40,198,174,220,96,201,222,100,187,192,105,210,81,208,134,96,27,212,19,209,2,22,18,217,219,22,48,185,225,111,39,212,141,167,99,28,134,164,118,138,209,252,58,128,232,6,233,163,148,92,41,111,93,137,135,183,100,145,77,49,22,102,243,133,253,252,94,228,70,23,202,251,122,36,142,94,247,94,162,200,251,69,112,109,13,223,95,94,82,242,148,60,22,159,9,144,231,173,195,175,100,52,237,185,176,21,117,197,114,152,237,137,58,237,85,46,35,72,18,165,146,41,27,199,118,34,53,139,32,93,106,24,230,207,186,251,225,132,54,121,63,210,75,93,41,63,225,88,102,88,224,160,227,110,17,177,26,15,120,244,229,30,221,199,127,223,61,247,93,188,150,217,150,9,23,178,33,248,183,70,252,171,110,250,99,175,248,199,23,255,41,133,39,24,159,56,198,239,248,245,3,58,56,184,255,216,6,0,0 };
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


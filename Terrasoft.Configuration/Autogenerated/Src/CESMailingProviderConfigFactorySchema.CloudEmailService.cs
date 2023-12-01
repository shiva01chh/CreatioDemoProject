namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESMailingProviderConfigFactorySchema

	/// <exclude/>
	public class CESMailingProviderConfigFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESMailingProviderConfigFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESMailingProviderConfigFactorySchema(CESMailingProviderConfigFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("21e2f7e7-ec6e-4ec1-a3d8-235df40381e1");
			Name = "CESMailingProviderConfigFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bc5abc6e-45a7-497f-b7c0-68ae441d38e3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,95,75,195,48,16,127,222,192,239,112,204,151,9,210,190,207,173,160,69,101,15,130,248,231,3,196,236,90,3,107,82,46,201,68,196,239,238,53,201,182,118,110,8,246,161,165,151,223,253,254,92,78,139,6,109,43,36,194,11,18,9,107,42,151,149,70,87,170,246,36,156,50,250,108,252,117,54,30,121,171,116,61,128,16,94,157,168,103,119,66,58,67,10,45,35,24,115,78,88,51,17,148,107,97,237,12,202,219,231,7,161,214,220,247,72,102,163,86,72,81,47,118,125,134,150,60,207,97,110,125,211,8,250,44,210,127,66,91,104,208,189,155,149,133,202,16,72,66,118,201,22,148,182,78,104,201,162,96,42,112,239,200,253,136,221,121,181,152,44,143,10,78,242,34,219,106,229,61,177,214,191,173,149,4,217,217,253,203,45,204,224,56,249,46,205,232,43,36,218,77,225,33,186,159,193,99,144,137,135,135,121,67,161,236,178,113,158,20,13,143,4,59,229,46,69,251,157,45,86,90,65,162,1,205,87,191,152,120,27,154,52,202,238,182,39,197,178,167,214,83,122,29,194,152,127,158,7,154,61,43,161,243,164,109,241,20,191,255,245,61,207,183,68,29,115,186,140,227,67,78,35,218,90,158,14,77,194,48,218,5,116,139,60,26,109,4,1,234,90,105,188,166,218,194,2,52,126,0,195,172,35,223,221,25,87,125,131,218,77,15,71,115,121,72,120,181,227,147,107,227,87,183,129,148,9,195,162,167,5,200,238,209,205,111,218,198,104,182,143,229,30,87,76,247,38,250,76,49,88,114,117,98,76,211,212,16,193,217,51,210,70,73,188,110,21,247,245,172,244,14,34,62,188,226,116,147,80,168,127,167,13,69,189,138,75,26,254,99,117,88,12,53,126,126,0,177,0,166,72,54,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("21e2f7e7-ec6e-4ec1-a3d8-235df40381e1"));
		}

		#endregion

	}

	#endregion

}


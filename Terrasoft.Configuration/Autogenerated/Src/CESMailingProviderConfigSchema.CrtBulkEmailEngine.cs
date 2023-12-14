namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESMailingProviderConfigSchema

	/// <exclude/>
	public class CESMailingProviderConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESMailingProviderConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESMailingProviderConfigSchema(CESMailingProviderConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b30ba11-e71d-45a7-abb8-9df39c11c6f4");
			Name = "CESMailingProviderConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bc5abc6e-45a7-497f-b7c0-68ae441d38e3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,81,77,107,195,48,12,61,167,208,255,32,218,123,114,111,187,194,40,29,244,48,40,164,127,192,115,149,204,16,127,32,57,133,80,246,223,231,216,73,232,202,194,96,62,73,79,239,73,79,178,17,26,217,9,137,112,65,34,193,182,242,249,193,154,74,213,45,9,175,172,89,46,238,203,69,214,178,50,53,148,29,123,212,219,41,159,145,228,135,99,25,72,129,182,38,172,3,0,178,17,204,27,8,248,187,80,77,144,158,201,222,212,21,41,233,34,183,40,10,216,113,171,181,160,110,63,228,3,141,65,70,30,216,10,252,39,130,78,77,192,13,93,242,81,94,60,232,93,251,209,40,153,70,207,78,134,13,156,102,44,101,247,104,107,218,33,212,29,146,87,24,22,57,199,222,169,254,236,59,2,39,195,94,152,112,213,193,241,142,17,65,18,86,47,171,113,222,5,181,107,132,199,55,33,189,165,110,85,236,243,169,221,227,30,227,34,51,58,120,206,251,239,202,178,26,253,54,6,28,131,62,252,250,167,223,112,187,87,167,254,246,151,120,80,34,221,148,196,62,252,213,202,100,100,141,230,154,110,27,243,132,254,4,35,214,191,111,152,186,252,23,167,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b30ba11-e71d-45a7-abb8-9df39c11c6f4"));
		}

		#endregion

	}

	#endregion

}


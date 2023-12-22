namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermCalculationLogStoreLoaderSchema

	/// <exclude/>
	public class TermCalculationLogStoreLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermCalculationLogStoreLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermCalculationLogStoreLoaderSchema(TermCalculationLogStoreLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e278331b-3fd3-439e-9087-7f82e26e675d");
			Name = "TermCalculationLogStoreLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28322dfd-15f8-434e-b343-12da0b1a75f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,82,75,75,195,64,16,62,71,232,127,24,234,165,5,73,238,154,244,210,131,8,69,197,250,56,202,186,157,198,133,100,55,204,236,86,170,248,223,157,108,170,182,149,20,197,16,8,243,252,30,19,171,106,228,70,105,132,91,36,82,236,150,62,157,58,187,52,101,32,229,141,179,131,163,183,193,81,18,216,216,114,167,133,240,172,39,159,206,125,87,149,122,150,101,144,115,168,107,69,235,201,38,190,193,134,144,209,122,134,202,169,5,18,184,37,120,164,26,180,170,116,168,34,172,148,74,6,110,55,165,159,123,178,173,69,77,120,170,140,6,93,41,230,22,191,158,126,207,206,92,25,41,204,226,118,105,110,21,36,13,153,149,242,8,132,106,225,108,181,134,59,70,18,169,22,117,4,124,12,59,113,199,63,57,38,44,219,170,20,216,83,208,178,151,79,225,58,162,119,29,251,18,99,226,194,26,111,84,101,94,145,193,226,11,24,153,86,86,92,22,169,57,35,130,38,92,22,195,131,196,135,217,36,253,2,200,246,17,242,70,145,170,193,202,253,138,97,208,195,73,158,197,76,108,216,184,115,112,253,104,79,127,208,99,136,70,37,123,78,64,33,181,246,216,201,251,198,19,180,139,206,150,93,143,174,201,53,72,222,224,111,28,138,76,184,247,244,61,202,15,11,235,150,110,84,148,232,161,136,67,63,20,165,115,100,150,239,84,233,103,76,31,140,127,158,57,33,208,134,242,59,143,198,221,80,146,158,163,191,87,85,192,188,7,111,50,234,41,164,187,185,136,115,41,151,26,71,27,19,254,63,181,57,250,43,186,193,218,173,48,82,252,43,147,19,88,181,99,227,3,119,149,172,188,91,207,7,234,54,213,121,44,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e278331b-3fd3-439e-9087-7f82e26e675d"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,82,75,75,195,64,16,62,167,224,127,24,234,165,5,73,238,154,246,210,131,8,69,75,235,227,40,235,118,154,46,36,187,97,102,183,82,197,255,238,100,83,31,173,164,40,134,64,152,231,247,152,88,85,33,215,74,35,220,34,145,98,183,242,233,196,217,149,41,2,41,111,156,61,233,189,158,244,146,192,198,22,123,45,132,23,29,249,116,225,219,170,212,179,44,131,156,67,85,41,218,142,119,241,28,107,66,70,235,25,74,167,150,72,224,86,224,145,42,208,170,212,161,140,176,82,42,24,184,217,148,126,236,201,190,45,170,195,83,105,52,232,82,49,55,248,213,228,107,118,234,138,72,97,26,183,75,115,163,32,169,201,108,148,71,32,84,75,103,203,45,220,49,146,72,181,168,35,224,99,216,139,91,254,201,41,97,209,84,165,192,158,130,150,189,124,14,179,136,222,118,28,74,140,137,43,107,188,81,165,121,65,6,139,207,96,100,90,89,113,89,164,230,140,8,154,112,53,234,31,37,222,207,198,233,39,64,118,136,144,215,138,84,5,86,238,55,234,7,221,31,231,89,204,196,134,157,59,71,215,15,14,244,7,61,132,104,84,114,224,4,140,164,214,28,59,121,219,121,130,118,217,218,178,239,209,140,92,141,228,13,254,198,161,200,132,59,79,223,161,252,184,176,118,233,78,69,129,30,70,113,232,135,162,116,129,204,242,157,40,189,198,244,193,248,245,212,9,129,38,148,223,121,48,108,135,146,244,18,253,189,42,3,230,29,120,227,65,71,33,221,207,69,156,107,185,212,48,218,152,240,255,169,45,208,223,208,28,43,183,193,72,241,175,76,206,96,211,140,13,143,220,85,178,242,202,243,14,2,179,239,142,36,4,0,0 };
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


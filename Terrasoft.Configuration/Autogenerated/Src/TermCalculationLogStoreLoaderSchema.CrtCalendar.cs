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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,82,75,107,194,64,16,62,71,232,127,24,236,69,161,36,247,54,122,241,80,10,210,138,246,113,44,219,117,140,11,201,110,152,217,181,216,210,255,222,201,198,62,180,68,90,10,66,216,121,124,175,209,170,10,185,86,26,225,22,137,20,187,149,79,39,206,174,76,17,72,121,227,236,73,239,245,164,151,4,54,182,216,27,33,188,232,168,167,11,223,118,165,159,101,25,228,28,170,74,209,118,188,123,207,177,38,100,180,158,161,116,106,137,4,110,5,30,169,2,173,74,29,202,72,43,173,130,129,27,164,244,3,39,251,6,84,135,167,210,104,208,165,98,110,248,171,201,215,238,212,21,81,194,52,162,203,112,227,32,169,201,108,148,71,32,84,75,103,203,45,220,49,146,88,181,168,35,225,99,216,123,183,250,147,83,194,162,233,74,131,61,5,45,184,124,14,179,200,222,78,28,90,140,133,43,107,188,81,165,121,65,6,139,207,96,100,91,89,73,89,172,230,140,8,154,112,53,234,31,21,222,207,198,233,39,65,118,200,144,215,138,84,5,86,238,55,234,7,221,31,231,89,172,196,129,93,58,71,225,7,7,254,131,30,66,12,42,57,72,2,70,210,107,142,157,188,237,50,65,187,108,99,217,207,104,70,174,70,242,6,127,147,80,84,194,157,167,239,112,126,220,88,11,186,115,81,160,135,81,92,250,225,40,93,32,179,124,39,74,175,49,125,48,126,61,117,34,160,121,202,223,121,48,108,151,146,244,18,253,189,42,3,230,29,124,227,65,71,35,221,175,69,158,107,185,212,48,198,152,240,255,165,45,208,223,208,28,43,183,193,40,241,175,74,206,96,211,172,13,143,220,85,170,242,235,245,222,1,177,139,54,94,35,4,0,0 };
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


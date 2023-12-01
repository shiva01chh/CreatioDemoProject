namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProductPriceDataSchema

	/// <exclude/>
	public class ProductPriceDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProductPriceDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProductPriceDataSchema(ProductPriceDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("525ed2a1-425c-433b-81f6-b5e01bce93f9");
			Name = "ProductPriceData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c797525-d05e-4bd8-84e9-5dcb79ad7c60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,193,106,132,48,16,134,207,43,248,14,3,189,235,189,150,94,44,148,194,30,22,186,47,48,77,70,25,208,68,38,9,172,44,125,247,198,168,203,110,75,109,215,91,38,243,125,243,235,104,176,39,55,160,34,56,146,8,58,219,248,162,182,166,225,54,8,122,182,38,207,206,121,182,11,142,77,11,239,163,243,212,87,121,22,43,15,66,109,188,134,186,67,231,30,225,32,86,7,229,15,194,138,94,208,99,234,41,203,18,158,92,232,123,148,241,121,57,167,126,80,214,120,100,67,2,141,149,27,184,88,185,242,10,28,194,71,199,10,84,98,127,142,218,157,211,184,75,166,216,49,144,120,166,41,88,66,231,251,239,121,82,225,136,39,96,77,198,115,195,36,197,165,239,122,254,26,224,53,176,158,128,55,93,253,234,171,131,8,25,53,222,39,93,169,45,115,122,99,216,179,243,247,185,19,55,97,155,114,18,21,157,96,27,240,120,218,182,106,82,220,99,55,125,137,5,251,43,116,180,14,243,218,254,103,78,84,181,108,149,140,158,23,155,206,159,243,239,119,83,140,181,248,124,1,93,48,132,39,204,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("525ed2a1-425c-433b-81f6-b5e01bce93f9"));
		}

		#endregion

	}

	#endregion

}


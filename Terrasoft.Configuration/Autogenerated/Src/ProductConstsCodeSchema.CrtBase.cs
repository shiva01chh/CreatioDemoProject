namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProductConstsCodeSchema

	/// <exclude/>
	public class ProductConstsCodeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProductConstsCodeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProductConstsCodeSchema(ProductConstsCodeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e82d2b87-855b-4382-aac0-c05f66836306");
			Name = "ProductConstsCode";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,141,193,10,194,48,16,68,207,45,244,31,22,79,122,168,88,149,134,34,30,98,75,197,131,32,168,31,16,211,88,2,105,82,178,9,82,138,255,110,80,4,113,88,230,50,111,118,52,235,4,246,140,11,184,8,107,25,154,187,155,151,70,223,101,235,45,115,210,232,36,30,147,56,242,40,117,11,231,1,157,232,54,73,12,65,189,191,41,201,1,93,192,56,112,197,16,225,100,77,227,185,11,15,208,225,7,27,33,212,163,63,218,10,214,24,173,6,216,123,217,124,91,199,224,74,92,15,13,108,65,139,199,59,155,78,86,180,174,8,169,242,180,94,147,58,93,215,197,50,45,114,186,72,201,138,238,202,108,145,45,105,158,79,102,27,136,162,207,222,51,137,195,253,234,5,40,192,37,184,227,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e82d2b87-855b-4382-aac0-c05f66836306"));
		}

		#endregion

	}

	#endregion

}


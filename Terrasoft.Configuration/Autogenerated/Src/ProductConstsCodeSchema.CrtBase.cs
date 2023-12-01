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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,141,205,10,130,64,20,133,215,10,190,195,197,85,45,12,127,66,17,105,97,138,209,34,8,170,7,152,198,81,6,116,70,230,206,16,34,189,123,67,210,166,195,229,108,206,119,238,17,100,100,56,17,202,224,206,148,34,40,59,189,171,164,232,120,111,20,209,92,10,207,93,60,215,49,200,69,15,183,25,53,27,11,207,5,171,201,60,7,78,1,181,197,40,208,129,32,194,85,201,214,80,109,31,160,198,21,91,192,214,157,63,90,49,210,74,49,204,112,50,188,253,181,46,214,7,246,56,183,112,0,193,94,223,108,227,39,101,83,103,89,157,6,205,62,107,130,125,147,199,65,158,150,97,144,37,229,177,138,194,40,46,211,212,223,22,224,56,235,222,219,115,237,89,125,0,207,244,37,8,218,0,0,0 };
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


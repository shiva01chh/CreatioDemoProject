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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,141,193,10,194,48,16,68,207,45,244,31,22,79,122,168,88,149,134,34,30,98,75,197,131,32,168,31,16,211,88,2,105,82,178,9,82,138,255,110,84,188,56,44,115,153,55,59,154,117,2,123,198,5,92,132,181,12,205,221,205,75,163,239,178,245,150,57,105,116,18,143,73,28,121,148,186,133,243,128,78,116,155,36,134,160,222,223,148,228,128,46,96,28,184,98,136,112,178,166,241,220,133,7,232,240,139,141,16,234,209,31,109,5,107,140,86,3,236,189,108,126,173,99,112,37,174,135,6,182,160,197,227,147,77,39,43,90,87,132,84,121,90,175,73,157,174,235,98,153,22,57,93,164,100,69,119,101,182,200,150,52,207,39,179,13,68,209,119,239,153,196,225,222,122,1,70,252,4,57,219,0,0,0 };
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


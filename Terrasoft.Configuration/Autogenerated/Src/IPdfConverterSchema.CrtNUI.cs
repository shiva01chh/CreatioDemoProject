namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPdfConverterSchema

	/// <exclude/>
	public class IPdfConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPdfConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPdfConverterSchema(IPdfConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("76370a5e-e3c8-4be4-b8c3-cb6e28b3bda1");
			Name = "IPdfConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,79,189,78,132,64,16,174,143,132,119,152,80,221,53,236,3,136,52,84,87,152,88,216,25,139,1,102,13,201,237,79,102,7,13,49,188,187,187,8,136,231,118,223,126,191,99,209,80,240,216,17,188,16,51,6,167,165,108,156,213,195,251,200,40,131,179,121,246,149,103,39,165,20,84,97,52,6,121,170,87,124,181,66,172,147,85,59,134,206,217,15,98,1,19,224,211,113,15,76,222,69,40,14,124,175,203,45,66,29,50,252,216,222,134,14,134,61,230,250,220,235,230,39,134,24,98,109,20,253,107,94,62,154,187,178,30,5,215,170,52,198,160,148,187,87,221,155,43,143,140,6,108,188,252,177,72,206,162,126,90,115,218,73,40,44,105,101,165,22,217,175,139,73,70,182,161,142,35,255,234,54,34,41,19,241,250,182,237,59,175,48,9,47,15,145,159,243,108,78,103,29,223,55,65,230,227,245,130,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("76370a5e-e3c8-4be4-b8c3-cb6e28b3bda1"));
		}

		#endregion

	}

	#endregion

}


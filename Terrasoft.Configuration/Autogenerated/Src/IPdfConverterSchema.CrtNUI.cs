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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,79,189,78,132,64,16,174,37,225,29,38,84,103,195,62,128,72,67,117,197,37,22,118,198,98,128,89,67,114,251,147,217,65,67,12,239,238,46,2,222,225,118,223,126,191,99,209,80,240,216,17,188,18,51,6,167,165,108,156,213,195,199,200,40,131,179,121,246,157,103,15,74,41,168,194,104,12,242,84,175,248,108,133,88,39,171,118,12,157,179,159,196,2,38,192,151,227,30,152,188,139,80,28,248,94,151,91,132,186,201,240,99,123,29,58,24,246,152,243,75,175,155,223,24,98,136,181,81,244,175,121,249,104,14,101,61,10,174,85,105,140,65,41,119,175,58,154,43,143,140,6,108,188,252,185,72,206,162,190,172,57,237,36,20,150,180,178,82,139,236,207,197,36,35,219,80,199,145,247,186,141,72,202,68,188,189,111,251,78,43,76,194,199,167,200,207,121,54,167,179,210,251,1,189,84,12,50,122,1,0,0 };
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


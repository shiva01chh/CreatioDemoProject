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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,79,59,142,194,48,16,173,137,148,59,140,168,150,38,62,0,33,77,42,10,36,10,58,68,49,36,99,20,105,253,209,120,2,66,136,187,99,135,4,118,193,221,243,251,142,69,67,193,99,67,176,35,102,12,78,75,81,59,171,187,83,207,40,157,179,121,118,203,179,153,82,10,202,208,27,131,124,173,70,188,182,66,172,147,85,59,134,198,217,51,177,128,9,112,113,220,2,147,119,17,138,3,223,234,98,138,80,127,50,124,127,252,237,26,232,94,49,235,109,171,235,103,12,49,196,218,40,250,106,30,62,234,143,178,22,5,199,170,52,198,160,20,47,175,250,52,151,30,25,13,216,120,249,106,158,156,243,106,51,230,28,175,66,97,72,43,74,53,200,222,46,38,233,217,134,42,142,252,175,155,136,164,76,196,254,48,237,251,25,97,18,46,150,145,191,231,217,61,157,21,223,3,0,46,82,219,121,1,0,0 };
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


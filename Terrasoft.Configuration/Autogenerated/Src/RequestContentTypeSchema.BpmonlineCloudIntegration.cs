namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RequestContentTypeSchema

	/// <exclude/>
	public class RequestContentTypeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RequestContentTypeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RequestContentTypeSchema(RequestContentTypeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9276eb3a-690d-4f9a-89bf-69e191abc4b4");
			Name = "RequestContentType";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,79,59,14,194,48,12,157,27,169,119,176,196,208,173,97,70,192,82,177,116,68,189,64,40,110,9,34,78,200,103,168,16,119,39,77,0,85,2,111,207,126,31,63,18,10,157,17,61,66,135,214,10,167,7,95,55,154,6,57,6,43,188,212,84,178,71,201,74,86,172,44,142,17,194,129,130,218,192,17,239,1,157,143,76,143,228,187,201,96,34,113,206,97,235,130,82,194,78,251,55,238,46,8,54,211,161,207,124,240,81,80,127,248,124,33,48,225,116,147,61,96,12,249,155,81,228,103,126,130,210,162,89,184,67,37,140,137,86,169,3,191,58,77,85,253,21,46,19,139,54,222,96,7,235,100,252,204,93,145,206,185,238,12,211,110,158,23,173,21,174,195,44,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9276eb3a-690d-4f9a-89bf-69e191abc4b4"));
		}

		#endregion

	}

	#endregion

}


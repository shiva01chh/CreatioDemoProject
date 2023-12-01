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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,79,59,14,194,48,12,157,91,169,119,176,196,208,173,97,70,192,82,177,48,162,92,32,20,183,20,17,39,228,51,84,136,187,99,18,64,149,192,219,179,223,199,143,148,70,111,85,135,32,209,57,229,77,31,154,214,80,63,14,209,169,48,26,170,202,123,85,86,101,177,112,56,48,132,29,69,189,130,3,222,34,250,192,204,128,20,228,100,49,145,132,16,176,246,81,107,229,166,237,27,203,51,130,203,116,232,50,31,2,11,154,15,95,204,4,54,30,175,99,7,200,33,127,51,138,252,204,79,80,90,180,51,119,168,149,181,108,149,58,136,139,55,84,55,95,225,60,177,216,243,13,54,176,76,198,143,220,21,233,148,235,190,96,218,241,60,1,209,124,241,173,43,1,0,0 };
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


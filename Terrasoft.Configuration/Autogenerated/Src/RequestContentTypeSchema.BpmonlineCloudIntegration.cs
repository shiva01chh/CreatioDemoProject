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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,79,59,14,194,48,12,157,27,169,119,176,196,208,173,97,70,192,82,177,48,162,94,32,20,183,4,17,39,228,51,84,136,187,19,18,64,145,192,219,179,223,199,143,132,66,103,196,128,208,163,181,194,233,209,183,157,166,81,78,193,10,47,53,213,236,94,179,154,85,11,139,83,132,176,163,160,86,112,192,91,64,231,35,211,35,249,126,54,152,72,156,115,88,187,160,148,176,243,246,141,251,51,130,205,116,24,50,31,124,20,180,31,62,47,4,38,28,175,114,0,140,33,127,51,170,252,204,79,80,90,116,133,59,52,194,152,104,149,58,240,139,211,212,180,95,97,153,88,237,227,13,54,176,76,198,143,220,21,233,148,235,190,96,218,149,243,4,175,96,164,74,52,1,0,0 };
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


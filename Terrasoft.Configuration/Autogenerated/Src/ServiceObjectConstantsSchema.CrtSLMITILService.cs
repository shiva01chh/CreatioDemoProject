namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceObjectConstantsSchema

	/// <exclude/>
	public class ServiceObjectConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceObjectConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceObjectConstantsSchema(ServiceObjectConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87b3bcc1-054b-4d22-b62d-b3d765973e0c");
			Name = "ServiceObjectConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,201,106,195,48,16,64,207,53,248,31,68,114,105,15,170,247,37,233,2,37,133,210,83,11,201,15,72,163,81,112,137,101,99,201,45,161,228,223,43,59,49,9,73,10,93,6,9,105,52,219,19,51,173,46,212,146,204,215,218,96,121,227,58,174,163,88,137,186,102,128,100,129,77,195,116,37,205,245,172,82,178,88,182,13,51,69,165,92,231,211,117,46,198,13,46,173,66,102,43,166,245,148,204,177,121,47,0,95,248,27,130,177,238,218,48,101,180,245,179,203,243,60,114,171,219,178,100,205,250,126,167,143,7,33,39,151,78,134,40,239,32,172,110,249,170,0,98,51,27,123,64,87,247,251,178,29,226,158,113,48,76,201,107,159,164,51,118,251,152,108,64,35,231,152,166,100,15,119,74,119,132,247,212,22,162,171,107,24,152,197,186,198,103,65,238,136,194,143,222,112,57,226,33,99,34,17,146,50,153,0,141,195,132,83,6,33,208,80,6,145,200,243,192,103,89,48,186,234,251,241,87,202,223,128,62,0,84,173,58,7,26,37,190,72,165,200,40,228,177,5,141,192,167,28,33,165,177,31,4,41,112,62,17,33,255,63,232,207,73,31,177,102,141,41,241,44,44,79,57,6,81,152,83,153,73,65,227,28,18,58,241,179,136,198,89,204,162,36,207,210,137,31,245,176,219,238,143,81,137,237,132,88,109,179,157,213,195,183,77,247,43,43,95,192,178,221,142,35,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87b3bcc1-054b-4d22-b62d-b3d765973e0c"));
		}

		#endregion

	}

	#endregion

}


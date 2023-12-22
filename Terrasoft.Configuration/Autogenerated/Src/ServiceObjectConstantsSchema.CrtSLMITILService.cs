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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,201,106,195,48,16,64,207,53,248,31,68,114,105,15,170,247,37,233,2,37,133,210,83,11,201,15,140,70,82,112,137,101,99,201,45,161,228,223,43,59,49,9,73,10,93,6,9,105,52,219,19,51,173,46,212,146,204,215,218,136,242,198,117,92,71,65,41,116,13,40,200,66,52,13,232,74,154,235,89,165,100,177,108,27,48,69,165,92,231,211,117,46,198,141,88,90,133,204,86,160,245,148,204,69,243,94,160,120,97,111,2,141,117,215,6,148,209,214,207,46,207,243,200,173,110,203,18,154,245,253,78,31,15,66,78,46,157,12,81,222,65,88,221,178,85,129,196,102,54,246,192,174,238,247,101,59,196,61,227,96,152,146,215,62,73,103,236,246,49,217,128,70,206,49,77,201,30,238,148,238,8,239,169,45,120,87,215,0,154,197,186,22,207,156,220,17,37,62,122,195,229,136,133,0,60,225,146,130,76,144,198,97,194,40,96,136,52,148,65,196,243,60,240,33,11,70,87,125,63,254,74,249,27,208,7,196,170,85,231,64,163,196,231,169,228,25,197,60,182,160,17,250,148,9,76,105,236,7,65,138,140,77,120,200,254,15,250,115,210,71,81,67,99,74,113,22,150,165,76,4,81,152,83,153,73,78,227,28,19,58,241,179,136,198,89,12,81,146,103,233,196,143,122,216,109,247,199,66,241,237,132,88,109,179,157,213,195,183,77,247,171,67,249,2,232,71,22,23,44,3,0,0 };
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


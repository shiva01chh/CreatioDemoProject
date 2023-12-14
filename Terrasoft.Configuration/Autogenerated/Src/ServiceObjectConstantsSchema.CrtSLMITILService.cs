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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,89,75,3,49,16,128,159,93,216,255,16,218,23,125,136,123,31,173,7,72,5,241,73,161,253,3,147,73,82,86,186,217,101,147,85,138,248,223,77,90,151,150,182,130,199,144,144,76,230,250,194,76,175,43,181,36,243,181,54,162,190,242,61,223,83,80,11,221,2,10,178,16,93,7,186,145,230,114,214,40,89,45,251,14,76,213,40,223,123,247,189,179,113,39,150,86,33,179,21,104,61,37,115,209,189,86,40,158,216,139,64,99,221,181,1,101,180,245,179,43,8,2,114,173,251,186,134,110,125,251,165,143,7,33,71,23,39,67,84,176,23,214,246,108,85,33,177,153,141,61,208,213,253,190,172,67,220,49,14,134,41,121,222,36,113,70,183,15,201,6,52,114,138,105,74,118,112,199,116,7,120,15,125,197,93,93,3,104,22,235,86,60,114,114,67,148,120,219,24,206,71,44,6,224,25,151,20,100,134,52,141,51,70,1,99,164,177,140,18,94,150,81,8,69,52,186,216,244,227,175,148,191,1,189,67,108,122,117,10,52,201,66,158,75,94,80,44,83,11,154,96,72,153,192,156,166,97,20,229,200,216,132,199,236,255,160,63,39,189,23,45,116,166,22,39,97,89,206,68,148,196,37,149,133,228,52,45,49,163,147,176,72,104,90,164,144,100,101,145,79,194,100,3,187,237,254,88,40,190,157,16,171,125,108,103,117,255,237,195,253,202,201,39,145,25,61,169,36,3,0,0 };
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


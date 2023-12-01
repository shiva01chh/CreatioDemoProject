namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CloudDataResponseSchema

	/// <exclude/>
	public class CloudDataResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CloudDataResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CloudDataResponseSchema(CloudDataResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("db4128e4-39dd-4160-97b6-b20928a12b20");
			Name = "CloudDataResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c9ff5cbb-cb0e-4041-b483-395260757ab0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,77,111,130,64,16,134,207,152,248,31,38,244,162,23,184,87,32,105,108,211,52,169,141,209,222,154,30,214,101,196,77,96,151,236,46,109,172,233,127,239,236,130,6,181,26,185,176,188,59,31,207,188,131,100,21,154,154,113,132,119,212,154,25,181,182,209,84,201,181,40,26,205,172,80,114,56,216,13,7,65,99,132,44,96,185,53,22,43,186,47,75,228,238,210,68,207,40,81,11,62,57,141,89,52,210,138,10,163,37,221,178,82,252,248,90,20,69,113,119,26,11,250,128,105,201,140,185,167,151,106,242,71,102,217,130,64,168,36,250,160,56,142,33,49,77,85,49,189,205,186,239,39,73,157,54,192,149,180,140,91,192,18,43,148,214,144,176,231,137,246,153,113,47,245,195,21,167,153,172,166,172,79,18,234,102,85,10,14,220,245,255,175,125,176,243,8,7,208,185,86,53,106,43,144,104,231,62,183,189,63,101,236,4,68,224,26,215,105,216,242,78,91,220,23,114,37,132,56,3,65,7,3,165,48,54,58,228,244,113,91,222,25,86,43,212,163,55,90,15,164,16,230,36,133,99,7,191,167,127,165,2,201,89,135,12,92,50,184,149,5,65,129,118,226,15,166,59,252,118,115,161,204,219,209,142,231,164,58,198,234,134,91,165,79,38,237,122,158,121,53,26,119,173,124,215,20,36,126,95,2,27,141,111,65,152,161,221,168,252,22,159,31,242,220,64,82,51,205,42,50,27,36,25,149,134,206,219,144,60,182,170,191,7,7,231,212,43,158,123,197,23,235,87,202,174,46,211,237,146,12,99,146,99,148,196,62,57,235,153,245,165,68,238,40,71,103,153,254,23,232,59,23,185,48,47,94,242,168,211,142,109,35,141,158,63,171,162,171,185,194,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("db4128e4-39dd-4160-97b6-b20928a12b20"));
		}

		#endregion

	}

	#endregion

}


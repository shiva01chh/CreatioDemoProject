namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMacrosWorkerPropertiesConverterSchema

	/// <exclude/>
	public class IMacrosWorkerPropertiesConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMacrosWorkerPropertiesConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMacrosWorkerPropertiesConverterSchema(IMacrosWorkerPropertiesConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9fea00b7-db2d-4922-a2b4-e3c0ba2cab34");
			Name = "IMacrosWorkerPropertiesConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,77,11,130,64,16,134,207,10,254,135,193,83,65,184,63,32,243,226,201,67,20,33,116,222,100,148,165,246,163,217,221,64,162,255,158,150,138,68,68,195,92,102,120,223,103,62,20,151,104,13,175,16,74,36,226,86,215,46,201,181,170,69,227,137,59,161,85,20,222,163,48,96,140,65,106,189,148,156,218,108,168,11,229,144,234,222,90,107,130,74,171,27,146,19,170,1,201,43,210,22,12,105,211,119,208,38,35,129,125,32,82,215,26,52,156,184,4,213,45,178,137,203,3,94,61,90,23,103,133,50,222,125,65,165,108,242,252,162,88,127,233,32,59,239,254,162,24,127,186,136,10,196,116,81,177,125,89,142,154,206,72,251,201,151,191,143,68,74,199,69,87,48,12,235,49,253,167,130,161,134,65,187,24,149,179,241,203,117,39,124,68,97,151,243,120,2,39,96,9,165,140,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9fea00b7-db2d-4922-a2b4-e3c0ba2cab34"));
		}

		#endregion

	}

	#endregion

}


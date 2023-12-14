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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,203,10,194,48,16,69,215,22,250,15,67,87,10,210,124,128,181,155,174,186,16,69,4,215,177,76,37,216,60,156,36,130,136,255,110,163,105,17,17,113,152,205,12,247,158,121,40,46,209,26,222,32,236,144,136,91,221,186,188,210,170,21,71,79,220,9,173,210,228,150,38,19,198,24,20,214,75,201,233,90,198,186,86,14,169,13,214,86,19,52,90,93,144,156,80,71,144,188,33,109,193,144,54,161,131,54,31,8,236,3,81,184,171,65,195,137,75,80,253,34,203,108,183,197,179,71,235,178,178,86,198,187,47,168,130,141,158,95,20,235,187,30,178,246,238,47,138,241,135,78,52,32,198,139,234,213,211,178,215,116,66,218,140,190,234,117,36,82,49,44,58,135,56,44,96,194,167,38,177,134,168,157,14,202,183,241,179,69,47,188,167,73,159,33,30,26,46,215,111,132,1,0,0 };
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


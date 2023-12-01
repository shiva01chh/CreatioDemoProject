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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,203,10,194,48,16,69,215,22,250,15,67,87,10,210,124,128,181,155,174,186,16,69,4,215,177,76,37,216,60,156,36,130,136,255,110,170,105,17,17,113,152,205,12,247,158,121,40,46,209,26,222,32,236,144,136,91,221,186,188,210,170,21,71,79,220,9,173,210,228,150,38,19,198,24,20,214,75,201,233,90,198,186,86,14,169,237,173,173,38,104,180,186,32,57,161,142,32,121,67,218,130,33,109,250,14,218,124,32,176,15,68,225,174,6,13,39,46,65,133,69,150,217,110,139,103,143,214,101,101,173,140,119,95,80,5,27,61,191,40,214,119,1,178,246,238,47,138,241,135,78,52,32,198,139,234,213,211,178,215,116,66,218,140,190,234,117,36,82,49,44,58,135,56,172,199,244,159,154,196,26,162,118,58,40,223,198,207,22,65,120,79,147,144,33,30,250,139,51,104,131,1,0,0 };
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


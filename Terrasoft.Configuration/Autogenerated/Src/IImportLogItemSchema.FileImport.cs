namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportLogItemSchema

	/// <exclude/>
	public class IImportLogItemSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportLogItemSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportLogItemSchema(IImportLogItemSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a68587a1-ef86-40c0-811b-ca07c771c3c7");
			Name = "IImportLogItem";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,77,10,194,48,16,133,215,45,244,14,3,221,183,251,42,110,68,161,160,32,232,5,98,157,134,160,249,97,50,5,165,120,119,211,68,69,16,52,171,201,155,111,222,203,196,8,141,222,137,14,225,128,68,194,219,158,171,165,53,189,146,3,9,86,214,84,107,117,193,86,59,75,92,228,99,145,23,121,86,18,202,208,129,214,48,82,31,102,27,104,19,177,177,178,101,212,145,114,195,241,162,58,80,47,232,139,201,146,219,219,110,71,214,33,177,66,223,192,46,14,167,126,93,215,48,247,131,214,130,110,139,151,16,92,32,188,220,11,137,213,27,170,63,41,207,164,140,132,109,130,96,156,180,76,34,207,98,225,159,197,253,71,198,234,218,161,155,254,0,60,139,238,12,76,97,141,223,105,251,9,60,76,220,159,192,18,205,41,237,29,239,73,253,20,163,18,206,3,123,153,213,182,161,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a68587a1-ef86-40c0-811b-ca07c771c3c7"));
		}

		#endregion

	}

	#endregion

}


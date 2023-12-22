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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,77,10,194,48,16,133,215,45,244,14,3,238,219,189,138,27,81,40,40,8,246,2,177,78,67,208,252,48,153,130,82,188,187,105,162,82,16,52,171,201,155,111,222,203,196,8,141,222,137,22,161,65,34,225,109,199,229,218,154,78,201,158,4,43,107,202,173,186,98,173,157,37,46,242,161,200,139,60,155,17,202,208,129,218,48,82,23,102,231,80,39,98,103,101,205,168,35,229,250,211,85,181,160,222,208,23,147,37,183,143,221,129,172,67,98,133,126,14,135,56,156,250,85,85,193,210,247,90,11,186,175,222,66,112,129,240,114,47,36,150,31,168,154,82,158,73,25,9,251,4,193,48,106,153,68,94,196,194,191,138,199,143,140,205,173,69,55,254,1,120,22,237,5,152,194,26,191,211,142,35,216,140,220,159,192,25,154,115,218,59,222,147,58,21,163,50,61,79,15,172,253,162,170,1,0,0 };
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


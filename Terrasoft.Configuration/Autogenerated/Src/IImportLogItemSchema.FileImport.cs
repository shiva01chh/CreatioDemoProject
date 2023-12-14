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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,203,10,194,48,16,69,215,45,244,31,6,220,183,251,42,110,68,161,160,32,232,15,196,58,13,65,243,96,50,5,69,252,119,243,80,17,4,205,106,114,231,204,189,153,24,161,209,59,209,35,236,145,72,120,59,112,189,176,102,80,114,36,193,202,154,122,165,206,216,105,103,137,171,242,86,149,85,89,76,8,101,232,64,103,24,105,8,179,45,116,153,88,91,217,49,234,68,185,241,112,86,61,168,23,244,197,20,217,237,109,183,37,235,144,88,161,111,97,155,134,115,191,105,26,152,249,81,107,65,215,249,75,8,46,16,94,238,133,196,250,13,53,159,148,103,82,70,194,38,67,112,139,90,33,145,167,169,240,207,226,254,35,99,121,233,209,197,63,0,207,162,63,1,83,88,227,119,218,46,130,251,200,253,9,156,160,57,230,189,211,61,171,159,98,82,226,121,0,190,123,182,245,162,1,0,0 };
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


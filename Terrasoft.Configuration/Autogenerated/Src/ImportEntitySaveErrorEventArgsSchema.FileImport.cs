namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportEntitySaveErrorEventArgsSchema

	/// <exclude/>
	public class ImportEntitySaveErrorEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportEntitySaveErrorEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportEntitySaveErrorEventArgsSchema(ImportEntitySaveErrorEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5beeed51-04c6-4feb-97c6-7d344852fe83");
			Name = "ImportEntitySaveErrorEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,142,205,10,131,48,12,199,207,10,190,67,192,187,15,160,167,33,14,118,24,12,220,11,116,46,150,130,182,146,68,65,100,239,190,218,178,225,78,203,33,144,31,255,143,88,53,34,79,170,67,184,35,145,98,215,75,81,59,219,27,61,147,18,227,108,113,54,3,94,198,201,145,100,233,150,165,201,204,198,106,104,87,22,28,171,44,245,36,39,212,94,9,80,15,138,185,132,168,110,172,24,89,91,181,96,67,228,168,89,208,202,137,52,7,203,52,63,6,211,65,183,27,254,232,161,132,0,174,200,172,52,30,114,146,253,157,111,251,141,220,132,36,6,253,7,183,16,31,154,62,85,199,146,223,99,3,141,82,1,239,235,21,61,57,218,103,140,245,87,100,71,20,136,159,55,140,186,37,143,61,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5beeed51-04c6-4feb-97c6-7d344852fe83"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,142,205,10,131,48,12,199,207,10,190,67,192,187,15,160,167,33,14,118,24,12,220,11,116,46,150,130,182,37,137,130,200,222,125,90,217,232,78,203,33,144,31,255,143,88,53,34,123,213,33,220,145,72,177,235,165,168,157,237,141,158,72,137,113,182,56,155,1,47,163,119,36,89,186,102,105,50,177,177,26,218,133,5,199,42,75,55,146,19,234,77,9,80,15,138,185,132,67,221,88,49,178,180,106,198,134,200,81,51,163,149,19,105,14,22,63,61,6,211,65,183,27,254,232,161,132,0,174,200,172,52,70,57,201,254,206,183,253,70,206,35,137,193,237,131,91,136,15,77,159,170,184,228,247,88,65,163,84,192,251,122,29,158,28,237,243,136,221,174,131,197,40,144,120,222,85,11,152,96,70,1,0,0 };
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


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,142,205,10,131,48,12,199,207,10,190,67,192,187,15,160,167,33,14,118,24,12,220,11,116,46,150,130,182,37,137,130,200,222,125,182,178,225,78,203,33,144,31,255,143,88,53,34,123,213,33,220,145,72,177,235,165,168,157,237,141,158,72,137,113,182,56,155,1,47,163,119,36,89,186,102,105,50,177,177,26,218,133,5,199,42,75,55,146,19,234,77,9,80,15,138,185,132,93,221,88,49,178,180,106,198,134,200,81,51,163,149,19,105,142,22,63,61,6,211,65,23,12,127,244,80,66,4,87,100,86,26,15,57,73,120,231,219,126,35,231,145,196,224,246,193,45,198,199,166,79,213,177,228,247,88,65,163,84,192,97,189,118,79,142,246,185,199,110,215,206,142,40,146,48,111,34,236,86,214,62,1,0,0 };
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


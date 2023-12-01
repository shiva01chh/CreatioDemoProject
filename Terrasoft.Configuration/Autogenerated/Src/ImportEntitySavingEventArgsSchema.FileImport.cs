namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportEntitySavingEventArgsSchema

	/// <exclude/>
	public class ImportEntitySavingEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportEntitySavingEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportEntitySavingEventArgsSchema(ImportEntitySavingEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9ddd5a40-8a06-4e75-ab40-8d237a2f6898");
			Name = "ImportEntitySavingEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f3a21-2903-49a8-8e29-be203e6136ba");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,193,10,194,48,12,134,207,27,236,29,10,222,125,0,119,146,161,224,65,16,221,11,212,153,149,194,150,140,38,85,134,248,238,198,78,68,17,196,158,146,191,95,254,63,65,219,3,15,182,1,83,67,8,150,169,149,121,69,216,122,23,131,21,79,56,95,251,14,54,253,64,65,138,252,90,228,89,100,143,206,28,70,22,232,203,34,87,101,22,192,41,105,170,206,50,47,204,4,175,80,188,140,7,123,86,122,117,6,148,101,112,156,240,33,30,59,223,152,230,65,255,130,141,90,97,75,91,96,182,14,222,60,178,107,242,121,229,238,2,13,16,196,131,134,239,146,249,244,255,12,138,30,197,212,36,182,219,211,133,43,138,218,62,14,201,50,7,82,166,130,159,197,237,123,80,205,27,221,0,78,255,14,207,0,79,211,98,169,159,212,79,49,105,250,238,195,19,79,40,125,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9ddd5a40-8a06-4e75-ab40-8d237a2f6898"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,193,10,194,48,12,134,207,27,236,29,10,187,239,1,244,36,99,130,7,97,168,47,80,103,86,10,91,50,154,84,25,195,119,183,235,68,20,65,236,41,249,251,229,255,19,212,61,240,160,27,80,39,112,78,51,181,82,148,132,173,53,222,105,177,132,197,214,118,176,235,7,114,146,165,83,150,38,158,45,26,117,28,89,160,95,103,105,80,114,7,38,144,170,236,52,243,74,45,112,133,98,101,60,234,107,160,171,43,160,108,156,225,136,15,254,220,217,70,53,51,253,11,86,193,10,91,218,3,179,54,240,230,145,76,209,231,149,91,59,26,192,137,133,16,94,71,243,229,255,25,228,45,138,58,145,232,238,64,55,46,201,135,118,62,36,73,12,200,58,22,252,44,238,223,131,193,188,9,27,192,229,223,225,28,240,178,44,22,251,69,253,20,163,54,191,7,138,218,146,48,126,1,0,0 };
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


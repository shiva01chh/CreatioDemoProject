namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkDeduplicationGroupManagerSchema

	/// <exclude/>
	public class IBulkDeduplicationGroupManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkDeduplicationGroupManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkDeduplicationGroupManagerSchema(IBulkDeduplicationGroupManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f12816d-d543-4f86-9793-07195211c781");
			Name = "IBulkDeduplicationGroupManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("dcfefe5b-65e2-4411-92b0-7b05d81d9c9b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,193,106,195,48,12,134,207,9,228,29,4,189,108,48,146,123,55,6,107,11,37,176,142,194,186,7,112,107,197,53,139,237,84,182,14,161,236,221,231,216,235,200,78,243,237,151,252,233,151,126,176,194,160,31,196,9,225,128,68,194,187,46,212,107,103,59,173,152,68,208,206,214,27,148,60,244,250,148,84,85,94,171,178,96,175,173,130,247,209,7,52,143,85,25,43,11,66,21,219,208,218,128,212,197,113,75,104,87,220,127,254,129,183,228,120,216,9,43,20,82,162,154,166,129,39,207,198,8,26,159,127,244,68,129,156,99,160,38,14,76,6,235,27,215,204,192,129,143,241,55,232,155,251,191,230,197,116,198,239,214,59,12,103,39,253,18,246,105,78,218,173,56,58,215,195,139,148,9,60,184,15,171,47,140,175,218,135,59,31,104,186,31,109,208,97,124,139,1,62,192,150,181,204,123,182,242,62,71,82,44,208,202,108,16,213,87,142,105,86,170,202,88,155,191,111,167,216,133,226,140,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f12816d-d543-4f86-9793-07195211c781"));
		}

		#endregion

	}

	#endregion

}


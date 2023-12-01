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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,193,106,195,48,12,134,207,9,228,29,4,189,108,48,146,123,55,6,107,11,37,176,142,194,186,7,112,107,197,53,139,237,84,150,15,161,236,221,231,216,235,200,78,243,237,151,252,233,151,126,176,194,160,31,196,9,225,128,68,194,187,142,235,181,179,157,86,129,4,107,103,235,13,202,48,244,250,148,84,85,94,171,178,8,94,91,5,239,163,103,52,143,85,25,43,11,66,21,219,208,90,70,234,226,184,37,180,171,208,127,254,129,183,228,194,176,19,86,40,164,68,53,77,3,79,62,24,35,104,124,254,209,19,5,114,142,129,154,56,48,25,172,111,92,51,3,135,112,140,191,65,223,220,255,53,47,166,51,126,183,222,33,159,157,244,75,216,167,57,105,183,226,232,92,15,47,82,38,240,224,62,172,190,4,124,213,158,239,60,211,116,63,90,214,60,190,197,0,31,96,27,180,204,123,182,242,62,71,82,44,208,202,108,16,213,87,142,105,86,170,202,88,139,239,27,228,180,210,169,131,1,0,0 };
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


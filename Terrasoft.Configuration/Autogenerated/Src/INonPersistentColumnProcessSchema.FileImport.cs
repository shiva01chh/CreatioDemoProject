namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INonPersistentColumnProcessSchema

	/// <exclude/>
	public class INonPersistentColumnProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INonPersistentColumnProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INonPersistentColumnProcessSchema(INonPersistentColumnProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5b9b0b8a-a0c7-4250-a378-016529bb5c12");
			Name = "INonPersistentColumnProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,81,75,195,48,16,199,159,91,232,119,56,182,151,9,163,125,215,58,144,169,208,7,165,136,248,158,53,215,46,208,94,74,146,110,12,241,187,219,36,235,108,139,14,67,94,46,119,191,127,238,159,11,177,6,117,203,10,132,119,84,138,105,89,154,120,43,169,20,85,167,152,17,146,226,103,81,99,214,180,82,153,40,252,140,194,160,237,118,181,40,64,144,65,85,90,48,123,149,148,163,210,66,27,36,179,149,117,215,80,174,100,129,90,247,229,22,9,150,10,171,94,11,94,208,236,37,215,183,144,59,145,40,180,201,36,73,32,213,93,211,48,117,218,12,7,15,156,107,80,236,8,7,86,119,8,102,207,12,28,69,93,195,14,161,245,226,200,227,11,158,204,249,180,101,138,53,64,189,189,251,133,112,237,63,145,17,230,180,216,120,51,128,46,140,211,196,85,254,14,22,206,204,5,241,225,127,144,15,219,245,140,243,86,174,211,28,181,17,228,30,126,78,143,82,19,141,131,20,220,62,215,42,27,185,132,177,229,53,248,148,31,205,89,111,122,232,250,133,81,239,107,43,29,140,75,30,127,238,31,247,114,115,119,101,138,111,29,233,137,123,61,12,79,80,245,199,244,156,159,243,255,89,13,234,75,36,238,255,144,139,191,162,176,223,118,125,3,54,124,137,11,192,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b9b0b8a-a0c7-4250-a378-016529bb5c12"));
		}

		#endregion

	}

	#endregion

}


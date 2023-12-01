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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,81,75,195,48,16,199,159,91,232,119,56,182,151,9,163,125,215,58,144,169,208,7,165,136,248,158,53,215,46,208,94,74,146,110,12,241,187,219,38,235,76,139,14,67,94,46,119,191,127,238,159,11,177,6,117,203,10,132,119,84,138,105,89,154,120,43,169,20,85,167,152,17,146,226,103,81,99,214,180,82,153,40,252,140,194,160,237,118,181,40,64,144,65,85,14,96,246,42,41,71,165,133,54,72,102,43,235,174,161,92,201,2,181,238,203,7,36,88,42,172,122,45,120,65,179,151,92,223,66,110,69,162,112,72,38,73,2,169,238,154,134,169,211,102,60,120,224,92,131,98,71,56,176,186,67,48,123,102,224,40,234,26,118,8,173,19,71,30,95,240,100,206,167,45,83,172,1,234,237,221,47,132,109,255,137,140,48,167,197,198,153,1,180,97,156,38,182,242,119,176,176,102,46,136,11,255,131,124,12,93,207,56,103,229,58,205,81,27,65,246,225,231,180,151,154,104,28,164,224,195,115,173,50,207,37,248,150,215,224,82,110,52,103,189,233,161,237,23,188,222,215,131,116,224,151,60,254,220,239,247,114,115,119,101,138,111,29,233,137,123,61,14,79,80,245,199,244,172,159,243,255,89,141,234,75,36,238,254,144,141,191,162,176,223,253,250,6,227,103,201,93,191,2,0,0 };
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


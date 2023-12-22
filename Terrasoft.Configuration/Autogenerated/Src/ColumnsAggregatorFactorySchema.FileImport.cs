namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnsAggregatorFactorySchema

	/// <exclude/>
	public class ColumnsAggregatorFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnsAggregatorFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnsAggregatorFactorySchema(ColumnsAggregatorFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("32c31bbf-f71f-44eb-9406-7b7d802e4208");
			Name = "ColumnsAggregatorFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,193,74,195,64,16,61,183,208,127,24,114,74,64,146,187,181,66,173,86,122,41,61,232,73,68,182,233,108,92,72,118,195,204,46,82,164,255,238,164,53,214,90,22,161,129,36,108,242,230,189,55,111,118,173,106,144,91,85,34,60,33,145,98,167,125,62,115,86,155,42,144,242,198,217,124,110,106,92,52,173,35,63,26,126,142,134,131,192,198,86,39,104,194,113,228,123,62,87,165,119,100,144,5,33,152,162,40,224,198,216,119,36,227,55,174,132,146,80,79,146,197,204,213,161,177,60,173,42,194,74,73,193,161,108,155,20,183,125,17,135,166,81,180,237,215,98,168,198,6,173,103,48,214,35,233,174,3,237,168,99,84,30,161,60,48,130,250,161,236,137,138,95,76,47,247,168,85,168,253,157,177,27,49,159,250,109,139,78,167,81,63,217,21,44,37,47,152,128,149,151,32,163,192,236,85,232,219,176,174,141,52,89,43,102,136,65,225,26,162,122,194,209,37,126,89,108,189,252,57,108,186,81,173,100,6,143,232,207,254,165,207,140,36,27,192,98,217,77,31,194,201,50,131,189,159,65,156,243,237,59,249,21,185,18,153,29,141,247,5,70,67,122,74,149,139,250,130,231,50,173,64,248,96,213,186,198,77,154,136,250,10,137,13,123,153,237,113,231,37,89,175,60,56,19,232,166,129,31,112,44,139,121,251,99,32,59,56,219,1,214,140,255,177,47,157,189,88,96,255,36,148,62,109,36,158,14,34,247,174,59,35,191,175,47,49,115,219,13,157,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("32c31bbf-f71f-44eb-9406-7b7d802e4208"));
		}

		#endregion

	}

	#endregion

}


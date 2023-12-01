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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,193,74,195,64,16,61,183,208,127,24,122,74,64,146,187,181,66,173,86,122,41,61,232,73,68,182,201,108,92,72,118,195,204,46,82,164,255,238,164,53,214,90,22,161,129,36,108,242,230,189,55,111,118,173,106,144,91,85,32,60,33,145,98,167,125,54,119,86,155,42,144,242,198,217,108,97,106,92,54,173,35,63,26,126,142,134,131,192,198,86,39,104,194,73,228,123,182,80,133,119,100,144,5,33,152,60,207,225,198,216,119,36,227,75,87,64,65,168,167,227,229,220,213,161,177,60,171,42,194,74,73,193,161,108,59,206,111,251,34,14,77,163,104,219,175,197,80,141,13,90,207,96,172,71,210,93,7,218,81,199,168,60,66,113,96,4,245,67,217,19,229,191,152,94,238,81,171,80,251,59,99,75,49,159,248,109,139,78,39,81,63,233,21,172,36,47,152,130,149,151,32,163,192,244,85,232,219,176,169,141,52,89,43,102,136,65,225,26,162,122,194,209,37,126,89,108,189,252,57,108,86,170,86,50,131,71,244,103,255,146,103,70,146,13,96,177,232,166,15,225,100,153,194,222,207,32,206,249,246,157,252,154,92,129,204,142,38,251,2,163,33,57,165,202,68,125,201,11,153,86,32,124,176,106,83,99,153,140,69,125,141,196,134,189,204,246,184,243,198,105,175,60,56,19,232,166,129,31,112,44,139,121,251,99,32,61,56,219,1,214,140,255,177,175,156,189,88,96,255,36,148,62,109,36,158,14,34,247,174,59,35,114,125,1,180,112,47,242,148,3,0,0 };
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


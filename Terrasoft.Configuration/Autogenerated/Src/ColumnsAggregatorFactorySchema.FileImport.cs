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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,209,74,195,48,20,125,222,96,255,112,217,83,11,210,190,59,39,204,233,100,47,99,15,250,36,34,89,123,83,3,105,82,110,18,100,200,254,221,155,205,58,231,8,194,10,109,73,123,238,57,231,158,155,24,209,162,235,68,133,240,132,68,194,89,233,139,185,53,82,53,129,132,87,214,20,11,165,113,217,118,150,252,104,248,57,26,14,130,83,166,57,65,19,78,18,223,139,133,168,188,37,133,142,17,140,41,203,18,110,148,121,71,82,190,182,21,84,132,114,58,94,206,173,14,173,113,179,166,33,108,4,23,28,202,182,227,242,182,47,114,161,109,5,109,251,53,27,210,216,162,241,14,148,241,72,50,118,32,45,69,70,225,17,170,3,35,136,31,202,158,168,252,197,244,114,143,82,4,237,239,148,169,217,124,230,183,29,90,153,37,253,228,87,176,226,188,96,10,134,95,140,76,2,243,87,166,239,194,70,43,110,82,11,231,32,5,133,107,72,234,49,71,76,252,178,216,122,249,115,216,172,22,29,103,6,143,232,207,254,101,207,14,137,55,128,193,42,78,31,194,201,50,135,189,159,65,154,243,237,59,249,53,217,10,157,179,52,217,23,40,9,217,41,85,193,234,75,183,224,105,5,194,7,35,54,26,235,108,204,234,107,36,167,156,231,217,30,119,222,56,239,149,7,103,2,113,26,248,1,199,178,148,183,63,6,242,131,179,29,160,118,248,31,251,202,154,139,5,246,79,66,238,211,36,226,137,16,190,119,241,140,196,235,11,118,94,41,254,149,3,0,0 };
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


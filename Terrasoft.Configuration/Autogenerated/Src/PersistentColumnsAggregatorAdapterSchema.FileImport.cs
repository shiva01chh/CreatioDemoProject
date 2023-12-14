namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PersistentColumnsAggregatorAdapterSchema

	/// <exclude/>
	public class PersistentColumnsAggregatorAdapterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PersistentColumnsAggregatorAdapterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PersistentColumnsAggregatorAdapterSchema(PersistentColumnsAggregatorAdapterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a19ab3c1-267e-4152-ae6e-61811f92503a");
			Name = "PersistentColumnsAggregatorAdapter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,84,193,110,219,48,12,61,183,64,255,129,112,47,25,80,216,247,46,53,16,100,221,144,195,134,2,91,119,87,100,198,21,96,83,6,37,13,8,130,253,251,104,57,112,236,44,118,54,96,167,249,98,137,122,124,228,163,40,146,170,209,53,74,35,124,67,102,229,236,206,167,107,75,59,83,6,86,222,88,74,63,154,10,55,117,99,217,223,221,30,238,110,111,130,51,84,194,215,189,243,88,11,180,170,80,183,56,151,126,66,66,54,250,125,143,25,50,50,138,93,78,238,25,75,65,195,186,82,206,61,194,11,178,51,194,68,94,152,66,77,238,133,173,70,231,44,175,10,213,120,228,232,212,132,109,101,52,232,214,231,119,151,85,89,10,169,242,189,15,92,224,61,129,30,96,51,229,40,161,14,49,224,41,77,17,230,57,104,193,180,217,198,60,58,68,150,101,176,52,244,38,146,125,97,53,100,121,111,117,161,174,21,239,123,195,154,81,121,116,96,132,75,145,148,218,238,192,239,27,20,36,34,104,198,221,83,114,93,85,34,33,210,62,70,118,30,100,217,40,86,53,144,220,231,83,18,28,178,164,78,221,213,36,249,171,236,65,247,134,116,153,69,244,101,103,178,116,158,77,127,43,46,201,103,125,155,63,116,60,222,232,117,213,139,215,145,20,24,43,123,104,185,110,54,207,20,106,100,181,173,112,185,249,50,153,125,14,179,202,46,112,77,130,115,152,22,250,46,242,60,194,86,57,92,156,165,123,37,131,57,86,56,192,207,255,172,243,254,81,19,204,20,124,80,181,123,164,162,123,212,227,23,254,25,253,155,45,174,60,238,174,82,147,115,35,201,134,122,126,88,83,192,170,40,22,221,212,124,38,111,252,30,204,96,35,35,40,238,58,62,41,79,251,27,27,191,171,42,224,241,36,174,143,237,57,128,124,64,231,13,197,33,13,197,105,61,211,41,127,47,227,216,128,139,233,66,118,214,177,49,218,218,239,23,20,135,154,218,94,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a19ab3c1-267e-4152-ae6e-61811f92503a"));
		}

		#endregion

	}

	#endregion

}


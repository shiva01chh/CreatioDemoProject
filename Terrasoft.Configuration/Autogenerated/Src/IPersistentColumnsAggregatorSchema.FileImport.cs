namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPersistentColumnsAggregatorSchema

	/// <exclude/>
	public class IPersistentColumnsAggregatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPersistentColumnsAggregatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPersistentColumnsAggregatorSchema(IPersistentColumnsAggregatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("333054bb-29a4-4f0e-82ae-cc1b1c7cc202");
			Name = "IPersistentColumnsAggregator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,141,49,10,195,48,12,0,231,26,252,7,61,160,228,1,221,218,64,193,91,134,126,192,53,178,17,216,150,145,228,41,228,239,77,231,220,122,28,215,99,67,29,49,33,124,80,36,42,103,91,86,238,153,202,148,104,196,125,121,83,197,208,6,139,121,183,123,119,27,243,91,41,1,117,67,201,255,48,108,40,74,106,216,109,229,58,91,215,103,41,130,37,26,11,60,174,122,19,78,168,122,135,240,138,138,151,228,92,236,112,128,119,135,119,39,63,84,5,28,194,161,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("333054bb-29a4-4f0e-82ae-cc1b1c7cc202"));
		}

		#endregion

	}

	#endregion

}


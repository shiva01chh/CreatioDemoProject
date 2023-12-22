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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,141,49,10,195,48,12,0,231,26,252,7,63,160,228,1,221,218,64,193,91,134,126,64,53,178,49,216,146,145,228,41,228,239,109,183,66,110,61,142,35,232,168,3,18,134,23,138,128,114,182,101,101,202,181,76,1,171,76,203,179,54,140,125,176,152,119,187,119,151,49,223,173,166,80,201,80,242,47,140,27,138,86,53,36,91,185,205,78,122,47,69,176,128,177,132,219,89,111,194,9,85,175,33,62,64,241,148,124,23,123,56,130,119,135,119,255,124,0,76,213,172,78,170,0,0,0 };
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


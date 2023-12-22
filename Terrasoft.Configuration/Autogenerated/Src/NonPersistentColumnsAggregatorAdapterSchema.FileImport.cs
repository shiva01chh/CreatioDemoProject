namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NonPersistentColumnsAggregatorAdapterSchema

	/// <exclude/>
	public class NonPersistentColumnsAggregatorAdapterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NonPersistentColumnsAggregatorAdapterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NonPersistentColumnsAggregatorAdapterSchema(NonPersistentColumnsAggregatorAdapterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0e17349a-19a3-44d5-b001-2f4514573b56");
			Name = "NonPersistentColumnsAggregatorAdapter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,193,106,194,64,16,61,43,244,31,134,120,177,80,146,187,181,1,145,182,120,104,17,90,63,96,221,140,233,66,178,27,102,54,5,145,254,123,199,36,166,49,106,241,208,75,115,243,249,102,222,155,121,153,88,149,35,23,74,35,188,35,145,98,183,241,225,220,217,141,73,75,82,222,56,27,62,153,12,23,121,225,200,223,12,119,55,195,65,201,198,166,240,182,101,143,185,80,179,12,245,158,199,225,51,90,36,163,239,91,78,183,35,161,224,242,207,136,48,21,54,192,60,83,204,19,120,117,118,137,196,70,186,89,47,221,202,220,242,44,77,133,165,188,163,89,162,10,143,84,85,70,81,4,83,99,63,68,195,39,78,131,38,220,60,4,77,201,146,156,70,102,71,65,20,11,183,40,215,153,17,202,94,227,58,9,152,64,191,213,29,44,46,27,26,236,42,83,237,60,178,51,246,84,106,225,200,84,203,74,191,102,84,190,185,204,115,69,219,248,0,204,9,149,71,6,35,85,202,202,246,221,6,252,182,64,97,34,54,163,93,229,91,230,13,91,149,168,47,51,45,20,169,28,172,132,252,16,148,140,36,54,109,157,87,16,175,228,55,232,22,8,167,81,197,62,95,172,43,253,118,55,28,196,93,122,179,239,171,28,143,87,71,62,224,216,214,221,190,221,96,176,120,180,101,142,164,214,25,78,155,20,90,237,24,250,102,110,235,162,9,172,21,227,184,215,240,148,13,59,248,234,100,243,243,78,69,241,191,13,236,239,18,248,109,153,157,213,141,208,38,245,187,127,124,8,47,232,63,92,114,238,6,78,110,247,226,121,213,71,124,152,233,211,153,4,154,248,198,245,151,104,185,159,27,133,41,129,244,128,203,22,107,244,24,172,176,238,243,13,248,149,175,159,16,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e17349a-19a3-44d5-b001-2f4514573b56"));
		}

		#endregion

	}

	#endregion

}


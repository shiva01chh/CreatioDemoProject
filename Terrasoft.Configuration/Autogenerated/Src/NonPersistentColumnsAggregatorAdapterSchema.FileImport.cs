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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,77,107,194,64,16,61,43,244,63,12,241,98,161,36,119,107,3,34,109,241,208,34,180,254,128,117,51,166,11,201,110,152,217,20,68,250,223,59,249,48,213,168,197,67,47,205,205,231,155,121,111,230,101,98,85,142,92,40,141,240,142,68,138,221,198,135,115,103,55,38,45,73,121,227,108,248,100,50,92,228,133,35,127,51,220,221,12,7,37,27,155,194,219,150,61,230,66,205,50,212,21,143,195,103,180,72,70,223,119,156,195,142,132,130,203,63,35,194,84,216,0,243,76,49,79,224,213,217,37,18,27,233,102,189,116,43,115,203,179,52,21,150,242,142,102,137,42,60,82,93,25,69,17,76,141,253,16,13,159,56,13,154,112,243,16,180,37,75,114,26,153,29,5,81,44,220,162,92,103,70,40,149,198,117,18,48,129,126,171,59,88,92,54,52,216,213,166,186,121,100,103,236,169,212,194,145,169,150,181,126,195,168,125,115,153,231,138,182,241,30,152,19,42,143,12,70,170,148,149,237,187,13,248,109,129,194,68,108,71,187,202,183,204,27,118,42,81,95,102,90,40,82,57,88,9,249,33,40,25,73,108,218,38,175,32,94,201,111,208,29,16,78,163,154,125,190,88,215,250,221,110,56,136,15,233,237,190,175,114,60,94,29,249,128,99,91,119,85,187,193,96,241,104,203,28,73,173,51,156,182,41,116,218,49,244,205,220,54,69,19,88,43,198,113,175,225,41,27,118,240,117,144,205,207,59,21,197,255,54,176,191,75,224,183,101,30,172,110,132,54,105,222,253,227,67,120,65,255,225,146,115,55,112,114,187,23,207,171,57,226,253,76,159,206,36,208,198,55,110,190,68,203,106,110,20,166,4,210,3,46,91,108,208,99,176,198,170,231,27,61,230,30,111,8,5,0,0 };
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


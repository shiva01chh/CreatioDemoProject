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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,193,74,195,64,16,61,167,208,127,24,226,165,130,36,247,218,6,74,81,233,65,9,168,31,176,221,76,227,66,178,27,102,54,66,41,254,187,211,36,198,54,182,210,131,23,115,235,235,155,121,111,230,101,98,85,137,92,41,141,240,130,68,138,221,198,71,75,103,55,38,175,73,121,227,108,116,111,10,92,149,149,35,63,30,237,198,163,160,102,99,115,120,222,178,199,82,168,69,129,122,207,227,232,1,45,146,209,183,61,231,176,35,161,224,242,207,21,97,46,108,128,101,161,152,167,240,228,108,138,196,70,186,89,47,221,234,210,242,34,207,133,165,188,163,69,166,42,143,212,84,198,113,12,51,99,223,68,195,103,78,131,38,220,204,195,174,36,37,167,145,217,81,24,39,194,173,234,117,97,132,178,215,184,76,2,166,48,108,117,3,171,243,134,130,93,99,170,159,71,118,198,158,106,45,28,153,42,109,244,91,70,227,155,235,178,84,180,77,190,128,37,161,242,200,96,164,74,89,217,190,219,128,223,86,40,76,196,110,180,139,124,203,188,81,175,18,15,101,102,149,34,85,130,149,144,231,97,205,72,98,211,182,121,133,201,171,252,6,221,3,209,44,110,216,167,139,117,163,223,239,134,195,228,144,222,237,251,34,199,147,215,35,31,112,108,235,102,223,46,8,86,119,182,46,145,212,186,192,89,151,66,175,157,192,208,204,117,91,52,133,181,98,156,12,26,254,100,195,14,62,14,178,249,126,167,226,228,223,6,246,119,9,252,182,204,131,213,93,161,205,218,119,255,248,16,30,209,191,185,236,212,13,252,184,221,179,231,213,30,241,215,76,239,206,100,208,197,55,105,191,68,233,126,110,20,166,4,50,0,206,91,108,209,99,176,193,228,249,4,250,172,251,161,7,5,0,0 };
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


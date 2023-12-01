namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelCellWriterConfigSchema

	/// <exclude/>
	public class ExcelCellWriterConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelCellWriterConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelCellWriterConfigSchema(ExcelCellWriterConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("346c17cb-c7b3-4b13-89c8-26d13a32c8da");
			Name = "ExcelCellWriterConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,193,106,2,49,16,134,207,10,190,195,128,247,221,75,233,161,150,94,182,10,94,44,84,109,123,205,166,227,146,146,100,150,201,4,21,241,221,205,102,215,34,148,98,32,9,127,242,205,252,51,227,149,195,208,42,141,176,65,102,21,104,39,69,69,126,103,154,200,74,12,249,98,126,104,137,101,67,243,131,70,59,25,159,38,227,81,12,198,55,176,62,6,65,55,251,213,175,164,163,67,47,11,98,167,164,120,107,209,127,57,155,254,19,49,101,108,82,50,168,172,10,225,9,114,174,10,173,253,100,35,200,189,97,6,203,178,132,231,16,157,83,124,124,25,116,166,33,109,11,251,204,131,206,1,197,149,47,111,2,218,88,91,163,65,119,70,255,249,140,186,38,174,228,80,103,79,192,112,157,160,65,153,65,232,142,243,13,188,93,122,121,124,128,119,218,175,162,171,239,131,21,217,232,252,29,150,234,31,212,2,31,202,70,252,3,157,251,249,161,255,238,71,216,201,244,150,214,5,135,71,17,204,187,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("346c17cb-c7b3-4b13-89c8-26d13a32c8da"));
		}

		#endregion

	}

	#endregion

}


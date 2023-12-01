namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntExcelCellWriterSchema

	/// <exclude/>
	public class IntExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntExcelCellWriterSchema(IntExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("61d5eba2-33cc-431f-aed3-08714edf99a5");
			Name = "IntExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,79,107,194,64,16,197,207,10,126,135,129,94,244,146,220,253,119,104,106,161,135,130,80,105,207,235,102,140,91,54,59,97,118,99,45,210,239,222,217,141,218,106,165,129,64,230,205,123,251,126,27,167,106,244,141,210,8,43,100,86,158,54,33,43,200,109,76,213,178,10,134,92,182,216,55,196,97,69,139,189,70,59,232,31,6,253,65,191,119,199,88,201,18,10,171,188,31,195,3,106,83,43,155,44,5,90,251,72,92,171,16,144,147,57,207,115,152,250,182,174,21,127,206,143,243,147,11,88,33,3,198,8,200,107,225,131,141,36,178,83,32,255,149,104,218,181,53,26,116,108,139,209,115,209,91,202,192,24,238,149,199,43,85,114,29,236,153,118,201,212,32,7,131,130,188,76,71,118,123,233,155,26,183,69,137,149,164,33,143,149,167,78,218,201,127,49,37,194,213,229,254,204,179,249,181,148,9,233,228,72,128,174,236,32,46,137,158,49,108,169,140,56,76,1,117,192,242,63,162,147,231,7,202,7,54,174,130,174,239,85,217,22,135,180,126,23,19,236,226,48,130,67,12,246,118,138,193,184,206,0,51,24,202,247,40,25,38,105,205,24,90,118,103,71,182,162,151,116,238,112,148,246,95,55,239,208,169,151,162,104,242,124,3,255,62,81,74,84,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("61d5eba2-33cc-431f-aed3-08714edf99a5"));
		}

		#endregion

	}

	#endregion

}


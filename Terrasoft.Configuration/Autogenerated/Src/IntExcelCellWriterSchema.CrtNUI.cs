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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,205,106,195,48,16,132,207,9,228,29,22,122,113,46,246,61,127,135,186,41,244,80,8,212,180,103,69,222,56,42,178,214,172,228,52,37,244,221,43,201,137,155,184,165,6,131,119,118,70,243,201,70,212,104,27,33,17,10,100,22,150,118,46,205,201,236,84,213,178,112,138,76,186,62,54,196,174,160,245,81,162,158,140,79,147,241,100,60,186,99,172,252,18,114,45,172,157,193,3,74,85,11,29,45,57,106,253,72,92,11,231,144,163,57,203,50,88,216,182,174,5,127,174,206,243,147,113,88,33,3,134,8,248,87,195,7,43,159,72,47,129,236,42,209,180,91,173,36,200,208,22,162,125,209,91,204,192,12,238,133,197,129,234,115,29,108,79,187,97,106,144,157,66,143,188,137,71,118,123,223,183,80,102,143,62,86,146,132,44,84,94,58,233,224,255,139,42,17,6,151,251,53,47,87,67,41,245,164,243,51,1,154,178,131,184,37,122,70,183,167,50,224,48,57,148,14,203,255,136,46,158,31,40,235,88,153,10,186,190,87,161,91,76,104,251,238,77,112,8,195,20,78,33,56,58,8,6,101,58,3,44,33,241,223,211,104,152,199,53,163,107,217,244,142,180,160,151,120,110,50,141,251,175,63,239,208,169,183,162,215,174,159,111,90,4,197,39,93,2,0,0 };
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


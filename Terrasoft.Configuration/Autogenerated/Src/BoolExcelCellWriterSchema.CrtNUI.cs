namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BoolExcelCellWriterSchema

	/// <exclude/>
	public class BoolExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BoolExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BoolExcelCellWriterSchema(BoolExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bb306662-1573-42f1-9db8-66a8d68b57c0");
			Name = "BoolExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,219,78,195,48,12,134,175,59,105,239,96,193,205,38,161,246,126,39,36,166,237,10,208,36,6,92,103,173,41,65,105,92,57,105,57,76,188,59,105,178,178,3,99,80,169,82,29,255,182,255,126,142,22,5,154,82,164,8,75,100,22,134,158,108,60,37,253,36,243,138,133,149,164,227,217,91,73,108,151,52,123,75,81,117,59,235,110,39,170,140,212,249,94,65,81,144,30,118,59,46,119,206,152,187,50,152,42,97,204,0,238,44,59,173,175,157,162,82,143,44,45,178,23,38,73,2,35,83,21,133,224,247,201,38,14,106,192,70,14,238,85,240,234,11,226,86,159,236,20,148,213,74,201,20,210,102,16,92,17,169,131,41,240,235,244,104,237,29,108,189,146,54,86,104,235,252,46,88,214,194,98,200,151,33,128,180,201,131,9,230,110,43,121,35,180,200,145,111,29,59,24,195,217,22,132,203,157,13,79,212,46,185,194,224,233,65,168,10,219,6,129,223,189,149,202,196,7,146,147,237,230,66,153,191,250,29,106,218,134,231,168,179,240,251,251,44,22,76,37,178,149,216,192,240,132,67,222,225,31,73,253,140,14,97,70,41,36,19,239,42,172,128,106,71,64,102,8,223,164,231,196,133,176,63,226,241,228,240,40,110,22,247,135,165,27,180,207,148,249,229,144,197,212,98,118,202,82,171,217,186,106,105,249,129,30,66,143,86,47,78,4,117,19,244,161,185,211,81,84,11,134,149,115,227,21,14,99,175,9,250,65,51,244,10,70,91,177,222,21,141,193,186,125,249,100,116,9,26,95,225,154,82,161,228,135,88,169,13,245,222,254,133,185,56,118,9,250,177,255,12,125,6,255,236,115,108,251,155,70,222,238,231,81,170,225,116,255,208,157,237,62,95,255,134,165,211,20,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb306662-1573-42f1-9db8-66a8d68b57c0"));
		}

		#endregion

	}

	#endregion

}


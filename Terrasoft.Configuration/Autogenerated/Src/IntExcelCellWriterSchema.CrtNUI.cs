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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,205,106,195,48,16,132,207,9,248,29,22,122,137,47,246,61,127,135,186,41,244,80,8,52,180,103,69,222,56,42,178,214,172,228,52,37,244,221,43,201,177,219,164,161,6,131,119,118,70,243,201,70,212,104,27,33,17,54,200,44,44,237,92,86,144,217,169,170,101,225,20,153,108,117,108,136,221,134,86,71,137,58,25,159,146,113,50,30,221,49,86,126,9,133,22,214,78,225,1,165,170,133,142,150,2,181,126,36,174,133,115,200,209,156,231,57,204,109,91,215,130,63,151,231,249,201,56,172,144,1,67,4,252,171,225,131,149,79,100,125,32,255,149,104,218,173,86,18,100,104,11,209,161,232,45,102,96,10,247,194,226,149,234,115,29,236,64,187,102,106,144,157,66,143,188,142,71,118,123,223,55,87,102,143,62,86,146,132,60,84,246,157,116,240,255,69,149,8,87,151,251,51,47,150,215,82,230,73,103,103,2,52,101,7,113,73,244,140,110,79,101,192,97,114,40,29,150,255,17,245,158,31,40,235,88,153,10,186,190,87,161,91,156,208,246,221,155,224,16,134,20,78,33,56,58,8,6,101,58,3,44,96,226,191,211,104,152,197,53,163,107,217,12,142,108,67,47,241,220,73,26,247,95,55,239,208,169,151,162,215,194,243,13,32,184,159,31,85,2,0,0 };
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


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,77,79,194,64,16,134,207,37,225,63,76,224,2,137,105,239,34,152,72,224,36,196,68,212,243,210,14,176,102,187,211,204,110,1,53,254,119,183,187,84,62,68,180,73,147,206,206,59,51,111,159,89,45,114,52,133,72,17,102,200,44,12,45,108,60,36,189,144,203,146,133,149,164,227,209,182,32,182,51,26,109,83,84,205,198,71,179,17,149,70,234,229,81,65,158,147,238,53,27,46,215,102,92,186,50,24,42,97,204,53,60,90,118,90,95,59,68,165,94,88,90,100,47,76,146,4,110,76,153,231,130,223,6,187,56,168,1,43,57,184,87,193,198,23,196,181,62,57,40,40,202,185,146,41,164,213,32,184,35,82,39,83,224,215,233,209,135,119,176,247,74,218,88,161,173,243,251,192,114,45,44,134,124,17,2,72,171,60,152,96,110,90,202,137,208,98,137,60,117,236,160,15,173,61,8,151,107,245,46,212,206,184,196,224,233,89,168,18,235,6,129,223,147,149,202,196,39,146,139,237,198,66,153,191,250,157,106,234,134,109,212,89,248,253,99,22,15,76,5,178,149,88,193,240,132,67,222,225,191,145,122,133,14,97,70,41,36,3,239,42,172,128,214,142,128,204,16,190,73,143,137,115,97,127,196,253,193,233,81,92,45,238,15,75,19,180,43,202,252,114,200,98,106,49,187,100,169,214,236,93,213,180,252,64,15,161,67,243,87,39,130,117,21,116,161,186,211,81,180,22,12,115,231,198,43,28,198,78,21,116,131,166,231,21,140,182,100,125,40,234,131,117,251,242,201,232,22,52,110,224,158,82,161,228,187,152,171,29,245,206,241,133,185,58,119,9,186,177,255,12,125,174,255,217,231,220,246,119,141,188,221,207,179,84,195,233,241,161,59,115,207,23,53,196,56,183,11,4,0,0 };
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


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,219,78,194,64,16,134,175,75,194,59,76,240,6,18,211,222,139,96,34,129,43,33,38,162,94,47,237,136,107,182,59,205,236,22,60,196,119,119,15,84,14,34,218,164,73,103,231,159,153,191,223,172,22,37,154,74,228,8,115,100,22,134,158,108,58,34,253,36,151,53,11,43,73,167,227,215,138,216,206,105,252,154,163,106,183,62,218,173,164,54,82,47,247,10,202,146,116,191,221,114,185,51,198,165,43,131,145,18,198,92,192,157,101,167,13,181,35,84,234,145,165,69,14,194,44,203,224,210,212,101,41,248,109,184,137,163,26,208,203,193,189,10,214,161,32,109,244,217,78,65,85,47,148,204,33,247,131,224,154,72,29,76,129,95,167,39,31,193,193,214,43,105,99,133,182,206,239,45,203,149,176,24,243,85,12,32,247,121,48,209,220,172,150,83,161,197,18,121,230,216,193,0,58,91,16,46,215,233,159,168,157,115,141,209,211,131,80,53,54,13,34,191,123,43,149,73,15,36,39,219,77,132,50,127,245,59,212,52,13,207,80,23,241,247,247,89,220,50,85,200,86,162,135,17,8,199,188,195,127,41,245,51,58,132,5,229,144,13,131,171,184,2,90,57,2,178,64,248,38,61,33,46,133,253,17,15,134,135,71,169,95,220,31,150,166,104,159,169,8,203,33,139,185,197,226,148,165,70,179,117,213,208,10,3,3,132,46,45,94,156,8,86,62,232,129,191,211,73,178,18,12,11,231,38,40,28,198,174,15,122,81,211,15,10,70,91,179,222,21,13,192,186,125,133,100,114,5,26,215,112,67,185,80,242,93,44,212,134,122,119,255,194,156,31,187,4,189,52,124,198,62,23,255,236,115,108,251,155,70,193,238,231,81,170,241,116,255,208,157,249,231,11,116,250,211,100,12,4,0,0 };
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


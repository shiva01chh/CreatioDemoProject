namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LookupExcelCellWriterSchema

	/// <exclude/>
	public class LookupExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LookupExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LookupExcelCellWriterSchema(LookupExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("434dfe6c-8e8d-4e15-b08d-b3f5add4566b");
			Name = "LookupExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,80,187,142,194,48,16,172,137,148,127,88,233,250,184,7,142,38,226,42,10,36,144,168,125,206,18,172,115,188,214,218,225,33,196,191,159,99,3,226,101,201,197,204,206,236,140,214,202,14,189,147,10,97,141,204,210,211,54,84,53,217,173,110,123,150,65,147,173,230,71,71,28,214,52,63,42,52,101,113,46,139,178,24,125,49,182,113,8,181,145,222,143,97,65,244,215,187,164,168,209,152,13,235,128,156,132,66,8,152,250,190,235,36,159,102,87,156,213,128,131,28,226,55,112,72,134,234,166,23,15,6,215,255,26,173,64,13,65,159,115,96,12,171,192,218,182,111,249,163,92,246,222,118,201,228,144,131,198,88,121,153,246,230,121,12,157,106,187,195,104,107,72,129,24,114,111,193,180,143,119,209,13,194,125,251,15,113,39,195,27,254,158,189,82,85,174,59,185,150,64,219,228,30,9,95,242,29,159,200,200,61,190,127,109,197,154,241,156,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("434dfe6c-8e8d-4e15-b08d-b3f5add4566b"));
		}

		#endregion

	}

	#endregion

}


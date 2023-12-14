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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,80,187,142,194,48,16,172,137,148,127,88,233,250,184,15,28,77,196,85,20,72,32,81,27,103,9,214,57,94,107,237,240,16,226,223,207,177,1,221,29,88,114,49,179,51,59,163,181,178,71,239,164,66,216,32,179,244,180,15,85,67,118,175,187,129,101,208,100,171,197,217,17,135,13,45,206,10,77,89,92,203,162,44,38,31,140,93,28,66,99,164,247,53,44,137,190,7,151,20,13,26,179,101,29,144,147,80,8,1,51,63,244,189,228,203,252,142,179,26,112,148,67,252,6,78,201,80,61,244,226,151,193,13,59,163,21,168,49,232,125,14,212,176,14,172,109,247,146,63,201,101,159,109,87,76,14,57,104,140,149,87,105,111,158,199,208,153,182,7,140,182,150,20,136,49,247,17,76,199,120,23,221,34,60,183,127,17,247,50,188,224,207,249,127,170,202,117,167,247,18,104,219,220,35,225,91,190,227,31,50,114,227,251,1,103,138,141,198,148,1,0,0 };
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


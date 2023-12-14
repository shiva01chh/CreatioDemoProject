namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportExcelDataSchema

	/// <exclude/>
	public class ImportExcelDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportExcelDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportExcelDataSchema(ImportExcelDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f0c56b32-3373-4f0c-9885-a983759de99d");
			Name = "ImportExcelData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,93,107,131,48,20,134,175,45,236,63,28,218,155,237,70,239,117,219,141,43,67,232,74,161,221,245,72,245,52,132,197,68,146,56,42,165,255,125,249,80,177,29,91,23,48,230,227,61,111,206,121,18,65,106,212,13,41,17,118,168,20,209,242,96,226,92,138,3,163,173,34,134,73,17,23,117,35,149,89,30,75,228,47,196,144,187,217,233,110,22,181,154,9,10,219,78,27,172,179,113,78,185,220,19,158,166,185,172,107,27,185,146,148,218,101,187,111,21,11,133,212,218,65,206,137,214,41,4,215,92,242,182,22,91,52,86,230,85,73,146,192,163,110,235,154,168,238,185,159,47,250,54,14,166,19,24,127,227,138,79,53,30,204,146,137,91,211,238,57,43,161,116,41,4,89,72,32,20,108,5,174,180,65,197,132,129,66,84,120,132,19,80,52,25,104,215,157,39,10,109,148,171,58,39,141,3,117,75,182,20,134,153,46,28,184,182,212,127,213,239,165,228,80,232,149,148,159,109,179,235,154,27,202,53,98,21,104,254,208,157,3,121,20,213,191,224,95,93,145,7,244,110,24,103,134,161,246,138,177,34,251,52,46,56,142,50,24,40,14,102,27,37,27,84,110,43,133,141,15,247,78,81,163,216,23,49,56,120,41,36,149,20,188,131,194,190,26,248,224,182,123,2,59,124,35,130,80,84,241,43,26,247,156,80,221,207,253,129,243,135,172,247,185,72,201,71,187,207,231,16,89,28,253,40,82,104,90,37,188,115,230,87,60,200,64,104,130,232,15,106,215,60,172,206,181,111,238,13,60,8,66,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f0c56b32-3373-4f0c-9885-a983759de99d"));
		}

		#endregion

	}

	#endregion

}


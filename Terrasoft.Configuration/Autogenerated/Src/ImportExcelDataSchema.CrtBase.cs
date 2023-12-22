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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,93,107,131,48,20,134,175,45,236,63,28,218,155,237,70,239,117,219,141,43,67,232,74,161,221,245,72,245,84,194,98,18,146,56,42,165,255,125,249,80,177,29,91,23,48,230,227,61,111,206,121,18,78,26,212,146,148,8,59,84,138,104,113,48,113,46,248,129,214,173,34,134,10,30,23,141,20,202,44,143,37,178,23,98,200,221,236,116,55,139,90,77,121,13,219,78,27,108,178,113,94,51,177,39,44,77,115,209,52,54,114,37,234,218,46,219,125,171,88,40,172,173,29,228,140,104,157,66,112,205,5,107,27,190,69,99,101,94,149,36,9,60,234,182,105,136,234,158,251,249,162,111,227,96,58,129,241,55,174,248,84,227,193,44,153,184,201,118,207,104,9,165,75,33,200,66,2,161,96,43,112,165,13,42,202,13,20,188,194,35,156,160,70,147,129,118,221,121,162,208,70,185,170,115,34,29,168,91,178,37,55,212,116,225,192,181,165,254,171,126,47,4,131,66,175,132,248,108,229,174,147,55,148,107,196,42,208,252,161,59,7,242,200,171,127,193,191,186,34,15,232,221,80,70,13,69,237,21,99,69,246,105,92,112,28,101,48,80,28,204,54,74,72,84,110,43,133,141,15,247,78,145,84,244,139,24,28,188,20,146,74,112,214,65,97,95,13,124,48,219,61,129,29,190,17,78,106,84,241,43,26,247,156,80,221,207,253,129,243,135,172,247,185,72,201,71,187,207,231,16,89,28,253,40,82,104,90,197,189,115,230,87,60,200,64,104,130,232,15,106,215,60,172,110,218,190,1,138,25,236,119,74,3,0,0 };
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


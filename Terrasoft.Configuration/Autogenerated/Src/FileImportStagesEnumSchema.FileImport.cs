namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportStagesEnumSchema

	/// <exclude/>
	public class FileImportStagesEnumSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportStagesEnumSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportStagesEnumSchema(FileImportStagesEnumSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bb4174ad-6f70-437d-9b0f-36d3b9a6d06b");
			Name = "FileImportStagesEnum";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,205,75,10,2,49,12,128,225,245,20,230,14,61,128,12,248,216,186,42,35,184,19,244,2,181,100,134,66,155,148,36,93,137,119,183,234,66,209,9,89,229,255,32,232,51,72,241,1,236,5,152,189,208,164,131,35,156,226,92,217,107,36,28,14,49,193,49,23,98,237,205,173,55,93,169,215,20,131,5,172,217,126,218,89,253,12,50,182,99,35,79,214,157,24,138,103,248,33,118,111,215,171,119,166,0,34,142,82,205,40,255,106,243,173,70,212,168,17,22,216,246,197,28,229,146,64,23,158,237,90,190,247,166,109,155,7,23,62,251,14,237,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb4174ad-6f70-437d-9b0f-36d3b9a6d06b"));
		}

		#endregion

	}

	#endregion

}


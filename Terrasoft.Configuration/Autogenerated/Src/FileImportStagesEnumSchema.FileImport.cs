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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,205,205,10,194,48,12,192,241,243,10,125,135,62,128,12,252,184,122,42,19,188,13,244,5,106,201,70,160,109,74,147,158,196,119,183,211,131,162,11,57,229,255,131,36,23,129,179,243,96,174,80,138,99,154,164,183,148,38,156,107,113,130,148,250,19,6,56,199,76,69,180,186,107,213,229,122,11,232,13,164,26,205,167,93,196,205,192,67,59,54,178,176,110,44,144,93,129,31,98,142,102,187,121,103,242,192,108,41,212,152,248,95,237,190,213,144,4,5,97,133,237,95,204,82,204,1,100,229,217,161,229,135,86,109,151,121,2,106,120,10,177,238,0,0,0 };
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


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,205,205,10,194,48,12,192,241,243,10,125,135,62,128,12,252,184,122,42,19,188,13,244,5,106,201,70,160,109,74,154,158,196,119,183,234,193,161,11,57,229,255,131,36,23,161,100,231,193,92,129,217,21,154,164,183,148,38,156,43,59,65,74,253,9,3,156,99,38,22,173,238,90,117,185,222,2,122,3,169,70,243,109,23,113,51,148,161,29,27,121,177,110,100,200,142,225,135,152,163,217,110,62,153,60,148,98,41,212,152,202,191,218,45,213,144,4,5,97,133,237,223,204,82,204,1,100,229,217,161,229,135,86,109,151,243,4,243,227,57,209,246,0,0,0 };
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


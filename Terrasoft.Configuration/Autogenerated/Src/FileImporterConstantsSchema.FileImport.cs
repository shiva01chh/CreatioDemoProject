namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImporterConstantsSchema

	/// <exclude/>
	public class FileImporterConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImporterConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImporterConstantsSchema(FileImporterConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1dc2dd32-8b13-47cd-be30-3ed1dbba2572");
			Name = "FileImporterConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,193,10,194,48,12,134,207,27,236,29,10,222,135,30,188,108,120,26,8,30,132,137,190,64,221,178,89,232,218,145,180,224,24,190,187,177,67,198,4,5,115,41,249,243,255,95,67,140,236,128,122,89,129,184,0,162,36,219,184,180,176,166,81,173,71,233,148,53,233,94,105,56,116,189,69,151,196,99,18,71,158,148,105,197,121,32,7,93,158,196,172,172,16,90,118,138,66,75,162,76,204,1,64,70,145,147,198,81,48,246,254,170,85,37,88,113,252,84,47,251,55,119,52,134,196,204,126,143,50,81,6,202,52,94,18,149,113,226,40,239,39,15,56,48,151,137,84,88,207,226,78,108,215,235,252,119,160,148,200,183,248,47,83,220,148,174,63,126,218,132,84,216,29,76,61,173,31,250,199,116,172,133,200,26,215,19,210,154,90,254,133,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1dc2dd32-8b13-47cd-be30-3ed1dbba2572"));
		}

		#endregion

	}

	#endregion

}


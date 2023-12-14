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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,193,10,131,48,12,134,207,10,190,67,97,119,113,135,93,148,157,10,131,29,6,142,237,5,58,141,174,80,91,105,90,152,200,222,125,177,50,196,193,6,203,165,228,207,255,127,13,209,162,3,236,69,5,236,10,214,10,52,141,75,185,209,141,108,189,21,78,26,157,30,164,130,99,215,27,235,146,120,76,226,200,163,212,45,187,12,232,160,43,146,152,148,141,133,150,156,140,43,129,152,179,37,0,150,80,232,132,118,24,140,189,191,41,89,49,82,28,61,213,100,255,230,142,198,144,88,216,239,81,206,202,64,153,199,107,162,212,142,157,196,227,236,193,14,196,37,34,114,227,73,220,179,93,150,21,191,3,165,176,116,139,255,50,252,46,85,253,241,211,54,164,194,238,160,235,121,253,208,63,231,99,173,68,210,166,122,1,241,239,244,90,134,1,0,0 };
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


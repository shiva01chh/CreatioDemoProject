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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,193,10,194,48,12,134,207,27,236,29,10,222,199,60,120,217,240,84,16,60,8,19,125,129,186,101,179,208,181,163,105,193,49,124,119,99,135,204,9,10,230,82,242,231,255,191,134,104,209,1,246,162,2,118,6,107,5,154,198,165,220,232,70,182,222,10,39,141,78,119,82,193,190,235,141,117,73,60,38,113,228,81,234,150,157,6,116,208,21,73,76,202,202,66,75,78,198,149,64,204,217,28,0,75,40,116,66,59,12,198,222,95,148,172,24,41,142,158,234,105,255,230,142,198,144,152,217,175,81,206,202,64,153,198,75,162,212,142,29,196,237,232,193,14,196,37,34,114,227,73,220,178,77,150,21,191,3,165,176,116,139,255,50,252,42,85,253,241,211,58,164,194,238,160,235,105,253,208,223,167,99,45,68,210,222,235,1,65,141,32,249,142,1,0,0 };
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


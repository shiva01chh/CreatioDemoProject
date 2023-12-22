namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportDataChunkSchema

	/// <exclude/>
	public class ImportDataChunkSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportDataChunkSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportDataChunkSchema(ImportDataChunkSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd201402-92ae-464e-8ec8-0ef3cbe29b35");
			Name = "ImportDataChunk";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,59,111,194,48,20,133,103,144,248,15,87,116,173,136,218,110,37,176,80,90,33,117,64,74,182,170,131,155,92,82,139,216,142,252,24,82,196,127,175,31,9,160,64,33,205,16,41,199,231,250,124,246,189,225,132,161,170,72,134,144,162,148,68,137,141,158,44,4,223,208,194,72,162,169,224,147,87,90,226,138,85,66,234,209,112,55,26,14,140,162,188,128,164,86,26,217,116,52,180,202,157,196,194,58,97,201,13,123,134,224,93,124,27,190,77,52,209,232,45,149,249,42,105,6,104,29,23,12,3,183,239,32,21,107,41,50,84,10,102,240,112,239,148,21,63,42,143,94,105,190,49,183,202,147,21,246,1,0,121,30,24,174,243,164,117,117,21,39,172,7,154,119,33,182,166,58,160,44,185,166,186,118,28,183,82,23,37,81,170,141,125,33,154,248,173,189,37,138,34,136,149,97,140,200,122,222,124,251,85,16,27,200,173,21,168,175,154,180,222,168,99,142,181,37,172,136,36,12,184,109,220,108,156,142,231,113,116,16,157,237,35,65,73,73,73,127,200,87,137,159,199,179,102,14,171,75,21,167,243,246,188,45,190,189,225,10,165,166,104,207,176,246,165,30,253,140,221,11,137,237,133,43,90,229,238,4,71,248,115,250,22,227,205,208,188,161,104,138,109,237,14,10,212,83,80,238,181,255,51,44,220,84,136,234,92,214,141,60,95,217,59,199,15,37,100,109,95,66,10,92,143,233,206,116,179,73,191,64,215,14,112,77,236,123,137,157,145,5,255,250,71,86,207,152,52,184,59,27,251,97,57,25,253,139,127,131,213,78,159,95,138,155,114,152,102,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd201402-92ae-464e-8ec8-0ef3cbe29b35"));
		}

		#endregion

	}

	#endregion

}


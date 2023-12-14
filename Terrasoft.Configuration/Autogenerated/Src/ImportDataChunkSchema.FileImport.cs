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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,59,111,194,48,20,133,103,144,248,15,87,116,173,136,218,110,37,176,80,90,33,117,64,74,182,170,131,73,46,169,69,108,71,126,12,41,226,191,215,143,4,170,64,33,205,16,41,199,231,250,124,246,189,225,132,161,170,72,134,144,162,148,68,137,173,158,44,4,223,210,194,72,162,169,224,147,87,90,226,138,85,66,234,209,112,63,26,14,140,162,188,128,164,86,26,217,116,52,180,202,157,196,194,58,97,201,13,123,134,224,93,124,25,190,75,52,209,232,45,149,217,148,52,3,180,142,11,134,129,219,119,144,138,181,20,25,42,5,51,120,184,119,202,138,159,148,71,175,52,223,152,91,229,201,10,135,0,128,60,15,12,215,121,210,186,186,138,19,214,3,205,187,16,59,83,29,81,150,92,83,93,59,142,91,169,139,146,40,213,198,190,16,77,252,214,222,18,69,17,196,202,48,70,100,61,111,190,253,42,136,45,228,214,10,212,87,77,90,111,212,49,199,218,18,86,68,18,6,220,54,110,54,78,199,243,56,58,138,206,246,145,160,164,164,164,223,100,83,226,231,233,172,153,195,234,82,197,233,188,61,111,139,111,111,184,66,169,41,218,51,172,125,169,71,63,99,247,66,98,123,225,138,86,185,59,193,9,254,156,190,197,120,51,52,111,40,154,98,91,187,135,2,245,20,148,123,29,254,12,11,55,21,162,58,151,117,35,207,87,246,206,241,67,9,89,219,151,144,2,215,99,186,51,221,108,210,47,208,181,3,92,19,251,94,98,103,100,193,191,254,145,213,51,38,13,238,206,198,126,88,126,141,254,197,191,193,106,238,249,1,220,185,93,243,94,4,0,0 };
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


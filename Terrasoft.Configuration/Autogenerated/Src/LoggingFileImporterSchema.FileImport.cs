namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LoggingFileImporterSchema

	/// <exclude/>
	public class LoggingFileImporterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LoggingFileImporterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LoggingFileImporterSchema(LoggingFileImporterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("10ecd8e5-f4a7-4119-9170-ce80b8367b66");
			Name = "LoggingFileImporter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,84,93,75,195,48,20,125,174,224,127,8,243,165,123,233,15,168,136,200,112,50,112,56,240,227,69,68,178,246,46,6,218,164,220,164,123,17,255,187,55,105,212,205,196,58,113,48,150,222,157,115,207,57,247,134,42,222,130,233,120,5,236,14,16,185,209,27,91,204,180,218,72,209,35,183,82,171,98,46,27,88,180,157,70,123,124,244,122,124,148,245,70,42,193,68,163,215,188,41,203,153,110,91,2,93,107,33,168,124,250,249,255,110,55,132,159,234,197,156,87,86,163,4,67,8,194,156,32,8,210,100,179,134,27,83,178,208,245,203,1,160,135,61,222,108,169,141,172,225,137,30,186,126,221,200,138,85,142,146,98,176,146,237,55,200,94,125,147,47,49,173,140,197,222,25,33,205,149,111,55,32,66,235,68,211,252,222,0,18,81,65,229,134,196,250,189,199,41,105,174,185,129,252,123,217,205,47,123,11,242,160,234,193,193,190,157,21,234,14,208,210,76,74,119,182,196,133,58,248,65,185,229,22,216,130,28,177,231,70,251,121,83,53,128,134,186,251,122,157,76,128,13,167,12,193,246,168,60,135,157,159,179,220,31,206,28,118,201,21,23,128,197,21,88,151,147,162,77,42,191,211,139,174,35,135,128,147,233,212,203,56,223,191,154,95,130,125,209,117,202,249,135,71,29,86,199,182,90,146,99,63,207,124,248,89,113,164,219,72,211,53,172,251,60,134,161,101,100,174,88,168,141,206,39,3,248,214,114,180,147,96,205,13,187,8,189,118,168,167,73,230,165,170,3,239,109,220,220,18,80,192,7,199,74,183,146,191,57,77,52,136,109,167,84,70,50,36,224,7,7,162,165,84,96,204,76,55,125,171,30,120,211,255,53,80,162,65,28,40,165,50,18,40,1,63,56,208,66,73,251,159,5,197,252,196,181,138,53,198,174,88,132,62,56,204,45,223,254,235,182,197,252,56,76,66,99,36,76,140,142,194,124,123,17,12,213,253,162,175,237,126,222,1,103,195,254,226,116,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("10ecd8e5-f4a7-4119-9170-ce80b8367b66"));
		}

		#endregion

	}

	#endregion

}


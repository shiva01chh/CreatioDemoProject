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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,84,93,75,195,48,20,125,238,192,255,16,230,75,247,210,31,80,17,145,161,50,112,56,240,227,69,68,178,246,46,6,218,164,220,164,123,17,255,187,55,105,252,152,137,117,178,193,88,122,119,206,61,231,220,27,170,120,11,166,227,21,176,59,64,228,70,111,108,49,215,106,35,69,143,220,74,173,138,75,217,192,162,237,52,218,163,201,235,209,36,235,141,84,130,137,70,175,121,83,150,115,221,182,4,186,214,66,80,249,228,243,255,239,221,16,126,171,23,151,188,178,26,37,24,66,16,230,24,65,144,38,155,55,220,152,146,133,174,95,14,0,61,236,241,102,75,109,100,13,79,244,208,245,235,70,86,172,114,148,20,131,149,108,183,65,246,234,155,124,137,105,101,44,246,206,8,105,174,124,187,1,17,90,39,154,230,247,6,144,136,10,42,55,36,214,239,60,206,72,115,205,13,228,63,203,110,126,217,91,144,7,85,15,14,118,237,172,80,119,128,150,102,82,186,179,37,46,212,193,15,202,45,183,192,22,228,136,61,55,218,207,155,170,1,52,212,221,215,235,100,2,108,56,101,8,182,71,229,57,236,236,140,229,254,112,234,176,75,174,184,0,44,174,192,186,156,20,109,90,249,157,158,119,29,57,4,156,206,102,94,198,249,254,211,252,18,236,139,174,83,206,63,60,234,176,58,182,213,146,28,251,121,230,195,207,138,35,221,70,154,174,97,221,231,49,12,45,35,115,197,66,109,116,62,29,192,183,150,163,157,6,107,110,216,69,232,245,141,122,146,100,94,168,58,240,222,198,205,45,1,5,124,112,172,116,43,249,159,211,68,131,216,118,74,101,36,67,2,190,119,32,90,74,5,198,204,117,211,183,234,129,55,253,127,3,37,26,196,129,82,42,35,129,18,240,189,3,45,148,180,135,44,40,230,39,174,85,172,49,118,197,34,244,222,97,110,249,246,160,219,22,243,227,48,9,141,145,48,49,58,10,243,227,69,48,84,119,139,190,70,159,119,129,17,20,220,107,6,0,0 };
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


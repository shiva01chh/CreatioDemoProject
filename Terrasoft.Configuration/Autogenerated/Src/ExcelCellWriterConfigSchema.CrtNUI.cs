namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelCellWriterConfigSchema

	/// <exclude/>
	public class ExcelCellWriterConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelCellWriterConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelCellWriterConfigSchema(ExcelCellWriterConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("346c17cb-c7b3-4b13-89c8-26d13a32c8da");
			Name = "ExcelCellWriterConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,193,106,195,48,12,134,207,45,244,29,4,187,39,151,209,195,58,118,201,90,216,101,133,173,221,118,117,60,53,120,216,86,144,101,218,82,250,238,117,156,116,4,198,168,193,54,191,253,73,191,36,175,28,134,86,105,132,13,50,171,64,59,41,42,242,59,211,68,86,98,200,23,203,67,75,44,27,90,30,52,218,217,244,52,155,78,98,48,190,129,247,99,16,116,139,95,253,76,58,58,244,178,34,118,74,138,117,139,254,203,217,244,159,136,59,198,38,37,131,202,170,16,30,32,231,170,208,218,79,54,130,220,27,102,176,44,75,120,12,209,57,197,199,167,65,103,26,210,182,176,207,60,232,28,80,92,249,114,20,208,198,218,26,13,186,51,250,207,103,210,53,113,37,135,58,123,2,134,235,4,13,202,2,66,119,156,71,240,246,197,203,252,30,222,104,255,26,93,125,27,172,200,70,231,111,176,84,255,160,22,248,80,54,226,31,232,220,207,15,253,119,63,194,78,166,183,241,186,0,144,109,67,83,196,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("346c17cb-c7b3-4b13-89c8-26d13a32c8da"));
		}

		#endregion

	}

	#endregion

}


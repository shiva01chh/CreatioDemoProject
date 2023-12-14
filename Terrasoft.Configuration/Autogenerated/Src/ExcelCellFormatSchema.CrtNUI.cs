namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelCellFormatSchema

	/// <exclude/>
	public class ExcelCellFormatSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelCellFormatSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelCellFormatSchema(ExcelCellFormatSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5521b4a2-bdcb-488d-b088-5f4a850b95ea");
			Name = "ExcelCellFormat";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,93,75,195,48,20,134,175,55,216,127,56,224,205,6,165,237,58,63,167,19,116,155,76,16,21,55,69,16,47,178,238,180,11,230,163,166,9,78,197,255,110,210,78,24,74,173,6,26,154,156,247,125,243,112,56,130,112,204,51,18,35,204,80,41,146,203,68,251,67,41,18,154,26,69,52,149,194,31,175,50,169,244,76,142,87,49,178,86,243,189,213,108,53,27,38,167,34,133,145,140,13,71,161,207,164,226,68,251,87,25,138,123,206,252,105,166,144,44,242,37,162,62,44,212,91,10,83,27,5,99,97,120,31,138,160,33,50,86,218,10,69,16,4,112,148,27,206,137,122,61,94,159,11,29,216,143,65,82,40,1,173,223,255,82,7,27,242,204,204,25,141,139,250,207,248,134,69,110,52,30,138,251,75,195,231,168,202,74,59,33,44,199,206,163,171,158,74,201,96,0,93,175,66,170,149,65,15,162,176,123,107,247,94,233,25,17,141,214,19,213,120,156,35,244,160,77,133,238,76,164,162,111,82,104,194,78,24,77,133,235,221,29,97,6,115,255,134,166,75,189,206,197,152,114,226,112,122,85,209,5,185,7,207,70,106,188,86,152,208,85,31,220,115,101,192,196,118,31,149,245,111,255,142,214,253,55,218,185,208,54,118,167,6,235,133,46,244,178,15,219,97,37,225,84,43,55,63,3,216,173,107,120,248,173,225,51,202,93,211,247,254,134,16,245,42,17,46,164,124,50,153,141,218,175,67,136,54,16,214,207,31,216,255,143,114,180,81,44,202,233,118,71,123,231,214,39,36,73,15,123,85,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5521b4a2-bdcb-488d-b088-5f4a850b95ea"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TimeExcelCellWriterSchema

	/// <exclude/>
	public class TimeExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TimeExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TimeExcelCellWriterSchema(TimeExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7b9f4301-da1a-457b-8c99-61b188d2ca09");
			Name = "TimeExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ee75749b-5184-4f75-a3ec-dd2e096c705e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,193,106,2,49,16,134,207,43,248,14,3,94,244,178,123,87,43,136,218,158,74,133,74,123,78,55,179,154,146,77,150,201,196,42,165,239,222,36,238,110,75,149,6,114,152,159,47,153,47,19,35,106,116,141,40,17,118,72,36,156,173,56,95,89,83,169,189,39,193,202,154,124,115,106,44,241,206,110,78,37,234,225,224,115,56,200,188,83,102,15,207,103,199,88,207,134,131,144,140,8,247,1,134,149,22,206,77,97,167,106,76,252,10,181,126,37,197,72,9,43,138,2,230,206,215,181,160,243,162,173,35,11,24,97,8,91,195,71,194,243,142,46,58,60,11,73,227,223,180,42,161,140,93,110,53,129,41,172,5,95,183,206,162,117,47,185,37,219,32,177,194,96,186,77,55,38,185,216,111,174,204,1,195,33,105,75,40,162,97,215,210,30,195,120,148,68,232,239,190,183,84,11,190,170,239,22,127,163,60,138,94,198,148,141,208,200,139,69,91,183,74,143,200,7,43,163,15,89,198,146,81,254,167,212,49,63,86,241,213,105,144,15,200,75,249,238,195,207,200,46,123,17,218,227,184,39,142,177,156,64,154,72,70,200,158,12,72,172,132,215,220,67,147,124,41,229,56,145,201,254,169,90,139,243,100,22,143,124,93,63,164,205,126,71,33,9,235,27,83,91,233,39,93,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b9f4301-da1a-457b-8c99-61b188d2ca09"));
		}

		#endregion

	}

	#endregion

}


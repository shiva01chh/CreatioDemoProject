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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,193,106,2,49,16,134,207,43,248,14,3,94,244,178,123,87,43,136,218,158,74,133,74,123,78,55,179,154,146,77,150,201,196,42,165,239,222,36,238,110,165,150,6,114,152,159,47,153,47,19,35,106,116,141,40,17,118,72,36,156,173,56,95,89,83,169,189,39,193,202,154,124,115,106,44,241,206,110,78,37,234,225,224,115,56,200,188,83,102,15,207,103,199,88,207,134,131,144,140,8,247,1,134,149,22,206,77,97,167,106,76,252,10,181,126,37,197,72,9,43,138,2,230,206,215,181,160,243,162,173,35,11,24,97,8,91,195,71,194,243,142,46,58,60,11,73,227,223,180,42,161,140,93,254,106,2,83,88,11,190,109,157,69,235,94,114,75,182,65,98,133,193,116,155,110,76,114,177,223,92,153,3,134,67,210,150,80,68,195,174,165,61,134,241,40,137,208,223,125,111,169,22,124,83,223,45,126,71,121,20,189,140,41,27,161,145,23,139,182,110,149,30,145,15,86,70,31,178,140,37,163,252,79,169,99,126,172,226,171,211,32,31,144,151,242,221,135,159,145,93,246,34,180,199,113,79,28,99,57,129,52,145,140,144,61,25,144,88,9,175,185,135,38,249,82,202,113,34,147,253,83,181,22,231,201,44,30,249,186,125,72,155,93,71,33,185,90,223,56,51,120,123,101,2,0,0 };
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


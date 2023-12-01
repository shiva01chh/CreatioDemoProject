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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,177,78,195,48,16,134,231,68,234,59,156,212,165,93,146,189,45,149,80,91,152,16,149,168,96,54,241,165,53,114,236,232,124,46,173,16,239,142,237,38,1,81,196,144,225,126,125,246,255,249,98,68,131,174,21,21,194,14,137,132,179,53,23,43,107,106,181,247,36,88,89,83,108,78,173,37,222,217,205,169,66,61,202,63,70,121,230,157,50,123,120,58,59,198,102,62,202,67,50,38,220,7,24,86,90,56,55,131,157,106,48,241,43,212,250,133,20,35,37,172,44,75,88,56,223,52,130,206,203,110,142,44,96,132,33,124,26,222,19,94,244,116,217,227,89,72,90,255,170,85,5,85,108,249,171,4,102,176,22,124,93,157,69,235,65,114,75,182,69,98,133,193,116,155,110,76,114,177,111,161,204,1,195,33,105,43,40,163,97,95,105,143,97,61,74,34,12,119,223,89,106,4,95,205,55,203,223,81,17,69,47,107,202,198,104,228,197,162,155,59,165,7,228,131,149,209,135,44,99,197,40,255,83,234,153,111,171,248,234,180,200,123,228,91,249,230,195,159,145,125,246,44,180,199,201,64,28,227,56,133,180,145,140,144,61,25,144,88,11,175,121,128,166,197,173,148,147,68,38,251,199,122,45,206,211,121,60,242,121,253,144,46,251,25,133,36,207,191,0,93,137,112,228,92,2,0,0 };
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


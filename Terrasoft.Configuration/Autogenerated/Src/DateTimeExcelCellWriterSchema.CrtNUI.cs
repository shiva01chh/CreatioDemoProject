namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateTimeExcelCellWriterSchema

	/// <exclude/>
	public class DateTimeExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateTimeExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateTimeExcelCellWriterSchema(DateTimeExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2cb26043-42ca-4c84-9e87-fb66c4e44a45");
			Name = "DateTimeExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,205,78,195,48,16,132,207,137,212,119,88,169,23,184,36,119,90,42,161,80,56,33,85,34,130,179,137,183,169,145,99,71,235,117,105,133,120,119,236,252,81,17,129,165,28,118,52,227,249,178,54,162,65,215,138,10,161,68,34,225,236,158,179,194,154,189,170,61,9,86,214,100,219,83,107,137,75,187,61,85,168,23,233,231,34,77,188,83,166,134,231,179,99,108,86,139,52,40,75,194,58,152,161,208,194,185,27,184,23,140,165,106,176,203,20,168,245,43,41,70,234,172,121,158,195,218,249,166,17,116,222,12,243,232,7,140,1,8,159,134,143,46,146,141,137,252,34,210,250,55,173,42,168,98,217,95,93,208,83,204,8,146,248,3,19,239,142,108,139,196,10,3,244,174,187,181,99,140,149,107,101,14,24,66,210,86,144,199,214,177,214,30,195,166,148,68,152,238,126,176,212,8,158,205,183,155,223,82,54,194,246,91,75,150,104,100,79,50,204,3,214,19,242,193,202,200,68,150,177,98,148,255,97,141,158,31,178,105,159,143,200,119,242,221,135,135,146,163,246,34,180,199,171,201,113,140,227,53,116,91,73,8,217,147,233,181,85,84,190,230,156,131,118,41,5,37,156,111,118,140,9,228,75,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2cb26043-42ca-4c84-9e87-fb66c4e44a45"));
		}

		#endregion

	}

	#endregion

}


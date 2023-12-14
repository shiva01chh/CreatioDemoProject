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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,77,107,195,48,12,134,207,45,244,63,8,118,79,46,99,135,117,236,146,181,208,75,7,91,247,113,117,60,53,120,200,86,176,101,218,82,250,223,103,59,233,40,140,81,131,109,94,251,145,94,73,78,89,12,189,210,8,27,244,94,5,222,74,213,176,219,154,46,122,37,134,93,181,216,247,236,101,195,139,189,70,154,77,143,179,233,36,6,227,58,120,61,4,65,59,255,213,79,172,163,69,39,75,246,86,73,245,220,163,251,180,148,254,19,113,227,177,75,201,160,33,21,194,61,148,92,13,18,125,120,35,232,7,195,2,214,117,13,15,33,90,171,252,225,113,212,133,134,180,9,118,133,7,93,2,170,51,95,95,4,244,177,37,163,65,103,163,255,124,38,185,137,51,57,214,57,16,48,94,71,232,80,230,16,242,113,186,128,223,86,78,238,110,225,133,119,235,104,219,235,96,195,20,173,187,194,114,251,141,90,224,93,81,196,63,208,105,152,31,186,175,97,132,89,166,183,188,126,0,87,1,199,65,188,1,0,0 };
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


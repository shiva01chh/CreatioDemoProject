namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastExportToExcelServiceSchema

	/// <exclude/>
	public class IForecastExportToExcelServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastExportToExcelServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastExportToExcelServiceSchema(IForecastExportToExcelServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c9ba928-203d-4631-aa4f-bccc69f69d0a");
			Name = "IForecastExportToExcelService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,77,107,195,48,12,61,175,208,255,32,114,218,96,36,176,235,210,92,70,59,202,14,131,174,236,238,58,74,235,205,177,139,236,52,11,101,255,125,178,211,150,244,99,57,69,207,210,211,123,146,140,168,209,109,133,68,88,34,145,112,182,242,233,139,53,149,90,55,36,188,178,38,157,89,66,41,156,255,124,26,143,246,227,209,93,227,148,89,195,71,231,60,214,156,170,53,202,144,231,210,87,52,72,74,62,159,114,254,99,156,254,108,45,249,165,157,254,72,212,156,206,5,89,150,65,238,154,186,22,212,21,135,120,110,60,82,21,164,85,150,0,99,81,160,173,14,130,96,163,156,183,212,65,73,74,235,210,182,6,74,225,5,120,203,201,204,156,30,121,179,1,241,182,89,105,37,65,157,184,231,71,127,103,170,62,144,118,74,34,23,236,163,190,43,129,17,120,33,20,30,29,8,83,66,75,42,252,198,206,224,60,191,212,65,137,182,82,132,216,146,88,99,76,36,244,13,153,131,31,248,198,46,61,241,103,151,13,242,173,32,230,49,188,164,73,82,41,205,162,251,81,38,197,44,70,189,99,121,54,222,60,139,85,183,73,236,234,139,247,245,41,116,131,11,148,150,74,151,20,239,17,131,93,0,89,94,68,31,161,221,40,185,129,150,71,11,43,60,200,197,242,154,189,247,227,138,220,33,130,36,172,38,201,217,40,23,124,95,124,30,152,100,69,143,115,139,30,97,174,99,113,96,187,89,5,175,120,190,153,55,236,238,103,131,73,192,112,44,143,48,159,154,166,70,18,43,141,249,251,165,215,2,174,237,63,132,123,253,29,143,126,97,60,26,126,127,103,96,197,181,25,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c9ba928-203d-4631-aa4f-bccc69f69d0a"));
		}

		#endregion

	}

	#endregion

}


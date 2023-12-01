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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,193,110,194,48,12,61,15,169,255,96,245,180,73,168,149,118,93,215,11,2,132,118,64,98,211,238,33,117,33,91,154,32,39,165,171,166,253,251,156,20,16,12,214,83,253,98,63,191,103,219,136,6,221,78,72,132,55,36,18,206,214,62,155,88,83,171,77,75,194,43,107,178,153,37,148,194,249,247,199,100,244,157,140,238,90,167,204,6,94,123,231,177,225,84,173,81,134,60,151,205,209,32,41,249,116,202,249,143,113,250,181,179,228,223,236,244,75,162,230,116,46,200,243,28,10,215,54,141,160,190,60,196,11,227,145,234,32,173,182,4,24,139,2,109,125,16,4,91,229,188,165,30,42,82,90,87,182,51,80,9,47,192,91,78,102,230,236,200,155,159,17,239,218,181,86,18,212,137,123,113,244,119,161,234,21,105,175,36,114,193,119,212,119,37,48,2,19,66,225,209,129,48,21,116,164,194,111,236,12,206,243,75,19,148,104,43,69,136,45,137,13,198,68,66,223,146,57,248,129,79,236,179,19,127,254,183,65,177,19,196,60,134,151,244,156,214,74,179,232,97,148,105,57,139,209,224,88,94,140,183,200,99,213,109,18,187,254,224,125,189,11,221,226,10,165,165,202,165,229,50,98,176,15,32,203,139,232,24,186,173,146,91,232,120,180,176,198,131,92,172,174,217,7,63,174,44,28,34,72,194,250,57,189,24,229,138,239,139,207,3,211,188,28,112,110,49,32,204,117,44,14,108,55,171,96,142,151,155,121,193,254,126,118,54,9,56,31,203,24,22,83,211,54,72,98,173,177,88,254,245,90,194,181,253,135,112,175,63,201,232,7,146,17,127,191,155,59,116,56,16,3,0,0 };
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


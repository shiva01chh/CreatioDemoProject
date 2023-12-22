namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PdfAsyncReportGenerationControllerSchema

	/// <exclude/>
	public class PdfAsyncReportGenerationControllerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PdfAsyncReportGenerationControllerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PdfAsyncReportGenerationControllerSchema(PdfAsyncReportGenerationControllerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("71fc74a3-8eb1-455a-8bf5-06643861c00c");
			Name = "PdfAsyncReportGenerationController";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,193,106,219,64,16,61,59,144,127,24,212,75,114,136,116,45,118,108,112,93,28,122,104,49,137,123,42,61,108,86,35,123,65,218,221,206,140,12,34,244,223,59,43,41,70,105,27,82,170,147,102,120,243,246,205,155,231,77,131,28,141,69,216,35,145,225,80,73,190,9,190,114,135,150,140,184,224,47,47,158,46,47,102,45,59,127,128,135,142,5,155,252,1,233,228,44,126,14,37,214,249,218,138,59,245,200,197,25,55,165,34,204,183,198,74,32,135,172,8,197,188,35,60,40,28,54,181,97,158,195,174,172,214,220,121,123,143,49,144,220,161,199,225,97,85,33,20,234,26,41,77,233,220,183,53,199,47,40,155,208,68,5,60,186,218,73,119,143,63,90,71,216,160,23,190,154,22,73,28,44,225,141,145,132,202,199,70,121,253,93,31,41,138,2,110,185,109,26,67,221,106,172,85,25,33,39,60,24,176,103,89,16,42,48,73,249,145,130,15,45,195,238,227,246,134,250,45,224,112,94,3,120,112,43,127,38,47,38,236,177,125,172,157,5,155,156,248,7,35,96,14,31,12,227,155,118,205,158,122,195,206,78,239,40,68,36,209,11,204,211,191,160,21,44,7,72,47,201,249,35,146,147,50,168,20,194,106,153,189,250,202,120,250,20,17,81,67,246,93,196,172,72,155,204,226,51,47,132,147,158,223,169,253,44,148,210,48,193,194,114,5,153,137,81,151,238,233,138,88,86,11,176,71,67,140,178,252,186,223,222,188,207,22,227,185,255,87,218,139,126,160,215,229,125,250,147,38,16,252,94,171,226,62,168,67,136,187,252,14,229,246,175,147,171,171,76,3,144,93,47,70,239,209,151,131,253,125,253,115,136,254,139,166,246,166,223,47,133,98,252,146,139,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("71fc74a3-8eb1-455a-8bf5-06643861c00c"));
		}

		#endregion

	}

	#endregion

}


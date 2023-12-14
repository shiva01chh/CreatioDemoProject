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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,193,106,219,64,16,61,59,144,127,24,148,75,114,136,116,13,118,108,112,93,28,122,104,48,137,123,42,61,108,86,35,123,65,218,221,206,140,12,34,228,223,59,43,41,198,105,27,82,170,147,102,120,243,246,205,155,231,77,131,28,141,69,216,34,145,225,80,73,190,10,190,114,187,150,140,184,224,207,207,158,207,207,38,45,59,191,131,199,142,5,155,252,17,233,224,44,126,13,37,214,249,210,138,59,244,200,217,17,119,74,69,152,175,141,149,64,14,89,17,138,185,32,220,41,28,86,181,97,158,194,166,172,150,220,121,251,128,49,144,220,161,199,225,97,85,33,20,234,26,41,77,233,220,247,37,199,123,148,85,104,162,2,158,92,237,164,123,192,159,173,35,108,208,11,95,158,22,73,28,204,225,131,145,132,202,199,70,121,245,67,31,41,138,2,110,185,109,26,67,221,98,172,85,25,33,39,60,24,176,71,89,16,42,48,73,249,158,130,15,45,195,230,243,250,154,250,45,96,119,92,3,120,112,43,127,37,47,78,216,99,251,84,59,11,54,57,241,15,70,192,20,62,25,198,15,237,154,60,247,134,29,157,222,80,136,72,162,23,152,166,127,65,43,88,14,144,94,146,243,123,36,39,101,80,41,132,213,60,123,247,149,241,244,41,34,162,134,108,187,136,89,145,54,153,196,87,94,8,7,61,191,83,251,89,40,165,225,4,11,243,5,100,38,70,93,186,167,43,98,89,205,192,238,13,49,202,252,219,118,125,125,147,205,198,115,255,175,180,55,253,64,239,203,251,242,39,77,32,248,189,86,197,125,80,135,16,119,249,29,202,237,95,39,23,151,153,6,32,187,154,141,222,163,47,7,251,251,250,101,136,254,155,166,246,210,247,11,231,155,234,15,131,3,0,0 };
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


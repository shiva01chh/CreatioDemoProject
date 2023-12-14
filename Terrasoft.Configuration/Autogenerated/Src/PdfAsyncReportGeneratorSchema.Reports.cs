namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PdfAsyncReportGeneratorSchema

	/// <exclude/>
	public class PdfAsyncReportGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PdfAsyncReportGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PdfAsyncReportGeneratorSchema(PdfAsyncReportGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e562fee6-cd50-43d6-8ac4-36911be07fee");
			Name = "PdfAsyncReportGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,77,107,219,64,16,61,59,144,255,48,168,23,25,194,250,30,199,134,196,174,67,14,45,166,73,233,161,148,178,149,70,246,130,188,43,102,71,110,76,232,127,239,172,86,9,150,145,157,166,173,78,218,217,153,247,230,205,199,90,189,65,95,233,12,225,1,137,180,119,5,171,153,179,133,89,213,164,217,56,123,126,246,116,126,54,168,189,177,43,88,152,18,229,114,139,196,72,225,240,254,145,209,122,241,130,73,247,82,205,74,131,150,85,48,142,95,226,247,41,232,168,93,45,116,198,142,12,250,126,143,189,228,212,39,172,28,241,61,210,214,100,1,80,2,222,17,174,66,70,179,82,123,127,9,203,188,184,246,59,155,69,207,91,180,40,161,142,26,215,209,104,4,87,190,222,108,52,237,166,237,89,252,8,189,228,238,65,3,53,65,176,122,142,2,99,129,215,8,203,249,2,10,71,27,205,234,25,102,180,135,243,117,142,133,174,75,190,49,54,151,236,83,222,85,232,138,244,174,47,145,225,5,124,148,30,72,1,19,65,77,134,223,36,190,170,127,148,38,131,44,40,56,38,0,46,225,70,123,236,215,54,120,106,244,189,212,98,97,176,204,67,49,200,108,53,99,188,172,226,65,68,234,220,217,114,7,119,135,20,223,127,58,202,15,140,227,22,25,109,30,193,187,76,210,30,207,84,135,6,6,190,70,72,75,23,69,29,145,147,14,33,204,217,96,208,199,41,197,105,186,25,7,99,167,110,145,175,14,147,157,166,201,23,137,76,134,97,104,6,191,78,103,185,36,87,201,156,202,136,133,154,56,198,140,49,143,46,77,51,141,93,35,25,206,157,52,129,176,152,36,199,74,173,238,93,77,25,118,118,33,25,77,99,121,91,92,112,178,19,100,114,60,177,63,170,187,77,61,168,48,153,254,113,188,154,187,236,113,252,87,122,30,52,173,144,255,183,158,30,212,55,233,145,161,121,101,238,62,32,175,93,254,207,237,92,202,198,107,194,104,78,63,123,36,201,207,10,158,112,92,192,129,119,231,41,26,30,47,83,12,155,107,214,112,10,31,234,55,208,65,214,33,111,151,135,144,107,178,189,123,171,218,63,76,15,105,186,72,39,214,39,90,187,198,198,22,190,223,73,157,0,132,73,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e562fee6-cd50-43d6-8ac4-36911be07fee"));
		}

		#endregion

	}

	#endregion

}


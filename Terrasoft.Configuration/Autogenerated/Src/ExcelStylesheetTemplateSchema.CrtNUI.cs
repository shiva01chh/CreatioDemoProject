namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelStylesheetTemplateSchema

	/// <exclude/>
	public class ExcelStylesheetTemplateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelStylesheetTemplateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelStylesheetTemplateSchema(ExcelStylesheetTemplateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("962cb08b-b35b-4310-92bb-ae488ec1da3f");
			Name = "ExcelStylesheetTemplate";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,63,107,195,48,16,197,103,27,252,29,14,178,203,123,27,186,184,41,221,58,196,148,174,87,229,226,8,244,15,221,9,18,66,190,123,108,57,73,189,180,84,131,208,19,239,253,142,123,30,29,113,68,77,208,83,74,200,97,47,170,11,126,111,134,156,80,76,240,106,115,140,33,73,31,54,71,77,182,169,207,77,221,212,85,102,227,7,120,13,58,59,242,242,22,146,67,81,31,145,252,151,179,106,27,19,225,142,15,68,242,92,220,171,68,195,136,130,206,34,243,19,20,210,86,78,150,138,167,39,23,45,10,21,107,219,182,176,230,236,28,166,211,203,77,151,24,200,1,5,116,240,130,198,51,208,196,0,126,64,64,110,20,117,135,180,11,74,204,223,214,104,208,5,244,235,248,106,220,173,186,123,127,12,203,231,25,134,113,41,224,233,186,44,220,29,89,59,183,0,159,104,51,45,244,63,34,239,99,93,148,254,200,92,230,26,201,239,230,38,39,89,254,154,122,58,87,195,238,152,174,197,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("962cb08b-b35b-4310-92bb-ae488ec1da3f"));
		}

		#endregion

	}

	#endregion

}


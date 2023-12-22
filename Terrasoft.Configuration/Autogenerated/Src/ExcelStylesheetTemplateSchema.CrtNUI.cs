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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,63,107,195,48,16,197,103,27,252,29,14,186,203,123,91,186,184,41,221,58,196,148,174,87,229,226,8,244,15,221,9,18,66,190,123,109,57,105,181,180,84,131,208,19,239,253,142,123,30,29,113,68,77,48,82,74,200,97,47,106,8,126,111,166,156,80,76,240,106,115,140,33,201,24,54,71,77,182,107,207,93,219,181,77,102,227,39,120,14,58,59,242,242,18,146,67,81,111,145,252,135,179,106,27,19,225,142,15,68,242,80,220,119,137,166,25,5,131,69,230,123,40,164,173,156,44,21,207,72,46,90,20,42,214,190,239,225,145,179,115,152,78,79,87,93,98,32,7,20,208,193,11,26,207,64,11,3,248,27,2,114,165,168,27,164,175,40,49,127,90,163,65,23,208,175,227,155,121,183,230,230,253,49,212,207,51,76,243,82,192,203,117,169,220,3,89,187,182,0,239,104,51,85,250,31,145,215,185,46,74,127,100,46,107,141,228,119,107,147,139,44,127,93,91,159,47,73,235,61,90,205,1,0,0 };
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


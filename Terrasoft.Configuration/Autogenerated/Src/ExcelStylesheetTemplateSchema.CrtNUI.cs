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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,63,107,195,48,16,197,103,27,252,29,14,186,203,123,91,186,184,41,221,58,196,148,174,87,229,226,8,244,15,221,9,18,66,190,123,101,57,105,189,180,84,131,208,19,239,253,142,123,30,29,113,68,77,48,82,74,200,97,47,106,8,126,111,166,156,80,76,240,106,115,140,33,201,24,54,71,77,182,107,207,93,219,181,77,102,227,39,120,14,58,59,242,242,18,146,67,81,111,145,252,135,179,106,27,19,225,142,15,68,242,80,221,119,137,166,130,130,193,34,243,61,84,210,86,78,150,170,103,36,23,45,10,85,107,223,247,240,200,217,57,76,167,167,171,174,49,144,3,10,232,224,5,141,103,160,153,1,252,13,1,185,82,212,13,210,175,40,49,127,90,163,65,87,208,175,227,155,178,91,115,243,254,24,214,207,51,76,101,41,224,249,186,172,220,3,89,187,180,0,239,104,51,173,244,63,34,175,165,46,74,127,100,46,75,141,228,119,75,147,179,172,127,93,91,206,23,196,249,238,70,196,1,0,0 };
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


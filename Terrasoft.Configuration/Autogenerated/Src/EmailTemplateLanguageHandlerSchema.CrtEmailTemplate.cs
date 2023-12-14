namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTemplateLanguageHandlerSchema

	/// <exclude/>
	public class EmailTemplateLanguageHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTemplateLanguageHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTemplateLanguageHandlerSchema(EmailTemplateLanguageHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ce5d036c-9766-420e-a3b2-131f211f241e");
			Name = "EmailTemplateLanguageHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("91d5b8ed-2389-4812-9e17-f329888285e6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,83,219,74,195,64,16,125,110,161,255,48,232,139,130,54,239,90,11,82,5,5,133,82,243,3,211,100,154,46,110,118,227,204,110,161,20,255,221,220,54,54,85,188,32,152,167,157,217,153,51,103,206,217,24,204,73,10,76,8,98,98,70,177,43,55,158,89,179,82,153,103,116,202,154,209,112,55,26,142,134,131,99,166,172,12,97,166,81,228,2,110,115,84,58,166,188,208,232,232,1,77,230,49,163,59,52,169,38,174,235,163,40,130,137,248,60,71,222,78,219,248,218,0,46,197,49,38,14,232,188,66,0,215,66,128,110,49,128,41,33,181,33,30,7,144,232,0,101,194,84,134,207,50,189,33,81,153,161,20,80,0,33,89,163,50,96,87,37,128,20,214,136,90,42,173,220,118,60,137,66,125,232,119,219,130,10,100,204,193,148,219,95,29,197,11,122,241,36,238,104,26,151,55,13,68,157,40,123,187,218,175,186,197,235,94,115,21,31,246,22,126,169,85,242,190,127,82,233,248,165,140,147,192,235,12,218,25,21,78,227,70,103,199,156,109,65,236,20,149,158,204,235,17,205,253,161,252,117,226,201,39,9,137,216,90,219,143,226,6,142,191,36,245,14,11,187,10,101,144,145,187,172,15,210,30,94,91,206,100,210,134,118,127,135,71,114,107,155,254,100,129,134,132,116,254,124,190,70,157,217,183,136,131,191,139,206,215,206,151,240,164,156,103,35,211,69,240,46,36,246,100,217,40,118,30,117,216,187,37,115,18,4,9,164,78,91,21,26,132,80,197,65,53,227,181,62,221,87,229,127,23,221,175,14,255,222,131,197,148,248,143,234,116,15,251,27,121,206,224,62,238,205,133,62,141,74,155,79,159,75,35,87,63,89,230,170,239,13,45,95,226,136,197,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ce5d036c-9766-420e-a3b2-131f211f241e"));
		}

		#endregion

	}

	#endregion

}


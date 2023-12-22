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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,83,219,74,195,64,16,125,182,208,127,24,244,69,161,54,239,90,11,82,5,5,5,169,249,129,105,50,77,23,55,187,113,102,87,40,226,191,155,219,198,164,74,85,4,243,180,51,59,115,230,204,57,27,131,57,73,129,9,65,76,204,40,118,237,166,11,107,214,42,243,140,78,89,51,30,189,142,71,227,209,193,17,83,86,134,176,208,40,114,6,215,57,42,29,83,94,104,116,116,135,38,243,152,209,13,154,84,19,215,245,81,20,193,76,124,158,35,111,231,109,124,105,0,87,226,24,19,7,116,90,33,128,107,33,64,183,24,192,148,144,122,33,158,6,144,104,7,101,198,84,134,79,50,191,34,81,153,161,20,80,0,33,217,160,50,96,215,37,128,20,214,136,90,41,173,220,118,58,139,66,125,232,119,219,130,10,100,204,193,148,219,95,28,198,75,122,246,36,238,112,30,151,55,13,68,157,40,123,187,218,125,221,226,245,160,185,138,119,123,11,191,210,42,249,216,63,169,116,220,43,227,44,240,154,64,59,163,194,105,220,232,236,120,96,91,16,59,69,165,39,15,245,136,230,126,87,254,58,241,232,147,132,68,108,173,237,103,113,3,199,95,146,250,128,133,215,10,229,32,35,119,94,31,164,61,188,181,156,201,164,13,237,225,14,247,228,54,54,253,201,2,13,9,233,252,249,122,141,58,211,183,136,131,191,203,206,215,206,151,240,164,156,103,35,243,101,240,46,36,122,178,188,40,118,30,117,216,187,37,115,28,4,9,164,78,90,21,26,132,80,197,65,53,227,181,62,233,171,242,191,139,246,171,195,191,119,103,49,37,254,163,58,221,195,254,70,158,9,220,198,131,185,48,164,81,105,243,229,115,105,228,26,38,203,92,255,123,7,13,108,93,174,205,4,0,0 };
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


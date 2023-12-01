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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,83,219,74,195,64,16,125,110,161,255,48,232,139,130,54,239,90,11,162,130,130,66,169,249,129,105,50,141,139,155,221,56,179,43,20,241,223,221,92,54,54,85,188,32,152,167,157,217,153,51,103,206,217,24,44,73,42,204,8,82,98,70,177,107,55,189,176,102,173,10,207,232,148,53,147,241,203,100,60,25,143,246,153,138,16,194,133,70,145,19,184,42,81,233,148,202,74,163,163,91,52,133,199,130,174,209,228,154,184,169,79,146,4,102,226,203,18,121,51,239,226,115,3,184,18,199,152,57,160,227,26,1,92,7,1,186,195,0,166,140,212,51,241,52,130,36,59,40,51,166,16,62,202,252,146,68,21,134,114,64,1,132,236,1,149,1,187,14,0,82,89,35,106,165,180,114,155,233,44,137,245,177,223,109,42,170,144,177,4,19,182,63,219,75,151,244,228,73,220,222,60,13,55,45,68,147,8,189,125,237,87,221,226,245,160,185,142,119,123,43,191,210,42,123,223,63,171,117,252,82,198,89,228,117,4,221,140,26,167,117,163,183,99,193,182,34,118,138,130,39,139,102,68,123,191,43,127,147,184,247,89,70,34,182,209,246,163,184,145,227,47,73,189,195,194,75,141,50,42,200,157,54,7,233,14,175,29,103,50,121,75,123,184,195,29,185,7,155,255,100,129,150,132,244,254,124,190,70,147,217,182,136,163,191,203,222,215,222,151,248,164,156,103,35,243,101,244,46,38,182,100,121,86,236,60,234,184,119,71,230,32,10,18,73,29,118,42,180,8,177,138,163,106,198,107,125,184,173,202,255,46,186,93,29,255,189,91,139,57,241,31,213,233,31,246,55,242,28,193,77,58,152,11,67,26,181,54,159,62,151,86,174,97,50,228,194,247,6,244,187,111,229,196,4,0,0 };
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


﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTemplateCommLangHandlerSchema

	/// <exclude/>
	public class EmailTemplateCommLangHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTemplateCommLangHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTemplateCommLangHandlerSchema(EmailTemplateCommLangHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1e74a254-fcca-4fb6-be7b-59789815c512");
			Name = "EmailTemplateCommLangHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("91d5b8ed-2389-4812-9e17-f329888285e6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,86,93,79,219,48,20,125,46,18,255,225,146,73,40,149,88,242,62,218,72,163,43,172,18,176,73,133,189,187,201,109,235,45,177,35,219,129,117,136,255,190,235,56,33,31,180,165,15,104,90,31,218,196,190,62,247,220,115,63,92,193,50,212,57,139,17,238,80,41,166,229,210,4,19,41,150,124,85,40,102,184,20,112,124,244,116,124,52,40,52,23,43,152,111,180,193,236,252,229,189,125,70,225,174,245,96,42,12,55,28,53,25,144,201,7,133,43,11,60,73,153,214,159,96,154,49,158,222,97,150,167,204,224,68,102,217,53,19,171,175,76,36,41,170,210,62,12,67,24,233,34,203,152,218,68,213,251,103,1,108,161,141,98,177,1,252,104,17,192,84,16,16,19,70,33,120,236,232,167,132,86,176,21,130,194,24,249,3,170,160,134,12,91,152,121,177,72,121,220,96,198,150,219,94,106,208,99,126,93,249,169,182,71,87,5,79,206,192,126,91,252,167,50,146,38,116,41,200,81,17,27,169,72,129,239,74,26,140,13,38,206,168,31,111,185,48,19,164,32,75,249,31,4,129,143,192,233,60,19,148,53,185,36,91,164,160,21,46,199,222,62,194,30,132,81,240,130,31,246,29,140,114,166,88,6,130,234,97,236,197,76,227,44,241,162,9,253,90,225,164,74,128,39,72,105,92,114,82,112,20,150,198,219,207,22,26,21,197,39,40,34,10,213,139,238,233,157,114,82,47,116,14,231,117,228,123,165,246,173,138,224,56,157,193,125,7,31,186,238,134,96,139,117,48,232,25,141,123,102,231,165,81,89,150,155,121,188,198,140,149,240,213,227,184,231,35,104,27,222,48,65,89,86,193,37,23,201,172,202,194,197,230,150,66,247,61,43,151,55,116,224,246,217,157,35,188,6,60,152,40,164,8,221,142,127,223,35,207,52,216,115,125,132,224,18,77,188,190,84,50,251,114,225,59,29,156,151,231,255,166,98,176,36,234,69,21,225,127,93,33,149,210,142,197,123,214,72,39,141,14,190,147,165,42,3,31,80,36,174,183,187,141,78,173,157,163,178,179,239,176,54,47,27,206,185,217,161,124,35,72,105,219,226,231,162,90,161,113,204,115,197,31,236,56,212,213,194,190,90,233,103,224,45,215,61,233,122,175,135,17,217,37,217,13,154,181,76,14,213,107,141,241,47,224,186,153,254,143,220,172,65,231,24,219,81,149,52,227,31,127,115,109,14,173,230,26,205,206,192,105,247,118,57,116,12,214,142,203,49,186,253,70,58,20,170,246,125,45,89,66,93,25,185,95,88,74,5,216,33,167,95,227,40,52,133,18,58,154,181,36,114,82,140,194,122,175,155,219,133,148,41,204,116,221,105,63,104,132,36,110,2,55,170,184,139,13,154,24,207,96,118,215,97,9,93,210,117,207,241,37,248,221,29,24,143,65,20,105,90,91,12,250,219,112,133,166,211,251,115,186,53,209,175,198,236,115,107,146,55,17,142,123,238,3,194,168,143,251,237,48,154,8,42,60,167,73,131,116,226,216,129,227,118,122,10,39,116,113,211,95,156,96,166,111,105,253,155,154,102,57,13,242,218,190,116,180,201,49,153,200,180,200,4,137,87,224,200,157,136,124,111,94,44,126,146,200,222,112,248,46,112,23,50,217,16,214,155,221,77,32,189,66,1,109,53,44,43,72,35,83,241,218,254,105,235,154,236,107,149,186,112,166,91,64,119,214,213,3,87,166,96,233,171,66,217,145,222,170,28,170,124,216,27,108,139,85,239,254,220,51,94,220,106,119,145,214,218,159,191,45,230,126,63,11,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1e74a254-fcca-4fb6-be7b-59789815c512"));
		}

		#endregion

	}

	#endregion

}


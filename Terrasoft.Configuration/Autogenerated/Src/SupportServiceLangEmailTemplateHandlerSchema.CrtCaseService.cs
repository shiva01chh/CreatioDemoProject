﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SupportServiceLangEmailTemplateHandlerSchema

	/// <exclude/>
	public class SupportServiceLangEmailTemplateHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SupportServiceLangEmailTemplateHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SupportServiceLangEmailTemplateHandlerSchema(SupportServiceLangEmailTemplateHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4c6b9a45-0482-4042-8c7a-9872af895143");
			Name = "SupportServiceLangEmailTemplateHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("91d5b8ed-2389-4812-9e17-f329888285e6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,86,223,79,219,48,16,126,238,36,254,135,91,144,80,145,170,244,157,210,78,91,7,172,18,176,73,129,189,27,231,210,90,74,156,200,118,216,50,196,255,190,179,157,180,113,40,172,123,218,120,40,242,249,126,126,247,221,57,146,21,168,43,198,17,238,80,41,166,203,204,196,203,82,102,98,93,43,102,68,41,143,222,61,29,189,27,213,90,200,53,36,141,54,88,204,182,231,190,137,194,215,228,241,133,52,194,8,212,179,129,163,4,141,161,147,134,57,56,189,32,110,76,58,157,2,25,146,233,177,194,53,93,64,82,87,85,169,76,130,234,81,112,188,102,114,125,81,48,145,223,97,81,229,204,224,23,38,211,28,149,51,153,78,167,112,174,235,162,96,170,89,180,103,107,80,179,53,130,70,166,248,6,54,94,31,178,82,145,200,249,4,237,67,128,118,121,146,216,231,17,119,46,167,61,159,85,253,144,11,14,60,103,90,31,152,27,156,65,32,94,150,69,97,117,183,169,143,158,92,250,219,146,9,25,109,84,205,77,169,244,25,124,115,17,189,198,176,66,39,88,73,194,155,229,226,23,130,196,31,32,200,152,73,42,171,204,72,23,17,184,194,108,30,29,150,107,4,211,69,188,141,52,29,134,58,175,152,98,5,72,162,209,60,226,76,227,42,141,22,75,250,15,10,121,169,82,10,158,34,245,63,19,168,226,243,169,211,222,111,92,19,248,84,167,68,110,219,31,45,238,233,12,124,43,8,140,91,204,15,171,96,124,85,139,20,124,110,19,184,15,194,64,24,245,212,58,31,157,193,3,41,143,59,139,129,10,216,121,24,61,255,135,240,91,156,77,19,45,220,188,53,255,10,109,31,29,124,50,127,131,119,103,241,22,222,199,40,83,63,19,225,128,220,160,217,148,169,157,13,37,30,41,153,55,186,115,133,6,242,110,7,136,45,57,33,83,101,1,182,160,135,242,39,60,52,195,217,119,251,65,72,238,44,192,134,165,137,244,155,234,192,246,232,0,63,135,93,180,72,130,40,175,7,129,71,150,215,248,178,167,10,77,173,164,94,92,191,172,136,148,187,91,215,69,143,12,184,105,32,16,236,210,169,165,224,206,125,103,190,74,199,20,209,102,178,39,219,182,21,35,145,65,171,21,175,244,109,157,231,95,213,69,81,153,102,188,207,166,51,26,249,92,92,248,216,169,207,156,252,217,253,122,210,36,124,131,5,235,154,144,52,146,119,47,64,123,51,247,174,66,78,197,125,227,27,38,169,12,21,95,210,222,89,181,131,247,169,185,165,6,140,163,155,151,126,163,211,89,47,126,75,90,122,143,94,77,33,94,42,36,20,189,254,56,76,164,245,213,22,234,125,197,151,104,248,230,146,184,245,249,211,56,74,136,190,168,28,48,31,83,34,178,214,209,100,47,210,190,206,15,157,19,106,215,93,83,97,186,44,243,186,144,223,45,21,206,45,144,11,42,138,156,80,197,187,6,70,173,241,217,16,234,131,71,232,79,207,11,21,175,26,168,74,65,28,181,132,205,195,23,213,242,226,192,145,48,237,238,176,143,134,43,28,58,73,200,227,55,22,89,103,112,93,50,130,246,133,27,109,236,151,197,223,140,141,43,9,3,47,195,73,242,251,176,124,164,207,28,178,243,19,229,215,159,127,107,118,101,77,96,117,23,36,8,97,190,221,116,188,62,116,68,198,240,107,201,146,193,49,96,192,190,9,12,158,20,191,97,136,95,126,84,29,17,90,138,186,44,243,45,101,40,198,91,11,97,15,63,103,219,69,208,243,242,126,14,41,102,172,206,141,131,225,20,78,78,96,165,187,250,41,103,145,142,251,208,236,76,39,67,88,134,91,99,167,218,223,26,237,101,82,115,78,83,64,109,163,12,36,237,35,248,176,147,197,109,99,250,129,135,61,56,112,84,188,52,20,146,172,247,247,27,25,211,30,140,78,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c6b9a45-0482-4042-8c7a-9872af895143"));
		}

		#endregion

	}

	#endregion

}


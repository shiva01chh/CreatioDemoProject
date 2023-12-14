﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DefaultMessageLangEmailTemplateHandlerSchema

	/// <exclude/>
	public class DefaultMessageLangEmailTemplateHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DefaultMessageLangEmailTemplateHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DefaultMessageLangEmailTemplateHandlerSchema(DefaultMessageLangEmailTemplateHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("695d3b1f-a8b6-4808-a4dc-7ae18b27f0ce");
			Name = "DefaultMessageLangEmailTemplateHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("91d5b8ed-2389-4812-9e17-f329888285e6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,85,77,111,219,48,12,61,187,64,255,3,231,1,69,2,4,246,61,105,188,67,22,116,1,90,96,64,219,221,85,139,78,5,216,146,161,143,14,89,209,255,62,74,178,219,216,77,138,108,187,44,7,7,162,249,200,199,71,82,150,172,65,211,178,18,225,14,181,102,70,85,54,91,41,89,137,173,211,204,10,37,207,207,158,207,207,18,103,132,220,194,237,206,88,108,22,175,231,125,136,198,99,246,108,45,173,176,2,205,98,20,232,22,173,165,147,129,37,4,191,65,222,140,124,122,7,2,18,244,179,198,45,189,128,85,205,140,153,195,87,172,152,171,237,13,26,195,182,120,205,228,118,221,48,81,223,97,211,214,204,226,55,38,121,141,58,32,243,60,135,75,227,154,134,233,93,209,157,59,56,212,4,116,20,0,12,50,93,62,194,99,196,101,61,44,223,195,181,238,161,22,37,148,158,192,137,249,97,14,3,243,74,53,141,247,125,165,151,60,7,138,111,213,41,105,44,147,150,42,252,174,149,197,210,34,143,30,173,22,79,20,1,74,239,1,198,106,175,228,123,22,190,152,149,226,72,170,166,135,223,166,139,46,37,74,30,179,30,160,160,93,105,149,246,44,66,209,209,99,44,100,48,108,36,117,151,213,226,23,130,196,159,32,2,127,26,40,85,145,47,18,95,141,213,242,0,149,67,114,165,144,23,217,107,166,124,156,234,178,101,154,53,32,105,104,151,105,201,12,110,120,90,172,232,31,52,150,74,115,74,206,145,166,173,18,212,193,203,60,120,31,6,59,131,154,234,148,164,47,149,156,22,247,116,246,202,118,134,1,184,107,251,105,21,76,174,156,224,16,185,205,224,126,144,6,134,89,167,62,120,50,135,7,114,158,244,136,145,11,248,237,75,94,254,67,249,189,206,118,151,22,97,187,119,255,166,118,241,247,114,199,244,16,217,252,137,224,61,226,35,193,143,109,200,13,218,71,197,79,89,14,162,167,119,208,42,33,45,84,74,143,175,27,90,225,83,245,182,93,225,126,228,131,18,208,91,64,156,56,244,61,224,90,49,78,205,30,135,49,214,223,194,239,34,104,180,78,75,83,244,215,199,94,186,80,18,14,162,16,190,7,236,53,83,61,209,39,129,112,16,182,35,246,46,110,202,91,89,51,216,220,13,8,194,144,111,215,154,36,192,120,156,142,158,83,55,37,27,78,183,222,240,227,146,93,161,253,193,106,135,147,225,104,204,62,184,58,103,33,79,210,229,8,60,167,211,69,48,138,10,38,71,115,127,90,194,0,3,23,23,176,49,125,81,196,66,240,201,126,189,199,2,205,198,149,247,165,39,81,218,163,192,200,241,37,60,59,215,91,87,150,244,154,250,68,236,164,171,107,248,242,102,203,186,78,236,147,26,139,62,15,61,203,214,77,107,119,139,227,187,17,173,67,35,217,252,239,55,113,64,143,46,100,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("695d3b1f-a8b6-4808-a4dc-7ae18b27f0ce"));
		}

		#endregion

	}

	#endregion

}


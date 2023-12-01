namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTemplateUserTaskContactLanguageRuleSchema

	/// <exclude/>
	public class EmailTemplateUserTaskContactLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTemplateUserTaskContactLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTemplateUserTaskContactLanguageRuleSchema(EmailTemplateUserTaskContactLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("93d56a0b-3d90-4502-a157-7f5bc05c865d");
			Name = "EmailTemplateUserTaskContactLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,75,107,219,64,16,62,43,144,255,48,85,47,54,24,233,110,199,134,34,76,48,52,109,154,184,189,111,164,145,188,84,218,85,103,119,83,68,200,127,239,172,94,181,212,54,184,62,24,102,244,205,124,15,141,173,68,133,166,22,41,194,17,137,132,209,185,141,18,173,114,89,56,18,86,106,117,125,245,114,125,21,56,35,85,1,143,141,177,88,109,198,58,209,132,211,42,218,43,43,173,68,195,109,126,240,158,176,224,29,144,148,194,152,53,35,148,21,169,253,40,84,225,68,129,15,174,196,22,22,199,49,220,24,87,85,130,154,93,95,183,35,43,176,39,97,161,38,253,44,51,52,80,246,147,144,147,174,32,237,214,245,32,131,22,164,2,172,132,44,129,101,214,165,176,8,206,32,129,21,230,59,160,87,214,68,3,93,124,198,87,187,167,82,166,144,122,74,216,251,5,199,126,254,43,143,31,121,250,47,202,97,13,135,169,147,224,165,117,51,186,190,39,93,35,249,52,214,112,223,82,116,207,231,118,219,134,103,242,142,20,166,62,246,104,4,158,11,29,148,122,112,50,98,231,165,127,97,65,80,160,221,248,80,252,11,10,94,123,101,168,178,78,220,84,41,15,27,75,46,181,154,46,209,154,16,114,54,134,227,54,86,40,190,29,157,51,8,17,82,194,124,27,94,154,96,24,239,254,97,179,237,212,130,68,5,138,15,116,27,186,137,195,112,55,79,235,38,110,209,231,25,93,170,98,49,75,111,74,181,236,211,156,129,182,51,216,37,33,223,161,61,233,236,146,124,63,63,89,193,217,254,62,119,62,126,190,222,92,178,233,255,191,252,183,50,150,234,132,36,109,166,83,136,207,195,187,117,50,131,91,28,131,58,100,139,182,213,253,136,30,48,213,148,29,178,33,156,103,65,128,230,7,167,162,240,39,180,127,1,205,99,122,98,65,95,28,82,51,75,56,58,7,220,9,197,235,105,5,97,255,106,194,229,102,220,57,248,79,116,233,42,245,137,47,129,41,152,40,250,144,101,93,111,17,14,10,163,67,22,46,35,143,233,230,59,146,33,169,190,234,166,217,87,87,207,132,173,230,246,186,77,50,135,197,116,205,59,54,234,202,114,176,31,16,90,71,106,202,229,89,142,77,141,189,208,111,162,116,120,227,51,220,45,254,180,213,51,189,182,223,253,54,143,141,246,85,109,155,55,142,171,235,78,155,220,227,207,47,40,53,73,149,217,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("93d56a0b-3d90-4502-a157-7f5bc05c865d"));
		}

		#endregion

	}

	#endregion

}


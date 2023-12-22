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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,75,107,219,64,16,62,43,144,255,48,85,47,54,24,233,110,199,134,34,76,48,52,109,154,184,189,111,164,145,188,84,218,85,103,119,83,68,200,127,239,172,30,174,164,182,193,245,193,48,163,111,230,123,104,108,37,42,52,181,72,17,142,72,36,140,206,109,148,104,149,203,194,145,176,82,171,235,171,151,235,171,192,25,169,10,120,108,140,197,106,115,174,19,77,56,173,162,189,178,210,74,52,220,230,7,239,9,11,222,1,73,41,140,89,51,66,89,145,218,143,66,21,78,20,248,224,74,108,97,113,28,195,141,113,85,37,168,217,245,117,59,178,2,123,18,22,106,210,207,50,67,3,101,63,9,57,233,10,210,110,93,15,50,104,65,42,192,74,200,18,88,102,93,10,139,224,12,18,88,97,190,3,122,101,77,52,208,197,35,190,218,61,149,50,133,212,83,194,222,47,56,246,243,95,121,252,200,211,127,81,14,107,56,76,157,4,47,173,155,179,235,123,210,53,146,79,99,13,247,45,69,247,124,110,183,109,120,38,239,72,97,234,99,143,206,192,177,208,65,169,7,39,103,236,188,244,47,44,8,10,180,27,31,138,127,65,193,107,175,12,85,214,137,155,42,229,97,99,201,165,86,211,37,90,19,66,206,198,112,220,198,10,197,183,163,115,6,33,66,74,152,111,195,75,19,12,227,221,63,108,182,157,90,144,168,64,241,129,110,67,55,113,24,238,230,105,221,196,45,122,156,209,165,42,22,179,244,166,84,203,62,205,25,104,59,131,93,18,242,29,218,147,206,46,201,247,243,147,21,156,237,239,115,231,227,231,235,205,37,155,254,255,203,127,43,99,169,78,72,210,102,58,133,120,28,222,173,147,25,220,226,57,168,67,182,104,91,221,143,232,1,83,77,217,33,27,194,121,22,4,104,126,112,42,10,127,66,251,23,208,60,166,39,22,244,197,33,53,179,132,163,49,224,78,40,94,79,43,8,251,87,19,46,55,231,157,131,255,68,151,174,82,159,248,18,152,130,137,162,15,89,214,245,22,225,160,48,58,100,225,50,242,152,110,190,35,25,146,234,171,110,154,125,117,245,76,216,106,110,175,219,36,115,88,76,215,188,99,163,174,44,7,251,1,161,117,164,166,92,158,229,216,212,216,11,253,38,74,135,55,62,195,221,226,79,91,61,211,107,251,221,111,243,216,104,95,213,182,121,227,184,186,238,180,201,189,241,231,23,175,72,144,189,226,5,0,0 };
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


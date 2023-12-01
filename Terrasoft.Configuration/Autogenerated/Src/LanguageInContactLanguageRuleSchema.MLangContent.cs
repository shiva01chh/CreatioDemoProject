namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LanguageInContactLanguageRuleSchema

	/// <exclude/>
	public class LanguageInContactLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LanguageInContactLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LanguageInContactLanguageRuleSchema(LanguageInContactLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2c80707-56d1-485c-9153-61f3c4d5fd6c");
			Name = "LanguageInContactLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,203,110,219,48,16,60,59,64,254,97,161,94,36,192,144,238,142,173,67,92,55,16,144,2,70,220,180,103,134,92,57,4,36,210,225,195,173,97,244,223,187,34,101,71,22,220,32,130,14,218,89,206,112,56,75,41,214,162,221,49,142,240,3,141,97,86,215,46,95,106,85,203,173,55,204,73,173,110,111,142,183,55,19,111,165,218,194,230,96,29,182,119,231,122,72,105,91,173,174,119,12,254,15,207,191,222,83,139,154,69,81,192,220,250,182,101,230,80,246,245,178,97,214,78,97,103,244,94,10,180,208,48,181,245,108,139,83,168,141,110,129,107,229,24,119,249,137,93,12,232,59,255,210,72,14,188,83,128,199,158,87,169,101,164,156,128,39,223,32,204,224,158,89,28,66,196,63,6,83,147,47,6,183,148,0,16,207,58,227,185,211,198,206,96,29,196,227,138,177,239,104,220,32,115,100,88,18,139,41,74,86,215,180,8,17,184,193,122,145,124,232,39,41,202,252,44,92,140,149,231,59,102,88,11,138,102,182,72,188,69,67,10,10,121,55,166,164,124,166,186,75,165,7,242,121,17,86,7,114,31,200,135,91,167,207,23,130,112,169,159,117,50,147,25,188,80,90,233,168,5,71,248,219,39,134,74,196,208,46,19,252,142,238,85,139,207,132,183,30,143,27,168,82,78,214,146,78,55,30,252,103,98,226,100,120,69,2,238,240,132,92,27,81,137,164,236,79,15,24,240,193,14,23,161,5,41,169,94,209,72,39,52,135,98,24,165,222,211,77,38,34,60,120,41,224,1,207,81,86,34,13,80,111,179,18,20,79,200,110,207,204,9,60,173,221,96,67,17,194,2,20,254,134,88,140,166,144,209,127,210,248,86,165,9,79,166,240,126,119,68,146,229,223,40,141,52,233,207,210,117,121,18,167,52,201,127,145,105,236,57,97,109,101,87,111,158,53,105,84,203,215,221,33,209,161,73,223,109,102,192,108,111,226,46,200,92,53,155,175,254,32,247,14,55,244,55,55,24,35,77,233,194,11,26,207,162,132,248,149,83,30,113,167,159,172,241,56,239,2,41,211,11,247,83,208,222,197,240,154,51,156,197,141,13,58,111,212,0,15,240,245,43,70,40,189,244,252,3,54,68,194,136,201,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2c80707-56d1-485c-9153-61f3c4d5fd6c"));
		}

		#endregion

	}

	#endregion

}


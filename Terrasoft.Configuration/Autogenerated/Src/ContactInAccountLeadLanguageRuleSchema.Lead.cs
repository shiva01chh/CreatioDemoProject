namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactInAccountLeadLanguageRuleSchema

	/// <exclude/>
	public class ContactInAccountLeadLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactInAccountLeadLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactInAccountLeadLanguageRuleSchema(ContactInAccountLeadLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cfdf212a-4f1d-4503-a3e8-25f804f8d198");
			Name = "ContactInAccountLeadLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("df5a8bee-e0f6-4225-b7c8-127f6fd1b1ca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,147,77,111,26,49,16,134,207,68,202,127,24,109,47,32,33,239,29,8,40,69,81,132,148,180,249,236,221,216,179,96,105,215,166,254,160,90,161,254,247,142,189,187,4,182,74,41,135,149,60,30,63,51,239,59,131,230,21,186,29,23,8,111,104,45,119,166,240,108,105,116,161,54,193,114,175,140,190,190,58,92,95,13,130,83,122,3,175,181,243,88,77,143,231,211,39,22,63,139,179,59,237,149,87,232,40,129,82,190,88,220,16,23,150,37,119,110,2,84,204,115,225,87,250,86,8,19,180,127,64,46,31,184,222,4,190,193,151,80,98,122,147,231,57,204,92,168,42,110,235,121,123,78,239,199,224,183,220,195,206,154,189,146,232,64,52,52,40,172,169,128,55,68,80,26,74,162,66,217,98,193,18,151,117,216,252,132,187,11,235,82,9,16,17,125,177,51,152,192,87,238,240,188,217,193,33,53,252,161,210,104,231,109,16,222,88,18,251,148,248,77,70,95,83,35,202,34,247,164,67,209,43,174,105,42,166,160,36,68,16,22,139,155,236,82,75,89,62,103,71,118,222,135,207,118,220,242,10,52,141,252,38,11,14,45,225,52,138,56,229,108,254,78,231,104,95,27,96,179,60,101,167,199,173,45,151,170,15,223,207,152,112,94,98,20,73,131,9,172,201,179,97,239,10,14,233,50,126,126,183,254,161,150,141,133,231,126,62,162,223,26,249,63,86,126,95,123,78,54,126,76,157,22,132,22,177,80,164,51,173,71,183,43,180,30,221,166,164,120,220,149,127,185,168,244,22,173,242,210,8,200,79,237,49,123,90,123,42,2,247,65,73,184,71,223,121,179,146,195,20,138,229,125,253,130,194,88,185,146,157,232,61,183,128,238,39,220,128,198,95,144,254,43,245,171,216,98,197,159,3,218,186,103,42,59,77,120,228,154,240,118,12,89,28,69,54,154,30,129,157,232,165,41,67,165,191,209,196,137,79,85,216,173,148,77,108,152,61,7,94,70,59,100,59,78,246,100,85,84,218,142,153,117,237,179,21,161,89,100,52,252,166,131,86,77,139,37,181,77,184,215,238,184,47,186,65,88,244,193,234,246,110,17,95,191,213,59,108,59,251,193,203,128,179,232,216,124,248,183,142,17,44,22,201,97,118,87,237,124,61,253,124,103,154,232,121,144,98,167,191,63,89,132,33,207,254,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cfdf212a-4f1d-4503-a3e8-25f804f8d198"));
		}

		#endregion

	}

	#endregion

}


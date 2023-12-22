namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactInLeadLanguageRuleSchema

	/// <exclude/>
	public class ContactInLeadLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactInLeadLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactInLeadLanguageRuleSchema(ContactInLeadLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd37686f-0318-45bd-ba58-4b312c10abb5");
			Name = "ContactInLeadLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("df5a8bee-e0f6-4225-b7c8-127f6fd1b1ca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,219,138,219,48,16,134,175,179,176,239,48,184,55,9,4,249,62,71,118,195,178,4,118,219,238,169,247,138,52,78,4,182,228,142,164,20,19,250,238,29,31,146,77,92,82,234,11,131,70,51,223,252,243,143,172,44,208,151,82,33,188,35,145,244,46,11,98,229,108,102,182,145,100,48,206,222,222,28,110,111,6,209,27,187,133,183,202,7,44,166,167,243,121,9,225,181,184,120,176,193,4,131,158,19,56,229,11,225,150,185,176,202,165,247,19,224,102,65,170,176,182,79,40,245,147,180,219,40,183,248,26,115,108,146,211,52,133,153,143,69,33,169,90,116,231,166,112,12,97,39,3,148,228,246,70,163,7,213,98,192,88,200,25,4,121,71,2,98,148,56,146,210,51,84,25,55,185,81,160,106,218,117,21,48,129,123,233,241,82,216,224,208,136,251,28,197,89,31,40,170,224,136,39,250,222,128,219,140,190,254,118,0,66,25,88,179,225,42,105,217,122,151,113,18,34,40,194,108,158,92,213,146,164,11,113,130,166,125,234,172,148,36,11,176,188,208,121,18,61,18,115,44,170,122,135,201,226,131,207,181,71,93,64,204,210,38,187,41,238,140,184,218,118,248,113,1,131,75,246,168,70,12,38,176,97,151,134,189,43,56,52,151,245,239,119,231,24,90,221,154,118,233,224,51,134,157,211,255,99,222,183,77,144,108,220,231,130,121,253,252,190,50,195,3,102,228,138,254,75,248,151,99,198,238,144,76,208,78,65,122,110,133,219,243,3,102,46,60,70,163,225,17,195,209,142,181,30,54,161,186,99,168,94,81,57,210,107,125,156,115,47,9,208,255,132,57,88,252,5,205,171,175,222,212,14,11,249,18,145,170,158,143,226,60,225,89,90,198,211,24,146,218,253,100,52,61,1,143,115,174,92,30,11,251,149,183,203,124,238,34,238,180,110,99,195,228,37,202,188,118,64,119,59,20,71,189,98,205,44,81,23,181,192,182,101,39,191,227,240,120,109,184,167,111,220,159,178,69,16,134,72,182,187,91,214,213,239,85,137,157,148,31,50,143,56,171,45,90,12,255,22,62,130,229,178,177,84,60,20,101,168,166,215,223,69,27,189,12,114,236,252,251,3,192,104,97,134,185,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd37686f-0318-45bd-ba58-4b312c10abb5"));
		}

		#endregion

	}

	#endregion

}


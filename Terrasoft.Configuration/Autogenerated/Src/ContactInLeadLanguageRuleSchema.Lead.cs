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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,219,106,219,64,16,134,175,29,200,59,12,234,141,13,70,186,247,145,196,132,96,72,218,230,212,251,241,238,200,94,144,118,213,61,184,8,211,119,239,172,36,59,182,138,75,117,33,216,217,153,111,254,249,103,53,150,228,42,20,4,239,100,45,58,147,251,116,101,116,174,182,193,162,87,70,223,222,28,110,111,6,193,41,189,133,183,218,121,42,167,167,243,121,137,165,107,241,244,65,123,229,21,57,78,224,148,47,150,182,204,133,85,129,206,77,128,155,121,20,126,173,159,8,229,19,234,109,192,45,189,134,130,154,228,44,203,96,230,66,89,162,173,23,221,185,41,28,131,223,161,135,202,154,189,146,228,64,180,24,80,26,10,6,65,209,145,192,50,42,61,146,178,51,84,21,54,133,18,32,34,237,186,10,152,192,61,58,186,20,54,56,52,226,62,71,49,218,121,27,132,55,150,39,250,222,128,219,140,190,254,118,0,75,232,89,179,226,42,212,108,189,201,57,137,8,132,165,124,158,92,213,146,100,139,244,4,205,250,212,89,133,22,75,208,188,208,121,18,28,89,230,104,18,113,135,201,226,131,207,209,163,46,144,206,178,38,187,41,238,140,184,218,118,248,113,1,131,75,246,40,34,6,19,216,176,75,195,222,21,28,154,203,248,251,221,57,70,90,182,166,93,58,248,76,126,103,228,255,152,247,109,227,145,141,251,92,48,175,159,223,87,174,120,192,220,154,178,255,18,254,229,152,210,59,178,202,75,35,32,59,183,194,236,249,1,51,23,30,131,146,240,72,254,104,199,90,14,155,80,236,232,235,87,18,198,202,181,60,206,185,71,11,228,126,194,28,52,253,130,230,213,215,111,98,71,37,190,4,178,117,207,199,244,60,225,25,53,227,237,24,146,232,126,50,154,158,128,199,57,87,166,8,165,254,202,219,101,62,119,73,239,164,108,99,195,228,37,96,17,29,144,221,14,211,163,222,116,205,172,52,22,181,192,182,101,39,191,227,240,120,109,184,167,111,220,159,178,69,88,242,193,234,238,110,25,171,223,235,138,58,41,63,176,8,52,139,22,45,134,127,11,31,193,114,217,88,154,62,148,149,175,167,215,223,69,27,189,12,114,44,126,127,0,119,38,38,203,177,4,0,0 };
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


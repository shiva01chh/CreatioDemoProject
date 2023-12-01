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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,219,106,219,64,16,134,175,29,200,59,12,234,141,13,102,117,239,35,137,9,193,144,180,205,169,247,227,221,145,189,32,237,170,123,112,17,166,239,222,209,193,142,173,226,82,93,8,118,118,230,155,127,254,89,131,5,249,18,37,193,59,57,135,222,102,65,172,172,201,244,54,58,12,218,154,219,155,195,237,205,32,122,109,182,240,86,249,64,197,244,116,62,47,113,116,45,46,30,76,208,65,147,231,4,78,249,226,104,203,92,88,229,232,253,4,184,89,64,25,214,230,137,80,61,161,217,70,220,210,107,204,169,73,78,211,20,102,62,22,5,186,106,209,157,155,194,49,132,29,6,40,157,221,107,69,30,100,139,1,109,32,103,16,228,29,9,28,163,196,145,148,158,161,202,184,201,181,4,89,211,174,171,128,9,220,163,167,75,97,131,67,35,238,115,20,107,124,112,81,6,235,120,162,239,13,184,205,232,235,111,7,112,132,129,53,107,174,66,195,214,219,140,147,136,64,58,202,230,201,85,45,73,186,16,39,104,218,167,206,74,116,88,128,225,133,206,147,232,201,49,199,144,172,119,152,44,62,248,92,123,212,5,196,44,109,178,155,226,206,136,171,109,135,31,23,48,184,100,143,106,196,96,2,27,118,105,216,187,130,67,115,89,255,126,119,142,145,81,173,105,151,14,62,83,216,89,245,63,230,125,219,4,100,227,62,23,204,235,231,247,149,105,30,48,115,182,232,191,132,127,57,166,205,142,156,14,202,74,72,207,173,176,123,126,192,204,133,199,168,21,60,82,56,218,177,86,195,38,84,119,12,213,43,73,235,212,90,29,231,220,163,3,242,63,97,14,134,126,65,243,234,171,55,185,163,2,95,34,185,170,231,163,56,79,120,70,195,120,55,134,164,118,63,25,77,79,192,227,156,43,155,199,194,124,229,237,50,159,187,136,59,165,218,216,48,121,137,152,215,14,168,110,135,226,168,87,172,153,37,234,162,22,216,182,236,228,119,28,30,175,13,247,244,141,251,83,182,8,71,33,58,211,221,45,235,234,247,170,164,78,202,15,204,35,205,106,139,22,195,191,133,143,96,185,108,44,21,15,69,25,170,233,245,119,209,70,47,131,28,227,239,15,156,139,255,72,176,4,0,0 };
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


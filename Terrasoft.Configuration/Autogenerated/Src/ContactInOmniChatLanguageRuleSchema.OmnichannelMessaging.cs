namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactInOmniChatLanguageRuleSchema

	/// <exclude/>
	public class ContactInOmniChatLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactInOmniChatLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactInOmniChatLanguageRuleSchema(ContactInOmniChatLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba21deee-aa7e-5f17-8481-2cba8316ae86");
			Name = "ContactInOmniChatLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,147,223,111,155,64,12,199,159,83,169,255,131,197,94,18,9,193,123,154,32,109,209,84,69,90,183,110,109,247,126,5,67,78,130,59,230,187,203,132,162,253,239,51,199,143,2,221,170,70,60,196,198,254,216,254,218,40,81,161,169,69,138,240,136,68,194,232,220,70,7,173,114,89,56,18,86,106,117,125,117,185,190,90,57,35,85,1,15,141,177,88,221,140,246,52,133,240,127,254,232,179,178,210,74,52,28,192,33,113,28,195,206,184,170,18,212,36,189,125,40,133,49,33,212,164,207,50,67,3,165,80,133,19,5,134,144,147,174,224,91,165,228,225,36,44,116,120,238,207,138,212,70,3,44,158,208,106,247,92,202,20,210,22,56,4,30,213,0,248,210,115,127,184,18,97,11,159,132,193,169,139,243,47,190,199,213,7,194,130,135,111,9,198,146,75,173,38,179,133,123,15,239,34,150,99,116,115,16,10,203,253,75,206,18,138,69,213,57,7,33,66,74,152,239,131,55,251,9,226,36,26,193,241,146,188,171,5,137,10,20,175,107,31,56,131,196,44,133,105,187,161,32,121,98,27,210,209,17,237,98,31,237,147,123,65,222,44,189,126,154,1,97,206,223,180,152,213,22,158,89,173,245,226,21,92,224,79,175,24,170,172,19,109,174,224,29,218,147,206,222,35,222,253,114,251,243,229,135,175,183,255,30,173,116,159,126,204,130,100,188,35,108,47,178,1,174,198,127,114,137,52,147,204,51,164,58,33,73,155,233,20,226,169,144,250,204,199,205,137,112,235,100,6,183,56,10,121,204,214,222,245,82,144,213,241,210,157,5,1,154,95,176,7,133,191,193,127,13,205,67,122,194,74,124,119,72,205,66,253,104,26,112,39,20,163,41,132,96,232,61,216,220,140,208,65,168,131,46,93,165,190,242,188,92,131,43,69,31,179,172,243,173,135,155,139,134,54,35,22,98,19,181,177,29,167,171,54,118,221,155,29,134,167,235,236,69,139,225,116,200,14,227,71,47,71,41,24,48,39,182,172,199,166,198,190,175,159,162,116,184,107,147,146,245,235,41,122,38,161,117,164,38,84,239,254,247,189,177,151,159,233,239,47,8,4,109,208,218,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba21deee-aa7e-5f17-8481-2cba8316ae86"));
		}

		#endregion

	}

	#endregion

}


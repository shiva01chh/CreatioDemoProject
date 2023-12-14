namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactInAccountOpportunityLanguageRuleSchema

	/// <exclude/>
	public class ContactInAccountOpportunityLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactInAccountOpportunityLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactInAccountOpportunityLanguageRuleSchema(ContactInAccountOpportunityLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0a831195-1dd5-446c-9d0a-2a61dd77a5bb");
			Name = "ContactInAccountOpportunityLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0e987dc8-e3a7-4136-b3d3-af8a5676bbce");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,219,110,219,48,12,125,78,129,254,3,225,189,36,64,32,191,231,138,46,40,138,0,235,218,245,178,119,69,166,19,1,182,228,81,82,6,35,216,191,143,190,165,142,135,14,241,131,0,81,228,57,60,135,180,145,57,186,66,42,132,55,36,146,206,166,94,108,172,73,245,62,144,244,218,154,219,155,211,237,205,40,56,109,246,240,90,58,143,249,252,124,239,151,16,126,22,23,247,198,107,175,209,113,2,167,124,33,220,51,46,108,50,233,220,12,152,204,75,229,183,230,78,41,27,140,127,42,10,75,62,24,237,203,111,210,236,131,220,227,75,200,176,46,141,227,24,22,46,228,185,164,114,213,222,107,152,41,248,131,244,80,144,61,234,4,29,168,6,20,178,22,1,82,75,208,67,22,29,88,220,67,43,194,46,211,10,84,5,120,109,91,48,131,175,210,225,101,167,163,83,221,237,135,82,107,156,167,160,188,37,22,252,92,211,52,25,67,65,141,34,66,233,89,132,230,42,105,120,50,54,229,36,68,80,132,233,50,186,178,179,40,94,137,51,69,60,228,88,20,146,100,14,134,167,191,140,130,67,98,84,131,170,26,120,180,122,231,123,101,97,27,16,139,184,206,174,139,91,147,174,108,98,252,126,1,13,151,76,147,10,112,52,131,29,59,56,30,60,193,169,126,172,142,63,173,155,104,146,198,208,75,119,31,209,31,108,114,141,177,79,59,47,217,212,143,173,224,93,225,213,76,53,203,77,201,230,231,181,209,6,100,163,235,127,22,106,115,64,210,62,177,10,226,190,55,246,200,235,207,208,240,16,116,2,15,232,59,71,182,201,184,14,85,164,190,124,65,101,41,217,38,157,212,163,36,64,247,11,150,96,240,55,212,255,76,249,170,14,152,203,31,1,169,28,88,41,250,9,143,210,48,60,77,33,234,205,33,154,204,207,184,157,226,141,205,66,110,190,243,212,153,134,201,196,93,146,52,177,113,212,78,82,60,147,174,116,182,19,22,93,243,98,155,68,19,81,149,54,176,13,127,171,165,69,99,173,77,120,208,236,116,40,185,129,32,244,129,76,251,182,174,170,223,202,2,219,134,126,202,44,224,162,242,107,53,254,183,253,9,172,215,181,191,226,62,47,124,57,255,124,79,154,232,101,144,99,213,247,23,245,117,133,229,252,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a831195-1dd5-446c-9d0a-2a61dd77a5bb"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChannelInOmniChatLanguageRuleSchema

	/// <exclude/>
	public class ChannelInOmniChatLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChannelInOmniChatLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChannelInOmniChatLanguageRuleSchema(ChannelInOmniChatLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("793788e6-b334-a107-994a-4852353f66cb");
			Name = "ChannelInOmniChatLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,147,77,111,155,64,16,134,207,142,148,255,48,162,23,44,89,112,119,108,164,214,170,34,75,77,155,54,73,239,27,24,240,74,176,75,103,119,93,33,171,255,189,195,242,17,160,109,26,228,3,51,204,60,243,206,187,107,80,162,66,83,139,20,225,17,137,132,209,185,141,14,90,229,178,112,36,172,212,234,250,234,114,125,181,114,70,170,2,30,26,99,177,186,25,227,105,11,225,191,242,209,71,101,165,149,104,184,128,75,226,56,134,157,113,85,37,168,73,250,248,80,10,99,54,80,147,62,203,12,13,148,66,21,78,20,184,129,156,116,5,95,42,37,15,39,97,161,195,243,171,82,88,70,3,44,158,208,106,247,92,202,20,210,22,56,20,30,213,0,248,212,115,191,185,18,97,11,31,132,193,105,138,251,47,94,227,234,29,97,193,203,3,91,97,44,185,212,106,50,91,184,247,240,174,98,185,70,183,7,161,176,172,95,114,151,80,108,170,206,185,8,17,82,194,124,31,188,170,39,136,147,104,4,199,75,242,174,22,36,42,104,143,107,31,56,131,196,202,20,166,237,9,5,201,19,199,144,142,137,104,23,251,106,223,220,27,242,234,232,240,105,6,132,57,127,221,98,86,91,120,102,183,194,197,39,184,192,175,222,49,84,89,103,218,220,193,59,180,39,157,189,197,188,251,229,233,255,239,240,223,98,149,238,187,143,89,144,140,36,108,47,100,3,60,140,95,114,137,52,115,204,51,164,58,33,73,155,233,20,226,169,143,250,204,119,155,27,225,214,201,12,110,113,244,241,152,133,62,245,50,144,205,241,206,157,5,1,154,31,176,7,133,63,193,255,25,154,135,244,132,149,248,234,144,154,133,249,209,180,224,78,40,70,211,6,130,65,123,176,190,25,161,131,79,7,93,186,74,125,230,125,121,6,79,138,222,103,89,151,11,135,43,23,13,50,35,54,98,29,181,181,29,167,155,54,170,238,195,14,195,219,117,241,66,226,102,186,100,135,241,171,151,163,21,12,152,19,91,214,99,83,99,175,235,187,40,29,238,218,166,36,252,115,139,158,73,104,29,169,9,213,167,255,126,221,56,203,63,126,126,3,72,103,203,182,209,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("793788e6-b334-a107-994a-4852353f66cb"));
		}

		#endregion

	}

	#endregion

}


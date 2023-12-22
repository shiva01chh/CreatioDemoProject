﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialMentionSearchRuleEntityRepositorySchema

	/// <exclude/>
	public class SocialMentionSearchRuleEntityRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialMentionSearchRuleEntityRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialMentionSearchRuleEntityRepositorySchema(SocialMentionSearchRuleEntityRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("df2f2b65-3bbc-4d32-a495-5a77a207f077");
			Name = "SocialMentionSearchRuleEntityRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c726abc-cc67-49b0-9345-f38bdff9ced8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,86,93,111,26,59,16,125,166,82,255,131,197,125,89,164,104,121,191,1,164,18,160,138,212,68,17,220,246,221,217,29,192,234,174,141,108,111,82,90,245,191,223,241,215,174,119,19,86,75,155,135,0,246,204,241,248,204,204,241,112,90,130,58,209,12,200,127,32,37,85,98,175,211,59,193,247,236,80,73,170,153,224,31,63,252,250,248,97,84,41,198,15,100,119,86,26,74,220,47,10,200,204,166,74,63,3,7,201,178,219,174,205,138,106,218,44,198,216,101,41,248,251,59,18,46,173,167,171,37,110,225,230,63,18,14,120,46,185,43,168,82,100,39,50,70,139,7,224,38,150,29,80,153,29,183,85,1,107,252,173,207,91,56,9,197,180,144,103,235,121,170,158,11,150,145,236,58,199,209,47,235,92,159,187,97,80,228,234,95,242,36,133,70,10,32,119,219,211,233,148,204,84,85,150,84,158,23,205,2,0,201,36,236,231,227,175,10,36,178,202,29,107,227,233,130,48,174,52,229,25,164,181,245,52,246,63,5,124,34,129,230,130,23,103,210,198,232,252,188,245,97,2,207,93,164,237,176,209,80,105,89,101,120,41,19,188,165,194,89,120,90,6,18,146,116,130,168,178,9,49,229,49,26,117,54,230,184,101,146,57,250,221,31,216,3,232,163,24,74,232,14,76,217,169,152,216,11,113,27,134,115,172,192,224,73,121,110,28,168,134,33,222,238,214,6,35,171,43,253,66,158,236,138,4,93,73,174,22,127,136,60,155,6,128,118,230,191,48,165,103,189,64,11,242,25,244,5,11,149,132,212,188,80,73,164,89,193,172,112,120,29,130,155,76,110,107,215,19,61,128,114,212,35,64,207,129,206,38,184,186,54,78,86,203,245,15,200,42,44,30,146,63,215,95,231,157,242,77,215,92,85,18,86,203,102,41,153,132,248,3,212,189,209,148,45,182,3,72,155,92,255,117,30,71,152,186,35,192,237,37,205,145,13,218,232,245,200,10,32,73,3,145,154,143,232,188,209,200,210,149,126,202,243,251,253,163,208,235,31,200,152,74,238,108,1,245,18,119,239,187,58,2,159,120,62,108,43,52,31,238,191,75,188,203,78,220,46,239,150,255,214,85,137,205,225,53,165,22,164,230,134,56,34,25,223,11,89,122,113,119,208,123,41,74,50,59,81,73,75,196,36,28,31,133,249,184,185,3,162,244,213,191,245,123,235,20,247,67,148,59,27,82,121,42,160,196,144,109,20,141,24,206,166,22,235,239,90,43,66,107,55,22,123,193,252,245,75,29,185,38,201,239,23,100,40,35,20,92,195,54,88,159,93,118,132,146,98,173,70,85,135,173,132,47,105,85,242,111,180,168,96,230,236,23,201,120,29,121,140,125,245,120,176,61,43,52,200,229,217,249,13,131,219,180,124,58,128,149,109,195,225,96,95,107,251,113,36,17,166,126,189,184,244,50,215,121,62,110,90,228,220,116,110,119,19,5,231,207,138,218,101,112,183,12,127,44,136,114,18,114,165,210,91,167,222,186,11,130,238,69,116,128,132,70,202,93,6,35,39,192,78,67,44,211,206,182,77,233,36,93,161,86,49,110,64,188,236,164,142,194,110,93,117,119,187,101,210,221,143,51,239,246,210,13,170,70,114,145,213,118,206,90,215,184,110,50,168,167,149,107,114,141,148,104,154,233,141,144,62,178,56,67,209,235,235,53,209,42,112,75,13,237,133,67,216,88,26,230,94,206,108,76,10,33,190,87,167,161,146,232,124,31,241,251,120,241,68,165,38,98,255,78,164,38,62,99,79,244,145,106,242,202,138,130,60,131,105,129,156,104,225,91,3,135,65,85,21,154,20,152,227,65,90,57,148,133,110,201,186,161,208,14,10,111,32,236,208,225,87,85,179,188,60,187,169,195,11,75,115,233,184,152,51,239,22,79,34,111,15,72,58,210,162,250,231,142,96,142,175,26,80,76,82,210,175,240,86,172,152,127,116,235,55,63,68,102,30,253,45,229,7,136,95,126,99,154,94,142,32,144,145,68,151,14,175,62,219,147,164,198,190,19,21,215,100,49,39,235,221,227,6,32,127,16,57,186,239,64,190,48,148,13,143,27,208,158,112,170,217,177,159,208,140,37,207,120,191,239,183,23,167,136,112,204,165,238,242,107,237,134,195,181,248,239,127,176,89,51,154,15,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("df2f2b65-3bbc-4d32-a495-5a77a207f077"));
		}

		#endregion

	}

	#endregion

}


﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialMentionSearchRuleEntitySchema

	/// <exclude/>
	public class SocialMentionSearchRuleEntitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialMentionSearchRuleEntitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialMentionSearchRuleEntitySchema(SocialMentionSearchRuleEntitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2b15e086-76c3-4a26-a34d-ce6d77f04435");
			Name = "SocialMentionSearchRuleEntity";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c726abc-cc67-49b0-9345-f38bdff9ced8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,88,77,111,219,56,16,61,187,64,255,3,215,123,145,128,64,190,199,177,187,105,106,23,89,52,77,16,167,237,97,177,7,70,26,199,68,37,202,37,169,180,110,145,255,190,195,15,201,164,44,37,74,187,192,110,46,177,200,225,188,153,225,155,225,144,156,22,32,183,52,5,114,3,66,80,89,174,85,114,86,242,53,187,171,4,85,172,228,47,95,252,120,249,98,84,73,198,239,200,106,39,21,20,211,214,55,202,231,57,164,90,88,38,111,129,131,96,233,129,204,59,198,191,236,7,125,172,162,40,121,247,140,103,69,183,128,128,190,241,100,193,21,83,12,100,175,192,155,215,56,133,147,191,11,184,67,0,114,150,83,41,143,201,170,76,25,205,47,128,107,212,21,80,145,110,174,171,28,140,186,157,89,240,215,10,29,164,57,251,78,111,115,248,27,7,182,213,109,206,82,146,106,5,79,173,31,253,48,58,26,212,37,131,60,67,216,43,81,42,12,33,100,118,122,50,153,144,19,89,21,5,21,187,249,126,0,128,164,2,214,179,241,7,9,2,227,195,109,212,199,147,57,97,92,42,202,83,72,26,233,137,191,126,91,235,39,2,104,86,242,124,71,66,29,173,207,169,51,19,120,102,45,13,205,126,212,75,244,198,68,196,46,113,209,121,116,69,212,178,165,10,62,143,136,84,66,239,32,24,225,85,186,129,130,54,131,107,150,43,16,175,119,72,194,170,224,71,26,114,52,114,115,86,143,30,143,201,15,51,211,2,154,181,160,166,70,104,225,225,160,136,15,107,5,150,1,38,138,132,70,76,61,40,39,176,183,196,76,62,60,30,94,100,195,22,132,166,111,24,203,167,104,17,48,63,241,221,208,20,225,152,234,125,244,176,155,228,194,22,248,111,227,118,7,202,55,188,211,16,29,21,155,173,228,118,71,82,235,186,6,37,81,74,113,12,200,86,48,189,162,158,43,5,201,203,242,115,181,117,3,181,162,175,76,109,144,167,107,16,128,140,30,238,32,2,7,178,92,209,84,153,9,225,79,156,166,105,89,113,61,81,3,214,201,35,227,65,241,105,109,255,240,8,105,74,212,206,255,215,49,121,166,207,30,155,59,253,109,83,185,211,255,51,44,62,10,164,111,209,10,244,209,161,13,202,168,162,68,154,207,30,139,204,200,150,10,90,24,90,205,198,210,212,145,247,248,123,60,191,162,66,145,114,221,227,173,161,161,218,80,133,129,204,115,29,119,204,200,140,168,210,165,46,134,86,86,185,34,57,147,42,57,153,24,144,110,76,43,111,67,49,158,15,218,7,39,92,155,177,198,61,94,55,185,50,4,237,35,205,43,104,129,53,174,253,132,9,135,152,2,84,37,184,156,119,238,76,115,182,156,76,106,185,240,76,177,162,228,45,168,158,50,239,204,149,86,48,114,156,218,111,223,81,88,115,252,24,187,138,254,182,98,25,241,162,81,23,244,123,170,51,202,104,183,242,239,76,246,104,165,88,118,45,144,110,37,82,170,162,61,135,143,200,248,60,27,199,211,70,69,88,192,3,29,190,49,228,183,25,225,21,18,232,85,75,117,88,18,156,122,114,220,42,21,22,207,69,11,45,102,247,128,237,209,105,86,48,254,129,51,181,170,110,221,220,76,199,242,180,95,32,242,76,119,222,55,199,85,120,196,5,44,184,160,156,222,129,192,38,77,157,187,61,125,189,211,110,70,13,161,60,197,174,50,189,97,114,155,83,231,129,139,73,128,169,213,93,245,200,250,134,202,218,55,14,95,29,101,90,7,127,156,220,148,219,104,177,122,191,4,200,46,202,12,153,131,205,214,61,67,234,57,74,213,68,186,66,63,86,236,59,196,9,66,42,198,117,72,44,81,18,11,30,141,195,21,99,183,39,201,169,140,204,143,167,164,251,188,183,26,76,205,121,26,241,106,83,170,178,129,109,190,158,92,183,40,40,203,221,42,247,187,181,102,31,180,155,221,22,156,168,207,149,164,45,97,20,36,75,81,22,209,34,104,164,252,47,39,117,142,75,197,159,37,227,30,49,12,66,203,212,218,170,75,222,210,217,147,146,113,114,46,23,95,42,154,247,109,207,1,188,239,18,218,112,217,30,194,117,78,133,9,243,32,245,159,54,120,138,182,12,238,43,0,123,149,118,38,185,210,133,19,80,54,242,171,81,29,136,83,158,117,97,91,186,232,45,145,72,87,249,9,15,243,67,125,251,114,24,168,139,147,197,55,189,40,122,164,96,196,132,74,151,82,54,223,108,157,118,41,247,100,95,210,117,46,251,65,30,126,58,255,91,231,200,163,181,207,43,253,3,106,74,43,113,246,52,48,169,208,34,152,79,144,95,38,154,163,67,91,141,245,109,252,8,179,148,208,148,250,181,61,189,182,17,38,247,154,159,166,231,112,57,233,245,30,100,141,33,32,2,203,236,208,142,203,114,222,181,151,195,186,159,214,206,247,52,30,31,135,153,217,199,28,211,30,244,247,31,203,125,170,70,29,157,134,171,125,142,87,237,86,67,159,198,56,148,44,138,173,218,217,173,96,107,18,249,75,201,204,246,5,181,138,145,196,126,61,221,144,0,172,153,28,165,84,2,105,238,33,199,110,116,20,98,182,206,241,179,74,96,235,175,244,104,226,86,158,103,211,122,233,45,102,240,231,105,160,190,102,228,243,213,55,60,239,84,255,96,254,61,16,200,17,197,121,20,170,246,35,147,216,142,97,182,119,215,233,124,53,200,65,39,124,252,12,115,31,252,100,241,12,11,110,43,238,162,125,1,106,83,102,205,45,155,12,200,39,154,101,76,155,64,243,154,169,210,222,37,52,119,11,75,60,228,59,89,99,11,67,34,188,8,219,215,167,130,166,162,148,228,143,36,73,98,195,231,90,175,121,203,105,22,218,51,192,112,93,142,221,77,240,255,118,27,170,51,240,102,3,70,66,227,52,161,48,90,113,243,242,172,81,219,21,24,35,6,250,92,195,161,103,132,162,149,255,118,215,222,161,154,19,231,222,178,20,46,251,231,3,238,35,135,55,145,142,123,133,116,199,75,15,76,221,226,6,117,197,127,51,250,217,158,60,168,29,135,24,238,70,178,110,191,69,249,208,238,212,147,238,56,90,50,33,213,165,120,3,107,138,219,27,185,39,135,217,220,189,53,52,185,26,222,90,226,118,205,219,131,181,170,158,75,186,58,110,126,62,246,86,93,114,240,124,150,92,215,207,28,254,155,91,87,85,30,84,239,131,18,223,118,197,136,232,131,88,215,246,40,30,226,137,107,82,164,119,83,27,120,235,245,174,187,190,81,71,193,189,214,66,213,192,201,105,150,93,83,126,7,145,235,189,22,223,32,173,20,44,120,85,128,208,47,208,145,126,208,197,180,193,93,212,36,61,224,167,155,143,227,56,232,34,2,207,186,223,112,236,104,56,104,198,252,191,127,0,0,158,132,245,64,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b15e086-76c3-4a26-a34d-ce6d77f04435"));
		}

		#endregion

	}

	#endregion

}


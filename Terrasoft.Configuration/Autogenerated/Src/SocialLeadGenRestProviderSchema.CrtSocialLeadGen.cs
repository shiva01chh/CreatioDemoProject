﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialLeadGenRestProviderSchema

	/// <exclude/>
	public class SocialLeadGenRestProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialLeadGenRestProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialLeadGenRestProviderSchema(SocialLeadGenRestProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3fb8360e-08c0-8981-a28e-7cc3afcc5bee");
			Name = "SocialLeadGenRestProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,89,223,115,211,56,16,126,14,51,252,15,186,112,15,233,76,206,121,167,77,58,33,20,232,221,65,59,77,24,30,59,170,189,73,76,29,219,39,201,45,133,233,255,126,187,146,44,203,142,237,210,99,96,24,174,47,181,165,213,234,219,213,183,63,228,164,124,7,50,231,33,176,21,8,193,101,182,86,193,34,75,215,241,166,16,92,197,89,26,44,179,48,230,201,223,192,163,215,144,62,125,242,229,233,147,65,33,227,116,195,150,119,82,193,46,120,7,234,208,141,117,41,121,145,239,178,52,137,83,88,36,89,17,157,166,10,54,102,166,125,169,128,174,241,224,21,15,85,38,98,144,149,196,5,72,181,220,114,145,87,67,239,224,86,101,169,94,245,167,244,119,49,160,155,239,100,68,240,70,169,188,117,2,61,112,13,74,182,67,218,237,180,122,156,123,38,96,131,22,177,69,194,165,124,206,106,126,35,136,231,34,187,137,35,16,90,120,50,153,176,35,89,236,118,92,220,205,236,187,21,96,113,186,206,196,78,187,135,173,69,182,99,74,240,240,154,54,150,32,110,226,16,130,82,193,196,211,144,23,87,73,28,178,144,118,239,219,124,240,69,3,112,112,113,38,7,161,208,163,207,241,57,190,225,10,140,64,110,94,216,105,4,169,138,213,221,18,55,7,81,42,98,151,113,235,56,121,105,207,58,61,80,234,209,86,160,130,188,212,20,167,82,241,20,205,194,147,84,133,72,37,67,192,28,173,145,91,136,156,88,224,244,172,107,243,177,100,105,145,36,76,109,33,101,161,0,130,92,106,100,217,26,113,0,208,248,122,58,108,183,100,56,153,177,82,183,118,183,183,66,159,165,161,220,29,202,57,12,53,207,63,228,169,142,97,138,164,193,96,3,202,62,13,226,53,27,117,120,149,77,167,218,202,131,82,118,208,41,200,22,218,7,237,155,142,14,14,205,250,123,243,79,104,135,247,158,165,21,149,21,206,238,173,111,120,82,128,183,234,222,82,13,210,200,176,173,143,122,153,130,80,65,100,68,90,25,244,30,153,195,194,44,77,81,144,178,74,215,105,88,77,90,126,225,196,155,175,206,255,135,172,60,64,105,114,89,137,219,157,43,69,208,34,137,209,106,118,41,220,115,55,213,95,99,186,96,153,32,125,146,136,201,104,17,134,166,214,128,193,205,230,121,204,66,158,36,178,195,6,61,162,189,233,94,87,117,53,222,194,74,174,50,221,135,236,61,182,115,174,50,169,133,103,254,36,75,225,214,83,231,216,228,75,5,243,40,122,9,107,94,36,234,13,230,31,228,220,16,157,174,112,230,143,213,93,14,195,49,27,242,60,199,84,165,19,220,228,35,166,231,97,7,43,27,174,110,97,98,13,220,35,217,135,168,164,18,5,197,54,241,79,167,207,30,242,121,226,148,86,184,201,180,125,231,151,115,193,119,44,197,10,59,29,22,53,238,13,103,167,94,134,170,243,50,56,154,232,133,230,64,77,82,239,76,231,163,6,167,235,219,148,167,216,16,154,54,196,14,191,194,89,111,65,109,179,232,145,37,162,63,19,89,112,55,92,52,240,204,197,198,82,205,243,57,14,22,59,226,92,211,149,227,134,255,44,151,44,135,252,4,30,96,88,30,181,163,153,141,246,32,28,180,101,2,242,253,5,252,83,80,28,26,235,236,219,135,88,109,87,217,53,164,35,4,76,165,186,16,137,111,161,162,57,180,170,125,123,66,54,15,67,144,82,235,32,101,39,159,66,200,9,202,27,158,70,9,140,134,82,115,224,50,65,18,108,32,189,228,121,92,134,13,233,23,22,84,21,162,22,216,136,128,148,46,209,35,20,160,101,100,206,11,60,86,17,127,230,214,149,191,15,95,0,23,84,156,52,224,251,97,221,155,86,67,155,103,86,148,244,112,223,28,143,12,94,114,197,143,86,179,209,169,1,98,6,113,128,18,152,126,62,96,183,91,16,180,170,167,81,42,23,142,201,38,199,23,7,197,76,30,7,180,25,59,62,214,134,175,70,173,199,182,98,75,228,181,246,109,252,25,34,227,26,2,104,104,205,118,250,223,152,85,103,55,102,217,213,71,228,2,187,202,162,187,51,243,56,101,145,201,107,7,38,251,252,103,19,234,7,214,193,163,253,115,179,34,175,116,115,136,11,201,112,243,226,154,220,74,216,90,54,181,182,153,73,202,246,158,65,191,85,22,17,178,103,56,253,238,100,245,234,98,254,246,228,195,217,197,95,101,50,118,172,121,129,75,189,245,4,239,25,36,18,246,4,9,78,171,112,26,197,107,47,149,27,71,24,23,33,212,170,178,4,39,159,32,44,20,113,102,100,245,90,103,44,182,16,94,151,110,69,235,79,132,200,196,200,241,170,70,215,6,35,27,82,109,69,190,20,111,227,75,31,89,236,243,71,107,247,79,113,208,37,152,230,49,55,206,234,156,138,13,40,202,6,123,117,121,236,44,26,51,39,71,85,188,132,168,141,61,124,204,137,126,195,113,150,163,143,172,87,15,247,149,26,132,172,112,83,135,6,101,254,197,70,46,12,11,1,81,95,169,87,232,19,191,220,175,134,51,157,150,220,29,199,233,38,73,44,241,110,65,123,187,80,138,215,27,5,219,73,234,153,90,155,160,215,59,196,246,238,66,0,202,60,228,170,201,112,182,218,138,236,86,82,254,77,237,158,40,221,220,214,187,18,225,246,170,144,216,118,211,205,20,239,90,153,242,47,72,116,105,94,106,137,5,10,4,103,127,225,210,163,137,131,210,232,74,111,178,56,98,173,71,254,189,170,5,5,130,115,89,5,148,98,98,15,186,139,14,34,49,16,170,183,88,145,249,134,136,236,116,144,87,143,131,19,127,22,107,143,155,246,39,108,111,236,79,219,78,184,182,196,96,120,9,50,20,113,238,250,177,193,64,209,65,233,170,214,105,179,59,214,81,15,190,113,205,150,177,69,85,71,236,20,141,155,184,200,55,222,160,141,251,99,124,144,89,33,66,240,163,255,254,187,198,216,255,58,62,234,193,225,69,198,55,208,252,193,80,194,109,118,8,77,3,184,168,146,58,93,16,75,142,138,59,119,83,108,23,166,130,133,172,199,102,87,5,200,113,16,184,37,214,84,211,20,28,61,8,97,54,106,198,142,187,43,226,5,90,133,91,246,133,221,247,68,237,30,164,159,50,118,31,64,249,67,35,152,84,127,93,101,125,232,198,76,61,148,244,131,193,187,150,80,4,169,108,47,192,176,23,162,153,91,108,142,246,230,170,94,210,255,18,183,212,159,88,244,237,10,245,149,205,22,222,153,220,51,173,99,230,139,170,15,198,216,17,156,159,45,87,221,95,246,186,138,187,167,199,79,35,23,94,126,176,247,135,140,190,111,98,245,138,41,190,245,39,3,144,46,119,104,59,109,111,70,31,182,202,203,238,195,13,2,57,106,246,94,36,140,71,120,74,82,167,211,178,169,219,203,124,254,66,207,139,51,221,29,90,156,189,10,76,3,38,103,46,174,35,52,26,197,202,241,199,230,88,247,200,116,160,164,38,219,150,7,182,229,152,70,65,221,102,226,154,26,168,171,4,118,149,203,16,102,72,191,33,48,36,87,158,197,24,143,22,68,85,90,180,87,117,196,96,79,172,67,38,216,75,185,230,187,74,227,94,120,158,57,126,82,63,210,123,27,252,246,27,108,239,149,84,243,114,108,246,174,95,162,250,203,236,175,18,115,63,138,235,12,185,102,206,185,155,244,252,214,107,91,232,7,130,249,249,233,47,64,126,75,239,174,8,24,181,220,111,125,250,251,55,92,87,237,187,175,205,125,132,110,94,240,202,82,219,115,209,51,163,245,65,28,163,191,127,1,112,178,190,160,211,28,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3fb8360e-08c0-8981-a28e-7cc3afcc5bee"));
		}

		#endregion

	}

	#endregion

}


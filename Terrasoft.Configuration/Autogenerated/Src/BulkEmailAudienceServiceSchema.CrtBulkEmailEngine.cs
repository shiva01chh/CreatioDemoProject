﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailAudienceServiceSchema

	/// <exclude/>
	public class BulkEmailAudienceServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailAudienceServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailAudienceServiceSchema(BulkEmailAudienceServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f706cda4-7f31-44bd-a90d-b46badfde015");
			Name = "BulkEmailAudienceService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,89,115,212,56,16,126,30,170,248,15,170,225,97,157,170,41,103,119,31,201,65,229,24,96,168,77,8,153,80,60,80,20,165,177,123,18,47,190,144,228,192,44,240,223,183,117,217,146,237,241,4,72,216,147,135,128,165,238,86,235,235,79,173,110,133,156,102,192,75,26,1,185,0,198,40,47,150,34,60,42,242,101,114,89,49,42,146,34,191,127,239,211,253,123,163,138,39,249,37,153,175,184,128,108,167,245,141,242,105,10,145,20,230,225,19,200,129,37,81,71,230,188,202,69,146,65,56,199,89,154,38,127,40,219,29,41,156,189,78,34,56,41,98,72,7,39,195,3,92,239,122,179,145,240,21,44,26,1,119,139,89,86,228,225,51,238,234,187,211,12,194,41,122,44,18,224,125,2,167,85,226,175,115,76,5,69,220,4,163,145,184,145,194,244,163,128,156,75,204,250,196,209,109,227,99,51,171,252,89,53,96,147,61,50,232,70,216,86,104,76,201,253,233,217,121,116,5,25,69,83,222,150,67,119,18,213,80,241,1,131,75,185,232,81,74,57,127,72,14,171,244,221,52,163,73,122,80,197,9,228,17,24,55,148,236,246,246,54,217,229,85,150,81,182,218,55,223,39,52,167,151,192,9,53,242,164,88,146,5,26,33,32,173,240,208,170,109,59,122,175,141,81,187,163,224,20,217,138,190,142,59,171,143,183,222,72,249,3,94,158,130,64,224,74,164,198,34,73,113,15,231,240,190,74,24,100,144,11,30,184,31,18,48,180,181,65,69,74,133,102,32,86,139,148,213,34,77,34,18,73,28,214,194,64,16,33,202,27,80,70,159,20,48,53,138,103,172,40,129,73,168,31,146,51,101,80,207,183,145,83,3,7,57,73,114,46,168,65,109,151,3,144,136,193,114,175,193,225,49,141,104,12,227,237,125,237,87,88,219,114,225,28,149,76,158,25,32,45,53,242,118,225,15,236,40,97,189,207,182,108,251,91,102,135,209,232,18,4,217,219,239,24,34,143,30,145,160,51,184,71,114,248,208,54,20,188,228,192,48,208,185,230,234,214,150,114,98,196,215,24,222,35,215,52,173,180,167,95,190,9,187,89,39,118,231,80,22,60,17,5,91,221,20,200,33,27,228,45,237,140,185,192,14,234,246,12,249,64,119,109,107,172,123,198,91,112,119,77,111,128,190,215,100,7,253,7,144,199,154,220,62,211,79,64,92,21,177,164,185,198,76,207,90,0,221,60,243,162,2,52,253,4,132,245,112,58,127,17,112,193,100,194,2,254,222,222,28,16,79,136,25,181,158,105,125,153,28,38,202,243,81,81,137,174,233,231,165,186,162,72,161,255,158,16,41,117,156,168,61,99,96,119,181,81,107,28,9,80,164,85,150,75,171,39,180,220,50,248,95,83,70,56,200,132,170,221,221,35,242,14,9,143,129,91,247,118,231,205,244,126,224,57,110,128,85,54,108,222,245,177,247,18,175,78,153,12,239,84,49,51,28,62,92,73,127,2,199,131,240,188,40,68,3,192,150,6,32,60,74,139,28,130,45,66,121,39,217,55,78,248,248,221,200,25,99,190,235,82,55,22,206,110,53,148,184,128,222,182,172,24,240,155,135,143,147,60,54,250,227,223,146,252,29,196,122,201,177,209,213,122,152,127,151,192,60,71,253,213,134,132,95,206,226,142,124,136,131,90,167,203,63,12,152,244,211,1,248,176,74,210,120,202,223,7,218,249,73,11,37,205,35,159,44,218,184,33,154,60,128,85,154,234,177,100,73,188,232,205,248,25,194,74,23,41,144,207,159,137,63,243,52,1,70,89,116,149,68,52,181,252,115,140,42,177,186,140,144,33,89,71,121,119,197,137,239,106,123,55,198,245,47,4,82,110,147,251,8,49,65,154,125,56,42,176,136,107,129,99,135,141,154,250,201,64,84,44,151,72,186,9,194,30,249,230,166,172,173,156,99,9,138,110,2,57,98,128,34,86,194,155,11,250,10,20,167,24,138,44,203,113,214,100,129,155,158,237,73,95,22,40,22,191,163,229,125,194,228,6,101,61,108,35,208,89,25,204,170,3,33,105,164,3,207,207,94,218,24,248,100,210,30,194,202,196,6,3,192,109,22,170,51,77,0,245,10,130,85,176,53,105,100,15,150,75,52,5,242,80,88,161,80,69,176,145,209,251,237,26,173,161,48,86,117,200,191,238,18,216,84,235,204,178,178,96,130,59,165,97,83,49,46,86,68,92,1,73,19,46,228,93,94,227,94,48,178,44,210,24,216,186,235,250,245,115,44,182,84,179,96,43,201,55,106,24,171,236,89,126,93,188,131,64,59,40,75,203,179,231,243,139,241,132,28,22,241,106,46,86,169,172,52,80,236,4,56,199,115,90,143,134,135,148,153,203,70,22,135,192,197,227,130,101,84,120,210,122,72,53,25,19,98,227,54,44,167,42,76,91,33,180,106,202,58,242,26,163,160,115,163,235,113,213,8,212,160,169,47,75,93,81,151,17,163,86,245,21,30,196,177,53,19,248,186,54,33,68,84,68,87,36,152,126,140,160,212,188,175,115,82,47,99,125,159,141,228,104,94,69,17,238,26,247,191,164,152,97,12,233,70,6,9,73,202,208,252,91,207,124,233,73,44,3,235,4,91,27,43,194,115,200,138,107,248,159,97,67,12,211,24,117,25,166,199,191,141,97,90,247,63,66,178,163,43,136,222,113,34,40,199,159,73,238,146,13,99,89,193,26,26,169,145,146,50,154,145,28,239,132,189,113,221,246,204,226,241,254,203,60,65,101,146,196,146,151,75,44,14,36,71,37,95,27,235,225,238,182,82,111,172,233,237,240,253,11,204,216,228,195,21,228,218,1,188,121,114,65,177,53,50,62,46,145,226,158,25,171,119,71,236,126,197,104,89,98,41,127,199,4,95,20,69,74,158,82,62,203,35,236,240,83,16,112,129,219,13,158,84,73,76,28,108,45,201,76,236,219,212,237,26,112,117,55,146,97,202,69,130,222,249,57,71,71,65,129,255,19,129,143,16,85,138,239,50,14,188,132,72,198,55,118,35,242,195,9,83,159,170,15,137,184,194,98,78,239,33,214,46,255,107,8,242,66,134,65,134,212,4,9,183,80,111,220,198,77,77,219,8,173,229,142,236,115,160,54,130,139,183,89,212,111,174,195,36,55,1,13,121,103,146,221,153,236,201,245,130,205,234,161,29,53,169,207,46,29,95,36,234,1,205,145,244,166,186,21,221,63,254,98,235,22,206,122,172,190,136,122,68,7,46,56,25,101,39,100,78,107,169,31,96,15,155,185,29,135,22,178,167,108,189,108,248,122,83,255,129,195,159,116,91,227,222,183,14,185,136,247,172,209,52,221,126,111,161,188,105,250,149,238,91,80,216,66,199,217,235,68,238,195,44,234,251,119,92,149,8,186,164,246,170,132,137,245,196,89,146,57,77,69,183,71,210,175,1,90,64,62,152,12,182,69,67,45,34,244,247,85,19,167,137,27,232,86,244,104,107,176,245,236,189,142,44,107,159,189,229,131,60,201,20,159,100,106,239,123,187,109,85,25,227,237,253,254,199,112,247,109,191,243,16,189,222,177,239,122,122,158,121,87,199,198,235,72,249,120,2,217,2,88,48,227,246,217,28,131,174,250,69,247,128,170,44,234,28,22,242,137,92,130,216,33,92,254,24,124,208,181,181,122,108,73,71,4,178,238,187,29,234,132,195,35,53,241,191,110,234,108,115,164,9,30,249,144,28,217,162,235,217,252,249,41,222,196,152,205,34,138,213,33,238,166,121,64,140,9,229,141,197,154,47,55,252,229,83,232,48,192,80,233,187,112,49,79,173,94,126,186,241,254,213,239,107,76,205,145,170,36,166,179,207,202,62,4,222,146,119,253,9,178,207,205,111,56,243,67,125,246,95,126,238,7,31,1,122,124,191,203,164,208,244,209,183,20,93,149,36,106,152,148,205,254,76,113,27,81,117,122,219,191,95,84,221,198,251,142,162,186,41,177,30,195,146,86,169,208,191,249,193,104,253,252,181,225,85,189,248,45,229,92,185,254,206,109,222,226,182,134,88,27,250,186,124,252,209,215,120,227,217,119,133,183,238,56,8,3,142,113,12,137,125,37,89,172,240,246,81,177,221,28,209,78,111,109,141,180,163,35,207,178,9,208,26,117,147,186,213,251,117,207,145,222,168,101,10,202,155,171,38,185,32,222,11,248,29,37,146,191,105,10,169,147,7,229,208,90,65,225,245,79,175,22,111,35,116,94,198,89,27,194,53,153,114,205,255,97,89,19,37,200,171,108,163,3,35,213,116,190,158,162,172,195,231,211,34,87,9,120,210,55,169,204,225,236,47,189,179,170,0,141,100,15,253,235,26,140,212,24,254,249,19,154,98,145,187,25,38,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f706cda4-7f31-44bd-a90d-b46badfde015"));
		}

		#endregion

	}

	#endregion

}


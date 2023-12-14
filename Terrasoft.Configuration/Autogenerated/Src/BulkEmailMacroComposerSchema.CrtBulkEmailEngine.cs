﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailMacroComposerSchema

	/// <exclude/>
	public class BulkEmailMacroComposerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailMacroComposerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailMacroComposerSchema(BulkEmailMacroComposerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0a0facfe-998c-404e-bfe3-0ab89f11f400");
			Name = "BulkEmailMacroComposer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,89,221,115,219,54,18,127,86,103,250,63,160,188,78,135,158,83,233,222,220,61,197,54,51,142,106,167,154,198,141,199,118,174,15,157,142,7,34,33,11,87,18,84,65,80,177,206,245,255,126,139,47,18,32,65,201,78,154,92,245,36,130,139,197,126,254,118,23,100,184,36,245,26,103,4,221,16,206,113,93,45,69,50,171,216,146,222,53,28,11,90,177,47,191,120,248,242,139,73,83,83,118,135,174,183,181,32,229,81,239,25,232,139,130,100,146,184,78,94,19,70,56,205,6,52,111,40,251,125,176,120,179,226,4,231,176,208,189,185,4,94,219,238,113,68,168,228,157,160,69,29,38,227,100,108,61,57,199,153,168,56,37,114,39,208,252,141,147,59,96,134,102,5,174,235,23,232,85,83,252,118,86,98,90,92,224,140,87,179,170,92,87,53,225,138,242,240,240,16,29,215,77,89,98,190,77,205,243,37,175,54,52,39,53,42,137,88,85,121,141,68,133,22,13,45,114,84,202,253,53,194,44,71,84,212,104,131,139,6,200,150,21,71,146,187,148,139,147,140,174,41,97,162,78,44,247,67,135,253,186,89,20,52,67,153,148,107,68,44,4,242,226,154,140,201,60,121,80,114,119,42,130,111,4,134,243,94,128,220,116,131,5,209,239,215,250,1,101,242,61,170,5,151,210,181,76,231,57,40,185,38,92,108,127,130,48,65,39,40,90,116,175,162,163,81,6,87,100,13,242,227,225,118,110,95,68,71,70,62,194,114,45,162,47,239,57,37,69,238,10,59,153,184,167,129,46,2,12,36,163,167,98,197,22,81,38,208,45,39,130,111,103,85,3,255,79,208,63,143,246,210,83,70,5,197,197,37,230,24,226,183,56,187,39,89,35,131,75,71,165,101,116,129,197,42,185,160,44,62,99,27,202,43,86,130,215,18,208,43,35,117,93,113,69,53,69,255,58,216,121,220,53,41,241,122,5,17,120,93,208,18,221,214,246,17,216,51,242,222,127,29,63,69,46,255,184,246,156,214,113,232,182,117,84,152,210,56,234,22,162,241,55,146,159,49,65,197,246,58,91,129,32,210,85,225,61,16,67,130,220,131,225,84,124,95,105,107,171,165,48,61,164,50,205,182,46,185,94,217,45,81,9,105,195,105,1,1,6,176,210,148,108,32,207,105,147,67,230,100,68,69,252,247,88,224,235,170,225,128,95,183,216,188,232,214,188,125,138,254,223,42,23,221,93,101,104,57,44,226,252,26,162,21,132,84,118,133,16,184,227,16,3,16,235,85,77,1,86,64,211,245,96,109,79,152,171,180,228,141,68,37,25,236,42,237,53,69,31,113,212,194,12,68,17,0,37,84,37,51,72,95,45,119,160,128,198,143,169,196,165,53,36,30,134,120,187,43,170,5,46,20,50,65,94,214,21,131,7,141,86,73,123,232,97,255,212,99,216,138,75,196,192,17,39,81,3,140,65,106,166,241,62,74,231,142,40,141,58,180,125,153,28,31,170,157,97,70,64,39,0,142,1,10,210,119,140,254,222,16,4,96,10,113,184,164,192,4,152,137,149,2,21,73,3,255,177,64,239,33,40,208,130,200,83,114,5,166,150,173,201,23,250,95,25,63,89,91,139,36,19,163,175,81,113,167,60,46,178,141,75,36,169,16,81,41,246,9,132,50,184,31,118,103,252,206,51,61,242,61,49,69,175,27,154,163,214,170,230,217,209,234,64,158,48,121,129,22,16,48,113,127,179,179,207,221,130,30,212,166,65,10,3,112,233,63,201,15,16,75,5,57,62,187,207,200,90,178,74,227,131,68,17,198,14,30,79,21,151,73,76,44,213,20,169,151,115,65,116,61,215,2,0,146,28,160,147,20,189,101,154,131,89,27,18,183,124,14,52,16,78,134,144,100,160,213,60,197,81,95,131,168,219,57,196,27,89,170,46,218,245,200,80,14,179,27,232,84,239,160,251,138,45,52,63,226,120,55,70,164,177,54,133,145,205,38,255,41,191,107,100,97,137,251,249,53,69,190,215,141,194,143,207,5,137,143,7,8,242,249,33,162,141,196,40,125,181,47,239,254,28,16,8,151,195,40,85,65,97,32,160,237,221,144,166,70,68,145,255,121,137,220,85,241,214,0,83,91,30,195,2,218,212,22,43,90,15,82,187,101,146,188,125,15,189,185,151,226,137,147,227,237,34,68,181,223,61,76,70,218,4,32,220,209,63,60,238,46,125,166,53,132,102,220,47,124,198,116,225,106,29,94,213,10,220,17,33,193,35,92,208,209,203,151,40,30,121,117,130,230,16,60,65,214,177,5,152,122,39,243,19,221,227,187,106,27,53,198,154,149,177,117,87,21,141,20,129,182,70,43,19,88,63,209,91,38,3,80,26,57,46,141,63,28,135,244,81,61,243,132,100,26,218,102,44,36,46,244,32,53,50,162,152,166,122,83,65,89,179,21,194,130,125,91,41,100,99,223,175,22,109,109,114,234,134,49,244,133,158,199,228,52,73,101,40,38,111,170,187,228,103,204,217,121,197,75,44,12,88,71,191,132,19,25,198,0,133,154,106,177,254,245,5,138,208,223,245,142,175,163,51,206,1,149,222,175,104,65,144,71,166,208,202,204,65,232,193,8,254,75,112,98,250,245,17,244,233,114,177,163,30,25,208,128,222,145,0,244,165,214,8,232,193,55,10,250,22,253,227,49,65,145,91,74,189,232,53,54,255,158,42,111,3,212,31,203,118,98,138,230,103,12,2,132,227,5,212,124,223,40,115,182,172,210,20,65,180,105,61,193,130,87,237,148,171,13,233,112,211,112,102,97,45,5,7,150,101,197,244,78,255,20,189,166,184,27,8,239,174,27,116,95,225,82,183,71,26,71,49,193,33,13,82,103,224,182,174,7,115,152,127,147,110,32,3,223,83,17,155,160,158,128,205,26,206,194,160,147,88,69,245,139,184,59,96,218,83,166,47,180,225,254,136,150,20,170,107,17,146,226,138,20,68,118,105,150,52,224,153,167,40,13,34,58,46,80,253,96,59,128,91,51,108,48,71,54,107,53,140,119,146,66,238,142,0,135,212,222,190,138,111,221,114,50,117,142,208,210,27,43,142,29,146,92,19,249,47,190,151,0,34,225,40,172,141,181,210,204,54,170,32,220,189,20,227,102,187,38,166,117,83,174,80,129,154,198,81,75,24,29,152,246,243,141,83,171,246,239,247,169,91,38,173,116,239,246,178,8,182,150,134,207,99,48,221,194,229,109,71,117,114,156,56,86,153,6,181,32,200,234,163,251,210,233,158,253,35,157,213,116,236,10,194,22,222,160,90,137,206,173,31,72,1,216,167,238,104,186,199,93,219,110,32,146,224,172,211,130,66,118,213,176,209,95,240,226,117,252,94,160,231,52,85,144,230,0,204,28,210,217,131,250,94,202,61,3,215,208,121,195,178,227,69,85,21,0,141,152,233,33,235,21,22,217,202,186,156,46,81,236,182,108,48,238,52,208,18,255,241,7,250,106,134,153,47,198,0,129,44,19,163,171,131,50,42,148,92,252,178,61,197,40,8,190,86,221,181,38,54,88,232,148,39,24,67,157,247,179,110,202,28,65,69,93,48,99,95,103,136,243,111,190,233,161,153,3,100,84,94,177,114,7,226,129,218,170,215,94,179,158,178,109,220,233,237,209,187,178,67,76,140,84,176,221,160,62,117,43,204,81,15,42,46,244,236,105,103,192,228,26,111,136,111,164,160,44,150,79,96,240,76,230,44,227,68,102,150,241,116,238,72,234,113,254,46,80,67,246,247,95,251,46,162,174,84,220,212,253,25,177,119,111,243,212,129,209,185,10,218,57,157,245,141,30,165,51,111,208,27,155,240,116,148,215,233,141,55,189,25,145,187,89,17,54,90,74,167,131,175,54,132,115,154,123,189,80,191,123,129,144,49,161,237,229,65,239,70,102,208,172,236,130,128,221,121,222,75,96,117,167,147,140,72,145,237,77,58,55,243,157,253,144,11,253,13,201,207,43,194,73,92,182,211,201,87,101,50,175,117,138,203,28,45,147,75,8,70,166,202,179,132,101,213,93,171,122,80,39,74,129,27,82,174,11,64,77,125,130,38,110,81,193,136,163,90,18,83,56,106,115,143,51,104,68,171,197,127,64,164,212,182,72,45,125,114,154,231,202,240,112,222,90,108,167,106,247,143,100,171,140,113,137,41,111,157,103,138,180,13,97,45,145,46,64,206,125,216,65,240,128,231,106,230,50,244,170,140,91,185,218,150,178,231,57,139,57,173,8,251,239,128,246,228,167,127,113,241,196,44,45,252,134,232,47,152,170,27,202,69,3,202,238,206,84,183,177,27,166,171,175,229,135,231,172,62,16,146,227,39,72,215,183,92,5,99,60,218,235,244,210,185,23,241,61,37,226,65,218,22,3,149,62,87,238,90,67,253,95,82,55,108,205,105,207,135,31,149,193,109,32,244,153,62,61,139,135,206,121,86,42,155,2,191,175,214,62,249,118,182,251,4,155,206,7,159,55,132,49,129,109,90,119,223,150,126,104,146,123,181,223,235,244,162,84,54,190,106,191,186,230,165,44,7,41,212,109,246,18,138,28,80,200,118,88,94,252,174,245,23,88,146,135,238,93,45,16,168,214,252,179,181,228,193,203,36,201,205,92,38,125,200,53,146,127,117,84,11,204,5,168,220,41,32,47,118,204,223,254,101,81,215,53,188,132,185,252,49,137,70,191,149,140,220,62,65,254,182,204,71,183,142,93,69,193,102,95,128,1,7,243,1,73,127,222,38,113,172,62,253,132,231,40,199,95,67,191,244,156,49,13,124,159,54,154,127,122,7,157,83,70,235,149,244,208,199,184,200,191,66,254,4,193,108,35,246,25,86,214,238,129,177,158,120,50,246,70,9,189,234,47,170,53,249,251,31,94,218,222,82,107,36,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a0facfe-998c-404e-bfe3-0ab89f11f400"));
		}

		#endregion

	}

	#endregion

}


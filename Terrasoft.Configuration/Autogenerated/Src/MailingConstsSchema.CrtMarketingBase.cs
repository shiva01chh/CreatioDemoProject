﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingConstsSchema

	/// <exclude/>
	public class MailingConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingConstsSchema(MailingConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dbe56edb-a5f3-493d-98f2-d26bb8f618f3");
			Name = "MailingConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c79d6b8e-4dfb-4af0-8a52-3dfabe5c47b0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,91,91,111,227,200,177,126,158,5,246,63,16,115,94,118,129,244,110,223,47,231,228,28,160,175,155,61,103,102,103,50,158,65,30,130,32,160,37,218,195,51,146,168,144,210,110,156,96,255,123,170,73,201,23,217,146,108,137,9,226,7,219,18,201,234,250,186,170,171,190,170,110,46,202,121,213,45,203,73,85,124,172,218,182,236,154,171,213,119,190,89,92,213,215,235,182,92,213,205,162,248,251,215,95,189,90,119,245,226,186,184,184,233,86,213,252,191,190,254,10,190,249,143,182,186,206,87,253,172,236,186,255,44,222,150,245,12,110,129,39,187,85,215,223,240,253,247,223,23,191,237,214,243,121,217,222,252,207,230,51,92,94,149,245,162,43,38,249,190,114,181,88,117,197,85,219,204,243,231,187,17,203,89,49,107,154,47,235,101,247,221,86,206,247,247,4,45,215,151,179,122,82,228,231,225,207,36,143,255,112,248,94,227,71,227,247,95,108,238,235,31,174,138,111,222,150,237,151,106,5,95,124,91,160,226,247,235,106,93,77,191,187,125,246,254,152,59,131,182,85,57,109,22,179,155,226,135,117,61,45,220,122,246,37,206,65,242,5,92,93,119,131,156,31,167,197,127,23,139,234,151,254,150,111,94,91,170,92,48,73,34,69,19,67,220,82,138,116,144,10,25,239,130,23,154,107,79,200,235,111,135,169,125,185,234,241,175,203,186,29,67,247,141,160,29,229,189,78,38,40,42,80,178,26,148,23,74,34,237,168,69,160,182,9,209,91,236,69,60,91,249,162,94,20,203,182,185,110,171,174,27,15,200,226,253,70,228,14,36,238,133,137,50,42,228,35,224,226,194,97,164,99,210,200,17,21,153,23,222,91,170,79,135,244,126,86,46,22,99,216,99,35,104,71,121,102,104,96,30,180,213,65,89,196,169,35,72,11,229,81,228,49,49,153,140,54,54,253,27,40,31,218,242,106,181,171,58,5,167,9,146,32,166,12,69,220,97,137,44,1,167,138,54,145,64,148,4,221,213,233,170,191,41,215,139,201,231,49,116,223,74,218,81,95,41,152,91,143,61,120,12,118,136,99,203,144,99,28,208,4,233,148,49,146,27,199,65,253,226,68,253,125,51,95,206,170,213,24,0,82,189,168,187,199,0,56,5,11,24,70,145,177,65,2,10,2,255,25,129,145,148,52,37,103,169,23,204,159,1,224,125,91,45,203,54,95,93,53,249,134,118,117,62,146,139,44,102,119,253,122,25,41,177,65,163,72,57,132,36,41,192,143,108,242,136,48,66,147,81,158,11,58,196,211,87,175,78,2,242,135,178,206,255,22,151,213,85,211,86,69,87,45,166,25,210,117,253,115,85,148,197,228,115,185,128,140,217,99,108,150,197,124,16,116,62,212,205,168,174,31,244,2,198,220,181,158,156,86,186,186,156,34,34,39,21,226,6,99,116,201,176,65,120,202,174,38,10,87,21,197,229,25,11,63,27,111,117,107,188,102,121,62,32,7,87,191,128,196,29,28,82,107,41,32,18,32,43,9,88,143,8,141,12,113,30,178,161,103,88,50,195,2,117,103,224,40,215,29,44,161,98,4,207,107,150,203,199,169,92,155,200,4,76,61,139,130,64,8,147,144,53,242,58,210,216,134,68,140,98,58,158,17,194,54,99,158,63,245,191,43,219,233,211,0,20,102,42,72,22,145,10,74,195,236,83,6,179,143,53,24,131,19,15,177,65,192,186,58,51,125,108,157,8,92,248,55,227,4,128,44,246,17,146,24,33,139,88,43,16,177,144,254,32,28,71,112,33,158,32,38,91,198,162,39,218,70,123,134,41,242,162,191,130,27,214,109,53,2,35,105,219,166,221,93,207,218,83,108,45,112,15,170,20,68,49,130,145,115,212,163,148,12,227,137,56,48,205,25,174,100,39,43,8,87,231,107,62,200,217,13,192,92,66,148,133,185,102,92,68,224,32,209,33,205,180,64,218,71,166,153,52,198,9,250,60,213,129,157,45,129,183,239,161,33,103,104,255,97,35,248,105,18,69,56,176,13,137,41,138,46,0,137,194,64,162,12,9,2,152,136,9,146,50,200,43,24,63,51,19,238,65,208,251,207,180,186,186,170,206,228,230,91,32,161,186,202,53,218,108,7,73,0,11,88,101,96,41,11,15,94,196,93,4,122,14,164,132,122,105,179,59,121,30,158,73,207,247,0,241,57,219,205,102,123,65,252,241,221,101,215,100,222,242,167,23,67,26,68,63,102,184,196,218,24,168,70,2,8,23,226,44,37,100,52,6,11,165,36,157,48,66,58,243,204,4,113,11,233,30,140,98,186,238,147,247,164,153,207,215,139,122,50,212,185,179,122,94,159,69,87,182,152,222,100,65,255,10,72,79,89,9,208,125,179,94,116,235,203,110,210,214,151,240,105,86,119,171,111,199,128,181,149,255,41,75,223,1,231,92,114,204,112,133,4,7,92,16,214,48,208,250,8,5,35,151,9,19,43,120,148,97,36,112,245,226,231,114,6,250,85,89,183,81,129,253,56,72,238,175,101,124,89,208,171,59,140,2,152,127,128,117,6,201,198,7,196,149,247,8,88,12,68,188,168,184,11,52,96,28,240,104,24,39,77,219,86,147,213,63,5,229,70,246,62,156,73,67,125,73,61,69,94,67,121,195,67,0,91,2,97,67,1,38,128,147,72,172,123,46,57,59,138,243,18,34,243,151,127,2,70,151,229,238,195,167,83,10,81,36,140,188,83,80,250,7,3,248,148,80,72,69,174,184,230,6,0,62,179,122,222,131,239,135,106,81,65,148,134,203,127,89,87,221,106,12,10,177,5,248,97,16,153,224,171,199,93,26,74,161,180,6,74,170,121,12,57,13,48,112,77,44,16,198,196,9,133,29,144,212,103,146,137,253,249,108,148,248,152,229,236,232,110,188,144,193,101,39,35,18,146,49,211,192,225,40,240,82,194,181,195,216,75,233,245,153,201,248,67,245,255,224,243,227,228,225,173,172,93,54,26,2,241,49,47,23,23,28,20,6,194,34,109,44,5,94,231,83,112,145,177,160,210,185,32,38,192,196,166,197,229,77,110,149,253,92,87,237,24,112,158,108,88,2,16,167,18,48,35,103,44,84,57,146,89,4,165,141,64,80,105,83,7,25,44,70,241,76,106,125,192,155,114,18,30,17,200,251,166,3,171,188,207,2,167,213,46,215,214,198,88,171,184,69,74,11,159,59,176,18,1,73,242,72,66,201,201,181,76,209,57,115,22,160,77,250,40,202,233,52,55,28,171,81,22,252,70,232,46,22,25,4,133,21,141,112,116,224,95,6,106,57,167,189,64,66,8,202,172,103,68,97,113,38,119,109,174,86,133,107,214,16,79,71,89,242,32,110,144,182,187,240,29,148,211,137,57,36,49,48,86,30,53,132,175,68,192,235,36,172,249,228,132,75,234,188,100,115,177,44,231,163,32,0,57,187,188,219,139,20,131,196,136,123,0,192,165,11,200,37,66,145,74,44,196,228,49,212,64,116,176,194,51,154,80,123,212,255,116,71,229,198,64,241,20,119,179,82,225,152,39,158,18,41,1,11,20,113,38,130,49,180,54,152,120,107,188,101,207,108,7,236,193,144,59,17,35,250,82,22,247,164,47,121,103,141,206,157,124,70,29,20,67,58,41,100,40,143,217,30,44,106,7,101,146,211,231,173,138,119,203,234,204,206,248,22,196,32,105,7,0,84,6,144,238,4,120,16,183,224,80,154,4,164,3,78,40,166,168,149,37,70,3,166,243,0,188,169,129,111,77,64,205,47,163,208,173,44,232,17,10,73,45,214,82,75,228,61,6,127,114,28,80,232,72,129,68,134,196,3,135,106,71,157,199,67,62,128,86,55,219,246,210,56,249,28,4,126,108,158,104,184,6,230,133,77,80,215,112,236,242,218,176,144,220,45,228,117,155,188,73,220,184,160,159,187,109,183,47,60,13,29,186,98,94,46,214,229,108,118,51,74,168,26,100,190,221,136,124,216,245,96,148,115,72,228,40,112,136,84,156,58,200,28,60,194,66,49,14,115,108,157,50,236,60,242,187,5,244,205,170,158,87,91,35,21,213,176,29,55,10,201,223,140,176,221,54,124,16,202,156,167,30,7,224,242,201,65,142,55,94,3,5,54,17,8,25,80,23,157,188,194,156,31,70,247,105,81,3,195,46,214,93,213,22,48,248,85,211,2,224,197,180,173,103,179,162,94,172,170,235,97,139,250,4,28,91,49,159,186,199,212,196,58,194,56,75,80,145,8,157,213,6,123,8,32,142,88,104,39,146,196,80,111,178,35,70,1,194,81,94,195,124,87,243,229,44,119,2,231,229,164,109,114,196,250,5,106,145,151,43,219,79,248,199,141,176,183,89,86,247,190,108,129,177,253,48,107,46,31,53,160,72,32,130,104,72,30,216,115,168,168,72,166,35,20,200,188,145,130,39,206,9,97,246,88,3,106,159,254,57,96,129,145,97,228,122,117,51,34,142,216,11,220,205,132,192,55,156,102,12,249,4,5,8,15,12,40,162,6,138,8,105,94,59,66,128,55,38,121,34,142,204,220,151,53,12,60,34,134,254,52,197,100,183,148,2,30,75,41,134,242,54,49,233,160,128,34,144,15,49,24,131,120,153,164,136,148,7,119,172,49,187,15,196,61,50,50,34,140,123,82,119,160,96,32,88,224,250,121,115,72,1,57,196,44,151,86,16,172,156,182,202,122,155,180,59,202,76,158,1,229,187,79,31,222,140,2,231,158,204,79,237,238,26,97,134,122,149,60,5,74,146,251,229,18,74,116,75,173,68,137,70,109,2,230,138,50,121,108,195,18,242,84,215,44,250,160,180,128,191,96,123,8,240,219,46,102,185,105,99,174,110,150,213,67,2,255,114,112,119,116,253,167,102,97,251,97,134,177,119,13,36,185,115,30,120,47,14,132,231,125,60,140,140,77,14,5,129,121,164,202,123,231,143,44,252,151,64,186,199,35,95,14,233,142,53,30,134,196,29,84,34,46,228,61,101,7,49,32,49,143,44,20,246,136,233,192,136,86,82,248,99,117,239,75,32,109,107,198,222,155,94,14,234,126,199,242,48,172,8,245,161,163,24,214,14,99,121,211,50,5,100,52,48,0,194,3,118,73,224,168,211,136,150,218,54,72,94,142,104,251,228,17,52,216,42,105,57,80,76,147,209,8,193,32,97,74,139,136,48,212,112,137,141,85,71,98,220,139,150,82,181,58,135,159,109,121,216,97,72,41,226,220,65,7,179,64,156,131,220,131,53,114,94,8,132,165,22,84,59,26,34,23,135,33,109,210,65,177,9,66,203,30,66,215,239,224,61,12,120,103,113,230,205,40,247,197,237,156,21,51,92,37,13,145,154,169,28,18,40,212,242,14,120,88,180,6,160,88,237,148,126,230,102,20,24,161,186,110,218,27,80,62,143,62,180,137,79,154,255,174,219,156,208,184,67,177,145,189,75,196,124,132,154,5,66,51,149,253,169,18,168,32,173,203,59,253,130,90,136,101,12,248,254,51,155,94,247,148,255,216,214,215,215,64,39,79,213,127,243,124,53,44,243,99,16,104,72,148,123,74,145,19,6,42,22,99,56,178,216,7,20,105,178,36,232,232,67,60,210,80,185,155,236,98,214,159,130,42,154,193,151,208,246,243,24,197,10,172,138,114,61,27,142,89,189,235,229,239,150,145,73,81,79,28,71,154,228,163,86,49,25,88,16,20,35,13,37,10,92,129,138,210,31,89,227,7,128,212,176,50,150,64,201,174,106,112,223,92,169,156,181,75,158,15,138,173,103,213,116,63,24,3,92,140,6,205,129,89,66,212,226,152,39,192,65,37,10,76,169,200,181,145,74,29,41,76,30,120,209,99,60,243,121,53,173,193,35,78,50,202,70,246,176,97,178,149,116,192,52,137,68,77,115,158,215,26,12,194,45,97,72,195,234,64,148,58,98,53,209,80,71,30,169,138,143,160,25,193,58,247,49,221,26,232,0,38,97,153,143,78,41,4,148,198,32,14,4,13,242,190,228,40,41,72,252,66,71,78,237,17,174,121,24,211,112,204,185,156,47,203,250,250,148,242,241,62,158,4,178,252,70,212,1,72,68,69,160,156,176,130,160,238,5,72,210,56,8,202,140,34,8,12,66,74,35,176,166,71,66,241,197,114,86,175,128,60,119,171,205,1,147,113,78,135,102,169,135,206,183,2,83,129,32,172,48,138,57,2,115,88,32,176,244,149,67,66,98,184,162,100,242,254,72,29,246,132,226,163,156,13,189,211,124,207,1,81,134,163,34,1,180,14,38,171,110,141,69,90,18,152,120,105,1,147,48,129,152,147,231,60,119,83,6,183,26,9,195,254,131,85,24,220,67,25,159,144,181,52,119,36,148,133,213,0,102,80,193,73,43,73,100,44,249,23,195,24,231,116,235,157,250,251,142,184,178,16,192,235,13,144,67,155,247,119,37,68,39,96,133,80,148,112,78,12,23,210,99,119,172,210,186,168,174,231,121,127,106,224,133,245,223,202,91,50,149,129,124,90,78,203,147,216,237,70,236,160,254,70,202,110,108,181,76,226,64,61,34,178,239,5,89,96,132,68,80,136,173,92,153,20,60,246,228,72,218,123,134,238,192,80,198,80,254,137,131,157,28,8,134,140,14,17,149,15,85,41,10,158,143,129,64,97,141,77,224,134,113,157,142,116,178,14,107,159,247,191,235,182,234,138,245,56,48,182,242,246,192,201,126,4,169,78,33,226,76,230,32,86,229,110,41,228,61,163,19,148,26,92,144,116,100,207,208,206,234,178,235,203,140,190,243,176,121,221,37,247,68,33,83,44,202,121,245,178,83,170,221,170,63,92,157,19,192,79,240,112,223,119,248,191,42,183,120,95,167,15,239,222,254,249,39,251,54,190,62,89,159,33,115,157,170,208,134,214,237,104,20,223,218,31,223,28,84,41,3,41,154,171,226,47,107,136,70,127,43,186,77,178,110,115,184,3,166,153,219,55,151,183,76,238,133,175,134,108,212,187,141,30,191,239,199,184,184,29,2,180,220,119,237,160,206,255,219,92,22,215,109,179,94,14,54,28,230,115,56,4,126,210,252,237,40,1,226,127,200,210,251,169,1,29,55,85,197,65,149,126,156,230,38,41,80,166,54,79,230,64,209,135,51,109,197,234,115,219,172,86,125,93,50,111,166,131,186,167,87,83,89,112,127,196,237,227,173,216,183,89,234,131,24,28,136,164,28,88,7,11,57,138,121,8,96,38,228,190,151,15,28,11,26,168,141,250,88,12,126,8,232,118,187,161,29,42,247,215,239,86,159,193,72,39,32,232,31,188,183,245,147,165,61,200,125,80,94,80,197,50,57,143,34,47,122,131,180,48,17,121,225,176,8,158,66,141,24,206,212,253,15,121,59,225,67,181,106,111,78,1,144,159,238,31,62,0,66,224,24,188,204,201,3,71,8,196,193,98,4,149,183,71,193,18,11,73,196,225,68,217,153,32,178,83,94,54,127,45,222,183,205,229,172,154,159,130,100,35,98,35,225,0,28,35,152,86,196,36,164,172,135,250,137,104,9,54,201,135,132,130,165,81,209,200,4,59,82,213,218,182,45,111,50,14,176,254,131,83,211,235,14,210,201,47,159,171,197,38,252,77,128,107,53,171,226,178,202,39,83,38,249,32,199,237,121,209,171,58,191,155,216,231,162,103,129,205,186,255,241,79,69,202,143,93,108,135,234,95,78,124,117,93,173,54,255,189,106,171,213,186,93,100,176,112,239,230,187,87,251,222,203,251,205,193,99,254,143,174,222,81,164,65,238,175,189,197,95,253,154,127,231,95,191,14,239,114,66,248,31,94,231,252,250,171,254,155,175,191,202,63,255,0,8,37,27,191,27,58,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dbe56edb-a5f3-493d-98f2-d26bb8f618f3"));
		}

		#endregion

	}

	#endregion

}


﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailMiningServiceProxySchema

	/// <exclude/>
	public class EmailMiningServiceProxySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailMiningServiceProxySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailMiningServiceProxySchema(EmailMiningServiceProxySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e91d9edc-05b9-4672-95b3-5fa7bd473efa");
			Name = "EmailMiningServiceProxy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bae6174e-6d8e-4782-b180-300a95031ded");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,90,109,111,219,70,18,254,172,2,253,15,27,21,104,41,64,71,59,197,29,112,176,37,5,142,98,39,106,226,23,68,202,5,184,162,48,40,106,45,237,133,228,178,187,75,57,170,235,255,126,51,251,66,46,105,82,177,219,11,174,249,144,136,203,221,217,217,217,103,102,158,25,38,139,82,42,243,40,166,100,65,133,136,36,191,81,225,148,103,55,108,93,136,72,49,158,133,167,105,196,146,115,150,177,108,253,237,55,119,223,126,211,43,36,252,36,243,157,84,52,61,110,60,195,218,36,161,49,46,148,225,107,154,81,193,226,7,115,222,177,236,215,7,131,23,84,61,24,91,208,207,222,224,84,80,212,40,60,131,127,10,65,23,124,189,78,96,188,154,176,78,248,50,74,142,142,166,60,77,65,241,119,48,161,246,254,130,222,42,208,11,143,248,147,228,89,245,226,61,149,106,190,137,68,94,13,249,214,64,105,237,111,106,118,202,224,172,155,148,102,170,125,174,160,93,227,117,65,157,179,78,51,197,20,163,178,115,194,89,20,43,46,58,102,156,243,140,225,91,223,32,213,219,203,147,66,109,102,153,162,235,82,9,152,245,157,160,107,120,32,248,66,220,0,72,142,200,204,131,195,156,138,45,139,233,149,224,159,119,122,254,193,193,1,25,201,34,77,35,177,155,216,231,114,45,185,225,130,196,81,130,119,70,164,89,74,248,13,161,40,144,164,90,98,232,132,28,120,82,242,98,153,176,152,176,82,80,183,14,189,59,173,71,169,248,57,85,27,190,146,71,228,74,203,48,47,155,90,234,129,147,60,79,192,114,100,25,169,120,67,4,253,181,0,76,104,149,37,85,165,154,50,44,5,28,52,37,140,242,72,68,41,201,192,161,198,125,51,187,63,121,199,164,183,90,203,203,5,143,169,68,251,135,163,3,189,166,18,33,40,32,59,147,147,87,76,187,16,136,39,183,76,109,172,141,34,73,62,209,29,137,178,21,8,42,224,239,85,164,34,28,221,70,73,65,65,154,91,142,242,42,17,35,13,156,221,144,188,166,74,91,206,1,9,96,159,131,63,208,9,121,137,167,158,194,221,4,179,211,172,72,169,136,150,9,181,235,38,86,249,193,177,181,45,205,86,198,188,250,249,222,32,165,62,232,236,63,77,34,9,214,127,42,102,94,70,146,18,150,230,9,69,119,210,128,68,35,142,36,165,36,22,244,102,220,239,130,64,255,96,210,138,161,159,95,209,155,168,72,212,75,150,173,96,73,160,118,57,229,55,65,151,152,193,224,151,10,120,49,30,162,235,12,100,159,75,52,225,8,126,46,85,148,41,4,164,96,219,72,81,243,62,55,15,36,198,247,68,42,161,195,93,194,139,149,149,39,79,174,102,111,225,234,199,164,223,50,220,63,238,20,98,39,106,13,175,34,129,168,51,62,129,162,214,13,60,104,20,236,17,230,157,243,67,6,193,56,222,32,76,64,30,4,190,11,128,61,202,212,88,185,54,222,124,13,171,51,72,6,215,16,102,184,128,167,34,83,253,118,20,149,38,58,99,52,89,117,217,71,34,22,98,240,206,104,197,179,100,71,102,16,226,201,117,2,127,141,9,252,60,143,178,104,77,5,228,29,133,177,159,138,160,239,169,220,31,212,78,86,10,249,0,177,104,106,20,69,5,174,139,218,115,251,154,25,102,140,41,4,140,76,145,235,141,82,185,249,221,62,121,193,82,58,207,35,16,109,195,10,14,240,66,129,210,238,85,120,38,120,10,106,22,138,202,224,159,29,138,206,140,165,223,211,156,11,8,133,228,58,173,63,143,141,187,153,44,176,67,43,140,26,75,38,65,135,19,215,17,42,10,148,240,152,168,57,131,156,194,162,132,253,6,145,147,105,108,155,152,158,107,215,80,220,5,174,44,74,118,146,73,114,75,151,46,244,63,54,146,214,175,163,63,89,108,40,193,49,18,151,131,181,56,106,157,182,195,39,131,198,109,215,165,15,8,242,155,94,175,129,1,176,108,11,40,122,236,134,4,207,106,38,95,136,29,88,189,134,58,127,243,10,52,253,33,65,0,120,208,25,184,189,123,222,32,108,92,173,113,155,104,26,68,171,241,192,192,5,3,113,207,70,227,206,235,5,53,114,42,208,215,59,60,108,54,91,81,29,245,173,222,31,69,148,231,136,53,214,58,126,252,152,181,29,195,227,137,177,117,187,100,242,226,5,9,186,222,141,201,107,77,245,32,105,207,169,82,96,102,233,88,33,220,239,156,34,26,20,117,175,206,184,208,244,230,199,67,99,224,23,45,126,210,174,227,4,174,242,51,248,13,192,247,36,198,164,221,31,24,17,71,79,16,49,248,146,207,85,36,197,191,145,86,127,131,141,36,81,224,1,16,248,145,11,124,45,39,170,145,145,147,156,105,222,129,76,4,81,155,64,64,194,116,128,60,68,9,64,58,62,220,110,152,50,133,132,108,16,145,70,240,182,185,4,78,98,146,215,227,60,114,27,9,173,195,152,4,70,192,0,74,132,242,238,65,216,191,144,2,5,245,197,195,246,108,57,168,220,23,77,56,147,23,92,93,20,73,114,41,78,211,92,237,130,202,21,205,142,56,105,33,88,90,115,180,158,57,34,190,60,246,28,207,29,118,203,217,138,76,55,52,254,244,30,98,62,19,116,117,133,198,165,0,38,25,160,17,173,25,108,48,252,32,18,19,17,236,112,148,51,208,212,233,81,77,2,109,90,207,221,8,88,67,163,190,23,134,116,92,151,186,160,178,52,192,26,165,18,55,180,155,135,218,10,158,145,170,237,209,86,173,134,106,164,162,240,117,84,172,105,240,37,190,48,36,207,237,54,61,181,17,252,150,100,244,22,82,74,204,133,128,115,212,138,162,211,207,49,205,241,71,240,180,67,213,174,204,88,21,163,71,9,190,134,225,188,83,155,201,205,19,147,239,191,39,54,210,104,243,207,228,43,38,241,84,171,81,85,255,149,19,0,218,58,242,76,254,63,166,106,1,127,75,174,112,144,125,88,29,152,26,232,74,96,60,165,246,49,48,69,129,73,236,174,176,104,71,173,25,212,19,95,242,21,218,221,91,132,198,91,0,9,95,77,121,82,164,153,134,241,200,44,129,168,139,243,157,159,90,57,169,92,227,252,71,72,89,114,158,128,140,153,124,163,210,196,72,34,47,72,127,3,79,125,160,235,253,60,137,88,214,175,9,151,16,154,117,94,121,180,134,115,189,162,161,163,17,163,173,8,178,204,83,8,25,68,64,158,208,163,39,43,200,0,82,186,72,130,81,205,149,154,99,125,165,93,151,112,231,121,180,111,76,252,109,189,253,188,52,144,53,149,29,63,113,168,55,215,99,71,231,45,170,234,39,131,143,99,63,198,89,21,59,227,28,144,109,93,58,184,122,114,110,82,81,240,164,18,20,236,2,245,153,3,207,92,27,244,101,193,18,188,23,96,248,231,96,54,32,247,214,76,181,215,0,201,45,19,60,67,215,11,47,232,237,59,150,81,231,200,192,161,20,87,81,226,246,145,32,192,236,20,78,177,28,105,76,155,23,144,230,233,138,174,26,211,2,97,215,3,107,33,238,119,168,33,1,17,66,175,146,178,185,231,25,156,243,137,146,112,9,68,14,43,169,58,118,8,76,7,174,8,79,6,206,81,107,81,216,188,79,38,147,73,191,107,29,48,160,52,2,94,186,64,181,202,93,129,113,220,29,222,223,61,191,7,54,90,55,210,144,116,155,180,83,120,105,187,35,98,254,212,133,151,175,255,144,112,99,75,39,249,129,112,243,122,159,100,12,233,254,173,76,200,97,25,146,59,236,252,138,42,221,180,193,246,13,22,176,242,200,25,184,231,119,73,108,72,48,115,172,28,15,102,31,55,84,208,224,211,22,239,251,211,246,193,77,27,121,189,112,78,177,109,106,231,217,68,236,14,111,188,244,7,56,242,15,33,57,197,109,72,106,246,129,27,124,126,31,246,173,79,3,97,217,134,152,180,128,72,34,38,188,192,53,172,246,62,245,244,28,184,3,181,155,192,234,241,19,103,89,155,147,13,235,103,238,22,214,133,217,209,104,84,154,20,203,120,163,91,224,173,95,112,227,234,129,19,126,79,104,2,206,211,117,115,143,222,105,150,221,240,253,27,61,162,156,250,107,181,23,9,181,65,181,217,102,36,46,218,146,180,128,249,75,10,1,53,194,32,135,140,190,44,229,193,125,116,54,33,85,226,28,18,147,38,160,76,64,36,201,175,218,176,212,242,168,35,47,182,207,215,108,195,135,39,98,93,32,6,61,86,86,18,30,172,107,128,27,73,40,70,104,230,90,174,64,93,72,6,147,97,183,82,120,247,126,95,160,84,229,14,16,78,98,127,6,193,230,6,184,199,250,193,54,182,31,241,191,111,199,122,149,145,9,53,54,55,62,101,39,71,68,44,250,116,193,226,91,56,112,72,179,243,254,116,69,3,98,190,3,219,93,156,46,206,222,159,156,159,126,188,124,255,214,116,1,170,166,71,136,221,95,83,235,84,178,112,29,58,254,158,201,120,246,15,130,121,229,138,222,13,0,204,110,30,44,171,90,112,1,228,235,65,163,51,23,234,68,121,206,146,132,73,10,247,188,146,199,15,36,0,149,179,61,229,55,80,15,99,175,209,16,45,72,73,213,89,97,77,7,163,251,249,23,23,5,164,227,114,210,37,1,227,60,144,7,26,212,91,143,151,226,7,160,229,9,120,199,206,93,162,110,74,58,194,184,52,132,204,113,75,95,115,211,64,194,47,96,78,112,103,151,120,88,42,105,19,85,248,17,188,91,215,52,251,235,157,246,102,8,38,104,183,168,236,133,123,31,206,244,226,121,204,115,90,63,146,101,76,75,159,100,54,14,117,197,225,28,254,161,61,138,93,91,55,87,160,172,156,242,21,117,151,95,123,29,86,239,43,226,208,37,96,50,38,127,63,60,36,191,255,222,189,197,216,227,25,251,68,61,27,147,127,28,86,83,255,124,153,104,74,222,158,132,112,12,25,39,232,58,100,181,99,140,31,93,14,143,28,149,120,160,172,73,206,101,40,196,136,7,238,102,56,74,57,90,137,251,122,53,125,201,118,252,206,200,144,180,40,235,88,206,177,91,81,103,15,53,214,225,200,150,243,153,56,202,50,174,147,101,204,241,75,148,130,124,185,220,85,159,138,45,19,211,28,186,239,169,244,24,53,170,194,10,227,118,165,157,127,19,111,0,219,213,53,133,31,178,8,124,131,11,246,27,208,96,183,160,178,176,255,218,180,42,43,235,214,53,2,3,43,236,55,31,239,217,236,130,171,51,204,215,45,27,125,173,171,244,111,178,143,75,136,17,82,126,41,198,203,208,36,162,228,113,189,149,137,191,165,150,174,227,160,25,242,120,15,32,154,93,157,82,139,23,164,213,88,229,251,163,61,66,203,107,124,136,169,169,193,146,165,100,150,28,229,81,252,41,36,101,56,139,193,240,26,76,1,80,250,65,133,174,31,125,116,117,121,241,112,127,36,179,68,189,2,96,27,254,238,91,248,245,31,141,66,135,181,190,27,178,212,209,222,202,223,148,157,102,141,2,14,105,183,23,94,213,142,249,10,174,99,75,133,10,95,81,64,133,249,238,116,185,252,15,128,113,180,127,139,73,135,15,184,226,107,193,113,125,217,223,5,223,215,49,19,183,156,219,141,234,48,47,195,220,215,118,140,154,91,92,190,133,40,7,164,37,141,18,96,248,41,6,36,91,78,88,12,193,246,148,109,97,252,111,196,119,33,252,88,0,118,147,24,181,83,38,83,92,20,246,107,87,132,209,190,180,182,233,84,96,74,114,217,63,124,71,179,181,218,84,77,204,38,196,173,186,141,234,11,45,82,228,16,57,159,145,139,34,93,66,33,1,181,74,73,123,2,0,251,0,211,8,250,6,12,70,9,126,49,204,188,137,238,246,141,75,148,126,208,208,106,72,26,154,59,156,183,160,188,237,180,39,192,115,91,187,50,46,131,107,223,106,132,200,203,183,216,10,46,167,162,185,203,42,11,150,96,197,49,248,171,160,164,50,228,31,7,72,89,98,24,170,106,217,224,191,89,94,25,18,130,144,101,168,110,104,128,230,196,99,223,145,198,27,114,239,8,229,130,87,5,75,144,71,12,63,12,18,252,55,180,75,106,99,165,100,163,91,87,231,209,54,19,27,93,204,18,6,237,101,125,219,255,100,209,99,248,231,191,191,222,56,255,40,39,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e91d9edc-05b9-4672-95b3-5fa7bd473efa"));
		}

		#endregion

	}

	#endregion

}


﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailSenderObtainerSchema

	/// <exclude/>
	public class EmailSenderObtainerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailSenderObtainerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailSenderObtainerSchema(EmailSenderObtainerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d19e6f15-46ac-44e4-b344-671cde651a73");
			Name = "EmailSenderObtainer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,88,77,111,219,56,16,61,187,64,255,195,196,11,20,54,16,216,216,107,18,59,216,102,147,192,64,211,20,117,183,61,44,22,5,45,209,14,1,138,242,146,84,82,183,200,127,223,225,151,69,201,148,237,20,221,94,106,81,195,153,199,225,123,51,163,8,82,80,181,38,25,133,79,84,74,162,202,165,30,93,149,98,201,86,149,36,154,149,226,245,171,31,175,95,245,42,197,196,10,230,27,165,105,113,222,122,70,123,206,105,102,140,213,232,150,10,42,89,182,99,243,142,137,127,235,197,56,86,81,148,34,253,70,210,209,181,208,76,51,170,208,0,77,126,147,116,133,81,224,138,19,165,206,224,186,32,140,207,169,200,169,188,95,104,194,48,178,53,27,143,199,112,161,170,162,32,114,51,245,207,206,64,129,178,230,176,148,101,1,170,90,175,75,169,193,184,89,148,223,168,26,133,205,227,104,247,186,90,112,150,65,102,98,166,67,246,126,216,176,91,120,55,140,242,28,241,125,144,236,145,104,234,94,174,221,3,72,74,242,82,240,13,204,230,46,252,29,122,124,91,126,251,72,215,165,98,186,148,27,248,170,58,222,156,167,29,225,125,105,146,105,147,202,119,68,172,42,178,162,240,53,219,93,60,247,48,17,190,67,218,132,253,65,150,107,42,77,182,17,186,61,180,123,223,78,167,93,152,137,156,101,8,67,193,211,3,213,15,152,82,159,69,200,182,108,0,245,80,86,60,135,5,133,37,227,154,74,138,191,55,144,17,69,193,236,93,225,145,70,219,8,113,206,67,210,23,101,201,225,47,69,175,188,53,24,46,246,122,43,170,109,42,122,202,255,120,126,25,210,138,107,198,67,166,152,2,42,200,130,211,252,8,44,51,117,23,111,190,118,27,15,192,234,74,56,222,155,210,178,202,240,106,143,75,57,74,129,112,246,157,130,160,79,128,108,214,68,160,112,203,37,218,82,76,169,164,203,73,63,193,208,254,120,218,113,52,187,178,38,146,20,32,176,16,76,250,93,204,235,79,231,109,177,64,233,221,143,46,198,214,197,94,143,127,210,165,119,218,159,6,92,176,44,107,218,56,69,218,98,129,34,213,26,139,193,126,199,9,130,119,184,150,148,227,253,231,240,196,244,3,248,109,16,174,176,17,196,95,117,34,135,131,110,185,118,229,236,212,114,33,169,206,4,246,161,39,81,167,248,97,210,25,201,177,46,37,121,220,148,46,4,7,201,121,135,90,41,59,171,216,109,197,114,184,165,218,31,46,56,30,216,117,31,113,150,135,51,61,18,25,22,141,229,44,71,88,41,180,216,61,244,160,222,237,142,37,169,174,164,104,238,31,205,212,251,82,95,23,107,189,25,12,173,85,239,178,105,225,22,207,58,195,32,31,9,42,121,48,140,115,17,78,135,170,52,189,8,205,238,28,133,110,144,156,237,163,206,174,69,85,80,105,10,192,133,109,83,155,105,45,142,83,104,102,34,60,251,58,86,167,134,45,97,144,46,42,193,162,231,209,20,157,80,48,155,53,212,183,155,54,208,8,84,59,183,54,252,137,11,96,114,90,113,126,47,93,90,187,195,13,183,200,194,221,116,219,250,48,207,64,57,22,125,19,45,174,230,111,222,68,25,129,201,4,114,127,43,38,89,187,97,4,194,11,14,237,127,207,91,118,5,169,79,162,102,126,195,164,210,247,178,121,211,45,200,151,134,11,159,54,107,154,227,16,83,21,226,51,225,21,189,112,9,153,14,250,62,167,239,177,224,244,135,7,59,13,186,82,237,161,98,91,124,116,185,91,122,142,44,202,219,35,37,170,240,81,53,114,150,247,167,254,98,176,215,25,170,2,203,205,143,37,75,149,111,151,34,213,14,134,134,225,205,94,177,236,50,240,69,82,9,215,110,87,121,40,23,137,90,211,38,179,97,151,183,63,233,162,82,10,137,217,115,23,208,120,198,197,60,250,130,51,3,170,200,210,11,113,155,76,164,72,99,2,25,202,80,165,16,93,64,137,169,31,26,102,59,96,177,236,26,97,71,127,8,172,100,53,227,45,167,29,161,155,118,150,212,129,203,181,157,97,168,33,127,23,184,61,140,142,52,225,95,36,52,214,86,224,65,25,4,250,227,73,219,138,192,129,203,140,250,28,235,129,64,121,100,108,205,144,139,234,88,53,212,59,250,211,143,245,238,189,58,120,153,130,58,248,127,106,15,99,145,31,148,194,220,154,249,100,15,220,250,223,255,68,167,61,133,189,162,8,76,136,141,252,29,110,175,73,53,170,221,156,154,169,251,48,77,211,76,240,84,72,133,203,236,23,154,39,151,141,59,154,9,28,230,149,9,23,31,104,110,55,96,163,197,116,98,89,185,151,57,19,132,207,86,2,63,228,174,112,230,111,247,115,227,22,191,242,42,129,124,54,18,249,29,46,195,170,103,57,156,237,48,238,240,184,114,104,140,62,226,75,240,255,164,226,207,149,228,134,135,109,203,68,23,161,149,254,186,178,238,70,224,71,38,117,69,120,171,186,187,153,56,205,231,35,7,158,189,180,55,115,97,215,144,59,170,59,12,85,161,2,122,120,42,150,155,235,22,77,5,198,64,107,145,213,125,163,233,0,219,135,225,221,182,28,123,202,54,140,206,163,234,104,167,168,214,96,115,114,96,170,243,62,143,57,174,153,171,220,159,81,230,238,195,40,156,190,142,222,61,85,117,182,194,56,233,63,219,236,174,106,42,90,9,71,215,29,35,108,78,176,142,68,190,99,237,159,177,83,163,235,233,110,148,131,83,108,29,114,216,190,128,29,139,24,248,47,184,164,116,221,114,171,205,69,92,195,127,255,1,137,49,197,177,145,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d19e6f15-46ac-44e4-b344-671cde651a73"));
		}

		#endregion

	}

	#endregion

}

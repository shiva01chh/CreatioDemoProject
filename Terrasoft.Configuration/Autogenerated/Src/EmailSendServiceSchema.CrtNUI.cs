﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailSendServiceSchema

	/// <exclude/>
	public class EmailSendServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailSendServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailSendServiceSchema(EmailSendServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae3b2d03-d334-4f08-892a-e59dcebd13c3");
			Name = "EmailSendService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,87,89,111,219,56,16,126,118,129,254,7,174,251,80,9,48,148,62,231,90,56,174,220,122,177,57,26,123,55,15,65,31,24,105,98,19,171,195,37,169,36,218,32,255,125,103,120,200,146,45,123,15,108,128,196,38,57,199,55,51,223,144,147,130,231,160,214,60,1,182,0,41,185,42,31,117,52,41,139,71,177,172,36,215,162,44,162,56,231,34,155,67,145,206,65,62,137,4,222,191,123,125,255,110,80,41,81,44,217,188,86,26,242,147,173,53,26,200,50,72,72,91,69,95,160,0,41,146,29,25,103,237,178,76,33,59,120,24,141,209,210,147,193,114,88,238,14,30,54,2,237,104,242,188,173,218,62,145,16,197,133,22,90,128,218,43,48,229,137,46,229,30,137,75,204,77,68,201,1,217,119,140,144,54,254,241,252,222,1,198,12,107,137,118,191,211,222,88,173,175,64,163,216,26,131,124,16,153,208,245,45,252,168,132,132,28,10,173,130,246,130,34,101,103,236,111,84,72,42,114,27,105,72,78,214,213,67,38,18,150,100,92,41,182,93,81,118,204,46,184,130,166,190,131,87,3,118,112,127,189,6,75,130,54,222,193,61,70,53,43,158,202,63,32,184,4,189,42,83,4,52,188,185,158,47,134,35,246,155,20,11,200,215,25,215,4,115,72,78,112,247,162,76,235,185,174,51,218,67,229,75,80,138,47,161,217,141,238,36,95,175,33,29,145,245,1,225,6,165,167,165,204,185,238,40,216,173,232,23,85,22,35,118,139,180,69,126,193,97,57,19,188,143,254,87,161,244,41,65,66,221,42,211,231,140,190,7,74,75,42,154,97,25,230,113,150,134,236,213,0,113,7,36,100,51,166,185,174,20,133,53,43,110,100,185,148,232,109,120,98,68,31,202,50,99,43,174,166,72,252,242,25,181,240,60,193,227,56,51,5,65,157,71,158,41,56,105,219,69,146,148,210,33,70,1,187,139,221,182,214,181,149,211,178,118,72,6,79,92,50,32,12,147,76,160,61,75,201,26,181,38,84,80,183,196,86,211,167,241,142,212,121,80,192,51,195,10,162,135,138,118,198,114,89,17,170,96,88,41,144,120,80,216,94,165,242,117,54,194,240,100,227,158,187,252,52,228,1,137,254,187,10,132,96,166,166,128,121,146,16,23,252,33,131,52,64,18,36,180,84,90,228,134,76,195,144,253,204,8,147,61,24,239,26,14,118,99,221,193,198,142,45,182,1,89,250,143,54,92,120,230,10,168,55,17,218,229,89,95,200,166,215,131,47,149,72,163,27,46,21,4,45,218,120,115,7,121,16,16,85,194,174,171,200,73,81,250,240,43,54,157,174,127,231,89,5,193,240,10,94,116,215,198,45,240,180,30,122,95,61,228,52,64,83,71,204,55,150,112,157,172,88,16,191,36,176,166,160,25,120,126,247,40,3,19,238,122,104,201,199,47,88,47,252,219,122,9,172,252,49,27,198,68,226,235,194,244,185,131,228,233,237,13,24,138,94,225,51,67,246,41,196,69,189,134,32,140,22,229,220,72,6,225,30,197,77,111,64,228,190,183,248,184,130,108,109,40,184,211,2,243,186,72,86,178,44,196,159,134,110,6,226,87,35,253,63,180,130,35,71,222,96,179,56,200,113,188,5,60,216,77,193,104,39,58,111,87,60,178,192,27,253,233,140,21,85,150,53,117,114,78,231,201,10,57,221,176,210,45,119,122,176,45,124,201,11,52,104,208,205,48,104,94,36,112,81,19,144,96,232,137,219,80,169,211,229,196,84,47,17,118,61,70,19,137,13,14,214,77,208,223,81,38,28,175,22,77,1,41,56,149,101,254,249,98,95,235,108,98,53,48,148,191,95,26,27,155,55,118,75,200,144,114,156,166,116,27,211,53,106,219,116,33,69,30,124,60,249,24,70,241,139,121,185,218,98,13,227,6,131,254,75,216,62,32,190,30,158,179,41,142,53,85,94,152,206,60,181,146,231,193,144,18,224,12,12,195,81,15,168,198,217,155,253,180,31,246,175,15,195,54,84,60,255,134,24,136,162,237,26,126,171,64,110,231,185,175,200,35,236,198,110,131,250,210,118,60,224,101,131,247,176,172,141,89,27,81,52,83,227,236,153,215,106,14,52,182,33,6,108,15,232,211,197,144,172,10,222,76,200,162,126,7,45,161,9,14,34,253,66,83,145,105,144,138,132,131,238,137,165,151,61,191,19,122,133,100,65,87,36,28,184,68,218,51,51,253,72,129,143,60,21,39,138,127,84,60,27,49,39,98,61,55,203,173,155,206,238,250,158,222,42,130,201,236,102,130,117,156,218,224,163,78,223,146,233,239,2,111,215,78,27,52,124,184,234,110,207,33,158,143,212,52,251,129,224,32,89,225,19,114,206,62,133,237,177,64,224,28,220,197,184,165,119,255,233,187,191,96,59,96,76,234,237,51,236,183,131,77,27,126,22,10,167,56,251,12,161,121,242,226,153,227,142,90,221,48,114,74,125,210,45,177,214,149,239,53,38,118,158,53,10,7,219,204,50,201,171,125,61,244,196,238,127,127,189,122,220,237,250,246,37,224,122,52,244,207,167,249,144,128,3,77,177,85,76,35,97,218,24,127,223,204,196,220,153,178,55,105,221,76,212,31,36,44,137,83,238,149,199,127,42,142,217,141,81,178,231,206,128,123,9,59,53,176,133,89,130,246,221,212,0,216,85,252,247,26,166,14,255,72,193,140,186,7,242,127,216,200,209,209,17,59,85,85,78,204,56,247,27,148,41,243,242,83,135,218,106,248,7,54,106,148,142,218,90,93,240,157,114,30,246,255,1,93,217,26,152,53,238,154,3,252,249,11,223,162,231,123,9,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae3b2d03-d334-4f08-892a-e59dcebd13c3"));
		}

		#endregion

	}

	#endregion

}


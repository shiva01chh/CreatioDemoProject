﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailMiningConstsSchema

	/// <exclude/>
	public class EmailMiningConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailMiningConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailMiningConstsSchema(EmailMiningConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d5e5c83-b152-4d68-8555-f21b36618bc1");
			Name = "EmailMiningConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b6327e89-1dee-4b6f-a695-226c016beae1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,90,75,111,219,56,16,62,167,64,255,3,161,30,226,0,174,189,231,62,2,100,99,183,200,162,105,131,58,221,61,46,104,137,142,185,43,145,2,73,37,241,22,249,239,59,28,82,178,44,75,178,228,40,205,37,122,12,103,62,206,124,28,206,136,22,52,97,58,165,33,35,183,76,41,170,229,202,76,46,165,88,241,187,76,81,195,165,152,204,19,202,227,107,46,184,184,123,253,234,231,235,87,39,153,134,75,178,216,104,195,146,247,149,123,24,27,199,44,180,3,245,228,51,19,76,241,112,43,83,54,145,36,82,192,27,120,55,157,78,201,7,157,37,9,85,155,115,127,143,70,73,130,86,73,8,202,12,21,70,79,114,233,105,73,60,205,150,49,15,9,72,24,248,23,198,84,107,82,194,124,105,7,107,144,251,137,198,246,172,225,131,91,246,104,72,74,21,162,212,76,221,115,112,200,143,239,95,136,198,89,193,35,99,28,146,136,77,10,45,101,20,57,12,196,10,96,148,155,239,163,185,113,90,23,78,41,120,105,225,117,125,36,193,254,251,192,185,228,169,209,49,183,107,70,204,38,101,68,174,136,129,107,208,160,104,104,88,68,152,48,220,108,8,143,236,197,138,135,24,61,194,5,89,166,201,169,20,49,23,172,205,127,206,113,87,59,163,111,173,161,119,100,129,179,153,139,44,113,110,108,112,98,62,22,176,36,84,100,52,142,55,19,242,67,195,237,195,154,137,42,48,157,178,112,87,152,44,55,56,165,12,2,208,238,100,31,107,197,104,4,19,219,212,161,190,70,165,224,100,193,30,106,222,143,2,39,16,156,189,239,50,159,40,3,175,75,68,23,102,218,200,132,196,242,142,135,207,70,121,233,148,53,163,116,2,136,18,53,43,105,24,70,187,70,216,147,238,158,198,25,59,179,210,39,239,200,146,106,54,114,79,8,70,238,233,72,118,1,175,13,92,85,162,88,75,40,167,152,49,26,107,73,66,197,86,31,131,125,180,1,153,238,145,239,210,217,168,229,224,254,195,86,46,254,238,168,180,202,226,152,8,72,113,253,34,213,12,228,43,232,242,225,106,20,26,5,86,170,141,89,57,58,174,32,87,80,17,225,29,184,192,12,138,245,147,85,255,5,180,58,208,200,136,3,192,119,134,116,152,1,179,121,118,40,188,46,231,31,116,46,138,117,192,166,153,136,152,58,213,195,130,92,160,214,142,80,75,194,29,0,167,107,41,24,129,44,187,236,155,255,154,225,222,160,206,131,64,81,172,38,203,52,15,121,209,100,67,195,80,102,226,101,147,205,133,179,209,43,217,28,138,96,255,213,219,140,162,148,105,26,133,58,103,154,72,2,7,69,238,232,7,182,124,75,163,72,49,173,135,66,251,23,91,206,156,141,131,144,11,209,222,184,143,88,200,205,136,113,85,118,197,92,18,174,89,37,205,3,7,88,37,11,152,17,84,68,58,119,2,152,13,33,112,182,40,161,134,30,174,232,110,114,249,25,136,59,101,53,37,93,115,101,108,163,0,35,201,3,213,224,214,127,220,140,143,174,212,234,208,124,207,181,186,48,212,136,140,130,92,166,141,51,59,80,105,154,198,124,104,164,23,94,105,11,80,47,82,195,146,58,241,33,178,40,240,12,201,193,4,244,90,107,44,213,146,36,19,121,157,141,109,1,103,245,189,83,77,246,236,208,6,78,182,236,169,203,172,115,161,194,245,101,25,68,67,31,209,24,201,121,255,133,222,96,180,188,81,215,139,140,2,86,236,207,141,128,32,103,17,205,77,207,228,222,128,201,42,107,71,4,9,186,29,207,181,92,242,216,87,12,131,96,242,10,219,97,37,40,84,67,237,134,1,3,176,251,79,43,9,37,28,112,134,172,164,66,182,3,193,227,44,193,93,193,26,182,77,244,28,123,223,95,76,241,173,225,190,252,254,166,238,168,224,255,21,85,77,207,240,85,12,151,181,149,35,184,43,54,10,202,114,238,121,59,201,124,241,247,124,128,94,81,27,54,47,210,13,86,57,189,141,116,22,174,9,36,124,92,11,99,91,219,140,137,150,33,135,230,95,48,243,32,213,191,99,194,76,56,57,27,98,30,101,203,173,179,41,9,118,153,211,197,49,213,88,29,68,175,168,13,156,23,233,2,235,15,185,124,62,36,80,210,6,7,94,87,160,84,242,74,101,192,11,36,149,57,238,156,126,143,223,38,151,139,208,240,251,95,157,86,182,64,250,238,151,68,72,83,170,14,55,172,255,202,221,26,191,18,212,206,190,180,35,20,239,70,65,59,105,156,108,2,117,71,142,134,192,26,181,255,237,215,152,141,45,79,210,152,65,120,159,1,111,182,237,106,119,161,205,202,125,236,33,120,249,135,94,197,76,166,160,82,82,10,200,96,9,113,68,163,177,3,111,142,154,234,240,225,155,122,166,111,165,94,128,226,123,228,118,6,93,95,211,212,71,188,32,199,11,195,173,100,127,163,216,157,77,181,159,120,28,233,119,80,65,243,123,106,88,238,59,188,217,11,196,140,227,233,3,76,225,131,243,227,184,222,228,57,249,27,221,121,77,83,116,177,139,86,231,209,163,60,134,111,152,136,28,204,42,102,230,64,227,228,15,46,94,108,92,18,46,88,52,38,203,204,84,22,51,116,49,182,131,57,118,81,87,189,125,109,237,236,240,179,34,49,10,80,228,192,74,218,2,47,144,14,129,110,158,55,50,173,0,115,169,224,80,32,240,0,72,101,161,145,10,57,228,151,92,253,10,172,154,233,180,20,79,10,38,77,96,115,117,175,198,208,118,114,237,186,213,167,118,128,215,204,172,101,39,170,220,48,5,139,57,129,238,86,16,14,89,148,135,220,216,47,243,247,76,105,171,105,165,100,130,43,214,175,86,127,38,231,150,86,48,61,183,103,24,165,215,181,83,6,177,134,32,226,147,148,42,154,224,135,174,143,1,56,39,56,183,93,119,217,75,19,242,9,242,141,251,92,147,154,77,254,238,129,199,49,89,22,185,54,98,43,154,197,134,120,158,185,161,31,166,168,125,107,204,9,235,157,14,31,106,23,59,208,127,13,217,78,190,4,186,60,108,151,121,133,211,100,202,32,115,21,123,127,67,216,225,95,30,226,122,170,58,48,24,228,19,190,34,118,220,228,74,127,133,125,238,155,154,219,233,143,206,114,5,39,126,230,56,97,55,226,169,24,183,37,208,173,218,124,102,6,211,183,213,54,38,18,146,129,51,179,167,170,108,221,233,50,107,37,31,220,97,146,0,149,60,186,164,218,204,31,67,150,218,172,230,167,53,129,0,37,212,64,153,74,133,77,51,161,61,120,56,253,249,219,211,169,229,71,61,41,198,232,139,54,58,119,255,130,181,119,100,25,101,54,42,110,35,1,224,145,189,6,113,94,21,199,84,179,146,153,136,236,177,38,123,228,26,15,82,151,246,112,217,150,25,172,185,11,220,239,222,102,222,40,235,95,110,125,5,167,161,117,109,113,88,140,21,8,100,100,67,96,225,30,211,117,84,145,129,185,226,81,84,46,165,43,130,7,11,179,54,200,3,224,116,250,175,124,195,211,10,116,87,180,169,242,175,14,27,232,204,65,203,76,133,219,83,135,124,183,49,246,55,0,45,20,250,21,31,18,22,14,90,239,210,223,255,80,2,167,144,87,181,35,159,99,159,215,248,122,68,254,231,9,104,205,254,98,129,169,250,158,206,137,119,98,162,5,156,183,88,3,176,113,15,242,69,154,206,150,133,129,86,180,40,250,54,151,61,220,136,250,113,125,248,136,148,132,191,255,1,207,154,43,61,112,35,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d5e5c83-b152-4d68-8555-f21b36618bc1"));
		}

		#endregion

	}

	#endregion

}


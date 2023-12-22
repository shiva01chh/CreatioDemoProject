﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailClientFactorySchema

	/// <exclude/>
	public class EmailClientFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailClientFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailClientFactorySchema(EmailClientFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bb18ef6c-25c9-43e3-b6da-de0755b0e432");
			Name = "EmailClientFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,88,75,111,27,55,16,62,43,64,254,3,171,2,193,10,80,165,123,108,43,112,157,184,213,193,181,17,59,167,162,7,122,151,43,177,88,145,2,201,149,97,4,249,239,25,62,86,226,99,87,90,171,50,130,2,209,77,179,31,103,134,51,31,103,134,100,120,69,228,26,231,4,61,16,33,176,228,165,154,220,96,90,77,238,9,43,136,64,111,223,124,125,251,102,80,75,202,22,30,226,138,179,146,46,106,129,21,229,236,172,21,32,72,151,124,114,141,115,197,5,37,114,135,248,248,112,139,46,208,167,21,88,6,221,74,0,98,2,50,0,0,228,87,65,22,96,7,93,85,88,202,247,14,85,81,194,148,213,244,108,80,211,233,20,157,203,122,181,194,226,121,230,254,27,40,202,13,22,149,22,140,232,106,93,145,21,72,140,247,147,102,233,212,91,251,247,71,82,226,186,82,191,83,86,128,123,153,122,94,19,94,102,243,212,244,104,244,15,224,215,245,99,69,115,48,4,14,182,248,135,222,163,150,165,232,171,241,123,187,189,107,90,145,2,246,119,39,232,6,43,98,63,174,5,87,36,87,164,64,130,224,130,179,234,25,125,145,68,64,144,24,136,245,178,240,239,153,211,9,217,179,106,67,27,0,148,74,212,218,190,182,100,220,182,136,32,124,19,13,152,4,33,177,128,53,22,120,133,24,144,230,98,88,7,134,135,179,75,134,40,104,199,12,200,196,75,164,150,4,105,8,202,183,24,208,104,20,24,125,46,102,105,92,178,104,131,161,157,145,14,219,96,48,136,64,23,17,76,83,107,240,109,127,48,110,136,90,242,36,226,49,143,140,224,15,162,64,72,8,202,5,41,47,134,243,251,149,90,91,167,135,211,217,110,219,41,181,82,110,165,129,4,157,5,172,161,184,146,195,153,103,5,14,192,228,202,251,6,150,60,104,16,76,163,83,16,85,11,38,103,47,119,244,124,218,172,181,156,51,225,64,222,98,29,128,221,191,140,63,254,11,97,246,189,129,4,176,186,170,154,236,108,176,136,18,114,41,22,26,67,158,124,14,130,176,214,94,100,49,153,198,17,173,71,38,159,3,90,162,44,48,26,90,29,216,93,216,66,225,216,52,1,207,207,189,157,204,178,196,47,167,252,219,214,115,207,132,117,27,116,120,137,104,219,128,183,196,169,59,206,151,113,100,124,228,19,185,149,154,224,152,78,150,151,244,22,255,116,242,75,193,87,1,129,142,161,167,23,6,100,89,208,139,135,29,46,105,62,50,104,62,29,4,108,89,213,35,21,41,57,27,126,208,50,96,15,149,40,58,98,91,34,105,22,152,194,20,48,28,172,109,136,80,15,252,38,252,20,104,197,169,214,179,128,157,157,103,32,50,8,135,32,146,4,68,61,164,45,15,52,69,30,38,74,247,50,204,110,27,237,47,77,138,251,128,40,66,126,241,121,133,178,184,85,221,135,139,45,174,133,101,181,141,138,209,162,110,42,68,222,181,209,208,203,92,172,214,209,239,79,46,21,240,205,119,235,158,136,13,205,201,23,81,141,45,230,142,139,24,163,69,238,171,46,159,127,65,24,35,68,35,246,80,119,80,159,158,184,40,98,93,78,188,67,222,203,42,213,6,194,29,226,246,178,86,203,20,99,196,14,101,199,74,211,244,47,11,232,202,82,38,251,140,1,150,243,125,27,122,193,77,67,119,83,83,11,171,63,219,236,162,28,210,135,41,11,218,186,55,140,24,90,152,121,206,35,87,194,215,134,42,87,71,40,11,105,214,140,121,254,50,83,236,172,102,79,154,237,202,25,202,126,9,251,164,238,48,115,121,13,29,161,22,228,19,195,143,48,82,102,195,219,170,48,235,231,76,145,133,29,218,135,35,155,143,193,187,119,232,69,58,116,126,134,163,195,29,215,115,120,150,29,221,246,91,43,30,116,252,206,154,117,154,236,162,1,58,80,143,58,135,221,214,1,109,171,239,52,124,209,234,94,196,152,3,5,233,255,67,36,103,235,104,62,141,15,41,232,236,154,110,155,63,136,144,135,218,99,68,199,253,221,114,15,81,127,100,89,235,209,57,127,18,117,171,128,164,211,226,113,108,61,220,76,187,94,9,26,65,67,113,204,16,241,31,92,220,32,174,150,88,237,46,156,154,43,138,136,82,63,57,117,211,170,81,141,149,41,173,114,77,114,90,82,224,209,26,38,35,92,33,236,102,7,87,122,165,25,26,14,157,24,153,140,22,195,153,123,230,34,191,25,199,157,218,238,3,49,111,14,89,183,235,241,17,176,207,28,27,42,84,13,142,7,231,192,94,221,252,51,0,121,214,207,97,169,167,209,236,216,53,24,124,248,16,221,212,15,79,247,77,246,130,212,233,7,47,84,114,225,69,222,124,255,47,33,118,235,163,200,250,171,233,130,113,65,62,211,197,82,193,186,235,10,47,28,121,88,65,115,136,148,68,79,75,96,37,40,131,203,134,5,35,97,208,253,30,67,162,210,213,85,180,78,147,177,49,122,228,188,66,254,158,162,36,182,40,75,243,222,59,127,175,113,250,242,28,110,0,122,123,16,239,29,19,118,15,122,200,4,157,128,70,249,162,118,229,61,220,245,234,67,243,246,222,118,202,147,215,239,206,214,126,238,2,124,114,4,147,167,161,159,217,124,245,108,246,191,133,159,50,163,81,43,181,210,80,8,50,255,247,29,244,14,112,102,127,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb18ef6c-25c9-43e3-b6da-de0755b0e432"));
		}

		#endregion

	}

	#endregion

}


﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApplicationSectionQueryExecutorSchema

	/// <exclude/>
	public class ApplicationSectionQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApplicationSectionQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApplicationSectionQueryExecutorSchema(ApplicationSectionQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f43da2b1-c755-46b8-898c-76529770c065");
			Name = "ApplicationSectionQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,26,219,110,227,54,246,57,5,250,15,92,15,80,72,128,161,116,183,125,74,98,7,142,147,204,26,59,151,236,36,217,121,40,138,129,98,209,142,80,91,242,136,210,204,120,7,249,247,30,242,144,226,69,164,172,180,83,160,243,48,136,200,195,115,191,241,208,69,186,165,108,151,46,41,185,163,85,149,178,114,85,39,243,178,88,229,235,166,74,235,188,44,190,255,238,235,247,223,29,53,44,47,214,228,118,207,106,186,61,117,190,1,126,179,161,75,14,204,146,151,180,160,85,190,236,192,188,202,139,143,122,209,164,181,221,150,133,127,167,162,161,245,100,182,219,109,242,101,138,52,103,15,172,174,82,100,32,120,226,170,168,243,58,167,97,128,107,192,80,86,125,16,55,233,242,183,116,45,0,0,228,69,69,215,64,145,204,55,41,99,39,196,224,232,22,149,113,153,214,169,128,220,53,15,176,69,150,28,48,8,119,244,85,192,182,104,111,170,114,71,43,206,241,9,185,17,8,112,95,34,123,217,228,25,89,100,228,43,89,211,250,148,48,254,223,147,5,1,58,225,50,204,211,29,39,114,24,240,146,178,101,149,15,4,158,151,25,61,12,37,116,190,191,93,62,210,109,250,6,28,173,231,132,144,71,42,4,15,220,15,145,14,65,239,246,187,62,220,121,81,147,3,32,130,188,97,154,94,218,2,248,85,185,46,123,161,192,172,244,46,7,161,95,151,89,190,202,105,246,118,128,94,23,203,178,184,0,55,91,87,101,83,120,177,191,160,69,134,46,34,190,113,213,89,60,232,154,255,109,104,181,191,250,66,151,13,184,188,56,242,203,37,93,165,205,166,190,200,139,12,24,137,106,208,87,185,138,22,104,66,11,62,30,19,97,204,9,25,29,192,60,138,127,61,236,254,214,9,114,66,124,36,187,225,113,157,211,77,198,67,163,202,63,129,162,165,46,241,131,84,52,205,202,98,179,39,247,140,86,144,205,10,164,68,62,52,214,247,105,224,148,180,197,7,234,186,175,87,226,81,8,205,2,96,95,167,5,100,140,138,124,72,219,191,67,224,151,185,64,151,86,251,51,100,96,76,174,155,98,121,198,189,109,204,181,210,108,105,149,62,108,232,153,63,133,76,167,83,142,247,232,3,195,181,151,180,174,105,197,46,246,144,158,155,109,33,5,40,232,231,111,65,41,138,29,49,192,111,89,173,83,137,240,165,183,85,90,172,41,144,7,187,130,234,94,172,86,63,255,248,207,159,148,190,28,159,245,39,190,170,172,129,46,205,20,49,249,233,26,214,249,156,76,131,166,86,8,230,155,28,204,123,95,228,53,218,87,25,42,180,14,40,109,34,73,0,178,67,201,76,130,10,155,111,173,75,193,3,229,104,221,132,176,253,245,52,204,132,253,49,145,94,99,30,38,231,231,36,178,87,38,62,158,161,218,215,11,176,123,90,44,233,197,158,123,88,212,9,154,56,62,96,239,57,247,156,170,225,197,215,95,234,14,164,140,200,49,190,109,248,177,21,134,58,10,99,242,21,229,110,28,215,33,29,199,225,80,250,32,64,88,177,12,187,11,240,129,60,221,228,255,167,146,191,25,246,34,34,72,142,142,252,137,187,149,255,53,173,31,203,96,42,251,84,242,58,31,36,160,164,8,199,124,50,203,178,104,180,200,70,99,178,202,55,53,58,26,192,129,86,36,178,87,57,171,47,246,139,44,194,253,56,62,29,134,211,42,151,135,208,91,192,54,165,39,91,98,14,31,74,60,1,198,69,65,150,236,46,50,165,20,63,14,5,7,118,4,100,114,35,210,135,81,248,91,90,55,59,139,231,89,109,32,81,240,18,186,2,232,170,16,185,181,151,123,228,235,72,30,22,31,79,62,21,4,56,55,248,21,18,231,173,168,24,155,142,104,123,6,157,71,179,161,184,25,229,153,205,45,170,210,67,199,22,238,201,151,113,124,248,5,75,0,182,133,186,130,174,242,191,116,211,80,155,69,204,11,34,126,9,101,31,129,211,57,20,192,154,118,118,175,203,170,37,16,217,140,195,57,158,120,36,217,123,39,220,61,28,248,228,16,113,117,200,202,253,30,196,255,86,210,9,225,83,171,127,156,56,26,94,100,215,85,185,69,17,35,3,69,226,118,189,82,90,19,100,230,96,182,40,249,196,19,252,244,208,199,136,105,41,154,82,236,240,150,115,175,68,184,105,191,77,254,29,102,67,214,229,33,209,217,139,60,165,100,76,70,96,111,73,107,81,136,170,2,183,202,12,4,24,73,26,220,238,144,120,208,178,17,7,15,65,93,139,244,194,68,154,226,223,232,99,184,250,62,175,31,111,210,10,178,24,7,137,112,17,110,161,187,180,202,89,89,240,123,66,114,245,177,73,55,22,71,201,189,72,113,90,55,177,37,184,190,1,67,35,212,254,57,177,93,85,3,57,78,107,187,183,70,0,114,84,172,142,98,142,130,243,149,25,78,45,154,181,105,71,11,192,165,215,221,149,63,120,141,233,119,134,133,101,159,5,92,226,207,220,150,103,42,79,241,48,246,119,67,32,66,145,241,179,23,123,64,221,113,27,41,50,46,39,154,185,111,81,23,236,138,163,2,84,203,215,139,15,244,41,191,153,12,228,118,193,201,70,92,64,77,154,69,130,198,216,68,240,199,170,156,65,207,202,160,134,171,49,43,3,67,195,236,75,252,176,236,112,220,57,6,25,136,163,140,130,21,33,78,238,74,206,112,212,83,18,12,190,252,60,252,181,117,224,64,112,121,89,54,153,24,68,94,138,240,41,173,254,88,122,67,60,102,166,186,193,106,37,206,97,116,39,11,54,219,124,78,247,12,141,2,68,160,57,166,222,12,40,71,59,129,252,104,204,115,2,16,124,136,19,74,174,78,77,10,128,241,172,20,216,90,108,65,238,159,254,21,216,213,51,145,112,118,55,187,139,228,23,88,64,110,78,128,157,19,248,50,181,12,75,191,38,188,51,29,197,137,186,169,187,195,167,145,159,77,107,224,50,234,120,216,243,218,179,64,67,165,218,51,91,38,171,234,50,119,244,53,113,193,123,171,64,192,92,242,62,206,244,148,12,51,68,251,125,161,21,24,185,44,216,56,114,123,50,53,140,61,60,59,61,160,102,30,69,1,157,202,142,217,171,143,155,78,167,55,70,104,53,242,124,38,143,109,56,73,52,230,64,244,153,168,172,216,83,92,241,145,233,115,89,18,17,42,17,116,166,169,207,68,214,9,8,133,184,51,118,157,116,220,81,65,154,142,164,189,74,238,170,245,1,76,229,69,61,85,233,67,158,150,3,213,103,249,189,76,50,220,225,37,22,99,216,58,12,147,26,211,78,237,164,36,209,45,92,175,183,195,0,146,245,155,102,179,121,91,189,127,204,107,122,203,223,81,162,248,220,51,255,58,113,14,134,239,126,50,220,130,81,250,55,105,214,200,63,160,250,129,232,228,220,102,85,158,138,201,137,148,36,185,218,238,234,253,80,73,163,97,130,152,222,217,54,22,95,234,42,149,195,67,171,75,18,80,230,46,118,74,22,146,196,217,71,137,243,21,137,188,199,147,57,24,17,106,243,132,252,168,200,183,234,113,165,230,98,187,236,25,177,99,175,79,252,236,114,207,149,3,182,145,86,214,200,103,152,14,206,243,68,56,250,57,244,112,183,130,55,127,23,215,219,144,186,77,174,238,166,199,253,7,205,54,216,236,187,69,252,146,21,15,133,182,210,203,250,206,192,227,184,125,108,154,198,94,176,197,22,141,89,170,217,228,23,101,13,131,86,74,222,63,210,10,188,84,17,229,227,170,48,27,252,41,180,78,115,144,184,61,208,189,174,199,18,179,213,35,31,25,124,36,208,69,94,165,203,199,72,175,113,178,250,203,119,191,119,195,206,192,23,52,31,106,53,172,184,63,99,54,227,209,0,223,9,144,24,115,213,246,142,166,27,105,65,243,30,192,44,3,118,44,23,192,206,133,246,161,157,181,235,218,33,2,151,28,151,47,191,27,56,80,202,60,190,163,71,201,172,216,71,237,46,50,21,86,4,70,31,142,20,152,125,12,183,226,214,129,228,53,172,143,169,32,149,255,208,189,215,15,29,55,9,232,185,171,210,238,125,153,7,151,158,127,104,67,232,91,187,215,16,161,90,163,135,17,60,201,179,200,64,173,5,209,236,70,170,120,169,50,198,39,50,99,210,89,149,250,120,166,240,126,55,237,13,17,230,196,7,87,79,199,58,82,81,204,78,65,174,157,45,195,118,243,139,55,189,28,214,46,170,53,182,253,93,171,235,64,186,107,117,28,255,85,214,48,50,86,215,145,186,238,103,62,75,74,72,17,163,234,71,25,160,102,227,149,38,177,80,122,29,211,56,171,44,178,227,172,239,132,212,189,81,52,224,137,212,127,27,100,23,123,28,56,70,221,150,30,231,13,114,28,217,118,47,248,82,210,122,217,170,172,40,84,18,18,9,119,107,31,104,240,61,136,228,5,233,121,181,105,59,21,217,120,45,205,119,97,23,23,79,40,168,46,209,5,253,59,101,183,59,186,132,246,120,137,8,103,53,178,122,245,101,87,81,198,68,87,32,121,29,27,152,227,150,168,8,16,132,16,105,79,214,7,11,169,216,24,138,249,212,192,171,2,12,165,246,137,35,80,171,35,170,70,88,167,34,131,57,133,252,201,104,224,234,199,170,252,140,19,159,47,75,42,238,118,209,232,77,89,99,251,64,152,148,68,178,200,184,49,36,219,254,145,236,67,89,110,200,32,189,14,246,146,113,192,190,202,8,82,110,9,173,188,94,191,219,133,40,197,242,189,78,102,2,94,255,244,33,252,43,121,69,87,181,102,58,209,127,226,173,112,210,157,147,217,32,9,238,160,22,200,15,63,72,83,249,177,155,176,114,224,51,233,248,70,96,4,62,208,229,190,181,210,69,74,139,255,172,234,241,69,224,239,173,252,228,93,190,126,52,14,176,246,29,163,125,119,209,209,120,104,150,12,21,233,19,220,98,140,203,199,93,217,153,248,14,201,199,70,255,108,150,108,235,185,70,143,115,131,227,228,177,165,202,193,189,190,76,130,198,219,14,127,155,10,11,103,28,87,47,77,79,161,103,162,158,103,218,30,2,129,129,155,65,215,126,91,214,27,114,193,118,170,196,28,160,251,223,183,92,12,16,4,181,17,132,242,71,10,198,173,168,173,216,7,79,170,209,157,117,92,46,14,197,97,206,236,44,60,198,198,96,126,248,220,206,102,6,86,134,158,238,12,234,44,76,238,238,80,172,157,25,177,133,53,240,8,125,24,171,158,70,216,248,218,245,161,152,186,56,158,115,218,253,49,74,232,114,61,20,31,78,35,109,68,184,54,20,131,49,77,180,176,232,245,193,113,97,15,207,237,24,177,246,66,35,3,68,252,188,95,35,25,63,196,58,62,62,38,103,172,217,242,113,251,84,45,188,19,68,152,249,91,132,182,163,34,15,248,172,167,202,93,139,228,216,197,114,182,227,53,129,20,224,200,147,17,28,25,77,175,224,220,231,188,126,108,15,159,29,11,24,125,4,197,99,211,153,135,50,64,171,109,145,15,241,39,100,190,39,202,78,162,247,190,76,170,44,232,252,52,239,242,2,52,219,84,0,127,85,172,243,130,38,243,71,186,252,109,158,22,248,171,52,250,118,71,241,231,243,60,55,21,120,41,185,5,155,226,139,192,105,231,70,51,160,106,117,126,80,210,185,83,24,63,125,112,110,137,67,138,168,89,32,123,60,197,247,131,99,177,6,255,126,7,228,93,35,169,77,48,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f43da2b1-c755-46b8-898c-76529770c065"));
		}

		#endregion

	}

	#endregion

}

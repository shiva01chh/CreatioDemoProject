﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApprovalDataProviderSchema

	/// <exclude/>
	public class ApprovalDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApprovalDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApprovalDataProviderSchema(ApprovalDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2a237de7-dbfc-40a8-acaa-88d533b28632");
			Name = "ApprovalDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,25,219,110,219,54,244,217,3,246,15,132,251,34,3,134,130,189,166,113,128,36,77,50,15,75,147,197,189,60,20,125,96,164,99,135,131,44,185,36,229,206,43,242,239,59,188,73,20,37,37,118,146,161,45,218,162,104,45,242,220,121,174,100,78,151,32,86,52,1,242,6,56,167,162,152,203,248,164,200,231,108,81,114,42,89,145,147,47,191,254,50,40,5,203,23,100,182,17,18,150,47,131,111,4,207,50,72,20,172,136,207,33,7,206,146,22,204,117,153,75,182,132,120,134,187,52,99,255,106,210,53,148,207,123,185,236,219,225,208,183,30,191,58,238,221,58,69,206,146,129,232,5,56,163,137,44,120,15,196,235,146,41,161,215,44,129,139,34,133,44,126,69,37,69,3,73,142,88,91,33,156,254,35,33,23,202,58,53,184,150,105,83,27,142,76,250,164,142,67,208,144,200,44,185,133,37,125,144,128,1,67,100,68,127,193,97,161,152,78,115,9,124,142,103,191,79,166,71,171,21,47,214,52,83,234,93,225,47,150,2,71,80,252,187,42,111,50,150,16,230,128,123,97,149,163,40,132,193,222,222,30,57,16,229,114,73,249,230,208,45,156,131,20,132,102,25,161,22,91,144,164,214,127,94,112,34,86,144,176,57,131,148,112,72,10,158,18,154,167,68,104,185,227,138,236,94,72,247,96,69,57,93,146,28,253,120,50,196,223,144,75,163,235,107,92,25,30,26,237,45,25,13,117,176,167,49,238,35,112,173,249,79,211,10,221,10,196,210,184,133,205,65,150,60,23,135,7,123,238,151,218,154,129,210,236,175,18,248,230,26,227,11,15,31,148,5,156,229,126,103,2,93,110,19,9,201,213,73,134,98,143,201,121,201,82,210,20,102,100,14,239,62,235,162,45,215,208,111,224,164,228,138,32,41,5,112,99,220,31,192,226,218,38,206,238,226,153,45,62,103,92,200,208,238,63,172,173,207,148,53,154,6,127,102,123,175,153,160,68,133,14,93,128,175,117,144,63,188,157,109,109,43,60,171,206,238,49,103,183,65,156,186,6,211,212,79,63,222,107,197,157,65,106,126,91,196,181,23,208,88,71,201,130,23,229,10,213,188,193,147,151,84,162,139,137,31,214,231,170,200,190,0,52,108,34,206,10,110,56,236,236,121,131,59,83,239,94,64,158,154,2,105,191,109,181,60,201,168,16,251,164,235,168,245,1,126,240,59,131,49,169,58,157,155,12,62,214,101,52,81,84,122,136,212,21,84,211,186,128,229,13,240,72,9,141,229,125,8,90,45,125,6,35,69,208,81,180,122,158,86,219,228,11,89,128,124,73,132,250,231,206,56,87,23,193,37,197,214,140,99,103,81,46,243,94,178,23,1,80,72,188,203,106,253,70,107,118,12,218,104,48,167,101,38,143,89,158,34,187,72,110,86,80,204,163,206,22,99,52,234,181,163,15,70,250,187,153,47,198,24,149,112,232,68,146,151,170,251,67,25,175,52,97,3,97,153,116,145,137,222,10,101,143,60,183,133,181,108,124,142,116,187,60,24,4,64,147,0,76,185,219,192,30,77,96,185,74,58,100,184,2,174,90,184,125,245,91,34,38,164,86,60,247,73,2,62,193,103,135,35,244,113,195,240,185,45,82,205,138,173,169,4,199,72,127,144,117,129,33,131,214,200,54,198,19,68,244,138,105,22,152,55,14,140,167,140,173,199,28,170,174,195,58,203,5,93,141,27,109,170,14,95,2,226,147,179,83,3,246,3,110,196,71,105,106,120,68,67,76,23,163,88,237,125,84,238,138,95,47,31,198,121,135,21,226,242,51,14,33,62,106,189,184,11,5,53,7,73,140,229,78,74,110,111,11,130,51,144,199,27,159,136,89,216,6,83,103,247,6,170,89,217,2,87,13,82,152,50,124,100,183,180,5,246,229,205,223,160,11,185,143,95,47,250,254,235,124,164,125,206,39,28,112,163,202,208,167,226,211,78,73,121,76,180,156,131,162,148,100,91,119,115,126,101,27,236,43,85,89,0,19,152,32,183,222,138,64,109,176,118,180,128,162,80,174,145,49,213,154,114,229,180,136,149,195,231,182,162,65,74,104,76,92,23,52,199,94,133,143,155,252,99,179,25,123,60,26,106,88,78,253,90,71,22,171,17,147,65,224,169,48,51,80,234,112,207,88,166,84,84,135,28,169,111,115,56,102,245,61,147,183,158,21,204,34,122,11,154,131,137,34,127,131,73,57,62,253,84,210,44,84,35,172,14,227,176,174,90,1,76,33,87,18,117,121,78,251,176,58,15,167,199,119,220,145,171,67,226,32,176,152,88,235,181,41,88,105,26,131,179,112,243,115,94,102,153,217,183,140,194,250,168,66,192,198,14,202,55,219,8,156,239,203,12,76,99,210,118,29,28,252,33,41,37,92,3,85,101,131,235,255,200,228,208,138,59,208,30,111,184,191,157,166,72,220,64,196,72,219,240,124,71,179,18,14,20,216,161,201,74,51,7,60,180,138,12,42,225,31,246,64,69,119,138,245,142,230,9,28,111,144,72,84,241,118,212,180,68,190,214,91,200,117,209,4,175,36,235,191,131,48,176,13,62,200,196,118,165,214,149,21,51,35,100,32,142,35,223,113,54,254,146,14,44,3,122,103,81,216,156,68,206,92,230,176,157,227,236,100,197,51,108,84,106,51,234,142,126,136,174,224,146,220,240,30,1,135,134,94,85,199,238,108,104,40,151,141,171,107,28,225,46,106,234,189,86,15,54,105,249,102,35,204,12,90,87,164,25,95,37,29,238,219,30,75,188,176,18,6,109,98,84,83,177,101,177,154,6,27,153,253,65,92,213,47,199,68,121,239,112,76,66,47,142,143,68,203,179,31,164,209,242,56,77,165,181,106,232,196,103,188,88,122,68,106,250,83,148,154,255,81,176,22,139,81,124,217,197,214,147,13,145,133,78,135,62,97,4,105,224,120,50,188,191,5,14,1,236,73,145,250,194,88,122,214,123,171,148,21,121,231,49,34,84,88,187,55,78,91,212,75,157,167,221,28,153,174,56,168,76,213,177,21,117,54,106,227,157,75,111,235,110,51,241,175,57,85,233,65,247,11,129,66,79,170,235,110,82,228,107,108,131,33,117,201,4,137,104,233,170,123,213,78,122,53,211,113,32,166,33,221,161,85,161,219,27,165,149,30,223,187,216,152,243,49,243,90,164,173,211,69,187,203,238,220,253,48,181,169,11,196,102,163,235,226,179,210,177,165,247,184,222,62,154,207,77,251,223,1,134,129,83,230,178,6,62,113,218,36,110,202,68,63,9,211,133,22,96,155,161,164,30,19,188,105,73,79,237,44,71,47,103,50,45,112,54,227,48,159,12,59,135,176,184,247,74,206,180,128,163,225,222,33,241,38,176,255,227,86,175,225,167,129,187,163,157,58,186,214,54,221,176,83,221,169,71,221,110,102,64,179,65,48,53,232,37,47,52,180,164,233,101,94,85,209,112,6,112,0,174,44,5,24,241,37,199,51,57,222,28,137,36,234,148,42,132,175,71,137,138,242,179,119,152,195,169,56,81,213,53,131,20,19,229,28,143,0,70,207,223,199,186,73,106,92,13,249,250,54,128,230,82,196,239,41,70,82,190,24,121,89,72,141,239,134,220,185,186,124,235,155,4,28,199,42,13,233,28,241,103,177,96,9,205,46,113,156,215,239,94,51,117,83,37,209,248,150,65,64,252,201,170,213,227,238,56,108,105,78,204,21,161,90,141,235,246,252,185,5,248,160,58,162,116,201,242,183,57,195,166,243,186,200,96,223,95,82,11,211,116,191,146,243,99,236,239,110,43,117,232,13,129,22,205,209,227,158,186,215,151,199,239,30,151,221,58,159,120,118,203,110,79,121,37,250,70,178,155,105,27,117,198,234,203,78,85,142,179,83,151,15,253,96,102,106,66,247,36,201,239,39,43,189,46,228,22,137,201,73,48,250,202,190,221,122,206,8,29,251,73,239,33,222,224,177,170,175,4,122,110,108,154,239,40,181,77,84,122,238,148,194,118,89,222,117,249,196,99,227,95,204,216,30,170,99,250,242,224,195,93,175,191,122,156,141,251,31,209,118,202,33,79,126,139,251,70,242,200,183,217,37,41,10,186,183,86,207,113,19,242,219,207,222,233,103,239,244,179,119,122,182,250,210,247,152,251,168,46,234,137,47,195,223,237,131,130,185,60,121,204,163,130,193,196,212,214,147,49,107,247,62,90,44,56,44,116,96,158,149,185,9,91,111,77,57,182,13,88,115,43,97,174,209,252,22,81,103,146,222,14,209,190,127,117,166,215,90,64,255,133,171,236,121,223,242,25,245,60,167,125,245,87,146,239,167,16,124,165,118,53,184,149,50,171,205,69,92,243,255,252,7,27,170,26,35,223,42,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a237de7-dbfc-40a8-acaa-88d533b28632"));
		}

		#endregion

	}

	#endregion

}


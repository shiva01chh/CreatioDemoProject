﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApplicationPageQueryExecutorSchema

	/// <exclude/>
	public class ApplicationPageQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApplicationPageQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApplicationPageQueryExecutorSchema(ApplicationPageQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2f24a183-c8da-4a3f-b5a2-7bdf5c250c86");
			Name = "ApplicationPageQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("13b9c287-707b-4588-95dc-f40709dfb679");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,89,91,111,219,70,22,126,118,129,254,7,174,23,40,100,64,163,144,156,25,146,83,199,14,156,139,82,99,147,54,27,59,187,15,69,177,152,203,153,152,8,69,170,36,149,70,8,252,223,247,144,148,34,81,34,117,137,221,0,129,165,225,185,126,231,202,81,42,39,80,76,165,6,231,22,242,92,22,153,45,71,47,178,212,198,31,103,185,44,227,44,253,241,135,175,63,254,112,50,43,226,244,163,115,51,47,74,152,156,111,124,71,250,36,1,93,17,23,163,215,144,66,30,235,45,154,55,113,250,231,234,112,93,215,100,146,165,221,79,114,232,59,31,93,77,167,73,172,101,163,243,74,21,101,46,27,3,122,57,94,165,101,92,198,208,79,48,70,9,89,222,80,32,205,63,115,248,136,2,157,23,137,44,138,159,157,53,133,239,228,71,248,247,12,242,249,171,47,160,103,200,83,211,63,121,242,196,121,90,204,38,19,153,207,47,23,223,107,42,7,22,100,142,197,255,83,100,46,156,204,58,114,37,112,180,100,127,178,198,255,251,75,176,114,150,148,207,227,212,160,181,131,114,62,133,204,14,174,107,63,230,45,253,103,67,231,87,12,163,115,225,156,238,50,243,244,236,15,148,59,157,41,164,112,116,229,214,78,175,156,159,157,231,178,128,53,146,27,125,7,19,217,34,122,250,34,137,33,45,63,164,113,217,60,173,76,255,90,3,242,13,193,113,12,137,65,8,223,229,241,103,89,66,243,112,218,124,113,138,18,69,107,39,7,105,178,52,153,59,175,103,177,113,254,87,161,244,223,184,188,187,149,170,184,133,201,52,65,210,15,215,6,61,76,225,175,154,102,112,234,114,22,134,90,25,226,105,25,17,22,240,136,40,230,135,68,132,158,213,60,82,74,187,209,233,217,249,113,202,198,57,128,201,38,125,58,169,242,193,243,66,75,34,29,40,194,180,228,36,114,165,79,66,80,138,137,80,27,99,197,209,58,151,202,174,39,120,184,161,80,41,129,46,6,134,80,37,208,73,215,245,137,100,158,37,161,10,93,171,69,24,248,192,143,82,248,62,254,120,87,94,225,195,171,212,236,66,87,68,136,42,211,30,225,54,144,132,73,206,137,208,212,18,19,4,145,6,207,167,97,164,31,164,120,15,210,220,70,198,48,234,18,169,173,79,24,120,18,145,214,17,193,144,91,30,130,207,184,134,71,113,188,19,117,163,60,5,145,37,154,1,37,204,3,52,131,49,69,148,137,4,11,165,27,169,240,56,231,111,179,233,1,152,83,47,12,56,69,184,195,80,106,12,54,149,68,80,31,136,95,65,161,184,11,12,130,7,168,221,131,184,31,130,167,124,143,19,47,64,197,76,69,62,81,174,12,136,136,66,95,162,5,16,0,123,4,167,187,240,14,35,229,26,166,177,152,132,103,8,19,146,18,73,3,70,92,105,181,231,90,95,10,42,143,82,253,6,108,29,235,222,222,97,35,80,145,8,176,142,2,204,46,99,37,198,22,83,28,107,139,89,238,34,234,50,124,144,194,46,47,141,66,32,13,8,98,140,64,128,153,64,128,45,179,152,95,92,7,16,105,102,244,113,94,238,242,16,152,194,18,9,21,209,182,74,97,0,70,20,199,158,197,93,223,6,194,53,8,248,113,141,163,82,182,39,131,68,8,44,114,3,151,120,76,84,249,139,5,36,172,23,146,72,201,200,215,85,243,98,199,117,199,125,136,178,136,10,233,161,154,128,134,136,168,23,9,162,128,107,18,113,235,99,234,114,244,253,72,133,245,18,241,82,22,119,42,147,185,233,115,212,243,3,235,115,45,112,244,84,249,74,21,197,66,13,177,53,107,79,184,148,178,8,236,113,165,178,161,119,15,206,150,6,174,107,41,199,176,82,84,111,12,37,81,132,125,130,50,151,73,197,61,14,244,184,201,215,227,118,55,228,126,32,49,137,8,213,38,192,36,230,140,200,72,97,18,7,161,80,161,181,6,252,195,90,163,194,221,226,151,108,2,213,222,177,85,158,26,67,167,48,164,30,24,129,113,85,17,17,46,7,130,141,1,7,175,240,56,231,238,209,74,186,188,161,94,100,60,215,197,78,227,25,204,88,133,125,64,120,190,33,129,182,152,67,33,229,148,171,131,21,221,52,59,112,111,117,24,215,154,72,163,26,234,225,238,192,57,246,28,0,133,147,93,9,170,3,166,213,129,81,235,208,213,229,27,103,92,184,126,200,137,225,214,197,106,244,16,63,160,148,24,223,226,110,196,68,128,142,31,166,47,145,233,167,10,193,222,124,196,144,64,228,71,196,85,20,115,2,123,39,54,242,106,122,82,26,130,144,54,8,205,119,106,234,242,203,138,200,163,90,83,28,139,12,59,91,228,9,28,81,190,34,129,167,133,21,128,21,41,15,43,250,36,46,202,125,251,222,216,27,211,49,141,200,149,123,197,48,102,76,144,231,145,224,4,27,217,248,185,27,141,57,103,87,223,171,235,239,141,25,230,200,219,56,141,215,193,236,170,52,208,70,235,200,90,226,135,62,102,166,224,184,63,211,200,35,161,9,25,174,121,184,18,176,239,87,216,217,63,2,79,161,66,78,20,22,23,161,1,245,113,175,116,13,209,220,122,74,130,8,112,245,217,163,240,101,92,231,62,190,39,61,173,100,14,107,201,151,77,55,171,85,174,8,22,170,123,56,170,23,219,147,147,175,189,175,27,195,221,123,250,253,112,147,127,111,27,31,30,220,115,183,133,119,175,112,71,219,184,227,5,96,120,248,182,188,95,238,78,83,143,23,223,187,65,15,15,93,56,247,201,220,141,237,145,162,59,22,208,225,254,109,177,35,163,122,101,28,206,191,59,13,15,19,211,187,23,125,79,70,111,140,254,97,247,156,110,211,111,15,215,225,206,73,184,198,221,49,190,134,59,102,205,138,179,123,64,12,119,118,243,182,213,61,45,120,184,187,95,54,50,238,207,23,215,40,144,154,230,38,165,125,173,242,34,75,139,50,159,85,151,86,213,229,74,125,173,179,184,91,105,174,120,118,93,238,12,62,20,144,163,132,180,65,207,153,181,190,14,157,107,100,126,43,83,100,203,171,155,170,197,199,179,218,183,159,157,202,248,193,38,203,26,89,211,89,239,119,219,255,22,202,187,172,247,94,232,115,134,83,229,6,202,26,147,113,150,55,215,94,215,37,76,150,87,96,14,212,127,208,214,230,230,105,161,188,34,217,190,149,114,138,77,154,133,145,39,213,40,120,230,76,115,248,28,195,95,171,137,245,26,202,119,173,179,231,243,70,84,109,66,135,180,90,216,201,179,103,93,156,239,100,142,230,52,252,69,7,115,61,238,78,110,218,140,131,165,127,109,219,26,226,251,206,91,180,198,151,221,166,63,12,173,67,184,127,255,163,78,144,45,202,2,97,253,186,45,218,185,111,220,207,161,156,229,233,182,245,131,110,97,157,56,244,2,208,142,192,195,48,120,131,213,255,244,16,17,151,189,56,52,201,210,174,193,209,38,255,130,101,132,238,92,37,73,227,65,87,246,140,110,179,202,164,193,217,227,225,184,59,159,6,215,239,113,23,251,13,119,177,213,205,255,131,0,89,34,107,51,156,70,250,206,25,252,11,230,255,145,201,12,251,101,156,183,86,182,111,59,94,245,196,137,211,206,173,111,41,238,68,101,89,226,196,197,202,74,68,187,148,113,90,52,38,96,62,190,184,3,253,233,218,246,81,244,96,54,108,219,49,66,115,23,224,159,196,214,25,244,107,252,102,217,50,74,109,57,181,207,11,65,247,245,159,251,245,144,166,179,36,217,17,173,101,203,108,53,145,205,102,217,213,238,150,86,85,182,183,159,140,174,139,95,81,233,111,249,171,201,180,156,15,206,190,217,223,88,116,190,102,99,163,96,132,250,209,249,217,36,173,125,25,156,182,51,231,244,152,110,86,71,111,95,128,26,115,208,203,217,4,114,169,18,56,48,17,183,202,168,104,176,89,60,248,176,66,101,1,254,54,195,232,42,157,15,190,56,23,151,206,151,81,253,94,117,177,198,188,238,215,1,19,48,43,209,59,48,205,243,205,159,146,154,131,56,189,131,60,46,77,166,157,39,171,211,245,159,140,16,192,133,28,39,251,12,121,30,155,10,203,188,250,173,235,61,20,179,164,108,114,161,193,160,249,197,232,114,235,39,163,211,243,199,55,162,21,145,142,86,139,29,166,69,50,56,171,44,59,172,61,254,13,230,142,103,169,62,40,141,134,117,142,94,54,57,136,78,172,103,199,56,78,74,244,100,29,242,122,3,107,206,87,249,236,216,250,224,91,15,60,86,121,221,82,27,161,216,207,170,47,163,110,75,150,122,154,162,221,20,119,59,159,194,34,125,235,143,245,6,244,30,254,156,197,57,152,166,162,27,57,117,93,111,89,83,241,92,46,85,12,157,211,213,233,105,123,44,109,143,255,139,229,139,248,201,171,47,101,46,177,22,166,144,99,199,154,46,63,92,108,51,141,214,73,99,40,70,227,56,197,41,95,229,244,160,67,247,114,16,220,224,243,155,117,31,49,189,48,232,37,78,208,235,180,164,254,96,169,179,233,196,103,85,73,15,226,180,60,91,1,115,190,222,255,182,69,254,244,211,90,60,158,141,174,211,207,217,39,232,90,23,255,113,225,88,153,20,11,121,247,235,237,226,49,83,185,158,9,111,229,244,202,152,184,158,142,73,19,203,98,240,168,75,116,247,162,190,148,221,179,240,118,119,199,230,180,125,88,159,85,255,254,15,70,105,101,35,174,32,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f24a183-c8da-4a3f-b5a2-7bdf5c250c86"));
		}

		#endregion

	}

	#endregion

}


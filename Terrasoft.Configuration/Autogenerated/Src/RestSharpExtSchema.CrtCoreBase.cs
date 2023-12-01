﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RestSharpExtSchema

	/// <exclude/>
	public class RestSharpExtSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RestSharpExtSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RestSharpExtSchema(RestSharpExtSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("412cd130-59d7-4126-a567-47ba5a825132");
			Name = "RestSharpExt";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,88,75,111,219,70,16,62,43,64,254,195,134,49,82,185,85,169,0,189,217,22,3,199,143,90,105,109,7,150,92,31,138,160,88,145,35,137,9,197,101,119,151,178,85,67,255,189,179,47,114,37,83,118,36,160,64,125,176,196,225,188,231,155,153,93,229,116,6,162,160,49,144,33,112,78,5,27,203,240,132,229,227,116,82,114,42,83,150,191,126,245,248,250,85,171,20,105,62,33,131,133,144,48,59,92,123,14,175,64,62,161,221,193,168,166,157,112,80,186,194,115,252,40,57,12,217,100,146,33,189,102,152,100,108,68,179,131,131,19,54,155,177,60,252,29,25,86,222,223,128,144,131,41,229,69,3,41,60,5,1,60,165,89,250,15,112,81,51,248,241,40,173,77,111,174,143,75,57,237,231,18,38,38,88,228,65,174,110,183,75,142,68,57,155,81,190,136,236,243,103,206,230,105,2,130,148,50,205,82,185,32,240,32,33,23,40,67,102,32,167,44,17,100,204,120,237,21,137,51,42,4,136,208,233,235,122,10,139,114,148,165,49,17,18,141,198,134,179,150,60,123,144,200,242,168,61,105,189,229,48,81,54,206,83,200,18,113,128,110,164,115,42,193,188,44,204,131,211,131,73,78,88,158,45,72,31,243,71,254,202,240,95,143,224,215,75,154,211,9,240,240,87,144,42,177,192,219,193,133,148,197,13,252,93,162,205,96,255,208,154,130,60,49,214,86,77,95,154,240,208,182,246,218,188,92,79,145,38,28,39,152,133,164,170,134,206,40,153,210,60,201,176,48,68,50,34,167,64,38,233,28,114,114,115,54,24,98,224,41,228,50,172,244,117,215,21,30,21,148,211,25,201,17,163,189,128,163,179,39,90,34,136,60,113,165,87,128,44,139,240,168,171,217,181,244,106,134,231,44,77,200,64,49,157,174,122,119,97,157,107,203,105,106,74,96,44,144,218,216,62,193,82,188,77,199,228,234,108,120,126,115,124,121,118,119,125,243,155,50,209,234,251,192,243,226,198,135,30,201,225,190,46,233,39,193,114,108,170,57,112,137,217,87,9,71,241,218,68,136,137,179,158,180,3,90,20,232,185,246,174,251,21,229,130,206,138,234,231,133,37,162,114,71,169,135,159,119,180,70,231,84,196,60,45,228,86,178,63,254,180,193,220,91,200,4,188,144,223,126,142,133,205,113,102,125,79,158,87,213,76,64,250,207,199,177,74,116,123,159,244,162,70,11,219,150,170,81,253,247,215,108,87,241,170,120,59,219,247,171,184,131,146,170,156,27,101,213,120,73,199,74,199,242,153,17,162,55,5,78,89,221,224,220,76,40,114,159,202,41,249,52,184,190,34,49,195,89,253,31,141,140,38,105,86,242,24,130,232,246,166,79,216,88,143,47,235,211,243,146,35,150,44,130,232,35,254,223,74,204,44,146,32,186,24,14,63,219,173,162,92,45,5,60,149,227,232,63,207,69,228,39,10,185,28,249,233,12,236,171,46,177,51,223,166,89,181,139,165,152,1,216,111,156,128,29,84,193,213,222,116,9,233,16,54,250,10,177,36,42,206,142,134,69,203,108,9,231,117,207,110,141,240,243,245,96,168,39,40,178,204,41,215,90,157,19,61,207,70,104,60,114,222,212,150,140,194,14,57,165,146,158,51,62,163,50,84,110,123,104,180,50,154,60,216,98,4,55,206,116,95,33,226,91,149,176,173,162,92,157,76,107,92,74,247,26,167,195,122,203,20,196,143,251,112,151,30,248,191,35,126,27,232,250,114,73,85,214,32,26,162,49,245,172,14,82,170,206,27,49,239,8,27,18,180,85,15,236,132,255,23,33,239,227,245,3,169,131,84,168,44,179,108,115,71,56,204,58,138,225,107,221,88,203,166,103,26,156,232,89,55,52,113,105,154,3,241,221,174,77,135,23,84,252,65,179,18,156,241,21,20,219,207,202,75,79,78,11,25,141,203,93,33,125,43,128,232,179,182,2,5,197,79,76,171,218,156,64,112,129,104,2,227,216,181,36,46,57,55,201,223,26,245,238,56,27,185,212,165,118,133,63,15,64,60,211,163,43,114,129,147,99,158,198,112,199,113,169,3,15,34,251,69,31,234,83,92,58,156,226,38,67,12,232,93,228,132,72,97,110,5,252,121,27,34,102,5,136,32,186,2,72,32,177,137,48,196,167,130,114,81,128,47,60,180,151,166,32,178,95,48,133,230,250,100,47,14,202,67,220,139,73,170,54,45,205,252,244,34,1,13,84,26,95,234,136,59,140,77,59,119,228,140,70,94,95,56,46,47,217,22,131,253,126,99,18,73,115,110,171,118,50,25,216,39,247,83,192,168,156,201,3,98,191,32,178,169,130,97,71,53,69,219,161,86,129,218,50,8,117,163,233,139,211,84,208,81,6,137,231,244,190,135,241,70,172,90,36,43,101,111,154,189,12,251,194,69,101,166,64,63,199,4,235,221,146,120,250,213,45,43,188,163,60,111,7,142,221,141,92,204,91,206,20,12,43,185,144,28,199,49,8,117,21,250,134,119,160,123,150,255,128,59,20,212,148,76,116,25,189,113,27,216,13,247,66,4,54,149,84,235,29,106,181,189,13,121,87,217,58,174,249,218,54,253,79,23,169,58,215,225,85,82,29,235,142,109,103,106,40,225,233,110,47,248,8,148,99,105,31,61,139,203,160,82,178,245,96,48,7,72,129,47,0,187,159,195,184,23,120,67,56,232,70,74,91,193,114,156,31,120,105,103,124,195,68,104,184,238,25,205,103,74,104,5,196,86,155,83,235,227,202,209,66,45,117,246,16,67,161,175,176,111,86,167,118,75,78,57,187,39,27,184,215,241,85,177,57,211,3,116,178,20,74,233,42,69,253,76,81,100,32,17,11,239,222,173,105,191,196,92,227,29,30,65,121,197,228,21,250,114,205,207,102,133,92,120,72,84,187,100,102,216,16,2,123,193,159,143,27,44,47,191,28,144,199,70,245,203,224,208,15,80,237,34,245,67,65,21,90,187,141,147,112,95,145,140,166,19,150,160,75,106,56,226,220,81,96,3,174,213,117,156,35,251,126,50,70,140,101,216,20,154,163,150,71,95,181,214,202,33,239,85,212,35,191,188,127,95,47,179,39,194,85,240,182,13,192,11,198,174,90,27,209,170,211,26,40,149,253,151,3,58,36,214,12,78,255,120,234,213,180,193,149,86,76,17,94,107,58,111,243,106,199,37,7,150,175,181,230,109,165,244,196,94,114,134,76,85,186,63,182,149,118,98,173,15,31,136,110,204,122,200,219,222,32,39,83,136,191,233,5,160,78,123,106,95,9,130,99,133,10,36,38,51,156,68,152,39,42,25,119,117,246,43,237,187,104,198,68,93,119,223,83,55,151,26,227,68,116,158,179,50,223,24,227,94,96,103,146,30,141,99,197,74,70,11,116,46,225,106,46,62,133,236,45,79,151,181,183,207,149,205,153,174,152,71,120,190,251,102,159,150,223,129,235,90,121,103,181,125,106,35,203,47,228,113,37,34,44,197,122,217,170,105,184,244,102,223,218,111,107,72,213,47,240,239,95,117,173,158,69,128,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("412cd130-59d7-4126-a567-47ba5a825132"));
		}

		#endregion

	}

	#endregion

}

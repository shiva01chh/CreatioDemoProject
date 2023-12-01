﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WordReportingDesignWorkerSchema

	/// <exclude/>
	public class WordReportingDesignWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WordReportingDesignWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WordReportingDesignWorkerSchema(WordReportingDesignWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9c434595-f2cf-4fa8-8a76-df19f24dd5b8");
			Name = "WordReportingDesignWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7609649d-94a6-447b-b054-9d91465ffa7b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,90,221,111,227,54,18,127,246,2,253,31,88,223,67,101,192,167,244,158,14,216,141,83,36,78,178,53,208,108,246,226,164,91,160,40,238,24,137,177,117,43,139,94,146,74,98,4,249,223,111,248,37,145,20,101,59,73,209,123,217,141,168,225,124,113,102,248,155,145,43,188,34,124,141,51,130,174,9,99,152,211,59,145,78,105,117,87,44,106,134,69,65,171,244,138,172,41,19,69,181,72,191,80,150,203,127,190,18,246,221,187,167,239,222,13,106,14,203,104,190,225,130,172,62,4,207,192,165,44,73,38,89,240,244,35,169,8,43,178,14,205,236,178,179,244,75,81,125,235,44,126,34,162,179,54,39,89,205,10,177,137,188,96,247,69,70,46,104,78,202,244,11,185,109,9,78,105,86,175,72,37,206,41,91,97,145,94,174,73,245,219,170,76,63,227,236,43,94,0,65,75,217,235,140,98,177,20,220,72,136,147,179,222,245,244,244,164,247,213,89,37,10,81,16,222,75,112,142,51,65,153,71,49,3,107,63,81,176,166,174,242,179,199,140,172,165,138,104,210,171,124,148,30,216,1,195,191,49,178,144,155,167,37,230,252,61,146,39,221,156,251,41,225,197,162,178,231,14,196,7,7,7,232,144,215,171,21,102,155,35,243,252,153,209,251,34,39,28,49,181,13,45,228,137,99,185,29,221,213,149,10,3,92,194,105,165,118,255,129,195,96,93,223,150,69,134,50,41,188,95,54,122,143,102,237,75,95,171,193,147,210,172,181,3,162,78,224,74,128,45,159,89,113,143,5,209,239,215,250,1,101,242,61,226,130,41,63,230,16,171,245,170,250,4,185,0,238,27,206,242,225,135,94,226,243,162,36,62,185,92,217,178,225,122,179,38,161,4,189,182,101,211,148,174,55,42,214,142,179,140,112,126,198,24,101,23,240,7,94,192,126,185,107,48,156,214,140,65,44,163,154,131,107,150,248,158,84,255,17,136,169,248,68,119,148,33,146,23,240,76,50,240,24,122,40,196,18,253,240,244,227,243,15,168,80,98,149,175,72,149,107,119,249,190,59,47,72,153,247,57,142,17,156,211,170,220,160,27,16,11,94,174,116,138,163,127,215,222,243,14,17,234,120,88,45,35,90,10,82,199,111,228,232,80,232,13,130,36,144,235,139,29,161,39,229,156,64,27,112,121,71,189,193,224,121,187,142,23,68,44,105,175,31,110,41,45,209,20,87,160,206,63,31,33,2,4,97,124,63,221,24,17,53,3,47,19,12,255,147,27,81,148,42,241,161,70,138,25,55,171,103,21,190,45,73,158,248,28,198,104,232,138,131,42,214,186,137,15,71,174,81,86,77,27,78,75,74,57,57,33,226,129,144,234,2,103,140,242,95,10,46,142,171,92,63,204,137,144,142,230,137,161,95,53,36,99,228,45,89,66,107,76,113,135,146,208,11,129,243,71,150,214,90,254,189,230,152,206,248,167,186,44,47,217,217,106,45,54,73,200,255,167,64,34,100,127,171,149,50,117,240,140,72,201,73,192,189,67,20,241,202,76,85,219,205,60,91,146,21,254,87,77,216,70,235,46,11,36,210,254,148,25,170,23,147,14,49,34,252,91,112,154,176,146,78,33,55,132,217,244,5,18,238,51,102,144,238,202,37,122,113,74,87,107,204,10,78,43,201,61,61,251,86,227,114,172,139,65,42,43,195,16,30,46,230,42,246,227,167,121,138,5,190,188,253,47,248,213,122,229,84,80,4,129,35,95,56,75,201,199,186,200,77,37,158,229,86,213,123,204,164,158,144,12,21,121,64,29,171,194,115,75,93,138,11,92,65,233,97,160,32,92,178,112,179,214,37,209,126,50,138,42,230,173,235,189,106,39,125,115,156,155,10,152,12,219,240,27,142,148,217,33,3,107,200,110,38,150,178,195,136,111,184,171,253,77,80,127,3,102,141,73,105,243,151,222,45,159,3,62,49,81,250,229,20,171,251,212,21,164,3,115,111,105,191,255,250,48,183,220,102,170,222,41,100,246,30,196,190,239,106,242,71,106,36,118,84,34,138,208,216,9,209,161,55,134,231,59,110,3,228,67,147,203,118,43,196,8,228,102,147,185,98,201,232,131,10,27,192,83,231,184,46,69,131,31,146,159,133,88,207,5,148,45,56,176,28,2,217,0,140,145,147,126,65,116,72,205,180,197,160,156,140,126,227,155,95,113,89,147,67,93,29,142,146,88,52,117,130,77,69,192,162,226,47,97,217,141,47,195,214,228,178,52,51,158,105,198,27,198,239,251,201,236,143,143,209,88,179,211,177,220,194,101,224,187,119,189,118,11,181,239,17,203,61,136,154,237,74,203,186,161,84,238,205,30,195,246,57,86,158,52,56,254,153,148,107,64,36,192,222,3,203,122,57,9,234,166,194,155,26,218,42,141,14,93,30,71,137,60,10,7,43,28,179,133,194,239,201,208,15,101,40,156,157,75,103,239,250,249,251,31,82,215,107,121,225,202,247,127,109,249,84,98,221,26,154,117,171,72,88,174,250,210,158,42,203,182,151,186,75,67,211,83,122,255,223,181,91,82,26,24,33,119,36,111,185,86,195,139,202,169,119,174,191,221,180,243,234,101,155,144,29,68,227,149,139,150,3,116,158,242,175,228,17,77,142,94,82,69,30,183,22,144,78,68,244,103,118,156,145,78,234,110,116,252,25,245,71,115,24,108,183,32,90,201,199,232,5,123,35,37,123,164,235,208,40,189,166,199,208,238,110,146,104,198,107,31,169,4,39,171,117,169,3,137,232,4,191,131,191,218,244,118,189,105,74,164,121,152,132,197,37,150,218,10,190,171,158,51,35,39,27,169,161,186,233,77,150,27,217,54,209,141,86,237,61,237,240,51,241,30,191,179,157,155,250,123,83,198,207,137,200,150,231,140,174,78,79,18,99,81,228,218,142,182,254,93,68,160,25,128,75,231,202,253,9,156,210,176,183,21,27,122,87,188,5,194,74,171,216,81,220,83,240,249,28,250,84,109,154,58,7,16,67,240,10,9,227,159,49,138,86,222,208,93,242,106,81,36,198,73,1,142,49,142,129,152,209,236,85,64,37,126,223,62,110,100,6,155,64,191,93,145,228,201,222,162,240,159,29,75,125,176,123,219,165,228,10,31,181,53,22,106,235,113,89,26,92,162,156,194,147,81,188,4,119,218,33,217,252,248,113,204,8,7,68,248,42,188,105,183,246,226,205,61,3,215,178,126,75,232,106,93,122,67,119,90,18,204,100,38,219,108,238,135,9,185,220,52,145,229,159,92,23,43,137,137,31,164,47,79,241,134,39,127,255,199,40,149,47,180,2,186,159,204,225,222,80,59,212,165,161,30,58,153,175,29,147,202,76,143,86,22,243,254,203,146,48,8,151,43,163,149,93,31,64,183,173,46,198,68,31,119,218,220,162,109,246,88,22,151,12,48,134,42,66,249,101,229,50,248,168,22,25,116,236,113,78,210,108,27,26,218,164,244,236,145,100,181,232,73,41,229,86,200,206,66,110,148,179,19,61,236,82,16,208,78,34,184,138,81,157,178,107,41,137,171,26,1,160,205,234,221,204,34,60,248,201,220,135,73,47,26,213,202,222,81,176,44,91,162,68,30,158,229,139,138,170,43,99,160,230,62,25,174,206,228,116,109,226,137,145,161,63,213,111,116,102,93,169,225,155,49,199,177,35,200,3,93,206,13,207,70,144,147,3,118,210,221,198,191,153,160,232,57,118,178,101,88,216,5,61,38,230,221,177,200,238,9,152,51,160,11,135,191,106,1,44,71,184,44,141,48,158,54,132,7,33,229,161,78,54,126,116,165,255,183,91,92,24,117,120,96,137,156,137,224,236,172,2,236,207,36,94,62,108,243,250,2,23,213,172,186,163,128,171,142,218,218,236,128,153,228,47,155,126,20,219,128,183,135,187,2,228,252,6,200,207,173,58,251,14,56,226,3,12,253,50,50,192,232,103,20,211,232,37,87,135,51,55,219,7,113,119,160,117,52,4,108,238,216,234,183,3,18,23,17,48,172,183,190,25,155,207,219,131,217,161,68,244,8,59,108,246,85,168,255,48,45,94,118,11,113,111,46,235,164,220,150,198,170,22,163,10,24,79,134,182,196,12,143,180,247,32,21,32,135,21,197,174,188,143,231,122,123,184,193,156,211,95,140,95,192,241,166,139,219,49,242,36,54,47,13,42,114,223,156,64,200,234,99,88,120,3,131,96,191,51,72,138,155,210,141,83,203,161,233,201,138,170,171,5,208,89,59,12,93,163,133,79,232,53,115,90,235,238,216,38,122,250,55,235,146,98,235,212,6,36,239,27,9,150,126,120,100,129,137,252,124,0,24,188,27,15,47,9,32,19,22,77,7,209,32,176,253,250,135,160,233,104,169,131,99,235,34,60,159,224,217,251,68,101,100,91,252,226,163,66,191,183,20,128,241,158,220,166,221,235,101,188,206,212,108,52,119,181,172,207,183,27,65,252,249,230,137,92,137,117,53,118,219,5,89,81,182,49,10,234,3,48,247,158,251,38,81,156,237,30,253,73,57,145,241,186,102,84,226,8,137,153,205,7,115,148,211,12,74,47,138,191,85,31,210,19,45,7,122,72,92,114,210,246,160,3,185,53,157,150,148,91,20,104,33,200,192,132,198,156,144,175,201,143,99,36,255,191,4,64,85,84,233,9,0,16,219,236,218,108,210,212,246,203,79,134,133,4,108,237,103,111,18,105,30,236,188,176,5,78,36,53,192,200,109,0,182,229,195,21,56,236,158,188,54,31,94,85,25,111,49,151,2,249,154,86,156,196,11,164,202,4,173,218,246,110,36,8,125,217,100,133,97,191,205,250,83,250,80,189,165,30,188,202,126,209,41,29,17,15,152,212,183,159,39,71,141,170,187,187,179,125,231,8,146,86,166,163,151,123,253,35,133,238,16,215,219,232,220,214,46,158,107,251,85,239,234,80,117,96,108,25,237,62,40,104,1,138,246,199,23,141,7,149,250,119,208,50,34,78,107,150,17,251,123,0,184,130,114,194,225,170,80,63,12,49,171,251,30,170,102,213,116,152,71,115,203,186,247,132,221,221,142,220,150,197,169,167,204,174,43,64,246,59,254,49,251,42,153,107,32,34,105,223,137,146,207,207,57,89,161,126,184,177,207,71,148,240,103,31,134,73,95,187,107,231,79,78,155,24,26,21,179,199,129,241,10,32,235,121,194,196,180,141,10,50,247,12,18,12,164,15,98,216,157,50,116,84,242,103,12,126,75,211,59,94,8,92,105,121,28,87,121,215,69,253,92,180,223,225,86,193,220,216,213,90,94,175,165,67,93,203,111,212,74,119,74,212,107,17,224,166,206,128,208,113,232,171,12,143,29,151,57,47,71,227,248,132,36,232,200,245,170,191,168,214,222,189,251,31,238,253,98,16,192,39,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c434595-f2cf-4fa8-8a76-df19f24dd5b8"));
		}

		#endregion

	}

	#endregion

}

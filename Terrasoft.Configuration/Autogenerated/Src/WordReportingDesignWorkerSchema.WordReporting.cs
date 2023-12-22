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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,90,221,111,227,54,18,127,118,129,254,15,172,251,80,25,240,41,189,167,3,118,227,28,18,39,217,26,104,54,123,113,210,61,160,40,90,70,98,108,117,101,209,75,82,73,140,32,255,251,13,191,36,146,162,108,39,41,122,251,176,177,168,225,124,113,102,248,155,177,43,188,34,124,141,51,130,174,9,99,152,211,59,145,78,105,117,87,44,106,134,69,65,171,244,138,172,41,19,69,181,72,63,83,150,203,255,190,16,246,237,55,79,223,126,51,168,57,44,163,249,134,11,178,122,31,60,3,151,178,36,153,100,193,211,15,164,34,172,200,58,52,179,203,206,210,207,69,245,181,179,248,145,136,206,218,156,100,53,43,196,38,242,130,221,23,25,185,160,57,41,211,207,228,182,37,56,165,89,189,34,149,56,167,108,133,69,122,185,38,213,127,87,101,250,9,103,95,240,2,8,90,202,94,103,20,139,165,224,70,66,156,156,245,174,167,167,39,189,175,206,42,81,136,130,240,94,130,115,156,9,202,60,138,25,88,251,145,130,53,117,149,159,61,102,100,45,85,68,147,94,229,163,244,192,14,24,126,207,200,66,110,158,150,152,243,119,72,158,116,115,238,167,132,23,139,202,158,59,16,31,28,28,160,67,94,175,86,152,109,142,204,243,39,70,239,139,156,112,196,212,54,180,144,39,142,229,118,116,87,87,42,12,112,9,167,149,218,253,7,14,131,117,125,91,22,25,202,164,240,126,217,232,29,154,181,47,125,173,6,79,74,179,214,14,136,58,129,43,1,182,124,98,197,61,22,68,191,95,235,7,148,201,247,136,11,166,252,152,67,172,214,171,234,35,228,2,184,111,56,203,135,239,123,137,207,139,146,248,228,114,101,203,134,235,205,154,132,18,244,218,150,77,83,186,222,168,88,59,206,50,194,249,25,99,148,93,192,7,188,128,253,114,215,96,56,173,25,131,88,70,53,7,215,44,241,61,169,254,16,136,169,248,68,119,148,33,146,23,240,76,50,240,24,122,40,196,18,253,240,244,227,243,15,168,80,98,149,175,72,149,107,119,249,190,59,47,72,153,247,57,142,17,156,211,170,220,160,27,16,11,94,174,116,138,163,223,107,239,121,135,8,117,60,172,150,17,45,5,169,227,55,114,116,40,244,6,65,18,200,245,197,142,208,147,114,78,160,13,184,188,163,222,96,240,188,93,199,11,34,150,180,215,15,183,148,150,104,138,43,80,231,95,143,16,1,130,48,190,159,110,140,136,154,129,151,9,134,191,228,70,20,165,74,124,168,145,98,198,205,234,89,133,111,75,146,39,62,135,49,26,186,226,160,138,181,110,226,195,145,107,148,85,211,134,211,146,82,78,78,136,120,32,164,186,192,25,163,252,231,130,139,227,42,215,15,115,34,164,163,121,98,232,87,13,201,24,121,75,150,208,26,83,220,161,36,244,66,224,252,145,165,181,150,127,167,57,166,51,254,177,46,203,75,118,182,90,139,77,18,242,255,119,32,17,178,191,213,74,153,58,120,70,164,228,36,224,222,33,138,120,101,166,170,237,102,158,45,201,10,255,167,38,108,163,117,151,5,18,105,127,202,12,213,139,73,135,24,17,254,53,56,77,88,73,167,144,27,194,108,250,12,9,247,9,51,72,119,229,18,189,56,165,171,53,102,5,167,149,228,158,158,125,173,113,57,214,197,32,149,149,97,8,15,23,115,21,251,241,211,60,197,2,95,222,254,9,126,181,94,57,21,20,65,224,200,23,206,82,242,161,46,114,83,137,103,185,85,245,30,51,169,39,36,67,69,30,80,199,170,240,220,82,151,226,2,87,80,122,24,40,8,151,44,220,172,117,73,180,159,140,162,138,121,235,122,175,218,73,223,28,231,166,2,38,195,54,252,134,35,101,118,200,192,26,178,155,137,165,236,48,226,27,238,106,127,19,212,223,128,89,99,82,218,124,210,187,229,115,192,39,38,74,191,156,98,117,159,186,130,116,96,238,45,237,215,95,30,230,150,219,76,213,59,133,204,222,129,216,119,93,77,126,75,141,196,142,74,68,17,26,59,33,58,244,198,240,124,199,109,128,188,111,114,217,110,133,24,129,220,108,50,87,44,25,125,80,97,3,120,234,28,215,165,104,240,67,242,147,16,235,185,128,178,5,7,150,67,32,27,128,49,114,210,47,136,14,169,153,182,24,148,147,209,111,124,243,11,46,107,114,168,171,195,81,18,139,166,78,176,169,8,88,84,252,37,44,187,241,101,216,154,92,150,102,198,51,205,120,195,248,125,63,153,253,241,49,26,107,118,58,150,91,184,12,124,247,174,215,110,161,246,61,98,185,7,81,179,93,105,89,55,148,202,189,217,99,216,62,199,202,147,6,199,63,145,114,13,136,4,216,123,96,89,47,39,65,221,84,120,83,67,91,165,209,161,203,227,40,145,71,225,96,133,99,182,80,248,61,25,250,161,12,133,179,115,233,236,93,63,127,253,77,234,122,45,47,92,249,254,239,45,159,74,172,91,67,179,110,21,9,203,85,95,218,83,101,217,246,82,119,105,104,122,74,239,255,187,118,75,74,3,35,228,142,228,45,215,106,120,81,57,245,206,245,183,155,118,94,189,108,19,178,131,104,188,114,209,114,128,206,83,126,74,30,209,228,232,37,85,228,113,107,1,233,68,68,127,102,199,25,233,164,238,70,199,95,81,127,52,135,193,118,11,162,149,124,140,94,176,55,82,178,71,186,14,141,210,107,122,12,237,238,38,137,102,188,246,145,74,112,178,90,151,58,144,136,78,240,59,248,212,166,183,235,77,83,34,205,195,36,44,46,177,212,86,240,93,245,156,25,57,217,72,13,213,77,111,178,220,200,182,137,110,180,106,239,105,135,159,137,247,248,157,237,220,212,223,153,50,126,78,68,182,60,103,116,117,122,146,24,139,34,215,118,180,245,239,34,2,205,0,92,58,87,238,79,224,148,134,189,173,216,208,187,226,45,16,86,90,197,142,226,158,130,207,231,208,167,106,211,212,57,128,24,130,87,72,24,255,140,81,180,242,134,238,146,87,139,34,49,78,10,112,140,113,12,196,140,102,175,2,42,241,251,246,113,35,51,216,4,250,237,138,36,79,246,22,133,255,234,88,234,131,221,219,46,37,87,248,168,173,177,80,91,143,203,210,224,18,229,20,158,140,226,37,184,211,14,201,230,199,143,99,70,56,32,194,87,225,77,187,181,23,111,238,25,184,150,245,91,66,87,235,210,27,186,211,146,96,38,51,217,102,115,63,76,200,229,166,137,44,255,228,186,88,73,76,252,32,125,121,138,55,60,249,199,63,71,169,124,161,21,208,253,100,14,247,134,218,161,46,13,245,208,201,124,237,152,84,102,122,180,178,152,247,159,151,132,65,184,92,25,173,236,250,0,186,109,117,49,38,250,184,211,230,22,109,179,199,178,184,100,128,49,84,17,202,47,43,151,193,7,181,200,160,99,143,115,146,102,219,208,208,38,165,103,143,36,171,69,79,74,41,183,66,118,22,114,163,156,157,232,97,151,130,128,118,18,193,85,140,234,148,93,75,73,92,213,8,0,109,86,239,102,22,225,193,79,230,62,76,122,209,168,86,246,142,130,101,217,18,37,242,240,44,95,84,84,93,25,3,53,247,201,112,117,38,167,107,19,79,140,12,253,169,126,163,51,235,74,13,223,140,57,142,29,65,30,232,114,110,120,54,130,156,28,176,147,238,54,254,205,4,69,207,177,147,45,195,194,46,232,49,49,239,142,69,118,79,192,156,1,93,56,252,85,11,96,57,194,101,105,132,241,180,33,60,8,41,15,117,178,241,163,43,253,215,110,113,97,212,225,129,37,114,38,130,179,179,10,176,63,147,120,249,176,205,235,11,92,84,179,234,142,2,174,58,106,107,179,3,102,146,191,109,250,81,108,3,222,30,238,10,144,243,27,32,63,183,234,236,59,224,136,15,48,244,203,200,0,163,159,81,76,163,151,92,29,206,220,108,31,196,221,129,214,209,16,176,185,99,171,223,14,72,92,68,192,176,222,250,102,108,62,111,15,102,135,18,209,35,236,176,217,87,161,254,195,180,120,217,45,196,189,185,172,147,114,91,26,171,90,140,42,96,60,25,218,18,51,60,210,222,131,84,128,28,86,20,187,242,62,158,235,237,225,6,115,78,127,49,126,1,199,155,46,110,199,200,147,216,188,52,168,200,125,115,2,33,171,143,97,225,13,12,130,253,206,32,41,110,74,55,78,45,135,166,39,43,170,174,22,64,103,237,48,116,141,22,62,161,215,204,105,173,187,99,155,232,233,223,172,75,138,173,83,27,144,188,111,36,88,250,225,145,5,38,242,235,3,192,224,221,120,120,73,0,153,176,104,58,136,6,129,237,215,63,4,77,71,75,29,28,91,23,225,249,4,207,222,87,84,70,182,197,47,62,42,244,123,75,1,24,239,201,109,218,189,94,198,235,76,205,70,115,87,203,250,124,187,17,196,159,111,158,200,149,88,87,99,183,93,144,21,101,27,163,160,62,0,115,239,185,111,18,197,217,238,209,95,41,39,50,94,215,140,74,28,33,49,179,249,194,28,229,52,131,210,139,226,111,213,23,233,137,150,3,61,36,46,57,105,123,208,129,220,154,78,75,202,45,10,180,16,100,96,66,99,78,200,151,228,199,49,146,127,47,1,80,21,85,122,2,0,196,54,187,54,155,52,181,253,230,39,195,66,2,182,246,107,111,18,105,30,236,188,176,5,78,36,53,192,200,109,0,182,229,195,21,56,236,158,188,54,31,94,85,25,111,49,151,2,249,154,86,156,196,11,164,202,4,173,218,246,110,36,8,125,217,100,133,97,191,205,250,83,250,80,189,165,30,188,202,126,209,41,29,17,15,152,212,183,95,79,142,26,85,119,119,103,251,206,17,36,173,76,71,47,247,250,71,10,221,33,174,183,209,185,173,93,60,215,246,171,222,213,161,234,192,216,50,218,125,80,208,2,20,237,143,47,26,15,42,245,239,160,101,68,156,214,44,35,246,247,0,112,5,229,132,195,85,161,126,24,98,86,247,61,84,205,170,233,48,143,230,150,117,239,9,187,187,29,185,45,139,83,79,153,93,87,128,236,119,252,99,246,85,50,215,64,68,210,190,19,37,159,159,115,178,66,253,112,99,159,47,81,194,159,125,24,38,125,237,174,157,63,57,109,98,104,84,204,30,7,198,43,128,172,231,9,19,211,54,42,200,220,51,72,48,144,62,136,97,119,202,208,81,201,159,49,248,45,77,239,120,33,112,165,229,113,92,229,93,23,245,115,209,126,135,91,5,115,99,87,107,121,189,150,14,117,45,191,81,43,221,41,81,175,69,128,155,58,3,66,199,161,175,50,60,118,92,230,188,28,141,227,19,146,160,35,215,171,254,162,90,115,254,253,15,226,134,201,92,201,39,0,0 };
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


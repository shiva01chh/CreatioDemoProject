﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseActiveIntervalReaderSchema

	/// <exclude/>
	public class CaseActiveIntervalReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseActiveIntervalReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseActiveIntervalReaderSchema(CaseActiveIntervalReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9b299706-707d-4ea1-bb1f-dd34d3b36ef1");
			Name = "CaseActiveIntervalReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,88,219,110,227,54,16,125,246,2,253,7,198,11,44,100,192,85,250,188,177,181,200,58,201,194,64,246,210,117,210,125,40,138,130,145,104,135,173,76,57,36,229,173,219,205,191,119,120,147,40,234,18,59,47,182,168,153,51,195,153,51,23,135,225,45,17,59,156,18,116,71,56,199,162,88,203,120,81,176,53,221,148,28,75,90,176,159,94,253,247,211,171,81,41,40,219,160,213,65,72,178,189,8,158,227,91,202,158,90,135,139,34,207,73,170,16,68,252,129,48,194,105,90,203,248,182,182,219,130,117,191,225,164,239,60,190,122,223,251,234,154,73,42,41,17,189,2,43,105,144,225,253,107,78,54,224,33,90,228,88,8,244,22,45,176,32,151,224,244,158,44,153,36,124,143,243,175,4,103,132,107,225,243,243,115,52,19,229,118,139,249,33,177,207,31,136,68,105,117,83,84,172,145,81,71,66,98,89,10,148,97,73,68,236,148,207,61,237,93,249,144,211,20,165,218,114,191,221,145,138,126,167,159,87,88,98,237,87,203,49,125,240,137,64,26,50,131,255,115,90,48,137,41,36,1,173,11,142,196,142,164,116,13,198,133,132,28,147,205,65,185,137,227,10,202,119,115,180,227,116,15,66,158,163,198,240,200,120,230,238,241,161,164,153,126,187,204,144,121,49,218,16,121,97,190,9,247,237,217,87,121,95,20,57,193,12,173,138,188,84,209,251,188,39,60,43,201,177,234,15,160,142,22,143,36,253,91,153,253,10,44,6,170,145,14,16,228,235,247,35,12,184,129,154,30,88,152,215,132,101,38,47,246,217,38,233,11,47,118,132,43,10,66,166,224,65,2,57,72,54,144,42,32,145,64,242,145,160,82,64,134,32,87,204,208,169,39,35,250,4,40,82,146,234,241,110,80,185,150,221,57,111,208,61,72,47,42,225,240,209,220,189,202,128,227,128,11,195,11,1,184,161,36,207,204,229,181,222,192,213,87,142,138,41,100,224,24,26,114,168,139,130,229,135,138,137,232,207,212,126,187,232,148,131,226,223,46,112,158,150,185,110,103,183,197,70,215,191,82,107,29,94,12,223,11,2,4,21,83,166,32,170,111,167,89,52,112,185,37,131,70,132,115,250,47,48,1,35,70,190,35,10,0,152,65,179,133,70,161,18,62,19,4,42,139,147,245,124,220,215,2,198,231,137,169,189,33,54,236,48,199,91,196,160,151,207,199,101,35,149,227,228,62,224,197,236,92,75,119,43,99,190,41,183,132,73,49,78,20,167,170,199,134,150,45,159,62,143,163,128,76,77,135,166,232,138,234,47,112,129,25,132,19,26,244,20,21,15,127,193,219,164,182,55,177,20,12,160,230,1,152,161,103,87,42,65,180,39,243,117,86,56,12,38,169,207,162,38,236,164,194,181,28,155,123,145,184,43,62,107,111,103,142,129,73,52,57,166,42,62,18,249,88,100,226,152,170,208,61,9,149,140,62,149,48,57,161,237,2,93,116,129,228,116,77,210,67,154,187,249,114,44,39,68,81,242,148,140,19,229,114,141,81,15,174,97,82,24,91,48,208,203,45,251,4,39,227,100,101,166,91,170,143,180,84,27,129,19,89,114,38,146,251,161,107,120,179,243,225,224,46,53,59,119,186,126,69,215,221,250,138,10,73,89,42,141,23,145,30,248,135,122,223,64,230,182,83,100,216,133,66,247,29,183,244,200,90,83,46,228,117,78,84,110,33,205,70,245,247,95,254,80,212,184,59,236,72,102,244,126,83,45,116,166,52,146,168,133,103,216,162,253,163,194,57,87,129,197,151,121,30,17,103,33,49,83,101,100,15,78,49,131,230,243,134,187,214,174,137,149,103,217,39,99,35,120,96,107,41,20,5,236,136,139,116,4,82,61,180,167,70,36,85,241,117,179,212,63,115,211,209,5,143,174,81,116,214,144,70,111,222,160,179,78,89,231,226,26,231,130,248,147,124,69,84,202,96,172,232,143,185,110,145,230,44,232,33,19,131,19,155,104,68,186,89,142,167,104,28,204,236,113,159,92,176,29,244,202,57,60,40,235,151,193,26,66,55,188,216,90,145,73,252,237,145,64,79,25,47,51,248,190,20,215,79,37,206,35,131,18,127,81,69,66,160,93,70,38,238,147,9,194,194,94,218,132,198,68,35,190,254,135,164,165,36,43,96,112,14,219,77,90,240,44,226,186,191,214,36,106,197,223,148,7,248,229,50,108,52,20,203,124,130,41,137,59,186,37,73,20,92,6,37,200,189,139,63,82,35,141,126,252,64,221,48,138,29,30,68,21,220,169,117,239,68,227,19,176,228,95,204,37,227,132,139,89,143,90,180,152,246,220,192,243,165,153,122,119,135,162,148,200,22,182,5,179,85,167,248,223,57,119,206,128,198,101,158,43,167,107,29,87,8,93,26,192,16,183,114,206,107,21,191,76,170,10,247,223,117,21,120,43,74,250,180,48,15,55,57,134,73,235,110,236,78,213,179,115,175,122,199,138,239,250,115,94,179,225,94,166,159,138,239,141,142,227,225,42,142,68,30,162,106,85,25,89,227,50,151,145,131,152,160,119,166,3,192,234,228,139,206,156,185,83,166,232,49,235,215,87,51,68,144,84,87,161,118,69,241,39,206,26,106,86,111,49,183,110,30,13,205,83,55,147,238,122,224,194,177,101,150,164,61,229,18,202,31,45,175,25,236,15,28,63,228,53,235,220,218,148,168,206,220,220,164,68,228,146,114,11,93,189,67,131,19,1,193,181,61,179,91,38,106,82,213,44,43,113,80,27,97,143,54,184,62,251,148,122,107,114,212,120,11,59,62,188,147,158,223,100,157,50,161,59,47,251,179,199,28,17,241,100,175,110,134,255,10,26,198,22,255,90,18,126,8,38,71,236,11,124,196,12,111,8,135,30,222,200,250,216,6,170,222,23,184,84,209,172,103,47,24,3,147,241,101,150,185,97,176,114,66,208,226,63,115,104,45,239,15,151,34,141,38,177,18,111,192,1,145,95,2,187,54,34,227,14,237,112,11,232,244,68,45,77,122,216,244,168,171,227,35,32,244,110,215,1,66,197,13,101,56,95,157,130,181,52,58,221,112,64,140,34,223,147,236,68,68,167,214,13,250,5,195,18,127,42,164,81,106,0,42,209,27,154,67,17,9,165,18,169,231,5,140,15,73,204,233,55,42,31,171,41,46,34,115,184,40,182,176,254,82,81,48,181,205,197,122,228,91,154,141,27,188,183,67,223,152,106,109,174,36,60,48,158,67,249,133,162,225,130,84,151,122,136,17,95,178,67,84,215,85,123,77,237,218,169,67,144,105,123,139,182,255,156,209,139,96,141,87,217,209,117,138,155,77,205,190,153,183,238,105,55,166,170,171,206,19,116,230,30,58,87,100,51,232,135,146,62,129,9,108,237,29,7,53,68,202,137,94,110,143,130,233,45,21,151,244,209,104,13,83,31,167,143,200,254,114,169,135,9,101,97,196,234,112,142,194,254,174,23,247,198,129,233,136,161,92,84,217,29,133,26,177,238,98,106,237,24,186,89,189,36,117,116,198,26,92,247,101,211,200,142,71,108,53,199,1,103,161,75,170,122,112,38,230,29,171,234,59,167,28,252,227,32,94,148,156,3,233,212,169,222,1,205,163,3,128,97,251,182,210,180,6,42,63,204,4,210,173,32,116,169,118,246,165,117,208,203,99,247,18,104,198,191,15,110,186,143,202,40,120,157,53,222,84,80,53,232,40,96,66,232,234,180,150,212,99,183,34,232,75,185,50,253,213,253,28,13,40,93,129,62,215,161,120,182,95,236,231,115,123,145,245,102,122,199,182,103,207,252,35,56,129,191,255,1,26,170,82,225,171,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9b299706-707d-4ea1-bb1f-dd34d3b36ef1"));
		}

		#endregion

	}

	#endregion

}

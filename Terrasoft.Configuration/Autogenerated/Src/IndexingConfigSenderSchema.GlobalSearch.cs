﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IndexingConfigSenderSchema

	/// <exclude/>
	public class IndexingConfigSenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IndexingConfigSenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IndexingConfigSenderSchema(IndexingConfigSenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c5cb028a-05f4-4596-988a-6fb508bebf2c");
			Name = "IndexingConfigSender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eef27540-b1e9-466b-87b9-62933f9468f4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,88,91,111,219,54,20,126,118,129,254,7,86,41,90,105,53,228,54,143,73,236,192,75,157,212,91,155,4,181,187,62,12,91,192,200,199,182,54,221,70,82,105,188,32,255,125,135,55,155,146,37,103,238,176,2,169,77,158,11,15,191,115,165,51,154,2,47,104,4,100,10,140,81,158,207,69,120,150,103,243,120,81,50,42,226,60,11,47,146,252,150,38,19,160,44,90,62,127,246,240,252,89,167,228,113,182,32,147,21,23,144,30,215,214,40,156,36,16,73,73,30,94,64,6,44,142,182,120,166,112,47,194,207,176,40,19,202,70,247,5,3,206,37,255,134,111,161,206,60,58,58,203,211,20,77,248,152,47,22,184,189,161,95,194,55,129,2,210,216,159,120,158,109,8,159,129,139,201,146,178,98,179,229,222,139,65,197,150,9,8,129,95,185,36,144,126,141,179,6,131,195,222,166,59,60,167,145,200,89,12,141,28,46,142,225,56,19,192,230,8,123,35,235,213,176,20,75,201,178,208,135,35,15,114,29,48,88,224,130,156,37,148,243,35,50,206,102,112,143,114,218,204,9,224,146,41,190,94,175,71,78,120,153,166,148,173,6,102,45,201,156,196,82,4,102,4,50,17,11,52,147,136,156,136,37,232,125,105,2,7,118,23,71,16,90,45,61,71,77,81,222,38,113,68,34,121,122,203,225,157,7,101,192,218,210,243,24,146,25,154,122,205,226,59,42,64,19,235,230,169,141,17,106,21,168,125,6,73,156,198,136,13,41,168,192,143,44,92,139,184,182,116,10,173,145,112,65,165,24,3,58,203,179,100,133,254,95,192,61,185,1,173,238,189,213,118,173,149,161,143,51,248,166,153,124,207,15,127,8,122,254,175,191,247,126,123,19,188,244,130,227,29,230,157,112,0,18,49,152,247,189,47,136,17,222,58,211,49,238,245,6,136,30,90,145,105,212,118,152,186,182,177,170,129,220,148,149,245,46,51,48,15,72,74,51,186,0,182,39,46,99,41,122,147,224,127,125,169,229,147,81,114,1,66,230,22,48,223,115,195,115,13,198,1,58,86,251,178,234,216,107,150,23,192,100,8,213,156,107,207,31,143,103,42,200,86,19,29,81,95,25,45,80,130,220,196,141,251,199,255,70,182,101,187,175,46,222,105,209,76,78,79,137,223,70,235,19,125,235,97,81,216,220,14,207,129,138,146,1,58,105,2,5,197,252,3,75,58,207,153,74,204,195,183,234,192,206,169,206,68,157,244,43,137,229,73,139,233,3,223,27,221,203,0,196,163,34,204,121,238,5,90,197,209,30,42,130,253,156,146,11,140,39,152,61,157,115,218,229,100,153,115,65,232,108,38,139,113,107,112,25,165,24,94,76,150,11,163,225,131,20,237,15,90,211,14,75,125,145,96,173,243,13,255,23,150,116,137,247,242,221,238,156,171,154,167,74,20,201,176,91,237,105,156,170,84,223,97,221,225,62,214,205,203,36,33,37,75,246,5,208,218,132,103,30,87,25,238,98,38,74,154,212,46,131,124,238,85,228,242,244,84,133,82,173,155,201,80,250,133,38,37,248,181,242,130,87,115,51,29,53,120,93,115,72,56,74,11,177,218,121,107,45,138,109,66,221,58,82,197,223,54,141,239,186,255,194,177,197,4,252,147,88,92,52,202,40,92,154,213,233,26,208,66,235,255,23,248,108,251,179,218,234,88,238,4,211,246,80,221,142,87,36,137,49,141,158,42,239,22,19,43,60,82,178,31,81,212,212,116,44,177,109,164,22,88,219,85,181,83,16,108,83,117,91,89,116,225,109,215,160,43,224,118,253,107,147,24,248,90,162,35,91,56,2,143,64,151,82,108,200,22,101,138,16,250,94,213,85,232,139,154,243,130,39,252,145,22,9,72,77,136,141,237,233,36,159,187,205,127,44,231,203,179,36,70,38,236,252,79,244,96,135,153,220,176,245,119,237,5,61,76,173,93,224,176,58,95,109,107,219,8,107,84,157,117,159,188,168,64,56,101,43,68,177,218,206,77,124,58,182,119,73,94,138,202,169,145,250,8,108,103,219,80,172,226,51,156,37,132,163,195,95,183,48,35,218,208,157,58,29,183,63,57,62,147,29,74,33,208,224,142,113,134,179,41,77,226,191,113,62,165,106,94,115,157,33,199,213,246,105,140,224,56,166,6,212,176,230,18,13,119,211,212,234,215,198,177,90,200,144,7,237,130,234,54,194,190,53,181,117,58,143,187,251,243,39,16,203,124,107,28,182,209,114,151,199,51,50,161,119,160,141,227,103,52,73,110,105,244,167,175,188,132,127,5,194,39,167,200,205,194,26,23,207,137,239,238,135,19,156,254,74,44,100,51,32,47,250,246,209,117,9,34,252,32,68,177,33,134,87,63,91,21,29,57,27,134,35,198,114,86,85,165,182,62,97,73,199,20,12,212,45,59,143,4,18,180,196,21,28,103,243,220,55,149,15,199,164,148,98,4,74,120,101,117,179,37,128,155,126,193,201,60,206,98,190,196,44,251,22,139,37,241,200,27,147,216,29,207,30,171,109,60,34,15,111,31,187,100,99,48,110,188,195,13,68,72,96,196,225,234,240,209,235,90,225,138,217,85,69,93,210,2,79,141,96,20,7,246,162,123,57,181,45,158,237,134,243,4,83,143,186,53,28,248,8,107,122,128,53,85,22,83,53,84,168,160,58,223,141,0,3,255,152,95,226,48,114,197,84,3,242,155,123,101,64,94,189,34,141,252,155,57,35,8,182,61,92,169,42,210,126,155,14,220,244,78,66,241,33,13,82,83,232,25,16,209,47,56,79,103,14,162,29,89,212,107,117,94,7,253,128,108,247,11,76,181,214,150,32,27,70,133,136,179,175,47,207,61,64,64,46,71,211,201,116,120,249,126,248,249,253,225,141,30,217,55,213,43,252,145,114,221,254,85,133,249,194,98,255,165,247,208,140,22,214,212,56,29,33,218,175,123,175,131,199,30,223,228,168,186,227,129,204,134,255,73,125,56,205,39,202,77,250,86,50,163,230,234,40,51,10,241,8,71,254,245,51,70,107,86,111,148,137,36,200,31,96,132,250,134,57,121,86,50,134,150,201,106,87,31,106,140,167,76,161,249,171,196,15,204,11,253,105,95,204,27,138,137,10,29,248,72,215,95,194,235,171,201,84,251,56,252,138,105,173,172,56,113,237,50,15,43,30,162,9,138,58,240,155,159,58,93,125,45,99,149,49,36,28,206,102,215,248,28,75,65,200,215,234,120,157,70,22,171,46,145,191,4,225,234,14,223,64,33,106,212,61,228,234,246,15,188,164,191,29,87,193,211,250,47,113,133,122,221,135,132,17,114,82,162,82,230,170,137,141,93,139,225,48,177,78,5,39,62,70,247,16,149,2,134,124,149,69,190,49,161,219,84,254,131,182,206,162,114,73,254,42,228,236,41,54,252,247,15,158,43,227,7,213,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c5cb028a-05f4-4596-988a-6fb508bebf2c"));
		}

		#endregion

	}

	#endregion

}

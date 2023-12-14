﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportChunkDataProviderSchema

	/// <exclude/>
	public class ImportChunkDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportChunkDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportChunkDataProviderSchema(ImportChunkDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a9ff971c-8134-4075-beb4-e73a602bfc8d");
			Name = "ImportChunkDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,89,221,111,219,54,16,127,118,129,253,15,68,250,34,99,134,210,110,123,216,150,196,64,154,143,194,67,155,100,181,211,62,12,123,144,37,38,225,42,75,46,73,37,245,134,252,239,59,242,72,137,162,40,217,70,219,135,38,34,239,139,119,191,59,222,49,69,178,162,98,157,164,148,44,40,231,137,40,239,100,124,86,22,119,236,190,226,137,100,101,17,95,178,156,206,86,235,146,203,31,94,252,247,195,139,81,37,88,113,79,230,27,33,233,234,200,251,6,214,60,167,169,226,19,241,91,90,80,206,210,14,205,59,86,124,233,44,46,232,87,217,44,94,209,39,9,34,148,49,127,136,178,104,54,92,35,87,171,190,29,78,251,214,227,243,55,189,91,23,133,100,146,81,1,4,64,242,146,211,123,56,6,57,203,19,33,126,39,232,129,243,68,38,55,188,124,100,25,229,154,234,240,240,144,28,179,226,1,14,42,179,50,37,135,83,88,92,87,203,156,165,36,89,10,201,147,84,146,84,137,48,18,206,30,170,226,179,43,230,120,49,37,32,190,111,183,209,171,247,128,90,105,80,113,168,45,188,100,52,207,192,68,224,145,224,123,154,105,203,208,52,81,173,86,9,223,76,237,194,60,125,160,171,132,20,16,117,114,87,114,99,212,156,10,1,146,180,134,184,230,61,116,153,215,86,56,73,33,48,146,192,209,148,11,187,252,168,225,74,41,56,33,7,221,253,131,163,1,243,62,148,79,2,20,84,133,36,235,132,75,109,34,43,4,229,18,148,109,181,140,1,155,19,39,16,48,103,255,42,51,126,254,229,55,163,181,33,230,52,201,202,34,223,144,91,16,15,136,47,16,182,222,167,97,123,73,139,12,189,109,190,45,56,148,47,120,149,202,146,171,0,232,184,27,69,136,129,158,176,70,158,210,170,245,57,38,58,190,35,143,232,196,35,83,64,30,61,15,27,248,158,202,135,18,193,193,30,19,73,173,23,244,7,153,93,20,213,138,242,100,153,211,227,214,239,93,208,77,201,91,42,219,206,21,209,22,30,194,234,53,123,36,78,101,197,11,103,35,158,175,115,38,175,17,27,32,177,19,190,177,123,76,107,248,114,35,233,95,127,43,147,230,144,121,73,14,116,209,130,164,214,205,158,182,139,34,45,51,5,160,219,197,229,175,80,150,228,27,96,23,145,170,44,224,205,71,64,87,92,139,185,94,254,3,222,141,26,81,65,253,11,165,250,156,138,90,185,49,168,207,2,87,149,195,134,202,192,85,81,199,196,185,206,175,144,29,163,145,107,201,99,201,50,114,154,101,31,147,188,162,98,81,206,116,182,252,89,81,190,137,240,119,147,64,19,210,141,144,19,7,189,100,173,70,14,112,138,140,14,102,217,193,4,112,158,87,171,34,134,152,64,94,75,192,175,199,24,235,255,103,153,177,178,37,224,12,50,13,18,238,186,8,201,1,9,116,193,86,52,190,42,159,66,204,139,205,154,134,248,34,200,245,177,111,132,34,14,9,153,75,208,178,179,20,77,29,18,163,72,66,82,90,40,244,165,97,236,2,210,48,26,181,20,177,155,159,91,245,180,246,183,135,78,1,39,128,218,163,161,113,195,41,84,82,122,147,220,83,149,166,215,107,125,55,71,250,174,219,96,173,214,96,49,27,80,118,239,45,209,132,32,21,129,235,75,226,175,19,125,12,83,251,65,157,42,194,104,179,42,248,22,62,54,168,14,99,13,2,168,98,205,170,2,186,10,90,134,50,52,134,143,45,247,212,133,142,113,224,219,10,142,212,240,207,178,182,184,27,215,34,45,13,217,156,67,197,214,19,144,142,25,83,75,152,57,241,89,78,19,30,141,119,103,128,164,107,131,59,112,218,61,197,117,60,58,105,29,54,24,236,64,86,155,74,179,40,245,138,137,53,161,250,135,141,145,170,220,241,130,111,0,106,194,22,111,77,174,226,49,141,104,29,31,199,153,38,29,199,241,162,52,229,105,60,33,112,253,129,153,101,37,201,99,194,137,84,41,120,52,172,65,39,88,175,10,76,214,33,29,66,39,40,42,89,144,12,78,14,40,240,234,113,35,28,164,208,100,101,132,235,20,86,178,79,161,243,219,68,54,47,77,149,46,232,83,192,157,145,117,217,200,75,62,208,74,251,97,172,160,58,13,166,249,24,179,104,100,106,102,35,166,11,95,67,169,132,3,153,114,174,89,209,94,130,37,237,11,179,118,142,158,80,14,209,11,207,125,13,2,222,32,129,22,97,123,255,168,45,193,162,132,151,93,79,83,166,87,208,173,98,218,101,58,62,180,123,237,166,172,110,153,61,64,54,205,71,189,164,83,181,205,109,239,194,104,247,155,78,225,9,171,50,120,78,199,95,127,120,253,217,56,158,21,178,140,134,154,93,131,164,158,155,216,94,193,190,21,173,107,225,226,43,77,43,73,163,241,126,141,157,211,116,186,117,161,83,225,149,15,181,86,52,73,151,82,230,93,39,142,87,168,248,98,92,210,145,228,121,39,118,9,222,39,5,20,56,62,25,156,12,204,185,65,133,197,188,150,107,110,191,153,248,200,4,131,18,169,32,207,109,13,87,54,165,182,174,34,165,202,28,16,1,62,199,239,192,133,225,113,196,215,28,186,239,55,155,83,145,70,175,135,173,112,40,127,114,40,29,101,88,12,131,91,166,136,5,247,176,6,5,183,252,98,225,146,193,24,174,150,226,119,229,61,75,147,252,122,77,113,62,7,39,248,75,170,112,166,50,62,45,178,46,187,74,15,245,141,158,194,213,79,76,62,52,74,35,92,132,249,26,26,7,6,141,171,58,103,124,241,165,74,242,9,233,154,104,138,143,143,164,128,229,223,170,26,123,65,84,167,59,183,80,81,176,138,221,186,14,74,219,205,115,112,106,175,71,182,45,67,13,104,221,49,121,218,9,231,147,219,220,151,186,231,50,147,234,107,123,119,110,111,207,250,178,211,110,155,75,203,246,27,231,140,215,115,164,93,155,83,245,88,83,239,64,164,184,144,147,54,31,140,228,103,122,32,63,169,237,244,40,188,78,198,216,117,206,180,76,200,170,99,236,23,225,2,215,227,14,92,168,206,245,100,142,218,188,27,153,203,208,89,192,44,7,103,250,164,94,29,154,184,222,177,238,189,35,145,47,48,54,231,57,33,175,234,171,125,163,222,80,200,18,144,249,25,25,53,86,204,178,129,145,215,86,117,196,190,131,86,45,214,62,176,87,83,176,241,219,37,16,87,230,53,108,223,214,85,179,44,203,50,87,79,5,215,119,119,130,202,75,42,83,72,177,123,213,177,3,36,243,114,153,228,167,235,53,204,32,234,77,69,196,183,1,194,54,52,113,187,110,83,124,71,30,13,206,4,38,122,129,2,171,118,145,55,43,109,24,84,184,66,150,215,113,106,249,67,189,22,213,198,53,150,30,25,82,165,247,3,244,132,18,189,139,89,104,112,49,122,38,52,23,180,22,219,51,38,181,166,161,129,128,79,2,195,144,85,132,63,190,43,170,119,134,117,23,215,214,158,111,64,118,29,6,116,253,143,195,192,120,38,79,15,12,238,242,1,123,109,93,105,53,62,131,53,90,65,83,55,122,59,63,64,245,116,125,10,66,182,188,189,106,26,141,134,79,61,67,97,41,247,31,191,122,122,185,22,85,124,42,212,237,6,71,206,163,113,124,89,242,139,36,125,136,220,27,179,150,135,138,166,117,228,190,119,103,58,26,221,149,0,3,80,223,62,32,40,33,1,83,26,8,217,246,20,139,77,157,64,123,244,186,53,139,193,222,200,247,61,64,40,216,3,91,142,246,152,230,113,239,12,26,93,23,111,215,48,31,209,225,9,193,133,73,165,233,77,8,12,179,159,160,131,222,199,115,236,247,16,101,223,160,92,222,61,95,159,236,195,147,17,241,9,92,66,195,211,40,244,219,186,195,138,6,30,159,186,239,78,70,46,244,152,250,137,112,55,41,245,43,161,203,109,222,20,122,249,125,223,224,43,31,73,132,9,71,11,27,24,174,6,70,100,106,210,250,185,245,44,95,207,153,122,100,196,134,180,6,131,125,133,110,220,100,176,209,44,216,187,118,59,222,84,225,16,40,246,226,43,19,80,55,182,245,142,204,27,125,79,250,134,95,67,47,244,237,102,16,138,87,157,95,36,140,187,23,229,26,166,30,243,97,102,14,227,110,253,135,140,72,77,91,227,49,20,45,152,164,148,42,180,248,192,178,92,242,114,53,92,106,182,163,205,80,108,65,75,15,208,246,128,74,237,42,132,10,250,165,5,21,244,155,133,202,28,6,168,132,31,171,152,77,163,221,47,34,141,159,115,144,4,96,251,222,129,205,180,88,219,78,163,142,112,96,191,95,96,246,143,204,55,133,198,244,127,250,108,219,223,63,204,90,251,73,4,214,212,191,255,1,108,206,14,197,200,30,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a9ff971c-8134-4075-beb4-e73a602bfc8d"));
		}

		#endregion

	}

	#endregion

}


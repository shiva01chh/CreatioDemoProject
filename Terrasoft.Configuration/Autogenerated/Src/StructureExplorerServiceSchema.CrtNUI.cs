﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StructureExplorerServiceSchema

	/// <exclude/>
	public class StructureExplorerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StructureExplorerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StructureExplorerServiceSchema(StructureExplorerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("257acf57-fa02-4a9d-8bf4-c2ede20590ec");
			Name = "StructureExplorerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5fe850f8-633f-4f49-b171-3760bb47e9da");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,89,75,111,219,56,16,62,187,64,255,3,215,189,200,128,33,223,227,216,69,146,166,221,20,205,3,177,187,61,4,57,48,210,216,38,162,215,146,84,18,111,218,255,190,195,135,158,150,228,199,102,23,219,67,18,145,51,195,111,134,195,111,134,108,68,67,16,9,245,128,204,129,115,42,226,133,116,207,226,104,193,150,41,167,146,197,145,59,147,60,245,100,202,225,252,37,9,98,14,124,6,252,137,121,240,254,221,235,251,119,189,84,176,104,73,102,107,33,33,68,197,32,0,79,105,9,247,11,68,192,153,55,174,203,88,237,203,216,135,160,115,210,61,65,75,79,26,67,183,220,15,120,216,16,192,49,20,18,2,149,103,146,74,40,4,202,110,242,214,113,247,60,146,76,50,16,77,2,87,41,171,34,56,127,145,16,169,181,26,197,21,150,179,56,12,181,31,56,255,129,195,18,101,201,89,64,133,56,34,51,111,5,33,61,163,137,242,212,132,94,139,141,70,35,114,44,210,48,164,124,61,181,223,24,224,52,140,136,167,165,200,34,230,40,1,64,60,14,139,73,191,109,163,250,163,41,225,240,103,10,66,146,16,228,42,246,133,155,217,31,149,22,72,210,135,128,121,196,83,176,154,80,145,87,141,43,199,127,195,227,4,184,10,210,17,185,209,186,102,190,14,92,15,124,1,41,8,226,21,234,183,92,1,137,48,241,72,188,208,127,243,56,150,68,232,21,181,83,158,113,51,161,114,229,230,22,71,117,147,199,79,52,72,33,255,156,215,140,26,123,37,253,66,220,122,42,36,87,59,101,4,175,148,234,43,89,130,28,43,144,227,95,251,56,115,48,224,102,197,54,164,70,250,6,133,203,72,201,33,80,89,180,136,201,35,172,135,152,26,152,51,145,192,145,74,50,149,247,255,22,41,2,147,27,46,240,104,97,54,237,231,34,46,178,131,107,40,117,152,79,148,104,147,8,223,103,30,178,5,218,122,94,97,150,3,39,119,17,128,159,229,149,103,92,185,223,29,60,33,199,222,20,207,20,28,143,188,41,97,139,102,123,99,18,171,197,158,153,128,161,82,88,208,64,104,141,46,167,31,226,56,32,202,90,37,204,77,1,248,0,145,111,206,155,254,54,163,181,193,46,66,41,111,221,219,211,138,161,19,76,33,179,200,158,180,82,197,214,123,83,122,177,105,110,119,233,160,67,185,169,219,125,46,59,118,113,127,74,180,24,112,7,128,67,228,101,116,70,28,181,59,223,226,248,49,77,196,224,112,114,172,219,221,193,201,92,101,214,200,151,135,187,154,80,52,43,43,14,62,80,239,241,153,114,223,134,225,159,120,90,177,190,131,155,70,254,45,124,148,235,36,71,225,83,105,137,106,63,79,182,218,216,112,163,163,77,249,132,6,176,148,75,78,61,169,63,254,80,202,115,181,132,95,249,58,216,101,197,226,136,182,84,99,84,125,9,176,1,195,249,56,239,66,148,88,71,185,49,237,198,127,91,104,14,225,217,214,198,184,133,102,237,188,38,88,120,209,219,80,176,135,48,37,217,68,203,87,209,2,213,130,174,75,153,187,17,137,59,107,49,219,212,123,53,118,34,146,43,144,216,112,98,83,193,30,88,128,54,110,49,238,140,67,136,22,133,83,254,80,121,65,38,100,139,138,146,114,237,128,63,184,223,224,244,150,56,144,35,114,74,5,216,175,33,185,184,5,234,95,71,193,186,220,152,111,242,254,165,105,81,119,37,125,221,234,101,8,252,106,48,157,74,8,135,25,163,15,200,195,186,220,121,9,226,176,200,11,82,95,237,70,192,162,71,19,255,172,51,205,150,179,198,2,77,190,132,70,126,65,83,74,169,224,42,210,145,182,72,47,52,212,4,53,233,155,122,251,117,118,125,213,159,170,4,86,127,97,82,114,70,3,246,23,98,160,120,146,245,121,218,126,80,142,71,218,112,177,142,237,234,166,39,218,198,51,195,150,177,20,37,29,29,157,134,212,91,229,245,78,91,67,83,153,174,50,118,119,141,69,152,218,197,242,36,235,221,225,165,230,34,122,138,31,193,49,251,133,89,212,191,185,158,205,251,67,242,157,179,57,132,137,202,99,53,250,69,101,86,214,183,90,224,40,117,26,251,235,153,92,7,74,6,141,93,98,78,208,37,228,163,238,15,78,147,4,252,161,90,173,119,107,136,227,115,204,67,42,43,10,102,200,253,42,226,104,72,178,134,162,91,78,103,112,150,194,173,13,201,221,61,105,66,238,228,37,63,219,187,129,186,23,33,198,134,157,65,27,182,167,154,16,167,113,126,96,46,134,26,151,249,241,9,242,12,112,138,69,76,24,122,170,28,196,139,22,83,131,177,22,250,198,132,60,110,117,107,154,55,107,136,41,130,103,178,69,220,177,86,49,89,116,174,56,79,148,91,167,212,188,162,113,243,149,133,161,135,141,178,13,146,123,33,174,210,32,184,230,231,97,34,215,78,161,229,22,87,174,65,174,215,195,121,228,195,20,204,130,138,130,213,47,181,158,57,121,6,36,194,254,142,17,66,175,35,243,212,96,174,234,118,246,146,70,184,217,220,253,140,215,129,139,72,72,138,253,202,233,90,45,212,178,252,184,0,93,93,5,163,131,216,183,161,83,122,37,195,27,45,125,161,159,247,200,39,190,239,168,192,183,198,220,41,148,122,213,206,114,82,137,132,107,135,93,93,184,135,153,138,42,112,147,210,22,185,56,96,231,126,13,54,209,255,182,109,175,138,75,103,105,175,76,22,104,218,168,129,194,67,99,61,211,211,167,107,165,217,98,111,252,239,197,166,6,227,51,250,102,37,59,17,213,98,89,109,139,38,214,229,106,239,228,206,227,243,40,69,100,185,86,83,167,156,235,222,86,39,179,68,35,31,73,191,143,21,179,89,202,85,54,114,251,27,45,106,110,252,70,207,32,35,83,51,251,81,43,146,143,202,248,1,9,98,126,154,114,80,92,242,230,177,46,42,150,25,186,250,195,79,32,129,135,44,194,238,47,187,147,235,114,157,128,199,22,172,184,75,175,40,222,227,151,75,108,0,116,165,201,139,184,170,80,133,112,89,66,17,97,87,119,88,46,179,197,105,239,79,175,54,31,136,54,74,103,89,183,180,166,218,107,172,211,165,134,124,3,80,107,21,182,3,181,247,132,125,98,177,203,51,195,219,214,237,223,169,56,41,112,152,99,36,254,63,133,91,63,161,52,98,116,54,222,245,134,89,243,95,219,206,140,76,90,75,86,169,80,144,159,63,73,77,230,199,138,73,152,169,199,115,167,110,56,167,41,123,120,244,118,141,75,135,234,205,202,218,70,45,219,90,202,218,32,213,74,188,189,194,213,74,142,237,113,203,197,30,169,246,66,204,210,36,137,57,222,92,42,220,88,143,203,208,218,29,148,235,162,70,163,206,69,59,247,20,88,15,160,27,235,138,48,8,69,237,216,29,202,42,187,50,67,55,191,24,108,166,253,183,28,190,141,68,234,175,146,85,119,154,156,173,187,184,47,151,148,79,92,215,102,55,31,178,33,41,103,114,254,212,168,211,160,116,254,154,74,43,97,130,156,178,8,247,160,50,188,53,147,53,210,74,237,86,71,54,84,255,31,213,82,196,213,74,86,162,50,110,172,10,188,63,169,131,209,66,31,61,15,175,185,164,127,22,167,145,236,31,181,230,181,145,186,100,81,38,99,7,232,75,93,169,5,58,50,80,107,152,112,0,230,44,132,106,160,42,43,207,210,176,186,242,201,211,114,183,149,173,25,31,22,52,13,100,77,165,30,253,93,31,84,112,164,252,239,111,116,44,41,250,137,28,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("257acf57-fa02-4a9d-8bf4-c2ede20590ec"));
		}

		#endregion

	}

	#endregion

}


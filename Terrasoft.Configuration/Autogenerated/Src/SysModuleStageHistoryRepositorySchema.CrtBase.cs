﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysModuleStageHistoryRepositorySchema

	/// <exclude/>
	public class SysModuleStageHistoryRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysModuleStageHistoryRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysModuleStageHistoryRepositorySchema(SysModuleStageHistoryRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("606c473b-83a8-403c-b3e8-30b26e3b8597");
			Name = "SysModuleStageHistoryRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,90,91,111,219,54,20,126,118,128,254,7,214,29,48,25,48,228,247,198,118,145,186,113,231,173,9,138,37,217,75,16,12,138,68,37,194,100,201,35,169,116,110,145,255,190,195,155,174,36,45,59,233,205,79,150,68,30,126,231,240,156,143,31,41,101,193,26,211,77,16,98,116,137,9,9,104,30,51,127,145,103,113,114,87,144,128,37,121,246,226,232,203,139,163,65,65,147,236,14,93,108,41,195,235,227,214,53,180,79,83,28,242,198,148,247,13,11,66,112,198,156,205,222,227,12,147,36,172,218,44,242,245,58,207,170,235,58,26,130,109,247,253,211,140,37,44,193,212,218,96,25,132,44,39,178,5,180,121,69,240,29,0,64,171,140,97,18,131,219,175,209,10,224,157,229,81,145,226,11,22,220,225,223,18,10,29,182,127,226,77,78,19,254,79,244,155,76,38,104,74,139,245,58,32,219,185,186,254,72,242,135,36,194,20,173,49,187,207,35,138,226,156,32,138,25,227,48,130,44,66,4,51,24,249,129,95,82,110,26,221,75,219,186,17,245,181,229,73,205,244,166,184,77,147,16,37,26,97,15,128,3,62,69,165,111,103,18,206,107,244,81,88,18,248,59,14,136,27,203,36,3,216,18,155,194,228,151,141,39,237,214,211,77,64,130,53,202,32,99,102,67,204,3,191,189,8,239,241,58,184,90,69,195,185,152,9,112,77,220,65,16,23,184,142,19,76,252,233,68,244,171,204,64,88,10,146,209,249,148,98,140,66,130,227,217,176,238,216,133,4,50,156,204,167,19,221,148,247,53,180,17,14,120,239,139,36,66,45,60,163,99,135,219,239,49,59,208,107,233,221,57,252,111,59,204,159,127,85,87,1,180,71,33,159,120,50,149,40,156,110,94,4,15,248,64,63,19,168,215,97,31,212,149,191,15,57,204,2,31,210,51,161,231,6,119,207,73,144,166,77,188,212,2,120,117,154,21,107,76,130,219,20,79,13,195,205,185,185,147,52,245,244,144,175,112,22,201,234,128,171,71,201,4,245,91,38,102,64,54,106,88,4,16,255,175,200,10,136,229,8,250,196,36,95,163,144,143,245,20,154,80,96,37,67,216,35,159,80,57,20,216,3,62,13,210,228,51,142,44,177,191,205,243,20,173,168,48,188,170,90,163,47,232,14,179,99,244,200,219,236,98,156,13,14,129,28,66,115,0,0,67,229,247,51,112,81,145,37,255,22,248,91,82,146,225,254,254,44,117,18,69,150,248,64,126,236,21,31,213,111,56,191,132,9,182,172,68,207,21,18,73,3,152,213,219,94,230,34,89,140,196,160,0,244,227,6,206,34,180,85,24,182,0,28,136,127,31,102,217,193,36,139,52,160,176,10,27,203,242,100,179,129,234,21,2,75,87,168,46,242,36,187,7,105,196,162,60,68,19,14,233,250,29,142,131,34,101,111,33,177,120,34,177,237,6,231,177,231,40,247,209,24,241,197,1,205,208,176,54,206,112,116,83,209,70,200,177,245,131,182,139,7,155,226,3,244,31,100,88,198,184,252,32,201,67,192,36,83,14,54,242,2,133,252,57,82,11,153,176,240,7,222,114,164,166,201,49,177,247,160,62,26,144,237,6,19,46,0,249,112,57,3,121,137,35,39,1,241,18,40,40,38,28,72,38,213,168,37,139,54,218,30,186,130,246,139,178,121,251,178,226,189,54,86,43,210,93,186,108,15,74,22,72,229,156,90,137,153,183,25,0,72,245,111,240,16,144,106,177,153,241,209,234,193,95,66,121,201,122,21,57,14,63,89,31,85,151,151,51,148,21,105,42,159,10,190,55,56,223,156,40,145,22,164,224,90,220,57,61,21,110,168,120,148,225,79,224,61,207,39,88,223,242,24,49,136,70,189,158,251,164,47,84,184,204,246,190,108,89,52,166,87,146,102,59,99,234,108,169,162,223,11,140,215,202,157,230,88,35,53,65,205,187,254,226,30,135,255,156,144,59,224,165,140,157,67,224,61,14,20,40,160,213,91,77,87,107,136,89,107,144,99,53,95,106,126,44,233,90,237,33,76,69,188,122,151,8,91,16,195,41,95,215,198,200,70,149,134,251,212,211,126,246,206,67,244,230,141,120,26,196,56,221,58,115,181,92,207,254,10,210,2,83,127,153,147,83,120,238,61,240,75,52,155,87,37,0,215,126,39,84,87,221,80,13,30,149,233,86,21,52,227,120,64,100,92,206,40,152,106,72,119,96,120,145,244,26,85,197,232,241,57,230,210,138,213,235,103,111,212,140,180,223,46,148,107,189,52,220,28,35,11,193,244,219,242,182,87,211,178,92,159,42,221,122,229,112,149,242,173,244,188,36,91,104,42,146,212,107,89,30,163,188,96,136,219,37,152,194,186,223,76,63,121,175,62,145,78,55,15,149,99,202,59,189,109,180,82,144,110,175,64,114,212,114,209,154,245,44,88,209,250,90,143,115,218,12,197,13,152,81,143,76,220,230,200,26,232,40,44,247,14,84,111,221,119,208,188,183,184,67,177,147,157,138,197,221,3,165,229,42,59,195,235,238,54,245,89,101,165,28,161,175,162,108,32,218,79,78,90,4,158,83,222,53,78,16,156,27,133,74,226,65,31,6,78,124,8,62,111,167,213,17,102,47,42,155,35,61,219,210,63,165,7,53,191,82,33,14,209,76,228,1,231,234,131,198,40,79,50,58,144,149,234,107,96,48,108,203,21,140,239,166,141,221,114,227,135,80,199,160,14,236,113,172,19,137,205,139,111,39,114,27,21,245,93,21,110,3,201,79,40,111,191,181,94,104,228,151,92,7,118,139,1,211,224,63,159,56,72,98,228,189,180,87,152,54,59,112,144,217,12,65,125,225,218,198,83,24,53,197,20,50,130,5,80,86,32,6,60,139,186,24,149,35,90,38,229,106,19,1,131,219,186,143,117,60,198,200,208,223,42,105,84,48,30,17,78,41,222,1,224,36,138,118,142,62,170,69,163,121,246,250,92,82,71,37,151,9,99,83,199,244,81,49,61,69,76,235,245,219,94,98,165,234,59,234,41,80,170,30,86,117,210,126,221,214,225,253,190,103,94,70,235,23,229,27,29,113,20,102,106,242,179,29,134,181,246,197,118,201,135,254,166,214,103,174,83,225,75,177,248,87,235,166,125,132,157,62,185,208,57,30,117,14,214,28,158,192,188,186,158,194,62,222,115,247,230,59,12,235,115,79,115,172,36,89,135,37,191,43,129,74,26,28,240,155,141,50,119,97,210,35,74,30,214,44,225,158,204,178,57,149,122,203,237,178,56,164,217,83,120,245,17,144,79,215,95,21,27,124,87,241,85,193,248,129,148,87,63,221,165,121,178,73,19,66,145,116,179,208,85,159,98,23,160,29,148,139,100,245,161,9,4,181,252,59,67,75,204,194,123,179,169,178,153,222,177,199,57,193,96,25,121,124,163,47,69,153,120,47,89,54,28,25,78,211,97,12,158,77,38,77,216,12,158,174,29,189,184,47,147,52,229,71,35,18,191,18,129,186,145,220,193,90,116,154,75,5,232,168,118,162,210,47,16,181,147,142,70,24,185,139,109,147,45,255,198,187,150,57,125,250,83,26,240,63,228,65,212,58,46,169,158,26,15,46,29,73,177,131,44,27,158,149,212,1,149,64,165,123,215,55,176,144,113,55,23,141,167,162,78,188,118,5,143,91,107,224,8,61,74,47,196,142,51,169,239,143,78,51,46,186,162,206,65,179,15,120,87,116,137,3,112,91,55,242,134,74,241,213,224,255,158,67,88,128,184,178,59,189,237,26,214,180,181,105,168,50,75,85,72,133,230,146,223,68,109,249,168,83,71,20,231,158,62,231,25,183,195,84,79,183,3,77,215,223,76,90,236,63,251,161,239,19,15,249,28,10,163,254,86,216,250,170,160,231,134,204,246,13,205,19,183,95,245,13,132,254,52,162,147,136,245,70,103,65,6,32,136,204,31,145,162,106,149,124,187,229,37,236,245,43,241,26,127,206,212,176,254,2,184,149,97,69,118,70,102,148,61,124,65,84,156,24,223,189,45,55,66,242,179,137,22,121,154,136,83,217,16,241,140,3,216,109,169,251,142,105,236,67,178,125,38,114,191,111,213,186,217,230,78,54,219,185,131,225,235,146,78,50,238,118,65,220,197,255,133,120,35,87,80,161,130,86,12,175,207,115,182,204,139,44,58,213,207,134,243,85,12,235,111,246,43,67,49,64,42,193,223,110,149,228,129,174,221,15,231,38,115,208,55,165,253,93,81,51,127,246,86,143,152,118,183,87,50,139,52,6,95,84,10,215,76,250,96,226,248,121,230,129,182,102,128,147,115,105,80,190,59,47,121,153,221,147,252,147,90,107,248,23,176,190,49,210,222,47,195,139,234,59,67,64,245,165,66,254,56,52,177,177,97,186,91,60,218,253,120,69,220,57,58,250,31,86,129,9,9,19,44,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("606c473b-83a8-403c-b3e8-30b26e3b8597"));
		}

		#endregion

	}

	#endregion

}


﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysSyncMetaDataActualizerSchema

	/// <exclude/>
	public class SysSyncMetaDataActualizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysSyncMetaDataActualizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysSyncMetaDataActualizerSchema(SysSyncMetaDataActualizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("505880b2-c188-4a89-a971-eb8c1bb83687");
			Name = "SysSyncMetaDataActualizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,26,217,110,219,56,240,57,5,250,15,172,11,20,50,16,40,239,73,227,69,82,59,133,128,77,91,212,105,251,80,244,129,145,232,132,187,58,188,36,149,52,61,254,125,135,151,68,74,180,44,59,217,237,67,18,145,115,113,102,56,23,139,74,92,16,190,198,41,65,87,132,49,204,171,149,136,223,84,229,138,222,212,12,11,90,149,207,159,253,124,254,236,160,230,180,188,65,203,7,46,72,113,210,249,6,248,60,39,169,4,230,241,91,82,18,70,211,65,152,164,40,106,129,175,115,210,131,154,99,129,219,69,87,162,162,168,202,240,14,35,155,214,227,249,121,104,107,249,80,74,249,96,231,37,35,55,32,17,122,147,99,206,143,165,16,114,239,146,8,44,5,57,75,69,141,115,250,131,48,5,124,116,116,132,94,243,186,40,48,123,152,153,111,133,136,104,177,206,73,65,74,161,20,134,170,21,192,17,130,82,70,86,167,147,68,146,188,101,85,73,127,168,109,80,174,96,82,25,108,114,52,139,45,221,35,135,240,186,190,206,105,138,82,69,123,163,76,232,24,109,38,13,84,164,213,154,3,94,80,146,103,199,232,3,171,4,24,129,100,234,64,189,19,169,133,101,122,75,10,140,42,150,17,22,55,80,174,124,7,107,75,6,209,82,24,132,247,18,254,100,128,238,71,82,0,22,226,2,12,131,104,6,218,162,43,58,130,197,219,154,102,104,41,177,146,108,4,125,10,110,132,164,83,111,37,204,5,147,126,161,241,18,64,123,7,88,134,195,75,82,102,90,117,230,219,232,17,204,112,91,101,92,106,146,222,97,65,244,238,90,127,160,187,10,68,109,44,52,7,147,209,220,26,46,250,196,9,3,3,149,250,18,160,218,251,60,68,22,46,41,87,21,42,156,143,41,82,150,60,112,215,226,37,17,31,48,3,29,130,69,215,132,9,74,120,228,83,156,158,40,172,59,204,80,70,185,188,108,25,72,70,239,168,120,0,76,65,83,186,198,165,0,248,140,42,121,78,59,18,193,69,22,9,191,32,88,212,140,44,74,69,32,154,188,35,247,151,132,8,208,91,82,10,114,163,35,196,100,170,88,29,188,122,229,9,30,47,192,196,226,65,187,135,212,45,58,61,69,147,128,16,19,45,42,93,161,200,195,215,39,52,246,201,226,132,191,171,243,252,61,91,20,107,241,16,77,209,175,95,163,78,102,245,119,192,8,28,165,212,188,126,135,57,202,251,116,166,237,3,178,182,95,241,27,6,138,32,13,169,164,4,93,137,198,180,93,91,122,230,51,12,17,201,57,177,248,141,143,236,68,66,253,220,13,245,16,9,86,19,77,224,119,192,89,59,7,121,172,143,74,111,163,138,36,248,83,73,238,13,253,174,107,198,224,60,85,52,233,132,54,235,70,210,185,163,201,159,85,138,243,36,155,28,34,200,28,117,81,74,111,0,31,18,132,69,1,39,75,178,169,135,253,153,48,46,61,115,27,246,101,149,201,40,148,189,47,125,124,235,116,91,9,248,62,58,237,31,97,9,73,129,132,200,244,189,43,32,129,137,123,65,124,189,229,99,105,74,112,156,189,79,222,174,239,77,194,8,113,254,48,66,127,198,227,4,78,69,247,44,150,252,99,233,72,69,183,65,104,164,67,181,8,97,161,146,114,192,52,139,239,233,45,46,111,8,8,196,5,143,141,31,108,54,215,211,16,115,242,112,208,95,218,237,160,175,155,4,24,66,245,33,166,38,30,233,139,30,47,190,147,180,22,36,218,28,100,250,33,107,223,56,115,136,174,171,42,71,148,235,107,215,16,134,104,179,194,16,95,221,56,68,76,96,128,189,62,252,31,40,112,139,1,246,56,148,193,84,221,225,81,117,115,218,88,234,14,78,144,75,187,223,114,227,78,62,10,242,113,130,200,167,117,38,53,222,161,221,2,180,73,150,15,103,57,4,121,252,69,194,117,249,210,74,21,117,143,62,29,200,172,82,120,220,53,187,201,9,90,208,94,218,26,78,7,143,13,232,79,16,214,158,246,234,15,39,135,214,68,6,43,254,114,75,24,105,211,34,228,80,190,248,7,244,27,245,112,73,55,35,158,149,89,55,159,12,160,119,165,85,216,157,24,186,149,187,235,37,65,199,123,225,57,222,156,228,196,41,175,66,158,211,91,211,160,70,62,55,229,12,8,55,148,50,16,230,198,53,93,71,238,177,13,199,187,17,253,194,136,206,139,8,132,51,93,181,226,28,173,181,216,140,163,85,229,220,38,117,191,65,76,204,55,116,56,106,69,33,171,62,232,116,210,53,201,100,246,250,72,237,119,26,162,59,202,36,15,29,180,65,24,105,160,15,86,136,200,180,75,61,251,26,163,9,232,67,239,213,253,126,87,137,196,54,196,36,131,11,65,214,242,68,190,194,130,10,128,150,67,150,143,2,151,41,233,116,209,110,74,48,125,243,127,113,116,47,243,128,56,238,119,148,204,169,114,87,224,246,90,107,227,16,85,215,127,1,133,153,53,22,68,169,167,84,72,2,61,76,10,30,201,81,6,130,228,28,113,117,146,177,167,231,254,173,157,117,198,5,134,154,238,150,93,189,40,66,58,168,243,217,21,52,16,8,110,175,1,166,90,22,154,195,217,5,196,164,123,10,109,141,74,190,64,194,226,132,149,171,114,119,32,177,24,207,242,165,221,67,141,99,174,161,26,173,12,77,17,234,146,143,158,222,116,6,63,163,47,164,159,250,192,39,91,126,126,101,164,120,152,11,209,183,144,75,178,245,191,201,76,215,19,74,159,174,181,91,16,143,148,153,54,169,75,111,99,219,150,250,108,183,139,32,35,255,139,49,195,133,38,119,226,28,236,136,217,23,10,86,171,213,29,204,84,65,176,165,224,112,163,59,100,140,238,245,117,36,211,152,189,16,55,220,7,180,121,44,224,195,91,90,136,94,227,223,25,14,253,143,19,132,112,198,210,171,157,197,206,120,212,178,50,213,50,208,221,54,23,53,225,75,201,130,84,206,122,218,225,168,107,95,61,242,220,62,244,236,13,0,47,160,222,161,55,165,46,22,70,204,0,219,145,219,136,120,162,117,229,69,218,13,115,73,125,46,35,83,175,101,248,137,110,136,56,65,142,240,242,115,40,119,24,206,205,248,108,60,91,139,178,63,211,109,236,212,76,183,105,186,118,103,99,34,220,40,54,182,135,219,159,205,174,198,235,205,61,119,231,108,99,158,44,251,100,188,28,100,235,76,45,157,63,247,62,110,97,250,28,4,68,82,117,41,208,29,206,235,45,103,135,107,72,174,40,28,182,109,159,30,115,238,234,190,36,12,216,171,242,124,196,115,129,99,112,175,174,223,95,13,250,232,92,159,157,203,79,243,126,53,44,66,243,182,53,144,35,117,168,249,172,9,27,1,183,52,18,170,159,100,117,10,205,153,31,117,12,219,71,20,170,238,208,27,57,99,201,105,11,250,117,210,46,79,190,233,100,178,104,231,43,145,212,187,7,110,55,125,96,111,108,210,7,119,74,213,111,241,85,181,84,146,155,242,238,192,113,43,96,104,189,205,99,234,244,248,134,173,239,10,33,65,61,8,139,230,217,7,176,70,216,212,35,234,226,91,154,80,108,244,18,205,206,61,164,247,230,180,169,109,11,176,49,150,230,247,84,164,183,40,234,213,39,182,170,72,49,84,24,193,39,154,99,211,110,247,136,35,231,77,7,52,120,98,224,174,161,33,255,251,36,68,117,152,212,6,18,25,89,225,58,23,199,200,89,28,168,102,58,186,27,145,167,101,239,189,103,245,222,41,150,101,113,51,84,208,135,106,239,142,5,123,79,123,131,245,184,181,94,147,79,173,159,187,110,248,181,167,237,111,206,152,145,200,208,102,198,115,75,245,209,125,178,49,54,137,53,190,243,64,210,219,233,142,138,236,254,5,171,138,192,155,79,124,198,97,117,121,57,111,33,205,168,75,45,30,162,49,35,47,123,116,59,180,106,198,86,134,196,200,241,80,96,34,164,181,161,85,165,255,31,65,52,63,215,109,82,197,80,118,221,252,217,123,63,93,148,28,154,155,249,121,187,20,181,125,128,33,149,72,29,124,36,56,131,92,199,244,175,83,99,13,59,103,210,187,81,203,169,37,162,122,17,141,22,75,48,135,190,245,134,166,148,59,53,244,101,231,229,248,133,9,99,51,215,160,39,62,9,47,104,111,33,210,181,189,37,165,123,52,243,107,167,46,4,86,224,223,191,225,180,209,166,166,34,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("505880b2-c188-4a89-a971-eb8c1bb83687"));
		}

		#endregion

	}

	#endregion

}


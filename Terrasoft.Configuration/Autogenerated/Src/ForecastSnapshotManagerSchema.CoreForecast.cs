﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastSnapshotManagerSchema

	/// <exclude/>
	public class ForecastSnapshotManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastSnapshotManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastSnapshotManagerSchema(ForecastSnapshotManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("34f3862d-5486-8119-3fe1-90c54ebc44c4");
			Name = "ForecastSnapshotManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,90,75,111,219,56,16,62,187,64,255,3,235,189,200,64,96,3,123,76,98,23,73,28,55,6,182,216,32,78,123,89,44,2,70,26,219,218,202,146,151,164,156,26,65,254,123,249,212,147,148,100,39,89,96,123,112,37,114,134,51,252,230,73,42,40,198,27,160,91,236,3,186,7,66,48,77,150,108,120,149,196,203,112,149,18,204,194,36,30,206,18,2,62,166,236,251,239,31,63,60,127,252,208,75,105,24,175,208,98,79,25,108,206,42,239,156,53,138,192,23,124,116,248,5,98,32,161,95,163,249,35,140,255,205,7,139,98,9,184,198,135,211,75,231,212,12,251,44,33,33,80,78,193,105,126,35,176,226,242,209,60,102,64,150,124,103,167,104,190,136,241,150,174,19,38,9,70,163,17,58,167,233,102,131,201,126,162,223,111,73,178,11,3,160,104,75,146,45,16,198,87,67,79,33,91,35,170,57,81,128,25,30,26,238,81,129,125,155,62,70,161,143,66,35,174,40,173,39,0,171,9,148,3,247,107,64,75,13,109,93,74,93,76,207,216,193,172,62,229,164,168,244,242,140,86,192,206,16,21,63,47,156,229,69,225,1,113,160,32,113,194,83,93,250,43,142,241,10,72,59,90,27,96,235,36,160,136,37,104,131,127,88,54,68,59,66,230,212,160,1,193,175,66,34,142,3,68,241,14,50,137,14,244,228,200,22,19,188,65,194,229,199,125,163,234,60,232,79,74,182,8,131,225,249,72,82,58,24,195,136,171,173,98,68,179,202,17,228,203,161,58,51,1,150,146,152,78,206,41,0,242,9,44,199,253,197,26,128,245,71,147,243,145,153,20,212,143,73,18,161,5,223,140,65,193,251,146,134,1,202,53,61,65,179,130,112,84,212,100,112,214,102,240,171,8,83,122,138,108,110,228,52,116,179,147,186,236,234,11,73,14,65,194,158,98,175,70,171,219,44,222,78,209,173,100,87,243,86,139,207,50,85,4,126,220,82,16,179,112,25,2,113,24,93,235,35,81,148,144,207,131,106,144,116,149,37,246,140,146,199,127,120,114,107,22,38,229,232,223,174,178,4,204,25,186,135,237,74,115,29,176,177,69,193,140,128,24,15,162,184,89,16,55,28,220,135,27,144,15,54,49,21,135,235,226,133,211,112,185,60,191,159,52,58,94,192,105,58,250,90,182,220,171,220,75,8,141,225,9,113,195,39,36,160,205,168,204,175,227,116,3,4,63,70,192,37,163,43,2,28,157,238,86,16,178,252,53,142,87,156,231,24,121,223,182,193,193,242,8,108,146,221,145,242,166,16,129,67,222,17,230,255,175,11,142,90,19,0,71,52,209,41,216,85,114,250,104,36,56,254,154,194,18,167,17,187,12,227,128,247,28,30,219,111,33,89,122,46,174,193,224,239,182,252,167,41,81,83,189,173,186,239,44,132,40,16,174,75,194,29,55,183,154,220,170,151,124,153,155,144,138,6,200,199,209,13,207,26,152,248,235,253,93,242,36,242,237,29,108,19,26,242,201,61,122,88,103,84,124,146,230,51,103,214,53,101,2,43,178,211,242,128,131,75,111,168,196,88,27,179,243,94,243,172,199,246,102,133,5,144,93,200,59,131,7,31,162,136,234,183,131,24,113,16,64,32,182,218,200,44,80,154,243,42,138,185,98,232,33,40,188,117,161,207,49,157,182,114,58,212,12,84,96,181,42,234,96,55,1,240,167,44,77,223,113,148,66,133,230,204,26,165,121,68,242,86,157,145,84,180,208,149,28,169,189,217,225,172,222,55,42,123,143,88,181,251,40,45,189,14,144,236,219,122,21,162,113,133,76,110,213,158,70,236,41,156,36,140,115,66,96,34,65,191,182,85,221,156,176,162,80,229,181,145,181,177,1,239,144,24,91,139,146,201,188,13,209,100,25,82,64,175,196,198,229,83,79,181,148,182,192,67,159,63,35,207,54,62,86,137,89,157,164,246,252,228,198,206,27,180,152,120,74,80,79,20,203,130,255,92,144,21,47,25,49,243,250,101,43,247,79,42,56,15,6,178,93,149,166,231,191,84,26,205,174,215,78,120,180,58,206,24,71,169,194,212,41,253,29,68,92,131,52,92,114,220,92,9,20,141,199,40,78,163,200,248,124,175,215,64,218,0,116,23,213,50,232,123,125,93,160,250,39,102,228,120,107,156,233,37,26,246,136,105,126,174,29,12,23,80,138,2,47,155,209,43,189,148,61,177,177,244,148,157,160,1,185,14,174,80,173,90,213,119,119,172,84,8,85,160,84,6,27,163,164,76,251,94,33,82,211,168,3,40,246,202,113,37,234,170,125,202,137,82,177,22,43,136,74,35,77,248,88,37,77,188,190,84,35,243,225,183,69,171,162,220,209,80,93,4,188,149,16,238,120,32,92,213,14,68,65,86,27,61,6,182,11,177,200,131,88,229,157,176,179,104,121,52,126,211,188,197,57,16,193,122,115,164,48,180,140,31,131,162,86,236,61,113,180,106,218,1,201,82,159,105,6,47,124,150,150,91,205,6,232,138,84,10,180,226,72,19,92,69,1,239,148,200,42,186,28,11,200,141,181,255,110,173,223,37,226,166,234,61,125,21,100,111,80,145,119,152,160,48,87,192,185,9,156,159,55,139,227,217,58,2,128,108,157,79,213,29,247,204,212,48,7,214,217,28,141,15,234,165,140,2,47,45,141,65,237,252,228,106,11,166,7,123,142,61,231,204,90,15,78,5,55,26,79,186,156,180,84,152,117,160,27,107,80,14,207,88,10,242,253,195,148,132,81,20,36,79,241,27,180,127,122,1,253,191,118,25,218,125,215,198,8,29,206,114,95,213,245,141,227,66,99,151,136,27,77,188,3,217,20,100,151,224,197,155,40,113,233,57,65,132,103,83,227,189,238,62,102,88,186,74,55,15,39,242,138,175,116,143,174,195,224,78,94,139,205,3,202,119,36,36,40,47,28,20,247,85,211,84,230,245,110,138,54,119,17,239,173,172,10,25,200,43,136,103,244,114,23,151,161,102,18,74,123,178,193,213,250,88,50,205,173,248,230,65,51,237,56,135,153,153,137,99,255,13,142,131,168,132,150,216,111,71,165,203,89,62,83,92,228,180,79,101,95,22,65,52,167,51,192,60,189,192,117,44,44,17,120,125,163,47,23,111,164,247,7,131,114,193,44,230,156,230,234,242,230,168,220,148,142,60,135,224,99,71,181,197,15,5,108,175,71,173,230,252,82,68,17,197,122,32,23,72,14,85,66,231,189,60,237,229,154,136,18,89,252,18,198,113,173,6,205,51,170,134,11,122,209,133,169,189,12,184,34,179,246,245,77,111,220,109,40,183,161,91,76,214,214,64,191,67,242,104,207,224,109,95,83,236,159,103,81,178,204,47,237,27,190,118,255,31,190,215,234,70,227,85,159,109,181,73,212,205,229,184,122,97,33,130,66,14,121,249,106,218,215,178,139,199,113,41,251,148,255,32,64,199,170,254,244,57,46,234,84,152,50,114,149,27,168,229,213,95,90,120,211,203,235,159,224,167,162,215,10,30,179,199,113,165,133,24,94,199,148,71,237,244,50,31,242,242,0,205,25,135,11,134,9,187,39,56,166,88,83,233,48,100,217,229,76,190,179,2,12,188,118,214,238,152,122,142,234,80,153,46,86,60,51,85,208,232,42,217,108,66,171,74,47,200,199,204,95,35,239,250,167,15,91,121,61,12,230,41,111,157,11,75,221,37,81,244,136,253,31,182,197,122,108,205,3,173,116,59,166,126,117,39,204,155,182,166,6,202,246,77,77,142,241,127,191,0,163,1,155,55,195,35,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34f3862d-5486-8119-3fe1-90c54ebc44c4"));
		}

		#endregion

	}

	#endregion

}

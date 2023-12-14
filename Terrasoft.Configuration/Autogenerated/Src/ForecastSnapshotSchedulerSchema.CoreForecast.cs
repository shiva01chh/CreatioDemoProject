﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastSnapshotSchedulerSchema

	/// <exclude/>
	public class ForecastSnapshotSchedulerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastSnapshotSchedulerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastSnapshotSchedulerSchema(ForecastSnapshotSchedulerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e222a5cb-76eb-404f-88b1-1a851d6e06f9");
			Name = "ForecastSnapshotScheduler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,25,107,115,219,54,242,179,59,211,255,128,242,250,129,234,169,116,122,247,205,177,229,241,217,78,170,52,118,114,177,219,206,244,49,30,152,132,36,166,20,201,2,160,109,197,227,255,126,187,120,144,0,69,82,114,220,92,147,100,34,17,220,93,236,251,165,156,46,153,40,105,204,200,37,227,156,138,98,38,163,227,34,159,165,243,138,83,153,22,121,244,162,224,44,166,66,254,244,175,47,191,184,255,242,139,157,74,164,249,156,92,172,132,100,203,231,173,103,64,205,50,22,35,158,136,94,178,156,241,52,94,131,121,157,230,127,54,135,243,172,184,166,217,222,222,113,177,92,194,109,175,139,249,28,142,155,247,231,236,86,2,53,228,235,149,40,242,230,197,127,43,202,229,135,246,115,52,93,150,89,116,70,101,188,96,92,116,191,189,228,233,124,238,189,117,101,71,54,186,223,112,214,119,30,157,230,50,149,41,235,33,9,0,47,104,44,11,174,33,0,230,31,156,205,65,73,100,154,75,198,103,160,254,61,50,181,138,190,200,105,41,22,133,188,0,17,146,42,99,28,224,225,223,238,238,46,217,23,213,114,73,249,106,98,158,223,242,226,38,77,152,32,177,50,25,41,121,81,50,142,140,144,89,193,201,159,74,104,34,44,161,200,146,217,117,232,148,213,117,150,198,164,4,208,148,102,36,206,168,16,70,93,53,7,218,35,0,24,29,192,98,188,172,210,132,88,166,167,9,185,39,115,38,159,19,129,255,61,32,156,3,43,36,71,165,28,243,34,103,167,119,37,103,66,160,248,67,40,211,211,188,90,50,78,175,51,182,143,87,77,200,91,112,167,34,153,38,98,16,79,153,98,101,63,134,32,47,211,37,251,5,24,154,230,179,194,127,104,99,61,108,97,130,37,147,139,34,209,138,183,26,199,7,165,30,34,140,81,201,251,226,90,12,217,33,181,30,49,236,16,202,16,109,126,212,193,59,182,44,110,128,159,250,198,152,51,21,201,120,117,84,163,237,182,241,246,193,3,232,146,228,144,16,14,2,237,79,193,228,114,193,140,47,52,94,100,156,45,218,223,85,24,138,192,77,1,190,160,111,126,85,92,135,157,238,99,240,70,58,2,186,153,183,161,249,55,112,111,174,126,18,251,199,11,22,255,33,8,173,100,241,109,45,1,120,145,4,231,135,32,93,208,124,206,196,167,146,66,17,224,76,86,60,23,147,19,38,210,121,78,33,231,0,140,61,68,168,235,162,200,200,84,28,1,139,181,95,25,6,143,21,127,201,199,139,95,163,136,198,241,81,23,75,176,96,92,155,244,147,90,209,178,96,99,199,149,115,163,96,24,231,152,156,89,158,232,252,236,229,234,99,204,140,123,100,32,42,109,88,167,57,20,159,84,38,69,76,118,145,181,95,79,216,140,86,153,252,79,154,39,160,232,80,174,74,86,204,194,254,0,31,141,126,111,50,130,206,200,189,176,100,67,233,184,215,6,171,165,128,98,42,105,46,65,146,183,60,189,161,146,13,249,51,228,107,194,154,124,45,57,205,69,6,56,123,228,244,134,241,21,73,232,138,80,112,241,146,197,233,12,120,149,144,69,199,228,22,196,103,228,254,217,3,73,33,47,166,121,37,33,31,209,28,74,196,119,234,104,81,84,188,47,12,74,205,20,90,5,211,102,83,55,154,178,113,89,102,228,128,4,207,212,13,72,242,144,124,131,127,3,227,155,150,4,200,137,126,7,9,36,41,242,108,69,92,95,192,116,79,174,18,109,23,245,112,64,114,118,187,6,19,142,136,74,181,59,223,35,207,0,244,239,177,122,60,51,82,29,144,103,248,252,96,174,110,185,78,173,245,23,41,203,146,182,202,45,159,53,131,83,232,126,200,85,86,168,246,167,227,245,81,89,214,150,253,153,83,40,245,228,202,134,4,62,195,65,55,230,143,66,121,123,174,91,51,114,85,121,207,27,120,87,30,195,43,236,95,80,2,229,148,67,62,211,128,111,27,233,62,59,193,4,190,75,118,39,209,7,204,217,122,162,115,241,111,181,236,13,98,147,39,204,43,15,223,196,85,111,208,132,45,117,249,236,141,59,237,96,238,177,222,210,54,11,248,201,173,99,160,157,150,5,224,245,154,73,16,10,92,1,94,129,87,156,209,156,66,113,130,158,90,98,135,12,60,162,228,144,67,6,82,136,162,241,48,108,219,183,117,195,136,190,89,72,184,157,37,195,40,103,186,207,233,241,229,174,186,66,128,235,174,243,208,68,183,88,48,86,31,90,13,166,51,18,122,47,200,1,68,104,149,101,22,96,71,87,53,117,166,213,165,250,187,157,27,202,235,234,115,225,19,32,56,65,128,146,33,117,201,8,42,36,36,105,154,165,31,216,155,235,247,32,248,190,11,61,241,47,215,202,220,233,148,142,118,29,30,116,243,112,24,185,36,52,81,35,71,23,25,215,132,77,86,83,74,3,157,250,89,49,196,116,117,81,210,188,246,126,60,176,218,50,151,104,100,156,233,160,38,135,107,105,117,236,225,70,38,201,181,78,85,38,28,117,177,102,122,139,118,63,97,90,113,166,62,44,67,104,38,221,16,37,48,52,86,203,28,117,166,65,208,203,143,221,87,63,209,172,98,34,28,121,250,242,145,163,163,124,21,198,234,59,57,152,16,253,45,58,135,32,137,78,97,12,202,68,24,24,182,2,63,50,6,27,153,39,246,161,179,122,56,10,38,54,80,73,154,12,39,179,216,51,10,228,180,119,111,206,191,109,106,240,48,178,116,166,24,221,57,225,201,7,56,129,193,98,166,172,222,166,97,141,231,181,79,216,5,171,249,174,17,97,108,61,207,103,112,236,79,78,46,3,214,212,6,15,20,247,146,23,85,137,70,1,91,131,145,95,57,39,161,123,147,85,22,0,92,66,175,164,130,198,88,191,33,102,26,118,143,156,115,182,45,65,116,68,165,13,38,153,170,240,216,6,156,164,42,13,131,101,247,245,133,99,82,168,36,49,169,27,130,157,123,18,52,211,111,48,118,84,69,30,198,53,200,84,64,53,209,155,15,44,43,0,7,197,145,233,89,84,181,13,240,49,5,182,78,152,164,105,134,114,1,11,237,242,17,29,163,247,49,213,129,2,236,126,59,235,159,222,177,24,36,226,147,208,215,203,216,83,186,97,234,170,93,207,26,233,53,115,142,98,164,166,101,180,130,249,194,80,199,69,202,240,101,45,63,169,213,102,221,5,104,186,206,226,234,99,77,252,169,234,89,99,22,185,254,9,183,141,45,131,163,166,96,70,72,45,252,58,56,170,7,143,238,33,156,220,166,114,161,244,61,71,158,201,111,193,189,203,255,195,111,193,56,32,255,212,60,127,29,40,64,171,13,140,53,3,239,200,15,24,170,201,117,252,0,96,154,39,124,191,160,9,185,102,44,39,101,70,193,0,73,20,108,85,166,155,154,187,169,251,122,167,71,61,2,238,86,98,163,238,8,136,92,127,76,230,178,77,213,108,219,12,246,94,7,89,131,169,116,135,97,215,59,174,190,108,56,244,199,85,127,127,212,206,25,107,41,170,21,231,196,176,226,22,29,172,179,240,250,140,242,63,148,99,27,16,108,47,186,178,4,12,23,1,162,4,48,103,53,173,134,73,26,18,242,133,246,144,16,226,227,215,223,201,61,217,216,151,185,137,34,186,44,46,148,100,33,28,251,140,61,140,162,159,113,140,10,239,160,158,233,59,118,238,200,87,166,7,242,42,161,38,17,189,42,210,60,12,174,130,177,230,108,115,149,235,244,21,215,199,63,87,111,185,116,121,220,236,47,110,81,248,28,60,134,252,5,206,18,24,59,5,235,126,163,157,197,241,30,242,68,191,105,175,51,172,146,159,186,74,50,42,54,171,28,181,59,59,226,243,106,9,93,224,57,48,107,71,28,3,109,120,55,208,186,167,220,132,100,192,44,174,98,56,173,251,211,243,194,182,153,96,147,175,214,251,86,159,198,243,122,44,233,162,208,158,74,102,208,114,178,246,88,34,154,233,192,23,3,252,20,221,199,109,119,77,223,49,113,250,214,129,25,4,28,170,243,252,160,127,246,242,39,27,148,171,151,72,247,224,213,41,98,145,37,23,155,164,124,147,125,188,160,64,255,145,130,58,28,249,110,224,65,75,108,175,26,103,232,81,133,157,37,122,184,240,195,171,255,134,173,35,236,49,107,245,167,68,83,211,199,250,136,167,203,82,174,90,33,213,192,142,214,90,242,161,254,126,13,125,99,87,174,218,22,243,83,30,18,116,30,247,1,229,7,182,154,68,234,16,43,7,77,115,17,186,44,56,132,222,43,96,209,213,88,215,157,165,102,23,193,66,247,222,17,100,221,215,169,144,118,248,236,39,112,194,50,232,161,129,134,98,3,9,125,146,166,212,237,73,215,187,205,53,37,123,77,103,162,88,108,55,157,155,61,240,227,151,234,255,247,20,239,110,127,166,201,86,137,86,253,184,24,6,208,188,56,52,62,93,170,238,89,23,61,34,79,119,83,232,76,210,110,122,110,242,8,206,114,157,102,107,134,219,23,174,14,27,133,106,114,27,120,137,166,226,52,199,223,109,155,170,184,182,122,151,122,229,222,137,142,0,250,6,109,10,103,249,4,40,166,23,70,25,236,198,43,68,106,135,122,49,69,14,15,189,189,190,62,29,19,13,98,215,246,109,160,122,211,245,204,200,182,211,185,236,208,118,106,237,221,188,117,155,193,118,231,84,183,219,108,239,78,140,111,121,43,20,224,205,125,142,126,148,241,200,177,227,214,81,187,237,15,154,127,95,225,152,246,175,89,30,179,146,233,91,200,172,221,251,216,189,204,95,86,216,222,228,174,119,108,191,194,122,52,233,181,242,212,4,253,208,178,198,218,227,243,217,67,169,230,178,119,17,117,145,194,196,202,182,93,69,109,44,221,195,91,165,238,221,76,215,79,197,234,12,255,252,15,58,150,39,47,86,37,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e222a5cb-76eb-404f-88b1-1a851d6e06f9"));
		}

		#endregion

	}

	#endregion

}


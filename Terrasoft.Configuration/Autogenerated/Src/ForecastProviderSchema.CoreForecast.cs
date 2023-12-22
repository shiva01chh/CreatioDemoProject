﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastProviderSchema

	/// <exclude/>
	public class ForecastProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastProviderSchema(ForecastProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b512f4ff-912d-452a-ba48-948ea30f99de");
			Name = "ForecastProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,27,93,111,219,56,242,217,11,236,127,224,229,94,20,32,171,220,245,177,141,83,164,105,210,26,219,118,131,36,219,125,40,138,66,145,104,91,119,178,228,21,229,100,125,69,254,251,113,248,37,146,34,105,73,78,187,205,139,35,113,102,56,51,156,79,146,42,147,21,38,235,36,197,232,22,215,117,66,170,121,19,159,87,229,60,95,108,234,164,201,171,50,190,172,106,156,38,164,249,248,236,231,159,190,254,252,211,100,67,242,114,129,110,182,164,193,171,23,214,51,69,45,10,156,2,30,137,223,224,18,215,121,218,129,121,151,151,127,118,94,94,111,202,38,95,225,248,134,162,36,69,254,63,54,119,11,117,78,153,104,159,116,86,87,43,29,78,31,169,113,124,153,164,77,85,231,152,80,8,10,243,207,26,47,40,89,52,43,27,92,207,169,208,207,209,76,138,119,85,87,247,121,134,107,6,120,124,124,140,78,200,102,181,74,234,237,169,120,22,0,4,173,112,179,172,50,84,205,17,193,32,44,154,11,18,40,75,154,36,150,232,199,26,254,122,115,87,228,41,202,229,188,174,105,39,95,217,212,157,185,217,139,55,184,33,168,89,98,115,46,244,144,55,75,180,78,22,121,201,244,133,170,53,87,189,162,115,108,19,58,89,39,117,178,66,37,93,246,233,129,36,54,203,14,78,111,117,226,148,35,186,28,243,28,215,241,201,49,195,112,19,88,211,213,170,178,89,70,56,62,127,164,216,100,7,90,178,192,201,93,129,185,161,9,92,241,14,165,134,245,117,232,212,184,217,212,37,81,47,16,85,22,166,88,53,158,79,15,164,86,95,83,229,28,160,227,22,235,88,71,211,161,64,179,240,27,189,217,228,25,106,21,114,132,102,23,229,102,133,107,224,233,4,6,79,145,146,246,8,93,25,18,32,83,160,195,23,131,87,242,71,92,177,31,65,211,160,202,201,35,119,94,92,102,220,127,125,190,108,251,20,68,44,238,141,39,121,185,164,36,155,172,74,57,175,187,29,242,227,51,228,140,14,224,166,35,156,116,158,23,116,170,239,238,160,124,90,233,103,151,156,137,31,197,195,46,53,230,144,206,233,238,85,63,47,18,66,48,121,142,216,12,183,117,82,146,57,149,236,183,187,255,208,128,76,188,49,60,16,104,2,97,59,133,201,44,151,223,109,8,85,77,243,131,48,136,186,122,160,211,209,20,23,90,248,251,164,216,96,245,120,235,65,107,161,90,27,70,215,213,195,57,192,161,175,104,129,155,23,48,241,11,244,184,43,10,89,28,210,23,243,57,125,49,152,71,7,162,143,75,242,27,131,28,207,231,146,154,124,82,167,203,45,42,240,61,46,134,241,234,71,118,242,251,86,130,191,3,232,241,60,23,224,177,108,134,97,236,58,241,58,156,146,166,134,202,231,29,148,104,48,54,158,207,117,157,3,128,140,85,35,56,222,65,193,199,251,21,71,227,241,96,79,33,218,53,102,150,169,5,202,145,166,226,39,211,17,167,155,200,148,9,129,237,207,178,61,252,19,167,85,157,17,161,217,254,178,92,11,188,86,0,50,76,2,78,128,166,226,222,188,207,22,37,13,242,104,67,168,5,212,249,98,73,37,120,88,230,52,224,242,114,217,195,187,96,224,174,170,10,65,225,154,227,90,211,138,188,224,139,238,187,107,241,79,144,50,104,16,111,106,218,28,124,182,163,188,158,185,134,197,248,180,42,54,171,112,106,239,154,89,23,169,133,97,140,190,199,171,59,92,71,31,104,54,71,83,116,32,224,15,14,63,123,22,237,156,1,204,202,121,117,138,248,255,253,23,206,153,20,134,103,131,222,194,0,176,95,18,234,49,167,44,101,12,180,0,174,34,26,192,169,41,172,252,185,61,108,6,173,26,135,25,1,47,92,7,6,77,27,39,172,53,14,110,233,141,182,208,232,138,215,242,163,87,59,47,179,60,77,104,191,60,140,125,23,90,88,2,133,225,16,98,38,199,246,144,99,100,200,239,23,227,89,21,187,79,36,111,242,166,24,152,86,109,20,95,30,189,5,184,61,56,219,174,199,107,207,143,236,86,225,45,133,31,171,70,146,47,74,216,127,89,230,25,136,205,61,190,63,187,55,6,122,136,83,158,141,200,91,42,215,56,78,69,48,194,89,222,160,85,149,13,88,119,153,136,66,36,58,252,242,176,117,65,65,223,83,72,164,254,233,203,251,107,60,207,75,76,208,125,78,242,187,188,200,155,45,232,105,14,33,146,198,209,164,160,205,83,221,192,43,193,84,168,68,52,85,120,169,104,92,81,18,84,161,212,82,6,6,246,28,226,67,59,247,126,1,30,130,205,176,208,254,141,194,138,51,64,90,225,125,239,152,3,155,1,195,184,182,48,194,252,2,176,201,177,8,72,12,96,52,215,105,216,97,28,156,179,20,178,41,243,63,105,7,209,224,191,26,155,196,174,226,42,115,139,113,238,240,161,190,117,40,45,114,70,152,39,173,123,164,117,238,105,32,46,116,166,6,167,164,79,213,124,141,108,182,122,47,149,194,240,215,143,170,245,2,163,208,58,177,61,236,17,23,197,208,250,222,66,217,97,128,0,29,168,237,233,48,173,234,1,104,188,16,139,186,218,172,89,6,253,150,146,228,228,13,204,99,202,34,82,1,27,25,25,251,149,91,25,38,51,208,185,12,203,24,150,4,70,236,137,248,55,65,190,171,107,142,77,95,195,216,127,242,204,53,98,151,207,191,183,231,226,152,65,155,76,195,222,159,111,203,175,103,212,7,111,25,211,118,82,180,254,6,9,147,140,90,215,115,47,226,119,94,93,117,252,52,206,54,67,232,125,154,232,153,75,158,43,49,52,94,42,224,134,86,206,99,165,10,161,135,165,226,152,78,169,46,196,208,19,108,15,140,175,132,195,20,122,110,26,56,197,155,181,163,79,33,225,142,202,211,174,58,21,222,232,210,83,77,125,238,171,65,103,58,196,120,25,255,142,4,150,225,52,95,209,230,113,207,12,6,167,97,163,162,93,85,150,56,109,112,102,20,229,99,108,144,162,57,173,239,26,222,239,211,231,240,134,246,111,149,141,51,225,20,79,108,134,118,36,12,36,67,113,210,204,206,191,123,159,179,194,230,66,78,237,68,236,196,107,7,194,193,156,56,107,143,54,160,68,228,161,221,87,167,123,207,57,100,216,31,112,206,97,206,43,78,104,134,206,59,252,124,229,42,105,150,48,33,175,228,131,155,95,102,8,97,133,55,95,76,70,163,239,132,109,235,52,87,23,8,178,60,116,145,33,212,142,241,117,221,221,148,249,141,171,197,98,109,65,123,36,230,51,44,171,236,111,57,8,218,85,59,141,112,208,53,85,90,47,69,239,165,99,38,211,206,88,160,251,167,51,174,134,239,79,192,194,248,175,73,188,198,84,63,43,182,19,8,59,142,96,108,13,191,50,193,122,79,216,138,20,27,167,0,77,163,31,250,5,157,21,5,156,213,52,21,223,169,172,202,98,219,238,97,138,146,134,221,103,144,125,36,11,133,204,132,221,200,194,188,117,112,215,218,98,42,137,181,239,41,87,149,50,118,4,191,108,150,93,26,97,55,74,186,119,136,190,201,117,64,78,15,227,164,32,149,184,87,179,251,246,101,236,184,162,36,110,224,124,122,141,231,201,166,104,94,65,25,81,46,34,216,139,175,230,81,7,225,144,197,246,190,208,31,159,113,120,231,249,168,4,114,93,146,130,123,87,242,54,163,84,239,101,142,139,140,234,247,170,206,239,147,6,243,193,53,127,104,41,220,112,29,41,226,95,230,238,129,23,6,54,77,168,146,0,116,54,215,120,93,145,156,86,74,91,244,101,225,27,50,40,212,56,201,152,205,253,78,88,198,41,249,21,86,244,101,99,60,139,107,125,150,1,181,22,68,227,97,83,111,224,198,41,149,147,41,77,136,201,21,104,171,41,178,102,51,39,59,210,180,178,196,184,209,164,34,230,51,179,241,137,130,230,190,160,129,167,214,11,74,153,39,59,13,102,109,189,16,52,69,215,80,122,212,139,131,195,22,95,250,85,8,168,63,52,58,75,239,208,33,98,158,60,177,68,142,207,151,56,253,239,89,189,160,233,165,108,62,108,138,34,130,61,104,106,197,22,224,33,187,74,54,153,216,58,240,19,176,33,37,5,91,67,126,10,54,164,164,224,151,210,79,43,160,25,65,213,178,81,90,202,117,140,150,66,217,38,52,181,141,136,131,117,108,103,218,177,30,14,216,49,160,105,199,132,56,224,14,11,154,238,176,33,78,164,135,9,77,3,70,196,136,60,134,157,151,58,37,21,160,201,225,78,161,195,119,189,190,104,63,59,242,189,77,162,163,228,206,139,0,145,142,226,59,47,2,200,59,22,99,199,112,128,176,63,2,251,71,184,99,47,224,50,32,251,111,114,159,212,40,169,23,132,174,101,137,31,62,125,166,19,210,95,61,172,74,15,137,14,76,27,63,56,178,67,245,33,122,228,166,51,225,215,82,3,153,0,189,124,201,33,39,81,0,104,202,11,4,254,65,193,54,166,98,157,248,165,62,141,14,206,210,102,147,20,148,49,144,72,250,234,35,143,101,84,228,233,105,136,163,41,239,185,117,187,181,141,40,224,10,61,64,122,88,169,157,138,125,239,191,243,50,122,10,2,125,17,125,32,174,37,244,72,117,26,249,151,205,79,190,179,104,190,96,243,158,149,140,222,106,200,115,157,139,182,45,133,184,210,21,233,48,102,92,57,85,245,167,128,229,105,120,162,99,240,152,33,175,217,19,153,100,97,229,196,5,51,190,120,232,93,78,26,157,135,72,104,4,166,72,210,37,138,0,69,238,194,150,54,61,19,76,29,219,219,12,42,112,198,0,85,51,52,23,42,243,192,58,113,192,27,62,66,78,94,37,4,27,175,20,95,50,209,147,248,44,203,34,110,118,146,121,53,139,72,94,66,68,118,100,172,134,38,179,76,165,178,120,150,29,169,247,98,155,68,140,192,147,28,122,84,64,237,62,160,159,180,16,202,65,90,140,192,83,59,198,54,251,212,216,57,111,110,236,105,221,116,249,101,32,55,93,113,249,70,13,242,231,150,34,191,241,210,82,101,207,106,88,93,43,9,172,17,192,128,173,181,43,20,139,147,63,24,65,47,53,9,245,214,45,230,29,225,115,171,163,139,101,43,199,185,115,94,38,153,74,211,137,221,0,2,253,81,154,202,163,230,219,34,186,8,227,49,226,174,112,74,251,139,6,249,53,192,147,127,59,36,12,134,213,21,188,72,163,146,89,85,6,232,155,189,138,218,73,133,88,173,67,130,15,219,197,65,172,165,44,62,70,34,141,51,54,93,204,7,184,73,104,84,219,200,160,86,27,220,138,68,186,224,50,2,180,104,140,102,123,147,158,6,20,89,124,2,51,198,81,44,137,52,60,189,156,131,73,119,103,53,190,172,6,85,192,229,45,193,145,131,145,35,199,119,91,98,246,85,242,23,63,1,156,58,240,98,246,173,133,151,217,25,83,189,241,42,190,97,91,3,81,13,25,164,142,229,158,159,160,208,61,227,79,104,164,103,91,45,122,24,134,17,231,164,58,148,121,235,65,130,231,115,20,205,8,124,34,192,164,138,76,185,143,148,184,135,42,22,3,134,41,194,89,185,141,218,241,137,198,162,183,14,98,113,1,128,228,26,48,62,141,207,126,218,240,216,110,192,78,213,30,174,80,27,6,181,97,26,220,14,219,200,216,238,155,78,59,234,87,49,82,165,133,246,186,128,76,12,134,162,90,54,88,84,4,151,141,63,224,7,248,141,218,57,165,69,72,109,121,34,10,194,5,193,122,53,180,52,166,114,90,212,69,129,161,34,58,107,172,165,137,205,111,80,228,76,6,85,177,215,46,189,138,46,197,202,218,234,244,18,229,250,146,84,205,37,101,145,88,20,57,198,34,122,215,176,187,130,16,85,196,160,189,249,60,53,213,18,183,67,18,35,180,194,18,230,173,230,3,150,66,196,154,24,53,28,115,17,118,177,188,230,81,69,249,13,188,140,28,141,58,1,125,94,208,34,38,90,50,231,253,218,173,166,184,203,166,66,115,82,137,241,31,75,92,227,40,5,164,52,86,199,175,83,202,103,39,0,76,216,181,121,105,153,176,159,42,85,202,204,81,67,144,114,243,45,95,54,196,254,13,234,67,14,202,197,101,172,202,151,242,62,206,20,253,163,87,132,176,212,42,126,69,2,101,166,161,103,74,33,199,185,202,29,169,81,148,138,216,14,226,115,114,174,212,219,213,181,211,58,181,140,25,250,180,80,171,117,137,134,174,101,24,171,176,143,229,108,68,12,72,63,232,124,177,40,242,164,32,167,83,151,129,140,221,216,160,6,193,42,83,250,127,164,226,41,175,198,224,214,136,90,100,185,198,145,56,63,61,100,195,250,114,171,131,57,129,42,159,197,176,186,201,32,134,153,20,106,180,53,73,62,42,77,204,181,174,76,38,215,218,136,43,93,173,221,4,139,155,35,118,181,70,153,146,144,93,204,17,12,124,224,55,18,111,167,141,104,61,147,85,170,4,11,53,79,87,52,160,213,130,22,211,222,104,84,28,144,110,177,38,36,215,27,59,187,121,51,43,170,128,212,44,170,209,201,88,201,227,9,79,82,164,126,97,16,140,153,157,120,171,152,193,45,232,213,86,217,49,51,28,105,72,135,170,202,161,1,108,202,104,199,191,226,173,148,149,81,82,209,148,61,106,1,53,28,1,25,180,43,198,233,59,12,70,70,167,158,245,232,140,123,254,184,204,38,9,199,55,224,114,88,131,175,109,37,30,59,190,67,183,207,6,198,127,40,47,20,214,130,155,155,202,23,171,117,179,149,187,202,154,33,154,242,217,141,77,183,180,103,125,2,104,219,116,244,54,144,217,126,139,254,213,198,122,254,141,242,20,253,242,111,93,185,143,223,65,61,61,187,174,145,218,179,66,151,255,100,192,156,116,148,238,93,45,203,147,105,112,103,218,28,169,32,157,148,95,61,198,132,46,76,85,17,246,163,209,194,31,218,13,233,224,158,186,214,138,81,247,28,221,94,206,74,40,104,170,167,229,112,83,110,76,113,213,179,67,95,251,59,168,53,132,187,117,108,128,143,235,224,124,85,207,184,221,1,145,127,100,222,146,44,133,171,202,54,216,104,245,163,81,18,105,149,102,183,174,180,130,182,235,86,0,123,167,255,253,31,12,4,43,205,39,73,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b512f4ff-912d-452a-ba48-948ea30f99de"));
		}

		#endregion

	}

	#endregion

}


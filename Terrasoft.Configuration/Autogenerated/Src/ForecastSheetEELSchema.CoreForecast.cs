﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastSheetEELSchema

	/// <exclude/>
	public class ForecastSheetEELSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastSheetEELSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastSheetEELSchema(ForecastSheetEELSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("214cd8e1-3270-e685-76ed-f73a02c69c7f");
			Name = "ForecastSheetEEL";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,88,109,111,219,54,16,254,236,2,253,15,140,7,20,50,16,40,192,62,38,177,139,52,77,58,23,125,157,147,14,216,48,4,140,117,118,52,200,146,75,82,238,220,151,255,190,163,72,74,36,69,201,105,147,96,237,135,212,162,238,142,207,29,239,185,59,42,167,43,224,107,58,7,114,1,140,81,94,44,68,124,90,228,139,116,89,50,42,210,34,143,207,11,6,115,202,197,135,95,31,63,250,242,248,209,160,228,105,190,36,179,45,23,176,58,242,158,81,53,203,96,46,245,120,252,2,114,96,233,188,37,243,42,205,63,54,139,203,172,184,166,217,225,225,105,177,90,225,110,175,138,229,18,151,155,247,111,224,147,64,107,18,215,75,94,228,205,139,247,37,101,226,179,255,28,79,87,235,44,126,77,197,252,6,24,15,191,189,96,233,114,233,188,181,125,151,48,194,111,24,116,173,199,103,185,72,69,10,29,38,45,129,248,108,3,185,232,150,59,167,115,81,48,101,9,101,126,97,176,196,96,146,211,140,114,126,72,204,89,204,110,0,196,217,217,171,74,230,224,224,128,28,243,114,181,162,108,59,209,207,142,32,1,185,249,150,128,220,154,220,208,60,201,128,25,197,3,75,243,175,10,229,182,130,248,42,197,195,194,3,140,102,24,201,21,125,131,121,66,198,100,232,24,30,142,254,70,173,117,121,157,165,115,50,151,16,91,8,201,33,121,70,57,4,12,163,230,151,10,127,237,228,121,10,89,130,94,190,99,233,134,10,80,47,215,234,129,92,23,69,70,174,82,126,82,138,226,148,102,243,25,8,129,241,227,167,232,207,18,146,163,46,217,89,78,215,252,166,16,183,145,191,72,87,240,103,145,67,72,230,146,3,67,98,228,42,187,201,85,233,60,59,162,149,239,122,63,114,197,173,167,30,177,34,75,102,93,146,6,159,241,225,77,33,66,16,13,252,105,190,40,200,149,176,158,142,116,160,33,79,84,172,221,192,191,99,197,26,152,76,79,25,252,66,160,79,144,184,225,159,158,172,215,50,19,146,18,115,231,15,70,81,30,93,179,23,112,69,163,209,6,130,58,254,179,172,40,131,193,18,147,84,253,26,48,16,37,203,219,182,201,211,167,36,106,175,142,21,53,20,109,182,88,115,196,113,96,219,73,52,26,85,224,6,223,228,223,111,119,15,135,201,115,153,138,101,86,85,202,122,79,114,181,232,121,123,20,180,83,167,105,219,72,235,149,62,77,205,187,126,40,189,47,91,193,79,23,24,227,62,240,100,111,76,242,50,203,70,70,163,62,175,157,46,235,216,223,78,35,120,174,125,190,76,34,141,39,135,79,4,121,201,5,43,165,234,9,91,150,43,172,58,209,208,37,236,112,223,167,240,104,127,151,133,79,42,231,80,213,75,47,39,185,6,188,137,231,46,31,55,52,43,161,157,152,254,201,182,147,163,251,77,115,166,227,73,79,14,33,157,20,196,168,71,166,239,16,90,210,255,243,9,232,35,224,59,29,183,163,190,163,16,188,6,113,83,244,119,164,41,247,26,75,116,166,155,109,245,159,225,201,134,50,50,87,2,56,34,149,171,156,35,14,37,34,195,122,106,191,250,32,225,241,72,59,164,217,226,42,199,39,249,54,154,87,191,165,183,234,87,44,123,116,124,246,177,164,25,143,134,26,214,80,7,230,91,16,187,105,166,50,53,193,119,196,96,175,138,66,168,249,140,188,154,189,192,141,237,108,86,154,118,255,123,26,219,59,202,16,143,189,122,210,101,170,2,108,117,127,129,128,53,12,140,228,158,179,139,191,137,137,137,223,99,91,104,220,144,135,119,51,209,28,12,90,241,196,131,156,250,51,196,195,68,177,238,244,201,247,6,208,131,215,142,93,99,186,59,108,141,140,31,177,208,4,229,165,222,166,72,113,52,200,113,26,166,89,250,25,108,203,188,155,60,92,75,52,180,153,209,5,72,234,52,156,57,198,130,129,50,19,43,249,21,60,199,67,180,128,106,238,182,198,186,150,151,17,223,187,205,97,217,1,150,40,101,164,90,64,113,183,139,237,26,146,183,89,114,43,176,94,184,67,120,173,125,130,244,230,152,176,216,64,28,51,109,167,43,0,117,100,237,68,109,162,29,206,46,185,230,251,190,176,39,127,43,10,242,214,134,197,124,131,19,85,252,28,176,224,171,115,127,123,253,15,86,253,99,91,122,226,159,131,201,229,144,229,144,219,206,0,44,195,110,61,187,68,116,27,79,92,49,247,28,40,110,135,87,21,122,157,33,113,135,126,167,27,142,200,147,39,164,155,137,254,104,84,109,100,79,225,173,104,14,244,17,204,139,4,212,49,215,252,193,21,211,1,48,37,92,43,181,159,151,34,205,212,173,210,119,86,90,52,234,222,216,229,221,11,106,1,253,222,54,19,95,138,121,56,189,152,206,40,23,175,246,75,145,88,221,27,53,9,244,195,216,111,249,177,45,251,154,230,20,239,229,213,105,96,243,167,249,28,158,109,101,83,139,134,102,31,67,18,153,112,192,63,162,65,57,43,216,70,222,151,192,182,145,189,171,86,65,241,248,36,209,20,140,134,18,177,177,230,84,29,73,92,20,69,16,106,217,79,150,125,210,85,48,45,108,250,68,189,10,16,164,191,13,196,52,123,92,234,44,157,102,146,49,233,233,245,176,112,9,53,21,173,227,246,44,19,123,175,125,1,222,81,237,12,47,101,23,234,115,245,69,153,38,232,232,52,49,110,122,144,235,98,65,61,116,50,95,250,26,123,83,173,219,154,193,194,101,123,208,119,155,136,127,135,85,177,129,151,197,53,143,100,130,169,175,71,245,107,245,129,172,206,247,218,84,21,136,38,42,106,179,81,55,202,120,202,117,181,105,153,10,162,50,191,110,139,171,11,152,153,179,79,25,158,245,217,191,107,6,156,87,195,88,235,4,98,41,210,72,24,197,11,183,30,181,74,173,46,60,223,113,231,110,70,237,234,238,163,94,250,95,182,170,133,223,170,239,87,220,176,117,70,55,178,22,85,223,182,226,90,233,192,215,58,94,83,70,87,36,199,106,50,30,114,4,129,183,136,73,245,61,138,168,167,248,248,160,18,9,107,192,112,114,113,3,8,6,128,204,25,44,198,195,139,195,206,47,124,21,176,103,32,227,93,237,128,247,23,62,36,7,19,146,234,170,134,4,207,5,77,115,9,92,160,89,245,97,46,161,130,58,40,244,53,16,19,145,177,52,209,244,127,155,43,143,163,162,106,160,26,253,62,9,238,74,192,228,194,53,229,16,215,186,70,9,236,114,106,170,159,174,32,35,37,164,135,18,183,6,54,124,191,108,127,6,27,4,39,39,57,105,182,47,75,186,74,41,189,174,161,208,17,250,238,246,237,213,12,188,16,213,183,243,238,122,56,222,121,57,106,77,232,63,54,82,216,96,218,179,121,248,70,113,228,192,239,248,192,137,218,157,87,245,120,218,167,105,223,227,119,21,24,211,58,77,62,232,229,16,243,29,50,183,73,140,136,21,135,127,2,238,158,44,4,176,134,186,247,201,92,12,111,144,184,238,150,33,222,162,230,195,210,246,30,153,181,107,70,113,24,125,103,14,17,181,41,206,48,209,14,78,124,253,26,248,204,63,106,53,223,54,97,66,14,25,169,91,117,98,143,39,119,111,164,125,116,122,14,25,136,166,43,254,4,140,122,184,110,104,124,253,177,126,88,107,63,44,181,238,52,45,223,35,47,239,113,230,237,29,122,221,140,189,151,254,216,205,205,26,247,61,195,14,79,172,106,213,93,172,214,240,223,127,39,123,223,92,77,31,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("214cd8e1-3270-e685-76ed-f73a02c69c7f"));
		}

		#endregion

	}

	#endregion

}

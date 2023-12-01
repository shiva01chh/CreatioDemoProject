﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastAddRowColumnsQueryBuilderSchema

	/// <exclude/>
	public class ForecastAddRowColumnsQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastAddRowColumnsQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastAddRowColumnsQueryBuilderSchema(ForecastAddRowColumnsQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("393a4c7e-584f-2050-4c00-48849e3035fe");
			Name = "ForecastAddRowColumnsQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,89,91,111,219,54,20,126,86,129,253,7,214,43,80,25,241,148,237,181,137,3,52,137,51,120,203,214,172,201,246,82,20,129,34,209,49,55,89,114,73,42,169,235,250,191,239,240,38,145,20,37,187,24,86,160,105,37,158,251,249,206,133,74,153,174,48,91,167,25,70,119,152,210,148,85,11,158,92,84,229,130,60,214,52,229,164,42,191,123,177,253,238,69,84,51,82,62,162,219,13,227,120,5,231,69,129,51,113,200,146,159,113,137,41,201,78,124,154,107,82,126,106,95,218,178,87,171,170,12,159,80,220,247,62,185,60,239,61,154,149,156,112,130,89,47,193,85,154,241,138,42,10,160,249,158,226,71,48,29,205,75,142,233,2,60,127,131,230,87,64,151,165,140,191,205,243,247,213,51,248,87,175,74,246,71,141,233,230,188,38,69,142,169,228,60,62,62,70,167,172,94,173,82,186,57,211,207,55,180,122,34,57,102,104,133,249,178,202,25,90,84,20,61,8,38,97,201,39,33,2,61,108,80,154,203,231,76,73,70,188,18,116,82,37,162,213,51,98,88,4,52,49,58,142,45,37,235,250,161,32,25,34,198,218,131,140,141,68,206,58,246,202,23,151,56,171,32,179,96,177,82,170,109,124,38,124,41,172,108,76,196,159,215,20,51,38,147,220,8,59,246,165,157,174,83,154,174,80,9,40,154,142,148,192,209,217,85,192,181,211,99,73,25,102,212,58,71,103,23,109,124,192,150,97,38,249,127,12,81,97,150,70,120,145,230,41,79,81,123,234,72,121,170,72,142,32,112,90,209,93,117,43,205,139,213,63,218,216,9,154,207,202,122,133,105,250,80,224,211,95,241,230,175,180,168,241,77,74,232,41,164,97,130,24,167,144,204,179,51,19,171,137,144,28,245,166,227,70,104,103,150,69,99,1,213,157,2,35,46,115,133,199,126,132,53,124,18,91,189,106,80,181,198,170,100,135,112,148,21,41,99,253,66,148,173,131,0,106,98,141,69,225,109,16,203,150,120,149,34,168,168,231,37,201,150,45,176,9,147,133,192,123,224,163,13,146,229,187,185,85,66,140,108,253,184,69,143,152,159,64,86,224,135,138,87,216,164,183,5,73,25,170,22,173,110,109,27,23,25,132,218,177,10,172,223,18,149,86,164,160,160,204,82,130,61,51,76,234,116,31,185,16,17,125,131,14,110,33,128,161,37,180,76,158,87,25,58,6,253,40,250,112,137,23,105,93,240,115,82,138,46,17,243,205,26,87,139,120,127,161,143,199,31,253,204,238,229,65,135,181,59,1,0,17,155,198,75,232,3,60,45,57,120,122,67,201,19,52,16,117,190,86,15,80,10,112,110,66,56,215,245,245,59,0,23,77,209,104,158,143,78,122,137,175,179,47,62,253,123,209,163,114,197,37,141,112,171,164,49,234,138,224,34,239,179,72,151,244,189,74,189,163,223,198,156,210,140,238,21,98,212,83,47,49,186,55,8,179,223,14,144,67,15,125,234,37,213,1,184,207,26,231,131,199,75,2,117,77,179,229,166,13,146,196,101,144,88,244,198,139,97,121,194,38,101,205,32,201,157,168,157,126,69,20,47,148,158,121,222,43,134,15,139,144,199,144,254,126,10,55,218,134,110,8,18,18,167,180,22,19,95,0,67,150,134,198,133,42,147,189,216,143,255,100,152,130,152,82,173,56,168,118,30,199,72,118,198,200,35,154,122,100,210,155,221,176,169,176,58,64,199,22,171,139,64,112,197,129,19,231,6,195,250,17,121,122,188,199,64,131,236,211,246,155,218,79,122,138,197,157,139,48,5,120,172,114,240,225,163,153,114,55,41,95,138,3,102,6,160,62,48,239,39,98,71,129,191,57,254,108,130,244,148,82,148,19,182,46,82,141,93,136,147,83,104,201,123,188,192,20,151,25,86,128,132,117,146,131,125,162,51,95,218,124,177,28,153,81,244,80,85,5,204,149,235,42,75,11,242,69,54,247,41,90,164,5,83,248,139,200,2,197,174,194,151,83,84,214,69,97,44,138,124,102,135,58,153,219,167,74,228,78,254,244,225,14,156,174,247,232,200,233,122,138,215,42,0,96,120,53,154,109,101,120,118,179,173,87,132,187,173,175,96,55,178,69,152,34,17,205,113,212,186,234,56,211,184,216,97,177,205,56,66,163,34,251,50,178,125,19,89,130,217,193,231,194,182,198,177,54,223,176,69,215,37,143,199,232,7,244,211,73,195,1,186,129,71,186,62,85,89,71,211,105,43,199,49,82,19,54,22,2,208,204,59,157,95,215,19,219,58,33,194,197,140,72,82,245,79,189,190,131,49,233,136,148,111,91,129,90,195,4,245,10,223,13,21,65,179,27,246,46,128,58,82,54,218,253,216,65,108,110,215,5,209,110,74,49,231,27,121,18,107,102,157,102,23,15,34,105,225,222,103,104,239,108,100,133,90,122,212,153,61,93,161,214,76,82,57,213,8,248,81,189,234,0,1,122,231,44,205,150,177,7,253,233,89,3,189,190,89,37,225,239,29,110,149,152,4,226,107,208,30,57,153,54,158,217,198,138,14,97,15,110,17,77,238,91,164,131,42,125,98,141,239,67,141,199,168,111,71,113,135,163,141,108,228,77,217,14,169,211,187,100,210,5,25,232,132,183,25,142,45,45,19,168,103,219,90,128,42,78,23,141,251,115,235,49,14,38,111,98,175,15,70,146,46,187,86,210,215,175,77,28,188,126,24,242,197,219,71,224,207,45,230,251,12,49,186,119,8,67,59,110,196,187,51,165,59,74,186,51,68,204,15,163,55,0,117,111,167,8,214,142,20,146,64,1,203,58,141,93,113,94,73,48,59,255,59,29,63,193,127,116,164,59,197,248,100,160,87,120,125,172,59,160,76,164,7,250,181,190,156,104,17,0,240,139,42,45,48,203,176,92,75,174,234,82,14,251,216,237,235,19,59,20,19,127,241,27,143,181,203,201,91,22,247,86,165,233,133,78,202,60,115,6,181,28,36,125,40,122,58,28,194,191,95,42,82,234,165,3,193,136,106,19,218,236,27,182,37,45,97,11,15,59,212,47,141,27,66,44,75,102,159,9,131,158,235,200,29,119,50,32,77,16,63,196,104,73,174,241,130,191,171,225,226,61,113,237,145,94,187,138,77,176,223,149,177,109,164,189,17,140,97,110,205,62,213,105,225,178,78,252,251,79,155,184,50,247,73,71,183,27,118,1,23,197,154,98,184,28,25,202,168,145,172,219,79,243,197,192,91,101,147,139,154,66,207,227,226,109,98,139,26,31,148,42,107,186,26,152,55,35,182,31,247,58,81,36,31,232,151,223,214,40,123,150,138,33,220,146,220,3,237,171,209,182,23,183,187,173,157,143,221,168,179,142,132,177,101,41,108,145,37,122,58,117,71,77,48,2,254,30,108,53,95,33,226,111,80,4,121,204,137,190,108,236,5,108,64,167,42,86,30,4,173,215,103,39,157,235,93,139,222,251,94,128,187,195,39,208,232,162,80,197,15,199,193,38,183,59,130,109,133,41,3,183,63,142,157,150,30,66,118,176,203,162,222,246,27,234,56,67,173,201,26,203,58,0,20,67,185,149,72,72,76,140,142,184,196,207,72,42,82,17,152,53,159,93,253,226,183,228,105,151,251,89,121,152,47,56,201,100,233,58,139,134,51,33,195,75,199,62,31,67,92,73,232,102,39,145,158,72,104,153,149,184,5,83,168,21,185,171,136,99,42,182,215,17,107,22,224,189,70,204,131,120,149,23,35,235,26,21,216,200,221,251,212,193,163,188,104,135,120,64,168,187,211,29,52,100,131,165,229,248,221,91,73,65,3,10,183,138,134,55,132,189,46,28,188,38,28,38,122,254,223,187,185,135,172,230,91,71,223,101,237,208,59,160,134,191,190,217,72,150,68,202,140,95,39,175,29,213,251,191,211,88,223,174,2,159,141,155,15,90,255,227,175,52,190,229,119,26,58,0,58,129,98,177,110,191,187,70,193,27,3,208,88,191,165,113,63,253,7,217,76,33,90,92,157,143,245,206,205,53,121,71,193,214,243,205,165,168,64,245,109,61,19,183,213,76,220,57,199,222,117,214,186,198,118,191,1,56,151,245,157,185,180,107,176,66,47,225,4,42,59,30,74,112,232,247,61,242,29,252,249,23,75,37,64,49,133,29,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("393a4c7e-584f-2050-4c00-48849e3035fe"));
		}

		#endregion

	}

	#endregion

}


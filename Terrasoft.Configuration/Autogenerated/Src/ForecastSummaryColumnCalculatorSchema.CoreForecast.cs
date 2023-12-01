﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastSummaryColumnCalculatorSchema

	/// <exclude/>
	public class ForecastSummaryColumnCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastSummaryColumnCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastSummaryColumnCalculatorSchema(ForecastSummaryColumnCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4a035b29-b568-4d05-9c8e-eedb85b87ce2");
			Name = "ForecastSummaryColumnCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,89,221,111,219,182,22,127,246,128,253,15,172,239,176,201,128,161,20,247,177,73,60,120,105,210,107,160,219,138,124,116,15,69,17,168,18,29,11,87,150,124,73,42,153,151,249,127,191,231,240,75,36,69,217,94,215,174,15,69,68,242,28,158,243,59,223,116,157,173,41,223,100,57,37,183,148,177,140,55,75,145,94,52,245,178,124,104,89,38,202,166,78,175,26,70,243,140,139,247,255,254,246,155,231,111,191,25,181,188,172,31,200,205,150,11,186,62,13,190,129,180,170,104,142,116,60,125,67,107,202,202,188,119,230,109,89,255,175,91,116,175,93,175,155,58,190,195,232,208,122,122,149,229,162,97,37,229,112,2,206,252,139,209,7,184,158,44,106,65,217,18,20,123,69,22,70,133,155,118,189,206,216,22,132,108,215,245,69,86,229,109,149,1,173,164,59,57,57,33,103,92,29,152,233,111,67,71,244,58,201,37,37,39,185,165,77,13,233,137,67,187,105,63,85,101,78,74,35,194,17,18,140,16,218,158,16,114,97,94,20,188,39,129,104,200,210,72,103,165,178,224,167,150,217,73,200,237,108,147,177,108,77,106,176,251,249,184,229,148,129,181,107,69,53,158,221,193,55,176,49,11,233,217,137,60,29,39,214,215,142,103,87,129,32,125,50,70,69,203,106,222,59,73,158,74,177,10,117,3,114,115,30,25,60,54,101,65,230,155,77,181,245,192,227,201,157,39,60,241,117,153,146,69,231,139,103,183,217,167,138,42,186,153,185,102,162,252,229,24,204,105,85,113,82,100,34,67,216,233,239,37,23,232,135,160,74,195,138,31,184,102,72,30,179,170,165,252,31,129,222,152,126,81,56,232,151,5,173,69,185,44,41,219,79,172,228,6,187,73,84,180,26,190,209,122,152,191,6,229,15,1,254,166,5,162,78,50,176,192,101,221,174,41,195,91,206,110,25,165,242,62,228,180,128,52,48,51,23,163,29,70,59,21,187,180,46,84,248,122,161,124,81,101,156,191,34,255,116,20,127,120,77,151,89,91,137,159,202,186,0,123,39,98,187,161,205,50,57,20,203,147,201,199,46,5,228,40,250,33,201,201,49,41,10,19,4,154,198,130,2,41,86,100,181,0,96,222,177,242,49,19,84,237,111,212,7,186,18,170,44,152,204,188,134,107,65,201,57,25,107,37,199,167,131,4,129,56,240,185,6,65,174,104,6,113,41,89,196,15,140,117,76,5,134,180,66,95,149,180,42,134,36,14,220,235,222,247,175,3,156,223,177,102,67,153,128,50,128,220,27,1,68,180,240,249,91,140,21,184,215,116,211,240,18,176,221,146,251,60,88,209,192,104,54,123,40,123,11,231,50,126,70,61,142,228,199,31,73,210,95,61,87,206,173,106,216,22,74,166,56,27,188,108,150,72,214,163,154,62,41,235,179,22,169,230,236,1,162,172,22,73,152,82,166,33,132,147,137,201,121,46,36,104,55,227,31,157,75,222,47,7,118,34,208,196,57,12,110,24,136,134,110,80,80,13,238,14,64,22,61,252,21,32,211,87,221,137,178,42,209,221,44,82,118,37,64,168,71,208,91,8,0,233,54,92,32,156,227,125,0,66,150,179,196,202,125,84,192,200,100,165,245,84,137,203,205,221,190,67,206,136,255,205,201,51,121,160,226,148,112,252,111,183,255,214,159,169,88,53,131,25,160,104,90,172,72,104,63,197,91,27,52,241,42,137,172,229,80,146,77,37,127,47,235,238,52,16,75,111,78,77,70,91,182,181,180,40,230,192,9,145,221,214,232,49,99,170,184,223,54,120,39,32,11,96,34,107,254,147,206,192,137,127,133,250,146,21,107,52,82,77,138,146,86,209,92,233,59,18,247,178,169,123,133,34,221,249,106,203,106,139,187,218,140,190,238,3,106,29,3,137,114,254,129,147,186,8,72,209,93,64,140,236,92,193,97,82,191,89,77,60,12,176,220,103,249,138,36,102,127,81,47,27,203,66,126,148,117,199,210,220,51,10,148,194,3,250,79,101,3,249,119,4,80,228,168,175,30,73,196,12,208,160,69,96,43,87,191,169,115,195,212,19,47,53,28,52,215,93,196,62,94,44,56,180,179,40,62,81,123,185,0,67,156,96,255,136,248,170,205,212,106,124,163,183,76,64,235,111,8,231,211,206,62,106,11,168,13,163,84,187,138,212,28,147,134,221,176,43,152,0,53,79,108,190,62,188,252,120,26,53,120,152,72,80,180,78,53,125,181,239,255,150,124,191,107,187,134,58,42,156,143,112,219,233,1,103,154,186,58,91,65,141,45,44,83,151,167,242,191,155,110,33,25,242,35,141,66,36,189,0,15,243,169,44,160,79,118,140,172,215,113,185,255,115,182,65,115,238,221,215,70,124,93,202,117,56,119,166,110,158,234,172,105,125,68,39,81,57,141,96,173,232,37,83,31,230,88,96,200,28,121,132,208,31,92,130,143,112,217,163,213,118,79,8,57,198,68,225,28,172,121,210,155,33,122,115,131,30,27,188,128,114,56,128,16,239,24,133,73,134,122,124,53,81,144,180,100,254,87,78,3,89,42,40,107,54,87,149,75,146,44,184,151,155,77,18,180,103,70,131,233,219,228,107,37,65,122,49,152,163,76,90,219,17,90,113,106,25,127,150,151,122,57,218,55,226,251,65,191,136,74,104,196,183,241,107,198,14,76,58,86,228,46,117,74,180,2,36,211,121,189,13,17,236,160,115,114,26,202,244,14,135,80,52,163,147,178,180,132,122,203,32,115,101,221,4,3,174,243,25,189,125,221,60,25,54,31,62,66,143,130,127,244,189,201,48,27,73,46,26,130,142,201,232,90,174,184,155,102,197,30,113,1,243,195,152,235,35,187,157,198,233,180,243,168,160,209,196,68,11,16,169,1,235,178,70,25,11,139,99,116,10,115,156,175,7,95,170,143,94,83,222,84,143,20,155,230,68,23,5,232,54,77,125,240,234,134,111,203,209,80,71,157,58,142,110,28,167,119,189,225,21,4,102,95,76,180,81,122,85,50,46,146,137,231,120,233,109,243,182,196,85,7,177,23,95,18,50,87,180,244,183,21,101,52,201,17,154,92,139,33,243,248,139,115,242,221,248,217,44,45,138,221,61,124,188,97,77,187,193,237,221,120,98,92,0,241,190,132,148,18,225,1,69,94,90,163,91,82,189,121,24,55,186,154,186,114,197,18,41,162,226,102,208,88,178,251,140,156,137,193,17,176,54,216,135,193,108,85,213,253,218,204,96,234,65,58,47,138,68,70,156,77,95,6,121,25,75,186,241,233,162,200,67,12,241,242,31,66,16,54,157,212,124,138,56,55,107,35,216,116,222,62,108,106,24,12,106,109,23,211,12,250,157,206,33,219,116,111,39,17,233,247,182,133,250,2,116,54,165,138,244,175,251,103,71,246,221,248,47,212,213,222,24,243,249,3,212,240,172,228,18,155,16,146,181,73,141,179,35,252,112,34,33,189,17,25,19,252,183,82,24,223,1,131,65,156,223,72,212,146,201,196,7,219,185,43,166,120,32,107,108,102,136,142,36,158,58,146,226,87,24,131,179,186,112,155,54,189,100,83,147,18,76,246,38,121,231,117,232,222,184,150,120,124,82,55,155,154,246,218,206,54,189,96,194,11,126,101,250,165,209,164,15,100,127,110,175,154,64,239,167,16,21,43,214,60,201,123,205,11,198,229,239,57,221,72,109,191,27,27,125,201,179,85,228,202,107,67,119,100,149,217,215,234,76,115,32,98,149,9,232,33,161,118,213,141,80,175,219,233,184,223,226,43,137,99,166,232,66,60,232,73,134,156,78,245,40,123,189,77,135,18,15,195,232,80,114,232,187,144,182,161,246,76,18,56,37,226,220,187,36,58,164,127,106,154,138,132,109,224,94,29,252,25,238,239,140,125,242,238,220,54,108,115,35,5,176,250,251,53,145,252,249,167,206,223,102,106,188,227,116,97,186,66,31,80,37,247,237,118,67,149,139,118,250,67,87,104,187,14,37,165,62,245,253,247,49,201,93,132,143,120,43,10,222,115,205,211,218,99,201,68,155,85,222,187,81,240,18,227,140,103,234,49,102,159,83,90,239,123,42,5,206,7,134,10,178,212,221,6,194,59,233,26,8,208,154,198,155,226,87,186,200,120,78,8,235,190,11,122,61,215,0,179,249,227,67,148,217,28,58,186,236,129,238,97,88,168,124,18,80,191,236,63,113,28,198,222,121,26,148,191,144,148,53,100,250,82,20,77,78,114,70,151,231,227,67,63,93,164,145,223,238,198,39,51,231,173,241,171,253,194,167,141,21,132,200,197,138,230,255,53,9,244,151,22,18,21,254,46,214,44,147,240,233,247,212,14,52,230,151,201,5,191,92,111,196,54,193,160,177,63,87,226,116,99,251,62,149,82,156,186,221,185,140,178,130,99,3,175,17,51,21,162,107,154,212,138,38,30,108,102,46,50,153,255,97,175,159,9,222,54,16,122,229,31,200,77,87,89,251,187,205,219,252,15,28,14,90,150,83,62,158,146,177,109,244,37,183,177,233,178,46,86,101,5,14,82,247,91,68,5,117,162,90,224,221,169,163,207,39,243,46,124,110,33,186,172,40,130,61,23,201,75,232,243,53,207,96,24,119,149,238,134,242,142,157,55,143,191,48,29,4,255,79,217,189,231,118,61,168,238,162,244,77,65,55,234,1,235,34,104,154,47,181,224,12,120,170,143,239,90,51,187,229,183,159,102,220,139,245,247,214,91,64,20,79,74,175,218,124,129,16,195,166,255,64,124,125,205,95,115,191,72,204,153,223,164,7,201,204,109,78,140,26,26,27,163,123,2,47,168,154,189,224,137,78,62,248,104,18,252,36,215,149,112,249,56,170,177,10,159,153,134,230,49,244,239,0,54,213,151,106,195,210,194,140,103,189,119,50,215,48,222,219,214,40,242,138,131,62,119,157,213,88,49,124,206,145,55,239,160,32,196,126,151,151,107,240,239,255,114,135,234,12,59,36,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a035b29-b568-4d05-9c8e-eedb85b87ce2"));
		}

		#endregion

	}

	#endregion

}


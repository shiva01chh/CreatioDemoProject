﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCGroupingStrategySchema

	/// <exclude/>
	public class DCGroupingStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCGroupingStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCGroupingStrategySchema(DCGroupingStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b72b57ae-ada0-4e4e-a22f-841fbbc685d8");
			Name = "DCGroupingStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("41c9b305-ccaa-4408-abc9-8158dd3fa84a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,91,91,111,219,56,22,126,206,0,243,31,88,47,208,149,209,172,210,29,96,95,154,196,65,110,237,120,183,109,138,58,131,62,12,22,133,108,209,14,81,89,114,73,42,137,167,147,255,190,135,87,145,20,101,43,183,121,218,62,180,22,47,135,135,231,242,157,195,67,182,204,150,152,173,178,25,70,151,152,210,140,85,115,158,158,86,229,156,44,106,154,113,82,149,233,217,186,204,150,100,6,141,28,151,252,231,159,126,252,252,211,78,205,72,185,64,147,53,227,120,185,31,124,195,244,162,192,51,49,151,165,239,112,137,41,153,181,198,188,39,229,247,166,209,93,122,185,172,202,120,79,55,83,233,135,42,199,5,139,79,163,56,61,59,129,46,232,252,27,197,11,152,141,78,139,140,177,55,232,236,244,29,173,234,21,76,152,112,160,139,23,107,57,106,111,111,15,29,176,122,185,204,232,122,164,191,63,227,21,197,12,150,98,104,161,231,32,166,39,161,121,69,81,86,162,172,206,9,46,65,146,12,47,150,48,84,113,170,9,140,57,34,12,85,43,78,150,228,15,156,35,94,161,41,70,53,131,159,98,250,18,231,164,94,58,36,96,16,186,33,252,10,21,152,49,196,175,128,254,191,94,127,67,20,207,200,138,8,62,12,225,131,61,135,213,85,61,45,200,12,205,196,254,34,219,67,98,207,19,135,59,211,113,146,49,12,211,127,200,253,91,49,65,111,61,227,53,197,98,218,73,81,205,190,141,203,121,37,101,173,6,134,146,10,69,69,96,56,93,202,149,80,54,173,106,14,27,193,104,42,40,49,181,59,241,205,192,4,81,198,57,37,211,154,227,212,18,118,55,182,179,162,228,26,88,21,66,7,158,90,252,32,205,122,163,98,176,62,57,180,162,160,233,79,82,46,122,72,139,107,217,114,74,49,208,103,138,59,143,243,165,92,128,0,189,12,84,147,54,52,246,90,68,14,86,25,205,150,8,108,19,31,14,236,150,198,101,142,111,7,163,223,74,242,189,198,64,8,190,80,53,71,115,82,112,76,155,157,139,54,43,159,244,96,79,210,234,160,13,226,168,40,225,235,193,232,147,254,229,205,22,220,146,28,203,6,112,183,85,33,68,39,13,119,11,221,169,146,42,112,56,169,151,131,17,252,101,232,74,182,65,62,226,211,80,84,154,220,66,82,46,219,155,164,28,29,144,212,86,29,234,60,33,37,71,190,144,119,145,104,51,194,81,95,222,150,84,147,199,210,80,216,14,172,178,115,236,145,66,135,1,237,125,53,202,202,251,208,174,163,123,78,220,133,160,219,91,88,143,121,231,174,12,99,60,78,212,152,59,99,201,184,204,149,49,7,166,253,137,86,43,76,57,193,253,12,251,126,102,215,101,221,90,7,66,122,129,156,126,160,5,230,251,0,122,240,215,221,70,78,238,107,170,61,120,177,36,251,115,209,207,166,123,172,237,235,251,201,24,208,30,208,131,1,223,152,98,12,132,54,164,219,195,230,77,128,47,23,185,7,230,43,165,50,12,54,39,2,25,41,213,134,20,138,222,11,220,39,154,198,179,0,188,15,234,50,6,43,62,65,21,12,98,116,145,209,109,166,208,66,58,18,199,121,181,160,8,119,32,12,215,204,123,3,231,96,52,246,137,193,48,108,112,108,11,149,109,81,72,17,12,65,225,65,225,167,229,207,125,248,3,195,185,62,126,96,164,20,115,73,85,179,158,33,19,95,27,147,234,88,71,102,35,198,114,123,172,225,7,38,207,94,101,112,34,77,76,106,148,169,190,55,198,45,21,43,118,84,91,40,30,51,54,216,141,13,99,38,122,17,39,104,53,72,225,197,156,253,167,9,124,30,31,208,253,218,206,8,121,151,115,195,70,103,116,72,169,181,203,191,32,68,70,28,21,37,171,234,6,12,16,76,226,23,244,15,9,22,181,154,50,37,252,134,48,140,150,25,19,150,15,249,249,10,22,203,134,125,224,251,190,225,211,98,128,231,253,247,138,19,247,88,173,39,78,60,103,190,208,143,5,52,167,213,50,112,83,27,118,250,229,16,45,51,125,56,143,54,136,72,44,233,23,72,28,94,124,7,120,22,54,158,68,94,15,229,243,11,38,139,43,222,138,138,138,93,225,87,218,129,216,223,129,90,153,195,126,128,83,137,53,143,206,6,239,153,11,189,37,184,200,5,124,168,220,68,117,154,68,5,82,137,188,42,139,53,122,87,147,28,125,101,112,70,135,57,227,28,32,75,180,164,31,241,141,248,55,25,238,111,94,164,59,137,137,166,89,38,133,129,92,171,42,174,193,9,108,9,194,38,50,242,84,157,9,245,230,120,78,74,156,163,153,168,145,220,242,142,212,171,21,38,221,226,197,169,154,58,24,29,11,81,74,232,105,232,202,73,24,92,145,237,162,155,43,50,131,101,169,168,104,136,210,200,116,109,88,3,8,246,98,166,92,15,223,206,240,74,158,173,103,20,207,15,7,199,116,81,139,69,63,214,69,113,65,207,151,43,190,62,55,67,6,163,47,87,184,212,60,194,232,13,108,238,141,68,141,165,4,34,206,102,237,90,42,211,52,17,59,44,141,36,126,97,68,147,68,145,101,134,232,13,154,102,12,39,209,62,21,132,35,93,233,233,21,158,125,115,119,154,136,157,84,243,40,157,225,126,15,19,253,128,249,85,213,105,163,18,249,49,191,172,120,86,124,182,101,163,196,176,120,13,128,192,176,40,212,129,209,150,248,6,160,71,124,36,17,41,164,191,49,76,225,119,169,170,122,67,21,175,211,211,170,46,121,114,90,21,245,178,76,143,25,88,2,97,223,146,161,233,126,11,48,19,165,54,169,106,58,195,199,186,212,53,132,169,201,32,224,114,160,246,191,163,24,76,39,43,232,153,175,63,86,239,1,51,126,37,114,27,106,0,197,112,92,41,245,70,210,243,91,60,3,12,159,204,50,128,187,3,24,55,74,60,65,26,209,168,173,10,233,188,149,193,68,176,42,83,56,176,130,75,29,243,229,183,58,122,72,168,26,162,67,133,55,177,45,153,73,169,141,35,204,72,129,80,198,47,232,25,158,103,117,193,19,72,106,70,232,54,29,51,181,48,104,227,229,75,148,168,212,210,143,65,152,29,137,154,39,207,192,181,19,152,161,114,188,163,35,52,207,10,134,173,148,47,43,77,169,135,222,246,125,41,92,87,128,93,231,183,28,172,203,40,67,9,230,11,96,136,166,42,28,78,75,11,203,145,56,24,187,107,186,85,88,182,82,138,143,6,83,75,226,61,233,175,25,3,86,115,194,165,153,139,189,29,117,44,169,179,227,244,184,204,55,217,87,65,50,246,182,162,106,35,130,205,174,145,202,130,237,208,161,161,63,46,147,185,219,242,102,11,63,128,83,20,255,69,28,13,81,198,180,228,239,163,85,133,170,86,206,125,212,235,31,94,254,106,253,14,242,217,96,23,13,154,12,118,48,4,231,145,232,105,165,242,30,207,249,5,184,13,253,119,69,202,100,112,118,106,113,228,98,53,80,240,2,84,236,240,139,210,80,61,47,57,36,11,227,220,246,129,132,217,249,247,58,43,30,169,69,67,216,213,230,208,221,150,6,77,183,63,182,85,244,18,233,145,50,81,72,28,61,180,89,222,50,114,155,245,254,95,138,125,164,104,188,124,147,93,118,251,230,184,4,64,230,218,85,78,106,82,228,110,203,134,224,211,174,33,200,196,211,230,157,187,104,90,85,5,100,63,50,220,104,97,186,145,94,164,133,74,158,106,131,147,71,70,126,41,235,103,83,239,189,114,135,190,92,232,140,65,72,163,19,188,28,105,196,37,22,72,64,91,203,39,147,10,39,86,35,67,229,50,19,243,61,216,54,83,229,0,218,216,228,220,166,190,188,117,178,107,168,114,174,107,152,106,223,100,142,146,23,122,17,166,211,17,91,51,18,66,209,231,234,195,88,90,164,50,32,93,168,233,145,50,116,5,147,185,171,137,187,134,175,184,225,118,174,20,11,99,93,75,58,162,113,151,237,136,82,221,153,166,204,151,9,184,39,86,62,171,173,197,115,224,254,30,52,46,121,213,2,89,221,55,193,60,105,80,21,80,166,49,34,248,112,172,34,0,32,199,119,52,63,241,77,6,169,179,179,167,88,174,188,25,179,46,171,207,152,129,37,93,102,211,2,39,62,40,185,248,211,220,91,11,253,125,200,216,183,39,65,32,39,248,72,179,183,226,108,59,220,219,186,156,165,147,122,233,251,149,154,38,248,241,228,215,165,26,13,254,142,87,135,129,35,10,5,122,182,84,214,201,218,229,122,191,67,66,159,117,25,228,113,82,186,172,86,209,209,39,25,159,93,77,200,31,56,20,103,181,18,70,229,73,113,155,92,33,18,82,49,201,142,21,146,147,204,247,0,189,141,103,41,88,180,162,121,35,191,157,46,180,55,3,47,51,186,192,60,18,73,26,158,108,38,67,133,234,64,94,42,221,233,50,79,53,186,106,12,224,162,217,176,50,26,171,127,45,59,207,148,108,174,32,39,52,225,125,179,225,108,20,138,16,135,151,95,72,79,238,54,157,45,136,70,92,239,126,60,162,69,89,151,90,145,0,225,34,220,166,148,192,85,100,60,121,176,38,230,13,213,118,242,16,27,209,251,221,36,74,31,55,93,201,197,112,243,140,72,241,100,116,45,10,17,187,173,215,11,35,17,103,101,19,19,109,94,93,102,234,94,39,49,173,151,247,132,241,131,216,85,147,41,114,200,251,34,22,191,139,153,87,20,103,179,43,148,8,242,170,218,74,202,168,100,173,165,73,180,98,205,181,210,121,89,47,49,21,106,60,136,37,170,35,69,86,237,8,22,222,72,91,141,242,83,106,93,26,113,175,170,244,93,149,206,138,210,11,154,99,10,248,169,71,154,106,175,201,75,196,214,68,89,91,18,215,66,139,94,205,153,9,238,157,27,140,255,167,110,246,100,229,151,199,21,223,86,38,50,121,9,114,42,244,231,159,40,94,207,129,35,86,185,224,87,98,91,175,27,18,59,162,62,75,202,26,235,213,117,126,162,184,91,184,247,118,226,74,113,248,33,227,87,233,167,234,38,249,101,87,47,243,46,76,112,212,212,44,188,120,139,51,245,251,235,255,154,89,98,187,179,154,138,187,165,173,34,116,178,213,93,239,92,18,222,107,134,119,154,59,86,67,105,120,173,217,244,248,23,155,46,127,250,42,195,240,231,59,74,71,177,45,188,130,12,239,55,13,103,47,95,58,70,37,134,89,219,208,61,237,219,204,67,212,181,157,128,104,235,106,243,112,235,118,93,85,164,225,197,168,43,135,84,198,17,150,228,122,219,49,133,53,39,221,35,31,34,76,243,27,159,100,228,210,117,103,39,144,246,113,158,39,46,147,150,115,35,183,87,175,154,150,198,45,221,41,186,95,155,188,199,152,153,124,231,130,110,192,129,73,168,164,162,133,173,254,0,97,123,172,239,182,245,127,167,69,129,16,130,4,169,129,105,99,46,31,32,31,152,138,159,83,141,59,214,116,237,50,173,151,104,183,233,127,240,186,101,208,30,45,139,86,150,220,206,173,204,71,253,181,144,215,232,248,246,48,90,201,214,247,113,43,90,205,68,186,89,46,84,170,207,176,134,95,150,132,133,2,49,131,251,213,118,55,244,200,174,227,249,28,162,26,206,85,208,100,77,24,145,41,131,119,86,131,62,78,13,120,89,192,148,33,77,136,86,29,39,221,48,247,84,241,72,76,204,186,248,236,192,240,30,49,169,51,200,248,160,31,174,60,58,236,18,170,240,27,224,229,91,11,222,109,232,112,34,222,11,47,226,89,67,129,144,210,58,187,11,80,122,225,11,219,222,23,128,49,250,245,132,103,14,55,155,74,11,142,85,8,62,13,104,91,166,127,119,24,181,161,104,199,105,108,94,82,206,171,212,123,115,103,71,123,124,55,131,189,247,113,225,126,35,217,111,187,34,167,139,111,110,128,115,93,201,175,90,152,21,66,219,120,117,232,45,100,110,169,146,70,126,161,71,201,43,30,31,27,163,126,9,148,131,197,34,152,25,155,217,13,37,18,71,154,122,65,227,47,79,4,36,155,193,202,33,31,146,110,16,102,89,93,227,241,22,205,249,117,137,230,40,238,165,240,33,161,64,51,119,157,23,43,170,210,245,197,86,8,199,121,251,186,108,174,75,159,82,108,88,15,51,2,178,181,54,125,159,19,189,29,209,93,162,210,173,127,170,99,139,206,115,146,225,134,51,164,93,208,86,255,53,9,149,107,63,130,94,235,244,169,105,117,158,51,3,49,74,121,64,76,152,128,254,11,108,207,113,222,249,199,190,187,218,124,140,112,139,39,146,140,56,124,111,59,243,240,142,120,18,143,24,252,65,209,97,11,174,247,65,227,246,193,194,153,229,110,247,149,201,236,189,84,45,30,115,188,50,47,239,186,179,126,254,91,107,176,238,251,94,92,203,89,61,188,111,190,245,114,213,76,242,206,21,198,190,69,41,224,108,42,32,88,89,181,255,162,64,216,238,40,241,226,158,63,81,220,1,85,92,62,96,73,134,143,87,216,157,131,230,142,153,187,202,51,37,138,14,149,41,143,56,116,29,196,199,64,221,113,148,142,115,161,38,249,122,73,242,127,191,7,40,219,94,46,157,201,71,67,76,63,20,50,251,96,87,85,93,228,226,63,66,137,183,227,226,255,68,217,250,75,215,75,113,245,126,7,128,155,82,241,202,88,189,153,147,170,54,65,43,137,215,157,229,107,21,149,142,182,158,196,52,55,36,173,241,238,89,93,139,236,117,36,200,110,10,156,95,157,168,22,208,247,16,242,89,5,39,91,20,179,204,190,123,206,133,245,206,137,122,217,122,192,48,214,239,177,154,114,233,222,72,187,6,170,168,59,162,177,19,24,146,30,236,25,202,49,29,73,196,215,18,81,168,175,92,208,42,74,8,126,187,191,138,224,20,56,150,22,126,96,180,190,102,98,161,102,171,212,39,74,190,20,139,20,1,101,69,129,196,123,98,201,92,86,160,60,227,89,79,251,148,73,195,105,129,51,122,177,58,131,105,137,125,64,33,207,145,16,70,121,252,201,72,188,200,250,84,119,19,95,219,151,19,110,238,19,241,121,37,45,191,81,182,193,159,255,1,73,238,232,202,68,58,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b72b57ae-ada0-4e4e-a22f-841fbbc685d8"));
		}

		#endregion

	}

	#endregion

}

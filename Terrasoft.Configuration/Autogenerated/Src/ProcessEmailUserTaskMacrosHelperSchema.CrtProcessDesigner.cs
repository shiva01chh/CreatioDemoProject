﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProcessEmailUserTaskMacrosHelperSchema

	/// <exclude/>
	public class ProcessEmailUserTaskMacrosHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProcessEmailUserTaskMacrosHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProcessEmailUserTaskMacrosHelperSchema(ProcessEmailUserTaskMacrosHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0fcd8e80-952c-4520-b7ac-1cc2e95ab1c8");
			Name = "ProcessEmailUserTaskMacrosHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,26,89,115,219,54,250,89,157,233,127,64,184,59,29,42,149,233,99,156,140,99,91,114,125,200,174,166,113,147,177,149,238,131,237,238,64,36,36,115,195,67,5,65,219,170,170,255,190,31,46,2,60,116,36,157,236,122,198,54,5,124,247,13,80,9,142,73,54,197,62,65,67,66,41,206,210,49,243,206,83,74,188,143,52,245,73,150,193,135,100,28,78,114,138,89,152,38,223,127,55,255,254,187,86,158,133,201,4,221,206,50,70,226,163,202,103,128,143,34,226,115,224,204,187,34,9,161,161,223,0,19,79,211,132,36,236,58,13,72,84,219,126,31,38,127,212,22,135,228,133,121,55,100,146,71,152,246,95,166,20,100,227,60,12,156,45,127,28,167,73,243,142,165,140,86,241,130,100,225,4,4,93,143,240,137,133,209,18,142,96,177,126,194,66,22,18,14,0,32,255,160,100,2,56,232,60,194,89,118,136,20,175,126,140,195,232,83,70,232,16,103,159,175,177,79,211,236,103,18,77,9,21,56,211,124,20,133,62,242,57,202,90,12,116,136,206,112,70,86,80,108,205,5,85,35,10,216,139,209,220,103,41,229,18,9,102,18,66,49,94,199,210,21,59,67,18,79,35,204,136,134,64,185,122,104,115,82,173,67,52,2,177,220,98,17,241,144,105,45,148,40,36,9,164,52,101,209,174,9,123,76,3,97,167,240,9,104,43,177,228,7,148,49,176,191,143,222,135,25,59,6,13,192,246,61,116,69,152,20,141,100,151,52,141,207,210,96,230,202,61,52,130,103,197,182,229,115,157,145,218,152,98,198,8,77,80,23,57,174,123,114,120,28,198,19,248,119,247,123,239,225,199,147,118,128,25,222,122,194,81,78,186,247,78,187,205,1,188,215,39,242,225,222,129,199,251,251,237,215,189,118,219,57,18,132,41,97,57,144,114,199,192,28,93,99,230,63,162,88,252,13,19,4,97,74,94,60,177,72,50,151,139,211,209,188,165,141,90,173,140,240,44,145,40,222,111,156,107,219,27,166,92,67,183,125,244,101,6,75,25,80,34,129,54,153,250,136,210,39,8,207,48,32,232,42,15,3,99,174,127,165,244,51,161,131,192,213,22,82,138,36,228,89,64,186,206,217,197,206,110,255,226,224,205,214,219,119,251,111,183,246,251,123,59,91,7,239,78,247,183,250,187,7,103,187,151,251,187,111,206,78,223,58,37,33,27,152,74,102,131,100,156,162,115,74,192,137,102,65,187,41,22,43,90,12,11,33,54,143,93,17,76,94,141,132,194,149,174,48,240,222,32,0,148,6,93,75,62,51,240,107,148,80,130,222,16,136,119,95,177,215,210,51,149,5,29,116,17,138,114,135,233,76,5,103,7,233,32,149,156,132,123,11,69,21,62,20,176,60,98,32,173,38,36,69,28,67,37,193,16,69,238,47,100,38,240,62,226,144,214,232,134,128,196,3,173,137,126,171,160,44,31,60,37,190,203,145,60,32,219,17,232,42,232,36,215,133,109,30,137,182,198,52,205,185,104,138,63,207,201,219,52,167,62,225,133,91,27,45,43,86,42,209,215,152,205,6,248,203,50,194,42,108,219,219,219,232,56,203,227,24,188,211,211,11,55,130,103,134,48,157,228,49,116,161,12,129,213,149,45,145,168,0,89,129,187,93,69,62,158,98,138,99,148,64,223,236,58,132,151,252,217,175,240,236,244,68,249,159,137,13,244,252,24,130,15,161,4,6,136,165,104,66,152,225,229,29,111,11,10,205,4,41,241,83,26,12,2,167,119,35,158,190,158,146,9,242,204,233,73,219,66,248,164,20,79,72,29,81,122,33,235,157,90,180,245,154,213,31,10,239,91,33,207,107,70,7,165,163,255,128,223,173,72,40,40,105,215,27,83,117,100,69,210,170,118,100,212,138,128,50,25,222,179,178,84,134,182,0,3,97,135,31,46,62,28,162,243,155,235,173,189,189,131,131,55,98,121,169,60,198,197,170,146,52,8,104,75,86,8,85,98,47,147,196,24,254,52,8,220,134,34,211,65,186,37,150,235,77,129,184,34,140,229,106,101,113,227,25,66,202,32,112,238,236,21,215,153,111,82,205,23,78,251,97,243,241,67,146,134,241,99,80,102,222,154,215,134,13,12,74,47,233,233,165,198,204,157,246,209,52,231,59,188,245,231,206,214,187,135,249,193,98,171,120,222,223,224,121,119,111,225,28,173,46,19,151,33,137,150,14,26,80,123,131,52,137,102,90,174,127,139,60,33,32,151,145,238,159,124,118,56,238,126,212,59,135,243,121,123,110,41,176,80,19,194,82,154,208,249,121,52,212,40,246,229,250,151,211,19,241,11,165,55,143,147,58,81,107,179,153,242,42,99,65,16,192,216,199,135,218,198,121,145,199,5,248,57,145,37,191,250,81,22,120,40,89,50,25,50,194,190,112,176,89,62,9,234,176,209,57,40,122,217,217,76,233,229,150,199,61,221,54,85,74,219,221,167,218,139,147,60,138,164,180,98,132,131,13,254,183,43,134,35,177,226,234,49,78,66,133,99,228,10,24,111,144,137,113,207,181,120,20,13,249,9,83,53,27,118,37,69,175,6,123,84,105,221,214,92,184,97,135,94,98,159,11,50,198,0,107,153,201,189,5,203,203,65,126,54,5,12,251,83,197,84,149,38,93,2,69,221,46,42,81,242,78,115,150,74,53,78,20,25,175,31,79,217,76,174,29,114,105,126,14,39,143,17,252,194,40,161,166,41,123,144,91,169,75,255,133,81,236,179,65,60,57,141,138,121,226,145,197,81,131,63,205,156,255,147,115,207,167,124,239,71,28,49,24,235,29,247,238,119,248,251,240,90,79,241,133,107,8,239,16,229,185,93,19,55,179,123,101,138,20,96,112,246,203,19,134,122,104,7,253,240,131,94,188,219,121,240,174,104,154,79,205,246,46,58,169,239,222,237,62,72,39,67,53,117,156,141,28,90,55,225,42,151,221,74,63,92,166,20,120,187,206,113,16,62,1,173,89,196,207,56,243,157,5,154,239,46,238,157,222,124,111,113,188,13,91,61,167,131,156,17,246,63,79,64,186,36,216,242,211,40,165,135,104,70,162,40,125,62,114,84,167,110,57,65,152,193,72,57,59,132,17,52,10,19,2,59,173,178,123,148,44,27,184,213,132,168,42,127,208,72,85,235,185,4,166,106,17,77,229,82,69,59,87,45,163,87,50,117,185,7,212,146,247,225,25,142,244,60,72,171,27,183,224,130,24,43,194,159,224,192,160,144,219,58,118,151,1,194,249,76,154,211,109,23,33,13,197,84,6,185,181,217,172,180,214,86,22,228,162,123,92,72,83,202,204,84,138,75,198,5,8,42,154,144,158,107,204,138,192,235,232,102,93,160,92,227,169,56,62,77,43,11,218,126,82,8,201,71,246,6,100,119,17,72,133,2,19,142,15,99,66,73,226,19,9,206,39,40,27,241,108,6,21,27,132,101,143,110,149,155,119,155,143,140,72,10,170,156,68,54,87,239,2,78,224,66,33,81,78,120,100,216,198,41,235,188,198,202,118,189,91,125,105,177,212,166,141,105,165,22,125,33,240,167,242,105,179,210,132,154,250,178,30,43,219,166,250,84,141,38,41,46,113,104,113,171,34,195,123,21,57,160,83,6,246,46,195,36,40,8,214,156,165,104,40,5,197,41,8,72,168,58,62,200,126,133,12,249,64,69,168,187,133,246,109,244,215,95,232,149,33,85,246,32,10,51,36,3,173,180,108,242,172,25,109,157,227,173,118,178,42,151,172,164,169,122,118,137,234,42,36,159,138,166,251,247,175,96,100,100,113,127,150,68,88,27,146,141,177,167,206,62,226,232,179,191,3,103,31,152,3,158,41,156,229,145,188,142,172,184,187,198,213,202,84,77,152,159,123,71,41,123,68,62,156,141,50,19,68,170,172,86,67,72,218,169,49,95,204,60,84,160,156,227,4,84,19,85,60,153,64,155,40,205,67,194,202,96,184,39,56,78,242,88,213,69,183,44,178,6,56,50,136,95,150,47,138,108,37,81,90,101,217,129,68,73,156,186,233,150,101,203,2,145,40,35,90,175,26,85,173,212,6,174,104,152,242,26,12,92,187,143,89,86,248,87,152,68,173,163,194,52,171,10,29,209,77,121,101,161,43,29,104,10,91,163,147,147,198,246,174,123,249,145,186,247,227,131,177,101,95,57,39,223,212,230,228,78,253,52,86,174,89,223,182,40,243,35,192,50,147,22,86,234,84,20,41,93,178,241,228,120,181,166,160,182,107,177,180,170,151,130,88,5,234,170,0,82,52,154,67,168,185,105,254,255,154,226,223,234,64,50,243,138,198,83,239,53,2,160,105,146,179,174,48,129,116,83,231,233,24,13,215,116,140,229,198,181,169,43,19,91,119,184,133,125,45,253,230,69,80,86,44,34,44,97,66,86,26,22,182,93,165,186,69,215,64,249,122,190,147,224,222,218,153,174,170,178,33,194,47,204,138,0,244,44,197,248,134,137,120,197,8,56,12,108,237,223,167,56,32,129,107,72,217,199,101,169,167,193,180,173,102,97,84,103,238,114,244,127,69,31,175,223,112,172,184,219,23,197,0,84,24,244,147,60,38,20,143,34,178,228,254,210,220,138,87,223,185,232,235,134,197,183,100,90,76,184,197,61,164,22,67,84,36,215,220,145,242,188,89,253,134,207,122,201,80,214,160,108,251,38,49,36,158,60,248,158,205,84,81,71,93,45,179,119,26,133,56,83,249,232,221,138,215,99,110,144,79,193,32,32,137,192,226,192,229,21,152,105,41,127,99,86,65,179,95,32,245,180,196,234,172,47,238,126,57,43,113,203,82,188,56,18,75,71,22,100,173,153,215,135,2,51,175,89,100,245,136,81,190,91,178,138,161,36,213,112,47,83,190,152,105,23,115,212,109,249,134,166,137,23,119,100,69,96,125,170,45,212,215,2,61,226,36,136,244,229,193,111,75,107,138,162,122,21,165,35,28,157,78,167,183,132,49,0,201,188,75,130,193,199,242,189,179,36,82,152,37,235,243,164,195,118,164,243,159,70,142,149,126,99,108,89,45,186,77,250,86,6,175,13,121,108,70,217,214,254,85,157,172,215,255,35,199,81,166,252,39,150,142,225,252,66,134,97,76,122,110,219,214,187,201,245,117,130,53,206,250,191,190,228,176,196,236,212,195,73,75,190,208,57,48,76,77,253,112,25,164,11,225,73,32,30,188,1,35,241,110,7,53,172,238,181,87,23,34,89,66,86,189,236,148,197,137,87,39,147,243,174,148,233,155,150,200,255,153,100,203,235,232,18,89,191,226,21,143,29,86,252,91,50,152,18,254,165,147,144,223,162,2,116,152,240,129,9,71,250,18,77,190,170,89,133,36,95,202,40,171,41,172,81,154,70,168,33,140,135,61,151,61,134,153,30,66,194,100,154,179,54,122,126,36,148,160,33,58,68,242,203,35,74,103,70,103,246,121,206,79,147,39,66,229,189,3,175,83,23,36,243,105,56,101,41,149,13,92,237,186,12,246,210,177,59,108,235,184,85,54,85,248,226,181,177,100,223,53,52,189,243,234,174,43,133,83,52,120,170,54,16,168,86,64,229,166,49,232,173,179,110,81,234,102,194,38,98,60,21,70,164,96,17,79,89,72,165,189,11,146,215,56,117,80,32,129,140,90,11,56,81,243,131,140,219,127,241,201,180,84,16,235,82,44,84,204,52,70,8,172,193,207,127,1,134,57,253,107,167,37,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0fcd8e80-952c-4520-b7ac-1cc2e95ab1c8"));
		}

		#endregion

	}

	#endregion

}

﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PreparingTemplateStateSchema

	/// <exclude/>
	public class PreparingTemplateStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PreparingTemplateStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PreparingTemplateStateSchema(PreparingTemplateStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aa19d90e-ae83-428e-1eba-43a914a5db80");
			Name = "PreparingTemplateState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,26,105,111,27,185,245,179,22,216,255,192,168,197,98,132,170,131,221,244,192,34,142,29,248,74,34,212,222,184,150,157,0,13,130,128,158,97,36,54,115,104,73,142,98,173,161,255,222,199,115,56,28,142,164,162,88,160,249,16,140,200,247,30,223,125,144,174,112,73,248,10,103,4,221,17,198,48,175,191,136,244,188,174,190,208,69,195,176,160,117,245,253,119,79,223,127,55,106,56,173,22,104,190,225,130,148,71,193,111,128,47,10,146,73,96,158,190,33,21,97,52,235,193,92,209,234,215,118,241,6,48,54,237,79,255,232,178,172,171,248,142,199,84,122,126,57,63,8,232,186,206,73,193,247,131,94,108,42,92,210,12,22,5,169,196,127,11,159,30,122,204,53,166,5,236,239,7,188,23,116,136,30,35,233,107,156,137,154,81,114,208,137,236,43,17,0,161,72,82,209,65,146,196,192,62,115,34,36,4,71,199,225,65,93,90,30,40,208,0,42,127,96,100,1,27,232,188,192,156,191,64,55,140,172,48,131,237,59,82,174,10,44,200,92,192,127,10,114,213,60,20,52,67,153,4,28,128,67,47,144,81,143,65,27,61,41,212,246,20,240,47,129,43,161,78,162,107,75,122,180,210,63,80,38,247,17,173,132,165,115,141,31,221,9,244,55,2,226,253,237,249,95,159,255,252,243,143,71,125,52,46,36,67,232,172,41,190,94,150,128,62,203,111,88,189,34,76,108,126,129,8,1,212,241,67,187,53,62,50,156,145,42,215,204,117,57,125,77,73,145,15,177,233,142,184,198,25,171,111,48,227,132,161,207,15,145,213,14,155,134,193,207,32,216,87,146,95,86,130,138,205,60,91,146,18,75,6,59,160,210,239,181,6,172,248,218,97,54,232,179,232,46,116,208,124,93,189,199,5,205,49,128,160,207,107,251,25,176,3,62,145,33,70,112,94,87,197,70,169,253,51,35,130,109,206,235,6,190,143,209,95,14,132,191,32,5,222,32,64,248,123,215,46,14,84,5,217,163,5,119,92,130,238,205,206,65,104,75,86,11,161,188,11,148,150,55,197,126,2,144,164,104,182,49,248,250,199,30,187,43,15,101,141,84,173,180,190,242,121,99,124,237,255,113,207,79,38,72,230,216,209,200,63,10,20,162,63,210,183,184,202,11,242,242,242,49,35,43,25,135,39,201,36,253,128,169,56,173,242,91,9,159,120,122,159,42,58,35,181,112,42,164,181,193,20,39,232,142,150,100,190,194,85,250,154,213,229,156,128,203,231,60,241,212,63,49,120,9,177,135,76,145,48,56,83,164,224,102,130,232,52,48,149,17,35,181,54,145,148,223,85,154,7,179,214,7,118,20,39,147,35,79,200,136,25,65,226,138,124,179,118,75,198,183,3,112,227,46,161,93,134,141,147,220,133,97,136,111,119,27,218,228,6,72,166,50,200,107,1,213,143,228,54,204,205,79,84,175,33,153,210,220,133,238,37,99,53,187,38,156,227,5,216,93,46,157,67,217,144,74,28,67,196,182,161,10,153,255,154,47,108,142,217,65,111,13,165,231,42,251,45,160,117,134,69,182,148,18,169,253,125,169,170,35,73,223,97,163,201,42,186,168,61,120,65,148,191,69,211,25,122,245,10,37,241,157,99,244,134,8,111,33,177,206,194,119,209,59,70,144,155,26,226,27,204,176,61,156,1,195,223,93,182,131,244,168,57,14,23,141,79,13,29,209,227,189,143,63,196,118,60,3,183,95,93,102,93,98,214,108,182,63,53,131,81,98,61,230,124,172,33,182,156,227,189,105,104,254,241,19,58,93,131,224,248,161,32,175,107,118,249,72,178,70,134,183,204,100,13,39,92,82,133,227,1,236,201,214,97,149,22,121,234,220,70,131,194,255,76,240,89,142,182,123,92,244,154,136,101,61,88,78,77,97,89,215,52,119,201,200,70,191,75,74,178,218,132,137,201,229,83,47,69,25,13,27,190,93,199,148,94,213,11,72,185,172,2,129,75,44,18,157,44,255,56,254,248,100,78,72,157,26,254,65,54,219,79,47,116,172,163,111,75,90,16,180,178,73,31,89,79,72,145,210,195,11,100,241,63,14,244,29,159,182,104,140,254,100,143,131,58,128,168,21,0,61,117,5,66,127,70,63,109,83,52,246,51,110,199,150,70,95,179,203,170,41,1,7,204,247,114,22,120,240,9,58,135,234,39,136,253,205,19,199,23,114,17,56,141,199,127,217,126,235,98,226,31,4,250,63,1,3,172,192,155,240,53,230,95,249,93,13,98,102,144,11,165,179,54,69,97,53,191,198,204,105,233,150,172,106,78,189,144,187,56,191,235,109,189,108,23,85,19,126,98,141,159,222,3,39,240,93,233,201,196,184,125,151,62,206,223,41,69,113,119,64,75,216,219,13,207,152,106,64,37,140,58,211,48,63,186,139,82,246,217,182,235,233,47,117,69,20,210,86,51,22,28,225,152,4,252,190,62,82,73,232,12,88,204,106,150,207,242,196,217,38,157,229,211,152,124,70,122,223,36,161,8,198,58,214,32,26,129,126,65,137,227,228,89,215,84,35,15,3,178,183,161,198,207,54,202,192,14,109,26,183,187,225,104,171,254,7,79,110,88,213,115,62,207,229,124,239,114,172,254,255,248,247,144,50,91,113,141,210,164,66,123,155,232,56,208,172,239,165,237,112,109,156,244,138,114,209,151,44,49,10,29,133,59,168,12,126,31,107,184,81,80,182,82,173,154,153,154,177,50,50,16,70,83,20,55,138,61,61,56,44,157,85,84,56,214,250,34,165,167,121,158,4,56,22,218,56,69,31,41,226,57,187,101,225,135,8,211,179,74,68,190,237,174,73,238,188,46,33,62,193,83,108,43,99,23,98,78,230,231,187,135,56,153,99,61,86,91,145,128,234,203,248,129,39,166,30,153,78,215,78,32,167,108,1,254,89,65,215,219,116,164,134,10,49,144,34,167,123,232,56,70,199,158,230,246,98,197,7,86,32,49,48,202,218,14,37,174,150,84,253,226,111,73,1,69,50,16,64,170,44,42,217,145,239,43,113,186,251,237,107,242,64,216,168,122,134,44,61,214,98,230,243,89,127,255,220,133,108,249,191,74,180,199,79,52,167,39,201,160,133,124,6,198,211,142,24,191,151,117,119,36,237,48,151,70,106,203,80,177,60,160,241,136,244,27,94,29,115,13,154,61,241,40,204,218,154,136,41,133,232,135,31,58,196,211,211,74,182,255,145,2,105,63,211,15,75,194,72,242,40,187,228,14,166,52,51,166,21,79,30,83,185,48,137,213,71,230,51,21,104,176,63,212,222,146,95,27,194,133,212,223,224,230,190,212,36,122,136,118,184,232,111,24,161,213,125,194,13,97,154,234,113,75,55,85,59,103,68,124,35,164,210,73,87,99,168,111,14,40,23,120,211,69,128,255,54,87,180,164,194,239,148,140,50,226,92,88,161,159,60,210,48,98,248,84,161,69,210,155,48,55,131,230,22,155,96,191,37,42,157,43,149,115,181,69,232,232,64,77,56,17,5,109,61,102,3,35,169,33,69,150,196,171,104,108,36,114,190,66,184,201,41,129,170,165,215,103,185,111,143,238,158,177,133,179,225,105,103,119,119,35,220,165,148,190,38,34,91,202,203,161,139,179,100,60,203,33,126,67,54,166,78,230,177,230,251,221,195,191,129,226,24,109,237,117,76,60,224,7,83,88,234,67,94,227,10,47,8,211,122,150,57,204,214,238,179,205,61,52,184,1,183,62,3,160,160,212,221,128,142,236,81,113,5,3,47,187,238,79,99,214,210,55,118,224,87,25,93,1,11,130,235,36,30,111,28,119,247,158,94,31,175,219,87,175,39,124,22,92,197,75,21,188,151,227,248,96,235,50,158,227,53,81,231,58,222,52,107,96,59,200,210,196,79,67,50,96,252,124,50,208,184,148,65,255,209,107,100,218,28,161,169,125,1,166,113,182,68,73,175,233,52,169,10,6,239,158,216,126,10,124,52,229,220,239,8,85,10,117,204,119,120,74,239,24,206,192,122,167,5,197,234,170,193,165,101,4,89,182,127,35,51,121,21,96,152,214,82,197,153,193,84,209,239,147,9,101,49,124,79,108,77,152,229,71,49,214,140,163,24,247,112,196,93,99,217,147,20,218,48,92,233,187,93,63,217,199,156,80,154,218,178,211,215,117,59,105,237,200,230,202,201,220,53,80,106,190,28,85,121,73,228,141,108,117,163,31,82,132,183,221,218,68,38,189,111,42,245,184,59,148,68,223,73,166,230,130,100,236,152,123,250,113,139,150,192,62,226,242,5,230,233,167,45,42,193,105,32,111,226,10,61,61,223,166,227,118,94,85,97,108,82,173,189,130,9,158,112,186,101,49,184,44,80,6,108,107,120,204,150,31,168,88,190,133,177,152,48,227,10,48,127,180,118,214,165,3,247,151,84,40,244,65,253,1,53,224,99,223,93,247,224,133,79,80,170,124,50,230,57,64,95,53,145,36,81,247,239,54,61,204,9,91,211,140,156,174,104,234,49,154,244,133,153,76,135,31,82,162,189,153,246,192,88,19,177,171,123,144,254,54,84,83,33,228,160,129,234,94,14,66,1,104,112,161,138,125,23,120,71,26,27,46,255,253,178,220,49,229,112,63,20,102,184,3,222,24,126,79,83,198,213,62,40,157,237,214,15,224,58,106,234,72,52,196,29,63,86,253,116,239,61,28,112,189,16,241,251,154,88,204,201,4,19,225,200,184,131,169,231,1,81,63,135,200,118,198,118,161,33,152,212,132,233,81,61,232,1,154,26,216,163,60,111,84,235,17,1,117,65,165,33,12,188,126,155,233,1,155,191,30,152,218,203,67,245,94,101,18,233,101,185,18,27,191,65,30,234,98,103,37,52,78,60,66,125,86,129,33,136,222,78,239,106,168,142,234,59,177,78,98,224,206,151,36,251,202,155,50,198,159,217,234,34,40,70,66,80,183,7,39,233,247,40,119,206,229,227,138,234,43,234,11,125,159,217,10,209,221,2,212,251,138,174,193,85,112,33,31,44,29,5,24,28,228,242,198,186,49,204,9,60,156,44,122,0,6,247,76,254,165,3,225,92,189,128,202,23,135,14,98,111,55,149,95,239,190,0,1,248,2,225,35,84,46,171,124,144,6,236,13,80,184,195,108,1,193,12,123,255,170,43,162,116,56,208,22,159,55,140,129,87,220,171,126,199,192,183,230,134,12,179,166,198,27,59,108,248,27,254,184,212,77,196,55,140,214,12,58,95,157,130,101,31,164,61,205,101,217,126,36,58,156,224,56,189,232,62,252,196,188,63,249,183,39,203,25,58,6,251,207,134,52,61,224,93,108,202,40,85,127,60,114,232,84,119,52,76,42,131,52,222,211,112,192,155,71,35,42,117,107,234,131,69,136,56,73,159,96,239,92,51,16,247,233,29,242,146,237,61,174,237,123,198,246,255,58,199,189,119,221,18,222,20,2,233,62,118,46,200,106,6,78,205,42,92,36,209,43,78,217,107,187,226,49,177,17,224,86,244,88,214,58,238,179,86,252,211,96,30,77,103,92,233,211,187,111,217,49,89,15,211,217,215,81,202,76,179,227,97,34,118,213,182,119,58,114,45,106,100,60,114,210,116,154,254,182,53,15,59,20,205,120,188,81,8,97,135,134,217,225,62,214,190,211,88,75,5,146,68,234,14,239,221,210,236,240,27,104,101,168,154,117,239,54,43,226,89,114,222,100,230,113,80,142,178,238,190,70,62,27,163,227,56,65,189,155,94,116,223,213,226,222,175,87,187,139,176,6,255,254,3,207,89,249,207,15,41,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aa19d90e-ae83-428e-1eba-43a914a5db80"));
		}

		#endregion

	}

	#endregion

}

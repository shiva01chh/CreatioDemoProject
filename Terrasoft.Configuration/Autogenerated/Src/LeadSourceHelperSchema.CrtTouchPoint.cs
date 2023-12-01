﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadSourceHelperSchema

	/// <exclude/>
	public class LeadSourceHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadSourceHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadSourceHelperSchema(LeadSourceHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2a833b27-9f15-41d1-bff5-e2a709739e54");
			Name = "LeadSourceHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("202cd6f4-4bd7-46f3-ba65-b53cf8adb6f1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,91,233,111,219,70,22,255,236,2,253,31,38,90,160,144,0,83,22,173,147,113,236,128,135,152,24,77,155,108,108,111,176,40,138,128,22,71,22,17,138,84,120,56,85,83,255,239,125,115,144,28,82,67,82,178,179,221,43,31,98,115,248,230,29,191,121,215,204,208,129,179,198,241,198,89,96,116,141,163,200,137,195,101,210,55,195,96,233,221,165,145,147,120,97,240,253,119,95,191,255,238,40,141,189,224,14,93,109,227,4,175,207,42,207,64,239,251,120,65,136,227,254,43,28,224,200,91,52,210,92,109,240,194,115,124,239,119,236,238,208,189,241,130,207,197,160,168,211,122,29,6,242,55,130,182,76,190,147,96,247,3,190,181,195,104,125,133,163,123,111,129,229,19,163,218,241,254,60,72,188,196,195,113,45,129,237,44,146,48,42,81,188,78,146,205,77,226,249,94,178,69,231,153,65,160,71,95,120,1,212,64,255,183,8,223,129,182,232,50,72,112,180,4,244,159,163,203,235,48,93,172,174,194,52,90,96,74,115,114,114,130,94,196,233,122,237,68,219,11,254,108,225,120,17,121,183,56,70,94,16,39,78,0,203,150,172,156,4,45,156,0,185,120,233,5,24,197,148,3,114,2,23,45,86,78,16,96,31,221,110,81,132,151,116,40,77,214,104,227,68,206,58,238,103,34,78,4,25,155,244,214,247,22,192,156,171,85,209,234,232,43,213,44,87,255,93,20,110,112,68,96,122,142,222,209,169,236,125,85,117,58,80,120,0,10,151,104,69,52,162,154,96,144,21,163,36,4,253,28,127,251,59,238,231,28,68,205,142,126,6,202,127,56,126,138,5,62,198,102,253,26,248,188,43,216,124,69,119,56,57,67,15,92,79,28,184,76,213,178,222,63,225,100,21,186,251,40,109,81,80,227,28,74,130,33,71,24,80,21,244,143,137,79,47,61,236,214,168,79,71,40,61,10,96,206,121,167,152,219,185,120,17,99,140,22,96,201,121,199,242,168,105,48,237,107,156,68,224,85,199,136,253,124,232,156,92,16,224,4,153,206,189,227,249,206,173,143,251,47,78,232,112,33,41,194,73,26,5,241,197,117,186,241,49,153,22,225,56,245,19,153,29,247,4,212,24,88,100,115,8,147,238,171,212,115,1,39,215,75,215,199,136,62,48,39,232,193,58,174,55,105,130,217,59,61,112,217,120,183,80,252,69,89,241,11,65,229,222,217,163,177,94,66,48,35,215,73,156,195,161,38,83,45,152,217,185,176,115,38,89,252,252,39,64,103,115,253,80,166,104,6,83,197,127,153,87,87,6,51,159,54,125,39,6,143,126,131,29,206,246,53,246,33,56,107,83,9,121,77,195,174,54,111,72,51,196,47,176,74,14,192,97,120,129,11,139,219,77,182,27,28,46,187,98,158,232,245,126,45,82,201,130,168,181,163,21,170,230,59,150,89,16,255,151,219,4,213,34,137,82,146,104,75,193,154,209,85,236,18,135,47,3,72,223,180,198,64,156,160,0,127,41,50,38,44,105,178,194,72,8,186,170,122,36,212,168,226,253,138,172,19,185,176,146,183,165,49,142,64,241,128,229,168,206,197,53,200,34,99,104,145,15,10,78,87,203,102,227,220,225,155,200,103,243,141,119,63,209,140,185,207,68,32,131,74,133,163,210,100,58,136,203,254,158,113,224,43,85,5,161,123,83,50,4,149,237,202,162,27,113,61,243,103,65,124,15,145,214,225,232,168,194,232,188,194,234,140,18,125,228,140,224,53,255,141,143,11,12,225,157,240,196,222,147,133,222,169,3,221,30,125,249,240,63,234,44,143,90,177,131,86,163,21,213,250,226,90,106,10,34,239,30,154,49,70,176,97,15,153,163,124,20,151,185,250,174,188,204,34,5,109,204,182,66,19,240,209,7,24,88,74,5,99,130,212,111,157,241,166,152,192,32,129,158,129,255,118,228,45,81,87,228,248,140,177,204,192,59,58,98,169,94,148,202,16,35,176,144,31,101,117,94,225,164,42,190,219,41,228,119,122,124,114,29,215,7,1,240,125,16,48,67,23,31,140,2,157,212,134,4,37,218,3,13,66,87,139,8,87,175,5,21,66,213,128,76,33,97,127,116,88,152,28,128,12,159,80,143,10,39,104,68,132,209,72,208,200,213,169,69,130,81,72,81,16,185,30,138,192,129,254,33,76,106,67,162,221,63,10,186,90,68,218,252,163,160,106,64,230,241,254,193,74,204,97,224,144,57,109,216,16,154,61,160,201,107,154,4,25,166,90,11,48,164,228,215,227,146,179,151,193,34,219,94,221,238,108,175,74,224,236,87,0,194,4,184,97,55,147,198,31,81,165,10,85,30,247,219,198,29,180,253,124,207,43,10,74,1,201,98,71,82,179,135,224,21,118,207,77,103,190,252,231,23,187,160,49,204,243,2,87,67,5,208,210,221,132,88,97,229,219,104,190,13,73,3,239,115,138,145,231,98,112,8,216,13,69,205,150,208,125,200,123,186,147,41,18,237,165,155,33,45,168,151,195,46,21,207,51,215,211,164,51,38,205,210,219,247,238,178,222,226,62,4,65,53,205,11,95,39,222,98,128,250,17,57,166,185,137,188,254,117,180,53,35,12,243,187,31,243,118,22,198,127,132,61,78,95,191,141,67,31,54,109,199,40,76,19,50,10,14,228,245,16,11,178,151,228,161,255,119,202,138,141,60,231,45,76,127,190,222,208,211,30,24,147,45,182,112,36,212,135,23,49,166,76,174,232,220,46,213,173,212,108,213,38,34,89,70,224,22,98,58,78,250,204,204,244,123,39,66,56,254,76,194,24,122,92,54,239,106,177,194,107,135,74,175,244,143,125,145,224,39,39,0,100,162,99,145,43,179,14,24,246,117,215,213,125,159,81,130,34,233,58,200,154,197,44,15,17,42,153,174,101,145,82,155,233,154,194,92,230,179,204,119,140,237,77,178,174,46,105,154,172,25,13,13,89,176,114,7,248,95,58,64,243,113,205,122,175,95,207,42,147,25,235,150,201,108,159,188,59,217,116,214,27,199,187,11,90,166,47,56,89,198,64,106,87,217,144,227,138,110,199,59,226,14,132,173,10,87,190,119,203,229,136,35,153,164,12,108,26,203,190,152,67,206,105,124,139,30,159,211,228,145,190,75,67,106,228,51,30,44,151,241,207,80,87,222,70,31,86,94,130,175,200,113,116,129,65,47,47,153,196,125,11,193,204,149,128,113,185,113,236,219,16,181,221,14,237,17,142,11,27,179,178,72,164,238,240,216,169,205,21,243,170,19,136,39,95,111,55,216,101,190,78,215,224,5,177,239,66,108,99,47,221,188,24,63,20,117,119,15,187,179,227,162,63,254,64,205,132,249,210,148,32,138,177,19,45,86,153,31,238,39,234,101,177,246,232,185,184,234,103,5,223,114,3,86,130,191,24,46,195,47,168,34,46,128,148,147,116,17,4,255,145,77,106,91,136,108,122,190,16,149,245,39,140,69,207,44,132,231,206,198,88,72,172,229,150,2,243,227,146,171,231,162,114,89,37,22,59,102,74,189,77,156,114,176,183,229,253,99,246,83,116,63,73,15,112,94,10,231,179,10,153,176,4,162,153,251,167,156,43,234,4,186,91,77,215,119,11,223,115,229,153,146,190,202,82,164,44,96,232,106,117,41,89,225,252,82,211,196,236,16,196,73,220,47,6,50,197,50,155,229,70,139,126,151,51,96,3,175,194,240,206,199,186,251,33,140,220,56,227,242,32,218,184,173,183,113,187,159,141,219,127,179,141,159,254,233,4,46,254,205,242,34,40,209,37,27,247,90,124,104,187,187,245,39,131,196,236,250,252,36,78,200,1,96,253,132,8,53,15,172,210,70,39,143,87,190,95,41,200,226,244,214,10,215,142,23,188,105,161,47,55,134,130,46,117,189,33,201,24,164,55,44,86,20,158,118,226,189,124,156,73,218,199,215,97,156,136,246,44,67,16,185,88,161,46,87,10,240,88,35,175,178,231,204,249,101,133,58,242,223,132,225,167,116,147,229,125,50,75,154,57,248,173,76,183,115,243,254,77,158,50,56,23,55,76,110,170,140,248,250,144,75,10,39,233,118,250,95,7,15,164,176,150,200,196,228,46,24,216,159,127,78,29,63,238,150,137,143,17,107,115,201,109,136,19,121,49,116,154,111,35,215,11,28,255,242,46,0,219,77,39,198,61,89,25,16,215,201,227,23,209,69,146,219,145,29,184,241,7,47,89,117,119,140,58,80,129,22,143,217,209,132,253,47,87,91,54,250,242,101,163,83,22,238,36,101,89,113,47,66,39,203,17,242,42,119,104,54,201,54,209,215,145,179,92,122,139,60,169,60,60,46,183,188,77,86,56,202,153,236,70,118,75,17,202,81,56,180,13,120,100,109,127,132,188,158,108,245,106,58,129,22,107,219,69,11,45,192,55,112,131,39,183,33,66,52,236,93,42,242,77,134,236,165,120,43,176,215,85,132,112,86,80,58,134,170,57,32,162,119,184,104,81,250,78,65,184,110,255,86,151,208,228,142,39,103,84,127,255,252,184,143,2,42,151,209,197,129,219,189,23,37,144,140,81,195,61,61,128,78,27,148,216,216,102,87,210,146,187,105,190,66,217,115,223,92,225,197,39,61,186,75,215,56,72,72,13,239,22,182,10,241,198,59,32,112,172,124,38,249,197,246,176,239,198,228,241,101,255,10,180,240,241,219,136,95,49,119,127,35,39,101,191,245,9,126,196,115,59,252,76,167,211,123,217,167,103,101,36,115,118,58,37,17,239,159,44,225,125,141,0,126,142,65,14,78,26,32,228,17,245,21,117,152,50,144,63,184,86,15,199,226,43,106,199,113,14,10,15,149,214,195,63,8,84,156,196,104,197,46,209,217,238,10,100,147,152,162,23,247,16,179,224,168,252,131,5,246,117,2,185,226,199,36,220,235,78,232,10,15,33,81,105,18,22,44,31,20,71,102,210,252,80,221,207,75,211,87,133,232,47,248,46,167,249,32,146,217,40,255,12,35,179,182,12,65,145,192,165,237,121,118,96,216,67,63,252,128,228,20,123,182,177,242,19,174,66,188,100,17,158,137,0,19,5,36,107,240,76,154,242,247,16,95,108,219,254,50,29,158,32,66,94,217,190,117,67,178,79,89,221,71,193,3,157,229,208,54,141,109,214,170,77,218,30,107,78,75,112,107,22,250,127,253,40,46,203,33,188,146,254,171,190,145,43,159,146,228,69,109,247,94,161,160,32,69,228,172,49,121,9,29,2,184,75,2,91,141,248,71,188,237,102,101,170,240,181,92,222,70,56,171,224,84,252,176,226,40,89,121,113,191,242,97,14,35,169,6,75,131,88,86,202,69,185,188,63,168,8,166,116,101,201,197,167,66,37,219,27,191,90,1,104,106,210,126,249,194,84,18,223,199,146,120,238,137,150,210,157,127,118,210,92,178,160,108,181,112,249,64,142,92,55,53,247,18,72,118,137,196,101,228,95,14,52,201,224,119,20,50,25,217,245,69,147,140,236,236,183,69,74,126,149,33,147,83,220,115,72,37,53,95,123,28,139,55,17,226,57,119,83,37,34,153,52,76,88,26,237,201,147,112,137,164,82,135,30,181,240,210,4,202,34,161,124,253,117,16,243,199,231,222,255,154,143,100,159,156,74,107,247,37,196,135,55,226,77,171,108,87,35,126,104,91,44,82,141,168,242,231,203,210,38,118,239,79,115,197,130,93,251,105,110,22,105,200,167,103,86,228,91,64,178,14,89,71,223,244,229,62,217,11,148,190,186,45,11,204,62,224,175,185,218,39,127,149,1,59,156,228,75,24,125,106,249,50,130,11,138,64,68,24,248,91,182,102,194,177,51,229,245,51,99,69,219,21,178,113,34,68,221,142,173,15,237,177,110,205,148,241,196,210,149,145,109,218,138,174,79,53,101,58,24,14,13,203,158,156,170,211,89,167,241,75,241,249,26,106,252,83,212,163,12,42,106,205,181,177,57,176,198,19,101,62,157,14,149,145,62,53,149,153,10,90,170,163,217,68,213,140,249,220,48,6,205,106,177,142,25,57,238,19,177,203,143,236,75,250,13,135,250,208,24,218,115,197,214,13,77,25,157,130,166,154,106,24,138,49,158,142,230,131,83,213,156,14,244,102,253,104,119,139,64,36,249,222,251,169,90,82,102,111,41,175,29,85,167,115,205,30,15,199,51,101,62,178,109,101,164,14,53,69,63,29,234,202,192,176,205,145,174,218,160,246,184,89,85,34,195,121,178,142,148,75,21,70,205,24,141,180,153,166,76,166,218,0,96,28,170,138,54,0,85,13,211,80,71,218,124,110,219,179,150,101,102,48,242,76,247,13,64,148,105,121,122,106,152,150,58,182,20,77,211,77,101,52,183,84,197,176,116,77,57,53,45,123,106,234,227,201,100,110,55,107,105,71,24,243,19,130,39,169,72,248,48,143,172,168,168,207,103,170,106,78,52,197,26,104,176,200,134,13,174,8,129,162,76,85,123,100,27,170,102,91,234,168,37,94,190,120,201,98,69,90,216,101,20,174,161,102,132,20,217,216,75,90,118,241,45,42,239,156,82,151,244,54,173,201,200,154,153,67,101,58,154,64,250,49,33,216,181,161,110,41,3,77,159,142,245,249,84,29,15,212,102,189,217,246,10,37,140,253,147,84,173,236,212,202,9,105,166,77,244,41,44,191,62,129,168,31,13,117,29,162,200,180,20,117,162,26,3,91,183,39,99,195,104,241,212,229,242,219,196,58,227,179,19,231,218,112,164,158,90,22,120,233,204,84,33,147,79,230,202,204,210,102,202,68,155,204,166,99,107,48,158,218,185,134,135,253,241,202,190,21,178,152,241,45,138,101,89,118,99,177,100,87,191,136,223,253,62,18,93,233,45,114,9,225,137,58,157,154,234,216,80,198,35,72,162,35,115,50,80,12,125,52,81,70,214,233,220,56,29,168,167,211,193,188,217,7,216,245,45,247,217,39,233,89,185,9,174,20,39,205,54,44,168,150,167,166,14,89,85,31,13,192,39,244,177,162,26,35,3,188,120,160,78,38,45,65,245,246,169,177,95,58,193,41,55,28,227,249,116,104,156,142,32,133,78,102,202,104,108,232,138,54,55,39,138,53,159,143,6,250,112,108,78,212,113,201,77,233,223,32,149,60,21,134,225,223,159,23,82,18,84,45,59,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a833b27-9f15-41d1-bff5-e2a709739e54"));
		}

		#endregion

	}

	#endregion

}


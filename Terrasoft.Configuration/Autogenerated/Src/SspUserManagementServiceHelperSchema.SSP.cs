﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspUserManagementServiceHelperSchema

	/// <exclude/>
	public class SspUserManagementServiceHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspUserManagementServiceHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspUserManagementServiceHelperSchema(SspUserManagementServiceHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6b839ffb-24e7-4bd4-8864-98ed5f5bd62f");
			Name = "SspUserManagementServiceHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,91,235,111,27,55,18,255,236,2,253,31,24,29,208,174,0,223,186,253,114,31,234,88,133,227,71,171,187,52,246,89,73,239,67,81,28,104,137,146,246,42,237,42,228,174,29,181,200,255,126,51,28,114,249,216,135,100,57,13,238,130,192,210,114,201,121,241,199,153,225,144,202,249,90,168,13,159,10,246,86,72,201,85,49,47,211,139,34,159,103,139,74,242,50,43,242,116,50,185,253,242,139,63,190,252,226,168,82,89,190,96,147,173,42,197,250,52,122,134,49,171,149,152,226,0,149,254,32,114,33,179,105,163,207,37,47,121,163,241,117,150,191,111,52,78,196,180,146,89,185,117,47,124,233,214,235,34,111,127,35,69,87,123,122,249,170,243,213,213,135,82,200,156,175,222,41,33,85,103,175,107,62,45,11,153,9,236,1,125,254,34,197,2,180,101,23,43,174,212,119,108,162,54,56,252,39,158,243,133,88,139,188,156,8,249,144,77,197,143,98,181,17,18,250,159,156,156,176,151,170,90,175,185,220,142,204,51,142,96,235,122,8,91,234,206,108,94,72,246,88,200,223,80,136,199,172,92,178,10,251,201,98,37,20,227,249,140,101,249,67,86,10,149,90,170,39,30,217,77,117,191,202,166,108,138,82,237,22,234,15,173,138,211,5,102,175,148,21,234,9,42,221,106,82,212,35,150,94,55,140,243,172,204,248,42,251,29,229,98,185,120,4,201,84,201,115,0,83,49,103,229,82,192,16,33,216,84,138,249,217,160,95,150,193,201,136,100,78,107,110,27,46,249,154,229,128,207,179,1,26,0,132,203,9,97,131,209,184,155,207,187,176,235,201,40,125,121,162,73,213,98,7,246,178,6,235,23,47,9,169,178,80,158,33,195,229,113,116,20,117,58,139,186,33,178,142,62,26,139,139,124,70,70,15,103,224,58,19,171,25,218,94,102,15,188,20,244,114,67,15,76,10,62,43,242,213,150,189,230,191,111,95,142,125,216,94,173,121,182,186,44,224,111,254,51,204,200,140,195,20,142,216,191,197,142,46,236,76,11,142,83,183,39,205,36,25,178,179,17,161,158,86,196,22,214,123,185,207,200,225,240,116,111,125,192,106,37,80,39,235,71,138,4,239,122,53,8,169,236,37,122,52,164,150,185,107,194,110,101,1,29,75,112,11,56,105,69,9,83,45,102,61,107,102,247,10,185,0,179,128,108,45,43,34,196,173,101,198,194,113,241,227,31,108,33,202,83,166,240,207,199,103,9,54,214,110,231,233,130,153,113,241,227,190,130,105,39,57,173,87,209,78,174,209,42,140,30,13,215,29,203,240,39,81,46,139,206,117,248,67,149,205,24,32,71,199,11,208,234,124,58,45,170,188,76,116,59,174,249,241,204,186,4,41,202,74,230,45,157,85,162,33,155,169,242,37,14,3,164,153,17,71,68,64,127,255,56,76,175,51,169,202,100,232,251,14,43,198,248,42,175,214,66,242,251,149,32,26,173,108,28,11,35,154,178,156,38,2,35,54,76,128,254,56,211,14,156,218,34,119,55,76,47,129,72,150,195,139,33,6,250,106,157,39,131,219,66,150,124,101,216,140,103,3,16,85,22,235,100,0,17,252,124,182,206,242,119,16,28,6,67,82,41,253,215,82,72,145,12,116,183,113,158,16,141,244,22,221,178,0,44,168,196,138,54,100,92,25,33,180,202,38,20,39,151,175,174,62,64,78,128,128,22,246,203,89,52,183,233,85,174,42,41,46,95,185,38,88,191,206,172,154,208,24,147,144,59,112,60,0,170,153,251,122,102,204,144,18,27,65,205,137,229,229,200,28,61,46,179,149,96,137,27,155,226,135,199,232,232,104,139,78,156,153,169,247,58,194,244,144,230,224,20,43,51,103,45,134,60,53,116,62,210,39,125,124,108,1,128,153,64,32,11,19,254,58,155,222,242,233,111,16,189,168,249,159,149,144,219,36,194,97,247,20,27,158,245,244,174,106,114,131,99,166,39,174,191,199,27,152,201,102,31,16,234,237,118,227,189,168,49,2,111,0,11,231,74,211,113,239,199,32,144,252,123,145,229,182,147,101,81,247,173,27,236,144,27,146,5,133,8,134,248,50,143,213,213,251,138,175,250,212,34,136,198,200,76,0,46,226,109,182,22,233,155,226,17,19,88,49,4,4,171,87,162,124,20,2,133,44,185,44,177,25,5,204,103,201,224,178,18,244,104,233,234,214,136,45,46,80,92,9,70,170,6,83,200,193,68,99,41,244,172,126,72,218,0,220,35,6,20,148,184,94,241,178,132,12,124,166,163,176,74,232,37,155,135,205,17,48,162,183,233,100,179,202,202,228,107,246,245,49,252,199,63,167,95,219,181,108,240,243,1,99,233,135,244,173,204,214,0,126,99,62,221,248,130,56,130,122,111,170,213,234,6,178,129,77,185,77,62,12,119,58,49,171,6,196,99,9,49,88,167,14,70,137,182,110,34,80,228,129,67,138,44,84,181,178,174,76,59,62,211,215,56,208,35,200,172,5,159,46,89,130,189,245,120,136,123,17,161,163,108,206,146,157,153,83,170,215,48,232,232,164,164,30,215,133,244,243,137,68,19,247,188,3,201,152,158,207,102,230,213,105,99,153,219,73,161,174,251,90,77,123,23,157,188,24,155,161,127,249,229,87,12,157,216,232,57,254,90,121,101,76,245,35,87,203,137,232,182,150,14,108,53,29,52,89,147,232,17,81,68,197,238,120,190,16,73,119,206,102,108,23,11,252,106,123,97,169,38,53,253,99,70,139,225,180,105,30,98,216,102,158,135,2,228,53,83,37,234,25,84,137,206,137,116,131,99,166,76,162,127,39,222,87,66,149,96,116,253,105,213,66,48,188,216,23,13,147,101,81,173,102,150,113,15,40,28,30,72,23,95,187,110,168,195,108,53,38,217,136,155,94,184,9,57,173,5,255,196,40,86,125,98,35,168,214,66,41,240,113,118,1,22,83,220,28,162,34,19,173,71,50,8,183,212,232,11,175,62,76,197,134,162,183,227,62,86,119,2,85,199,124,238,38,127,93,44,178,220,134,197,114,41,139,71,138,99,147,91,215,203,27,92,83,76,140,56,129,223,217,35,227,11,146,120,151,87,62,100,178,4,111,237,69,221,243,13,120,73,144,80,115,227,171,235,42,159,222,225,38,29,140,167,141,214,157,122,161,177,246,201,187,108,28,197,118,27,176,116,32,212,137,52,62,216,30,200,56,232,129,13,46,190,181,38,103,53,37,157,149,249,129,55,238,20,228,40,154,149,165,123,227,73,215,76,9,235,184,219,36,208,214,223,208,12,101,161,61,3,49,173,37,214,118,134,231,155,216,56,53,71,215,139,18,3,107,177,86,30,177,190,134,219,77,108,216,78,234,145,181,61,234,62,58,32,236,123,122,216,55,190,46,97,27,208,182,160,242,137,91,33,194,57,199,60,163,49,252,70,46,236,232,93,147,193,165,160,39,143,149,201,219,91,7,56,156,82,138,23,167,51,186,152,148,124,59,180,180,180,128,173,148,252,9,64,90,218,41,117,17,252,38,36,120,16,141,191,13,135,225,232,88,151,200,210,177,70,52,56,196,221,147,118,53,38,130,169,150,236,174,219,221,184,93,221,56,159,23,198,99,180,236,57,15,113,46,110,1,244,172,75,59,192,9,18,12,171,93,79,203,251,93,27,68,187,174,253,133,248,90,204,203,27,216,139,117,47,211,54,65,98,199,212,175,153,91,20,29,74,117,217,66,35,160,99,204,65,43,163,131,214,129,107,195,44,220,134,1,2,157,27,251,14,131,163,79,13,215,70,128,244,177,171,28,170,15,70,240,205,245,228,46,118,150,65,16,116,208,61,127,119,125,23,239,87,235,174,212,216,29,43,97,116,24,42,123,156,59,138,228,99,17,199,54,220,172,131,159,85,33,112,216,189,49,138,84,137,88,144,114,237,164,3,235,24,128,24,169,14,67,44,141,125,42,66,131,193,157,41,64,23,68,3,184,124,26,160,106,72,158,63,64,2,137,169,234,185,114,83,100,96,119,40,44,141,142,189,104,124,30,22,195,213,254,191,59,153,88,8,72,158,51,91,122,71,119,177,20,211,223,244,78,37,43,183,218,181,17,43,44,233,197,201,182,178,5,80,127,35,23,213,130,51,133,155,136,104,246,252,42,64,64,8,148,134,15,246,226,140,125,235,118,243,222,118,196,28,89,186,237,71,184,179,63,162,77,116,37,17,92,200,211,249,71,218,215,197,213,228,168,184,121,225,70,166,0,253,83,39,229,139,80,76,83,49,78,245,132,169,164,149,227,240,16,13,62,246,206,208,101,166,229,228,114,171,103,225,152,121,117,9,196,179,123,143,144,166,234,164,89,131,210,197,4,43,87,39,53,221,23,231,218,44,193,174,142,86,246,207,86,63,246,148,248,36,69,228,90,209,95,118,86,144,173,95,249,213,28,134,225,191,238,65,214,64,158,151,233,174,56,215,165,40,43,205,211,246,210,187,78,144,113,7,189,53,39,219,120,234,173,145,220,113,194,211,122,40,172,104,103,168,6,35,141,137,98,174,231,244,175,216,198,54,28,86,2,29,160,35,7,198,113,187,62,213,151,26,176,222,185,8,14,134,205,49,176,246,51,90,170,174,93,189,57,81,113,187,210,91,96,99,124,142,17,166,253,60,56,189,124,85,175,176,124,145,229,34,213,254,236,130,231,116,232,108,142,199,148,69,110,151,67,107,245,22,180,215,176,2,216,26,109,149,73,44,200,194,71,74,219,223,97,250,182,64,186,88,177,181,223,136,91,175,111,13,29,234,105,29,12,11,127,187,105,22,37,200,214,48,157,102,212,234,165,188,98,85,160,192,121,190,181,210,191,104,112,161,98,87,150,171,127,8,221,43,165,5,48,116,203,103,15,167,70,240,54,70,215,49,15,40,75,125,100,138,57,70,208,96,162,125,75,223,56,246,91,167,227,169,130,165,52,62,93,90,117,252,240,2,162,143,117,233,192,84,146,220,242,143,69,72,169,116,25,148,67,18,55,175,199,204,51,131,117,218,76,172,148,232,166,120,9,24,121,34,69,50,92,80,79,107,93,214,26,76,138,101,116,146,76,203,219,59,79,214,13,120,140,188,230,229,116,169,251,112,155,126,49,110,98,162,238,180,175,43,32,138,35,109,112,86,22,108,138,2,52,47,126,248,67,252,68,114,48,26,207,32,70,102,243,12,92,57,248,144,141,78,100,106,81,128,224,66,148,218,221,163,151,106,210,21,22,92,246,192,60,6,221,96,244,22,17,9,222,104,41,242,110,131,88,130,179,130,229,69,105,204,227,76,227,252,164,54,153,145,206,163,19,232,116,50,122,121,82,11,214,240,113,214,247,96,185,30,201,218,211,2,205,227,152,117,110,205,16,183,36,199,25,172,10,72,235,122,74,194,134,100,173,0,77,79,143,139,8,24,166,176,186,21,120,169,115,41,249,54,241,188,78,125,202,67,16,25,231,88,107,65,119,23,50,242,92,139,57,115,209,9,28,164,161,47,236,208,215,34,95,148,203,39,123,141,157,208,143,1,180,144,69,181,129,196,3,116,20,249,84,236,139,106,238,240,105,51,69,72,28,0,18,235,10,92,237,189,32,152,139,89,91,32,187,47,138,21,9,51,158,155,193,63,160,20,87,40,4,237,188,121,235,182,219,187,164,193,205,53,166,232,70,201,247,223,251,238,208,180,70,142,240,216,163,30,38,251,49,253,212,151,110,60,195,201,65,233,82,125,106,184,211,211,0,148,152,200,113,206,103,108,14,88,34,84,217,149,2,137,102,29,163,76,219,10,163,212,156,156,188,142,171,79,201,54,198,51,133,174,66,61,209,71,152,41,105,205,27,64,129,43,146,255,9,199,7,159,61,177,64,222,207,77,24,58,83,250,162,205,23,28,154,73,104,7,225,82,113,34,179,235,160,198,170,216,145,217,248,7,202,180,116,108,140,212,15,38,72,254,255,111,57,2,165,245,9,117,66,138,126,183,251,22,139,61,94,57,174,119,32,100,150,61,134,218,237,203,176,111,31,210,186,120,154,231,253,81,143,214,115,127,154,109,60,197,142,150,85,116,224,61,55,48,193,158,173,24,213,17,170,245,100,31,229,9,69,73,60,59,147,173,204,253,80,128,145,109,39,67,64,187,229,92,191,9,178,68,232,16,205,20,36,203,58,183,180,9,27,198,230,90,250,175,190,98,54,169,195,118,83,227,181,150,126,210,245,131,78,23,92,59,217,166,15,54,174,214,248,201,125,189,109,156,157,29,230,113,251,106,18,237,174,165,183,36,221,240,43,187,75,220,1,169,32,16,246,148,69,252,122,200,94,230,55,87,195,93,14,173,96,243,139,85,31,218,248,234,164,243,70,46,120,158,253,206,109,154,10,95,242,69,215,101,202,221,230,235,46,154,38,189,38,219,93,108,253,211,172,148,229,0,147,53,25,128,223,23,85,25,33,234,105,153,192,96,164,47,166,62,23,151,100,210,99,86,220,255,7,20,25,53,207,249,186,78,248,178,250,12,48,198,162,119,58,104,134,53,2,112,204,85,5,131,155,165,181,168,255,103,143,116,78,217,221,129,14,19,254,190,40,23,234,250,75,163,106,253,43,240,59,252,210,102,131,124,251,97,232,126,165,58,195,172,227,60,117,119,213,46,148,101,247,182,93,215,24,148,5,180,78,179,216,253,214,220,62,218,123,47,78,55,146,6,35,115,177,202,222,168,106,110,155,73,74,53,26,55,22,38,177,214,94,10,226,157,21,1,40,216,33,113,90,61,158,196,251,138,17,11,110,123,153,235,82,93,63,243,232,184,253,229,237,136,236,238,231,192,237,144,53,66,28,13,130,187,120,173,247,55,237,72,115,111,211,13,123,112,247,35,97,108,203,165,73,225,143,104,191,250,232,209,168,151,72,168,48,230,51,116,101,63,241,212,164,150,122,81,105,10,32,132,166,107,179,150,250,142,12,166,170,70,137,186,205,96,182,237,94,95,196,191,109,26,247,40,65,233,81,62,148,17,70,238,150,220,231,68,179,197,49,85,183,159,1,98,39,254,33,87,25,255,124,48,183,92,185,180,50,180,128,48,184,80,218,114,143,241,25,120,172,169,128,134,238,42,233,159,136,75,59,3,123,32,211,136,26,33,211,63,120,125,247,153,241,137,213,196,204,21,124,32,165,57,4,169,164,23,85,26,232,123,63,28,159,88,134,176,122,249,134,250,20,101,137,184,232,37,188,85,97,27,194,85,97,90,219,75,255,1,194,85,32,107,8,244,88,143,8,237,134,201,94,104,15,73,225,111,89,34,190,187,65,109,217,249,147,184,79,157,31,111,122,43,2,49,192,31,111,95,35,130,20,96,162,122,210,57,94,157,79,103,117,33,190,191,124,159,193,60,2,63,49,24,189,1,187,116,8,208,117,192,71,114,19,58,236,152,137,30,226,103,219,199,84,68,181,156,236,12,237,123,20,148,246,112,177,12,106,218,251,108,96,148,86,93,23,31,113,71,13,218,136,92,245,159,145,216,245,107,15,71,253,113,68,173,103,145,123,187,61,250,125,17,30,22,171,122,123,23,255,124,172,247,103,72,45,23,62,108,38,239,174,187,39,210,228,251,35,38,251,143,174,233,216,58,90,251,125,230,187,35,29,181,206,104,136,153,152,115,44,29,121,6,217,199,142,151,102,152,25,162,201,181,91,208,252,234,6,20,48,99,156,9,227,31,101,69,27,165,243,205,198,123,50,72,187,19,11,194,25,180,57,19,239,84,251,86,72,116,246,248,243,108,125,86,160,203,49,27,89,44,179,251,12,51,18,202,3,249,108,38,133,218,1,165,231,5,29,215,81,109,10,52,118,171,209,130,95,78,224,111,0,116,223,168,57,137,123,117,38,59,150,153,217,207,182,83,79,62,119,34,94,155,224,231,96,152,71,36,10,105,245,0,112,206,193,16,179,47,163,67,170,196,79,229,27,20,108,65,79,19,234,185,195,65,173,97,163,110,251,242,11,255,223,127,1,98,225,15,172,54,66,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6b839ffb-24e7-4bd4-8864-98ed5f5bd62f"));
		}

		#endregion

	}

	#endregion

}


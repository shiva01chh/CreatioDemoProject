﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EnrichContactHelperSchema

	/// <exclude/>
	public class EnrichContactHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EnrichContactHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EnrichContactHelperSchema(EnrichContactHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("920c182b-716a-4f29-b1e0-49c807b17b6d");
			Name = "EnrichContactHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c9ff5cbb-cb0e-4041-b483-395260757ab0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,61,107,111,36,183,145,159,21,32,255,161,61,1,140,17,50,153,77,242,229,0,121,37,67,175,117,228,236,67,183,90,37,31,156,197,162,119,154,146,58,59,211,61,238,238,145,172,44,246,191,95,21,139,143,34,155,236,199,72,178,157,92,14,56,71,59,77,22,139,100,189,89,100,21,233,74,212,235,116,33,146,119,162,170,210,186,188,106,230,199,101,113,149,95,111,170,180,201,203,226,183,191,249,252,219,223,236,108,234,188,184,78,46,238,235,70,172,190,241,254,13,237,151,75,177,192,198,245,252,59,81,136,42,95,180,218,156,164,77,218,250,241,101,94,252,104,127,188,94,150,31,211,229,222,222,113,185,90,149,197,252,101,121,125,13,63,219,239,175,197,93,3,67,32,134,223,215,101,17,253,224,129,229,243,66,192,241,47,30,216,200,130,204,79,87,105,190,124,149,23,14,114,177,198,47,242,165,56,91,173,203,170,9,183,173,68,236,247,249,201,81,244,211,105,209,228,77,46,234,104,131,23,233,162,41,171,72,139,87,162,174,83,92,91,187,34,208,234,119,149,184,6,140,147,227,101,90,215,123,201,105,1,219,120,3,147,105,0,212,95,196,114,45,42,217,236,217,179,103,201,243,122,179,90,165,213,253,129,250,247,121,85,222,230,153,168,147,5,53,79,132,236,188,18,69,147,172,68,115,83,102,245,92,119,125,198,250,174,55,31,151,249,34,89,224,136,225,1,119,62,203,65,13,114,47,114,177,204,0,187,243,42,191,77,27,65,31,125,148,212,15,66,36,139,74,92,237,79,46,107,81,1,220,130,104,116,242,236,32,201,139,186,73,139,133,152,155,214,28,173,157,53,65,79,42,145,102,101,177,188,79,92,8,201,135,141,243,239,111,134,161,161,166,198,199,79,196,79,185,250,107,113,35,22,159,96,196,122,179,108,234,161,120,157,228,18,1,248,254,252,187,77,158,205,146,143,101,185,60,72,62,168,125,56,69,232,117,178,159,20,226,46,210,118,186,219,133,61,112,22,159,1,108,209,226,230,69,185,41,50,54,151,58,189,21,73,6,236,189,53,210,248,95,64,26,144,108,13,112,218,136,179,44,58,3,217,177,123,6,114,9,144,252,127,182,105,108,214,0,69,108,61,147,192,72,196,25,146,231,239,47,68,10,128,137,61,146,15,34,242,69,173,200,239,68,145,17,227,184,92,4,40,213,77,181,65,17,129,188,36,185,144,90,40,142,12,240,226,212,227,1,151,5,118,19,212,18,59,59,30,103,192,116,91,172,130,173,98,120,171,229,137,77,120,234,129,151,235,245,165,123,174,32,155,160,39,10,75,148,26,101,3,61,69,54,140,97,207,172,240,22,213,32,177,161,192,39,183,121,213,108,210,101,226,64,72,204,31,180,86,215,162,81,127,237,220,166,85,210,90,57,92,9,182,83,135,213,245,6,37,234,116,226,182,156,204,124,121,68,100,180,179,83,137,102,83,41,129,78,10,225,30,244,115,243,220,193,234,96,26,236,252,5,255,251,101,224,58,129,170,150,203,179,90,47,5,162,40,85,223,80,33,139,189,147,15,203,242,250,27,119,13,229,239,248,255,173,213,82,243,194,62,201,183,223,38,83,249,199,62,182,125,149,22,233,181,168,112,150,104,62,0,197,104,169,123,106,52,210,100,119,139,41,74,157,127,158,2,29,45,242,117,90,40,158,24,161,74,194,0,146,15,107,251,83,237,240,110,155,152,34,32,206,91,16,126,102,250,10,204,1,182,133,154,236,76,67,95,247,219,52,25,158,92,139,56,3,91,23,99,252,87,100,120,12,177,21,46,64,246,215,96,180,160,188,177,186,249,42,7,179,54,75,238,242,230,70,42,134,228,170,42,87,201,115,152,79,186,2,162,72,10,48,157,247,39,57,24,178,64,7,145,237,151,191,200,30,188,249,129,171,140,128,48,17,3,146,119,104,40,59,116,245,252,153,236,239,80,211,109,153,103,9,245,193,222,34,163,190,211,16,176,4,135,212,242,89,201,84,232,178,74,213,132,213,63,246,253,93,158,243,182,140,177,206,20,98,71,247,175,97,70,83,132,174,154,226,191,213,6,1,247,205,207,138,171,114,10,212,133,134,230,139,178,90,165,64,90,109,156,113,127,4,204,16,117,180,156,168,0,161,84,39,87,37,144,241,31,191,72,181,60,79,254,150,46,55,40,192,63,255,233,11,144,163,55,228,140,72,77,254,74,13,231,23,2,29,146,233,167,219,117,178,127,144,192,255,204,255,42,238,147,223,39,147,253,9,252,23,255,45,27,238,162,177,190,72,155,179,171,215,101,115,186,90,195,10,2,120,16,16,106,22,36,35,207,45,86,12,65,160,97,80,208,141,176,95,229,82,204,156,85,221,98,53,114,57,166,157,63,8,83,145,181,39,237,162,8,59,67,127,252,29,136,85,98,84,79,45,174,15,199,2,88,172,3,137,46,25,122,140,102,109,157,52,55,105,147,44,54,85,133,46,1,210,89,114,147,214,189,198,113,150,55,73,82,229,215,55,81,139,184,197,95,85,122,39,57,104,8,139,45,140,223,234,48,153,132,73,178,173,62,120,190,56,120,87,109,196,243,103,11,64,236,202,162,46,113,35,212,102,9,52,186,74,151,53,181,42,155,27,81,221,229,53,114,174,134,194,121,23,205,238,4,248,232,47,105,173,117,19,192,122,43,65,77,207,78,11,16,194,85,250,113,41,158,135,208,62,72,212,4,45,67,7,56,94,153,255,184,217,64,167,170,7,184,162,85,221,188,169,78,196,85,10,62,134,164,86,228,14,111,79,147,253,253,196,236,134,162,28,152,248,212,129,9,202,99,179,92,106,28,36,101,157,86,85,9,234,54,50,177,189,68,253,4,187,11,0,138,178,1,94,170,107,16,175,82,168,46,150,185,212,204,174,98,145,107,202,4,254,14,90,201,102,114,25,76,13,127,152,3,189,215,130,227,167,164,192,15,147,179,108,242,158,77,225,43,64,238,152,123,70,166,83,182,235,204,37,196,37,189,19,67,62,193,121,45,164,88,200,146,123,209,204,146,116,3,74,136,40,230,10,86,76,81,12,112,18,27,217,157,52,104,99,103,206,227,241,145,142,164,195,107,140,88,37,75,47,44,202,33,84,78,142,46,4,244,7,130,56,45,174,243,66,36,181,251,207,182,170,240,123,16,28,146,129,111,197,162,172,50,137,221,75,113,43,150,181,198,100,223,131,139,202,133,235,28,191,163,177,229,28,156,105,40,181,120,83,5,250,235,36,50,246,252,56,45,112,177,118,145,134,123,218,244,202,182,11,209,212,45,191,18,124,140,133,64,202,150,60,119,1,226,123,83,43,97,179,89,21,201,45,146,230,80,97,150,61,80,146,185,230,130,104,8,155,99,137,137,228,145,1,242,38,99,194,6,104,71,164,139,155,36,110,103,0,123,147,19,253,119,16,130,98,154,161,128,201,124,233,210,94,167,137,229,63,100,84,174,202,229,158,131,74,0,5,62,157,156,213,146,186,65,23,217,14,92,241,255,48,81,11,254,30,133,3,146,147,63,18,125,151,35,104,198,115,44,135,183,98,85,222,10,103,36,221,44,170,63,3,11,43,227,103,222,208,100,73,130,40,184,145,178,162,18,139,252,22,228,68,45,251,146,105,163,70,114,167,244,78,252,164,248,2,24,254,102,242,94,169,97,127,198,70,144,124,25,230,221,188,37,221,196,9,56,176,82,72,93,40,50,126,81,179,215,213,200,189,248,50,24,33,5,76,219,215,73,30,189,118,180,146,55,168,203,149,254,113,246,196,82,207,251,93,218,148,111,147,192,56,243,195,245,26,52,95,70,77,246,130,77,222,138,127,74,55,176,87,26,129,83,191,108,139,35,63,204,133,104,214,189,193,174,71,151,68,177,29,140,146,129,68,211,2,35,222,129,57,128,35,156,255,139,86,204,119,209,163,211,141,208,65,191,236,35,207,164,29,203,195,175,83,218,180,113,2,180,35,198,57,63,94,138,180,82,33,192,157,238,40,162,219,246,49,165,178,179,126,86,198,118,25,94,14,225,235,174,218,236,218,81,204,6,54,168,21,99,18,130,18,162,210,235,250,134,141,210,184,205,228,64,188,17,23,214,239,170,123,224,98,210,100,132,191,29,4,140,132,114,211,248,3,107,180,164,17,158,215,175,197,29,169,127,24,41,206,203,166,149,157,150,236,15,162,220,27,212,162,12,168,17,44,15,1,194,170,9,160,36,21,159,29,203,234,183,152,222,233,162,78,165,127,248,207,220,242,3,60,209,246,75,126,175,21,206,36,168,142,108,243,89,114,150,161,99,123,149,47,100,112,239,221,253,90,204,95,165,5,176,163,209,59,157,212,125,152,101,211,198,89,7,223,132,219,1,55,19,236,125,244,178,166,161,149,125,154,5,17,173,13,244,23,6,195,64,201,71,145,16,71,170,120,16,44,143,157,0,44,84,108,106,118,109,186,25,122,200,242,48,167,64,169,31,198,211,49,111,238,171,48,103,247,251,237,210,139,169,165,255,80,163,95,99,182,190,166,96,88,45,67,44,67,245,71,227,216,48,162,246,117,137,195,185,32,183,177,149,99,50,215,131,212,9,197,125,6,216,0,212,16,109,128,215,124,106,82,239,82,236,136,11,118,162,179,131,196,159,133,103,13,96,64,85,245,246,35,166,138,10,230,100,34,78,39,135,24,103,2,202,217,157,31,214,240,47,104,116,43,247,125,210,106,121,113,120,233,182,205,86,121,113,89,228,141,109,60,127,1,62,116,91,0,82,251,211,119,167,22,232,25,32,84,125,95,230,133,106,45,163,174,100,128,83,227,211,19,248,235,77,65,127,233,97,207,234,211,31,129,209,9,214,44,241,186,50,164,119,230,135,69,102,154,161,140,96,189,105,66,115,25,113,102,97,121,66,213,66,96,40,234,101,209,51,239,66,237,176,27,49,133,153,108,117,33,10,52,176,8,183,239,36,157,87,46,118,248,245,93,190,18,243,203,102,241,186,188,67,238,60,73,239,235,233,31,254,103,215,98,234,45,167,76,10,144,7,235,130,47,232,43,179,160,175,36,214,124,171,61,236,29,124,93,232,23,247,181,217,119,5,25,233,194,129,252,230,14,154,187,96,21,237,28,27,65,165,9,134,100,134,222,40,233,86,64,183,66,175,2,139,105,182,72,126,55,73,107,69,229,131,133,72,175,149,166,152,149,162,19,200,70,74,250,245,29,132,75,199,150,70,105,1,158,106,238,52,234,98,18,105,185,135,74,175,106,172,175,103,44,42,207,238,1,51,170,75,199,181,163,206,42,202,124,34,207,160,17,37,163,196,206,10,16,16,141,18,67,87,12,86,77,95,212,249,12,111,22,21,42,103,69,83,78,67,82,94,55,0,15,117,10,208,126,120,159,124,78,124,49,33,213,23,35,17,73,136,190,170,159,36,95,12,48,20,54,10,33,77,173,253,130,143,75,52,69,117,46,185,235,175,14,31,50,61,218,211,50,106,157,204,223,149,23,82,122,79,57,235,14,150,152,208,244,165,184,106,222,108,26,71,110,186,203,76,189,94,28,107,126,132,191,102,161,117,118,68,135,39,83,93,97,21,227,79,11,96,208,146,179,69,39,24,92,188,116,45,193,185,187,6,22,163,115,134,110,88,96,116,48,136,131,24,1,244,121,101,46,87,197,9,204,134,15,115,28,65,204,23,150,52,16,109,129,146,134,175,55,203,229,84,183,241,28,147,250,199,37,206,30,216,45,192,132,24,145,188,160,6,218,217,146,210,228,68,124,220,92,251,214,103,92,184,168,33,254,160,226,173,234,223,198,54,12,13,124,250,147,88,0,205,77,3,231,157,65,73,123,41,173,203,177,146,86,232,228,152,49,226,246,50,108,200,6,196,109,164,229,40,113,219,109,54,143,145,184,132,141,50,227,79,175,22,74,194,210,207,62,19,205,130,86,51,151,167,142,200,244,217,160,45,185,12,75,183,165,2,103,236,135,75,210,17,162,173,109,15,182,58,28,203,30,36,214,92,97,164,229,215,177,243,123,75,132,29,247,11,140,206,45,102,200,62,154,196,144,38,12,237,123,76,24,24,42,249,121,68,128,29,174,131,241,29,46,4,147,244,173,88,130,182,187,21,135,139,5,12,214,232,168,37,2,70,11,244,173,168,215,160,27,133,202,41,4,15,254,37,48,197,115,202,82,43,171,235,180,200,255,37,181,37,172,178,117,100,176,233,92,34,175,193,42,62,145,157,105,4,245,229,12,92,77,157,179,70,231,107,30,84,36,18,121,168,110,153,240,112,189,6,235,219,129,63,213,248,249,56,241,83,48,4,31,66,14,88,1,254,7,227,87,127,180,39,120,22,83,189,22,18,85,103,0,152,150,162,6,5,246,36,226,75,163,45,129,240,61,254,144,38,198,27,6,112,23,44,13,28,121,202,227,57,206,136,10,215,3,134,106,108,193,163,9,114,115,34,91,189,3,142,213,35,133,174,51,162,137,62,128,192,218,172,85,167,151,101,249,105,179,166,232,86,112,77,189,120,140,70,149,147,79,170,199,239,70,86,225,119,175,32,31,221,3,79,79,217,122,27,252,34,203,16,69,219,142,31,63,244,112,217,37,64,119,15,103,23,39,155,230,138,1,127,96,78,13,211,61,10,160,86,149,152,200,37,234,31,77,158,164,133,246,191,27,81,221,79,219,72,168,142,208,9,221,88,19,127,112,193,122,95,91,186,192,182,122,145,47,81,106,203,128,21,254,155,68,30,253,106,146,79,72,176,211,143,199,229,10,179,123,106,101,149,75,105,221,182,142,245,209,151,47,65,142,83,216,131,242,35,30,129,28,76,77,94,14,245,177,215,14,248,65,193,62,174,143,61,74,182,141,130,201,163,58,183,193,28,90,4,228,9,69,119,184,52,50,6,139,220,14,157,54,198,176,96,125,3,50,11,215,206,166,185,50,105,106,121,13,227,200,4,24,167,130,43,151,177,211,69,162,74,179,139,168,91,245,209,33,133,243,187,250,170,96,150,233,141,61,108,255,80,64,187,31,145,168,175,243,165,79,143,69,89,60,162,111,28,54,51,140,24,149,77,78,107,109,23,56,242,29,12,6,79,114,35,69,88,32,202,127,120,83,249,170,172,77,22,221,100,9,203,167,16,97,52,217,18,100,65,114,252,138,147,163,119,220,195,201,135,207,22,9,50,184,86,26,79,189,80,128,26,27,80,38,9,77,21,77,195,26,169,189,63,175,114,244,6,216,214,35,143,112,248,115,27,169,222,113,126,87,20,169,70,211,144,192,64,95,47,83,14,176,87,144,199,40,34,74,66,97,170,48,126,74,4,28,177,236,112,171,103,48,169,40,200,156,98,80,126,60,45,145,244,74,40,45,162,250,133,146,35,149,218,4,97,146,23,92,17,20,221,111,213,252,75,199,249,6,91,48,143,22,90,172,22,92,184,110,2,112,180,119,250,56,138,123,164,186,118,70,101,90,86,45,154,108,164,60,166,179,250,111,121,157,127,92,226,210,218,28,49,87,113,59,224,130,43,63,103,57,186,143,169,206,165,23,204,56,225,233,245,182,34,17,11,129,147,201,128,156,240,254,155,32,58,65,70,96,104,63,89,81,108,223,102,167,186,119,221,48,55,65,186,21,227,206,197,132,214,151,252,20,203,156,123,240,100,216,77,145,255,8,82,55,87,38,63,144,223,163,28,136,169,142,128,225,167,250,224,72,36,245,166,18,201,221,141,40,146,251,114,147,172,202,12,204,247,164,185,201,245,196,40,147,247,170,248,160,211,103,142,151,229,134,210,155,174,54,5,109,165,134,139,26,40,208,240,213,5,56,212,31,216,45,202,15,239,4,94,83,59,57,74,26,248,35,129,177,54,235,164,41,241,156,145,208,37,236,136,255,253,91,17,246,36,79,66,212,113,52,149,11,65,10,95,198,149,244,82,243,56,85,208,139,239,2,181,103,192,236,41,87,222,128,101,44,175,150,106,191,255,68,48,30,202,241,191,224,221,84,58,88,242,191,83,172,179,125,200,163,27,200,207,100,229,201,47,67,35,68,91,68,190,121,172,199,4,184,251,194,225,254,56,46,116,47,170,206,166,201,98,80,126,20,172,255,160,211,158,203,197,206,52,217,12,94,157,180,195,108,3,206,41,95,141,60,167,244,194,254,91,156,159,178,83,78,103,216,86,124,210,82,109,171,163,34,119,202,166,139,12,207,219,204,79,202,66,4,142,89,36,200,221,185,202,180,30,19,224,12,158,240,252,137,157,17,119,17,240,177,19,227,84,75,10,27,2,254,255,209,178,92,124,178,33,73,88,13,81,120,148,20,140,168,190,169,252,56,166,215,220,66,98,115,88,150,181,160,17,189,83,232,23,32,39,245,169,132,154,226,69,185,169,22,194,48,172,2,123,178,89,47,85,108,71,111,135,9,53,43,50,120,45,238,38,238,153,244,235,18,28,153,232,174,45,110,52,80,161,118,143,246,231,172,160,69,140,28,151,209,86,18,104,111,67,135,30,69,245,109,170,187,173,94,118,48,241,236,249,137,19,188,214,220,114,126,18,21,12,49,217,104,103,165,187,123,73,182,189,1,110,245,135,127,26,174,205,146,122,216,1,185,54,49,34,182,132,60,163,225,214,199,80,179,130,134,159,244,90,2,253,6,132,209,218,58,62,214,153,92,227,43,231,86,111,125,88,223,214,175,186,197,84,41,116,154,130,86,214,168,85,29,199,172,5,89,187,100,173,80,190,50,200,218,113,252,190,48,126,28,199,61,99,12,1,184,189,112,76,159,30,93,152,158,28,81,68,31,118,50,251,104,254,12,249,23,104,121,157,28,217,159,152,255,168,96,157,209,124,211,76,84,242,114,184,188,73,169,166,167,206,13,232,235,212,14,197,242,228,239,110,114,240,30,166,212,115,142,45,217,16,129,28,79,213,80,94,154,105,69,124,24,75,105,175,95,47,253,63,149,165,18,5,97,34,80,214,166,241,97,40,60,148,43,217,3,134,108,27,3,130,92,94,118,129,93,122,177,252,102,57,255,221,204,223,134,190,72,41,247,173,0,151,38,95,204,224,252,170,84,134,82,94,95,44,228,75,189,211,66,111,126,204,22,222,244,55,80,229,156,112,93,213,52,190,127,35,93,171,169,157,244,14,126,253,97,34,115,229,228,237,7,182,130,110,35,181,53,242,165,20,162,120,252,83,73,125,249,235,133,168,114,153,102,61,197,246,160,115,168,25,158,20,131,217,131,14,136,176,177,30,229,177,7,39,245,189,29,78,143,108,186,61,132,251,204,2,237,3,235,205,12,236,253,207,127,250,50,99,185,155,59,19,190,10,251,159,255,236,165,180,234,126,51,222,204,166,108,242,200,72,107,110,166,213,151,17,209,139,65,58,192,94,127,116,148,193,131,60,202,208,237,202,237,28,202,49,250,32,232,91,74,255,177,203,193,124,144,111,169,38,250,184,46,102,76,139,25,27,220,209,95,227,156,205,14,72,214,215,220,127,152,171,9,70,221,26,76,45,237,110,133,12,49,121,157,147,204,44,180,75,15,151,121,90,15,74,47,85,152,127,232,76,51,237,116,26,57,132,150,27,55,212,137,52,198,96,220,75,236,245,129,148,153,107,6,183,46,3,247,5,2,63,238,180,109,226,177,249,89,131,55,99,167,127,71,64,205,103,31,252,4,174,176,55,31,53,179,105,103,12,164,118,126,135,183,61,97,35,218,25,159,91,219,219,237,15,223,104,7,183,144,39,215,65,86,45,116,66,121,98,172,149,51,86,192,41,123,18,159,203,73,106,11,59,147,224,151,242,70,140,52,127,85,4,73,187,243,40,20,201,64,253,250,72,210,69,174,147,26,3,1,131,161,52,217,71,22,206,143,190,119,250,104,206,81,68,97,41,192,251,65,143,104,184,15,247,235,243,157,40,255,40,236,56,217,165,234,94,28,109,224,45,210,2,239,19,9,245,228,198,36,104,112,246,57,43,220,95,208,84,105,78,224,118,152,225,205,239,217,25,147,253,241,173,215,161,38,226,76,63,171,67,251,226,95,43,54,214,43,116,73,11,123,205,51,216,76,250,125,195,239,32,7,45,99,123,229,104,140,97,220,6,43,113,9,3,198,102,79,107,91,71,206,142,96,1,35,79,172,72,156,115,81,39,32,135,192,44,95,203,55,100,178,45,12,97,116,141,241,199,67,114,82,80,13,156,28,185,38,240,76,95,184,182,11,165,153,167,190,203,27,60,164,110,127,217,89,164,0,221,206,102,79,209,171,19,28,82,119,252,163,199,62,70,90,219,52,51,122,16,173,55,6,165,130,79,223,112,92,244,242,237,133,128,133,93,1,31,129,140,158,94,241,32,116,138,194,193,215,248,221,16,162,124,122,51,147,190,237,32,70,251,127,194,97,225,148,191,81,33,205,72,214,160,246,68,245,135,199,230,4,223,180,10,82,161,253,238,144,146,79,134,195,233,185,19,76,156,154,195,107,52,154,164,199,109,220,64,26,181,183,118,159,38,64,50,154,196,30,124,2,175,199,234,11,146,232,118,143,27,28,137,240,67,156,140,220,56,179,38,115,246,34,234,95,197,189,12,180,158,167,121,197,159,71,157,121,99,81,186,214,90,84,181,186,185,107,6,151,122,225,188,253,129,93,18,216,230,176,222,56,71,242,4,239,85,30,58,156,39,143,197,63,172,111,157,230,171,67,38,108,235,248,37,209,17,232,48,152,122,208,223,193,30,233,79,166,71,192,81,165,238,129,15,3,2,61,60,49,64,31,170,134,14,4,7,248,153,61,71,129,99,206,1,189,67,192,248,41,94,208,101,28,234,0,70,110,35,186,7,221,236,132,57,16,150,8,221,124,9,144,46,94,84,49,121,170,242,246,138,119,119,69,30,70,247,222,169,249,197,33,211,53,44,11,187,237,169,206,191,171,202,205,250,232,222,219,26,223,99,109,57,141,221,186,69,121,116,71,155,124,153,89,172,15,107,149,178,202,50,231,156,12,73,154,21,202,203,208,252,40,157,212,207,233,70,47,141,90,59,55,85,30,219,197,230,152,244,56,216,241,11,11,128,198,168,141,99,247,231,188,228,104,152,117,100,7,104,158,51,115,127,34,124,157,103,156,119,249,29,190,176,182,132,225,227,182,192,25,61,68,149,124,188,111,217,176,86,213,63,179,154,118,176,117,96,30,246,35,59,96,136,25,240,114,8,166,125,6,230,214,154,48,162,243,194,250,182,43,251,45,0,197,59,115,11,189,26,184,165,46,13,164,220,244,165,190,69,180,105,228,99,80,91,198,50,119,184,238,137,157,90,104,80,189,151,39,217,221,201,232,241,69,71,234,209,54,103,26,108,87,122,37,233,182,132,246,235,141,210,13,201,112,88,171,29,239,59,222,183,148,241,141,211,95,140,207,18,24,145,153,192,23,154,69,251,190,223,34,165,194,70,3,229,99,58,189,61,137,137,108,47,186,248,216,215,203,225,46,150,7,129,83,253,36,238,213,228,98,244,53,245,86,115,102,182,199,46,154,188,89,170,116,238,49,123,12,242,19,26,47,108,141,188,224,233,22,67,206,218,155,195,18,44,70,75,76,92,26,74,80,248,158,39,40,200,183,141,40,25,193,134,242,219,185,19,216,59,128,144,201,169,8,125,67,200,187,237,204,140,7,7,121,165,26,110,185,195,117,82,94,201,221,85,166,133,140,35,85,120,41,25,180,25,215,254,33,221,76,125,228,29,239,225,218,153,119,218,70,63,95,246,77,97,132,110,230,53,63,240,25,41,113,167,136,0,108,29,210,185,12,219,33,90,215,129,176,199,123,43,141,203,225,61,185,206,237,82,140,3,124,195,200,107,1,195,125,68,139,208,121,216,117,27,254,124,73,248,237,146,152,6,117,86,89,249,121,99,84,105,187,158,203,99,184,4,109,250,232,244,4,254,61,85,243,67,84,43,211,237,195,33,4,116,188,155,243,21,82,20,246,151,174,83,180,17,59,9,255,81,187,168,6,215,215,84,229,59,157,248,150,164,205,15,80,76,118,220,89,182,96,156,112,15,63,210,245,72,209,86,123,34,160,211,217,48,101,86,223,72,28,46,185,255,27,96,13,7,88,35,17,255,109,114,208,194,160,122,147,208,206,34,58,113,109,40,156,194,177,174,130,244,206,18,254,227,226,176,172,199,147,199,97,71,134,27,241,122,38,6,126,182,11,252,13,234,173,133,233,56,61,223,202,137,25,127,207,103,192,115,67,177,121,140,11,75,62,90,148,47,198,117,227,50,105,186,131,162,29,47,153,216,192,32,46,136,122,86,249,87,18,252,131,209,58,180,146,142,251,129,24,109,159,93,71,52,196,64,165,165,111,207,36,35,175,207,184,138,47,136,195,104,69,214,49,132,183,198,147,3,146,175,174,235,149,103,181,91,17,194,87,47,250,53,169,200,198,58,9,23,126,56,200,40,163,240,108,149,127,59,224,33,157,127,59,123,245,63,54,146,99,123,181,212,83,63,136,168,70,227,145,161,48,173,244,220,178,136,139,209,40,233,142,10,192,60,69,252,37,224,21,132,94,109,139,240,78,88,132,142,52,228,253,2,102,78,126,195,47,95,206,46,226,46,208,251,21,129,92,31,245,97,236,29,198,174,85,232,205,247,105,213,128,107,149,125,11,77,89,190,45,52,115,94,252,112,11,195,177,123,141,185,29,161,150,229,179,83,146,122,40,75,142,210,90,156,133,190,27,221,222,89,162,46,8,122,174,254,226,115,224,184,57,245,101,212,48,23,162,1,107,137,152,158,151,150,83,109,237,183,96,253,59,165,247,109,183,94,90,150,165,149,48,126,76,111,192,123,207,149,42,247,177,150,111,205,161,19,214,138,46,242,189,30,74,203,172,211,8,234,233,160,230,79,102,85,38,7,244,46,158,126,210,30,191,243,242,38,221,112,234,45,249,33,162,236,221,189,236,32,160,89,18,122,4,255,19,219,107,135,190,107,135,178,121,87,26,131,122,29,152,45,221,103,67,41,47,160,246,206,230,121,71,189,118,185,254,171,86,70,255,66,62,242,105,176,154,31,22,242,112,64,245,226,223,240,205,170,133,186,108,191,107,213,121,112,184,19,129,180,70,70,84,198,254,54,195,207,89,139,218,173,172,66,11,114,121,150,233,199,73,105,105,230,151,232,54,91,43,130,129,157,159,225,153,134,147,160,208,89,112,202,110,224,158,122,17,128,170,69,138,6,61,21,203,56,242,160,150,61,49,48,182,72,84,171,168,144,91,90,28,73,47,51,254,127,36,213,84,151,100,28,206,137,143,80,196,49,78,251,199,108,2,227,235,45,118,23,219,209,199,175,88,227,16,8,69,87,94,236,42,187,99,14,152,157,10,104,12,80,164,16,154,45,74,195,40,234,1,5,18,251,106,226,4,187,135,74,227,236,184,36,242,131,65,7,111,37,127,197,224,235,246,129,185,218,42,108,108,154,3,216,130,239,173,91,153,81,214,81,13,212,156,156,121,51,110,213,189,225,37,121,182,172,176,182,166,186,52,153,84,98,178,244,214,22,21,176,126,169,2,168,231,143,130,124,175,149,53,180,22,23,254,140,63,140,231,92,159,245,245,103,218,83,93,31,52,88,149,85,55,13,21,60,245,240,218,75,46,117,137,216,162,100,133,55,121,245,37,191,206,169,247,208,160,55,15,39,109,122,96,189,49,32,100,122,40,216,201,159,212,111,254,58,19,87,205,59,75,157,101,182,249,22,149,135,248,219,75,111,42,240,31,143,238,221,78,242,199,126,255,38,252,198,125,7,253,201,186,133,93,229,57,157,171,48,185,13,235,251,26,44,27,167,190,178,199,228,191,177,96,30,202,103,113,186,25,87,234,46,88,110,52,76,72,253,158,45,43,34,29,185,208,36,117,205,163,221,1,24,147,250,239,22,136,54,215,112,36,66,131,75,67,251,251,164,139,68,115,137,85,71,82,249,80,116,185,58,215,177,21,120,74,216,103,71,238,68,21,53,23,56,29,245,135,29,228,66,234,118,181,169,27,188,234,184,160,98,152,200,98,39,71,15,201,29,12,191,100,48,105,165,41,24,163,202,61,40,217,58,119,78,110,135,137,184,187,81,196,139,69,186,76,43,117,164,188,235,60,249,66,157,187,236,33,254,36,236,67,86,90,174,44,150,23,240,205,23,26,224,97,39,195,84,3,78,42,10,176,156,42,85,28,65,191,73,53,152,235,72,44,158,170,107,175,4,111,136,4,188,236,25,126,116,210,142,243,168,175,42,199,5,235,126,112,16,172,7,183,85,161,207,33,213,227,96,251,153,26,29,94,42,89,209,180,98,17,213,47,86,44,216,188,188,218,91,38,94,226,66,207,63,247,120,42,4,242,1,190,70,240,145,167,80,31,121,231,239,61,75,128,232,229,148,214,246,237,249,149,27,100,5,102,81,171,103,187,104,49,253,173,9,37,88,216,252,138,192,37,212,88,21,193,86,249,180,71,205,8,106,207,85,65,140,188,73,166,216,31,157,122,167,175,57,190,99,130,131,109,206,67,170,69,182,216,124,160,176,216,242,5,187,39,187,233,23,0,220,186,144,26,2,221,125,53,245,178,127,189,98,210,109,132,84,107,239,183,119,170,231,178,178,185,166,202,73,32,246,14,223,112,52,126,166,180,241,204,254,185,197,121,159,237,29,201,81,171,55,31,235,42,255,136,149,22,149,204,124,219,149,97,230,84,235,116,147,213,82,83,9,114,16,32,86,55,178,255,80,172,181,227,123,124,56,89,133,104,230,76,69,91,14,182,149,243,157,37,21,199,246,215,54,87,63,131,79,213,155,195,237,12,193,78,73,3,176,66,15,242,179,225,249,83,120,44,135,143,13,48,11,97,200,146,165,221,106,55,49,28,8,246,15,12,238,251,86,190,117,168,43,98,67,234,132,76,121,254,212,190,157,6,27,254,144,147,7,219,22,211,128,191,0,98,121,215,255,236,42,87,252,151,193,182,47,125,49,164,97,3,132,181,144,178,63,243,106,4,163,239,45,205,83,189,20,181,205,111,148,245,10,30,195,36,253,79,84,52,191,106,213,224,21,60,30,100,72,200,199,163,6,28,248,21,89,237,153,246,152,219,35,55,122,232,94,58,36,56,57,112,80,27,126,218,6,70,50,89,218,195,124,149,232,73,67,145,201,61,116,23,104,196,222,56,179,225,206,190,243,33,80,100,205,86,96,12,35,177,135,161,73,151,93,11,1,248,195,114,131,179,94,67,31,246,42,81,71,245,163,192,21,155,248,108,110,117,75,244,85,131,83,179,10,118,97,53,172,233,134,103,204,10,165,179,87,245,245,241,77,10,246,192,50,89,168,255,149,86,184,170,191,172,190,77,57,40,94,149,205,244,217,39,226,52,82,23,169,54,47,188,82,52,113,141,103,165,114,237,96,202,203,217,200,200,70,190,90,47,133,66,78,7,56,248,111,70,121,57,45,231,71,101,118,175,94,106,5,97,114,139,117,65,205,211,172,234,1,88,134,66,24,6,169,7,154,240,220,188,40,235,182,249,11,25,30,56,28,102,189,40,149,49,209,212,47,221,25,100,138,73,87,111,36,53,105,115,77,88,226,179,238,17,63,178,9,211,39,210,32,90,118,90,16,160,38,81,194,64,25,42,237,149,210,170,207,217,117,243,228,137,90,129,243,178,214,84,50,117,64,12,125,155,68,94,133,226,217,1,150,22,221,228,26,140,61,123,97,228,154,85,241,150,215,158,6,235,40,183,163,163,171,120,101,240,135,191,94,18,153,78,127,92,153,177,100,155,17,137,177,157,73,120,154,196,118,215,197,117,116,101,157,249,139,188,200,48,187,234,232,254,242,12,12,58,23,202,224,67,3,152,122,147,47,242,117,138,149,5,101,50,137,150,237,242,129,245,109,85,76,91,75,71,21,77,68,79,232,130,142,196,199,231,12,205,7,235,10,39,59,67,75,138,135,87,56,210,197,46,188,92,13,223,169,241,197,188,10,88,1,232,251,64,193,94,253,100,87,154,203,170,99,105,62,183,6,112,176,156,175,10,230,232,1,153,145,172,202,31,233,98,172,216,44,82,67,72,213,239,162,110,243,23,162,89,220,168,119,155,236,60,152,95,18,147,98,241,45,220,75,142,211,229,82,155,53,129,22,146,20,205,28,88,68,106,103,135,163,160,45,117,14,91,215,216,4,70,32,149,192,210,185,116,223,153,204,39,233,234,126,161,30,80,115,8,207,30,229,175,91,61,18,82,154,219,157,132,75,51,163,18,215,42,1,77,21,55,112,121,115,153,94,15,150,139,214,84,67,5,53,60,164,236,29,218,4,208,80,152,46,203,20,21,209,131,207,113,94,3,184,183,102,222,206,98,247,7,150,205,52,61,161,105,126,151,41,79,116,144,75,97,232,72,232,246,184,92,173,64,47,16,67,78,146,175,191,86,219,44,187,232,152,171,211,72,38,5,99,0,246,101,121,39,170,233,46,66,107,53,144,207,227,212,115,73,71,99,100,178,127,54,107,15,138,65,245,212,244,84,238,19,80,66,167,32,166,29,48,152,208,17,230,54,123,20,58,1,16,173,104,190,57,9,48,253,85,116,191,251,108,125,216,209,128,211,187,231,128,0,37,97,12,189,136,139,241,247,180,42,88,145,247,246,178,237,37,175,203,196,221,89,238,104,144,84,148,225,70,153,94,174,164,100,253,41,95,175,69,54,239,240,64,208,168,86,173,135,20,113,103,9,8,138,224,169,130,187,202,81,15,148,111,15,78,103,174,13,226,80,177,35,231,132,113,203,27,80,23,209,90,84,186,109,231,141,168,139,224,141,168,11,239,38,118,232,78,84,108,227,253,203,81,157,133,128,158,188,178,147,251,128,244,22,175,71,247,62,9,221,247,92,152,123,223,174,189,77,172,191,75,119,173,146,82,61,47,61,183,42,212,71,10,212,143,57,48,234,100,84,197,77,166,158,205,44,57,61,61,73,228,245,100,229,111,209,40,202,58,137,74,138,206,115,51,133,179,91,226,126,208,67,144,225,135,157,164,135,130,245,25,215,203,242,94,140,125,1,178,47,88,55,62,229,67,225,241,96,99,225,204,164,160,41,136,83,101,236,170,145,180,20,230,177,57,117,199,71,253,171,171,86,51,254,110,79,17,220,204,6,6,76,167,46,27,211,65,233,120,194,136,128,184,167,153,203,242,250,221,122,105,98,228,68,41,223,38,147,208,140,220,28,6,182,137,19,234,182,55,176,27,120,24,182,107,231,225,48,97,103,34,147,129,2,182,219,69,164,181,49,147,218,83,2,249,6,138,118,5,101,74,250,147,59,151,79,103,16,217,35,140,183,122,90,91,59,166,250,66,224,120,107,106,64,254,130,181,134,127,158,36,6,62,11,93,98,152,199,3,31,203,249,181,246,25,131,63,192,36,11,108,220,94,242,14,53,152,102,28,70,178,24,92,35,21,0,94,243,146,80,238,48,192,156,200,130,90,167,135,6,22,188,157,113,69,158,149,77,195,189,251,65,238,186,187,60,242,19,202,50,182,52,40,105,238,242,230,198,160,34,21,34,173,12,223,17,181,137,41,61,219,145,186,239,118,68,94,236,8,164,194,177,236,127,39,34,193,206,96,190,254,58,249,42,168,38,180,126,112,35,234,166,44,243,48,253,160,75,127,219,35,0,90,48,67,222,151,131,44,111,27,39,50,230,147,52,186,205,177,101,200,238,110,173,134,91,97,61,82,79,173,133,152,251,3,141,107,167,21,24,215,140,224,165,248,247,130,246,204,254,182,105,205,3,244,222,187,179,118,37,172,249,231,219,125,109,195,207,67,160,109,0,246,89,128,65,194,7,248,210,236,251,71,245,143,66,211,121,158,73,227,207,212,245,166,31,216,181,89,109,19,242,211,190,246,74,122,8,187,214,159,19,58,234,175,218,189,249,184,204,23,3,142,135,241,37,178,43,255,234,82,79,93,138,255,22,164,248,213,23,164,144,219,63,188,26,197,224,215,247,187,50,111,25,188,61,140,84,84,50,100,193,31,197,153,49,136,251,228,45,217,49,217,96,174,121,25,174,156,17,236,56,56,43,34,72,246,253,207,76,252,151,246,31,165,84,132,75,157,3,235,68,60,6,141,58,0,31,155,72,67,85,45,182,163,82,180,222,129,70,151,75,125,61,39,244,254,192,47,115,89,212,221,58,202,223,144,157,237,9,248,248,11,103,44,13,195,131,165,183,72,91,88,35,252,41,60,25,63,161,43,91,193,100,117,247,114,87,63,206,250,110,226,137,115,13,204,220,178,107,95,146,227,29,58,189,16,127,210,123,238,88,228,243,227,17,21,184,34,55,72,243,119,32,185,130,133,177,58,82,80,130,126,161,244,117,241,45,119,54,158,65,144,163,165,220,7,118,43,137,192,107,231,194,187,11,167,109,22,19,73,235,249,28,56,72,104,175,103,247,225,144,51,5,51,135,142,51,99,77,31,206,124,226,158,188,110,62,115,23,75,231,185,7,83,152,188,33,58,200,156,103,18,133,109,60,250,213,253,81,254,6,255,247,127,200,13,133,14,155,190,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("920c182b-716a-4f29-b1e0-49c807b17b6d"));
		}

		#endregion

	}

	#endregion

}


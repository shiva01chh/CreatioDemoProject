﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProcessUserTaskUtilitiesSchema

	/// <exclude/>
	public class ProcessUserTaskUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProcessUserTaskUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProcessUserTaskUtilitiesSchema(ProcessUserTaskUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a4180509-1689-4ac3-9cf4-0c34bddf3a44");
			Name = "ProcessUserTaskUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,60,107,115,219,72,114,159,117,85,247,31,198,184,170,91,176,150,129,237,75,93,37,101,73,116,201,146,236,101,202,150,181,162,148,253,32,171,82,16,56,164,16,131,0,141,1,37,51,94,253,247,116,207,11,243,192,75,146,237,100,63,172,204,193,76,119,79,191,167,231,145,199,43,202,214,113,66,201,57,45,203,152,21,139,42,58,44,242,69,186,220,148,113,149,22,249,95,255,242,237,175,127,217,217,176,52,95,146,217,150,85,116,181,235,252,134,254,89,70,19,236,204,162,119,52,167,101,154,116,246,249,120,253,223,240,207,15,197,156,102,94,191,119,89,113,29,103,233,255,112,220,222,215,247,105,254,197,107,60,163,11,9,218,255,180,201,171,116,69,163,25,208,212,14,245,156,126,173,234,198,37,167,224,213,171,195,98,181,42,242,232,125,177,92,66,115,253,221,228,19,246,104,255,18,253,7,107,251,92,210,182,246,232,232,77,235,167,99,152,77,149,82,214,218,225,109,156,84,69,217,213,227,180,44,18,202,26,191,159,108,82,100,212,109,154,80,46,155,232,40,174,98,208,133,170,4,168,131,6,252,65,175,229,239,166,238,23,83,236,192,1,22,25,139,212,63,6,116,189,168,210,140,79,156,115,20,71,222,210,178,162,165,49,22,105,253,207,56,219,208,243,237,154,146,125,143,169,230,231,122,20,103,232,182,214,77,127,160,98,121,228,118,117,129,204,146,27,186,138,123,1,136,110,205,131,1,248,102,213,79,131,217,25,0,1,168,191,149,116,137,212,31,102,49,99,175,8,104,223,58,163,72,228,111,113,62,207,104,201,59,61,127,254,156,236,177,205,106,21,151,219,137,252,125,70,215,37,101,52,175,24,73,243,69,81,174,184,129,144,248,186,216,84,36,209,96,200,141,128,67,160,11,169,110,40,116,6,238,199,130,101,52,163,43,128,16,41,20,207,13,28,235,205,117,150,38,36,65,186,154,200,218,249,198,73,211,19,0,237,92,131,100,97,174,175,200,41,31,43,190,187,180,243,134,119,20,200,6,130,24,254,205,193,143,145,98,193,169,187,152,154,68,249,84,41,178,88,85,162,8,78,112,232,55,178,164,213,46,194,218,37,247,67,145,210,91,192,241,20,212,199,28,192,163,112,87,241,146,220,162,70,15,66,116,14,189,31,133,166,164,95,54,148,137,73,14,194,116,38,6,180,49,245,111,52,159,11,97,243,223,162,213,105,108,85,231,41,232,232,67,117,185,42,148,34,63,89,109,5,250,239,167,179,190,129,177,62,11,107,103,191,103,93,151,87,228,55,5,245,81,162,95,199,37,8,17,200,24,46,252,83,53,228,123,136,255,56,223,172,94,17,30,89,166,249,105,188,164,7,73,165,250,244,40,192,10,7,17,193,190,46,9,83,64,209,132,1,101,188,179,115,60,79,171,49,57,152,207,199,192,221,245,118,160,186,74,112,105,37,210,168,97,250,10,254,93,231,39,160,23,56,144,171,2,159,72,191,142,122,56,159,164,164,39,67,197,253,32,207,121,160,165,209,0,247,114,186,204,33,212,97,152,254,64,87,215,180,188,50,176,121,2,106,104,121,24,21,195,53,90,246,223,159,248,56,163,243,98,198,59,133,35,248,231,251,226,142,150,211,252,54,134,76,51,175,194,209,110,7,17,103,52,41,202,57,73,231,32,253,116,145,210,178,155,148,119,155,116,254,90,14,154,206,191,147,87,149,137,224,5,163,229,121,204,62,235,20,139,247,85,60,160,113,70,231,82,199,218,6,144,87,228,77,204,104,59,60,87,23,65,71,129,185,27,204,84,57,29,233,109,92,81,209,101,45,126,180,226,10,71,132,91,102,243,180,53,134,15,180,186,41,230,109,192,89,5,102,150,64,100,139,231,69,158,109,201,20,82,124,242,95,25,252,111,159,192,63,63,196,57,136,184,132,149,76,133,185,63,45,195,64,146,19,40,161,58,144,204,180,236,247,13,45,183,228,16,128,87,92,77,110,121,210,152,231,34,105,60,102,95,66,179,183,196,69,86,226,239,152,139,154,48,254,237,98,58,151,179,221,1,165,34,148,125,1,250,114,122,231,163,11,245,240,64,101,169,10,97,160,64,236,28,198,249,25,204,248,34,135,168,179,74,43,58,71,91,3,136,32,9,58,22,93,164,13,166,108,157,197,91,158,45,51,187,3,200,227,96,190,74,243,179,116,121,83,225,183,69,156,49,202,191,221,239,242,63,64,101,4,14,83,36,167,97,32,254,194,76,56,235,228,247,195,24,72,159,194,194,139,187,143,253,78,237,137,156,15,22,219,44,64,187,53,167,56,15,222,166,25,134,174,125,194,81,114,121,136,166,63,210,234,70,199,41,22,138,70,140,158,96,185,176,186,192,5,66,116,252,101,19,103,192,78,88,32,154,220,198,137,72,86,212,50,170,39,38,64,49,100,64,104,18,33,187,148,180,218,148,57,210,179,107,232,176,163,75,239,139,132,7,130,235,140,10,231,130,49,89,96,63,22,105,192,97,188,70,201,134,146,51,74,201,200,90,252,150,189,148,220,13,230,90,80,164,146,169,95,251,206,240,200,197,26,202,73,248,244,177,6,226,0,158,213,28,201,118,139,17,30,168,104,202,78,54,89,246,177,60,94,173,171,109,216,4,120,36,184,255,154,27,130,7,32,12,236,149,147,18,214,142,112,230,184,112,76,226,74,219,179,152,96,48,118,231,46,218,35,212,42,208,1,69,123,48,146,200,95,53,78,121,247,65,126,201,8,193,151,31,175,89,129,233,105,24,252,91,244,242,223,163,151,228,79,217,145,164,176,174,41,42,72,15,200,134,81,2,201,28,185,75,179,140,92,83,112,94,171,226,22,92,51,126,90,131,69,163,32,74,200,19,65,218,44,34,96,45,36,32,191,114,114,131,78,243,2,85,253,184,88,64,40,57,47,142,98,158,33,179,10,188,68,48,50,227,175,84,77,236,112,158,130,201,158,208,59,252,119,168,27,138,12,189,9,48,11,178,86,88,9,33,188,177,242,225,71,178,142,116,74,203,20,166,36,190,138,31,35,8,171,156,70,135,138,80,195,83,176,172,81,93,145,117,154,207,83,16,49,56,174,234,38,174,120,38,189,76,97,145,165,68,140,44,165,95,105,178,1,7,72,174,183,132,165,203,60,206,90,194,47,111,225,89,48,207,23,246,3,9,36,152,156,3,92,249,35,218,123,206,187,212,35,132,122,179,201,94,50,65,223,185,247,60,153,144,84,44,15,21,21,13,36,144,143,208,161,188,75,65,116,255,66,96,40,119,173,56,214,32,78,65,246,101,115,93,20,25,122,138,41,147,108,63,150,24,222,108,103,28,190,114,23,138,4,229,31,84,115,113,151,115,111,185,174,235,67,59,59,28,42,36,169,155,12,61,4,239,18,181,98,16,67,238,110,210,140,146,240,153,28,245,247,191,203,97,31,57,252,103,16,193,192,194,117,80,82,88,141,62,2,204,206,195,176,222,155,126,69,12,181,124,172,197,171,219,2,98,236,140,86,186,162,3,33,138,71,59,25,154,101,0,25,171,20,48,225,61,132,55,40,120,233,82,54,241,65,102,140,78,84,1,71,64,80,142,68,160,96,16,31,114,160,27,1,133,53,76,233,87,65,65,100,163,98,18,242,238,25,6,105,140,72,181,197,114,164,182,163,52,169,209,172,85,36,208,202,156,161,232,58,182,38,96,176,240,190,201,37,253,243,233,46,169,209,159,112,57,76,229,58,23,163,50,186,167,208,113,85,136,134,255,67,59,20,161,1,0,29,203,131,244,43,10,131,255,173,115,148,178,206,127,248,240,250,231,88,24,74,202,206,54,121,14,32,228,111,118,83,220,73,176,5,79,240,21,23,21,242,200,35,83,33,53,97,249,96,118,255,111,152,250,113,77,115,197,64,139,32,143,187,201,166,44,65,83,46,52,147,59,217,103,234,250,74,144,14,249,33,168,103,177,112,33,143,48,131,16,211,11,3,164,199,162,67,5,230,55,96,17,48,165,183,89,188,100,192,99,152,67,158,80,224,139,213,126,2,99,248,28,165,166,10,204,208,253,182,248,12,26,237,206,0,51,3,97,166,151,47,174,70,237,110,128,167,218,16,121,148,90,229,85,185,61,45,32,130,133,61,42,196,7,82,59,45,180,90,225,167,152,30,111,179,147,11,35,171,71,147,119,192,144,253,125,14,40,226,134,77,254,252,83,67,180,191,104,43,151,46,175,254,98,250,67,69,146,156,23,2,17,61,33,128,227,95,149,211,217,181,243,37,124,113,171,233,54,11,236,106,186,177,94,82,18,148,78,46,64,36,42,243,71,157,73,231,58,241,150,107,25,190,126,209,141,97,128,9,182,69,242,216,167,103,228,166,250,154,125,125,208,189,92,222,23,99,63,182,161,104,12,248,125,128,109,21,233,71,224,246,247,82,216,11,173,130,93,104,165,233,168,52,174,15,235,161,221,29,144,58,106,113,88,155,162,64,142,58,225,140,10,71,144,82,107,16,62,49,210,246,42,240,181,189,124,104,71,31,105,16,166,246,137,181,82,239,60,85,63,152,32,95,251,146,224,13,4,9,26,231,129,173,11,74,71,115,64,88,73,88,226,135,67,153,92,55,96,16,41,184,118,200,145,129,252,176,131,81,90,234,190,97,34,246,87,177,132,157,127,204,161,83,155,224,26,71,188,17,154,216,201,95,123,224,135,98,142,85,169,135,224,82,67,30,142,172,215,38,59,199,89,70,214,210,19,22,241,167,150,117,160,61,52,24,77,43,128,105,173,16,158,14,169,229,191,163,14,145,204,83,149,139,149,169,164,57,53,89,253,112,148,184,161,58,196,61,107,69,87,111,182,192,13,55,98,140,162,186,248,193,21,89,100,123,199,95,177,184,204,68,53,217,105,216,39,162,79,52,43,54,101,66,85,173,70,242,232,125,10,43,64,72,185,33,189,32,127,202,210,145,232,94,155,72,24,194,68,71,50,127,190,137,243,37,247,44,209,197,122,142,10,55,170,11,163,135,144,136,111,74,138,27,39,145,174,141,202,198,145,97,77,27,62,146,236,11,124,104,72,2,86,232,198,94,151,129,182,160,188,41,140,189,217,43,91,252,3,22,91,148,219,156,182,78,198,171,62,161,175,77,130,78,65,163,43,88,85,212,49,66,86,207,202,227,136,226,190,4,214,124,30,157,121,212,209,209,200,51,186,51,146,193,73,135,147,90,152,249,196,79,203,19,158,26,152,196,4,58,194,195,143,141,75,129,238,216,25,35,235,32,53,32,86,215,82,191,144,182,66,58,204,164,61,200,252,84,223,110,56,206,158,64,203,171,29,102,164,109,176,83,109,161,143,78,28,61,103,125,209,104,211,63,197,89,255,140,132,82,59,194,25,197,83,43,166,127,21,45,205,137,202,78,164,98,130,225,30,223,150,197,42,172,11,226,226,132,211,105,153,28,103,129,35,43,181,81,101,72,172,45,66,71,7,249,92,13,168,3,137,49,208,11,61,173,65,199,152,61,251,94,179,245,173,72,205,81,75,100,232,28,181,41,116,204,13,179,77,173,248,23,57,22,249,155,5,105,186,39,63,186,107,13,114,83,129,240,160,76,171,27,192,149,38,176,34,23,101,217,104,182,185,174,228,65,131,177,21,238,251,178,131,49,241,243,130,206,180,224,255,75,188,31,38,49,176,213,162,130,255,31,127,5,232,44,100,38,227,27,83,129,246,34,3,184,4,64,1,216,36,189,224,24,122,170,177,107,179,187,91,149,53,171,10,124,77,111,245,142,46,100,6,162,74,177,54,44,183,2,59,0,206,142,71,141,213,207,168,218,90,101,88,13,185,157,59,117,213,90,111,149,138,53,203,160,68,200,205,222,205,234,84,44,225,217,142,47,148,230,243,4,151,160,8,117,29,194,169,187,36,119,211,202,38,191,238,13,242,151,36,16,19,69,118,100,231,155,246,252,148,38,206,146,56,139,203,61,28,48,9,71,40,107,167,48,212,169,163,106,106,51,104,222,176,65,34,80,100,216,204,103,79,100,186,32,96,48,235,45,155,246,124,146,65,162,205,66,214,193,186,254,205,131,39,49,203,105,80,243,53,121,56,216,67,122,108,81,171,94,197,196,6,63,237,33,126,34,71,187,252,97,227,54,157,60,193,203,72,140,199,88,240,240,228,66,236,157,227,113,61,181,73,38,206,240,13,221,155,179,249,18,76,80,34,184,53,160,114,53,111,155,206,28,108,134,153,96,34,183,129,196,46,111,247,192,181,189,9,31,76,148,151,84,76,234,30,14,108,139,69,156,149,103,7,130,137,58,170,78,231,138,39,237,59,140,51,155,119,105,110,109,50,74,254,117,109,27,202,76,87,138,227,188,80,123,182,46,89,125,250,109,38,194,86,204,150,41,69,203,89,5,245,91,111,181,121,252,48,55,98,204,85,212,13,77,62,31,148,203,13,58,73,220,10,11,93,249,215,169,190,166,165,105,148,37,120,57,198,33,174,105,152,43,118,57,210,35,223,31,171,246,236,26,68,111,230,71,214,100,212,120,153,219,25,231,167,212,23,111,250,238,186,211,95,27,120,50,214,167,234,177,64,132,39,190,196,101,130,109,93,202,221,155,182,233,135,30,59,9,155,73,183,93,111,47,9,81,191,70,186,42,36,200,180,228,205,171,32,190,74,181,59,119,23,139,113,49,160,143,160,186,107,40,40,121,180,197,144,62,99,17,240,251,44,6,11,61,172,233,88,141,63,194,221,77,194,4,209,76,232,196,58,163,214,14,84,194,54,185,224,5,13,45,198,206,116,126,236,78,76,147,113,90,242,131,245,103,116,137,137,61,78,225,48,75,161,97,150,148,233,186,146,71,210,4,125,187,62,129,76,82,136,171,130,189,19,122,87,129,185,224,129,32,126,117,196,34,111,66,190,25,243,186,183,84,52,108,23,240,136,67,58,162,76,121,106,159,165,99,181,43,218,1,69,202,177,166,187,63,108,78,213,57,97,126,190,133,18,182,166,9,47,205,52,28,65,84,193,227,103,132,207,39,70,193,71,71,95,202,190,4,19,189,109,44,175,96,248,172,224,231,87,191,119,32,110,74,11,185,56,182,199,179,223,7,134,205,97,150,222,225,42,252,185,2,75,126,92,52,125,124,100,124,76,28,230,7,55,27,186,130,208,141,67,51,143,243,113,166,123,155,122,92,20,131,176,140,135,252,20,191,126,122,112,86,55,239,148,227,120,80,116,110,25,220,19,158,145,159,253,20,240,18,103,67,135,46,174,203,107,129,226,122,66,84,251,49,85,114,221,209,124,174,171,29,93,36,232,112,220,33,187,16,109,65,174,137,92,205,229,69,139,214,228,96,231,158,208,140,81,69,124,71,90,176,112,27,246,31,146,41,56,254,64,210,218,25,36,219,105,182,88,232,210,21,181,114,202,32,7,0,152,135,193,252,51,205,10,193,147,34,213,236,119,114,151,86,55,164,40,231,64,42,30,128,4,23,218,117,193,233,7,186,125,78,195,155,45,238,79,90,14,95,211,134,55,201,134,187,253,143,2,220,76,77,40,236,246,207,6,246,222,172,205,236,219,225,203,60,132,98,245,110,40,168,40,144,50,117,48,94,252,50,247,61,46,175,100,159,211,184,186,225,51,58,74,75,121,117,27,207,99,214,132,68,179,117,150,86,225,47,227,95,164,218,192,138,147,198,201,141,154,66,43,28,92,169,182,226,208,179,211,228,48,68,115,216,6,107,191,21,148,162,239,149,162,79,176,183,11,90,244,158,230,75,80,206,103,251,228,95,53,33,152,163,85,105,190,145,59,55,146,213,59,222,36,241,212,123,39,240,183,105,201,244,73,250,54,89,213,167,72,147,182,115,163,8,122,68,94,191,38,246,117,11,227,227,174,74,46,121,237,198,227,88,104,183,140,240,170,29,86,120,24,13,101,226,234,116,208,7,233,187,230,119,249,242,106,180,75,124,204,167,5,75,37,226,20,172,92,224,233,134,244,143,171,134,99,169,45,119,169,120,113,131,196,89,86,220,209,186,168,38,143,1,255,156,4,184,46,137,129,99,58,82,46,169,61,251,85,21,153,3,73,244,173,184,108,227,140,147,83,24,82,193,193,242,173,128,165,2,197,153,152,254,119,40,227,146,135,87,112,37,45,130,134,31,84,198,229,101,126,19,15,154,95,83,77,87,176,72,85,117,219,93,172,5,204,91,20,7,151,87,65,155,167,85,215,184,104,67,219,144,77,227,93,15,162,5,74,31,40,247,119,154,157,131,20,182,240,173,243,106,29,215,199,26,128,219,75,117,190,109,173,25,210,124,11,76,87,250,82,180,49,211,159,237,107,63,58,101,7,217,93,188,213,219,209,245,66,94,50,245,222,218,128,175,15,201,59,28,192,169,75,68,242,182,218,161,238,26,26,171,7,215,53,26,231,237,221,139,106,16,177,151,144,78,43,150,245,38,75,186,232,42,226,168,76,147,90,52,115,58,199,126,50,7,134,236,32,249,140,79,142,252,70,179,53,136,209,40,36,236,169,144,55,113,148,209,221,239,173,239,175,73,161,202,3,207,46,86,25,206,174,116,120,38,184,69,75,82,24,245,98,23,254,236,121,116,202,17,240,241,215,95,181,196,17,113,41,123,72,132,252,252,176,59,248,50,189,178,35,79,77,39,124,130,145,10,136,105,72,11,59,195,124,244,93,61,113,56,197,65,59,178,228,105,136,143,250,47,127,32,242,119,198,181,144,230,44,93,2,148,247,8,120,68,231,11,69,161,204,198,33,132,107,201,41,113,20,238,205,38,205,230,184,231,119,25,184,201,210,177,121,235,4,83,35,151,54,45,7,116,93,207,12,164,117,134,194,174,163,131,245,154,226,73,131,177,66,224,172,98,118,108,106,185,209,58,9,141,2,242,150,239,28,132,193,183,111,159,2,37,178,79,193,171,79,193,183,23,247,159,130,241,167,32,17,119,222,68,219,75,213,38,76,72,117,253,7,52,223,223,7,246,170,6,25,140,82,155,27,151,82,228,166,27,15,0,202,239,52,246,83,142,220,48,230,225,208,15,53,121,122,47,85,76,219,96,221,85,96,215,169,225,83,125,199,187,119,205,163,50,17,230,22,142,196,93,52,224,40,184,19,6,109,121,156,241,240,189,97,42,215,19,241,255,177,169,10,222,70,219,60,36,93,17,50,173,47,231,114,8,54,69,198,221,244,65,153,143,128,209,152,241,180,37,44,48,133,57,207,11,113,133,60,40,79,113,232,86,245,47,141,214,218,64,253,129,85,154,69,103,73,230,59,21,99,164,14,46,252,226,139,138,242,111,81,147,196,30,174,172,192,120,12,210,156,25,114,8,227,140,82,117,73,167,239,162,144,119,96,69,31,14,113,58,154,199,67,106,143,182,39,199,189,133,248,33,143,58,76,200,162,254,193,212,198,183,186,100,105,116,100,151,46,10,235,162,50,76,251,202,102,160,49,20,18,212,13,40,193,132,188,52,249,225,222,192,125,241,244,27,184,114,248,188,160,28,192,13,102,155,245,149,220,11,6,57,22,73,226,28,1,177,120,65,179,173,130,215,126,169,107,6,211,89,139,169,234,248,38,46,233,63,178,204,108,223,20,239,220,174,231,33,185,46,231,27,142,134,204,183,224,8,240,33,18,225,55,234,71,99,32,88,165,21,231,64,254,75,69,40,30,163,250,41,107,177,42,46,151,180,2,127,196,255,10,199,88,161,10,55,236,40,52,177,121,155,39,55,101,145,131,255,246,223,111,48,114,145,110,158,171,100,184,225,241,2,34,8,84,22,212,180,142,88,61,109,237,160,197,180,175,32,117,173,21,84,204,211,190,251,125,17,207,141,171,245,82,199,218,18,99,185,178,232,122,241,66,63,79,161,81,212,239,38,120,137,89,236,129,96,15,205,205,220,204,202,208,214,180,17,129,206,163,120,148,73,148,251,228,37,24,205,251,174,220,194,125,230,194,98,147,91,214,209,92,176,239,5,227,121,97,141,218,44,88,169,129,206,201,189,29,124,178,36,194,58,156,74,215,14,26,204,83,14,230,21,215,58,166,19,153,202,113,231,182,0,159,88,231,206,6,114,39,127,20,34,62,18,246,110,61,161,160,205,98,186,56,41,42,126,98,50,20,90,174,160,142,172,76,115,112,81,7,152,152,81,175,156,50,208,139,216,110,174,222,148,84,207,105,245,164,72,248,78,10,100,133,177,204,177,240,166,177,36,196,254,214,13,71,198,42,37,26,94,32,170,197,32,1,202,78,3,10,70,3,75,65,18,206,57,178,175,231,161,144,113,195,147,35,246,4,205,75,38,222,116,204,194,181,243,140,198,84,95,214,199,171,236,222,72,172,190,128,178,240,210,203,200,90,106,118,21,158,28,28,23,141,117,168,186,16,197,57,80,159,140,115,43,80,17,46,48,127,131,37,49,11,249,255,163,147,2,184,241,89,247,31,84,154,242,121,162,180,189,235,164,161,83,149,18,134,225,139,130,91,0,119,54,100,223,56,152,193,87,130,125,15,168,216,98,172,121,108,193,180,59,53,156,227,13,141,238,175,95,183,62,71,227,36,21,35,241,80,193,235,232,188,220,224,163,43,52,252,231,139,23,253,107,168,3,134,207,97,48,190,201,165,172,99,109,219,45,250,44,176,158,68,188,149,198,79,138,12,245,8,230,200,96,114,244,48,28,221,73,7,215,179,201,185,233,175,30,10,67,60,114,18,76,32,163,47,49,229,236,57,115,193,31,67,169,123,19,209,208,151,222,8,6,159,24,164,241,213,151,125,18,217,252,108,77,67,111,93,241,249,90,239,189,200,120,5,13,107,249,184,75,237,24,120,111,97,239,166,126,214,26,105,226,136,4,19,247,5,14,83,33,245,123,51,12,231,124,36,111,65,153,67,103,234,195,174,185,58,233,120,130,6,157,76,99,175,145,152,133,128,211,140,3,198,186,15,215,104,194,218,159,174,25,184,155,145,215,143,2,26,7,80,30,22,249,116,200,235,214,164,186,94,209,116,246,133,91,34,227,251,205,3,206,193,72,8,124,61,89,211,175,142,195,56,171,69,173,77,30,5,230,66,94,32,149,107,235,174,165,246,91,179,227,36,108,90,70,171,97,34,149,9,107,58,60,2,122,37,117,14,139,132,59,124,201,39,161,226,201,171,212,56,136,11,237,168,225,67,229,181,80,124,199,205,241,214,83,191,230,136,21,144,141,239,104,76,142,53,126,217,212,231,0,56,221,122,212,116,193,77,81,9,104,112,217,91,139,78,98,53,173,93,77,64,172,181,33,109,125,129,15,89,120,173,47,101,144,133,220,64,125,147,251,163,200,191,161,148,188,43,139,205,154,104,24,252,167,129,185,142,121,56,109,94,251,49,60,144,102,67,168,166,241,192,77,71,106,158,85,235,122,84,178,243,204,155,92,201,57,71,223,244,218,109,240,217,57,94,202,187,200,211,47,16,169,83,47,201,180,104,109,207,48,117,21,179,158,147,92,202,223,197,76,172,21,120,29,68,126,223,120,232,100,201,132,234,75,39,8,190,48,30,183,226,95,164,254,12,217,219,196,229,145,169,14,124,249,58,112,251,173,249,181,150,142,203,208,152,230,57,193,73,101,113,130,96,239,149,149,169,133,16,171,235,123,38,113,19,11,185,44,190,183,109,231,181,94,28,181,124,153,11,176,190,85,58,252,57,80,222,134,255,253,47,202,154,66,227,1,96,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a4180509-1689-4ac3-9cf4-0c34bddf3a44"));
		}

		#endregion

	}

	#endregion

}


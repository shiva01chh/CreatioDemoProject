﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicationMergeHandlerSchema

	/// <exclude/>
	public class DeduplicationMergeHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicationMergeHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicationMergeHandlerSchema(DeduplicationMergeHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a1ec6de7-b322-46a3-a0da-77f95b1a84c4");
			Name = "DeduplicationMergeHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b5c46c08-cc76-4157-b24b-44267444e258");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,61,107,115,219,200,145,159,149,170,252,7,152,73,109,192,20,15,246,222,85,221,7,219,82,138,146,40,45,19,189,66,81,187,151,115,185,84,48,57,146,16,83,0,13,128,146,21,69,255,253,186,231,217,243,0,8,74,222,205,94,82,169,181,8,204,244,244,244,244,123,122,6,121,122,203,170,101,58,99,209,148,149,101,90,21,87,117,178,87,228,87,217,245,170,76,235,172,200,127,251,155,199,223,254,102,107,85,101,249,117,116,254,80,213,236,246,157,243,27,218,47,22,108,134,141,171,228,144,229,172,204,102,94,155,253,180,78,189,135,71,89,254,197,60,188,94,20,159,210,197,219,183,123,197,237,109,145,39,71,197,245,53,60,54,239,27,16,76,246,217,124,181,92,100,51,254,43,220,28,1,134,223,148,172,233,185,61,74,99,171,253,221,198,87,7,233,172,46,202,140,85,141,45,70,121,157,213,13,13,14,57,57,206,89,90,206,110,146,113,62,103,95,27,168,113,178,202,146,115,86,222,101,51,118,92,204,217,34,25,125,173,89,94,225,114,152,230,127,174,138,60,218,142,78,216,125,13,207,177,27,62,49,239,113,125,96,194,117,9,56,67,187,22,232,180,165,233,63,30,94,213,172,180,150,98,200,89,2,128,89,79,147,198,150,8,12,254,255,187,146,93,99,191,189,69,90,85,111,163,99,86,94,179,99,86,85,233,53,251,237,111,224,253,114,245,9,250,69,51,124,237,188,221,66,86,85,13,14,87,217,60,58,44,22,243,9,155,21,229,124,60,143,30,163,107,86,191,139,42,252,207,19,182,36,173,171,186,196,105,240,5,121,56,159,221,176,219,244,4,68,163,181,207,120,148,175,110,89,153,126,90,176,247,56,218,78,180,47,231,196,4,156,241,188,242,0,60,241,73,252,142,229,115,49,207,230,73,159,149,197,12,168,84,50,193,136,13,147,247,90,89,68,56,202,170,250,189,152,219,78,52,90,100,215,25,32,123,80,148,98,134,207,67,206,90,58,142,195,15,105,62,95,176,146,119,126,253,250,117,244,190,90,221,222,166,229,195,142,252,61,190,93,46,216,45,203,235,8,200,133,66,29,205,180,202,136,138,171,136,73,49,136,178,188,46,162,107,88,51,150,139,135,15,137,2,249,154,192,180,168,208,136,78,244,54,26,183,224,138,116,66,74,233,217,129,92,212,48,189,179,50,187,131,21,20,47,151,226,7,224,11,47,21,147,140,115,192,54,93,76,88,181,90,212,213,20,215,255,124,117,117,149,125,5,94,239,105,22,16,146,43,26,245,222,181,128,227,104,77,86,0,4,180,5,155,235,5,61,43,153,132,89,87,203,75,4,97,0,84,53,204,104,22,149,44,157,23,249,226,65,130,250,240,49,26,95,231,8,68,41,22,232,157,179,123,243,250,49,66,40,91,189,225,108,86,172,242,186,55,144,191,81,160,65,158,123,3,235,39,42,206,85,46,169,231,188,27,206,129,71,170,74,61,149,0,131,61,228,59,213,3,31,62,57,4,89,55,31,48,49,171,219,60,48,157,158,198,35,234,237,1,191,168,49,39,124,81,241,233,255,102,75,254,18,81,40,31,240,79,208,203,236,83,81,124,198,191,193,4,125,102,243,49,111,57,189,207,106,80,77,10,132,106,54,158,211,134,226,151,108,42,126,72,138,156,221,20,117,97,168,52,103,248,238,124,85,230,160,71,240,207,195,236,142,229,39,242,199,113,54,7,54,84,191,128,108,32,33,160,181,41,125,164,174,105,160,208,24,236,99,116,185,128,255,108,71,240,231,113,154,131,10,44,193,254,214,104,56,89,25,247,44,222,239,245,37,197,169,112,83,246,63,200,216,98,206,217,191,168,65,50,217,188,233,117,64,58,12,82,154,251,43,163,156,170,170,40,43,97,11,31,162,203,165,251,168,1,175,165,194,195,64,191,168,88,9,180,206,165,226,176,127,174,153,222,49,171,111,138,198,9,236,103,28,6,168,23,169,44,7,145,82,154,64,208,191,174,88,249,32,57,48,166,22,66,60,51,238,15,170,53,108,212,143,184,14,222,186,75,203,232,11,233,44,217,183,121,180,184,207,215,125,235,10,120,62,157,221,68,129,209,228,24,160,42,221,209,182,232,80,31,196,203,4,57,236,35,140,75,126,138,33,184,49,219,42,89,13,12,106,33,201,95,63,217,244,1,49,88,68,227,106,116,187,172,31,78,193,118,95,165,160,212,68,251,31,211,197,138,53,227,57,144,38,149,52,150,111,248,223,10,119,137,71,44,38,66,26,36,162,203,54,80,110,181,88,68,255,252,103,67,139,100,90,156,115,26,198,253,100,92,157,64,219,211,146,163,27,247,117,167,88,18,225,135,180,130,41,8,192,223,125,23,249,176,70,95,86,233,162,82,205,85,91,241,178,223,239,135,40,36,117,249,65,150,207,193,77,202,174,50,54,63,205,197,164,99,249,174,70,67,129,11,160,38,45,159,223,58,237,185,223,1,90,95,104,252,45,80,90,106,129,41,149,165,125,148,63,182,29,105,72,104,83,162,27,198,96,119,210,124,198,118,31,112,148,216,160,244,206,31,65,174,163,139,30,140,69,135,78,220,233,74,72,217,85,20,123,93,95,137,101,212,28,187,213,48,119,247,49,225,91,201,184,79,17,104,25,144,144,199,200,98,228,16,188,208,114,221,21,224,28,94,44,231,240,247,132,93,177,146,1,77,164,163,88,121,235,53,176,221,40,254,92,10,203,64,184,153,183,41,196,51,165,114,52,133,9,224,125,132,91,56,103,117,154,45,212,107,232,180,191,59,250,202,102,43,80,127,209,252,147,250,83,81,133,119,228,58,231,44,45,97,120,128,12,32,180,98,213,96,162,109,65,16,7,58,120,235,168,142,226,82,185,189,219,59,92,235,216,16,245,235,126,31,68,7,135,84,186,167,157,43,131,12,238,178,145,86,95,148,146,123,90,111,81,2,106,86,64,93,185,226,11,34,181,164,88,157,216,230,235,1,145,34,201,66,48,223,58,38,32,7,145,228,25,51,87,123,121,250,253,22,22,229,211,124,133,210,103,152,84,160,197,199,9,53,15,12,8,49,18,155,102,183,44,185,168,103,39,197,189,30,81,240,170,2,248,211,13,48,30,69,29,84,87,30,7,86,90,117,39,170,64,193,16,204,195,98,194,70,106,44,33,33,241,232,235,140,45,185,117,98,102,74,232,56,36,163,178,44,202,248,247,224,232,100,11,214,40,14,137,33,249,219,232,81,255,253,52,8,178,8,52,9,61,126,26,208,85,87,112,196,175,167,158,66,121,171,190,41,139,251,200,145,244,38,241,221,103,232,50,29,147,181,213,162,91,233,0,78,202,174,144,195,178,163,4,218,162,66,236,251,151,166,23,219,1,17,51,175,61,179,206,149,134,22,80,16,9,141,153,109,204,3,176,18,112,120,227,86,121,166,246,29,89,188,17,18,119,137,209,180,190,209,163,138,5,64,240,154,109,226,222,56,191,75,23,128,48,31,49,90,114,72,101,21,49,213,34,137,168,11,148,230,121,81,71,159,88,196,208,252,190,238,89,248,124,115,11,102,86,218,86,95,192,41,24,45,90,186,203,50,91,0,106,127,247,204,109,165,86,10,181,209,156,243,151,242,217,248,15,71,27,245,147,131,178,184,165,56,8,42,74,201,246,112,80,175,65,202,155,22,69,142,47,198,110,148,238,144,123,134,180,1,191,6,109,129,142,40,189,136,63,36,32,234,209,151,197,148,125,173,245,239,116,62,207,184,155,42,192,137,244,130,98,20,228,171,87,178,71,114,94,167,101,93,253,148,213,55,113,123,44,219,215,124,38,205,117,93,174,44,119,148,40,56,92,129,165,157,219,128,165,192,164,21,207,92,193,147,59,86,214,224,156,193,138,64,48,158,253,131,157,126,250,59,208,240,125,40,43,178,19,135,103,243,206,140,37,40,130,46,186,51,106,226,17,241,157,53,7,217,81,153,93,241,115,123,71,252,139,182,181,184,7,241,4,51,203,195,196,12,66,8,67,124,242,250,157,237,214,180,145,201,228,161,58,133,47,14,79,4,148,164,90,150,22,56,183,186,123,231,32,134,83,149,19,69,118,145,20,114,100,72,202,132,116,37,122,60,36,118,31,158,255,245,8,57,205,123,62,12,173,170,110,197,133,147,132,193,204,208,64,105,37,145,188,140,131,214,32,164,146,42,96,139,253,93,243,40,54,44,45,65,141,49,63,58,129,144,149,149,60,114,101,8,71,144,65,137,179,120,75,133,218,24,230,251,27,176,197,81,44,122,38,216,146,12,33,105,42,196,78,6,70,114,16,212,103,36,198,82,206,42,33,221,59,10,35,40,14,235,129,53,208,91,131,70,181,208,81,15,81,5,68,38,52,104,208,59,132,6,124,2,152,84,233,72,1,193,81,26,199,45,195,202,31,52,20,12,145,41,26,186,181,244,216,212,191,196,37,209,33,135,6,215,24,104,72,79,5,27,234,204,28,50,39,77,17,174,113,93,66,94,225,191,204,91,105,65,230,151,243,91,118,136,219,34,105,151,249,137,89,105,250,69,131,4,248,239,54,173,227,222,227,155,167,199,239,159,122,3,139,218,141,105,93,26,47,188,250,17,93,33,157,225,151,220,220,48,48,225,90,193,44,118,24,32,177,158,81,31,197,71,148,231,24,61,55,103,51,15,165,9,63,21,66,9,127,197,32,210,239,224,162,184,62,74,223,182,80,158,16,76,24,26,108,202,242,135,101,177,90,78,139,179,162,2,236,238,88,72,2,50,88,232,107,108,6,12,98,103,77,126,222,181,126,193,82,211,149,150,204,12,147,40,113,246,149,80,54,211,226,132,93,167,56,101,192,86,206,46,250,99,244,31,223,27,187,217,37,18,110,95,84,30,174,246,14,5,244,94,32,70,85,100,117,152,64,119,193,60,26,79,132,197,94,215,240,100,148,4,59,145,105,208,99,37,106,209,227,136,142,124,176,33,85,255,255,177,205,207,32,225,47,95,220,160,208,135,194,145,32,21,228,34,48,103,151,213,201,2,119,8,4,49,13,229,68,130,62,80,153,109,108,143,152,68,41,130,116,40,173,240,84,44,252,32,106,204,109,211,96,72,102,229,183,157,4,167,156,209,85,186,168,152,107,223,100,132,96,197,160,10,103,147,151,78,4,123,110,71,161,230,9,165,94,83,80,69,198,218,3,139,94,251,249,216,230,209,156,14,207,28,111,183,243,236,156,14,155,142,231,102,38,215,15,232,246,120,238,136,221,167,232,246,232,60,162,3,174,39,55,215,208,73,196,162,155,170,183,14,136,199,140,142,80,8,59,19,137,53,16,1,54,86,145,152,61,189,105,129,245,20,210,28,73,89,22,217,103,43,147,160,92,58,146,34,165,14,207,135,143,81,122,125,93,114,197,82,228,118,34,253,90,213,107,48,204,163,7,29,96,253,218,218,102,51,104,12,23,25,15,227,127,223,123,52,15,159,38,69,81,11,17,150,219,42,34,24,197,36,214,98,53,103,166,78,228,188,107,196,170,163,80,185,140,188,126,32,230,210,175,91,112,213,108,176,232,39,195,138,254,20,152,52,163,0,10,74,252,141,185,149,161,71,51,24,81,132,74,85,220,0,99,16,164,180,67,171,118,52,208,111,215,3,53,141,147,156,23,171,114,198,70,95,151,184,23,207,189,125,132,60,104,102,133,173,163,226,26,150,115,113,186,100,178,140,107,152,207,91,172,146,197,24,202,24,73,66,169,65,198,185,162,17,155,119,73,57,76,139,101,252,189,155,82,64,227,72,243,7,235,86,175,97,240,238,75,23,2,176,201,186,181,111,23,129,152,136,217,108,135,36,232,165,123,69,206,2,84,224,60,93,80,207,181,75,198,39,52,127,78,234,238,75,33,200,97,229,94,125,198,179,55,87,80,125,200,14,192,120,113,63,57,41,96,86,224,215,192,236,26,197,169,31,129,102,17,127,134,55,186,72,40,7,97,178,191,134,68,67,187,20,75,184,107,182,251,224,78,107,64,128,90,33,242,51,246,233,60,230,149,139,213,37,218,32,125,73,128,17,144,239,64,164,17,146,221,142,155,111,223,108,239,237,137,198,38,210,27,22,142,176,97,65,179,26,90,184,185,197,20,189,66,38,83,10,64,119,105,151,29,42,169,158,91,45,162,103,97,5,159,75,210,60,155,247,100,57,139,68,9,107,209,228,95,58,79,105,169,252,160,162,150,41,0,221,87,25,60,104,149,239,46,138,217,231,184,106,55,12,132,169,85,170,77,43,255,54,9,208,141,79,203,152,252,120,193,176,91,178,94,36,38,79,80,37,180,97,225,117,73,246,22,69,197,4,10,198,63,32,207,2,126,88,101,20,137,195,85,34,208,147,142,152,113,191,100,252,183,145,227,213,209,133,250,87,26,17,57,219,14,161,110,131,49,216,88,241,163,26,23,35,88,98,62,55,143,156,5,137,237,45,142,15,31,251,17,76,172,226,105,223,221,98,254,160,214,164,148,191,169,103,138,207,206,97,240,90,56,6,170,73,194,159,197,127,120,247,7,178,93,130,47,105,189,148,108,175,186,127,120,243,209,180,245,37,220,109,253,253,71,53,200,224,15,182,66,139,221,129,66,14,135,142,237,221,66,68,169,178,64,233,225,252,101,107,69,2,157,14,215,92,201,200,56,150,6,139,67,83,30,68,225,201,245,97,118,54,205,245,72,148,128,60,255,1,77,125,0,232,160,3,3,240,28,52,150,142,186,3,63,217,36,18,144,36,83,101,53,187,69,182,230,255,190,218,14,76,9,120,122,88,150,233,67,220,64,53,158,240,226,59,0,251,164,92,167,218,125,192,9,52,211,142,10,185,29,32,181,199,71,188,200,65,200,69,112,111,203,206,106,156,46,151,152,131,53,181,31,227,252,170,32,251,5,34,114,213,111,43,154,248,208,56,63,103,27,88,205,210,195,93,85,243,153,188,220,159,139,12,188,243,222,32,208,216,208,222,218,208,181,135,86,30,169,253,212,115,115,92,166,218,114,192,36,56,63,163,212,122,135,188,88,93,161,2,232,209,5,234,8,67,107,120,92,206,224,12,21,57,154,0,54,87,1,53,165,21,145,173,94,86,121,225,57,147,200,13,14,36,158,97,59,0,43,6,72,142,114,76,74,206,227,222,1,171,103,55,2,58,106,242,99,128,3,238,85,10,190,151,83,177,108,213,134,9,235,123,145,97,221,155,199,144,90,247,19,254,69,121,181,30,36,98,204,11,180,80,219,22,9,18,120,166,44,249,119,223,57,189,132,148,99,47,85,189,168,236,187,180,123,95,113,164,175,166,157,34,189,118,208,44,244,77,225,46,206,197,108,16,97,35,102,171,126,11,69,165,197,208,177,223,125,128,97,98,13,69,239,109,226,10,216,48,220,122,75,244,216,234,44,55,27,156,79,13,195,171,44,10,125,150,144,237,85,82,144,169,45,151,49,67,142,105,32,122,205,215,156,10,10,215,25,82,31,18,104,3,75,7,182,161,51,176,244,155,165,40,213,236,125,201,178,43,243,158,34,182,168,152,162,214,55,182,79,214,12,219,227,251,65,96,216,117,147,107,156,91,227,142,28,197,103,179,64,36,104,219,73,118,167,193,230,108,106,193,20,223,186,97,106,199,12,101,19,227,16,68,67,179,181,17,108,36,43,178,193,223,171,34,15,214,68,72,33,8,190,11,107,206,87,210,206,217,197,235,205,3,24,237,56,92,46,23,15,194,171,8,143,39,232,54,104,193,214,10,79,92,127,188,33,12,105,165,110,51,217,214,213,173,110,86,249,70,38,49,6,223,76,120,165,225,57,42,39,171,133,10,146,162,164,10,77,58,131,93,203,206,40,38,59,109,139,215,86,237,133,110,138,11,77,57,254,33,89,150,243,106,100,55,79,122,173,232,132,213,198,199,226,60,247,156,226,173,96,38,245,5,197,89,86,68,103,151,132,53,102,136,201,252,188,60,221,175,174,204,11,37,190,169,198,75,44,201,203,42,177,154,203,149,130,106,6,222,245,163,63,89,108,16,189,69,222,72,166,101,118,219,178,203,43,87,163,138,133,20,128,109,4,44,79,115,80,0,244,193,244,190,112,170,55,224,31,104,5,211,84,29,248,138,241,119,239,156,118,208,89,181,195,63,157,118,124,43,78,0,115,15,151,104,208,219,114,56,58,25,186,147,39,198,8,118,23,131,139,22,129,238,146,166,98,174,234,216,144,161,129,158,124,11,253,196,234,142,115,113,208,145,231,69,44,219,106,153,91,146,130,178,183,204,157,99,159,166,214,212,0,233,227,150,164,125,156,210,52,115,115,204,33,119,129,219,25,115,60,128,215,24,196,129,50,80,122,88,134,184,224,162,131,158,202,213,103,93,164,96,237,14,194,139,61,111,150,66,92,44,64,26,247,191,176,135,152,0,227,211,124,229,52,254,64,26,124,52,179,182,134,34,185,249,150,190,88,197,102,117,83,154,156,58,142,109,16,164,58,165,68,138,97,104,107,218,209,211,26,207,77,152,100,161,49,217,45,68,4,120,240,77,184,139,242,248,180,248,97,107,250,138,39,69,49,2,134,144,206,87,123,63,21,229,103,126,21,4,168,36,171,169,37,145,115,86,205,202,108,73,234,8,143,138,25,26,66,94,12,35,142,224,57,67,13,162,94,227,57,108,121,94,118,171,231,65,169,18,81,48,41,79,247,239,155,113,197,65,60,165,236,148,166,88,113,33,220,75,127,121,212,228,152,54,90,231,15,21,210,151,71,162,179,85,9,236,80,227,111,159,236,123,230,165,204,135,202,13,12,88,49,92,90,254,231,54,133,193,141,130,248,169,218,198,86,14,76,114,196,203,226,251,158,230,172,94,8,56,55,81,214,64,178,120,67,64,119,29,5,149,91,147,61,112,67,103,159,93,17,211,86,197,161,54,164,1,216,188,85,125,83,136,51,215,148,26,242,248,181,14,188,155,1,136,93,1,14,64,79,78,28,251,79,244,111,209,70,13,181,22,164,30,252,217,72,77,244,42,247,6,100,201,215,246,35,2,129,57,35,243,107,61,25,44,81,233,13,156,210,55,91,146,6,150,66,73,212,82,139,151,253,174,99,233,212,152,6,100,213,49,137,147,181,107,97,61,84,148,117,125,152,38,155,179,22,214,73,81,103,87,82,232,167,15,203,48,83,184,141,232,239,208,24,233,93,91,185,163,136,211,72,233,180,101,36,42,212,20,161,210,199,14,22,22,51,213,84,213,187,165,112,214,189,20,102,224,30,137,62,131,229,122,94,73,93,75,181,98,160,116,174,155,230,233,82,202,103,244,15,171,190,72,221,78,97,241,173,38,89,146,165,202,89,170,47,104,172,135,139,5,173,220,211,90,6,95,31,100,11,8,28,42,110,211,241,183,208,95,226,169,149,162,173,98,241,16,175,105,72,203,172,18,220,32,252,61,176,32,194,253,227,81,138,85,169,45,135,210,105,28,149,78,103,238,131,109,156,22,170,96,183,105,88,139,58,183,3,72,120,152,88,116,33,187,137,118,226,136,232,220,30,142,139,211,153,7,227,12,221,94,199,22,161,170,245,46,144,140,123,227,128,130,160,125,166,51,135,6,172,183,65,230,237,120,203,217,16,191,41,112,41,194,86,208,109,21,50,51,176,188,80,31,158,147,28,12,8,246,38,187,40,122,125,237,230,149,56,95,65,121,30,115,186,27,151,196,98,13,66,24,143,42,118,128,75,199,198,47,108,189,64,119,134,243,54,191,199,11,185,219,59,127,93,174,194,49,194,90,61,133,220,129,244,53,120,237,62,128,201,97,217,117,14,62,124,203,177,52,107,99,175,225,236,153,53,84,108,73,158,117,218,244,155,157,51,21,72,169,153,136,116,95,120,121,165,112,160,85,82,59,7,170,214,231,171,218,43,127,164,27,8,3,248,65,148,247,83,212,176,227,112,144,149,184,139,238,106,5,11,51,113,184,216,221,184,11,235,3,221,142,140,78,54,212,244,235,209,139,40,73,99,53,9,221,10,239,164,45,31,87,251,187,63,102,236,222,8,178,179,117,241,20,154,137,85,3,229,130,84,81,47,224,36,118,80,204,132,205,230,77,195,38,199,203,181,136,149,49,16,61,27,93,133,115,150,207,49,193,52,45,240,46,183,50,199,123,224,248,21,108,246,253,51,150,210,232,152,75,23,217,91,227,13,196,54,140,198,188,173,232,199,239,161,51,121,134,142,157,155,15,127,184,240,94,58,59,238,203,116,217,132,164,183,235,93,254,248,159,189,117,7,49,50,121,1,223,238,42,91,136,100,31,191,13,77,222,97,132,99,188,87,119,244,77,216,23,8,103,48,52,75,101,107,173,144,2,77,128,21,244,223,239,188,225,144,17,218,71,147,20,227,237,156,163,183,249,92,142,51,172,30,242,25,0,233,68,25,177,48,163,115,62,192,57,116,188,41,139,188,88,85,139,7,59,14,92,208,93,19,126,61,212,89,138,119,98,161,59,67,169,43,69,171,206,22,85,210,244,92,169,8,8,195,26,193,146,124,159,51,51,178,116,134,172,219,238,146,37,252,95,244,20,51,54,39,11,224,149,0,40,202,234,138,55,110,16,5,89,154,55,219,6,246,245,2,114,23,175,121,58,90,247,89,43,157,224,63,246,210,198,100,86,3,111,85,27,242,79,93,233,32,102,245,239,70,13,101,174,64,203,222,140,115,128,127,151,46,80,134,188,91,61,19,8,41,33,50,172,121,78,7,164,65,4,135,46,9,122,35,16,190,58,155,77,108,136,224,236,127,175,6,148,23,154,78,111,48,109,143,177,160,248,43,57,95,48,182,140,93,84,254,24,125,255,230,205,155,117,219,179,74,16,157,75,37,213,85,39,237,181,63,17,201,6,138,167,27,171,200,54,69,176,70,91,210,45,84,60,141,167,127,6,67,4,62,9,81,141,107,20,140,57,99,60,158,211,156,169,104,28,180,0,246,176,79,4,214,102,165,133,61,143,230,238,142,148,186,222,83,148,15,187,91,81,85,76,145,239,123,229,134,93,206,208,17,14,32,182,250,23,51,143,187,171,197,103,160,66,67,61,78,67,81,145,201,48,96,249,198,13,155,125,110,48,93,251,161,150,59,242,242,55,92,35,158,127,41,87,216,101,88,94,175,240,234,208,184,183,178,240,238,185,161,73,127,176,166,191,141,223,132,113,255,188,224,87,66,174,67,209,52,6,19,43,121,129,236,221,7,103,46,8,187,111,8,200,47,66,192,243,5,150,215,196,227,2,171,210,105,110,246,68,57,3,136,12,65,11,138,170,149,244,185,21,33,159,79,73,115,194,219,195,68,106,254,56,160,222,59,20,230,181,151,162,140,111,49,153,46,118,143,61,245,21,186,72,240,62,3,148,75,210,77,92,33,209,20,221,58,199,54,221,76,217,179,19,229,160,252,57,14,84,125,9,192,252,177,123,243,208,250,52,57,233,156,240,106,57,84,75,251,187,113,120,190,9,205,158,242,187,49,216,61,111,195,21,39,170,132,228,132,221,227,191,212,61,156,45,138,220,68,114,116,196,61,124,19,115,173,37,222,139,78,164,131,151,77,229,217,83,51,44,245,66,211,59,54,81,177,187,5,194,36,75,133,83,167,27,106,97,32,102,195,25,112,214,80,0,230,161,16,98,56,185,241,186,134,219,214,237,184,82,228,172,147,185,4,174,218,83,22,211,249,238,187,78,157,244,1,79,51,180,50,16,129,146,226,179,162,170,229,54,84,76,47,195,22,133,172,242,7,229,248,91,249,62,112,151,210,185,93,210,18,91,32,4,61,143,171,235,189,155,20,184,112,129,142,187,216,107,38,40,128,188,47,22,49,77,54,107,183,81,90,59,100,148,91,10,178,97,90,165,186,59,54,148,18,215,117,100,170,242,182,225,170,148,53,215,188,137,43,166,152,185,145,22,136,226,223,79,139,18,111,208,129,231,126,46,200,2,130,219,40,163,116,118,19,235,71,152,173,145,44,173,159,37,106,122,20,91,123,74,94,105,212,83,43,197,96,21,126,85,36,51,248,252,58,104,134,255,116,184,29,216,186,253,216,92,66,76,118,112,90,42,237,172,66,69,173,67,214,87,156,241,146,82,180,148,50,100,107,46,98,91,91,83,22,168,58,22,198,18,15,133,169,33,66,199,235,72,219,68,213,156,122,69,86,51,207,236,4,21,173,69,53,113,234,65,47,25,238,172,152,131,149,173,134,94,101,206,231,252,190,119,190,222,2,237,150,139,202,112,131,127,113,135,1,70,126,5,157,106,255,188,156,33,12,210,196,87,201,238,121,57,180,78,193,58,29,191,171,144,181,153,209,227,253,117,233,75,145,250,116,80,166,151,8,120,47,173,194,151,240,80,19,209,71,117,137,41,113,9,45,125,216,10,119,93,71,22,70,250,32,91,44,136,237,29,95,137,42,178,166,97,44,152,141,46,96,3,208,103,241,71,39,223,79,104,14,234,79,90,145,42,238,75,122,46,103,131,231,65,235,120,219,174,201,158,73,185,242,134,110,139,173,44,198,213,83,21,247,112,169,121,7,142,74,168,41,233,70,207,153,81,247,41,205,66,147,145,178,67,93,45,186,144,97,238,221,242,130,1,191,143,188,43,206,225,214,173,79,64,169,207,234,151,58,218,176,185,27,233,107,57,5,147,14,16,218,21,212,138,47,43,235,85,186,80,55,95,217,226,248,179,171,188,14,119,214,112,223,92,150,195,200,196,8,143,16,60,88,214,69,242,212,177,231,157,41,127,137,179,41,167,37,143,88,98,242,216,118,117,149,109,81,163,211,24,64,192,244,43,49,93,158,22,13,159,205,208,155,114,228,179,25,50,116,235,219,183,99,199,14,172,199,61,22,233,149,145,253,224,111,83,102,114,165,190,111,20,72,79,64,28,240,126,44,11,20,213,176,242,181,181,75,113,229,226,6,176,52,92,181,223,41,27,161,79,120,101,134,160,243,241,138,46,60,184,218,197,116,223,16,168,250,153,110,172,116,50,105,251,168,215,86,53,230,107,242,39,221,231,78,48,233,78,184,96,86,237,25,154,238,96,199,101,169,176,115,79,184,251,165,1,119,133,187,236,184,119,171,50,10,238,180,175,221,175,119,93,250,78,5,78,132,229,36,71,145,206,1,78,109,106,223,178,145,26,148,4,252,70,138,237,136,118,187,51,60,148,91,231,193,20,168,76,125,206,51,228,98,106,5,232,220,153,233,95,153,41,54,252,42,8,193,165,38,30,243,31,77,215,14,141,243,186,32,135,70,171,31,178,138,167,49,173,11,241,123,225,75,255,236,108,80,223,238,114,106,178,231,161,190,100,66,78,199,19,67,138,80,71,74,41,187,163,176,12,166,198,40,208,153,138,54,166,164,4,109,244,118,17,254,104,187,130,210,253,28,21,127,112,198,74,88,170,219,40,197,47,145,145,124,43,26,222,84,124,200,78,247,125,237,118,126,207,47,64,231,23,208,110,247,104,249,97,111,231,144,126,185,234,253,107,222,112,167,133,39,37,30,77,31,68,171,218,74,186,131,37,224,86,67,163,100,235,135,37,90,77,252,167,184,138,27,63,192,70,122,220,171,90,112,220,172,129,160,248,46,107,218,134,254,41,212,210,82,241,146,162,208,59,8,85,109,9,85,177,189,201,178,68,21,138,40,39,227,106,88,85,160,117,144,77,248,6,205,146,23,249,47,225,5,199,199,92,72,195,173,69,141,29,91,102,137,255,64,216,81,148,50,19,171,210,185,113,221,148,8,215,114,221,252,149,59,49,73,30,100,139,233,106,233,78,101,46,89,242,104,96,137,40,191,54,101,40,72,30,31,211,20,92,20,91,56,156,52,79,58,178,178,179,41,176,163,200,130,31,104,123,95,49,22,205,192,100,109,247,248,38,170,77,166,222,235,29,139,217,197,215,217,26,235,234,29,189,22,217,3,235,51,159,118,163,109,167,153,160,156,159,122,90,179,223,20,254,42,213,139,183,158,54,76,50,173,91,61,64,58,244,133,188,135,8,24,81,36,118,187,46,170,209,158,189,29,185,203,129,47,18,186,94,94,167,108,94,245,118,246,66,227,131,188,230,88,2,141,85,179,173,32,100,21,102,111,7,135,174,16,130,42,241,172,11,126,180,205,239,46,12,122,21,28,24,90,171,215,132,195,188,160,73,151,224,237,235,224,99,141,117,207,208,156,91,95,247,49,165,168,52,6,121,110,117,179,212,76,29,235,9,59,23,55,155,235,32,43,239,140,255,154,194,103,187,82,4,27,203,184,140,124,229,12,53,238,226,62,197,218,8,121,2,212,92,37,41,50,2,51,247,0,89,79,223,20,74,246,137,21,46,50,106,162,109,236,152,168,253,46,43,175,164,215,6,75,182,104,252,200,252,27,22,122,27,138,153,203,36,3,215,177,14,144,169,146,189,20,120,170,224,251,40,184,101,252,115,149,130,187,253,147,211,18,207,156,18,74,15,34,254,104,63,43,213,61,236,213,140,113,111,193,118,164,93,72,84,163,5,149,148,190,225,183,50,190,173,254,146,231,207,170,159,124,87,218,85,87,68,79,225,207,0,126,173,3,120,73,16,132,207,191,144,128,10,88,188,21,108,170,114,178,141,218,76,18,9,241,146,55,10,5,85,153,162,37,141,78,170,37,152,34,22,120,181,121,196,178,121,10,73,9,91,11,98,165,250,67,168,172,230,150,45,229,216,47,219,121,247,148,104,23,249,10,26,9,66,201,198,10,216,128,51,78,47,72,81,18,200,171,178,117,170,148,110,113,219,61,195,55,69,43,162,210,4,176,55,4,56,252,197,29,147,229,223,162,165,101,195,204,106,106,91,230,29,57,53,104,53,110,63,16,220,92,120,254,174,4,166,4,156,139,221,158,124,204,148,196,172,199,172,219,39,48,131,103,211,54,217,191,113,59,63,111,7,199,191,73,220,46,206,146,105,193,205,54,131,28,11,187,9,78,188,196,33,171,246,44,106,243,204,154,190,135,220,200,138,206,171,54,109,136,104,26,61,39,223,250,140,195,74,1,212,236,244,47,123,62,58,156,198,188,180,30,12,187,169,97,16,91,78,214,157,8,30,53,212,134,167,217,168,8,17,140,96,170,183,37,154,46,93,234,140,75,96,219,117,253,149,78,130,239,229,165,4,13,179,9,37,151,81,53,113,70,33,99,4,120,137,184,132,225,141,23,194,212,110,119,139,127,169,66,224,46,26,229,244,128,71,39,156,95,167,91,254,64,238,208,8,0,157,164,249,53,115,133,171,239,138,130,249,142,175,82,133,207,177,23,3,87,205,169,113,90,12,176,152,243,113,186,20,35,90,159,28,54,110,134,163,225,20,88,96,33,84,19,101,138,151,80,4,230,130,213,61,244,155,224,146,246,124,16,60,96,146,87,178,16,212,115,58,103,238,206,48,96,168,134,85,166,42,217,35,212,242,70,163,166,32,100,227,218,92,76,89,154,45,190,230,33,82,228,24,63,230,234,59,31,240,183,188,169,57,186,42,139,91,149,186,94,128,114,255,133,66,101,249,157,145,222,206,88,123,156,232,112,214,55,76,34,13,63,42,126,220,65,34,103,187,138,210,251,227,201,192,145,152,201,75,62,135,162,8,35,191,242,241,111,244,29,148,95,224,123,56,14,241,158,243,93,28,253,73,29,129,126,219,135,112,130,252,206,179,83,161,204,15,74,45,44,112,33,205,177,50,128,191,98,206,110,200,148,235,109,2,59,87,46,111,46,38,113,219,75,35,64,9,119,149,103,95,176,246,169,107,222,234,101,145,159,18,103,154,227,231,107,218,37,43,69,100,122,237,6,212,115,34,57,247,80,69,117,84,92,139,123,50,237,43,86,7,81,240,10,82,146,166,42,244,81,160,226,51,203,13,152,223,247,30,205,132,158,46,31,229,108,224,47,123,219,233,73,94,60,192,63,66,204,119,5,161,103,16,232,83,18,157,79,135,147,105,116,60,154,28,142,162,253,139,179,163,241,222,112,58,58,127,27,61,134,230,242,148,168,204,210,207,249,213,116,47,236,244,29,8,131,220,75,34,206,134,144,211,0,111,8,54,215,71,155,221,104,63,58,217,15,80,94,74,174,18,217,138,67,78,204,221,99,161,162,7,130,114,32,120,13,28,32,147,205,236,24,173,241,206,16,231,20,70,232,203,198,47,153,177,73,105,128,224,35,228,248,62,171,111,138,85,173,244,177,160,69,255,109,244,102,13,29,90,4,119,238,124,166,85,48,142,255,241,86,143,249,54,189,130,75,93,208,218,190,61,79,143,210,81,161,209,231,218,215,31,121,247,174,99,249,150,247,240,109,153,158,176,220,96,253,196,181,57,184,40,219,209,127,253,247,155,55,239,54,89,119,174,101,46,167,147,225,201,249,112,111,58,62,61,33,235,72,6,226,87,92,79,203,52,175,82,235,83,153,91,91,180,96,157,136,246,26,246,13,71,15,254,45,206,118,101,1,255,118,186,117,176,95,46,33,9,216,164,129,169,137,99,199,255,198,60,141,142,218,186,145,102,239,135,209,241,240,242,100,120,60,2,173,75,20,252,32,154,140,14,146,233,112,247,104,164,222,210,175,195,227,203,189,211,163,139,227,19,212,214,190,137,17,232,8,41,38,159,128,223,242,46,137,117,179,16,62,25,117,95,162,245,149,82,112,228,199,170,158,173,125,247,147,208,78,223,223,171,175,98,54,96,62,232,174,31,223,153,142,27,176,26,87,50,151,251,163,233,112,124,116,57,25,237,157,78,246,207,47,119,255,118,57,185,56,26,69,248,159,183,143,122,252,167,136,19,249,45,33,111,116,120,122,180,127,57,222,127,251,72,41,69,201,40,171,214,66,183,205,147,235,152,107,115,111,193,186,107,111,7,6,242,22,189,212,55,168,28,250,155,82,5,20,239,47,64,19,123,243,107,195,37,187,56,219,7,115,0,136,29,140,38,163,147,189,209,190,194,241,121,203,35,162,24,163,133,85,57,18,89,18,34,34,207,93,159,103,45,196,183,157,169,202,71,185,215,221,110,70,253,241,201,201,104,114,57,57,61,58,218,29,238,253,165,65,85,91,202,122,2,238,216,167,116,246,57,168,175,55,160,70,199,145,235,155,178,184,215,63,157,239,70,111,89,199,115,126,6,3,97,105,190,205,245,144,118,118,46,127,26,79,127,184,228,139,42,214,156,206,177,253,36,7,157,202,192,58,82,228,199,36,155,153,32,162,28,186,33,186,1,1,246,71,71,35,224,245,227,225,249,20,87,89,240,57,133,37,63,222,157,86,16,225,235,146,193,53,249,191,144,252,117,158,233,90,140,54,152,221,57,7,56,156,14,47,167,167,151,163,255,1,128,39,195,35,120,58,249,113,188,55,178,128,182,92,57,211,237,146,151,141,230,216,29,175,77,38,59,252,113,36,56,98,116,50,29,79,255,70,193,216,123,61,228,236,233,70,88,55,15,224,233,182,13,240,94,167,90,58,235,180,206,19,89,55,98,135,111,117,83,29,38,211,94,198,13,163,170,80,105,192,13,8,178,119,122,124,60,182,220,113,240,32,195,93,130,110,58,198,3,89,216,79,239,76,162,231,224,32,167,186,185,246,57,31,13,39,123,63,128,172,159,95,28,77,47,15,39,167,23,103,102,57,26,63,147,221,188,4,107,174,14,9,169,172,64,93,226,198,42,171,117,26,27,27,37,46,99,99,208,244,7,147,211,99,27,182,75,28,113,29,175,218,114,192,26,81,74,174,142,201,150,13,77,81,39,244,54,152,244,217,104,114,112,58,57,190,28,30,160,218,223,31,41,83,7,156,119,41,24,144,232,197,181,149,195,161,229,20,199,191,201,25,241,109,243,173,1,117,134,220,4,66,135,27,133,96,202,251,116,56,110,204,63,215,211,236,172,210,244,129,218,127,208,63,164,80,169,41,147,147,238,129,147,233,221,151,111,35,66,119,253,168,17,180,9,84,228,111,152,125,18,140,112,116,122,232,123,59,190,27,208,114,160,97,141,119,210,49,167,214,157,162,221,48,222,68,59,26,56,50,29,119,126,177,7,142,193,249,193,197,209,145,49,187,202,232,198,163,175,51,38,238,253,54,155,214,124,156,81,89,22,101,219,64,7,16,107,118,207,46,71,143,204,104,123,110,229,68,181,166,26,30,70,58,128,112,91,72,25,113,129,155,1,234,251,17,162,26,17,107,180,49,73,15,34,237,53,245,226,242,153,83,127,172,43,200,177,44,250,109,228,124,89,132,55,249,160,110,126,64,102,254,8,15,228,70,198,12,187,248,61,182,56,133,63,232,251,35,32,174,1,156,235,135,88,150,253,246,250,31,201,110,136,204,166,200,186,129,199,232,154,213,239,162,10,255,243,212,4,230,78,92,164,78,161,136,82,202,72,84,89,184,64,252,121,195,19,250,191,255,3,233,196,72,44,230,160,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateMergedMessageDescriptionLocalizableString());
			LocalizableStrings.Add(CreateMergedMessageCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateMergedMessageDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b2492680-5abd-40a7-af5e-4230a8d5a802"),
				Name = "MergedMessageDescription",
				CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31"),
				CreatedInSchemaUId = new Guid("a1ec6de7-b322-46a3-a0da-77f95b1a84c4"),
				ModifiedInSchemaUId = new Guid("a1ec6de7-b322-46a3-a0da-77f95b1a84c4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMergedMessageCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2b6d4c7e-1753-4854-8165-632495c7ba4b"),
				Name = "MergedMessageCaption",
				CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31"),
				CreatedInSchemaUId = new Guid("a1ec6de7-b322-46a3-a0da-77f95b1a84c4"),
				ModifiedInSchemaUId = new Guid("a1ec6de7-b322-46a3-a0da-77f95b1a84c4")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1ec6de7-b322-46a3-a0da-77f95b1a84c4"));
		}

		#endregion

	}

	#endregion

}


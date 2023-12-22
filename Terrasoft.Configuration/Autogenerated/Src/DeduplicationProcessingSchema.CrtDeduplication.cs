﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicationProcessingSchema

	/// <exclude/>
	public class DeduplicationProcessingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicationProcessingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicationProcessingSchema(DeduplicationProcessingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d04fa5da-95dd-4b84-8e61-36d15f0bbcfb");
			Name = "DeduplicationProcessing";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2bccf296-28ac-4fb9-9305-bd0b56b97b98");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,60,93,111,219,56,182,207,94,96,255,131,198,187,15,50,214,171,182,251,114,129,105,236,65,154,184,29,207,78,155,110,156,185,179,192,96,48,80,44,198,209,142,44,185,164,148,198,183,200,127,223,67,30,146,226,167,236,36,29,224,230,197,177,116,120,120,120,190,207,33,233,58,223,18,182,203,215,36,185,34,148,230,172,185,105,179,179,166,190,41,55,29,205,219,178,169,255,252,167,47,127,254,211,168,99,101,189,73,86,123,214,146,237,107,231,59,192,87,21,89,115,96,150,189,35,53,161,229,122,16,230,226,250,63,240,239,251,166,32,149,7,119,158,183,185,247,240,199,178,254,228,61,188,236,234,182,220,146,108,5,243,229,85,249,127,130,90,15,234,223,91,99,14,115,137,219,173,9,29,89,124,118,89,110,110,91,6,83,220,149,107,18,6,167,209,231,217,249,155,232,171,5,16,223,150,132,69,1,222,230,235,182,161,67,16,171,245,45,41,186,138,208,16,196,135,174,204,36,217,130,209,217,226,190,37,53,227,252,63,188,234,21,201,233,250,246,188,219,85,229,58,111,137,191,126,65,253,190,151,105,50,27,154,154,203,20,38,104,41,44,41,115,135,2,82,64,251,23,74,54,28,207,89,149,51,246,173,194,95,149,164,110,123,50,222,209,166,219,9,240,23,47,94,36,39,172,219,110,115,186,159,203,239,226,109,210,220,36,133,30,144,41,208,23,6,236,47,38,57,191,194,131,93,119,13,240,201,154,79,61,60,243,232,139,152,221,155,94,60,88,22,48,164,188,41,9,229,68,108,248,136,76,3,155,4,32,5,239,201,246,154,208,244,3,216,31,112,111,44,224,151,197,120,194,41,82,36,149,117,139,203,90,22,9,183,194,209,104,67,218,215,226,31,38,255,121,24,160,200,144,143,205,147,35,105,162,205,103,102,19,228,201,253,18,64,6,72,147,228,253,133,212,5,10,56,36,108,135,205,151,224,143,64,75,73,84,208,92,118,121,89,51,228,49,123,182,200,163,243,15,138,219,96,130,18,247,99,120,139,3,108,238,246,40,79,6,212,112,142,42,49,196,246,1,162,13,51,231,116,175,155,170,219,214,143,84,10,196,98,211,126,94,10,194,97,228,9,107,41,248,136,105,210,8,55,63,231,58,130,35,158,66,241,7,114,223,38,172,205,105,155,236,26,86,62,153,223,53,224,185,184,185,129,41,125,19,251,160,223,61,133,194,171,166,205,43,96,36,132,163,132,146,117,67,11,6,88,147,188,170,30,79,101,203,113,157,113,84,151,136,201,39,246,202,5,121,162,30,128,148,58,30,97,34,212,41,177,134,109,35,157,200,89,13,214,205,146,191,191,50,38,126,156,229,191,39,116,67,14,90,190,128,2,38,35,216,179,76,221,153,112,208,212,1,172,171,218,71,136,145,117,235,53,97,142,240,174,155,166,74,86,248,230,41,50,123,15,227,242,13,121,4,25,91,28,97,147,129,214,169,176,61,213,137,0,166,246,49,138,189,86,99,14,196,19,141,251,217,65,133,168,152,0,15,63,210,134,115,29,214,29,85,173,229,118,87,145,45,120,219,228,154,167,56,92,70,85,179,1,18,111,243,186,168,56,199,14,196,24,91,207,98,179,43,61,83,212,174,132,21,126,155,44,235,150,208,58,175,98,111,193,241,229,21,234,225,18,210,218,1,233,124,4,243,128,101,176,4,28,117,114,67,155,109,79,56,183,28,64,16,147,91,41,105,72,208,53,132,102,29,41,250,253,185,3,57,80,123,75,140,60,40,48,99,60,207,233,5,175,37,175,116,50,50,245,79,117,249,169,35,73,233,81,128,62,249,16,9,239,186,178,72,208,163,30,67,132,252,112,116,208,255,110,43,101,88,202,86,206,27,202,118,195,130,142,228,187,67,130,53,83,92,63,185,253,255,43,219,120,34,59,48,177,85,102,121,101,135,17,10,190,190,180,121,116,205,193,6,191,5,107,44,239,96,14,124,191,195,47,144,43,192,251,158,49,236,35,161,151,4,148,151,241,32,250,63,175,195,160,60,211,182,0,95,189,124,249,50,0,43,253,187,101,188,236,42,191,174,200,170,187,185,41,239,185,55,214,107,199,66,15,129,198,113,100,202,46,206,68,182,200,125,250,199,188,229,58,197,145,125,121,249,0,117,75,124,176,136,180,61,183,127,104,174,125,4,14,204,111,95,94,61,28,143,81,250,87,21,106,44,223,123,186,54,60,240,0,202,183,101,93,56,24,139,142,18,157,151,177,221,111,22,200,0,170,51,74,224,217,69,221,51,139,99,192,167,197,69,61,126,61,172,60,111,75,82,21,49,205,249,137,17,10,218,85,75,29,254,173,179,190,191,182,129,151,184,248,31,155,245,239,96,179,191,85,226,211,133,177,184,37,24,251,61,15,120,124,192,214,248,230,14,131,73,239,8,101,42,190,221,129,219,133,17,235,192,83,103,100,160,78,192,207,57,12,23,229,14,242,141,29,96,19,160,223,17,202,77,155,179,170,105,129,3,164,80,83,201,175,14,7,228,135,78,44,148,221,83,210,118,160,137,146,65,201,119,223,37,169,250,127,150,212,228,115,18,208,40,196,149,58,2,152,76,180,219,64,47,162,166,232,241,221,229,85,71,12,168,7,143,230,184,68,172,47,209,101,152,98,195,197,88,79,102,24,111,176,189,180,207,222,145,246,36,58,227,60,69,212,35,206,5,163,102,56,165,155,142,231,74,233,216,94,255,120,234,170,228,36,206,18,135,170,195,140,9,234,92,240,97,148,55,33,5,69,30,5,223,160,248,67,83,28,47,249,8,226,200,114,7,67,10,50,159,43,188,136,112,207,170,239,196,147,93,78,243,109,82,131,139,154,185,146,156,47,69,12,91,19,30,236,79,24,1,39,71,201,205,108,108,123,160,241,139,121,118,242,66,160,177,170,198,112,250,155,58,238,203,97,161,100,153,195,89,224,149,231,229,14,178,235,61,105,111,155,128,23,85,186,132,109,221,239,73,5,62,36,1,19,176,218,188,248,88,151,184,119,57,77,114,186,97,189,54,184,102,240,203,175,201,151,4,197,253,116,67,65,85,64,141,144,234,234,25,170,73,246,60,229,68,77,94,91,182,130,62,118,69,120,146,35,3,145,157,8,224,171,84,134,42,182,190,37,219,156,135,168,169,200,49,26,81,201,171,133,75,160,210,207,36,100,80,251,235,248,75,143,225,225,75,52,229,144,177,92,33,164,94,54,1,184,184,16,188,231,105,143,94,218,151,72,211,217,158,157,22,219,178,134,148,191,133,172,114,230,242,50,59,235,40,5,174,115,117,203,150,5,142,148,76,97,226,227,95,29,161,123,41,80,201,146,160,60,70,163,236,170,217,165,118,238,165,95,33,161,169,191,30,23,98,252,78,117,119,241,69,246,22,234,178,52,194,216,73,118,202,162,239,228,248,159,111,9,37,49,160,105,226,206,55,202,150,117,138,234,176,234,174,229,130,163,163,165,22,76,146,156,73,230,32,7,79,139,98,101,112,30,120,85,136,126,92,106,203,99,106,242,120,98,41,180,241,34,164,183,63,150,172,61,241,170,206,57,215,13,91,183,30,165,191,207,81,183,24,69,88,72,75,5,138,0,165,19,75,241,108,118,43,5,28,178,81,99,113,114,97,136,16,183,96,210,243,55,139,123,178,238,192,57,36,197,181,254,215,55,134,69,205,32,147,61,127,211,63,74,39,138,69,10,215,146,183,108,46,73,206,99,19,197,143,89,136,226,12,231,33,8,154,246,243,246,24,71,159,111,203,138,36,41,162,201,56,164,49,223,104,228,49,74,50,83,252,139,12,245,64,20,43,133,38,169,135,153,174,214,103,146,102,238,35,81,154,255,203,163,235,9,119,22,243,144,121,134,176,169,26,53,134,12,244,107,110,24,178,131,34,3,227,72,123,108,250,53,230,3,242,227,193,180,5,4,14,153,1,234,134,107,174,195,222,56,164,255,95,201,87,30,227,38,179,115,176,129,178,134,247,234,1,119,155,110,117,171,222,61,201,43,62,217,243,177,119,130,147,244,130,46,62,117,121,149,226,236,217,71,158,180,16,120,158,198,252,157,229,180,178,11,10,74,241,102,127,202,214,199,204,30,146,235,93,3,242,136,58,81,46,173,239,18,215,149,250,81,75,73,87,180,147,75,246,22,214,6,230,189,168,57,21,1,241,114,223,105,3,21,233,216,174,118,47,234,85,126,71,148,74,151,55,73,234,160,213,214,203,223,185,10,5,218,209,85,85,111,224,6,169,217,105,13,147,173,172,1,227,9,72,228,3,140,208,54,253,144,144,138,145,71,141,143,8,210,38,109,162,39,8,20,21,40,17,108,10,173,132,163,69,171,3,118,45,216,167,183,13,213,62,72,236,177,12,7,28,85,194,66,30,40,247,211,190,98,8,226,233,39,97,159,164,21,122,20,187,6,153,153,16,239,243,58,223,16,58,77,60,172,128,49,131,220,152,151,3,2,141,228,229,146,157,86,159,243,189,12,65,48,39,228,177,178,74,177,171,115,85,25,71,171,121,37,222,155,6,172,111,125,155,164,124,29,200,29,190,59,230,240,201,193,254,11,39,15,44,69,58,10,4,158,100,156,254,95,97,102,252,110,22,92,92,49,191,177,113,100,106,155,248,159,100,159,250,61,153,201,113,83,7,6,106,50,252,119,38,73,146,133,128,78,51,147,163,6,169,175,122,13,247,220,105,40,101,208,227,159,146,44,88,56,132,65,217,79,86,77,71,215,100,113,191,163,188,70,3,253,57,173,202,156,77,3,42,171,60,176,50,63,189,178,40,142,113,31,40,185,128,250,1,223,231,76,59,62,45,135,254,53,167,114,2,169,6,196,20,102,147,171,170,108,203,101,244,3,49,56,12,15,53,93,59,140,140,58,234,75,178,109,238,128,217,249,14,202,70,120,147,243,172,71,56,131,55,123,81,135,133,124,66,44,95,228,148,72,129,169,245,10,80,145,161,104,94,51,153,116,73,200,204,72,212,47,101,194,105,162,210,9,208,196,8,191,16,120,57,102,101,126,86,161,75,205,47,179,104,221,235,24,174,72,35,20,137,220,118,53,185,90,116,34,22,173,243,122,1,34,229,9,148,49,143,72,163,240,13,250,36,36,90,114,208,96,157,194,170,188,182,48,105,137,179,143,46,38,123,80,66,167,16,74,14,114,136,135,41,119,130,120,88,16,162,9,238,146,200,179,23,248,78,21,35,71,8,125,138,83,30,216,146,32,242,141,165,34,17,58,252,10,36,12,24,244,195,6,191,202,58,164,156,35,68,134,20,241,58,69,145,150,241,212,33,13,233,160,33,54,57,234,27,55,53,8,82,136,187,72,152,253,59,57,245,219,146,178,246,130,158,147,155,28,190,166,2,144,11,24,247,157,116,194,110,26,141,122,170,19,112,78,143,49,131,75,210,200,120,103,4,88,135,198,212,24,48,234,11,5,127,218,169,134,50,182,151,84,223,104,72,246,110,32,152,74,214,103,171,62,114,43,220,15,161,218,67,175,195,45,61,250,21,102,61,77,98,8,206,16,48,135,195,37,138,240,144,31,41,217,229,148,88,102,16,209,86,60,8,211,47,87,241,147,231,80,144,176,73,199,186,172,81,35,102,201,63,144,40,119,152,97,242,142,50,24,75,19,103,99,146,19,31,239,36,130,20,178,189,5,152,70,143,82,237,7,186,152,69,9,144,122,143,81,68,42,157,146,153,20,58,53,49,226,188,164,114,38,40,30,8,132,189,122,163,152,30,153,194,207,44,14,162,122,8,150,28,3,187,45,224,151,141,204,143,165,126,46,12,209,209,236,129,174,191,78,230,199,147,160,51,39,251,147,145,244,119,178,215,217,93,214,231,83,35,57,243,47,240,158,231,93,78,158,7,11,17,21,122,239,40,0,110,202,145,133,66,254,90,239,46,249,204,10,159,117,146,253,255,150,71,73,66,145,77,87,13,30,205,195,111,97,222,73,95,48,100,22,104,129,88,38,43,102,196,168,176,28,254,161,99,89,35,121,68,80,185,158,163,206,21,166,86,15,122,64,117,152,224,132,226,65,175,164,239,243,29,166,21,150,98,113,53,114,52,226,80,32,40,235,32,107,70,94,196,196,205,149,150,20,202,177,234,24,34,72,208,103,158,185,146,120,46,55,228,24,181,3,31,88,163,50,222,1,94,38,168,162,202,157,245,129,37,8,109,132,151,62,184,244,212,57,177,69,28,185,157,249,75,151,110,92,18,71,141,184,132,238,222,32,201,50,12,30,33,29,232,122,111,180,236,6,78,118,162,49,201,195,157,113,206,159,25,96,92,29,166,67,26,52,177,23,208,31,30,157,89,211,217,166,109,82,47,27,53,145,116,193,110,72,199,35,156,116,73,145,34,221,205,252,21,179,84,203,72,188,231,129,101,155,183,105,244,244,132,95,151,59,68,252,123,91,157,55,107,177,131,196,41,145,1,183,128,199,233,10,38,168,136,58,13,66,101,131,77,146,97,142,187,223,86,82,3,141,167,202,71,195,163,133,60,246,70,240,83,106,23,140,202,48,10,201,247,169,60,13,110,244,197,229,228,252,42,69,87,203,205,62,174,19,198,87,198,1,69,75,85,128,102,22,44,223,120,213,217,107,16,153,23,74,66,80,246,140,216,92,112,73,208,202,28,92,112,116,189,186,205,235,15,179,72,184,218,239,136,48,218,0,154,0,160,70,27,199,149,45,33,19,164,87,252,240,243,204,94,79,22,130,190,106,86,66,229,210,56,193,31,58,126,32,51,76,35,190,115,201,194,167,3,148,32,128,61,8,216,153,157,238,118,144,155,156,221,150,21,36,153,209,37,78,142,26,136,115,40,88,240,99,146,104,118,213,192,136,20,22,51,53,36,57,213,150,224,33,103,33,236,240,220,243,133,190,246,232,148,242,213,115,245,232,143,166,159,79,31,6,99,182,227,187,199,107,81,177,22,181,77,164,227,78,166,73,112,245,211,228,144,79,114,53,18,251,160,33,125,132,55,138,103,6,176,165,138,202,165,244,121,226,1,69,234,155,159,24,241,112,56,152,45,212,169,188,199,145,45,182,187,118,63,32,225,152,133,251,6,237,216,111,63,151,111,168,195,68,107,43,9,181,41,132,176,86,45,248,198,197,74,103,20,50,181,202,219,60,218,159,194,166,147,62,72,121,233,182,115,120,190,142,131,130,187,137,94,123,89,236,49,200,211,34,111,246,34,64,142,61,138,20,139,56,242,54,167,27,34,219,65,79,158,194,107,105,91,245,134,183,58,30,23,226,75,246,250,29,136,93,73,26,179,252,112,175,118,164,10,117,210,66,253,97,236,24,178,212,135,48,94,139,141,13,92,228,79,160,65,83,139,43,217,79,134,127,12,143,70,162,196,72,111,93,238,208,252,142,164,1,69,58,226,244,76,228,96,221,93,73,219,46,175,80,5,229,158,176,208,68,125,114,242,231,178,189,213,59,51,122,255,100,103,30,172,156,14,93,26,218,233,177,150,90,242,57,10,61,137,218,154,180,159,250,189,20,107,90,201,136,126,2,221,0,16,217,162,51,69,102,45,36,221,101,255,228,197,229,46,19,82,80,91,76,238,24,201,145,212,74,234,14,115,251,208,169,174,75,225,187,227,247,222,142,57,230,213,155,205,120,46,45,144,191,176,78,113,121,131,100,209,60,158,75,223,14,26,160,46,142,13,142,195,157,8,152,200,190,191,5,150,170,174,70,121,195,49,62,177,254,248,153,113,246,44,82,245,142,95,240,172,115,232,78,224,201,11,133,86,168,49,30,82,83,58,28,43,184,223,113,131,54,206,177,13,156,61,113,183,255,100,169,230,111,201,55,234,170,148,250,103,150,188,76,190,75,94,37,223,202,39,70,122,29,233,40,247,91,63,88,107,187,39,99,98,27,65,207,235,43,24,123,195,214,124,78,173,200,87,44,111,178,190,207,239,189,51,36,25,60,84,8,176,231,170,215,100,86,186,202,125,29,177,5,99,237,199,154,83,217,69,186,211,154,177,250,247,200,198,240,174,175,199,204,169,222,185,140,225,191,216,137,188,49,105,228,103,100,223,86,129,169,194,255,35,132,57,190,215,174,59,124,48,80,61,195,125,160,190,247,39,250,226,83,103,160,40,148,121,154,58,115,174,10,184,128,122,231,13,163,84,188,159,39,93,177,58,210,161,58,11,199,108,98,24,188,117,217,29,108,197,120,30,91,114,79,113,249,216,38,26,151,165,191,65,99,107,198,212,38,81,77,225,116,179,173,254,147,213,146,224,27,177,7,59,130,238,170,167,73,8,97,192,158,228,158,95,164,121,97,110,244,9,105,167,19,238,67,188,131,54,90,173,100,107,196,186,166,217,27,232,235,24,212,223,254,246,152,93,129,240,117,69,48,93,166,47,196,226,122,218,38,41,55,53,232,79,82,241,178,234,143,12,89,5,241,179,189,241,220,187,36,198,66,199,151,85,21,116,213,44,5,181,98,67,53,150,77,171,166,104,104,66,231,24,136,15,160,202,1,158,113,98,207,232,135,166,172,211,241,148,103,117,1,132,80,63,156,82,154,115,151,219,167,211,79,76,138,196,165,22,88,101,111,80,230,122,199,145,212,198,78,135,198,253,246,212,56,112,202,228,192,224,126,230,80,18,171,153,243,152,36,43,252,203,12,245,93,243,59,40,163,184,113,128,201,32,99,127,164,242,169,31,115,152,71,238,204,241,47,76,92,189,82,87,50,191,190,46,123,88,96,166,166,186,35,133,190,98,59,158,203,206,42,207,199,240,45,87,69,125,85,247,169,201,153,117,181,154,39,103,114,141,98,30,75,6,9,17,50,228,49,237,200,20,205,194,141,23,98,220,176,112,202,246,245,58,118,96,107,99,247,210,7,235,225,96,125,162,204,221,227,102,98,111,45,199,72,142,164,91,22,144,153,110,125,131,55,141,50,126,134,66,42,188,149,149,138,203,6,76,254,98,203,197,142,224,79,59,136,83,216,189,53,234,120,224,187,112,233,219,33,23,40,11,32,164,167,200,164,24,255,153,89,23,144,50,127,136,149,47,133,248,233,49,205,106,200,200,91,253,250,37,158,226,49,104,23,65,202,100,184,63,230,245,129,117,90,43,88,220,175,171,174,176,46,65,226,126,140,185,142,141,149,147,74,181,250,15,94,98,236,221,182,108,245,15,222,117,156,90,218,40,90,78,31,200,103,254,105,185,243,190,48,61,34,53,83,204,249,146,152,174,56,49,167,74,30,166,26,198,80,16,112,185,33,69,18,43,48,192,204,209,122,97,234,152,171,230,78,16,170,247,85,33,109,48,135,92,122,174,41,160,43,137,204,69,122,149,57,234,172,235,57,36,84,45,89,172,150,117,65,238,87,224,26,110,105,83,55,29,171,246,227,222,46,134,186,104,131,58,109,117,95,79,119,59,253,155,76,250,215,153,150,219,45,41,120,233,34,239,65,129,78,164,82,125,166,120,89,245,90,137,0,86,29,191,218,42,185,229,174,249,231,134,254,46,126,191,75,158,56,24,58,222,141,16,70,103,69,181,132,133,97,169,159,166,48,15,125,62,46,229,131,4,20,92,252,150,169,216,214,87,224,58,15,196,251,6,24,202,251,182,204,31,154,9,34,49,88,236,140,231,178,232,129,76,244,166,172,139,0,137,241,168,119,105,132,49,103,240,112,248,50,162,140,125,242,58,20,165,204,102,187,73,122,244,220,160,114,19,253,11,21,63,196,201,61,243,254,161,232,96,135,174,51,102,111,200,166,172,205,55,233,192,141,232,103,223,197,58,170,239,119,208,251,105,223,103,234,133,233,249,180,135,25,223,111,43,94,20,243,183,6,75,179,11,8,167,20,24,222,3,154,203,225,208,214,234,44,7,212,210,189,110,30,31,209,0,29,96,103,192,36,71,65,33,45,234,194,18,145,45,90,171,86,30,186,179,52,220,52,122,217,87,187,74,187,148,131,192,210,148,242,178,148,30,115,248,244,33,129,197,138,243,30,247,107,178,195,238,128,118,185,199,172,144,243,112,65,105,67,157,165,78,147,191,191,130,138,58,147,63,98,19,58,231,35,169,183,54,185,158,97,149,246,214,22,164,61,121,124,175,221,217,169,23,192,150,59,117,167,51,230,1,12,67,77,99,255,151,111,224,137,249,247,95,183,2,134,236,207,81,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d04fa5da-95dd-4b84-8e61-36d15f0bbcfb"));
		}

		#endregion

	}

	#endregion

}


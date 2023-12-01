﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDeduplicationManagerSchema

	/// <exclude/>
	public class BulkDeduplicationManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDeduplicationManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDeduplicationManagerSchema(BulkDeduplicationManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9c848255-c02c-4ca5-9d7c-159a0d6b4582");
			Name = "BulkDeduplicationManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,28,107,115,219,198,241,179,50,211,255,0,51,153,22,108,24,200,113,190,217,18,61,178,30,46,147,88,82,36,57,254,224,241,100,32,226,40,161,38,1,26,0,45,169,42,255,123,119,239,253,4,64,201,78,219,76,198,54,239,177,183,183,175,219,221,219,67,145,46,72,189,76,167,36,186,32,85,149,214,229,172,73,246,203,98,150,95,173,170,180,201,203,34,57,32,217,106,57,207,167,244,215,95,190,185,255,203,55,91,171,58,47,174,162,243,187,186,33,139,23,214,111,152,61,159,147,41,14,174,147,215,164,32,85,62,109,29,115,114,249,79,248,231,155,50,35,115,103,220,175,121,241,201,105,60,38,141,106,51,176,59,156,167,117,147,79,147,131,114,145,230,22,230,201,69,90,127,236,152,247,142,92,238,45,115,220,127,83,165,211,166,78,206,200,167,21,169,155,122,243,121,245,18,246,70,212,188,99,114,211,64,11,146,247,231,186,44,84,7,12,109,206,175,211,106,169,154,116,78,44,22,250,96,189,167,34,161,246,228,176,104,242,38,39,117,112,192,17,96,89,86,129,17,199,171,60,57,39,213,231,124,74,40,87,146,131,180,73,197,222,122,77,56,188,109,72,81,35,119,125,195,129,90,201,63,154,102,153,236,93,214,20,166,57,144,34,127,167,36,36,218,237,139,91,98,79,5,160,0,246,219,138,92,33,156,125,224,86,253,60,122,181,154,127,52,184,248,38,45,210,43,82,209,177,219,219,219,209,78,189,90,44,210,234,110,204,127,227,132,40,211,103,68,11,54,37,17,51,182,181,41,239,15,200,44,93,205,155,87,121,145,193,126,226,230,110,73,202,89,60,9,173,59,28,126,120,192,172,223,159,109,56,239,117,85,174,150,198,146,203,213,37,116,70,83,36,75,144,42,17,16,44,173,137,175,107,20,181,96,231,235,212,81,128,245,239,41,197,37,123,142,114,50,207,128,63,167,85,254,57,109,8,235,92,178,31,81,69,210,172,44,230,119,209,228,188,73,171,198,0,203,149,148,201,244,93,244,71,221,49,226,133,31,176,131,46,26,140,253,121,78,138,38,250,227,50,220,25,0,183,183,92,158,79,175,97,202,156,84,239,170,116,9,164,252,35,117,218,140,201,83,208,131,38,2,157,64,53,152,212,111,139,28,208,222,107,224,247,229,170,33,199,96,169,65,23,6,162,99,208,54,247,188,92,85,83,194,244,193,3,65,239,246,193,201,97,207,111,210,219,35,210,76,175,79,129,93,53,76,251,241,233,211,23,156,99,164,200,24,211,76,14,158,86,37,108,9,13,15,114,177,108,64,9,73,38,248,200,127,70,159,243,170,89,165,115,186,196,254,53,153,186,100,5,14,55,171,122,82,52,160,231,48,112,119,28,253,216,177,48,53,0,43,100,46,174,76,197,154,47,203,68,60,36,166,241,219,154,84,48,185,224,150,102,101,252,28,33,132,173,45,31,39,93,70,14,65,81,46,65,81,98,19,198,48,186,167,80,242,89,20,51,230,36,147,250,120,53,159,159,84,135,139,101,115,23,27,104,177,115,228,109,53,31,138,121,91,191,150,87,201,97,85,149,85,60,240,15,141,242,58,34,8,42,25,12,41,39,183,214,244,207,207,105,101,237,103,31,89,203,200,180,87,93,173,22,40,216,187,81,65,110,34,79,79,60,48,39,15,70,22,52,190,88,167,182,193,18,212,240,242,159,224,18,52,59,157,74,60,142,217,238,59,55,32,176,104,209,79,47,2,45,202,190,241,218,174,48,192,146,1,85,95,183,11,242,27,210,92,151,134,17,220,218,210,181,147,105,44,2,94,164,191,173,8,80,23,118,115,192,119,65,196,177,127,88,127,226,194,22,17,58,1,21,95,72,20,202,5,169,63,113,206,59,0,45,149,72,244,1,210,238,107,80,25,13,0,96,2,40,227,17,72,161,192,17,188,90,20,32,234,123,243,155,244,174,62,39,120,32,195,146,64,65,162,102,192,82,123,217,34,47,206,242,171,235,166,54,186,43,210,172,170,2,17,213,201,38,200,112,144,83,228,96,181,29,182,207,17,183,124,99,164,7,250,7,164,186,40,25,59,25,42,136,235,155,116,201,201,242,254,3,216,57,108,174,71,30,146,194,162,58,177,234,48,56,78,196,48,58,49,167,15,194,89,50,250,40,0,48,59,64,55,236,101,19,103,224,173,165,211,235,40,70,8,12,103,176,156,2,123,105,37,90,112,124,143,107,236,101,25,107,140,217,204,33,93,226,3,96,192,126,235,134,3,77,213,147,22,128,201,94,113,23,223,162,89,190,77,126,33,160,223,187,158,173,253,251,223,208,251,123,58,95,17,111,255,176,55,230,1,234,124,232,67,60,182,159,214,173,100,89,236,61,104,71,254,243,119,104,72,103,11,100,159,212,190,94,229,25,202,231,89,121,115,70,166,101,149,77,178,216,35,58,37,141,135,198,81,85,222,244,144,206,7,73,149,51,241,156,174,205,249,133,43,191,119,224,126,72,46,74,54,44,54,169,128,219,74,78,211,10,206,190,16,204,161,143,28,142,159,239,51,101,177,151,0,163,136,34,208,98,6,90,88,195,39,79,126,205,235,102,71,46,56,41,102,229,152,25,54,88,150,29,253,19,103,241,163,124,14,94,201,4,162,80,68,131,253,66,35,0,7,186,126,210,11,48,16,108,173,240,0,218,141,158,74,129,231,84,83,198,87,81,32,118,14,112,113,64,17,33,48,104,37,37,116,102,86,217,106,119,168,144,236,95,137,24,172,25,31,9,168,54,2,43,157,228,181,131,142,162,116,155,18,137,33,46,174,162,71,146,106,232,49,106,57,18,19,76,154,15,67,73,52,28,56,203,171,186,49,248,165,211,226,8,123,133,89,18,24,32,229,45,133,195,229,70,84,137,56,50,20,118,110,120,196,0,215,93,44,97,35,116,208,158,65,162,155,195,70,97,48,97,203,45,109,33,38,220,0,5,189,245,17,61,18,5,166,107,14,84,77,244,90,46,15,90,98,164,33,96,92,18,125,132,223,88,95,93,225,241,43,238,163,244,22,244,17,28,175,42,189,156,147,29,180,58,66,224,149,168,61,72,99,209,92,158,145,26,29,7,68,158,185,65,154,99,195,38,129,50,207,73,90,249,58,144,23,248,123,31,196,186,33,172,245,93,222,64,228,84,1,234,56,36,102,141,251,229,98,153,86,121,13,238,38,132,233,201,225,39,8,132,70,33,115,125,154,54,215,60,4,145,219,20,42,15,7,9,8,58,216,93,101,147,135,201,1,24,180,188,128,222,161,144,109,106,139,228,174,159,152,219,246,109,193,80,83,67,74,40,102,50,175,131,78,180,207,92,120,219,77,143,114,56,106,99,178,247,164,64,103,157,67,165,51,148,212,209,140,130,33,136,180,229,171,156,26,173,231,5,59,220,175,112,113,176,187,255,95,130,213,231,40,233,16,180,150,35,230,79,21,156,7,28,45,93,214,244,49,39,76,171,221,69,15,160,75,178,57,142,175,153,92,1,53,185,132,113,246,193,178,232,16,248,246,199,214,243,105,211,231,18,36,21,54,44,112,227,129,65,171,167,73,133,144,197,28,148,86,222,208,145,13,16,56,83,199,239,240,118,89,145,186,102,146,224,157,164,70,184,24,168,62,42,213,82,234,213,25,42,155,132,235,154,177,108,104,124,89,150,243,33,63,53,57,177,184,115,236,103,51,27,242,150,210,152,58,180,199,228,6,255,142,25,144,181,215,46,81,74,138,40,63,144,198,162,41,46,208,155,159,203,75,17,147,215,140,67,118,80,62,245,38,195,148,170,135,131,77,17,49,112,170,220,183,165,213,0,143,195,91,50,93,53,101,197,99,123,196,131,174,194,228,93,195,78,80,174,55,192,73,145,145,91,11,158,108,91,107,34,25,216,176,132,72,5,158,49,140,161,208,23,3,208,69,119,168,11,54,214,121,16,76,227,128,150,47,202,207,236,72,129,217,117,220,7,227,22,112,226,247,155,188,0,185,155,223,193,180,157,158,27,19,73,169,62,24,8,97,54,19,57,239,202,234,35,189,232,75,24,95,172,238,253,85,85,129,1,194,214,68,3,210,39,67,59,234,20,93,240,73,211,121,237,15,3,89,28,54,161,216,131,52,83,199,110,20,153,231,236,56,162,153,104,101,29,143,170,114,193,175,129,220,76,215,136,230,150,203,217,12,78,94,246,239,41,134,97,186,174,41,139,41,110,234,64,187,24,173,9,93,138,167,35,213,121,47,198,141,227,3,181,75,154,119,70,147,91,209,51,181,175,126,70,131,90,115,248,17,229,129,158,83,139,164,222,69,3,194,110,24,165,18,13,52,133,210,199,177,221,66,47,251,135,222,69,55,15,61,244,111,209,177,54,99,120,151,30,137,34,246,203,132,50,231,149,204,250,240,227,104,8,78,1,50,47,246,242,213,116,151,216,20,234,51,81,250,210,223,39,179,199,113,148,253,179,41,151,10,204,41,169,40,104,193,108,190,63,31,107,67,8,26,28,166,205,255,191,108,198,14,131,62,52,33,33,136,4,163,189,196,179,132,196,78,190,138,241,20,22,141,195,45,237,164,29,29,12,197,3,26,8,73,50,35,138,228,249,18,22,245,118,179,208,69,69,49,143,3,251,223,225,157,127,179,131,81,136,10,235,22,30,248,98,17,139,9,175,238,40,47,59,216,160,135,45,29,118,179,183,42,113,45,250,110,112,31,52,149,235,237,123,190,232,122,176,1,79,250,139,127,11,237,46,188,91,184,24,11,242,128,203,73,89,207,228,101,210,150,161,101,115,169,175,74,15,187,154,121,139,209,205,53,169,112,161,231,184,181,88,63,120,248,20,238,203,97,237,7,71,32,54,151,101,23,65,201,235,195,11,105,168,233,48,81,145,114,84,86,139,20,193,96,253,3,251,33,235,74,172,40,232,147,68,15,99,33,15,206,42,51,201,150,0,7,95,30,221,177,154,141,201,254,145,6,141,165,247,71,145,28,75,157,116,10,152,133,138,78,54,179,82,103,45,238,156,133,60,9,231,6,114,128,99,160,101,47,196,148,132,123,211,101,70,48,143,129,229,35,170,37,57,249,197,115,95,250,221,128,50,56,2,98,68,247,5,160,88,206,226,139,225,26,92,145,124,78,178,36,66,66,63,143,238,117,186,175,147,72,65,101,125,246,234,48,100,16,125,207,195,143,239,6,26,29,97,60,191,225,253,185,204,139,24,100,17,254,119,201,141,100,172,135,235,184,223,96,74,99,24,62,20,151,187,122,244,120,209,146,48,214,29,27,185,13,20,22,69,91,223,88,43,69,164,83,19,53,24,175,83,109,122,230,53,200,21,184,129,121,144,166,138,142,28,198,58,249,95,165,33,239,113,41,246,136,148,20,107,18,52,142,93,151,67,113,141,54,5,110,125,30,157,59,221,60,51,138,18,181,200,139,128,251,0,131,159,169,104,46,175,105,65,131,26,59,41,196,40,115,123,154,103,169,221,143,40,177,12,1,50,132,18,201,6,50,73,71,42,248,236,36,139,238,173,5,225,148,137,102,112,14,82,10,193,65,8,90,78,197,147,159,132,207,157,9,102,170,127,157,56,130,3,52,178,53,175,54,47,16,122,220,172,180,242,11,101,147,30,171,44,209,45,18,30,91,173,152,242,65,235,33,75,86,157,84,188,56,44,214,44,170,137,167,71,223,57,105,13,18,69,151,119,45,180,45,74,180,10,171,34,251,42,132,149,32,196,157,160,69,93,121,85,216,77,212,160,32,142,34,59,249,77,253,211,235,180,230,169,88,88,115,175,226,25,216,26,168,154,23,196,77,152,51,53,56,46,27,104,133,35,198,182,9,187,238,86,184,2,236,180,105,217,95,255,26,61,81,136,232,122,18,90,201,199,78,154,66,198,60,156,178,250,120,247,47,242,180,221,252,165,11,125,113,6,111,158,11,117,131,133,32,87,233,128,145,157,66,117,54,200,71,232,151,112,190,129,230,214,2,25,88,193,88,15,76,24,166,235,94,56,65,75,69,207,149,182,126,22,220,242,214,101,251,75,76,141,241,9,69,221,164,197,20,52,102,72,107,57,134,104,6,100,233,141,157,158,105,91,21,147,246,231,191,177,134,208,157,11,247,170,103,108,51,224,25,10,12,97,50,37,108,173,167,1,216,145,29,45,101,234,136,9,139,208,194,153,212,198,39,10,160,85,81,199,211,190,47,35,244,135,193,225,0,115,208,36,7,4,12,67,14,78,202,191,8,171,55,223,225,32,199,177,134,25,155,249,92,147,210,141,142,77,165,155,2,79,207,149,155,156,193,199,36,175,86,249,60,59,20,29,244,50,228,172,44,27,182,164,55,89,231,243,88,36,228,80,229,201,251,15,200,46,150,251,150,55,244,190,144,112,194,162,18,238,17,10,79,72,47,111,120,184,83,206,34,149,120,176,159,22,104,84,174,32,134,91,81,140,96,29,68,169,166,222,37,139,175,162,251,167,235,40,45,50,240,46,33,154,142,238,127,4,79,242,226,154,68,11,82,215,233,21,65,191,243,254,217,218,8,203,185,214,109,201,248,123,20,217,174,167,65,59,78,23,134,130,230,112,208,50,139,251,104,237,137,67,56,24,148,185,178,49,196,78,238,214,15,174,93,26,25,38,99,103,29,31,171,61,240,125,76,215,130,203,136,93,32,90,252,175,69,232,233,19,2,231,170,61,211,215,211,29,196,43,11,42,102,28,20,114,103,70,192,11,24,156,20,243,187,183,214,14,196,32,78,64,149,62,217,85,169,20,143,69,21,229,78,54,255,109,210,179,18,87,113,214,177,253,196,198,126,100,38,115,104,95,82,132,3,118,155,154,118,166,137,135,240,167,39,231,23,82,52,58,162,119,185,248,183,32,115,199,135,23,71,103,123,111,14,223,157,156,253,98,164,0,32,62,127,85,102,119,113,47,194,163,0,125,75,230,53,177,65,224,122,155,130,41,178,124,102,134,73,180,83,72,159,89,171,74,111,199,14,16,166,188,187,38,25,187,158,239,103,250,229,217,225,48,184,203,85,48,79,238,51,203,132,177,98,34,13,31,126,136,251,156,74,158,69,139,185,240,134,250,57,238,156,203,237,210,41,220,150,167,252,247,9,203,101,169,6,126,209,10,45,138,22,226,246,149,15,81,94,169,54,132,55,118,56,60,50,193,207,7,24,215,1,129,161,174,207,229,208,47,161,127,208,110,79,134,193,4,167,134,130,231,171,109,224,162,45,147,191,197,43,96,85,101,65,91,9,221,150,26,137,194,126,150,22,87,36,14,32,125,145,126,36,113,39,26,2,112,203,158,88,57,173,94,66,197,180,162,119,209,183,246,114,129,62,43,202,139,107,56,39,154,172,156,70,211,138,204,118,7,193,7,55,232,221,25,237,232,246,15,182,199,84,33,3,143,32,104,234,193,55,47,92,60,222,128,87,167,177,35,157,226,83,14,231,226,79,92,218,182,150,229,35,198,123,254,249,177,113,18,137,3,64,48,0,5,43,184,48,243,183,176,252,56,48,36,81,247,151,78,244,107,71,35,46,181,100,24,62,169,105,132,125,182,42,248,109,197,72,245,64,99,129,228,219,101,183,158,34,40,55,139,248,104,100,235,191,87,197,215,3,157,200,107,197,139,139,244,214,144,87,102,199,91,160,188,241,79,224,206,170,216,8,196,157,155,1,72,254,145,214,52,215,38,32,188,220,20,128,49,251,121,244,195,143,218,46,151,85,9,33,75,77,50,24,62,5,1,17,21,31,65,82,149,77,58,151,71,51,218,154,113,244,148,23,164,2,102,113,86,130,90,144,97,104,250,169,88,206,0,177,189,193,114,127,199,23,83,124,189,231,34,193,37,115,4,55,74,74,130,98,176,27,5,110,222,147,83,66,95,251,129,156,203,188,208,230,64,56,6,102,25,236,106,138,219,238,70,238,73,24,238,62,6,151,115,146,105,130,244,0,40,71,52,77,239,38,108,219,21,211,208,75,170,126,50,38,208,54,165,51,64,245,243,189,211,126,147,14,98,76,64,113,118,3,42,40,166,157,90,162,139,47,146,120,36,112,81,78,138,230,167,103,177,87,186,69,1,147,30,3,192,10,120,177,131,177,214,225,237,148,44,141,90,54,127,146,101,253,224,19,197,117,210,248,145,242,254,228,178,46,231,112,92,198,3,8,77,35,239,208,232,38,111,174,253,93,182,171,7,33,94,221,144,52,75,6,244,97,170,113,98,249,179,232,126,184,190,72,198,125,241,195,143,145,199,85,20,248,215,231,110,98,112,199,61,29,68,225,255,77,13,167,79,248,94,83,45,173,37,157,71,190,21,214,234,245,96,240,160,242,181,235,14,160,116,226,237,119,208,180,1,118,86,179,52,97,13,235,105,105,119,89,35,41,167,110,219,115,119,40,179,35,188,55,218,29,40,103,107,48,214,10,220,88,220,159,236,108,211,126,53,149,145,188,30,191,110,91,122,103,91,12,123,148,4,245,11,77,204,43,93,121,209,38,237,83,96,201,251,136,111,193,137,73,59,34,154,113,60,20,217,8,71,196,205,32,64,137,22,119,195,133,104,219,225,132,114,212,161,143,95,140,240,170,28,46,82,218,112,214,230,31,191,223,10,93,61,55,12,189,84,212,188,76,53,165,253,209,93,199,35,63,79,216,68,139,89,55,76,233,25,217,77,154,203,116,131,45,95,253,179,170,139,217,237,172,140,209,45,149,86,35,199,174,31,82,59,7,220,235,22,130,89,48,240,70,100,160,201,218,111,174,225,64,141,98,173,107,199,131,51,11,11,25,162,70,232,101,198,61,181,190,191,214,98,46,126,6,234,27,229,77,174,208,121,187,88,22,95,244,116,198,105,220,99,208,182,249,189,29,2,83,228,185,144,114,184,70,197,132,57,218,168,32,87,243,85,212,224,78,209,238,222,91,46,130,237,91,95,237,185,85,199,131,43,155,229,109,209,182,27,229,64,108,12,204,40,196,83,91,25,146,176,200,202,150,47,109,158,63,153,163,39,108,116,46,7,146,48,190,69,219,242,4,52,209,106,167,88,241,24,214,211,24,172,42,189,223,138,90,0,150,206,231,184,6,21,98,146,105,82,235,100,77,52,145,1,181,113,196,83,15,77,67,48,21,242,94,107,43,131,157,173,75,16,197,143,102,180,232,153,1,82,29,66,195,103,157,93,91,242,146,159,11,207,249,223,63,68,54,77,117,152,90,46,20,98,34,216,32,51,101,108,151,122,141,137,62,55,26,115,111,69,163,79,16,136,162,143,75,0,246,167,251,104,65,89,245,74,19,26,246,253,34,239,219,19,54,143,13,232,188,48,182,65,31,147,219,70,242,203,101,137,81,81,43,38,233,153,249,176,83,165,93,202,138,155,216,175,236,75,29,120,86,12,186,80,125,43,93,236,172,105,119,198,180,183,75,213,130,130,200,249,109,232,25,61,192,51,249,90,174,195,87,244,118,204,162,48,215,35,241,148,137,234,70,92,3,254,90,84,137,58,126,225,200,241,253,124,139,127,193,242,13,79,189,70,101,165,181,77,222,243,70,215,84,120,47,239,31,161,200,214,109,102,158,33,49,103,57,189,187,198,10,36,243,51,82,220,134,160,6,214,75,50,205,103,119,40,192,26,187,180,249,125,237,129,226,222,96,204,11,15,176,195,181,4,250,36,227,50,108,160,27,7,29,131,160,49,121,27,220,181,223,166,184,183,139,246,101,218,196,190,135,122,196,37,165,126,17,170,174,243,218,175,68,189,142,12,5,250,194,103,165,220,114,86,171,150,149,126,141,199,123,47,236,185,148,215,23,175,76,47,166,223,21,240,67,46,15,2,118,58,152,240,9,77,144,105,159,190,150,191,37,249,243,208,115,167,87,26,104,243,210,247,63,237,130,208,159,255,81,150,77,96,221,150,3,50,178,69,225,28,207,3,165,132,66,199,219,107,207,29,147,25,237,234,249,22,119,122,251,119,138,218,14,174,150,80,218,175,163,110,114,198,192,79,150,233,183,85,152,213,109,213,101,190,225,90,7,227,65,191,179,229,145,186,203,86,109,99,141,147,10,11,192,232,165,74,42,161,58,165,170,122,162,235,17,63,200,173,7,120,155,36,205,30,158,51,19,5,60,70,70,4,101,230,213,114,161,18,35,136,79,41,116,72,223,193,127,47,131,53,117,29,57,44,140,138,113,39,57,197,28,254,218,49,63,209,7,77,223,127,239,79,217,176,163,69,210,177,229,49,165,206,103,97,14,117,22,106,129,92,0,186,157,109,240,68,179,254,100,203,153,240,30,10,63,226,129,132,75,237,41,116,224,160,240,153,192,11,239,156,147,153,83,146,43,230,24,111,26,5,251,111,233,23,15,174,14,116,123,244,104,39,150,35,97,172,36,244,66,160,103,135,213,71,121,145,89,207,48,145,228,14,53,140,196,144,5,212,201,7,217,139,110,80,141,187,229,45,52,17,88,168,116,150,40,148,245,215,108,136,81,226,142,220,159,222,49,208,116,242,72,70,47,75,29,201,194,15,151,127,214,39,117,24,233,167,36,255,172,23,83,59,246,92,23,199,228,124,181,16,156,160,3,99,227,139,66,238,146,2,154,189,53,13,142,42,140,81,192,252,217,135,82,38,129,2,104,27,25,23,255,198,118,116,205,198,146,137,16,206,227,93,159,25,15,231,105,140,130,73,190,203,73,109,231,240,2,21,225,255,237,36,207,133,60,40,132,65,234,201,178,225,23,63,218,221,175,100,226,253,184,121,172,211,139,2,255,192,150,239,77,88,117,60,193,111,120,194,222,59,63,240,201,133,129,127,164,38,248,101,79,253,147,11,158,170,158,246,90,75,124,75,234,148,17,153,47,74,41,154,3,179,236,82,170,80,223,183,147,222,186,75,167,240,50,72,17,179,216,210,91,109,217,49,87,86,88,246,120,48,233,80,68,125,163,192,12,62,77,133,196,93,191,76,204,34,12,243,64,192,165,27,189,28,201,152,235,22,33,81,248,77,175,170,14,94,184,98,28,62,84,95,232,229,151,109,211,55,249,182,138,243,65,15,9,90,125,85,84,0,214,159,53,250,117,135,214,161,255,237,94,255,24,202,223,140,151,142,238,155,70,251,169,139,182,163,117,196,203,54,100,201,6,216,90,187,120,227,209,72,97,41,188,132,26,198,229,17,6,9,4,249,162,100,182,25,157,36,143,37,178,70,132,158,156,203,162,123,153,244,208,131,131,212,4,98,150,144,195,10,190,140,205,151,170,29,183,114,49,161,234,113,11,251,135,212,143,139,51,238,79,174,26,247,19,183,187,76,188,109,158,180,90,155,166,197,190,232,107,18,192,208,247,154,132,171,75,223,231,36,220,118,120,75,80,59,158,147,216,143,135,181,13,237,122,54,244,176,108,12,117,65,52,133,164,191,187,181,210,25,214,245,53,8,127,30,6,103,110,124,137,32,147,108,79,145,150,205,79,207,176,254,83,251,48,172,32,156,109,60,252,73,88,236,18,223,171,179,190,198,134,95,164,217,171,170,244,78,184,207,146,186,86,237,53,179,127,102,35,180,193,127,255,1,38,239,36,247,16,101,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c848255-c02c-4ca5-9d7c-159a0d6b4582"));
		}

		#endregion

	}

	#endregion

}


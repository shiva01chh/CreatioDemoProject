﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IndexingEntityListBuilderSchema

	/// <exclude/>
	public class IndexingEntityListBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IndexingEntityListBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IndexingEntityListBuilderSchema(IndexingEntityListBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("53dfc9d5-8345-4de0-994f-2835d022341e");
			Name = "IndexingEntityListBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eef27540-b1e9-466b-87b9-62933f9468f4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,28,107,111,220,54,242,243,22,232,127,96,215,65,171,5,12,25,215,3,238,131,29,59,112,28,59,183,184,164,113,179,78,91,224,112,48,232,21,215,214,85,43,109,68,174,237,173,235,255,126,51,124,72,164,68,74,242,35,57,28,112,249,144,100,41,206,112,56,156,55,71,202,233,146,241,21,157,51,114,198,202,146,242,98,33,226,163,34,95,164,151,235,146,138,180,200,227,183,89,113,65,179,25,163,229,252,234,219,111,238,190,253,102,180,230,105,126,73,102,27,46,216,114,175,241,27,128,179,140,205,17,146,199,111,89,206,202,116,222,154,243,46,205,63,215,131,151,114,129,221,221,163,98,185,132,245,222,21,151,151,48,92,63,183,9,195,25,254,39,33,146,129,158,245,50,255,36,210,140,251,1,75,22,26,119,177,6,103,189,121,29,124,116,156,139,84,164,44,184,114,124,66,231,162,40,3,51,236,109,196,211,92,176,114,1,7,133,83,97,242,86,201,46,129,42,114,148,81,206,119,201,52,79,216,45,128,203,21,55,239,82,46,94,175,211,44,97,165,156,188,179,179,67,94,242,245,114,73,203,205,129,254,45,159,115,66,115,146,34,44,189,200,24,97,18,58,54,16,59,22,200,106,125,145,165,115,66,47,184,40,129,104,50,199,117,187,150,29,221,201,165,107,66,65,34,4,205,5,16,123,90,22,2,100,132,37,106,70,147,58,57,0,98,64,150,52,167,151,172,140,171,73,54,65,163,149,193,66,0,175,0,218,74,70,147,34,207,54,100,138,192,231,25,252,181,143,120,222,107,52,111,153,64,225,98,101,52,182,89,59,158,236,117,208,241,97,177,224,76,144,5,19,243,43,146,179,91,1,84,205,203,226,193,52,1,219,240,116,207,69,177,58,65,92,239,17,11,208,55,222,218,42,228,18,63,1,238,173,173,113,23,45,39,101,177,36,252,115,70,68,186,100,3,233,104,17,176,0,36,179,207,217,27,42,216,25,160,177,232,104,60,233,33,230,172,120,50,41,162,240,19,226,140,43,50,70,163,32,33,211,132,100,32,120,79,60,151,52,65,233,53,68,188,24,255,112,119,119,247,118,157,38,241,241,114,37,54,247,247,247,63,116,114,3,8,38,115,105,106,200,77,73,87,143,229,8,112,84,25,172,95,1,137,197,17,179,246,22,203,19,165,79,174,114,157,164,12,148,25,53,43,189,6,190,117,16,250,38,149,198,25,134,72,177,32,92,155,106,114,147,130,120,223,164,89,70,46,152,50,8,44,9,146,47,215,176,48,189,84,228,111,19,101,6,102,243,43,182,164,63,175,25,0,144,115,101,83,240,87,106,108,215,128,109,244,27,136,151,156,49,50,47,217,98,127,252,137,179,18,204,75,174,54,51,222,57,128,29,160,173,153,179,222,19,112,65,201,249,218,249,221,67,46,144,185,98,37,26,248,129,54,13,197,20,184,174,60,30,48,31,205,143,54,186,164,88,41,167,217,205,116,68,241,210,181,186,202,75,1,167,83,123,88,251,20,107,171,215,105,41,214,176,108,7,138,105,3,3,65,119,63,26,93,130,1,220,247,44,64,94,189,34,81,123,116,31,236,228,77,199,50,209,100,34,73,27,241,16,222,125,114,77,179,181,116,204,163,251,97,50,48,189,204,193,161,38,181,35,66,49,80,131,36,133,160,131,247,122,19,197,224,22,30,32,175,57,20,96,108,27,180,61,82,51,84,253,111,148,46,144,133,173,121,223,1,19,215,89,54,49,211,70,37,19,235,50,15,17,35,217,132,255,92,211,146,184,50,172,143,67,186,223,114,141,225,198,97,121,185,94,130,212,69,99,119,230,120,187,41,255,250,156,70,30,2,247,85,228,161,2,152,13,250,214,151,85,184,4,161,68,83,146,14,34,63,230,158,109,221,187,114,226,161,98,152,160,184,86,79,92,105,27,135,54,87,108,86,172,79,235,60,166,206,108,240,12,192,45,17,198,159,33,197,235,197,98,255,10,233,158,122,230,40,158,26,82,199,220,183,70,80,247,12,146,129,252,100,11,186,206,132,203,69,195,218,58,138,236,52,189,149,218,88,20,24,196,206,216,190,203,153,88,254,232,114,198,198,206,34,49,139,52,131,192,153,80,237,231,22,69,105,12,46,151,110,138,124,70,63,53,196,234,30,74,20,47,219,62,14,157,28,255,124,178,206,231,39,114,177,14,19,209,135,232,184,137,7,55,47,207,171,189,132,18,130,246,176,101,126,195,43,41,57,176,247,120,81,20,217,43,114,190,44,146,116,145,178,228,67,254,174,40,126,95,175,20,226,227,28,149,58,105,236,10,65,200,251,46,128,128,189,235,92,36,254,59,229,191,160,20,182,141,95,55,220,47,149,232,86,230,16,87,131,164,115,198,132,0,233,225,241,89,185,1,75,37,39,70,13,91,183,77,156,172,192,179,0,216,199,98,13,130,117,241,111,128,80,138,50,169,105,236,38,14,78,37,66,118,77,174,109,34,9,203,56,27,142,97,65,97,186,187,193,7,115,230,222,82,237,65,113,141,204,251,58,148,77,9,151,84,35,116,221,90,237,76,96,25,82,44,149,77,14,11,33,143,237,8,178,45,81,134,5,78,160,169,149,195,25,10,90,200,246,154,149,153,172,29,144,94,173,133,243,186,205,219,254,104,37,80,161,24,20,186,42,117,13,96,32,231,151,225,226,135,97,123,8,54,52,94,217,160,0,110,197,236,208,67,197,246,0,238,218,14,117,230,118,32,85,74,237,56,72,23,21,132,150,189,89,138,218,170,52,131,152,199,213,62,100,166,69,243,211,52,1,105,34,32,73,123,32,174,240,87,143,86,88,17,84,151,94,76,115,8,120,104,150,254,1,210,65,229,214,205,137,26,221,8,22,77,84,81,37,246,110,36,8,20,53,82,152,70,156,165,229,246,188,21,20,182,50,157,94,179,240,158,137,171,98,104,122,118,184,90,101,168,32,52,199,52,87,106,168,207,241,146,218,112,25,87,61,175,42,136,129,163,149,35,43,90,210,37,201,233,146,237,143,193,7,142,15,44,237,106,233,51,234,21,76,2,206,74,176,26,139,162,140,119,2,43,83,90,215,53,37,178,199,239,196,44,233,15,16,122,87,151,140,221,212,78,87,61,231,81,11,16,55,108,78,31,179,2,102,77,128,227,71,118,124,44,10,161,6,246,234,105,16,79,40,148,90,113,123,41,138,0,100,27,235,108,233,156,102,31,192,113,200,114,233,12,108,235,92,196,31,202,73,141,187,230,144,178,0,72,134,133,61,126,223,120,174,32,209,135,183,32,155,249,81,77,118,124,152,36,72,82,124,84,50,48,148,106,244,215,84,92,157,226,209,51,201,44,179,133,37,136,67,202,139,92,134,149,175,153,184,97,12,226,128,230,98,241,79,0,183,109,156,180,175,126,182,237,171,101,185,46,4,2,79,70,33,219,143,144,17,186,82,148,230,238,254,213,114,60,254,245,138,149,44,186,69,187,219,25,93,105,146,70,223,127,79,110,99,88,155,74,63,175,98,100,174,230,19,249,236,35,91,0,70,48,65,1,70,87,236,172,248,41,64,128,76,92,130,7,0,81,211,148,79,149,197,85,48,145,218,196,182,179,5,43,30,122,206,35,49,40,71,47,198,119,243,250,76,238,99,243,171,111,131,106,58,38,184,222,227,171,240,119,28,99,21,114,221,147,57,197,98,112,116,124,59,103,178,104,67,216,173,21,7,102,197,101,124,92,150,69,25,189,24,195,198,73,166,14,66,159,185,67,191,117,188,218,102,196,68,130,238,146,59,118,27,191,103,156,211,75,160,123,226,4,125,234,111,228,103,131,191,250,167,158,173,173,110,61,222,155,213,125,84,166,137,36,58,187,3,80,153,48,169,11,130,7,89,100,75,38,130,166,217,137,118,30,101,154,27,24,252,166,181,109,25,65,152,33,207,132,92,203,177,154,174,32,219,150,19,216,16,176,133,81,3,134,124,44,110,142,138,117,142,89,88,181,138,25,139,38,228,94,29,141,141,71,9,168,101,224,149,128,240,166,113,212,198,97,207,181,38,109,76,150,113,209,152,42,217,4,49,169,194,8,254,89,35,116,182,176,77,42,173,6,239,97,219,47,233,118,48,212,152,230,139,194,15,90,131,200,201,199,149,224,69,245,147,90,40,123,165,17,248,87,139,98,89,220,0,105,200,88,83,100,0,241,239,16,70,35,10,111,186,224,251,156,113,10,211,125,167,120,103,111,5,38,197,239,233,237,47,131,234,38,112,2,188,46,154,152,147,22,197,3,106,18,143,215,53,133,188,173,105,54,50,69,82,16,141,58,120,68,166,205,88,39,178,71,197,101,214,49,20,105,66,252,50,27,212,91,55,153,115,52,66,91,249,206,64,9,93,221,119,15,246,117,74,18,156,132,81,221,231,40,48,52,245,104,15,252,25,16,150,78,143,170,121,122,165,73,29,250,40,84,224,208,127,2,7,253,161,148,215,81,81,141,184,139,10,181,155,240,178,83,62,219,240,233,18,92,140,10,22,156,205,214,136,245,102,32,167,161,188,123,31,135,56,197,207,172,189,0,247,245,17,49,115,182,58,52,133,99,119,168,145,91,221,171,139,58,146,250,211,50,69,181,208,19,125,118,204,138,71,164,77,114,32,62,174,51,22,85,11,75,251,181,173,118,233,250,219,81,53,39,158,49,113,82,148,115,150,88,180,75,205,87,59,175,142,82,254,196,59,60,8,135,35,133,210,181,166,73,162,73,113,56,223,103,138,107,176,246,169,245,192,118,89,37,136,55,115,173,185,160,167,62,179,130,126,150,99,6,44,240,238,159,162,21,43,89,70,81,75,49,143,4,147,6,30,105,73,29,255,5,86,173,133,19,12,194,206,65,183,221,134,223,191,243,106,192,44,169,239,202,74,198,193,154,115,153,255,171,128,9,203,144,160,194,183,144,16,163,144,74,106,34,44,242,154,17,172,252,94,51,249,96,130,78,113,9,8,210,85,6,54,137,114,198,183,205,66,226,10,54,152,64,12,173,110,65,217,237,60,91,39,12,188,62,44,128,49,16,236,57,149,117,163,140,188,121,13,116,128,137,230,34,38,78,109,231,74,90,185,43,33,86,124,119,103,103,142,193,110,90,196,84,96,86,159,210,60,206,153,216,201,118,230,171,157,67,254,219,223,126,75,86,63,34,95,41,58,4,1,41,183,228,37,156,42,172,77,151,64,160,147,51,186,92,249,114,246,255,169,38,91,123,78,101,186,125,33,195,64,203,237,181,204,78,60,36,173,42,228,45,99,45,34,227,14,67,136,81,156,146,131,128,145,25,255,19,44,225,97,178,76,243,79,121,42,118,53,202,221,105,242,175,248,80,194,153,16,220,198,162,86,235,179,9,47,198,91,91,26,223,185,189,200,185,66,188,181,53,142,207,138,119,197,13,178,9,232,4,57,17,166,250,216,25,73,32,115,73,81,98,217,8,20,160,4,91,134,26,183,82,230,193,184,231,129,33,132,134,170,28,236,127,211,255,247,18,39,217,58,62,48,59,197,232,92,135,188,210,208,14,150,204,182,47,8,57,167,38,5,219,173,32,190,18,215,109,211,202,225,165,186,18,209,230,211,248,3,30,228,235,205,33,159,71,253,103,47,35,99,19,230,115,179,212,255,102,188,104,34,240,179,114,205,8,40,121,123,91,161,40,93,222,62,121,226,128,199,196,134,141,152,62,20,226,12,10,57,30,116,124,42,168,66,94,130,223,17,87,178,121,104,21,108,82,8,176,95,107,196,81,19,101,152,219,173,169,238,234,33,150,107,217,246,135,57,78,204,235,136,187,230,234,139,241,157,167,193,233,254,206,130,184,247,206,24,15,99,169,108,71,99,183,226,57,203,198,157,85,227,153,89,176,47,145,172,249,6,32,103,0,209,93,174,157,49,172,5,64,204,35,255,145,149,4,53,164,107,14,85,60,168,102,196,242,38,160,174,165,29,170,235,83,0,20,165,185,154,210,20,112,181,60,60,210,160,22,73,6,103,53,229,35,91,101,116,206,206,116,199,98,164,159,184,153,188,30,28,120,66,106,71,170,94,142,149,56,114,60,251,249,235,29,151,119,245,208,217,233,217,13,222,63,232,220,144,154,6,188,191,193,198,240,82,78,28,80,166,147,231,66,10,187,53,21,124,191,236,57,12,221,184,182,216,169,15,110,124,32,79,187,186,182,181,88,36,77,130,189,72,191,38,40,152,82,17,152,24,96,81,172,42,4,157,134,165,37,113,142,212,26,54,91,66,172,254,23,107,184,104,154,139,191,254,88,85,99,32,174,154,73,4,209,100,187,209,120,251,56,25,62,133,141,65,230,193,149,87,193,219,45,125,235,109,229,1,129,102,151,170,111,90,198,31,26,145,115,177,29,117,94,132,202,194,209,66,95,204,96,102,53,176,42,42,115,151,121,145,195,84,145,254,161,18,52,56,235,186,229,187,231,162,222,175,133,230,201,112,50,144,6,65,211,92,21,18,50,171,241,244,170,187,243,116,88,44,167,11,141,103,69,179,168,107,235,104,183,78,45,139,107,60,89,44,175,152,106,92,207,233,6,34,43,125,158,227,131,227,6,150,142,42,151,90,94,214,118,96,7,120,187,27,13,235,141,112,150,52,10,226,220,53,213,51,54,245,133,147,6,0,13,57,44,75,186,137,234,58,73,93,240,182,0,157,214,26,153,137,225,101,142,190,173,122,91,22,235,213,107,83,147,194,75,43,29,235,157,82,113,53,137,77,209,244,229,62,249,75,93,141,113,201,80,219,143,236,21,255,193,54,158,91,143,222,218,170,201,10,220,75,151,175,83,96,117,210,211,103,137,154,159,43,201,26,154,176,251,171,82,95,170,216,234,102,74,246,146,100,95,129,235,253,7,174,54,95,117,149,34,125,27,49,177,254,174,188,236,236,41,177,122,200,234,170,181,162,222,120,64,14,251,139,166,78,74,17,174,160,198,86,9,212,45,94,248,40,237,171,74,168,109,248,3,249,208,54,134,84,37,108,29,76,177,70,249,127,77,124,154,38,182,11,189,143,82,199,238,226,154,171,137,173,37,65,126,159,160,137,193,11,134,7,233,97,11,203,64,101,108,193,13,215,72,9,250,100,181,108,19,254,184,91,132,206,253,12,80,205,163,43,54,255,221,42,175,208,158,6,186,71,171,138,92,168,174,4,244,232,204,179,104,116,184,136,100,246,216,151,161,215,197,36,247,226,111,160,70,121,123,7,80,164,91,111,128,168,123,55,61,60,232,230,74,39,41,86,243,175,18,114,73,114,106,42,82,170,76,48,188,64,101,192,157,237,170,118,251,142,242,87,107,182,123,95,105,174,196,61,88,255,252,179,166,117,72,113,155,229,9,215,183,62,40,75,218,105,116,191,36,213,17,144,111,198,7,58,233,74,236,232,126,67,126,103,27,213,194,75,86,52,45,59,111,162,37,81,110,31,102,4,97,170,212,220,83,0,30,22,167,111,236,214,18,231,205,39,115,134,238,10,54,164,226,114,243,221,26,217,254,227,98,26,88,132,172,58,17,52,75,100,246,190,170,186,191,191,14,155,29,13,158,246,80,212,167,199,190,23,206,60,76,125,194,177,121,29,105,56,93,114,172,4,239,234,190,212,78,88,225,65,175,130,29,114,179,245,98,145,222,54,208,3,245,117,83,101,93,13,177,106,121,117,137,80,185,66,205,38,116,223,154,39,114,250,105,251,65,196,237,251,122,175,140,98,39,148,151,207,218,96,1,121,21,193,238,62,156,172,64,183,69,240,218,141,234,199,167,32,62,185,112,38,33,173,114,84,49,76,118,74,104,66,13,144,119,143,158,157,235,249,179,102,17,73,143,187,111,30,217,162,35,205,157,187,232,89,73,165,171,171,251,55,20,72,123,220,0,42,251,237,90,75,135,149,195,20,119,37,153,97,120,55,180,226,215,235,101,67,55,62,70,231,78,237,101,209,209,154,255,97,56,145,48,65,211,44,168,161,85,5,172,46,134,183,142,212,163,44,157,85,49,93,84,54,78,194,121,27,237,235,113,101,230,39,96,168,169,146,146,214,148,51,31,39,220,219,20,231,101,193,216,188,213,244,161,212,29,111,145,173,87,190,215,234,6,186,8,161,69,217,196,84,242,178,72,87,139,77,163,52,25,222,24,250,116,110,159,121,8,122,192,5,140,71,53,59,120,29,232,90,231,93,253,234,250,124,218,96,170,199,26,146,37,249,207,174,191,207,124,224,197,127,194,50,118,73,5,115,138,194,61,61,145,95,42,87,109,52,123,118,102,154,78,105,82,189,148,137,85,201,214,123,143,85,244,75,171,119,12,236,6,170,46,6,157,164,185,108,79,210,29,225,200,32,102,12,213,197,198,84,158,221,50,196,243,223,157,123,87,121,104,147,51,96,58,73,171,239,178,212,88,134,191,67,34,185,81,117,199,35,50,53,62,176,243,217,26,215,222,173,149,251,214,129,194,162,194,174,191,184,50,21,108,9,32,141,59,175,216,94,218,124,155,5,201,196,233,186,48,197,228,75,103,96,215,212,170,248,65,142,187,38,49,247,184,155,49,38,22,206,60,28,109,207,29,187,25,138,151,212,87,241,84,95,87,12,84,66,249,57,24,183,227,198,180,241,127,65,53,12,36,230,184,205,241,193,137,105,138,115,173,227,48,37,198,79,208,56,249,163,194,230,215,232,170,211,197,106,208,212,162,227,121,53,225,193,175,126,188,149,243,203,109,11,253,54,169,63,200,50,160,224,161,219,44,100,36,136,183,96,245,206,177,205,239,185,53,190,79,195,143,130,132,244,169,179,47,178,13,196,238,189,74,237,195,53,55,193,50,198,245,62,172,147,189,182,233,54,21,22,255,27,76,149,245,126,92,63,245,8,47,11,211,188,249,50,119,189,238,148,207,88,206,83,217,216,89,213,38,173,65,36,126,207,166,224,177,61,208,248,250,84,107,201,154,78,233,196,158,163,45,122,164,14,161,174,30,106,214,251,186,145,113,71,157,229,88,151,62,16,214,153,73,59,53,88,227,109,41,67,3,34,174,102,199,142,33,120,213,228,46,218,90,236,46,65,243,219,193,32,187,18,251,101,174,66,194,188,179,151,109,190,195,229,223,235,155,148,175,50,250,140,91,214,8,7,236,124,128,136,244,236,211,94,107,216,118,173,250,246,147,54,43,239,121,190,96,89,61,188,245,122,229,214,75,122,86,161,84,251,124,133,195,118,27,253,47,58,247,125,252,64,181,101,96,45,127,216,7,101,2,249,16,31,31,216,223,44,209,193,170,191,133,207,134,182,63,222,50,174,107,103,50,253,117,156,190,122,135,92,122,250,89,35,211,148,111,200,43,87,110,90,62,185,251,209,24,98,47,83,93,25,169,153,241,27,217,102,63,23,209,36,62,41,202,99,138,93,59,218,220,52,62,104,35,67,1,174,75,209,14,202,129,247,138,79,250,148,75,139,119,10,141,233,210,176,131,27,245,36,200,64,160,197,73,87,162,224,87,86,52,166,170,114,216,76,114,36,71,168,213,8,214,27,206,200,215,17,220,170,45,182,33,225,55,18,134,188,13,103,11,153,31,85,51,26,177,190,162,224,255,100,152,236,61,140,234,248,34,208,216,84,85,253,76,203,135,17,22,95,85,221,141,213,155,229,238,14,13,86,163,238,160,28,179,255,252,7,88,145,189,127,243,84,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("53dfc9d5-8345-4de0-994f-2835d022341e"));
		}

		#endregion

	}

	#endregion

}


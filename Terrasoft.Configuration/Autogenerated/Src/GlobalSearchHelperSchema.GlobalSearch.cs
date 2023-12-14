﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchHelperSchema

	/// <exclude/>
	public class GlobalSearchHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchHelperSchema(GlobalSearchHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eeb8f245-6054-4f17-89f4-1723a10bad64");
			Name = "GlobalSearchHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6f142301-7a5f-41f6-815b-40f61aa5d442");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,61,107,115,220,54,146,159,181,85,251,31,16,94,118,139,147,76,209,78,170,246,139,101,141,79,214,35,158,59,43,246,121,156,205,7,199,81,209,51,144,196,53,135,28,19,28,61,86,158,255,190,141,119,227,65,14,37,43,185,220,214,109,213,57,26,16,104,52,186,27,253,66,3,87,229,75,202,86,249,156,146,183,180,105,114,86,159,181,217,65,93,157,21,231,235,38,111,139,186,202,126,40,235,15,121,57,163,121,51,191,120,65,203,21,109,254,252,167,219,63,255,105,103,205,138,234,156,204,110,88,75,151,187,222,111,0,81,150,116,206,199,179,236,7,90,209,166,152,7,125,94,22,213,167,160,241,45,189,110,179,55,244,124,93,230,205,209,245,170,161,140,113,32,182,223,185,64,231,201,147,131,122,185,4,236,94,214,231,231,208,108,191,15,89,198,97,91,199,7,52,52,214,142,135,198,190,255,184,46,178,25,109,46,139,57,61,169,23,180,204,14,243,54,135,217,219,38,159,183,118,192,81,213,22,237,205,108,126,65,151,240,181,92,47,43,178,231,205,158,137,62,5,101,89,216,249,110,75,148,99,126,106,139,146,117,45,213,76,214,217,225,24,240,175,155,190,30,179,214,161,153,196,218,50,127,235,2,109,215,56,157,6,82,40,134,223,73,93,21,28,123,44,28,74,200,14,139,252,188,170,89,91,204,59,86,198,69,107,155,36,68,39,240,144,61,124,222,249,201,97,29,244,130,126,255,209,208,115,78,180,131,50,103,236,9,137,109,60,232,181,90,127,40,139,57,153,243,78,209,62,59,183,162,159,5,7,251,167,205,171,22,64,190,110,138,203,188,165,242,251,74,254,32,115,254,157,20,85,75,246,23,139,130,163,147,151,111,232,188,110,22,236,160,94,67,243,30,249,254,241,110,56,130,181,124,237,228,184,40,169,228,197,143,160,75,102,235,179,179,226,26,134,36,188,61,233,30,246,146,230,11,119,168,30,196,191,36,187,106,13,180,90,200,101,184,107,58,46,104,185,232,90,144,154,225,148,26,208,14,26,142,124,169,78,86,140,76,183,142,221,68,78,207,187,183,153,25,220,192,26,234,170,188,33,160,202,232,53,57,109,232,170,4,37,251,162,56,191,40,225,255,90,217,188,71,42,122,37,187,164,255,153,188,187,221,188,79,70,187,238,74,64,60,230,22,218,20,212,29,57,45,225,159,61,2,127,158,228,85,126,78,27,208,176,45,215,131,180,73,19,140,181,7,204,64,145,244,121,247,158,156,46,232,89,190,46,219,25,48,155,206,228,62,228,228,98,0,254,150,36,92,133,129,6,72,198,36,217,159,207,185,40,36,100,227,128,156,158,80,128,53,127,67,87,117,211,210,134,156,46,221,223,123,82,150,165,30,185,225,120,62,245,134,76,210,209,22,86,191,110,106,16,107,190,229,17,187,45,10,92,110,103,23,245,186,92,156,228,237,252,226,53,109,230,192,82,194,45,212,206,206,57,213,127,237,52,180,93,55,124,51,248,123,47,3,165,48,163,109,11,36,225,182,170,253,123,94,174,105,250,19,163,13,116,171,36,81,128,2,152,176,225,124,64,163,199,146,218,59,27,254,239,6,163,248,161,174,75,2,0,167,21,189,6,74,72,24,15,143,161,157,193,17,130,49,57,203,75,70,61,236,98,248,189,172,231,121,89,252,51,255,80,82,12,225,13,101,32,35,191,9,190,189,51,14,192,156,51,31,100,98,153,55,55,114,39,30,74,129,254,153,242,77,246,219,10,129,154,202,153,94,206,11,136,255,109,11,210,82,7,253,254,216,202,121,13,154,223,247,160,217,165,255,186,218,3,244,139,51,146,118,41,75,178,7,186,111,93,150,35,221,121,167,187,103,168,67,58,80,144,186,100,71,175,199,16,176,87,99,59,107,31,166,131,234,22,72,76,23,154,92,234,39,113,233,239,255,188,37,64,154,93,194,248,63,91,102,19,6,187,89,243,245,242,249,132,189,151,61,30,61,122,68,158,178,245,146,75,220,100,10,238,71,193,183,15,232,235,92,88,146,66,24,122,240,229,235,51,210,94,80,229,35,60,101,20,254,108,232,217,94,18,186,11,201,163,201,88,67,150,126,10,31,200,86,116,94,156,21,176,168,53,172,130,27,110,181,140,236,233,35,61,189,193,103,149,55,249,146,84,96,55,246,146,181,179,232,100,130,230,118,233,1,243,26,116,1,168,128,33,64,42,247,38,196,212,147,111,226,78,165,5,169,189,40,88,230,245,220,243,250,238,14,224,56,88,169,139,186,211,195,248,111,122,35,246,220,235,188,104,158,74,115,58,38,47,11,214,170,31,147,9,140,163,176,40,250,134,239,52,240,163,42,233,89,165,71,51,163,226,86,192,102,74,40,211,127,142,181,227,98,253,22,23,40,41,225,199,171,51,229,155,77,23,122,205,151,185,96,145,156,129,41,175,226,176,16,107,5,78,117,32,168,54,222,45,158,205,155,64,110,35,105,242,197,118,134,205,55,101,214,107,75,237,216,17,249,235,95,201,87,46,225,193,253,5,167,98,221,64,151,163,10,162,52,202,55,175,244,180,160,227,73,14,190,120,35,231,146,84,194,224,140,98,112,22,166,136,202,49,240,8,11,131,17,33,237,32,172,224,180,62,176,95,179,227,162,97,173,82,27,158,254,219,74,192,62,100,122,217,188,21,50,66,31,177,152,98,79,57,92,67,6,66,185,107,58,75,78,78,23,44,222,87,72,175,237,205,215,81,181,142,43,110,103,131,112,92,56,175,105,204,211,7,51,163,220,204,0,16,0,241,228,1,123,222,218,119,61,46,170,197,84,41,130,231,2,112,234,99,51,178,2,232,192,255,202,179,33,109,115,99,204,137,216,19,235,134,247,230,104,191,40,90,78,9,203,133,12,123,26,25,255,156,253,124,65,27,154,130,87,62,177,212,203,132,15,12,138,42,189,206,96,195,141,178,183,53,103,149,49,52,59,78,48,113,6,51,153,184,245,126,107,167,254,170,245,246,86,249,2,59,69,38,45,25,19,80,250,41,39,105,167,96,248,84,147,19,44,197,110,116,156,153,253,178,200,57,209,58,172,45,223,204,97,127,53,203,152,68,22,162,247,223,93,212,19,215,80,254,170,198,62,103,77,215,29,205,196,189,201,117,54,171,215,224,155,27,14,194,246,72,187,86,57,26,33,16,51,202,83,18,82,16,52,148,119,93,35,223,91,145,216,104,24,27,189,96,213,178,33,115,30,42,144,244,232,122,78,87,194,36,209,107,228,249,64,60,151,29,53,77,221,28,215,205,50,111,33,20,84,2,206,109,234,19,114,251,120,51,38,211,5,39,40,152,100,238,18,220,126,183,33,122,50,3,19,154,191,223,36,99,199,122,72,106,102,255,85,23,85,202,195,184,177,149,236,17,244,188,206,78,40,99,32,138,174,223,212,161,44,99,74,242,178,46,22,100,127,181,2,43,186,127,153,23,37,247,228,165,74,135,41,82,199,120,229,254,119,179,160,113,152,55,106,148,66,213,13,194,71,217,137,216,199,30,69,171,41,188,197,112,25,70,240,109,96,144,148,154,211,71,67,203,6,229,178,65,51,71,28,132,74,5,97,152,9,36,83,33,23,245,21,248,45,35,77,93,172,159,126,39,189,33,183,142,68,240,222,138,253,30,42,200,206,248,7,83,65,14,147,173,101,48,219,255,225,60,24,242,204,234,148,1,118,199,118,222,81,154,231,237,205,138,242,56,9,217,125,240,177,176,132,186,214,9,9,156,85,74,228,201,23,98,113,23,45,138,70,19,254,63,64,55,182,140,72,183,174,85,109,211,190,209,53,27,102,119,171,156,108,127,177,120,147,87,231,52,13,132,193,211,255,46,93,255,192,154,29,147,176,71,185,43,189,142,221,226,33,100,242,53,161,66,242,158,10,49,234,112,139,52,148,175,168,3,149,175,169,171,204,19,210,102,71,213,130,253,92,180,23,81,117,54,34,159,63,59,30,244,94,36,3,29,195,234,249,106,233,90,24,197,65,24,89,194,55,183,21,252,126,16,33,176,65,240,175,70,244,20,207,42,63,137,61,177,139,191,222,69,251,115,18,185,202,255,52,208,116,92,205,53,46,194,50,44,236,90,142,18,217,233,194,224,56,93,72,163,187,227,132,5,104,42,245,25,49,187,39,246,172,63,252,3,150,52,73,71,106,212,113,189,174,22,202,124,116,143,210,153,106,24,135,67,81,107,142,204,180,238,98,51,140,148,29,115,230,78,234,141,193,40,217,49,102,115,216,113,192,128,125,175,213,110,12,135,25,32,242,251,77,147,223,164,40,132,217,150,246,116,252,17,9,203,172,82,36,250,205,216,35,244,49,117,4,105,76,126,88,23,139,236,117,222,48,112,13,20,59,71,227,96,49,90,53,156,213,13,205,185,30,67,134,190,168,194,238,70,179,97,234,115,37,161,108,110,38,149,19,198,250,29,250,242,222,232,79,24,98,206,66,152,196,112,76,180,221,198,108,26,59,140,246,252,84,66,75,240,248,110,239,185,6,235,144,100,83,246,178,174,63,174,87,124,95,34,175,4,176,148,237,72,156,124,100,99,232,121,152,9,64,119,6,241,160,148,18,255,2,168,67,10,150,181,100,6,98,234,238,129,177,82,93,187,88,197,186,93,6,166,74,212,126,239,147,88,199,5,118,164,87,204,206,37,24,230,150,22,73,54,77,143,170,245,146,54,28,210,211,240,128,124,210,201,107,177,147,216,39,165,103,240,200,255,89,211,70,71,3,178,69,173,29,186,107,107,38,250,28,104,65,217,47,175,114,158,125,231,219,29,0,182,13,206,163,128,242,190,4,253,93,22,198,5,62,201,87,219,212,155,73,91,187,18,220,43,188,28,61,35,84,233,60,195,78,110,20,9,185,73,213,254,116,250,111,204,122,193,164,181,202,232,167,252,247,1,160,211,82,217,202,13,235,107,158,164,165,188,75,42,27,15,234,37,184,251,5,171,43,190,113,178,163,79,235,188,28,91,4,223,212,181,114,150,3,71,93,152,45,80,72,154,191,35,87,228,130,138,138,163,235,150,86,162,18,36,19,236,48,191,229,108,28,190,31,67,138,37,196,218,93,19,11,72,68,9,166,156,217,190,12,161,12,126,35,155,170,203,200,250,155,45,226,45,112,214,95,152,253,110,140,177,129,109,237,8,234,229,199,83,28,200,194,67,42,2,75,249,252,140,251,110,140,167,15,179,89,155,55,173,116,162,142,102,166,110,32,83,11,124,221,80,238,73,41,197,196,243,189,114,148,113,188,146,98,145,24,31,25,111,214,233,15,77,189,94,129,172,135,150,125,66,206,249,55,26,80,209,70,101,193,82,50,1,238,249,141,244,209,129,199,114,44,23,170,231,55,60,66,185,230,120,1,103,149,15,47,20,78,212,214,249,160,249,166,235,194,103,228,36,23,229,72,199,55,242,129,9,226,232,24,251,235,228,182,147,164,155,44,9,194,109,195,94,99,252,3,240,56,80,113,226,1,146,101,25,15,9,174,71,129,7,130,145,63,200,87,234,124,196,144,80,53,165,254,234,2,212,94,114,12,196,9,184,118,76,94,120,173,169,183,2,3,162,199,237,18,170,199,159,123,28,76,216,5,234,192,247,74,66,80,92,19,27,179,60,55,4,112,8,50,214,223,23,5,3,230,73,123,197,125,223,104,21,135,225,112,148,5,62,17,4,159,181,137,143,24,233,77,228,160,79,55,0,145,153,194,84,4,144,228,195,13,249,72,111,200,21,236,61,194,68,152,147,153,193,253,231,116,48,140,239,88,25,27,37,19,16,84,9,17,131,194,167,114,2,128,84,206,108,114,104,81,128,78,186,21,107,70,21,181,69,118,166,250,226,204,175,55,150,44,138,145,11,124,157,183,96,96,42,167,68,38,249,53,125,247,107,246,254,219,95,126,201,196,127,71,240,71,246,205,215,248,252,129,147,99,207,5,97,248,227,204,9,124,248,250,59,61,18,79,44,63,119,78,127,10,211,158,162,73,149,193,138,140,197,243,226,217,54,209,98,165,96,7,170,246,133,161,223,80,103,102,123,4,9,216,204,110,152,156,46,65,254,206,148,29,22,172,45,42,207,177,17,174,0,104,76,26,134,167,51,89,158,41,190,102,156,184,194,215,227,63,121,196,239,21,32,8,237,133,231,19,195,166,45,93,234,234,175,176,63,79,232,36,40,232,147,196,49,213,147,174,27,148,40,218,97,129,224,66,218,213,253,29,47,163,16,132,121,242,211,116,241,4,83,10,126,191,23,78,18,134,53,199,117,141,3,189,11,59,26,235,34,113,40,103,146,202,194,197,120,213,168,18,13,157,120,2,224,220,171,194,129,131,206,165,167,118,85,210,147,227,233,12,36,41,17,209,116,143,204,200,51,167,185,119,46,135,230,106,186,39,36,249,169,250,88,213,87,26,124,210,231,31,161,248,5,121,60,227,88,65,172,14,108,250,114,1,110,212,35,53,104,79,4,226,68,69,206,137,57,74,138,163,32,117,23,29,53,188,123,111,21,184,180,114,114,90,235,234,57,1,217,40,226,157,25,146,131,191,100,26,179,151,180,58,7,77,59,33,143,71,54,126,181,171,122,103,145,123,79,96,98,51,80,25,12,62,195,87,78,12,142,243,179,118,176,61,220,216,81,135,52,166,194,211,152,107,29,67,32,104,99,18,91,86,196,76,249,156,198,65,238,23,176,122,27,235,46,149,65,54,252,136,132,213,136,23,95,41,203,60,101,63,2,35,94,53,71,203,85,123,147,10,32,184,206,192,206,229,228,44,96,158,75,123,90,222,183,250,48,87,240,27,210,160,20,147,253,221,82,98,75,166,2,209,195,25,234,133,14,97,118,24,165,73,120,93,187,24,38,114,250,5,35,211,37,216,19,57,177,251,141,7,7,34,5,245,182,185,145,89,40,52,169,244,199,97,137,235,150,156,90,14,4,61,136,196,109,55,252,124,232,58,102,182,151,68,185,143,151,8,76,183,57,134,125,31,217,235,195,184,169,215,99,32,53,178,126,114,143,8,71,60,19,210,247,212,11,253,57,145,189,232,44,26,213,205,135,30,139,185,39,97,167,145,12,7,130,247,194,113,82,35,129,98,204,66,169,77,37,130,126,38,35,174,49,198,111,228,84,153,32,49,242,103,243,15,3,109,218,9,230,242,207,46,20,41,99,241,70,12,250,8,205,46,7,123,90,64,212,45,197,70,242,126,117,171,58,5,200,129,235,5,156,189,53,68,224,221,200,38,212,147,145,197,244,8,92,176,36,243,49,186,182,88,202,192,58,174,16,112,202,248,228,136,129,9,167,105,114,123,123,155,140,54,105,246,205,179,145,247,101,179,217,192,23,228,103,53,252,243,202,241,126,253,25,144,103,179,52,97,160,28,151,185,232,171,136,40,25,199,87,129,118,128,2,148,169,107,7,123,200,58,162,210,17,67,148,219,205,110,72,105,3,35,103,237,83,129,8,108,50,29,42,47,185,224,110,9,227,150,90,61,65,160,230,135,207,61,213,15,157,134,117,160,110,119,178,65,3,212,203,3,107,131,223,85,25,116,234,2,95,229,245,31,51,220,37,30,135,112,188,75,0,37,167,187,205,123,96,88,227,214,246,110,236,11,129,74,21,17,154,180,7,102,180,142,43,93,11,42,121,172,206,250,31,134,193,113,175,11,207,171,242,32,159,63,247,173,104,202,32,74,67,126,134,227,174,186,197,59,10,246,193,80,98,245,148,142,132,39,170,59,30,127,64,17,133,60,212,86,226,203,200,26,174,67,83,87,103,166,60,255,7,19,85,153,32,100,227,11,78,60,19,3,171,29,244,134,158,209,134,86,115,93,201,163,104,49,181,125,145,229,196,16,80,56,131,154,135,187,134,110,22,21,246,88,238,205,59,156,113,254,160,62,238,97,246,57,139,141,177,74,231,255,134,179,172,107,29,158,19,212,233,25,108,241,71,253,72,231,127,213,84,232,202,139,47,85,25,74,152,101,121,136,61,74,202,166,21,32,92,228,85,123,0,160,214,13,157,158,87,117,67,193,158,83,68,205,8,169,244,145,203,39,48,22,173,200,133,201,172,154,188,226,22,124,76,249,61,28,113,171,77,150,189,140,197,197,156,21,240,239,199,245,82,254,56,107,234,37,38,34,43,254,41,147,5,102,16,249,182,227,210,36,62,19,12,208,146,234,35,130,175,218,26,199,48,47,47,180,227,255,249,86,163,68,190,17,243,107,170,73,84,112,139,224,132,78,11,206,228,79,83,111,97,195,10,221,193,56,116,110,109,133,226,110,136,117,76,58,95,228,236,98,70,109,141,39,208,91,244,149,215,51,83,81,209,35,110,164,137,86,76,202,188,44,69,39,190,243,76,7,242,76,11,141,170,151,74,110,31,111,126,253,91,194,125,35,123,116,178,175,134,242,52,84,172,29,213,123,8,52,212,138,125,92,111,13,14,99,50,115,103,253,134,79,251,221,99,111,94,224,193,7,158,219,227,2,172,19,215,138,104,114,34,225,161,124,13,163,241,40,199,200,48,57,142,175,105,20,25,233,12,228,55,225,85,74,88,142,85,142,55,26,172,120,37,97,244,57,168,229,141,186,221,169,110,122,202,171,99,58,199,204,228,55,124,76,34,42,119,143,102,39,176,115,10,225,68,11,254,76,200,210,105,40,168,218,196,206,81,190,42,206,158,97,168,6,226,241,186,18,205,19,114,166,254,50,89,13,231,96,142,50,111,110,126,50,23,204,110,140,137,116,194,99,87,242,4,135,211,56,78,193,36,206,145,184,3,83,227,157,26,180,199,33,221,162,65,66,23,41,97,175,156,248,235,209,28,249,228,111,151,96,229,218,5,137,3,247,234,141,156,139,167,134,102,1,76,33,133,82,57,248,196,215,54,91,235,47,129,160,246,70,142,245,54,243,182,191,188,189,169,123,157,20,85,177,92,47,209,221,89,24,17,185,185,203,195,62,109,128,159,57,27,16,32,160,254,186,207,19,30,233,134,112,54,127,73,148,205,213,76,117,106,114,238,176,120,57,160,151,2,178,198,149,36,243,166,102,236,84,238,199,68,127,124,181,162,77,222,214,252,54,116,146,87,139,100,27,217,248,201,203,200,195,221,137,112,125,212,183,132,166,221,187,162,187,2,39,34,2,75,111,171,32,233,92,97,208,166,196,220,245,44,15,177,83,107,165,211,29,26,75,121,229,67,125,22,7,212,152,196,82,94,34,46,241,22,146,29,43,21,92,221,232,163,23,83,128,156,75,31,206,250,172,93,99,65,118,34,150,235,246,59,94,182,43,128,140,123,238,41,143,134,38,216,163,10,169,91,177,154,11,133,161,162,210,42,87,119,69,210,175,1,129,129,84,98,29,177,15,234,202,242,94,244,34,243,166,183,90,134,151,220,242,67,191,183,181,168,226,144,248,155,138,153,253,243,243,134,158,231,114,37,162,18,131,203,34,106,5,165,141,126,97,41,60,83,128,1,43,49,176,227,92,141,47,74,249,193,123,209,199,43,144,238,180,32,61,193,68,115,57,85,181,24,81,45,51,250,17,13,7,113,153,227,194,250,67,251,230,209,203,24,174,158,113,33,241,70,55,234,147,203,231,44,213,120,218,32,214,79,239,235,30,42,233,246,109,20,207,93,183,171,64,3,122,122,34,63,6,153,231,101,234,1,118,81,121,0,23,149,59,35,198,81,87,79,43,152,54,199,22,118,139,242,88,214,141,175,25,117,124,27,117,130,237,200,135,22,118,215,118,154,141,147,226,148,102,196,222,70,13,246,39,228,54,8,237,226,35,18,203,96,226,165,99,135,34,244,111,252,131,152,104,78,37,220,222,216,47,42,245,238,116,125,191,1,211,126,57,202,232,22,166,227,122,221,251,154,83,135,203,37,51,138,177,137,124,139,210,227,12,135,146,21,122,187,29,206,173,245,101,35,246,250,30,228,27,126,57,29,189,69,192,123,116,213,13,217,74,82,93,26,13,255,81,164,55,227,250,75,134,108,78,37,153,40,227,74,152,116,29,84,37,80,71,185,16,122,3,96,75,1,111,242,104,18,20,20,233,215,21,46,139,166,93,231,37,217,86,3,220,95,156,223,121,157,196,22,219,127,217,85,140,32,243,228,220,83,113,175,205,73,137,84,85,152,138,45,96,162,14,242,234,13,205,117,149,10,190,244,163,211,58,202,26,240,67,214,206,163,217,231,5,63,114,112,83,111,142,112,69,69,229,224,130,206,63,18,216,77,243,188,18,15,6,233,124,225,64,33,145,2,209,45,36,36,144,18,60,90,206,149,232,131,145,174,33,17,193,226,54,96,136,244,8,91,225,18,88,27,22,131,249,192,140,90,45,220,122,89,12,180,229,214,160,201,39,154,130,33,12,91,92,29,124,73,47,105,153,98,36,20,225,81,218,79,182,203,161,175,244,236,118,52,63,243,18,11,115,37,207,226,249,213,94,100,101,118,124,118,72,171,155,173,18,34,148,9,242,114,132,175,193,6,43,17,238,27,152,107,136,206,251,32,142,151,103,122,224,103,66,6,73,130,178,234,216,143,228,64,230,182,118,139,150,57,127,250,77,165,184,240,98,182,138,79,4,56,39,200,17,246,120,132,87,203,43,157,34,203,33,238,250,253,187,108,206,199,12,141,87,21,207,116,17,182,161,232,175,151,103,106,181,186,98,246,206,124,235,224,153,91,231,206,41,237,77,52,140,107,67,138,197,39,19,193,73,85,158,237,179,209,204,119,23,3,210,61,149,100,171,187,58,195,217,173,87,206,13,67,123,46,220,58,53,236,50,44,49,5,235,211,197,118,85,205,153,42,175,79,48,89,182,43,212,181,188,167,249,71,97,43,126,0,224,33,120,231,60,40,128,45,125,112,115,117,8,151,6,74,130,66,154,51,72,133,1,29,130,129,102,144,26,120,224,251,7,56,30,241,234,130,102,109,189,186,18,185,50,118,165,143,13,116,147,238,195,174,228,189,141,232,53,34,132,60,186,219,32,214,226,21,22,169,103,30,236,43,59,254,211,69,248,9,27,4,71,158,235,224,6,125,15,27,103,93,238,231,238,27,172,196,125,14,29,133,107,115,250,249,179,69,91,30,12,197,42,71,228,45,236,105,117,86,235,56,117,138,158,201,82,62,138,216,64,162,2,30,98,88,114,5,129,120,85,183,178,208,148,92,93,20,220,109,230,158,17,119,20,228,158,35,96,85,151,133,124,156,54,51,41,189,29,23,97,125,246,8,173,16,99,120,167,128,15,82,200,29,157,239,238,119,215,172,204,40,111,72,57,96,133,255,140,89,207,131,8,179,226,188,2,121,158,231,250,18,21,243,216,231,222,188,244,46,136,169,33,248,37,9,237,114,133,175,69,120,183,223,156,34,85,115,53,223,210,226,33,239,181,117,17,87,251,108,142,56,154,29,224,87,137,127,65,41,249,78,231,107,43,125,15,172,216,249,34,123,55,208,91,27,171,87,234,149,86,43,222,219,158,153,252,35,181,39,153,242,97,79,114,75,14,215,198,49,6,24,71,101,190,98,116,113,82,148,101,1,49,54,80,8,240,49,135,149,42,235,35,79,145,159,175,150,58,121,168,77,104,247,162,182,26,72,96,55,81,15,156,130,119,15,2,206,31,223,147,111,38,14,52,143,38,80,79,38,97,120,139,59,6,97,188,55,32,180,100,246,100,46,154,157,233,73,234,74,41,24,124,64,23,61,93,211,239,190,218,39,95,249,86,239,124,14,54,126,204,22,59,18,11,1,59,34,245,37,71,124,15,178,0,117,34,255,16,169,168,206,165,110,63,141,100,110,246,168,235,24,50,114,30,176,61,35,212,245,90,164,110,120,221,212,115,202,88,167,11,246,240,158,99,244,153,199,46,143,49,184,58,235,65,192,254,225,187,87,31,88,93,130,226,78,249,227,146,122,101,190,115,134,221,178,100,244,94,108,71,249,198,164,222,139,193,156,2,84,20,214,112,223,127,0,54,91,53,216,191,17,175,6,145,252,158,20,119,158,233,136,121,215,253,145,66,96,254,66,228,152,251,179,227,41,21,227,144,59,173,224,14,215,31,221,183,7,121,75,71,215,22,136,211,253,78,161,248,30,29,201,19,125,56,142,232,184,130,62,233,192,113,182,22,242,238,56,133,70,225,162,106,51,174,101,251,162,90,147,233,66,143,41,246,60,47,180,253,253,42,163,185,239,31,68,216,39,119,34,190,100,244,161,156,248,219,62,248,105,12,115,163,160,251,250,113,165,46,23,244,94,119,174,156,203,5,49,166,10,175,213,133,17,119,117,157,51,7,23,208,125,21,13,74,141,177,123,104,157,47,72,245,117,170,31,46,21,60,110,139,169,33,4,20,3,99,3,205,70,4,167,212,203,215,197,237,71,207,9,182,53,36,49,232,247,200,17,222,5,219,255,103,123,143,5,218,194,180,7,225,153,73,192,68,53,51,158,83,171,101,244,68,100,44,215,76,195,68,179,206,72,133,25,232,152,52,4,46,56,46,88,40,170,216,4,174,174,108,187,42,16,176,94,28,242,14,244,148,97,245,205,143,45,32,240,217,47,75,176,0,139,180,21,167,85,232,161,6,55,129,98,30,71,138,61,237,233,143,141,148,156,168,186,18,183,146,100,119,219,100,182,170,98,107,201,135,46,212,224,184,140,113,155,46,242,112,62,244,20,136,104,20,252,135,175,250,158,29,12,94,29,76,180,64,199,68,55,227,25,175,95,154,95,42,89,172,100,159,13,20,127,207,218,124,254,241,109,147,207,221,56,78,41,35,65,145,1,90,70,164,19,241,222,13,75,159,29,53,48,80,213,136,218,11,89,186,155,76,100,4,169,234,35,122,131,117,153,192,19,228,77,38,146,246,160,89,152,200,138,81,253,228,20,235,135,161,106,178,147,137,44,10,118,0,240,111,253,163,121,97,55,104,198,1,46,246,22,66,245,106,184,120,61,124,164,16,30,23,218,204,84,246,155,151,191,35,66,13,41,142,143,213,185,247,22,224,59,240,13,108,1,215,117,82,237,152,12,23,208,31,205,112,133,42,113,42,51,229,58,200,93,138,218,31,70,120,101,42,121,190,102,109,189,188,103,218,233,158,114,29,20,176,128,116,203,106,21,157,241,208,217,238,120,189,198,239,178,71,132,131,241,127,97,135,136,28,210,214,109,210,89,149,166,130,150,63,248,46,138,149,221,185,235,235,168,183,122,208,13,197,221,148,127,215,77,21,145,216,237,203,237,151,218,248,120,145,228,48,95,190,76,122,157,196,74,124,54,169,129,59,80,81,142,200,253,165,76,255,127,126,146,46,135,123,32,16,157,178,167,106,78,182,186,141,162,141,255,239,95,123,91,9,124,255,114,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eeb8f245-6054-4f17-89f4-1723a10bad64"));
		}

		#endregion

	}

	#endregion

}


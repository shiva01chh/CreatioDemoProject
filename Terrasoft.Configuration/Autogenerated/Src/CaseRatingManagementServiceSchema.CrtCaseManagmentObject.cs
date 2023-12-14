﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseRatingManagementServiceSchema

	/// <exclude/>
	public class CaseRatingManagementServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseRatingManagementServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseRatingManagementServiceSchema(CaseRatingManagementServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("07cd0230-240d-4c09-8dec-f39bc3e6322f");
			Name = "CaseRatingManagementService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1c03a3fe-87f3-466f-a6b7-a88ed4e512f8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,27,107,115,219,198,241,51,51,211,255,112,65,59,14,56,145,64,63,146,212,149,68,186,122,198,106,109,89,149,232,106,58,178,167,5,129,163,136,10,4,232,59,64,18,171,232,191,119,247,30,192,29,0,130,164,236,164,153,198,95,100,222,99,119,111,223,187,119,72,252,41,229,51,63,160,100,72,25,243,121,58,206,188,253,52,25,71,87,57,243,179,40,77,188,125,159,211,51,248,111,114,245,214,79,252,43,58,165,73,118,78,217,77,20,208,223,125,117,255,187,175,58,57,135,57,114,62,231,25,157,110,87,126,3,172,56,166,1,2,226,222,143,52,161,44,10,106,107,222,68,201,167,218,224,89,158,100,209,148,122,128,42,242,227,232,63,130,152,218,170,115,26,228,44,202,230,11,39,188,83,22,37,65,52,243,227,134,37,226,16,111,211,144,182,79,122,187,112,128,155,69,4,24,235,46,232,168,182,96,72,239,178,250,224,132,81,63,132,129,114,198,100,255,116,106,98,50,103,24,93,52,238,29,236,45,156,58,4,86,102,17,229,77,11,128,230,22,140,56,251,58,203,102,222,238,136,103,204,151,130,132,133,176,244,247,140,94,193,47,178,31,251,156,111,145,115,224,15,31,203,21,111,232,13,141,207,64,175,96,49,21,139,123,189,30,217,225,249,116,234,179,249,64,253,62,163,51,70,57,104,19,39,76,173,37,227,148,17,110,64,34,49,130,34,113,154,94,231,51,242,41,167,108,238,105,112,61,3,222,229,129,159,249,160,183,130,198,143,48,48,203,71,113,20,144,0,137,91,76,27,217,34,150,178,43,105,150,164,119,238,5,249,197,97,79,89,58,163,12,121,185,69,78,5,10,57,95,61,159,24,40,117,159,164,227,134,99,113,175,216,106,158,69,30,230,45,157,142,40,115,79,192,62,73,159,56,188,122,4,238,116,241,156,250,160,111,34,158,237,180,152,170,87,227,1,71,118,249,17,152,228,160,206,32,78,208,178,59,157,43,154,109,19,78,133,6,119,30,20,47,104,18,74,118,192,47,57,102,14,161,52,20,82,83,32,151,187,124,118,66,51,80,181,25,32,27,69,49,24,231,25,253,148,71,76,144,201,93,243,7,154,19,156,122,201,22,92,229,169,129,176,91,147,122,11,55,64,238,123,48,91,184,177,206,189,41,228,149,52,122,137,134,149,220,197,181,146,153,203,148,168,174,69,98,4,85,192,43,231,45,85,209,84,128,113,162,225,10,109,145,200,108,209,105,217,45,64,113,60,5,254,44,195,241,99,30,133,114,229,163,80,132,171,193,15,59,143,0,126,154,70,73,182,34,143,196,218,246,19,88,26,222,164,246,150,182,128,74,100,62,168,35,8,147,97,152,160,45,46,65,34,15,210,56,159,38,36,209,130,173,211,60,147,144,96,37,0,183,40,223,23,123,181,91,16,67,206,246,194,45,232,217,105,117,147,26,108,217,118,156,100,148,77,105,24,193,12,68,231,107,220,117,255,244,161,103,70,187,94,155,183,225,55,65,207,4,34,194,49,174,166,184,171,119,255,236,161,119,255,252,161,133,130,35,74,195,145,31,92,159,2,224,243,96,66,167,126,65,125,129,214,92,179,2,168,139,40,155,28,227,204,170,48,139,13,43,210,249,158,197,0,236,207,78,239,36,143,122,122,194,243,249,236,238,213,205,180,175,7,128,121,121,76,159,100,233,53,77,250,192,212,39,188,32,165,15,124,89,247,32,95,4,233,19,8,127,240,31,41,145,118,117,63,138,104,28,86,117,93,147,171,8,253,39,167,156,195,226,227,16,72,67,179,246,78,232,45,254,117,187,222,48,61,23,139,92,231,196,233,110,55,110,158,243,247,156,50,164,109,123,161,33,1,104,136,169,217,132,146,8,18,42,50,102,233,148,4,16,54,227,244,138,188,5,236,192,153,147,52,139,198,17,101,75,76,76,184,157,202,22,65,120,66,111,197,164,235,28,30,124,255,244,217,225,193,222,230,203,195,189,163,205,239,246,255,248,195,230,238,139,239,15,54,127,56,122,254,98,239,240,249,119,47,158,126,247,66,28,102,169,159,96,121,144,165,108,165,228,1,50,196,140,114,2,217,43,120,23,8,89,112,220,29,78,65,37,24,29,247,157,22,227,115,6,36,155,207,22,122,22,233,12,91,246,187,93,229,29,81,10,64,117,162,114,24,136,199,179,89,249,251,149,39,147,89,123,149,116,164,166,12,87,219,231,237,231,140,1,13,56,234,21,162,239,232,52,126,136,138,251,62,195,20,0,194,166,18,78,243,164,107,3,238,154,169,203,47,202,105,49,50,243,153,63,21,158,190,239,228,22,97,206,160,194,129,157,158,88,188,170,148,42,210,177,129,47,20,97,190,92,90,249,10,130,89,18,19,173,12,199,114,20,242,92,163,52,141,201,49,63,163,57,247,71,49,45,147,77,29,151,25,205,114,150,16,176,23,90,132,230,245,176,46,179,175,99,17,181,165,180,209,141,24,18,111,214,43,167,55,144,201,94,171,93,45,80,216,5,195,70,146,45,254,215,146,105,155,7,125,75,179,73,90,115,194,205,202,61,161,193,53,39,33,184,70,8,38,12,100,154,128,171,91,85,99,57,197,2,134,59,3,83,55,197,42,41,32,14,19,250,127,166,79,85,242,149,69,25,67,172,174,40,80,206,5,188,1,81,112,181,150,222,248,140,68,230,106,208,194,82,244,56,43,55,64,2,158,199,153,142,41,135,211,153,44,252,229,18,40,38,111,22,46,128,186,146,250,193,132,184,37,48,176,247,42,29,157,10,26,249,211,59,188,3,233,65,14,19,248,177,207,118,16,244,192,149,110,165,211,169,146,109,65,248,186,111,82,245,228,137,125,72,5,193,162,219,220,110,40,190,182,135,250,254,54,199,118,78,161,180,134,128,152,146,72,100,237,89,90,22,218,163,57,225,194,13,99,246,139,14,102,85,149,208,16,156,193,235,225,240,148,232,154,200,171,105,136,185,73,224,71,231,225,12,222,32,61,54,106,80,204,208,6,160,245,232,38,133,216,12,199,208,88,112,179,139,253,136,162,128,215,228,108,232,244,161,64,165,133,106,108,199,94,140,91,221,225,29,165,108,234,103,174,179,19,80,204,88,7,59,177,63,162,49,137,194,254,7,231,204,143,144,66,196,251,193,129,13,243,152,194,40,102,84,87,44,205,147,112,139,228,44,118,179,162,95,226,223,133,175,120,223,33,223,74,217,58,73,30,109,142,162,4,184,185,9,103,86,231,125,194,48,5,235,110,147,219,40,204,38,91,228,217,243,151,79,103,119,219,19,26,93,77,178,45,242,167,167,248,139,132,17,159,197,254,124,11,244,52,134,58,114,115,20,167,193,245,246,7,180,69,65,32,252,85,4,59,27,198,169,151,199,59,96,72,169,7,25,176,132,76,101,246,3,152,64,69,38,217,52,94,95,23,12,153,180,106,2,226,115,6,103,77,232,87,81,0,33,193,118,5,64,144,166,99,145,210,236,215,164,253,122,248,246,205,96,103,239,221,193,63,6,32,141,157,158,248,223,78,79,12,59,27,82,126,2,214,182,178,64,165,232,23,224,199,169,43,160,174,201,235,25,28,242,231,227,108,0,185,194,113,232,12,48,103,0,229,93,133,155,88,63,44,226,166,72,139,37,76,205,77,197,96,189,70,86,30,23,116,84,196,51,239,71,154,97,95,5,242,61,136,133,162,163,6,139,4,6,108,135,0,51,117,54,33,218,54,148,107,230,42,200,124,229,66,79,72,118,172,134,1,135,148,234,151,170,190,58,230,17,191,173,170,78,13,237,134,226,211,134,113,128,238,118,213,249,8,102,151,252,53,80,88,106,244,24,89,213,5,163,69,86,104,237,107,234,135,148,241,75,71,8,34,201,54,135,144,184,58,31,145,207,40,151,30,90,253,54,9,38,62,3,39,213,207,179,241,230,75,131,211,56,187,151,71,49,128,208,185,183,64,169,198,220,239,159,61,239,74,139,241,64,246,144,181,128,125,225,158,129,163,134,141,241,81,26,206,203,113,99,130,7,44,154,101,198,84,57,231,142,243,68,102,176,88,156,128,223,76,194,244,214,3,135,40,175,40,38,152,182,125,112,192,237,90,202,249,45,113,192,105,63,184,224,19,155,240,245,170,8,141,41,139,72,99,92,29,170,209,37,24,76,42,171,220,110,171,112,205,22,137,37,104,237,203,80,77,75,249,10,99,208,162,53,172,10,219,4,226,111,159,24,163,187,65,0,142,53,101,104,149,58,219,117,23,232,165,2,224,157,149,246,95,165,78,179,213,85,68,41,106,26,207,167,8,94,12,99,133,243,169,148,199,182,189,106,99,106,227,115,253,143,118,244,214,153,86,44,25,255,37,123,204,186,121,64,94,67,138,155,178,57,232,32,100,218,225,138,158,94,5,63,103,240,182,30,5,219,125,252,241,98,31,47,233,195,85,10,170,34,237,76,80,166,185,175,80,55,250,250,104,76,42,21,166,188,69,154,203,198,153,44,71,153,119,4,150,120,12,169,220,222,28,157,158,235,212,81,58,93,76,131,147,60,46,124,82,199,4,164,92,38,104,238,10,216,12,69,110,67,184,109,162,17,231,178,87,168,137,190,194,237,73,110,201,209,234,161,173,214,69,99,231,66,163,91,132,199,3,91,59,160,99,217,130,253,187,31,131,218,185,171,236,49,54,200,99,130,224,117,164,89,123,127,173,191,5,160,106,99,107,67,125,237,243,221,44,131,186,74,180,147,55,200,216,143,57,125,44,109,176,95,41,228,114,8,254,77,225,201,30,126,65,91,109,49,191,250,218,162,229,238,12,68,70,147,142,73,62,131,58,156,134,170,255,191,194,118,193,33,103,32,254,180,3,104,48,127,243,78,234,189,216,168,204,223,48,247,194,247,150,228,110,144,116,244,111,44,102,13,18,172,66,29,92,56,203,84,26,112,44,126,84,91,110,42,108,130,179,78,93,167,78,70,25,112,65,21,64,183,5,181,225,187,4,52,64,42,134,119,138,231,162,224,234,93,168,119,233,16,223,1,188,207,130,147,244,182,107,111,133,108,14,117,247,81,123,11,147,194,115,252,13,111,150,203,157,202,202,172,13,38,135,154,182,24,220,234,18,159,43,214,72,37,149,60,211,141,4,183,49,102,30,68,130,69,160,124,59,82,38,90,54,3,114,138,89,153,104,29,97,249,239,142,230,25,189,252,40,122,58,118,176,212,126,15,234,105,140,153,239,135,71,47,209,103,170,84,68,172,47,78,4,17,50,115,191,121,242,141,113,70,108,61,184,119,164,63,32,119,122,190,255,77,183,235,237,242,195,36,159,82,134,173,58,183,88,63,76,75,138,221,107,58,199,125,240,231,242,233,199,13,114,35,20,22,6,196,127,46,159,125,92,156,5,237,134,97,237,242,116,55,9,213,29,149,14,85,21,109,149,113,218,80,94,177,216,212,82,185,1,6,117,51,72,240,208,181,220,39,198,184,175,85,126,113,204,79,32,68,189,99,162,103,228,234,220,70,71,172,37,6,85,32,219,168,222,209,217,41,133,6,180,48,48,159,91,201,14,106,217,27,200,113,241,245,11,176,94,137,177,18,160,46,82,118,45,30,240,96,238,150,230,44,128,117,41,195,176,174,4,213,218,192,222,32,78,13,3,175,191,21,80,196,122,210,31,117,139,83,109,148,124,54,221,113,11,103,181,168,30,193,218,218,93,230,70,33,248,213,184,251,171,224,167,58,69,141,163,141,140,44,12,38,205,128,60,112,252,102,86,36,28,16,230,216,10,124,22,104,113,29,242,79,174,105,12,148,127,82,254,186,182,127,133,36,15,206,84,83,8,157,100,1,100,124,97,133,33,83,128,83,62,248,152,239,198,183,254,156,75,159,98,117,115,113,7,216,188,92,232,58,226,61,129,9,205,152,19,193,179,121,74,222,123,27,115,71,81,12,94,152,227,26,23,127,75,85,144,163,120,95,90,56,106,238,202,65,241,170,132,69,60,77,176,18,246,14,63,229,126,172,68,236,0,249,248,226,11,197,249,172,91,20,123,162,28,1,216,77,174,76,118,183,219,158,216,148,114,42,231,203,7,66,150,184,152,104,255,26,175,135,164,236,150,226,208,41,145,232,113,87,215,29,10,29,88,168,45,77,109,242,42,8,209,49,111,128,139,49,70,234,141,113,160,74,74,208,45,111,118,236,195,9,137,137,142,194,226,147,233,189,29,213,26,170,17,129,20,160,24,67,35,177,84,81,116,160,245,72,219,175,184,219,93,13,130,108,245,59,144,37,148,187,69,39,125,93,0,184,201,132,34,159,129,172,125,16,165,245,10,202,131,229,114,149,126,86,217,187,222,117,210,178,75,179,225,132,146,137,159,132,49,200,68,221,155,5,113,132,81,150,71,87,137,31,19,138,1,95,20,222,228,22,172,142,112,241,238,67,214,249,171,222,48,136,197,206,64,95,153,169,205,173,217,178,12,71,42,49,151,63,172,13,151,239,102,84,190,240,51,159,164,117,46,47,232,8,24,238,190,103,209,144,78,103,49,90,114,159,56,213,199,42,130,128,135,222,189,4,252,96,63,188,19,73,140,200,205,78,89,138,13,23,213,89,88,165,197,209,214,1,170,116,36,58,157,101,117,206,111,67,54,109,143,138,150,203,201,220,189,239,199,241,250,34,195,204,166,249,50,215,27,178,57,90,111,145,166,43,48,105,158,17,149,177,103,122,174,116,135,232,104,197,112,25,160,224,152,149,132,191,220,183,93,238,146,9,3,198,86,123,251,165,174,108,62,170,197,149,67,234,84,218,74,76,31,8,248,219,226,93,95,54,97,233,173,245,196,226,240,46,160,51,225,215,255,224,216,194,151,186,132,249,191,226,63,185,133,226,39,73,51,50,198,11,50,207,89,181,78,95,67,127,87,213,214,168,188,14,1,56,242,49,208,47,168,171,165,102,70,97,171,90,54,171,97,84,173,119,190,72,231,23,21,184,146,153,95,76,34,48,38,204,121,221,40,236,146,159,126,34,139,23,84,43,163,82,85,118,217,85,142,153,173,145,237,151,90,163,57,107,133,44,241,74,32,226,71,144,169,129,29,31,38,152,50,139,23,99,113,58,242,227,221,217,236,92,222,151,114,15,146,137,253,243,221,161,204,186,85,174,109,221,28,201,86,124,160,243,126,225,41,48,232,14,65,163,174,57,212,83,234,34,87,221,105,24,29,16,243,161,87,84,84,134,160,117,51,21,163,129,167,55,88,188,15,83,240,30,47,158,187,150,221,168,35,44,122,186,160,168,171,149,4,58,163,251,95,23,35,77,197,157,69,249,180,224,167,93,154,214,224,86,252,137,112,80,105,18,70,136,69,33,208,207,182,26,26,29,230,227,144,34,141,149,31,73,232,142,125,241,29,135,130,82,124,163,80,76,136,44,82,125,99,34,42,41,108,231,154,111,155,186,178,113,35,145,138,62,69,249,80,209,76,157,5,29,135,119,64,19,23,142,160,47,153,45,253,161,104,146,84,146,91,208,141,153,251,172,232,140,20,181,77,88,220,32,29,177,116,42,91,78,197,208,197,132,50,42,23,129,161,137,250,195,173,181,176,116,35,10,27,74,18,119,51,157,50,63,255,98,132,54,212,123,22,213,149,46,71,203,1,132,21,213,233,175,233,134,40,3,164,205,42,83,61,73,179,35,140,32,170,67,103,170,136,184,4,172,31,95,39,196,109,192,81,4,235,64,22,10,160,1,103,80,111,43,191,87,84,74,69,11,202,198,137,181,82,157,142,191,210,121,249,216,168,211,244,36,10,180,187,182,237,178,58,162,35,123,237,245,145,253,228,74,191,110,42,86,99,87,198,218,82,210,210,169,123,208,42,86,13,166,51,130,163,95,235,95,15,170,24,145,127,16,197,2,12,43,53,122,26,26,104,82,131,182,45,40,11,91,60,197,149,150,125,79,98,81,103,199,155,146,192,229,119,162,21,160,86,206,212,169,62,83,170,111,175,176,216,38,238,1,159,47,163,66,21,65,147,208,187,130,184,234,19,152,58,112,122,231,217,112,151,38,92,96,20,197,19,10,221,73,195,55,98,200,220,53,235,129,191,240,52,217,28,139,208,128,93,42,101,19,152,197,45,175,15,20,230,22,32,106,69,29,140,126,122,168,191,234,41,46,228,237,87,137,45,89,219,113,114,3,20,186,178,2,22,31,84,188,59,31,130,95,80,169,88,241,172,4,150,42,238,202,33,15,137,221,32,123,105,56,63,199,71,97,214,146,98,212,187,96,254,12,138,121,25,173,181,172,218,129,90,217,97,219,199,105,68,180,195,172,46,185,93,184,52,116,197,139,167,72,50,134,182,129,119,235,62,207,170,58,140,166,186,64,171,181,185,150,56,252,42,18,157,230,174,171,213,54,94,234,153,138,239,102,214,237,59,55,59,165,38,131,55,187,100,82,147,203,201,62,49,159,66,27,253,30,177,112,233,147,5,40,5,154,190,172,20,15,131,197,215,19,242,27,203,54,195,95,100,110,170,157,80,7,30,148,93,190,255,23,139,92,252,41,105,83,131,215,173,60,102,105,236,115,22,16,238,155,190,195,236,55,2,182,58,199,15,75,133,255,89,189,33,2,27,197,40,118,50,84,81,252,197,218,69,235,85,212,135,60,139,166,11,250,61,253,144,142,253,60,206,154,10,108,115,223,26,205,158,207,42,180,127,190,215,146,149,215,137,21,87,138,164,84,114,28,215,129,53,239,226,208,122,71,217,37,175,76,143,173,43,187,202,7,109,27,154,65,205,31,228,117,201,22,105,131,82,253,84,173,6,110,193,71,121,149,114,114,121,106,182,232,57,229,210,196,71,226,17,58,174,115,32,249,17,252,227,50,33,209,180,19,159,177,7,162,135,36,34,192,138,9,208,126,153,131,225,230,213,90,85,50,38,22,86,221,184,239,55,159,39,213,29,115,91,198,180,192,27,124,126,2,245,165,155,199,143,236,30,175,215,62,238,44,121,161,97,247,147,107,185,81,165,74,250,57,90,203,45,21,212,151,73,168,42,23,103,48,42,38,240,223,127,1,66,169,131,47,64,69,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSatisfactionLevelMessageLocalizableString());
			LocalizableStrings.Add(CreateSatisfactionCommentMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSatisfactionLevelMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ab3c17d7-33c5-4de2-a399-e7879744f3df"),
				Name = "SatisfactionLevelMessage",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("07cd0230-240d-4c09-8dec-f39bc3e6322f"),
				ModifiedInSchemaUId = new Guid("07cd0230-240d-4c09-8dec-f39bc3e6322f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSatisfactionCommentMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("04116657-8ba6-48bc-a1c9-4c90fcf7410b"),
				Name = "SatisfactionCommentMessage",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("07cd0230-240d-4c09-8dec-f39bc3e6322f"),
				ModifiedInSchemaUId = new Guid("07cd0230-240d-4c09-8dec-f39bc3e6322f")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("07cd0230-240d-4c09-8dec-f39bc3e6322f"));
		}

		#endregion

	}

	#endregion

}


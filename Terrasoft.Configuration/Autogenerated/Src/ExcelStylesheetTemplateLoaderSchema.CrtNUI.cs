﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelStylesheetTemplateLoaderSchema

	/// <exclude/>
	public class ExcelStylesheetTemplateLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelStylesheetTemplateLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelStylesheetTemplateLoaderSchema(ExcelStylesheetTemplateLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c65a30b-a8a3-421c-b7d4-fa0179c7765a");
			Name = "ExcelStylesheetTemplateLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,123,215,206,228,58,146,230,245,25,96,222,161,48,115,83,131,108,84,202,100,202,236,244,233,89,73,41,41,229,189,93,236,133,92,202,123,165,220,96,222,125,149,127,217,115,170,170,187,215,161,49,187,77,160,254,44,82,100,48,24,12,126,17,65,211,4,117,50,118,65,148,188,51,147,97,8,198,246,49,125,160,218,230,145,167,207,33,152,242,182,249,64,175,93,59,76,102,75,175,81,82,253,227,63,252,251,63,254,195,47,207,49,111,210,119,198,54,78,73,253,175,191,203,127,224,148,239,138,196,188,233,191,22,222,218,232,89,39,205,196,180,67,29,76,31,148,46,105,220,186,250,160,6,81,25,164,71,133,191,88,211,232,134,36,136,199,44,73,166,163,238,81,251,159,135,36,61,88,125,71,85,193,56,254,151,119,111,156,26,211,86,37,111,117,204,164,238,170,96,74,196,54,136,147,225,173,193,249,124,126,247,199,241,89,215,193,176,253,233,83,158,110,166,124,218,222,77,89,48,189,171,142,170,227,187,241,11,137,119,211,39,26,31,62,55,62,127,211,186,123,134,85,30,189,139,94,189,255,165,206,127,121,201,239,43,195,109,51,78,65,51,29,76,171,67,62,31,245,222,216,251,165,251,152,121,23,189,190,31,124,12,111,194,252,142,232,187,95,95,149,95,233,191,254,147,69,143,55,146,212,8,50,37,56,226,72,156,70,146,242,69,84,195,148,62,114,26,115,252,49,9,34,165,28,64,158,195,70,175,142,127,15,251,94,45,190,43,199,98,147,77,33,69,229,36,193,181,45,65,80,196,223,211,223,211,127,138,68,141,182,84,61,151,130,208,102,251,209,171,128,113,178,219,58,203,144,190,167,200,13,185,51,99,137,16,137,151,240,188,199,139,97,197,26,5,246,48,226,218,178,157,149,146,232,202,114,118,213,217,194,93,37,243,9,202,125,95,43,111,69,72,161,136,99,97,165,71,60,155,34,0,55,204,132,113,131,199,153,180,55,70,187,133,246,146,27,193,150,76,101,244,132,177,0,106,221,77,177,8,188,252,218,115,51,150,243,186,7,78,68,187,95,177,251,102,62,43,170,191,164,103,109,115,112,225,25,244,196,220,120,200,14,243,75,85,82,198,86,129,44,203,93,18,78,54,68,189,19,224,42,193,102,134,222,36,208,43,135,235,180,223,109,235,89,169,137,44,232,198,106,137,53,112,202,112,30,25,7,131,17,200,120,116,82,95,41,165,135,198,214,35,17,100,147,148,97,146,116,241,248,55,36,160,69,122,101,84,46,245,47,4,43,110,106,252,28,251,139,148,14,55,168,201,48,79,153,238,172,216,199,23,4,129,98,251,140,41,23,81,47,185,213,110,233,179,61,54,201,53,120,26,42,117,86,252,232,172,142,178,148,87,131,87,30,128,211,85,40,141,194,212,227,122,97,89,27,195,29,108,236,84,201,77,163,115,203,241,151,181,84,153,235,236,105,92,116,241,180,32,6,8,120,24,38,250,161,69,17,2,80,8,209,172,56,227,193,204,153,112,79,87,77,41,38,237,162,112,167,8,74,41,55,134,104,183,12,46,8,174,45,116,170,237,163,6,243,45,164,6,210,93,173,7,104,65,227,38,224,201,251,137,114,48,237,18,158,211,3,207,212,243,153,88,72,205,88,36,250,64,50,246,0,178,215,236,103,132,104,219,18,165,2,175,140,249,134,123,227,129,94,252,35,170,237,49,218,176,231,199,223,191,3,219,223,211,127,182,68,141,101,9,170,203,78,72,217,19,231,206,220,131,195,113,55,46,73,146,50,224,152,52,196,49,179,239,8,97,196,139,58,121,80,193,147,115,60,111,81,68,191,161,0,163,5,233,34,223,31,40,120,58,75,67,8,155,155,140,140,105,134,63,57,96,224,70,131,185,141,197,212,36,83,214,61,144,200,181,238,66,238,111,85,233,175,131,114,167,105,55,180,241,216,133,106,43,22,18,35,131,102,15,235,123,52,111,91,107,230,225,77,102,129,51,67,143,250,77,21,171,40,160,116,165,186,115,158,163,250,53,233,140,190,236,196,215,252,36,92,72,208,226,77,52,128,216,81,140,224,86,233,205,253,58,157,193,107,80,35,26,112,206,111,149,132,202,130,207,68,217,238,213,15,127,104,118,46,164,238,224,73,239,108,11,74,175,65,72,230,77,195,33,92,83,61,124,118,39,48,192,8,231,85,197,31,20,168,52,82,102,112,133,102,156,110,162,170,99,81,213,170,246,217,25,52,0,139,158,113,18,105,48,21,41,195,166,222,248,180,29,31,189,124,33,9,226,118,62,47,18,241,189,103,68,145,106,103,184,216,114,100,196,246,5,10,193,1,40,100,194,46,179,11,243,85,120,151,230,24,194,183,0,226,231,16,26,159,9,11,142,98,243,86,158,182,169,70,10,194,209,66,251,91,42,199,255,171,137,26,173,18,20,215,219,97,205,181,249,148,237,36,92,195,158,77,199,21,32,110,226,104,39,163,74,73,53,32,196,99,205,153,242,9,151,177,80,24,186,216,145,125,81,92,228,57,107,154,121,143,142,153,219,45,229,146,74,38,30,209,67,207,181,6,121,111,205,80,193,80,210,57,203,24,6,220,40,86,156,6,29,161,244,197,50,233,231,222,35,200,60,81,11,18,68,171,114,85,59,145,19,249,139,165,40,225,69,160,44,63,67,148,154,43,77,224,25,11,172,204,14,138,116,183,182,160,81,181,123,212,29,250,142,138,147,98,16,167,86,55,81,1,162,38,49,129,57,190,237,252,167,123,126,90,106,136,167,193,35,109,202,7,240,144,124,202,42,177,155,91,18,64,82,88,156,49,95,22,203,133,40,85,192,206,172,47,39,209,117,88,2,21,185,41,86,212,3,99,210,23,22,254,224,124,128,59,22,189,190,226,103,193,231,247,107,32,248,79,208,157,47,174,78,157,176,182,155,241,121,19,165,25,64,161,176,220,162,135,13,191,116,249,139,145,124,67,129,223,89,74,254,78,133,125,234,188,178,206,242,210,94,236,248,71,94,66,10,135,67,152,31,188,26,159,131,237,122,9,157,237,112,169,158,10,84,16,22,252,114,169,192,34,209,214,11,77,230,34,21,220,51,235,30,212,61,192,155,74,200,250,69,67,78,249,197,138,251,122,225,2,60,198,209,114,215,38,209,127,118,80,9,61,135,245,124,191,94,175,123,115,132,111,134,213,108,76,176,152,122,29,1,72,155,88,169,226,213,12,220,187,64,116,10,99,20,88,249,232,178,55,166,220,201,172,9,220,56,52,217,39,228,84,235,136,12,59,39,25,210,37,250,240,37,138,238,17,219,108,106,40,21,66,121,200,117,20,100,225,98,173,249,80,75,161,131,46,140,229,56,202,85,32,4,188,164,185,71,38,48,164,20,200,109,222,169,30,200,10,94,75,114,73,117,209,34,6,26,162,148,201,205,221,144,15,47,177,225,226,250,41,204,169,173,74,104,138,219,197,58,217,92,164,59,134,114,87,111,70,90,229,253,3,86,32,96,132,128,118,60,173,154,172,64,90,228,150,244,49,81,224,218,205,36,158,17,93,80,86,15,80,175,105,77,119,96,126,132,202,140,191,109,208,152,201,142,173,159,252,190,62,233,21,93,212,103,170,117,239,179,32,21,5,1,234,231,108,90,14,223,244,100,49,156,203,65,6,79,92,59,73,157,186,53,238,242,116,216,231,142,72,134,218,75,24,64,191,86,167,252,190,204,192,96,120,20,46,164,75,160,145,231,108,163,201,80,195,193,222,135,116,227,92,28,171,0,193,67,169,58,233,169,111,121,46,242,144,88,91,181,177,86,127,162,242,211,154,43,86,193,196,34,36,136,106,52,208,71,161,30,96,107,62,243,241,65,234,123,44,66,110,95,241,91,146,29,80,44,5,170,119,57,37,34,118,76,232,33,185,171,184,75,65,129,69,217,48,196,59,10,220,71,163,197,5,15,149,32,35,141,92,136,6,138,203,10,202,188,216,174,24,163,198,48,201,158,234,219,144,128,235,85,247,42,133,36,224,231,67,95,96,28,205,178,166,236,177,169,183,148,61,210,117,181,45,89,156,0,208,83,122,150,101,157,98,24,253,24,29,47,110,40,101,196,188,8,46,114,54,128,165,202,85,232,5,210,52,124,13,121,169,186,200,33,24,138,160,187,95,208,199,9,226,207,189,31,231,39,204,175,202,13,217,19,231,112,201,79,204,138,164,245,77,185,163,113,235,100,247,93,207,189,43,8,240,80,112,56,159,63,247,22,149,115,145,186,74,249,202,108,175,5,67,106,159,215,192,30,176,204,230,59,186,25,223,249,46,172,227,253,45,36,166,13,69,211,6,74,34,73,6,191,240,48,37,42,112,111,67,156,193,115,79,82,165,9,164,64,128,118,1,128,242,218,251,249,132,38,57,87,136,248,126,81,231,186,126,68,182,166,238,228,98,56,118,230,202,70,94,138,179,67,134,89,168,116,152,220,83,151,129,177,78,231,187,206,22,89,166,109,147,179,93,164,17,41,12,186,26,61,93,8,98,112,90,100,246,6,186,129,197,245,219,238,86,136,96,167,7,205,68,154,251,132,4,140,195,85,70,251,164,87,138,219,98,244,198,174,240,153,22,90,166,66,159,46,103,244,190,55,228,162,79,219,26,243,249,27,10,200,76,253,0,86,120,159,86,15,219,207,189,245,244,241,37,252,185,101,36,208,208,228,197,55,124,160,185,195,130,18,197,171,252,101,25,223,44,34,44,183,190,99,3,209,134,127,114,177,95,130,179,171,248,70,127,99,37,21,186,192,88,225,136,201,44,253,17,221,206,165,124,73,174,170,147,105,235,205,218,163,252,201,184,13,1,137,8,148,134,97,117,189,193,140,10,162,227,186,86,139,226,86,145,116,174,228,110,70,85,161,12,253,20,209,69,217,64,136,214,45,189,53,110,71,149,68,161,28,58,107,33,125,65,166,197,162,12,0,43,217,35,252,26,144,128,0,174,138,209,54,247,146,73,109,10,101,25,203,48,113,86,146,79,171,92,175,69,90,119,229,13,173,33,171,230,19,243,198,159,188,49,4,132,173,15,106,120,115,151,4,16,1,4,68,183,189,124,216,201,77,41,64,195,121,160,99,209,0,15,149,69,138,25,187,114,216,120,162,13,179,214,188,27,146,27,183,134,211,19,120,75,89,158,68,224,7,212,212,19,126,75,141,58,140,118,17,59,123,252,207,229,74,130,106,87,117,229,226,29,153,37,32,222,246,98,62,201,149,205,170,208,177,62,255,174,111,138,167,172,190,115,153,67,61,211,79,226,89,59,83,34,128,206,101,189,205,145,22,134,114,165,64,207,165,230,146,103,121,61,2,220,2,129,249,162,208,89,9,71,100,202,99,13,85,117,42,139,206,68,119,233,112,4,144,186,155,105,106,0,255,56,213,156,67,203,51,160,171,166,98,12,126,3,42,252,44,118,131,86,5,96,94,2,238,67,121,220,85,5,48,35,215,13,87,64,68,66,133,182,46,87,207,106,194,193,70,218,39,113,85,214,122,165,202,170,9,103,211,138,42,190,127,46,139,45,240,109,190,145,226,35,230,147,240,217,197,144,170,162,61,23,151,6,237,157,54,226,17,241,176,37,63,229,140,47,230,74,154,176,155,4,113,46,68,238,141,68,237,130,53,21,188,66,64,141,111,53,130,217,178,243,78,79,224,214,219,45,185,20,229,144,41,105,205,47,9,12,32,188,163,142,55,193,22,99,248,81,205,244,57,147,51,38,146,219,181,75,114,50,246,176,99,184,70,114,183,189,38,53,86,212,0,111,21,53,41,32,165,174,50,164,74,38,156,41,147,182,18,22,22,28,142,3,158,36,78,188,157,28,192,186,62,117,233,48,22,24,248,108,213,235,246,196,215,52,170,50,243,17,4,59,16,118,230,126,86,240,86,84,161,97,33,173,80,17,145,194,69,181,27,30,158,24,130,146,215,253,102,20,220,252,4,78,39,232,89,0,231,21,234,83,84,22,243,39,254,104,193,96,100,221,89,126,192,167,91,132,37,174,186,80,147,118,56,189,225,66,96,44,103,153,250,43,159,205,209,36,57,141,165,141,103,66,0,41,246,182,135,75,97,245,205,117,183,164,153,224,153,138,50,238,236,41,23,238,184,121,3,157,194,45,169,186,176,145,125,169,158,216,225,120,184,81,226,177,84,80,101,110,117,90,243,45,19,214,33,246,243,67,240,213,1,116,28,71,59,20,207,93,189,125,166,173,34,96,5,13,48,121,129,114,149,123,87,49,111,40,96,221,179,189,186,17,202,238,219,129,111,83,221,2,159,175,24,110,216,121,90,4,139,149,239,213,176,17,84,140,183,101,179,68,106,137,242,174,104,198,38,198,14,61,192,38,42,60,65,216,124,235,182,72,126,152,235,5,87,154,230,18,225,8,28,213,174,119,68,15,188,41,198,232,41,146,221,7,12,31,248,175,54,34,126,58,63,212,21,4,103,187,83,229,199,42,194,40,114,25,237,121,70,207,130,234,109,23,74,114,247,240,138,96,137,58,148,135,253,127,156,231,123,225,93,102,216,108,59,86,105,86,206,27,183,56,56,23,222,51,170,114,86,160,24,117,69,170,16,242,214,130,36,86,145,33,232,57,135,158,167,141,219,82,57,113,114,185,91,92,103,99,177,187,39,8,181,116,115,43,52,146,195,52,57,34,19,138,166,103,213,70,84,143,80,46,187,62,140,227,164,133,105,255,92,197,252,76,46,101,180,143,77,16,137,119,55,50,91,67,14,225,141,17,10,194,132,25,88,209,108,136,223,89,43,244,218,123,125,107,75,35,101,45,100,137,20,109,143,219,124,245,93,29,166,110,247,252,89,158,89,33,145,71,161,91,208,85,41,115,47,133,249,146,219,36,45,239,165,161,35,60,108,16,0,218,211,45,22,189,251,243,9,4,216,208,145,159,109,162,154,148,129,49,109,22,108,4,182,202,17,127,97,13,128,206,107,224,153,109,121,157,140,55,184,228,178,145,39,78,14,98,23,119,60,172,9,83,194,22,223,186,158,211,162,134,33,123,85,189,112,13,128,254,68,45,83,97,206,229,201,29,189,74,34,205,26,56,197,235,173,80,26,238,94,140,18,183,154,234,224,175,60,253,108,60,243,156,102,21,149,109,97,65,102,233,9,219,177,5,210,241,43,113,175,216,85,198,33,136,42,92,227,33,106,6,172,49,43,104,148,14,185,81,137,8,242,162,184,93,115,31,61,41,134,153,49,142,144,170,65,8,100,136,201,115,59,254,128,172,113,158,207,133,40,134,242,163,141,100,25,126,158,24,248,8,14,37,3,217,39,240,234,27,108,136,169,56,121,117,208,236,176,228,55,109,153,183,83,40,225,22,123,81,151,28,62,161,152,139,214,240,140,205,141,24,7,119,141,147,81,198,169,160,9,86,148,137,58,71,93,251,208,9,145,106,146,11,52,76,123,205,36,117,186,165,150,3,244,160,116,221,102,159,13,15,233,251,225,42,73,48,181,50,219,232,243,245,35,151,114,37,77,181,70,246,46,204,195,150,27,147,141,240,104,71,199,197,207,96,231,28,84,94,232,53,187,48,225,45,46,42,60,46,143,13,212,227,78,15,243,83,125,25,89,93,144,219,225,60,180,49,158,181,185,182,36,178,151,158,160,184,199,161,201,84,64,27,188,232,165,232,207,90,41,14,59,165,235,211,149,108,7,178,205,40,4,203,91,203,135,196,124,13,152,204,151,17,23,177,251,202,114,64,132,38,130,231,115,92,36,145,79,19,219,129,206,14,142,146,11,49,85,6,119,105,27,201,130,189,114,148,250,167,41,33,87,191,233,66,73,168,18,34,164,4,135,177,137,50,169,157,171,216,129,201,157,7,156,160,198,245,222,147,233,170,191,214,134,1,72,237,174,145,202,195,238,245,83,212,176,201,211,1,108,225,230,182,135,198,62,225,54,184,233,129,136,168,238,17,148,43,129,37,203,50,107,167,121,168,68,241,40,31,222,73,84,120,176,62,43,160,226,189,161,64,140,169,213,153,142,130,246,33,146,198,41,151,246,20,99,47,35,144,156,238,15,189,106,106,65,143,240,85,144,198,11,221,1,82,225,112,121,68,117,26,208,68,241,211,93,64,220,38,104,196,202,242,234,9,146,173,184,12,155,235,18,85,115,157,174,236,173,227,39,126,157,164,238,158,142,56,106,247,98,113,215,33,106,233,31,129,231,130,189,201,159,19,148,2,124,98,226,112,128,6,20,215,103,99,254,158,232,12,153,63,122,169,39,246,52,187,115,215,115,95,149,0,191,152,138,132,199,148,61,153,143,222,43,187,10,132,113,141,185,219,150,28,40,200,109,165,78,222,150,231,112,201,218,155,128,116,189,250,4,139,187,134,206,220,170,1,4,172,237,121,176,105,13,212,56,143,195,47,142,123,214,172,100,153,27,175,0,72,216,138,51,7,235,195,196,205,7,23,244,135,247,38,219,89,5,244,16,116,11,119,237,57,249,2,130,144,218,16,170,52,27,170,207,0,88,56,118,112,114,233,162,4,190,184,116,11,40,236,24,24,152,80,81,62,41,81,231,72,102,206,167,238,82,12,60,115,129,174,229,3,165,175,238,224,47,169,253,156,4,251,81,244,203,229,113,10,61,65,70,91,254,64,74,194,74,104,154,177,145,154,22,23,172,75,75,251,17,183,72,180,105,1,198,205,49,61,151,1,45,64,137,94,14,62,58,159,120,120,22,111,117,134,216,194,97,97,220,195,54,187,130,233,226,230,0,91,216,3,68,166,4,119,5,20,124,162,26,35,137,148,32,244,48,10,1,142,69,144,32,3,212,46,142,88,9,16,54,224,57,7,237,38,204,76,86,220,128,21,119,243,114,184,60,135,221,64,15,93,124,40,162,6,144,0,154,38,160,22,204,9,146,6,149,61,0,187,112,175,241,112,80,45,170,149,159,189,158,208,69,140,164,204,121,144,193,39,69,34,235,210,141,114,210,101,32,170,133,215,128,10,178,220,153,5,34,71,204,56,236,60,223,237,97,7,211,251,135,143,239,173,138,213,150,84,220,54,179,216,23,135,102,80,38,56,199,243,203,195,57,159,177,27,193,144,34,177,104,22,65,120,4,69,80,70,65,87,146,94,99,167,186,212,110,71,21,153,58,92,241,219,203,227,188,103,163,8,203,64,226,172,85,244,22,138,238,140,61,77,207,26,32,180,179,238,210,202,137,201,35,22,24,120,110,152,56,218,22,90,32,83,186,240,242,28,21,210,198,91,193,225,67,251,136,249,103,4,160,207,189,8,107,110,213,206,19,216,220,141,254,14,230,113,19,214,232,173,68,23,236,166,162,135,153,23,247,136,102,129,147,86,93,10,29,184,155,234,93,86,8,153,165,187,182,169,90,59,23,118,190,247,117,170,36,205,148,172,153,54,172,153,206,173,174,81,136,248,149,35,136,23,167,149,91,147,40,73,10,108,88,60,82,247,208,210,214,104,131,54,72,147,143,209,169,20,221,94,4,176,172,247,140,103,67,222,175,4,142,129,28,151,224,128,74,168,232,122,69,139,66,1,187,221,35,115,190,141,173,153,128,120,57,89,93,55,186,231,185,118,55,132,141,176,217,107,93,144,82,122,229,197,70,106,165,179,221,90,85,169,141,169,197,45,11,93,77,76,40,47,59,54,210,25,240,108,122,77,230,178,38,18,27,130,85,70,221,103,202,184,147,205,181,100,37,223,0,123,187,247,122,125,12,90,129,131,104,219,54,232,238,99,68,112,86,173,226,185,235,88,127,2,232,108,218,162,14,58,156,190,181,105,129,38,21,92,87,214,192,80,209,5,150,53,19,218,39,116,59,84,148,50,149,136,58,76,233,37,47,26,227,156,46,90,38,62,228,98,138,168,225,48,198,190,129,1,230,248,112,209,170,47,201,156,225,164,254,140,199,227,225,244,211,161,114,134,204,178,185,251,119,225,154,238,193,125,67,18,3,170,224,117,137,3,164,187,179,250,158,108,54,182,3,180,239,251,155,34,61,175,94,80,7,160,168,38,182,200,229,84,83,218,75,0,53,168,199,116,156,81,25,74,174,225,38,41,110,97,117,103,215,88,132,51,208,29,203,197,200,166,228,228,240,23,201,151,156,160,35,144,84,246,89,209,228,107,149,119,246,225,234,250,51,101,200,22,88,122,126,47,92,229,11,186,77,166,199,8,107,91,248,37,183,0,83,218,17,69,93,16,202,211,116,46,133,50,208,184,200,73,222,32,155,222,217,199,33,221,109,224,146,47,228,86,55,184,60,156,4,100,20,90,97,48,234,107,48,40,36,144,206,168,195,163,225,21,174,208,36,32,90,76,13,158,92,113,47,45,19,220,146,231,9,43,158,179,107,175,69,85,29,33,34,37,54,141,41,145,52,72,98,98,135,194,77,27,92,157,43,64,229,103,48,224,235,211,98,13,65,68,160,82,182,187,203,13,48,83,219,106,81,135,133,208,211,212,181,56,129,236,55,167,16,228,134,13,214,68,153,108,179,155,135,156,234,140,54,54,184,91,75,174,84,46,120,136,141,159,123,190,152,216,104,54,27,170,136,74,216,197,89,224,121,233,231,73,45,147,13,78,78,26,0,142,180,184,11,21,155,46,30,249,116,41,122,164,25,107,80,161,162,1,109,212,105,156,206,87,169,130,230,148,122,185,67,19,133,4,254,188,134,129,155,169,61,129,14,130,229,108,141,164,113,46,163,161,145,95,15,48,78,7,65,203,85,23,55,246,78,73,45,147,250,236,66,195,181,213,80,112,124,16,69,152,78,89,24,38,152,153,116,151,60,5,102,16,85,85,96,115,193,43,211,152,254,126,93,85,254,126,160,87,189,184,107,71,62,174,249,92,173,172,133,197,59,51,157,45,56,156,79,131,164,25,101,61,51,206,200,246,56,86,205,58,138,183,178,104,184,130,223,204,20,156,223,103,84,102,151,88,11,21,48,33,17,176,208,183,59,61,61,150,165,6,107,13,163,250,165,141,68,184,130,120,252,65,130,119,77,32,178,154,200,88,142,246,28,148,205,16,214,173,202,231,211,220,158,171,130,12,94,138,159,189,28,63,17,246,247,192,68,204,151,78,58,167,71,232,75,10,175,248,151,37,62,3,83,60,71,245,244,49,220,189,75,115,4,101,149,239,106,31,195,53,222,177,76,7,13,37,146,98,134,195,140,221,113,25,186,244,154,195,165,49,89,4,124,194,80,89,223,50,176,9,210,105,46,222,57,174,156,121,117,192,125,166,192,181,33,166,179,80,159,4,64,15,5,93,225,135,12,191,94,107,65,133,17,236,161,158,46,14,129,76,169,244,144,229,222,48,1,191,216,71,162,31,68,125,50,38,244,126,122,182,177,127,248,0,14,86,42,162,111,98,20,71,159,69,229,162,174,135,208,228,65,35,74,253,78,102,163,224,206,28,172,51,22,71,131,158,160,123,158,166,136,138,253,134,2,61,78,251,44,213,0,197,40,32,96,154,31,46,81,75,201,94,209,38,240,210,170,141,183,149,247,106,152,136,226,108,22,247,86,222,203,252,140,198,144,173,61,37,110,140,217,184,24,35,233,110,82,247,205,3,49,195,228,131,68,91,189,117,189,79,234,125,52,22,183,214,108,247,82,28,243,206,185,210,198,216,228,195,8,206,27,230,201,155,161,59,192,85,66,58,79,214,3,28,190,155,214,114,218,132,110,243,157,122,62,164,53,98,24,72,217,231,134,52,103,255,186,241,149,212,91,195,58,64,23,187,161,219,105,27,91,77,178,219,128,191,70,126,88,143,244,61,234,158,134,112,111,225,253,49,51,238,194,61,70,60,148,27,38,54,54,244,196,185,240,29,163,225,208,208,13,193,8,31,186,107,71,90,69,2,110,206,201,126,171,196,153,14,93,14,188,211,167,113,12,19,51,243,105,198,29,3,215,222,157,12,146,81,36,233,110,80,127,91,239,242,4,203,249,120,211,137,177,171,171,226,198,49,247,249,33,93,17,241,64,13,8,16,122,244,124,53,44,212,144,29,181,15,247,210,166,243,174,228,207,51,243,84,202,209,28,187,171,241,204,154,45,147,96,196,91,118,109,48,253,165,55,207,219,44,193,189,161,233,25,148,196,84,178,175,228,57,142,66,129,52,113,14,134,210,208,209,124,32,139,175,251,21,192,205,77,233,69,81,192,248,73,98,196,48,67,242,106,89,210,147,238,24,181,222,110,174,70,236,173,28,153,137,100,68,241,73,116,79,102,29,239,123,86,33,135,2,238,50,88,109,217,126,69,122,67,230,153,174,87,170,195,109,99,48,197,117,177,91,46,131,223,42,251,107,179,157,38,92,164,47,59,198,122,41,59,240,218,35,163,53,130,35,28,125,246,64,114,11,97,114,23,33,249,80,122,235,109,111,135,19,56,154,48,242,87,173,255,251,7,1,255,31,166,130,231,117,243,34,45,12,231,62,204,199,162,118,10,174,109,147,62,222,66,146,174,80,184,45,115,59,151,197,11,136,198,64,170,209,115,96,14,254,57,188,208,178,243,48,201,245,28,68,167,179,19,213,88,40,122,32,120,117,17,82,110,29,131,50,72,34,191,109,186,219,118,55,148,20,193,42,128,79,138,202,42,254,97,5,141,143,247,5,50,30,32,90,197,65,18,80,222,201,89,168,188,96,178,83,176,117,46,199,18,160,203,96,235,70,250,26,123,16,195,170,183,8,201,125,202,95,111,74,195,54,177,4,141,202,169,197,195,44,157,33,253,122,48,237,169,79,34,20,73,81,146,98,128,58,179,94,211,22,164,142,233,55,239,238,62,44,98,49,25,203,226,20,128,236,20,226,66,158,102,210,134,66,117,137,17,63,17,70,10,158,122,87,136,119,152,170,66,140,166,35,216,138,205,66,10,160,208,147,33,112,140,151,147,214,156,32,113,195,240,202,197,181,38,64,47,237,205,112,238,55,65,54,169,33,22,187,77,100,160,104,86,226,232,25,81,85,62,51,52,74,250,135,63,32,193,225,51,65,137,209,44,130,135,62,215,6,26,83,18,166,250,222,122,134,240,197,124,4,106,118,215,169,100,3,242,187,158,61,170,199,35,0,182,201,107,11,139,219,112,76,229,110,71,172,172,213,169,101,133,226,5,101,248,104,119,19,63,187,204,72,163,88,231,149,182,89,174,233,238,8,181,5,52,117,34,38,9,199,207,214,217,8,127,115,4,243,187,157,103,6,85,160,244,246,124,101,176,215,217,33,21,17,159,118,158,151,168,174,158,241,17,212,88,144,13,196,108,245,244,225,195,186,188,118,161,27,189,138,42,249,176,54,250,219,142,180,100,92,243,192,65,199,50,2,251,165,34,180,44,196,66,98,96,0,100,81,1,202,226,207,195,237,28,87,158,62,62,243,195,119,178,172,148,82,17,32,224,57,131,128,221,33,56,155,254,41,191,34,97,73,113,207,188,174,4,172,148,35,236,116,149,174,114,118,45,87,122,111,61,245,112,110,46,30,22,208,125,114,165,6,48,166,218,180,21,87,83,174,28,245,220,73,193,117,125,64,57,186,57,232,192,30,83,48,63,17,160,203,82,108,109,47,197,116,139,48,96,111,80,236,132,41,14,78,39,57,226,215,221,106,221,154,54,245,199,224,130,184,151,231,253,36,238,203,208,85,230,201,20,28,111,96,145,19,174,185,193,225,59,50,229,243,238,242,153,99,109,103,160,168,143,104,54,114,155,109,158,12,189,167,131,21,103,111,126,73,219,227,217,222,198,68,137,96,36,141,34,44,41,6,41,33,18,148,125,98,188,79,55,233,225,190,234,177,8,74,118,22,193,222,222,31,179,48,29,136,5,154,88,15,251,122,207,136,233,72,62,60,226,231,27,179,183,68,211,67,63,127,93,146,35,233,87,56,162,189,142,130,125,22,47,172,59,127,204,131,52,123,46,185,124,189,32,71,191,238,145,144,127,43,144,248,63,158,222,80,224,111,205,196,183,137,223,12,205,57,135,18,177,49,232,162,66,247,101,143,217,189,137,149,116,35,7,150,231,228,179,177,120,41,107,196,117,44,119,181,146,141,185,193,13,252,125,4,47,39,8,136,245,46,193,123,249,122,159,46,167,82,231,93,29,67,220,179,161,1,145,173,229,137,147,51,199,244,179,208,232,226,157,115,129,207,208,229,68,181,2,79,202,253,5,82,8,35,91,200,53,116,79,39,154,153,162,114,211,54,141,118,238,36,187,208,57,168,59,101,205,79,173,171,92,56,177,90,232,214,140,160,132,131,208,205,29,157,58,202,252,169,109,246,150,227,169,179,136,181,79,154,0,216,182,13,175,92,7,16,43,31,92,145,211,116,214,148,169,39,111,43,14,173,152,73,56,13,40,110,230,52,228,236,169,67,175,187,76,59,242,109,125,36,55,50,56,151,46,163,75,211,114,68,82,36,16,199,65,83,206,140,29,6,251,54,42,118,10,175,185,212,158,76,94,155,32,138,237,28,72,218,144,204,54,145,49,17,37,59,106,213,89,12,208,209,90,245,211,77,82,72,171,45,30,126,109,81,146,28,231,181,223,175,184,54,14,72,140,109,42,116,168,187,48,214,108,96,230,78,116,58,97,113,119,6,163,66,95,34,231,18,17,185,167,49,227,69,143,47,23,236,34,224,181,183,11,184,134,110,17,125,193,36,250,144,202,184,194,151,174,80,155,135,162,216,167,64,119,161,100,246,120,93,81,68,126,235,155,237,104,211,192,193,170,79,55,76,220,21,12,185,7,83,238,223,118,3,95,156,57,238,90,246,122,45,241,82,229,146,217,201,110,176,117,56,40,240,50,223,46,55,92,82,65,236,57,232,143,186,187,222,147,120,247,117,236,116,196,239,247,223,0,41,77,137,26,241,27,175,69,51,19,106,135,94,247,59,8,250,117,130,71,47,63,86,165,159,222,116,125,237,71,104,220,68,252,246,78,8,104,155,68,129,191,50,244,242,234,74,252,142,160,16,29,0,65,254,246,114,25,248,67,90,63,184,95,242,187,36,45,236,39,3,240,249,36,237,119,199,240,203,159,163,175,47,53,210,50,175,139,113,204,248,114,199,212,239,232,171,24,247,227,227,253,245,7,50,253,232,11,16,232,73,33,35,228,181,19,115,123,27,60,243,29,85,146,122,109,214,188,142,173,142,248,39,59,24,44,45,88,223,2,231,218,68,63,37,78,19,10,4,108,6,70,191,181,127,225,43,247,253,132,121,47,232,253,159,59,102,148,127,216,87,108,34,126,224,75,135,112,41,137,77,127,168,28,193,107,179,233,167,71,111,191,87,14,238,138,26,214,202,134,59,18,232,132,116,52,7,94,178,145,191,163,42,95,204,207,103,201,241,189,26,125,87,122,227,245,176,56,135,19,6,16,159,189,129,162,153,120,147,16,79,130,169,94,94,178,48,210,227,15,153,126,71,206,212,163,191,28,119,254,80,145,201,71,223,27,165,173,29,242,190,107,47,177,232,223,17,191,143,254,209,105,25,66,178,22,213,135,7,178,225,197,161,36,213,159,161,153,236,83,75,160,233,155,170,189,38,178,249,142,38,17,69,255,107,30,205,245,135,243,8,151,180,3,121,45,249,198,255,242,195,160,3,185,31,162,251,161,165,62,198,64,106,222,91,165,67,175,36,130,122,169,215,237,35,176,16,196,175,255,244,241,214,252,199,183,3,191,252,115,210,196,31,175,227,127,202,127,186,155,47,37,83,214,198,63,187,153,79,37,85,245,142,77,166,215,175,217,85,228,166,183,11,215,196,201,250,222,120,221,208,191,5,83,240,110,252,252,191,63,188,203,155,233,221,240,169,198,191,188,123,123,3,240,203,28,12,175,178,119,191,126,173,248,129,174,146,215,131,135,241,143,7,185,63,189,255,151,15,76,62,140,147,50,220,146,71,240,172,166,247,235,187,95,255,244,110,253,240,185,175,119,191,254,250,149,234,191,190,17,29,146,233,57,52,175,210,127,251,74,236,197,228,23,106,239,63,214,252,143,239,199,243,241,153,197,231,81,125,204,189,142,132,170,234,253,219,112,163,227,207,31,222,125,243,250,226,243,251,140,47,207,35,62,23,124,30,98,254,120,247,254,213,234,223,62,188,61,94,248,194,116,243,172,170,207,117,62,179,252,42,251,56,134,255,248,34,158,232,43,87,71,163,100,249,134,205,79,195,248,210,197,55,61,124,184,7,163,29,84,207,228,75,23,47,90,83,87,81,223,146,251,61,207,31,156,118,40,195,182,45,213,96,248,154,249,248,232,226,173,232,235,251,139,207,175,46,62,124,37,56,126,48,91,49,127,73,247,191,189,207,95,2,248,61,79,111,12,253,247,119,193,248,205,24,62,142,224,151,175,163,252,192,180,205,196,197,47,238,190,229,246,83,241,15,170,231,85,245,163,234,111,197,223,87,39,219,33,78,134,31,52,248,252,225,71,12,189,126,126,200,210,199,15,223,55,33,170,60,109,222,212,226,247,109,190,124,249,183,15,84,213,54,137,220,198,201,251,105,120,77,212,33,151,47,95,127,64,178,235,170,237,207,208,253,205,231,111,149,232,147,110,69,191,21,249,127,252,181,43,255,237,97,207,199,143,191,127,50,244,86,32,190,189,19,74,94,79,126,126,246,90,232,251,231,66,31,75,62,114,54,254,201,248,65,179,63,158,63,127,125,91,162,31,159,23,253,228,97,209,27,15,159,51,239,191,197,150,112,155,18,98,24,130,237,144,23,213,54,115,114,232,48,51,180,53,25,140,9,114,49,222,30,21,189,255,158,224,167,117,245,162,80,39,117,59,108,71,205,36,168,63,45,64,233,155,162,247,95,122,248,166,205,155,24,140,223,190,82,122,107,249,19,254,63,175,227,143,47,190,222,255,53,232,114,16,252,65,181,183,231,97,239,191,101,249,15,239,222,116,235,55,40,176,124,179,200,255,42,16,120,235,227,149,27,127,3,159,191,252,242,253,64,191,65,136,175,47,179,254,55,96,230,71,139,228,235,215,127,253,58,168,47,246,227,24,209,242,195,1,124,56,64,253,141,125,42,203,171,248,143,95,108,212,159,190,12,231,69,39,75,94,143,212,222,176,254,215,31,27,183,111,76,26,248,103,4,113,255,66,232,11,220,254,200,170,124,237,239,15,223,155,144,111,248,154,95,216,249,87,178,5,253,25,182,236,207,116,254,44,87,95,122,251,41,83,191,193,150,239,251,249,25,198,124,42,251,182,232,40,249,54,253,15,144,0,21,227,142,57,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c65a30b-a8a3-421c-b7d4-fa0179c7765a"));
		}

		#endregion

	}

	#endregion

}


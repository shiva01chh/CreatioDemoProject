﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CommonUtilitiesSchema

	/// <exclude/>
	public class CommonUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CommonUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CommonUtilitiesSchema(CommonUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("71c18de2-c788-40e6-b321-6dd8aa6a1945");
			Name = "CommonUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,61,105,115,212,72,178,159,189,17,251,31,132,230,5,163,126,175,17,176,195,139,221,135,177,9,227,3,60,3,152,117,219,195,7,134,152,144,91,213,182,22,89,106,84,106,108,15,227,255,254,42,235,62,37,181,221,48,71,12,95,112,215,145,153,149,149,87,93,169,42,59,71,120,158,77,81,116,132,154,38,195,245,172,77,183,235,106,86,156,46,154,172,45,234,234,239,127,251,252,247,191,173,45,112,81,157,70,147,43,220,162,243,117,235,119,122,132,46,91,167,112,187,46,75,52,5,8,56,125,142,42,212,20,83,167,205,243,178,62,201,202,226,23,138,200,169,125,89,84,31,85,225,107,116,209,18,88,64,223,247,88,111,173,211,125,126,222,85,211,209,177,65,161,114,147,27,193,86,59,207,130,85,187,85,91,180,5,194,193,6,111,154,122,86,148,29,13,38,109,128,192,215,139,34,157,160,230,83,49,69,175,234,28,149,233,238,101,139,42,12,76,15,2,219,203,166,4,92,144,30,109,176,233,30,161,234,120,94,214,89,238,76,206,254,129,87,12,210,67,116,186,40,179,102,247,114,222,32,44,8,33,45,231,139,147,178,152,70,184,37,144,167,209,180,204,48,142,216,172,28,183,69,73,249,19,145,102,159,105,227,181,111,26,116,74,250,70,123,5,42,115,252,56,122,211,20,159,178,22,177,202,57,251,33,96,53,40,203,235,170,188,34,191,27,160,38,207,218,236,7,116,181,62,168,113,93,230,47,167,191,28,101,39,37,122,77,52,97,178,152,205,138,75,222,245,27,84,229,140,142,0,81,116,72,221,109,9,63,9,166,5,112,220,234,193,9,178,120,144,140,34,80,183,181,53,62,138,104,35,138,127,254,185,168,90,212,84,89,9,133,31,208,85,188,78,155,120,105,135,14,7,101,206,154,92,119,19,71,228,110,142,26,64,107,113,248,254,253,251,209,19,188,56,63,207,154,171,77,81,240,106,81,2,149,213,233,34,43,35,188,152,207,235,166,77,101,235,251,122,115,115,178,79,234,186,140,142,49,98,0,50,0,112,138,118,200,80,248,80,79,81,203,255,90,107,80,187,104,170,136,112,12,177,49,94,15,24,198,43,212,158,213,125,82,178,143,95,47,202,242,223,11,212,92,237,45,42,106,151,162,231,168,37,12,36,134,106,113,94,25,53,9,151,142,82,99,239,56,178,10,89,63,90,197,136,231,245,231,89,81,185,189,100,169,234,38,166,154,162,102,197,74,109,44,52,90,197,70,196,138,210,73,189,104,166,188,62,49,73,117,105,28,173,119,224,178,136,235,69,102,13,209,55,54,134,142,207,39,240,53,101,51,144,132,198,229,128,81,85,35,93,152,173,121,165,194,181,143,137,165,34,42,114,88,156,158,181,187,151,194,242,236,158,207,219,171,132,154,223,171,201,244,12,157,103,108,150,105,219,104,70,255,19,147,224,180,82,232,149,39,139,26,134,64,218,54,194,31,6,38,61,180,106,216,248,41,117,5,35,132,180,77,236,254,196,222,46,170,54,218,216,136,30,68,119,239,10,88,196,38,204,179,166,32,206,234,232,106,142,162,59,27,17,35,217,44,231,12,37,253,152,248,45,221,185,110,161,63,159,169,98,22,37,119,4,165,132,148,48,165,15,5,203,186,120,102,247,39,131,183,33,190,123,240,158,161,94,3,91,240,99,86,46,16,165,24,201,38,244,167,211,49,125,147,53,68,194,200,144,104,159,189,154,200,101,14,77,57,52,141,221,22,168,2,71,224,163,76,116,191,254,106,99,36,205,72,19,116,84,156,35,163,233,136,193,95,35,220,177,39,210,162,9,216,84,1,111,59,122,236,90,195,220,136,58,216,73,167,76,226,24,105,182,113,77,215,51,62,244,14,117,249,84,23,121,180,83,96,80,51,218,150,9,7,126,114,180,153,236,239,86,139,115,212,64,21,249,201,133,17,243,49,92,156,161,134,196,136,209,227,200,137,57,128,73,196,207,181,13,9,44,82,174,92,76,66,102,36,222,200,166,103,81,242,41,19,250,22,21,149,132,44,228,136,202,30,23,223,125,188,91,1,5,185,172,93,155,18,216,69,37,60,2,31,246,26,190,40,90,0,205,251,49,188,116,154,84,199,12,163,174,96,201,67,56,101,52,251,243,121,83,47,230,143,57,168,53,15,207,4,234,125,18,252,224,148,78,60,230,83,3,170,79,134,254,97,253,150,148,236,94,22,184,197,157,68,84,232,226,221,251,232,179,176,29,147,197,9,175,137,174,87,76,12,179,32,136,149,120,105,50,90,112,246,172,152,136,253,202,194,15,194,19,176,193,66,13,137,142,139,214,210,76,218,109,153,125,35,225,23,233,147,163,89,70,98,149,132,132,93,35,37,77,178,171,20,81,176,254,89,137,145,28,225,181,111,168,215,78,32,211,167,147,38,27,7,233,155,233,204,52,158,188,68,179,219,89,29,34,80,180,88,50,98,128,16,90,72,61,50,201,57,209,49,123,210,134,10,188,61,220,103,38,208,132,14,102,199,117,68,126,124,202,13,222,222,82,47,197,51,27,157,79,131,125,131,27,64,234,157,101,156,138,25,131,247,227,146,61,159,166,134,211,139,24,24,226,87,195,93,120,15,226,105,121,120,252,137,254,38,126,114,66,127,243,216,230,160,97,33,28,173,29,141,6,138,130,174,106,222,149,204,14,194,168,41,96,227,1,145,74,132,162,105,131,102,27,241,16,69,195,241,253,205,192,162,135,150,204,97,132,81,69,70,185,17,51,42,119,243,130,70,28,241,230,4,101,13,241,88,176,136,139,234,89,212,158,17,196,101,129,72,84,197,29,98,250,228,62,237,175,192,177,185,192,155,55,160,146,56,90,98,95,170,41,34,80,5,24,143,241,25,4,78,231,152,16,223,147,171,22,17,249,53,7,41,102,136,207,170,236,148,11,64,32,144,211,58,135,41,62,62,218,251,87,74,150,96,108,198,19,19,208,56,122,48,182,96,19,171,82,157,182,103,92,37,64,181,129,147,108,93,162,192,195,22,79,170,145,251,100,208,0,55,19,135,84,115,5,227,160,50,98,44,99,185,75,205,249,86,46,215,230,223,215,69,149,144,229,47,137,192,171,138,175,35,22,198,207,113,244,124,65,250,76,137,207,89,52,104,63,31,71,19,4,43,14,194,63,248,79,174,33,49,213,226,142,21,231,86,89,100,88,54,39,226,66,98,54,34,1,111,178,246,76,150,78,213,178,213,94,209,210,238,172,134,46,92,8,149,251,132,198,6,70,32,102,22,248,206,232,32,204,54,135,145,234,182,230,85,86,145,85,126,3,19,188,207,5,241,217,21,192,78,212,40,56,139,61,139,109,2,155,53,131,254,47,235,41,221,36,36,117,76,86,240,68,130,72,180,229,139,143,220,53,198,194,84,86,24,11,229,81,186,133,19,103,244,34,106,79,15,42,183,114,28,197,135,104,90,55,249,126,30,143,192,2,125,92,100,101,98,207,128,193,122,9,111,171,202,189,0,39,87,120,91,204,189,6,148,56,136,136,154,108,105,54,19,41,34,35,225,71,35,68,236,158,53,88,112,191,7,139,246,207,57,96,181,90,245,109,41,201,121,103,26,69,101,253,120,63,87,242,196,246,22,96,75,186,229,242,168,20,98,148,146,166,235,6,43,67,35,216,22,144,123,200,23,205,12,242,7,239,103,105,219,133,94,71,118,200,236,58,140,83,236,80,112,199,50,171,203,92,134,133,120,168,199,50,245,57,222,20,154,43,160,106,110,200,218,84,54,237,27,56,73,199,151,233,136,48,117,133,186,91,220,209,188,34,35,190,27,2,210,108,13,76,195,230,113,85,124,132,144,34,135,154,89,65,6,207,161,97,106,182,5,43,132,28,12,113,181,251,129,173,35,88,240,129,135,21,94,71,177,223,242,181,239,14,78,112,93,18,73,72,226,127,166,15,255,145,126,23,253,10,27,161,176,43,252,9,53,237,54,245,254,12,10,140,255,168,222,197,31,5,80,112,223,40,35,242,245,222,117,49,93,132,9,224,123,148,137,138,185,2,56,145,74,38,225,61,46,137,251,119,53,83,220,75,89,140,23,10,199,253,228,128,145,37,54,38,29,133,13,93,119,179,94,21,224,8,49,15,165,238,157,144,117,101,46,246,26,176,22,113,181,181,71,77,8,37,159,126,199,106,178,130,8,242,75,234,140,171,214,180,29,181,147,111,200,240,139,203,120,147,254,136,230,244,23,81,108,17,60,96,144,183,28,54,131,0,221,201,130,32,90,42,10,238,83,205,9,157,88,83,26,130,106,186,188,114,117,202,247,50,234,101,71,189,62,21,51,131,61,135,199,145,185,78,14,5,198,158,16,222,138,221,187,3,222,244,25,153,164,92,14,51,177,137,116,70,232,16,218,175,204,127,88,127,214,136,8,41,172,82,67,156,26,107,51,68,65,57,63,66,206,204,80,74,58,139,43,244,148,58,240,220,221,216,136,55,119,32,246,57,47,42,132,163,139,51,18,204,16,12,196,250,242,166,17,162,187,243,2,9,177,8,85,221,174,68,231,103,125,238,120,9,61,39,225,33,115,160,203,234,53,85,96,33,14,252,167,53,173,188,212,154,23,174,229,116,225,229,225,170,216,226,240,157,87,241,181,150,97,55,68,217,144,69,218,186,3,209,32,142,192,240,64,54,87,118,100,0,137,53,32,211,158,248,24,106,243,78,177,205,225,152,14,59,101,49,184,135,73,127,89,152,223,220,194,192,220,196,155,116,13,255,151,85,249,186,86,69,4,8,214,108,44,105,88,156,184,159,52,144,116,171,229,196,112,229,213,118,104,20,208,167,176,106,166,123,187,35,216,165,54,40,16,38,3,162,26,119,63,223,29,194,51,4,231,140,34,60,113,45,30,24,42,188,135,50,216,72,224,27,198,73,236,238,200,155,96,98,109,159,113,214,21,68,169,49,105,3,245,241,249,238,221,94,218,151,56,99,113,143,82,232,206,28,221,181,160,98,7,97,33,186,24,124,196,54,209,122,114,34,14,235,186,85,98,4,91,40,126,201,210,4,137,253,197,200,82,252,67,116,86,52,218,100,44,105,73,17,31,17,105,79,55,134,85,7,127,187,128,170,105,247,53,144,90,79,111,192,15,177,223,219,59,83,119,110,52,85,1,130,112,162,232,48,182,177,184,160,171,218,193,254,43,184,105,242,151,223,234,246,91,194,114,107,75,233,78,123,206,205,161,207,2,222,222,102,127,173,96,110,169,48,206,111,190,149,30,131,85,113,4,157,239,234,155,59,250,202,52,170,139,97,92,15,183,242,156,223,37,139,21,71,227,17,13,237,148,17,16,75,79,210,154,251,73,40,221,110,136,45,231,246,247,109,209,158,201,237,86,156,120,175,58,209,221,217,49,243,49,227,40,38,210,163,188,213,200,48,37,186,229,224,151,118,57,189,132,75,118,19,191,77,162,59,211,162,115,186,85,17,7,215,233,215,36,110,46,27,252,199,134,36,128,48,161,193,109,98,70,211,122,91,182,149,221,34,76,207,84,19,31,211,251,227,98,110,197,48,143,163,8,114,184,33,44,246,103,60,49,208,64,59,243,209,103,150,227,77,239,206,169,210,84,207,129,218,32,51,203,216,172,223,99,234,10,199,54,35,47,117,35,223,229,165,2,194,55,194,141,206,30,90,176,64,38,144,118,201,176,171,43,172,187,184,173,38,47,64,64,28,100,92,120,160,117,157,87,27,249,173,15,237,142,74,239,21,21,235,50,149,188,178,18,188,50,34,200,146,247,12,21,150,213,223,45,25,232,78,131,215,76,88,116,97,186,90,53,70,99,70,237,123,33,242,94,154,115,53,72,163,238,11,93,15,25,58,110,207,85,17,255,136,229,144,249,255,230,49,225,48,100,161,139,179,154,220,131,136,11,156,158,107,78,238,45,240,125,188,131,206,107,26,67,117,187,79,193,154,250,228,63,112,16,94,168,126,124,187,83,89,219,163,142,231,26,233,228,10,79,80,219,194,161,113,122,212,92,17,83,201,172,164,237,172,227,201,89,125,1,56,94,22,213,7,76,28,68,189,48,176,58,70,60,129,241,140,180,22,158,184,78,105,94,248,162,192,219,134,48,145,63,0,25,28,85,48,174,104,107,190,15,232,106,204,75,217,85,26,65,46,135,44,2,136,185,249,211,137,39,204,230,202,243,207,21,129,60,2,208,72,22,156,97,231,172,130,54,123,17,192,65,208,117,176,3,2,74,133,139,211,26,242,75,149,212,255,243,7,17,99,62,62,163,45,189,30,194,174,97,26,77,53,80,102,7,17,252,76,178,79,130,249,142,72,104,176,199,192,224,81,120,38,57,231,15,81,150,175,98,42,245,173,252,223,104,198,44,62,109,205,231,229,213,114,140,90,179,166,151,134,218,251,252,249,152,84,108,58,153,74,151,221,249,212,149,86,206,43,40,167,0,167,52,147,46,231,120,169,144,156,96,119,126,165,76,154,68,174,178,26,61,186,69,115,66,183,176,66,239,32,56,240,93,133,24,188,201,90,98,110,141,155,55,57,5,206,39,148,97,178,195,80,70,123,186,215,212,231,9,92,180,208,40,137,69,229,91,184,204,157,196,132,25,36,228,134,39,74,112,203,24,66,233,132,191,246,80,55,24,52,58,70,244,54,68,124,192,73,213,110,62,56,189,196,112,68,120,205,222,137,81,191,155,159,236,94,162,233,162,173,189,203,25,188,104,208,206,51,85,164,69,207,108,236,41,235,77,102,83,194,241,92,173,240,204,11,44,10,8,31,116,167,214,55,51,158,69,20,191,25,213,44,170,157,103,175,80,155,77,166,77,49,111,221,203,81,198,157,19,121,171,4,234,179,249,92,67,233,176,96,75,175,22,204,235,189,101,5,118,140,143,73,226,183,79,228,180,5,74,128,124,38,98,180,98,139,118,9,90,29,96,28,175,36,242,245,169,200,217,66,146,23,37,241,142,11,36,30,65,48,236,169,88,215,112,159,40,162,92,164,58,201,90,167,140,61,50,37,237,61,164,171,133,27,99,15,171,196,138,75,163,232,233,83,166,77,90,231,190,69,222,154,78,40,184,28,29,5,153,11,34,236,2,17,167,78,28,135,142,214,215,60,16,184,76,91,125,28,185,254,134,204,221,235,221,163,189,195,173,87,187,111,15,14,127,128,141,170,131,50,63,222,143,200,178,235,232,96,231,32,218,62,124,117,239,209,163,71,223,61,132,62,230,237,147,239,210,71,209,175,252,110,17,92,188,173,234,22,98,94,50,190,40,171,242,232,162,32,33,254,9,34,11,227,243,250,19,59,153,95,204,167,245,57,232,45,28,207,231,216,123,19,165,127,11,206,183,101,106,223,14,101,215,250,194,247,28,7,133,138,116,131,217,119,123,216,198,51,112,65,110,111,158,172,230,178,163,121,60,239,108,210,30,239,167,111,209,9,221,149,173,75,120,148,192,255,96,216,118,100,71,17,44,41,80,233,164,195,240,4,17,200,135,167,14,6,85,179,95,145,255,41,3,183,136,185,221,65,179,9,125,209,74,44,117,162,208,107,195,251,15,6,13,162,247,36,168,237,232,28,161,66,67,111,238,202,126,56,85,164,112,185,249,94,135,235,68,33,26,41,98,122,223,52,232,19,170,218,67,116,74,252,27,130,169,103,247,54,164,129,129,119,166,118,156,170,54,251,53,124,250,141,98,230,255,158,244,207,153,61,0,165,20,155,142,76,142,77,174,185,179,187,189,104,26,32,93,176,222,216,27,155,117,95,89,14,119,62,170,123,21,56,169,228,35,65,162,29,112,103,177,152,249,156,44,215,221,190,251,186,237,89,129,125,142,213,186,57,238,191,12,44,32,3,93,10,166,49,106,239,59,227,167,38,188,199,156,88,152,170,105,214,90,111,103,189,207,170,59,130,127,99,48,29,195,239,29,58,31,1,31,235,50,246,165,255,150,116,7,253,59,5,157,231,172,185,122,2,161,168,176,194,155,48,22,126,75,151,222,122,197,195,86,236,116,163,248,86,123,215,54,4,253,56,203,221,120,246,224,50,110,24,235,7,121,5,223,116,182,182,194,217,30,138,182,37,13,193,173,234,5,59,153,195,250,209,195,111,113,136,229,52,220,206,200,15,111,196,71,102,131,202,52,109,145,66,32,78,103,19,126,194,211,136,163,64,122,6,218,92,25,80,49,89,180,152,190,94,28,217,12,213,252,178,111,40,131,119,185,233,6,26,194,4,161,88,139,4,132,72,248,41,185,245,198,247,183,25,110,136,50,108,194,52,231,12,240,223,33,185,201,13,123,103,156,213,116,65,71,49,109,38,98,82,233,217,193,232,189,28,152,183,139,32,75,205,105,170,57,103,99,173,199,240,135,245,70,51,120,211,95,228,221,112,17,220,100,80,192,92,133,241,214,130,95,104,215,223,255,3,51,75,13,4,216,59,195,62,57,176,226,159,227,177,14,41,61,68,243,50,35,81,65,124,143,84,196,241,8,154,16,144,177,233,17,116,36,192,157,23,232,242,69,134,207,182,235,92,196,19,253,3,85,135,10,204,158,245,44,161,220,136,206,125,135,98,217,63,63,67,5,47,116,72,26,8,123,177,35,92,30,144,39,20,35,117,142,66,130,15,119,248,43,129,190,5,226,176,103,58,238,197,205,37,158,232,56,15,113,120,216,34,152,70,12,29,16,185,95,205,106,34,17,114,204,174,153,209,24,194,132,130,191,57,162,165,242,53,6,233,167,65,73,245,135,26,198,209,158,217,143,75,173,191,167,114,209,58,111,157,248,205,166,196,46,225,194,35,88,173,11,148,198,88,97,58,12,182,234,252,52,30,9,45,33,11,203,190,224,114,213,157,211,214,43,51,209,109,228,133,225,8,9,141,213,131,221,205,102,251,233,178,170,149,79,93,172,139,197,161,199,98,202,92,153,203,46,5,136,111,59,61,117,85,91,87,102,205,48,178,246,143,53,90,214,45,18,182,213,0,186,104,208,198,25,38,98,152,125,241,209,167,129,247,19,200,105,11,4,165,10,62,9,73,99,234,160,120,106,31,95,182,154,210,155,170,134,221,206,10,164,177,241,188,92,50,72,19,55,203,117,73,155,90,167,198,226,37,148,202,51,227,193,36,222,149,89,211,50,210,245,94,61,134,116,85,95,169,77,143,126,219,26,224,136,190,103,200,75,170,252,33,42,179,86,68,13,55,243,0,131,30,100,114,222,15,112,144,250,67,77,139,195,225,55,156,95,240,193,38,207,106,163,173,56,134,190,175,219,215,59,169,253,72,3,150,122,186,201,83,116,53,197,105,193,151,123,186,194,199,7,180,34,142,254,199,29,60,223,166,243,190,135,212,134,3,82,235,5,63,130,167,144,222,26,118,129,100,232,67,72,78,135,233,28,58,125,179,199,229,174,204,170,124,101,179,178,22,96,160,99,97,86,96,98,110,107,99,58,167,209,99,102,124,118,134,93,98,229,43,137,254,119,185,150,28,186,10,28,122,142,187,188,252,57,252,181,97,234,58,218,197,230,240,25,203,203,2,183,79,180,85,32,230,219,90,236,36,104,147,238,38,48,99,57,228,76,12,38,253,201,177,215,214,110,70,167,2,210,56,218,167,107,93,154,30,49,154,194,159,202,122,194,47,56,9,180,109,161,92,182,210,22,239,140,118,239,225,136,162,111,36,218,49,10,7,37,179,204,68,119,88,145,115,239,75,91,41,247,129,23,43,102,237,62,47,233,41,199,28,56,144,88,197,1,155,14,4,242,36,210,85,4,23,29,126,66,113,72,139,245,179,55,237,14,203,197,89,65,60,65,194,186,166,208,52,49,210,231,80,184,245,133,187,99,96,177,64,114,96,205,186,178,195,164,20,54,13,12,129,214,47,232,144,137,169,90,226,50,242,162,202,74,200,29,198,136,33,194,119,192,202,184,59,74,89,76,168,16,173,41,4,60,155,137,214,151,157,31,115,168,122,39,50,156,119,58,64,216,125,208,128,168,150,50,51,208,154,144,144,60,79,72,239,240,141,29,246,159,87,72,55,244,189,137,229,54,45,120,188,2,103,117,117,190,40,17,49,4,92,174,6,111,238,9,153,100,4,194,84,250,37,147,143,71,88,29,216,146,99,56,247,43,249,39,187,83,27,11,163,70,76,79,12,119,138,224,199,114,221,173,34,9,13,187,229,55,4,236,130,244,2,91,156,116,13,14,59,213,157,20,113,2,222,16,231,174,174,62,91,84,168,202,78,80,44,212,227,0,245,184,207,3,82,175,246,1,197,198,152,88,107,213,78,93,61,8,177,85,52,52,253,161,61,135,28,188,135,163,212,51,118,177,90,56,199,190,185,237,152,141,32,113,130,44,237,247,129,61,103,75,17,225,138,83,16,55,159,68,139,2,89,122,224,159,240,0,53,6,114,103,18,45,18,126,188,128,155,116,76,34,170,183,117,243,129,230,140,22,130,195,113,83,185,56,14,160,235,19,64,184,90,130,121,181,68,208,151,95,195,114,111,178,95,10,87,79,248,72,216,101,23,149,227,100,142,170,103,101,61,253,96,177,2,118,65,41,178,215,117,27,196,103,16,23,11,20,0,181,9,130,131,164,167,74,133,202,26,35,134,222,200,146,210,45,205,38,12,197,42,90,77,232,77,220,70,148,160,48,76,127,167,14,74,96,129,70,239,110,119,206,71,252,250,120,95,178,133,208,64,58,63,187,218,194,211,62,37,120,83,227,130,65,135,8,140,249,19,21,103,121,23,58,119,239,70,52,173,120,86,30,34,254,48,137,196,35,164,54,221,65,51,190,130,130,208,44,208,104,219,216,92,180,215,156,231,148,190,237,108,206,111,131,168,69,151,179,11,238,222,36,53,196,128,129,136,71,235,30,248,108,252,183,196,162,152,232,224,50,162,254,0,93,160,192,129,209,134,224,120,229,195,3,48,48,60,239,10,201,220,118,119,51,132,176,112,63,96,188,98,241,170,67,82,97,46,198,150,134,222,229,34,250,144,25,225,24,86,146,220,19,142,177,84,248,236,45,12,67,119,211,184,44,10,135,100,233,14,89,124,20,100,61,157,116,199,28,3,99,157,229,98,11,127,84,97,71,11,174,123,253,253,248,68,149,68,172,51,186,49,41,241,53,56,88,50,236,244,19,234,167,236,143,231,169,211,163,154,231,0,28,89,78,219,28,175,174,34,91,159,50,226,14,78,74,212,141,149,158,148,57,62,229,139,26,155,165,53,159,51,61,47,90,252,5,84,158,243,243,38,58,235,171,8,130,35,228,27,150,195,168,73,59,187,74,74,224,180,94,79,172,6,112,172,178,62,252,170,57,219,248,244,17,227,180,233,3,218,183,4,131,118,110,155,16,212,62,3,27,88,102,97,211,112,218,118,179,219,12,178,46,62,251,69,199,232,225,146,99,58,21,47,108,235,216,105,66,20,193,183,89,80,173,12,235,31,207,58,114,147,40,44,98,119,220,207,35,120,71,212,6,182,189,129,133,125,232,154,215,27,90,192,29,212,18,140,95,206,6,122,84,145,161,52,212,44,167,69,157,225,142,234,181,236,230,80,7,132,231,77,145,187,80,68,105,16,18,52,232,54,81,43,221,31,234,219,25,242,140,240,5,42,225,69,67,139,46,91,9,233,204,44,243,71,130,28,132,101,29,68,105,71,72,70,121,98,117,227,101,7,62,222,5,20,189,99,146,58,144,175,52,28,213,102,215,54,127,183,141,105,60,163,51,180,225,75,196,55,191,129,134,43,180,203,106,185,217,211,40,246,71,0,55,129,246,39,211,122,115,148,55,214,124,13,140,39,50,249,122,22,160,103,210,126,15,86,224,207,176,254,187,253,2,173,67,87,191,168,81,131,153,249,177,64,23,95,213,164,9,164,254,117,132,168,237,181,31,2,196,42,108,145,128,197,55,189,1,192,148,254,217,107,193,94,100,120,171,44,233,83,95,10,132,91,9,187,212,111,39,36,106,143,170,27,253,190,160,141,232,100,165,185,15,190,131,140,141,112,189,103,120,255,123,89,85,8,210,163,137,204,170,213,128,191,91,252,154,74,192,80,250,85,128,213,117,10,173,234,126,211,16,222,128,240,166,169,167,8,99,159,31,214,107,6,0,132,189,137,14,77,178,53,128,83,97,137,177,40,237,144,126,13,155,183,51,175,57,8,83,24,208,7,197,23,104,232,42,129,121,24,164,90,175,78,3,60,115,107,72,203,170,165,255,16,193,151,48,191,170,244,51,148,126,233,103,117,157,162,166,186,223,84,250,13,8,236,135,71,248,157,138,97,240,14,232,228,132,34,91,127,237,0,200,131,195,209,78,40,66,170,105,247,214,20,113,75,57,121,39,75,191,68,233,146,145,91,176,242,32,220,179,35,198,235,158,64,125,131,40,12,251,119,19,254,121,228,217,208,144,149,251,187,42,43,175,72,133,96,220,215,244,123,38,234,128,3,20,141,186,29,142,11,234,198,206,208,11,202,163,188,67,252,160,23,214,74,109,130,7,197,141,215,170,54,44,219,155,218,213,191,173,218,247,78,212,31,76,243,187,100,216,175,42,252,254,246,23,50,8,219,103,217,215,181,7,55,56,173,55,137,53,0,76,161,100,128,172,179,158,33,81,231,181,43,223,30,241,238,70,116,200,184,28,31,43,119,165,220,71,90,223,105,212,234,174,16,252,38,122,47,121,194,57,249,135,87,124,57,160,110,249,214,67,0,54,212,27,168,189,147,98,193,74,247,192,174,137,47,253,34,154,209,227,121,245,101,100,16,14,126,168,28,242,211,174,251,171,24,63,57,204,192,203,125,103,80,226,250,253,234,147,18,79,110,252,86,89,188,136,178,122,202,107,126,198,211,99,94,234,142,98,137,68,200,254,135,111,161,203,136,242,250,96,87,134,100,111,162,10,7,197,218,84,102,154,48,210,36,187,143,166,236,4,201,61,169,145,185,63,232,202,144,172,146,137,188,105,10,200,233,171,93,64,28,185,57,147,205,27,124,183,254,224,158,124,228,166,242,150,44,253,25,200,229,39,192,192,215,51,7,252,49,221,13,39,160,139,243,218,247,4,199,138,137,163,47,129,137,125,204,49,118,167,51,144,113,251,54,41,183,193,40,139,52,44,227,96,98,1,243,211,142,118,2,146,91,101,226,22,125,217,215,189,163,205,232,129,84,85,51,17,73,40,223,182,38,150,226,89,208,128,236,34,252,73,144,46,82,252,217,207,68,230,212,97,206,194,53,102,99,137,235,38,73,73,116,67,169,233,177,42,29,144,181,195,76,63,106,0,0,189,78,64,211,71,131,179,238,134,83,238,154,196,233,25,119,176,148,142,193,111,150,89,49,183,48,166,220,121,165,67,161,72,247,80,59,61,131,80,119,231,89,98,143,215,12,16,52,62,166,42,59,18,101,171,6,175,75,50,120,138,160,190,103,232,144,207,209,9,44,12,137,29,123,162,145,210,234,209,145,107,165,215,147,89,95,1,231,19,99,178,82,41,131,41,79,106,34,111,159,8,234,227,202,147,63,113,199,242,209,151,244,73,251,254,128,153,249,41,212,137,77,167,213,77,201,2,150,125,6,155,173,128,31,228,140,158,44,229,14,121,102,161,201,114,97,143,207,37,26,239,48,53,245,132,183,152,106,180,246,51,10,45,103,6,184,242,97,42,98,50,93,127,13,59,149,54,161,67,17,245,60,29,65,27,206,115,126,208,36,33,188,17,253,112,131,173,65,233,139,12,91,246,154,189,23,81,79,78,53,168,78,239,231,150,181,31,246,22,133,19,100,229,108,95,6,207,212,130,164,71,104,154,37,239,153,16,51,189,150,206,80,39,214,51,165,83,132,124,123,69,149,119,198,124,220,162,17,221,126,201,71,183,43,220,177,20,66,30,123,176,138,192,235,103,7,0,248,89,120,6,164,70,131,147,112,99,221,1,116,63,77,150,179,241,217,14,109,56,87,175,199,178,129,12,180,56,115,140,152,154,162,215,26,123,227,63,81,127,221,57,78,13,160,238,248,24,40,203,143,13,128,224,143,68,7,119,103,33,178,19,196,12,232,41,191,50,222,193,177,14,104,196,99,38,122,196,212,149,9,122,14,89,46,249,125,183,65,137,157,112,51,61,52,191,228,211,102,205,41,106,85,161,88,214,55,83,38,182,90,62,37,104,40,10,121,234,148,237,51,226,115,209,139,246,188,124,86,231,87,246,39,216,130,153,108,117,88,202,4,233,165,160,213,130,4,221,121,223,191,15,249,129,31,71,223,188,250,225,222,255,62,248,231,163,232,144,230,249,141,178,25,228,104,37,214,39,163,153,126,191,5,190,188,68,89,254,173,88,43,183,117,244,45,20,64,197,183,169,244,42,12,39,20,26,94,74,39,133,45,2,112,18,191,164,159,177,142,158,242,157,87,129,34,86,121,56,247,234,230,60,107,147,248,243,131,107,168,37,18,96,140,84,243,172,205,244,203,225,148,140,211,16,50,224,198,38,194,13,179,232,248,56,102,142,108,21,88,28,6,113,20,78,126,70,106,220,33,217,45,130,132,20,161,44,142,204,5,88,100,78,254,29,254,10,148,57,10,145,237,218,202,189,201,128,104,97,20,47,80,31,156,11,236,65,136,16,137,53,215,215,170,188,232,134,235,84,93,107,149,166,143,204,113,115,62,113,76,75,165,202,4,54,195,41,4,46,136,199,7,117,223,46,51,140,247,178,41,252,4,80,79,246,140,22,155,98,237,77,211,43,16,144,152,102,238,173,155,173,230,116,113,78,172,99,98,127,192,205,89,229,120,227,182,102,74,3,54,54,22,35,235,123,145,51,6,232,115,100,187,115,181,131,99,166,220,212,34,52,250,181,141,156,119,239,138,41,116,108,169,214,128,1,92,211,194,12,194,1,250,255,6,21,198,244,53,251,73,101,146,181,210,178,150,156,19,163,214,92,145,112,24,101,226,35,35,175,180,34,61,29,9,52,63,185,128,143,175,136,20,213,207,10,16,124,250,61,150,38,209,33,201,28,29,114,132,176,186,222,176,102,53,125,89,51,43,105,43,65,74,115,241,51,206,140,5,78,69,190,132,202,207,10,24,108,32,104,79,22,30,207,75,2,156,45,223,61,102,100,44,152,52,150,228,129,114,24,49,240,154,137,2,190,213,0,33,167,190,184,209,13,233,128,94,34,26,53,61,97,160,227,81,221,102,37,179,194,213,105,123,198,185,231,171,10,0,160,7,177,21,40,160,62,53,235,208,146,119,224,95,176,210,167,132,241,141,78,138,9,206,250,100,22,181,129,212,142,176,205,13,49,89,156,173,246,135,164,174,215,132,103,149,238,218,113,233,119,239,74,227,234,217,124,114,214,229,254,53,137,242,64,250,113,210,42,252,144,225,232,232,8,66,120,104,20,175,171,235,51,248,32,200,89,18,195,48,227,145,251,213,50,99,80,172,149,185,14,185,17,54,193,216,126,140,178,165,139,245,78,71,146,72,170,44,166,125,112,137,148,226,238,161,124,192,58,37,48,116,99,1,98,170,147,46,168,34,119,0,194,152,204,45,15,28,61,208,250,119,38,13,195,176,102,2,212,126,201,180,194,154,83,212,30,235,142,45,213,215,223,241,74,224,222,175,232,9,205,208,19,55,245,83,1,189,211,31,208,149,134,135,252,249,178,190,32,246,154,16,83,200,207,254,120,27,184,153,150,216,142,214,60,207,228,23,117,142,233,15,103,167,210,80,25,73,48,44,96,52,126,142,35,238,205,212,9,168,54,136,145,214,143,191,228,51,206,79,157,190,182,24,72,234,25,193,242,51,56,142,109,234,89,1,233,31,71,100,49,32,193,137,17,252,137,65,2,57,227,140,111,73,203,12,176,252,107,2,103,104,250,65,68,34,76,145,222,158,17,238,79,224,116,151,110,223,212,51,254,49,120,65,247,20,66,24,177,34,58,37,184,14,209,233,238,229,28,212,53,121,247,224,222,255,101,247,102,91,247,246,222,127,254,215,245,79,63,221,211,11,30,45,95,240,240,31,215,163,88,197,94,103,13,154,73,108,255,21,63,201,126,250,9,167,255,253,20,190,142,112,143,126,237,105,227,167,248,179,34,233,250,167,152,212,110,106,0,26,209,25,36,132,52,66,151,137,130,57,102,37,252,2,82,202,246,83,139,10,69,191,154,21,251,167,21,81,132,237,12,235,49,63,89,127,76,207,182,245,148,236,12,87,250,10,42,16,22,76,12,157,220,66,38,57,35,66,87,218,70,33,48,4,160,112,22,38,33,140,90,46,50,26,92,81,81,72,104,227,148,38,144,199,239,30,190,103,58,37,37,48,120,16,1,159,134,32,244,19,240,244,55,41,165,21,228,223,255,3,185,1,210,206,100,162,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("71c18de2-c788-40e6-b321-6dd8aa6a1945"));
		}

		#endregion

	}

	#endregion

}


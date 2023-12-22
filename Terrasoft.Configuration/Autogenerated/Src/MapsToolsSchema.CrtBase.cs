﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MapsToolsSchema

	/// <exclude/>
	public class MapsToolsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MapsToolsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MapsToolsSchema(MapsToolsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6695633c-183e-4546-aee4-b7c12b985585");
			Name = "MapsTools";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,60,93,111,27,73,114,207,92,96,255,67,239,24,88,13,97,106,40,201,94,159,87,178,116,39,75,148,204,88,150,116,250,88,217,43,8,194,144,108,81,179,38,103,120,51,67,73,92,29,129,228,238,225,16,32,64,242,146,215,60,228,41,143,139,75,14,72,110,239,54,127,129,254,71,169,234,175,233,238,153,161,196,181,141,59,92,214,240,146,195,234,170,234,234,234,250,236,30,239,48,9,194,46,57,28,37,41,237,175,124,250,201,80,251,233,29,209,155,84,193,142,104,28,251,73,116,145,122,199,77,239,132,182,54,162,48,141,163,94,226,201,135,2,204,141,40,166,222,126,28,181,105,194,240,46,130,238,48,246,211,32,10,75,144,109,9,154,123,54,100,35,234,245,104,27,89,36,222,54,13,105,28,180,109,148,93,90,36,245,70,212,239,107,243,10,220,237,94,212,242,123,193,183,166,80,187,244,58,133,9,144,236,239,18,6,255,244,147,211,67,152,139,161,182,122,244,236,211,79,6,195,86,47,104,147,118,207,79,18,242,202,31,236,71,65,152,146,219,202,167,159,84,196,144,4,238,68,109,198,62,33,217,19,185,37,93,16,147,36,248,49,206,104,146,52,70,1,214,59,157,24,116,118,7,22,232,34,138,239,192,105,134,23,209,73,16,118,162,235,23,105,191,119,7,242,94,235,27,208,237,174,223,167,57,68,248,91,175,147,163,189,205,189,101,242,64,252,81,15,214,51,254,32,198,136,49,10,127,106,10,72,10,144,52,108,147,152,8,98,46,140,6,38,38,165,206,0,55,144,204,147,199,222,130,7,255,193,147,37,104,78,242,2,25,202,22,170,228,48,215,231,77,229,194,68,121,10,162,112,106,247,50,77,7,203,245,250,55,160,245,196,11,153,229,189,133,205,240,218,81,191,238,199,237,203,224,138,214,151,22,22,151,234,11,75,245,197,197,250,55,176,158,249,144,166,243,143,231,23,230,99,218,163,126,66,231,159,206,183,134,221,249,139,224,6,88,248,201,224,166,234,233,58,178,244,105,60,90,154,179,53,152,219,73,248,20,156,11,22,73,78,81,219,224,232,96,79,195,118,26,197,103,101,154,211,159,61,52,174,28,101,222,143,136,91,37,183,194,22,115,67,194,130,123,224,95,233,176,67,191,242,123,67,90,147,118,221,139,194,110,1,216,23,94,182,74,194,97,175,167,192,129,233,50,214,104,155,57,29,7,130,60,32,75,165,21,69,61,114,233,39,153,123,175,146,11,191,151,96,56,203,70,215,213,108,217,88,112,65,220,92,152,240,142,226,209,198,37,109,191,221,247,99,48,138,148,198,137,107,173,203,92,80,85,200,81,209,5,0,75,202,71,160,59,248,48,153,42,214,74,96,67,184,176,99,41,241,103,92,21,94,51,217,5,37,236,197,141,254,32,29,185,66,155,74,152,108,189,98,68,113,207,70,50,222,149,138,226,110,204,255,249,231,228,179,140,68,242,78,47,227,232,154,45,113,61,238,14,251,52,76,27,55,109,58,64,18,215,145,196,100,160,244,71,162,11,146,94,82,50,96,198,2,63,250,254,128,4,9,9,163,20,54,52,142,33,234,57,213,251,44,210,180,13,181,214,166,109,50,38,222,123,112,222,16,230,198,204,78,83,213,24,62,198,119,230,37,30,208,133,242,80,72,178,172,229,170,204,143,182,135,65,135,28,55,59,102,216,215,28,205,204,75,71,163,1,45,69,101,246,222,76,246,227,160,239,199,35,19,141,136,28,66,220,7,158,116,255,234,50,49,34,130,200,13,102,72,173,89,145,204,74,40,53,115,32,27,253,41,115,21,96,60,248,41,115,217,60,127,100,230,42,74,92,154,43,228,220,47,159,193,242,40,204,23,33,34,69,113,7,60,210,78,86,53,238,95,129,242,47,145,78,108,60,230,162,86,234,138,178,242,78,142,96,64,41,74,157,54,169,153,40,222,39,99,226,140,203,164,5,123,79,166,103,163,90,182,100,147,127,141,115,100,172,88,144,196,192,181,154,169,140,69,201,166,166,32,165,172,21,54,251,186,161,33,77,95,140,112,79,87,82,166,177,21,30,117,167,109,220,71,220,168,42,215,90,122,25,36,204,62,160,199,185,198,111,183,170,107,73,78,85,211,121,215,52,110,85,203,248,162,43,104,143,130,14,149,243,30,69,135,236,193,21,217,231,202,143,73,210,18,197,4,31,122,62,12,122,29,26,187,213,146,218,166,56,185,201,244,109,16,25,154,46,166,203,80,10,231,19,186,155,58,39,226,84,97,247,84,125,97,204,44,211,108,210,242,214,7,3,26,118,140,41,5,213,184,132,24,139,19,83,152,60,59,167,70,100,101,97,112,49,137,196,68,26,93,145,244,227,60,61,138,96,9,245,235,95,219,66,21,78,224,44,19,187,228,201,215,89,57,121,52,138,152,166,195,56,4,251,240,50,179,89,225,62,194,10,147,123,182,204,89,169,119,59,165,58,208,195,185,157,26,244,44,151,171,88,118,68,136,145,117,200,32,142,82,208,20,237,148,245,192,59,50,8,77,161,152,210,227,207,210,136,8,45,207,86,235,243,64,84,81,235,90,53,167,98,251,147,173,97,213,34,23,27,196,86,16,7,87,126,138,190,15,244,109,114,21,65,218,177,69,153,109,49,211,246,207,168,239,72,105,74,213,242,17,149,21,61,30,67,193,66,156,245,148,96,205,0,245,123,72,177,134,247,69,233,159,96,37,31,132,87,96,105,29,135,173,95,26,116,97,92,48,22,83,189,79,71,97,72,2,254,108,112,200,123,119,241,172,197,29,219,76,211,26,44,116,231,149,177,186,29,133,16,209,211,253,56,186,130,168,30,139,192,189,59,236,183,104,188,21,197,125,63,229,69,8,163,180,144,61,142,182,73,219,144,67,122,135,20,155,167,148,229,109,199,227,90,173,215,139,73,182,227,104,56,152,157,32,248,150,202,62,21,28,232,148,156,129,1,61,34,99,181,129,41,54,15,162,7,98,92,32,206,108,70,224,118,212,220,66,239,128,14,122,126,155,66,168,197,96,235,57,213,12,66,28,105,173,30,219,134,106,205,214,145,208,34,1,247,109,95,18,87,105,255,131,217,133,90,138,12,193,249,213,24,251,250,87,180,156,66,123,83,117,144,30,57,89,4,97,201,185,224,236,98,246,136,168,109,253,108,177,113,250,226,69,198,202,142,95,244,60,198,142,34,180,197,177,28,102,100,172,55,126,216,161,55,16,241,147,35,88,105,130,76,51,29,28,39,52,134,157,13,249,217,180,253,83,164,146,177,78,97,177,115,45,146,161,241,83,44,193,194,89,181,176,132,215,157,183,245,163,118,46,44,119,180,141,220,128,123,110,77,36,121,128,79,210,110,158,67,211,2,23,210,219,230,193,118,122,155,166,155,65,44,206,238,247,253,144,246,176,152,223,26,134,12,114,216,142,131,65,122,239,194,83,21,38,59,65,72,93,182,187,191,112,46,4,47,84,118,193,84,46,132,157,84,149,104,108,142,107,31,235,114,6,247,128,104,223,79,47,19,183,138,143,238,66,181,198,241,42,9,237,242,52,179,138,248,56,120,40,32,174,194,233,67,41,189,19,36,152,167,230,158,165,88,239,144,54,237,245,146,129,223,198,181,175,146,197,133,181,103,105,12,255,117,214,158,213,241,35,237,16,72,88,93,220,196,54,240,130,104,221,234,202,78,233,65,163,209,248,178,241,229,218,179,214,218,228,223,223,253,253,228,135,201,127,78,190,155,252,97,242,167,119,255,240,238,159,1,40,57,136,135,58,48,158,227,167,107,149,11,96,224,226,210,2,224,179,176,2,95,207,136,92,128,215,163,97,55,189,4,224,195,135,74,13,92,215,105,76,41,10,47,81,79,131,51,182,80,6,23,58,215,151,249,144,173,51,155,214,30,17,139,91,141,131,238,101,90,140,229,6,228,33,89,172,194,199,156,87,194,6,87,55,199,110,95,10,231,40,225,59,55,249,215,201,127,161,182,8,168,106,14,248,91,139,122,49,236,251,225,58,51,14,23,167,119,197,234,127,142,51,182,214,200,228,207,147,239,20,41,31,90,38,115,115,76,82,68,152,43,81,199,29,210,146,235,160,147,94,174,126,177,144,137,205,84,79,187,59,108,91,242,218,231,240,76,251,172,184,80,232,107,96,83,11,217,54,154,58,40,225,68,234,72,180,80,245,210,104,43,184,161,29,151,235,159,76,254,56,249,147,146,106,76,40,4,200,217,24,103,28,23,4,71,141,223,236,218,210,45,90,144,231,76,111,118,87,250,55,112,159,223,128,35,193,254,78,126,63,249,126,242,223,240,169,220,202,195,173,157,226,88,182,128,232,227,106,80,228,16,137,195,161,99,135,103,124,89,178,23,54,76,69,217,84,134,75,246,55,226,173,93,118,239,249,60,26,134,157,36,139,151,21,131,123,46,22,78,99,226,118,57,60,49,130,98,0,26,20,149,156,28,199,173,110,10,176,178,71,86,113,14,227,152,159,38,175,42,58,68,222,133,18,194,64,236,7,225,235,55,250,111,255,198,248,29,36,91,65,44,53,87,17,191,244,27,130,74,165,19,25,49,75,77,253,250,13,110,188,252,5,179,71,80,44,196,44,80,139,101,86,79,23,206,116,159,187,209,9,94,191,177,70,71,214,232,226,153,238,128,66,52,205,241,50,97,179,202,130,89,12,46,25,160,167,55,53,50,58,203,192,184,242,60,24,121,235,234,86,46,187,186,138,81,82,205,86,105,197,212,127,171,200,198,252,171,196,117,145,233,13,100,0,38,10,44,83,231,35,97,32,202,77,198,142,152,164,107,124,163,108,82,1,155,66,58,82,179,46,22,204,186,136,164,163,82,82,57,235,98,193,172,54,169,21,100,238,101,144,99,114,125,25,64,138,118,21,118,213,240,227,83,38,101,141,75,113,38,189,217,56,221,48,42,195,237,40,234,246,168,81,25,170,246,26,118,171,19,133,189,145,93,18,158,231,75,183,28,73,190,92,35,5,181,93,33,169,93,167,145,92,65,183,98,68,157,59,234,87,84,1,104,209,44,164,11,150,192,246,193,140,103,150,114,238,85,231,90,156,139,11,221,247,47,115,63,74,145,139,71,65,226,204,139,71,121,214,155,168,46,200,30,213,78,33,49,248,196,52,25,246,88,37,166,245,121,234,174,184,248,164,179,152,167,58,195,19,19,39,87,216,154,231,164,75,60,7,18,118,33,11,128,59,30,111,254,68,10,131,198,224,129,118,219,102,94,30,169,131,30,114,18,197,111,177,244,165,100,227,96,241,103,143,158,60,126,194,136,113,125,74,199,57,65,44,195,240,20,19,232,127,147,104,24,183,1,47,138,253,46,180,125,142,178,38,104,136,97,97,194,175,149,238,122,137,117,38,105,116,122,28,45,191,133,155,1,155,216,143,71,207,184,206,100,147,186,38,183,149,245,19,199,248,138,16,164,212,118,212,129,135,245,65,144,59,248,23,191,187,202,240,215,247,155,47,233,72,220,8,36,151,209,245,137,31,135,168,123,177,71,245,58,58,28,81,76,9,16,16,216,239,81,52,132,170,49,185,36,105,4,61,13,14,82,82,35,111,195,232,58,148,179,209,132,93,152,33,139,102,10,75,251,213,16,26,31,25,145,240,120,50,97,204,96,122,79,162,113,190,16,38,230,82,104,104,32,82,2,119,176,111,118,65,254,150,142,216,104,219,103,158,105,243,209,231,26,240,35,135,132,248,82,182,88,132,67,236,65,186,106,45,74,80,210,25,133,126,63,128,109,135,248,116,17,71,125,230,212,36,8,7,195,84,49,126,62,76,81,144,132,178,181,208,4,218,46,63,134,31,16,220,230,123,65,63,192,115,88,144,183,19,36,109,176,9,176,6,226,183,80,80,113,193,15,12,175,2,48,153,156,59,161,201,149,111,176,176,18,102,160,214,53,152,179,224,100,99,246,45,152,62,56,128,134,51,72,120,180,90,84,208,111,35,88,39,118,98,18,128,151,166,27,17,59,154,93,184,195,175,237,55,42,144,252,130,29,227,129,22,178,43,23,48,206,45,11,170,72,185,99,48,187,3,45,29,210,48,97,117,157,86,168,32,211,204,82,15,184,210,179,19,151,59,85,39,19,244,173,243,43,112,70,91,188,113,77,142,130,101,193,184,237,19,217,120,194,100,3,20,37,167,230,195,25,26,180,234,96,46,120,50,214,78,174,28,13,78,17,54,76,47,158,58,162,20,168,215,111,157,110,207,25,51,115,228,239,245,129,201,132,120,182,132,198,42,2,218,184,72,11,199,49,118,207,14,110,85,178,92,175,247,1,228,241,81,118,183,141,191,235,96,224,63,119,86,178,35,239,201,191,120,147,255,128,102,226,247,239,126,7,159,127,134,142,234,135,234,50,153,252,47,52,239,223,191,251,45,0,191,123,247,155,119,255,68,160,1,249,195,228,143,0,248,71,104,63,254,7,198,177,189,7,224,15,72,48,249,254,62,91,194,149,2,2,230,210,151,7,166,240,2,132,46,33,113,167,48,173,102,122,16,142,199,149,96,42,229,225,221,114,229,248,0,147,19,218,18,216,222,6,84,40,41,117,179,57,170,196,79,8,10,157,33,201,104,206,41,94,209,244,50,194,11,94,103,187,113,228,152,99,192,173,3,29,95,224,179,180,146,253,218,240,219,151,212,219,164,23,62,120,191,134,148,9,231,39,237,32,104,132,34,70,113,35,95,63,220,104,54,37,204,173,90,83,69,209,219,128,226,203,174,126,16,170,179,117,11,42,137,68,6,0,15,24,64,198,160,91,16,236,14,33,50,81,121,13,206,177,184,81,186,34,78,49,76,118,143,205,39,132,189,60,16,80,215,84,18,7,170,210,88,176,193,179,26,191,175,56,137,159,171,10,160,51,228,131,110,53,43,175,149,42,104,216,230,209,73,66,144,78,41,5,61,108,254,169,163,142,36,10,150,112,0,37,168,210,15,159,136,131,92,83,180,154,152,74,19,162,82,168,48,147,177,135,95,71,81,35,236,100,7,35,99,253,164,128,127,150,71,213,252,28,85,163,253,149,1,122,95,198,115,121,213,166,223,170,229,153,120,135,131,94,144,186,115,53,117,60,164,69,122,236,75,193,81,96,39,239,230,142,189,150,108,131,47,136,155,113,89,37,75,250,129,143,158,111,102,226,191,168,248,87,236,100,119,15,234,37,213,178,230,178,225,61,168,31,73,106,109,175,198,185,12,250,53,36,205,44,227,228,83,16,44,23,95,10,73,215,228,121,113,229,118,161,70,22,199,181,202,237,98,141,44,225,247,82,141,124,129,223,143,106,228,41,126,63,134,113,64,224,141,230,237,23,240,11,208,200,237,19,120,120,132,15,63,131,135,199,136,248,20,30,158,32,228,75,120,120,202,5,84,121,58,211,249,51,162,182,194,72,241,227,60,234,26,249,210,66,93,124,154,225,10,80,201,218,79,21,252,76,156,149,137,183,74,14,88,97,179,193,223,93,4,250,156,157,100,181,133,141,252,249,231,69,53,104,229,16,96,122,89,251,66,48,124,5,105,28,234,44,183,188,181,113,88,11,13,94,22,241,42,153,118,26,113,12,185,188,90,83,38,97,84,225,40,140,7,5,130,235,72,3,193,50,222,184,150,93,201,97,74,19,114,138,111,125,116,92,84,33,160,161,102,181,26,34,143,167,236,20,144,149,158,167,82,112,69,74,205,56,217,250,10,168,166,246,26,89,187,200,212,158,85,69,131,64,237,129,220,53,181,5,51,222,145,32,2,75,37,88,30,248,201,91,129,250,75,1,194,118,11,193,86,223,149,209,182,253,129,104,190,117,46,158,176,155,13,62,90,112,27,147,157,61,206,176,54,183,15,9,84,60,243,251,71,188,85,28,162,117,202,108,99,205,194,78,17,57,1,222,186,204,173,148,224,241,43,121,228,133,174,33,202,56,86,210,109,139,182,229,144,141,122,123,47,241,29,6,190,113,43,100,92,194,142,29,176,221,155,231,215,141,131,189,243,131,198,225,241,206,209,33,114,215,4,198,182,123,138,79,29,135,172,207,19,117,52,115,168,13,31,106,99,7,207,215,157,57,178,50,38,31,68,194,189,175,26,7,231,191,60,110,28,188,57,223,105,190,106,30,205,38,37,148,157,175,252,112,4,54,21,7,244,35,74,121,208,0,17,15,143,206,55,27,187,205,198,230,108,50,242,252,204,100,251,120,2,54,119,191,90,223,105,110,158,11,65,103,147,240,85,144,96,29,133,90,28,205,34,34,191,194,100,238,168,185,14,76,104,57,211,52,215,144,82,126,182,202,238,184,110,139,24,226,149,7,113,241,62,76,98,63,36,115,213,185,114,39,105,220,96,221,206,80,159,71,55,158,160,114,75,176,153,122,100,180,193,37,215,74,16,243,162,149,97,90,2,236,189,188,39,226,201,250,193,110,115,119,187,12,91,70,54,183,149,226,81,229,202,24,37,119,202,176,241,117,205,146,161,170,220,18,11,46,21,58,229,229,186,251,101,145,236,254,251,111,48,141,76,89,220,95,34,143,100,226,124,200,76,146,227,250,227,115,73,198,138,69,151,175,105,28,113,197,37,31,38,22,230,21,240,215,153,84,114,114,190,79,90,177,148,42,206,46,54,105,24,208,78,129,184,149,15,33,239,171,245,215,231,39,235,111,246,247,154,187,71,135,231,141,215,27,141,198,230,123,202,253,202,191,57,241,71,236,31,70,37,248,198,20,237,20,138,255,33,164,223,221,59,58,223,218,59,222,125,63,129,161,203,216,194,107,221,143,36,228,241,238,203,221,189,147,221,243,198,193,193,222,193,7,47,52,62,136,21,188,87,173,241,35,171,161,159,74,141,255,175,165,134,184,89,102,239,135,223,117,70,32,10,146,92,14,198,251,248,216,232,157,115,87,158,114,32,51,202,252,221,3,97,39,63,230,197,3,158,252,76,49,247,221,136,27,188,60,249,212,109,94,220,30,220,126,177,48,157,71,137,203,72,242,39,11,139,83,201,203,170,251,140,126,105,42,125,121,39,152,113,120,116,7,7,255,202,15,122,8,159,198,101,113,186,26,158,251,157,151,180,120,5,75,211,41,203,19,58,231,48,86,197,162,233,118,5,225,69,158,106,149,26,141,39,14,227,19,144,213,194,98,255,16,134,73,108,77,3,65,199,33,46,58,88,41,219,83,115,228,12,157,177,234,100,167,90,172,140,6,239,48,106,108,188,163,201,191,164,224,137,122,253,196,16,66,84,229,166,100,89,21,157,176,97,208,34,64,241,80,220,117,75,255,135,28,251,72,40,254,255,22,0,247,184,204,97,10,234,243,54,134,113,76,67,245,253,194,15,59,61,26,87,189,173,0,18,42,103,0,246,174,207,229,176,187,7,3,196,163,137,14,193,211,49,177,128,156,18,138,130,73,214,184,228,110,46,205,203,244,162,55,35,244,127,78,174,128,226,148,206,120,85,222,121,168,66,92,25,22,123,199,158,152,145,208,56,179,131,191,250,159,255,3,142,228,160,151,47,69,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateStartPointIsNotLocatedErrorLocalizableString());
			LocalizableStrings.Add(CreateStartPointIsNotDefinedLocalizableString());
			LocalizableStrings.Add(CreateFinishPointIsNotLocatedErrorLocalizableString());
			LocalizableStrings.Add(CreatePointIsNotLocatedErrorLocalizableString());
			LocalizableStrings.Add(CreateServerErrorErrorCauseLocalizableString());
			LocalizableStrings.Add(CreateMissingQueryErrorCauseLocalizableString());
			LocalizableStrings.Add(CreateUnknownAddressErrorCauseLocalizableString());
			LocalizableStrings.Add(CreateUnavailableAddressErrorCauseLocalizableString());
			LocalizableStrings.Add(CreateBadKeyErrorCauseLocalizableString());
			LocalizableStrings.Add(CreateTooManyQueriesErrorCauseLocalizableString());
			LocalizableStrings.Add(CreateNoServerResponseErrorCauseLocalizableString());
			LocalizableStrings.Add(CreateDirectionsErrorLocalizableString());
			LocalizableStrings.Add(CreateDirectionsErrorZeroResultsCauseLocalizableString());
			LocalizableStrings.Add(CreateDirectionsErrorRequestDeniedCauseLocalizableString());
			LocalizableStrings.Add(CreateDirectionsErrorMaxWaypointsExceededCauseLocalizableString());
			LocalizableStrings.Add(CreateDirectionsErrorNotFoundCauseLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateStartPointIsNotLocatedErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cbddb5c8-f56f-4f25-a0eb-1fed9eee9db5"),
				Name = "StartPointIsNotLocatedError",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStartPointIsNotDefinedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5768b2f6-3d6c-4c36-a583-582ffbeeb9b8"),
				Name = "StartPointIsNotDefined",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFinishPointIsNotLocatedErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ea24aebb-cf9b-49dc-bad1-c358ac485e1c"),
				Name = "FinishPointIsNotLocatedError",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePointIsNotLocatedErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("025601fa-6178-408c-8962-606133cd45d0"),
				Name = "PointIsNotLocatedError",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateServerErrorErrorCauseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("57508a72-d39f-4c7d-bc69-63c1bd0c8159"),
				Name = "ServerErrorErrorCause",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMissingQueryErrorCauseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("13183777-efc5-44d2-8060-bb91b9802db7"),
				Name = "MissingQueryErrorCause",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUnknownAddressErrorCauseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fa459144-5196-4840-b7f8-37bf454b7e91"),
				Name = "UnknownAddressErrorCause",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUnavailableAddressErrorCauseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ede157b6-6da6-4bac-a365-58844aa74f20"),
				Name = "UnavailableAddressErrorCause",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBadKeyErrorCauseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("486504b1-d294-414f-a69e-70ec142bd7a5"),
				Name = "BadKeyErrorCause",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTooManyQueriesErrorCauseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("984ccb61-ab38-4e3c-b389-02a15f614d0e"),
				Name = "TooManyQueriesErrorCause",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoServerResponseErrorCauseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5e78d1ed-2ff0-4c03-8b00-d32fa8c4ad07"),
				Name = "NoServerResponseErrorCause",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDirectionsErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5922dd8c-cafb-4871-ab50-bdd1df90d590"),
				Name = "DirectionsError",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDirectionsErrorZeroResultsCauseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e9bb669a-37c8-4c99-bef5-35a1fb7b602f"),
				Name = "DirectionsErrorZeroResultsCause",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDirectionsErrorRequestDeniedCauseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("dad2a39b-608f-4111-b050-5d78c80609b9"),
				Name = "DirectionsErrorRequestDeniedCause",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDirectionsErrorMaxWaypointsExceededCauseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("32ae0b81-e362-4903-b6b7-8d20cb3324cb"),
				Name = "DirectionsErrorMaxWaypointsExceededCause",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDirectionsErrorNotFoundCauseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9f4e5568-1e02-4c1d-a1f3-646ed7dc9672"),
				Name = "DirectionsErrorNotFoundCause",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585"),
				ModifiedInSchemaUId = new Guid("6695633c-183e-4546-aee4-b7c12b985585")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6695633c-183e-4546-aee4-b7c12b985585"));
		}

		#endregion

	}

	#endregion

}


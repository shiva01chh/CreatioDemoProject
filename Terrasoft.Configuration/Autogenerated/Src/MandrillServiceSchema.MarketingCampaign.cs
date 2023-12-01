﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MandrillServiceSchema

	/// <exclude/>
	public class MandrillServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MandrillServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MandrillServiceSchema(MandrillServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa");
			Name = "MandrillService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("cce0bbcf-0f62-4d10-8668-e532f5611287");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,27,107,115,219,198,241,179,50,147,255,112,70,102,82,176,97,32,59,105,220,70,175,25,234,101,177,181,100,85,164,234,206,104,52,158,19,112,36,81,129,0,124,7,72,102,51,254,239,221,189,7,112,7,128,20,101,43,19,213,31,44,18,216,219,221,219,215,237,238,45,83,58,103,34,167,33,35,99,198,57,21,217,164,8,14,178,116,18,79,75,78,139,56,75,131,83,154,70,60,78,146,17,227,119,113,200,190,253,230,183,111,191,217,40,69,156,78,201,104,33,10,54,223,110,124,135,245,73,194,66,92,44,130,81,206,194,152,38,241,127,89,212,130,27,190,107,61,122,27,167,31,91,15,71,44,44,121,92,44,130,3,190,200,139,108,202,105,62,91,116,64,73,254,78,179,136,37,43,95,6,3,224,237,78,110,110,53,220,123,118,211,2,24,179,79,69,253,208,150,25,103,203,158,7,135,251,75,95,29,165,69,92,196,76,44,5,56,166,97,145,241,37,16,192,97,112,82,20,121,48,184,17,5,167,74,230,53,32,190,186,44,226,4,100,71,118,205,14,204,26,253,2,160,1,254,59,206,166,176,150,28,36,84,136,45,210,210,57,128,108,110,110,238,136,114,62,167,124,177,39,193,200,36,227,228,62,227,183,228,62,46,102,213,154,96,103,211,128,193,170,43,141,2,108,74,50,120,141,207,6,34,63,99,197,65,54,207,65,11,55,146,141,11,246,177,140,57,155,179,180,16,190,253,5,85,1,204,63,176,4,161,2,253,32,234,33,145,188,188,73,226,144,132,146,211,198,126,200,22,25,158,82,64,146,78,207,121,118,23,71,140,195,138,223,228,54,155,162,24,166,5,227,41,77,244,75,6,136,228,251,6,48,200,189,160,192,200,22,57,231,104,92,74,102,27,185,250,66,66,124,79,226,180,32,163,130,51,58,191,96,20,136,238,151,147,9,227,35,112,14,216,225,235,95,126,249,249,245,246,106,50,199,49,75,162,101,52,46,5,227,192,71,170,92,143,124,40,157,239,219,46,48,112,91,128,120,110,178,44,33,31,98,49,72,179,116,49,207,74,49,40,139,25,8,52,14,165,127,0,91,19,154,8,246,0,91,32,196,156,113,52,99,96,77,202,93,19,83,58,104,48,214,248,138,225,100,99,99,202,10,253,105,35,158,16,191,193,60,121,177,75,210,50,73,122,6,102,131,179,162,228,93,155,196,151,159,213,159,38,146,93,233,16,104,137,224,196,193,65,201,57,236,20,92,94,8,120,123,229,185,124,121,215,132,138,6,175,219,79,204,160,68,180,84,248,53,174,59,202,9,205,115,103,43,254,192,126,208,235,218,25,64,36,26,215,149,231,128,123,215,154,145,14,25,57,132,2,21,52,58,197,160,55,177,106,163,10,68,128,110,119,247,154,16,64,234,142,38,165,140,154,8,184,202,192,78,89,49,203,150,26,254,93,22,71,196,146,29,243,141,232,80,192,13,115,219,109,40,170,152,241,236,158,164,236,190,117,218,184,218,104,124,61,250,20,178,28,63,248,61,107,171,114,27,54,107,210,227,89,177,95,38,183,71,115,136,56,251,224,252,183,16,118,70,224,126,165,240,223,148,192,249,141,121,57,140,42,190,97,25,103,162,76,64,112,228,165,34,80,240,133,225,25,237,161,90,117,153,71,72,105,87,238,65,125,105,236,185,79,188,138,1,175,167,21,15,251,44,124,79,241,49,140,188,62,132,176,164,156,167,193,57,229,144,18,64,204,243,79,41,191,101,5,48,43,131,155,8,42,28,106,209,168,200,242,156,69,192,116,11,37,47,14,129,139,26,167,68,224,75,177,87,176,239,103,140,51,223,3,210,189,96,40,142,62,150,52,241,91,44,216,162,169,86,14,210,200,98,28,86,167,190,126,181,129,34,248,103,201,248,226,17,187,0,110,1,79,175,255,229,56,222,210,50,13,103,82,20,26,73,79,198,14,169,139,109,227,37,90,155,13,189,5,71,159,192,222,208,100,181,25,17,176,175,112,70,124,109,141,32,72,26,140,62,38,7,73,44,131,213,199,164,178,60,194,42,35,54,231,155,58,211,33,14,7,111,179,105,112,196,121,198,143,51,62,167,133,145,144,119,213,56,10,131,229,214,121,189,69,60,189,236,7,226,105,51,51,32,68,193,108,145,106,241,22,249,237,229,103,56,46,226,68,4,160,122,214,119,12,219,142,7,58,98,40,145,216,238,95,31,78,28,73,188,97,133,225,246,156,46,146,140,70,62,134,57,60,230,153,64,7,145,127,251,228,12,212,244,47,12,37,117,226,73,56,189,63,207,4,218,33,53,82,210,81,244,146,39,160,6,189,56,128,111,193,56,27,73,130,70,7,8,40,110,180,71,169,87,251,101,156,192,129,237,171,245,26,206,162,17,12,146,228,31,108,33,130,119,28,207,245,133,255,9,35,222,167,94,109,42,234,137,184,193,168,12,81,206,135,119,250,147,133,230,234,211,117,207,32,87,66,130,5,13,246,26,178,146,39,248,80,104,161,56,81,80,139,241,150,45,250,228,107,4,135,81,212,200,235,68,38,46,162,218,47,158,57,52,78,133,239,253,251,71,163,172,31,71,241,52,5,235,224,204,235,145,239,191,55,14,224,32,184,234,134,191,198,248,236,189,126,253,243,175,63,255,250,234,151,191,254,228,85,38,174,229,81,112,125,98,104,91,66,222,212,62,33,138,156,65,132,121,199,143,230,121,177,240,97,215,189,71,248,71,219,49,58,101,10,62,49,158,49,121,216,192,246,73,44,8,67,106,129,215,219,118,216,52,89,147,195,231,139,47,21,226,83,248,249,170,237,204,36,63,164,139,56,73,179,2,18,253,50,141,30,222,163,182,55,136,19,20,156,167,195,123,43,195,179,141,76,97,80,5,139,143,174,55,163,98,54,72,166,218,255,78,78,7,7,163,147,193,43,255,40,13,179,8,245,124,57,62,254,91,0,216,247,23,5,19,74,207,61,251,100,196,245,176,88,163,9,176,102,128,0,123,2,95,151,225,64,142,141,223,153,93,136,74,2,117,176,120,192,118,93,241,248,22,134,93,44,16,238,32,69,6,103,222,167,130,189,254,139,118,105,100,178,215,202,32,86,69,66,109,122,190,29,213,170,195,69,123,130,244,128,58,150,49,241,81,11,83,86,155,139,17,28,86,115,42,207,184,70,166,16,216,0,64,145,78,25,135,236,193,208,134,210,113,150,101,183,198,16,0,111,48,136,34,117,106,251,158,230,204,188,85,168,172,200,50,119,177,8,224,9,49,192,222,154,160,13,174,52,66,40,55,25,197,163,81,129,55,241,65,174,213,34,209,140,30,141,247,72,123,188,128,36,70,109,65,134,194,29,37,195,189,214,126,30,125,118,105,127,83,185,171,210,215,119,16,6,94,156,29,141,71,227,193,217,225,224,226,240,167,15,47,109,172,192,214,59,40,164,100,130,217,76,230,135,96,186,115,192,172,177,6,10,45,112,240,29,3,55,180,177,116,149,2,102,21,190,179,86,166,81,60,121,84,250,109,21,119,155,155,155,100,199,170,244,229,3,16,97,140,121,130,32,115,40,171,192,124,130,10,116,179,9,187,147,99,130,69,82,56,132,118,61,13,14,9,221,222,101,26,3,179,4,170,114,208,243,36,134,192,148,77,8,196,172,10,229,206,166,92,89,35,82,27,23,123,154,186,60,198,164,130,0,212,188,179,234,81,167,191,165,227,227,5,19,57,36,119,172,218,193,169,34,166,82,244,138,59,99,80,90,212,232,83,171,176,185,71,246,122,18,19,143,22,153,232,144,153,248,35,133,166,10,155,171,235,90,110,226,171,4,247,24,22,14,57,157,20,86,121,245,116,92,116,170,15,210,103,65,202,156,132,202,209,200,1,157,231,20,2,63,196,1,150,147,155,133,252,59,140,86,233,180,128,8,100,235,53,212,40,106,95,112,93,193,144,0,61,85,75,151,99,83,244,187,49,101,55,255,129,8,155,196,233,45,139,84,19,207,97,191,69,64,235,65,247,142,100,217,13,251,55,107,198,148,79,65,26,58,228,140,0,129,114,158,122,63,125,34,31,40,150,250,205,70,144,219,30,48,170,106,148,189,165,44,67,92,146,110,237,91,54,107,95,23,184,81,0,91,220,118,87,193,138,217,70,141,123,6,177,181,185,164,171,200,149,192,167,144,114,128,196,163,119,105,23,126,172,148,199,241,156,5,151,69,120,150,221,183,10,228,131,218,26,86,20,202,181,140,27,117,178,197,233,138,229,102,147,173,178,181,75,220,207,161,100,93,110,115,110,213,10,160,196,81,177,170,82,139,172,178,116,120,240,202,45,91,141,121,90,50,221,182,123,69,172,157,174,117,134,134,11,21,68,201,42,31,86,126,182,102,192,127,68,96,104,4,5,27,11,103,97,198,163,47,15,9,75,142,145,135,119,217,121,172,232,88,34,227,194,155,90,175,74,89,251,139,11,205,236,146,72,98,246,178,102,44,145,133,61,195,36,211,166,99,10,125,249,162,17,62,180,51,5,38,199,69,55,210,143,142,121,54,175,221,19,17,85,175,190,210,117,149,231,154,173,175,90,107,246,175,60,87,237,192,109,31,180,118,107,188,119,20,210,132,242,29,20,227,222,26,231,28,246,49,32,195,6,225,20,36,51,57,234,186,134,171,184,240,246,100,201,129,206,55,97,24,48,176,236,90,110,80,131,57,84,157,5,154,17,141,34,102,116,45,86,154,17,246,77,245,254,134,146,87,173,84,245,71,75,163,79,142,203,52,220,25,233,47,54,224,30,129,104,98,63,208,93,193,181,172,171,190,227,201,105,120,11,9,135,190,216,121,245,18,254,233,27,20,85,143,1,135,154,163,53,76,111,156,229,190,133,176,97,145,218,36,6,224,97,60,22,183,104,54,152,195,41,140,94,207,49,86,181,253,30,0,55,193,108,238,226,2,181,171,229,135,165,17,106,161,234,66,75,136,238,87,81,102,31,212,177,37,69,128,105,200,213,175,101,96,130,171,213,1,136,110,148,18,51,14,43,203,102,133,42,160,164,62,220,175,31,249,117,249,191,81,175,12,100,103,119,204,105,42,212,189,168,115,60,13,69,150,72,19,126,203,238,88,18,224,117,220,37,22,88,243,184,128,141,25,150,236,228,99,99,99,137,96,236,141,86,71,99,205,71,133,203,28,147,21,62,139,215,11,40,125,111,64,199,54,187,213,66,117,236,84,104,244,95,87,9,63,236,118,234,109,187,45,150,3,185,201,46,66,159,245,105,126,63,139,19,70,252,238,237,238,218,198,237,182,42,227,22,229,85,1,229,0,138,121,172,122,198,84,220,202,155,100,149,106,16,145,67,58,64,10,236,83,178,121,156,144,66,165,120,80,220,99,87,34,42,19,198,215,14,59,178,141,129,77,78,111,79,181,52,228,139,175,57,30,53,26,5,228,32,186,114,42,119,115,213,189,113,5,53,253,48,189,203,110,153,175,170,104,176,24,239,252,221,104,12,185,198,37,143,199,108,158,39,234,250,70,119,216,71,184,255,177,236,211,69,144,63,133,120,141,178,159,69,139,81,177,72,16,12,240,233,42,171,122,26,188,231,20,175,98,84,176,210,165,190,74,162,156,5,234,81,240,119,129,105,177,169,113,86,195,201,171,116,19,100,101,194,191,132,75,223,57,143,141,67,186,151,114,117,4,209,45,194,58,107,87,121,156,65,134,46,42,51,105,251,230,74,146,4,97,212,103,190,108,64,106,172,114,86,2,109,73,200,255,149,247,159,177,251,247,144,194,184,209,123,71,81,52,180,246,193,156,167,28,27,156,184,174,191,148,159,61,213,37,252,98,187,54,199,252,255,141,65,183,16,197,194,74,188,143,99,46,100,74,237,237,13,5,196,30,208,37,156,209,112,180,227,101,47,212,195,19,124,223,78,25,159,202,75,92,253,60,75,23,113,89,52,151,49,181,10,91,41,172,188,201,233,22,178,153,195,120,58,191,178,249,168,89,232,166,254,220,92,76,31,178,130,200,184,80,29,28,152,2,138,34,20,36,231,89,8,106,90,215,171,98,112,13,141,169,225,32,191,79,128,87,124,198,225,179,180,218,138,59,21,208,227,7,67,121,117,201,107,52,121,194,18,16,20,208,149,3,84,106,124,109,129,157,246,157,253,110,80,83,126,108,44,65,21,52,57,107,78,55,196,209,26,125,186,34,203,181,189,8,108,123,167,211,39,54,15,167,118,49,165,191,38,88,224,69,191,91,183,124,189,53,201,155,120,61,197,246,124,76,73,51,84,181,101,109,46,151,142,187,56,118,164,227,87,125,113,222,121,25,164,175,189,20,17,181,162,65,186,186,33,219,24,149,33,198,3,19,68,117,77,103,38,72,240,170,18,248,82,151,102,42,5,86,36,228,149,109,197,86,112,140,53,43,214,81,135,251,238,92,202,234,142,214,48,157,100,230,142,249,128,166,127,194,251,84,170,248,81,113,87,117,89,116,103,10,91,80,237,177,9,235,214,73,110,173,121,177,188,98,194,168,230,31,197,189,71,94,90,87,98,10,89,80,139,167,190,92,183,222,214,98,122,96,12,198,80,30,70,15,115,189,146,120,23,237,122,31,230,161,83,123,56,52,86,247,235,165,243,107,207,132,124,165,26,91,253,29,194,129,155,61,29,178,132,46,88,36,143,77,111,175,106,226,144,98,70,49,29,140,100,104,21,56,83,128,247,54,145,130,214,140,222,83,33,219,6,112,236,69,120,171,80,167,142,127,104,12,66,105,234,128,240,124,67,144,197,164,57,212,170,100,203,214,73,35,62,232,132,141,214,67,148,106,114,200,171,102,82,234,209,193,179,172,24,130,84,228,44,50,139,234,217,192,234,230,28,212,153,131,187,131,216,34,175,235,106,107,21,207,67,253,1,35,73,117,151,5,159,215,103,99,157,107,44,229,22,120,105,136,165,247,23,187,135,21,188,190,204,79,66,156,133,9,11,92,46,199,98,138,240,145,8,24,18,189,96,97,156,227,245,131,183,39,191,99,15,145,99,156,129,13,114,243,78,150,103,186,211,128,145,229,65,87,66,163,97,52,221,146,62,90,173,147,206,41,16,159,80,193,108,2,25,246,226,119,241,181,177,156,39,120,102,254,38,93,169,193,93,235,168,215,213,78,165,221,190,25,148,112,213,245,148,174,213,105,232,231,170,54,64,202,21,2,118,135,63,33,88,251,218,93,47,251,160,150,121,123,77,60,95,90,52,252,185,173,243,19,64,157,48,0,62,201,178,219,35,69,175,157,185,119,64,249,234,103,6,164,193,172,17,239,202,137,255,250,32,110,103,52,154,136,73,108,58,198,230,58,152,185,222,34,50,192,178,122,134,76,43,127,110,54,223,30,151,169,115,48,3,132,242,56,26,28,54,71,2,155,201,144,6,127,97,28,169,99,210,123,192,167,37,218,83,109,77,122,209,15,196,51,60,129,139,99,170,38,202,60,207,28,214,63,215,249,103,61,197,214,57,44,234,84,73,248,75,15,13,21,206,40,191,234,254,29,200,117,107,26,78,88,112,53,149,234,145,223,212,176,51,10,7,112,209,91,150,78,139,89,221,166,223,208,253,93,223,121,105,147,145,237,240,253,36,11,111,125,197,119,159,188,236,47,249,225,74,207,77,42,245,172,104,133,120,103,217,178,186,13,46,165,113,173,37,244,150,10,53,36,141,95,130,49,5,7,169,177,245,130,113,54,224,156,46,172,222,184,51,131,171,230,105,107,76,53,152,131,29,59,32,117,87,30,199,167,106,110,150,226,171,251,248,78,183,92,23,174,70,187,21,230,174,209,218,143,206,84,185,208,191,71,209,191,195,194,91,61,193,228,13,153,158,13,180,89,169,103,128,251,196,25,98,236,24,69,62,128,51,170,50,62,237,104,247,150,63,98,0,7,218,13,110,174,90,129,237,186,118,193,206,9,219,38,78,215,244,88,117,231,191,235,248,28,98,176,162,120,147,168,17,243,202,208,35,167,4,214,142,61,146,91,66,249,84,93,240,27,218,110,109,101,251,182,60,208,88,74,111,42,92,2,168,78,81,142,187,196,199,183,189,198,143,244,220,95,76,142,22,216,70,195,66,73,40,18,216,253,144,198,208,254,97,198,81,23,25,207,138,126,157,124,172,168,57,107,49,105,123,117,42,208,53,69,134,118,36,235,81,16,88,75,205,29,35,191,84,207,67,59,83,191,213,164,170,85,78,119,15,170,235,229,253,85,163,139,253,166,193,174,42,188,155,182,242,208,68,73,183,20,236,73,111,156,26,129,35,225,158,103,224,7,32,21,205,242,114,35,106,112,235,122,165,117,175,120,179,40,24,132,191,48,155,231,152,160,178,72,187,103,123,83,7,26,164,237,120,219,181,219,233,43,122,229,115,234,238,174,217,64,169,237,162,128,3,252,130,222,27,82,18,97,99,62,170,123,40,74,54,76,206,216,61,254,245,123,141,121,39,100,9,13,168,107,161,187,205,122,225,178,145,162,245,38,135,150,168,123,61,61,203,160,176,124,194,103,13,23,123,92,42,132,106,76,24,214,241,78,185,0,97,61,170,58,215,107,36,178,7,51,22,222,202,94,183,252,253,42,102,214,230,138,188,59,145,253,250,10,228,220,250,189,236,51,43,63,108,214,252,167,43,34,240,131,61,20,173,53,226,206,73,203,103,240,239,127,11,137,40,99,75,63,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateMandrillMassMailingFinishedMsgLocalizableString());
			LocalizableStrings.Add(CreateMandrillMassMailingStoppedMsgLocalizableString());
			LocalizableStrings.Add(CreateMandrillPingFailsMsgLocalizableString());
			LocalizableStrings.Add(CreateMandrillTemplateFailsMsgLocalizableString());
			LocalizableStrings.Add(CreateMandrillNoRecipientsMsgLocalizableString());
			LocalizableStrings.Add(CreateMandrillMassMailingNotAllSentMsgLocalizableString());
			LocalizableStrings.Add(CreateRemindingMsgCaptionLocalizableString());
			LocalizableStrings.Add(CreateErrorLicPackageMsgLocalizableString());
			LocalizableStrings.Add(CreateErrorCountContactsMsgLocalizableString());
			LocalizableStrings.Add(CreateRedirectHtmlPageWithSysSettingLocalizableString());
			LocalizableStrings.Add(CreateRedirectHtmlPageWithoutSysSettingTrueLocalizableString());
			LocalizableStrings.Add(CreateUpdateSplitTestAudienceSuccessMessageLocalizableString());
			LocalizableStrings.Add(CreateMandrillStoppedMailingMsgLocalizableString());
			LocalizableStrings.Add(CreateRedirectHtmlPageWithoutSysSettingFalseLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateMandrillMassMailingFinishedMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ca44fd52-2da0-4c75-90d4-5b819d272d74"),
				Name = "MandrillMassMailingFinishedMsg",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMandrillMassMailingStoppedMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d8ce8c59-0b00-4bde-be14-1128af69381b"),
				Name = "MandrillMassMailingStoppedMsg",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMandrillPingFailsMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f5aead8b-e55a-47d5-afb4-b3c9abfb12bd"),
				Name = "MandrillPingFailsMsg",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMandrillTemplateFailsMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2c4f6d93-50f6-481f-8fc7-a61e6402709d"),
				Name = "MandrillTemplateFailsMsg",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMandrillNoRecipientsMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7f6b9d44-b15d-4140-b815-8c7d5ac03c5d"),
				Name = "MandrillNoRecipientsMsg",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMandrillMassMailingNotAllSentMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a9d448ad-03e6-44e8-b637-ef8ce004e18f"),
				Name = "MandrillMassMailingNotAllSentMsg",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRemindingMsgCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("44be7d51-91eb-4738-bc88-3b95aaa69eef"),
				Name = "RemindingMsgCaption",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorLicPackageMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1dbbdb2d-1964-49d0-bc2b-ad0373ecc0b4"),
				Name = "ErrorLicPackageMsg",
				CreatedInPackageId = new Guid("e8f16034-77e7-4b36-b64c-5a28e91e0820"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorCountContactsMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("582dfece-f1a3-42bc-b398-0e1cb134b5b6"),
				Name = "ErrorCountContactsMsg",
				CreatedInPackageId = new Guid("e8f16034-77e7-4b36-b64c-5a28e91e0820"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRedirectHtmlPageWithSysSettingLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("200b6c5a-c878-4f44-b719-bb84151657d0"),
				Name = "RedirectHtmlPageWithSysSetting",
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRedirectHtmlPageWithoutSysSettingTrueLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b76bc353-7f64-4921-9f7f-9e1acc57f2ad"),
				Name = "RedirectHtmlPageWithoutSysSettingTrue",
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUpdateSplitTestAudienceSuccessMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("214b886f-2479-4d11-a087-859c55a99b5e"),
				Name = "UpdateSplitTestAudienceSuccessMessage",
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMandrillStoppedMailingMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d5186feb-0b32-4db8-94dc-92fb3fa4398d"),
				Name = "MandrillStoppedMailingMsg",
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRedirectHtmlPageWithoutSysSettingFalseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b33e5f04-a912-4cd1-812b-a0f5e8e79d78"),
				Name = "RedirectHtmlPageWithoutSysSettingFalse",
				CreatedInPackageId = new Guid("9a681325-ee36-4de2-b9a2-8e04cfb5b011"),
				CreatedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"),
				ModifiedInSchemaUId = new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("535378d1-2d09-44e9-a1ab-366f968dd4aa"));
		}

		#endregion

	}

	#endregion

}

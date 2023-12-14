﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmnichannelChatProviderSchema

	/// <exclude/>
	public class OmnichannelChatProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmnichannelChatProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmnichannelChatProviderSchema(OmnichannelChatProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e94751c1-9439-4b80-9da4-b31915167fdf");
			Name = "OmnichannelChatProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aa784342-25af-480c-b5d1-88617bf6f672");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,28,107,111,220,184,241,243,30,112,255,129,183,87,224,100,192,209,222,29,90,20,112,226,13,156,181,115,231,94,28,167,126,52,64,139,67,32,75,180,87,141,86,218,136,146,157,109,224,255,222,25,190,73,81,90,109,146,22,5,154,15,201,138,226,12,103,134,195,121,82,41,147,21,101,235,36,165,228,138,214,117,194,170,219,38,94,84,229,109,126,215,214,73,147,87,101,124,190,42,243,116,153,148,37,45,226,51,202,88,114,151,151,119,223,126,243,233,219,111,38,45,131,159,228,174,168,110,146,226,224,96,81,173,86,48,255,85,117,135,51,158,234,247,22,2,13,31,124,251,166,174,238,243,140,214,44,62,174,86,73,94,198,39,101,147,55,57,101,102,246,229,134,53,116,229,63,3,197,69,65,83,36,151,197,191,208,146,214,121,218,153,243,42,47,63,152,65,155,91,36,59,252,166,166,125,227,241,241,139,222,87,93,178,189,9,151,180,190,207,83,122,86,101,180,0,97,55,117,146,54,161,201,111,233,205,0,121,248,246,215,166,89,199,71,55,140,163,64,246,205,68,33,107,122,156,215,66,50,228,112,148,172,99,31,206,23,228,37,109,26,120,98,128,143,51,227,106,11,204,81,19,0,16,64,191,175,233,29,174,190,40,18,198,14,108,18,22,203,164,81,100,240,169,179,217,140,60,99,237,106,149,212,155,185,124,150,19,24,73,72,138,24,200,109,85,147,135,170,126,143,4,61,228,205,146,84,6,35,129,127,27,22,43,84,51,11,215,186,189,41,242,84,226,232,37,98,242,137,19,162,137,126,153,211,34,3,170,223,212,249,125,210,208,137,120,187,22,79,164,166,73,86,149,197,134,92,51,90,131,24,74,41,232,119,173,243,252,212,133,98,13,72,42,53,192,176,119,200,203,187,12,94,190,172,234,85,210,128,100,167,27,248,243,195,147,31,206,206,224,175,44,187,250,245,215,31,14,126,88,173,224,47,198,166,79,123,200,64,94,206,215,20,118,162,170,23,73,186,164,228,93,234,15,13,193,94,208,117,197,114,152,185,17,128,230,185,15,234,85,206,154,103,130,129,57,192,128,42,131,26,194,97,108,87,37,234,71,73,31,220,41,104,52,38,147,233,66,76,140,79,179,233,190,59,242,26,204,145,63,246,102,89,53,149,63,120,2,74,91,248,131,71,105,90,181,101,8,175,122,195,241,227,171,199,113,44,85,74,118,91,121,82,82,86,43,171,231,184,203,108,231,149,205,117,231,165,96,223,166,249,123,90,102,66,65,93,109,5,8,32,170,77,1,26,117,150,107,188,228,82,104,127,143,222,71,158,254,186,234,187,39,57,244,180,26,68,209,81,115,156,213,209,56,41,179,142,114,70,222,50,22,188,165,136,6,216,12,6,33,31,135,101,3,188,194,226,104,224,240,52,87,13,128,210,204,85,1,155,194,215,85,147,223,230,180,54,26,160,70,158,10,16,137,33,12,212,25,16,18,188,163,141,252,53,169,105,211,214,101,23,59,240,219,29,123,254,188,35,65,245,46,122,23,148,226,163,37,17,197,158,2,61,75,74,48,239,22,103,114,192,99,204,159,238,63,111,101,73,77,4,234,163,206,160,216,86,15,103,135,153,1,110,164,151,210,204,172,156,103,14,231,187,19,62,192,221,16,121,88,194,57,32,44,185,167,36,41,51,194,64,105,136,196,192,0,134,82,146,214,244,246,112,234,174,50,157,205,133,3,137,53,122,219,197,88,194,243,168,243,30,123,69,231,50,129,186,224,141,72,77,112,241,141,208,129,160,40,44,62,79,33,104,67,238,242,213,186,160,43,90,54,220,153,147,28,236,73,82,166,180,151,95,177,23,8,13,254,139,54,96,146,25,134,127,29,101,226,51,142,237,9,253,66,112,240,8,237,113,135,14,9,252,144,188,67,180,215,136,225,104,106,89,55,185,212,52,164,65,125,22,226,140,54,203,202,114,246,174,190,221,84,85,65,142,24,203,239,74,165,181,209,47,109,158,241,144,227,52,219,39,252,65,169,57,14,188,169,105,150,167,0,251,140,135,86,155,57,89,171,17,101,82,239,147,154,195,159,176,15,24,77,129,15,106,40,252,126,11,97,141,116,56,81,143,187,153,76,47,97,143,90,38,189,70,199,253,76,166,224,241,232,186,57,6,140,122,72,132,116,52,235,204,93,20,21,163,206,212,191,182,180,21,142,114,242,40,101,168,136,5,74,37,205,40,124,193,155,175,130,251,82,44,18,52,191,37,145,102,62,194,87,123,74,4,19,124,130,128,88,70,13,127,75,138,150,70,146,57,244,152,193,236,129,59,58,22,159,150,96,201,239,106,24,69,211,40,96,228,138,97,180,231,122,123,0,177,217,43,5,131,100,122,140,32,139,167,236,37,108,76,91,211,147,50,185,41,104,6,228,1,94,37,178,243,242,188,109,238,42,160,74,158,202,169,225,205,247,102,177,13,40,228,32,151,126,36,180,96,84,195,5,169,183,118,137,148,109,81,104,88,241,79,215,243,198,215,107,12,42,143,128,147,123,138,34,98,11,12,130,34,91,75,127,82,88,2,224,23,116,85,221,83,165,53,136,32,114,182,85,29,89,65,45,24,211,232,54,1,46,236,51,167,166,240,23,182,159,86,231,42,66,180,50,212,217,39,214,195,30,249,133,170,223,71,165,214,89,224,63,121,177,89,112,50,236,3,168,100,238,156,149,180,3,110,226,56,47,90,197,112,11,180,51,242,35,190,189,248,170,66,156,145,119,10,6,142,108,239,170,95,126,144,164,52,35,35,26,33,15,9,204,53,106,31,5,231,138,203,126,189,23,218,5,75,238,196,199,221,47,235,17,178,240,164,252,213,36,48,36,128,16,131,199,57,71,6,158,235,25,50,226,104,218,220,22,24,115,152,230,218,132,0,115,73,5,219,133,119,95,149,12,243,64,22,122,81,241,226,101,94,52,220,173,41,89,8,108,98,24,17,190,73,106,72,16,224,129,69,98,112,81,173,214,73,157,179,170,188,218,172,105,124,242,161,77,138,125,50,213,25,198,68,18,27,47,18,160,191,186,249,39,136,114,30,161,42,31,213,117,178,137,148,91,84,11,10,172,44,62,202,178,40,64,154,183,107,44,180,109,166,2,211,19,142,32,52,152,234,182,104,100,240,55,184,37,234,184,65,182,79,193,22,217,218,7,81,137,191,25,190,66,49,224,168,204,58,198,10,23,231,60,106,159,189,253,160,184,102,76,224,216,245,4,73,172,226,31,78,160,34,92,162,85,209,189,66,32,185,2,94,5,63,40,102,220,233,204,242,7,66,45,35,149,225,190,131,205,223,147,187,143,233,228,16,164,52,143,6,150,231,159,10,154,231,155,0,14,144,252,103,52,150,2,62,27,201,80,152,120,142,190,19,33,34,171,87,240,50,105,87,73,119,85,189,111,215,28,80,251,73,241,52,94,72,18,163,45,172,201,113,206,214,69,178,217,138,170,67,172,66,38,164,103,251,226,199,17,26,18,84,188,128,138,40,213,86,160,219,153,181,162,156,61,242,221,33,201,232,109,130,199,238,121,159,158,141,83,52,133,246,93,64,227,198,171,92,7,139,163,123,187,43,95,7,95,71,11,31,201,129,207,120,228,58,19,75,188,161,141,147,5,58,140,4,87,16,223,93,215,133,48,71,107,177,146,218,40,72,143,174,206,143,207,15,192,72,96,216,68,154,101,206,120,118,153,151,96,67,203,164,128,12,19,51,12,178,108,154,53,59,152,205,82,52,243,121,21,39,13,230,148,121,82,198,37,109,102,55,117,245,192,232,236,226,245,241,147,159,255,252,243,31,127,214,1,244,117,157,199,87,96,152,185,115,192,8,224,104,189,46,48,162,6,35,138,52,129,227,135,41,191,129,225,195,130,48,72,170,161,16,228,182,13,142,146,182,206,77,88,42,217,134,177,24,112,64,58,20,77,103,249,234,110,70,185,246,205,150,9,91,206,46,55,140,115,59,67,253,156,65,196,41,185,5,31,114,201,229,1,78,68,175,3,43,4,140,165,144,91,124,178,90,55,155,97,185,250,156,184,214,17,107,220,184,61,244,99,19,47,218,186,6,50,81,173,49,4,22,252,60,39,111,233,205,117,147,23,162,128,13,8,95,36,140,122,72,3,88,32,192,253,208,82,214,200,179,123,224,21,184,17,145,8,189,59,33,201,244,50,71,174,11,144,139,205,101,48,244,16,103,250,18,2,234,85,2,105,85,189,9,71,11,110,224,202,53,82,68,13,193,128,3,21,186,131,184,147,188,216,51,100,194,12,180,99,70,133,135,97,234,69,1,215,32,179,108,149,151,23,249,221,146,59,121,19,180,235,57,111,68,116,192,151,19,4,198,167,236,168,120,72,176,236,143,1,0,128,53,117,75,29,239,77,34,78,60,159,174,188,183,199,157,94,0,220,179,120,21,137,249,33,47,44,231,246,25,89,153,135,145,179,100,109,61,70,215,37,86,204,50,245,86,86,86,246,135,50,144,110,36,143,167,161,199,121,43,196,182,243,150,139,196,16,108,72,151,214,130,9,168,173,55,221,46,205,97,167,115,3,137,110,90,173,240,172,60,151,102,18,228,21,36,45,62,5,253,253,9,12,222,192,235,159,37,41,87,57,55,217,104,91,225,215,105,137,69,96,252,245,247,170,164,145,34,15,7,88,147,172,214,123,230,224,91,157,10,101,99,175,224,84,117,153,146,47,237,14,84,31,219,10,15,88,249,238,44,28,85,242,107,128,173,37,86,168,152,53,207,26,149,243,78,217,139,74,239,136,181,15,236,36,93,86,253,62,154,219,117,244,61,9,218,135,237,153,143,56,207,226,56,10,253,239,68,191,130,158,88,42,245,84,96,70,255,36,95,188,172,171,85,100,206,36,156,207,42,213,47,223,46,105,13,153,63,140,136,240,126,15,57,192,104,63,146,135,79,167,6,42,216,149,144,36,97,146,160,142,167,227,52,199,39,31,105,10,150,251,50,77,138,164,150,206,84,155,175,201,36,108,167,229,193,56,205,132,167,144,146,81,131,178,6,38,139,53,70,88,42,105,29,47,164,133,66,33,214,241,100,229,81,129,162,73,115,61,231,20,32,235,191,84,185,65,3,82,59,98,209,20,164,26,159,151,248,239,24,89,74,22,182,99,213,104,57,94,213,82,113,240,79,59,175,220,237,5,234,225,189,102,26,33,75,69,212,101,213,214,41,85,130,73,53,241,18,197,36,62,66,247,45,49,40,193,12,242,166,38,117,85,101,207,211,10,21,180,245,232,133,149,28,219,9,52,228,101,145,84,25,167,54,250,1,75,138,94,161,70,64,155,122,148,211,96,179,149,146,71,64,18,3,154,72,124,39,125,174,50,184,94,1,150,151,120,220,234,155,69,229,105,230,20,54,80,62,140,234,51,100,213,3,45,132,223,5,151,157,88,212,243,228,178,91,87,148,73,129,83,226,115,121,246,26,33,46,165,76,231,171,74,132,18,175,83,80,143,143,233,77,123,39,204,114,244,135,41,96,112,228,138,109,115,158,33,127,18,200,30,245,154,236,128,124,146,65,140,80,112,208,36,187,58,202,246,30,167,198,11,219,39,218,154,179,205,23,3,57,242,167,150,187,167,35,186,184,235,57,104,37,104,27,219,138,221,25,173,88,41,43,47,66,66,189,49,48,73,184,55,11,146,133,118,59,126,149,176,230,188,62,22,105,146,82,56,119,187,68,0,19,242,169,114,141,225,66,37,234,52,174,236,107,152,160,209,11,84,116,100,210,19,126,4,34,34,37,144,209,45,14,171,55,28,236,13,137,78,7,211,91,76,32,43,107,150,84,36,120,26,106,214,105,41,173,209,206,144,18,108,205,225,84,240,58,157,11,67,205,59,153,213,173,192,240,108,198,39,134,225,140,90,249,176,234,205,48,124,194,105,23,109,130,44,71,255,50,157,43,1,18,253,18,165,43,222,118,177,9,169,178,249,21,68,178,36,55,235,146,7,176,149,2,3,5,149,173,64,34,245,67,206,240,246,0,7,16,17,51,224,83,8,248,113,16,189,247,251,188,110,192,32,219,141,36,187,161,187,115,51,169,203,165,210,252,33,179,112,100,216,71,99,192,47,208,192,82,218,40,192,54,107,102,63,25,2,180,5,192,115,144,51,69,244,145,20,5,232,176,215,26,83,140,216,60,4,40,54,167,184,139,84,31,228,33,126,22,65,46,236,109,218,202,146,14,230,142,115,52,73,55,109,83,169,254,244,66,132,75,45,181,94,245,148,55,7,169,212,224,189,130,239,16,195,151,13,251,48,77,213,169,95,226,244,184,136,245,111,97,236,56,208,24,122,251,165,154,105,140,92,176,220,33,137,25,28,185,225,99,8,253,171,42,201,80,18,106,51,66,222,233,22,66,61,146,98,27,202,17,141,1,57,12,92,110,178,253,38,19,151,76,84,144,67,136,140,182,170,53,57,196,144,35,214,98,100,226,170,77,94,50,75,74,22,156,140,89,43,14,135,89,50,186,118,175,45,52,200,239,249,0,159,15,64,19,41,64,32,32,208,0,207,254,125,143,88,180,117,145,118,62,180,57,98,155,50,213,49,7,243,186,37,142,147,232,30,49,219,103,4,221,0,70,17,162,6,11,214,183,45,241,146,148,185,99,55,198,7,184,182,124,216,134,43,163,185,8,46,56,104,84,243,146,215,84,175,57,0,10,71,118,58,61,59,234,167,111,61,161,23,71,240,98,163,141,153,109,196,236,14,167,70,163,235,167,76,41,75,4,121,109,85,195,130,160,51,226,231,80,17,147,7,244,161,70,163,44,127,255,104,236,164,92,15,194,126,108,227,232,234,137,156,56,62,199,122,217,150,105,44,132,100,231,19,59,164,163,215,229,186,174,82,136,85,104,118,198,238,56,42,158,119,252,194,171,91,181,202,60,120,175,62,250,209,75,88,236,140,182,236,36,41,76,177,169,201,226,189,239,23,69,149,190,143,246,172,132,69,190,117,211,22,80,6,157,54,184,117,35,164,241,179,116,94,223,13,194,234,149,44,65,162,120,121,125,183,45,181,175,217,122,54,148,14,255,70,55,79,238,121,199,97,157,228,128,6,219,114,194,226,114,243,0,90,43,48,187,171,139,59,140,131,39,161,211,85,67,105,152,179,161,226,96,177,243,74,127,100,233,14,148,71,189,215,197,188,241,73,187,149,215,170,161,160,138,140,87,52,245,4,7,177,20,123,47,245,198,238,112,128,198,189,134,176,63,210,250,117,94,247,76,235,73,136,253,162,169,44,14,163,157,143,183,106,160,83,93,233,200,79,41,230,73,217,174,128,148,155,130,70,2,27,110,5,182,124,231,92,190,160,12,220,28,188,1,85,176,118,77,206,149,147,185,97,10,155,142,253,193,137,28,85,120,43,52,115,87,149,209,155,232,35,210,245,49,6,170,246,137,252,205,49,237,141,59,58,168,191,74,99,119,79,21,250,83,4,227,30,84,167,89,28,24,189,86,240,92,156,26,217,63,179,146,172,121,48,49,12,221,37,113,128,156,6,118,231,181,93,171,144,189,106,211,126,227,11,24,139,109,211,101,46,24,176,190,186,197,5,45,18,121,7,135,117,194,62,27,151,91,229,158,131,9,177,159,209,225,185,151,7,99,147,153,51,157,174,42,235,107,199,164,159,159,252,186,196,58,61,1,149,187,131,89,245,8,53,245,21,171,111,191,99,162,236,213,95,236,163,218,109,228,15,248,2,209,44,221,89,167,117,53,78,169,181,188,208,61,152,188,234,210,163,117,24,248,167,55,131,80,117,245,32,142,180,9,158,176,141,184,21,232,252,246,150,81,128,186,128,201,0,132,15,255,141,131,119,84,20,222,185,235,171,33,115,75,72,20,123,160,110,127,250,81,15,9,226,49,60,250,210,3,139,170,136,119,128,249,45,156,64,157,219,34,207,148,134,205,89,23,160,210,17,157,215,188,62,104,5,103,110,106,112,82,215,85,109,50,45,169,92,185,92,138,39,89,101,213,64,166,208,66,0,112,179,33,154,22,242,143,79,154,142,199,223,121,124,160,75,198,248,78,253,126,252,93,103,15,93,101,151,167,0,25,78,204,38,108,177,10,151,156,63,201,230,190,189,57,106,99,246,205,126,88,114,177,86,240,226,85,21,57,139,234,167,61,79,198,26,43,244,59,86,173,110,21,47,84,181,14,147,218,188,196,38,190,159,131,217,87,27,82,115,1,199,217,211,128,101,194,219,66,181,83,1,212,73,221,224,173,49,59,23,237,189,65,38,151,232,88,191,128,207,119,144,131,58,212,27,180,139,122,21,99,17,141,244,96,101,62,17,157,245,83,235,109,229,218,104,49,135,175,167,102,13,249,140,149,81,11,123,107,68,80,198,119,70,172,46,46,158,57,53,85,179,79,157,221,177,12,249,69,82,26,243,237,238,185,111,226,247,73,100,109,229,190,195,25,44,242,149,76,188,21,179,136,44,92,122,35,221,56,28,105,243,229,244,233,252,218,131,255,74,70,85,69,249,94,105,125,123,155,219,201,124,63,223,149,219,59,45,57,83,251,237,68,194,159,83,209,222,178,73,140,44,65,155,240,147,160,155,141,74,146,84,109,120,215,48,115,225,130,143,217,28,25,150,126,97,180,249,171,96,33,20,108,238,22,196,245,148,5,97,251,238,33,125,230,151,94,220,184,107,231,91,14,187,135,118,234,90,145,75,172,62,221,170,77,211,61,227,163,194,184,109,103,120,93,211,39,183,57,236,87,70,188,195,71,26,186,90,99,248,60,86,77,22,97,53,113,14,177,119,32,189,83,135,238,160,109,196,165,13,117,137,65,18,17,218,251,49,9,131,21,46,239,16,197,187,65,188,187,53,230,94,132,116,207,228,185,25,240,93,34,57,144,86,124,196,194,254,5,10,221,104,243,145,90,125,86,143,180,239,188,102,158,125,217,198,147,181,154,49,185,160,105,190,206,41,15,19,93,116,159,123,203,198,195,34,226,32,114,224,99,215,11,171,68,124,114,169,130,201,255,8,29,134,209,14,41,98,97,77,71,224,27,240,206,114,90,81,53,212,66,197,22,210,205,155,43,127,246,20,25,121,118,120,212,175,140,52,248,29,134,238,76,49,238,19,43,239,0,237,242,173,58,191,5,143,119,144,36,170,71,39,42,8,5,224,24,122,3,110,8,180,241,11,52,45,130,142,201,232,86,236,15,32,60,183,95,67,152,30,235,254,184,211,51,14,45,59,110,213,3,33,249,99,146,51,66,49,155,136,167,161,122,102,247,48,68,219,109,229,89,82,191,199,176,206,117,103,88,209,210,5,162,93,237,100,79,213,198,51,145,247,21,216,61,92,29,193,142,216,5,77,130,87,171,124,207,230,65,216,70,109,136,77,60,8,140,243,137,82,226,188,150,188,135,34,110,132,50,236,94,37,247,176,63,232,112,237,78,20,70,127,130,203,154,222,74,70,229,189,139,233,108,254,133,145,198,112,66,174,150,153,203,35,36,219,107,99,193,115,246,154,62,240,98,234,252,148,73,150,129,247,219,34,185,235,143,63,159,165,188,203,253,108,150,206,177,211,109,203,8,83,226,134,203,169,220,216,157,27,22,147,243,78,231,27,240,240,214,8,34,26,209,0,55,157,73,36,120,232,190,208,190,0,208,204,201,11,166,253,23,70,136,235,58,122,239,25,249,119,150,212,226,238,37,27,247,14,16,27,153,228,239,122,23,7,147,121,217,75,149,203,63,74,201,66,24,195,45,0,41,128,15,63,177,183,46,232,62,106,106,181,164,52,109,78,201,205,186,208,148,59,87,120,188,175,22,221,198,42,36,109,206,119,128,254,133,150,208,231,148,210,250,118,90,152,64,158,114,113,166,143,105,11,217,111,98,58,86,53,132,78,106,192,105,57,14,31,255,59,132,199,233,145,108,197,195,35,50,117,201,200,191,221,164,180,73,229,95,79,123,23,181,99,246,173,75,239,227,138,125,200,252,246,103,23,141,27,169,235,139,218,67,134,244,66,30,112,125,135,2,141,141,165,176,248,56,214,40,98,11,37,211,94,227,152,123,13,62,198,185,27,52,110,165,208,105,3,200,205,58,111,53,246,64,43,19,132,21,22,219,124,9,6,248,25,52,107,123,12,241,215,202,113,4,173,153,52,89,234,254,255,158,109,78,32,129,225,151,8,240,211,22,239,251,73,75,2,210,204,105,198,190,198,71,225,138,2,251,127,20,145,31,115,155,255,250,196,249,162,187,42,50,105,85,229,154,131,95,98,90,228,91,56,74,109,153,71,224,48,252,10,4,210,244,235,255,244,66,124,72,36,201,26,249,45,145,248,134,200,193,247,65,109,128,168,253,110,71,198,133,228,96,82,247,150,109,210,246,13,226,237,49,72,231,232,160,146,101,210,140,186,250,56,190,171,224,158,33,247,106,157,209,231,225,72,193,62,76,10,67,22,58,84,253,113,67,240,84,245,84,69,182,156,21,255,191,37,248,223,56,54,255,15,135,36,11,72,126,236,121,9,226,13,31,153,208,50,219,79,143,240,139,13,68,234,248,161,10,132,161,206,197,11,62,248,175,170,28,93,212,105,212,151,44,211,249,149,66,40,86,24,42,206,242,9,120,215,13,64,194,202,141,255,33,3,71,24,254,144,166,168,64,206,122,109,125,69,83,1,101,168,16,234,73,52,80,248,205,8,72,235,62,226,208,89,94,64,224,71,241,174,42,139,12,154,248,186,73,21,148,35,249,76,22,188,39,147,1,201,190,104,243,2,194,80,254,69,31,105,235,98,172,8,229,39,128,190,217,225,195,253,66,188,174,11,20,182,154,21,16,161,249,192,68,124,243,25,250,186,82,242,39,71,59,101,50,85,43,177,63,210,212,24,14,122,63,69,244,46,74,139,81,119,144,143,225,159,127,3,85,216,23,2,42,81,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e94751c1-9439-4b80-9da4-b31915167fdf"));
		}

		#endregion

	}

	#endregion

}


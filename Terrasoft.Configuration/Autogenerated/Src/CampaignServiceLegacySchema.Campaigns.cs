﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignServiceLegacySchema

	/// <exclude/>
	public class CampaignServiceLegacySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignServiceLegacySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignServiceLegacySchema(CampaignServiceLegacySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("694791be-7ea5-453a-ac4e-518c732e3007");
			Name = "CampaignServiceLegacy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,28,253,111,219,54,246,103,15,216,255,192,243,126,152,220,203,41,105,119,183,3,214,38,69,210,36,173,123,77,218,197,201,10,44,8,6,89,162,19,181,178,164,82,82,82,175,203,255,126,239,241,67,34,41,202,178,211,166,232,221,10,44,54,69,62,62,190,239,15,202,36,13,230,180,200,131,144,146,83,202,88,80,100,179,210,127,150,165,179,248,178,98,65,25,103,169,255,44,152,231,65,124,153,78,40,187,142,67,250,253,119,159,190,255,110,80,21,113,122,73,38,139,162,164,243,199,214,119,88,159,36,52,196,197,133,255,156,166,148,197,97,107,206,126,80,6,173,65,185,197,81,22,209,100,233,67,255,45,157,46,159,176,11,251,95,243,3,180,230,61,79,178,105,144,196,127,186,159,158,94,49,26,68,48,208,253,196,63,13,138,247,69,243,252,152,222,148,112,86,36,221,203,2,40,246,42,78,63,52,79,127,173,2,86,254,105,127,247,199,243,60,241,79,89,124,121,73,153,6,75,231,194,124,174,227,103,63,225,123,185,31,51,218,53,94,115,179,123,130,206,252,206,89,135,65,88,102,44,166,29,152,195,140,253,189,206,71,147,240,138,70,85,66,153,107,6,112,214,127,81,150,185,191,59,45,74,22,8,49,130,137,48,245,7,70,47,225,27,121,150,4,69,241,11,177,4,243,21,189,12,194,5,159,184,185,185,73,158,20,213,124,30,176,197,142,252,46,103,145,16,23,147,89,198,200,60,72,131,75,220,60,75,34,18,74,96,133,175,214,111,106,0,206,95,79,139,44,161,37,245,134,255,246,31,62,242,183,200,95,228,172,160,54,10,36,78,65,82,130,104,56,186,192,69,114,20,40,202,15,194,199,118,139,252,152,150,192,193,28,8,60,141,147,184,92,156,208,15,85,204,232,156,166,101,225,233,95,80,146,201,54,233,89,130,179,124,57,16,241,141,243,106,154,196,161,60,105,7,149,6,159,56,165,26,154,2,149,203,0,192,253,66,222,48,212,28,42,158,231,226,11,9,241,57,1,142,32,193,20,204,151,217,244,57,203,170,252,24,140,8,32,58,84,227,195,199,75,22,131,102,86,168,126,116,82,210,188,128,37,65,46,64,217,80,38,139,52,132,225,59,0,123,195,178,144,22,69,7,64,249,244,14,112,159,177,44,61,248,152,51,88,13,52,123,19,148,37,101,41,238,176,69,182,200,207,155,159,182,110,201,3,248,247,148,60,112,3,143,211,146,236,211,89,80,37,165,141,19,71,105,156,2,192,235,32,1,144,143,126,90,29,61,105,69,20,72,19,75,137,222,230,195,127,113,220,122,176,123,145,85,236,40,78,171,146,22,207,178,10,6,182,201,207,91,221,103,9,22,184,64,205,124,244,207,101,56,159,100,0,21,109,214,110,20,141,211,89,54,17,46,2,241,11,196,200,82,142,212,203,15,227,4,168,164,173,22,3,29,252,140,50,80,6,170,168,14,71,139,231,213,28,240,62,101,65,90,196,8,66,97,191,229,111,61,220,82,39,248,129,166,145,208,12,83,77,64,118,114,202,74,48,124,160,39,92,205,204,77,193,40,0,57,210,84,98,247,71,101,124,151,192,109,243,196,7,158,211,178,32,96,149,10,252,139,203,240,0,114,157,95,175,210,141,146,210,115,107,79,235,43,122,235,193,224,146,150,242,211,128,209,178,98,45,212,200,211,167,226,241,192,179,159,108,19,180,199,104,197,232,71,176,224,21,99,96,118,192,219,114,241,58,31,154,251,13,47,72,80,88,56,140,30,115,208,183,252,255,69,131,73,123,35,144,253,138,106,179,111,151,16,108,55,229,230,54,72,193,238,102,51,82,94,81,152,67,129,239,140,206,182,135,135,96,212,41,123,65,19,96,215,112,115,71,24,195,46,58,74,230,233,107,200,31,51,237,219,99,141,220,198,44,227,75,39,169,117,80,64,104,226,153,35,219,36,165,55,6,40,111,212,73,51,107,229,58,20,51,68,12,233,165,156,30,185,226,224,124,50,214,8,170,17,83,89,150,154,156,61,132,52,231,11,151,67,254,8,141,81,157,164,206,249,230,96,55,113,77,176,130,188,214,152,32,176,107,23,207,146,212,78,178,183,32,222,153,240,53,209,105,10,209,7,37,101,38,34,145,134,29,5,146,29,232,24,145,155,184,188,226,184,71,180,128,7,192,34,5,178,131,83,99,117,200,3,14,188,159,85,214,130,134,156,226,59,63,160,29,253,60,130,232,71,26,194,5,137,225,100,242,49,9,82,68,57,73,200,148,18,136,78,178,107,56,66,156,146,42,15,179,57,218,112,70,19,26,20,180,16,241,145,226,190,141,130,245,181,151,241,114,158,193,120,57,102,50,94,12,174,205,242,26,86,7,203,187,124,197,17,45,175,178,200,14,168,186,5,36,78,195,154,165,19,138,25,20,15,83,25,58,190,31,11,242,114,242,250,184,203,130,241,145,60,96,193,156,96,66,183,61,84,184,143,163,225,206,89,26,127,168,32,54,141,192,108,199,179,24,164,23,54,80,19,252,39,155,124,157,27,12,68,179,249,233,34,167,157,96,208,138,224,36,3,140,146,45,121,8,56,28,134,41,220,129,23,98,236,148,66,246,3,83,188,231,85,220,196,222,227,104,131,224,192,83,210,236,139,44,172,146,100,36,185,114,29,160,22,113,176,130,183,2,158,205,83,62,23,243,208,106,158,122,77,252,167,176,24,110,144,33,28,105,228,239,22,222,144,143,224,183,21,22,33,15,228,50,241,81,172,57,100,217,220,92,161,158,140,1,37,246,50,139,157,0,71,254,235,174,141,38,16,86,133,60,186,171,49,3,96,197,193,7,8,251,172,157,228,89,196,126,111,175,40,163,237,9,207,26,113,24,213,96,196,73,253,55,200,55,208,94,230,53,124,24,141,208,139,11,218,10,129,143,103,196,107,184,226,191,8,138,223,80,27,20,95,6,130,41,254,110,26,181,119,151,18,180,100,231,6,178,169,142,82,213,139,6,145,94,51,59,23,33,30,1,235,20,103,17,202,40,2,23,90,132,198,168,22,252,59,104,82,181,76,147,92,26,32,163,79,64,76,70,158,53,147,223,112,244,108,249,87,228,148,154,243,14,194,221,137,146,246,101,106,164,65,16,228,147,27,67,14,0,81,47,44,254,199,195,72,60,16,233,182,183,191,119,240,145,134,21,228,240,36,154,214,31,183,173,192,205,63,72,139,138,209,253,189,102,8,34,19,197,114,9,106,140,165,156,19,200,122,129,28,17,194,104,176,246,5,100,42,158,122,205,78,13,144,65,196,124,124,236,73,196,145,231,18,103,93,140,138,23,224,91,18,240,127,251,20,48,140,121,238,211,142,226,61,0,246,28,83,101,20,47,46,159,79,68,246,176,163,244,117,67,110,50,112,70,168,131,193,205,85,12,100,243,106,164,26,60,107,146,54,220,35,219,234,217,224,94,113,237,196,150,107,165,142,208,19,201,113,13,237,134,158,218,196,26,192,173,252,32,255,202,63,28,172,88,246,4,18,163,6,90,13,171,47,159,122,172,195,51,116,89,128,232,213,229,9,234,114,10,9,7,153,197,12,130,164,120,46,194,11,202,37,8,221,171,84,112,116,145,165,72,128,63,75,183,215,244,146,226,52,197,142,200,30,97,106,48,155,1,119,32,224,97,217,77,1,243,213,4,221,28,96,206,124,150,71,240,81,201,203,33,28,238,20,206,214,101,8,208,223,33,21,212,60,36,61,44,199,143,254,89,25,30,103,55,143,235,121,184,241,174,194,2,216,102,88,2,164,162,146,218,37,246,168,101,72,16,101,92,43,168,61,78,101,113,0,128,120,240,104,116,20,148,87,62,0,0,179,239,105,91,60,48,75,3,15,90,117,133,209,6,17,18,114,20,71,57,184,199,146,195,192,218,234,238,77,176,64,127,250,59,101,217,168,57,92,160,42,30,245,33,248,254,147,5,152,194,178,132,133,88,106,46,185,30,89,193,0,56,32,177,166,46,154,236,85,201,251,131,121,16,39,39,52,140,243,24,139,104,195,81,227,230,60,123,47,7,250,168,23,46,178,252,245,151,115,216,208,34,165,8,26,187,116,159,135,167,173,184,144,200,16,71,72,76,251,84,117,181,77,197,7,64,9,111,120,172,73,11,56,223,150,171,213,165,105,100,172,60,172,249,231,90,231,56,86,189,92,70,29,171,71,23,226,188,150,192,138,67,43,159,1,14,97,96,216,13,155,92,189,214,67,184,252,153,168,14,97,154,133,129,36,1,14,139,7,210,126,92,242,84,139,97,122,70,17,113,156,8,54,42,207,210,2,28,129,66,250,199,38,111,27,169,77,148,152,4,154,57,186,95,203,163,236,200,117,6,198,66,136,197,89,26,102,160,56,136,2,141,68,108,176,204,150,220,187,26,145,77,169,216,186,1,120,172,7,53,154,27,90,51,182,81,54,163,46,116,98,133,175,240,107,60,116,39,44,163,201,175,22,244,180,78,181,74,236,179,36,218,64,102,197,145,180,0,200,80,152,117,190,117,225,159,102,19,30,37,212,21,34,57,23,131,46,152,221,27,84,212,139,92,225,204,93,66,46,220,120,195,93,240,115,5,40,70,56,129,38,64,223,126,197,168,162,9,91,90,240,119,182,109,17,215,119,3,85,1,25,87,57,188,14,231,229,235,233,59,21,113,35,107,1,25,222,202,211,206,206,79,202,243,34,57,217,56,100,179,208,76,88,87,223,22,43,224,114,107,5,236,188,163,102,126,177,12,139,6,206,90,152,236,50,22,44,248,206,178,158,174,225,162,64,158,187,139,240,2,29,14,160,133,141,1,108,29,132,172,197,160,33,96,14,66,234,161,62,136,189,116,21,144,226,207,121,54,49,56,134,139,155,121,154,63,181,170,207,154,67,213,50,116,181,142,8,23,201,117,200,225,28,185,104,104,147,87,114,136,49,56,66,205,219,185,34,241,222,202,226,51,238,189,10,242,235,201,233,239,228,93,54,69,239,149,4,85,26,94,217,238,73,52,189,116,215,194,19,227,123,174,40,25,30,75,32,219,217,255,235,242,91,37,91,40,137,177,122,27,173,254,193,153,221,110,81,162,104,207,180,37,145,251,198,60,55,128,121,187,250,192,200,213,4,129,25,73,28,114,10,159,15,141,233,195,11,197,208,22,146,198,62,190,184,92,224,68,92,138,194,9,175,164,182,200,166,58,176,237,152,125,32,91,102,97,197,180,121,178,27,186,188,253,250,119,141,254,18,216,24,158,237,211,18,252,43,23,48,128,144,231,117,7,223,23,60,149,45,85,142,77,107,211,13,103,191,88,101,183,189,29,220,13,139,205,254,219,140,189,231,87,86,124,29,142,53,73,114,8,233,42,166,113,71,186,31,243,167,32,228,210,47,110,144,140,91,209,29,242,9,254,233,117,178,13,141,18,228,150,220,42,218,98,66,164,114,189,19,136,73,81,234,220,41,93,55,95,236,6,173,24,247,15,230,121,185,208,132,214,216,102,71,119,156,45,8,107,52,132,77,225,18,117,61,190,253,184,56,6,157,120,205,56,26,158,185,133,22,154,32,1,226,166,81,221,29,63,118,219,87,87,207,187,9,77,16,165,122,3,12,24,48,171,170,7,118,200,163,159,52,15,162,97,178,74,103,221,178,178,109,66,74,90,28,102,108,30,148,222,26,215,0,54,106,20,71,38,133,209,180,168,2,133,236,71,192,122,201,34,188,5,228,80,25,208,195,161,156,49,84,2,238,84,34,75,150,212,214,114,63,31,229,240,247,140,55,47,212,71,244,229,88,58,144,51,13,101,86,77,165,250,134,14,42,52,40,253,134,58,128,42,206,130,110,148,224,98,188,131,143,33,205,185,89,107,42,193,10,207,179,18,175,170,196,180,240,95,101,32,219,140,101,76,82,117,120,110,93,74,241,123,60,195,133,15,234,72,245,202,240,50,159,184,79,121,51,170,118,137,88,33,186,140,175,105,83,251,253,42,46,15,72,89,198,161,240,124,125,38,188,195,243,125,73,59,110,154,113,249,105,155,28,198,105,180,142,217,214,234,36,13,152,191,89,238,212,16,42,113,246,59,236,209,127,3,64,220,241,163,100,10,25,32,161,152,2,242,171,19,145,94,231,191,255,82,160,14,198,180,121,0,202,186,200,209,25,27,169,179,156,208,25,132,142,160,131,81,221,181,228,231,106,119,202,150,198,66,70,191,12,146,78,26,113,143,26,65,98,171,26,103,230,104,59,219,47,139,252,15,133,85,157,98,239,45,154,170,211,99,41,163,6,28,255,109,92,94,57,139,62,43,165,226,213,26,169,184,189,179,10,165,181,84,187,45,72,237,222,228,94,80,52,231,147,197,135,59,82,91,150,170,180,190,164,53,79,214,203,84,143,241,132,134,25,139,180,14,95,119,35,81,102,20,253,173,180,53,138,35,18,180,209,179,187,115,135,208,162,239,171,184,40,159,32,21,119,56,141,21,22,227,90,167,238,42,209,26,96,209,74,104,110,27,75,201,110,102,168,172,74,50,123,170,115,122,18,52,181,39,167,8,232,152,85,174,242,198,23,20,101,71,85,137,137,63,219,46,172,215,168,45,9,48,237,250,146,77,59,127,55,138,212,100,160,8,175,56,109,141,150,100,165,102,63,167,1,212,95,155,45,179,252,255,193,98,239,211,224,126,108,246,253,72,107,87,91,161,21,165,215,160,205,190,194,4,194,153,170,24,59,123,3,71,1,123,79,49,250,183,141,142,88,132,28,207,105,84,91,28,9,241,40,139,144,87,209,235,212,5,211,106,115,185,123,13,169,39,229,211,65,44,249,68,152,183,26,123,125,209,96,221,131,188,73,2,32,20,30,100,227,174,32,224,255,172,68,56,159,7,134,59,102,250,217,136,0,69,84,213,74,254,229,102,93,136,134,180,114,118,87,166,79,191,249,45,12,126,231,66,175,53,77,23,164,4,175,243,149,239,47,149,242,238,210,216,88,203,145,227,216,124,113,203,192,53,30,40,112,24,179,66,102,162,220,227,238,45,208,231,186,175,59,17,129,229,58,17,157,227,6,148,59,210,56,205,114,239,161,29,118,172,18,112,180,174,18,173,30,24,200,245,92,239,186,226,21,46,147,94,41,227,16,251,178,145,113,237,71,137,222,36,12,146,128,25,142,125,153,24,158,229,92,112,11,204,158,176,18,36,184,142,87,8,240,142,31,191,89,32,228,64,246,5,49,75,156,197,41,79,169,162,175,121,147,224,139,56,35,48,168,207,179,32,129,4,91,231,229,29,29,16,95,117,9,224,116,88,99,121,113,160,67,178,245,77,172,16,244,185,5,73,200,132,187,110,39,157,21,199,128,126,140,203,47,131,193,129,5,105,5,12,126,173,40,91,8,97,213,234,67,40,41,181,208,171,235,63,109,215,181,135,133,52,159,87,193,54,234,6,30,198,118,124,136,99,107,245,28,141,135,71,252,58,48,27,25,168,128,131,35,31,234,79,66,245,235,39,158,137,181,108,8,203,249,245,87,125,145,26,244,204,175,184,189,207,53,181,142,21,95,209,89,105,148,200,52,32,38,121,192,88,8,93,51,238,45,222,10,212,76,92,252,147,248,242,74,3,91,240,248,179,69,201,182,16,42,162,212,164,192,133,96,170,210,113,73,231,158,185,137,35,170,232,3,248,21,105,133,23,53,254,119,9,133,0,15,146,130,174,120,218,22,252,182,114,143,214,13,84,213,242,211,128,93,210,210,140,86,77,65,220,88,130,89,125,156,81,235,26,77,179,90,87,251,207,246,143,159,29,97,61,187,162,225,251,2,111,178,52,105,20,122,137,18,12,98,1,46,14,70,242,18,226,45,121,131,98,69,23,54,109,114,244,98,184,19,240,118,48,56,46,14,253,71,216,45,42,92,222,103,154,101,9,129,99,227,142,234,202,6,152,219,66,148,80,206,47,136,14,182,29,195,168,151,175,122,174,114,215,177,203,97,149,134,190,184,120,192,195,24,51,142,105,167,46,86,182,96,243,165,240,12,244,204,208,69,158,102,47,139,22,203,239,46,55,205,27,199,189,105,56,94,40,15,169,29,217,10,106,96,86,93,172,144,193,143,88,180,35,175,241,241,148,187,229,245,205,198,147,136,235,215,244,249,27,234,253,58,132,116,24,211,36,210,154,106,28,84,33,83,39,157,121,51,156,88,72,190,117,55,213,212,145,196,244,243,161,137,41,48,229,130,119,92,196,23,99,170,129,205,69,215,173,71,5,79,127,163,7,213,183,105,197,33,48,35,50,16,240,221,57,242,202,239,115,104,47,254,57,21,20,139,234,90,79,30,114,31,84,49,30,124,94,98,145,155,127,93,53,180,124,39,74,229,195,29,94,216,7,141,132,129,229,81,228,59,173,150,222,44,227,59,155,17,164,120,255,70,54,42,180,6,129,106,10,72,209,120,167,138,245,205,247,166,86,175,73,197,123,186,144,34,1,139,255,67,23,94,189,240,93,187,186,223,209,143,112,247,163,32,234,171,167,123,176,141,169,42,245,250,94,203,249,138,95,141,128,164,192,236,7,221,111,148,239,122,125,10,95,30,159,115,121,146,56,41,145,253,237,145,249,18,57,172,6,209,14,196,21,168,230,61,242,193,249,91,58,29,167,215,217,123,234,9,185,196,55,97,223,188,158,156,130,187,58,99,177,50,94,56,106,110,0,207,209,162,77,202,69,130,79,1,204,17,120,66,136,55,235,81,255,45,11,176,94,35,141,0,190,90,78,139,82,244,238,140,21,98,136,255,14,193,6,57,145,119,38,151,207,51,94,252,50,126,106,64,182,2,21,24,139,44,93,29,178,187,92,8,89,186,109,125,245,83,182,106,151,204,85,214,173,239,90,75,171,7,226,52,219,221,5,60,124,29,8,139,53,104,2,135,173,220,230,164,74,109,179,170,240,170,18,80,15,222,240,133,36,152,127,198,62,48,255,21,11,117,63,194,252,38,87,136,229,248,35,23,242,119,30,192,168,34,2,199,244,198,243,70,100,123,71,133,187,218,205,156,193,10,112,97,247,80,223,65,81,194,117,135,181,125,121,130,155,152,80,11,25,213,5,197,230,53,12,254,195,16,10,101,176,25,79,92,247,25,119,60,201,88,176,102,21,78,221,101,151,21,254,146,130,103,167,223,45,47,81,163,226,66,131,59,158,38,236,84,18,176,91,69,49,214,134,93,39,234,109,250,245,86,117,59,80,49,133,177,105,218,25,0,225,248,202,24,47,239,232,223,169,165,111,234,175,209,193,87,109,4,211,138,43,205,235,53,226,135,178,74,243,53,155,250,61,54,28,127,156,3,159,222,163,21,183,183,248,134,236,184,184,220,103,225,247,37,45,118,175,193,108,53,175,15,210,200,109,46,21,154,81,135,209,92,251,178,221,253,91,217,187,88,214,94,91,249,181,76,229,221,205,211,44,72,138,218,98,172,208,108,235,183,149,29,69,210,254,133,206,60,195,20,74,81,132,216,13,175,98,122,77,251,65,222,174,152,229,99,146,47,204,156,222,49,189,10,174,105,59,207,95,53,138,53,19,253,93,71,162,223,253,186,219,33,50,5,145,2,211,128,239,242,151,4,111,151,245,85,32,172,215,225,62,223,24,26,229,134,223,64,148,162,64,138,225,183,98,19,121,93,164,3,205,101,165,17,233,12,157,21,21,99,126,175,252,128,39,79,170,8,114,29,96,37,228,119,113,142,191,238,68,102,44,155,127,86,222,115,170,255,110,72,227,57,151,103,164,161,161,37,92,238,12,56,37,31,95,46,122,43,189,105,249,5,68,75,144,13,11,74,223,160,171,197,114,146,3,67,119,99,17,68,172,69,120,163,199,131,69,88,29,204,61,117,88,156,47,7,125,67,13,22,188,204,216,38,133,47,117,80,187,54,35,149,115,75,187,86,198,61,45,21,28,225,71,90,241,165,77,87,209,186,191,230,236,172,109,27,45,213,246,57,186,110,78,180,107,161,109,97,49,10,162,86,115,199,63,206,74,175,163,177,235,194,194,8,246,117,138,173,81,249,62,17,170,78,208,234,96,30,66,196,175,33,129,90,64,244,53,199,31,126,228,63,74,2,44,110,255,22,20,70,104,252,183,33,187,127,20,167,101,183,4,120,101,246,212,102,75,140,94,237,39,197,212,8,95,123,66,228,190,184,153,226,111,249,129,191,13,203,230,116,223,144,157,178,72,78,92,232,10,163,165,72,92,87,23,197,0,22,1,231,129,188,235,172,95,46,150,2,164,255,90,22,198,175,26,216,22,128,167,79,49,125,210,118,7,66,53,219,186,172,147,187,18,44,70,205,65,62,134,255,253,23,188,248,197,124,74,85,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("694791be-7ea5-453a-ac4e-518c732e3007"));
		}

		#endregion

	}

	#endregion

}


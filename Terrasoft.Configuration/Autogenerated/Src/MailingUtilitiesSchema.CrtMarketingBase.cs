﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingUtilitiesSchema

	/// <exclude/>
	public class MailingUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingUtilitiesSchema(MailingUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e8c12000-4abb-45f4-8345-4170f554711b");
			Name = "MailingUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("27091b53-7f92-431b-845e-5f00397c8b24");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,27,107,115,219,198,241,51,51,147,255,112,70,218,24,148,41,80,246,196,73,42,75,84,244,180,213,145,44,71,143,120,38,146,236,130,224,81,68,13,2,52,14,144,76,203,234,111,239,238,189,112,7,2,36,100,55,110,58,211,100,44,2,119,123,187,123,251,190,7,98,127,76,217,196,15,40,57,165,105,234,179,100,152,121,219,73,60,12,175,242,212,207,194,36,254,246,155,219,111,191,105,229,44,140,175,44,144,241,56,137,159,213,246,120,127,103,117,221,6,238,106,128,148,214,181,123,59,91,181,93,187,113,22,102,33,101,181,0,39,193,136,14,242,136,166,85,16,47,243,208,59,161,233,117,24,208,195,100,64,35,111,247,67,70,99,6,60,26,8,79,166,44,163,227,242,187,183,227,103,254,76,227,118,18,69,52,192,73,50,239,57,141,105,26,6,179,3,83,255,6,94,235,218,189,253,177,127,85,213,191,127,84,209,132,130,159,164,148,49,75,174,178,251,32,140,223,207,52,158,210,15,89,101,163,119,76,175,242,200,79,119,63,40,132,51,66,0,97,5,121,26,102,83,111,59,157,78,178,228,42,245,39,163,105,1,245,107,238,167,217,199,226,253,42,74,250,126,180,186,42,173,227,32,185,146,51,3,136,239,82,122,5,52,200,118,228,51,182,74,14,253,48,130,190,179,12,126,80,161,28,166,219,237,146,53,150,143,199,126,58,237,201,119,1,49,37,99,154,141,146,1,35,195,36,37,217,136,146,177,64,64,152,208,167,167,134,119,141,241,147,188,31,133,1,97,25,216,97,64,2,164,92,65,184,117,203,137,107,14,247,66,26,13,128,197,87,105,120,237,103,84,116,78,196,11,9,64,76,25,9,227,140,236,80,22,164,225,4,149,127,58,157,208,147,44,5,180,7,52,190,202,70,100,157,60,121,186,242,172,110,228,73,222,255,39,88,205,182,95,55,248,233,74,121,176,156,66,74,253,65,18,71,83,178,15,178,37,111,35,248,179,78,224,241,208,143,253,43,154,130,13,102,40,116,154,186,142,156,167,211,110,132,233,134,246,95,36,201,187,131,57,8,95,11,16,182,16,227,225,206,83,242,118,60,120,10,152,224,17,76,135,2,148,187,104,20,88,35,253,64,118,81,173,226,113,157,196,244,70,52,187,191,56,231,155,203,191,251,203,31,87,150,255,246,224,187,191,252,245,251,135,75,143,186,235,27,111,222,254,227,246,211,221,191,150,47,31,185,27,14,121,132,232,91,191,56,171,23,222,2,232,246,210,47,238,198,106,1,116,105,189,45,95,46,25,93,237,141,11,175,253,200,104,80,132,156,185,131,22,74,73,76,242,69,54,142,94,128,1,164,160,171,119,236,149,159,130,57,87,77,127,205,191,232,159,191,233,93,46,109,92,244,71,41,29,94,176,165,117,248,87,76,26,152,113,224,207,218,217,241,65,15,158,47,46,28,231,211,249,27,199,185,108,47,181,225,241,161,217,245,16,122,30,98,199,195,54,199,217,115,207,223,172,93,46,65,159,187,241,96,173,235,183,215,248,59,0,192,75,175,233,76,128,171,223,252,40,167,149,236,123,75,200,245,58,103,17,159,122,222,210,6,240,229,186,222,167,139,24,8,245,244,211,218,69,215,91,154,37,42,188,135,113,63,225,180,64,86,144,212,50,154,190,132,31,32,231,32,90,135,143,234,118,231,152,187,112,53,17,207,200,91,102,190,9,158,79,194,241,36,162,162,73,91,237,119,52,30,136,240,96,199,138,87,105,2,202,195,56,2,241,130,71,27,209,95,142,100,188,65,120,146,167,251,205,80,85,138,85,220,43,241,223,45,215,239,21,205,228,83,43,165,89,158,198,220,247,159,241,150,59,252,123,55,135,172,116,220,123,147,127,93,196,132,90,46,138,184,81,197,12,169,224,135,183,237,198,1,202,23,37,56,166,193,200,143,67,54,246,204,49,221,210,160,18,123,150,18,173,151,91,57,160,96,22,95,52,191,166,190,159,169,222,59,249,112,55,95,215,135,34,3,213,36,6,201,154,180,80,136,155,199,116,28,198,3,120,121,225,179,145,187,19,242,50,1,166,180,38,64,58,36,225,89,160,71,6,186,171,45,197,123,237,167,136,72,25,36,135,223,202,195,104,0,113,184,45,4,13,105,144,250,193,136,184,2,11,185,70,215,131,236,98,96,243,184,59,50,133,180,5,24,189,205,201,4,102,231,114,232,182,161,50,37,160,189,48,162,58,53,98,244,135,8,206,249,7,141,37,56,25,239,44,14,225,137,98,223,214,52,163,204,69,180,167,137,96,210,109,183,5,214,187,121,194,57,77,243,56,128,102,57,70,182,178,36,79,3,218,225,25,50,226,153,80,113,46,121,115,5,132,39,211,100,79,65,137,217,109,72,4,32,52,9,7,105,86,160,118,87,58,54,236,170,4,121,182,200,117,182,71,52,120,199,200,205,8,84,79,83,66,49,59,97,40,202,252,48,102,36,78,98,152,32,188,244,35,8,80,35,40,16,131,17,4,36,86,227,98,188,101,130,97,139,196,16,179,214,29,142,206,233,241,156,71,252,193,0,203,48,111,173,203,65,138,17,98,246,172,7,82,3,5,15,23,49,145,42,38,214,186,106,100,133,38,250,73,18,137,217,113,234,219,18,219,203,36,126,165,144,109,23,184,148,138,56,233,146,86,120,136,247,246,217,161,159,5,35,151,67,116,8,228,235,55,23,249,202,202,147,199,203,248,243,211,222,165,51,207,46,74,220,236,51,176,220,112,48,143,106,81,39,216,164,45,42,139,29,121,81,196,62,22,18,36,225,128,194,194,99,24,130,13,36,67,94,126,250,224,101,215,148,76,210,228,26,58,235,162,234,140,202,115,200,239,32,236,88,44,26,156,222,62,100,53,63,6,171,149,104,215,24,5,45,242,84,89,90,216,156,217,35,187,189,122,75,1,23,125,143,182,162,153,46,219,130,21,76,159,231,225,0,227,213,38,159,209,43,57,161,253,129,107,83,36,54,235,101,223,68,44,237,18,203,214,42,208,131,37,197,9,205,50,208,40,15,44,60,56,185,54,210,14,81,101,171,98,195,54,155,106,31,229,245,37,227,252,65,158,151,65,183,177,19,150,53,130,179,70,239,82,211,14,165,134,102,197,109,185,50,174,75,167,78,239,72,68,99,24,119,51,10,33,60,107,126,72,200,80,175,192,233,96,62,166,65,177,172,112,122,58,135,144,12,87,108,115,7,50,88,249,142,125,185,168,112,122,219,57,203,146,177,193,192,8,74,32,110,10,5,14,219,16,174,19,48,4,33,77,77,215,21,1,115,174,41,116,8,95,149,79,137,16,66,71,133,121,99,38,186,205,98,18,171,54,71,25,82,49,85,205,178,68,171,74,73,197,82,201,16,69,22,83,248,197,210,10,198,8,102,60,8,103,168,251,157,144,77,34,127,10,235,245,124,28,115,211,19,195,96,85,79,79,67,40,32,17,169,126,89,47,205,208,219,206,211,20,16,162,24,208,118,229,171,130,87,57,153,123,146,28,9,185,32,219,31,204,199,164,193,158,233,172,15,134,55,8,165,108,112,214,115,202,6,153,213,229,79,203,217,204,33,170,165,78,199,230,64,244,222,117,136,134,147,93,139,1,79,120,142,4,56,45,250,109,44,194,153,167,223,5,132,32,92,137,193,90,232,2,38,169,158,10,200,41,19,218,62,225,6,2,160,82,127,226,221,59,43,208,139,162,197,210,250,8,42,20,16,216,76,209,165,165,41,21,4,217,211,125,32,198,64,218,120,153,71,209,81,186,59,158,100,83,215,176,213,118,81,48,105,99,146,99,246,146,116,236,103,174,115,187,114,71,46,156,219,199,119,23,14,185,125,114,231,116,228,52,90,149,184,45,155,111,147,141,210,212,100,135,168,214,200,170,237,34,26,243,34,115,214,128,230,76,204,2,143,207,189,228,90,222,30,133,204,185,151,38,227,157,45,119,145,185,193,255,14,74,21,116,195,229,125,71,64,129,67,63,98,180,144,88,25,63,4,252,29,58,52,216,100,174,197,148,193,44,72,185,92,23,10,241,119,230,237,180,40,239,215,154,170,195,49,127,207,69,162,169,96,223,224,221,117,14,161,4,134,124,58,56,138,165,247,168,8,208,112,188,242,148,178,239,53,28,174,225,63,115,188,112,87,62,188,161,75,55,68,44,70,163,32,62,79,46,134,130,1,193,172,5,47,156,88,77,156,105,56,220,176,234,166,4,237,112,197,69,58,19,176,238,199,188,137,67,122,185,1,86,135,203,191,86,217,231,79,95,34,125,126,97,51,35,236,30,72,23,43,102,33,46,25,49,239,81,116,53,168,123,22,84,60,85,37,14,79,255,51,204,170,216,248,103,170,52,190,176,214,106,30,229,103,170,178,82,120,182,228,215,40,68,207,205,24,22,186,197,89,227,255,225,250,127,50,92,87,5,223,89,183,187,127,240,69,167,242,120,201,246,101,209,86,109,26,4,250,112,80,173,238,135,9,110,225,145,97,24,221,103,155,232,15,221,51,48,9,165,52,72,210,1,143,175,229,29,4,123,6,243,209,8,24,161,136,179,6,216,100,252,94,144,4,184,161,55,65,42,183,1,165,144,107,145,171,13,17,67,122,251,166,9,253,154,211,116,186,199,145,236,103,116,12,194,35,123,18,101,161,216,210,198,202,249,81,159,37,17,205,192,176,126,242,126,246,86,200,39,2,42,168,59,23,151,135,232,214,118,235,30,151,200,46,123,47,104,57,237,203,217,124,53,143,77,162,113,72,102,155,45,224,121,62,81,234,151,175,37,53,170,252,102,235,161,180,13,180,120,70,138,161,50,7,5,241,25,186,37,146,29,146,165,170,32,154,91,244,200,147,114,168,123,164,73,200,108,116,19,102,35,114,245,49,156,16,63,186,74,82,120,27,55,117,69,192,224,244,78,76,108,245,134,165,233,15,200,192,207,252,185,123,112,253,105,70,207,47,53,203,122,75,60,75,149,128,37,4,98,146,73,154,183,224,230,187,220,15,95,34,44,252,72,147,161,139,155,192,237,75,17,194,228,57,254,86,62,28,130,219,110,69,73,240,110,59,153,76,229,166,61,110,241,110,130,109,78,221,118,135,172,116,56,118,253,224,89,185,82,28,240,187,135,116,156,164,83,200,165,20,100,146,228,217,36,207,36,59,102,143,91,172,8,229,184,231,191,135,19,57,138,75,94,140,41,90,93,129,171,67,140,251,13,120,69,67,223,119,144,90,215,120,91,136,198,123,13,218,163,238,28,182,37,220,118,148,48,93,60,105,107,21,52,65,14,82,6,178,251,174,88,160,206,179,175,29,176,88,109,97,156,114,67,35,66,88,199,52,143,194,32,49,126,161,94,137,143,28,213,219,150,65,187,185,117,21,131,92,195,154,148,68,171,20,28,198,11,245,203,65,26,232,65,192,189,74,152,218,221,90,121,166,182,12,184,46,12,230,56,168,185,77,208,88,11,76,176,253,69,202,224,122,16,136,254,56,249,159,20,140,150,228,191,208,81,132,144,203,110,82,224,46,59,202,231,58,174,138,56,125,8,29,102,196,249,241,135,75,229,70,120,82,135,7,235,208,189,252,184,240,45,222,192,221,238,24,158,93,68,192,173,2,31,202,222,9,11,182,136,18,151,15,234,145,149,130,122,75,58,167,176,44,141,3,1,245,224,123,210,186,251,170,17,193,176,69,226,199,3,92,47,95,211,52,99,36,204,72,150,168,236,241,245,172,84,167,171,122,59,149,89,167,24,166,143,117,43,236,85,153,7,158,1,131,14,12,227,230,80,170,130,230,98,229,7,197,26,25,31,210,36,127,75,129,21,1,241,254,130,227,180,156,222,86,131,152,42,233,221,75,84,179,19,83,34,81,98,194,100,12,109,248,195,164,27,241,38,14,164,82,119,247,62,169,155,143,228,70,206,145,10,115,55,176,217,162,71,130,242,20,156,131,47,150,251,238,7,26,228,168,212,77,81,43,226,133,59,126,213,128,70,116,12,197,54,94,50,48,42,224,106,69,84,236,176,108,229,145,56,222,93,59,237,185,217,40,100,88,200,230,99,154,226,97,51,180,25,72,59,146,54,182,250,214,113,163,190,246,128,135,37,33,22,188,22,55,58,126,136,81,222,126,124,157,188,163,46,2,54,77,40,103,147,40,241,7,140,167,226,112,236,95,129,221,100,98,93,49,161,1,223,253,37,103,199,7,51,46,13,177,48,33,62,217,242,25,253,241,135,123,26,105,158,70,176,170,227,180,0,245,252,117,80,159,19,216,225,241,64,12,241,193,67,44,170,115,199,143,97,153,143,219,33,78,239,112,255,112,151,100,240,168,22,78,124,182,139,246,201,14,64,56,156,238,38,19,115,85,181,42,76,162,131,241,83,185,70,193,168,213,172,232,235,48,162,193,208,59,242,40,18,106,82,96,86,99,150,78,149,126,81,253,41,133,5,32,195,52,230,74,95,121,73,51,239,69,150,77,94,211,254,177,232,108,27,61,69,171,186,147,8,60,171,16,47,16,178,73,18,51,90,135,81,244,182,37,93,143,31,55,137,54,157,41,100,182,149,241,18,22,53,52,188,166,242,109,93,19,48,135,206,38,94,43,85,51,53,118,54,85,171,220,165,104,206,94,43,86,22,188,94,117,231,152,122,120,240,35,145,89,156,26,188,180,132,81,240,157,15,193,74,71,218,201,177,127,35,142,195,138,116,108,233,82,134,83,200,165,194,78,138,203,62,152,179,116,134,229,225,11,74,190,172,45,123,74,73,187,197,89,221,134,26,39,216,143,135,9,193,187,71,1,160,183,155,81,160,188,5,211,208,0,87,153,109,53,190,229,237,133,41,203,142,210,29,58,244,243,40,115,97,52,196,26,121,150,183,191,67,214,215,203,51,242,248,101,6,205,129,97,139,130,250,3,97,148,100,67,188,123,135,10,96,213,48,214,162,222,144,19,43,85,28,178,21,79,242,204,118,89,106,144,0,239,180,144,91,178,48,94,241,107,231,124,119,255,228,197,230,99,113,52,199,47,104,53,12,62,56,0,119,38,33,178,235,165,45,47,90,100,84,192,254,250,164,249,66,145,3,251,67,242,184,148,65,111,31,208,40,228,183,51,89,187,73,30,85,147,224,167,182,156,20,147,93,144,59,13,14,149,97,90,87,226,8,235,55,186,41,39,105,169,172,81,129,182,197,250,234,134,92,57,101,168,122,7,71,109,201,154,135,31,153,226,180,197,125,66,249,101,129,186,186,2,46,205,87,175,185,156,22,7,54,174,223,159,157,238,253,172,110,213,41,115,53,110,213,245,103,47,213,181,196,68,181,137,169,234,42,204,84,237,98,220,196,211,140,182,161,52,158,68,126,64,93,103,217,81,39,23,230,62,231,60,235,226,23,177,184,117,105,195,226,169,47,204,24,191,130,6,194,187,143,161,57,13,13,102,78,2,251,50,123,149,243,193,186,6,130,49,132,131,249,11,55,188,151,166,68,192,149,104,92,56,232,144,6,134,42,85,100,217,183,5,6,209,7,223,23,42,2,12,131,17,31,130,206,72,223,22,39,67,136,223,82,56,41,29,42,249,100,227,72,222,220,232,246,26,235,166,24,164,100,138,77,13,14,231,38,120,101,253,52,57,72,110,104,186,13,129,222,129,85,7,104,113,28,198,96,51,225,144,240,126,130,252,98,241,30,33,24,196,54,86,113,86,168,212,176,151,228,96,96,197,52,231,106,168,226,194,130,248,237,17,126,153,222,190,95,175,213,167,167,219,17,58,46,207,2,220,140,175,162,213,217,93,61,21,161,137,218,203,58,18,108,38,22,241,43,139,100,204,255,66,44,170,253,12,192,227,128,16,15,10,150,141,189,151,33,113,57,10,239,36,15,2,88,122,21,121,91,78,20,209,157,165,17,240,39,224,158,167,73,62,97,231,79,46,61,227,14,148,64,84,22,129,81,3,20,88,228,147,39,225,220,153,181,117,1,106,23,94,242,43,30,15,39,42,114,180,43,65,219,222,105,26,26,213,12,242,162,200,156,100,62,148,215,175,33,68,184,96,162,217,100,181,219,117,218,228,211,39,82,7,192,56,132,193,186,33,7,125,233,76,87,6,66,194,42,58,90,18,122,44,37,132,87,89,215,196,71,18,165,216,217,17,55,95,143,38,226,235,175,253,171,24,116,203,5,247,204,148,91,113,213,173,145,64,212,45,161,146,80,56,42,118,46,167,125,41,53,33,129,75,58,48,54,43,84,248,225,163,27,159,91,97,148,241,227,96,132,235,62,177,228,251,239,133,26,125,249,25,175,220,90,60,213,159,194,216,17,226,32,100,217,218,76,76,216,228,184,118,5,170,217,176,96,94,196,23,121,66,186,184,137,237,171,59,181,188,194,197,211,214,102,60,117,223,98,37,251,214,219,125,159,251,17,147,131,164,213,202,111,34,160,252,240,211,144,129,136,142,82,168,51,252,200,48,83,211,77,20,210,193,192,68,83,246,238,10,203,18,3,27,155,150,248,74,65,101,106,180,164,137,250,140,7,91,171,12,76,234,232,43,217,217,111,245,12,54,169,99,139,156,163,190,134,50,109,203,154,138,146,190,236,215,86,102,198,152,5,246,101,125,113,101,25,149,77,169,137,109,105,250,86,24,156,249,208,202,78,28,11,13,162,213,106,102,18,172,90,228,172,206,40,190,166,53,212,241,54,215,30,204,173,173,217,130,68,41,174,162,32,185,87,228,65,32,223,140,100,88,137,212,196,56,131,68,245,186,200,66,132,246,101,99,54,238,120,234,88,81,97,238,214,160,182,181,130,186,95,200,40,214,181,249,204,73,63,207,70,197,130,36,103,49,78,0,191,59,149,39,186,205,15,116,149,77,8,25,224,94,103,129,55,240,163,32,143,124,153,98,254,163,31,91,200,207,170,240,213,254,254,169,180,189,46,111,54,227,231,180,214,98,82,127,142,37,119,53,140,133,163,244,121,227,162,24,34,57,227,87,196,248,89,18,210,52,238,58,74,18,51,203,74,57,106,241,62,125,213,55,82,33,119,236,112,240,199,124,10,181,102,127,11,165,137,53,93,202,113,50,243,62,47,122,208,252,211,40,57,252,251,239,43,62,96,90,248,73,146,104,181,27,121,27,252,247,111,226,79,235,100,180,65,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e8c12000-4abb-45f4-8345-4170f554711b"));
		}

		#endregion

	}

	#endregion

}


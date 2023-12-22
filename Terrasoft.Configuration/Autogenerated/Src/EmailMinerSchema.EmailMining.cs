﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailMinerSchema

	/// <exclude/>
	public class EmailMinerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailMinerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailMinerSchema(EmailMinerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a6fb7ccb-c76c-4cf5-bc34-c2fac7c3b5ca");
			Name = "EmailMiner";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e20436f2-80ed-4182-a2cd-94f2d77ff547");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,28,219,114,219,54,246,89,157,233,63,32,218,153,150,154,209,50,205,107,98,185,227,107,162,108,46,222,40,109,31,118,58,30,154,130,109,182,20,169,16,164,19,109,234,127,223,115,112,35,174,148,148,56,157,205,67,44,129,56,87,156,43,0,170,202,86,148,173,179,156,146,247,180,105,50,86,95,183,233,73,93,93,23,55,93,147,181,69,93,165,103,171,172,40,95,23,85,81,221,124,255,221,231,239,191,27,117,12,62,146,197,134,181,116,245,204,249,14,176,101,73,115,4,100,233,115,90,209,166,200,189,57,167,89,155,121,131,175,138,234,131,55,248,174,171,218,98,69,211,5,224,201,202,226,191,156,163,126,214,77,89,95,101,229,211,167,39,245,106,5,156,190,170,111,110,96,184,127,222,139,116,86,1,35,183,43,90,181,233,188,106,105,115,13,18,179,126,226,27,250,177,5,142,113,230,75,102,82,48,149,130,52,194,79,26,26,27,79,79,143,163,143,206,64,182,182,48,217,112,38,156,103,121,91,55,145,25,175,235,170,192,167,92,94,120,254,143,134,222,128,114,200,73,153,49,246,148,168,85,163,13,127,250,248,241,99,114,192,186,213,42,107,54,135,242,251,49,162,164,140,145,178,190,41,114,114,93,55,132,34,20,89,103,13,18,75,21,220,99,3,112,221,93,149,48,57,71,42,22,145,209,103,78,104,180,110,138,187,172,165,114,198,124,9,42,47,174,139,156,175,220,188,186,174,113,14,90,209,72,161,186,170,235,146,204,153,154,73,151,228,51,185,161,237,51,194,240,191,251,192,212,163,188,237,178,210,159,118,47,56,112,101,229,3,239,111,41,105,40,235,202,150,212,215,164,133,111,66,214,21,55,236,84,195,153,178,142,254,131,150,10,222,208,54,176,18,191,115,233,76,241,133,83,188,227,88,123,177,60,242,154,190,160,8,168,138,187,162,221,144,66,73,220,164,61,160,69,95,48,240,154,174,174,104,147,188,1,79,37,51,50,86,240,243,229,120,242,187,169,157,231,93,177,36,71,250,105,64,141,97,214,20,8,161,220,73,8,107,179,182,99,48,145,194,42,54,244,122,54,22,222,179,224,227,227,199,135,123,177,75,77,88,155,97,214,162,249,18,19,251,206,76,115,125,10,126,133,90,151,64,26,86,56,175,155,37,251,82,213,2,194,252,150,27,53,62,12,43,248,204,153,243,149,28,75,101,251,218,214,36,190,88,237,62,142,152,250,189,153,81,223,210,81,6,162,101,11,97,230,66,120,187,227,250,248,80,161,183,35,128,112,221,11,8,231,245,18,98,252,130,182,45,76,98,138,107,35,215,196,225,198,207,162,196,12,248,247,144,55,94,83,24,206,181,74,240,225,165,112,248,203,18,96,171,124,115,201,192,98,170,37,27,63,147,242,209,106,41,68,180,229,61,47,104,185,140,201,139,107,8,250,108,104,182,172,171,114,67,230,144,136,200,37,68,85,160,10,31,95,103,85,118,3,150,248,156,182,152,161,96,145,76,57,199,19,75,28,141,228,23,70,27,208,114,37,146,41,185,236,172,239,97,152,185,129,23,82,230,93,145,211,139,166,254,180,33,151,84,71,106,57,30,65,128,193,14,2,204,130,102,96,20,180,33,151,185,61,16,1,59,165,203,110,93,226,90,65,18,185,92,26,223,194,0,96,105,20,23,136,92,102,124,97,129,51,28,10,79,230,121,114,179,0,242,171,12,36,65,115,125,79,63,181,230,112,12,144,59,146,152,199,5,120,65,203,53,74,69,35,79,34,226,9,59,122,71,215,117,211,34,248,202,254,62,19,73,87,164,235,13,174,243,129,3,114,152,76,182,24,24,119,168,166,67,12,104,102,220,67,7,210,217,28,146,63,175,136,40,35,21,253,72,10,128,206,42,168,226,32,185,153,161,68,47,59,196,143,112,142,227,35,144,241,179,21,169,192,81,102,99,219,208,198,135,104,136,232,101,202,18,177,78,224,161,171,6,133,113,231,100,36,97,92,137,68,90,11,155,66,150,203,107,40,222,216,36,61,120,204,177,31,26,233,179,103,43,113,204,220,38,62,33,34,165,58,198,15,10,15,120,195,232,46,107,156,113,67,169,71,205,77,135,229,31,192,162,190,2,79,18,87,242,169,203,141,32,227,251,82,208,0,34,174,120,152,108,101,81,209,113,92,47,72,197,241,215,61,176,155,78,26,68,109,250,244,238,120,11,80,177,240,233,211,108,195,68,192,70,244,88,207,218,125,133,17,254,145,224,175,89,217,81,135,204,148,163,28,237,156,66,166,228,137,18,207,138,43,192,128,99,66,233,73,215,52,128,21,205,15,169,203,175,42,46,37,147,244,104,185,68,9,146,127,186,210,104,51,8,5,162,0,37,243,177,145,10,230,210,99,143,55,200,121,50,62,179,209,141,13,50,225,32,38,12,57,22,227,146,203,144,241,222,15,7,33,8,90,183,117,52,205,189,42,88,123,96,214,188,135,48,175,134,62,138,169,78,38,57,45,56,49,136,45,7,130,165,41,1,81,185,43,168,57,0,186,6,235,161,135,88,122,211,37,182,4,202,205,209,129,69,141,206,164,116,62,201,68,234,5,162,16,205,32,226,36,255,162,27,110,58,23,89,209,236,64,116,13,211,160,62,172,124,234,35,1,220,215,231,51,49,57,5,10,130,230,40,134,22,185,22,31,20,12,103,73,66,181,205,70,145,24,21,215,36,81,147,211,57,56,92,81,118,13,213,44,140,70,96,206,71,185,168,224,153,88,91,186,76,20,75,41,172,11,6,110,104,178,187,85,197,105,76,121,85,10,77,250,26,229,54,75,233,244,172,105,234,70,170,11,254,97,56,41,42,205,213,232,94,254,213,54,7,2,137,202,84,127,155,105,193,82,115,150,194,32,139,46,42,135,95,100,236,22,64,44,20,104,233,56,158,104,62,164,150,169,148,237,29,175,216,1,236,188,168,150,74,96,44,68,19,19,173,134,230,29,96,193,160,95,55,231,34,85,7,31,216,79,87,150,10,140,87,238,110,117,223,115,20,168,183,101,97,254,204,88,55,143,172,177,108,158,56,39,96,158,45,117,0,18,75,55,253,210,184,156,121,242,4,22,94,3,203,14,98,70,130,114,164,152,168,180,168,35,193,150,226,201,92,212,196,101,98,74,194,220,222,19,90,130,165,127,126,88,230,29,16,48,155,247,155,53,93,26,48,7,194,220,14,147,177,234,102,92,75,230,171,188,86,196,120,98,236,3,42,50,166,168,162,173,93,88,243,236,149,153,122,182,50,245,141,110,226,184,1,131,160,202,195,178,246,214,97,33,248,244,113,24,11,167,12,168,196,183,244,236,19,223,129,224,163,144,151,192,41,89,239,80,70,204,69,5,136,128,112,216,183,192,75,41,34,106,249,151,53,84,110,84,14,248,123,51,190,13,232,69,182,213,99,112,57,164,25,65,238,72,148,130,187,144,35,14,157,56,106,116,72,131,11,136,165,111,234,246,13,184,252,219,134,199,194,100,98,120,231,209,122,13,83,23,253,244,0,101,75,36,35,68,27,80,167,53,252,95,157,55,148,106,189,140,226,230,22,245,31,249,215,170,192,210,190,218,82,203,195,3,134,191,138,49,180,50,113,98,221,146,96,234,52,179,166,161,137,126,123,200,48,212,64,90,81,0,222,118,199,204,247,13,99,110,191,145,51,179,147,209,105,93,197,144,106,0,17,12,148,154,180,100,251,167,196,173,241,39,200,50,231,81,83,229,45,24,187,149,249,94,237,30,139,182,142,105,242,106,250,61,129,149,195,114,228,236,83,78,215,188,73,161,159,122,11,196,205,0,145,143,207,235,102,149,65,175,113,146,85,85,221,18,150,221,81,205,174,104,171,250,125,216,2,181,253,249,167,251,148,112,208,167,228,243,147,251,177,102,125,88,3,159,52,103,252,143,248,191,161,109,215,84,170,198,50,43,66,85,227,221,213,64,116,88,116,167,76,50,139,55,88,192,166,149,5,247,96,20,84,117,54,196,65,145,145,150,111,43,21,10,17,81,85,127,252,130,154,189,135,23,155,60,167,178,213,88,208,28,235,201,250,99,186,232,174,120,36,77,52,167,147,244,125,221,102,229,66,108,3,201,154,219,238,239,211,231,89,119,67,147,232,222,210,212,39,55,137,234,54,104,204,60,113,245,251,186,34,132,7,114,144,229,96,194,91,76,245,119,60,220,130,168,137,8,188,19,140,3,226,163,219,14,76,201,88,133,130,241,36,5,166,18,123,147,87,90,153,88,179,244,2,27,120,10,170,72,4,81,208,217,130,167,43,136,178,19,49,51,253,13,218,79,104,99,112,211,20,162,230,217,7,232,153,18,15,188,151,113,162,250,69,136,227,94,5,241,104,102,84,181,218,139,132,120,154,89,123,167,118,74,60,98,46,90,69,82,248,130,196,118,246,137,230,93,171,140,39,180,98,219,146,88,100,173,172,178,186,53,190,72,213,134,43,89,37,44,22,189,32,232,193,219,230,38,171,228,185,151,112,188,67,82,27,99,24,54,77,228,169,9,192,156,86,201,71,102,225,146,67,208,27,89,20,180,254,37,199,142,38,40,6,169,235,12,74,66,25,112,112,69,31,13,212,202,178,208,49,105,200,206,193,103,198,111,31,194,244,79,110,105,254,167,216,24,8,46,84,226,82,243,43,60,59,94,202,130,223,163,213,139,225,180,83,18,108,126,86,117,43,218,100,87,37,61,16,117,88,166,80,168,94,34,200,32,70,72,93,178,25,67,179,248,94,165,228,35,149,136,54,18,111,226,107,113,106,219,31,169,187,214,96,107,98,174,91,63,140,21,85,184,156,146,6,175,138,106,108,182,205,186,39,80,91,121,214,48,13,172,181,85,218,41,244,24,74,188,114,46,214,201,70,85,133,69,209,57,200,181,148,58,98,26,255,212,80,196,52,176,0,129,44,234,196,136,72,249,189,173,210,142,68,13,65,45,30,59,136,223,38,76,201,110,161,68,242,162,162,72,222,119,5,86,0,81,117,166,16,124,159,230,2,179,77,120,190,183,105,99,241,162,88,233,227,143,226,205,13,61,142,58,191,52,244,72,244,50,234,88,212,67,1,39,68,213,8,56,193,53,78,12,26,59,198,26,143,204,254,177,38,87,40,84,172,9,242,22,143,53,42,148,168,166,216,82,141,27,69,76,19,148,124,98,96,233,121,176,2,75,63,28,15,44,56,209,152,119,194,195,217,4,247,114,158,24,222,239,219,30,239,121,236,101,68,95,50,80,157,23,13,3,84,225,29,131,175,13,101,22,229,191,35,138,41,185,141,40,214,203,186,99,20,83,189,128,175,205,80,33,196,245,228,42,39,18,194,194,209,104,42,27,82,189,253,215,26,189,195,22,191,149,172,250,139,99,123,108,212,207,44,129,169,50,144,157,229,52,183,57,55,194,161,131,162,91,157,16,197,91,80,88,138,47,248,39,94,138,139,143,222,206,188,74,228,162,128,21,37,180,44,170,207,155,122,21,56,26,176,75,110,100,105,168,232,238,25,159,104,90,71,213,50,80,68,15,34,9,23,211,226,90,82,114,122,44,10,105,60,27,188,210,31,67,135,33,172,107,232,233,113,63,100,248,132,196,53,71,10,239,104,134,187,105,203,254,227,76,42,85,149,236,98,56,233,201,57,145,228,81,15,155,226,31,203,249,120,67,254,91,214,84,170,31,71,245,202,37,38,216,152,95,163,163,145,171,13,185,197,44,241,35,116,225,63,146,172,242,23,221,238,201,71,166,145,196,162,126,111,208,186,199,217,22,151,12,81,176,241,53,58,105,145,95,185,205,152,145,103,47,217,121,80,33,43,72,206,164,189,205,42,242,132,71,122,189,175,255,141,180,160,100,181,252,82,239,202,199,11,174,120,78,115,211,215,64,149,177,189,63,11,21,90,152,223,134,178,174,25,207,156,124,196,184,146,231,213,171,140,137,125,92,189,32,61,56,250,139,115,232,155,138,15,199,27,14,195,18,125,40,38,247,145,201,103,107,199,248,126,239,156,43,181,31,85,106,106,236,127,6,178,136,197,11,223,181,50,78,34,252,12,166,14,208,88,98,215,18,110,242,150,98,236,165,26,65,221,216,86,216,69,254,173,226,27,130,223,239,193,19,63,211,181,165,226,254,250,208,236,33,157,253,185,227,229,16,164,0,52,198,0,167,207,139,59,90,137,157,45,251,193,2,152,129,225,135,22,130,179,163,120,121,22,179,174,245,109,93,209,109,214,117,193,39,61,164,117,73,140,130,250,67,75,206,145,7,138,20,125,118,233,196,62,191,145,36,60,31,196,186,76,191,225,217,82,187,244,165,86,0,219,96,79,51,37,162,158,48,43,212,113,112,87,45,44,68,124,131,77,10,33,27,245,175,21,194,66,51,40,132,228,104,31,33,226,220,111,173,30,237,180,195,203,15,97,176,239,49,213,160,103,40,241,2,164,11,127,72,244,227,129,185,210,54,173,27,215,178,141,22,134,216,111,163,123,85,44,217,163,140,165,215,249,24,244,105,236,239,71,102,248,126,97,215,191,65,93,164,71,76,32,208,88,231,192,73,243,178,46,170,64,193,44,102,183,128,56,125,91,137,79,156,176,81,241,42,110,28,88,163,24,151,229,182,4,254,226,170,91,194,63,68,241,45,11,226,197,154,230,80,246,188,169,95,213,249,159,47,10,220,223,250,191,174,206,63,222,22,37,29,174,81,245,5,209,92,153,207,96,21,60,116,158,212,59,85,112,207,35,142,84,31,213,135,12,84,227,150,237,238,235,172,130,165,43,55,150,83,133,8,206,72,32,15,8,104,141,211,119,231,212,113,215,182,49,46,81,4,167,203,151,36,102,134,6,15,157,235,182,228,175,191,130,156,247,136,113,99,42,142,220,88,47,119,59,161,159,173,145,169,122,255,126,235,94,132,3,28,58,148,57,41,33,61,135,119,222,246,206,121,28,215,62,219,119,187,167,186,158,215,240,177,196,222,169,45,196,235,3,101,180,158,215,48,147,219,51,24,217,33,121,157,66,148,0,98,75,241,7,50,139,24,16,153,69,124,142,100,150,129,100,96,7,232,144,187,138,251,33,145,240,26,117,200,192,57,167,8,226,19,8,115,80,155,178,68,25,247,246,188,104,36,62,201,0,191,68,155,96,169,55,233,39,197,182,124,250,12,214,79,181,19,146,149,66,66,106,26,74,110,94,122,250,130,244,246,176,25,78,34,149,129,86,216,203,240,105,45,143,196,91,55,230,247,14,15,187,150,91,131,133,248,46,199,1,209,104,107,68,254,31,126,32,143,118,137,200,3,241,113,23,86,182,132,101,143,167,1,150,118,89,169,7,10,142,123,172,84,188,219,24,140,166,223,106,165,194,10,216,133,149,111,188,82,34,41,240,10,162,15,27,177,157,127,107,135,31,91,112,124,159,96,74,156,160,195,203,160,107,188,44,7,31,100,215,35,110,110,102,120,157,71,222,115,177,174,214,215,93,147,83,194,196,31,113,179,87,39,155,91,113,138,199,195,168,212,169,228,0,98,114,143,67,158,164,251,55,246,83,117,37,150,75,22,188,53,63,178,48,225,5,148,83,122,109,84,138,186,220,182,231,249,247,178,228,89,43,170,69,29,64,248,184,141,249,193,123,46,3,54,169,52,24,185,64,51,76,234,66,2,3,9,133,199,178,49,126,227,82,44,193,35,91,223,91,16,139,229,3,180,2,218,76,170,38,254,97,36,60,141,79,181,221,248,72,134,193,241,173,110,84,23,160,192,143,176,194,119,180,105,245,123,229,244,237,213,31,152,187,213,234,236,134,148,231,200,169,176,192,159,127,238,151,86,159,72,237,140,229,87,218,48,241,202,145,139,68,62,137,225,202,238,134,174,46,13,220,246,222,229,214,146,125,209,84,46,246,174,183,137,240,28,223,126,21,224,109,240,86,145,23,92,124,166,76,180,193,112,98,161,54,223,136,176,12,108,248,246,129,207,175,58,16,221,135,85,137,44,204,229,137,122,40,103,89,108,59,222,102,48,187,90,117,149,140,215,154,101,99,44,196,184,241,120,79,246,13,200,152,16,230,20,89,165,89,112,169,174,59,194,18,201,27,236,82,150,76,124,243,165,144,211,232,94,2,72,108,97,214,143,212,67,57,107,27,163,47,235,43,201,228,31,245,149,207,32,60,222,139,55,64,18,230,235,37,62,128,167,97,126,28,199,150,28,133,223,47,217,238,190,102,234,115,252,255,65,222,96,211,216,212,22,73,159,140,253,55,118,60,226,59,38,99,19,211,112,58,118,103,126,73,82,176,245,184,35,110,153,27,34,47,67,197,144,244,225,92,159,4,216,83,66,161,94,106,216,123,129,202,40,144,98,171,175,39,127,155,181,199,61,100,202,62,232,87,21,123,84,255,238,104,195,125,196,225,64,2,2,144,42,159,248,76,217,47,206,217,175,5,43,160,157,181,118,192,112,50,184,182,218,85,182,223,14,194,135,239,234,143,252,46,17,64,61,233,71,207,139,18,58,79,113,121,8,191,11,211,19,163,191,21,237,173,110,78,89,34,6,33,242,65,97,84,48,117,50,136,157,172,234,148,69,21,48,177,108,190,255,41,28,136,171,250,227,12,53,194,15,66,157,73,17,115,23,103,201,106,82,42,5,153,145,159,220,83,166,254,125,55,171,39,48,96,249,57,155,241,106,98,232,242,75,224,213,168,129,219,136,67,87,128,96,201,37,6,189,121,101,229,93,251,205,153,216,53,68,181,247,131,172,191,109,192,209,179,174,212,23,211,200,76,159,190,135,78,216,141,194,216,161,229,212,175,145,251,24,125,221,235,203,162,96,108,204,186,170,183,95,146,179,91,21,7,196,189,113,24,185,237,116,187,181,11,12,85,128,254,155,79,195,91,119,161,123,165,248,194,147,120,245,73,221,79,13,188,104,55,112,161,194,188,21,225,170,203,187,23,39,164,55,245,31,42,128,12,54,207,248,54,162,120,167,223,159,168,14,187,248,229,62,92,94,200,152,248,55,153,200,210,69,245,101,254,109,70,157,140,189,37,147,19,228,1,2,15,125,22,237,254,226,128,209,166,168,119,217,61,51,149,177,76,63,231,103,194,234,68,174,135,210,139,128,231,10,198,87,161,169,222,212,29,47,50,43,65,225,84,69,197,18,91,127,67,218,247,54,127,109,93,1,180,107,192,95,121,253,237,188,171,114,121,245,147,111,105,254,61,87,225,116,243,59,0,108,27,129,126,129,5,194,177,184,122,130,73,99,1,115,181,150,204,243,176,69,158,149,89,115,0,179,245,109,104,126,67,212,135,60,244,66,187,185,30,67,203,139,153,204,89,89,1,186,67,113,106,195,237,82,250,135,157,34,184,117,147,66,24,58,189,82,47,28,77,13,107,218,243,103,9,182,253,44,202,187,174,98,206,229,53,42,222,157,45,228,47,151,136,55,235,140,164,168,113,13,255,42,138,88,168,241,225,153,3,207,145,202,31,17,35,58,252,173,58,214,146,43,74,202,58,91,210,37,249,8,235,75,80,203,199,245,18,196,159,179,23,237,170,20,159,69,104,158,42,154,230,75,88,83,231,167,153,166,68,159,109,34,3,96,156,44,244,227,42,119,69,195,79,254,2,63,215,160,182,207,189,250,68,222,157,82,103,52,123,255,138,195,137,89,223,248,63,144,146,30,227,203,145,39,89,89,218,183,180,2,44,246,191,255,224,254,182,132,67,200,46,147,3,175,52,58,214,36,70,237,65,62,102,254,251,31,82,28,205,215,14,81,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a6fb7ccb-c76c-4cf5-bc34-c2fac7c3b5ca"));
		}

		#endregion

	}

	#endregion

}


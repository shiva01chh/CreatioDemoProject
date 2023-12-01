﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailSenderSchema

	/// <exclude/>
	public class EmailSenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailSenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailSenderSchema(EmailSenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716");
			Name = "EmailSender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,61,107,115,27,55,146,159,181,85,251,31,144,73,42,26,110,232,145,147,203,110,221,201,166,180,122,57,102,173,109,121,69,249,82,117,178,54,53,34,33,105,214,228,12,51,51,148,172,213,233,191,95,55,222,175,25,14,37,217,206,238,109,62,56,34,6,104,52,26,141,70,119,163,209,200,211,25,173,230,233,152,146,99,90,150,105,85,156,215,201,235,52,155,38,35,154,79,104,73,110,127,255,187,181,69,149,229,23,100,116,83,213,116,246,204,249,157,236,21,211,41,29,215,89,145,87,201,79,52,167,101,54,246,234,12,15,189,162,87,89,254,171,87,120,76,63,214,201,17,189,88,76,211,242,224,227,188,164,85,133,112,117,189,139,105,113,150,78,55,55,247,138,217,172,200,147,87,197,197,5,20,235,239,195,188,166,23,101,138,216,236,204,179,4,127,150,231,48,56,3,132,30,38,7,18,254,146,159,103,23,11,14,40,92,161,164,77,229,201,254,110,227,167,131,188,206,234,172,9,29,168,240,34,29,215,69,217,80,227,96,6,19,179,95,192,191,121,112,104,251,199,135,100,64,88,45,24,65,93,2,172,4,202,160,194,215,217,57,249,234,205,193,241,232,120,231,205,254,206,209,254,15,191,60,37,27,27,199,135,251,135,228,235,189,163,215,79,126,252,241,63,254,248,199,64,143,239,134,201,207,244,140,1,43,166,85,242,174,206,166,18,255,175,129,63,178,243,223,255,14,90,125,93,210,11,32,20,217,155,166,85,181,201,17,224,236,195,62,111,108,108,144,231,213,98,54,75,203,155,45,241,251,109,89,92,101,19,90,145,10,234,17,138,45,8,48,98,149,94,64,217,140,214,151,197,164,74,100,219,13,163,241,201,62,61,79,23,211,122,55,131,238,243,139,184,190,153,211,226,60,30,26,157,246,122,167,80,113,190,56,155,102,99,50,70,156,76,148,54,201,208,66,112,237,150,33,233,13,2,103,234,230,69,54,165,252,179,59,8,86,112,68,145,71,105,94,87,100,158,102,37,41,206,9,101,237,200,187,225,132,164,48,178,115,0,176,94,145,146,142,139,114,66,96,196,240,249,60,163,101,162,96,154,131,91,155,151,69,13,139,137,78,36,222,10,11,34,208,244,17,97,37,188,34,235,142,44,242,236,215,5,117,59,11,244,38,105,244,211,34,155,8,8,136,247,237,5,173,159,193,196,212,207,238,90,251,100,104,133,71,182,172,179,35,214,202,237,107,109,77,116,136,188,197,167,195,158,155,87,197,56,157,102,255,72,207,166,116,84,151,48,253,85,203,228,68,103,243,217,122,145,79,179,156,146,154,86,181,228,175,136,76,53,24,82,49,56,77,211,193,81,246,186,133,21,82,213,175,57,184,209,226,236,239,48,101,76,80,174,173,193,112,196,95,107,37,173,23,101,78,114,122,237,3,136,127,162,245,17,173,138,69,57,134,146,162,4,56,113,175,79,34,131,51,163,62,7,179,22,249,163,78,252,254,147,255,78,167,11,26,245,146,227,66,116,209,123,198,0,152,116,13,211,233,248,50,171,36,113,200,117,42,214,100,186,168,65,210,212,25,244,61,5,198,42,139,25,49,8,58,1,6,171,11,178,168,96,139,128,217,171,17,43,50,190,164,227,15,201,35,211,119,183,152,220,124,49,226,98,231,157,40,219,196,177,32,58,171,58,5,1,177,137,34,143,175,237,150,185,56,190,164,4,132,111,1,68,173,211,122,81,161,68,193,217,64,154,164,185,45,39,151,139,16,236,91,76,0,57,64,168,135,57,14,159,211,129,195,31,0,89,244,151,232,89,251,104,94,100,116,58,97,67,201,174,210,90,72,198,57,255,1,146,32,157,0,119,220,8,249,186,55,205,64,36,240,253,236,134,252,66,189,178,103,193,198,239,128,163,128,104,57,87,41,200,47,11,235,247,18,252,128,196,115,90,226,6,229,145,91,147,197,233,193,249,233,113,26,236,156,177,131,5,25,12,72,190,152,78,123,178,206,90,125,89,22,215,140,27,119,202,139,197,12,6,249,6,190,31,124,28,211,57,54,136,231,105,153,206,222,128,170,181,73,34,187,195,72,48,19,231,38,197,216,254,184,29,134,211,227,25,130,22,68,80,19,130,165,56,216,194,191,94,167,57,240,71,9,234,88,205,203,99,139,247,123,75,168,200,120,182,92,224,36,33,29,217,26,13,240,236,243,138,82,50,46,233,249,192,130,190,177,69,176,101,98,115,37,107,201,168,64,114,32,195,32,242,249,33,218,218,201,73,198,150,11,104,163,192,248,53,44,6,198,240,99,86,141,156,243,122,0,153,1,10,195,181,233,22,132,201,132,214,88,213,177,224,9,137,100,12,40,14,177,179,143,125,223,101,36,27,17,201,42,129,117,0,107,176,97,113,172,121,124,71,2,108,177,68,2,189,230,202,84,195,162,29,58,130,146,132,100,167,192,61,204,154,201,207,69,249,129,89,16,137,211,208,196,46,40,237,246,166,52,45,97,187,185,201,199,176,126,114,144,194,108,148,92,0,102,57,155,252,179,226,99,131,160,243,166,254,146,78,97,245,71,38,99,14,71,54,108,38,235,94,242,122,192,168,217,108,62,165,184,90,121,199,146,81,218,57,172,98,108,193,152,98,103,50,65,27,37,218,18,198,18,151,207,41,47,181,249,74,208,251,170,0,237,135,141,27,49,99,232,196,45,72,18,62,166,190,148,226,126,223,114,114,80,76,125,229,78,13,76,230,176,122,65,65,210,151,244,32,199,61,110,18,71,135,83,190,3,24,182,82,212,235,217,27,171,33,111,214,56,10,9,34,157,191,155,135,112,141,3,104,45,157,124,36,89,69,232,19,115,75,19,132,134,169,51,165,132,216,139,97,194,186,114,130,177,158,162,173,161,177,252,77,214,48,150,53,130,110,157,115,11,143,173,3,11,233,246,150,217,69,14,118,221,81,118,113,89,3,159,188,152,166,23,32,131,210,154,160,249,50,6,142,168,200,245,37,172,80,152,106,80,167,120,101,82,178,218,205,252,131,164,19,200,88,210,201,148,35,125,46,195,68,53,98,14,160,79,206,138,98,74,76,204,228,244,47,229,68,16,65,205,117,24,191,9,106,187,123,166,216,230,234,82,42,115,107,6,178,204,217,16,219,56,90,232,137,61,210,89,56,114,113,152,13,147,23,160,169,74,5,141,0,133,199,151,36,86,27,49,161,31,21,167,243,173,49,225,160,190,137,44,58,114,21,12,213,96,201,153,235,183,86,47,66,235,190,91,143,250,8,83,224,39,150,10,168,30,96,151,87,193,165,226,225,106,182,103,106,68,119,229,210,16,237,203,85,203,61,84,206,129,237,174,64,221,229,118,41,227,80,80,218,83,116,20,208,178,234,186,186,176,45,234,50,192,206,18,138,191,6,184,28,169,182,142,75,52,69,207,85,199,186,59,2,86,135,48,159,251,164,192,37,112,157,85,20,118,249,105,133,240,36,0,91,217,97,156,203,134,50,228,0,95,8,100,98,33,33,37,114,166,92,148,101,201,176,122,83,48,205,236,16,132,213,188,190,137,181,220,187,74,113,203,65,188,208,152,27,144,183,105,125,201,249,217,234,102,15,208,175,226,30,119,191,96,85,13,252,184,216,41,203,20,97,62,179,84,57,5,53,217,201,111,44,219,65,214,0,101,107,249,102,121,196,233,65,166,25,40,245,182,40,227,130,183,174,211,241,229,140,75,51,146,213,116,182,210,132,130,112,210,158,60,132,207,32,184,29,41,119,4,246,129,174,151,230,137,127,37,240,76,21,94,85,227,172,98,221,231,206,40,182,80,21,113,202,170,120,168,145,124,174,177,217,98,211,174,164,24,206,165,209,45,204,38,179,19,67,157,200,249,24,30,228,160,182,151,184,69,62,31,254,84,22,139,57,48,211,115,244,85,244,153,199,98,107,139,92,96,41,2,99,125,37,172,210,238,13,155,127,212,187,241,255,137,114,162,244,137,85,46,253,29,162,183,115,144,108,41,10,166,96,87,188,39,84,128,120,151,138,71,77,82,194,62,123,148,230,23,212,31,81,136,108,12,80,242,23,10,106,42,255,243,184,64,114,0,175,134,248,209,232,231,75,178,101,53,190,4,105,9,196,132,29,151,187,183,120,73,192,193,213,186,5,151,130,248,30,139,11,95,29,255,94,25,240,170,207,205,214,204,41,166,198,219,39,38,155,115,158,80,131,144,220,192,73,50,98,109,254,186,160,104,148,84,191,2,119,2,120,92,18,7,163,191,198,10,160,152,100,168,144,192,55,38,235,129,127,98,81,21,12,3,156,4,232,114,49,203,249,247,24,170,246,141,62,5,0,92,88,98,14,6,142,189,147,152,248,72,3,244,5,104,57,82,33,216,197,101,225,161,132,226,153,151,37,111,211,18,104,193,1,144,175,184,133,77,190,253,150,4,62,39,40,112,209,10,143,152,44,82,11,164,97,128,123,197,132,234,113,5,89,62,52,41,88,119,185,13,83,228,87,180,172,67,252,191,127,124,152,216,236,15,42,94,235,250,232,186,50,12,230,139,182,244,15,134,68,51,235,142,53,243,183,98,177,50,59,11,26,208,137,71,66,214,196,166,195,150,185,116,76,137,77,157,198,109,98,155,220,146,59,71,148,106,161,143,146,51,208,199,154,208,16,152,214,51,16,53,24,39,61,51,20,210,29,91,198,198,136,130,211,187,242,250,12,39,2,71,92,162,177,0,8,172,45,157,139,156,75,195,234,74,206,116,148,109,142,205,166,82,55,236,239,18,208,126,90,167,26,101,168,134,5,177,250,60,172,240,132,6,49,83,117,134,213,144,57,106,133,111,41,196,242,238,112,151,178,58,172,64,118,60,196,173,220,75,154,78,80,139,99,158,225,86,47,111,192,80,199,166,194,89,119,3,210,221,0,8,42,33,47,110,230,99,229,207,113,185,88,168,213,47,25,160,22,70,246,43,35,23,227,240,232,228,165,133,155,212,42,109,140,149,8,246,225,128,62,187,152,226,60,160,244,226,68,231,32,78,78,201,7,122,195,92,201,240,213,134,151,140,230,211,172,142,215,7,235,134,84,148,181,147,87,52,191,168,47,201,22,249,222,48,210,101,47,146,59,109,44,110,137,96,61,9,228,228,233,105,159,200,206,85,225,247,167,114,21,89,140,193,161,127,201,157,31,36,111,163,221,238,237,123,95,74,21,13,110,192,141,187,51,223,93,65,199,16,127,12,176,54,74,24,254,59,142,64,205,17,179,207,219,26,170,10,170,144,242,228,88,52,68,132,156,106,241,187,144,193,125,15,93,24,155,96,151,71,116,94,84,153,112,81,178,99,81,225,156,196,222,159,191,176,106,108,197,156,51,17,184,225,63,150,222,240,216,245,203,186,238,210,158,171,25,27,7,154,226,207,204,38,132,90,12,76,119,202,38,66,49,231,149,17,195,99,224,9,65,93,198,238,92,145,138,229,12,48,201,47,77,53,126,238,205,246,144,25,157,193,120,70,53,224,49,19,212,122,109,20,25,38,35,35,212,217,117,9,172,93,138,154,187,89,14,76,253,51,43,138,77,72,178,35,69,220,97,126,94,8,148,53,21,147,87,69,202,182,8,212,61,146,163,162,144,250,14,83,10,209,64,16,221,41,112,142,213,219,180,219,200,30,19,89,210,19,237,215,182,137,247,77,126,10,236,74,62,28,115,92,134,38,98,136,166,192,198,201,119,78,24,143,252,45,112,151,195,80,229,98,227,51,41,169,237,108,85,203,220,255,184,255,64,124,185,147,216,57,150,83,172,127,219,199,47,15,54,131,178,85,133,214,103,176,133,164,160,227,66,202,112,114,55,236,142,158,92,51,76,10,219,80,9,73,59,97,85,141,86,48,19,12,183,97,216,74,48,78,123,61,236,98,179,63,67,95,95,58,85,191,178,177,157,51,187,128,156,221,144,8,5,70,130,182,66,68,230,200,248,95,102,179,250,171,129,86,227,28,13,61,192,220,190,25,194,46,75,124,171,167,117,171,106,133,53,86,64,248,198,195,23,75,178,7,43,177,22,31,126,206,234,203,183,56,22,138,118,87,204,11,247,138,25,140,47,171,138,156,81,245,77,81,31,252,186,72,167,125,147,202,240,227,85,150,127,136,236,73,214,61,118,94,116,238,76,206,185,65,11,160,216,86,251,5,38,243,147,185,31,30,141,59,66,70,127,144,77,184,148,237,224,144,104,237,149,237,69,15,229,34,201,66,32,5,13,231,68,178,151,130,50,83,48,127,60,232,48,158,31,86,186,97,39,62,87,45,119,172,55,29,126,43,155,168,164,56,83,252,108,225,137,121,90,141,209,95,213,167,62,227,250,162,71,82,252,168,252,42,43,107,152,22,125,50,21,175,114,240,132,155,62,110,216,154,137,194,199,89,80,47,112,116,110,241,145,209,210,63,101,73,14,62,178,120,72,243,140,18,131,130,2,167,76,230,233,154,117,160,182,236,124,170,213,118,254,178,124,178,26,131,128,184,99,178,8,38,6,101,150,10,63,48,202,63,43,135,117,225,172,61,141,155,137,103,7,150,67,99,219,132,133,231,82,86,116,207,178,224,30,28,115,113,110,193,176,125,140,216,131,129,211,125,59,48,64,216,240,149,247,172,109,173,4,86,137,9,240,223,188,255,219,228,125,79,186,162,55,149,59,204,216,232,250,24,245,157,60,2,247,63,136,237,63,47,191,175,182,73,116,98,124,92,66,150,83,142,187,90,108,95,137,229,100,107,242,65,11,55,102,38,28,172,9,175,173,221,21,1,119,221,204,250,53,104,116,70,114,208,210,98,69,42,219,45,191,114,195,18,221,17,49,219,215,106,19,50,127,149,56,145,2,209,247,51,194,216,121,59,220,91,101,0,155,184,50,34,204,242,227,66,149,31,81,152,89,36,124,37,190,237,141,213,183,189,98,126,227,125,223,29,235,10,187,83,88,57,193,90,50,242,90,117,207,127,75,24,24,55,172,128,192,15,81,110,159,48,180,158,94,240,182,70,137,116,57,12,171,151,245,108,106,245,160,139,68,157,151,62,55,185,211,193,105,174,93,190,120,6,157,28,151,55,108,242,69,239,195,217,188,40,185,193,174,227,143,251,164,88,212,124,66,64,143,47,74,52,35,230,226,15,237,159,178,148,32,85,111,160,106,154,75,234,147,8,126,190,240,170,102,49,15,11,135,135,230,115,255,155,248,42,226,231,194,155,128,12,185,219,80,189,32,116,29,205,169,163,209,221,230,166,100,95,113,11,81,113,126,7,22,134,247,219,73,36,130,157,196,189,17,139,46,207,34,76,140,26,245,30,255,96,141,55,176,165,26,135,136,146,204,172,35,197,90,39,57,224,139,1,137,154,43,6,20,6,222,242,109,186,205,96,175,228,96,88,126,223,92,67,159,96,95,48,154,249,65,106,189,22,91,146,151,58,133,206,29,35,148,24,38,53,151,220,153,98,173,80,107,224,119,166,172,165,212,231,74,6,122,135,107,154,19,232,227,229,241,235,87,184,192,102,105,29,188,72,101,221,143,10,99,66,156,187,92,222,85,41,243,114,67,32,184,216,186,128,112,177,200,38,111,83,192,174,196,195,143,232,100,231,201,255,60,125,242,95,167,183,255,121,247,68,253,253,99,135,191,191,255,225,110,217,53,5,51,128,157,180,24,241,195,60,195,185,206,254,65,25,99,187,113,226,134,235,39,76,31,22,235,142,244,187,79,176,187,201,171,34,178,189,99,0,178,27,226,254,206,142,103,15,67,17,211,29,30,200,35,197,184,179,21,179,73,206,210,202,218,68,84,235,96,72,124,55,87,12,113,88,172,233,58,222,20,111,68,242,216,43,232,236,42,131,217,124,119,244,170,66,175,224,24,143,137,180,5,194,79,12,58,31,89,139,205,93,109,1,88,160,128,180,239,3,188,82,192,1,40,190,136,80,187,86,255,223,253,194,245,244,226,21,126,247,110,161,123,47,237,177,217,78,70,190,180,197,162,22,20,71,176,35,78,238,189,116,58,173,134,249,112,118,49,42,199,234,248,92,170,70,129,192,38,77,30,169,92,117,13,241,171,104,90,142,47,161,167,67,188,56,228,157,52,4,131,223,71,188,13,139,141,24,206,240,182,41,54,142,12,43,160,158,79,1,150,5,91,104,211,219,36,170,202,241,224,100,253,125,116,186,29,95,214,245,60,62,249,219,251,232,253,251,234,244,187,237,222,255,38,73,47,190,125,122,183,1,255,126,127,215,139,197,255,35,209,120,147,68,157,155,112,100,46,181,138,185,140,204,154,190,6,53,57,193,250,36,130,9,172,234,13,163,241,134,240,1,71,125,28,173,140,204,126,248,184,19,248,185,226,184,173,38,150,191,246,177,199,188,95,92,231,211,34,157,152,131,110,63,92,248,183,48,121,136,48,113,59,17,243,240,174,156,138,184,113,73,210,75,80,224,167,176,131,45,202,236,1,80,160,53,129,45,131,126,4,131,98,6,51,87,255,115,202,55,117,211,199,30,172,42,102,67,60,158,43,27,95,20,207,149,98,37,34,177,94,48,197,47,150,213,251,30,60,67,29,51,132,31,167,32,215,243,143,240,239,88,64,238,243,159,135,115,158,232,97,200,236,192,61,216,232,69,227,215,120,209,194,96,162,153,243,123,192,65,39,172,30,173,212,234,53,2,158,156,38,201,94,177,0,118,222,34,79,149,65,171,252,44,12,10,239,131,223,19,179,90,106,255,135,2,203,163,181,43,5,243,79,186,206,26,251,36,14,227,248,223,3,98,54,58,249,241,244,153,170,139,199,223,84,221,148,31,176,200,63,195,100,215,64,60,107,157,53,157,51,183,206,187,108,162,226,47,64,186,170,66,85,182,137,126,9,126,144,6,197,13,96,85,232,5,27,230,189,162,113,213,72,122,254,149,214,181,53,228,220,44,95,80,213,207,157,77,50,193,217,65,154,253,201,161,153,90,5,146,102,156,96,38,136,224,208,244,234,97,190,43,245,83,215,224,209,248,42,84,211,74,152,32,6,114,96,76,152,26,178,138,30,89,83,201,8,6,26,77,53,100,221,17,31,167,144,55,111,65,38,102,31,131,67,255,94,15,93,221,218,51,218,176,77,214,133,225,221,45,215,141,139,233,68,6,238,125,19,221,90,77,239,110,237,85,125,183,113,107,176,10,252,50,201,123,23,185,144,129,94,26,50,108,104,155,77,245,13,77,68,254,153,8,201,24,75,244,250,10,28,222,45,40,174,193,168,208,211,120,231,59,25,197,46,47,225,117,62,235,167,86,244,11,206,41,236,198,236,10,82,199,205,151,183,228,247,151,236,80,154,246,139,76,7,110,199,13,59,7,99,119,107,249,74,46,80,29,91,74,44,43,101,103,228,221,67,234,161,246,238,13,191,245,164,129,90,218,147,6,139,177,99,157,169,171,175,133,161,107,14,13,185,63,253,8,18,150,165,124,208,225,80,171,135,169,99,220,210,46,135,102,4,137,173,120,143,99,150,205,40,198,1,132,64,225,183,37,86,141,223,72,141,182,93,9,128,201,228,109,85,24,28,155,99,115,116,106,127,150,56,202,41,102,187,38,161,31,113,89,193,148,30,121,251,235,159,35,166,3,103,104,139,188,223,136,183,159,179,186,152,246,104,11,93,30,233,147,127,156,126,215,123,22,57,251,47,6,70,0,50,147,182,221,151,199,138,90,61,171,237,87,161,105,134,40,19,213,181,214,35,216,53,57,103,143,166,85,96,111,230,91,178,130,0,226,189,150,130,145,86,39,79,165,76,52,187,136,146,136,124,103,55,145,50,52,82,165,209,41,119,244,5,226,148,5,138,176,96,198,160,234,68,204,156,251,5,40,101,79,140,130,180,130,202,47,88,133,119,80,145,235,172,190,252,98,26,191,117,215,99,185,154,46,53,116,63,2,123,185,154,254,40,198,197,189,149,108,78,244,46,138,181,23,158,109,208,40,160,100,187,122,184,163,59,51,30,213,158,73,88,144,219,207,7,207,223,87,127,200,102,23,176,52,193,244,61,249,91,20,129,221,26,69,61,248,36,151,206,214,201,223,250,88,220,199,66,46,41,183,226,237,205,147,247,215,223,109,192,146,229,255,191,253,225,142,255,49,184,125,218,255,225,14,32,68,206,145,161,163,202,30,5,181,228,190,133,164,62,225,113,132,142,171,137,104,137,105,45,34,217,140,35,45,85,0,187,37,255,214,214,142,45,55,104,103,64,9,220,175,37,219,86,133,209,226,140,3,137,159,246,173,15,226,146,195,19,188,228,176,25,16,62,70,148,55,83,31,223,208,107,118,233,166,103,163,102,196,65,251,82,27,227,167,29,193,183,90,216,178,19,181,220,16,180,44,98,150,197,177,34,139,62,226,136,8,13,207,32,95,240,6,15,222,6,22,250,146,64,114,121,244,178,163,38,103,19,135,46,186,197,30,163,161,109,37,114,229,239,233,93,132,49,230,234,46,187,231,126,82,11,212,224,75,91,6,75,234,246,137,53,72,187,251,208,93,164,21,212,64,33,162,95,30,31,191,85,174,3,208,79,62,152,110,153,131,127,74,183,204,189,37,231,203,186,158,191,228,164,184,167,107,162,163,59,33,138,171,193,228,236,219,42,31,48,255,93,47,254,54,155,168,63,235,65,242,135,222,118,252,109,53,22,69,209,255,119,47,195,31,61,47,67,155,201,236,186,25,62,157,201,236,91,150,206,52,39,27,181,74,1,153,126,156,108,115,217,96,97,251,244,212,131,103,216,147,141,242,197,196,94,3,248,109,24,152,66,178,48,85,188,34,60,149,209,191,150,179,215,210,37,229,173,184,199,208,34,239,45,186,80,88,49,66,63,220,149,218,162,20,246,120,246,76,204,130,250,230,224,248,197,209,206,235,131,159,15,143,254,130,183,203,15,167,147,119,195,96,46,84,197,215,19,138,119,18,38,130,65,187,156,50,237,103,21,254,197,80,218,199,214,0,38,234,137,144,169,181,109,53,72,81,176,73,68,134,85,149,95,53,65,66,178,150,212,18,98,95,83,121,185,41,136,155,193,236,50,61,235,154,190,114,102,7,180,105,207,179,84,162,108,88,203,92,223,70,237,192,17,76,27,200,224,118,213,0,174,13,142,101,48,88,237,77,123,192,7,198,61,134,71,116,86,92,209,157,233,84,101,240,176,212,172,252,6,213,44,81,156,12,39,252,242,65,21,219,233,60,164,4,10,101,230,8,38,226,224,196,177,125,53,6,234,43,155,168,76,88,201,53,101,217,169,166,172,18,233,59,81,172,174,46,181,180,208,98,0,90,5,140,161,246,241,141,137,251,106,136,131,233,18,177,151,77,88,192,148,146,112,157,110,183,189,155,79,82,188,252,98,98,186,130,209,233,203,31,223,218,225,67,82,95,0,79,21,69,155,179,0,95,166,213,168,29,108,136,5,135,231,177,7,193,246,186,168,203,220,198,214,135,172,25,51,128,125,31,1,97,44,97,18,34,144,69,181,172,55,206,156,235,114,157,239,113,99,111,96,118,164,213,165,205,48,59,32,226,174,164,59,61,85,121,154,77,102,95,217,19,104,4,209,233,178,199,222,5,201,69,118,69,115,118,21,76,228,44,224,220,199,236,132,230,188,106,156,18,199,72,8,193,126,113,248,58,184,37,95,204,212,65,77,122,245,151,188,82,205,130,26,112,76,59,134,95,12,247,2,161,238,226,76,163,168,179,179,102,240,143,215,151,180,164,92,2,42,11,21,54,205,175,12,29,19,139,211,44,175,98,46,39,197,193,86,69,113,158,132,236,212,218,183,143,7,79,138,165,149,111,251,62,244,62,128,97,55,196,64,153,143,76,118,196,83,124,15,150,84,7,77,6,213,98,94,36,7,1,137,222,128,5,154,237,240,49,197,179,48,157,204,163,107,26,229,17,173,43,162,169,116,142,129,255,232,68,167,30,183,255,107,45,154,17,139,160,22,157,61,214,122,49,169,5,70,196,1,252,48,188,30,56,77,183,238,84,39,166,15,165,129,63,85,85,229,132,232,236,20,54,137,97,24,3,50,146,25,55,28,140,186,228,223,235,66,125,184,199,188,203,60,229,109,247,86,28,185,37,116,105,52,92,134,185,80,168,173,56,93,1,67,210,119,233,52,177,75,247,188,91,55,69,12,19,40,154,192,166,82,201,51,44,248,169,30,37,40,91,127,211,186,191,249,221,86,38,77,37,94,172,238,128,148,110,215,247,214,108,22,109,175,172,114,70,114,219,213,200,28,25,184,190,194,40,168,239,173,132,115,108,247,9,77,84,0,61,117,187,9,222,128,249,212,157,125,178,142,140,197,212,33,160,115,217,229,218,145,31,231,156,144,93,138,14,26,30,3,93,6,214,166,185,8,31,111,241,125,198,43,95,192,220,101,9,114,185,233,222,163,138,248,94,122,183,43,44,23,102,102,240,250,26,106,151,60,178,93,193,93,237,146,71,112,146,134,231,36,99,23,98,248,62,152,225,155,2,117,255,55,51,95,12,181,37,51,133,197,234,81,4,30,86,207,116,36,102,95,136,184,250,223,206,53,107,135,41,216,0,91,242,252,162,46,198,43,169,245,223,133,89,238,86,102,153,123,220,138,144,106,158,117,245,224,247,206,149,8,243,233,21,140,213,231,25,168,197,109,6,17,191,207,83,2,172,87,196,100,140,202,116,115,201,174,120,254,231,166,203,17,1,132,72,243,229,13,247,146,196,74,111,150,224,251,15,226,245,12,48,101,77,179,158,37,195,23,147,29,97,58,13,236,26,207,90,152,120,142,86,125,96,195,131,240,121,159,216,240,186,191,255,243,37,29,73,102,96,6,157,131,70,112,63,186,133,193,124,94,226,133,113,248,228,20,124,83,168,27,152,247,229,57,27,192,231,102,57,187,247,79,78,47,41,54,24,143,35,146,236,116,124,31,140,173,156,78,238,71,193,229,32,63,47,77,151,227,243,217,168,188,95,80,236,251,224,35,216,33,15,35,174,7,233,203,208,212,67,227,241,222,33,90,118,85,111,132,107,68,171,250,24,170,133,69,60,116,37,216,130,201,33,239,101,33,81,218,210,110,152,191,45,139,11,188,22,234,52,213,31,30,244,38,17,59,72,229,119,63,145,71,133,43,74,126,221,207,152,87,4,56,67,220,132,149,9,184,127,73,197,36,112,132,116,189,37,184,116,189,120,24,80,65,76,246,248,151,120,66,39,48,176,223,240,53,67,251,229,168,38,78,58,208,140,212,240,80,148,193,106,232,70,100,231,246,44,140,201,206,26,41,220,163,220,117,50,98,63,220,244,157,176,204,231,241,247,234,158,64,98,230,9,85,133,24,92,20,91,59,141,241,241,103,116,222,198,17,203,181,214,75,134,21,59,193,138,69,246,75,149,107,75,188,13,133,79,192,164,149,192,69,30,171,219,195,17,88,39,7,31,233,120,81,211,17,136,174,180,180,125,62,221,169,176,178,191,65,182,91,91,190,233,132,195,2,212,251,69,174,56,144,188,113,103,207,120,163,116,216,105,16,14,13,44,209,36,75,252,43,23,44,24,205,170,109,230,98,27,52,228,63,92,30,52,222,215,219,36,7,171,30,29,227,207,94,76,204,12,181,131,102,20,194,233,106,165,67,112,66,239,1,134,51,167,4,212,173,9,187,182,63,57,204,129,169,15,75,16,43,187,55,59,213,56,182,176,161,110,10,221,54,116,58,231,210,21,217,114,156,186,34,220,7,102,243,105,144,189,151,191,8,215,196,80,145,203,200,107,45,204,196,250,106,226,89,77,29,43,87,13,85,153,117,221,65,25,35,17,91,245,7,122,163,174,207,4,211,235,138,100,18,177,195,9,86,158,93,249,78,85,211,48,148,183,254,47,244,6,51,96,247,204,251,72,205,173,48,206,233,3,62,110,209,130,158,204,254,235,161,166,113,187,107,21,27,45,58,129,39,67,62,219,99,108,206,226,239,244,22,155,236,78,178,29,193,172,195,242,135,184,219,32,126,53,164,120,85,164,184,111,146,87,22,143,171,221,47,102,174,106,137,212,128,196,242,123,207,238,79,38,238,96,157,132,87,42,227,50,217,42,121,65,235,241,37,110,149,251,187,177,49,178,229,174,111,215,186,136,250,205,86,130,229,34,227,247,4,173,205,243,192,221,117,44,66,171,106,10,105,179,42,14,199,169,249,213,192,132,223,97,40,166,203,5,198,225,121,96,188,12,94,34,84,3,118,87,35,160,91,161,39,159,90,94,222,177,231,174,136,250,13,110,148,224,91,52,162,195,14,231,116,252,10,83,21,120,138,143,29,196,186,249,128,36,228,85,222,221,144,77,66,26,60,203,114,223,152,192,67,134,162,132,94,10,92,138,222,178,235,73,35,253,254,158,76,156,46,155,155,17,8,42,210,196,143,175,183,222,23,52,217,112,148,158,83,150,36,203,23,244,145,241,158,168,92,115,65,166,169,28,94,209,120,240,48,195,227,50,155,197,235,207,214,123,225,44,157,1,174,240,67,91,36,81,172,188,70,42,2,75,166,30,146,81,62,169,44,48,29,226,97,134,87,53,123,33,235,223,232,205,70,148,107,249,44,239,33,26,131,124,123,198,199,207,78,78,201,45,129,193,246,201,122,127,93,166,90,146,204,46,59,19,47,66,104,0,66,171,79,132,173,80,166,215,60,46,107,176,69,228,223,156,140,61,89,147,107,255,102,197,240,228,200,26,61,12,236,80,176,100,236,210,250,159,215,123,44,58,186,67,255,193,201,147,13,229,131,83,230,156,157,140,110,42,188,161,184,159,165,23,121,81,213,217,184,98,153,161,119,242,116,122,83,101,21,64,28,79,23,19,138,162,27,203,247,240,104,12,54,147,83,115,194,217,25,199,176,218,91,84,117,49,19,201,246,100,32,102,251,102,25,12,221,100,216,219,96,162,79,134,244,203,12,218,45,234,130,117,10,130,16,108,152,49,203,147,249,144,17,52,3,181,7,98,173,24,243,36,67,230,55,4,232,48,141,25,83,115,36,73,218,196,203,220,204,117,215,73,128,184,57,242,164,40,105,68,201,122,248,164,169,86,108,8,164,38,198,176,222,253,75,49,95,52,75,140,167,18,37,138,23,89,222,231,242,73,22,173,56,203,59,18,34,43,35,139,155,66,0,182,29,71,61,188,90,18,59,74,88,182,157,225,67,240,18,60,10,81,202,20,96,191,126,91,120,60,39,78,23,6,4,177,208,54,153,200,202,48,149,195,10,225,140,22,103,51,60,42,157,24,47,202,178,125,65,226,153,203,44,150,32,57,4,114,252,55,211,197,101,144,109,132,176,158,104,96,125,194,61,158,58,31,120,178,183,40,241,61,176,61,128,10,204,111,220,20,49,76,6,131,56,203,30,202,241,123,148,87,25,162,20,191,224,201,117,6,229,68,37,4,8,220,53,104,222,149,172,179,90,35,239,156,76,237,215,176,170,100,8,42,15,155,233,180,164,88,208,174,60,219,215,103,193,187,203,65,168,137,148,245,37,24,129,5,96,56,165,93,209,56,198,202,14,128,115,158,36,208,209,87,212,152,237,206,10,6,176,179,36,81,103,59,78,159,227,241,106,112,172,68,163,14,172,51,1,172,243,84,120,153,75,45,249,38,149,148,146,142,51,158,215,148,19,199,209,88,36,37,66,77,199,227,163,246,198,114,248,161,198,103,75,91,203,1,27,230,25,19,50,70,46,209,3,243,119,242,166,200,169,97,220,200,68,163,182,97,19,32,25,183,205,163,183,170,190,169,83,26,80,190,10,250,18,91,113,146,217,93,153,1,106,125,49,0,123,182,143,158,19,195,187,131,146,208,164,153,243,233,172,225,219,253,35,172,220,35,75,79,193,12,100,44,14,110,218,206,26,115,76,124,115,114,172,103,33,140,187,191,93,2,6,177,107,227,170,131,97,105,59,252,211,57,159,40,74,12,51,143,168,158,22,51,145,176,73,119,43,129,240,89,224,139,206,58,202,228,153,157,98,244,172,41,77,176,127,193,220,224,55,139,255,66,25,130,179,7,230,6,54,31,236,19,132,10,109,50,108,90,49,63,136,178,174,57,35,73,141,5,29,115,142,62,25,199,92,161,239,117,60,135,8,156,66,136,51,8,167,79,241,181,235,25,4,67,173,215,107,57,90,8,141,21,25,206,114,202,237,222,96,71,45,227,109,242,180,90,126,71,222,110,187,177,242,9,86,56,37,155,134,44,234,236,157,48,252,6,175,129,96,103,197,71,124,37,124,36,82,2,163,11,193,75,138,18,244,14,84,122,7,213,25,145,59,167,192,241,27,111,181,35,150,140,66,253,201,7,118,196,203,59,87,236,114,166,198,161,193,3,114,31,18,92,95,210,92,29,102,66,11,29,8,96,15,112,9,129,128,148,139,124,146,144,67,245,218,120,41,231,101,188,165,103,243,249,198,216,123,59,210,102,59,129,248,80,39,247,241,186,147,156,199,87,213,234,39,126,205,75,45,68,53,219,234,143,2,211,213,178,250,2,200,123,135,129,50,231,202,178,35,64,103,157,202,43,2,251,244,60,5,221,24,241,218,135,242,38,133,215,116,116,134,20,5,108,123,156,205,168,112,62,225,207,136,229,46,147,31,146,215,25,175,170,31,205,214,30,75,19,148,1,192,61,111,150,182,5,150,162,214,32,126,202,46,226,208,149,144,14,14,127,241,58,211,146,80,90,255,41,12,92,46,156,167,205,157,18,184,185,207,194,80,41,134,65,79,217,213,55,251,121,97,51,184,17,71,88,161,201,122,5,139,106,210,184,102,216,137,129,233,207,4,201,115,78,121,46,161,76,92,10,219,223,197,43,34,77,222,74,96,214,118,57,84,194,46,86,126,168,84,193,48,23,113,154,13,168,99,224,48,119,234,178,101,198,3,68,100,156,177,238,199,5,27,116,219,98,22,42,80,119,138,115,113,185,91,171,61,173,241,16,14,89,154,124,191,226,236,169,61,133,149,138,86,182,230,120,146,214,233,231,9,38,86,111,132,201,120,98,117,8,196,2,122,29,205,80,31,119,16,155,8,125,91,107,147,113,192,134,213,217,18,150,110,92,12,121,85,92,224,217,208,62,61,91,92,196,223,68,39,198,185,192,41,59,150,98,206,90,137,195,153,14,253,103,71,155,195,201,38,185,213,216,222,169,243,82,133,181,113,154,100,15,128,108,111,219,199,94,158,182,234,200,34,33,44,208,4,241,100,141,229,34,49,148,121,199,211,106,121,38,252,195,13,229,166,105,37,10,187,230,106,81,69,172,9,155,56,200,6,195,124,46,98,168,90,72,197,175,205,218,170,78,108,114,64,48,68,171,111,29,33,72,88,173,136,51,175,71,166,158,143,54,159,128,88,62,161,1,211,65,2,128,137,12,56,84,28,139,71,162,134,111,151,122,152,241,181,216,136,68,159,8,155,1,138,77,28,228,123,35,88,129,65,218,36,17,249,78,76,240,55,145,93,23,119,110,168,40,126,14,247,93,88,168,83,136,111,147,184,167,7,238,189,57,208,215,156,102,60,57,18,122,199,172,125,58,212,160,235,7,141,56,48,74,133,187,191,120,6,196,6,39,202,67,245,217,134,12,70,23,207,127,210,178,65,171,106,138,98,158,178,209,192,12,97,194,140,180,118,151,31,188,222,255,100,212,113,250,81,72,218,79,174,200,218,232,249,196,171,176,35,206,165,222,144,70,138,127,56,15,172,54,230,29,71,150,44,132,144,249,100,131,95,42,117,156,16,212,176,188,9,74,81,117,217,45,116,201,77,80,129,201,104,160,2,15,239,45,52,8,107,172,76,36,68,250,118,155,56,211,147,38,46,114,51,222,108,178,157,57,132,30,124,4,219,17,254,213,113,250,162,254,38,9,59,122,186,210,68,119,109,92,190,147,184,49,231,146,175,151,54,93,85,214,35,158,171,71,55,59,63,137,195,20,157,104,75,113,141,8,35,226,122,92,227,245,154,54,45,68,154,9,178,133,161,168,171,35,39,222,139,156,74,161,109,121,74,61,163,15,123,32,84,195,202,171,154,167,204,196,21,36,72,168,31,23,14,8,12,209,213,82,171,126,148,94,25,97,52,152,33,129,173,28,106,81,183,206,198,217,60,93,229,222,183,210,52,21,232,135,146,214,21,31,158,130,164,173,213,240,28,56,226,196,176,209,174,168,60,111,227,12,44,73,192,45,93,94,230,88,186,70,60,226,91,77,159,72,159,49,215,232,208,79,39,175,65,165,135,137,244,236,85,204,144,231,156,115,43,128,104,45,55,91,186,45,126,78,5,112,7,118,220,200,192,171,29,98,151,157,137,91,211,156,20,156,84,156,70,210,140,142,151,115,154,244,31,77,69,210,38,55,49,191,157,164,137,221,237,95,149,221,208,58,82,124,193,95,215,237,148,120,69,230,145,50,47,111,54,189,76,28,118,35,59,142,227,134,8,52,165,3,138,116,68,161,12,26,195,3,163,194,86,220,156,58,99,220,154,46,131,117,35,242,56,154,93,170,51,4,223,92,16,123,209,242,247,228,16,172,245,166,156,237,54,9,46,223,224,214,224,217,106,50,139,175,189,237,232,114,189,249,200,189,67,80,86,71,171,233,102,193,40,53,249,137,12,92,223,167,60,107,212,106,197,68,154,125,226,12,237,58,99,187,178,211,141,218,153,199,152,38,200,217,245,55,133,50,237,130,197,245,47,143,182,61,180,225,123,200,7,206,93,98,147,166,88,99,62,166,6,127,114,4,0,179,234,210,108,125,6,38,199,135,103,6,234,254,13,152,77,227,107,208,136,50,43,132,53,131,205,21,7,233,18,55,132,237,132,239,117,171,130,14,35,168,122,240,153,75,47,29,165,0,125,71,34,102,35,5,88,49,128,169,62,230,90,105,71,177,183,145,3,119,120,161,253,196,163,65,207,134,161,177,13,182,246,215,149,179,55,117,219,147,66,251,4,191,167,109,112,191,90,47,98,7,97,8,182,141,205,101,115,251,37,213,149,247,33,150,229,198,182,224,197,86,193,189,77,203,66,25,69,109,181,55,29,9,215,165,244,235,11,40,215,217,116,74,206,216,61,163,9,210,68,20,171,167,93,86,214,164,86,142,215,132,250,32,188,10,115,143,229,150,149,140,103,30,97,108,54,142,133,23,163,125,35,236,57,161,176,246,81,68,246,196,67,149,134,96,23,170,174,109,174,181,132,85,117,10,155,64,70,193,138,141,46,39,190,63,185,43,171,52,135,20,218,80,253,129,63,86,90,42,182,177,204,228,57,10,31,160,62,86,193,177,200,157,181,43,217,181,5,173,192,118,100,104,201,125,198,137,147,74,161,55,41,211,243,238,47,30,220,159,225,188,155,125,210,209,191,229,234,122,250,4,160,225,169,63,159,215,76,71,131,195,106,142,43,215,114,62,24,92,120,73,167,243,22,22,81,97,85,88,235,49,51,151,241,115,241,202,117,29,185,39,232,201,113,161,15,104,227,121,154,97,128,25,193,255,179,192,178,62,177,138,220,168,22,80,245,63,96,23,114,166,48,15,103,149,136,21,199,221,189,80,193,219,115,156,53,40,80,61,137,172,86,209,41,139,53,128,191,188,139,187,156,166,73,139,251,178,111,232,89,125,73,139,62,83,128,218,210,108,4,142,159,186,228,218,185,207,217,19,147,78,97,102,239,75,216,41,75,213,195,13,152,212,190,76,218,96,210,182,44,55,247,164,7,189,248,213,146,51,164,179,155,192,153,114,183,35,172,207,125,62,133,215,222,5,174,162,95,19,229,229,14,0,203,52,59,190,212,80,36,209,27,97,88,22,155,125,135,55,120,56,212,195,229,196,62,152,70,8,198,167,242,127,145,65,31,157,221,150,31,117,174,192,58,159,115,110,31,116,108,104,239,7,95,234,236,80,36,34,210,9,136,58,111,36,193,76,68,34,0,216,226,160,128,95,166,31,184,7,182,236,89,114,87,36,6,243,14,177,50,248,239,255,0,131,169,170,232,2,177,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateTestMessageSubjectLocalizableString());
			LocalizableStrings.Add(CreateTestMessageBodyLocalizableString());
			LocalizableStrings.Add(CreateNotAllowedSendingFromThisMailboxLocalizableString());
			LocalizableStrings.Add(CreateNoAcceptedRecipientsErrorLocalizableString());
			LocalizableStrings.Add(CreateActivityTypeEmailIsNotDifinedErrorLocalizableString());
			LocalizableStrings.Add(CreateNoRecepientErrorLocalizableString());
			LocalizableStrings.Add(CreateEmailSenderNotSetErrorLocalizableString());
			LocalizableStrings.Add(CreateNotEmailTypeErrorLocalizableString());
			LocalizableStrings.Add(CreateActivityDoesNotExistErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateTestMessageSubjectLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bb67c5b0-f575-4678-8606-5d9ecf705462"),
				Name = "TestMessageSubject",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a"),
				CreatedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716"),
				ModifiedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTestMessageBodyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a4f2ea0f-cddd-461d-ac9b-5231be51b4eb"),
				Name = "TestMessageBody",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a"),
				CreatedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716"),
				ModifiedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotAllowedSendingFromThisMailboxLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("67fde6e7-54a1-4db0-a606-ccf2041b0753"),
				Name = "NotAllowedSendingFromThisMailbox",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a"),
				CreatedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716"),
				ModifiedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoAcceptedRecipientsErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("52351648-7827-4713-9e9a-5d0106d69b7e"),
				Name = "NoAcceptedRecipientsError",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a"),
				CreatedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716"),
				ModifiedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateActivityTypeEmailIsNotDifinedErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("da830684-264a-48f1-8168-97a6ce696b66"),
				Name = "ActivityTypeEmailIsNotDifinedError",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a"),
				CreatedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716"),
				ModifiedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoRecepientErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f169ac9d-081a-482f-9b4e-34225c670aa5"),
				Name = "NoRecepientError",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a"),
				CreatedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716"),
				ModifiedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmailSenderNotSetErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("728bcb13-b89f-4587-a93c-63398e5fbdd3"),
				Name = "EmailSenderNotSetError",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a"),
				CreatedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716"),
				ModifiedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotEmailTypeErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6548d6de-26ea-480a-ba71-5a87d3ef623b"),
				Name = "NotEmailTypeError",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a"),
				CreatedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716"),
				ModifiedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateActivityDoesNotExistErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c514b856-69b8-4b2c-82be-24fec978189b"),
				Name = "ActivityDoesNotExistError",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716"),
				ModifiedInSchemaUId = new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e0e5b82b-26d5-4286-b711-73e4dd521716"));
		}

		#endregion

	}

	#endregion

}

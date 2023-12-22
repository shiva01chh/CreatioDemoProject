﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailMessageHelperSchema

	/// <exclude/>
	public class EmailMessageHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailMessageHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailMessageHelperSchema(EmailMessageHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("240b9c1d-cca6-4a06-b885-11b14d6a1945");
			Name = "EmailMessageHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,61,107,115,220,70,142,159,181,85,251,31,232,217,92,150,170,157,140,147,189,111,182,165,148,245,112,50,187,182,149,149,228,203,7,159,43,69,145,45,137,103,14,57,38,57,146,117,138,254,251,1,253,68,63,248,152,145,108,199,87,123,117,181,177,56,221,104,116,55,128,6,208,0,186,76,22,172,89,38,41,139,78,89,93,39,77,117,222,206,246,171,242,60,191,88,213,73,155,87,229,159,255,116,251,231,63,253,249,79,91,171,38,47,47,162,147,155,166,101,139,167,206,223,208,163,40,88,138,205,155,217,79,172,100,117,158,122,109,14,146,54,241,62,190,204,203,15,230,227,69,81,157,37,197,147,39,251,213,98,81,149,179,151,213,197,5,124,54,191,207,203,150,93,8,180,158,47,243,25,254,89,159,3,238,77,103,147,87,73,94,156,85,31,15,170,69,146,151,193,14,175,217,117,11,104,227,188,255,209,84,101,231,15,14,170,116,181,16,217,238,95,28,176,244,231,154,117,125,183,247,160,179,213,193,94,231,79,135,101,155,183,57,157,169,211,224,69,146,182,85,221,209,226,21,107,154,4,23,223,76,15,90,253,165,102,23,128,78,180,95,36,77,243,36,58,132,69,45,68,75,246,51,43,150,172,230,173,222,30,176,243,100,85,180,123,121,153,1,132,184,189,89,178,234,60,158,251,205,183,183,223,65,251,229,234,172,200,211,40,69,160,1,152,209,147,40,208,21,250,9,186,12,34,117,204,10,190,112,205,193,233,145,104,245,248,241,227,232,89,179,90,44,146,250,102,87,125,224,109,163,90,53,142,50,32,209,168,173,147,178,57,135,113,171,179,255,1,154,158,233,222,143,105,247,101,93,181,240,43,203,40,222,246,176,91,10,67,141,226,47,117,5,168,227,174,60,137,126,225,179,150,13,60,236,228,23,198,162,180,102,231,59,147,231,192,92,87,121,123,51,121,188,27,229,101,211,38,37,112,108,158,49,216,228,243,28,112,77,53,3,206,76,119,11,97,181,204,47,243,166,125,246,211,42,207,118,5,206,243,172,137,110,163,11,214,62,141,26,252,159,187,104,39,42,217,53,105,23,111,63,237,69,211,93,69,192,101,181,40,163,18,37,75,148,148,89,116,149,20,43,248,103,150,115,4,161,239,16,142,7,186,229,179,166,173,129,134,166,145,192,120,159,131,254,47,1,47,132,117,87,79,51,135,191,176,50,19,219,33,62,220,73,42,114,62,171,45,123,145,179,34,195,237,170,243,171,164,101,61,196,68,118,107,14,146,139,239,212,98,89,176,5,108,18,95,25,189,113,179,232,77,195,112,157,144,179,162,162,186,136,146,229,18,198,103,117,39,177,241,193,163,6,1,165,176,212,73,86,149,197,77,132,227,68,191,33,128,157,8,254,249,42,41,129,63,106,144,192,45,138,78,86,199,19,190,55,39,55,101,58,81,11,240,160,19,85,100,249,75,2,84,157,230,203,164,108,143,171,130,89,84,122,157,183,151,48,215,140,69,147,23,117,181,152,68,171,50,255,176,162,212,59,48,107,61,93,220,201,232,183,115,0,130,131,204,51,152,181,66,0,196,101,211,54,179,14,124,112,220,167,159,100,70,167,213,189,231,211,86,107,206,230,180,250,52,115,217,75,211,123,79,230,44,77,215,156,13,140,58,114,58,192,52,53,192,42,133,156,163,179,24,192,209,238,24,253,182,178,254,30,224,11,142,125,189,194,179,210,145,218,82,88,249,103,83,236,12,104,143,183,29,221,114,65,228,160,1,11,230,225,53,40,157,94,177,246,178,242,184,214,17,23,167,92,94,70,167,245,13,8,134,231,101,118,204,218,85,93,62,59,253,39,187,153,202,31,119,227,57,145,156,214,47,68,108,195,55,248,37,122,207,110,212,28,36,104,56,41,57,182,91,249,121,20,63,34,114,94,140,201,27,197,239,17,104,181,106,177,245,182,2,176,5,127,192,204,51,161,49,196,2,222,182,0,118,199,255,183,230,216,234,33,238,122,104,69,76,12,4,235,101,94,100,148,114,232,22,161,26,138,180,227,17,122,19,157,87,117,244,108,153,212,201,2,122,241,243,107,103,194,176,43,180,215,36,182,63,6,120,195,10,161,28,8,189,170,11,104,116,9,220,3,35,119,208,47,255,194,187,90,253,118,7,6,215,92,241,236,49,239,108,96,137,181,108,134,0,4,150,134,232,23,207,30,43,48,4,46,224,252,190,217,61,66,65,48,0,156,11,28,182,88,182,189,45,103,32,37,96,116,249,101,158,65,79,53,154,84,47,212,18,115,124,196,240,148,246,231,135,229,106,193,234,228,172,96,82,219,1,66,228,123,71,135,2,229,39,230,138,242,77,196,215,86,145,229,191,86,172,70,185,149,229,156,53,197,88,188,55,170,75,66,213,56,225,31,99,135,141,183,5,89,207,132,166,18,79,0,117,245,9,79,161,216,95,147,237,217,175,151,172,102,177,164,122,62,116,244,129,255,47,200,208,44,123,145,23,96,181,236,221,104,148,99,142,234,212,193,106,26,157,39,69,163,120,71,32,39,56,1,126,148,127,238,8,184,51,16,2,241,196,93,225,237,217,188,121,189,42,138,120,59,74,26,57,59,1,140,168,140,169,189,6,142,146,8,109,5,193,199,7,123,135,31,89,186,2,161,25,101,103,250,159,59,174,236,5,43,165,89,213,236,96,207,124,138,141,108,144,176,230,184,76,199,156,83,184,134,46,255,185,227,204,110,38,134,97,226,231,216,12,107,0,110,93,67,15,22,197,6,202,12,255,67,134,220,218,82,64,103,176,244,180,33,146,143,209,62,229,164,249,246,202,153,43,129,37,255,99,73,47,5,116,80,132,237,195,121,218,130,110,184,228,155,19,45,196,238,72,114,56,171,178,27,252,165,203,38,233,226,113,155,154,29,17,65,153,89,49,143,67,254,48,117,139,88,196,122,239,1,54,177,90,56,57,207,30,190,152,157,86,203,248,135,141,216,3,36,198,207,121,217,54,49,130,127,93,189,172,210,247,248,55,108,155,197,58,99,214,85,45,104,205,210,170,206,162,58,191,184,108,129,117,4,165,165,171,90,172,186,112,26,32,27,136,6,81,83,173,234,78,53,35,44,166,233,28,54,146,216,106,51,174,42,80,172,64,121,90,37,69,254,191,76,246,60,230,120,89,178,139,192,84,187,34,140,82,222,84,218,6,114,66,234,175,29,97,53,11,87,192,13,210,248,51,191,207,110,44,118,8,87,159,104,67,207,235,139,21,218,54,241,196,222,233,201,212,229,114,197,33,214,216,179,19,214,30,243,93,16,131,225,246,75,111,77,236,205,103,112,127,79,64,65,106,162,178,194,243,42,21,214,150,218,106,60,213,17,159,209,167,236,162,99,231,254,113,196,29,2,253,71,44,5,196,71,181,64,156,220,52,207,179,69,94,190,41,243,182,227,164,45,64,164,118,211,1,206,243,4,232,159,41,94,140,37,86,17,193,122,26,56,253,56,46,138,46,90,16,38,82,224,93,37,117,180,104,46,12,65,188,106,46,246,47,19,216,186,66,109,212,92,78,246,169,233,209,112,203,86,162,160,206,67,235,155,146,167,40,37,160,1,247,160,189,168,234,69,210,226,63,79,184,109,30,243,175,39,172,206,57,105,199,100,10,219,211,72,180,110,209,7,53,47,113,129,88,38,69,197,157,196,196,194,98,246,179,144,211,39,220,144,134,33,39,175,217,53,39,230,137,108,110,166,57,251,165,106,218,152,47,201,212,158,139,82,61,35,32,162,244,18,206,158,242,10,112,203,142,64,171,231,84,117,248,49,101,75,78,94,76,159,25,104,128,207,126,77,234,50,254,102,114,88,215,64,110,226,152,89,194,32,40,86,126,61,209,180,216,86,98,35,158,68,183,194,61,49,251,71,149,131,24,156,70,147,169,220,162,187,25,252,211,82,129,199,200,53,206,49,160,26,149,87,0,67,122,27,8,81,9,85,65,51,192,252,60,106,138,234,90,126,142,206,1,6,156,194,17,43,145,96,178,89,183,190,106,96,42,80,215,121,81,68,103,96,107,176,164,78,47,65,227,205,75,16,174,231,32,149,83,166,93,65,213,121,148,64,51,246,49,111,114,190,36,28,160,97,200,211,203,188,137,146,101,93,37,176,230,240,159,43,24,7,100,117,5,56,165,64,139,232,44,129,149,59,207,203,76,184,153,96,24,1,97,26,157,129,65,129,115,105,162,172,186,54,76,223,36,87,235,137,235,201,174,112,99,81,73,205,133,235,120,118,23,211,134,102,141,2,86,179,43,241,37,83,136,53,116,91,70,41,232,226,56,29,113,104,75,29,143,235,41,134,12,230,153,60,143,233,81,97,11,8,65,137,187,145,193,95,145,182,248,69,225,206,141,122,222,31,15,138,211,155,37,203,168,70,36,193,196,19,162,82,10,42,230,18,67,105,160,99,85,4,163,35,216,211,25,212,23,228,207,82,51,152,1,235,150,123,5,136,76,11,49,16,41,177,128,143,150,6,108,31,168,216,77,76,86,64,99,113,84,135,85,229,195,15,112,32,123,48,196,209,53,3,115,28,233,141,44,143,58,3,209,66,118,149,96,88,205,121,243,66,48,225,161,224,193,120,114,44,8,157,207,175,57,1,10,159,108,71,223,126,107,246,2,181,245,170,61,68,67,138,232,175,122,153,37,199,35,246,199,134,46,17,241,151,249,123,230,227,61,249,143,73,244,55,178,211,127,139,224,203,182,101,137,187,176,247,139,170,97,98,105,213,162,115,195,194,221,175,25,224,25,27,235,226,41,85,24,37,76,219,224,24,99,227,15,104,84,82,191,35,30,114,116,27,122,130,77,106,122,220,190,68,69,193,230,107,211,46,145,190,43,222,112,172,92,33,157,118,59,92,249,30,154,253,18,198,160,75,1,74,173,9,189,188,160,83,161,124,109,70,194,30,233,15,8,65,10,73,32,238,2,4,98,182,45,236,152,127,54,139,33,60,242,145,158,139,162,93,41,191,238,33,40,140,112,24,146,14,74,60,76,142,174,75,86,247,115,180,203,173,251,194,74,64,31,31,222,210,181,48,51,152,132,6,204,89,224,185,217,250,30,200,102,77,84,119,199,240,230,238,52,189,80,8,104,128,221,249,224,33,122,232,193,194,108,132,103,248,223,69,172,104,216,70,131,133,61,9,119,62,239,43,179,253,36,77,138,164,182,156,9,15,32,7,180,159,251,1,217,95,43,93,72,161,230,50,238,92,241,9,88,33,92,213,105,71,91,28,255,111,36,197,128,138,34,117,16,37,34,198,74,6,212,31,152,184,171,4,234,243,5,12,133,96,58,11,138,19,67,158,128,106,186,72,162,70,252,39,228,134,50,173,200,45,154,178,124,246,110,94,195,170,134,196,9,29,68,42,225,59,114,152,153,32,19,241,155,39,194,68,71,161,45,128,40,225,86,161,48,132,113,138,60,14,226,249,114,169,118,105,38,181,3,187,229,188,60,92,156,177,44,99,217,203,234,66,68,92,8,153,33,23,43,32,48,196,128,0,246,128,157,211,203,84,117,44,43,222,228,237,40,207,106,176,128,10,88,70,40,94,15,246,212,64,6,126,87,119,229,31,2,169,48,236,171,185,100,233,123,80,148,141,183,70,186,201,241,170,119,180,82,47,148,247,77,142,182,46,210,79,119,79,107,208,115,31,167,187,200,236,20,167,232,168,133,227,228,58,111,208,177,36,229,82,186,203,253,177,216,188,131,27,206,170,170,16,147,21,166,107,3,219,162,213,116,254,31,181,172,124,241,249,151,217,9,198,108,148,23,39,45,66,216,217,137,228,223,194,9,192,191,206,192,238,117,247,131,163,66,247,131,155,253,84,173,23,208,215,211,235,37,112,71,37,69,201,127,84,75,194,27,220,236,215,12,140,35,48,238,154,247,249,82,239,55,152,128,160,173,162,79,110,148,167,211,222,152,146,64,188,207,206,128,74,94,213,41,131,77,65,28,127,17,40,185,14,79,63,86,103,118,114,211,104,182,213,151,95,14,251,131,189,31,0,62,177,124,248,227,88,164,247,72,107,46,193,112,209,2,53,170,106,60,155,70,187,193,214,57,66,244,49,232,223,31,143,101,168,17,51,153,90,155,23,85,106,111,251,183,81,161,204,65,196,159,76,249,108,196,0,142,125,26,212,143,44,19,117,210,175,36,246,168,103,125,122,20,206,221,209,163,70,92,34,203,152,166,245,244,46,223,67,33,110,82,195,138,140,187,205,194,69,132,231,235,100,87,252,91,18,12,52,209,163,242,8,162,7,212,166,214,33,87,10,154,34,219,1,90,72,82,26,4,245,80,110,30,21,112,118,149,215,120,25,64,28,62,38,210,2,7,149,116,235,41,87,210,155,99,230,64,143,23,211,48,160,53,184,167,183,60,68,238,205,52,4,21,139,105,244,122,174,197,41,212,156,234,101,149,77,140,11,133,18,158,113,68,98,195,126,201,157,230,36,218,29,66,96,235,29,159,247,38,169,139,230,198,205,105,144,14,185,152,37,84,104,65,27,186,162,114,168,84,121,24,105,40,64,72,41,145,215,175,212,206,182,46,190,243,70,135,27,9,60,88,166,239,192,187,24,134,242,202,196,94,18,226,188,235,129,188,195,57,100,80,247,146,223,59,1,13,75,242,94,157,224,92,47,39,234,7,89,157,156,183,95,3,89,218,202,128,55,133,209,71,127,23,117,206,245,114,31,32,188,47,68,151,10,34,222,82,1,16,182,30,81,170,94,148,30,187,32,134,137,177,133,53,14,208,98,24,136,67,136,248,195,105,190,96,64,140,51,46,130,155,88,125,154,189,202,75,18,186,181,166,108,13,232,72,51,239,194,91,133,23,143,23,185,216,82,141,42,45,139,47,24,104,117,175,73,174,71,229,97,152,207,139,162,186,6,5,56,20,239,100,43,197,189,215,60,146,194,131,122,173,69,234,99,212,2,87,137,238,94,144,63,172,86,221,31,137,40,35,74,112,218,81,93,21,97,106,77,140,250,184,174,142,107,211,232,154,23,150,155,89,120,107,186,9,73,188,54,7,115,110,47,202,101,130,46,20,126,101,47,174,38,205,154,26,16,42,68,26,1,12,75,126,117,13,65,28,245,216,93,17,190,90,186,46,111,35,10,213,62,159,187,164,143,192,0,10,242,182,231,105,145,75,202,234,171,60,101,161,168,155,249,43,171,201,110,220,29,108,147,118,7,216,144,177,196,189,33,12,101,143,61,83,222,211,134,176,0,189,165,197,157,56,148,126,76,104,123,98,62,232,233,245,123,137,68,143,9,189,239,180,80,18,119,38,64,77,49,25,204,91,93,66,53,174,23,114,212,237,41,236,201,158,8,69,159,24,216,56,195,182,130,137,141,155,201,49,75,217,50,135,69,159,160,249,242,18,132,103,173,221,164,8,42,77,71,131,218,175,150,55,125,224,252,85,2,105,29,47,128,84,118,163,71,109,101,214,12,141,182,111,191,141,30,165,169,245,141,4,48,170,5,212,145,248,114,136,64,84,162,230,171,175,88,158,253,33,36,142,58,133,71,74,30,39,188,226,225,153,206,176,178,188,160,68,65,32,255,249,166,205,11,158,24,40,34,90,197,207,123,55,82,40,120,126,74,29,229,171,162,68,244,101,160,198,81,16,22,225,119,123,104,77,168,255,100,222,53,72,215,101,234,56,105,176,54,25,195,140,237,189,31,75,158,162,15,16,103,23,249,157,80,160,67,100,34,247,221,217,105,139,26,232,213,151,248,130,155,192,239,94,121,158,24,104,50,13,227,253,158,103,89,205,29,211,142,246,162,250,192,178,174,74,110,15,252,16,253,72,190,191,253,254,157,17,67,209,19,137,212,140,159,118,227,22,146,38,188,153,168,65,223,15,232,72,135,134,196,64,174,21,79,225,116,236,139,171,220,200,29,61,56,157,193,141,37,253,112,137,164,18,43,191,8,135,156,61,9,231,54,161,59,246,114,246,34,47,179,121,203,22,123,55,111,230,89,236,64,25,17,30,219,250,183,105,193,43,113,249,35,78,27,142,202,238,64,192,254,204,171,7,55,168,40,44,133,226,238,43,103,66,36,241,200,14,160,117,247,73,134,210,182,242,222,205,137,141,11,228,144,42,225,39,71,162,170,162,74,225,17,33,15,250,226,43,250,253,119,239,110,143,133,84,29,42,208,244,237,44,17,242,86,252,214,212,205,226,82,195,79,35,43,204,203,186,94,118,225,153,123,188,62,112,228,182,175,23,218,188,60,102,203,226,230,180,234,133,102,90,245,67,19,86,71,211,136,208,177,62,136,118,203,109,109,123,182,202,135,161,210,100,212,158,141,99,18,213,219,246,49,228,229,112,98,216,151,224,0,161,52,40,250,183,146,180,130,244,47,233,94,47,209,125,8,255,145,162,124,122,190,107,23,213,105,158,190,111,38,125,196,206,181,113,108,5,167,90,81,193,209,195,207,52,181,195,111,29,72,239,28,213,134,239,145,201,49,69,173,134,107,52,170,23,250,9,120,79,95,165,225,131,246,83,161,242,179,77,245,88,195,228,243,102,153,241,168,160,78,153,153,94,194,42,225,221,182,172,1,240,25,40,167,67,244,185,110,150,125,196,44,232,24,226,126,165,44,111,208,172,82,107,109,60,74,18,76,34,243,87,31,141,115,64,137,1,140,186,56,10,124,15,33,61,80,148,178,4,147,43,73,53,14,12,17,108,228,142,64,125,12,7,233,158,56,249,84,115,123,77,140,169,59,16,236,43,40,142,39,0,74,72,77,0,208,137,27,16,78,219,140,34,232,174,136,52,85,240,97,32,201,245,143,75,247,154,212,130,180,79,99,228,105,128,152,160,3,229,160,109,108,231,189,2,41,26,105,181,156,243,81,110,95,65,136,142,238,189,4,221,192,207,193,125,46,82,160,183,140,27,17,26,202,21,232,116,146,109,228,186,177,2,223,201,9,210,57,179,189,155,16,125,247,57,175,221,8,245,169,154,137,29,5,71,209,151,27,120,92,85,138,107,199,120,201,131,137,3,36,50,74,238,0,129,218,179,130,96,76,49,76,144,137,125,98,84,218,74,94,234,153,40,56,252,168,150,55,237,188,6,19,71,16,17,198,187,53,196,211,250,72,60,73,41,156,235,121,169,238,139,84,118,43,30,192,137,218,10,189,7,202,205,223,2,142,226,214,52,131,61,13,132,61,181,205,242,55,16,44,124,119,249,177,227,185,248,183,120,194,39,201,76,0,254,174,91,174,13,118,38,87,116,244,36,225,26,106,139,103,164,155,136,129,64,247,191,141,182,156,176,63,75,48,199,242,86,36,171,145,172,17,69,52,36,171,78,165,46,227,98,109,158,255,28,68,65,94,72,208,252,102,57,190,206,63,86,201,107,161,100,53,145,173,198,211,212,164,199,65,166,229,197,147,183,183,223,223,69,223,129,133,90,166,160,246,112,205,250,73,116,251,195,221,187,72,100,181,85,165,222,120,157,195,21,221,254,253,78,17,31,26,251,183,255,121,39,127,80,214,38,166,80,207,38,83,53,163,62,7,16,238,199,116,204,161,235,232,254,26,120,120,139,123,232,198,100,218,81,255,104,223,161,168,165,144,185,162,54,7,225,217,77,87,10,222,216,51,47,181,37,211,216,195,175,115,216,17,209,76,96,70,60,247,167,226,185,97,169,184,113,134,30,99,117,140,151,222,220,77,98,175,131,157,175,214,115,22,123,17,227,100,189,244,85,123,44,254,181,221,23,174,116,144,99,238,38,252,226,38,172,211,155,125,249,211,168,68,52,63,43,170,243,110,210,158,59,245,233,154,107,250,17,17,87,131,83,192,172,83,50,141,208,207,38,224,192,154,107,127,124,86,233,229,111,203,5,151,141,143,234,12,235,89,28,176,38,237,26,205,189,147,253,99,28,125,246,242,135,22,172,227,140,161,167,184,200,175,39,133,226,4,161,30,179,68,126,18,141,63,103,29,13,103,94,35,234,104,56,40,135,85,224,70,166,22,152,177,60,61,139,94,74,157,36,87,190,202,25,59,35,13,91,45,220,53,173,228,152,42,61,231,148,199,27,33,136,13,210,150,16,38,107,56,222,93,243,73,229,236,80,112,159,157,182,77,160,240,210,124,226,172,94,171,118,95,151,19,220,39,236,30,154,8,211,226,230,114,222,162,69,148,138,30,54,74,77,35,197,108,100,246,74,163,52,121,3,100,118,40,127,18,125,58,235,17,166,180,30,161,15,133,102,216,8,72,131,5,104,20,78,235,151,159,217,76,70,110,121,81,193,88,88,39,40,198,148,154,137,98,149,78,220,114,0,210,232,98,176,16,55,19,191,174,252,85,2,88,92,187,155,161,177,114,216,192,18,17,124,58,240,15,88,175,221,8,88,243,198,45,50,240,167,20,179,174,193,26,115,29,167,140,103,254,193,26,252,12,54,242,189,171,212,155,35,109,77,112,20,90,32,8,32,116,250,244,122,201,65,76,251,2,182,173,140,62,188,190,176,205,91,182,104,186,131,245,31,86,122,117,59,198,131,7,208,224,121,173,139,237,60,100,166,161,209,176,28,5,200,141,75,205,189,29,212,178,75,147,128,19,126,176,86,134,162,21,99,106,229,254,89,225,246,138,216,168,13,108,144,6,193,192,201,245,151,36,175,187,37,104,104,46,84,130,18,14,177,177,234,118,192,80,54,7,36,182,131,188,110,20,59,247,34,192,233,110,113,248,204,230,115,35,34,204,63,12,88,160,172,216,53,211,183,250,172,244,110,51,93,143,167,236,117,216,188,130,245,25,234,134,63,184,133,14,6,187,70,204,216,229,35,12,243,113,161,40,167,136,14,177,201,205,42,244,219,223,129,234,105,99,10,223,184,101,206,120,38,55,175,152,39,166,171,220,16,194,9,45,170,212,72,135,181,252,233,59,100,168,18,57,233,187,26,189,246,223,129,44,147,206,234,250,243,120,171,61,88,31,236,130,109,163,107,185,245,128,20,5,229,100,150,209,238,137,88,135,44,175,229,110,71,96,193,149,24,98,223,170,32,124,167,2,157,90,211,148,175,59,88,228,106,148,107,217,209,196,230,139,242,155,186,224,141,211,115,148,242,170,183,210,174,83,59,180,177,131,1,26,162,184,98,176,168,162,125,21,234,84,192,179,55,100,42,194,173,233,146,58,33,93,2,209,125,170,83,209,214,209,143,244,126,61,122,66,239,199,173,203,40,142,77,47,24,211,17,193,24,160,79,125,116,148,202,52,236,96,115,134,181,67,139,236,181,80,54,189,174,178,227,78,189,199,209,65,208,178,235,103,132,96,224,253,23,7,243,98,85,166,170,192,196,190,82,84,129,76,98,26,193,4,146,197,250,109,130,201,16,160,43,171,97,186,198,177,75,213,40,207,8,41,116,51,168,31,245,9,166,166,170,91,161,108,43,194,26,184,58,147,49,161,163,171,50,127,122,169,228,11,163,181,227,51,59,152,219,91,156,241,220,172,130,167,5,132,16,43,11,170,165,102,163,32,227,164,81,229,235,254,165,254,86,7,245,131,230,68,152,17,245,214,211,97,213,199,216,254,19,7,18,169,54,90,51,120,201,206,219,195,143,203,90,120,191,109,32,136,144,249,173,47,75,66,86,208,179,49,154,241,170,18,6,128,48,112,52,252,96,242,4,133,3,107,135,61,240,36,193,72,181,216,21,154,30,255,255,224,247,63,132,67,196,154,158,215,233,239,1,105,164,92,138,49,255,239,129,58,213,176,202,32,214,169,105,82,198,95,162,152,246,44,150,70,97,123,100,160,80,39,207,58,7,103,206,117,116,126,74,125,190,236,35,81,15,153,159,233,88,64,15,31,242,136,218,75,94,81,3,115,189,65,145,197,208,52,248,148,180,209,193,94,4,242,170,53,30,122,62,152,115,115,249,219,30,44,205,111,167,208,142,87,29,88,45,209,226,195,240,0,50,39,187,12,115,87,204,157,27,249,16,186,121,231,142,91,126,57,204,175,8,101,8,221,33,175,169,163,194,186,172,144,178,238,75,83,206,197,98,75,68,245,24,248,155,4,185,122,193,35,63,43,167,232,166,177,31,14,164,64,77,12,141,109,176,202,180,44,152,217,87,115,87,106,204,82,9,80,147,211,151,2,195,53,163,17,204,148,231,2,122,158,246,173,16,56,71,190,74,88,118,203,110,72,90,107,153,135,19,92,173,250,209,38,88,64,245,9,199,190,132,3,183,220,251,118,131,228,216,130,154,253,188,77,152,58,241,138,52,195,71,84,76,29,245,247,107,100,126,43,164,232,129,88,63,20,172,180,49,239,211,224,212,110,222,247,171,224,146,242,229,93,229,224,221,248,24,93,15,124,76,144,11,30,243,138,226,196,132,229,9,45,254,8,196,67,116,93,27,110,57,101,175,143,171,107,82,247,90,181,193,168,226,0,209,123,135,102,231,5,120,199,5,158,11,160,209,203,32,242,37,197,116,196,204,237,249,234,248,132,209,9,235,3,113,99,159,249,137,4,43,63,210,22,229,162,236,199,62,193,106,168,188,135,157,211,110,205,71,86,136,123,128,180,246,0,155,216,10,112,248,136,163,5,64,238,113,8,134,160,90,10,218,240,121,56,72,40,61,229,56,104,32,162,14,200,27,231,128,30,184,51,235,131,218,243,4,198,177,219,13,235,121,227,251,38,121,9,187,119,118,227,95,248,237,107,184,56,108,81,85,239,87,75,239,81,11,181,253,67,247,99,125,145,136,244,206,172,249,160,238,201,8,16,174,143,120,65,122,1,143,53,202,45,137,187,174,250,110,162,82,221,106,118,156,188,165,63,112,63,1,56,104,29,72,119,134,7,71,98,59,161,102,138,117,69,245,102,158,201,190,48,9,180,55,212,53,252,190,250,25,43,206,234,235,42,203,43,175,47,186,31,216,59,143,152,8,149,75,216,76,248,183,240,3,136,175,86,88,90,19,191,144,110,135,5,200,141,188,161,102,30,207,107,104,40,22,56,31,229,75,181,209,159,189,49,6,152,75,73,122,166,102,110,141,92,49,76,0,118,90,119,184,254,157,218,16,4,212,76,198,156,164,228,245,162,221,48,146,114,63,121,254,146,200,93,74,173,248,207,94,199,189,220,235,109,253,208,131,188,224,217,209,213,17,30,201,50,23,35,108,182,222,7,2,144,21,254,8,201,78,157,118,83,153,161,39,94,21,253,239,83,156,176,110,13,182,127,77,230,58,156,122,244,160,222,14,25,44,75,42,232,244,2,20,85,21,194,37,119,56,94,60,211,120,4,74,50,103,215,198,66,41,70,101,90,45,80,140,236,68,143,16,158,42,97,66,114,75,131,253,70,134,106,7,158,97,144,18,86,254,162,12,28,210,224,173,51,229,119,208,195,90,181,96,15,103,62,178,151,243,181,175,39,71,222,238,198,63,5,250,132,246,248,157,41,42,160,210,113,241,72,225,175,23,136,117,66,74,197,226,137,148,2,49,236,194,211,173,197,179,28,207,75,59,57,194,125,225,194,122,217,66,60,146,48,210,152,163,133,122,9,55,130,44,202,155,75,224,18,19,70,234,187,35,189,180,85,29,111,186,70,198,170,238,179,139,99,93,214,85,169,162,231,229,79,3,9,170,93,121,12,104,225,123,115,48,25,196,114,84,42,25,70,133,222,31,73,115,136,60,162,11,231,186,216,151,111,191,141,98,222,73,142,38,85,77,50,216,239,191,139,148,102,254,65,217,120,34,28,129,180,218,217,137,190,239,19,68,252,226,115,94,158,87,227,195,147,229,144,248,64,4,95,147,105,20,88,29,93,23,244,76,188,14,145,173,21,148,108,38,32,105,143,92,116,91,42,134,194,65,142,186,142,166,161,140,186,128,194,17,162,88,229,6,146,103,129,51,48,234,93,33,84,70,221,249,59,61,253,2,197,164,166,153,215,184,167,184,112,160,169,157,119,231,100,127,154,85,239,2,64,47,214,55,160,156,16,157,112,226,152,154,202,192,79,240,202,124,51,98,153,186,123,208,243,48,68,111,212,254,189,130,246,97,66,40,22,2,115,221,144,5,200,173,125,11,50,237,154,178,239,72,163,63,111,244,210,112,220,67,162,113,80,12,175,89,101,253,222,210,184,207,184,31,156,205,131,217,251,142,252,237,144,249,155,214,230,244,31,83,144,49,223,65,17,36,26,72,231,145,147,149,209,125,239,75,132,233,58,197,183,164,159,216,242,7,143,246,29,104,127,108,202,3,230,80,231,191,63,1,126,25,202,123,181,254,84,6,201,43,47,219,238,195,251,254,36,102,211,22,191,193,23,176,189,52,126,74,114,29,190,209,207,69,111,176,38,164,214,155,16,109,189,52,198,93,61,213,121,212,83,152,196,127,240,109,198,203,235,224,173,55,143,161,213,113,53,244,249,46,128,41,212,235,235,203,28,142,8,172,96,132,239,46,171,215,9,71,86,247,212,111,103,73,237,253,11,86,251,124,185,201,74,13,44,131,26,100,211,213,24,44,238,18,122,81,86,26,72,220,226,225,38,206,87,246,34,163,32,127,251,97,70,101,193,161,215,234,240,227,178,200,211,188,149,239,77,122,211,26,45,127,55,226,13,237,154,17,129,190,194,123,163,44,202,207,93,203,115,51,154,13,205,64,226,191,17,193,117,218,214,33,151,16,218,229,53,107,86,133,18,207,36,249,225,214,51,73,168,202,55,207,162,187,79,16,6,227,214,86,52,7,57,86,181,115,75,245,147,56,19,167,32,152,152,212,12,214,29,204,222,16,27,74,127,23,73,130,163,74,170,5,101,220,61,85,232,173,5,237,32,116,68,9,62,118,136,47,18,226,35,20,172,204,200,254,243,2,116,148,8,62,255,211,223,68,109,21,161,155,15,50,41,53,142,61,183,117,95,223,232,82,122,131,46,205,79,94,199,118,163,103,11,181,254,140,248,254,202,206,26,238,202,162,136,127,109,181,108,135,235,218,220,47,229,89,82,54,39,231,53,158,223,244,171,26,57,121,196,157,62,242,123,85,161,8,223,249,155,135,35,101,153,190,159,240,113,99,245,205,243,123,218,205,71,71,22,216,137,193,50,134,33,80,250,98,234,224,35,71,230,78,132,3,118,182,186,136,191,153,188,189,29,178,248,239,222,185,59,203,15,179,73,244,55,129,227,55,147,195,87,7,248,117,39,186,237,138,47,184,67,177,121,107,227,125,167,248,75,70,132,140,152,192,212,153,250,26,87,198,221,210,237,92,61,205,202,191,89,15,179,138,71,152,63,45,253,90,82,249,120,24,155,46,89,25,122,201,213,166,190,16,35,72,155,206,44,243,184,136,55,90,99,46,28,63,247,101,139,47,89,149,74,61,166,116,107,153,198,65,150,12,199,155,57,44,251,60,203,142,147,18,102,112,142,109,133,43,198,52,81,158,92,196,46,73,65,128,239,62,195,252,246,221,233,51,19,222,115,2,138,117,203,67,123,82,208,118,222,190,139,110,255,26,253,117,10,255,255,215,187,105,36,222,199,230,77,142,150,226,44,61,102,139,234,138,113,180,96,67,49,51,101,91,93,195,214,120,33,90,207,78,129,253,0,99,203,29,186,22,187,19,106,176,56,125,13,86,55,32,238,120,236,29,82,244,173,179,118,220,242,191,163,20,62,177,180,179,17,149,175,214,159,91,146,101,132,72,111,245,63,239,232,44,81,185,113,22,97,196,196,181,39,222,167,17,74,30,122,72,111,178,3,229,194,54,155,172,97,165,91,253,207,207,55,89,61,100,88,239,166,93,239,47,203,191,140,2,226,193,169,201,251,223,163,4,122,199,97,32,16,233,174,232,50,80,245,190,91,11,26,251,236,119,80,215,208,226,120,222,16,122,120,89,37,25,11,188,249,44,47,13,183,126,28,214,192,195,207,123,111,61,241,66,181,69,238,51,109,220,37,170,57,149,217,77,93,93,74,43,246,93,239,165,123,138,136,164,100,111,97,6,159,177,13,35,100,91,191,63,186,11,46,167,255,154,93,227,127,191,94,53,253,193,185,164,175,90,210,16,231,116,90,15,65,85,116,29,214,145,143,73,56,106,170,164,200,112,172,186,67,247,97,29,55,192,139,247,139,43,30,17,86,44,162,138,61,244,6,235,20,217,54,171,85,244,46,20,81,76,56,203,122,62,158,118,12,166,227,121,173,72,114,160,239,251,167,73,129,94,236,114,104,101,103,123,171,188,200,12,162,207,27,149,56,105,30,79,90,255,72,14,81,152,72,94,2,189,233,73,244,223,37,177,171,110,131,104,225,245,204,135,226,148,125,132,37,209,199,112,176,101,48,4,123,248,245,199,213,89,145,167,235,101,54,246,249,160,68,50,4,125,121,33,47,215,189,122,248,130,207,220,172,113,33,231,132,23,245,45,10,191,255,197,136,69,253,234,105,111,63,125,25,52,98,77,163,164,192,219,144,27,117,43,238,40,10,124,119,181,103,77,202,54,25,12,66,6,30,251,74,142,122,255,214,7,96,122,234,78,211,145,65,154,255,166,176,158,65,188,178,247,121,201,218,161,218,247,254,85,116,114,197,38,187,24,55,227,70,197,245,175,116,145,92,252,155,1,4,45,15,151,73,151,81,53,220,125,141,11,46,207,142,238,183,5,123,106,100,208,0,111,253,194,188,122,197,201,122,30,208,240,168,209,151,101,135,240,99,128,238,123,174,230,141,247,53,95,25,87,73,150,109,158,230,203,164,108,69,56,45,141,19,53,62,78,80,117,73,200,45,234,185,221,15,105,249,115,234,208,165,142,174,75,86,115,45,101,220,3,51,189,192,100,20,241,212,159,81,127,63,82,26,114,74,182,183,191,147,29,1,172,194,177,186,222,30,255,253,247,254,42,44,225,72,106,29,97,198,138,134,69,67,239,155,249,239,128,173,247,6,17,168,31,109,13,93,120,111,231,117,26,235,133,50,158,131,98,46,239,224,111,250,36,152,204,79,245,251,49,242,170,217,225,90,9,13,91,244,102,72,67,51,37,180,190,7,218,52,70,39,144,166,110,131,143,229,116,177,166,225,157,71,125,203,26,222,254,208,25,225,83,189,46,228,174,30,44,145,54,137,245,180,133,120,122,9,164,141,59,36,137,145,244,43,127,13,158,201,99,79,8,180,181,202,134,137,26,14,236,10,229,243,101,82,102,197,154,22,230,189,227,76,28,57,207,205,187,163,210,237,62,87,168,14,5,108,104,153,56,242,229,215,224,109,222,232,2,233,222,72,107,10,98,100,19,55,239,162,71,150,116,62,218,28,142,243,144,20,101,225,215,47,206,108,100,44,34,12,191,65,177,126,128,201,218,244,137,206,134,175,131,60,157,199,90,191,122,234,244,106,64,247,5,21,245,20,252,239,236,225,166,73,117,180,147,7,97,23,86,67,195,140,168,33,128,185,102,157,129,192,165,34,192,112,124,169,21,213,184,206,235,104,180,223,166,249,38,1,234,228,9,57,6,184,138,3,214,97,161,116,92,181,213,93,9,42,86,219,241,177,187,82,191,215,188,140,105,180,94,88,174,214,28,164,206,129,44,40,170,195,140,93,65,31,196,8,115,142,62,39,136,23,47,216,79,87,196,231,137,158,253,6,89,126,81,86,181,100,133,201,238,156,255,37,29,67,42,188,179,215,246,234,40,32,28,42,205,20,48,135,188,46,174,66,230,61,81,41,151,70,214,64,163,216,171,188,16,122,141,160,244,180,147,127,221,51,223,184,39,78,199,140,97,37,225,146,207,130,209,215,205,200,149,101,109,101,97,114,135,50,166,129,53,217,246,17,146,74,35,169,57,4,210,246,121,113,157,220,52,186,192,138,113,43,242,203,64,178,162,90,114,18,136,125,185,56,142,96,211,133,91,68,91,185,56,100,97,250,205,37,71,253,84,249,252,186,247,32,255,2,2,134,121,129,152,219,75,83,13,176,173,244,47,107,49,41,107,62,4,92,53,221,52,223,119,123,96,230,138,18,115,223,242,42,244,203,71,153,132,23,92,94,159,165,0,103,117,63,64,135,164,124,34,150,229,167,186,90,45,187,24,69,209,168,54,114,56,216,151,213,69,158,38,197,209,146,137,124,61,89,243,234,168,54,86,192,253,146,209,77,128,235,212,65,95,208,134,32,145,121,7,186,152,234,15,74,160,8,232,196,229,18,159,69,46,186,244,231,111,138,220,92,130,157,88,166,34,89,73,46,6,252,193,59,146,246,73,199,62,199,185,248,106,127,132,111,244,255,254,15,203,147,158,86,84,177,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("240b9c1d-cca6-4a06-b885-11b14d6a1945"));
		}

		#endregion

	}

	#endregion

}


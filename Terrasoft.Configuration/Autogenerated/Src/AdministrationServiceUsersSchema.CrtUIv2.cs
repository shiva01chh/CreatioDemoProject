﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AdministrationServiceUsersSchema

	/// <exclude/>
	public class AdministrationServiceUsersSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AdministrationServiceUsersSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AdministrationServiceUsersSchema(AdministrationServiceUsersSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fdb74e46-7da8-408c-8b1e-76c9dc575c49");
			Name = "AdministrationServiceUsers";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ee2cfe-a059-4eed-92fa-2b7fd54ad54c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,93,221,115,219,54,18,127,118,103,250,63,32,202,76,135,154,81,152,164,233,220,228,82,219,25,59,118,114,186,203,135,47,178,155,135,78,31,104,10,178,217,80,164,66,80,182,117,109,254,247,195,226,251,139,20,101,203,182,210,105,30,18,137,4,22,139,5,246,135,221,213,46,82,36,83,76,102,73,138,209,49,174,170,132,148,147,58,126,85,22,147,236,108,94,37,117,86,22,223,127,247,199,247,223,109,205,73,86,156,161,209,130,212,120,250,179,243,157,182,207,115,156,66,99,18,191,193,5,174,178,212,107,115,144,212,137,247,240,109,86,124,241,30,142,112,58,175,178,122,17,120,81,93,100,41,126,87,142,113,222,250,50,254,132,79,117,3,115,94,211,105,89,52,191,137,255,77,154,94,87,184,233,121,124,176,223,248,234,176,168,179,58,195,36,212,224,253,60,179,153,62,188,170,113,65,64,136,186,249,123,124,89,211,7,208,190,141,55,214,183,42,146,252,132,224,42,56,26,107,245,58,73,235,178,226,252,208,54,15,43,124,70,135,67,175,242,132,144,23,104,111,60,205,138,140,212,124,217,5,107,180,217,108,126,154,103,41,154,37,85,157,37,57,74,161,117,99,99,216,43,138,240,235,12,231,99,74,249,168,202,46,146,26,179,65,183,30,63,126,140,182,201,124,58,77,170,197,174,124,240,144,255,145,255,26,31,145,253,173,247,203,37,93,112,54,250,73,145,213,189,216,164,128,30,33,147,136,75,117,160,223,132,27,42,98,219,143,77,6,103,156,125,116,144,177,61,78,31,111,211,137,83,249,14,80,121,250,59,221,248,187,40,61,79,138,51,60,254,37,201,231,82,186,173,19,53,198,69,15,93,54,228,159,37,236,84,56,25,151,69,190,64,111,230,217,24,17,33,21,242,177,204,241,112,140,118,80,129,47,217,171,168,247,252,89,242,211,51,124,154,62,154,60,251,199,233,163,167,63,61,125,242,232,199,127,62,31,63,122,242,228,41,126,158,62,255,241,52,77,198,189,190,96,251,33,46,198,109,235,39,23,247,29,174,207,75,235,109,167,181,69,198,90,210,149,132,13,59,44,128,231,30,122,24,220,0,102,175,6,137,176,39,116,127,38,83,84,80,56,219,233,205,129,234,184,183,235,75,91,201,118,251,49,235,16,238,95,49,25,134,250,91,253,228,74,92,148,116,1,246,198,99,61,153,136,111,12,196,25,145,251,4,113,186,125,196,180,100,235,45,213,159,109,185,131,114,250,133,105,175,88,57,243,101,4,107,67,59,168,54,49,29,44,226,180,197,43,49,58,17,195,171,150,3,57,38,107,246,181,211,206,12,126,236,184,57,217,147,10,215,243,170,32,187,33,58,238,46,160,2,149,205,77,145,102,69,141,222,224,90,234,58,121,85,206,139,58,146,146,187,72,42,216,240,90,222,255,157,227,106,33,36,199,64,119,49,74,207,241,52,97,207,35,104,71,207,180,130,159,81,177,217,224,93,82,36,103,184,26,184,155,81,136,213,163,69,143,186,249,180,64,41,176,35,62,239,4,88,129,5,226,175,163,222,112,44,169,25,189,226,17,23,218,241,98,134,41,133,189,179,51,170,86,12,75,225,73,204,166,203,59,13,61,30,94,103,57,69,251,33,61,245,216,226,242,175,97,54,94,81,144,168,69,139,79,89,125,126,4,123,23,211,47,36,98,196,183,248,43,122,252,209,93,157,17,49,250,225,151,121,146,115,145,48,97,12,92,116,17,243,9,12,200,233,241,13,170,153,179,164,137,196,126,9,115,12,139,206,223,243,214,206,226,9,74,124,203,40,74,15,232,202,207,243,28,189,148,79,128,12,76,69,44,2,195,229,109,186,167,118,35,115,13,222,83,89,244,209,11,244,196,85,14,181,79,7,10,181,130,120,212,73,65,196,203,1,242,78,28,244,234,28,167,159,95,37,197,71,60,45,47,48,204,244,117,85,78,65,24,10,12,225,175,120,21,229,11,225,96,35,104,73,6,14,112,78,119,5,48,16,177,211,68,96,203,223,234,102,171,27,136,229,86,213,13,8,82,117,179,160,253,219,5,0,45,174,123,7,140,108,130,34,23,45,126,248,225,58,112,177,139,158,72,189,216,106,214,223,40,44,176,175,157,79,225,129,137,21,14,246,132,0,199,129,8,101,243,42,194,10,77,144,69,221,62,238,183,9,198,40,173,240,100,167,39,221,176,195,171,20,207,64,146,189,199,187,93,113,231,58,246,83,139,44,25,36,217,182,19,172,39,127,2,203,233,10,91,174,15,63,38,12,209,179,126,33,187,98,103,7,61,85,221,234,243,170,188,100,224,230,9,33,98,182,89,153,38,121,246,191,228,52,199,35,230,8,184,144,247,169,172,62,51,167,58,254,136,73,57,175,82,218,174,172,40,242,13,248,0,91,189,160,255,196,44,182,158,106,227,13,67,98,42,159,162,172,185,136,222,38,220,198,3,49,169,249,40,70,223,97,66,232,128,49,219,203,189,254,138,251,239,70,198,250,170,214,122,133,211,178,26,183,217,235,226,99,187,209,126,31,70,255,43,230,247,249,118,191,156,146,99,249,171,175,246,249,106,2,60,170,217,122,243,207,59,104,249,89,10,216,53,44,72,157,20,41,222,95,0,70,69,109,135,171,13,161,116,4,99,60,113,90,44,197,81,147,66,252,26,215,233,57,236,193,131,253,72,78,187,175,84,201,100,88,28,224,115,70,87,156,229,214,232,236,33,132,144,106,103,34,114,10,33,114,32,217,21,200,153,18,177,207,163,120,132,107,3,255,35,205,103,108,60,6,66,206,1,221,78,70,243,231,147,49,125,51,143,76,114,129,163,77,86,91,46,3,34,21,198,119,241,110,87,245,28,143,215,114,166,5,107,13,126,247,221,168,219,164,164,202,148,158,35,59,20,64,29,91,201,157,163,35,55,84,204,173,182,232,84,89,140,51,22,158,21,54,123,75,91,193,211,214,31,190,61,138,190,14,172,151,194,52,20,199,48,63,95,183,190,10,118,0,40,30,52,35,133,102,73,99,133,175,71,7,120,98,232,12,145,234,176,118,88,89,55,174,172,11,88,214,133,44,45,208,34,236,162,155,33,204,235,121,145,50,211,171,248,80,157,49,73,116,5,145,146,183,247,148,63,164,254,94,231,137,28,214,235,189,28,59,60,150,165,158,42,142,20,122,232,97,110,19,65,124,25,122,231,182,215,100,101,148,88,47,72,80,24,144,44,81,28,208,98,82,64,65,27,200,201,12,180,96,5,84,124,213,22,197,131,208,228,150,226,69,176,83,11,106,4,148,92,242,220,85,209,213,116,91,104,138,121,118,37,233,172,118,227,172,76,205,183,217,246,181,223,216,177,43,80,181,24,247,137,170,245,107,167,185,138,217,194,29,25,6,122,104,66,23,26,37,212,45,7,232,34,171,70,184,96,183,163,225,184,89,229,181,91,57,44,246,242,28,120,37,81,208,26,103,209,46,29,108,185,133,48,151,65,29,226,30,148,29,115,3,169,13,187,66,40,202,32,216,18,241,185,78,244,201,36,221,26,219,225,204,234,159,130,41,160,168,143,54,135,116,243,187,141,195,104,5,43,193,15,50,192,36,77,143,110,92,248,20,93,161,157,93,105,95,245,175,130,65,28,8,29,236,170,3,26,98,131,253,248,184,4,99,49,50,60,26,49,8,143,3,90,17,30,115,219,240,61,35,127,210,17,125,174,103,161,171,47,13,97,228,187,253,161,107,137,13,223,78,226,140,74,184,131,19,96,252,222,211,65,67,3,234,57,176,126,18,147,226,23,79,217,50,35,198,10,226,209,61,185,130,94,4,7,225,43,209,164,33,230,252,13,40,191,29,245,93,143,242,91,214,60,249,22,32,200,11,23,223,39,86,41,119,79,152,107,152,255,147,153,180,21,242,232,72,35,221,98,210,251,105,9,128,114,98,93,1,78,26,253,162,23,255,109,71,251,78,0,120,92,83,30,216,170,66,255,176,231,76,102,157,134,60,225,240,163,135,148,78,32,74,147,26,132,17,208,62,61,26,83,68,236,187,33,140,67,250,210,101,143,135,101,241,213,13,16,119,13,144,43,99,92,75,49,239,222,96,211,198,73,201,174,143,148,127,105,136,164,50,130,53,228,93,214,136,82,194,244,53,232,124,44,203,90,152,247,71,230,160,177,240,196,229,2,44,1,169,0,195,127,163,85,0,145,44,25,51,170,42,146,241,23,70,157,96,176,245,6,182,221,157,131,19,9,162,147,10,212,118,179,237,228,162,116,143,173,46,181,223,7,130,242,13,150,119,125,198,122,163,28,219,243,51,172,112,84,34,115,35,111,24,146,114,18,45,237,96,148,26,68,124,223,113,135,237,248,83,146,67,199,10,249,136,57,170,165,4,111,112,204,228,32,3,84,28,42,28,226,66,205,99,160,226,133,230,229,203,79,231,184,194,150,9,19,15,9,3,248,72,128,183,58,13,20,31,2,50,56,11,241,225,21,5,25,3,168,220,153,216,56,214,33,18,194,18,154,234,106,142,17,21,12,139,136,164,106,82,168,134,188,149,140,32,150,93,157,228,93,119,156,166,0,72,44,162,36,46,217,39,232,145,164,59,64,79,233,151,209,232,200,135,7,153,164,215,145,195,1,154,36,57,193,148,90,89,83,89,55,100,249,157,150,101,142,134,196,94,65,96,85,80,137,32,13,208,158,132,220,14,34,3,204,126,201,207,104,18,65,191,62,80,101,15,5,177,229,41,144,98,17,232,204,233,89,195,0,2,157,46,130,51,189,199,5,96,36,24,111,44,220,21,18,43,131,8,170,210,71,108,34,176,243,247,23,182,124,151,11,182,109,85,220,142,47,185,10,236,39,4,211,14,164,166,231,117,158,31,78,103,121,185,160,192,111,194,200,9,69,233,23,200,104,120,84,86,181,72,91,119,218,117,92,45,130,146,170,74,22,168,156,72,147,15,76,24,136,188,94,176,232,47,143,43,78,132,161,213,113,217,38,194,254,131,50,8,122,14,142,112,149,65,38,6,30,75,66,32,59,250,174,121,149,246,90,153,106,89,183,95,127,67,67,42,221,138,46,31,135,38,18,241,232,59,178,152,162,171,133,116,180,146,133,195,4,42,182,84,24,64,13,6,237,95,87,73,90,139,24,26,55,225,229,97,169,44,89,56,2,40,189,158,117,4,112,36,51,163,246,140,49,138,156,239,169,193,244,161,162,43,78,177,222,102,211,66,111,41,188,29,1,195,80,210,64,27,94,224,170,166,120,73,164,148,63,176,67,125,187,235,68,132,17,189,235,140,44,131,212,108,154,178,17,157,147,96,194,76,10,2,222,48,249,2,198,52,111,189,63,207,242,241,33,249,18,62,184,104,83,203,114,135,239,55,113,38,44,41,195,91,158,179,51,240,11,77,98,183,101,12,12,246,155,252,4,44,202,79,192,224,165,60,118,246,14,4,4,200,238,86,184,245,42,100,128,83,87,129,109,248,104,57,198,210,14,217,24,54,59,131,213,89,66,200,37,117,143,86,49,161,96,111,10,36,133,135,205,198,167,28,10,154,30,137,129,164,50,73,66,114,127,90,5,28,241,113,181,160,194,226,191,138,244,204,238,240,51,214,188,54,179,120,196,27,223,29,1,13,9,55,128,100,51,203,197,240,211,212,4,151,21,38,243,28,20,91,78,69,77,67,242,63,64,98,70,253,165,204,112,98,160,173,101,205,85,181,223,41,227,141,247,11,24,50,65,97,31,78,147,44,63,40,233,223,133,148,53,134,71,230,175,43,88,183,17,221,74,112,206,89,29,18,175,81,98,222,227,246,208,44,107,58,12,116,218,53,131,248,15,66,100,233,116,217,103,163,247,235,178,50,233,70,156,189,111,32,249,207,152,195,144,80,218,244,113,90,227,241,135,2,126,115,91,33,241,47,184,110,0,167,84,244,198,24,36,26,142,232,34,240,69,220,229,139,70,238,107,25,71,231,229,60,31,7,54,153,187,154,253,22,173,186,241,46,33,223,194,54,129,90,198,121,145,165,172,215,7,198,209,186,119,142,80,108,56,80,128,114,196,236,248,140,188,199,151,3,164,211,21,212,73,37,133,102,226,129,177,224,45,216,203,200,11,208,101,191,6,114,44,82,171,192,72,209,61,199,198,70,66,40,47,5,127,49,67,57,241,240,133,197,81,48,56,37,118,186,28,85,206,31,97,112,100,156,1,57,35,47,233,193,39,86,215,148,150,58,64,213,68,29,249,89,138,245,6,126,133,215,202,71,186,74,147,89,249,41,239,41,204,229,165,242,20,3,181,72,20,40,176,177,117,196,76,204,70,199,131,101,152,95,13,142,118,150,75,87,132,254,94,201,62,97,249,154,36,85,1,163,56,185,180,172,45,97,51,40,50,84,85,140,240,47,156,207,240,114,60,178,90,43,32,146,11,216,212,48,118,23,141,57,88,156,243,72,205,97,192,252,249,126,104,7,8,207,215,130,152,142,235,46,253,90,199,127,235,188,1,76,135,180,121,31,216,196,165,138,41,13,115,157,235,238,90,38,123,238,122,204,4,55,196,97,49,159,194,20,168,65,77,176,191,19,248,4,28,135,52,160,138,238,116,118,244,12,168,183,109,174,144,174,127,109,172,119,45,107,12,240,185,44,72,24,8,250,234,23,162,2,172,103,62,237,33,81,152,129,12,74,200,39,49,176,71,64,110,72,246,58,101,26,3,35,165,207,30,49,192,128,99,115,11,121,112,131,2,142,20,182,157,131,185,183,122,143,131,43,6,33,34,190,88,162,241,204,243,45,126,94,102,158,15,165,81,238,247,237,47,237,60,90,20,41,61,200,11,234,117,130,215,246,246,96,239,200,54,241,51,18,104,18,168,86,19,191,160,220,102,204,21,203,80,171,57,84,151,56,171,144,246,3,236,199,88,27,101,230,184,73,234,136,125,201,75,167,94,40,183,67,255,216,99,166,146,245,152,147,102,88,117,14,212,9,148,227,157,237,32,129,60,97,149,113,97,183,21,39,80,200,221,224,134,188,104,96,29,177,169,9,213,156,182,125,228,6,199,0,190,173,158,220,119,50,131,29,70,242,114,155,33,109,81,9,36,222,138,83,55,176,213,164,175,136,254,252,19,61,96,39,68,63,188,37,37,31,65,167,87,121,187,174,53,108,159,244,98,45,155,83,40,121,71,245,235,203,127,240,130,189,63,74,178,202,203,17,205,224,87,88,248,65,209,212,190,182,186,144,84,38,76,218,251,219,203,152,4,194,49,29,90,202,81,104,106,106,58,216,108,244,216,0,16,54,219,136,183,97,225,35,246,238,88,4,173,233,3,124,156,77,177,245,162,15,5,130,145,38,164,126,25,212,107,110,143,9,189,161,227,73,157,229,60,112,194,222,236,17,120,184,45,199,216,53,72,218,91,193,144,191,169,75,105,67,62,102,234,41,45,39,35,169,24,137,152,254,82,219,183,21,52,254,180,234,36,146,155,190,128,113,79,68,232,104,12,31,157,236,42,145,46,229,143,250,208,137,229,199,96,133,227,202,121,230,228,118,18,205,205,112,238,175,31,168,133,200,188,47,25,163,252,141,61,254,132,79,135,197,69,249,25,71,92,32,16,96,61,250,48,58,166,39,206,73,149,29,227,233,44,79,216,143,91,189,80,126,58,117,250,208,126,57,94,140,234,5,75,252,166,212,132,195,166,158,198,159,170,100,70,205,45,238,29,126,196,95,168,198,213,212,145,157,38,181,213,129,63,98,55,202,12,16,117,7,103,101,65,112,123,187,62,155,130,184,10,70,28,14,65,46,101,208,71,11,124,32,219,251,121,244,210,33,172,170,178,18,99,130,43,97,120,111,124,223,5,126,29,134,71,180,45,240,102,198,142,183,205,166,187,145,230,66,236,96,35,133,193,57,162,15,246,149,35,95,156,101,5,142,101,134,131,248,165,79,45,42,181,91,147,130,31,226,182,135,174,82,184,21,64,234,4,86,64,66,205,184,70,144,96,37,130,44,22,244,211,184,197,153,33,19,29,66,9,14,142,48,113,44,62,135,252,83,163,233,210,192,109,64,53,61,109,68,166,198,222,113,9,72,131,98,47,43,76,107,76,165,176,46,49,49,250,12,172,66,106,255,141,51,236,109,98,3,209,181,34,27,140,13,154,75,15,27,2,208,64,238,12,27,204,49,191,33,112,48,132,87,109,40,54,168,47,215,240,70,73,55,119,244,161,210,174,53,87,132,111,176,218,195,158,220,88,75,64,49,39,149,188,114,78,127,59,101,233,214,181,187,218,116,205,54,204,111,59,37,109,115,244,217,170,22,191,86,202,219,239,116,145,248,207,249,29,78,103,71,225,189,171,254,58,151,144,95,63,150,181,209,16,112,50,3,199,254,67,197,67,62,162,82,98,179,128,192,103,81,194,129,222,9,10,17,236,200,96,87,68,176,226,9,33,28,104,174,91,221,141,52,23,119,9,12,42,36,106,59,211,155,115,82,95,239,168,94,251,73,125,77,19,126,16,128,45,247,163,31,35,255,102,212,222,190,232,98,227,84,222,185,135,195,210,109,231,240,191,153,109,207,105,116,59,253,229,120,119,168,228,142,28,52,183,110,12,237,254,213,254,90,71,249,154,110,105,186,37,232,248,107,24,249,242,160,216,84,93,119,248,83,202,174,110,187,106,211,254,85,149,255,78,180,150,221,103,21,74,99,245,175,178,234,102,180,91,63,94,111,121,247,131,105,81,73,25,89,165,174,27,98,244,91,138,116,125,39,222,87,200,240,65,110,28,224,45,103,184,221,247,126,237,9,100,62,109,138,32,182,86,141,118,101,9,89,21,44,75,160,204,235,110,93,58,11,196,230,105,74,183,195,64,212,206,140,161,84,146,80,20,246,114,192,214,141,108,126,33,216,198,129,91,160,86,173,53,148,161,191,235,18,79,7,226,28,169,6,97,142,101,68,16,190,46,118,78,196,154,172,159,53,133,80,130,85,197,29,9,57,37,176,161,43,27,228,149,231,60,77,236,46,13,55,158,27,109,204,199,184,31,214,124,30,184,29,36,80,94,104,246,176,107,11,221,179,33,176,223,124,163,49,68,134,255,163,183,12,36,153,117,177,45,253,221,24,60,59,120,54,24,40,63,247,148,197,234,8,42,35,53,172,96,64,164,162,90,128,178,195,57,22,175,92,112,129,129,157,71,124,120,43,247,206,44,14,25,217,165,33,145,201,222,242,146,131,119,229,56,155,132,235,184,16,253,151,204,112,154,77,50,188,82,17,66,211,157,67,119,81,1,102,148,35,137,220,135,203,172,62,71,179,170,164,155,158,213,123,40,152,191,117,92,215,6,142,151,89,184,89,232,222,196,104,100,97,186,130,244,112,109,28,79,53,237,0,234,172,42,43,132,233,6,162,65,27,123,24,153,72,50,44,234,103,63,198,60,227,49,152,218,200,250,114,142,101,31,192,77,209,197,182,40,111,15,56,131,87,106,25,92,57,158,177,101,55,139,236,146,246,34,197,128,116,84,25,174,27,6,108,191,177,142,247,145,200,251,7,226,89,131,166,4,205,187,45,189,173,28,90,38,217,193,188,240,178,123,209,164,152,140,206,36,178,114,20,161,170,172,183,71,27,95,176,139,245,96,251,56,232,175,66,138,44,35,233,231,141,60,18,238,27,247,131,198,253,53,47,92,232,106,174,235,111,234,201,186,76,246,33,241,239,181,184,3,203,93,95,61,176,34,166,223,58,164,27,151,34,180,5,26,84,17,221,42,182,183,200,83,246,37,110,181,106,182,243,117,177,132,186,175,129,125,104,6,234,59,177,117,3,255,223,135,100,77,221,35,220,252,170,21,95,218,46,93,9,11,82,19,233,2,68,247,135,99,33,197,219,9,109,142,13,193,61,89,24,207,12,222,108,12,201,157,212,188,173,8,92,102,240,133,213,123,223,121,57,252,137,195,202,218,81,74,151,203,111,156,229,217,84,201,79,184,64,145,93,12,44,238,0,240,19,243,165,145,195,26,60,249,109,25,0,173,2,118,119,2,61,225,25,185,119,29,88,162,217,80,187,70,240,74,159,7,230,116,247,24,176,20,7,168,101,90,159,139,130,251,140,162,64,94,166,159,175,233,237,106,21,110,214,245,99,243,134,24,61,222,128,223,4,115,153,177,91,97,216,238,187,13,20,224,38,248,62,31,115,115,176,128,41,159,203,94,216,108,233,106,48,192,230,21,178,5,154,35,113,9,8,223,127,188,48,153,93,219,192,255,131,84,167,52,72,184,29,162,170,192,191,244,232,105,95,52,209,247,40,25,117,73,226,149,184,69,105,249,245,73,204,136,144,189,246,10,234,220,156,20,140,117,40,136,96,157,223,176,132,145,202,239,46,203,38,226,147,58,125,95,94,82,151,41,33,98,102,92,12,252,127,58,141,14,246,57,36,149,21,26,159,170,143,59,40,52,251,248,176,32,243,10,31,236,235,71,70,37,143,32,56,132,114,142,143,56,25,211,93,60,214,31,119,124,153,203,187,160,120,139,72,15,111,248,119,66,193,53,161,24,254,89,245,18,126,33,53,126,180,15,36,39,40,153,192,237,134,4,95,128,163,137,230,133,128,171,201,60,87,23,108,160,164,166,98,152,213,43,94,172,77,60,189,239,30,149,26,52,135,165,238,201,149,17,226,219,68,95,198,96,109,147,157,25,195,82,232,10,83,183,104,82,0,200,241,140,51,167,242,113,128,130,128,181,5,165,85,54,246,12,144,135,56,48,91,74,64,2,79,175,239,222,26,215,21,239,188,59,226,254,246,159,54,205,127,10,22,177,233,34,53,222,202,104,212,254,95,101,127,255,29,237,0,127,254,15,178,138,181,5,85,125,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCannotRemoveLastUserFromSysAdminsExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateEmailDomainIsRestrictedOnSaveExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateCommunicationOptionEmailDomainIsRestrictedOnSaveExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCannotRemoveLastUserFromSysAdminsExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("061c7e6f-b56b-4968-b0a0-092ea1d3e22e"),
				Name = "CannotRemoveLastUserFromSysAdminsExceptionMessage",
				CreatedInPackageId = new Guid("3ef38dce-5e2a-47ca-84c6-fd68ead8e4f1"),
				CreatedInSchemaUId = new Guid("fdb74e46-7da8-408c-8b1e-76c9dc575c49"),
				ModifiedInSchemaUId = new Guid("fdb74e46-7da8-408c-8b1e-76c9dc575c49")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmailDomainIsRestrictedOnSaveExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cda5d11d-5d0b-f91c-456f-27746a6741f1"),
				Name = "EmailDomainIsRestrictedOnSaveExceptionMessage",
				CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044"),
				CreatedInSchemaUId = new Guid("fdb74e46-7da8-408c-8b1e-76c9dc575c49"),
				ModifiedInSchemaUId = new Guid("fdb74e46-7da8-408c-8b1e-76c9dc575c49")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCommunicationOptionEmailDomainIsRestrictedOnSaveExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a7bd73d5-4c2e-e3d3-ca4d-496f7b62ef43"),
				Name = "CommunicationOptionEmailDomainIsRestrictedOnSaveExceptionMessage",
				CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044"),
				CreatedInSchemaUId = new Guid("fdb74e46-7da8-408c-8b1e-76c9dc575c49"),
				ModifiedInSchemaUId = new Guid("fdb74e46-7da8-408c-8b1e-76c9dc575c49")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fdb74e46-7da8-408c-8b1e-76c9dc575c49"));
		}

		#endregion

	}

	#endregion

}


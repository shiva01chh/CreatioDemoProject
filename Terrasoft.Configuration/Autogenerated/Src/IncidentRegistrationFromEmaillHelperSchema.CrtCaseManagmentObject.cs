﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IncidentRegistrationFromEmaillHelperSchema

	/// <exclude/>
	public class IncidentRegistrationFromEmaillHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IncidentRegistrationFromEmaillHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IncidentRegistrationFromEmaillHelperSchema(IncidentRegistrationFromEmaillHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b71b5962-3320-40fb-83d2-34b80b685827");
			Name = "IncidentRegistrationFromEmaillHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,61,237,118,219,200,110,191,125,207,185,239,192,232,222,179,135,78,20,57,187,237,109,123,18,91,89,91,113,118,181,205,87,35,167,249,97,123,247,208,210,216,230,134,34,181,36,229,68,221,248,93,250,44,125,178,2,152,15,98,134,195,15,57,217,222,222,252,136,37,18,131,193,96,0,12,128,193,140,210,104,41,138,85,52,23,193,137,200,243,168,200,46,203,209,36,75,47,227,171,117,30,149,113,150,254,249,79,191,255,249,79,59,235,34,78,175,130,217,166,40,197,242,137,243,29,224,147,68,204,17,184,24,253,32,82,145,199,243,26,204,179,168,140,234,15,227,232,42,205,138,50,158,23,181,119,63,36,217,69,148,196,255,69,68,212,222,190,136,211,223,106,15,79,196,167,210,251,112,244,86,92,173,147,40,63,254,180,202,69,81,32,161,21,220,36,91,46,121,15,147,44,23,246,183,209,179,35,231,193,113,90,198,101,44,10,231,241,243,104,94,102,185,245,188,129,171,163,73,84,136,153,200,111,226,57,235,236,199,178,92,189,43,227,36,46,55,193,129,30,192,123,113,49,98,47,220,1,206,68,89,194,183,2,26,16,13,118,55,0,163,1,170,134,87,196,218,199,143,229,200,71,47,178,171,43,120,12,239,1,226,47,185,184,130,134,193,36,137,138,226,113,48,77,231,241,66,164,37,48,48,46,74,137,244,121,158,45,143,151,81,156,252,40,146,149,200,169,217,222,222,94,176,95,172,151,203,40,223,140,213,119,221,54,200,89,227,224,50,203,131,56,157,103,75,164,68,60,68,60,1,136,96,17,93,137,98,164,49,237,49,84,171,245,69,18,207,131,57,18,212,135,158,224,113,224,125,11,168,80,146,221,17,190,201,227,155,168,20,52,138,157,149,252,162,58,123,19,229,32,154,241,42,74,203,105,122,153,189,201,179,27,232,60,71,64,194,100,192,29,192,224,151,149,253,64,178,182,130,207,69,180,200,210,100,19,188,43,68,14,19,150,74,237,9,126,89,91,223,77,51,201,129,6,114,66,7,137,141,99,55,144,164,238,56,184,65,92,106,157,1,212,109,107,151,193,15,162,12,127,88,199,139,0,4,61,190,1,105,156,46,76,7,241,101,16,186,3,15,14,14,130,116,157,36,6,104,167,14,129,72,129,140,18,80,78,23,56,91,172,211,144,245,163,185,129,52,226,159,92,148,235,60,245,241,154,143,163,97,134,218,250,108,26,32,61,159,235,86,72,56,60,24,29,47,87,82,41,53,68,52,159,103,235,180,1,98,38,208,82,6,5,253,249,143,181,200,65,209,21,103,118,82,241,49,144,239,67,103,178,118,209,196,174,151,105,56,152,15,134,193,96,186,24,236,234,70,59,246,171,67,221,57,135,192,1,134,240,74,142,136,13,245,109,150,8,14,120,88,132,131,104,149,243,71,83,160,33,255,41,139,83,47,130,122,99,254,228,117,42,209,213,72,158,22,199,191,173,163,132,224,225,37,146,225,0,212,123,173,117,85,239,73,50,64,207,155,191,67,15,49,85,95,74,36,220,174,230,254,174,184,76,249,123,243,204,214,251,107,145,11,195,150,73,182,16,190,150,114,78,209,150,23,101,56,192,249,27,236,114,162,210,133,127,40,190,230,76,146,119,131,168,80,34,166,228,81,46,8,225,179,163,227,79,98,190,134,197,43,88,92,224,71,144,93,71,6,97,205,43,214,185,120,118,84,61,10,119,43,189,86,136,166,184,206,191,5,243,6,118,56,151,127,14,184,180,143,100,63,66,130,132,178,51,134,102,231,227,117,156,136,32,148,109,71,8,198,123,217,217,225,250,167,128,72,151,113,192,255,25,37,107,177,143,58,55,14,137,51,79,76,51,174,148,173,205,152,2,153,214,202,224,232,191,182,253,65,173,117,172,75,104,136,28,86,214,96,215,24,38,99,157,220,69,147,30,188,21,232,163,224,178,25,3,170,124,89,173,154,115,112,25,52,62,24,68,2,118,109,17,124,140,203,107,109,148,12,78,190,124,182,175,105,213,90,166,151,69,88,86,96,17,69,231,6,214,70,90,5,148,41,173,81,75,79,148,202,4,180,42,199,151,177,92,30,61,100,232,37,133,108,164,177,189,122,102,175,132,150,72,77,110,161,159,220,182,246,175,230,139,245,95,241,74,40,47,173,15,69,102,222,183,160,232,47,34,93,72,174,233,7,218,181,64,197,203,215,232,12,246,227,226,52,5,66,209,219,21,36,79,49,52,143,82,240,201,179,75,0,22,48,119,185,184,60,24,56,115,55,216,27,55,141,140,30,193,194,24,45,131,20,28,252,131,129,145,200,193,184,62,99,251,123,4,218,208,212,72,240,96,92,103,182,213,212,239,52,132,246,186,57,12,236,85,210,40,247,132,105,182,129,86,83,112,200,212,215,180,108,158,12,243,212,157,161,154,239,151,149,96,153,196,162,143,62,22,65,148,58,14,235,168,73,227,20,90,165,115,218,253,68,77,251,34,93,187,206,178,66,20,192,157,60,71,47,98,158,100,104,146,225,251,66,4,11,177,130,193,22,1,160,141,129,86,8,67,192,169,31,181,10,136,180,96,197,120,194,241,192,220,128,39,119,9,44,94,140,246,247,52,136,171,47,79,3,213,8,87,48,166,50,198,82,163,55,56,45,142,146,104,254,33,1,95,92,44,152,17,87,150,19,67,32,210,148,2,236,252,92,196,55,130,92,49,214,134,24,167,205,240,45,195,124,239,48,23,63,146,25,175,88,248,250,67,107,23,135,176,186,161,49,157,19,82,152,213,100,227,98,214,22,29,28,214,39,220,212,183,91,32,73,71,176,50,132,4,55,160,201,11,105,183,139,245,124,14,178,210,56,15,138,165,23,89,150,4,222,49,125,177,129,156,22,96,78,130,11,205,212,94,148,88,19,247,53,40,248,117,157,126,8,144,239,61,187,255,9,225,61,82,165,102,200,166,239,243,231,192,47,15,91,76,226,177,212,235,107,119,46,187,232,5,51,79,129,187,211,247,23,243,76,209,115,145,45,54,61,73,56,2,208,47,239,150,122,133,85,51,17,61,187,61,65,216,63,96,21,239,234,254,206,139,118,95,55,166,23,1,95,211,143,145,94,250,246,44,208,222,253,87,154,124,48,197,241,42,198,245,174,167,4,84,13,254,206,174,19,44,208,53,239,169,188,22,220,131,162,33,14,130,189,113,251,194,200,221,31,158,188,26,140,121,102,201,116,52,106,119,160,4,117,58,54,51,76,110,233,102,228,115,157,136,190,208,155,190,178,178,104,195,128,50,144,128,11,95,153,117,175,102,134,14,36,0,198,58,39,155,149,88,240,128,71,78,31,132,60,110,43,19,249,144,73,233,133,2,33,77,51,105,18,122,181,35,80,211,144,123,121,205,141,27,3,53,238,64,118,54,55,192,172,119,163,73,186,253,155,60,70,201,96,205,21,44,147,249,3,165,7,35,153,66,120,2,81,121,143,129,163,195,67,8,6,187,67,237,179,244,104,54,201,86,27,214,84,147,110,175,135,7,150,168,140,38,215,98,254,193,130,8,165,212,232,113,123,221,14,31,146,195,36,113,33,67,247,193,110,179,158,119,123,229,25,41,84,233,102,101,189,126,249,203,232,83,188,92,47,131,68,164,87,16,2,43,93,87,142,57,45,156,224,18,95,70,235,164,108,244,210,85,92,140,189,130,46,151,136,242,153,108,66,26,135,66,253,66,98,63,8,254,246,232,209,147,47,163,6,188,176,151,71,95,66,203,12,195,195,131,224,91,77,72,19,27,159,199,34,89,52,101,182,27,146,200,181,52,170,126,241,196,110,14,243,3,80,85,2,123,250,34,187,10,126,73,224,191,131,0,62,190,140,82,24,47,229,86,112,87,65,228,225,192,151,177,31,236,58,104,167,179,245,234,37,13,243,211,139,40,189,170,168,42,188,207,123,51,192,10,239,170,176,140,188,204,9,12,162,20,24,33,20,104,100,209,229,36,86,211,70,9,3,166,101,22,223,34,168,154,147,25,176,97,237,2,62,139,41,43,6,115,170,20,86,134,186,99,105,213,145,254,53,48,231,48,137,177,203,142,33,52,47,131,94,241,219,98,17,132,137,242,206,137,179,139,130,139,228,48,208,248,49,203,148,173,75,192,93,172,192,244,129,119,178,160,237,3,20,88,157,31,108,144,108,185,176,245,232,49,84,203,88,91,114,236,143,30,167,204,98,34,158,109,199,89,91,245,237,236,233,96,252,206,65,195,151,255,45,152,212,190,217,67,54,247,113,112,1,18,22,250,247,129,188,130,108,54,27,245,94,33,42,48,45,61,78,127,106,173,26,120,177,192,202,199,226,109,218,224,164,231,175,196,71,147,254,108,84,186,173,73,104,196,4,100,92,70,73,33,116,143,152,130,145,27,179,155,209,73,190,1,180,251,13,230,6,22,88,251,5,160,66,169,111,176,66,138,18,148,66,166,174,135,249,213,122,9,147,24,186,18,48,116,118,251,244,234,237,179,14,192,13,68,219,100,81,66,217,84,105,202,215,146,30,237,84,86,219,249,148,70,45,142,54,132,66,11,87,121,29,23,13,194,53,97,224,152,197,99,95,57,193,77,70,207,74,135,109,179,120,189,177,190,73,90,88,218,192,183,51,105,160,59,119,40,43,72,95,174,191,97,23,86,59,87,237,123,149,108,61,219,177,183,6,122,177,136,173,10,58,126,112,39,208,154,17,195,24,217,95,181,114,233,240,172,205,244,34,38,224,212,242,2,51,236,162,156,95,67,187,75,16,47,229,237,182,90,127,21,41,190,140,168,25,98,122,37,17,213,40,178,195,69,91,192,121,196,109,237,189,221,5,13,208,224,102,15,186,218,55,176,165,20,87,96,90,48,103,36,197,4,183,31,84,242,230,83,199,162,168,27,107,57,120,159,71,43,172,96,104,122,238,208,217,50,62,154,240,217,38,157,207,100,189,75,71,211,134,197,214,187,11,129,172,59,202,179,15,176,118,238,141,131,18,98,149,14,167,182,106,16,252,50,55,159,159,48,146,25,4,251,88,233,241,193,152,183,12,158,62,37,77,172,64,149,61,196,81,185,176,7,152,141,85,113,91,135,110,189,20,224,228,212,28,103,47,107,96,17,41,200,77,160,125,38,224,143,246,244,101,2,177,144,27,24,113,138,82,31,105,173,1,48,4,239,235,64,168,180,193,75,137,153,187,11,118,242,222,236,116,109,156,124,189,230,191,74,21,224,126,39,250,5,210,22,88,137,131,186,98,30,104,112,249,221,138,24,209,156,170,152,119,90,188,2,219,249,58,167,18,135,176,134,166,218,185,197,16,97,132,38,239,57,109,105,134,223,15,78,93,17,157,46,30,255,254,232,246,252,179,101,105,62,70,69,240,234,245,9,40,148,178,56,160,92,85,160,254,56,248,253,219,219,161,20,118,74,37,192,131,239,110,7,195,154,248,235,152,188,106,170,159,80,51,109,173,107,27,0,183,102,192,220,144,58,195,174,70,233,172,127,138,133,69,101,143,61,44,122,242,229,12,218,134,57,163,0,124,160,0,149,10,90,97,163,185,33,238,206,124,147,92,98,91,46,134,81,207,227,188,40,95,231,202,77,180,221,150,38,197,146,58,37,135,183,165,174,40,209,174,231,215,44,141,121,43,9,229,221,248,21,71,45,91,182,38,120,212,71,193,205,201,249,93,136,151,81,241,161,217,157,53,201,28,199,173,117,125,103,141,9,255,14,165,139,34,185,77,193,107,42,196,2,214,64,48,115,50,71,215,212,25,2,215,187,26,168,47,210,97,62,218,84,195,155,166,148,202,211,46,180,148,205,111,190,9,238,77,11,147,135,120,125,3,22,14,66,48,59,143,196,152,224,183,33,71,27,240,76,197,39,217,104,136,239,72,25,112,140,242,5,231,223,238,208,30,98,151,233,153,123,108,142,162,40,74,74,145,167,17,214,156,64,47,171,59,204,204,224,48,161,113,28,197,233,2,0,8,15,176,72,165,151,20,65,38,25,215,155,3,14,97,254,17,91,186,85,161,222,86,145,152,171,22,92,108,48,183,135,245,176,129,48,5,177,95,85,211,120,131,85,84,226,48,41,117,238,244,25,148,25,248,88,81,62,191,150,11,99,43,30,139,57,131,241,43,248,202,218,227,22,39,106,194,101,18,93,253,65,154,175,103,143,25,128,161,6,84,131,28,6,117,229,212,226,232,17,221,247,215,113,41,102,88,124,29,42,4,149,240,54,44,69,132,246,141,4,14,77,175,24,164,18,113,138,29,111,248,11,69,98,46,86,9,244,164,94,41,233,146,241,176,187,206,75,227,62,116,145,217,24,44,228,115,119,61,195,209,86,15,125,35,222,13,192,172,120,57,213,68,21,194,244,34,170,70,77,131,18,185,235,120,240,148,248,29,60,110,80,52,45,29,106,147,218,99,16,61,139,131,234,149,87,163,31,167,243,12,13,201,232,93,26,99,205,5,90,160,163,77,9,198,15,194,17,54,216,221,96,47,248,246,209,63,255,219,223,254,245,95,46,131,113,83,74,184,211,20,204,86,9,86,132,24,115,131,218,15,162,162,164,7,179,205,89,176,136,47,47,69,142,85,103,74,161,162,116,161,121,27,96,212,90,244,53,16,70,223,159,35,43,221,78,21,118,5,212,174,241,18,86,90,219,241,115,44,72,217,170,185,45,25,26,67,53,38,53,250,75,48,72,113,65,21,51,48,113,32,7,90,166,69,226,152,36,61,253,55,25,4,88,150,34,186,86,192,213,71,250,220,166,141,150,35,113,122,46,57,174,18,14,210,234,124,63,8,159,238,31,156,254,124,118,118,30,158,157,129,35,183,123,127,247,108,111,176,59,162,217,53,246,67,199,65,166,87,11,9,161,61,125,116,62,148,223,95,175,228,153,141,233,85,154,229,148,74,11,62,219,111,38,217,114,21,39,66,103,239,108,170,1,181,148,12,189,73,114,16,124,7,42,36,59,249,246,28,212,104,48,232,20,206,19,60,46,129,134,252,18,22,87,107,197,2,147,94,130,182,124,217,114,85,100,235,124,46,6,227,25,253,37,132,91,8,157,127,201,66,74,183,19,61,205,48,104,108,233,148,127,108,240,168,192,109,171,214,46,42,11,165,37,219,94,213,26,196,182,102,90,149,60,74,62,13,125,82,235,149,216,38,235,175,4,249,38,146,37,152,228,225,81,5,176,65,56,162,103,161,236,144,173,22,247,12,252,104,38,139,166,204,122,96,121,84,74,166,180,97,117,227,52,155,76,239,194,227,199,91,117,207,54,122,111,201,10,120,225,237,142,20,77,24,129,133,184,125,23,3,196,163,39,240,103,159,33,254,33,207,214,43,84,42,48,243,240,238,193,131,42,233,88,35,69,173,80,111,101,47,225,224,236,108,16,60,8,226,97,13,221,105,124,46,41,182,83,142,157,117,198,218,65,44,88,4,136,242,120,25,163,201,238,171,95,92,12,39,13,2,104,167,43,170,206,84,62,164,104,77,91,48,120,79,56,221,42,128,162,248,77,89,63,137,106,6,65,242,50,162,50,116,199,197,31,113,0,181,135,137,81,18,160,213,229,1,128,108,116,184,88,28,38,137,132,146,219,243,69,104,191,214,103,49,228,198,7,72,223,243,56,141,18,142,227,57,177,183,64,224,16,191,203,109,12,249,244,125,92,130,99,3,108,19,8,18,202,135,104,130,163,60,46,178,20,203,2,70,84,224,15,180,41,166,15,249,216,245,142,135,157,133,192,94,128,117,46,59,253,9,107,79,16,223,105,194,193,41,137,83,33,243,97,217,197,175,88,153,10,83,171,143,29,4,210,161,145,221,239,162,132,77,23,125,165,43,23,243,44,95,96,229,241,107,137,183,1,233,212,99,143,181,72,181,182,236,206,152,209,244,200,66,84,89,200,172,105,178,36,77,177,186,91,170,112,38,116,94,245,104,243,10,70,201,79,184,40,105,144,237,252,19,36,189,195,231,152,128,199,205,157,103,71,161,33,200,154,65,16,158,132,168,86,9,243,130,7,235,109,179,137,13,229,92,70,235,242,26,236,217,37,238,166,15,117,73,54,154,11,48,95,34,199,5,108,163,217,138,107,184,205,216,237,194,201,174,73,250,250,115,91,231,143,175,162,10,39,183,126,96,205,218,110,194,25,13,155,202,133,180,70,250,54,45,14,92,204,163,137,93,245,110,239,81,212,193,15,237,66,120,164,181,16,169,220,169,234,81,75,52,35,88,109,155,140,24,131,97,66,63,4,112,88,203,53,1,91,73,170,99,6,173,253,88,190,118,26,140,106,150,148,41,38,77,194,61,68,149,73,116,179,90,82,5,94,137,143,122,98,238,184,51,204,48,60,207,242,119,233,135,52,251,152,114,154,5,238,20,151,249,154,59,33,190,137,146,38,183,8,171,179,124,119,75,107,75,126,107,61,162,196,109,154,149,178,210,94,166,103,60,7,236,138,81,91,70,87,102,187,149,11,209,148,187,109,41,130,195,234,183,94,229,106,170,78,79,187,24,47,32,96,146,56,36,249,108,170,142,164,128,224,87,121,96,25,139,168,97,21,52,48,106,85,9,185,176,213,182,198,85,63,56,37,86,7,163,195,148,231,219,155,20,203,110,227,77,66,123,244,171,58,19,170,158,122,197,161,106,174,197,140,159,29,101,2,111,37,205,91,49,41,147,45,216,105,135,219,138,1,126,165,248,230,27,112,153,121,111,170,104,254,243,231,230,194,38,198,56,210,106,41,145,82,39,210,133,85,135,224,76,15,239,168,170,125,172,88,225,159,6,151,106,223,212,255,1,236,68,166,241,134,198,172,182,105,178,94,89,103,214,169,64,94,39,218,209,107,67,251,67,90,68,187,155,91,103,11,173,124,85,37,22,93,238,124,162,38,15,207,240,208,33,56,109,106,98,8,194,62,194,130,23,92,208,38,46,29,28,196,4,15,109,28,5,113,105,157,34,44,90,119,244,155,86,240,137,221,184,53,118,37,144,74,140,84,54,185,64,215,74,151,158,55,6,176,157,130,171,179,55,86,126,214,233,81,207,58,217,49,101,228,176,119,97,106,122,9,39,26,176,98,68,153,30,190,112,132,46,182,106,253,104,168,20,10,238,57,69,38,184,54,234,217,34,85,105,104,72,133,148,122,100,21,129,220,62,50,52,247,248,129,243,74,178,125,5,70,50,254,144,60,170,48,108,25,66,202,116,186,116,22,105,151,29,253,254,36,155,83,129,222,66,241,190,119,226,16,255,31,140,209,37,246,163,105,244,2,79,218,187,239,202,240,191,144,45,162,139,68,204,232,161,212,92,5,128,84,57,169,92,116,99,106,141,220,136,242,125,150,127,160,123,85,192,94,202,92,199,172,204,114,224,178,246,82,90,203,181,116,113,34,4,122,181,158,138,17,102,2,144,46,248,51,144,30,23,132,14,39,153,34,164,219,197,151,166,86,87,80,82,222,232,66,57,190,202,9,110,63,223,216,100,3,78,122,4,128,237,211,216,163,117,139,79,95,173,55,184,89,167,22,27,79,74,94,103,167,84,179,187,198,109,50,61,208,35,102,195,254,100,90,69,69,146,106,211,118,146,136,40,255,177,92,38,184,43,192,243,254,202,160,164,184,73,255,201,180,48,181,232,180,117,234,62,15,153,25,170,117,166,83,180,99,15,66,235,2,15,135,19,56,234,226,57,140,111,157,195,8,81,6,23,16,56,68,151,194,224,152,172,201,41,31,176,149,212,55,84,108,3,160,230,81,157,196,161,143,52,109,143,172,52,156,183,131,250,144,103,235,11,169,195,225,163,86,220,108,197,173,132,2,215,113,112,24,217,82,110,82,61,54,144,181,216,75,93,70,50,94,215,235,61,71,147,117,142,59,44,248,148,46,31,144,95,159,129,240,156,196,75,204,75,118,226,135,33,161,126,12,124,69,24,109,205,54,176,32,100,75,170,140,117,217,212,221,250,53,157,36,150,30,140,93,162,32,223,240,61,41,179,132,180,224,131,245,20,134,205,238,233,168,23,153,40,36,114,14,16,185,46,136,11,43,188,118,248,72,169,153,130,178,110,58,30,54,110,160,118,141,193,101,110,118,141,171,162,1,137,3,68,170,185,230,191,117,124,236,96,52,27,28,123,122,231,146,31,12,25,115,35,98,195,224,98,45,207,128,227,137,134,141,60,99,171,178,183,221,65,227,93,75,125,44,77,100,204,106,174,252,126,210,168,96,182,144,42,92,131,161,153,71,102,62,251,39,97,106,82,116,151,184,254,110,9,155,106,23,226,222,182,29,234,18,51,19,143,122,128,81,128,239,53,38,129,90,131,155,45,83,73,58,26,105,147,242,158,113,145,228,70,199,200,236,125,144,134,30,171,3,127,67,187,124,183,221,146,87,69,56,152,94,87,87,174,189,1,114,45,91,226,27,130,191,27,78,97,116,35,66,126,214,128,85,24,72,16,237,138,237,236,52,58,99,178,234,148,74,89,96,141,12,230,160,211,170,76,7,23,177,96,10,46,109,84,148,65,177,89,94,100,73,16,227,105,254,5,8,120,17,95,224,61,57,98,116,53,2,248,236,215,120,119,40,3,57,25,229,229,240,236,6,163,188,50,136,146,164,167,27,135,1,32,158,43,28,207,212,182,138,252,222,30,204,193,202,42,23,212,193,88,31,130,83,237,180,143,45,207,196,53,59,126,170,55,138,65,115,241,219,58,6,227,86,53,106,113,222,107,78,69,97,209,61,12,148,7,101,251,57,102,63,19,55,89,209,249,147,69,24,136,172,114,25,12,10,233,59,88,46,131,220,102,164,45,90,238,86,57,222,148,193,175,64,45,119,196,110,254,48,248,206,87,168,34,129,180,8,5,234,159,135,15,222,17,232,141,221,50,151,124,0,163,154,131,178,47,112,75,23,191,39,22,185,148,60,190,80,57,90,57,33,71,235,56,193,131,13,9,31,59,37,117,211,245,82,64,192,146,97,162,89,194,146,17,193,12,34,56,178,199,137,192,243,47,199,6,42,36,26,170,254,21,42,117,211,83,133,109,244,18,68,246,21,186,194,182,93,172,90,6,227,3,135,238,157,157,11,88,210,237,155,30,244,12,95,229,209,10,92,120,58,138,92,117,98,83,105,178,129,172,147,7,7,166,169,154,33,102,203,138,11,86,238,240,168,34,67,110,97,95,71,88,84,244,34,251,56,3,231,46,187,130,57,10,53,170,211,71,231,60,219,164,230,204,28,31,152,71,40,43,132,0,40,116,222,26,36,32,143,85,194,73,214,88,149,72,136,3,63,122,149,165,184,217,13,92,120,25,229,148,20,108,0,84,80,147,108,121,65,213,234,29,224,199,41,250,27,10,206,189,150,43,78,205,249,232,166,59,179,128,123,135,43,188,167,198,140,200,39,248,0,181,69,52,139,153,47,19,45,230,246,237,5,61,140,94,117,61,26,59,162,31,183,108,40,30,214,251,26,6,191,102,113,10,86,43,78,245,105,240,174,172,67,149,62,106,186,111,208,216,169,250,81,115,118,163,96,203,133,130,236,62,193,119,158,99,130,244,207,220,30,72,183,201,177,163,229,77,32,206,9,244,38,176,163,132,82,254,126,88,231,66,66,136,161,107,23,250,233,107,242,244,29,119,219,95,109,215,114,179,93,45,220,111,185,216,238,43,221,107,215,113,173,157,59,215,141,183,212,249,46,16,48,58,103,137,10,94,71,192,132,140,11,171,249,236,105,218,221,179,51,171,255,199,189,251,4,235,107,144,80,15,198,60,122,30,64,48,54,96,205,171,221,139,230,244,125,5,220,105,201,144,98,158,5,151,165,153,74,231,123,154,179,156,165,213,217,45,21,198,42,181,86,173,41,112,214,114,24,128,228,206,175,131,226,58,91,39,11,244,44,165,165,107,54,143,63,73,75,152,123,250,110,177,136,206,100,213,108,31,43,67,211,83,199,234,170,239,121,207,4,84,160,204,41,107,187,183,163,77,68,238,58,167,230,164,152,167,206,143,54,125,35,61,178,101,84,124,232,59,203,177,74,30,227,81,9,171,240,74,98,105,41,128,175,17,161,170,176,250,214,195,59,103,54,212,11,78,15,119,41,243,90,9,234,247,131,179,223,79,127,254,253,246,252,193,217,45,175,61,160,82,207,3,217,64,213,28,88,72,121,42,64,87,159,114,0,83,41,71,37,158,100,52,134,1,116,182,120,48,176,131,179,21,43,216,107,61,253,136,119,108,86,251,27,203,238,11,62,244,189,147,109,147,168,153,219,125,95,72,195,76,160,235,222,144,255,245,21,156,215,15,185,0,130,218,9,23,149,244,112,106,59,16,55,88,195,9,21,28,170,240,70,158,70,106,188,40,165,219,91,155,81,217,161,114,122,251,112,204,173,54,148,129,245,192,57,247,216,181,219,120,135,205,9,107,219,209,147,138,84,233,5,158,69,240,236,53,80,93,203,149,48,205,170,251,156,182,45,107,145,101,118,52,73,12,151,218,52,116,46,61,32,151,114,161,9,174,90,120,174,164,70,251,233,165,239,155,111,92,71,201,187,27,224,35,198,205,107,249,79,51,187,155,162,117,143,247,176,80,185,129,3,199,101,110,72,245,237,236,248,199,220,64,1,57,25,140,252,217,122,181,202,242,82,141,34,172,211,225,203,52,225,8,61,189,162,195,234,156,14,245,211,182,149,16,48,21,125,86,199,54,228,219,191,110,74,210,79,227,171,172,116,201,108,75,250,169,134,148,131,243,32,180,58,221,62,189,237,84,40,80,66,168,234,146,18,217,245,51,174,223,185,103,92,255,201,159,221,246,144,219,43,229,237,63,251,243,202,42,202,161,99,213,174,57,224,14,10,79,71,74,169,199,32,155,61,246,150,95,201,195,155,42,51,254,139,41,38,86,162,14,250,57,45,228,102,10,18,64,47,187,48,170,186,175,170,21,198,86,187,181,83,103,88,21,231,113,123,200,194,180,48,197,37,70,94,252,75,189,56,139,19,109,208,210,1,125,144,65,155,122,156,4,223,46,170,211,165,182,202,216,248,109,124,117,237,20,112,26,139,220,52,43,180,7,12,97,132,124,42,49,80,237,181,62,118,3,122,201,223,201,13,249,209,196,219,132,47,34,35,185,111,140,91,196,74,105,249,203,122,137,232,48,224,10,87,181,229,143,27,11,75,187,136,60,92,44,227,84,150,23,8,60,191,136,149,194,133,98,151,123,202,213,207,13,47,243,105,98,235,229,114,246,69,207,156,211,109,191,137,32,103,130,26,241,141,247,187,111,203,235,75,252,37,122,45,1,188,135,234,134,105,142,179,231,78,190,167,165,53,63,84,193,226,239,0,168,173,129,134,91,160,110,162,91,158,69,144,199,8,9,103,31,26,173,126,9,193,73,70,117,229,158,67,19,178,213,233,185,89,35,122,81,161,183,108,148,201,186,173,28,14,171,189,85,205,222,69,249,176,18,176,161,67,119,101,198,184,184,217,93,109,115,161,164,101,251,236,91,199,251,223,36,210,125,193,56,85,129,200,32,131,130,32,85,195,253,227,201,203,23,15,1,240,195,122,213,63,42,92,173,75,233,169,128,191,139,184,200,193,6,252,169,55,248,55,149,55,8,26,93,150,194,2,182,163,15,125,85,208,77,156,151,235,40,209,17,161,93,194,98,162,65,67,7,55,2,215,0,246,94,94,36,55,93,226,207,253,152,26,115,29,187,177,134,24,188,133,251,241,242,234,108,239,233,233,207,227,243,7,227,221,193,208,202,127,54,30,98,100,130,157,102,147,162,222,77,141,16,236,108,239,236,254,232,193,211,179,251,123,237,221,204,224,69,34,18,240,196,173,110,164,143,83,74,95,213,238,141,104,160,30,246,239,61,124,120,122,86,156,205,206,239,63,125,248,112,188,119,117,167,17,205,202,13,93,175,234,246,82,145,48,12,6,251,5,66,141,238,63,5,145,193,79,227,59,141,106,54,207,227,85,233,233,139,104,160,110,8,66,246,67,31,239,214,17,10,59,154,29,213,35,59,246,150,159,165,128,122,21,165,136,120,16,232,207,170,53,107,137,31,170,118,10,14,155,183,182,115,7,134,143,113,174,246,23,241,205,248,243,126,18,83,183,132,166,111,83,4,254,253,187,225,237,214,13,247,165,156,127,254,159,255,118,120,216,15,193,96,31,166,193,101,191,219,148,253,144,216,8,213,246,153,192,253,29,133,163,47,161,63,159,21,15,254,122,138,99,59,191,111,70,233,76,244,75,240,181,99,54,207,221,163,199,75,11,145,3,247,59,68,168,166,22,84,36,47,231,127,134,187,120,5,234,118,168,120,111,214,4,87,84,170,157,210,239,134,250,89,251,126,172,4,234,204,112,232,34,48,171,190,18,13,113,148,86,105,7,252,186,146,63,216,16,151,184,249,143,191,45,129,231,208,245,113,198,173,74,47,117,78,164,237,138,105,203,226,79,171,95,75,193,252,159,10,184,38,242,18,14,191,225,39,231,110,154,210,113,254,68,143,145,71,62,60,145,226,57,27,231,61,252,163,192,153,39,66,17,0,128,235,203,85,176,91,54,207,110,65,215,189,238,138,174,150,204,62,46,175,88,36,161,126,160,224,88,213,140,127,136,87,50,34,173,253,112,157,21,121,62,114,35,207,111,111,61,181,108,109,23,77,201,209,114,81,171,197,43,85,249,74,237,14,46,95,20,202,2,157,187,221,189,69,216,172,186,224,63,238,186,45,107,148,222,226,93,62,228,29,59,218,179,194,60,54,236,39,245,160,171,86,106,166,138,128,242,12,143,153,139,133,125,14,108,199,200,96,191,96,154,57,140,178,56,206,14,248,183,137,236,49,57,32,211,120,60,25,115,39,90,182,79,191,96,213,157,192,2,35,58,149,134,4,141,130,195,133,14,224,41,249,130,118,74,235,14,101,103,192,36,52,73,128,142,229,27,82,117,245,147,245,91,12,211,206,95,124,241,128,217,96,87,12,243,87,31,50,253,223,38,152,106,68,26,19,63,242,219,208,66,218,0,37,201,78,18,120,27,134,188,91,45,144,25,154,230,17,229,233,37,57,143,253,124,184,83,18,174,137,67,62,243,96,13,27,43,237,234,69,118,118,52,214,122,214,1,45,154,25,0,43,127,12,122,174,179,188,76,4,68,131,109,33,180,95,211,225,169,43,212,8,212,59,123,207,193,196,89,152,223,242,158,137,115,202,69,212,239,105,249,58,210,86,196,74,171,232,150,12,114,139,132,139,84,181,182,83,236,12,175,147,130,241,244,76,63,231,213,64,79,143,116,140,167,109,75,225,126,3,180,83,100,202,202,210,35,87,131,251,96,176,167,122,232,159,152,254,232,212,111,99,14,141,190,233,159,179,170,183,69,80,244,129,182,193,46,162,5,150,114,57,150,163,79,211,105,10,16,130,207,182,181,138,246,71,241,86,20,43,24,147,119,148,124,116,26,44,125,150,173,47,58,152,88,153,139,94,123,243,215,81,186,72,200,243,190,206,10,65,215,160,208,229,174,252,166,3,125,152,50,162,107,168,200,129,160,103,57,60,188,203,254,165,58,21,175,124,238,110,19,130,118,67,211,224,187,239,194,54,86,230,39,251,244,239,69,246,184,34,163,213,253,215,121,159,99,235,50,89,183,164,218,179,39,218,239,215,255,26,43,167,59,13,187,10,178,100,7,67,170,142,158,71,20,70,201,223,234,187,219,57,214,166,99,172,230,26,27,21,50,233,25,97,191,218,212,197,65,121,255,116,195,209,104,126,94,213,107,190,85,135,127,100,142,188,74,154,110,149,23,143,77,114,31,134,133,127,121,102,59,149,73,113,21,214,43,135,100,0,190,71,16,130,119,129,169,189,230,147,152,131,138,77,72,125,13,202,220,97,160,43,244,37,108,203,74,128,30,186,247,84,236,68,94,219,92,252,187,216,168,216,163,249,200,174,15,193,41,53,58,215,129,68,69,136,101,247,94,24,52,3,207,233,219,91,119,16,182,205,196,54,38,36,110,130,66,62,1,92,90,165,249,155,32,105,20,131,6,6,54,156,111,136,251,187,93,95,247,136,169,182,157,127,135,131,166,90,139,143,157,163,166,250,24,175,57,110,250,149,146,33,122,163,180,35,42,238,189,17,209,245,11,50,109,89,43,62,109,245,39,78,242,138,238,2,218,58,131,37,151,42,53,19,206,90,117,250,250,162,0,215,166,4,105,5,227,99,40,213,156,167,159,128,1,63,102,52,216,61,167,185,146,119,202,107,115,75,142,180,149,175,34,3,172,122,181,109,172,53,174,131,218,253,79,186,141,156,33,11,103,109,2,255,1,51,132,157,140,107,150,109,111,94,240,255,59,79,156,138,127,182,128,247,227,137,22,64,175,64,81,189,146,13,55,93,216,18,244,15,200,142,150,36,114,117,48,213,235,72,218,124,212,5,4,30,22,121,153,73,62,164,84,197,73,75,134,120,86,102,171,143,116,167,201,71,117,241,164,121,34,183,6,192,144,106,31,160,204,205,207,165,222,65,249,119,92,106,250,105,192,206,142,38,38,91,153,163,71,148,167,121,38,46,214,87,221,137,26,60,41,94,253,192,185,149,159,198,44,77,21,190,54,38,169,36,1,199,73,180,42,132,206,187,176,172,220,156,24,23,30,127,154,11,218,111,1,129,178,19,201,199,121,158,229,61,50,74,234,119,43,84,206,120,18,37,9,204,192,252,131,74,22,77,193,129,204,77,39,205,9,35,44,6,150,136,232,51,161,56,129,144,75,126,181,177,152,49,80,62,47,217,240,26,68,57,234,105,241,118,157,166,108,91,218,59,31,188,186,111,155,185,161,164,226,117,84,4,23,66,164,92,31,84,222,80,177,194,73,156,249,243,100,92,186,220,73,210,177,18,135,105,113,6,228,83,251,33,61,227,255,254,23,126,211,94,242,7,138,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNewContactNameLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateUnableToGetClosureCodeErrorMsgLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNewContactNameLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e2333bfd-1c31-4dff-8d70-a9288a413a5c"),
				Name = "NewContactNameLocalizableString",
				CreatedInPackageId = new Guid("c2657f9d-1b86-4f69-b0c1-b23085f13744"),
				CreatedInSchemaUId = new Guid("b71b5962-3320-40fb-83d2-34b80b685827"),
				ModifiedInSchemaUId = new Guid("b71b5962-3320-40fb-83d2-34b80b685827")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUnableToGetClosureCodeErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("508fcc8a-3ea1-4803-8d4f-7d5717f894f5"),
				Name = "UnableToGetClosureCodeErrorMsg",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("b71b5962-3320-40fb-83d2-34b80b685827"),
				ModifiedInSchemaUId = new Guid("b71b5962-3320-40fb-83d2-34b80b685827")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b71b5962-3320-40fb-83d2-34b80b685827"));
		}

		#endregion

	}

	#endregion

}


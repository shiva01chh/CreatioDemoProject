﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SyncWithLDAPProcessHelperSchema

	/// <exclude/>
	public class SyncWithLDAPProcessHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SyncWithLDAPProcessHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SyncWithLDAPProcessHelperSchema(SyncWithLDAPProcessHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8b1112e7-8eb1-417c-8d5f-1d425a56c066");
			Name = "SyncWithLDAPProcessHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c94edc4f-74f1-46a8-b11f-d3d8de7f0346");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,61,105,115,20,201,149,159,123,34,252,31,138,94,219,211,109,139,226,24,207,98,11,36,66,23,51,154,5,132,17,44,31,38,38,38,74,221,41,169,76,117,85,187,170,26,144,65,255,125,243,229,249,242,172,234,67,192,216,59,225,48,234,202,235,101,230,187,243,229,203,50,155,145,102,158,77,72,242,138,212,117,214,84,231,109,122,80,149,231,249,197,162,206,218,188,42,211,167,135,123,47,126,247,205,199,223,125,51,88,52,121,121,145,156,94,53,45,153,61,180,126,211,70,69,65,38,208,162,73,127,32,37,169,243,73,180,206,201,217,63,232,159,207,170,41,41,156,122,135,89,155,57,31,159,230,229,63,157,143,175,200,135,86,127,60,168,9,192,156,62,161,255,44,106,242,170,186,184,40,232,119,93,225,162,168,206,178,98,123,251,160,154,205,96,106,180,130,81,142,215,0,106,248,75,106,18,250,110,46,93,176,214,225,126,176,232,168,108,243,54,39,77,176,194,73,125,113,218,214,139,9,76,208,87,233,13,57,67,192,211,255,253,87,77,46,40,48,201,164,200,154,38,217,78,96,63,159,230,19,82,54,228,184,60,175,126,247,13,173,51,95,156,21,249,68,84,113,42,12,96,243,101,157,31,22,249,52,121,221,144,250,120,154,124,76,46,72,251,48,105,224,255,174,81,157,166,173,1,40,168,245,156,226,87,176,222,211,188,105,31,241,202,187,201,179,188,129,169,136,145,27,167,209,181,152,14,41,167,124,70,12,114,57,187,3,0,125,155,162,69,57,121,147,183,151,48,135,23,117,53,33,77,243,35,41,230,164,118,167,25,169,10,19,6,48,101,231,79,114,82,76,105,239,47,234,252,93,214,18,94,56,231,63,232,100,233,102,79,18,138,122,211,170,44,174,146,138,33,118,242,107,81,77,222,114,36,79,118,146,146,188,23,5,163,241,67,220,90,53,131,197,162,216,83,114,250,72,126,93,24,191,253,109,216,94,252,154,21,197,209,108,94,84,87,132,52,63,212,213,98,78,119,134,143,8,229,163,225,199,189,251,127,219,251,110,127,239,251,219,127,217,191,123,120,251,240,232,222,189,219,127,219,251,254,222,237,187,119,191,191,251,253,127,31,220,165,255,253,245,122,24,128,139,143,209,52,115,0,208,223,255,131,251,119,247,31,60,184,119,112,251,232,193,222,131,219,127,121,242,29,237,255,224,201,254,237,239,239,31,28,222,191,119,240,221,131,239,254,246,36,216,255,49,37,66,88,172,11,218,39,253,243,89,86,102,23,164,166,44,164,5,234,36,245,104,8,27,100,181,54,16,231,215,236,93,150,23,217,89,65,4,238,0,206,53,110,125,11,175,119,249,26,55,128,3,213,162,149,120,23,25,167,97,60,231,148,180,173,198,83,57,22,67,23,132,154,131,1,70,32,138,95,20,177,128,174,1,137,170,150,110,42,153,242,70,119,238,220,73,30,53,139,217,44,171,175,118,229,7,58,251,38,57,198,164,46,214,37,201,75,138,111,229,132,164,170,237,29,220,120,46,59,247,183,246,125,19,116,118,237,206,1,207,128,162,98,195,90,86,53,204,129,17,146,160,3,78,84,65,114,26,89,152,109,34,246,56,97,204,101,96,225,59,69,6,15,1,12,188,59,38,144,209,187,199,130,218,6,190,137,243,102,158,146,145,5,12,239,163,99,129,158,17,10,84,144,73,80,137,70,94,229,51,242,24,182,246,89,94,82,185,151,159,231,100,10,223,79,206,159,147,247,140,186,70,114,53,222,101,53,236,74,176,34,133,125,116,74,64,150,142,97,14,252,79,7,108,214,213,0,164,238,98,86,142,158,44,202,73,74,123,28,13,101,159,39,229,112,44,43,61,169,171,217,104,72,165,42,172,32,236,229,37,12,52,148,197,111,46,73,77,70,227,244,121,69,25,88,122,244,129,174,117,51,234,28,90,141,205,255,73,25,18,141,238,141,85,177,26,117,111,58,203,203,215,101,222,14,85,25,31,210,44,220,74,24,55,160,66,178,190,58,158,14,199,233,113,115,244,207,69,86,120,32,167,85,161,6,239,77,96,129,220,5,202,125,154,69,1,124,57,182,200,116,154,100,178,104,201,233,36,43,178,250,145,108,172,112,170,38,20,103,202,100,36,59,219,81,187,12,203,252,191,89,177,32,227,228,113,50,37,231,25,45,31,41,20,24,83,33,204,219,96,188,146,152,242,174,162,252,246,224,146,76,222,50,32,142,75,198,114,71,79,167,217,156,253,149,92,192,255,111,113,190,124,193,217,177,248,213,208,201,195,15,74,27,8,225,102,129,249,73,92,163,75,41,254,26,228,101,203,200,174,57,168,22,37,135,110,32,20,140,17,160,100,65,129,120,221,230,133,34,57,241,155,105,44,14,14,200,1,160,11,217,39,109,168,58,73,143,41,149,214,237,51,50,59,163,197,39,231,108,122,175,170,87,192,201,71,98,150,124,74,98,193,229,82,113,250,96,253,160,37,58,93,156,113,100,76,118,196,176,221,248,169,16,20,225,74,23,45,96,204,244,162,156,129,148,97,220,21,115,202,207,147,17,159,37,109,71,201,139,138,242,246,106,132,22,47,56,207,116,175,164,210,23,246,224,148,181,71,35,11,122,123,145,213,84,60,181,148,163,137,117,68,11,9,255,136,245,82,35,188,170,14,233,151,150,188,172,10,210,220,192,122,70,169,156,233,148,37,12,13,75,37,63,68,215,19,13,50,224,171,193,54,163,174,202,252,95,68,10,163,216,178,80,198,79,198,78,23,230,32,248,247,171,171,57,97,132,29,235,116,68,201,104,108,183,74,25,201,153,67,89,236,52,184,209,227,36,107,196,194,35,164,57,165,50,176,152,210,30,96,206,71,31,232,200,101,86,8,49,226,193,30,255,222,250,167,172,55,22,64,71,107,28,159,51,140,195,230,202,236,191,172,176,209,13,168,118,170,129,48,240,138,3,23,148,35,10,133,16,150,120,112,8,190,199,9,65,112,76,45,130,248,70,216,91,224,95,45,57,31,152,8,40,116,204,202,83,140,13,77,77,138,14,41,42,6,160,224,166,160,145,60,169,234,89,214,114,68,61,62,220,78,62,222,191,78,147,143,247,174,25,223,29,53,99,42,25,102,213,59,170,191,157,211,25,39,231,85,49,5,21,237,238,53,221,22,6,122,10,10,231,150,61,186,205,40,1,63,16,211,125,148,220,211,24,17,146,7,9,150,95,217,7,134,230,162,59,33,234,204,221,252,251,130,80,201,129,86,108,111,58,93,159,113,24,154,130,130,231,121,245,126,188,177,170,54,10,172,202,180,44,242,149,189,245,152,172,119,196,0,146,167,123,205,104,184,168,81,53,129,238,139,122,37,62,41,184,156,106,189,4,201,104,54,212,65,61,14,3,195,213,111,150,193,174,195,32,29,4,254,236,220,49,103,26,145,203,29,185,166,212,161,107,31,151,109,21,226,145,131,148,154,173,163,33,115,144,49,197,159,206,3,153,1,6,42,152,88,133,233,65,0,16,91,50,57,41,151,61,162,185,173,193,30,179,233,148,50,199,182,90,153,53,194,50,207,148,5,104,173,37,119,191,93,157,78,46,201,44,19,214,32,106,247,79,198,242,184,238,139,107,50,86,56,18,189,74,61,175,32,51,82,82,166,161,48,141,46,25,195,163,151,249,197,101,11,42,244,121,86,52,68,224,0,26,133,90,2,96,207,115,44,98,254,179,29,62,114,74,87,91,48,14,254,251,101,69,145,155,65,0,254,146,23,118,59,138,230,108,77,68,223,188,205,147,188,104,193,184,161,125,137,94,56,82,240,239,160,52,41,188,109,70,252,227,65,53,155,103,117,222,112,132,79,25,146,91,218,172,220,2,164,99,110,106,56,208,137,197,136,140,222,182,146,30,244,15,235,56,81,222,102,181,128,116,149,248,190,105,79,180,223,216,231,28,68,247,64,57,129,161,148,75,3,68,251,195,116,221,159,239,254,2,3,1,80,98,187,24,71,123,4,54,218,238,200,217,93,57,160,105,212,184,66,116,19,130,197,111,208,44,97,209,96,204,14,24,52,221,22,205,192,157,229,26,182,140,228,159,72,189,212,198,178,177,120,113,29,83,46,19,204,137,115,80,248,139,117,227,174,148,42,138,131,138,80,196,209,253,45,181,33,182,189,169,170,52,240,237,47,134,92,177,29,93,136,64,182,231,37,182,208,213,32,172,125,246,40,16,86,13,46,10,237,149,224,10,87,31,131,40,110,17,105,241,162,118,221,218,105,67,164,32,132,200,145,228,20,40,145,44,41,81,99,8,209,41,86,49,162,88,171,237,145,172,95,151,162,236,199,222,8,135,241,34,224,170,190,195,192,80,81,50,229,202,242,133,7,251,233,199,53,144,93,183,94,150,232,93,157,57,164,52,59,218,242,102,9,77,179,103,155,34,28,109,76,185,217,34,166,98,220,141,141,100,104,168,143,244,199,172,17,62,82,41,23,226,90,32,29,142,74,206,34,153,130,151,180,58,103,84,204,108,92,74,227,92,251,0,101,112,27,180,69,83,35,148,203,25,132,132,129,225,248,26,19,66,181,179,30,176,221,163,176,253,32,135,79,166,21,105,202,111,219,228,50,123,71,146,76,3,105,41,169,142,95,147,141,120,158,83,11,165,80,238,88,45,208,4,211,234,235,36,177,196,124,95,79,35,31,75,201,139,53,28,139,162,39,11,177,174,67,238,110,170,28,62,205,39,116,101,1,222,17,215,208,216,178,73,216,196,129,114,129,206,220,232,146,208,153,138,195,56,8,57,104,217,54,218,139,3,100,43,40,140,14,241,34,155,188,165,58,58,236,6,239,50,101,139,32,224,99,10,152,62,84,194,163,193,138,45,138,226,164,126,115,153,183,228,20,2,38,70,224,220,47,233,199,100,155,109,142,86,41,229,137,225,200,232,225,116,94,228,237,232,219,135,223,142,209,112,23,117,86,82,201,129,142,178,108,139,132,22,241,115,52,80,161,97,26,123,198,105,231,132,52,204,211,147,26,218,191,192,104,57,25,52,224,204,58,101,23,148,108,124,28,89,80,57,29,113,186,54,218,88,10,50,212,240,30,214,165,194,28,220,73,238,90,132,255,38,171,75,38,22,158,86,147,172,200,255,5,83,60,101,11,105,239,105,250,166,170,223,178,160,149,244,37,105,170,69,61,161,21,171,154,110,172,162,245,97,240,56,114,184,53,116,6,104,82,116,110,248,148,194,34,92,16,22,86,91,135,139,12,67,97,12,59,114,129,173,233,107,127,33,219,172,45,123,27,148,29,236,93,50,176,157,2,99,201,134,146,64,170,139,103,116,166,116,37,162,64,60,85,213,58,192,81,251,162,59,142,208,178,113,90,238,65,43,68,33,204,22,178,177,127,43,57,62,42,23,51,106,190,211,157,81,29,41,220,195,103,163,70,67,201,15,232,144,63,184,5,54,54,35,98,240,6,14,104,202,111,0,77,25,133,179,99,219,61,95,237,17,156,230,209,194,211,80,108,192,104,51,68,200,250,218,242,67,108,158,71,90,157,251,206,24,109,68,142,160,43,98,198,91,230,6,251,246,101,33,35,126,248,241,189,215,12,150,204,113,8,21,135,104,85,212,161,44,99,2,22,136,130,85,136,192,35,209,189,135,231,233,106,8,14,164,6,184,180,42,231,193,209,218,88,202,240,41,173,15,81,163,88,208,7,179,129,105,222,10,71,153,40,25,100,11,110,1,109,52,62,69,113,49,36,228,36,186,171,232,9,185,53,98,83,48,204,204,197,165,196,254,110,82,242,182,28,0,57,145,84,154,49,108,233,119,89,199,102,67,86,52,30,167,175,42,24,112,132,118,191,49,188,29,203,28,53,130,194,163,68,59,168,200,28,177,120,61,164,20,229,19,245,241,152,246,86,255,84,229,78,235,113,122,162,190,9,71,168,46,197,70,155,17,120,96,140,174,107,97,183,138,7,64,10,5,91,142,70,86,151,222,102,179,242,137,242,103,234,209,185,41,117,76,107,190,37,174,78,54,252,195,49,85,140,234,119,88,229,249,131,10,245,176,206,18,249,186,75,85,237,37,201,166,180,135,154,253,3,91,136,84,81,132,53,20,105,120,21,160,240,78,226,30,96,124,99,210,12,125,144,242,68,252,27,70,98,91,35,59,164,8,148,151,16,80,103,97,83,63,114,96,212,208,131,164,67,92,31,147,172,151,43,119,146,107,56,108,77,144,170,10,87,153,44,234,154,154,127,135,217,21,62,164,123,221,78,168,13,15,193,178,196,209,95,187,72,27,83,92,210,151,228,126,51,20,231,80,132,94,192,49,234,111,159,180,239,9,49,71,111,179,186,133,21,117,3,11,100,149,195,5,49,42,244,39,219,245,232,118,144,158,212,148,226,246,175,246,154,73,199,22,124,237,52,222,161,119,33,66,16,180,226,20,56,212,107,235,158,62,69,208,209,63,125,42,76,79,2,2,194,87,98,143,162,166,159,198,221,9,93,119,74,86,10,89,80,176,82,91,217,47,86,243,105,84,168,254,251,145,184,191,10,136,84,88,191,207,43,81,251,19,230,215,77,151,17,98,91,198,204,243,9,210,149,44,61,19,30,56,53,158,144,121,235,216,115,38,222,59,156,65,152,198,189,172,225,229,172,29,195,218,102,180,197,42,239,47,114,56,154,198,116,184,178,93,164,135,72,247,230,115,66,209,249,247,67,74,236,219,201,199,128,1,116,61,78,62,241,66,232,230,154,254,144,93,137,117,112,109,79,225,9,227,148,75,17,214,113,247,184,64,248,253,5,110,189,97,58,180,112,75,87,121,85,9,239,78,96,223,206,170,170,128,93,163,148,119,202,156,246,35,22,228,186,96,22,160,220,6,113,70,154,203,58,167,75,90,17,70,112,52,115,77,57,177,202,252,80,129,149,185,252,207,9,14,146,236,41,238,53,21,147,176,217,212,114,97,48,226,42,81,26,61,89,227,125,219,33,43,225,78,85,148,10,93,208,177,19,120,200,246,68,45,54,4,117,152,11,111,133,76,231,101,75,5,102,178,155,220,53,144,64,53,10,198,63,43,135,112,100,235,123,135,248,224,224,181,107,46,9,213,146,201,224,229,164,113,190,8,146,182,191,75,178,118,221,189,201,156,51,125,169,58,56,93,178,75,45,74,54,112,157,196,113,87,27,27,160,117,13,163,239,91,220,45,165,102,232,142,36,124,197,202,69,236,12,195,215,114,203,128,185,183,155,158,130,118,82,139,48,166,144,203,30,128,54,168,55,192,176,244,62,57,155,30,106,33,183,18,31,208,152,71,8,12,144,240,108,0,155,152,75,239,120,186,127,197,34,101,4,115,44,249,225,12,255,65,216,164,248,121,13,67,252,9,59,230,125,78,222,31,159,83,148,123,66,57,130,129,140,130,143,154,102,31,247,119,88,106,33,108,158,237,147,81,170,90,119,28,0,62,22,21,159,24,67,210,0,203,207,130,25,73,127,67,136,232,5,144,22,177,139,192,255,195,125,78,212,85,157,76,207,212,159,190,208,169,102,81,147,195,125,253,9,209,160,232,235,24,110,118,114,61,7,206,241,228,159,59,137,87,19,210,195,161,67,42,88,105,221,52,133,127,140,216,18,177,196,168,138,165,38,241,48,156,33,142,88,17,254,253,107,180,37,44,252,39,188,223,131,59,119,218,106,90,193,137,221,148,221,183,200,155,36,111,233,222,193,65,3,69,87,212,147,189,231,94,202,154,180,11,56,146,32,138,145,243,248,61,202,60,169,30,232,185,162,148,170,22,152,251,203,70,15,61,67,28,207,230,85,221,114,222,216,125,57,36,126,163,36,251,192,27,77,152,22,205,27,170,80,32,227,70,151,123,252,83,144,204,80,141,248,34,51,184,246,232,86,207,224,50,37,28,130,82,212,45,229,17,164,136,232,239,123,228,199,119,72,68,101,244,234,153,234,60,44,24,15,49,220,91,75,0,166,176,34,190,50,44,70,220,190,12,244,208,35,164,56,16,242,50,14,109,38,228,39,124,34,117,93,169,111,236,171,188,129,198,14,161,169,54,155,137,155,133,226,164,4,2,113,87,212,138,204,248,174,96,97,164,232,240,185,91,104,120,42,212,87,127,84,109,15,77,107,141,43,31,113,197,75,154,132,43,95,243,64,241,27,234,194,154,236,20,100,196,200,175,95,53,65,165,6,8,32,162,241,32,47,160,12,65,49,47,71,202,175,202,139,241,57,89,60,194,196,62,124,254,253,101,94,144,56,171,231,65,158,24,109,224,94,164,84,160,198,97,17,192,244,82,7,227,164,52,224,194,60,188,9,127,252,163,61,42,213,199,156,232,110,13,230,0,41,23,192,2,130,96,249,13,248,1,62,135,253,253,240,32,43,203,170,101,156,57,33,2,174,164,166,108,63,249,8,3,92,227,118,20,76,202,42,245,53,14,21,42,41,65,186,80,225,171,61,160,242,6,123,26,61,61,239,61,67,196,59,188,61,29,150,75,246,3,140,70,245,164,209,159,121,60,228,85,69,126,147,82,221,153,84,32,111,201,49,157,152,82,165,17,112,70,107,93,253,85,156,151,133,114,81,128,24,126,32,6,44,248,46,129,98,50,229,81,94,171,178,98,191,255,45,194,21,151,180,38,255,226,42,128,64,95,4,79,45,226,15,189,105,78,2,157,184,235,184,12,35,241,48,16,99,114,12,85,166,181,86,43,238,142,145,143,98,77,204,248,169,58,179,37,243,63,232,39,25,215,149,179,37,160,122,35,211,78,165,5,98,156,214,64,245,149,145,199,39,190,61,8,69,161,28,126,198,253,212,83,90,115,31,89,160,47,227,98,125,180,125,86,93,50,227,222,76,24,128,101,40,2,251,83,226,184,253,126,24,17,14,32,188,123,157,38,236,220,137,169,123,73,206,20,245,116,104,5,9,42,101,78,222,167,185,171,191,151,92,105,63,158,26,20,202,141,114,133,68,241,8,70,102,221,176,8,70,96,169,124,36,184,111,211,86,12,12,161,96,1,84,136,185,250,46,216,48,161,76,85,92,138,14,27,64,87,205,233,14,120,159,54,159,59,228,10,117,183,198,103,51,55,102,223,8,117,92,119,207,175,114,96,240,45,151,22,199,39,59,159,64,145,53,204,180,210,177,223,137,39,27,0,111,116,94,81,195,98,114,153,216,87,250,143,91,50,131,80,86,189,190,10,195,241,93,127,129,117,82,223,176,84,17,81,42,86,158,53,209,185,71,78,123,184,24,250,112,142,53,84,245,37,52,237,222,119,7,44,53,187,251,42,35,36,142,122,238,117,121,108,148,237,245,211,136,237,237,233,195,10,59,157,32,131,62,138,157,143,53,14,28,125,58,220,94,162,96,76,149,182,162,168,5,23,58,2,27,214,203,134,78,234,139,140,50,26,102,61,75,189,22,212,221,115,198,158,40,233,32,246,148,124,75,217,213,183,67,21,243,41,103,45,183,215,142,178,30,68,20,98,131,135,15,148,181,4,83,220,213,151,178,76,36,89,39,35,134,234,210,72,136,1,135,105,70,54,12,141,176,91,225,60,30,15,13,216,227,65,244,22,155,231,254,5,147,199,3,15,66,139,204,195,233,21,188,130,231,139,105,196,23,156,185,53,17,233,242,171,138,253,110,93,166,79,242,114,122,44,146,29,9,39,173,197,91,208,40,68,228,191,90,123,4,153,72,203,232,29,176,38,155,172,15,254,1,239,199,232,155,237,128,37,210,77,17,193,78,90,184,102,80,234,125,208,168,116,231,79,204,19,217,144,172,166,77,104,29,169,213,170,85,105,254,116,7,57,79,189,110,106,230,106,127,66,63,60,55,252,213,46,197,92,163,158,60,82,239,17,63,223,212,95,240,173,63,159,144,180,170,219,195,48,201,39,214,95,201,62,254,53,155,76,96,217,24,147,131,56,45,249,19,59,255,181,55,68,220,160,225,181,105,115,30,248,31,168,181,212,78,195,49,130,181,209,198,61,168,192,24,226,200,100,199,29,87,220,144,229,21,66,215,83,7,78,87,32,20,61,247,139,241,240,116,33,167,57,11,124,112,13,15,142,22,91,34,75,221,174,222,182,143,246,77,95,182,101,116,33,175,183,80,149,206,171,185,137,98,181,15,49,10,57,179,120,66,218,201,37,168,18,135,251,35,13,175,125,123,20,111,167,219,71,248,246,173,41,237,220,150,167,134,136,163,213,155,61,186,66,239,136,154,182,248,29,237,35,123,167,239,82,233,203,84,14,59,252,123,244,54,185,203,56,85,151,78,39,29,91,239,214,167,118,204,94,81,240,110,249,124,245,165,45,204,242,0,157,121,57,62,207,196,221,32,157,16,26,164,166,213,132,186,82,244,185,92,127,162,89,138,247,141,113,124,142,142,252,198,184,183,179,213,174,181,203,109,245,227,188,1,66,134,113,252,230,0,241,43,205,209,91,240,225,141,199,215,241,141,37,236,217,198,51,103,227,222,119,191,156,27,74,242,221,232,202,13,108,181,84,172,153,227,170,213,30,200,232,220,77,128,189,215,207,113,7,7,56,253,128,219,243,18,169,8,156,174,173,14,117,15,20,222,186,105,79,106,97,21,143,140,189,49,122,176,67,8,204,201,59,124,48,78,13,61,219,202,150,70,214,131,158,109,15,159,203,214,135,101,207,182,140,21,45,63,100,23,195,143,54,246,29,70,109,37,204,3,209,175,3,64,206,23,89,211,188,175,234,169,255,150,162,43,57,169,20,188,133,181,26,227,236,161,115,117,101,31,66,203,87,191,145,17,231,135,220,16,115,3,20,161,99,161,103,68,28,187,66,206,140,247,176,247,141,159,16,32,225,212,103,40,233,209,115,100,154,213,59,214,53,247,144,114,217,115,46,126,57,103,141,193,179,138,104,240,111,9,13,88,170,222,201,167,79,72,177,189,181,227,192,131,247,86,233,197,253,129,148,114,213,52,250,145,152,78,118,76,115,167,159,50,106,76,204,86,225,248,120,134,123,66,130,30,165,89,101,142,60,236,110,167,214,135,54,86,235,231,109,104,98,173,198,109,173,167,13,68,240,212,171,138,37,43,98,193,31,204,143,63,146,65,83,234,8,201,244,150,160,212,19,29,222,86,101,124,51,83,188,161,48,77,49,167,114,61,23,218,76,252,243,159,31,118,143,1,166,254,139,186,186,168,9,36,197,134,49,184,165,63,231,55,97,101,122,57,110,219,235,190,181,232,180,237,125,7,32,143,93,136,68,205,45,147,119,234,157,143,47,11,179,19,246,14,25,192,183,147,41,181,129,91,22,193,210,177,56,113,88,172,67,158,242,106,244,1,130,106,62,192,229,78,45,27,122,195,40,79,116,248,246,93,102,77,210,94,18,189,161,236,92,225,182,72,75,245,91,218,80,30,87,130,128,9,175,42,230,59,76,234,60,39,239,89,42,112,68,0,58,117,122,57,149,75,38,120,143,170,131,162,29,56,151,57,80,60,8,36,166,28,152,121,227,248,133,13,53,50,216,56,134,175,141,233,83,230,56,180,150,63,238,81,113,150,45,188,27,233,139,203,170,36,162,198,209,44,203,11,52,29,196,222,104,183,226,18,251,46,78,171,216,129,54,167,228,29,232,154,114,6,141,240,104,182,151,89,155,76,178,50,57,35,201,116,49,47,32,112,136,52,144,222,66,114,7,228,223,252,242,232,228,248,1,87,64,35,238,17,246,46,40,165,200,123,150,239,73,226,25,170,203,116,92,196,195,253,24,100,88,192,26,119,157,115,57,141,170,167,111,243,185,142,25,219,43,89,102,187,227,115,209,229,94,1,183,46,174,126,164,188,26,138,67,152,97,229,9,219,132,175,216,160,128,133,58,231,51,220,198,226,248,111,255,74,225,62,146,188,166,148,22,61,56,144,246,98,206,121,147,100,124,33,68,224,30,119,202,3,11,228,8,45,213,136,17,69,170,49,246,205,15,76,202,115,125,243,126,28,190,81,166,216,131,45,122,48,218,115,140,96,168,17,253,49,78,99,155,141,78,29,209,69,16,131,212,211,212,142,57,112,61,148,227,134,87,173,161,21,34,109,141,90,164,72,97,67,222,166,160,74,199,116,57,15,18,7,234,155,71,0,30,51,98,153,206,58,244,208,21,181,208,80,51,38,108,134,182,228,137,183,97,194,74,182,97,63,28,51,233,31,213,217,171,188,45,212,165,163,159,196,111,195,224,121,12,213,164,15,253,39,248,83,56,177,33,222,97,75,245,209,13,16,107,59,220,226,221,245,170,206,58,30,70,199,176,61,169,10,108,29,242,224,211,65,56,105,87,147,183,201,8,61,195,18,240,117,88,198,211,82,8,46,253,88,7,171,56,214,193,109,110,251,40,144,83,29,138,195,238,132,68,115,28,195,184,52,236,64,108,136,153,96,26,140,127,25,91,69,114,127,150,135,53,174,226,6,24,250,77,242,243,110,118,30,9,137,180,60,37,97,142,21,243,169,244,242,104,108,105,244,237,237,87,90,217,9,28,239,88,251,3,188,252,241,171,116,10,174,232,216,91,219,55,167,60,131,155,246,231,117,237,144,233,196,118,157,14,154,252,125,1,77,171,249,6,113,23,116,80,79,199,30,7,225,151,114,76,162,55,76,156,174,45,135,143,142,149,99,78,125,92,23,135,173,80,59,12,14,224,249,149,99,208,213,136,195,49,195,81,44,220,250,167,100,78,82,113,219,213,195,137,90,138,139,239,157,169,68,245,198,160,99,74,77,170,143,111,106,179,174,41,31,147,191,57,22,223,197,224,89,19,5,72,103,72,140,154,176,202,31,169,33,145,25,27,131,225,45,58,26,83,13,184,204,196,47,248,253,12,239,204,117,215,157,241,150,215,86,196,241,235,57,75,144,201,151,53,47,169,192,46,196,80,40,246,152,95,183,219,43,228,181,18,14,253,151,190,24,212,51,74,217,140,2,250,154,175,1,217,225,133,189,79,72,205,253,89,246,14,119,244,185,1,78,19,159,35,188,219,154,196,250,33,222,76,10,112,164,83,161,219,158,80,253,135,222,54,86,139,123,221,45,248,29,20,212,230,126,176,141,14,183,84,207,34,226,134,223,121,111,18,152,55,181,144,83,136,135,254,161,217,110,105,160,182,48,124,186,43,247,193,48,213,49,18,9,248,58,231,175,75,198,175,171,140,158,8,45,216,253,110,241,216,234,81,9,185,60,56,158,182,117,85,136,27,159,144,165,171,206,207,22,236,58,228,2,86,64,38,167,29,154,217,66,251,38,115,165,173,41,74,85,239,187,251,23,122,154,70,34,21,86,135,98,230,129,69,106,149,0,33,92,248,178,123,105,198,93,90,235,103,4,188,46,51,98,239,1,205,141,82,79,253,64,154,5,125,151,62,120,161,216,148,26,157,23,86,61,65,123,187,110,100,123,242,216,87,113,155,195,18,186,243,42,220,20,128,148,47,101,234,71,182,191,40,26,149,65,69,85,153,217,28,18,10,79,135,15,35,115,70,29,253,89,101,53,145,130,56,225,146,142,153,173,219,232,120,198,72,122,192,207,139,248,5,219,254,61,51,61,176,145,157,242,230,70,175,125,252,170,236,210,7,92,39,207,155,75,50,189,197,158,211,228,67,202,142,53,16,166,6,224,201,109,96,198,67,26,65,164,86,110,29,156,3,129,233,120,44,162,166,164,108,70,58,179,212,213,232,228,241,227,68,124,99,161,249,77,122,178,168,69,117,53,152,15,34,153,59,194,175,186,162,184,1,251,81,67,41,194,108,85,86,76,129,85,158,101,121,137,31,225,48,163,215,119,140,116,26,20,75,157,135,108,183,189,239,231,242,221,51,96,246,28,3,163,177,199,253,90,92,224,218,157,203,212,103,149,236,236,171,156,204,205,155,55,189,159,10,237,149,14,71,86,237,249,36,27,231,115,253,147,225,104,109,108,137,151,169,4,91,40,219,164,38,19,106,105,203,128,106,123,69,188,249,105,52,79,49,26,227,12,213,34,0,75,207,116,19,161,236,120,221,4,107,23,65,193,198,80,220,63,105,15,221,203,65,105,180,139,7,137,154,85,35,238,47,167,162,237,53,16,27,46,83,204,244,110,167,94,159,50,136,196,105,136,204,249,96,162,26,166,13,81,45,65,62,247,64,149,162,163,119,164,190,2,166,202,181,163,53,222,75,93,46,43,191,39,41,191,120,171,66,163,93,44,41,255,250,57,249,185,12,242,100,228,231,10,64,248,137,7,175,220,198,214,195,26,135,154,64,170,220,42,13,61,11,203,77,94,249,28,172,251,188,33,110,109,188,111,232,121,171,80,10,247,126,10,236,161,138,59,57,250,48,41,22,84,97,144,18,180,65,58,171,82,251,249,59,30,55,249,250,172,245,228,140,231,177,38,245,154,143,249,176,9,39,119,241,162,234,74,143,207,250,102,184,254,187,179,76,88,49,63,133,225,127,96,75,198,253,23,30,205,223,119,177,80,62,192,163,60,179,14,0,92,119,113,215,110,245,103,98,87,204,214,214,247,34,227,77,191,39,169,74,55,251,242,238,82,239,89,169,58,241,39,126,44,71,15,164,225,211,24,237,62,241,99,96,187,3,190,51,73,169,94,232,126,216,198,26,189,4,118,25,193,191,118,146,152,208,192,107,188,99,236,125,75,203,71,201,99,27,245,62,199,131,166,255,143,128,255,49,8,24,71,61,36,131,250,197,178,32,145,177,81,151,168,249,62,181,10,58,21,178,9,75,170,37,30,46,21,231,64,194,17,207,124,251,92,7,155,74,207,255,123,138,52,86,144,171,61,186,235,235,31,96,233,137,29,247,203,201,77,46,54,253,39,162,93,50,148,53,53,207,126,93,185,143,207,57,3,45,87,109,199,174,130,44,221,18,157,38,186,249,15,23,5,60,47,10,70,129,78,234,252,21,159,43,160,238,253,60,251,43,208,61,109,134,109,168,159,200,248,233,69,250,28,221,111,224,28,4,236,16,247,169,98,49,156,99,44,25,183,254,2,122,255,154,105,78,98,185,51,214,90,114,11,37,221,190,172,36,161,225,222,122,244,117,88,246,234,73,31,2,46,247,50,56,67,121,185,154,107,60,19,222,101,254,132,246,58,50,243,213,45,116,126,29,88,13,41,93,127,191,89,12,251,58,119,210,93,214,27,217,76,233,32,18,14,88,238,34,26,111,214,91,20,117,21,41,137,16,194,97,244,170,136,45,68,34,139,37,39,105,156,114,173,227,163,242,154,190,55,2,51,39,48,21,2,153,188,7,112,153,155,139,65,175,10,252,181,217,45,162,70,255,118,219,253,124,239,23,127,211,82,66,20,109,125,95,182,182,70,74,223,212,217,124,31,162,88,149,210,105,215,96,57,14,157,65,100,109,54,207,244,37,153,85,239,72,184,90,220,75,40,24,80,163,31,141,213,105,139,110,32,29,157,254,10,130,100,51,142,84,47,236,235,251,85,63,127,146,108,123,10,155,203,165,106,197,87,24,137,159,150,138,179,240,180,236,29,111,225,105,235,143,187,144,38,80,178,130,215,176,143,41,162,224,26,7,155,249,45,17,28,160,225,58,9,204,116,192,209,71,164,69,53,199,80,95,202,162,56,232,76,163,102,4,144,246,188,85,114,19,26,185,162,41,221,189,109,110,15,6,150,178,174,99,14,61,57,220,123,196,253,157,231,164,152,54,252,181,230,51,66,74,161,250,243,91,77,42,74,111,212,140,233,70,91,67,99,219,220,144,249,191,253,67,33,20,34,40,125,66,191,153,32,193,127,211,140,226,55,145,41,252,243,203,46,141,78,255,97,41,192,113,202,217,175,33,255,119,151,184,247,130,229,79,0,30,151,254,241,142,66,221,172,151,254,219,140,200,92,46,1,166,27,72,185,124,84,166,27,113,169,118,36,26,106,96,162,159,85,152,254,152,53,60,214,142,34,223,232,86,232,220,94,87,251,244,73,141,26,60,229,231,15,157,39,187,54,36,169,245,52,79,164,11,186,194,86,145,131,109,174,104,246,5,109,232,99,119,46,59,167,123,220,7,142,99,53,204,103,87,151,59,204,55,123,69,39,249,238,211,27,232,58,201,166,114,125,162,200,6,142,93,83,25,219,176,127,197,19,74,89,49,14,210,230,146,55,30,104,3,43,192,96,19,7,115,74,255,128,33,52,25,116,198,5,12,28,176,214,209,70,204,36,90,74,177,199,243,92,77,193,239,27,23,224,215,206,117,103,66,112,151,35,103,218,230,33,100,95,191,151,238,121,173,131,59,113,110,199,39,217,167,83,243,152,78,130,236,209,118,122,247,133,49,166,167,237,112,35,166,131,186,214,94,182,206,41,90,196,173,207,218,244,59,196,131,108,232,246,145,29,196,114,55,236,153,233,45,106,62,76,50,90,15,114,33,92,201,138,252,188,143,29,254,237,29,166,58,29,130,23,66,251,126,145,12,40,63,207,75,120,119,8,7,30,245,55,53,58,105,189,147,212,215,55,54,228,230,120,204,141,126,2,65,198,97,5,229,1,143,207,84,120,124,82,22,87,234,249,155,245,99,190,56,244,144,114,193,115,71,225,17,104,226,187,129,155,10,167,62,152,124,143,77,121,129,143,72,168,205,157,1,247,100,145,190,20,238,107,198,9,44,119,82,240,229,15,74,157,24,14,239,201,105,143,104,232,149,35,93,54,16,32,38,123,247,204,33,18,245,98,180,242,69,240,108,46,118,196,196,138,190,113,48,130,119,173,43,74,125,171,211,47,136,231,235,57,210,214,172,65,221,170,241,11,190,190,177,43,158,56,21,220,127,244,54,10,115,83,196,214,195,188,142,98,243,234,189,249,28,253,58,110,14,201,172,162,166,134,54,110,28,35,224,105,62,249,145,20,115,110,236,81,91,72,189,245,45,238,139,141,192,128,166,99,3,123,167,243,54,160,25,26,83,176,111,192,201,11,182,207,72,123,89,77,155,237,228,184,228,109,121,113,46,126,113,217,197,57,177,138,63,127,115,153,79,46,233,192,251,4,209,198,212,39,201,54,107,122,168,55,4,67,81,214,12,58,127,144,181,190,101,229,9,178,54,163,172,13,245,221,60,250,228,236,41,174,162,132,117,20,139,211,4,2,20,55,30,233,167,75,61,71,227,12,178,149,194,93,250,216,85,66,71,90,61,196,90,237,133,95,219,250,60,186,210,205,105,75,189,244,37,241,34,148,72,63,137,2,40,122,188,124,131,17,165,177,77,171,190,136,186,46,194,152,126,200,40,194,12,156,105,174,131,60,218,67,200,195,81,140,228,153,106,4,53,118,191,5,237,36,189,192,98,126,137,213,244,79,120,51,75,234,42,237,131,213,156,27,182,234,238,160,128,111,9,215,142,231,189,145,59,15,182,82,235,95,255,175,242,140,178,183,162,53,232,175,107,129,19,97,70,146,76,229,32,15,42,90,18,130,201,162,174,73,217,10,87,172,205,192,15,116,169,106,165,94,45,19,77,213,239,29,220,25,115,150,155,21,172,131,251,198,114,71,46,41,134,141,67,187,101,184,193,210,33,105,24,129,29,62,162,194,30,149,253,16,139,124,92,134,149,52,27,100,29,155,100,27,250,134,190,207,234,183,144,98,28,108,190,31,8,253,198,56,100,4,47,120,130,46,26,63,183,82,220,192,41,95,134,15,117,71,62,192,161,42,95,196,175,145,191,132,152,137,241,4,147,214,231,27,150,5,242,57,33,83,145,2,232,211,39,172,238,55,44,177,100,184,88,38,100,212,53,44,117,74,133,63,216,175,85,45,253,156,41,106,97,31,105,172,163,202,119,177,22,244,186,233,192,200,110,26,127,136,167,199,13,111,74,114,7,214,219,94,42,137,101,143,7,119,6,206,160,188,138,62,84,20,191,119,18,187,83,57,227,159,49,134,111,11,96,126,73,253,106,144,209,201,235,232,211,65,50,73,135,5,137,120,122,193,250,202,178,100,249,71,193,239,168,24,5,235,62,241,18,152,184,153,170,47,48,245,141,1,197,36,0,60,167,214,13,152,223,46,252,178,139,229,231,167,209,228,146,171,41,100,95,116,150,78,30,197,222,140,216,126,167,71,39,113,183,8,114,153,55,125,84,192,3,215,116,111,132,15,242,196,194,190,18,158,62,216,87,162,18,243,246,80,205,150,209,134,172,169,174,119,92,140,132,228,38,31,108,221,212,83,213,131,104,42,179,193,210,15,86,15,86,124,179,122,16,123,182,26,175,34,250,43,180,2,246,254,109,106,25,124,73,221,188,115,243,173,8,1,4,143,55,19,52,96,183,156,3,1,196,91,10,26,177,91,162,180,218,145,198,154,140,112,123,145,223,101,98,103,85,111,88,142,24,120,145,141,189,9,185,139,154,12,72,248,77,67,57,154,71,58,143,33,129,13,14,34,198,96,160,55,11,160,154,245,16,24,252,23,183,87,15,128,221,243,119,121,115,148,243,31,98,102,209,144,59,230,235,21,240,159,17,61,101,91,179,240,159,19,177,102,224,166,171,243,90,74,173,53,139,73,32,249,184,76,184,78,204,92,235,29,99,89,250,117,207,177,100,162,246,185,153,163,189,99,172,168,54,14,255,173,148,187,61,6,103,32,127,123,71,147,112,14,119,107,130,170,15,43,29,47,138,232,118,159,126,240,240,39,245,199,38,130,187,69,88,7,142,237,246,167,149,181,82,252,69,146,3,175,157,25,24,165,5,254,143,10,253,232,60,110,123,177,56,43,242,137,56,94,100,127,243,163,182,83,166,116,213,87,207,100,42,67,240,108,168,164,69,118,46,193,67,68,74,48,255,31,138,234,44,43,246,230,115,117,84,33,142,59,232,74,161,3,140,163,242,34,47,245,46,219,9,43,133,187,194,127,172,225,66,135,130,15,7,184,27,158,118,43,150,250,210,211,215,150,119,138,86,12,17,190,174,199,125,119,124,72,121,36,162,129,8,41,172,252,216,69,47,146,126,89,128,218,190,83,51,195,80,112,178,158,220,76,200,141,42,65,224,65,169,221,23,123,140,250,86,88,139,220,127,105,203,120,241,212,94,52,79,192,134,28,163,3,233,209,57,151,193,34,121,104,128,236,150,121,138,224,20,251,188,219,247,46,22,201,179,50,209,0,42,78,24,92,58,88,82,33,228,150,73,184,184,16,150,62,211,17,17,129,120,159,11,47,141,39,211,196,225,61,168,17,56,16,65,37,63,253,31,114,197,0,127,145,229,181,53,116,222,146,25,4,209,1,8,6,117,65,65,42,166,11,203,212,176,49,183,18,126,13,76,91,128,84,4,80,4,202,179,178,21,121,233,29,108,99,99,164,20,6,147,36,216,255,11,125,78,224,26,93,172,0,246,211,58,145,156,120,80,42,60,34,165,242,128,176,38,72,216,177,179,126,41,175,161,80,102,153,84,26,58,43,52,148,116,49,1,86,128,67,19,126,62,57,107,42,198,249,135,15,210,123,127,77,239,179,44,162,75,4,29,140,135,227,95,108,62,202,34,223,187,26,203,197,237,63,20,126,235,224,122,224,97,223,180,129,60,145,82,221,163,40,8,145,216,82,11,159,190,199,212,16,228,33,196,30,50,29,228,233,55,235,199,232,87,32,205,99,235,57,25,241,121,219,125,53,222,213,64,218,172,102,79,3,234,36,182,58,135,237,123,58,71,176,249,116,50,87,116,117,108,112,231,142,76,220,142,78,182,121,198,207,134,215,232,183,226,158,126,217,190,2,84,148,172,140,167,10,155,36,171,73,66,233,168,133,247,230,160,200,24,251,12,44,65,170,163,36,139,50,111,5,16,221,137,21,197,133,7,35,167,98,18,73,170,136,33,61,230,73,112,5,108,212,152,164,171,154,79,64,1,226,85,120,57,247,43,133,58,220,10,101,117,140,38,58,214,96,4,111,33,216,43,27,138,78,181,235,177,171,28,209,193,213,149,13,164,20,120,117,154,142,110,120,31,166,112,93,70,97,29,33,157,148,248,212,81,87,206,176,135,233,0,2,17,93,5,212,176,155,136,247,232,26,32,235,103,121,3,14,5,81,238,15,248,98,21,233,118,201,74,145,40,44,254,213,252,72,191,125,243,205,255,1,185,28,47,131,200,210,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateLDAPLicenseLogLocalizableString());
			LocalizableStrings.Add(CreateLDAPLicenseNotificationLocalizableString());
			LocalizableStrings.Add(CreateEmailSubjectLocalizableString());
			LocalizableStrings.Add(CreateLDAPEmailMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateLDAPLicenseLogLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cfc4bccf-ff95-411e-821a-4e6f18bf14c1"),
				Name = "LDAPLicenseLog",
				CreatedInPackageId = new Guid("7c904ad4-e292-4453-b17c-60a3882c9384"),
				CreatedInSchemaUId = new Guid("8b1112e7-8eb1-417c-8d5f-1d425a56c066"),
				ModifiedInSchemaUId = new Guid("8b1112e7-8eb1-417c-8d5f-1d425a56c066")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLDAPLicenseNotificationLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3c6db6be-eaa1-4b2e-8638-a48c219070a4"),
				Name = "LDAPLicenseNotification",
				CreatedInPackageId = new Guid("7c904ad4-e292-4453-b17c-60a3882c9384"),
				CreatedInSchemaUId = new Guid("8b1112e7-8eb1-417c-8d5f-1d425a56c066"),
				ModifiedInSchemaUId = new Guid("8b1112e7-8eb1-417c-8d5f-1d425a56c066")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmailSubjectLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("97b265de-9332-443f-a2d2-80ab418ee98e"),
				Name = "EmailSubject",
				CreatedInPackageId = new Guid("7c904ad4-e292-4453-b17c-60a3882c9384"),
				CreatedInSchemaUId = new Guid("8b1112e7-8eb1-417c-8d5f-1d425a56c066"),
				ModifiedInSchemaUId = new Guid("8b1112e7-8eb1-417c-8d5f-1d425a56c066")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLDAPEmailMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("de602e4d-9774-4a92-af9a-080611eba58e"),
				Name = "LDAPEmailMessage",
				CreatedInPackageId = new Guid("7c904ad4-e292-4453-b17c-60a3882c9384"),
				CreatedInSchemaUId = new Guid("8b1112e7-8eb1-417c-8d5f-1d425a56c066"),
				ModifiedInSchemaUId = new Guid("8b1112e7-8eb1-417c-8d5f-1d425a56c066")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b1112e7-8eb1-417c-8d5f-1d425a56c066"));
		}

		#endregion

	}

	#endregion

}

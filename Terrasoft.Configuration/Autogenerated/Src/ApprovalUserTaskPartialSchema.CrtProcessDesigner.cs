﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApprovalUserTaskPartialSchema

	/// <exclude/>
	public class ApprovalUserTaskPartialSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApprovalUserTaskPartialSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApprovalUserTaskPartialSchema(ApprovalUserTaskPartialSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6035e251-52fb-4af6-9245-ea29e5c426b2");
			Name = "ApprovalUserTaskPartial";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("dce8bec2-6e2f-4ee6-9a95-98b71b1b3746");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,28,93,115,227,182,241,217,157,233,127,64,212,206,148,158,81,233,52,143,231,143,140,207,167,187,170,61,223,185,182,147,62,116,58,25,90,130,100,54,20,169,0,148,109,245,226,255,222,93,96,241,73,144,210,185,215,78,166,205,203,89,192,98,177,187,216,47,44,150,169,139,21,151,235,98,198,217,45,23,162,144,205,162,205,47,26,193,243,43,209,204,184,148,240,163,94,148,203,141,40,218,178,169,127,253,171,79,191,254,213,193,70,150,245,146,221,108,101,203,87,199,209,111,128,175,42,62,67,96,153,191,227,53,23,229,204,193,44,171,230,174,168,94,189,186,104,86,171,166,206,223,55,203,37,12,187,249,15,252,177,133,133,72,196,159,100,83,187,9,159,56,92,154,158,241,40,77,3,0,95,111,94,247,78,77,234,182,108,75,46,123,1,222,22,179,182,17,67,16,36,181,212,252,101,81,86,249,13,175,231,92,184,105,92,4,130,187,225,109,11,63,37,59,85,35,33,43,185,7,224,86,190,41,218,2,192,90,1,52,193,50,183,207,135,77,9,219,136,135,114,198,47,155,57,175,114,31,18,214,3,134,223,8,190,4,196,108,82,111,86,175,216,100,5,148,93,137,18,56,107,183,106,254,232,232,136,157,200,205,106,85,136,237,25,253,62,95,175,69,243,192,5,107,183,107,206,154,5,43,212,64,81,229,102,193,145,183,98,189,185,171,202,25,227,176,129,93,121,11,11,113,71,152,70,45,234,236,162,6,38,171,117,213,108,57,207,45,132,143,246,192,76,3,199,95,143,21,173,195,104,216,170,168,139,37,23,59,208,93,106,40,192,250,135,33,172,215,77,213,71,24,78,193,242,111,224,239,103,45,99,56,105,45,230,64,228,23,85,33,229,43,146,73,81,125,39,65,46,133,252,241,178,152,137,70,254,145,87,107,46,20,60,9,112,134,224,131,208,236,21,123,167,172,42,68,129,34,70,186,204,190,151,188,189,111,230,176,51,104,104,11,246,201,231,122,126,109,126,50,60,34,81,206,57,147,173,64,5,123,199,91,141,242,251,162,218,240,236,207,124,171,254,184,42,74,113,162,65,198,4,122,6,82,70,192,67,166,206,245,64,240,118,35,106,26,204,213,42,212,91,18,76,44,153,151,136,171,87,75,175,10,209,150,69,69,114,3,45,141,87,142,89,123,95,180,172,132,131,231,43,94,183,108,35,81,167,97,134,137,13,216,255,138,179,59,126,95,60,148,205,70,12,105,246,58,216,168,75,95,44,127,48,64,217,22,117,171,78,160,124,40,90,62,168,189,96,145,12,188,233,186,2,64,176,34,240,75,91,38,103,247,124,85,176,26,60,118,143,18,174,53,102,54,195,205,204,57,42,100,183,132,235,70,225,248,0,40,64,89,71,193,212,232,120,128,162,219,98,201,22,141,96,75,237,135,24,15,41,116,66,172,138,122,185,1,91,98,101,203,193,125,53,125,150,183,155,84,35,203,247,132,113,74,8,145,148,152,118,3,107,120,136,180,201,158,194,219,146,87,243,248,8,12,41,112,62,45,156,172,224,197,188,169,171,45,155,66,120,98,63,84,13,110,7,127,146,143,128,160,214,98,220,226,34,27,145,183,31,29,238,216,22,224,192,40,49,180,244,108,125,137,76,162,143,134,163,214,65,102,203,126,152,5,191,143,123,207,230,114,83,181,165,19,60,45,99,11,189,174,79,254,90,141,83,27,39,198,112,133,182,109,80,0,118,122,22,19,199,190,253,150,101,241,216,41,171,249,99,10,91,134,199,5,67,181,206,19,14,15,21,111,7,50,141,250,148,61,236,240,32,61,114,142,252,156,150,244,160,43,253,97,229,253,58,14,221,227,224,194,224,71,40,40,31,37,138,9,101,50,136,75,47,63,56,8,133,4,98,8,7,198,14,236,124,190,42,235,235,114,121,223,98,2,177,40,42,201,245,228,115,40,216,128,148,151,138,85,233,77,164,189,10,239,228,169,197,228,102,238,160,205,142,221,153,126,101,54,176,108,109,129,201,101,131,143,1,112,8,233,51,193,23,167,35,95,102,163,163,179,97,45,239,35,176,111,66,137,205,137,44,177,82,41,124,239,44,169,126,207,116,118,184,203,97,120,209,58,225,45,222,109,202,57,134,103,147,189,76,231,153,9,189,15,133,96,146,99,2,254,122,59,157,179,83,173,7,217,141,26,58,68,162,244,159,177,9,230,183,205,58,251,195,33,233,20,38,241,155,85,157,141,166,243,17,141,229,111,69,179,202,70,144,138,42,109,251,174,46,91,59,245,215,123,46,184,6,206,167,114,242,211,166,168,50,141,33,135,120,12,177,6,60,119,230,136,53,246,174,216,224,118,24,132,230,40,207,39,79,124,182,193,120,85,84,133,56,65,208,179,140,214,149,11,150,185,101,176,227,135,6,69,209,110,65,174,198,122,40,5,113,96,122,233,115,71,72,232,153,192,209,252,183,101,101,183,253,60,145,37,165,101,113,13,9,45,45,144,231,97,197,162,144,247,197,245,203,9,77,174,70,99,182,75,116,249,185,84,144,6,102,10,104,197,159,154,18,214,27,74,9,8,96,242,143,53,254,11,88,83,50,166,13,189,169,157,56,57,225,228,184,208,74,196,199,25,243,224,225,74,49,98,16,74,222,75,101,60,19,42,143,94,248,127,110,110,255,147,154,67,7,220,171,24,191,28,23,241,125,41,139,143,143,117,224,28,212,220,131,155,0,2,112,40,87,218,66,169,200,99,217,206,238,89,150,197,69,129,67,127,192,234,213,172,144,188,83,63,200,13,211,175,72,39,162,45,195,192,120,76,64,119,144,215,255,120,188,15,90,58,169,157,216,61,239,184,255,38,88,39,72,99,198,25,99,56,1,166,103,255,116,188,53,169,227,121,104,224,8,222,150,85,101,82,76,173,49,50,155,232,59,164,190,74,250,222,220,148,113,8,224,148,101,175,129,112,60,222,67,13,172,137,8,193,242,143,119,255,64,243,124,192,107,228,213,70,172,27,201,147,112,223,199,194,11,244,38,185,100,42,207,171,170,121,228,243,219,230,13,168,239,18,217,58,101,137,209,158,213,215,252,167,77,41,248,252,77,185,44,219,162,186,41,151,117,1,162,211,72,250,38,211,184,144,230,239,204,153,160,31,236,231,14,77,52,114,138,17,240,219,70,204,248,13,111,245,137,232,162,202,200,195,0,54,95,111,170,202,232,210,94,82,105,5,101,240,164,36,9,26,245,141,63,215,87,126,184,55,163,131,36,136,145,37,85,185,104,93,94,136,239,25,186,42,186,213,104,188,59,240,84,213,51,102,252,245,22,36,148,249,64,240,187,135,137,152,251,107,190,0,127,7,72,92,89,2,164,32,29,197,123,226,209,195,74,132,215,124,214,136,185,165,224,153,113,184,13,25,54,125,42,53,2,182,42,100,139,236,170,31,167,44,45,60,50,34,100,91,179,123,233,173,218,155,93,127,171,46,161,9,99,38,147,188,0,87,208,242,243,0,119,32,112,146,152,57,205,192,212,49,8,16,19,10,13,45,143,98,44,133,14,77,118,250,70,25,128,0,103,111,248,194,99,78,26,99,78,249,30,114,58,97,148,113,190,37,226,218,47,87,231,128,14,100,70,34,184,105,193,86,165,30,202,84,176,145,106,4,132,232,57,180,133,94,162,175,96,41,100,164,12,250,23,58,102,128,77,192,225,12,190,54,172,11,193,245,8,93,185,223,243,69,59,121,90,11,46,165,190,152,119,54,66,15,234,65,152,27,189,27,162,93,253,67,252,203,134,139,109,8,145,251,154,106,238,251,250,215,85,209,222,99,21,76,139,100,68,215,125,130,209,68,151,210,238,163,201,15,135,115,149,81,208,10,117,212,255,29,158,108,238,98,24,178,3,169,93,221,164,217,240,0,231,149,206,165,142,46,152,204,81,71,204,54,7,106,24,205,129,116,134,198,159,73,118,218,10,3,29,213,154,148,210,81,87,34,135,157,231,37,218,16,238,156,117,245,208,61,135,25,246,74,245,171,16,91,91,69,79,40,159,77,202,92,242,188,127,198,188,243,102,138,81,135,52,39,190,195,131,121,213,24,25,226,148,83,213,175,51,140,55,174,92,135,123,155,132,242,154,23,115,176,74,161,254,193,106,19,157,87,96,166,32,2,13,144,191,11,92,35,229,161,138,80,114,165,41,195,181,150,157,112,7,214,19,208,250,88,250,249,249,124,110,129,224,74,113,163,100,159,141,62,140,14,199,132,216,120,98,79,242,122,66,246,59,19,249,89,222,68,255,249,78,52,155,181,241,37,205,178,132,84,252,227,154,235,183,62,93,106,14,134,144,82,64,243,209,24,204,180,229,43,229,149,35,14,19,10,140,111,168,64,7,228,159,45,62,9,150,69,85,254,147,235,212,45,35,214,204,249,95,243,117,85,204,192,209,9,105,67,251,199,69,54,250,4,49,245,183,163,79,159,62,81,173,155,208,53,226,187,182,172,212,107,105,240,190,72,82,81,207,54,24,192,159,199,116,162,169,60,245,2,55,169,162,192,166,20,198,4,82,231,217,19,241,238,133,169,138,217,47,78,86,94,28,54,213,5,153,114,60,14,183,27,180,177,55,175,149,54,143,125,78,108,182,197,211,89,204,84,106,129,112,92,167,44,237,120,16,254,134,180,25,160,93,196,165,87,166,220,160,138,112,12,197,118,187,79,241,192,51,53,62,144,155,168,3,196,215,108,245,14,147,189,47,101,123,98,94,3,5,159,241,117,9,216,228,152,81,213,193,123,171,113,103,218,138,173,205,204,16,226,18,244,11,95,48,86,244,175,49,116,127,50,243,145,199,120,137,15,210,101,93,126,133,212,132,240,153,105,52,108,245,236,36,54,248,194,112,46,150,27,124,9,52,86,126,209,157,202,70,155,224,224,65,226,73,77,80,168,21,81,23,85,25,60,97,40,131,160,159,168,146,39,147,14,212,89,150,34,170,131,89,119,16,16,173,127,108,87,149,47,29,61,153,117,73,232,35,216,67,169,122,19,140,172,2,5,124,102,179,66,221,218,39,79,32,123,229,166,220,21,29,31,200,242,137,16,13,108,107,176,162,69,124,53,93,214,141,208,103,167,166,237,243,48,28,252,189,104,30,143,131,192,155,74,127,125,157,72,104,66,172,115,229,62,58,71,145,91,26,41,194,89,104,246,21,106,8,18,152,171,100,145,75,240,81,77,188,75,49,242,25,185,32,116,55,242,45,87,151,202,73,93,220,129,9,102,233,183,74,245,108,103,30,55,191,255,102,228,249,135,238,126,154,210,96,137,1,200,34,78,199,8,105,87,83,173,194,22,128,178,67,147,16,237,251,216,234,31,234,62,204,2,140,182,60,16,166,202,140,138,202,102,113,210,227,242,160,239,121,36,183,68,96,194,144,16,6,238,139,241,116,158,72,33,220,90,155,74,60,39,110,130,189,34,158,116,39,98,1,251,94,209,234,211,70,69,85,15,199,141,30,201,18,59,153,4,74,47,189,107,230,254,222,175,225,231,192,34,244,3,206,63,162,15,8,204,196,100,35,16,130,84,249,15,53,155,14,252,182,81,233,151,53,19,61,106,250,126,48,115,247,251,128,242,15,141,88,217,251,193,141,101,143,24,165,241,215,154,118,100,193,100,39,18,125,18,141,163,15,73,164,37,68,127,111,94,16,251,239,128,67,238,253,240,211,109,106,244,193,236,104,255,196,0,128,135,147,2,229,118,169,186,128,110,124,35,4,252,60,183,65,61,134,162,206,10,143,24,85,199,48,165,89,71,122,78,34,242,159,49,149,94,243,167,54,180,108,127,193,216,219,102,108,9,35,209,247,217,211,97,98,119,119,160,49,1,87,85,81,214,253,84,208,194,127,131,144,222,171,148,83,255,126,191,27,185,113,178,29,253,203,175,51,235,71,139,174,141,127,117,170,139,108,198,80,8,193,190,78,134,162,77,54,66,50,71,129,35,32,221,70,132,123,176,105,188,195,222,156,58,7,243,114,102,29,142,207,230,151,232,77,178,76,104,83,92,19,33,61,126,117,40,78,163,73,153,246,162,137,252,41,225,156,241,8,96,38,122,189,240,214,32,71,201,188,189,39,113,76,210,238,21,50,250,41,72,220,81,76,71,225,202,118,22,238,118,73,158,51,81,28,43,239,30,83,145,17,198,113,220,190,101,204,28,24,135,200,107,238,254,190,162,70,83,209,153,154,194,156,252,105,88,127,83,233,82,42,185,242,33,122,213,54,234,127,205,111,197,22,31,9,212,5,39,62,52,85,182,192,46,218,187,230,201,44,128,76,188,217,180,172,209,138,173,58,90,92,134,161,244,107,21,46,80,110,92,105,222,161,235,127,9,203,44,108,239,10,139,43,177,116,133,50,178,101,24,93,115,49,132,111,235,153,37,222,130,80,245,37,5,179,243,165,183,195,160,41,208,28,164,207,33,40,219,208,59,224,13,217,121,96,222,120,62,93,20,248,0,12,78,229,163,136,159,59,84,82,175,117,214,92,19,140,92,168,93,176,32,34,74,137,143,140,224,114,216,197,61,159,253,200,126,151,56,216,223,49,169,250,201,129,94,106,141,86,199,149,118,64,29,34,143,181,242,70,58,28,92,24,64,205,206,55,237,125,19,172,227,50,40,225,193,16,100,220,100,137,254,106,35,40,44,138,82,97,68,155,232,196,235,42,197,124,250,198,84,42,208,112,124,8,191,190,183,182,233,241,37,111,139,105,189,192,76,45,155,18,226,171,206,236,97,136,93,35,10,200,176,107,188,242,163,219,5,176,119,183,212,239,83,152,0,216,41,67,99,26,181,195,17,224,203,223,150,245,252,181,74,12,178,81,87,194,230,0,81,185,28,130,56,82,145,61,83,15,216,214,148,110,125,234,180,143,176,40,140,206,219,35,75,94,111,92,209,202,71,21,105,64,236,119,2,42,204,237,41,222,56,80,72,77,68,202,141,118,84,144,222,135,101,143,22,106,247,227,185,166,193,119,115,124,224,75,190,56,107,162,191,197,29,241,167,191,25,57,56,114,69,175,252,7,238,20,152,230,54,186,122,239,176,146,253,42,197,20,60,180,171,232,43,20,27,71,165,99,223,200,191,155,170,133,233,246,20,210,10,85,3,86,96,209,213,48,140,128,253,167,71,167,177,67,68,3,221,16,201,247,239,47,81,226,167,251,253,200,100,5,212,129,66,127,107,104,10,68,6,116,119,183,210,199,16,113,216,186,18,192,14,117,43,197,128,195,209,204,19,216,161,65,116,94,207,187,104,206,85,251,193,16,42,255,177,194,70,138,42,202,84,211,223,121,40,104,105,91,97,84,79,53,126,103,83,206,241,170,179,40,65,113,189,86,84,125,68,163,163,51,86,82,165,185,167,233,90,141,40,207,161,186,248,79,71,174,215,102,116,230,35,244,121,5,180,150,14,183,127,126,114,164,16,57,188,154,69,121,54,121,49,209,39,71,6,199,176,210,219,163,38,221,140,58,203,186,189,130,95,68,175,59,175,88,191,108,69,246,228,177,75,7,187,146,238,115,210,191,112,215,2,18,66,100,211,26,233,223,243,92,6,165,26,97,28,51,59,144,236,191,179,26,241,229,78,188,179,187,110,211,250,37,185,176,61,154,200,131,79,33,94,236,242,22,88,85,236,251,242,103,200,229,237,227,154,134,145,199,174,201,124,149,241,80,138,22,36,103,219,18,7,234,222,100,59,95,40,101,239,203,205,97,93,132,168,144,172,63,149,127,81,238,222,135,236,219,129,28,62,200,183,37,38,138,152,112,179,159,127,246,83,247,139,102,3,130,128,185,175,227,206,222,184,143,211,117,246,206,92,71,111,7,10,55,189,86,217,148,215,228,225,131,5,13,104,65,231,170,190,162,15,36,252,225,69,195,117,124,142,236,245,55,206,157,7,34,152,231,172,237,221,121,159,156,245,192,231,126,223,214,6,147,110,134,47,18,61,151,172,162,115,131,122,201,109,75,55,6,118,166,163,118,153,169,124,223,52,63,110,214,135,73,246,250,78,164,139,54,202,174,125,239,101,17,238,204,193,72,242,146,181,247,224,47,116,221,29,4,166,44,113,223,244,74,125,73,246,212,142,206,110,239,233,187,184,167,182,63,113,58,153,157,169,87,239,147,163,217,89,175,195,177,95,201,222,53,77,197,166,128,82,212,69,69,196,102,116,136,250,103,73,223,189,61,181,102,111,35,88,181,182,148,215,155,186,198,43,79,226,93,1,111,196,177,53,209,42,245,152,10,107,244,243,63,218,147,81,29,53,160,223,98,157,253,125,229,246,1,99,167,229,246,132,255,243,109,21,157,190,138,100,59,35,117,48,26,227,211,87,193,153,223,91,165,13,56,106,183,34,248,136,94,227,110,39,245,178,172,57,222,250,104,0,47,167,248,191,36,160,118,141,49,54,247,142,195,109,12,202,238,137,156,18,11,249,149,40,81,229,60,35,183,14,135,218,33,110,27,123,175,207,82,245,1,215,116,49,100,1,192,174,100,171,240,227,206,232,155,224,125,13,161,181,165,110,176,5,131,66,168,14,212,193,59,133,143,67,80,195,234,232,140,78,244,51,215,75,215,227,123,134,223,240,226,40,107,27,252,164,152,21,181,251,94,184,215,62,47,135,69,209,103,177,238,13,34,253,124,174,82,7,39,32,106,31,48,220,154,111,220,153,35,223,191,223,208,183,170,127,46,213,83,90,247,83,87,29,13,12,76,230,144,140,251,190,203,14,91,15,44,147,167,222,86,30,210,204,39,92,132,45,197,209,139,200,231,165,140,222,103,158,73,229,196,102,210,138,163,127,230,198,217,253,59,158,218,69,180,209,217,185,16,197,22,191,221,71,124,174,70,168,234,191,114,208,125,99,186,140,222,123,204,192,243,17,5,236,17,18,48,185,153,161,253,47,32,229,217,18,193,160,25,69,61,119,198,47,213,247,237,171,230,65,113,210,168,205,107,244,221,224,50,214,236,17,238,3,102,71,89,180,165,4,125,159,31,179,6,160,196,99,9,81,252,247,108,40,124,232,207,80,195,216,97,36,104,131,133,206,109,36,61,102,252,237,239,94,152,31,252,96,195,129,253,237,235,191,99,186,105,62,224,112,65,32,94,19,149,91,59,110,137,220,85,39,119,235,244,199,83,11,154,219,105,42,125,47,168,82,3,187,77,79,147,152,246,236,233,98,188,151,190,184,5,61,69,62,215,141,230,247,136,121,120,141,177,13,228,39,119,32,186,188,231,100,244,73,236,116,219,186,243,206,218,5,88,21,169,178,49,13,136,154,203,189,43,68,47,51,140,88,225,188,118,203,207,81,55,45,141,212,50,79,22,59,162,239,53,7,155,226,113,0,238,132,87,215,195,104,19,8,21,158,105,143,100,171,104,7,73,248,142,27,201,192,123,129,55,39,19,244,108,147,6,216,62,89,219,35,140,165,146,79,207,41,220,230,246,25,54,67,6,209,159,144,119,77,195,128,244,90,71,25,88,71,223,59,65,104,32,229,254,6,98,187,229,12,234,93,38,178,255,255,189,69,141,193,127,255,2,3,123,215,207,92,74,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6035e251-52fb-4af6-9245-ea29e5c426b2"));
		}

		#endregion

	}

	#endregion

}

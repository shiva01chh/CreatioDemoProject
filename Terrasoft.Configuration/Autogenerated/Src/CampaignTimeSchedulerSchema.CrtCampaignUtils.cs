﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignTimeSchedulerSchema

	/// <exclude/>
	public class CampaignTimeSchedulerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignTimeSchedulerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignTimeSchedulerSchema(CampaignTimeSchedulerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("df9d7ecd-4d8a-4e6b-85e8-391311eeb8c1");
			Name = "CampaignTimeScheduler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,29,107,111,220,198,241,243,21,232,127,216,168,72,194,67,20,90,77,138,22,176,116,103,216,178,108,11,181,108,195,146,27,180,69,17,80,228,158,142,49,143,188,240,33,89,9,252,223,59,179,47,238,46,119,249,56,41,133,147,198,48,44,145,156,157,153,157,153,157,153,157,125,56,143,54,180,218,70,49,37,23,180,44,163,170,88,213,225,113,145,175,210,171,166,140,234,180,200,255,248,135,159,255,248,135,89,83,165,249,21,57,191,173,106,186,57,180,158,1,62,203,104,140,192,85,248,156,230,180,76,227,14,204,211,168,142,58,47,95,166,249,143,237,75,157,129,205,166,200,221,95,74,234,123,31,30,71,155,109,148,94,121,27,42,128,240,36,111,54,149,23,236,233,147,246,19,190,144,205,206,227,53,221,68,100,225,69,107,2,2,18,64,243,167,146,94,129,100,200,113,22,85,213,67,34,65,46,210,13,69,176,164,201,104,201,0,31,60,120,64,142,170,102,179,137,202,219,165,120,6,77,212,81,154,87,36,43,174,210,152,20,43,18,71,89,220,100,76,51,240,59,199,69,106,64,70,182,81,9,186,172,105,89,133,18,219,3,13,221,182,185,204,0,69,140,108,184,185,32,15,201,169,135,189,217,207,140,69,187,51,79,162,138,234,45,142,5,115,5,239,81,167,75,236,5,54,34,41,168,159,172,138,146,196,107,232,31,118,172,94,83,171,67,177,194,198,122,212,237,210,108,91,166,215,81,77,69,167,250,184,153,201,30,168,46,188,41,139,45,45,235,148,66,63,224,247,26,12,152,38,2,102,43,159,123,112,146,87,244,67,173,61,254,204,90,206,174,104,125,72,42,248,135,61,126,148,68,105,158,112,186,22,23,103,180,94,23,137,131,133,142,232,184,61,8,122,180,34,57,141,74,90,213,92,84,117,65,46,105,30,175,1,250,61,127,179,42,139,13,137,139,60,73,209,84,162,140,212,101,148,87,236,129,68,121,194,128,74,66,51,186,161,121,205,229,235,16,48,127,197,44,139,228,96,93,139,61,217,98,111,249,50,5,234,160,56,249,134,220,172,211,120,141,52,209,100,129,67,206,7,234,88,231,250,67,221,170,185,108,242,240,232,1,67,239,33,87,9,27,76,80,248,111,148,133,239,45,219,223,5,221,132,86,113,153,94,2,13,133,190,170,129,166,194,139,189,78,243,56,107,0,82,27,44,78,14,87,105,73,25,255,14,246,74,90,55,101,94,45,223,242,159,128,19,232,228,224,64,65,22,71,21,5,107,44,233,106,177,39,173,230,25,160,98,150,195,156,234,222,131,101,72,78,107,77,74,27,48,127,133,92,137,140,113,33,59,79,126,40,46,247,161,155,20,186,84,0,128,144,56,1,3,224,136,242,84,136,187,218,103,221,44,96,48,149,55,41,140,51,193,108,75,33,102,108,192,104,139,116,38,6,249,14,241,87,96,158,164,21,161,63,54,96,79,154,149,170,182,224,228,89,155,240,44,250,240,143,40,107,176,5,72,80,74,204,26,91,110,74,228,57,173,241,41,57,17,118,133,227,76,130,4,167,232,185,105,25,93,102,244,200,244,182,2,124,169,236,113,159,15,200,153,14,230,48,37,226,49,177,185,28,209,215,81,201,236,65,99,113,1,250,185,241,241,47,154,205,240,21,64,118,100,34,249,58,249,64,227,6,199,227,57,12,205,154,94,221,2,176,213,37,27,34,60,221,128,96,82,105,213,179,143,220,203,204,192,98,104,4,99,32,64,94,165,117,128,93,73,81,168,190,204,52,0,201,54,144,21,111,32,120,183,146,158,11,220,179,116,69,130,207,172,54,225,139,168,98,157,105,49,207,208,154,210,188,161,178,221,199,46,73,213,33,20,138,144,162,148,79,96,147,96,248,193,238,226,247,149,193,139,19,215,145,165,34,102,175,146,179,47,190,112,51,176,244,233,62,124,34,157,41,190,215,250,232,32,210,138,207,64,110,73,65,252,224,35,193,226,213,12,21,94,199,159,9,223,4,153,211,22,149,203,35,39,14,119,57,200,33,30,52,89,205,93,127,189,134,145,138,160,227,93,123,197,140,110,111,121,172,252,39,123,209,34,56,117,123,186,113,217,16,184,130,95,157,171,215,217,219,150,244,58,45,154,234,28,100,170,194,48,227,117,111,57,198,237,183,222,182,245,197,77,89,226,72,101,26,213,19,59,174,200,17,177,135,115,8,132,135,153,4,14,88,4,209,120,53,51,24,128,80,132,192,118,242,162,6,65,175,128,225,36,36,143,153,149,49,235,178,114,80,102,108,134,93,170,224,51,217,243,163,145,35,79,200,125,224,72,188,185,61,222,209,175,219,205,45,30,252,18,84,110,64,12,98,43,255,91,128,59,107,178,76,96,127,212,131,72,128,60,180,48,132,10,42,16,29,245,118,161,143,203,59,121,147,155,180,94,179,140,228,26,157,47,228,148,245,13,69,155,153,100,102,48,250,172,33,212,182,140,11,144,122,73,19,103,43,167,35,179,199,235,239,62,237,55,230,211,116,134,60,230,177,188,192,104,38,82,215,106,93,52,89,66,4,40,51,89,175,185,13,26,170,178,248,116,211,108,248,52,20,41,225,248,112,37,184,3,30,106,159,12,56,165,125,143,235,155,235,206,119,195,230,132,255,215,222,255,59,208,202,89,154,179,20,240,211,139,4,3,13,221,70,108,204,39,192,224,180,244,219,221,128,103,151,71,61,124,216,73,110,31,158,207,22,168,207,8,116,24,200,140,123,174,98,149,187,161,138,83,126,14,14,141,136,104,140,142,193,24,166,201,96,62,181,90,114,154,3,142,60,202,196,247,84,60,246,149,107,206,105,173,120,235,1,203,5,140,82,151,124,17,30,175,105,252,254,113,121,213,96,174,255,10,66,125,128,163,174,88,5,170,137,156,166,216,153,129,66,106,138,203,124,59,161,84,196,42,121,118,215,175,211,178,198,121,185,127,116,137,228,226,147,27,78,118,98,229,159,91,7,3,134,34,222,219,175,61,37,216,167,124,60,140,46,92,30,179,20,169,173,92,90,65,87,12,47,30,124,153,159,228,100,100,243,75,48,186,132,20,134,15,238,234,34,20,92,233,2,120,67,203,180,72,176,150,50,166,12,218,219,61,210,95,180,237,150,73,159,165,52,227,245,73,70,67,21,72,57,197,119,21,45,65,53,57,175,254,147,239,27,227,249,112,200,164,1,180,170,203,38,198,18,175,101,215,158,196,181,164,76,224,17,51,18,85,121,99,65,188,218,210,56,93,165,32,99,147,139,241,201,162,217,110,111,169,231,134,50,175,65,24,204,68,36,114,35,74,139,26,123,175,6,2,75,102,38,209,57,40,8,13,37,80,131,194,146,41,120,147,142,144,199,120,15,163,220,61,44,232,231,180,174,8,152,75,133,63,141,210,252,154,102,128,40,244,37,206,178,239,47,24,152,180,89,151,248,165,13,153,45,200,247,177,241,124,232,18,172,0,181,30,219,10,188,42,216,8,143,98,225,36,143,30,145,192,126,103,214,244,248,203,192,18,190,242,240,162,156,83,105,164,186,248,216,28,202,104,48,101,57,64,31,110,158,193,80,228,215,160,82,92,28,2,95,68,18,20,166,44,237,227,138,192,187,139,227,214,233,72,251,53,151,88,126,42,114,170,205,133,86,28,137,200,255,128,255,52,33,1,250,58,250,1,154,101,148,124,243,215,240,224,219,240,155,131,63,255,141,28,124,251,240,224,224,235,131,191,192,191,204,29,254,61,165,215,228,249,217,197,87,7,223,192,171,185,66,122,190,78,87,192,99,90,35,75,104,73,171,6,116,2,115,203,219,150,23,233,58,183,204,209,125,66,179,187,129,233,10,19,60,159,161,188,100,58,208,104,180,235,158,84,102,224,29,13,197,92,131,66,89,61,25,63,170,178,31,55,115,129,73,116,155,165,87,107,76,211,87,96,155,221,20,156,143,56,217,78,90,208,69,241,174,142,159,220,234,65,225,95,96,24,61,153,66,139,66,137,64,57,44,172,209,170,183,225,223,83,232,239,162,45,131,227,115,8,228,230,246,24,85,77,204,33,134,217,178,48,15,30,6,31,39,73,154,95,29,23,13,24,243,130,252,249,224,224,176,37,43,212,47,59,240,154,75,225,180,58,205,153,45,179,50,115,203,112,203,2,218,111,144,98,205,28,80,30,28,194,143,35,47,81,248,250,213,87,90,73,88,225,131,166,109,183,161,1,204,95,26,136,85,146,41,111,92,87,197,109,94,105,223,181,15,179,217,37,4,199,247,10,153,44,191,203,159,119,145,15,159,179,208,170,138,174,168,182,74,193,61,157,162,143,203,7,47,227,159,206,235,18,100,197,167,110,34,67,118,174,42,207,247,201,158,65,250,117,83,191,94,189,141,242,43,122,10,249,36,155,96,158,148,37,76,77,91,9,213,235,178,184,97,142,250,228,67,76,183,8,18,8,190,20,144,179,226,46,187,124,154,175,138,80,154,61,188,99,166,223,246,121,159,56,69,52,121,126,50,34,194,202,73,188,168,106,160,9,170,245,62,115,149,244,135,226,18,189,165,116,146,234,61,75,52,109,151,9,217,69,133,254,132,199,4,190,142,206,187,139,12,194,7,81,67,178,125,133,168,191,241,128,98,22,145,164,123,250,213,184,229,49,85,55,75,222,55,76,202,60,173,23,84,119,47,157,13,164,70,221,50,154,190,26,219,214,157,82,176,213,114,35,10,45,131,230,33,25,50,234,51,172,88,234,15,43,247,196,40,76,251,129,39,154,208,100,34,207,122,177,208,14,86,106,98,91,128,77,150,105,66,127,205,51,219,79,105,13,249,169,30,216,132,175,180,98,168,107,73,84,161,173,163,186,169,78,19,172,40,201,119,108,30,87,133,111,155,220,134,210,98,172,185,116,170,84,240,88,78,107,58,202,225,95,66,64,85,214,135,110,44,66,62,94,158,185,125,105,89,69,223,10,172,158,114,48,247,201,40,139,165,106,95,0,121,86,22,27,12,33,62,22,20,142,254,208,210,18,53,150,158,239,64,216,192,51,130,184,28,155,47,211,149,172,75,58,248,249,218,146,140,134,160,46,222,136,129,32,44,12,48,96,82,53,63,139,234,117,248,22,114,167,36,176,137,132,23,69,29,101,34,83,154,147,207,201,80,178,164,209,67,143,194,178,110,109,154,13,36,29,108,64,78,71,190,248,130,124,230,19,149,108,208,217,221,160,10,164,93,73,168,226,168,247,211,108,74,18,8,130,237,48,46,181,227,182,249,129,220,93,38,234,46,41,73,196,59,149,109,77,110,238,181,32,119,150,86,136,61,81,30,224,188,46,182,227,74,115,109,45,142,101,44,24,122,54,2,91,219,21,136,51,197,150,37,58,136,120,139,25,189,225,174,84,121,237,59,92,42,81,193,74,33,146,25,152,137,80,54,226,203,54,214,106,145,55,50,221,121,169,8,73,202,245,82,214,103,136,225,38,99,158,238,84,172,175,132,109,15,1,41,160,24,8,68,117,182,240,197,16,25,88,81,146,169,220,117,100,162,61,213,86,123,248,146,153,140,242,106,73,123,74,189,82,237,109,50,181,62,185,98,57,80,39,255,45,164,19,147,226,244,162,19,167,221,214,175,7,235,193,74,124,59,53,28,31,130,101,191,103,83,98,127,177,85,205,238,41,217,81,217,206,199,97,97,26,158,232,172,72,168,83,158,252,49,191,58,151,21,104,196,194,161,37,239,16,126,70,72,136,44,253,130,52,88,193,208,251,75,104,171,67,100,23,157,233,56,126,105,229,237,20,194,70,239,158,153,26,206,162,76,15,103,154,32,162,114,194,50,83,27,203,116,127,30,149,124,175,247,36,159,218,199,194,239,142,117,228,60,109,112,249,251,254,167,77,35,220,134,169,218,93,124,211,93,28,136,177,115,119,28,139,8,206,183,243,238,119,171,193,247,231,39,238,230,177,128,207,123,116,52,247,154,43,123,157,75,177,189,171,111,129,172,184,102,179,68,231,26,181,44,136,185,44,110,234,162,116,15,219,191,251,163,255,133,63,186,207,140,102,96,103,210,142,217,204,46,117,178,93,221,18,167,253,201,123,37,62,201,252,20,157,146,117,168,81,157,49,219,197,35,225,190,227,246,148,90,165,157,99,235,221,49,51,213,5,249,152,252,221,255,184,253,143,58,223,183,144,213,185,103,89,113,35,79,103,9,18,225,119,107,90,210,224,3,89,44,201,135,80,124,188,184,221,178,90,218,179,44,186,10,172,225,162,65,180,10,153,235,5,201,142,31,232,61,24,166,78,125,121,207,115,249,139,94,198,110,211,59,204,30,246,157,30,236,94,71,152,199,2,250,6,152,60,66,108,237,25,239,95,252,218,41,166,219,60,245,31,186,181,246,112,186,87,73,191,179,54,45,123,114,16,146,122,182,107,107,81,45,202,251,3,27,95,223,162,185,66,196,42,98,154,212,218,45,250,204,51,213,133,61,63,243,174,144,42,159,160,182,77,116,83,227,254,3,196,147,165,35,131,251,167,33,156,194,127,100,163,87,54,60,62,239,34,26,99,237,89,159,67,111,160,63,4,220,114,94,99,23,203,97,190,158,55,105,66,92,118,199,192,238,139,53,72,193,239,204,153,74,232,238,196,148,40,15,79,229,163,51,209,221,129,137,167,236,196,65,165,175,101,119,68,165,106,32,130,237,156,92,82,118,242,138,31,112,80,77,209,165,165,184,55,14,79,169,151,36,173,191,172,48,164,192,19,149,169,218,120,155,124,68,236,53,162,187,116,79,46,123,203,178,125,255,66,249,132,145,163,151,18,239,104,3,48,82,112,187,218,148,97,123,23,79,38,197,219,42,135,239,150,99,233,31,252,22,225,204,116,2,51,136,143,167,228,52,121,157,223,69,89,106,21,132,159,211,114,56,80,36,168,118,53,177,83,81,190,227,88,221,24,59,174,55,230,26,236,164,155,38,38,38,240,128,191,116,229,238,158,84,186,11,190,123,22,237,59,211,241,91,201,163,209,0,202,147,222,100,58,124,189,194,140,248,200,144,175,188,216,64,157,200,247,176,49,45,95,54,184,249,173,37,205,206,67,11,147,206,44,120,199,139,247,196,130,181,69,221,112,10,67,123,254,185,149,140,219,233,207,143,143,245,46,148,91,53,19,207,194,170,180,39,109,135,173,53,148,77,52,238,211,12,86,87,90,148,149,145,49,245,98,238,91,165,208,185,172,125,51,119,19,157,111,130,31,184,185,235,212,33,189,204,217,144,6,111,14,87,104,177,213,133,144,8,6,244,201,71,72,168,159,96,235,147,238,220,1,239,84,176,11,176,71,48,46,112,159,74,156,176,93,1,136,254,119,228,54,32,144,195,17,62,192,188,223,201,225,7,122,14,1,90,143,124,120,26,241,118,10,113,221,73,216,59,240,191,143,173,45,106,206,57,188,43,113,84,83,116,185,145,152,31,217,103,73,112,90,147,155,168,66,102,33,57,198,203,97,236,107,129,242,226,134,39,36,105,174,182,246,58,166,251,220,165,245,164,151,218,89,27,117,212,70,3,90,244,29,58,85,155,26,223,213,241,171,226,70,188,127,216,21,137,168,118,106,135,109,76,34,250,65,155,143,154,114,164,176,153,43,222,70,194,213,227,83,187,3,110,188,204,217,193,47,38,51,60,52,35,79,88,76,82,130,4,54,117,97,227,68,157,104,89,166,25,58,228,110,1,124,171,109,4,114,234,77,245,251,93,167,219,126,245,117,69,164,107,81,162,108,181,104,5,45,157,191,80,36,32,45,170,96,222,106,217,163,11,135,178,93,44,249,116,238,27,144,238,131,85,210,66,216,4,22,184,53,147,199,119,105,18,176,47,50,99,111,151,76,101,8,97,64,231,20,111,63,20,222,158,63,116,14,142,9,119,120,92,100,205,38,15,246,44,66,167,201,158,132,192,109,157,237,119,245,154,151,87,247,16,48,60,173,78,240,6,174,128,35,11,85,154,21,104,124,206,9,152,30,231,133,11,201,226,54,228,53,158,219,87,197,203,34,126,255,2,146,237,202,14,143,12,90,229,169,109,75,49,173,58,135,89,78,84,30,161,128,84,106,42,140,72,181,56,116,140,198,161,28,28,212,160,62,181,175,135,20,97,129,139,162,103,231,88,159,135,168,222,117,73,99,7,173,118,139,122,123,61,32,188,182,213,7,209,86,56,123,209,120,96,236,130,76,23,137,151,75,115,246,252,139,219,166,41,242,30,211,228,87,114,6,79,159,112,230,32,52,39,151,234,215,69,199,23,157,228,85,83,210,167,79,218,87,65,123,168,73,224,58,197,139,73,223,210,40,1,91,41,249,143,133,101,3,210,226,57,84,208,146,212,78,72,221,172,211,140,146,128,99,8,17,50,208,207,79,245,153,168,99,155,132,108,54,91,8,158,208,149,114,145,178,249,214,145,140,157,75,183,209,29,78,165,203,109,113,71,178,210,144,39,83,53,43,169,125,132,185,151,241,140,141,29,122,187,51,217,118,180,141,163,234,219,216,51,68,178,59,120,71,246,114,39,19,154,106,57,166,127,152,66,202,246,44,206,67,123,31,237,96,226,99,196,21,95,70,220,16,9,236,201,173,230,70,129,100,135,219,37,85,110,92,201,121,152,118,54,22,114,17,189,10,52,250,150,70,121,186,97,228,13,141,184,221,67,7,119,92,206,200,40,202,202,170,107,175,132,209,222,123,243,162,129,97,217,246,25,79,87,152,31,143,22,118,239,225,207,45,150,101,196,246,114,217,35,191,1,220,163,94,135,10,131,83,180,104,22,34,70,214,243,218,123,120,207,233,143,13,205,99,170,129,45,59,117,132,123,168,18,10,41,123,69,210,237,66,248,46,135,39,143,108,205,122,161,220,24,163,137,75,74,201,53,36,213,68,132,29,2,186,40,228,161,24,245,190,214,228,171,237,69,148,223,25,241,240,105,116,91,237,243,169,239,139,162,41,229,239,2,217,62,57,128,191,78,242,74,147,130,252,57,197,123,145,43,53,37,117,145,103,168,31,39,9,27,4,193,215,156,3,246,64,62,87,124,241,23,111,104,201,49,206,157,212,175,11,72,92,197,100,210,202,58,71,156,175,215,238,17,148,126,80,14,83,161,131,209,53,237,238,213,182,142,79,157,179,80,250,126,51,155,3,206,0,94,166,225,195,164,45,193,244,94,64,53,220,94,77,28,85,235,71,115,92,245,155,31,122,187,114,108,20,9,58,103,1,93,77,236,195,119,163,36,244,200,205,191,147,32,12,101,109,221,189,189,101,255,223,109,146,241,174,142,37,234,189,255,0,15,150,213,14,178,109,88,225,240,124,88,171,78,57,235,32,178,178,49,180,146,213,238,71,240,221,74,103,155,143,184,78,154,173,221,226,222,2,44,177,36,45,31,221,91,165,121,161,136,221,220,87,105,247,157,111,11,188,186,65,191,146,73,174,237,118,75,35,221,27,7,213,188,68,59,175,174,45,126,235,135,167,93,23,6,105,245,14,228,17,235,56,123,75,220,240,196,207,74,167,224,248,99,126,101,81,146,24,181,36,137,176,22,173,100,245,167,46,172,37,96,115,233,59,224,21,187,57,174,105,231,69,221,207,159,95,244,75,102,185,226,218,253,238,114,59,94,204,46,49,226,109,229,246,42,59,158,246,110,151,57,109,219,40,41,234,224,154,102,183,102,197,178,195,171,125,161,161,164,255,165,48,55,96,67,182,212,207,134,219,117,73,173,114,99,172,113,89,53,131,125,114,89,20,25,113,43,205,202,4,122,252,46,225,23,189,58,75,65,124,213,173,91,70,210,102,191,109,168,191,180,156,141,159,34,120,24,35,91,211,92,75,248,79,26,149,251,186,119,11,207,32,61,94,203,232,160,189,135,0,106,2,98,24,181,154,178,96,202,98,105,103,51,172,93,29,58,139,242,232,138,77,151,173,189,125,226,195,220,158,142,139,202,142,2,176,203,96,226,181,156,20,56,162,99,108,62,46,76,78,90,2,242,94,131,64,41,198,181,244,163,57,90,174,55,195,120,76,90,251,166,182,4,58,76,138,221,230,100,223,105,231,34,202,54,73,235,135,132,187,117,90,243,124,180,94,32,29,194,171,7,129,93,253,250,151,149,126,115,199,8,103,202,161,221,23,127,220,247,101,187,191,122,103,55,245,255,141,232,94,190,177,243,221,27,110,127,234,217,87,96,15,140,177,147,169,30,23,58,80,189,229,163,209,85,5,22,246,116,2,209,185,190,85,206,212,157,93,203,84,218,159,64,59,115,227,214,81,240,43,111,213,118,10,38,146,81,183,117,235,27,31,250,46,179,84,83,181,150,142,60,221,175,114,30,81,12,69,47,28,88,153,96,167,221,220,235,181,133,183,208,91,140,118,16,226,130,34,135,137,170,51,15,47,129,42,40,160,82,182,186,223,185,213,58,19,32,214,127,83,196,40,201,230,250,198,41,109,88,217,9,165,177,201,196,191,251,127,208,59,41,247,166,15,69,71,254,121,63,238,201,228,154,187,36,173,147,108,63,173,229,105,148,204,184,10,38,184,148,73,202,234,247,6,158,118,56,66,205,55,163,174,139,51,164,160,207,67,239,113,98,164,5,104,118,171,138,224,82,140,44,171,6,161,79,18,191,38,62,28,96,196,53,228,241,153,178,84,85,152,57,22,95,58,98,234,50,224,60,208,228,19,175,72,31,244,226,141,170,34,105,229,33,68,133,255,17,147,175,108,35,43,53,47,77,33,232,50,177,32,180,19,73,29,222,194,87,133,96,136,103,34,109,22,164,35,52,146,22,172,4,30,216,217,144,41,17,61,173,209,119,55,25,5,43,30,19,220,181,44,231,238,51,35,177,21,170,52,233,134,67,194,117,50,50,178,207,182,197,40,17,88,60,104,98,255,204,73,47,124,156,223,6,109,165,100,172,110,176,84,226,135,237,237,185,208,7,161,89,69,127,113,174,229,248,25,193,180,4,125,156,39,99,248,215,3,159,195,224,220,5,18,254,214,124,201,222,233,127,254,11,18,90,201,49,52,113,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateIsInvalidTimeOutOfRangeIterationErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateIsInvalidTimeOutOfRangeIterationErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6ce6e53b-31f8-439b-b560-7d304bc46c4e"),
				Name = "IsInvalidTimeOutOfRangeIterationError",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("df9d7ecd-4d8a-4e6b-85e8-391311eeb8c1"),
				ModifiedInSchemaUId = new Guid("df9d7ecd-4d8a-4e6b-85e8-391311eeb8c1")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("df9d7ecd-4d8a-4e6b-85e8-391311eeb8c1"));
		}

		#endregion

	}

	#endregion

}


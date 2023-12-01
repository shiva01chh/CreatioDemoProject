﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailAudienceDataSourceSchema

	/// <exclude/>
	public class BulkEmailAudienceDataSourceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailAudienceDataSourceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailAudienceDataSourceSchema(BulkEmailAudienceDataSourceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("71b712c2-3b6b-4e3c-988c-7b8af3836094");
			Name = "BulkEmailAudienceDataSource";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("93656b7c-51ad-4950-bd26-b581bae6f796");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,29,107,115,227,182,241,179,58,211,255,128,168,95,168,86,161,239,218,15,157,241,43,227,215,37,106,108,159,107,203,201,180,55,55,25,90,132,108,214,20,169,35,41,251,148,196,255,189,187,120,3,4,31,114,125,215,52,77,62,36,22,9,44,118,23,251,230,2,201,162,5,45,151,209,140,146,41,45,138,168,204,231,85,120,148,103,243,228,118,85,68,85,146,103,191,255,221,79,191,255,221,96,85,38,217,45,185,90,151,21,93,236,56,191,97,124,154,210,25,14,46,195,175,105,70,139,100,86,27,115,28,85,81,237,225,105,146,125,208,15,143,242,130,218,191,194,227,67,231,193,155,104,86,229,69,66,75,253,252,44,42,238,105,5,127,133,215,85,146,38,149,245,210,36,106,177,200,51,255,27,0,124,146,85,114,42,12,249,67,65,111,129,28,114,148,70,101,185,77,14,87,233,253,201,34,74,210,131,85,156,208,108,70,145,154,171,124,85,204,40,27,190,181,181,69,118,203,213,98,17,21,235,125,241,123,178,88,166,116,65,179,170,36,5,141,210,228,71,198,77,50,207,11,248,93,1,9,15,136,69,36,0,146,124,78,170,59,74,110,96,37,66,113,169,80,194,221,50,0,191,123,123,83,230,41,173,104,48,252,62,73,83,114,67,1,216,34,127,160,49,137,230,21,45,200,95,195,215,127,13,255,50,28,189,135,193,203,213,77,154,204,200,12,105,104,35,129,108,147,201,25,188,1,124,234,47,199,100,114,124,228,35,123,240,19,35,93,179,10,118,191,138,128,220,109,114,81,36,15,81,197,89,51,88,242,31,100,134,239,73,146,85,228,239,43,90,172,15,163,106,118,119,149,252,72,201,30,121,253,234,213,171,157,250,216,18,184,4,44,186,164,179,100,9,203,87,211,232,38,165,231,32,175,48,101,168,232,153,70,197,45,173,134,59,2,27,154,197,28,33,27,187,55,9,77,227,38,212,96,127,226,60,75,215,228,186,164,5,208,145,113,97,38,63,172,172,223,59,222,57,72,209,15,55,146,26,255,152,211,232,199,245,174,194,120,31,198,203,191,241,141,127,206,215,171,36,54,6,78,226,182,97,11,190,125,87,180,44,1,209,73,12,28,194,23,225,201,98,89,53,192,231,120,75,240,39,31,151,9,215,247,11,80,223,188,97,49,70,199,113,194,184,1,18,185,139,107,140,17,210,62,208,20,175,150,32,110,17,106,162,218,178,210,130,211,58,61,77,22,73,69,227,134,169,10,5,197,69,53,240,44,154,21,249,37,93,230,101,2,166,97,109,16,213,52,164,67,86,46,138,124,73,11,52,6,13,242,162,112,48,214,34,63,17,16,67,178,231,110,110,248,93,148,174,232,14,121,106,95,147,105,79,177,66,227,134,171,50,205,229,35,92,219,194,141,75,6,198,10,141,10,45,73,68,50,250,8,92,68,237,211,134,100,183,164,160,71,5,157,239,13,91,84,127,184,181,207,237,67,168,150,218,114,215,218,93,70,69,180,32,25,40,222,222,208,214,136,225,254,209,170,40,128,193,4,159,163,218,138,23,225,238,22,155,229,7,98,8,245,112,127,106,89,61,146,196,0,46,153,39,180,232,128,33,53,110,184,207,172,136,180,159,248,88,254,40,148,44,145,42,39,37,69,39,101,65,21,22,178,133,65,129,99,18,108,250,199,92,253,12,122,152,56,19,133,220,136,160,243,28,12,28,75,2,234,233,49,45,131,135,168,32,96,205,202,70,209,6,173,166,213,65,113,187,98,126,165,105,88,96,195,30,113,224,221,106,65,246,216,192,1,115,122,220,209,174,193,159,87,187,157,58,183,31,180,161,173,16,48,76,190,109,48,7,166,157,195,183,142,213,27,216,58,5,35,80,228,29,171,26,4,35,84,63,173,26,234,21,243,237,235,96,84,227,132,107,245,0,112,0,251,55,98,17,129,21,5,133,16,177,92,209,10,141,27,198,56,21,211,106,135,209,99,206,62,173,111,46,248,161,68,192,107,42,77,170,252,70,50,192,221,151,34,42,64,208,75,8,223,192,120,208,82,0,71,250,49,214,89,101,108,133,60,131,1,224,72,121,120,230,98,108,114,154,207,127,106,50,117,45,124,21,66,142,226,171,237,33,167,70,141,13,126,240,74,165,26,31,190,161,32,17,111,138,124,113,124,24,12,193,48,140,45,231,55,70,104,239,222,139,149,6,124,192,240,8,80,188,5,9,27,142,135,211,245,146,226,163,43,48,176,87,85,84,84,160,195,252,129,249,99,82,242,200,147,65,29,50,88,79,2,19,8,202,86,69,166,9,16,78,226,233,115,90,97,242,152,84,119,58,14,20,94,29,44,151,112,235,255,115,86,90,97,62,220,63,179,137,249,149,25,122,49,64,209,59,98,50,181,13,216,37,173,74,55,246,248,10,79,48,167,224,106,29,37,240,207,179,35,24,59,248,187,116,130,75,124,123,104,188,20,136,97,124,35,244,79,40,139,5,130,236,237,145,87,252,245,224,43,247,149,134,199,162,255,111,104,10,8,162,33,53,215,9,108,141,119,45,134,128,189,237,193,28,89,162,116,181,23,87,186,34,44,64,173,36,144,171,149,248,95,148,177,108,181,184,1,237,17,18,55,19,26,181,140,110,105,131,86,10,153,67,102,94,192,168,115,62,159,133,137,59,8,86,197,132,77,235,147,82,200,59,152,134,138,201,56,197,68,143,9,76,247,154,167,48,73,39,89,98,89,185,195,125,150,215,228,71,228,1,221,29,128,141,133,215,34,143,119,20,216,80,48,249,214,86,239,49,47,238,133,17,51,140,5,24,156,42,74,50,156,22,175,65,169,1,65,48,193,203,20,16,105,39,227,38,207,193,239,148,199,71,218,11,121,216,215,180,221,103,128,97,222,152,243,25,30,150,231,153,99,145,111,238,147,99,10,114,199,237,58,139,100,74,244,74,151,144,128,208,34,152,160,197,224,127,179,156,132,22,220,16,44,216,192,163,60,93,45,178,73,22,211,143,166,83,228,47,175,120,58,187,39,230,133,64,216,225,249,42,77,3,207,220,175,4,50,60,129,131,4,93,204,129,109,225,96,60,147,118,156,245,208,108,112,32,147,18,215,121,91,48,96,129,137,141,208,169,175,152,243,106,102,73,32,198,109,247,72,174,194,139,168,40,117,140,192,222,78,178,121,238,91,119,16,78,115,189,106,240,17,227,183,143,225,65,154,68,229,152,136,95,44,210,178,125,52,135,228,11,87,30,114,48,194,237,17,208,134,118,94,89,229,90,126,218,35,94,227,17,169,176,153,184,51,73,249,134,70,64,3,61,201,176,152,17,215,18,1,220,225,137,51,40,24,50,92,154,72,146,81,229,32,153,147,224,139,218,10,63,255,108,108,90,104,5,64,146,54,197,88,71,10,52,41,129,92,227,73,211,130,33,63,231,129,142,203,6,8,193,200,101,101,174,18,184,33,201,216,161,123,52,238,2,96,134,35,118,220,218,57,85,71,33,227,122,169,68,136,226,211,142,166,108,214,192,105,43,19,171,101,73,173,155,228,230,74,146,159,130,241,221,43,134,70,236,127,138,162,168,226,126,185,55,79,222,0,222,195,16,216,174,94,105,100,171,166,72,217,209,146,163,165,224,217,66,192,233,240,145,225,149,74,210,154,15,89,121,73,65,203,85,90,9,149,109,21,113,38,0,119,116,118,175,32,150,50,49,14,208,33,245,78,14,127,112,77,203,240,162,0,7,158,85,26,48,38,43,48,73,106,48,83,96,103,237,145,19,114,113,66,140,160,135,147,151,231,213,21,11,123,5,137,252,71,45,233,226,160,66,238,54,130,122,101,21,144,60,139,192,157,38,41,170,217,40,60,40,131,161,26,117,141,143,108,8,184,212,247,16,22,228,143,44,172,123,179,202,216,58,129,161,145,151,249,35,15,125,236,17,150,214,178,87,28,36,228,204,5,87,77,97,246,14,226,24,31,12,123,76,240,210,131,72,143,4,37,12,21,69,3,186,117,207,28,249,250,123,136,111,168,31,230,161,97,139,70,96,83,79,62,172,162,52,224,248,160,255,131,81,21,4,11,102,56,59,50,196,171,16,34,186,249,142,249,55,131,17,162,69,128,19,203,211,26,24,159,23,113,57,180,137,82,156,0,220,191,134,208,2,145,173,97,255,122,52,34,81,41,240,146,254,215,68,60,188,90,2,54,243,245,121,126,154,207,238,191,1,37,82,182,136,127,98,9,144,216,248,230,228,35,157,173,192,14,0,161,14,117,225,73,86,130,171,58,62,212,143,130,145,146,120,3,8,15,127,88,236,100,97,192,65,83,17,156,233,165,52,16,198,112,80,114,35,82,210,33,24,232,234,219,2,52,16,54,207,225,172,48,207,131,199,187,36,165,36,16,227,113,29,3,65,225,211,99,11,32,90,148,192,94,80,65,27,112,237,125,151,196,239,101,169,73,164,197,210,106,29,229,49,13,149,246,199,114,226,147,233,125,159,76,195,107,216,3,199,100,10,233,2,253,49,227,159,105,174,35,24,158,30,112,185,19,163,121,238,236,24,119,145,80,191,180,66,8,145,60,200,226,14,160,146,57,134,200,55,46,33,248,201,220,79,25,214,64,224,14,174,167,57,26,94,68,193,17,112,95,52,233,240,239,48,42,105,252,54,83,8,95,173,110,202,89,145,44,121,112,233,114,113,192,208,21,252,59,165,243,234,45,72,107,241,183,60,1,85,86,184,153,32,128,123,111,27,223,97,197,11,115,169,89,133,156,24,56,172,144,239,134,194,232,49,198,54,67,210,31,208,214,75,234,131,215,178,123,33,159,3,54,109,32,216,54,24,120,68,15,180,65,11,219,121,158,97,26,140,251,107,202,157,237,164,37,83,95,198,149,25,204,98,38,209,248,221,99,182,237,125,24,0,251,145,99,154,13,246,95,186,75,94,246,92,179,159,243,237,112,92,19,224,145,144,49,137,19,147,170,78,30,53,73,82,221,13,184,251,212,211,200,56,19,71,94,112,45,110,69,217,60,107,66,139,241,179,36,176,75,252,148,120,203,178,50,43,92,25,82,175,159,215,125,249,17,216,5,254,125,230,152,206,35,48,201,151,198,139,160,49,3,211,128,18,220,181,203,223,52,96,147,240,211,116,17,98,20,228,47,232,59,17,135,227,35,241,67,193,178,158,216,160,204,125,228,131,69,117,223,244,204,159,34,252,93,165,233,231,142,108,95,220,64,8,184,77,14,174,182,57,114,66,211,154,150,16,168,69,91,55,91,61,243,25,172,6,221,234,105,181,124,179,133,226,110,20,28,180,192,65,3,144,230,143,23,209,236,30,140,212,73,124,43,108,201,169,245,204,76,81,239,146,219,187,218,240,111,236,135,129,149,115,60,219,178,168,237,56,166,105,242,0,226,41,150,48,226,17,143,118,183,205,106,181,34,221,171,109,182,88,171,1,105,153,215,98,44,218,166,245,48,27,30,73,102,181,151,33,19,125,172,109,218,154,236,21,28,25,61,151,205,216,244,214,75,190,186,161,149,109,24,218,252,212,234,185,233,22,212,83,209,67,90,61,82,154,213,35,79,91,53,172,204,161,54,214,81,12,95,18,251,121,194,141,73,236,141,56,88,129,185,144,146,101,198,31,255,105,4,80,79,0,54,246,248,159,189,248,243,107,240,126,53,111,51,199,130,129,216,96,242,133,217,138,167,74,7,13,123,237,123,108,34,220,233,82,63,157,79,149,240,237,172,178,59,238,106,76,39,181,14,108,0,123,227,66,67,232,73,243,69,5,229,147,69,5,255,235,222,252,5,252,235,139,248,173,255,3,15,241,235,113,10,207,176,186,29,89,64,29,203,223,44,240,111,22,184,183,5,254,149,219,200,79,103,170,120,16,134,245,172,134,106,22,235,203,73,124,157,4,158,138,152,14,235,112,170,64,70,84,233,143,111,212,145,157,16,54,29,236,125,6,236,141,19,35,140,52,161,105,238,171,36,18,254,16,49,163,152,134,149,233,144,201,228,216,234,161,17,81,102,227,55,151,35,108,96,74,105,124,152,70,217,189,89,155,251,196,168,242,222,156,49,49,34,225,255,14,142,19,172,208,31,204,42,224,92,55,103,171,98,69,251,98,59,201,30,162,52,137,77,124,69,167,138,175,21,165,63,41,45,180,28,231,231,121,117,93,210,141,8,233,166,196,2,43,63,234,245,65,120,224,199,184,251,219,12,190,184,170,162,106,85,178,230,149,102,58,228,10,13,159,191,4,111,174,179,146,175,116,67,227,113,243,247,71,73,175,57,252,112,141,203,141,76,235,109,82,19,158,164,192,23,149,178,201,142,137,230,156,174,230,48,26,177,185,200,65,74,226,139,34,127,72,98,90,140,92,115,166,113,232,27,118,153,62,132,153,50,240,5,50,83,7,131,133,34,225,124,0,53,6,112,186,190,234,241,101,129,143,220,238,247,21,204,135,59,246,21,122,178,6,27,181,192,232,45,253,146,188,30,145,63,26,167,209,200,159,200,235,22,200,181,4,195,6,109,64,254,163,123,196,173,225,91,243,114,153,174,117,128,144,205,243,105,46,27,116,236,239,204,145,245,212,215,94,109,246,83,95,219,49,241,115,90,139,91,59,139,117,208,80,202,88,193,70,208,246,244,53,217,53,17,18,53,9,115,113,55,82,168,205,55,200,20,205,27,234,65,231,220,121,4,154,39,166,77,176,163,168,234,156,162,45,21,240,0,130,10,118,60,98,154,44,232,52,199,127,151,85,180,88,6,242,89,120,93,205,206,243,71,89,107,81,3,134,182,34,150,93,153,143,45,27,166,105,49,98,189,205,132,196,148,137,114,227,32,207,215,240,98,70,102,141,31,232,173,237,181,223,217,137,107,159,175,248,29,153,141,145,199,110,234,46,122,180,74,136,131,211,61,188,197,104,67,76,100,83,1,164,78,102,61,176,117,99,140,80,90,78,87,47,156,29,49,222,8,94,183,103,35,158,190,147,90,74,82,118,69,208,182,56,50,78,140,66,136,8,224,223,39,31,19,224,96,80,218,159,181,153,98,216,179,26,219,76,174,104,165,143,139,161,238,5,245,44,12,13,170,14,224,241,23,158,206,214,13,233,177,250,83,106,134,84,98,2,74,91,130,57,199,223,59,117,59,218,247,131,55,198,109,158,73,60,8,41,157,222,155,105,145,220,222,194,222,240,200,239,176,62,77,55,82,33,50,149,52,44,118,167,150,166,201,234,214,170,153,33,134,155,30,252,206,7,238,61,30,81,225,77,247,162,173,220,105,128,174,55,57,43,48,158,230,181,227,67,20,83,97,66,1,191,227,67,6,116,154,79,178,170,19,21,19,109,99,145,61,242,170,29,41,99,35,1,165,154,37,87,124,153,230,114,239,53,120,185,166,13,67,25,122,33,249,223,38,32,216,198,144,177,26,129,111,208,29,200,40,144,80,112,61,238,30,254,152,103,244,237,124,94,226,97,232,26,203,196,65,52,236,44,14,17,226,63,97,48,238,43,0,229,115,204,186,129,58,185,103,242,202,247,62,252,7,133,197,247,12,82,206,146,140,237,5,123,163,25,218,64,56,247,112,146,207,22,85,206,20,239,234,16,238,7,95,218,164,171,142,191,23,98,181,211,249,103,88,128,208,182,26,176,136,1,15,81,3,86,172,42,90,6,205,167,94,219,130,79,207,215,76,239,25,152,94,198,74,212,124,42,29,181,3,184,134,51,51,73,125,97,171,205,18,116,236,47,127,14,154,0,105,115,229,131,243,69,75,239,165,147,109,56,221,215,30,104,86,61,11,243,90,1,85,171,230,119,152,254,2,79,249,57,88,103,247,140,47,225,35,163,54,233,35,190,71,166,61,203,65,191,102,149,60,192,170,197,153,169,78,237,8,11,183,130,225,17,63,160,85,126,75,215,14,122,42,80,233,194,173,9,246,187,6,120,239,235,216,121,15,69,119,98,216,3,181,22,192,239,92,96,117,188,236,17,170,174,138,230,198,91,85,126,214,206,77,197,121,56,136,38,222,228,171,204,60,212,216,37,122,13,61,171,92,27,190,79,170,187,124,85,29,39,37,128,95,243,115,9,39,236,212,246,213,236,142,46,34,150,49,17,90,126,24,19,243,49,41,217,127,100,5,141,204,24,48,83,61,103,78,62,15,68,214,224,134,71,172,181,156,63,225,248,176,231,70,21,128,131,25,139,245,132,218,186,176,195,107,125,161,201,57,125,100,13,214,98,40,96,30,42,98,217,7,233,26,22,226,157,77,194,128,177,194,66,223,93,149,239,128,101,27,187,79,26,246,58,85,26,177,34,155,204,139,62,176,45,200,111,254,133,63,240,118,160,57,30,132,71,174,231,115,125,202,153,75,33,158,58,11,248,69,63,179,40,77,197,32,227,20,12,24,127,68,101,212,118,80,156,203,83,185,63,49,206,170,27,231,212,57,90,195,173,253,112,119,75,14,101,2,198,207,100,250,10,42,252,25,227,182,91,67,232,46,147,152,12,110,230,25,158,185,109,190,43,137,159,250,206,90,207,199,75,90,78,33,82,119,72,158,156,113,151,105,249,174,70,14,32,128,93,239,20,235,64,146,226,4,26,17,163,148,178,107,134,120,198,243,61,81,170,49,79,245,56,28,230,159,133,253,133,44,251,120,137,62,235,212,130,237,103,56,172,97,227,223,247,184,6,229,73,104,199,129,13,187,137,108,199,152,63,83,77,105,157,64,204,254,53,15,136,254,16,92,0,207,63,114,162,79,240,118,2,144,205,98,230,84,245,81,175,115,182,245,149,208,6,225,141,170,252,80,188,253,110,27,28,159,137,248,14,90,192,197,25,103,87,14,70,152,83,46,212,89,84,231,176,115,219,177,109,25,166,54,157,154,118,121,231,57,165,237,227,171,170,66,96,65,88,5,3,234,161,121,108,155,121,45,47,12,7,3,51,124,118,238,80,177,99,107,197,197,193,164,251,4,210,88,13,86,242,90,159,227,19,250,250,204,75,103,42,143,196,189,58,103,76,54,181,21,203,171,252,47,253,254,76,110,35,223,34,253,226,210,218,19,241,183,124,251,100,49,207,31,124,53,100,49,82,36,156,122,74,123,70,81,203,190,60,144,89,19,65,67,154,0,255,212,11,61,53,12,88,5,199,57,51,198,178,76,107,164,26,225,57,28,198,3,87,62,47,91,27,58,103,223,10,177,39,124,5,196,215,171,204,250,50,223,120,186,172,221,69,107,139,79,146,184,148,69,89,22,226,244,189,187,70,237,49,191,116,70,252,108,189,46,198,116,210,248,224,202,191,108,207,104,70,117,229,240,128,166,185,53,167,203,61,235,246,30,61,93,123,233,44,175,120,213,240,25,237,9,155,246,140,184,229,211,198,134,124,81,76,237,221,201,240,156,54,22,167,113,65,211,95,11,23,56,54,78,141,213,225,155,167,121,203,238,115,40,235,133,215,118,25,22,150,172,46,193,44,58,47,89,229,38,161,74,38,126,89,114,109,92,16,202,174,2,125,69,126,198,91,45,219,36,156,93,223,2,54,135,95,26,90,215,12,97,246,95,84,47,124,153,128,79,73,102,222,181,159,211,255,86,59,46,237,32,105,246,220,136,41,34,19,178,203,249,126,140,250,72,87,87,14,115,179,222,84,164,84,69,111,216,148,204,233,15,38,91,251,34,199,108,191,109,203,144,210,137,146,76,125,205,22,71,175,251,190,46,158,211,12,247,207,213,165,73,242,194,36,126,123,81,43,4,188,238,200,180,24,251,232,180,200,178,200,103,16,49,48,197,19,239,64,121,154,149,198,224,2,175,9,232,91,138,25,51,106,252,215,18,225,207,251,92,40,184,167,76,126,177,234,197,24,163,82,63,125,95,145,218,34,241,245,82,241,215,184,63,140,51,73,68,60,108,148,195,1,235,59,39,47,208,248,178,51,93,248,0,251,13,10,38,162,51,46,24,135,107,236,66,12,134,223,61,214,46,65,211,223,139,211,60,195,188,21,44,170,9,77,171,35,45,63,8,221,171,149,89,2,81,194,145,129,6,24,157,131,120,145,100,151,201,237,29,187,43,135,125,167,230,17,134,174,221,92,64,60,15,226,109,20,106,192,163,28,164,143,209,90,219,14,236,199,224,51,90,203,90,172,136,37,235,86,186,199,116,227,153,167,73,118,79,99,78,223,208,40,51,189,73,210,138,22,172,185,7,103,136,226,22,127,138,80,213,199,198,50,224,15,143,242,5,136,102,82,218,141,58,134,74,26,183,216,132,250,130,136,151,92,75,187,96,163,213,243,19,146,36,3,222,161,16,230,205,14,227,119,33,118,46,61,63,127,29,12,223,53,156,82,218,54,131,148,237,73,252,62,100,135,69,52,252,203,252,145,69,188,32,93,246,101,212,150,169,199,145,160,65,174,222,251,111,178,220,172,130,165,189,126,239,155,119,95,32,126,208,247,222,240,59,218,76,54,17,8,249,136,206,13,239,233,250,75,126,233,219,50,74,138,79,29,108,212,46,228,193,127,91,213,52,237,140,202,134,200,227,211,149,217,54,136,87,218,175,25,98,84,253,98,171,110,255,197,146,87,143,50,145,78,125,55,184,110,197,34,171,103,189,195,201,187,141,47,68,236,210,22,53,231,151,147,125,31,225,141,81,248,173,74,155,151,18,98,154,101,213,154,115,75,69,158,22,43,234,159,236,141,130,196,157,140,252,42,193,38,221,195,62,196,13,85,207,208,172,182,50,55,107,206,52,2,18,16,229,205,243,103,60,135,200,153,110,23,128,27,18,4,99,253,112,154,47,177,79,76,52,233,153,249,129,213,80,35,205,150,244,50,26,79,169,141,87,179,40,141,138,93,243,230,49,247,6,98,7,8,24,180,78,81,0,135,169,55,18,18,138,57,243,148,125,93,140,221,170,52,220,255,187,202,122,193,106,227,205,169,198,255,176,98,131,187,131,175,179,228,195,202,244,121,234,18,213,8,194,137,228,54,35,224,18,150,189,46,18,190,110,133,39,6,53,59,66,35,29,145,73,126,20,199,52,14,27,252,154,233,163,30,146,130,125,182,195,176,29,227,146,151,104,100,197,251,82,245,169,151,238,230,89,119,49,107,29,99,9,46,79,45,208,219,219,47,245,68,207,5,225,162,210,138,242,96,105,222,196,120,212,164,127,147,172,202,117,117,73,105,184,74,64,174,168,173,145,238,85,1,86,172,201,223,27,157,178,252,126,111,132,7,127,25,13,98,134,86,215,8,180,85,207,36,75,42,106,191,47,148,178,80,196,255,247,46,16,214,226,39,201,170,136,178,114,14,2,167,84,114,14,56,144,26,253,13,250,233,21,67,93,151,169,129,41,69,60,61,21,203,154,103,11,155,111,174,182,47,170,229,32,251,152,84,102,10,53,20,225,13,107,135,161,244,38,195,166,92,171,35,132,70,103,115,199,156,158,151,208,116,64,49,179,58,133,132,251,208,133,212,235,232,164,167,42,107,77,176,206,203,57,83,254,195,219,203,196,97,76,247,114,52,89,238,109,212,179,230,51,240,126,230,153,62,210,219,169,124,105,46,238,59,44,217,6,221,238,148,247,84,148,107,43,184,237,213,138,223,155,244,255,14,124,13,188,27,244,40,55,183,143,215,235,237,226,255,81,84,107,90,118,7,52,30,18,109,214,38,1,211,41,130,219,138,220,125,42,208,30,223,210,243,194,159,154,15,225,9,252,243,111,77,221,5,81,71,108,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("71b712c2-3b6b-4e3c-988c-7b8af3836094"));
		}

		#endregion

	}

	#endregion

}

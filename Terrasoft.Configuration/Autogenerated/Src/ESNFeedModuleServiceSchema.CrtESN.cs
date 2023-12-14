﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ESNFeedModuleServiceSchema

	/// <exclude/>
	public class ESNFeedModuleServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ESNFeedModuleServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ESNFeedModuleServiceSchema(ESNFeedModuleServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("685e8463-83b8-4db0-b36e-78b67d76959b");
			Name = "ESNFeedModuleService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,28,93,115,219,54,242,217,157,233,127,64,117,51,41,53,163,99,154,206,220,75,28,59,231,15,165,163,78,19,187,150,211,60,100,50,25,154,132,44,78,40,82,38,200,164,106,234,255,126,11,44,64,226,139,20,101,59,237,245,174,247,112,141,192,197,238,98,119,177,95,0,156,71,43,202,214,81,76,201,37,45,203,136,21,139,42,60,41,242,69,122,93,151,81,149,22,249,215,95,125,254,250,171,189,154,165,249,53,153,111,88,69,87,251,214,111,128,207,50,26,115,96,22,254,64,115,90,166,177,3,115,26,85,145,59,152,70,215,121,193,170,52,102,206,183,159,210,252,198,25,188,168,243,42,93,209,112,14,52,162,44,253,77,112,232,64,193,215,143,105,76,95,22,9,205,122,63,134,111,232,85,63,192,17,44,235,163,69,69,23,212,106,213,245,69,19,33,160,140,187,81,232,128,211,249,43,63,80,73,187,198,77,12,157,80,167,199,157,159,166,32,211,42,165,172,19,224,69,20,87,69,217,1,1,34,148,114,80,146,187,40,234,10,96,250,129,29,177,95,46,75,26,37,48,16,94,70,236,3,39,5,16,255,40,233,53,172,138,156,100,17,99,79,9,44,181,2,94,94,20,229,75,154,163,113,2,208,227,199,143,201,51,86,175,86,81,185,57,148,191,207,207,78,206,72,204,103,145,69,81,146,24,39,146,20,40,145,154,209,68,140,174,16,9,73,115,18,145,5,165,73,168,176,61,214,208,189,229,166,203,41,151,128,225,157,24,160,87,245,245,53,45,79,83,182,206,162,77,48,250,252,10,118,209,237,104,204,191,174,235,171,44,141,37,109,15,195,123,159,5,211,237,210,96,215,84,101,205,37,12,43,60,23,179,17,66,98,114,112,4,99,242,249,118,11,200,140,51,125,1,2,165,37,73,154,127,142,159,146,106,153,178,160,29,153,144,17,231,125,116,103,148,19,2,220,115,53,174,203,148,75,76,202,4,92,66,189,202,57,234,6,0,116,144,227,62,184,220,172,41,57,32,35,78,149,147,220,155,37,240,179,197,9,78,164,66,4,191,68,89,77,159,253,80,167,201,97,48,154,37,163,241,62,194,175,162,107,58,108,210,249,178,168,138,118,38,231,168,119,26,50,123,24,116,45,71,226,153,174,162,52,27,132,104,36,64,21,253,19,91,8,182,84,14,164,184,194,233,106,93,109,200,115,49,107,111,0,25,216,70,71,201,42,205,95,231,169,240,42,26,86,144,243,83,139,144,224,70,106,252,31,52,79,208,24,77,203,60,47,139,53,45,185,103,48,237,82,108,136,151,116,117,69,203,64,202,115,20,91,4,223,105,166,36,245,111,45,253,51,185,166,213,62,97,252,255,110,187,17,127,228,171,52,241,113,205,18,208,254,64,12,82,147,194,102,124,136,164,45,13,196,150,160,65,252,226,178,37,151,41,0,7,34,99,20,228,150,112,230,242,69,225,197,134,118,230,65,103,41,13,71,173,65,203,123,234,62,115,136,83,59,213,150,234,115,110,157,46,109,23,195,73,147,123,41,87,58,246,247,107,190,205,223,251,144,61,39,210,5,236,138,50,135,223,239,175,179,226,42,202,24,141,202,120,249,94,90,146,87,81,186,176,118,165,68,209,67,252,49,234,255,185,166,229,70,218,128,163,114,241,177,71,215,114,242,222,231,33,234,150,8,210,188,34,103,139,5,112,239,91,136,6,116,82,64,118,215,3,35,101,34,120,120,32,153,64,190,245,2,226,62,228,122,117,70,101,250,130,178,145,63,172,45,178,136,234,172,210,210,28,136,110,115,182,214,7,4,224,17,91,191,226,110,122,181,134,164,236,42,205,210,106,115,65,111,234,180,164,60,229,96,129,254,131,231,153,96,12,91,166,112,168,80,14,36,174,122,124,235,0,159,127,28,177,118,85,222,196,35,2,220,160,181,146,39,185,184,114,39,157,18,3,82,255,42,145,98,100,13,94,147,176,244,55,26,54,115,244,164,169,213,25,44,39,38,60,181,43,242,108,35,244,44,113,201,12,131,157,3,166,57,32,2,33,252,107,127,135,136,164,243,188,198,31,68,164,178,155,121,188,132,45,69,222,75,102,241,231,126,15,228,137,14,72,14,196,2,246,204,233,228,249,115,18,88,67,7,228,53,163,101,27,215,66,29,233,203,40,135,133,137,120,61,19,130,142,233,241,134,239,252,96,36,201,141,198,99,139,169,217,116,46,191,201,217,228,61,101,230,200,126,63,188,51,112,112,232,226,192,181,56,163,7,184,43,48,219,223,112,198,159,57,4,14,131,134,233,93,211,6,197,180,220,198,239,153,150,176,204,146,125,119,163,207,13,0,153,42,194,174,23,107,50,103,227,138,172,49,71,61,39,117,89,130,237,241,209,112,150,132,151,197,92,16,194,37,1,110,230,199,125,64,68,18,50,36,101,122,73,171,101,145,12,218,81,71,9,20,33,105,86,209,146,145,170,104,42,148,103,140,82,18,151,116,113,48,210,173,73,56,189,209,227,67,216,64,104,75,29,219,78,140,172,163,50,90,17,30,191,14,70,212,65,114,120,178,43,169,103,143,5,70,63,129,88,36,163,231,81,181,28,29,234,128,173,186,133,7,248,88,64,92,135,53,207,152,40,169,233,11,177,244,192,33,76,28,134,181,2,66,81,106,234,6,103,58,162,157,241,50,47,82,42,196,49,114,128,169,180,131,63,60,1,239,84,73,134,222,164,213,242,156,175,129,114,197,4,56,40,188,114,153,50,204,92,195,233,77,29,101,19,141,157,9,129,2,78,85,6,22,217,80,5,251,214,162,164,4,70,8,239,242,131,19,89,8,210,10,44,108,99,221,8,59,36,108,230,217,157,114,46,211,235,101,197,230,245,149,20,50,247,204,102,22,127,23,41,63,81,98,54,209,223,85,198,35,171,144,153,216,44,122,101,254,196,21,186,133,7,167,89,60,246,200,253,201,238,130,247,153,54,187,81,50,117,62,98,77,103,45,79,14,30,240,153,161,160,192,127,7,163,183,186,107,124,42,247,243,59,167,234,67,77,132,103,37,212,141,199,155,35,22,7,82,94,62,42,8,118,94,176,84,4,250,3,242,68,95,114,167,11,19,50,36,55,98,125,188,152,17,179,133,71,211,220,203,156,242,254,224,93,220,23,195,153,62,159,229,65,234,243,63,74,59,8,46,101,173,248,12,112,148,32,25,165,156,143,81,41,183,71,11,9,2,129,128,120,193,71,77,28,129,156,139,146,77,23,36,112,166,126,115,64,242,58,203,80,29,143,30,145,192,200,55,66,161,201,20,156,28,176,155,28,67,218,23,23,101,194,16,250,247,223,251,130,152,221,77,192,136,39,54,208,124,126,62,86,235,217,67,22,195,163,60,113,152,147,124,223,110,211,53,110,96,93,254,166,24,184,30,244,78,91,71,112,1,176,47,175,122,129,170,164,85,93,230,204,55,221,225,28,102,43,112,221,116,76,184,46,253,119,154,16,84,247,117,9,43,159,230,215,105,78,221,116,228,244,120,110,64,72,167,36,24,217,6,203,179,51,105,40,96,49,156,171,150,161,156,126,34,230,183,179,53,26,162,52,7,93,33,210,83,154,22,41,250,118,46,236,188,168,203,152,30,101,105,196,183,131,52,42,28,156,254,186,46,41,99,156,85,241,93,206,22,212,61,228,88,199,98,46,208,35,55,160,129,203,215,88,162,62,131,36,51,146,174,74,167,160,33,106,64,66,222,59,147,243,206,177,136,111,59,122,206,234,129,27,7,40,80,100,185,94,182,231,150,45,240,41,205,55,250,218,28,106,30,24,220,145,227,65,254,55,74,80,235,81,166,91,184,211,189,213,247,10,182,196,25,91,243,78,56,196,187,59,100,146,175,103,9,100,123,157,91,188,33,69,234,60,133,216,64,210,132,207,94,164,32,156,222,100,18,105,120,145,27,104,135,226,195,198,141,232,112,31,66,202,81,145,98,161,60,212,183,76,192,144,106,25,85,228,83,154,101,228,138,226,209,0,196,46,76,204,161,108,101,80,239,147,12,156,243,182,36,24,107,89,131,111,175,18,226,230,172,172,55,90,169,226,24,38,207,217,154,91,85,32,58,99,150,18,38,68,27,229,63,101,170,220,174,91,90,226,79,176,132,103,14,67,135,77,61,63,33,87,69,145,129,28,120,106,118,77,21,121,176,86,145,218,74,207,193,163,219,240,112,244,141,25,142,144,17,30,209,190,177,112,240,18,153,189,128,248,82,151,116,154,71,87,25,77,130,209,140,193,28,181,85,138,56,141,50,201,52,83,137,13,71,165,248,15,177,121,116,120,208,217,93,0,96,75,120,225,140,137,38,123,208,6,74,116,190,90,72,20,75,182,165,210,128,55,212,65,99,23,81,126,77,103,139,87,69,53,253,21,132,205,2,222,168,71,225,232,115,181,3,21,77,73,174,94,149,74,199,99,155,27,107,201,207,186,86,60,156,75,249,29,130,69,157,81,63,135,38,27,13,198,121,81,86,65,16,63,129,188,252,251,49,175,157,99,204,189,67,76,231,233,101,17,196,223,135,26,130,1,41,198,67,86,194,61,73,64,47,78,127,62,224,102,244,173,244,166,236,38,80,18,151,33,156,199,97,103,138,25,209,26,29,93,20,159,80,157,157,6,220,134,20,145,47,54,209,100,193,219,211,242,227,236,58,47,74,170,183,162,213,14,70,229,13,138,40,88,215,126,217,166,4,187,185,103,27,194,246,151,32,126,12,214,172,191,238,226,133,148,12,238,90,217,5,158,224,151,148,165,224,120,148,64,247,27,232,182,236,26,146,37,140,183,79,60,215,206,163,36,121,237,96,113,203,105,106,79,178,226,192,170,106,143,231,162,62,124,78,93,217,121,230,233,41,33,125,176,78,9,249,93,91,20,117,46,8,162,132,58,34,85,155,193,170,118,141,3,84,189,80,113,75,60,238,174,186,59,75,236,166,51,64,250,154,16,18,72,111,133,96,90,223,82,105,154,74,192,113,79,139,163,69,52,217,69,125,19,141,77,205,176,244,62,133,206,76,227,97,255,228,142,227,189,55,247,159,150,198,181,122,26,29,10,11,0,58,136,131,159,200,147,249,178,168,179,164,33,32,14,52,174,210,28,36,65,10,85,106,48,32,243,129,146,121,5,108,114,43,144,10,135,117,78,20,73,90,197,219,124,153,84,241,112,35,38,119,54,96,50,220,118,209,214,191,180,1,239,185,93,98,177,232,174,174,151,236,166,122,59,116,93,105,239,79,69,212,164,216,193,253,164,153,60,148,139,142,219,156,27,102,136,123,116,81,214,50,169,113,167,187,19,135,188,7,163,202,44,204,204,177,245,205,38,220,29,18,74,158,69,158,67,42,120,23,126,39,157,25,251,63,205,5,152,41,168,204,177,20,132,79,249,179,105,94,175,64,136,16,214,125,54,224,225,121,103,67,104,182,162,103,89,178,161,174,45,64,179,26,231,50,212,147,86,109,96,237,220,134,196,150,228,190,0,74,64,209,106,217,42,91,111,111,156,111,56,45,187,52,56,218,215,124,130,104,98,161,55,0,201,104,221,82,171,226,243,91,172,108,6,77,127,165,113,13,92,55,130,15,74,188,48,38,207,84,247,246,120,82,236,40,67,66,121,173,195,92,148,126,104,55,134,31,124,131,171,77,52,192,36,186,252,129,111,195,61,160,49,244,106,254,187,47,165,249,255,35,189,186,113,178,79,136,119,208,108,247,233,88,171,55,171,24,108,183,159,83,179,13,233,255,147,251,180,254,155,64,170,213,69,188,10,106,198,141,84,25,115,10,175,105,169,235,142,254,19,64,121,74,226,73,37,176,187,32,241,119,69,238,246,90,166,142,167,61,188,211,82,128,81,7,31,214,49,38,76,51,80,97,255,185,233,77,179,183,223,189,11,21,108,87,178,97,31,140,142,140,4,99,175,235,132,213,158,214,233,140,245,236,71,103,214,180,118,128,220,241,194,65,81,1,57,154,244,84,247,23,216,211,240,52,138,69,42,222,244,84,25,89,148,197,138,196,104,110,120,213,71,118,5,6,31,222,52,45,252,222,62,49,7,30,212,89,149,70,220,137,12,191,43,148,90,151,245,139,183,155,85,163,232,62,66,181,219,77,82,149,24,174,196,69,102,226,237,38,206,146,214,155,53,2,159,224,52,121,49,152,152,2,180,26,198,86,96,146,56,97,23,113,119,222,82,15,60,17,5,253,62,135,67,247,106,135,19,112,226,235,160,43,147,12,33,19,174,210,28,102,169,67,234,23,32,156,160,93,132,26,126,179,164,37,197,171,223,188,93,203,111,5,4,178,217,208,212,40,65,219,43,37,17,147,236,32,195,139,2,188,81,188,36,129,113,133,132,95,248,55,197,98,157,148,182,129,79,246,32,112,158,145,128,226,227,133,64,148,0,87,24,31,139,210,119,37,140,213,37,61,61,110,135,180,118,179,196,225,191,89,239,68,95,28,14,90,106,45,34,145,198,107,151,196,249,127,52,58,154,32,80,211,91,164,96,91,196,128,139,246,134,132,20,71,13,2,208,29,111,57,91,221,118,173,150,0,171,227,14,81,239,76,55,95,52,164,183,234,95,234,31,242,191,183,157,149,1,32,222,218,245,244,248,69,247,132,25,79,183,205,221,43,203,160,129,62,177,229,200,119,76,180,139,183,216,177,85,226,39,118,191,182,137,199,237,237,36,179,46,151,39,79,211,183,29,158,72,159,163,57,200,86,186,222,254,200,150,190,170,209,31,209,146,21,136,231,243,129,14,79,90,164,114,25,194,103,233,206,205,120,161,49,178,28,156,241,13,239,61,225,106,52,191,215,40,15,190,183,200,247,196,181,14,7,129,74,90,186,189,166,56,216,115,60,166,81,52,244,120,119,219,129,183,235,238,224,210,253,220,221,110,62,98,129,124,150,212,131,188,121,217,211,3,35,91,199,54,132,71,218,198,197,41,193,64,239,131,26,67,177,138,160,26,157,1,108,249,99,145,218,148,198,225,153,159,248,64,85,43,99,177,62,2,61,71,187,154,251,100,99,211,82,180,217,40,99,190,56,198,93,46,239,252,185,118,162,31,2,234,136,198,161,116,212,222,253,226,24,150,116,203,172,29,26,226,146,181,235,13,77,85,234,123,191,199,95,239,145,224,106,67,48,164,174,162,184,44,24,249,119,24,134,99,133,210,231,80,177,73,189,107,110,251,7,185,216,191,226,229,11,229,212,47,151,84,172,138,203,70,60,111,49,222,97,122,162,91,127,14,236,111,217,108,57,94,119,131,128,247,10,5,218,116,103,90,204,112,219,247,93,146,159,27,32,135,129,236,133,168,103,157,71,229,117,205,77,53,24,213,49,236,58,203,147,78,218,184,226,157,195,140,235,175,77,145,47,219,85,70,223,68,239,224,112,139,62,138,99,168,123,185,0,241,202,149,198,164,232,5,177,245,137,5,23,88,194,209,80,234,95,134,189,124,120,145,230,73,251,244,1,176,245,96,239,57,239,212,39,201,222,128,239,190,26,121,110,66,246,118,221,201,83,233,252,156,166,151,76,133,109,186,114,88,122,96,153,64,31,28,58,130,14,213,105,143,132,9,249,50,81,195,143,30,73,104,200,206,23,128,5,164,130,200,159,247,172,74,121,126,25,133,109,194,161,150,136,99,232,52,91,103,90,18,174,86,208,117,233,165,45,249,220,205,22,24,149,143,83,44,118,214,166,142,234,38,78,57,218,108,57,135,97,94,18,60,12,179,77,62,51,48,171,52,82,73,205,125,108,121,19,188,229,188,97,167,174,42,233,239,167,118,114,226,111,153,154,86,241,7,197,93,225,227,21,222,17,247,23,205,68,20,42,41,249,117,163,17,201,138,226,67,189,254,111,139,190,190,72,214,136,66,96,141,141,211,96,159,96,4,24,229,89,18,12,237,32,138,187,196,194,238,75,92,118,28,212,111,243,181,163,188,68,175,179,236,172,124,144,29,167,95,216,195,94,51,103,11,163,196,5,93,243,43,34,133,104,215,138,18,99,24,180,255,192,66,229,149,195,112,132,154,168,218,21,72,161,233,169,238,110,205,87,253,145,115,115,235,152,211,81,111,71,247,222,190,161,87,179,252,99,241,129,6,56,141,119,184,207,207,230,151,16,212,143,139,100,51,175,54,226,246,17,128,189,132,88,2,238,169,25,13,223,148,209,122,77,101,166,194,31,129,82,198,197,191,138,42,99,2,14,133,63,178,34,159,192,70,102,107,72,39,104,63,156,241,230,88,220,63,56,5,215,84,209,243,130,241,183,168,34,3,81,149,115,59,164,93,52,229,151,252,192,155,194,55,43,107,146,234,16,4,167,243,159,165,166,221,235,112,219,243,8,168,83,230,58,54,213,136,183,73,240,254,209,81,150,233,253,96,166,55,46,87,8,201,221,175,61,19,140,2,9,91,236,76,204,85,107,49,74,33,147,79,59,154,205,34,199,67,20,163,177,49,110,255,39,236,227,245,58,137,188,246,65,33,96,208,68,162,104,237,3,0,229,152,207,64,78,150,17,200,58,251,146,6,210,146,216,213,64,180,153,253,6,210,46,112,184,129,204,141,38,106,48,82,188,79,76,65,170,222,103,51,45,250,232,181,42,111,48,7,174,217,157,195,247,223,207,2,254,170,247,201,30,42,125,177,210,16,137,22,44,225,3,71,155,50,128,23,142,42,213,108,11,111,212,104,135,159,32,182,2,188,65,65,210,138,48,177,222,252,219,138,195,27,207,187,101,25,32,40,34,129,191,168,171,124,139,18,227,127,109,67,0,180,109,52,117,170,141,198,99,254,181,143,1,121,157,150,208,13,121,8,34,79,179,236,212,79,252,213,165,173,215,29,0,202,251,40,183,49,66,229,205,12,196,90,42,121,9,229,201,148,183,8,209,81,109,123,124,210,122,205,33,15,67,230,233,106,157,165,139,141,68,168,222,214,140,157,235,105,192,147,121,207,175,239,134,195,45,161,25,24,165,68,177,229,82,71,231,205,10,247,118,128,245,81,187,219,185,253,214,197,221,110,240,60,220,173,196,189,206,103,179,198,155,87,93,224,247,174,108,221,187,83,77,211,217,108,109,96,177,225,127,42,213,249,154,198,20,184,226,187,125,21,221,253,170,197,212,170,249,190,197,252,214,81,131,235,5,197,223,142,13,242,169,185,199,181,25,55,23,110,218,63,76,80,202,11,140,205,47,134,127,81,200,115,127,129,91,97,96,255,217,146,16,43,66,69,241,136,109,242,56,144,248,91,220,26,222,240,66,172,198,238,167,117,191,204,11,95,209,79,252,191,252,210,179,253,251,70,254,121,129,146,85,103,165,252,35,66,124,92,113,60,193,55,39,219,237,102,192,95,56,18,99,252,127,255,1,122,236,87,105,217,83,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("685e8463-83b8-4db0-b36e-78b67d76959b"));
		}

		#endregion

	}

	#endregion

}


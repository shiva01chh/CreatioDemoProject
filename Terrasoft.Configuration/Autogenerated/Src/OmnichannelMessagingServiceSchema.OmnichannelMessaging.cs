﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmnichannelMessagingServiceSchema

	/// <exclude/>
	public class OmnichannelMessagingServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmnichannelMessagingServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmnichannelMessagingServiceSchema(OmnichannelMessagingServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f4922da9-3ec4-4fcb-93f6-37d8c2b2d734");
			Name = "OmnichannelMessagingService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,60,219,114,219,200,177,207,74,85,254,97,22,103,43,6,43,44,104,183,242,38,153,114,233,230,93,38,190,197,146,227,135,173,148,11,2,134,20,142,65,128,158,1,36,51,42,254,123,186,231,142,193,0,36,237,108,206,73,101,101,98,46,61,61,61,125,159,6,170,116,69,249,58,205,40,185,165,140,165,188,94,52,201,101,93,45,138,101,203,210,166,168,171,228,237,170,42,178,251,180,170,104,153,188,166,156,167,203,162,90,254,241,15,79,127,252,195,81,203,225,39,89,150,245,93,90,158,156,92,214,171,21,140,127,85,47,113,196,169,233,119,0,152,249,193,222,119,172,126,40,114,202,120,114,85,175,210,162,74,174,171,166,104,10,202,237,232,171,130,209,12,209,34,179,189,102,42,140,169,153,103,65,221,108,120,67,87,254,51,108,190,44,229,80,158,252,66,43,202,138,172,55,230,125,11,224,87,52,185,129,222,180,44,254,149,118,33,187,148,100,52,121,153,102,77,205,58,219,232,142,24,156,249,158,126,105,41,111,130,19,95,215,85,129,96,93,90,218,222,143,244,46,145,231,209,67,254,170,72,151,85,205,155,34,27,64,200,61,252,139,53,128,40,139,138,94,150,117,155,207,171,134,46,89,26,162,99,242,170,168,190,132,225,117,177,240,182,120,117,49,216,117,211,116,104,243,134,62,54,112,40,216,253,87,238,66,12,241,87,114,253,53,163,107,113,138,118,160,226,133,219,205,154,30,200,62,56,5,224,0,164,255,97,116,137,236,119,89,166,156,147,19,114,205,88,205,4,159,164,128,174,24,114,124,124,76,158,243,118,181,74,217,230,76,61,203,225,139,154,17,138,19,200,103,186,225,100,41,167,1,56,61,235,216,153,182,110,239,202,34,35,153,152,41,150,249,27,76,114,150,58,66,17,236,173,38,26,94,214,108,149,54,156,112,90,229,184,115,179,168,153,113,236,79,121,190,78,89,186,34,21,232,131,89,36,198,35,149,163,51,224,241,135,2,212,3,3,53,1,212,164,36,229,228,175,55,111,223,144,250,238,127,65,78,158,31,139,121,22,12,163,77,203,42,126,118,173,151,156,146,156,174,1,15,78,128,108,6,240,243,99,61,16,103,170,189,62,20,172,105,211,146,240,6,249,154,252,66,155,27,185,1,189,253,88,245,24,48,112,142,85,91,150,19,34,104,113,36,97,146,8,167,137,57,17,158,254,209,22,254,224,127,120,126,208,35,143,80,61,187,231,121,18,228,37,69,129,193,179,189,72,57,213,84,194,19,214,68,79,171,28,168,150,209,226,1,159,86,146,147,128,9,88,189,82,79,216,94,88,153,34,233,186,72,118,178,194,8,138,192,143,14,50,146,67,112,255,251,111,242,189,58,101,57,239,183,171,180,73,65,33,52,12,84,216,63,157,131,218,137,137,133,115,36,217,84,194,122,77,87,119,148,9,72,26,212,93,93,151,228,166,205,50,128,64,158,64,38,154,83,160,32,252,217,194,217,54,172,21,26,96,120,186,98,8,113,216,74,88,187,80,212,249,11,50,56,103,31,32,203,121,150,213,160,216,1,245,230,32,50,4,230,145,61,137,124,164,79,200,224,2,170,104,77,25,234,158,19,242,78,172,162,6,244,228,92,180,168,181,73,145,39,118,84,71,182,7,41,247,75,91,228,122,254,60,247,137,54,178,230,156,147,84,45,11,244,40,30,232,193,75,139,51,159,243,115,49,251,128,149,47,25,69,65,33,31,222,191,58,120,77,197,40,10,196,7,86,6,215,245,89,100,63,206,81,140,231,42,43,57,78,173,77,171,118,21,30,164,165,227,77,93,209,169,248,133,54,150,85,105,41,159,112,18,173,150,148,237,143,76,136,241,212,218,175,41,16,65,49,84,208,110,204,87,235,146,174,104,213,72,125,84,47,96,8,165,36,99,116,49,139,230,114,122,116,124,38,212,156,85,97,43,227,138,36,97,251,178,83,107,116,240,3,225,153,107,76,191,91,64,180,78,224,117,203,178,97,78,85,24,94,74,188,132,135,112,35,102,28,192,157,135,45,117,168,251,65,196,159,253,177,81,124,166,237,14,201,181,75,183,3,175,178,70,55,91,13,254,142,245,120,241,175,157,52,16,107,221,192,192,3,214,177,17,0,112,167,90,236,63,73,107,11,223,254,218,31,59,233,245,52,112,84,187,112,10,168,3,57,251,192,115,86,50,131,126,155,80,203,76,156,66,83,195,255,215,208,126,223,52,107,126,114,124,188,6,175,131,54,247,180,229,73,81,31,231,117,198,161,9,213,55,216,221,99,152,12,147,142,119,161,172,84,232,27,92,106,118,70,162,218,146,245,147,209,6,234,23,141,78,7,84,170,145,100,192,252,190,206,247,19,99,112,5,225,176,197,78,31,210,18,130,162,93,184,206,175,10,113,118,208,254,92,226,61,85,30,235,25,2,123,89,208,50,255,135,128,20,107,231,81,123,143,21,125,36,35,179,213,224,163,39,18,105,153,138,166,86,98,182,83,219,143,50,0,125,130,195,221,246,92,115,22,116,198,224,0,78,44,171,185,195,144,141,96,4,50,68,114,91,223,8,60,226,9,252,124,85,63,82,54,175,30,82,8,63,171,6,54,224,206,18,190,177,6,108,57,106,43,71,108,165,59,53,206,83,72,237,52,207,11,65,130,82,19,190,73,151,223,75,246,91,0,241,29,244,150,154,21,41,42,85,236,14,162,4,119,28,176,240,71,71,1,51,122,153,102,247,84,9,169,12,21,194,38,243,173,64,19,5,142,99,188,74,248,125,205,26,163,5,139,106,81,195,31,146,33,180,176,113,252,205,100,17,238,74,218,247,46,61,60,246,183,135,93,161,149,20,235,251,121,158,50,190,45,0,243,38,93,173,247,245,142,142,130,30,201,128,135,210,193,149,21,15,105,163,60,236,181,124,128,112,41,205,235,170,220,144,185,216,182,200,0,144,79,233,122,13,8,10,241,18,205,167,238,148,12,60,233,70,239,82,43,31,49,236,29,120,45,197,87,136,34,34,151,134,159,100,72,232,163,217,229,129,46,162,117,3,39,76,115,141,170,122,132,53,1,165,76,251,42,239,233,26,14,158,50,210,125,60,237,110,112,254,170,6,44,203,122,121,218,133,37,218,241,63,201,237,64,122,79,72,112,14,121,241,130,196,226,199,12,199,190,78,43,216,15,75,64,174,48,231,70,89,28,245,124,43,250,43,68,161,37,101,209,100,98,196,192,200,130,70,202,153,5,14,80,163,77,36,249,148,57,79,30,194,67,115,58,15,131,155,113,1,195,102,186,207,176,75,84,9,3,43,196,31,56,101,16,140,85,82,97,142,108,107,158,83,180,237,27,140,186,40,179,187,42,130,237,167,195,78,177,26,15,178,128,19,200,90,67,42,128,243,210,10,244,16,121,47,115,25,4,101,7,132,137,223,3,133,244,48,227,19,207,23,157,254,130,139,212,5,1,163,92,161,135,141,40,107,136,190,231,29,196,24,29,113,13,91,36,21,156,25,66,137,201,196,227,6,198,13,249,229,150,255,194,180,26,104,30,60,215,48,105,241,132,7,122,224,172,69,68,70,195,43,197,238,241,30,113,187,224,240,74,194,61,24,97,138,95,193,33,82,121,213,203,178,0,32,228,19,115,31,135,249,0,228,140,19,145,223,129,127,225,212,48,37,214,128,150,22,64,48,34,58,95,23,160,232,203,146,15,144,91,180,8,252,204,227,109,23,140,51,209,142,27,65,189,251,212,59,150,98,1,250,162,179,59,50,235,38,204,128,146,94,63,113,89,7,117,203,243,254,186,103,250,92,212,193,152,243,239,83,50,112,116,254,130,59,78,12,133,255,85,157,125,230,168,82,57,6,154,27,169,48,176,209,182,13,159,155,204,189,130,129,94,9,133,73,112,46,249,210,22,217,103,176,121,0,119,167,112,132,48,8,181,141,170,187,46,182,90,233,121,173,74,245,5,128,239,86,123,123,25,93,105,234,135,213,127,13,161,127,214,72,97,92,20,194,6,248,77,35,132,150,67,73,97,167,15,40,180,177,37,81,173,9,215,103,60,153,48,138,117,191,101,248,108,122,67,133,149,237,55,207,122,86,201,31,226,159,209,136,109,210,9,15,105,194,141,223,162,158,119,241,242,227,61,224,64,120,250,64,69,146,25,19,206,54,191,236,144,185,187,202,78,194,26,134,247,176,243,30,123,164,244,176,71,222,246,90,20,95,119,1,133,89,218,28,76,128,36,131,250,193,87,13,123,169,5,84,3,204,78,28,96,213,46,248,61,153,211,195,201,123,28,213,19,93,109,16,251,109,51,163,32,134,117,195,8,223,225,196,191,183,180,165,87,5,186,204,119,45,204,151,235,250,173,59,8,247,5,135,147,220,129,50,66,63,31,246,1,84,236,33,27,108,28,165,104,111,180,161,107,175,199,82,215,239,58,128,198,111,215,242,134,206,8,119,221,109,248,110,150,244,22,216,87,97,122,104,249,207,131,52,244,208,151,228,243,27,149,118,236,182,30,200,152,122,246,155,90,27,159,218,107,25,113,210,135,185,207,7,123,0,247,245,48,234,53,236,164,154,25,217,33,155,105,181,28,231,131,222,131,120,131,55,1,24,19,179,22,93,56,47,43,48,64,187,162,17,25,8,176,30,136,205,110,163,237,223,104,141,132,24,61,107,237,207,53,249,160,238,126,129,50,94,3,16,240,124,189,182,13,47,18,89,122,208,29,38,169,132,158,111,183,61,185,108,25,11,121,192,67,195,72,8,174,244,102,123,25,137,222,232,228,60,148,179,208,60,191,155,38,222,214,219,46,43,144,19,114,151,114,26,251,205,79,255,71,123,111,247,223,251,127,157,1,85,150,102,31,6,244,18,57,161,80,168,59,68,199,65,59,196,209,38,186,67,57,175,129,24,123,60,44,86,24,63,164,204,35,254,57,91,106,157,98,149,0,52,182,120,171,23,71,221,193,209,148,4,125,48,165,195,250,219,15,98,115,22,247,80,232,144,69,111,212,13,35,69,145,145,218,99,167,45,118,70,73,186,97,250,25,254,153,234,28,95,203,74,243,187,169,63,211,202,43,254,192,189,247,151,210,12,207,74,69,158,15,172,136,1,212,68,101,206,213,90,51,189,154,108,253,149,166,120,87,4,205,78,22,250,188,133,17,76,85,125,1,9,127,140,46,104,202,208,22,8,116,182,145,201,60,43,40,10,19,204,173,214,45,74,215,95,126,146,2,21,162,210,30,117,3,138,110,34,183,175,219,158,223,158,233,226,152,207,116,19,32,201,62,112,213,38,117,53,198,140,44,210,146,171,123,233,163,78,137,133,102,49,85,241,151,233,252,181,202,199,123,122,229,99,205,62,139,34,195,4,150,18,137,104,204,236,2,156,169,184,42,171,23,241,237,36,193,107,37,125,141,241,99,212,131,201,147,39,216,216,54,17,151,54,209,196,201,253,15,211,178,95,53,133,73,156,110,201,86,236,222,249,102,246,183,38,33,127,44,26,8,182,226,64,215,81,150,114,234,222,25,99,169,31,189,171,235,207,39,106,31,14,253,117,151,193,169,131,87,55,209,229,159,93,127,31,86,241,200,209,122,199,162,178,226,60,207,213,57,197,254,13,187,189,181,87,13,122,47,98,98,193,223,208,71,244,69,6,141,40,144,111,206,95,2,247,181,140,94,87,120,58,121,28,189,44,190,226,36,5,113,158,71,19,67,33,127,185,4,7,206,81,206,212,164,121,62,95,188,161,52,7,56,254,216,41,65,105,49,56,105,10,17,90,90,86,29,134,223,13,145,18,135,38,187,214,113,88,203,61,148,110,240,10,156,140,149,93,33,104,33,156,144,67,144,193,39,150,178,63,244,198,205,249,13,152,189,252,194,136,239,145,155,248,78,76,52,66,177,185,183,176,218,250,240,250,34,164,193,1,102,171,253,177,157,29,43,14,236,114,133,39,98,15,53,86,17,229,185,171,29,110,107,129,224,78,222,51,106,156,58,147,245,222,123,187,56,111,26,112,38,208,140,113,85,245,119,26,30,216,45,243,116,158,146,91,250,181,25,159,68,254,60,235,96,35,71,143,48,207,128,28,170,141,245,153,124,128,40,138,9,187,82,104,28,58,221,160,53,178,196,74,173,145,137,5,58,77,10,166,185,243,155,153,66,137,94,145,3,120,132,230,33,153,87,89,141,149,0,228,133,153,128,245,9,96,218,78,76,3,240,125,177,182,233,93,247,106,141,172,25,125,40,234,150,91,43,209,243,22,127,11,93,209,253,217,199,248,159,88,101,234,130,182,98,227,173,241,34,177,87,150,103,6,73,211,102,36,233,85,189,132,237,45,234,248,199,232,101,221,218,124,25,1,245,126,79,30,25,94,126,98,77,183,184,79,4,65,163,85,182,73,188,146,30,50,191,58,33,79,30,170,219,132,104,183,185,49,152,204,204,48,139,202,118,106,232,211,29,233,237,200,153,17,233,156,88,166,181,154,167,132,64,29,191,65,223,131,107,229,43,185,237,98,35,143,45,246,112,157,6,8,116,218,163,207,13,4,179,89,205,144,41,100,174,124,126,133,104,74,28,182,78,237,151,67,151,62,89,162,160,190,206,246,85,207,187,181,242,209,135,117,14,162,230,114,137,207,28,38,159,238,142,153,76,125,110,27,38,75,71,15,58,130,214,147,119,161,6,3,8,117,196,195,236,44,44,166,83,121,5,223,248,188,219,67,14,11,99,245,239,211,206,144,190,196,235,150,211,112,240,182,175,56,26,120,221,237,239,119,209,63,112,127,238,85,123,43,42,41,187,202,6,42,52,119,78,7,174,25,152,188,103,136,54,120,219,175,107,210,117,20,116,139,222,126,236,185,218,225,16,9,5,245,92,56,213,114,82,196,235,12,2,222,79,37,196,23,75,90,193,177,20,145,23,51,153,109,34,103,233,162,80,237,116,236,237,214,129,159,189,126,76,209,129,229,240,235,163,248,37,125,119,211,163,229,9,99,73,85,233,211,187,234,240,215,83,69,103,74,168,221,151,114,2,78,205,117,118,95,131,69,177,102,230,109,219,40,59,115,18,48,62,42,6,16,69,83,1,120,248,82,0,116,197,58,112,83,101,154,129,145,178,71,13,83,222,192,152,179,224,196,17,71,141,73,211,31,25,194,37,224,157,177,198,168,159,190,155,165,239,131,80,189,249,119,67,136,183,105,28,240,34,164,129,27,129,251,131,127,121,59,52,22,92,197,117,153,110,68,172,180,3,27,119,104,28,99,81,248,100,24,3,239,218,55,112,79,153,220,178,13,54,13,186,168,200,78,65,47,85,154,172,249,2,217,197,241,134,240,138,246,252,75,11,108,146,187,84,250,193,109,55,244,8,33,116,93,137,187,138,33,7,238,0,156,134,78,77,24,207,43,122,215,46,193,122,10,63,205,56,23,224,198,80,185,126,110,92,135,62,247,89,67,175,212,72,151,204,59,221,79,48,178,153,16,237,248,101,81,130,251,93,95,20,75,243,2,20,161,29,39,232,99,202,170,216,172,60,37,102,23,97,39,190,239,179,163,106,248,158,136,127,52,141,167,19,0,161,248,223,217,155,40,113,156,200,92,64,199,84,43,50,132,54,47,117,91,98,43,34,103,161,26,220,68,171,90,199,47,18,29,242,149,170,56,146,149,186,143,247,128,140,243,118,15,150,131,104,35,172,138,128,177,244,15,206,252,39,240,251,64,113,100,159,111,25,190,101,249,244,243,54,2,162,59,244,79,108,175,57,205,69,1,24,148,70,5,189,2,135,244,185,174,135,20,220,52,111,232,138,43,55,202,99,120,69,65,96,72,49,18,123,105,142,227,184,8,0,191,93,0,52,163,200,189,199,14,30,61,189,4,62,34,77,241,32,208,168,20,48,6,107,32,237,4,59,80,200,178,28,192,201,80,108,228,12,239,203,130,149,194,29,114,152,83,79,14,67,226,167,221,85,23,45,65,125,84,140,103,164,132,159,46,54,112,106,21,95,0,231,35,121,111,107,73,96,49,104,4,169,70,77,34,188,88,98,121,173,168,221,146,206,229,236,9,39,3,167,51,222,188,101,87,116,145,182,37,88,156,109,103,3,137,139,174,250,161,255,221,147,57,126,71,238,24,49,13,239,41,248,59,156,234,174,239,94,75,149,22,57,246,185,94,107,243,172,164,221,148,101,207,172,3,148,92,151,233,154,211,252,117,81,2,181,41,4,124,57,63,85,41,30,55,187,159,200,31,177,4,229,4,250,61,167,80,235,12,196,113,127,223,12,101,3,4,61,87,145,125,63,34,50,126,210,14,237,175,176,128,48,16,184,197,70,202,26,118,162,242,185,134,113,139,133,237,155,243,87,41,111,240,231,101,141,47,255,52,174,57,245,175,36,19,21,140,201,252,115,46,154,55,177,48,8,70,70,208,33,246,47,195,84,128,140,173,9,184,49,160,17,205,250,122,245,121,238,4,120,30,47,133,248,68,186,89,227,96,76,65,9,210,165,31,60,139,211,234,219,183,33,174,116,210,119,97,194,212,21,120,252,92,176,155,154,170,8,228,67,196,228,198,135,10,39,230,221,131,236,198,202,6,111,179,75,97,88,48,74,215,154,43,16,165,58,92,208,139,37,110,197,91,58,234,58,226,99,209,220,139,104,4,175,14,246,187,117,145,38,8,252,178,124,163,202,222,103,160,149,132,146,146,89,248,199,123,202,40,44,179,215,235,143,194,149,232,92,101,177,206,149,205,44,120,63,164,241,18,8,245,163,49,39,193,234,160,249,131,197,211,82,215,129,154,92,192,88,88,208,78,113,41,43,81,83,119,36,238,32,7,174,4,250,162,91,145,41,88,12,233,140,175,42,227,18,72,234,206,194,146,108,71,39,129,121,253,177,118,107,22,27,207,242,26,119,5,140,205,200,17,36,33,62,56,209,244,199,90,73,32,47,121,246,4,127,183,207,136,122,83,91,172,20,89,169,18,236,166,182,239,146,203,53,120,223,130,131,220,90,130,239,113,98,222,9,105,39,101,171,49,31,92,160,146,254,134,14,19,99,194,173,20,136,142,145,152,90,219,110,227,239,74,3,40,94,139,205,172,33,82,252,207,133,249,49,151,66,38,245,42,135,129,198,1,84,205,99,79,7,33,7,161,133,231,125,61,15,44,124,81,99,146,31,85,52,76,145,90,140,199,46,10,114,237,83,245,22,198,174,168,203,197,74,79,30,13,168,6,227,169,61,194,169,240,98,98,175,110,106,113,212,1,10,69,75,9,145,6,31,188,53,9,116,43,8,119,34,243,144,188,239,34,121,140,233,50,100,208,75,115,81,60,200,191,30,116,157,66,164,80,11,236,118,153,247,246,152,15,116,152,29,127,89,204,74,251,179,172,55,249,253,254,243,65,238,243,30,222,243,239,233,60,235,91,122,249,207,247,134,85,35,167,191,29,20,91,223,35,30,6,50,174,195,58,20,116,8,46,153,92,81,92,107,54,233,58,133,197,200,42,4,217,127,41,94,243,63,35,63,155,99,243,156,40,149,243,150,151,92,218,239,225,23,27,129,145,4,50,85,139,106,194,123,10,240,138,162,215,249,1,157,69,156,205,220,169,201,205,231,98,29,255,44,94,239,131,93,197,147,30,69,29,64,151,101,205,169,252,166,128,214,131,118,85,20,43,121,196,129,219,7,204,134,233,154,207,121,222,159,152,129,248,230,67,55,203,210,73,185,212,67,212,236,233,158,175,53,62,145,72,45,27,77,13,130,186,112,4,58,111,154,180,105,185,232,13,217,82,81,228,195,147,143,105,209,192,211,203,154,89,67,162,170,80,182,106,31,102,131,78,81,171,115,165,44,186,4,229,229,217,9,50,152,93,143,241,224,123,186,196,251,50,166,62,37,97,28,58,231,70,201,27,18,246,14,157,143,11,157,175,11,204,224,131,242,120,246,244,139,248,186,212,249,122,125,67,155,70,228,129,246,154,188,125,22,117,163,163,86,84,254,252,24,125,43,64,48,177,197,234,26,34,134,103,199,207,38,219,227,116,93,28,171,175,96,28,203,151,183,34,135,95,192,6,165,242,35,19,51,242,145,222,125,104,138,82,190,100,142,214,30,4,222,169,144,131,65,194,251,198,28,43,253,170,110,9,106,145,161,213,53,173,241,68,127,9,74,219,171,17,210,58,107,11,250,217,103,75,18,196,49,151,238,21,114,169,182,246,246,211,24,51,7,140,226,69,243,185,14,249,85,22,55,89,30,12,42,246,8,0,2,97,71,242,238,237,205,173,114,238,17,195,61,54,156,215,21,29,186,60,9,125,154,5,8,251,122,227,51,235,239,207,36,43,151,65,156,104,34,72,188,0,222,59,136,37,156,137,67,93,96,143,150,243,5,4,172,215,95,161,201,190,164,237,92,132,32,226,250,195,47,51,143,140,78,102,94,15,81,30,14,249,211,159,244,172,196,126,109,102,172,51,153,115,196,99,181,110,54,177,173,36,114,121,64,127,245,6,13,123,90,226,75,195,27,178,16,183,250,224,52,233,245,185,10,51,236,55,110,102,79,189,181,118,100,222,157,253,36,174,120,248,249,206,230,158,213,143,66,150,116,169,229,27,232,55,89,232,56,178,147,205,130,91,235,29,139,109,25,206,70,70,68,80,122,35,253,61,25,24,61,221,235,93,7,56,121,240,175,253,24,81,167,180,193,200,151,57,169,106,124,247,64,194,51,11,62,253,36,210,213,95,173,221,13,114,147,189,28,237,223,226,134,101,236,247,80,139,138,241,229,58,120,105,5,160,176,198,179,35,149,211,192,69,243,128,246,232,239,74,95,46,235,82,203,117,218,220,7,183,247,141,250,227,155,246,161,145,154,74,116,70,228,93,250,57,136,194,121,149,11,139,143,149,34,18,65,48,248,194,65,228,230,121,186,51,190,184,161,165,42,18,65,152,234,73,93,47,139,7,255,29,6,201,128,224,205,9,167,238,178,46,219,21,8,7,86,12,170,158,151,224,206,199,145,66,210,180,126,196,180,82,28,189,230,75,139,109,52,193,171,229,47,109,90,198,18,78,242,14,63,68,7,174,36,139,237,30,38,26,4,108,24,22,82,54,108,108,46,26,55,208,58,160,89,228,22,228,145,116,182,152,92,127,165,89,139,137,41,172,14,142,153,248,7,191,136,98,110,154,188,116,54,208,68,14,146,247,174,184,162,184,186,82,25,83,65,128,126,213,225,192,73,142,20,181,118,75,68,47,255,159,21,182,186,188,189,111,85,107,224,115,3,67,222,4,241,62,23,232,238,255,133,75,0,85,61,216,173,62,12,124,76,208,237,6,52,241,67,18,222,119,5,101,230,68,201,41,88,45,152,252,150,73,195,101,128,78,208,198,57,171,39,191,166,92,222,91,106,98,59,11,244,171,147,221,153,114,90,18,248,44,162,93,205,141,143,92,130,135,74,198,29,162,202,171,6,234,211,246,44,214,200,13,190,232,32,150,145,237,221,226,26,209,230,254,239,223,65,223,96,161,107,86,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f4922da9-3ec4-4fcb-93f6-37d8c2b2d734"));
		}

		#endregion

	}

	#endregion

}


﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLServiceProxySchema

	/// <exclude/>
	public class MLServiceProxySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLServiceProxySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLServiceProxySchema(MLServiceProxySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9ede723f-6621-4b3c-ae0f-44ad2d0ebf8f");
			Name = "MLServiceProxy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,28,93,115,219,54,242,217,157,233,127,192,177,153,134,106,53,180,211,222,220,131,99,43,227,56,118,170,171,20,103,108,249,242,208,233,100,40,17,178,121,161,72,149,0,157,168,174,255,251,237,226,131,0,73,144,148,99,183,115,237,93,103,218,68,192,98,177,223,187,88,128,77,195,21,101,235,112,65,201,140,230,121,200,178,37,15,142,179,116,25,95,21,121,200,227,44,13,166,147,47,191,184,253,242,139,157,130,197,233,21,185,216,48,78,87,207,107,191,97,73,146,208,5,194,179,224,53,77,105,30,47,26,48,147,56,253,165,49,248,134,114,51,118,156,83,220,51,56,133,63,138,156,206,178,171,171,4,198,13,192,85,146,205,195,100,127,255,56,91,173,128,180,9,0,84,230,207,41,227,23,215,97,190,54,67,54,91,184,200,61,147,211,182,241,224,52,92,240,44,143,41,115,65,76,39,193,56,229,52,95,130,4,251,1,130,115,250,75,1,36,110,5,201,214,32,76,55,210,179,163,130,95,35,240,149,212,145,11,230,29,157,7,63,112,190,14,142,230,140,231,161,212,13,0,2,232,87,57,189,130,95,228,56,9,25,219,39,211,201,5,205,111,226,5,125,155,103,159,54,2,98,119,119,151,28,176,98,181,10,243,205,72,253,126,25,50,74,226,213,58,161,43,154,114,177,47,201,150,0,70,41,89,228,116,121,232,141,171,152,188,221,81,160,113,237,214,144,225,170,48,97,89,203,74,178,139,128,63,189,162,203,176,72,248,203,56,141,128,57,159,111,214,52,91,250,53,224,193,224,103,128,93,23,243,36,94,144,117,152,243,56,76,200,2,89,171,113,70,246,201,184,206,235,206,173,224,215,136,4,132,196,195,148,131,88,222,230,241,77,200,169,156,95,203,31,100,129,243,4,4,138,194,6,17,159,124,90,208,53,138,98,74,25,11,175,40,57,68,232,29,111,118,77,115,250,148,145,148,242,143,89,254,129,100,57,225,241,138,102,5,39,84,47,33,215,97,26,37,52,34,81,33,208,45,194,36,33,79,111,247,238,158,6,228,2,4,92,0,17,183,207,238,134,68,225,134,95,223,221,121,207,91,201,57,78,178,34,82,236,177,163,117,252,35,221,144,67,226,85,135,223,142,97,216,123,174,184,166,105,36,25,111,151,130,144,171,156,174,91,133,24,80,58,42,217,91,2,171,235,156,70,177,138,6,229,66,219,4,180,186,36,253,113,202,53,154,183,229,202,153,194,119,72,190,223,235,33,247,52,166,73,36,52,150,113,8,66,52,234,32,23,20,67,18,8,27,52,111,163,76,35,1,177,130,145,47,8,196,164,40,75,147,13,25,67,184,33,248,239,33,254,119,26,166,33,98,121,77,249,68,224,243,189,233,196,27,60,239,217,251,35,157,19,38,149,1,70,26,131,39,245,210,49,198,168,118,44,96,201,251,107,112,105,249,247,190,157,64,213,228,3,221,244,162,47,249,83,102,244,62,20,166,179,141,137,228,5,134,198,109,172,100,156,198,232,151,241,175,148,145,16,188,226,35,40,29,77,12,164,0,49,132,3,185,86,28,105,6,3,233,207,45,172,136,17,112,252,112,69,82,200,102,135,158,146,239,101,158,120,35,148,132,150,247,229,249,36,56,216,21,144,238,133,146,115,185,72,139,175,177,192,248,175,138,93,233,34,203,115,144,101,37,109,150,129,193,27,97,208,143,115,52,40,145,242,128,28,206,65,208,32,136,156,146,52,227,56,0,219,148,120,109,7,169,138,194,87,42,50,12,14,181,214,66,237,239,105,145,36,3,114,43,194,80,188,36,190,156,8,198,236,13,76,156,229,39,171,53,223,248,3,242,245,215,68,101,89,76,216,124,204,94,197,44,156,67,52,58,152,78,202,137,75,70,69,170,25,249,3,141,114,135,95,231,217,71,161,193,30,198,125,71,60,26,136,232,181,115,39,254,251,190,164,185,180,56,24,69,75,249,161,52,114,223,176,42,215,222,117,155,37,136,105,77,33,5,208,182,0,62,30,71,128,54,230,27,69,216,187,60,92,195,10,242,62,118,142,63,223,102,109,203,240,225,72,178,233,198,76,94,188,32,126,219,220,33,121,45,42,157,163,245,250,66,89,139,46,138,64,39,23,20,77,146,83,61,117,154,229,66,77,223,237,73,21,189,144,153,93,22,46,27,84,239,65,11,233,35,223,59,249,4,53,71,10,91,45,64,75,204,27,72,20,251,247,64,49,24,244,196,138,170,82,182,139,209,145,74,43,185,172,152,202,244,2,6,177,24,244,198,180,155,56,231,5,148,1,86,102,81,249,228,130,46,200,45,185,130,170,147,220,129,152,219,210,78,87,112,189,92,39,89,8,89,59,228,225,35,144,39,177,189,2,100,110,10,255,177,215,69,139,208,82,188,140,23,178,30,123,56,57,10,225,230,241,196,117,1,81,2,35,212,195,105,67,76,244,241,8,123,25,242,197,53,97,143,70,158,192,215,65,227,247,123,157,170,60,135,106,30,60,240,113,212,104,144,61,182,188,242,199,36,83,160,236,163,181,87,110,11,56,216,65,232,121,44,23,168,34,116,211,244,236,187,110,162,160,126,207,49,177,87,5,165,11,17,192,189,206,226,45,74,63,77,150,74,242,2,235,133,68,58,165,252,58,139,222,64,221,98,211,229,237,170,61,119,25,194,122,247,141,99,15,165,208,68,179,54,250,112,187,221,66,128,117,82,7,41,167,148,95,156,46,179,71,35,17,16,43,17,142,1,109,159,24,113,235,93,24,239,164,181,37,10,63,148,82,29,139,91,104,92,168,93,105,190,171,14,92,157,68,214,227,240,131,141,17,35,93,11,105,24,84,183,36,203,17,246,30,74,153,66,217,66,155,10,96,89,131,188,182,242,69,226,105,169,39,213,33,241,38,139,35,114,124,77,23,31,116,181,175,138,51,83,178,139,159,72,77,89,179,171,177,127,133,73,65,237,146,221,30,47,11,247,119,215,49,84,124,216,169,251,172,98,220,218,223,46,194,239,170,220,8,54,102,121,152,50,56,198,175,116,15,234,36,207,179,252,229,70,246,36,124,113,28,213,83,160,51,249,23,77,146,154,149,138,212,10,61,44,193,116,7,76,146,160,228,176,50,138,58,212,107,176,1,150,21,249,130,214,32,85,151,197,32,20,196,169,14,73,48,203,80,88,227,165,62,229,64,141,93,2,130,96,184,60,54,3,190,82,48,132,126,106,96,51,147,176,30,133,107,196,168,8,80,34,100,31,99,76,137,126,185,92,138,232,56,139,74,121,236,44,176,109,134,7,26,51,23,92,166,33,148,235,224,142,191,210,104,95,130,89,170,180,103,101,85,110,246,175,115,163,8,113,238,2,199,130,121,28,65,209,174,183,184,9,115,66,145,193,87,148,135,113,194,128,241,39,94,169,201,101,158,173,44,85,236,147,91,243,227,142,0,167,215,228,167,219,182,45,238,126,246,200,183,106,155,157,39,222,109,157,78,213,183,170,240,137,184,28,156,25,244,195,10,181,93,172,190,201,248,105,86,164,14,97,246,249,133,167,78,51,138,115,111,104,137,96,168,25,170,1,137,67,251,18,247,243,186,136,18,221,92,56,89,225,98,154,11,203,210,244,25,59,126,226,53,132,234,88,119,247,51,233,16,233,36,187,146,134,171,205,19,4,247,105,240,89,2,119,32,112,177,246,50,140,148,35,219,182,165,92,247,101,22,109,44,71,126,139,237,19,10,44,193,17,54,206,25,63,203,85,241,233,175,245,17,25,254,89,7,179,205,26,4,114,72,74,120,28,208,241,2,113,14,94,4,34,36,62,223,70,136,134,66,144,157,109,213,158,222,241,91,88,86,49,241,91,139,254,14,225,62,154,96,213,17,183,106,179,244,83,79,116,22,73,70,217,163,246,221,158,152,220,8,83,26,82,18,88,13,85,213,57,240,172,148,238,183,79,31,103,120,33,192,203,48,230,130,169,88,62,230,55,31,114,250,192,33,37,50,58,36,127,223,219,35,191,253,70,90,65,192,64,246,74,130,119,118,122,114,85,41,9,173,179,59,245,231,60,167,225,135,231,237,52,99,213,31,157,21,188,131,173,163,121,150,27,198,133,3,212,18,89,53,229,213,50,154,101,89,16,69,87,33,247,29,215,9,149,104,228,206,121,37,107,54,75,78,211,66,75,61,202,175,10,188,190,1,214,206,150,231,97,122,69,141,221,58,234,130,238,146,104,203,118,142,221,251,141,85,108,35,216,199,238,110,128,119,182,117,237,174,108,179,14,20,142,82,111,36,214,91,167,218,138,156,85,155,55,157,0,107,243,132,174,68,20,186,48,91,15,73,189,37,185,99,6,64,237,230,71,48,203,227,149,150,42,218,125,165,165,54,203,55,112,18,241,77,179,91,210,9,248,241,212,106,245,249,101,181,247,21,32,120,115,50,59,61,63,154,158,188,59,59,255,81,106,214,2,11,240,126,174,78,2,236,253,21,77,24,237,130,22,37,71,30,215,58,173,168,249,120,41,13,130,32,10,237,115,22,18,88,108,174,38,52,95,226,14,151,154,241,70,7,87,119,127,45,98,142,162,72,229,132,31,104,24,225,85,138,108,23,131,48,84,147,184,210,252,117,90,217,219,140,113,38,15,179,60,19,55,10,108,77,23,120,60,138,148,19,117,217,25,94,45,218,182,54,195,182,189,10,167,160,143,53,168,4,65,130,131,221,18,210,109,164,198,95,189,145,8,4,234,122,131,85,42,136,238,107,8,43,15,201,187,8,93,71,207,97,164,123,41,47,187,21,114,165,238,130,48,186,104,46,204,41,47,242,148,149,156,62,101,138,87,0,213,115,85,7,155,9,49,31,204,70,126,163,116,7,187,157,255,27,160,236,42,96,40,250,41,134,166,1,249,136,247,162,100,182,143,86,231,247,156,25,108,11,145,86,245,79,150,165,10,206,175,6,70,83,36,72,43,13,222,65,189,42,154,226,238,251,12,119,47,123,72,166,147,75,14,181,102,48,157,8,64,56,227,174,117,132,181,201,49,151,147,34,81,225,79,56,154,165,193,41,212,208,192,103,150,70,204,183,216,134,115,9,15,147,105,156,36,49,147,179,18,165,44,154,172,204,93,101,90,203,90,177,167,232,112,22,0,54,22,43,226,216,195,1,118,101,48,127,218,55,68,86,106,176,211,143,255,164,44,121,111,29,81,67,29,7,84,53,92,41,162,164,221,168,219,211,130,17,56,22,16,149,133,228,177,192,208,99,178,250,221,144,204,11,110,214,166,153,112,228,64,22,59,68,147,130,241,42,76,35,114,162,250,2,218,153,136,57,123,60,241,236,220,184,79,170,59,218,115,119,94,37,28,205,202,236,42,83,119,85,108,18,82,210,87,2,254,63,36,61,106,72,178,210,56,166,111,20,222,231,70,153,63,127,88,49,220,144,111,200,179,61,209,108,222,46,96,124,94,180,216,186,222,235,187,232,23,45,106,38,2,10,207,195,56,213,61,220,109,139,60,144,127,136,30,231,141,96,207,80,58,143,178,215,21,68,138,228,41,214,144,104,251,24,8,202,108,213,101,253,184,234,98,113,77,87,225,56,2,172,19,137,135,48,49,68,228,5,44,54,81,219,243,163,30,64,235,53,240,165,27,33,199,24,240,26,140,86,114,168,188,207,127,93,128,105,11,25,205,80,58,170,17,109,217,185,96,126,40,225,42,164,107,171,182,14,218,170,120,179,111,5,180,185,171,232,62,53,24,80,156,66,154,135,102,155,6,208,56,194,105,251,183,12,145,210,150,170,27,213,14,155,176,80,228,43,23,208,200,119,223,92,148,46,166,40,105,92,213,14,156,129,55,208,253,251,168,55,4,203,251,136,90,16,150,222,176,173,69,70,194,26,95,41,4,242,230,162,219,228,152,38,79,6,188,166,201,72,36,100,87,186,136,60,150,72,227,169,4,68,105,50,34,26,154,123,21,109,43,145,177,147,114,63,109,35,34,121,10,207,215,231,61,108,139,250,146,149,242,208,162,22,85,1,101,231,212,98,97,240,188,197,236,12,73,53,163,147,117,134,36,80,142,148,250,18,135,19,245,119,219,178,68,224,114,221,29,25,11,113,94,148,247,31,11,94,66,0,75,153,144,186,22,246,182,138,231,150,135,106,93,86,98,90,103,240,216,38,3,227,99,48,71,246,181,21,47,232,159,41,202,125,161,238,42,93,229,109,130,217,68,155,65,21,208,169,231,26,143,173,202,22,100,28,151,23,78,154,160,154,230,109,61,87,49,55,148,237,200,179,195,230,83,141,126,253,194,25,154,137,251,65,108,161,160,78,194,57,102,80,91,223,247,77,65,15,211,187,14,250,10,129,168,131,105,64,198,75,179,154,145,133,110,155,13,85,209,219,199,67,253,68,166,178,73,229,42,179,12,201,48,172,21,100,77,187,140,231,119,176,148,58,77,159,97,32,45,108,153,76,35,145,137,116,227,134,29,249,109,183,188,253,214,214,86,230,239,236,180,23,250,242,34,145,17,249,8,27,106,140,139,251,229,24,145,114,199,234,69,228,165,168,83,68,145,82,62,146,252,156,72,163,168,178,200,41,239,47,96,190,27,143,121,193,43,218,241,172,196,134,230,41,0,217,61,170,126,231,211,224,230,250,198,137,231,172,224,162,98,211,228,151,22,208,126,240,209,94,98,145,91,150,13,78,31,194,77,180,2,15,240,199,200,55,197,151,165,18,71,156,29,18,179,203,88,20,165,117,177,169,252,87,61,159,116,60,191,41,27,36,216,122,174,244,72,234,228,184,124,20,165,150,45,253,58,232,64,217,117,157,56,71,133,160,48,212,33,7,173,222,110,56,80,158,126,80,19,201,168,82,138,10,199,111,138,86,249,115,109,87,0,173,19,98,71,9,161,184,122,245,41,21,232,76,46,252,175,228,231,88,92,77,98,6,238,113,130,7,206,152,50,217,146,73,96,12,171,11,121,70,18,117,224,31,18,47,162,186,65,235,176,161,63,15,88,255,207,135,143,49,234,235,224,149,196,10,22,114,32,227,137,238,104,140,70,68,43,85,249,131,35,222,96,245,203,40,151,193,166,69,230,234,13,248,227,133,30,77,86,51,94,232,231,228,42,108,104,64,59,92,68,146,98,21,46,164,8,228,144,184,203,29,233,251,17,80,46,13,241,146,178,93,64,242,16,7,101,88,185,143,142,45,184,145,180,120,185,141,189,131,95,94,183,162,51,188,67,30,253,15,116,35,230,200,225,136,232,191,203,187,101,242,55,213,31,197,167,13,39,64,144,13,171,122,140,98,39,188,179,40,231,130,31,233,102,88,195,52,176,247,197,23,254,184,64,44,173,244,29,145,244,122,148,195,195,83,139,110,213,131,20,219,14,252,182,240,110,157,195,24,229,149,152,87,53,216,166,173,218,54,215,200,105,141,72,218,85,159,31,135,73,194,200,162,250,64,238,158,39,240,102,212,156,233,118,144,29,57,251,35,166,55,26,151,113,145,44,197,87,67,34,170,212,200,19,152,251,219,65,19,21,107,173,47,87,170,15,1,161,26,5,29,226,247,43,221,77,161,234,170,51,217,219,213,143,255,218,194,73,143,159,216,237,34,135,125,213,141,136,220,106,155,192,215,37,121,60,47,196,215,91,0,185,12,241,242,79,229,220,6,127,205,30,144,178,44,55,164,195,214,164,147,152,224,208,17,31,111,165,226,238,134,142,151,145,14,59,149,152,155,15,218,91,154,74,82,238,141,71,42,253,38,46,30,66,50,130,95,100,8,107,138,241,35,31,145,141,241,4,119,21,223,80,25,178,84,213,80,187,7,16,182,118,31,71,80,53,3,184,225,117,200,9,187,206,138,36,34,107,154,227,241,81,191,102,223,198,21,196,87,22,86,123,85,144,109,227,156,83,129,142,246,56,214,218,97,55,158,117,249,31,161,13,80,8,27,241,178,188,114,80,59,40,21,224,231,157,55,113,132,55,247,75,217,83,199,15,3,45,43,228,25,201,110,104,142,223,71,90,5,128,17,90,119,18,199,222,44,242,33,52,228,206,226,234,109,172,114,61,161,80,127,58,17,114,150,239,198,164,158,122,189,110,72,230,89,86,18,89,17,201,163,57,164,11,185,246,79,197,71,151,99,214,64,148,71,6,211,71,241,75,137,203,100,45,125,83,215,234,157,181,207,37,126,71,215,148,145,190,172,143,193,216,217,127,189,147,202,10,95,124,178,170,232,214,14,43,233,255,203,123,43,115,187,171,176,200,138,207,142,186,156,246,222,149,119,175,19,99,85,189,200,10,241,4,102,26,242,235,96,26,167,254,179,33,49,165,50,78,234,139,120,83,130,151,224,225,39,191,254,165,208,55,18,227,208,249,29,145,85,81,255,121,130,71,41,213,251,196,5,45,170,238,80,208,127,247,46,125,141,217,223,43,129,223,164,112,118,201,177,183,46,74,250,63,50,34,244,215,175,247,61,249,183,199,5,228,203,240,221,95,201,26,215,171,200,167,187,106,21,78,21,101,240,131,142,244,39,23,15,63,251,218,30,230,112,26,231,183,98,223,212,252,110,216,254,93,217,99,249,81,165,42,174,72,194,225,53,246,188,235,180,101,252,164,241,229,138,242,164,123,122,201,125,188,163,242,241,28,26,142,49,242,130,225,163,237,207,72,123,165,85,119,155,178,192,239,141,46,241,15,204,26,87,148,215,8,234,123,148,2,225,40,98,66,231,222,232,77,177,154,203,43,86,149,28,51,131,76,48,38,250,11,184,103,55,214,101,156,112,154,143,17,7,156,23,53,42,57,186,245,74,20,131,20,6,18,36,39,134,91,44,62,74,240,127,199,176,17,159,0,132,232,145,138,142,83,49,43,158,134,134,18,68,62,165,21,48,218,235,241,3,142,174,6,89,93,246,10,247,229,26,132,173,213,45,113,245,202,61,76,22,69,2,171,46,165,10,207,205,136,66,83,213,163,238,152,90,71,101,67,192,238,200,113,249,89,253,8,179,204,73,229,176,59,211,11,79,195,24,52,146,100,200,167,65,182,157,224,183,155,123,202,171,44,104,75,117,213,254,89,149,142,211,170,134,73,77,227,226,65,108,7,124,32,62,226,178,139,140,46,173,139,59,178,130,14,29,93,51,82,74,175,74,173,192,89,87,143,14,87,91,156,64,170,212,171,24,40,81,35,170,113,132,128,50,44,92,80,252,31,62,249,162,135,134,31,94,93,136,136,238,15,240,177,35,18,236,15,26,109,253,243,170,30,108,181,40,216,211,138,26,44,233,190,216,98,63,221,28,19,226,146,9,102,84,82,81,215,220,97,93,119,22,74,196,152,125,132,185,20,68,21,135,41,175,97,105,85,87,151,54,135,150,24,21,120,169,68,99,107,117,197,213,117,105,95,128,212,122,121,110,143,105,45,209,238,127,86,107,251,46,186,235,5,153,28,173,14,138,49,251,159,255,0,67,182,130,75,132,76,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9ede723f-6621-4b3c-ae0f-44ad2d0ebf8f"));
		}

		#endregion

	}

	#endregion

}


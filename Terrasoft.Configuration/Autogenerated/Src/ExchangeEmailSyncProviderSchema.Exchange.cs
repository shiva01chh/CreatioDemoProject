﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeEmailSyncProviderSchema

	/// <exclude/>
	public class ExchangeEmailSyncProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeEmailSyncProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeEmailSyncProviderSchema(ExchangeEmailSyncProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("32028a2e-2477-480e-a573-14f866c4379f");
			Name = "ExchangeEmailSyncProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,29,107,115,219,198,241,51,59,147,255,112,97,59,13,152,208,176,29,183,77,171,72,244,232,233,178,177,108,215,146,226,153,122,60,30,136,56,74,136,65,128,198,129,146,24,143,254,123,119,239,133,187,195,225,65,217,121,120,38,249,18,17,184,219,199,221,238,222,238,222,98,77,178,104,65,217,50,154,81,114,74,139,34,98,249,188,12,79,214,217,44,60,188,153,93,70,217,5,253,226,79,31,190,248,211,96,197,146,236,130,156,172,89,73,23,223,59,191,195,253,60,77,233,172,76,242,140,133,79,104,70,139,100,86,27,243,52,201,222,87,15,109,92,190,231,251,121,54,79,46,86,69,132,96,253,3,10,218,244,60,60,216,107,124,117,152,149,73,153,80,230,31,176,88,52,99,11,143,162,89,153,23,214,92,181,74,100,135,28,39,179,34,231,131,213,195,240,21,61,63,161,197,85,50,163,44,60,136,202,8,230,17,248,79,76,189,72,243,243,40,221,218,18,72,195,167,249,197,5,60,182,22,238,132,150,37,252,201,0,186,67,138,181,60,161,49,20,230,3,132,251,247,239,147,109,182,90,44,162,98,61,145,191,247,211,136,49,50,207,11,194,96,205,47,139,60,75,126,230,211,201,117,82,94,86,156,208,69,148,164,44,84,80,238,27,96,94,31,208,121,180,74,203,189,36,139,1,89,80,174,151,52,159,7,123,17,163,106,58,238,231,139,34,191,74,98,90,140,198,228,25,136,23,80,63,84,175,15,17,184,57,102,56,122,3,128,151,171,243,52,153,145,25,39,177,113,44,217,34,62,52,48,255,3,231,122,240,231,130,94,32,67,176,58,172,140,178,146,109,145,23,69,114,21,149,84,188,95,138,31,100,134,239,9,43,11,190,133,28,13,108,44,157,198,72,234,163,111,255,245,183,131,131,71,187,247,246,14,255,249,221,189,191,253,227,239,255,186,183,247,232,31,127,191,119,248,96,119,239,209,193,195,135,223,125,247,96,127,40,150,185,182,206,252,193,9,101,12,169,72,50,88,236,133,88,98,80,129,101,10,168,67,61,203,92,87,63,97,111,153,0,52,5,56,167,114,62,18,248,26,153,151,72,166,241,22,249,240,224,118,76,86,229,140,100,249,53,252,122,8,191,144,165,243,252,6,126,125,123,251,134,144,86,114,159,70,172,68,136,7,8,126,145,100,171,146,50,146,207,231,140,150,92,90,230,73,90,10,57,147,162,1,140,213,68,104,89,228,32,228,172,131,189,130,70,113,158,165,107,128,80,146,183,169,129,248,88,224,125,206,209,182,81,187,205,40,44,83,65,231,59,195,6,99,193,77,138,65,219,97,81,228,197,191,105,186,4,97,187,63,1,212,40,26,179,174,157,208,164,54,67,131,13,130,119,198,3,73,247,159,105,22,11,65,108,145,202,188,4,139,73,227,22,78,79,47,41,201,86,139,115,64,148,207,73,2,18,196,212,50,211,24,247,224,124,185,32,17,108,85,70,9,24,240,119,209,69,19,79,252,73,1,155,87,188,99,147,105,73,18,6,34,150,164,169,185,152,62,197,10,95,0,204,41,32,222,207,87,89,137,139,247,53,121,20,110,223,87,160,196,122,73,78,72,70,175,165,252,226,238,226,212,195,148,46,40,240,203,167,131,228,62,252,246,81,199,18,29,37,52,141,155,180,86,111,201,211,132,149,219,167,96,123,38,98,11,240,55,254,68,59,137,84,24,239,63,16,105,163,44,163,114,12,107,8,244,141,200,109,111,122,172,253,170,152,230,168,180,189,63,202,83,88,54,160,106,206,255,168,206,197,239,237,89,122,194,9,141,138,217,229,17,104,24,172,182,249,163,154,74,222,242,173,119,31,55,65,20,36,144,183,179,85,81,192,218,139,159,206,224,243,60,79,1,44,219,55,199,188,80,162,117,7,237,131,3,233,140,33,117,89,38,168,235,165,104,138,28,123,42,121,187,178,126,247,81,170,98,133,7,51,238,19,63,71,112,68,35,11,211,12,142,255,40,77,126,166,92,86,20,149,168,99,30,117,168,159,87,4,88,227,7,230,50,226,138,232,90,66,38,15,98,133,143,143,77,243,40,86,214,115,94,228,11,18,163,64,47,163,2,142,71,220,250,22,189,229,131,8,186,105,59,67,123,101,134,19,131,224,150,245,223,190,207,97,248,65,50,88,87,90,112,54,119,99,88,97,198,134,147,19,254,76,208,75,34,241,180,29,10,242,199,97,176,35,224,14,13,250,112,242,180,131,231,86,128,200,169,114,105,44,62,57,22,109,172,212,136,38,118,165,95,209,184,155,129,35,123,246,2,143,213,73,92,95,164,49,66,31,12,144,211,211,4,92,156,250,2,140,137,151,84,98,114,134,246,106,149,166,35,14,108,139,148,151,9,11,106,36,212,113,91,48,70,228,3,159,254,180,70,1,64,175,147,197,77,193,237,239,64,63,62,123,153,255,221,139,232,230,2,120,14,142,124,128,187,254,100,149,196,129,233,24,143,198,14,226,80,30,30,72,93,136,42,240,63,240,67,124,210,170,228,211,49,235,128,185,102,231,97,212,153,77,156,69,235,227,199,92,34,189,92,245,80,155,145,192,240,35,45,152,192,111,226,10,77,47,88,12,108,246,79,219,230,186,142,44,0,66,141,178,92,246,64,146,226,250,143,0,183,217,219,132,200,186,156,74,1,114,184,29,253,26,74,221,87,95,75,41,11,24,181,12,39,82,74,8,62,253,25,158,110,174,152,232,6,227,3,20,114,169,151,72,118,9,143,29,211,178,153,90,181,232,205,169,193,2,49,249,233,165,39,230,132,54,133,104,18,139,219,118,135,7,24,0,105,192,12,134,233,238,84,12,123,117,222,82,43,129,254,66,137,167,114,175,149,188,182,201,81,215,153,222,224,234,9,210,244,97,233,57,170,62,130,166,147,218,1,35,194,239,85,150,188,95,81,2,155,157,149,201,60,105,166,78,225,82,81,247,58,99,122,79,190,55,232,151,3,78,204,247,21,225,242,175,65,65,203,85,145,249,192,32,23,237,172,24,186,248,146,46,192,63,214,145,24,108,224,49,45,35,88,238,8,78,146,214,101,206,175,192,51,135,73,194,205,55,38,146,157,9,249,210,49,195,220,170,176,35,26,1,209,244,48,139,206,83,26,7,195,131,252,89,94,26,51,143,114,33,193,195,209,134,121,143,118,129,208,148,170,149,173,242,29,141,235,122,194,135,66,152,131,24,2,95,138,100,108,239,208,88,203,93,120,86,206,158,229,215,240,190,233,108,80,27,212,172,125,176,34,151,121,45,66,245,46,199,217,18,149,131,17,60,70,106,94,16,215,155,171,40,93,181,198,236,191,176,31,4,209,122,73,111,74,11,22,106,211,190,124,222,232,178,72,141,185,202,147,88,178,105,30,129,93,30,139,129,130,72,18,148,77,76,230,36,144,143,148,131,193,77,100,25,21,165,58,184,39,213,134,194,97,251,35,174,161,154,62,184,138,10,178,226,4,201,84,128,160,174,230,29,12,143,69,130,76,216,95,233,161,9,235,62,24,64,32,94,6,67,147,163,225,24,226,204,116,181,200,194,23,202,212,117,145,57,210,208,94,93,210,130,6,195,186,208,13,71,225,148,29,190,95,69,105,80,131,110,249,23,30,121,149,2,59,16,204,134,135,55,116,6,110,71,48,234,105,104,0,52,35,206,174,107,141,193,125,95,138,83,102,221,42,163,150,28,120,142,51,229,249,89,166,16,54,134,89,58,108,165,158,228,176,183,31,30,220,194,162,227,241,26,62,163,215,252,152,29,117,187,57,96,204,76,174,172,45,4,166,96,203,174,240,232,4,83,83,230,230,64,37,80,63,36,89,28,62,205,103,81,138,195,57,235,61,181,243,147,4,192,194,196,177,9,167,160,133,17,204,192,137,145,230,46,232,227,21,86,193,82,199,150,32,85,109,81,53,196,152,8,230,18,47,30,12,119,6,19,173,184,130,248,236,52,135,247,129,47,238,85,51,164,48,122,97,99,108,234,162,218,169,43,182,212,161,199,238,96,249,124,203,125,30,130,126,72,15,60,104,246,223,37,97,242,68,49,135,133,167,57,95,124,36,34,232,39,111,34,213,199,179,228,160,249,237,25,88,177,105,71,246,12,255,110,122,83,132,4,206,67,49,91,252,102,90,199,208,240,205,221,204,161,48,129,155,36,27,117,154,20,175,163,18,88,136,231,96,5,34,112,109,195,231,133,92,181,10,83,43,124,105,217,78,243,192,73,77,158,204,46,65,39,228,15,126,39,53,214,32,120,50,143,133,224,124,80,227,61,222,33,25,200,49,96,237,65,192,225,77,2,176,186,177,75,200,238,226,161,36,5,226,97,219,136,102,252,192,68,80,145,58,178,101,206,133,213,199,241,55,92,143,238,203,131,174,204,62,16,153,10,23,83,44,5,195,68,118,179,103,169,115,181,218,101,227,54,223,11,37,0,172,13,121,113,161,43,172,211,5,144,227,200,151,50,61,97,251,128,198,25,55,80,35,141,196,191,139,85,29,138,8,216,14,219,193,118,237,26,208,81,184,146,216,21,42,1,5,142,51,227,86,55,77,127,200,242,235,76,188,66,241,12,143,217,133,248,245,50,207,203,49,233,58,190,229,233,237,102,237,11,152,44,255,220,113,41,8,241,210,53,144,215,201,99,32,84,1,145,75,128,158,60,112,35,55,98,111,45,196,48,168,64,142,61,214,67,249,11,132,166,76,5,97,198,154,158,68,115,138,104,37,208,10,187,197,159,41,1,103,211,152,133,63,208,53,236,177,218,87,115,187,4,226,3,186,44,232,12,172,156,6,140,34,35,209,118,91,221,62,178,61,245,221,153,220,73,190,189,144,42,223,198,123,57,243,73,45,239,110,22,27,214,47,46,162,121,121,212,199,254,130,1,170,153,96,100,70,154,192,41,59,64,80,99,82,22,43,101,94,253,220,112,67,103,224,53,244,169,87,52,9,130,162,211,47,34,6,162,241,52,83,52,13,71,150,2,206,86,172,204,23,152,228,128,105,61,248,116,204,252,89,153,164,73,185,158,66,40,40,28,185,105,44,19,38,107,165,47,252,12,201,203,253,13,17,161,61,247,16,167,160,182,44,157,31,153,165,23,45,46,26,16,229,201,151,124,217,232,44,61,246,12,23,111,182,186,50,158,32,121,60,225,24,252,101,232,189,77,248,234,67,253,241,237,87,99,187,130,0,135,53,226,193,209,96,0,87,105,201,199,213,185,189,253,106,104,136,151,103,53,124,140,91,2,148,226,174,59,20,185,30,177,199,17,54,132,195,216,201,14,21,123,82,128,168,211,226,20,94,122,117,12,145,30,231,49,102,159,98,164,88,222,26,13,106,52,246,144,34,227,141,26,221,190,95,210,71,138,98,26,199,99,245,139,135,32,184,240,14,1,213,186,15,0,217,83,56,163,144,41,245,86,158,37,77,100,119,134,155,0,146,164,152,184,45,1,40,209,27,35,105,146,177,88,148,178,92,154,117,255,50,52,154,111,79,52,230,16,58,156,224,95,156,251,230,76,70,51,227,134,122,186,43,96,120,45,253,114,107,83,230,34,153,194,57,89,64,176,105,88,194,186,163,195,69,187,97,34,191,55,208,21,96,136,150,171,133,107,157,199,100,216,136,122,76,30,26,135,140,139,136,223,36,58,156,163,80,30,68,107,22,52,81,101,198,11,189,2,6,69,220,38,170,228,34,31,213,45,153,203,75,171,94,56,131,209,94,37,106,149,107,111,21,167,183,195,238,243,115,110,198,18,29,49,37,227,103,50,73,196,45,7,149,85,52,234,214,99,86,185,25,81,65,73,116,5,90,143,178,197,139,181,176,70,6,115,43,61,21,37,225,197,61,90,193,38,232,64,19,170,42,1,57,55,205,105,138,163,52,186,32,88,9,56,227,121,206,143,33,151,184,65,176,242,199,174,146,162,4,31,70,228,178,97,105,142,243,130,238,42,16,70,112,7,100,112,71,237,37,63,92,216,182,37,66,19,98,243,169,212,76,6,99,246,203,208,66,241,209,206,40,218,0,46,20,96,150,165,183,187,137,27,202,35,154,169,240,176,5,43,30,128,218,27,173,143,214,135,173,14,143,204,215,58,52,202,32,12,51,139,129,166,16,177,220,192,172,7,134,171,103,13,168,133,102,222,233,181,58,40,177,81,248,54,184,193,235,136,39,42,34,129,248,234,102,132,41,32,243,137,141,114,52,114,237,161,168,142,59,121,151,44,151,58,148,0,172,50,73,21,158,230,160,160,143,190,13,26,43,157,70,228,27,15,219,50,218,7,41,136,102,151,36,144,238,162,140,111,176,238,174,206,21,146,16,248,168,169,44,122,35,17,64,240,28,142,62,170,60,0,123,153,119,12,220,134,139,18,1,222,43,240,115,213,82,89,1,48,102,75,245,214,214,195,222,151,58,34,156,198,184,141,60,201,122,184,88,130,135,172,136,29,212,224,115,27,214,8,70,225,186,173,40,156,43,12,246,150,86,220,52,211,231,134,147,152,40,136,146,140,65,88,25,40,176,163,205,104,117,64,190,86,96,222,56,148,107,179,161,130,6,0,1,161,246,243,44,93,155,79,156,115,204,120,85,153,36,44,138,54,94,132,83,14,197,245,51,127,76,0,144,3,110,42,159,7,86,249,101,197,176,77,73,141,58,229,100,234,90,5,4,243,76,20,146,126,93,175,203,148,252,215,50,18,27,89,84,57,155,91,233,132,29,71,55,28,180,194,227,136,184,26,101,218,89,103,72,156,107,110,109,68,150,56,33,121,58,209,81,73,214,184,161,100,114,172,87,92,237,194,64,152,71,20,152,151,200,91,240,68,134,170,220,186,26,193,185,77,196,184,174,127,250,66,102,224,101,63,144,136,68,37,236,118,125,23,204,233,206,186,212,78,61,231,48,83,18,76,174,47,19,152,16,184,16,254,250,87,207,150,152,218,247,165,51,163,146,180,54,163,133,46,138,34,218,144,48,125,102,40,149,82,24,92,2,42,113,214,147,191,249,70,1,60,7,227,251,206,130,115,107,158,216,98,53,187,43,3,104,6,150,177,94,128,38,174,169,231,73,150,176,75,178,16,181,192,191,222,53,108,221,185,225,209,7,18,107,220,128,29,113,234,104,220,126,153,106,166,255,237,55,252,42,81,90,22,163,70,118,183,184,88,225,250,7,46,35,110,125,151,20,16,179,92,90,22,41,93,170,90,37,158,62,23,223,196,172,209,207,217,174,15,158,4,30,170,36,104,1,39,108,226,219,186,196,239,118,155,247,121,40,206,200,106,169,107,109,73,84,150,112,132,11,29,252,41,63,239,187,197,119,189,22,183,202,236,15,111,192,246,100,176,185,49,93,98,254,55,155,173,209,219,197,48,74,214,42,249,171,232,45,153,16,76,157,113,150,118,53,51,255,201,207,131,150,4,186,147,10,11,155,129,168,43,236,51,39,76,236,149,189,110,219,12,129,140,249,119,129,124,118,219,224,174,29,195,111,185,54,217,2,63,128,95,110,249,51,224,239,157,243,181,136,244,43,107,230,144,202,239,225,188,95,134,193,188,8,14,214,75,90,127,37,205,232,175,88,199,107,236,14,223,21,206,37,238,2,141,213,71,125,253,173,101,139,21,67,88,107,35,89,93,40,91,102,27,46,129,95,99,174,229,90,156,156,55,95,181,97,175,18,191,234,166,207,168,239,219,176,96,12,56,17,135,170,233,106,244,46,29,195,128,208,11,161,77,234,229,225,92,243,109,54,137,161,29,46,94,130,170,82,112,164,209,213,235,77,60,151,14,115,38,191,94,50,226,94,176,0,234,207,138,118,253,82,4,182,31,65,244,51,74,99,172,156,67,37,223,157,161,25,81,187,191,81,229,94,35,152,192,89,240,202,113,190,27,189,187,203,101,186,222,231,6,171,89,66,44,171,170,30,112,17,231,9,178,11,249,133,32,255,62,75,24,127,233,88,201,218,23,29,62,84,224,45,203,235,219,67,147,48,159,224,141,173,77,69,3,101,108,233,221,214,2,63,198,77,202,59,45,134,227,129,152,199,30,155,129,71,179,2,95,188,140,216,187,77,86,192,34,167,77,247,204,194,185,179,30,89,232,167,246,121,52,205,78,192,72,75,247,222,200,67,183,30,92,222,203,227,78,111,195,202,226,120,138,7,155,78,69,123,122,147,215,232,159,221,80,111,31,238,131,137,200,206,150,190,162,251,160,241,214,222,123,238,180,225,189,171,36,242,8,239,25,189,230,113,238,239,69,49,167,135,25,4,16,5,138,209,182,184,96,229,233,0,135,218,30,199,132,78,87,85,80,122,84,92,117,165,91,37,117,37,237,82,225,54,190,172,12,170,11,177,141,53,252,46,160,70,130,35,248,205,53,51,181,188,162,43,244,45,229,8,86,117,145,55,69,108,46,173,100,190,55,207,207,211,248,99,217,70,159,171,95,50,186,202,30,254,81,214,243,153,148,245,56,183,230,159,127,33,204,38,117,48,191,143,218,141,63,202,37,186,202,37,54,172,64,107,187,1,82,3,205,133,252,227,74,230,143,43,153,166,43,25,201,208,39,185,99,249,200,171,145,190,55,35,40,3,46,124,231,202,215,78,211,171,253,250,5,238,84,170,171,141,150,155,122,75,203,55,187,39,224,37,23,230,135,26,134,151,233,84,72,244,46,65,114,43,43,142,68,203,36,146,98,133,133,104,230,194,81,169,98,139,246,47,181,106,107,35,75,53,212,153,46,190,117,52,62,117,108,44,218,112,10,45,132,35,168,178,157,141,14,97,211,30,222,81,148,133,97,175,44,163,103,239,165,144,157,200,160,94,156,16,60,144,134,255,237,16,196,39,158,237,241,84,29,63,216,208,101,11,218,250,189,132,198,167,4,218,188,91,148,114,66,209,196,251,43,70,180,90,96,15,29,61,209,238,41,163,180,195,107,184,150,250,235,221,79,96,177,6,94,10,200,57,172,141,8,0,43,111,83,101,162,149,235,135,188,110,123,167,79,12,103,20,27,183,225,23,148,21,213,150,125,168,16,185,213,32,202,223,55,147,106,6,179,38,190,64,236,233,184,34,219,248,130,168,130,55,216,245,156,175,53,177,81,163,149,169,29,12,214,216,193,135,104,123,160,8,114,140,150,113,199,248,49,209,39,122,111,74,98,3,91,116,199,226,163,183,81,255,128,212,72,109,181,192,37,106,249,228,55,180,16,64,56,151,16,40,67,196,159,223,108,16,160,57,188,255,36,2,84,59,67,193,221,0,2,141,200,173,66,85,255,214,99,19,225,209,112,106,159,159,57,65,144,193,154,69,157,5,85,50,160,132,253,206,164,36,177,79,150,79,74,225,102,203,79,70,75,26,30,208,148,242,239,121,12,217,117,14,50,75,112,239,152,81,226,238,247,51,122,173,36,232,78,178,88,131,226,23,72,243,174,133,127,72,185,193,130,111,110,59,56,134,218,214,127,202,197,227,153,1,222,100,236,78,41,37,209,141,172,2,226,230,240,237,62,102,31,65,39,198,110,24,46,165,107,21,73,241,99,185,179,121,192,111,152,70,68,2,21,125,220,213,104,99,192,123,15,32,253,106,113,113,199,69,226,191,43,90,172,201,194,132,112,200,222,55,165,32,45,10,122,100,33,95,21,9,102,250,41,38,138,213,58,96,25,59,214,187,166,249,5,214,12,207,210,21,247,247,204,38,144,209,121,190,42,69,145,236,205,140,46,69,99,200,203,8,248,136,86,120,75,139,253,159,4,208,190,151,170,2,54,120,151,252,255,234,12,224,237,151,34,171,17,3,56,119,170,208,165,213,209,212,132,13,39,135,55,226,175,14,207,180,192,238,71,250,228,224,248,124,141,88,236,123,13,93,159,45,41,22,243,248,135,160,114,93,52,33,99,241,197,52,35,249,249,79,224,140,189,126,67,16,165,149,122,212,208,20,24,99,50,31,220,144,254,151,247,29,61,211,255,6,216,182,91,220,219,198,6,172,82,71,69,7,38,221,7,139,223,187,139,182,83,158,166,154,66,169,191,240,244,98,181,91,166,122,187,190,24,237,82,171,166,116,31,236,187,102,174,107,128,16,20,81,180,214,96,173,237,95,248,96,16,85,213,64,129,196,57,48,4,1,38,44,14,126,65,42,117,130,223,133,180,90,201,26,94,242,44,87,84,30,65,112,29,43,145,218,153,8,61,117,199,7,98,79,157,79,46,94,229,96,113,176,157,113,8,129,72,190,42,102,20,27,243,0,28,117,33,95,235,203,37,140,199,176,190,14,161,159,160,144,135,26,195,81,120,154,75,66,84,83,148,77,91,20,58,139,172,238,15,145,219,13,187,137,125,22,13,212,218,26,20,221,185,201,153,213,145,169,71,15,48,235,110,248,142,45,150,166,96,111,208,130,145,15,152,122,255,158,220,242,52,239,197,113,148,129,120,200,19,248,2,254,170,58,91,180,247,205,81,61,178,140,141,241,181,39,129,221,233,221,210,72,16,138,177,53,145,160,204,86,69,194,28,246,234,247,244,43,244,6,22,180,98,197,73,99,31,181,14,210,63,201,23,243,110,75,148,70,98,218,218,163,244,156,190,88,177,146,128,139,115,29,173,25,57,199,158,108,23,176,84,87,84,184,90,180,80,254,44,203,21,228,8,187,245,114,93,194,68,181,208,194,34,186,22,182,8,9,202,89,194,33,240,153,12,92,0,152,112,78,85,203,19,116,46,242,10,141,24,212,215,201,208,120,116,55,55,217,94,186,165,181,145,148,17,144,6,41,53,253,74,96,203,198,101,11,80,64,20,37,250,123,151,150,14,125,106,44,217,222,33,15,200,227,234,247,22,185,247,144,124,173,127,247,168,34,110,22,140,22,89,56,142,110,120,123,61,103,211,60,141,98,0,70,148,197,245,145,14,30,5,88,238,48,247,24,81,7,55,39,237,213,37,133,125,17,244,233,118,52,76,1,166,120,87,102,113,172,110,144,68,14,0,204,98,248,159,232,42,98,179,34,89,150,176,236,234,181,17,91,148,136,193,128,80,191,132,26,242,54,161,66,72,57,43,209,93,22,249,14,93,121,218,173,108,88,191,128,19,157,131,176,63,147,68,222,222,9,215,250,234,180,11,89,173,65,81,3,154,126,10,211,214,233,167,106,131,102,53,188,241,105,146,183,111,44,153,216,253,123,30,251,198,216,253,120,132,173,134,179,48,196,222,65,193,95,60,219,209,248,21,184,231,163,242,150,239,200,253,95,50,99,126,201,134,82,93,134,118,136,178,78,214,56,84,212,196,216,200,213,116,218,16,145,135,208,57,123,215,110,230,60,180,96,222,195,68,148,52,88,138,160,148,7,173,29,15,248,124,150,102,87,166,162,152,238,103,229,3,239,222,197,181,227,137,19,238,94,1,123,120,45,51,187,228,81,56,94,6,26,12,22,112,134,161,243,81,230,30,116,118,38,183,195,175,49,168,52,110,55,55,91,9,149,38,118,33,108,108,75,170,229,236,99,70,244,104,20,107,28,180,151,223,108,102,76,188,132,79,84,232,133,53,32,155,174,107,103,71,227,95,232,219,150,210,42,121,122,46,68,61,224,117,174,214,194,138,158,111,196,199,248,216,109,20,239,47,238,150,43,47,141,152,6,44,107,53,180,236,110,139,144,66,224,83,157,137,206,228,181,189,206,143,243,143,151,44,56,214,157,191,84,229,253,28,220,34,182,204,249,247,5,244,144,189,87,41,75,55,33,229,68,40,161,57,64,134,15,170,230,65,73,213,145,15,197,208,41,18,170,17,16,190,40,18,20,101,142,85,54,23,156,178,93,238,112,158,80,188,212,178,191,224,146,241,149,144,151,105,44,102,200,127,187,165,17,7,196,84,98,96,48,148,159,135,69,229,229,80,92,178,217,112,221,123,154,141,225,219,162,29,130,22,88,104,26,65,200,138,40,241,5,126,195,32,185,224,50,61,46,102,188,2,51,162,155,49,178,64,221,151,47,64,210,19,150,243,20,110,200,107,138,170,86,146,195,113,21,106,141,204,154,130,247,184,7,242,90,180,141,93,188,99,229,242,96,220,175,122,191,201,26,88,194,106,130,15,79,243,74,194,3,117,64,170,175,192,17,3,82,46,87,149,159,95,82,13,38,65,125,235,71,74,20,123,193,17,21,46,205,27,109,127,189,237,158,56,122,93,248,15,217,232,187,73,89,85,29,141,85,53,179,227,181,25,253,156,123,157,138,171,238,57,127,139,175,90,236,20,105,213,178,187,74,71,244,255,188,101,193,88,61,29,254,17,86,169,161,99,170,12,199,133,150,47,133,205,177,148,219,71,135,16,43,67,189,125,131,120,49,147,172,11,3,121,123,225,194,14,70,166,5,240,66,48,236,199,177,234,254,77,139,36,143,29,186,77,159,181,147,120,19,170,229,190,155,228,40,192,230,193,177,25,228,38,247,193,131,197,39,247,155,239,193,240,181,109,99,183,112,242,150,220,116,252,251,141,107,117,85,78,206,23,127,111,196,172,63,77,210,185,189,166,109,247,14,184,155,65,23,43,227,107,215,235,109,28,61,250,237,40,92,179,221,120,145,100,103,96,40,106,159,239,90,255,60,67,117,32,121,206,35,47,97,189,207,34,238,32,89,71,208,110,182,14,170,82,192,18,34,156,107,110,118,240,99,158,68,124,117,169,111,121,2,187,19,176,63,225,222,182,236,226,52,17,164,114,73,148,0,220,115,241,40,41,88,105,22,152,215,117,254,71,121,73,109,64,241,30,116,42,4,156,4,126,187,97,34,49,181,184,7,104,116,135,39,65,131,213,48,224,250,52,190,7,120,251,136,246,155,11,95,77,179,83,205,172,126,114,137,108,249,71,41,164,137,121,130,214,128,39,33,205,201,129,65,108,175,127,90,68,18,86,101,179,251,242,91,59,149,244,23,68,245,34,231,42,89,210,32,31,254,185,118,162,178,139,172,36,43,39,65,135,213,28,85,136,188,129,147,19,51,249,195,165,150,127,36,164,126,103,201,95,192,127,255,7,184,177,189,152,17,116,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("32028a2e-2477-480e-a573-14f866c4379f"));
		}

		#endregion

	}

	#endregion

}

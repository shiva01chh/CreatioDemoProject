﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastDataServiceSchema

	/// <exclude/>
	public class ForecastDataServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastDataServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastDataServiceSchema(ForecastDataServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("08760552-aaa7-433d-9c0c-32c521adaf87");
			Name = "ForecastDataService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,61,93,115,227,54,146,207,222,170,253,15,136,110,107,34,215,233,232,108,30,237,145,92,51,30,123,226,236,120,198,103,107,146,7,215,84,138,166,32,155,23,138,84,72,202,19,197,235,255,126,104,160,241,73,128,162,44,123,108,95,93,30,50,38,62,26,141,70,119,163,209,221,128,242,120,70,171,121,156,80,50,166,101,25,87,197,180,142,14,138,124,154,94,45,202,184,78,139,60,58,42,74,154,196,85,253,203,143,127,255,219,237,223,255,182,181,168,210,252,138,92,101,197,101,156,237,238,30,20,179,25,107,244,161,184,186,98,197,123,170,254,124,89,213,116,230,126,51,208,89,70,19,128,91,69,239,105,78,203,52,105,180,121,207,65,167,127,241,225,27,181,31,210,252,143,70,225,217,34,175,211,25,141,206,25,192,112,215,115,154,44,202,180,94,122,42,202,155,52,161,39,197,132,102,173,149,209,27,134,251,77,8,186,209,238,87,122,217,104,96,149,125,164,95,107,70,4,32,247,207,149,9,237,191,23,113,89,255,229,126,71,199,179,121,22,157,196,117,114,77,203,74,215,154,139,6,11,225,175,41,105,116,200,8,84,167,52,208,149,53,56,138,147,186,40,219,90,156,179,177,39,139,140,150,225,22,6,9,24,19,213,37,131,233,107,204,40,161,241,101,245,255,81,210,43,70,82,114,144,197,85,181,75,36,199,189,139,235,24,65,242,102,23,248,33,65,247,63,50,230,37,67,210,155,98,135,40,158,167,189,237,47,208,244,77,53,255,72,107,54,200,156,173,214,101,154,177,101,63,163,127,44,210,146,206,104,94,87,125,243,3,240,101,96,86,116,129,86,17,22,76,248,32,243,197,101,150,38,36,1,172,125,72,147,93,242,54,174,168,154,194,214,45,159,134,154,238,97,190,152,237,18,38,18,139,89,62,94,206,197,36,183,118,118,118,200,235,106,49,155,197,229,114,36,11,206,231,52,73,167,75,82,95,83,194,102,59,91,100,49,169,104,93,3,93,107,214,53,82,61,119,204,174,136,33,101,3,1,130,208,237,92,244,18,227,109,1,74,91,91,91,239,232,52,94,100,53,35,194,15,3,94,112,46,128,176,130,127,138,130,163,162,168,105,201,190,127,132,207,59,156,8,205,39,98,46,246,196,60,235,120,198,180,12,227,247,182,57,158,150,197,77,58,161,21,153,151,197,156,150,192,173,164,152,18,185,184,100,194,192,4,230,121,1,67,72,182,248,98,204,188,185,54,18,17,2,148,55,244,28,174,146,198,115,75,46,151,128,126,66,103,151,180,84,44,7,200,156,23,139,50,161,130,225,212,136,199,90,197,189,30,151,148,142,227,203,140,2,128,99,166,3,70,228,157,234,71,110,201,21,173,247,96,25,247,200,93,203,80,9,103,144,170,109,28,24,67,240,209,8,249,169,242,129,95,111,217,144,7,30,96,229,176,253,102,139,231,160,179,225,250,33,2,46,81,223,165,156,162,172,230,117,85,151,76,78,6,100,82,176,58,58,34,82,36,194,116,189,23,109,164,52,39,52,203,170,135,161,20,74,250,1,64,252,38,84,3,69,70,75,96,66,100,69,54,114,43,193,218,128,159,21,95,27,188,110,14,208,148,169,115,221,113,115,174,63,136,179,132,17,143,19,167,142,235,69,245,0,252,159,104,152,164,226,64,55,91,224,32,142,107,44,175,156,254,9,173,175,139,9,35,192,105,9,150,13,78,115,107,46,190,136,144,2,34,13,43,160,58,29,51,83,171,47,255,216,7,189,204,255,218,38,98,51,217,42,105,189,40,115,85,190,31,141,139,115,14,166,207,205,39,182,175,126,174,211,172,138,36,8,89,13,124,27,215,219,123,28,138,228,20,119,217,20,226,167,138,214,12,119,78,37,137,186,32,153,70,240,3,146,12,74,188,220,216,232,241,145,254,217,222,195,199,191,105,117,156,51,164,174,74,90,185,12,124,89,20,25,57,54,234,253,104,216,52,255,45,51,240,6,188,4,125,106,58,217,11,226,224,118,113,240,64,200,31,66,128,229,10,50,220,24,134,184,142,205,181,55,251,111,115,252,161,83,197,59,133,177,102,248,221,196,217,130,202,14,161,105,231,6,241,59,78,219,237,226,159,246,199,16,224,142,211,54,251,55,166,29,196,58,52,109,151,177,215,84,83,98,151,127,8,229,36,32,109,168,145,108,116,214,221,102,172,1,236,17,4,100,94,46,187,248,89,32,214,203,238,174,59,52,241,9,92,192,220,154,132,0,29,192,65,161,51,32,176,203,143,39,46,168,247,139,116,66,198,188,170,59,168,180,250,41,109,98,133,90,5,170,186,131,90,84,244,56,63,183,247,113,11,224,103,163,193,58,24,30,193,2,130,237,148,157,178,19,43,67,106,66,243,0,198,190,166,238,80,134,164,220,207,40,126,112,123,88,0,130,83,240,44,110,30,105,214,18,148,38,144,13,12,179,97,143,105,80,88,45,1,251,99,28,210,127,167,110,51,15,205,187,140,112,16,207,1,197,14,131,96,203,78,91,232,176,55,73,171,121,22,47,127,1,109,185,106,46,239,188,109,239,61,80,235,148,154,99,173,55,175,155,46,19,186,223,76,110,58,78,225,158,184,131,164,81,240,28,45,5,199,134,209,63,116,90,117,101,45,119,132,207,90,99,154,10,243,208,110,178,185,48,131,35,135,10,143,192,134,46,9,102,47,112,80,155,109,160,22,62,210,45,227,35,150,28,219,79,167,35,85,219,121,125,217,188,82,118,0,104,57,114,1,228,17,57,21,237,58,195,45,166,83,214,198,207,45,159,120,221,26,30,144,69,238,66,74,243,154,105,76,86,222,25,10,24,166,236,140,24,54,137,89,101,103,96,215,41,35,78,153,92,175,58,174,10,218,253,100,182,238,60,198,52,205,106,90,114,209,245,35,125,164,27,52,229,109,133,60,52,220,42,15,33,15,216,254,97,68,194,135,217,75,146,140,206,75,240,33,249,235,97,200,159,21,137,138,126,60,204,26,184,168,181,209,255,119,186,108,163,149,224,217,17,249,23,107,182,54,169,24,166,85,29,231,181,235,167,144,103,199,4,234,149,44,3,210,21,119,178,86,198,142,196,80,180,166,133,45,122,123,43,86,41,165,89,195,63,162,207,172,140,216,9,163,117,60,41,242,108,73,142,63,20,112,112,103,255,27,18,246,231,73,156,199,87,180,140,222,211,26,34,100,180,124,237,9,19,140,250,219,43,80,176,92,29,101,81,51,11,151,78,108,68,142,37,96,228,145,242,151,31,201,111,83,167,108,207,195,91,12,181,74,134,21,4,23,205,177,117,100,115,12,239,197,237,141,209,56,208,92,212,10,180,16,75,47,98,110,17,25,242,78,91,13,132,201,254,62,233,55,75,135,98,55,23,33,171,37,80,247,181,103,24,70,87,73,88,73,37,147,250,39,241,156,17,85,19,73,151,117,35,19,223,251,103,188,67,71,74,217,61,124,196,242,224,231,41,114,169,101,84,89,244,50,187,52,41,214,4,236,33,152,34,235,249,53,165,204,72,153,23,85,10,16,200,111,149,93,208,141,102,188,19,147,22,217,171,35,225,60,221,90,89,205,69,214,253,150,4,116,230,32,168,231,22,182,49,155,3,184,141,128,224,19,55,233,151,88,223,221,200,7,125,214,167,94,179,87,43,241,28,68,157,79,73,58,27,125,65,57,167,172,141,112,54,212,86,198,19,51,84,178,175,184,219,169,240,81,144,120,56,16,3,44,36,72,59,50,14,180,111,103,57,7,205,80,185,43,187,110,189,37,192,141,206,109,172,104,183,109,101,69,126,14,180,152,209,41,233,72,76,116,194,152,204,181,130,174,254,30,237,252,232,98,219,40,80,60,233,86,8,174,108,52,111,227,75,167,241,106,50,98,60,189,146,219,201,204,220,66,130,211,113,122,121,11,229,180,102,134,106,199,191,135,194,171,182,106,30,54,192,214,185,24,17,37,153,230,161,69,205,87,251,172,88,196,135,125,107,165,43,134,222,70,150,44,250,193,180,177,146,167,131,90,2,239,34,176,195,161,41,148,165,249,217,145,220,19,154,81,48,135,29,149,255,240,36,183,113,181,191,36,113,173,9,8,106,218,69,109,228,179,64,26,172,27,160,64,73,103,197,13,37,194,149,164,233,209,157,6,157,0,120,73,114,198,123,10,15,149,118,231,104,218,240,106,47,133,236,66,18,87,171,128,121,196,151,231,244,136,121,73,142,43,132,232,122,107,58,242,145,202,49,194,3,125,162,0,116,216,57,91,122,134,120,202,63,139,96,133,33,190,254,6,82,116,3,221,253,124,231,109,220,193,54,145,126,85,77,253,202,95,177,158,141,162,196,242,177,137,223,58,151,80,185,178,161,3,245,251,251,188,190,31,108,208,193,152,113,251,172,86,3,146,0,139,26,242,247,216,129,185,43,197,172,14,129,163,25,52,252,44,219,53,11,134,35,239,33,203,106,164,207,250,138,153,132,247,200,84,252,115,167,164,105,76,52,250,52,10,228,242,184,176,132,100,52,74,125,139,225,194,108,147,132,247,101,177,152,243,132,35,109,168,95,53,202,194,86,145,167,191,167,72,78,170,9,89,76,203,83,222,198,101,205,17,140,41,182,231,199,56,254,159,64,24,60,18,223,100,92,200,18,153,154,197,203,251,118,55,148,119,153,70,115,19,151,50,197,147,241,22,86,194,4,108,219,78,178,24,126,11,6,211,73,56,57,253,186,10,59,76,126,64,31,25,142,3,95,3,180,50,69,122,44,86,192,23,86,96,20,91,85,137,111,172,180,194,200,67,53,147,200,44,199,166,129,128,176,209,201,223,66,117,231,17,112,133,134,248,230,117,119,123,134,111,81,174,217,77,145,78,200,199,162,78,167,203,55,89,198,240,41,171,62,122,14,103,180,170,226,43,202,231,40,220,198,218,169,108,174,11,182,99,99,2,125,145,128,186,169,49,246,214,73,117,117,112,29,231,57,205,148,18,136,78,139,170,62,17,32,198,5,195,161,111,141,11,249,224,7,69,126,67,203,90,37,180,211,79,151,255,195,68,70,54,220,222,246,77,172,45,123,17,1,114,110,31,23,72,255,126,32,115,79,170,108,104,44,167,221,6,188,82,203,12,228,8,55,148,188,105,194,135,251,5,135,113,114,221,231,54,43,211,161,72,77,108,115,1,197,200,169,64,158,47,176,206,80,196,163,30,152,42,102,179,60,246,244,81,72,230,31,8,145,57,206,5,92,6,42,157,244,109,57,82,188,55,240,36,78,243,148,107,73,152,116,74,250,192,68,140,194,185,72,61,0,33,101,131,208,152,161,195,76,57,160,235,164,223,115,246,54,132,218,219,86,105,115,0,8,0,147,225,208,51,102,132,253,84,115,57,93,119,139,137,248,116,216,108,251,74,124,176,171,8,20,49,77,137,74,129,211,160,166,179,139,31,190,32,5,183,84,226,197,90,240,87,2,14,121,247,3,254,238,118,157,219,12,192,32,115,139,44,194,227,9,216,240,211,148,137,245,184,128,250,15,105,85,75,1,103,255,152,114,156,78,64,181,138,58,166,55,62,46,178,236,83,121,56,155,215,203,62,111,41,102,4,64,46,190,144,91,114,71,118,161,113,116,62,103,164,232,127,63,248,126,155,9,40,228,155,244,41,112,174,108,219,151,242,41,73,200,134,9,42,34,17,195,19,10,13,21,116,63,152,219,141,22,161,156,130,76,221,146,34,36,182,117,84,235,90,148,204,226,232,224,58,205,24,209,65,189,122,203,163,95,175,105,73,251,9,244,255,46,65,101,186,29,49,61,85,150,241,82,74,240,157,87,1,153,46,101,149,216,194,246,214,132,105,45,38,19,102,181,218,251,140,240,146,12,89,193,223,230,42,149,18,212,208,218,206,204,81,36,94,53,228,44,137,89,67,79,49,195,99,190,202,6,240,8,35,118,123,186,165,21,207,229,155,154,217,222,138,223,98,47,8,64,179,227,44,134,178,135,16,144,142,198,229,146,109,79,12,29,179,179,104,49,32,197,194,232,0,188,165,123,239,146,31,12,168,10,151,15,244,134,50,157,232,34,23,241,184,183,156,178,152,40,219,20,4,163,64,14,17,18,234,212,42,236,107,205,193,192,136,208,185,61,75,94,54,208,109,42,53,55,133,169,172,133,112,185,144,122,27,4,134,209,101,179,159,26,84,117,166,210,104,216,152,50,47,144,205,48,185,200,140,123,15,201,79,117,61,23,218,105,25,125,46,179,119,20,50,248,172,21,48,218,111,163,158,51,104,199,195,50,195,70,80,10,180,56,231,84,11,146,218,227,7,154,185,6,14,249,205,133,145,103,184,161,39,144,3,35,176,191,12,9,175,250,128,140,236,47,249,62,50,46,141,180,193,113,51,227,5,180,129,210,26,6,90,34,162,50,116,35,35,0,137,23,5,38,109,177,156,144,33,190,170,238,81,33,50,164,29,101,173,111,144,139,143,142,66,40,140,70,9,120,211,205,148,188,122,165,17,147,114,66,70,228,159,154,249,3,103,203,232,205,124,158,45,173,202,202,65,165,65,201,78,176,56,15,185,128,2,60,133,96,125,43,111,239,208,91,190,109,195,193,174,180,237,124,125,136,64,13,118,71,18,184,79,72,250,135,127,38,84,228,132,209,63,141,36,126,236,173,107,135,172,94,37,231,235,221,77,182,108,219,17,220,107,40,205,77,65,154,164,225,236,143,53,183,7,103,200,192,14,241,0,130,96,90,179,134,124,58,1,25,14,17,231,200,7,29,8,108,249,58,162,218,150,44,122,218,190,109,33,35,152,56,176,33,139,114,130,20,104,40,2,5,88,217,187,11,202,13,31,211,14,31,23,220,80,114,20,228,131,89,183,143,38,43,48,227,139,47,183,146,4,119,142,160,40,62,214,103,81,255,89,72,244,143,76,18,109,127,59,65,241,28,154,100,194,204,123,154,125,72,254,130,233,235,70,125,95,102,13,36,224,56,130,33,82,92,194,7,51,236,42,133,3,142,176,49,204,20,205,101,6,145,217,53,22,224,45,5,245,130,21,195,113,172,201,30,31,48,15,137,33,135,23,127,252,41,57,3,128,188,237,167,148,104,27,52,155,15,174,105,242,251,113,245,134,13,49,46,36,55,81,201,30,125,203,200,231,173,24,162,211,56,67,226,175,205,214,70,48,231,237,242,19,219,97,248,159,103,233,213,117,93,153,71,56,57,148,3,251,221,91,121,247,252,48,191,74,115,202,221,56,113,126,248,39,43,173,169,130,215,239,177,194,198,100,122,138,13,41,195,223,84,94,11,54,202,155,201,44,205,63,231,105,173,207,12,221,198,255,236,239,172,204,74,53,151,192,40,209,155,124,217,103,43,129,78,57,214,97,18,29,254,177,96,52,54,252,90,121,85,179,227,73,154,199,121,66,207,138,12,118,122,242,239,127,55,58,192,53,105,108,44,46,203,243,241,152,58,42,65,69,84,172,76,33,192,32,88,28,3,43,249,157,192,85,45,67,125,205,12,86,206,242,106,218,82,54,251,80,218,228,207,158,125,147,189,39,181,75,15,55,42,193,179,50,157,75,65,139,62,22,156,7,216,132,79,138,73,58,93,246,44,228,86,36,181,233,99,174,113,125,205,155,248,119,198,197,162,234,116,23,154,151,204,227,50,158,145,156,231,136,107,191,84,111,36,87,134,29,73,229,41,57,122,189,195,91,251,59,203,28,200,145,193,94,197,84,218,88,38,24,130,219,74,69,161,63,120,119,47,33,132,193,16,107,142,32,196,188,26,189,174,40,37,73,73,167,195,158,239,84,215,219,25,157,182,220,5,127,189,35,225,0,224,11,37,70,86,90,227,197,175,244,242,56,191,41,126,167,125,65,111,200,3,124,127,56,198,37,254,92,166,99,58,155,131,188,65,197,142,28,97,231,86,147,237,174,71,254,83,240,67,111,31,39,62,188,197,63,238,94,137,60,231,225,173,248,247,238,21,79,86,30,222,242,127,238,94,97,210,241,240,22,255,184,123,101,157,128,134,183,214,231,221,43,35,231,119,120,107,124,220,33,190,111,139,201,242,188,94,114,193,100,51,67,47,162,42,141,222,198,37,83,171,104,53,29,241,59,104,86,75,81,196,223,156,16,0,77,207,116,184,237,182,153,34,234,61,230,187,231,123,220,65,166,198,129,9,139,144,114,234,187,192,243,49,126,38,250,20,138,37,72,58,213,194,34,153,42,53,136,101,111,130,218,128,180,13,68,195,180,212,103,99,109,96,96,107,238,208,49,188,192,168,25,100,206,239,176,139,243,9,103,44,251,170,99,117,97,158,169,229,137,220,242,35,8,98,112,215,1,159,12,30,220,209,123,32,186,236,146,255,194,71,26,182,100,22,251,80,209,76,148,219,249,231,157,112,182,136,44,49,183,15,222,6,197,77,143,183,99,147,7,252,63,166,49,111,57,203,124,86,210,195,43,69,99,248,222,136,63,88,66,190,166,245,53,40,25,238,15,168,22,204,12,138,43,139,127,21,227,202,85,17,235,72,235,228,249,105,184,211,79,231,76,197,145,144,122,99,85,157,52,9,170,136,46,218,132,60,146,38,121,187,20,225,18,152,217,61,189,134,47,155,5,155,62,167,234,197,241,155,164,196,51,227,59,215,45,161,207,232,94,174,187,151,79,34,236,234,88,139,255,214,54,111,194,107,97,154,54,114,97,154,134,205,51,52,56,194,203,181,218,220,232,102,19,52,87,88,155,6,155,108,249,43,205,138,181,54,208,123,49,144,87,129,241,196,25,241,36,9,104,3,227,161,146,141,78,23,194,171,214,118,198,144,122,230,220,59,246,227,233,33,24,101,71,76,184,35,131,255,90,130,147,125,242,173,120,60,252,182,11,247,25,100,137,40,237,7,178,19,116,73,196,93,36,111,202,171,5,60,95,38,130,154,176,100,197,212,228,187,109,139,229,196,27,96,62,84,100,6,107,132,88,88,40,242,67,181,120,168,78,53,116,131,78,150,4,184,169,18,219,94,198,183,114,87,66,100,209,35,88,239,171,12,113,58,145,89,106,88,201,234,117,23,213,208,125,20,5,27,91,79,193,168,198,238,83,34,166,248,174,43,131,202,225,83,201,108,52,245,14,20,137,19,112,74,242,87,222,10,93,59,161,115,154,131,112,225,171,81,60,95,45,244,130,199,67,73,172,9,162,210,238,218,222,8,252,168,136,2,248,138,38,224,49,148,168,134,5,95,205,122,210,204,90,228,254,232,199,211,1,56,222,26,54,137,212,1,223,200,44,57,106,121,192,75,108,3,70,170,170,171,9,6,68,101,242,92,124,33,198,74,117,136,153,180,12,28,136,159,8,175,121,123,124,179,25,151,52,177,106,70,82,240,144,106,79,211,136,24,192,159,14,13,140,196,19,25,119,1,182,171,84,244,33,160,126,204,104,55,151,110,62,27,81,104,5,88,226,44,147,1,30,238,65,100,123,188,145,49,165,156,166,198,12,84,86,6,248,34,135,35,5,33,122,51,153,156,197,249,21,133,10,59,220,208,136,220,233,152,133,236,253,248,17,137,255,43,58,170,132,139,249,35,190,70,224,43,169,200,215,235,148,145,236,58,190,145,23,30,164,210,98,104,75,227,67,37,4,191,4,197,181,115,243,227,243,180,97,214,210,95,191,252,232,209,96,174,202,96,154,12,214,240,193,85,152,43,105,79,168,122,216,63,182,222,121,76,33,127,104,147,250,249,236,161,109,175,40,49,120,74,208,33,35,188,201,120,226,204,200,184,205,123,106,180,24,174,109,32,15,167,173,10,88,162,234,111,38,55,154,57,108,210,253,131,89,135,115,43,235,112,190,189,29,141,99,182,116,78,248,237,36,254,19,143,174,194,119,188,103,27,228,94,43,127,92,166,240,92,193,207,197,101,23,219,126,21,139,159,54,166,192,254,118,19,14,238,155,2,244,102,81,23,198,28,204,148,3,39,201,219,161,139,73,0,118,166,40,153,70,71,222,26,152,7,43,59,51,246,165,200,36,83,127,47,68,38,207,217,134,12,218,186,41,140,188,64,152,100,234,83,178,15,126,138,141,92,114,26,122,124,110,154,49,160,181,37,183,83,110,80,131,75,76,121,183,110,184,71,106,150,70,238,15,63,56,73,94,21,87,254,48,243,20,167,236,136,143,33,61,178,234,0,231,175,114,187,116,149,140,210,200,171,4,227,226,29,77,210,89,156,245,57,125,6,228,128,29,100,153,64,29,231,211,34,98,12,22,151,105,156,215,88,232,8,229,75,97,123,126,1,72,240,254,58,118,145,92,252,71,179,143,46,196,252,119,9,54,224,22,2,173,141,199,115,36,127,156,113,255,66,111,61,241,81,23,153,250,214,23,218,33,115,57,216,166,187,89,39,153,208,163,53,211,229,12,241,104,222,189,138,236,153,160,156,24,200,63,209,209,231,29,191,82,109,196,120,132,149,191,201,65,166,235,17,70,138,180,209,21,79,46,15,158,190,81,117,137,40,181,49,73,111,103,244,136,94,91,32,249,142,184,220,254,66,182,53,193,54,156,195,3,59,155,82,216,242,130,137,99,115,206,85,188,65,254,181,111,220,71,249,225,139,22,74,117,145,67,39,128,57,150,34,207,211,18,151,2,120,133,242,153,2,249,211,149,94,216,53,109,221,251,109,158,238,150,105,82,80,106,3,103,162,124,31,133,171,57,184,231,53,111,59,26,70,234,150,181,77,98,225,221,183,219,232,90,35,200,153,78,73,91,43,136,204,31,93,27,169,220,74,158,170,121,175,84,44,157,28,10,10,194,68,71,88,85,155,248,53,86,196,35,179,228,175,157,91,64,252,188,46,239,158,73,132,184,53,31,183,198,124,92,35,77,22,112,151,124,162,14,145,80,206,70,195,106,227,218,152,21,40,240,230,247,242,148,219,71,231,30,43,5,65,92,49,37,245,117,12,219,76,94,199,105,78,50,118,66,3,126,40,109,6,123,18,46,90,181,73,48,54,122,73,204,35,50,12,212,161,212,126,105,209,151,87,208,198,46,102,142,252,191,214,98,157,215,201,168,46,23,244,245,78,50,26,16,118,246,190,129,219,157,3,40,230,233,210,80,78,138,250,154,150,95,211,42,244,51,67,1,195,69,92,237,233,141,244,19,51,252,226,108,247,40,19,222,47,21,16,212,109,211,214,62,48,64,207,124,213,70,223,161,231,191,147,20,228,220,251,209,227,17,77,30,142,253,206,13,94,182,125,33,86,15,247,212,240,11,194,184,253,26,150,14,62,15,32,243,50,212,5,107,142,175,244,160,58,151,172,137,247,42,52,254,92,213,134,199,25,112,52,153,152,133,178,215,205,39,27,240,182,218,182,105,233,76,45,131,195,141,91,91,111,44,108,157,235,7,29,228,252,209,0,217,179,0,154,55,209,135,206,8,221,223,128,192,235,15,124,61,24,152,192,197,119,123,184,129,184,220,222,140,68,37,137,136,171,35,60,195,91,247,29,22,105,83,203,126,35,97,147,11,34,61,68,249,99,81,243,49,144,57,229,157,8,211,38,43,203,162,4,103,6,174,128,254,86,6,224,137,66,9,145,147,70,160,237,227,219,232,152,136,143,80,172,165,40,29,37,217,89,63,130,81,44,251,170,227,105,247,220,155,103,170,242,94,226,49,175,161,236,212,41,15,23,233,1,92,47,105,165,133,208,184,202,100,70,12,108,173,51,50,110,31,187,15,27,106,37,130,135,43,117,12,115,52,87,34,181,154,122,108,32,45,171,250,83,137,58,88,60,20,144,68,112,182,210,135,171,134,134,37,223,177,185,46,178,76,95,209,209,167,69,83,231,233,171,170,71,238,179,19,112,29,155,199,148,157,235,174,242,86,174,210,8,92,37,217,240,248,93,37,35,48,208,237,132,106,211,5,32,27,43,208,32,168,224,4,121,82,117,40,225,222,222,178,84,164,150,6,89,185,181,145,202,20,168,49,16,147,227,252,72,94,196,220,243,12,76,212,219,23,130,247,251,14,66,3,103,89,196,218,247,183,249,235,64,26,226,58,42,56,168,131,149,18,86,71,242,214,163,120,251,89,92,69,107,76,154,123,123,0,154,204,96,102,219,203,81,177,200,39,250,158,152,92,64,253,227,101,246,189,51,239,206,136,127,223,47,15,172,225,104,196,27,169,157,207,114,34,106,32,182,3,188,13,219,117,43,49,221,148,107,238,38,77,119,227,49,56,28,185,8,161,195,230,123,203,211,248,114,54,164,178,248,250,18,119,35,169,193,69,72,233,172,248,218,247,69,210,12,255,27,74,136,245,28,101,100,171,160,134,25,183,145,175,240,126,14,66,241,158,134,241,192,137,121,121,94,59,250,206,112,158,86,174,22,143,165,247,77,245,33,26,89,234,194,159,225,86,124,21,176,108,242,188,151,27,196,0,113,50,227,215,162,143,187,235,216,249,114,232,185,84,203,66,148,2,244,196,70,140,196,5,93,107,198,18,189,13,84,152,73,39,163,88,212,65,100,212,85,122,166,253,178,197,4,226,97,18,73,43,33,78,199,232,133,61,2,47,11,12,145,62,114,107,48,27,196,229,149,92,3,223,179,166,34,60,101,58,104,101,205,25,128,4,133,202,70,24,184,149,190,4,98,99,247,240,232,101,207,11,172,145,40,235,3,138,223,46,194,31,78,193,215,193,37,52,128,138,41,190,146,210,81,251,175,29,103,106,185,48,228,188,19,184,81,100,103,157,171,40,56,247,103,226,196,11,80,131,152,134,179,123,233,164,67,126,154,3,174,45,122,18,188,44,34,115,133,140,103,194,2,224,163,198,73,0,197,164,203,121,64,6,143,2,207,87,110,171,12,30,215,89,240,4,15,206,132,68,203,249,25,4,204,248,100,133,164,226,63,169,158,82,185,49,126,155,144,174,237,202,169,26,145,221,150,56,236,35,159,187,171,157,197,252,5,121,26,63,115,100,37,203,186,17,86,113,50,94,67,62,156,117,121,184,188,191,110,199,115,103,120,41,121,253,105,194,12,224,124,2,98,130,241,219,128,99,17,243,72,166,137,249,114,171,124,186,149,149,26,207,182,234,119,91,89,185,245,102,235,214,41,104,3,33,121,124,84,220,24,85,128,214,85,26,246,34,216,239,79,253,191,180,27,233,23,167,205,132,139,21,217,235,2,75,8,237,10,91,172,211,1,234,113,51,48,118,36,82,107,38,87,113,253,240,84,143,82,128,33,44,194,225,111,151,72,75,127,62,134,78,192,80,223,56,223,123,190,69,201,253,80,146,219,236,163,128,226,126,235,101,63,239,219,93,42,209,195,43,15,40,42,93,158,49,52,231,27,122,121,172,153,168,43,15,7,158,99,131,24,223,58,155,221,251,173,67,63,65,194,96,186,61,117,248,96,143,151,221,251,237,50,147,232,158,57,6,222,190,90,227,224,0,143,222,155,186,238,114,73,120,18,228,11,81,115,28,215,74,239,211,150,243,74,84,194,154,202,39,167,158,74,241,9,76,94,172,222,227,30,129,174,202,143,35,98,246,192,251,55,238,82,109,162,21,215,17,74,142,10,202,88,15,94,15,35,223,185,168,124,3,237,122,63,111,21,239,165,223,182,133,100,154,33,158,235,223,27,21,66,131,25,253,226,44,195,107,65,250,178,161,139,250,200,99,108,54,8,115,132,119,16,121,5,127,10,82,63,11,205,223,26,206,240,189,93,213,32,58,101,103,235,156,77,163,218,143,62,208,252,170,190,134,180,67,249,60,177,126,73,8,195,197,28,230,181,57,17,57,67,107,218,110,212,40,69,84,224,223,8,223,252,29,10,100,172,56,142,3,217,9,34,169,140,127,29,207,248,71,239,160,88,100,19,146,23,53,252,196,168,70,77,184,171,152,122,20,51,190,229,255,220,69,198,235,42,187,196,122,243,75,133,55,224,231,60,69,104,67,61,191,175,234,244,75,115,58,114,224,54,194,120,134,117,18,80,196,17,187,48,95,79,141,171,46,212,7,246,45,193,54,160,6,156,206,125,207,218,89,126,184,100,245,203,164,92,200,228,125,185,208,251,164,166,171,46,108,41,216,182,130,198,77,149,170,118,106,30,100,232,157,187,106,40,60,154,124,243,61,141,25,67,14,109,142,219,143,116,157,215,83,89,170,91,125,157,205,9,78,179,129,79,44,116,230,129,231,146,47,92,233,61,174,56,190,108,64,8,98,168,230,40,211,214,245,95,237,123,108,127,243,25,251,26,30,230,39,126,147,181,155,93,243,84,46,85,195,25,94,33,247,243,28,70,225,237,22,25,142,108,57,225,161,2,180,49,248,195,75,79,121,70,60,222,224,148,200,251,170,113,203,231,113,96,44,249,26,168,11,57,207,211,120,234,122,89,212,136,185,132,204,39,181,20,79,125,241,236,49,163,71,205,83,224,177,251,90,194,147,101,208,207,197,111,3,144,73,90,49,118,92,138,3,17,137,243,9,254,37,79,167,32,57,223,250,250,206,129,155,216,245,52,62,28,145,95,85,241,92,17,56,47,63,75,153,180,29,156,34,177,37,244,62,160,219,102,197,77,155,206,225,153,230,168,30,99,59,148,40,213,22,90,49,4,23,69,106,157,124,42,51,161,170,97,11,123,15,48,210,248,180,243,69,121,134,121,101,126,12,189,63,65,27,53,73,109,116,10,252,58,130,196,85,4,123,5,37,137,224,185,102,46,168,217,72,190,174,12,182,76,94,213,240,100,244,219,37,120,179,251,38,170,145,176,48,68,71,51,15,201,4,133,75,50,93,228,137,202,202,21,40,112,29,106,180,121,187,4,171,209,30,225,72,117,51,225,43,213,133,63,66,162,91,104,224,86,213,62,119,197,183,246,62,136,165,14,244,3,192,250,134,109,40,84,28,63,222,183,160,129,205,218,176,105,66,10,161,228,0,11,96,214,68,73,175,129,31,3,239,208,102,167,192,72,230,114,219,179,247,141,98,182,254,204,99,31,216,152,125,172,181,111,121,83,48,55,220,214,156,247,193,69,169,83,40,223,12,231,191,102,72,225,205,240,79,7,159,120,205,5,240,172,185,57,160,30,77,160,37,129,151,213,27,199,155,215,227,17,249,10,63,243,68,198,187,250,181,40,214,245,22,175,100,243,19,18,157,93,26,23,148,211,137,125,41,25,79,222,140,150,183,112,208,222,3,125,178,71,238,194,0,84,126,154,5,134,235,103,105,86,116,5,149,8,150,240,34,36,153,168,35,168,84,28,214,108,80,248,51,113,226,24,215,21,39,227,33,39,27,154,245,107,94,35,114,96,52,244,0,23,255,183,214,176,249,123,30,187,161,117,85,47,82,193,98,34,196,118,6,113,150,191,219,226,243,85,91,99,189,132,120,23,19,234,95,50,85,237,3,104,14,121,32,159,59,248,246,60,39,126,91,52,52,133,247,178,118,45,112,94,196,222,139,154,174,128,184,113,107,131,17,191,182,40,46,129,118,5,115,29,87,232,238,181,97,189,101,162,64,227,156,252,164,234,91,214,168,237,55,34,97,83,133,186,138,163,197,236,139,189,22,155,30,108,67,121,149,130,192,207,121,145,105,89,204,172,2,48,236,69,164,3,62,219,236,121,191,97,109,175,31,12,168,217,176,239,92,185,195,36,233,159,139,52,239,247,126,99,38,182,110,58,208,75,191,207,206,89,108,139,76,104,191,71,88,27,214,208,250,153,206,238,194,200,129,63,170,56,6,5,177,59,3,63,160,14,78,240,167,7,91,212,166,249,35,136,234,23,12,59,171,248,195,73,90,3,4,175,150,151,149,93,193,81,214,254,164,65,65,129,220,33,214,17,245,71,103,28,225,103,22,189,248,241,31,183,237,12,198,247,59,185,94,176,222,159,220,93,161,126,49,113,196,105,213,137,179,221,128,82,27,123,207,165,171,181,201,229,23,95,136,114,196,110,198,94,8,77,123,52,238,51,43,249,106,139,72,101,109,155,147,225,72,104,138,174,145,218,250,237,55,54,233,127,244,128,82,15,15,173,181,207,123,65,173,187,115,251,182,53,241,124,145,127,95,235,188,92,238,235,56,187,107,44,34,110,218,126,190,196,125,219,203,150,222,77,78,102,91,43,143,45,223,227,196,158,134,46,171,149,207,113,75,93,217,120,53,206,77,229,246,147,203,62,100,240,50,246,223,255,2,99,75,220,165,20,170,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("08760552-aaa7-433d-9c0c-32c521adaf87"));
		}

		#endregion

	}

	#endregion

}

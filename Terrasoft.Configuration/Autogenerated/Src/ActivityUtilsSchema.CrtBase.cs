﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActivityUtilsSchema

	/// <exclude/>
	public class ActivityUtilsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActivityUtilsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActivityUtilsSchema(ActivityUtilsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("20677495-3b4f-4361-9b9d-6d84654cad61");
			Name = "ActivityUtils";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,60,107,115,219,56,146,159,189,85,251,31,176,186,249,64,87,52,204,236,93,237,125,72,98,167,252,74,70,183,118,146,181,148,157,170,157,154,186,162,72,200,194,133,15,13,31,182,149,148,255,251,117,55,30,4,248,18,173,120,54,179,85,235,47,22,65,160,209,232,55,26,104,166,65,194,139,77,16,114,182,224,121,30,20,217,170,244,207,178,116,37,110,170,60,40,69,150,254,241,15,95,254,248,135,131,170,16,233,13,155,165,37,191,145,205,39,27,225,159,5,49,79,163,32,247,207,23,239,95,154,78,243,109,81,242,164,249,12,64,227,152,135,56,180,240,223,242,148,231,34,108,245,57,15,202,160,213,56,107,193,246,47,69,250,107,171,113,193,239,203,206,70,255,154,223,84,113,144,95,220,111,114,94,20,136,65,221,207,94,117,146,100,105,247,155,156,247,181,251,231,167,189,175,46,210,82,148,130,247,204,6,29,222,4,97,153,229,67,61,230,165,156,27,222,255,71,206,111,0,119,54,47,243,42,44,95,176,15,213,50,22,33,189,218,208,79,86,208,27,118,2,84,190,21,229,246,156,175,254,30,196,21,47,24,114,80,119,2,26,243,133,72,56,192,9,242,18,159,94,118,189,61,175,120,243,221,219,74,68,236,164,42,215,89,62,139,236,23,48,47,162,46,95,189,3,129,106,141,122,127,7,12,239,28,68,111,244,152,7,185,80,16,42,185,86,103,221,103,113,80,20,47,204,234,62,150,34,46,168,195,243,231,207,217,171,162,74,146,32,223,30,171,103,16,225,50,16,105,193,42,232,6,189,89,194,1,185,168,96,171,44,103,119,89,254,137,221,137,114,13,195,56,103,97,206,87,71,19,13,119,242,252,152,113,100,220,214,215,176,159,91,192,13,246,160,5,33,11,17,39,23,37,36,54,46,211,160,13,226,86,6,105,89,56,28,107,33,45,177,14,194,53,103,159,248,150,208,236,65,174,64,190,177,8,152,195,194,44,174,146,212,55,240,108,68,53,166,33,206,175,169,109,120,254,87,152,227,136,77,204,243,228,229,215,162,21,85,124,79,164,148,168,41,148,212,211,215,35,84,172,179,59,38,82,86,64,223,168,138,247,197,110,14,96,102,233,92,1,209,116,115,26,7,113,189,10,238,25,152,201,27,144,182,108,197,22,162,140,53,18,132,60,79,2,16,26,159,205,86,236,22,149,149,37,160,240,172,92,7,41,142,164,238,151,114,116,177,77,150,25,200,151,40,65,118,227,152,45,161,91,94,165,33,172,42,26,179,30,145,150,77,144,71,236,63,255,242,223,67,200,255,180,230,169,194,11,144,39,92,213,18,204,212,83,6,58,80,26,236,114,190,137,193,155,68,82,191,202,181,48,77,185,4,244,8,210,71,124,21,84,113,121,173,199,3,225,125,223,31,33,25,55,121,86,109,88,10,86,101,72,64,106,45,31,137,143,30,76,147,188,197,57,208,112,33,90,206,27,11,193,38,126,40,217,172,20,18,175,36,40,9,61,162,234,58,40,214,236,6,253,34,185,87,141,149,65,170,87,121,148,193,94,100,115,106,120,35,225,2,78,91,248,251,254,234,234,251,40,98,63,254,248,34,73,94,20,133,191,90,173,52,118,13,43,107,236,213,149,52,148,96,173,114,113,11,192,229,219,141,124,208,118,79,77,254,150,151,151,225,103,114,50,222,199,130,231,96,235,82,233,227,89,229,60,78,245,8,208,217,67,233,142,14,114,94,86,121,202,82,126,199,46,179,48,136,197,231,96,25,115,185,10,207,29,14,30,188,200,170,60,228,232,14,131,27,62,173,41,78,54,119,50,37,136,7,7,223,77,90,160,10,255,11,76,250,224,19,150,147,67,95,19,202,59,36,111,244,176,107,125,89,248,46,155,87,203,255,3,76,134,215,216,88,151,77,155,38,49,38,54,212,201,16,34,168,180,0,73,175,246,141,136,57,240,5,5,226,92,20,160,22,219,51,50,37,115,241,121,7,7,52,118,183,65,78,22,49,9,64,70,26,84,166,120,101,59,167,183,87,65,10,132,206,33,84,43,103,228,192,66,126,186,69,113,247,38,54,50,10,121,2,171,172,218,145,130,143,67,187,112,245,90,67,22,219,13,106,145,50,205,24,4,18,217,176,185,217,21,23,10,93,61,160,203,97,61,88,78,149,109,120,94,110,37,197,39,216,81,35,167,56,82,67,176,9,222,105,70,174,105,68,65,90,9,241,83,104,98,87,105,79,54,65,30,36,96,79,200,196,28,77,200,46,34,218,96,85,122,204,9,181,208,48,53,198,37,253,228,216,178,81,46,31,209,82,9,197,1,255,213,115,130,209,13,178,70,227,248,130,108,202,21,68,187,192,68,24,190,202,218,67,37,85,10,213,183,181,82,24,160,123,116,200,229,165,40,202,87,82,75,142,81,64,9,200,143,4,99,151,37,48,93,97,215,192,12,206,90,62,29,192,10,169,35,105,36,172,55,182,12,97,39,136,221,55,25,204,131,125,41,78,148,145,245,22,5,227,36,142,95,205,204,164,186,167,1,1,12,229,96,181,153,215,132,133,177,131,3,91,163,120,32,209,242,79,162,232,58,72,111,248,108,245,46,43,47,238,1,189,194,179,7,224,228,138,36,77,26,212,203,86,88,60,216,130,42,225,143,22,82,142,83,163,185,146,254,89,64,148,91,112,228,226,84,253,7,111,188,220,182,164,86,206,242,109,69,86,225,48,32,131,125,66,219,183,230,97,177,157,83,31,35,176,179,168,144,45,187,100,118,118,145,86,9,184,102,240,42,13,225,236,240,102,10,100,195,254,42,15,229,43,35,56,153,69,19,213,230,191,201,179,164,54,171,166,25,130,175,28,44,217,149,146,92,240,93,179,212,147,195,253,15,72,22,94,130,84,122,10,143,67,22,20,106,106,91,114,118,187,249,93,155,18,45,102,85,42,126,133,56,144,2,21,19,185,214,124,102,239,151,69,22,3,74,76,36,155,152,39,16,93,57,145,204,46,233,90,102,209,86,11,2,254,30,22,156,18,131,80,221,189,144,142,116,120,68,1,132,224,185,25,66,79,44,136,34,76,9,12,143,204,121,200,55,2,214,163,7,155,134,225,113,97,182,217,94,55,199,98,227,88,0,210,74,136,92,74,16,58,58,13,37,210,141,172,68,223,9,238,48,204,18,84,135,231,44,171,202,155,12,126,30,238,38,7,237,179,44,130,208,14,169,95,231,62,14,11,128,171,120,63,107,113,240,208,56,56,46,194,131,185,112,234,41,35,46,78,137,221,83,10,139,255,145,165,124,6,222,234,112,114,248,139,147,43,104,68,101,22,44,217,38,65,168,7,5,86,61,73,86,155,71,67,123,211,226,240,201,180,182,137,63,173,179,35,154,122,13,237,199,136,232,35,37,28,4,199,44,87,121,117,254,23,194,242,2,248,19,1,84,31,104,8,191,40,96,57,221,150,224,25,16,113,246,76,162,12,255,149,92,62,171,209,132,223,14,130,240,220,70,77,141,68,148,172,0,247,240,112,180,15,217,165,220,96,89,148,124,176,187,172,138,35,220,125,194,62,228,22,34,46,240,46,101,198,62,46,206,152,204,96,129,217,131,102,98,231,103,96,167,207,244,92,95,105,32,30,33,177,95,103,41,118,91,162,223,181,70,180,132,180,71,47,112,14,45,191,170,9,130,116,145,98,202,244,20,165,242,136,73,65,170,37,250,76,114,252,199,50,137,23,217,7,221,153,100,88,197,49,102,242,170,12,231,106,126,220,17,212,194,9,52,3,24,69,16,99,55,207,141,208,247,208,31,23,229,90,145,164,15,181,176,168,245,162,123,203,252,148,218,50,94,89,48,72,168,85,229,95,79,19,92,248,181,184,78,142,63,58,43,27,28,24,113,84,139,159,214,162,228,115,60,138,128,128,240,77,28,220,76,129,162,145,192,36,83,193,4,68,173,92,18,79,246,102,119,216,157,209,209,197,14,255,29,41,126,75,62,79,142,103,171,86,44,220,198,0,67,216,2,179,92,124,170,129,178,18,179,97,148,210,218,232,240,11,25,24,145,12,24,38,160,1,20,148,131,232,12,97,93,220,86,66,38,228,104,234,66,47,94,220,99,210,140,7,20,225,222,213,175,112,75,34,5,124,5,244,121,34,187,244,180,22,101,202,22,150,24,56,38,76,37,105,150,89,22,179,22,193,193,72,16,177,77,238,207,97,90,87,62,107,130,102,18,64,117,144,80,1,211,214,109,41,173,25,253,123,253,90,205,224,95,36,155,114,251,242,105,205,95,3,249,86,82,174,219,244,200,177,32,226,94,139,44,102,207,185,11,183,243,230,72,215,50,42,252,14,122,49,115,233,109,111,74,123,76,58,238,116,244,43,175,182,239,34,252,84,212,129,210,95,65,131,193,102,23,27,30,138,149,224,145,66,195,133,100,11,140,166,177,196,241,99,25,122,86,223,134,71,172,83,0,32,2,60,146,121,233,163,78,121,120,13,174,229,222,106,240,72,112,15,217,11,41,193,79,237,132,44,124,158,13,56,162,110,102,60,198,17,153,109,243,55,220,195,239,233,141,148,3,250,167,249,163,179,42,207,49,124,174,134,253,82,59,43,246,104,115,185,35,151,208,111,77,21,13,92,123,42,229,167,215,168,218,121,221,79,116,56,213,56,65,118,14,243,253,249,182,152,243,178,164,188,56,32,221,147,158,214,41,7,157,201,2,83,59,57,13,10,222,202,162,185,233,95,149,55,107,167,224,58,243,111,120,20,208,200,207,214,121,179,115,121,244,67,244,108,162,135,150,199,73,34,42,19,217,17,111,42,234,169,76,59,190,80,36,150,237,167,181,99,104,208,25,61,136,69,101,105,14,119,235,37,88,25,94,88,190,59,0,85,40,115,146,111,227,192,149,251,25,169,176,121,112,39,141,195,228,120,174,124,110,134,246,165,95,114,155,177,77,13,1,84,26,79,229,178,170,236,68,209,10,52,198,200,124,195,162,234,237,181,158,205,22,76,192,168,68,167,108,94,250,243,13,216,87,15,57,25,174,131,252,231,31,126,153,42,143,70,47,222,111,228,61,145,107,158,100,183,156,28,245,69,90,226,69,9,87,98,20,41,255,39,19,169,55,97,32,165,52,209,161,191,200,69,226,237,230,22,104,66,161,98,163,156,199,129,156,115,79,67,74,225,174,117,150,50,104,153,2,157,234,83,102,70,63,59,163,92,162,223,102,34,66,132,105,192,181,198,118,151,173,209,57,69,51,131,230,74,27,82,115,168,39,79,131,14,235,161,255,166,39,147,52,105,81,19,101,60,168,202,204,1,166,98,164,147,102,187,223,106,105,166,138,165,140,183,0,250,31,242,44,132,77,144,25,230,114,230,192,172,122,30,220,114,111,21,196,5,223,127,75,171,129,213,65,192,72,70,170,93,166,145,60,122,30,102,95,156,133,129,228,250,98,205,153,126,194,27,7,176,227,234,102,102,59,156,48,55,89,8,136,117,73,230,81,96,34,117,251,132,128,152,43,45,143,2,177,201,69,150,67,175,89,52,209,27,49,17,225,93,3,8,128,193,20,170,183,195,48,210,172,196,141,32,34,65,63,31,135,193,163,54,226,125,123,198,182,0,140,139,131,52,227,237,236,172,187,77,212,12,182,67,33,205,61,171,77,177,98,42,111,144,213,84,53,112,136,50,3,251,205,246,129,188,131,27,41,167,213,128,199,113,96,16,116,52,161,183,19,18,119,217,118,169,69,243,168,94,132,138,48,244,2,48,198,48,139,145,239,212,141,38,220,100,169,37,201,246,15,102,73,240,202,90,159,124,251,142,248,126,164,86,217,17,5,238,23,161,60,185,190,7,109,18,58,219,138,14,18,15,239,45,126,83,129,236,98,120,199,10,180,232,56,123,95,139,197,206,230,183,99,188,111,58,63,98,71,108,193,223,189,37,174,21,166,107,250,69,247,62,217,72,38,12,79,54,48,79,215,88,176,23,24,164,3,21,151,49,137,171,202,17,188,118,136,32,215,101,29,54,192,94,218,125,239,222,179,113,72,89,107,196,78,66,170,174,227,201,88,195,222,73,196,115,109,97,30,65,66,165,194,123,19,208,89,79,139,124,230,109,131,120,251,167,38,164,225,248,110,242,165,123,141,96,219,30,58,95,105,83,247,240,197,21,154,135,47,54,5,186,199,214,134,173,251,61,153,182,7,117,206,253,13,77,150,21,165,140,75,117,252,126,28,107,35,16,29,225,5,109,87,108,9,46,74,10,158,32,70,242,98,1,37,4,204,45,155,9,9,200,196,77,110,198,181,19,28,7,68,139,210,164,105,9,10,203,226,13,130,210,35,0,88,125,99,185,9,45,50,138,63,22,150,190,106,172,32,53,226,140,93,128,176,59,0,169,133,189,65,167,84,57,240,113,68,34,157,104,92,88,107,50,93,133,81,117,252,100,133,77,38,90,178,3,37,21,33,181,179,166,67,234,182,192,125,182,204,50,164,81,235,164,68,221,152,160,251,179,114,175,37,27,234,204,134,134,35,218,199,44,214,96,81,32,118,44,173,226,152,209,9,5,236,241,31,153,26,209,208,244,166,79,33,18,202,171,255,148,80,147,240,118,36,249,234,75,32,59,213,240,226,190,204,129,159,52,238,68,14,155,173,60,58,18,82,61,20,176,70,236,169,167,152,21,239,96,193,239,115,74,105,128,209,119,15,35,192,7,232,142,29,19,141,72,104,124,45,235,254,181,40,239,141,34,249,126,148,164,84,134,72,111,131,88,208,14,176,62,240,235,185,80,238,222,9,71,26,135,214,85,116,46,239,59,124,93,54,36,172,243,18,157,238,170,35,193,113,22,243,32,119,80,28,127,75,56,216,108,228,109,250,214,61,225,185,172,162,162,183,254,79,162,92,211,165,107,124,196,144,165,155,34,58,71,161,128,2,91,54,34,151,175,7,71,12,50,9,139,163,10,85,159,32,82,144,251,166,200,211,43,100,134,113,186,54,87,106,192,35,216,73,240,85,188,25,82,170,189,57,25,180,217,183,41,59,142,153,13,58,71,71,236,85,120,140,198,239,213,243,240,120,202,114,74,116,22,178,164,37,207,18,137,230,111,42,45,45,40,136,254,177,169,172,25,238,43,23,162,122,203,178,142,221,169,182,247,185,204,231,206,74,158,204,210,71,72,165,93,61,48,101,153,204,229,75,174,31,145,7,249,231,137,173,181,12,121,118,66,40,17,46,163,78,7,138,126,153,0,127,41,74,93,42,212,87,5,164,65,97,214,30,44,28,18,165,149,239,87,229,50,36,246,37,165,141,120,218,87,33,212,199,89,60,200,136,122,173,248,211,11,31,57,164,179,24,47,184,145,194,233,219,146,212,66,125,134,199,39,193,189,36,144,76,154,193,163,72,170,196,42,188,10,228,161,236,168,37,25,10,30,51,93,123,52,197,211,145,112,173,107,153,10,34,43,21,62,225,249,5,88,23,188,123,62,60,77,223,33,138,22,60,226,178,246,105,196,134,41,219,161,22,36,155,88,34,98,150,15,82,239,10,140,117,239,209,84,81,53,234,170,180,246,224,5,4,133,183,27,167,72,241,54,87,17,180,230,53,171,99,58,179,216,15,224,251,10,94,15,205,89,177,84,251,126,185,197,61,173,68,28,241,220,179,116,72,161,178,244,213,154,142,235,245,25,36,14,224,181,212,67,175,94,252,247,102,149,190,105,249,51,80,96,89,63,214,157,159,181,58,63,99,127,214,8,32,248,147,205,6,20,199,211,189,244,171,7,151,10,208,177,185,91,119,46,243,83,191,209,123,220,88,128,72,233,82,187,194,186,192,79,94,97,232,104,111,143,3,197,189,163,183,75,27,75,13,96,199,169,161,83,216,241,33,200,213,105,178,14,201,236,24,186,117,134,168,72,73,3,168,224,203,111,3,168,7,57,229,84,253,135,62,0,2,218,196,6,107,115,245,126,154,171,51,47,103,203,44,239,228,74,98,145,212,207,235,6,79,141,232,159,179,222,192,219,195,58,231,35,237,160,78,103,186,148,74,213,40,202,154,44,85,59,80,248,111,32,188,215,213,88,18,170,222,57,146,226,216,32,254,228,122,72,119,77,245,4,67,123,83,27,158,111,117,176,252,227,40,14,73,56,135,63,255,240,139,54,13,54,115,91,183,178,30,165,46,173,114,16,183,246,229,223,247,100,126,171,123,50,174,41,0,194,239,54,2,148,56,161,43,51,138,107,136,104,49,139,118,158,190,238,115,115,102,103,94,172,187,224,172,81,210,246,59,187,130,114,96,209,17,84,11,124,185,93,35,39,19,83,150,65,80,245,106,179,66,165,29,140,49,80,170,39,65,216,190,75,90,162,88,34,220,174,150,106,146,67,149,32,169,28,60,93,108,246,206,79,47,238,121,88,193,22,141,69,75,243,179,163,230,180,168,114,126,126,90,55,89,248,41,80,51,76,28,95,243,0,45,86,84,255,60,210,37,95,18,58,151,205,94,61,91,13,232,0,162,183,152,51,175,30,237,227,63,107,42,36,6,82,1,171,250,236,110,176,120,164,167,247,195,161,9,13,30,236,56,192,241,245,22,33,119,36,23,40,126,20,105,44,82,121,151,87,71,234,118,109,45,26,174,89,244,237,12,86,96,225,130,135,217,38,89,190,66,228,68,180,123,199,55,163,5,226,93,238,19,167,132,121,151,162,83,38,214,157,222,246,145,213,38,170,79,143,62,210,67,251,14,155,91,165,44,89,134,219,55,111,34,177,154,76,89,179,150,206,163,75,195,141,242,59,171,78,15,20,232,215,42,136,91,53,120,94,3,85,173,8,132,153,150,206,17,73,167,183,214,97,36,93,101,82,225,9,203,179,152,239,157,59,218,83,18,180,17,63,233,71,104,200,210,159,11,154,3,176,84,198,85,114,149,236,190,29,121,93,35,164,241,73,41,156,88,6,67,127,171,120,190,85,50,96,23,174,83,123,243,251,1,29,149,237,150,136,88,248,32,58,19,99,20,0,173,147,40,17,233,181,184,89,211,5,182,183,113,182,12,98,216,24,152,75,148,111,120,0,36,224,110,207,89,122,145,44,121,20,241,232,50,187,193,226,74,52,20,42,181,239,46,192,87,21,242,244,160,228,106,86,156,196,119,193,86,25,91,117,151,221,190,103,25,113,171,59,94,171,107,192,4,19,166,171,76,207,160,179,57,85,104,116,251,170,52,137,12,242,6,147,38,157,243,97,242,167,249,213,12,139,254,255,219,199,147,122,253,50,98,173,63,39,213,65,0,244,88,141,94,221,187,83,45,82,186,198,188,79,106,59,139,197,37,34,152,61,111,162,100,4,136,12,153,136,234,56,91,177,219,138,162,95,58,113,57,50,119,92,84,222,16,3,223,137,198,73,61,209,147,97,175,41,96,208,181,51,165,94,99,146,86,224,156,74,228,93,162,82,49,83,204,85,201,182,68,167,103,116,198,138,167,236,252,84,127,10,162,16,159,247,78,98,62,133,3,51,40,202,156,210,44,21,165,8,226,38,234,253,182,79,102,193,190,106,245,35,207,118,29,76,71,102,67,221,229,217,86,50,204,114,44,14,69,119,164,116,77,150,135,204,228,129,134,110,63,91,195,30,205,107,128,177,20,237,190,228,105,33,53,236,67,80,174,125,8,118,47,116,155,215,152,3,207,178,168,19,197,245,189,157,94,116,84,223,200,10,14,131,170,134,162,7,253,36,175,44,247,3,181,84,89,199,194,26,92,29,243,170,130,192,215,187,178,86,120,81,36,12,74,249,77,7,26,106,200,0,30,67,135,2,47,154,36,126,105,82,113,206,119,74,198,126,186,165,211,56,97,232,110,65,59,62,82,235,243,27,169,176,193,40,94,127,167,201,225,185,178,118,146,21,158,33,214,34,248,196,237,25,191,175,69,64,207,233,47,178,147,60,15,112,19,241,178,119,14,0,127,205,111,248,189,175,50,140,94,39,18,64,78,255,203,127,61,124,135,197,5,248,89,39,247,236,187,57,100,23,95,118,218,49,169,1,12,43,229,137,115,118,226,150,146,107,20,213,146,61,24,105,177,52,221,48,91,174,135,14,152,18,213,197,92,193,87,167,139,188,158,216,66,105,140,221,24,208,105,213,99,101,244,174,206,240,90,170,225,156,69,55,197,169,173,167,15,45,109,37,81,176,213,205,72,71,45,28,162,3,63,75,203,59,209,119,69,161,11,130,143,159,162,204,11,84,96,7,153,195,90,227,229,106,192,44,233,14,170,193,152,32,42,27,176,151,57,173,23,34,235,19,186,102,30,81,157,117,6,65,2,222,253,0,94,125,82,231,84,120,106,108,146,3,202,63,168,55,93,137,93,115,67,233,155,126,157,229,81,247,164,180,184,46,220,69,155,253,76,231,234,7,197,60,206,234,188,169,76,253,132,159,246,189,161,223,74,29,61,230,202,145,78,220,13,215,184,15,95,55,172,83,86,141,112,91,229,219,112,89,230,206,161,43,255,78,237,32,210,96,180,0,26,236,6,68,13,133,244,27,127,5,72,162,112,108,176,165,231,126,9,123,188,36,25,142,89,210,132,31,221,25,37,81,36,134,132,146,147,131,232,47,134,45,187,174,170,150,161,203,212,62,105,65,180,90,101,175,163,69,102,76,206,124,162,191,137,148,112,142,123,216,9,93,40,139,193,225,71,131,95,104,252,173,19,13,151,13,44,198,69,206,151,225,103,245,161,194,43,185,156,167,251,72,159,11,215,13,49,26,159,85,234,250,112,45,181,193,223,255,3,122,7,217,64,98,89,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateLocNoSubjectLocalizableString());
			LocalizableStrings.Add(CreatePrivateMeetingLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateLocNoSubjectLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9fa2ae80-c4ba-4b9b-b1c4-a1e964ac8b96"),
				Name = "LocNoSubject",
				CreatedInPackageId = new Guid("d702c996-3cae-4e74-a7fe-414987972104"),
				CreatedInSchemaUId = new Guid("20677495-3b4f-4361-9b9d-6d84654cad61"),
				ModifiedInSchemaUId = new Guid("20677495-3b4f-4361-9b9d-6d84654cad61")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePrivateMeetingLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7110b0f8-ce64-13ed-1988-ee1486b52ab6"),
				Name = "PrivateMeeting",
				CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f"),
				CreatedInSchemaUId = new Guid("20677495-3b4f-4361-9b9d-6d84654cad61"),
				ModifiedInSchemaUId = new Guid("20677495-3b4f-4361-9b9d-6d84654cad61")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("20677495-3b4f-4361-9b9d-6d84654cad61"));
		}

		#endregion

	}

	#endregion

}

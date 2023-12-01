﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GCalendarToolSchema

	/// <exclude/>
	public class GCalendarToolSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GCalendarToolSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GCalendarToolSchema(GCalendarToolSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cc1fe1d8-16e1-4178-9ffe-576f133c893b");
			Name = "GCalendarTool";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,61,107,115,27,185,145,159,153,170,252,7,136,183,231,12,107,233,177,189,169,251,112,146,169,45,201,122,132,23,191,98,201,151,186,219,117,165,70,28,72,154,44,57,67,207,12,37,43,90,253,247,67,227,217,120,204,131,20,189,217,186,77,62,100,45,14,208,104,52,26,141,70,191,144,39,11,90,45,147,25,37,231,180,44,147,170,184,172,227,87,69,126,153,93,173,202,164,206,138,252,247,191,187,255,253,239,6,171,42,203,175,200,217,93,85,211,197,158,243,55,107,63,159,211,25,52,174,226,83,154,211,50,155,121,109,142,146,58,241,126,124,157,229,159,189,31,223,210,218,251,237,140,206,86,101,86,223,153,15,167,69,113,53,167,241,193,50,171,226,87,201,156,230,105,82,198,55,127,116,198,193,115,90,44,138,60,252,165,164,77,191,199,71,135,141,159,142,243,58,171,51,90,53,54,56,73,102,117,81,54,180,16,248,159,209,242,38,155,133,91,156,221,229,64,70,246,229,223,74,122,197,136,75,94,205,147,170,218,37,167,106,190,208,226,186,44,242,236,31,180,228,13,151,171,139,121,54,35,51,104,23,110,70,118,201,97,82,81,57,186,213,127,112,207,97,152,209,216,114,214,73,94,179,17,223,151,217,77,82,83,241,125,41,254,32,51,248,78,178,188,38,211,116,78,207,179,5,45,86,245,127,39,243,21,37,19,242,31,207,159,63,223,147,240,24,18,2,100,51,124,142,183,4,47,231,192,161,87,117,9,68,249,192,88,148,253,77,207,234,164,94,85,71,116,54,207,114,154,178,97,134,169,252,247,112,175,111,239,131,217,140,46,107,209,59,145,255,238,223,251,45,165,41,3,1,188,14,0,114,243,103,127,24,231,52,103,255,205,110,128,78,195,90,253,49,236,32,215,251,178,88,210,18,24,174,97,61,222,93,252,157,109,66,242,166,72,179,203,140,166,167,138,63,9,236,223,193,224,74,108,171,193,160,146,255,120,8,118,103,168,22,243,27,154,130,12,96,243,168,63,78,211,53,33,124,92,166,167,31,232,172,40,211,234,117,198,104,208,175,51,52,125,41,200,181,79,142,232,124,3,16,108,235,115,54,36,231,69,154,220,153,78,242,95,131,146,214,171,50,39,57,189,213,77,35,245,143,248,99,61,123,91,220,198,255,67,147,114,76,220,95,223,20,121,125,237,255,124,148,220,141,4,70,15,1,116,46,138,98,78,166,213,73,86,86,53,236,180,70,132,94,39,162,129,216,138,92,232,194,72,28,23,50,153,144,23,255,201,247,146,51,76,63,62,41,106,182,36,52,21,77,158,61,123,70,94,86,171,197,34,41,239,246,213,15,175,74,154,192,118,200,114,114,177,92,252,161,200,97,63,145,43,46,32,8,189,97,236,89,145,57,91,132,88,67,120,134,65,44,213,16,98,5,133,96,129,29,113,195,196,245,62,121,75,111,215,88,201,94,115,242,101,197,169,26,15,168,200,218,222,100,41,147,116,214,31,155,141,203,69,84,185,2,49,222,48,114,72,198,70,31,43,90,178,174,185,56,19,201,202,250,115,196,17,216,37,23,76,12,71,206,39,137,166,75,180,9,231,217,16,125,35,201,127,238,158,235,238,225,110,49,212,67,238,66,213,210,162,163,104,22,36,120,164,208,31,56,243,159,56,20,16,172,44,128,7,197,13,198,126,149,165,26,147,55,180,170,146,43,118,104,230,2,149,161,152,155,90,131,97,159,37,125,67,235,235,34,109,146,161,55,69,150,146,51,202,183,35,236,65,61,167,236,146,68,120,178,49,251,7,59,183,43,154,42,49,203,206,252,21,59,11,119,38,228,185,38,132,150,72,139,228,11,252,155,225,220,14,228,135,231,159,98,182,150,176,33,63,158,191,18,179,30,92,50,101,34,153,93,147,232,134,201,3,10,45,239,96,183,182,67,210,56,112,212,69,47,4,154,236,43,156,76,195,129,193,210,107,47,81,17,18,72,255,7,16,74,69,15,217,55,62,72,83,166,172,21,121,90,69,47,228,178,13,24,65,149,140,227,68,117,214,45,32,255,134,99,119,113,3,141,142,243,148,181,131,241,197,255,183,200,98,190,174,12,181,243,130,31,143,119,192,91,81,131,194,27,43,230,38,137,252,199,88,157,227,140,44,229,221,52,197,76,177,163,26,197,103,215,197,237,52,63,155,93,211,116,53,167,229,200,150,242,8,55,78,182,213,50,149,251,46,10,109,211,145,179,163,247,116,71,142,131,218,135,86,39,181,77,56,90,188,89,252,186,72,82,139,111,199,122,14,45,248,137,190,7,43,182,83,202,227,69,146,205,129,111,139,89,150,204,153,242,4,92,254,150,93,26,68,7,53,246,121,113,122,12,103,69,100,104,86,210,75,49,216,152,92,38,243,74,45,143,156,56,48,74,196,63,143,66,103,249,227,22,236,159,182,64,54,159,176,190,122,240,83,90,159,223,45,65,208,205,87,139,156,171,201,90,208,14,21,84,118,109,40,185,170,152,210,124,70,255,166,126,254,219,89,177,42,103,122,236,105,58,28,253,38,249,129,145,220,166,208,73,81,158,151,73,94,93,94,50,206,160,169,92,142,104,26,84,69,150,77,34,18,168,200,168,39,87,219,61,124,147,42,120,142,10,228,181,104,182,191,146,43,253,47,38,168,27,7,230,43,35,71,142,15,230,243,40,103,42,215,100,159,176,255,196,199,95,106,198,64,236,52,209,160,196,79,102,157,6,76,202,214,89,190,146,148,199,50,121,102,81,73,50,71,152,201,28,101,69,137,108,27,2,187,127,215,71,244,18,241,110,21,53,180,52,76,170,120,146,157,224,145,59,137,134,81,28,54,39,120,246,226,227,52,109,239,202,217,145,247,116,126,105,232,150,220,208,168,235,220,144,103,43,211,152,40,59,12,167,185,179,203,154,150,94,45,212,235,226,74,42,46,209,176,29,20,59,102,146,18,174,163,99,98,175,138,119,26,42,1,112,70,193,240,66,42,58,151,212,22,63,184,139,42,230,30,139,245,51,226,6,4,137,243,105,170,112,243,190,132,217,7,14,234,0,24,213,24,62,171,11,233,187,124,56,138,15,42,243,17,127,144,253,79,202,98,209,56,148,106,244,154,94,214,239,86,53,45,255,171,200,240,88,163,248,157,51,52,96,22,79,171,227,207,171,100,222,54,131,0,65,254,122,77,75,182,96,190,228,213,240,128,220,127,89,209,242,238,125,82,50,249,199,240,137,124,110,29,41,120,7,121,106,227,246,238,54,167,165,5,80,16,47,54,224,236,85,140,95,173,24,222,121,13,191,194,1,88,51,209,202,229,1,147,80,98,217,247,144,56,163,169,88,72,198,23,92,218,138,111,176,25,153,32,6,233,198,55,9,252,29,31,47,150,194,178,38,191,39,120,3,186,45,132,149,42,58,58,60,254,66,103,43,118,49,34,233,133,254,231,196,225,219,248,56,175,86,37,61,58,52,63,69,70,128,73,80,83,48,217,125,160,9,232,244,169,249,231,4,184,58,22,160,169,248,45,50,67,141,108,253,214,244,139,225,63,104,16,56,207,244,116,81,51,118,30,115,201,100,255,244,174,76,179,28,120,5,22,70,73,41,111,8,182,73,14,223,174,152,188,110,232,140,217,5,99,34,244,101,189,87,197,2,185,123,181,215,30,192,44,218,197,148,106,254,130,83,196,160,122,102,131,212,16,25,147,215,52,144,242,64,30,137,211,252,240,253,27,97,35,224,247,157,111,191,53,45,145,160,251,6,209,128,100,21,201,25,181,8,59,44,201,189,194,230,161,191,144,115,149,18,115,214,121,43,195,86,65,155,118,58,22,7,75,159,17,187,14,153,189,107,110,61,120,237,130,179,51,64,96,150,87,220,148,82,126,149,137,246,94,6,107,247,246,103,120,139,103,53,48,75,142,212,165,214,53,6,15,132,50,161,98,200,99,81,39,47,132,6,50,19,108,203,218,113,138,248,210,113,61,218,216,164,177,110,162,15,90,209,53,24,235,197,179,112,147,179,1,158,100,45,105,186,249,98,245,59,116,91,142,214,126,199,157,222,231,125,15,33,195,0,254,217,32,14,135,162,150,152,8,147,197,132,60,71,95,5,41,42,247,211,22,229,254,182,4,255,224,246,58,99,10,115,171,240,31,224,233,96,97,37,111,106,89,165,73,1,171,4,23,25,48,44,153,181,50,61,128,56,186,249,219,213,226,130,227,26,222,78,1,176,104,143,251,11,16,60,93,156,193,70,228,231,159,201,142,61,30,190,77,130,189,121,63,56,50,58,52,190,247,86,255,91,242,194,124,222,117,63,123,130,200,54,0,193,142,179,25,102,66,94,0,158,246,175,251,236,199,39,79,188,161,95,146,239,208,90,89,219,212,234,14,91,52,213,251,246,197,35,228,43,92,149,53,111,192,130,170,205,2,86,129,69,18,98,228,90,127,125,147,228,12,57,78,247,41,119,93,205,232,225,29,16,24,235,160,123,33,232,200,16,32,64,197,194,234,46,160,55,92,193,4,117,181,1,225,132,214,179,107,16,24,71,135,124,215,31,101,188,117,82,222,73,59,194,152,20,220,1,179,143,184,255,30,180,131,49,210,232,30,198,232,27,87,65,61,242,133,245,76,125,16,61,88,219,75,163,39,149,25,36,124,124,214,33,179,164,134,203,242,209,197,187,37,21,182,155,227,47,224,129,67,182,239,129,182,190,72,225,42,78,227,200,91,226,78,5,9,46,173,88,234,142,73,64,88,194,153,134,246,199,102,58,149,64,81,207,151,225,174,85,170,209,158,59,121,229,202,254,237,205,220,113,143,203,187,176,220,98,108,150,233,225,157,252,237,183,71,27,61,99,130,13,242,72,36,210,248,188,56,227,251,60,26,173,163,52,213,215,101,113,235,232,76,219,188,135,108,227,22,130,239,32,26,243,53,204,38,224,15,74,201,139,117,14,2,75,151,108,58,204,26,142,45,246,243,250,167,214,130,177,60,169,175,147,252,81,231,151,216,4,143,220,3,27,108,129,109,236,128,213,210,91,100,172,188,175,189,222,223,245,38,92,200,49,255,234,154,206,126,154,86,140,20,171,229,41,88,196,35,110,251,152,105,187,10,50,14,211,234,179,36,57,86,7,248,212,93,27,77,64,95,96,88,89,198,114,181,154,12,42,147,129,25,120,210,57,40,105,254,153,86,7,243,219,228,174,146,166,61,124,237,130,30,39,217,156,17,186,18,230,114,246,183,80,36,196,175,127,205,234,107,189,22,85,36,126,124,85,44,150,73,153,85,69,14,254,135,152,47,29,67,233,135,179,187,234,32,93,100,249,199,60,171,119,167,233,46,76,228,147,58,239,135,99,101,46,213,102,166,237,163,0,127,168,129,32,60,107,149,103,51,174,20,112,183,123,37,67,164,160,213,71,131,0,172,71,133,201,9,238,98,192,130,105,101,130,248,38,26,45,172,88,201,168,11,27,72,172,182,246,243,70,239,3,99,21,125,237,167,160,144,87,32,33,15,151,139,168,213,255,164,53,164,119,229,85,194,227,3,166,41,91,228,183,69,205,173,106,81,155,227,37,212,215,215,81,131,250,154,113,253,248,156,110,192,10,27,164,65,161,97,64,183,67,16,71,193,6,82,40,141,156,189,238,16,148,239,53,176,72,232,56,52,137,248,7,41,64,34,229,73,3,119,147,66,207,222,161,1,227,228,215,219,172,194,171,34,71,22,59,85,242,29,219,5,234,134,223,190,167,98,227,183,219,230,46,98,114,51,3,127,185,160,212,87,219,166,100,173,29,58,211,123,112,221,221,9,28,107,122,155,109,169,89,84,128,81,139,193,192,163,214,60,214,10,121,166,12,167,200,127,7,221,176,34,198,196,89,221,24,221,217,31,176,220,152,89,59,204,225,107,143,229,128,201,149,120,96,4,175,179,89,182,76,242,26,51,165,99,115,199,7,207,50,216,227,113,236,29,192,70,177,101,120,56,96,160,131,249,92,252,34,136,163,189,127,13,61,48,235,53,52,217,140,27,197,194,34,63,138,45,182,108,38,228,191,82,32,138,128,200,232,246,53,144,65,132,140,109,9,32,55,254,39,225,20,133,77,196,181,170,222,164,115,39,128,230,182,250,21,204,10,255,10,0,248,110,226,146,130,7,78,123,223,99,152,73,255,217,175,66,243,190,130,240,242,100,254,107,88,84,179,211,164,132,124,222,127,110,222,52,108,221,36,12,161,77,51,177,35,140,17,246,142,123,26,125,33,87,232,143,49,9,181,64,120,40,177,36,207,229,43,123,64,240,212,227,142,147,137,112,249,124,223,20,124,189,107,181,143,237,86,50,150,230,54,227,87,99,103,40,125,16,204,146,138,54,71,103,239,54,54,210,225,215,187,230,162,141,38,26,79,115,70,6,170,250,240,211,195,220,168,248,177,135,48,215,205,242,163,98,117,97,226,12,66,32,45,2,89,222,148,193,5,227,213,159,156,91,122,0,117,69,190,109,98,206,67,169,202,5,187,102,109,17,247,148,94,38,171,121,189,77,60,85,212,255,26,104,34,199,119,24,79,28,242,209,18,28,93,17,250,37,171,106,224,251,151,21,165,100,86,210,203,137,57,132,158,237,147,207,252,92,134,123,253,203,37,136,25,136,117,202,153,180,153,12,175,240,246,203,104,197,90,55,68,82,243,95,120,239,166,174,251,98,47,43,101,1,98,251,145,242,243,242,25,239,28,134,85,57,113,12,226,28,31,238,155,56,165,20,98,62,47,51,10,215,43,104,11,160,65,203,133,254,237,176,209,50,24,127,168,26,0,175,200,194,120,75,123,3,183,3,118,124,248,182,145,163,247,16,66,208,86,251,104,61,61,125,10,22,54,147,134,126,6,65,117,233,212,247,142,37,179,152,149,19,234,217,244,56,95,45,152,216,191,152,211,151,112,229,17,157,221,192,178,125,226,174,187,56,147,138,85,237,15,39,111,34,225,213,29,147,182,62,45,171,38,15,193,182,222,237,203,98,31,22,63,124,146,8,138,216,110,119,122,210,182,148,64,228,219,142,232,1,247,99,118,124,188,43,197,21,57,137,167,60,9,204,141,169,145,126,87,222,211,109,19,159,23,7,101,153,232,32,72,76,124,149,102,66,33,22,173,11,165,63,37,21,143,89,147,88,140,70,161,97,113,84,155,60,33,231,197,213,25,154,181,156,216,73,81,46,146,58,26,54,179,137,161,213,228,135,251,231,15,159,246,36,154,236,175,23,15,159,164,198,43,44,193,31,235,108,174,98,207,115,118,49,139,116,215,209,152,52,52,17,192,148,154,140,140,110,24,223,222,22,201,173,92,184,155,236,149,98,136,103,207,228,45,187,233,14,162,27,232,107,120,24,224,174,250,249,147,84,13,83,20,69,129,111,230,8,84,239,134,174,3,48,188,35,125,147,65,83,100,111,203,238,12,216,29,2,186,155,158,45,154,54,14,121,17,195,180,111,99,127,36,31,66,11,162,241,187,50,165,229,225,221,17,173,102,17,34,219,122,70,79,97,240,179,169,116,169,84,255,205,237,26,82,15,240,23,96,108,54,160,194,89,137,9,241,15,41,28,248,31,32,2,248,63,108,139,158,49,101,200,46,211,202,53,246,185,22,154,240,20,149,1,194,138,182,1,138,136,207,213,105,89,104,119,128,183,251,212,236,181,193,133,141,57,38,96,47,154,37,115,237,129,5,57,49,171,217,90,41,179,9,6,221,141,154,223,252,209,107,130,239,247,138,230,90,154,235,224,36,151,128,24,143,144,221,134,181,199,23,168,86,117,15,200,217,160,233,41,133,128,92,220,249,186,30,106,216,87,199,211,93,176,42,98,171,4,142,30,98,52,25,235,18,40,112,127,75,111,123,7,38,99,134,249,90,129,16,210,90,247,152,64,8,100,119,119,99,208,129,244,218,230,190,103,155,163,207,172,232,152,136,155,49,249,246,118,174,26,231,73,245,147,178,96,118,128,208,61,25,198,87,69,121,23,2,119,176,92,22,89,94,47,152,54,237,55,239,26,192,201,80,177,13,70,220,109,149,241,59,46,79,39,157,144,41,255,67,13,3,63,130,71,66,44,187,137,69,30,163,60,38,4,142,103,133,24,112,161,104,57,71,103,241,56,44,182,210,68,217,21,98,194,20,150,49,97,122,10,15,174,35,121,65,42,6,154,77,195,15,253,83,155,221,124,65,249,37,107,120,184,125,167,137,72,60,97,2,67,237,3,68,137,0,195,4,243,37,144,213,214,73,151,48,187,72,116,223,98,92,156,233,24,159,65,34,0,79,109,73,100,43,57,93,28,192,4,201,11,114,227,216,19,208,238,226,176,203,170,153,65,76,71,3,218,251,214,150,240,161,57,91,158,241,136,187,3,160,27,176,70,116,0,167,67,22,36,196,64,204,130,175,53,82,123,170,240,186,183,224,133,137,37,88,71,168,251,109,228,97,231,77,143,80,92,216,97,161,168,98,178,15,252,245,177,158,233,80,229,134,12,112,28,105,21,206,127,148,233,154,0,228,127,139,156,78,243,203,2,20,253,27,202,184,135,253,6,171,205,198,9,98,97,2,193,90,220,137,10,240,40,152,215,105,197,147,108,148,47,55,24,68,162,53,39,252,7,186,200,32,181,119,127,164,93,131,170,191,250,84,161,13,56,138,95,205,105,82,26,150,192,169,100,238,62,109,143,62,195,81,55,136,253,62,48,221,233,34,153,253,20,100,64,43,242,227,132,73,45,38,241,234,2,78,112,88,20,80,33,244,169,7,134,33,75,84,222,50,157,136,201,75,242,135,80,80,116,76,134,228,91,181,58,223,12,53,146,187,228,158,174,19,45,210,215,198,117,157,228,87,76,233,209,216,106,93,131,87,38,16,38,149,59,145,231,187,170,100,196,244,76,230,107,51,137,90,177,189,196,25,231,151,80,121,60,104,73,8,88,8,76,43,148,50,144,134,222,12,145,93,6,234,235,164,38,51,78,57,94,58,65,174,110,146,167,80,69,65,136,131,199,25,182,218,44,83,178,77,111,34,181,90,232,30,49,144,165,128,30,167,153,62,109,26,117,207,49,113,52,194,49,202,243,39,238,50,128,41,66,240,242,102,118,168,241,38,214,175,127,162,122,44,255,220,64,73,182,50,157,69,67,43,98,88,31,128,205,14,240,134,180,37,95,193,122,188,34,42,16,28,19,23,227,22,228,80,64,10,15,65,11,222,182,67,250,108,56,187,91,13,140,18,120,38,164,7,54,234,200,222,15,217,66,48,96,166,54,6,97,119,64,109,231,103,28,148,128,7,123,31,226,230,254,131,182,217,112,156,17,179,74,237,77,113,150,243,197,183,127,138,124,218,142,219,49,29,135,169,134,134,101,42,214,180,58,48,227,112,49,1,250,181,252,167,80,107,212,247,54,150,107,69,68,142,40,60,136,142,6,163,100,201,62,132,53,30,228,41,232,177,234,219,225,157,208,28,201,68,240,156,39,254,130,144,0,151,17,88,144,148,230,161,54,113,112,185,68,122,135,119,69,180,51,29,3,9,82,28,170,163,111,250,43,212,35,3,46,12,221,191,109,57,115,149,87,46,173,54,193,252,112,218,117,47,77,222,129,9,48,90,52,249,237,132,138,139,48,89,180,203,131,113,178,195,183,197,237,208,43,13,197,192,171,95,134,126,20,237,227,147,138,67,209,181,129,240,114,185,142,93,55,149,7,35,65,221,253,109,149,42,216,9,111,67,195,35,205,59,3,111,73,29,47,57,178,55,167,209,212,173,220,66,183,10,72,83,247,113,187,184,211,197,54,124,234,219,10,243,32,160,133,152,112,156,142,99,10,129,179,167,177,21,210,152,52,199,45,221,43,191,218,173,114,211,59,101,231,109,69,134,134,107,221,27,52,238,4,174,227,90,5,159,105,47,94,207,11,73,165,124,177,220,199,206,47,177,197,37,182,255,26,103,45,214,132,171,102,85,88,34,201,205,4,108,213,37,121,78,29,47,99,111,135,48,70,16,135,22,135,139,103,137,208,27,189,196,107,85,216,50,10,82,96,19,152,227,214,6,166,43,164,0,36,172,215,246,119,84,183,57,163,59,116,252,134,1,165,91,178,197,29,143,169,42,92,229,109,110,244,126,238,242,14,183,56,198,213,248,101,112,60,71,3,198,224,84,193,209,127,130,161,116,133,199,137,197,34,242,152,169,120,45,25,180,29,14,114,110,205,99,191,10,132,155,52,13,37,41,195,228,16,26,33,176,89,69,109,159,59,249,249,231,126,128,173,155,6,134,36,43,220,152,137,50,46,109,159,100,198,186,241,192,1,135,36,34,232,154,109,85,222,66,129,52,174,249,55,213,149,239,148,239,183,109,49,82,194,69,63,118,23,196,242,213,55,57,235,17,24,21,82,144,139,242,63,212,141,119,104,7,228,78,93,2,91,113,96,43,15,88,208,245,207,232,209,219,176,212,80,143,14,205,71,11,31,223,41,37,43,203,241,80,138,61,207,227,240,141,242,184,147,75,118,200,200,122,86,228,30,117,98,199,71,61,95,199,12,246,208,134,179,67,186,17,118,177,154,26,78,186,30,222,84,86,63,30,52,165,247,2,249,69,16,122,162,183,217,32,121,212,46,243,213,63,189,207,58,32,123,219,172,161,10,147,101,184,9,186,141,66,118,153,46,211,139,68,177,205,208,18,90,127,185,233,182,188,254,173,101,157,68,92,161,174,105,137,239,32,214,17,221,24,73,187,111,5,179,74,147,149,48,107,203,43,163,138,31,196,205,20,179,89,172,121,213,52,6,55,50,134,186,227,212,20,16,146,77,69,242,100,220,178,145,30,39,89,158,202,31,171,195,59,238,119,139,26,135,143,249,247,176,118,167,35,1,240,68,76,242,69,166,115,38,220,162,148,1,162,240,50,104,92,112,209,54,53,27,117,225,204,189,51,65,153,123,232,206,218,60,31,47,126,57,92,99,218,185,238,246,52,169,179,155,99,229,148,208,173,11,47,92,64,155,174,251,135,132,242,2,121,237,118,243,71,89,203,27,53,90,239,154,239,165,100,242,194,126,48,57,199,166,169,86,3,223,38,200,204,220,7,212,239,237,121,109,170,85,151,3,29,252,166,112,125,97,242,161,233,250,34,170,12,198,186,105,124,94,124,204,51,246,181,74,230,252,187,58,110,45,0,236,194,51,14,161,173,142,211,70,148,142,86,180,31,66,178,225,118,208,129,253,229,144,19,204,209,213,9,59,93,87,37,61,206,65,162,165,160,242,240,69,126,67,41,236,196,138,109,165,39,79,196,98,198,211,74,126,244,179,3,189,216,10,144,201,40,22,2,132,12,60,5,80,191,158,253,195,30,193,181,94,43,217,209,8,250,109,81,179,91,153,170,192,42,146,253,130,23,236,78,228,196,172,248,95,189,71,149,43,67,171,89,153,45,145,172,19,114,0,185,215,133,127,242,188,224,9,146,168,232,37,170,104,105,101,56,187,251,105,215,40,19,211,116,50,36,223,182,185,172,217,87,206,78,108,38,188,169,177,172,53,219,39,206,148,82,32,200,49,18,48,224,42,255,244,188,232,13,5,153,191,205,86,227,176,158,110,0,66,109,141,222,225,30,193,34,177,129,99,251,188,64,54,197,6,81,213,32,166,76,68,107,119,230,94,203,18,169,37,183,148,0,115,147,209,183,111,249,45,234,153,35,137,193,246,85,71,132,250,202,216,216,254,81,152,9,196,138,125,223,84,46,28,67,141,164,29,115,183,87,99,127,72,36,153,236,35,223,207,241,236,165,154,217,58,151,166,174,103,201,184,88,46,80,75,174,199,88,75,224,148,59,215,90,76,72,9,91,218,10,25,117,239,13,56,107,89,176,144,151,225,44,20,45,156,186,98,41,51,74,52,113,5,9,154,58,177,240,157,245,95,173,135,20,102,104,204,181,148,67,94,91,10,245,117,205,231,190,118,31,158,70,136,248,96,247,251,0,214,187,200,66,79,117,65,218,35,55,132,168,242,15,202,185,50,112,20,198,252,46,82,234,222,210,92,186,116,250,175,26,147,53,147,122,37,183,180,87,209,82,234,180,50,82,222,68,164,42,197,227,213,106,14,103,229,244,42,103,44,241,42,169,192,110,250,228,137,134,191,116,117,200,157,38,37,18,175,105,123,206,18,59,124,119,66,115,55,139,238,76,62,77,35,191,240,51,134,168,85,97,85,184,153,98,69,126,208,161,6,163,132,58,165,8,59,86,122,238,23,232,156,212,58,115,98,71,105,113,67,245,154,218,31,197,229,26,214,89,46,155,183,154,116,237,69,13,85,35,129,24,151,8,222,182,201,156,212,70,37,174,158,146,23,123,236,227,62,84,200,35,217,211,167,150,163,36,204,245,30,7,90,112,127,200,62,109,192,144,253,170,65,91,151,188,71,223,17,195,88,183,94,13,69,86,191,5,39,32,246,131,140,112,80,71,89,104,133,66,103,154,189,82,157,42,131,46,82,238,197,164,192,61,38,172,54,232,224,135,91,125,42,97,213,33,235,21,5,9,45,107,208,195,122,87,136,151,90,155,233,94,41,245,171,191,155,31,171,108,6,80,42,148,176,53,192,104,181,205,83,107,77,97,84,69,90,91,175,189,207,210,7,165,184,222,115,2,60,24,29,244,94,79,233,225,233,189,196,234,65,217,80,123,26,123,178,203,104,103,179,107,15,212,86,108,186,247,160,155,3,164,166,192,127,93,37,3,202,50,114,66,1,225,100,0,144,127,163,61,10,180,10,133,9,25,223,241,30,226,245,51,180,228,250,225,162,81,104,100,128,201,127,59,41,74,238,107,119,201,167,73,109,13,112,164,89,225,145,224,229,234,33,141,207,222,49,156,218,58,177,78,220,145,52,181,157,56,92,185,239,180,158,142,41,223,193,122,188,43,225,96,38,247,98,138,252,15,195,131,104,101,217,143,58,236,242,155,161,102,74,135,244,140,53,45,90,173,97,136,236,190,168,4,167,26,42,94,165,73,23,20,82,138,146,40,86,92,230,192,132,211,43,17,101,244,205,90,198,202,254,153,222,177,171,240,9,147,212,169,95,147,15,245,51,190,20,84,141,199,74,191,49,185,216,235,148,76,241,51,10,183,90,151,75,91,190,30,85,146,11,229,199,233,40,181,134,52,65,81,113,51,252,205,18,241,110,154,160,43,185,157,239,142,72,118,123,187,49,67,166,213,182,138,4,53,100,174,108,113,36,8,248,179,43,18,153,0,30,158,121,195,181,10,167,22,81,56,247,203,45,158,113,36,170,21,200,199,24,223,67,254,142,121,113,76,115,156,220,106,203,172,194,13,227,55,201,23,245,254,33,4,195,57,79,33,226,97,123,60,73,213,253,92,27,55,45,47,68,50,135,112,146,180,101,161,193,37,181,197,236,220,211,234,252,203,70,108,171,206,6,156,88,51,245,206,220,77,86,214,140,15,218,138,178,201,200,211,222,65,200,118,129,49,169,108,163,234,81,253,11,174,73,3,64,98,189,149,19,204,113,218,51,35,94,185,54,2,81,220,172,173,60,26,26,0,219,85,124,64,129,212,83,20,112,237,95,13,122,93,1,208,232,238,241,215,105,90,197,129,188,99,143,216,221,221,229,179,25,99,23,247,88,23,160,126,78,190,247,23,113,215,107,47,139,133,173,103,76,54,195,7,104,189,230,220,155,33,56,149,245,188,60,68,78,254,22,250,181,250,166,152,194,86,121,66,129,122,225,77,107,184,164,220,205,236,199,74,57,161,82,225,173,108,18,195,228,246,20,160,21,223,74,39,48,138,29,109,155,230,41,200,201,82,101,13,117,75,202,95,76,20,170,50,34,220,248,136,163,204,172,20,40,55,208,204,46,62,226,210,15,123,169,237,76,42,35,69,108,79,5,28,179,93,249,193,242,240,52,210,75,119,37,223,35,139,177,61,96,143,165,57,195,75,195,29,163,225,60,155,2,246,90,239,132,235,190,252,218,117,252,244,60,197,30,153,184,221,117,152,217,254,36,207,62,209,181,116,45,12,97,246,196,164,141,57,220,252,57,81,28,89,117,221,145,245,189,158,60,49,240,184,129,203,156,50,243,2,158,87,200,153,34,119,147,192,193,2,127,131,178,132,147,65,173,136,1,205,17,76,103,209,64,237,136,1,245,115,44,84,38,16,246,195,101,177,92,45,135,24,147,248,77,150,175,106,182,109,216,53,73,248,203,216,71,141,201,190,223,78,120,108,140,169,20,97,29,110,27,140,10,16,247,92,213,117,199,153,177,1,223,40,214,173,53,183,115,191,251,246,18,158,102,53,143,13,236,66,160,158,203,169,70,79,213,100,140,133,212,142,204,238,61,19,252,222,223,122,83,17,177,172,182,249,175,223,73,221,138,195,166,40,244,139,252,208,38,175,37,182,78,118,30,65,91,78,160,12,235,209,141,242,144,169,19,251,250,74,69,86,121,246,153,109,28,83,21,172,143,252,234,78,228,104,214,200,91,170,160,82,156,136,247,216,204,59,132,24,182,130,126,150,133,85,251,59,125,181,178,230,133,243,94,44,23,33,91,15,131,206,71,233,95,11,23,61,241,1,228,81,65,16,251,228,18,12,50,74,41,159,230,135,203,133,42,229,223,208,3,63,5,106,206,115,11,187,29,39,110,60,56,198,6,254,67,165,111,55,185,16,195,232,168,32,86,238,233,145,190,29,168,233,197,51,64,70,150,154,204,61,80,62,182,58,2,248,207,212,179,6,53,189,164,215,56,117,110,181,232,3,100,236,63,140,26,114,72,135,248,227,85,177,4,14,108,248,170,8,194,61,72,33,223,244,136,26,250,244,240,100,39,129,223,178,70,222,5,220,52,121,248,86,189,88,44,241,101,53,0,206,118,8,75,193,43,239,199,108,24,236,94,222,208,37,37,46,163,174,249,21,99,54,38,67,157,14,47,29,115,184,111,224,114,220,224,71,19,110,159,64,141,201,208,196,61,23,40,194,160,139,83,49,246,35,161,184,56,192,124,77,2,143,45,31,243,104,240,105,26,109,235,167,155,37,172,183,143,141,189,204,51,180,198,172,75,204,80,148,144,251,50,149,242,218,7,121,182,137,217,97,145,55,8,3,157,224,48,80,68,244,32,94,142,188,11,81,19,60,33,193,173,134,206,156,94,79,57,133,86,170,229,77,221,7,91,75,193,189,14,244,241,131,152,79,111,175,206,109,72,38,78,1,115,109,215,12,204,222,46,233,203,201,133,136,218,243,28,25,56,80,26,228,125,183,99,31,216,143,211,105,45,7,185,77,209,214,74,201,118,61,228,0,41,93,237,209,90,205,134,151,132,123,104,137,178,88,46,185,225,76,240,117,239,177,221,55,207,80,141,173,6,115,41,214,162,195,172,220,105,161,105,168,180,230,228,228,110,96,150,218,158,161,230,237,218,40,118,153,107,194,32,90,138,78,117,93,247,183,242,230,119,239,39,191,55,127,181,123,179,71,187,245,195,11,184,179,237,207,113,41,204,143,107,175,48,129,186,242,6,170,63,152,12,238,142,82,5,66,49,119,219,218,117,11,108,251,89,20,72,183,39,251,164,41,55,151,191,158,216,138,67,75,103,20,160,102,134,181,75,81,188,12,204,222,30,180,169,125,16,153,81,247,70,231,15,208,84,16,41,198,171,194,213,162,42,156,64,221,144,80,220,143,133,77,252,87,94,74,168,29,12,15,117,48,136,145,147,121,114,37,140,57,64,130,140,9,126,171,56,84,75,109,234,217,62,244,122,249,108,182,191,14,241,246,72,81,95,211,242,54,171,40,121,74,24,16,110,249,0,40,136,172,237,2,74,110,159,150,162,46,107,212,247,49,17,83,174,216,122,188,187,77,23,125,241,96,107,169,225,128,87,106,69,171,109,44,84,115,198,14,60,121,180,11,45,232,19,108,112,166,133,162,231,184,134,156,241,2,180,153,158,148,231,13,26,181,189,52,133,194,24,172,80,141,157,86,207,99,184,96,163,53,78,167,68,144,105,228,149,204,191,52,213,196,46,104,125,75,169,239,179,182,124,218,144,242,191,133,92,170,95,165,240,88,134,100,236,182,74,130,33,193,114,142,4,75,11,45,173,226,111,234,121,115,254,138,97,31,95,26,234,60,182,4,145,145,80,142,174,36,209,100,139,246,83,101,222,38,176,204,168,115,183,38,221,140,97,115,33,75,211,37,72,173,70,109,248,40,2,104,139,192,11,215,18,234,47,233,196,222,106,42,125,208,178,178,88,141,11,232,10,253,35,51,219,75,82,133,149,137,109,87,137,242,188,134,168,64,201,75,183,64,73,88,21,241,44,131,125,64,132,181,147,127,137,162,127,137,162,223,172,40,234,119,165,249,138,210,103,91,178,128,136,255,253,34,2,129,155,37,208,251,133,197,165,121,253,71,83,162,231,190,166,213,231,246,173,210,111,147,4,74,18,133,182,115,119,156,136,231,170,10,23,155,9,22,211,113,110,181,235,60,234,216,55,85,94,239,23,250,165,22,111,252,50,5,119,41,34,49,123,211,252,23,144,165,27,198,55,217,113,237,107,7,39,218,54,215,227,47,225,224,62,167,69,123,54,10,122,83,220,246,207,44,66,229,113,236,9,236,162,2,41,247,207,31,72,116,255,226,225,233,253,119,15,35,82,210,89,118,195,102,175,16,184,255,163,78,227,64,232,241,112,103,171,50,188,138,66,192,63,202,192,230,113,83,237,18,148,1,176,88,163,132,13,182,208,118,135,229,174,46,152,248,149,166,38,254,111,82,220,208,178,204,82,93,73,132,178,213,167,230,206,132,204,50,58,124,24,69,227,67,147,247,101,113,147,65,96,9,220,162,192,159,48,131,34,133,240,192,91,85,157,23,63,81,157,105,222,246,66,60,127,220,157,152,4,64,183,148,155,234,18,209,88,82,105,76,108,127,100,119,244,179,104,45,239,224,1,155,83,251,125,29,252,192,226,79,45,159,37,68,168,14,32,173,88,240,41,114,86,42,96,225,26,122,203,25,46,95,135,117,223,107,58,95,242,76,156,87,236,176,174,78,216,94,40,132,7,94,102,94,155,222,180,252,19,111,171,125,229,162,171,168,49,238,55,110,19,116,13,76,194,115,154,229,4,68,245,58,85,119,72,51,73,224,17,244,96,7,145,192,195,223,110,239,201,241,125,107,205,169,7,212,78,245,80,147,0,211,50,2,170,51,85,207,161,185,150,160,68,225,141,15,218,31,110,111,61,58,248,48,43,238,39,95,135,52,60,127,75,60,53,127,106,78,65,53,111,15,67,89,121,76,10,52,85,128,12,34,191,70,25,175,180,85,243,93,1,113,200,79,158,144,40,154,86,220,183,197,75,37,131,63,23,218,240,74,70,42,221,106,159,156,23,105,114,39,114,208,80,235,64,165,174,118,98,4,38,177,25,53,152,68,81,197,207,54,38,8,162,197,206,68,201,39,33,99,170,24,166,199,191,73,127,117,42,59,15,30,73,49,12,166,39,2,138,131,84,215,1,131,105,70,196,213,53,39,189,203,107,174,187,112,97,122,175,191,118,150,135,95,87,203,227,149,206,124,222,240,171,45,240,22,42,61,91,201,4,83,39,209,170,218,230,37,224,173,205,154,75,209,126,93,222,92,22,165,124,87,92,71,32,183,200,179,8,245,132,84,238,23,1,66,113,142,21,5,236,252,85,8,189,139,243,77,251,92,165,54,203,193,222,27,86,82,89,134,247,33,238,210,191,115,166,52,250,82,223,183,30,36,85,120,156,82,134,106,235,241,152,84,242,239,68,150,0,126,79,203,247,138,126,19,156,121,221,179,98,169,28,70,199,53,168,97,237,135,56,84,60,172,42,48,108,226,180,116,251,166,146,31,107,34,16,28,127,77,214,228,55,141,222,60,216,227,136,215,85,150,249,100,188,51,158,59,107,141,138,180,166,199,35,88,159,38,144,38,41,90,111,47,197,79,208,187,253,169,193,79,56,164,99,56,182,103,185,205,92,192,83,97,254,97,107,100,149,231,110,148,199,198,141,130,15,139,166,167,248,30,135,17,170,247,197,207,40,47,252,79,62,84,119,120,167,110,222,235,188,223,167,145,230,254,22,153,138,42,6,64,199,119,193,174,104,39,143,121,35,145,67,135,28,97,111,221,27,223,212,108,122,201,210,155,174,40,90,98,80,108,224,11,175,31,146,228,212,181,99,76,214,178,71,136,226,58,78,203,128,76,226,167,40,63,132,255,34,195,131,229,40,103,230,199,134,136,47,212,45,62,92,101,243,212,80,252,64,38,37,88,207,104,35,105,37,69,171,121,110,141,201,19,41,190,37,54,192,51,70,38,238,254,152,67,237,45,60,34,160,248,121,126,78,191,212,81,255,167,212,2,41,245,218,32,51,19,185,117,170,18,167,75,181,53,178,224,189,160,84,252,238,144,183,176,225,211,247,173,113,159,195,252,9,15,214,7,236,122,57,117,101,6,223,232,97,207,126,103,73,123,123,123,67,194,238,97,23,154,170,22,97,32,173,91,184,244,177,247,87,225,28,87,183,216,36,199,113,138,211,28,138,171,212,244,140,129,51,22,211,24,2,102,59,177,51,74,131,93,184,183,101,4,162,130,106,215,152,125,67,32,110,56,225,247,112,185,240,30,170,107,97,25,146,92,130,108,172,104,77,208,34,254,191,101,36,206,8,214,97,236,69,65,32,20,154,22,216,214,89,118,144,97,17,117,222,226,74,75,65,207,229,174,95,227,202,60,15,97,165,90,123,209,247,18,164,19,180,172,43,255,152,48,21,240,31,201,2,28,56,241,10,202,150,160,103,235,132,130,128,138,58,134,107,144,144,31,135,238,122,253,56,148,239,20,216,33,60,27,22,50,238,163,126,54,25,153,126,105,5,116,173,167,185,155,212,136,109,22,171,48,85,58,26,116,84,152,227,66,107,150,2,214,87,120,106,57,236,113,219,246,112,236,54,101,169,186,95,89,217,30,111,62,210,107,198,189,239,74,181,74,214,104,205,246,231,145,171,253,6,253,214,191,94,162,118,220,168,48,21,148,84,254,218,148,95,31,165,158,203,19,220,83,214,219,58,193,21,27,117,245,238,90,242,6,25,18,4,248,235,186,44,134,30,166,92,227,29,22,145,52,237,183,13,92,118,120,215,226,226,239,140,249,247,201,92,188,228,218,208,149,87,174,62,152,207,85,115,94,130,82,254,76,75,153,121,168,190,93,113,235,184,248,107,116,213,248,124,251,35,75,2,241,98,24,128,181,255,82,188,33,230,99,175,141,27,222,93,220,7,172,28,69,117,237,115,93,26,106,189,115,93,62,69,205,221,25,155,190,65,205,147,72,69,10,153,67,130,24,244,236,168,235,213,52,245,196,217,84,153,147,209,219,102,50,86,76,175,106,36,74,68,169,158,76,164,218,79,86,200,50,101,209,72,63,108,102,166,165,216,72,150,228,170,84,101,46,192,95,102,74,58,248,171,97,116,81,44,79,209,80,45,214,154,104,16,97,107,74,78,78,67,27,65,156,166,14,109,108,154,42,230,111,34,43,136,3,65,9,73,42,196,30,140,141,83,126,61,17,116,83,244,253,192,127,198,84,54,87,129,219,235,140,93,67,34,209,51,134,150,56,105,114,192,48,243,212,100,217,22,140,17,34,200,224,185,222,253,205,239,41,4,119,192,73,150,39,115,166,176,53,249,214,55,126,127,218,242,3,48,8,7,104,63,75,128,97,19,132,245,76,9,228,70,223,163,222,219,120,163,134,221,21,48,50,206,53,36,140,148,245,118,14,71,10,65,217,6,82,169,94,101,192,201,89,243,48,78,146,101,17,78,6,200,218,200,40,183,150,242,67,195,133,15,253,105,206,60,135,92,184,94,137,123,161,243,79,66,203,211,141,108,26,32,107,221,117,80,247,74,235,65,120,57,5,105,51,11,14,232,58,70,20,247,34,68,213,107,230,62,130,152,4,210,135,164,17,84,92,43,17,115,95,128,180,81,179,134,112,81,114,150,23,163,230,238,246,14,26,10,30,208,40,186,124,163,46,210,176,107,81,0,233,241,151,37,19,188,21,227,138,125,96,60,161,248,184,35,75,89,207,191,131,162,225,9,67,254,101,228,166,198,111,237,156,11,61,229,153,139,65,171,145,247,32,167,220,12,13,171,17,164,42,94,21,107,221,153,46,180,200,106,92,216,33,240,249,184,44,11,166,96,5,147,64,84,173,122,222,132,13,63,28,218,7,197,65,154,44,217,180,168,16,222,220,136,205,118,220,133,252,175,204,47,12,181,137,134,98,112,9,26,91,12,181,52,193,131,131,44,105,196,29,157,49,114,232,248,96,185,164,144,30,14,223,245,129,226,126,29,254,152,15,221,211,102,160,231,170,26,123,241,111,15,158,8,115,130,224,4,86,164,128,124,68,192,114,23,130,223,224,165,16,129,237,154,2,141,109,79,155,193,216,48,231,101,146,87,151,151,12,160,230,20,123,105,223,43,199,185,218,81,18,228,25,53,209,84,150,179,210,137,112,19,191,218,63,178,223,216,255,254,15,72,98,244,204,13,198,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cc1fe1d8-16e1-4178-9ffe-576f133c893b"));
		}

		#endregion

	}

	#endregion

}


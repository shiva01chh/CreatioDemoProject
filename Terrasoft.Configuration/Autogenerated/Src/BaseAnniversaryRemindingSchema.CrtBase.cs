﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseAnniversaryRemindingSchema

	/// <exclude/>
	public class BaseAnniversaryRemindingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseAnniversaryRemindingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseAnniversaryRemindingSchema(BaseAnniversaryRemindingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("627718f7-94a8-40e7-9791-08a084a92574");
			Name = "BaseAnniversaryReminding";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e07b3414-0244-4600-8fa5-7c3b4f179d09");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,60,107,111,220,56,146,159,123,129,253,15,220,62,96,79,125,215,35,207,100,95,192,216,238,192,207,108,239,38,113,54,118,54,184,59,28,6,114,139,182,117,81,75,29,81,109,167,49,240,127,223,42,190,41,146,146,28,39,192,229,67,172,166,200,98,177,222,85,36,85,101,107,202,54,217,138,146,43,218,52,25,171,111,218,244,164,174,110,138,219,109,147,181,69,93,253,246,55,191,254,246,55,147,45,43,170,91,114,185,99,45,93,239,119,126,67,255,178,164,43,236,204,210,87,180,162,77,177,242,250,156,102,109,230,53,190,46,170,207,166,241,164,110,104,122,158,173,218,186,41,40,179,218,27,138,152,164,231,240,103,219,208,171,250,246,182,132,118,211,193,198,188,161,177,246,244,244,56,252,106,189,174,171,232,160,179,170,45,90,129,14,116,249,183,134,222,194,50,201,89,181,93,255,76,78,179,29,227,205,155,237,117,89,172,8,133,86,217,56,65,162,77,46,183,21,57,36,63,205,241,249,77,141,207,47,248,243,213,150,194,243,31,248,243,71,154,195,243,31,69,251,221,22,158,255,196,159,207,155,2,158,255,204,159,47,179,22,158,255,2,143,143,2,13,90,229,2,19,7,171,147,50,99,236,103,114,156,49,122,84,85,197,61,109,88,214,236,222,211,117,81,229,176,52,222,119,111,111,143,28,176,237,122,13,111,22,242,55,14,32,43,28,76,110,234,134,220,34,11,179,150,146,204,0,33,141,130,194,82,5,101,207,2,35,41,144,93,179,182,1,14,74,104,113,76,144,62,184,50,141,58,200,78,155,85,173,160,231,100,211,20,247,136,193,10,155,73,81,181,228,148,222,100,219,178,213,32,94,23,55,244,29,72,90,141,212,251,195,143,251,189,163,222,214,109,113,179,67,206,232,33,47,246,37,2,46,41,53,66,231,5,45,115,32,230,59,1,83,188,236,18,143,55,252,99,75,129,62,155,166,222,208,6,37,5,166,87,234,144,234,65,54,173,52,158,175,11,214,30,252,157,238,254,153,149,91,250,46,43,154,3,160,30,172,109,78,196,223,197,130,252,242,25,161,191,211,192,71,99,93,183,128,2,205,123,240,62,217,54,13,5,26,177,213,29,93,103,164,2,67,16,197,87,66,147,120,145,75,62,228,45,140,216,31,49,65,67,87,117,147,147,101,62,8,254,213,182,200,201,123,222,125,137,76,194,223,233,217,122,211,238,250,230,185,172,183,13,216,175,177,240,69,247,101,222,7,242,234,142,18,78,121,82,111,184,93,35,121,193,57,10,157,6,103,57,213,93,53,63,251,153,204,37,232,66,76,100,6,15,176,154,107,76,179,69,107,57,146,223,102,128,89,194,38,107,178,53,231,253,225,116,203,104,3,157,42,33,187,211,197,7,231,55,232,19,106,232,138,166,7,123,124,212,98,136,14,49,237,79,58,128,221,121,103,132,155,206,201,47,110,51,72,131,219,176,47,122,85,190,106,255,240,19,249,15,225,76,28,71,150,130,211,185,164,109,203,109,216,43,218,114,134,116,112,225,214,118,50,33,129,127,83,48,34,244,161,110,218,187,221,217,61,136,53,183,41,197,138,131,22,83,79,231,49,123,51,227,200,62,246,51,212,40,121,199,234,60,193,92,252,195,181,22,146,148,183,20,220,135,111,75,200,203,151,36,241,26,15,73,69,31,70,204,149,204,196,170,38,44,2,253,144,220,227,224,167,47,125,88,148,99,146,217,111,110,33,140,200,235,170,220,117,135,255,18,16,44,35,197,157,206,157,159,184,112,111,120,20,239,243,50,187,37,245,77,216,177,42,191,139,143,0,89,90,77,150,221,71,215,37,124,238,117,93,151,100,201,94,201,209,117,117,81,93,194,32,242,43,0,108,247,9,195,255,158,66,127,14,181,103,17,111,183,235,107,218,224,50,90,176,146,57,8,57,185,166,16,55,196,226,5,82,48,29,82,12,112,8,93,182,167,209,251,214,90,177,131,231,204,141,144,139,167,73,113,3,114,237,27,134,67,242,163,50,46,61,134,35,162,194,66,214,81,144,241,79,67,33,18,173,34,184,202,78,150,215,148,26,18,152,210,83,145,168,59,170,52,217,57,201,129,168,89,21,167,120,245,239,45,201,105,73,199,145,188,241,163,170,46,213,67,129,87,152,240,1,96,93,218,7,187,244,132,120,97,226,199,176,142,210,63,60,237,56,22,188,10,5,197,50,56,232,215,207,37,38,11,48,246,186,164,210,136,46,136,116,246,134,130,66,79,71,152,202,55,180,189,171,189,192,84,113,243,190,134,0,231,236,11,93,109,91,138,190,0,52,58,81,116,71,21,205,86,119,36,233,51,235,196,182,226,59,224,124,215,165,104,46,94,82,12,114,1,109,254,7,98,53,218,162,195,23,205,137,3,38,133,25,165,179,152,232,254,167,104,223,0,103,57,64,180,207,221,249,213,32,148,43,15,98,122,246,121,155,149,44,153,30,173,86,245,182,106,167,51,35,97,122,150,163,60,151,175,173,72,228,188,40,91,120,146,115,206,92,233,194,185,92,35,143,193,194,146,201,236,243,172,66,70,230,201,212,246,255,255,124,97,79,174,68,69,11,50,11,175,206,38,203,35,161,37,36,97,10,4,160,253,150,62,120,0,92,84,31,45,113,113,4,192,27,237,240,74,33,122,159,53,232,57,1,19,249,250,80,0,71,247,191,180,218,59,212,152,73,20,211,101,213,214,201,84,207,50,213,47,32,200,74,166,48,160,133,68,112,137,81,209,244,114,123,253,127,84,255,216,49,158,84,239,68,22,225,244,56,201,184,98,96,139,0,124,85,172,233,84,70,101,147,137,67,244,171,221,134,138,193,64,208,21,101,12,99,22,36,61,227,0,65,127,104,35,129,203,136,223,160,120,222,212,107,71,240,36,101,165,234,156,94,115,169,79,108,242,56,49,156,34,55,247,189,39,89,5,57,11,69,233,122,15,33,134,36,21,205,197,42,19,77,33,99,161,149,186,201,220,11,19,41,197,149,64,242,80,115,210,44,48,173,205,11,97,55,68,144,214,211,87,10,210,175,68,49,2,232,160,167,79,53,115,200,227,92,119,60,2,96,247,64,108,2,73,2,37,82,196,246,181,168,176,29,59,202,1,192,135,170,104,229,252,151,86,83,87,74,196,64,84,166,223,217,35,211,115,218,174,238,144,252,167,199,137,89,208,156,220,128,42,83,163,68,210,198,243,86,219,168,35,38,77,113,123,215,178,215,244,158,150,128,72,71,87,79,143,47,129,133,13,16,254,172,186,45,42,138,202,107,139,155,200,46,223,35,8,14,33,113,176,91,230,146,30,134,49,54,221,180,28,203,229,73,44,45,132,210,191,102,12,163,188,36,60,27,75,185,176,100,121,80,154,184,242,6,172,135,163,190,90,118,44,71,116,233,137,17,231,216,246,90,105,182,96,87,143,58,99,13,111,187,174,146,169,209,18,174,36,1,5,79,63,222,209,134,218,47,230,36,164,152,179,116,201,184,137,78,166,140,43,96,172,159,4,123,84,229,29,160,198,134,4,97,41,165,235,133,97,76,79,16,70,239,88,68,80,89,164,224,232,142,213,154,25,109,89,103,69,165,137,47,25,56,27,203,4,241,39,61,2,115,214,20,236,19,100,90,54,71,164,193,130,215,26,21,151,51,179,20,168,12,255,159,125,1,131,8,174,67,137,129,133,158,21,43,90,249,158,94,60,36,119,162,175,89,70,42,77,35,10,47,109,146,134,255,193,168,74,42,172,3,85,132,3,38,225,23,189,149,247,178,74,137,224,169,18,253,83,190,127,148,127,117,188,226,130,46,42,11,251,153,29,121,6,114,160,223,255,158,252,110,192,60,91,70,57,172,81,198,177,131,189,130,236,76,6,139,86,56,170,205,3,76,169,40,247,168,237,159,181,220,19,12,68,200,194,138,133,79,121,140,14,252,2,235,11,194,21,42,151,176,36,140,151,53,79,199,142,24,143,227,112,97,137,53,120,193,63,34,57,98,89,139,149,246,9,135,242,45,154,78,33,138,60,92,60,192,234,217,34,113,212,206,72,20,229,212,28,30,29,26,133,203,137,142,147,129,41,4,92,208,203,30,203,186,113,196,208,212,150,41,176,160,136,234,167,231,71,108,208,111,178,42,187,21,96,151,45,93,31,239,62,44,243,196,155,222,2,154,99,92,43,172,244,224,178,226,54,196,98,59,70,214,167,200,218,24,56,124,137,177,18,0,60,242,135,41,168,75,45,12,87,244,75,123,94,55,144,151,144,214,60,30,138,45,4,177,7,179,195,57,14,66,18,105,6,47,18,19,51,90,245,197,163,230,22,82,158,10,194,192,78,77,113,222,33,243,204,90,46,208,178,196,5,26,124,16,129,43,108,77,70,70,59,83,163,30,48,149,96,109,138,191,30,29,203,130,179,93,215,249,206,155,236,24,26,159,63,151,10,169,166,103,82,39,224,189,82,143,238,75,57,220,232,129,233,192,25,55,183,100,201,95,132,109,112,17,109,163,235,157,162,148,142,87,180,169,162,45,164,219,150,4,177,196,235,99,34,240,49,98,103,197,235,30,164,83,202,86,77,177,145,117,92,206,232,110,151,119,245,102,187,185,82,34,16,234,113,98,25,40,109,172,188,117,57,218,4,61,145,207,145,78,28,146,98,140,215,71,230,12,208,197,218,48,232,208,80,164,24,208,197,51,6,94,223,128,177,26,28,228,7,75,48,74,243,152,235,27,243,58,89,10,235,67,180,34,26,0,101,68,171,219,207,2,34,205,14,48,190,211,152,4,236,83,39,46,86,240,66,193,174,18,157,16,100,253,46,52,133,229,179,242,108,183,172,222,128,44,220,97,65,65,14,74,177,192,38,155,53,164,244,170,134,206,233,127,209,172,153,135,160,166,188,187,99,194,209,60,132,122,2,120,112,225,214,212,47,237,31,63,199,198,4,237,186,36,46,55,57,18,211,39,162,140,6,98,231,146,189,11,255,192,144,230,109,253,0,232,118,58,96,20,134,179,176,228,167,153,139,63,190,141,38,42,163,66,151,177,185,74,165,192,152,177,24,146,218,209,169,240,226,22,139,2,99,196,94,44,151,214,94,196,68,122,223,23,87,197,128,119,227,96,12,129,35,200,139,232,182,39,14,154,245,70,186,160,237,16,235,70,96,207,98,113,247,24,55,224,134,165,78,74,110,205,238,229,228,142,65,71,222,43,102,116,234,81,147,137,45,43,50,11,26,199,145,177,226,210,102,205,173,155,215,11,166,95,121,237,189,76,238,102,201,129,68,173,75,65,55,83,59,223,86,171,244,77,246,197,78,10,249,113,21,154,95,64,44,23,205,164,227,201,219,64,174,172,179,80,153,35,10,223,164,146,119,65,150,216,88,39,209,181,240,13,100,217,3,208,173,33,17,160,126,145,111,52,240,192,208,216,36,129,220,126,8,184,25,98,203,192,87,11,128,5,186,175,114,194,249,45,187,118,248,109,81,213,8,14,44,7,56,40,86,100,242,119,155,10,253,172,238,146,227,29,110,216,131,198,54,201,147,194,135,89,100,74,93,92,237,153,200,87,209,244,3,66,52,133,65,117,208,67,46,22,143,121,36,198,218,8,158,120,51,199,89,110,175,81,0,158,57,185,184,244,142,2,238,126,208,86,133,252,154,88,129,229,210,156,0,132,247,181,43,231,210,50,70,106,230,190,96,124,44,218,187,191,22,85,203,120,222,241,190,126,120,93,175,62,97,131,174,250,132,11,110,166,166,29,167,131,234,99,32,5,234,99,35,88,105,232,73,50,38,87,24,172,151,11,114,4,107,155,198,13,88,187,68,99,205,125,193,252,77,28,208,214,101,160,185,215,222,203,249,248,65,63,243,18,32,5,39,120,73,166,126,235,20,34,36,93,83,119,160,174,56,217,122,128,241,132,14,135,31,23,77,123,199,127,237,127,107,143,214,217,149,51,114,217,191,151,35,173,217,165,85,245,158,94,60,84,82,48,208,120,249,197,86,61,42,136,143,99,16,187,149,205,97,43,193,231,180,148,189,3,135,251,221,147,45,107,235,53,62,226,90,146,233,77,245,203,73,198,90,30,236,214,34,175,1,9,15,57,132,142,0,204,37,239,102,90,81,38,246,252,186,52,51,180,24,140,244,196,153,55,36,51,15,230,103,51,69,62,147,29,15,129,121,162,137,230,240,227,117,245,248,60,63,202,177,222,246,89,175,88,104,137,48,150,99,104,34,99,135,196,192,224,118,92,226,201,242,179,119,98,181,91,151,190,100,64,94,69,129,177,179,152,152,168,240,149,244,148,218,30,39,194,181,56,91,209,242,132,67,116,43,58,86,130,254,10,159,233,243,236,219,184,203,80,250,238,9,189,218,203,84,125,86,162,131,254,109,37,235,31,218,21,36,165,102,129,146,185,76,176,90,243,24,96,139,158,203,170,147,144,77,189,77,195,32,108,103,81,248,246,191,235,10,64,22,37,63,221,141,197,37,32,123,139,130,8,163,186,167,2,187,11,8,122,56,199,118,135,45,247,179,210,155,39,120,59,65,142,151,99,107,218,242,248,220,49,47,64,90,231,41,4,152,159,191,18,140,114,146,110,113,194,95,90,116,95,61,184,224,49,36,228,163,35,49,67,112,160,127,148,196,193,57,4,170,39,198,233,61,115,18,60,138,33,245,246,111,117,81,37,248,31,90,240,116,9,4,111,230,193,24,68,133,229,23,149,65,185,171,230,161,113,6,154,217,4,177,227,236,200,16,243,51,146,95,72,116,140,73,233,12,145,142,236,28,128,231,220,76,159,102,59,99,111,130,150,38,76,215,184,1,253,138,61,242,111,38,38,255,143,195,74,44,241,158,22,55,55,130,76,226,127,17,88,158,58,111,206,190,108,192,232,50,140,163,98,30,207,7,250,150,126,105,177,112,248,28,176,115,242,147,91,117,189,184,249,72,233,39,23,164,211,56,26,85,33,11,78,182,29,9,112,197,126,57,184,212,109,89,38,118,206,171,21,109,67,171,227,18,50,179,120,203,222,30,192,94,125,34,133,123,188,183,96,88,197,243,206,172,66,155,244,41,164,110,72,5,132,36,59,160,164,7,60,196,63,196,244,152,182,15,148,6,98,45,239,232,249,140,47,36,20,252,169,201,154,36,204,208,111,60,207,73,89,51,218,33,217,141,96,51,76,241,41,23,247,166,20,229,59,146,0,184,248,72,176,36,129,68,121,134,72,164,151,91,117,120,127,98,26,223,160,239,54,63,175,182,212,254,249,145,230,206,219,187,173,253,243,188,41,236,159,151,89,219,179,18,36,98,143,100,128,76,172,235,10,183,20,126,32,66,74,60,129,248,79,2,241,8,202,255,104,17,136,68,115,30,228,31,64,195,70,241,250,107,0,6,72,17,230,94,12,186,195,172,103,81,184,221,82,54,64,226,246,161,254,78,36,126,241,173,73,252,226,123,144,24,20,160,15,172,221,52,210,53,43,115,207,67,113,149,138,247,250,1,219,183,217,167,236,28,119,55,231,103,206,179,92,28,15,204,74,164,34,177,206,144,35,116,8,7,220,89,115,209,136,179,98,127,153,149,0,173,228,5,177,67,34,214,121,234,246,83,197,4,39,194,79,102,115,7,59,133,150,139,146,164,82,152,8,55,202,133,113,248,170,79,98,112,240,134,44,43,24,112,159,149,184,93,40,141,217,192,154,100,175,240,10,196,59,151,147,2,169,16,39,33,120,111,139,21,9,82,182,75,177,37,127,45,4,205,176,86,230,80,5,100,108,156,23,115,242,213,188,102,238,46,47,159,93,202,128,166,166,108,74,58,35,197,137,137,64,180,18,145,9,151,59,253,124,225,123,177,130,172,161,178,146,47,48,179,185,141,125,7,169,126,89,245,214,105,4,34,42,13,193,98,87,0,43,87,38,6,112,137,169,61,24,152,54,160,246,177,88,109,72,12,108,213,246,65,251,202,132,125,44,101,242,134,104,166,125,20,193,133,173,42,62,89,39,33,37,29,82,83,75,28,198,11,132,234,223,167,179,19,221,109,36,84,169,234,252,207,88,133,231,155,29,75,60,186,173,72,223,189,61,56,254,42,160,169,223,200,155,45,50,152,190,104,186,37,42,156,176,51,143,123,100,82,119,144,144,146,248,81,105,177,19,225,109,208,240,91,190,130,72,88,75,182,44,9,101,159,229,162,236,2,132,216,187,24,46,114,232,75,9,124,231,70,45,8,198,241,243,227,252,144,55,210,140,239,154,75,254,45,111,171,186,1,9,98,155,50,19,4,196,30,120,192,94,172,88,44,28,208,194,179,2,71,101,41,230,19,124,214,116,193,215,50,205,229,71,10,240,183,216,43,20,173,184,133,100,197,196,162,241,164,94,111,178,166,96,162,28,44,50,215,192,102,161,186,91,241,196,154,243,183,71,172,179,235,171,143,212,125,248,78,211,89,55,82,186,245,79,239,128,52,78,164,175,17,152,143,93,116,55,83,210,171,250,168,105,178,157,226,219,147,14,48,199,206,86,216,231,123,71,220,9,27,190,59,43,183,236,152,188,223,94,112,251,159,93,103,44,118,83,208,187,39,206,7,78,23,226,172,77,91,19,42,32,58,247,194,205,229,187,251,162,193,109,84,231,106,154,218,47,92,158,30,227,231,55,178,42,23,216,40,106,124,182,79,218,116,13,64,16,112,208,172,144,95,201,200,81,218,214,216,150,208,187,145,47,202,17,225,119,1,27,136,183,30,43,48,130,157,250,180,109,236,180,136,72,87,40,46,20,242,234,17,48,70,194,113,14,185,135,103,79,175,154,157,190,210,110,128,204,73,189,109,123,63,62,64,54,208,104,29,241,81,161,159,186,163,150,224,123,188,168,54,231,61,83,14,168,239,26,90,151,206,79,254,24,66,15,133,37,150,210,179,69,206,233,142,241,84,125,23,61,223,115,232,76,109,161,62,128,81,33,89,89,74,71,42,190,144,162,74,55,226,240,104,248,107,10,98,252,116,33,11,147,226,195,42,252,235,3,225,91,187,254,103,21,60,157,83,76,81,186,183,81,215,52,109,156,100,61,119,60,52,228,238,116,97,23,21,197,178,236,15,131,60,1,26,39,254,116,129,87,150,53,126,57,90,100,88,39,88,157,22,172,176,190,59,46,174,128,162,187,245,38,16,76,102,139,55,117,14,142,136,95,226,29,205,143,131,61,53,58,108,209,140,148,234,239,213,72,46,117,46,165,118,138,202,227,47,206,162,152,69,37,12,116,140,11,239,103,151,137,96,73,157,22,140,192,74,60,70,24,36,250,167,97,166,245,203,192,253,183,225,19,253,146,173,55,37,93,120,134,195,186,120,56,197,224,188,88,21,155,12,107,230,7,123,106,204,16,119,212,101,86,23,176,52,149,159,208,38,201,103,190,22,101,30,180,149,52,174,32,61,170,132,37,195,211,154,202,162,161,121,6,32,120,71,200,152,54,108,20,208,122,172,182,7,29,130,17,100,104,159,124,36,28,95,9,218,54,66,195,78,125,232,131,12,34,96,224,74,81,151,121,231,75,77,1,2,255,207,197,53,171,121,140,49,21,147,96,145,58,167,144,169,173,240,252,217,220,249,4,150,253,1,21,59,40,60,41,105,86,209,230,111,245,53,89,111,89,75,174,41,23,189,124,91,210,60,157,206,254,151,115,82,92,128,183,98,245,139,50,15,156,164,138,92,204,127,214,39,92,156,72,151,65,30,90,8,16,176,182,181,249,80,75,224,91,3,118,146,110,159,238,74,196,10,102,241,67,94,145,11,147,114,235,225,41,117,6,83,255,9,30,103,116,14,112,217,39,75,230,36,156,85,206,176,58,248,138,135,202,77,108,203,46,68,138,248,213,200,240,161,195,80,137,94,6,22,67,9,134,253,27,207,30,63,227,156,162,131,232,146,225,73,237,222,131,138,141,86,73,139,235,103,172,146,140,39,163,57,127,118,249,214,70,243,187,241,191,59,143,123,118,244,187,10,65,96,234,167,81,184,231,196,96,248,29,48,98,56,104,179,76,160,149,185,217,161,129,248,156,78,36,84,83,153,230,116,209,249,40,26,180,13,125,238,202,179,113,242,206,247,80,61,226,217,167,155,34,213,15,51,145,116,89,206,151,37,108,179,70,190,243,121,213,17,103,192,141,140,88,217,190,2,195,5,238,137,7,126,187,7,84,123,229,237,113,72,172,204,71,95,64,176,112,189,93,225,18,33,14,126,138,7,98,73,177,59,207,194,50,86,243,11,201,154,146,230,166,242,116,193,191,10,101,125,120,177,176,63,21,193,200,195,29,173,84,116,247,0,203,195,47,66,61,69,42,213,34,186,215,72,18,126,254,33,138,151,45,167,209,78,252,130,245,24,41,214,72,84,213,78,154,109,113,69,219,59,190,229,212,2,253,27,221,135,113,140,247,117,253,208,78,198,71,161,55,160,100,61,135,193,109,116,187,31,222,25,52,91,207,148,175,167,179,92,173,43,218,129,155,234,158,240,212,255,254,40,111,193,127,255,2,188,142,173,66,74,86,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("627718f7-94a8-40e7-9791-08a084a92574"));
		}

		#endregion

	}

	#endregion

}


﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SynchronizationErrorHelperSchema

	/// <exclude/>
	public class SynchronizationErrorHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SynchronizationErrorHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SynchronizationErrorHelperSchema(SynchronizationErrorHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd2838b1-4a6c-439b-aee9-57d6006ebc8a");
			Name = "SynchronizationErrorHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,28,107,115,219,54,242,179,51,211,255,128,170,51,45,53,149,153,244,146,118,174,73,172,140,159,141,123,177,147,70,201,229,67,39,115,67,83,176,141,134,34,21,2,180,173,38,254,239,183,139,7,9,128,160,68,57,207,15,109,103,154,136,4,22,187,139,125,239,178,121,50,163,124,158,164,148,188,160,101,153,240,226,84,196,187,69,126,202,206,170,50,17,172,200,191,185,245,238,155,91,27,21,103,249,25,153,44,184,160,179,7,222,111,88,159,101,52,197,197,60,254,141,230,180,100,105,107,205,19,150,191,109,30,30,230,130,158,41,248,219,115,22,227,207,242,20,144,224,205,146,99,122,41,0,32,226,243,59,47,242,206,23,30,100,155,138,217,204,222,231,191,241,192,218,175,75,218,245,60,222,207,5,19,204,70,212,91,112,144,164,162,40,59,86,28,37,44,11,62,167,156,39,103,240,108,9,214,175,232,73,252,88,136,121,188,125,194,69,153,40,126,195,66,88,250,93,73,207,224,23,217,205,18,206,239,3,203,243,244,188,44,114,246,183,228,240,126,89,22,229,99,154,205,105,41,87,255,185,71,79,147,42,19,59,44,159,194,17,145,88,204,105,113,26,29,118,111,27,14,95,195,190,121,117,146,177,148,164,120,200,146,51,238,147,37,144,0,204,59,137,196,198,109,248,231,197,211,189,167,228,187,231,199,123,155,63,253,122,231,215,127,235,199,228,33,175,102,179,164,92,140,205,131,231,138,188,19,154,21,151,132,113,242,6,48,79,8,136,213,188,40,97,29,185,44,202,55,73,89,84,249,52,54,91,38,197,140,146,20,56,36,146,92,112,114,73,75,252,57,103,116,74,78,203,98,70,246,175,210,243,36,63,163,4,100,255,77,2,127,78,43,74,68,81,255,44,233,41,108,73,115,202,21,148,50,97,8,39,218,73,120,179,135,23,85,54,37,121,33,212,114,2,56,166,231,12,30,233,5,124,88,227,243,44,163,184,19,214,73,249,32,76,212,212,222,182,201,117,174,146,194,101,62,43,217,69,34,168,98,218,92,253,208,119,96,104,216,69,4,57,190,215,188,109,115,81,62,121,1,23,77,138,83,50,47,139,11,54,5,124,55,107,16,113,179,205,65,199,92,58,176,81,192,31,37,77,166,69,158,45,200,111,21,155,214,155,81,170,39,180,188,160,37,158,112,56,37,91,36,167,151,114,77,52,184,123,239,215,59,59,123,247,126,222,188,119,112,111,111,243,222,47,63,221,221,220,222,190,243,203,230,189,159,225,223,95,14,238,222,189,247,175,237,193,240,193,82,196,143,40,21,168,12,73,62,37,34,225,111,56,225,32,97,72,7,152,12,78,114,176,97,235,18,0,55,138,16,183,65,141,46,152,88,160,196,62,83,224,142,1,26,80,48,192,71,134,66,189,12,180,90,47,26,44,71,24,110,68,192,61,127,60,60,53,192,21,104,154,99,45,36,55,54,174,93,209,209,7,184,18,244,82,176,12,184,176,90,132,190,196,77,184,98,30,119,44,252,90,46,196,195,54,188,206,190,152,239,104,62,85,74,175,127,107,11,112,192,104,54,245,13,64,208,60,62,228,20,76,2,152,150,173,129,116,79,139,73,122,78,103,201,81,146,131,13,42,7,183,199,132,73,59,152,210,56,108,116,140,108,4,118,147,255,113,251,231,131,37,104,120,86,159,80,52,251,4,152,49,205,0,78,154,0,156,134,227,221,72,248,156,254,159,132,243,88,129,225,187,8,198,150,125,235,68,179,198,40,103,23,103,229,213,148,21,218,97,228,175,188,231,37,116,89,203,99,50,161,32,68,202,57,0,63,209,99,88,220,247,66,129,151,156,150,176,57,87,177,81,143,123,144,79,230,73,153,204,36,163,182,6,149,11,97,124,163,179,30,222,150,32,21,147,149,80,119,59,232,200,5,68,92,12,134,228,157,212,13,111,209,150,183,76,138,247,134,43,57,173,69,113,64,218,250,232,5,168,17,224,137,182,24,117,163,16,0,141,78,251,105,199,218,23,50,55,240,137,71,177,247,243,29,57,163,226,1,225,248,159,21,232,31,81,113,94,244,211,235,253,43,154,86,2,34,16,75,147,80,35,78,225,7,159,211,148,157,194,85,206,192,249,158,20,87,125,37,202,86,38,71,158,212,109,116,10,78,11,144,62,247,131,96,112,224,17,45,247,17,212,246,20,184,5,46,107,60,49,132,169,151,132,226,91,146,168,215,203,193,177,179,28,84,225,40,185,122,78,69,185,216,133,120,80,12,198,135,242,33,105,30,145,98,46,197,207,81,11,109,123,46,10,8,107,14,88,73,247,45,54,69,138,44,98,179,110,164,109,165,97,255,200,88,171,54,73,35,114,82,20,25,9,32,103,180,9,34,75,128,99,189,0,93,177,15,131,164,74,96,100,53,133,68,171,154,229,255,77,178,138,62,132,77,227,104,96,81,58,84,90,135,81,215,35,146,86,37,24,40,33,201,216,45,166,42,40,51,162,2,224,44,72,209,192,90,53,24,146,132,203,200,237,81,0,220,171,164,204,129,200,149,0,157,117,65,144,138,190,26,208,74,106,113,207,216,195,84,65,99,167,36,138,218,228,198,143,19,46,183,146,239,191,15,112,35,150,239,226,253,183,85,146,241,200,66,102,56,36,239,223,75,192,27,27,81,136,236,16,96,119,65,55,104,115,225,27,37,21,85,169,205,228,117,45,3,137,192,148,70,28,87,179,19,105,47,45,246,174,188,126,208,102,75,0,64,12,49,28,247,47,169,139,173,77,0,223,240,213,2,83,71,245,0,194,142,243,35,115,138,117,21,223,6,228,28,57,229,202,247,152,108,254,132,79,93,138,31,186,171,106,110,189,156,79,65,57,109,90,163,90,237,126,252,209,129,161,49,9,48,248,34,1,163,41,138,57,112,0,40,57,133,187,161,13,214,97,236,162,16,45,239,223,123,88,143,183,60,180,21,6,176,255,219,149,98,141,150,1,248,127,92,136,9,160,134,94,25,196,104,208,200,73,131,48,4,32,26,223,13,179,84,199,147,81,200,228,216,23,55,244,217,32,209,82,37,7,170,111,21,147,8,235,233,206,2,69,214,17,222,134,89,246,246,71,65,178,148,45,4,194,112,47,232,255,22,196,106,123,128,222,98,66,101,201,225,143,170,16,9,4,202,148,78,41,218,135,110,173,184,241,113,79,24,102,69,84,154,250,230,4,205,50,124,137,80,141,24,181,56,196,184,86,233,62,182,169,62,190,62,80,38,239,131,161,10,254,193,21,214,22,209,66,73,29,249,170,100,130,214,118,169,17,107,139,243,35,35,182,163,6,173,97,40,179,147,206,107,55,163,73,254,114,30,10,240,162,149,46,202,162,90,42,136,225,27,178,68,163,166,228,229,72,253,128,83,32,30,198,132,80,121,195,128,40,14,109,37,211,16,182,72,94,101,217,146,107,199,243,82,227,27,106,172,212,234,71,125,12,154,231,128,212,206,251,125,118,118,120,24,141,205,183,91,210,145,197,251,160,254,139,154,128,174,75,68,42,173,75,187,239,223,159,162,182,127,188,184,58,214,253,13,179,19,43,32,59,60,226,103,187,16,55,230,52,179,163,50,25,65,170,208,9,150,153,96,108,193,183,167,51,150,191,204,153,0,226,111,143,251,134,148,222,70,59,32,156,88,175,28,4,170,156,189,5,23,202,166,224,61,33,218,3,205,106,69,118,74,44,248,120,53,57,176,215,44,118,131,246,11,86,10,240,194,196,218,39,165,87,25,19,253,36,82,158,206,33,194,92,173,2,75,154,237,58,79,137,15,205,209,7,44,159,30,130,59,216,89,188,68,135,232,66,177,181,180,163,176,41,209,38,14,203,92,83,236,222,27,203,192,251,1,101,39,139,214,253,213,38,3,175,238,239,117,210,1,185,105,188,4,135,88,131,5,165,68,133,33,23,50,194,233,115,99,203,168,233,188,54,29,90,119,251,37,63,130,52,215,101,103,148,178,210,99,239,213,143,183,188,138,6,26,3,115,155,59,11,172,44,68,109,172,181,190,106,196,124,200,0,51,124,88,188,91,82,176,204,218,56,186,57,163,101,92,252,205,241,1,21,233,249,65,89,204,246,118,34,199,19,40,171,236,89,206,214,225,182,41,213,75,208,20,173,148,70,133,45,39,127,113,176,59,51,77,219,37,19,231,58,1,101,249,105,209,215,40,132,210,195,198,107,164,218,109,240,229,185,162,17,15,236,212,232,4,107,165,174,107,39,7,183,106,179,36,114,211,53,195,65,149,221,184,185,200,77,179,36,179,209,1,2,73,62,242,200,2,164,54,252,254,244,228,47,192,187,230,178,170,152,235,167,145,150,13,253,242,79,195,56,56,248,117,3,27,50,141,23,197,68,82,27,249,209,153,151,170,212,2,211,45,192,189,130,64,149,218,152,24,59,36,186,232,33,29,231,190,161,239,3,107,63,47,232,149,8,232,202,242,160,10,181,198,83,67,139,51,246,219,215,186,196,132,199,232,133,215,109,77,144,61,195,131,162,156,37,2,255,170,25,40,159,66,110,195,146,140,253,13,46,92,129,28,142,136,90,137,178,10,54,31,189,21,237,103,214,75,70,47,168,103,216,61,95,88,251,62,78,50,198,197,23,209,172,117,240,91,233,101,247,243,106,70,203,228,36,211,209,148,21,41,62,189,204,1,78,135,22,234,155,209,165,114,213,139,96,20,123,201,2,239,151,239,44,100,68,201,61,11,58,146,58,243,4,80,51,210,98,132,110,89,156,87,11,214,164,93,124,82,129,226,245,16,36,1,27,218,209,155,139,57,217,26,19,248,35,254,15,93,172,190,119,4,105,170,117,121,129,204,75,85,41,92,20,82,50,249,231,186,227,246,229,200,228,0,241,147,154,119,108,33,215,113,41,90,111,103,182,133,112,44,170,155,59,201,0,95,235,243,33,63,6,19,240,180,148,81,114,180,172,234,1,113,40,77,210,115,162,99,176,234,132,167,37,59,145,133,11,150,183,197,199,28,89,67,180,3,187,84,255,185,21,8,241,108,200,182,249,170,247,248,86,43,5,89,100,121,157,114,43,108,85,13,129,205,230,25,61,114,236,246,196,126,102,140,241,134,179,50,222,41,166,11,52,222,182,139,246,150,72,207,161,81,130,31,193,53,143,105,2,82,27,43,225,13,244,64,228,21,13,244,86,3,235,89,193,13,71,34,7,92,32,15,89,26,167,186,45,29,204,34,138,84,214,192,32,28,51,169,109,239,74,180,147,45,99,224,229,214,146,235,84,25,227,78,217,173,148,205,163,165,21,224,26,166,241,9,157,16,141,172,246,177,140,237,178,54,118,209,67,81,174,41,172,195,82,170,180,10,135,43,86,90,206,38,224,117,234,206,90,5,219,140,170,171,205,62,189,110,32,220,204,229,152,43,227,158,167,55,29,51,35,179,178,58,228,193,124,82,92,74,73,243,159,67,244,33,95,217,123,77,126,242,184,57,206,156,172,36,50,126,117,14,239,163,115,52,171,70,215,112,163,94,229,86,80,112,247,122,21,151,7,22,72,198,15,64,165,247,91,204,179,73,169,31,90,165,154,184,1,131,38,162,11,76,99,43,92,174,25,204,3,103,76,230,224,216,162,31,226,31,134,241,147,132,215,97,94,227,1,221,61,166,132,28,228,205,136,168,200,101,183,152,129,0,51,12,95,118,85,49,122,183,202,0,24,85,125,143,221,132,215,241,218,198,53,161,144,62,52,120,235,83,131,240,209,136,23,194,177,227,102,27,150,54,3,212,237,131,239,123,5,201,66,111,124,15,115,96,28,75,150,98,172,205,175,45,158,150,220,106,189,217,106,201,157,22,182,3,86,114,241,180,212,243,78,90,234,136,172,102,41,25,62,144,251,86,203,217,145,189,124,48,244,69,191,102,165,3,54,192,66,98,179,206,214,175,70,254,28,16,6,254,181,31,224,123,12,240,220,215,26,60,10,51,105,77,118,248,14,63,144,128,182,81,234,93,28,49,117,67,238,205,23,112,21,5,73,55,36,206,105,211,18,13,118,14,251,22,179,66,45,201,94,157,200,128,227,232,152,29,140,87,58,148,142,88,239,102,62,165,179,88,219,85,14,14,150,83,168,253,163,79,17,37,68,131,91,71,105,74,202,54,240,30,69,19,163,109,58,204,183,203,37,161,176,126,20,44,121,235,10,119,93,79,38,247,251,85,73,140,88,250,226,232,198,70,39,186,95,44,235,216,107,53,231,117,137,161,105,132,55,112,214,173,151,126,121,249,179,66,144,112,220,17,16,181,63,42,90,2,247,248,91,29,93,183,222,69,174,240,141,72,59,0,211,130,2,64,98,57,49,132,37,90,237,252,59,230,137,154,13,32,33,202,234,117,197,23,222,34,207,26,6,215,180,251,244,254,73,117,33,54,252,222,111,17,218,138,20,142,243,16,0,70,148,222,146,165,26,101,182,127,236,194,117,239,188,87,109,109,117,17,150,148,196,215,84,137,143,92,144,86,137,107,141,246,199,177,156,43,202,207,159,194,108,90,20,172,109,16,101,251,171,203,30,74,179,133,211,162,105,1,209,41,159,23,178,1,92,151,21,68,33,93,119,95,211,243,33,245,147,79,99,12,87,228,163,182,65,223,111,252,193,234,77,117,2,171,118,133,210,213,142,34,143,215,141,244,231,148,90,37,111,221,252,245,174,111,226,142,74,172,234,16,27,153,2,185,147,69,196,231,236,236,92,112,119,208,194,116,117,213,244,204,150,83,118,119,26,171,196,45,201,91,98,88,195,80,102,81,91,244,6,171,71,196,107,253,194,102,167,112,255,192,193,118,226,150,248,93,192,163,6,217,225,210,109,238,20,206,136,220,89,177,124,18,228,52,70,41,193,23,62,180,228,162,46,49,97,172,211,130,150,136,138,187,197,185,101,202,171,102,107,184,212,194,84,145,128,226,95,34,73,45,149,214,131,47,31,84,198,252,18,106,168,9,27,140,143,33,156,48,84,182,155,152,29,10,21,24,63,242,149,10,167,183,52,220,117,52,162,167,64,25,200,157,130,208,55,139,210,99,65,50,128,179,28,103,40,131,194,117,253,115,38,61,58,54,62,178,14,89,219,49,203,239,196,208,10,172,213,219,151,14,216,31,76,115,102,224,194,221,225,245,18,25,5,221,239,3,43,66,183,52,176,190,221,94,197,91,219,251,26,76,59,27,188,106,203,146,177,21,69,183,193,207,45,244,104,32,141,125,237,89,244,69,251,211,118,235,230,219,137,165,89,247,167,207,182,219,242,167,89,224,200,160,39,232,189,122,36,254,116,93,247,208,84,107,68,210,158,151,146,7,81,161,98,113,76,99,246,152,148,4,224,133,46,164,140,72,33,219,189,77,37,116,227,29,233,155,191,146,235,145,181,73,151,254,80,230,14,209,147,184,194,23,91,175,177,201,112,109,170,107,141,79,69,9,158,86,153,148,102,153,235,168,207,24,23,40,115,15,15,15,103,137,228,201,239,197,201,196,44,28,27,39,84,111,141,159,211,89,113,65,245,194,86,179,174,97,72,75,25,204,128,105,235,235,153,174,47,204,106,5,145,184,123,152,5,73,232,68,127,195,223,190,130,140,144,32,120,159,81,117,125,162,244,9,79,12,127,102,212,183,189,163,183,144,140,165,52,7,195,129,31,88,88,65,252,23,238,90,250,67,155,225,126,101,151,47,221,207,177,33,45,5,104,145,91,134,108,96,140,109,163,4,51,229,3,180,220,4,197,8,187,205,248,133,243,145,179,116,108,247,64,50,119,137,28,216,176,23,203,164,92,95,159,7,46,236,52,60,128,49,90,40,179,209,4,122,129,65,19,39,52,88,61,93,184,234,43,168,64,198,223,241,197,120,220,253,117,209,87,241,13,148,19,129,60,215,243,81,96,160,63,30,101,94,204,226,124,72,216,13,130,88,177,71,191,207,176,172,47,211,182,203,179,106,70,241,35,2,243,23,229,117,2,75,34,159,165,35,31,188,83,46,104,41,65,55,5,227,200,156,254,97,179,18,166,0,81,200,182,255,103,51,63,234,158,234,73,137,112,102,21,182,62,225,201,138,222,89,152,54,113,93,85,148,15,10,167,110,254,61,149,28,212,186,210,61,243,241,118,78,186,154,233,245,16,192,180,82,193,146,75,196,39,251,106,75,95,88,192,89,172,59,255,94,147,67,108,162,187,63,221,242,235,31,225,37,29,223,143,224,255,197,1,29,54,189,18,38,52,51,115,115,182,51,250,124,243,246,129,15,220,172,129,159,122,28,193,226,140,201,69,162,161,53,132,56,114,152,23,187,51,38,126,235,178,133,150,234,217,239,95,129,103,51,67,130,6,210,94,34,18,171,67,127,8,134,170,108,119,228,235,190,189,106,219,75,72,67,103,202,128,169,141,246,40,64,235,156,63,59,193,191,54,205,222,21,124,242,79,233,203,33,103,90,177,197,46,127,176,178,245,149,162,251,121,98,243,93,98,64,218,67,223,34,174,23,42,126,101,150,42,52,75,212,168,180,156,30,186,201,240,80,3,162,115,92,232,171,179,100,221,67,67,58,249,8,79,14,253,99,234,28,93,10,140,92,181,102,173,58,236,218,87,162,168,248,33,88,217,213,149,193,73,126,156,107,94,99,92,239,195,52,54,36,224,55,250,84,173,14,125,151,109,14,113,178,249,10,203,74,251,110,192,192,75,221,106,248,138,89,168,41,253,164,76,196,239,81,63,193,247,77,255,76,148,118,115,105,201,244,133,18,13,107,140,212,195,250,131,71,73,63,167,193,52,245,234,64,183,253,70,255,159,128,208,56,154,223,216,246,234,35,234,169,251,80,62,187,117,235,255,226,239,148,107,49,79,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd2838b1-4a6c-439b-aee9-57d6006ebc8a"));
		}

		#endregion

	}

	#endregion

}


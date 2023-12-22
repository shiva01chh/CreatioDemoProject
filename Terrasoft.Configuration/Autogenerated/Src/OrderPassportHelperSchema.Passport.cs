﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OrderPassportHelperSchema

	/// <exclude/>
	public class OrderPassportHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OrderPassportHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OrderPassportHelperSchema(OrderPassportHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cb4a7c94-f312-40d9-9d18-9206951b494d");
			Name = "OrderPassportHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,61,109,115,220,54,143,159,183,51,253,15,202,118,174,163,125,186,85,210,185,251,20,199,155,137,95,210,250,218,36,110,236,182,51,151,167,211,81,86,116,172,203,90,218,74,90,167,190,54,255,253,248,78,128,4,245,98,187,189,231,185,187,126,72,215,20,9,130,32,0,130,32,8,238,218,178,122,151,156,221,180,29,187,218,251,244,147,29,248,51,59,172,55,27,182,238,202,186,106,179,175,89,197,154,114,237,87,57,202,187,156,42,227,109,175,174,234,202,255,244,93,89,253,234,151,157,177,245,174,41,187,27,91,126,206,154,38,111,235,139,206,7,2,63,52,44,82,156,29,29,196,190,28,87,93,217,149,172,141,125,127,158,175,187,186,233,169,112,218,212,107,214,186,207,162,240,176,174,46,202,119,187,38,23,116,74,246,253,38,232,51,111,248,233,39,85,126,197,218,109,190,102,168,42,168,149,157,230,109,187,173,155,238,211,79,126,255,244,147,217,103,13,123,39,64,31,110,120,241,227,228,108,183,221,110,110,78,243,155,43,86,117,28,161,98,183,238,78,170,139,90,128,158,109,119,111,55,229,58,217,230,77,87,230,155,100,45,154,244,180,152,9,248,179,109,83,94,231,29,75,10,182,46,175,242,205,211,228,151,138,125,248,126,151,11,106,221,72,148,103,22,9,222,124,203,26,65,196,199,201,169,236,76,125,215,29,127,189,43,11,186,191,34,145,125,205,222,177,110,79,254,104,245,143,143,33,128,87,77,193,154,91,55,28,219,66,15,55,121,145,255,102,6,59,173,225,15,45,43,110,215,82,143,237,188,238,242,205,179,171,122,87,117,183,111,127,119,12,14,242,150,77,131,34,137,125,188,97,98,130,207,111,182,108,210,36,157,84,215,117,185,30,221,198,96,252,210,241,164,107,168,127,205,26,214,237,154,10,49,110,242,244,105,242,72,1,254,24,66,125,91,215,155,228,188,62,98,27,198,57,63,128,119,120,201,214,239,65,143,233,98,15,117,4,145,217,223,79,30,37,159,127,30,99,251,7,251,114,216,217,241,213,86,74,83,47,62,135,13,203,111,131,15,98,69,131,16,68,114,53,68,11,80,249,184,105,234,230,110,52,121,194,49,248,227,15,15,3,32,104,253,184,156,113,13,25,159,235,137,115,3,73,19,118,251,25,171,10,165,218,176,158,123,193,186,203,186,16,74,78,41,71,141,164,214,148,156,129,139,36,196,67,99,88,94,36,41,226,68,142,69,181,219,108,204,247,89,119,217,212,31,18,94,67,200,66,190,41,139,87,111,255,147,175,179,103,29,135,125,252,219,154,109,197,42,144,206,225,64,202,54,169,234,46,41,171,82,40,246,242,191,88,145,205,23,183,25,78,168,179,229,96,206,88,7,135,98,132,238,87,93,96,80,199,195,178,159,247,34,40,232,50,15,43,111,65,83,218,94,47,121,223,176,13,95,95,224,90,166,214,48,178,146,88,190,224,40,41,9,84,18,110,23,72,62,133,117,199,105,205,138,158,197,17,182,153,169,53,114,252,2,231,244,153,85,104,106,138,134,151,184,104,211,129,217,213,132,60,101,205,154,35,148,191,99,194,2,67,115,172,198,234,87,240,198,102,38,93,46,10,174,110,63,114,20,128,195,93,211,8,202,220,1,132,212,150,14,192,33,88,35,71,64,81,235,19,6,161,151,171,187,19,155,91,195,29,103,123,95,55,172,69,121,210,118,141,52,109,33,135,232,158,207,214,151,236,42,127,201,117,27,151,156,57,85,99,190,23,0,146,124,130,91,202,34,162,42,130,120,206,174,182,27,142,219,9,183,176,123,58,134,213,134,64,246,128,33,154,30,177,11,3,156,219,249,92,189,116,188,180,61,172,11,55,6,35,206,166,30,111,66,0,58,109,216,117,89,239,90,77,35,190,39,217,93,85,6,11,239,227,216,230,63,230,155,29,139,192,56,41,8,40,82,215,31,150,205,122,183,201,155,35,182,229,188,193,170,245,205,25,223,46,176,66,238,10,138,93,99,33,118,237,246,151,147,86,208,244,164,122,205,174,89,211,178,111,74,214,228,205,250,242,134,66,81,211,225,85,147,175,55,236,52,95,191,231,236,10,96,189,127,247,139,169,66,205,17,223,144,112,190,20,18,253,45,187,121,94,115,244,46,242,221,166,11,168,91,182,57,23,14,222,130,67,141,212,121,117,113,241,139,182,161,137,158,180,225,134,249,64,23,198,171,107,37,71,182,210,223,230,123,35,68,174,217,137,205,25,189,132,17,171,67,202,215,253,134,55,172,212,6,54,217,161,63,205,122,230,85,218,247,170,197,214,53,136,220,192,142,200,235,193,251,211,179,128,141,125,65,91,194,223,213,107,177,244,243,89,100,103,154,45,243,118,157,23,236,240,134,243,205,11,206,7,78,213,2,123,233,58,111,146,107,193,240,124,120,95,179,46,128,146,206,9,48,115,207,168,146,0,162,86,27,133,89,197,237,21,46,246,122,138,165,2,191,19,138,113,120,119,197,245,71,97,130,113,178,123,235,158,52,131,239,128,242,8,176,247,138,185,218,72,158,110,242,234,94,49,167,193,222,23,230,208,14,66,251,143,123,64,127,8,246,216,49,104,161,148,222,163,27,165,199,146,95,218,112,105,220,3,35,70,149,41,123,81,127,10,134,39,55,15,4,240,96,19,49,163,107,121,26,38,131,136,188,200,43,62,236,38,227,100,59,145,70,204,154,29,220,8,149,156,206,41,20,45,125,62,34,50,69,135,78,82,77,78,130,226,33,165,152,147,95,106,191,8,18,46,172,31,150,208,68,11,192,18,36,35,234,40,235,89,185,254,110,4,105,158,4,29,174,82,221,126,38,246,108,96,53,122,214,188,219,9,34,164,115,188,110,204,151,222,52,44,34,164,164,73,49,202,14,69,235,142,217,212,140,230,88,100,147,238,225,141,81,156,119,81,171,49,188,139,27,12,176,176,87,121,4,39,155,105,33,56,186,223,2,31,195,217,33,137,238,193,115,192,113,236,140,155,67,32,221,190,172,187,31,182,66,91,125,87,86,239,89,161,59,109,83,53,218,132,194,8,250,25,168,239,198,77,29,208,91,15,243,34,223,180,80,207,205,106,233,126,72,26,214,114,155,80,251,226,122,224,102,231,205,205,215,114,37,22,12,120,35,141,233,116,126,84,71,134,194,133,161,222,25,232,154,240,26,147,84,208,97,1,250,253,72,82,203,122,40,166,211,106,169,72,45,85,251,29,233,6,41,54,68,158,179,73,228,81,216,245,16,0,177,139,218,139,0,147,237,159,148,87,130,113,220,43,163,76,162,210,63,22,151,80,132,137,179,72,104,91,145,86,145,222,148,137,195,39,131,177,176,164,84,177,222,150,169,63,50,190,135,188,202,249,154,22,0,105,179,223,31,125,204,36,170,28,165,202,233,81,61,75,98,117,12,123,246,212,248,79,117,243,94,30,127,101,175,89,91,239,184,89,44,118,209,92,155,47,61,183,128,90,16,121,71,14,71,146,0,114,234,148,203,142,82,250,109,42,189,65,181,218,214,194,177,239,164,52,242,113,11,188,149,104,122,200,46,7,28,57,139,236,167,178,187,252,166,20,189,8,32,175,235,15,124,252,239,69,65,186,88,152,213,105,150,241,137,78,251,29,17,203,68,21,100,210,186,72,37,99,105,0,217,79,151,172,97,3,237,23,25,103,156,116,145,113,13,193,155,26,151,184,24,101,161,142,56,212,40,21,153,188,81,2,68,159,55,245,213,208,210,57,114,204,10,235,185,113,39,8,212,142,127,221,229,155,84,15,244,52,111,56,180,142,239,212,205,212,104,164,143,127,99,235,93,199,190,223,49,113,20,155,170,89,90,234,113,128,129,149,173,26,141,168,120,115,182,91,43,161,76,210,51,38,14,173,23,2,55,245,51,58,92,137,167,66,39,125,190,171,214,153,220,85,166,115,129,174,87,235,22,132,121,89,83,116,185,27,109,180,160,81,67,207,52,221,206,184,252,229,205,19,222,237,42,93,200,179,32,74,104,148,50,116,7,252,66,105,64,103,160,150,154,206,20,33,193,97,237,175,154,159,160,77,38,145,241,165,157,48,218,150,99,60,149,122,188,188,167,236,89,81,60,219,108,212,39,69,159,22,242,183,65,241,121,185,233,164,61,47,218,168,115,52,85,36,102,197,18,180,77,85,225,97,125,181,205,155,178,173,43,113,126,153,73,234,47,35,206,81,174,130,0,29,28,98,10,82,43,16,76,49,22,120,182,68,93,78,94,159,228,62,91,82,211,36,23,52,165,154,228,172,120,74,32,61,42,101,219,188,185,121,34,230,107,169,39,100,133,87,57,217,116,169,88,48,104,33,254,93,37,91,13,88,86,125,145,111,141,214,77,74,94,192,45,217,43,222,192,185,94,13,51,92,212,156,206,235,203,36,253,150,169,21,236,52,47,155,33,76,146,178,34,208,91,192,77,196,3,31,29,161,22,187,188,172,90,222,81,26,52,206,120,233,194,237,42,214,188,110,89,153,173,188,177,241,37,63,11,184,10,177,147,130,179,138,223,205,27,18,244,207,26,144,54,32,28,12,177,100,6,3,121,3,251,48,77,67,184,146,92,98,97,0,138,124,104,141,208,227,115,29,8,182,18,252,91,128,154,146,252,171,148,158,55,226,200,16,177,218,89,126,173,197,255,187,178,237,158,196,185,9,170,3,169,163,88,33,90,152,101,38,194,150,80,110,215,234,144,232,59,118,205,54,18,228,132,246,69,13,189,65,245,166,152,6,133,236,218,108,9,197,66,160,7,174,204,194,21,66,149,79,81,81,174,57,193,246,28,187,146,240,212,98,34,21,48,96,77,10,146,88,180,196,116,113,109,189,74,204,66,33,10,122,166,119,192,26,16,221,250,81,7,179,143,9,227,198,252,16,46,16,1,129,80,64,93,183,196,67,161,188,27,190,222,126,60,198,27,33,31,82,235,42,57,48,111,5,62,175,29,119,164,102,168,114,12,72,104,36,134,203,4,86,48,168,142,209,125,165,86,119,52,195,217,153,0,2,244,166,52,74,135,15,183,180,138,2,145,231,99,242,225,178,220,176,126,190,91,113,182,219,195,74,90,43,45,166,35,10,42,40,184,170,27,167,133,99,155,40,166,5,163,107,118,214,137,210,179,51,167,170,171,178,76,168,154,84,110,47,135,148,18,92,255,54,185,56,233,98,67,234,105,220,242,37,148,7,87,20,103,65,115,190,20,196,116,136,98,103,160,199,72,0,19,244,32,223,227,240,25,186,98,5,108,40,135,135,186,242,103,209,176,86,207,74,42,141,228,194,240,209,212,165,98,207,1,17,11,142,60,205,28,1,108,64,208,53,212,24,213,223,148,197,207,122,93,86,29,246,213,215,149,75,21,185,106,197,67,210,142,16,74,137,223,74,132,209,200,45,184,38,184,191,160,120,159,213,124,144,184,106,109,243,254,122,43,84,195,3,60,143,86,55,138,239,202,62,225,58,71,160,150,142,81,32,202,40,51,115,236,225,228,20,135,88,124,156,146,192,74,223,213,154,121,168,9,123,213,168,25,131,140,89,28,4,196,216,72,92,79,192,216,66,12,18,163,214,27,215,212,88,68,200,8,24,110,11,204,176,217,236,48,223,136,131,120,165,19,172,74,48,72,44,33,84,59,190,113,68,32,213,172,71,126,95,193,82,42,139,198,16,24,144,10,81,93,0,241,5,170,201,212,51,237,129,96,144,2,40,234,156,151,87,108,149,206,197,79,209,108,14,21,141,110,43,142,58,110,1,78,52,131,224,132,203,141,129,250,67,224,148,122,152,203,32,55,177,231,85,144,4,161,94,178,15,2,87,131,87,155,2,122,44,131,126,150,1,93,150,193,208,226,126,34,20,200,241,154,93,240,126,214,76,237,117,65,175,39,90,4,147,181,168,174,75,148,75,79,45,43,157,240,111,41,191,141,46,145,70,185,31,162,2,103,83,116,207,36,194,185,28,135,32,144,176,252,14,136,242,5,222,26,106,63,16,170,210,115,150,167,33,162,201,218,74,207,8,14,87,81,46,18,92,22,56,192,198,71,190,88,119,21,220,111,167,115,77,86,23,93,179,196,148,142,53,19,253,162,70,110,42,34,77,236,164,136,13,187,249,29,169,75,78,215,124,25,153,70,0,227,213,174,219,238,58,0,169,108,5,117,54,236,57,215,10,2,79,106,158,245,76,180,219,12,71,247,68,35,127,108,125,237,212,49,139,134,246,190,155,243,111,9,208,120,54,178,231,101,85,24,30,192,88,45,160,21,41,229,0,125,23,188,33,29,236,20,238,130,195,228,31,207,235,230,187,58,47,2,14,1,174,105,231,159,2,208,7,252,26,198,86,84,167,160,200,89,187,76,226,102,158,110,6,13,233,224,220,54,83,61,144,94,97,221,157,237,41,10,60,170,74,228,121,76,36,144,74,250,159,56,117,142,43,193,135,69,212,5,93,200,160,44,86,216,0,44,81,37,60,250,4,49,94,111,38,199,123,233,117,83,172,236,145,238,232,163,31,97,179,67,187,42,142,83,246,154,93,213,220,154,159,140,154,119,200,35,201,180,32,145,92,136,56,122,77,64,106,70,74,190,34,243,9,161,166,90,201,49,183,75,215,165,192,206,156,132,172,73,45,93,188,133,202,57,238,240,213,110,99,189,255,20,50,162,37,15,128,197,10,59,201,219,228,249,166,206,59,84,138,8,0,59,127,160,38,37,121,10,75,51,59,138,228,49,246,235,142,56,141,246,66,4,204,105,63,60,98,60,105,193,66,123,120,153,87,239,88,241,228,124,133,119,142,118,201,131,20,252,32,108,225,228,156,163,117,162,92,171,98,10,121,83,77,90,32,199,160,135,21,87,234,178,15,80,38,44,110,102,157,91,135,225,247,212,55,164,3,176,26,49,99,149,16,125,232,89,123,94,54,45,215,189,154,75,211,181,176,227,215,153,61,136,241,34,69,247,225,128,157,76,161,206,70,30,162,74,211,87,182,147,102,146,197,212,129,202,16,64,193,5,26,201,243,5,167,49,255,55,168,187,71,65,126,181,33,129,187,226,81,240,77,117,55,232,142,3,175,47,120,181,236,164,117,171,156,55,108,127,132,153,226,12,118,94,167,4,138,82,194,225,37,21,3,230,129,116,206,183,169,15,110,73,13,212,83,215,134,201,229,122,227,29,44,9,38,229,27,60,121,108,241,230,231,228,87,85,108,6,161,46,248,165,74,39,168,150,53,161,153,143,171,150,155,63,71,7,174,40,117,155,163,174,185,177,251,36,7,36,227,38,48,215,133,77,94,181,185,110,97,246,31,118,75,40,145,146,40,73,71,141,135,27,255,79,126,178,214,129,3,238,111,101,96,191,226,54,101,73,118,252,49,89,231,157,232,247,232,173,189,127,34,135,173,127,47,168,97,188,174,55,155,183,220,100,33,71,162,85,4,131,161,124,1,241,142,14,142,171,119,101,197,244,137,179,187,250,2,187,54,16,221,165,153,163,183,175,248,226,174,214,87,219,4,246,180,76,8,0,118,140,119,24,149,196,1,251,226,104,118,43,155,142,243,172,222,11,202,179,168,112,99,155,6,103,112,29,60,128,211,59,16,194,104,8,92,62,147,35,166,110,27,47,69,246,62,201,217,229,29,184,140,242,178,129,197,3,158,2,174,44,189,212,223,218,71,12,14,50,93,57,117,96,24,184,188,120,99,52,3,153,94,234,101,252,138,87,55,230,150,131,0,132,228,34,128,150,225,116,101,193,208,251,198,227,79,176,137,158,134,215,245,135,136,157,234,38,127,137,122,90,18,164,129,14,61,88,87,58,245,96,65,207,238,61,74,58,223,91,136,238,83,140,135,63,206,121,40,125,84,65,39,15,104,231,87,112,196,135,199,110,188,141,8,22,62,140,8,25,30,157,248,26,127,1,159,76,232,200,158,161,173,75,169,229,132,128,165,44,18,207,166,233,57,242,165,156,221,225,233,237,208,76,81,62,245,82,123,206,105,14,139,136,1,130,23,219,92,73,200,186,166,59,98,4,165,81,13,42,117,32,140,77,40,68,36,6,184,81,148,66,205,104,231,68,240,92,112,57,63,3,205,156,30,116,252,247,116,21,236,109,227,183,152,150,144,219,144,21,15,144,120,250,212,63,133,27,88,42,132,143,131,84,1,229,187,203,72,36,211,209,129,73,160,160,22,211,164,197,127,18,171,46,110,224,172,186,7,184,169,92,37,90,168,120,101,212,9,167,192,179,205,166,254,192,183,181,3,139,6,113,225,213,118,109,23,110,100,48,152,216,51,58,146,108,142,115,43,204,151,201,92,159,131,91,112,217,203,90,210,138,195,201,84,140,204,124,97,206,205,103,67,232,66,241,149,225,127,3,228,120,86,92,149,21,151,90,206,94,172,56,184,121,205,214,124,110,218,212,187,179,183,64,161,13,67,48,143,139,18,82,56,10,107,166,10,85,159,114,200,242,24,176,77,26,87,178,17,37,110,133,153,133,125,195,158,125,80,126,223,75,203,121,198,28,18,227,73,131,254,62,79,34,168,101,135,121,37,134,39,79,167,7,235,88,83,23,198,85,122,46,250,49,140,149,36,127,2,107,41,117,7,88,43,185,221,189,11,127,122,249,240,183,240,190,64,191,121,25,53,140,34,54,144,166,41,108,129,181,253,57,243,99,177,76,60,192,136,209,9,247,99,159,81,25,2,247,118,210,131,168,68,175,209,187,73,247,66,88,117,203,191,207,127,127,244,241,239,243,228,106,215,138,59,244,151,124,55,213,37,23,124,33,17,95,190,226,95,230,102,34,71,96,188,140,93,139,197,10,68,250,252,243,150,65,247,68,59,129,156,148,99,223,130,155,155,112,6,227,135,178,246,131,43,175,174,89,211,113,61,98,252,26,63,88,201,117,78,2,116,222,76,112,82,196,204,133,117,52,164,224,44,58,36,158,193,21,135,122,169,230,217,73,171,210,1,137,196,21,182,232,68,77,21,103,121,94,250,32,160,166,59,154,212,45,196,16,97,28,152,170,37,172,53,245,27,135,153,32,47,131,174,220,191,72,107,187,189,223,84,199,30,236,184,176,1,227,29,237,10,176,33,63,97,243,3,45,33,181,181,136,153,114,106,0,10,42,25,134,56,227,237,69,112,26,183,127,176,239,13,125,133,161,107,54,152,213,95,38,164,93,198,205,125,205,45,222,94,0,115,6,240,163,206,197,22,1,30,97,85,225,14,205,196,234,28,149,45,47,131,46,64,220,53,177,185,147,206,69,89,95,55,86,163,112,136,130,158,153,154,91,28,36,175,2,173,95,53,63,93,114,254,60,19,241,236,169,138,173,127,234,186,124,44,145,142,146,76,22,169,241,83,3,89,194,142,145,175,19,50,2,112,31,112,120,86,205,36,0,248,33,96,237,145,146,28,103,46,41,180,174,39,120,232,164,133,208,6,160,225,187,94,116,84,166,83,69,154,188,86,246,191,171,235,247,187,173,244,133,63,53,165,190,79,246,113,2,250,212,128,9,66,187,14,150,17,38,240,235,97,85,174,85,132,241,253,68,213,67,224,198,136,101,222,90,5,103,21,224,163,82,32,212,121,20,118,3,149,188,238,241,29,35,177,231,63,126,160,208,152,135,220,207,55,94,38,192,90,119,124,63,65,214,38,115,195,146,216,108,187,97,107,35,65,119,12,3,175,61,244,98,142,42,155,106,197,170,33,3,140,3,209,87,0,200,75,176,153,139,85,176,177,174,163,128,193,219,199,20,144,9,173,229,31,30,140,109,144,66,108,52,56,208,38,6,209,92,151,30,13,211,52,136,1,132,57,198,70,3,133,141,32,224,43,151,72,170,15,22,200,55,5,91,239,64,66,168,190,230,48,113,20,33,16,42,239,217,104,118,50,215,191,164,36,224,169,44,77,66,180,201,192,116,26,141,0,222,69,205,13,145,22,0,26,123,253,128,240,240,114,8,49,47,109,84,189,197,188,163,194,42,41,43,139,32,142,84,116,29,197,224,186,189,47,157,128,73,173,122,113,247,98,159,70,80,203,150,217,6,120,233,153,134,0,83,90,129,0,56,22,18,13,2,230,41,140,131,209,9,148,86,105,32,36,202,211,40,215,134,103,155,50,111,45,96,156,60,110,24,114,40,64,81,208,68,162,195,17,29,196,116,27,166,7,153,4,113,34,116,111,24,81,248,40,69,226,196,62,66,213,135,251,193,121,20,135,24,132,208,62,24,156,75,175,56,4,202,211,59,25,8,117,250,184,71,249,190,185,8,190,17,98,154,97,241,248,89,43,26,194,100,10,218,211,6,148,220,228,196,141,165,211,134,137,115,99,93,214,74,35,105,130,173,21,32,17,187,10,101,166,207,172,92,173,8,213,80,151,146,117,208,212,179,234,6,101,18,177,151,133,131,47,156,38,224,216,95,110,201,228,237,101,184,225,30,175,63,221,158,210,41,37,174,72,33,158,34,144,213,219,90,7,3,71,55,54,48,184,193,251,83,64,71,135,92,129,97,153,72,93,29,30,15,4,7,34,28,105,36,25,204,75,71,8,128,192,67,32,85,21,38,139,252,227,15,137,99,230,103,179,244,66,166,251,171,208,179,233,194,161,220,225,58,77,41,53,209,42,194,152,247,68,110,37,136,155,236,164,119,239,47,23,138,147,227,106,119,197,84,248,14,106,240,15,39,19,208,48,216,130,223,158,92,216,121,213,23,0,117,69,183,32,131,182,217,169,247,121,111,180,52,249,128,7,229,41,106,228,68,133,204,239,194,72,140,201,153,72,138,154,68,20,231,63,253,127,17,51,34,38,57,152,8,18,53,66,149,14,200,96,40,68,9,224,181,254,45,188,150,30,117,72,85,152,30,143,127,227,61,182,88,80,156,156,233,90,47,234,162,188,40,89,129,171,65,191,99,18,94,255,179,114,211,207,120,193,149,34,65,94,184,170,216,30,232,243,118,135,128,179,20,252,19,117,203,32,38,1,179,107,78,228,113,208,40,106,86,36,77,120,119,34,21,165,39,224,45,239,30,228,177,185,149,33,91,236,225,210,18,37,42,76,148,83,107,207,103,116,147,184,25,222,185,177,45,8,111,177,25,18,205,33,75,64,58,59,68,123,210,164,164,215,90,121,74,21,99,52,253,75,61,4,82,207,89,183,190,188,53,153,141,112,198,69,199,232,67,53,22,219,80,151,134,151,255,12,49,17,181,31,248,62,196,25,174,64,129,193,231,131,17,169,241,67,155,101,223,68,85,219,243,171,138,212,15,42,60,53,37,212,64,175,31,75,137,106,103,12,254,112,97,145,129,169,233,34,67,91,3,221,54,140,114,63,220,176,188,113,9,6,79,42,19,134,33,156,114,156,59,172,54,179,135,18,170,107,74,107,198,4,136,107,253,7,20,133,70,4,53,244,48,201,49,145,146,231,212,48,78,175,158,50,51,227,39,170,54,122,231,37,122,193,0,84,236,136,237,92,9,150,254,96,203,70,52,239,107,74,55,227,54,213,91,214,188,186,248,161,42,133,244,133,72,60,196,144,113,235,183,24,93,59,214,191,33,184,184,77,184,135,166,176,85,95,112,203,181,185,187,102,155,129,14,137,189,185,143,251,194,27,58,251,96,1,165,30,249,246,85,154,120,10,87,121,109,254,41,255,254,216,71,72,129,167,120,38,56,147,178,238,187,165,203,100,62,161,57,242,63,46,209,52,76,1,163,93,173,75,71,138,129,160,167,59,137,141,47,17,198,36,137,51,134,107,67,185,70,232,175,144,52,254,161,196,72,47,30,233,27,34,176,11,107,135,86,46,198,56,108,225,9,124,108,36,74,31,186,195,6,223,72,246,152,168,103,138,232,185,113,107,225,45,142,152,13,232,30,219,18,198,12,59,203,65,21,90,111,143,38,143,48,27,72,35,7,135,137,232,220,7,61,57,76,71,156,38,203,139,182,241,227,100,243,25,73,13,229,240,150,199,203,253,71,68,20,40,75,10,115,56,237,91,52,192,246,136,70,146,6,150,224,237,98,56,188,204,215,46,94,99,144,136,129,241,19,165,39,81,19,209,195,26,143,243,165,99,139,145,109,105,203,112,190,140,37,207,48,70,6,178,68,123,172,106,108,141,152,171,253,129,184,104,230,140,155,177,161,148,184,73,255,19,24,92,56,8,36,5,36,70,34,70,245,232,32,114,222,64,133,69,154,68,178,65,32,147,228,193,101,50,167,65,205,73,19,46,74,52,185,174,244,236,176,254,98,154,17,162,218,3,144,14,63,94,198,240,5,125,232,164,119,125,21,105,82,245,91,253,3,190,1,224,127,49,119,57,250,29,2,161,97,223,223,63,238,160,79,43,6,163,11,252,132,46,223,72,24,154,160,129,249,155,137,216,237,20,125,64,209,170,208,132,177,217,248,76,26,190,249,117,187,221,206,35,65,2,130,225,189,234,237,86,198,106,170,29,146,253,42,179,245,69,99,27,178,103,173,238,103,68,202,62,190,211,174,88,243,239,117,25,57,131,213,224,4,30,99,18,0,242,57,29,30,163,77,7,104,134,7,134,166,83,7,234,15,83,50,8,106,0,95,55,245,110,123,112,51,154,210,182,190,223,101,228,187,55,21,223,228,215,34,190,22,166,87,36,59,6,58,45,24,140,202,137,249,200,4,229,200,59,121,121,151,199,142,165,1,51,155,21,81,223,230,59,58,176,55,249,216,237,174,244,105,64,39,194,179,252,154,229,226,250,116,163,254,183,15,57,223,220,204,83,85,82,211,25,112,10,235,220,34,170,113,38,234,165,48,171,138,140,178,82,223,78,218,163,3,153,212,147,111,136,248,102,201,47,253,10,54,243,221,165,206,85,227,249,28,52,20,46,235,162,156,3,217,67,245,90,186,218,35,87,77,94,39,87,15,61,58,39,184,246,43,64,132,68,157,55,170,252,103,233,175,109,129,235,33,48,12,188,6,65,54,164,228,119,141,218,199,96,128,56,119,11,92,16,11,245,70,101,76,203,171,252,146,70,175,157,215,148,60,244,26,221,170,227,9,103,47,230,120,2,250,86,135,221,179,145,51,14,233,48,242,178,119,169,27,82,206,255,143,66,7,112,66,58,210,189,78,238,11,246,208,183,59,249,55,33,110,180,155,19,214,24,229,235,28,227,138,4,64,77,179,184,67,114,140,63,114,208,29,9,185,113,212,106,14,167,211,198,116,79,92,221,195,228,26,206,57,216,191,123,180,59,125,91,255,71,152,18,251,222,115,191,198,238,153,14,164,125,13,122,214,129,83,224,53,5,27,74,197,136,248,178,12,7,191,81,238,20,141,153,6,96,195,167,130,11,98,189,155,81,234,99,184,57,181,180,22,233,103,60,194,99,87,26,24,159,185,213,79,118,209,27,154,18,16,41,3,132,31,133,177,123,17,134,99,252,34,239,46,179,215,34,207,75,26,160,247,55,127,60,201,195,228,171,71,143,150,201,191,45,122,251,243,196,40,96,112,252,142,93,24,75,139,62,123,241,248,48,213,19,25,86,251,151,48,184,74,205,23,97,82,241,215,235,186,238,223,248,96,73,49,236,13,152,201,143,55,189,151,252,200,234,237,185,88,136,255,189,116,33,227,254,141,11,79,39,142,177,111,238,225,131,41,81,85,255,4,228,128,209,193,96,228,145,26,14,111,63,157,136,9,171,103,126,193,254,164,140,206,202,160,98,177,199,8,195,131,90,116,212,0,222,80,180,217,49,172,163,222,127,102,209,40,5,175,30,163,222,82,180,181,252,24,77,82,13,150,33,25,236,42,24,89,52,110,165,156,8,6,214,244,243,122,183,55,215,71,247,161,99,222,138,80,233,201,165,62,214,193,126,84,89,216,52,181,225,4,120,164,192,231,206,58,197,34,110,130,140,178,30,102,161,209,220,163,27,202,153,254,226,11,108,219,249,108,245,69,4,93,85,221,83,181,91,252,167,210,147,94,29,61,10,255,21,209,125,159,161,181,140,135,143,133,238,71,56,219,92,147,162,217,153,26,59,221,2,209,51,242,9,158,4,232,109,4,30,59,189,50,25,89,224,12,40,85,37,56,199,136,59,76,238,184,224,248,119,72,201,133,129,180,120,152,57,15,233,183,113,176,178,71,234,201,158,219,40,80,3,194,141,145,48,215,229,189,115,200,62,154,98,237,143,95,167,155,186,206,171,228,58,211,61,84,210,147,113,182,187,66,118,208,66,121,129,60,148,60,127,212,221,221,71,119,247,254,60,227,118,154,239,169,137,183,158,176,254,82,29,104,224,47,235,46,2,63,152,159,56,143,9,122,186,69,235,222,252,57,97,15,40,179,146,126,76,195,178,48,195,105,150,62,70,24,89,128,234,243,56,108,54,245,218,223,173,190,102,45,220,167,245,42,222,8,123,187,13,28,231,31,79,121,250,1,19,237,238,74,152,148,72,237,226,78,50,95,131,127,169,183,204,184,86,168,191,191,32,186,119,199,36,105,216,243,74,236,10,174,164,119,43,29,132,190,191,79,141,174,231,21,38,217,169,7,150,94,67,246,147,175,22,201,231,159,235,197,116,160,13,202,60,19,50,178,193,39,182,15,31,9,124,41,73,147,124,25,206,87,111,134,128,232,217,132,123,218,60,126,7,177,104,199,94,65,28,23,190,11,250,196,185,160,116,119,74,235,222,230,176,64,59,146,201,115,1,249,5,120,149,227,170,24,31,12,140,61,23,176,170,120,156,43,63,208,125,17,234,254,149,14,107,111,6,254,36,167,245,56,247,52,136,232,141,5,143,56,62,2,16,227,87,193,124,215,181,139,160,12,111,119,249,222,112,139,30,29,87,56,62,208,184,255,196,117,148,160,141,146,101,227,62,52,17,181,42,17,90,76,188,123,189,86,189,158,104,48,7,198,3,12,124,209,65,60,111,207,97,179,245,188,246,157,223,66,237,246,240,225,195,228,137,86,131,43,83,240,153,253,143,250,153,152,127,77,73,50,119,181,230,160,154,250,185,76,2,56,137,5,147,89,28,30,250,72,60,145,169,36,229,101,255,253,57,14,48,153,175,56,131,249,253,124,150,61,121,40,155,208,16,192,21,47,153,149,122,133,134,227,254,129,16,63,35,65,147,70,244,139,252,55,40,0,103,91,27,254,68,93,51,82,62,119,147,206,17,99,134,205,105,5,227,53,19,6,163,9,1,27,167,196,177,53,42,13,105,124,136,24,152,222,238,94,46,48,188,93,225,125,235,250,63,225,12,248,62,142,128,253,37,110,96,27,0,34,80,52,164,216,217,173,91,164,91,179,54,15,78,231,121,189,181,138,211,206,237,247,136,43,100,23,228,76,57,94,144,149,36,219,163,89,196,236,165,232,237,1,191,203,68,170,100,35,122,22,71,129,50,179,216,129,141,142,158,49,98,208,152,157,165,248,29,220,28,177,118,61,130,68,110,50,174,208,13,224,71,250,213,19,79,40,93,138,18,224,83,4,217,108,239,102,71,40,171,79,219,15,169,49,216,20,151,44,134,13,8,96,33,40,235,65,38,246,233,181,25,160,114,65,75,245,145,82,105,254,161,180,173,187,130,244,130,70,8,38,163,169,111,129,16,4,117,157,234,116,97,224,188,124,248,252,25,244,103,172,132,217,44,186,162,189,150,141,90,109,20,36,91,197,160,70,245,74,87,205,200,149,136,90,229,231,171,51,18,110,184,34,41,228,219,213,147,150,177,100,221,176,139,253,121,224,159,154,63,92,61,121,104,42,122,150,15,138,103,5,109,98,241,69,7,55,82,44,142,207,190,31,243,158,49,72,163,49,221,9,236,28,39,78,182,254,17,206,53,237,131,77,83,199,227,134,226,31,111,220,231,97,207,253,119,65,230,123,85,121,122,74,255,205,83,222,13,180,177,73,217,177,207,238,180,34,232,131,255,91,95,36,91,225,214,201,171,34,185,200,185,181,57,82,116,148,59,115,190,82,83,221,111,174,249,15,212,4,34,38,43,244,195,40,244,123,61,26,128,124,158,71,32,62,220,74,60,121,3,91,201,81,210,54,32,78,53,74,61,188,131,252,194,38,104,49,120,127,199,60,12,148,32,172,213,246,10,125,179,184,217,92,165,126,203,126,207,113,207,131,70,65,63,147,32,193,183,140,196,203,17,5,219,228,55,253,16,228,123,186,243,35,81,113,14,15,246,100,83,253,92,68,79,115,45,168,71,166,182,147,88,29,72,229,136,37,252,80,38,27,191,193,219,45,136,94,85,60,7,190,219,11,32,231,30,155,137,56,115,37,106,194,214,18,208,80,119,122,162,80,79,66,242,143,242,155,86,117,129,131,188,111,221,179,24,23,213,115,248,212,212,32,76,249,204,212,115,145,157,245,146,21,122,133,126,138,153,210,27,130,174,244,120,204,56,131,137,19,62,192,248,156,161,154,43,219,1,200,63,239,152,216,124,196,135,118,154,179,252,72,12,43,21,75,7,116,111,176,133,228,254,165,37,6,25,161,63,185,67,184,83,31,126,140,100,247,118,83,174,199,108,235,253,237,173,253,1,55,245,112,211,238,126,77,217,175,139,141,58,82,154,18,65,172,49,207,249,42,116,196,46,252,199,108,94,93,92,144,71,123,247,250,132,79,66,62,126,211,71,186,196,35,71,226,211,39,113,222,17,237,251,192,85,0,85,195,89,1,70,225,153,203,53,155,186,228,253,79,23,220,54,156,228,50,65,190,146,222,101,207,37,216,134,222,21,106,250,84,78,109,17,95,135,80,244,78,9,29,60,51,119,67,121,184,195,240,151,66,59,186,204,43,244,132,227,203,220,202,245,90,107,109,233,90,195,55,88,45,218,238,234,174,255,18,249,44,126,154,228,221,251,69,218,75,157,75,40,71,144,106,162,142,174,188,40,69,141,180,190,20,140,33,221,130,11,7,217,240,47,101,153,165,241,165,33,52,189,66,132,254,210,64,231,69,153,42,206,160,48,196,243,197,203,173,18,205,161,190,4,97,246,124,138,179,218,195,0,84,185,95,104,77,91,253,214,152,242,252,142,126,153,44,100,198,7,1,200,158,195,53,121,144,227,117,145,236,251,57,240,123,243,247,187,158,67,64,228,77,188,16,139,99,63,68,11,61,187,145,160,71,65,212,219,3,126,87,26,139,232,91,45,222,211,44,83,229,0,49,145,227,187,248,242,134,84,108,255,179,24,156,179,150,189,221,145,191,167,238,132,98,242,251,112,88,248,182,253,232,175,124,212,98,75,187,253,137,134,11,170,44,161,42,73,38,210,48,38,157,231,226,146,222,201,133,200,115,139,94,194,246,246,74,224,25,208,120,55,164,252,82,239,108,27,33,238,121,131,27,94,93,37,235,13,73,45,199,212,109,184,147,224,25,20,31,117,46,199,253,52,4,26,132,124,71,78,231,175,211,244,194,221,247,157,223,171,219,203,46,248,141,184,100,186,135,70,229,63,62,51,184,45,27,245,236,140,204,84,236,61,28,107,94,207,164,95,149,45,139,101,136,207,210,160,163,163,123,149,183,99,20,6,242,181,57,10,3,226,66,233,73,117,157,111,202,130,120,40,11,178,136,126,47,107,242,97,91,68,109,133,167,81,183,80,56,180,215,50,162,126,98,66,75,62,70,63,194,173,168,83,45,69,158,179,7,82,73,118,64,66,246,196,148,106,56,32,169,104,67,58,197,59,56,240,32,180,239,74,184,45,220,17,47,67,79,117,104,122,175,68,135,78,100,229,174,29,118,37,247,76,137,244,250,222,49,182,155,138,28,6,239,131,155,121,245,99,172,153,185,95,21,143,170,166,95,198,118,171,141,239,148,195,190,56,207,253,102,227,131,181,234,233,187,167,52,73,1,132,39,237,104,73,86,255,222,139,73,31,74,247,212,189,11,181,73,143,61,25,252,167,237,139,20,248,54,233,46,153,78,222,35,125,212,122,167,38,83,239,243,47,244,217,207,93,52,168,160,107,228,68,169,44,4,91,92,148,124,15,89,55,253,14,103,131,167,240,92,240,121,170,46,228,51,43,66,110,248,32,204,65,218,227,228,91,118,147,124,153,156,20,48,68,68,82,104,153,40,133,240,165,173,156,245,207,241,228,160,153,101,120,29,152,204,234,106,147,84,250,239,206,0,195,129,220,124,220,54,103,3,56,219,247,157,136,16,175,204,134,34,62,26,180,223,220,133,65,24,129,7,111,154,154,205,21,76,234,169,238,209,186,214,65,34,76,151,77,214,139,7,162,19,104,162,171,168,175,176,120,81,233,185,96,47,209,148,150,232,54,164,137,9,35,114,8,205,78,125,116,246,147,0,69,19,248,69,28,250,106,237,71,120,70,104,206,27,184,208,218,158,248,9,126,254,175,41,1,19,213,117,239,98,61,42,47,237,176,84,139,40,13,33,158,233,221,179,176,244,72,244,3,36,74,207,42,216,93,40,205,119,201,218,219,19,231,39,18,2,247,6,250,185,188,162,82,233,200,44,172,123,52,253,116,186,219,64,53,121,173,113,106,69,116,160,48,152,45,69,102,51,182,105,7,245,216,168,36,199,1,98,75,196,3,70,218,229,85,113,140,158,177,118,130,132,170,122,25,23,33,49,61,252,73,225,56,148,233,177,39,78,1,222,244,54,9,31,113,186,84,229,254,43,106,190,109,48,78,94,211,247,171,10,44,84,48,41,169,159,202,82,15,13,156,53,13,131,163,135,132,79,164,70,123,157,151,131,3,8,196,199,159,182,190,7,223,14,243,170,170,187,51,102,250,149,205,38,238,107,101,2,205,150,82,186,134,177,238,170,117,207,163,250,220,106,94,70,168,93,102,31,227,214,103,45,242,137,180,44,208,83,115,219,132,147,47,98,206,148,173,186,236,198,217,49,134,74,81,243,69,137,83,51,97,34,233,39,24,179,197,35,122,56,38,73,120,235,16,231,255,105,43,76,250,118,208,21,142,219,230,119,27,8,3,82,216,143,77,40,134,81,66,169,197,40,82,79,73,148,69,220,84,185,103,154,246,69,189,247,234,204,241,9,110,189,251,99,83,188,241,120,235,10,194,191,157,19,139,14,40,167,189,246,242,15,212,11,218,33,227,184,242,123,217,15,135,193,64,80,203,2,237,106,219,7,167,94,196,6,62,160,201,208,161,248,240,50,64,157,104,197,112,245,252,227,189,105,202,242,205,70,178,35,118,206,81,242,23,73,131,12,61,86,36,63,10,144,126,47,102,193,86,49,216,215,226,101,205,235,12,92,31,203,116,140,180,254,162,215,245,133,247,188,119,92,223,181,227,54,128,120,79,22,211,248,85,108,96,248,69,226,168,226,141,77,211,80,250,160,91,166,66,186,139,45,139,119,140,198,170,170,155,99,78,165,116,91,138,217,216,150,126,58,87,94,2,50,35,153,120,195,217,168,132,80,227,119,130,195,246,135,217,15,122,203,178,8,90,212,25,134,146,15,151,172,74,222,150,174,228,79,176,72,250,44,17,8,210,166,12,85,80,12,138,145,230,112,247,119,192,7,64,222,120,80,32,70,164,182,117,233,74,53,15,70,182,121,242,68,198,174,99,114,199,55,176,106,89,200,100,91,55,230,224,114,4,206,232,170,149,77,244,90,218,228,59,142,165,189,226,40,175,39,224,222,226,55,31,109,3,26,147,249,98,166,98,208,237,53,25,63,49,173,108,92,78,190,31,3,175,22,105,32,245,40,32,234,66,69,25,189,211,34,192,144,55,58,99,119,58,110,117,213,71,97,81,111,195,91,29,209,27,165,127,214,69,80,13,94,94,168,215,76,224,152,48,14,206,73,8,1,33,198,12,250,57,91,24,136,126,45,117,104,44,199,162,58,167,49,89,156,166,202,129,119,81,196,92,40,89,233,78,165,199,47,188,191,25,94,211,132,25,33,197,189,253,146,161,7,173,229,81,209,42,213,64,15,93,230,117,183,126,130,247,23,157,148,242,133,83,183,65,111,106,201,199,35,165,170,62,9,242,23,243,46,149,22,15,178,103,224,186,193,94,96,38,22,165,158,180,202,193,252,42,204,222,248,72,255,236,56,88,51,228,40,54,1,119,194,244,234,167,233,40,231,128,26,109,176,91,183,13,144,155,75,207,240,247,234,163,173,116,94,63,107,154,252,198,230,175,250,56,235,61,135,209,93,31,220,208,98,213,107,19,220,199,138,187,171,254,233,215,220,31,228,16,254,23,173,186,187,208,69,231,54,237,61,130,56,110,107,142,87,136,215,245,135,112,181,147,2,171,152,85,135,82,7,210,245,8,87,214,251,241,73,109,64,164,54,74,131,43,55,72,222,218,115,151,76,3,129,86,19,103,239,187,118,148,82,11,201,167,134,235,98,240,119,45,173,197,194,240,125,163,101,96,219,67,225,89,17,1,136,147,198,11,86,192,200,16,239,67,113,143,211,219,61,115,54,113,49,215,145,16,88,173,114,244,223,252,156,252,222,35,19,75,106,114,151,52,57,62,14,43,78,41,165,173,202,117,3,242,197,136,163,31,95,179,137,72,73,171,49,159,237,186,90,156,18,173,249,134,250,38,185,40,55,155,54,217,176,139,14,194,144,45,132,7,179,174,184,106,206,27,38,125,145,5,187,40,43,86,76,14,12,22,106,82,254,49,90,199,250,73,92,20,12,93,58,202,95,11,161,133,73,106,20,60,193,113,96,208,114,57,31,237,249,165,61,190,193,108,148,109,242,78,186,24,155,164,187,204,43,145,67,230,95,12,1,99,222,92,177,86,252,40,98,198,130,243,15,47,121,108,127,138,173,49,57,136,134,146,202,13,36,244,180,8,4,89,119,204,154,2,217,74,201,212,105,195,177,106,85,132,79,196,77,228,85,164,114,17,70,147,39,133,137,255,232,12,74,126,133,169,201,147,64,182,85,26,135,101,207,200,191,76,190,90,38,47,202,98,203,247,74,157,4,34,124,186,207,62,168,203,87,255,193,154,122,97,83,49,121,231,247,14,168,240,237,37,84,10,38,42,71,145,250,240,133,132,169,205,75,29,39,171,14,141,197,59,99,116,2,42,209,13,39,159,190,110,61,127,62,231,80,162,35,51,79,28,249,119,110,52,117,69,41,255,189,233,118,141,13,120,210,104,92,43,134,231,149,245,145,145,187,61,255,92,98,152,26,145,240,166,82,30,76,233,54,75,106,52,166,35,234,204,42,232,21,217,212,99,178,131,249,233,192,66,41,36,164,111,154,114,207,85,106,63,121,125,118,72,187,255,19,233,100,151,160,237,175,208,201,144,136,190,82,86,132,80,53,110,173,156,167,229,63,68,202,217,163,132,159,32,174,246,242,87,42,197,25,100,181,164,147,67,34,147,243,60,200,177,55,148,202,113,80,195,155,119,72,33,126,95,246,247,250,164,103,204,84,134,109,173,232,38,118,115,39,245,226,192,96,245,226,97,117,107,213,210,39,251,6,17,117,12,174,120,211,132,239,217,96,189,41,242,14,82,32,157,7,16,39,8,172,77,132,98,37,149,140,29,156,46,161,16,84,32,156,218,164,138,16,96,140,152,66,71,104,127,130,37,226,253,102,187,207,86,124,212,233,84,36,110,59,115,149,255,198,151,181,2,132,180,245,103,118,162,146,58,25,168,64,168,224,19,210,79,252,78,172,180,132,157,3,187,196,251,184,76,254,245,214,107,46,69,66,44,25,65,103,222,152,110,45,35,240,10,179,46,131,69,178,4,254,247,223,142,84,70,52,71,215,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCascadeCycleMessageLocalizableString());
			LocalizableStrings.Add(CreateCannotSetProductCountMessageLocalizableString());
			LocalizableStrings.Add(CreateValidateTotalPercentageErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateValidateOrderProductQuantityErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateValidateTotalAmountPlanErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCascadeCycleMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2f18a579-0121-4432-81ae-cd957b7ddd4b"),
				Name = "CascadeCycleMessage",
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("cb4a7c94-f312-40d9-9d18-9206951b494d"),
				ModifiedInSchemaUId = new Guid("cb4a7c94-f312-40d9-9d18-9206951b494d")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCannotSetProductCountMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("baa3fba5-e00e-4ebc-88b5-cd7f251476db"),
				Name = "CannotSetProductCountMessage",
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("cb4a7c94-f312-40d9-9d18-9206951b494d"),
				ModifiedInSchemaUId = new Guid("cb4a7c94-f312-40d9-9d18-9206951b494d")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidateTotalPercentageErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8602a0d7-5e14-4044-a421-26e3188b089b"),
				Name = "ValidateTotalPercentageErrorMessage",
				CreatedInPackageId = new Guid("ea2e3ae4-7b44-4850-bdfa-8147ce4d763d"),
				CreatedInSchemaUId = new Guid("cb4a7c94-f312-40d9-9d18-9206951b494d"),
				ModifiedInSchemaUId = new Guid("cb4a7c94-f312-40d9-9d18-9206951b494d")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidateOrderProductQuantityErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("513c0117-f5f8-4330-b7cb-8aabefff37f4"),
				Name = "ValidateOrderProductQuantityErrorMessage",
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				CreatedInSchemaUId = new Guid("cb4a7c94-f312-40d9-9d18-9206951b494d"),
				ModifiedInSchemaUId = new Guid("cb4a7c94-f312-40d9-9d18-9206951b494d")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidateTotalAmountPlanErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a7dedbbd-56a2-4378-972e-11ab14453dc7"),
				Name = "ValidateTotalAmountPlanErrorMessage",
				CreatedInPackageId = new Guid("0e488ac0-fe51-4dc3-8d9a-11caac414976"),
				CreatedInSchemaUId = new Guid("cb4a7c94-f312-40d9-9d18-9206951b494d"),
				ModifiedInSchemaUId = new Guid("cb4a7c94-f312-40d9-9d18-9206951b494d")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb4a7c94-f312-40d9-9d18-9206951b494d"));
		}

		#endregion

	}

	#endregion

}


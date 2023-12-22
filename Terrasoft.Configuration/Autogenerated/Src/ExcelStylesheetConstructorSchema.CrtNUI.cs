﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelStylesheetConstructorSchema

	/// <exclude/>
	public class ExcelStylesheetConstructorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelStylesheetConstructorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelStylesheetConstructorSchema(ExcelStylesheetConstructorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c83cf6a-8570-4d0e-8667-0bfa7f5957be");
			Name = "ExcelStylesheetConstructor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,26,93,111,227,184,241,57,7,220,127,96,125,125,176,145,84,78,182,135,2,23,231,3,137,147,220,5,77,178,105,237,189,235,219,130,150,105,91,168,36,170,36,157,139,55,240,127,239,240,75,36,37,202,113,30,54,192,46,172,249,158,225,204,112,52,118,137,11,194,43,156,18,52,37,140,97,78,23,34,25,211,114,145,45,215,12,139,140,150,201,237,107,69,153,152,210,219,215,148,228,63,254,240,246,227,15,7,107,158,149,75,52,217,112,65,138,81,227,57,249,53,167,51,156,103,223,20,119,11,251,144,149,255,115,192,165,162,61,61,29,211,162,0,85,15,116,185,4,176,195,223,208,116,93,144,82,220,81,86,96,145,124,174,72,249,159,34,127,15,159,76,42,70,240,156,175,8,17,142,214,247,143,145,228,14,167,130,178,140,112,160,0,154,159,24,89,130,189,104,156,99,206,79,145,114,118,34,54,57,81,82,32,34,92,176,181,228,80,212,195,225,16,157,241,117,81,96,182,185,48,207,183,165,200,196,6,137,21,22,40,5,253,130,112,196,107,9,104,6,40,82,84,57,192,19,43,97,232,137,168,214,179,60,75,81,42,245,239,84,127,32,79,160,182,247,46,35,249,28,12,126,102,217,11,136,86,214,29,84,250,1,141,73,158,235,208,160,175,162,202,127,131,160,16,230,128,163,29,180,191,227,124,77,58,72,157,97,138,84,61,78,108,176,157,192,117,46,214,140,220,151,11,138,190,18,233,144,129,232,128,31,252,68,202,185,118,194,60,27,143,158,25,173,8,19,112,50,210,43,42,72,42,200,60,244,235,30,18,5,125,205,233,210,40,52,68,26,46,255,157,95,40,52,186,188,68,125,245,225,92,130,31,113,137,151,132,37,191,18,33,51,141,176,126,47,85,137,119,85,65,226,64,104,122,131,129,49,174,121,192,250,132,165,19,40,165,229,11,216,7,114,106,66,255,28,107,35,27,103,56,53,135,255,64,229,33,152,136,116,161,71,214,95,235,217,110,97,187,177,50,24,59,181,65,152,164,182,246,95,255,29,190,115,93,46,186,148,54,50,174,103,59,77,185,232,239,19,224,185,140,158,200,10,130,22,186,172,187,226,108,131,115,3,12,83,160,215,169,170,18,46,4,185,16,152,20,188,76,26,4,144,40,94,190,38,227,53,99,208,86,12,168,65,252,78,254,62,18,177,162,157,37,249,66,179,57,186,154,207,93,105,241,190,87,79,174,97,12,144,170,243,131,23,204,16,24,158,255,193,50,200,57,14,49,191,198,156,168,72,141,107,176,12,253,85,238,1,120,127,144,76,233,67,198,69,127,48,138,201,25,211,117,9,113,241,65,137,130,133,212,198,196,8,181,6,29,162,147,40,3,208,150,228,79,228,123,9,14,89,49,253,47,247,165,248,251,167,65,75,197,86,11,243,192,137,174,205,126,40,77,231,17,80,66,134,160,126,6,66,51,168,223,87,16,125,50,50,31,207,218,214,26,212,225,161,141,173,178,154,216,80,218,92,65,253,219,16,52,208,124,163,78,158,43,33,88,54,91,195,241,118,158,142,2,105,234,71,82,204,8,171,121,250,13,97,3,79,79,185,150,164,181,97,93,106,147,39,143,206,99,199,85,149,111,158,246,148,113,213,36,246,4,217,155,43,8,83,43,112,231,168,17,184,68,223,56,166,185,92,70,47,33,131,60,237,188,117,154,185,5,154,33,158,94,46,180,141,59,234,244,210,6,55,146,97,105,243,4,182,234,127,87,145,109,66,174,41,183,178,196,59,238,210,208,84,15,1,222,250,6,171,200,249,209,119,57,213,233,75,163,67,212,225,9,107,197,230,186,47,252,126,190,111,54,29,105,230,86,114,124,40,147,140,144,127,173,161,99,63,51,178,200,94,119,177,123,100,134,241,142,150,218,100,211,56,84,154,12,208,241,23,139,207,242,124,23,254,154,50,200,185,157,18,92,88,154,20,58,23,116,74,100,11,212,15,14,14,253,5,194,189,206,243,186,163,184,131,72,106,171,3,14,3,110,229,97,82,59,209,32,87,224,54,185,231,83,200,96,17,17,13,206,201,166,73,26,209,102,185,202,179,101,41,39,108,93,117,55,100,129,225,78,172,161,97,48,28,117,119,1,38,191,193,208,253,13,66,128,243,154,186,93,148,78,82,242,7,195,213,148,188,238,221,254,100,27,58,254,18,145,40,147,210,119,167,97,122,128,246,27,0,35,48,3,148,94,133,185,154,119,21,239,4,199,162,228,176,160,212,11,82,36,22,42,237,56,154,147,69,44,80,94,197,227,208,21,167,194,100,36,186,12,192,201,56,167,37,121,162,115,210,135,55,9,72,108,204,61,163,79,85,207,112,6,15,92,186,199,45,145,90,58,173,135,251,174,36,12,187,162,168,109,245,78,31,204,142,139,142,196,30,7,184,109,108,162,82,173,217,4,94,86,216,30,83,213,66,146,153,118,169,89,218,35,138,233,2,39,95,142,208,63,75,250,103,121,103,120,100,12,183,163,64,148,39,201,159,185,36,106,146,125,35,30,90,62,74,93,191,171,40,156,156,220,120,146,82,154,83,102,123,184,252,44,9,167,43,82,144,136,81,13,11,158,112,225,171,145,143,78,77,111,12,81,156,177,172,215,96,186,195,69,102,187,181,124,77,118,252,13,140,19,245,169,33,98,188,194,108,66,252,0,24,136,199,114,252,115,131,105,146,26,167,234,168,40,128,99,113,48,147,85,143,89,73,217,214,206,125,101,125,31,219,8,15,218,40,21,205,8,220,70,171,3,213,240,188,131,202,56,217,129,213,166,123,72,238,99,13,188,61,92,40,202,193,158,121,14,87,195,59,121,174,72,208,66,253,111,66,173,152,118,100,186,137,176,164,83,140,79,208,55,60,94,155,219,207,88,192,104,91,42,178,202,125,246,168,61,10,169,207,60,78,55,149,36,48,79,230,104,37,151,61,89,35,196,6,164,33,123,224,168,92,64,67,92,36,168,146,250,189,160,234,123,115,143,190,49,211,132,198,75,203,246,126,68,29,111,192,234,55,139,156,44,196,181,79,242,80,3,124,50,150,45,87,33,221,191,29,196,39,20,180,10,200,166,246,217,39,154,81,33,104,113,29,90,230,64,62,233,60,195,75,90,226,60,32,190,9,128,150,92,123,106,79,192,57,22,69,123,14,69,241,181,31,81,172,239,64,148,32,52,59,32,225,78,136,135,107,167,144,161,222,179,50,117,14,237,78,165,200,149,229,17,141,34,52,170,114,59,104,108,26,54,209,221,166,142,215,28,162,182,143,165,114,12,8,23,125,137,190,7,155,195,111,59,108,49,182,216,40,114,231,218,158,185,250,99,74,85,27,251,184,82,213,43,98,74,93,91,232,86,106,2,251,113,181,134,49,166,248,218,79,38,173,186,113,78,19,33,47,30,213,65,212,68,25,44,160,198,82,152,53,196,140,72,30,67,114,199,228,185,170,59,251,175,189,183,144,55,153,172,40,83,242,76,7,222,162,55,80,208,20,190,237,69,211,167,97,86,135,73,106,60,45,158,11,163,1,218,68,204,6,249,108,40,146,123,185,95,249,188,232,247,132,232,29,25,45,99,90,84,152,101,156,150,201,103,54,207,160,124,239,151,48,0,144,49,230,16,197,11,152,242,97,196,237,161,171,199,225,243,99,15,38,88,174,184,146,219,162,18,155,209,94,161,89,173,154,193,145,31,39,4,212,98,1,163,70,81,188,121,110,52,66,210,181,254,243,118,245,114,7,168,182,250,38,136,122,195,223,189,219,183,1,220,238,75,239,175,216,253,245,230,0,194,33,86,25,175,79,36,88,126,214,111,82,245,58,254,93,167,188,157,102,176,144,143,110,113,229,174,151,215,43,35,244,162,175,248,248,18,87,65,244,57,241,11,201,136,24,225,96,87,114,54,180,208,112,215,59,163,52,87,26,166,85,238,220,11,42,15,233,74,29,213,168,230,202,169,69,208,88,59,5,120,193,54,173,109,97,123,191,141,206,119,47,225,19,101,178,1,217,43,178,109,119,135,244,196,129,60,206,136,91,93,252,209,111,126,186,124,239,18,18,93,206,109,81,138,69,186,210,59,211,74,126,229,167,248,213,167,186,87,62,80,168,75,198,32,99,107,92,242,72,56,199,203,122,33,103,106,117,129,115,78,34,111,128,178,117,250,137,26,77,60,221,135,81,170,46,182,221,95,30,40,136,172,243,2,149,240,30,112,222,115,237,188,119,81,151,152,124,31,242,250,252,217,80,113,196,5,148,193,122,173,119,161,191,203,8,151,110,187,37,44,234,78,106,185,93,111,13,56,93,53,120,215,185,217,48,70,47,242,35,180,150,59,242,208,196,163,160,155,59,229,246,212,234,215,31,147,24,11,127,189,216,64,214,149,216,222,50,122,179,176,234,190,250,185,31,218,50,8,214,112,210,10,224,116,38,249,43,56,239,60,26,70,120,47,88,222,22,119,23,189,26,216,15,15,223,79,172,57,52,180,32,173,160,191,81,115,122,140,44,218,57,52,188,248,94,137,231,29,126,198,196,26,94,149,235,175,148,148,129,123,125,169,180,35,40,241,3,230,232,13,233,35,178,47,57,199,254,161,168,119,3,115,149,54,182,196,31,255,62,164,249,37,130,189,163,7,145,175,57,130,220,247,19,62,102,205,81,215,40,53,8,189,248,46,30,124,216,250,208,242,142,33,230,157,225,206,247,76,124,143,179,249,240,185,52,173,56,138,205,145,123,13,90,110,38,241,102,172,104,249,214,101,197,245,221,166,11,2,233,252,223,99,46,169,249,161,232,130,170,12,70,20,61,173,217,162,244,202,175,102,119,176,96,84,246,126,36,162,107,47,66,119,240,56,174,15,193,150,232,35,102,255,93,87,106,76,22,217,44,203,51,177,113,52,146,83,205,203,120,150,203,102,218,123,61,249,25,167,189,109,71,43,133,246,241,100,127,9,116,67,210,28,235,31,255,244,123,69,10,3,121,111,37,68,117,58,28,114,185,211,194,60,161,112,184,175,69,110,90,97,66,217,114,88,40,99,254,150,250,214,12,63,29,31,255,163,23,121,165,238,82,166,109,108,235,43,178,148,81,245,211,29,144,63,164,139,69,150,146,33,119,63,242,41,114,169,234,151,225,47,67,96,247,118,215,245,156,88,135,49,242,234,219,122,161,222,34,2,67,72,200,17,190,215,183,89,116,210,55,123,112,251,93,61,252,226,191,133,55,211,14,15,199,189,72,33,24,152,15,2,136,255,247,127,142,118,245,249,217,37,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c83cf6a-8570-4d0e-8667-0bfa7f5957be"));
		}

		#endregion

	}

	#endregion

}


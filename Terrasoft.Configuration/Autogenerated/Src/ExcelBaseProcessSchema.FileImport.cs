﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelBaseProcessSchema

	/// <exclude/>
	public class ExcelBaseProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelBaseProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelBaseProcessSchema(ExcelBaseProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b3e9eb0d-23ba-452a-8a56-9c37508070ca");
			Name = "ExcelBaseProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,90,255,111,219,182,18,255,217,3,246,63,112,126,192,32,99,169,210,1,27,30,94,19,43,72,157,164,51,176,182,65,156,109,15,175,43,2,90,166,109,189,74,162,71,74,73,188,46,255,251,142,95,36,145,34,101,41,195,214,31,146,136,186,59,30,239,27,63,119,106,142,51,194,119,56,38,232,150,48,134,57,93,23,225,140,230,235,100,83,50,92,36,52,15,175,146,148,204,179,29,101,197,151,95,124,254,242,139,81,201,147,124,131,46,104,92,102,36,47,174,40,203,112,17,190,223,145,252,191,89,26,94,227,248,19,222,0,193,73,31,229,98,199,8,94,241,45,33,69,67,187,216,243,130,100,237,103,80,40,77,73,44,180,225,225,27,146,19,150,196,14,205,143,73,254,155,179,120,75,30,139,240,134,108,202,20,179,203,71,216,145,115,33,164,161,51,15,157,101,52,247,191,97,164,107,61,188,204,139,164,72,72,135,72,32,184,194,113,65,153,162,0,154,127,49,178,1,21,208,44,197,156,191,66,151,143,49,73,95,99,78,174,25,141,65,59,73,179,43,151,105,18,163,88,144,56,20,232,179,164,169,5,93,37,36,93,129,164,107,150,220,227,130,168,151,59,245,128,132,137,105,158,238,17,216,128,60,162,59,16,149,130,49,203,44,159,231,43,242,168,86,167,40,39,15,138,34,24,127,56,127,241,63,252,226,247,143,223,140,39,39,125,146,110,232,67,167,152,151,47,254,227,200,88,82,154,162,59,190,197,140,172,22,5,3,99,205,193,73,252,103,156,150,132,207,115,176,35,78,147,223,201,202,98,250,49,225,197,41,151,212,81,39,179,197,49,127,71,243,107,194,56,48,66,216,169,227,242,243,205,6,12,134,193,21,160,187,90,210,6,165,236,68,91,148,228,43,101,84,219,194,144,14,176,127,41,220,40,236,44,157,163,205,172,28,213,118,81,240,19,39,12,184,114,21,179,168,180,30,39,104,26,161,22,197,180,69,211,163,209,65,159,191,41,147,21,186,99,148,22,139,120,75,50,252,211,220,54,168,140,216,189,122,167,232,204,21,219,146,142,241,84,52,239,107,27,58,111,36,255,48,221,105,1,135,37,171,74,123,253,216,68,154,114,58,60,239,82,168,79,120,153,146,197,62,91,66,8,77,209,248,238,241,229,203,151,23,119,99,109,168,227,227,99,116,202,203,44,195,108,31,85,11,11,25,43,149,152,68,68,11,186,151,225,18,214,60,199,38,83,163,131,21,116,11,127,204,137,68,28,141,70,27,82,232,191,70,201,26,5,95,13,136,239,73,197,48,154,95,230,80,27,153,56,219,105,123,155,8,57,146,224,228,111,72,225,232,19,252,66,217,39,72,174,79,215,152,21,42,229,224,95,151,34,29,66,212,203,192,97,234,149,103,28,12,68,67,162,16,205,241,164,126,49,82,148,44,63,156,186,138,246,201,141,122,29,75,58,118,32,102,118,132,137,114,219,17,251,221,1,219,249,2,146,177,51,152,209,217,153,212,46,232,166,152,170,74,174,31,225,118,42,78,59,149,136,130,201,196,147,217,135,206,104,229,136,55,202,69,37,65,113,93,57,122,67,187,85,121,90,143,159,17,196,243,9,122,178,205,106,198,23,186,123,48,158,78,58,245,170,120,208,14,200,122,181,178,118,176,30,154,44,19,158,114,246,30,241,38,255,134,69,232,26,167,188,10,81,75,30,188,147,229,193,141,72,239,1,111,160,114,34,46,139,102,239,241,172,154,123,83,151,102,127,9,113,106,50,250,10,238,214,50,77,155,186,81,229,148,183,122,215,153,183,32,197,77,139,32,176,47,134,42,185,15,203,235,53,133,14,120,180,171,110,212,14,131,124,120,191,228,52,37,5,9,198,255,14,191,253,62,252,14,253,129,222,146,98,75,87,40,225,40,7,123,38,242,182,68,56,95,161,135,36,77,209,82,32,143,140,222,131,13,197,171,93,76,51,81,204,151,101,2,151,72,136,198,232,27,169,225,24,194,24,8,224,194,199,43,244,235,184,129,172,63,192,2,64,129,250,170,255,117,60,158,124,180,125,211,7,23,102,45,180,96,86,140,102,177,93,41,12,242,206,218,115,38,202,133,243,178,133,30,38,147,222,43,85,153,176,93,19,189,158,130,13,57,18,216,13,41,61,193,104,0,224,58,220,37,87,32,125,113,134,114,104,19,166,99,38,192,93,131,163,199,209,233,177,124,237,167,22,219,140,163,25,252,12,29,58,21,112,92,190,181,85,57,61,174,222,153,21,72,95,226,194,94,192,33,81,103,160,96,103,75,167,35,164,68,146,38,93,222,226,34,222,162,76,254,156,182,233,67,249,54,16,244,161,224,188,33,107,194,72,30,147,80,214,14,157,32,58,63,164,12,245,226,164,47,39,116,0,16,109,110,89,89,134,218,89,18,143,35,209,189,104,198,78,3,86,219,172,106,194,3,230,211,196,226,156,242,16,129,94,151,172,149,185,36,74,231,101,44,155,141,41,90,81,0,185,36,188,101,123,168,145,156,4,146,246,168,106,176,222,164,116,41,42,171,106,21,223,149,217,146,176,69,177,79,1,99,157,167,41,125,184,32,113,146,225,244,154,38,121,161,74,205,31,67,89,193,71,52,135,140,60,210,197,204,199,53,43,83,56,44,153,231,107,26,206,243,123,204,18,12,41,172,22,143,16,45,11,173,190,254,229,113,105,160,79,58,65,103,38,81,120,75,213,53,18,76,208,43,227,90,56,228,113,153,91,234,10,250,11,62,31,146,45,11,71,120,95,182,40,142,198,225,78,114,128,95,36,52,150,41,5,238,134,231,80,57,186,78,9,109,16,8,70,219,116,29,16,242,67,45,238,227,48,147,97,81,0,116,127,143,232,186,50,161,62,68,33,192,177,66,239,67,77,105,94,234,227,200,6,34,157,182,61,31,172,133,223,230,135,161,124,47,108,71,166,210,149,115,76,150,91,33,89,82,114,239,234,212,146,16,122,89,79,252,82,93,137,32,205,187,139,43,214,138,8,135,39,188,76,137,152,253,112,215,36,193,228,89,9,53,188,139,115,194,193,65,133,227,200,211,26,246,102,157,79,3,127,40,88,221,227,129,94,235,153,221,95,21,21,150,248,54,85,221,227,137,97,140,73,169,237,61,90,83,104,176,225,38,12,218,59,202,147,9,148,213,185,241,200,191,89,120,190,90,5,130,25,74,112,78,152,81,40,158,186,130,163,97,174,130,64,33,156,202,130,247,52,89,33,31,124,149,195,13,27,194,106,229,108,96,43,46,122,103,2,50,114,145,245,180,213,0,133,230,219,183,56,199,27,194,4,74,155,3,182,196,128,10,94,239,65,152,23,68,215,103,24,128,210,234,174,78,113,244,224,135,21,46,48,218,74,32,123,40,228,187,10,89,34,129,176,6,89,110,200,214,48,216,8,70,133,157,21,50,141,42,77,20,148,14,186,232,164,59,35,189,141,242,109,229,154,121,55,30,175,218,232,93,123,193,215,88,247,138,169,131,220,221,113,6,81,47,208,252,182,197,9,251,180,247,22,123,213,239,91,104,252,200,232,222,236,219,176,45,56,148,59,18,181,189,6,249,65,195,124,100,91,202,12,33,116,104,60,208,68,145,49,135,236,174,158,74,43,121,227,15,174,151,235,132,113,200,188,135,113,116,37,254,130,68,122,64,107,70,51,117,9,14,191,65,173,189,91,97,167,6,167,102,44,9,164,33,171,165,142,179,27,177,171,214,164,6,43,208,29,87,107,104,218,106,138,139,173,80,84,148,189,203,108,87,236,149,24,49,154,221,9,133,90,126,12,197,221,43,191,123,132,55,132,211,146,197,100,1,190,135,116,183,74,151,171,160,58,148,248,91,20,217,74,153,230,158,147,84,85,24,202,129,160,193,17,158,231,251,96,242,143,106,108,69,163,220,244,25,157,138,172,52,160,211,224,126,80,4,137,56,254,224,152,16,7,238,168,68,110,72,120,202,139,214,21,246,148,1,194,154,216,112,93,21,107,39,177,78,255,104,99,25,109,17,151,176,151,247,99,147,150,209,158,149,96,146,88,97,253,3,176,163,109,58,117,28,63,240,120,142,237,212,49,59,204,101,97,140,158,242,110,130,12,151,212,193,27,117,235,33,48,134,181,217,8,26,55,83,50,8,54,116,149,30,169,6,85,34,163,12,74,213,139,135,115,254,142,22,239,160,24,188,103,50,147,140,28,27,57,212,32,221,149,112,163,62,50,4,206,199,6,232,116,37,98,9,165,224,122,24,110,218,65,226,31,99,161,34,122,114,211,210,100,251,43,33,246,119,54,147,51,229,138,181,252,44,43,10,140,63,166,218,142,181,92,227,180,147,26,36,199,85,219,168,62,54,52,253,167,225,75,131,212,248,36,217,48,168,33,143,247,147,229,17,114,229,48,253,49,210,43,192,250,82,105,113,107,199,136,64,118,142,26,212,199,56,106,171,121,84,239,55,176,141,249,103,6,2,179,206,73,128,242,158,61,54,235,26,1,136,156,18,219,92,64,152,221,238,119,164,154,55,163,175,191,70,214,139,42,129,166,168,22,199,173,150,176,78,59,109,86,207,4,194,176,189,149,26,173,121,67,51,243,62,115,199,86,190,209,4,122,37,233,123,189,113,65,10,194,178,36,135,180,130,131,235,187,72,151,85,179,226,38,28,17,145,242,131,221,165,36,41,163,140,221,234,173,102,156,117,249,238,112,104,189,16,71,226,75,218,233,113,28,105,53,43,89,106,83,70,214,222,125,143,35,159,226,158,200,144,83,190,57,159,153,220,170,118,14,2,248,220,70,248,86,121,211,239,84,32,136,89,94,96,213,246,200,83,126,161,128,91,213,123,88,78,21,91,162,16,24,138,183,73,10,29,186,248,207,36,135,190,55,253,61,147,162,219,238,109,189,166,150,192,77,208,200,57,13,104,110,45,244,79,129,236,49,1,176,69,106,75,222,158,249,84,146,194,11,194,99,232,32,176,26,188,8,142,234,54,150,79,74,123,245,231,84,203,10,37,214,175,200,108,149,31,172,167,41,10,172,215,19,243,0,178,119,130,223,175,247,208,38,55,219,132,245,167,38,29,41,150,200,103,220,132,155,228,158,64,62,45,255,15,217,32,90,168,156,39,128,115,213,92,70,60,22,56,201,245,125,9,73,71,100,51,175,63,210,85,194,30,146,98,139,202,60,249,13,130,17,152,129,100,157,64,155,210,206,43,171,197,135,188,26,142,137,77,190,200,248,74,232,110,218,29,99,222,64,146,83,17,241,49,179,105,35,15,12,68,172,197,112,182,37,241,167,115,182,145,255,21,75,165,153,208,151,174,3,155,185,138,19,207,236,197,63,244,240,140,60,68,93,55,151,224,89,252,251,19,150,5,21,2,107,38,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b3e9eb0d-23ba-452a-8a56-9c37508070ca"));
		}

		#endregion

	}

	#endregion

}


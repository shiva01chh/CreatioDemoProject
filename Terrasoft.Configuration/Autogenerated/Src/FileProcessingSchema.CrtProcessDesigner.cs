﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileProcessingSchema

	/// <exclude/>
	public class FileProcessingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileProcessingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileProcessingSchema(FileProcessingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("97b94958-703d-4c3a-bee0-59f3011ea524");
			Name = "FileProcessing";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8b1c57bf-1ff6-4af0-890b-4cc1ace5ccaa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,89,75,111,227,54,16,62,123,129,253,15,172,122,81,0,67,70,175,73,108,32,111,24,216,205,238,218,206,246,88,48,18,101,179,149,41,175,72,37,117,23,249,239,157,33,41,137,18,37,199,65,122,104,46,150,72,206,251,155,7,21,65,183,76,238,104,204,200,138,21,5,149,121,170,162,171,92,164,124,93,22,84,241,92,124,252,240,243,227,135,81,41,185,88,147,229,94,42,182,61,235,188,195,249,44,99,49,30,150,209,29,19,172,224,177,119,230,154,42,218,44,186,178,182,219,92,244,239,20,108,104,61,186,190,28,220,186,17,138,43,206,100,223,129,91,158,245,242,196,245,232,226,81,170,130,26,59,154,67,115,220,35,211,67,135,163,185,229,11,68,191,22,108,13,107,228,70,148,219,83,178,96,178,204,212,133,62,182,218,239,24,174,234,99,147,201,132,156,203,114,187,165,197,126,102,223,175,153,98,197,150,11,38,137,218,48,82,104,90,98,100,16,149,19,246,55,139,75,197,162,138,124,226,208,239,202,199,140,199,132,1,255,1,161,35,12,163,39,87,47,44,233,83,45,14,228,228,143,127,66,52,73,138,102,214,52,174,176,17,18,172,114,52,90,142,181,57,3,124,21,196,195,97,108,159,118,180,0,208,129,173,3,220,31,36,155,139,175,69,30,51,41,225,253,197,248,149,137,196,184,182,229,230,171,140,74,121,74,80,149,171,124,183,55,166,203,65,23,47,216,14,148,96,66,73,109,30,137,129,198,170,37,15,249,53,70,49,190,20,244,41,106,92,105,3,74,239,88,129,224,59,37,95,53,229,1,239,220,49,208,34,47,136,196,95,134,160,221,27,165,178,60,166,224,57,216,76,65,55,154,184,1,145,3,62,179,122,206,63,113,169,206,117,6,236,81,219,79,134,213,140,44,243,178,136,153,179,36,201,79,178,102,234,12,197,159,145,151,247,234,25,131,162,138,253,39,170,174,104,1,138,189,166,106,7,15,7,65,50,23,0,182,20,106,220,169,201,102,139,45,200,238,65,160,192,145,39,158,64,38,2,80,55,121,2,112,1,15,96,86,238,106,218,198,200,33,212,240,74,174,47,182,139,156,207,70,204,17,176,1,0,2,190,8,21,80,15,192,131,181,34,152,96,130,61,31,116,189,94,209,233,71,4,164,224,52,0,143,34,7,25,204,190,56,129,51,105,81,237,69,231,19,77,210,112,40,152,42,11,33,103,243,4,225,144,114,230,96,149,138,164,31,12,231,147,138,12,249,116,82,9,173,218,135,70,7,93,86,240,125,105,21,168,53,57,57,59,224,151,133,225,110,160,201,27,205,142,117,5,147,63,130,217,205,242,219,176,185,8,88,180,179,5,254,142,93,131,168,190,107,67,58,52,71,150,241,134,109,233,183,146,21,123,2,10,84,6,190,5,220,78,5,236,195,53,23,27,232,199,42,201,99,50,233,45,104,13,17,233,73,143,46,78,97,52,144,138,66,253,4,164,22,252,9,194,108,246,119,230,5,144,3,251,4,90,35,242,91,176,56,47,18,99,227,61,56,25,230,132,114,43,240,9,250,105,208,221,13,250,141,239,21,237,36,73,101,144,22,12,25,7,109,52,253,14,113,71,146,41,249,237,21,166,183,156,101,201,144,49,8,232,92,100,123,2,29,169,0,241,194,12,57,228,143,178,245,126,140,222,69,25,99,216,143,201,111,157,60,144,224,58,155,185,182,25,42,8,224,14,203,207,185,100,12,243,43,157,6,237,80,5,147,25,81,208,236,143,133,123,219,132,96,134,38,162,19,237,66,43,11,172,139,219,2,195,142,83,218,12,79,136,30,55,70,29,87,65,68,60,223,141,70,135,186,207,255,208,29,30,177,210,29,11,39,92,55,171,31,230,9,240,17,252,71,233,214,163,74,115,67,67,18,32,170,154,170,212,100,239,245,252,152,220,149,60,33,131,58,189,41,50,163,213,16,27,56,63,40,194,13,234,80,86,180,70,165,190,228,211,86,12,139,127,125,36,232,233,173,125,114,0,80,10,92,236,215,227,185,128,107,4,205,248,63,204,219,27,168,222,214,179,240,24,65,136,46,18,152,229,23,124,189,129,246,54,37,41,205,36,59,171,247,175,168,88,64,117,121,16,49,220,127,56,52,75,180,17,125,90,148,206,169,249,90,192,4,125,205,229,46,163,251,239,52,43,153,244,206,128,81,8,107,173,133,41,176,209,92,94,100,207,116,47,151,12,175,101,45,10,211,171,80,91,55,72,149,47,250,186,50,88,130,203,183,20,11,216,17,61,218,58,193,245,208,103,42,232,26,160,207,122,214,166,221,106,26,245,80,158,121,44,45,248,90,75,211,62,1,112,33,85,115,91,53,46,247,128,156,176,158,107,86,30,11,76,15,95,150,241,106,85,13,88,98,223,167,61,58,68,102,79,194,29,81,36,70,156,102,55,170,133,94,85,92,140,35,205,249,70,238,220,241,181,30,52,170,103,223,79,118,162,168,2,115,18,253,206,213,198,224,13,16,67,31,51,150,132,61,214,212,112,5,150,181,86,222,1,171,205,208,52,35,253,235,196,212,27,113,236,64,131,214,155,121,160,232,116,124,160,177,85,13,43,218,138,202,191,30,20,207,244,229,93,59,208,213,10,207,135,61,241,29,27,255,14,22,10,171,193,19,45,108,184,58,74,99,87,25,176,178,242,30,140,254,140,198,27,18,122,71,124,63,64,135,234,113,78,149,20,35,93,212,140,21,186,132,226,123,116,207,158,241,183,18,215,175,171,85,213,83,33,236,1,33,250,106,92,139,169,216,154,15,25,13,99,224,104,154,43,190,132,14,214,198,190,244,113,23,253,214,237,131,184,110,196,242,148,132,221,192,67,133,186,207,213,125,153,101,95,138,155,237,78,1,122,107,23,141,26,225,17,84,151,11,5,216,121,44,21,11,135,167,201,177,135,172,74,248,139,249,241,35,31,93,36,73,232,45,183,93,213,196,17,235,119,227,31,204,188,208,11,114,69,219,108,68,250,82,211,8,177,39,94,220,66,140,49,237,86,93,235,136,158,43,251,180,7,91,173,4,232,156,246,237,54,26,28,211,160,223,112,35,181,35,26,218,242,250,183,35,111,122,114,60,27,204,156,129,238,213,15,110,21,17,92,108,234,193,240,240,160,150,54,158,8,102,183,206,53,78,95,239,171,219,243,97,30,157,68,8,102,53,242,43,227,99,211,133,143,227,82,165,75,15,159,178,59,59,14,95,77,175,236,141,219,170,239,222,72,237,8,105,199,28,131,108,39,239,135,26,206,216,47,53,196,113,159,69,221,235,109,210,142,163,158,189,85,190,27,133,82,63,201,140,142,97,234,101,24,22,148,110,47,254,5,170,35,84,147,186,136,164,94,245,232,80,216,70,173,103,42,83,66,124,13,221,116,245,25,6,246,146,25,140,157,27,231,73,107,202,74,237,215,230,214,5,167,123,33,119,103,252,183,127,17,177,6,91,129,61,243,154,251,237,228,56,69,222,249,9,163,25,130,33,160,135,102,232,102,60,192,134,151,242,183,182,101,59,84,72,119,156,192,129,120,145,231,202,105,132,230,176,29,133,101,53,17,227,65,176,199,44,27,125,58,243,149,149,98,254,9,16,94,95,222,232,175,239,144,5,201,99,253,216,55,188,202,18,38,246,203,102,201,105,109,150,215,28,199,20,156,254,97,252,77,154,199,169,213,46,50,236,153,89,14,27,113,78,143,124,222,96,194,132,13,117,132,63,110,23,213,78,229,56,99,56,135,192,98,7,247,231,152,153,179,48,128,226,83,53,47,47,22,131,99,71,227,246,49,136,105,232,221,56,234,38,235,39,112,221,150,95,252,126,232,146,31,232,82,125,95,196,244,26,254,253,11,61,138,144,250,211,26,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("97b94958-703d-4c3a-bee0-59f3011ea524"));
		}

		#endregion

	}

	#endregion

}


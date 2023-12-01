﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileServiceBase64ImageParserSchema

	/// <exclude/>
	public class FileServiceBase64ImageParserSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileServiceBase64ImageParserSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileServiceBase64ImageParserSchema(FileServiceBase64ImageParserSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9a697e77-a493-44ef-98b3-7dad600378fd");
			Name = "FileServiceBase64ImageParser";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,87,91,79,35,55,20,126,206,74,251,31,142,178,47,19,53,56,84,170,42,149,144,180,133,0,141,180,233,34,18,218,7,160,43,51,57,129,145,230,146,181,61,129,104,149,255,222,227,91,198,51,9,65,106,65,202,140,143,207,229,59,87,123,114,158,161,92,242,24,97,134,66,112,89,44,20,59,47,242,69,242,84,10,174,146,34,103,19,158,164,73,254,244,241,195,247,143,31,90,165,164,87,152,174,165,194,172,223,88,179,207,73,254,109,135,56,254,178,67,26,113,197,119,137,130,191,208,242,45,58,27,103,252,105,223,254,12,95,21,187,193,167,50,229,226,226,117,41,80,74,66,45,43,190,208,47,129,111,209,217,232,236,205,173,139,92,37,42,65,173,147,88,62,9,124,34,11,112,158,114,41,79,224,50,73,113,138,98,149,196,120,198,37,254,252,147,6,138,215,92,72,20,134,191,215,235,193,169,44,179,140,139,245,208,173,111,80,3,197,92,73,136,181,26,88,20,2,150,36,163,173,255,49,155,124,54,74,46,82,204,136,7,100,81,10,74,144,122,230,10,132,151,196,57,112,73,203,148,178,180,66,40,69,2,82,9,45,79,216,18,218,23,57,79,193,217,35,17,171,35,50,74,248,138,114,202,31,83,132,85,194,67,15,58,90,178,32,184,136,16,11,92,12,218,239,84,5,11,124,110,247,134,204,251,219,11,28,94,150,143,105,18,59,71,15,133,11,78,96,188,39,134,45,93,120,85,216,41,185,138,83,228,78,224,90,36,43,174,208,68,185,181,180,11,136,245,190,15,133,201,220,122,26,63,99,198,111,199,115,210,72,229,78,161,249,147,30,48,128,54,214,247,219,253,55,53,221,96,92,136,249,30,21,194,109,28,144,189,21,201,53,87,58,35,154,165,53,128,223,218,255,220,51,250,239,81,94,212,125,47,136,201,125,239,10,149,94,223,247,162,95,79,191,31,111,134,119,199,71,191,252,126,116,201,143,22,247,71,15,63,116,44,253,199,29,122,221,188,64,62,47,242,116,13,183,20,65,138,88,142,177,206,90,99,105,235,185,245,9,243,185,13,174,91,135,145,22,101,172,10,161,131,109,178,232,98,109,51,122,40,151,81,195,114,89,91,118,192,228,180,213,96,26,52,216,140,79,155,195,40,39,168,158,139,249,91,213,64,131,1,95,129,98,106,94,34,111,215,37,70,104,226,84,9,50,108,41,236,178,16,25,87,81,149,177,238,193,26,234,238,175,139,142,1,222,18,168,74,145,67,142,47,22,71,228,237,117,237,250,203,82,59,41,217,248,41,167,49,115,78,33,236,132,30,123,31,30,215,10,239,30,72,132,207,245,228,140,174,202,100,14,141,202,237,130,161,250,98,244,126,174,184,128,57,201,144,131,26,133,209,116,252,96,209,133,126,213,212,17,115,61,47,44,100,157,240,156,146,44,24,197,116,108,58,145,146,191,38,4,81,3,81,39,180,226,244,147,230,144,139,157,83,157,42,180,44,141,130,113,226,83,76,105,13,210,60,70,149,39,150,222,148,49,34,45,154,84,105,153,229,81,91,243,183,61,241,82,20,153,195,200,172,121,147,41,183,251,247,51,10,140,218,212,198,29,54,150,23,223,74,158,70,86,13,219,102,54,218,70,183,163,71,175,133,96,97,218,99,35,26,157,93,188,98,92,82,195,0,250,151,61,193,148,165,192,209,89,69,138,58,62,95,94,209,88,67,215,9,167,161,40,236,99,16,4,129,89,51,104,57,34,111,171,82,211,74,22,16,89,65,166,153,2,11,173,150,43,8,187,125,103,163,244,160,61,178,133,214,119,124,27,251,180,143,77,88,208,115,119,126,55,11,213,148,160,233,53,27,167,104,194,85,252,12,153,254,221,233,60,203,66,56,204,54,187,18,69,185,148,119,123,219,233,129,253,197,211,18,107,77,165,109,49,51,106,170,180,28,194,212,232,226,3,208,26,117,220,68,120,104,28,188,3,116,111,135,52,240,58,16,186,187,244,48,157,36,25,206,214,75,140,204,10,18,253,235,241,26,146,29,88,250,254,160,31,3,203,193,110,248,139,221,232,87,156,231,197,28,227,113,190,40,232,112,162,55,226,173,147,153,183,57,66,205,32,100,212,97,151,137,144,42,250,10,131,33,124,117,179,113,60,130,193,192,217,99,218,185,250,176,51,186,153,135,189,207,195,224,168,216,186,185,47,29,251,198,28,129,222,147,75,43,214,175,164,130,234,10,203,49,228,115,67,213,132,235,140,222,37,241,110,39,236,206,112,173,151,88,43,72,70,173,255,245,184,205,164,27,81,19,204,10,177,166,105,143,60,139,42,59,85,39,26,154,79,131,153,79,142,57,147,206,206,38,172,75,186,82,40,125,27,28,232,131,121,133,66,177,89,97,99,57,53,12,161,141,126,40,152,185,100,216,104,212,203,202,22,212,206,113,21,228,40,242,226,93,143,160,86,183,239,31,203,193,189,161,121,21,54,4,231,141,164,251,237,182,252,183,183,92,115,217,132,98,1,60,183,241,166,11,42,112,168,148,253,143,139,234,238,77,213,82,150,186,165,33,167,126,30,180,165,136,219,195,169,189,59,135,40,148,238,34,155,133,211,158,17,216,47,111,184,219,67,127,82,106,29,218,205,255,140,27,104,176,123,67,254,123,225,133,70,183,44,227,152,190,124,22,101,218,133,130,44,136,151,68,34,228,101,154,238,226,179,121,150,195,27,251,4,186,227,161,214,251,190,190,5,79,37,146,66,175,33,184,11,62,22,69,10,51,177,182,147,206,165,145,162,71,226,165,170,245,124,109,134,249,30,208,72,93,99,106,69,137,52,122,116,3,27,155,253,237,109,134,202,139,190,242,124,99,155,59,157,221,12,38,136,57,220,52,27,51,196,136,96,56,38,125,44,218,105,62,181,14,110,155,81,137,117,117,120,58,80,219,233,20,14,14,218,174,192,233,208,57,242,6,98,99,59,186,120,141,113,233,46,185,240,230,25,234,149,28,232,37,75,173,19,137,70,127,255,2,150,1,138,108,181,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9a697e77-a493-44ef-98b3-7dad600378fd"));
		}

		#endregion

	}

	#endregion

}


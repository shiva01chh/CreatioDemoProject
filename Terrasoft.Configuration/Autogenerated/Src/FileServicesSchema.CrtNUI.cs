﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileServicesSchema

	/// <exclude/>
	public class FileServicesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileServicesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileServicesSchema(FileServicesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6ea11376-0063-46ad-9150-87f7f849558d");
			Name = "FileServices";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,25,219,110,219,70,246,89,5,250,15,83,22,40,104,192,161,218,45,118,177,72,44,5,190,72,137,182,177,149,149,236,245,131,209,135,17,57,146,102,75,145,204,112,232,84,53,244,239,123,206,92,200,225,69,82,28,103,243,16,75,103,206,109,206,253,140,18,186,97,121,70,67,70,110,153,16,52,79,151,50,184,76,147,37,95,21,130,74,158,38,193,152,199,108,206,196,35,15,217,247,223,61,125,255,93,175,200,121,178,34,243,109,46,217,230,77,227,123,240,46,78,23,52,230,127,41,218,214,233,100,218,2,25,214,215,105,196,226,131,135,193,121,40,249,99,55,223,26,222,61,91,180,16,102,69,34,249,134,33,34,223,175,30,80,2,70,158,195,217,92,82,201,42,4,215,56,155,141,75,218,60,9,254,149,239,59,110,90,245,46,139,83,26,117,227,10,22,140,64,101,201,89,190,23,97,76,67,153,138,67,24,174,93,64,190,20,64,209,133,140,218,4,231,139,92,33,128,122,157,28,193,58,231,89,182,231,228,128,93,240,244,189,148,89,83,0,160,254,40,216,10,190,145,203,152,230,249,107,82,11,53,56,238,247,251,228,140,39,107,112,154,140,210,144,132,130,45,7,94,151,220,224,130,230,150,212,35,253,161,37,206,139,205,134,138,173,253,142,2,72,174,209,2,139,211,111,32,181,37,238,9,143,96,50,99,52,154,38,241,214,133,26,241,15,70,27,107,246,223,17,118,158,103,55,76,130,202,25,68,193,130,199,92,110,103,236,83,193,5,219,176,68,230,190,251,5,157,70,6,228,8,9,98,5,6,16,157,160,144,172,88,196,28,52,71,147,186,22,37,175,137,99,164,83,210,169,60,208,63,41,211,55,93,243,142,201,233,226,191,44,148,31,120,242,199,12,74,6,248,80,59,233,168,151,246,70,162,114,154,229,101,204,214,114,155,2,128,116,146,42,241,36,6,249,68,24,162,160,164,112,157,216,123,184,162,146,186,134,175,27,165,243,46,198,60,213,213,122,214,18,165,41,62,138,52,99,2,83,242,53,249,168,24,26,132,150,206,10,50,173,20,14,42,180,154,162,90,211,107,182,89,48,225,223,64,41,6,135,123,105,169,155,167,28,90,106,95,41,237,126,124,34,43,38,223,64,84,195,127,59,171,49,75,34,173,180,6,24,120,19,220,240,113,197,212,113,108,211,21,205,91,61,219,250,174,148,23,219,88,213,200,45,201,195,53,219,80,146,128,5,159,101,106,166,200,231,138,26,97,13,131,67,185,194,82,54,106,96,117,154,188,91,191,25,11,83,17,17,30,161,164,37,103,226,89,234,9,69,61,137,26,106,189,43,120,100,56,79,162,111,225,255,154,209,5,54,89,147,218,153,254,66,176,124,163,71,217,159,146,92,22,66,192,109,236,215,193,208,61,61,15,67,168,38,169,8,32,199,38,73,46,105,18,50,255,228,205,97,241,215,76,174,211,104,159,236,185,20,140,110,200,7,104,149,88,205,124,117,123,215,113,119,147,232,84,219,100,9,231,147,232,132,60,41,35,204,33,205,11,185,74,193,133,54,171,149,150,137,188,221,102,90,43,192,122,164,130,44,138,229,146,9,176,120,194,62,131,54,155,84,108,181,84,23,137,67,11,0,148,59,104,31,192,38,97,170,143,5,110,108,92,211,132,174,152,190,59,32,95,108,65,51,191,161,169,195,16,181,157,177,44,205,57,116,241,45,176,70,9,129,242,253,15,224,252,49,99,234,194,158,34,232,189,213,89,170,123,254,22,101,156,141,107,12,134,62,106,15,170,65,212,22,136,116,46,86,5,246,8,223,43,106,58,123,167,141,75,156,156,104,17,175,59,68,24,37,190,141,24,125,247,250,189,131,187,210,45,218,230,211,4,5,162,187,201,64,235,213,48,57,154,55,31,51,42,11,193,70,9,93,196,44,242,189,253,92,60,35,118,82,141,92,147,100,153,234,96,193,15,131,134,39,130,50,212,90,81,166,3,236,84,197,201,5,79,32,121,239,161,233,65,198,234,8,178,55,228,75,226,87,236,33,172,138,56,182,81,217,19,12,20,79,76,88,7,55,112,164,137,118,71,130,246,3,75,86,114,237,195,183,71,200,213,224,54,157,36,242,215,191,149,114,0,32,105,172,46,173,16,173,46,166,134,133,154,201,21,207,213,53,49,237,6,216,8,27,66,156,243,138,51,50,197,176,52,28,235,5,32,176,28,130,243,40,122,15,35,5,88,195,51,220,94,57,236,32,28,218,58,24,142,215,48,154,99,78,2,171,34,150,100,83,255,58,32,246,252,138,73,134,33,135,33,96,97,207,86,211,169,1,192,186,46,43,120,79,243,145,16,169,176,57,231,209,44,131,146,171,102,246,126,26,74,38,95,229,202,113,158,77,153,6,3,252,8,242,127,132,16,184,25,221,142,103,231,215,163,251,233,236,183,178,73,144,219,233,213,148,204,110,174,94,253,242,235,63,254,254,79,76,17,66,205,92,76,104,198,9,135,196,2,43,146,116,137,237,135,242,213,90,146,34,135,186,130,144,251,203,49,34,233,38,50,133,154,173,20,179,165,56,180,37,153,52,143,2,99,140,42,60,45,238,15,141,232,236,90,168,46,215,20,146,47,206,213,20,111,237,120,13,117,30,180,50,173,99,91,142,100,77,184,201,225,30,166,204,87,51,55,202,245,122,58,192,114,184,98,9,234,61,148,225,134,198,247,126,135,195,47,240,189,37,223,153,15,59,109,27,155,47,107,71,27,171,198,111,12,171,244,215,94,66,85,118,35,196,88,63,176,169,94,71,133,62,252,176,71,62,94,110,143,165,203,42,130,109,150,47,219,133,136,235,117,64,119,172,70,33,108,1,127,250,169,19,174,146,172,29,52,186,69,155,252,54,5,181,147,52,192,165,195,118,85,91,10,13,157,91,6,117,61,13,198,113,145,175,45,186,129,205,25,251,195,255,249,148,224,223,169,224,43,14,203,31,204,17,182,150,24,158,26,249,205,23,12,63,206,244,145,98,121,97,209,129,233,23,10,79,94,58,160,188,112,228,84,213,181,138,80,242,72,227,98,223,122,162,32,25,21,96,50,156,88,7,222,210,84,46,111,168,204,171,198,216,179,190,194,168,8,244,197,242,225,229,49,161,103,125,139,170,199,40,115,43,242,200,133,44,104,108,167,218,195,197,223,32,89,205,172,171,113,110,169,183,121,104,255,102,112,234,156,9,214,213,108,8,29,160,158,151,206,44,36,246,106,130,217,220,156,74,174,210,207,73,108,154,52,106,55,74,66,72,67,49,244,91,170,213,131,98,191,20,96,155,96,201,84,236,124,123,235,211,103,205,31,119,34,254,72,229,90,43,51,78,133,101,105,181,244,76,75,222,29,136,175,57,198,87,106,170,66,59,208,98,213,218,247,132,85,219,211,143,41,12,197,71,39,10,14,140,115,254,87,233,227,125,197,211,212,222,170,220,106,122,85,112,145,30,38,144,185,138,26,255,18,58,33,24,71,101,253,36,1,255,114,10,252,52,240,197,54,144,80,188,191,149,5,244,34,112,228,222,245,129,97,255,68,240,188,98,227,236,182,157,86,80,3,48,6,226,151,22,145,198,176,234,13,221,213,132,0,164,93,82,154,53,8,169,84,5,106,32,63,212,230,137,114,173,127,184,103,11,72,6,255,78,240,91,182,201,98,220,214,192,64,0,66,38,253,167,134,70,187,254,147,22,178,51,251,172,89,103,77,247,48,100,182,242,180,102,111,167,34,85,59,158,73,236,114,98,199,58,132,171,96,107,237,210,51,187,58,50,28,142,7,226,139,92,160,235,121,205,7,221,117,253,255,227,4,91,34,235,94,64,165,142,184,193,18,118,249,65,213,196,110,71,212,46,234,210,124,249,202,108,158,11,46,182,170,6,55,229,214,43,121,231,138,22,220,217,221,236,121,126,158,233,118,233,190,48,190,48,233,236,131,148,243,238,115,208,239,40,18,169,213,131,222,33,34,219,217,167,93,143,161,245,198,175,240,217,159,33,203,84,27,213,175,178,248,46,113,147,202,113,90,36,209,200,158,121,195,219,181,72,63,231,228,243,154,37,198,121,246,6,169,208,66,146,84,146,37,82,129,148,146,233,215,21,135,234,1,176,171,68,104,83,236,96,88,176,5,24,90,233,134,226,84,9,28,205,204,171,65,234,167,22,211,163,47,210,104,59,151,219,152,213,240,74,104,112,65,161,245,184,225,222,253,8,92,131,30,43,69,90,85,119,52,42,155,149,158,136,186,101,216,161,185,80,111,101,128,10,67,147,94,71,204,14,34,69,185,241,188,44,173,204,106,83,207,46,124,148,218,91,38,237,100,142,151,249,84,48,245,44,133,200,46,243,127,35,188,70,105,169,20,5,190,3,92,166,113,177,73,124,15,223,52,189,250,41,100,173,132,41,2,177,124,13,185,132,186,163,166,36,128,223,115,185,254,136,33,207,16,201,215,64,245,227,135,224,224,108,236,193,193,232,19,116,246,83,226,169,109,207,184,191,135,197,64,13,160,185,49,4,154,28,49,220,91,153,228,52,17,62,208,55,68,235,232,3,191,110,81,167,148,24,79,159,144,183,111,141,60,137,25,163,16,58,83,202,247,204,203,239,211,207,187,42,119,96,185,39,79,191,96,108,107,134,167,53,151,6,78,153,51,63,162,249,232,7,61,94,128,186,26,25,245,213,181,250,63,56,238,91,35,151,203,88,155,116,166,183,3,237,201,185,3,242,245,185,67,219,120,46,194,201,206,193,87,219,219,109,58,74,170,21,14,43,178,41,63,206,111,18,3,130,169,25,92,177,220,252,222,202,206,170,211,161,111,184,151,60,204,14,174,255,236,8,12,87,225,154,248,165,49,9,115,30,207,140,48,152,233,212,67,13,206,152,62,171,22,74,123,92,38,215,146,198,57,115,87,203,198,46,112,96,106,211,208,58,80,193,220,127,255,3,5,173,164,44,65,31,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6ea11376-0063-46ad-9150-87f7f849558d"));
		}

		#endregion

	}

	#endregion

}


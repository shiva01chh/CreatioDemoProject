﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TaggingManagerSchema

	/// <exclude/>
	public class TaggingManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TaggingManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TaggingManagerSchema(TaggingManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1c3b9698-5711-47a9-9751-4e71722bca1f");
			Name = "TaggingManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,89,73,115,219,54,20,62,43,51,249,15,24,181,7,105,70,3,245,210,75,98,105,198,107,71,157,44,174,229,182,135,78,15,8,9,73,156,112,145,1,208,169,154,209,127,239,195,70,2,36,40,81,182,115,106,114,112,76,240,173,223,91,240,30,157,147,140,242,45,137,40,186,167,140,17,94,172,4,190,44,242,85,178,46,25,17,73,145,227,123,178,94,39,249,250,245,171,175,175,95,13,74,14,191,162,229,142,11,154,225,119,73,254,240,182,58,116,249,179,172,200,187,223,224,95,121,215,107,70,187,206,241,117,46,18,145,80,222,73,112,67,34,81,176,14,138,15,101,130,151,148,61,38,17,125,95,196,52,197,87,68,16,112,84,48,224,234,197,112,253,143,160,57,7,68,28,249,202,166,221,50,218,208,140,160,89,151,197,216,37,3,102,96,255,129,209,53,136,66,139,92,80,182,2,248,223,160,133,1,250,61,201,201,154,50,69,54,157,78,209,25,47,179,140,176,221,220,60,87,44,168,88,33,161,121,80,166,153,176,229,153,58,76,219,242,83,154,68,40,169,248,90,154,6,50,180,45,101,234,224,60,142,185,212,2,63,10,196,104,84,176,152,227,138,122,218,36,63,219,18,70,50,148,67,86,205,134,134,252,154,63,0,144,9,73,147,127,105,60,156,215,191,35,170,112,65,92,227,247,80,82,182,147,78,89,53,103,83,37,45,44,92,218,116,178,100,201,212,22,203,168,40,89,206,231,151,69,153,11,73,182,101,69,68,57,7,57,181,41,150,72,114,1,148,18,24,128,145,143,184,96,50,0,33,95,39,200,188,108,217,58,214,89,16,134,252,142,102,197,35,53,168,175,88,145,125,199,221,193,93,163,243,60,232,7,123,93,132,52,143,117,29,122,53,121,153,18,206,223,160,158,229,120,223,163,2,255,186,162,43,82,166,226,34,201,99,160,29,137,221,150,22,171,81,163,14,199,19,244,1,32,134,62,50,244,95,12,199,127,215,101,28,73,235,26,198,161,64,247,144,53,45,49,179,94,221,178,98,75,153,108,71,111,224,247,228,145,8,170,9,182,250,1,253,206,41,131,134,152,211,72,182,253,230,227,87,180,166,226,45,226,242,199,222,72,246,225,171,241,131,112,2,250,165,236,198,82,153,178,219,232,210,62,248,182,142,26,170,74,239,113,140,84,115,26,136,77,194,113,131,114,214,160,149,161,29,28,177,238,61,21,155,34,238,2,193,237,212,191,169,236,189,100,20,94,180,206,47,118,117,74,65,126,217,92,164,193,36,36,108,93,102,80,26,50,188,214,159,71,194,0,205,20,12,215,122,102,70,211,178,62,187,129,218,247,181,52,196,123,114,149,243,3,93,46,93,86,107,137,149,130,145,99,64,72,218,222,7,199,225,236,99,236,11,64,34,7,5,124,69,185,229,63,115,20,206,125,52,140,255,14,63,190,220,208,232,243,185,85,84,166,233,232,199,161,35,44,70,95,93,43,246,67,31,66,71,82,8,140,174,76,129,220,94,228,119,170,37,121,233,162,143,248,121,174,175,141,54,187,105,99,206,209,68,153,211,166,148,61,205,121,118,225,3,72,0,182,156,126,105,219,215,40,51,111,40,49,149,56,81,157,199,154,111,241,0,153,24,138,69,54,51,37,232,178,72,203,44,199,11,126,158,126,33,59,174,67,2,90,161,228,105,205,1,218,206,227,44,201,239,146,245,70,112,120,189,34,41,119,222,223,36,41,204,35,28,191,43,214,73,68,210,143,208,156,136,41,234,230,209,18,82,38,18,24,160,123,91,57,170,209,210,66,186,60,214,111,193,220,84,187,44,19,102,210,37,253,35,27,215,210,1,225,111,33,122,5,83,33,137,54,200,68,223,56,1,147,89,32,248,248,23,42,52,153,163,197,15,225,216,70,126,224,162,129,97,50,145,230,96,157,143,250,240,207,68,108,110,229,237,75,37,232,35,107,126,6,55,114,2,53,118,15,23,18,190,126,40,73,10,41,160,163,191,136,135,58,255,172,116,155,3,58,252,127,144,180,164,99,227,215,62,232,29,128,40,93,107,100,235,73,126,85,113,120,182,83,144,215,149,63,32,245,168,51,110,138,74,221,46,194,227,118,22,75,146,202,88,191,143,0,217,41,253,227,104,207,118,187,176,215,191,143,116,86,218,82,56,115,249,241,69,153,164,170,111,55,130,97,156,109,114,7,187,107,219,169,112,139,109,75,59,216,46,2,186,203,252,243,18,122,56,154,233,152,170,125,203,223,91,151,178,53,9,1,144,112,153,115,42,198,13,223,84,178,147,88,173,130,86,226,112,130,126,254,169,211,204,211,250,160,205,128,166,152,80,62,200,217,22,204,116,250,175,185,49,212,116,28,184,47,68,240,162,233,123,25,116,112,215,153,189,224,87,9,7,244,2,173,29,146,93,251,62,170,123,69,43,231,251,212,57,86,190,157,56,181,21,2,184,105,124,96,129,186,213,107,132,220,88,73,28,235,229,227,180,213,201,129,228,69,23,167,19,229,190,208,218,180,181,152,169,36,51,232,216,253,181,215,32,18,232,86,7,134,16,102,19,215,198,29,50,232,105,23,156,119,35,251,2,159,112,173,120,210,252,236,7,129,199,199,35,169,99,1,171,13,201,35,122,177,147,13,109,20,154,151,142,222,242,181,133,213,69,119,224,238,12,80,15,244,85,1,3,209,146,60,186,19,103,187,172,39,33,228,239,138,66,232,103,44,189,176,52,19,169,207,56,97,174,193,189,91,213,45,243,219,245,27,172,71,109,45,183,78,25,60,116,206,247,45,76,93,26,195,249,181,91,41,135,11,142,57,48,72,55,135,115,13,140,45,51,73,213,71,66,197,103,44,62,86,229,195,57,68,164,147,216,22,230,125,8,140,174,186,53,94,183,54,12,175,122,141,95,213,32,208,244,223,86,113,21,237,58,215,220,234,117,82,200,16,204,44,220,238,132,18,46,174,22,51,134,59,248,138,174,156,57,139,143,14,209,58,132,246,118,113,34,56,105,57,213,91,150,68,13,70,90,212,49,252,157,102,146,146,212,61,22,123,119,97,75,230,179,234,5,254,131,4,134,170,255,223,22,206,69,81,164,148,228,232,81,66,141,196,134,8,36,63,171,69,10,50,94,70,242,114,91,193,56,186,83,48,29,45,173,79,32,14,117,246,211,231,212,151,179,189,187,53,38,228,84,108,215,54,231,99,141,171,150,123,189,219,85,225,118,106,44,173,181,213,180,71,128,0,220,32,190,104,103,138,222,31,75,59,103,108,98,234,35,235,247,201,41,56,57,57,95,160,191,193,240,164,135,246,147,190,37,133,116,54,53,212,179,79,229,179,187,95,128,202,3,203,7,216,228,108,6,125,6,251,251,226,29,108,15,163,49,190,41,216,53,12,54,35,19,167,217,188,254,128,95,101,187,126,55,246,219,102,208,204,163,173,83,11,71,142,244,190,249,235,180,105,213,135,236,195,11,246,163,24,54,68,209,179,35,181,81,170,59,137,61,234,238,40,14,17,190,82,90,159,212,38,142,111,99,206,183,125,0,229,44,201,55,80,154,34,46,34,52,157,59,31,252,159,255,7,179,246,122,225,127,201,232,249,153,62,168,85,67,33,211,160,88,5,41,198,141,69,228,73,170,91,62,77,144,81,217,246,214,47,133,198,198,214,187,220,247,253,2,243,236,191,168,125,143,141,123,39,156,26,158,70,145,133,254,52,169,206,156,127,255,1,199,28,164,104,181,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1c3b9698-5711-47a9-9751-4e71722bca1f"));
		}

		#endregion

	}

	#endregion

}


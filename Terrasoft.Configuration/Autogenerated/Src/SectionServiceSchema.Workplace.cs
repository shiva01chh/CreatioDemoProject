﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SectionServiceSchema

	/// <exclude/>
	public class SectionServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SectionServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SectionServiceSchema(SectionServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("69e688f5-79ee-45b6-b372-e56d1cdaed4c");
			Name = "SectionService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a77104ae-5f68-4069-bd8c-b88c3fda022c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,91,79,219,72,20,126,78,165,254,135,81,186,15,142,20,57,239,64,82,5,10,85,86,229,34,2,229,1,85,43,199,62,9,222,250,214,153,49,144,69,252,247,61,115,177,61,99,59,36,84,192,110,161,85,213,146,153,115,230,220,191,115,102,66,226,197,192,50,207,7,114,6,148,122,44,157,115,119,47,77,230,225,34,167,30,15,211,196,157,130,47,254,127,255,238,238,253,187,78,206,194,100,65,166,75,198,33,222,174,125,70,190,40,82,196,204,253,12,9,208,208,111,208,124,9,147,31,141,197,211,60,225,97,12,40,138,134,94,20,254,35,5,55,168,112,247,58,244,225,48,13,32,122,112,211,29,163,18,215,235,15,113,47,96,86,17,28,193,13,71,205,133,3,254,100,38,167,233,152,56,94,181,99,186,236,196,91,192,62,154,196,151,237,180,20,220,3,207,231,41,13,129,181,81,160,94,149,44,220,31,12,6,100,135,229,113,236,209,229,72,127,62,161,233,117,24,0,35,227,147,9,73,51,80,162,25,185,9,249,21,97,69,24,10,230,129,193,125,169,125,128,58,115,138,106,124,19,107,99,150,29,1,71,161,25,158,51,11,35,212,253,20,126,228,33,133,24,18,206,28,243,131,112,30,25,146,53,44,130,202,213,11,65,79,8,201,242,89,20,250,196,143,60,198,136,78,43,173,203,22,217,245,24,232,15,72,122,39,237,238,124,160,176,64,34,178,39,88,182,200,81,202,199,65,28,38,33,227,202,92,233,100,116,226,41,230,48,154,11,138,171,238,46,185,112,10,25,5,38,20,35,84,83,43,95,37,41,39,94,117,42,4,4,244,169,110,121,152,233,190,206,229,39,143,123,166,243,108,195,214,42,73,182,136,149,46,218,234,114,91,156,40,106,173,197,16,185,82,149,25,73,231,165,178,228,230,42,244,219,172,153,45,209,96,63,165,129,178,167,197,32,101,209,33,196,51,160,206,17,2,2,6,183,59,195,96,74,174,174,140,93,105,228,100,63,201,99,204,182,89,4,59,40,2,19,119,68,118,11,90,114,71,22,192,183,49,255,240,159,123,21,141,39,179,162,74,242,71,26,114,92,50,110,100,75,69,94,55,167,211,209,54,125,128,36,80,169,105,231,41,22,37,50,11,67,182,200,137,148,161,246,51,42,240,8,200,164,66,134,67,47,193,159,41,249,43,171,47,109,63,144,197,130,159,145,88,17,174,200,207,194,184,166,172,230,138,202,51,52,146,12,71,45,170,144,143,31,101,58,118,58,78,203,230,80,213,165,130,178,37,66,62,223,105,10,29,57,9,220,136,132,71,7,231,130,112,76,23,185,0,8,167,155,251,221,62,57,103,64,113,55,81,185,208,235,245,182,165,64,182,82,165,33,185,246,162,28,182,55,8,199,33,240,171,52,16,177,80,254,127,192,177,123,20,144,128,225,6,0,241,41,204,135,221,137,134,40,45,184,59,24,145,48,206,34,137,110,50,63,72,136,70,121,137,15,43,2,33,87,50,143,122,49,73,48,25,135,93,190,204,160,59,210,199,22,81,36,98,213,221,25,72,194,138,143,2,207,105,194,70,63,167,208,206,160,224,183,210,207,62,128,96,196,236,21,71,85,129,84,169,167,147,67,29,212,18,106,155,245,145,113,238,171,180,90,201,163,59,216,153,240,88,95,233,211,123,92,200,141,242,187,44,75,218,130,237,75,236,179,147,228,58,253,14,142,98,19,112,113,114,60,61,67,137,187,105,176,156,242,101,36,32,4,201,14,129,49,180,178,92,117,47,168,151,101,16,40,51,68,151,3,198,15,82,26,123,220,98,80,75,114,160,232,147,2,225,31,166,235,153,45,165,13,161,208,249,114,186,242,162,113,18,76,89,166,227,192,156,207,121,24,20,173,127,18,20,241,187,246,104,153,106,195,150,144,119,245,97,93,93,121,130,30,59,100,30,9,13,69,124,190,32,8,23,194,29,77,196,233,82,31,47,233,139,121,3,57,10,108,18,130,48,233,85,237,150,42,86,218,169,115,58,74,146,59,14,130,83,47,89,192,100,142,237,115,255,22,37,150,180,12,103,54,209,41,28,38,0,129,185,103,233,84,234,226,148,88,33,145,185,227,123,28,59,135,179,127,235,67,38,83,76,43,120,111,102,177,18,103,38,210,171,203,141,194,215,99,132,201,80,108,34,255,69,74,191,103,17,78,249,42,71,110,138,143,79,148,37,70,204,81,106,24,9,169,165,200,50,246,166,212,237,102,80,86,135,249,77,132,235,2,103,209,52,231,88,207,95,67,184,113,54,142,203,116,122,178,46,38,187,75,1,163,206,180,130,84,87,71,243,173,199,65,84,131,140,2,118,167,64,65,213,36,248,105,32,53,66,161,61,106,4,225,20,34,49,200,86,66,106,80,248,203,251,85,143,14,149,95,68,162,49,43,145,131,80,110,224,124,164,91,203,167,114,65,151,68,31,71,24,94,118,153,57,222,148,61,1,234,198,137,196,152,12,144,216,218,187,252,214,19,193,21,238,254,42,102,68,230,136,193,33,157,155,52,216,53,138,206,85,169,35,250,143,99,28,108,100,61,254,120,142,238,163,78,175,79,28,84,174,103,144,89,253,71,135,92,248,5,67,119,141,215,128,242,61,3,142,103,127,139,146,170,4,190,146,152,175,192,180,226,198,43,48,173,118,23,166,52,165,207,83,96,154,248,40,77,198,230,205,177,188,155,170,202,219,243,178,214,73,228,217,67,161,131,240,220,17,89,255,250,128,174,178,137,52,40,33,205,238,82,92,223,84,116,196,197,107,234,95,65,236,157,219,17,42,95,79,84,9,175,23,168,171,173,122,36,104,27,43,251,5,145,113,251,110,163,83,5,87,245,59,102,223,104,90,211,102,255,150,3,77,170,217,165,54,188,10,75,145,177,113,115,21,73,37,253,97,187,66,15,174,225,156,56,138,19,213,204,163,168,68,21,163,155,74,251,53,253,125,37,48,169,185,31,133,219,102,184,70,13,21,9,91,143,25,186,51,92,92,225,152,44,148,112,167,75,157,223,13,61,11,53,92,203,255,181,195,220,242,181,167,201,101,7,164,201,88,237,63,52,141,19,184,45,61,84,30,94,237,14,113,191,5,76,45,31,254,46,81,89,162,42,206,197,77,29,140,168,139,23,175,87,93,169,166,177,120,128,253,164,224,154,5,80,20,210,65,152,4,19,253,40,178,187,20,14,114,26,30,51,10,218,22,80,47,108,126,69,211,27,105,233,132,67,140,238,60,72,243,36,40,147,216,249,163,171,84,16,143,149,226,193,135,220,213,101,221,203,151,205,185,96,115,11,27,159,15,25,76,233,238,127,10,9,68,194,65,167,14,7,228,41,240,160,245,57,111,10,220,122,203,51,115,195,109,159,15,186,131,81,127,67,14,227,65,121,48,34,89,249,232,219,47,196,31,132,81,100,201,71,124,198,225,197,60,115,236,251,8,19,162,100,196,25,92,140,80,152,24,84,63,24,34,147,126,51,180,154,15,146,86,38,183,170,42,14,243,146,0,61,37,175,27,132,201,213,85,95,101,52,94,40,109,105,35,209,254,244,17,4,23,172,87,202,95,30,135,31,252,18,102,42,190,217,146,208,82,97,175,42,171,181,67,82,251,219,216,163,112,239,89,230,146,245,240,37,195,141,224,117,142,166,221,89,167,63,4,92,53,132,90,237,185,53,163,202,38,131,131,68,1,253,104,188,50,120,14,178,180,128,199,90,182,222,27,130,21,176,67,240,236,192,82,151,55,210,173,242,55,184,232,18,169,229,194,102,83,222,83,65,205,171,30,172,54,199,167,21,3,211,218,241,229,229,80,233,23,124,42,186,84,134,110,17,77,112,34,138,28,184,241,13,253,132,201,103,161,99,223,207,41,133,160,107,21,210,44,77,35,81,48,197,239,139,40,216,105,199,218,21,239,74,242,136,208,22,130,114,231,94,84,220,206,107,117,180,233,35,84,39,174,114,106,35,253,234,95,127,233,204,42,100,55,117,228,84,127,211,109,39,77,141,240,13,245,173,210,131,207,222,177,42,73,197,23,246,47,214,163,254,239,181,184,174,121,105,135,189,72,57,54,250,89,188,22,231,43,5,95,160,30,107,191,168,128,171,248,23,255,252,11,39,11,138,232,121,41,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69e688f5-79ee-45b6-b372-e56d1cdaed4c"));
		}

		#endregion

	}

	#endregion

}


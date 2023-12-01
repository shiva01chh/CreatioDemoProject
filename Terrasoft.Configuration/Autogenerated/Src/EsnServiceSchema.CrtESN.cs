﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnServiceSchema

	/// <exclude/>
	public class EsnServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnServiceSchema(EsnServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0efab49d-c4be-440d-91a9-a715a5813ec3");
			Name = "EsnService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,91,77,111,219,56,16,61,167,192,254,7,194,189,216,128,161,220,155,196,64,154,143,194,187,77,19,196,9,114,8,138,133,34,141,99,33,250,240,146,84,178,217,162,255,125,135,20,41,81,50,37,219,138,157,184,169,123,104,37,146,195,121,226,188,55,28,81,110,236,70,192,166,174,7,228,10,40,117,89,50,230,206,81,18,143,131,251,148,186,60,72,98,231,100,244,237,143,15,63,254,248,176,147,178,32,190,39,163,103,198,33,218,171,220,163,77,24,130,39,12,152,243,5,98,160,129,55,51,230,50,141,121,16,129,51,194,94,55,12,254,147,243,207,140,194,222,199,192,131,179,196,135,176,177,211,57,68,127,143,243,39,113,110,224,110,102,0,182,225,32,198,208,120,196,93,14,197,128,163,132,130,115,234,122,60,161,1,176,162,189,88,31,97,123,148,68,17,46,142,242,115,153,164,28,199,20,131,139,33,216,134,173,31,41,220,163,43,114,20,186,140,125,34,39,44,254,26,60,0,211,230,24,2,92,56,144,67,111,143,93,238,98,8,56,69,12,223,177,97,154,222,133,129,71,60,97,90,103,73,62,145,82,212,102,38,222,17,17,44,96,96,35,167,169,120,70,68,115,33,29,72,231,218,89,141,155,110,143,252,32,63,23,26,121,242,175,7,83,1,133,128,190,234,33,202,59,23,251,140,150,124,186,143,16,251,25,58,117,175,160,94,208,100,10,148,99,40,202,64,229,50,157,65,116,7,180,251,13,73,76,14,72,39,20,64,58,189,239,6,188,225,73,156,70,64,221,187,16,246,21,212,227,171,243,65,14,27,1,220,3,223,35,76,252,101,129,178,147,181,85,208,105,112,70,60,47,18,198,207,144,80,238,253,146,225,180,24,174,33,154,22,47,246,96,218,6,190,69,44,135,126,57,144,95,210,192,39,67,127,101,241,82,207,216,78,130,53,198,11,198,173,88,236,154,121,236,145,169,27,188,108,116,108,171,109,76,223,168,159,75,112,125,53,80,203,72,219,89,34,179,104,44,78,131,176,101,32,108,150,107,80,143,205,141,61,72,214,145,111,161,159,177,0,210,24,75,1,85,7,81,194,94,153,182,212,243,203,238,221,221,93,178,207,210,40,114,233,243,64,221,227,115,60,6,62,58,60,188,24,146,113,66,201,83,66,31,200,83,192,39,4,98,14,116,74,3,12,35,75,60,44,19,72,12,92,116,59,122,174,93,99,178,219,99,24,187,105,200,141,109,24,196,19,223,142,216,116,182,45,107,48,233,116,123,200,166,223,128,227,78,61,69,170,220,5,97,192,159,47,225,159,52,160,16,33,18,214,53,111,68,49,129,43,59,199,68,140,114,84,131,223,179,113,86,225,64,2,124,70,2,168,187,62,25,10,109,157,199,225,179,89,150,84,201,74,78,3,8,125,17,126,42,74,31,80,244,203,110,48,192,44,62,146,43,72,254,6,125,185,183,4,167,108,147,202,196,251,5,159,56,165,20,39,188,102,64,49,13,31,12,136,184,194,197,140,179,178,207,49,250,157,161,191,87,139,172,184,146,79,182,131,148,83,87,59,193,152,116,11,224,228,224,128,196,105,24,246,116,247,206,163,75,137,39,251,178,250,236,25,195,33,89,167,110,177,242,228,251,133,43,213,58,232,246,246,212,4,230,228,229,153,156,35,10,8,52,183,237,150,159,78,207,240,51,251,135,2,79,105,92,94,100,221,59,71,195,103,192,39,137,95,17,112,85,36,178,1,31,134,164,136,130,200,178,70,234,36,82,185,214,201,141,118,171,86,251,83,151,186,17,137,49,13,28,116,212,248,161,207,58,3,149,167,9,70,211,203,139,117,103,127,87,142,47,204,179,71,99,131,33,102,69,55,70,154,38,99,132,6,64,60,10,227,131,78,77,185,215,33,187,3,156,75,27,203,164,116,142,188,146,9,216,84,220,206,45,150,198,195,248,49,121,128,110,182,20,34,89,93,156,143,174,58,125,242,57,241,159,71,252,57,20,50,195,97,10,113,222,234,220,80,119,58,5,95,168,11,24,239,103,177,80,119,167,9,141,92,94,50,204,154,156,63,89,18,247,137,70,218,60,174,148,47,235,106,109,12,140,178,148,221,104,46,200,210,253,26,48,190,47,212,50,32,197,186,107,242,214,205,69,129,97,254,202,232,195,145,208,138,234,130,233,89,216,15,10,193,56,53,142,171,226,236,155,254,247,52,99,133,31,156,45,134,167,218,7,211,58,203,209,226,120,137,66,145,95,177,156,120,46,247,38,196,220,214,114,141,46,226,167,11,61,67,47,90,76,198,74,252,156,163,138,130,191,130,157,66,35,140,60,77,18,137,213,215,15,191,180,70,76,137,108,117,209,78,23,55,147,68,116,233,26,177,43,55,143,124,133,87,45,134,170,183,194,209,123,99,189,152,240,109,136,221,84,74,191,75,118,55,61,176,140,67,51,183,5,89,75,116,104,154,79,87,38,6,217,11,130,151,124,213,167,248,222,178,252,108,4,244,18,146,94,66,148,60,66,81,179,108,137,250,118,68,189,142,95,147,170,21,111,191,2,89,179,58,34,18,239,108,102,61,97,84,217,139,210,151,121,19,136,220,107,65,223,145,188,212,19,16,108,155,165,177,105,138,206,241,245,81,88,158,200,171,220,210,198,255,181,20,45,53,135,74,239,82,48,13,7,119,226,221,251,40,99,3,203,212,146,71,181,159,189,1,235,80,169,219,249,98,106,58,222,155,145,82,102,233,152,199,105,102,173,83,130,103,32,43,64,181,87,88,3,206,151,234,203,229,220,245,38,43,144,152,149,238,56,45,15,198,1,46,79,163,84,12,121,94,184,34,41,169,208,46,163,78,101,152,53,44,235,90,156,200,229,169,65,116,52,27,225,74,165,81,156,25,157,6,161,56,171,200,154,106,108,127,65,141,175,85,226,214,35,97,33,160,195,156,141,172,178,33,42,77,215,75,158,113,42,190,234,21,241,20,11,208,81,9,75,117,22,113,147,157,77,121,193,126,156,220,144,20,178,227,217,106,70,48,31,168,57,41,244,13,232,125,3,105,155,100,97,5,255,146,76,113,12,33,112,216,140,100,81,128,96,87,201,95,0,83,121,116,118,29,83,81,218,138,131,115,19,166,156,85,78,202,54,42,5,105,69,143,130,251,152,240,9,74,71,197,48,96,132,165,158,135,139,66,112,89,227,132,191,55,249,223,37,73,168,248,52,79,237,183,223,137,45,216,115,82,129,86,133,116,84,115,92,145,11,166,80,235,44,36,3,141,29,134,69,208,21,181,86,221,141,221,144,193,203,54,236,109,229,251,91,86,190,165,215,196,13,40,124,197,44,168,207,31,149,253,78,195,156,83,0,147,54,39,118,235,42,129,189,73,26,63,228,223,109,228,118,150,97,222,100,141,81,241,37,82,174,24,110,126,98,229,69,125,147,100,13,21,21,25,113,209,22,153,128,182,122,108,175,199,44,92,139,169,50,63,138,153,141,4,49,226,248,106,175,169,101,236,86,169,154,176,54,91,170,242,40,115,12,224,47,170,214,173,114,222,86,57,167,24,171,238,230,136,65,192,209,82,216,64,214,139,223,250,201,249,219,189,97,21,21,152,207,147,10,39,111,104,192,245,129,240,241,213,121,91,106,91,126,141,248,94,105,109,251,29,168,209,214,157,93,84,29,182,38,58,91,127,247,89,71,101,241,187,30,131,193,166,119,237,170,5,115,109,16,86,194,90,117,124,191,226,207,76,229,179,56,233,97,75,244,215,32,186,58,224,158,121,91,183,16,95,197,101,157,196,215,104,12,32,218,235,6,104,224,196,15,150,126,91,111,193,255,87,74,244,219,79,183,102,29,35,98,107,255,112,107,213,194,188,77,160,245,71,93,19,135,1,161,237,78,176,182,47,185,82,11,75,238,5,106,184,208,130,18,250,166,236,5,91,45,84,181,80,218,23,242,192,181,218,23,94,164,5,141,195,128,208,118,71,88,155,22,212,183,148,223,230,28,119,171,22,83,45,89,244,87,123,154,219,90,50,101,48,43,254,209,194,186,5,180,228,118,242,22,2,90,112,11,219,10,104,105,1,149,54,156,57,2,202,163,176,46,1,105,48,86,1,21,222,223,66,64,115,254,111,152,108,193,63,255,3,97,171,103,198,99,62,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0efab49d-c4be-440d-91a9-a715a5813ec3"));
		}

		#endregion

	}

	#endregion

}

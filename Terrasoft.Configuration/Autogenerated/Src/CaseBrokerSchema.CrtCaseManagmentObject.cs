﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseBrokerSchema

	/// <exclude/>
	public class CaseBrokerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseBrokerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseBrokerSchema(CaseBrokerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("29af7a40-d9b4-4d1e-b907-cfa9dd10b1a2");
			Name = "CaseBroker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,88,75,111,219,70,16,62,43,64,254,195,130,233,65,70,84,186,103,199,82,155,40,81,32,160,121,212,78,123,41,138,96,77,14,229,69,200,93,117,119,105,67,8,252,223,59,179,15,190,36,43,74,173,28,2,36,135,64,220,199,204,55,51,223,124,28,90,242,10,204,154,103,192,62,128,214,220,168,194,166,115,37,11,177,170,53,183,66,201,116,206,13,92,130,190,17,25,60,126,244,249,241,163,81,109,132,92,177,203,141,177,80,61,27,60,227,221,178,132,140,46,154,244,53,72,208,34,107,207,172,74,117,197,203,179,179,185,170,42,180,252,187,90,173,112,185,221,239,66,208,112,223,122,250,74,90,97,5,152,161,243,75,176,22,159,12,155,14,111,244,35,194,211,241,40,154,64,35,79,52,172,112,131,205,75,110,204,25,163,136,95,104,245,9,180,219,61,61,61,101,231,166,174,42,174,55,179,240,236,78,50,13,107,13,6,164,53,140,75,38,164,5,93,65,46,240,28,43,148,102,183,74,127,34,116,183,194,94,59,163,12,8,249,38,141,70,79,59,86,215,245,85,41,50,150,57,195,93,4,35,202,121,3,113,33,160,204,17,227,123,45,110,184,5,7,112,180,246,15,204,88,12,48,67,88,60,87,178,220,176,37,102,152,125,44,241,191,41,195,159,111,184,228,43,208,88,23,75,169,7,61,78,200,209,27,48,6,215,127,23,152,67,44,88,114,226,147,50,122,2,50,247,94,195,115,128,240,6,236,181,186,23,131,43,206,134,161,15,255,107,28,22,178,90,107,12,223,63,77,216,149,82,37,147,0,249,2,108,118,125,194,92,144,35,194,154,46,101,161,22,74,87,220,142,127,74,254,38,132,203,252,140,125,238,25,72,209,55,101,14,233,86,87,242,47,94,214,112,247,15,251,153,189,199,236,65,238,147,109,85,139,130,85,14,180,139,13,253,132,197,82,101,188,12,191,167,125,132,254,156,40,216,120,11,228,195,81,58,120,183,162,44,217,21,176,130,108,67,3,109,116,195,53,178,0,184,190,196,229,138,15,129,121,246,111,252,102,172,232,66,200,124,41,177,252,50,131,23,155,183,216,211,227,254,37,127,156,54,162,155,65,236,173,195,116,142,252,177,16,170,215,55,243,167,1,141,189,36,125,135,239,48,69,39,158,231,149,144,23,98,117,109,169,19,11,94,26,120,118,164,196,93,90,174,173,207,24,53,22,93,78,118,161,112,245,90,104,85,189,124,49,254,146,225,147,99,129,243,85,229,102,88,209,187,227,80,251,2,108,173,101,36,119,129,193,221,75,111,237,142,118,233,237,214,239,14,237,107,39,69,126,115,40,126,110,225,2,212,26,36,203,90,73,99,183,215,120,27,144,185,74,230,130,200,193,84,193,80,29,115,145,145,42,8,131,59,24,100,102,211,198,234,233,208,236,249,154,107,94,49,137,44,157,38,16,68,62,153,145,48,145,181,214,29,46,167,231,167,238,244,238,203,141,227,100,246,190,193,128,122,128,101,201,62,49,4,218,193,73,74,173,93,64,251,109,54,58,144,204,222,226,79,188,83,42,158,199,248,93,61,114,110,57,187,66,152,219,150,124,73,204,108,174,106,233,162,241,46,209,14,133,69,225,196,19,78,76,253,203,224,70,104,91,243,146,222,44,33,231,239,228,60,2,31,47,95,201,186,2,205,175,74,56,247,85,158,53,233,153,176,38,238,102,175,73,202,196,19,190,47,193,177,85,163,202,145,207,6,227,148,253,226,153,133,201,2,142,135,163,170,135,232,133,108,60,55,42,73,218,217,184,28,251,131,39,205,238,222,126,128,3,68,192,99,219,82,1,39,159,125,109,107,95,69,16,94,62,173,164,199,91,93,241,192,217,160,227,114,156,160,63,91,155,101,158,76,156,43,44,128,177,198,143,69,110,231,34,100,105,153,247,64,212,61,173,68,28,3,153,236,108,118,175,57,37,126,110,140,88,33,74,44,55,186,185,104,66,157,178,253,227,76,176,51,162,87,188,67,127,78,69,158,141,251,88,38,44,153,239,241,130,113,90,221,234,162,43,228,62,84,109,77,247,166,241,221,45,14,23,46,139,178,46,203,198,250,221,131,249,208,116,4,51,152,16,83,8,200,211,64,18,39,149,134,223,80,238,214,90,101,56,233,36,187,107,206,111,96,236,249,31,183,35,249,159,62,125,246,112,136,1,71,64,134,164,33,69,140,30,26,72,119,157,247,69,208,240,120,166,43,224,59,53,121,94,42,244,241,237,37,121,147,204,186,163,236,81,101,216,161,207,48,16,172,215,81,196,120,191,22,47,141,247,232,11,179,87,129,157,86,186,20,119,21,184,39,130,7,72,238,126,197,221,41,26,112,191,94,80,95,246,207,83,219,47,205,2,199,183,90,227,0,71,111,134,28,103,124,247,181,229,164,11,3,192,157,185,202,81,48,155,182,13,76,219,138,46,134,213,6,177,91,255,220,69,84,191,109,93,189,107,226,202,90,207,75,122,157,244,63,216,26,185,218,33,84,125,216,47,161,64,1,121,93,139,60,125,85,173,241,133,210,27,120,142,16,66,15,232,86,68,63,26,48,90,54,241,165,56,139,122,150,19,32,20,95,189,255,98,47,193,24,138,127,68,28,57,28,108,227,187,235,126,199,88,22,115,54,97,142,180,110,109,192,183,47,204,100,123,71,170,175,213,143,255,55,42,29,56,41,197,88,15,185,22,56,240,146,120,58,25,132,144,206,253,183,17,5,64,50,17,30,233,236,7,129,159,185,39,95,225,32,112,110,208,228,59,13,108,141,3,65,97,104,48,234,106,91,88,110,63,114,127,40,196,131,21,226,187,239,238,31,77,124,148,38,254,54,61,72,188,54,109,227,57,142,52,19,121,33,36,47,15,237,181,204,205,254,161,215,14,37,119,63,49,201,140,82,66,45,22,51,117,47,161,191,76,225,165,33,36,11,10,97,236,223,45,14,224,132,245,121,51,168,77,151,150,254,2,155,78,89,14,5,175,75,235,236,108,77,138,195,2,16,5,193,252,139,212,147,112,203,186,127,159,252,163,6,189,25,14,169,59,254,128,25,6,189,248,33,132,198,210,231,121,238,249,21,25,153,226,100,75,177,197,67,228,245,55,87,191,41,121,79,91,218,15,135,72,31,86,184,230,82,37,188,41,188,25,44,76,221,71,41,251,213,197,198,206,252,50,153,252,176,89,67,222,33,122,248,160,14,152,62,14,48,133,4,5,243,123,254,232,230,87,251,139,184,214,253,247,31,178,13,100,181,154,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("29af7a40-d9b4-4d1e-b907-cfa9dd10b1a2"));
		}

		#endregion

	}

	#endregion

}


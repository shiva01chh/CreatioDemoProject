﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseStatusStoreSchema

	/// <exclude/>
	public class CaseStatusStoreSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseStatusStoreSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseStatusStoreSchema(CaseStatusStoreSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f17547d2-226b-4661-872c-1dadafb69117");
			Name = "CaseStatusStore";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,87,219,110,219,56,16,125,118,128,252,195,192,251,34,3,129,252,94,95,130,194,77,3,3,233,34,27,183,187,143,11,70,26,219,66,37,202,33,169,4,70,145,127,223,225,69,87,75,178,178,72,129,228,161,9,197,51,195,225,156,51,195,105,38,35,190,131,205,81,42,76,102,151,23,89,101,233,175,210,56,198,64,69,41,151,254,45,114,20,81,208,132,220,69,252,169,248,246,29,133,96,50,221,42,178,76,146,148,183,110,8,236,248,236,223,112,21,169,8,101,215,254,70,89,227,203,11,206,18,148,7,22,96,13,194,183,209,46,19,76,199,123,121,241,75,227,70,127,8,220,209,18,86,49,147,242,19,172,152,196,141,98,42,147,198,151,129,76,167,83,152,203,44,73,152,56,46,221,218,192,65,224,65,160,68,174,36,72,130,179,29,66,186,133,128,124,208,90,59,65,233,231,14,166,21,15,135,236,49,142,2,8,140,147,147,35,71,54,178,238,208,190,48,197,44,164,25,90,123,108,149,128,32,36,91,216,138,52,177,127,61,210,150,95,120,170,198,216,21,164,61,124,164,131,28,21,160,219,44,10,97,29,194,47,216,161,154,129,212,255,188,86,1,82,9,205,215,159,68,75,55,232,49,77,99,88,203,175,17,103,241,89,212,3,202,52,126,198,158,51,29,240,158,17,15,45,176,87,151,101,228,161,77,116,35,235,164,105,37,178,128,56,249,4,247,198,99,95,206,5,50,133,18,56,190,208,38,34,4,2,183,139,113,131,219,241,116,9,17,185,101,60,192,43,176,18,158,31,152,96,9,161,65,107,118,49,166,96,5,157,205,109,89,105,139,252,140,109,42,32,78,89,168,173,134,211,104,190,152,51,218,15,88,254,160,53,4,197,135,106,248,63,78,98,201,163,247,231,83,227,179,170,148,198,101,189,186,53,212,207,157,128,21,80,3,180,104,192,102,21,166,222,57,241,84,30,116,5,82,134,201,160,174,95,60,33,67,58,227,161,185,181,248,229,253,169,235,33,9,91,223,240,44,65,193,30,99,156,215,11,110,105,157,228,73,251,55,168,91,106,8,165,78,186,246,119,86,219,247,34,61,160,208,157,148,164,45,162,103,202,160,5,28,236,2,250,34,105,59,124,54,212,120,213,22,120,187,79,184,190,6,175,227,166,119,84,6,250,79,111,50,153,189,229,170,169,34,89,97,216,163,167,181,83,137,110,228,89,189,50,186,250,100,238,21,26,90,110,44,93,3,58,67,205,55,84,251,52,236,226,197,60,128,199,77,176,199,132,253,149,161,56,194,45,170,27,249,84,166,213,203,53,242,204,4,160,124,162,100,233,210,56,49,108,84,167,95,5,124,99,156,158,50,113,5,149,50,26,79,12,199,35,114,233,83,104,250,246,198,15,77,0,89,194,253,181,252,28,191,176,163,220,160,158,7,232,80,106,157,88,90,124,14,67,11,244,198,250,9,168,58,171,108,185,214,223,185,155,183,252,78,128,109,245,213,237,21,163,27,81,56,141,219,110,80,74,250,109,118,253,127,34,181,191,75,3,22,235,37,117,6,175,217,61,12,236,196,235,154,166,27,243,158,45,160,213,64,239,143,173,141,64,149,9,174,233,24,82,157,21,9,156,215,171,174,132,255,249,192,155,47,54,52,89,246,211,98,162,59,241,90,113,83,181,42,245,223,87,248,101,197,158,232,243,84,194,179,18,225,38,62,130,233,196,107,168,17,106,25,102,67,200,147,122,198,157,185,111,117,233,153,245,81,119,28,93,20,245,24,93,92,35,26,99,22,214,240,168,207,251,126,60,160,147,216,223,44,206,112,174,103,157,165,167,163,121,72,83,101,43,70,3,93,85,88,168,22,6,53,167,43,235,210,201,164,199,169,157,143,150,121,121,56,187,124,22,234,53,213,99,206,178,82,60,133,173,27,124,134,25,231,165,83,88,23,243,213,48,251,178,54,141,131,215,201,219,148,126,118,190,218,99,240,19,162,218,112,13,145,4,2,253,164,24,153,132,173,190,189,15,15,86,153,166,255,104,124,164,52,204,108,94,65,170,246,40,94,34,242,176,101,241,240,137,201,30,183,14,105,86,226,209,83,134,81,168,51,178,141,232,117,168,143,251,181,71,190,189,188,244,61,76,228,213,139,216,216,59,202,171,50,204,90,177,58,166,61,51,116,231,177,229,101,229,132,223,242,206,90,98,125,178,13,61,119,238,98,153,7,174,69,191,40,157,93,251,185,244,232,17,54,185,58,63,136,157,101,232,96,36,214,69,145,221,253,184,28,185,232,135,147,100,43,234,119,179,228,138,252,29,105,18,174,146,187,136,202,247,63,46,85,197,13,134,147,149,183,175,223,77,87,209,85,223,149,48,26,113,121,31,97,118,255,35,19,230,110,240,22,194,172,73,47,97,249,103,77,131,38,207,252,159,94,250,37,143,185,151,117,216,243,92,217,175,245,143,244,141,126,254,3,183,193,202,229,27,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f17547d2-226b-4661-872c-1dadafb69117"));
		}

		#endregion

	}

	#endregion

}

﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SenderObtainingServiceSchema

	/// <exclude/>
	public class SenderObtainingServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SenderObtainingServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SenderObtainingServiceSchema(SenderObtainingServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5bf1c040-6f5b-435c-9b08-854bd766f820");
			Name = "SenderObtainingService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,203,110,227,54,20,93,123,128,249,7,86,179,145,1,131,222,79,18,23,142,155,4,41,198,73,106,165,157,69,208,5,45,93,59,68,245,10,73,37,163,9,242,239,189,124,232,101,41,142,59,24,20,45,48,89,56,214,213,229,225,185,175,67,58,101,9,200,156,133,64,110,65,8,38,179,141,162,139,44,221,240,109,33,152,226,89,250,254,221,243,251,119,163,66,242,116,75,130,82,42,72,142,118,158,209,63,142,33,212,206,146,94,64,10,130,135,61,159,79,60,125,232,25,87,69,170,120,2,52,192,37,44,230,95,205,134,61,47,124,251,200,67,88,102,17,196,123,95,210,57,146,120,124,27,132,126,134,117,227,208,142,91,0,61,67,74,138,131,108,28,208,27,95,37,137,65,69,235,7,1,91,220,130,44,98,38,229,71,18,64,26,129,184,94,43,198,83,116,119,27,25,207,233,116,74,142,101,145,36,76,148,51,247,236,222,147,77,38,136,52,75,73,194,120,188,206,190,144,172,194,160,213,218,105,107,241,157,91,137,213,81,130,133,234,79,109,155,203,252,10,20,178,203,49,236,53,143,185,42,87,240,80,112,1,9,164,74,250,237,7,29,59,57,33,111,44,209,94,212,25,162,177,222,36,47,214,49,15,73,168,195,125,37,90,242,145,156,50,9,117,236,163,103,19,255,97,169,90,97,3,98,235,216,148,245,114,102,12,43,200,5,72,77,111,55,103,17,83,140,132,152,18,132,4,65,107,132,118,230,70,119,191,160,87,59,111,135,196,84,209,194,216,58,3,209,99,61,210,209,142,6,152,187,122,119,248,166,56,111,180,113,239,208,180,60,151,144,172,65,248,87,232,136,213,242,150,118,161,126,244,76,57,106,242,82,9,221,158,45,7,242,76,182,160,142,48,71,248,241,98,243,121,24,45,30,125,11,169,203,104,135,210,69,193,35,82,191,220,165,51,26,57,78,31,112,115,219,25,221,54,89,130,186,207,34,108,148,27,161,231,216,117,68,110,31,44,248,5,40,141,127,170,241,125,151,129,164,201,192,152,216,90,60,50,65,64,62,32,215,20,158,136,153,233,50,8,239,33,97,191,21,32,74,255,119,9,2,171,154,90,217,162,109,135,37,75,217,22,196,164,142,50,40,211,48,0,165,112,43,233,141,143,12,62,98,83,36,169,179,100,0,81,2,139,36,165,151,114,30,63,177,82,6,160,5,17,119,87,162,128,102,197,57,143,21,8,73,231,81,228,235,231,133,0,12,204,90,63,115,117,127,195,4,198,160,93,124,107,52,83,42,184,204,210,219,50,71,109,122,40,88,60,233,246,196,164,19,190,163,103,227,105,116,153,192,174,225,68,167,7,213,90,237,186,238,164,198,1,10,80,133,232,195,208,121,90,250,99,242,115,255,197,57,23,82,209,63,88,92,128,222,69,211,143,108,146,140,237,88,23,115,230,123,186,131,112,192,34,216,176,34,86,190,182,218,29,15,238,20,211,120,123,164,195,142,117,79,55,214,37,97,250,180,64,214,68,64,200,115,174,213,101,66,66,148,49,171,39,88,63,150,70,104,80,176,205,68,89,75,11,230,71,226,54,0,44,150,25,9,5,108,78,188,51,13,219,150,17,172,167,96,121,14,194,155,206,94,17,37,99,201,117,197,141,40,156,120,13,13,111,102,0,59,196,36,104,95,5,17,121,194,78,193,199,132,135,89,140,153,62,158,26,144,97,76,23,9,166,121,182,104,71,102,235,133,99,175,191,108,56,42,231,126,24,151,132,6,199,25,14,1,178,189,35,103,181,160,186,0,122,58,142,75,43,95,163,218,215,152,63,35,185,29,233,190,195,243,248,50,125,204,254,2,223,118,129,22,164,155,235,224,22,71,65,159,91,32,213,121,38,18,166,199,15,93,151,32,37,206,179,53,209,95,113,148,38,228,52,139,202,64,149,49,116,92,106,43,181,181,139,38,166,245,43,218,251,65,199,237,99,229,141,3,197,190,176,78,110,148,43,41,107,87,220,232,93,93,192,234,185,174,68,91,234,158,108,179,85,114,247,106,55,14,15,183,70,168,234,96,17,6,148,111,120,169,194,22,176,52,218,40,238,152,112,172,244,252,7,69,158,103,162,146,110,191,51,113,77,132,173,224,44,124,165,59,154,211,27,73,117,44,70,65,17,134,88,29,220,254,39,155,83,20,229,171,34,142,175,197,89,146,171,210,111,171,229,196,173,89,118,104,183,60,156,195,139,101,243,162,9,134,247,196,63,251,18,66,110,117,181,170,194,63,97,74,26,142,27,20,17,152,144,6,16,117,153,84,219,213,58,248,67,220,126,136,219,255,88,220,78,203,185,235,70,188,179,25,21,99,245,243,119,189,176,85,219,120,45,97,195,54,3,211,102,246,246,225,102,92,95,126,240,22,102,109,190,183,170,156,188,49,213,30,205,242,48,203,203,213,33,16,139,182,99,31,6,251,106,97,219,115,47,8,186,81,231,71,245,221,104,8,198,117,167,126,243,54,86,53,224,3,96,166,8,216,222,59,87,193,157,84,79,218,197,58,250,78,39,14,30,27,230,255,55,28,29,78,178,245,174,159,184,84,199,86,228,103,181,254,143,92,88,131,183,78,231,236,15,52,69,125,24,28,4,240,74,91,140,29,198,203,132,184,111,251,192,236,29,120,176,53,106,54,7,174,31,236,137,234,215,64,59,191,151,90,81,58,63,162,218,7,226,127,234,212,173,28,12,229,154,254,206,145,108,62,7,142,229,209,191,112,44,247,127,158,88,115,215,138,54,253,247,55,75,111,45,244,105,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5bf1c040-6f5b-435c-9b08-854bd766f820"));
		}

		#endregion

	}

	#endregion

}


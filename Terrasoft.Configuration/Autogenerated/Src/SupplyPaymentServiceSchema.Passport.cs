﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SupplyPaymentServiceSchema

	/// <exclude/>
	public class SupplyPaymentServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SupplyPaymentServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SupplyPaymentServiceSchema(SupplyPaymentServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("23c7aa6b-167a-48e3-ba60-3683f5ff5f9d");
			Name = "SupplyPaymentService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a9dc8202-29a7-4ff6-a0ce-2857c0a07123");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,75,111,219,56,16,62,59,64,255,3,215,189,200,11,87,155,94,243,2,18,39,45,188,216,164,105,157,108,14,65,177,80,164,73,66,84,175,146,148,91,163,205,127,95,82,164,36,74,162,100,61,178,93,236,162,189,184,38,103,230,155,39,61,228,36,116,2,160,177,227,2,186,2,66,28,26,221,51,123,17,133,247,248,33,33,14,195,81,248,98,231,219,139,157,73,66,113,248,128,86,27,202,32,216,175,124,183,87,64,214,216,133,243,200,3,191,117,211,190,129,187,118,130,99,151,225,117,138,91,208,233,138,17,104,90,183,207,66,134,25,6,218,72,112,122,98,218,226,42,241,237,32,72,17,249,254,75,2,15,28,30,45,124,135,210,61,180,74,226,216,223,92,58,155,0,66,166,84,77,233,110,213,23,238,44,70,28,151,125,20,107,199,52,190,0,198,197,197,220,134,59,236,99,182,249,0,159,19,76,64,176,83,75,255,34,12,70,135,104,11,139,160,178,213,130,55,19,32,113,114,231,99,23,185,66,63,163,122,104,15,157,56,20,114,101,39,223,82,133,115,203,206,129,61,70,30,183,237,146,224,53,102,210,156,73,76,132,227,1,165,110,220,44,34,223,7,87,196,1,189,5,86,66,185,36,145,151,184,204,122,155,96,15,81,195,206,210,155,163,116,211,85,174,89,122,51,36,146,104,50,89,59,4,1,253,204,205,14,225,139,130,90,185,143,16,56,239,19,32,27,235,154,2,225,14,13,37,180,173,19,156,59,161,243,0,100,142,166,38,109,166,179,253,20,128,11,183,185,89,129,67,54,169,68,110,71,18,132,246,146,30,251,95,156,13,93,129,176,138,195,51,146,192,126,174,82,44,133,240,117,193,127,236,121,146,205,154,86,164,11,218,207,137,147,106,85,39,126,175,118,116,93,222,96,159,1,161,130,204,18,223,23,4,184,147,229,234,13,102,143,151,14,225,5,40,72,172,148,103,34,183,210,116,32,152,70,225,213,38,6,251,34,98,103,28,215,159,75,154,233,109,201,5,103,126,154,42,123,75,111,207,180,254,209,94,122,83,197,105,14,87,186,55,219,170,245,146,114,61,46,18,223,151,219,214,48,101,178,122,153,118,68,253,193,190,202,213,83,252,69,14,151,244,37,192,18,18,166,25,192,235,163,90,51,149,60,150,60,79,219,235,108,145,16,34,234,184,103,185,253,143,170,43,115,119,157,216,20,174,34,90,255,114,129,254,176,234,28,150,119,147,109,137,151,121,230,29,241,128,148,50,14,63,111,118,233,0,195,179,170,18,215,11,30,33,93,152,190,21,49,160,13,123,6,53,180,221,69,66,89,20,180,211,156,130,143,215,92,227,83,238,215,6,18,83,206,105,219,215,33,110,18,174,92,194,63,220,38,225,91,246,4,251,113,16,37,97,19,68,235,166,18,112,138,169,43,168,90,105,123,17,93,2,113,161,145,234,202,249,218,174,16,39,104,133,217,182,159,137,137,152,227,183,11,218,74,145,89,212,172,115,154,239,13,123,162,73,219,146,30,105,128,255,192,180,57,73,197,15,134,219,196,158,109,127,168,228,231,63,112,232,21,167,24,126,238,95,202,117,196,207,161,235,216,227,255,175,159,79,145,88,41,126,2,181,3,228,236,107,76,128,82,113,194,177,34,146,232,80,106,57,177,212,49,179,138,18,34,186,248,106,185,162,95,145,145,162,92,150,51,251,196,143,220,79,214,12,189,202,228,154,5,151,217,154,132,215,74,4,253,166,196,78,20,125,30,26,235,245,238,174,6,223,32,176,176,39,39,149,97,145,254,68,137,252,144,103,186,92,171,132,164,118,104,219,82,163,21,176,114,137,204,117,55,103,84,55,143,64,64,149,1,79,145,25,63,213,211,180,177,106,230,100,129,156,33,135,42,77,164,166,82,69,251,236,43,184,9,215,174,248,81,155,52,36,73,102,179,76,144,184,184,148,120,224,242,32,248,121,135,80,172,184,178,241,202,56,179,108,122,30,39,229,49,152,163,154,213,121,179,242,170,166,67,197,133,237,222,203,173,236,238,191,154,247,228,41,80,42,49,89,174,185,195,244,189,70,231,101,151,63,185,154,117,104,122,23,17,105,98,150,30,247,171,96,176,47,224,139,248,204,18,180,74,40,59,9,78,188,189,207,16,7,205,50,164,204,9,93,56,217,136,238,192,50,54,30,85,8,46,188,142,168,14,71,9,99,60,174,38,58,147,205,67,126,10,247,50,64,127,58,126,2,212,106,32,211,104,210,240,206,43,142,233,194,150,182,62,115,99,128,132,23,196,57,237,105,12,7,148,17,28,62,28,101,61,83,39,136,180,133,26,132,33,155,47,5,130,239,145,213,89,134,200,132,163,188,69,19,185,143,126,81,121,114,22,196,69,133,182,171,94,176,247,80,191,14,173,12,120,218,238,171,114,211,56,196,103,149,182,179,75,128,74,93,104,15,76,65,127,133,3,56,170,54,178,93,64,181,67,173,122,112,13,15,183,232,134,135,198,90,241,246,15,116,6,218,61,202,165,223,242,30,128,234,192,60,170,53,17,29,252,61,14,172,7,138,118,105,24,99,90,214,55,119,65,29,3,215,7,199,124,163,25,99,101,245,222,211,169,92,159,1,126,12,110,214,91,142,2,206,27,212,17,213,206,111,77,67,139,93,178,246,175,117,5,217,187,212,139,59,229,152,108,209,110,166,93,2,54,18,180,39,154,225,90,60,202,86,253,242,220,201,218,177,192,189,17,245,219,251,168,98,72,175,255,35,10,33,191,29,13,41,133,140,185,127,49,228,176,221,203,161,244,100,49,200,103,229,71,143,81,173,161,122,26,25,222,28,22,2,134,180,135,26,124,201,129,67,140,201,30,106,134,218,162,241,247,55,69,7,239,211,234,106,111,75,131,82,161,252,58,165,165,66,229,234,56,200,33,249,216,166,104,80,243,171,104,179,141,206,186,114,65,126,9,161,39,199,166,77,51,212,116,26,43,55,111,223,197,32,135,230,250,80,120,114,123,3,119,203,112,29,125,2,75,178,241,123,230,244,242,221,234,138,171,38,38,187,64,217,155,136,4,142,184,127,114,210,115,160,148,223,98,229,146,253,59,21,175,11,39,145,183,89,177,141,15,37,146,124,213,190,33,78,204,253,44,95,224,62,0,141,163,144,66,187,208,116,150,156,13,147,239,162,200,71,23,0,222,41,94,99,15,198,140,120,107,227,5,19,191,182,125,216,56,96,110,2,214,48,247,205,144,110,243,28,173,138,220,54,114,107,152,182,73,208,251,136,128,227,62,162,236,141,196,72,204,32,64,120,155,11,242,140,174,138,108,49,35,147,220,201,210,28,96,82,126,17,227,30,104,210,186,227,205,120,95,151,171,116,209,31,118,182,88,208,19,69,156,13,154,242,135,53,196,194,208,236,217,185,152,25,101,5,175,62,158,244,199,233,123,199,167,80,148,253,127,187,150,211,183,188,159,117,220,179,142,127,150,241,15,43,99,211,243,240,56,16,211,96,253,47,173,5,200,161,27,158,172,7,162,23,173,76,117,140,215,239,172,210,255,106,161,154,215,198,201,124,92,201,225,74,215,89,200,176,23,114,230,117,136,118,53,60,117,236,229,188,79,38,69,116,64,174,74,93,246,237,238,199,125,19,163,70,220,163,25,172,123,176,120,158,239,35,177,122,183,49,58,8,29,112,135,160,239,223,81,219,252,5,29,116,115,90,101,232,164,205,155,138,57,147,249,137,148,255,51,204,92,204,195,150,218,144,197,220,212,230,250,148,68,166,94,156,53,255,14,26,154,93,181,166,47,241,149,157,157,191,1,172,114,162,111,48,42,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("23c7aa6b-167a-48e3-ba60-3683f5ff5f9d"));
		}

		#endregion

	}

	#endregion

}

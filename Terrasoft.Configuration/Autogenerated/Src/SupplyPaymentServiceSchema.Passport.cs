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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,221,111,219,54,16,127,86,129,253,15,156,251,34,15,174,150,189,38,77,128,196,73,11,15,75,154,214,233,242,16,20,131,34,93,18,162,250,42,73,185,53,218,252,239,35,69,74,162,36,74,214,71,214,97,67,243,226,154,188,187,223,125,210,71,94,35,55,4,154,184,30,160,43,32,196,165,241,29,115,150,113,116,135,239,83,226,50,28,71,63,61,251,250,211,51,43,165,56,186,71,235,45,101,16,30,212,190,59,107,32,27,236,193,121,236,67,208,185,233,92,195,109,55,193,177,199,240,38,195,45,233,116,197,8,180,173,59,103,17,195,12,3,109,37,56,61,49,109,113,149,248,118,24,102,136,124,255,57,129,123,14,143,150,129,75,233,62,90,167,73,18,108,47,221,109,8,17,83,170,102,116,55,234,11,119,22,35,174,199,62,136,181,99,154,92,0,227,226,18,110,195,45,14,48,219,190,131,79,41,38,32,216,169,173,127,17,6,163,67,180,131,69,80,57,106,193,159,11,144,36,189,13,176,135,60,161,159,81,61,180,143,78,92,10,133,178,214,215,76,225,194,178,115,96,15,177,207,109,187,36,120,131,153,52,199,74,136,112,60,160,204,141,219,101,28,4,224,137,56,160,215,192,42,40,151,36,246,83,143,217,175,83,236,35,106,216,89,249,11,148,109,122,202,53,43,127,142,68,18,89,214,198,37,8,232,39,110,118,4,159,21,212,218,123,128,208,125,155,2,217,218,239,41,16,238,208,72,66,59,58,193,185,27,185,247,64,22,104,102,210,102,54,63,200,0,184,112,135,155,21,186,100,155,73,228,118,164,97,228,172,232,113,240,217,221,210,53,8,171,56,60,35,41,28,20,42,37,82,8,95,23,252,199,190,47,217,236,89,77,186,160,253,148,186,153,86,77,226,183,106,71,215,229,21,14,24,16,42,200,108,241,125,73,128,59,89,174,94,99,246,112,233,18,94,128,130,196,206,120,44,185,149,165,3,193,52,142,174,182,9,56,23,49,59,227,184,193,66,210,204,110,42,46,56,11,178,84,217,95,249,251,166,245,15,206,202,159,41,78,115,184,178,189,249,78,173,87,148,235,113,145,6,129,220,182,199,41,147,215,203,172,39,234,119,246,85,161,158,226,47,115,184,162,47,1,150,146,40,203,0,94,31,245,154,169,229,177,228,121,220,93,103,203,148,16,81,199,3,203,237,127,84,93,185,187,155,196,166,112,149,209,250,151,11,244,187,85,231,184,188,179,118,37,94,238,153,55,196,7,82,201,56,252,180,217,165,3,140,207,170,90,92,47,120,132,116,97,250,86,204,128,182,236,25,212,208,118,151,41,101,113,216,77,115,10,1,222,112,141,79,185,95,91,72,76,57,167,109,191,143,112,155,112,229,18,254,225,181,9,223,177,39,216,143,195,56,141,218,32,58,55,149,128,83,76,61,65,213,73,59,136,232,18,136,7,173,84,87,238,151,110,133,56,65,39,204,174,253,92,76,204,220,160,91,208,78,138,220,162,118,157,179,124,111,217,19,77,218,142,244,200,2,252,7,166,237,73,42,126,48,188,54,246,124,251,93,45,63,255,129,67,175,60,197,240,83,255,82,110,98,126,14,189,79,124,254,239,230,249,20,139,149,242,39,80,59,64,206,190,36,4,40,21,39,28,43,35,137,14,165,150,150,173,142,153,117,156,18,209,197,215,203,21,253,130,140,20,213,178,156,59,39,65,236,125,180,231,232,69,46,215,44,184,202,214,38,188,81,34,232,87,37,214,82,244,69,104,236,223,246,246,52,248,22,129,165,61,5,169,12,139,244,39,74,229,135,60,211,229,90,45,36,141,67,219,145,26,173,129,85,75,100,161,187,57,167,186,126,0,2,170,12,120,138,204,249,169,158,165,141,221,48,39,15,228,28,185,84,105,34,53,149,42,58,103,95,192,75,185,118,229,143,154,213,146,36,185,205,50,65,146,242,82,226,131,199,131,16,20,29,66,185,226,201,198,43,231,204,179,233,105,156,84,196,96,129,26,86,23,205,202,139,134,14,53,23,118,123,175,176,178,191,255,26,222,147,167,64,165,196,100,185,22,14,211,247,90,157,151,95,254,228,106,222,161,233,93,68,172,137,89,249,220,175,130,193,185,128,207,226,51,79,208,58,161,236,36,56,241,238,62,67,28,52,171,136,50,55,242,224,100,43,186,3,219,216,120,212,33,184,240,38,162,58,28,37,140,241,184,178,116,38,135,135,252,20,238,100,128,254,116,131,20,168,221,66,166,209,100,225,93,212,28,211,135,45,107,125,22,198,0,9,47,136,115,218,215,24,94,82,70,112,116,127,148,247,76,189,32,178,22,106,20,134,108,190,20,8,190,67,118,111,25,34,19,142,138,22,77,228,62,250,89,229,201,89,152,148,21,218,173,122,201,62,64,253,38,180,50,224,113,183,175,170,77,227,24,159,213,218,206,62,1,170,116,161,3,48,5,253,21,14,225,168,222,200,246,1,213,14,181,250,193,53,62,220,162,27,30,27,107,197,59,60,208,57,104,255,40,87,126,203,7,0,170,3,243,168,209,68,244,240,247,52,176,1,40,218,165,97,138,105,121,223,220,7,117,10,220,16,28,243,141,102,138,149,245,123,79,175,114,125,2,248,41,184,121,111,57,9,184,104,80,39,84,59,191,53,141,45,118,201,58,188,214,21,228,224,82,47,239,148,83,178,69,187,153,246,9,216,68,208,129,104,134,107,241,36,91,245,203,115,47,107,167,2,15,70,212,111,239,147,138,33,187,254,79,40,132,226,118,52,166,20,114,230,225,197,80,192,246,47,135,202,147,197,40,159,85,31,61,38,181,134,234,105,100,124,115,88,10,24,211,30,106,240,21,7,142,49,38,127,168,25,107,139,198,63,220,20,29,124,72,171,171,189,45,141,74,133,234,235,148,150,10,181,171,227,40,135,20,99,155,178,65,45,174,162,237,54,186,155,218,5,249,57,68,190,28,155,182,205,80,179,105,172,220,188,121,147,128,28,154,235,67,97,235,230,26,110,87,209,38,254,8,182,100,227,247,204,217,229,155,245,21,87,77,76,118,129,178,87,49,9,93,113,255,228,164,231,64,41,191,197,202,37,231,119,42,94,23,78,98,127,187,102,219,0,42,36,197,170,115,77,220,132,251,89,190,192,189,3,154,196,17,133,110,161,217,44,57,31,38,223,198,113,128,46,0,252,83,188,193,62,76,25,241,54,198,11,38,126,109,251,176,117,192,220,6,172,97,30,152,33,189,246,57,90,29,185,107,228,214,50,109,147,160,119,49,1,215,123,64,249,27,137,145,152,65,136,240,46,23,20,25,93,23,217,97,70,46,185,151,165,5,128,85,125,17,227,30,104,211,186,231,205,248,64,151,171,116,209,31,118,118,88,48,16,69,156,13,154,242,135,13,196,210,208,252,217,185,156,25,229,5,175,62,30,245,199,233,59,55,160,80,150,253,127,187,150,179,183,188,31,117,60,176,142,127,148,241,119,43,99,211,243,240,52,16,211,96,253,47,173,5,40,160,91,158,172,71,162,151,173,76,125,140,55,236,172,210,255,215,66,61,175,141,147,249,164,150,195,181,174,179,148,225,44,229,204,235,16,237,105,120,234,216,43,120,31,77,138,232,128,92,149,166,236,155,189,15,7,38,70,141,120,64,51,216,244,96,249,60,63,68,98,253,110,99,116,16,122,201,29,130,190,125,67,93,243,23,244,178,159,211,106,67,39,109,222,84,206,153,204,79,164,252,207,48,115,49,15,91,26,67,22,115,83,91,232,83,17,153,121,113,222,254,59,104,104,118,213,154,190,196,87,248,223,223,34,75,216,237,49,42,0,0 };
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


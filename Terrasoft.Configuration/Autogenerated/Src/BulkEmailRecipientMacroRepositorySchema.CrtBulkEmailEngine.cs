﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailRecipientMacroRepositorySchema

	/// <exclude/>
	public class BulkEmailRecipientMacroRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailRecipientMacroRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailRecipientMacroRepositorySchema(BulkEmailRecipientMacroRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f21e75ff-18af-4453-8d4a-578418fcde6a");
			Name = "BulkEmailRecipientMacroRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,86,91,111,219,54,20,126,86,129,254,7,194,123,145,1,67,202,176,183,197,22,208,56,89,225,109,105,189,56,233,107,65,75,199,49,87,137,212,120,113,226,22,249,239,59,36,37,155,178,236,56,245,139,205,203,57,223,119,190,115,161,57,173,64,213,52,7,114,15,82,82,37,86,58,153,10,190,98,143,70,82,205,4,127,255,238,199,251,119,145,81,140,63,146,197,86,105,168,46,15,214,120,191,44,33,183,151,85,242,17,56,72,150,247,238,252,205,248,127,251,205,169,168,42,193,195,181,132,238,42,185,190,218,111,124,130,39,141,206,45,183,63,149,179,195,163,95,36,60,34,36,153,150,84,169,223,201,149,41,191,221,84,148,149,119,144,179,154,1,215,183,52,151,226,14,106,161,152,22,114,235,140,210,52,37,99,101,170,138,202,109,214,172,231,82,108,88,1,138,84,160,215,162,80,68,11,34,129,22,132,242,130,40,186,1,82,80,77,201,74,200,83,32,4,127,48,189,77,90,128,52,64,168,205,178,100,57,201,45,203,183,144,140,126,56,162,251,240,48,112,77,185,198,16,231,146,109,168,6,127,94,251,5,201,237,57,97,92,147,175,21,125,158,83,137,9,213,32,213,84,24,174,231,32,255,49,32,183,87,84,231,107,50,33,191,94,92,92,92,54,254,129,23,30,162,139,247,7,131,178,56,5,102,101,17,188,220,146,7,5,18,153,113,159,118,242,213,116,214,103,32,92,72,210,228,24,176,5,114,2,249,27,135,233,113,27,51,206,52,163,37,251,142,41,162,132,195,19,70,107,37,193,154,21,43,162,215,128,38,128,66,72,88,77,6,103,21,30,164,153,79,70,178,3,76,15,17,199,181,149,145,112,148,114,50,232,134,54,200,238,17,208,238,89,229,155,205,100,156,58,11,231,160,73,248,89,34,241,129,134,93,156,33,177,109,23,69,7,202,98,14,123,82,71,209,203,235,122,223,250,186,62,145,83,91,58,83,90,230,166,196,213,116,109,248,55,21,219,189,202,210,245,101,52,114,151,114,81,154,138,251,157,150,222,134,74,210,150,157,194,106,115,246,72,242,150,234,117,242,97,169,226,179,69,153,118,253,186,120,34,9,218,72,78,44,143,161,115,53,5,86,226,36,136,3,82,104,25,23,2,197,134,97,143,193,48,148,165,13,116,35,88,129,197,132,242,249,84,40,71,0,84,252,209,224,193,178,205,215,172,24,57,14,209,236,134,155,10,36,69,132,113,248,251,47,216,126,161,165,129,57,101,114,108,109,71,4,203,25,217,101,89,214,168,214,120,14,85,202,141,148,88,4,215,150,201,132,216,175,123,86,65,242,160,243,79,226,201,71,141,19,6,40,74,18,219,251,75,167,14,227,199,61,58,151,204,197,226,180,68,151,182,49,124,116,241,65,209,12,147,25,215,34,62,213,27,131,70,244,46,190,135,181,4,28,147,29,112,20,160,38,78,7,21,183,14,58,103,11,208,241,96,135,244,48,43,6,35,236,124,155,234,100,87,16,77,62,19,148,116,120,218,137,207,214,43,230,142,198,43,14,174,246,185,61,230,37,72,253,206,201,139,255,10,93,221,60,67,110,52,180,209,190,252,84,231,157,27,114,11,124,103,148,27,102,170,70,205,86,12,10,156,182,141,120,109,50,236,19,212,189,98,169,19,176,220,223,58,206,130,96,253,44,219,187,32,248,10,226,67,134,142,101,103,162,245,124,200,78,253,168,253,251,239,61,246,120,231,187,11,199,38,229,134,73,109,104,233,251,211,234,208,111,72,114,205,156,57,70,229,59,206,101,32,108,202,93,138,29,165,25,95,9,108,198,147,60,195,198,172,119,211,9,167,135,111,160,59,241,132,13,245,219,229,190,121,221,88,244,99,103,210,155,150,39,97,146,102,122,30,135,24,94,6,35,52,232,113,68,56,233,209,87,37,86,181,93,199,207,100,146,185,190,63,61,146,226,103,219,92,35,98,255,55,225,68,216,32,52,90,75,255,158,126,94,254,235,220,180,13,52,76,22,117,201,244,103,142,189,161,85,28,68,221,112,61,54,61,59,121,234,14,171,112,10,31,173,122,196,81,208,86,137,103,108,255,125,5,239,249,153,28,227,107,254,214,194,223,216,24,7,217,66,24,153,31,96,246,171,221,63,64,42,251,41,38,227,180,53,11,170,251,140,153,151,160,127,16,55,106,56,214,109,185,54,207,98,152,203,107,80,221,108,142,207,117,69,236,93,190,242,199,193,239,134,155,184,99,63,255,3,68,209,222,43,45,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f21e75ff-18af-4453-8d4a-578418fcde6a"));
		}

		#endregion

	}

	#endregion

}


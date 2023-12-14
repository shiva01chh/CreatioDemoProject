﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountServiceApiSchema

	/// <exclude/>
	public class AccountServiceApiSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountServiceApiSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountServiceApiSchema(AccountServiceApiSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4db0ce7d-3875-48f8-ab5c-a9ba8c18e7ab");
			Name = "AccountServiceApi";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,87,77,115,219,56,12,61,187,51,253,15,172,187,7,121,198,43,223,155,216,25,199,77,182,222,182,73,198,118,183,199,12,35,193,182,90,89,212,146,84,82,111,38,255,125,1,146,250,180,100,183,59,155,75,44,16,0,65,224,225,129,76,248,14,84,202,3,96,43,144,146,43,177,214,254,76,36,235,104,147,73,174,35,145,188,126,245,252,250,85,47,83,81,178,97,203,189,210,176,243,111,64,159,21,178,14,51,255,50,221,137,36,142,18,152,197,34,11,231,137,134,141,93,105,55,149,80,202,233,203,58,99,227,134,82,125,147,46,87,254,53,15,180,144,17,168,82,99,1,74,47,183,92,166,40,66,225,91,9,27,244,192,102,49,87,234,29,155,6,129,200,18,189,4,249,24,5,48,77,35,163,52,26,141,216,185,202,118,59,46,247,19,247,125,39,197,99,20,130,98,60,141,152,22,76,65,18,50,137,57,20,137,2,18,192,15,13,50,225,49,227,214,39,106,24,167,126,238,112,84,241,152,102,15,113,20,176,128,162,104,11,162,247,108,2,41,195,197,93,52,79,52,134,124,39,163,71,174,193,174,55,35,53,130,213,22,216,19,60,108,133,248,222,12,134,125,89,124,98,202,148,19,69,90,83,134,2,17,66,225,171,26,100,47,181,91,161,6,238,206,148,150,164,94,143,246,139,140,17,29,75,235,106,134,158,176,116,253,165,8,34,30,31,40,246,207,220,161,48,117,246,92,245,67,94,71,16,135,205,19,230,49,72,224,33,2,107,159,135,113,175,2,145,194,89,93,105,30,66,162,35,189,167,61,65,186,146,73,118,31,181,202,155,198,4,149,89,28,161,42,187,151,197,239,19,65,155,202,200,140,112,71,161,155,186,30,169,77,69,157,137,53,227,22,2,126,123,254,141,36,229,146,239,88,130,253,58,238,103,88,70,244,144,64,64,109,208,159,204,13,42,176,172,232,234,75,109,205,63,31,25,195,118,63,38,119,253,9,1,133,4,100,158,167,136,153,181,154,185,3,235,1,76,189,250,150,172,30,221,48,175,148,113,56,96,68,39,189,158,45,27,130,36,47,31,202,26,110,198,13,71,70,233,229,120,21,176,164,41,72,141,157,255,51,13,50,47,206,106,240,192,210,28,40,145,203,167,143,180,161,51,153,40,134,48,224,120,122,181,133,176,80,43,170,53,95,215,214,35,197,146,44,142,153,222,66,194,2,4,44,130,42,170,84,232,92,1,144,124,61,238,183,3,181,63,154,176,220,247,90,138,93,213,194,16,150,229,183,61,234,117,32,230,68,35,116,136,199,19,91,155,246,54,97,23,23,204,235,90,27,179,153,57,104,187,103,111,48,56,209,62,245,194,9,141,37,135,240,72,233,254,0,173,40,193,199,8,174,51,55,206,125,39,147,57,140,110,64,187,95,189,71,46,243,157,14,181,199,149,137,229,151,44,168,172,105,207,199,88,255,226,113,6,141,62,25,158,162,208,129,191,18,75,19,162,55,176,29,210,139,214,204,179,81,251,115,117,131,32,187,149,87,187,84,239,189,174,224,6,121,195,245,122,122,43,197,19,75,224,9,195,221,225,112,246,231,200,254,55,66,95,163,69,120,245,35,128,148,162,242,78,5,229,34,121,177,255,164,233,143,206,220,88,229,151,74,231,118,87,19,153,80,229,85,37,218,69,74,52,28,188,198,5,100,25,22,240,56,62,202,144,143,148,228,218,244,171,184,169,24,150,122,37,20,170,164,95,249,121,0,4,42,64,101,40,176,55,99,211,235,101,150,93,66,234,131,163,146,176,170,241,216,84,163,220,174,40,115,69,201,159,134,225,123,88,243,44,214,31,112,244,97,47,245,17,66,26,87,126,95,237,145,188,135,172,207,211,20,121,217,220,136,70,223,20,206,131,220,77,87,44,54,20,76,54,118,60,171,7,100,114,115,118,170,94,4,100,186,13,228,67,230,84,163,53,152,189,241,249,204,48,193,103,236,4,181,127,6,189,21,157,215,130,14,70,59,78,74,174,104,212,220,245,81,51,149,27,87,156,202,156,70,97,182,163,42,53,199,239,176,113,32,151,126,151,253,42,97,19,21,156,183,71,51,241,14,66,24,84,235,144,31,148,208,178,128,191,51,66,182,61,157,251,250,26,233,237,74,124,135,196,17,4,203,100,1,75,39,209,180,204,198,22,28,237,97,80,132,216,197,160,148,241,69,78,11,106,248,192,147,48,6,207,142,238,193,25,27,141,250,174,239,125,51,229,34,225,175,177,23,238,185,177,207,81,72,217,149,46,224,18,240,46,104,143,130,204,211,101,36,132,247,28,232,211,12,75,46,163,127,184,75,243,111,253,75,224,18,203,250,108,78,242,210,175,103,218,121,104,203,218,138,40,102,225,110,233,239,185,230,231,171,137,55,183,129,88,33,10,138,107,252,192,120,125,218,130,36,203,119,236,146,43,112,212,150,171,15,233,36,5,130,138,0,236,226,133,79,91,208,188,164,227,174,188,214,66,174,216,18,145,238,242,64,225,88,128,179,157,249,87,220,154,48,65,67,38,30,190,33,42,216,131,8,247,183,246,231,152,133,150,20,126,57,214,42,128,202,186,116,64,233,176,60,78,229,90,200,29,39,67,58,169,253,240,255,84,238,146,86,40,187,35,141,221,161,236,34,81,104,229,36,111,202,163,80,132,111,113,249,230,106,117,189,152,126,190,250,122,187,248,152,51,89,1,142,75,52,173,216,83,120,111,33,86,112,160,72,225,180,42,39,97,180,174,240,96,39,12,48,238,146,155,253,171,31,16,100,154,20,60,183,137,203,204,108,11,193,247,220,30,83,113,37,165,144,94,129,165,26,68,27,40,108,104,253,60,3,158,190,32,153,168,84,121,22,154,162,144,119,50,14,219,32,200,164,132,240,216,60,213,56,95,170,175,133,85,127,98,112,93,92,147,203,103,239,222,60,21,10,131,246,215,70,174,94,127,175,184,113,111,86,234,207,141,98,124,60,138,40,100,173,105,254,127,219,152,144,89,132,178,212,92,103,202,60,101,17,162,31,180,78,75,137,127,251,177,152,248,174,79,129,194,249,140,188,199,55,4,156,194,13,101,236,194,191,170,174,94,92,20,119,5,167,212,88,46,173,221,168,175,201,108,24,239,65,5,50,74,139,135,81,237,146,117,26,65,167,222,167,196,77,246,42,150,138,146,40,126,17,45,39,17,129,244,98,95,159,116,91,63,250,82,45,123,216,26,208,183,163,197,67,67,219,108,106,178,224,79,149,6,160,135,212,244,110,142,234,249,122,229,81,107,217,248,78,20,220,72,200,58,74,193,255,117,72,180,178,190,127,119,187,92,13,237,78,117,186,234,170,169,149,214,133,70,70,127,255,2,10,166,211,95,214,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4db0ce7d-3875-48f8-ab5c-a9ba8c18e7ab"));
		}

		#endregion

	}

	#endregion

}


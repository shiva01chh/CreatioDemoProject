﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountAnniversaryRemindingSchema

	/// <exclude/>
	public class AccountAnniversaryRemindingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountAnniversaryRemindingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountAnniversaryRemindingSchema(AccountAnniversaryRemindingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e9ea5704-c35b-4cf3-994e-53f638b244ee");
			Name = "AccountAnniversaryReminding";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e07b3414-0244-4600-8fa5-7c3b4f179d09");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,85,203,110,219,48,16,60,59,64,254,97,161,94,100,192,144,239,137,35,32,175,6,110,145,38,141,211,222,25,113,109,19,144,72,133,164,18,24,69,254,189,43,146,146,229,216,82,155,67,81,195,54,192,229,236,99,102,201,165,100,5,154,146,101,8,143,168,53,51,106,105,147,75,37,151,98,85,105,102,133,146,199,71,191,142,143,70,149,17,114,5,139,141,177,88,156,190,91,19,62,207,49,171,193,38,185,65,137,90,100,91,76,55,108,81,40,121,120,71,99,159,61,185,186,168,183,232,251,73,227,138,114,192,101,206,140,57,129,243,44,83,149,180,231,82,138,23,212,134,233,205,3,22,66,114,10,113,124,68,240,178,122,202,69,6,89,141,30,2,195,9,92,48,131,135,227,140,106,242,109,230,207,2,115,78,169,239,93,104,151,165,73,99,44,169,149,129,70,198,149,204,55,180,214,117,236,144,247,174,172,213,129,51,136,130,33,58,253,179,47,181,193,178,172,227,27,12,181,175,171,10,37,247,133,133,117,163,15,245,193,234,42,179,74,239,150,58,157,78,97,102,170,162,32,142,105,99,232,160,147,22,84,50,205,10,144,116,54,206,162,202,160,38,144,244,29,142,210,31,59,107,16,228,206,100,134,201,108,234,188,218,192,179,105,55,85,160,58,208,135,248,93,224,221,188,227,19,120,162,46,197,239,172,224,250,51,90,100,107,44,216,55,170,119,79,227,209,66,85,58,195,57,167,157,54,151,35,109,146,0,244,230,6,231,188,222,254,139,98,221,32,130,71,233,101,165,53,74,75,39,35,83,154,195,156,255,99,145,39,112,83,9,14,130,147,218,118,45,76,143,218,15,174,28,167,168,216,145,171,239,68,222,162,93,43,119,113,180,178,20,11,249,128,188,15,104,43,45,13,24,172,135,10,188,10,187,6,150,231,176,20,185,37,54,176,84,26,178,32,12,253,132,221,28,238,130,247,143,210,133,143,83,187,173,208,218,250,102,177,173,50,164,109,144,102,184,29,207,21,234,13,149,95,162,182,155,40,253,94,47,161,12,235,157,154,124,222,15,68,75,190,34,69,236,116,43,208,2,227,78,181,115,249,64,180,159,44,175,48,74,31,215,184,173,143,35,73,71,60,209,128,221,148,8,106,73,253,69,50,83,35,221,148,223,47,87,251,54,164,183,138,139,165,64,254,145,126,204,166,141,119,207,57,109,142,1,40,162,172,5,71,8,93,186,242,21,161,95,198,193,234,83,79,128,132,114,236,238,153,208,51,63,37,39,97,90,166,176,163,66,115,84,197,18,226,61,177,147,235,231,138,229,38,110,7,234,184,129,143,66,243,190,40,33,227,250,239,145,212,74,230,116,1,244,100,59,127,199,30,59,74,238,100,220,14,27,218,191,215,162,166,24,96,115,30,141,147,185,113,185,182,169,8,86,111,248,209,244,230,254,189,86,129,100,247,58,29,144,233,69,209,253,156,75,97,191,119,72,9,52,113,195,160,30,146,201,65,128,79,121,206,121,119,103,211,37,224,149,76,174,139,146,4,236,131,111,137,236,195,251,235,190,18,110,130,144,58,109,223,134,154,153,194,13,122,6,254,245,51,91,255,150,233,11,211,160,182,187,52,140,220,11,145,12,120,122,78,29,167,132,248,197,59,111,244,4,36,190,14,214,214,171,88,79,248,157,103,252,111,194,247,40,28,194,135,211,210,201,50,48,129,189,181,107,116,150,250,243,27,12,123,177,149,249,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9ea5704-c35b-4cf3-994e-53f638b244ee"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountInfoResponseSchema

	/// <exclude/>
	public class AccountInfoResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountInfoResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountInfoResponseSchema(AccountInfoResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("126bd8c9-55dd-b001-f748-1309e196c95f");
			Name = "AccountInfoResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,91,107,195,32,20,126,110,32,255,225,64,223,147,247,117,12,70,54,74,161,176,210,203,15,48,230,36,21,18,13,30,221,86,194,254,251,212,92,200,70,9,245,65,240,243,187,29,84,178,6,169,101,28,225,140,90,51,82,165,73,50,37,75,81,89,205,140,80,50,57,41,46,88,189,71,86,108,81,198,81,23,71,43,75,66,86,112,186,145,193,102,19,71,14,89,107,172,28,25,178,154,17,61,193,43,231,202,74,179,147,165,58,58,123,37,9,3,45,77,83,120,38,219,52,76,223,94,134,243,219,249,3,244,64,130,47,97,174,32,156,76,55,33,29,88,174,172,1,214,251,37,163,69,58,243,104,109,94,11,14,220,39,223,15,94,117,33,124,42,121,208,170,69,109,4,186,166,135,160,238,239,255,183,11,192,142,198,116,192,111,65,134,146,137,58,111,49,214,200,149,170,157,102,232,241,30,20,208,65,133,102,3,228,183,159,133,172,65,5,162,88,14,217,90,81,76,163,22,15,219,207,70,97,220,136,79,124,112,20,79,125,56,36,211,232,95,14,46,199,253,178,61,25,237,127,209,192,191,232,250,94,196,26,101,209,191,90,56,247,232,95,48,96,126,253,2,129,44,174,234,203,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("126bd8c9-55dd-b001-f748-1309e196c95f"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,221,106,131,48,20,190,174,224,59,28,232,189,222,175,99,48,220,40,133,194,74,127,30,32,141,71,27,208,68,206,73,182,21,217,187,47,70,43,110,20,105,46,2,249,242,253,29,18,45,106,228,70,72,132,35,18,9,54,133,77,50,163,11,85,58,18,86,25,157,28,140,84,162,218,162,200,215,168,227,168,141,163,133,99,165,75,56,92,217,98,189,138,35,143,44,9,75,79,134,172,18,204,79,240,42,165,113,218,110,116,97,246,222,222,104,198,64,75,211,20,158,217,213,181,160,235,203,112,126,59,126,0,13,36,248,82,246,2,202,203,168,14,233,32,206,198,89,16,189,95,114,179,72,39,30,141,59,87,74,130,236,146,239,7,47,218,16,62,150,220,145,105,144,172,66,223,116,23,212,253,253,255,118,1,216,240,45,29,240,91,177,229,100,164,78,91,220,106,156,141,169,188,102,232,241,30,20,208,66,137,118,5,220,109,63,51,89,131,10,84,62,31,178,118,42,31,71,205,31,182,159,140,34,164,85,159,248,224,40,29,245,225,144,140,176,123,57,56,237,183,243,246,108,169,251,69,3,255,68,213,189,136,37,234,188,127,181,112,238,209,191,96,192,252,250,5,168,200,1,116,202,2,0,0 };
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


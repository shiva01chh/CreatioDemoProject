namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountRestResponseSchema

	/// <exclude/>
	public class AccountRestResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountRestResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountRestResponseSchema(AccountRestResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c549c9b6-fa79-24e6-145a-6a71c2ee8ca3");
			Name = "AccountRestResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,93,139,195,32,16,124,110,32,255,97,161,239,201,123,123,28,148,28,148,66,161,165,31,63,192,232,38,39,36,26,86,237,81,194,253,247,139,38,233,165,71,9,39,168,56,142,51,179,139,138,213,104,26,198,17,46,72,196,140,46,108,146,105,85,200,210,17,179,82,171,228,172,185,100,213,30,153,216,162,138,163,54,142,22,206,72,85,194,249,110,44,214,235,56,234,144,37,97,217,145,33,171,152,49,43,216,112,174,157,178,39,52,126,54,90,25,12,180,52,77,225,205,184,186,102,116,127,31,206,89,165,157,0,26,104,240,113,57,192,151,180,159,32,85,161,169,14,25,128,229,218,89,96,189,106,50,10,165,19,165,198,229,149,228,192,189,255,43,123,88,193,83,33,254,238,72,250,38,5,210,111,196,69,27,98,62,202,233,24,13,146,149,216,213,116,12,14,253,253,223,58,2,48,184,130,20,201,131,51,141,56,102,220,58,41,70,242,78,64,11,37,218,53,24,191,124,207,200,239,204,216,128,110,183,242,134,243,46,185,214,85,247,102,19,168,255,54,201,8,125,199,225,122,218,207,203,27,75,254,15,12,252,43,85,175,44,150,168,68,223,201,112,238,209,103,48,96,211,241,3,20,172,27,55,145,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c549c9b6-fa79-24e6-145a-6a71c2ee8ca3"));
		}

		#endregion

	}

	#endregion

}


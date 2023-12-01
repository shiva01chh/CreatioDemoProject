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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,93,139,195,32,16,124,110,160,255,97,161,239,201,123,123,28,148,28,148,66,161,165,31,63,192,196,77,78,48,26,86,237,81,194,253,247,83,147,244,218,163,132,19,84,28,199,153,217,69,197,26,52,45,43,17,206,72,196,140,174,108,154,107,85,137,218,17,179,66,171,244,164,75,193,228,14,25,223,160,154,39,221,60,153,57,35,84,13,167,155,177,216,172,230,137,71,22,132,181,39,67,46,153,49,75,88,151,165,118,202,30,209,132,217,106,101,48,210,178,44,131,55,227,154,134,209,237,125,56,231,82,59,14,52,208,224,227,188,135,47,97,63,65,168,74,83,19,51,0,43,180,179,192,122,213,116,20,202,30,148,90,87,72,81,66,25,252,95,217,195,18,158,10,9,119,7,210,87,193,145,126,35,206,186,24,243,94,142,103,180,72,86,160,175,233,16,29,250,251,191,117,68,96,112,5,193,211,59,231,49,226,152,113,227,4,31,201,91,14,29,212,104,87,96,194,242,61,33,191,53,99,3,252,110,197,21,167,93,10,173,165,127,179,142,212,127,155,228,132,161,227,112,57,238,166,229,141,165,240,7,6,254,133,228,43,139,5,42,222,119,50,158,123,244,25,140,152,31,63,46,76,54,7,136,2,0,0 };
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


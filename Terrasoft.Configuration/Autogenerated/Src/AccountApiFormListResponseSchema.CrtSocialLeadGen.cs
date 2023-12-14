namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountApiFormListResponseSchema

	/// <exclude/>
	public class AccountApiFormListResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountApiFormListResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountApiFormListResponseSchema(AccountApiFormListResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c594cadb-29f2-49ba-adfb-e460ee13e9d5");
			Name = "AccountApiFormListResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,65,79,194,64,16,133,207,144,240,31,38,112,209,75,123,7,66,66,48,26,12,81,34,220,140,135,101,119,90,55,182,187,205,236,22,67,136,255,221,233,182,168,20,68,123,104,210,55,243,190,125,59,83,35,114,116,133,144,8,107,36,18,206,38,62,154,89,147,232,180,36,225,181,53,209,202,74,45,178,5,10,117,135,166,215,221,247,186,157,210,105,147,194,3,190,123,107,130,227,222,89,51,250,42,172,118,206,99,206,152,44,67,89,49,92,196,86,36,45,185,135,187,6,132,41,171,48,203,132,115,67,152,74,105,75,227,167,133,190,181,148,47,180,243,79,28,137,93,24,186,227,56,134,177,43,243,92,208,110,210,124,223,172,31,193,191,10,15,10,157,36,189,33,132,233,114,14,212,248,32,33,155,131,168,185,224,144,182,90,98,116,96,197,63,96,69,185,201,180,4,89,37,185,16,4,134,112,52,6,214,253,146,236,86,43,164,239,176,157,125,8,220,190,95,5,171,11,71,167,213,114,231,96,250,114,49,183,64,242,26,217,186,12,134,166,225,185,154,114,83,221,93,245,181,234,95,191,132,66,131,205,44,207,126,174,96,15,41,250,17,95,155,95,31,231,189,134,183,222,114,59,79,97,169,92,249,15,33,211,230,13,213,220,204,8,133,71,181,214,191,1,23,167,141,167,252,75,39,172,188,240,165,187,12,175,123,206,230,30,160,81,245,100,107,161,209,219,242,95,211,111,133,75,120,121,135,76,77,164,234,127,25,87,75,157,132,213,158,77,211,58,181,86,143,197,160,85,207,39,240,4,26,162,154,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c594cadb-29f2-49ba-adfb-e460ee13e9d5"));
		}

		#endregion

	}

	#endregion

}


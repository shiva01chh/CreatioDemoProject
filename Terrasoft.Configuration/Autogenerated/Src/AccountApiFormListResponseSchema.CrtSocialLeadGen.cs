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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,65,79,194,64,16,133,207,144,240,31,38,112,209,75,123,7,66,66,48,26,12,81,34,220,140,135,101,119,168,27,219,221,102,118,139,33,196,255,238,116,91,16,10,162,61,52,233,155,121,223,190,157,169,17,25,186,92,72,132,37,18,9,103,215,62,154,88,179,214,73,65,194,107,107,162,133,149,90,164,51,20,234,1,77,167,189,235,180,91,133,211,38,129,39,252,244,214,4,199,163,179,102,112,40,44,182,206,99,198,152,52,69,89,50,92,196,86,36,45,185,135,187,122,132,9,171,48,73,133,115,125,24,75,105,11,227,199,185,190,183,148,205,180,243,47,28,137,93,24,186,227,56,134,161,43,178,76,208,118,84,127,223,45,159,193,191,11,15,10,157,36,189,34,132,241,124,10,84,251,96,77,54,3,81,113,193,33,109,180,196,104,207,138,143,96,121,177,74,181,4,89,38,185,18,4,250,112,50,6,214,253,156,236,70,43,164,159,176,173,93,8,220,188,95,9,171,10,39,167,85,114,107,111,58,184,152,155,35,121,141,108,157,7,67,221,240,90,78,185,174,110,111,186,90,117,111,223,66,161,198,166,150,103,63,85,176,131,4,253,128,175,205,175,175,203,94,195,91,111,184,157,167,176,84,174,252,135,144,106,243,129,106,106,38,132,194,163,90,234,223,128,179,243,198,115,254,181,19,22,94,248,194,93,135,87,61,23,115,247,208,168,106,178,149,80,235,77,249,175,233,55,194,173,121,121,251,76,117,164,242,127,25,150,75,29,133,213,94,76,211,56,181,82,79,197,160,29,63,223,92,30,39,96,162,3,0,0 };
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


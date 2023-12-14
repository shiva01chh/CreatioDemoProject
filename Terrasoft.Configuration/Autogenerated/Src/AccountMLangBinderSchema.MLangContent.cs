namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountMLangBinderSchema

	/// <exclude/>
	public class AccountMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountMLangBinderSchema(AccountMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2b2c9475-0367-40a6-8f73-d4237f998eae");
			Name = "AccountMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,193,106,195,48,12,61,167,208,127,16,221,165,131,145,220,215,82,88,203,6,133,148,13,54,216,217,113,212,204,144,216,193,150,195,74,217,191,79,177,157,209,110,243,197,88,239,233,233,61,89,139,14,93,47,36,194,27,90,43,156,57,82,190,51,250,168,26,111,5,41,163,231,179,243,124,150,121,167,116,115,69,177,152,63,9,73,198,42,116,171,127,24,239,88,49,171,235,140,102,148,241,27,139,13,203,193,174,21,206,221,195,131,148,198,107,58,148,66,55,91,165,107,180,129,85,20,5,172,157,239,58,97,79,155,244,78,84,232,124,75,170,101,190,23,13,130,28,117,160,10,173,249,212,89,92,180,246,190,106,149,76,188,191,227,128,61,244,253,227,128,154,74,229,8,53,218,173,112,200,141,231,224,228,199,240,1,233,195,212,108,249,37,8,70,48,137,155,129,243,170,26,97,48,170,134,103,205,138,175,36,44,45,39,105,94,37,225,39,129,140,247,45,140,203,204,178,138,39,229,23,244,9,94,5,52,172,40,46,247,148,143,110,215,251,50,197,222,19,242,183,24,123,55,37,250,13,108,150,139,132,44,162,218,87,74,131,186,142,129,194,59,86,175,139,92,27,207,55,179,210,63,139,18,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b2c9475-0367-40a6-8f73-d4237f998eae"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,193,106,195,48,12,61,167,208,127,48,221,165,131,145,220,215,82,88,203,6,133,148,13,54,216,217,113,212,204,144,200,193,150,195,74,217,191,79,177,157,209,110,243,197,88,239,233,233,61,25,101,7,174,151,10,196,27,88,43,157,57,82,190,51,120,212,141,183,146,180,193,249,236,60,159,101,222,105,108,174,40,22,242,39,169,200,88,13,110,245,15,227,29,42,102,117,157,65,70,25,191,177,208,176,156,216,181,210,185,123,241,160,148,241,72,135,82,98,179,213,88,131,13,172,162,40,196,218,249,174,147,246,180,73,239,68,21,157,111,73,183,204,247,178,1,161,70,29,81,133,214,124,234,44,46,90,123,95,181,90,37,222,223,113,130,61,244,253,227,0,72,165,118,4,8,118,43,29,112,227,57,56,249,49,124,0,250,48,53,91,126,9,130,17,76,226,102,224,188,186,6,49,24,93,139,103,100,197,87,146,150,150,147,52,175,146,224,147,132,138,247,173,24,151,153,101,21,79,202,47,232,19,188,10,104,88,81,92,238,41,31,221,174,247,101,138,189,39,224,111,49,246,110,74,244,27,216,44,23,9,89,68,181,175,148,6,176,142,129,194,59,86,175,139,92,227,243,13,118,41,0,142,17,2,0,0 };
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


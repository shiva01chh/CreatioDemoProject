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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,193,106,195,48,12,61,183,208,127,48,221,165,131,145,220,215,82,88,203,6,133,148,13,54,216,217,113,212,204,144,200,193,150,195,74,217,191,79,177,157,145,110,243,197,88,239,233,233,61,25,101,11,174,147,10,196,27,88,43,157,57,81,182,55,120,210,181,183,146,180,193,197,252,178,152,207,188,211,88,95,81,44,100,79,82,145,177,26,220,250,31,198,59,148,204,106,91,131,140,50,126,99,161,102,57,177,111,164,115,247,226,65,41,227,145,142,133,196,122,167,177,2,27,88,121,158,139,141,243,109,43,237,121,155,222,137,42,90,223,144,110,152,239,101,13,66,13,58,162,12,173,217,216,153,79,90,59,95,54,90,37,222,223,113,130,61,116,221,99,15,72,133,118,4,8,118,39,29,112,227,37,56,249,49,124,4,250,48,21,91,126,9,130,17,76,226,166,231,188,186,2,209,27,93,137,103,100,197,87,146,150,86,163,52,175,146,224,147,132,138,247,173,24,150,57,155,149,60,41,155,208,71,120,29,208,176,162,184,220,115,54,184,221,28,138,20,251,64,192,223,98,236,221,152,232,55,176,93,45,19,178,140,106,95,41,13,96,21,3,133,119,172,94,23,185,54,61,223,221,52,150,148,26,2,0,0 };
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


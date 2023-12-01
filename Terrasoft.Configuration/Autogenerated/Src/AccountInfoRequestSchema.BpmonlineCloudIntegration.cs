namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountInfoRequestSchema

	/// <exclude/>
	public class AccountInfoRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountInfoRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountInfoRequestSchema(AccountInfoRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d34c2d1e-3df3-49cb-81c1-5fa5d286583e");
			Name = "AccountInfoRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,193,78,195,48,12,61,111,210,254,193,26,23,184,180,247,109,32,141,130,16,66,67,211,182,27,226,224,101,110,137,104,147,17,59,147,202,196,191,147,164,172,8,132,68,14,137,252,236,231,231,231,24,108,136,247,168,8,54,228,28,178,45,37,43,172,41,117,229,29,138,182,38,43,110,215,11,187,163,154,71,195,227,104,56,26,14,60,107,83,193,186,101,161,38,91,121,35,186,161,108,77,78,99,173,223,19,103,154,234,206,28,85,33,128,162,70,230,9,204,149,178,161,248,222,148,118,69,111,158,88,82,213,211,13,10,6,69,113,168,228,57,0,123,191,173,181,2,21,89,127,144,96,2,215,200,20,244,14,90,81,223,105,208,205,214,139,46,157,221,147,19,77,65,121,153,58,118,249,60,207,97,198,190,105,208,181,87,39,224,142,132,193,58,224,248,202,11,1,250,112,7,99,42,217,129,87,106,179,158,156,255,102,207,14,88,123,234,195,205,127,252,239,242,228,125,65,205,150,220,249,99,248,8,184,132,113,164,62,80,59,190,136,187,56,45,131,197,197,157,207,187,28,28,161,34,153,198,113,167,240,241,229,155,204,174,179,158,226,14,253,9,38,44,156,79,38,0,67,79,243,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d34c2d1e-3df3-49cb-81c1-5fa5d286583e"));
		}

		#endregion

	}

	#endregion

}


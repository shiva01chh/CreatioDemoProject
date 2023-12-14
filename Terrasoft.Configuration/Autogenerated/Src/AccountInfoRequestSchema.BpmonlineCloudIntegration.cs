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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,193,78,195,48,12,61,175,82,255,193,26,23,184,180,247,109,32,141,129,16,66,67,211,182,27,226,224,101,94,137,104,147,17,59,147,202,196,191,147,164,172,8,132,68,14,137,252,236,231,231,231,24,108,136,247,168,8,214,228,28,178,221,73,49,179,102,167,43,239,80,180,53,197,236,118,53,183,91,170,57,207,142,121,150,103,3,207,218,84,176,106,89,168,41,150,222,136,110,168,88,145,211,88,235,247,196,25,167,186,51,71,85,8,96,86,35,243,8,166,74,217,80,124,111,118,118,73,111,158,88,82,213,211,13,10,6,69,113,168,228,57,0,123,191,169,181,2,21,89,127,144,96,4,215,200,20,244,14,90,81,223,105,208,205,214,139,46,156,221,147,19,77,65,121,145,58,118,249,178,44,97,194,190,105,208,181,87,39,224,142,132,193,58,224,248,202,11,1,250,112,7,99,42,217,129,87,106,139,158,92,254,102,79,14,88,123,234,195,245,127,252,239,242,228,125,78,205,134,220,249,99,248,8,184,132,97,164,62,80,59,188,136,187,56,45,131,197,197,157,79,187,28,28,161,34,25,199,113,199,240,241,229,155,204,182,179,158,226,14,253,9,38,44,158,79,110,192,149,224,244,1,0,0 };
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


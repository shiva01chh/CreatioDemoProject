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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,193,78,195,48,12,61,111,210,254,193,26,23,184,180,247,117,32,141,129,16,66,67,211,186,27,226,224,101,110,137,104,147,17,59,147,202,196,191,147,166,172,3,132,68,14,137,252,236,231,231,231,24,172,137,119,168,8,214,228,28,178,45,36,153,91,83,232,210,59,20,109,77,50,191,205,23,118,75,21,143,134,135,209,112,52,28,120,214,166,132,188,97,161,58,89,121,35,186,166,36,39,167,177,210,239,145,147,197,186,51,71,101,8,96,94,33,243,4,102,74,217,80,124,111,10,187,162,55,79,44,177,234,233,6,5,131,162,56,84,242,28,128,157,223,84,90,129,106,89,127,144,96,2,215,200,20,244,246,90,81,223,105,208,205,214,139,46,157,221,145,19,77,65,121,25,59,118,249,52,77,97,202,190,174,209,53,87,71,224,142,132,193,58,224,246,149,23,2,244,225,14,198,84,180,3,175,212,36,61,57,253,205,158,238,177,242,212,135,235,255,248,167,242,232,125,65,245,134,220,249,99,248,8,184,132,113,75,125,160,102,124,209,238,226,184,12,22,215,238,124,214,229,224,0,37,73,214,142,155,193,199,151,111,50,219,206,122,140,59,244,39,24,177,239,231,19,35,174,170,175,252,1,0,0 };
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


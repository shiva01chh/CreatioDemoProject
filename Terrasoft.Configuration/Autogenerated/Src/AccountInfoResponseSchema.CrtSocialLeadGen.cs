namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountInfoResponseSchema

	/// <exclude/>
	public class AccountInfoResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountInfoResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountInfoResponseSchema(AccountInfoResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("126bd8c9-55dd-b001-f748-1309e196c95f");
			Name = "AccountInfoResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,91,107,131,48,20,126,174,224,127,56,208,119,125,95,199,96,184,81,10,133,149,94,126,64,140,71,123,64,19,201,73,182,21,217,127,159,198,11,110,20,105,30,2,249,242,221,14,137,18,21,114,45,36,194,25,141,17,172,115,27,37,90,229,84,56,35,44,105,21,157,180,36,81,238,81,100,91,84,97,208,132,193,202,49,169,2,78,55,182,88,109,194,160,69,214,6,139,150,12,73,41,152,159,224,85,74,237,148,221,169,92,31,91,123,173,24,61,45,142,99,120,102,87,85,194,220,94,134,243,219,249,3,204,64,130,47,178,87,160,86,102,42,159,14,34,213,206,130,232,253,162,209,34,158,121,212,46,45,73,130,236,146,239,7,175,26,31,62,149,60,24,93,163,177,132,109,211,131,87,247,247,255,219,121,96,199,99,58,224,55,177,229,104,162,206,91,140,53,82,173,203,86,51,244,120,247,10,104,160,64,187,1,238,182,159,133,172,65,5,148,45,135,108,29,101,211,168,217,195,246,179,81,132,180,244,137,15,142,210,81,31,14,73,12,118,47,7,151,227,126,217,158,173,233,126,209,192,191,152,242,94,196,26,85,214,191,154,63,247,232,95,208,99,243,245,11,66,186,87,21,211,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("126bd8c9-55dd-b001-f748-1309e196c95f"));
		}

		#endregion

	}

	#endregion

}


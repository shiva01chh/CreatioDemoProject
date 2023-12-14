namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseWebhookAccountResponseSchema

	/// <exclude/>
	public class BaseWebhookAccountResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseWebhookAccountResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseWebhookAccountResponseSchema(BaseWebhookAccountResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0327d562-7b53-46be-9ae5-db7a20f892a0");
			Name = "BaseWebhookAccountResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8e07ad5d-ca48-4dfc-8107-c7bee2abec1b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,193,74,196,48,16,134,207,91,232,59,12,120,111,239,174,8,107,189,136,130,139,22,60,79,219,105,27,182,201,148,76,130,148,226,187,219,38,221,101,85,48,135,64,190,25,254,249,38,0,6,53,201,136,53,65,73,214,162,112,235,178,130,77,171,58,111,209,41,54,217,11,154,70,153,78,61,25,71,93,100,105,50,167,201,206,203,130,225,125,18,71,122,159,38,11,185,177,212,45,101,40,6,20,185,133,7,20,250,160,170,103,62,29,234,154,189,113,111,203,44,54,66,161,59,207,115,184,19,175,53,218,233,126,123,23,3,251,6,236,214,6,143,229,43,124,42,215,131,50,45,91,29,134,3,86,236,29,96,76,204,206,65,249,85,210,232,171,65,213,80,175,26,255,88,64,84,252,227,182,155,131,223,101,157,163,229,145,172,83,180,236,116,12,209,177,254,123,129,0,202,158,0,71,5,39,154,178,75,211,181,220,217,78,156,93,255,239,48,170,103,154,96,134,142,220,30,100,189,190,182,241,100,154,104,16,222,145,254,132,129,173,231,27,219,33,42,12,201,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0327d562-7b53-46be-9ae5-db7a20f892a0"));
		}

		#endregion

	}

	#endregion

}


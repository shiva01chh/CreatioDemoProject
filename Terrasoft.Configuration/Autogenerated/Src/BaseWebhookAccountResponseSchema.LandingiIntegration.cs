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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,193,106,132,48,16,134,207,43,248,14,3,189,235,189,91,10,91,123,41,45,236,178,21,122,30,117,212,176,154,145,76,66,17,233,187,87,19,119,177,45,52,135,64,190,25,254,249,38,0,26,123,146,1,75,130,156,140,65,225,218,38,25,235,90,53,206,160,85,172,147,55,212,149,210,141,122,209,150,154,192,226,104,138,163,157,147,25,195,251,40,150,250,125,28,205,228,206,80,51,151,33,235,80,228,30,158,80,232,131,138,150,249,114,40,75,118,218,158,231,89,172,133,124,119,154,166,240,32,174,239,209,140,143,235,59,235,216,85,96,214,54,120,206,143,240,169,108,11,74,215,108,122,63,28,176,96,103,1,67,98,114,13,74,55,73,131,43,58,85,66,185,104,252,99,1,65,241,143,219,110,242,126,183,117,78,134,7,50,86,209,188,211,201,71,135,250,239,5,60,200,91,2,28,20,92,104,76,110,77,91,185,171,157,88,179,252,223,97,80,175,52,194,4,13,217,61,200,114,125,173,227,73,87,193,192,191,3,253,9,61,219,158,111,61,80,211,146,209,1,0,0 };
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


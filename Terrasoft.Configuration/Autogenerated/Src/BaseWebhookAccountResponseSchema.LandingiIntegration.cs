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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,193,74,196,48,16,134,207,91,232,59,12,120,111,239,174,8,107,189,136,130,139,22,60,79,219,105,27,182,205,148,76,130,148,226,187,155,38,221,101,85,48,135,64,190,25,254,249,38,0,26,71,146,9,107,130,146,140,65,225,214,102,5,235,86,117,206,160,85,172,179,23,212,141,210,157,122,210,150,186,200,210,100,73,147,157,19,143,225,125,22,75,227,62,77,60,185,49,212,249,50,20,3,138,220,194,3,10,125,80,213,51,159,14,117,205,78,219,55,63,139,181,80,232,206,243,28,238,196,141,35,154,249,126,123,23,3,187,6,204,214,6,143,229,43,124,42,219,131,210,45,155,49,12,7,172,216,89,192,152,152,157,131,242,171,164,201,85,131,170,161,94,53,254,177,128,168,248,199,109,183,4,191,203,58,71,195,19,25,171,200,239,116,12,209,177,254,123,129,0,202,158,0,39,5,39,154,179,75,211,181,220,217,78,172,89,255,239,48,169,103,154,97,129,142,236,30,100,189,190,182,241,164,155,104,16,222,145,254,132,129,249,243,13,231,147,80,147,200,1,0,0 };
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


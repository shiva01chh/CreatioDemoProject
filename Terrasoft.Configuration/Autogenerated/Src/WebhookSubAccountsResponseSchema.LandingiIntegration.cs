namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookSubAccountsResponseSchema

	/// <exclude/>
	public class WebhookSubAccountsResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookSubAccountsResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookSubAccountsResponseSchema(WebhookSubAccountsResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95258480-3f8d-4085-a822-2deac2e3e86d");
			Name = "WebhookSubAccountsResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8e07ad5d-ca48-4dfc-8107-c7bee2abec1b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,193,106,195,48,12,134,207,11,244,29,244,4,201,125,41,133,109,135,50,232,169,29,236,236,56,74,106,150,72,193,146,55,74,233,187,79,105,146,18,182,139,177,127,89,159,62,155,92,143,50,56,143,240,129,49,58,225,70,243,55,166,38,180,41,58,13,76,249,193,81,29,168,13,239,164,216,78,217,38,187,110,178,167,36,22,195,233,34,138,189,245,116,29,250,177,40,249,30,9,99,240,229,38,179,91,69,81,192,86,82,223,187,120,217,205,231,35,14,17,5,73,5,244,140,96,251,193,250,16,154,200,61,252,96,117,102,254,2,231,61,39,82,16,140,223,193,252,144,234,129,3,105,190,64,139,21,117,72,85,23,60,248,206,137,192,231,68,56,165,234,101,98,200,113,153,240,12,175,78,112,142,151,212,250,199,247,252,83,189,7,123,52,75,142,166,49,219,118,65,20,184,121,120,46,126,54,153,125,112,138,53,72,170,102,123,201,31,224,181,238,226,123,48,214,118,214,253,35,181,131,149,63,92,161,69,45,71,137,18,110,6,184,141,127,123,95,178,236,23,60,145,109,122,195,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95258480-3f8d-4085-a822-2deac2e3e86d"));
		}

		#endregion

	}

	#endregion

}


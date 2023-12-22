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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,193,106,195,48,12,134,207,11,244,29,244,4,201,125,41,133,109,135,50,232,169,29,236,236,56,74,106,150,72,193,146,55,74,233,187,79,105,146,18,54,31,140,253,219,250,244,217,228,122,148,193,121,132,15,140,209,9,55,154,191,49,53,161,77,209,105,96,202,15,142,234,64,109,120,39,197,118,202,54,217,117,147,61,37,177,24,78,23,81,236,173,166,235,208,143,135,146,239,145,48,6,95,110,50,187,85,20,5,108,37,245,189,139,151,221,188,63,226,16,81,144,84,64,207,8,182,30,172,14,161,137,220,195,15,86,103,230,47,112,222,115,34,5,193,248,29,204,15,169,30,56,144,230,11,180,88,81,135,84,117,193,131,239,156,8,124,78,132,83,170,94,38,134,28,151,14,207,240,234,4,231,120,73,173,126,124,207,63,213,123,176,71,179,228,104,26,179,109,23,68,129,155,135,231,226,103,157,217,7,167,88,131,164,106,182,151,252,1,94,235,46,190,7,99,109,103,221,63,82,59,88,249,195,21,90,212,114,148,40,225,102,128,219,248,183,247,105,53,126,1,124,6,91,190,204,1,0,0 };
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


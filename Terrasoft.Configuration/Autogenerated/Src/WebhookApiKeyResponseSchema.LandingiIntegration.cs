namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookApiKeyResponseSchema

	/// <exclude/>
	public class WebhookApiKeyResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookApiKeyResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookApiKeyResponseSchema(WebhookApiKeyResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8fce16ad-5709-43b9-bd14-2a8342248eb7");
			Name = "WebhookApiKeyResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,146,65,107,131,64,16,133,207,6,242,31,6,115,105,47,122,79,154,64,154,66,9,109,66,72,10,61,148,28,54,58,234,18,221,149,221,177,96,67,255,123,103,53,86,105,179,23,217,199,123,243,230,83,149,40,208,150,34,66,120,67,99,132,213,9,5,43,173,18,153,86,70,144,212,42,120,21,42,150,42,149,107,69,152,182,218,120,116,25,143,188,202,178,12,135,218,18,22,193,190,82,36,11,12,14,104,164,200,229,87,227,155,253,186,250,225,219,74,58,211,167,140,112,163,99,204,131,39,65,130,27,201,136,136,56,48,30,1,159,137,193,148,7,192,42,23,214,78,225,29,79,153,214,231,101,41,95,176,222,243,194,90,89,236,188,97,24,194,131,173,138,66,152,122,209,75,157,13,34,55,3,18,109,216,133,124,53,152,204,253,155,19,253,112,1,76,11,82,101,140,65,24,183,89,180,193,160,41,236,171,188,143,225,242,199,214,84,86,167,92,70,215,214,155,53,48,133,71,97,177,231,112,177,75,135,51,196,223,25,93,162,33,137,252,14,118,205,220,161,235,6,120,39,63,35,89,96,98,235,158,148,33,44,119,107,56,99,29,252,73,135,255,227,13,211,6,139,19,154,187,45,255,29,48,7,95,52,251,251,247,199,222,118,197,180,100,220,247,109,1,225,2,41,210,204,181,206,224,219,173,234,121,19,84,113,75,211,220,91,117,40,54,10,159,31,118,116,123,202,138,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8fce16ad-5709-43b9-bd14-2a8342248eb7"));
		}

		#endregion

	}

	#endregion

}


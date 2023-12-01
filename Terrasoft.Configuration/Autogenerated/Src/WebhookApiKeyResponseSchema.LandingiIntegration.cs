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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,146,65,107,131,64,16,133,207,10,249,15,131,185,180,151,245,30,155,64,154,66,9,109,130,36,133,30,74,14,27,29,205,18,221,149,221,177,96,67,255,123,119,53,86,105,227,69,246,241,222,188,249,86,37,47,209,84,60,65,120,67,173,185,81,25,177,149,146,153,200,107,205,73,40,201,94,185,76,133,204,197,90,18,230,157,54,241,47,19,223,171,141,149,97,223,24,194,146,237,106,73,162,68,182,71,45,120,33,190,90,95,244,235,26,134,111,107,225,76,159,34,193,141,74,177,96,79,156,184,109,36,205,19,178,129,137,15,246,153,106,204,237,0,88,21,220,152,25,188,227,241,164,212,121,89,137,23,108,118,118,97,37,13,246,222,48,12,225,193,212,101,201,117,179,24,164,222,6,137,155,1,153,210,214,133,246,168,49,155,7,55,39,6,225,2,44,45,8,121,178,24,132,105,151,69,195,70,77,225,80,229,125,140,151,63,116,166,170,62,22,34,185,182,222,172,129,25,60,114,131,3,135,139,93,122,156,49,126,172,85,133,154,4,218,59,136,219,185,99,215,13,240,94,126,70,50,96,137,141,123,211,9,97,25,175,225,140,13,251,147,14,255,199,91,166,13,150,71,212,119,91,251,119,192,28,2,222,238,31,220,31,6,219,21,211,144,118,223,183,3,132,11,228,72,145,107,141,224,219,173,234,121,83,148,105,71,211,158,59,117,44,182,138,239,255,0,221,140,220,206,137,2,0,0 };
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


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,146,65,107,131,64,16,133,207,6,242,31,6,115,105,47,235,61,54,129,52,133,18,218,4,73,10,61,148,28,54,58,234,18,221,149,221,177,96,67,255,123,119,53,86,105,179,23,217,199,123,243,230,83,37,47,209,84,60,70,120,67,173,185,81,41,177,181,146,169,200,106,205,73,40,201,94,185,76,132,204,196,70,18,102,157,54,157,92,166,19,175,54,86,134,67,99,8,75,182,175,37,137,18,217,1,181,224,133,248,106,125,225,175,107,24,190,171,133,51,125,138,24,183,42,193,130,61,113,226,182,145,52,143,201,6,166,19,176,103,166,49,179,3,96,93,112,99,230,240,142,167,92,169,243,170,18,47,216,236,237,194,74,26,236,189,65,16,192,131,169,203,146,235,102,57,72,189,13,98,55,3,82,165,173,11,237,85,99,186,240,111,78,244,131,37,88,90,16,50,183,24,132,73,151,69,195,70,77,193,80,229,125,140,151,63,118,166,170,62,21,34,190,182,222,172,129,57,60,114,131,3,135,139,93,122,156,49,126,164,85,133,154,4,218,119,16,181,115,199,174,27,224,189,252,140,100,192,18,27,247,164,28,97,21,109,224,140,13,251,147,14,254,199,91,166,45,150,39,212,119,59,251,119,192,2,124,222,238,239,223,31,7,219,21,211,144,118,223,183,3,132,11,100,72,161,107,13,225,219,173,234,121,51,148,73,71,211,222,59,117,44,182,202,232,252,0,89,162,241,115,146,2,0,0 };
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


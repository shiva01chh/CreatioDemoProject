namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookParserSchema

	/// <exclude/>
	public class WebhookParserSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookParserSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookParserSchema(WebhookParserSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("27f94e71-ff84-4026-a617-5aa9c6d13750");
			Name = "WebhookParser";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,83,193,110,194,48,12,61,23,137,127,176,224,194,46,237,125,116,189,128,52,105,2,134,180,73,59,167,169,105,179,181,9,74,210,33,134,246,239,115,210,2,131,149,33,237,176,28,42,197,126,239,217,126,78,37,171,208,172,25,71,120,70,173,153,81,43,27,78,148,92,137,188,214,204,10,37,195,39,197,5,43,103,200,178,123,148,253,222,174,223,11,106,35,100,14,11,220,88,37,61,227,193,40,57,238,247,40,53,212,152,19,11,38,37,51,230,22,94,48,45,148,122,91,50,109,80,123,64,20,69,16,155,186,170,152,222,38,237,189,69,193,218,195,194,61,42,250,6,91,215,105,41,56,24,75,77,113,224,78,253,92,60,216,249,2,135,22,230,104,11,149,81,19,75,207,109,146,231,229,125,192,43,64,73,35,130,84,86,172,182,176,105,59,202,152,101,225,129,23,157,19,99,234,152,85,32,201,196,187,129,195,14,146,41,125,97,83,8,94,128,48,32,17,51,176,10,82,4,174,228,59,106,219,220,109,209,93,79,165,175,200,109,24,71,94,248,88,71,163,173,181,52,201,236,55,206,30,228,88,167,126,57,218,194,179,246,86,251,145,143,225,145,177,218,237,212,205,112,3,110,199,65,208,200,129,219,237,164,233,61,156,34,57,77,175,65,124,224,163,175,26,255,80,78,70,94,99,236,36,62,175,122,78,143,207,176,28,255,211,246,11,37,175,57,63,191,66,187,108,126,203,236,240,255,36,243,231,21,116,233,119,108,97,136,50,107,254,12,127,247,81,160,115,26,167,48,157,47,91,212,225,244,22,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("27f94e71-ff84-4026-a617-5aa9c6d13750"));
		}

		#endregion

	}

	#endregion

}


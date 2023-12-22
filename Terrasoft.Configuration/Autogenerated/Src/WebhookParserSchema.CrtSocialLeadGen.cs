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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,83,193,110,194,48,12,61,23,137,127,176,224,194,46,237,125,116,189,128,52,105,2,134,180,73,59,167,169,105,179,181,9,74,210,33,134,246,239,75,220,2,131,149,33,237,176,28,42,197,126,239,217,126,78,37,171,208,172,25,71,120,70,173,153,81,43,27,78,148,92,137,188,214,204,10,37,195,39,197,5,43,103,200,178,123,148,253,222,174,223,11,106,35,100,14,11,220,88,37,137,241,96,148,28,247,123,46,53,212,152,59,22,76,74,102,204,45,188,96,90,40,245,182,100,218,160,38,64,20,69,16,155,186,170,152,222,38,237,189,69,193,154,96,225,30,21,125,131,173,235,180,20,28,140,117,77,113,224,94,253,92,60,216,81,129,67,11,115,180,133,202,92,19,75,226,54,201,243,242,20,32,5,40,221,136,32,149,21,171,45,108,218,142,50,102,89,120,224,69,231,196,216,117,204,42,144,206,196,187,129,199,14,146,169,251,194,166,16,188,0,97,64,34,102,96,21,164,8,92,201,119,212,182,185,219,162,187,158,74,95,145,219,48,142,72,248,88,71,163,173,181,52,201,236,55,206,30,228,89,167,126,121,218,130,88,123,171,105,228,99,120,100,172,246,59,245,51,220,128,223,113,16,52,114,224,119,59,105,122,15,167,232,156,118,175,65,124,224,35,85,141,127,40,39,35,210,24,123,137,207,171,158,187,199,103,88,142,255,105,251,133,146,215,156,159,95,161,93,54,191,101,118,248,127,146,249,243,10,186,244,59,182,48,68,153,53,127,6,221,41,10,238,156,198,93,248,219,249,2,114,53,197,244,30,4,0,0 };
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


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,83,193,110,194,48,12,61,83,137,127,176,224,194,46,237,125,116,189,128,52,105,2,134,180,73,59,167,169,105,179,181,9,74,210,33,134,246,239,75,220,2,131,149,33,237,176,30,34,197,126,239,217,126,78,37,171,208,172,25,71,120,70,173,153,81,43,27,78,148,92,137,188,214,204,10,37,195,39,197,5,43,103,200,178,123,148,253,96,215,15,122,181,17,50,135,5,110,172,146,196,120,48,74,142,251,129,75,13,53,230,142,5,147,146,25,115,11,47,152,22,74,189,45,153,54,168,9,16,69,17,196,166,174,42,166,183,73,123,111,81,176,38,88,184,71,69,223,96,235,58,45,5,7,99,93,83,28,184,87,63,23,239,237,168,192,161,133,57,218,66,101,174,137,37,113,155,228,121,121,10,144,2,148,110,68,144,202,138,213,22,54,109,71,25,179,44,60,240,162,115,98,236,58,102,21,72,103,226,221,192,99,7,201,212,157,176,41,4,47,64,24,144,136,25,88,5,41,2,87,242,29,181,109,238,182,232,174,167,210,87,228,54,140,35,18,62,214,209,104,107,45,77,50,251,141,179,7,121,214,169,95,158,182,32,214,222,106,26,249,24,30,25,171,253,78,253,12,55,224,119,220,235,53,114,224,119,59,105,122,15,167,232,156,118,175,65,124,224,35,85,141,127,40,39,35,210,24,123,137,207,171,158,187,199,103,88,142,255,105,251,133,146,215,156,159,95,161,93,54,191,101,118,248,127,146,249,243,10,186,244,59,182,48,68,153,53,127,6,221,41,10,238,59,141,187,112,16,124,1,58,122,11,58,21,4,0,0 };
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


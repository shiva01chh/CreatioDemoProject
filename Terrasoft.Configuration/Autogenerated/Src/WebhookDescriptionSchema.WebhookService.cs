namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookDescriptionSchema

	/// <exclude/>
	public class WebhookDescriptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookDescriptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookDescriptionSchema(WebhookDescriptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("020f1299-16ac-4e29-87a6-9d2c2c565cca");
			Name = "WebhookDescription";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,147,95,79,219,48,16,192,159,83,137,239,112,42,47,84,66,201,59,237,138,52,64,69,8,177,110,84,236,217,77,175,173,33,181,195,157,189,42,170,246,221,119,182,67,20,77,176,105,93,30,108,231,254,254,238,124,54,106,135,92,171,18,97,129,68,138,237,218,229,87,214,172,245,198,147,114,218,154,147,193,225,100,144,121,214,102,3,143,13,59,220,137,190,170,176,12,74,206,103,104,144,116,57,238,108,30,112,239,68,17,226,220,177,53,249,189,54,175,162,21,125,81,20,48,97,191,219,41,106,166,237,255,92,17,227,10,246,184,220,90,251,146,191,89,21,61,179,218,47,43,93,66,89,41,102,248,158,12,175,145,75,210,117,226,203,14,49,124,118,74,184,17,1,204,201,214,72,78,35,95,192,60,58,39,253,239,249,163,96,134,142,193,18,112,216,221,22,97,139,106,133,196,121,231,209,103,121,131,185,214,177,124,145,78,216,145,148,125,14,105,159,194,109,242,135,3,108,208,141,67,220,49,252,252,23,128,87,143,212,64,173,72,110,198,253,15,201,215,16,104,222,197,57,158,136,80,152,216,193,210,174,154,63,211,220,125,89,62,203,100,192,183,228,241,89,28,142,79,203,214,147,204,101,111,54,62,78,220,206,133,164,135,199,232,214,10,222,203,126,138,102,149,70,229,111,52,129,194,53,53,130,93,199,51,26,167,221,71,45,136,146,120,109,96,164,229,159,134,251,142,105,56,93,108,187,66,192,198,30,229,147,34,26,247,171,248,161,201,121,85,181,55,24,24,110,98,198,133,48,156,141,32,60,196,44,35,116,158,76,191,197,151,249,147,170,60,182,3,48,61,27,38,175,7,161,24,142,194,203,204,82,229,113,149,165,247,253,2,92,243,40,10,255,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("020f1299-16ac-4e29-87a6-9d2c2c565cca"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookAccountRequestSchema

	/// <exclude/>
	public class WebhookAccountRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookAccountRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookAccountRequestSchema(WebhookAccountRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3176958d-017e-4009-868d-c2180693d9ea");
			Name = "WebhookAccountRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8e07ad5d-ca48-4dfc-8107-c7bee2abec1b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,148,81,79,234,64,16,133,159,37,225,63,76,226,59,188,203,141,9,214,196,52,151,228,18,208,248,188,108,135,50,177,221,237,221,217,98,26,226,127,119,216,109,9,26,69,172,242,212,61,157,195,249,218,61,91,163,74,228,74,105,132,123,116,78,177,93,251,81,98,205,154,242,218,41,79,214,140,102,202,100,100,114,74,141,199,60,106,195,193,110,56,184,168,89,100,88,54,236,177,156,12,7,162,92,58,204,229,54,36,133,98,190,130,71,92,109,172,125,154,106,109,107,227,23,248,191,70,246,97,112,60,30,195,31,174,203,82,185,230,186,93,47,176,114,200,104,60,131,223,32,60,71,51,168,232,6,23,237,163,206,61,62,178,87,245,170,32,13,122,31,251,89,234,197,46,36,31,24,231,206,86,232,60,161,128,206,131,63,222,127,143,22,132,59,20,42,235,128,177,165,155,206,83,120,194,102,116,112,28,227,116,60,236,221,254,13,77,43,250,139,13,236,32,71,63,217,255,197,4,94,190,147,165,29,42,143,25,172,206,139,75,226,248,205,47,36,202,238,159,76,188,149,169,123,42,177,203,252,103,250,101,42,216,170,162,70,32,105,154,150,134,201,83,60,111,80,72,156,224,16,139,206,94,25,233,168,92,43,237,105,139,167,185,86,214,22,144,242,52,140,246,127,13,82,118,132,130,74,242,167,227,72,234,185,144,217,217,126,180,127,92,215,120,182,181,211,95,60,97,187,215,109,215,151,193,209,63,153,50,57,118,228,27,57,65,36,87,237,122,77,232,206,162,72,91,123,18,220,105,246,195,226,145,237,201,145,68,247,175,99,48,138,240,69,7,62,66,88,6,223,207,49,14,219,195,232,182,114,38,30,22,179,239,192,116,219,179,12,238,7,87,124,68,116,137,38,139,95,198,176,142,234,91,49,104,71,191,87,94,17,96,190,59,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3176958d-017e-4009-868d-c2180693d9ea"));
		}

		#endregion

	}

	#endregion

}


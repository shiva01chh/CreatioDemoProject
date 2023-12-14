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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,148,65,75,195,64,16,133,207,22,250,31,6,188,183,119,43,66,141,32,193,130,165,85,60,111,55,211,116,48,217,141,59,155,74,40,254,119,167,187,73,81,209,170,209,158,178,47,243,250,190,100,223,198,168,18,185,82,26,225,14,157,83,108,215,126,148,88,179,166,188,118,202,147,53,163,153,50,25,153,156,82,227,49,143,218,112,176,27,14,78,106,22,25,150,13,123,44,39,195,129,40,167,14,115,185,13,73,161,152,207,224,1,87,27,107,31,167,90,219,218,248,5,62,213,200,62,12,142,199,99,56,231,186,44,149,107,46,218,245,2,43,135,140,198,51,248,13,194,115,52,131,138,110,112,209,62,234,220,227,55,246,170,94,21,164,65,239,99,191,74,61,217,133,228,3,227,220,217,10,157,39,20,208,121,240,199,251,31,209,130,112,141,66,101,29,48,182,116,211,121,10,143,216,140,14,142,183,56,29,15,123,183,127,67,211,138,110,176,129,29,228,232,39,251,191,152,192,203,111,178,180,67,229,49,131,213,207,226,146,56,126,249,15,137,178,251,71,19,175,100,234,142,74,236,50,111,77,191,76,5,91,85,212,8,36,77,211,210,48,121,138,231,13,10,137,19,28,98,209,217,43,35,29,149,107,165,61,109,241,56,215,202,218,2,82,158,134,209,254,175,65,202,142,80,80,73,254,120,28,73,61,23,50,59,219,143,246,143,235,26,207,182,118,250,155,39,108,247,186,237,250,50,56,250,39,83,38,199,142,124,35,39,136,228,170,93,175,9,221,143,40,210,214,158,4,119,154,253,177,120,100,123,114,36,209,253,239,24,140,34,124,211,129,207,16,150,193,247,119,140,195,246,48,186,173,156,137,251,197,236,55,48,221,246,44,131,251,222,21,159,17,157,162,201,226,151,49,172,163,250,94,12,154,252,94,1,63,242,205,83,51,6,0,0 };
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


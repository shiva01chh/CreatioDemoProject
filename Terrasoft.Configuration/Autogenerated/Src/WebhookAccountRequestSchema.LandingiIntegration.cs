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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,148,65,107,227,48,16,133,207,53,228,63,12,244,158,220,55,101,33,235,194,98,54,176,33,105,233,89,145,39,206,16,91,114,53,114,138,9,251,223,59,145,236,208,45,109,218,186,185,89,207,243,252,62,91,79,54,170,66,174,149,70,184,67,231,20,219,141,31,167,214,108,168,104,156,242,100,205,120,174,76,78,166,160,204,120,44,162,54,74,14,163,228,170,97,145,97,213,178,199,106,58,74,68,185,118,88,200,109,72,75,197,252,3,30,112,189,181,118,55,211,218,54,198,47,241,177,65,246,97,112,50,153,192,13,55,85,165,92,251,179,91,47,177,118,200,104,60,131,223,34,60,69,51,168,232,6,23,237,227,222,61,121,97,175,155,117,73,26,244,49,246,189,212,171,67,72,62,49,46,156,173,209,121,66,1,93,4,127,188,255,26,45,8,191,81,168,172,3,198,142,110,182,200,96,135,237,248,228,120,137,211,243,176,119,199,47,52,171,233,15,182,112,128,2,253,244,248,136,41,252,251,74,150,118,168,60,230,176,254,92,92,26,199,127,93,32,81,118,255,108,226,173,76,221,81,133,125,230,95,51,44,83,193,94,149,13,2,73,211,180,52,76,222,226,105,139,66,226,4,135,88,116,246,202,72,71,229,90,105,79,123,60,207,181,182,182,132,140,103,97,116,248,103,144,178,35,148,84,145,63,31,71,82,207,165,204,206,143,163,195,227,250,198,179,109,156,254,224,13,187,189,238,186,190,10,142,225,201,148,203,177,35,223,202,9,34,185,234,214,27,66,247,41,138,172,179,167,193,157,229,223,44,30,217,129,28,105,116,95,28,131,81,132,15,58,240,22,194,42,248,190,143,113,218,30,70,183,151,51,113,191,156,127,5,166,223,158,85,112,223,187,242,45,162,107,52,121,252,51,134,117,84,255,23,131,150,36,207,222,127,11,113,50,6,0,0 };
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


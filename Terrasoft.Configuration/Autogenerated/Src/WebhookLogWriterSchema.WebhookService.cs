namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookLogWriterSchema

	/// <exclude/>
	public class WebhookLogWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookLogWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookLogWriterSchema(WebhookLogWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e1f5aa0c-1e22-41e9-b051-ad2f74579970");
			Name = "WebhookLogWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,75,75,195,64,16,62,71,240,63,44,241,82,161,36,119,91,123,176,62,16,172,8,245,113,30,147,105,186,152,236,150,125,84,130,248,223,157,77,54,105,178,138,116,217,203,204,124,223,60,190,25,1,21,234,29,100,200,158,81,41,208,114,99,146,165,20,27,94,88,5,134,75,113,122,242,117,122,18,89,205,69,193,214,181,54,88,205,122,123,72,81,72,126,138,164,105,202,230,218,86,21,168,122,225,237,55,124,223,74,249,193,74,89,176,79,197,13,170,164,67,166,3,232,206,190,151,60,99,89,9,90,119,156,7,89,188,53,12,138,127,53,5,162,51,133,5,53,198,110,57,150,185,190,96,79,138,239,193,96,27,220,181,6,83,8,185,20,101,205,94,52,42,26,72,96,230,166,9,204,153,207,136,34,111,147,142,43,16,80,27,101,51,35,149,171,211,180,215,34,194,41,27,199,0,158,244,160,52,68,205,119,160,160,98,130,132,191,140,237,168,157,120,225,218,99,89,239,72,230,105,131,110,200,94,158,80,152,73,48,225,56,229,57,115,235,139,162,0,116,25,192,220,78,163,239,255,213,88,161,217,202,252,24,33,30,220,158,253,206,233,68,142,151,195,147,238,243,120,209,241,121,62,18,225,23,165,162,99,129,2,227,197,141,43,196,232,154,157,249,151,112,123,201,115,215,154,23,176,193,79,238,44,57,251,178,83,70,11,116,151,237,179,118,234,237,65,49,20,134,155,122,157,109,177,2,210,111,44,104,114,51,136,174,64,16,87,37,119,104,238,233,34,64,100,120,85,63,82,183,147,248,176,188,248,124,22,164,166,164,195,26,201,146,110,216,96,155,56,88,178,231,182,240,100,141,230,26,55,75,89,218,74,188,66,105,81,79,126,1,6,209,190,11,146,121,122,152,253,127,202,170,213,149,8,157,52,99,56,236,209,23,253,251,138,200,75,127,240,126,0,152,32,12,61,121,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e1f5aa0c-1e22-41e9-b051-ad2f74579970"));
		}

		#endregion

	}

	#endregion

}


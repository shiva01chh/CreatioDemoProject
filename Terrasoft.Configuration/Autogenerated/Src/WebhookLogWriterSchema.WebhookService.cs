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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,77,75,195,64,16,61,167,224,127,88,226,165,5,73,238,182,246,96,253,64,176,34,212,143,243,152,76,211,197,100,183,236,71,37,136,255,221,217,100,19,147,85,164,176,151,217,121,111,222,204,155,17,80,161,222,67,134,236,9,149,2,45,183,38,89,73,177,229,133,85,96,184,20,39,147,207,147,73,100,53,23,5,219,212,218,96,53,239,227,33,69,33,253,83,38,77,83,182,208,182,170,64,213,75,31,191,226,219,78,202,119,86,202,130,125,40,110,80,37,29,50,29,64,247,246,173,228,25,203,74,208,186,227,220,203,226,181,97,80,254,179,17,136,78,21,22,212,24,187,225,88,230,250,156,61,42,126,0,131,109,114,223,6,76,33,228,82,148,53,123,214,168,104,32,129,153,155,38,8,231,190,34,138,188,45,58,86,32,160,54,202,102,70,42,167,211,180,215,34,194,41,155,143,1,60,233,65,105,136,90,236,65,65,197,4,25,127,17,219,81,59,241,210,181,199,178,254,35,89,164,13,186,33,123,123,66,99,166,193,132,227,146,51,230,214,23,69,1,232,34,128,185,157,70,95,255,187,177,70,179,147,249,49,70,220,187,61,251,157,211,137,28,111,135,39,221,229,241,178,227,243,124,100,194,47,74,69,199,2,5,198,203,107,39,196,232,154,93,248,151,113,7,201,115,215,154,55,176,193,79,111,45,125,246,178,103,140,22,232,46,219,87,237,220,59,128,98,40,12,55,245,38,219,97,5,228,223,216,208,228,122,144,93,131,32,174,74,110,209,220,209,69,128,200,240,178,126,160,110,167,241,207,242,226,217,60,40,77,69,135,26,201,138,110,216,96,91,56,88,178,231,182,240,100,131,230,10,183,43,89,218,74,188,64,105,81,79,127,1,6,217,190,11,178,249,236,103,246,255,41,235,214,87,34,116,214,140,225,112,64,47,250,247,21,209,47,189,201,228,27,195,52,202,0,112,4,0,0 };
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


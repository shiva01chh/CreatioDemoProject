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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,147,221,107,219,48,16,192,159,29,200,255,112,164,47,41,20,251,125,201,50,88,91,58,194,232,178,53,180,207,138,115,73,212,57,146,115,39,45,152,176,255,125,39,201,53,166,172,29,237,94,36,251,62,127,247,33,163,246,200,181,42,17,150,72,164,216,110,92,126,105,205,70,111,61,41,167,173,25,14,78,195,65,230,89,155,45,220,53,236,112,47,250,170,194,50,40,57,191,65,131,164,203,73,103,115,139,71,39,138,16,103,206,214,228,95,181,57,136,86,244,69,81,192,148,253,126,175,168,153,181,255,11,69,140,107,56,226,106,103,237,207,252,201,170,232,153,213,126,85,233,18,202,74,49,195,67,50,188,66,46,73,215,137,47,59,197,240,217,25,225,86,4,176,32,91,35,57,141,252,1,22,209,57,233,159,231,143,130,27,116,12,150,128,195,237,118,8,59,84,107,36,206,59,143,62,203,19,204,149,142,229,139,116,202,142,164,236,11,72,247,12,190,36,127,56,193,22,221,36,196,157,192,239,183,0,28,60,82,3,181,34,153,140,251,31,146,239,33,208,162,139,243,126,34,66,97,98,7,43,187,110,94,167,153,127,91,61,202,102,192,143,228,241,89,28,222,159,150,173,39,217,203,222,110,188,156,184,221,11,73,15,119,209,173,21,252,45,251,25,154,117,90,149,127,209,4,10,215,212,8,118,19,191,209,56,237,94,106,65,148,196,177,129,145,150,127,28,29,59,166,209,108,185,235,10,1,27,123,148,79,139,104,220,175,226,151,38,231,85,213,78,48,48,92,199,140,75,97,24,159,67,120,136,89,70,232,60,153,126,139,63,229,247,170,242,216,46,192,108,60,74,94,183,66,49,58,15,47,51,75,149,199,83,142,193,224,15,60,245,10,48,246,3,0,0 };
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


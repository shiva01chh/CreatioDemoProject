namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookAccountResponseSchema

	/// <exclude/>
	public class WebhookAccountResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookAccountResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookAccountResponseSchema(WebhookAccountResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cbf385ce-188b-4c9c-b713-0b0178ffc565");
			Name = "WebhookAccountResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8e07ad5d-ca48-4dfc-8107-c7bee2abec1b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,93,107,194,64,16,124,86,240,63,236,47,72,222,155,82,80,11,69,16,10,42,244,121,115,174,241,104,114,23,110,247,148,32,253,239,221,124,21,105,139,165,6,2,201,220,206,205,236,238,0,128,195,138,184,70,67,176,163,16,144,253,65,146,165,119,7,91,196,128,98,189,75,214,232,246,214,21,118,229,132,138,30,155,77,47,179,233,36,178,194,176,109,88,168,202,102,83,69,210,52,133,71,142,85,133,161,121,26,254,55,84,7,98,114,194,32,71,130,51,229,71,239,223,1,141,241,209,9,232,89,237,29,83,50,210,211,43,126,29,243,210,26,48,37,50,195,91,207,156,247,196,205,192,131,7,88,32,211,239,135,122,69,107,244,135,175,14,120,33,181,228,3,48,13,214,76,32,20,218,67,222,36,95,164,107,55,163,29,150,208,54,190,236,203,23,13,92,160,32,201,218,139,50,248,232,6,241,79,69,157,242,77,197,103,173,218,217,138,70,205,87,119,159,38,194,9,203,72,96,117,163,70,55,169,93,156,143,164,78,130,218,177,172,56,11,58,205,130,126,163,17,123,162,219,190,114,239,75,88,241,188,43,189,127,12,26,42,130,210,86,86,110,203,89,205,203,70,107,215,109,233,253,114,99,4,217,199,96,254,232,112,216,245,16,175,109,199,248,174,60,209,183,51,160,207,39,4,199,94,173,82,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cbf385ce-188b-4c9c-b713-0b0178ffc565"));
		}

		#endregion

	}

	#endregion

}


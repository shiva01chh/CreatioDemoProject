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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,219,106,194,64,16,125,54,224,63,204,23,36,239,181,20,212,66,17,132,130,10,125,158,172,99,92,154,236,134,157,89,37,72,255,189,147,91,145,182,88,234,67,96,115,246,156,61,103,46,0,224,176,34,174,209,16,236,40,4,100,127,144,116,233,221,193,22,49,160,88,239,210,53,186,189,117,133,93,57,161,162,199,166,201,101,154,76,34,43,12,219,134,133,170,217,52,81,36,203,50,120,228,88,85,24,154,167,225,127,67,117,32,38,39,12,114,36,56,83,126,244,254,29,208,24,31,157,128,222,213,222,49,165,163,60,187,210,215,49,47,173,1,83,34,51,188,245,202,121,47,220,12,58,120,128,5,50,253,126,169,79,180,65,127,228,234,128,23,210,72,62,0,211,16,205,4,66,161,61,228,77,250,37,186,78,51,198,97,9,109,225,203,158,190,104,224,2,5,201,172,125,104,6,31,93,35,254,233,168,93,190,233,248,172,172,157,173,104,244,124,117,247,121,34,156,176,140,4,86,39,106,116,146,90,197,249,72,154,36,104,28,203,138,179,160,211,93,208,51,26,177,39,186,157,43,247,190,132,21,207,59,234,253,109,208,165,34,40,109,101,229,182,157,213,125,217,40,119,221,82,239,183,27,87,144,125,12,230,143,10,135,89,15,235,181,237,20,223,157,39,250,117,1,146,228,19,70,50,37,54,81,3,0,0 };
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


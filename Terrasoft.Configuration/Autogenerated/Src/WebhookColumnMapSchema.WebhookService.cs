namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookColumnMapSchema

	/// <exclude/>
	public class WebhookColumnMapSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookColumnMapSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookColumnMapSchema(WebhookColumnMapSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8640abaf-c1c2-47ff-a168-5310c87cef25");
			Name = "WebhookColumnMap";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,193,74,196,48,16,134,207,27,232,59,12,236,189,185,187,226,165,136,39,61,9,158,103,219,73,54,152,76,74,146,34,75,241,221,77,82,139,91,117,15,98,46,67,126,38,223,124,9,97,116,20,71,236,9,158,41,4,140,94,165,182,243,172,140,158,2,38,227,185,17,115,35,26,1,121,237,3,233,156,64,103,49,198,27,120,161,227,201,251,215,206,219,201,241,35,142,107,155,148,18,110,227,228,28,134,243,221,87,148,169,9,13,71,72,39,2,135,227,104,88,131,245,218,244,160,124,168,233,219,66,132,190,34,129,179,27,32,15,64,156,76,58,95,198,237,197,40,185,157,53,78,71,155,153,125,145,252,197,177,180,204,75,185,34,187,198,15,148,34,100,179,88,106,209,171,62,94,109,84,149,33,59,180,223,120,242,39,240,211,42,166,80,174,189,209,122,42,216,25,52,165,67,153,117,128,247,245,37,255,35,184,121,179,63,11,222,215,211,215,253,118,213,113,183,39,30,150,79,81,182,53,19,226,3,248,20,57,194,83,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8640abaf-c1c2-47ff-a168-5310c87cef25"));
		}

		#endregion

	}

	#endregion

}


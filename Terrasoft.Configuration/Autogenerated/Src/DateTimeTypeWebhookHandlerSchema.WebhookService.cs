namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateTimeTypeWebhookHandlerSchema

	/// <exclude/>
	public class DateTimeTypeWebhookHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateTimeTypeWebhookHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateTimeTypeWebhookHandlerSchema(DateTimeTypeWebhookHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f6423a49-1ee5-458c-ab0f-20db6e65c91d");
			Name = "DateTimeTypeWebhookHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d7950703-7230-445f-b3e5-fcd99a7a2e60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,77,139,219,48,16,61,103,97,255,195,224,189,196,176,216,247,124,24,218,44,165,61,180,4,18,232,161,244,160,216,227,68,173,45,153,145,180,197,148,253,239,29,203,146,55,237,174,151,250,32,172,209,155,247,102,222,140,18,45,154,78,148,8,71,36,18,70,215,54,219,105,85,203,179,35,97,165,86,183,55,191,111,111,22,206,72,117,134,67,111,44,182,235,233,126,157,66,152,125,16,165,213,36,209,48,130,49,119,132,103,38,128,93,35,140,89,193,131,176,120,148,45,30,251,14,191,226,233,162,245,207,143,66,85,13,146,71,231,121,14,27,227,218,86,80,95,132,123,128,193,101,196,65,173,137,49,136,80,18,214,219,36,50,38,121,1,150,89,179,72,147,255,195,51,228,136,198,232,144,55,211,105,246,105,231,140,213,237,203,2,19,200,7,170,111,15,88,11,215,216,247,82,85,220,254,114,208,212,245,114,54,45,189,135,47,108,47,108,33,153,111,62,73,191,51,117,231,78,141,44,161,28,172,122,195,41,88,193,172,26,179,12,147,154,108,223,147,238,144,44,143,99,5,123,79,239,125,126,97,180,15,48,248,81,86,44,160,184,224,108,130,93,27,25,107,52,150,134,217,199,140,177,195,34,206,234,160,29,149,200,190,26,43,148,53,217,59,213,175,223,208,245,181,15,116,113,126,243,186,67,199,227,177,29,199,205,214,71,167,210,160,113,135,170,26,219,15,247,224,197,103,180,23,93,253,143,17,83,65,191,194,238,117,130,184,67,203,214,60,138,198,205,213,232,35,30,234,29,220,38,82,117,206,38,197,97,52,203,167,130,174,95,97,29,118,58,138,102,155,220,63,60,83,18,90,71,202,20,155,60,254,93,57,162,79,63,176,180,99,54,46,195,92,188,112,10,126,21,22,178,134,201,163,236,72,253,94,144,193,165,135,220,131,118,118,90,53,32,52,188,217,105,76,92,140,114,33,188,246,177,39,127,134,7,229,154,198,135,159,94,117,126,140,254,29,244,49,254,254,0,163,32,248,229,115,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6423a49-1ee5-458c-ab0f-20db6e65c91d"));
		}

		#endregion

	}

	#endregion

}


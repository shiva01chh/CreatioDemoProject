namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookServiceConstantsSchema

	/// <exclude/>
	public class WebhookServiceConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookServiceConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookServiceConstantsSchema(WebhookServiceConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3cc6351f-388a-4694-ba6f-4b149818986c");
			Name = "WebhookServiceConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e50fad81-60b2-4030-89a7-8b387fd6a892");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,148,93,111,155,48,20,134,175,27,41,255,193,234,174,157,4,12,182,179,110,147,98,27,174,166,169,106,90,237,218,37,135,20,141,152,200,54,139,170,106,255,125,134,124,140,45,218,210,149,43,124,56,175,159,71,199,128,209,27,112,91,93,0,186,7,107,181,107,74,63,145,141,41,171,117,107,181,175,26,51,30,189,140,71,87,173,171,204,26,45,159,157,135,205,205,120,20,42,239,44,172,195,99,36,107,237,220,123,244,21,30,159,154,230,219,18,236,247,170,128,176,131,243,218,120,215,183,78,167,83,244,193,181,155,141,182,207,159,14,235,208,225,117,101,28,218,237,131,200,237,147,168,56,70,39,199,228,116,16,221,182,143,117,85,160,162,131,254,157,121,245,210,115,207,192,125,225,254,9,208,170,49,240,139,236,181,111,221,169,127,136,59,241,186,189,67,163,237,166,160,66,248,136,238,163,232,35,186,102,146,208,132,103,9,206,133,136,112,18,243,20,243,60,150,88,41,149,43,162,88,62,203,213,245,205,5,173,82,87,53,172,222,44,150,247,241,51,181,152,210,140,241,140,99,42,82,134,147,104,78,176,224,84,98,30,43,170,102,115,66,35,181,248,167,154,180,160,61,56,100,96,247,135,219,228,245,114,95,96,119,102,22,165,9,21,148,50,44,8,91,224,68,201,4,207,69,54,199,145,204,4,89,204,226,148,144,248,226,208,182,182,41,192,245,239,231,239,114,203,215,203,221,158,246,56,115,84,44,86,74,134,193,73,42,195,193,166,44,193,11,26,206,153,115,21,238,25,145,34,138,46,59,234,53,160,135,187,207,168,172,160,94,253,199,212,110,67,240,193,214,121,23,235,108,14,235,139,64,11,101,248,156,193,190,9,122,119,8,15,193,131,218,1,254,99,255,27,0,179,218,255,9,186,101,95,27,92,63,1,201,203,66,35,94,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3cc6351f-388a-4694-ba6f-4b149818986c"));
		}

		#endregion

	}

	#endregion

}


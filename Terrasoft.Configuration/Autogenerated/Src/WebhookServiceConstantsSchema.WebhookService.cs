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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,148,93,111,155,48,20,134,175,27,41,255,193,234,174,157,4,12,182,179,174,147,98,27,174,166,169,106,90,237,218,37,135,20,149,152,200,54,141,170,170,255,125,134,124,44,91,180,165,43,87,248,112,94,63,143,142,1,163,87,224,214,186,0,116,7,214,106,215,148,126,36,27,83,86,203,214,106,95,53,102,56,120,29,14,46,90,87,153,37,154,191,56,15,171,171,225,32,84,62,89,88,134,199,72,214,218,185,207,232,7,60,60,54,205,211,28,236,115,85,64,216,193,121,109,188,235,91,199,227,49,250,226,218,213,74,219,151,175,187,117,232,240,186,50,14,109,182,65,228,182,73,84,236,163,163,125,114,124,20,93,183,15,117,85,160,162,131,254,157,121,241,218,115,79,192,125,225,238,17,208,162,49,240,139,236,181,111,221,161,255,24,119,224,117,123,135,70,219,77,65,133,240,30,221,71,209,53,186,100,146,208,132,103,9,206,133,136,112,18,243,20,243,60,150,88,41,149,43,162,88,62,201,213,229,213,25,173,82,87,53,44,62,44,150,247,241,19,181,152,210,140,241,140,99,42,82,134,147,104,74,176,224,84,98,30,43,170,38,83,66,35,53,251,167,154,180,160,61,56,100,96,243,135,219,232,253,114,223,97,115,98,22,165,9,21,148,50,44,8,155,225,68,201,4,79,69,54,197,145,204,4,153,77,226,148,144,248,236,208,214,182,41,192,245,239,231,239,114,243,247,203,221,28,246,56,113,84,44,86,74,134,193,73,42,195,193,166,44,193,51,26,206,153,115,21,238,25,145,34,138,206,59,234,37,160,251,219,111,168,172,160,94,252,199,212,110,66,240,222,214,121,23,235,108,118,235,179,64,11,101,248,156,193,126,8,122,187,11,31,131,143,106,59,248,219,246,55,0,102,177,253,19,116,203,190,22,174,159,244,148,55,96,86,4,0,0 };
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


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,148,93,111,155,48,20,134,175,139,148,255,96,117,215,78,2,6,219,89,183,73,177,13,87,211,84,53,173,118,237,146,67,138,70,76,100,155,69,85,181,255,62,67,62,150,45,218,210,245,14,31,206,235,231,209,49,216,232,53,184,141,46,1,221,131,181,218,181,149,31,203,214,84,245,170,179,218,215,173,25,69,47,163,232,170,115,181,89,161,197,179,243,176,190,25,69,161,242,206,194,42,188,70,178,209,206,189,71,95,225,241,169,109,191,45,192,126,175,75,8,59,56,175,141,119,67,235,100,50,65,31,92,183,94,107,251,252,105,191,14,29,94,215,198,161,237,46,136,220,46,137,202,67,116,124,72,78,78,162,155,238,177,169,75,84,246,208,191,51,175,94,6,238,25,120,40,220,63,1,90,182,6,126,145,189,246,157,59,246,159,226,142,188,126,239,208,104,251,41,168,16,62,160,135,40,250,136,174,153,36,52,229,121,138,11,33,98,156,38,60,195,188,72,36,86,74,21,138,40,86,76,11,117,125,115,65,171,210,117,3,203,55,139,21,67,252,76,45,161,52,103,60,231,152,138,140,225,52,158,17,44,56,149,152,39,138,170,233,140,208,88,205,255,169,38,45,104,15,14,25,216,254,225,54,126,189,220,23,216,158,153,197,89,74,5,165,12,11,194,230,56,85,50,197,51,145,207,112,44,115,65,230,211,36,35,36,185,56,180,141,109,75,112,195,247,249,187,220,226,245,114,183,199,61,206,28,21,75,148,146,97,112,146,202,112,176,25,75,241,156,134,115,230,92,133,103,70,164,136,227,203,142,122,5,232,225,238,51,170,106,104,150,255,49,181,219,16,124,176,77,209,199,122,155,253,250,34,208,66,21,126,103,176,111,130,222,237,195,167,224,147,218,30,254,99,119,13,128,89,238,110,130,126,57,212,162,232,39,179,81,112,136,85,4,0,0 };
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


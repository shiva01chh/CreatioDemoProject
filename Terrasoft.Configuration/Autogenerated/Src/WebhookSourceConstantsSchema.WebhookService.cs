namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookSourceConstantsSchema

	/// <exclude/>
	public class WebhookSourceConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookSourceConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookSourceConstantsSchema(WebhookSourceConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5c4d12fa-2a84-42e8-8c1f-ddb1a7a5cd70");
			Name = "WebhookSourceConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,65,107,2,49,16,133,207,6,246,63,12,122,223,189,215,86,40,94,123,40,108,193,243,24,179,219,80,51,145,76,162,44,226,127,119,204,54,91,237,161,80,8,132,153,201,247,222,203,16,58,195,7,212,6,62,76,8,200,190,139,245,218,83,103,251,20,48,90,79,149,58,87,106,150,216,82,15,237,192,209,184,101,165,164,211,52,13,60,115,114,14,195,176,250,174,5,140,104,137,225,100,182,159,222,127,1,251,20,68,154,77,56,90,185,181,39,142,72,145,235,34,208,220,41,28,210,118,111,53,232,61,50,195,102,84,104,179,192,186,112,242,234,156,221,103,139,96,122,73,7,211,232,9,222,51,63,142,127,167,203,141,205,99,170,206,7,120,67,218,201,207,108,61,65,247,137,166,72,55,19,224,24,110,75,40,8,188,192,124,194,181,119,243,229,31,214,237,143,37,210,80,246,243,15,215,87,161,196,176,152,44,12,237,198,13,228,250,82,41,57,74,93,1,218,165,221,21,206,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5c4d12fa-2a84-42e8-8c1f-ddb1a7a5cd70"));
		}

		#endregion

	}

	#endregion

}


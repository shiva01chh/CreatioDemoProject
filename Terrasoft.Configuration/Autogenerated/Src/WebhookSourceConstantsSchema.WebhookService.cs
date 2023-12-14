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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,65,107,195,48,12,133,207,13,228,63,136,246,158,220,215,109,48,122,221,97,144,65,207,170,235,100,102,181,92,36,187,37,148,253,247,169,206,156,117,59,12,102,12,70,178,191,247,158,69,232,173,28,209,88,120,181,204,40,161,143,205,38,80,239,134,196,24,93,160,186,186,212,213,34,137,163,1,186,81,162,245,235,186,210,78,219,182,112,47,201,123,228,241,241,171,86,48,162,35,129,179,221,189,133,240,14,18,18,171,180,88,62,57,61,77,32,137,72,81,154,34,208,222,40,28,211,238,224,12,152,3,138,192,118,82,232,178,192,166,112,250,234,146,221,23,43,182,131,166,131,249,234,14,94,50,63,93,255,78,151,27,219,159,169,250,192,240,140,180,215,159,185,102,134,110,19,205,145,174,38,32,145,175,67,40,8,60,192,114,198,77,240,203,245,31,214,221,183,37,210,88,230,243,15,215,39,165,212,176,152,172,44,237,167,9,228,250,163,174,116,235,250,4,252,224,196,84,207,1,0,0 };
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


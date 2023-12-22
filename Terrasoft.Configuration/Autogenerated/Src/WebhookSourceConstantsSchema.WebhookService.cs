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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,65,107,195,48,12,133,207,13,228,63,136,246,158,220,215,109,48,122,221,97,144,65,207,170,235,100,102,181,92,36,123,35,148,253,247,169,206,156,101,59,12,102,12,70,178,191,247,158,69,232,173,156,209,88,120,182,204,40,161,143,205,46,80,239,134,196,24,93,160,186,186,212,213,42,137,163,1,186,81,162,245,219,186,210,78,219,182,112,43,201,123,228,241,254,171,86,48,162,35,129,119,123,120,9,225,21,36,36,86,105,177,252,230,244,52,129,36,34,69,105,138,64,187,80,56,167,195,201,25,48,39,20,129,253,164,208,101,129,93,225,244,213,37,187,175,54,108,7,77,7,243,213,13,60,101,126,186,254,157,46,55,246,63,83,245,129,225,17,233,168,63,115,205,12,45,19,205,145,174,38,32,145,175,67,40,8,220,193,122,198,77,240,235,237,31,214,221,183,37,210,88,230,243,15,215,7,165,212,176,152,108,44,29,167,9,228,250,163,174,116,47,214,39,181,81,39,47,215,1,0,0 };
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


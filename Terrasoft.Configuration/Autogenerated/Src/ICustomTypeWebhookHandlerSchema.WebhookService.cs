namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICustomTypeWebhookHandlerSchema

	/// <exclude/>
	public class ICustomTypeWebhookHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICustomTypeWebhookHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICustomTypeWebhookHandlerSchema(ICustomTypeWebhookHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87741c9c-aa61-4ad0-b909-e56eff97f745");
			Name = "ICustomTypeWebhookHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,80,203,78,195,48,16,60,39,82,254,97,213,94,224,146,220,105,232,165,23,56,128,42,81,137,179,155,108,18,67,99,71,235,117,81,85,241,239,216,206,131,22,181,21,81,20,57,235,153,217,153,81,162,69,211,137,2,97,131,68,194,232,138,211,149,86,149,172,45,9,150,90,37,241,49,137,35,107,164,170,225,237,96,24,219,69,18,187,73,150,101,144,27,219,182,130,14,203,225,255,29,183,141,214,159,80,88,195,186,5,62,116,8,141,80,229,14,41,29,41,217,9,167,179,219,157,44,64,42,70,170,188,135,231,85,96,110,28,113,208,122,234,233,14,124,12,107,163,57,97,237,108,193,154,116,135,196,18,205,3,172,131,78,127,255,215,87,24,56,240,94,150,72,160,92,220,116,130,157,122,137,12,147,207,56,66,95,29,18,142,80,35,47,224,251,134,116,48,232,137,62,237,21,105,159,7,194,231,92,112,142,170,236,227,156,103,123,65,110,116,249,159,96,211,246,175,161,250,78,144,51,238,250,132,189,216,217,107,134,194,36,64,67,35,143,51,169,58,203,179,229,208,65,160,130,174,46,168,86,154,166,165,105,158,133,139,95,73,66,182,164,204,50,207,198,147,191,210,219,15,44,184,167,225,221,176,35,108,188,95,92,44,194,213,227,94,255,252,0,185,113,148,160,159,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87741c9c-aa61-4ad0-b909-e56eff97f745"));
		}

		#endregion

	}

	#endregion

}


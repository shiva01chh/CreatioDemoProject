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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,80,65,110,194,48,16,60,19,41,127,88,193,165,189,196,247,66,115,225,210,30,90,33,21,169,103,147,108,130,219,196,142,214,107,42,132,250,247,218,78,160,161,2,212,40,138,156,245,204,236,204,104,217,162,237,100,129,176,70,34,105,77,197,217,210,232,74,213,142,36,43,163,211,228,144,38,19,103,149,174,225,109,111,25,219,121,154,248,137,16,2,22,214,181,173,164,125,62,252,191,227,102,107,204,39,20,206,178,105,129,247,29,194,86,234,178,65,202,142,20,49,226,116,110,211,168,2,148,102,164,42,120,120,94,70,230,218,19,7,173,167,158,238,193,135,184,118,50,35,172,189,45,88,145,233,144,88,161,125,128,85,212,233,239,255,250,138,3,15,222,169,18,9,180,143,155,157,96,99,47,19,203,20,50,30,161,175,30,9,7,168,145,231,240,125,67,58,26,12,196,144,246,138,116,200,3,241,115,46,56,67,93,246,113,206,179,189,32,111,77,249,159,96,167,237,95,67,245,157,36,111,220,247,9,59,217,184,107,134,226,36,66,99,35,143,83,165,59,199,211,124,232,32,82,193,84,23,84,43,67,167,165,217,66,196,139,95,73,66,118,164,109,190,16,199,83,184,50,155,15,44,184,167,225,221,176,35,110,188,159,95,44,194,215,227,223,241,243,3,222,30,223,182,167,2,0,0 };
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


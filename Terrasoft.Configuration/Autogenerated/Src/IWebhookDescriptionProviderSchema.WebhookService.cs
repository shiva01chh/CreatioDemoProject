namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebhookDescriptionProviderSchema

	/// <exclude/>
	public class IWebhookDescriptionProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebhookDescriptionProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebhookDescriptionProviderSchema(IWebhookDescriptionProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("96f3414e-d8a1-4585-8da8-b94ccc3c921b");
			Name = "IWebhookDescriptionProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,77,107,132,48,16,134,207,10,254,135,193,94,90,88,244,222,90,47,91,40,61,44,149,34,236,57,234,168,105,53,145,73,108,145,210,255,222,196,143,173,93,151,149,32,76,230,125,102,230,205,8,214,162,234,88,142,144,34,17,83,178,212,193,94,138,146,87,61,49,205,165,240,220,111,207,117,194,48,132,72,245,109,203,104,136,231,56,33,249,201,11,36,248,194,172,150,242,3,10,84,57,241,206,82,80,146,108,79,9,20,154,235,97,41,19,174,234,116,125,214,240,28,184,208,72,165,157,226,229,56,49,79,127,181,150,62,70,110,70,49,127,231,134,176,178,77,14,168,107,89,168,123,72,198,50,83,242,124,212,241,98,79,200,52,94,154,52,56,49,225,57,20,117,140,88,11,194,60,209,163,63,163,126,124,252,103,42,136,194,81,117,21,90,153,241,227,55,84,125,163,175,115,102,21,146,14,168,20,171,208,143,211,26,161,157,2,24,51,91,152,80,247,36,84,156,48,82,88,44,62,141,110,73,88,101,38,101,3,41,13,207,168,183,175,124,59,95,189,102,239,11,190,3,217,107,216,74,97,107,107,7,182,129,99,245,74,19,23,21,172,45,220,61,204,123,67,81,76,171,27,227,31,207,53,199,126,191,236,100,223,97,134,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("96f3414e-d8a1-4585-8da8-b94ccc3c921b"));
		}

		#endregion

	}

	#endregion

}


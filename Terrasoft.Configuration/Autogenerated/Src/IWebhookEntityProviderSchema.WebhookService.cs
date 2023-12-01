namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebhookEntityProviderSchema

	/// <exclude/>
	public class IWebhookEntityProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebhookEntityProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebhookEntityProviderSchema(IWebhookEntityProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd2e4593-dbe9-4b91-9fef-074b97ab2c88");
			Name = "IWebhookEntityProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e50fad81-60b2-4030-89a7-8b387fd6a892");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,77,107,195,48,12,134,207,45,244,63,136,238,178,93,146,251,154,245,178,149,82,216,70,97,133,157,221,68,73,76,19,219,200,206,66,40,251,239,243,87,218,108,244,48,147,131,109,189,175,244,72,142,96,45,106,197,114,132,3,18,49,45,75,147,60,75,81,242,170,35,102,184,20,139,249,121,49,159,117,154,139,10,62,6,109,176,181,241,166,193,220,5,117,178,69,129,196,243,213,69,51,77,67,152,108,132,225,134,163,182,2,43,73,211,20,50,221,181,45,163,97,29,207,135,26,65,145,252,226,5,18,200,18,122,60,214,82,158,0,157,115,72,70,87,58,177,169,238,216,240,28,184,48,72,165,99,223,125,6,147,175,54,236,99,54,171,60,251,178,179,59,194,202,226,130,141,40,36,199,243,8,123,159,36,196,255,114,249,139,87,174,141,3,194,216,2,152,41,105,47,233,164,161,231,166,78,46,25,166,140,179,221,70,116,45,18,59,54,152,105,67,118,54,107,8,124,239,110,230,112,134,10,205,10,190,35,33,138,34,64,254,38,126,67,83,203,226,63,184,91,52,1,241,58,184,27,84,254,70,49,98,45,8,139,241,180,140,227,94,174,221,59,196,67,146,165,94,114,117,16,154,142,132,246,34,173,48,231,37,199,98,172,148,165,99,216,233,67,143,14,39,236,238,227,219,188,160,206,137,43,247,219,140,117,30,86,55,155,183,35,177,159,93,63,98,105,75,74,157,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd2e4593-dbe9-4b91-9fef-074b97ab2c88"));
		}

		#endregion

	}

	#endregion

}


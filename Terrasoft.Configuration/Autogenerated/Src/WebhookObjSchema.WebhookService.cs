namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookObjSchema

	/// <exclude/>
	public class WebhookObjSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookObjSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookObjSchema(WebhookObjSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("03985297-1a6a-43c1-ac77-0535d189ca09");
			Name = "WebhookObj";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e50fad81-60b2-4030-89a7-8b387fd6a892");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,147,77,107,195,48,12,134,207,13,244,63,8,122,111,238,235,216,97,61,116,59,45,235,7,59,59,182,146,186,75,236,76,178,25,161,236,191,207,137,219,82,198,24,89,40,24,108,201,122,245,188,198,182,17,53,114,35,36,194,22,137,4,219,194,205,151,214,20,186,244,36,156,182,102,154,28,167,201,196,179,54,37,108,90,118,88,47,166,73,200,164,105,10,247,236,235,90,80,251,112,138,215,216,16,50,26,199,32,224,19,243,189,181,239,96,243,3,74,7,133,37,240,140,160,13,72,171,112,126,110,145,94,245,104,124,94,105,9,178,18,204,240,22,245,47,249,33,236,28,123,230,100,70,88,6,79,144,145,109,144,156,70,190,131,172,23,197,253,159,166,250,196,10,131,159,64,231,110,118,123,4,215,54,8,182,232,215,210,26,23,12,207,47,234,107,63,103,67,236,168,59,254,50,214,110,59,249,17,74,116,139,174,231,2,190,254,3,223,163,80,72,60,8,248,20,107,199,195,62,60,82,11,141,160,112,203,110,40,245,181,19,101,23,205,120,58,97,224,179,131,220,170,118,16,121,29,5,143,161,126,60,213,131,86,225,150,116,161,145,254,166,174,188,86,176,123,86,227,89,231,55,206,214,147,196,65,103,60,61,235,77,175,184,21,25,60,85,131,232,17,187,163,234,55,242,12,141,138,31,172,143,67,54,140,36,249,6,55,39,169,188,35,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("03985297-1a6a-43c1-ac77-0535d189ca09"));
		}

		#endregion

	}

	#endregion

}


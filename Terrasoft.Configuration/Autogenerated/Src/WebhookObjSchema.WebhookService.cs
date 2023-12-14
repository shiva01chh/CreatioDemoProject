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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,147,77,111,195,32,12,134,207,141,212,255,96,169,247,230,190,78,59,172,135,110,167,117,253,208,206,4,156,148,46,129,204,6,77,81,180,255,62,18,218,170,154,166,41,139,138,144,0,227,215,207,139,0,35,42,228,90,72,132,29,18,9,182,185,155,47,173,201,117,225,73,56,109,205,52,105,167,201,196,179,54,5,108,27,118,88,45,166,73,136,164,105,10,247,236,171,74,80,243,112,90,111,176,38,100,52,142,65,192,39,102,7,107,223,193,102,71,148,14,114,75,224,25,65,27,144,86,225,252,92,34,189,170,81,251,172,212,18,100,41,152,225,45,234,95,178,99,216,105,123,230,100,70,88,4,79,176,38,91,35,57,141,124,7,235,94,20,247,127,154,234,3,43,12,126,2,157,187,209,29,16,92,83,35,216,188,159,75,107,92,48,60,191,168,175,253,156,13,177,163,238,248,203,152,187,235,228,45,20,232,22,93,205,5,124,253,7,126,64,161,144,120,16,240,41,230,142,135,125,120,164,6,106,65,225,150,221,80,234,107,39,90,95,52,227,233,132,129,207,14,50,171,154,65,228,77,20,60,134,252,241,84,15,90,133,91,210,185,70,250,155,186,242,90,193,254,89,141,103,157,223,56,91,79,18,7,157,241,244,172,183,189,226,86,100,240,84,14,162,71,236,158,202,223,200,51,52,42,126,176,126,29,162,161,135,246,13,187,10,214,138,36,4,0,0 };
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


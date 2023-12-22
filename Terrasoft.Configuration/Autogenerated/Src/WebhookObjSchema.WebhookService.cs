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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,147,77,111,195,32,12,134,207,141,212,255,96,169,247,230,190,76,59,172,135,110,167,117,253,208,206,4,156,148,46,129,204,6,77,81,181,255,62,18,218,170,154,166,41,139,138,144,0,227,215,207,139,0,35,106,228,70,72,132,45,18,9,182,133,155,47,172,41,116,233,73,56,109,205,52,57,78,147,137,103,109,74,216,180,236,176,206,166,73,136,164,105,10,247,236,235,90,80,251,112,90,175,177,33,100,52,142,65,192,39,230,123,107,223,193,230,7,148,14,10,75,224,25,65,27,144,86,225,252,92,34,189,170,209,248,188,210,18,100,37,152,225,45,234,95,242,67,216,57,246,204,201,140,176,12,158,96,69,182,65,114,26,249,14,86,189,40,238,255,52,213,7,150,24,252,4,58,119,163,219,35,184,182,65,176,69,63,151,214,184,96,120,126,81,95,251,57,27,98,71,221,241,23,49,119,219,201,143,80,162,203,186,154,25,124,253,7,190,71,161,144,120,16,240,41,230,142,135,125,120,164,22,26,65,225,150,221,80,234,107,39,90,93,52,227,233,132,129,207,14,114,171,218,65,228,117,20,60,134,252,241,84,15,90,133,91,210,133,70,250,155,186,244,90,193,238,89,141,103,157,223,56,91,79,18,7,157,241,244,172,55,189,226,86,100,240,84,13,162,71,236,142,170,223,200,51,52,42,126,176,126,29,162,161,95,181,111,176,1,116,211,44,4,0,0 };
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


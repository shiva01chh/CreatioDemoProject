namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookColumnMapListExtensionSchema

	/// <exclude/>
	public class WebhookColumnMapListExtensionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookColumnMapListExtensionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookColumnMapListExtensionSchema(WebhookColumnMapListExtensionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4758cf44-9a3d-4b34-85fb-dd216e52e4af");
			Name = "WebhookColumnMapListExtension";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,203,110,219,48,16,60,75,128,255,97,235,94,108,192,144,238,245,227,162,58,69,128,164,41,154,0,57,211,210,202,102,75,145,10,151,74,99,4,249,247,174,72,11,213,35,109,117,32,168,125,204,204,206,74,90,84,72,181,200,17,30,208,90,65,166,116,73,102,116,41,143,141,21,78,26,61,139,95,103,241,44,142,26,146,250,8,247,103,114,88,173,71,239,220,161,20,230,109,57,37,95,80,163,149,249,164,230,70,234,167,117,11,5,252,124,180,120,228,106,200,148,32,250,4,143,120,56,25,243,147,97,154,74,223,138,250,70,146,219,191,56,212,228,21,132,158,52,77,97,67,77,85,9,123,222,253,9,177,90,39,164,38,192,174,129,192,148,224,78,8,84,99,46,75,137,197,132,0,20,51,36,61,220,116,8,92,55,7,37,115,32,199,30,228,144,183,42,255,39,50,10,62,69,221,104,183,232,78,166,224,225,190,121,172,144,28,205,16,2,223,177,86,188,1,242,154,43,22,103,14,63,216,77,144,218,71,254,166,253,130,150,142,225,54,181,176,162,2,205,155,221,206,25,174,198,226,74,162,42,104,190,123,8,4,28,129,210,135,146,77,234,171,223,111,70,237,164,59,7,226,175,28,153,239,218,179,115,55,100,33,247,233,127,3,253,234,143,48,69,186,164,223,131,26,46,226,217,200,162,179,107,225,78,146,160,93,194,102,236,208,14,250,99,175,184,219,182,31,226,120,156,85,75,16,93,146,19,137,75,120,245,249,137,253,248,194,156,124,185,11,91,218,14,200,146,43,105,201,221,217,207,88,138,70,185,69,47,7,91,63,81,199,152,236,159,26,161,168,95,145,60,142,69,172,166,186,130,234,40,186,247,40,153,169,216,44,73,70,39,215,250,153,111,66,187,140,137,27,139,215,71,109,44,102,130,112,185,92,251,38,89,194,98,164,254,195,22,116,163,84,55,108,52,76,39,251,145,101,60,237,216,197,0,253,214,158,111,151,63,0,117,17,126,2,255,30,162,195,160,143,197,241,111,48,215,140,18,126,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4758cf44-9a3d-4b34-85fb-dd216e52e4af"));
		}

		#endregion

	}

	#endregion

}


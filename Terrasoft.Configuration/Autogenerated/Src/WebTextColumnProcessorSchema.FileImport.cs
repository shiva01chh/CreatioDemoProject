namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebTextColumnProcessorSchema

	/// <exclude/>
	public class WebTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebTextColumnProcessorSchema(WebTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("12ec7f7e-14ab-4185-85fd-238e9d07bc1e");
			Name = "WebTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,41,244,63,12,217,75,2,197,190,167,73,160,77,105,9,148,165,176,73,123,40,123,80,228,113,42,176,37,119,70,42,27,202,254,247,29,203,118,91,103,221,66,125,177,52,60,189,167,249,36,89,85,34,87,74,35,108,144,72,177,203,125,178,114,54,55,251,64,202,27,103,147,107,83,224,186,172,28,249,211,147,215,211,147,81,96,99,247,240,235,192,30,203,243,183,249,199,213,132,159,213,147,107,165,189,35,131,44,10,209,252,32,220,75,6,172,10,197,60,131,7,220,109,240,143,95,185,34,148,246,142,156,70,102,71,81,153,166,41,204,141,125,66,50,62,115,26,52,97,190,24,15,168,199,233,178,147,115,40,75,69,135,110,126,97,193,88,246,202,74,179,46,7,255,100,24,116,29,12,50,32,161,224,44,155,93,129,144,59,130,170,241,171,91,184,117,118,95,7,129,142,73,240,162,138,128,156,116,41,233,135,152,199,43,204,85,40,252,165,177,153,44,157,248,67,133,46,159,172,143,246,56,61,131,159,194,29,22,96,229,39,130,225,198,167,211,223,226,89,133,93,97,116,187,211,97,33,204,96,144,219,232,53,178,123,199,44,29,122,10,245,17,8,237,187,104,220,40,190,137,247,63,190,177,176,34,84,30,185,79,89,8,136,18,177,181,28,110,64,92,147,55,219,244,216,119,94,41,82,101,100,181,24,7,70,146,62,44,234,250,118,142,151,91,153,203,201,116,133,100,158,70,117,92,220,162,27,206,156,108,123,78,208,55,158,10,211,157,98,156,28,151,235,39,48,250,219,114,69,155,53,104,251,156,37,163,66,242,114,205,103,245,216,203,90,204,190,2,125,41,73,223,0,125,165,188,106,174,97,195,55,88,243,44,99,147,161,245,38,55,72,159,192,172,186,189,128,123,145,119,41,122,184,9,38,139,126,247,181,221,70,220,182,235,12,22,203,126,45,105,17,30,11,207,7,57,52,116,250,197,88,147,239,31,14,202,165,138,112,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("12ec7f7e-14ab-4185-85fd-238e9d07bc1e"));
		}

		#endregion

	}

	#endregion

}


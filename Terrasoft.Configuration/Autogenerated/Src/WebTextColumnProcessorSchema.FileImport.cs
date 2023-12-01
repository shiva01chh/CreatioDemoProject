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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,9,244,63,12,217,75,2,139,125,79,147,192,54,165,75,96,89,10,155,180,135,178,7,69,30,167,2,123,228,29,73,101,67,233,127,239,88,182,211,58,235,46,244,100,105,120,243,158,230,147,76,170,68,87,41,141,176,69,102,229,108,238,147,181,165,220,28,2,43,111,44,37,55,166,192,77,89,89,246,23,227,231,139,241,40,56,67,7,248,117,116,30,203,203,211,254,125,55,227,71,245,228,70,105,111,217,160,19,133,104,190,48,30,36,3,214,133,114,110,14,247,184,223,226,95,191,182,69,40,233,150,173,70,231,44,71,101,154,166,176,48,244,136,108,124,102,53,104,198,124,57,25,80,79,210,85,39,119,161,44,21,31,187,253,55,2,67,206,43,146,97,109,14,254,209,56,208,117,48,200,130,133,130,37,103,246,5,66,110,25,170,198,175,30,225,135,165,67,29,4,58,38,193,147,42,2,186,164,75,73,223,197,60,92,99,174,66,225,175,12,101,210,58,245,199,10,109,62,221,156,157,113,246,21,126,10,119,88,2,201,71,4,195,131,207,102,191,197,179,10,251,194,232,246,164,195,66,152,195,32,183,209,115,100,247,134,89,38,244,28,234,43,16,218,183,209,184,81,124,18,239,63,124,99,97,205,168,60,186,62,101,33,32,74,196,214,114,120,0,113,77,78,182,233,185,239,162,82,172,202,200,106,57,9,14,89,230,32,212,245,235,156,172,118,178,151,155,233,10,201,34,141,234,216,220,162,27,206,156,238,122,78,208,55,158,9,211,189,114,56,61,47,215,191,192,232,165,229,138,148,53,104,251,156,37,163,66,246,242,204,231,245,218,75,47,102,255,3,125,37,73,159,0,125,173,188,106,158,97,195,55,144,249,35,107,147,33,121,147,27,228,15,96,86,221,89,192,62,201,127,41,122,248,30,76,22,253,238,106,187,173,184,237,54,25,44,87,253,90,210,34,60,23,94,14,114,104,232,244,139,177,54,30,191,2,55,146,105,207,111,4,0,0 };
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


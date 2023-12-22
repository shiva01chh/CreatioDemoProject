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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,41,244,63,12,217,75,2,139,125,79,147,192,54,165,75,96,89,10,155,180,135,178,7,69,30,167,3,182,228,29,73,101,67,233,127,239,88,182,211,56,235,46,212,23,75,195,211,123,154,79,146,81,37,186,74,105,132,13,50,43,103,115,159,172,172,201,105,31,88,121,178,38,185,165,2,215,101,101,217,95,94,188,92,94,140,130,35,179,135,95,7,231,177,188,58,206,79,87,51,126,84,79,110,149,246,150,9,157,40,68,243,133,113,47,25,176,42,148,115,51,120,192,221,6,255,250,149,45,66,105,238,216,106,116,206,114,84,166,105,10,115,50,79,200,228,51,171,65,51,230,139,241,128,122,156,46,59,185,11,101,169,248,208,205,191,25,32,227,188,50,210,172,205,193,63,145,3,93,7,131,12,88,40,88,227,104,87,32,228,150,161,106,252,234,22,126,88,179,175,131,64,199,36,120,86,69,64,151,116,41,233,73,204,227,13,230,42,20,254,154,76,38,75,39,254,80,161,205,39,235,179,61,78,191,194,79,225,14,11,48,242,19,193,112,227,211,233,111,241,172,194,174,32,221,238,116,88,8,51,24,228,54,122,137,236,222,49,75,135,158,67,125,4,66,251,46,26,55,138,79,226,253,135,111,44,172,24,149,71,215,167,44,4,68,137,216,90,14,55,32,174,201,209,54,61,247,157,87,138,85,25,89,45,198,193,33,75,31,6,117,125,59,199,203,173,204,229,100,186,66,50,79,163,58,46,110,209,13,103,78,182,61,39,232,27,79,133,233,78,57,156,156,151,235,39,48,122,109,185,162,201,26,180,125,206,146,81,33,123,185,230,179,122,236,101,45,102,255,3,125,45,73,159,0,125,163,188,106,174,97,195,55,24,250,35,99,202,208,120,202,9,249,3,152,85,183,23,176,207,242,46,69,15,223,3,101,209,239,190,182,219,136,219,118,157,193,98,217,175,37,45,194,115,225,213,32,135,134,78,191,24,107,39,223,27,151,57,201,12,120,4,0,0 };
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


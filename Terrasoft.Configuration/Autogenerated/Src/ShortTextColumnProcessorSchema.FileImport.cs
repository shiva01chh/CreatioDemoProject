namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ShortTextColumnProcessorSchema

	/// <exclude/>
	public class ShortTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ShortTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ShortTextColumnProcessorSchema(ShortTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0e75194b-c61b-4a32-9829-7c88737e87a4");
			Name = "ShortTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("560ff4eb-7ab5-4d8f-8733-4031e1e3144b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,41,244,63,12,217,75,2,197,190,167,73,160,77,105,201,101,41,52,217,75,233,65,145,199,137,192,150,220,25,169,108,40,251,223,119,44,199,105,156,141,23,234,139,165,225,233,61,205,39,201,170,18,185,82,26,97,133,68,138,93,238,147,133,179,185,217,6,82,222,56,155,60,154,2,151,101,229,200,95,95,125,94,95,13,2,27,187,133,151,61,123,44,111,143,243,211,213,132,125,245,228,81,105,239,200,32,139,66,52,63,8,183,146,1,139,66,49,79,224,101,39,41,43,252,237,23,174,8,165,125,38,167,145,217,81,212,166,105,10,83,99,119,72,198,103,78,131,38,204,103,195,11,234,97,58,111,229,28,202,82,209,190,157,223,89,48,150,189,178,210,174,203,193,239,12,131,174,163,65,6,36,28,156,101,179,41,16,114,71,80,53,126,177,217,118,95,160,99,20,124,168,34,32,39,109,76,122,146,243,250,128,185,10,133,191,55,54,147,181,35,191,175,208,229,163,229,217,38,199,55,240,83,208,195,12,172,252,68,208,215,251,120,252,38,174,85,216,20,70,31,54,219,39,133,9,92,132,55,248,140,0,191,104,75,155,158,66,125,18,2,253,57,90,55,138,111,50,254,7,114,44,44,8,149,71,238,162,22,10,162,68,60,88,246,181,32,190,201,209,56,61,119,158,86,138,84,25,137,205,134,129,145,164,19,139,186,190,166,195,249,90,230,114,62,109,33,153,166,81,29,23,31,240,245,165,142,214,29,47,232,90,143,133,235,70,49,142,206,203,245,107,24,252,57,176,69,155,53,120,187,172,37,163,66,242,114,227,39,245,216,203,90,204,254,7,251,94,146,190,1,251,65,121,213,92,199,134,113,176,230,93,198,38,67,235,77,110,144,122,112,86,237,94,192,125,200,19,21,61,60,5,147,69,191,95,181,221,74,220,214,203,12,102,243,110,45,57,66,60,151,222,94,36,209,240,233,22,165,38,223,95,135,124,142,152,123,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e75194b-c61b-4a32-9829-7c88737e87a4"));
		}

		#endregion

	}

	#endregion

}


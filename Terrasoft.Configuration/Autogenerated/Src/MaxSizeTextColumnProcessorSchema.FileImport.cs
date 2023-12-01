namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MaxSizeTextColumnProcessorSchema

	/// <exclude/>
	public class MaxSizeTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MaxSizeTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MaxSizeTextColumnProcessorSchema(MaxSizeTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cf2e8673-fb8d-4ba0-9c62-446b24f54ef1");
			Name = "MaxSizeTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("560ff4eb-7ab5-4d8f-8733-4031e1e3144b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,78,227,48,16,134,207,69,226,29,70,221,75,43,161,228,94,218,74,80,4,234,97,87,72,180,92,16,7,215,153,148,145,18,59,140,109,68,23,237,187,239,196,105,186,77,183,57,144,75,236,209,63,255,204,124,182,141,42,209,85,74,35,172,144,89,57,155,251,100,97,77,78,219,192,202,147,53,201,61,21,184,44,43,203,254,242,226,235,242,98,16,28,153,45,60,237,156,199,242,250,176,63,206,102,236,139,39,247,74,123,203,132,78,20,162,249,193,184,149,26,176,40,148,115,19,248,169,62,159,232,55,174,240,211,47,108,17,74,243,200,86,163,115,150,163,58,77,83,152,146,121,67,38,159,89,13,154,49,159,13,207,168,135,233,188,149,187,80,150,138,119,237,254,198,0,25,231,149,145,129,109,14,254,141,28,232,186,56,200,130,133,132,53,142,54,5,66,110,25,170,198,175,30,227,168,51,208,177,24,124,168,34,160,75,218,66,233,81,165,151,59,204,85,40,252,45,153,76,178,71,126,87,161,205,71,203,147,54,199,87,240,75,240,195,12,140,252,68,208,63,255,120,252,42,190,85,216,20,164,247,13,247,139,97,2,103,17,14,190,34,198,127,212,101,88,207,161,62,17,129,255,24,205,27,197,55,73,255,135,58,6,22,140,202,163,235,2,23,18,162,68,220,91,246,15,33,206,201,193,58,61,245,158,86,138,85,25,185,205,134,193,33,203,44,6,117,125,97,135,243,181,236,229,148,218,64,50,77,163,58,38,239,17,246,215,29,173,59,110,208,53,31,11,219,141,114,56,58,13,215,47,99,240,103,207,23,77,214,32,238,242,150,26,21,178,151,219,63,169,215,94,114,49,171,5,253,200,111,165,214,55,144,223,41,175,154,139,217,144,14,134,222,101,77,25,26,79,57,33,247,32,173,218,110,192,126,200,131,21,61,60,4,202,162,223,115,109,183,18,183,245,50,131,217,188,27,75,142,64,158,138,175,207,210,104,24,117,131,18,147,239,47,93,165,104,235,139,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cf2e8673-fb8d-4ba0-9c62-446b24f54ef1"));
		}

		#endregion

	}

	#endregion

}


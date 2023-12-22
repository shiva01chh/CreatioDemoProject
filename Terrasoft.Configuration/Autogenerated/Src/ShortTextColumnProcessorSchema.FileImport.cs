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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,41,244,63,12,217,75,2,139,125,79,147,192,54,165,37,151,82,104,210,203,178,7,69,30,39,3,182,228,142,164,210,80,246,191,119,44,199,105,156,141,23,234,139,165,225,233,61,205,39,201,168,18,93,165,52,194,10,153,149,179,185,79,22,214,228,180,13,172,60,89,147,220,83,129,203,178,178,236,175,175,62,174,175,6,193,145,217,194,243,222,121,44,111,142,243,211,213,140,125,245,228,94,105,111,153,208,137,66,52,63,24,183,146,1,139,66,57,55,129,231,157,164,172,240,221,47,108,17,74,243,196,86,163,115,150,163,54,77,83,152,146,217,33,147,207,172,6,205,152,207,134,23,212,195,116,222,202,93,40,75,197,251,118,254,203,0,25,231,149,145,118,109,14,126,71,14,116,29,13,50,96,225,96,141,163,77,129,144,91,134,170,241,139,205,182,251,2,29,163,224,77,21,1,93,210,198,164,39,57,191,239,48,87,161,240,183,100,50,89,59,242,251,10,109,62,90,158,109,114,252,19,30,5,61,204,192,200,79,4,125,189,143,199,127,196,181,10,155,130,244,97,179,125,82,152,192,69,120,131,143,8,240,139,182,180,233,57,212,39,33,208,159,162,117,163,248,38,227,127,32,199,194,130,81,121,116,93,212,66,65,148,136,7,203,190,22,196,55,57,26,167,231,206,211,74,177,42,35,177,217,48,56,100,233,196,160,174,175,233,112,190,150,185,156,79,91,72,166,105,84,199,197,7,124,125,169,163,117,199,11,186,214,99,225,186,81,14,71,231,229,250,53,12,254,30,216,162,201,26,188,93,214,146,81,33,123,185,241,147,122,236,101,45,102,255,131,125,43,73,223,128,125,167,188,106,174,99,195,56,24,122,149,49,101,104,60,229,132,220,131,179,106,247,2,246,77,158,168,232,225,33,80,22,253,94,106,187,149,184,173,151,25,204,230,221,90,114,132,120,46,189,185,72,162,225,211,45,74,237,244,251,4,143,110,123,5,132,4,0,0 };
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


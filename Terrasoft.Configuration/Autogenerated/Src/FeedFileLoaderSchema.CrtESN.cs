namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FeedFileLoaderSchema

	/// <exclude/>
	public class FeedFileLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FeedFileLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FeedFileLoaderSchema(FeedFileLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bcaef2e2-05be-4e8f-8a25-8d27e34d45f1");
			Name = "FeedFileLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f0db0304-dc6c-40c0-a3bb-97ab97632500");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,147,193,106,227,48,16,134,207,46,244,29,134,244,226,66,177,239,219,36,80,66,82,10,187,75,105,118,207,139,34,141,99,177,182,100,70,82,138,41,125,247,149,228,56,181,221,164,235,155,70,51,223,252,154,127,172,88,141,166,97,28,225,23,18,49,163,11,155,173,180,42,228,222,17,179,82,171,108,189,253,121,125,245,118,125,149,56,35,213,30,182,173,177,88,223,159,206,151,202,54,178,194,239,154,137,243,153,132,151,226,217,90,89,105,37,154,139,9,27,198,173,166,46,195,231,220,16,238,125,67,88,85,204,152,111,176,65,20,125,111,164,152,209,184,93,37,57,240,144,48,185,7,95,48,72,78,194,59,63,136,90,25,203,148,245,212,103,146,7,102,49,226,146,166,59,0,33,19,90,85,45,60,173,141,10,152,23,108,180,145,94,92,11,127,138,209,185,147,154,220,160,18,29,60,156,97,210,138,92,120,88,232,22,5,119,37,121,158,195,220,184,186,102,212,46,251,192,202,183,182,104,128,129,194,87,144,81,166,183,80,23,96,75,244,233,136,192,9,139,197,108,252,218,89,190,4,219,54,152,157,192,249,148,60,111,24,177,26,148,95,139,197,204,25,36,175,76,33,15,150,206,150,3,240,239,241,149,7,247,42,178,121,30,25,17,121,28,253,88,70,58,46,134,113,155,91,239,201,142,25,76,167,225,232,77,114,96,52,41,120,160,189,171,81,89,88,196,105,12,70,217,223,164,211,151,220,77,123,222,71,246,196,52,15,140,75,213,45,92,155,61,162,157,127,182,122,153,158,151,211,49,223,207,25,255,225,251,15,180,165,22,113,193,180,245,245,40,6,174,75,85,34,73,43,52,239,221,60,141,48,91,149,200,255,190,248,5,12,177,7,206,209,152,52,254,57,237,150,151,88,179,59,120,116,82,220,122,99,186,141,61,210,65,31,252,207,36,5,194,78,235,10,254,71,1,252,132,132,48,163,39,209,219,65,104,29,169,233,186,159,149,55,102,29,49,95,12,169,139,142,131,49,54,252,254,1,62,60,231,225,192,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bcaef2e2-05be-4e8f-8a25-8d27e34d45f1"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,147,81,107,219,48,16,199,159,93,232,119,56,210,23,23,138,253,190,38,129,18,146,82,216,198,104,182,231,161,72,231,88,204,150,204,73,202,48,99,223,125,178,20,167,177,154,116,126,211,233,238,119,127,221,255,172,88,139,166,99,28,225,59,18,49,163,43,91,172,180,170,228,222,17,179,82,171,98,189,253,122,123,243,231,246,38,115,70,170,61,108,123,99,177,125,60,157,175,149,109,100,131,159,53,19,151,51,9,175,197,139,181,178,210,74,52,87,19,54,140,91,77,49,195,231,220,17,238,125,67,88,53,204,152,79,176,65,20,99,111,164,144,209,185,93,35,57,240,33,33,185,7,95,112,150,156,13,239,124,35,106,101,44,83,214,83,191,145,60,48,139,1,151,117,241,0,132,76,104,213,244,240,178,54,106,192,188,98,167,141,244,226,122,248,89,77,206,81,106,118,135,74,68,248,112,134,164,21,185,225,97,67,183,32,56,150,148,101,9,115,227,218,150,81,191,28,3,43,223,218,162,1,6,10,127,131,12,50,189,133,186,2,91,163,79,71,4,78,88,45,102,211,215,206,202,37,216,190,195,226,4,46,83,242,188,99,196,90,80,126,45,22,51,103,144,188,50,133,124,176,116,182,60,3,255,152,94,121,240,168,162,152,151,129,17,144,199,209,79,101,228,211,98,152,182,185,247,158,236,152,193,60,13,7,111,178,3,163,164,224,137,246,174,69,101,97,17,166,113,54,202,241,38,79,95,242,144,246,124,12,236,196,52,15,12,75,21,23,174,47,158,209,206,223,91,189,204,47,203,137,204,191,151,140,127,243,253,11,218,90,139,176,96,218,250,122,20,103,174,75,85,35,73,43,52,31,221,60,141,176,88,213,200,127,189,250,5,28,98,79,156,163,49,121,248,115,250,45,175,177,101,15,240,236,164,184,247,198,196,141,61,210,65,31,252,207,36,5,194,78,235,6,254,71,1,124,135,132,97,70,47,98,180,131,208,58,82,233,186,95,148,55,101,29,49,31,12,41,70,167,193,16,243,223,63,76,122,225,211,183,4,0,0 };
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


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,147,223,107,219,48,16,199,159,93,232,255,112,164,47,46,20,251,125,77,2,37,36,165,176,141,209,108,207,67,145,206,177,152,45,153,147,156,97,198,254,247,233,71,156,198,106,210,249,77,167,187,207,125,117,223,179,98,45,154,142,113,132,239,72,196,140,174,108,177,210,170,146,251,158,152,149,90,21,235,237,215,219,155,63,183,55,89,111,164,218,195,118,48,22,219,199,211,249,90,217,70,54,248,89,51,113,57,147,240,90,188,88,43,43,173,68,115,53,97,195,184,213,20,51,92,206,29,225,222,53,132,85,195,140,249,4,27,68,49,246,70,10,25,93,191,107,36,7,238,19,146,123,112,5,103,201,153,127,231,27,81,43,99,153,178,142,250,141,228,129,89,12,184,172,139,7,32,100,66,171,102,128,151,181,81,30,243,138,157,54,210,137,27,224,103,53,57,71,169,217,29,42,17,225,254,12,73,43,234,253,195,124,183,32,56,150,148,101,9,115,211,183,45,163,97,57,6,86,174,181,69,3,12,20,254,6,25,100,58,11,117,5,182,70,151,142,8,156,176,90,204,166,175,157,149,75,176,67,135,197,9,92,166,228,121,199,136,181,160,220,90,44,102,189,65,114,202,20,114,111,233,108,121,6,254,49,189,114,224,81,69,49,47,3,35,32,143,163,159,202,200,167,197,48,109,115,239,60,217,49,131,121,26,14,222,100,7,70,73,193,19,237,251,22,149,133,69,152,198,217,40,199,155,60,125,201,67,218,243,49,176,19,211,28,48,44,85,92,184,161,120,70,59,127,111,245,50,191,44,39,50,255,94,50,254,205,247,47,104,107,45,194,130,105,235,234,81,156,185,46,85,141,36,173,208,124,116,243,52,194,98,85,35,255,245,234,22,208,199,158,56,71,99,242,240,231,12,91,94,99,203,30,224,185,151,226,222,25,19,55,246,72,7,125,112,63,147,20,8,59,173,27,248,31,5,240,29,18,252,140,94,196,104,7,161,237,73,165,235,126,81,222,148,117,196,124,48,164,24,157,6,67,204,127,255,0,82,234,110,77,184,4,0,0 };
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


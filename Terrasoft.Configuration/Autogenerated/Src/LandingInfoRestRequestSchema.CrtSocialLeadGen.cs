namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingInfoRestRequestSchema

	/// <exclude/>
	public class LandingInfoRestRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingInfoRestRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingInfoRestRequestSchema(LandingInfoRestRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e5fd23eb-b854-0a9b-4281-cb8f7bee4cd8");
			Name = "LandingInfoRestRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,143,203,106,195,48,16,69,215,49,248,31,6,186,183,247,77,232,198,165,33,16,104,72,2,93,203,214,216,29,208,195,29,73,148,96,242,239,149,37,39,164,133,106,33,49,87,71,151,35,35,52,186,81,116,8,103,100,22,206,246,190,106,172,233,105,8,44,60,89,83,157,108,71,66,237,81,200,45,154,178,152,202,98,21,28,153,1,78,23,231,81,175,203,34,38,79,140,67,132,161,81,194,185,103,216,11,35,35,178,51,189,61,162,243,71,252,10,241,72,100,93,215,176,113,65,107,193,151,151,101,110,148,13,18,56,83,240,122,126,135,111,242,159,64,241,57,235,100,1,162,181,193,131,202,189,213,173,167,126,40,26,67,171,168,131,110,54,248,87,96,53,37,137,187,239,129,237,136,236,9,163,244,33,21,228,251,191,150,41,88,74,129,100,117,103,30,13,110,10,219,64,18,26,198,217,252,3,219,183,248,137,157,132,9,6,244,107,112,243,118,93,44,208,200,44,146,230,156,254,14,83,54,175,31,213,57,47,201,169,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e5fd23eb-b854-0a9b-4281-cb8f7bee4cd8"));
		}

		#endregion

	}

	#endregion

}


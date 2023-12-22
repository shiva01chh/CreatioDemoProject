namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SessionTokenResponseSchema

	/// <exclude/>
	public class SessionTokenResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SessionTokenResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SessionTokenResponseSchema(SessionTokenResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f87b198-4253-acd7-9bd9-07d8390cb4bc");
			Name = "SessionTokenResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,193,106,195,48,12,134,207,13,228,29,4,189,39,247,109,12,70,15,187,244,80,154,246,1,84,71,201,204,18,41,200,118,203,40,123,247,185,78,83,178,178,141,249,96,172,223,210,255,127,98,236,201,13,104,8,118,164,138,78,26,95,172,132,27,219,6,69,111,133,139,74,140,197,110,77,88,191,18,231,217,57,207,242,108,177,84,106,227,39,172,58,116,238,1,42,114,46,150,59,121,39,222,70,63,97,71,169,175,44,75,120,114,161,239,81,63,158,175,245,212,0,39,235,223,192,114,35,218,167,40,192,131,4,15,104,140,4,246,224,72,143,54,130,33,215,241,157,2,138,201,178,156,121,14,225,208,89,3,230,130,242,11,201,98,164,190,97,111,84,6,82,111,41,178,111,210,248,248,127,143,155,132,151,59,158,253,118,93,220,154,231,32,19,137,243,106,185,157,230,170,113,108,175,29,156,161,37,255,24,141,226,245,249,71,226,117,9,240,151,45,254,149,53,95,251,167,152,37,113,61,238,158,234,81,253,46,38,109,126,190,0,205,60,102,248,27,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f87b198-4253-acd7-9bd9-07d8390cb4bc"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,193,78,195,48,12,134,207,171,212,119,176,180,123,123,7,132,132,118,224,178,195,180,110,15,224,165,110,137,104,237,202,73,64,104,226,221,73,211,117,42,19,32,114,136,226,63,246,255,127,102,236,201,13,104,8,14,164,138,78,26,95,108,132,27,219,6,69,111,133,139,74,140,197,110,75,88,63,19,231,217,57,207,242,108,181,86,106,227,39,108,58,116,238,14,42,114,46,150,7,121,37,222,71,63,97,71,169,175,44,75,120,112,161,239,81,63,30,47,245,220,0,239,214,191,128,229,70,180,79,81,128,39,9,30,208,24,9,236,193,145,190,217,8,134,92,199,119,10,40,102,203,114,225,57,132,83,103,13,152,17,229,23,146,213,68,125,197,222,169,12,164,222,82,100,223,165,241,233,255,22,55,9,79,55,60,199,253,182,184,54,47,65,102,18,231,213,114,59,207,85,211,216,81,59,56,67,75,254,62,26,197,235,243,143,196,203,18,224,199,45,254,149,181,92,251,167,152,53,113,61,237,158,234,73,253,46,38,109,60,95,19,210,4,158,19,2,0,0 };
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


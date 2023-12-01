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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,193,106,195,48,12,134,207,13,228,29,4,189,39,247,109,12,70,15,187,244,80,154,246,1,84,71,201,204,18,57,72,118,203,40,123,247,185,78,83,178,178,141,249,96,172,223,210,255,127,98,236,73,7,52,4,59,18,65,117,141,47,86,142,27,219,6,65,111,29,23,149,51,22,187,53,97,253,74,156,103,231,60,203,179,197,82,168,141,159,176,234,80,245,1,42,82,141,229,206,189,19,111,163,159,99,165,212,87,150,37,60,105,232,123,148,143,231,107,61,53,192,201,250,55,176,220,56,233,83,20,224,193,5,15,104,140,11,236,65,73,142,54,130,33,215,241,157,2,138,201,178,156,121,14,225,208,89,3,230,130,242,11,201,98,164,190,97,111,196,13,36,222,82,100,223,164,241,241,255,30,55,9,47,119,60,251,237,186,184,53,207,65,38,18,245,98,185,157,230,170,113,108,47,29,156,161,37,255,24,141,226,245,249,71,226,117,9,240,151,45,254,149,53,95,251,167,152,37,113,61,238,158,234,81,253,46,38,45,158,47,43,192,45,111,18,2,0,0 };
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


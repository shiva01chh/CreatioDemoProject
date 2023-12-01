namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetThrottlingSchedulesResponseSchema

	/// <exclude/>
	public class GetThrottlingSchedulesResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetThrottlingSchedulesResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetThrottlingSchedulesResponseSchema(GetThrottlingSchedulesResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dfe8f2e9-f969-4657-87c8-6095ab77b87d");
			Name = "GetThrottlingSchedulesResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,49,111,194,48,16,133,103,144,248,15,39,186,180,75,178,23,202,66,43,150,182,66,132,173,234,96,204,17,44,57,118,228,59,15,20,245,191,247,236,64,68,161,82,179,36,247,252,252,242,62,219,169,6,169,85,26,97,141,33,40,242,59,46,230,222,237,76,29,131,98,227,93,49,127,169,86,98,241,142,144,70,195,227,104,56,136,100,92,13,213,129,24,27,49,91,139,58,57,169,88,160,195,96,244,228,218,179,138,142,77,131,69,37,171,202,154,175,28,44,46,241,221,5,172,101,128,185,85,68,143,176,64,94,239,131,103,182,178,189,210,123,220,70,139,116,254,127,222,81,150,37,76,41,54,141,10,135,217,105,94,97,27,144,208,49,1,239,17,228,59,90,6,191,203,19,247,129,64,167,196,226,156,83,94,4,125,60,43,86,194,206,65,105,254,20,161,141,27,107,52,232,84,237,223,102,131,99,110,215,3,45,131,111,49,176,65,161,90,230,160,110,253,186,126,22,36,156,192,7,160,244,214,253,137,118,4,55,237,169,232,131,46,251,119,0,111,216,108,48,220,191,203,189,194,19,140,249,182,243,171,33,30,63,36,192,51,97,82,166,183,116,51,248,131,56,121,225,8,53,242,36,213,157,192,247,137,27,221,182,67,207,115,167,254,22,179,38,207,15,60,180,141,190,116,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dfe8f2e9-f969-4657-87c8-6095ab77b87d"));
		}

		#endregion

	}

	#endregion

}


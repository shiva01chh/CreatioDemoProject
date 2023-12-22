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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,49,111,194,48,16,133,103,144,248,15,39,186,180,75,178,23,202,66,43,150,182,66,132,173,234,96,204,17,44,57,118,116,119,30,40,234,127,175,237,64,68,161,82,179,36,247,252,252,242,62,219,169,6,185,85,26,97,141,68,138,253,78,138,185,119,59,83,7,82,98,188,43,230,47,213,42,90,188,99,228,209,240,56,26,14,2,27,87,67,117,96,193,38,154,173,69,157,156,92,44,208,33,25,61,185,246,172,130,19,211,96,81,197,85,101,205,87,14,142,174,232,187,35,172,227,0,115,171,152,31,97,129,178,222,147,23,177,113,123,165,247,184,13,22,249,252,255,188,163,44,75,152,114,104,26,69,135,217,105,94,97,75,200,232,132,65,246,8,241,59,88,1,191,203,147,244,129,192,167,196,226,156,83,94,4,125,60,43,81,145,93,72,105,249,140,66,27,54,214,104,208,169,218,191,205,6,199,220,174,7,90,146,111,145,196,96,164,90,230,160,110,253,186,126,22,98,56,131,39,224,244,214,253,137,118,4,55,237,185,232,131,46,251,119,0,111,216,108,144,238,223,227,189,194,19,140,229,182,243,171,97,25,63,36,192,51,97,82,166,183,116,51,248,131,56,121,225,8,53,202,36,213,157,192,247,137,27,221,182,67,207,115,167,254,22,179,118,249,252,0,251,144,20,134,125,2,0,0 };
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


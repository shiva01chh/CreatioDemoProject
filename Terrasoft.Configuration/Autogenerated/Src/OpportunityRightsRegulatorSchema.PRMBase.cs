namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityRightsRegulatorSchema

	/// <exclude/>
	public class OpportunityRightsRegulatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityRightsRegulatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityRightsRegulatorSchema(OpportunityRightsRegulatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f85e969-5663-4fc5-857b-99942ce033c3");
			Name = "OpportunityRightsRegulator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6efc2b6b-5901-4b9d-a21e-e587e5c1977b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,85,77,111,218,64,16,61,59,82,254,195,136,94,176,132,204,61,80,36,132,72,196,33,37,10,105,175,213,214,30,214,43,217,187,214,126,64,221,40,255,189,235,93,3,182,131,85,26,20,110,243,245,230,205,99,102,205,73,142,170,32,49,194,11,74,73,148,216,234,104,33,248,150,81,35,137,102,130,223,222,188,222,222,4,70,49,78,97,83,42,141,249,228,104,55,75,242,92,240,243,17,137,125,254,104,201,53,211,12,85,52,87,37,143,215,5,250,158,234,191,11,162,21,215,40,183,118,142,254,218,123,18,107,33,153,203,176,57,95,36,82,91,10,139,140,40,117,7,235,162,16,82,27,206,116,249,204,104,170,213,51,82,147,17,91,225,178,199,227,49,76,149,201,115,34,203,89,109,187,74,216,167,44,78,1,127,99,108,52,42,16,7,78,176,21,18,226,148,112,90,113,145,14,19,172,91,156,26,69,112,64,30,55,160,11,243,43,99,49,196,14,253,29,45,55,248,145,27,220,193,202,105,82,46,119,200,117,91,21,139,245,234,200,31,103,189,103,152,37,118,216,39,201,118,68,163,15,22,222,128,141,42,60,84,103,126,248,41,219,142,73,13,138,60,241,184,237,38,143,168,83,209,219,101,39,88,2,143,132,19,138,141,217,214,146,18,206,254,56,218,190,253,176,119,172,185,164,10,136,164,38,183,33,21,66,181,159,65,208,37,25,249,30,30,229,12,252,17,192,239,84,185,74,70,14,39,232,6,22,34,51,57,255,65,50,99,215,238,1,245,75,89,96,226,204,233,131,97,201,108,56,120,34,82,115,148,171,100,16,190,195,88,103,201,7,96,194,106,137,131,183,139,148,219,219,154,207,144,172,129,123,94,152,43,20,115,224,215,234,117,4,9,39,112,208,235,146,173,116,231,85,75,235,79,205,41,187,244,23,60,252,174,80,218,23,144,99,236,174,216,180,204,17,92,169,49,124,245,207,134,127,140,202,106,178,105,223,225,205,106,225,57,238,193,82,80,90,154,170,104,94,247,24,14,218,220,6,163,14,217,112,4,255,0,64,215,118,19,167,152,147,111,246,75,96,33,186,127,230,41,88,111,101,112,201,241,158,116,232,171,105,172,87,39,249,237,236,243,226,189,109,167,243,85,191,191,197,9,177,207,198,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f85e969-5663-4fc5-857b-99942ce033c3"));
		}

		#endregion

	}

	#endregion

}


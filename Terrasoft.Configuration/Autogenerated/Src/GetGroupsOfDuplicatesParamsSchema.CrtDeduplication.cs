namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetGroupsOfDuplicatesParamsSchema

	/// <exclude/>
	public class GetGroupsOfDuplicatesParamsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetGroupsOfDuplicatesParamsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetGroupsOfDuplicatesParamsSchema(GetGroupsOfDuplicatesParamsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b7f703a5-c87f-41f4-8e13-77635795a696");
			Name = "GetGroupsOfDuplicatesParams";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,110,194,48,12,134,207,32,241,14,22,92,182,75,123,31,219,46,101,227,180,129,6,55,196,33,20,167,138,212,36,149,227,28,24,218,187,47,73,97,2,209,161,86,85,37,255,254,251,217,177,99,132,70,215,136,18,97,141,68,194,89,201,89,97,141,84,149,39,193,202,154,108,134,123,223,212,170,76,209,104,120,28,13,7,222,41,83,193,234,224,24,117,246,229,13,43,141,217,10,73,137,90,125,39,223,116,52,12,190,9,97,21,2,40,106,225,220,19,204,145,231,100,125,227,22,114,118,66,162,91,10,18,218,37,123,120,243,60,135,103,231,181,22,116,120,61,197,201,129,140,228,64,219,61,214,32,45,221,99,101,103,78,126,1,218,204,4,139,112,48,38,81,242,54,8,141,223,133,191,160,140,173,221,239,108,112,76,221,253,157,102,73,182,65,98,133,225,72,203,68,105,243,169,196,7,234,29,210,195,103,232,24,94,96,140,97,54,124,136,209,248,49,86,61,151,117,76,113,132,111,127,105,56,66,133,60,5,23,63,63,255,3,75,91,123,109,92,23,109,179,133,162,205,246,133,89,41,131,229,154,165,12,195,34,233,253,91,10,55,224,22,82,68,185,47,131,109,115,49,120,164,180,141,91,230,186,203,214,183,134,84,117,188,68,157,139,120,111,115,93,168,9,154,125,187,249,20,183,234,181,24,180,240,252,2,16,156,102,28,75,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7f703a5-c87f-41f4-8e13-77635795a696"));
		}

		#endregion

	}

	#endregion

}


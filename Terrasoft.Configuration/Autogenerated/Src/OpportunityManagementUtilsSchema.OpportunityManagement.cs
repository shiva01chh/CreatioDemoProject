namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityManagementUtilsSchema

	/// <exclude/>
	public class OpportunityManagementUtilsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityManagementUtilsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityManagementUtilsSchema(OpportunityManagementUtilsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4fcdad74-69f0-4516-b611-2a2e42ad8a52");
			Name = "OpportunityManagementUtils";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3263ef9-3aa8-474b-9e91-a704f3bef247");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,207,74,4,49,12,198,207,29,152,119,232,113,23,164,47,224,105,87,23,17,252,3,142,123,18,15,221,78,118,44,76,211,49,73,15,131,248,238,166,46,138,131,91,104,160,31,95,190,252,26,244,9,120,242,1,236,51,16,121,206,71,113,87,25,143,113,40,228,37,102,116,143,211,148,73,10,70,153,239,61,250,1,18,160,180,205,71,219,152,194,17,135,69,35,193,229,175,222,205,44,144,220,93,196,119,21,85,158,202,97,140,193,134,209,51,219,179,177,123,137,35,219,26,253,99,102,81,138,96,15,57,143,246,6,228,150,55,56,119,225,13,146,223,244,41,98,100,81,76,232,183,243,19,132,76,61,175,246,12,164,31,64,8,149,222,150,197,243,162,38,155,201,147,79,172,209,164,152,47,175,86,7,43,197,41,245,161,238,99,125,66,48,134,64,10,225,127,131,83,138,213,50,218,93,111,59,8,133,212,184,195,33,34,184,111,220,221,159,214,243,196,235,186,49,243,169,165,222,182,209,170,231,11,5,145,249,87,152,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4fcdad74-69f0-4516-b611-2a2e42ad8a52"));
		}

		#endregion

	}

	#endregion

}


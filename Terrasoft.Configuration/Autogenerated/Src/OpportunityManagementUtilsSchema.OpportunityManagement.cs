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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,193,106,195,48,12,134,207,9,228,29,124,108,97,248,5,118,106,183,50,10,107,7,203,122,26,59,184,142,154,25,98,57,147,228,67,24,123,247,201,43,27,13,171,193,2,255,252,250,245,89,232,34,240,232,60,152,23,32,114,156,78,98,239,18,158,66,159,201,73,72,104,159,198,49,145,100,12,50,237,28,186,30,34,160,52,245,103,83,87,153,3,246,179,70,130,219,63,189,157,88,32,218,199,128,31,42,170,60,230,227,16,188,241,131,99,54,87,99,15,18,6,54,37,250,215,204,162,20,222,28,83,26,204,3,200,150,87,56,181,254,29,162,91,117,49,96,96,81,76,232,214,211,51,248,68,29,47,14,12,164,31,64,240,133,222,228,217,243,166,36,87,163,35,23,89,163,73,49,95,223,140,14,86,138,115,234,190,236,99,121,70,168,42,2,201,132,255,13,86,41,22,243,104,123,191,110,193,103,82,227,6,251,128,96,127,112,55,23,173,215,137,151,101,99,213,151,150,114,155,90,235,229,249,6,50,52,124,156,161,1,0,0 };
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


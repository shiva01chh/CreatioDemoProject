namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityStageRepositorySchema

	/// <exclude/>
	public class OpportunityStageRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityStageRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityStageRepositorySchema(OpportunityStageRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("55be1109-390d-43ae-b7ab-5425c01ee864");
			Name = "OpportunityStageRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,84,75,111,219,48,12,62,167,64,255,3,225,93,92,160,176,239,121,1,131,215,21,59,108,221,214,108,119,69,166,19,15,182,228,82,82,129,32,200,127,31,45,57,137,147,217,221,128,229,18,88,250,200,239,65,218,74,212,104,26,33,17,86,72,36,140,46,108,146,105,85,148,27,71,194,150,90,221,222,236,111,111,38,206,148,106,115,1,33,156,141,156,39,15,202,150,182,68,195,0,134,188,35,220,112,31,200,42,97,204,20,158,154,70,147,117,170,180,59,143,219,61,91,177,193,15,194,10,143,78,211,20,230,198,213,181,160,221,178,123,238,149,128,105,209,144,51,28,164,86,150,132,180,201,177,44,189,170,155,27,68,81,25,13,146,176,88,68,35,6,147,147,128,8,210,182,180,113,235,170,148,32,91,189,125,238,19,14,166,144,233,186,214,170,39,125,178,247,242,15,193,50,170,60,184,254,75,2,190,193,119,108,180,41,173,166,221,104,2,171,45,2,157,96,80,104,2,61,24,202,255,102,209,27,201,89,214,126,12,61,20,206,225,95,82,60,247,230,44,7,57,231,67,189,151,33,231,201,57,81,173,216,187,178,156,234,87,207,231,19,60,113,183,183,28,14,181,59,218,235,151,9,185,197,71,210,174,249,194,219,15,11,136,174,201,76,20,118,247,122,146,151,196,228,36,75,29,230,30,119,28,255,48,72,92,175,80,182,33,130,187,120,188,107,123,76,166,176,22,6,227,203,171,251,63,117,70,247,227,190,238,192,71,117,120,219,200,103,180,91,157,183,30,72,91,230,193,188,179,113,124,4,253,202,211,47,115,28,126,21,50,66,97,241,105,253,139,193,31,73,215,97,152,113,248,11,139,217,9,153,12,214,251,55,121,225,237,38,35,189,66,147,153,239,225,119,252,147,121,118,82,162,49,133,171,184,214,223,39,143,104,87,187,6,243,76,87,174,86,63,69,229,112,190,214,186,90,198,209,25,29,117,109,8,173,35,229,201,103,189,144,6,76,119,203,201,193,214,226,155,67,94,88,38,10,135,204,84,133,201,60,152,151,248,232,242,85,16,160,121,57,122,26,67,7,29,12,76,222,231,157,230,55,132,50,110,54,50,204,129,79,14,159,180,191,223,141,36,223,41,219,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55be1109-390d-43ae-b7ab-5425c01ee864"));
		}

		#endregion

	}

	#endregion

}


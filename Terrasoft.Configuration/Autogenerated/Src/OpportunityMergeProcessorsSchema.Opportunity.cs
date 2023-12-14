namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityMergeProcessorsSchema

	/// <exclude/>
	public class OpportunityMergeProcessorsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityMergeProcessorsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityMergeProcessorsSchema(OpportunityMergeProcessorsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("80a4ac9d-51e1-4221-91bf-e86e043b909e");
			Name = "OpportunityMergeProcessors";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,77,111,218,64,16,61,7,137,255,48,114,46,32,89,230,30,136,15,132,20,161,54,105,84,162,94,170,170,90,214,131,179,146,189,107,205,238,38,69,17,255,189,227,181,13,38,161,77,145,133,152,207,247,102,222,24,45,74,180,149,144,8,143,72,36,172,217,186,228,198,232,173,202,61,9,167,140,30,14,94,135,131,11,111,149,206,97,189,179,14,203,233,27,155,243,139,2,101,157,108,147,37,106,36,37,143,57,253,182,132,201,98,254,215,208,39,33,157,33,133,150,51,56,231,146,48,231,150,112,83,8,107,175,224,107,85,25,114,94,43,183,91,59,145,163,189,67,202,241,129,248,49,18,173,53,196,53,252,76,38,19,152,89,95,150,130,118,105,107,247,106,87,58,84,67,89,87,67,134,78,168,2,42,194,170,235,146,64,215,100,210,235,242,99,129,91,225,11,55,87,58,99,234,35,183,171,208,108,71,171,133,175,10,37,133,67,187,150,79,88,138,119,164,198,49,220,243,138,225,26,162,143,39,136,198,63,25,171,242,27,238,9,178,158,251,63,198,134,43,152,11,139,33,218,6,219,72,12,31,243,99,188,90,223,119,107,11,142,59,193,250,18,160,118,12,15,54,116,0,205,227,36,135,146,254,146,58,230,214,81,45,239,109,40,107,112,195,14,94,33,71,55,133,253,155,101,68,141,222,231,41,180,68,91,189,68,123,101,231,225,131,167,18,36,202,64,242,58,202,14,211,71,233,113,19,32,15,247,154,204,38,33,255,124,121,110,138,12,245,55,148,134,178,40,93,178,5,20,12,88,101,255,44,204,54,183,191,81,122,190,102,198,157,119,191,65,105,235,132,150,120,130,218,238,236,217,168,172,27,118,244,69,89,55,91,122,149,165,112,28,33,134,218,3,125,82,49,244,186,31,65,199,16,36,189,120,22,196,90,240,89,60,212,104,150,215,174,241,5,62,227,238,187,40,60,59,21,205,26,169,226,86,178,116,20,133,51,250,117,239,203,13,82,20,67,99,39,235,39,243,178,210,76,47,39,230,55,23,124,169,211,0,177,225,203,75,58,218,125,174,167,52,143,220,226,83,233,227,62,193,211,88,251,166,182,72,123,254,218,55,111,248,37,234,172,249,111,24,14,216,85,127,254,0,193,80,154,205,198,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("80a4ac9d-51e1-4221-91bf-e86e043b909e"));
		}

		#endregion

	}

	#endregion

}


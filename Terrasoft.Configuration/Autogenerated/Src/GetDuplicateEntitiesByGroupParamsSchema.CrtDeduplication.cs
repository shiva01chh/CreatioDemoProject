namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetDuplicateEntitiesByGroupParamsSchema

	/// <exclude/>
	public class GetDuplicateEntitiesByGroupParamsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetDuplicateEntitiesByGroupParamsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetDuplicateEntitiesByGroupParamsSchema(GetDuplicateEntitiesByGroupParamsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87b86dad-c94c-4ef5-a14c-884f5a2ac989");
			Name = "GetDuplicateEntitiesByGroupParams";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,78,195,48,12,134,207,155,180,119,176,182,11,92,218,251,6,28,232,70,197,1,152,24,183,105,135,172,117,171,72,77,82,57,201,161,76,188,59,78,202,38,6,67,180,170,42,253,191,237,207,142,27,45,20,218,86,20,8,111,72,36,172,169,92,146,25,93,201,218,147,112,210,232,100,137,165,111,27,89,68,53,25,31,38,227,145,183,82,215,176,233,172,67,181,248,161,147,87,175,157,84,152,108,144,164,104,228,123,172,227,44,206,155,17,214,44,32,107,132,181,115,200,209,45,191,208,184,226,34,39,209,222,119,57,25,223,174,5,9,101,99,17,191,105,154,194,141,245,74,9,234,238,190,116,204,64,135,100,65,153,18,27,168,12,253,79,76,142,180,244,27,110,187,20,78,240,161,29,137,194,237,216,104,253,158,25,80,132,49,135,76,57,58,196,73,79,231,91,147,105,145,66,226,28,214,145,213,199,99,163,39,84,123,164,171,103,158,30,110,97,138,1,217,5,53,189,14,189,143,205,173,163,176,212,213,41,12,7,168,209,45,192,134,207,199,223,192,194,52,94,105,123,137,182,221,65,214,71,135,194,76,85,113,202,57,75,106,7,47,209,31,62,18,223,137,223,144,44,216,67,25,117,88,248,99,121,78,201,189,44,33,239,35,67,65,149,108,194,173,185,184,237,135,62,118,9,53,67,93,246,191,55,234,222,61,55,217,227,231,19,242,135,172,101,82,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87b86dad-c94c-4ef5-a14c-884f5a2ac989"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,78,195,48,12,134,207,155,180,119,176,182,11,92,218,251,6,28,232,70,197,1,152,24,183,105,135,172,117,171,72,77,82,57,206,161,76,188,59,73,202,38,6,67,180,170,42,253,191,237,207,142,27,45,20,218,86,20,8,111,72,36,172,169,56,201,140,174,100,237,72,176,52,58,89,98,233,218,70,22,81,77,198,135,201,120,228,172,212,53,108,58,203,168,22,63,116,242,234,52,75,133,201,6,73,138,70,190,199,58,159,229,243,102,132,181,23,144,53,194,218,57,228,200,203,47,52,174,124,17,75,180,247,93,78,198,181,107,65,66,217,88,228,223,52,77,225,198,58,165,4,117,119,95,58,102,32,35,89,80,166,196,6,42,67,255,19,147,35,45,253,134,219,46,5,11,127,104,38,81,240,206,27,173,219,123,6,20,97,204,33,83,142,14,113,210,211,249,214,100,90,164,144,56,135,117,100,245,241,216,232,9,213,30,233,234,217,79,15,183,48,197,128,236,130,154,94,135,222,199,230,150,41,44,117,117,10,195,1,106,228,5,216,240,249,248,27,88,152,198,41,109,47,209,182,59,200,250,232,80,152,169,42,159,114,206,146,154,225,37,250,195,71,242,119,226,55,36,11,246,80,70,29,22,254,88,158,83,114,39,75,200,251,200,80,80,37,155,112,107,46,110,251,161,143,93,66,205,80,151,253,239,141,186,119,207,77,239,133,231,19,36,57,1,97,83,3,0,0 };
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


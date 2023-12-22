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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,78,195,48,12,134,207,155,180,119,176,182,11,92,218,251,6,28,104,71,197,1,168,24,183,105,135,172,117,171,72,77,82,57,201,161,76,188,59,73,186,77,43,12,209,170,170,244,255,182,63,59,110,36,19,168,91,86,32,124,32,17,211,170,50,81,162,100,197,107,75,204,112,37,163,20,75,219,54,188,8,106,54,61,204,166,19,171,185,172,97,211,105,131,98,245,67,71,239,86,26,46,48,218,32,113,214,240,207,80,231,178,92,222,130,176,118,2,146,134,105,189,132,12,77,122,68,227,218,21,25,142,250,177,203,72,217,54,103,196,132,14,69,238,141,227,24,238,180,21,130,81,247,112,212,33,3,13,146,6,161,74,108,160,82,244,63,49,58,209,226,11,220,54,101,134,185,67,27,98,133,217,57,163,181,123,199,128,194,143,57,102,202,201,33,76,122,62,95,78,170,69,242,137,75,200,3,171,143,135,70,47,40,246,72,55,175,110,122,184,135,57,122,100,231,213,252,214,247,62,53,215,134,252,82,215,231,48,28,160,70,179,2,237,63,95,127,3,11,213,88,33,245,53,218,118,7,73,31,29,11,83,85,229,82,134,44,46,13,188,5,127,252,72,238,78,252,134,36,222,30,203,168,253,194,159,203,33,37,179,188,132,172,143,140,5,85,188,241,183,230,234,182,159,250,216,53,212,2,101,217,255,222,160,123,119,104,58,239,242,249,6,123,194,96,236,91,3,0,0 };
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


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RelationshipDesignerConstsSchema

	/// <exclude/>
	public class RelationshipDesignerConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RelationshipDesignerConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RelationshipDesignerConstsSchema(RelationshipDesignerConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("718abfbc-0c58-497c-88f9-59343c161b6f");
			Name = "RelationshipDesignerConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("306bd3dc-c1db-4d7d-a14d-6d8f14db70cb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,81,79,228,32,20,133,159,109,210,255,64,124,218,125,184,74,129,210,54,102,31,218,2,250,180,49,234,187,169,21,71,146,14,52,208,217,205,104,252,239,50,227,56,218,68,179,154,37,132,112,195,57,231,126,1,86,193,216,5,186,92,135,73,47,79,210,36,77,108,183,212,97,236,122,141,174,180,247,93,112,119,211,81,235,236,157,89,172,124,55,25,103,143,46,244,176,221,132,123,51,10,29,204,194,106,159,38,143,105,114,48,174,110,6,211,163,48,197,243,30,245,67,23,2,250,72,29,243,162,198,78,33,122,54,190,131,227,227,87,25,154,214,163,70,189,179,86,247,111,53,32,229,252,178,27,54,218,121,19,175,187,91,103,135,53,58,93,153,219,125,179,171,104,106,247,25,155,234,250,37,0,253,66,86,255,221,138,127,28,230,92,20,20,55,10,72,161,114,96,68,84,80,82,161,32,219,172,68,182,152,215,217,225,207,147,175,1,254,118,211,127,51,238,51,102,152,92,100,130,16,70,65,48,33,129,9,206,160,174,27,6,132,74,41,24,38,89,205,241,39,152,163,11,102,91,1,58,115,222,60,56,59,125,29,240,124,103,190,126,179,206,184,234,22,87,82,241,2,184,164,12,152,146,18,42,69,57,52,121,163,138,34,147,52,167,197,191,185,132,241,241,6,190,205,244,98,155,241,96,204,74,85,148,10,88,77,120,228,169,49,148,152,55,32,90,73,171,138,231,50,207,63,123,206,119,60,23,250,143,246,65,127,27,104,231,155,17,101,82,202,82,10,12,132,103,241,131,73,74,160,98,188,5,138,153,204,170,74,213,101,187,187,161,167,52,137,243,253,120,6,222,125,155,250,153,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("718abfbc-0c58-497c-88f9-59343c161b6f"));
		}

		#endregion

	}

	#endregion

}


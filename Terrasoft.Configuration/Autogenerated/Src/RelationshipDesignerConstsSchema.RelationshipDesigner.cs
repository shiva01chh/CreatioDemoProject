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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,81,79,228,32,20,133,159,109,210,255,64,124,210,135,171,20,40,109,99,246,161,45,176,251,100,140,250,110,106,197,145,164,3,13,116,214,140,102,255,251,50,227,56,110,147,53,106,36,132,112,195,57,231,126,1,86,193,216,5,186,90,135,73,47,207,210,36,77,108,183,212,97,236,122,141,174,181,247,93,112,247,211,73,235,236,189,89,172,124,55,25,103,79,46,245,176,221,132,7,51,10,29,204,194,106,159,38,207,105,114,48,174,110,7,211,163,48,197,243,30,245,67,23,2,250,159,58,230,69,141,157,66,244,108,124,7,167,167,175,50,52,173,71,141,122,103,173,238,223,106,64,202,249,101,55,108,180,243,38,94,119,119,206,14,107,244,115,101,238,246,205,174,163,169,221,103,108,170,155,151,0,244,3,89,253,184,21,31,29,230,92,20,20,55,10,72,161,114,96,68,84,80,82,161,32,219,172,68,182,152,215,217,225,241,217,231,0,207,221,244,109,198,125,198,12,147,139,76,16,194,40,8,38,36,48,193,25,212,117,195,128,80,41,5,195,36,171,57,126,7,115,116,193,108,43,64,191,156,55,79,206,78,159,7,188,216,153,111,222,172,51,174,186,197,149,84,188,0,46,41,3,166,164,132,74,81,14,77,222,168,162,200,36,205,105,241,49,151,48,62,222,192,151,153,94,108,51,30,140,89,169,138,82,1,171,9,143,60,53,134,18,243,6,68,43,105,85,241,92,230,249,123,207,249,15,207,165,254,173,125,208,95,6,218,249,102,68,153,148,178,148,2,3,225,89,252,96,146,18,168,24,111,129,98,38,179,170,82,117,217,238,110,232,79,154,196,25,199,95,244,117,58,80,144,3,0,0 };
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


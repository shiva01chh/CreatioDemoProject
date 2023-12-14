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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,81,79,228,32,20,133,159,109,210,255,64,124,210,135,171,20,40,109,99,124,104,11,236,62,25,227,250,110,186,21,103,73,58,208,64,71,51,187,217,255,190,116,156,29,109,162,89,205,18,66,184,225,156,115,191,0,155,96,236,10,125,219,134,73,175,47,210,36,77,108,183,214,97,236,122,141,110,181,247,93,112,15,211,89,235,236,131,89,109,124,55,25,103,207,110,244,176,219,132,31,102,20,58,152,149,213,62,77,126,165,201,209,184,249,62,152,30,133,41,158,247,168,31,186,16,208,91,234,152,23,53,118,10,209,51,251,142,206,207,255,202,208,180,29,53,234,157,181,186,127,169,1,41,231,215,221,48,107,151,77,188,238,238,157,29,182,232,203,198,220,31,154,221,70,83,123,200,152,171,187,231,0,116,137,172,126,218,137,79,142,115,46,10,138,27,5,164,80,57,48,34,42,40,169,80,144,205,43,145,45,230,117,118,124,122,241,49,192,43,55,253,55,227,33,99,129,201,69,38,8,97,20,4,19,18,152,224,12,234,186,97,64,168,148,130,97,146,213,28,191,131,57,186,96,118,21,160,175,206,155,159,206,78,31,7,188,222,155,239,94,172,11,174,186,197,149,84,188,0,46,41,3,166,164,132,74,81,14,77,222,168,162,200,36,205,105,241,111,46,97,124,188,129,79,51,61,219,22,60,24,179,82,21,165,2,86,19,30,121,106,12,37,230,13,136,86,210,170,226,185,204,243,247,158,243,21,207,141,126,212,62,232,79,3,237,125,11,162,76,74,89,74,129,129,240,44,126,48,73,9,84,140,183,64,49,147,89,85,169,186,108,247,55,244,59,77,226,156,199,31,227,10,87,136,145,3,0,0 };
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


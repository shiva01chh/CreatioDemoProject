namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDuplicatesGroupResponseSchema

	/// <exclude/>
	public class BulkDuplicatesGroupResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDuplicatesGroupResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDuplicatesGroupResponseSchema(BulkDuplicatesGroupResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb44fa4e-3083-461b-a753-81b61ff52720");
			Name = "BulkDuplicatesGroupResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,201,78,195,48,20,60,183,18,255,240,212,94,64,66,201,189,45,61,208,160,168,135,130,212,112,67,28,220,228,53,50,56,118,228,5,84,42,254,157,23,71,93,210,189,228,224,196,206,204,104,60,206,68,178,2,77,201,82,132,87,212,154,25,53,183,193,72,201,57,207,157,102,150,43,121,211,94,222,180,91,206,112,153,67,178,48,22,139,254,206,156,240,66,96,90,129,77,16,163,68,205,211,147,152,151,217,7,61,78,84,134,98,15,55,117,210,242,2,131,132,84,152,224,63,222,3,161,8,215,213,152,211,4,70,130,25,211,131,71,39,62,159,8,108,23,35,193,81,218,200,149,130,167,204,162,137,181,114,165,167,188,69,204,50,218,142,213,44,181,239,180,80,186,25,129,32,173,36,206,41,64,15,78,234,183,170,96,90,97,24,194,192,184,162,96,122,49,92,45,140,51,34,240,57,71,13,106,14,121,133,15,214,224,112,27,237,29,78,176,152,161,190,125,166,179,128,7,232,120,252,56,235,220,85,142,87,150,37,126,67,236,120,6,113,253,22,150,144,163,237,131,169,134,95,191,219,75,188,24,229,52,29,54,250,141,93,225,169,230,213,121,236,90,243,182,146,6,224,98,119,35,69,7,94,25,203,214,241,2,151,87,71,182,97,123,193,166,63,161,232,251,138,154,136,139,13,38,219,129,173,110,95,76,56,52,255,140,175,105,46,226,190,21,68,30,24,171,169,9,247,160,124,63,134,141,72,15,248,173,199,46,202,172,46,198,177,146,236,124,184,83,234,59,181,16,47,44,200,17,54,149,227,168,238,137,98,108,126,3,235,98,92,19,99,77,216,47,198,70,118,112,166,212,195,186,63,102,55,207,131,105,210,218,246,245,7,239,188,224,119,44,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb44fa4e-3083-461b-a753-81b61ff52720"));
		}

		#endregion

	}

	#endregion

}


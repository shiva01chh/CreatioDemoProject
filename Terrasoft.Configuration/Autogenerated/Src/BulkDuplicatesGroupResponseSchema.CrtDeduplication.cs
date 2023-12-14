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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,201,78,195,48,20,60,183,18,255,240,212,94,64,66,233,189,45,61,144,160,170,135,130,212,112,67,28,220,228,37,50,56,118,229,5,84,42,254,157,23,71,93,146,238,228,224,196,206,204,104,60,206,68,178,2,205,130,37,8,175,168,53,51,42,179,65,168,100,198,115,167,153,229,74,222,180,87,55,237,150,51,92,230,16,47,141,197,98,208,152,19,94,8,76,74,176,9,198,40,81,243,228,36,230,101,254,65,143,83,149,162,216,195,205,156,180,188,192,32,38,21,38,248,143,247,64,40,194,117,53,230,52,129,80,48,99,250,240,232,196,231,19,129,237,50,20,28,165,141,220,66,240,132,89,52,99,173,220,194,83,222,34,102,25,109,199,106,150,216,119,90,88,184,57,129,32,41,37,206,41,64,31,78,234,183,202,96,90,189,94,15,134,198,21,5,211,203,209,122,97,146,18,129,103,28,53,168,12,242,18,31,108,192,189,93,180,119,56,197,98,142,250,246,153,206,2,30,160,227,241,147,180,115,87,58,94,91,150,248,13,99,199,83,24,87,111,97,5,57,218,1,152,114,248,245,187,189,196,139,81,78,211,97,163,223,216,21,158,42,94,149,71,211,154,183,21,215,0,23,187,11,21,29,120,105,44,221,196,11,92,94,29,217,150,237,5,235,254,132,162,239,43,170,35,46,54,24,239,6,182,190,125,49,225,208,252,51,190,186,185,136,251,86,16,121,104,172,166,38,220,131,242,253,24,213,34,61,224,183,26,187,40,211,170,24,199,74,210,248,112,103,212,119,106,33,94,88,144,35,108,42,199,81,221,19,197,216,254,6,54,197,184,38,198,138,176,95,140,173,236,240,76,169,71,85,127,76,51,207,131,105,210,90,121,253,1,46,163,96,110,36,5,0,0 };
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


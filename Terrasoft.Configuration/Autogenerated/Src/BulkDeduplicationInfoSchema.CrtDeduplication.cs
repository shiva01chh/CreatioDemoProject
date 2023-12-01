namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDeduplicationInfoSchema

	/// <exclude/>
	public class BulkDeduplicationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDeduplicationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDeduplicationInfoSchema(BulkDeduplicationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e14ddd74-99f1-4f32-b2b4-b4a8b303f9e2");
			Name = "BulkDeduplicationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,147,61,111,194,48,16,134,231,70,202,127,56,193,210,46,201,94,218,14,5,85,98,160,66,192,86,117,112,156,75,100,145,216,209,157,45,149,162,254,247,58,31,80,62,50,16,53,131,165,187,123,253,222,147,187,68,139,18,185,18,18,97,131,68,130,77,102,163,169,209,153,202,29,9,171,140,142,102,152,186,170,80,178,137,194,96,31,6,97,112,231,88,233,28,214,59,182,88,70,43,167,173,42,49,90,35,41,81,168,239,70,57,105,116,99,194,220,7,48,45,4,243,35,188,186,98,123,230,55,215,153,105,132,113,28,195,19,187,178,20,180,123,233,226,90,13,233,169,28,84,163,111,213,241,137,252,99,38,172,240,220,150,132,180,159,62,81,185,196,95,2,89,247,237,111,11,237,155,92,117,110,18,27,114,8,42,187,232,174,141,5,182,130,44,166,144,96,102,8,163,163,195,41,77,139,179,192,50,65,186,127,247,19,134,103,24,41,126,83,196,214,15,107,244,80,19,30,16,19,99,10,152,31,139,176,135,28,237,4,184,62,126,6,35,42,6,114,90,251,237,12,66,91,181,119,122,201,186,218,205,96,75,50,18,153,253,140,42,36,137,218,130,185,164,180,130,183,3,248,170,131,227,178,53,60,199,84,190,195,242,66,113,51,236,172,163,66,6,105,252,119,12,201,14,216,56,111,2,132,210,80,58,0,179,20,95,127,118,30,100,213,24,92,195,46,122,117,255,92,124,61,82,96,39,235,49,12,90,253,186,189,211,187,250,174,214,131,214,158,99,212,105,251,135,251,32,12,124,210,63,191,236,188,82,224,83,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e14ddd74-99f1-4f32-b2b4-b4a8b303f9e2"));
		}

		#endregion

	}

	#endregion

}


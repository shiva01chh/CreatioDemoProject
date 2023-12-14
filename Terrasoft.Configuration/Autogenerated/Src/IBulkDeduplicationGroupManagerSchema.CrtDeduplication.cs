namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkDeduplicationGroupManagerSchema

	/// <exclude/>
	public class IBulkDeduplicationGroupManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkDeduplicationGroupManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkDeduplicationGroupManagerSchema(IBulkDeduplicationGroupManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f12816d-d543-4f86-9793-07195211c781");
			Name = "IBulkDeduplicationGroupManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("dcfefe5b-65e2-4411-92b0-7b05d81d9c9b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,207,74,196,48,16,198,207,45,244,29,6,246,162,32,237,125,21,193,117,97,41,184,34,184,62,64,118,51,141,193,102,210,77,38,135,34,190,187,249,227,74,61,153,219,55,147,223,124,51,31,144,48,232,39,113,66,56,160,115,194,219,129,219,71,75,131,86,193,9,214,150,218,45,202,48,141,250,148,85,83,127,54,117,21,188,38,5,175,179,103,52,183,77,29,43,43,135,42,182,161,39,70,55,196,113,107,232,55,97,252,248,3,239,156,13,211,94,144,80,232,50,213,117,29,220,249,96,140,112,243,253,143,78,20,200,37,6,42,113,96,10,216,94,184,110,1,78,225,24,127,131,190,184,255,107,94,165,51,126,183,222,35,191,91,233,215,240,146,231,228,221,170,163,181,35,60,72,153,193,131,125,35,125,14,248,164,61,95,121,118,233,126,36,214,60,63,199,0,111,96,23,180,44,123,246,242,186,68,82,173,144,100,49,136,234,171,196,180,40,53,117,172,165,247,13,70,242,25,149,132,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f12816d-d543-4f86-9793-07195211c781"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkDeduplicationTaskStarterSchema

	/// <exclude/>
	public class IBulkDeduplicationTaskStarterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkDeduplicationTaskStarterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkDeduplicationTaskStarterSchema(IBulkDeduplicationTaskStarterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("34bd4c3a-5be2-45e6-81db-f052a01f9932");
			Name = "IBulkDeduplicationTaskStarter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,177,78,195,48,16,134,231,70,202,59,156,218,5,150,120,135,208,1,88,186,84,72,237,11,56,241,37,88,77,236,232,206,174,132,16,239,206,217,161,40,180,3,150,151,223,254,191,255,206,103,167,71,228,73,183,8,71,36,210,236,187,80,189,120,215,217,62,146,14,214,187,234,21,77,156,6,219,102,85,22,159,101,177,146,189,33,236,69,195,206,5,164,78,248,7,216,61,199,225,244,199,125,212,124,58,4,77,98,41,11,129,148,82,80,115,28,71,77,31,219,31,253,70,254,108,13,50,140,24,222,189,129,206,19,112,98,172,235,161,145,68,48,203,72,152,200,183,200,92,93,226,212,34,111,138,141,248,192,94,122,250,175,165,85,122,204,77,87,249,32,123,248,170,118,16,184,250,69,212,53,83,79,154,244,8,78,70,250,180,102,108,19,179,23,177,222,30,102,145,175,170,90,101,95,198,26,239,135,185,214,77,151,119,28,40,205,96,17,116,255,40,204,87,30,229,6,157,153,191,32,73,57,75,235,27,213,117,69,221,205,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34bd4c3a-5be2-45e6-81db-f052a01f9932"));
		}

		#endregion

	}

	#endregion

}


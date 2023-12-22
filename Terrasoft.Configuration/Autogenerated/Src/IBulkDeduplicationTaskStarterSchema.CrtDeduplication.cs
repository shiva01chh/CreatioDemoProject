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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,177,78,195,48,16,134,231,70,202,59,156,218,5,150,120,135,208,1,88,186,84,72,237,11,56,241,37,88,141,237,232,206,174,132,16,239,206,197,161,40,180,3,150,151,223,254,191,255,206,103,175,29,242,168,91,132,35,18,105,14,93,172,94,130,239,108,159,72,71,27,124,245,138,38,141,131,109,179,42,139,207,178,88,201,222,16,246,162,97,231,35,82,39,252,3,236,158,211,112,250,227,62,106,62,29,162,38,177,148,133,64,74,41,168,57,57,167,233,99,251,163,223,40,156,173,65,6,135,241,61,24,232,2,1,79,140,245,61,52,146,8,102,25,9,35,133,22,153,171,75,156,90,228,141,169,17,31,216,75,79,255,181,180,154,30,115,211,85,62,200,30,190,170,29,5,174,126,17,117,205,212,163,38,237,192,203,72,159,214,140,237,196,236,69,172,183,135,89,228,171,170,86,217,151,177,38,132,97,174,117,211,229,29,71,154,102,176,8,186,127,20,230,43,143,114,131,222,204,95,48,73,57,91,174,111,205,100,244,29,213,1,0,0 };
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


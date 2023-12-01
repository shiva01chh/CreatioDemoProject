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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,177,78,195,48,16,134,231,70,202,59,156,218,5,22,123,135,208,1,88,186,84,72,237,11,56,241,37,88,77,236,232,206,169,132,16,239,206,217,161,40,180,3,150,151,223,254,191,255,206,103,111,6,228,209,52,8,71,36,50,28,218,168,94,130,111,93,55,145,137,46,120,245,138,118,26,123,215,100,85,22,159,101,177,146,189,33,236,68,195,206,71,164,86,248,7,216,61,79,253,233,143,251,104,248,116,136,134,196,82,22,2,105,173,161,226,105,24,12,125,108,127,244,27,133,179,179,200,48,96,124,15,22,218,64,192,137,113,190,131,90,18,193,46,35,97,164,208,32,179,186,196,233,69,222,56,213,226,3,119,233,233,191,150,86,233,49,55,93,229,131,236,225,171,218,81,96,245,139,232,107,166,26,13,153,1,188,140,244,105,205,216,36,102,47,98,189,61,204,34,95,169,74,103,95,198,234,16,250,185,214,77,151,119,28,41,205,96,17,116,255,40,204,87,30,229,6,189,157,191,32,73,57,147,245,13,67,108,99,71,204,1,0,0 };
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


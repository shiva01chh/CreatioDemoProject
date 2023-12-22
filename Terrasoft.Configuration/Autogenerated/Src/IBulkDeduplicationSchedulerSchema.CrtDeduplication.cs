namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkDeduplicationSchedulerSchema

	/// <exclude/>
	public class IBulkDeduplicationSchedulerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkDeduplicationSchedulerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkDeduplicationSchedulerSchema(IBulkDeduplicationSchedulerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ddfb5587-be3e-400d-bba5-ff6929417fb9");
			Name = "IBulkDeduplicationScheduler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,147,77,79,195,48,12,134,207,155,180,255,96,109,23,184,180,247,49,118,128,94,134,4,154,216,238,40,109,220,54,208,38,85,146,130,166,137,255,78,62,150,182,251,128,209,67,85,59,246,155,199,175,92,78,106,84,13,201,16,182,40,37,81,34,215,209,163,224,57,43,90,73,52,19,60,74,144,182,77,197,50,23,77,198,251,201,120,52,147,88,152,0,86,92,163,204,77,243,28,222,86,15,109,245,113,84,187,65,34,179,114,147,149,38,89,161,156,140,77,103,28,199,176,80,109,93,19,185,91,30,226,87,108,36,42,228,90,1,1,21,202,33,23,18,106,194,73,193,120,1,65,22,21,40,39,11,239,34,85,81,80,140,7,146,77,155,154,82,96,129,13,46,144,245,76,163,189,227,234,70,122,70,93,10,170,230,176,118,50,254,240,148,218,37,130,136,165,190,136,7,95,76,151,118,164,6,51,150,51,164,208,16,105,236,54,92,81,167,26,159,202,46,92,17,112,83,120,63,237,117,195,109,212,187,186,14,74,211,229,182,196,94,24,68,14,218,36,130,141,23,200,172,175,150,78,105,34,181,241,54,90,196,174,221,17,124,10,70,187,201,252,85,79,34,189,73,174,114,192,117,212,219,187,63,220,76,176,66,141,195,13,248,197,212,116,119,100,233,225,196,54,213,196,185,246,95,111,125,203,139,249,246,30,158,43,117,86,81,11,103,255,133,51,171,60,118,111,148,210,210,174,107,175,29,134,158,33,167,126,197,92,252,237,222,195,164,203,12,159,31,87,255,157,190,154,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ddfb5587-be3e-400d-bba5-ff6929417fb9"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,147,77,79,195,48,12,134,207,171,180,255,96,109,23,184,180,247,49,118,128,93,134,4,154,216,238,40,109,220,54,208,38,85,146,130,166,137,255,78,62,150,118,31,133,209,67,85,59,246,155,199,175,92,78,106,84,13,201,16,182,40,37,81,34,215,241,163,224,57,43,90,73,52,19,60,94,34,109,155,138,101,46,26,71,251,113,52,154,74,44,76,0,43,174,81,230,166,121,6,111,171,135,182,250,56,169,221,32,145,89,185,201,74,147,172,80,142,35,211,153,36,9,204,85,91,215,68,238,22,135,248,21,27,137,10,185,86,64,64,133,114,200,133,132,154,112,82,48,94,64,144,69,5,202,201,194,187,72,85,28,20,147,35,201,166,77,77,41,176,192,6,3,100,61,211,104,239,184,186,145,158,81,151,130,170,25,172,157,140,63,60,167,118,137,32,98,169,7,241,224,139,233,210,142,212,96,198,114,134,20,26,34,141,221,134,43,238,84,147,115,217,185,43,2,110,10,239,39,189,110,184,141,122,87,215,65,105,178,216,150,216,11,131,200,65,155,68,176,113,128,204,250,106,233,148,38,82,27,111,227,121,226,218,29,193,167,96,180,155,204,95,245,36,210,155,229,85,14,184,142,122,123,247,135,155,75,172,80,227,241,6,252,98,106,186,59,177,244,112,98,155,106,226,92,251,175,183,190,229,197,124,123,15,47,149,58,171,168,133,179,255,194,133,85,30,187,55,74,105,105,215,181,215,14,67,79,145,83,191,98,46,254,118,239,227,164,203,216,231,7,136,221,233,214,146,3,0,0 };
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


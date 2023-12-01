namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRecordsOperationWorkerSchema

	/// <exclude/>
	public class IRecordsOperationWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRecordsOperationWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRecordsOperationWorkerSchema(IRecordsOperationWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("de0a68c6-78e9-4e0a-a753-aa946a7db874");
			Name = "IRecordsOperationWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,77,79,195,48,12,61,15,137,255,96,141,11,92,218,251,86,42,77,104,26,59,32,38,152,196,57,75,220,46,162,77,138,157,12,77,136,255,78,154,174,101,155,134,68,46,145,237,247,236,231,15,35,106,228,70,72,132,53,18,9,182,133,75,30,172,41,116,233,73,56,109,13,124,93,95,141,60,107,83,194,235,158,29,214,211,51,59,192,171,10,101,139,229,100,129,6,73,203,128,9,168,27,194,178,205,176,52,14,169,8,53,38,176,124,65,105,73,241,115,131,93,250,55,75,239,72,17,158,166,41,100,236,235,90,208,62,63,216,3,21,108,1,110,27,190,158,8,206,2,117,201,146,158,156,30,177,27,191,169,180,4,61,36,248,163,116,219,95,128,15,98,231,59,52,142,39,176,138,252,46,118,174,44,58,214,164,203,18,137,225,115,139,6,196,65,12,104,134,134,172,68,102,84,201,64,62,86,54,194,182,68,87,232,81,24,85,33,101,157,182,85,79,140,177,25,149,156,195,89,100,122,80,139,70,117,130,79,213,63,161,219,90,245,31,249,179,166,169,52,242,233,64,219,9,31,13,245,130,246,232,105,4,137,26,76,56,157,251,177,28,182,63,206,127,47,161,95,151,55,250,195,35,104,21,250,209,133,14,227,74,178,52,210,99,182,157,213,42,42,217,15,91,225,219,229,220,248,58,88,155,10,179,133,215,42,135,223,26,119,151,251,255,238,238,237,196,25,125,225,253,0,51,156,189,108,226,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("de0a68c6-78e9-4e0a-a753-aa946a7db874"));
		}

		#endregion

	}

	#endregion

}


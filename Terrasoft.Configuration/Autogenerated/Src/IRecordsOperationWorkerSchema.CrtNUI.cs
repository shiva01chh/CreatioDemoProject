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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,77,107,195,48,12,61,119,176,255,32,186,203,118,73,238,109,22,40,163,116,61,140,149,173,176,179,27,43,169,88,98,103,178,221,81,198,254,251,28,167,73,211,210,194,124,49,146,222,147,158,62,148,168,208,212,34,67,88,35,179,48,58,183,209,147,86,57,21,142,133,37,173,224,231,246,102,228,12,169,2,222,247,198,98,53,61,179,61,188,44,49,107,176,38,90,160,66,166,204,99,60,234,142,177,104,50,44,149,69,206,125,141,9,44,223,48,211,44,205,107,141,109,250,15,205,159,200,1,30,199,49,36,198,85,149,224,125,122,176,123,42,232,28,236,214,127,29,17,172,6,110,147,69,29,57,30,176,107,183,41,41,3,234,19,92,41,221,244,231,225,189,216,249,14,149,53,19,88,5,126,27,59,87,22,28,107,166,162,64,54,240,189,69,5,226,32,6,200,64,205,58,67,99,80,70,61,121,168,108,132,77,137,182,208,179,80,178,68,78,90,109,171,142,24,98,51,46,76,10,103,145,233,65,45,42,217,10,62,85,255,130,118,171,229,127,228,207,234,186,36,52,167,3,109,38,60,24,234,5,237,193,83,11,22,21,40,127,58,143,227,172,223,254,56,61,94,66,183,46,167,232,203,33,144,244,253,80,78,126,92,81,18,7,122,200,182,211,36,131,146,125,191,21,115,191,156,43,87,121,107,83,98,178,112,36,83,56,214,120,184,220,255,111,123,111,39,206,224,27,190,63,191,62,171,132,235,2,0,0 };
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


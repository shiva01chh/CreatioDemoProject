namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: QueueEntityEventAsyncOperationArgsSchema

	/// <exclude/>
	public class QueueEntityEventAsyncOperationArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public QueueEntityEventAsyncOperationArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public QueueEntityEventAsyncOperationArgsSchema(QueueEntityEventAsyncOperationArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1ee00480-4744-4349-9314-bc0a08994574");
			Name = "QueueEntityEventAsyncOperationArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("64ebcdcc-1a9c-4eb3-9403-16c8221d18f7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,111,107,194,48,16,198,95,43,236,59,28,238,141,131,209,190,87,39,136,136,8,131,57,182,47,16,227,181,11,180,169,228,146,129,200,190,251,46,73,91,91,97,42,19,252,147,235,115,119,191,123,46,106,81,34,29,132,68,248,68,99,4,85,153,77,150,149,206,84,238,140,176,170,210,15,195,211,195,112,224,72,233,28,62,142,100,177,156,94,156,89,95,20,40,189,152,146,53,106,52,74,158,53,221,178,6,147,149,182,202,42,164,155,130,100,65,71,45,223,14,24,49,124,2,167,60,26,204,249,4,203,66,16,77,224,221,161,195,144,113,92,125,163,182,253,156,133,201,41,100,165,105,10,51,114,101,41,204,113,94,159,67,5,48,120,48,72,156,73,44,64,4,105,48,123,25,93,173,56,74,231,160,244,23,79,105,43,3,25,191,29,33,71,186,5,2,215,134,189,161,80,228,85,177,79,236,11,167,38,13,78,218,225,57,184,93,161,36,200,128,116,123,38,152,192,141,153,7,167,48,247,217,46,54,208,26,39,153,152,93,219,134,118,81,81,183,190,221,116,28,159,2,134,175,103,136,50,79,131,205,175,39,6,219,9,194,113,163,233,60,241,151,104,240,83,83,161,222,71,176,62,229,214,84,220,209,47,191,207,120,185,190,58,208,119,59,174,133,172,208,124,151,101,123,35,147,86,223,53,188,25,123,179,210,174,228,33,119,5,206,226,124,243,104,5,69,224,65,142,118,10,196,31,45,254,61,64,177,84,143,72,220,65,195,43,242,127,136,69,144,254,9,240,175,246,85,179,74,80,123,191,157,76,161,185,14,179,118,106,15,237,13,216,236,175,240,92,236,51,70,251,65,142,249,215,47,251,159,190,52,110,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1ee00480-4744-4349-9314-bc0a08994574"));
		}

		#endregion

	}

	#endregion

}


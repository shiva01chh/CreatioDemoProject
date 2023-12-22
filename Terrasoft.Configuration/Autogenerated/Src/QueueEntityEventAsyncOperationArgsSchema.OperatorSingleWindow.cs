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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,111,107,194,48,16,198,95,43,236,59,28,238,141,131,209,190,87,39,136,136,8,131,57,182,47,16,211,107,23,104,211,146,75,6,69,246,221,119,77,172,182,194,172,76,240,79,174,207,221,253,238,185,168,69,129,84,9,137,240,137,198,8,42,83,27,173,75,157,170,204,25,97,85,169,31,198,199,135,241,200,145,210,25,124,212,100,177,152,95,157,89,159,231,40,27,49,69,91,212,104,148,188,104,186,101,13,70,27,109,149,85,72,131,130,104,69,181,150,111,21,6,140,38,129,83,30,13,102,124,130,117,46,136,102,240,238,208,161,207,168,55,223,168,109,63,103,101,50,242,89,113,28,195,130,92,81,8,83,47,79,103,95,1,12,86,6,137,51,137,5,136,32,13,166,47,147,155,21,39,241,18,148,254,226,41,109,105,32,229,183,35,228,72,183,128,231,218,177,55,228,139,188,42,246,137,125,225,212,168,197,137,59,60,149,59,228,74,130,244,72,195,51,193,12,6,102,30,29,253,220,23,187,216,64,107,156,100,98,118,109,239,219,5,197,169,245,112,211,105,120,10,232,191,158,33,200,26,26,108,127,61,49,216,65,16,78,91,77,231,73,115,137,70,63,39,42,212,73,0,235,83,238,77,201,29,155,229,247,25,175,215,119,10,244,221,14,107,33,43,52,223,101,121,190,145,209,89,223,53,188,29,123,183,209,174,224,33,15,57,46,194,124,203,96,5,5,224,81,134,118,14,196,31,103,252,123,128,66,169,30,145,184,131,134,87,212,252,33,86,94,250,39,192,191,218,151,237,42,65,37,205,118,82,133,230,54,204,214,169,4,206,55,96,151,220,224,185,218,103,136,246,131,28,235,190,126,1,132,161,73,12,118,4,0,0 };
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


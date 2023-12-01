namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TrackingLoggerSchema

	/// <exclude/>
	public class TrackingLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TrackingLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TrackingLoggerSchema(TrackingLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e1b4bc65-b177-4549-904d-d9ef71e207d9");
			Name = "TrackingLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("874306e1-e314-437e-96bf-3f336a8aaf12");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,77,79,220,48,16,61,103,37,254,195,40,92,18,9,57,119,186,187,135,82,42,173,84,42,164,93,206,200,56,179,169,213,196,142,252,65,89,42,254,59,99,231,131,36,80,212,83,60,31,239,205,155,55,81,188,65,219,114,129,112,64,99,184,213,71,199,174,180,58,202,202,27,238,164,86,236,96,184,248,45,85,117,182,250,123,182,74,188,165,39,236,79,214,97,243,101,140,167,88,131,255,202,179,111,95,169,68,197,115,131,21,81,195,85,205,173,189,132,97,194,15,93,85,104,98,71,235,31,106,41,64,132,134,119,245,36,8,25,73,190,75,172,75,98,185,53,242,145,59,140,240,164,237,2,48,200,75,173,234,19,220,89,52,180,151,66,17,150,130,123,63,139,59,89,201,57,170,178,99,237,227,65,167,86,214,25,47,156,54,97,80,212,214,117,20,69,1,107,235,155,134,155,211,118,72,236,148,116,146,215,242,25,169,134,8,194,224,113,147,206,183,72,139,45,72,98,229,74,32,27,153,138,37,213,186,229,134,55,160,232,74,155,116,174,57,221,238,122,60,232,227,116,208,124,85,26,196,214,69,164,137,172,189,179,115,53,217,194,158,249,164,28,162,225,201,194,52,216,192,59,23,147,228,229,115,43,111,208,253,210,229,194,197,94,211,163,150,37,144,160,140,204,14,127,79,163,75,95,227,79,218,253,2,134,20,90,203,43,28,20,145,3,104,92,48,50,124,54,160,240,15,116,185,108,33,54,103,59,229,116,54,189,66,154,71,193,73,135,102,123,116,89,122,51,142,76,47,232,236,181,111,20,187,13,222,161,35,151,222,4,229,31,97,59,109,31,2,123,217,115,212,245,19,10,239,48,203,167,198,253,135,23,215,79,2,219,120,1,28,94,131,33,1,49,109,29,27,216,65,239,35,83,150,231,159,220,169,203,206,147,148,91,173,94,1,8,79,116,138,40,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e1b4bc65-b177-4549-904d-d9ef71e207d9"));
		}

		#endregion

	}

	#endregion

}


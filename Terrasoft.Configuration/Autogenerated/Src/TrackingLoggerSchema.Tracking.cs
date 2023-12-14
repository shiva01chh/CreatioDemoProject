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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,78,220,64,16,60,27,137,127,104,153,139,45,161,241,29,118,247,16,66,164,149,66,132,180,155,115,52,140,123,205,40,246,140,53,15,194,130,248,119,122,198,15,108,67,16,190,216,253,168,234,234,106,43,222,160,109,185,64,216,163,49,220,234,131,99,87,90,29,100,229,13,119,82,43,182,55,92,252,149,170,58,61,121,62,61,73,188,165,79,216,29,173,195,230,114,140,167,88,131,255,203,179,239,223,168,68,197,51,131,21,81,195,85,205,173,189,128,97,194,79,93,85,104,98,71,235,239,106,41,64,132,134,119,245,36,8,25,73,126,72,172,75,98,185,53,242,129,59,140,240,164,237,2,48,200,75,173,234,35,252,182,104,104,47,133,34,44,5,127,252,44,238,100,37,103,168,202,142,181,143,7,157,90,89,103,188,112,218,132,65,81,91,215,81,20,5,172,172,111,26,110,142,155,33,177,85,210,73,94,203,39,164,26,34,8,131,135,117,58,223,34,45,54,32,137,149,43,129,108,100,42,150,84,171,150,27,222,128,162,43,173,211,185,230,116,179,237,241,160,15,211,65,243,85,105,16,91,21,145,38,178,246,206,206,213,100,11,123,230,147,114,136,134,39,11,211,96,13,239,92,76,146,151,207,173,188,65,119,175,203,133,139,189,166,7,45,75,32,65,25,153,29,254,158,70,151,190,198,95,180,251,57,12,41,180,150,87,56,40,34,7,208,184,96,100,120,173,65,225,63,232,114,217,66,108,206,182,202,233,108,122,133,52,143,130,147,14,205,118,232,178,244,102,28,153,158,211,217,107,223,40,118,27,188,67,71,46,189,9,202,63,194,118,218,62,4,246,178,231,168,235,71,20,222,97,150,79,141,251,130,23,215,143,2,219,120,1,28,190,6,67,2,98,218,58,54,176,189,222,69,166,44,207,63,185,83,151,157,39,41,71,207,43,238,250,134,60,41,4,0,0 };
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


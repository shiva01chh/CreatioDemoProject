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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,110,219,48,16,60,43,64,254,97,161,92,36,192,160,238,173,237,67,19,7,48,144,20,1,236,158,11,150,90,43,68,36,82,224,35,141,91,244,223,187,164,30,149,148,52,136,46,210,62,102,118,118,86,138,55,104,91,46,16,142,104,12,183,250,228,216,181,86,39,89,121,195,157,212,138,29,13,23,79,82,85,151,23,191,47,47,18,111,233,19,14,103,235,176,249,60,198,83,172,193,255,229,217,205,23,42,81,241,202,96,69,212,112,93,115,107,63,193,48,225,78,87,21,154,216,209,250,31,181,20,32,66,195,171,122,18,132,140,36,183,18,235,146,88,30,140,124,230,14,35,60,105,187,0,12,242,82,171,250,12,223,44,26,218,75,161,8,75,193,119,63,139,59,89,201,21,170,178,99,237,227,65,167,86,214,25,47,156,54,97,80,212,214,117,20,69,1,107,235,155,134,155,243,118,72,236,149,116,146,215,242,23,82,13,17,132,193,211,38,157,111,145,22,91,144,196,202,149,64,54,50,21,75,170,117,203,13,111,64,209,149,54,233,92,115,186,221,247,120,208,167,233,160,249,170,52,136,173,139,72,19,89,123,103,231,106,178,133,61,243,73,57,68,195,147,133,105,176,129,87,46,38,201,159,247,173,188,71,247,168,203,133,139,189,166,103,45,75,32,65,25,153,29,254,158,70,151,190,198,175,180,251,10,134,20,90,203,43,28,20,145,3,104,92,48,50,188,54,160,240,39,116,185,108,33,54,103,123,229,116,54,189,66,154,71,193,73,135,102,7,116,89,122,63,142,76,87,116,246,218,55,138,61,4,239,208,145,75,255,4,229,111,97,59,109,111,2,123,217,115,212,238,5,133,119,152,229,83,227,62,224,197,238,69,96,27,47,128,195,215,96,72,64,76,91,199,6,118,212,135,200,148,229,249,59,119,234,178,243,36,229,38,207,95,136,51,197,57,49,4,0,0 };
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


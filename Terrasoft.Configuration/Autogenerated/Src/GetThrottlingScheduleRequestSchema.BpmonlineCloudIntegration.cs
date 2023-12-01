namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetThrottlingScheduleRequestSchema

	/// <exclude/>
	public class GetThrottlingScheduleRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetThrottlingScheduleRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetThrottlingScheduleRequestSchema(GetThrottlingScheduleRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("164861d9-449c-4213-a157-80657f43f33a");
			Name = "GetThrottlingScheduleRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,49,111,194,48,16,133,103,144,248,15,39,186,180,75,178,67,219,161,161,170,24,168,16,97,171,170,202,56,71,176,148,216,212,119,174,68,81,255,123,47,78,72,161,3,89,44,63,191,247,124,159,99,85,141,180,87,26,97,141,222,43,114,91,78,50,103,183,166,12,94,177,113,54,201,158,243,149,88,156,37,164,209,240,56,26,14,2,25,91,66,126,32,198,58,89,5,203,166,198,36,71,111,84,101,190,99,104,218,187,174,180,46,92,129,21,137,85,204,55,30,75,145,33,171,20,209,4,94,144,215,59,239,152,43,233,200,245,14,139,80,225,10,63,3,18,71,127,154,166,112,79,161,174,149,63,60,118,251,153,98,5,218,89,246,74,51,176,131,18,101,233,107,128,186,30,74,78,5,233,89,195,91,19,207,186,244,187,8,251,176,169,140,6,221,76,116,117,32,152,192,147,34,148,7,248,50,250,111,202,193,49,78,218,163,45,189,219,163,103,131,194,183,140,221,237,249,127,148,40,200,125,4,206,3,53,235,124,6,110,123,65,34,67,50,150,135,164,207,159,147,180,40,11,172,55,232,111,95,229,255,194,3,140,79,145,15,83,140,239,26,188,19,159,177,12,121,119,56,47,224,216,188,218,180,185,119,10,63,29,0,218,162,101,136,251,86,189,20,163,38,223,47,7,195,147,7,78,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("164861d9-449c-4213-a157-80657f43f33a"));
		}

		#endregion

	}

	#endregion

}


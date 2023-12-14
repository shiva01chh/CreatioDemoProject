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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,63,111,194,48,16,197,103,144,248,14,39,186,180,75,178,67,219,161,161,170,24,168,16,97,171,170,202,56,71,176,148,216,169,239,92,137,162,126,247,218,206,159,66,7,178,88,126,126,239,249,126,142,22,53,82,35,36,194,22,173,21,100,246,156,100,70,239,85,233,172,96,101,116,146,61,231,27,111,49,154,144,38,227,211,100,60,114,164,116,9,249,145,24,235,100,227,52,171,26,147,28,173,18,149,250,142,161,249,224,186,210,186,50,5,86,228,173,222,124,99,177,244,50,100,149,32,154,193,11,242,246,96,13,115,229,59,114,121,192,194,85,184,193,79,135,196,209,159,166,41,220,147,171,107,97,143,143,221,126,33,88,128,52,154,173,144,12,108,160,68,191,12,53,64,93,15,37,125,65,122,214,240,22,226,89,151,126,247,66,227,118,149,146,32,195,68,87,7,130,25,60,9,66,255,0,95,74,254,77,57,58,197,73,7,180,181,53,13,90,86,232,249,214,177,187,61,255,143,18,5,127,31,129,177,64,97,93,46,192,236,47,72,252,144,140,229,49,25,242,231,36,45,202,10,235,29,218,219,87,255,127,225,1,166,125,228,67,21,211,187,128,215,243,41,205,144,119,135,203,2,78,225,213,230,225,222,57,252,116,0,168,139,150,33,238,91,245,82,140,90,248,126,1,243,0,180,172,79,2,0,0 };
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


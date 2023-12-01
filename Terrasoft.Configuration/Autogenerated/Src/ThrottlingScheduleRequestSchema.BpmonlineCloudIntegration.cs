namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ThrottlingScheduleRequestSchema

	/// <exclude/>
	public class ThrottlingScheduleRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ThrottlingScheduleRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ThrottlingScheduleRequestSchema(ThrottlingScheduleRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9582f96f-5bbb-484d-b61c-0857214e30ce");
			Name = "ThrottlingScheduleRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,147,77,111,219,48,12,134,207,49,144,255,64,164,151,237,98,223,251,117,88,91,20,59,116,8,234,222,138,34,80,45,218,21,32,91,153,40,13,240,130,254,247,81,138,133,186,113,220,125,96,65,144,72,20,249,240,21,73,1,116,162,69,218,138,10,225,1,173,21,100,106,151,95,153,174,86,141,183,194,41,211,45,179,221,50,3,254,120,82,93,3,101,79,14,219,179,101,182,24,239,243,123,223,57,213,98,94,162,85,66,171,159,49,244,205,107,134,157,95,221,148,119,70,162,38,118,101,231,162,40,224,156,124,219,10,219,95,14,251,135,23,107,156,211,129,66,213,11,74,175,17,164,112,2,218,16,152,167,168,98,20,246,120,205,231,156,200,89,81,185,39,54,108,253,179,86,21,84,90,16,141,128,229,192,99,143,93,204,191,56,177,216,176,46,88,91,179,69,235,20,210,41,172,99,240,254,60,146,239,176,125,70,251,233,27,87,14,46,96,37,69,191,250,28,178,164,52,170,115,112,45,122,216,65,131,238,12,40,252,188,126,16,143,90,244,27,78,183,193,86,40,125,132,21,28,214,104,111,194,241,159,82,35,139,34,246,168,192,8,35,166,206,40,61,193,78,238,139,17,247,175,113,6,194,50,140,194,65,159,146,41,200,128,106,168,59,56,3,126,203,157,66,112,211,22,230,35,80,241,158,116,216,189,96,251,77,3,239,241,187,71,114,167,240,69,16,242,8,254,80,85,178,237,227,119,73,249,140,250,100,190,69,71,96,108,168,4,65,44,33,248,78,49,8,148,68,158,240,90,161,205,15,72,197,20,53,219,144,141,146,177,21,201,113,184,215,173,87,114,223,145,175,114,218,140,191,213,61,46,55,23,209,97,211,179,252,127,148,157,8,51,202,195,40,149,131,203,255,208,174,21,57,48,245,219,83,63,39,68,168,44,214,23,171,105,223,87,197,229,7,215,58,254,48,18,249,253,147,152,178,31,159,32,45,15,175,21,146,241,223,34,126,121,145,101,191,0,18,183,213,173,72,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9582f96f-5bbb-484d-b61c-0857214e30ce"));
		}

		#endregion

	}

	#endregion

}


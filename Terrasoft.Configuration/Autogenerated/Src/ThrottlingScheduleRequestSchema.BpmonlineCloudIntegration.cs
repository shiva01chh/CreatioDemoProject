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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,147,77,79,227,48,16,134,207,173,212,255,48,42,151,229,146,220,249,58,44,32,180,7,86,21,225,134,80,101,226,73,176,228,196,93,143,141,20,42,254,251,142,221,88,132,166,97,217,213,70,81,98,143,103,158,121,61,99,3,180,162,65,218,136,18,225,30,173,21,100,42,151,93,154,182,82,181,183,194,41,211,46,230,219,197,28,248,241,164,218,26,138,142,28,54,167,139,249,108,56,207,238,124,235,84,131,89,129,86,9,173,94,99,232,187,215,4,59,187,188,46,110,141,68,77,236,202,206,121,158,195,25,249,166,17,182,187,232,231,247,207,214,56,167,3,133,202,103,148,94,35,72,225,4,52,33,48,75,81,249,32,236,225,138,215,57,145,179,162,116,143,108,216,248,39,173,74,40,181,32,26,0,139,158,199,30,219,152,127,118,100,177,102,93,176,178,102,131,214,41,164,19,88,197,224,221,122,36,223,98,243,132,246,219,79,174,28,156,195,82,138,110,121,28,178,164,52,170,117,112,37,58,216,66,141,238,20,40,124,222,62,137,71,45,186,53,167,91,99,35,148,62,192,10,14,43,180,215,97,249,171,212,200,162,136,61,40,48,194,136,169,19,74,143,176,149,187,98,196,249,91,60,3,97,24,142,194,94,159,146,41,200,128,178,175,59,56,3,126,195,157,66,112,227,22,102,3,80,254,145,180,223,189,96,251,67,3,239,240,151,71,114,39,240,93,16,242,17,124,81,101,178,237,226,183,73,249,132,250,100,190,65,71,96,108,168,4,65,44,33,248,86,49,8,148,68,62,225,149,66,155,237,145,242,49,106,178,33,107,37,99,43,146,99,191,175,27,175,228,174,35,63,228,184,25,127,171,123,88,110,46,162,195,186,99,249,255,40,59,17,38,148,135,163,84,244,46,255,67,187,86,228,192,84,239,87,253,140,16,161,180,88,157,47,199,125,95,230,23,159,108,235,240,197,72,228,143,87,98,204,126,120,132,52,220,223,86,72,198,191,89,124,121,192,207,111,108,162,195,193,73,5,0,0 };
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


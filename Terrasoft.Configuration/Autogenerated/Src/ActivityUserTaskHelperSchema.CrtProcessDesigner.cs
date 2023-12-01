namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActivityUserTaskHelperSchema

	/// <exclude/>
	public class ActivityUserTaskHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActivityUserTaskHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActivityUserTaskHelperSchema(ActivityUserTaskHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("64a98983-9363-4df0-9a04-3cf2dd6cddc8");
			Name = "ActivityUserTaskHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,219,106,227,48,16,125,118,161,255,48,155,125,73,32,216,239,205,5,218,144,110,11,219,82,72,119,223,181,242,56,17,213,197,104,164,176,166,244,223,87,150,108,55,110,211,53,70,104,46,231,204,153,209,104,166,144,106,198,17,158,209,90,70,166,114,249,198,232,74,236,189,101,78,24,125,121,241,122,121,145,121,18,122,15,187,134,28,170,197,96,159,66,148,50,250,124,196,98,190,213,78,56,129,20,18,66,202,119,139,251,192,12,27,201,136,174,224,154,59,113,20,174,249,69,104,159,25,189,220,161,172,209,134,188,240,23,69,1,75,242,74,49,219,172,59,251,201,154,163,40,145,128,249,191,66,138,16,1,133,238,96,74,130,202,88,112,7,4,214,81,130,15,156,224,2,105,222,147,21,39,108,181,255,35,5,7,114,161,83,14,188,149,243,181,154,215,168,125,16,255,144,74,94,193,83,36,73,193,143,114,163,227,86,72,73,192,141,244,74,195,145,73,143,96,170,40,19,219,177,52,249,128,44,62,66,151,53,179,76,129,14,143,180,154,164,236,201,122,155,80,203,34,6,207,231,166,106,143,225,62,89,111,82,229,54,240,127,80,212,54,228,71,107,4,24,143,235,104,68,9,187,26,185,168,154,126,104,63,141,121,241,117,34,248,221,226,167,73,108,215,233,60,96,109,187,30,239,242,230,240,195,7,158,88,108,6,237,170,101,153,168,96,154,170,223,211,86,213,174,153,206,250,80,102,209,121,27,23,45,203,222,226,153,42,236,248,1,21,27,30,190,51,87,253,136,147,189,248,4,72,82,195,41,145,183,219,222,41,163,128,28,83,229,41,147,190,162,232,10,141,92,171,158,45,191,21,186,188,105,218,126,167,239,173,207,22,67,183,103,192,223,86,160,189,148,67,227,125,35,232,78,199,251,25,56,239,102,121,50,162,183,110,115,81,151,105,121,163,157,188,99,103,244,133,239,31,171,174,23,73,22,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("64a98983-9363-4df0-9a04-3cf2dd6cddc8"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,219,106,220,48,16,125,118,32,255,48,221,190,236,194,98,191,103,47,144,44,155,182,208,150,192,166,125,87,229,241,174,136,46,70,35,45,53,33,255,94,89,178,29,59,217,212,24,161,185,156,51,103,70,163,153,66,170,25,71,120,68,107,25,153,202,229,59,163,43,113,244,150,57,97,244,245,213,243,245,85,230,73,232,35,28,26,114,168,86,131,61,134,40,101,244,229,136,197,124,175,157,112,2,41,36,132,148,207,22,143,129,25,118,146,17,221,192,45,119,226,44,92,243,139,208,62,50,122,250,138,178,70,27,242,194,95,20,5,172,201,43,197,108,179,237,236,7,107,206,162,68,2,230,255,10,41,66,4,20,186,147,41,9,42,99,193,157,16,88,71,9,62,112,130,11,164,121,79,86,140,216,106,255,71,10,14,228,66,167,28,120,43,231,99,53,207,81,251,32,254,71,42,121,3,15,145,36,5,223,202,141,142,123,33,37,1,55,210,43,13,103,38,61,130,169,162,76,108,199,210,228,3,178,120,11,93,215,204,50,5,58,60,210,102,150,178,103,219,125,66,173,139,24,188,156,155,170,253,12,247,217,118,151,42,183,129,255,131,162,182,33,63,90,19,192,116,92,103,35,74,56,212,200,69,213,244,67,251,110,204,147,175,19,193,239,22,63,79,98,187,78,151,1,107,219,245,120,149,183,132,47,62,240,196,98,11,104,87,45,203,68,5,243,84,253,27,237,85,237,154,249,162,15,101,22,157,183,113,209,178,236,37,158,169,194,129,159,80,177,225,225,59,115,211,143,56,217,171,119,128,36,53,156,18,121,187,237,157,50,10,200,41,85,158,50,233,35,138,174,208,196,181,233,217,242,123,161,203,187,166,237,119,254,218,250,98,53,116,123,1,252,105,3,218,75,57,52,222,55,130,110,60,222,247,192,101,55,203,209,136,94,186,205,69,93,166,229,141,118,242,78,157,209,55,254,254,1,60,146,180,134,31,4,0,0 };
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


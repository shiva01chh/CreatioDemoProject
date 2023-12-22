namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysUserProfileRefreshServiceSchema

	/// <exclude/>
	public class SysUserProfileRefreshServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysUserProfileRefreshServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysUserProfileRefreshServiceSchema(SysUserProfileRefreshServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("803ab10e-c8ad-4b9b-b660-c988f5e60033");
			Name = "SysUserProfileRefreshService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b5578e4f-2732-4fb5-8de7-483c06c796b9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,77,111,218,64,20,60,59,82,254,195,138,94,140,132,252,3,18,245,0,52,85,83,137,6,65,170,30,80,14,139,61,134,85,237,93,119,223,154,198,66,249,239,125,235,15,192,73,227,150,131,197,206,206,155,247,102,252,44,180,204,65,133,140,33,30,97,173,36,147,186,104,110,116,170,118,165,149,78,25,125,125,117,188,190,10,74,82,122,39,214,21,57,228,183,175,206,209,26,246,160,98,44,76,130,108,240,50,250,129,237,48,97,26,59,117,168,251,158,121,231,193,184,156,135,203,243,247,111,191,56,87,68,211,45,57,43,99,175,66,195,50,93,243,149,41,29,115,152,204,244,15,22,59,46,21,243,76,18,221,248,49,191,19,236,210,154,84,101,88,33,181,160,125,91,87,243,55,159,144,202,50,115,23,90,120,242,120,11,112,156,245,56,13,70,197,27,222,148,138,111,112,60,81,193,206,183,42,83,174,90,225,87,169,44,114,104,71,225,229,193,199,36,62,138,127,148,120,86,212,2,201,216,55,41,202,109,166,98,17,123,79,131,150,196,141,152,73,194,201,96,112,172,77,158,82,89,192,237,77,194,185,44,107,197,230,114,243,80,160,89,151,75,179,193,134,147,190,215,7,243,19,97,83,198,147,143,150,15,235,199,209,68,248,233,64,238,179,177,185,116,140,51,117,1,34,185,67,3,69,95,201,232,137,152,153,164,90,187,42,67,143,114,66,163,153,180,152,248,94,193,138,247,152,95,56,134,21,235,48,186,52,122,139,222,189,150,86,70,180,177,204,75,107,57,82,159,87,56,22,199,186,149,179,85,251,47,240,56,203,104,212,235,22,189,45,186,215,169,9,199,183,127,101,175,249,21,158,153,115,222,161,210,226,68,246,187,236,227,196,51,127,146,13,141,43,136,184,114,51,234,43,141,158,216,111,31,106,69,44,88,83,11,141,223,131,110,187,166,47,34,150,46,222,139,240,238,57,70,225,137,2,157,235,255,214,66,39,86,63,253,227,165,221,33,232,164,89,163,250,220,160,125,144,177,139,223,31,207,186,83,99,159,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("803ab10e-c8ad-4b9b-b660-c988f5e60033"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,77,111,218,64,20,60,19,41,255,97,69,47,70,66,254,1,137,122,0,154,170,169,68,131,112,170,30,80,14,139,61,134,85,237,93,119,223,154,198,66,249,239,125,235,15,192,73,227,150,131,197,206,206,155,247,102,252,44,180,204,65,133,140,33,30,97,173,36,147,186,112,97,116,170,118,165,149,78,25,125,125,117,188,190,26,149,164,244,78,68,21,57,228,183,175,206,97,4,123,80,49,150,38,65,54,120,25,254,192,118,152,48,139,157,58,212,125,207,188,243,96,92,206,195,229,249,251,183,95,156,43,194,217,150,156,149,177,87,161,97,153,174,249,218,148,142,57,76,102,250,7,139,29,151,138,69,38,137,110,252,152,223,9,118,101,77,170,50,172,145,90,208,190,173,171,249,155,79,72,101,153,185,11,45,60,121,188,5,56,206,122,156,6,163,226,13,111,70,197,55,56,158,168,96,231,91,149,41,87,173,241,171,84,22,57,180,163,224,242,224,99,18,31,197,63,74,60,43,108,129,100,226,155,20,229,54,83,177,136,189,167,65,75,226,70,204,37,225,100,112,116,172,77,158,82,89,194,237,77,194,185,172,106,197,230,114,243,80,160,89,151,75,179,163,13,39,125,175,15,230,39,130,166,140,39,31,175,30,162,199,241,84,248,233,64,238,179,177,185,116,140,51,117,9,34,185,67,3,133,95,201,232,169,152,155,164,138,92,149,161,71,57,161,225,92,90,76,125,175,209,154,247,152,95,56,134,21,235,48,186,52,122,139,222,189,150,86,70,180,177,44,74,107,57,82,159,87,48,17,199,186,149,179,85,251,111,228,113,150,209,168,215,45,124,91,116,175,83,19,76,110,255,202,142,248,21,158,153,11,222,161,210,226,68,246,187,236,227,196,51,127,146,13,141,43,136,184,114,51,238,43,141,159,216,111,31,106,69,44,88,83,11,141,223,131,110,187,166,47,34,150,46,222,139,224,238,57,70,225,137,2,157,235,255,214,66,39,86,63,253,227,165,221,33,232,164,89,163,250,220,160,125,144,49,254,253,1,70,0,145,96,151,4,0,0 };
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


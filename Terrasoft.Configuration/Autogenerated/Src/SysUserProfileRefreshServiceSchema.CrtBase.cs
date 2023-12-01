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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,77,143,218,48,20,60,7,105,255,131,69,47,65,66,249,1,187,234,1,104,171,110,37,186,8,182,234,1,237,193,36,19,176,154,216,169,159,67,55,66,251,223,251,156,15,32,187,109,218,75,132,199,243,230,189,25,63,132,150,57,168,144,49,196,35,172,149,100,82,23,45,140,78,213,190,180,210,41,163,111,70,167,155,81,80,146,210,123,177,169,200,33,191,123,117,142,54,176,71,21,99,105,18,100,131,151,209,119,236,134,9,179,216,169,99,221,247,194,187,12,198,229,60,92,158,255,253,246,179,115,69,52,219,145,179,50,246,42,52,44,211,53,95,155,210,49,135,201,76,127,103,177,231,82,177,200,36,209,173,31,243,27,193,174,172,73,85,134,53,82,11,58,180,117,53,127,251,1,169,44,51,119,165,133,39,143,183,0,199,89,143,211,96,84,188,225,205,168,248,10,199,19,21,236,124,167,50,229,170,53,126,150,202,34,135,118,20,94,31,124,76,226,189,248,71,137,103,69,45,144,76,124,147,162,220,101,42,22,177,247,52,104,73,220,138,185,36,156,13,6,167,218,228,57,149,37,220,193,36,156,203,170,86,108,46,183,15,5,154,117,185,54,27,108,57,233,123,125,52,63,16,54,101,60,249,120,245,176,121,28,79,133,159,14,228,62,25,155,75,199,56,83,151,32,146,123,52,80,244,133,140,158,138,185,73,170,141,171,50,244,40,103,52,154,75,139,169,239,21,172,121,143,249,193,49,172,88,135,209,165,209,91,244,238,89,90,25,209,198,178,40,173,229,72,125,94,225,68,156,234,86,206,86,237,175,192,227,44,163,81,175,91,244,182,232,94,167,38,156,220,253,145,189,225,39,188,48,23,188,67,165,197,153,236,119,217,199,137,103,254,75,54,52,174,32,226,202,237,184,175,52,126,98,191,125,168,21,177,96,77,45,52,126,13,186,237,154,190,136,88,186,248,32,194,143,207,49,10,79,20,232,92,255,183,22,58,177,250,235,63,47,237,14,65,39,205,26,213,231,6,237,131,140,141,70,191,1,179,227,228,46,150,4,0,0 };
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


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StopEmailRequestSchema

	/// <exclude/>
	public class StopEmailRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StopEmailRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StopEmailRequestSchema(StopEmailRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3d11e55e-cb8c-465a-9cb7-dfaf13400a61");
			Name = "StopEmailRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,77,75,195,64,20,60,91,232,127,120,196,139,94,146,123,63,4,173,165,120,168,148,166,55,17,217,102,95,226,194,110,54,238,123,91,168,197,255,238,102,211,86,141,160,185,132,153,204,60,102,134,64,45,12,82,35,10,132,13,58,39,200,150,156,206,108,93,170,202,59,193,202,214,233,108,158,47,173,68,77,195,193,97,56,184,240,164,234,10,242,61,49,154,113,15,167,107,95,179,50,152,230,232,148,208,234,61,94,8,170,160,187,116,88,5,0,51,45,136,70,112,43,229,6,77,163,5,227,26,223,60,18,71,85,150,101,48,33,111,140,112,251,155,35,142,14,40,173,3,215,41,129,45,16,219,6,208,8,165,211,147,45,235,249,38,132,40,52,89,40,28,150,211,228,223,126,233,157,32,12,201,119,170,56,101,74,32,107,175,61,221,11,22,193,197,78,20,252,28,136,198,111,181,42,160,136,201,242,16,101,222,38,57,154,96,4,191,47,5,211,33,54,60,15,177,114,182,65,199,10,195,26,171,120,175,251,222,159,32,18,11,100,130,176,0,181,111,126,197,174,58,40,137,97,240,82,161,75,207,214,172,239,157,236,132,246,120,134,155,191,221,95,226,216,122,137,102,139,238,234,49,252,38,48,133,36,26,95,148,76,174,219,25,78,59,44,188,146,16,39,120,144,112,128,10,121,220,38,29,195,199,177,50,214,178,107,29,113,199,254,36,3,247,253,249,4,168,50,163,90,152,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3d11e55e-cb8c-465a-9cb7-dfaf13400a61"));
		}

		#endregion

	}

	#endregion

}


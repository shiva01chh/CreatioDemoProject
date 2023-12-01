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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,77,75,195,64,20,60,91,232,127,120,196,139,94,146,123,63,4,173,165,120,168,148,166,55,17,217,102,95,226,194,110,54,238,123,91,168,197,255,238,102,211,86,26,65,115,9,51,153,121,204,12,129,90,24,164,70,20,8,27,116,78,144,45,57,157,217,186,84,149,119,130,149,173,211,217,60,95,90,137,154,134,131,195,112,112,229,73,213,21,228,123,98,52,227,30,78,215,190,102,101,48,205,209,41,161,213,103,188,16,84,65,119,237,176,10,0,102,90,16,141,224,94,202,13,154,70,11,198,53,126,120,36,142,170,44,203,96,66,222,24,225,246,119,71,28,29,80,90,7,174,83,2,91,32,182,13,160,17,74,167,39,91,214,243,77,8,81,104,178,80,56,44,167,201,191,253,210,7,65,24,146,239,84,113,202,148,64,214,94,123,121,20,44,130,139,157,40,248,53,16,141,223,106,85,64,17,147,229,33,202,188,77,114,52,193,8,126,95,10,166,67,108,120,30,98,229,108,131,142,21,134,53,86,241,94,247,189,63,65,36,22,200,4,97,1,106,223,252,142,93,117,80,18,195,224,165,66,151,158,173,89,223,59,217,9,237,241,12,55,127,187,127,196,177,245,18,205,22,221,205,115,248,77,96,10,73,52,190,41,153,220,182,51,156,118,88,120,37,33,78,240,36,225,0,21,242,184,77,58,134,175,99,101,172,101,215,58,226,142,189,36,3,23,158,111,202,130,57,244,143,2,0,0 };
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


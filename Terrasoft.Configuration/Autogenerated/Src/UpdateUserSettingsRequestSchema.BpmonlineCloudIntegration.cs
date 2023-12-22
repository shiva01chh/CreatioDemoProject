namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateUserSettingsRequestSchema

	/// <exclude/>
	public class UpdateUserSettingsRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateUserSettingsRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateUserSettingsRequestSchema(UpdateUserSettingsRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83429a60-95f6-4bbb-baae-d29f929fc531");
			Name = "UpdateUserSettingsRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,77,79,194,64,16,134,207,146,240,31,38,112,80,47,237,157,15,19,4,163,137,193,16,62,226,193,120,24,202,0,27,218,110,221,153,197,32,241,191,187,221,2,42,34,74,15,77,102,118,222,167,243,190,221,20,19,226,12,35,130,33,25,131,172,167,18,180,117,58,85,51,107,80,148,78,131,246,205,160,171,39,20,115,185,180,46,151,202,165,51,203,42,157,193,96,197,66,73,208,183,169,168,132,130,1,25,133,177,122,243,154,186,159,171,26,154,185,2,218,49,50,215,96,148,77,80,104,196,100,6,36,226,16,220,167,23,75,44,126,56,12,67,104,176,77,18,52,171,171,77,237,133,48,213,6,76,49,9,162,193,122,12,96,20,105,247,233,115,6,235,136,192,27,100,176,69,133,123,172,6,19,97,204,26,34,67,211,102,229,79,179,193,53,50,57,83,75,21,209,102,207,10,132,57,237,169,131,130,78,37,6,35,121,118,141,204,142,99,21,65,228,183,253,213,37,212,224,39,210,169,139,76,119,97,245,140,206,200,136,34,151,88,207,131,139,243,253,124,124,227,150,132,65,123,247,12,50,39,120,165,49,204,181,94,0,102,153,147,122,79,48,209,9,170,52,216,81,194,125,76,99,137,177,165,93,57,252,55,232,83,231,67,233,82,50,38,115,241,224,174,20,52,161,226,24,119,14,209,202,178,142,23,86,46,243,180,182,113,177,152,252,26,61,238,13,193,26,102,36,245,220,82,29,222,79,241,142,214,189,221,101,220,44,187,160,213,105,150,143,234,143,59,205,165,247,180,58,104,176,85,156,29,242,85,165,116,82,252,118,95,23,221,239,77,223,251,242,124,0,90,165,33,177,175,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83429a60-95f6-4bbb-baae-d29f929fc531"));
		}

		#endregion

	}

	#endregion

}


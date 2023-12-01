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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,79,79,194,64,16,197,207,54,225,59,76,224,160,94,218,59,127,76,16,140,38,6,67,0,227,193,120,24,202,0,27,218,110,221,153,197,32,241,187,187,221,2,70,68,148,75,147,153,157,247,219,121,175,155,97,74,156,99,76,48,34,99,144,245,84,194,142,206,166,106,102,13,138,210,89,216,185,25,246,244,132,18,174,4,235,74,80,9,206,44,171,108,6,195,21,11,165,225,192,102,162,82,10,135,100,20,38,234,221,107,26,126,174,102,104,230,10,232,36,200,92,135,199,124,130,66,143,76,102,72,34,14,193,3,122,181,196,226,135,163,40,130,38,219,52,69,179,186,218,212,94,8,83,109,192,148,147,32,26,172,199,0,198,177,118,87,159,51,88,71,4,222,32,195,45,42,218,99,53,153,8,19,214,16,27,154,182,170,127,154,13,175,145,201,153,90,170,152,54,123,86,33,42,104,207,93,20,116,42,49,24,203,139,107,228,118,156,168,24,98,191,237,175,46,161,14,63,145,78,93,102,186,11,171,111,116,78,70,20,185,196,250,30,92,158,239,231,227,27,183,36,12,218,187,103,144,57,193,27,141,97,174,245,2,48,207,157,212,123,130,137,78,81,101,225,142,18,237,99,154,75,76,44,237,202,209,191,65,95,58,31,74,143,210,49,153,139,7,247,164,160,5,85,199,184,115,136,118,158,119,189,176,122,89,164,181,141,139,197,20,207,232,105,111,8,214,48,35,105,20,150,26,240,113,138,119,180,238,235,30,227,102,217,5,173,78,179,124,84,127,220,105,33,189,167,213,65,131,237,242,236,144,175,26,101,147,242,183,251,186,236,126,111,250,94,16,124,2,211,197,145,110,166,3,0,0 };
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


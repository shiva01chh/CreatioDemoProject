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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,79,79,194,64,16,197,207,146,240,29,38,112,80,47,237,157,63,38,8,70,19,131,33,128,241,96,60,12,237,0,27,218,110,221,153,197,32,241,187,187,221,2,70,68,148,30,154,204,236,188,95,231,189,110,134,41,113,142,17,193,152,140,65,214,83,9,186,58,155,170,153,53,40,74,103,65,247,102,212,215,49,37,92,173,172,171,149,106,229,204,178,202,102,48,90,177,80,26,12,109,38,42,165,96,68,70,97,162,222,189,166,233,231,234,134,102,174,128,110,130,204,13,120,204,99,20,122,100,50,35,18,113,8,30,210,171,37,22,63,28,134,33,180,216,166,41,154,213,213,166,246,66,152,106,3,166,156,4,209,96,61,6,48,138,180,251,244,57,131,117,68,224,13,50,216,162,194,61,86,139,137,48,97,13,145,161,105,187,246,167,217,224,26,153,156,169,165,138,104,179,103,13,194,130,246,220,67,65,167,18,131,145,188,184,70,110,39,137,138,32,242,219,254,234,18,26,240,19,233,212,101,166,187,176,6,70,231,100,68,145,75,108,224,193,229,249,126,62,190,113,75,194,160,189,123,6,153,19,188,209,4,230,90,47,0,243,220,73,189,39,136,117,138,42,11,118,148,112,31,211,90,98,98,105,87,142,255,13,250,210,249,80,250,148,78,200,92,60,184,43,5,109,168,57,198,157,67,116,242,188,231,133,181,203,34,173,109,92,44,166,184,70,79,123,67,176,134,25,73,179,176,212,132,143,83,188,163,117,111,119,25,55,203,46,104,117,154,229,163,250,227,78,11,233,61,173,14,26,236,148,103,135,124,213,41,139,203,223,238,235,178,251,189,233,123,238,249,4,56,20,99,45,167,3,0,0 };
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


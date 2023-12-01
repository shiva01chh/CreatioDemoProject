namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailHashDTOSchema

	/// <exclude/>
	public class EmailHashDTOSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailHashDTOSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailHashDTOSchema(EmailHashDTOSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d659f6d2-cdbc-4628-8188-da882d020fa0");
			Name = "EmailHashDTO";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,49,79,195,48,16,133,231,70,202,127,56,169,123,179,211,138,129,22,9,38,42,53,19,155,147,92,130,171,216,142,124,231,33,173,248,239,92,108,26,1,66,148,122,136,116,239,62,191,23,61,91,101,144,6,85,35,148,232,189,34,215,242,106,235,108,171,187,224,21,107,103,243,236,156,103,121,182,8,164,109,7,135,145,24,205,58,42,75,143,157,0,176,237,21,209,29,60,26,165,251,39,69,111,187,242,37,238,135,80,245,186,134,122,90,255,216,46,146,231,108,177,247,110,64,207,26,197,103,159,174,37,160,40,10,216,80,48,70,249,241,254,34,68,47,32,180,13,52,138,113,53,131,197,87,242,51,126,39,68,169,13,194,65,248,105,128,51,116,200,107,185,47,159,247,235,49,161,58,98,205,127,135,16,251,216,78,98,111,76,168,92,51,254,203,254,65,192,91,255,254,82,18,176,116,112,114,246,74,91,83,83,175,66,61,219,214,205,195,111,153,75,49,78,143,23,231,164,126,23,163,38,231,3,170,41,117,58,99,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d659f6d2-cdbc-4628-8188-da882d020fa0"));
		}

		#endregion

	}

	#endregion

}


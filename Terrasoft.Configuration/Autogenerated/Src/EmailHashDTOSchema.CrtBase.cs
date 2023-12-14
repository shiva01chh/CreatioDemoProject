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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,49,79,195,48,16,133,231,70,202,127,56,169,123,179,211,138,129,22,9,38,42,53,19,219,37,185,4,87,177,29,249,236,33,173,248,239,92,108,26,1,66,148,122,136,116,239,62,191,23,61,27,212,196,3,214,4,37,57,135,108,91,191,218,90,211,170,46,56,244,202,154,60,59,231,89,158,45,2,43,211,193,97,100,79,122,29,149,165,163,78,0,216,246,200,124,7,143,26,85,255,132,252,182,43,95,226,126,8,85,175,106,168,167,245,143,237,34,121,206,22,123,103,7,114,94,145,248,236,211,181,4,20,69,1,27,14,90,163,27,239,47,66,244,2,38,211,64,131,158,86,51,88,124,37,63,227,119,66,148,74,19,28,132,159,6,56,67,71,126,45,247,229,243,126,61,38,84,71,170,253,223,33,236,93,108,39,177,55,38,84,182,25,255,101,255,32,224,173,127,127,41,9,188,116,112,178,230,74,91,83,83,175,66,61,155,214,206,195,111,153,75,49,78,143,23,231,164,126,23,163,54,157,15,76,57,238,4,100,2,0,0 };
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


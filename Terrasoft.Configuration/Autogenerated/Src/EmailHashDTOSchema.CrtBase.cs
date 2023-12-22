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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,49,79,195,48,16,133,231,70,202,127,56,169,123,179,83,196,64,139,4,83,43,53,19,219,37,185,4,163,216,142,124,246,144,86,252,119,46,54,141,10,66,148,122,136,116,239,62,191,23,61,27,212,196,3,214,4,37,57,135,108,91,191,218,88,211,170,46,56,244,202,154,60,59,229,89,158,45,2,43,211,193,97,100,79,122,29,149,165,163,78,0,216,244,200,124,7,79,26,85,255,140,252,182,45,119,113,63,132,170,87,53,212,211,250,199,118,145,60,103,139,189,179,3,57,175,72,124,246,233,90,2,138,162,128,123,14,90,163,27,31,206,66,244,2,38,211,64,131,158,86,51,88,92,146,95,241,91,33,74,165,9,14,194,79,3,156,160,35,191,150,251,242,249,184,30,19,170,119,170,253,223,33,236,93,108,39,177,55,38,84,182,25,255,101,255,40,224,173,127,127,46,9,188,116,112,180,230,74,91,83,83,175,66,189,152,214,206,195,111,153,75,49,78,143,23,231,164,126,23,163,118,121,62,1,31,40,174,89,108,2,0,0 };
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


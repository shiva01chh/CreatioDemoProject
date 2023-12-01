namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CheckedEmailResponseSchema

	/// <exclude/>
	public class CheckedEmailResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CheckedEmailResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CheckedEmailResponseSchema(CheckedEmailResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3507f4f-1914-4114-8a7c-cc67545f380a");
			Name = "CheckedEmailResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,77,79,194,64,16,134,207,146,240,31,38,120,209,75,123,23,228,82,9,241,128,33,224,205,120,88,150,161,108,220,143,102,102,247,128,196,255,238,116,91,16,73,180,183,125,247,121,103,158,182,94,57,228,70,105,132,87,36,82,28,118,177,168,130,223,153,58,145,138,38,248,162,154,173,87,130,4,207,200,195,193,113,56,184,73,108,124,13,235,3,71,116,2,91,139,186,37,185,152,163,71,50,122,124,205,172,146,143,198,97,177,150,91,101,205,103,30,252,67,253,179,121,17,182,104,89,80,129,111,9,107,137,161,178,138,249,1,170,61,234,15,220,206,156,50,246,36,152,185,178,44,97,194,201,57,69,135,105,127,94,97,67,200,232,35,67,220,35,232,174,11,216,150,129,250,54,236,40,56,144,173,197,105,74,121,49,230,237,73,69,37,130,145,148,142,239,18,52,105,99,141,6,221,234,252,97,115,115,204,70,103,245,37,133,6,41,26,20,255,101,174,119,247,215,202,57,152,163,216,6,2,198,222,90,60,147,141,197,185,112,105,215,233,45,208,109,144,238,94,228,167,194,35,140,186,194,232,190,181,61,233,62,207,124,114,72,106,99,113,114,41,61,149,111,212,210,112,132,26,227,184,221,58,134,175,94,31,253,182,123,131,124,238,210,223,97,206,228,249,6,204,241,39,128,80,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3507f4f-1914-4114-8a7c-cc67545f380a"));
		}

		#endregion

	}

	#endregion

}


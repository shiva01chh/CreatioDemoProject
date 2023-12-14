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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,77,79,194,64,16,134,207,146,240,31,38,120,209,75,123,23,228,82,9,241,128,33,224,205,120,88,150,161,108,220,143,102,102,247,128,196,255,238,108,91,16,73,180,183,125,247,121,103,158,182,94,57,228,70,105,132,87,36,82,28,118,177,168,130,223,153,58,145,138,38,248,162,154,173,87,130,4,207,200,195,193,113,56,184,73,108,124,13,235,3,71,116,2,91,139,58,147,92,204,209,35,25,61,190,102,86,201,71,227,176,88,203,173,178,230,179,29,252,67,253,179,121,17,182,104,89,80,129,111,9,107,137,161,178,138,249,1,170,61,234,15,220,206,156,50,246,36,216,114,101,89,194,132,147,115,138,14,211,254,188,194,134,144,209,71,134,184,71,208,93,23,48,151,129,250,54,236,40,56,144,173,197,105,74,121,49,230,237,73,69,37,130,145,148,142,239,18,52,105,99,141,6,157,117,254,176,185,57,182,70,103,245,37,133,6,41,26,20,255,101,91,239,238,175,149,219,96,142,98,27,8,24,123,107,241,76,54,22,231,194,165,93,167,183,64,183,65,186,123,145,159,10,143,48,234,10,163,251,108,123,210,125,158,249,228,144,212,198,226,228,82,122,42,223,40,211,112,132,26,227,56,111,29,195,87,175,143,126,219,189,65,123,238,210,223,97,155,229,231,27,249,175,133,160,81,2,0,0 };
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


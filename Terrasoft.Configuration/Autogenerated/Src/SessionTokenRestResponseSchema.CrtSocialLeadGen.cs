namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SessionTokenRestResponseSchema

	/// <exclude/>
	public class SessionTokenRestResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SessionTokenRestResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SessionTokenRestResponseSchema(SessionTokenRestResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6e3a15ec-b9d8-c38d-ff2f-9dd9e4d205ff");
			Name = "SessionTokenRestResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,143,193,106,195,48,12,134,207,13,228,29,4,187,39,247,117,236,146,193,46,131,150,37,47,224,38,74,102,150,72,65,178,59,70,217,187,207,177,211,173,237,152,65,6,253,18,191,190,159,204,132,58,155,22,161,65,17,163,220,187,162,98,234,237,224,197,56,203,84,212,220,90,51,190,160,233,158,145,242,236,148,103,121,182,185,19,28,194,16,170,209,168,222,67,141,170,161,109,248,29,233,21,213,133,154,153,20,227,110,89,150,240,160,126,154,140,124,62,174,125,53,178,239,64,214,53,120,106,118,240,97,221,27,88,234,89,166,120,24,204,129,189,3,77,214,224,22,239,226,108,87,94,248,205,254,48,218,22,218,5,229,95,18,8,144,151,65,150,217,94,248,104,59,148,95,218,77,74,247,19,47,108,204,40,206,98,200,184,143,103,210,252,54,82,20,234,91,210,191,168,103,86,117,98,105,184,130,133,19,12,232,182,33,111,248,190,86,12,164,46,145,196,62,169,215,98,212,194,251,6,35,97,82,133,200,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6e3a15ec-b9d8-c38d-ff2f-9dd9e4d205ff"));
		}

		#endregion

	}

	#endregion

}


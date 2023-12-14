namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidationResponseSchema

	/// <exclude/>
	public class ValidationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidationResponseSchema(ValidationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95fa2455-4082-4b76-99b1-0a45dbb30c9d");
			Name = "ValidationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,77,107,195,48,12,134,207,13,228,63,8,122,79,238,219,216,165,215,30,74,91,118,119,20,197,53,115,172,32,217,131,181,236,191,207,113,218,82,198,168,15,70,31,214,251,62,86,48,35,233,100,144,224,72,34,70,121,136,205,134,195,224,108,18,19,29,135,186,186,212,85,93,173,218,182,133,55,77,227,104,228,251,253,154,239,105,18,82,10,81,33,158,8,114,156,124,4,30,0,79,132,159,46,88,248,50,222,245,69,7,36,121,106,110,66,237,131,210,148,58,239,16,208,27,85,248,184,15,236,51,23,7,165,252,98,33,88,173,133,236,172,180,19,158,72,162,35,125,129,93,25,94,250,127,17,175,140,51,84,115,239,63,58,223,172,59,102,15,135,132,72,153,224,2,150,226,43,232,124,253,60,17,222,50,102,214,179,233,60,65,222,161,26,75,128,220,211,115,43,141,50,239,101,139,231,67,137,54,121,226,63,203,53,133,126,249,110,201,115,181,52,242,249,5,196,40,173,221,178,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95fa2455-4082-4b76-99b1-0a45dbb30c9d"));
		}

		#endregion

	}

	#endregion

}


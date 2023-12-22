namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailStateRequestSchema

	/// <exclude/>
	public class EmailStateRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailStateRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailStateRequestSchema(EmailStateRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e71e3e74-ee53-49b0-8b08-eff380e4bbfa");
			Name = "EmailStateRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,146,193,78,195,48,12,134,207,157,196,59,88,227,2,151,246,206,128,29,198,52,237,0,154,214,221,16,135,172,117,187,136,54,41,142,139,52,38,222,29,55,217,166,109,2,132,64,244,210,216,177,127,125,191,99,163,106,116,141,202,16,22,72,164,156,45,56,30,89,83,232,178,37,197,218,154,179,222,230,172,23,181,78,155,18,210,181,99,172,7,39,113,60,111,13,235,26,227,20,73,171,74,191,249,62,169,146,186,115,194,82,2,24,85,202,185,43,24,215,74,87,41,43,198,57,190,180,232,216,23,37,73,2,215,174,173,107,69,235,219,109,60,199,134,208,161,97,7,20,74,193,22,192,43,4,236,52,192,117,34,224,144,94,117,134,241,78,36,57,80,121,188,83,172,196,10,147,202,248,73,18,77,187,172,116,6,89,135,242,25,73,180,241,52,123,230,25,217,6,137,53,10,248,204,247,134,251,83,92,159,152,160,144,90,18,34,249,7,196,105,14,108,33,91,97,246,28,239,251,14,9,3,226,61,214,75,164,139,7,121,8,184,129,190,239,157,230,253,203,14,121,199,60,105,117,62,12,204,162,218,61,72,20,149,200,3,127,112,219,195,251,79,241,100,118,196,144,119,3,220,206,84,124,106,155,67,225,43,12,7,3,238,55,248,94,91,242,120,108,160,203,44,100,71,134,144,238,10,254,108,3,77,254,79,38,68,249,59,11,227,112,253,165,1,216,238,145,200,132,85,242,113,240,117,156,244,185,195,239,3,132,158,240,53,143,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e71e3e74-ee53-49b0-8b08-eff380e4bbfa"));
		}

		#endregion

	}

	#endregion

}


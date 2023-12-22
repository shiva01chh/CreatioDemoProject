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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,77,111,194,48,12,134,207,84,234,127,176,196,189,189,111,211,46,92,57,32,64,187,167,174,27,162,165,113,101,39,72,128,246,223,151,182,128,170,105,34,135,200,31,241,251,62,113,48,61,233,96,144,224,72,34,70,185,139,213,134,67,231,108,18,19,29,135,178,184,149,69,89,172,234,186,134,15,77,125,111,228,242,121,207,247,52,8,41,133,168,16,79,4,57,78,62,2,119,128,39,194,111,23,44,156,141,119,237,164,3,146,60,85,15,161,122,161,52,164,198,59,4,244,70,21,190,158,3,251,204,197,65,41,191,152,9,86,107,33,59,42,237,132,7,146,232,72,223,96,55,13,207,253,191,136,119,198,17,170,122,246,151,206,15,235,134,217,195,33,33,82,38,184,129,165,248,14,58,94,63,47,132,183,140,153,245,106,26,79,144,119,168,198,18,32,183,244,218,74,163,140,123,217,226,245,48,69,155,60,241,159,229,154,66,59,127,119,202,115,117,106,44,206,47,224,68,240,21,186,1,0,0 };
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


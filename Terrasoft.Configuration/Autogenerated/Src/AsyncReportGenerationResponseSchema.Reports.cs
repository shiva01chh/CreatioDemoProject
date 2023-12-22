namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AsyncReportGenerationResponseSchema

	/// <exclude/>
	public class AsyncReportGenerationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AsyncReportGenerationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AsyncReportGenerationResponseSchema(AsyncReportGenerationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("59415005-e6b4-4fec-b04e-4cda4c279496");
			Name = "AsyncReportGenerationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,193,106,195,48,16,68,207,9,228,31,22,122,183,239,113,8,148,28,76,160,135,144,228,7,84,121,237,46,181,37,179,187,46,24,211,127,175,36,167,110,146,67,117,17,59,122,59,154,113,166,67,233,141,69,184,34,179,17,95,107,118,240,174,166,102,96,163,228,221,102,61,109,214,171,65,200,53,112,25,69,177,43,158,230,192,183,45,218,8,75,86,162,67,38,27,152,64,189,48,54,65,133,67,107,68,182,240,42,163,179,103,236,61,107,194,146,255,57,124,31,22,49,45,244,195,123,75,22,108,228,255,199,97,11,15,49,47,200,95,100,241,207,109,53,37,199,37,195,137,125,143,172,132,33,200,41,125,51,191,231,121,14,59,25,186,206,240,184,255,21,74,84,1,207,32,241,214,15,4,187,84,4,95,3,85,232,148,106,66,150,56,114,202,8,205,18,18,212,200,167,100,139,125,126,239,127,235,120,124,35,209,93,57,80,181,135,231,146,215,176,126,172,4,166,224,169,69,76,81,192,247,173,14,186,106,110,148,230,89,125,20,131,118,127,126,0,86,128,117,42,226,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("59415005-e6b4-4fec-b04e-4cda4c279496"));
		}

		#endregion

	}

	#endregion

}


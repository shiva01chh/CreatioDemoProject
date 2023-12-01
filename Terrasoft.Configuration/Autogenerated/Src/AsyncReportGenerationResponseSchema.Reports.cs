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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,193,106,195,48,16,68,207,9,228,31,22,122,183,239,113,8,148,28,76,32,135,144,228,7,84,121,237,46,181,37,179,43,21,140,233,191,119,45,167,110,147,67,117,17,59,122,59,154,113,166,67,233,141,69,184,33,179,17,95,135,236,224,93,77,77,100,19,200,187,205,122,220,172,87,81,200,53,112,29,36,96,87,60,205,202,183,45,218,9,150,172,68,135,76,86,25,165,94,24,27,85,225,208,26,145,45,188,202,224,236,5,123,207,33,97,201,255,162,223,235,34,166,133,62,190,181,100,193,78,252,255,56,108,225,33,230,21,249,147,44,254,186,173,198,228,184,100,56,179,239,145,3,161,6,57,167,111,230,247,60,207,97,39,177,235,12,15,251,31,161,196,32,224,25,100,186,195,59,130,93,42,130,175,129,42,116,129,106,66,150,105,228,148,17,154,37,36,4,35,31,146,45,246,249,95,255,123,199,227,137,36,236,202,72,213,30,158,75,222,116,253,88,9,140,234,25,138,41,69,1,95,247,58,232,170,185,81,154,103,245,81,84,77,207,55,178,193,205,164,217,1,0,0 };
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


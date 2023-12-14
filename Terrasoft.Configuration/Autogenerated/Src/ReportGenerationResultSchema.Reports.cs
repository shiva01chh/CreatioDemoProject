namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportGenerationResultSchema

	/// <exclude/>
	public class ReportGenerationResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportGenerationResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportGenerationResultSchema(ReportGenerationResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0ee0c217-8753-49b8-84d4-5d609fc7ae8a");
			Name = "ReportGenerationResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,80,187,106,195,48,20,157,21,200,63,92,200,226,64,201,7,196,100,202,80,58,180,13,118,183,144,65,118,111,28,129,45,153,171,107,138,107,250,239,149,44,211,90,38,93,170,77,71,231,165,163,101,131,182,149,37,194,27,18,73,107,174,188,59,26,125,85,85,71,146,149,209,235,213,176,94,137,206,42,93,65,222,91,198,38,93,220,119,79,175,14,114,224,134,176,114,10,56,214,210,218,61,100,216,26,226,71,212,24,156,50,180,93,205,35,243,156,35,41,89,171,79,89,212,120,113,64,219,21,181,42,161,244,202,63,133,98,24,197,191,57,70,91,166,174,100,67,46,238,52,90,4,198,100,119,223,40,113,34,223,158,198,215,23,55,192,3,20,61,227,249,50,65,206,151,81,243,214,59,137,61,240,77,217,100,78,214,248,1,207,216,24,234,115,38,148,77,18,203,182,224,23,19,95,255,172,18,60,23,85,130,165,200,126,120,112,152,137,210,217,227,36,63,196,6,233,172,209,6,245,123,88,48,158,243,68,166,69,98,133,247,199,156,170,206,42,12,80,33,167,16,127,116,202,143,202,196,196,69,126,64,99,208,97,254,124,3,225,255,19,225,157,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0ee0c217-8753-49b8-84d4-5d609fc7ae8a"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,80,187,106,195,48,20,157,21,200,63,92,200,226,64,201,7,196,100,202,80,58,180,13,118,183,144,65,118,111,28,129,44,153,171,107,138,107,250,239,149,45,211,90,38,93,170,77,71,231,165,99,100,141,174,145,37,194,27,18,73,103,175,188,59,90,115,85,85,75,146,149,53,235,85,191,94,137,214,41,83,65,222,57,198,58,93,220,119,79,175,30,242,224,134,176,242,10,56,106,233,220,30,50,108,44,241,35,26,12,78,25,186,86,243,200,60,231,72,74,106,245,41,11,141,23,15,52,109,161,85,9,229,160,252,83,40,250,81,252,155,99,141,99,106,75,182,228,227,78,163,69,96,76,118,247,141,18,47,26,218,211,248,250,226,7,120,128,162,99,60,95,38,200,251,50,26,222,14,78,98,15,124,83,46,153,147,13,126,192,51,214,150,186,156,9,101,157,196,178,45,12,139,137,175,127,86,9,158,139,42,193,82,100,63,60,56,204,68,233,236,113,146,31,98,131,116,214,104,131,230,61,44,24,207,121,34,219,32,177,194,251,99,78,85,103,21,122,168,144,83,136,63,58,229,71,101,98,226,34,63,160,49,232,49,127,190,1,103,137,13,18,156,2,0,0 };
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


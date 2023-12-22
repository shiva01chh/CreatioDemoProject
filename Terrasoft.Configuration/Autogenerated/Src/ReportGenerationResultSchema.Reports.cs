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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,80,187,106,195,48,20,157,29,200,63,92,200,226,64,201,7,196,100,202,80,58,180,13,118,183,144,65,118,111,28,129,44,153,171,107,138,107,250,239,149,45,211,74,38,93,170,77,71,231,165,163,69,131,182,21,21,194,27,18,9,107,174,188,59,26,125,149,117,71,130,165,209,235,213,176,94,37,157,149,186,134,162,183,140,77,182,184,239,158,94,29,228,192,13,97,237,20,112,84,194,218,61,228,216,26,226,71,212,232,157,114,180,157,226,137,121,46,144,164,80,242,83,148,10,47,14,104,187,82,201,10,170,81,249,167,48,25,38,241,111,142,209,150,169,171,216,144,139,59,77,22,158,49,219,221,55,74,157,104,108,79,211,235,139,27,224,1,202,158,241,124,153,33,231,203,168,121,59,58,37,123,224,155,180,105,72,214,248,1,207,216,24,234,11,38,20,77,26,203,182,48,46,150,124,253,179,138,247,92,84,241,150,73,254,195,131,67,32,202,130,199,89,126,136,13,178,160,209,6,245,187,95,48,158,243,68,166,69,98,137,247,199,156,171,6,21,6,168,145,51,136,63,58,231,71,101,98,226,34,223,163,49,232,176,240,124,3,155,50,19,142,165,2,0,0 };
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


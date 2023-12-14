namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DocumentConstsSchema

	/// <exclude/>
	public class DocumentConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DocumentConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DocumentConstsSchema(DocumentConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c6fbe5f3-8af5-45bb-b253-d7c21e1e0cb2");
			Name = "DocumentConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,144,193,106,196,32,16,134,207,27,200,59,200,158,218,131,69,141,154,200,210,131,49,73,233,169,135,246,5,172,113,151,64,162,139,26,202,82,250,238,117,219,91,122,104,161,50,115,152,225,155,239,7,157,94,108,60,107,99,193,139,13,65,71,127,76,119,202,187,227,116,90,131,78,147,119,101,241,94,22,187,53,78,238,4,158,47,49,217,229,144,231,93,238,243,250,58,79,6,196,148,57,3,204,172,99,4,157,55,235,98,93,202,138,152,98,134,174,199,27,50,88,61,122,55,95,192,195,58,141,32,147,41,104,147,30,71,112,15,156,125,251,218,222,236,43,209,146,134,19,10,69,211,115,216,13,24,67,81,227,22,34,132,59,142,122,81,53,138,239,111,15,191,217,229,15,49,199,67,45,89,93,65,70,254,35,86,62,132,252,113,222,141,214,25,187,201,32,170,101,74,42,12,49,35,21,236,81,206,144,130,202,107,6,99,29,162,21,65,244,15,25,79,97,180,97,163,110,218,86,12,76,169,44,68,61,164,117,61,64,65,21,131,156,200,78,160,174,231,74,201,111,245,71,89,228,186,190,79,39,253,153,162,228,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c6fbe5f3-8af5-45bb-b253-d7c21e1e0cb2"));
		}

		#endregion

	}

	#endregion

}


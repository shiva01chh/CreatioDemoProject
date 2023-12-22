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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,144,193,106,196,32,16,134,207,27,216,119,144,61,181,7,139,26,53,145,165,7,99,146,210,83,15,237,11,88,227,46,129,68,23,53,148,165,244,221,235,182,151,146,30,90,88,153,57,204,240,205,247,131,78,207,54,158,180,177,224,197,134,160,163,63,164,59,229,221,97,60,46,65,167,209,187,109,241,190,45,54,75,28,221,17,60,159,99,178,243,62,207,155,220,167,229,117,26,13,136,41,115,6,152,73,199,8,90,111,150,217,186,148,21,49,197,12,93,142,87,100,176,122,240,110,58,131,135,101,28,64,38,83,208,38,61,14,224,30,56,251,246,181,189,217,149,162,33,53,39,20,138,186,227,176,237,49,134,162,194,13,68,8,183,28,117,162,172,21,223,221,238,255,178,203,95,98,142,251,74,178,170,132,140,92,35,86,62,132,252,113,222,13,214,25,187,202,32,170,97,74,42,12,49,35,37,236,80,206,144,130,202,75,6,99,45,162,37,65,244,31,25,79,97,176,97,165,174,155,70,244,76,169,44,68,29,164,85,213,67,65,21,131,156,200,86,160,182,227,74,201,111,245,199,182,200,245,243,125,2,37,120,61,5,236,1,0,0 };
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


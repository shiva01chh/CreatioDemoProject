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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,144,193,106,196,32,16,134,207,27,200,59,200,158,218,131,69,77,52,145,165,7,163,73,233,169,135,246,5,172,113,151,64,162,139,26,202,82,250,238,117,219,91,122,104,161,50,115,152,225,155,239,7,157,94,108,60,107,99,193,139,13,65,71,127,76,119,210,187,227,116,90,131,78,147,119,101,241,94,22,187,53,78,238,4,158,47,49,217,229,144,231,93,238,243,250,58,79,6,196,148,57,3,204,172,99,4,202,155,117,177,46,101,69,76,49,67,215,227,13,25,172,30,189,155,47,224,97,157,70,144,201,20,180,73,143,35,184,7,206,190,125,109,111,246,21,239,72,203,72,13,121,219,51,168,6,140,33,111,112,7,17,194,138,161,158,87,173,100,251,219,195,111,118,241,67,204,240,208,8,218,84,144,146,255,136,165,15,33,127,156,119,163,117,198,110,50,136,236,168,20,18,67,76,73,5,123,148,51,4,175,197,53,131,82,133,234,138,160,250,15,25,79,97,180,97,163,110,187,142,15,84,202,44,68,61,172,155,102,128,188,150,20,50,34,20,71,170,103,82,138,111,245,71,89,228,202,239,19,15,37,230,241,227,1,0,0 };
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


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeleteRelationshipEntityAsyncOperationSchema

	/// <exclude/>
	public class DeleteRelationshipEntityAsyncOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeleteRelationshipEntityAsyncOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeleteRelationshipEntityAsyncOperationSchema(DeleteRelationshipEntityAsyncOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2810347f-8d41-bc89-5b74-bf02880df2b3");
			Name = "DeleteRelationshipEntityAsyncOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ac9dec01-f305-4a8c-bd6f-7a943e292d3e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,221,106,194,48,20,190,174,224,59,4,119,83,65,242,0,186,13,58,117,163,23,178,33,219,3,100,233,49,6,106,82,206,73,220,138,236,221,151,38,34,86,40,108,189,74,190,156,239,231,156,83,35,14,64,141,144,192,222,1,81,144,221,57,190,180,102,167,149,71,225,180,53,124,11,117,60,208,94,55,43,32,173,12,224,120,116,26,143,50,79,218,168,30,15,97,49,128,243,181,113,218,105,32,94,80,107,228,107,3,73,158,254,77,224,165,113,128,187,16,121,152,251,44,164,179,168,99,69,168,185,67,80,129,202,150,181,32,154,179,21,212,224,224,186,175,232,213,246,141,34,179,241,159,181,150,76,118,196,63,242,216,156,149,9,95,31,193,184,91,209,236,20,133,47,153,54,224,246,182,10,169,222,162,85,122,60,219,30,173,174,216,250,27,164,119,144,127,16,96,216,140,1,25,93,124,239,58,99,131,150,5,42,98,2,149,63,132,39,154,178,110,115,89,118,20,200,240,122,179,90,40,20,135,141,48,66,1,178,135,52,171,52,199,150,191,128,187,47,183,131,229,143,121,212,204,12,124,177,144,137,28,250,142,87,156,77,243,73,63,236,100,118,147,126,58,93,68,129,225,64,60,205,62,53,249,212,110,65,90,172,202,42,191,244,149,126,151,182,172,146,212,207,121,200,96,170,52,231,120,79,232,53,24,145,238,251,5,13,110,179,255,8,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2810347f-8d41-bc89-5b74-bf02880df2b3"));
		}

		#endregion

	}

	#endregion

}


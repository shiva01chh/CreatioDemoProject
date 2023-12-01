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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,221,106,194,48,20,190,174,224,59,4,119,83,65,242,0,186,13,156,118,163,23,178,81,182,7,200,210,99,12,212,164,156,147,184,21,217,187,47,38,34,86,40,108,189,74,190,156,239,231,156,83,35,246,64,173,144,192,222,1,81,144,221,58,190,178,102,171,149,71,225,180,53,188,130,38,30,104,167,219,53,144,86,6,112,60,58,142,71,153,39,109,84,143,135,176,24,192,121,97,156,118,26,136,47,169,51,242,181,133,36,79,255,38,240,210,56,192,109,136,60,204,125,22,210,89,212,177,34,212,220,33,168,64,101,171,70,16,205,217,26,26,112,112,221,87,244,234,250,70,145,217,250,207,70,75,38,79,196,63,242,216,156,149,9,47,14,96,220,173,104,118,140,194,151,76,27,112,59,91,135,84,111,209,42,61,158,109,15,86,215,172,248,6,233,29,228,31,4,24,54,99,64,70,23,223,187,206,216,160,229,18,21,49,129,202,239,195,19,77,217,105,115,89,118,16,200,240,122,179,90,40,20,251,141,48,66,1,178,135,52,171,52,199,142,191,128,187,47,171,193,242,199,60,106,102,6,190,88,200,68,14,253,137,183,60,155,230,147,126,216,201,236,38,253,116,186,136,2,195,129,120,154,125,106,242,169,171,64,90,172,203,58,191,244,149,126,151,174,172,147,212,207,121,200,96,234,52,231,120,79,232,53,24,145,240,253,2,245,13,110,179,7,3,0,0 };
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


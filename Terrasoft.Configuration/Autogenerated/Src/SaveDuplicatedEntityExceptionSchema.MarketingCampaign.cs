namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SaveDuplicatedEntityExceptionSchema

	/// <exclude/>
	public class SaveDuplicatedEntityExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SaveDuplicatedEntityExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SaveDuplicatedEntityExceptionSchema(SaveDuplicatedEntityExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b337a224-56ad-46fe-b05d-92c5ffd63b6b");
			Name = "SaveDuplicatedEntityException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,81,61,111,194,64,12,157,131,196,127,176,232,210,46,201,78,41,11,101,232,80,169,18,252,1,147,56,225,84,114,23,157,157,166,41,234,127,175,239,18,62,202,192,109,247,228,247,225,103,139,53,113,131,57,193,150,188,71,118,165,164,43,103,75,83,181,30,197,56,155,190,163,255,36,49,182,90,97,221,160,169,236,116,114,156,78,146,150,21,130,77,207,66,245,243,116,162,200,131,167,74,9,176,58,32,243,28,54,248,69,175,109,115,48,57,10,21,107,43,70,250,245,119,78,77,80,141,132,44,203,96,193,109,93,163,239,151,227,255,60,1,178,247,174,99,232,246,100,161,56,233,0,69,29,16,223,7,123,113,96,44,147,151,244,36,151,93,233,53,237,78,89,144,135,60,247,227,192,28,174,162,37,199,24,239,178,144,179,44,190,205,197,121,221,235,35,170,14,19,183,27,68,224,205,26,49,120,48,63,196,128,96,169,11,25,5,173,118,236,74,93,139,198,214,210,139,253,16,177,51,178,87,6,55,148,155,210,80,1,122,17,231,65,15,196,88,81,122,54,204,110,29,23,13,122,172,193,234,45,95,102,227,248,108,185,85,167,241,163,174,40,80,16,231,222,236,52,86,8,17,197,211,69,22,185,81,106,236,235,110,83,143,218,68,104,126,20,126,10,188,36,153,195,14,153,30,79,32,28,225,119,172,144,108,49,180,24,255,3,250,31,84,76,223,31,101,20,2,219,136,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b337a224-56ad-46fe-b05d-92c5ffd63b6b"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IChildImportEntitiesGetterSchema

	/// <exclude/>
	public class IChildImportEntitiesGetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IChildImportEntitiesGetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IChildImportEntitiesGetterSchema(IChildImportEntitiesGetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("62efa7fa-c711-4c24-a8e7-b07f25c59080");
			Name = "IChildImportEntitiesGetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,144,193,110,195,32,12,64,207,141,148,127,64,61,109,23,248,128,101,185,68,93,149,219,164,237,7,40,115,58,75,224,68,54,28,162,105,255,62,72,150,180,27,226,0,246,179,31,134,108,0,153,172,3,245,14,204,86,198,33,234,110,164,1,175,137,109,196,145,244,11,122,232,195,52,114,172,171,175,186,58,36,65,186,170,183,89,34,132,140,122,15,174,112,162,207,64,192,232,158,118,230,190,35,131,62,81,196,136,32,25,200,200,148,46,30,157,66,138,192,67,241,247,221,39,250,143,213,180,161,103,136,57,157,233,34,62,24,99,84,35,41,4,203,115,187,5,50,34,202,149,82,5,191,85,122,135,205,127,186,153,44,219,160,40,79,253,124,92,206,144,5,114,108,87,175,186,133,116,99,150,203,173,148,33,38,38,105,187,191,178,198,108,137,66,246,39,74,1,216,94,60,52,203,20,115,91,158,248,176,246,127,221,219,223,153,30,203,143,125,215,85,222,101,253,0,135,108,220,27,146,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("62efa7fa-c711-4c24-a8e7-b07f25c59080"));
		}

		#endregion

	}

	#endregion

}


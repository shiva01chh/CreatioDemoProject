namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FolderConstsSchema

	/// <exclude/>
	public class FolderConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FolderConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FolderConstsSchema(FolderConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("76859cd8-136b-4004-a6d6-9dceeb8425ee");
			Name = "FolderConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,93,79,131,48,20,134,175,33,225,63,156,108,55,122,81,104,157,76,136,31,201,86,192,120,225,149,251,3,29,116,75,19,104,73,11,81,98,252,239,118,200,24,186,152,232,201,185,56,237,249,120,159,188,173,17,114,15,47,157,105,120,117,235,185,158,43,89,197,77,205,114,14,27,174,53,51,106,215,248,84,201,157,216,183,154,53,66,73,240,220,247,195,160,19,4,1,220,153,182,170,152,238,30,134,247,124,136,177,152,214,240,253,255,108,112,238,31,175,6,147,179,117,187,45,69,14,166,177,234,57,228,37,51,6,50,85,22,92,91,44,211,24,203,227,88,32,231,140,231,8,52,72,0,58,129,164,168,98,162,244,199,173,169,222,15,65,205,89,161,100,217,193,99,43,10,72,15,123,95,234,155,174,230,79,5,220,131,228,175,125,243,98,182,142,111,86,97,180,88,34,66,19,140,82,66,8,138,49,93,34,140,73,24,38,56,188,166,120,49,187,236,109,254,51,238,201,32,24,61,250,39,244,179,101,222,170,183,95,177,227,152,94,45,66,66,81,134,179,104,192,78,214,171,17,155,68,152,244,216,206,135,231,218,156,198,39,149,77,92,220,64,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("76859cd8-136b-4004-a6d6-9dceeb8425ee"));
		}

		#endregion

	}

	#endregion

}


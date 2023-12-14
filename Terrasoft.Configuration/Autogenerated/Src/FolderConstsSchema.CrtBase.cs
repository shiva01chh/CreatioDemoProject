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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,203,78,132,48,20,134,215,144,240,14,39,51,27,93,20,90,145,17,226,37,153,225,98,92,184,114,94,160,3,157,73,19,104,73,11,81,98,124,119,11,50,12,58,49,209,147,179,56,237,185,252,95,254,86,115,113,128,151,78,55,172,186,117,108,199,22,180,98,186,166,57,131,45,83,138,106,185,111,220,88,138,61,63,180,138,54,92,10,112,236,247,126,208,242,60,15,238,116,91,85,84,117,15,227,123,57,198,84,204,107,248,254,127,54,184,116,143,87,189,217,217,186,221,149,60,7,221,24,245,28,242,146,106,13,153,44,11,166,12,150,110,180,225,177,12,144,117,198,115,4,26,37,0,157,64,82,84,81,94,186,211,214,92,239,135,160,98,180,144,162,236,224,177,229,5,164,253,222,151,250,182,171,217,83,1,247,32,216,235,208,188,88,108,162,155,117,16,250,43,68,226,4,163,148,16,130,34,28,175,16,198,36,8,18,28,92,199,216,95,92,14,54,255,25,247,100,16,76,30,253,19,250,217,48,239,228,219,175,216,81,20,95,249,1,137,81,134,179,112,196,78,54,235,9,155,132,152,12,216,214,135,99,155,236,227,19,163,60,119,82,56,2,0,0 };
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


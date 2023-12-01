namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileSchemaProviderSchema

	/// <exclude/>
	public class IFileSchemaProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileSchemaProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileSchemaProviderSchema(IFileSchemaProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c19fcb3d-30cc-4889-b3ff-cadcced57d1c");
			Name = "IFileSchemaProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ee75749b-5184-4f75-a3ec-dd2e096c705e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,219,106,2,49,16,125,174,224,63,12,250,98,161,236,190,235,86,40,165,21,161,23,169,253,129,152,157,117,83,178,137,204,100,43,34,253,247,38,217,213,122,105,139,251,16,200,92,206,57,115,38,11,70,84,200,43,33,17,222,145,72,176,45,92,114,111,77,161,150,53,9,167,172,233,118,182,221,206,85,205,202,44,97,190,97,135,149,207,107,141,50,36,57,153,160,65,82,114,212,237,248,170,62,225,210,71,97,106,28,82,225,65,135,48,125,48,78,185,77,76,167,105,10,25,215,85,37,104,51,110,239,51,178,159,42,71,6,101,10,75,85,164,4,177,176,181,3,140,157,192,178,196,74,48,8,66,95,84,122,54,135,57,20,100,43,232,61,42,141,220,75,118,216,233,1,248,170,94,104,37,125,71,43,5,166,161,120,30,193,90,82,242,101,219,168,108,175,252,25,93,105,115,30,194,44,182,55,201,83,221,49,240,134,174,38,195,224,74,4,173,216,129,45,64,104,125,129,220,182,228,198,167,165,174,243,96,172,200,115,21,38,23,250,208,135,100,79,158,158,178,103,212,208,143,127,118,17,4,4,130,189,130,128,148,100,233,174,50,180,62,121,161,217,143,15,83,95,49,134,9,186,59,173,155,8,15,174,71,23,12,125,190,172,34,48,31,109,12,214,165,146,37,40,6,66,45,130,9,206,2,175,80,170,66,249,11,161,180,148,31,183,252,55,240,74,144,168,32,60,215,219,94,211,219,40,126,241,145,222,56,156,193,128,176,141,95,145,179,52,2,156,27,248,186,248,240,254,193,90,185,242,175,177,246,16,135,86,30,187,232,157,55,173,160,1,59,10,59,61,21,185,51,182,143,38,111,94,91,188,127,53,127,206,81,48,198,252,247,13,91,5,102,51,158,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c19fcb3d-30cc-4889-b3ff-cadcced57d1c"));
		}

		#endregion

	}

	#endregion

}


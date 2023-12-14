namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkEmailAudienceRepositorySchema

	/// <exclude/>
	public class IBulkEmailAudienceRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkEmailAudienceRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkEmailAudienceRepositorySchema(IBulkEmailAudienceRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a06eeb92-03f3-e55d-a005-1861571a3c8a");
			Name = "IBulkEmailAudienceRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,147,219,78,195,48,12,134,175,55,105,239,96,149,27,144,166,246,30,70,37,216,166,105,23,136,195,224,1,178,214,93,45,218,164,228,32,84,33,222,29,55,93,183,238,160,145,187,56,241,151,223,191,29,41,74,52,149,72,16,222,81,107,97,84,102,195,169,146,25,109,156,22,150,148,28,13,127,70,195,129,51,36,55,176,170,141,197,242,110,183,239,167,104,12,231,210,146,37,52,251,11,62,82,79,85,81,96,210,192,224,30,14,110,134,199,23,56,149,147,175,52,110,154,219,75,105,81,103,44,238,22,150,143,174,248,156,151,130,138,7,151,18,202,4,223,176,82,134,172,210,181,207,137,162,8,38,198,149,165,208,117,188,221,207,208,36,154,214,104,32,115,210,243,69,193,207,65,166,52,136,45,6,84,6,54,71,88,51,31,176,121,32,236,104,81,15,87,185,117,65,9,80,167,232,31,65,131,31,47,106,87,201,19,218,92,165,230,22,94,60,167,61,60,150,236,3,11,180,230,130,56,248,38,155,67,234,42,166,8,139,144,40,153,82,83,153,9,119,200,232,152,57,169,132,22,37,72,238,245,125,176,238,116,47,211,32,254,144,244,229,16,40,69,110,68,70,168,207,216,49,137,124,250,121,26,154,175,32,94,97,211,62,96,146,174,207,72,238,170,185,76,218,213,244,94,87,24,196,157,171,189,90,45,31,92,102,168,202,91,113,172,168,141,158,166,106,180,78,75,19,247,6,148,213,107,76,168,226,183,185,15,167,102,91,193,216,189,93,204,236,32,13,245,100,222,91,29,93,45,215,11,71,41,244,26,48,222,254,144,85,146,179,85,175,94,45,59,58,110,88,131,147,1,155,245,29,130,3,191,206,128,158,219,170,187,234,111,238,182,19,137,50,109,135,210,239,127,219,15,215,11,2,175,209,208,199,155,245,7,100,127,203,58,33,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a06eeb92-03f3-e55d-a005-1861571a3c8a"));
		}

		#endregion

	}

	#endregion

}


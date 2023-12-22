namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailAudienceDataSourceFactorySchema

	/// <exclude/>
	public class BulkEmailAudienceDataSourceFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailAudienceDataSourceFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailAudienceDataSourceFactorySchema(BulkEmailAudienceDataSourceFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1c1f0d41-7ba2-4160-96b6-1a7c839825bf");
			Name = "BulkEmailAudienceDataSourceFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("93656b7c-51ad-4950-bd26-b581bae6f796");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,193,110,211,64,16,61,167,82,255,97,228,30,72,165,200,22,226,80,169,73,35,65,10,200,135,2,82,90,113,168,56,108,236,113,178,194,222,53,59,187,84,1,241,239,204,218,142,235,52,113,27,36,232,9,159,60,227,153,55,251,222,60,175,18,5,82,41,18,132,107,52,70,144,206,108,56,211,42,147,75,103,132,149,90,29,31,253,60,62,26,56,146,106,9,243,53,89,44,198,109,60,211,6,57,226,248,196,224,146,139,33,86,22,77,198,112,231,16,95,9,153,115,213,107,151,74,84,9,94,10,43,230,218,153,4,223,137,196,106,179,174,26,163,40,130,9,185,162,16,102,61,109,226,184,40,115,44,80,89,130,172,46,5,171,33,49,40,44,130,84,100,5,195,17,232,140,59,17,253,135,236,34,232,31,23,68,211,112,51,41,234,140,186,253,184,32,157,163,197,97,240,89,230,57,44,16,12,22,250,59,166,32,50,166,1,103,225,203,179,240,85,112,250,133,139,75,183,200,101,2,73,46,136,224,141,203,191,190,45,120,94,47,183,3,232,143,118,74,230,72,196,34,98,186,71,170,129,223,66,43,51,111,136,172,113,254,27,157,195,167,234,108,149,156,59,122,86,137,75,204,132,203,45,36,247,109,33,204,42,61,9,132,106,53,245,146,218,21,30,192,47,108,103,117,21,221,168,244,116,255,240,20,42,66,191,234,83,159,160,74,107,106,62,234,50,189,66,187,210,233,33,36,59,174,41,170,166,142,105,20,222,109,145,252,19,223,236,161,89,101,74,97,68,1,138,255,159,139,192,17,26,222,137,194,196,255,50,193,244,134,227,23,228,245,110,82,225,36,170,234,247,183,47,54,122,197,105,48,189,230,5,56,37,191,57,246,122,202,116,100,38,217,139,205,102,124,37,160,47,125,2,81,216,100,53,151,63,176,198,35,126,243,16,165,88,162,151,133,85,73,119,1,12,90,103,20,77,63,244,171,245,200,102,89,174,73,180,129,216,96,118,76,209,47,116,99,197,184,25,57,188,217,82,19,182,197,29,193,123,39,83,232,72,54,226,195,90,104,25,55,206,26,212,71,169,86,255,200,169,135,15,209,183,128,239,65,199,29,183,62,155,253,224,78,218,21,80,125,45,196,41,144,43,75,109,236,127,87,62,163,43,219,75,249,47,217,179,41,104,151,250,79,236,58,234,224,143,123,238,89,142,235,236,118,146,115,221,231,55,142,55,169,89,32,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1c1f0d41-7ba2-4160-96b6-1a7c839825bf"));
		}

		#endregion

	}

	#endregion

}


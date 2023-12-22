namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateAudienceBackgroundTaskSchema

	/// <exclude/>
	public class UpdateAudienceBackgroundTaskSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateAudienceBackgroundTaskSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateAudienceBackgroundTaskSchema(UpdateAudienceBackgroundTaskSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fe47ef50-c61a-408b-9310-9543c3f3a000");
			Name = "UpdateAudienceBackgroundTask";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,81,65,110,194,48,16,60,167,82,255,224,99,144,170,60,0,40,82,161,180,229,208,30,72,56,87,139,179,4,43,198,78,215,118,170,170,226,239,117,72,131,8,36,136,72,142,228,221,25,207,236,142,130,29,154,2,56,178,4,137,192,232,141,141,102,90,109,68,230,8,172,208,138,253,222,223,5,206,8,149,245,33,162,119,80,41,9,41,99,164,82,112,28,117,18,168,183,30,189,0,183,154,4,154,94,68,2,38,175,186,190,95,184,181,20,156,113,9,198,176,85,145,130,197,39,151,10,84,28,167,192,243,140,180,83,105,133,103,67,182,104,87,198,53,60,1,202,208,54,164,103,176,48,121,96,139,149,65,242,99,41,228,213,76,75,252,114,130,48,245,130,213,252,65,65,162,244,84,214,70,177,79,215,186,215,14,27,139,165,22,41,91,58,21,246,201,178,2,200,175,223,34,153,193,97,205,158,122,172,68,103,82,143,29,98,158,80,2,177,181,147,249,124,7,66,54,143,191,161,44,144,60,101,86,109,169,94,239,79,244,138,118,60,237,134,78,194,65,253,156,249,22,150,111,89,120,226,35,230,91,220,193,135,191,54,38,3,14,6,153,242,21,189,9,231,37,42,59,24,94,54,142,82,77,51,232,241,25,117,237,231,196,193,191,53,207,39,132,124,116,69,41,46,164,176,55,202,29,176,9,154,91,21,247,213,127,127,25,112,140,182,157,84,120,22,92,59,181,102,135,103,97,250,172,58,210,173,52,253,57,168,158,124,127,39,8,181,247,180,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe47ef50-c61a-408b-9310-9543c3f3a000"));
		}

		#endregion

	}

	#endregion

}


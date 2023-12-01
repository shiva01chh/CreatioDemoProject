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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,81,65,110,194,48,16,60,7,169,127,240,49,72,85,30,0,20,169,80,218,114,104,15,36,156,171,197,89,130,21,227,184,107,59,85,85,241,247,58,164,65,4,146,138,67,34,121,119,198,51,158,81,176,71,163,129,35,75,144,8,76,177,181,209,188,80,91,145,57,2,43,10,197,126,238,6,129,51,66,101,125,136,232,13,84,74,66,202,24,169,20,28,199,157,4,234,157,71,207,192,109,65,2,77,47,34,1,147,87,91,191,215,110,35,5,103,92,130,49,108,173,83,176,248,232,82,129,138,227,12,120,158,81,225,84,90,225,217,136,45,219,147,73,13,79,128,50,180,13,233,9,44,76,239,217,114,109,144,252,179,20,242,234,77,43,252,116,130,48,245,130,213,251,3,77,162,244,84,214,70,177,15,215,58,215,14,27,139,101,33,82,182,114,42,236,147,101,26,200,199,111,145,204,240,24,179,167,158,38,209,133,212,67,135,152,39,148,64,108,227,100,190,216,131,144,205,229,175,40,53,146,167,204,171,148,234,120,191,163,23,180,147,89,55,116,26,14,235,235,204,151,176,124,199,194,51,31,49,223,225,30,222,253,177,49,25,112,48,200,148,159,20,219,112,81,162,178,195,209,245,226,36,213,44,131,30,159,81,87,62,103,14,254,172,121,62,33,228,227,127,148,98,45,133,189,81,238,136,77,208,220,170,120,168,254,135,235,130,99,180,237,166,194,139,226,218,173,53,25,94,148,233,187,234,104,183,210,244,223,81,117,48,248,5,167,56,118,92,171,3,0,0 };
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


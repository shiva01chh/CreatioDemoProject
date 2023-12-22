namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CloudSenderDomainSchema

	/// <exclude/>
	public class CloudSenderDomainSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CloudSenderDomainSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CloudSenderDomainSchema(CloudSenderDomainSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e61dae9a-2655-48a6-bc4a-42efa1e9c942");
			Name = "CloudSenderDomain";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,193,78,132,48,16,134,207,75,178,239,48,201,222,225,238,26,47,184,122,48,155,16,241,5,186,116,138,205,66,75,166,197,72,136,239,238,208,238,26,162,123,192,85,46,77,127,166,243,125,133,49,162,69,215,137,10,225,5,137,132,179,202,167,185,53,74,215,61,9,175,173,73,243,93,185,183,18,27,183,78,198,117,178,218,16,214,28,67,222,8,231,110,120,177,189,44,209,72,164,123,219,10,109,214,9,23,101,89,6,183,174,111,91,65,195,221,105,255,140,29,161,67,227,29,104,163,44,181,161,61,136,131,237,61,200,112,22,56,6,46,145,218,212,224,95,17,144,211,198,165,231,142,217,172,101,215,31,26,93,65,53,105,92,178,88,141,193,228,203,183,32,219,33,121,141,44,93,132,179,241,253,119,213,16,60,34,91,6,23,94,39,145,147,159,144,146,239,16,132,126,26,157,149,156,167,201,63,138,192,8,53,250,237,212,105,11,31,191,65,190,33,105,165,171,248,149,248,223,88,90,132,221,77,149,255,68,61,226,176,136,249,132,195,245,196,253,251,98,14,151,94,141,41,139,135,197,156,178,83,127,186,146,243,194,247,28,169,217,236,44,3,199,131,23,192,27,30,238,56,201,97,31,211,121,200,201,252,249,4,31,193,225,165,216,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e61dae9a-2655-48a6-bc4a-42efa1e9c942"));
		}

		#endregion

	}

	#endregion

}


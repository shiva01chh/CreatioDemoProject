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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,193,78,132,48,16,134,207,75,178,239,48,201,222,225,238,26,47,184,122,48,155,16,241,5,186,116,192,102,161,37,211,214,72,136,239,238,208,238,26,162,123,192,85,46,77,127,166,243,125,133,209,162,67,219,139,10,225,5,137,132,53,181,75,115,163,107,213,120,18,78,25,157,230,187,114,111,36,182,118,157,140,235,100,181,33,108,56,134,188,21,214,222,240,98,188,44,81,75,164,123,211,9,165,215,9,23,101,89,6,183,214,119,157,160,225,238,180,127,198,158,208,162,118,22,148,174,13,117,161,61,136,131,241,14,100,56,11,28,3,151,72,165,27,112,175,8,200,105,107,211,115,199,108,214,178,247,135,86,85,80,77,26,151,44,86,99,48,249,242,45,200,244,72,78,33,75,23,225,108,124,255,93,53,4,143,200,150,193,133,215,73,228,228,39,164,228,59,4,161,159,70,103,37,235,104,242,143,34,48,66,131,110,59,117,218,194,199,111,144,111,72,170,86,85,252,74,252,111,12,45,194,238,166,202,127,162,30,113,88,196,124,194,225,122,226,254,125,49,135,75,175,198,148,197,195,98,78,217,215,127,186,146,117,194,121,142,234,217,236,44,3,199,131,23,192,27,30,238,56,201,97,31,211,121,200,201,244,124,2,56,165,20,244,208,3,0,0 };
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


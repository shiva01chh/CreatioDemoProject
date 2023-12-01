namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CloudSenderDomainsInfoSchema

	/// <exclude/>
	public class CloudSenderDomainsInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CloudSenderDomainsInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CloudSenderDomainsInfoSchema(CloudSenderDomainsInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f2e8d79a-460e-4a42-b17f-4d076f55b6e6");
			Name = "CloudSenderDomainsInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,75,111,219,48,12,62,183,64,255,3,209,30,118,179,239,75,218,75,210,22,93,151,33,136,135,222,85,139,242,132,200,146,33,202,25,130,96,255,189,148,148,24,125,172,131,179,67,129,250,34,136,164,190,135,40,211,138,22,169,19,53,194,79,244,94,144,83,161,152,57,171,116,211,123,17,180,179,197,236,186,90,56,137,134,206,78,119,103,167,39,61,105,219,64,181,165,128,45,87,26,131,117,44,163,226,22,45,122,93,79,134,154,31,248,59,112,34,34,126,35,103,57,193,169,11,143,13,151,195,204,8,162,175,188,184,94,86,104,37,250,185,107,133,182,116,103,149,75,149,101,89,194,148,250,182,21,126,123,181,223,175,176,243,72,104,3,1,175,29,163,35,56,5,225,23,2,161,223,104,182,161,156,231,92,240,26,55,81,132,204,168,41,204,7,101,140,33,135,76,113,160,40,159,113,116,253,163,209,53,212,81,220,187,218,78,118,73,223,96,101,233,93,135,62,104,100,63,203,4,144,243,175,13,164,192,45,178,246,164,133,215,168,251,32,80,88,9,58,124,225,100,151,239,115,128,40,95,99,76,9,81,24,114,80,123,84,151,231,207,37,158,151,169,106,239,227,187,166,48,125,99,227,10,246,118,96,7,13,134,73,212,50,129,63,71,137,70,37,122,19,64,174,117,91,0,191,151,144,240,54,194,244,8,90,65,231,221,70,51,97,62,17,95,131,65,88,227,54,181,65,24,115,112,253,142,201,189,124,226,46,114,187,230,153,108,126,127,183,184,103,136,79,34,154,213,174,176,118,94,254,191,224,106,121,147,213,141,98,172,58,245,144,172,124,16,223,156,227,235,227,24,243,187,139,28,90,166,225,194,127,106,188,162,113,124,233,240,195,112,246,200,219,93,29,230,5,5,17,250,113,77,172,82,233,241,20,53,207,203,127,19,104,27,248,5,202,241,87,55,96,243,184,38,209,140,107,209,34,215,254,141,228,130,7,66,158,95,105,159,163,47,131,41,198,223,19,102,13,164,120,35,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f2e8d79a-460e-4a42-b17f-4d076f55b6e6"));
		}

		#endregion

	}

	#endregion

}


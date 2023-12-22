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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,205,110,219,48,12,62,183,64,223,129,104,15,187,217,247,37,235,37,233,138,174,75,17,196,67,239,170,69,121,66,100,201,16,229,20,65,176,119,31,37,37,70,218,174,131,179,67,129,249,34,136,164,190,31,81,166,21,45,82,39,106,132,31,232,189,32,167,66,49,115,86,233,166,247,34,104,103,139,217,77,181,112,18,13,93,156,239,46,206,207,122,210,182,129,106,75,1,91,174,52,6,235,88,70,197,45,90,244,186,158,12,53,15,248,28,56,17,17,191,145,179,156,224,212,149,199,134,203,97,102,4,209,103,94,92,47,43,180,18,253,220,181,66,91,186,179,202,165,202,178,44,97,74,125,219,10,191,189,222,239,87,216,121,36,180,129,128,215,142,209,17,156,130,240,19,129,208,111,52,219,80,206,115,46,120,141,155,40,66,102,212,20,230,131,50,198,144,67,166,56,80,148,71,28,93,255,100,116,13,117,20,247,174,182,179,93,210,55,88,89,122,215,161,15,26,217,207,50,1,228,252,107,3,41,112,139,172,61,105,225,53,234,62,8,20,86,130,14,159,56,217,229,251,28,32,202,215,24,83,66,20,134,28,212,30,213,151,203,99,137,151,101,170,218,251,248,174,41,76,223,216,184,134,189,29,216,65,131,97,18,181,76,224,215,73,162,81,137,222,4,144,107,221,22,192,239,37,36,188,141,48,61,130,86,208,121,183,209,76,152,79,196,215,96,16,214,184,77,109,16,198,28,92,191,99,114,47,159,184,139,220,174,121,38,155,223,223,45,238,25,226,63,17,205,106,87,88,59,47,255,93,112,181,252,154,213,141,98,172,58,245,152,172,124,16,223,156,227,235,211,24,243,187,139,28,90,166,225,194,127,106,188,162,113,124,233,240,227,112,246,196,219,93,29,230,5,5,17,250,113,77,172,82,233,233,20,53,207,203,191,19,104,27,248,5,202,241,87,55,96,243,184,38,209,140,107,209,34,215,254,137,228,138,7,66,158,95,105,159,163,47,131,41,118,252,253,6,121,23,69,53,44,6,0,0 };
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


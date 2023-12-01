namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailLicenseInformationResponseSchema

	/// <exclude/>
	public class EmailLicenseInformationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailLicenseInformationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailLicenseInformationResponseSchema(EmailLicenseInformationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c3bb4a3c-028b-42dd-b032-27136305e1d1");
			Name = "EmailLicenseInformationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,145,79,75,195,64,16,197,239,133,126,135,161,23,245,208,4,175,86,5,77,123,40,180,30,218,122,146,30,166,217,73,92,200,238,134,157,13,18,139,223,221,73,210,218,63,82,16,151,37,11,195,219,247,222,111,3,22,13,113,137,41,193,138,188,71,118,89,136,18,103,51,157,87,30,131,118,54,74,38,203,185,83,84,112,191,183,237,247,64,86,197,218,230,176,172,57,144,137,22,149,13,218,80,180,36,175,177,208,159,237,165,81,191,215,73,227,56,134,123,174,140,65,95,63,30,70,11,42,61,49,217,192,32,103,233,44,19,124,232,240,14,152,166,78,12,175,24,10,157,82,51,214,54,115,222,116,85,142,60,227,83,211,183,49,6,148,222,193,99,26,214,221,172,172,54,98,2,105,129,204,48,49,168,139,89,231,57,61,88,46,118,233,119,240,140,76,73,225,42,181,31,117,38,219,61,201,5,154,253,248,233,168,184,209,1,92,6,212,68,50,4,7,66,170,160,36,15,10,235,8,166,25,12,111,97,8,149,109,165,164,162,179,132,248,119,68,203,55,39,179,33,127,253,34,191,12,30,96,160,196,190,158,53,22,73,19,61,184,89,31,244,59,118,109,3,140,79,101,176,133,156,194,72,58,201,231,235,175,116,133,39,84,117,7,178,227,106,121,65,94,82,8,27,174,255,65,180,119,95,25,115,186,212,127,245,163,56,175,222,8,229,144,45,235,27,115,84,141,233,202,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c3bb4a3c-028b-42dd-b032-27136305e1d1"));
		}

		#endregion

	}

	#endregion

}


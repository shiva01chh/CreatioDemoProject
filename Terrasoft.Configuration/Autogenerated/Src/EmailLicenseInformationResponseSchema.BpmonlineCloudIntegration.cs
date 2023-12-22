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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,145,75,75,195,64,20,133,247,133,254,135,75,55,234,162,9,110,173,10,154,118,81,104,93,180,117,37,93,220,102,110,226,192,60,194,220,25,36,22,255,187,147,164,181,15,41,136,195,144,129,203,153,115,206,55,1,131,154,184,194,156,96,69,206,33,219,194,39,153,53,133,44,131,67,47,173,73,178,201,114,110,5,41,238,247,182,253,30,196,21,88,154,18,150,53,123,210,201,34,24,47,53,37,75,114,18,149,252,108,47,141,250,189,78,154,166,41,220,115,208,26,93,253,120,24,45,168,114,196,100,60,67,60,43,107,152,224,67,250,119,192,60,183,209,240,138,65,201,156,154,177,52,133,117,186,171,114,228,153,158,154,190,141,209,99,236,237,29,230,126,221,205,170,176,137,38,144,43,100,134,137,70,169,102,157,231,244,96,185,216,165,223,193,51,50,101,202,6,177,31,117,38,219,61,201,5,154,253,248,233,168,184,150,30,108,1,212,68,50,120,11,145,84,64,69,14,4,214,9,76,11,24,222,194,16,130,105,165,36,146,179,132,244,119,68,203,55,39,189,33,119,253,18,127,25,60,192,64,68,251,122,214,88,100,77,244,224,102,125,208,239,216,165,241,48,62,149,193,22,74,242,163,216,41,126,190,254,74,167,28,161,168,59,144,29,87,203,11,241,37,35,97,195,245,63,136,246,238,43,99,73,151,250,175,126,20,231,213,27,97,60,226,62,94,223,3,65,100,21,211,2,0,0 };
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


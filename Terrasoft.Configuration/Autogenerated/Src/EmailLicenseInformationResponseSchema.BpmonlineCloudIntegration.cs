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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,145,75,75,195,64,20,133,247,133,254,135,75,55,234,162,9,110,173,10,154,118,81,104,93,180,117,37,93,220,102,110,226,192,60,194,220,9,18,139,255,221,153,164,181,15,41,136,195,144,129,203,153,115,206,55,1,131,154,184,194,156,96,69,206,33,219,194,39,153,53,133,44,107,135,94,90,147,100,147,229,220,10,82,220,239,109,251,61,8,171,102,105,74,88,54,236,73,39,139,218,120,169,41,89,146,147,168,228,103,123,105,212,239,117,210,52,77,225,158,107,173,209,53,143,135,209,130,42,71,76,198,51,132,179,178,134,9,62,164,127,7,204,115,27,12,175,24,148,204,41,142,165,41,172,211,93,149,35,207,244,212,244,109,140,30,67,111,239,48,247,235,110,86,213,155,96,2,185,66,102,152,104,148,106,214,121,78,15,150,139,93,250,29,60,35,83,166,108,45,246,163,206,100,187,39,185,64,179,31,63,29,21,215,210,131,45,128,98,36,131,183,16,72,5,84,228,64,96,147,192,180,128,225,45,12,161,54,173,148,68,114,150,144,254,142,104,249,230,164,55,228,174,95,194,47,131,7,24,136,96,223,204,162,69,22,163,7,55,235,131,126,199,46,141,135,241,169,12,182,80,146,31,133,78,225,243,245,87,58,229,8,69,211,129,236,184,90,94,8,47,25,8,35,215,255,32,218,187,175,140,37,93,234,191,250,81,156,87,143,194,112,132,29,215,55,65,171,50,251,203,2,0,0 };
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


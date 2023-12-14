namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookPermissionSchema

	/// <exclude/>
	public class FacebookPermissionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookPermissionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookPermissionSchema(FacebookPermissionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e9463608-7170-4f90-8842-6c14ece0a0d4");
			Name = "FacebookPermission";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,106,195,48,12,134,207,9,228,29,4,189,108,48,242,0,45,189,172,163,199,17,104,95,192,117,213,76,44,181,131,164,156,74,223,125,138,147,45,41,205,124,176,225,215,239,95,159,20,220,21,165,117,30,225,136,204,78,226,69,203,93,12,23,170,59,118,74,49,148,135,232,201,53,69,126,43,242,34,207,86,140,181,169,176,107,156,200,26,246,246,243,20,227,119,133,124,37,17,171,36,87,219,157,26,242,224,123,211,130,7,214,240,238,4,103,194,16,254,151,94,113,108,145,149,208,90,84,41,107,168,143,185,162,76,161,134,79,99,135,91,141,186,1,177,235,190,228,249,64,241,76,173,166,38,255,88,39,142,131,58,237,4,198,231,201,191,194,112,30,8,31,113,109,97,214,174,243,26,121,25,248,121,5,47,35,95,176,25,222,126,97,207,19,236,107,191,146,44,203,244,139,164,76,131,110,147,119,51,169,243,209,182,243,191,201,179,140,60,168,143,162,105,253,249,1,111,232,32,197,10,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9463608-7170-4f90-8842-6c14ece0a0d4"));
		}

		#endregion

	}

	#endregion

}


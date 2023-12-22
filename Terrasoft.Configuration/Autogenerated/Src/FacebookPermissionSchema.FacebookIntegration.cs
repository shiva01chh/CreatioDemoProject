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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,110,194,48,12,134,207,173,212,119,176,196,101,147,80,31,0,196,101,76,28,81,37,246,2,33,152,206,90,73,42,219,61,161,189,59,38,45,107,17,93,14,137,244,251,207,239,207,14,238,130,210,58,143,240,133,204,78,226,89,203,109,12,103,170,59,118,74,49,148,135,232,201,53,69,126,45,242,34,207,22,140,181,169,176,109,156,200,10,118,246,243,24,227,79,133,124,33,17,171,36,87,219,29,27,242,224,239,166,25,15,172,224,195,9,78,132,62,252,47,189,226,216,34,43,161,181,168,82,86,95,31,114,69,153,66,13,123,99,135,107,141,186,6,177,235,119,206,243,137,226,153,90,77,77,254,177,142,28,7,117,218,9,12,207,139,127,129,225,212,19,62,227,218,194,172,93,231,53,242,60,240,235,10,222,6,190,96,51,44,31,176,167,17,246,253,190,146,44,203,244,155,164,76,131,110,146,119,61,170,211,209,54,211,191,201,51,143,220,171,207,162,105,211,115,3,244,251,116,220,18,2,0,0 };
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


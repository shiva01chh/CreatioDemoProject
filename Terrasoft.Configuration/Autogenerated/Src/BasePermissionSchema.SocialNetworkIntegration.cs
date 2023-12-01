namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BasePermissionSchema

	/// <exclude/>
	public class BasePermissionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BasePermissionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BasePermissionSchema(BasePermissionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("61e6f54e-7847-49e3-aff5-86a7ed440807");
			Name = "BasePermission";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,193,78,195,48,12,134,207,173,212,119,176,196,21,85,112,93,197,133,13,237,130,80,69,121,129,144,121,149,165,36,45,118,114,128,105,239,142,211,34,96,93,115,72,100,251,179,255,248,15,198,163,140,198,34,188,33,179,145,225,24,235,237,16,142,212,39,54,145,134,80,119,131,37,227,170,242,84,149,85,89,36,161,208,67,247,41,17,189,130,206,161,205,148,212,123,12,200,100,155,37,243,76,225,227,42,249,154,66,36,143,117,167,45,198,209,215,164,212,76,2,55,140,189,6,240,20,146,223,64,139,236,73,68,19,93,52,49,201,132,140,233,221,145,5,84,98,5,40,244,163,69,177,67,235,40,224,1,30,224,238,54,39,246,108,66,156,226,123,13,207,179,22,134,195,44,119,33,189,117,70,100,3,143,70,240,111,252,127,101,155,129,171,122,49,59,244,59,166,229,97,68,142,132,58,171,157,26,231,186,68,206,86,188,168,243,112,130,30,99,3,146,175,243,69,121,135,98,153,198,108,204,26,181,220,27,126,158,21,116,177,229,218,234,154,211,243,13,31,126,167,208,12,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("61e6f54e-7847-49e3-aff5-86a7ed440807"));
		}

		#endregion

	}

	#endregion

}


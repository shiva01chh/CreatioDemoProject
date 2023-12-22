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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,193,106,195,48,12,134,207,9,228,29,4,187,142,176,93,27,118,89,91,122,41,37,44,123,1,207,85,131,192,81,50,201,62,108,165,239,62,59,25,91,155,198,7,27,73,159,244,91,63,155,14,117,48,22,225,29,69,140,246,39,95,174,123,62,81,27,196,120,234,185,108,122,75,198,21,249,185,200,139,60,11,74,220,66,243,165,30,187,8,58,135,54,81,90,238,144,81,200,86,115,102,79,252,121,151,124,11,236,169,195,178,137,45,198,209,247,168,84,141,2,15,130,109,12,96,203,161,91,65,141,210,145,106,76,52,222,248,160,35,50,132,15,71,22,48,18,11,64,22,63,154,101,27,180,142,24,143,240,2,79,143,41,177,19,195,126,140,159,99,120,153,180,144,143,147,220,141,244,218,25,213,21,188,26,197,255,241,215,202,54,1,119,245,108,114,232,111,76,45,253,128,226,9,227,172,122,108,156,234,234,37,89,113,136,206,195,25,90,244,21,104,186,46,55,229,13,170,21,26,146,49,75,212,124,111,248,125,22,208,217,150,75,171,199,220,245,249,1,154,125,61,143,21,2,0,0 };
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


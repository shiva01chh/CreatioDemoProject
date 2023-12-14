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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,193,78,195,48,12,134,207,173,212,119,176,196,21,85,112,93,197,133,13,237,130,80,69,121,129,144,121,149,165,196,45,118,114,128,105,239,78,210,34,96,93,115,72,100,251,179,255,248,103,227,81,71,99,17,222,80,196,232,112,12,245,118,224,35,245,81,76,160,129,235,110,176,100,92,85,158,170,178,42,139,168,196,61,116,159,26,208,39,208,57,180,153,210,122,143,140,66,182,89,50,207,196,31,87,201,215,200,129,60,214,93,106,49,142,190,38,165,102,18,184,17,236,83,0,79,28,253,6,90,20,79,170,41,209,5,19,162,78,200,24,223,29,89,192,68,172,0,69,250,104,81,236,208,58,98,60,192,3,220,221,230,196,94,12,135,41,190,79,225,121,214,66,62,204,114,23,210,91,103,84,55,240,104,20,255,198,255,87,182,25,184,170,23,179,67,191,99,90,25,70,148,64,152,102,181,83,227,92,215,32,217,138,151,228,60,156,160,199,208,128,230,235,124,81,222,161,90,161,49,27,179,70,45,247,134,159,103,5,93,108,185,182,122,202,229,243,13,24,172,15,191,13,2,0,0 };
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


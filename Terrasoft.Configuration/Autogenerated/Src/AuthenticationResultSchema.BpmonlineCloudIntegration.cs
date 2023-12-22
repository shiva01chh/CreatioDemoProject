namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AuthenticationResultSchema

	/// <exclude/>
	public class AuthenticationResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AuthenticationResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AuthenticationResultSchema(AuthenticationResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("16a1ffba-730d-4792-8d1d-f8f8fb57e8df");
			Name = "AuthenticationResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("48c79191-1a42-4c6e-9843-1938fdf8bec4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,193,10,194,48,12,134,207,14,246,14,1,239,219,93,69,16,189,10,162,190,64,173,89,45,108,109,73,218,131,136,239,110,215,77,153,50,181,135,66,210,252,255,255,53,70,52,200,78,72,132,35,18,9,182,149,47,214,214,84,90,5,18,94,91,147,103,183,60,203,179,201,148,80,197,18,214,181,96,158,193,42,248,11,26,175,101,26,218,35,135,218,167,185,178,44,97,193,161,105,4,93,151,125,189,71,71,200,113,156,65,182,114,176,21,68,57,136,55,19,160,228,82,60,77,202,129,139,11,167,90,203,94,61,158,61,233,56,95,160,59,178,14,201,107,140,180,187,36,239,222,63,1,123,194,214,100,156,171,120,169,134,68,79,164,147,181,53,28,130,148,24,201,110,160,208,207,129,219,235,254,35,110,131,44,73,187,244,235,127,187,248,30,205,158,180,81,176,141,201,66,225,88,248,20,205,185,91,71,170,187,238,123,51,245,134,231,1,35,68,7,153,18,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16a1ffba-730d-4792-8d1d-f8f8fb57e8df"));
		}

		#endregion

	}

	#endregion

}


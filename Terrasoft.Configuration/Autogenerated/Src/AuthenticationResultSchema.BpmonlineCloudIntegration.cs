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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,193,10,194,48,12,134,207,14,246,14,1,239,219,93,69,16,189,10,67,125,129,90,179,90,216,218,146,180,7,17,223,221,174,155,162,50,181,135,66,210,252,255,255,53,70,180,200,78,72,132,3,18,9,182,181,47,214,214,212,90,5,18,94,91,147,103,215,60,203,179,201,148,80,197,18,214,141,96,158,193,42,248,51,26,175,101,26,218,33,135,198,167,185,178,44,97,193,161,109,5,93,150,67,189,67,71,200,113,156,65,118,114,176,53,68,57,136,55,19,160,228,82,60,76,202,23,23,23,142,141,150,131,122,60,123,210,115,62,65,43,178,14,201,107,140,180,85,146,247,239,159,128,3,97,103,50,206,85,60,85,175,68,15,164,163,181,13,236,131,148,24,201,174,160,208,207,129,187,235,246,35,110,131,44,73,187,244,235,127,187,248,30,205,158,180,81,176,141,201,66,225,88,248,20,205,169,95,71,170,251,238,123,51,245,226,185,3,187,164,10,199,9,2,0,0 };
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


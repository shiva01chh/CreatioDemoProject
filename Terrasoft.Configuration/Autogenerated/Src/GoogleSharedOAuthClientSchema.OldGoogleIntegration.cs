namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoogleSharedOAuthClientSchema

	/// <exclude/>
	public class GoogleSharedOAuthClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoogleSharedOAuthClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoogleSharedOAuthClientSchema(GoogleSharedOAuthClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6e2a4fc-fe7f-4b18-9691-d148df804de7");
			Name = "GoogleSharedOAuthClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,77,79,131,64,16,61,99,226,127,152,224,133,38,6,238,45,109,82,107,52,38,126,197,143,147,241,176,194,64,55,161,187,100,118,87,99,140,255,221,97,233,7,212,226,65,46,176,179,111,222,204,123,51,40,177,66,83,139,12,225,9,137,132,209,133,141,23,90,21,178,116,36,172,212,234,248,232,235,248,40,112,70,170,178,7,33,156,12,196,227,11,145,89,77,18,205,33,196,163,206,164,168,226,187,185,179,75,190,103,196,9,97,201,133,96,81,9,99,198,112,169,117,89,225,227,82,16,230,30,181,168,36,42,235,161,73,146,64,106,220,106,37,232,115,182,62,63,96,77,104,24,97,64,168,117,54,248,68,200,124,38,20,154,192,120,62,40,219,107,81,215,149,204,188,190,120,67,155,116,120,95,206,177,16,174,178,103,82,229,220,126,100,63,107,212,69,212,105,103,116,10,183,108,29,76,33,28,104,56,28,189,50,83,237,222,184,18,119,194,218,134,164,193,70,116,79,110,240,229,37,239,236,209,202,88,114,141,181,236,210,189,231,109,17,251,174,248,64,7,30,111,65,201,62,42,173,5,137,21,40,150,50,13,157,65,186,214,165,84,225,44,77,252,133,199,173,37,12,52,31,113,149,102,194,219,228,83,120,230,79,46,175,48,107,12,246,55,187,227,168,161,12,198,240,38,12,70,157,164,61,20,52,91,23,124,175,45,64,149,183,46,244,45,185,65,187,212,121,227,6,105,203,137,152,255,97,200,3,90,71,138,151,132,91,231,190,155,241,243,94,52,187,193,231,255,237,205,144,169,212,150,154,165,6,17,50,194,98,26,30,254,1,226,43,255,154,119,91,10,147,25,72,158,157,80,25,198,105,178,225,242,147,216,200,4,253,206,124,50,71,56,64,0,151,104,123,129,232,239,129,180,86,7,109,33,80,248,241,123,212,125,186,189,252,201,240,164,218,104,63,232,99,221,231,7,109,82,45,53,131,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6e2a4fc-fe7f-4b18-9691-d148df804de7"));
		}

		#endregion

	}

	#endregion

}


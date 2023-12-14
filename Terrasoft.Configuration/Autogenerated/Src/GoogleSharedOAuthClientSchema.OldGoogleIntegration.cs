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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,77,79,195,48,12,61,23,137,255,96,149,75,39,161,246,14,221,36,24,2,33,241,37,62,78,136,67,104,221,46,82,151,84,78,2,66,136,255,142,147,110,163,29,43,7,122,105,227,60,63,251,61,187,74,44,209,180,162,64,120,68,34,97,116,101,211,185,86,149,172,29,9,43,181,218,223,251,220,223,139,156,145,170,30,64,8,143,71,226,233,185,40,172,38,137,102,23,226,65,23,82,52,233,237,137,179,11,190,103,196,1,97,205,133,96,222,8,99,142,224,66,235,186,193,135,133,32,44,3,106,222,72,84,54,64,179,44,131,220,184,229,82,208,199,108,117,190,199,150,208,48,194,128,80,171,108,8,137,80,132,76,168,52,129,9,124,80,119,215,162,109,27,89,4,125,233,154,54,235,241,62,159,97,37,92,99,79,165,42,185,253,196,126,180,168,171,164,215,206,228,16,110,216,58,152,66,60,210,112,60,121,97,166,214,189,114,37,238,132,181,141,73,131,181,232,129,220,232,51,72,254,177,71,43,99,201,121,107,217,165,187,192,219,33,182,93,9,129,30,60,221,128,178,109,84,222,10,18,75,80,44,101,26,59,131,116,165,107,169,226,89,158,133,139,128,91,73,24,105,62,225,42,126,194,155,228,67,120,226,79,46,175,176,240,6,135,155,159,227,196,83,70,71,240,42,12,38,189,164,45,20,248,173,139,190,86,22,160,42,59,23,134,150,92,163,93,232,210,187,65,218,114,34,150,127,24,114,143,214,145,226,37,225,214,185,111,63,126,222,11,191,27,124,254,223,222,140,153,74,93,169,89,110,16,161,32,172,166,241,238,31,32,189,12,175,147,126,75,113,54,3,201,179,19,170,192,52,207,214,92,97,18,107,153,160,223,152,79,150,8,59,8,224,2,237,32,144,252,61,144,206,234,168,43,4,10,223,127,143,122,72,183,149,127,60,62,169,46,58,12,134,152,127,190,1,132,202,137,160,123,4,0,0 };
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


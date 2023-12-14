namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccessTokenInfoSchema

	/// <exclude/>
	public class AccessTokenInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccessTokenInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccessTokenInfoSchema(AccessTokenInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("edcf69f4-2a5f-419d-9855-0d3c0ba8478a");
			Name = "AccessTokenInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("34c57733-6570-402b-8e25-5c50c5be2b38");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,148,219,78,195,48,12,134,175,55,137,119,136,198,13,220,236,1,24,32,161,113,80,37,134,38,54,184,65,83,149,102,222,20,150,37,81,156,34,14,226,221,113,210,118,231,14,169,189,74,237,223,254,108,231,160,249,18,208,114,1,108,12,206,113,52,51,223,237,27,61,147,243,220,113,47,141,238,142,140,144,92,157,180,127,78,218,173,28,165,158,179,209,23,122,88,246,118,254,41,76,41,16,33,6,187,15,160,193,73,177,167,121,206,181,151,75,232,142,200,203,149,252,142,136,181,234,158,10,201,140,89,144,133,108,167,14,230,228,102,125,197,17,47,216,141,16,128,56,54,11,208,137,158,153,40,121,91,37,202,20,76,130,225,150,123,78,13,120,199,133,15,6,155,103,74,10,38,66,142,253,20,173,159,152,102,133,26,58,99,193,121,9,196,27,198,200,194,31,211,14,96,153,129,59,123,162,145,177,43,214,225,235,100,157,243,73,84,85,245,15,184,181,212,207,89,169,73,253,134,168,44,8,189,11,29,111,84,196,194,132,91,173,57,248,94,92,96,185,248,61,82,130,181,201,180,30,110,109,42,167,135,177,33,176,25,144,178,196,93,59,134,221,209,236,177,43,127,131,10,224,211,74,7,120,227,107,249,165,34,229,126,27,175,12,193,239,170,240,230,232,164,190,245,10,45,117,61,58,105,210,181,196,87,58,229,245,91,45,49,253,216,16,148,88,146,40,150,20,161,141,160,152,195,244,200,164,11,193,225,65,39,101,112,3,46,10,186,132,88,75,221,114,151,200,71,137,254,210,100,239,244,254,92,179,81,20,52,0,199,107,58,254,178,80,203,142,138,212,175,37,219,71,123,92,37,104,0,207,17,220,145,203,28,220,117,183,249,37,134,254,195,60,5,61,45,94,185,248,95,88,183,141,100,11,223,31,255,196,8,132,20,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("edcf69f4-2a5f-419d-9855-0d3c0ba8478a"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,148,219,110,194,48,12,134,175,65,226,29,34,118,195,110,120,128,157,36,196,14,170,180,77,104,176,221,76,168,74,131,65,25,105,18,197,233,180,13,237,221,231,166,45,208,177,50,169,189,74,237,223,254,108,231,160,121,10,104,185,0,54,3,231,56,154,165,31,142,141,94,202,85,230,184,151,70,15,167,70,72,174,122,221,77,175,219,201,80,234,21,155,126,162,135,244,252,215,63,133,41,5,34,143,193,225,29,104,112,82,28,104,158,50,237,101,10,195,41,121,185,146,95,1,177,83,221,82,33,137,49,107,178,144,237,196,193,138,220,108,172,56,226,25,27,9,1,136,51,179,6,29,233,165,9,146,215,109,162,68,193,60,55,92,115,207,169,1,239,184,240,185,193,102,137,146,130,137,60,199,97,138,206,38,164,217,162,38,206,88,112,94,2,241,38,33,178,240,135,180,15,144,38,224,6,143,52,50,118,201,250,124,151,172,127,58,15,170,170,254,7,110,45,245,51,40,53,177,223,19,149,5,161,119,121,199,123,21,177,124,194,157,206,10,252,121,88,96,185,248,62,82,130,181,209,162,25,110,109,44,23,127,99,243,192,118,64,202,18,118,237,24,246,151,230,128,93,249,91,84,0,31,86,58,192,145,111,228,151,138,152,251,58,94,25,130,223,84,225,237,209,81,115,235,21,90,234,102,116,212,166,107,137,47,116,202,155,183,90,98,252,190,39,40,177,36,81,44,42,66,91,65,49,131,197,145,73,23,130,191,7,29,149,193,45,184,40,232,18,98,35,181,230,46,145,247,18,253,133,73,222,232,253,185,98,211,32,104,1,14,215,116,246,105,161,145,29,20,177,223,73,234,71,123,86,37,104,1,207,16,220,145,203,156,187,155,110,243,115,8,253,135,121,2,122,81,188,114,225,191,176,214,141,100,163,239,7,63,81,239,185,19,6,0,0 };
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


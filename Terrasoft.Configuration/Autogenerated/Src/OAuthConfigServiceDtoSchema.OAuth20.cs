namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OAuthConfigServiceDtoSchema

	/// <exclude/>
	public class OAuthConfigServiceDtoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OAuthConfigServiceDtoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OAuthConfigServiceDtoSchema(OAuthConfigServiceDtoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a2501d98-fcfc-4786-9ed5-b96381b1cbae");
			Name = "OAuthConfigServiceDto";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,86,77,107,27,49,16,61,59,144,255,32,156,75,11,197,148,30,19,74,48,14,148,28,154,6,111,125,42,61,200,218,137,43,88,107,183,51,163,64,107,250,223,59,210,198,249,216,106,227,85,235,164,241,193,102,37,189,55,222,55,111,70,227,244,26,168,209,6,212,103,64,212,84,95,241,100,86,187,43,187,242,168,217,214,110,242,105,234,249,219,187,183,135,7,155,195,131,145,39,235,86,170,248,65,12,235,147,206,243,100,238,29,219,53,76,10,64,171,43,251,51,226,229,148,156,59,66,88,201,131,154,85,154,232,88,77,203,114,86,89,112,60,135,239,30,136,227,153,47,103,154,181,196,102,212,134,191,202,66,227,151,149,53,202,4,76,2,50,218,68,216,45,247,37,214,13,32,91,144,0,151,17,218,238,71,222,143,176,94,2,190,186,144,215,85,239,213,216,201,239,248,141,58,167,192,102,17,74,89,100,244,240,58,196,221,6,38,198,240,118,17,179,81,43,224,19,69,225,235,87,63,175,48,9,155,225,5,86,227,20,215,252,110,191,75,57,26,245,145,234,166,17,138,168,102,224,29,248,183,167,15,80,195,163,81,76,230,130,0,207,203,157,177,62,120,91,222,164,191,69,164,132,58,2,87,182,57,138,207,237,106,103,177,223,32,212,212,142,32,207,33,45,70,29,171,7,86,22,95,94,91,3,119,148,255,226,32,19,67,137,68,41,237,103,55,155,67,109,211,146,21,96,16,248,17,194,246,192,158,36,94,52,165,102,200,45,195,36,42,232,248,184,138,253,118,187,213,113,160,173,115,165,141,149,254,31,203,122,96,81,231,87,240,160,250,253,163,88,79,119,86,107,138,211,210,212,176,189,238,8,185,172,235,234,84,178,214,238,237,178,101,182,41,11,35,62,162,191,179,102,7,251,18,12,218,31,1,129,106,143,6,46,50,46,165,249,61,204,94,148,63,131,10,242,219,65,18,181,91,237,231,104,6,217,10,196,65,167,0,102,97,206,176,93,26,246,18,52,24,116,219,100,69,233,191,128,146,157,72,238,91,192,140,145,165,216,2,246,146,79,153,7,182,85,146,55,69,116,81,79,58,71,80,232,84,201,246,31,123,216,158,46,251,251,233,203,16,35,5,123,134,169,234,105,7,33,89,11,159,223,93,13,191,190,250,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2501d98-fcfc-4786-9ed5-b96381b1cbae"));
		}

		#endregion

	}

	#endregion

}


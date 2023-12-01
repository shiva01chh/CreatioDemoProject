namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookTypesSchema

	/// <exclude/>
	public class WebHookTypesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookTypesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookTypesSchema(WebHookTypesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3d2ed00b-c1c2-42d1-a51d-b896bc7b6d83");
			Name = "WebHookTypes";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,77,107,220,48,16,61,219,176,255,65,36,23,47,4,255,128,46,189,236,174,155,64,18,8,181,67,15,165,20,89,158,117,68,100,201,29,141,77,76,200,127,175,108,203,235,117,106,122,17,163,249,120,122,243,102,164,121,5,182,230,2,88,6,136,220,154,19,197,7,163,79,178,108,144,147,52,122,19,190,111,194,160,177,82,151,44,237,44,65,181,59,223,15,6,97,190,93,2,32,196,199,189,11,185,224,53,66,233,112,216,65,113,107,191,176,61,183,240,3,242,59,99,94,135,112,221,228,74,10,198,115,75,200,5,49,209,167,45,179,130,247,33,243,140,244,132,166,6,36,9,14,238,105,40,31,227,30,42,37,71,220,146,20,73,11,154,178,174,118,189,245,71,223,71,16,148,64,187,193,176,222,248,240,197,40,91,78,192,142,238,200,100,5,236,55,244,229,253,117,119,1,126,14,39,83,116,198,245,86,128,64,13,106,230,249,63,147,84,178,39,27,223,2,165,252,4,233,31,213,215,69,243,3,219,145,209,199,196,107,2,154,51,216,87,214,114,213,192,69,162,231,125,13,186,24,117,89,138,244,8,244,98,138,117,133,206,98,183,70,22,236,142,235,66,77,106,71,207,22,208,45,128,6,209,79,159,53,139,235,118,183,192,201,141,81,44,195,110,137,112,220,39,111,32,26,50,200,138,124,50,111,216,255,129,199,142,9,187,169,247,185,52,118,3,69,202,144,107,203,135,228,200,235,21,44,223,253,151,234,39,156,131,169,42,185,10,228,39,70,120,86,152,9,78,226,133,69,201,155,128,122,32,12,219,21,106,223,141,82,57,23,175,107,160,143,220,13,94,151,243,252,61,209,7,83,198,9,162,193,111,6,43,78,209,213,79,31,24,219,193,216,237,183,0,107,189,215,198,159,21,254,117,117,195,150,59,227,249,159,184,178,176,88,234,113,78,173,68,106,184,98,110,234,253,71,117,123,120,139,166,169,239,161,139,166,166,60,66,255,81,226,204,164,67,162,239,100,125,209,70,239,210,57,248,54,97,24,254,5,163,162,161,168,86,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3d2ed00b-c1c2-42d1-a51d-b896bc7b6d83"));
		}

		#endregion

	}

	#endregion

}


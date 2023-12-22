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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,77,111,156,48,16,61,179,210,254,7,43,185,176,82,196,15,232,170,151,221,165,137,148,68,138,10,81,15,85,85,25,51,75,172,24,155,142,7,20,20,229,191,215,128,129,37,69,229,128,60,95,207,111,222,140,53,47,193,86,92,0,75,1,145,91,115,166,232,104,244,89,22,53,114,146,70,111,55,239,219,77,80,91,169,11,150,180,150,160,220,79,246,209,32,204,214,37,0,66,116,58,184,144,11,94,35,20,14,135,29,21,183,246,11,59,112,11,63,32,187,51,230,181,15,87,117,166,164,96,60,179,132,92,16,19,93,218,50,43,120,239,51,39,164,39,52,21,32,73,112,112,79,125,249,16,247,80,9,57,226,150,164,136,27,208,148,182,149,235,173,251,117,125,4,65,1,180,239,15,214,31,62,124,49,202,134,19,176,147,251,165,178,4,246,27,186,242,206,220,95,128,79,225,120,140,206,184,254,20,32,80,141,154,121,254,207,36,149,236,200,70,183,64,9,63,67,242,71,117,117,225,124,193,110,96,244,49,242,26,129,230,12,246,149,53,92,213,112,145,232,121,95,131,206,7,93,150,34,61,2,189,152,124,93,161,73,236,198,200,156,221,113,157,171,81,237,240,217,2,186,5,208,32,186,233,179,122,97,238,246,11,156,204,24,197,82,108,151,8,167,67,252,6,162,38,131,44,207,198,227,13,251,63,240,208,49,97,59,246,62,151,70,110,160,72,41,114,109,121,159,28,122,189,130,229,189,255,82,253,132,115,52,101,41,87,129,252,196,8,39,133,153,224,36,94,88,24,191,9,168,122,194,176,91,161,246,221,40,149,113,241,186,6,250,200,221,224,117,49,207,223,19,125,48,69,20,35,26,252,102,176,228,20,94,253,244,129,161,29,140,220,126,11,176,214,123,109,244,89,225,95,87,55,108,185,51,158,255,153,43,11,139,165,30,230,212,72,164,154,43,230,166,222,61,84,183,135,183,104,234,234,30,218,112,108,202,35,116,15,37,74,77,210,39,250,78,214,23,109,240,46,157,189,111,187,185,248,254,2,214,151,126,244,95,4,0,0 };
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


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RootAccountInfoRequestSchema

	/// <exclude/>
	public class RootAccountInfoRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RootAccountInfoRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RootAccountInfoRequestSchema(RootAccountInfoRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ab1e6279-d876-431e-a833-76ede3fe1e04");
			Name = "RootAccountInfoRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e340cd47-dd91-41d9-9076-90ff98ffd14e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,148,77,107,194,64,16,134,207,21,252,15,3,94,139,185,87,17,36,133,18,40,173,248,113,42,61,172,155,73,92,136,187,233,236,68,17,233,127,239,102,19,211,88,106,209,182,230,144,100,38,243,190,243,236,238,16,45,214,104,115,33,17,230,72,36,172,73,184,31,26,157,168,180,32,193,202,232,110,103,223,237,116,59,55,61,194,212,133,16,102,194,218,59,152,26,195,99,41,77,161,57,210,137,153,226,91,129,150,125,101,16,4,48,180,197,122,45,104,55,170,227,251,249,51,80,85,3,137,33,16,149,180,127,40,15,90,245,121,177,204,148,4,89,54,58,217,231,166,162,106,176,38,100,114,36,86,232,216,38,222,160,250,254,21,198,39,30,144,45,56,10,91,62,121,133,32,9,203,197,194,98,250,216,111,84,109,166,3,148,101,82,58,133,176,170,95,80,6,123,72,145,7,165,213,0,222,207,237,41,96,35,178,2,65,233,88,73,231,228,44,183,43,116,36,4,47,121,25,29,128,148,182,44,180,196,215,159,177,150,198,100,48,113,194,26,44,170,101,191,163,107,239,136,204,20,106,6,21,187,187,74,20,210,37,251,19,122,113,20,255,27,134,69,151,224,203,17,102,94,247,119,140,106,27,120,231,190,208,198,29,214,133,243,18,213,242,153,87,95,99,122,120,165,108,51,52,224,222,133,100,181,193,51,166,39,178,99,95,122,125,36,237,78,66,26,58,5,229,51,222,173,9,1,134,114,196,84,224,48,144,35,80,201,105,207,1,152,178,233,86,89,188,45,69,137,200,172,87,181,154,125,122,31,175,255,9,57,116,22,223,109,64,15,117,92,253,104,124,92,101,143,147,62,87,94,31,196,174,0,142,82,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ab1e6279-d876-431e-a833-76ede3fe1e04"));
		}

		#endregion

	}

	#endregion

}


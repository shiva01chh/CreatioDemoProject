namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEsnSecurityEngineSchema

	/// <exclude/>
	public class IEsnSecurityEngineSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEsnSecurityEngineSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEsnSecurityEngineSchema(IEsnSecurityEngineSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9c30106-e300-4bc7-ad30-d1a26877b5c8");
			Name = "IEsnSecurityEngine";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,86,77,139,219,48,16,61,111,32,255,97,216,94,90,88,226,123,55,53,44,174,217,230,208,178,212,237,15,80,228,113,34,214,150,204,140,180,105,40,253,239,29,249,99,137,55,105,105,217,182,132,250,96,172,97,230,205,123,79,194,35,171,26,228,86,105,132,79,72,164,216,85,126,145,57,91,153,77,32,229,141,179,139,188,248,48,159,125,157,207,46,2,27,187,129,98,207,30,155,235,249,76,34,47,8,55,146,2,176,178,30,169,18,148,215,176,202,217,22,168,3,25,191,207,237,198,88,236,82,147,36,129,37,135,166,81,180,79,135,245,29,185,7,83,34,67,131,126,235,74,134,202,17,232,45,234,251,216,168,69,106,12,115,196,247,14,48,118,104,201,48,2,59,109,84,13,22,253,206,209,189,20,51,171,13,242,98,236,146,28,180,105,195,186,54,26,204,200,239,36,189,139,168,238,136,97,23,200,34,27,216,109,133,32,18,200,11,2,203,199,86,49,40,173,165,115,228,70,168,209,60,96,228,40,168,19,66,199,140,250,72,171,72,53,96,197,252,55,151,44,146,27,245,121,85,94,166,69,247,57,34,128,196,22,203,164,203,61,93,218,119,140,149,249,164,55,152,105,225,218,185,26,50,101,63,162,42,251,204,247,125,226,203,219,96,74,120,100,112,5,221,122,132,125,117,29,139,159,103,78,235,216,199,237,28,152,157,161,41,25,161,242,248,203,134,252,25,59,180,107,26,65,61,91,59,178,158,223,223,182,3,75,115,166,167,227,168,112,200,187,9,242,175,162,88,63,156,24,80,93,228,71,118,230,162,240,78,54,253,231,78,14,203,39,61,158,239,111,137,53,254,231,6,191,141,18,241,31,89,140,95,100,144,88,153,62,39,188,30,230,210,239,58,221,85,13,82,59,191,39,48,162,58,10,168,12,210,177,123,132,62,144,229,116,169,83,79,1,151,137,78,193,84,61,55,195,253,212,139,100,197,188,41,241,117,240,79,232,198,252,49,231,10,4,176,82,92,247,136,46,170,223,201,228,21,2,99,199,199,13,184,69,255,78,113,113,40,34,31,96,110,58,103,134,77,153,170,28,93,255,214,95,35,208,150,253,77,98,62,235,34,135,207,119,4,27,70,31,161,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9c30106-e300-4bc7-ad30-d1a26877b5c8"));
		}

		#endregion

	}

	#endregion

}


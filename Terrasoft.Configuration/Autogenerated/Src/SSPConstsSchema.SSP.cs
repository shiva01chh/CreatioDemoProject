namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SSPConstsSchema

	/// <exclude/>
	public class SSPConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SSPConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SSPConstsSchema(SSPConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("baddafff-9580-40c5-a726-cdd52e87d9ee");
			Name = "SSPConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("39b1aa09-c30c-47e9-9379-18a9c48e3a0f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,221,110,194,32,20,128,175,109,210,119,32,94,109,23,248,211,210,86,99,118,65,91,186,120,165,153,238,1,88,139,13,73,11,13,80,157,51,190,251,168,186,57,119,177,27,71,66,194,207,57,31,95,14,167,213,92,148,96,181,215,134,213,51,215,113,29,65,107,166,27,154,51,176,102,74,81,45,55,102,144,72,177,225,101,171,168,225,82,184,206,193,117,122,77,251,86,241,28,104,99,207,114,144,87,84,107,176,90,45,109,164,54,218,222,31,58,86,175,55,28,130,23,86,114,109,206,185,128,213,148,87,192,190,213,84,212,48,192,11,38,12,223,112,166,6,93,244,45,84,49,90,72,81,237,193,115,203,139,27,12,233,40,235,11,100,94,128,39,32,216,238,20,246,208,199,65,154,18,148,132,48,74,253,41,68,145,55,130,24,219,237,132,144,40,246,67,130,179,24,247,31,103,223,114,53,23,5,104,172,254,78,170,226,46,191,92,110,153,218,47,47,168,191,28,17,74,18,60,137,17,12,166,169,7,17,33,62,140,73,128,96,138,162,140,100,97,226,71,94,124,117,156,139,45,55,247,150,239,10,249,23,177,179,26,46,108,245,206,191,34,21,216,216,201,222,13,83,130,86,64,170,146,10,254,113,233,152,191,221,110,48,153,84,139,31,185,11,177,148,202,208,202,118,232,41,236,85,112,243,75,58,204,166,56,11,71,30,244,177,103,165,131,32,129,241,40,8,161,151,100,99,228,161,113,54,69,254,151,244,209,117,142,221,162,27,159,136,100,15,248,251,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("baddafff-9580-40c5-a726-cdd52e87d9ee"));
		}

		#endregion

	}

	#endregion

}


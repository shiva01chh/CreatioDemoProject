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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,221,110,194,32,20,128,175,109,210,119,32,94,109,23,248,211,210,214,198,236,130,182,176,120,165,153,238,1,88,139,134,164,130,1,170,115,198,119,31,85,55,231,46,118,227,72,72,248,57,231,227,203,225,52,70,200,21,152,239,141,229,235,177,239,249,158,100,107,110,54,172,228,96,193,181,102,70,45,109,47,87,114,41,86,141,102,86,40,233,123,7,223,235,108,154,183,90,148,192,88,119,86,130,178,102,198,128,249,124,230,34,141,53,238,254,208,178,58,157,126,31,188,240,149,48,246,156,11,248,154,137,26,184,183,54,53,179,28,136,138,75,43,150,130,235,94,27,125,11,213,156,85,74,214,123,240,220,136,234,6,67,90,202,226,2,153,84,224,9,72,190,59,133,61,116,113,84,20,4,229,49,76,138,48,133,40,9,6,16,99,183,29,17,146,100,97,76,48,205,112,247,113,252,45,183,22,178,2,27,167,191,83,186,186,203,175,84,91,174,247,179,11,234,47,71,132,242,28,143,50,4,163,180,8,32,34,36,132,25,137,16,44,80,66,9,141,243,48,9,178,171,227,68,110,133,189,183,124,87,200,191,136,157,213,112,229,170,119,254,21,165,193,210,77,254,110,185,150,172,6,74,175,152,20,31,151,142,249,219,237,6,67,149,158,254,200,157,202,153,210,150,213,174,67,79,97,175,82,216,95,210,49,77,49,141,7,1,12,113,224,164,163,40,135,217,32,138,97,144,211,33,10,208,144,166,40,252,146,62,250,222,177,93,184,241,9,241,145,160,98,250,2,0,0 };
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


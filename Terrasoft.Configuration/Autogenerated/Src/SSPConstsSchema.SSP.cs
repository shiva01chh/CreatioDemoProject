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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,201,110,194,48,16,64,207,68,202,63,88,156,218,131,89,18,39,1,161,30,156,196,169,56,129,10,253,0,55,49,145,165,196,142,108,7,74,17,255,94,179,180,64,15,92,168,37,75,94,102,158,159,198,211,106,46,74,176,216,106,195,234,137,235,184,142,160,53,211,13,205,25,88,50,165,168,150,43,211,75,164,88,241,178,85,212,112,41,92,103,231,58,157,166,253,168,120,14,180,177,103,57,200,43,170,53,88,44,230,54,82,27,109,239,119,7,86,167,211,239,131,55,86,114,109,78,185,128,213,148,87,192,190,213,84,212,48,192,11,38,12,95,113,166,122,135,232,91,168,98,180,144,162,218,130,215,150,23,55,24,114,160,44,207,144,105,1,94,128,96,155,99,216,83,23,7,105,74,80,18,194,40,245,199,16,69,222,0,98,108,183,35,66,162,216,15,9,206,98,220,125,158,252,202,213,92,20,160,177,250,27,169,138,135,252,114,185,102,106,59,63,163,238,57,34,148,36,120,20,35,24,140,83,15,34,66,124,24,147,0,193,20,69,25,201,194,196,143,188,248,226,56,21,107,110,30,45,223,5,242,47,98,39,53,92,216,234,157,126,69,42,176,178,147,125,26,166,4,173,128,84,37,21,252,235,220,49,247,221,110,48,153,84,179,171,220,153,152,75,101,104,101,59,244,24,246,46,184,249,35,29,102,99,156,133,3,15,250,216,179,210,65,144,192,120,16,132,208,75,178,33,242,208,48,27,35,255,71,122,239,58,251,195,226,122,124,3,222,156,156,181,3,3,0,0 };
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


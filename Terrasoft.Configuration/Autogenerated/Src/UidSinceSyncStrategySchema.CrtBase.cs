namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UidSinceSyncStrategySchema

	/// <exclude/>
	public class UidSinceSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UidSinceSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UidSinceSyncStrategySchema(UidSinceSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ea1a0baf-434e-4325-bd23-753efc693955");
			Name = "UidSinceSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,77,111,218,64,16,61,27,137,255,48,114,47,32,33,220,51,9,28,66,83,41,135,68,169,92,78,85,15,139,61,118,87,181,119,173,217,113,133,133,248,239,157,181,129,216,212,148,131,241,142,223,124,188,247,102,141,42,209,85,42,65,248,142,68,202,217,140,151,175,74,23,211,201,113,58,9,106,167,77,222,251,178,181,38,211,121,77,138,181,53,15,163,0,194,123,241,229,179,97,205,26,221,93,192,87,149,176,165,14,33,152,79,132,185,244,129,109,161,156,91,193,78,167,177,54,9,198,141,73,98,150,25,48,111,90,92,20,69,240,232,234,178,84,212,108,174,103,68,72,8,179,117,248,210,79,8,163,13,232,178,42,176,68,195,74,179,53,11,72,177,208,127,144,48,133,140,108,217,79,149,150,79,202,97,122,83,97,121,105,18,221,118,37,148,227,111,119,57,143,229,67,45,1,96,11,14,11,76,24,84,81,128,120,224,84,142,14,180,73,241,32,255,237,32,206,179,21,152,97,72,37,245,163,107,175,203,143,47,152,169,186,224,39,201,20,69,103,220,84,104,179,217,128,243,124,1,111,98,51,172,33,28,211,48,156,255,148,66,85,189,47,116,2,137,215,122,84,106,88,141,210,145,212,99,235,194,213,174,119,178,21,18,55,43,255,198,66,17,211,14,112,235,83,27,136,81,81,242,11,240,80,145,136,224,243,25,197,159,51,223,127,101,14,170,75,81,176,98,26,233,84,36,98,242,219,180,51,78,6,123,117,121,87,243,91,141,212,128,95,227,32,200,145,207,111,1,33,215,100,32,140,95,222,182,207,112,252,124,10,31,218,15,39,255,60,157,169,160,73,59,54,67,106,178,255,210,171,246,91,42,11,249,222,74,246,31,110,75,15,188,67,163,141,84,138,84,9,70,204,89,135,178,22,36,245,141,112,147,86,225,102,39,103,72,174,129,229,99,212,162,199,147,61,241,24,153,69,6,23,110,122,27,236,239,242,222,30,226,254,119,127,5,132,135,18,131,7,85,207,43,48,102,254,108,55,152,14,134,195,46,160,189,218,13,244,199,152,183,170,174,96,47,27,51,187,197,15,128,157,51,227,210,119,209,126,48,152,78,36,216,251,253,5,99,134,238,31,195,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea1a0baf-434e-4325-bd23-753efc693955"));
		}

		#endregion

	}

	#endregion

}


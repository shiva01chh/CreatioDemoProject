namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SecurityTokenCleanerSchema

	/// <exclude/>
	public class SecurityTokenCleanerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SecurityTokenCleanerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SecurityTokenCleanerSchema(SecurityTokenCleanerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0104f03c-a574-4da3-bbd9-fc323cbac58a");
			Name = "SecurityTokenCleaner";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,65,110,194,48,16,60,7,137,63,172,232,5,36,148,220,91,154,11,160,138,74,149,80,129,7,56,201,66,77,29,59,242,58,20,132,250,247,110,236,148,146,22,213,167,245,204,120,60,222,181,22,37,82,37,114,132,53,90,43,200,108,93,60,53,122,43,119,181,21,78,26,221,239,157,251,189,168,38,169,119,176,58,145,195,146,121,165,48,111,72,138,159,80,163,149,249,195,69,115,109,99,145,113,102,238,44,238,88,13,83,37,136,224,30,86,152,215,86,186,211,218,188,163,158,42,20,236,225,133,73,146,192,132,234,178,20,246,148,182,251,87,172,44,18,106,71,32,32,15,98,216,155,12,182,198,2,30,43,105,177,0,106,29,193,53,150,20,127,123,37,87,102,85,157,41,153,179,69,19,226,86,4,78,182,120,54,217,252,200,156,51,156,40,58,251,84,151,252,47,232,222,76,209,188,96,233,189,2,251,59,180,7,102,168,208,33,253,23,240,111,194,128,84,194,138,18,52,15,230,113,80,19,90,30,135,14,237,30,164,27,222,67,126,1,226,73,226,213,183,15,251,154,83,88,26,164,203,75,221,57,211,246,228,32,173,171,133,130,131,145,5,132,247,227,112,211,185,27,186,81,198,176,152,73,95,113,246,9,57,203,179,31,131,201,246,76,167,240,115,243,8,154,239,19,69,26,63,186,61,223,56,169,164,147,72,195,174,241,40,14,173,155,135,198,121,45,13,71,205,7,139,62,219,113,160,46,194,68,252,62,160,93,144,49,94,95,7,142,81,39,221,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0104f03c-a574-4da3-bbd9-fc323cbac58a"));
		}

		#endregion

	}

	#endregion

}


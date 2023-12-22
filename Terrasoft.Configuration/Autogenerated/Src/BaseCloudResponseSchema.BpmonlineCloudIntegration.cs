namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCloudResponseSchema

	/// <exclude/>
	public class BaseCloudResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCloudResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCloudResponseSchema(BaseCloudResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4d2a5529-1027-4e39-b5d9-500029d6ce6b");
			Name = "BaseCloudResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,201,110,194,48,16,134,207,32,241,14,35,184,86,228,206,118,104,84,85,61,32,161,194,11,24,103,18,172,38,118,234,177,139,42,196,187,119,236,132,165,45,180,180,185,56,158,229,159,111,198,182,22,21,82,45,36,194,10,173,21,100,114,55,76,141,206,85,225,173,112,202,232,97,250,176,156,155,12,75,234,117,119,189,110,175,219,25,88,44,216,1,105,41,136,70,112,47,8,211,210,248,236,153,133,140,38,140,65,73,146,192,132,124,85,9,251,62,107,247,49,1,114,99,97,205,57,96,219,120,200,173,169,128,203,192,86,185,13,72,83,85,172,94,91,83,163,117,10,105,120,144,75,206,244,106,191,46,149,4,25,37,47,32,116,26,214,35,236,226,40,55,130,69,204,109,252,95,57,163,225,17,29,129,128,55,81,122,4,165,51,37,121,20,186,128,237,6,221,6,45,184,141,162,19,62,255,147,151,18,41,146,126,71,109,44,81,236,184,5,152,200,153,179,30,39,137,156,129,202,97,233,132,243,4,248,234,69,73,208,55,47,253,49,152,80,108,171,8,239,66,116,206,142,24,126,86,229,36,218,206,99,109,76,9,79,180,108,120,96,23,92,157,2,29,236,152,215,121,171,15,133,166,211,182,200,62,132,236,127,27,6,159,25,133,149,137,128,162,194,237,189,134,58,161,69,203,205,33,185,102,88,152,157,245,7,125,190,123,198,246,127,104,140,156,13,39,208,210,239,128,123,26,7,164,216,192,237,236,124,217,73,20,120,59,252,234,98,210,53,188,121,19,249,127,190,227,165,146,252,228,254,70,121,45,245,27,171,210,14,82,142,185,68,57,64,157,53,47,38,238,27,235,103,99,180,157,127,31,164,157,239,149,67,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4d2a5529-1027-4e39-b5d9-500029d6ce6b"));
		}

		#endregion

	}

	#endregion

}


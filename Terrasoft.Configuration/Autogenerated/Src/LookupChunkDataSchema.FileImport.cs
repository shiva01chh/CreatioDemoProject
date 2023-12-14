namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LookupChunkDataSchema

	/// <exclude/>
	public class LookupChunkDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LookupChunkDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LookupChunkDataSchema(LookupChunkDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c8fe945c-3ca6-454e-abfa-54dbb19e8a55");
			Name = "LookupChunkData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,141,65,10,194,48,16,69,215,6,114,135,156,160,23,112,89,17,4,5,209,226,126,154,78,53,52,201,196,76,178,18,239,110,66,237,166,29,254,234,191,247,25,15,14,57,128,70,213,97,140,192,52,166,166,37,63,154,103,142,144,12,249,230,104,44,158,92,160,152,164,248,72,177,11,185,183,70,43,109,129,89,157,137,166,28,218,87,246,211,1,18,20,92,149,197,153,233,3,108,70,238,232,26,73,35,243,5,29,250,68,106,85,223,19,36,220,111,198,127,138,195,172,47,227,85,189,25,247,68,182,126,48,67,1,55,124,103,19,113,104,201,102,231,185,122,95,41,74,164,168,247,3,100,48,252,92,3,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c8fe945c-3ca6-454e-abfa-54dbb19e8a55"));
		}

		#endregion

	}

	#endregion

}


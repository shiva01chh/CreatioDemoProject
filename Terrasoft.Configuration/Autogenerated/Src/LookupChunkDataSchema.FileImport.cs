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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,141,65,10,194,48,16,69,215,6,114,135,156,160,23,112,89,17,4,5,209,226,126,154,78,53,52,201,196,76,102,37,222,221,150,90,144,58,252,213,127,239,51,17,2,114,2,139,166,193,156,129,169,47,85,77,177,119,119,201,80,28,197,106,239,60,30,66,162,92,180,122,105,181,73,210,122,103,141,245,192,108,142,68,131,164,250,33,113,216,65,129,17,79,202,226,204,244,6,94,144,27,58,103,178,200,124,194,128,177,144,89,213,215,2,5,183,127,227,47,197,110,214,151,241,170,254,27,183,68,126,250,224,186,17,92,240,41,46,99,87,147,151,16,121,242,222,90,141,209,234,247,62,181,51,216,160,11,1,0,0 };
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


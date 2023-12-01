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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,141,65,10,194,48,16,69,215,6,114,135,156,160,23,112,89,17,4,5,209,226,126,154,76,53,52,201,196,76,178,18,239,110,74,237,166,29,254,234,191,247,153,0,30,57,130,70,213,97,74,192,52,228,166,165,48,216,103,73,144,45,133,230,104,29,158,124,164,148,165,248,72,177,139,165,119,86,43,237,128,89,157,137,198,18,219,87,9,227,1,50,84,60,41,139,51,211,7,184,130,220,209,53,145,70,230,11,122,12,153,212,170,190,103,200,184,223,140,255,20,205,172,47,227,85,189,25,247,68,110,250,96,77,5,55,124,23,155,208,180,228,138,15,60,121,95,41,106,164,168,247,3,151,16,48,64,2,1,0,0 };
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


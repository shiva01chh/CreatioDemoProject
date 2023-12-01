namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDuplicatesCountResponseSchema

	/// <exclude/>
	public class BulkDuplicatesCountResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDuplicatesCountResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDuplicatesCountResponseSchema(BulkDuplicatesCountResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1b8e96c8-ec0b-4b5d-87fb-133c37e8eac7");
			Name = "BulkDuplicatesCountResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,145,77,79,131,64,16,134,207,37,225,63,76,218,139,94,224,46,216,131,52,225,84,109,218,222,140,135,45,12,184,186,236,146,253,48,169,141,255,221,89,72,91,165,68,147,114,89,102,246,125,103,230,217,145,172,65,211,178,2,97,139,90,51,163,42,27,101,74,86,188,118,154,89,174,100,24,28,194,96,226,12,151,53,108,246,198,98,147,12,98,210,11,129,133,23,155,40,71,137,154,23,127,106,158,118,111,244,187,84,37,138,11,221,218,73,203,27,140,54,84,133,9,254,217,205,64,42,210,205,52,214,20,64,38,152,49,119,240,224,196,251,194,181,130,23,204,162,201,181,114,237,154,80,168,1,118,242,231,5,179,140,80,172,102,133,125,161,68,235,118,36,134,194,219,7,238,76,81,219,179,123,226,145,79,253,86,90,181,168,45,71,106,186,234,106,116,245,39,113,28,67,106,92,211,48,189,159,31,19,57,90,3,74,131,241,167,125,69,144,174,217,161,6,85,65,237,71,52,209,201,26,15,189,233,7,19,14,231,219,49,87,26,247,151,94,219,145,45,209,43,110,30,105,127,112,15,211,94,214,113,76,111,61,237,17,87,40,122,220,252,124,11,7,168,209,38,126,192,4,190,174,35,41,79,15,7,92,94,201,53,90,227,63,202,242,247,198,70,72,7,59,29,163,157,161,44,251,213,82,212,231,126,166,194,128,114,244,125,3,3,167,205,153,26,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b8e96c8-ec0b-4b5d-87fb-133c37e8eac7"));
		}

		#endregion

	}

	#endregion

}


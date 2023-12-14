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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,145,77,79,195,48,12,134,207,171,180,255,96,109,23,184,180,119,58,118,96,147,122,26,76,219,110,136,67,154,122,37,144,38,85,62,144,198,196,127,199,105,181,14,186,10,164,245,146,218,121,95,219,79,172,88,133,182,102,28,97,135,198,48,171,247,46,94,104,181,23,165,55,204,9,173,198,209,113,28,141,188,21,170,132,237,193,58,172,210,94,76,122,41,145,7,177,141,51,84,104,4,255,83,243,148,191,209,239,74,23,40,47,116,27,175,156,168,48,222,82,21,38,197,103,51,3,169,72,55,53,88,82,0,11,201,172,189,131,7,47,223,151,190,150,130,51,135,54,51,218,215,27,66,161,6,216,200,159,151,204,49,66,113,134,113,247,66,137,218,231,36,6,30,236,61,247,66,83,219,179,123,20,144,187,126,107,163,107,52,78,32,53,93,55,53,154,250,163,36,73,96,102,125,85,49,115,152,159,18,25,58,11,218,128,13,167,123,69,80,190,202,209,128,222,67,25,70,180,113,103,77,250,222,217,7,147,30,231,187,33,215,44,105,47,131,182,33,91,97,80,220,60,210,254,224,30,38,173,172,225,152,220,6,218,19,174,212,244,184,217,249,22,142,80,162,75,195,128,41,124,93,71,82,116,15,7,66,93,201,53,88,227,63,202,226,247,198,6,72,123,59,29,162,157,162,42,218,213,82,212,230,126,166,198,17,229,194,247,13,142,154,71,171,27,3,0,0 };
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


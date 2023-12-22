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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,145,77,79,131,64,16,134,207,144,244,63,76,218,139,94,224,46,216,131,109,194,169,218,180,189,25,15,91,24,112,117,217,37,251,97,82,27,255,187,179,144,210,138,68,147,114,89,102,246,125,103,230,217,145,172,70,211,176,28,97,135,90,51,163,74,27,45,148,44,121,229,52,179,92,201,73,120,156,132,129,51,92,86,176,61,24,139,117,50,136,73,47,4,230,94,108,162,12,37,106,158,255,169,121,218,191,209,239,74,21,40,126,233,54,78,90,94,99,180,165,42,76,240,207,118,6,82,145,110,166,177,162,0,22,130,25,115,7,15,78,188,47,93,35,120,206,44,154,76,43,215,108,8,133,26,96,43,127,94,50,203,8,197,106,150,219,23,74,52,110,79,98,200,189,125,224,94,40,106,123,118,7,30,185,239,183,214,170,65,109,57,82,211,117,91,163,173,31,196,113,12,169,113,117,205,244,97,126,74,100,104,13,40,13,198,159,246,21,65,186,122,143,26,84,9,149,31,209,68,189,53,30,122,211,15,38,28,206,119,99,174,52,238,46,189,182,37,91,161,87,220,60,210,254,224,30,166,157,172,229,152,222,122,218,19,174,80,244,184,217,249,22,142,80,161,77,252,128,9,124,93,71,82,244,15,7,92,94,201,53,90,227,63,202,226,231,198,70,72,7,59,29,163,157,161,44,186,213,82,212,229,46,83,147,144,114,151,223,55,199,233,10,219,35,3,0,0 };
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


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IndexedDataConfigSchema

	/// <exclude/>
	public class IndexedDataConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IndexedDataConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IndexedDataConfigSchema(IndexedDataConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5326868b-e6e3-4b52-8fc8-2345a24cdc02");
			Name = "IndexedDataConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30c103fe-34c6-441e-895c-acadc354f737");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,10,194,48,12,134,207,14,246,14,5,175,178,7,80,241,226,96,236,60,111,226,33,235,226,44,116,169,36,29,40,226,187,219,173,10,234,52,244,146,240,241,255,31,37,232,80,206,160,81,237,144,25,196,29,125,182,117,116,52,109,207,224,141,163,172,176,174,6,91,33,176,62,165,201,45,77,102,189,24,106,85,117,21,143,93,128,173,69,61,144,146,21,72,200,70,175,210,36,80,115,198,54,92,213,214,130,200,82,149,212,224,5,155,28,60,196,252,128,132,119,238,107,107,180,210,3,52,101,212,82,229,102,12,7,190,174,197,115,40,94,188,176,42,214,70,114,19,178,6,183,123,140,157,35,53,177,255,185,255,148,249,72,248,239,243,141,13,61,47,48,58,237,15,170,108,201,49,54,225,59,250,142,100,21,85,166,38,227,241,125,30,231,203,94,242,129,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5326868b-e6e3-4b52-8fc8-2345a24cdc02"));
		}

		#endregion

	}

	#endregion

}


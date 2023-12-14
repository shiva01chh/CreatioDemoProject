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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,203,10,194,48,16,69,215,22,250,15,129,110,165,31,160,226,198,66,113,93,119,226,98,76,199,26,72,39,101,38,5,69,252,119,19,99,23,190,134,108,102,56,220,123,8,65,143,50,128,70,181,67,102,16,119,242,229,198,209,201,116,35,131,55,142,202,218,186,35,216,6,129,245,57,207,110,121,54,27,197,80,167,154,171,120,236,3,108,45,234,72,74,89,35,33,27,189,204,179,64,21,140,93,184,170,141,5,145,133,218,82,139,23,108,43,240,144,242,3,18,222,48,30,173,209,74,71,232,155,81,11,85,153,103,56,240,117,37,158,67,241,124,194,154,84,155,200,117,200,138,110,247,20,91,32,181,169,255,181,255,148,121,75,248,239,243,137,197,158,9,76,78,251,131,218,118,228,24,219,240,29,99,79,178,76,42,223,38,207,99,156,7,25,243,99,208,121,1,0,0 };
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


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,77,11,194,48,12,134,207,14,246,31,10,94,101,63,64,197,139,130,120,158,55,241,144,117,113,22,186,116,36,29,56,196,255,110,102,245,224,87,232,37,225,225,125,31,74,208,162,116,96,209,236,145,25,36,156,98,177,14,116,114,77,207,16,93,160,98,235,67,5,190,68,96,123,206,179,107,158,77,122,113,212,152,114,144,136,173,194,222,163,29,73,41,182,72,200,206,46,242,76,169,41,99,163,87,179,246,32,50,55,59,170,241,130,245,6,34,164,124,69,244,117,125,229,157,53,118,132,190,25,51,55,27,247,8,7,30,150,18,89,139,103,47,172,76,181,137,92,105,214,232,118,75,177,83,164,58,245,63,247,159,50,111,9,255,125,62,177,177,231,5,38,167,195,209,236,26,10,140,181,126,71,223,146,44,146,202,183,201,227,168,115,7,201,158,143,12,120,1,0,0 };
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


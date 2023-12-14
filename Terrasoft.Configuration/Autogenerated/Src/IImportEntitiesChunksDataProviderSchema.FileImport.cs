namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportEntitiesChunksDataProviderSchema

	/// <exclude/>
	public class IImportEntitiesChunksDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportEntitiesChunksDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportEntitiesChunksDataProviderSchema(IImportEntitiesChunksDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2a8003b9-4985-421c-aeb6-96632952b722");
			Name = "IImportEntitiesChunksDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,65,110,194,48,16,60,23,137,63,172,224,210,74,40,185,151,144,11,165,40,135,74,8,250,1,199,217,128,213,196,142,214,54,20,161,254,189,182,3,81,202,129,28,154,219,142,103,118,103,199,142,100,53,234,134,113,132,79,36,98,90,149,38,90,42,89,138,189,37,102,132,146,209,187,168,48,171,27,69,102,60,186,140,71,79,86,11,185,135,221,89,27,172,231,119,181,147,86,21,114,175,211,209,26,37,146,224,142,227,88,83,194,189,67,33,147,6,169,116,243,94,33,107,187,174,164,17,70,160,94,30,172,252,210,111,204,176,13,169,163,40,144,130,48,142,99,72,180,173,107,70,231,244,90,183,66,40,28,23,154,43,25,74,69,142,136,8,156,176,92,76,134,215,137,194,228,115,152,235,199,78,32,78,163,219,196,184,55,178,177,121,37,56,136,155,245,97,231,221,114,93,243,219,73,210,226,30,10,103,201,157,137,52,133,75,216,187,75,236,3,205,65,21,186,5,239,211,8,192,142,29,209,185,115,1,212,97,71,96,185,178,198,39,195,81,135,219,33,117,2,66,109,43,19,117,93,250,27,62,193,81,137,34,52,218,180,42,44,182,234,244,188,182,14,229,222,91,86,204,124,0,190,83,38,11,252,158,65,174,84,5,218,114,207,134,5,24,178,248,50,127,224,114,139,134,4,58,167,188,123,35,112,18,230,48,232,92,63,182,158,173,164,173,145,88,94,97,210,55,191,13,162,20,214,104,250,176,254,179,212,128,227,90,253,59,217,16,108,219,105,216,198,20,101,209,94,123,168,127,218,95,167,7,58,196,127,191,93,205,100,57,182,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a8003b9-4985-421c-aeb6-96632952b722"));
		}

		#endregion

	}

	#endregion

}


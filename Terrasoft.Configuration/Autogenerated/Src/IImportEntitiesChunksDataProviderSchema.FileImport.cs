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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,65,110,194,48,16,60,23,137,63,172,224,210,74,40,185,151,144,11,165,40,135,74,8,250,1,199,222,128,213,196,142,214,54,20,161,254,189,142,3,81,202,129,28,154,219,142,103,118,103,199,142,98,21,154,154,113,132,79,36,98,70,23,54,90,106,85,200,189,35,102,165,86,209,187,44,49,171,106,77,118,60,186,140,71,79,206,72,181,135,221,217,88,172,230,119,181,151,150,37,242,70,103,162,53,42,36,201,61,199,179,166,132,123,143,66,166,44,82,225,231,189,66,214,118,93,41,43,173,68,179,60,56,245,101,222,152,101,27,210,71,41,144,130,48,142,99,72,140,171,42,70,231,244,90,183,66,16,158,11,245,149,12,133,38,79,68,4,78,88,44,38,195,235,68,97,242,57,204,109,198,78,32,78,163,219,196,184,55,178,118,121,41,57,200,155,245,97,231,221,114,93,243,219,73,210,226,13,20,206,146,59,19,105,10,151,176,119,151,216,7,218,131,22,166,5,239,211,8,192,142,29,209,187,243,1,84,97,71,96,185,118,182,73,134,163,9,183,67,250,4,132,198,149,54,234,186,244,55,124,130,163,150,34,52,218,180,42,20,91,125,122,94,59,143,242,198,91,38,102,77,0,77,167,76,9,252,158,65,174,117,9,198,241,134,13,11,176,228,240,101,254,192,229,22,45,73,244,78,121,247,70,224,36,237,97,208,185,121,108,61,91,41,87,33,177,188,196,164,111,126,27,68,41,172,209,246,97,243,103,169,1,199,149,254,119,178,33,216,182,211,176,141,41,42,209,94,123,168,127,218,95,167,7,122,196,127,191,207,239,20,104,181,3,0,0 };
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


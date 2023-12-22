namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportEntitiesDataProviderSchema

	/// <exclude/>
	public class IImportEntitiesDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportEntitiesDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportEntitiesDataProviderSchema(IImportEntitiesDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("18959618-7987-4279-b581-a64c3683bed3");
			Name = "IImportEntitiesDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,219,110,226,48,16,125,46,18,255,48,162,47,172,84,145,247,109,54,210,114,105,139,170,106,81,169,250,238,36,19,106,213,177,163,177,157,85,84,237,191,239,56,129,82,82,64,32,68,72,230,92,230,140,237,104,81,162,173,68,134,240,130,68,194,154,194,77,102,70,23,114,227,73,56,105,244,228,78,42,92,150,149,33,55,28,124,12,7,87,222,74,189,129,117,99,29,150,183,189,123,166,42,133,89,224,217,201,61,106,36,153,49,134,81,149,79,149,204,64,106,135,84,4,187,101,167,185,208,78,58,137,118,46,156,88,145,169,101,142,196,240,143,150,116,117,77,184,97,45,120,66,247,102,114,251,19,86,173,76,87,140,162,8,98,235,203,82,80,147,236,30,204,20,10,178,144,179,28,20,100,74,152,250,162,64,194,252,139,93,3,78,164,10,33,109,160,234,44,115,136,43,65,162,36,44,64,243,68,126,141,100,11,95,163,181,236,191,204,71,16,125,90,196,81,223,180,35,159,96,38,113,212,150,91,116,109,100,222,246,168,143,244,197,99,24,223,123,6,244,36,126,220,158,9,60,71,133,14,193,168,29,13,112,171,53,185,176,225,66,234,109,23,171,240,148,213,200,222,121,157,157,234,252,143,234,53,253,44,254,134,229,27,7,82,28,2,220,64,95,47,129,83,46,103,195,45,181,69,78,212,11,6,206,64,158,94,26,175,250,180,59,12,244,13,248,142,13,111,95,95,234,99,64,66,231,73,91,46,236,254,133,82,106,140,130,181,168,241,112,32,47,102,62,29,247,195,194,190,17,158,207,66,251,18,41,108,195,184,3,118,214,9,236,187,56,59,153,217,27,102,239,32,106,33,85,187,151,153,6,89,199,227,171,215,238,210,241,236,253,102,129,54,74,30,191,41,157,28,198,51,90,175,28,212,66,73,62,112,56,57,50,156,215,109,237,241,208,102,204,47,2,232,89,239,242,94,163,206,187,115,223,221,99,205,11,15,139,240,251,32,116,174,144,226,5,145,161,39,62,31,98,131,109,225,55,109,120,143,29,59,235,97,117,230,211,150,16,222,86,255,134,3,254,126,253,252,7,94,154,50,216,2,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("18959618-7987-4279-b581-a64c3683bed3"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,109,107,219,48,16,254,220,64,254,195,145,126,201,96,216,223,87,47,176,188,180,11,165,44,52,101,223,101,251,236,138,202,146,57,73,30,166,236,191,239,100,39,205,226,38,33,33,196,177,239,121,185,231,36,89,139,10,109,45,50,132,23,36,18,214,20,46,90,24,93,200,210,147,112,210,232,232,94,42,92,87,181,33,55,30,189,143,71,55,222,74,93,194,182,181,14,171,187,193,61,83,149,194,44,240,108,244,128,26,73,102,140,97,84,237,83,37,51,144,218,33,21,193,110,221,107,174,180,147,78,162,93,10,39,54,100,26,153,35,49,252,189,35,221,220,18,150,172,5,79,232,94,77,110,191,193,166,147,233,139,113,28,67,98,125,85,9,106,103,251,7,11,133,130,44,228,44,7,5,153,10,230,190,40,144,48,255,207,174,5,39,82,133,144,182,80,247,150,57,36,181,32,81,17,22,160,121,34,223,39,178,131,111,209,90,246,95,231,19,136,63,44,146,120,104,218,147,207,48,103,73,220,149,59,116,99,100,222,245,168,79,244,197,99,152,62,120,6,12,36,190,220,93,8,188,68,133,14,193,168,61,13,112,167,21,93,217,112,33,245,174,139,77,120,202,106,100,239,189,206,206,117,254,75,13,154,126,22,127,194,242,77,3,41,9,1,190,194,80,111,6,231,92,46,134,91,107,139,156,104,16,12,156,129,60,189,54,94,253,97,119,28,232,19,240,13,91,222,190,190,210,167,128,132,206,147,182,92,216,255,11,165,212,24,5,91,209,224,241,64,94,204,114,62,29,134,133,67,35,60,159,149,246,21,82,216,134,73,15,236,173,103,112,232,226,226,100,22,175,152,189,129,104,132,84,221,94,102,26,100,61,143,175,94,187,107,199,115,240,91,4,218,100,246,248,73,233,236,48,158,209,122,229,160,17,74,242,129,195,232,196,112,126,239,106,143,199,54,83,126,17,192,192,122,159,247,22,117,222,159,251,254,30,27,94,120,88,133,223,159,66,231,10,41,89,17,25,122,226,243,33,74,236,10,63,168,228,61,118,234,172,135,213,89,206,59,66,120,91,253,29,143,248,27,62,255,0,236,95,60,53,250,4,0,0 };
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


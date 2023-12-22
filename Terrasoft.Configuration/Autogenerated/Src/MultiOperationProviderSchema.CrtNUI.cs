namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MultiOperationProviderSchema

	/// <exclude/>
	public class MultiOperationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MultiOperationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MultiOperationProviderSchema(MultiOperationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("13cc5a20-1dd4-486f-abc0-6d6d0a98a042");
			Name = "MultiOperationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,83,77,79,220,48,16,61,7,137,255,48,162,151,172,132,178,119,22,144,42,186,69,43,241,165,210,123,148,198,179,193,146,63,194,216,94,26,33,254,59,78,178,78,156,176,160,54,151,196,243,102,230,189,153,60,171,66,162,169,139,18,225,55,18,21,70,111,109,118,165,213,150,87,142,10,203,181,58,62,122,61,62,74,156,225,170,130,199,198,88,148,171,217,217,231,11,129,101,155,108,178,107,84,72,188,252,144,115,195,213,243,24,140,185,164,212,202,35,30,251,70,88,249,38,112,37,10,99,206,224,214,9,203,239,107,236,117,60,144,222,113,134,212,101,46,151,75,56,55,78,202,130,154,203,253,57,36,192,86,19,200,182,182,22,8,58,212,155,44,212,45,163,194,218,253,17,188,132,178,101,252,148,48,121,237,72,7,125,63,57,10,230,5,62,16,223,21,22,123,176,238,15,64,88,48,173,68,3,155,105,187,71,235,223,88,53,144,155,253,215,234,96,153,71,219,13,229,168,44,183,205,157,255,61,135,243,110,184,177,231,215,142,179,75,200,9,75,77,204,108,216,106,47,20,21,235,181,78,133,251,31,235,219,187,210,106,106,229,119,179,239,213,247,123,56,188,129,244,179,81,194,36,167,65,245,40,250,52,22,56,232,91,64,107,166,36,225,91,72,67,49,92,92,128,114,66,4,44,177,79,164,95,64,225,11,124,167,202,73,223,243,206,195,235,191,37,214,45,123,122,18,248,79,22,221,106,146,183,184,167,151,145,109,76,91,113,79,107,89,219,38,29,69,45,254,157,99,61,20,125,100,25,198,153,17,253,71,251,95,161,197,180,123,62,46,5,38,54,73,34,63,120,108,102,142,100,116,128,7,99,55,116,141,191,178,196,45,218,39,205,102,110,152,95,175,46,240,67,143,151,41,27,178,226,203,20,92,180,227,100,93,33,96,167,57,243,101,131,111,210,176,159,97,204,44,70,243,216,61,227,68,139,47,198,232,163,211,160,143,197,207,59,237,18,244,246,225,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("13cc5a20-1dd4-486f-abc0-6d6d0a98a042"));
		}

		#endregion

	}

	#endregion

}


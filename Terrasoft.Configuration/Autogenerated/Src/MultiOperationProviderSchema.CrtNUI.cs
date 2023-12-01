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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,83,219,78,164,64,16,125,198,196,127,168,184,47,76,98,152,119,71,77,54,238,172,153,196,91,214,125,39,44,93,131,157,244,5,251,50,46,49,254,187,5,76,67,131,163,217,229,5,186,78,85,157,83,197,105,85,72,180,117,81,34,252,70,99,10,171,183,46,187,210,106,203,43,111,10,199,181,58,62,122,61,62,74,188,229,170,130,199,198,58,148,171,217,153,242,133,192,178,77,182,217,53,42,52,188,252,144,115,195,213,243,24,140,185,164,212,138,16,194,190,25,172,168,9,92,137,194,218,51,184,245,194,241,251,26,123,29,15,70,239,56,67,211,101,46,151,75,56,183,94,202,194,52,151,251,115,72,128,173,54,32,219,218,90,32,232,80,111,179,80,183,140,10,107,255,71,240,18,202,150,241,83,194,228,181,35,29,244,253,228,40,24,9,124,48,124,87,56,236,193,186,63,128,193,130,105,37,26,216,76,219,61,58,122,99,213,64,110,247,95,171,131,101,132,182,27,202,81,57,238,154,59,250,61,135,243,110,184,117,231,215,158,179,75,200,13,150,218,48,187,97,171,189,80,84,172,215,58,21,78,63,150,218,251,210,105,211,202,239,102,223,171,239,247,112,120,3,233,103,163,132,73,78,131,234,81,244,105,44,112,208,183,128,214,76,73,194,183,144,134,98,184,184,0,229,133,8,88,226,158,140,126,1,133,47,240,221,84,94,82,207,59,130,215,127,75,172,91,246,244,36,240,159,44,186,213,36,111,113,79,146,145,109,108,91,113,111,214,178,118,77,58,138,90,252,59,199,122,40,250,200,50,140,51,35,250,143,246,191,66,139,105,247,124,92,10,76,108,146,68,126,32,108,102,142,100,116,0,129,177,27,186,198,95,89,226,22,221,147,102,51,55,204,175,87,23,248,161,199,203,148,13,89,241,101,10,46,218,113,227,124,33,96,167,57,163,178,193,55,105,216,207,48,102,22,163,121,236,158,113,162,197,23,99,244,209,105,144,98,244,188,3,76,41,206,123,216,4,0,0 };
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


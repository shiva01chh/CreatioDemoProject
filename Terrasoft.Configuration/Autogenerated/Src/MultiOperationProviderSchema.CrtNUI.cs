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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,83,219,78,220,48,16,125,14,18,255,48,162,47,89,9,101,223,89,64,170,232,22,173,196,77,165,239,145,27,207,6,75,190,4,95,150,70,136,127,199,78,214,137,19,22,212,230,37,241,156,153,57,103,38,199,146,8,52,13,169,16,126,163,214,196,168,173,45,174,148,220,178,218,105,98,153,146,199,71,175,199,71,153,51,76,214,240,216,26,139,98,53,59,251,124,206,177,10,201,166,184,70,137,154,85,31,114,110,152,124,30,131,41,151,16,74,122,196,99,223,52,214,190,9,92,113,98,204,25,220,58,110,217,125,131,189,142,7,173,118,140,162,238,50,151,203,37,156,27,39,4,209,237,229,254,28,19,96,171,52,136,80,219,112,4,21,235,77,17,235,150,73,97,227,254,112,86,65,21,24,63,37,204,94,59,210,65,223,79,134,156,122,129,15,154,237,136,197,30,108,250,3,104,36,84,73,222,194,102,218,238,209,250,55,214,45,148,102,255,181,58,88,230,209,176,161,18,165,101,182,189,243,191,231,112,222,13,51,246,252,218,49,122,9,165,198,74,105,106,54,116,181,23,138,146,246,90,167,194,253,143,245,237,93,101,149,14,242,187,217,247,234,251,61,28,222,64,254,217,40,113,146,211,168,122,20,125,154,10,28,244,45,32,152,41,203,216,22,242,88,12,23,23,32,29,231,17,203,236,147,86,47,32,241,5,190,235,218,9,223,243,206,195,235,191,21,54,129,61,63,137,252,39,139,110,53,217,91,218,211,203,40,54,38,84,220,235,181,104,108,155,143,162,22,255,206,177,30,138,62,178,12,227,204,136,254,163,253,175,216,98,218,189,28,151,2,19,155,100,137,31,60,54,51,71,54,58,192,131,169,27,186,198,95,89,226,22,237,147,162,51,55,204,175,87,23,248,161,198,203,84,12,89,233,101,138,46,218,49,109,29,225,176,83,140,250,178,193,55,121,220,207,48,102,145,162,101,234,158,113,162,197,23,99,244,209,105,208,199,194,243,14,1,197,198,77,217,4,0,0 };
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


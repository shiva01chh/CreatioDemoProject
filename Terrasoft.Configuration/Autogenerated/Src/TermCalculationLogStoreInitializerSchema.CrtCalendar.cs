namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermCalculationLogStoreInitializerSchema

	/// <exclude/>
	public class TermCalculationLogStoreInitializerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermCalculationLogStoreInitializerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermCalculationLogStoreInitializerSchema(TermCalculationLogStoreInitializerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("20a2cde7-74b1-4ec7-b8c7-7539f979eab9");
			Name = "TermCalculationLogStoreInitializer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28322dfd-15f8-434e-b343-12da0b1a75f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,91,107,219,48,20,126,118,161,255,65,115,161,56,80,236,247,53,201,30,194,54,2,217,133,118,151,103,197,62,118,4,178,20,36,57,99,43,251,239,59,146,236,248,22,135,210,238,102,12,182,142,206,229,59,231,251,36,65,75,208,123,154,2,249,4,74,81,45,115,19,175,164,200,89,81,41,106,152,20,151,23,15,151,23,65,165,153,40,122,46,10,110,39,236,241,189,241,187,184,159,36,9,153,235,170,44,169,250,190,172,215,107,193,12,163,156,253,0,69,100,78,12,168,146,164,148,167,21,119,5,9,151,133,38,218,230,136,155,12,73,39,197,190,218,114,150,162,3,122,167,36,229,84,107,11,160,92,181,41,54,178,112,24,58,149,48,240,193,33,10,174,20,20,182,204,59,48,59,153,233,151,228,163,98,7,106,192,239,238,253,162,73,63,145,120,35,105,134,232,223,130,241,127,209,103,13,10,199,38,32,117,45,84,233,140,216,177,5,129,2,83,41,65,4,124,59,159,43,194,16,59,208,224,231,73,28,91,41,57,89,107,140,41,112,224,175,5,221,114,200,70,85,123,203,1,130,254,102,124,15,90,227,119,69,211,29,196,95,153,217,109,36,114,96,151,152,63,154,185,72,124,98,108,241,11,229,21,204,45,130,101,52,209,67,220,183,213,248,92,242,247,40,176,155,38,93,144,83,174,97,70,234,245,245,245,16,22,150,91,235,55,64,17,50,52,93,134,227,162,118,8,97,111,94,87,32,50,79,236,20,203,78,54,126,115,168,74,103,192,210,122,160,189,177,248,188,101,79,21,45,137,192,206,22,97,191,129,112,105,57,33,105,219,209,60,113,222,109,176,231,67,47,55,109,169,121,210,24,29,245,61,129,79,76,220,194,117,63,143,19,1,203,73,52,146,207,192,181,241,13,206,139,158,251,207,162,163,254,65,162,91,159,166,22,158,247,127,117,188,21,2,199,89,231,104,84,156,119,153,60,73,78,123,146,255,10,71,221,96,87,41,236,211,213,186,247,201,58,72,150,117,176,54,147,59,207,209,205,36,199,174,92,67,203,239,97,197,10,161,246,125,177,112,179,63,210,238,205,158,39,76,164,91,190,130,39,93,30,232,102,62,168,59,40,229,1,220,29,242,220,219,195,168,10,102,29,5,157,19,204,29,232,63,127,158,79,144,239,234,62,142,247,127,69,236,241,192,253,47,188,58,176,99,94,7,87,58,90,241,197,231,23,251,142,28,176,179,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("20a2cde7-74b1-4ec7-b8c7-7539f979eab9"));
		}

		#endregion

	}

	#endregion

}


﻿namespace Terrasoft.Configuration
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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,219,138,219,48,16,125,118,96,255,65,245,194,226,192,98,191,119,147,244,33,180,37,144,94,216,237,229,89,177,199,142,64,150,130,36,167,180,75,255,189,35,201,142,111,113,88,122,15,1,91,163,209,153,51,115,142,37,104,9,250,64,83,32,31,64,41,170,101,110,226,181,20,57,43,42,69,13,147,226,106,246,120,53,11,42,205,68,209,75,81,112,55,17,143,31,140,223,197,253,36,73,200,66,87,101,73,213,215,85,189,222,8,102,24,229,236,27,40,34,115,98,64,149,36,165,60,173,184,43,72,184,44,52,209,22,35,110,16,146,14,196,161,218,113,150,98,2,102,167,36,229,84,107,75,160,92,183,16,91,89,56,14,157,74,120,240,209,49,10,174,21,20,182,204,27,48,123,153,233,231,228,189,98,71,106,192,239,30,252,162,129,159,0,222,74,154,33,251,215,96,252,91,244,81,131,194,177,9,72,93,11,85,58,39,118,108,65,160,192,84,74,16,1,95,46,99,69,120,196,14,52,248,126,150,199,78,74,78,54,26,207,20,56,240,151,130,238,56,100,163,170,189,229,128,65,127,51,126,0,173,241,185,166,233,30,226,207,204,236,183,18,53,176,75,196,143,230,238,36,254,98,108,241,19,229,21,44,44,131,85,52,209,67,220,143,213,252,28,248,91,52,216,109,3,23,228,148,107,152,147,122,125,115,51,164,133,229,54,250,21,80,164,12,77,151,225,184,168,29,66,216,155,215,53,136,204,11,59,165,178,179,141,223,28,186,210,5,176,180,30,120,111,108,62,31,57,80,69,75,34,176,179,101,216,111,32,92,89,77,72,218,118,180,72,92,118,123,216,235,161,87,219,182,212,34,105,130,78,250,158,193,39,38,110,233,186,151,167,153,128,229,36,26,217,103,144,218,228,6,151,77,207,253,99,217,113,255,0,232,206,195,212,198,243,249,47,78,183,66,224,52,235,124,26,21,231,93,37,207,138,211,126,201,127,69,163,238,97,87,41,236,203,213,166,247,197,58,74,150,117,184,54,147,187,172,209,237,164,198,174,92,35,203,239,81,197,26,161,206,125,182,116,179,63,201,238,195,94,39,4,210,173,94,193,79,93,30,152,102,222,169,123,40,229,17,220,29,242,171,183,135,81,21,204,59,14,186,100,152,123,208,127,254,123,62,35,190,171,251,52,221,255,149,176,167,15,238,127,209,213,145,29,235,58,184,210,49,138,255,217,236,7,86,169,124,195,178,8,0,0 };
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

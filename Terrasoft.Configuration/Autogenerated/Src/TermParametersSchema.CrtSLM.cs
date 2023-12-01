namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermParametersSchema

	/// <exclude/>
	public class TermParametersSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermParametersSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermParametersSchema(TermParametersSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cce52b8e-5cff-471e-bee8-6f28959e4246");
			Name = "TermParameters";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,148,223,107,219,48,16,199,159,99,200,255,112,125,9,27,20,155,61,55,9,140,80,66,41,133,210,116,123,87,229,75,38,144,37,115,39,21,76,217,255,62,89,254,17,59,109,186,101,105,31,12,146,238,123,167,239,231,56,203,179,50,59,216,84,236,176,184,154,38,126,176,77,87,86,107,148,78,89,195,233,26,13,146,146,65,50,77,140,40,144,75,33,17,30,145,72,176,221,186,160,53,91,181,243,36,106,121,186,65,122,86,18,67,184,152,38,47,211,100,146,101,25,204,217,23,133,160,106,217,238,235,40,148,130,66,53,135,196,105,39,203,6,186,210,63,105,37,65,106,193,28,19,238,123,125,136,214,149,39,37,169,103,225,16,216,133,187,37,16,138,220,26,93,129,50,14,238,148,121,84,5,254,48,202,253,20,218,35,44,224,91,68,152,188,114,20,15,86,66,163,201,5,129,202,209,56,181,85,72,105,47,30,250,234,140,173,189,202,251,172,155,28,162,163,201,14,221,85,92,112,187,248,125,244,198,61,15,108,45,5,247,92,134,118,35,228,53,146,20,90,122,221,180,244,93,27,183,88,69,190,123,161,104,222,217,225,180,99,191,172,155,177,132,135,182,120,188,147,207,246,202,86,251,218,218,167,120,221,180,197,255,234,245,168,219,7,116,158,12,131,251,37,220,222,235,126,222,64,80,112,109,137,194,136,31,113,28,79,168,169,179,252,30,228,227,50,220,167,207,179,78,53,0,125,178,86,195,13,175,26,205,24,232,203,215,22,169,201,59,192,77,155,97,93,46,94,13,240,105,212,253,52,157,71,61,200,62,1,120,60,109,135,192,227,232,71,1,187,241,147,242,63,176,135,37,254,145,56,72,222,6,61,222,143,217,236,157,233,8,193,193,179,114,177,136,47,77,122,93,148,174,234,255,210,240,197,206,36,201,31,37,188,232,28,198,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cce52b8e-5cff-471e-bee8-6f28959e4246"));
		}

		#endregion

	}

	#endregion

}


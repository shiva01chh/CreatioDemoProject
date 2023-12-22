namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PRMOrderConstantsSchema

	/// <exclude/>
	public class PRMOrderConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PRMOrderConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PRMOrderConstantsSchema(PRMOrderConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ee3a9e6e-8558-427d-9613-797cab16dcc3");
			Name = "PRMOrderConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0cf4ca6-907d-4eba-86db-4399f9ff6801");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,203,106,195,48,16,69,215,49,248,31,68,186,105,23,142,193,117,243,104,218,46,108,43,93,149,152,54,63,160,216,99,35,176,228,48,26,83,76,232,191,87,145,250,72,32,218,12,186,247,206,97,102,180,80,96,14,162,2,182,3,68,97,250,134,102,121,175,27,217,14,40,72,246,58,12,142,97,48,25,140,212,45,251,24,13,129,90,135,129,85,110,16,90,107,179,188,19,198,60,178,242,253,109,139,53,160,237,53,36,52,25,23,58,12,251,78,86,204,42,100,75,117,138,94,75,78,142,46,253,207,252,181,44,215,17,188,29,199,49,123,50,131,82,2,199,23,47,176,18,165,157,189,147,134,88,41,144,52,160,45,66,229,130,160,237,113,100,178,6,77,178,145,128,179,63,68,124,206,184,28,241,117,144,181,103,158,144,87,137,207,76,195,167,11,222,78,179,162,216,100,60,73,162,100,85,164,81,186,225,60,90,242,98,17,241,135,44,73,87,243,197,124,201,239,167,119,235,159,237,64,215,126,65,247,255,242,103,188,16,173,118,254,190,1,6,114,187,173,157,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee3a9e6e-8558-427d-9613-797cab16dcc3"));
		}

		#endregion

	}

	#endregion

}


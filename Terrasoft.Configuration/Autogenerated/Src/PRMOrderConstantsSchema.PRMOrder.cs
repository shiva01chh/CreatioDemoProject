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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,203,106,195,48,16,69,215,49,248,31,134,116,211,46,28,131,235,230,209,180,93,216,86,186,42,53,109,126,64,177,199,70,96,203,97,36,81,76,232,191,87,150,250,10,68,155,65,247,222,57,204,140,228,61,170,35,175,16,246,72,196,213,208,232,69,62,200,70,180,134,184,22,131,12,131,83,24,204,140,18,178,133,247,81,105,236,183,97,96,149,43,194,214,218,144,119,92,169,123,40,223,94,94,169,70,178,189,74,115,169,149,11,29,205,161,19,21,88,69,219,82,77,209,75,201,217,201,165,255,152,63,150,229,58,130,183,227,56,134,7,101,250,158,211,248,228,5,40,73,216,217,59,161,52,148,156,180,68,178,133,247,57,215,216,14,52,130,168,81,106,209,8,164,197,47,34,254,207,56,31,241,217,136,218,51,39,228,69,226,35,72,252,112,193,235,121,86,20,187,140,37,73,148,108,138,52,74,119,140,69,107,86,172,34,118,151,37,233,102,185,90,174,217,237,252,102,251,189,29,202,218,47,232,254,159,254,140,103,162,213,166,247,5,33,87,114,138,149,1,0,0 };
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


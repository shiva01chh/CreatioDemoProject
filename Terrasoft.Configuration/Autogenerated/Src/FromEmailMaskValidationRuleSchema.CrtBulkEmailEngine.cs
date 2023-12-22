namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FromEmailMaskValidationRuleSchema

	/// <exclude/>
	public class FromEmailMaskValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FromEmailMaskValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FromEmailMaskValidationRuleSchema(FromEmailMaskValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c4a873c4-bfd7-48e3-ac0b-3c4de968c246");
			Name = "FromEmailMaskValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,205,110,219,48,12,62,167,64,223,129,237,128,34,1,10,249,222,38,61,52,91,139,160,203,48,164,91,238,138,77,39,66,100,201,21,229,12,65,209,119,31,37,219,154,231,67,125,144,37,138,252,126,36,202,200,10,169,150,57,194,47,116,78,146,45,189,88,90,83,170,125,227,164,87,214,192,229,197,251,229,197,164,33,101,246,240,122,38,143,21,39,104,141,121,216,37,241,140,6,157,202,239,199,57,223,149,121,227,32,135,191,56,220,7,160,165,150,68,119,0,79,206,86,223,42,169,244,90,210,113,43,181,42,34,209,166,209,24,243,179,44,131,57,53,85,37,221,249,161,91,111,176,118,72,104,60,129,63,32,228,1,10,254,40,127,104,7,199,181,4,182,132,83,130,131,210,58,192,64,67,80,50,35,84,50,119,150,96,119,230,25,29,69,79,148,13,152,234,102,167,85,222,161,127,34,19,238,224,81,18,142,130,12,240,30,13,36,199,107,244,7,91,176,231,159,206,122,62,48,44,218,253,177,195,24,232,208,176,117,200,94,11,236,12,180,250,67,116,160,137,205,136,132,149,141,193,230,181,116,178,2,195,183,187,184,118,152,171,90,241,225,93,63,108,250,105,56,172,93,163,143,45,131,152,103,177,32,214,215,189,88,176,39,238,9,85,32,156,172,42,96,101,60,58,35,117,47,116,186,90,35,145,220,99,2,93,153,210,66,98,155,65,104,156,201,228,36,93,184,151,6,147,122,88,192,51,250,232,97,219,111,36,144,105,2,184,133,53,39,115,79,113,67,146,39,241,191,251,23,60,207,238,35,129,42,97,58,34,184,90,128,105,180,134,155,27,184,234,64,126,123,254,121,133,36,122,3,49,117,84,41,162,32,241,79,219,172,183,49,73,186,196,202,48,144,212,27,126,57,172,12,151,150,143,104,1,83,197,158,59,178,225,150,88,74,147,163,198,226,53,222,41,125,181,76,100,126,88,191,229,135,83,42,44,90,23,31,97,252,232,26,136,51,219,30,138,235,54,58,12,114,100,248,253,5,185,161,150,1,198,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c4a873c4-bfd7-48e3-ac0b-3c4de968c246"));
		}

		#endregion

	}

	#endregion

}

